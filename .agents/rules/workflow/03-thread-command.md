# `hahaha_thread_command` 處理規則

## 適用情境

- `thread_command` 子類別一律繼承 `hahahalib.hahaha_thread_command`。
- `hahaha_thread_command` 適合用在「一次丟多筆命令，由背景佇列逐筆處理」的需求。

## 讀取順序

1. 先讀 `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\thread\hahaha_thread_command.cs`
2. 再讀需求直接相關的 `c_sharp_base/thread/` 子類別

## 實作規則

- thread 物件的建立、`Create()`、`Close()`，集中放在 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs` 管理。
- command code 使用獨立 static class 常數管理。
- command code 命名要能直接表達用途，若有物件參數版本，建議獨立 `*_OBJECT` code。
- parameter class 獨立宣告，不要把多欄位參數直接散落成匿名 `object` 判斷。
- parameter class 欄位一律使用 `public`，讓背景命令與 UI 呼叫端可直接賦值。
- `Handle()` 只做 command routing，不堆大段業務邏輯。
- `Handle()` 內先依 `cmd.Code_` 分流，再把邏輯下沉到對應方法。
- 實際邏輯拆到 `On_Command_xxx()`。
- 若同一個 command 同時接受基本型別與 parameter object，可在 `Handle()` 內先把兩種輸入轉成同一份本地變數，再共用同一個 `On_Command_xxx()`。
- 若同一功能同時支援基本型別與參數物件，可拆成不同 command code，例如一般版與 `*_OBJECT` 版。
- 物件參數傳法要搭配專用 parameter class 與 `On_Command_xxx_Object(...)`。
- `On_Command_xxx_Object(...)` 建議只做 null 檢查、欄位解包與轉呼叫 `On_Command_xxx(...)`，不要再複製主要邏輯。
- 對外呼叫入口用 `Add_Command_xxx(...)` 封裝，不要讓 UI 直接手組 queue 命令。
- `Add_Command_xxx(...)` 內部負責建立 `hahaha_thread_command_command`、設定 `Code_`、`Parameter_`、enqueue、`Event_Run_.Set()`。
- 若同一需求同時提供 `Add_Command_xxx(int value)` 與 `Add_Command_xxx(parameter_)` 兩種入口，兩者都應維持相同 command code 與相同主要處理流程。
- 若支援物件參數傳法，另外提供 `Add_Command_xxx_Object(...)`，並在方法內建立 parameter 物件後再 enqueue。
- `On_Command_xxx_Object(...)` 可只做參數檢查與轉呼叫 `On_Command_xxx(...)`，避免重複邏輯。
- 若 `Add_Command_xxx_Object(...)` 只是把基本型別包成 parameter object，應在方法內完成包裝後再用 `*_OBJECT` command code enqueue。
- 若背景工作需要計時、等待或格式化結果字串，優先沿用 `hahaha_define.cs` 內既有共用物件，例如 `hahaha.Timer_`，不要在 thread 類別內自行 new 新 timer。

## UI 與共用物件

- 若有共用計時、log、設定、全域入口，優先沿用 `hahaha_define.cs` 內既有靜態物件，不要在 thread 類別內各自 new 新實例。
- 若背景執行完要更新 UI，一律透過 `ha.Form_Main_.BeginInvoke(...)` 回 UI thread。
- 若 UI 更新同時涉及主表單與其他子表單，統一在同一次 `BeginInvoke(...)` 內處理。
- UI 更新目標若已統一收斂到 `ha.Form_Main_`，就不要再平行回寫其他測試表單方法。
- `Event_Run_ == null`、parameter 為空、form 已釋放等條件要先檢查，失敗時明確回傳 `-1` 或直接略過 UI 更新。

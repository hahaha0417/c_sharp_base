# `hahaha_thread_pause` 處理規則

## 適用情境

- `thread_pause` 子類別一律繼承 `hahahalib.hahaha_thread_pause`。
- `hahaha_thread_pause` 適合用在「啟用後持續運作，停用後停止」的背景流程。
- 典型用途是輪詢、定時更新、背景監看、持續執行中的狀態工作。

## 讀取順序

1. 先讀 `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\thread\hahaha_thread_pause.cs`
2. 再讀需求直接相關的 `c_sharp_base/thread/` 子類別

## 實作規則

- thread 物件的建立、`Create()`、`Close()`，集中放在 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs` 管理。
- `Enabled()` 用來啟動一次 `Handle()` 執行；若子類別需要持續執行，可在子類別內自行維護 `Is_Enabled_` 之類的旗標。
- 若子類別使用 `Is_Enabled_` 旗標，`Enabled()` 內要先檢查 `Is_Close_` 與目前是否已啟用，避免重複喚醒或關閉後誤啟動。
- `Disabled()` 用來停止後續持續處理；若基底未實作停止邏輯，子類別要自行覆寫。
- `Disabled()` 建議只負責切換停止旗標，讓 `Handle()` 內的 while 條件自然結束。
- `Handle()` 直接寫主要處理流程，不使用 command queue。
- 若需要持續輪詢或週期更新，可在 `Handle()` 內用 `while (!Is_Close_ && Is_Enabled_)` 這類條件迴圈控制生命週期。
- 若要週期執行，間隔控制直接寫在 `Handle()` 內，例如 `Thread.Sleep(1000)`。
- `Enabled()` / `Disabled()` 的啟停旗標由子類別自己負責一致性，不要假設基底已幫你做完整停止控制。
- 若背景流程只是持續產生顯示字串或狀態值，建議在 while 內先產生本地 `result_`，再統一回 UI 更新。

## UI 與共用物件

- 若背景執行完要更新 UI，一律透過 `ha.Form_Main_.BeginInvoke(...)` 回 UI thread。
- 若 pause 型背景流程的主要顯示目標是某個子表單，也可直接對該 form 做 `BeginInvoke(...)`，但仍要先檢查 form 非 null 且未釋放。
- 若 UI 更新同時涉及主表單與其他子表單，統一在同一次 `BeginInvoke(...)` 內處理。
- 若有共用計時、log、設定、全域入口，優先沿用 `hahaha_define.cs` 內既有靜態物件，不要在 thread 類別內各自 new 新實例。
- 若 UI 更新目標已收斂到單一 form 控制項，例如直接更新 `label_timer_result`，就不要再平行建立額外包裝方法。

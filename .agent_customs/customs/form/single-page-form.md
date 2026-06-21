# 單獨頁面 Custom 規則

## 適用範圍

- 本檔適用於單獨頁面、測試頁、功能展示頁、局部操作頁。
- 目前以 `D:\vs\c#\c_sharp_base\c_sharp_base\form\hahaha_form_test.cs` 為參考實作。

## 責任劃分

- 單獨頁面負責單頁功能展示、測試操作、局部 UI 互動，不負責全域關閉流程。
- 單獨頁面是共用物件的使用者，不是共用物件的建立者；需要 thread、timer、setting 時直接取用 `hahaha_define.cs` 內現有物件。

## 實作規則

- `Form_Load` 主要負責初始文字、預設狀態、控制項顯示內容。
- 若頁面是功能展示頁，按鈕事件可直接呼叫 `hahaha_define.cs` 內已建立好的共用靜態物件，例如 `hahaha.Timer_`、`hahaha.Thread_Timer_Test_`、`hahaha.Thread_Pause_Timer_Test_`。
- `FormClosing` 若沒有特別攔截需求，維持 `e.Cancel = false;`。
- 不要在單獨頁面內插入全域關閉流程。

## 設計原則

- 不要把主頁與單獨頁面的責任混在同一個 form 內：主頁處理全域生命週期，單獨頁面處理局部功能。

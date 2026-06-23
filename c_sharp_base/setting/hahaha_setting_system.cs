namespace c_sharp_base
{
    public class hahaha_setting_system
    {
        // 可調整設定：環境根目錄，設定檔、config、log 都會以此路徑為基底。
        public string Dir_Environment { get; set; } = "C:/c_sharp_hahaha_setting/base";
        // 內建設定：設定目錄名稱，由系統固定使用。
        public string Name_Setting { get; set; } = "setting";
        // 內建設定：config 目錄名稱，由系統固定使用。
        public string Name_Config { get; set; } = "config";
        // 內建設定：log 目錄名稱，由系統固定使用。
        public string Name_Log { get; set; } = "log";
        // 內建設定：system 類別名稱，由系統固定使用。
        public string Name_Class { get; set; } = "system";
        // 內建設定：system 設定檔名稱，由系統固定使用。
        public string Name_File { get; set; } = "system.json";
        public hahaha_setting_system()
        {
        }

        
    }
}

using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;

namespace c_sharp_base
{
    public static partial class ha
    {
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static Form? Form_Main = null;

        public static ILogger? Log_Form_Main = null;
        public static hahaha_setting_box? Setting = null;
    }

    public static partial class app
    {
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static string Name_Application = "base";
        public static string Name_Title = "°òÂ¦¬[ºc";
    }
    public static partial class hahaha
    {
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_form_main? Form_Main_ = null;


        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahahalib.hahaha_log Log_ = new hahahalib.hahaha_log();
        public static hahahalib.hahaha_json Json_ = new hahahalib.hahaha_json();


        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_setting_box? Setting_Box_ = null;
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static ILogger? Log_Form_Main_ = null;
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------





        // ---------------------------------------------------------------
        // ¥D­n
        // ---------------------------------------------------------------
        public static int Initial_Environment()
        {
            Setting_Box_ = new hahaha_setting_box();

            if (Setting_Box_.Load_All() != 0)
            {
                Setting_Box_.Save_All();
            }

            ha.Setting = Setting_Box_;

            Log_.Create($"{ha.Setting.System.Dir_Environment}/{ha.Setting.System.Name_Config}/nlog.config");

            Log_Form_Main_ = Log_.Create_Log<hahaha_form_main>();
            ha.Log_Form_Main = Log_Form_Main_;

            

            return 0;

        }


        


        public static int Initial()
        {
            return 0;
        }

        public static int Initial_UI()
        {
            return 0;
        }

        public static int Close()
        {
            return 0;
        }

        

    }    

}
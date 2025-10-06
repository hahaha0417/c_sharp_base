using Microsoft.Extensions.Logging;

namespace c_sharp_base
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // ------------------------------------------
            // 初始化環境
            // ------------------------------------------
            hahaha.Initial_Environment();
            hahaha_form_main form_main_ = new hahaha_form_main();
            hahaha.Form_Main_ = form_main_;
            ha.Form_Main = form_main_;
            ha.Log_Form_Main!.LogDebug("初始化環境");
            // ------------------------------------------
            // 初始化
            // ------------------------------------------
            ha.Log_Form_Main!.LogDebug("初始化");
            hahaha.Initial();
            // ------------------------------------------
            // 初始化 UI
            // ------------------------------------------
            ha.Log_Form_Main!.LogDebug("初始化UI");
            hahaha.Initial_UI();

            // ------------------------------------------
            // 
            // ------------------------------------------
            // ------------------------------------------
            // 
            // ------------------------------------------

            Application.Run(form_main_);
        }
    }
}
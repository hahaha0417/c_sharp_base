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
            // ��l������
            // ------------------------------------------
            hahaha.Initial_Environment();
            hahaha_form_main form_main_ = new hahaha_form_main();
            hahaha.Form_Main_ = form_main_;
            ha.Form_Main = form_main_;
            ha.Log_Form_Main!.LogDebug("��l������");
            // ------------------------------------------
            // ��l��
            // ------------------------------------------
            ha.Log_Form_Main!.LogDebug("��l��");
            hahaha.Initial();
            // ------------------------------------------
            // ��l�� UI
            // ------------------------------------------
            ha.Log_Form_Main!.LogDebug("��l��UI");
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
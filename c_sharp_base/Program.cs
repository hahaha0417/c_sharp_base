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
            ha.Form_Main = form_main_;

            // ------------------------------------------
            // ��l��
            // ------------------------------------------
            hahaha.Initial();
            // ------------------------------------------
            // ��l�� UI
            // ------------------------------------------
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
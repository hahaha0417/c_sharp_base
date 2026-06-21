namespace c_sharp_base
{
    public partial class hahaha_form_test : hahahalib.ui.hahaha_form_base_titlebar
    {
        public hahaha_form_test()
        {
            InitializeComponent();
        }

        private void hahaha_form_test_Load(object sender, EventArgs e)
        {
            label_title.Text = "test";
            label_timer_result.Text = "尚未測量";
            button_timer_pause_enabled.Text = "啟用";
            button_timer_pause_disabled.Text = "禁用";
        }

        private void hahaha_form_test_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void button_timer_test_Click(object sender, EventArgs e)
        {
            hahaha.Timer_.Reset();
            hahaha.Timer_.Start();
            Thread.Sleep(1000);
            hahaha.Timer_.End();

            label_timer_result.Text = $"Sleep 1000 ms, 測量結果 {hahaha.Timer_.Time_Ms():F3} ms";
        }

        private void button_timer_test_thread_Click(object sender, EventArgs e)
        {
            label_timer_result.Text = "背景執行中...";
            hahaha.Thread_Timer_Test_?.Add_Command_Timer(2000);
        }

        private void button_timer_test_object_Click(object sender, EventArgs e)
        {
            label_timer_result.Text = "背景執行中...";
            hahaha.Thread_Timer_Test_?.Add_Command_Timer_Object(3000);
        }

        private void button_timer_pause_enabled_Click(object sender, EventArgs e)
        {
            label_timer_result.Text = "pause timer enabled";
            hahaha.Thread_Pause_Timer_Test_?.Enabled();
        }

        private void button_timer_pause_disabled_Click(object sender, EventArgs e)
        {
            hahaha.Thread_Pause_Timer_Test_?.Disabled();
            label_timer_result.Text = "pause timer disabled";
        }

    }
}

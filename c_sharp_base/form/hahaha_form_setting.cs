namespace c_sharp_base
{
    public partial class hahaha_form_setting : hahahalib.ui.hahaha_form_base_titlebar
    {
        public hahaha_form_setting()
        {
            InitializeComponent();
        }

        private void hahaha_form_setting_Load(object sender, EventArgs e)
        {
            label_title.Text = "設定";
            Setting_Reload_All();
        }

        private void hahaha_form_setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        public int Setting_Reload_All()
        {
            if (hahaha.Setting_Box_ == null)
            {
                return -1;
            }

            textBox_system_dir_environment.Text = hahaha.Setting_Box_.System.Dir_Environment;

            return 0;
        }

        public int Setting_Save_All()
        {
            if (hahaha.Setting_Box_ == null)
            {
                return -1;
            }

            hahaha.Setting_Box_.System.Dir_Environment = textBox_system_dir_environment.Text;

            hahaha.Setting_Box_.Save_All();

            return 0;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Setting_Save_All();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (hahaha.Setting_Box_ == null)
            {
                return;
            }

            hahaha.Setting_Box_.Load_All();
            ha.Setting = hahaha.Setting_Box_;
            Setting_Reload_All();
        }

        private void button_system_dir_environment_browse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog_ = new FolderBrowserDialog();
            dialog_.InitialDirectory = textBox_system_dir_environment.Text;

            if (dialog_.ShowDialog() == DialogResult.OK)
            {
                textBox_system_dir_environment.Text = dialog_.SelectedPath;
            }
        }
    }
}

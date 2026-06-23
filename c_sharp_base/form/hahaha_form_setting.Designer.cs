namespace c_sharp_base
{
    partial class hahaha_form_setting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public hahahalib.ui.Tab_Controll_Base pageControl1;
        public TabPage tabPage_system;
        public TabPage tabPage_global;
        public Panel panel_setting_bottom;
        public Button button_save;
        public Button button_cancel;
        public Panel panel_system_base;
        public Panel panel_global_base;
        public Label label_system_dir_environment;
        public TextBox textBox_system_dir_environment;
        public Button button_system_dir_environment_browse;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageControl1 = new hahahalib.ui.Tab_Controll_Base();
            tabPage_system = new TabPage();
            panel_system_base = new Panel();
            button_system_dir_environment_browse = new Button();
            textBox_system_dir_environment = new TextBox();
            label_system_dir_environment = new Label();
            tabPage_global = new TabPage();
            panel_global_base = new Panel();
            panel_setting_bottom = new Panel();
            button_cancel = new Button();
            button_save = new Button();
            panel_title.SuspendLayout();
            panel_base.SuspendLayout();
            panel_body.SuspendLayout();
            pageControl1.SuspendLayout();
            tabPage_system.SuspendLayout();
            panel_system_base.SuspendLayout();
            tabPage_global.SuspendLayout();
            panel_setting_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // panel_title
            // 
            panel_title.Size = new Size(876, 65);
            // 
            // panel_base
            // 
            panel_base.Size = new Size(876, 664);
            // 
            // panel_body
            // 
            panel_body.Controls.Add(pageControl1);
            panel_body.Controls.Add(panel_setting_bottom);
            panel_body.Size = new Size(876, 599);
            // 
            // panel_title_system
            // 
            panel_title_system.Location = new Point(658, 0);
            // 
            // pageControl1
            // 
            pageControl1.Controls.Add(tabPage_system);
            pageControl1.Controls.Add(tabPage_global);
            pageControl1.Dock = DockStyle.Fill;
            pageControl1.Location = new Point(0, 0);
            pageControl1.Name = "pageControl1";
            pageControl1.SelectedIndex = 0;
            pageControl1.Size = new Size(876, 546);
            pageControl1.TabIndex = 0;
            // 
            // tabPage_system
            // 
            tabPage_system.Controls.Add(panel_system_base);
            tabPage_system.Location = new Point(4, 24);
            tabPage_system.Name = "tabPage_system";
            tabPage_system.Padding = new Padding(3);
            tabPage_system.Size = new Size(868, 518);
            tabPage_system.TabIndex = 0;
            tabPage_system.Text = "系統";
            tabPage_system.UseVisualStyleBackColor = true;
            // 
            // panel_system_base
            // 
            panel_system_base.BackColor = Color.Gainsboro;
            panel_system_base.Controls.Add(button_system_dir_environment_browse);
            panel_system_base.Controls.Add(textBox_system_dir_environment);
            panel_system_base.Controls.Add(label_system_dir_environment);
            panel_system_base.Dock = DockStyle.Fill;
            panel_system_base.Location = new Point(3, 3);
            panel_system_base.Name = "panel_system_base";
            panel_system_base.Size = new Size(862, 512);
            panel_system_base.TabIndex = 0;
            // 
            // button_system_dir_environment_browse
            // 
            button_system_dir_environment_browse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_system_dir_environment_browse.Font = new Font("Microsoft JhengHei UI", 12F);
            button_system_dir_environment_browse.Location = new Point(744, 33);
            button_system_dir_environment_browse.Name = "button_system_dir_environment_browse";
            button_system_dir_environment_browse.Size = new Size(52, 35);
            button_system_dir_environment_browse.TabIndex = 2;
            button_system_dir_environment_browse.Text = "...";
            button_system_dir_environment_browse.UseVisualStyleBackColor = true;
            button_system_dir_environment_browse.Click += button_system_dir_environment_browse_Click;
            // 
            // textBox_system_dir_environment
            // 
            textBox_system_dir_environment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_system_dir_environment.Font = new Font("Microsoft JhengHei UI", 16F);
            textBox_system_dir_environment.Location = new Point(132, 33);
            textBox_system_dir_environment.Name = "textBox_system_dir_environment";
            textBox_system_dir_environment.Size = new Size(592, 35);
            textBox_system_dir_environment.TabIndex = 1;
            // 
            // label_system_dir_environment
            // 
            label_system_dir_environment.AutoSize = true;
            label_system_dir_environment.Font = new Font("Microsoft JhengHei UI", 16F);
            label_system_dir_environment.Location = new Point(26, 36);
            label_system_dir_environment.Name = "label_system_dir_environment";
            label_system_dir_environment.Size = new Size(100, 28);
            label_system_dir_environment.TabIndex = 0;
            label_system_dir_environment.Text = "環境路徑";
            // 
            // tabPage_global
            // 
            tabPage_global.Controls.Add(panel_global_base);
            tabPage_global.Location = new Point(4, 24);
            tabPage_global.Name = "tabPage_global";
            tabPage_global.Padding = new Padding(3);
            tabPage_global.Size = new Size(836, 440);
            tabPage_global.TabIndex = 1;
            tabPage_global.Text = "全域";
            tabPage_global.UseVisualStyleBackColor = true;
            // 
            // panel_global_base
            // 
            panel_global_base.BackColor = Color.Gainsboro;
            panel_global_base.Dock = DockStyle.Fill;
            panel_global_base.Location = new Point(3, 3);
            panel_global_base.Name = "panel_global_base";
            panel_global_base.Size = new Size(830, 434);
            panel_global_base.TabIndex = 0;
            // 
            // panel_setting_bottom
            // 
            panel_setting_bottom.Controls.Add(button_cancel);
            panel_setting_bottom.Controls.Add(button_save);
            panel_setting_bottom.Dock = DockStyle.Bottom;
            panel_setting_bottom.Location = new Point(0, 546);
            panel_setting_bottom.Name = "panel_setting_bottom";
            panel_setting_bottom.Size = new Size(876, 53);
            panel_setting_bottom.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_cancel.Font = new Font("Microsoft JhengHei UI", 12F);
            button_cancel.Location = new Point(745, 10);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(115, 34);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_save.Font = new Font("Microsoft JhengHei UI", 12F);
            button_save.Location = new Point(616, 10);
            button_save.Name = "button_save";
            button_save.Size = new Size(115, 34);
            button_save.TabIndex = 0;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // hahaha_form_setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 684);
            Name = "hahaha_form_setting";
            Text = "hahaha_form_setting";
            FormClosing += hahaha_form_setting_FormClosing;
            Load += hahaha_form_setting_Load;
            panel_title.ResumeLayout(false);
            panel_base.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            pageControl1.ResumeLayout(false);
            tabPage_system.ResumeLayout(false);
            panel_system_base.ResumeLayout(false);
            panel_system_base.PerformLayout();
            tabPage_global.ResumeLayout(false);
            panel_setting_bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}

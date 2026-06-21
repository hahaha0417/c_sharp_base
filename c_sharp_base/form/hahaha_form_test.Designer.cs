namespace c_sharp_base
{
    partial class hahaha_form_test
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private hahahalib.ui.Tab_Controll_Base pageControl1;
        private TabPage tabPage_timer;
        private Panel panel_timer_base;
        private Panel panel_timer;
        public Button button_timer_test;
        public Button button_timer_test_thread;
        public Button button_timer_test_object;
        public Button button_timer_pause_enabled;
        public Button button_timer_pause_disabled;

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
            tabPage_timer = new TabPage();
            panel_timer_base = new Panel();
            panel_timer = new Panel();
            label_timer_result = new Label();
            button_timer_test = new Button();
            button_timer_test_thread = new Button();
            button_timer_test_object = new Button();
            button_timer_pause_enabled = new Button();
            button_timer_pause_disabled = new Button();
            panel_title.SuspendLayout();
            panel_base.SuspendLayout();
            panel_body.SuspendLayout();
            pageControl1.SuspendLayout();
            tabPage_timer.SuspendLayout();
            panel_timer_base.SuspendLayout();
            panel_timer.SuspendLayout();
            SuspendLayout();
            // 
            // panel_title
            // 
            panel_title.Size = new Size(908, 65);
            // 
            // panel_base
            // 
            panel_base.Size = new Size(908, 742);
            // 
            // panel_body
            // 
            panel_body.Controls.Add(pageControl1);
            panel_body.Size = new Size(908, 677);
            // 
            // panel_title_system
            // 
            panel_title_system.Location = new Point(690, 0);
            // 
            // pageControl1
            // 
            pageControl1.Controls.Add(tabPage_timer);
            pageControl1.Dock = DockStyle.Fill;
            pageControl1.Location = new Point(0, 0);
            pageControl1.Name = "pageControl1";
            pageControl1.SelectedIndex = 0;
            pageControl1.Size = new Size(908, 677);
            pageControl1.TabIndex = 0;
            // 
            // tabPage_timer
            // 
            tabPage_timer.Controls.Add(panel_timer_base);
            tabPage_timer.Location = new Point(4, 24);
            tabPage_timer.Name = "tabPage_timer";
            tabPage_timer.Padding = new Padding(3);
            tabPage_timer.Size = new Size(900, 649);
            tabPage_timer.TabIndex = 0;
            tabPage_timer.Text = "timer";
            tabPage_timer.UseVisualStyleBackColor = true;
            // 
            // panel_timer_base
            // 
            panel_timer_base.BackColor = Color.Gainsboro;
            panel_timer_base.Controls.Add(panel_timer);
            panel_timer_base.Dock = DockStyle.Fill;
            panel_timer_base.Location = new Point(3, 3);
            panel_timer_base.Name = "panel_timer_base";
            panel_timer_base.Size = new Size(894, 643);
            panel_timer_base.TabIndex = 0;
            // 
            // panel_timer
            // 
            panel_timer.BackColor = Color.Silver;
            panel_timer.Controls.Add(label_timer_result);
            panel_timer.Controls.Add(button_timer_pause_disabled);
            panel_timer.Controls.Add(button_timer_pause_enabled);
            panel_timer.Controls.Add(button_timer_test_object);
            panel_timer.Controls.Add(button_timer_test_thread);
            panel_timer.Controls.Add(button_timer_test);
            panel_timer.Location = new Point(15, 15);
            panel_timer.Name = "panel_timer";
            panel_timer.Size = new Size(402, 255);
            panel_timer.TabIndex = 0;
            // 
            // label_timer_result
            // 
            label_timer_result.AutoSize = true;
            label_timer_result.Location = new Point(28, 75);
            label_timer_result.Name = "label_timer_result";
            label_timer_result.Size = new Size(55, 15);
            label_timer_result.TabIndex = 1;
            label_timer_result.Text = "尚未測量";
            // 
            // button_timer_test
            // 
            button_timer_test.Location = new Point(23, 24);
            button_timer_test.Name = "button_timer_test";
            button_timer_test.Size = new Size(139, 32);
            button_timer_test.TabIndex = 0;
            button_timer_test.Text = "測試 timer 1000";
            button_timer_test.UseVisualStyleBackColor = true;
            button_timer_test.Click += button_timer_test_Click;
            // 
            // button_timer_test_thread
            // 
            button_timer_test_thread.Location = new Point(184, 24);
            button_timer_test_thread.Name = "button_timer_test_thread";
            button_timer_test_thread.Size = new Size(179, 32);
            button_timer_test_thread.TabIndex = 2;
            button_timer_test_thread.Text = "測試 timer thread 2000";
            button_timer_test_thread.UseVisualStyleBackColor = true;
            button_timer_test_thread.Click += button_timer_test_thread_Click;
            // 
            // button_timer_test_object
            // 
            button_timer_test_object.Location = new Point(23, 109);
            button_timer_test_object.Name = "button_timer_test_object";
            button_timer_test_object.Size = new Size(340, 32);
            button_timer_test_object.TabIndex = 3;
            button_timer_test_object.Text = "測試 timer object 3000";
            button_timer_test_object.UseVisualStyleBackColor = true;
            button_timer_test_object.Click += button_timer_test_object_Click;
            // 
            // button_timer_pause_enabled
            // 
            button_timer_pause_enabled.Location = new Point(23, 159);
            button_timer_pause_enabled.Name = "button_timer_pause_enabled";
            button_timer_pause_enabled.Size = new Size(139, 32);
            button_timer_pause_enabled.TabIndex = 4;
            button_timer_pause_enabled.Text = "啟用";
            button_timer_pause_enabled.UseVisualStyleBackColor = true;
            button_timer_pause_enabled.Click += button_timer_pause_enabled_Click;
            // 
            // button_timer_pause_disabled
            // 
            button_timer_pause_disabled.Location = new Point(184, 159);
            button_timer_pause_disabled.Name = "button_timer_pause_disabled";
            button_timer_pause_disabled.Size = new Size(139, 32);
            button_timer_pause_disabled.TabIndex = 5;
            button_timer_pause_disabled.Text = "禁用";
            button_timer_pause_disabled.UseVisualStyleBackColor = true;
            button_timer_pause_disabled.Click += button_timer_pause_disabled_Click;
            // 
            // hahaha_form_test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 762);
            Name = "hahaha_form_test";
            Text = "hahaha_form_test";
            FormClosing += hahaha_form_test_FormClosing;
            Load += hahaha_form_test_Load;
            panel_title.ResumeLayout(false);
            panel_base.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            pageControl1.ResumeLayout(false);
            tabPage_timer.ResumeLayout(false);
            panel_timer_base.ResumeLayout(false);
            panel_timer.ResumeLayout(false);
            panel_timer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label_timer_result;
    }
}

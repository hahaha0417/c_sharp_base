using System.Threading;

namespace c_sharp_base
{
    public class hahaha_thread_pause_timer_test : hahahalib.hahaha_thread_pause
    {
        public bool Is_Enabled_ = false;

        public override void Enabled()
        {
            if (Is_Close_)
            {
                return;
            }

            if (Is_Enabled_)
            {
                return;
            }

            Is_Enabled_ = true;
            base.Enabled();
        }

        public override void Disabled()
        {
            Is_Enabled_ = false;
        }

        public override void Handle()
        {
            while (!Is_Close_ && Is_Enabled_)
            {
                string result_ = $"pause timer {DateTime.Now:HH:mm:ss}";

                if (hahaha.Form_Test_ != null && !hahaha.Form_Test_.IsDisposed)
                {
                    hahaha.Form_Test_.BeginInvoke(() =>
                    {
                        hahaha.Form_Test_!.label_timer_result.Text = result_;
                    });
                }

                Thread.Sleep(1000);
            }
        }
    }
}

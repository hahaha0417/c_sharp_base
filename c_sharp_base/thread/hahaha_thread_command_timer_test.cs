using System.Threading;

namespace c_sharp_base
{
    public static class hahaha_thread_command_timer_test_command
    {
        public static string COMMAND_SLEEP_MS = "command_sleep_ms";
        public static string COMMAND_SLEEP_MS_OBJECT = "command_sleep_ms_object";
    }

    public class hahaha_thread_command_timer_test_parameter
    {
        public int Sleep_Time_ = 0;
    }

    public class hahaha_thread_command_timer_test : hahahalib.hahaha_thread_command
    {        
        public override int Handle(hahahalib.hahaha_thread_command_command cmd)
        {
            if (cmd.Code_ == hahaha_thread_command_timer_test_command.COMMAND_SLEEP_MS)
            {
                int sleep_time_ = 0;

                if (cmd.Parameter_ is int sleep_time)
                {
                    sleep_time_ = sleep_time;
                }
                else if (cmd.Parameter_ is hahaha_thread_command_timer_test_parameter parameter_)
                {
                    sleep_time_ = parameter_.Sleep_Time_;
                }

                On_Command_Timer(sleep_time_);
            }
            else if (cmd.Code_ == hahaha_thread_command_timer_test_command.COMMAND_SLEEP_MS_OBJECT)
            {
                if (cmd.Parameter_ is hahaha_thread_command_timer_test_parameter parameter_)
                {
                    On_Command_Timer_Object(parameter_);
                }
            }

            return 0;
        }

        public int On_Command_Timer(int sleep_time)
        {
            hahaha.Timer_.Reset();
            hahaha.Timer_.Start();
            Thread.Sleep(sleep_time);
            hahaha.Timer_.End();

            string result_ = $"Sleep {sleep_time} ms, 測量結果 {hahaha.Timer_.Time_Ms():F3} ms";

            if (ha.Form_Main_ != null && !ha.Form_Main_.IsDisposed)
            {
                ha.Form_Main_.BeginInvoke(() =>
                {
                    ha.Form_Main_!.label_title.Text = result_;
                });
            }

            return 0;
        }

        public int On_Command_Timer_Object(hahaha_thread_command_timer_test_parameter parameter_)
        {
            if (parameter_ == null)
            {
                return -1;
            }

            return On_Command_Timer(parameter_.Sleep_Time_);
        }

        public int Add_Command_Timer(int sleep_time)
        {
            if (Event_Run_ == null) return -1;

            hahahalib.hahaha_thread_command_command p = new hahahalib.hahaha_thread_command_command();
            p.Code_ = hahaha_thread_command_timer_test_command.COMMAND_SLEEP_MS;
            p.Parameter_ = sleep_time;

            lock (Lock_)
            {
                Queue_.Enqueue(p);
                // 有命令就喚醒
                Event_Run_.Set();
            }

            return 0;
        }

        public int Add_Command_Timer(hahaha_thread_command_timer_test_parameter parameter_)
        {
            if (Event_Run_ == null) return -1;

            hahahalib.hahaha_thread_command_command p = new hahahalib.hahaha_thread_command_command();
            p.Code_ = hahaha_thread_command_timer_test_command.COMMAND_SLEEP_MS;
            p.Parameter_ = parameter_;

            lock (Lock_)
            {
                Queue_.Enqueue(p);
                Event_Run_.Set();
            }

            return 0;
        }

        public int Add_Command_Timer_Object(int sleep_time)
        {
            if (Event_Run_ == null) return -1;

            hahaha_thread_command_timer_test_parameter parameter_ = new hahaha_thread_command_timer_test_parameter();
            parameter_.Sleep_Time_ = sleep_time;

            hahahalib.hahaha_thread_command_command p = new hahahalib.hahaha_thread_command_command();
            p.Code_ = hahaha_thread_command_timer_test_command.COMMAND_SLEEP_MS_OBJECT;
            p.Parameter_ = parameter_;

            lock (Lock_)
            {
                Queue_.Enqueue(p);
                Event_Run_.Set();
            }

            return 0;
        }
    }
}

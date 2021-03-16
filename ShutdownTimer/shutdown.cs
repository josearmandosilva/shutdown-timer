using System;
using System.Windows.Forms;
using System.Threading;

namespace ShutdownTimer
{
    public partial class Shutdown : Form
    {
        public Shutdown()
        {
            InitializeComponent();
        }

        private void hour_only_pick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void input_hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isNumberOrBackDel(e.KeyChar);
        }

        private void input_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isNumberOrBackDel(e.KeyChar);
        }

        private void input_sec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isNumberOrBackDel(e.KeyChar);
        }

        private bool isNumberOrBackDel(char c)
        {
            return (c != '\b' && !char.IsNumber(c)) ? true : false;
        }

        // 1 CAMPO
        private void btn_desligarDayHour_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateTimePicker.Value.ToString());
            DateTime dataSistema = DateTime.Now;

            int result = DateTime.Compare(dataSistema, data);
            if (result != -1)
            {
                MessageBox.Show("Inserted date needs to be bigger than the current date!");
                return;
            }
            desligarDaquiA((int)(data - dataSistema).TotalSeconds);
        }

        // 2 CAMPO
        private void btn_desligarHour_Click(object sender, EventArgs e)
        {
            //Obtain current day time
            DateTime dataSistema = DateTime.Now;

            //Field date
            DateTime data = Convert.ToDateTime(hour_only_pick.Value.ToString());

            //Compare the difference
            int result = DateTime.Compare(dataSistema, data);
            if (result != -1)
            {
                MessageBox.Show("Inserted date needs to be bigger than the current date!");
                return;
            }

            desligarDaquiA((int)(data - dataSistema).TotalSeconds);
        }

        // 3 CAMPO
        private void btn_desligarToHour_Click(object sender, EventArgs e)
        {

            int horas = int.Parse(string.IsNullOrEmpty(input_hour.Text.ToString()) ? "0" : input_hour.Text.ToString());
            int minutos = int.Parse(string.IsNullOrEmpty(input_min.Text.ToString()) ? "0" : input_min.Text.ToString());
            int segundos = int.Parse(string.IsNullOrEmpty(input_sec.Text.ToString()) ? "0" : input_sec.Text.ToString());

            if (horas == 0 && minutos == 0 && segundos == 0)
            {
                MessageBox.Show("You didn't insert a valid date or none at all!");
                return;
            }

            DateTime dataSistema = DateTime.Now;

            DateTime data = dataSistema;
            data = data.AddHours(horas);
            data = data.AddMinutes(minutos);
            data = data.AddSeconds(segundos);

            int result = DateTime.Compare(dataSistema, data);
            if (result != -1)
            {
                MessageBox.Show("Inserted date needs to be bigger than the current date!");
                return;
            }

            desligarDaquiA((int)(data - dataSistema).TotalSeconds);

        }

        private void desligarDaquiA(int seconds)
        {
            reset_shutdown();
            ExecuteCommandAsync("shutdown -s -f -t " + seconds);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset_shutdown();
        }

        private void reset_shutdown()
        {
            ExecuteCommandAsync("shutdown -a");
        }

        public void ExecuteCommandAsync(string command)
        {
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException objException)
            {
                // Log the exception
            }
            catch (ThreadAbortException objException)
            {
                // Log the exception
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }

        public void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
    }
}

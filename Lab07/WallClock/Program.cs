using System;
using System.Windows.Forms;

namespace WallClockApp
{
    public class WallClockForm : Form
    {
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer clockTimer;

        public WallClockForm()
        {
            // Initialize components
            lblTime = new Label();
            lblDate = new Label();
            clockTimer = new System.Windows.Forms.Timer();

            // Form settings
            this.Text = "Wall Clock";
            this.Size = new System.Drawing.Size(400, 200);

            // Time Label
            lblTime.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
            lblTime.Location = new System.Drawing.Point(50, 20);
            lblTime.AutoSize = true;
            this.Controls.Add(lblTime);

            // Date Label
            lblDate.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
            lblDate.Location = new System.Drawing.Point(50, 80);
            lblDate.AutoSize = true;
            this.Controls.Add(lblDate);

            // Timer settings
            clockTimer.Interval = 1000; // 1 second interval
            clockTimer.Tick += new EventHandler(ClockTimer_Tick);
            clockTimer.Start();

            // Update the time and date immediately upon form load
            UpdateTimeAndDate();
        }

        // Event handler for Timer tick
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndDate();
        }

        // Method to update time and date
        private void UpdateTimeAndDate()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WallClockForm());
        }
    }
}

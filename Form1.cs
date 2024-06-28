using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool git = true;
        Process process = new Process();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (git){
                pictureBox1.Image = Image.FromFile("../../../Resources/guzik2.png");
                label1.ForeColor = Color.LimeGreen;
                process = Process.Start("../../../run.bat");
                git = false;
            } else
            {
                pictureBox1.Image = Image.FromFile("../../../Resources/guzik.png");
                label1.ForeColor = Color.OrangeRed;
                process.CloseMainWindow();
                git = true;
            }
        }
    }
}

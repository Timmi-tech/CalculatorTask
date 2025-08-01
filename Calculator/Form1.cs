using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Center the panel in the form
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string value = btn.Text;

            if (txtDisplay.Text == "0" || txtDisplay.Text == "Error")
                txtDisplay.Text = value;
            else
                txtDisplay.Text += value;
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtDisplay.Text, null);

                // Convert to double for better validation
                if (double.TryParse(result.ToString(), out double numericResult))
                {
                    if (double.IsInfinity(numericResult) || double.IsNaN(numericResult))
                    {
                        txtDisplay.Text = "Error";
                    }
                    else
                    {
                        txtDisplay.Text = numericResult.ToString();
                    }
                }
                else
                {
                    txtDisplay.Text = "Error";
                }
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }
        private void BtnPM_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
                txtDisplay.Text = (-value).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

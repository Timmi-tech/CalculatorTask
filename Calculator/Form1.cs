using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                txtDisplay.Text = result.ToString();
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
        }
    }
}

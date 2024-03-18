namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal ConvCoeficient = 1.95583m;

            decimal amountEUR = bgnValue.Value / ConvCoeficient;

            ResultLabel.Text = $"{bgnValue.Value} BGN = {amountEUR:F2} EUR";
        }
    }
}

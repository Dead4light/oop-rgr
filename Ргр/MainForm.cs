using System;
using System.Windows.Forms;

namespace BigIntApp
{
    public partial class MainForm : Form
    {
        private BigInt bigInt;

        public MainForm()
        {
            InitializeComponent();
            bigInt = new BigInt();
        }

        private void btnAddDigit_Click(object sender, EventArgs e)
        {
            try
            {
                char digit = txtDigit.Text[0];
                bigInt.AddDigit(digit);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetDigit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtIndex.Text);
                char digit = txtNewDigit.Text[0];
                bigInt.SetDigit(index, digit);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDisplay()
        {
            lblBigInt.Text = "BigInt: " + bigInt.ToString();
        }
    }
}

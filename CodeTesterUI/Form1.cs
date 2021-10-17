using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace CodeTesterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnFirst.MouseLeave += BtnFirst_MouseLeave;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbOriginalText.Text = "long long long long long long text";
        }

        private void btnFirst_MouseEnter(object sender, EventArgs e)
        {
            btnFirst.BackColor = Color.Blue;
        }

        private void BtnFirst_MouseLeave(object sender, EventArgs e)
        {
            btnFirst.BackColor = Color.Orange;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var originalText = tbOriginalText.Text;
            int key = Convert.ToInt32(tbKey.Text);

            var encodedText = CeasarLogic.EncodeCeasar(originalText, key);

            tbEncodedText.Text = encodedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnFirst.ResetBackColor();
        }
    }
}

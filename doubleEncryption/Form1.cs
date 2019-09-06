using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doubleEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(750, 300);
            InitializeComponent();
        }

        //암호화 창 여는 함수
        private void encryptionBtn_Click(object sender, EventArgs e)
        {
            FormEncryption encryptionF = new FormEncryption();
            encryptionF.StartPosition = FormStartPosition.Manual;
            encryptionF.Location = new Point(400, 300);
            encryptionF.Show();
        }

        //복호화 창 여는 함수
        private void decyptionBtn_Click(object sender, EventArgs e)
        {
            FormDecryption decryptionF = new FormDecryption();
            decryptionF.StartPosition = FormStartPosition.Manual;
            decryptionF.Location = new Point(1100, 300);
            decryptionF.Show();
        }

        //종료버튼 함수
        private void overBtn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Close();
        }

    }
}

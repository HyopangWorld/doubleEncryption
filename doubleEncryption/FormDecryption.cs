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
    public partial class FormDecryption : Form
    {
        public FormDecryption()
        {
            InitializeComponent();
        }

        private void FormDecryption_Load(object sender, EventArgs e)
        {

        }

        //암호화 버튼 누르면 실행
        private void decryptionBtn_Click(object sender, EventArgs e)
        {
            string encryption = null, enKey = null;
            encryption = encryptionTxt.Text;
            enKey = textBox1.Text;

            if (encryption == "")
            {
                MessageBox.Show("암호문을 입력해 주세요.");
                return;
            }
            else if (enKey == "")
            {
                MessageBox.Show("암호키를 입력해 주세요.");
                return;
            }

            //암호화 객체 호출
            Dencryption den = new Dencryption(encryption, enKey);

            // 결과값을 가져오는 함수
            resultDeL.Text = den.GetResult();
        }
    }
}

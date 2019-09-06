using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//암호화 Form 클래스
namespace doubleEncryption
{
    public partial class FormEncryption : Form
    {
        public FormEncryption()
        {
            InitializeComponent();
        }


        //암호화 버튼 누르면 실행되는 이벤트
        private void encryptionBtn_Click(object sender, EventArgs e)
        {
            string plain = null, enKey = null;
            plain = plainTxt.Text;
            enKey = keyEnTxt.Text;

            if (plain == "") 
            { 
                MessageBox.Show("평문을 입력해 주세요.");
                return;
            } else if (enKey == ""){
                MessageBox.Show("암호키를 입력해 주세요.");
                return;
            }

            //암호화 객체 호출
            Encryption en = new Encryption(plain, enKey);
            // 결과값을 가져오는 함수
            resultEnL.Text = en.GetResult();
        }


        private void saveEnBtn_Click(object sender, EventArgs e){ }
        private void FormEncryption_Load(object sender, EventArgs e) { }
        private void plainTxt_TextChanged(object sender, EventArgs e) { }

    }
}

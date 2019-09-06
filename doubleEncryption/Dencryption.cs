using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleEncryption
{
    class Dencryption
    {
        private string encryption, key;
        private string result = null;


        //생성자함수
        public Dencryption(string encryption, string key)
        {
            this.encryption = encryption;
            this.key = key;
            ToDencryption();
        }

        
        //복호화 하는 함수
        public void ToDencryption()
        {
            //여러가지 연산 함수가 들어있는 클래스
            Deduplication dd = new Deduplication();

            // [key 중복제거]
            char[] keyResult = dd.KeyDeduplication(key);
            this.result += "암호키:" + new string(keyResult) + "\n\n";

            // [key로 2차원 암호판 생성]
            char[,] dencryptionBoard = dd.CreateBoard(keyResult);

            // [문자열 공백제거]
            string encryptionText = this.encryption.Replace(" ", ""); // 평문 공백제거
            char[] xEncryption = (encryptionText.ToLower()).ToCharArray(); // 모두 소문자로 전환, 평문 문자열로 전환
            
            // [복호화 하기]
            int irow=999, icol=999, iirow=999, iicol=999;
            char[] resultEn = new char[xEncryption.Length];
            //복호판에서 해당 문자 찾기
            for (int i = 0; i < resultEn.Length; i += 2)
            {
                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        if (xEncryption[i] == dencryptionBoard[row, col])
                        {
                            icol = col; irow = row;
                        }
                        if (xEncryption[i + 1] == dencryptionBoard[row, col])
                        {
                            iicol = col; iirow = row;
                        }
                    }
                }
                //복호화
                if (icol == iicol || irow == iirow) 
                {
                    if (icol == iicol) { //같은 열처리
                        if (irow < 1) { irow = 5; }
                        if (iirow < 1) { iirow = 5; }
                        irow--; iirow--;
                        resultEn[i] = dencryptionBoard[irow, icol];
                        resultEn[i+1] = dencryptionBoard[iirow, iicol];
                    }
                    else if (irow == iirow) { //같은 행처리
                        if (icol < 1) { icol = 5; }
                        if (iicol < 1) { iicol = 5; }
                        icol--; iicol--;
                        resultEn[i] = dencryptionBoard[irow, icol];
                        resultEn[i + 1] = dencryptionBoard[iirow, iicol];
                    }
                }
                else
                {
                    resultEn[i+1] = dencryptionBoard[irow, iicol];
                    resultEn[i] = dencryptionBoard[iirow, icol];
                }
            }

            this.result += "복호문:" + new string(resultEn);
        }


        // 결과값을 반환하는 메서드
        public string GetResult()
        {
            return this.result;
        }
    }
}

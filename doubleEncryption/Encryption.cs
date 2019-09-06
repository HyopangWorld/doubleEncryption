using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//암호화를 수행하는 클래스
namespace doubleEncryption
{
    class Encryption
    {
        private string plain, key;
        private string result = null;


        //생성자함수
        public Encryption(string plain, string key)
        {
            this.plain = plain;
            this.key = key;
            ToEncryption();
        }

        
        //암호화 하는 함수
        public void ToEncryption()
        {
            //여러가지 연산 함수가 들어있는 클래스
            Deduplication dd = new Deduplication();

            // [key 중복제거]
            char[] keyResult = dd.KeyDeduplication(key);
            this.result += "암호키:" + new string(keyResult)+"\n\n";

            // [key로 2차원 암호판 생성]
            char[,] encryptionBoard = dd.CreateBoard(keyResult);

            // [문자열에 x 추가하기]
            string plainText = this.plain.Replace(" ", ""); // 평문 공백제거
            char[] spaceText = (plainText.ToLower()).ToCharArray(); // 모두 소문자로 전환, 평문 문자열로 전환
            char[] xPlain = dd.AddX(spaceText); // 평문에 x 추가하기 함수 호출
            this.result += " 평문+x :" + new string(xPlain) + "\n\n";
            
            // [암호화 하기]
            // row 가로, col 세로, irow 첫번째 숫자 가로, icol 첫번째 숫자 세로, iirow&iicol은 두번째 숫자
            int irow=999, icol=999, iirow=999, iicol=999;
            char[] resultEn = new char[xPlain.Length];
            //암호판에서 해당 문자 찾기
            for (int i = 0; i < resultEn.Length; i += 2)
            {
                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        if (xPlain[i] == encryptionBoard[row,col])
                        {
                            icol = col; irow = row;
                        }
                        if (xPlain[i + 1] == encryptionBoard[row, col])
                        {
                            iicol = col; iirow = row;
                        }
                    }
                }
                //암호화
                if (icol == iicol || irow == iirow)
                {
                    if (icol == iicol) //같은 열처리
                    {
                        if (irow > 3) { irow = -1; }
                        if (iirow > 3) { iirow = -1; }
                        irow++; iirow++;
                        resultEn[i] = encryptionBoard[irow, icol];
                        resultEn[i + 1] = encryptionBoard[iirow, iicol];
                    }
                    else if (irow == iirow) //같은 행처리
                    {
                        if (icol > 3) { icol = -1; }
                        if (iicol > 3) { iicol = -1; }
                        icol++; iicol++;
                        resultEn[i] = encryptionBoard[irow, icol];
                        resultEn[i + 1] = encryptionBoard[iirow, iicol];
                    }
                }
                else
                {
                    resultEn[i] = encryptionBoard[iirow, icol];
                    resultEn[i + 1] = encryptionBoard[irow, iicol];
                }
            }

            this.result += "암호문:"+ new string(resultEn);
        }


        // 결과값을 반환하는 메서드
        public string GetResult()
        {
            return this.result;
        }
    }
}

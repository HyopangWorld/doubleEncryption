using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//여러가지 함수가 들어있는 클래스
namespace doubleEncryption
{
    class Deduplication
    {
        //key값 중복제거 함수
        public char[] KeyDeduplication(string key)
        {
            //z를 q로 바꿔주기
            for (int b = 0; b < key.Length; b++)
            {
                char[] k = key.ToCharArray();
                if (k[b] == 'z') { k[b] = 'q'; }
                key = new string(k);
            }

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (i != j) {
                        if (key.Substring(i, 1).Equals(key.Substring(j, 1))) { 
                         key = key.Remove(j, 1);
                         j--;
                        }
                    }
                }
            }
            return key.ToCharArray();
        }


        //암호판을 만드는 함수
        public char[,] CreateBoard(char[] key)
        {
            char[,] result = new char[5, 5] { { '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0' } };
            int cnt = 0;
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y'}; //q는 z와 같은 자리
            
            //key를 먼저 집어넣고
            for (int i = 0 ; i < 5; i++)
            {
                for (int j=0 ; j < 5; j++)
                {
                    if (cnt < key.Length) 
                    {
                        result[i, j] = key[cnt]; cnt++;
                    }
                }
            }

            //key에 있는 알파벳은 제외시키고
            int c = 0;
            for (; c < alphabet.Length; c++ )
            {
                for (int k = 0; k < key.Length; k++)
                {
                    if (alphabet[c] == key[k])
                    {
                        alphabet[c] = '0';
                    }
                }
            }

            //배열에 넣기
            int ii = (key.Length/5), jj = (key.Length%5);
            for (c = 0; c < alphabet.Length; c++)
            {
                if (alphabet[c] == '0')
                {
                    continue;
                }
                result[ii, jj] = alphabet[c];
                if(jj < 4){jj++;}
                else if(ii < 5 && jj == 4) { ii++; jj = 0; }
            }
                return result;
        }


        //평문에 x를 추가하는 함수
        public char[] AddX(char[] text)
        {
            char[,] plain2 = new char[(text.Length * 2) + 1, 2];
            char[] xPlain = new char[(text.Length * 2)];

            //0. xPlain '0'으로 초기화 시키기
            for (int b = 0; b < xPlain.Length; b++) { xPlain[b] = '0'; }

            //1.평문 2개 씩 나누기, 나머지는 0으로 채우기
            int cnt = 0;
            for (int i = 0; i < ((plain2.Length) / 2); i++)
            {
                if (cnt >= text.Length)
                {
                    plain2[i, 0] = '0';
                    plain2[i, 1] = '0';
                }
                else
                {
                    if (text[cnt] == 'z') { text[cnt] = 'q'; } //z는 q와 같이
                    plain2[i, 0] = text[cnt]; cnt++;
                    if (cnt == text.Length) { plain2[i, 1] = '0'; continue; };
                    plain2[i, 1] = text[cnt]; cnt++;
                }
            }

            //2. x집어 넣기
            cnt = 0;
            char tmp0, tmp1;
            for (int i = 0; i < ((plain2.Length) / 2); i++)
            {
                //마지막 문자 처리
                if (plain2[i, 0] == '0') { break; }
                else if (plain2[i, 0] != '0' && plain2[i, 1] == '0')
                {
                    xPlain[cnt] = plain2[i, 0]; cnt++;
                    xPlain[cnt] = 'x';
                    break;
                }

                // x넣기
                if (plain2[i, 0] == plain2[i, 1])
                {
                    xPlain[cnt] = plain2[i, 0]; cnt++;
                    xPlain[cnt] = 'x'; cnt++;
                    tmp1 = plain2[i, 1];
                    //x가 추가되면 문자가 하나씩 뒤로 밀리게
                    for (int k = i; k < (((plain2.Length) / 2) - 1); k++)
                    {
                        int a = k + 1;
                        tmp0 = plain2[a, 0];
                        plain2[a, 0] = tmp1;
                        tmp1 = plain2[a, 1];
                        plain2[a, 1] = tmp0;
                    }
                }
                else
                {
                    xPlain[cnt] = plain2[i, 0]; cnt++;
                    xPlain[cnt] = plain2[i, 1]; cnt++;
                }
            }

            //3.xPlain 뒤에 남은 배열 제거하기
            int index = Array.IndexOf(xPlain, '0', 0, (xPlain.Length - 1));
            string xP = new string(xPlain);
            char[] xResult = xPlain;
            if (index != -1)
            {
                xResult = xP.Remove(index).ToCharArray();
            }

            return xResult;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180912
{
    class Program
    {
        static void Main(string[] args)
        {
            //将字符串s1中所有出现在字符串s2中的字符删去
            string s1 = "aaabbccabfcabcc";
            string s2 = "abcd";


            //借助List来解决问题
            //List<string> letterList = new List<string>();
            List<char> charList = new List<char>();
            char[] letter = s1.ToCharArray();
            for (int i = 0; i < letter.Length; i++)
            {
                if(charList.Contains(letter[i]))//改变大小写的方法 区分string和char
                {
                    //char newChar = char.ToUpper(letter[i]); 字符提供了静态的方法
                    continue;
                }
                else
                {
                    //letterList.Add(letter[i].ToString());//list 的属性是string，所以无法添加char，改变list的属性
                    charList.Add(letter[i]);
                }
            }

            //foreach (var item in charList)
            //{
            //    Console.Write(item + " " );
            //}

            //string result = "";
            List<char> resultList = new List<char>();
            char[] result = s2.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            //foreach (var resultItem in result)
            {
                foreach (var item in charList)
                {
                    if (result[i] == item)
                    {
                        i++;
                        break;
                    }
                    else
                    {
                        //不能在这里添加
                        //if (resultList.Contains(result[i]))
                        //{
                        //    continue;
                        //}
                        //else
                        //{
                        //    resultList.Add(result[i]);
                        //}

                    }
                }
            }
            {
                

            }
            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }
            //foreach (var item in charList)
            //{
            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        if(result[i] == item)
            //        {
            //            continue;
            //        }
            //        else
            //        {

            //        }

            //        //if (s2.Contains(item))
            //        //{
            //        //    //remove方法的使用
            //        //    //result = s2.Remove(item); 错误

            //        //}
            //    }
                
            //}
            //Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}

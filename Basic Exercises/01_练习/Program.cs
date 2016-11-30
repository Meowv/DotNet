using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 交换两个变量
            //int n1 = 10, n2 = 20;

            //int tmp = n1;
            //n1 = n2;
            //n2 = tmp;

            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;
            #endregion

            #region 用方法来实现,两个变量交换
            //int n1 = 10, n2 = 20;

            //Swap(ref n1, ref n2);
            #endregion

            #region 请用户输入一个字符串，计算字符串中的字符个数，并输出
            //Console.WriteLine("请输入一个字符串：");
            //string msg = Console.ReadLine();
            //Console.WriteLine("字符的长度是：{0}", msg.Length);
            #endregion

            #region 用方法来实现：计算两个数的最大值
            //Console.WriteLine("请输入两个值：");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int max = GetMaxNumber(num1, num2);

            //可变参数
            //int max = GetMaxNumbers(1, 2, 3, 4, 5);
            //Console.WriteLine("最大值是：{0}", max);
            #endregion

            #region 用方法来实现：计算1-100之间的所有整数的和
            //int sum = GetSum();
            //Console.WriteLine(sum);
            #endregion

            #region 用方法来实现：计算1-100之间的所有奇数的和
            //int sum = GetOddSum();
            //Console.WriteLine(sum);
            #endregion

            #region 用方法来实现：判断一个给定的整数是否为"质数"
            //while (true)
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsZhiShu(number);
            //    Console.WriteLine(b);
            //}
            #endregion

            #region 用方法来实现：计算1-100之间的所有质数（素数）的和
            //int sum = GetZhiShuSum();
            //Console.WriteLine(sum);
            #endregion

            #region 用方法来实现：有一个整数数组,找出其中最大值，并输出
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //int maxValue = GetMaxFromArray(arrInt);
            //Console.WriteLine(maxValue);
            #endregion

            #region 用方法来实现：有一个字符串数组,请输出最长的字符串
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string maxName = GetMaxName(names);
            //Console.WriteLine(maxName);
            #endregion

            #region 用方法来实现：请计算出一个整型数组的平均值
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10, 9 };
            //double avg = GetAvg(arrInt);
            //Console.WriteLine(avg);
            #endregion

            #region 请通过冒泡排序法对整数数组实现升序排序
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //for (int i = 0; i < arrInt.Length - 1; i++)
            //{
            //    for (int j = arrInt.Length - 1; j > i; j--)
            //    {
            //        if (arrInt[j] > arrInt[j - 1])
            //        {
            //            int tmp = arrInt[j];
            //            arrInt[j] = arrInt[j - 1];
            //            arrInt[j - 1] = tmp;
            //        }
            //    }
            //}
            //for (int n = 0; n < arrInt.Length; n++)
            //{
            //    Console.WriteLine(arrInt[n]);
            //}
            #endregion

            #region 统计次数以及出点的索引位置
            //需求：①请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。②扩展（*）：统计出每个字符的出现次数
            //string msg = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            //记录“咳嗽”出现的次数
            //int count = 0;
            //int index = 0;
            //while ((index = msg.IndexOf("咳嗽", index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现【咳嗽】的索引位置为：{1}", count, index);
            //    index = index + "咳嗽".Length;
            //}
            //Console.WriteLine("【咳嗽】总共出现了{0}次", count);

            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    if (!dict.ContainsKey(msg[i]))
            //    {
            //        dict.Add(msg[i], 1);
            //    }
            //    else
            //    {
            //        dict[msg[i]]++;
            //    }
            //}
            //foreach (KeyValuePair<char,int> item in dict)
            //{
            //    Console.WriteLine("字符{0}出现了{1}次", item.Key, item.Value);
            //}
            #endregion

            #region 将字符串两端空格去掉，并且将其中的所有其他空格都替换成一个空格
            //字符串："  hello      world,你  好 世界   !    "
            //输出："hello world,你 好 世界 !"
            //string msg = "  hello      world,你  好 世界   !    ";
            //msg = msg.Trim();//去掉两边空格
            //string[] words = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //msg = string.Join(" ", words);
            //Console.WriteLine(msg);
            #endregion

            #region 制作一个控制台小程序。
            //要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名。统计姓王同学的个数
            //string name = string.Empty;
            //int count = 0;
            //List<string> list = new List<string>();
            //do
            //{
            //    Console.WriteLine("请输入姓名：");
            //    name = Console.ReadLine();
            //    if (name.IndexOf('王') == 0)
            //    {
            //        count++;
            //    }
            //    list.Add(name);
            //} while (name.ToLower() != "quit");

            //除去集合中最后一个元素
            //list.RemoveAt(list.Count - 1);

            //Console.WriteLine("学生个数：{0}", list.Count);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("姓王个数：{0}", count);
            #endregion

            #region 将普通日期格式：“2016年1月2日” 转换成汉字日期格式：“二零一六年一月二日”
            //暂时不考虑10日、13日、23日等“带十”的问题
            //string msg = "2016年1月2日";
            //msg = ConvertToDate(msg);
            //Console.WriteLine(msg);
            #endregion

            #region 将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。
            //string[] msg = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Reverse(msg);
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    Console.WriteLine(msg[i]);
            //}
            #endregion
        }

        private static void Reverse(string[] msg)
        {
            for (int i = 0; i < msg.Length/2; i++)
            {
                string tmp = msg[i];
                msg[i] = msg[msg.Length - 1 - i];
                msg[msg.Length - 1 - i] = tmp;
            }
        }

        private static string ConvertToDate(string msg)
        {
            char[] chs = msg.ToCharArray();
            #region 循环修改字符
            for (int i = 0; i < chs.Length; i++)
            {
                switch (chs[i])
                {
                    case '0':
                        chs[i] = '零';
                        break;
                    case '1':
                        chs[i] = '一';
                        break;
                    case '2':
                        chs[i] = '二';
                        break;
                    case '3':
                        chs[i] = '三';
                        break;
                    case '4':
                        chs[i] = '四';
                        break;
                    case '5':
                        chs[i] = '五';
                        break;
                    case '6':
                        chs[i] = '六';
                        break;
                    case '7':
                        chs[i] = '七';
                        break;
                    case '8':
                        chs[i] = '八';
                        break;
                    case '9':
                        chs[i] = '九';
                        break;
                    default:
                        break;
                }
            }
            #endregion
            //把一个char数组转换成字符串
            return new string(chs);
        }

        private static double GetAvg(int[] arrInt)
        {
            int sum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                sum += arrInt[i];
            }
            //保留两位小数
            return Math.Round(sum / (double)arrInt.Length, 2);
        }

        private static string GetMaxName(string[] names)
        {
            string maxName = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                if (names[i].Length > maxName.Length)
                {
                    maxName = names[i];
                }
            }
            return maxName;
        }

        private static int GetMaxFromArray(int[] arrInt)
        {
            int max = arrInt[0];
            for (int i = 1; i < arrInt.Length; i++)
            {
                if (arrInt[i] > max)
                {
                    max = arrInt[i];
                }
            }
            return max;
        }

        private static int GetZhiShuSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsZhiShu(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static bool IsZhiShu(int number)
        {
            //开方 Math.Sqrt

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetOddSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)//偶数i % 2 == 0
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int GetSum()
        {
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                result += i;
            }
            return result;
        }

        private static int GetMaxNumbers(params int[] pms)
        {
            int max = pms[0];
            for (int i = 1; i < pms.Length; i++)
            {
                if (pms[i] > max)
                {
                    max = pms[i];
                }
            }
            return max;
        }

        private static int GetMaxNumber(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }

        private static void Swap(ref int n1, ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
    }
}

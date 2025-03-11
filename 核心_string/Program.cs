namespace 核心_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 字符串指定位置获取
            //字符串本质上是char数组
            string a = "acscasc";
            char v = a[0];     //说明字符串是char数组，且string类中实现了索引器，所以可以这样获取
            char[] chars= a.ToCharArray();   //将字符串转换为char数组
            #endregion

            #region 知识点二 字符串拼接
            string str;
            //str = string.Concat("aa","bb","cc
            //str = string.Format()
            // Console.WriteLine(str);
            #endregion

            #region 知识点三 正向查找字符的位置
            //string str1 = "abcdefg";
            //int index = str1.IndexOf('c');  //找不到返回-1
            #endregion

            #region 知识点四 反向查找字符的位置
            //string str2 = "abcdefg";
            //int index = str2.LastIndexOf('c');  //找不到返回-1
            #endregion

            #region 知识点五 移除指定字符后的字符
            string str3 = "abcdefg";
            string str4 = str3.Remove(3);   //返回一个移除后的新字符串
            Console.WriteLine(str4);

            string str5 = str3.Remove(3,2); //  第一个参数表示移除的起始位置，第二个参数表示移除的长度
            Console.WriteLine(str5);
            #endregion

            #region 知识点六 替换字符串
            string str6 = "abcdefg";
            string str7 = str6.Replace("c","d");  //返回一个替换后的新字符串
            Console.WriteLine(str7);
            #endregion
            #region 知识点七 大小写转换
            string str8 = "abcdefg";
            string str9 = str8.ToUpper();    //返回一个大写的字符串  ToLower
            Console.WriteLine(str9);
            #endregion

            #region 知识点八 字符串截取
            string str10 = "abcdefg";
            string str11 = str10.Substring(3);//返回一个从指定位置开始到字符串末尾的子字符串
            Console.WriteLine(str11);

            string str12 = str10.Substring(3,2);//返回一个从指定位置开始到指定长度的子字符串   不会判断越界
            #endregion

            #region 知识点九 字符串切割
            str = "1,2,3,4,5,6,7,8,9";
            string[] strs = str.Split(',');  //处理数据    此处处理逗号
            #endregion
        }
    }
}
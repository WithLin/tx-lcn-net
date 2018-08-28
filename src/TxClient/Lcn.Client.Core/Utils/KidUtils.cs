using System;
using System.Collections.Generic;
using System.Text;

namespace Lcn.TxClient.Core.Utils
{
    public static class KidUtils
    {
        private static readonly string[] Chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


        public static string GetKid()
        {
            var kid = GenerateShortUuid();
            kid = DateTime.Now.ToString("yyyyMMddHHmmss") + kid;
            return kid;
        }

        public static string GetKKid()
        {
            var kid = GenerateShortUuid();
            kid = "k" + DateTime.Now.ToString("yyyyMMddHHmmss") + kid;
            return kid;
        }

        public static string GetUuid()
        {
            var kid = GenerateShortUuid();
            kid = DateTime.Now.ToString("yyyyMMddHHmmss") + "ud" + kid;
            return kid;
        }

        public static bool IsUuid(string uuid)
        {
            if (uuid != null && uuid.Length == 24)
            {
                 var time = uuid.Substring(0, 14);

                try
                {
                    //DateUtil.parseDate(time, "");
                    if ("ud".Equals(uuid.Substring(14, 16)))
                    {
                        return true;
                    }
                }
                catch (Exception var3)
                {
                    return false;
                }
            }

            return false;
        }

        public static string GenerateShortUuid()
        {
            var shortBuffer = new StringBuilder();
            var uuid = Guid.NewGuid().ToString().Replace("-", "");

            for (int i = 0; i < 8; ++i)
            {
                var str = uuid.Substring(i * 4, i * 4 + 4);
                int x = int.Parse(str);
                shortBuffer.Append(Chars[x % 62]);
            }

            return shortBuffer.ToString();
        }
    }
}

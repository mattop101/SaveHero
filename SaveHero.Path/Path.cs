using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHero.Path
{
    public class Path
    {
        private static string ReverseString(string s)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);

            return new string(rev);
        }

        public static string GetFilename(string filepath)
        {
            string filepathReversed = ReverseString(filepath);
            return ReverseString(filepathReversed.Substring(0, filepathReversed.Replace(@"\", @"/").IndexOf('/'))).Replace(@"/", @"\");
        }

        public static bool VerifyDir(string path, bool createIfNotExist)
        {
            if (Directory.Exists(path)) return true;
            if (!createIfNotExist) return false;
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("An errror occured: " + e);
                return false;
            }
            return true;
        }
    }
}

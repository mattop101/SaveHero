using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHero.Archive
{
    public class Archive
    {
        public static void ZipDirectory(string dirPath, string dstPath)
        {
            if (!dstPath.EndsWith(".zip"))
            {
                dstPath += ".zip";
            }

            try
            {
                ZipFile.CreateFromDirectory(dirPath, dstPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e);
            }
        }
    }
}

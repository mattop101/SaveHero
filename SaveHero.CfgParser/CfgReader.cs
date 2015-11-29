using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHero.CfgParser
{
    public class CfgReader
    {
        public static List<Profile> ReadCfg(string configPath)
        {
            List<Profile> allProfiles = new List<Profile>();

            using (StreamReader reader = new StreamReader(configPath))
            {
                string line, title, src, dst, archive;
                title = src = dst = archive = "";
                bool isProfile = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isProfile)
                    {
                        if (line.StartsWith("SourcePath="))
                        {
                            src = line.Replace("SourcePath=", string.Empty);
                        }
                        else if (line.StartsWith("DestinationPath="))
                        {
                            dst = line.Replace("DestinationPath=", string.Empty);
                        }
                        else if (line.StartsWith("ArchiveName="))
                        {
                            archive = line.Replace("ArchiveName=", string.Empty);
                        }
                    }

                    if (line.StartsWith("["))
                    {
                        isProfile = true;
                        title = line.Substring(1, line.Length - 2);
                    }

                    if ((new string[] { title, src, dst, archive }).All(x => x.Length > 0))
                    {
                        allProfiles.Add(new Profile { Title = title, Data = new Dictionary<string, string> { { "SourcePath", src }, { "DestinationPath", dst }, { "ArchiveName", archive } } });
                        title = src = dst = archive = "";
                        isProfile = false;
                    }
                }
            }

            return allProfiles;
        }
    }

    public class Profile
    {
        public string Title { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}

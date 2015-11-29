using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SaveHero.CfgReader
{
    class CfgReader
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

                    if ((new string[] {title, src, dst, archive}).All(x => x.Length > 0))
                    {
                        allProfiles.Add(new Profile { Title = title, PathSource = src, PathDestination = dst, ArchiveName = archive });
                        title = src = dst = archive = "";
                        isProfile = false;
                    }
                }
            }

            return allProfiles;
        }
    }

    class Profile
    {
        public string Title { get; set; }
        public string PathSource { get; set; }
        public string PathDestination { get; set; }
        public string ArchiveName { get; set; }
    }
}

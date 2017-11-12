using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TelegramBot
{
    class Commands
    {
        public static string deleteFile(string path, string name)
        {
            return $"file {name} was deleted successfully";
        }

        public static List<string> getDirectory(string path)
        {
            var list = new List<string>();
            return list;
        }

        public static string makeDirectory(string path, string name)
        {
            return "";
        }

        public static string removeDirectory(string path, string name)
        {
            return "";
        }

        public static string taskManager(string command, string pid = null)
        {
            return "";
        }

        public static string downloadFromWeb(string url, string path)
        {
            return "";
        }

        public static string uploadFromPc(string command, string path, string filename, string subcommand = null)
        {
            return "";
        }

        public static List<string> ListDownloads(string path, string filter = null)
        {
            var list = new List<string>();

            string[] obj;

            if (filter == null)
            {
                obj = Directory.GetFiles(path);
            }
            else
            {
                obj = Directory.GetFiles(path, filter);
            }

            foreach (string item in obj)
            {
                list.Add(Path.GetFileName(item));
            }

            return list;
        }

        public static bool DownloadFromURL(string url, string path)
        {
            bool result = false;
            WebClient wc = new WebClient();
            Uri uri = new Uri(url);
            if (Directory.Exists(path))
            {
                try
                {
                    string filename = Path.GetFileName(uri.LocalPath);
                    wc.DownloadFile(uri, path + filename);
                    if (File.Exists(path + filename))
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            return result;
        }
    }
}

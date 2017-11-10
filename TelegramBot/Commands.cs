using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    class Commands
    {
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
    }
}

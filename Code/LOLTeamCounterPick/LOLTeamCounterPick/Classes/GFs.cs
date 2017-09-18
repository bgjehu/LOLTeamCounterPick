using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LOLTeamCounterPick.Classes
{
    class GFs
    {
        public static string parseElement(string parsefrom, string header, string ender)
        {
            string str = "";
            int startIndex;
            int endIndex;
            int length;
            startIndex = parsefrom.IndexOf(header);

            if (startIndex == -1) { throw new Exception("Error: Cannot find header to parse the element"); }

            startIndex += header.Length;
            endIndex = parsefrom.Substring(startIndex).IndexOf(ender);

            if (endIndex == -1) { throw new Exception("Error: Cannot find ender to parse the element"); }

            length = endIndex;
            endIndex += startIndex;
            str = parsefrom.Substring(startIndex, length);
            return str;
        }
        public static List<string> parseElements(string parsefrom, string header, string ender)
        {
            List<string> list = new List<string>();
            int startIndex = 0;
            int endIndex = 0;
            int length;
            while (startIndex != -1 && endIndex != -1)
            {
                startIndex = parsefrom.IndexOf(header);

                if (startIndex == -1) { break; }

                startIndex += header.Length;
                endIndex = parsefrom.Substring(startIndex).IndexOf(ender);

                if (endIndex == -1) { break; }

                length = endIndex;
                endIndex += startIndex;


                list.Add(parsefrom.Substring(startIndex, length));
                parsefrom = parsefrom.Substring(endIndex);


            }
            return list;
        }
        public static string originChampionName(string alias)
        {
            for (int i = 0; i < GVs.championNames.Count(); i++)
            {
                if (alias.ToLower() == Regex.Replace(GVs.championNames[i], @"[^a-zA-Z]+", "").ToLower())
                {
                    return GVs.championNames[i];
                }
            }
            throw new Exception("Error: Invalid Champion Alias");
        }
    }
}

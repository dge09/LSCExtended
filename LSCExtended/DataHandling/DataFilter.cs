using LSCExtended.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCExtended.DataHandling
{
    public static class DataFilter
    {
        public static List<string> SearchForKeywords(string collectedData)
        {
            List<string> keywords = GetStringListKeywords(DbHandling.SelectKeywords());
            List<string> foundKeywords = new List<string>();

            foreach (string keyword in keywords)
            {
                if (collectedData.Contains(keyword))
                {
                    foundKeywords.Add(keyword);
                }
            }

            return foundKeywords;
        }

        public static List<string> GetStringListKeywords(List<Keyword> objKeywords)
        {
            List<Keyword> keywordsObjs = DbHandling.SelectKeywords();
            List<string> keywords = new List<string>();

            for (int i = 0; i < keywordsObjs.Count; i++)
            {
                keywords.Add(keywordsObjs[i].KeyWord.ToString());
            }

            return keywords;
        }
    }
}

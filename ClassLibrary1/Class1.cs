using System;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
        public class RegexValidador
        {
            public static string RegexMatch(string pattern, string text)
            {
                Regex regex = new Regex(pattern);
                Match m = regex.Match(text);
                if (!m.Success)
                {
                    return "False";
                }
                else {
                    return "True";
                }   
            } 
        } 
}

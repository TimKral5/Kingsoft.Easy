using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kingsoft.Easy
{
    public static class Utils
    {
        #region utility-functions
        public static void Print(string s, 
            ConsoleColor fCol = ConsoleColor.White, 
            ConsoleColor bCol = ConsoleColor.Black
            )
        {
            ConsoleColor _fCol = Console.ForegroundColor;
            ConsoleColor _bCol = Console.BackgroundColor;
            Console.BackgroundColor = bCol;
            Console.ForegroundColor = fCol;
            Console.Write(s);
            Console.ForegroundColor = _fCol;
            Console.BackgroundColor = _bCol;
        }

        public static void PrintLine(string s,
            ConsoleColor fCol = ConsoleColor.White,
            ConsoleColor bCol = ConsoleColor.Black
            ) => Print(s + "\n", fCol, bCol);

        public static string ReadFile(string path) => File.ReadAllText(path);

        public static bool WriteFile(string path, string content)
        {
            try
            {
                if (!File.Exists(path))
                    throw new Exception();
                File.WriteAllText(path, content);
            } 
            catch
            {
                return false;
            }
            return true;
        }

        public static void Title(string s) => Console.Title = s;
        #endregion

        #region type-extensions
        public static T[] Append<T>(this T[] self, params T[] values)
        {
            foreach (var item in values)
            {
                self.ToList().Add(item);
            }
            return self.ToArray();
        }


        #endregion
    }
}

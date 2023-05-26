using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasury.Challenge.Stone.Dojo
{
    public class Promocao
    {
        static Hashtable _letras = new Hashtable();
        static Hashtable _linhas = new Hashtable();

        public static void Execute()
        {
            Console.WriteLine("Tell me the number of lines do you need and press enter.");

            int l = int.Parse(Console.ReadLine());

            var t = Stopwatch.StartNew();

            Write(l);

            t.Stop();

            System.Console.WriteLine(t.ElapsedMilliseconds);
        }

        static string GetChar()
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(0, 26);

            return chars[random.Next(26)].ToString();

        }

        static void Write(int l)
        {
            var file = new StreamWriter("aleatory-file.txt");
            var line = string.Empty;
            for (int i = 0; i < l; i++)
            {
                do
                {
                    line = GetLine();
                } while (_letras.ContainsKey(line));

                _letras.Add(line, line);
                file.WriteLine(GetLine());

            }
            file.Close();

            System.Console.WriteLine($"A file with {File.ReadLines("C:\\Users\\juliano.maciel\\source\\repos\\Treasury.Challenge.Stone.Dojo\\Treasury.Challenge.Stone.Dojo\\bin\\Debug\\net6.0\\aleatory-file.txt").Count()} lines was generated.");

        }

        public static string GetLine(string l = "")
        {
            if (l.Length == 7)
            {
                _letras.Clear();
                return l;
            }


            var c = string.Empty;
            do
            {
                c = GetChar();

            } while (_letras.ContainsKey(c));

            _letras.Add(c, c);

            return GetLine(l + c);
        }
    }
}

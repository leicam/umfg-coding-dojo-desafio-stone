using System.Collections;
using System.Diagnostics;
using System.IO;

namespace Treasury.Challenge.Stone.Dojo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Promocao.Execute();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

        }
        
    }
}
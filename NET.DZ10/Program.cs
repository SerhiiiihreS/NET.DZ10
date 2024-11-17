using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine a = new Magazine("hiu dfb", 2000, "mofv nuobn,p miogdfbiv,p", 32423987, "324oingbm3y", 7);
            a.Output();
            Console.WriteLine();
            Shop b = new Shop("guvygnu","u bydc cunvosr 79","vnjuibhtsl  vnrbi vnbni",4567890,"fgunhiuom",145);
            b.Output();
        }
    }
}

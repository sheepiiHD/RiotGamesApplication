using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotGamesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentCreator dc = new DocumentCreator();
            dc.create(new CoverLetter());

           
        }
    }
}

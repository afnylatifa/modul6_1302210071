using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302210071
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title.Length < 200);
            Contract.Requires(title != null);
            this.title = title;
            Random random= new Random();
            id = random.Next(10000, 99990);
            playCount = 0;
        }

        public void IncreasePlayCount(int playcount)
        {
            Contract.Requires(title.Length <= 25000000);
            try
            {
                this.playCount = checked(this.playCount + playcount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Detail video: ");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Play count : " + playCount);
        }
    }
}

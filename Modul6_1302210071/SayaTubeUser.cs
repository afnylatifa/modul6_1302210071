using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302210071
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            this.id = id;
            this.uploadedVideos= new List<SayaTubeVideo>();
            this.username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo sayaTubeVideoin in uploadedVideos)
            {
                total += sayaTubeVideoin.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo vids)
        {
            uploadedVideos.Add(vids);
        }

        public void PrintAllPlayCount()
        {
            Console.WriteLine("USer : " + username);
            int i = 0;
            foreach(SayaTubeVideo sayaTubeVideoin in uploadedVideos)
            {
                i++;
                Console.WriteLine("Video " + i + " judul " + sayaTubeVideoin.GetTitle());
            }
        }
    }
}

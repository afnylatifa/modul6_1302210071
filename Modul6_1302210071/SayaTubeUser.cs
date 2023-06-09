﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null);
            Debug.Assert(username.Length <= 100);
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
            Debug.Assert(!uploadedVideos.Contains(vids));
            Debug.Assert(uploadedVideos.Count >= 0 && uploadedVideos.Count < int.MaxValue);
            uploadedVideos.Add(vids);
        }

        public void PrintAllPlayCount()
        {
            Console.WriteLine("USer : " + username);
            for(int i = 0; i < uploadedVideos.Count && i < 8; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul " + uploadedVideos[i].GetTitle());
            }
        }
    }
}

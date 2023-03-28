// See https://aka.ms/new-console-template for more information

using Modul6_1302210071;

public class program
{
    static void Main(string[] args)
    {
        SayaTubeUser afny = new SayaTubeUser("afny");
        
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Afny Latifa");
        SayaTubeVideo video = new SayaTubeVideo("Riview Film Fashion oleh Afny");
        SayaTubeVideo video2 = new SayaTubeVideo("Riview Film Fantastic oleh Afny");
        SayaTubeVideo video3 = new SayaTubeVideo("Riview Film Raden oleh Afny");
        SayaTubeVideo video4 = new SayaTubeVideo("Riview Film Saleh oleh Afny");
        SayaTubeVideo video5 = new SayaTubeVideo("Riview Film Pulang oleh Afny");
        SayaTubeVideo video6 = new SayaTubeVideo("Riview Film Rumah oleh Afny");
        SayaTubeVideo video7 = new SayaTubeVideo("Riview Film Princess oleh Afny");
        SayaTubeVideo video8 = new SayaTubeVideo("Riview Film Barbie oleh Afny");
        SayaTubeVideo video9 = new SayaTubeVideo("Riview Film Anime oleh Afny");
        SayaTubeVideo video10 = new SayaTubeVideo("Riview Film Kartun oleh Afny");

        afny.AddVideo(video);
        afny.AddVideo(video2);
        afny.AddVideo(video3);
        afny.AddVideo(video4);
        afny.AddVideo(video5);
        afny.AddVideo(video6);
        afny.AddVideo(video7);
        afny.AddVideo(video8);
        afny.AddVideo(video9);
        afny.AddVideo(video10);

        afny.PrintAllPlayCount();
    }
}

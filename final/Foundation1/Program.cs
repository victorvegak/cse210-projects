using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
         // Here we create videos
         Video video1 = new Video("Challenge video", "Mr.Beast", 600);
         Video video2 = new Video("Educational video", "VictorV", 900);
         Video video3 = new Video("Unboxing video", "Microsoft", 500);
         Video video4 = new Video("Video Testimonial", "TEDx", 800);

         // here we add the comments
        video1.AddComment(new Comment("Mario", " that was insane!"));
        video1.AddComment(new Comment("Kyle", "So much respect for you, Mr. Beast."));
        video2.AddComment(new Comment("John", "I learned a lot from this video!"));
        video2.AddComment(new Comment("Victor", "Great Work!"));
        video3.AddComment(new Comment("Laura", "The series X is definitely A thing of beauty on the inside and outside."));
        video3.AddComment(new Comment("Douglas", "The box itself looks insane inside. Microsoft did so great."));
        video4.AddComment(new Comment("Justin", "This Ted talk is actually very inspiring.."));
        video4.AddComment(new Comment("Mary", "This is THE bravest TEDx speaker I've ever listened to."));
        

        // list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Information of each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
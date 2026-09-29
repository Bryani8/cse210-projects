using System;
using System.ComponentModel;

class Program
//    Comment _comment2 = new Comment("", "");
//         _video.addComment(_comment1);
{
    static void Main(string[] args)
    {
        Video _video1 = new Video("Do schools kill creativity?", "Sir Ken Robinson", 19);
        Comment _comment1 = new Comment("SarahJenkins92: ", "This is hands down the most important talk on education ever given. Every teacher and policymaker needs to watch this.");
        _video1.addComment(_comment1);
        _comment1 = new Comment("MarkT_88: ", "It's hilarious yet deeply tragic how true his points are about traditional schooling systems crushing out-of-the-box thinking.");
        _video1.addComment(_comment1);
        _comment1 = new Comment("Elena_Rodriguez: ", "Watched this for a university assignment and ended up watching it three more times. Absolute masterpiece.");
        _video1.addComment(_comment1);


        Video _video2 = new Video("How great leaders inspire action", "Simon Sinek", 17);
        Comment _comment2 = new Comment("TechEntrepreneur_J: ", "The 'Golden Circle' concept completely changed how we pitch products at my startup. Start with why!");
        _video2.addComment(_comment2);
        _comment2 = new Comment("David_Miller_21: ", "Apple and Martin Luther King Jr. examples make this theory crystal clear. Brilliant presentation style.");
        _video2.addComment(_comment2);
        _comment2 = new Comment("RachelG_Design: ", "I show this video to every single new employee I manage. Essential leadership wisdom");
        _video2.addComment(_comment2);
        _comment2 = new Comment("SammyK_Official", "Simple, elegant, and timeless. Sinek delivers every single time.");
        _video2.addComment(_comment2);

        Video _video3 = new Video("After watching this, your brain will not be the same", "Lara Boyd", 14);
        Comment _comment3 = new Comment("NeuroFan_99: ", "Her explanation of neuroplasticity is so clear and encouraging. Knowing we can actually change our brain structure at any age is empowering.");
        _video3.addComment(_comment3);
        _comment3 = new Comment("Katy_L: ", "I love how she emphasizes that behavior changes structure. It really motivates me to practice new habits daily.");
        _video3.addComment(_comment3);

        _video1.displayVideoData();
        _video2.displayVideoData();
        _video3.displayVideoData();
    }
}
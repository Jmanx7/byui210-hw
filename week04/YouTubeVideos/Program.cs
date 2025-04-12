using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Contains every video
        List<Video> videosList = new List<Video>();
        //Create Videos
        videosList.Add(new Video("The Simpsons: Seasons 1-99 Full","Homer Simpson",999999.99));
        videosList[0].AddComment("Bart Simpson","Ay Caramba!");
        videosList[0].AddComment("homerfan9", "Homer Simpson is so funny. I like it when he says 'Doh!'.");
        videosList[0].AddComment("simpsonsfan8000", "I really like the fact that the characters are yellow.");
        videosList[0].AddComment("simpsonshater8001", "I really hate the fact that the characters are yellow.");

        videosList.Add(new Video("50 Cordless Drill Engine Swap for Ford F150", "milwaukee4life", 767.5));
        videosList[1].AddComment("JoeDirt2", "Still runs better than a modern car.");
        videosList[1].AddComment("KetchupMustardMan", "Video Idea: put a Hemi into a riding lawnmower.");
        videosList[1].AddComment("guywhowatchesthevideos", "LOL.");

        videosList.Add(new Video("Playing Pinball for 200 hours straight", "ILOVEPINBALL", 720001.0));
        videosList[2].AddComment("guymcman", "Ok but why???");
        videosList[2].AddComment("JeorgeBush", "Really liked the part where he hit the ball!");
        videosList[2].AddComment("olddude57", "Used to play this game back in the 80's! #Classic");

        //Display Videos to screen
        for (int i = 0; i < videosList.Count(); i++)
        {
            videosList[i].Display();
            //spacing
            Console.WriteLine("");
        }
    }
}
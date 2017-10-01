using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            int totalPicturesTaken = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int percentageOfTheGoodPics = int.Parse(Console.ReadLine());
            int uploadTimePerPic = int.Parse(Console.ReadLine());

            long totalPicturesTime = (long)totalPicturesTaken * filterTimeInSeconds;
            double goodPicturesCnt = Math.Ceiling(totalPicturesTaken * (percentageOfTheGoodPics / 100.0));

            long totalUploadTime = uploadTimePerPic * (long)goodPicturesCnt;
            long totalTimeInSeconds = totalUploadTime + totalPicturesTime;



            Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSeconds).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}

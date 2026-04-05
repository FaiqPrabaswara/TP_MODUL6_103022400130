using System;

namespace TP_MODUL6_103022400130
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Hymne Informatika");

            lagu1.PrintTrackDetails();
            lagu1.IncreasePlayCount(5000);
            lagu1.PrintTrackDetails();
        }
    }
}
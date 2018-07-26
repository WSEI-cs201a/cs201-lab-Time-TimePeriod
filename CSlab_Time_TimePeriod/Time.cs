using System;

namespace CSLabs.TimeLib
{
    public struct Time
    {
        public byte Hours { get; private set; }
        public byte Minutes { get; private set; }
        public byte Seconds { get; private set; }


        public Time(byte hours, byte minutes, byte seconds)
        {
            if (hours < 0 || hours > 23) throw new ArgumentOutOfRangeException("Liczba godzin musi byc z przedzialu od 0 do 23");
            if (minutes < 0 || minutes > 59) throw new ArgumentOutOfRangeException("Liczba minut musi byc z przedzialu od 0 do 59");
            if (seconds < 0 || seconds > 59) throw new ArgumentOutOfRangeException("Liczba sekund musi byc z przedzialu od 0 do 59");
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

    }

}
using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[8];
            int stormIndex = 0;

            storms[stormIndex] = new Storm("electric", true, "Zul'rajas");
            stormIndex++;
            //Console.WriteLine(zul.Announce());

            Pupil mezil = new Pupil("Mezil-kree", "Icecrown");
            storms[stormIndex] = mezil.CastWindStorm();
            stormIndex++;
            //Console.WriteLine(pupilStorm.Announce());

            Mage gul = new Mage("Gul’dan", "Draenor");
            storms[stormIndex] = gul.CastWindStorm();
            stormIndex++;
            //Console.WriteLine(gulStorm.Announce());

            Archmage nielas = new Archmage("Nielas Aran", "Stormwind");
            storms[stormIndex] = nielas.CastRainStorm();
            stormIndex++;
            storms[stormIndex] = nielas.CastLightningStorm();
            stormIndex++;
            //Console.WriteLine(nielStorm1.Announce());
            //Console.WriteLine(nielStorm2.Announce());

            for (int i = 0; i < stormIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }
        }
    }
}

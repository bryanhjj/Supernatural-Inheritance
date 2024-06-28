namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string t, string o) : base(t, o)
        {}

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}
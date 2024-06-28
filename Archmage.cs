namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string t, string o) : base(t, o)
        {}

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", false, Title);
        }

        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }
    }
}
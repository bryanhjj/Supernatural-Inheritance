namespace MagicalInheritance
{
    class Storm : Spell
    {
        public string Essense
        {get; private set;}
        public bool IsStrong
        {get; private set;}
        public string Caster
        {get; private set;}

        public Storm(string e, bool i, string c)
        {
            Essense = e;
            IsStrong = i;
            Caster = c;
        }

        public override string Announce()
        {
            return $"{Caster} casts a " + (IsStrong? "strong " : "weak ") + $"{Essense} storm.";
        }
    }
}

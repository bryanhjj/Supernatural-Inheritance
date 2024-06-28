namespace MagicalInheritance
{
    abstract class Spell
    {
        public string Essense
        {get; private set;}
        public bool IsStrong
        {get; private set;}
        public string Caster
        {get; private set;}

        public abstract string Announce();
    }
}
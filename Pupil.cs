namespace MagicalInheritance
{
    class Pupil
    {
        public string Title
        {get; private set;}
        public string Origin
        {get; private set;}
        public Pupil(string t, string o)
        {
            Title = t;
            Origin = o;
        }

        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}

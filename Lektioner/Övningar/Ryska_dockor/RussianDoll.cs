class RussianDoll
{
    public int Size { get; }
    public RussianDoll? DollInsideMe;
    public RussianDoll(int size)
    {
        if (size < 1)
        {
            size = 1;
        }
        else if (size > 10)
        {
            size = 10;
        }
        Size = size;
    }

    public void AddInsideMe(RussianDoll otherDoll)
    {
        if (otherDoll.Size >= Size)
        {
            throw new ArgumentException("Dockan måste vara mindre än den du lägger den i.");
        }
        DollInsideMe = otherDoll;
    }

    public void TellMeAboutDollsInsideYou()
    {
        if (DollInsideMe == null)
        {
            Console.WriteLine($"Docka {Size}: ingen docka inuti.");
            return;
        }
        Console.WriteLine($"Docka {Size} har docka {DollInsideMe.Size} inuti.");
        DollInsideMe.TellMeAboutDollsInsideYou();
    }
}
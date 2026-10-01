class Band(string name)
{
    public string Name { get; } = name;

    public List<Musician> Members { get; } = [];

    public void Hire(Musician musician)
    {
        if (!Members.Contains(musician))
        {
            Members.Add(musician);
            musician.JoinBand(this);
        }

    }

    public void Fire(Musician musician)
    {
        if (Members.Remove(musician))
        {
            musician.LeaveBand(this);
        }
    }
}
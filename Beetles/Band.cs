class Band(string name)
{
    public string Name { get; } = name;

    public List<Musician> Members { get; } = [];

    public void Hire(Musician musician)
    {
        Members.Add(musician);
    }

    public void Fire(Musician musician)
    {
        Members.Remove(musician);
    }
}
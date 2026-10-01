class Musician(string name, string instrument, int age)
{
    public string Name { get; } = name;
    public string Instrument { get; } = instrument;
    public int Age { get; } = age;

    public List<Band> Bands { get; } = [];

    public void JoinBand(Band band)
    {
        if (!Bands.Contains(band))
        {
            Bands.Add(band);
            band.Hire(this);
        }
    }

    public void LeaveBand(Band band)
    {
        if (Bands.Contains(band))
        {
            Bands.Remove(band);
            band.Fire(this);
        }
    }
}
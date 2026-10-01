Band beatles = new("The Beatles");
Musician paul = new("Paul McCartney", "bass", 20);
Musician john = new("John Lennon", "guitar", 20);
Musician george = new("George Harrison", "guitar", 18);
Musician stuart = new("Stuart Sutcliffe", "bass", 18);
Musician pete = new("Pete Best", "drums", 22);
Musician ringo = new("Ringo Starr", "drums", 20);

paul.JoinBand(beatles);
john.JoinBand(beatles);
beatles.Hire(george);
beatles.Hire(stuart);
beatles.Hire(pete);
stuart.LeaveBand(beatles);
beatles.Fire(pete);
beatles.Hire(ringo);

foreach (Musician m in beatles.Members)
{
    Console.WriteLine(m.Name);
}

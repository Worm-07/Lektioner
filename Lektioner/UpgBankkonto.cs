public class User(string firstname, string lastname)
{
    public int kontonummer { get; } = 123456789;
    public string firstname { get; } = firstname;
    public string lastname { get; } = lastname;
    public double saldo = 25;
    double ränta = 0;
    double kreditgräns = 50_000;
    bool kontostatus = true;
}
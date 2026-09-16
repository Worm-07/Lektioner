class Person(string firstname, string lastname)
{
    string firstname = firstname;
    string lastname = lastname;
    string ssn = "070824 - 1234";
    string dateOfBirth = "";
    string email = "";
    public override string ToString()
    {
        return $"{firstname} {lastname} with ssn:{ssn},born {dateOfBirth},email {email}";
    }
}
using System;

namespace ovningsuppgift_automatiskt_namn_och_mejl;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Domain { get; set; } = "ankeborg.se";
    public string Email
    {
        get { return $"{FirstName.ToLower()}.{LastName.ToLower()}@{Domain}"; }
        set
        {
            string input = value.Trim();
            int dot = input.IndexOf('.');
            int at = input.IndexOf('@');
            if (dot > 0 && at > dot)
            {
                FirstName = input[..dot]; // ".." är range operator, från början till dot-1
                LastName = input[(dot + 1)..at]; // (dot + 1) till at-1
                Domain = input[(at + 1)..]; // (at + 1) till slutet
            }
            else
            {
                throw new ArgumentException(
                    "Ogiltig e-postadress format. Använd formatet: förnamn.efternamn@domän"
                );
            }
        }
    }

    // Konstruktor för att mata in förnamn och efternamn vid skapandet av objektet
    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}

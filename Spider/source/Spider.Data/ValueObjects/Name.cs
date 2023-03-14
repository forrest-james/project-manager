namespace Spider.Data.ValueObjects;

internal class Name : ValueObject
{
    public string FirstName { get; private set; }
    public string MiddleInitial { get; private set; }
    public string LastName { get; private set; }

    public Name() {}

    public Name(string firstName, string middleInitial, string lastName)
    {
        FirstName = firstName;
        MiddleInitial = middleInitial;
        LastName = lastName;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return MiddleInitial;
        yield return LastName;
    }
}
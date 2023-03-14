﻿namespace Spider.Data.ValueObjects;

internal class Address : ValueObject
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string Zipcode { get; }
    public string ZipCode { get; private set; }

    public Address() {}

    public Address(string street, string city, string state, string country, string zipcode)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        Zipcode = zipcode;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street; 
        yield return City; 
        yield return State; 
        yield return Country; 
        yield return Zipcode;
    }
}
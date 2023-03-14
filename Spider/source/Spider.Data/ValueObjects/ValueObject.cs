﻿namespace Spider.Data.ValueObjects;

public abstract class ValueObject
{
    protected abstract IEnumerable<Object> GetEqualityComponents();

    protected static bool EqualOperator(ValueObject left, ValueObject right)
    {
        if(ReferenceEquals(left, null) ^ ReferenceEquals(right, null)) return false;

        return ReferenceEquals(left, right) || left.Equals(right);
    }

    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
        return !(EqualOperator(left, right));
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;        

        var other = (ValueObject)obj;

        return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    public static bool operator ==(ValueObject left, ValueObject right) => EqualOperator(left, right);

    public static bool operator !=(ValueObject left, ValueObject right) => NotEqualOperator(left, right);
}
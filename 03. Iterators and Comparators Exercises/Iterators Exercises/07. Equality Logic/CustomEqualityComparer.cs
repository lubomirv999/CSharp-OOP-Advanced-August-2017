using System.Collections.Generic;

public class CustomEqualityComparer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y)
    {
        bool result = x.Name.Equals(y.Name);

        if (result)
        {
            result = x.Age.Equals(y.Age);
        }

        return result;
    }

    public int GetHashCode(Person obj)
    {
        var result = obj.Name.GetHashCode() + obj.Age.GetHashCode();
        return result;
    }
}
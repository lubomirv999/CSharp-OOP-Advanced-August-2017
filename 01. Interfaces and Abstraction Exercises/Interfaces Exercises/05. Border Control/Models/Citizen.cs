public class Citizen : Buyer
{
    public Citizen(string name, int age, string id, string birthdate) : base(name, age)
    {
        this.FoodCount = 10;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Id { get; set; }

    public string Birthdate { get; set; }
}

//Task 6
//public Citizen(string name, int age, string id, string birthdate)
//{
//    this.Name = name;
//    this.Age = age;
//    this.Id = id;
//    this.Birthdate = birthdate;
//}

//public string Name { get; set; }

//public int Age { get; set; }

//public string Id { get; set; }

//public string Birthdate { get; set; }
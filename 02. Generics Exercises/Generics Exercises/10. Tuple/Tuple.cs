public class Tuple<T1, T2, T3>
{
    public Tuple()
    {
    }

    public T1 Item1 { get; set; }

    public T2 Item2 { get; set; }

    public T3 Item3 { get; set; }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
    }
}

//Task 11 Tuple
//public Tuple()
//{
//}

//public T1 Item1 { get; set; }

//public T2 Item2 { get; set; }

//public override string ToString()
//{
//    return $"{this.Item1} -> {this.Item2}";
//}
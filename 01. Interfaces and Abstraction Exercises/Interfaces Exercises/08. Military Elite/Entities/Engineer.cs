using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps, IList<IRepair> parts) : base(id, firstName, lastName, salary, corps)
    {
        this.Parts = parts;
    }

    public IList<IRepair> Parts { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
        sb.AppendLine("Repairs:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Parts)}");

        return sb.ToString().Trim();
    }
}
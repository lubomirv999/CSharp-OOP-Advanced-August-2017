namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            Type harvestingFieldsType = typeof(HarvestingFields);
            FieldInfo[] harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] gatheredFields;

            string requestedAccMod;

            while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            {
                switch (requestedAccMod)
                {
                    case "private":
                        gatheredFields = harvestingFields.Where(f => f.IsPrivate).ToArray();
                        break;
                    case "protected":
                        gatheredFields = harvestingFields.Where(f => f.IsFamily).ToArray();
                        break;
                    case "public":
                        gatheredFields = harvestingFields.Where(f => f.IsPublic).ToArray();
                        break;
                    case "all":
                        gatheredFields = harvestingFields;
                        break;
                    default:
                        gatheredFields = null;
                        break;
                }

                string[] result = gatheredFields.Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").ToArray();

                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
            }

            //Type harvestingFieldsType = typeof(HarvestingFields);
            //FieldInfo[] harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            //Dictionary<string, Func<FieldInfo[]>> accModFilters = new Dictionary<string, Func<FieldInfo[]>>()
            //{
            //	{"private", () => harvestingFields.Where(f => f.IsPrivate).ToArray()},
            //	{"protected", () => harvestingFields.Where(f => f.IsFamily).ToArray()},
            //	{"public" , () => harvestingFields.Where(f => f.IsPublic).ToArray()},
            //	{"all", () => harvestingFields}
            //};
            //
            //FieldInfo[] gatherdFields;
            //string requestedAccMod;
            //while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            //{
            //	accModFilters[requestedAccMod]()
            //		.Select(f =>
            //			$"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
            //			.ToList()
            //			.ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            //}
        }
    }
}
namespace ForceSourceGenCodeOutput
{
    public class Program
    {
        public static void Main()
        {
            var sample = new SimplePocoForSerialisation { FirstName = "John", LastName = "Doe" };
            var repo = new PocoRepository();
            var json = repo.GetJsonFromPoco(sample);
            var clone = repo.GetPocoFromJson(json);
            var isCloneRecordEqual = clone?.Equals(sample) ?? false;
            Console.WriteLine(isCloneRecordEqual ? "Done" : "Error cloning");
            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}

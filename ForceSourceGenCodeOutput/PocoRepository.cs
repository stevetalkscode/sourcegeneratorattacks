namespace ForceSourceGenCodeOutput
{
    public class PocoRepository
    {
        public SimplePocoForSerialisation? GetPocoFromJson(string json) =>
            System.Text.Json.JsonSerializer.Deserialize(json, SimplePocoForSerialisationContext.Default.SimplePocoForSerialisation);

        public string GetJsonFromPoco(SimplePocoForSerialisation poco) => 
            System.Text.Json.JsonSerializer.Serialize(poco, SimplePocoForSerialisationContext.Default.SimplePocoForSerialisation);
    }

}
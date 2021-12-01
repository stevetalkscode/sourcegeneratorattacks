using System.Text.Json.Serialization;

namespace ForceSourceGenCodeOutput
{
    [JsonSourceGenerationOptions(
        WriteIndented = true, 
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(SimplePocoForSerialisation))]
    internal partial class SimplePocoForSerialisationContext : JsonSerializerContext
    {
    }

}
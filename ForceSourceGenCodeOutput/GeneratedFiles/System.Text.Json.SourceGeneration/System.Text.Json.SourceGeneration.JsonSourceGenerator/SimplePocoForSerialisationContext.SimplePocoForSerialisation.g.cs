// <auto-generated/>
#nullable enable

namespace ForceSourceGenCodeOutput
{
    internal partial class SimplePocoForSerialisationContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation>? _SimplePocoForSerialisation;
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation> SimplePocoForSerialisation
        {
            get
            {
                if (_SimplePocoForSerialisation == null)
                {
                    global::System.Text.Json.Serialization.JsonConverter? customConverter;
                    if (Options.Converters.Count > 0 && (customConverter = GetRuntimeProvidedCustomConverter(typeof(global::ForceSourceGenCodeOutput.SimplePocoForSerialisation))) != null)
                    {
                        _SimplePocoForSerialisation = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation>(Options, customConverter);
                    }
                    else
                    {
                        global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation> objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation>()
                        {
                            ObjectCreator = static () => new global::ForceSourceGenCodeOutput.SimplePocoForSerialisation(),
                            ObjectWithParameterizedConstructorCreator = null,
                            PropertyMetadataInitializer = SimplePocoForSerialisationPropInit,
                            ConstructorParameterMetadataInitializer = null,
                            NumberHandling = default,
                            SerializeHandler = SimplePocoForSerialisationSerializeHandler
                        };
            
                        _SimplePocoForSerialisation = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::ForceSourceGenCodeOutput.SimplePocoForSerialisation>(Options, objectInfo);
                    }
                }
        
                return _SimplePocoForSerialisation;
            }
        }
        
        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] SimplePocoForSerialisationPropInit(global::System.Text.Json.Serialization.JsonSerializerContext context)
        {
            global::ForceSourceGenCodeOutput.SimplePocoForSerialisationContext jsonContext = (global::ForceSourceGenCodeOutput.SimplePocoForSerialisationContext)context;
            global::System.Text.Json.JsonSerializerOptions options = context.Options;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[2];
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::ForceSourceGenCodeOutput.SimplePocoForSerialisation),
                PropertyTypeInfo = jsonContext.String,
                Converter = null,
                Getter = static (obj) => ((global::ForceSourceGenCodeOutput.SimplePocoForSerialisation)obj).FirstName!,
                Setter = static (obj, value) => ((global::ForceSourceGenCodeOutput.SimplePocoForSerialisation)obj).FirstName = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "FirstName",
                JsonPropertyName = null
            };
        
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info0);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::ForceSourceGenCodeOutput.SimplePocoForSerialisation),
                PropertyTypeInfo = jsonContext.String,
                Converter = null,
                Getter = static (obj) => ((global::ForceSourceGenCodeOutput.SimplePocoForSerialisation)obj).LastName!,
                Setter = static (obj, value) => ((global::ForceSourceGenCodeOutput.SimplePocoForSerialisation)obj).LastName = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "LastName",
                JsonPropertyName = null
            };
        
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info1);
            
            return properties;
        }
        
        private static void SimplePocoForSerialisationSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::ForceSourceGenCodeOutput.SimplePocoForSerialisation? value)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
        
            writer.WriteStartObject();
            writer.WriteString(PropName_firstName, value.FirstName);
            writer.WriteString(PropName_lastName, value.LastName);
        
            writer.WriteEndObject();
        }
    }
}

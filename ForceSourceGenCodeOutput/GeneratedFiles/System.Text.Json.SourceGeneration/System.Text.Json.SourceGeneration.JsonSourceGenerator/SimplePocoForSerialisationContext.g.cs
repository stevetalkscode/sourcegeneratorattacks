﻿// <auto-generated/>
#nullable enable

namespace ForceSourceGenCodeOutput
{
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Text.Json.SourceGeneration", "6.0.5.2210")]
    internal partial class SimplePocoForSerialisationContext
    {
        
        private static global::System.Text.Json.JsonSerializerOptions s_defaultOptions { get; } = new global::System.Text.Json.JsonSerializerOptions()
        {
            DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.Never,
            IgnoreReadOnlyFields = false,
            IgnoreReadOnlyProperties = false,
            IncludeFields = false,
            WriteIndented = true,
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase
        };
        
        private static global::ForceSourceGenCodeOutput.SimplePocoForSerialisationContext? s_defaultContext;
        public static global::ForceSourceGenCodeOutput.SimplePocoForSerialisationContext Default => s_defaultContext ??= new global::ForceSourceGenCodeOutput.SimplePocoForSerialisationContext(new global::System.Text.Json.JsonSerializerOptions(s_defaultOptions));
        
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions { get; } = s_defaultOptions;
        
        public SimplePocoForSerialisationContext() : base(null)
        {
        }
        
        public SimplePocoForSerialisationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options)
        {
        }
        
        private global::System.Text.Json.Serialization.JsonConverter? GetRuntimeProvidedCustomConverter(global::System.Type type)
        {
            global::System.Collections.Generic.IList<global::System.Text.Json.Serialization.JsonConverter> converters = Options.Converters;
        
            for (int i = 0; i < converters.Count; i++)
            {
                global::System.Text.Json.Serialization.JsonConverter? converter = converters[i];
        
                if (converter.CanConvert(type))
                {
                    if (converter is global::System.Text.Json.Serialization.JsonConverterFactory factory)
                    {
                        converter = factory.CreateConverter(type, Options);
                        if (converter == null || converter is global::System.Text.Json.Serialization.JsonConverterFactory)
                        {
                            throw new global::System.InvalidOperationException(string.Format("The converter '{0}' cannot return null or a JsonConverterFactory instance.", factory.GetType()));
                        }
                    }
        
                    return converter;
                }
            }
        
            return null;
        }
    }
}
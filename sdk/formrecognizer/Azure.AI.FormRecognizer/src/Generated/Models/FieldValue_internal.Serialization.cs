// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class FieldValue_internal
    {
        internal static FieldValue_internal DeserializeFieldValue_internal(JsonElement element)
        {
            FieldValueType type = default;
            string valueString = default;
            DateTimeOffset? valueDate = default;
            TimeSpan? valueTime = default;
            string valuePhoneNumber = default;
            float? valueNumber = default;
            int? valueInteger = default;
            IReadOnlyList<FieldValue_internal> valueArray = default;
            IReadOnlyDictionary<string, FieldValue_internal> valueObject = default;
            string text = default;
            IReadOnlyList<float> boundingBox = default;
            float? confidence = default;
            IReadOnlyList<string> elements = default;
            int? page = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToFieldValueType();
                    continue;
                }
                if (property.NameEquals("valueString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("valueTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valuePhoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valuePhoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueNumber = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("valueInteger"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInteger = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("valueArray"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldValue_internal> array = new List<FieldValue_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeserializeFieldValue_internal(item));
                        }
                    }
                    valueArray = array;
                    continue;
                }
                if (property.NameEquals("valueObject"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, FieldValue_internal> dictionary = new Dictionary<string, FieldValue_internal>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, DeserializeFieldValue_internal(property0.Value));
                        }
                    }
                    valueObject = dictionary;
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elements"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    elements = array;
                    continue;
                }
                if (property.NameEquals("page"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    page = property.Value.GetInt32();
                    continue;
                }
            }
            return new FieldValue_internal(type, valueString, valueDate, valueTime, valuePhoneNumber, valueNumber, valueInteger, valueArray, valueObject, text, boundingBox, confidence, elements, page);
        }
    }
}

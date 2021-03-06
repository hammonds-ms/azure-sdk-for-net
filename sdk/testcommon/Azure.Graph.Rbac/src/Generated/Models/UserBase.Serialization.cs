// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class UserBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ImmutableId != null)
            {
                writer.WritePropertyName("immutableId");
                writer.WriteStringValue(ImmutableId);
            }
            if (UsageLocation != null)
            {
                writer.WritePropertyName("usageLocation");
                writer.WriteStringValue(UsageLocation);
            }
            if (GivenName != null)
            {
                writer.WritePropertyName("givenName");
                writer.WriteStringValue(GivenName);
            }
            if (Surname != null)
            {
                writer.WritePropertyName("surname");
                writer.WriteStringValue(Surname);
            }
            if (UserType != null)
            {
                writer.WritePropertyName("userType");
                writer.WriteStringValue(UserType.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}

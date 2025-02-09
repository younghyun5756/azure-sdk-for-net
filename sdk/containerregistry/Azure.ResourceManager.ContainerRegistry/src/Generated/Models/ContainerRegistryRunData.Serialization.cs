// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryRunData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(RunType))
            {
                writer.WritePropertyName("runType"u8);
                writer.WriteStringValue(RunType.Value.ToString());
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(FinishOn))
            {
                writer.WritePropertyName("finishTime"u8);
                writer.WriteStringValue(FinishOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(OutputImages))
            {
                writer.WritePropertyName("outputImages"u8);
                writer.WriteStartArray();
                foreach (var item in OutputImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Task))
            {
                writer.WritePropertyName("task"u8);
                writer.WriteStringValue(Task);
            }
            if (Optional.IsDefined(ImageUpdateTrigger))
            {
                writer.WritePropertyName("imageUpdateTrigger"u8);
                writer.WriteObjectValue(ImageUpdateTrigger);
            }
            if (Optional.IsDefined(SourceTrigger))
            {
                writer.WritePropertyName("sourceTrigger"u8);
                writer.WriteObjectValue(SourceTrigger);
            }
            if (Optional.IsDefined(TimerTrigger))
            {
                writer.WritePropertyName("timerTrigger"u8);
                writer.WriteObjectValue(TimerTrigger);
            }
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteObjectValue(Platform);
            }
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceRegistryAuth))
            {
                writer.WritePropertyName("sourceRegistryAuth"u8);
                writer.WriteStringValue(SourceRegistryAuth);
            }
            if (Optional.IsCollectionDefined(CustomRegistries))
            {
                writer.WritePropertyName("customRegistries"u8);
                writer.WriteStartArray();
                foreach (var item in CustomRegistries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpdateTriggerToken))
            {
                writer.WritePropertyName("updateTriggerToken"u8);
                writer.WriteStringValue(UpdateTriggerToken);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerRegistryRunData DeserializeContainerRegistryRunData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> runId = default;
            Optional<ContainerRegistryRunStatus> status = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<ContainerRegistryRunType> runType = default;
            Optional<string> agentPoolName = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> finishTime = default;
            Optional<IList<ContainerRegistryImageDescriptor>> outputImages = default;
            Optional<string> task = default;
            Optional<ContainerRegistryImageUpdateTrigger> imageUpdateTrigger = default;
            Optional<ContainerRegistrySourceTriggerDescriptor> sourceTrigger = default;
            Optional<ContainerRegistryTimerTriggerDescriptor> timerTrigger = default;
            Optional<ContainerRegistryPlatformProperties> platform = default;
            Optional<ContainerRegistryAgentProperties> agentConfiguration = default;
            Optional<string> sourceRegistryAuth = default;
            Optional<IList<string>> customRegistries = default;
            Optional<string> runErrorMessage = default;
            Optional<string> updateTriggerToken = default;
            Optional<ContainerRegistryImageDescriptor> logArtifact = default;
            Optional<ContainerRegistryProvisioningState> provisioningState = default;
            Optional<bool> isArchiveEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("runId"u8))
                        {
                            runId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new ContainerRegistryRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runType = new ContainerRegistryRunType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentPoolName"u8))
                        {
                            agentPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("finishTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            finishTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("outputImages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ContainerRegistryImageDescriptor> array = new List<ContainerRegistryImageDescriptor>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerRegistryImageDescriptor.DeserializeContainerRegistryImageDescriptor(item));
                            }
                            outputImages = array;
                            continue;
                        }
                        if (property0.NameEquals("task"u8))
                        {
                            task = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageUpdateTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            imageUpdateTrigger = ContainerRegistryImageUpdateTrigger.DeserializeContainerRegistryImageUpdateTrigger(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceTrigger = ContainerRegistrySourceTriggerDescriptor.DeserializeContainerRegistrySourceTriggerDescriptor(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timerTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timerTrigger = ContainerRegistryTimerTriggerDescriptor.DeserializeContainerRegistryTimerTriggerDescriptor(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("platform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("agentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceRegistryAuth"u8))
                        {
                            sourceRegistryAuth = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customRegistries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            customRegistries = array;
                            continue;
                        }
                        if (property0.NameEquals("runErrorMessage"u8))
                        {
                            runErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateTriggerToken"u8))
                        {
                            updateTriggerToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logArtifact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logArtifact = ContainerRegistryImageDescriptor.DeserializeContainerRegistryImageDescriptor(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ContainerRegistryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isArchiveEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isArchiveEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerRegistryRunData(id, name, type, systemData.Value, runId.Value, Optional.ToNullable(status), Optional.ToNullable(lastUpdatedTime), Optional.ToNullable(runType), agentPoolName.Value, Optional.ToNullable(createTime), Optional.ToNullable(startTime), Optional.ToNullable(finishTime), Optional.ToList(outputImages), task.Value, imageUpdateTrigger.Value, sourceTrigger.Value, timerTrigger.Value, platform.Value, agentConfiguration.Value, sourceRegistryAuth.Value, Optional.ToList(customRegistries), runErrorMessage.Value, updateTriggerToken.Value, logArtifact.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isArchiveEnabled));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Result of a device message queue purge operation. </summary>
    public partial class PurgeMessageQueueResult
    {
        /// <summary> Initializes a new instance of PurgeMessageQueueResult. </summary>
        internal PurgeMessageQueueResult()
        {
        }

        /// <summary> Initializes a new instance of PurgeMessageQueueResult. </summary>
        /// <param name="totalMessagesPurged"> . </param>
        /// <param name="deviceId"> The ID of the device whose messages are being purged. </param>
        /// <param name="moduleId"> The ID of the device whose messages are being purged. </param>
        internal PurgeMessageQueueResult(int? totalMessagesPurged, string deviceId, string moduleId)
        {
            TotalMessagesPurged = totalMessagesPurged;
            DeviceId = deviceId;
            ModuleId = moduleId;
        }

        public int? TotalMessagesPurged { get; }
        /// <summary> The ID of the device whose messages are being purged. </summary>
        public string DeviceId { get; }
        /// <summary> The ID of the device whose messages are being purged. </summary>
        public string ModuleId { get; }
    }
}

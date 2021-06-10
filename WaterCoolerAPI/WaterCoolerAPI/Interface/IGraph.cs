﻿// <copyright file="IGraph.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace WaterCoolerAPI.Interface
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Graph;
    using WaterCoolerAPI.Repositories.RoomData;

    /// <summary>
    /// Interface for Graph.
    /// </summary>
    public interface IGraph
    {
        /// <summary>
        /// Get graph service client.
        /// </summary>
        /// <returns>Graph service client.</returns>
        Task<GraphServiceClient> GetGraphServiceClient();

        /// <summary>
        /// Get application access token.
        /// </summary>
        /// <returns>Graph service client.</returns>
        Task<string> GetApplicationAccessToken();

        /// <summary>
        /// Creates online meeting.
        /// </summary>
        /// <param name="graphServiceClient">GraphServiceClient instance.</param>
        /// <param name="roomDataEntity">RoomDataEntity instance.</param>
        /// <returns>Online meeting details.</returns>
        Task<OnlineMeeting> CreateOnlineMeeting(GraphServiceClient graphServiceClient, RoomDataEntity roomDataEntity);

        /// <summary>
        /// Get List of Participants in the meeting.
        /// </summary>
        /// <param name="graphServiceClient">GraphServiceClient instance.</param>
        /// <param name="callId">CallId of the Room.</param>
        /// <returns>Online meeting details.</returns>
        Task<IEnumerable<Participant>> GetParticipants(GraphServiceClient graphServiceClient, string callId);
    }
}

// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of Job operations for Azure backup extension.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Get details of a particular job.
        /// </summary>
        /// <param name='jobId'>
        /// Request header parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list jobs operation.
        /// </returns>
        Task<JobByIdResponse> GetAsync(string jobId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all jobs queried by specified filters.
        /// </summary>
        /// <param name='parameters'>
        /// Job query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list jobs operation.
        /// </returns>
        Task<JobListResponse> ListAsync(JobQueryParameter parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Trigger cancellation of a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job whose details should be retrieved.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Custom request headers to make the call.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> StopAsync(string jobId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}

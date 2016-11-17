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

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    /// <summary>
    /// Deployment operation properties.
    /// </summary>
    public partial class DeploymentOperationProperties
    {
        private string _provisioningState;

        /// <summary>
        /// Optional. Gets or sets the state of the provisioning.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }

        private string _statusCode;

        /// <summary>
        /// Optional. Gets or sets operation status code.
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        private string _statusMessage;

        /// <summary>
        /// Optional. Gets or sets operation status message.
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        private TargetResource _targetResource;

        /// <summary>
        /// Optional. Gets or sets the target resource.
        /// </summary>
        public TargetResource TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        private DateTime _timestamp;

        /// <summary>
        /// Optional. Gets or sets the date and time of the operation.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentOperationProperties
        /// class.
        /// </summary>
        public DeploymentOperationProperties()
        {
        }
    }
}

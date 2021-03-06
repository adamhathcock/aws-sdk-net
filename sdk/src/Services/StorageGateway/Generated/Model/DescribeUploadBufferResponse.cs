/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeUploadBufferResponse : AmazonWebServiceResponse
    {
        private List<string> _diskIds = new List<string>();
        private string _gatewayARN;
        private long? _uploadBufferAllocatedInBytes;
        private long? _uploadBufferUsedInBytes;

        /// <summary>
        /// Gets and sets the property DiskIds.
        /// </summary>
        public List<string> DiskIds
        {
            get { return this._diskIds; }
            set { this._diskIds = value; }
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this._diskIds != null && this._diskIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property UploadBufferAllocatedInBytes.
        /// </summary>
        public long UploadBufferAllocatedInBytes
        {
            get { return this._uploadBufferAllocatedInBytes.GetValueOrDefault(); }
            set { this._uploadBufferAllocatedInBytes = value; }
        }

        // Check to see if UploadBufferAllocatedInBytes property is set
        internal bool IsSetUploadBufferAllocatedInBytes()
        {
            return this._uploadBufferAllocatedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadBufferUsedInBytes.
        /// </summary>
        public long UploadBufferUsedInBytes
        {
            get { return this._uploadBufferUsedInBytes.GetValueOrDefault(); }
            set { this._uploadBufferUsedInBytes = value; }
        }

        // Check to see if UploadBufferUsedInBytes property is set
        internal bool IsSetUploadBufferUsedInBytes()
        {
            return this._uploadBufferUsedInBytes.HasValue; 
        }

    }
}
﻿/* Copyright 2010-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

namespace MongoDB.Driver
{
    /// <summary>
    /// Represents the type of a write request.
    /// </summary>
    public enum WriteRequestType
    {
        /// <summary>
        /// A delete request.
        /// </summary>
        Delete,
        /// <summary>
        /// An insert request.
        /// </summary>
        Insert,
        /// <summary>
        /// An udpate request.
        /// </summary>
        Update
    }

    /// <summary>
    /// Represents a request to write something to the database.
    /// </summary>
    public abstract class WriteRequest
    {
        // private fields
        private readonly WriteRequestType _requestType;

        // constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteRequest"/> class.
        /// </summary>
        /// <param name="requestType">The request type.</param>
        protected WriteRequest(WriteRequestType requestType)
        {
            _requestType = requestType;
        }

        // public properties
        /// <summary>
        /// Gets the request type.
        /// </summary>
        /// <value>
        /// The request type.
        /// </value>
        public WriteRequestType RequestType
        {
            get { return _requestType; }
        }
    }
}

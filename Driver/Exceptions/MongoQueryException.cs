﻿/* Copyright 2010 10gen Inc.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MongoDB.Driver {
    [Serializable]
    public class MongoQueryException : MongoException {
        #region constructors
        public MongoQueryException(
            string message
        )
            : base(message) {
        }

        public MongoQueryException(
            string message,
            Exception innerException
        )
            : base(message, innerException) {
        }

        // this constructor needed to support deserialization
        public MongoQueryException(
            SerializationInfo info,
            StreamingContext context
        )
            : base(info, context) {
        }
        #endregion
    }
}
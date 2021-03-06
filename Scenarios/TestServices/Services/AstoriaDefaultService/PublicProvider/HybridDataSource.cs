//   Copyright 2011 Microsoft Corporation
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

namespace Microsoft.Test.OData.Services.PublicProvider 
{
    using Microsoft.Test.OData.Services.Astoria;
    using Microsoft.Test.OData.Services.AstoriaDefaultService;

    /// <summary>
    /// Hybrid service data source
    /// </summary>
    public class HybridDataSource
    {
        /// <summary>
        /// The database source
        /// </summary>
        public AstoriaDefaultServiceDBEntities DatabaseSource { get; set; }

        /// <summary>
        /// The reflection source
        /// </summary>
        public DefaultContainer ReflectionDataSource { get; set; }
    }
}

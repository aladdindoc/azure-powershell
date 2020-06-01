﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Security.Models.IotSecuritySolutionAnalytics
{
    public class PSIoTSecurityAggregatedAlert : PSResource
    {
        public string AlertType { get; set; }

        public string AlertDisplayName { get; set; }

        public DateTime? AggregatedDateUtc { get; set; }

        public string VendorName { get; set; }

        public string ReportedSeverity { get; set; }

        public string RemediationSteps { get; set; }

        public string Description { get; set; }

        public long? Count { get; set; }

        public string EffectedResourceType { get; set; }

        public string SystemSource { get; set; }

        public string ActionTaken { get; set; }

        public string LogAnalyticsQuery { get; set; }

        public IList<PSTopDevice> TopDevicesList { get; set; }

        public IDictionary<string, string> Tags { get; set; }
    }
}

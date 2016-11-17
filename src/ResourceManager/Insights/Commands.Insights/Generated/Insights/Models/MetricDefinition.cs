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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Insights.Legacy.Models;

namespace Microsoft.Azure.Insights.Legacy.Models
{
    /// <summary>
    /// Metric definition class specifies the metadata for a metric.
    /// </summary>
    public partial class MetricDefinition
    {
        private IList<Dimension> _dimensions;
        
        /// <summary>
        /// Optional. Gets or sets the collection of availability information
        /// defining what timeGrains are available to be queried.
        /// </summary>
        public IList<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }
        
        private IList<MetricAvailability> _metricAvailabilities;
        
        /// <summary>
        /// Optional. Gets or sets the collection of what aggregation intervals
        /// are available to be queried.
        /// </summary>
        public IList<MetricAvailability> MetricAvailabilities
        {
            get { return this._metricAvailabilities; }
            set { this._metricAvailabilities = value; }
        }
        
        private LocalizableString _name;
        
        /// <summary>
        /// Optional. Gets or sets the name and the display name of the metric.
        /// </summary>
        public LocalizableString Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private AggregationType _primaryAggregationType;
        
        /// <summary>
        /// Optional. Gets or sets the primary aggregation type value defining
        /// how to use the values for display.
        /// </summary>
        public AggregationType PrimaryAggregationType
        {
            get { return this._primaryAggregationType; }
            set { this._primaryAggregationType = value; }
        }
        
        private IDictionary<string, string> _properties;
        
        /// <summary>
        /// Optional. Gets or sets the collection of extended properties.
        /// </summary>
        public IDictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _resourceId;
        
        /// <summary>
        /// Optional. Gets or sets the resource identifier of the resource that
        /// has emitted the metric.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private Unit _unit;
        
        /// <summary>
        /// Optional. Gets or sets the unit of the metric.
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
            this.Dimensions = new LazyList<Dimension>();
            this.MetricAvailabilities = new LazyList<MetricAvailability>();
            this.Properties = new LazyDictionary<string, string>();
        }
    }
}

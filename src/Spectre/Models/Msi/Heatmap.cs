﻿/*
 * Heatmap.cs
 * Class representing single heatmap in MALDI MSI sample.
 *
   Copyright 2017 Michał Gallus

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Spectre.Models.Msi
{
    /// <summary>
    /// Provides details about a single heatmap in the dataset.
    /// </summary>
    [DataContract]
    public class Heatmap
    {
        /// <summary>
        /// Gets or sets the mz identifier of the spectrum.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public double Mz { get; set; }

        /// <summary>
        /// Gets or sets the intensities for all coordinates.
        /// </summary>
        /// <value>
        /// The intensities.
        /// </value>
        [DataMember]
        public IEnumerable<double> Intensities { get; set; }

        /// <summary>
        /// Gets or sets the x coordinates.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        [DataMember]
        public IEnumerable<int> X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinates.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        [DataMember]
        public IEnumerable<int> Y { get; set; }
    }
}

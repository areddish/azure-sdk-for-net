// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the detailed performance data for a trained iteration.
    /// </summary>
    public partial class IterationPerformance
    {
        /// <summary>
        /// Initializes a new instance of the IterationPerformance class.
        /// </summary>
        public IterationPerformance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IterationPerformance class.
        /// </summary>
        /// <param name="perTagPerformance">Gets the per-tag performance
        /// details for this iteration.</param>
        /// <param name="precision">Gets the precision.</param>
        /// <param name="precisionStdDeviation">Gets the standard deviation for
        /// the precision.</param>
        /// <param name="recall">Gets the recall.</param>
        /// <param name="recallStdDeviation">Gets the standard deviation for
        /// the recall.</param>
        /// <param name="averagePrecision">Gets the average precision when
        /// applicable.</param>
        public IterationPerformance(IList<TagPerformance> perTagPerformance = default(IList<TagPerformance>), double precision = default(double), double precisionStdDeviation = default(double), double recall = default(double), double recallStdDeviation = default(double), double? averagePrecision = default(double?))
        {
            PerTagPerformance = perTagPerformance;
            Precision = precision;
            PrecisionStdDeviation = precisionStdDeviation;
            Recall = recall;
            RecallStdDeviation = recallStdDeviation;
            AveragePrecision = averagePrecision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the per-tag performance details for this iteration.
        /// </summary>
        [JsonProperty(PropertyName = "perTagPerformance")]
        public IList<TagPerformance> PerTagPerformance { get; private set; }

        /// <summary>
        /// Gets the precision.
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public double Precision { get; private set; }

        /// <summary>
        /// Gets the standard deviation for the precision.
        /// </summary>
        [JsonProperty(PropertyName = "precisionStdDeviation")]
        public double PrecisionStdDeviation { get; private set; }

        /// <summary>
        /// Gets the recall.
        /// </summary>
        [JsonProperty(PropertyName = "recall")]
        public double Recall { get; private set; }

        /// <summary>
        /// Gets the standard deviation for the recall.
        /// </summary>
        [JsonProperty(PropertyName = "recallStdDeviation")]
        public double RecallStdDeviation { get; private set; }

        /// <summary>
        /// Gets the average precision when applicable.
        /// </summary>
        [JsonProperty(PropertyName = "averagePrecision")]
        public double? AveragePrecision { get; private set; }

    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PATCH body schema for Update operation in Update Kb
    /// </summary>
    public partial class UpdateKbContentsDTO
    {
        /// <summary>
        /// Initializes a new instance of the UpdateKbContentsDTO class.
        /// </summary>
        public UpdateKbContentsDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateKbContentsDTO class.
        /// </summary>
        /// <param name="name">Friendly name for the knowledgebase.</param>
        /// <param name="qnaList">List of Q-A (UpdateQnaDTO) to be added to the
        /// knowledgebase.</param>
        /// <param name="urls">List of existing URLs to be refreshed. The
        /// content will be extracted again and re-indexed.</param>
        public UpdateKbContentsDTO(string name = default(string), IList<UpdateQnaDTO> qnaList = default(IList<UpdateQnaDTO>), IList<string> urls = default(IList<string>))
        {
            Name = name;
            QnaList = qnaList;
            Urls = urls;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name for the knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of Q-A (UpdateQnaDTO) to be added to the
        /// knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "qnaList")]
        public IList<UpdateQnaDTO> QnaList { get; set; }

        /// <summary>
        /// Gets or sets list of existing URLs to be refreshed. The content
        /// will be extracted again and re-indexed.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }

    }
}

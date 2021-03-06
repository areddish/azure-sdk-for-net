// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters used to create a new Virtual Machine Extension Image.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VMExtensionParameters
    {
        /// <summary>
        /// Initializes a new instance of the VMExtensionParameters class.
        /// </summary>
        public VMExtensionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMExtensionParameters class.
        /// </summary>
        /// <param name="vmOsType">Target virtual machine operating system type
        /// necessary for deploying the extension handler. Possible values
        /// include: 'Unknown', 'Windows', 'Linux'</param>
        /// <param name="computeRole">Compute role</param>
        /// <param name="vmScaleSetEnabled">Value indicating whether the
        /// extension is enabled for virtual machine scale set support.</param>
        /// <param name="supportMultipleExtensions">True if supports multiple
        /// extensions.</param>
        /// <param name="isSystemExtension">Indicates if the extension is for
        /// the system.</param>
        /// <param name="sourceBlob">URI to Azure or AzureStack blob.</param>
        /// <param name="provisioningState">Provisioning state of extension.
        /// Possible values include: 'Creating', 'Failed', 'Succeeded',
        /// 'Canceled'</param>
        public VMExtensionParameters(OsType? vmOsType = default(OsType?), string computeRole = default(string), bool? vmScaleSetEnabled = default(bool?), bool? supportMultipleExtensions = default(bool?), bool? isSystemExtension = default(bool?), AzureBlob sourceBlob = default(AzureBlob), ProvisioningState? provisioningState = default(ProvisioningState?))
        {
            VmOsType = vmOsType;
            ComputeRole = computeRole;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportMultipleExtensions = supportMultipleExtensions;
            IsSystemExtension = isSystemExtension;
            SourceBlob = sourceBlob;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target virtual machine operating system type necessary
        /// for deploying the extension handler. Possible values include:
        /// 'Unknown', 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmOsType")]
        public OsType? VmOsType { get; set; }

        /// <summary>
        /// Gets or sets compute role
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeRole")]
        public string ComputeRole { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the extension is enabled for
        /// virtual machine scale set support.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmScaleSetEnabled")]
        public bool? VmScaleSetEnabled { get; set; }

        /// <summary>
        /// Gets or sets true if supports multiple extensions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportMultipleExtensions")]
        public bool? SupportMultipleExtensions { get; set; }

        /// <summary>
        /// Gets or sets indicates if the extension is for the system.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isSystemExtension")]
        public bool? IsSystemExtension { get; set; }

        /// <summary>
        /// Gets or sets URI to Azure or AzureStack blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceBlob")]
        public AzureBlob SourceBlob { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of extension. Possible values
        /// include: 'Creating', 'Failed', 'Succeeded', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

    }
}

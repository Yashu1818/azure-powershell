// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// KubernetesClusterPatchParameters represents the body of the request to patch the Hybrid AKS cluster.
    /// </summary>
    public partial class KubernetesClusterPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersInternal
    {

        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public long? ControlPlaneNodeConfigurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).ControlPlaneNodeConfigurationCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).ControlPlaneNodeConfigurationCount = value ?? default(long); }

        /// <summary>
        /// The Kubernetes version for this cluster. Accepts n.n, n.n.n, and n.n.n-n format. The interpreted version used will be
        /// resolved into this field after creation or update.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string KubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).KubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).KubernetesVersion = value ?? null; }

        /// <summary>Internal Acessors for ControlPlaneNodeConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IControlPlaneNodePatchConfiguration Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersInternal.ControlPlaneNodeConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).ControlPlaneNodeConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchPropertiesInternal)Property).ControlPlaneNodeConfiguration = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.KubernetesClusterPatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchProperties _property;

        /// <summary>The list of the resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.KubernetesClusterPatchProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersTags _tag;

        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.KubernetesClusterPatchParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="KubernetesClusterPatchParameters" /> instance.</summary>
        public KubernetesClusterPatchParameters()
        {

        }
    }
    /// KubernetesClusterPatchParameters represents the body of the request to patch the Hybrid AKS cluster.
    public partial interface IKubernetesClusterPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of virtual machines that use this configuration.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? ControlPlaneNodeConfigurationCount { get; set; }
        /// <summary>
        /// The Kubernetes version for this cluster. Accepts n.n, n.n.n, and n.n.n-n format. The interpreted version used will be
        /// resolved into this field after creation or update.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Kubernetes version for this cluster. Accepts n.n, n.n.n, and n.n.n-n format. The interpreted version used will be resolved into this field after creation or update.",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KubernetesVersion { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure resource tags that will replace the existing ones.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersTags Tag { get; set; }

    }
    /// KubernetesClusterPatchParameters represents the body of the request to patch the Hybrid AKS cluster.
    internal partial interface IKubernetesClusterPatchParametersInternal

    {
        /// <summary>
        /// The defining characteristics of the control plane that can be patched for this Kubernetes cluster.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IControlPlaneNodePatchConfiguration ControlPlaneNodeConfiguration { get; set; }
        /// <summary>The number of virtual machines that use this configuration.</summary>
        long? ControlPlaneNodeConfigurationCount { get; set; }
        /// <summary>
        /// The Kubernetes version for this cluster. Accepts n.n, n.n.n, and n.n.n-n format. The interpreted version used will be
        /// resolved into this field after creation or update.
        /// </summary>
        string KubernetesVersion { get; set; }
        /// <summary>The list of the resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchProperties Property { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IKubernetesClusterPatchParametersTags Tag { get; set; }

    }
}
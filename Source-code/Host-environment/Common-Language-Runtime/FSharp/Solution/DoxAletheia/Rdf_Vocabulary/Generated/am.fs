namespace http.open_services.net.ns.asset.hash

open DoxAletheia.Rdf_Vocabulary

module am =
    let _namespace_name = "http://open-services.net/ns/asset#"
    /// <summary>
    /// The Artifact fragment
    /// <see href="http://open-services.net/ns/asset#Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName
    /// <summary>
    /// The Asset resource
    /// <see href="http://open-services.net/ns/asset#Asset"></see></summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName
    /// <summary>
    /// The multi valued list of artifacts.
    ///
    /// <see href="http://open-services.net/ns/asset#artifact"></see></summary>
    let artifact = Namespaced_IRI.parse _namespace_name "artifact" |> NamespacedName

    /// <summary>
    /// Resource URI used to post new artifacts to the asset.
    /// <see href="http://open-services.net/ns/asset#artifactFactory"></see></summary>
    let artifactFactory =
        Namespaced_IRI.parse _namespace_name "artifactFactory" |> NamespacedName

    /// <summary>
    /// 	A categorization to classify an asset. The category schema values are
    /// 		    defined by the service provider. This specification does not define the resource for this
    /// 		    property, however it should contain a dcterms:title property.
    /// <see href="http://open-services.net/ns/asset#categorization"></see></summary>
    let categorization =
        Namespaced_IRI.parse _namespace_name "categorization" |> NamespacedName

    /// <summary>
    /// The media resource reference URI (the artifact bytes).
    ///
    /// <see href="http://open-services.net/ns/asset#content"></see></summary>
    let content = Namespaced_IRI.parse _namespace_name "content" |> NamespacedName
    /// <summary>
    /// An identifier for the asset. Assigned by the service provider
    /// 		    when a resource is created. Different versions of the same asset will
    /// 		    share the same identifier.
    /// <see href="http://open-services.net/ns/asset#guid"></see></summary>
    let guid = Namespaced_IRI.parse _namespace_name "guid" |> NamespacedName
    /// <summary>
    /// A unique identifier for a resource. Assigned by the service provider when
    /// 			a resource is created.
    /// <see href="http://open-services.net/ns/asset#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// The name of the asset manufacturer.
    /// <see href="http://open-services.net/ns/asset#manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// The value of the asset model.
    /// <see href="http://open-services.net/ns/asset#model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    /// The type of this relationship from the perspective of the
    /// 		    oslc_asset:relatedAsset resource based on values defined by the service provider.
    /// 		    This specification does not define the resource for this property, however it
    /// 		    should contain a dcterms:title property.
    ///
    /// <see href="http://open-services.net/ns/asset#relationshipType"></see></summary>
    let relationshipType =
        Namespaced_IRI.parse _namespace_name "relationshipType" |> NamespacedName

    /// <summary>
    /// The serial number assigned by the asset manufacturer.
    /// <see href="http://open-services.net/ns/asset#serialNumber"></see></summary>
    let serialNumber =
        Namespaced_IRI.parse _namespace_name "serialNumber" |> NamespacedName

    /// <summary>
    /// The size of the artifact media resource in bytes.
    ///
    /// <see href="http://open-services.net/ns/asset#size"></see></summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    /// Used to indicate the state of the asset based on values defined by the service provider.
    /// 		This specification does not define the resource for this property, however it should contain a
    /// 		dcterms:title property.
    /// <see href="http://open-services.net/ns/asset#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    /// Specifies the asset tag value for an Asset. Asset tags are typically human
    /// 		    readable labels. For hardware assets, these tags are durable, securely attached to
    /// 		    equipment, and may also be readable by barcode and/or RFID.
    /// <see href="http://open-services.net/ns/asset#tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    /// The version of the asset. Possible values may include '1.0',
    /// 		    '2.0', etc.
    /// <see href="http://open-services.net/ns/asset#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

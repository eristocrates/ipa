namespace http.open_services.net.ns.asset.hash

open DoxAletheia

module am =
    let _namespace_name = "http://open-services.net/ns/asset#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Artifact fragment
    /// <see href="http://open-services.net/ns/asset#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    /// The Asset resource
    /// <see href="http://open-services.net/ns/asset#Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// The multi valued list of artifacts.
    ///
    /// <see href="http://open-services.net/ns/asset#artifact"></see></summary>
    let artifact = _prefix "artifact"
    /// <summary>
    /// Resource URI used to post new artifacts to the asset.
    /// <see href="http://open-services.net/ns/asset#artifactFactory"></see></summary>
    let artifactFactory = _prefix "artifactFactory"
    /// <summary>
    /// 	A categorization to classify an asset. The category schema values are
    /// 		    defined by the service provider. This specification does not define the resource for this
    /// 		    property, however it should contain a dcterms:title property.
    /// <see href="http://open-services.net/ns/asset#categorization"></see></summary>
    let categorization = _prefix "categorization"
    /// <summary>
    /// The media resource reference URI (the artifact bytes).
    ///
    /// <see href="http://open-services.net/ns/asset#content"></see></summary>
    let content = _prefix "content"
    /// <summary>
    /// An identifier for the asset. Assigned by the service provider
    /// 		    when a resource is created. Different versions of the same asset will
    /// 		    share the same identifier.
    /// <see href="http://open-services.net/ns/asset#guid"></see></summary>
    let guid = _prefix "guid"
    /// <summary>
    /// A unique identifier for a resource. Assigned by the service provider when
    /// 			a resource is created.
    /// <see href="http://open-services.net/ns/asset#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// The name of the asset manufacturer.
    /// <see href="http://open-services.net/ns/asset#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// The value of the asset model.
    /// <see href="http://open-services.net/ns/asset#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// The type of this relationship from the perspective of the
    /// 		    oslc_asset:relatedAsset resource based on values defined by the service provider.
    /// 		    This specification does not define the resource for this property, however it
    /// 		    should contain a dcterms:title property.
    ///
    /// <see href="http://open-services.net/ns/asset#relationshipType"></see></summary>
    let relationshipType = _prefix "relationshipType"
    /// <summary>
    /// The serial number assigned by the asset manufacturer.
    /// <see href="http://open-services.net/ns/asset#serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    /// The size of the artifact media resource in bytes.
    ///
    /// <see href="http://open-services.net/ns/asset#size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    /// Used to indicate the state of the asset based on values defined by the service provider.
    /// 		This specification does not define the resource for this property, however it should contain a
    /// 		dcterms:title property.
    /// <see href="http://open-services.net/ns/asset#state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// Specifies the asset tag value for an Asset. Asset tags are typically human
    /// 		    readable labels. For hardware assets, these tags are durable, securely attached to
    /// 		    equipment, and may also be readable by barcode and/or RFID.
    /// <see href="http://open-services.net/ns/asset#tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    /// The version of the asset. Possible values may include '1.0',
    /// 		    '2.0', etc.
    /// <see href="http://open-services.net/ns/asset#version"></see></summary>
    let version = _prefix "version"

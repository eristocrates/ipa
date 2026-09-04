#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module am =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://open-services.net/ns/asset#" "am"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Artifact^^xsd:string</para>
    ///   <para>rdfs:comment : The Artifact fragment^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#Artifact">am:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:label : Asset^^xsd:string</para>
    ///   <para>rdfs:comment : The Asset resource^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#Asset">am:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>rdfs:label : artifact^^xsd:string</para>
    ///   <para>rdfs:comment : The multi valued list of artifacts.
    /// 		^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#artifact">am:artifact</a>
    /// </summary>
    let artifact = _prefixId.prefix "artifact"
    /// <summary>
    ///   <para>rdfs:label : artifactFactory^^xsd:string</para>
    ///   <para>rdfs:comment : Resource URI used to post new artifacts to the asset.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#artifactFactory">am:artifactFactory</a>
    /// </summary>
    let artifactFactory = _prefixId.prefix "artifactFactory"
    /// <summary>
    ///   <para>rdfs:label : categorization^^xsd:string</para>
    ///   <para>rdfs:comment : 	A categorization to classify an asset. The category schema values are
    /// 		    defined by the service provider. This specification does not define the resource for this
    /// 		    property, however it should contain a dcterms:title property.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#categorization">am:categorization</a>
    /// </summary>
    let categorization = _prefixId.prefix "categorization"
    /// <summary>
    ///   <para>rdfs:label : content^^xsd:string</para>
    ///   <para>rdfs:comment : The media resource reference URI (the artifact bytes).
    /// 		^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#content">am:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>rdfs:label : guid^^xsd:string</para>
    ///   <para>rdfs:comment : An identifier for the asset. Assigned by the service provider
    /// 		    when a resource is created. Different versions of the same asset will
    /// 		    share the same identifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#guid">am:guid</a>
    /// </summary>
    let guid = _prefixId.prefix "guid"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <para>rdfs:comment : A unique identifier for a resource. Assigned by the service provider when
    /// 			a resource is created. ^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#identifier">am:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the asset manufacturer.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#manufacturer">am:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:label : model^^xsd:string</para>
    ///   <para>rdfs:comment : The value of the asset model.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#model">am:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>rdfs:label : relationshipType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of this relationship from the perspective of the
    /// 		    oslc_asset:relatedAsset resource based on values defined by the service provider.
    /// 		    This specification does not define the resource for this property, however it
    /// 		    should contain a dcterms:title property.
    /// 		^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#relationshipType">am:relationshipType</a>
    /// </summary>
    let relationshipType = _prefixId.prefix "relationshipType"
    /// <summary>
    ///   <para>rdfs:label : serialNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The serial number assigned by the asset manufacturer.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#serialNumber">am:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    /// <summary>
    ///   <para>rdfs:label : size^^xsd:string</para>
    ///   <para>rdfs:comment : The size of the artifact media resource in bytes.
    /// 		^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#size">am:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : state^^xsd:string</para>
    ///   <para>rdfs:comment : Used to indicate the state of the asset based on values defined by the service provider.
    /// 		This specification does not define the resource for this property, however it should contain a
    /// 		dcterms:title property.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#state">am:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>rdfs:label : tag^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the asset tag value for an Asset. Asset tags are typically human
    /// 		    readable labels. For hardware assets, these tags are durable, securely attached to
    /// 		    equipment, and may also be readable by barcode and/or RFID.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#tag">am:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : The version of the asset. Possible values may include '1.0',
    /// 		    '2.0', etc.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/asset#version">am:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"

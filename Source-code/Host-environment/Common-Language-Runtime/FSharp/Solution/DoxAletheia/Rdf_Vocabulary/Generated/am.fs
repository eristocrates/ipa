namespace http.open_services.net.ns.asset.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module am =
    let _namespace_iri = Namespace_Iri am |> NamespaceIRI
    /// <summary>
    ///   <para>am:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Asset Management(Asset)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#">http://open-services.net/ns/asset#</seealso>
    let _prefix_iri = Prefixed_Name(am, "") |> PrefixedName
    /// <summary>
    ///   <para>am:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Artifact fragment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Artifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#Artifact">http://open-services.net/ns/asset#Artifact</seealso>
    let Artifact = Prefixed_Name(am, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>am:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Asset resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#Asset">http://open-services.net/ns/asset#Asset</seealso>
    let Asset = Prefixed_Name(am, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>am:artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The multi valued list of artifacts.
    /// 		"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"artifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#artifact">http://open-services.net/ns/asset#artifact</seealso>
    let artifact = Prefixed_Name(am, "artifact") |> PrefixedName
    /// <summary>
    ///   <para>am:artifactFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Resource URI used to post new artifacts to the asset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"artifactFactory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#artifactFactory">http://open-services.net/ns/asset#artifactFactory</seealso>
    let artifactFactory = Prefixed_Name(am, "artifactFactory") |> PrefixedName
    /// <summary>
    ///   <para>am:categorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"	A categorization to classify an asset. The category schema values are
    /// 		    defined by the service provider. This specification does not define the resource for this
    /// 		    property, however it should contain a dcterms:title property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"categorization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#categorization">http://open-services.net/ns/asset#categorization</seealso>
    let categorization = Prefixed_Name(am, "categorization") |> PrefixedName
    /// <summary>
    ///   <para>am:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The media resource reference URI (the artifact bytes).
    /// 		"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#content">http://open-services.net/ns/asset#content</seealso>
    let content = Prefixed_Name(am, "content") |> PrefixedName
    /// <summary>
    ///   <para>am:guid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An identifier for the asset. Assigned by the service provider
    /// 		    when a resource is created. Different versions of the same asset will
    /// 		    share the same identifier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"guid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#guid">http://open-services.net/ns/asset#guid</seealso>
    let guid = Prefixed_Name(am, "guid") |> PrefixedName
    /// <summary>
    ///   <para>am:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A unique identifier for a resource. Assigned by the service provider when
    /// 			a resource is created. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#identifier">http://open-services.net/ns/asset#identifier</seealso>
    let identifier = Prefixed_Name(am, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>am:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the asset manufacturer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manufacturer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#manufacturer">http://open-services.net/ns/asset#manufacturer</seealso>
    let manufacturer = Prefixed_Name(am, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>am:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The value of the asset model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#model">http://open-services.net/ns/asset#model</seealso>
    let model = Prefixed_Name(am, "model") |> PrefixedName
    /// <summary>
    ///   <para>am:relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of this relationship from the perspective of the
    /// 		    oslc_asset:relatedAsset resource based on values defined by the service provider.
    /// 		    This specification does not define the resource for this property, however it
    /// 		    should contain a dcterms:title property.
    /// 		"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relationshipType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#relationshipType">http://open-services.net/ns/asset#relationshipType</seealso>
    let relationshipType = Prefixed_Name(am, "relationshipType") |> PrefixedName
    /// <summary>
    ///   <para>am:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The serial number assigned by the asset manufacturer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serialNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#serialNumber">http://open-services.net/ns/asset#serialNumber</seealso>
    let serialNumber = Prefixed_Name(am, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>am:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The size of the artifact media resource in bytes.
    /// 		"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#size">http://open-services.net/ns/asset#size</seealso>
    let size = Prefixed_Name(am, "size") |> PrefixedName
    /// <summary>
    ///   <para>am:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to indicate the state of the asset based on values defined by the service provider.
    /// 		This specification does not define the resource for this property, however it should contain a
    /// 		dcterms:title property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#state">http://open-services.net/ns/asset#state</seealso>
    let state = Prefixed_Name(am, "state") |> PrefixedName
    /// <summary>
    ///   <para>am:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the asset tag value for an Asset. Asset tags are typically human
    /// 		    readable labels. For hardware assets, these tags are durable, securely attached to
    /// 		    equipment, and may also be readable by barcode and/or RFID."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#tag">http://open-services.net/ns/asset#tag</seealso>
    let tag = Prefixed_Name(am, "tag") |> PrefixedName
    /// <summary>
    ///   <para>am:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The version of the asset. Possible values may include '1.0',
    /// 		    '2.0', etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#version">http://open-services.net/ns/asset#version</seealso>
    let version = Prefixed_Name(am, "version") |> PrefixedName

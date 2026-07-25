namespace http.open_services.net.ns.asset.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module am =
    let _namespace_iri = Namespace_Iri am |> NamespaceIRI
    /// <summary>
    ///   <para>am:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Artifact fragment</para>
    /// labels<para>Artifact</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#Artifact">http://open-services.net/ns/asset#Artifact</seealso>
    let Artifact = Prefixed_Name(am, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>am:categorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>	A categorization to classify an asset. The category schema values are
    /// 		    defined by the service provider. This specification does not define the resource for this
    /// 		    property, however it should contain a dcterms:title property.</para>
    /// labels<para>categorization</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#categorization">http://open-services.net/ns/asset#categorization</seealso>
    let categorization = Prefixed_Name(am, "categorization") |> PrefixedName
    /// <summary>
    ///   <para>am:guid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An identifier for the asset. Assigned by the service provider
    /// 		    when a resource is created. Different versions of the same asset will
    /// 		    share the same identifier.</para>
    /// labels<para>guid</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#guid">http://open-services.net/ns/asset#guid</seealso>
    let guid = Prefixed_Name(am, "guid") |> PrefixedName
    /// <summary>
    ///   <para>am:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Asset resource</para>
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#Asset">http://open-services.net/ns/asset#Asset</seealso>
    let Asset = Prefixed_Name(am, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>am:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The media resource reference URI (the artifact bytes).
    /// 		</para>
    /// labels<para>content</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#content">http://open-services.net/ns/asset#content</seealso>
    let content = Prefixed_Name(am, "content") |> PrefixedName
    /// <summary>
    ///   <para>am:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value of the asset model.</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#model">http://open-services.net/ns/asset#model</seealso>
    let model = Prefixed_Name(am, "model") |> PrefixedName
    /// <summary>
    ///   <para>am:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the state of the asset based on values defined by the service provider.
    /// 		This specification does not define the resource for this property, however it should contain a
    /// 		dcterms:title property.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#state">http://open-services.net/ns/asset#state</seealso>
    let state = Prefixed_Name(am, "state") |> PrefixedName
    /// <summary>
    ///   <para>am:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A unique identifier for a resource. Assigned by the service provider when
    /// 			a resource is created. </para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#identifier">http://open-services.net/ns/asset#identifier</seealso>
    let identifier = Prefixed_Name(am, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>am:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The serial number assigned by the asset manufacturer.</para>
    /// labels<para>serialNumber</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#serialNumber">http://open-services.net/ns/asset#serialNumber</seealso>
    let serialNumber = Prefixed_Name(am, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>am:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the artifact media resource in bytes.
    /// 		</para>
    /// labels<para>size</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#size">http://open-services.net/ns/asset#size</seealso>
    let size = Prefixed_Name(am, "size") |> PrefixedName
    /// <summary>
    ///   <para>am:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the asset tag value for an Asset. Asset tags are typically human
    /// 		    readable labels. For hardware assets, these tags are durable, securely attached to
    /// 		    equipment, and may also be readable by barcode and/or RFID.</para>
    /// labels<para>tag</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#tag">http://open-services.net/ns/asset#tag</seealso>
    let tag = Prefixed_Name(am, "tag") |> PrefixedName
    /// <summary>
    ///   <para>am:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the asset manufacturer.</para>
    /// labels<para>manufacturer</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#manufacturer">http://open-services.net/ns/asset#manufacturer</seealso>
    let manufacturer = Prefixed_Name(am, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>am:relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of this relationship from the perspective of the
    /// 		    oslc_asset:relatedAsset resource based on values defined by the service provider.
    /// 		    This specification does not define the resource for this property, however it
    /// 		    should contain a dcterms:title property.
    /// 		</para>
    /// labels<para>relationshipType</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#relationshipType">http://open-services.net/ns/asset#relationshipType</seealso>
    let relationshipType = Prefixed_Name(am, "relationshipType") |> PrefixedName
    /// <summary>
    ///   <para>am:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The version of the asset. Possible values may include '1.0',
    /// 		    '2.0', etc.</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#version">http://open-services.net/ns/asset#version</seealso>
    let version = Prefixed_Name(am, "version") |> PrefixedName
    /// <summary>
    ///   <para>am:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Asset Management(Asset)</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#">http://open-services.net/ns/asset#</seealso>
    let _prefix_iri = Prefixed_Name(am, "") |> PrefixedName
    /// <summary>
    ///   <para>am:artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The multi valued list of artifacts.
    /// 		</para>
    /// labels<para>artifact</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#artifact">http://open-services.net/ns/asset#artifact</seealso>
    let artifact = Prefixed_Name(am, "artifact") |> PrefixedName
    /// <summary>
    ///   <para>am:artifactFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Resource URI used to post new artifacts to the asset.</para>
    /// labels<para>artifactFactory</para></remarks>
    /// <seealso href="http://open-services.net/ns/asset#artifactFactory">http://open-services.net/ns/asset#artifactFactory</seealso>
    let artifactFactory = Prefixed_Name(am, "artifactFactory") |> PrefixedName

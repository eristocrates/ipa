namespace http.purl.org.ctic.dcat.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ds =
    let _namespace_iri = Namespace_Iri ds |> NamespaceIRI
    /// <summary>
    ///   <para>ds:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Catalog which have defined datasets in</para>
    ///   <para>Catálogo donde se expresan conjuntos de datos</para>
    /// labels<para>Catálogo de datasets</para><para>Catalog of Datasets</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#Catalog">http://purl.org/ctic/dcat#Catalog</seealso>
    let Catalog = Prefixed_Name(ds, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>ds:accessMode-direct</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#accessMode-direct">http://purl.org/ctic/dcat#accessMode-direct</seealso>
    let accessMode_direct = Prefixed_Name(ds, "accessMode-direct") |> PrefixedName
    /// <summary>
    ///   <para>ds:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Propiedad que define que el Catálogo tiene un Dataset como miembro del mismo</para>
    ///   <para>Property which defines a Dataset member of the Catalog</para>
    /// labels<para>Un Catálogo tiene un Dataset como miembro del mismo</para><para>A Catalog has a Dataset member</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#member">http://purl.org/ctic/dcat#member</seealso>
    let member_ = Prefixed_Name(ds, "member") |> PrefixedName
    /// <summary>
    ///   <para>ds:status-ldFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-ldFormat">http://purl.org/ctic/dcat#status-ldFormat</seealso>
    let status_ldFormat = Prefixed_Name(ds, "status-ldFormat") |> PrefixedName

    /// <summary>
    ///   <para>ds:status-nonProprietaryFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-nonProprietaryFormat">http://purl.org/ctic/dcat#status-nonProprietaryFormat</seealso>
    let status_nonProprietaryFormat =
        Prefixed_Name(ds, "status-nonProprietaryFormat") |> PrefixedName

    /// <summary>
    ///   <para>ds:status-announced</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-announced">http://purl.org/ctic/dcat#status-announced</seealso>
    let status_announced = Prefixed_Name(ds, "status-announced") |> PrefixedName
    /// <summary>
    ///   <para>ds:status-linkedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-linkedData">http://purl.org/ctic/dcat#status-linkedData</seealso>
    let status_linkedData = Prefixed_Name(ds, "status-linkedData") |> PrefixedName
    /// <summary>
    ///   <para>ds:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Este vocabulario se utiliza para modelar los catálogos de conjuntos de datos y las relaciones con los datasets</para>
    ///   <para>This vocabulary is used for modelling catalogs of datasets and its relationships with the datasets</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#">http://purl.org/ctic/dcat#</seealso>
    let _prefix_iri = Prefixed_Name(ds, "") |> PrefixedName
    /// <summary>
    ///   <para>ds:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Un conjunto de datos</para>
    ///   <para>A dataset</para>
    /// labels<para>Dataset</para><para>Dataset</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#Dataset">http://purl.org/ctic/dcat#Dataset</seealso>
    let Dataset = Prefixed_Name(ds, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>ds:accessModeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Concept scheme of the different access modes to the information distributions</para>
    ///   <para>Taxonomía de los tipos de acceso a las distribuciones de la información</para>
    /// labels<para>Taxonomía de los tipos de acceso a la información</para><para>Taxonomy of the information access mode</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#accessModeScheme">http://purl.org/ctic/dcat#accessModeScheme</seealso>
    let accessModeScheme = Prefixed_Name(ds, "accessModeScheme") |> PrefixedName
    /// <summary>
    ///   <para>ds:accessMode-indirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#accessMode-indirect">http://purl.org/ctic/dcat#accessMode-indirect</seealso>
    let accessMode_indirect = Prefixed_Name(ds, "accessMode-indirect") |> PrefixedName
    /// <summary>
    ///   <para>ds:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Propiedad que define un Catálogo al que pertenece el Dataset</para>
    ///   <para>Property which defines a Catalog that contains the Dataset</para>
    /// labels<para>Un Dataset es miembro de un Catálogo</para><para>A Dataset is a member of a Catalog</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#memberOf">http://purl.org/ctic/dcat#memberOf</seealso>
    let memberOf = Prefixed_Name(ds, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>ds:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property which defines the status of the Dataset according to a defined taxonomy</para>
    ///   <para>Propiedad que define el estado del catálogo en función de una taxonomía determinada</para>
    /// labels<para>Estado del catálogo</para><para>Catalog status</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status">http://purl.org/ctic/dcat#status</seealso>
    let status = Prefixed_Name(ds, "status") |> PrefixedName
    /// <summary>
    ///   <para>ds:statusScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Esquema de conceptos de los estados que puede tomar un catálogo</para>
    ///   <para>Concept scheme of the different statuses for a catalog</para>
    /// labels<para>Taxonomía de los estados de un catálogo</para><para>Taxonomy of the catalog statuses</para></remarks>
    /// <seealso href="http://purl.org/ctic/dcat#statusScheme">http://purl.org/ctic/dcat#statusScheme</seealso>
    let statusScheme = Prefixed_Name(ds, "statusScheme") |> PrefixedName
    /// <summary>
    ///   <para>ds:status-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-data">http://purl.org/ctic/dcat#status-data</seealso>
    let status_data = Prefixed_Name(ds, "status-data") |> PrefixedName
    /// <summary>
    ///   <para>ds:status-extinct</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-extinct">http://purl.org/ctic/dcat#status-extinct</seealso>
    let status_extinct = Prefixed_Name(ds, "status-extinct") |> PrefixedName

    /// <summary>
    ///   <para>ds:status-structuredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/dcat#status-structuredData">http://purl.org/ctic/dcat#status-structuredData</seealso>
    let status_structuredData =
        Prefixed_Name(ds, "status-structuredData") |> PrefixedName

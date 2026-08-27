namespace https.w3id.org.aerOS.data_catalog.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aosdatcat =
    let _namespace_iri = Namespace_Iri aosdatcat |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"aerOS Data Catalog Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#">https://w3id.org/aerOS/data-catalog#</seealso>
    let _prefix_iri = Prefixed_Name(aosdatcat, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#ContextBroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an NGSI-LD Context Broker."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Broker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#ContextBroker">https://w3id.org/aerOS/data-catalog#ContextBroker</seealso>
    let ContextBroker = Prefixed_Name(aosdatcat, "ContextBroker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#DataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Representation of a data product as wrapper of a dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#DataProduct">https://w3id.org/aerOS/data-catalog#DataProduct</seealso>
    let DataProduct = Prefixed_Name(aosdatcat, "DataProduct") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#DataProductOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>org:Role</para>
    ///   <para>"Person responsible for the creation and publication of a data product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Product Owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#DataProductOwner">https://w3id.org/aerOS/data-catalog#DataProductOwner</seealso>
    let DataProductOwner = Prefixed_Name(aosdatcat, "DataProductOwner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#contextBroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation with a context broker."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"context broker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#contextBroker">https://w3id.org/aerOS/data-catalog#contextBroker</seealso>
    let contextBroker = Prefixed_Name(aosdatcat, "contextBroker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#dataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation with a data product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"data product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#dataProduct">https://w3id.org/aerOS/data-catalog#dataProduct</seealso>
    let dataProduct = Prefixed_Name(aosdatcat, "dataProduct") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/data-catalog#servesDataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a data product exposed by a data service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serves data product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#servesDataProduct">https://w3id.org/aerOS/data-catalog#servesDataProduct</seealso>
    let servesDataProduct =
        Prefixed_Name(aosdatcat, "servesDataProduct") |> PrefixedName

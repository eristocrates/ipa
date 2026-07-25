namespace https.w3id.org.aerOS.data_catalog.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aosdatcat =
    let _namespace_iri = Namespace_Iri aosdatcat |> NamespaceIRI
    /// <summary>
    ///   <para>aosdatcat:DataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Representation of a data product as wrapper of a dataset.</para>
    /// labels<para>Data Product</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#DataProduct">https://w3id.org/aerOS/data-catalog#DataProduct</seealso>
    let DataProduct = Prefixed_Name(aosdatcat, "DataProduct") |> PrefixedName
    /// <summary>
    ///   <para>aosdatcat:dataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation with a data product.</para>
    /// labels<para>data product</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#dataProduct">https://w3id.org/aerOS/data-catalog#dataProduct</seealso>
    let dataProduct = Prefixed_Name(aosdatcat, "dataProduct") |> PrefixedName
    /// <summary>
    ///   <para>aosdatcat:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>aerOS Data Catalog Ontology</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#">https://w3id.org/aerOS/data-catalog#</seealso>
    let _prefix_iri = Prefixed_Name(aosdatcat, "") |> PrefixedName
    /// <summary>
    ///   <para>aosdatcat:ContextBroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an NGSI-LD Context Broker.</para>
    /// labels<para>Context Broker</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#ContextBroker">https://w3id.org/aerOS/data-catalog#ContextBroker</seealso>
    let ContextBroker = Prefixed_Name(aosdatcat, "ContextBroker") |> PrefixedName
    /// <summary>
    ///   <para>aosdatcat:contextBroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation with a context broker.</para>
    /// labels<para>context broker</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#contextBroker">https://w3id.org/aerOS/data-catalog#contextBroker</seealso>
    let contextBroker = Prefixed_Name(aosdatcat, "contextBroker") |> PrefixedName
    /// <summary>
    ///   <para>aosdatcat:DataProductOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>org:Role</para>
    ///   <para>Person responsible for the creation and publication of a data product.</para>
    /// labels<para>Data Product Owner</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#DataProductOwner">https://w3id.org/aerOS/data-catalog#DataProductOwner</seealso>
    let DataProductOwner = Prefixed_Name(aosdatcat, "DataProductOwner") |> PrefixedName

    /// <summary>
    ///   <para>aosdatcat:servesDataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Denotes a data product exposed by a data service.</para>
    /// labels<para>serves data product</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog#servesDataProduct">https://w3id.org/aerOS/data-catalog#servesDataProduct</seealso>
    let servesDataProduct =
        Prefixed_Name(aosdatcat, "servesDataProduct") |> PrefixedName

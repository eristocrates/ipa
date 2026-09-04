#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ds =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ctic/dcat#" "ds"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2009-09-28^^xsd:string</para>
    ///   <para>skos:definition : Catalog which have defined datasets inskos:definition : Catálogo donde se expresan conjuntos de datos</para>
    ///   <para>rdfs:comment : Catalog which have defined datasets inrdfs:comment : Catálogo donde se expresan conjuntos de datos</para>
    ///   <para>rdfs:label : Catalog of Datasetsrdfs:label : Catálogo de datasets</para>
    ///   <a href="http://purl.org/ctic/dcat#Catalog">ds:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:comment : Un conjunto de datosrdfs:comment : A dataset</para>
    ///   <para>skos:definition : A datasetskos:definition : Un conjunto de datos</para>
    ///   <para>rdfs:label : Datasetrdfs:label : Dataset</para>
    ///   <para>dcterms:issued : 2009-09-28^^xsd:string</para>
    ///   <a href="http://purl.org/ctic/dcat#Dataset">ds:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    let accessMode_direct = _prefixId.prefix "accessMode-direct"
    let accessMode_indirect = _prefixId.prefix "accessMode-indirect"
    let accessModeScheme = _prefixId.prefix "accessModeScheme"
    /// <summary>
    ///   <para>rdfs:label : Un Catálogo tiene un Dataset como miembro del mismordfs:label : A Catalog has a Dataset member</para>
    ///   <para>skos:definition : Property which defines a Dataset member of the Catalogskos:definition : Propiedad que define que el Catálogo tiene un Dataset como miembro del mismo</para>
    ///   <para>dcterms:issued : 2010-04-06^^xsd:string</para>
    ///   <para>rdfs:comment : Property which defines a Dataset member of the Catalogrdfs:comment : Propiedad que define que el Catálogo tiene un Dataset como miembro del mismo</para>
    ///   <a href="http://purl.org/ctic/dcat#member">ds:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : Property which defines a Catalog that contains the Datasetrdfs:comment : Propiedad que define un Catálogo al que pertenece el Dataset</para>
    ///   <para>skos:definition : Property which defines a Catalog that contains the Datasetskos:definition : Propiedad que define un Catálogo al que pertenece el Dataset</para>
    ///   <para>rdfs:label : Un Dataset es miembro de un Catálogordfs:label : A Dataset is a member of a Catalog</para>
    ///   <para>dcterms:issued : 2009-09-28^^xsd:string</para>
    ///   <a href="http://purl.org/ctic/dcat#memberOf">ds:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>dcterms:issued : 2010-09-01^^xsd:string</para>
    ///   <para>skos:definition : Propiedad que define el estado del catálogo en función de una taxonomía determinadaskos:definition : Property which defines the status of the Dataset according to a defined taxonomy</para>
    ///   <para>rdfs:label : Estado del catálogordfs:label : Catalog status</para>
    ///   <para>rdfs:comment : Propiedad que define el estado del catálogo en función de una taxonomía determinadardfs:comment : Property which defines the status of the Dataset according to a defined taxonomy</para>
    ///   <a href="http://purl.org/ctic/dcat#status">ds:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    let status_announced = _prefixId.prefix "status-announced"
    let status_data = _prefixId.prefix "status-data"
    let status_extinct = _prefixId.prefix "status-extinct"
    let status_ldFormat = _prefixId.prefix "status-ldFormat"
    let status_linkedData = _prefixId.prefix "status-linkedData"
    let status_nonProprietaryFormat = _prefixId.prefix "status-nonProprietaryFormat"
    let status_structuredData = _prefixId.prefix "status-structuredData"
    let statusScheme = _prefixId.prefix "statusScheme"

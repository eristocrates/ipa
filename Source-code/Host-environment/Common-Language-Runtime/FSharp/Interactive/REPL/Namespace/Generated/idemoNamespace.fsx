#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module idemo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdf.insee.fr/def/demo#" "idemo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Population légale datée et déclinée en 'municipale', 'comptée à part' et 'totale'</para>
    ///   <para>rdfs:label : Population légale</para>
    ///   <a href="http://rdf.insee.fr/def/demo#PopulationLegale">idemo:PopulationLegale</a>
    /// </summary>
    let PopulationLegale = _prefixId.prefix "PopulationLegale"
    /// <summary>
    ///   <para>rdfs:label : date de référence</para>
    ///   <a href="http://rdf.insee.fr/def/demo#date">idemo:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : population</para>
    ///   <a href="http://rdf.insee.fr/def/demo#population">idemo:population</a>
    /// </summary>
    let population = _prefixId.prefix "population"
    /// <summary>
    ///   <para>rdfs:label : population comptée à part</para>
    ///   <a href="http://rdf.insee.fr/def/demo#populationCompteeAPart">idemo:populationCompteeAPart</a>
    /// </summary>
    let populationCompteeAPart = _prefixId.prefix "populationCompteeAPart"
    /// <summary>
    ///   <para>rdfs:label : population municipale</para>
    ///   <a href="http://rdf.insee.fr/def/demo#populationMunicipale">idemo:populationMunicipale</a>
    /// </summary>
    let populationMunicipale = _prefixId.prefix "populationMunicipale"
    /// <summary>
    ///   <para>rdfs:label : population totale</para>
    ///   <a href="http://rdf.insee.fr/def/demo#populationTotale">idemo:populationTotale</a>
    /// </summary>
    let populationTotale = _prefixId.prefix "populationTotale"

namespace http.rdf.insee.fr.def.demo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module idemo =
    let _namespace_iri = Namespace_Iri idemo |> NamespaceIRI
    /// <summary>
    ///   <para>idemo:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#">http://rdf.insee.fr/def/demo#</seealso>
    let _prefix_iri = Prefixed_Name(idemo, "") |> PrefixedName
    /// <summary>
    ///   <para>idemo:PopulationLegale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Population légale datée et déclinée en 'municipale', 'comptée à part' et 'totale'"</para>
    /// labels<para>"Population légale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#PopulationLegale">http://rdf.insee.fr/def/demo#PopulationLegale</seealso>
    let PopulationLegale = Prefixed_Name(idemo, "PopulationLegale") |> PrefixedName
    /// <summary>
    ///   <para>idemo:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date de référence"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#date">http://rdf.insee.fr/def/demo#date</seealso>
    let date = Prefixed_Name(idemo, "date") |> PrefixedName
    /// <summary>
    ///   <para>idemo:population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"population"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#population">http://rdf.insee.fr/def/demo#population</seealso>
    let population = Prefixed_Name(idemo, "population") |> PrefixedName

    /// <summary>
    ///   <para>idemo:populationCompteeAPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"population comptée à part"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#populationCompteeAPart">http://rdf.insee.fr/def/demo#populationCompteeAPart</seealso>
    let populationCompteeAPart =
        Prefixed_Name(idemo, "populationCompteeAPart") |> PrefixedName

    /// <summary>
    ///   <para>idemo:populationMunicipale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"population municipale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#populationMunicipale">http://rdf.insee.fr/def/demo#populationMunicipale</seealso>
    let populationMunicipale =
        Prefixed_Name(idemo, "populationMunicipale") |> PrefixedName

    /// <summary>
    ///   <para>idemo:populationTotale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"population totale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/demo#populationTotale">http://rdf.insee.fr/def/demo#populationTotale</seealso>
    let populationTotale = Prefixed_Name(idemo, "populationTotale") |> PrefixedName

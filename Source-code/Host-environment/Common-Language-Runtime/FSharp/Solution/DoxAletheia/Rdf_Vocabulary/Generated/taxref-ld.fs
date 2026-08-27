namespace http.taxref.mnhn.fr.lod.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module taxref_ld =
    let _namespace_iri = Namespace_Iri taxref_ld |> NamespaceIRI
    /// <summary>
    ///   <para>taxref-ld:sandrinetercerie</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/sandrinetercerie">http://taxref.mnhn.fr/lod/sandrinetercerie</seealso>
    let sandrinetercerie = Prefixed_Name(taxref_ld, "sandrinetercerie") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:sparql-service</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:GraphCollection</para>
    ///   <para>sd:Service</para>
    ///   <para>dcat:DataService</para>
    ///
    /// labels<para>"SPARQL endpoint serving the TAXREF-LD Knowledge Graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/sparql-service">http://taxref.mnhn.fr/lod/sparql-service</seealso>
    let sparql_service = Prefixed_Name(taxref_ld, "sparql-service") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/Mandatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Mandatory"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/Mandatory">http://taxref.mnhn.fr/lod/specificity/Mandatory</seealso>
    let ``specificity/Mandatory`` =
        Prefixed_Name(taxref_ld, "specificity/Mandatory") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/Optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Optional"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/Optional">http://taxref.mnhn.fr/lod/specificity/Optional</seealso>
    let ``specificity/Optional`` =
        Prefixed_Name(taxref_ld, "specificity/Optional") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/Principal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Principal"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/Principal">http://taxref.mnhn.fr/lod/specificity/Principal</seealso>
    let ``specificity/Principal`` =
        Prefixed_Name(taxref_ld, "specificity/Principal") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/Regular</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Regular"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/Regular">http://taxref.mnhn.fr/lod/specificity/Regular</seealso>
    let ``specificity/Regular`` =
        Prefixed_Name(taxref_ld, "specificity/Regular") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/SpecificityCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of interaction specificities"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/SpecificityCollection">http://taxref.mnhn.fr/lod/specificity/SpecificityCollection</seealso>
    let ``specificity/SpecificityCollection`` =
        Prefixed_Name(taxref_ld, "specificity/SpecificityCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:specificity/Sporadic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Sporadic"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/specificity/Sporadic">http://taxref.mnhn.fr/lod/specificity/Sporadic</seealso>
    let ``specificity/Sporadic`` =
        Prefixed_Name(taxref_ld, "specificity/Sporadic") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/BioGeographicalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The biogeographical status of a taxon with the geographical area where this status applies and the bibliographic source that assigned this status to that taxon"</para>
    /// labels<para>"Biogeographical status of a taxon in a geographical area, according to a bibliographic source"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/BioGeographicalStatus">http://taxref.mnhn.fr/lod/status/BioGeographicalStatus</seealso>
    let ``status/BioGeographicalStatus`` =
        Prefixed_Name(taxref_ld, "status/BioGeographicalStatus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/EuropeanDirective</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/EuropeanDirective">http://taxref.mnhn.fr/lod/status/EuropeanDirective</seealso>
    let ``status/EuropeanDirective`` =
        Prefixed_Name(taxref_ld, "status/EuropeanDirective") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/InternationalConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/InternationalConvention">http://taxref.mnhn.fr/lod/status/InternationalConvention</seealso>
    let ``status/InternationalConvention`` =
        Prefixed_Name(taxref_ld, "status/InternationalConvention") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/LegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>"To be used jointly with http://taxref.mnhn.fr/lod/status/TaxonStatusType whose narrower concepts represent directives, conventions, regulations or protections"</para>
    /// labels<para>"Status of a taxon attested by a legal document"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/LegalStatus">http://taxref.mnhn.fr/lod/status/LegalStatus</seealso>
    let ``status/LegalStatus`` =
        Prefixed_Name(taxref_ld, "status/LegalStatus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/Protection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/Protection">http://taxref.mnhn.fr/lod/status/Protection</seealso>
    let ``status/Protection`` =
        Prefixed_Name(taxref_ld, "status/Protection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/RedList/CR%2A</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q82673</para>
    ///
    /// labels<para>"Disparue au niveau régional mais on ne sait pas si elle est éteinte au niveau mondial"</para><para>"Extinct regionaly and possibly extinct worldwide"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/RedList/CR%2A">http://taxref.mnhn.fr/lod/status/RedList/CR%2A</seealso>
    let ``status/RedList/CR%2A`` =
        Prefixed_Name(taxref_ld, "status/RedList/CR%2A") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/RedList/NA</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q82673</para>
    ///
    /// labels<para>"Not applicable"</para><para>"Non applicable"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/RedList/NA">http://taxref.mnhn.fr/lod/status/RedList/NA</seealso>
    let ``status/RedList/NA`` =
        Prefixed_Name(taxref_ld, "status/RedList/NA") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/RedList/RE%3F</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q82673</para>
    ///
    /// labels<para>"Probably extinct regionaly"</para><para>"Probablement disparue au niveau régional"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/RedList/RE%3F">http://taxref.mnhn.fr/lod/status/RedList/RE%3F</seealso>
    let ``status/RedList/RE%3F`` =
        Prefixed_Name(taxref_ld, "status/RedList/RE%3F") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/RedListStatus</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"IUCN Red List status of a taxon in a geographical area, according to a bibliographic source"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/RedListStatus">http://taxref.mnhn.fr/lod/status/RedListStatus</seealso>
    let ``status/RedListStatus`` =
        Prefixed_Name(taxref_ld, "status/RedListStatus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/Regulation">http://taxref.mnhn.fr/lod/status/Regulation</seealso>
    let ``status/Regulation`` =
        Prefixed_Name(taxref_ld, "status/Regulation") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/TaxonStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relates a biogeographical, conservation or legal status of a taxon with the geographical location where this status is valid and the bibliographic source that assigned this status to that taxon"</para>
    /// labels<para>"Biogeographical, conservation or legal status of a taxon"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/TaxonStatus">http://taxref.mnhn.fr/lod/status/TaxonStatus</seealso>
    let ``status/TaxonStatus`` =
        Prefixed_Name(taxref_ld, "status/TaxonStatus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:status/TaxonStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/status/TaxonStatusType">http://taxref.mnhn.fr/lod/status/TaxonStatusType</seealso>
    let ``status/TaxonStatusType`` =
        Prefixed_Name(taxref_ld, "status/TaxonStatusType") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Abberatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Abberatio">http://taxref.mnhn.fr/lod/taxrank/Abberatio</seealso>
    let ``taxrank/Abberatio`` =
        Prefixed_Name(taxref_ld, "taxrank/Abberatio") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Agregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Agregate">http://taxref.mnhn.fr/lod/taxrank/Agregate</seealso>
    let ``taxrank/Agregate`` =
        Prefixed_Name(taxref_ld, "taxrank/Agregate") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Cladus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Cladus">http://taxref.mnhn.fr/lod/taxrank/Cladus</seealso>
    let ``taxrank/Cladus`` = Prefixed_Name(taxref_ld, "taxrank/Cladus") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Class">http://taxref.mnhn.fr/lod/taxrank/Class</seealso>
    let ``taxrank/Class`` = Prefixed_Name(taxref_ld, "taxrank/Class") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Clone</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Clone">http://taxref.mnhn.fr/lod/taxrank/Clone</seealso>
    let ``taxrank/Clone`` = Prefixed_Name(taxref_ld, "taxrank/Clone") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Cohort</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Cohort">http://taxref.mnhn.fr/lod/taxrank/Cohort</seealso>
    let ``taxrank/Cohort`` = Prefixed_Name(taxref_ld, "taxrank/Cohort") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Cultivar</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Cultivar">http://taxref.mnhn.fr/lod/taxrank/Cultivar</seealso>
    let ``taxrank/Cultivar`` =
        Prefixed_Name(taxref_ld, "taxrank/Cultivar") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Division">http://taxref.mnhn.fr/lod/taxrank/Division</seealso>
    let ``taxrank/Division`` =
        Prefixed_Name(taxref_ld, "taxrank/Division") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Domain">http://taxref.mnhn.fr/lod/taxrank/Domain</seealso>
    let ``taxrank/Domain`` = Prefixed_Name(taxref_ld, "taxrank/Domain") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Family">http://taxref.mnhn.fr/lod/taxrank/Family</seealso>
    let ``taxrank/Family`` = Prefixed_Name(taxref_ld, "taxrank/Family") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Forma</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Forma">http://taxref.mnhn.fr/lod/taxrank/Forma</seealso>
    let ``taxrank/Forma`` = Prefixed_Name(taxref_ld, "taxrank/Forma") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/FormaSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/FormaSpecies">http://taxref.mnhn.fr/lod/taxrank/FormaSpecies</seealso>
    let ``taxrank/FormaSpecies`` =
        Prefixed_Name(taxref_ld, "taxrank/FormaSpecies") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Genus">http://taxref.mnhn.fr/lod/taxrank/Genus</seealso>
    let ``taxrank/Genus`` = Prefixed_Name(taxref_ld, "taxrank/Genus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/InfraClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/InfraClass">http://taxref.mnhn.fr/lod/taxrank/InfraClass</seealso>
    let ``taxrank/InfraClass`` =
        Prefixed_Name(taxref_ld, "taxrank/InfraClass") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/InfraKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/InfraKingdom">http://taxref.mnhn.fr/lod/taxrank/InfraKingdom</seealso>
    let ``taxrank/InfraKingdom`` =
        Prefixed_Name(taxref_ld, "taxrank/InfraKingdom") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/InfraOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/InfraOrder">http://taxref.mnhn.fr/lod/taxrank/InfraOrder</seealso>
    let ``taxrank/InfraOrder`` =
        Prefixed_Name(taxref_ld, "taxrank/InfraOrder") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/InfraPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/InfraPhylum">http://taxref.mnhn.fr/lod/taxrank/InfraPhylum</seealso>
    let ``taxrank/InfraPhylum`` =
        Prefixed_Name(taxref_ld, "taxrank/InfraPhylum") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Kingdom">http://taxref.mnhn.fr/lod/taxrank/Kingdom</seealso>
    let ``taxrank/Kingdom`` =
        Prefixed_Name(taxref_ld, "taxrank/Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Legio</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Legio">http://taxref.mnhn.fr/lod/taxrank/Legio</seealso>
    let ``taxrank/Legio`` = Prefixed_Name(taxref_ld, "taxrank/Legio") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Linea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Linea">http://taxref.mnhn.fr/lod/taxrank/Linea</seealso>
    let ``taxrank/Linea`` = Prefixed_Name(taxref_ld, "taxrank/Linea") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/MicroSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/MicroSpecies">http://taxref.mnhn.fr/lod/taxrank/MicroSpecies</seealso>
    let ``taxrank/MicroSpecies`` =
        Prefixed_Name(taxref_ld, "taxrank/MicroSpecies") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Morpha</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Morpha">http://taxref.mnhn.fr/lod/taxrank/Morpha</seealso>
    let ``taxrank/Morpha`` = Prefixed_Name(taxref_ld, "taxrank/Morpha") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Natio</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Natio">http://taxref.mnhn.fr/lod/taxrank/Natio</seealso>
    let ``taxrank/Natio`` = Prefixed_Name(taxref_ld, "taxrank/Natio") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Order">http://taxref.mnhn.fr/lod/taxrank/Order</seealso>
    let ``taxrank/Order`` = Prefixed_Name(taxref_ld, "taxrank/Order") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Phylum">http://taxref.mnhn.fr/lod/taxrank/Phylum</seealso>
    let ``taxrank/Phylum`` = Prefixed_Name(taxref_ld, "taxrank/Phylum") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrank/Race</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Race">http://taxref.mnhn.fr/lod/taxrank/Race</seealso>
    let ``taxrank/Race`` = Prefixed_Name(taxref_ld, "taxrank/Race") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Section">http://taxref.mnhn.fr/lod/taxrank/Section</seealso>
    let ``taxrank/Section`` =
        Prefixed_Name(taxref_ld, "taxrank/Section") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SemiSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SemiSpecies">http://taxref.mnhn.fr/lod/taxrank/SemiSpecies</seealso>
    let ``taxrank/SemiSpecies`` =
        Prefixed_Name(taxref_ld, "taxrank/SemiSpecies") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Series">http://taxref.mnhn.fr/lod/taxrank/Series</seealso>
    let ``taxrank/Series`` = Prefixed_Name(taxref_ld, "taxrank/Series") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Species">http://taxref.mnhn.fr/lod/taxrank/Species</seealso>
    let ``taxrank/Species`` =
        Prefixed_Name(taxref_ld, "taxrank/Species") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubClass">http://taxref.mnhn.fr/lod/taxrank/SubClass</seealso>
    let ``taxrank/SubClass`` =
        Prefixed_Name(taxref_ld, "taxrank/SubClass") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubDivision">http://taxref.mnhn.fr/lod/taxrank/SubDivision</seealso>
    let ``taxrank/SubDivision`` =
        Prefixed_Name(taxref_ld, "taxrank/SubDivision") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubFamily">http://taxref.mnhn.fr/lod/taxrank/SubFamily</seealso>
    let ``taxrank/SubFamily`` =
        Prefixed_Name(taxref_ld, "taxrank/SubFamily") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubForma</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubForma">http://taxref.mnhn.fr/lod/taxrank/SubForma</seealso>
    let ``taxrank/SubForma`` =
        Prefixed_Name(taxref_ld, "taxrank/SubForma") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubGenus">http://taxref.mnhn.fr/lod/taxrank/SubGenus</seealso>
    let ``taxrank/SubGenus`` =
        Prefixed_Name(taxref_ld, "taxrank/SubGenus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubKingdom">http://taxref.mnhn.fr/lod/taxrank/SubKingdom</seealso>
    let ``taxrank/SubKingdom`` =
        Prefixed_Name(taxref_ld, "taxrank/SubKingdom") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubOrder">http://taxref.mnhn.fr/lod/taxrank/SubOrder</seealso>
    let ``taxrank/SubOrder`` =
        Prefixed_Name(taxref_ld, "taxrank/SubOrder") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubPhylum">http://taxref.mnhn.fr/lod/taxrank/SubPhylum</seealso>
    let ``taxrank/SubPhylum`` =
        Prefixed_Name(taxref_ld, "taxrank/SubPhylum") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubSection">http://taxref.mnhn.fr/lod/taxrank/SubSection</seealso>
    let ``taxrank/SubSection`` =
        Prefixed_Name(taxref_ld, "taxrank/SubSection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubSeries">http://taxref.mnhn.fr/lod/taxrank/SubSeries</seealso>
    let ``taxrank/SubSeries`` =
        Prefixed_Name(taxref_ld, "taxrank/SubSeries") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubSpecies">http://taxref.mnhn.fr/lod/taxrank/SubSpecies</seealso>
    let ``taxrank/SubSpecies`` =
        Prefixed_Name(taxref_ld, "taxrank/SubSpecies") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubTribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubTribe">http://taxref.mnhn.fr/lod/taxrank/SubTribe</seealso>
    let ``taxrank/SubTribe`` =
        Prefixed_Name(taxref_ld, "taxrank/SubTribe") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SubVarietas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SubVarietas">http://taxref.mnhn.fr/lod/taxrank/SubVarietas</seealso>
    let ``taxrank/SubVarietas`` =
        Prefixed_Name(taxref_ld, "taxrank/SubVarietas") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SuperClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SuperClass">http://taxref.mnhn.fr/lod/taxrank/SuperClass</seealso>
    let ``taxrank/SuperClass`` =
        Prefixed_Name(taxref_ld, "taxrank/SuperClass") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SuperFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SuperFamily">http://taxref.mnhn.fr/lod/taxrank/SuperFamily</seealso>
    let ``taxrank/SuperFamily`` =
        Prefixed_Name(taxref_ld, "taxrank/SuperFamily") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/SuperOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/SuperOrder">http://taxref.mnhn.fr/lod/taxrank/SuperOrder</seealso>
    let ``taxrank/SuperOrder`` =
        Prefixed_Name(taxref_ld, "taxrank/SuperOrder") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Superkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Superkingdom">http://taxref.mnhn.fr/lod/taxrank/Superkingdom</seealso>
    let ``taxrank/Superkingdom`` =
        Prefixed_Name(taxref_ld, "taxrank/Superkingdom") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/TaxonomicRank</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Class of taxonomical ranks"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRank">http://taxref.mnhn.fr/lod/taxrank/TaxonomicRank</seealso>
    let ``taxrank/TaxonomicRank`` =
        Prefixed_Name(taxref_ld, "taxrank/TaxonomicRank") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/TaxonomicRankCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of taxonomical ranks"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRankCollection">http://taxref.mnhn.fr/lod/taxrank/TaxonomicRankCollection</seealso>
    let ``taxrank/TaxonomicRankCollection`` =
        Prefixed_Name(taxref_ld, "taxrank/TaxonomicRankCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Tribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Tribe">http://taxref.mnhn.fr/lod/taxrank/Tribe</seealso>
    let ``taxrank/Tribe`` = Prefixed_Name(taxref_ld, "taxrank/Tribe") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxrank/Varietas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrank/Varietas">http://taxref.mnhn.fr/lod/taxrank/Varietas</seealso>
    let ``taxrank/Varietas`` =
        Prefixed_Name(taxref_ld, "taxrank/Varietas") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:taxref</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Dataset</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxref">http://taxref.mnhn.fr/lod/taxref</seealso>
    let taxref = Prefixed_Name(taxref_ld, "taxref") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxref-ld</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Dataset</para>
    ///   <para>dcat:Distribution</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>void:Dataset</para>
    ///   <para>owl:Ontology</para>
    ///   <para>nsprov:Entity</para>
    ///   <para>dcat:Dataset</para>
    ///
    /// labels<para>"TAXREF-LD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxref-ld">http://taxref.mnhn.fr/lod/taxref-ld</seealso>
    let taxref_ld_ = Prefixed_Name(taxref_ld, "taxref-ld") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxref-ld/15.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxref-ld/15.2">http://taxref.mnhn.fr/lod/taxref-ld/15.2</seealso>
    let ``taxref_ld/15.2`` = Prefixed_Name(taxref_ld, "taxref-ld/15.2") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxrefmethodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;https://data.archives-ouvertes.fr/doctype/Report&gt;</para>
    ///   <para>schemas:Article</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxrefmethodo">http://taxref.mnhn.fr/lod/taxrefmethodo</seealso>
    let taxrefmethodo = Prefixed_Name(taxref_ld, "taxrefmethodo") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Algivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Algivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Algivore">http://taxref.mnhn.fr/lod/trophicLevel/Algivore</seealso>
    let ``trophicLevel/Algivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Algivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Autotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Autotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Autotroph">http://taxref.mnhn.fr/lod/trophicLevel/Autotroph</seealso>
    let ``trophicLevel/Autotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Autotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Carnivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Carnivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Carnivore">http://taxref.mnhn.fr/lod/trophicLevel/Carnivore</seealso>
    let ``trophicLevel/Carnivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Carnivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Chemoautotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Chemoautotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Chemoautotroph">http://taxref.mnhn.fr/lod/trophicLevel/Chemoautotroph</seealso>
    let ``trophicLevel/Chemoautotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Chemoautotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Coprophage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Coprophage"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Coprophage">http://taxref.mnhn.fr/lod/trophicLevel/Coprophage</seealso>
    let ``trophicLevel/Coprophage`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Coprophage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Decomposer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Decomposer"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Decomposer">http://taxref.mnhn.fr/lod/trophicLevel/Decomposer</seealso>
    let ``trophicLevel/Decomposer`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Decomposer") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Detritivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Detritivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Detritivore">http://taxref.mnhn.fr/lod/trophicLevel/Detritivore</seealso>
    let ``trophicLevel/Detritivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Detritivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Florivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Florivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Florivore">http://taxref.mnhn.fr/lod/trophicLevel/Florivore</seealso>
    let ``trophicLevel/Florivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Florivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Folivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Folivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Folivore">http://taxref.mnhn.fr/lod/trophicLevel/Folivore</seealso>
    let ``trophicLevel/Folivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Folivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Frugivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Frugivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Frugivore">http://taxref.mnhn.fr/lod/trophicLevel/Frugivore</seealso>
    let ``trophicLevel/Frugivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Frugivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Fungivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Fungivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Fungivore">http://taxref.mnhn.fr/lod/trophicLevel/Fungivore</seealso>
    let ``trophicLevel/Fungivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Fungivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Graminivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Graminivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Graminivore">http://taxref.mnhn.fr/lod/trophicLevel/Graminivore</seealso>
    let ``trophicLevel/Graminivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Graminivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Granivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Granivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Granivore">http://taxref.mnhn.fr/lod/trophicLevel/Granivore</seealso>
    let ``trophicLevel/Granivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Granivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Herbivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Herbivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Herbivore">http://taxref.mnhn.fr/lod/trophicLevel/Herbivore</seealso>
    let ``trophicLevel/Herbivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Herbivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Heterotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Heterotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Heterotroph">http://taxref.mnhn.fr/lod/trophicLevel/Heterotroph</seealso>
    let ``trophicLevel/Heterotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Heterotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Nectarivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Nectarivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Nectarivore">http://taxref.mnhn.fr/lod/trophicLevel/Nectarivore</seealso>
    let ``trophicLevel/Nectarivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Nectarivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Palynivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Palynivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Palynivore">http://taxref.mnhn.fr/lod/trophicLevel/Palynivore</seealso>
    let ``trophicLevel/Palynivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Palynivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Photoautotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Photoautotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Photoautotroph">http://taxref.mnhn.fr/lod/trophicLevel/Photoautotroph</seealso>
    let ``trophicLevel/Photoautotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Photoautotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Predator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Predator"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Predator">http://taxref.mnhn.fr/lod/trophicLevel/Predator</seealso>
    let ``trophicLevel/Predator`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Predator") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Rhizovore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Rhizovore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Rhizovore">http://taxref.mnhn.fr/lod/trophicLevel/Rhizovore</seealso>
    let ``trophicLevel/Rhizovore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Rhizovore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Saprotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Saprotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Saprotroph">http://taxref.mnhn.fr/lod/trophicLevel/Saprotroph</seealso>
    let ``trophicLevel/Saprotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Saprotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Saproxylotroph</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Saproxylotroph"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Saproxylotroph">http://taxref.mnhn.fr/lod/trophicLevel/Saproxylotroph</seealso>
    let ``trophicLevel/Saproxylotroph`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Saproxylotroph") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Scavenger</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Scavenger"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Scavenger">http://taxref.mnhn.fr/lod/trophicLevel/Scavenger</seealso>
    let ``trophicLevel/Scavenger`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Scavenger") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/TrophicLevelCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of trophic levels"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/TrophicLevelCollection">http://taxref.mnhn.fr/lod/trophicLevel/TrophicLevelCollection</seealso>
    let ``trophicLevel/TrophicLevelCollection`` =
        Prefixed_Name(taxref_ld, "trophicLevel/TrophicLevelCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Unknown"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Unknown">http://taxref.mnhn.fr/lod/trophicLevel/Unknown</seealso>
    let ``trophicLevel/Unknown`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Unknown") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Xylofungivore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Xylofungivore"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Xylofungivore">http://taxref.mnhn.fr/lod/trophicLevel/Xylofungivore</seealso>
    let ``trophicLevel/Xylofungivore`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Xylofungivore") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:trophicLevel/Xylophage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Xylophage"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/trophicLevel/Xylophage">http://taxref.mnhn.fr/lod/trophicLevel/Xylophage</seealso>
    let ``trophicLevel/Xylophage`` =
        Prefixed_Name(taxref_ld, "trophicLevel/Xylophage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:xR2RML</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:SoftwareAgent</para>
    ///
    /// labels<para>"Morph-xR2RML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/xR2RML">http://taxref.mnhn.fr/lod/xR2RML</seealso>
    let xR2RML = Prefixed_Name(taxref_ld, "xR2RML") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Agrovoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///
    /// labels<para>"AGROVOC Multilingual agricultural thesaurus"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Agrovoc">http://taxref.mnhn.fr/lod/Agrovoc</seealso>
    let Agrovoc = Prefixed_Name(taxref_ld, "Agrovoc") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcat:Catalog</para>
    ///
    /// labels<para>"Catalogue des jeux de données TAXREF-LD"</para><para>"Catalog of TAXREF-LD datasets"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Catalog">http://taxref.mnhn.fr/lod/Catalog</seealso>
    let Catalog = Prefixed_Name(taxref_ld, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:INPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"French National Inventory of Natural Heritage"</para><para>"Inventaire National du Patrimoine Naturel"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/INPN">http://taxref.mnhn.fr/lod/INPN</seealso>
    let INPN = Prefixed_Name(taxref_ld, "INPN") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:NcbiTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///
    /// labels<para>"NCBI Organismal Classification"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/NcbiTaxon">http://taxref.mnhn.fr/lod/NcbiTaxon</seealso>
    let NcbiTaxon = Prefixed_Name(taxref_ld, "NcbiTaxon") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_%C5%92uf_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_%C5%92uf_stage">http://taxref.mnhn.fr/lod/Organisms_in_%C5%92uf_stage</seealso>
    let ``Organisms_in_%C5%92uf_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_%C5%92uf_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_adulte_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_adulte_stage">http://taxref.mnhn.fr/lod/Organisms_in_adulte_stage</seealso>
    let Organisms_in_adulte_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_adulte_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_au%20nid_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_au%20nid_stage">http://taxref.mnhn.fr/lod/Organisms_in_au%20nid_stage</seealso>
    let ``Organisms_in_au%20nid_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_au%20nid_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20III_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20III_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20III_stage</seealso>
    let ``Organisms_in_copepodite%20III_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20III_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20II_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20II_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20II_stage</seealso>
    let ``Organisms_in_copepodite%20II_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20II_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20IV_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20IV_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20IV_stage</seealso>
    let ``Organisms_in_copepodite%20IV_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20IV_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20I_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20I_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20I_stage</seealso>
    let ``Organisms_in_copepodite%20I_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20I_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20VI_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20VI_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20VI_stage</seealso>
    let ``Organisms_in_copepodite%20VI_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20VI_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_copepodite%20V_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20V_stage">http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20V_stage</seealso>
    let ``Organisms_in_copepodite%20V_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_copepodite%20V_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_cypris_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_cypris_stage">http://taxref.mnhn.fr/lod/Organisms_in_cypris_stage</seealso>
    let Organisms_in_cypris_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_cypris_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_de%20l%27ann%C3%A9e_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_de%20l%27ann%C3%A9e_stage">http://taxref.mnhn.fr/lod/Organisms_in_de%20l%27ann%C3%A9e_stage</seealso>
    let ``Organisms_in_de%20l%27ann%C3%A9e_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_de%20l%27ann%C3%A9e_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_ephyra_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_ephyra_stage">http://taxref.mnhn.fr/lod/Organisms_in_ephyra_stage</seealso>
    let Organisms_in_ephyra_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_ephyra_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_foetus_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_foetus_stage">http://taxref.mnhn.fr/lod/Organisms_in_foetus_stage</seealso>
    let Organisms_in_foetus_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_foetus_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_gametophyte_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_gametophyte_stage">http://taxref.mnhn.fr/lod/Organisms_in_gametophyte_stage</seealso>
    let Organisms_in_gametophyte_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_gametophyte_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_hydro%C3%AFde_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_hydro%C3%AFde_stage">http://taxref.mnhn.fr/lod/Organisms_in_hydro%C3%AFde_stage</seealso>
    let ``Organisms_in_hydro%C3%AFde_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_hydro%C3%AFde_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_juv%C3%A9nile_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_juv%C3%A9nile_stage">http://taxref.mnhn.fr/lod/Organisms_in_juv%C3%A9nile_stage</seealso>
    let ``Organisms_in_juv%C3%A9nile_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_juv%C3%A9nile_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_larve_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_larve_stage">http://taxref.mnhn.fr/lod/Organisms_in_larve_stage</seealso>
    let Organisms_in_larve_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_larve_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_m%C3%A9duse_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_m%C3%A9duse_stage">http://taxref.mnhn.fr/lod/Organisms_in_m%C3%A9duse_stage</seealso>
    let ``Organisms_in_m%C3%A9duse_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_m%C3%A9duse_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_macrothallus_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_macrothallus_stage">http://taxref.mnhn.fr/lod/Organisms_in_macrothallus_stage</seealso>
    let Organisms_in_macrothallus_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_macrothallus_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_manca_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_manca_stage">http://taxref.mnhn.fr/lod/Organisms_in_manca_stage</seealso>
    let Organisms_in_manca_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_manca_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_megalopa_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_megalopa_stage">http://taxref.mnhn.fr/lod/Organisms_in_megalopa_stage</seealso>
    let Organisms_in_megalopa_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_megalopa_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_microthallus_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_microthallus_stage">http://taxref.mnhn.fr/lod/Organisms_in_microthallus_stage</seealso>
    let Organisms_in_microthallus_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_microthallus_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_nauplius_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_nauplius_stage">http://taxref.mnhn.fr/lod/Organisms_in_nauplius_stage</seealso>
    let Organisms_in_nauplius_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_nauplius_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_nouveau-n%C3%A9_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_nouveau-n%C3%A9_stage">http://taxref.mnhn.fr/lod/Organisms_in_nouveau-n%C3%A9_stage</seealso>
    let ``Organisms_in_nouveau_n%C3%A9_stage`` =
        Prefixed_Name(taxref_ld, "Organisms_in_nouveau-n%C3%A9_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_planula_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_planula_stage">http://taxref.mnhn.fr/lod/Organisms_in_planula_stage</seealso>
    let Organisms_in_planula_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_planula_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_polype_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_polype_stage">http://taxref.mnhn.fr/lod/Organisms_in_polype_stage</seealso>
    let Organisms_in_polype_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_polype_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_post-larve_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_post-larve_stage">http://taxref.mnhn.fr/lod/Organisms_in_post-larve_stage</seealso>
    let Organisms_in_post_larve_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_post-larve_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_sporophyte_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_sporophyte_stage">http://taxref.mnhn.fr/lod/Organisms_in_sporophyte_stage</seealso>
    let Organisms_in_sporophyte_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_sporophyte_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_subadulte_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_subadulte_stage">http://taxref.mnhn.fr/lod/Organisms_in_subadulte_stage</seealso>
    let Organisms_in_subadulte_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_subadulte_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:Organisms_in_zoea_stage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Organisms_in_zoea_stage">http://taxref.mnhn.fr/lod/Organisms_in_zoea_stage</seealso>
    let Organisms_in_zoea_stage =
        Prefixed_Name(taxref_ld, "Organisms_in_zoea_stage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:RdfGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Activity</para>
    ///
    /// labels<para>"RDF generation process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/RdfGeneration">http://taxref.mnhn.fr/lod/RdfGeneration</seealso>
    let RdfGeneration = Prefixed_Name(taxref_ld, "RdfGeneration") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Taxref2Agrovoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Linkset</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Taxref2Agrovoc">http://taxref.mnhn.fr/lod/Taxref2Agrovoc</seealso>
    let Taxref2Agrovoc = Prefixed_Name(taxref_ld, "Taxref2Agrovoc") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Taxref2NcbiTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Linkset</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Taxref2NcbiTaxon">http://taxref.mnhn.fr/lod/Taxref2NcbiTaxon</seealso>
    let Taxref2NcbiTaxon = Prefixed_Name(taxref_ld, "Taxref2NcbiTaxon") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Taxref2Worms</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Linkset</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Taxref2Worms">http://taxref.mnhn.fr/lod/Taxref2Worms</seealso>
    let Taxref2Worms = Prefixed_Name(taxref_ld, "Taxref2Worms") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:WebService</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Entity</para>
    ///
    /// labels<para>"TAXREF web service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/WebService">http://taxref.mnhn.fr/lod/WebService</seealso>
    let WebService = Prefixed_Name(taxref_ld, "WebService") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:Worms</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///
    /// labels<para>"World Register of Marine Species"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/Worms">http://taxref.mnhn.fr/lod/Worms</seealso>
    let Worms = Prefixed_Name(taxref_ld, "Worms") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/A</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"absent"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/A">http://taxref.mnhn.fr/lod/bioGeoStatus/A</seealso>
    let ``bioGeoStatus/A`` = Prefixed_Name(taxref_ld, "bioGeoStatus/A") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/B</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"occasional"</para><para>"occasionnel"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/B">http://taxref.mnhn.fr/lod/bioGeoStatus/B</seealso>
    let ``bioGeoStatus/B`` = Prefixed_Name(taxref_ld, "bioGeoStatus/B") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/BioGeographicalStatus</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Class of biogeographical status values"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatus">http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatus</seealso>
    let ``bioGeoStatus/BioGeographicalStatus`` =
        Prefixed_Name(taxref_ld, "bioGeoStatus/BioGeographicalStatus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/BioGeographicalStatusCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of biogeographical status values"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatusCollection">http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatusCollection</seealso>
    let ``bioGeoStatus/BioGeographicalStatusCollection`` =
        Prefixed_Name(taxref_ld, "bioGeoStatus/BioGeographicalStatusCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/C</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"cryptogenic"</para><para>"cryptogène"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/C">http://taxref.mnhn.fr/lod/bioGeoStatus/C</seealso>
    let ``bioGeoStatus/C`` = Prefixed_Name(taxref_ld, "bioGeoStatus/C") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/D</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"doubtful"</para><para>"douteux"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/D">http://taxref.mnhn.fr/lod/bioGeoStatus/D</seealso>
    let ``bioGeoStatus/D`` = Prefixed_Name(taxref_ld, "bioGeoStatus/D") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/E</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"endémique"</para><para>"endemic"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/E">http://taxref.mnhn.fr/lod/bioGeoStatus/E</seealso>
    let ``bioGeoStatus/E`` = Prefixed_Name(taxref_ld, "bioGeoStatus/E") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/I</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Introduit"</para><para>"Introduced"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/I">http://taxref.mnhn.fr/lod/bioGeoStatus/I</seealso>
    let ``bioGeoStatus/I`` = Prefixed_Name(taxref_ld, "bioGeoStatus/I") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/J</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"introduit envahissant"</para><para>"introduced invasive"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/J">http://taxref.mnhn.fr/lod/bioGeoStatus/J</seealso>
    let ``bioGeoStatus/J`` = Prefixed_Name(taxref_ld, "bioGeoStatus/J") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/M</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"introduced casual"</para><para>"introduit non établi (dont domestique)"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/M">http://taxref.mnhn.fr/lod/bioGeoStatus/M</seealso>
    let ``bioGeoStatus/M`` = Prefixed_Name(taxref_ld, "bioGeoStatus/M") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/P</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"présent (indigène ou indéterminé)"</para><para>"present"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/P">http://taxref.mnhn.fr/lod/bioGeoStatus/P</seealso>
    let ``bioGeoStatus/P`` = Prefixed_Name(taxref_ld, "bioGeoStatus/P") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/Q</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"reported in error"</para><para>"mentionné par erreur "</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/Q">http://taxref.mnhn.fr/lod/bioGeoStatus/Q</seealso>
    let ``bioGeoStatus/Q`` = Prefixed_Name(taxref_ld, "bioGeoStatus/Q") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/S</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"subendemic"</para><para>"subendémique"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/S">http://taxref.mnhn.fr/lod/bioGeoStatus/S</seealso>
    let ``bioGeoStatus/S`` = Prefixed_Name(taxref_ld, "bioGeoStatus/S") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/W</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"disappeared"</para><para>"disparu"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/W">http://taxref.mnhn.fr/lod/bioGeoStatus/W</seealso>
    let ``bioGeoStatus/W`` = Prefixed_Name(taxref_ld, "bioGeoStatus/W") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/X</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"extinct"</para><para>"éteint"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/X">http://taxref.mnhn.fr/lod/bioGeoStatus/X</seealso>
    let ``bioGeoStatus/X`` = Prefixed_Name(taxref_ld, "bioGeoStatus/X") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"introduced extinct/disappeared"</para><para>"introduit éteint/disparu"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/Y">http://taxref.mnhn.fr/lod/bioGeoStatus/Y</seealso>
    let ``bioGeoStatus/Y`` = Prefixed_Name(taxref_ld, "bioGeoStatus/Y") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:bioGeoStatus/Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"endémique éteint"</para><para>"endemic extinct"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/bioGeoStatus/Z">http://taxref.mnhn.fr/lod/bioGeoStatus/Z</seealso>
    let ``bioGeoStatus/Z`` = Prefixed_Name(taxref_ld, "bioGeoStatus/Z") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/1YearOld</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/1YearOld">http://taxref.mnhn.fr/lod/biologicalStage/1YearOld</seealso>
    let ``biologicalStage/1YearOld`` =
        Prefixed_Name(taxref_ld, "biologicalStage/1YearOld") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Adult">http://taxref.mnhn.fr/lod/biologicalStage/Adult</seealso>
    let ``biologicalStage/Adult`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Adult") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/BiologicalStageCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of biological stages"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/BiologicalStageCollection">http://taxref.mnhn.fr/lod/biologicalStage/BiologicalStageCollection</seealso>
    let ``biologicalStage/BiologicalStageCollection`` =
        Prefixed_Name(taxref_ld, "biologicalStage/BiologicalStageCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeI</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeI">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeI</seealso>
    let ``biologicalStage/CopepoditeI`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeI") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeII</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeII">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeII</seealso>
    let ``biologicalStage/CopepoditeII`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeII") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeIII</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIII">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIII</seealso>
    let ``biologicalStage/CopepoditeIII`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeIII") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeIV</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIV">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIV</seealso>
    let ``biologicalStage/CopepoditeIV`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeIV") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeV</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeV">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeV</seealso>
    let ``biologicalStage/CopepoditeV`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeV") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/CopepoditeVI</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeVI">http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeVI</seealso>
    let ``biologicalStage/CopepoditeVI`` =
        Prefixed_Name(taxref_ld, "biologicalStage/CopepoditeVI") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Cypris</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Cypris">http://taxref.mnhn.fr/lod/biologicalStage/Cypris</seealso>
    let ``biologicalStage/Cypris`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Cypris") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Egg</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Egg">http://taxref.mnhn.fr/lod/biologicalStage/Egg</seealso>
    let ``biologicalStage/Egg`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Egg") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Ephyra</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Ephyra">http://taxref.mnhn.fr/lod/biologicalStage/Ephyra</seealso>
    let ``biologicalStage/Ephyra`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Ephyra") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Fetus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Fetus">http://taxref.mnhn.fr/lod/biologicalStage/Fetus</seealso>
    let ``biologicalStage/Fetus`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Fetus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Gametophyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Gametophyte">http://taxref.mnhn.fr/lod/biologicalStage/Gametophyte</seealso>
    let ``biologicalStage/Gametophyte`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Gametophyte") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Hatchling</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Hatchling">http://taxref.mnhn.fr/lod/biologicalStage/Hatchling</seealso>
    let ``biologicalStage/Hatchling`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Hatchling") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Hydroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Hydroid">http://taxref.mnhn.fr/lod/biologicalStage/Hydroid</seealso>
    let ``biologicalStage/Hydroid`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Hydroid") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Juvenile</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Juvenile">http://taxref.mnhn.fr/lod/biologicalStage/Juvenile</seealso>
    let ``biologicalStage/Juvenile`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Juvenile") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Larva</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Larva">http://taxref.mnhn.fr/lod/biologicalStage/Larva</seealso>
    let ``biologicalStage/Larva`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Larva") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Macrothallus</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Macrothallus">http://taxref.mnhn.fr/lod/biologicalStage/Macrothallus</seealso>
    let ``biologicalStage/Macrothallus`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Macrothallus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Manca</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Manca">http://taxref.mnhn.fr/lod/biologicalStage/Manca</seealso>
    let ``biologicalStage/Manca`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Manca") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Medusa</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Medusa">http://taxref.mnhn.fr/lod/biologicalStage/Medusa</seealso>
    let ``biologicalStage/Medusa`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Medusa") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Megalopa</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Megalopa">http://taxref.mnhn.fr/lod/biologicalStage/Megalopa</seealso>
    let ``biologicalStage/Megalopa`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Megalopa") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Microthallus</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Microthallus">http://taxref.mnhn.fr/lod/biologicalStage/Microthallus</seealso>
    let ``biologicalStage/Microthallus`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Microthallus") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Nauplius</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Nauplius">http://taxref.mnhn.fr/lod/biologicalStage/Nauplius</seealso>
    let ``biologicalStage/Nauplius`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Nauplius") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Planula</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Planula">http://taxref.mnhn.fr/lod/biologicalStage/Planula</seealso>
    let ``biologicalStage/Planula`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Planula") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Polyp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Polyp">http://taxref.mnhn.fr/lod/biologicalStage/Polyp</seealso>
    let ``biologicalStage/Polyp`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Polyp") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Postlarva</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Postlarva">http://taxref.mnhn.fr/lod/biologicalStage/Postlarva</seealso>
    let ``biologicalStage/Postlarva`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Postlarva") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Spat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Spat">http://taxref.mnhn.fr/lod/biologicalStage/Spat</seealso>
    let ``biologicalStage/Spat`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Spat") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Sporophyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Sporophyte">http://taxref.mnhn.fr/lod/biologicalStage/Sporophyte</seealso>
    let ``biologicalStage/Sporophyte`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Sporophyte") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Subadult</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>wikidata:Q1811014</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Subadult">http://taxref.mnhn.fr/lod/biologicalStage/Subadult</seealso>
    let ``biologicalStage/Subadult`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Subadult") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:biologicalStage/Zoea</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikidata:Q1811014</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/biologicalStage/Zoea">http://taxref.mnhn.fr/lod/biologicalStage/Zoea</seealso>
    let ``biologicalStage/Zoea`` =
        Prefixed_Name(taxref_ld, "biologicalStage/Zoea") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:femelle_Organisms</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"oganismes femelles"</para><para>"female oganisms"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/femelle_Organisms">http://taxref.mnhn.fr/lod/femelle_Organisms</seealso>
    let femelle_Organisms =
        Prefixed_Name(taxref_ld, "femelle_Organisms") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/biblio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/biblio">http://taxref.mnhn.fr/lod/graph/biblio</seealso>
    let ``graph/biblio`` = Prefixed_Name(taxref_ld, "graph/biblio") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/classes/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/classes/15.0">http://taxref.mnhn.fr/lod/graph/classes/15.0</seealso>
    let ``graph/classes/15.0`` =
        Prefixed_Name(taxref_ld, "graph/classes/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/concepts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/concepts">http://taxref.mnhn.fr/lod/graph/concepts</seealso>
    let ``graph/concepts`` = Prefixed_Name(taxref_ld, "graph/concepts") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/dbxref/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/dbxref/15.0">http://taxref.mnhn.fr/lod/graph/dbxref/15.0</seealso>
    let ``graph/dbxref/15.0`` =
        Prefixed_Name(taxref_ld, "graph/dbxref/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/habitats/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/habitats/15.0">http://taxref.mnhn.fr/lod/graph/habitats/15.0</seealso>
    let ``graph/habitats/15.0`` =
        Prefixed_Name(taxref_ld, "graph/habitats/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/interactions/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/interactions/15.0">http://taxref.mnhn.fr/lod/graph/interactions/15.0</seealso>
    let ``graph/interactions/15.0`` =
        Prefixed_Name(taxref_ld, "graph/interactions/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/links-agrovoc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/links-agrovoc">http://taxref.mnhn.fr/lod/graph/links-agrovoc</seealso>
    let ``graph/links_agrovoc`` =
        Prefixed_Name(taxref_ld, "graph/links-agrovoc") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/links-ncbi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/links-ncbi">http://taxref.mnhn.fr/lod/graph/links-ncbi</seealso>
    let ``graph/links_ncbi`` =
        Prefixed_Name(taxref_ld, "graph/links-ncbi") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/links-worms</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/links-worms">http://taxref.mnhn.fr/lod/graph/links-worms</seealso>
    let ``graph/links_worms`` =
        Prefixed_Name(taxref_ld, "graph/links-worms") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/locations</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/locations">http://taxref.mnhn.fr/lod/graph/locations</seealso>
    let ``graph/locations`` =
        Prefixed_Name(taxref_ld, "graph/locations") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/media</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/media">http://taxref.mnhn.fr/lod/graph/media</seealso>
    let ``graph/media`` = Prefixed_Name(taxref_ld, "graph/media") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:graph/metadata</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/metadata">http://taxref.mnhn.fr/lod/graph/metadata</seealso>
    let ``graph/metadata`` = Prefixed_Name(taxref_ld, "graph/metadata") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/statusCodes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/statusCodes">http://taxref.mnhn.fr/lod/graph/statusCodes</seealso>
    let ``graph/statusCodes`` =
        Prefixed_Name(taxref_ld, "graph/statusCodes") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/statuses/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/statuses/15.0">http://taxref.mnhn.fr/lod/graph/statuses/15.0</seealso>
    let ``graph/statuses/15.0`` =
        Prefixed_Name(taxref_ld, "graph/statuses/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:graph/vernacular/15.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/graph/vernacular/15.0">http://taxref.mnhn.fr/lod/graph/vernacular/15.0</seealso>
    let ``graph/vernacular/15.0`` =
        Prefixed_Name(taxref_ld, "graph/vernacular/15.0") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/BrackishWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Brackish water"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/BrackishWater">http://taxref.mnhn.fr/lod/habitat/BrackishWater</seealso>
    let ``habitat/BrackishWater`` =
        Prefixed_Name(taxref_ld, "habitat/BrackishWater") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/FreshWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Freshwater"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/FreshWater">http://taxref.mnhn.fr/lod/habitat/FreshWater</seealso>
    let ``habitat/FreshWater`` =
        Prefixed_Name(taxref_ld, "habitat/FreshWater") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/Habitat</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Class of habitats"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/Habitat">http://taxref.mnhn.fr/lod/habitat/Habitat</seealso>
    let ``habitat/Habitat`` =
        Prefixed_Name(taxref_ld, "habitat/Habitat") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/HabitatCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    ///
    /// labels<para>"Collection of habitat concepts"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/HabitatCollection">http://taxref.mnhn.fr/lod/habitat/HabitatCollection</seealso>
    let ``habitat/HabitatCollection`` =
        Prefixed_Name(taxref_ld, "habitat/HabitatCollection") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/Marine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Marine habitat"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/Marine">http://taxref.mnhn.fr/lod/habitat/Marine</seealso>
    let ``habitat/Marine`` = Prefixed_Name(taxref_ld, "habitat/Marine") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:habitat/Terrestrial</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Terrestrial"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/habitat/Terrestrial">http://taxref.mnhn.fr/lod/habitat/Terrestrial</seealso>
    let ``habitat/Terrestrial`` =
        Prefixed_Name(taxref_ld, "habitat/Terrestrial") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:hal01207828</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;https://data.archives-ouvertes.fr/doctype/Article&gt;</para>
    ///   <para>bibo:AcademicArticle</para>
    ///   <para>schemas:ScholarlyArticle</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/hal01207828">http://taxref.mnhn.fr/lod/hal01207828</seealso>
    let hal01207828 = Prefixed_Name(taxref_ld, "hal01207828") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:hal01617708</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;https://data.archives-ouvertes.fr/doctype/Article&gt;</para>
    ///   <para>bibo:AcademicArticle</para>
    ///   <para>schemas:ScholarlyArticle</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/hal01617708">http://taxref.mnhn.fr/lod/hal01617708</seealso>
    let hal01617708 = Prefixed_Name(taxref_ld, "hal01617708") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:johanmontagnat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/johanmontagnat">http://taxref.mnhn.fr/lod/johanmontagnat</seealso>
    let johanmontagnat = Prefixed_Name(taxref_ld, "johanmontagnat") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:loc/MaritimeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A maritime area, generally surrounding a landmass, that does not correspond to any specific sea or ocean, nor to any internationally recognized administrative subdivision (i.e. territorial waters or EEZ)"</para>
    /// labels<para>"Maritime area"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/loc/MaritimeArea">http://taxref.mnhn.fr/lod/loc/MaritimeArea</seealso>
    let ``loc/MaritimeArea`` =
        Prefixed_Name(taxref_ld, "loc/MaritimeArea") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:loicdjimenou</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/loicdjimenou">http://taxref.mnhn.fr/lod/loicdjimenou</seealso>
    let loicdjimenou = Prefixed_Name(taxref_ld, "loicdjimenou") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:m%C3%A2le_Organisms</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"oganismes mâles"</para><para>"male oganisms"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/m%C3%A2le_Organisms">http://taxref.mnhn.fr/lod/m%C3%A2le_Organisms</seealso>
    let ``m%C3%A2le_Organisms`` =
        Prefixed_Name(taxref_ld, "m%C3%A2le_Organisms") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:name/349525</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Biota"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/name/349525">http://taxref.mnhn.fr/lod/name/349525</seealso>
    let ``name/349525`` = Prefixed_Name(taxref_ld, "name/349525") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:oliviergargominy</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    /// </remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/oliviergargominy">http://taxref.mnhn.fr/lod/oliviergargominy</seealso>
    let oliviergargominy = Prefixed_Name(taxref_ld, "oliviergargominy") |> PrefixedName

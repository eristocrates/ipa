namespace http.purl.org.NET.biol.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module biol =
    let _namespace_iri = Namespace_Iri biol |> NamespaceIRI
    /// <summary>
    ///   <para>biol:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#">http://purl.org/NET/biol/ns#</seealso>
    let _prefix_iri = Prefixed_Name(biol, "") |> PrefixedName
    /// <summary>
    ///   <para>biol:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#name">http://purl.org/NET/biol/ns#name</seealso>
    let name = Prefixed_Name(biol, "name") |> PrefixedName
    /// <summary>
    ///   <para>biol:species</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>species</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#species">http://purl.org/NET/biol/ns#species</seealso>
    let species = Prefixed_Name(biol, "species") |> PrefixedName
    /// <summary>
    ///   <para>biol:kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>kingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#kingdom">http://purl.org/NET/biol/ns#kingdom</seealso>
    let kingdom = Prefixed_Name(biol, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>biol:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>see also</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#seeAlso">http://purl.org/NET/biol/ns#seeAlso</seealso>
    let seeAlso = Prefixed_Name(biol, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>biol:hasTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>taxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#hasTaxonomy">http://purl.org/NET/biol/ns#hasTaxonomy</seealso>
    let hasTaxonomy = Prefixed_Name(biol, "hasTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>biol:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#authority">http://purl.org/NET/biol/ns#authority</seealso>
    let authority = Prefixed_Name(biol, "authority") |> PrefixedName
    /// <summary>
    ///   <para>biol:phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>phylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#phylum">http://purl.org/NET/biol/ns#phylum</seealso>
    let phylum = Prefixed_Name(biol, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>biol:family</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>family</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#family">http://purl.org/NET/biol/ns#family</seealso>
    let family = Prefixed_Name(biol, "family") |> PrefixedName
    /// <summary>
    ///   <para>biol:BotTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Botanical Taxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#BotTaxonomy">http://purl.org/NET/biol/ns#BotTaxonomy</seealso>
    let BotTaxonomy = Prefixed_Name(biol, "BotTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>biol:ZooTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Zoological Taxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#ZooTaxonomy">http://purl.org/NET/biol/ns#ZooTaxonomy</seealso>
    let ZooTaxonomy = Prefixed_Name(biol, "ZooTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>biol:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Taxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#Taxonomy">http://purl.org/NET/biol/ns#Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(biol, "Taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>biol:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>rank</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#rank">http://purl.org/NET/biol/ns#rank</seealso>
    let rank = Prefixed_Name(biol, "rank") |> PrefixedName

    /// <summary>
    ///   <para>biol:secondLevelClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>second level classification</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#secondLevelClassification">http://purl.org/NET/biol/ns#secondLevelClassification</seealso>
    let secondLevelClassification =
        Prefixed_Name(biol, "secondLevelClassification") |> PrefixedName

    /// <summary>
    ///   <para>biol:morePrecise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>more precise</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#morePrecise">http://purl.org/NET/biol/ns#morePrecise</seealso>
    let morePrecise = Prefixed_Name(biol, "morePrecise") |> PrefixedName
    /// <summary>
    ///   <para>biol:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>common name</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#commonName">http://purl.org/NET/biol/ns#commonName</seealso>
    let commonName = Prefixed_Name(biol, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>biol:division</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>division</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#division">http://purl.org/NET/biol/ns#division</seealso>
    let division = Prefixed_Name(biol, "division") |> PrefixedName
    /// <summary>
    ///   <para>biol:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>order</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#order">http://purl.org/NET/biol/ns#order</seealso>
    let order = Prefixed_Name(biol, "order") |> PrefixedName
    /// <summary>
    ///   <para>biol:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>class</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#class">http://purl.org/NET/biol/ns#class</seealso>
    let class_ = Prefixed_Name(biol, "class") |> PrefixedName
    /// <summary>
    ///   <para>biol:genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>genus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/ns#genus">http://purl.org/NET/biol/ns#genus</seealso>
    let genus = Prefixed_Name(biol, "genus") |> PrefixedName

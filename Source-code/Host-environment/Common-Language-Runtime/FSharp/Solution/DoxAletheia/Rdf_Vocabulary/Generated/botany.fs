namespace http.purl.org.NET.biol.botany.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module botany =
    let _namespace_iri = Namespace_Iri botany |> NamespaceIRI
    /// <summary>
    ///   <para>botany:aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>aggregate</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#aggregate">http://purl.org/NET/biol/botany#aggregate</seealso>
    let aggregate = Prefixed_Name(botany, "aggregate") |> PrefixedName
    /// <summary>
    ///   <para>botany:nation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>nation</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#nation">http://purl.org/NET/biol/botany#nation</seealso>
    let nation = Prefixed_Name(botany, "nation") |> PrefixedName
    /// <summary>
    ///   <para>botany:parvorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>parvorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#parvorder">http://purl.org/NET/biol/botany#parvorder</seealso>
    let parvorder = Prefixed_Name(botany, "parvorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:pathovar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>pathovar</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#pathovar">http://purl.org/NET/biol/botany#pathovar</seealso>
    let pathovar = Prefixed_Name(botany, "pathovar") |> PrefixedName
    /// <summary>
    ///   <para>botany:phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>phylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#phylum">http://purl.org/NET/biol/botany#phylum</seealso>
    let phylum = Prefixed_Name(botany, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>section</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#section">http://purl.org/NET/biol/botany#section</seealso>
    let section = Prefixed_Name(botany, "section") |> PrefixedName
    /// <summary>
    ///   <para>botany:sectionOfBreeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>sectionOfBreeds</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#sectionOfBreeds">http://purl.org/NET/biol/botany#sectionOfBreeds</seealso>
    let sectionOfBreeds = Prefixed_Name(botany, "sectionOfBreeds") |> PrefixedName
    /// <summary>
    ///   <para>botany:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>series</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#series">http://purl.org/NET/biol/botany#series</seealso>
    let series = Prefixed_Name(botany, "series") |> PrefixedName
    /// <summary>
    ///   <para>botany:serogroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>serogroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#serogroup">http://purl.org/NET/biol/botany#serogroup</seealso>
    let serogroup = Prefixed_Name(botany, "serogroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:serovar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>serovar</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#serovar">http://purl.org/NET/biol/botany#serovar</seealso>
    let serovar = Prefixed_Name(botany, "serovar") |> PrefixedName
    /// <summary>
    ///   <para>botany:speciesGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>speciesGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#speciesGroup">http://purl.org/NET/biol/botany#speciesGroup</seealso>
    let speciesGroup = Prefixed_Name(botany, "speciesGroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:strain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>strain</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#strain">http://purl.org/NET/biol/botany#strain</seealso>
    let strain = Prefixed_Name(botany, "strain") |> PrefixedName
    /// <summary>
    ///   <para>botany:subclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subclass</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subclass">http://purl.org/NET/biol/botany#subclass</seealso>
    let subclass = Prefixed_Name(botany, "subclass") |> PrefixedName
    /// <summary>
    ///   <para>botany:subdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subdivision</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subdivision">http://purl.org/NET/biol/botany#subdivision</seealso>
    let subdivision = Prefixed_Name(botany, "subdivision") |> PrefixedName
    /// <summary>
    ///   <para>botany:subdomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subdomain</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subdomain">http://purl.org/NET/biol/botany#subdomain</seealso>
    let subdomain = Prefixed_Name(botany, "subdomain") |> PrefixedName
    /// <summary>
    ///   <para>botany:subfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subfamily</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subfamily">http://purl.org/NET/biol/botany#subfamily</seealso>
    let subfamily = Prefixed_Name(botany, "subfamily") |> PrefixedName
    /// <summary>
    ///   <para>botany:subfamilyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subfamilyGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subfamilyGroup">http://purl.org/NET/biol/botany#subfamilyGroup</seealso>
    let subfamilyGroup = Prefixed_Name(botany, "subfamilyGroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:subform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subform</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subform">http://purl.org/NET/biol/botany#subform</seealso>
    let subform = Prefixed_Name(botany, "subform") |> PrefixedName
    /// <summary>
    ///   <para>botany:subgenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subgenus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subgenus">http://purl.org/NET/biol/botany#subgenus</seealso>
    let subgenus = Prefixed_Name(botany, "subgenus") |> PrefixedName
    /// <summary>
    ///   <para>botany:subkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subkingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subkingdom">http://purl.org/NET/biol/botany#subkingdom</seealso>
    let subkingdom = Prefixed_Name(botany, "subkingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:sublegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>sublegion</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#sublegion">http://purl.org/NET/biol/botany#sublegion</seealso>
    let sublegion = Prefixed_Name(botany, "sublegion") |> PrefixedName
    /// <summary>
    ///   <para>botany:suborder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>suborder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#suborder">http://purl.org/NET/biol/botany#suborder</seealso>
    let suborder = Prefixed_Name(botany, "suborder") |> PrefixedName
    /// <summary>
    ///   <para>botany:subphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subphylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subphylum">http://purl.org/NET/biol/botany#subphylum</seealso>
    let subphylum = Prefixed_Name(botany, "subphylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:subsection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subsection</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subsection">http://purl.org/NET/biol/botany#subsection</seealso>
    let subsection = Prefixed_Name(botany, "subsection") |> PrefixedName
    /// <summary>
    ///   <para>botany:subseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subseries</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subseries">http://purl.org/NET/biol/botany#subseries</seealso>
    let subseries = Prefixed_Name(botany, "subseries") |> PrefixedName
    /// <summary>
    ///   <para>botany:subspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subspecies</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subspecies">http://purl.org/NET/biol/botany#subspecies</seealso>
    let subspecies = Prefixed_Name(botany, "subspecies") |> PrefixedName
    /// <summary>
    ///   <para>botany:subtribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subtribe</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subtribe">http://purl.org/NET/biol/botany#subtribe</seealso>
    let subtribe = Prefixed_Name(botany, "subtribe") |> PrefixedName
    /// <summary>
    ///   <para>botany:superclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superclass</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superclass">http://purl.org/NET/biol/botany#superclass</seealso>
    let superclass = Prefixed_Name(botany, "superclass") |> PrefixedName
    /// <summary>
    ///   <para>botany:supercohort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supercohort</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supercohort">http://purl.org/NET/biol/botany#supercohort</seealso>
    let supercohort = Prefixed_Name(botany, "supercohort") |> PrefixedName
    /// <summary>
    ///   <para>botany:superdomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superdomain</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superdomain">http://purl.org/NET/biol/botany#superdomain</seealso>
    let superdomain = Prefixed_Name(botany, "superdomain") |> PrefixedName
    /// <summary>
    ///   <para>botany:superfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superfamily</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superfamily">http://purl.org/NET/biol/botany#superfamily</seealso>
    let superfamily = Prefixed_Name(botany, "superfamily") |> PrefixedName
    /// <summary>
    ///   <para>botany:superform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superform</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superform">http://purl.org/NET/biol/botany#superform</seealso>
    let superform = Prefixed_Name(botany, "superform") |> PrefixedName
    /// <summary>
    ///   <para>botany:supergenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supergenus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supergenus">http://purl.org/NET/biol/botany#supergenus</seealso>
    let supergenus = Prefixed_Name(botany, "supergenus") |> PrefixedName
    /// <summary>
    ///   <para>botany:superkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superkingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superkingdom">http://purl.org/NET/biol/botany#superkingdom</seealso>
    let superkingdom = Prefixed_Name(botany, "superkingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:superlegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superlegion</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superlegion">http://purl.org/NET/biol/botany#superlegion</seealso>
    let superlegion = Prefixed_Name(botany, "superlegion") |> PrefixedName
    /// <summary>
    ///   <para>botany:superphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superphylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superphylum">http://purl.org/NET/biol/botany#superphylum</seealso>
    let superphylum = Prefixed_Name(botany, "superphylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:supersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supersection</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supersection">http://purl.org/NET/biol/botany#supersection</seealso>
    let supersection = Prefixed_Name(botany, "supersection") |> PrefixedName
    /// <summary>
    ///   <para>botany:superseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superseries</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superseries">http://purl.org/NET/biol/botany#superseries</seealso>
    let superseries = Prefixed_Name(botany, "superseries") |> PrefixedName
    /// <summary>
    ///   <para>botany:superspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superspecies</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superspecies">http://purl.org/NET/biol/botany#superspecies</seealso>
    let superspecies = Prefixed_Name(botany, "superspecies") |> PrefixedName
    /// <summary>
    ///   <para>botany:supervariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supervariety</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supervariety">http://purl.org/NET/biol/botany#supervariety</seealso>
    let supervariety = Prefixed_Name(botany, "supervariety") |> PrefixedName
    /// <summary>
    ///   <para>botany:suprakingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>suprakingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#suprakingdom">http://purl.org/NET/biol/botany#suprakingdom</seealso>
    let suprakingdom = Prefixed_Name(botany, "suprakingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:supraphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supraphylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supraphylum">http://purl.org/NET/biol/botany#supraphylum</seealso>
    let supraphylum = Prefixed_Name(botany, "supraphylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:synklepton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>synklepton</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#synklepton">http://purl.org/NET/biol/botany#synklepton</seealso>
    let synklepton = Prefixed_Name(botany, "synklepton") |> PrefixedName
    /// <summary>
    ///   <para>botany:variety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>variety</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#variety">http://purl.org/NET/biol/botany#variety</seealso>
    let variety = Prefixed_Name(botany, "variety") |> PrefixedName
    /// <summary>
    ///   <para>botany:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#">http://purl.org/NET/biol/botany#</seealso>
    let _prefix_iri = Prefixed_Name(botany, "") |> PrefixedName
    /// <summary>
    ///   <para>botany:subvariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subvariety</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subvariety">http://purl.org/NET/biol/botany#subvariety</seealso>
    let subvariety = Prefixed_Name(botany, "subvariety") |> PrefixedName
    /// <summary>
    ///   <para>botany:breed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>breed</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#breed">http://purl.org/NET/biol/botany#breed</seealso>
    let breed = Prefixed_Name(botany, "breed") |> PrefixedName
    /// <summary>
    ///   <para>botany:speciesSubgroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>speciesSubgroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#speciesSubgroup">http://purl.org/NET/biol/botany#speciesSubgroup</seealso>
    let speciesSubgroup = Prefixed_Name(botany, "speciesSubgroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:subcohort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subcohort</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subcohort">http://purl.org/NET/biol/botany#subcohort</seealso>
    let subcohort = Prefixed_Name(botany, "subcohort") |> PrefixedName
    /// <summary>
    ///   <para>botany:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#authority">http://purl.org/NET/biol/botany#authority</seealso>
    let authority = Prefixed_Name(botany, "authority") |> PrefixedName
    /// <summary>
    ///   <para>botany:biovar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>biovar</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#biovar">http://purl.org/NET/biol/botany#biovar</seealso>
    let biovar = Prefixed_Name(botany, "biovar") |> PrefixedName
    /// <summary>
    ///   <para>botany:species</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>species</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#species">http://purl.org/NET/biol/botany#species</seealso>
    let species = Prefixed_Name(botany, "species") |> PrefixedName
    /// <summary>
    ///   <para>botany:population</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>population</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#population">http://purl.org/NET/biol/botany#population</seealso>
    let population = Prefixed_Name(botany, "population") |> PrefixedName
    /// <summary>
    ///   <para>botany:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>seeAlso</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#seeAlso">http://purl.org/NET/biol/botany#seeAlso</seealso>
    let seeAlso = Prefixed_Name(botany, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>botany:branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>branch</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#branch">http://purl.org/NET/biol/botany#branch</seealso>
    let branch = Prefixed_Name(botany, "branch") |> PrefixedName
    /// <summary>
    ///   <para>botany:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#class">http://purl.org/NET/biol/botany#class</seealso>
    let class_ = Prefixed_Name(botany, "class") |> PrefixedName
    /// <summary>
    ///   <para>botany:claudius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>claudius</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#claudius">http://purl.org/NET/biol/botany#claudius</seealso>
    let claudius = Prefixed_Name(botany, "claudius") |> PrefixedName
    /// <summary>
    ///   <para>botany:cohort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>cohort</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#cohort">http://purl.org/NET/biol/botany#cohort</seealso>
    let cohort = Prefixed_Name(botany, "cohort") |> PrefixedName
    /// <summary>
    ///   <para>botany:complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>complex</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#complex">http://purl.org/NET/biol/botany#complex</seealso>
    let complex = Prefixed_Name(botany, "complex") |> PrefixedName
    /// <summary>
    ///   <para>botany:convariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>convariety</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#convariety">http://purl.org/NET/biol/botany#convariety</seealso>
    let convariety = Prefixed_Name(botany, "convariety") |> PrefixedName
    /// <summary>
    ///   <para>botany:cultivar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>cultivar</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#cultivar">http://purl.org/NET/biol/botany#cultivar</seealso>
    let cultivar = Prefixed_Name(botany, "cultivar") |> PrefixedName
    /// <summary>
    ///   <para>botany:empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>empire</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#empire">http://purl.org/NET/biol/botany#empire</seealso>
    let empire = Prefixed_Name(botany, "empire") |> PrefixedName
    /// <summary>
    ///   <para>botany:subgroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>subgroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#subgroup">http://purl.org/NET/biol/botany#subgroup</seealso>
    let subgroup = Prefixed_Name(botany, "subgroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:division</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>division</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#division">http://purl.org/NET/biol/botany#division</seealso>
    let division = Prefixed_Name(botany, "division") |> PrefixedName
    /// <summary>
    ///   <para>botany:familyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>familyGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#familyGroup">http://purl.org/NET/biol/botany#familyGroup</seealso>
    let familyGroup = Prefixed_Name(botany, "familyGroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:cultivarGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>cultivarGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#cultivarGroup">http://purl.org/NET/biol/botany#cultivarGroup</seealso>
    let cultivarGroup = Prefixed_Name(botany, "cultivarGroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#domain">http://purl.org/NET/biol/botany#domain</seealso>
    let domain = Prefixed_Name(botany, "domain") |> PrefixedName
    /// <summary>
    ///   <para>botany:falanx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>falanx</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#falanx">http://purl.org/NET/biol/botany#falanx</seealso>
    let falanx = Prefixed_Name(botany, "falanx") |> PrefixedName
    /// <summary>
    ///   <para>botany:form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>form</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#form">http://purl.org/NET/biol/botany#form</seealso>
    let form = Prefixed_Name(botany, "form") |> PrefixedName
    /// <summary>
    ///   <para>botany:supertribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>supertribe</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#supertribe">http://purl.org/NET/biol/botany#supertribe</seealso>
    let supertribe = Prefixed_Name(botany, "supertribe") |> PrefixedName
    /// <summary>
    ///   <para>botany:family</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>family</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#family">http://purl.org/NET/biol/botany#family</seealso>
    let family = Prefixed_Name(botany, "family") |> PrefixedName
    /// <summary>
    ///   <para>botany:superorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>superorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#superorder">http://purl.org/NET/biol/botany#superorder</seealso>
    let superorder = Prefixed_Name(botany, "superorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>genus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#genus">http://purl.org/NET/biol/botany#genus</seealso>
    let genus = Prefixed_Name(botany, "genus") |> PrefixedName
    /// <summary>
    ///   <para>botany:genusGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>genusGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#genusGroup">http://purl.org/NET/biol/botany#genusGroup</seealso>
    let genusGroup = Prefixed_Name(botany, "genusGroup") |> PrefixedName
    /// <summary>
    ///   <para>botany:tribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>tribe</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#tribe">http://purl.org/NET/biol/botany#tribe</seealso>
    let tribe = Prefixed_Name(botany, "tribe") |> PrefixedName
    /// <summary>
    ///   <para>botany:gigaorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>gigaorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#gigaorder">http://purl.org/NET/biol/botany#gigaorder</seealso>
    let gigaorder = Prefixed_Name(botany, "gigaorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:grandorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>grandorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#grandorder">http://purl.org/NET/biol/botany#grandorder</seealso>
    let grandorder = Prefixed_Name(botany, "grandorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:grade</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>grade</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#grade">http://purl.org/NET/biol/botany#grade</seealso>
    let grade = Prefixed_Name(botany, "grade") |> PrefixedName
    /// <summary>
    ///   <para>botany:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>group</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#group">http://purl.org/NET/biol/botany#group</seealso>
    let group = Prefixed_Name(botany, "group") |> PrefixedName
    /// <summary>
    ///   <para>botany:hasTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>hasTaxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#hasTaxonomy">http://purl.org/NET/biol/botany#hasTaxonomy</seealso>
    let hasTaxonomy = Prefixed_Name(botany, "hasTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>botany:groupOfBreeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>groupOfBreeds</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#groupOfBreeds">http://purl.org/NET/biol/botany#groupOfBreeds</seealso>
    let groupOfBreeds = Prefixed_Name(botany, "groupOfBreeds") |> PrefixedName
    /// <summary>
    ///   <para>botany:hybrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>hybrid</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#hybrid">http://purl.org/NET/biol/botany#hybrid</seealso>
    let hybrid = Prefixed_Name(botany, "hybrid") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraclass</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraclass">http://purl.org/NET/biol/botany#infraclass</seealso>
    let infraclass = Prefixed_Name(botany, "infraclass") |> PrefixedName
    /// <summary>
    ///   <para>botany:hyperorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>hyperorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#hyperorder">http://purl.org/NET/biol/botany#hyperorder</seealso>
    let hyperorder = Prefixed_Name(botany, "hyperorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:infradomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infradomain</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infradomain">http://purl.org/NET/biol/botany#infradomain</seealso>
    let infradomain = Prefixed_Name(botany, "infradomain") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraform</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraform">http://purl.org/NET/biol/botany#infraform</seealso>
    let infraform = Prefixed_Name(botany, "infraform") |> PrefixedName
    /// <summary>
    ///   <para>botany:infragenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infragenus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infragenus">http://purl.org/NET/biol/botany#infragenus</seealso>
    let infragenus = Prefixed_Name(botany, "infragenus") |> PrefixedName
    /// <summary>
    ///   <para>botany:infralegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infralegion</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infralegion">http://purl.org/NET/biol/botany#infralegion</seealso>
    let infralegion = Prefixed_Name(botany, "infralegion") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraphylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraphylum">http://purl.org/NET/biol/botany#infraphylum</seealso>
    let infraphylum = Prefixed_Name(botany, "infraphylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraseries</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraseries">http://purl.org/NET/biol/botany#infraseries</seealso>
    let infraseries = Prefixed_Name(botany, "infraseries") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraspecies</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraspecies">http://purl.org/NET/biol/botany#infraspecies</seealso>
    let infraspecies = Prefixed_Name(botany, "infraspecies") |> PrefixedName
    /// <summary>
    ///   <para>botany:infravariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infravariety</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infravariety">http://purl.org/NET/biol/botany#infravariety</seealso>
    let infravariety = Prefixed_Name(botany, "infravariety") |> PrefixedName
    /// <summary>
    ///   <para>botany:kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>kingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#kingdom">http://purl.org/NET/biol/botany#kingdom</seealso>
    let kingdom = Prefixed_Name(botany, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:klepton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>klepton</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#klepton">http://purl.org/NET/biol/botany#klepton</seealso>
    let klepton = Prefixed_Name(botany, "klepton") |> PrefixedName
    /// <summary>
    ///   <para>botany:legion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>legion</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#legion">http://purl.org/NET/biol/botany#legion</seealso>
    let legion = Prefixed_Name(botany, "legion") |> PrefixedName
    /// <summary>
    ///   <para>botany:lusus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>lusus</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#lusus">http://purl.org/NET/biol/botany#lusus</seealso>
    let lusus = Prefixed_Name(botany, "lusus") |> PrefixedName
    /// <summary>
    ///   <para>botany:magnorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>magnorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#magnorder">http://purl.org/NET/biol/botany#magnorder</seealso>
    let magnorder = Prefixed_Name(botany, "magnorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:megaorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>megaorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#megaorder">http://purl.org/NET/biol/botany#megaorder</seealso>
    let megaorder = Prefixed_Name(botany, "megaorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:microspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>microspecies</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#microspecies">http://purl.org/NET/biol/botany#microspecies</seealso>
    let microspecies = Prefixed_Name(botany, "microspecies") |> PrefixedName
    /// <summary>
    ///   <para>botany:midkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>midkingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#midkingdom">http://purl.org/NET/biol/botany#midkingdom</seealso>
    let midkingdom = Prefixed_Name(botany, "midkingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:midphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>midphylum</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#midphylum">http://purl.org/NET/biol/botany#midphylum</seealso>
    let midphylum = Prefixed_Name(botany, "midphylum") |> PrefixedName
    /// <summary>
    ///   <para>botany:mirorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>mirorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#mirorder">http://purl.org/NET/biol/botany#mirorder</seealso>
    let mirorder = Prefixed_Name(botany, "mirorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#order">http://purl.org/NET/biol/botany#order</seealso>
    let order = Prefixed_Name(botany, "order") |> PrefixedName
    /// <summary>
    ///   <para>botany:parvclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>parvclass</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#parvclass">http://purl.org/NET/biol/botany#parvclass</seealso>
    let parvclass = Prefixed_Name(botany, "parvclass") |> PrefixedName
    /// <summary>
    ///   <para>botany:infrakingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infrakingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infrakingdom">http://purl.org/NET/biol/botany#infrakingdom</seealso>
    let infrakingdom = Prefixed_Name(botany, "infrakingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:infraorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infraorder</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infraorder">http://purl.org/NET/biol/botany#infraorder</seealso>
    let infraorder = Prefixed_Name(botany, "infraorder") |> PrefixedName
    /// <summary>
    ///   <para>botany:infrasection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infrasection</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infrasection">http://purl.org/NET/biol/botany#infrasection</seealso>
    let infrasection = Prefixed_Name(botany, "infrasection") |> PrefixedName
    /// <summary>
    ///   <para>botany:infrafamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infrafamily</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infrafamily">http://purl.org/NET/biol/botany#infrafamily</seealso>
    let infrafamily = Prefixed_Name(botany, "infrafamily") |> PrefixedName
    /// <summary>
    ///   <para>botany:infratribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>infratribe</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#infratribe">http://purl.org/NET/biol/botany#infratribe</seealso>
    let infratribe = Prefixed_Name(botany, "infratribe") |> PrefixedName
    /// <summary>
    ///   <para>botany:interkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>interkingdom</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#interkingdom">http://purl.org/NET/biol/botany#interkingdom</seealso>
    let interkingdom = Prefixed_Name(botany, "interkingdom") |> PrefixedName
    /// <summary>
    ///   <para>botany:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>...</para>
    /// labels<para>Taxonomy</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#Taxonomy">http://purl.org/NET/biol/botany#Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(botany, "Taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>botany:aberration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>...</para>
    /// labels<para>aberration</para></remarks>
    /// <seealso href="http://purl.org/NET/biol/botany#aberration">http://purl.org/NET/biol/botany#aberration</seealso>
    let aberration = Prefixed_Name(botany, "aberration") |> PrefixedName

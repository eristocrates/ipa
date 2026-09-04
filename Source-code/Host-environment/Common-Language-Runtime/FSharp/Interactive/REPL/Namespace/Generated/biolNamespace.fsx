#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module biol =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/NET/biol/ns#" "biol"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Botanical Taxonomy</para>
    ///   <para>dcterms:description : A BotTaxonomy is a subclass of Taxonomy. It is not necessarily used to
    /// describe a plant. Most of the time, it is more appropriate to use Taxonomy
    /// instead.</para>
    ///   <a href="http://purl.org/NET/biol/ns#BotTaxonomy">biol:BotTaxonomy</a>
    /// </summary>
    let BotTaxonomy = _prefixId.prefix "BotTaxonomy"
    /// <summary>
    ///   <para>rdfs:label : Taxonomy</para>
    ///   <para>dcterms:description : A taxonomy is a classification for something. An animal or plant &lt;em xmlns="http://www.w3.org/1999/xhtml"&gt;has&lt;/em&gt; a taxonomy; an animal or plant &lt;em xmlns="http://www.w3.org/1999/xhtml"&gt;is not&lt;/em&gt; a taxonomy. For those familiar with object-oriented programming, think of a taxonomy as being analogous to a class, not an object.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#Taxonomy">biol:Taxonomy</a>
    /// </summary>
    let Taxonomy = _prefixId.prefix "Taxonomy"
    /// <summary>
    ///   <para>rdfs:label : Zoological Taxonomy</para>
    ///   <para>dcterms:description : A ZooTaxonomy is a subclass of Taxonomy. It is not necessarily used to
    /// describe an animal, but it indicates that certain ambiguous terms, such as
    /// "division" should be interpreted the way zoologists use them. Most of the
    /// time, it is more appropriate to use Taxonomy instead.</para>
    ///   <a href="http://purl.org/NET/biol/ns#ZooTaxonomy">biol:ZooTaxonomy</a>
    /// </summary>
    let ZooTaxonomy = _prefixId.prefix "ZooTaxonomy"
    /// <summary>
    ///   <para>rdfs:label : authority</para>
    ///   <para>dcterms:description : The authority who classified this form of life. For example "Linnaeus, 1758".</para>
    ///   <a href="http://purl.org/NET/biol/ns#authority">biol:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:label : class</para>
    ///   <para>dcterms:description : The third highest level of classification. For example &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Mammalia&lt;/i&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#class">biol:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : common name</para>
    ///   <para>dcterms:description : A non-scientific name. For example, "Human".</para>
    ///   <a href="http://purl.org/NET/biol/ns#commonName">biol:commonName</a>
    /// </summary>
    let commonName = _prefixId.prefix "commonName"
    /// <summary>
    ///   <para>rdfs:label : division</para>
    ///   <para>dcterms:description : The second highest level of classification, as used by botanists. Note that
    /// division may be used to describe any form of life — the use of division is
    /// not meant to imply that the entity being described is a plant, merely that
    /// botanical names of ranks are being used. Zoologists use the term "division"
    /// to describe a rank between an "infraclass" and a "cohort". biol:division
    /// should not be used for this purpose — use biol:rank instead.</para>
    ///   <a href="http://purl.org/NET/biol/ns#division">biol:division</a>
    /// </summary>
    let division = _prefixId.prefix "division"
    /// <summary>
    ///   <para>rdfs:label : family</para>
    ///   <para>dcterms:description : The fifth highest level of classification. For example &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Hominidae&lt;/i&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#family">biol:family</a>
    /// </summary>
    let family = _prefixId.prefix "family"
    /// <summary>
    ///   <para>rdfs:label : genus</para>
    ///   <para>dcterms:description : The sixth highest level of classification. For example &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Homo&lt;/i&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#genus">biol:genus</a>
    /// </summary>
    let genus = _prefixId.prefix "genus"
    /// <summary>
    ///   <para>rdfs:label : taxonomy</para>
    ///   <para>dcterms:description : This property provides a relationship between an entity (such as a &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://xmlns.com/foaf/spec/#term_Person"&gt;foaf:Person&lt;/a&gt;) and a taxonomy. Because biologists don't always agree on how to classify life, a single entity may have multiple taxonomies, each of which may be differentiated between using &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#term_authority"&gt;biol:authority&lt;/a&gt; or dc:date.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#hasTaxonomy">biol:hasTaxonomy</a>
    /// </summary>
    let hasTaxonomy = _prefixId.prefix "hasTaxonomy"
    /// <summary>
    ///   <para>rdfs:label : kingdom</para>
    ///   <para>dcterms:description : The highest-level and least specific level of classification. Example kingdoms are &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Animalia&lt;/i&gt; and &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Plantae&lt;/i&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#kingdom">biol:kingdom</a>
    /// </summary>
    let kingdom = _prefixId.prefix "kingdom"
    /// <summary>
    ///   <para>rdfs:label : more precise</para>
    ///   <para>dcterms:description : Connects a taxonomy to a more precise taxonomy. For example, the taxonomy
    /// "Mammal" might have a "more precise" property linking to "Primate".</para>
    ///   <a href="http://purl.org/NET/biol/ns#morePrecise">biol:morePrecise</a>
    /// </summary>
    let morePrecise = _prefixId.prefix "morePrecise"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>dcterms:description : A scientific name; a binomial or trinomial. For example, &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Homo sapiens&lt;/i&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#name">biol:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : order</para>
    ///   <para>dcterms:description : The fourth highest level of classification. For example "Primates".</para>
    ///   <a href="http://purl.org/NET/biol/ns#order">biol:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:label : phylum</para>
    ///   <para>dcterms:description : The second highest level of classification, as used by zoologists. Note that
    /// phylum may be used to describe any form of life — the use of phylum is not
    /// meant to imply that the entity being described is an animal, merely that
    /// zoological names of ranks are being used.</para>
    ///   <a href="http://purl.org/NET/biol/ns#phylum">biol:phylum</a>
    /// </summary>
    let phylum = _prefixId.prefix "phylum"
    /// <summary>
    ///   <para>rdfs:label : rank</para>
    ///   <para>dcterms:description : An unspecified classification. This should not normally be used.</para>
    ///   <a href="http://purl.org/NET/biol/ns#rank">biol:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:label : second level classification</para>
    ///   <para>dcterms:description : The second highest level of classification. Zoologists call these &lt;i xmlns="http://www.w3.org/1999/xhtml"&gt;phyla&lt;/i&gt; and botanists call them "divisions". In general, you should pick one of those terms and use it instead.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#secondLevelClassification">biol:secondLevelClassification</a>
    /// </summary>
    let secondLevelClassification = _prefixId.prefix "secondLevelClassification"
    /// <summary>
    ///   <para>rdfs:label : see also</para>
    ///   <para>dcterms:description : A link to another resource further describing this form of life.</para>
    ///   <a href="http://purl.org/NET/biol/ns#seeAlso">biol:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:label : species</para>
    ///   <para>dcterms:description : The lowest level of classification supported by this vocabulary. For example &lt;i xmlns="http://www.w3.org/1999/xhtml" class="taxon"&gt;Sapiens&lt;/i&gt;. To include information more specific than species, use &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#term_rank"&gt;biol:rank&lt;/a&gt; or &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#section_Abstract"&gt;a more specialist vocabulary&lt;/a&gt;.^^rdf:XMLLiteral</para>
    ///   <a href="http://purl.org/NET/biol/ns#species">biol:species</a>
    /// </summary>
    let species = _prefixId.prefix "species"

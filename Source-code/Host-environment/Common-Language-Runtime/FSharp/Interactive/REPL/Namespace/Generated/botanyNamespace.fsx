#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module botany =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/NET/biol/botany#" "botany"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>dcterms:description : A hierarchical classification for a form of life.</para>
    ///   <para>rdfs:label : Taxonomy</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#Taxonomy">botany:Taxonomy</a>
    /// </summary>
    let Taxonomy = _prefixId.prefix "Taxonomy"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : aberration</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#aberration">botany:aberration</a>
    /// </summary>
    let aberration = _prefixId.prefix "aberration"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : aggregate</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#aggregate">botany:aggregate</a>
    /// </summary>
    let aggregate = _prefixId.prefix "aggregate"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : authority</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#authority">botany:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : biovar</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#biovar">botany:biovar</a>
    /// </summary>
    let biovar = _prefixId.prefix "biovar"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : branch</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#branch">botany:branch</a>
    /// </summary>
    let branch = _prefixId.prefix "branch"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : breed</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#breed">botany:breed</a>
    /// </summary>
    let breed = _prefixId.prefix "breed"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : class</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#class">botany:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : claudius</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#claudius">botany:claudius</a>
    /// </summary>
    let claudius = _prefixId.prefix "claudius"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : cohort</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#cohort">botany:cohort</a>
    /// </summary>
    let cohort = _prefixId.prefix "cohort"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : complex</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#complex">botany:complex</a>
    /// </summary>
    let complex = _prefixId.prefix "complex"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : convariety</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#convariety">botany:convariety</a>
    /// </summary>
    let convariety = _prefixId.prefix "convariety"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : cultivar</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#cultivar">botany:cultivar</a>
    /// </summary>
    let cultivar = _prefixId.prefix "cultivar"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : cultivarGroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#cultivarGroup">botany:cultivarGroup</a>
    /// </summary>
    let cultivarGroup = _prefixId.prefix "cultivarGroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : division</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#division">botany:division</a>
    /// </summary>
    let division = _prefixId.prefix "division"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : domain</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#domain">botany:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : empire</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#empire">botany:empire</a>
    /// </summary>
    let empire = _prefixId.prefix "empire"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : falanx</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#falanx">botany:falanx</a>
    /// </summary>
    let falanx = _prefixId.prefix "falanx"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : family</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#family">botany:family</a>
    /// </summary>
    let family = _prefixId.prefix "family"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : familyGroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#familyGroup">botany:familyGroup</a>
    /// </summary>
    let familyGroup = _prefixId.prefix "familyGroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : form</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#form">botany:form</a>
    /// </summary>
    let form = _prefixId.prefix "form"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : genus</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#genus">botany:genus</a>
    /// </summary>
    let genus = _prefixId.prefix "genus"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : genusGroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#genusGroup">botany:genusGroup</a>
    /// </summary>
    let genusGroup = _prefixId.prefix "genusGroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : gigaorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#gigaorder">botany:gigaorder</a>
    /// </summary>
    let gigaorder = _prefixId.prefix "gigaorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : grade</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#grade">botany:grade</a>
    /// </summary>
    let grade = _prefixId.prefix "grade"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : grandorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#grandorder">botany:grandorder</a>
    /// </summary>
    let grandorder = _prefixId.prefix "grandorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : group</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#group">botany:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : groupOfBreeds</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#groupOfBreeds">botany:groupOfBreeds</a>
    /// </summary>
    let groupOfBreeds = _prefixId.prefix "groupOfBreeds"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : hasTaxonomy</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#hasTaxonomy">botany:hasTaxonomy</a>
    /// </summary>
    let hasTaxonomy = _prefixId.prefix "hasTaxonomy"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : hybrid</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#hybrid">botany:hybrid</a>
    /// </summary>
    let hybrid = _prefixId.prefix "hybrid"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : hyperorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#hyperorder">botany:hyperorder</a>
    /// </summary>
    let hyperorder = _prefixId.prefix "hyperorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraclass</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraclass">botany:infraclass</a>
    /// </summary>
    let infraclass = _prefixId.prefix "infraclass"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infradomain</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infradomain">botany:infradomain</a>
    /// </summary>
    let infradomain = _prefixId.prefix "infradomain"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infrafamily</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infrafamily">botany:infrafamily</a>
    /// </summary>
    let infrafamily = _prefixId.prefix "infrafamily"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraform</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraform">botany:infraform</a>
    /// </summary>
    let infraform = _prefixId.prefix "infraform"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infragenus</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infragenus">botany:infragenus</a>
    /// </summary>
    let infragenus = _prefixId.prefix "infragenus"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infrakingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infrakingdom">botany:infrakingdom</a>
    /// </summary>
    let infrakingdom = _prefixId.prefix "infrakingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infralegion</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infralegion">botany:infralegion</a>
    /// </summary>
    let infralegion = _prefixId.prefix "infralegion"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraorder">botany:infraorder</a>
    /// </summary>
    let infraorder = _prefixId.prefix "infraorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraphylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraphylum">botany:infraphylum</a>
    /// </summary>
    let infraphylum = _prefixId.prefix "infraphylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infrasection</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infrasection">botany:infrasection</a>
    /// </summary>
    let infrasection = _prefixId.prefix "infrasection"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraseries</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraseries">botany:infraseries</a>
    /// </summary>
    let infraseries = _prefixId.prefix "infraseries"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infraspecies</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infraspecies">botany:infraspecies</a>
    /// </summary>
    let infraspecies = _prefixId.prefix "infraspecies"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infratribe</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infratribe">botany:infratribe</a>
    /// </summary>
    let infratribe = _prefixId.prefix "infratribe"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : infravariety</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#infravariety">botany:infravariety</a>
    /// </summary>
    let infravariety = _prefixId.prefix "infravariety"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : interkingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#interkingdom">botany:interkingdom</a>
    /// </summary>
    let interkingdom = _prefixId.prefix "interkingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : kingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#kingdom">botany:kingdom</a>
    /// </summary>
    let kingdom = _prefixId.prefix "kingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : klepton</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#klepton">botany:klepton</a>
    /// </summary>
    let klepton = _prefixId.prefix "klepton"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : legion</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#legion">botany:legion</a>
    /// </summary>
    let legion = _prefixId.prefix "legion"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : lusus</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#lusus">botany:lusus</a>
    /// </summary>
    let lusus = _prefixId.prefix "lusus"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : magnorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#magnorder">botany:magnorder</a>
    /// </summary>
    let magnorder = _prefixId.prefix "magnorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : megaorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#megaorder">botany:megaorder</a>
    /// </summary>
    let megaorder = _prefixId.prefix "megaorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : microspecies</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#microspecies">botany:microspecies</a>
    /// </summary>
    let microspecies = _prefixId.prefix "microspecies"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : midkingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#midkingdom">botany:midkingdom</a>
    /// </summary>
    let midkingdom = _prefixId.prefix "midkingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : midphylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#midphylum">botany:midphylum</a>
    /// </summary>
    let midphylum = _prefixId.prefix "midphylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : mirorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#mirorder">botany:mirorder</a>
    /// </summary>
    let mirorder = _prefixId.prefix "mirorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : nation</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#nation">botany:nation</a>
    /// </summary>
    let nation = _prefixId.prefix "nation"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : order</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#order">botany:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : parvclass</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#parvclass">botany:parvclass</a>
    /// </summary>
    let parvclass = _prefixId.prefix "parvclass"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : parvorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#parvorder">botany:parvorder</a>
    /// </summary>
    let parvorder = _prefixId.prefix "parvorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : pathovar</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#pathovar">botany:pathovar</a>
    /// </summary>
    let pathovar = _prefixId.prefix "pathovar"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : phylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#phylum">botany:phylum</a>
    /// </summary>
    let phylum = _prefixId.prefix "phylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : population</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#population">botany:population</a>
    /// </summary>
    let population = _prefixId.prefix "population"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : section</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#section">botany:section</a>
    /// </summary>
    let section = _prefixId.prefix "section"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : sectionOfBreeds</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#sectionOfBreeds">botany:sectionOfBreeds</a>
    /// </summary>
    let sectionOfBreeds = _prefixId.prefix "sectionOfBreeds"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : seeAlso</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#seeAlso">botany:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : series</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#series">botany:series</a>
    /// </summary>
    let series = _prefixId.prefix "series"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : serogroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#serogroup">botany:serogroup</a>
    /// </summary>
    let serogroup = _prefixId.prefix "serogroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : serovar</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#serovar">botany:serovar</a>
    /// </summary>
    let serovar = _prefixId.prefix "serovar"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : species</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#species">botany:species</a>
    /// </summary>
    let species = _prefixId.prefix "species"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : speciesGroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#speciesGroup">botany:speciesGroup</a>
    /// </summary>
    let speciesGroup = _prefixId.prefix "speciesGroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : speciesSubgroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#speciesSubgroup">botany:speciesSubgroup</a>
    /// </summary>
    let speciesSubgroup = _prefixId.prefix "speciesSubgroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : strain</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#strain">botany:strain</a>
    /// </summary>
    let strain = _prefixId.prefix "strain"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subclass</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subclass">botany:subclass</a>
    /// </summary>
    let subclass = _prefixId.prefix "subclass"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subcohort</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subcohort">botany:subcohort</a>
    /// </summary>
    let subcohort = _prefixId.prefix "subcohort"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subdivision</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subdivision">botany:subdivision</a>
    /// </summary>
    let subdivision = _prefixId.prefix "subdivision"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subdomain</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subdomain">botany:subdomain</a>
    /// </summary>
    let subdomain = _prefixId.prefix "subdomain"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subfamily</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subfamily">botany:subfamily</a>
    /// </summary>
    let subfamily = _prefixId.prefix "subfamily"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subfamilyGroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subfamilyGroup">botany:subfamilyGroup</a>
    /// </summary>
    let subfamilyGroup = _prefixId.prefix "subfamilyGroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subform</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subform">botany:subform</a>
    /// </summary>
    let subform = _prefixId.prefix "subform"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subgenus</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subgenus">botany:subgenus</a>
    /// </summary>
    let subgenus = _prefixId.prefix "subgenus"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subgroup</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subgroup">botany:subgroup</a>
    /// </summary>
    let subgroup = _prefixId.prefix "subgroup"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subkingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subkingdom">botany:subkingdom</a>
    /// </summary>
    let subkingdom = _prefixId.prefix "subkingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : sublegion</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#sublegion">botany:sublegion</a>
    /// </summary>
    let sublegion = _prefixId.prefix "sublegion"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : suborder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#suborder">botany:suborder</a>
    /// </summary>
    let suborder = _prefixId.prefix "suborder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subphylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subphylum">botany:subphylum</a>
    /// </summary>
    let subphylum = _prefixId.prefix "subphylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subsection</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subsection">botany:subsection</a>
    /// </summary>
    let subsection = _prefixId.prefix "subsection"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subseries</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subseries">botany:subseries</a>
    /// </summary>
    let subseries = _prefixId.prefix "subseries"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subspecies</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subspecies">botany:subspecies</a>
    /// </summary>
    let subspecies = _prefixId.prefix "subspecies"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subtribe</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subtribe">botany:subtribe</a>
    /// </summary>
    let subtribe = _prefixId.prefix "subtribe"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : subvariety</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#subvariety">botany:subvariety</a>
    /// </summary>
    let subvariety = _prefixId.prefix "subvariety"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superclass</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superclass">botany:superclass</a>
    /// </summary>
    let superclass = _prefixId.prefix "superclass"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supercohort</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supercohort">botany:supercohort</a>
    /// </summary>
    let supercohort = _prefixId.prefix "supercohort"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superdomain</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superdomain">botany:superdomain</a>
    /// </summary>
    let superdomain = _prefixId.prefix "superdomain"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superfamily</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superfamily">botany:superfamily</a>
    /// </summary>
    let superfamily = _prefixId.prefix "superfamily"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superform</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superform">botany:superform</a>
    /// </summary>
    let superform = _prefixId.prefix "superform"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supergenus</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supergenus">botany:supergenus</a>
    /// </summary>
    let supergenus = _prefixId.prefix "supergenus"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superkingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superkingdom">botany:superkingdom</a>
    /// </summary>
    let superkingdom = _prefixId.prefix "superkingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superlegion</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superlegion">botany:superlegion</a>
    /// </summary>
    let superlegion = _prefixId.prefix "superlegion"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superorder</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superorder">botany:superorder</a>
    /// </summary>
    let superorder = _prefixId.prefix "superorder"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superphylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superphylum">botany:superphylum</a>
    /// </summary>
    let superphylum = _prefixId.prefix "superphylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supersection</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supersection">botany:supersection</a>
    /// </summary>
    let supersection = _prefixId.prefix "supersection"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superseries</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superseries">botany:superseries</a>
    /// </summary>
    let superseries = _prefixId.prefix "superseries"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : superspecies</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#superspecies">botany:superspecies</a>
    /// </summary>
    let superspecies = _prefixId.prefix "superspecies"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supertribe</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supertribe">botany:supertribe</a>
    /// </summary>
    let supertribe = _prefixId.prefix "supertribe"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supervariety</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supervariety">botany:supervariety</a>
    /// </summary>
    let supervariety = _prefixId.prefix "supervariety"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : suprakingdom</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#suprakingdom">botany:suprakingdom</a>
    /// </summary>
    let suprakingdom = _prefixId.prefix "suprakingdom"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : supraphylum</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#supraphylum">botany:supraphylum</a>
    /// </summary>
    let supraphylum = _prefixId.prefix "supraphylum"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : synklepton</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#synklepton">botany:synklepton</a>
    /// </summary>
    let synklepton = _prefixId.prefix "synklepton"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : tribe</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#tribe">botany:tribe</a>
    /// </summary>
    let tribe = _prefixId.prefix "tribe"
    /// <summary>
    ///   <para>rdfs:comment : ...</para>
    ///   <para>rdfs:label : variety</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/NET/biol/botany#variety">botany:variety</a>
    /// </summary>
    let variety = _prefixId.prefix "variety"

namespace http.purl.org.NET.biol.botany.hash

open DoxAletheia

module botany =
    let _namespace_name = "http://purl.org/NET/biol/botany#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#Taxonomy"></see></summary>
    let Taxonomy = _prefix "Taxonomy"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#aberration"></see></summary>
    let aberration = _prefix "aberration"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#aggregate"></see></summary>
    let aggregate = _prefix "aggregate"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#biovar"></see></summary>
    let biovar = _prefix "biovar"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#branch"></see></summary>
    let branch = _prefix "branch"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#breed"></see></summary>
    let breed = _prefix "breed"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#claudius"></see></summary>
    let claudius = _prefix "claudius"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cohort"></see></summary>
    let cohort = _prefix "cohort"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#complex"></see></summary>
    let complex = _prefix "complex"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#convariety"></see></summary>
    let convariety = _prefix "convariety"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cultivar"></see></summary>
    let cultivar = _prefix "cultivar"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cultivarGroup"></see></summary>
    let cultivarGroup = _prefix "cultivarGroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#division"></see></summary>
    let division = _prefix "division"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#empire"></see></summary>
    let empire = _prefix "empire"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#falanx"></see></summary>
    let falanx = _prefix "falanx"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#family"></see></summary>
    let family = _prefix "family"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#familyGroup"></see></summary>
    let familyGroup = _prefix "familyGroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#form"></see></summary>
    let form = _prefix "form"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#genus"></see></summary>
    let genus = _prefix "genus"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#genusGroup"></see></summary>
    let genusGroup = _prefix "genusGroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#gigaorder"></see></summary>
    let gigaorder = _prefix "gigaorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#grade"></see></summary>
    let grade = _prefix "grade"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#grandorder"></see></summary>
    let grandorder = _prefix "grandorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#groupOfBreeds"></see></summary>
    let groupOfBreeds = _prefix "groupOfBreeds"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hasTaxonomy"></see></summary>
    let hasTaxonomy = _prefix "hasTaxonomy"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hybrid"></see></summary>
    let hybrid = _prefix "hybrid"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hyperorder"></see></summary>
    let hyperorder = _prefix "hyperorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraclass"></see></summary>
    let infraclass = _prefix "infraclass"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infradomain"></see></summary>
    let infradomain = _prefix "infradomain"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrafamily"></see></summary>
    let infrafamily = _prefix "infrafamily"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraform"></see></summary>
    let infraform = _prefix "infraform"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infragenus"></see></summary>
    let infragenus = _prefix "infragenus"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrakingdom"></see></summary>
    let infrakingdom = _prefix "infrakingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infralegion"></see></summary>
    let infralegion = _prefix "infralegion"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraorder"></see></summary>
    let infraorder = _prefix "infraorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraphylum"></see></summary>
    let infraphylum = _prefix "infraphylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrasection"></see></summary>
    let infrasection = _prefix "infrasection"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraseries"></see></summary>
    let infraseries = _prefix "infraseries"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraspecies"></see></summary>
    let infraspecies = _prefix "infraspecies"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infratribe"></see></summary>
    let infratribe = _prefix "infratribe"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infravariety"></see></summary>
    let infravariety = _prefix "infravariety"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#interkingdom"></see></summary>
    let interkingdom = _prefix "interkingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#kingdom"></see></summary>
    let kingdom = _prefix "kingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#klepton"></see></summary>
    let klepton = _prefix "klepton"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#legion"></see></summary>
    let legion = _prefix "legion"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#lusus"></see></summary>
    let lusus = _prefix "lusus"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#magnorder"></see></summary>
    let magnorder = _prefix "magnorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#megaorder"></see></summary>
    let megaorder = _prefix "megaorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#microspecies"></see></summary>
    let microspecies = _prefix "microspecies"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#midkingdom"></see></summary>
    let midkingdom = _prefix "midkingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#midphylum"></see></summary>
    let midphylum = _prefix "midphylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#mirorder"></see></summary>
    let mirorder = _prefix "mirorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#nation"></see></summary>
    let nation = _prefix "nation"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#parvclass"></see></summary>
    let parvclass = _prefix "parvclass"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#parvorder"></see></summary>
    let parvorder = _prefix "parvorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#pathovar"></see></summary>
    let pathovar = _prefix "pathovar"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#phylum"></see></summary>
    let phylum = _prefix "phylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#population"></see></summary>
    let population = _prefix "population"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#section"></see></summary>
    let section = _prefix "section"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#sectionOfBreeds"></see></summary>
    let sectionOfBreeds = _prefix "sectionOfBreeds"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#seeAlso"></see></summary>
    let seeAlso = _prefix "seeAlso"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#series"></see></summary>
    let series = _prefix "series"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#serogroup"></see></summary>
    let serogroup = _prefix "serogroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#serovar"></see></summary>
    let serovar = _prefix "serovar"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#species"></see></summary>
    let species = _prefix "species"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#speciesGroup"></see></summary>
    let speciesGroup = _prefix "speciesGroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#speciesSubgroup"></see></summary>
    let speciesSubgroup = _prefix "speciesSubgroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#strain"></see></summary>
    let strain = _prefix "strain"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subclass"></see></summary>
    let subclass = _prefix "subclass"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subcohort"></see></summary>
    let subcohort = _prefix "subcohort"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subdivision"></see></summary>
    let subdivision = _prefix "subdivision"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subdomain"></see></summary>
    let subdomain = _prefix "subdomain"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subfamily"></see></summary>
    let subfamily = _prefix "subfamily"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subfamilyGroup"></see></summary>
    let subfamilyGroup = _prefix "subfamilyGroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subform"></see></summary>
    let subform = _prefix "subform"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subgenus"></see></summary>
    let subgenus = _prefix "subgenus"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subgroup"></see></summary>
    let subgroup = _prefix "subgroup"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subkingdom"></see></summary>
    let subkingdom = _prefix "subkingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#sublegion"></see></summary>
    let sublegion = _prefix "sublegion"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#suborder"></see></summary>
    let suborder = _prefix "suborder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subphylum"></see></summary>
    let subphylum = _prefix "subphylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subsection"></see></summary>
    let subsection = _prefix "subsection"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subseries"></see></summary>
    let subseries = _prefix "subseries"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subspecies"></see></summary>
    let subspecies = _prefix "subspecies"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subtribe"></see></summary>
    let subtribe = _prefix "subtribe"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subvariety"></see></summary>
    let subvariety = _prefix "subvariety"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superclass"></see></summary>
    let superclass = _prefix "superclass"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supercohort"></see></summary>
    let supercohort = _prefix "supercohort"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superdomain"></see></summary>
    let superdomain = _prefix "superdomain"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superfamily"></see></summary>
    let superfamily = _prefix "superfamily"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superform"></see></summary>
    let superform = _prefix "superform"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supergenus"></see></summary>
    let supergenus = _prefix "supergenus"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superkingdom"></see></summary>
    let superkingdom = _prefix "superkingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superlegion"></see></summary>
    let superlegion = _prefix "superlegion"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superorder"></see></summary>
    let superorder = _prefix "superorder"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superphylum"></see></summary>
    let superphylum = _prefix "superphylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supersection"></see></summary>
    let supersection = _prefix "supersection"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superseries"></see></summary>
    let superseries = _prefix "superseries"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superspecies"></see></summary>
    let superspecies = _prefix "superspecies"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supertribe"></see></summary>
    let supertribe = _prefix "supertribe"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supervariety"></see></summary>
    let supervariety = _prefix "supervariety"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#suprakingdom"></see></summary>
    let suprakingdom = _prefix "suprakingdom"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supraphylum"></see></summary>
    let supraphylum = _prefix "supraphylum"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#synklepton"></see></summary>
    let synklepton = _prefix "synklepton"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#tribe"></see></summary>
    let tribe = _prefix "tribe"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#variety"></see></summary>
    let variety = _prefix "variety"

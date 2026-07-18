namespace http.purl.org.NET.biol.botany.hash

open DoxAletheia.Rdf_Vocabulary

module botany =
    let _namespace_name = "http://purl.org/NET/biol/botany#"
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#Taxonomy"></see></summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#aberration"></see></summary>
    let aberration = Namespaced_IRI.parse _namespace_name "aberration" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#aggregate"></see></summary>
    let aggregate = Namespaced_IRI.parse _namespace_name "aggregate" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#biovar"></see></summary>
    let biovar = Namespaced_IRI.parse _namespace_name "biovar" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#branch"></see></summary>
    let branch = Namespaced_IRI.parse _namespace_name "branch" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#breed"></see></summary>
    let breed = Namespaced_IRI.parse _namespace_name "breed" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#claudius"></see></summary>
    let claudius = Namespaced_IRI.parse _namespace_name "claudius" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cohort"></see></summary>
    let cohort = Namespaced_IRI.parse _namespace_name "cohort" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#complex"></see></summary>
    let complex = Namespaced_IRI.parse _namespace_name "complex" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#convariety"></see></summary>
    let convariety = Namespaced_IRI.parse _namespace_name "convariety" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cultivar"></see></summary>
    let cultivar = Namespaced_IRI.parse _namespace_name "cultivar" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#cultivarGroup"></see></summary>
    let cultivarGroup =
        Namespaced_IRI.parse _namespace_name "cultivarGroup" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#division"></see></summary>
    let division = Namespaced_IRI.parse _namespace_name "division" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#empire"></see></summary>
    let empire = Namespaced_IRI.parse _namespace_name "empire" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#falanx"></see></summary>
    let falanx = Namespaced_IRI.parse _namespace_name "falanx" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#family"></see></summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#familyGroup"></see></summary>
    let familyGroup =
        Namespaced_IRI.parse _namespace_name "familyGroup" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#form"></see></summary>
    let form = Namespaced_IRI.parse _namespace_name "form" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#genus"></see></summary>
    let genus = Namespaced_IRI.parse _namespace_name "genus" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#genusGroup"></see></summary>
    let genusGroup = Namespaced_IRI.parse _namespace_name "genusGroup" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#gigaorder"></see></summary>
    let gigaorder = Namespaced_IRI.parse _namespace_name "gigaorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#grade"></see></summary>
    let grade = Namespaced_IRI.parse _namespace_name "grade" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#grandorder"></see></summary>
    let grandorder = Namespaced_IRI.parse _namespace_name "grandorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#groupOfBreeds"></see></summary>
    let groupOfBreeds =
        Namespaced_IRI.parse _namespace_name "groupOfBreeds" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hasTaxonomy"></see></summary>
    let hasTaxonomy =
        Namespaced_IRI.parse _namespace_name "hasTaxonomy" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hybrid"></see></summary>
    let hybrid = Namespaced_IRI.parse _namespace_name "hybrid" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#hyperorder"></see></summary>
    let hyperorder = Namespaced_IRI.parse _namespace_name "hyperorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraclass"></see></summary>
    let infraclass = Namespaced_IRI.parse _namespace_name "infraclass" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infradomain"></see></summary>
    let infradomain =
        Namespaced_IRI.parse _namespace_name "infradomain" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrafamily"></see></summary>
    let infrafamily =
        Namespaced_IRI.parse _namespace_name "infrafamily" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraform"></see></summary>
    let infraform = Namespaced_IRI.parse _namespace_name "infraform" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infragenus"></see></summary>
    let infragenus = Namespaced_IRI.parse _namespace_name "infragenus" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrakingdom"></see></summary>
    let infrakingdom =
        Namespaced_IRI.parse _namespace_name "infrakingdom" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infralegion"></see></summary>
    let infralegion =
        Namespaced_IRI.parse _namespace_name "infralegion" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraorder"></see></summary>
    let infraorder = Namespaced_IRI.parse _namespace_name "infraorder" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraphylum"></see></summary>
    let infraphylum =
        Namespaced_IRI.parse _namespace_name "infraphylum" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infrasection"></see></summary>
    let infrasection =
        Namespaced_IRI.parse _namespace_name "infrasection" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraseries"></see></summary>
    let infraseries =
        Namespaced_IRI.parse _namespace_name "infraseries" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infraspecies"></see></summary>
    let infraspecies =
        Namespaced_IRI.parse _namespace_name "infraspecies" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infratribe"></see></summary>
    let infratribe = Namespaced_IRI.parse _namespace_name "infratribe" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#infravariety"></see></summary>
    let infravariety =
        Namespaced_IRI.parse _namespace_name "infravariety" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#interkingdom"></see></summary>
    let interkingdom =
        Namespaced_IRI.parse _namespace_name "interkingdom" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#kingdom"></see></summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#klepton"></see></summary>
    let klepton = Namespaced_IRI.parse _namespace_name "klepton" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#legion"></see></summary>
    let legion = Namespaced_IRI.parse _namespace_name "legion" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#lusus"></see></summary>
    let lusus = Namespaced_IRI.parse _namespace_name "lusus" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#magnorder"></see></summary>
    let magnorder = Namespaced_IRI.parse _namespace_name "magnorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#megaorder"></see></summary>
    let megaorder = Namespaced_IRI.parse _namespace_name "megaorder" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#microspecies"></see></summary>
    let microspecies =
        Namespaced_IRI.parse _namespace_name "microspecies" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#midkingdom"></see></summary>
    let midkingdom = Namespaced_IRI.parse _namespace_name "midkingdom" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#midphylum"></see></summary>
    let midphylum = Namespaced_IRI.parse _namespace_name "midphylum" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#mirorder"></see></summary>
    let mirorder = Namespaced_IRI.parse _namespace_name "mirorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#nation"></see></summary>
    let nation = Namespaced_IRI.parse _namespace_name "nation" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#parvclass"></see></summary>
    let parvclass = Namespaced_IRI.parse _namespace_name "parvclass" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#parvorder"></see></summary>
    let parvorder = Namespaced_IRI.parse _namespace_name "parvorder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#pathovar"></see></summary>
    let pathovar = Namespaced_IRI.parse _namespace_name "pathovar" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#phylum"></see></summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#population"></see></summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#section"></see></summary>
    let section = Namespaced_IRI.parse _namespace_name "section" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#sectionOfBreeds"></see></summary>
    let sectionOfBreeds =
        Namespaced_IRI.parse _namespace_name "sectionOfBreeds" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#seeAlso"></see></summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#series"></see></summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#serogroup"></see></summary>
    let serogroup = Namespaced_IRI.parse _namespace_name "serogroup" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#serovar"></see></summary>
    let serovar = Namespaced_IRI.parse _namespace_name "serovar" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#species"></see></summary>
    let species = Namespaced_IRI.parse _namespace_name "species" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#speciesGroup"></see></summary>
    let speciesGroup =
        Namespaced_IRI.parse _namespace_name "speciesGroup" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#speciesSubgroup"></see></summary>
    let speciesSubgroup =
        Namespaced_IRI.parse _namespace_name "speciesSubgroup" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#strain"></see></summary>
    let strain = Namespaced_IRI.parse _namespace_name "strain" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subclass"></see></summary>
    let subclass = Namespaced_IRI.parse _namespace_name "subclass" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subcohort"></see></summary>
    let subcohort = Namespaced_IRI.parse _namespace_name "subcohort" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subdivision"></see></summary>
    let subdivision =
        Namespaced_IRI.parse _namespace_name "subdivision" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subdomain"></see></summary>
    let subdomain = Namespaced_IRI.parse _namespace_name "subdomain" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subfamily"></see></summary>
    let subfamily = Namespaced_IRI.parse _namespace_name "subfamily" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subfamilyGroup"></see></summary>
    let subfamilyGroup =
        Namespaced_IRI.parse _namespace_name "subfamilyGroup" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subform"></see></summary>
    let subform = Namespaced_IRI.parse _namespace_name "subform" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subgenus"></see></summary>
    let subgenus = Namespaced_IRI.parse _namespace_name "subgenus" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subgroup"></see></summary>
    let subgroup = Namespaced_IRI.parse _namespace_name "subgroup" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subkingdom"></see></summary>
    let subkingdom = Namespaced_IRI.parse _namespace_name "subkingdom" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#sublegion"></see></summary>
    let sublegion = Namespaced_IRI.parse _namespace_name "sublegion" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#suborder"></see></summary>
    let suborder = Namespaced_IRI.parse _namespace_name "suborder" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subphylum"></see></summary>
    let subphylum = Namespaced_IRI.parse _namespace_name "subphylum" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subsection"></see></summary>
    let subsection = Namespaced_IRI.parse _namespace_name "subsection" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subseries"></see></summary>
    let subseries = Namespaced_IRI.parse _namespace_name "subseries" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subspecies"></see></summary>
    let subspecies = Namespaced_IRI.parse _namespace_name "subspecies" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subtribe"></see></summary>
    let subtribe = Namespaced_IRI.parse _namespace_name "subtribe" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#subvariety"></see></summary>
    let subvariety = Namespaced_IRI.parse _namespace_name "subvariety" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superclass"></see></summary>
    let superclass = Namespaced_IRI.parse _namespace_name "superclass" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supercohort"></see></summary>
    let supercohort =
        Namespaced_IRI.parse _namespace_name "supercohort" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superdomain"></see></summary>
    let superdomain =
        Namespaced_IRI.parse _namespace_name "superdomain" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superfamily"></see></summary>
    let superfamily =
        Namespaced_IRI.parse _namespace_name "superfamily" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superform"></see></summary>
    let superform = Namespaced_IRI.parse _namespace_name "superform" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supergenus"></see></summary>
    let supergenus = Namespaced_IRI.parse _namespace_name "supergenus" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superkingdom"></see></summary>
    let superkingdom =
        Namespaced_IRI.parse _namespace_name "superkingdom" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superlegion"></see></summary>
    let superlegion =
        Namespaced_IRI.parse _namespace_name "superlegion" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superorder"></see></summary>
    let superorder = Namespaced_IRI.parse _namespace_name "superorder" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superphylum"></see></summary>
    let superphylum =
        Namespaced_IRI.parse _namespace_name "superphylum" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supersection"></see></summary>
    let supersection =
        Namespaced_IRI.parse _namespace_name "supersection" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superseries"></see></summary>
    let superseries =
        Namespaced_IRI.parse _namespace_name "superseries" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#superspecies"></see></summary>
    let superspecies =
        Namespaced_IRI.parse _namespace_name "superspecies" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supertribe"></see></summary>
    let supertribe = Namespaced_IRI.parse _namespace_name "supertribe" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supervariety"></see></summary>
    let supervariety =
        Namespaced_IRI.parse _namespace_name "supervariety" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#suprakingdom"></see></summary>
    let suprakingdom =
        Namespaced_IRI.parse _namespace_name "suprakingdom" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#supraphylum"></see></summary>
    let supraphylum =
        Namespaced_IRI.parse _namespace_name "supraphylum" |> NamespacedName

    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#synklepton"></see></summary>
    let synklepton = Namespaced_IRI.parse _namespace_name "synklepton" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#tribe"></see></summary>
    let tribe = Namespaced_IRI.parse _namespace_name "tribe" |> NamespacedName
    /// <summary>
    /// ...
    /// <see href="http://purl.org/NET/biol/botany#variety"></see></summary>
    let variety = Namespaced_IRI.parse _namespace_name "variety" |> NamespacedName

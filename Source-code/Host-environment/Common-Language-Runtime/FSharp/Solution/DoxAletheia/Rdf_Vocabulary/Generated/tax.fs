namespace https.w3id.org.EUTaxO.hash

open DoxAletheia.Rdf_Vocabulary

module tax =
    let _namespace_name = "https://w3id.org/EUTaxO#"
    /// <summary>
    ///   <see href="https://w3id.org/EUTaxO#2.0.0"></see>
    /// </summary>
    let ``_2.0.0`` = Namespaced_IRI.parse _namespace_name "2.0.0" |> NamespacedName
    /// <summary>
    /// Animalia kingdom
    /// <see href="https://w3id.org/EUTaxO#Animalia"></see></summary>
    let Animalia = Namespaced_IRI.parse _namespace_name "Animalia" |> NamespacedName
    /// <summary>
    /// Base taxon class
    /// <see href="https://w3id.org/EUTaxO#Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName
    /// <summary>
    /// Defines a hierarchy from more generic taxa, to more specific ones
    /// <see href="https://w3id.org/EUTaxO#belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    /// Whether to use brackets for the correct nomenclature of a taxon
    /// <see href="https://w3id.org/EUTaxO#brackets"></see></summary>
    let brackets = Namespaced_IRI.parse _namespace_name "brackets" |> NamespacedName
    /// <summary>
    /// id from the EUdaphobase database
    /// <see href="https://w3id.org/EUTaxO#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    /// The kingdom of a specific taxon
    /// <see href="https://w3id.org/EUTaxO#kingdom"></see></summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName
    /// <summary>
    /// The phylum of a specific taxon
    /// <see href="https://w3id.org/EUTaxO#phylum"></see></summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    /// Relates if two taxon are synonyms
    /// <see href="https://w3id.org/EUTaxO#synonym"></see></summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName

    /// <summary>
    /// Whether or not synonyms exists for a given taxon
    /// <see href="https://w3id.org/EUTaxO#synonyms_exist"></see></summary>
    let synonyms_exist =
        Namespaced_IRI.parse _namespace_name "synonyms_exist" |> NamespacedName

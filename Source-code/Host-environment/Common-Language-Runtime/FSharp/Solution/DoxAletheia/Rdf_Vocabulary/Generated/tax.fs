namespace https.w3id.org.EUTaxO.hash

open DoxAletheia

module tax =
    let _namespace_name = "https://w3id.org/EUTaxO#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/EUTaxO#2.0.0"></see>
    /// </summary>
    let ``_2.0.0`` = _prefix "2.0.0"
    /// <summary>
    /// Animalia kingdom
    /// <see href="https://w3id.org/EUTaxO#Animalia"></see></summary>
    let Animalia = _prefix "Animalia"
    /// <summary>
    /// Base taxon class
    /// <see href="https://w3id.org/EUTaxO#Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// Defines a hierarchy from more generic taxa, to more specific ones
    /// <see href="https://w3id.org/EUTaxO#belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// Whether to use brackets for the correct nomenclature of a taxon
    /// <see href="https://w3id.org/EUTaxO#brackets"></see></summary>
    let brackets = _prefix "brackets"
    /// <summary>
    /// id from the EUdaphobase database
    /// <see href="https://w3id.org/EUTaxO#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// The kingdom of a specific taxon
    /// <see href="https://w3id.org/EUTaxO#kingdom"></see></summary>
    let kingdom = _prefix "kingdom"
    /// <summary>
    /// The phylum of a specific taxon
    /// <see href="https://w3id.org/EUTaxO#phylum"></see></summary>
    let phylum = _prefix "phylum"
    /// <summary>
    /// Relates if two taxon are synonyms
    /// <see href="https://w3id.org/EUTaxO#synonym"></see></summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// Whether or not synonyms exists for a given taxon
    /// <see href="https://w3id.org/EUTaxO#synonyms_exist"></see></summary>
    let synonyms_exist = _prefix "synonyms_exist"

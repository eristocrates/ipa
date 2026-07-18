namespace http.purl.org.net.hifm.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module hifm =
    let _namespace_name = "http://purl.org/net/hifm/ontology#"
    /// <summary>
    /// This class represents a brand-name drug.
    /// <see href="http://purl.org/net/hifm/ontology#Drug"></see></summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName
    /// <summary>
    /// This property represents the dosage form of the medicine.
    /// <see href="http://purl.org/net/hifm/ontology#dosageForm"></see></summary>
    let dosageForm = Namespaced_IRI.parse _namespace_name "dosageForm" |> NamespacedName
    /// <summary>
    /// This is the ID that the medicine has in the local system of the Health Insurance Fund of Macedonia
    /// <see href="http://purl.org/net/hifm/ontology#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// This property represents a manufacturer of a drug.
    /// <see href="http://purl.org/net/hifm/ontology#manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// This property represents additional notes related to a medicine.
    /// <see href="http://purl.org/net/hifm/ontology#notes"></see></summary>
    let notes = Namespaced_IRI.parse _namespace_name "notes" |> NamespacedName
    /// <summary>
    /// This property represents the number of units per drug package.
    /// <see href="http://purl.org/net/hifm/ontology#packaging"></see></summary>
    let packaging = Namespaced_IRI.parse _namespace_name "packaging" |> NamespacedName

    /// <summary>
    /// This property represents the referent price of the medicine in macedonian denars (MKD), with NO VAT calculated
    /// <see href="http://purl.org/net/hifm/ontology#refPriceNoVAT"></see></summary>
    let refPriceNoVAT =
        Namespaced_IRI.parse _namespace_name "refPriceNoVAT" |> NamespacedName

    /// <summary>
    /// This property represents the referent value of the medicine in macedonian denars (MKD), with VAT calculated
    /// <see href="http://purl.org/net/hifm/ontology#refPriceWithVAT"></see></summary>
    let refPriceWithVAT =
        Namespaced_IRI.parse _namespace_name "refPriceWithVAT" |> NamespacedName

    /// <summary>
    /// This property represents a similarity that is known between two drugs.
    /// <see href="http://purl.org/net/hifm/ontology#similarTo"></see></summary>
    let similarTo = Namespaced_IRI.parse _namespace_name "similarTo" |> NamespacedName
    /// <summary>
    /// This property represents the strength of the drug, in milligrams.
    /// <see href="http://purl.org/net/hifm/ontology#strength"></see></summary>
    let strength = Namespaced_IRI.parse _namespace_name "strength" |> NamespacedName

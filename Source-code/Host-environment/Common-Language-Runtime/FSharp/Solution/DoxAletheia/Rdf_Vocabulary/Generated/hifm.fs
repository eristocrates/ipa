namespace http.purl.org.net.hifm.ontology.hash

open DoxAletheia

module hifm =
    let _namespace_name = "http://purl.org/net/hifm/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents a brand-name drug.
    /// <see href="http://purl.org/net/hifm/ontology#Drug"></see></summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// This property represents the dosage form of the medicine.
    /// <see href="http://purl.org/net/hifm/ontology#dosageForm"></see></summary>
    let dosageForm = _prefix "dosageForm"
    /// <summary>
    /// This is the ID that the medicine has in the local system of the Health Insurance Fund of Macedonia
    /// <see href="http://purl.org/net/hifm/ontology#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// This property represents a manufacturer of a drug.
    /// <see href="http://purl.org/net/hifm/ontology#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// This property represents additional notes related to a medicine.
    /// <see href="http://purl.org/net/hifm/ontology#notes"></see></summary>
    let notes = _prefix "notes"
    /// <summary>
    /// This property represents the number of units per drug package.
    /// <see href="http://purl.org/net/hifm/ontology#packaging"></see></summary>
    let packaging = _prefix "packaging"
    /// <summary>
    /// This property represents the referent price of the medicine in macedonian denars (MKD), with NO VAT calculated
    /// <see href="http://purl.org/net/hifm/ontology#refPriceNoVAT"></see></summary>
    let refPriceNoVAT = _prefix "refPriceNoVAT"
    /// <summary>
    /// This property represents the referent value of the medicine in macedonian denars (MKD), with VAT calculated
    /// <see href="http://purl.org/net/hifm/ontology#refPriceWithVAT"></see></summary>
    let refPriceWithVAT = _prefix "refPriceWithVAT"
    /// <summary>
    /// This property represents a similarity that is known between two drugs.
    /// <see href="http://purl.org/net/hifm/ontology#similarTo"></see></summary>
    let similarTo = _prefix "similarTo"
    /// <summary>
    /// This property represents the strength of the drug, in milligrams.
    /// <see href="http://purl.org/net/hifm/ontology#strength"></see></summary>
    let strength = _prefix "strength"

namespace http.purl.org.net.dbm.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module dbm =
    let _namespace_name = "http://purl.org/net/dbm/ontology#"
    /// <summary>
    /// This class represents a Drug entity from the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#Drug"></see></summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName

    /// <summary>
    /// This property represents the approval number assigned by the Macedonian Drug Bureau, for the company.
    /// <see href="http://purl.org/net/dbm/ontology#approvalNumber"></see></summary>
    let approvalNumber =
        Namespaced_IRI.parse _namespace_name "approvalNumber" |> NamespacedName

    /// <summary>
    /// This property represents the company which holds the approval by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedFor"></see></summary>
    let approvedFor =
        Namespaced_IRI.parse _namespace_name "approvedFor" |> NamespacedName

    /// <summary>
    /// This property represents the date the company was given the approval by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedOn"></see></summary>
    let approvedOn = Namespaced_IRI.parse _namespace_name "approvedOn" |> NamespacedName

    /// <summary>
    /// This property represents the expiry date of the approval which the company was given by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedUntil"></see></summary>
    let approvedUntil =
        Namespaced_IRI.parse _namespace_name "approvedUntil" |> NamespacedName

    /// <summary>
    /// This property represents the extended ATC code for the drug, assigned by the Ministry of Health, of the Republic of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#atcCodeExtended"></see></summary>
    let atcCodeExtended =
        Namespaced_IRI.parse _namespace_name "atcCodeExtended" |> NamespacedName

    /// <summary>
    /// This property indicates wether the drug packaging has Braille support or not.
    /// <see href="http://purl.org/net/dbm/ontology#brailleSupport"></see></summary>
    let brailleSupport =
        Namespaced_IRI.parse _namespace_name "brailleSupport" |> NamespacedName

    /// <summary>
    /// This property represents the brand name of the drug, in cyrillic alphabet.
    /// <see href="http://purl.org/net/dbm/ontology#brandNameCyrillic"></see></summary>
    let brandNameCyrillic =
        Namespaced_IRI.parse _namespace_name "brandNameCyrillic" |> NamespacedName

    /// <summary>
    /// This property represents the dosage information for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#dosage"></see></summary>
    let dosage = Namespaced_IRI.parse _namespace_name "dosage" |> NamespacedName
    /// <summary>
    /// This property represents the EAN code of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#eanCode"></see></summary>
    let eanCode = Namespaced_IRI.parse _namespace_name "eanCode" |> NamespacedName
    /// <summary>
    /// This is the code that the drug instance has in the local system of the Health Insurance Fund of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#hifmCode"></see></summary>
    let hifmCode = Namespaced_IRI.parse _namespace_name "hifmCode" |> NamespacedName

    /// <summary>
    /// This property represents a manufacturer of a drug.
    /// <see href="http://purl.org/net/dbm/ontology#manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// This property represents the packaging information of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#packaging"></see></summary>
    let packaging = Namespaced_IRI.parse _namespace_name "packaging" |> NamespacedName

    /// <summary>
    /// This property tells if the drug is featured on the positive list of drugs, or not.
    /// <see href="http://purl.org/net/dbm/ontology#positiveList"></see></summary>
    let positiveList =
        Namespaced_IRI.parse _namespace_name "positiveList" |> NamespacedName

    /// <summary>
    /// This property represents the price of the drug in Macedonian Denars (MKD), with VAT calculated.
    /// <see href="http://purl.org/net/dbm/ontology#priceWithVAT"></see></summary>
    let priceWithVAT =
        Namespaced_IRI.parse _namespace_name "priceWithVAT" |> NamespacedName

    /// <summary>
    /// This property represents the price of the drug in Macedonian Denars (MKD), with no VAT calculated.
    /// <see href="http://purl.org/net/dbm/ontology#priceWithoutVAT"></see></summary>
    let priceWithoutVAT =
        Namespaced_IRI.parse _namespace_name "priceWithoutVAT" |> NamespacedName

    /// <summary>
    /// This property represents the reference price for the drug, as assigned by the Ministry of Health of the Republic of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#referencePrice"></see></summary>
    let referencePrice =
        Namespaced_IRI.parse _namespace_name "referencePrice" |> NamespacedName

    /// <summary>
    /// This property is used to represent that the drugs in question are similar in their purpose, i.e. contain the same active substance.
    /// <see href="http://purl.org/net/dbm/ontology#similarTo"></see></summary>
    let similarTo = Namespaced_IRI.parse _namespace_name "similarTo" |> NamespacedName
    /// <summary>
    /// This property represents the strength of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#strength"></see></summary>
    let strength = Namespaced_IRI.parse _namespace_name "strength" |> NamespacedName

    /// <summary>
    /// This property holds the URL to the summary report for the drug, published by the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#summaryReport"></see></summary>
    let summaryReport =
        Namespaced_IRI.parse _namespace_name "summaryReport" |> NamespacedName

    /// <summary>
    /// This property represents the date the drug data has been updated.
    /// <see href="http://purl.org/net/dbm/ontology#updateDate"></see></summary>
    let updateDate = Namespaced_IRI.parse _namespace_name "updateDate" |> NamespacedName

    /// <summary>
    /// This property holds the URL to the usage guidelines for the drug, published by the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#usageGuidelines"></see></summary>
    let usageGuidelines =
        Namespaced_IRI.parse _namespace_name "usageGuidelines" |> NamespacedName

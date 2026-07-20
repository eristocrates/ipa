namespace http.purl.org.net.dbm.ontology.hash

open DoxAletheia

module dbm =
    let _namespace_name = "http://purl.org/net/dbm/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents a Drug entity from the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#Drug"></see></summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// This property represents the approval number assigned by the Macedonian Drug Bureau, for the company.
    /// <see href="http://purl.org/net/dbm/ontology#approvalNumber"></see></summary>
    let approvalNumber = _prefix "approvalNumber"
    /// <summary>
    /// This property represents the company which holds the approval by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedFor"></see></summary>
    let approvedFor = _prefix "approvedFor"
    /// <summary>
    /// This property represents the date the company was given the approval by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedOn"></see></summary>
    let approvedOn = _prefix "approvedOn"
    /// <summary>
    /// This property represents the expiry date of the approval which the company was given by the Macedonian Drug Bureau for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#approvedUntil"></see></summary>
    let approvedUntil = _prefix "approvedUntil"
    /// <summary>
    /// This property represents the extended ATC code for the drug, assigned by the Ministry of Health, of the Republic of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#atcCodeExtended"></see></summary>
    let atcCodeExtended = _prefix "atcCodeExtended"
    /// <summary>
    /// This property indicates wether the drug packaging has Braille support or not.
    /// <see href="http://purl.org/net/dbm/ontology#brailleSupport"></see></summary>
    let brailleSupport = _prefix "brailleSupport"
    /// <summary>
    /// This property represents the brand name of the drug, in cyrillic alphabet.
    /// <see href="http://purl.org/net/dbm/ontology#brandNameCyrillic"></see></summary>
    let brandNameCyrillic = _prefix "brandNameCyrillic"
    /// <summary>
    /// This property represents the dosage information for the drug.
    /// <see href="http://purl.org/net/dbm/ontology#dosage"></see></summary>
    let dosage = _prefix "dosage"
    /// <summary>
    /// This property represents the EAN code of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#eanCode"></see></summary>
    let eanCode = _prefix "eanCode"
    /// <summary>
    /// This is the code that the drug instance has in the local system of the Health Insurance Fund of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#hifmCode"></see></summary>
    let hifmCode = _prefix "hifmCode"
    /// <summary>
    /// This property represents a manufacturer of a drug.
    /// <see href="http://purl.org/net/dbm/ontology#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// This property represents the packaging information of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#packaging"></see></summary>
    let packaging = _prefix "packaging"
    /// <summary>
    /// This property tells if the drug is featured on the positive list of drugs, or not.
    /// <see href="http://purl.org/net/dbm/ontology#positiveList"></see></summary>
    let positiveList = _prefix "positiveList"
    /// <summary>
    /// This property represents the price of the drug in Macedonian Denars (MKD), with VAT calculated.
    /// <see href="http://purl.org/net/dbm/ontology#priceWithVAT"></see></summary>
    let priceWithVAT = _prefix "priceWithVAT"
    /// <summary>
    /// This property represents the price of the drug in Macedonian Denars (MKD), with no VAT calculated.
    /// <see href="http://purl.org/net/dbm/ontology#priceWithoutVAT"></see></summary>
    let priceWithoutVAT = _prefix "priceWithoutVAT"
    /// <summary>
    /// This property represents the reference price for the drug, as assigned by the Ministry of Health of the Republic of Macedonia.
    /// <see href="http://purl.org/net/dbm/ontology#referencePrice"></see></summary>
    let referencePrice = _prefix "referencePrice"
    /// <summary>
    /// This property is used to represent that the drugs in question are similar in their purpose, i.e. contain the same active substance.
    /// <see href="http://purl.org/net/dbm/ontology#similarTo"></see></summary>
    let similarTo = _prefix "similarTo"
    /// <summary>
    /// This property represents the strength of the drug.
    /// <see href="http://purl.org/net/dbm/ontology#strength"></see></summary>
    let strength = _prefix "strength"
    /// <summary>
    /// This property holds the URL to the summary report for the drug, published by the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#summaryReport"></see></summary>
    let summaryReport = _prefix "summaryReport"
    /// <summary>
    /// This property represents the date the drug data has been updated.
    /// <see href="http://purl.org/net/dbm/ontology#updateDate"></see></summary>
    let updateDate = _prefix "updateDate"
    /// <summary>
    /// This property holds the URL to the usage guidelines for the drug, published by the Macedonian Drug Bureau.
    /// <see href="http://purl.org/net/dbm/ontology#usageGuidelines"></see></summary>
    let usageGuidelines = _prefix "usageGuidelines"

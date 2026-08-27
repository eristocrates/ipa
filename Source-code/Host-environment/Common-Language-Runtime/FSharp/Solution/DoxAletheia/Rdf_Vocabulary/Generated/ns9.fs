namespace https.spdx.org.rdf._3._1.terms.ExpandedLicensing.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns9 =
    let _namespace_iri = Namespace_Iri ns9 |> NamespaceIRI

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ConjunctiveLicenseSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Portion of an AnyLicenseInfo representing a set of licensing information
    /// where all elements apply."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet</seealso>
    let ConjunctiveLicenseSet =
        Prefixed_Name(ns9, "ConjunctiveLicenseSet") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/CustomLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A license that is not listed on the SPDX License List."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense</seealso>
    let CustomLicense = Prefixed_Name(ns9, "CustomLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/CustomLicenseAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A license addition that is not listed on the SPDX Exceptions List."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition</seealso>
    let CustomLicenseAddition =
        Prefixed_Name(ns9, "CustomLicenseAddition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/DisjunctiveLicenseSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Portion of an AnyLicenseInfo representing a set of licensing information where
    /// only one of the elements applies."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet</seealso>
    let DisjunctiveLicenseSet =
        Prefixed_Name(ns9, "DisjunctiveLicenseSet") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ExtendableLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract class representing a License or an OrLaterOperator."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense</seealso>
    let ExtendableLicense = Prefixed_Name(ns9, "ExtendableLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete subclass of AnyLicenseInfo used by Individuals in the
    /// ExpandedLicensing profile."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo</seealso>
    let IndividualLicensingInfo =
        Prefixed_Name(ns9, "IndividualLicensingInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Abstract class for the portion of an AnyLicenseInfo representing a license."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License</seealso>
    let License = Prefixed_Name(ns9, "License") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/LicenseAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Abstract class for additional text intended to be added to a License, but
    /// which is not itself a standalone License."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition</seealso>
    let LicenseAddition = Prefixed_Name(ns9, "LicenseAddition") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ListedLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A license that is listed on the SPDX License List."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense</seealso>
    let ListedLicense = Prefixed_Name(ns9, "ListedLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ListedLicenseException</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A license exception that is listed on the SPDX Exceptions list."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException</seealso>
    let ListedLicenseException =
        Prefixed_Name(ns9, "ListedLicenseException") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/NoAssertionLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An Individual Value for License when no assertion can be made about its actual
    /// value."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense</seealso>
    let NoAssertionLicense = Prefixed_Name(ns9, "NoAssertionLicense") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/NoneLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An Individual Value for License where the SPDX data creator determines that no
    /// license is present."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense</seealso>
    let NoneLicense = Prefixed_Name(ns9, "NoneLicense") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/OrLaterOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Portion of an AnyLicenseInfo representing this version, or any later version,
    /// of the indicated License."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator</seealso>
    let OrLaterOperator = Prefixed_Name(ns9, "OrLaterOperator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/WithAdditionOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Portion of an AnyLicenseInfo representing a License which has additional
    /// text applied to it."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator</seealso>
    let WithAdditionOperator =
        Prefixed_Name(ns9, "WithAdditionOperator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/additionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the full text of a LicenseAddition."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText</seealso>
    let additionText = Prefixed_Name(ns9, "additionText") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/deprecatedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the SPDX License List version in which this license or exception
    /// identifier was deprecated."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion</seealso>
    let deprecatedVersion = Prefixed_Name(ns9, "deprecatedVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isDeprecatedAdditionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether an additional text identifier has been marked as deprecated."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId</seealso>
    let isDeprecatedAdditionId =
        Prefixed_Name(ns9, "isDeprecatedAdditionId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isDeprecatedLicenseId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether a license or additional text identifier has been marked as
    /// deprecated."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId</seealso>
    let isDeprecatedLicenseId =
        Prefixed_Name(ns9, "isDeprecatedLicenseId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isFsfLibre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether the License is listed as free by the
    /// Free Software Foundation (FSF)."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre</seealso>
    let isFsfLibre = Prefixed_Name(ns9, "isFsfLibre") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isOsiApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether the License is listed as approved by the
    /// Open Source Initiative (OSI)."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved</seealso>
    let isOsiApproved = Prefixed_Name(ns9, "isOsiApproved") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/licenseXml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies all the text and metadata associated with a license in the license
    /// XML format."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml</seealso>
    let licenseXml = Prefixed_Name(ns9, "licenseXml") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/listVersionAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the SPDX License List version in which this ListedLicense or
    /// ListedLicenseException identifier was first added."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded</seealso>
    let listVersionAdded = Prefixed_Name(ns9, "listVersionAdded") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A license expression participating in a license set."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member</seealso>
    let member_ = Prefixed_Name(ns9, "member") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/obsoletedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the licenseId that is preferred to be used in place of a deprecated
    /// License or LicenseAddition."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy</seealso>
    let obsoletedBy = Prefixed_Name(ns9, "obsoletedBy") |> PrefixedName
    /// <summary>
    ///   <para>spdx:ExpandedLicensing/seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Contains a URL where the License or LicenseAddition can be found in use."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso</seealso>
    let seeAlso = Prefixed_Name(ns9, "seeAlso") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardAdditionTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the full text of a LicenseAddition, in SPDX templating format."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate</seealso>
    let standardAdditionTemplate =
        Prefixed_Name(ns9, "standardAdditionTemplate") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardLicenseHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a License author's preferred text to indicate that a file is covered
    /// by the License."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader</seealso>
    let standardLicenseHeader =
        Prefixed_Name(ns9, "standardLicenseHeader") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardLicenseTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the full text of a License, in SPDX templating format."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate</seealso>
    let standardLicenseTemplate =
        Prefixed_Name(ns9, "standardLicenseTemplate") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A LicenseAddition participating in a 'with addition' model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition</seealso>
    let subjectAddition = Prefixed_Name(ns9, "subjectAddition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectExtendableLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A License participating in a 'with addition' model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense</seealso>
    let subjectExtendableLicense =
        Prefixed_Name(ns9, "subjectExtendableLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A License participating in an 'or later' model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense</seealso>
    let subjectLicense = Prefixed_Name(ns9, "subjectLicense") |> PrefixedName

namespace https.ref.gs1.org.voc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gs1 =
    let _namespace_iri = Namespace_Iri gs1 |> NamespaceIRI

    /// <summary>
    ///   <para>gs1:CertificationDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/CertificationDetails">https://ref.gs1.org/voc/CertificationDetails</seealso>
    let CertificationDetails =
        Prefixed_Name(gs1, "CertificationDetails") |> PrefixedName

    /// <summary>
    ///   <para>gs1:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/ContactPoint">https://ref.gs1.org/voc/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(gs1, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>gs1:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/Country">https://ref.gs1.org/voc/Country</seealso>
    let Country = Prefixed_Name(gs1, "Country") |> PrefixedName
    /// <summary>
    ///   <para>gs1:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/Organization">https://ref.gs1.org/voc/Organization</seealso>
    let Organization = Prefixed_Name(gs1, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>gs1:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/PostalAddress">https://ref.gs1.org/voc/PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(gs1, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>gs1:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/address">https://ref.gs1.org/voc/address</seealso>
    let address = Prefixed_Name(gs1, "address") |> PrefixedName
    /// <summary>
    ///   <para>gs1:addressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/addressLocality">https://ref.gs1.org/voc/addressLocality</seealso>
    let addressLocality = Prefixed_Name(gs1, "addressLocality") |> PrefixedName
    /// <summary>
    ///   <para>gs1:availableLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/availableLanguage">https://ref.gs1.org/voc/availableLanguage</seealso>
    let availableLanguage = Prefixed_Name(gs1, "availableLanguage") |> PrefixedName
    /// <summary>
    ///   <para>gs1:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/contactPoint">https://ref.gs1.org/voc/contactPoint</seealso>
    let contactPoint = Prefixed_Name(gs1, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>gs1:contactType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/contactType">https://ref.gs1.org/voc/contactType</seealso>
    let contactType = Prefixed_Name(gs1, "contactType") |> PrefixedName
    /// <summary>
    ///   <para>gs1:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/description">https://ref.gs1.org/voc/description</seealso>
    let description = Prefixed_Name(gs1, "description") |> PrefixedName
    /// <summary>
    ///   <para>gs1:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/email">https://ref.gs1.org/voc/email</seealso>
    let email = Prefixed_Name(gs1, "email") |> PrefixedName
    /// <summary>
    ///   <para>gs1:faxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/faxNumber">https://ref.gs1.org/voc/faxNumber</seealso>
    let faxNumber = Prefixed_Name(gs1, "faxNumber") |> PrefixedName

    /// <summary>
    ///   <para>gs1:globalLocationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/globalLocationNumber">https://ref.gs1.org/voc/globalLocationNumber</seealso>
    let globalLocationNumber =
        Prefixed_Name(gs1, "globalLocationNumber") |> PrefixedName

    /// <summary>
    ///   <para>gs1:gtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/gtin">https://ref.gs1.org/voc/gtin</seealso>
    let gtin = Prefixed_Name(gs1, "gtin") |> PrefixedName
    /// <summary>
    ///   <para>gs1:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/manufacturer">https://ref.gs1.org/voc/manufacturer</seealso>
    let manufacturer = Prefixed_Name(gs1, "manufacturer") |> PrefixedName

    /// <summary>
    ///   <para>gs1:organizationFormationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/organizationFormationDate">https://ref.gs1.org/voc/organizationFormationDate</seealso>
    let organizationFormationDate =
        Prefixed_Name(gs1, "organizationFormationDate") |> PrefixedName

    /// <summary>
    ///   <para>gs1:organizationLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/organizationLegalName">https://ref.gs1.org/voc/organizationLegalName</seealso>
    let organizationLegalName =
        Prefixed_Name(gs1, "organizationLegalName") |> PrefixedName

    /// <summary>
    ///   <para>gs1:organizationTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/organizationTerminationDate">https://ref.gs1.org/voc/organizationTerminationDate</seealso>
    let organizationTerminationDate =
        Prefixed_Name(gs1, "organizationTerminationDate") |> PrefixedName

    /// <summary>
    ///   <para>gs1:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/owns">https://ref.gs1.org/voc/owns</seealso>
    let owns = Prefixed_Name(gs1, "owns") |> PrefixedName
    /// <summary>
    ///   <para>gs1:parentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/parentOrganization">https://ref.gs1.org/voc/parentOrganization</seealso>
    let parentOrganization = Prefixed_Name(gs1, "parentOrganization") |> PrefixedName
    /// <summary>
    ///   <para>gs1:postOfficeBoxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/postOfficeBoxNumber">https://ref.gs1.org/voc/postOfficeBoxNumber</seealso>
    let postOfficeBoxNumber = Prefixed_Name(gs1, "postOfficeBoxNumber") |> PrefixedName
    /// <summary>
    ///   <para>gs1:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/postalCode">https://ref.gs1.org/voc/postalCode</seealso>
    let postalCode = Prefixed_Name(gs1, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>gs1:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/streetAddress">https://ref.gs1.org/voc/streetAddress</seealso>
    let streetAddress = Prefixed_Name(gs1, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>gs1:subOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/subOrganization">https://ref.gs1.org/voc/subOrganization</seealso>
    let subOrganization = Prefixed_Name(gs1, "subOrganization") |> PrefixedName
    /// <summary>
    ///   <para>gs1:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://ref.gs1.org/voc/telephone">https://ref.gs1.org/voc/telephone</seealso>
    let telephone = Prefixed_Name(gs1, "telephone") |> PrefixedName

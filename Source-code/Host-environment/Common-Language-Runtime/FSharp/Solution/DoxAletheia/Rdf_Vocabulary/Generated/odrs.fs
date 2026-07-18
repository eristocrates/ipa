namespace http.schema.theodi.org.odrs.hash

open DoxAletheia.Rdf_Vocabulary

module odrs =
    let _namespace_name = "http://schema.theodi.org/odrs#"
    /// <summary>
    /// A legal document that describes the legal terms for re-use of some information. A licence might be applicable to content, data, or both. This definition of licence used here is deliberately loose, and is intended to also cover waiver documents that indicate that the owner waives all rights over some information, e.g. public domain dedications.
    /// <see href="http://schema.theodi.org/odrs#License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName

    /// <summary>
    /// A description of the rights and terms of re-use for a dataset. A rights statement will include a reference to one or more licences copyright notices, and attribution requirements. Where a Rights Statement refers to several licences the intention is that these should separately apply to the data and content associated with the dataset. An individual Rights Statement may be specific to a dataset or could be applied to a
    /// number of datasets published by the same organisation or person, where the rights associated with each dataset are identical.
    /// <see href="http://schema.theodi.org/odrs#RightsStatement"></see></summary>
    let RightsStatement =
        Namespaced_IRI.parse _namespace_name "RightsStatement" |> NamespacedName

    /// <summary>
    /// The text to use in an attribution link. This may be the name of the publisher or a reference to a community or group of contributors
    /// <see href="http://schema.theodi.org/odrs#attributionText"></see></summary>
    let attributionText =
        Namespaced_IRI.parse _namespace_name "attributionText" |> NamespacedName

    /// <summary>
    /// The link which should be used when attributing a data source. The URL could be a reference to the dataset or publisher
    /// homepage, but may also be a dedicated attribution page. This is useful when providing onward attribution to upstream sources.
    /// <see href="http://schema.theodi.org/odrs#attributionURL"></see></summary>
    let attributionURL =
        Namespaced_IRI.parse _namespace_name "attributionURL" |> NamespacedName

    /// <summary>
    /// This property is used to indicates that one license is compatible with another. A re-use that meets the requirements, permissions and prohibitions of the first license should also meet the requirements, permissions and prohibitions of the second, compatible license. The inverse is not necessarily true: the compatible license might have stricter requirements. This statement can be used as an indicator that a re-user could publish a derivative dataset under the compatible license, e.g. to help drive automated selection and guidance licenses for publishers of derived data. However it is not a substitute for properly reading and understanding the text of either license.
    /// <see href="http://schema.theodi.org/odrs#compatibleWith"></see></summary>
    let compatibleWith =
        Namespaced_IRI.parse _namespace_name "compatibleWith" |> NamespacedName

    /// <summary>
    /// The contents of a database might be covered by a separate license, e.g. a database containing copyrightable material (e.g. text, images) might have different rights for the dataset and the contents. This property can be used to refer to a license that applies to the content of the dataset. In some cases the same license can be applied to both content and data, but in others a data publisher may choose to use a separate license for content. The value of the property will be the URI of the license that is being applied to the content.
    /// <see href="http://schema.theodi.org/odrs#contentLicense"></see></summary>
    let contentLicense =
        Namespaced_IRI.parse _namespace_name "contentLicense" |> NamespacedName

    /// <summary>
    /// A reference to the organization that holds copyright over the content of the dataset
    /// <see href="http://schema.theodi.org/odrs#copyrightHolder"></see></summary>
    let copyrightHolder =
        Namespaced_IRI.parse _namespace_name "copyrightHolder" |> NamespacedName

    /// <summary>
    /// The copyright notice associated with a rights statement. A notice must typically be preserved and displayed when acknowledging the source of some data. This property is expressed as a simple literal value and so is suitable for simple copyright notices. Where a data publisher needs to reference a larger copyright statement and/or related guidance then the copyrightStatement property should be used instead.
    /// <see href="http://schema.theodi.org/odrs#copyrightNotice"></see></summary>
    let copyrightNotice =
        Namespaced_IRI.parse _namespace_name "copyrightNotice" |> NamespacedName

    /// <summary>
    /// A link to a document that includes a statement about the copyright status of the content of a dataset. The web page might include both a copyright notice for a dataset, and any relevant guidance for re-users.
    /// <see href="http://schema.theodi.org/odrs#copyrightStatement"></see></summary>
    let copyrightStatement =
        Namespaced_IRI.parse _namespace_name "copyrightStatement" |> NamespacedName

    /// <summary>
    /// The year from which copyright over the content of the dataset is asserted.
    /// <see href="http://schema.theodi.org/odrs#copyrightYear"></see></summary>
    let copyrightYear =
        Namespaced_IRI.parse _namespace_name "copyrightYear" |> NamespacedName

    /// <summary>
    /// This property is used to indicate which license covers reuse of the dataset(s) associated with this rights statement object. Typically this license will refer to a standard open license, e.g. as published by Creative Commons or Open Data Commons. The value of the property will be the URI of the license that is being applied to the data
    /// <see href="http://schema.theodi.org/odrs#dataLicense"></see></summary>
    let dataLicense =
        Namespaced_IRI.parse _namespace_name "dataLicense" |> NamespacedName

    /// <summary>
    /// A reference to the organization that holds database rights over the dataset
    /// <see href="http://schema.theodi.org/odrs#databaseRightHolder"></see></summary>
    let databaseRightHolder =
        Namespaced_IRI.parse _namespace_name "databaseRightHolder" |> NamespacedName

    /// <summary>
    /// A link to a document that includes a statement about the database rights that apply to this dataset. The web page might include both a statement on the applicable rights and any relevant guidance for re-users.
    /// <see href="http://schema.theodi.org/odrs#databaseRightStatement"></see></summary>
    let databaseRightStatement =
        Namespaced_IRI.parse _namespace_name "databaseRightStatement" |> NamespacedName

    /// <summary>
    /// The year from which a database right over the dataset is asserted.
    /// <see href="http://schema.theodi.org/odrs#databaseRightYear"></see></summary>
    let databaseRightYear =
        Namespaced_IRI.parse _namespace_name "databaseRightYear" |> NamespacedName

    /// <summary>
    /// A reference to the jurisdiction in which copyright and/or database rights have been asserts. It is recommended that this refer to the URI for a country or region.
    /// <see href="http://schema.theodi.org/odrs#jurisdiction"></see></summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    /// Link to a document that provides guidelines for re-users of data that is covered by a specific rights statement. The guidelines
    /// may include more detail on attribution guidelines, a fuller copyright statement, and general guidance on how the data might be re-used
    /// <see href="http://schema.theodi.org/odrs#reuserGuidelines"></see></summary>
    let reuserGuidelines =
        Namespaced_IRI.parse _namespace_name "reuserGuidelines" |> NamespacedName

    /// <summary>
    /// Associates a rights statement with a dataset. This property is equivalent to the Dublin Core rights property
    /// <see href="http://schema.theodi.org/odrs#rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName

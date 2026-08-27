namespace http.www.daml.org.services.owl_s._1._2.Profile.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsProfile =
    let _namespace_iri = Namespace_Iri owlsProfile |> NamespaceIRI
    /// <summary>
    ///   <para>owlsProfile:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     A profile can have only one name
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     A profile can have only one text description
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///       Definition of Profile
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#Profile">http://www.daml.org/services/owl-s/1.2/Profile.owl#Profile</seealso>
    let Profile = Prefixed_Name(owlsProfile, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:ServiceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     a ServiceCategory is restricted to refer to only one taxonomy
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     a ServiceCategory is restricted to refer to only onename
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceCategory">http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceCategory</seealso>
    let ServiceCategory = Prefixed_Name(owlsProfile, "ServiceCategory") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:ServiceParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     A ServiceParameter should have at most 1 name (more precisely only
    ///       one serviceParameterName)
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     a Parameter is restricted to refer to only one concept in some
    ///     ontology
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceParameter">http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceParameter</seealso>
    let ServiceParameter =
        Prefixed_Name(owlsProfile, "ServiceParameter") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:categoryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#categoryName">http://www.daml.org/services/owl-s/1.2/Profile.owl#categoryName</seealso>
    let categoryName = Prefixed_Name(owlsProfile, "categoryName") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#code">http://www.daml.org/services/owl-s/1.2/Profile.owl#code</seealso>
    let code = Prefixed_Name(owlsProfile, "code") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:contactInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#contactInformation">http://www.daml.org/services/owl-s/1.2/Profile.owl#contactInformation</seealso>
    let contactInformation =
        Prefixed_Name(owlsProfile, "contactInformation") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasInput">http://www.daml.org/services/owl-s/1.2/Profile.owl#hasInput</seealso>
    let hasInput = Prefixed_Name(owlsProfile, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasOutput">http://www.daml.org/services/owl-s/1.2/Profile.owl#hasOutput</seealso>
    let hasOutput = Prefixed_Name(owlsProfile, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasParameter">http://www.daml.org/services/owl-s/1.2/Profile.owl#hasParameter</seealso>
    let hasParameter = Prefixed_Name(owlsProfile, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:hasPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasPrecondition">http://www.daml.org/services/owl-s/1.2/Profile.owl#hasPrecondition</seealso>
    let hasPrecondition = Prefixed_Name(owlsProfile, "hasPrecondition") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasResult">http://www.daml.org/services/owl-s/1.2/Profile.owl#hasResult</seealso>
    let hasResult = Prefixed_Name(owlsProfile, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:has_process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#has_process">http://www.daml.org/services/owl-s/1.2/Profile.owl#has_process</seealso>
    let has_process = Prefixed_Name(owlsProfile, "has_process") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:sParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#sParameter">http://www.daml.org/services/owl-s/1.2/Profile.owl#sParameter</seealso>
    let sParameter = Prefixed_Name(owlsProfile, "sParameter") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:serviceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceCategory">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceCategory</seealso>
    let serviceCategory = Prefixed_Name(owlsProfile, "serviceCategory") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:serviceClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceClassification">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceClassification</seealso>
    let serviceClassification =
        Prefixed_Name(owlsProfile, "serviceClassification") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:serviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceName">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceName</seealso>
    let serviceName = Prefixed_Name(owlsProfile, "serviceName") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:serviceParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameter">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameter</seealso>
    let serviceParameter =
        Prefixed_Name(owlsProfile, "serviceParameter") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:serviceParameterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameterName">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameterName</seealso>
    let serviceParameterName =
        Prefixed_Name(owlsProfile, "serviceParameterName") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfile:serviceProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceProduct">http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceProduct</seealso>
    let serviceProduct = Prefixed_Name(owlsProfile, "serviceProduct") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#taxonomy">http://www.daml.org/services/owl-s/1.2/Profile.owl#taxonomy</seealso>
    let taxonomy = Prefixed_Name(owlsProfile, "taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:textDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#textDescription">http://www.daml.org/services/owl-s/1.2/Profile.owl#textDescription</seealso>
    let textDescription = Prefixed_Name(owlsProfile, "textDescription") |> PrefixedName
    /// <summary>
    ///   <para>owlsProfile:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Profile.owl#value">http://www.daml.org/services/owl-s/1.2/Profile.owl#value</seealso>
    let value = Prefixed_Name(owlsProfile, "value") |> PrefixedName

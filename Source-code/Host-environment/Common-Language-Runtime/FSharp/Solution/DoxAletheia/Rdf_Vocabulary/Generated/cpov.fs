namespace http.data.europa.eu.m8g.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cpov =
    let _namespace_iri = Namespace_Iri cpov |> NamespaceIRI
    /// <summary>
    ///   <para>cpov:PublicOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Organization that is defined as being part of the public sector by a legal framework at any level.</para>
    /// labels<para>Public Organisation</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/PublicOrganisation">http://data.europa.eu/m8g/PublicOrganisation</seealso>
    let PublicOrganisation = Prefixed_Name(cpov, "PublicOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>cpov:contactPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A web page that could be used to reach out the Contact Point.</para>
    /// labels<para>contact page</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/contactPage">http://data.europa.eu/m8g/contactPage</seealso>
    let contactPage = Prefixed_Name(cpov, "contactPage") |> PrefixedName
    /// <summary>
    ///   <para>cpov:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A telephone number through which the Contact Point can be contacted.</para>
    /// labels<para>has telephone</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/telephone">http://data.europa.eu/m8g/telephone</seealso>
    let telephone = Prefixed_Name(cpov, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ImageObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A logo to describe / represent an entity.</para>
    /// labels<para>Image Object</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ImageObject">http://data.europa.eu/m8g/ImageObject</seealso>
    let ImageObject = Prefixed_Name(cpov, "ImageObject") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information (e.g. e-mail address, telephone number) of a person or department through which the user can get in touch with.</para>
    /// labels<para>Contact Point</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ContactPoint">http://data.europa.eu/m8g/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(cpov, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ReferenceFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Legislation or official policy from which Requirements are derived.</para>
    /// labels<para>Reference Framework</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ReferenceFramework">http://data.europa.eu/m8g/ReferenceFramework</seealso>
    let ReferenceFramework = Prefixed_Name(cpov, "ReferenceFramework") |> PrefixedName
    /// <summary>
    ///   <para>cpov:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The recurrence of an instant or period.</para>
    /// labels<para>frequency</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/frequency">http://data.europa.eu/m8g/frequency</seealso>
    let frequency = Prefixed_Name(cpov, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>cpov:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An electronic address through which the Contact Point can be contacted.</para>
    /// labels<para>has email</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/email">http://data.europa.eu/m8g/email</seealso>
    let email = Prefixed_Name(cpov, "email") |> PrefixedName

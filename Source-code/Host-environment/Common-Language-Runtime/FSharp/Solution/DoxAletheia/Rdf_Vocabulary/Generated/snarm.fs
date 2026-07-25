namespace http.rdf.myexperiment.org.ontologies.snarm.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module snarm =
    let _namespace_iri = Namespace_Iri snarm |> NamespaceIRI
    /// <summary>
    ///   <para>snarm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para> This ontology is designed for representing access rights within a simple network of associated users/groups.</para>
    /// labels<para>SNARM Ontology v1.1</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/">http://rdf.myexperiment.org/ontologies/snarm/</seealso>
    let _prefix_iri = Prefixed_Name(snarm, "") |> PrefixedName
    /// <summary>
    ///   <para>snarm:Accesser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Accesser that is getting access</para>
    /// labels<para>Accesser</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/Accesser">http://rdf.myexperiment.org/ontologies/snarm/Accesser</seealso>
    let Accesser = Prefixed_Name(snarm, "Accesser") |> PrefixedName
    /// <summary>
    ///   <para>snarm:Access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Unrestricted Access to an AccessType</para>
    /// labels<para>Access</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/Access">http://rdf.myexperiment.org/ontologies/snarm/Access</seealso>
    let Access = Prefixed_Name(snarm, "Access") |> PrefixedName
    /// <summary>
    ///   <para>snarm:RestrictedAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The restricted Access to an AccessType</para>
    /// labels<para>RestrictedAccess</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/RestrictedAccess">http://rdf.myexperiment.org/ontologies/snarm/RestrictedAccess</seealso>
    let RestrictedAccess = Prefixed_Name(snarm, "RestrictedAccess") |> PrefixedName
    /// <summary>
    ///   <para>snarm:has-access-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The AccessType an Access provides</para>
    /// labels<para>has-access-type</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/has-access-type">http://rdf.myexperiment.org/ontologies/snarm/has-access-type</seealso>
    let has_access_type = Prefixed_Name(snarm, "has-access-type") |> PrefixedName
    /// <summary>
    ///   <para>snarm:AccessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The AccessType that is being giving, e.g. view, edit, download, etc.</para>
    /// labels<para>AccessType</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/AccessType">http://rdf.myexperiment.org/ontologies/snarm/AccessType</seealso>
    let AccessType = Prefixed_Name(snarm, "AccessType") |> PrefixedName
    /// <summary>
    ///   <para>snarm:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Policy for the access rights to an object for users in the social network</para>
    /// labels<para>Policy</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/Policy">http://rdf.myexperiment.org/ontologies/snarm/Policy</seealso>
    let Policy = Prefixed_Name(snarm, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>snarm:has-accesser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An Accesser that a Mode provides access to</para>
    /// labels<para>has-accesser</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/has-accesser">http://rdf.myexperiment.org/ontologies/snarm/has-accesser</seealso>
    let has_accesser = Prefixed_Name(snarm, "has-accesser") |> PrefixedName
    /// <summary>
    ///   <para>snarm:has-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Access that a Policy provides</para>
    /// labels<para>has-access</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/snarm/has-access">http://rdf.myexperiment.org/ontologies/snarm/has-access</seealso>
    let has_access = Prefixed_Name(snarm, "has-access") |> PrefixedName

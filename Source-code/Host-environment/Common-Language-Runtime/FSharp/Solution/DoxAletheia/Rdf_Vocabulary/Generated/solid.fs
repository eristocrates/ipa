namespace http.www.w3.org.ns.solid.terms.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module solid =
    let _namespace_iri = Namespace_Iri solid |> NamespaceIRI
    /// <summary>
    ///   <para>solid:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Solid terms"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms">http://www.w3.org/ns/solid/terms</seealso>
    let _prefix_iri = Prefixed_Name(solid, "") |> PrefixedName
    /// <summary>
    ///   <para>solid:#Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Solid account."</para>
    /// labels<para>"Account"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#Account">http://www.w3.org/ns/solid/terms#Account</seealso>
    let ``_#Account`` = Prefixed_Name(solid, "#Account") |> PrefixedName
    /// <summary>
    ///   <para>solid:#Inbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A resource containing notifications."</para>
    /// labels<para>"Inbox"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#Inbox">http://www.w3.org/ns/solid/terms#Inbox</seealso>
    let ``_#Inbox`` = Prefixed_Name(solid, "#Inbox") |> PrefixedName
    /// <summary>
    ///   <para>solid:#ListedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Listed Type Index is a registry of resources that are publicly discoverable by outside users and applications."</para>
    /// labels<para>"Listed Type Index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#ListedDocument">http://www.w3.org/ns/solid/terms#ListedDocument</seealso>
    let ``_#ListedDocument`` = Prefixed_Name(solid, "#ListedDocument") |> PrefixedName
    /// <summary>
    ///   <para>solid:#Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A notification resource."</para>
    /// labels<para>"Notification"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#Notification">http://www.w3.org/ns/solid/terms#Notification</seealso>
    let ``_#Notification`` = Prefixed_Name(solid, "#Notification") |> PrefixedName
    /// <summary>
    ///   <para>solid:#Patch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A patch expresses conditional modifications to a resource that has an RDF-based representation."</para>
    /// labels<para>"Patch"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#Patch">http://www.w3.org/ns/solid/terms#Patch</seealso>
    let ``_#Patch`` = Prefixed_Name(solid, "#Patch") |> PrefixedName
    /// <summary>
    ///   <para>solid:#Timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A resource containing time ordered items and sub-containers.  Sub-containers may be desirable in file based systems to split the timeline into logical components e.g. /yyyy-mm-dd/ as used in ISO 8061."</para>
    /// labels<para>"Timeline"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#Timeline">http://www.w3.org/ns/solid/terms#Timeline</seealso>
    let ``_#Timeline`` = Prefixed_Name(solid, "#Timeline") |> PrefixedName
    /// <summary>
    ///   <para>solid:#TypeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A index of type registries for resources. Applications can register the RDF type they use and list them in the index resource."</para>
    /// labels<para>"Type index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#TypeIndex">http://www.w3.org/ns/solid/terms#TypeIndex</seealso>
    let ``_#TypeIndex`` = Prefixed_Name(solid, "#TypeIndex") |> PrefixedName

    /// <summary>
    ///   <para>solid:#TypeRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The registered types that map a RDF classes/types to their locations using either `instance` or `instanceContainer` property."</para>
    /// labels<para>"Type Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#TypeRegistration">http://www.w3.org/ns/solid/terms#TypeRegistration</seealso>
    let ``_#TypeRegistration`` =
        Prefixed_Name(solid, "#TypeRegistration") |> PrefixedName

    /// <summary>
    ///   <para>solid:#UnlistedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Unlisted Type Index is a registry of resources that are private to the user and their apps, for types that are not publicly discoverable."</para>
    /// labels<para>"Unlisted Type Index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#UnlistedDocument">http://www.w3.org/ns/solid/terms#UnlistedDocument</seealso>
    let ``_#UnlistedDocument`` =
        Prefixed_Name(solid, "#UnlistedDocument") |> PrefixedName

    /// <summary>
    ///   <para>solid:#account</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A solid account belonging to an Agent."</para>
    /// labels<para>"account"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#account">http://www.w3.org/ns/solid/terms#account</seealso>
    let ``_#account`` = Prefixed_Name(solid, "#account") |> PrefixedName
    /// <summary>
    ///   <para>solid:#deletes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The triple patterns this patch removes from the document."</para>
    /// labels<para>"deletes"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#deletes">http://www.w3.org/ns/solid/terms#deletes</seealso>
    let ``_#deletes`` = Prefixed_Name(solid, "#deletes") |> PrefixedName
    /// <summary>
    ///   <para>solid:#forClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A class that is used to map an listed or unlisted type index."</para>
    /// labels<para>"registry class"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#forClass">http://www.w3.org/ns/solid/terms#forClass</seealso>
    let ``_#forClass`` = Prefixed_Name(solid, "#forClass") |> PrefixedName
    /// <summary>
    ///   <para>solid:#inbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Deprecated pointer to a Linked Data Notifications inbox; please use http://www.w3.org/ns/ldp#inbox instead."</para>
    /// labels<para>"inbox (deprecated)"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#inbox">http://www.w3.org/ns/solid/terms#inbox</seealso>
    let ``_#inbox`` = Prefixed_Name(solid, "#inbox") |> PrefixedName
    /// <summary>
    ///   <para>solid:#inserts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The triple patterns this patch adds to the document."</para>
    /// labels<para>"inserts"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#inserts">http://www.w3.org/ns/solid/terms#inserts</seealso>
    let ``_#inserts`` = Prefixed_Name(solid, "#inserts") |> PrefixedName
    /// <summary>
    ///   <para>solid:#instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Maps a type to an individual resource, typically an index or a directory listing resource."</para>
    /// labels<para>"instance"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#instance">http://www.w3.org/ns/solid/terms#instance</seealso>
    let ``_#instance`` = Prefixed_Name(solid, "#instance") |> PrefixedName

    /// <summary>
    ///   <para>solid:#instanceContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Maps a type to a container which the client would have to list to get the instances of that type."</para>
    /// labels<para>"instance container"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#instanceContainer">http://www.w3.org/ns/solid/terms#instanceContainer</seealso>
    let ``_#instanceContainer`` =
        Prefixed_Name(solid, "#instanceContainer") |> PrefixedName

    /// <summary>
    ///   <para>solid:#loginEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The login URI of a given server."</para>
    /// labels<para>"loginEndpoint"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#loginEndpoint">http://www.w3.org/ns/solid/terms#loginEndpoint</seealso>
    let ``_#loginEndpoint`` = Prefixed_Name(solid, "#loginEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>solid:#logoutEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The logout URI of a given server."</para>
    /// labels<para>"logoutEndpoint"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#logoutEndpoint">http://www.w3.org/ns/solid/terms#logoutEndpoint</seealso>
    let ``_#logoutEndpoint`` = Prefixed_Name(solid, "#logoutEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>solid:#notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Notification resource for an inbox."</para>
    /// labels<para>"notification"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#notification">http://www.w3.org/ns/solid/terms#notification</seealso>
    let ``_#notification`` = Prefixed_Name(solid, "#notification") |> PrefixedName
    /// <summary>
    ///   <para>solid:#oidcIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The preferred OpenID Connect issuer URI for a given Web ID."</para>
    /// labels<para>"oidcIssuer"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#oidcIssuer">http://www.w3.org/ns/solid/terms#oidcIssuer</seealso>
    let ``_#oidcIssuer`` = Prefixed_Name(solid, "#oidcIssuer") |> PrefixedName
    /// <summary>
    ///   <para>solid:#patches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The document to which this patch applies."</para>
    /// labels<para>"patches"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#patches">http://www.w3.org/ns/solid/terms#patches</seealso>
    let ``_#patches`` = Prefixed_Name(solid, "#patches") |> PrefixedName

    /// <summary>
    ///   <para>solid:#privateTypeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to an unlisted type index resource."</para>
    /// labels<para>"private type index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#privateTypeIndex">http://www.w3.org/ns/solid/terms#privateTypeIndex</seealso>
    let ``_#privateTypeIndex`` =
        Prefixed_Name(solid, "#privateTypeIndex") |> PrefixedName

    /// <summary>
    ///   <para>solid:#publicTypeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a listed type index resource."</para>
    /// labels<para>"public type index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#publicTypeIndex">http://www.w3.org/ns/solid/terms#publicTypeIndex</seealso>
    let ``_#publicTypeIndex`` = Prefixed_Name(solid, "#publicTypeIndex") |> PrefixedName
    /// <summary>
    ///   <para>solid:#read</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates if a message has been read or not. This property should have a boolean datatype."</para>
    /// labels<para>"read"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#read">http://www.w3.org/ns/solid/terms#read</seealso>
    let ``_#read`` = Prefixed_Name(solid, "#read") |> PrefixedName
    /// <summary>
    ///   <para>solid:#storageQuota</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The quota of non-volatile memory that is available for the account (in bytes)"</para>
    /// labels<para>"Non-volatile memory quota"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#storageQuota">http://www.w3.org/ns/solid/terms#storageQuota</seealso>
    let ``_#storageQuota`` = Prefixed_Name(solid, "#storageQuota") |> PrefixedName
    /// <summary>
    ///   <para>solid:#storageUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The amount of non-volatile memory that the account have used (in bytes)"</para>
    /// labels<para>"Non-volatile memory usage"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#storageUsage">http://www.w3.org/ns/solid/terms#storageUsage</seealso>
    let ``_#storageUsage`` = Prefixed_Name(solid, "#storageUsage") |> PrefixedName
    /// <summary>
    ///   <para>solid:#timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Timeline for a given resource."</para>
    /// labels<para>"timeline"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#timeline">http://www.w3.org/ns/solid/terms#timeline</seealso>
    let ``_#timeline`` = Prefixed_Name(solid, "#timeline") |> PrefixedName
    /// <summary>
    ///   <para>solid:#typeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a TypeIndex resource."</para>
    /// labels<para>"type index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#typeIndex">http://www.w3.org/ns/solid/terms#typeIndex</seealso>
    let ``_#typeIndex`` = Prefixed_Name(solid, "#typeIndex") |> PrefixedName
    /// <summary>
    ///   <para>solid:#where</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The conditions the document and the inserted and deleted triple patterns need to satisfy in order for the patch to be applied."</para>
    /// labels<para>"where"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/terms#where">http://www.w3.org/ns/solid/terms#where</seealso>
    let ``_#where`` = Prefixed_Name(solid, "#where") |> PrefixedName

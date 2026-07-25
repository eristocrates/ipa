namespace http.data.press.net.ontology.stuff.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pns =
    let _namespace_iri = Namespace_Iri pns |> NamespaceIRI
    /// <summary>
    ///   <para>pns:Stuff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic Stuff Class  - a base class for all domain stuff</para>
    /// labels<para>Generic Stuff Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Stuff">http://data.press.net/ontology/stuff/Stuff</seealso>
    let Stuff = Prefixed_Name(pns, "Stuff") |> PrefixedName
    /// <summary>
    ///   <para>pns:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property of a Person. A person's date of birth</para>
    /// labels<para>A person's date of birth</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/dateOfBirth">http://data.press.net/ontology/stuff/dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(pns, "dateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>pns:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property of a Person. A person's date of death</para>
    /// labels<para>A person's date of death</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/dateOfDeath">http://data.press.net/ontology/stuff/dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(pns, "dateOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>pns:hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates images with domain entities, e.g. official photograph, corporate logo</para>
    /// labels<para>Property that associates images with domain entities.</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/hasImage">http://data.press.net/ontology/stuff/hasImage</seealso>
    let hasImage = Prefixed_Name(pns, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>pns:Intangible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A base class for all intangible stuff (eg love, conservatism, fashion)</para>
    /// labels<para>A base class for Intangible Stuff</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Intangible">http://data.press.net/ontology/stuff/Intangible</seealso>
    let Intangible = Prefixed_Name(pns, "Intangible") |> PrefixedName
    /// <summary>
    ///   <para>pns:Tangible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A base class for all tangible stuff (eg people, places, physical things)</para>
    /// labels<para>A base Class for Tangible Stuff</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Tangible">http://data.press.net/ontology/stuff/Tangible</seealso>
    let Tangible = Prefixed_Name(pns, "Tangible") |> PrefixedName
    /// <summary>
    ///   <para>pns:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates an alias of a Stuff instance. For example 'Television' might have an alias of 'TV'.</para>
    /// labels<para>An alias label of a Stuff instance</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/alias">http://data.press.net/ontology/stuff/alias</seealso>
    let alias = Prefixed_Name(pns, "alias") |> PrefixedName
    /// <summary>
    ///   <para>pns:hasAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates assets directly with domain entities, e.g. official biography, corporate logo</para>
    /// labels<para>Property that associates assets directly with domain entities.</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/hasAsset">http://data.press.net/ontology/stuff/hasAsset</seealso>
    let hasAsset = Prefixed_Name(pns, "hasAsset") |> PrefixedName
    /// <summary>
    ///   <para>pns:parentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Property of a Location. References the parent location of this location</para>
    /// labels<para>A parent location</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/parentLocation">http://data.press.net/ontology/stuff/parentLocation</seealso>
    let parentLocation = Prefixed_Name(pns, "parentLocation") |> PrefixedName
    /// <summary>
    ///   <para>pns:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates the definitive label of a Stuff instance. This might be the full name of a Person, Organization or something Intangible</para>
    /// labels<para>The definitive label of a Stuff instance</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/label">http://data.press.net/ontology/stuff/label</seealso>
    let label = Prefixed_Name(pns, "label") |> PrefixedName
    /// <summary>
    ///   <para>pns:longName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates the long name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Manchester United F.C.'</para>
    /// labels<para>A long name of a Person or Organization</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/longName">http://data.press.net/ontology/stuff/longName</seealso>
    let longName = Prefixed_Name(pns, "longName") |> PrefixedName
    /// <summary>
    ///   <para>pns:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates the definitive full name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label</para>
    /// labels<para>The definitive name of a Person or Organization</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/name">http://data.press.net/ontology/stuff/name</seealso>
    let name = Prefixed_Name(pns, "name") |> PrefixedName

    /// <summary>
    ///   <para>pns:notablyAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that notably associates stuff together, for example Karl Lagerfeld is notably associated with Fashion</para>
    /// labels<para>Property that notably associates stuff together</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/notablyAssociatedWith">http://data.press.net/ontology/stuff/notablyAssociatedWith</seealso>
    let notablyAssociatedWith =
        Prefixed_Name(pns, "notablyAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>pns:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property of a Person. A person's place of birth</para>
    /// labels<para>A person's place of birth</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/placeOfBirth">http://data.press.net/ontology/stuff/placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(pns, "placeOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>pns:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates the short name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Man Utd'</para>
    /// labels<para>A short name of a Person or Organization</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/shortName">http://data.press.net/ontology/stuff/shortName</seealso>
    let shortName = Prefixed_Name(pns, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>pns:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Stuff Ontology models real world entities. There are two kinds of stuff: tangibles and intangibles. Tangible stuff includes persons, locations and organizations. Intangibles are abstract concepts such as smoking, feminism or love.</para>
    /// </remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/">http://data.press.net/ontology/stuff/</seealso>
    let _prefix_iri = Prefixed_Name(pns, "") |> PrefixedName
    /// <summary>
    ///   <para>pns:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Location - a base class for Locations. Also a subclass of geo:SpatialThing</para>
    /// labels<para>A Location - a base class for Locations</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Location">http://data.press.net/ontology/stuff/Location</seealso>
    let Location = Prefixed_Name(pns, "Location") |> PrefixedName
    /// <summary>
    ///   <para>pns:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Organization - a base class for instances of organizations. Also a subclass of foaf:Organization</para>
    /// labels<para>An Organization - a base class for instances of organizations</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Organization">http://data.press.net/ontology/stuff/Organization</seealso>
    let Organization = Prefixed_Name(pns, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>pns:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Person - a base class for people instances. Also a subclass of foaf:Person</para>
    /// labels<para>A Person - a base class for people instances.</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/Person">http://data.press.net/ontology/stuff/Person</seealso>
    let Person = Prefixed_Name(pns, "Person") |> PrefixedName
    /// <summary>
    ///   <para>pns:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String property that indicates the definitive description of a Stuff instance.</para>
    /// labels<para>The definitive description of a Stuff instance</para></remarks>
    /// <seealso href="http://data.press.net/ontology/stuff/comment">http://data.press.net/ontology/stuff/comment</seealso>
    let comment = Prefixed_Name(pns, "comment") |> PrefixedName

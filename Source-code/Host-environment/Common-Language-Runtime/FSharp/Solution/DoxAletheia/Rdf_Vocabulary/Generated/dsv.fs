namespace https.w3id.org.dsv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dsv =
    let _namespace_iri = Namespace_Iri dsv |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:dsv#</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:Profile</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"See also DSV Default Application Profile for a more complete information on how to use this vocabulary."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsv#">https://w3id.org/dsv#</seealso>
    let _prefix_iri = Prefixed_Name(dsv, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#ApplicationProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An Application Profile identifies classes and properties from vocabularies, and class profiles and property profiles from Application profiles that are re-used in a certain usage context. It also allows specification editors to further adjust the description of re-used classes and properties for that usage context without the need to explicitly create subclasses and subproperties."</para>
    ///   <para>"Konceptuální model obsahující profily tříd a vlastností různých slovníků."</para>
    /// labels<para>"Application Profile"</para><para>"Konceptuální model"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#ApplicationProfile">https://w3id.org/dsv#ApplicationProfile</seealso>
    let ApplicationProfile = Prefixed_Name(dsv, "ApplicationProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#ApplicationProfileSpecificationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An Application Profile Specification Document contains human-readable version of an Application Profile."</para>
    /// labels<para>"Application Profile Specification Document"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#ApplicationProfileSpecificationDocument">https://w3id.org/dsv#ApplicationProfileSpecificationDocument</seealso>
    let ApplicationProfileSpecificationDocument =
        Prefixed_Name(dsv, "ApplicationProfileSpecificationDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#ClassProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Profile of a class. Allows specification editors to specify profile specific names, definitions and usage notes."</para>
    /// labels<para>"Profil třídy"</para><para>"Class Profile"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#ClassProfile">https://w3id.org/dsv#ClassProfile</seealso>
    let ClassProfile = Prefixed_Name(dsv, "ClassProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#DatatypePropertyProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Datatype Property Profile"</para><para>"Profile atributu"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#DatatypePropertyProfile">https://w3id.org/dsv#DatatypePropertyProfile</seealso>
    let DatatypePropertyProfile =
        Prefixed_Name(dsv, "DatatypePropertyProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#InvalidTermProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Invalid Term Profile is a profile, which breaks profile compliance rules. This may be for a good reason such as temporary, to be propagated upstream, inconsistency."</para>
    ///   <para>"Neplatný profil je profil, který porušuje pravidla pro správné profilování. To může být z dobrého důvodu, jako je dočasná nekonzistence, která se má teprve projevit na profilované entitě."</para>
    /// labels<para>"Invalid Term Profile"</para><para>"Nevalidní profil"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#InvalidTermProfile">https://w3id.org/dsv#InvalidTermProfile</seealso>
    let InvalidTermProfile = Prefixed_Name(dsv, "InvalidTermProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#ObjectPropertyProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object Property Profile"</para><para>"Profil objektové vlastnosti"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#ObjectPropertyProfile">https://w3id.org/dsv#ObjectPropertyProfile</seealso>
    let ObjectPropertyProfile =
        Prefixed_Name(dsv, "ObjectPropertyProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#PropertyProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Profile of a property allows specification editors to specify profile specific name, definition, usage note, domain, range and cardinality."</para>
    /// labels<para>"Profil vlastnosti"</para><para>"Property Profile"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#PropertyProfile">https://w3id.org/dsv#PropertyProfile</seealso>
    let PropertyProfile = Prefixed_Name(dsv, "PropertyProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#PropertyValueReuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies, which values of which properties of which resources are reused for the current Profile.
    /// E.g. reuse of profile name, reuse of class name, reuse of profile definition, reuse of profile usage note, etc."</para>
    /// labels<para>"Property Value Reuse"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#PropertyValueReuse">https://w3id.org/dsv#PropertyValueReuse</seealso>
    let PropertyValueReuse = Prefixed_Name(dsv, "PropertyValueReuse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#TermProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Profil entity. Umožňuje blíže specifikovat některé její vlastnost v kontextu aplikačního profilu."</para>
    ///   <para>"Term profile. Allows profile editors to specify context dependent information such as label, definition, usage note, cardinalities, etc. for Class profiles and Property profiles."</para>
    /// labels<para>"Profil"</para><para>"Term Profile"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#TermProfile">https://w3id.org/dsv#TermProfile</seealso>
    let TermProfile = Prefixed_Name(dsv, "TermProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#VocabularySpecificationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Vocabulary Specification Document is a human-readable representation of a Vocabulary."</para>
    /// labels<para>"Vocabulary Specification Document"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#VocabularySpecificationDocument">https://w3id.org/dsv#VocabularySpecificationDocument</seealso>
    let VocabularySpecificationDocument =
        Prefixed_Name(dsv, "VocabularySpecificationDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"kardinalita"</para><para>"cardinality"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#cardinality">https://w3id.org/dsv#cardinality</seealso>
    let cardinality = Prefixed_Name(dsv, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The profiled class."</para>
    /// labels<para>"profiled class"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#class">https://w3id.org/dsv#class</seealso>
    let class_ = Prefixed_Name(dsv, "class") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#classRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Class role, e.g. Mandatory, Supportive, etc."</para>
    /// labels<para>"class role"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#classRole">https://w3id.org/dsv#classRole</seealso>
    let classRole = Prefixed_Name(dsv, "classRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"datatype"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#datatype">https://w3id.org/dsv#datatype</seealso>
    let datatype = Prefixed_Name(dsv, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Class profile, which is the domain of the property profile."</para>
    /// labels<para>"domain"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#domain">https://w3id.org/dsv#domain</seealso>
    let domain = Prefixed_Name(dsv, "domain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#externalDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link to an external documentation of this resource. Profiles of this resource should preferably link to this URL for documentation."</para>
    /// labels<para>"external documentation"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#externalDocumentation">https://w3id.org/dsv#externalDocumentation</seealso>
    let externalDocumentation =
        Prefixed_Name(dsv, "externalDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dsv#profileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a parent profile of the current profile."</para>
    /// labels<para>"profile of"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#profileOf">https://w3id.org/dsv#profileOf</seealso>
    let profileOf = Prefixed_Name(dsv, "profileOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property profiled by the property profile."</para>
    /// labels<para>"profiled property"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#property">https://w3id.org/dsv#property</seealso>
    let property = Prefixed_Name(dsv, "property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#range</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Class profile, which is the range of the object property profile."</para>
    /// labels<para>"range"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#range">https://w3id.org/dsv#range</seealso>
    let range = Prefixed_Name(dsv, "range") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#requirementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Requirement level of the property, typically mandatory, recommended or optional."</para>
    /// labels<para>"requirement level"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#requirementLevel">https://w3id.org/dsv#requirementLevel</seealso>
    let requirementLevel = Prefixed_Name(dsv, "requirementLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#reusedFromResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The Resource on which there is a property with a value for reuse."</para>
    /// labels<para>"reused from resource"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#reusedFromResource">https://w3id.org/dsv#reusedFromResource</seealso>
    let reusedFromResource = Prefixed_Name(dsv, "reusedFromResource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#reusedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reused property"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#reusedProperty">https://w3id.org/dsv#reusedProperty</seealso>
    let reusedProperty = Prefixed_Name(dsv, "reusedProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#reusesPropertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Points to definitions of Property value reuse for this Profile."</para>
    /// labels<para>"reuses property value"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#reusesPropertyValue">https://w3id.org/dsv#reusesPropertyValue</seealso>
    let reusesPropertyValue = Prefixed_Name(dsv, "reusesPropertyValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsv#specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a profile specialized by this profile."</para>
    /// labels<para>"specializes"</para></remarks>
    /// <seealso href="https://w3id.org/dsv#specializes">https://w3id.org/dsv#specializes</seealso>
    let specializes = Prefixed_Name(dsv, "specializes") |> PrefixedName

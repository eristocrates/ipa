namespace http.moat_project.org.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module moat =
    let _namespace_iri = Namespace_Iri moat |> NamespaceIRI
    /// <summary>
    ///   <para>moat:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:Thing</para>
    ///   <para>An ontology that let users define relationships between Tag objects and URIs of Semantic Web resources.</para>
    /// labels<para>An ontology for the MOAT project.</para></remarks>
    /// <seealso href="http://moat-project.org/ns#">http://moat-project.org/ns#</seealso>
    let _prefix_iri = Prefixed_Name(moat, "") |> PrefixedName
    /// <summary>
    ///   <para>moat:TagType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://moat-project.org/ns#TagType">http://moat-project.org/ns#TagType</seealso>
    let TagType = Prefixed_Name(moat, "TagType") |> PrefixedName
    /// <summary>
    ///   <para>moat:Meaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reified object to define a potential meaning for a Tag. The meaning is a unique and explicitely defined Semantic Web resource and is related to the agent that defined it with foaf:maker</para>
    /// labels<para>Tag Meaning</para></remarks>
    /// <seealso href="http://moat-project.org/ns#Meaning">http://moat-project.org/ns#Meaning</seealso>
    let Meaning = Prefixed_Name(moat, "Meaning") |> PrefixedName
    /// <summary>
    ///   <para>moat:AutomatedTagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>moat:TagType</para>
    /// </remarks>
    /// <seealso href="http://moat-project.org/ns#AutomatedTagging">http://moat-project.org/ns#AutomatedTagging</seealso>
    let AutomatedTagging = Prefixed_Name(moat, "AutomatedTagging") |> PrefixedName
    /// <summary>
    ///   <para>moat:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Tag URI, that provides an unique identifier for a label attached to a resource</para>
    /// labels<para>Tag URI</para></remarks>
    /// <seealso href="http://moat-project.org/ns#Tag">http://moat-project.org/ns#Tag</seealso>
    let Tag = Prefixed_Name(moat, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>moat:meaningURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link between a reified Meaning object and the URI that defines a meaning</para>
    /// labels<para>tag meaning URI - global context</para></remarks>
    /// <seealso href="http://moat-project.org/ns#meaningURI">http://moat-project.org/ns#meaningURI</seealso>
    let meaningURI = Prefixed_Name(moat, "meaningURI") |> PrefixedName
    /// <summary>
    ///   <para>moat:hasMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link between a Tag and a Meaning object in a global context</para>
    /// labels<para>tag meaning object - global context</para></remarks>
    /// <seealso href="http://moat-project.org/ns#hasMeaning">http://moat-project.org/ns#hasMeaning</seealso>
    let hasMeaning = Prefixed_Name(moat, "hasMeaning") |> PrefixedName
    /// <summary>
    ///   <para>moat:localMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI used as a meaning for a local meaning of a Tag with MOAT</para>
    /// labels<para>local Meaning</para></remarks>
    /// <seealso href="http://moat-project.org/ns#localMeaning">http://moat-project.org/ns#localMeaning</seealso>
    let localMeaning = Prefixed_Name(moat, "localMeaning") |> PrefixedName
    /// <summary>
    ///   <para>moat:ValidatedTagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>moat:TagType</para>
    /// </remarks>
    /// <seealso href="http://moat-project.org/ns#ValidatedTagging">http://moat-project.org/ns#ValidatedTagging</seealso>
    let ValidatedTagging = Prefixed_Name(moat, "ValidatedTagging") |> PrefixedName
    /// <summary>
    ///   <para>moat:tagType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the tagging, i.e. automatic or has been validated</para>
    /// labels<para>tagging type</para></remarks>
    /// <seealso href="http://moat-project.org/ns#tagType">http://moat-project.org/ns#tagType</seealso>
    let tagType = Prefixed_Name(moat, "tagType") |> PrefixedName
    /// <summary>
    ///   <para>moat:taggedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI ised to 'tag' an item with MOAT</para>
    /// labels<para>tagged with</para></remarks>
    /// <seealso href="http://moat-project.org/ns#taggedWith">http://moat-project.org/ns#taggedWith</seealso>
    let taggedWith = Prefixed_Name(moat, "taggedWith") |> PrefixedName
    /// <summary>
    ///   <para>moat:tagMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link between a Tagging and a meaning (URI) of a tag in a given context (i.e. blog post)</para>
    /// labels<para>tag meaning - tagging context</para></remarks>
    /// <seealso href="http://moat-project.org/ns#tagMeaning">http://moat-project.org/ns#tagMeaning</seealso>
    let tagMeaning = Prefixed_Name(moat, "tagMeaning") |> PrefixedName

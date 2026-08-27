namespace http.www.w3.org._2004._09.fresnel.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fresnel =
    let _namespace_iri = Namespace_Iri fresnel |> NamespaceIRI
    /// <summary>
    ///   <para>fresnel:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#">http://www.w3.org/2004/09/fresnel#</seealso>
    let _prefix_iri = Prefixed_Name(fresnel, "") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:ClassList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a convenience class for the OWL specification of Fresnel (an rdf:List of resource selectors only)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#ClassList">http://www.w3.org/2004/09/fresnel#ClassList</seealso>
    let ClassList = Prefixed_Name(fresnel, "ClassList") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:ConvenienceToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract class for expressing shorthands a browser must understand how to expand."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convenience Token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#ConvenienceToken">http://www.w3.org/2004/09/fresnel#ConvenienceToken</seealso>
    let ConvenienceToken = Prefixed_Name(fresnel, "ConvenienceToken") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:ConvienceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract class of pseudo properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convenience Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#ConvienceProperty">http://www.w3.org/2004/09/fresnel#ConvienceProperty</seealso>
    let ConvienceProperty = Prefixed_Name(fresnel, "ConvienceProperty") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Fresnel format class for displaying RDF data; the domain property can be only one of :formatDomain, :classFormatDomain, :instanceFormatDomain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Format Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#Format">http://www.w3.org/2004/09/fresnel#Format</seealso>
    let Format = Prefixed_Name(fresnel, "Format") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:FormatDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of fresnel:Format content separators; super class, not to be used directly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Format Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#FormatDescription">http://www.w3.org/2004/09/fresnel#FormatDescription</seealso>
    let FormatDescription = Prefixed_Name(fresnel, "FormatDescription") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:FormatDescriptionNoSubstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of fresnel:Format content separators only; contentNoValue will not be recognized in conjunction with this class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Format Description No Substitution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#FormatDescriptionNoSubstitution">http://www.w3.org/2004/09/fresnel#FormatDescriptionNoSubstitution</seealso>
    let FormatDescriptionNoSubstitution =
        Prefixed_Name(fresnel, "FormatDescriptionNoSubstitution") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:FormatDescriptionSubstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of fresnel:Format content separators and content replacement if values are missing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Format Description Substitution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#FormatDescriptionSubstitution">http://www.w3.org/2004/09/fresnel#FormatDescriptionSubstitution</seealso>
    let FormatDescriptionSubstitution =
        Prefixed_Name(fresnel, "FormatDescriptionSubstitution") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Fresnel Group is used for grouping formats and lenses together."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#Group">http://www.w3.org/2004/09/fresnel#Group</seealso>
    let Group = Prefixed_Name(fresnel, "Group") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:HidePropertyList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a convenience class for the OWL specification of Fresnel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hide Property List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#HidePropertyList">http://www.w3.org/2004/09/fresnel#HidePropertyList</seealso>
    let HidePropertyList = Prefixed_Name(fresnel, "HidePropertyList") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:LabellingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract superclass of all labelling formats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Labelling Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#LabellingFormat">http://www.w3.org/2004/09/fresnel#LabellingFormat</seealso>
    let LabellingFormat = Prefixed_Name(fresnel, "LabellingFormat") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:Lens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lens for viewing RDF data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#Lens">http://www.w3.org/2004/09/fresnel#Lens</seealso>
    let Lens = Prefixed_Name(fresnel, "Lens") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:PropertyDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"More detailed description of the property, e.g. for specifing sublenses or merging properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#PropertyDescription">http://www.w3.org/2004/09/fresnel#PropertyDescription</seealso>
    let PropertyDescription =
        Prefixed_Name(fresnel, "PropertyDescription") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:PropertySet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract class of property sets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#PropertySet">http://www.w3.org/2004/09/fresnel#PropertySet</seealso>
    let PropertySet = Prefixed_Name(fresnel, "PropertySet") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:PropertyValueStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract superclass of all property value display styles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property value display style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#PropertyValueStyle">http://www.w3.org/2004/09/fresnel#PropertyValueStyle</seealso>
    let PropertyValueStyle =
        Prefixed_Name(fresnel, "PropertyValueStyle") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Propose in which a specific lens might be appropriate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#Purpose">http://www.w3.org/2004/09/fresnel#Purpose</seealso>
    let Purpose = Prefixed_Name(fresnel, "Purpose") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:ShowPropertyList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a convenience class for the OWL specification of Fresnel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Show Property List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#ShowPropertyList">http://www.w3.org/2004/09/fresnel#ShowPropertyList</seealso>
    let ShowPropertyList = Prefixed_Name(fresnel, "ShowPropertyList") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:allProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:PropertySet</para>
    ///   <para>"Set of all properties of the current instance, which have not be explicitly named before."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"All Properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#allProperties">http://www.w3.org/2004/09/fresnel#allProperties</seealso>
    let allProperties = Prefixed_Name(fresnel, "allProperties") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:classFormatDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Format should be applied to instances of this class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class format domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#classFormatDomain">http://www.w3.org/2004/09/fresnel#classFormatDomain</seealso>
    let classFormatDomain = Prefixed_Name(fresnel, "classFormatDomain") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:classLensDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies that the lens is usable for the specified class and its subclasses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class lens domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#classLensDomain">http://www.w3.org/2004/09/fresnel#classLensDomain</seealso>
    let classLensDomain = Prefixed_Name(fresnel, "classLensDomain") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:contentAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content that should be displayed before the content of the current box."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content after"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#contentAfter">http://www.w3.org/2004/09/fresnel#contentAfter</seealso>
    let contentAfter = Prefixed_Name(fresnel, "contentAfter") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:contentBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content that should be displayed before the content of the current box."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content before"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#contentBefore">http://www.w3.org/2004/09/fresnel#contentBefore</seealso>
    let contentBefore = Prefixed_Name(fresnel, "contentBefore") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:contentFirst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content that should be displayed before the content of the first element in a list of boxes; takes over the first :contentBefore element in case of a conflict."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content first"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#contentFirst">http://www.w3.org/2004/09/fresnel#contentFirst</seealso>
    let contentFirst = Prefixed_Name(fresnel, "contentFirst") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:contentLast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content that should be displayed after the content of the last element in a list of boxes; takes over the last :contentAfter element in case of a conflict."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content last"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#contentLast">http://www.w3.org/2004/09/fresnel#contentLast</seealso>
    let contentLast = Prefixed_Name(fresnel, "contentLast") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:contentNoValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content that should be displayed if the current property is missing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content no value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#contentNoValue">http://www.w3.org/2004/09/fresnel#contentNoValue</seealso>
    let contentNoValue = Prefixed_Name(fresnel, "contentNoValue") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:defaultLens</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:Purpose</para>
    ///   <para>"Provides the browser with a starting point which lens to show."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Lens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#defaultLens">http://www.w3.org/2004/09/fresnel#defaultLens</seealso>
    let defaultLens = Prefixed_Name(fresnel, "defaultLens") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Closure mechanism, if lenses are recursively used; the recursive depth limit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#depth">http://www.w3.org/2004/09/fresnel#depth</seealso>
    let depth = Prefixed_Name(fresnel, "depth") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:externalLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:PropertyValueStyle</para>
    ///   <para>"Show the property value as a dereferenceable URL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"External Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#externalLink">http://www.w3.org/2004/09/fresnel#externalLink</seealso>
    let externalLink = Prefixed_Name(fresnel, "externalLink") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the format group to which a format or a lens belongs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#group">http://www.w3.org/2004/09/fresnel#group</seealso>
    let group = Prefixed_Name(fresnel, "group") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:hideProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"List of all properties which should be hidden.  Must be used together with 'fresnel:showProperties fresnel:allProperties.'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hide properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#hideProperties">http://www.w3.org/2004/09/fresnel#hideProperties</seealso>
    let hideProperties = Prefixed_Name(fresnel, "hideProperties") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:PropertyValueStyle</para>
    ///   <para>"Show the property value as an image, such as PNG or JPEG ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#image">http://www.w3.org/2004/09/fresnel#image</seealso>
    let image = Prefixed_Name(fresnel, "image") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:instanceFormatDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Format should be applied to this set of instances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instance format domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#instanceFormatDomain">http://www.w3.org/2004/09/fresnel#instanceFormatDomain</seealso>
    let instanceFormatDomain =
        Prefixed_Name(fresnel, "instanceFormatDomain") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:instanceLensDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The lens is usable for the specified set of instances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instance lens domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#instanceLensDomain">http://www.w3.org/2004/09/fresnel#instanceLensDomain</seealso>
    let instanceLensDomain =
        Prefixed_Name(fresnel, "instanceLensDomain") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies how a property is labelled (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#label">http://www.w3.org/2004/09/fresnel#label</seealso>
    let label = Prefixed_Name(fresnel, "label") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:labelFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assign content formatting to a set of labels (theoretically, this does not make much sense, but it does round out the set of formatting properties; only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#labelFormat">http://www.w3.org/2004/09/fresnel#labelFormat</seealso>
    let labelFormat = Prefixed_Name(fresnel, "labelFormat") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:labelLens</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:Purpose</para>
    ///   <para>"Lens for providing a label for a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Label Lens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#labelLens">http://www.w3.org/2004/09/fresnel#labelLens</seealso>
    let labelLens = Prefixed_Name(fresnel, "labelLens") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:labelStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attaching a symbol appropriate for styling labels (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#labelStyle">http://www.w3.org/2004/09/fresnel#labelStyle</seealso>
    let labelStyle = Prefixed_Name(fresnel, "labelStyle") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:ConvienceProperty</para>
    ///   <para>"A special token to indicate the relationship between any RDF container or collection (rdf:List) and its member items.  Do not use as anything other than an individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#member">http://www.w3.org/2004/09/fresnel#member</seealso>
    let member_ = Prefixed_Name(fresnel, "member") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:none</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:LabellingFormat</para>
    ///   <para>"Do not show any label for the property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"none"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#none">http://www.w3.org/2004/09/fresnel#none</seealso>
    let none = Prefixed_Name(fresnel, "none") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:primaryClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the classes that should be considered primaries, or first class results; secondary resources not matching the primaries will only be shown as sublenses.  The range is a list of resource selectors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primaryClasses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#primaryClasses">http://www.w3.org/2004/09/fresnel#primaryClasses</seealso>
    let primaryClasses = Prefixed_Name(fresnel, "primaryClasses") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The RDF property, which is described."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#property">http://www.w3.org/2004/09/fresnel#property</seealso>
    let property = Prefixed_Name(fresnel, "property") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:propertyFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Assign content formatting to a set of properties (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#propertyFormat">http://www.w3.org/2004/09/fresnel#propertyFormat</seealso>
    let propertyFormat = Prefixed_Name(fresnel, "propertyFormat") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:propertyFormatDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Format should be used for the specified properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property format domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#propertyFormatDomain">http://www.w3.org/2004/09/fresnel#propertyFormatDomain</seealso>
    let propertyFormatDomain =
        Prefixed_Name(fresnel, "propertyFormatDomain") |> PrefixedName

    /// <summary>
    ///   <para>fresnel:propertyStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attaching a symbol appropriate for styling properties (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#propertyStyle">http://www.w3.org/2004/09/fresnel#propertyStyle</seealso>
    let propertyStyle = Prefixed_Name(fresnel, "propertyStyle") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies a purpose for which a lens or format might be appropriate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#purpose">http://www.w3.org/2004/09/fresnel#purpose</seealso>
    let purpose = Prefixed_Name(fresnel, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:replacedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:PropertyValueStyle</para>
    ///   <para>"Any kind of retrievable resource like an image, audio or video that should be displayed as property value.  The browser should try retrieve the resource and show it instead of the property value URI.  The browser has to negotiate an appropriate media type with the server using HTTP content negotiation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Replaced Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#replacedResource">http://www.w3.org/2004/09/fresnel#replacedResource</seealso>
    let replacedResource = Prefixed_Name(fresnel, "replacedResource") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:resourceFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assign content formatting to a set of resources (only works in conjunction with classFormatDomain and instanceFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#resourceFormat">http://www.w3.org/2004/09/fresnel#resourceFormat</seealso>
    let resourceFormat = Prefixed_Name(fresnel, "resourceFormat") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:resourceStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Attaching a symbol appropriate for styling a resource.  resourceStyle is ignored if not used with :classFormatDomain or :instanceFormatDomain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#resourceStyle">http://www.w3.org/2004/09/fresnel#resourceStyle</seealso>
    let resourceStyle = Prefixed_Name(fresnel, "resourceStyle") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:show</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:LabellingFormat</para>
    ///   <para>"Show the RDFS Label of the property. This is the default and doesn't have to be declared."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Show Label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#show">http://www.w3.org/2004/09/fresnel#show</seealso>
    let show = Prefixed_Name(fresnel, "show") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:showProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of all properties which should be shown."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"show properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#showProperties">http://www.w3.org/2004/09/fresnel#showProperties</seealso>
    let showProperties = Prefixed_Name(fresnel, "showProperties") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:sublens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Sublens which should be used for displaying property values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sublens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#sublens">http://www.w3.org/2004/09/fresnel#sublens</seealso>
    let sublens = Prefixed_Name(fresnel, "sublens") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>fresnel:PropertyValueStyle</para>
    ///   <para>"Show the property value as an URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#uri">http://www.w3.org/2004/09/fresnel#uri</seealso>
    let uri = Prefixed_Name(fresnel, "uri") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Explicit definition of fresnel:Group containing formats that should be used to render the lens or sublens."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#use">http://www.w3.org/2004/09/fresnel#use</seealso>
    let use_ = Prefixed_Name(fresnel, "use") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies how a property value is displayed (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#value">http://www.w3.org/2004/09/fresnel#value</seealso>
    let value = Prefixed_Name(fresnel, "value") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:valueFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assign content formatting to a set of values (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#valueFormat">http://www.w3.org/2004/09/fresnel#valueFormat</seealso>
    let valueFormat = Prefixed_Name(fresnel, "valueFormat") |> PrefixedName
    /// <summary>
    ///   <para>fresnel:valueStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Attaching a symbol appropriate for styling the values of a property (only works in conjunction with propertyFormatDomain)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/09/fresnel#valueStyle">http://www.w3.org/2004/09/fresnel#valueStyle</seealso>
    let valueStyle = Prefixed_Name(fresnel, "valueStyle") |> PrefixedName

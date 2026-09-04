#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fresnel =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2004/09/fresnel#" "fresnel"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This is a convenience class for the OWL specification of Fresnel (an rdf:List of resource selectors only).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#ClassList">fresnel:ClassList</a>
    /// </summary>
    let ClassList = _prefixId.prefix "ClassList"
    /// <summary>
    ///   <para>rdfs:label : Convenience Token^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract class for expressing shorthands a browser must understand how to expand.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#ConvenienceToken">fresnel:ConvenienceToken</a>
    /// </summary>
    let ConvenienceToken = _prefixId.prefix "ConvenienceToken"
    /// <summary>
    ///   <para>rdfs:label : Convenience Property^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract class of pseudo properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#ConvienceProperty">fresnel:ConvienceProperty</a>
    /// </summary>
    let ConvienceProperty = _prefixId.prefix "ConvienceProperty"
    /// <summary>
    ///   <para>rdfs:comment : A Fresnel format class for displaying RDF data; the domain property can be only one of :formatDomain, :classFormatDomain, :instanceFormatDomain.^^xsd:string</para>
    ///   <para>rdfs:label : Format Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#Format">fresnel:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:label : Format Description^^xsd:string</para>
    ///   <para>rdfs:comment : Description of fresnel:Format content separators; super class, not to be used directly.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#FormatDescription">fresnel:FormatDescription</a>
    /// </summary>
    let FormatDescription = _prefixId.prefix "FormatDescription"

    /// <summary>
    ///   <para>rdfs:label : Format Description No Substitution^^xsd:string</para>
    ///   <para>rdfs:comment : Description of fresnel:Format content separators only; contentNoValue will not be recognized in conjunction with this class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#FormatDescriptionNoSubstitution">fresnel:FormatDescriptionNoSubstitution</a>
    /// </summary>
    let FormatDescriptionNoSubstitution =
        _prefixId.prefix "FormatDescriptionNoSubstitution"

    /// <summary>
    ///   <para>rdfs:label : Format Description Substitution^^xsd:string</para>
    ///   <para>rdfs:comment : Description of fresnel:Format content separators and content replacement if values are missing.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#FormatDescriptionSubstitution">fresnel:FormatDescriptionSubstitution</a>
    /// </summary>
    let FormatDescriptionSubstitution = _prefixId.prefix "FormatDescriptionSubstitution"
    /// <summary>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>rdfs:comment : A Fresnel Group is used for grouping formats and lenses together.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#Group">fresnel:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Hide Property List^^xsd:string</para>
    ///   <para>rdfs:comment : This is a convenience class for the OWL specification of Fresnel.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#HidePropertyList">fresnel:HidePropertyList</a>
    /// </summary>
    let HidePropertyList = _prefixId.prefix "HidePropertyList"
    /// <summary>
    ///   <para>rdfs:label : Labelling Format^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract superclass of all labelling formats.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#LabellingFormat">fresnel:LabellingFormat</a>
    /// </summary>
    let LabellingFormat = _prefixId.prefix "LabellingFormat"
    /// <summary>
    ///   <para>rdfs:comment : Lens for viewing RDF data.^^xsd:string</para>
    ///   <para>rdfs:label : Lens^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#Lens">fresnel:Lens</a>
    /// </summary>
    let Lens = _prefixId.prefix "Lens"
    /// <summary>
    ///   <para>rdfs:label : Property Description^^xsd:string</para>
    ///   <para>rdfs:comment : More detailed description of the property, e.g. for specifing sublenses or merging properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#PropertyDescription">fresnel:PropertyDescription</a>
    /// </summary>
    let PropertyDescription = _prefixId.prefix "PropertyDescription"
    /// <summary>
    ///   <para>rdfs:label : Property Set^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract class of property sets.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#PropertySet">fresnel:PropertySet</a>
    /// </summary>
    let PropertySet = _prefixId.prefix "PropertySet"
    /// <summary>
    ///   <para>rdfs:label : Property value display style^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract superclass of all property value display styles.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#PropertyValueStyle">fresnel:PropertyValueStyle</a>
    /// </summary>
    let PropertyValueStyle = _prefixId.prefix "PropertyValueStyle"
    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <para>rdfs:comment : Propose in which a specific lens might be appropriate.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#Purpose">fresnel:Purpose</a>
    /// </summary>
    let Purpose = _prefixId.prefix "Purpose"
    /// <summary>
    ///   <para>rdfs:label : Show Property List^^xsd:string</para>
    ///   <para>rdfs:comment : This is a convenience class for the OWL specification of Fresnel.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#ShowPropertyList">fresnel:ShowPropertyList</a>
    /// </summary>
    let ShowPropertyList = _prefixId.prefix "ShowPropertyList"
    let allProperties = _prefixId.prefix "allProperties"
    /// <summary>
    ///   <para>rdfs:label : class format domain^^xsd:string</para>
    ///   <para>rdfs:comment : The Format should be applied to instances of this class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#classFormatDomain">fresnel:classFormatDomain</a>
    /// </summary>
    let classFormatDomain = _prefixId.prefix "classFormatDomain"
    /// <summary>
    ///   <para>rdfs:label : class lens domain^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that the lens is usable for the specified class and its subclasses.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#classLensDomain">fresnel:classLensDomain</a>
    /// </summary>
    let classLensDomain = _prefixId.prefix "classLensDomain"
    /// <summary>
    ///   <para>rdfs:label : content after^^xsd:string</para>
    ///   <para>rdfs:comment : Content that should be displayed before the content of the current box.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#contentAfter">fresnel:contentAfter</a>
    /// </summary>
    let contentAfter = _prefixId.prefix "contentAfter"
    /// <summary>
    ///   <para>rdfs:label : content before^^xsd:string</para>
    ///   <para>rdfs:comment : Content that should be displayed before the content of the current box.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#contentBefore">fresnel:contentBefore</a>
    /// </summary>
    let contentBefore = _prefixId.prefix "contentBefore"
    /// <summary>
    ///   <para>rdfs:label : content first^^xsd:string</para>
    ///   <para>rdfs:comment : Content that should be displayed before the content of the first element in a list of boxes; takes over the first :contentBefore element in case of a conflict.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#contentFirst">fresnel:contentFirst</a>
    /// </summary>
    let contentFirst = _prefixId.prefix "contentFirst"
    /// <summary>
    ///   <para>rdfs:label : content last^^xsd:string</para>
    ///   <para>rdfs:comment : Content that should be displayed after the content of the last element in a list of boxes; takes over the last :contentAfter element in case of a conflict.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#contentLast">fresnel:contentLast</a>
    /// </summary>
    let contentLast = _prefixId.prefix "contentLast"
    /// <summary>
    ///   <para>rdfs:label : content no value^^xsd:string</para>
    ///   <para>rdfs:comment : Content that should be displayed if the current property is missing.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#contentNoValue">fresnel:contentNoValue</a>
    /// </summary>
    let contentNoValue = _prefixId.prefix "contentNoValue"
    let defaultLens = _prefixId.prefix "defaultLens"
    /// <summary>
    ///   <para>rdfs:label : depth^^xsd:string</para>
    ///   <para>rdfs:comment : Closure mechanism, if lenses are recursively used; the recursive depth limit.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#depth">fresnel:depth</a>
    /// </summary>
    let depth = _prefixId.prefix "depth"
    let externalLink = _prefixId.prefix "externalLink"
    /// <summary>
    ///   <para>rdfs:label : group^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the format group to which a format or a lens belongs.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#group">fresnel:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : hide properties^^xsd:string</para>
    ///   <para>rdfs:comment : List of all properties which should be hidden.  Must be used together with 'fresnel:showProperties fresnel:allProperties.'^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#hideProperties">fresnel:hideProperties</a>
    /// </summary>
    let hideProperties = _prefixId.prefix "hideProperties"
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : instance format domain^^xsd:string</para>
    ///   <para>rdfs:comment : The Format should be applied to this set of instances.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#instanceFormatDomain">fresnel:instanceFormatDomain</a>
    /// </summary>
    let instanceFormatDomain = _prefixId.prefix "instanceFormatDomain"
    /// <summary>
    ///   <para>rdfs:label : instance lens domain^^xsd:string</para>
    ///   <para>rdfs:comment : The lens is usable for the specified set of instances.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#instanceLensDomain">fresnel:instanceLensDomain</a>
    /// </summary>
    let instanceLensDomain = _prefixId.prefix "instanceLensDomain"
    /// <summary>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies how a property is labelled (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#label">fresnel:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : label format^^xsd:string</para>
    ///   <para>rdfs:comment : Assign content formatting to a set of labels (theoretically, this does not make much sense, but it does round out the set of formatting properties; only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#labelFormat">fresnel:labelFormat</a>
    /// </summary>
    let labelFormat = _prefixId.prefix "labelFormat"
    let labelLens = _prefixId.prefix "labelLens"
    /// <summary>
    ///   <para>rdfs:label : label style^^xsd:string</para>
    ///   <para>rdfs:comment : Attaching a symbol appropriate for styling labels (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#labelStyle">fresnel:labelStyle</a>
    /// </summary>
    let labelStyle = _prefixId.prefix "labelStyle"
    let member_ = _prefixId.prefix "member"
    let none = _prefixId.prefix "none"
    /// <summary>
    ///   <para>rdfs:label : primaryClasses^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the classes that should be considered primaries, or first class results; secondary resources not matching the primaries will only be shown as sublenses.  The range is a list of resource selectors.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#primaryClasses">fresnel:primaryClasses</a>
    /// </summary>
    let primaryClasses = _prefixId.prefix "primaryClasses"
    /// <summary>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <para>rdfs:comment : The RDF property, which is described.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#property">fresnel:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : property format^^xsd:string</para>
    ///   <para>rdfs:comment : Assign content formatting to a set of properties (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#propertyFormat">fresnel:propertyFormat</a>
    /// </summary>
    let propertyFormat = _prefixId.prefix "propertyFormat"
    /// <summary>
    ///   <para>rdfs:label : property format domain^^xsd:string</para>
    ///   <para>rdfs:comment : The Format should be used for the specified properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#propertyFormatDomain">fresnel:propertyFormatDomain</a>
    /// </summary>
    let propertyFormatDomain = _prefixId.prefix "propertyFormatDomain"
    /// <summary>
    ///   <para>rdfs:label : property style^^xsd:string</para>
    ///   <para>rdfs:comment : Attaching a symbol appropriate for styling properties (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#propertyStyle">fresnel:propertyStyle</a>
    /// </summary>
    let propertyStyle = _prefixId.prefix "propertyStyle"
    /// <summary>
    ///   <para>rdfs:label : purpose^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a purpose for which a lens or format might be appropriate.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#purpose">fresnel:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    let replacedResource = _prefixId.prefix "replacedResource"
    /// <summary>
    ///   <para>rdfs:label : resource format^^xsd:string</para>
    ///   <para>rdfs:comment : Assign content formatting to a set of resources (only works in conjunction with classFormatDomain and instanceFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#resourceFormat">fresnel:resourceFormat</a>
    /// </summary>
    let resourceFormat = _prefixId.prefix "resourceFormat"
    /// <summary>
    ///   <para>rdfs:label : resource style^^xsd:string</para>
    ///   <para>rdfs:comment : Attaching a symbol appropriate for styling a resource.  resourceStyle is ignored if not used with :classFormatDomain or :instanceFormatDomain.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#resourceStyle">fresnel:resourceStyle</a>
    /// </summary>
    let resourceStyle = _prefixId.prefix "resourceStyle"
    let show = _prefixId.prefix "show"
    /// <summary>
    ///   <para>rdfs:label : show properties^^xsd:string</para>
    ///   <para>rdfs:comment : List of all properties which should be shown.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#showProperties">fresnel:showProperties</a>
    /// </summary>
    let showProperties = _prefixId.prefix "showProperties"
    /// <summary>
    ///   <para>rdfs:label : sublens^^xsd:string</para>
    ///   <para>rdfs:comment : Sublens which should be used for displaying property values.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#sublens">fresnel:sublens</a>
    /// </summary>
    let sublens = _prefixId.prefix "sublens"
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>rdfs:label : use^^xsd:string</para>
    ///   <para>rdfs:comment : Explicit definition of fresnel:Group containing formats that should be used to render the lens or sublens.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#use">fresnel:use</a>
    /// </summary>
    let use_ = _prefixId.prefix "use"
    /// <summary>
    ///   <para>rdfs:label : property value^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies how a property value is displayed (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#value">fresnel:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : value format^^xsd:string</para>
    ///   <para>rdfs:comment : Assign content formatting to a set of values (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#valueFormat">fresnel:valueFormat</a>
    /// </summary>
    let valueFormat = _prefixId.prefix "valueFormat"
    /// <summary>
    ///   <para>rdfs:label : value style^^xsd:string</para>
    ///   <para>rdfs:comment : Attaching a symbol appropriate for styling the values of a property (only works in conjunction with propertyFormatDomain).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/09/fresnel#valueStyle">fresnel:valueStyle</a>
    /// </summary>
    let valueStyle = _prefixId.prefix "valueStyle"

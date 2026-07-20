namespace http.www.w3.org._2004._09.fresnel.hash

open DoxAletheia

module fresnel =
    let _namespace_name = "http://www.w3.org/2004/09/fresnel#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel (an rdf:List of resource selectors only).
    /// <see href="http://www.w3.org/2004/09/fresnel#ClassList"></see></summary>
    let ClassList = _prefix "ClassList"
    /// <summary>
    /// Abstract class for expressing shorthands a browser must understand how to expand.
    /// <see href="http://www.w3.org/2004/09/fresnel#ConvenienceToken"></see></summary>
    let ConvenienceToken = _prefix "ConvenienceToken"
    /// <summary>
    /// Abstract class of pseudo properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#ConvienceProperty"></see></summary>
    let ConvienceProperty = _prefix "ConvienceProperty"
    /// <summary>
    /// A Fresnel format class for displaying RDF data; the domain property can be only one of :formatDomain, :classFormatDomain, :instanceFormatDomain.
    /// <see href="http://www.w3.org/2004/09/fresnel#Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// Assign content formatting to a set of values (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#valueFormat"></see></summary>
    let valueFormat = _prefix "valueFormat"
    /// <summary>
    /// Description of fresnel:Format content separators only; contentNoValue will not be recognized in conjunction with this class.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescriptionNoSubstitution"></see></summary>
    let FormatDescriptionNoSubstitution = _prefix "FormatDescriptionNoSubstitution"
    /// <summary>
    /// Assign content formatting to a set of resources (only works in conjunction with classFormatDomain and instanceFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#resourceFormat"></see></summary>
    let resourceFormat = _prefix "resourceFormat"
    /// <summary>
    /// The Format should be applied to this set of instances.
    /// <see href="http://www.w3.org/2004/09/fresnel#instanceFormatDomain"></see></summary>
    let instanceFormatDomain = _prefix "instanceFormatDomain"
    /// <summary>
    /// Assign content formatting to a set of properties (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyFormat"></see></summary>
    let propertyFormat = _prefix "propertyFormat"
    /// <summary>
    /// Description of fresnel:Format content separators and content replacement if values are missing.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescriptionSubstitution"></see></summary>
    let FormatDescriptionSubstitution = _prefix "FormatDescriptionSubstitution"
    /// <summary>
    /// Specifies how a property value is displayed (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Abstract superclass of all property value display styles.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertyValueStyle"></see></summary>
    let PropertyValueStyle = _prefix "PropertyValueStyle"
    /// <summary>
    /// Attaching a symbol appropriate for styling labels (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#labelStyle"></see></summary>
    let labelStyle = _prefix "labelStyle"
    /// <summary>
    /// Specifies the format group to which a format or a lens belongs.
    /// <see href="http://www.w3.org/2004/09/fresnel#group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    /// A Fresnel Group is used for grouping formats and lenses together.
    /// <see href="http://www.w3.org/2004/09/fresnel#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// The Format should be used for the specified properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyFormatDomain"></see></summary>
    let propertyFormatDomain = _prefix "propertyFormatDomain"
    /// <summary>
    /// Abstract class of property sets.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertySet"></see></summary>
    let PropertySet = _prefix "PropertySet"
    /// <summary>
    /// Specifies how a property is labelled (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// Attaching a symbol appropriate for styling the values of a property (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#valueStyle"></see></summary>
    let valueStyle = _prefix "valueStyle"
    /// <summary>
    /// Specifies a purpose for which a lens or format might be appropriate.
    /// <see href="http://www.w3.org/2004/09/fresnel#purpose"></see></summary>
    let purpose = _prefix "purpose"
    /// <summary>
    /// Propose in which a specific lens might be appropriate.
    /// <see href="http://www.w3.org/2004/09/fresnel#Purpose"></see></summary>
    let Purpose = _prefix "Purpose"
    /// <summary>
    /// The Format should be applied to instances of this class.
    /// <see href="http://www.w3.org/2004/09/fresnel#classFormatDomain"></see></summary>
    let classFormatDomain = _prefix "classFormatDomain"
    /// <summary>
    /// Attaching a symbol appropriate for styling properties (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyStyle"></see></summary>
    let propertyStyle = _prefix "propertyStyle"
    /// <summary>
    /// Assign content formatting to a set of labels (theoretically, this does not make much sense, but it does round out the set of formatting properties; only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#labelFormat"></see></summary>
    let labelFormat = _prefix "labelFormat"
    /// <summary>
    /// Lens for viewing RDF data.
    /// <see href="http://www.w3.org/2004/09/fresnel#Lens"></see></summary>
    let Lens = _prefix "Lens"
    /// <summary>
    /// Description of fresnel:Format content separators; super class, not to be used directly.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescription"></see></summary>
    let FormatDescription = _prefix "FormatDescription"
    /// <summary>
    /// Content that should be displayed before the content of the current box.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentBefore"></see></summary>
    let contentBefore = _prefix "contentBefore"
    /// <summary>
    /// Content that should be displayed before the content of the current box.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentAfter"></see></summary>
    let contentAfter = _prefix "contentAfter"
    /// <summary>
    /// Content that should be displayed before the content of the first element in a list of boxes; takes over the first :contentBefore element in case of a conflict.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentFirst"></see></summary>
    let contentFirst = _prefix "contentFirst"
    /// <summary>
    /// Content that should be displayed after the content of the last element in a list of boxes; takes over the last :contentAfter element in case of a conflict.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentLast"></see></summary>
    let contentLast = _prefix "contentLast"
    /// <summary>
    /// Content that should be displayed if the current property is missing.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentNoValue"></see></summary>
    let contentNoValue = _prefix "contentNoValue"
    /// <summary>
    /// Specifies the classes that should be considered primaries, or first class results; secondary resources not matching the primaries will only be shown as sublenses.  The range is a list of resource selectors.
    /// <see href="http://www.w3.org/2004/09/fresnel#primaryClasses"></see></summary>
    let primaryClasses = _prefix "primaryClasses"
    /// <summary>
    /// Attaching a symbol appropriate for styling a resource.  resourceStyle is ignored if not used with :classFormatDomain or :instanceFormatDomain.
    /// <see href="http://www.w3.org/2004/09/fresnel#resourceStyle"></see></summary>
    let resourceStyle = _prefix "resourceStyle"
    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel.
    /// <see href="http://www.w3.org/2004/09/fresnel#HidePropertyList"></see></summary>
    let HidePropertyList = _prefix "HidePropertyList"
    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel.
    /// <see href="http://www.w3.org/2004/09/fresnel#ShowPropertyList"></see></summary>
    let ShowPropertyList = _prefix "ShowPropertyList"
    /// <summary>
    /// Abstract superclass of all labelling formats.
    /// <see href="http://www.w3.org/2004/09/fresnel#LabellingFormat"></see></summary>
    let LabellingFormat = _prefix "LabellingFormat"
    /// <summary>
    /// Show the RDFS Label of the property. This is the default and doesn't have to be declared.
    /// <see href="http://www.w3.org/2004/09/fresnel#show"></see></summary>
    let show = _prefix "show"
    /// <summary>
    /// Do not show any label for the property.
    /// <see href="http://www.w3.org/2004/09/fresnel#none"></see></summary>
    let none = _prefix "none"
    /// <summary>
    /// The lens is usable for the specified set of instances.
    /// <see href="http://www.w3.org/2004/09/fresnel#instanceLensDomain"></see></summary>
    let instanceLensDomain = _prefix "instanceLensDomain"
    /// <summary>
    /// List of all properties which should be shown.
    /// <see href="http://www.w3.org/2004/09/fresnel#showProperties"></see></summary>
    let showProperties = _prefix "showProperties"
    /// <summary>
    /// Specifies that the lens is usable for the specified class and its subclasses.
    /// <see href="http://www.w3.org/2004/09/fresnel#classLensDomain"></see></summary>
    let classLensDomain = _prefix "classLensDomain"
    /// <summary>
    /// Explicit definition of fresnel:Group containing formats that should be used to render the lens or sublens.
    /// <see href="http://www.w3.org/2004/09/fresnel#use"></see></summary>
    let use_ = _prefix "use"
    /// <summary>
    /// List of all properties which should be hidden.  Must be used together with 'fresnel:showProperties fresnel:allProperties.'
    /// <see href="http://www.w3.org/2004/09/fresnel#hideProperties"></see></summary>
    let hideProperties = _prefix "hideProperties"
    /// <summary>
    /// More detailed description of the property, e.g. for specifing sublenses or merging properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertyDescription"></see></summary>
    let PropertyDescription = _prefix "PropertyDescription"
    /// <summary>
    /// The RDF property, which is described.
    /// <see href="http://www.w3.org/2004/09/fresnel#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// Sublens which should be used for displaying property values.
    /// <see href="http://www.w3.org/2004/09/fresnel#sublens"></see></summary>
    let sublens = _prefix "sublens"
    /// <summary>
    /// Closure mechanism, if lenses are recursively used; the recursive depth limit.
    /// <see href="http://www.w3.org/2004/09/fresnel#depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    /// Show the property value as an URI.
    /// <see href="http://www.w3.org/2004/09/fresnel#uri"></see></summary>
    let uri = _prefix "uri"
    /// <summary>
    /// Any kind of retrievable resource like an image, audio or video that should be displayed as property value.  The browser should try retrieve the resource and show it instead of the property value URI.  The browser has to negotiate an appropriate media type with the server using HTTP content negotiation.
    /// <see href="http://www.w3.org/2004/09/fresnel#replacedResource"></see></summary>
    let replacedResource = _prefix "replacedResource"
    /// <summary>
    /// Show the property value as an image, such as PNG or JPEG .
    /// <see href="http://www.w3.org/2004/09/fresnel#image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// Set of all properties of the current instance, which have not be explicitly named before.
    /// <see href="http://www.w3.org/2004/09/fresnel#allProperties"></see></summary>
    let allProperties = _prefix "allProperties"
    /// <summary>
    /// Provides the browser with a starting point which lens to show.
    /// <see href="http://www.w3.org/2004/09/fresnel#defaultLens"></see></summary>
    let defaultLens = _prefix "defaultLens"
    /// <summary>
    /// Show the property value as a dereferenceable URL.
    /// <see href="http://www.w3.org/2004/09/fresnel#externalLink"></see></summary>
    let externalLink = _prefix "externalLink"
    /// <summary>
    /// Lens for providing a label for a resource.
    /// <see href="http://www.w3.org/2004/09/fresnel#labelLens"></see></summary>
    let labelLens = _prefix "labelLens"
    /// <summary>
    /// A special token to indicate the relationship between any RDF container or collection (rdf:List) and its member items.  Do not use as anything other than an individual.
    /// <see href="http://www.w3.org/2004/09/fresnel#member"></see></summary>
    let member_ = _prefix "member"

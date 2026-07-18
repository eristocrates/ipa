namespace http.www.w3.org._2004._09.fresnel.hash

open DoxAletheia.Rdf_Vocabulary

module fresnel =
    let _namespace_name = "http://www.w3.org/2004/09/fresnel#"
    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel (an rdf:List of resource selectors only).
    /// <see href="http://www.w3.org/2004/09/fresnel#ClassList"></see></summary>
    let ClassList = Namespaced_IRI.parse _namespace_name "ClassList" |> NamespacedName

    /// <summary>
    /// Abstract class for expressing shorthands a browser must understand how to expand.
    /// <see href="http://www.w3.org/2004/09/fresnel#ConvenienceToken"></see></summary>
    let ConvenienceToken =
        Namespaced_IRI.parse _namespace_name "ConvenienceToken" |> NamespacedName

    /// <summary>
    /// Abstract class of pseudo properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#ConvienceProperty"></see></summary>
    let ConvienceProperty =
        Namespaced_IRI.parse _namespace_name "ConvienceProperty" |> NamespacedName

    /// <summary>
    /// A Fresnel format class for displaying RDF data; the domain property can be only one of :formatDomain, :classFormatDomain, :instanceFormatDomain.
    /// <see href="http://www.w3.org/2004/09/fresnel#Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    /// Assign content formatting to a set of values (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#valueFormat"></see></summary>
    let valueFormat =
        Namespaced_IRI.parse _namespace_name "valueFormat" |> NamespacedName

    /// <summary>
    /// Description of fresnel:Format content separators only; contentNoValue will not be recognized in conjunction with this class.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescriptionNoSubstitution"></see></summary>
    let FormatDescriptionNoSubstitution =
        Namespaced_IRI.parse _namespace_name "FormatDescriptionNoSubstitution" |> NamespacedName

    /// <summary>
    /// Assign content formatting to a set of resources (only works in conjunction with classFormatDomain and instanceFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#resourceFormat"></see></summary>
    let resourceFormat =
        Namespaced_IRI.parse _namespace_name "resourceFormat" |> NamespacedName

    /// <summary>
    /// The Format should be applied to this set of instances.
    /// <see href="http://www.w3.org/2004/09/fresnel#instanceFormatDomain"></see></summary>
    let instanceFormatDomain =
        Namespaced_IRI.parse _namespace_name "instanceFormatDomain" |> NamespacedName

    /// <summary>
    /// Assign content formatting to a set of properties (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyFormat"></see></summary>
    let propertyFormat =
        Namespaced_IRI.parse _namespace_name "propertyFormat" |> NamespacedName

    /// <summary>
    /// Description of fresnel:Format content separators and content replacement if values are missing.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescriptionSubstitution"></see></summary>
    let FormatDescriptionSubstitution =
        Namespaced_IRI.parse _namespace_name "FormatDescriptionSubstitution" |> NamespacedName

    /// <summary>
    /// Specifies how a property value is displayed (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// Abstract superclass of all property value display styles.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertyValueStyle"></see></summary>
    let PropertyValueStyle =
        Namespaced_IRI.parse _namespace_name "PropertyValueStyle" |> NamespacedName

    /// <summary>
    /// Attaching a symbol appropriate for styling labels (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#labelStyle"></see></summary>
    let labelStyle = Namespaced_IRI.parse _namespace_name "labelStyle" |> NamespacedName
    /// <summary>
    /// Specifies the format group to which a format or a lens belongs.
    /// <see href="http://www.w3.org/2004/09/fresnel#group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    /// A Fresnel Group is used for grouping formats and lenses together.
    /// <see href="http://www.w3.org/2004/09/fresnel#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName

    /// <summary>
    /// The Format should be used for the specified properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyFormatDomain"></see></summary>
    let propertyFormatDomain =
        Namespaced_IRI.parse _namespace_name "propertyFormatDomain" |> NamespacedName

    /// <summary>
    /// Abstract class of property sets.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertySet"></see></summary>
    let PropertySet =
        Namespaced_IRI.parse _namespace_name "PropertySet" |> NamespacedName

    /// <summary>
    /// Specifies how a property is labelled (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// Attaching a symbol appropriate for styling the values of a property (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#valueStyle"></see></summary>
    let valueStyle = Namespaced_IRI.parse _namespace_name "valueStyle" |> NamespacedName
    /// <summary>
    /// Specifies a purpose for which a lens or format might be appropriate.
    /// <see href="http://www.w3.org/2004/09/fresnel#purpose"></see></summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName
    /// <summary>
    /// Propose in which a specific lens might be appropriate.
    /// <see href="http://www.w3.org/2004/09/fresnel#Purpose"></see></summary>
    let Purpose = Namespaced_IRI.parse _namespace_name "Purpose" |> NamespacedName

    /// <summary>
    /// The Format should be applied to instances of this class.
    /// <see href="http://www.w3.org/2004/09/fresnel#classFormatDomain"></see></summary>
    let classFormatDomain =
        Namespaced_IRI.parse _namespace_name "classFormatDomain" |> NamespacedName

    /// <summary>
    /// Attaching a symbol appropriate for styling properties (only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#propertyStyle"></see></summary>
    let propertyStyle =
        Namespaced_IRI.parse _namespace_name "propertyStyle" |> NamespacedName

    /// <summary>
    /// Assign content formatting to a set of labels (theoretically, this does not make much sense, but it does round out the set of formatting properties; only works in conjunction with propertyFormatDomain).
    /// <see href="http://www.w3.org/2004/09/fresnel#labelFormat"></see></summary>
    let labelFormat =
        Namespaced_IRI.parse _namespace_name "labelFormat" |> NamespacedName

    /// <summary>
    /// Lens for viewing RDF data.
    /// <see href="http://www.w3.org/2004/09/fresnel#Lens"></see></summary>
    let Lens = Namespaced_IRI.parse _namespace_name "Lens" |> NamespacedName

    /// <summary>
    /// Description of fresnel:Format content separators; super class, not to be used directly.
    /// <see href="http://www.w3.org/2004/09/fresnel#FormatDescription"></see></summary>
    let FormatDescription =
        Namespaced_IRI.parse _namespace_name "FormatDescription" |> NamespacedName

    /// <summary>
    /// Content that should be displayed before the content of the current box.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentBefore"></see></summary>
    let contentBefore =
        Namespaced_IRI.parse _namespace_name "contentBefore" |> NamespacedName

    /// <summary>
    /// Content that should be displayed before the content of the current box.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentAfter"></see></summary>
    let contentAfter =
        Namespaced_IRI.parse _namespace_name "contentAfter" |> NamespacedName

    /// <summary>
    /// Content that should be displayed before the content of the first element in a list of boxes; takes over the first :contentBefore element in case of a conflict.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentFirst"></see></summary>
    let contentFirst =
        Namespaced_IRI.parse _namespace_name "contentFirst" |> NamespacedName

    /// <summary>
    /// Content that should be displayed after the content of the last element in a list of boxes; takes over the last :contentAfter element in case of a conflict.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentLast"></see></summary>
    let contentLast =
        Namespaced_IRI.parse _namespace_name "contentLast" |> NamespacedName

    /// <summary>
    /// Content that should be displayed if the current property is missing.
    /// <see href="http://www.w3.org/2004/09/fresnel#contentNoValue"></see></summary>
    let contentNoValue =
        Namespaced_IRI.parse _namespace_name "contentNoValue" |> NamespacedName

    /// <summary>
    /// Specifies the classes that should be considered primaries, or first class results; secondary resources not matching the primaries will only be shown as sublenses.  The range is a list of resource selectors.
    /// <see href="http://www.w3.org/2004/09/fresnel#primaryClasses"></see></summary>
    let primaryClasses =
        Namespaced_IRI.parse _namespace_name "primaryClasses" |> NamespacedName

    /// <summary>
    /// Attaching a symbol appropriate for styling a resource.  resourceStyle is ignored if not used with :classFormatDomain or :instanceFormatDomain.
    /// <see href="http://www.w3.org/2004/09/fresnel#resourceStyle"></see></summary>
    let resourceStyle =
        Namespaced_IRI.parse _namespace_name "resourceStyle" |> NamespacedName

    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel.
    /// <see href="http://www.w3.org/2004/09/fresnel#HidePropertyList"></see></summary>
    let HidePropertyList =
        Namespaced_IRI.parse _namespace_name "HidePropertyList" |> NamespacedName

    /// <summary>
    /// This is a convenience class for the OWL specification of Fresnel.
    /// <see href="http://www.w3.org/2004/09/fresnel#ShowPropertyList"></see></summary>
    let ShowPropertyList =
        Namespaced_IRI.parse _namespace_name "ShowPropertyList" |> NamespacedName

    /// <summary>
    /// Abstract superclass of all labelling formats.
    /// <see href="http://www.w3.org/2004/09/fresnel#LabellingFormat"></see></summary>
    let LabellingFormat =
        Namespaced_IRI.parse _namespace_name "LabellingFormat" |> NamespacedName

    /// <summary>
    /// Show the RDFS Label of the property. This is the default and doesn't have to be declared.
    /// <see href="http://www.w3.org/2004/09/fresnel#show"></see></summary>
    let show = Namespaced_IRI.parse _namespace_name "show" |> NamespacedName
    /// <summary>
    /// Do not show any label for the property.
    /// <see href="http://www.w3.org/2004/09/fresnel#none"></see></summary>
    let none = Namespaced_IRI.parse _namespace_name "none" |> NamespacedName

    /// <summary>
    /// The lens is usable for the specified set of instances.
    /// <see href="http://www.w3.org/2004/09/fresnel#instanceLensDomain"></see></summary>
    let instanceLensDomain =
        Namespaced_IRI.parse _namespace_name "instanceLensDomain" |> NamespacedName

    /// <summary>
    /// List of all properties which should be shown.
    /// <see href="http://www.w3.org/2004/09/fresnel#showProperties"></see></summary>
    let showProperties =
        Namespaced_IRI.parse _namespace_name "showProperties" |> NamespacedName

    /// <summary>
    /// Specifies that the lens is usable for the specified class and its subclasses.
    /// <see href="http://www.w3.org/2004/09/fresnel#classLensDomain"></see></summary>
    let classLensDomain =
        Namespaced_IRI.parse _namespace_name "classLensDomain" |> NamespacedName

    /// <summary>
    /// Explicit definition of fresnel:Group containing formats that should be used to render the lens or sublens.
    /// <see href="http://www.w3.org/2004/09/fresnel#use"></see></summary>
    let use_ = Namespaced_IRI.parse _namespace_name "use" |> NamespacedName

    /// <summary>
    /// List of all properties which should be hidden.  Must be used together with 'fresnel:showProperties fresnel:allProperties.'
    /// <see href="http://www.w3.org/2004/09/fresnel#hideProperties"></see></summary>
    let hideProperties =
        Namespaced_IRI.parse _namespace_name "hideProperties" |> NamespacedName

    /// <summary>
    /// More detailed description of the property, e.g. for specifing sublenses or merging properties.
    /// <see href="http://www.w3.org/2004/09/fresnel#PropertyDescription"></see></summary>
    let PropertyDescription =
        Namespaced_IRI.parse _namespace_name "PropertyDescription" |> NamespacedName

    /// <summary>
    /// The RDF property, which is described.
    /// <see href="http://www.w3.org/2004/09/fresnel#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName
    /// <summary>
    /// Sublens which should be used for displaying property values.
    /// <see href="http://www.w3.org/2004/09/fresnel#sublens"></see></summary>
    let sublens = Namespaced_IRI.parse _namespace_name "sublens" |> NamespacedName
    /// <summary>
    /// Closure mechanism, if lenses are recursively used; the recursive depth limit.
    /// <see href="http://www.w3.org/2004/09/fresnel#depth"></see></summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName
    /// <summary>
    /// Show the property value as an URI.
    /// <see href="http://www.w3.org/2004/09/fresnel#uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName

    /// <summary>
    /// Any kind of retrievable resource like an image, audio or video that should be displayed as property value.  The browser should try retrieve the resource and show it instead of the property value URI.  The browser has to negotiate an appropriate media type with the server using HTTP content negotiation.
    /// <see href="http://www.w3.org/2004/09/fresnel#replacedResource"></see></summary>
    let replacedResource =
        Namespaced_IRI.parse _namespace_name "replacedResource" |> NamespacedName

    /// <summary>
    /// Show the property value as an image, such as PNG or JPEG .
    /// <see href="http://www.w3.org/2004/09/fresnel#image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName

    /// <summary>
    /// Set of all properties of the current instance, which have not be explicitly named before.
    /// <see href="http://www.w3.org/2004/09/fresnel#allProperties"></see></summary>
    let allProperties =
        Namespaced_IRI.parse _namespace_name "allProperties" |> NamespacedName

    /// <summary>
    /// Provides the browser with a starting point which lens to show.
    /// <see href="http://www.w3.org/2004/09/fresnel#defaultLens"></see></summary>
    let defaultLens =
        Namespaced_IRI.parse _namespace_name "defaultLens" |> NamespacedName

    /// <summary>
    /// Show the property value as a dereferenceable URL.
    /// <see href="http://www.w3.org/2004/09/fresnel#externalLink"></see></summary>
    let externalLink =
        Namespaced_IRI.parse _namespace_name "externalLink" |> NamespacedName

    /// <summary>
    /// Lens for providing a label for a resource.
    /// <see href="http://www.w3.org/2004/09/fresnel#labelLens"></see></summary>
    let labelLens = Namespaced_IRI.parse _namespace_name "labelLens" |> NamespacedName
    /// <summary>
    /// A special token to indicate the relationship between any RDF container or collection (rdf:List) and its member items.  Do not use as anything other than an individual.
    /// <see href="http://www.w3.org/2004/09/fresnel#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ui =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ui#" "ui"
    let BooleanField = _prefixId.prefix "BooleanField"
    let CaseForm = _prefixId.prefix "CaseForm"
    let Choice = _prefixId.prefix "Choice"
    /// <summary>
    ///   <para>rdfs:label : classifier^^xsd:string</para>
    ///   <para>rdfs:comment : A classifier allows the user to select the type of an object.
    ///     The possible types must be subclasses of some overall class, the "category".
    ///     (Ideally, the superclass is also set up as the disjoint union of the subclasses,
    ///     if they are disjoint.)
    ///
    ///     The form normally stores the resulting classes using an rdf:type triple,
    ///     but a different predicate can be used if required, so the classifier field
    ///     needs is 'property' defined too.
    ///
    ///     If the subclass selected itself is has subclasses defined, the user can
    ///     recursively select from them in turn, as many levels as needed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#Classifier">ui:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    let Color = _prefixId.prefix "Color"
    let ColorField = _prefixId.prefix "ColorField"
    let Comment = _prefixId.prefix "Comment"
    let DateField = _prefixId.prefix "DateField"
    let DateTimeField = _prefixId.prefix "DateTimeField"
    let DecimalField = _prefixId.prefix "DecimalField"
    let EmailField = _prefixId.prefix "EmailField"
    let FF1 = _prefixId.prefix "FF1"
    let FF2 = _prefixId.prefix "FF2"
    let FF3 = _prefixId.prefix "FF3"
    let FieldForm = _prefixId.prefix "FieldForm"
    let FieldList = _prefixId.prefix "FieldList"
    let FloatField = _prefixId.prefix "FloatField"
    /// <summary>
    ///   <para>rdfs:comment : A form can be any type of single field, or typically a Group of several fields,
    ///     including interspersed headings and comments.  ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#Form">ui:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    let FormForm = _prefixId.prefix "FormForm"
    let Group = _prefixId.prefix "Group"
    let Heading = _prefixId.prefix "Heading"
    let IntegerField = _prefixId.prefix "IntegerField"
    let MultiLineTextField = _prefixId.prefix "MultiLineTextField"
    let Multiple = _prefixId.prefix "Multiple"
    let NumericField = _prefixId.prefix "NumericField"
    let Options = _prefixId.prefix "Options"
    let PhoneField = _prefixId.prefix "PhoneField"
    let Single = _prefixId.prefix "Single"
    let SingleLineTextField = _prefixId.prefix "SingleLineTextField"
    let TextField = _prefixId.prefix "TextField"
    let TriStateField = _prefixId.prefix "TriStateField"
    let ValueField = _prefixId.prefix "ValueField"
    /// <summary>
    ///   <para>rdfs:label : annotation form^^xsd:string</para>
    ///   <para>rdfs:comment : A form which may be used to add more infromation to an
    /// instance of this class which we know something about.  Anything from
    /// adding just add one more fact, to adding a whole lot of information about a specific
    /// facet of the thing.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#annotationForm">ui:annotationForm</a>
    /// </summary>
    let annotationForm = _prefixId.prefix "annotationForm"
    /// <summary>
    ///   <para>rdfs:label : background color</para>
    ///   <para>rdfs:comment : Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#backgroundColor">ui:backgroundColor</a>
    /// </summary>
    let backgroundColor = _prefixId.prefix "backgroundColor"
    /// <summary>
    ///   <para>rdfs:label : background image</para>
    ///   <para>rdfs:comment : URI or base64 representation of an image^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#backgroundImage">ui:backgroundImage</a>
    /// </summary>
    let backgroundImage = _prefixId.prefix "backgroundImage"
    let canMintNew = _prefixId.prefix "canMintNew"
    let case = _prefixId.prefix "case"
    /// <summary>
    ///   <para>rdfs:label : overall superclass</para>
    ///   <para>rdfs:comment : The superclass subclasses of which will be selected.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#category">ui:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : color</para>
    ///   <para>rdfs:comment : Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#color">ui:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    let contents = _prefixId.prefix "contents"
    /// <summary>
    ///   <para>rdfs:label : creation form^^xsd:string</para>
    ///   <para>rdfs:comment : A form which may be used to collect information about a
    ///     hitherto locally undocumented instance instance of this class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#creationForm">ui:creationForm</a>
    /// </summary>
    let creationForm = _prefixId.prefix "creationForm"
    let default_ = _prefixId.prefix "default"
    /// <summary>
    ///   <para>rdfs:label : depending on</para>
    ///   <para>rdfs:comment : Many fields prompt for information about a given property of the subject^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#dependingOn">ui:dependingOn</a>
    /// </summary>
    let dependingOn = _prefixId.prefix "dependingOn"
    let e = _prefixId.prefix "e"
    /// <summary>
    ///   <para>rdfs:label : for</para>
    ///   <para>rdfs:comment : The value for which this case is selected.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#for">ui:for</a>
    /// </summary>
    let for_ = _prefixId.prefix "for"
    /// <summary>
    ///   <para>ui:prompt : from what class^^xsd:string</para>
    ///   <para>rdfs:label : from^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#from">ui:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>ui:prompt : Properties to be specified for new ones^^xsd:string</para>
    ///   <para>rdfs:label : initial properties^^xsd:string</para>
    ///   <para>rdfs:comment : A really simple way of enabling user interfaces to
    ///             create new information about a class of things is to make a define of properties
    ///             to be specified when a information about a new item
    ///             ("New item" here means an item which the system
    ///             does not have prvious information about yet,
    ///             not an items which has just been created,
    ///             like new friend as opposed to new baby)^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#initialProperties">ui:initialProperties</a>
    /// </summary>
    let initialProperties = _prefixId.prefix "initialProperties"
    let label = _prefixId.prefix "label"
    let max = _prefixId.prefix "max"
    /// <summary>
    ///   <para>rdfs:label : max length of value^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#maxLength">ui:maxLength</a>
    /// </summary>
    let maxLength = _prefixId.prefix "maxLength"
    /// <summary>
    ///   <para>rdfs:label : max^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#maxValue">ui:maxValue</a>
    /// </summary>
    let maxValue = _prefixId.prefix "maxValue"
    let min = _prefixId.prefix "min"
    /// <summary>
    ///   <para>rdfs:label : min^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#minValue">ui:minValue</a>
    /// </summary>
    let minValue = _prefixId.prefix "minValue"
    let optional = _prefixId.prefix "optional"
    let ordered = _prefixId.prefix "ordered"
    /// <summary>
    ///   <para>rdfs:label : part</para>
    ///   <a href="http://www.w3.org/ns/ui#part">ui:part</a>
    /// </summary>
    let part = _prefixId.prefix "part"
    /// <summary>
    ///   <para>rdfs:label : parts</para>
    ///   <a href="http://www.w3.org/ns/ui#parts">ui:parts</a>
    /// </summary>
    let parts = _prefixId.prefix "parts"
    /// <summary>
    ///   <para>ui:prompt : A longer prompt for a user inputting this property^^xsd:string</para>
    ///   <para>rdfs:label : user prompt^^xsd:string</para>
    ///   <para>rdfs:comment : A string for the UI to use if the user needs a longer
    ///         prompts than just a field name, the rdfs:label. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#prompt">ui:prompt</a>
    /// </summary>
    let prompt = _prefixId.prefix "prompt"
    /// <summary>
    ///   <para>rdfs:label : property to be stored</para>
    ///   <para>rdfs:comment : Many fields prompt for information about a given property of the subject.
    ///     When field is filled in, this gives which property is written into the data.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#property">ui:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : sequence number^^xsd:string</para>
    ///   <para>rdfs:comment : The sequence in which this item is arranged with repect to other parts.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#seqeunce">ui:seqeunce</a>
    /// </summary>
    let seqeunce = _prefixId.prefix "seqeunce"
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>ui:prompt : size of field in characters^^xsd:string</para>
    ///   <para>rdfs:label : size of field^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#size">ui:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : sort by^^xsd:string</para>
    ///   <para>rdfs:comment : A property which typically is used to sort
    ///         members of a given class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#sortBy">ui:sortBy</a>
    /// </summary>
    let sortBy = _prefixId.prefix "sortBy"
    /// <summary>
    ///   <para>rdfs:label : sort priority^^xsd:string</para>
    ///   <para>rdfs:comment : When individuals or classes must be sorted, then
    ///         if they are given different values of sortPriority a user agent can
    ///         use this as a hint to how to present information.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#sortPriority">ui:sortPriority</a>
    /// </summary>
    let sortPriority = _prefixId.prefix "sortPriority"
    /// <summary>
    ///   <para>ui:prompt : CSS style^^xsd:string</para>
    ///   <para>rdfs:label : style^^xsd:string</para>
    ///   <para>rdfs:comment : Must be a valid CSS style string such as one could put in
    ///         an HTML style attribute.  Depending on the user interface system, this can
    ///         by given to individuals, classes or properties. It is up to a user interface
    ///         which wants to draw on them to pick how it uses styles from which parts
    ///         of the data it has.  For example, the style of a class may be picked
    ///         to distinguish information about things in that class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#style">ui:style</a>
    /// </summary>
    let style = _prefixId.prefix "style"
    /// <summary>
    ///   <para>ui:prompt : Properties to be given in a default table view^^xsd:string</para>
    ///   <para>rdfs:label : table properties^^xsd:string</para>
    ///   <para>rdfs:comment : This  is a crude way of specifying a table-based
    ///             view for objects of this class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ui#tableProperties">ui:tableProperties</a>
    /// </summary>
    let tableProperties = _prefixId.prefix "tableProperties"
    let true_ = _prefixId.prefix "true"
    let use_ = _prefixId.prefix "use"

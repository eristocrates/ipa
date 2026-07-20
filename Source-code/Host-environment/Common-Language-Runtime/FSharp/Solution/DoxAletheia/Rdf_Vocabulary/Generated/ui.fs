namespace http.www.w3.org.ns.ui.hash

open DoxAletheia

module ui =
    let _namespace_name = "http://www.w3.org/ns/ui#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#BooleanField"></see>
    /// </summary>
    let BooleanField = _prefix "BooleanField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#NumericField"></see>
    /// </summary>
    let NumericField = _prefix "NumericField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#CaseForm"></see>
    /// </summary>
    let CaseForm = _prefix "CaseForm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#sequence"></see>
    /// </summary>
    let sequence = _prefix "sequence"
    /// <summary>
    /// Many fields prompt for information about a given property of the subject.
    ///     When field is filled in, this gives which property is written into the data.
    /// <see href="http://www.w3.org/ns/ui#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// The value for which this case is selected.
    /// <see href="http://www.w3.org/ns/ui#for"></see></summary>
    let for_ = _prefix "for"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#label"></see>
    /// </summary>
    let label = _prefix "label"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#from"></see>
    /// </summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#canMintNew"></see>
    /// </summary>
    let canMintNew = _prefix "canMintNew"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#true"></see>
    /// </summary>
    let true_ = _prefix "true"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Choice"></see>
    /// </summary>
    let Choice = _prefix "Choice"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#use"></see>
    /// </summary>
    let use_ = _prefix "use"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FieldForm"></see>
    /// </summary>
    let FieldForm = _prefix "FieldForm"
    /// <summary>
    /// A form can be any type of single field, or typically a Group of several fields,
    ///     including interspersed headings and comments.
    /// <see href="http://www.w3.org/ns/ui#Form"></see></summary>
    let Form = _prefix "Form"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#parts"></see>
    /// </summary>
    let parts = _prefix "parts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Single"></see>
    /// </summary>
    let Single = _prefix "Single"
    /// <summary>
    /// A classifier allows the user to select the type of an object.
    ///     The possible types must be subclasses of some overall class, the "category".
    ///     (Ideally, the superclass is also set up as the disjoint union of the subclasses,
    ///     if they are disjoint.)
    ///
    ///     The form normally stores the resulting classes using an rdf:type triple,
    ///     but a different predicate can be used if required, so the classifier field
    ///     needs is 'property' defined too.
    ///
    ///     If the subclass selected itself is has subclasses defined, the user can
    ///     recursively select from them in turn, as many levels as needed.
    /// <see href="http://www.w3.org/ns/ui#Classifier"></see></summary>
    let Classifier = _prefix "Classifier"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ColorField"></see>
    /// </summary>
    let ColorField = _prefix "ColorField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ValueField"></see>
    /// </summary>
    let ValueField = _prefix "ValueField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Comment"></see>
    /// </summary>
    let Comment = _prefix "Comment"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DateField"></see>
    /// </summary>
    let DateField = _prefix "DateField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DateTimeField"></see>
    /// </summary>
    let DateTimeField = _prefix "DateTimeField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DecimalField"></see>
    /// </summary>
    let DecimalField = _prefix "DecimalField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#EmailField"></see>
    /// </summary>
    let EmailField = _prefix "EmailField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF1"></see>
    /// </summary>
    let FF1 = _prefix "FF1"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Heading"></see>
    /// </summary>
    let Heading = _prefix "Heading"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#contents"></see>
    /// </summary>
    let contents = _prefix "contents"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF2"></see>
    /// </summary>
    let FF2 = _prefix "FF2"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#SingleLineTextField"></see>
    /// </summary>
    let SingleLineTextField = _prefix "SingleLineTextField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#size"></see>
    /// </summary>
    let size = _prefix "size"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF3"></see>
    /// </summary>
    let FF3 = _prefix "FF3"
    /// <summary>
    /// Must be a valid CSS style string such as one could put in
    ///         an HTML style attribute.  Depending on the user interface system, this can
    ///         by given to individuals, classes or properties. It is up to a user interface
    ///         which wants to draw on them to pick how it uses styles from which parts
    ///         of the data it has.  For example, the style of a class may be picked
    ///         to distinguish information about things in that class.
    /// <see href="http://www.w3.org/ns/ui#style"></see></summary>
    let style = _prefix "style"
    /// <summary>
    /// The superclass subclasses of which will be selected.
    /// <see href="http://www.w3.org/ns/ui#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#min"></see>
    /// </summary>
    let min = _prefix "min"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#max"></see>
    /// </summary>
    let max = _prefix "max"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#IntegerField"></see>
    /// </summary>
    let IntegerField = _prefix "IntegerField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#maxLength"></see>
    /// </summary>
    let maxLength = _prefix "maxLength"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#TextField"></see>
    /// </summary>
    let TextField = _prefix "TextField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#case"></see>
    /// </summary>
    let case = _prefix "case"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FieldList"></see>
    /// </summary>
    let FieldList = _prefix "FieldList"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FormForm"></see>
    /// </summary>
    let FormForm = _prefix "FormForm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#optional"></see>
    /// </summary>
    let optional = _prefix "optional"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FloatField"></see>
    /// </summary>
    let FloatField = _prefix "FloatField"
    /// <summary>
    /// Many fields prompt for information about a given property of the subject
    /// <see href="http://www.w3.org/ns/ui#dependingOn"></see></summary>
    let dependingOn = _prefix "dependingOn"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#default"></see>
    /// </summary>
    let default_ = _prefix "default"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#part"></see>
    /// </summary>
    let part = _prefix "part"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Multiple"></see>
    /// </summary>
    let Multiple = _prefix "Multiple"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Options"></see>
    /// </summary>
    let Options = _prefix "Options"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ordered"></see>
    /// </summary>
    let ordered = _prefix "ordered"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#MultiLineTextField"></see>
    /// </summary>
    let MultiLineTextField = _prefix "MultiLineTextField"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#PhoneField"></see>
    /// </summary>
    let PhoneField = _prefix "PhoneField"
    /// <summary>
    /// A form which may be used to collect information about a
    ///     hitherto locally undocumented instance instance of this class.
    /// <see href="http://www.w3.org/ns/ui#creationForm"></see></summary>
    let creationForm = _prefix "creationForm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#TriStateField"></see>
    /// </summary>
    let TriStateField = _prefix "TriStateField"
    /// <summary>
    /// A form which may be used to add more infromation to an
    /// instance of this class which we know something about.  Anything from
    /// adding just add one more fact, to adding a whole lot of information about a specific
    /// facet of the thing.
    ///
    /// <see href="http://www.w3.org/ns/ui#annotationForm"></see></summary>
    let annotationForm = _prefix "annotationForm"
    /// <summary>
    /// Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.
    /// <see href="http://www.w3.org/ns/ui#backgroundColor"></see></summary>
    let backgroundColor = _prefix "backgroundColor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Color"></see>
    /// </summary>
    let Color = _prefix "Color"
    /// <summary>
    /// URI or base64 representation of an image
    /// <see href="http://www.w3.org/ns/ui#backgroundImage"></see></summary>
    let backgroundImage = _prefix "backgroundImage"
    /// <summary>
    /// Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.
    /// <see href="http://www.w3.org/ns/ui#color"></see></summary>
    let color = _prefix "color"
    /// <summary>
    /// A string for the UI to use if the user needs a longer
    ///         prompts than just a field name, the rdfs:label.
    /// <see href="http://www.w3.org/ns/ui#prompt"></see></summary>
    let prompt = _prefix "prompt"
    /// <summary>
    /// A really simple way of enabling user interfaces to
    ///             create new information about a class of things is to make a define of properties
    ///             to be specified when a information about a new item
    ///             ("New item" here means an item which the system
    ///             does not have prvious information about yet,
    ///             not an items which has just been created,
    ///             like new friend as opposed to new baby)
    /// <see href="http://www.w3.org/ns/ui#initialProperties"></see></summary>
    let initialProperties = _prefix "initialProperties"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#maxValue"></see>
    /// </summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#minValue"></see>
    /// </summary>
    let minValue = _prefix "minValue"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#e"></see>
    /// </summary>
    let e = _prefix "e"
    /// <summary>
    /// The sequence in which this item is arranged with repect to other parts.
    /// <see href="http://www.w3.org/ns/ui#seqeunce"></see></summary>
    let seqeunce = _prefix "seqeunce"
    /// <summary>
    /// A property which typically is used to sort
    ///         members of a given class.
    /// <see href="http://www.w3.org/ns/ui#sortBy"></see></summary>
    let sortBy = _prefix "sortBy"
    /// <summary>
    /// When individuals or classes must be sorted, then
    ///         if they are given different values of sortPriority a user agent can
    ///         use this as a hint to how to present information.
    /// <see href="http://www.w3.org/ns/ui#sortPriority"></see></summary>
    let sortPriority = _prefix "sortPriority"
    /// <summary>
    /// This  is a crude way of specifying a table-based
    ///             view for objects of this class.
    /// <see href="http://www.w3.org/ns/ui#tableProperties"></see></summary>
    let tableProperties = _prefix "tableProperties"

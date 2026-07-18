namespace http.www.w3.org.ns.ui.hash

open DoxAletheia.Rdf_Vocabulary

module ui =
    let _namespace_name = "http://www.w3.org/ns/ui#"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#BooleanField"></see>
    /// </summary>
    let BooleanField =
        Namespaced_IRI.parse _namespace_name "BooleanField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#NumericField"></see>
    /// </summary>
    let NumericField =
        Namespaced_IRI.parse _namespace_name "NumericField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#CaseForm"></see>
    /// </summary>
    let CaseForm = Namespaced_IRI.parse _namespace_name "CaseForm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Group"></see>
    /// </summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#sequence"></see>
    /// </summary>
    let sequence = Namespaced_IRI.parse _namespace_name "sequence" |> NamespacedName
    /// <summary>
    /// Many fields prompt for information about a given property of the subject.
    ///     When field is filled in, this gives which property is written into the data.
    /// <see href="http://www.w3.org/ns/ui#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName
    /// <summary>
    /// The value for which this case is selected.
    /// <see href="http://www.w3.org/ns/ui#for"></see></summary>
    let for_ = Namespaced_IRI.parse _namespace_name "for" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#label"></see>
    /// </summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#from"></see>
    /// </summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#canMintNew"></see>
    /// </summary>
    let canMintNew = Namespaced_IRI.parse _namespace_name "canMintNew" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#true"></see>
    /// </summary>
    let true_ = Namespaced_IRI.parse _namespace_name "true" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Choice"></see>
    /// </summary>
    let Choice = Namespaced_IRI.parse _namespace_name "Choice" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#use"></see>
    /// </summary>
    let use_ = Namespaced_IRI.parse _namespace_name "use" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FieldForm"></see>
    /// </summary>
    let FieldForm = Namespaced_IRI.parse _namespace_name "FieldForm" |> NamespacedName
    /// <summary>
    /// A form can be any type of single field, or typically a Group of several fields,
    ///     including interspersed headings and comments.
    /// <see href="http://www.w3.org/ns/ui#Form"></see></summary>
    let Form = Namespaced_IRI.parse _namespace_name "Form" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#parts"></see>
    /// </summary>
    let parts = Namespaced_IRI.parse _namespace_name "parts" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Single"></see>
    /// </summary>
    let Single = Namespaced_IRI.parse _namespace_name "Single" |> NamespacedName
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
    let Classifier = Namespaced_IRI.parse _namespace_name "Classifier" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ColorField"></see>
    /// </summary>
    let ColorField = Namespaced_IRI.parse _namespace_name "ColorField" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ValueField"></see>
    /// </summary>
    let ValueField = Namespaced_IRI.parse _namespace_name "ValueField" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Comment"></see>
    /// </summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DateField"></see>
    /// </summary>
    let DateField = Namespaced_IRI.parse _namespace_name "DateField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DateTimeField"></see>
    /// </summary>
    let DateTimeField =
        Namespaced_IRI.parse _namespace_name "DateTimeField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#DecimalField"></see>
    /// </summary>
    let DecimalField =
        Namespaced_IRI.parse _namespace_name "DecimalField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#EmailField"></see>
    /// </summary>
    let EmailField = Namespaced_IRI.parse _namespace_name "EmailField" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF1"></see>
    /// </summary>
    let FF1 = Namespaced_IRI.parse _namespace_name "FF1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Heading"></see>
    /// </summary>
    let Heading = Namespaced_IRI.parse _namespace_name "Heading" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#contents"></see>
    /// </summary>
    let contents = Namespaced_IRI.parse _namespace_name "contents" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF2"></see>
    /// </summary>
    let FF2 = Namespaced_IRI.parse _namespace_name "FF2" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#SingleLineTextField"></see>
    /// </summary>
    let SingleLineTextField =
        Namespaced_IRI.parse _namespace_name "SingleLineTextField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#size"></see>
    /// </summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FF3"></see>
    /// </summary>
    let FF3 = Namespaced_IRI.parse _namespace_name "FF3" |> NamespacedName
    /// <summary>
    /// Must be a valid CSS style string such as one could put in
    ///         an HTML style attribute.  Depending on the user interface system, this can
    ///         by given to individuals, classes or properties. It is up to a user interface
    ///         which wants to draw on them to pick how it uses styles from which parts
    ///         of the data it has.  For example, the style of a class may be picked
    ///         to distinguish information about things in that class.
    /// <see href="http://www.w3.org/ns/ui#style"></see></summary>
    let style = Namespaced_IRI.parse _namespace_name "style" |> NamespacedName
    /// <summary>
    /// The superclass subclasses of which will be selected.
    /// <see href="http://www.w3.org/ns/ui#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#min"></see>
    /// </summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#max"></see>
    /// </summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#IntegerField"></see>
    /// </summary>
    let IntegerField =
        Namespaced_IRI.parse _namespace_name "IntegerField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#maxLength"></see>
    /// </summary>
    let maxLength = Namespaced_IRI.parse _namespace_name "maxLength" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#TextField"></see>
    /// </summary>
    let TextField = Namespaced_IRI.parse _namespace_name "TextField" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#case"></see>
    /// </summary>
    let case = Namespaced_IRI.parse _namespace_name "case" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FieldList"></see>
    /// </summary>
    let FieldList = Namespaced_IRI.parse _namespace_name "FieldList" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FormForm"></see>
    /// </summary>
    let FormForm = Namespaced_IRI.parse _namespace_name "FormForm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#optional"></see>
    /// </summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#FloatField"></see>
    /// </summary>
    let FloatField = Namespaced_IRI.parse _namespace_name "FloatField" |> NamespacedName

    /// <summary>
    /// Many fields prompt for information about a given property of the subject
    /// <see href="http://www.w3.org/ns/ui#dependingOn"></see></summary>
    let dependingOn =
        Namespaced_IRI.parse _namespace_name "dependingOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#default"></see>
    /// </summary>
    let default_ = Namespaced_IRI.parse _namespace_name "default" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#part"></see>
    /// </summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Multiple"></see>
    /// </summary>
    let Multiple = Namespaced_IRI.parse _namespace_name "Multiple" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Options"></see>
    /// </summary>
    let Options = Namespaced_IRI.parse _namespace_name "Options" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#ordered"></see>
    /// </summary>
    let ordered = Namespaced_IRI.parse _namespace_name "ordered" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#MultiLineTextField"></see>
    /// </summary>
    let MultiLineTextField =
        Namespaced_IRI.parse _namespace_name "MultiLineTextField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#PhoneField"></see>
    /// </summary>
    let PhoneField = Namespaced_IRI.parse _namespace_name "PhoneField" |> NamespacedName

    /// <summary>
    /// A form which may be used to collect information about a
    ///     hitherto locally undocumented instance instance of this class.
    /// <see href="http://www.w3.org/ns/ui#creationForm"></see></summary>
    let creationForm =
        Namespaced_IRI.parse _namespace_name "creationForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#TriStateField"></see>
    /// </summary>
    let TriStateField =
        Namespaced_IRI.parse _namespace_name "TriStateField" |> NamespacedName

    /// <summary>
    /// A form which may be used to add more infromation to an
    /// instance of this class which we know something about.  Anything from
    /// adding just add one more fact, to adding a whole lot of information about a specific
    /// facet of the thing.
    ///
    /// <see href="http://www.w3.org/ns/ui#annotationForm"></see></summary>
    let annotationForm =
        Namespaced_IRI.parse _namespace_name "annotationForm" |> NamespacedName

    /// <summary>
    /// Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.
    /// <see href="http://www.w3.org/ns/ui#backgroundColor"></see></summary>
    let backgroundColor =
        Namespaced_IRI.parse _namespace_name "backgroundColor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#Color"></see>
    /// </summary>
    let Color = Namespaced_IRI.parse _namespace_name "Color" |> NamespacedName

    /// <summary>
    /// URI or base64 representation of an image
    /// <see href="http://www.w3.org/ns/ui#backgroundImage"></see></summary>
    let backgroundImage =
        Namespaced_IRI.parse _namespace_name "backgroundImage" |> NamespacedName

    /// <summary>
    /// Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.
    /// <see href="http://www.w3.org/ns/ui#color"></see></summary>
    let color = Namespaced_IRI.parse _namespace_name "color" |> NamespacedName
    /// <summary>
    /// A string for the UI to use if the user needs a longer
    ///         prompts than just a field name, the rdfs:label.
    /// <see href="http://www.w3.org/ns/ui#prompt"></see></summary>
    let prompt = Namespaced_IRI.parse _namespace_name "prompt" |> NamespacedName

    /// <summary>
    /// A really simple way of enabling user interfaces to
    ///             create new information about a class of things is to make a define of properties
    ///             to be specified when a information about a new item
    ///             ("New item" here means an item which the system
    ///             does not have prvious information about yet,
    ///             not an items which has just been created,
    ///             like new friend as opposed to new baby)
    /// <see href="http://www.w3.org/ns/ui#initialProperties"></see></summary>
    let initialProperties =
        Namespaced_IRI.parse _namespace_name "initialProperties" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#maxValue"></see>
    /// </summary>
    let maxValue = Namespaced_IRI.parse _namespace_name "maxValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#minValue"></see>
    /// </summary>
    let minValue = Namespaced_IRI.parse _namespace_name "minValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ui#e"></see>
    /// </summary>
    let e = Namespaced_IRI.parse _namespace_name "e" |> NamespacedName
    /// <summary>
    /// The sequence in which this item is arranged with repect to other parts.
    /// <see href="http://www.w3.org/ns/ui#seqeunce"></see></summary>
    let seqeunce = Namespaced_IRI.parse _namespace_name "seqeunce" |> NamespacedName
    /// <summary>
    /// A property which typically is used to sort
    ///         members of a given class.
    /// <see href="http://www.w3.org/ns/ui#sortBy"></see></summary>
    let sortBy = Namespaced_IRI.parse _namespace_name "sortBy" |> NamespacedName

    /// <summary>
    /// When individuals or classes must be sorted, then
    ///         if they are given different values of sortPriority a user agent can
    ///         use this as a hint to how to present information.
    /// <see href="http://www.w3.org/ns/ui#sortPriority"></see></summary>
    let sortPriority =
        Namespaced_IRI.parse _namespace_name "sortPriority" |> NamespacedName

    /// <summary>
    /// This  is a crude way of specifying a table-based
    ///             view for objects of this class.
    /// <see href="http://www.w3.org/ns/ui#tableProperties"></see></summary>
    let tableProperties =
        Namespaced_IRI.parse _namespace_name "tableProperties" |> NamespacedName

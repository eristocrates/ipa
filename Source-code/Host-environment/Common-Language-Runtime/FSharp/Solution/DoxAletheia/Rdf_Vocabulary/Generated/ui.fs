namespace http.www.w3.org.ns.ui.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ui =
    let _namespace_iri = Namespace_Iri ui |> NamespaceIRI
    /// <summary>
    ///   <para>ui:canMintNew</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#canMintNew">http://www.w3.org/ns/ui#canMintNew</seealso>
    let canMintNew = Prefixed_Name(ui, "canMintNew") |> PrefixedName
    /// <summary>
    ///   <para>ui:ColorField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#ColorField">http://www.w3.org/ns/ui#ColorField</seealso>
    let ColorField = Prefixed_Name(ui, "ColorField") |> PrefixedName
    /// <summary>
    ///   <para>ui:ValueField</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#ValueField">http://www.w3.org/ns/ui#ValueField</seealso>
    let ValueField = Prefixed_Name(ui, "ValueField") |> PrefixedName
    /// <summary>
    ///   <para>ui:EmailField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#EmailField">http://www.w3.org/ns/ui#EmailField</seealso>
    let EmailField = Prefixed_Name(ui, "EmailField") |> PrefixedName
    /// <summary>
    ///   <para>ui:FF1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Heading</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FF1">http://www.w3.org/ns/ui#FF1</seealso>
    let FF1 = Prefixed_Name(ui, "FF1") |> PrefixedName
    /// <summary>
    ///   <para>ui:SingleLineTextField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#SingleLineTextField">http://www.w3.org/ns/ui#SingleLineTextField</seealso>
    let SingleLineTextField = Prefixed_Name(ui, "SingleLineTextField") |> PrefixedName
    /// <summary>
    ///   <para>ui:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>size of field</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#size">http://www.w3.org/ns/ui#size</seealso>
    let size = Prefixed_Name(ui, "size") |> PrefixedName
    /// <summary>
    ///   <para>ui:CaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Group</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#CaseForm">http://www.w3.org/ns/ui#CaseForm</seealso>
    let CaseForm = Prefixed_Name(ui, "CaseForm") |> PrefixedName
    /// <summary>
    ///   <para>ui:FieldForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Group</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FieldForm">http://www.w3.org/ns/ui#FieldForm</seealso>
    let FieldForm = Prefixed_Name(ui, "FieldForm") |> PrefixedName
    /// <summary>
    ///   <para>ui:parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>parts</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#parts">http://www.w3.org/ns/ui#parts</seealso>
    let parts = Prefixed_Name(ui, "parts") |> PrefixedName
    /// <summary>
    ///   <para>ui:DateField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#DateField">http://www.w3.org/ns/ui#DateField</seealso>
    let DateField = Prefixed_Name(ui, "DateField") |> PrefixedName
    /// <summary>
    ///   <para>ui:FF2</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:SingleLineTextField</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FF2">http://www.w3.org/ns/ui#FF2</seealso>
    let FF2 = Prefixed_Name(ui, "FF2") |> PrefixedName
    /// <summary>
    ///   <para>ui:FF3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Comment</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FF3">http://www.w3.org/ns/ui#FF3</seealso>
    let FF3 = Prefixed_Name(ui, "FF3") |> PrefixedName
    /// <summary>
    ///   <para>ui:BooleanField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#BooleanField">http://www.w3.org/ns/ui#BooleanField</seealso>
    let BooleanField = Prefixed_Name(ui, "BooleanField") |> PrefixedName
    /// <summary>
    ///   <para>ui:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Many fields prompt for information about a given property of the subject.
    ///     When field is filled in, this gives which property is written into the data.</para>
    /// labels<para>property to be stored</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#property">http://www.w3.org/ns/ui#property</seealso>
    let property = Prefixed_Name(ui, "property") |> PrefixedName
    /// <summary>
    ///   <para>ui:contents</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#contents">http://www.w3.org/ns/ui#contents</seealso>
    let contents = Prefixed_Name(ui, "contents") |> PrefixedName
    /// <summary>
    ///   <para>ui:style</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Must be a valid CSS style string such as one could put in
    ///         an HTML style attribute.  Depending on the user interface system, this can
    ///         by given to individuals, classes or properties. It is up to a user interface
    ///         which wants to draw on them to pick how it uses styles from which parts
    ///         of the data it has.  For example, the style of a class may be picked
    ///         to distinguish information about things in that class.</para>
    /// labels<para>style</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#style">http://www.w3.org/ns/ui#style</seealso>
    let style = Prefixed_Name(ui, "style") |> PrefixedName
    /// <summary>
    ///   <para>ui:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The superclass subclasses of which will be selected.</para>
    /// labels<para>overall superclass</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#category">http://www.w3.org/ns/ui#category</seealso>
    let category = Prefixed_Name(ui, "category") |> PrefixedName
    /// <summary>
    ///   <para>ui:max</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#max">http://www.w3.org/ns/ui#max</seealso>
    let max = Prefixed_Name(ui, "max") |> PrefixedName
    /// <summary>
    ///   <para>ui:TextField</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#TextField">http://www.w3.org/ns/ui#TextField</seealso>
    let TextField = Prefixed_Name(ui, "TextField") |> PrefixedName
    /// <summary>
    ///   <para>ui:prompt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A string for the UI to use if the user needs a longer
    ///         prompts than just a field name, the rdfs:label. </para>
    /// labels<para>user prompt</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#prompt">http://www.w3.org/ns/ui#prompt</seealso>
    let prompt = Prefixed_Name(ui, "prompt") |> PrefixedName
    /// <summary>
    ///   <para>ui:initialProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A really simple way of enabling user interfaces to
    ///             create new information about a class of things is to make a define of properties
    ///             to be specified when a information about a new item
    ///             ("New item" here means an item which the system
    ///             does not have prvious information about yet,
    ///             not an items which has just been created,
    ///             like new friend as opposed to new baby)</para>
    /// labels<para>initial properties</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#initialProperties">http://www.w3.org/ns/ui#initialProperties</seealso>
    let initialProperties = Prefixed_Name(ui, "initialProperties") |> PrefixedName
    /// <summary>
    ///   <para>ui:e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#e">http://www.w3.org/ns/ui#e</seealso>
    let e = Prefixed_Name(ui, "e") |> PrefixedName
    /// <summary>
    ///   <para>ui:NumericField</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#NumericField">http://www.w3.org/ns/ui#NumericField</seealso>
    let NumericField = Prefixed_Name(ui, "NumericField") |> PrefixedName
    /// <summary>
    ///   <para>ui:sequence</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#sequence">http://www.w3.org/ns/ui#sequence</seealso>
    let sequence = Prefixed_Name(ui, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>ui:for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value for which this case is selected.</para>
    /// labels<para>for</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#for">http://www.w3.org/ns/ui#for</seealso>
    let for_ = Prefixed_Name(ui, "for") |> PrefixedName
    /// <summary>
    ///   <para>ui:true</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#true">http://www.w3.org/ns/ui#true</seealso>
    let true_ = Prefixed_Name(ui, "true") |> PrefixedName
    /// <summary>
    ///   <para>ui:label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#label">http://www.w3.org/ns/ui#label</seealso>
    let label = Prefixed_Name(ui, "label") |> PrefixedName
    /// <summary>
    ///   <para>ui:Choice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Choice">http://www.w3.org/ns/ui#Choice</seealso>
    let Choice = Prefixed_Name(ui, "Choice") |> PrefixedName
    /// <summary>
    ///   <para>ui:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A form can be any type of single field, or typically a Group of several fields,
    ///     including interspersed headings and comments.  </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Form">http://www.w3.org/ns/ui#Form</seealso>
    let Form = Prefixed_Name(ui, "Form") |> PrefixedName
    /// <summary>
    ///   <para>ui:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A classifier allows the user to select the type of an object.
    ///     The possible types must be subclasses of some overall class, the "category".
    ///     (Ideally, the superclass is also set up as the disjoint union of the subclasses,
    ///     if they are disjoint.)
    ///
    ///     The form normally stores the resulting classes using an rdf:type triple,
    ///     but a different predicate can be used if required, so the classifier field
    ///     needs is 'property' defined too.
    ///
    ///     If the subclass selected itself is has subclasses defined, the user can
    ///     recursively select from them in turn, as many levels as needed.</para>
    /// labels<para>classifier</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Classifier">http://www.w3.org/ns/ui#Classifier</seealso>
    let Classifier = Prefixed_Name(ui, "Classifier") |> PrefixedName
    /// <summary>
    ///   <para>ui:DateTimeField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#DateTimeField">http://www.w3.org/ns/ui#DateTimeField</seealso>
    let DateTimeField = Prefixed_Name(ui, "DateTimeField") |> PrefixedName
    /// <summary>
    ///   <para>ui:PhoneField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#PhoneField">http://www.w3.org/ns/ui#PhoneField</seealso>
    let PhoneField = Prefixed_Name(ui, "PhoneField") |> PrefixedName
    /// <summary>
    ///   <para>ui:creationForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A form which may be used to collect information about a
    ///     hitherto locally undocumented instance instance of this class.</para>
    /// labels<para>creation form</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#creationForm">http://www.w3.org/ns/ui#creationForm</seealso>
    let creationForm = Prefixed_Name(ui, "creationForm") |> PrefixedName
    /// <summary>
    ///   <para>ui:TriStateField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#TriStateField">http://www.w3.org/ns/ui#TriStateField</seealso>
    let TriStateField = Prefixed_Name(ui, "TriStateField") |> PrefixedName
    /// <summary>
    ///   <para>ui:annotationForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A form which may be used to add more infromation to an
    /// instance of this class which we know something about.  Anything from
    /// adding just add one more fact, to adding a whole lot of information about a specific
    /// facet of the thing.
    /// </para>
    /// labels<para>annotation form</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#annotationForm">http://www.w3.org/ns/ui#annotationForm</seealso>
    let annotationForm = Prefixed_Name(ui, "annotationForm") |> PrefixedName
    /// <summary>
    ///   <para>ui:backgroundColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.</para>
    /// labels<para>background color</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#backgroundColor">http://www.w3.org/ns/ui#backgroundColor</seealso>
    let backgroundColor = Prefixed_Name(ui, "backgroundColor") |> PrefixedName
    /// <summary>
    ///   <para>ui:Color</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Color">http://www.w3.org/ns/ui#Color</seealso>
    let Color = Prefixed_Name(ui, "Color") |> PrefixedName
    /// <summary>
    ///   <para>ui:backgroundImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI or base64 representation of an image</para>
    /// labels<para>background image</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#backgroundImage">http://www.w3.org/ns/ui#backgroundImage</seealso>
    let backgroundImage = Prefixed_Name(ui, "backgroundImage") |> PrefixedName
    /// <summary>
    ///   <para>ui:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Must be a valid CSS color string such as one could put in
    ///         an HTML style attribute.  This should be in the #xxxxxx form,
    ///         (with 6 digits of hex)  so that it
    ///         can work with Graphviz.</para>
    /// labels<para>color</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#color">http://www.w3.org/ns/ui#color</seealso>
    let color = Prefixed_Name(ui, "color") |> PrefixedName
    /// <summary>
    ///   <para>ui:maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>max</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#maxValue">http://www.w3.org/ns/ui#maxValue</seealso>
    let maxValue = Prefixed_Name(ui, "maxValue") |> PrefixedName
    /// <summary>
    ///   <para>ui:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>min</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#minValue">http://www.w3.org/ns/ui#minValue</seealso>
    let minValue = Prefixed_Name(ui, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>ui:seqeunce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The sequence in which this item is arranged with repect to other parts.</para>
    /// labels<para>sequence number</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#seqeunce">http://www.w3.org/ns/ui#seqeunce</seealso>
    let seqeunce = Prefixed_Name(ui, "seqeunce") |> PrefixedName
    /// <summary>
    ///   <para>ui:sortBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property which typically is used to sort
    ///         members of a given class.</para>
    /// labels<para>sort by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#sortBy">http://www.w3.org/ns/ui#sortBy</seealso>
    let sortBy = Prefixed_Name(ui, "sortBy") |> PrefixedName
    /// <summary>
    ///   <para>ui:sortPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>When individuals or classes must be sorted, then
    ///         if they are given different values of sortPriority a user agent can
    ///         use this as a hint to how to present information.</para>
    /// labels<para>sort priority</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#sortPriority">http://www.w3.org/ns/ui#sortPriority</seealso>
    let sortPriority = Prefixed_Name(ui, "sortPriority") |> PrefixedName
    /// <summary>
    ///   <para>ui:tableProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This  is a crude way of specifying a table-based
    ///             view for objects of this class.</para>
    /// labels<para>table properties</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#tableProperties">http://www.w3.org/ns/ui#tableProperties</seealso>
    let tableProperties = Prefixed_Name(ui, "tableProperties") |> PrefixedName
    /// <summary>
    ///   <para>ui:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>from</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#from">http://www.w3.org/ns/ui#from</seealso>
    let from = Prefixed_Name(ui, "from") |> PrefixedName
    /// <summary>
    ///   <para>ui:Single</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Single">http://www.w3.org/ns/ui#Single</seealso>
    let Single = Prefixed_Name(ui, "Single") |> PrefixedName
    /// <summary>
    ///   <para>ui:Comment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Comment">http://www.w3.org/ns/ui#Comment</seealso>
    let Comment = Prefixed_Name(ui, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>ui:DecimalField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#DecimalField">http://www.w3.org/ns/ui#DecimalField</seealso>
    let DecimalField = Prefixed_Name(ui, "DecimalField") |> PrefixedName
    /// <summary>
    ///   <para>ui:Heading</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Heading">http://www.w3.org/ns/ui#Heading</seealso>
    let Heading = Prefixed_Name(ui, "Heading") |> PrefixedName
    /// <summary>
    ///   <para>ui:min</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#min">http://www.w3.org/ns/ui#min</seealso>
    let min = Prefixed_Name(ui, "min") |> PrefixedName
    /// <summary>
    ///   <para>ui:IntegerField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#IntegerField">http://www.w3.org/ns/ui#IntegerField</seealso>
    let IntegerField = Prefixed_Name(ui, "IntegerField") |> PrefixedName
    /// <summary>
    ///   <para>ui:maxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>max length of value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#maxLength">http://www.w3.org/ns/ui#maxLength</seealso>
    let maxLength = Prefixed_Name(ui, "maxLength") |> PrefixedName
    /// <summary>
    ///   <para>ui:case</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#case">http://www.w3.org/ns/ui#case</seealso>
    let case = Prefixed_Name(ui, "case") |> PrefixedName
    /// <summary>
    ///   <para>ui:FieldList</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Multiple</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FieldList">http://www.w3.org/ns/ui#FieldList</seealso>
    let FieldList = Prefixed_Name(ui, "FieldList") |> PrefixedName
    /// <summary>
    ///   <para>ui:FormForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Form</para>
    ///   <para>ui:Group</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FormForm">http://www.w3.org/ns/ui#FormForm</seealso>
    let FormForm = Prefixed_Name(ui, "FormForm") |> PrefixedName
    /// <summary>
    ///   <para>ui:FloatField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#FloatField">http://www.w3.org/ns/ui#FloatField</seealso>
    let FloatField = Prefixed_Name(ui, "FloatField") |> PrefixedName
    /// <summary>
    ///   <para>ui:optional</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#optional">http://www.w3.org/ns/ui#optional</seealso>
    let optional = Prefixed_Name(ui, "optional") |> PrefixedName
    /// <summary>
    ///   <para>ui:dependingOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Many fields prompt for information about a given property of the subject</para>
    /// labels<para>depending on</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#dependingOn">http://www.w3.org/ns/ui#dependingOn</seealso>
    let dependingOn = Prefixed_Name(ui, "dependingOn") |> PrefixedName
    /// <summary>
    ///   <para>ui:default</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#default">http://www.w3.org/ns/ui#default</seealso>
    let default_ = Prefixed_Name(ui, "default") |> PrefixedName
    /// <summary>
    ///   <para>ui:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>part</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#part">http://www.w3.org/ns/ui#part</seealso>
    let part = Prefixed_Name(ui, "part") |> PrefixedName
    /// <summary>
    ///   <para>ui:Multiple</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Multiple">http://www.w3.org/ns/ui#Multiple</seealso>
    let Multiple = Prefixed_Name(ui, "Multiple") |> PrefixedName
    /// <summary>
    ///   <para>ui:ordered</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>ordered</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#ordered">http://www.w3.org/ns/ui#ordered</seealso>
    let ordered = Prefixed_Name(ui, "ordered") |> PrefixedName
    /// <summary>
    ///   <para>ui:MultiLineTextField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#MultiLineTextField">http://www.w3.org/ns/ui#MultiLineTextField</seealso>
    let MultiLineTextField = Prefixed_Name(ui, "MultiLineTextField") |> PrefixedName
    /// <summary>
    ///   <para>ui:Group</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Group">http://www.w3.org/ns/ui#Group</seealso>
    let Group = Prefixed_Name(ui, "Group") |> PrefixedName
    /// <summary>
    ///   <para>ui:use</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ui#use">http://www.w3.org/ns/ui#use</seealso>
    let use_ = Prefixed_Name(ui, "use") |> PrefixedName
    /// <summary>
    ///   <para>ui:Options</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/ui#Options">http://www.w3.org/ns/ui#Options</seealso>
    let Options = Prefixed_Name(ui, "Options") |> PrefixedName

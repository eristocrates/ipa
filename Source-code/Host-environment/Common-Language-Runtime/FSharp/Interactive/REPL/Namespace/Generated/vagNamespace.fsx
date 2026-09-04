#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vag =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2013/10/vagueness/" "vag"

    let ``_1.0`` = _prefixId.prefix "1.0"
    /// <summary>
    ///   <para>rdfs:comment : A context defines precise boundaries of application of descriptions of vagueness/non-vagueness or of the relation between a justification and a certain dimension.</para>
    ///   <para>rdfs:label : applicability context of descriptions and related dimensions</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/ApplicabilityContext">vag:ApplicabilityContext</a>
    /// </summary>
    let ApplicabilityContext = _prefixId.prefix "ApplicabilityContext"
    /// <summary>
    ///   <para>rdfs:comment : The descriptive characterisation of non-vagueness to associate to an ontological entity by means of an annotation. It provides at least one justification for considering the target ontological entity non-vague. This description is primarily meant to be used for entities that would typically be considered vague but which, for some reason, in the particular ontology are not.
    ///
    /// A description of non-vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another).</para>
    ///   <para>rdfs:label : description of non-vagueness</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfNonVagueness">vag:DescriptionOfNonVagueness</a>
    /// </summary>
    let DescriptionOfNonVagueness = _prefixId.prefix "DescriptionOfNonVagueness"
    /// <summary>
    ///   <para>rdfs:comment : The descriptive characterisation of vagueness to associate to an ontological entity by means of an annotation. It specifies a vagueness type and provides at least one justification for considering the target ontological entity vague.
    ///
    /// A description of vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another).</para>
    ///   <para>rdfs:label : description of vagueness</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfVagueness">vag:DescriptionOfVagueness</a>
    /// </summary>
    let DescriptionOfVagueness = _prefixId.prefix "DescriptionOfVagueness"
    /// <summary>
    ///   <para>rdfs:comment : A dimension is part of the justification of a description of quantitative vagueness. Dimensions of such a justification are used to identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself. A dimension is defined either as natural language text, an entity, a more complex logic formula, or any combination of them.
    ///
    /// The relation between a justification and a dimension may be context-dependent, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in dimension A in one context and in dimension B in another). In this case, instances of the classes 'DimensionInContext' should be used to link the justification to the related dimension.</para>
    ///   <para>rdfs:label : dimension</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/Dimension">vag:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:comment : This class describes situations where a particular dimension in considered according to a particular context. In particular, instances of this class are actually specifying that the relation between a justification and a certain dimension must be considered according to a particular applicability context.</para>
    ///   <para>rdfs:label : dimension in context</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/DimensionInContext">vag:DimensionInContext</a>
    /// </summary>
    let DimensionInContext = _prefixId.prefix "DimensionInContext"
    /// <summary>
    ///   <para>rdfs:comment : A justification that explains one possible reason behind a vagueness/non-vagueness description. It is defined either as natural language text, an entity, a more complex logic formula, or any combination of them.</para>
    ///   <para>rdfs:label : justification for vagueness/non-vagueness description</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/Justification">vag:Justification</a>
    /// </summary>
    let Justification = _prefixId.prefix "Justification"
    /// <summary>
    ///   <para>rdfs:comment : The annotation of an ontological entity with information about its vagueness is a particular act of tagging done by someone (i.e., an agent) who associates a description of vagueness/non-vagueness (called the body of the annotation) to the entity in consideration (called the target of the annotation).</para>
    ///   <para>rdfs:label : annotation of vagueness/non-vagueness</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/VaguenessAnnotation">vag:VaguenessAnnotation</a>
    /// </summary>
    let VaguenessAnnotation = _prefixId.prefix "VaguenessAnnotation"
    /// <summary>
    ///   <para>rdfs:comment : A particular kind of vagueness that characterizes the entity.</para>
    ///   <para>rdfs:label : vagueness type</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/VaguenessType">vag:VaguenessType</a>
    /// </summary>
    let VaguenessType = _prefixId.prefix "VaguenessType"
    /// <summary>
    ///   <para>rdfs:comment : This property links either descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness to the context to which they apply.</para>
    ///   <para>rdfs:label : has applicability context</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasApplicabilityContext">vag:hasApplicabilityContext</a>
    /// </summary>
    let hasApplicabilityContext = _prefixId.prefix "hasApplicabilityContext"
    /// <summary>
    ///   <para>rdfs:comment : It links justifications of a description of quantitative vagueness to the dimensions that identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself.</para>
    ///   <para>rdfs:label : has dimension</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasDimension">vag:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:comment : It links justifications of a description of quantitative vagueness to situations where a particular dimension, which identifies the boundaries that are not defined precisely by a particular entity, has to be considered within a particular applicability context.</para>
    ///   <para>rdfs:label : has dimension in context</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasDimensionInContext">vag:hasDimensionInContext</a>
    /// </summary>
    let hasDimensionInContext = _prefixId.prefix "hasDimensionInContext"
    /// <summary>
    ///   <para>rdfs:comment : The entity defining the body of either a justification or dimension.</para>
    ///   <para>rdfs:label : has entity</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasEntity">vag:hasEntity</a>
    /// </summary>
    let hasEntity = _prefixId.prefix "hasEntity"
    /// <summary>
    ///   <para>rdfs:comment : It links a particular description of vagueness/non-vagueness to a related justification.</para>
    ///   <para>rdfs:label : has justification</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasJustification">vag:hasJustification</a>
    /// </summary>
    let hasJustification = _prefixId.prefix "hasJustification"
    /// <summary>
    ///   <para>rdfs:comment : The logic formula defining the body of either a justification or dimension.</para>
    ///   <para>rdfs:label : has logic formula</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasLogicFormula">vag:hasLogicFormula</a>
    /// </summary>
    let hasLogicFormula = _prefixId.prefix "hasLogicFormula"
    /// <summary>
    ///   <para>rdfs:comment : The natural language text defining the body of either a justification or dimension.</para>
    ///   <para>rdfs:label : has natural language text</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasNaturalLanguageText">vag:hasNaturalLanguageText</a>
    /// </summary>
    let hasNaturalLanguageText = _prefixId.prefix "hasNaturalLanguageText"
    /// <summary>
    ///   <para>rdfs:comment : The link between a description of vagueness and the particular type of vagueness it describes.</para>
    ///   <para>rdfs:label : has vagueness type</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/hasVaguenessType">vag:hasVaguenessType</a>
    /// </summary>
    let hasVaguenessType = _prefixId.prefix "hasVaguenessType"
    /// <summary>
    ///   <para>rdfs:comment : This property links applicability contexts to the related descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness.</para>
    ///   <para>rdfs:label : is applicability context of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isApplicabilityContextOf">vag:isApplicabilityContextOf</a>
    /// </summary>
    let isApplicabilityContextOf = _prefixId.prefix "isApplicabilityContextOf"
    /// <summary>
    ///   <para>rdfs:comment : It links a dimension to the situations that include related applicability contexts.</para>
    ///   <para>rdfs:label : is dimension in</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isDimensionIn">vag:isDimensionIn</a>
    /// </summary>
    let isDimensionIn = _prefixId.prefix "isDimensionIn"
    /// <summary>
    ///   <para>rdfs:comment : It links situations describing a dimension according to a particular context to the justification that involves them.</para>
    ///   <para>rdfs:label : is dimension in context of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isDimensionInContextOf">vag:isDimensionInContextOf</a>
    /// </summary>
    let isDimensionInContextOf = _prefixId.prefix "isDimensionInContextOf"
    /// <summary>
    ///   <para>rdfs:comment : It links dimensions to the justification that involves them.</para>
    ///   <para>rdfs:label : is dimension of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isDimensionOf">vag:isDimensionOf</a>
    /// </summary>
    let isDimensionOf = _prefixId.prefix "isDimensionOf"
    /// <summary>
    ///   <para>rdfs:comment : It links to the justification/dimension that involves the entity.</para>
    ///   <para>rdfs:label : is entity of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isEntityOf">vag:isEntityOf</a>
    /// </summary>
    let isEntityOf = _prefixId.prefix "isEntityOf"
    /// <summary>
    ///   <para>rdfs:comment : It links to the description of vagueness/non-vagueness supported by the justification.</para>
    ///   <para>rdfs:label : is justification of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isJustificationOf">vag:isJustificationOf</a>
    /// </summary>
    let isJustificationOf = _prefixId.prefix "isJustificationOf"
    /// <summary>
    ///   <para>rdfs:comment : It links to the justification/dimension that involves the logic formula.</para>
    ///   <para>rdfs:label : is logic formula of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isLogicFormulaOf">vag:isLogicFormulaOf</a>
    /// </summary>
    let isLogicFormulaOf = _prefixId.prefix "isLogicFormulaOf"
    /// <summary>
    ///   <para>rdfs:comment : It links to the description of vagueness that has the particular vagueness type.</para>
    ///   <para>rdfs:label : is vagueness type of</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/isVaguenessTypeOf">vag:isVaguenessTypeOf</a>
    /// </summary>
    let isVaguenessTypeOf = _prefixId.prefix "isVaguenessTypeOf"
    let qualitative_vagueness = _prefixId.prefix "qualitative-vagueness"
    let quantitative_vagueness = _prefixId.prefix "quantitative-vagueness"
    /// <summary>
    ///   <para>rdfs:comment : It links the dimension that is used in a justification according to a particular applicability context.</para>
    ///   <para>rdfs:label : with dimension</para>
    ///   <a href="http://www.essepuntato.it/2013/10/vagueness/withDimension">vag:withDimension</a>
    /// </summary>
    let withDimension = _prefixId.prefix "withDimension"

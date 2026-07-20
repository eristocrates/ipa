namespace http.www.essepuntato.it._2013._10.vagueness.slash

open DoxAletheia

module vag =
    let _namespace_name = "http://www.essepuntato.it/2013/10/vagueness/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A context defines precise boundaries of application of descriptions of vagueness/non-vagueness or of the relation between a justification and a certain dimension.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/ApplicabilityContext"></see></summary>
    let ApplicabilityContext = _prefix "ApplicabilityContext"
    /// <summary>
    /// The descriptive characterisation of non-vagueness to associate to an ontological entity by means of an annotation. It provides at least one justification for considering the target ontological entity non-vague. This description is primarily meant to be used for entities that would typically be considered vague but which, for some reason, in the particular ontology are not.
    ///
    /// A description of non-vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another).
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfNonVagueness"></see></summary>
    let DescriptionOfNonVagueness = _prefix "DescriptionOfNonVagueness"
    /// <summary>
    /// The descriptive characterisation of vagueness to associate to an ontological entity by means of an annotation. It specifies a vagueness type and provides at least one justification for considering the target ontological entity vague.
    ///
    /// A description of vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another).
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfVagueness"></see></summary>
    let DescriptionOfVagueness = _prefix "DescriptionOfVagueness"
    /// <summary>
    /// A dimension is part of the justification of a description of quantitative vagueness. Dimensions of such a justification are used to identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself. A dimension is defined either as natural language text, an entity, a more complex logic formula, or any combination of them.
    ///
    /// The relation between a justification and a dimension may be context-dependent, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in dimension A in one context and in dimension B in another). In this case, instances of the classes 'DimensionInContext' should be used to link the justification to the related dimension.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    /// This class describes situations where a particular dimension in considered according to a particular context. In particular, instances of this class are actually specifying that the relation between a justification and a certain dimension must be considered according to a particular applicability context.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/DimensionInContext"></see></summary>
    let DimensionInContext = _prefix "DimensionInContext"
    /// <summary>
    /// A justification that explains one possible reason behind a vagueness/non-vagueness description. It is defined either as natural language text, an entity, a more complex logic formula, or any combination of them.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/Justification"></see></summary>
    let Justification = _prefix "Justification"
    /// <summary>
    /// The annotation of an ontological entity with information about its vagueness is a particular act of tagging done by someone (i.e., an agent) who associates a description of vagueness/non-vagueness (called the body of the annotation) to the entity in consideration (called the target of the annotation).
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/VaguenessAnnotation"></see></summary>
    let VaguenessAnnotation = _prefix "VaguenessAnnotation"
    /// <summary>
    /// A particular kind of vagueness that characterizes the entity.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/VaguenessType"></see></summary>
    let VaguenessType = _prefix "VaguenessType"
    /// <summary>
    /// A vagueness type that concerns the identification of such other discriminants of which boundaries are not quantifiable in any precise way.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/qualitative-vagueness"></see></summary>
    let ``qualitative-vagueness`` = _prefix "qualitative-vagueness"
    /// <summary>
    /// A vagueness type that concerns the (real or apparent) lack of precise boundaries defining an entity along one or more specific dimensions.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/quantitative-vagueness"></see></summary>
    let ``quantitative-vagueness`` = _prefix "quantitative-vagueness"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2013/10/vagueness/1.0"></see>
    /// </summary>
    let ``_1.0`` = _prefix "1.0"
    /// <summary>
    /// It links a particular description of vagueness/non-vagueness to a related justification.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasJustification"></see></summary>
    let hasJustification = _prefix "hasJustification"
    /// <summary>
    /// The link between a description of vagueness and the particular type of vagueness it describes.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasVaguenessType"></see></summary>
    let hasVaguenessType = _prefix "hasVaguenessType"
    /// <summary>
    /// The entity defining the body of either a justification or dimension.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasEntity"></see></summary>
    let hasEntity = _prefix "hasEntity"
    /// <summary>
    /// The logic formula defining the body of either a justification or dimension.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasLogicFormula"></see></summary>
    let hasLogicFormula = _prefix "hasLogicFormula"
    /// <summary>
    /// The natural language text defining the body of either a justification or dimension.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasNaturalLanguageText"></see></summary>
    let hasNaturalLanguageText = _prefix "hasNaturalLanguageText"
    /// <summary>
    /// It links the dimension that is used in a justification according to a particular applicability context.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/withDimension"></see></summary>
    let withDimension = _prefix "withDimension"
    /// <summary>
    /// This property links either descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness to the context to which they apply.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasApplicabilityContext"></see></summary>
    let hasApplicabilityContext = _prefix "hasApplicabilityContext"
    /// <summary>
    /// It links justifications of a description of quantitative vagueness to the dimensions that identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasDimension"></see></summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    /// It links justifications of a description of quantitative vagueness to situations where a particular dimension, which identifies the boundaries that are not defined precisely by a particular entity, has to be considered within a particular applicability context.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/hasDimensionInContext"></see></summary>
    let hasDimensionInContext = _prefix "hasDimensionInContext"
    /// <summary>
    /// This property links applicability contexts to the related descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isApplicabilityContextOf"></see></summary>
    let isApplicabilityContextOf = _prefix "isApplicabilityContextOf"
    /// <summary>
    /// It links a dimension to the situations that include related applicability contexts.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isDimensionIn"></see></summary>
    let isDimensionIn = _prefix "isDimensionIn"
    /// <summary>
    /// It links situations describing a dimension according to a particular context to the justification that involves them.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isDimensionInContextOf"></see></summary>
    let isDimensionInContextOf = _prefix "isDimensionInContextOf"
    /// <summary>
    /// It links dimensions to the justification that involves them.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isDimensionOf"></see></summary>
    let isDimensionOf = _prefix "isDimensionOf"
    /// <summary>
    /// It links to the justification/dimension that involves the entity.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isEntityOf"></see></summary>
    let isEntityOf = _prefix "isEntityOf"
    /// <summary>
    /// It links to the description of vagueness/non-vagueness supported by the justification.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isJustificationOf"></see></summary>
    let isJustificationOf = _prefix "isJustificationOf"
    /// <summary>
    /// It links to the justification/dimension that involves the logic formula.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isLogicFormulaOf"></see></summary>
    let isLogicFormulaOf = _prefix "isLogicFormulaOf"
    /// <summary>
    /// It links to the description of vagueness that has the particular vagueness type.
    /// <see href="http://www.essepuntato.it/2013/10/vagueness/isVaguenessTypeOf"></see></summary>
    let isVaguenessTypeOf = _prefix "isVaguenessTypeOf"

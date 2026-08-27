namespace http.www.essepuntato.it._2013._10.vagueness.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vag =
    let _namespace_iri = Namespace_Iri vag |> NamespaceIRI
    /// <summary>
    ///   <para>vag:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/1.0">http://www.essepuntato.it/2013/10/vagueness/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(vag, "1.0") |> PrefixedName

    /// <summary>
    ///   <para>vag:ApplicabilityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A context defines precise boundaries of application of descriptions of vagueness/non-vagueness or of the relation between a justification and a certain dimension."</para>
    /// labels<para>"applicability context of descriptions and related dimensions"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/ApplicabilityContext">http://www.essepuntato.it/2013/10/vagueness/ApplicabilityContext</seealso>
    let ApplicabilityContext =
        Prefixed_Name(vag, "ApplicabilityContext") |> PrefixedName

    /// <summary>
    ///   <para>vag:DescriptionOfNonVagueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The descriptive characterisation of non-vagueness to associate to an ontological entity by means of an annotation. It provides at least one justification for considering the target ontological entity non-vague. This description is primarily meant to be used for entities that would typically be considered vague but which, for some reason, in the particular ontology are not.
    ///
    /// A description of non-vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another)."</para>
    /// labels<para>"description of non-vagueness"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfNonVagueness">http://www.essepuntato.it/2013/10/vagueness/DescriptionOfNonVagueness</seealso>
    let DescriptionOfNonVagueness =
        Prefixed_Name(vag, "DescriptionOfNonVagueness") |> PrefixedName

    /// <summary>
    ///   <para>vag:DescriptionOfVagueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The descriptive characterisation of vagueness to associate to an ontological entity by means of an annotation. It specifies a vagueness type and provides at least one justification for considering the target ontological entity vague.
    ///
    /// A description of vagueness is a context-dependent object, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in one context and non-vague in another)."</para>
    /// labels<para>"description of vagueness"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/DescriptionOfVagueness">http://www.essepuntato.it/2013/10/vagueness/DescriptionOfVagueness</seealso>
    let DescriptionOfVagueness =
        Prefixed_Name(vag, "DescriptionOfVagueness") |> PrefixedName

    /// <summary>
    ///   <para>vag:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dimension is part of the justification of a description of quantitative vagueness. Dimensions of such a justification are used to identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself. A dimension is defined either as natural language text, an entity, a more complex logic formula, or any combination of them.
    ///
    /// The relation between a justification and a dimension may be context-dependent, which means that it can be applied within the boundaries of a particular context (i.e. the same entity can be vague in dimension A in one context and in dimension B in another). In this case, instances of the classes 'DimensionInContext' should be used to link the justification to the related dimension."</para>
    /// labels<para>"dimension"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/Dimension">http://www.essepuntato.it/2013/10/vagueness/Dimension</seealso>
    let Dimension = Prefixed_Name(vag, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>vag:DimensionInContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes situations where a particular dimension in considered according to a particular context. In particular, instances of this class are actually specifying that the relation between a justification and a certain dimension must be considered according to a particular applicability context."</para>
    /// labels<para>"dimension in context"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/DimensionInContext">http://www.essepuntato.it/2013/10/vagueness/DimensionInContext</seealso>
    let DimensionInContext = Prefixed_Name(vag, "DimensionInContext") |> PrefixedName
    /// <summary>
    ///   <para>vag:Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A justification that explains one possible reason behind a vagueness/non-vagueness description. It is defined either as natural language text, an entity, a more complex logic formula, or any combination of them."</para>
    /// labels<para>"justification for vagueness/non-vagueness description"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/Justification">http://www.essepuntato.it/2013/10/vagueness/Justification</seealso>
    let Justification = Prefixed_Name(vag, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>vag:VaguenessAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The annotation of an ontological entity with information about its vagueness is a particular act of tagging done by someone (i.e., an agent) who associates a description of vagueness/non-vagueness (called the body of the annotation) to the entity in consideration (called the target of the annotation)."</para>
    /// labels<para>"annotation of vagueness/non-vagueness"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/VaguenessAnnotation">http://www.essepuntato.it/2013/10/vagueness/VaguenessAnnotation</seealso>
    let VaguenessAnnotation = Prefixed_Name(vag, "VaguenessAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>vag:VaguenessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular kind of vagueness that characterizes the entity."</para>
    /// labels<para>"vagueness type"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/VaguenessType">http://www.essepuntato.it/2013/10/vagueness/VaguenessType</seealso>
    let VaguenessType = Prefixed_Name(vag, "VaguenessType") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasApplicabilityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links either descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness to the context to which they apply."</para>
    /// labels<para>"has applicability context"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasApplicabilityContext">http://www.essepuntato.it/2013/10/vagueness/hasApplicabilityContext</seealso>
    let hasApplicabilityContext =
        Prefixed_Name(vag, "hasApplicabilityContext") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links justifications of a description of quantitative vagueness to the dimensions that identify what boundaries are not defined precisely by a particular entity and, thus, are part of the causes of vagueness for the entity itself."</para>
    /// labels<para>"has dimension"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasDimension">http://www.essepuntato.it/2013/10/vagueness/hasDimension</seealso>
    let hasDimension = Prefixed_Name(vag, "hasDimension") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasDimensionInContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links justifications of a description of quantitative vagueness to situations where a particular dimension, which identifies the boundaries that are not defined precisely by a particular entity, has to be considered within a particular applicability context."</para>
    /// labels<para>"has dimension in context"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasDimensionInContext">http://www.essepuntato.it/2013/10/vagueness/hasDimensionInContext</seealso>
    let hasDimensionInContext =
        Prefixed_Name(vag, "hasDimensionInContext") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The entity defining the body of either a justification or dimension."</para>
    /// labels<para>"has entity"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasEntity">http://www.essepuntato.it/2013/10/vagueness/hasEntity</seealso>
    let hasEntity = Prefixed_Name(vag, "hasEntity") |> PrefixedName
    /// <summary>
    ///   <para>vag:hasJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links a particular description of vagueness/non-vagueness to a related justification."</para>
    /// labels<para>"has justification"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasJustification">http://www.essepuntato.it/2013/10/vagueness/hasJustification</seealso>
    let hasJustification = Prefixed_Name(vag, "hasJustification") |> PrefixedName
    /// <summary>
    ///   <para>vag:hasLogicFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The logic formula defining the body of either a justification or dimension."</para>
    /// labels<para>"has logic formula"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasLogicFormula">http://www.essepuntato.it/2013/10/vagueness/hasLogicFormula</seealso>
    let hasLogicFormula = Prefixed_Name(vag, "hasLogicFormula") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasNaturalLanguageText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The natural language text defining the body of either a justification or dimension."</para>
    /// labels<para>"has natural language text"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasNaturalLanguageText">http://www.essepuntato.it/2013/10/vagueness/hasNaturalLanguageText</seealso>
    let hasNaturalLanguageText =
        Prefixed_Name(vag, "hasNaturalLanguageText") |> PrefixedName

    /// <summary>
    ///   <para>vag:hasVaguenessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The link between a description of vagueness and the particular type of vagueness it describes."</para>
    /// labels<para>"has vagueness type"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/hasVaguenessType">http://www.essepuntato.it/2013/10/vagueness/hasVaguenessType</seealso>
    let hasVaguenessType = Prefixed_Name(vag, "hasVaguenessType") |> PrefixedName

    /// <summary>
    ///   <para>vag:isApplicabilityContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links applicability contexts to the related descriptions of vagueness/non-vagueness or dimensions of descriptions of quantitative vagueness."</para>
    /// labels<para>"is applicability context of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isApplicabilityContextOf">http://www.essepuntato.it/2013/10/vagueness/isApplicabilityContextOf</seealso>
    let isApplicabilityContextOf =
        Prefixed_Name(vag, "isApplicabilityContextOf") |> PrefixedName

    /// <summary>
    ///   <para>vag:isDimensionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links a dimension to the situations that include related applicability contexts."</para>
    /// labels<para>"is dimension in"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isDimensionIn">http://www.essepuntato.it/2013/10/vagueness/isDimensionIn</seealso>
    let isDimensionIn = Prefixed_Name(vag, "isDimensionIn") |> PrefixedName

    /// <summary>
    ///   <para>vag:isDimensionInContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links situations describing a dimension according to a particular context to the justification that involves them."</para>
    /// labels<para>"is dimension in context of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isDimensionInContextOf">http://www.essepuntato.it/2013/10/vagueness/isDimensionInContextOf</seealso>
    let isDimensionInContextOf =
        Prefixed_Name(vag, "isDimensionInContextOf") |> PrefixedName

    /// <summary>
    ///   <para>vag:isDimensionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links dimensions to the justification that involves them."</para>
    /// labels<para>"is dimension of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isDimensionOf">http://www.essepuntato.it/2013/10/vagueness/isDimensionOf</seealso>
    let isDimensionOf = Prefixed_Name(vag, "isDimensionOf") |> PrefixedName
    /// <summary>
    ///   <para>vag:isEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links to the justification/dimension that involves the entity."</para>
    /// labels<para>"is entity of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isEntityOf">http://www.essepuntato.it/2013/10/vagueness/isEntityOf</seealso>
    let isEntityOf = Prefixed_Name(vag, "isEntityOf") |> PrefixedName
    /// <summary>
    ///   <para>vag:isJustificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links to the description of vagueness/non-vagueness supported by the justification."</para>
    /// labels<para>"is justification of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isJustificationOf">http://www.essepuntato.it/2013/10/vagueness/isJustificationOf</seealso>
    let isJustificationOf = Prefixed_Name(vag, "isJustificationOf") |> PrefixedName
    /// <summary>
    ///   <para>vag:isLogicFormulaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links to the justification/dimension that involves the logic formula."</para>
    /// labels<para>"is logic formula of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isLogicFormulaOf">http://www.essepuntato.it/2013/10/vagueness/isLogicFormulaOf</seealso>
    let isLogicFormulaOf = Prefixed_Name(vag, "isLogicFormulaOf") |> PrefixedName
    /// <summary>
    ///   <para>vag:isVaguenessTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links to the description of vagueness that has the particular vagueness type."</para>
    /// labels<para>"is vagueness type of"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/isVaguenessTypeOf">http://www.essepuntato.it/2013/10/vagueness/isVaguenessTypeOf</seealso>
    let isVaguenessTypeOf = Prefixed_Name(vag, "isVaguenessTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>vag:qualitative-vagueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>vag:VaguenessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A vagueness type that concerns the identification of such other discriminants of which boundaries are not quantifiable in any precise way."</para>
    /// labels<para>"qualitative vagueness"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/qualitative-vagueness">http://www.essepuntato.it/2013/10/vagueness/qualitative-vagueness</seealso>
    let qualitative_vagueness =
        Prefixed_Name(vag, "qualitative-vagueness") |> PrefixedName

    /// <summary>
    ///   <para>vag:quantitative-vagueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vag:VaguenessType</para>
    ///   <para>"A vagueness type that concerns the (real or apparent) lack of precise boundaries defining an entity along one or more specific dimensions."</para>
    /// labels<para>"quantitative vagueness"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/quantitative-vagueness">http://www.essepuntato.it/2013/10/vagueness/quantitative-vagueness</seealso>
    let quantitative_vagueness =
        Prefixed_Name(vag, "quantitative-vagueness") |> PrefixedName

    /// <summary>
    ///   <para>vag:withDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links the dimension that is used in a justification according to a particular applicability context."</para>
    /// labels<para>"with dimension"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/10/vagueness/withDimension">http://www.essepuntato.it/2013/10/vagueness/withDimension</seealso>
    let withDimension = Prefixed_Name(vag, "withDimension") |> PrefixedName

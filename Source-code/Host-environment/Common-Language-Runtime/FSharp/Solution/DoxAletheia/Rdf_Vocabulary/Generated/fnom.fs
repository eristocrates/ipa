namespace https.w3id.org._function.vocabulary.mapping.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fnom =
    let _namespace_iri = Namespace_Iri fnom |> NamespaceIRI

    /// <summary>
    ///   <para>fnom:PositionParameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A position parameter mapping uses a position to map a parameter of an fno:Implementation to an fno:Parameter</para>
    /// labels<para>Position Parameter Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#PositionParameterMapping">https://w3id.org/function/vocabulary/mapping#PositionParameterMapping</seealso>
    let PositionParameterMapping =
        Prefixed_Name(fnom, "PositionParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>- Version 0.2.1: Updated metadata
    /// - Version 0.2.0: ReturnMapping
    /// - Version 0.1.0: creation.</para>
    /// labels<para>The Function Ontology - Mapping vocabulary</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#">https://w3id.org/function/vocabulary/mapping#</seealso>
    let _prefix_iri = Prefixed_Name(fnom, "") |> PrefixedName

    /// <summary>
    ///   <para>fnom:ConstantParameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A constant parameter mapping uses a property string to map a parameter of an fno:Implementation to a constant value</para>
    /// labels<para>Constant Parameter Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#ConstantParameterMapping">https://w3id.org/function/vocabulary/mapping#ConstantParameterMapping</seealso>
    let ConstantParameterMapping =
        Prefixed_Name(fnom, "ConstantParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:DefaultReturnMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A default return mapping links the return value of the method to a fno:Output</para>
    /// labels<para>Default Return Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#DefaultReturnMapping">https://w3id.org/function/vocabulary/mapping#DefaultReturnMapping</seealso>
    let DefaultReturnMapping =
        Prefixed_Name(fnom, "DefaultReturnMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:PropertyParameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A property parameter mapping uses a property string to map a parameter of an fno:Implementation to an fno:Parameter</para>
    /// labels<para>Property Parameter Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#PropertyParameterMapping">https://w3id.org/function/vocabulary/mapping#PropertyParameterMapping</seealso>
    let PropertyParameterMapping =
        Prefixed_Name(fnom, "PropertyParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:functionOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function output to a return mapping.</para>
    /// labels<para>function output</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#functionOutput">https://w3id.org/function/vocabulary/mapping#functionOutput</seealso>
    let functionOutput = Prefixed_Name(fnom, "functionOutput") |> PrefixedName

    /// <summary>
    ///   <para>fnom:implementationParameterPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Connects an implementation parameter position to a parameter mapping.</para>
    /// labels<para>implementation parameter position</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#implementationParameterPosition">https://w3id.org/function/vocabulary/mapping#implementationParameterPosition</seealso>
    let implementationParameterPosition =
        Prefixed_Name(fnom, "implementationParameterPosition") |> PrefixedName

    /// <summary>
    ///   <para>fnom:method-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects a method name to a method mapping.</para>
    /// labels<para>method name</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#method-name">https://w3id.org/function/vocabulary/mapping#method-name</seealso>
    let method_name = Prefixed_Name(fnom, "method-name") |> PrefixedName

    /// <summary>
    ///   <para>fnom:ExceptionReturnMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An exception return mapping links the thrown exception of the method to a fno:Output</para>
    /// labels<para>Exception Return Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#ExceptionReturnMapping">https://w3id.org/function/vocabulary/mapping#ExceptionReturnMapping</seealso>
    let ExceptionReturnMapping =
        Prefixed_Name(fnom, "ExceptionReturnMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:StringMethodMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A string method mapping uses a string to map a method of an fno:Implementation to an fno:Function</para>
    /// labels<para>String Method Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#StringMethodMapping">https://w3id.org/function/vocabulary/mapping#StringMethodMapping</seealso>
    let StringMethodMapping = Prefixed_Name(fnom, "StringMethodMapping") |> PrefixedName
    /// <summary>
    ///   <para>fnom:ParameterMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#ParameterMapping">https://w3id.org/function/vocabulary/mapping#ParameterMapping</seealso>
    let ParameterMapping = Prefixed_Name(fnom, "ParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>fnom:constantParameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects an implementation constant to a parameter value.</para>
    /// labels<para>constant parameter value</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#constantParameterValue">https://w3id.org/function/vocabulary/mapping#constantParameterValue</seealso>
    let constantParameterValue =
        Prefixed_Name(fnom, "constantParameterValue") |> PrefixedName

    /// <summary>
    ///   <para>fnom:functionParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function parameter to a parameter mapping.</para>
    /// labels<para>function parameter</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#functionParameter">https://w3id.org/function/vocabulary/mapping#functionParameter</seealso>
    let functionParameter = Prefixed_Name(fnom, "functionParameter") |> PrefixedName

    /// <summary>
    ///   <para>fnom:implementationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Connects an implementation parameter label to a parameter mapping.</para>
    /// labels<para>implementation property</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#implementationProperty">https://w3id.org/function/vocabulary/mapping#implementationProperty</seealso>
    let implementationProperty =
        Prefixed_Name(fnom, "implementationProperty") |> PrefixedName

    /// <summary>
    ///   <para>fnom:repeatableParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Flag indicating whether the parameter can be repeated.</para>
    /// labels<para>repeatable parameter value</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#repeatableParameter">https://w3id.org/function/vocabulary/mapping#repeatableParameter</seealso>
    let repeatableParameter = Prefixed_Name(fnom, "repeatableParameter") |> PrefixedName
    /// <summary>
    ///   <para>fnom:ReturnMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping#ReturnMapping">https://w3id.org/function/vocabulary/mapping#ReturnMapping</seealso>
    let ReturnMapping = Prefixed_Name(fnom, "ReturnMapping") |> PrefixedName

namespace https.www.omg.org.spec.Commons.Classifiers.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Classifiers =
    let _namespace_iri = Namespace_Iri Classifiers |> NamespaceIRI
    /// <summary>
    ///   <para>Classifiers:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/">https://www.omg.org/spec/Commons/Classifiers/</seealso>
    let _prefix_iri = Prefixed_Name(Classifiers, "") |> PrefixedName
    /// <summary>
    ///   <para>Classifiers:Aspect</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/Aspect">https://www.omg.org/spec/Commons/Classifiers/Aspect</seealso>
    let Aspect = Prefixed_Name(Classifiers, "Aspect") |> PrefixedName

    /// <summary>
    ///   <para>Classifiers:ClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/ClassificationScheme">https://www.omg.org/spec/Commons/Classifiers/ClassificationScheme</seealso>
    let ClassificationScheme =
        Prefixed_Name(Classifiers, "ClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>Classifiers:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/Classifier">https://www.omg.org/spec/Commons/Classifiers/Classifier</seealso>
    let Classifier = Prefixed_Name(Classifiers, "Classifier") |> PrefixedName
    /// <summary>
    ///   <para>Classifiers:characterizes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/characterizes">https://www.omg.org/spec/Commons/Classifiers/characterizes</seealso>
    let characterizes = Prefixed_Name(Classifiers, "characterizes") |> PrefixedName
    /// <summary>
    ///   <para>Classifiers:classifies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/classifies">https://www.omg.org/spec/Commons/Classifiers/classifies</seealso>
    let classifies = Prefixed_Name(Classifiers, "classifies") |> PrefixedName
    /// <summary>
    ///   <para>Classifiers:exemplifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/exemplifies">https://www.omg.org/spec/Commons/Classifiers/exemplifies</seealso>
    let exemplifies = Prefixed_Name(Classifiers, "exemplifies") |> PrefixedName

    /// <summary>
    ///   <para>Classifiers:isCharacterizedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/isCharacterizedBy">https://www.omg.org/spec/Commons/Classifiers/isCharacterizedBy</seealso>
    let isCharacterizedBy =
        Prefixed_Name(Classifiers, "isCharacterizedBy") |> PrefixedName

    /// <summary>
    ///   <para>Classifiers:isClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Classifiers/isClassifiedBy">https://www.omg.org/spec/Commons/Classifiers/isClassifiedBy</seealso>
    let isClassifiedBy = Prefixed_Name(Classifiers, "isClassifiedBy") |> PrefixedName

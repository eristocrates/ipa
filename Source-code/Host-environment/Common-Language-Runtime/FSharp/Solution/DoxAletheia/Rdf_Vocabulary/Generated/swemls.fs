namespace https.w3id.org.semsys.ns.swemls.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swemls =
    let _namespace_iri = Namespace_Iri swemls |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#ApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The application domain in which the SWeML systems solve tasks (e.g. Chemistry, Legal)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ApplicationDomain">https://w3id.org/semsys/ns/swemls#ApplicationDomain</seealso>
    let ApplicationDomain = Prefixed_Name(swemls, "ApplicationDomain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Positioning of the Paper in relation to research araeas e.g. Explainable AI or Semantic Web Mining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Area">https://w3id.org/semsys/ns/swemls#Area</seealso>
    let Area = Prefixed_Name(swemls, "Area") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Atomic-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Basic pattern type: a single algorithmic module consumes a single input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Atomic-Pattern">https://w3id.org/semsys/ns/swemls#Atomic-Pattern</seealso>
    let Atomic_Pattern = Prefixed_Name(swemls, "Atomic-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Australia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Australia">https://w3id.org/semsys/ns/swemls#Australia</seealso>
    let Australia = Prefixed_Name(swemls, "Australia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Austria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Austria">https://w3id.org/semsys/ns/swemls#Austria</seealso>
    let Austria = Prefixed_Name(swemls, "Austria") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Belgium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Belgium">https://w3id.org/semsys/ns/swemls#Belgium</seealso>
    let Belgium = Prefixed_Name(swemls, "Belgium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Brazil</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Brazil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Brazil">https://w3id.org/semsys/ns/swemls#Brazil</seealso>
    let Brazil = Prefixed_Name(swemls, "Brazil") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bulgaria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Bulgaria">https://w3id.org/semsys/ns/swemls#Bulgaria</seealso>
    let Bulgaria = Prefixed_Name(swemls, "Bulgaria") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Canada"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Canada">https://w3id.org/semsys/ns/swemls#Canada</seealso>
    let Canada = Prefixed_Name(swemls, "Canada") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#China</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"China"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#China">https://w3id.org/semsys/ns/swemls#China</seealso>
    let China = Prefixed_Name(swemls, "China") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Colombia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Colombia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Colombia">https://w3id.org/semsys/ns/swemls#Colombia</seealso>
    let Colombia = Prefixed_Name(swemls, "Colombia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Country to which authors describing the SWeML systems in their paper are affiliated to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Country">https://w3id.org/semsys/ns/swemls#Country</seealso>
    let Country = Prefixed_Name(swemls, "Country") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Facts and statistics collected together and used as a basis for reasoning, discussion or calculation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Data">https://w3id.org/semsys/ns/swemls#Data</seealso>
    let Data = Prefixed_Name(swemls, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Denmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Denmark">https://w3id.org/semsys/ns/swemls#Denmark</seealso>
    let Denmark = Prefixed_Name(swemls, "Denmark") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Documenation characteristics e.g. used dataset, training parameters, evaluation metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Documentation">https://w3id.org/semsys/ns/swemls#Documentation</seealso>
    let Documentation = Prefixed_Name(swemls, "Documentation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Egypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Egypt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Egypt">https://w3id.org/semsys/ns/swemls#Egypt</seealso>
    let Egypt = Prefixed_Name(swemls, "Egypt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Finland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Finland">https://w3id.org/semsys/ns/swemls#Finland</seealso>
    let Finland = Prefixed_Name(swemls, "Finland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#France</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"France"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#France">https://w3id.org/semsys/ns/swemls#France</seealso>
    let France = Prefixed_Name(swemls, "France") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Fusion-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Basic pattern type: a single algorithmic module consumes more than one input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fusion Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Fusion-Pattern">https://w3id.org/semsys/ns/swemls#Fusion-Pattern</seealso>
    let Fusion_Pattern = Prefixed_Name(swemls, "Fusion-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Germany"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Germany">https://w3id.org/semsys/ns/swemls#Germany</seealso>
    let Germany = Prefixed_Name(swemls, "Germany") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Greece"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Greece">https://w3id.org/semsys/ns/swemls#Greece</seealso>
    let Greece = Prefixed_Name(swemls, "Greece") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Hong_Kong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Hong Kong"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Hong_Kong">https://w3id.org/semsys/ns/swemls#Hong_Kong</seealso>
    let Hong_Kong = Prefixed_Name(swemls, "Hong_Kong") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#I-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Advanced pattern type: a chain of Atomic Patterns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I-Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#I-Pattern">https://w3id.org/semsys/ns/swemls#I-Pattern</seealso>
    let I_Pattern = Prefixed_Name(swemls, "I-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#India</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"India"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#India">https://w3id.org/semsys/ns/swemls#India</seealso>
    let India = Prefixed_Name(swemls, "India") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Indonesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Indonesia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Indonesia">https://w3id.org/semsys/ns/swemls#Indonesia</seealso>
    let Indonesia = Prefixed_Name(swemls, "Indonesia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Instance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Instance">https://w3id.org/semsys/ns/swemls#Instance</seealso>
    let Instance = Prefixed_Name(swemls, "Instance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Iran</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Iran"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Iran">https://w3id.org/semsys/ns/swemls#Iran</seealso>
    let Iran = Prefixed_Name(swemls, "Iran") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Ireland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Ireland">https://w3id.org/semsys/ns/swemls#Ireland</seealso>
    let Ireland = Prefixed_Name(swemls, "Ireland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Italy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Italy">https://w3id.org/semsys/ns/swemls#Italy</seealso>
    let Italy = Prefixed_Name(swemls, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Italy_and_UK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Italy and UK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Italy_and_UK">https://w3id.org/semsys/ns/swemls#Italy_and_UK</seealso>
    let Italy_and_UK = Prefixed_Name(swemls, "Italy_and_UK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Jamaica</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Jamaica"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Jamaica">https://w3id.org/semsys/ns/swemls#Jamaica</seealso>
    let Jamaica = Prefixed_Name(swemls, "Jamaica") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Japan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Japan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Japan">https://w3id.org/semsys/ns/swemls#Japan</seealso>
    let Japan = Prefixed_Name(swemls, "Japan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#KnowledgeRepresentationComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Knowledge Representation component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KR Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent">https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent</seealso>
    let KnowledgeRepresentationComponent =
        Prefixed_Name(swemls, "KnowledgeRepresentationComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Korea">https://w3id.org/semsys/ns/swemls#Korea</seealso>
    let Korea = Prefixed_Name(swemls, "Korea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Kosovo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Kosovo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Kosovo">https://w3id.org/semsys/ns/swemls#Kosovo</seealso>
    let Kosovo = Prefixed_Name(swemls, "Kosovo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#M-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"M-Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#M-Pattern">https://w3id.org/semsys/ns/swemls#M-Pattern</seealso>
    let M_Pattern = Prefixed_Name(swemls, "M-Pattern") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#MachineLearningComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Machine Learning component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ML Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#MachineLearningComponent">https://w3id.org/semsys/ns/swemls#MachineLearningComponent</seealso>
    let MachineLearningComponent =
        Prefixed_Name(swemls, "MachineLearningComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Mexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Mexico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Mexico">https://w3id.org/semsys/ns/swemls#Mexico</seealso>
    let Mexico = Prefixed_Name(swemls, "Mexico") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Missing_Info</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Missing_Info"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Missing_Info">https://w3id.org/semsys/ns/swemls#Missing_Info</seealso>
    let Missing_Info = Prefixed_Name(swemls, "Missing_Info") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models used in the SWeML systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Model">https://w3id.org/semsys/ns/swemls#Model</seealso>
    let Model = Prefixed_Name(swemls, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Morocco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Morocco"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Morocco">https://w3id.org/semsys/ns/swemls#Morocco</seealso>
    let Morocco = Prefixed_Name(swemls, "Morocco") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Netherlands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Netherlands">https://w3id.org/semsys/ns/swemls#Netherlands</seealso>
    let Netherlands = Prefixed_Name(swemls, "Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New Zealand"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#New_Zealand">https://w3id.org/semsys/ns/swemls#New_Zealand</seealso>
    let New_Zealand = Prefixed_Name(swemls, "New_Zealand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Norway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Norway">https://w3id.org/semsys/ns/swemls#Norway</seealso>
    let Norway = Prefixed_Name(swemls, "Norway") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Other-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Other Patterns that do not fit in any other category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Other Patterns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Other-Pattern">https://w3id.org/semsys/ns/swemls#Other-Pattern</seealso>
    let Other_Pattern = Prefixed_Name(swemls, "Other-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Pakistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Pakistan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Pakistan">https://w3id.org/semsys/ns/swemls#Pakistan</seealso>
    let Pakistan = Prefixed_Name(swemls, "Pakistan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Palestine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Palestine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Palestine">https://w3id.org/semsys/ns/swemls#Palestine</seealso>
    let Palestine = Prefixed_Name(swemls, "Palestine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Paper in which the SWeML system is described"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Paper">https://w3id.org/semsys/ns/swemls#Paper</seealso>
    let Paper = Prefixed_Name(swemls, "Paper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#PaperType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Paper type, e.g. Workshop or Conference paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paper Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#PaperType">https://w3id.org/semsys/ns/swemls#PaperType</seealso>
    let PaperType = Prefixed_Name(swemls, "PaperType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Patterns describing the SWeMLs flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Pattern">https://w3id.org/semsys/ns/swemls#Pattern</seealso>
    let Pattern = Prefixed_Name(swemls, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Poland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Poland">https://w3id.org/semsys/ns/swemls#Poland</seealso>
    let Poland = Prefixed_Name(swemls, "Poland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Portual</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Portual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Portual">https://w3id.org/semsys/ns/swemls#Portual</seealso>
    let Portual = Prefixed_Name(swemls, "Portual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Portugal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Portugal">https://w3id.org/semsys/ns/swemls#Portugal</seealso>
    let Portugal = Prefixed_Name(swemls, "Portugal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#ProcessingEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processing engine, that processes semantic web resources e.g.  SPARQL query engine, reasoner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Processing Engine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ProcessingEngine">https://w3id.org/semsys/ns/swemls#ProcessingEngine</seealso>
    let ProcessingEngine = Prefixed_Name(swemls, "ProcessingEngine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Republic_of_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Republic of Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Republic_of_Korea">https://w3id.org/semsys/ns/swemls#Republic_of_Korea</seealso>
    let Republic_of_Korea = Prefixed_Name(swemls, "Republic_of_Korea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#ResourceFormalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formalism of the semantic web resource data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symbol Formalism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceFormalism">https://w3id.org/semsys/ns/swemls#ResourceFormalism</seealso>
    let ResourceFormalism = Prefixed_Name(swemls, "ResourceFormalism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#ResourceSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Size of the semantic web resource(s) in triples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceSize">https://w3id.org/semsys/ns/swemls#ResourceSize</seealso>
    let ResourceSize = Prefixed_Name(swemls, "ResourceSize") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#ResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Resource type of the semantic web resources resource, e.g. ontology, queries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceType">https://w3id.org/semsys/ns/swemls#ResourceType</seealso>
    let ResourceType = Prefixed_Name(swemls, "ResourceType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Romania"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Romania">https://w3id.org/semsys/ns/swemls#Romania</seealso>
    let Romania = Prefixed_Name(swemls, "Romania") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Russia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Russia">https://w3id.org/semsys/ns/swemls#Russia</seealso>
    let Russia = Prefixed_Name(swemls, "Russia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Saudi_Arabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Saudi Arabia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Saudi_Arabia">https://w3id.org/semsys/ns/swemls#Saudi_Arabia</seealso>
    let Saudi_Arabia = Prefixed_Name(swemls, "Saudi_Arabia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Saudi_Ariabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Saudi Ariabia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Saudi_Ariabia">https://w3id.org/semsys/ns/swemls#Saudi_Ariabia</seealso>
    let Saudi_Ariabia = Prefixed_Name(swemls, "Saudi_Ariabia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Scotland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Scotland">https://w3id.org/semsys/ns/swemls#Scotland</seealso>
    let Scotland = Prefixed_Name(swemls, "Scotland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#SemanticModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Deductive Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semantic Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SemanticModel">https://w3id.org/semsys/ns/swemls#SemanticModel</seealso>
    let SemanticModel = Prefixed_Name(swemls, "SemanticModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#SemanticWebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Semantic entities or relations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semantic Web Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SemanticWebResource">https://w3id.org/semsys/ns/swemls#SemanticWebResource</seealso>
    let SemanticWebResource =
        Prefixed_Name(swemls, "SemanticWebResource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Singapore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Singapore">https://w3id.org/semsys/ns/swemls#Singapore</seealso>
    let Singapore = Prefixed_Name(swemls, "Singapore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Slovenia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Slovenia">https://w3id.org/semsys/ns/swemls#Slovenia</seealso>
    let Slovenia = Prefixed_Name(swemls, "Slovenia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#South_Korea">https://w3id.org/semsys/ns/swemls#South_Korea</seealso>
    let South_Korea = Prefixed_Name(swemls, "South_Korea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Spain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Spain">https://w3id.org/semsys/ns/swemls#Spain</seealso>
    let Spain = Prefixed_Name(swemls, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Sri_Lanka</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sri Lanka"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sri_Lanka">https://w3id.org/semsys/ns/swemls#Sri_Lanka</seealso>
    let Sri_Lanka = Prefixed_Name(swemls, "Sri_Lanka") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#StatisticalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Inductive Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statistical Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#StatisticalModel">https://w3id.org/semsys/ns/swemls#StatisticalModel</seealso>
    let StatisticalModel = Prefixed_Name(swemls, "StatisticalModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Sudan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sudan">https://w3id.org/semsys/ns/swemls#Sudan</seealso>
    let Sudan = Prefixed_Name(swemls, "Sudan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Sweden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sweden">https://w3id.org/semsys/ns/swemls#Sweden</seealso>
    let Sweden = Prefixed_Name(swemls, "Sweden") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Switzerland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Switzerland">https://w3id.org/semsys/ns/swemls#Switzerland</seealso>
    let Switzerland = Prefixed_Name(swemls, "Switzerland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A representation of symbolic data such as semantic entities or relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Symbol">https://w3id.org/semsys/ns/swemls#Symbol</seealso>
    let Symbol = Prefixed_Name(swemls, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#SymbolUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of usage of the semantic web resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symbol Usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SymbolUsage">https://w3id.org/semsys/ns/swemls#SymbolUsage</seealso>
    let SymbolUsage = Prefixed_Name(swemls, "SymbolUsage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SWeML System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#System">https://w3id.org/semsys/ns/swemls#System</seealso>
    let System = Prefixed_Name(swemls, "System") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#SystemComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One component of the system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SystemComponent">https://w3id.org/semsys/ns/swemls#SystemComponent</seealso>
    let SystemComponent = Prefixed_Name(swemls, "SystemComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#SystemMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maturity of the overall SWeML system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SystemMaturity">https://w3id.org/semsys/ns/swemls#SystemMaturity</seealso>
    let SystemMaturity = Prefixed_Name(swemls, "SystemMaturity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#T-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Advanded pattern type: a chain of Atomic and Fusion Patterns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"T-Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#T-Pattern">https://w3id.org/semsys/ns/swemls#T-Pattern</seealso>
    let T_Pattern = Prefixed_Name(swemls, "T-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Taiwan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Taiwan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Taiwan">https://w3id.org/semsys/ns/swemls#Taiwan</seealso>
    let Taiwan = Prefixed_Name(swemls, "Taiwan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Task that the SWeML system supposed to solve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Task">https://w3id.org/semsys/ns/swemls#Task</seealso>
    let Task = Prefixed_Name(swemls, "Task") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Thailand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Thailand"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Thailand">https://w3id.org/semsys/ns/swemls#Thailand</seealso>
    let Thailand = Prefixed_Name(swemls, "Thailand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#The_Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Netherlands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#The_Netherlands">https://w3id.org/semsys/ns/swemls#The_Netherlands</seealso>
    let The_Netherlands = Prefixed_Name(swemls, "The_Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#TrainingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Training type of the ML model(s)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Training Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#TrainingType">https://w3id.org/semsys/ns/swemls#TrainingType</seealso>
    let TrainingType = Prefixed_Name(swemls, "TrainingType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Tunisia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tunisia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Tunisia">https://w3id.org/semsys/ns/swemls#Tunisia</seealso>
    let Tunisia = Prefixed_Name(swemls, "Tunisia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Turkey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Turkey">https://w3id.org/semsys/ns/swemls#Turkey</seealso>
    let Turkey = Prefixed_Name(swemls, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#UAE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"UAE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#UAE">https://w3id.org/semsys/ns/swemls#UAE</seealso>
    let UAE = Prefixed_Name(swemls, "UAE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#UK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"UK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#UK">https://w3id.org/semsys/ns/swemls#UK</seealso>
    let UK = Prefixed_Name(swemls, "UK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#USA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#USA">https://w3id.org/semsys/ns/swemls#USA</seealso>
    let USA = Prefixed_Name(swemls, "USA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"United Kingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#United_Kingdom">https://w3id.org/semsys/ns/swemls#United_Kingdom</seealso>
    let United_Kingdom = Prefixed_Name(swemls, "United_Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Vietnam</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Vietnam"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Vietnam">https://w3id.org/semsys/ns/swemls#Vietnam</seealso>
    let Vietnam = Prefixed_Name(swemls, "Vietnam") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>"Wales"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Wales">https://w3id.org/semsys/ns/swemls#Wales</seealso>
    let Wales = Prefixed_Name(swemls, "Wales") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#X-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"X-Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#X-Pattern">https://w3id.org/semsys/ns/swemls#X-Pattern</seealso>
    let X_Pattern = Prefixed_Name(swemls, "X-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#Y-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Advanced pattern type: combination of two (or more) Atomic Patterns via a Fusion Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Y-Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Y-Pattern">https://w3id.org/semsys/ns/swemls#Y-Pattern</seealso>
    let Y_Pattern = Prefixed_Name(swemls, "Y-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#author_country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Country to which authors describing the SWeML systems in their paper are affiliated to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"author country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#author_country">https://w3id.org/semsys/ns/swemls#author_country</seealso>
    let author_country = Prefixed_Name(swemls, "author_country") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#componentInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"component input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentInput">https://w3id.org/semsys/ns/swemls#componentInput</seealso>
    let componentInput = Prefixed_Name(swemls, "componentInput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#componentModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the system with component models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"component model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentModel">https://w3id.org/semsys/ns/swemls#componentModel</seealso>
    let componentModel = Prefixed_Name(swemls, "componentModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#componentOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"component output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentOutput">https://w3id.org/semsys/ns/swemls#componentOutput</seealso>
    let componentOutput = Prefixed_Name(swemls, "componentOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#evaluation_data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used data sets: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"evaluation data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_data">https://w3id.org/semsys/ns/swemls#evaluation_data</seealso>
    let evaluation_data = Prefixed_Name(swemls, "evaluation_data") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#evaluation_data_split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used training, development and test set
    /// used in evaluation: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"evaluation data split"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_data_split">https://w3id.org/semsys/ns/swemls#evaluation_data_split</seealso>
    let evaluation_data_split =
        Prefixed_Name(swemls, "evaluation_data_split") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#evaluation_metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used metrics in evaluation: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"evaluation metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_metrics">https://w3id.org/semsys/ns/swemls#evaluation_metrics</seealso>
    let evaluation_metrics = Prefixed_Name(swemls, "evaluation_metrics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the system with the application domain it is working in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has application domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasApplicationDomain">https://w3id.org/semsys/ns/swemls#hasApplicationDomain</seealso>
    let hasApplicationDomain =
        Prefixed_Name(swemls, "hasApplicationDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking a SWeML system with a research area it is associated with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasArea">https://w3id.org/semsys/ns/swemls#hasArea</seealso>
    let hasArea = Prefixed_Name(swemls, "hasArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasAuthorsCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking a paper with the countries of author's affiliations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has authors country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasAuthorsCountry">https://w3id.org/semsys/ns/swemls#hasAuthorsCountry</seealso>
    let hasAuthorsCountry = Prefixed_Name(swemls, "hasAuthorsCountry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasCorrespondingPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SWeML system has a corresponding pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has corresponding pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern">https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern</seealso>
    let hasCorrespondingPattern =
        Prefixed_Name(swemls, "hasCorrespondingPattern") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasCorrespondingPatternStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the corresponding step of a pattern workflow with a specific system component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has corresponding pattern step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep">https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep</seealso>
    let hasCorrespondingPatternStep =
        Prefixed_Name(swemls, "hasCorrespondingPatternStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasDataIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Data as in- output(s) in the workflow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has data I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasDataIO">https://w3id.org/semsys/ns/swemls#hasDataIO</seealso>
    let hasDataIO = Prefixed_Name(swemls, "hasDataIO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"System has documentation providing details about e.g. training steps or split, used datasets and evaluation metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasDocumentation">https://w3id.org/semsys/ns/swemls#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(swemls, "hasDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Keywords assigned to the publication by the authors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has keyword"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasKeyword">https://w3id.org/semsys/ns/swemls#hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(swemls, "hasKeyword") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SWeML system can have one or more models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasModel">https://w3id.org/semsys/ns/swemls#hasModel</seealso>
    let hasModel = Prefixed_Name(swemls, "hasModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasProcessingEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"SWeMLs can have one or more processing engines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has processing engine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasProcessingEngine">https://w3id.org/semsys/ns/swemls#hasProcessingEngine</seealso>
    let hasProcessingEngine =
        Prefixed_Name(swemls, "hasProcessingEngine") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasResourceFormalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the symbol formalism with the semantic web resource data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource Formalism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceFormalism">https://w3id.org/semsys/ns/swemls#hasResourceFormalism</seealso>
    let hasResourceFormalism =
        Prefixed_Name(swemls, "hasResourceFormalism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasResourceSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the semantic web resource with the resource size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceSize">https://w3id.org/semsys/ns/swemls#hasResourceSize</seealso>
    let hasResourceSize = Prefixed_Name(swemls, "hasResourceSize") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the semantic web resource with the resource type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceType">https://w3id.org/semsys/ns/swemls#hasResourceType</seealso>
    let hasResourceType = Prefixed_Name(swemls, "hasResourceType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStatisticalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SWeML system linking to at least one statistical model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has statistical model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStatisticalModel">https://w3id.org/semsys/ns/swemls#hasStatisticalModel</seealso>
    let hasStatisticalModel =
        Prefixed_Name(swemls, "hasStatisticalModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepKR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking SWeMLs to Knowledge Representation component(s) in different steps of the workflow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has KR step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepKR">https://w3id.org/semsys/ns/swemls#hasStepKR</seealso>
    let hasStepKR = Prefixed_Name(swemls, "hasStepKR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepKR1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has KR step 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepKR1">https://w3id.org/semsys/ns/swemls#hasStepKR1</seealso>
    let hasStepKR1 = Prefixed_Name(swemls, "hasStepKR1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking SWeMLs to Machine Learning component(s) in different steps of the workflow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has ML step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML">https://w3id.org/semsys/ns/swemls#hasStepML</seealso>
    let hasStepML = Prefixed_Name(swemls, "hasStepML") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ML step 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML1">https://w3id.org/semsys/ns/swemls#hasStepML1</seealso>
    let hasStepML1 = Prefixed_Name(swemls, "hasStepML1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ML step 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML2">https://w3id.org/semsys/ns/swemls#hasStepML2</seealso>
    let hasStepML2 = Prefixed_Name(swemls, "hasStepML2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ML step 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML3">https://w3id.org/semsys/ns/swemls#hasStepML3</seealso>
    let hasStepML3 = Prefixed_Name(swemls, "hasStepML3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ML step 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML4">https://w3id.org/semsys/ns/swemls#hasStepML4</seealso>
    let hasStepML4 = Prefixed_Name(swemls, "hasStepML4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasStepML5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ML step 5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML5">https://w3id.org/semsys/ns/swemls#hasStepML5</seealso>
    let hasStepML5 = Prefixed_Name(swemls, "hasStepML5") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasSymbolIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Symbol as in- output(s) in the workflow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has symbol I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSymbolIO">https://w3id.org/semsys/ns/swemls#hasSymbolIO</seealso>
    let hasSymbolIO = Prefixed_Name(swemls, "hasSymbolIO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasSymbolUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking system to symbol usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has symbol usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSymbolUsage">https://w3id.org/semsys/ns/swemls#hasSymbolUsage</seealso>
    let hasSymbolUsage = Prefixed_Name(swemls, "hasSymbolUsage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasSystemComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"SWeMLs can have one or more system components"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has system component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemComponent">https://w3id.org/semsys/ns/swemls#hasSystemComponent</seealso>
    let hasSystemComponent = Prefixed_Name(swemls, "hasSystemComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasSystemIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes in- and outputs to SWeML systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has system I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemIO">https://w3id.org/semsys/ns/swemls#hasSystemIO</seealso>
    let hasSystemIO = Prefixed_Name(swemls, "hasSystemIO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasSystemMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"System has a certain maturity according to different characteristics (stability, UI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has system maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemMaturity">https://w3id.org/semsys/ns/swemls#hasSystemMaturity</seealso>
    let hasSystemMaturity = Prefixed_Name(swemls, "hasSystemMaturity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the system to the task it is solving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasTask">https://w3id.org/semsys/ns/swemls#hasTask</seealso>
    let hasTask = Prefixed_Name(swemls, "hasTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasTrainingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the training type of the system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has training type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasTrainingType">https://w3id.org/semsys/ns/swemls#hasTrainingType</seealso>
    let hasTrainingType = Prefixed_Name(swemls, "hasTrainingType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData1">https://w3id.org/semsys/ns/swemls#hasVariableData1</seealso>
    let hasVariableData1 = Prefixed_Name(swemls, "hasVariableData1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData2">https://w3id.org/semsys/ns/swemls#hasVariableData2</seealso>
    let hasVariableData2 = Prefixed_Name(swemls, "hasVariableData2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData3">https://w3id.org/semsys/ns/swemls#hasVariableData3</seealso>
    let hasVariableData3 = Prefixed_Name(swemls, "hasVariableData3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData4">https://w3id.org/semsys/ns/swemls#hasVariableData4</seealso>
    let hasVariableData4 = Prefixed_Name(swemls, "hasVariableData4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData5">https://w3id.org/semsys/ns/swemls#hasVariableData5</seealso>
    let hasVariableData5 = Prefixed_Name(swemls, "hasVariableData5") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 6"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData6">https://w3id.org/semsys/ns/swemls#hasVariableData6</seealso>
    let hasVariableData6 = Prefixed_Name(swemls, "hasVariableData6") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 7"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData7">https://w3id.org/semsys/ns/swemls#hasVariableData7</seealso>
    let hasVariableData7 = Prefixed_Name(swemls, "hasVariableData7") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableData8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable data 8"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData8">https://w3id.org/semsys/ns/swemls#hasVariableData8</seealso>
    let hasVariableData8 = Prefixed_Name(swemls, "hasVariableData8") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableSW1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable SW 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW1">https://w3id.org/semsys/ns/swemls#hasVariableSW1</seealso>
    let hasVariableSW1 = Prefixed_Name(swemls, "hasVariableSW1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableSW2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable SW 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW2">https://w3id.org/semsys/ns/swemls#hasVariableSW2</seealso>
    let hasVariableSW2 = Prefixed_Name(swemls, "hasVariableSW2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableSW3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable SW 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW3">https://w3id.org/semsys/ns/swemls#hasVariableSW3</seealso>
    let hasVariableSW3 = Prefixed_Name(swemls, "hasVariableSW3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#hasVariableSW4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has variable SW 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW4">https://w3id.org/semsys/ns/swemls#hasVariableSW4</seealso>
    let hasVariableSW4 = Prefixed_Name(swemls, "hasVariableSW4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#has_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ID of the SWeML system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_ID">https://w3id.org/semsys/ns/swemls#has_ID</seealso>
    let has_ID = Prefixed_Name(swemls, "has_ID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#has_link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Link of the paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_link">https://w3id.org/semsys/ns/swemls#has_link</seealso>
    let has_link = Prefixed_Name(swemls, "has_link") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#has_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The title of the paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_title">https://w3id.org/semsys/ns/swemls#has_title</seealso>
    let has_title = Prefixed_Name(swemls, "has_title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used infrastructure: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"infrastructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#infrastructure">https://w3id.org/semsys/ns/swemls#infrastructure</seealso>
    let infrastructure = Prefixed_Name(swemls, "infrastructure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#isOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the paper type to the paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is of type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#isOfType">https://w3id.org/semsys/ns/swemls#isOfType</seealso>
    let isOfType = Prefixed_Name(swemls, "isOfType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#parameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used parameters: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"parameters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#parameters">https://w3id.org/semsys/ns/swemls#parameters</seealso>
    let parameters = Prefixed_Name(swemls, "parameters") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#process_steps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on performed processing steps, such as
    /// pre-processing, cross-validation: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"process steps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#process_steps">https://w3id.org/semsys/ns/swemls#process_steps</seealso>
    let process_steps = Prefixed_Name(swemls, "process_steps") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#provenance_support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of input/output data provenance collection: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"provenance support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#provenance_support">https://w3id.org/semsys/ns/swemls#provenance_support</seealso>
    let provenance_support = Prefixed_Name(swemls, "provenance_support") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#reports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Linking the system reported in the paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#reports">https://w3id.org/semsys/ns/swemls#reports</seealso>
    let reports = Prefixed_Name(swemls, "reports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presence of documentation on used software and libraries: yes, no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#software">https://w3id.org/semsys/ns/swemls#software</seealso>
    let software = Prefixed_Name(swemls, "software") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Short summary of the paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"summary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#summary">https://w3id.org/semsys/ns/swemls#summary</seealso>
    let summary = Prefixed_Name(swemls, "summary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The venue where the paper is published"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#venue">https://w3id.org/semsys/ns/swemls#venue</seealso>
    let venue = Prefixed_Name(swemls, "venue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semsys/ns/swemls#year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Year in which the paper is published"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#year">https://w3id.org/semsys/ns/swemls#year</seealso>
    let year = Prefixed_Name(swemls, "year") |> PrefixedName

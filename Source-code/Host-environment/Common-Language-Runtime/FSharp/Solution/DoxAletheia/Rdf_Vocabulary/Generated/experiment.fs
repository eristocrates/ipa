namespace http.purl.org.swan._2._0.experiment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module experiment =
    let _namespace_iri = Namespace_Iri experiment |> NamespaceIRI
    /// <summary>
    ///   <para>swan:experiment#Assay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Assay">http://purl.org/swan/2.0/experiment#Assay</seealso>
    let Assay = Prefixed_Name(experiment, "Assay") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Biological_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biological_Factor">http://purl.org/swan/2.0/experiment#Biological_Factor</seealso>
    let Biological_Factor =
        Prefixed_Name(experiment, "Biological_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Biomaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biomaterial">http://purl.org/swan/2.0/experiment#Biomaterial</seealso>
    let Biomaterial = Prefixed_Name(experiment, "Biomaterial") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Biomaterial_Characteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biomaterial_Characteristics">http://purl.org/swan/2.0/experiment#Biomaterial_Characteristics</seealso>
    let Biomaterial_Characteristics =
        Prefixed_Name(experiment, "Biomaterial_Characteristics") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Case_Control_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Case_Control_Design">http://purl.org/swan/2.0/experiment#Case_Control_Design</seealso>
    let Case_Control_Design =
        Prefixed_Name(experiment, "Case_Control_Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Cohort_Based_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Cohort_Based_Design">http://purl.org/swan/2.0/experiment#Cohort_Based_Design</seealso>
    let Cohort_Based_Design =
        Prefixed_Name(experiment, "Cohort_Based_Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Cross-sectional_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Cross-sectional_Design">http://purl.org/swan/2.0/experiment#Cross-sectional_Design</seealso>
    let Cross_sectional_Design =
        Prefixed_Name(experiment, "Cross-sectional_Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data">http://purl.org/swan/2.0/experiment#Data</seealso>
    let Data = Prefixed_Name(experiment, "Data") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Data_Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Acquisition">http://purl.org/swan/2.0/experiment#Data_Acquisition</seealso>
    let Data_Acquisition = Prefixed_Name(experiment, "Data_Acquisition") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Data_Analysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Analysis">http://purl.org/swan/2.0/experiment#Data_Analysis</seealso>
    let Data_Analysis = Prefixed_Name(experiment, "Data_Analysis") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Data_Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Interpretation">http://purl.org/swan/2.0/experiment#Data_Interpretation</seealso>
    let Data_Interpretation =
        Prefixed_Name(experiment, "Data_Interpretation") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Data_Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Processing">http://purl.org/swan/2.0/experiment#Data_Processing</seealso>
    let Data_Processing = Prefixed_Name(experiment, "Data_Processing") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Derived_Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Derived_Data">http://purl.org/swan/2.0/experiment#Derived_Data</seealso>
    let Derived_Data = Prefixed_Name(experiment, "Derived_Data") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Design">http://purl.org/swan/2.0/experiment#Design</seealso>
    let Design = Prefixed_Name(experiment, "Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Environmental_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Environmental_Factor">http://purl.org/swan/2.0/experiment#Environmental_Factor</seealso>
    let Environmental_Factor =
        Prefixed_Name(experiment, "Environmental_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Factor">http://purl.org/swan/2.0/experiment#Factor</seealso>
    let Factor = Prefixed_Name(experiment, "Factor") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Interventional_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Interventional_Design">http://purl.org/swan/2.0/experiment#Interventional_Design</seealso>
    let Interventional_Design =
        Prefixed_Name(experiment, "Interventional_Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Measurement">http://purl.org/swan/2.0/experiment#Measurement</seealso>
    let Measurement = Prefixed_Name(experiment, "Measurement") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Methodological_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Methodological_Factor">http://purl.org/swan/2.0/experiment#Methodological_Factor</seealso>
    let Methodological_Factor =
        Prefixed_Name(experiment, "Methodological_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Observational_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Observational_Design">http://purl.org/swan/2.0/experiment#Observational_Design</seealso>
    let Observational_Design =
        Prefixed_Name(experiment, "Observational_Design") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#Population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Population">http://purl.org/swan/2.0/experiment#Population</seealso>
    let Population = Prefixed_Name(experiment, "Population") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Primary_Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Primary_Data">http://purl.org/swan/2.0/experiment#Primary_Data</seealso>
    let Primary_Data = Prefixed_Name(experiment, "Primary_Data") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Protocol">http://purl.org/swan/2.0/experiment#Protocol</seealso>
    let Protocol = Prefixed_Name(experiment, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Study">http://purl.org/swan/2.0/experiment#Study</seealso>
    let Study = Prefixed_Name(experiment, "Study") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#derived_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#derived_from">http://purl.org/swan/2.0/experiment#derived_from</seealso>
    let derived_from = Prefixed_Name(experiment, "derived_from") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#has_biomaterial_characteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_biomaterial_characteristics">http://purl.org/swan/2.0/experiment#has_biomaterial_characteristics</seealso>
    let has_biomaterial_characteristics =
        Prefixed_Name(experiment, "has_biomaterial_characteristics") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#has_input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_input">http://purl.org/swan/2.0/experiment#has_input</seealso>
    let has_input = Prefixed_Name(experiment, "has_input") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#has_keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_keyword">http://purl.org/swan/2.0/experiment#has_keyword</seealso>
    let has_keyword = Prefixed_Name(experiment, "has_keyword") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#has_output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_output">http://purl.org/swan/2.0/experiment#has_output</seealso>
    let has_output = Prefixed_Name(experiment, "has_output") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#has_part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_part">http://purl.org/swan/2.0/experiment#has_part</seealso>
    let has_part = Prefixed_Name(experiment, "has_part") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#has_partcipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_partcipant">http://purl.org/swan/2.0/experiment#has_partcipant</seealso>
    let has_partcipant = Prefixed_Name(experiment, "has_partcipant") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#has_study_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_study_description">http://purl.org/swan/2.0/experiment#has_study_description</seealso>
    let has_study_description =
        Prefixed_Name(experiment, "has_study_description") |> PrefixedName

    /// <summary>
    ///   <para>swan:experiment#has_study_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_study_name">http://purl.org/swan/2.0/experiment#has_study_name</seealso>
    let has_study_name = Prefixed_Name(experiment, "has_study_name") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#is_about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#is_about">http://purl.org/swan/2.0/experiment#is_about</seealso>
    let is_about = Prefixed_Name(experiment, "is_about") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#part_of">http://purl.org/swan/2.0/experiment#part_of</seealso>
    let part_of = Prefixed_Name(experiment, "part_of") |> PrefixedName
    /// <summary>
    ///   <para>swan:experiment#participates_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#participates_in">http://purl.org/swan/2.0/experiment#participates_in</seealso>
    let participates_in = Prefixed_Name(experiment, "participates_in") |> PrefixedName

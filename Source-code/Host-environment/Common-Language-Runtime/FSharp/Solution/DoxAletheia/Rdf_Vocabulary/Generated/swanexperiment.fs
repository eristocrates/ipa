namespace http.purl.org.swan._2._0.experiment.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swanexperiment =
    let _namespace_iri = Namespace_Iri swanexperiment |> NamespaceIRI
    /// <summary>
    ///   <para>swanexperiment:#Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Factor">http://purl.org/swan/2.0/experiment#Factor</seealso>
    let ``_#Factor`` = Prefixed_Name(swanexperiment, "#Factor") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#participates_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#participates_in">http://purl.org/swan/2.0/experiment#participates_in</seealso>
    let ``_#participates_in`` =
        Prefixed_Name(swanexperiment, "#participates_in") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Biomaterial_Characteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biomaterial_Characteristics">http://purl.org/swan/2.0/experiment#Biomaterial_Characteristics</seealso>
    let ``_#Biomaterial_Characteristics`` =
        Prefixed_Name(swanexperiment, "#Biomaterial_Characteristics") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Cross-sectional_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Cross-sectional_Design">http://purl.org/swan/2.0/experiment#Cross-sectional_Design</seealso>
    let ``_#Cross_sectional_Design`` =
        Prefixed_Name(swanexperiment, "#Cross-sectional_Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_output">http://purl.org/swan/2.0/experiment#has_output</seealso>
    let ``_#has_output`` = Prefixed_Name(swanexperiment, "#has_output") |> PrefixedName
    /// <summary>
    ///   <para>swanexperiment:#Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Study">http://purl.org/swan/2.0/experiment#Study</seealso>
    let ``_#Study`` = Prefixed_Name(swanexperiment, "#Study") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_partcipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_partcipant">http://purl.org/swan/2.0/experiment#has_partcipant</seealso>
    let ``_#has_partcipant`` =
        Prefixed_Name(swanexperiment, "#has_partcipant") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_input">http://purl.org/swan/2.0/experiment#has_input</seealso>
    let ``_#has_input`` = Prefixed_Name(swanexperiment, "#has_input") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Data_Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Processing">http://purl.org/swan/2.0/experiment#Data_Processing</seealso>
    let ``_#Data_Processing`` =
        Prefixed_Name(swanexperiment, "#Data_Processing") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Data_Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Acquisition">http://purl.org/swan/2.0/experiment#Data_Acquisition</seealso>
    let ``_#Data_Acquisition`` =
        Prefixed_Name(swanexperiment, "#Data_Acquisition") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Cohort_Based_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Cohort_Based_Design">http://purl.org/swan/2.0/experiment#Cohort_Based_Design</seealso>
    let ``_#Cohort_Based_Design`` =
        Prefixed_Name(swanexperiment, "#Cohort_Based_Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Primary_Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Primary_Data">http://purl.org/swan/2.0/experiment#Primary_Data</seealso>
    let ``_#Primary_Data`` =
        Prefixed_Name(swanexperiment, "#Primary_Data") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Data_Analysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Analysis">http://purl.org/swan/2.0/experiment#Data_Analysis</seealso>
    let ``_#Data_Analysis`` =
        Prefixed_Name(swanexperiment, "#Data_Analysis") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_study_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_study_description">http://purl.org/swan/2.0/experiment#has_study_description</seealso>
    let ``_#has_study_description`` =
        Prefixed_Name(swanexperiment, "#has_study_description") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Protocol">http://purl.org/swan/2.0/experiment#Protocol</seealso>
    let ``_#Protocol`` = Prefixed_Name(swanexperiment, "#Protocol") |> PrefixedName
    /// <summary>
    ///   <para>swanexperiment:#has_part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_part">http://purl.org/swan/2.0/experiment#has_part</seealso>
    let ``_#has_part`` = Prefixed_Name(swanexperiment, "#has_part") |> PrefixedName
    /// <summary>
    ///   <para>swanexperiment:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>v. 0.1</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment">http://purl.org/swan/2.0/experiment</seealso>
    let _prefix_iri = Prefixed_Name(swanexperiment, "") |> PrefixedName
    /// <summary>
    ///   <para>swanexperiment:#Assay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Assay">http://purl.org/swan/2.0/experiment#Assay</seealso>
    let ``_#Assay`` = Prefixed_Name(swanexperiment, "#Assay") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Biological_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biological_Factor">http://purl.org/swan/2.0/experiment#Biological_Factor</seealso>
    let ``_#Biological_Factor`` =
        Prefixed_Name(swanexperiment, "#Biological_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Biomaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Biomaterial">http://purl.org/swan/2.0/experiment#Biomaterial</seealso>
    let ``_#Biomaterial`` =
        Prefixed_Name(swanexperiment, "#Biomaterial") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#derived_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#derived_from">http://purl.org/swan/2.0/experiment#derived_from</seealso>
    let ``_#derived_from`` =
        Prefixed_Name(swanexperiment, "#derived_from") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Population">http://purl.org/swan/2.0/experiment#Population</seealso>
    let ``_#Population`` = Prefixed_Name(swanexperiment, "#Population") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_biomaterial_characteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_biomaterial_characteristics">http://purl.org/swan/2.0/experiment#has_biomaterial_characteristics</seealso>
    let ``_#has_biomaterial_characteristics`` =
        Prefixed_Name(swanexperiment, "#has_biomaterial_characteristics") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Case_Control_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Case_Control_Design">http://purl.org/swan/2.0/experiment#Case_Control_Design</seealso>
    let ``_#Case_Control_Design`` =
        Prefixed_Name(swanexperiment, "#Case_Control_Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Observational_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Observational_Design">http://purl.org/swan/2.0/experiment#Observational_Design</seealso>
    let ``_#Observational_Design`` =
        Prefixed_Name(swanexperiment, "#Observational_Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data">http://purl.org/swan/2.0/experiment#Data</seealso>
    let ``_#Data`` = Prefixed_Name(swanexperiment, "#Data") |> PrefixedName
    /// <summary>
    ///   <para>swanexperiment:#part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#part_of">http://purl.org/swan/2.0/experiment#part_of</seealso>
    let ``_#part_of`` = Prefixed_Name(swanexperiment, "#part_of") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Derived_Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Derived_Data">http://purl.org/swan/2.0/experiment#Derived_Data</seealso>
    let ``_#Derived_Data`` =
        Prefixed_Name(swanexperiment, "#Derived_Data") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Design">http://purl.org/swan/2.0/experiment#Design</seealso>
    let ``_#Design`` = Prefixed_Name(swanexperiment, "#Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Data_Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Data_Interpretation">http://purl.org/swan/2.0/experiment#Data_Interpretation</seealso>
    let ``_#Data_Interpretation`` =
        Prefixed_Name(swanexperiment, "#Data_Interpretation") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Environmental_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Environmental_Factor">http://purl.org/swan/2.0/experiment#Environmental_Factor</seealso>
    let ``_#Environmental_Factor`` =
        Prefixed_Name(swanexperiment, "#Environmental_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Interventional_Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Interventional_Design">http://purl.org/swan/2.0/experiment#Interventional_Design</seealso>
    let ``_#Interventional_Design`` =
        Prefixed_Name(swanexperiment, "#Interventional_Design") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Measurement">http://purl.org/swan/2.0/experiment#Measurement</seealso>
    let ``_#Measurement`` =
        Prefixed_Name(swanexperiment, "#Measurement") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#Methodological_Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#Methodological_Factor">http://purl.org/swan/2.0/experiment#Methodological_Factor</seealso>
    let ``_#Methodological_Factor`` =
        Prefixed_Name(swanexperiment, "#Methodological_Factor") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#is_about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#is_about">http://purl.org/swan/2.0/experiment#is_about</seealso>
    let ``_#is_about`` = Prefixed_Name(swanexperiment, "#is_about") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_study_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_study_name">http://purl.org/swan/2.0/experiment#has_study_name</seealso>
    let ``_#has_study_name`` =
        Prefixed_Name(swanexperiment, "#has_study_name") |> PrefixedName

    /// <summary>
    ///   <para>swanexperiment:#has_keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment#has_keyword">http://purl.org/swan/2.0/experiment#has_keyword</seealso>
    let ``_#has_keyword`` =
        Prefixed_Name(swanexperiment, "#has_keyword") |> PrefixedName

namespace http.purl.org.swan._2._0.experiment.bare

open DoxAletheia

module swanex =
    let _namespace_name = "http://purl.org/swan/2.0/experiment"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Assay"></see>
    /// </summary>
    let ``_#Assay`` = _prefix "#Assay"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Data_Acquisition"></see>
    /// </summary>
    let ``_#Data_Acquisition`` = _prefix "#Data_Acquisition"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Biological_Factor"></see>
    /// </summary>
    let ``_#Biological_Factor`` = _prefix "#Biological_Factor"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Factor"></see>
    /// </summary>
    let ``_#Factor`` = _prefix "#Factor"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Biomaterial"></see>
    /// </summary>
    let ``_#Biomaterial`` = _prefix "#Biomaterial"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#derived_from"></see>
    /// </summary>
    let ``_#derived_from`` = _prefix "#derived_from"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Population"></see>
    /// </summary>
    let ``_#Population`` = _prefix "#Population"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#participates_in"></see>
    /// </summary>
    let ``_#participates_in`` = _prefix "#participates_in"

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_biomaterial_characteristics"></see>
    /// </summary>
    let ``_#has_biomaterial_characteristics`` =
        _prefix "#has_biomaterial_characteristics"

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Biomaterial_Characteristics"></see>
    /// </summary>
    let ``_#Biomaterial_Characteristics`` = _prefix "#Biomaterial_Characteristics"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Case_Control_Design"></see>
    /// </summary>
    let ``_#Case_Control_Design`` = _prefix "#Case_Control_Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Observational_Design"></see>
    /// </summary>
    let ``_#Observational_Design`` = _prefix "#Observational_Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Cohort_Based_Design"></see>
    /// </summary>
    let ``_#Cohort_Based_Design`` = _prefix "#Cohort_Based_Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Cross-sectional_Design"></see>
    /// </summary>
    let ``_#Cross-sectional_Design`` = _prefix "#Cross-sectional_Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Data"></see>
    /// </summary>
    let ``_#Data`` = _prefix "#Data"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_output"></see>
    /// </summary>
    let ``_#has_output`` = _prefix "#has_output"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Primary_Data"></see>
    /// </summary>
    let ``_#Primary_Data`` = _prefix "#Primary_Data"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#part_of"></see>
    /// </summary>
    let ``_#part_of`` = _prefix "#part_of"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Study"></see>
    /// </summary>
    let ``_#Study`` = _prefix "#Study"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Data_Analysis"></see>
    /// </summary>
    let ``_#Data_Analysis`` = _prefix "#Data_Analysis"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Derived_Data"></see>
    /// </summary>
    let ``_#Derived_Data`` = _prefix "#Derived_Data"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_partcipant"></see>
    /// </summary>
    let ``_#has_partcipant`` = _prefix "#has_partcipant"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Design"></see>
    /// </summary>
    let ``_#Design`` = _prefix "#Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Data_Interpretation"></see>
    /// </summary>
    let ``_#Data_Interpretation`` = _prefix "#Data_Interpretation"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_input"></see>
    /// </summary>
    let ``_#has_input`` = _prefix "#has_input"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Data_Processing"></see>
    /// </summary>
    let ``_#Data_Processing`` = _prefix "#Data_Processing"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Environmental_Factor"></see>
    /// </summary>
    let ``_#Environmental_Factor`` = _prefix "#Environmental_Factor"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Interventional_Design"></see>
    /// </summary>
    let ``_#Interventional_Design`` = _prefix "#Interventional_Design"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Measurement"></see>
    /// </summary>
    let ``_#Measurement`` = _prefix "#Measurement"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Methodological_Factor"></see>
    /// </summary>
    let ``_#Methodological_Factor`` = _prefix "#Methodological_Factor"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#is_about"></see>
    /// </summary>
    let ``_#is_about`` = _prefix "#is_about"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#Protocol"></see>
    /// </summary>
    let ``_#Protocol`` = _prefix "#Protocol"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_study_name"></see>
    /// </summary>
    let ``_#has_study_name`` = _prefix "#has_study_name"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_study_description"></see>
    /// </summary>
    let ``_#has_study_description`` = _prefix "#has_study_description"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_keyword"></see>
    /// </summary>
    let ``_#has_keyword`` = _prefix "#has_keyword"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/experiment#has_part"></see>
    /// </summary>
    let ``_#has_part`` = _prefix "#has_part"

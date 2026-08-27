namespace http.purl.obolibrary.org.obo.IAO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module IAO =
    let _namespace_iri = Namespace_Iri IAO |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:IAO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conditional specification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000001">http://purl.obolibrary.org/obo/IAO_0000001</seealso>
    let conditional_specification = Prefixed_Name(IAO, "0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000078</para>
    ///
    /// labels<para>"example to be eventually removed"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000002">http://purl.obolibrary.org/obo/IAO_0000002</seealso>
    let example_to_be_eventually_removed = Prefixed_Name(IAO, "0000002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit Label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"measurement unit label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000003">http://purl.obolibrary.org/obo/IAO_0000003</seealso>
    let Measurement_Unit_Label = Prefixed_Name(IAO, "0000003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has measurement value"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000004">http://purl.obolibrary.org/obo/IAO_0000004</seealso>
    let has_measurement_value = Prefixed_Name(IAO, "0000004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"objective specification"</para><para>"Objective Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000005">http://purl.obolibrary.org/obo/IAO_0000005</seealso>
    let objective_specification = Prefixed_Name(IAO, "0000005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"narrative object"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000006">http://purl.obolibrary.org/obo/IAO_0000006</seealso>
    let narrative_object = Prefixed_Name(IAO, "0000006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action specification"</para><para>"Action Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000007">http://purl.obolibrary.org/obo/IAO_0000007</seealso>
    let action_specification = Prefixed_Name(IAO, "0000007") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_artifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000008">http://purl.obolibrary.org/obo/IAO_0000008</seealso>
    let obsolete_artifact = Prefixed_Name(IAO, "0000008") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Datum Label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"datum label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000009">http://purl.obolibrary.org/obo/IAO_0000009</seealso>
    let Datum_Label = Prefixed_Name(IAO, "0000009") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000010">http://purl.obolibrary.org/obo/IAO_0000010</seealso>
    let software = Prefixed_Name(IAO, "0000010") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_digital entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000012">http://purl.obolibrary.org/obo/IAO_0000012</seealso>
    let obsolete2_digital_entity = Prefixed_Name(IAO, "0000012") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"journal article"</para><para>"Journal Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000013">http://purl.obolibrary.org/obo/IAO_0000013</seealso>
    let journal_article = Prefixed_Name(IAO, "0000013") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information carrier"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000015">http://purl.obolibrary.org/obo/IAO_0000015</seealso>
    let information_carrier = Prefixed_Name(IAO, "0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"model number"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000017">http://purl.obolibrary.org/obo/IAO_0000017</seealso>
    let model_number = Prefixed_Name(IAO, "0000017") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_material_entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000018">http://purl.obolibrary.org/obo/IAO_0000018</seealso>
    let obsolete_material_entity = Prefixed_Name(IAO, "0000018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_binary digital entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000019">http://purl.obolibrary.org/obo/IAO_0000019</seealso>
    let obsolete2_binary_digital_entity = Prefixed_Name(IAO, "0000019") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_unit of measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000024">http://purl.obolibrary.org/obo/IAO_0000024</seealso>
    let obsolete_unit_of_measure = Prefixed_Name(IAO, "0000024") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"programming language"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000025">http://purl.obolibrary.org/obo/IAO_0000025</seealso>
    let programming_language = Prefixed_Name(IAO, "0000025") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data item"</para><para>"Data Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000027">http://purl.obolibrary.org/obo/IAO_0000027</seealso>
    let data_item = Prefixed_Name(IAO, "0000027") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"symbol"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000028">http://purl.obolibrary.org/obo/IAO_0000028</seealso>
    let symbol = Prefixed_Name(IAO, "0000028") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"numeral"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000029">http://purl.obolibrary.org/obo/IAO_0000029</seealso>
    let numeral = Prefixed_Name(IAO, "0000029") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information content entity"</para><para>"Information Content Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000030">http://purl.obolibrary.org/obo/IAO_0000030</seealso>
    let information_content_entity = Prefixed_Name(IAO, "0000030") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"integer numeral"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000031">http://purl.obolibrary.org/obo/IAO_0000031</seealso>
    let integer_numeral = Prefixed_Name(IAO, "0000031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scalar measurement datum"</para><para>"Scalar Measurement Datum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000032">http://purl.obolibrary.org/obo/IAO_0000032</seealso>
    let scalar_measurement_datum = Prefixed_Name(IAO, "0000032") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"directive information entity"</para><para>"Directive Information Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000033">http://purl.obolibrary.org/obo/IAO_0000033</seealso>
    let directive_information_entity = Prefixed_Name(IAO, "0000033") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time trigger"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000034">http://purl.obolibrary.org/obo/IAO_0000034</seealso>
    let time_trigger = Prefixed_Name(IAO, "0000034") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_study interpretation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000035">http://purl.obolibrary.org/obo/IAO_0000035</seealso>
    let obsolete_study_interpretation = Prefixed_Name(IAO, "0000035") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dot plot"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000037">http://purl.obolibrary.org/obo/IAO_0000037</seealso>
    let dot_plot = Prefixed_Name(IAO, "0000037") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"graph"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000038">http://purl.obolibrary.org/obo/IAO_0000038</seealso>
    let graph = Prefixed_Name(IAO, "0000038") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has measurement unit label"</para><para>"has measurement unit label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000039">http://purl.obolibrary.org/obo/IAO_0000039</seealso>
    let has_measurement_unit_label = Prefixed_Name(IAO, "0000039") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_text based digital entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000047">http://purl.obolibrary.org/obo/IAO_0000047</seealso>
    let obsolete2_text_based_digital_entity =
        Prefixed_Name(IAO, "0000047") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rule"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000055">http://purl.obolibrary.org/obo/IAO_0000055</seealso>
    let rule = Prefixed_Name(IAO, "0000055") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contour plot"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000057">http://purl.obolibrary.org/obo/IAO_0000057</seealso>
    let contour_plot = Prefixed_Name(IAO, "0000057") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_report figure"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000059">http://purl.obolibrary.org/obo/IAO_0000059</seealso>
    let obsolete2_report_figure = Prefixed_Name(IAO, "0000059") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"algorithm"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000064">http://purl.obolibrary.org/obo/IAO_0000064</seealso>
    let algorithm = Prefixed_Name(IAO, "0000064") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software interpreter"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000065">http://purl.obolibrary.org/obo/IAO_0000065</seealso>
    let software_interpreter = Prefixed_Name(IAO, "0000065") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curation status specification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000078">http://purl.obolibrary.org/obo/IAO_0000078</seealso>
    let curation_status_specification = Prefixed_Name(IAO, "0000078") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"density plot"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000079">http://purl.obolibrary.org/obo/IAO_0000079</seealso>
    let density_plot = Prefixed_Name(IAO, "0000079") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"report"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000088">http://purl.obolibrary.org/obo/IAO_0000088</seealso>
    let report = Prefixed_Name(IAO, "0000088") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_report element"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000091">http://purl.obolibrary.org/obo/IAO_0000091</seealso>
    let obsolete_report_element = Prefixed_Name(IAO, "0000091") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_binary executable"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000093">http://purl.obolibrary.org/obo/IAO_0000093</seealso>
    let obsolete2_binary_executable = Prefixed_Name(IAO, "0000093") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"source code module"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000096">http://purl.obolibrary.org/obo/IAO_0000096</seealso>
    let source_code_module = Prefixed_Name(IAO, "0000096") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_report table"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000097">http://purl.obolibrary.org/obo/IAO_0000097</seealso>
    let obsolete_report_table = Prefixed_Name(IAO, "0000097") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data format specification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000098">http://purl.obolibrary.org/obo/IAO_0000098</seealso>
    let data_format_specification = Prefixed_Name(IAO, "0000098") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data set"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000100">http://purl.obolibrary.org/obo/IAO_0000100</seealso>
    let data_set = Prefixed_Name(IAO, "0000100") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"image"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000101">http://purl.obolibrary.org/obo/IAO_0000101</seealso>
    let image = Prefixed_Name(IAO, "0000101") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data about an Ontology Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"data about an ontology part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000102">http://purl.obolibrary.org/obo/IAO_0000102</seealso>
    let Data_about_an_Ontology_Part = Prefixed_Name(IAO, "0000102") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000225</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"failed exploratory term"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000103">http://purl.obolibrary.org/obo/IAO_0000103</seealso>
    let failed_exploratory_term = Prefixed_Name(IAO, "0000103") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"2/3/2009 Comment from OBI review.
    ///
    /// Action specification not well enough specified.
    /// Conditional specification not well enough specified.
    /// Question whether all plan specifications have objective specifications.
    ///
    /// Request that IAO either clarify these or change definitions not to use them"</para>
    /// labels<para>"plan specification"</para><para>"Plan Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000104">http://purl.obolibrary.org/obo/IAO_0000104</seealso>
    let plan_specification = Prefixed_Name(IAO, "0000104") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete2_digital document"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000105">http://purl.obolibrary.org/obo/IAO_0000105</seealso>
    let obsolete2_digital_document = Prefixed_Name(IAO, "0000105") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Datum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000109">http://purl.obolibrary.org/obo/IAO_0000109</seealso>
    let Measurement_Datum = Prefixed_Name(IAO, "0000109") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"editor preferred label"</para><para>"editor preferred term~editor preferred label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"editor preferred term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"editor preferred label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"editor preferred term"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000111">http://purl.obolibrary.org/obo/IAO_0000111</seealso>
    let editor_preferred_label = Prefixed_Name(IAO, "0000111") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"example of usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"example of usage"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000112">http://purl.obolibrary.org/obo/IAO_0000112</seealso>
    let example_of_usage = Prefixed_Name(IAO, "0000112") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"in branch"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000113">http://purl.obolibrary.org/obo/IAO_0000113</seealso>
    let in_branch = Prefixed_Name(IAO, "0000113") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has curation status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has curation status"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000114">http://purl.obolibrary.org/obo/IAO_0000114</seealso>
    let has_curation_status = Prefixed_Name(IAO, "0000114") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"textual definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"definition"</para><para>"definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000115">http://purl.obolibrary.org/obo/IAO_0000115</seealso>
    let textual_definition = Prefixed_Name(IAO, "0000115") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"editor note"</para><para>"editor note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000116">http://purl.obolibrary.org/obo/IAO_0000116</seealso>
    let editor_note = Prefixed_Name(IAO, "0000116") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"term editor"</para><para>"term editor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000117">http://purl.obolibrary.org/obo/IAO_0000117</seealso>
    let term_editor = Prefixed_Name(IAO, "0000117") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"alternative term"</para><para>"alternative term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000118">http://purl.obolibrary.org/obo/IAO_0000118</seealso>
    let alternative_term = Prefixed_Name(IAO, "0000118") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"definition source"</para><para>"definition source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000119">http://purl.obolibrary.org/obo/IAO_0000119</seealso>
    let definition_source = Prefixed_Name(IAO, "0000119") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000078</para>
    ///
    /// labels<para>"metadata complete"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000120">http://purl.obolibrary.org/obo/IAO_0000120</seealso>
    let metadata_complete = Prefixed_Name(IAO, "0000120") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>cdao:IAO_0000078</para>
    ///
    /// labels<para>"organizational term"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000121">http://purl.obolibrary.org/obo/IAO_0000121</seealso>
    let organizational_term = Prefixed_Name(IAO, "0000121") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000122</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000078</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"ready for release"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000122">http://purl.obolibrary.org/obo/IAO_0000122</seealso>
    let ready_for_release = Prefixed_Name(IAO, "0000122") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>cdao:IAO_0000078</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"metadata incomplete"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000123">http://purl.obolibrary.org/obo/IAO_0000123</seealso>
    let metadata_incomplete = Prefixed_Name(IAO, "0000123") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000124</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000078</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"uncurated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"uncurated"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000124">http://purl.obolibrary.org/obo/IAO_0000124</seealso>
    let uncurated = Prefixed_Name(IAO, "0000124") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>cdao:IAO_0000078</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pending final vetting"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000125">http://purl.obolibrary.org/obo/IAO_0000125</seealso>
    let pending_final_vetting = Prefixed_Name(IAO, "0000125") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000128</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000128">http://purl.obolibrary.org/obo/IAO_0000128</seealso>
    let obsolete_identifier = Prefixed_Name(IAO, "0000128") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"version number"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000129">http://purl.obolibrary.org/obo/IAO_0000129</seealso>
    let version_number = Prefixed_Name(IAO, "0000129") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"serial number"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000131">http://purl.obolibrary.org/obo/IAO_0000131</seealso>
    let serial_number = Prefixed_Name(IAO, "0000131") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lot number"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000132">http://purl.obolibrary.org/obo/IAO_0000132</seealso>
    let lot_number = Prefixed_Name(IAO, "0000132") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000135</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"obsolete_specifically denotes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000135">http://purl.obolibrary.org/obo/IAO_0000135</seealso>
    let obsolete_specifically_denotes = Prefixed_Name(IAO, "0000135") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000136</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is about"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is about"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000136">http://purl.obolibrary.org/obo/IAO_0000136</seealso>
    let is_about = Prefixed_Name(IAO, "0000136") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"setting datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000140">http://purl.obolibrary.org/obo/IAO_0000140</seealso>
    let setting_datum = Prefixed_Name(IAO, "0000140") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_digital quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000141">http://purl.obolibrary.org/obo/IAO_0000141</seealso>
    let obsolete_digital_quality = Prefixed_Name(IAO, "0000141") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mentions"</para><para>"mentions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000142">http://purl.obolibrary.org/obo/IAO_0000142</seealso>
    let mentions = Prefixed_Name(IAO, "0000142") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Conclusion Textual Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"conclusion textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000144">http://purl.obolibrary.org/obo/IAO_0000144</seealso>
    let Conclusion_Textual_Entity = Prefixed_Name(IAO, "0000144") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"material information bearer"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000178">http://purl.obolibrary.org/obo/IAO_0000178</seealso>
    let material_information_bearer = Prefixed_Name(IAO, "0000178") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"histogram"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000179">http://purl.obolibrary.org/obo/IAO_0000179</seealso>
    let histogram = Prefixed_Name(IAO, "0000179") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heatmap"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000180">http://purl.obolibrary.org/obo/IAO_0000180</seealso>
    let heatmap = Prefixed_Name(IAO, "0000180") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000181</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Venn diagram"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000181">http://purl.obolibrary.org/obo/IAO_0000181</seealso>
    let Venn_diagram = Prefixed_Name(IAO, "0000181") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_survival curve"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000182">http://purl.obolibrary.org/obo/IAO_0000182</seealso>
    let obsolete_survival_curve = Prefixed_Name(IAO, "0000182") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dendrogram"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000183">http://purl.obolibrary.org/obo/IAO_0000183</seealso>
    let dendrogram = Prefixed_Name(IAO, "0000183") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scatter plot"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000184">http://purl.obolibrary.org/obo/IAO_0000184</seealso>
    let scatter_plot = Prefixed_Name(IAO, "0000184") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"photograph"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000185">http://purl.obolibrary.org/obo/IAO_0000185</seealso>
    let photograph = Prefixed_Name(IAO, "0000185") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"photographic print"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000186">http://purl.obolibrary.org/obo/IAO_0000186</seealso>
    let photographic_print = Prefixed_Name(IAO, "0000186") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""</para>
    /// labels<para>"denotes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000219">http://purl.obolibrary.org/obo/IAO_0000219</seealso>
    let denotes = Prefixed_Name(IAO, "0000219") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"obsolete_materially denotes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000220">http://purl.obolibrary.org/obo/IAO_0000220</seealso>
    let obsolete_materially_denotes = Prefixed_Name(IAO, "0000220") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is quality measurement of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is quality measurement of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000221">http://purl.obolibrary.org/obo/IAO_0000221</seealso>
    let is_quality_measurement_of = Prefixed_Name(IAO, "0000221") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"obsolete_describes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000222">http://purl.obolibrary.org/obo/IAO_0000222</seealso>
    let obsolete_describes = Prefixed_Name(IAO, "0000222") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"obsolete_represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000223">http://purl.obolibrary.org/obo/IAO_0000223</seealso>
    let obsolete_represents = Prefixed_Name(IAO, "0000223") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>oboinowl:Subset</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"core"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000224">http://purl.obolibrary.org/obo/IAO_0000224</seealso>
    let core = Prefixed_Name(IAO, "0000224") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolescence reason specification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000225">http://purl.obolibrary.org/obo/IAO_0000225</seealso>
    let obsolescence_reason_specification =
        Prefixed_Name(IAO, "0000225") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000226</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000225</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"placeholder removed"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000226">http://purl.obolibrary.org/obo/IAO_0000226</seealso>
    let placeholder_removed = Prefixed_Name(IAO, "0000226") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000225</para>
    ///
    /// labels<para>"terms merged"</para><para>"terms merged"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000227">http://purl.obolibrary.org/obo/IAO_0000227</seealso>
    let terms_merged = Prefixed_Name(IAO, "0000227") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000225</para>
    ///
    /// labels<para>"term imported"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000228">http://purl.obolibrary.org/obo/IAO_0000228</seealso>
    let term_imported = Prefixed_Name(IAO, "0000228") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000229</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000225</para>
    ///
    /// labels<para>"term split"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000229">http://purl.obolibrary.org/obo/IAO_0000229</seealso>
    let term_split = Prefixed_Name(IAO, "0000229") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000230</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000225</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"other"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000230">http://purl.obolibrary.org/obo/IAO_0000230</seealso>
    let other = Prefixed_Name(IAO, "0000230") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has obsolescence reason"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000231">http://purl.obolibrary.org/obo/IAO_0000231</seealso>
    let has_obsolescence_reason = Prefixed_Name(IAO, "0000231") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"curator note"</para><para>"curator note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000232">http://purl.obolibrary.org/obo/IAO_0000232</seealso>
    let curator_note = Prefixed_Name(IAO, "0000232") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The 'tracker item' can associate a tracker with a specific ontology term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"term tracker item"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000233">http://purl.obolibrary.org/obo/IAO_0000233</seealso>
    let term_tracker_item = Prefixed_Name(IAO, "0000233") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The 'term requester' can credit the person, organization or project who request the ontology term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ontology term requester"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000234">http://purl.obolibrary.org/obo/IAO_0000234</seealso>
    let ontology_term_requester = Prefixed_Name(IAO, "0000234") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"textual entity"</para><para>"Textual Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000300">http://purl.obolibrary.org/obo/IAO_0000300</seealso>
    let textual_entity = Prefixed_Name(IAO, "0000300") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"citation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000301">http://purl.obolibrary.org/obo/IAO_0000301</seealso>
    let citation = Prefixed_Name(IAO, "0000301") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author identification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000302">http://purl.obolibrary.org/obo/IAO_0000302</seealso>
    let author_identification = Prefixed_Name(IAO, "0000302") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000303</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institutional identification"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000303">http://purl.obolibrary.org/obo/IAO_0000303</seealso>
    let institutional_identification = Prefixed_Name(IAO, "0000303") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"caption"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000304">http://purl.obolibrary.org/obo/IAO_0000304</seealso>
    let caption = Prefixed_Name(IAO, "0000304") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000305</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document title"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000305">http://purl.obolibrary.org/obo/IAO_0000305</seealso>
    let document_title = Prefixed_Name(IAO, "0000305") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000306">http://purl.obolibrary.org/obo/IAO_0000306</seealso>
    let table = Prefixed_Name(IAO, "0000306") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table of abbreviations"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000307">http://purl.obolibrary.org/obo/IAO_0000307</seealso>
    let table_of_abbreviations = Prefixed_Name(IAO, "0000307") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"figure"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000308">http://purl.obolibrary.org/obo/IAO_0000308</seealso>
    let figure = Prefixed_Name(IAO, "0000308") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diagram"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000309">http://purl.obolibrary.org/obo/IAO_0000309</seealso>
    let diagram = Prefixed_Name(IAO, "0000309") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000310">http://purl.obolibrary.org/obo/IAO_0000310</seealso>
    let document = Prefixed_Name(IAO, "0000310") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publication"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000311">http://purl.obolibrary.org/obo/IAO_0000311</seealso>
    let publication = Prefixed_Name(IAO, "0000311") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000312</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publication about an investigation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000312">http://purl.obolibrary.org/obo/IAO_0000312</seealso>
    let publication_about_an_investigation =
        Prefixed_Name(IAO, "0000312") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000313</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patent"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000313">http://purl.obolibrary.org/obo/IAO_0000313</seealso>
    let patent = Prefixed_Name(IAO, "0000313") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000314</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000314">http://purl.obolibrary.org/obo/IAO_0000314</seealso>
    let document_part = Prefixed_Name(IAO, "0000314") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000315</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abstract"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000315">http://purl.obolibrary.org/obo/IAO_0000315</seealso>
    let abstract_ = Prefixed_Name(IAO, "0000315") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"introduction to a publication about an investigation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000316">http://purl.obolibrary.org/obo/IAO_0000316</seealso>
    let introduction_to_a_publication_about_an_investigation =
        Prefixed_Name(IAO, "0000316") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000317</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"methods section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000317">http://purl.obolibrary.org/obo/IAO_0000317</seealso>
    let methods_section = Prefixed_Name(IAO, "0000317") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000318</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"results section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000318">http://purl.obolibrary.org/obo/IAO_0000318</seealso>
    let results_section = Prefixed_Name(IAO, "0000318") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000319</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"discussion section of a publication about an investigation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000319">http://purl.obolibrary.org/obo/IAO_0000319</seealso>
    let discussion_section_of_a_publication_about_an_investigation =
        Prefixed_Name(IAO, "0000319") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"references section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000320">http://purl.obolibrary.org/obo/IAO_0000320</seealso>
    let references_section = Prefixed_Name(IAO, "0000320") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000321</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author list"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000321">http://purl.obolibrary.org/obo/IAO_0000321</seealso>
    let author_list = Prefixed_Name(IAO, "0000321") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000322</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institution list"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000322">http://purl.obolibrary.org/obo/IAO_0000322</seealso>
    let institution_list = Prefixed_Name(IAO, "0000322") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author contributions section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000323">http://purl.obolibrary.org/obo/IAO_0000323</seealso>
    let author_contributions_section = Prefixed_Name(IAO, "0000323") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000324</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acknowledgements section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000324">http://purl.obolibrary.org/obo/IAO_0000324</seealso>
    let acknowledgements_section = Prefixed_Name(IAO, "0000324") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"footnote"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000325">http://purl.obolibrary.org/obo/IAO_0000325</seealso>
    let footnote = Prefixed_Name(IAO, "0000325") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000326</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supplementary material to a document"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000326">http://purl.obolibrary.org/obo/IAO_0000326</seealso>
    let supplementary_material_to_a_document =
        Prefixed_Name(IAO, "0000326") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000327</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table of contents"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000327">http://purl.obolibrary.org/obo/IAO_0000327</seealso>
    let table_of_contents = Prefixed_Name(IAO, "0000327") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000328</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table of figures"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000328">http://purl.obolibrary.org/obo/IAO_0000328</seealso>
    let table_of_figures = Prefixed_Name(IAO, "0000328") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000329</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"running title"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000329">http://purl.obolibrary.org/obo/IAO_0000329</seealso>
    let running_title = Prefixed_Name(IAO, "0000329") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000330</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"copyright section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000330">http://purl.obolibrary.org/obo/IAO_0000330</seealso>
    let copyright_section = Prefixed_Name(IAO, "0000330") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000400</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cartesian spatial coordinate datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000400">http://purl.obolibrary.org/obo/IAO_0000400</seealso>
    let cartesian_spatial_coordinate_datum =
        Prefixed_Name(IAO, "0000400") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000401</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"one dimensional cartesian spatial coordinate datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000401">http://purl.obolibrary.org/obo/IAO_0000401</seealso>
    let one_dimensional_cartesian_spatial_coordinate_datum =
        Prefixed_Name(IAO, "0000401") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000402</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two dimensional cartesian spatial coordinate datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000402">http://purl.obolibrary.org/obo/IAO_0000402</seealso>
    let two_dimensional_cartesian_spatial_coordinate_datum =
        Prefixed_Name(IAO, "0000402") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000403</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"three dimensional cartesian spatial coordinate datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000403">http://purl.obolibrary.org/obo/IAO_0000403</seealso>
    let three_dimensional_cartesian_spatial_coordinate_datum =
        Prefixed_Name(IAO, "0000403") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000404</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has x coordinate value"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000404">http://purl.obolibrary.org/obo/IAO_0000404</seealso>
    let has_x_coordinate_value = Prefixed_Name(IAO, "0000404") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000405</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has z coordinate value"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000405">http://purl.obolibrary.org/obo/IAO_0000405</seealso>
    let has_z_coordinate_value = Prefixed_Name(IAO, "0000405") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000406</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has y coordinate value"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000406">http://purl.obolibrary.org/obo/IAO_0000406</seealso>
    let has_y_coordinate_value = Prefixed_Name(IAO, "0000406") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000407</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"relating a cartesian spatial coordinate datum to a unit label that together with the values represent a point"</para>
    /// labels<para>"has coordinate unit label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000407">http://purl.obolibrary.org/obo/IAO_0000407</seealso>
    let has_coordinate_unit_label = Prefixed_Name(IAO, "0000407") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000408</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"length measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000408">http://purl.obolibrary.org/obo/IAO_0000408</seealso>
    let length_measurement_datum = Prefixed_Name(IAO, "0000408") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000409</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"denotator type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000409">http://purl.obolibrary.org/obo/IAO_0000409</seealso>
    let denotator_type = Prefixed_Name(IAO, "0000409") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000410</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000409</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"universal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000410">http://purl.obolibrary.org/obo/IAO_0000410</seealso>
    let universal = Prefixed_Name(IAO, "0000410") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000411</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is denotator type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000411">http://purl.obolibrary.org/obo/IAO_0000411</seealso>
    let is_denotator_type = Prefixed_Name(IAO, "0000411") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000412</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"imported from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"imported from"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000412">http://purl.obolibrary.org/obo/IAO_0000412</seealso>
    let imported_from = Prefixed_Name(IAO, "0000412") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000413</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is duration of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000413">http://purl.obolibrary.org/obo/IAO_0000413</seealso>
    let is_duration_of = Prefixed_Name(IAO, "0000413") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000414</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000414">http://purl.obolibrary.org/obo/IAO_0000414</seealso>
    let mass_measurement_datum = Prefixed_Name(IAO, "0000414") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000415</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypothesis textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000415">http://purl.obolibrary.org/obo/IAO_0000415</seealso>
    let hypothesis_textual_entity = Prefixed_Name(IAO, "0000415") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000416</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000416">http://purl.obolibrary.org/obo/IAO_0000416</seealso>
    let time_measurement_datum = Prefixed_Name(IAO, "0000416") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000417</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is quality measured as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is quality measured as"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000417">http://purl.obolibrary.org/obo/IAO_0000417</seealso>
    let is_quality_measured_as = Prefixed_Name(IAO, "0000417") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000418</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is quality specification of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000418">http://purl.obolibrary.org/obo/IAO_0000418</seealso>
    let is_quality_specification_of = Prefixed_Name(IAO, "0000418") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000419</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"quality is specified as"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000419">http://purl.obolibrary.org/obo/IAO_0000419</seealso>
    let quality_is_specified_as = Prefixed_Name(IAO, "0000419") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000420</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000409</para>
    ///
    /// labels<para>"defined class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000420">http://purl.obolibrary.org/obo/IAO_0000420</seealso>
    let defined_class = Prefixed_Name(IAO, "0000420") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000421</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000409</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"named class expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000421">http://purl.obolibrary.org/obo/IAO_0000421</seealso>
    let named_class_expression = Prefixed_Name(IAO, "0000421") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000422</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"postal address"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000422">http://purl.obolibrary.org/obo/IAO_0000422</seealso>
    let postal_address = Prefixed_Name(IAO, "0000422") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000423</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:IAO_0000078</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"to be replaced with external ontology term"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000423">http://purl.obolibrary.org/obo/IAO_0000423</seealso>
    let to_be_replaced_with_external_ontology_term =
        Prefixed_Name(IAO, "0000423") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000424</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"expand expression to"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000424">http://purl.obolibrary.org/obo/IAO_0000424</seealso>
    let expand_expression_to = Prefixed_Name(IAO, "0000424") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"expand assertion to"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000425">http://purl.obolibrary.org/obo/IAO_0000425</seealso>
    let expand_assertion_to = Prefixed_Name(IAO, "0000425") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000426</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"first order logic expression"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000426">http://purl.obolibrary.org/obo/IAO_0000426</seealso>
    let first_order_logic_expression = Prefixed_Name(IAO, "0000426") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000427</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"antisymmetric property"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000427">http://purl.obolibrary.org/obo/IAO_0000427</seealso>
    let antisymmetric_property = Prefixed_Name(IAO, "0000427") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000428</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:IAO_0000078</para>
    ///
    /// labels<para>"requires discussion"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000428">http://purl.obolibrary.org/obo/IAO_0000428</seealso>
    let requires_discussion = Prefixed_Name(IAO, "0000428") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000429</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"email address"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000429">http://purl.obolibrary.org/obo/IAO_0000429</seealso>
    let email_address = Prefixed_Name(IAO, "0000429") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000442</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author role"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000442">http://purl.obolibrary.org/obo/IAO_0000442</seealso>
    let author_role = Prefixed_Name(IAO, "0000442") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000443</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data item extraction from journal article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000443">http://purl.obolibrary.org/obo/IAO_0000443</seealso>
    let data_item_extraction_from_journal_article =
        Prefixed_Name(IAO, "0000443") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000572</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"documenting"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000572">http://purl.obolibrary.org/obo/IAO_0000572</seealso>
    let documenting = Prefixed_Name(IAO, "0000572") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000573</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"line graph"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000573">http://purl.obolibrary.org/obo/IAO_0000573</seealso>
    let line_graph = Prefixed_Name(IAO, "0000573") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000574</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assigning a centrally registered identifier"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000574">http://purl.obolibrary.org/obo/IAO_0000574</seealso>
    let assigning_a_centrally_registered_identifier =
        Prefixed_Name(IAO, "0000574") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000575</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"associating information with a centrally registered identifier in its registry"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000575">http://purl.obolibrary.org/obo/IAO_0000575</seealso>
    let associating_information_with_a_centrally_registered_identifier_in_its_registry =
        Prefixed_Name(IAO, "0000575") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000576</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete_establishing a CRID registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000576">http://purl.obolibrary.org/obo/IAO_0000576</seealso>
    let obsolete_establishing_a_CRID_registry =
        Prefixed_Name(IAO, "0000576") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000577</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrally registered identifier symbol"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000577">http://purl.obolibrary.org/obo/IAO_0000577</seealso>
    let centrally_registered_identifier_symbol =
        Prefixed_Name(IAO, "0000577") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000578</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrally registered identifier"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000578">http://purl.obolibrary.org/obo/IAO_0000578</seealso>
    let centrally_registered_identifier = Prefixed_Name(IAO, "0000578") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000579</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrally registered identifier registry"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000579">http://purl.obolibrary.org/obo/IAO_0000579</seealso>
    let centrally_registered_identifier_registry =
        Prefixed_Name(IAO, "0000579") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000580</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"looking up a centrally registered identifier"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000580">http://purl.obolibrary.org/obo/IAO_0000580</seealso>
    let looking_up_a_centrally_registered_identifier =
        Prefixed_Name(IAO, "0000580") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000581</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time stamp"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000581">http://purl.obolibrary.org/obo/IAO_0000581</seealso>
    let has_time_stamp = Prefixed_Name(IAO, "0000581") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000582</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time stamped measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000582">http://purl.obolibrary.org/obo/IAO_0000582</seealso>
    let time_stamped_measurement_datum = Prefixed_Name(IAO, "0000582") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000583</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has measurement datum"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000583">http://purl.obolibrary.org/obo/IAO_0000583</seealso>
    let has_measurement_datum = Prefixed_Name(IAO, "0000583") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000584</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time sampled measurement data set"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000584">http://purl.obolibrary.org/obo/IAO_0000584</seealso>
    let time_sampled_measurement_data_set =
        Prefixed_Name(IAO, "0000584") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000589</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"OBO foundry unique label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000589">http://purl.obolibrary.org/obo/IAO_0000589</seealso>
    let OBO_foundry_unique_label = Prefixed_Name(IAO, "0000589") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000590</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"written name"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000590">http://purl.obolibrary.org/obo/IAO_0000590</seealso>
    let written_name = Prefixed_Name(IAO, "0000590") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000591</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software method"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000591">http://purl.obolibrary.org/obo/IAO_0000591</seealso>
    let software_method = Prefixed_Name(IAO, "0000591") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000592</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software module"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000592">http://purl.obolibrary.org/obo/IAO_0000592</seealso>
    let software_module = Prefixed_Name(IAO, "0000592") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000593</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software library"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000593">http://purl.obolibrary.org/obo/IAO_0000593</seealso>
    let software_library = Prefixed_Name(IAO, "0000593") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000594</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software application"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000594">http://purl.obolibrary.org/obo/IAO_0000594</seealso>
    let software_application = Prefixed_Name(IAO, "0000594") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000595</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software script"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000595">http://purl.obolibrary.org/obo/IAO_0000595</seealso>
    let software_script = Prefixed_Name(IAO, "0000595") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000596</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has ID digit count"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000596">http://purl.obolibrary.org/obo/IAO_0000596</seealso>
    let has_ID_digit_count = Prefixed_Name(IAO, "0000596") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000597</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has ID range allocated to"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000597">http://purl.obolibrary.org/obo/IAO_0000597</seealso>
    let has_ID_range_allocated_to = Prefixed_Name(IAO, "0000597") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000598</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has ID policy for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000598">http://purl.obolibrary.org/obo/IAO_0000598</seealso>
    let has_ID_policy_for = Prefixed_Name(IAO, "0000598") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000599</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has ID prefix"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000599">http://purl.obolibrary.org/obo/IAO_0000599</seealso>
    let has_ID_prefix = Prefixed_Name(IAO, "0000599") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000600</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"elucidation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000600">http://purl.obolibrary.org/obo/IAO_0000600</seealso>
    let elucidation = Prefixed_Name(IAO, "0000600") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000601</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has associated axiom(nl)"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000601">http://purl.obolibrary.org/obo/IAO_0000601</seealso>
    let ``has_associated_axiom(nl)`` = Prefixed_Name(IAO, "0000601") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000602</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has associated axiom(fol)"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000602">http://purl.obolibrary.org/obo/IAO_0000602</seealso>
    let ``has_associated_axiom(fol)`` = Prefixed_Name(IAO, "0000602") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000603</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is allocated id range"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000603">http://purl.obolibrary.org/obo/IAO_0000603</seealso>
    let is_allocated_id_range = Prefixed_Name(IAO, "0000603") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000604</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"retired from use as of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000604">http://purl.obolibrary.org/obo/IAO_0000604</seealso>
    let retired_from_use_as_of = Prefixed_Name(IAO, "0000604") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abbreviation textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000605">http://purl.obolibrary.org/obo/IAO_0000605</seealso>
    let abbreviation_textual_entity = Prefixed_Name(IAO, "0000605") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000606</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abbreviations section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000606">http://purl.obolibrary.org/obo/IAO_0000606</seealso>
    let abbreviations_section = Prefixed_Name(IAO, "0000606") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000607</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author information section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000607">http://purl.obolibrary.org/obo/IAO_0000607</seealso>
    let author_information_section = Prefixed_Name(IAO, "0000607") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author information textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000608">http://purl.obolibrary.org/obo/IAO_0000608</seealso>
    let author_information_textual_entity =
        Prefixed_Name(IAO, "0000608") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000609</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author summary section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000609">http://purl.obolibrary.org/obo/IAO_0000609</seealso>
    let author_summary_section = Prefixed_Name(IAO, "0000609") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author summary textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000610">http://purl.obolibrary.org/obo/IAO_0000610</seealso>
    let author_summary_textual_entity = Prefixed_Name(IAO, "0000610") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"availability section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000611">http://purl.obolibrary.org/obo/IAO_0000611</seealso>
    let availability_section = Prefixed_Name(IAO, "0000611") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000612</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"availability textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000612">http://purl.obolibrary.org/obo/IAO_0000612</seealso>
    let availability_textual_entity = Prefixed_Name(IAO, "0000612") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000613</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"case report section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000613">http://purl.obolibrary.org/obo/IAO_0000613</seealso>
    let case_report_section = Prefixed_Name(IAO, "0000613") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000614</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"case report textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000614">http://purl.obolibrary.org/obo/IAO_0000614</seealso>
    let case_report_textual_entity = Prefixed_Name(IAO, "0000614") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000615</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conclusion section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000615">http://purl.obolibrary.org/obo/IAO_0000615</seealso>
    let conclusion_section = Prefixed_Name(IAO, "0000615") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000616</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conflict of interest section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000616">http://purl.obolibrary.org/obo/IAO_0000616</seealso>
    let conflict_of_interest_section = Prefixed_Name(IAO, "0000616") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000617</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conflict of interest textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000617">http://purl.obolibrary.org/obo/IAO_0000617</seealso>
    let conflict_of_interest_textual_entity =
        Prefixed_Name(IAO, "0000617") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000618</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consent section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000618">http://purl.obolibrary.org/obo/IAO_0000618</seealso>
    let consent_section = Prefixed_Name(IAO, "0000618") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000619</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consent textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000619">http://purl.obolibrary.org/obo/IAO_0000619</seealso>
    let consent_textual_entity = Prefixed_Name(IAO, "0000619") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000620</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ethical approval section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000620">http://purl.obolibrary.org/obo/IAO_0000620</seealso>
    let ethical_approval_section = Prefixed_Name(IAO, "0000620") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ethical approval textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000621">http://purl.obolibrary.org/obo/IAO_0000621</seealso>
    let ethical_approval_textual_entity = Prefixed_Name(IAO, "0000621") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000622</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"figures section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000622">http://purl.obolibrary.org/obo/IAO_0000622</seealso>
    let figures_section = Prefixed_Name(IAO, "0000622") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000623</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"funding source declaration section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000623">http://purl.obolibrary.org/obo/IAO_0000623</seealso>
    let funding_source_declaration_section =
        Prefixed_Name(IAO, "0000623") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"funding source declaration textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000624">http://purl.obolibrary.org/obo/IAO_0000624</seealso>
    let funding_source_declaration_textual_entity =
        Prefixed_Name(IAO, "0000624") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future directions section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000625">http://purl.obolibrary.org/obo/IAO_0000625</seealso>
    let future_directions_section = Prefixed_Name(IAO, "0000625") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000626</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future directions textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000626">http://purl.obolibrary.org/obo/IAO_0000626</seealso>
    let future_directions_textual_entity = Prefixed_Name(IAO, "0000626") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000627</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genome announcement section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000627">http://purl.obolibrary.org/obo/IAO_0000627</seealso>
    let genome_announcement_section = Prefixed_Name(IAO, "0000627") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000628</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genome announcement textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000628">http://purl.obolibrary.org/obo/IAO_0000628</seealso>
    let genome_announcement_textual_entity =
        Prefixed_Name(IAO, "0000628") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000629</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"keyword textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000629">http://purl.obolibrary.org/obo/IAO_0000629</seealso>
    let keyword_textual_entity = Prefixed_Name(IAO, "0000629") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000630</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"keywords section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000630">http://purl.obolibrary.org/obo/IAO_0000630</seealso>
    let keywords_section = Prefixed_Name(IAO, "0000630") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000631</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study limitations section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000631">http://purl.obolibrary.org/obo/IAO_0000631</seealso>
    let study_limitations_section = Prefixed_Name(IAO, "0000631") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000632</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study limitations textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000632">http://purl.obolibrary.org/obo/IAO_0000632</seealso>
    let study_limitations_textual_entity = Prefixed_Name(IAO, "0000632") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000633</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"materials section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000633">http://purl.obolibrary.org/obo/IAO_0000633</seealso>
    let materials_section = Prefixed_Name(IAO, "0000633") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000634</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notes section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000634">http://purl.obolibrary.org/obo/IAO_0000634</seealso>
    let notes_section = Prefixed_Name(IAO, "0000634") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000635</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patients section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000635">http://purl.obolibrary.org/obo/IAO_0000635</seealso>
    let patients_section = Prefixed_Name(IAO, "0000635") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000636</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patients textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000636">http://purl.obolibrary.org/obo/IAO_0000636</seealso>
    let patients_textual_entity = Prefixed_Name(IAO, "0000636") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000637</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pre-publication history section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000637">http://purl.obolibrary.org/obo/IAO_0000637</seealso>
    let pre_publication_history_section = Prefixed_Name(IAO, "0000637") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pre-publication history textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000638">http://purl.obolibrary.org/obo/IAO_0000638</seealso>
    let pre_publication_history_textual_entity =
        Prefixed_Name(IAO, "0000638") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000639</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"related work section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000639">http://purl.obolibrary.org/obo/IAO_0000639</seealso>
    let related_work_section = Prefixed_Name(IAO, "0000639") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000640</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"related work textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000640">http://purl.obolibrary.org/obo/IAO_0000640</seealso>
    let related_work_textual_entity = Prefixed_Name(IAO, "0000640") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000641</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"requirements section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000641">http://purl.obolibrary.org/obo/IAO_0000641</seealso>
    let requirements_section = Prefixed_Name(IAO, "0000641") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000642</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"requirements textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000642">http://purl.obolibrary.org/obo/IAO_0000642</seealso>
    let requirements_textual_entity = Prefixed_Name(IAO, "0000642") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000643</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical analysis textual entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000643">http://purl.obolibrary.org/obo/IAO_0000643</seealso>
    let statistical_analysis_textual_entity =
        Prefixed_Name(IAO, "0000643") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000644</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical analysis section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000644">http://purl.obolibrary.org/obo/IAO_0000644</seealso>
    let statistical_analysis_section = Prefixed_Name(IAO, "0000644") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0000645</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tables section"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000645">http://purl.obolibrary.org/obo/IAO_0000645</seealso>
    let tables_section = Prefixed_Name(IAO, "0000645") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0000650</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database extract, transform, and load process"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0000650">http://purl.obolibrary.org/obo/IAO_0000650</seealso>
    let ``database_extract,_transform,_and_load_process`` =
        Prefixed_Name(IAO, "0000650") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IAO_0010000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has axiom label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0010000">http://purl.obolibrary.org/obo/IAO_0010000</seealso>
    let has_axiom_label = Prefixed_Name(IAO, "0010000") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IAO_0100001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"term replaced by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IAO_0100001">http://purl.obolibrary.org/obo/IAO_0100001</seealso>
    let term_replaced_by = Prefixed_Name(IAO, "0100001") |> PrefixedName

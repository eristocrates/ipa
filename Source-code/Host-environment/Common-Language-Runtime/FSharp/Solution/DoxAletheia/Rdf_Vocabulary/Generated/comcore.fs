namespace https.www.commoncoreontologies.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module comcore =
    let _namespace_iri = Namespace_Iri comcore |> NamespaceIRI

    /// <summary>
    ///   <para>comcore:2026-04-04/CommonCoreOntologiesMerged</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/2026-04-04/CommonCoreOntologiesMerged">https://www.commoncoreontologies.org/2026-04-04/CommonCoreOntologiesMerged</seealso>
    let ``_2026_04_04/CommonCoreOntologiesMerged`` =
        Prefixed_Name(comcore, "2026-04-04/CommonCoreOntologiesMerged") |> PrefixedName

    /// <summary>
    ///   <para>comcore:2026-25-03/BarcodeOntology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/2026-25-03/BarcodeOntology">https://www.commoncoreontologies.org/2026-25-03/BarcodeOntology</seealso>
    let ``_2026_25_03/BarcodeOntology`` =
        Prefixed_Name(comcore, "2026-25-03/BarcodeOntology") |> PrefixedName

    /// <summary>
    ///   <para>comcore:2026-25-03/FamilialRelationsOntology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/2026-25-03/FamilialRelationsOntology">https://www.commoncoreontologies.org/2026-25-03/FamilialRelationsOntology</seealso>
    let ``_2026_25_03/FamilialRelationsOntology`` =
        Prefixed_Name(comcore, "2026-25-03/FamilialRelationsOntology") |> PrefixedName

    /// <summary>
    ///   <para>comcore:ArtifactOntology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ArtifactOntology">https://www.commoncoreontologies.org/ArtifactOntology</seealso>
    let ArtifactOntology = Prefixed_Name(comcore, "ArtifactOntology") |> PrefixedName
    /// <summary>
    ///   <para>comcore:BarcodeOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology is designed to represent barcode information content entities."</para>
    /// labels<para>"Barcode Ontology"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/BarcodeOntology">https://www.commoncoreontologies.org/BarcodeOntology</seealso>
    let BarcodeOntology = Prefixed_Name(comcore, "BarcodeOntology") |> PrefixedName

    /// <summary>
    ///   <para>comcore:CommonCoreOntologiesMerged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A stand-alone file containing the eleven mid-level Common Core Ontologies plus BFO. Provided for use-cases where one file representing a specific release of CCO and its imports is desirable."</para>
    /// labels<para>"Common Core Ontologies Merged"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/CommonCoreOntologiesMerged">https://www.commoncoreontologies.org/CommonCoreOntologiesMerged</seealso>
    let CommonCoreOntologiesMerged =
        Prefixed_Name(comcore, "CommonCoreOntologiesMerged") |> PrefixedName

    /// <summary>
    ///   <para>comcore:ont00000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Deflecting Prism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000001">https://www.commoncoreontologies.org/ont00000001</seealso>
    let ont00000001 = Prefixed_Name(comcore, "ont00000001") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cooling Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000002">https://www.commoncoreontologies.org/ont00000002</seealso>
    let ont00000002 = Prefixed_Name(comcore, "ont00000002") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Designative Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000003">https://www.commoncoreontologies.org/ont00000003</seealso>
    let ont00000003 = Prefixed_Name(comcore, "ont00000003") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Change"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000004">https://www.commoncoreontologies.org/ont00000004</seealso>
    let ont00000004 = Prefixed_Name(comcore, "ont00000004") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000005">https://www.commoncoreontologies.org/ont00000005</seealso>
    let ont00000005 = Prefixed_Name(comcore, "ont00000005") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Upper Midrange Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000006">https://www.commoncoreontologies.org/ont00000006</seealso>
    let ont00000006 = Prefixed_Name(comcore, "ont00000006") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Natural Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000007">https://www.commoncoreontologies.org/ont00000007</seealso>
    let ont00000007 = Prefixed_Name(comcore, "ont00000007") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000008">https://www.commoncoreontologies.org/ont00000008</seealso>
    let ont00000008 = Prefixed_Name(comcore, "ont00000008") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mass Density"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000009">https://www.commoncoreontologies.org/ont00000009</seealso>
    let ont00000009 = Prefixed_Name(comcore, "ont00000009") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Incorporated Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000010">https://www.commoncoreontologies.org/ont00000010</seealso>
    let ont00000010 = Prefixed_Name(comcore, "ont00000010") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nominal Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000011">https://www.commoncoreontologies.org/ont00000011</seealso>
    let ont00000011 = Prefixed_Name(comcore, "ont00000011") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propulsion Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000012">https://www.commoncoreontologies.org/ont00000012</seealso>
    let ont00000012 = Prefixed_Name(comcore, "ont00000012") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Generically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000013">https://www.commoncoreontologies.org/ont00000013</seealso>
    let ont00000013 = Prefixed_Name(comcore, "ont00000013") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Aztec Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000014">https://www.commoncoreontologies.org/ont00000014</seealso>
    let ont00000014 = Prefixed_Name(comcore, "ont00000014") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shotgun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000015">https://www.commoncoreontologies.org/ont00000015</seealso>
    let ont00000015 = Prefixed_Name(comcore, "ont00000015") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Triangular Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000016">https://www.commoncoreontologies.org/ont00000016</seealso>
    let ont00000016 = Prefixed_Name(comcore, "ont00000016") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Minor Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000017">https://www.commoncoreontologies.org/ont00000017</seealso>
    let ont00000017 = Prefixed_Name(comcore, "ont00000017") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Title Document"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000018">https://www.commoncoreontologies.org/ont00000018</seealso>
    let ont00000018 = Prefixed_Name(comcore, "ont00000018") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Inverting Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000019">https://www.commoncoreontologies.org/ont00000019</seealso>
    let ont00000019 = Prefixed_Name(comcore, "ont00000019") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Container"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000020">https://www.commoncoreontologies.org/ont00000020</seealso>
    let ont00000020 = Prefixed_Name(comcore, "ont00000020") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor Platform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000021">https://www.commoncoreontologies.org/ont00000021</seealso>
    let ont00000021 = Prefixed_Name(comcore, "ont00000021") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Communication Reception Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000022">https://www.commoncoreontologies.org/ont00000022</seealso>
    let ont00000022 = Prefixed_Name(comcore, "ont00000022") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor Deployment Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000023">https://www.commoncoreontologies.org/ont00000023</seealso>
    let ont00000023 = Prefixed_Name(comcore, "ont00000023") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Advising"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000024">https://www.commoncoreontologies.org/ont00000024</seealso>
    let ont00000024 = Prefixed_Name(comcore, "ont00000024") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electronic Stock"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000025">https://www.commoncoreontologies.org/ont00000025</seealso>
    let ont00000025 = Prefixed_Name(comcore, "ont00000025") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hair Color"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000026">https://www.commoncoreontologies.org/ont00000026</seealso>
    let ont00000026 = Prefixed_Name(comcore, "ont00000026") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mailing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000027">https://www.commoncoreontologies.org/ont00000027</seealso>
    let ont00000027 = Prefixed_Name(comcore, "ont00000027") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dispersive Prism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000028">https://www.commoncoreontologies.org/ont00000028</seealso>
    let ont00000028 = Prefixed_Name(comcore, "ont00000028") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Median Point Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000029">https://www.commoncoreontologies.org/ont00000029</seealso>
    let ont00000029 = Prefixed_Name(comcore, "ont00000029") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Reactor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000030">https://www.commoncoreontologies.org/ont00000030</seealso>
    let ont00000030 = Prefixed_Name(comcore, "ont00000030") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Atmospheric Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000031">https://www.commoncoreontologies.org/ont00000031</seealso>
    let ont00000031 = Prefixed_Name(comcore, "ont00000031") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Church"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000032">https://www.commoncoreontologies.org/ont00000032</seealso>
    let ont00000032 = Prefixed_Name(comcore, "ont00000032") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000033">https://www.commoncoreontologies.org/ont00000033</seealso>
    let ont00000033 = Prefixed_Name(comcore, "ont00000033") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Conveyance Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000034">https://www.commoncoreontologies.org/ont00000034</seealso>
    let ont00000034 = Prefixed_Name(comcore, "ont00000034") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Soft X-ray Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000035">https://www.commoncoreontologies.org/ont00000035</seealso>
    let ont00000035 = Prefixed_Name(comcore, "ont00000035") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Waste Management Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000036">https://www.commoncoreontologies.org/ont00000036</seealso>
    let ont00000036 = Prefixed_Name(comcore, "ont00000036") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Observation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000037">https://www.commoncoreontologies.org/ont00000037</seealso>
    let ont00000037 = Prefixed_Name(comcore, "ont00000037") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"System Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000038">https://www.commoncoreontologies.org/ont00000038</seealso>
    let ont00000038 = Prefixed_Name(comcore, "ont00000038") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Solid Fuel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000039">https://www.commoncoreontologies.org/ont00000039</seealso>
    let ont00000039 = Prefixed_Name(comcore, "ont00000039") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Grocery Store"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000040">https://www.commoncoreontologies.org/ont00000040</seealso>
    let ont00000040 = Prefixed_Name(comcore, "ont00000040") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hostel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000041">https://www.commoncoreontologies.org/ont00000041</seealso>
    let ont00000041 = Prefixed_Name(comcore, "ont00000041") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semicircular"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000042">https://www.commoncoreontologies.org/ont00000042</seealso>
    let ont00000042 = Prefixed_Name(comcore, "ont00000042") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Solid Propellant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000043">https://www.commoncoreontologies.org/ont00000043</seealso>
    let ont00000043 = Prefixed_Name(comcore, "ont00000043") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Eye Color"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000044">https://www.commoncoreontologies.org/ont00000044</seealso>
    let ont00000044 = Prefixed_Name(comcore, "ont00000044") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Petroleum Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000045">https://www.commoncoreontologies.org/ont00000045</seealso>
    let ont00000045 = Prefixed_Name(comcore, "ont00000045") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Province"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000046">https://www.commoncoreontologies.org/ont00000046</seealso>
    let ont00000046 = Prefixed_Name(comcore, "ont00000046") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flow Control Valve"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000047">https://www.commoncoreontologies.org/ont00000047</seealso>
    let ont00000047 = Prefixed_Name(comcore, "ont00000047") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Random Wire Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000048">https://www.commoncoreontologies.org/ont00000048</seealso>
    let ont00000048 = Prefixed_Name(comcore, "ont00000048") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Banknote"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000049">https://www.commoncoreontologies.org/ont00000049</seealso>
    let ont00000049 = Prefixed_Name(comcore, "ont00000049") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Very High Frequency Communication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000050">https://www.commoncoreontologies.org/ont00000050</seealso>
    let ont00000050 = Prefixed_Name(comcore, "ont00000050") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Construction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000051">https://www.commoncoreontologies.org/ont00000051</seealso>
    let ont00000051 = Prefixed_Name(comcore, "ont00000051") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Religious Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000052">https://www.commoncoreontologies.org/ont00000052</seealso>
    let ont00000052 = Prefixed_Name(comcore, "ont00000052") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ground Motor Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000053">https://www.commoncoreontologies.org/ont00000053</seealso>
    let ont00000053 = Prefixed_Name(comcore, "ont00000053") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stirling Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000054">https://www.commoncoreontologies.org/ont00000054</seealso>
    let ont00000054 = Prefixed_Name(comcore, "ont00000054") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Healthcare Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000055">https://www.commoncoreontologies.org/ont00000055</seealso>
    let ont00000055 = Prefixed_Name(comcore, "ont00000055") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reaction Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000056">https://www.commoncoreontologies.org/ont00000056</seealso>
    let ont00000056 = Prefixed_Name(comcore, "ont00000056") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mobile Telephone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000057">https://www.commoncoreontologies.org/ont00000057</seealso>
    let ont00000057 = Prefixed_Name(comcore, "ont00000057") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scalp Hair"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000058">https://www.commoncoreontologies.org/ont00000058</seealso>
    let ont00000058 = Prefixed_Name(comcore, "ont00000058") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000059">https://www.commoncoreontologies.org/ont00000059</seealso>
    let ont00000059 = Prefixed_Name(comcore, "ont00000059") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open Pit Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000060">https://www.commoncoreontologies.org/ont00000060</seealso>
    let ont00000060 = Prefixed_Name(comcore, "ont00000060") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Flow"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000061">https://www.commoncoreontologies.org/ont00000061</seealso>
    let ont00000061 = Prefixed_Name(comcore, "ont00000061") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Frequency Measurement Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000062">https://www.commoncoreontologies.org/ont00000062</seealso>
    let ont00000062 = Prefixed_Name(comcore, "ont00000062") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Hour Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000063">https://www.commoncoreontologies.org/ont00000063</seealso>
    let ont00000063 = Prefixed_Name(comcore, "ont00000063") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Book"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000064">https://www.commoncoreontologies.org/ont00000064</seealso>
    let ont00000064 = Prefixed_Name(comcore, "ont00000064") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Location Change"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000065">https://www.commoncoreontologies.org/ont00000065</seealso>
    let ont00000065 = Prefixed_Name(comcore, "ont00000065") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000066">https://www.commoncoreontologies.org/ont00000066</seealso>
    let ont00000066 = Prefixed_Name(comcore, "ont00000066") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Civil Time Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000067">https://www.commoncoreontologies.org/ont00000067</seealso>
    let ont00000067 = Prefixed_Name(comcore, "ont00000067") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Three-Dimensional Path"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000068">https://www.commoncoreontologies.org/ont00000068</seealso>
    let ont00000068 = Prefixed_Name(comcore, "ont00000068") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Transcript"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000069">https://www.commoncoreontologies.org/ont00000069</seealso>
    let ont00000069 = Prefixed_Name(comcore, "ont00000069") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ground Track Point"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000070">https://www.commoncoreontologies.org/ont00000070</seealso>
    let ont00000070 = Prefixed_Name(comcore, "ont00000070") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Town"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000071">https://www.commoncoreontologies.org/ont00000071</seealso>
    let ont00000071 = Prefixed_Name(comcore, "ont00000071") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Low Density Residential Area"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000072">https://www.commoncoreontologies.org/ont00000072</seealso>
    let ont00000072 = Prefixed_Name(comcore, "ont00000072") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Interval Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000073">https://www.commoncoreontologies.org/ont00000073</seealso>
    let ont00000073 = Prefixed_Name(comcore, "ont00000073") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Acceleration"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000074">https://www.commoncoreontologies.org/ont00000074</seealso>
    let ont00000074 = Prefixed_Name(comcore, "ont00000074") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Microscope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000075">https://www.commoncoreontologies.org/ont00000075</seealso>
    let ont00000075 = Prefixed_Name(comcore, "ont00000075") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wired Communication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000076">https://www.commoncoreontologies.org/ont00000076</seealso>
    let ont00000076 = Prefixed_Name(comcore, "ont00000076") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000077">https://www.commoncoreontologies.org/ont00000077</seealso>
    let ont00000077 = Prefixed_Name(comcore, "ont00000077") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Estimation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000078">https://www.commoncoreontologies.org/ont00000078</seealso>
    let ont00000078 = Prefixed_Name(comcore, "ont00000078") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Social Movement"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000079">https://www.commoncoreontologies.org/ont00000079</seealso>
    let ont00000079 = Prefixed_Name(comcore, "ont00000079") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Standard Time of Day Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000080">https://www.commoncoreontologies.org/ont00000080</seealso>
    let ont00000080 = Prefixed_Name(comcore, "ont00000080") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cutting Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000081">https://www.commoncoreontologies.org/ont00000081</seealso>
    let ont00000081 = Prefixed_Name(comcore, "ont00000081") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Green"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000082">https://www.commoncoreontologies.org/ont00000082</seealso>
    let ont00000082 = Prefixed_Name(comcore, "ont00000082") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process Ending"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000083">https://www.commoncoreontologies.org/ont00000083</seealso>
    let ont00000083 = Prefixed_Name(comcore, "ont00000083") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bodily Component"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000084">https://www.commoncoreontologies.org/ont00000084</seealso>
    let ont00000084 = Prefixed_Name(comcore, "ont00000084") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Minute"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000085">https://www.commoncoreontologies.org/ont00000085</seealso>
    let ont00000085 = Prefixed_Name(comcore, "ont00000085") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Autopilot System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000086">https://www.commoncoreontologies.org/ont00000086</seealso>
    let ont00000086 = Prefixed_Name(comcore, "ont00000086") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ordinal Date Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000087">https://www.commoncoreontologies.org/ont00000087</seealso>
    let ont00000087 = Prefixed_Name(comcore, "ont00000087") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Firearm"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000088">https://www.commoncoreontologies.org/ont00000088</seealso>
    let ont00000088 = Prefixed_Name(comcore, "ont00000088") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Skill"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000089">https://www.commoncoreontologies.org/ont00000089</seealso>
    let ont00000089 = Prefixed_Name(comcore, "ont00000089") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrared Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000090">https://www.commoncoreontologies.org/ont00000090</seealso>
    let ont00000090 = Prefixed_Name(comcore, "ont00000090") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Coolant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000091">https://www.commoncoreontologies.org/ont00000091</seealso>
    let ont00000091 = Prefixed_Name(comcore, "ont00000091") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bidirectional Transducer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000092">https://www.commoncoreontologies.org/ont00000092</seealso>
    let ont00000092 = Prefixed_Name(comcore, "ont00000092") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Preferred Stock"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000093">https://www.commoncoreontologies.org/ont00000093</seealso>
    let ont00000093 = Prefixed_Name(comcore, "ont00000093") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Seat of National Government"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000094">https://www.commoncoreontologies.org/ont00000094</seealso>
    let ont00000094 = Prefixed_Name(comcore, "ont00000094") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Control Surface"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000095">https://www.commoncoreontologies.org/ont00000095</seealso>
    let ont00000095 = Prefixed_Name(comcore, "ont00000095") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propulsion System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000096">https://www.commoncoreontologies.org/ont00000096</seealso>
    let ont00000096 = Prefixed_Name(comcore, "ont00000096") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Complex Optical Lens"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000097">https://www.commoncoreontologies.org/ont00000097</seealso>
    let ont00000097 = Prefixed_Name(comcore, "ont00000097") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000098">https://www.commoncoreontologies.org/ont00000098</seealso>
    let ont00000098 = Prefixed_Name(comcore, "ont00000098") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wave Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000099">https://www.commoncoreontologies.org/ont00000099</seealso>
    let ont00000099 = Prefixed_Name(comcore, "ont00000099") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Partially Mission Capable"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000100">https://www.commoncoreontologies.org/ont00000100</seealso>
    let ont00000100 = Prefixed_Name(comcore, "ont00000100") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Oxygen"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000101">https://www.commoncoreontologies.org/ont00000101</seealso>
    let ont00000101 = Prefixed_Name(comcore, "ont00000101") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Skin Type"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000102">https://www.commoncoreontologies.org/ont00000102</seealso>
    let ont00000102 = Prefixed_Name(comcore, "ont00000102") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Compartment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000103">https://www.commoncoreontologies.org/ont00000103</seealso>
    let ont00000103 = Prefixed_Name(comcore, "ont00000103") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Underwater Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000104">https://www.commoncoreontologies.org/ont00000104</seealso>
    let ont00000104 = Prefixed_Name(comcore, "ont00000104") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Square"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000105">https://www.commoncoreontologies.org/ont00000105</seealso>
    let ont00000105 = Prefixed_Name(comcore, "ont00000105") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"End of Life Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000106">https://www.commoncoreontologies.org/ont00000106</seealso>
    let ont00000106 = Prefixed_Name(comcore, "ont00000106") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Generically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000107">https://www.commoncoreontologies.org/ont00000107</seealso>
    let ont00000107 = Prefixed_Name(comcore, "ont00000107") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rail Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000108">https://www.commoncoreontologies.org/ont00000108</seealso>
    let ont00000108 = Prefixed_Name(comcore, "ont00000108") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Military Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000109">https://www.commoncoreontologies.org/ont00000109</seealso>
    let ont00000109 = Prefixed_Name(comcore, "ont00000109") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mechanical Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000110">https://www.commoncoreontologies.org/ont00000110</seealso>
    let ont00000110 = Prefixed_Name(comcore, "ont00000110") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Air Inlet"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000111">https://www.commoncoreontologies.org/ont00000111</seealso>
    let ont00000111 = Prefixed_Name(comcore, "ont00000111") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Translucent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000112">https://www.commoncoreontologies.org/ont00000112</seealso>
    let ont00000112 = Prefixed_Name(comcore, "ont00000112") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ventilation Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000113">https://www.commoncoreontologies.org/ont00000113</seealso>
    let ont00000113 = Prefixed_Name(comcore, "ont00000113") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unix Temporal Instant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000114">https://www.commoncoreontologies.org/ont00000114</seealso>
    let ont00000114 = Prefixed_Name(comcore, "ont00000114") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000115">https://www.commoncoreontologies.org/ont00000115</seealso>
    let ont00000115 = Prefixed_Name(comcore, "ont00000115") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pump"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000116">https://www.commoncoreontologies.org/ont00000116</seealso>
    let ont00000116 = Prefixed_Name(comcore, "ont00000116") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Processing Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000117">https://www.commoncoreontologies.org/ont00000117</seealso>
    let ont00000117 = Prefixed_Name(comcore, "ont00000117") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Function Specification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000118">https://www.commoncoreontologies.org/ont00000118</seealso>
    let ont00000118 = Prefixed_Name(comcore, "ont00000118") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spatial Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000119">https://www.commoncoreontologies.org/ont00000119</seealso>
    let ont00000119 = Prefixed_Name(comcore, "ont00000119") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000120">https://www.commoncoreontologies.org/ont00000120</seealso>
    let ont00000120 = Prefixed_Name(comcore, "ont00000120") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Conducting Mass Media Interview"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000121">https://www.commoncoreontologies.org/ont00000121</seealso>
    let ont00000121 = Prefixed_Name(comcore, "ont00000121") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Track Point"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000122">https://www.commoncoreontologies.org/ont00000122</seealso>
    let ont00000122 = Prefixed_Name(comcore, "ont00000122") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Expressive Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000123">https://www.commoncoreontologies.org/ont00000123</seealso>
    let ont00000123 = Prefixed_Name(comcore, "ont00000123") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000124</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solar Time Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000124">https://www.commoncoreontologies.org/ont00000124</seealso>
    let ont00000124 = Prefixed_Name(comcore, "ont00000124") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bounding Box Point"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000125">https://www.commoncoreontologies.org/ont00000125</seealso>
    let ont00000125 = Prefixed_Name(comcore, "ont00000125") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000126</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"First-Order Administrative Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000126">https://www.commoncoreontologies.org/ont00000126</seealso>
    let ont00000126 = Prefixed_Name(comcore, "ont00000126") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000127</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Performance Specification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000127">https://www.commoncoreontologies.org/ont00000127</seealso>
    let ont00000127 = Prefixed_Name(comcore, "ont00000127") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000128</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Hydrogen"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000128">https://www.commoncoreontologies.org/ont00000128</seealso>
    let ont00000128 = Prefixed_Name(comcore, "ont00000128") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tattoo"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000129">https://www.commoncoreontologies.org/ont00000129</seealso>
    let ont00000129 = Prefixed_Name(comcore, "ont00000129") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000130</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Transformer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000130">https://www.commoncoreontologies.org/ont00000130</seealso>
    let ont00000130 = Prefixed_Name(comcore, "ont00000130") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000131">https://www.commoncoreontologies.org/ont00000131</seealso>
    let ont00000131 = Prefixed_Name(comcore, "ont00000131") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Recording Device"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000132">https://www.commoncoreontologies.org/ont00000132</seealso>
    let ont00000132 = Prefixed_Name(comcore, "ont00000132") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000133</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Directive Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000133">https://www.commoncoreontologies.org/ont00000133</seealso>
    let ont00000133 = Prefixed_Name(comcore, "ont00000133") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000134</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Third-Order Administrative Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000134">https://www.commoncoreontologies.org/ont00000134</seealso>
    let ont00000134 = Prefixed_Name(comcore, "ont00000134") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000135</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Specifically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000135">https://www.commoncoreontologies.org/ont00000135</seealso>
    let ont00000135 = Prefixed_Name(comcore, "ont00000135") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000136</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000136">https://www.commoncoreontologies.org/ont00000136</seealso>
    let ont00000136 = Prefixed_Name(comcore, "ont00000136") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000137</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Financial Deposit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000137">https://www.commoncoreontologies.org/ont00000137</seealso>
    let ont00000137 = Prefixed_Name(comcore, "ont00000137") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000138</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maximum Power"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000138">https://www.commoncoreontologies.org/ont00000138</seealso>
    let ont00000138 = Prefixed_Name(comcore, "ont00000138") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Domain of a Country"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000139">https://www.commoncoreontologies.org/ont00000139</seealso>
    let ont00000139 = Prefixed_Name(comcore, "ont00000139") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Amount of Substance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000140">https://www.commoncoreontologies.org/ont00000140</seealso>
    let ont00000140 = Prefixed_Name(comcore, "ont00000140") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Populace"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000141">https://www.commoncoreontologies.org/ont00000141</seealso>
    let ont00000141 = Prefixed_Name(comcore, "ont00000141") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Government"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000142">https://www.commoncoreontologies.org/ont00000142</seealso>
    let ont00000142 = Prefixed_Name(comcore, "ont00000142") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000143</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cargo Cabin"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000143">https://www.commoncoreontologies.org/ont00000143</seealso>
    let ont00000143 = Prefixed_Name(comcore, "ont00000143") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Meeting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000144">https://www.commoncoreontologies.org/ont00000144</seealso>
    let ont00000144 = Prefixed_Name(comcore, "ont00000144") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000145</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Incendiary Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000145">https://www.commoncoreontologies.org/ont00000145</seealso>
    let ont00000145 = Prefixed_Name(comcore, "ont00000145") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artificial Language"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000146">https://www.commoncoreontologies.org/ont00000146</seealso>
    let ont00000146 = Prefixed_Name(comcore, "ont00000146") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000147</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flight Transponder"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000147">https://www.commoncoreontologies.org/ont00000147</seealso>
    let ont00000147 = Prefixed_Name(comcore, "ont00000147") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clockwise Rotational Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000148">https://www.commoncoreontologies.org/ont00000148</seealso>
    let ont00000148 = Prefixed_Name(comcore, "ont00000148") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000149</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Instant Messaging"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000149">https://www.commoncoreontologies.org/ont00000149</seealso>
    let ont00000149 = Prefixed_Name(comcore, "ont00000149") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000150</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000150">https://www.commoncoreontologies.org/ont00000150</seealso>
    let ont00000150 = Prefixed_Name(comcore, "ont00000150") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000151</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Reporting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000151">https://www.commoncoreontologies.org/ont00000151</seealso>
    let ont00000151 = Prefixed_Name(comcore, "ont00000151") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000152</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000152">https://www.commoncoreontologies.org/ont00000152</seealso>
    let ont00000152 = Prefixed_Name(comcore, "ont00000152") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000153</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Generator Control Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000153">https://www.commoncoreontologies.org/ont00000153</seealso>
    let ont00000153 = Prefixed_Name(comcore, "ont00000153") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000154</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mode Point Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000154">https://www.commoncoreontologies.org/ont00000154</seealso>
    let ont00000154 = Prefixed_Name(comcore, "ont00000154") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000155</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Near Infrared Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000155">https://www.commoncoreontologies.org/ont00000155</seealso>
    let ont00000155 = Prefixed_Name(comcore, "ont00000155") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000156</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hand Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000156">https://www.commoncoreontologies.org/ont00000156</seealso>
    let ont00000156 = Prefixed_Name(comcore, "ont00000156") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000157</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Facial Hair"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000157">https://www.commoncoreontologies.org/ont00000157</seealso>
    let ont00000157 = Prefixed_Name(comcore, "ont00000157") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000158</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lithium-ion Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000158">https://www.commoncoreontologies.org/ont00000158</seealso>
    let ont00000158 = Prefixed_Name(comcore, "ont00000158") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000159</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Timekeeping Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000159">https://www.commoncoreontologies.org/ont00000159</seealso>
    let ont00000159 = Prefixed_Name(comcore, "ont00000159") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000160</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Manual Tool"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000160">https://www.commoncoreontologies.org/ont00000160</seealso>
    let ont00000160 = Prefixed_Name(comcore, "ont00000160") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000161</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coordinate System Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000161">https://www.commoncoreontologies.org/ont00000161</seealso>
    let ont00000161 = Prefixed_Name(comcore, "ont00000161") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000162</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Connector Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000162">https://www.commoncoreontologies.org/ont00000162</seealso>
    let ont00000162 = Prefixed_Name(comcore, "ont00000162") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000163</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"z-Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000163">https://www.commoncoreontologies.org/ont00000163</seealso>
    let ont00000163 = Prefixed_Name(comcore, "ont00000163") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000164</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Minimum Ordinal Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000164">https://www.commoncoreontologies.org/ont00000164</seealso>
    let ont00000164 = Prefixed_Name(comcore, "ont00000164") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Criminal Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000165">https://www.commoncoreontologies.org/ont00000165</seealso>
    let ont00000165 = Prefixed_Name(comcore, "ont00000165") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000166</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wave Cycle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000166">https://www.commoncoreontologies.org/ont00000166</seealso>
    let ont00000166 = Prefixed_Name(comcore, "ont00000166") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000167</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Large-Scale Rocket Launcher"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000167">https://www.commoncoreontologies.org/ont00000167</seealso>
    let ont00000167 = Prefixed_Name(comcore, "ont00000167") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000168</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Interpersonal Relationship"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000168">https://www.commoncoreontologies.org/ont00000168</seealso>
    let ont00000168 = Prefixed_Name(comcore, "ont00000168") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Very High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000169">https://www.commoncoreontologies.org/ont00000169</seealso>
    let ont00000169 = Prefixed_Name(comcore, "ont00000169") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000170</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object Track Point"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000170">https://www.commoncoreontologies.org/ont00000170</seealso>
    let ont00000170 = Prefixed_Name(comcore, "ont00000170") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Detergent Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000171">https://www.commoncoreontologies.org/ont00000171</seealso>
    let ont00000171 = Prefixed_Name(comcore, "ont00000171") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000172</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Base of Operations"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000172">https://www.commoncoreontologies.org/ont00000172</seealso>
    let ont00000172 = Prefixed_Name(comcore, "ont00000172") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000173</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Civilian Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000173">https://www.commoncoreontologies.org/ont00000173</seealso>
    let ont00000173 = Prefixed_Name(comcore, "ont00000173") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000174</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultraviolet Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000174">https://www.commoncoreontologies.org/ont00000174</seealso>
    let ont00000174 = Prefixed_Name(comcore, "ont00000174") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000175</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization Member Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000175">https://www.commoncoreontologies.org/ont00000175</seealso>
    let ont00000175 = Prefixed_Name(comcore, "ont00000175") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geopolitical Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000176">https://www.commoncoreontologies.org/ont00000176</seealso>
    let ont00000176 = Prefixed_Name(comcore, "ont00000176") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000177</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Affordance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000177">https://www.commoncoreontologies.org/ont00000177</seealso>
    let ont00000177 = Prefixed_Name(comcore, "ont00000177") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Arrow"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000178">https://www.commoncoreontologies.org/ont00000178</seealso>
    let ont00000178 = Prefixed_Name(comcore, "ont00000178") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thrust"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000179">https://www.commoncoreontologies.org/ont00000179</seealso>
    let ont00000179 = Prefixed_Name(comcore, "ont00000179") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hotel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000180">https://www.commoncoreontologies.org/ont00000180</seealso>
    let ont00000180 = Prefixed_Name(comcore, "ont00000180") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000181</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Language Skill"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000181">https://www.commoncoreontologies.org/ont00000181</seealso>
    let ont00000181 = Prefixed_Name(comcore, "ont00000181") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Thanking"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000182">https://www.commoncoreontologies.org/ont00000182</seealso>
    let ont00000182 = Prefixed_Name(comcore, "ont00000182") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fragrance Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000183">https://www.commoncoreontologies.org/ont00000183</seealso>
    let ont00000183 = Prefixed_Name(comcore, "ont00000183") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Axial Rotation Period"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000184">https://www.commoncoreontologies.org/ont00000184</seealso>
    let ont00000184 = Prefixed_Name(comcore, "ont00000184") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blunt"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000185">https://www.commoncoreontologies.org/ont00000185</seealso>
    let ont00000185 = Prefixed_Name(comcore, "ont00000185") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Version Ordinality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000186">https://www.commoncoreontologies.org/ont00000186</seealso>
    let ont00000186 = Prefixed_Name(comcore, "ont00000186") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000187</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Authority Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000187">https://www.commoncoreontologies.org/ont00000187</seealso>
    let ont00000187 = Prefixed_Name(comcore, "ont00000187") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000188</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ground Track"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000188">https://www.commoncoreontologies.org/ont00000188</seealso>
    let ont00000188 = Prefixed_Name(comcore, "ont00000188") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000189</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Certificate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000189">https://www.commoncoreontologies.org/ont00000189</seealso>
    let ont00000189 = Prefixed_Name(comcore, "ont00000189") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000190</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Minimum Speed Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000190">https://www.commoncoreontologies.org/ont00000190</seealso>
    let ont00000190 = Prefixed_Name(comcore, "ont00000190") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000191</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Homicide"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000191">https://www.commoncoreontologies.org/ont00000191</seealso>
    let ont00000191 = Prefixed_Name(comcore, "ont00000191") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000192</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000192">https://www.commoncoreontologies.org/ont00000192</seealso>
    let ont00000192 = Prefixed_Name(comcore, "ont00000192") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000193</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone Subscriber Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000193">https://www.commoncoreontologies.org/ont00000193</seealso>
    let ont00000193 = Prefixed_Name(comcore, "ont00000193") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000194</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Contact Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000194">https://www.commoncoreontologies.org/ont00000194</seealso>
    let ont00000194 = Prefixed_Name(comcore, "ont00000194") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heliport"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000195">https://www.commoncoreontologies.org/ont00000195</seealso>
    let ont00000195 = Prefixed_Name(comcore, "ont00000195") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Purple"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000196">https://www.commoncoreontologies.org/ont00000196</seealso>
    let ont00000196 = Prefixed_Name(comcore, "ont00000196") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process Beginning"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000197">https://www.commoncoreontologies.org/ont00000197</seealso>
    let ont00000197 = Prefixed_Name(comcore, "ont00000197") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000198</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Sound Level"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000198">https://www.commoncoreontologies.org/ont00000198</seealso>
    let ont00000198 = Prefixed_Name(comcore, "ont00000198") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000199</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Camera"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000199">https://www.commoncoreontologies.org/ont00000199</seealso>
    let ont00000199 = Prefixed_Name(comcore, "ont00000199") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000200</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Pilgrimage"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000200">https://www.commoncoreontologies.org/ont00000200</seealso>
    let ont00000200 = Prefixed_Name(comcore, "ont00000200") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Change of Residence"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000201">https://www.commoncoreontologies.org/ont00000201</seealso>
    let ont00000201 = Prefixed_Name(comcore, "ont00000201") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Terrorist Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000202">https://www.commoncoreontologies.org/ont00000202</seealso>
    let ont00000202 = Prefixed_Name(comcore, "ont00000202") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event Status Nominal Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000203">https://www.commoncoreontologies.org/ont00000203</seealso>
    let ont00000203 = Prefixed_Name(comcore, "ont00000203") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000204</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rifle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000204">https://www.commoncoreontologies.org/ont00000204</seealso>
    let ont00000204 = Prefixed_Name(comcore, "ont00000204") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000205</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object Track"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000205">https://www.commoncoreontologies.org/ont00000205</seealso>
    let ont00000205 = Prefixed_Name(comcore, "ont00000205") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000206</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Friction Reduction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000206">https://www.commoncoreontologies.org/ont00000206</seealso>
    let ont00000206 = Prefixed_Name(comcore, "ont00000206") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000207</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"One-Dimensional Geospatial Boundary"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000207">https://www.commoncoreontologies.org/ont00000207</seealso>
    let ont00000207 = Prefixed_Name(comcore, "ont00000207") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000208</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Congratulating"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000208">https://www.commoncoreontologies.org/ont00000208</seealso>
    let ont00000208 = Prefixed_Name(comcore, "ont00000208") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000209</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Wavelength"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000209">https://www.commoncoreontologies.org/ont00000209</seealso>
    let ont00000209 = Prefixed_Name(comcore, "ont00000209") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000210">https://www.commoncoreontologies.org/ont00000210</seealso>
    let ont00000210 = Prefixed_Name(comcore, "ont00000210") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000211</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Day Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000211">https://www.commoncoreontologies.org/ont00000211</seealso>
    let ont00000211 = Prefixed_Name(comcore, "ont00000211") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000212</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000212">https://www.commoncoreontologies.org/ont00000212</seealso>
    let ont00000212 = Prefixed_Name(comcore, "ont00000212") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000213</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Subcontinent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000213">https://www.commoncoreontologies.org/ont00000213</seealso>
    let ont00000213 = Prefixed_Name(comcore, "ont00000213") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000214</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Moving Target Indication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000214">https://www.commoncoreontologies.org/ont00000214</seealso>
    let ont00000214 = Prefixed_Name(comcore, "ont00000214") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000215</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000215">https://www.commoncoreontologies.org/ont00000215</seealso>
    let ont00000215 = Prefixed_Name(comcore, "ont00000215") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shell"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000216">https://www.commoncoreontologies.org/ont00000216</seealso>
    let ont00000216 = Prefixed_Name(comcore, "ont00000216") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000217</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Area"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000217">https://www.commoncoreontologies.org/ont00000217</seealso>
    let ont00000217 = Prefixed_Name(comcore, "ont00000217") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Major Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000218">https://www.commoncoreontologies.org/ont00000218</seealso>
    let ont00000218 = Prefixed_Name(comcore, "ont00000218") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reflecting Optical Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000219">https://www.commoncoreontologies.org/ont00000219</seealso>
    let ont00000219 = Prefixed_Name(comcore, "ont00000219") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ammunition Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000220">https://www.commoncoreontologies.org/ont00000220</seealso>
    let ont00000220 = Prefixed_Name(comcore, "ont00000220") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semi-Minor Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000221">https://www.commoncoreontologies.org/ont00000221</seealso>
    let ont00000221 = Prefixed_Name(comcore, "ont00000221") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Presence Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000222">https://www.commoncoreontologies.org/ont00000222</seealso>
    let ont00000222 = Prefixed_Name(comcore, "ont00000222") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time of Day"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000223">https://www.commoncoreontologies.org/ont00000223</seealso>
    let ont00000223 = Prefixed_Name(comcore, "ont00000223") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Populated place"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000224">https://www.commoncoreontologies.org/ont00000224</seealso>
    let ont00000224 = Prefixed_Name(comcore, "ont00000224") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Month"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000225">https://www.commoncoreontologies.org/ont00000225</seealso>
    let ont00000225 = Prefixed_Name(comcore, "ont00000225") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000226</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transportation Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000226">https://www.commoncoreontologies.org/ont00000226</seealso>
    let ont00000226 = Prefixed_Name(comcore, "ont00000226") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Year"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000227">https://www.commoncoreontologies.org/ont00000227</seealso>
    let ont00000227 = Prefixed_Name(comcore, "ont00000227") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Planned Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000228">https://www.commoncoreontologies.org/ont00000228</seealso>
    let ont00000228 = Prefixed_Name(comcore, "ont00000228") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000229</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Power"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000229">https://www.commoncoreontologies.org/ont00000229</seealso>
    let ont00000229 = Prefixed_Name(comcore, "ont00000229") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000230</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Diffraction Grating"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000230">https://www.commoncoreontologies.org/ont00000230</seealso>
    let ont00000230 = Prefixed_Name(comcore, "ont00000230") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Torpedo Tube"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000231">https://www.commoncoreontologies.org/ont00000231</seealso>
    let ont00000231 = Prefixed_Name(comcore, "ont00000231") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pumping Station"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000232">https://www.commoncoreontologies.org/ont00000232</seealso>
    let ont00000232 = Prefixed_Name(comcore, "ont00000232") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stock Certificate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000233">https://www.commoncoreontologies.org/ont00000233</seealso>
    let ont00000233 = Prefixed_Name(comcore, "ont00000233") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Training"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000234">https://www.commoncoreontologies.org/ont00000234</seealso>
    let ont00000234 = Prefixed_Name(comcore, "ont00000234") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Vocational Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000235">https://www.commoncoreontologies.org/ont00000235</seealso>
    let ont00000235 = Prefixed_Name(comcore, "ont00000235") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000236</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lighting System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000236">https://www.commoncoreontologies.org/ont00000236</seealso>
    let ont00000236 = Prefixed_Name(comcore, "ont00000236") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000237</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Terrorist Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000237">https://www.commoncoreontologies.org/ont00000237</seealso>
    let ont00000237 = Prefixed_Name(comcore, "ont00000237") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000238</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propeller"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000238">https://www.commoncoreontologies.org/ont00000238</seealso>
    let ont00000238 = Prefixed_Name(comcore, "ont00000238") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Mass"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000239">https://www.commoncoreontologies.org/ont00000239</seealso>
    let ont00000239 = Prefixed_Name(comcore, "ont00000239") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000240</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Oath Taking"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000240">https://www.commoncoreontologies.org/ont00000240</seealso>
    let ont00000240 = Prefixed_Name(comcore, "ont00000240") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000241</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Two-Dimensional Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000241">https://www.commoncoreontologies.org/ont00000241</seealso>
    let ont00000241 = Prefixed_Name(comcore, "ont00000241") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000242</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Data Matrix Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000242">https://www.commoncoreontologies.org/ont00000242</seealso>
    let ont00000242 = Prefixed_Name(comcore, "ont00000242") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000243</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heat Sink"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000243">https://www.commoncoreontologies.org/ont00000243</seealso>
    let ont00000243 = Prefixed_Name(comcore, "ont00000243") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000244</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fragmentation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000244">https://www.commoncoreontologies.org/ont00000244</seealso>
    let ont00000244 = Prefixed_Name(comcore, "ont00000244") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000245</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Petroleum Manufacturing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000245">https://www.commoncoreontologies.org/ont00000245</seealso>
    let ont00000245 = Prefixed_Name(comcore, "ont00000245") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000246</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Realizable Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000246">https://www.commoncoreontologies.org/ont00000246</seealso>
    let ont00000246 = Prefixed_Name(comcore, "ont00000246") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000247</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Road"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000247">https://www.commoncoreontologies.org/ont00000247</seealso>
    let ont00000247 = Prefixed_Name(comcore, "ont00000247") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000248</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical Manufacturing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000248">https://www.commoncoreontologies.org/ont00000248</seealso>
    let ont00000248 = Prefixed_Name(comcore, "ont00000248") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000249</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shaft"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000249">https://www.commoncoreontologies.org/ont00000249</seealso>
    let ont00000249 = Prefixed_Name(comcore, "ont00000249") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000250</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Realizable Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000250">https://www.commoncoreontologies.org/ont00000250</seealso>
    let ont00000250 = Prefixed_Name(comcore, "ont00000250") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000251</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Continent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000251">https://www.commoncoreontologies.org/ont00000251</seealso>
    let ont00000251 = Prefixed_Name(comcore, "ont00000251") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000252</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nozzle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000252">https://www.commoncoreontologies.org/ont00000252</seealso>
    let ont00000252 = Prefixed_Name(comcore, "ont00000252") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000253</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Bearing Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000253">https://www.commoncoreontologies.org/ont00000253</seealso>
    let ont00000253 = Prefixed_Name(comcore, "ont00000253") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000254</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transportation Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000254">https://www.commoncoreontologies.org/ont00000254</seealso>
    let ont00000254 = Prefixed_Name(comcore, "ont00000254") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Cryogenic Material"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000255">https://www.commoncoreontologies.org/ont00000255</seealso>
    let ont00000255 = Prefixed_Name(comcore, "ont00000255") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fluid Control Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000256">https://www.commoncoreontologies.org/ont00000256</seealso>
    let ont00000256 = Prefixed_Name(comcore, "ont00000256") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiopaque"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000257">https://www.commoncoreontologies.org/ont00000257</seealso>
    let ont00000257 = Prefixed_Name(comcore, "ont00000257") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000258</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a One-Dimensional Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000258">https://www.commoncoreontologies.org/ont00000258</seealso>
    let ont00000258 = Prefixed_Name(comcore, "ont00000258") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000259</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar Month"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000259">https://www.commoncoreontologies.org/ont00000259</seealso>
    let ont00000259 = Prefixed_Name(comcore, "ont00000259") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000260</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Muzzle Blast"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000260">https://www.commoncoreontologies.org/ont00000260</seealso>
    let ont00000260 = Prefixed_Name(comcore, "ont00000260") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000261</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gamma Ray Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000261">https://www.commoncoreontologies.org/ont00000261</seealso>
    let ont00000261 = Prefixed_Name(comcore, "ont00000261") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shop"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000262">https://www.commoncoreontologies.org/ont00000262</seealso>
    let ont00000262 = Prefixed_Name(comcore, "ont00000262") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000263</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clock Time System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000263">https://www.commoncoreontologies.org/ont00000263</seealso>
    let ont00000263 = Prefixed_Name(comcore, "ont00000263") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000264</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydraulic Fluid Reservoir"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000264">https://www.commoncoreontologies.org/ont00000264</seealso>
    let ont00000264 = Prefixed_Name(comcore, "ont00000264") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000265</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Election"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000265">https://www.commoncoreontologies.org/ont00000265</seealso>
    let ont00000265 = Prefixed_Name(comcore, "ont00000265") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000266</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hearing Aid"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000266">https://www.commoncoreontologies.org/ont00000266</seealso>
    let ont00000266 = Prefixed_Name(comcore, "ont00000266") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000267</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Catalyst Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000267">https://www.commoncoreontologies.org/ont00000267</seealso>
    let ont00000267 = Prefixed_Name(comcore, "ont00000267") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cannon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000268">https://www.commoncoreontologies.org/ont00000268</seealso>
    let ont00000268 = Prefixed_Name(comcore, "ont00000268") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000269</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Transmitter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000269">https://www.commoncoreontologies.org/ont00000269</seealso>
    let ont00000269 = Prefixed_Name(comcore, "ont00000269") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000270</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Educational Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000270">https://www.commoncoreontologies.org/ont00000270</seealso>
    let ont00000270 = Prefixed_Name(comcore, "ont00000270") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000271</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Underground Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000271">https://www.commoncoreontologies.org/ont00000271</seealso>
    let ont00000271 = Prefixed_Name(comcore, "ont00000271") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000272</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Combustion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000272">https://www.commoncoreontologies.org/ont00000272</seealso>
    let ont00000272 = Prefixed_Name(comcore, "ont00000272") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000273</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication Interference Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000273">https://www.commoncoreontologies.org/ont00000273</seealso>
    let ont00000273 = Prefixed_Name(comcore, "ont00000273") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000274</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Armed Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000274">https://www.commoncoreontologies.org/ont00000274</seealso>
    let ont00000274 = Prefixed_Name(comcore, "ont00000274") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000275</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spatial Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000275">https://www.commoncoreontologies.org/ont00000275</seealso>
    let ont00000275 = Prefixed_Name(comcore, "ont00000275") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solar Calendar System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000276">https://www.commoncoreontologies.org/ont00000276</seealso>
    let ont00000276 = Prefixed_Name(comcore, "ont00000276") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000277</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000277">https://www.commoncoreontologies.org/ont00000277</seealso>
    let ont00000277 = Prefixed_Name(comcore, "ont00000277") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Momentum"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000278">https://www.commoncoreontologies.org/ont00000278</seealso>
    let ont00000278 = Prefixed_Name(comcore, "ont00000278") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000279</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Enemy Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000279">https://www.commoncoreontologies.org/ont00000279</seealso>
    let ont00000279 = Prefixed_Name(comcore, "ont00000279") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Torpedo"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000280">https://www.commoncoreontologies.org/ont00000280</seealso>
    let ont00000280 = Prefixed_Name(comcore, "ont00000280") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Albedo"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000281">https://www.commoncoreontologies.org/ont00000281</seealso>
    let ont00000281 = Prefixed_Name(comcore, "ont00000281") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000282</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Counterfeit Financial Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000282">https://www.commoncoreontologies.org/ont00000282</seealso>
    let ont00000282 = Prefixed_Name(comcore, "ont00000282") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cylindrical"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000283">https://www.commoncoreontologies.org/ont00000283</seealso>
    let ont00000283 = Prefixed_Name(comcore, "ont00000283") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Strength"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000284">https://www.commoncoreontologies.org/ont00000284</seealso>
    let ont00000284 = Prefixed_Name(comcore, "ont00000284") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Emergency Locator Transmitter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000285">https://www.commoncoreontologies.org/ont00000285</seealso>
    let ont00000285 = Prefixed_Name(comcore, "ont00000285") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000286</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Partially Mission Capable Maintenance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000286">https://www.commoncoreontologies.org/ont00000286</seealso>
    let ont00000286 = Prefixed_Name(comcore, "ont00000286") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000287</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inertial Navigation System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000287">https://www.commoncoreontologies.org/ont00000287</seealso>
    let ont00000287 = Prefixed_Name(comcore, "ont00000287") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000288</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000288">https://www.commoncoreontologies.org/ont00000288</seealso>
    let ont00000288 = Prefixed_Name(comcore, "ont00000288") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000289</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radar Imaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000289">https://www.commoncoreontologies.org/ont00000289</seealso>
    let ont00000289 = Prefixed_Name(comcore, "ont00000289") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000290</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Specifically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000290">https://www.commoncoreontologies.org/ont00000290</seealso>
    let ont00000290 = Prefixed_Name(comcore, "ont00000290") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000291</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Decoy Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000291">https://www.commoncoreontologies.org/ont00000291</seealso>
    let ont00000291 = Prefixed_Name(comcore, "ont00000291") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000292</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000292">https://www.commoncoreontologies.org/ont00000292</seealso>
    let ont00000292 = Prefixed_Name(comcore, "ont00000292") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000293</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nominal Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000293">https://www.commoncoreontologies.org/ont00000293</seealso>
    let ont00000293 = Prefixed_Name(comcore, "ont00000293") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000294</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Air-Breathing Jet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000294">https://www.commoncoreontologies.org/ont00000294</seealso>
    let ont00000294 = Prefixed_Name(comcore, "ont00000294") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wetness"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000295">https://www.commoncoreontologies.org/ont00000295</seealso>
    let ont00000295 = Prefixed_Name(comcore, "ont00000295") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Angular Velocity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000296">https://www.commoncoreontologies.org/ont00000296</seealso>
    let ont00000296 = Prefixed_Name(comcore, "ont00000296") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000297</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Hydrosphere"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000297">https://www.commoncoreontologies.org/ont00000297</seealso>
    let ont00000297 = Prefixed_Name(comcore, "ont00000297") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000298</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shoulder-Fired Rocket Launcher"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000298">https://www.commoncoreontologies.org/ont00000298</seealso>
    let ont00000298 = Prefixed_Name(comcore, "ont00000298") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000299</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prosthetic Leg"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000299">https://www.commoncoreontologies.org/ont00000299</seealso>
    let ont00000299 = Prefixed_Name(comcore, "ont00000299") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Group of Agents"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000300">https://www.commoncoreontologies.org/ont00000300</seealso>
    let ont00000300 = Prefixed_Name(comcore, "ont00000300") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Transmission"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000301">https://www.commoncoreontologies.org/ont00000301</seealso>
    let ont00000301 = Prefixed_Name(comcore, "ont00000301") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Alternating Current Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000302">https://www.commoncoreontologies.org/ont00000302</seealso>
    let ont00000302 = Prefixed_Name(comcore, "ont00000302") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000303</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Intercommunication System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000303">https://www.commoncoreontologies.org/ont00000303</seealso>
    let ont00000303 = Prefixed_Name(comcore, "ont00000303") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Microscope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000304">https://www.commoncoreontologies.org/ont00000304</seealso>
    let ont00000304 = Prefixed_Name(comcore, "ont00000304") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000305</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Pressure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000305">https://www.commoncoreontologies.org/ont00000305</seealso>
    let ont00000305 = Prefixed_Name(comcore, "ont00000305") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hinge"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000306">https://www.commoncoreontologies.org/ont00000306</seealso>
    let ont00000306 = Prefixed_Name(comcore, "ont00000306") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Food"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000307">https://www.commoncoreontologies.org/ont00000307</seealso>
    let ont00000307 = Prefixed_Name(comcore, "ont00000307") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Military Service"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000308">https://www.commoncoreontologies.org/ont00000308</seealso>
    let ont00000308 = Prefixed_Name(comcore, "ont00000308") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Healthcare Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000309">https://www.commoncoreontologies.org/ont00000309</seealso>
    let ont00000309 = Prefixed_Name(comcore, "ont00000309") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Grenade"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000310">https://www.commoncoreontologies.org/ont00000310</seealso>
    let ont00000310 = Prefixed_Name(comcore, "ont00000310") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Filtration Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000311">https://www.commoncoreontologies.org/ont00000311</seealso>
    let ont00000311 = Prefixed_Name(comcore, "ont00000311") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000312</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propulsion Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000312">https://www.commoncoreontologies.org/ont00000312</seealso>
    let ont00000312 = Prefixed_Name(comcore, "ont00000312") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000313</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wavelength"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000313">https://www.commoncoreontologies.org/ont00000313</seealso>
    let ont00000313 = Prefixed_Name(comcore, "ont00000313") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000314</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Quality Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000314">https://www.commoncoreontologies.org/ont00000314</seealso>
    let ont00000314 = Prefixed_Name(comcore, "ont00000314") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000315</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Switching Node"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000315">https://www.commoncoreontologies.org/ont00000315</seealso>
    let ont00000315 = Prefixed_Name(comcore, "ont00000315") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Helium"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000316">https://www.commoncoreontologies.org/ont00000316</seealso>
    let ont00000316 = Prefixed_Name(comcore, "ont00000316") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000317</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electronic Signal Processing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000317">https://www.commoncoreontologies.org/ont00000317</seealso>
    let ont00000317 = Prefixed_Name(comcore, "ont00000317") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000318</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Disease"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000318">https://www.commoncoreontologies.org/ont00000318</seealso>
    let ont00000318 = Prefixed_Name(comcore, "ont00000318") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000319</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Design"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000319">https://www.commoncoreontologies.org/ont00000319</seealso>
    let ont00000319 = Prefixed_Name(comcore, "ont00000319") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Reconnaissance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000320">https://www.commoncoreontologies.org/ont00000320</seealso>
    let ont00000320 = Prefixed_Name(comcore, "ont00000320") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000321</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Residential Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000321">https://www.commoncoreontologies.org/ont00000321</seealso>
    let ont00000321 = Prefixed_Name(comcore, "ont00000321") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000322</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Funding"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000322">https://www.commoncoreontologies.org/ont00000322</seealso>
    let ont00000322 = Prefixed_Name(comcore, "ont00000322") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000323">https://www.commoncoreontologies.org/ont00000323</seealso>
    let ont00000323 = Prefixed_Name(comcore, "ont00000323") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000324</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Width"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000324">https://www.commoncoreontologies.org/ont00000324</seealso>
    let ont00000324 = Prefixed_Name(comcore, "ont00000324") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Transponder"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000325">https://www.commoncoreontologies.org/ont00000325</seealso>
    let ont00000325 = Prefixed_Name(comcore, "ont00000325") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000326</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a UPC Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000326">https://www.commoncoreontologies.org/ont00000326</seealso>
    let ont00000326 = Prefixed_Name(comcore, "ont00000326") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000327</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Texture"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000327">https://www.commoncoreontologies.org/ont00000327</seealso>
    let ont00000327 = Prefixed_Name(comcore, "ont00000327") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000328</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transportation Infrastructure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000328">https://www.commoncoreontologies.org/ont00000328</seealso>
    let ont00000328 = Prefixed_Name(comcore, "ont00000328") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000329</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Month Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000329">https://www.commoncoreontologies.org/ont00000329</seealso>
    let ont00000329 = Prefixed_Name(comcore, "ont00000329") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000330</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermal Power Plant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000330">https://www.commoncoreontologies.org/ont00000330</seealso>
    let ont00000330 = Prefixed_Name(comcore, "ont00000330") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000331</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"House"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000331">https://www.commoncoreontologies.org/ont00000331</seealso>
    let ont00000331 = Prefixed_Name(comcore, "ont00000331") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000332</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Training Camp"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000332">https://www.commoncoreontologies.org/ont00000332</seealso>
    let ont00000332 = Prefixed_Name(comcore, "ont00000332") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000333</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas Turbine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000333">https://www.commoncoreontologies.org/ont00000333</seealso>
    let ont00000333 = Prefixed_Name(comcore, "ont00000333") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000334</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interphone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000334">https://www.commoncoreontologies.org/ont00000334</seealso>
    let ont00000334 = Prefixed_Name(comcore, "ont00000334") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Generically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000335">https://www.commoncoreontologies.org/ont00000335</seealso>
    let ont00000335 = Prefixed_Name(comcore, "ont00000335") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000336</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Apartment Building"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000336">https://www.commoncoreontologies.org/ont00000336</seealso>
    let ont00000336 = Prefixed_Name(comcore, "ont00000336") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rocket-Propelled Grenade"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000337">https://www.commoncoreontologies.org/ont00000337</seealso>
    let ont00000337 = Prefixed_Name(comcore, "ont00000337") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fan"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000338">https://www.commoncoreontologies.org/ont00000338</seealso>
    let ont00000338 = Prefixed_Name(comcore, "ont00000338") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000339</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agricultural Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000339">https://www.commoncoreontologies.org/ont00000339</seealso>
    let ont00000339 = Prefixed_Name(comcore, "ont00000339") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mortar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000340">https://www.commoncoreontologies.org/ont00000340</seealso>
    let ont00000340 = Prefixed_Name(comcore, "ont00000340") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prosthetic Arm"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000341">https://www.commoncoreontologies.org/ont00000341</seealso>
    let ont00000341 = Prefixed_Name(comcore, "ont00000341") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Brake"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000342">https://www.commoncoreontologies.org/ont00000342</seealso>
    let ont00000342 = Prefixed_Name(comcore, "ont00000342") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reciprocating Steam Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000343">https://www.commoncoreontologies.org/ont00000343</seealso>
    let ont00000343 = Prefixed_Name(comcore, "ont00000343") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Surfactant Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000344">https://www.commoncoreontologies.org/ont00000344</seealso>
    let ont00000344 = Prefixed_Name(comcore, "ont00000344") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Measuring"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000345">https://www.commoncoreontologies.org/ont00000345</seealso>
    let ont00000345 = Prefixed_Name(comcore, "ont00000345") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000346">https://www.commoncoreontologies.org/ont00000346</seealso>
    let ont00000346 = Prefixed_Name(comcore, "ont00000346") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electronic Bond"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000347">https://www.commoncoreontologies.org/ont00000347</seealso>
    let ont00000347 = Prefixed_Name(comcore, "ont00000347") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000348</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Filter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000348">https://www.commoncoreontologies.org/ont00000348</seealso>
    let ont00000348 = Prefixed_Name(comcore, "ont00000348") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000349</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Police Station"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000349">https://www.commoncoreontologies.org/ont00000349</seealso>
    let ont00000349 = Prefixed_Name(comcore, "ont00000349") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000350</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cooling System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000350">https://www.commoncoreontologies.org/ont00000350</seealso>
    let ont00000350 = Prefixed_Name(comcore, "ont00000350") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Commanding"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000351">https://www.commoncoreontologies.org/ont00000351</seealso>
    let ont00000351 = Prefixed_Name(comcore, "ont00000351") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Satellite Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000352">https://www.commoncoreontologies.org/ont00000352</seealso>
    let ont00000352 = Prefixed_Name(comcore, "ont00000352") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000353">https://www.commoncoreontologies.org/ont00000353</seealso>
    let ont00000353 = Prefixed_Name(comcore, "ont00000353") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000354</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Testifying"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000354">https://www.commoncoreontologies.org/ont00000354</seealso>
    let ont00000354 = Prefixed_Name(comcore, "ont00000354") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000355</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refracting Optical Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000355">https://www.commoncoreontologies.org/ont00000355</seealso>
    let ont00000355 = Prefixed_Name(comcore, "ont00000355") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000356</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Publishing Mass Media Article"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000356">https://www.commoncoreontologies.org/ont00000356</seealso>
    let ont00000356 = Prefixed_Name(comcore, "ont00000356") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000357</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000357">https://www.commoncoreontologies.org/ont00000357</seealso>
    let ont00000357 = Prefixed_Name(comcore, "ont00000357") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Region Bounding Box"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000358">https://www.commoncoreontologies.org/ont00000358</seealso>
    let ont00000358 = Prefixed_Name(comcore, "ont00000358") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Date"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000359">https://www.commoncoreontologies.org/ont00000359</seealso>
    let ont00000359 = Prefixed_Name(comcore, "ont00000359") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wounded Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000360">https://www.commoncoreontologies.org/ont00000360</seealso>
    let ont00000360 = Prefixed_Name(comcore, "ont00000360") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000361</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000361">https://www.commoncoreontologies.org/ont00000361</seealso>
    let ont00000361 = Prefixed_Name(comcore, "ont00000361") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rocket Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000362">https://www.commoncoreontologies.org/ont00000362</seealso>
    let ont00000362 = Prefixed_Name(comcore, "ont00000362") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000363</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wireless Telecommunication Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000363">https://www.commoncoreontologies.org/ont00000363</seealso>
    let ont00000363 = Prefixed_Name(comcore, "ont00000363") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000364</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pneumatic Motor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000364">https://www.commoncoreontologies.org/ont00000364</seealso>
    let ont00000364 = Prefixed_Name(comcore, "ont00000364") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000365</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"x-Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000365">https://www.commoncoreontologies.org/ont00000365</seealso>
    let ont00000365 = Prefixed_Name(comcore, "ont00000365") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000366</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Information Processing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000366">https://www.commoncoreontologies.org/ont00000366</seealso>
    let ont00000366 = Prefixed_Name(comcore, "ont00000366") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Military Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000367">https://www.commoncoreontologies.org/ont00000367</seealso>
    let ont00000367 = Prefixed_Name(comcore, "ont00000367") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000368</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rotational Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000368">https://www.commoncoreontologies.org/ont00000368</seealso>
    let ont00000368 = Prefixed_Name(comcore, "ont00000368") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Priority Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000369">https://www.commoncoreontologies.org/ont00000369</seealso>
    let ont00000369 = Prefixed_Name(comcore, "ont00000369") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000370</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Condoling"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000370">https://www.commoncoreontologies.org/ont00000370</seealso>
    let ont00000370 = Prefixed_Name(comcore, "ont00000370") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Prediction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000371">https://www.commoncoreontologies.org/ont00000371</seealso>
    let ont00000371 = Prefixed_Name(comcore, "ont00000371") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000372</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Transformer Rectifier Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000372">https://www.commoncoreontologies.org/ont00000372</seealso>
    let ont00000372 = Prefixed_Name(comcore, "ont00000372") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000373</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Position"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000373">https://www.commoncoreontologies.org/ont00000373</seealso>
    let ont00000373 = Prefixed_Name(comcore, "ont00000373") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Volumetric Flow Rate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000374">https://www.commoncoreontologies.org/ont00000374</seealso>
    let ont00000374 = Prefixed_Name(comcore, "ont00000374") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Warehouse"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000375">https://www.commoncoreontologies.org/ont00000375</seealso>
    let ont00000375 = Prefixed_Name(comcore, "ont00000375") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Gallium Arsenide"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000376">https://www.commoncoreontologies.org/ont00000376</seealso>
    let ont00000376 = Prefixed_Name(comcore, "ont00000376") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Disability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000377">https://www.commoncoreontologies.org/ont00000377</seealso>
    let ont00000377 = Prefixed_Name(comcore, "ont00000377") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000378</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Color"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000378">https://www.commoncoreontologies.org/ont00000378</seealso>
    let ont00000378 = Prefixed_Name(comcore, "ont00000378") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000379</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Representative Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000379">https://www.commoncoreontologies.org/ont00000379</seealso>
    let ont00000379 = Prefixed_Name(comcore, "ont00000379") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000380</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pressure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000380">https://www.commoncoreontologies.org/ont00000380</seealso>
    let ont00000380 = Prefixed_Name(comcore, "ont00000380") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000381</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Weapon Manufacturing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000381">https://www.commoncoreontologies.org/ont00000381</seealso>
    let ont00000381 = Prefixed_Name(comcore, "ont00000381") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000382</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Spreadsheet"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000382">https://www.commoncoreontologies.org/ont00000382</seealso>
    let ont00000382 = Prefixed_Name(comcore, "ont00000382") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000383</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Family"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000383">https://www.commoncoreontologies.org/ont00000383</seealso>
    let ont00000383 = Prefixed_Name(comcore, "ont00000383") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rectilinear Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000384">https://www.commoncoreontologies.org/ont00000384</seealso>
    let ont00000384 = Prefixed_Name(comcore, "ont00000384") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000385</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wide"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000385">https://www.commoncoreontologies.org/ont00000385</seealso>
    let ont00000385 = Prefixed_Name(comcore, "ont00000385") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000386</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Webcast"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000386">https://www.commoncoreontologies.org/ont00000386</seealso>
    let ont00000386 = Prefixed_Name(comcore, "ont00000386") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000387</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Axis of Rotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000387">https://www.commoncoreontologies.org/ont00000387</seealso>
    let ont00000387 = Prefixed_Name(comcore, "ont00000387") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000388</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Citizen"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000388">https://www.commoncoreontologies.org/ont00000388</seealso>
    let ont00000388 = Prefixed_Name(comcore, "ont00000388") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000389</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Buying"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000389">https://www.commoncoreontologies.org/ont00000389</seealso>
    let ont00000389 = Prefixed_Name(comcore, "ont00000389") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spatial Region Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000390">https://www.commoncoreontologies.org/ont00000390</seealso>
    let ont00000390 = Prefixed_Name(comcore, "ont00000390") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000391</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tremendously High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000391">https://www.commoncoreontologies.org/ont00000391</seealso>
    let ont00000391 = Prefixed_Name(comcore, "ont00000391") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000392</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Allegiance Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000392">https://www.commoncoreontologies.org/ont00000392</seealso>
    let ont00000392 = Prefixed_Name(comcore, "ont00000392") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Yaw Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000393">https://www.commoncoreontologies.org/ont00000393</seealso>
    let ont00000393 = Prefixed_Name(comcore, "ont00000393") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000394</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Internal Combustion Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000394">https://www.commoncoreontologies.org/ont00000394</seealso>
    let ont00000394 = Prefixed_Name(comcore, "ont00000394") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000395</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Specifically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000395">https://www.commoncoreontologies.org/ont00000395</seealso>
    let ont00000395 = Prefixed_Name(comcore, "ont00000395") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000396</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Extremely Low Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000396">https://www.commoncoreontologies.org/ont00000396</seealso>
    let ont00000396 = Prefixed_Name(comcore, "ont00000396") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000397</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Combustion Chamber"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000397">https://www.commoncoreontologies.org/ont00000397</seealso>
    let ont00000397 = Prefixed_Name(comcore, "ont00000397") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000398</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000398">https://www.commoncoreontologies.org/ont00000398</seealso>
    let ont00000398 = Prefixed_Name(comcore, "ont00000398") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000399</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Region Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000399">https://www.commoncoreontologies.org/ont00000399</seealso>
    let ont00000399 = Prefixed_Name(comcore, "ont00000399") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000400</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Park"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000400">https://www.commoncoreontologies.org/ont00000400</seealso>
    let ont00000400 = Prefixed_Name(comcore, "ont00000400") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000401</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fundamental Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000401">https://www.commoncoreontologies.org/ont00000401</seealso>
    let ont00000401 = Prefixed_Name(comcore, "ont00000401") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000402</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000402">https://www.commoncoreontologies.org/ont00000402</seealso>
    let ont00000402 = Prefixed_Name(comcore, "ont00000402") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000403</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Diffraction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000403">https://www.commoncoreontologies.org/ont00000403</seealso>
    let ont00000403 = Prefixed_Name(comcore, "ont00000403") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000404</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Iris"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000404">https://www.commoncoreontologies.org/ont00000404</seealso>
    let ont00000404 = Prefixed_Name(comcore, "ont00000404") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000405</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Second-Order Administrative Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000405">https://www.commoncoreontologies.org/ont00000405</seealso>
    let ont00000405 = Prefixed_Name(comcore, "ont00000405") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000406</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Geocoordinate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000406">https://www.commoncoreontologies.org/ont00000406</seealso>
    let ont00000406 = Prefixed_Name(comcore, "ont00000406") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000407</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Resistance Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000407">https://www.commoncoreontologies.org/ont00000407</seealso>
    let ont00000407 = Prefixed_Name(comcore, "ont00000407") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000408</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000408">https://www.commoncoreontologies.org/ont00000408</seealso>
    let ont00000408 = Prefixed_Name(comcore, "ont00000408") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000409</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spark Ignition System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000409">https://www.commoncoreontologies.org/ont00000409</seealso>
    let ont00000409 = Prefixed_Name(comcore, "ont00000409") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000410</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Residential Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000410">https://www.commoncoreontologies.org/ont00000410</seealso>
    let ont00000410 = Prefixed_Name(comcore, "ont00000410") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000411</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Speed Measurement Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000411">https://www.commoncoreontologies.org/ont00000411</seealso>
    let ont00000411 = Prefixed_Name(comcore, "ont00000411") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000412</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oxidizer Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000412">https://www.commoncoreontologies.org/ont00000412</seealso>
    let ont00000412 = Prefixed_Name(comcore, "ont00000412") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000413</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electron Microscope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000413">https://www.commoncoreontologies.org/ont00000413</seealso>
    let ont00000413 = Prefixed_Name(comcore, "ont00000413") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000414</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Square Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000414">https://www.commoncoreontologies.org/ont00000414</seealso>
    let ont00000414 = Prefixed_Name(comcore, "ont00000414") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000415</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Anti-Microbial Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000415">https://www.commoncoreontologies.org/ont00000415</seealso>
    let ont00000415 = Prefixed_Name(comcore, "ont00000415") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000416</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Publishing Mass Media Press Release"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000416">https://www.commoncoreontologies.org/ont00000416</seealso>
    let ont00000416 = Prefixed_Name(comcore, "ont00000416") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000417</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prosthetic Hand"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000417">https://www.commoncoreontologies.org/ont00000417</seealso>
    let ont00000417 = Prefixed_Name(comcore, "ont00000417") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000418</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biographical Life"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000418">https://www.commoncoreontologies.org/ont00000418</seealso>
    let ont00000418 = Prefixed_Name(comcore, "ont00000418") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000419</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Part Number"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000419">https://www.commoncoreontologies.org/ont00000419</seealso>
    let ont00000419 = Prefixed_Name(comcore, "ont00000419") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000420</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Computer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000420">https://www.commoncoreontologies.org/ont00000420</seealso>
    let ont00000420 = Prefixed_Name(comcore, "ont00000420") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000421</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Power Plant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000421">https://www.commoncoreontologies.org/ont00000421</seealso>
    let ont00000421 = Prefixed_Name(comcore, "ont00000421") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000422</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication Reception Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000422">https://www.commoncoreontologies.org/ont00000422</seealso>
    let ont00000422 = Prefixed_Name(comcore, "ont00000422") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000423</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motor Vehicle Manufacturing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000423">https://www.commoncoreontologies.org/ont00000423</seealso>
    let ont00000423 = Prefixed_Name(comcore, "ont00000423") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000424</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sharp"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000424">https://www.commoncoreontologies.org/ont00000424</seealso>
    let ont00000424 = Prefixed_Name(comcore, "ont00000424") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gregorian Year"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000425">https://www.commoncoreontologies.org/ont00000425</seealso>
    let ont00000425 = Prefixed_Name(comcore, "ont00000425") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000426</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Personnel Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000426">https://www.commoncoreontologies.org/ont00000426</seealso>
    let ont00000426 = Prefixed_Name(comcore, "ont00000426") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000427</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Armored Fighting Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000427">https://www.commoncoreontologies.org/ont00000427</seealso>
    let ont00000427 = Prefixed_Name(comcore, "ont00000427") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000428</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Railway Junction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000428">https://www.commoncoreontologies.org/ont00000428</seealso>
    let ont00000428 = Prefixed_Name(comcore, "ont00000428") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000429</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Codabar Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000429">https://www.commoncoreontologies.org/ont00000429</seealso>
    let ont00000429 = Prefixed_Name(comcore, "ont00000429") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000430</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stable Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000430">https://www.commoncoreontologies.org/ont00000430</seealso>
    let ont00000430 = Prefixed_Name(comcore, "ont00000430") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000431</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"External Combustion Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000431">https://www.commoncoreontologies.org/ont00000431</seealso>
    let ont00000431 = Prefixed_Name(comcore, "ont00000431") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000432</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Missile Launch Site"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000432">https://www.commoncoreontologies.org/ont00000432</seealso>
    let ont00000432 = Prefixed_Name(comcore, "ont00000432") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000433</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Association"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000433">https://www.commoncoreontologies.org/ont00000433</seealso>
    let ont00000433 = Prefixed_Name(comcore, "ont00000433") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000434</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Simple Optical Lens"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000434">https://www.commoncoreontologies.org/ont00000434</seealso>
    let ont00000434 = Prefixed_Name(comcore, "ont00000434") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000435</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gregorian Day"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000435">https://www.commoncoreontologies.org/ont00000435</seealso>
    let ont00000435 = Prefixed_Name(comcore, "ont00000435") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000436</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"X-ray Microscope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000436">https://www.commoncoreontologies.org/ont00000436</seealso>
    let ont00000436 = Prefixed_Name(comcore, "ont00000436") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000437</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Enhancing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000437">https://www.commoncoreontologies.org/ont00000437</seealso>
    let ont00000437 = Prefixed_Name(comcore, "ont00000437") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000438</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Official Documentation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000438">https://www.commoncoreontologies.org/ont00000438</seealso>
    let ont00000438 = Prefixed_Name(comcore, "ont00000438") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000439</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Black"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000439">https://www.commoncoreontologies.org/ont00000439</seealso>
    let ont00000439 = Prefixed_Name(comcore, "ont00000439") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000440</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Watercraft"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000440">https://www.commoncoreontologies.org/ont00000440</seealso>
    let ont00000440 = Prefixed_Name(comcore, "ont00000440") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000441</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000441">https://www.commoncoreontologies.org/ont00000441</seealso>
    let ont00000441 = Prefixed_Name(comcore, "ont00000441") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000442</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radioactive"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000442">https://www.commoncoreontologies.org/ont00000442</seealso>
    let ont00000442 = Prefixed_Name(comcore, "ont00000442") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000443</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Commercial Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000443">https://www.commoncoreontologies.org/ont00000443</seealso>
    let ont00000443 = Prefixed_Name(comcore, "ont00000443") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000444</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Energy"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000444">https://www.commoncoreontologies.org/ont00000444</seealso>
    let ont00000444 = Prefixed_Name(comcore, "ont00000444") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000445</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000445">https://www.commoncoreontologies.org/ont00000445</seealso>
    let ont00000445 = Prefixed_Name(comcore, "ont00000445") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000446</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Circumference"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000446">https://www.commoncoreontologies.org/ont00000446</seealso>
    let ont00000446 = Prefixed_Name(comcore, "ont00000446") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000447</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Triangular"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000447">https://www.commoncoreontologies.org/ont00000447</seealso>
    let ont00000447 = Prefixed_Name(comcore, "ont00000447") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000448</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motion Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000448">https://www.commoncoreontologies.org/ont00000448</seealso>
    let ont00000448 = Prefixed_Name(comcore, "ont00000448") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000449</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Remuneration"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000449">https://www.commoncoreontologies.org/ont00000449</seealso>
    let ont00000449 = Prefixed_Name(comcore, "ont00000449") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000450</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Silver Color"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000450">https://www.commoncoreontologies.org/ont00000450</seealso>
    let ont00000450 = Prefixed_Name(comcore, "ont00000450") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000451</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Collimation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000451">https://www.commoncoreontologies.org/ont00000451</seealso>
    let ont00000451 = Prefixed_Name(comcore, "ont00000451") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000452</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Timekeeping Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000452">https://www.commoncoreontologies.org/ont00000452</seealso>
    let ont00000452 = Prefixed_Name(comcore, "ont00000452") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000453</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Environment Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000453">https://www.commoncoreontologies.org/ont00000453</seealso>
    let ont00000453 = Prefixed_Name(comcore, "ont00000453") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000454</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Compression Ignition System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000454">https://www.commoncoreontologies.org/ont00000454</seealso>
    let ont00000454 = Prefixed_Name(comcore, "ont00000454") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000455</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Ceremony"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000455">https://www.commoncoreontologies.org/ont00000455</seealso>
    let ont00000455 = Prefixed_Name(comcore, "ont00000455") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000456</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Railway"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000456">https://www.commoncoreontologies.org/ont00000456</seealso>
    let ont00000456 = Prefixed_Name(comcore, "ont00000456") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000457</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Material"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000457">https://www.commoncoreontologies.org/ont00000457</seealso>
    let ont00000457 = Prefixed_Name(comcore, "ont00000457") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000458</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coupling"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000458">https://www.commoncoreontologies.org/ont00000458</seealso>
    let ont00000458 = Prefixed_Name(comcore, "ont00000458") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000459</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fluorescence"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000459">https://www.commoncoreontologies.org/ont00000459</seealso>
    let ont00000459 = Prefixed_Name(comcore, "ont00000459") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000460</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Local Administrative Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000460">https://www.commoncoreontologies.org/ont00000460</seealso>
    let ont00000460 = Prefixed_Name(comcore, "ont00000460") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000461</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a ISSN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000461">https://www.commoncoreontologies.org/ont00000461</seealso>
    let ont00000461 = Prefixed_Name(comcore, "ont00000461") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000462</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000462">https://www.commoncoreontologies.org/ont00000462</seealso>
    let ont00000462 = Prefixed_Name(comcore, "ont00000462") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000463</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Educational Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000463">https://www.commoncoreontologies.org/ont00000463</seealso>
    let ont00000463 = Prefixed_Name(comcore, "ont00000463") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000464</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oblong"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000464">https://www.commoncoreontologies.org/ont00000464</seealso>
    let ont00000464 = Prefixed_Name(comcore, "ont00000464") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000465</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modified Julian Date"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000465">https://www.commoncoreontologies.org/ont00000465</seealso>
    let ont00000465 = Prefixed_Name(comcore, "ont00000465") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000466</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orientation Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000466">https://www.commoncoreontologies.org/ont00000466</seealso>
    let ont00000466 = Prefixed_Name(comcore, "ont00000466") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000467</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Armored Personnel Carrier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000467">https://www.commoncoreontologies.org/ont00000467</seealso>
    let ont00000467 = Prefixed_Name(comcore, "ont00000467") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000468</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Office Building"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000468">https://www.commoncoreontologies.org/ont00000468</seealso>
    let ont00000468 = Prefixed_Name(comcore, "ont00000468") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000469</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Coordinate Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000469">https://www.commoncoreontologies.org/ont00000469</seealso>
    let ont00000469 = Prefixed_Name(comcore, "ont00000469") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000470</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Academic Degree"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000470">https://www.commoncoreontologies.org/ont00000470</seealso>
    let ont00000470 = Prefixed_Name(comcore, "ont00000470") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000471</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Warning Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000471">https://www.commoncoreontologies.org/ont00000471</seealso>
    let ont00000471 = Prefixed_Name(comcore, "ont00000471") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000472</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000472">https://www.commoncoreontologies.org/ont00000472</seealso>
    let ont00000472 = Prefixed_Name(comcore, "ont00000472") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000473</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fourth-Order Administrative Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000473">https://www.commoncoreontologies.org/ont00000473</seealso>
    let ont00000473 = Prefixed_Name(comcore, "ont00000473") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000474</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Curved"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000474">https://www.commoncoreontologies.org/ont00000474</seealso>
    let ont00000474 = Prefixed_Name(comcore, "ont00000474") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000475</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Cash"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000475">https://www.commoncoreontologies.org/ont00000475</seealso>
    let ont00000475 = Prefixed_Name(comcore, "ont00000475") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000476</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Objective"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000476">https://www.commoncoreontologies.org/ont00000476</seealso>
    let ont00000476 = Prefixed_Name(comcore, "ont00000476") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000477</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel Cell"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000477">https://www.commoncoreontologies.org/ont00000477</seealso>
    let ont00000477 = Prefixed_Name(comcore, "ont00000477") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000478</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cuboidal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000478">https://www.commoncoreontologies.org/ont00000478</seealso>
    let ont00000478 = Prefixed_Name(comcore, "ont00000478") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000479</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Public Safety Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000479">https://www.commoncoreontologies.org/ont00000479</seealso>
    let ont00000479 = Prefixed_Name(comcore, "ont00000479") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000480</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Life Support Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000480">https://www.commoncoreontologies.org/ont00000480</seealso>
    let ont00000480 = Prefixed_Name(comcore, "ont00000480") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000481</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research and Development Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000481">https://www.commoncoreontologies.org/ont00000481</seealso>
    let ont00000481 = Prefixed_Name(comcore, "ont00000481") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000482</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Synthetic Aperture Radar Imaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000482">https://www.commoncoreontologies.org/ont00000482</seealso>
    let ont00000482 = Prefixed_Name(comcore, "ont00000482") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000483</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Base"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000483">https://www.commoncoreontologies.org/ont00000483</seealso>
    let ont00000483 = Prefixed_Name(comcore, "ont00000483") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000484</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Concave Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000484">https://www.commoncoreontologies.org/ont00000484</seealso>
    let ont00000484 = Prefixed_Name(comcore, "ont00000484") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000485</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Commercial Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000485">https://www.commoncoreontologies.org/ont00000485</seealso>
    let ont00000485 = Prefixed_Name(comcore, "ont00000485") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000486</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neutral Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000486">https://www.commoncoreontologies.org/ont00000486</seealso>
    let ont00000486 = Prefixed_Name(comcore, "ont00000486") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000487</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Location"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000487">https://www.commoncoreontologies.org/ont00000487</seealso>
    let ont00000487 = Prefixed_Name(comcore, "ont00000487") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000488</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tripod"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000488">https://www.commoncoreontologies.org/ont00000488</seealso>
    let ont00000488 = Prefixed_Name(comcore, "ont00000488") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000489</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"High Density Residential Area"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000489">https://www.commoncoreontologies.org/ont00000489</seealso>
    let ont00000489 = Prefixed_Name(comcore, "ont00000489") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000490</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"X-ray Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000490">https://www.commoncoreontologies.org/ont00000490</seealso>
    let ont00000490 = Prefixed_Name(comcore, "ont00000490") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000491</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Detonating Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000491">https://www.commoncoreontologies.org/ont00000491</seealso>
    let ont00000491 = Prefixed_Name(comcore, "ont00000491") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000492</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Email Messaging"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000492">https://www.commoncoreontologies.org/ont00000492</seealso>
    let ont00000492 = Prefixed_Name(comcore, "ont00000492") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000493</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Code List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000493">https://www.commoncoreontologies.org/ont00000493</seealso>
    let ont00000493 = Prefixed_Name(comcore, "ont00000493") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000494</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Serrated"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000494">https://www.commoncoreontologies.org/ont00000494</seealso>
    let ont00000494 = Prefixed_Name(comcore, "ont00000494") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000495</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Communication Interference Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000495">https://www.commoncoreontologies.org/ont00000495</seealso>
    let ont00000495 = Prefixed_Name(comcore, "ont00000495") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000496</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Natural Language"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000496">https://www.commoncoreontologies.org/ont00000496</seealso>
    let ont00000496 = Prefixed_Name(comcore, "ont00000496") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000497</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000497">https://www.commoncoreontologies.org/ont00000497</seealso>
    let ont00000497 = Prefixed_Name(comcore, "ont00000497") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000498</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Day"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000498">https://www.commoncoreontologies.org/ont00000498</seealso>
    let ont00000498 = Prefixed_Name(comcore, "ont00000498") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000499</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wire Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000499">https://www.commoncoreontologies.org/ont00000499</seealso>
    let ont00000499 = Prefixed_Name(comcore, "ont00000499") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000500</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Eye"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000500">https://www.commoncoreontologies.org/ont00000500</seealso>
    let ont00000500 = Prefixed_Name(comcore, "ont00000500") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000501</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Financial Withdrawal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000501">https://www.commoncoreontologies.org/ont00000501</seealso>
    let ont00000501 = Prefixed_Name(comcore, "ont00000501") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000502</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Area Moment of Inertia"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000502">https://www.commoncoreontologies.org/ont00000502</seealso>
    let ont00000502 = Prefixed_Name(comcore, "ont00000502") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000503</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000503">https://www.commoncoreontologies.org/ont00000503</seealso>
    let ont00000503 = Prefixed_Name(comcore, "ont00000503") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000504</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Processing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000504">https://www.commoncoreontologies.org/ont00000504</seealso>
    let ont00000504 = Prefixed_Name(comcore, "ont00000504") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000506</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contractor Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000506">https://www.commoncoreontologies.org/ont00000506</seealso>
    let ont00000506 = Prefixed_Name(comcore, "ont00000506") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000507</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ethnic Group"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000507">https://www.commoncoreontologies.org/ont00000507</seealso>
    let ont00000507 = Prefixed_Name(comcore, "ont00000507") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000508</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Near Ultraviolet Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000508">https://www.commoncoreontologies.org/ont00000508</seealso>
    let ont00000508 = Prefixed_Name(comcore, "ont00000508") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000509</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service Provider"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000509">https://www.commoncoreontologies.org/ont00000509</seealso>
    let ont00000509 = Prefixed_Name(comcore, "ont00000509") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000510</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mosque"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000510">https://www.commoncoreontologies.org/ont00000510</seealso>
    let ont00000510 = Prefixed_Name(comcore, "ont00000510") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000511</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Planning"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000511">https://www.commoncoreontologies.org/ont00000511</seealso>
    let ont00000511 = Prefixed_Name(comcore, "ont00000511") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiation Emissivity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000512">https://www.commoncoreontologies.org/ont00000512</seealso>
    let ont00000512 = Prefixed_Name(comcore, "ont00000512") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000513</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Tool Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000513">https://www.commoncoreontologies.org/ont00000513</seealso>
    let ont00000513 = Prefixed_Name(comcore, "ont00000513") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000514</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transverse Wave Profile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000514">https://www.commoncoreontologies.org/ont00000514</seealso>
    let ont00000514 = Prefixed_Name(comcore, "ont00000514") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000515</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Vehicle Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000515">https://www.commoncoreontologies.org/ont00000515</seealso>
    let ont00000515 = Prefixed_Name(comcore, "ont00000515") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000516</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pneumatic Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000516">https://www.commoncoreontologies.org/ont00000516</seealso>
    let ont00000516 = Prefixed_Name(comcore, "ont00000516") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000517</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Communication by Media"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000517">https://www.commoncoreontologies.org/ont00000517</seealso>
    let ont00000517 = Prefixed_Name(comcore, "ont00000517") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000518</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Currency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000518">https://www.commoncoreontologies.org/ont00000518</seealso>
    let ont00000518 = Prefixed_Name(comcore, "ont00000518") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000519</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Extremely High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000519">https://www.commoncoreontologies.org/ont00000519</seealso>
    let ont00000519 = Prefixed_Name(comcore, "ont00000519") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000520</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Departure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000520">https://www.commoncoreontologies.org/ont00000520</seealso>
    let ont00000520 = Prefixed_Name(comcore, "ont00000520") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000521</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Assassination"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000521">https://www.commoncoreontologies.org/ont00000521</seealso>
    let ont00000521 = Prefixed_Name(comcore, "ont00000521") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000522</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pulsejet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000522">https://www.commoncoreontologies.org/ont00000522</seealso>
    let ont00000522 = Prefixed_Name(comcore, "ont00000522") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000523</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loudness"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000523">https://www.commoncoreontologies.org/ont00000523</seealso>
    let ont00000523 = Prefixed_Name(comcore, "ont00000523") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Air Conditioning Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000524">https://www.commoncoreontologies.org/ont00000524</seealso>
    let ont00000524 = Prefixed_Name(comcore, "ont00000524") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000525</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transparent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000525">https://www.commoncoreontologies.org/ont00000525</seealso>
    let ont00000525 = Prefixed_Name(comcore, "ont00000525") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000526</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gamma-ray Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000526">https://www.commoncoreontologies.org/ont00000526</seealso>
    let ont00000526 = Prefixed_Name(comcore, "ont00000526") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000527</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Rotational Inertia"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000527">https://www.commoncoreontologies.org/ont00000527</seealso>
    let ont00000527 = Prefixed_Name(comcore, "ont00000527") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000528</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"White"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000528">https://www.commoncoreontologies.org/ont00000528</seealso>
    let ont00000528 = Prefixed_Name(comcore, "ont00000528") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000529</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Date Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000529">https://www.commoncoreontologies.org/ont00000529</seealso>
    let ont00000529 = Prefixed_Name(comcore, "ont00000529") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000530</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sonic Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000530">https://www.commoncoreontologies.org/ont00000530</seealso>
    let ont00000530 = Prefixed_Name(comcore, "ont00000530") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000531</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communications Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000531">https://www.commoncoreontologies.org/ont00000531</seealso>
    let ont00000531 = Prefixed_Name(comcore, "ont00000531") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000532</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government of a Country"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000532">https://www.commoncoreontologies.org/ont00000532</seealso>
    let ont00000532 = Prefixed_Name(comcore, "ont00000532") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000533</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Jet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000533">https://www.commoncoreontologies.org/ont00000533</seealso>
    let ont00000533 = Prefixed_Name(comcore, "ont00000533") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000534</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cutting Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000534">https://www.commoncoreontologies.org/ont00000534</seealso>
    let ont00000534 = Prefixed_Name(comcore, "ont00000534") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000535</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000535">https://www.commoncoreontologies.org/ont00000535</seealso>
    let ont00000535 = Prefixed_Name(comcore, "ont00000535") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000536</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bond Certificate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000536">https://www.commoncoreontologies.org/ont00000536</seealso>
    let ont00000536 = Prefixed_Name(comcore, "ont00000536") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000537</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000537">https://www.commoncoreontologies.org/ont00000537</seealso>
    let ont00000537 = Prefixed_Name(comcore, "ont00000537") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000538</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Defoliant Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000538">https://www.commoncoreontologies.org/ont00000538</seealso>
    let ont00000538 = Prefixed_Name(comcore, "ont00000538") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000539</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Count Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000539">https://www.commoncoreontologies.org/ont00000539</seealso>
    let ont00000539 = Prefixed_Name(comcore, "ont00000539") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000540</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Instant Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000540">https://www.commoncoreontologies.org/ont00000540</seealso>
    let ont00000540 = Prefixed_Name(comcore, "ont00000540") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000541</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Diameter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000541">https://www.commoncoreontologies.org/ont00000541</seealso>
    let ont00000541 = Prefixed_Name(comcore, "ont00000541") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000542</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Generically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000542">https://www.commoncoreontologies.org/ont00000542</seealso>
    let ont00000542 = Prefixed_Name(comcore, "ont00000542") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000543</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000543">https://www.commoncoreontologies.org/ont00000543</seealso>
    let ont00000543 = Prefixed_Name(comcore, "ont00000543") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000544</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Target"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000544">https://www.commoncoreontologies.org/ont00000544</seealso>
    let ont00000544 = Prefixed_Name(comcore, "ont00000544") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000545</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Seat of Local Government"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000545">https://www.commoncoreontologies.org/ont00000545</seealso>
    let ont00000545 = Prefixed_Name(comcore, "ont00000545") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000546</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unplanned Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000546">https://www.commoncoreontologies.org/ont00000546</seealso>
    let ont00000546 = Prefixed_Name(comcore, "ont00000546") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000547</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000547">https://www.commoncoreontologies.org/ont00000547</seealso>
    let ont00000547 = Prefixed_Name(comcore, "ont00000547") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000548</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vulnerability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000548">https://www.commoncoreontologies.org/ont00000548</seealso>
    let ont00000548 = Prefixed_Name(comcore, "ont00000548") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000549</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water Transportation Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000549">https://www.commoncoreontologies.org/ont00000549</seealso>
    let ont00000549 = Prefixed_Name(comcore, "ont00000549") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000550</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Morning"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000550">https://www.commoncoreontologies.org/ont00000550</seealso>
    let ont00000550 = Prefixed_Name(comcore, "ont00000550") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000551</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000551">https://www.commoncoreontologies.org/ont00000551</seealso>
    let ont00000551 = Prefixed_Name(comcore, "ont00000551") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000552</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Explosive Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000552">https://www.commoncoreontologies.org/ont00000552</seealso>
    let ont00000552 = Prefixed_Name(comcore, "ont00000552") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000553</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process Prohibition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000553">https://www.commoncoreontologies.org/ont00000553</seealso>
    let ont00000553 = Prefixed_Name(comcore, "ont00000553") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000554</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000554">https://www.commoncoreontologies.org/ont00000554</seealso>
    let ont00000554 = Prefixed_Name(comcore, "ont00000554") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000555</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Enhanced Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000555">https://www.commoncoreontologies.org/ont00000555</seealso>
    let ont00000555 = Prefixed_Name(comcore, "ont00000555") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000556</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Payload"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000556">https://www.commoncoreontologies.org/ont00000556</seealso>
    let ont00000556 = Prefixed_Name(comcore, "ont00000556") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000557</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Non-Mission Capable"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000557">https://www.commoncoreontologies.org/ont00000557</seealso>
    let ont00000557 = Prefixed_Name(comcore, "ont00000557") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000558</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Visible Light Reflection Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000558">https://www.commoncoreontologies.org/ont00000558</seealso>
    let ont00000558 = Prefixed_Name(comcore, "ont00000558") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000559</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a QR Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000559">https://www.commoncoreontologies.org/ont00000559</seealso>
    let ont00000559 = Prefixed_Name(comcore, "ont00000559") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000560</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cone Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000560">https://www.commoncoreontologies.org/ont00000560</seealso>
    let ont00000560 = Prefixed_Name(comcore, "ont00000560") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000561</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dam"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000561">https://www.commoncoreontologies.org/ont00000561</seealso>
    let ont00000561 = Prefixed_Name(comcore, "ont00000561") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000562</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Animal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000562">https://www.commoncoreontologies.org/ont00000562</seealso>
    let ont00000562 = Prefixed_Name(comcore, "ont00000562") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000563</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydrographic Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000563">https://www.commoncoreontologies.org/ont00000563</seealso>
    let ont00000563 = Prefixed_Name(comcore, "ont00000563") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000564</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Educational Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000564">https://www.commoncoreontologies.org/ont00000564</seealso>
    let ont00000564 = Prefixed_Name(comcore, "ont00000564") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cube Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000565">https://www.commoncoreontologies.org/ont00000565</seealso>
    let ont00000565 = Prefixed_Name(comcore, "ont00000565") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000566</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Artifact Employment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000566">https://www.commoncoreontologies.org/ont00000566</seealso>
    let ont00000566 = Prefixed_Name(comcore, "ont00000566") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000567</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operational Area"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000567">https://www.commoncoreontologies.org/ont00000567</seealso>
    let ont00000567 = Prefixed_Name(comcore, "ont00000567") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000568</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization Capability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000568">https://www.commoncoreontologies.org/ont00000568</seealso>
    let ont00000568 = Prefixed_Name(comcore, "ont00000568") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000569</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000569">https://www.commoncoreontologies.org/ont00000569</seealso>
    let ont00000569 = Prefixed_Name(comcore, "ont00000569") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000570</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000570">https://www.commoncoreontologies.org/ont00000570</seealso>
    let ont00000570 = Prefixed_Name(comcore, "ont00000570") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000571</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Article of Solid Waste"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000571">https://www.commoncoreontologies.org/ont00000571</seealso>
    let ont00000571 = Prefixed_Name(comcore, "ont00000571") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000572</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Production"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000572">https://www.commoncoreontologies.org/ont00000572</seealso>
    let ont00000572 = Prefixed_Name(comcore, "ont00000572") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000573</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Religious Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000573">https://www.commoncoreontologies.org/ont00000573</seealso>
    let ont00000573 = Prefixed_Name(comcore, "ont00000573") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000574</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Environmental Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000574">https://www.commoncoreontologies.org/ont00000574</seealso>
    let ont00000574 = Prefixed_Name(comcore, "ont00000574") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000575</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quality Specification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000575">https://www.commoncoreontologies.org/ont00000575</seealso>
    let ont00000575 = Prefixed_Name(comcore, "ont00000575") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000576</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scalp"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000576">https://www.commoncoreontologies.org/ont00000576</seealso>
    let ont00000576 = Prefixed_Name(comcore, "ont00000576") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000577</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Rectifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000577">https://www.commoncoreontologies.org/ont00000577</seealso>
    let ont00000577 = Prefixed_Name(comcore, "ont00000577") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000578</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sloped"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000578">https://www.commoncoreontologies.org/ont00000578</seealso>
    let ont00000578 = Prefixed_Name(comcore, "ont00000578") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000579</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thin"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000579">https://www.commoncoreontologies.org/ont00000579</seealso>
    let ont00000579 = Prefixed_Name(comcore, "ont00000579") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000580</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sine Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000580">https://www.commoncoreontologies.org/ont00000580</seealso>
    let ont00000580 = Prefixed_Name(comcore, "ont00000580") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000581</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tool"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000581">https://www.commoncoreontologies.org/ont00000581</seealso>
    let ont00000581 = Prefixed_Name(comcore, "ont00000581") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000582</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Code 93 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000582">https://www.commoncoreontologies.org/ont00000582</seealso>
    let ont00000582 = Prefixed_Name(comcore, "ont00000582") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000583</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000583">https://www.commoncoreontologies.org/ont00000583</seealso>
    let ont00000583 = Prefixed_Name(comcore, "ont00000583") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000584</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Position Change"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000584">https://www.commoncoreontologies.org/ont00000584</seealso>
    let ont00000584 = Prefixed_Name(comcore, "ont00000584") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000585</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sawtooth Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000585">https://www.commoncoreontologies.org/ont00000585</seealso>
    let ont00000585 = Prefixed_Name(comcore, "ont00000585") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000586</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Controllable Pitch Propeller"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000586">https://www.commoncoreontologies.org/ont00000586</seealso>
    let ont00000586 = Prefixed_Name(comcore, "ont00000586") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000587</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ally Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000587">https://www.commoncoreontologies.org/ont00000587</seealso>
    let ont00000587 = Prefixed_Name(comcore, "ont00000587") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000588</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Mass Media Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000588">https://www.commoncoreontologies.org/ont00000588</seealso>
    let ont00000588 = Prefixed_Name(comcore, "ont00000588") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000589</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Date Fraction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000589">https://www.commoncoreontologies.org/ont00000589</seealso>
    let ont00000589 = Prefixed_Name(comcore, "ont00000589") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000590</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Convex Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000590">https://www.commoncoreontologies.org/ont00000590</seealso>
    let ont00000590 = Prefixed_Name(comcore, "ont00000590") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000591</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Location"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000591">https://www.commoncoreontologies.org/ont00000591</seealso>
    let ont00000591 = Prefixed_Name(comcore, "ont00000591") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000592</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Veracity Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000592">https://www.commoncoreontologies.org/ont00000592</seealso>
    let ont00000592 = Prefixed_Name(comcore, "ont00000592") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000593</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Propellant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000593">https://www.commoncoreontologies.org/ont00000593</seealso>
    let ont00000593 = Prefixed_Name(comcore, "ont00000593") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000594</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ignition Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000594">https://www.commoncoreontologies.org/ont00000594</seealso>
    let ont00000594 = Prefixed_Name(comcore, "ont00000594") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000595</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Cargo Transportation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000595">https://www.commoncoreontologies.org/ont00000595</seealso>
    let ont00000595 = Prefixed_Name(comcore, "ont00000595") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000596</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a JAN-13 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000596">https://www.commoncoreontologies.org/ont00000596</seealso>
    let ont00000596 = Prefixed_Name(comcore, "ont00000596") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000597</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Instrument Display Panel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000597">https://www.commoncoreontologies.org/ont00000597</seealso>
    let ont00000597 = Prefixed_Name(comcore, "ont00000597") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000598</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000598">https://www.commoncoreontologies.org/ont00000598</seealso>
    let ont00000598 = Prefixed_Name(comcore, "ont00000598") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000599</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interpersonal Relationship Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000599">https://www.commoncoreontologies.org/ont00000599</seealso>
    let ont00000599 = Prefixed_Name(comcore, "ont00000599") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000600</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Legal Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000600">https://www.commoncoreontologies.org/ont00000600</seealso>
    let ont00000600 = Prefixed_Name(comcore, "ont00000600") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000601</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Imaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000601">https://www.commoncoreontologies.org/ont00000601</seealso>
    let ont00000601 = Prefixed_Name(comcore, "ont00000601") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000602</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a ITF Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000602">https://www.commoncoreontologies.org/ont00000602</seealso>
    let ont00000602 = Prefixed_Name(comcore, "ont00000602") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000603</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Navigation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000603">https://www.commoncoreontologies.org/ont00000603</seealso>
    let ont00000603 = Prefixed_Name(comcore, "ont00000603") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000604</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maximum Ordinal Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000604">https://www.commoncoreontologies.org/ont00000604</seealso>
    let ont00000604 = Prefixed_Name(comcore, "ont00000604") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Abbreviated Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000605">https://www.commoncoreontologies.org/ont00000605</seealso>
    let ont00000605 = Prefixed_Name(comcore, "ont00000605") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000606</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Truck"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000606">https://www.commoncoreontologies.org/ont00000606</seealso>
    let ont00000606 = Prefixed_Name(comcore, "ont00000606") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000607</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thickness"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000607">https://www.commoncoreontologies.org/ont00000607</seealso>
    let ont00000607 = Prefixed_Name(comcore, "ont00000607") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000608">https://www.commoncoreontologies.org/ont00000608</seealso>
    let ont00000608 = Prefixed_Name(comcore, "ont00000608") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000609</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000609">https://www.commoncoreontologies.org/ont00000609</seealso>
    let ont00000609 = Prefixed_Name(comcore, "ont00000609") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultraviolet Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000610">https://www.commoncoreontologies.org/ont00000610</seealso>
    let ont00000610 = Prefixed_Name(comcore, "ont00000610") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Realizable Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000611">https://www.commoncoreontologies.org/ont00000611</seealso>
    let ont00000611 = Prefixed_Name(comcore, "ont00000611") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000612</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Weapon Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000612">https://www.commoncoreontologies.org/ont00000612</seealso>
    let ont00000612 = Prefixed_Name(comcore, "ont00000612") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000613</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000613">https://www.commoncoreontologies.org/ont00000613</seealso>
    let ont00000613 = Prefixed_Name(comcore, "ont00000613") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000614</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mass"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000614">https://www.commoncoreontologies.org/ont00000614</seealso>
    let ont00000614 = Prefixed_Name(comcore, "ont00000614") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000615</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Encounter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000615">https://www.commoncoreontologies.org/ont00000615</seealso>
    let ont00000615 = Prefixed_Name(comcore, "ont00000615") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000616</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Religion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000616">https://www.commoncoreontologies.org/ont00000616</seealso>
    let ont00000616 = Prefixed_Name(comcore, "ont00000616") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000617</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrared Camera"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000617">https://www.commoncoreontologies.org/ont00000617</seealso>
    let ont00000617 = Prefixed_Name(comcore, "ont00000617") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000618</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ground Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000618">https://www.commoncoreontologies.org/ont00000618</seealso>
    let ont00000618 = Prefixed_Name(comcore, "ont00000618") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000619</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Week"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000619">https://www.commoncoreontologies.org/ont00000619</seealso>
    let ont00000619 = Prefixed_Name(comcore, "ont00000619") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000620</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiopacity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000620">https://www.commoncoreontologies.org/ont00000620</seealso>
    let ont00000620 = Prefixed_Name(comcore, "ont00000620") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inverse Sawtooth Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000621">https://www.commoncoreontologies.org/ont00000621</seealso>
    let ont00000621 = Prefixed_Name(comcore, "ont00000621") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000622</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Fully Mission Capable"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000622">https://www.commoncoreontologies.org/ont00000622</seealso>
    let ont00000622 = Prefixed_Name(comcore, "ont00000622") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000623</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Impact Shielding Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000623">https://www.commoncoreontologies.org/ont00000623</seealso>
    let ont00000623 = Prefixed_Name(comcore, "ont00000623") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Report"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000624">https://www.commoncoreontologies.org/ont00000624</seealso>
    let ont00000624 = Prefixed_Name(comcore, "ont00000624") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nozzle Throat"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000625">https://www.commoncoreontologies.org/ont00000625</seealso>
    let ont00000625 = Prefixed_Name(comcore, "ont00000625") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000626</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Predictive Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000626">https://www.commoncoreontologies.org/ont00000626</seealso>
    let ont00000626 = Prefixed_Name(comcore, "ont00000626") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000627</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrastructure Element"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000627">https://www.commoncoreontologies.org/ont00000627</seealso>
    let ont00000627 = Prefixed_Name(comcore, "ont00000627") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000628</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Disposition to Interact with Electromagnetic Radiation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000628">https://www.commoncoreontologies.org/ont00000628</seealso>
    let ont00000628 = Prefixed_Name(comcore, "ont00000628") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000629</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Deception Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000629">https://www.commoncoreontologies.org/ont00000629</seealso>
    let ont00000629 = Prefixed_Name(comcore, "ont00000629") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000630</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Universal Time Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000630">https://www.commoncoreontologies.org/ont00000630</seealso>
    let ont00000630 = Prefixed_Name(comcore, "ont00000630") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000631</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Territory of a Country"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000631">https://www.commoncoreontologies.org/ont00000631</seealso>
    let ont00000631 = Prefixed_Name(comcore, "ont00000631") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000632</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Magnetism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000632">https://www.commoncoreontologies.org/ont00000632</seealso>
    let ont00000632 = Prefixed_Name(comcore, "ont00000632") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000633</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Weight"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000633">https://www.commoncoreontologies.org/ont00000633</seealso>
    let ont00000633 = Prefixed_Name(comcore, "ont00000633") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000634</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Steam Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000634">https://www.commoncoreontologies.org/ont00000634</seealso>
    let ont00000634 = Prefixed_Name(comcore, "ont00000634") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000635</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refraction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000635">https://www.commoncoreontologies.org/ont00000635</seealso>
    let ont00000635 = Prefixed_Name(comcore, "ont00000635") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000636</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Appraisal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000636">https://www.commoncoreontologies.org/ont00000636</seealso>
    let ont00000636 = Prefixed_Name(comcore, "ont00000636") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000637</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Gaseous Propellant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000637">https://www.commoncoreontologies.org/ont00000637</seealso>
    let ont00000637 = Prefixed_Name(comcore, "ont00000637") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heat Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000638">https://www.commoncoreontologies.org/ont00000638</seealso>
    let ont00000638 = Prefixed_Name(comcore, "ont00000638") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000639</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000639">https://www.commoncoreontologies.org/ont00000639</seealso>
    let ont00000639 = Prefixed_Name(comcore, "ont00000639") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000640</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Email Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000640">https://www.commoncoreontologies.org/ont00000640</seealso>
    let ont00000640 = Prefixed_Name(comcore, "ont00000640") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000641</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Entertainment Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000641">https://www.commoncoreontologies.org/ont00000641</seealso>
    let ont00000641 = Prefixed_Name(comcore, "ont00000641") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000642</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Realizable Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000642">https://www.commoncoreontologies.org/ont00000642</seealso>
    let ont00000642 = Prefixed_Name(comcore, "ont00000642") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000643</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Low Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000643">https://www.commoncoreontologies.org/ont00000643</seealso>
    let ont00000643 = Prefixed_Name(comcore, "ont00000643") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000644</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oscillation Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000644">https://www.commoncoreontologies.org/ont00000644</seealso>
    let ont00000644 = Prefixed_Name(comcore, "ont00000644") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000645</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Permanent Resident"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000645">https://www.commoncoreontologies.org/ont00000645</seealso>
    let ont00000645 = Prefixed_Name(comcore, "ont00000645") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000646</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Highway"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000646">https://www.commoncoreontologies.org/ont00000646</seealso>
    let ont00000646 = Prefixed_Name(comcore, "ont00000646") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000647</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization Member"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000647">https://www.commoncoreontologies.org/ont00000647</seealso>
    let ont00000647 = Prefixed_Name(comcore, "ont00000647") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000648</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Color Brightness"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000648">https://www.commoncoreontologies.org/ont00000648</seealso>
    let ont00000648 = Prefixed_Name(comcore, "ont00000648") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000649</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non-Name Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000649">https://www.commoncoreontologies.org/ont00000649</seealso>
    let ont00000649 = Prefixed_Name(comcore, "ont00000649") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000650</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ground Moving Target Indication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000650">https://www.commoncoreontologies.org/ont00000650</seealso>
    let ont00000650 = Prefixed_Name(comcore, "ont00000650") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000651</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Containing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000651">https://www.commoncoreontologies.org/ont00000651</seealso>
    let ont00000651 = Prefixed_Name(comcore, "ont00000651") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000652</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decoy"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000652">https://www.commoncoreontologies.org/ont00000652</seealso>
    let ont00000652 = Prefixed_Name(comcore, "ont00000652") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000653</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Algorithm"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000653">https://www.commoncoreontologies.org/ont00000653</seealso>
    let ont00000653 = Prefixed_Name(comcore, "ont00000653") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000654</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Terrorism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000654">https://www.commoncoreontologies.org/ont00000654</seealso>
    let ont00000654 = Prefixed_Name(comcore, "ont00000654") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000655</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mailing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000655">https://www.commoncoreontologies.org/ont00000655</seealso>
    let ont00000655 = Prefixed_Name(comcore, "ont00000655") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000656</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiological Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000656">https://www.commoncoreontologies.org/ont00000656</seealso>
    let ont00000656 = Prefixed_Name(comcore, "ont00000656") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000657</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Distance Measurement Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000657">https://www.commoncoreontologies.org/ont00000657</seealso>
    let ont00000657 = Prefixed_Name(comcore, "ont00000657") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000658</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Missile Launcher"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000658">https://www.commoncoreontologies.org/ont00000658</seealso>
    let ont00000658 = Prefixed_Name(comcore, "ont00000658") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000659</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Torque"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000659">https://www.commoncoreontologies.org/ont00000659</seealso>
    let ont00000659 = Prefixed_Name(comcore, "ont00000659") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000660</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Effect"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000660">https://www.commoncoreontologies.org/ont00000660</seealso>
    let ont00000660 = Prefixed_Name(comcore, "ont00000660") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000661</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000661">https://www.commoncoreontologies.org/ont00000661</seealso>
    let ont00000661 = Prefixed_Name(comcore, "ont00000661") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000662</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Territory of a Government Domain"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000662">https://www.commoncoreontologies.org/ont00000662</seealso>
    let ont00000662 = Prefixed_Name(comcore, "ont00000662") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000663</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Transmission Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000663">https://www.commoncoreontologies.org/ont00000663</seealso>
    let ont00000663 = Prefixed_Name(comcore, "ont00000663") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000664</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Relay Station"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000664">https://www.commoncoreontologies.org/ont00000664</seealso>
    let ont00000664 = Prefixed_Name(comcore, "ont00000664") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000665</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cleaning Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000665">https://www.commoncoreontologies.org/ont00000665</seealso>
    let ont00000665 = Prefixed_Name(comcore, "ont00000665") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000666</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neutral Person"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000666">https://www.commoncoreontologies.org/ont00000666</seealso>
    let ont00000666 = Prefixed_Name(comcore, "ont00000666") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000667</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Combat Outpost"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000667">https://www.commoncoreontologies.org/ont00000667</seealso>
    let ont00000667 = Prefixed_Name(comcore, "ont00000667") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000668</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Battery Terminal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000668">https://www.commoncoreontologies.org/ont00000668</seealso>
    let ont00000668 = Prefixed_Name(comcore, "ont00000668") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000669</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Distance Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000669">https://www.commoncoreontologies.org/ont00000669</seealso>
    let ont00000669 = Prefixed_Name(comcore, "ont00000669") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000670</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Distribution Port"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000670">https://www.commoncoreontologies.org/ont00000670</seealso>
    let ont00000670 = Prefixed_Name(comcore, "ont00000670") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000671</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Anti-Bacterial Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000671">https://www.commoncoreontologies.org/ont00000671</seealso>
    let ont00000671 = Prefixed_Name(comcore, "ont00000671") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000672</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Super Low Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000672">https://www.commoncoreontologies.org/ont00000672</seealso>
    let ont00000672 = Prefixed_Name(comcore, "ont00000672") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000673</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prosthetic Foot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000673">https://www.commoncoreontologies.org/ont00000673</seealso>
    let ont00000673 = Prefixed_Name(comcore, "ont00000673") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar Year"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000674">https://www.commoncoreontologies.org/ont00000674</seealso>
    let ont00000674 = Prefixed_Name(comcore, "ont00000674") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000675</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Wave Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000675">https://www.commoncoreontologies.org/ont00000675</seealso>
    let ont00000675 = Prefixed_Name(comcore, "ont00000675") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000676</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Inhabitancy"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000676">https://www.commoncoreontologies.org/ont00000676</seealso>
    let ont00000676 = Prefixed_Name(comcore, "ont00000676") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000677</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Product Transport Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000677">https://www.commoncoreontologies.org/ont00000677</seealso>
    let ont00000677 = Prefixed_Name(comcore, "ont00000677") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000678</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage Regulating Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000678">https://www.commoncoreontologies.org/ont00000678</seealso>
    let ont00000678 = Prefixed_Name(comcore, "ont00000678") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000679</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Attitude Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000679">https://www.commoncoreontologies.org/ont00000679</seealso>
    let ont00000679 = Prefixed_Name(comcore, "ont00000679") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000680</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Medical Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000680">https://www.commoncoreontologies.org/ont00000680</seealso>
    let ont00000680 = Prefixed_Name(comcore, "ont00000680") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000681</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"External Navigation Lighting System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000681">https://www.commoncoreontologies.org/ont00000681</seealso>
    let ont00000681 = Prefixed_Name(comcore, "ont00000681") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000682</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mirror"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000682">https://www.commoncoreontologies.org/ont00000682</seealso>
    let ont00000682 = Prefixed_Name(comcore, "ont00000682") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000683</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Diminutive Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000683">https://www.commoncoreontologies.org/ont00000683</seealso>
    let ont00000683 = Prefixed_Name(comcore, "ont00000683") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000684</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Contract Formation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000684">https://www.commoncoreontologies.org/ont00000684</seealso>
    let ont00000684 = Prefixed_Name(comcore, "ont00000684") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000685</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government Domain Border"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000685">https://www.commoncoreontologies.org/ont00000685</seealso>
    let ont00000685 = Prefixed_Name(comcore, "ont00000685") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000686</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Designative Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000686">https://www.commoncoreontologies.org/ont00000686</seealso>
    let ont00000686 = Prefixed_Name(comcore, "ont00000686") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000687</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000687">https://www.commoncoreontologies.org/ont00000687</seealso>
    let ont00000687 = Prefixed_Name(comcore, "ont00000687") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000688</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Turbofan Air-Breathing Jet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000688">https://www.commoncoreontologies.org/ont00000688</seealso>
    let ont00000688 = Prefixed_Name(comcore, "ont00000688") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000689</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Switch Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000689">https://www.commoncoreontologies.org/ont00000689</seealso>
    let ont00000689 = Prefixed_Name(comcore, "ont00000689") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000690</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000690">https://www.commoncoreontologies.org/ont00000690</seealso>
    let ont00000690 = Prefixed_Name(comcore, "ont00000690") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000691</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel Tank"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000691">https://www.commoncoreontologies.org/ont00000691</seealso>
    let ont00000691 = Prefixed_Name(comcore, "ont00000691") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000692</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Probability Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000692">https://www.commoncoreontologies.org/ont00000692</seealso>
    let ont00000692 = Prefixed_Name(comcore, "ont00000692") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000693</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mass Specification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000693">https://www.commoncoreontologies.org/ont00000693</seealso>
    let ont00000693 = Prefixed_Name(comcore, "ont00000693") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000694</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nozzle Mouth"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000694">https://www.commoncoreontologies.org/ont00000694</seealso>
    let ont00000694 = Prefixed_Name(comcore, "ont00000694") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000695</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiolucent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000695">https://www.commoncoreontologies.org/ont00000695</seealso>
    let ont00000695 = Prefixed_Name(comcore, "ont00000695") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000696</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ideology"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000696">https://www.commoncoreontologies.org/ont00000696</seealso>
    let ont00000696 = Prefixed_Name(comcore, "ont00000696") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000697</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Enemy Person"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000697">https://www.commoncoreontologies.org/ont00000697</seealso>
    let ont00000697 = Prefixed_Name(comcore, "ont00000697") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000698</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Convergent-Divergent Nozzle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000698">https://www.commoncoreontologies.org/ont00000698</seealso>
    let ont00000698 = Prefixed_Name(comcore, "ont00000698") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000699</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Afternoon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000699">https://www.commoncoreontologies.org/ont00000699</seealso>
    let ont00000699 = Prefixed_Name(comcore, "ont00000699") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000700</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Computer Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000700">https://www.commoncoreontologies.org/ont00000700</seealso>
    let ont00000700 = Prefixed_Name(comcore, "ont00000700") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000701</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wire Receiver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000701">https://www.commoncoreontologies.org/ont00000701</seealso>
    let ont00000701 = Prefixed_Name(comcore, "ont00000701") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000702</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of an Image"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000702">https://www.commoncoreontologies.org/ont00000702</seealso>
    let ont00000702 = Prefixed_Name(comcore, "ont00000702") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000703</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a System Clock"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000703">https://www.commoncoreontologies.org/ont00000703</seealso>
    let ont00000703 = Prefixed_Name(comcore, "ont00000703") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000704</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Constructed Tunnel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000704">https://www.commoncoreontologies.org/ont00000704</seealso>
    let ont00000704 = Prefixed_Name(comcore, "ont00000704") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000705</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Transmission Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000705">https://www.commoncoreontologies.org/ont00000705</seealso>
    let ont00000705 = Prefixed_Name(comcore, "ont00000705") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000706</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Terminal Board"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000706">https://www.commoncoreontologies.org/ont00000706</seealso>
    let ont00000706 = Prefixed_Name(comcore, "ont00000706") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000707</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Angle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000707">https://www.commoncoreontologies.org/ont00000707</seealso>
    let ont00000707 = Prefixed_Name(comcore, "ont00000707") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000708</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water Tower"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000708">https://www.commoncoreontologies.org/ont00000708</seealso>
    let ont00000708 = Prefixed_Name(comcore, "ont00000708") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000709</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Visual Prosthesis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000709">https://www.commoncoreontologies.org/ont00000709</seealso>
    let ont00000709 = Prefixed_Name(comcore, "ont00000709") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000710</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Command Post Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000710">https://www.commoncoreontologies.org/ont00000710</seealso>
    let ont00000710 = Prefixed_Name(comcore, "ont00000710") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000711</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semi-automatic Pistol"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000711">https://www.commoncoreontologies.org/ont00000711</seealso>
    let ont00000711 = Prefixed_Name(comcore, "ont00000711") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000712</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Acceleration"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000712">https://www.commoncoreontologies.org/ont00000712</seealso>
    let ont00000712 = Prefixed_Name(comcore, "ont00000712") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000713</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000713">https://www.commoncoreontologies.org/ont00000713</seealso>
    let ont00000713 = Prefixed_Name(comcore, "ont00000713") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000714</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Horn Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000714">https://www.commoncoreontologies.org/ont00000714</seealso>
    let ont00000714 = Prefixed_Name(comcore, "ont00000714") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000715</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prosthesis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000715">https://www.commoncoreontologies.org/ont00000715</seealso>
    let ont00000715 = Prefixed_Name(comcore, "ont00000715") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000716</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000716">https://www.commoncoreontologies.org/ont00000716</seealso>
    let ont00000716 = Prefixed_Name(comcore, "ont00000716") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000717</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fossil Fuel Power Plant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000717">https://www.commoncoreontologies.org/ont00000717</seealso>
    let ont00000717 = Prefixed_Name(comcore, "ont00000717") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000718</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Village"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000718">https://www.commoncoreontologies.org/ont00000718</seealso>
    let ont00000718 = Prefixed_Name(comcore, "ont00000718") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000719</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Counterfeit Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000719">https://www.commoncoreontologies.org/ont00000719</seealso>
    let ont00000719 = Prefixed_Name(comcore, "ont00000719") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000720</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cryogenic Storage Dewar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000720">https://www.commoncoreontologies.org/ont00000720</seealso>
    let ont00000720 = Prefixed_Name(comcore, "ont00000720") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000721</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Polarizing Prism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000721">https://www.commoncoreontologies.org/ont00000721</seealso>
    let ont00000721 = Prefixed_Name(comcore, "ont00000721") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000722</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sea Level"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000722">https://www.commoncoreontologies.org/ont00000722</seealso>
    let ont00000722 = Prefixed_Name(comcore, "ont00000722") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000723</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000723">https://www.commoncoreontologies.org/ont00000723</seealso>
    let ont00000723 = Prefixed_Name(comcore, "ont00000723") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000724</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parabolic Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000724">https://www.commoncoreontologies.org/ont00000724</seealso>
    let ont00000724 = Prefixed_Name(comcore, "ont00000724") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000725</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wedding"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000725">https://www.commoncoreontologies.org/ont00000725</seealso>
    let ont00000725 = Prefixed_Name(comcore, "ont00000725") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000726</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000726">https://www.commoncoreontologies.org/ont00000726</seealso>
    let ont00000726 = Prefixed_Name(comcore, "ont00000726") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000727</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000727">https://www.commoncoreontologies.org/ont00000727</seealso>
    let ont00000727 = Prefixed_Name(comcore, "ont00000727") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000728</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Submillimeter Wavelength Radio Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000728">https://www.commoncoreontologies.org/ont00000728</seealso>
    let ont00000728 = Prefixed_Name(comcore, "ont00000728") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000729</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spherical Coordinate System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000729">https://www.commoncoreontologies.org/ont00000729</seealso>
    let ont00000729 = Prefixed_Name(comcore, "ont00000729") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000730</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydraulic Power Transfer Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000730">https://www.commoncoreontologies.org/ont00000730</seealso>
    let ont00000730 = Prefixed_Name(comcore, "ont00000730") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000731</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Deviation Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000731">https://www.commoncoreontologies.org/ont00000731</seealso>
    let ont00000731 = Prefixed_Name(comcore, "ont00000731") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000732</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Microwave Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000732">https://www.commoncoreontologies.org/ont00000732</seealso>
    let ont00000732 = Prefixed_Name(comcore, "ont00000732") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000733</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spherical"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000733">https://www.commoncoreontologies.org/ont00000733</seealso>
    let ont00000733 = Prefixed_Name(comcore, "ont00000733") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000734</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Explosive Land Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000734">https://www.commoncoreontologies.org/ont00000734</seealso>
    let ont00000734 = Prefixed_Name(comcore, "ont00000734") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000735</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Region Bounding Box Identifier List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000735">https://www.commoncoreontologies.org/ont00000735</seealso>
    let ont00000735 = Prefixed_Name(comcore, "ont00000735") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000736</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transducer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000736">https://www.commoncoreontologies.org/ont00000736</seealso>
    let ont00000736 = Prefixed_Name(comcore, "ont00000736") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000737</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Forward Operations Base"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000737">https://www.commoncoreontologies.org/ont00000737</seealso>
    let ont00000737 = Prefixed_Name(comcore, "ont00000737") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000738</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000738">https://www.commoncoreontologies.org/ont00000738</seealso>
    let ont00000738 = Prefixed_Name(comcore, "ont00000738") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000739</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Sojourn"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000739">https://www.commoncoreontologies.org/ont00000739</seealso>
    let ont00000739 = Prefixed_Name(comcore, "ont00000739") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000740</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000740">https://www.commoncoreontologies.org/ont00000740</seealso>
    let ont00000740 = Prefixed_Name(comcore, "ont00000740") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000741</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Targeting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000741">https://www.commoncoreontologies.org/ont00000741</seealso>
    let ont00000741 = Prefixed_Name(comcore, "ont00000741") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000742</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ignition System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000742">https://www.commoncoreontologies.org/ont00000742</seealso>
    let ont00000742 = Prefixed_Name(comcore, "ont00000742") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000743</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Chart"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000743">https://www.commoncoreontologies.org/ont00000743</seealso>
    let ont00000743 = Prefixed_Name(comcore, "ont00000743") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000744</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Social Group Membership"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000744">https://www.commoncoreontologies.org/ont00000744</seealso>
    let ont00000744 = Prefixed_Name(comcore, "ont00000744") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000745</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Point Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000745">https://www.commoncoreontologies.org/ont00000745</seealso>
    let ont00000745 = Prefixed_Name(comcore, "ont00000745") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000746</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Combustion Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000746">https://www.commoncoreontologies.org/ont00000746</seealso>
    let ont00000746 = Prefixed_Name(comcore, "ont00000746") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000747</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Canal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000747">https://www.commoncoreontologies.org/ont00000747</seealso>
    let ont00000747 = Prefixed_Name(comcore, "ont00000747") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000748</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bullet"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000748">https://www.commoncoreontologies.org/ont00000748</seealso>
    let ont00000748 = Prefixed_Name(comcore, "ont00000748") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000749</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Day Number"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000749">https://www.commoncoreontologies.org/ont00000749</seealso>
    let ont00000749 = Prefixed_Name(comcore, "ont00000749") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000750</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Text Messaging"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000750">https://www.commoncoreontologies.org/ont00000750</seealso>
    let ont00000750 = Prefixed_Name(comcore, "ont00000750") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000751</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Action Permission"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000751">https://www.commoncoreontologies.org/ont00000751</seealso>
    let ont00000751 = Prefixed_Name(comcore, "ont00000751") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000752</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wave Process Profile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000752">https://www.commoncoreontologies.org/ont00000752</seealso>
    let ont00000752 = Prefixed_Name(comcore, "ont00000752") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000753</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultra Low Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000753">https://www.commoncoreontologies.org/ont00000753</seealso>
    let ont00000753 = Prefixed_Name(comcore, "ont00000753") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000754</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Radiation Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000754">https://www.commoncoreontologies.org/ont00000754</seealso>
    let ont00000754 = Prefixed_Name(comcore, "ont00000754") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000755</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zenith"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000755">https://www.commoncoreontologies.org/ont00000755</seealso>
    let ont00000755 = Prefixed_Name(comcore, "ont00000755") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000756</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Database"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000756">https://www.commoncoreontologies.org/ont00000756</seealso>
    let ont00000756 = Prefixed_Name(comcore, "ont00000756") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000757</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Synagogue"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000757">https://www.commoncoreontologies.org/ont00000757</seealso>
    let ont00000757 = Prefixed_Name(comcore, "ont00000757") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000758</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Component Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000758">https://www.commoncoreontologies.org/ont00000758</seealso>
    let ont00000758 = Prefixed_Name(comcore, "ont00000758") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000759</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Color Saturation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000759">https://www.commoncoreontologies.org/ont00000759</seealso>
    let ont00000759 = Prefixed_Name(comcore, "ont00000759") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000760</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Surface Wave Profile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000760">https://www.commoncoreontologies.org/ont00000760</seealso>
    let ont00000760 = Prefixed_Name(comcore, "ont00000760") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000761</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000761">https://www.commoncoreontologies.org/ont00000761</seealso>
    let ont00000761 = Prefixed_Name(comcore, "ont00000761") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000762</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fungicide Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000762">https://www.commoncoreontologies.org/ont00000762</seealso>
    let ont00000762 = Prefixed_Name(comcore, "ont00000762") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000763</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Velocity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000763">https://www.commoncoreontologies.org/ont00000763</seealso>
    let ont00000763 = Prefixed_Name(comcore, "ont00000763") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000764</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Focusing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000764">https://www.commoncoreontologies.org/ont00000764</seealso>
    let ont00000764 = Prefixed_Name(comcore, "ont00000764") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000765</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wave Production"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000765">https://www.commoncoreontologies.org/ont00000765</seealso>
    let ont00000765 = Prefixed_Name(comcore, "ont00000765") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000766</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hardness"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000766">https://www.commoncoreontologies.org/ont00000766</seealso>
    let ont00000766 = Prefixed_Name(comcore, "ont00000766") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000767</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lubrication System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000767">https://www.commoncoreontologies.org/ont00000767</seealso>
    let ont00000767 = Prefixed_Name(comcore, "ont00000767") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000768</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amount"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000768">https://www.commoncoreontologies.org/ont00000768</seealso>
    let ont00000768 = Prefixed_Name(comcore, "ont00000768") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000769</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Requesting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000769">https://www.commoncoreontologies.org/ont00000769</seealso>
    let ont00000769 = Prefixed_Name(comcore, "ont00000769") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000770</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Density"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000770">https://www.commoncoreontologies.org/ont00000770</seealso>
    let ont00000770 = Prefixed_Name(comcore, "ont00000770") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000771</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Imaging Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000771">https://www.commoncoreontologies.org/ont00000771</seealso>
    let ont00000771 = Prefixed_Name(comcore, "ont00000771") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000772</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Impulsive Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000772">https://www.commoncoreontologies.org/ont00000772</seealso>
    let ont00000772 = Prefixed_Name(comcore, "ont00000772") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000773</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Curvilinear Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000773">https://www.commoncoreontologies.org/ont00000773</seealso>
    let ont00000773 = Prefixed_Name(comcore, "ont00000773") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000774</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Video Camera"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000774">https://www.commoncoreontologies.org/ont00000774</seealso>
    let ont00000774 = Prefixed_Name(comcore, "ont00000774") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000775</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Locomotive"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000775">https://www.commoncoreontologies.org/ont00000775</seealso>
    let ont00000775 = Prefixed_Name(comcore, "ont00000775") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000776</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Signal Detection Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000776">https://www.commoncoreontologies.org/ont00000776</seealso>
    let ont00000776 = Prefixed_Name(comcore, "ont00000776") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000777</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydraulic Motor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000777">https://www.commoncoreontologies.org/ont00000777</seealso>
    let ont00000777 = Prefixed_Name(comcore, "ont00000777") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000778</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000778">https://www.commoncoreontologies.org/ont00000778</seealso>
    let ont00000778 = Prefixed_Name(comcore, "ont00000778") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000779</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Cryosphere"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000779">https://www.commoncoreontologies.org/ont00000779</seealso>
    let ont00000779 = Prefixed_Name(comcore, "ont00000779") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000780</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ethnicity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000780">https://www.commoncoreontologies.org/ont00000780</seealso>
    let ont00000780 = Prefixed_Name(comcore, "ont00000780") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000781</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000781">https://www.commoncoreontologies.org/ont00000781</seealso>
    let ont00000781 = Prefixed_Name(comcore, "ont00000781") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000782</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Factory"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000782">https://www.commoncoreontologies.org/ont00000782</seealso>
    let ont00000782 = Prefixed_Name(comcore, "ont00000782") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000783</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Non-Mission Capable Maintenance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000783">https://www.commoncoreontologies.org/ont00000783</seealso>
    let ont00000783 = Prefixed_Name(comcore, "ont00000783") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000784</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Property"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000784">https://www.commoncoreontologies.org/ont00000784</seealso>
    let ont00000784 = Prefixed_Name(comcore, "ont00000784") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Repeater"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000785">https://www.commoncoreontologies.org/ont00000785</seealso>
    let ont00000785 = Prefixed_Name(comcore, "ont00000785") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000786">https://www.commoncoreontologies.org/ont00000786</seealso>
    let ont00000786 = Prefixed_Name(comcore, "ont00000786") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000787</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Altitude"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000787">https://www.commoncoreontologies.org/ont00000787</seealso>
    let ont00000787 = Prefixed_Name(comcore, "ont00000787") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Turbine Steam Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000788">https://www.commoncoreontologies.org/ont00000788</seealso>
    let ont00000788 = Prefixed_Name(comcore, "ont00000788") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Translational Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000789">https://www.commoncoreontologies.org/ont00000789</seealso>
    let ont00000789 = Prefixed_Name(comcore, "ont00000789") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000790</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Direct Current Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000790">https://www.commoncoreontologies.org/ont00000790</seealso>
    let ont00000790 = Prefixed_Name(comcore, "ont00000790") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000791</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical Reaction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000791">https://www.commoncoreontologies.org/ont00000791</seealso>
    let ont00000791 = Prefixed_Name(comcore, "ont00000791") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000792</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Catadioptric Optical Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000792">https://www.commoncoreontologies.org/ont00000792</seealso>
    let ont00000792 = Prefixed_Name(comcore, "ont00000792") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000793</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel Ventilation System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000793">https://www.commoncoreontologies.org/ont00000793</seealso>
    let ont00000793 = Prefixed_Name(comcore, "ont00000793") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Ellipse"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000794">https://www.commoncoreontologies.org/ont00000794</seealso>
    let ont00000794 = Prefixed_Name(comcore, "ont00000794") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000795</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Conduction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000795">https://www.commoncoreontologies.org/ont00000795</seealso>
    let ont00000795 = Prefixed_Name(comcore, "ont00000795") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000796</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rail Transport Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000796">https://www.commoncoreontologies.org/ont00000796</seealso>
    let ont00000796 = Prefixed_Name(comcore, "ont00000796") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000797</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hazel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000797">https://www.commoncoreontologies.org/ont00000797</seealso>
    let ont00000797 = Prefixed_Name(comcore, "ont00000797") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000798</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Bearing Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000798">https://www.commoncoreontologies.org/ont00000798</seealso>
    let ont00000798 = Prefixed_Name(comcore, "ont00000798") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000799</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000799">https://www.commoncoreontologies.org/ont00000799</seealso>
    let ont00000799 = Prefixed_Name(comcore, "ont00000799") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000800</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Day"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000800">https://www.commoncoreontologies.org/ont00000800</seealso>
    let ont00000800 = Prefixed_Name(comcore, "ont00000800") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000801</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"y-Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000801">https://www.commoncoreontologies.org/ont00000801</seealso>
    let ont00000801 = Prefixed_Name(comcore, "ont00000801") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000802</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stage"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000802">https://www.commoncoreontologies.org/ont00000802</seealso>
    let ont00000802 = Prefixed_Name(comcore, "ont00000802") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000803</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Round"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000803">https://www.commoncoreontologies.org/ont00000803</seealso>
    let ont00000803 = Prefixed_Name(comcore, "ont00000803") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000804</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000804">https://www.commoncoreontologies.org/ont00000804</seealso>
    let ont00000804 = Prefixed_Name(comcore, "ont00000804") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000805</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coiled"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000805">https://www.commoncoreontologies.org/ont00000805</seealso>
    let ont00000805 = Prefixed_Name(comcore, "ont00000805") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000806</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Tool"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000806">https://www.commoncoreontologies.org/ont00000806</seealso>
    let ont00000806 = Prefixed_Name(comcore, "ont00000806") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000807</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Compression Ignition Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000807">https://www.commoncoreontologies.org/ont00000807</seealso>
    let ont00000807 = Prefixed_Name(comcore, "ont00000807") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000808</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reactant Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000808">https://www.commoncoreontologies.org/ont00000808</seealso>
    let ont00000808 = Prefixed_Name(comcore, "ont00000808") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000809</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Submersible Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000809">https://www.commoncoreontologies.org/ont00000809</seealso>
    let ont00000809 = Prefixed_Name(comcore, "ont00000809") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000810</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Week Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000810">https://www.commoncoreontologies.org/ont00000810</seealso>
    let ont00000810 = Prefixed_Name(comcore, "ont00000810") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000811</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Wave Conversion Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000811">https://www.commoncoreontologies.org/ont00000811</seealso>
    let ont00000811 = Prefixed_Name(comcore, "ont00000811") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000812</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Pulse"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000812">https://www.commoncoreontologies.org/ont00000812</seealso>
    let ont00000812 = Prefixed_Name(comcore, "ont00000812") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000813</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Nuclear Fuel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000813">https://www.commoncoreontologies.org/ont00000813</seealso>
    let ont00000813 = Prefixed_Name(comcore, "ont00000813") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000814</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water Treatment Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000814">https://www.commoncoreontologies.org/ont00000814</seealso>
    let ont00000814 = Prefixed_Name(comcore, "ont00000814") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000815</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Folded"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000815">https://www.commoncoreontologies.org/ont00000815</seealso>
    let ont00000815 = Prefixed_Name(comcore, "ont00000815") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000816</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Nitrogen"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000816">https://www.commoncoreontologies.org/ont00000816</seealso>
    let ont00000816 = Prefixed_Name(comcore, "ont00000816") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000817</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Line String"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000817">https://www.commoncoreontologies.org/ont00000817</seealso>
    let ont00000817 = Prefixed_Name(comcore, "ont00000817") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000818</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orange"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000818">https://www.commoncoreontologies.org/ont00000818</seealso>
    let ont00000818 = Prefixed_Name(comcore, "ont00000818") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000819</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000819">https://www.commoncoreontologies.org/ont00000819</seealso>
    let ont00000819 = Prefixed_Name(comcore, "ont00000819") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000820</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000820">https://www.commoncoreontologies.org/ont00000820</seealso>
    let ont00000820 = Prefixed_Name(comcore, "ont00000820") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000821</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Promising"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000821">https://www.commoncoreontologies.org/ont00000821</seealso>
    let ont00000821 = Prefixed_Name(comcore, "ont00000821") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000822</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Very Low Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000822">https://www.commoncoreontologies.org/ont00000822</seealso>
    let ont00000822 = Prefixed_Name(comcore, "ont00000822") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000823</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Communication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000823">https://www.commoncoreontologies.org/ont00000823</seealso>
    let ont00000823 = Prefixed_Name(comcore, "ont00000823") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000824</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000824">https://www.commoncoreontologies.org/ont00000824</seealso>
    let ont00000824 = Prefixed_Name(comcore, "ont00000824") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000825</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Network Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000825">https://www.commoncoreontologies.org/ont00000825</seealso>
    let ont00000825 = Prefixed_Name(comcore, "ont00000825") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000826</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refractivity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000826">https://www.commoncoreontologies.org/ont00000826</seealso>
    let ont00000826 = Prefixed_Name(comcore, "ont00000826") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000827</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time of Day Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000827">https://www.commoncoreontologies.org/ont00000827</seealso>
    let ont00000827 = Prefixed_Name(comcore, "ont00000827") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000828</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pesticide Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000828">https://www.commoncoreontologies.org/ont00000828</seealso>
    let ont00000828 = Prefixed_Name(comcore, "ont00000828") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000829</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time Zone Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000829">https://www.commoncoreontologies.org/ont00000829</seealso>
    let ont00000829 = Prefixed_Name(comcore, "ont00000829") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000830</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000830">https://www.commoncoreontologies.org/ont00000830</seealso>
    let ont00000830 = Prefixed_Name(comcore, "ont00000830") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000831</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Herbicide Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000831">https://www.commoncoreontologies.org/ont00000831</seealso>
    let ont00000831 = Prefixed_Name(comcore, "ont00000831") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000832</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Year"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000832">https://www.commoncoreontologies.org/ont00000832</seealso>
    let ont00000832 = Prefixed_Name(comcore, "ont00000832") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000833</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Julian Date Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000833">https://www.commoncoreontologies.org/ont00000833</seealso>
    let ont00000833 = Prefixed_Name(comcore, "ont00000833") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000834</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mid Infrared Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000834">https://www.commoncoreontologies.org/ont00000834</seealso>
    let ont00000834 = Prefixed_Name(comcore, "ont00000834") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000835</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Body Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000835">https://www.commoncoreontologies.org/ont00000835</seealso>
    let ont00000835 = Prefixed_Name(comcore, "ont00000835") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000836</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Financial Instrument Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000836">https://www.commoncoreontologies.org/ont00000836</seealso>
    let ont00000836 = Prefixed_Name(comcore, "ont00000836") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000837</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000837">https://www.commoncoreontologies.org/ont00000837</seealso>
    let ont00000837 = Prefixed_Name(comcore, "ont00000837") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000838</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Fuel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000838">https://www.commoncoreontologies.org/ont00000838</seealso>
    let ont00000838 = Prefixed_Name(comcore, "ont00000838") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000839</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Donating"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000839">https://www.commoncoreontologies.org/ont00000839</seealso>
    let ont00000839 = Prefixed_Name(comcore, "ont00000839") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000840</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bicycle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000840">https://www.commoncoreontologies.org/ont00000840</seealso>
    let ont00000840 = Prefixed_Name(comcore, "ont00000840") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000841</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Explosive Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000841">https://www.commoncoreontologies.org/ont00000841</seealso>
    let ont00000841 = Prefixed_Name(comcore, "ont00000841") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000842</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sub-Bass Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000842">https://www.commoncoreontologies.org/ont00000842</seealso>
    let ont00000842 = Prefixed_Name(comcore, "ont00000842") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000843</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solar Panel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000843">https://www.commoncoreontologies.org/ont00000843</seealso>
    let ont00000843 = Prefixed_Name(comcore, "ont00000843") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000844</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Temperature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000844">https://www.commoncoreontologies.org/ont00000844</seealso>
    let ont00000844 = Prefixed_Name(comcore, "ont00000844") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000845</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proportional Ratio Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000845">https://www.commoncoreontologies.org/ont00000845</seealso>
    let ont00000845 = Prefixed_Name(comcore, "ont00000845") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000846</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydroelectric Power Plant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000846">https://www.commoncoreontologies.org/ont00000846</seealso>
    let ont00000846 = Prefixed_Name(comcore, "ont00000846") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000847</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000847">https://www.commoncoreontologies.org/ont00000847</seealso>
    let ont00000847 = Prefixed_Name(comcore, "ont00000847") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000848</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mounted Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000848">https://www.commoncoreontologies.org/ont00000848</seealso>
    let ont00000848 = Prefixed_Name(comcore, "ont00000848") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000849</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heating System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000849">https://www.commoncoreontologies.org/ont00000849</seealso>
    let ont00000849 = Prefixed_Name(comcore, "ont00000849") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000850</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000850">https://www.commoncoreontologies.org/ont00000850</seealso>
    let ont00000850 = Prefixed_Name(comcore, "ont00000850") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000851</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Light Machine Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000851">https://www.commoncoreontologies.org/ont00000851</seealso>
    let ont00000851 = Prefixed_Name(comcore, "ont00000851") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000852</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Work"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000852">https://www.commoncoreontologies.org/ont00000852</seealso>
    let ont00000852 = Prefixed_Name(comcore, "ont00000852") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000853</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Descriptive Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000853">https://www.commoncoreontologies.org/ont00000853</seealso>
    let ont00000853 = Prefixed_Name(comcore, "ont00000853") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000854</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Realizable Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000854">https://www.commoncoreontologies.org/ont00000854</seealso>
    let ont00000854 = Prefixed_Name(comcore, "ont00000854") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000855</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Effect of Location Change"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000855">https://www.commoncoreontologies.org/ont00000855</seealso>
    let ont00000855 = Prefixed_Name(comcore, "ont00000855") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000856</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact History"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000856">https://www.commoncoreontologies.org/ont00000856</seealso>
    let ont00000856 = Prefixed_Name(comcore, "ont00000856") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000857</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultra High Frequency Communication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000857">https://www.commoncoreontologies.org/ont00000857</seealso>
    let ont00000857 = Prefixed_Name(comcore, "ont00000857") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000858</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Improvised Explosive Device"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000858">https://www.commoncoreontologies.org/ont00000858</seealso>
    let ont00000858 = Prefixed_Name(comcore, "ont00000858") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000859</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Television Broadcast"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000859">https://www.commoncoreontologies.org/ont00000859</seealso>
    let ont00000859 = Prefixed_Name(comcore, "ont00000859") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000860</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Allied Person"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000860">https://www.commoncoreontologies.org/ont00000860</seealso>
    let ont00000860 = Prefixed_Name(comcore, "ont00000860") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000861</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Split"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000861">https://www.commoncoreontologies.org/ont00000861</seealso>
    let ont00000861 = Prefixed_Name(comcore, "ont00000861") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000862</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sound Process Profile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000862">https://www.commoncoreontologies.org/ont00000862</seealso>
    let ont00000862 = Prefixed_Name(comcore, "ont00000862") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000863</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Confessing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000863">https://www.commoncoreontologies.org/ont00000863</seealso>
    let ont00000863 = Prefixed_Name(comcore, "ont00000863") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000864</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Public Safety Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000864">https://www.commoncoreontologies.org/ont00000864</seealso>
    let ont00000864 = Prefixed_Name(comcore, "ont00000864") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000865</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Specifically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000865">https://www.commoncoreontologies.org/ont00000865</seealso>
    let ont00000865 = Prefixed_Name(comcore, "ont00000865") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000866</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Broadcast"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000866">https://www.commoncoreontologies.org/ont00000866</seealso>
    let ont00000866 = Prefixed_Name(comcore, "ont00000866") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000867</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pipeline"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000867">https://www.commoncoreontologies.org/ont00000867</seealso>
    let ont00000867 = Prefixed_Name(comcore, "ont00000867") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000868</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rocket Pod"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000868">https://www.commoncoreontologies.org/ont00000868</seealso>
    let ont00000868 = Prefixed_Name(comcore, "ont00000868") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000869</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Camera"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000869">https://www.commoncoreontologies.org/ont00000869</seealso>
    let ont00000869 = Prefixed_Name(comcore, "ont00000869") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000870</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrastructure System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000870">https://www.commoncoreontologies.org/ont00000870</seealso>
    let ont00000870 = Prefixed_Name(comcore, "ont00000870") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000871</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Plant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000871">https://www.commoncoreontologies.org/ont00000871</seealso>
    let ont00000871 = Prefixed_Name(comcore, "ont00000871") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000872</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Brown"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000872">https://www.commoncoreontologies.org/ont00000872</seealso>
    let ont00000872 = Prefixed_Name(comcore, "ont00000872") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000873</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physiographic Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000873">https://www.commoncoreontologies.org/ont00000873</seealso>
    let ont00000873 = Prefixed_Name(comcore, "ont00000873") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000874</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Video"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000874">https://www.commoncoreontologies.org/ont00000874</seealso>
    let ont00000874 = Prefixed_Name(comcore, "ont00000874") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000875</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Personal Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000875">https://www.commoncoreontologies.org/ont00000875</seealso>
    let ont00000875 = Prefixed_Name(comcore, "ont00000875") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000876</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000876">https://www.commoncoreontologies.org/ont00000876</seealso>
    let ont00000876 = Prefixed_Name(comcore, "ont00000876") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000877</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Brake Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000877">https://www.commoncoreontologies.org/ont00000877</seealso>
    let ont00000877 = Prefixed_Name(comcore, "ont00000877") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000878</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Identification Friend or Foe Transponder"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000878">https://www.commoncoreontologies.org/ont00000878</seealso>
    let ont00000878 = Prefixed_Name(comcore, "ont00000878") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000879</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Religious Group Affiliation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000879">https://www.commoncoreontologies.org/ont00000879</seealso>
    let ont00000879 = Prefixed_Name(comcore, "ont00000879") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000880</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Religious Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000880">https://www.commoncoreontologies.org/ont00000880</seealso>
    let ont00000880 = Prefixed_Name(comcore, "ont00000880") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000881</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Storage Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000881">https://www.commoncoreontologies.org/ont00000881</seealso>
    let ont00000881 = Prefixed_Name(comcore, "ont00000881") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000882</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wind Farm"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000882">https://www.commoncoreontologies.org/ont00000882</seealso>
    let ont00000882 = Prefixed_Name(comcore, "ont00000882") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000883</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Inviting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000883">https://www.commoncoreontologies.org/ont00000883</seealso>
    let ont00000883 = Prefixed_Name(comcore, "ont00000883") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000884</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Loaning"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000884">https://www.commoncoreontologies.org/ont00000884</seealso>
    let ont00000884 = Prefixed_Name(comcore, "ont00000884") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000885</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wavy"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000885">https://www.commoncoreontologies.org/ont00000885</seealso>
    let ont00000885 = Prefixed_Name(comcore, "ont00000885") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000886</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wired Communication Reception Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000886">https://www.commoncoreontologies.org/ont00000886</seealso>
    let ont00000886 = Prefixed_Name(comcore, "ont00000886") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000887</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"City"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000887">https://www.commoncoreontologies.org/ont00000887</seealso>
    let ont00000887 = Prefixed_Name(comcore, "ont00000887") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000888</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"High Frequency Communication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000888">https://www.commoncoreontologies.org/ont00000888</seealso>
    let ont00000888 = Prefixed_Name(comcore, "ont00000888") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000889</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Visible Observation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000889">https://www.commoncoreontologies.org/ont00000889</seealso>
    let ont00000889 = Prefixed_Name(comcore, "ont00000889") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000890</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Travel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000890">https://www.commoncoreontologies.org/ont00000890</seealso>
    let ont00000890 = Prefixed_Name(comcore, "ont00000890") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000891</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000891">https://www.commoncoreontologies.org/ont00000891</seealso>
    let ont00000891 = Prefixed_Name(comcore, "ont00000891") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000892</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Depth"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000892">https://www.commoncoreontologies.org/ont00000892</seealso>
    let ont00000892 = Prefixed_Name(comcore, "ont00000892") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000893</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Medium Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000893">https://www.commoncoreontologies.org/ont00000893</seealso>
    let ont00000893 = Prefixed_Name(comcore, "ont00000893") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000894</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decimal Date Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000894">https://www.commoncoreontologies.org/ont00000894</seealso>
    let ont00000894 = Prefixed_Name(comcore, "ont00000894") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000895</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Married"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000895">https://www.commoncoreontologies.org/ont00000895</seealso>
    let ont00000895 = Prefixed_Name(comcore, "ont00000895") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000896</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mean Point Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000896">https://www.commoncoreontologies.org/ont00000896</seealso>
    let ont00000896 = Prefixed_Name(comcore, "ont00000896") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000897</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Oxidizer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000897">https://www.commoncoreontologies.org/ont00000897</seealso>
    let ont00000897 = Prefixed_Name(comcore, "ont00000897") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000898</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geopolitical Power Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000898">https://www.commoncoreontologies.org/ont00000898</seealso>
    let ont00000898 = Prefixed_Name(comcore, "ont00000898") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000899</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a MSI Plessey Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000899">https://www.commoncoreontologies.org/ont00000899</seealso>
    let ont00000899 = Prefixed_Name(comcore, "ont00000899") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000900</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Communication Relay Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000900">https://www.commoncoreontologies.org/ont00000900</seealso>
    let ont00000900 = Prefixed_Name(comcore, "ont00000900") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000901</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decontamination Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000901">https://www.commoncoreontologies.org/ont00000901</seealso>
    let ont00000901 = Prefixed_Name(comcore, "ont00000901") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000902</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Facility Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000902">https://www.commoncoreontologies.org/ont00000902</seealso>
    let ont00000902 = Prefixed_Name(comcore, "ont00000902") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000903</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Communication Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000903">https://www.commoncoreontologies.org/ont00000903</seealso>
    let ont00000903 = Prefixed_Name(comcore, "ont00000903") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000904</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Track"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000904">https://www.commoncoreontologies.org/ont00000904</seealso>
    let ont00000904 = Prefixed_Name(comcore, "ont00000904") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000905</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post Office"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000905">https://www.commoncoreontologies.org/ont00000905</seealso>
    let ont00000905 = Prefixed_Name(comcore, "ont00000905") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Email Box"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000906">https://www.commoncoreontologies.org/ont00000906</seealso>
    let ont00000906 = Prefixed_Name(comcore, "ont00000906") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000907</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000907">https://www.commoncoreontologies.org/ont00000907</seealso>
    let ont00000907 = Prefixed_Name(comcore, "ont00000907") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000908</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Material Artifact Processing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000908">https://www.commoncoreontologies.org/ont00000908</seealso>
    let ont00000908 = Prefixed_Name(comcore, "ont00000908") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000909</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Emergency AC/DC Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000909">https://www.commoncoreontologies.org/ont00000909</seealso>
    let ont00000909 = Prefixed_Name(comcore, "ont00000909") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000910</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amplitude"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000910">https://www.commoncoreontologies.org/ont00000910</seealso>
    let ont00000910 = Prefixed_Name(comcore, "ont00000910") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000911</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semi-Major Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000911">https://www.commoncoreontologies.org/ont00000911</seealso>
    let ont00000911 = Prefixed_Name(comcore, "ont00000911") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000912</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pyramidal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000912">https://www.commoncoreontologies.org/ont00000912</seealso>
    let ont00000912 = Prefixed_Name(comcore, "ont00000912") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000913</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maroon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000913">https://www.commoncoreontologies.org/ont00000913</seealso>
    let ont00000913 = Prefixed_Name(comcore, "ont00000913") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000914</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Group of Persons"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000914">https://www.commoncoreontologies.org/ont00000914</seealso>
    let ont00000914 = Prefixed_Name(comcore, "ont00000914") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000915</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Acronym"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000915">https://www.commoncoreontologies.org/ont00000915</seealso>
    let ont00000915 = Prefixed_Name(comcore, "ont00000915") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000916</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lunar Calendar System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000916">https://www.commoncoreontologies.org/ont00000916</seealso>
    let ont00000916 = Prefixed_Name(comcore, "ont00000916") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000917</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Permanent Resident Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000917">https://www.commoncoreontologies.org/ont00000917</seealso>
    let ont00000917 = Prefixed_Name(comcore, "ont00000917") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000918</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Network Node"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000918">https://www.commoncoreontologies.org/ont00000918</seealso>
    let ont00000918 = Prefixed_Name(comcore, "ont00000918") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000919</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parts List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000919">https://www.commoncoreontologies.org/ont00000919</seealso>
    let ont00000919 = Prefixed_Name(comcore, "ont00000919") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000920</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Death"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000920">https://www.commoncoreontologies.org/ont00000920</seealso>
    let ont00000920 = Prefixed_Name(comcore, "ont00000920") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000921</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar Day"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000921">https://www.commoncoreontologies.org/ont00000921</seealso>
    let ont00000921 = Prefixed_Name(comcore, "ont00000921") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000922</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Arrival"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000922">https://www.commoncoreontologies.org/ont00000922</seealso>
    let ont00000922 = Prefixed_Name(comcore, "ont00000922") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000923</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Arbitrary Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000923">https://www.commoncoreontologies.org/ont00000923</seealso>
    let ont00000923 = Prefixed_Name(comcore, "ont00000923") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000924</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Beginning of Life Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000924">https://www.commoncoreontologies.org/ont00000924</seealso>
    let ont00000924 = Prefixed_Name(comcore, "ont00000924") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000925</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Military Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000925">https://www.commoncoreontologies.org/ont00000925</seealso>
    let ont00000925 = Prefixed_Name(comcore, "ont00000925") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000926</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Apologizing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000926">https://www.commoncoreontologies.org/ont00000926</seealso>
    let ont00000926 = Prefixed_Name(comcore, "ont00000926") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000927</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bass Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000927">https://www.commoncoreontologies.org/ont00000927</seealso>
    let ont00000927 = Prefixed_Name(comcore, "ont00000927") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000928</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Train Car"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000928">https://www.commoncoreontologies.org/ont00000928</seealso>
    let ont00000928 = Prefixed_Name(comcore, "ont00000928") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000929</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Part Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000929">https://www.commoncoreontologies.org/ont00000929</seealso>
    let ont00000929 = Prefixed_Name(comcore, "ont00000929") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000930</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nickel-metal Hydride Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000930">https://www.commoncoreontologies.org/ont00000930</seealso>
    let ont00000930 = Prefixed_Name(comcore, "ont00000930") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000931</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a UPC-A Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000931">https://www.commoncoreontologies.org/ont00000931</seealso>
    let ont00000931 = Prefixed_Name(comcore, "ont00000931") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000932</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Computing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000932">https://www.commoncoreontologies.org/ont00000932</seealso>
    let ont00000932 = Prefixed_Name(comcore, "ont00000932") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000933</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Landline Telephone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000933">https://www.commoncoreontologies.org/ont00000933</seealso>
    let ont00000933 = Prefixed_Name(comcore, "ont00000933") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000934</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Constituent State"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000934">https://www.commoncoreontologies.org/ont00000934</seealso>
    let ont00000934 = Prefixed_Name(comcore, "ont00000934") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000935</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Legal Instrument Use"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000935">https://www.commoncoreontologies.org/ont00000935</seealso>
    let ont00000935 = Prefixed_Name(comcore, "ont00000935") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000936</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Deactivated Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000936">https://www.commoncoreontologies.org/ont00000936</seealso>
    let ont00000936 = Prefixed_Name(comcore, "ont00000936") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000937</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inhibiting Motion Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000937">https://www.commoncoreontologies.org/ont00000937</seealso>
    let ont00000937 = Prefixed_Name(comcore, "ont00000937") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000938</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000938">https://www.commoncoreontologies.org/ont00000938</seealso>
    let ont00000938 = Prefixed_Name(comcore, "ont00000938") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000939</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000939">https://www.commoncoreontologies.org/ont00000939</seealso>
    let ont00000939 = Prefixed_Name(comcore, "ont00000939") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000940</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Momentum"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000940">https://www.commoncoreontologies.org/ont00000940</seealso>
    let ont00000940 = Prefixed_Name(comcore, "ont00000940") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000941</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Phosphorescence"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000941">https://www.commoncoreontologies.org/ont00000941</seealso>
    let ont00000941 = Prefixed_Name(comcore, "ont00000941") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000942</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sniper Rifle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000942">https://www.commoncoreontologies.org/ont00000942</seealso>
    let ont00000942 = Prefixed_Name(comcore, "ont00000942") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000943</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ocular Prosthesis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000943">https://www.commoncoreontologies.org/ont00000943</seealso>
    let ont00000943 = Prefixed_Name(comcore, "ont00000943") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000944</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermal Imaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000944">https://www.commoncoreontologies.org/ont00000944</seealso>
    let ont00000944 = Prefixed_Name(comcore, "ont00000944") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000945</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"X-ray Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000945">https://www.commoncoreontologies.org/ont00000945</seealso>
    let ont00000945 = Prefixed_Name(comcore, "ont00000945") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000946</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government Building"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000946">https://www.commoncoreontologies.org/ont00000946</seealso>
    let ont00000946 = Prefixed_Name(comcore, "ont00000946") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000947</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature Measurement Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000947">https://www.commoncoreontologies.org/ont00000947</seealso>
    let ont00000947 = Prefixed_Name(comcore, "ont00000947") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000948</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Religious Worship"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000948">https://www.commoncoreontologies.org/ont00000948</seealso>
    let ont00000948 = Prefixed_Name(comcore, "ont00000948") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000949</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Consumption"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000949">https://www.commoncoreontologies.org/ont00000949</seealso>
    let ont00000949 = Prefixed_Name(comcore, "ont00000949") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000950</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Maintenance"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000950">https://www.commoncoreontologies.org/ont00000950</seealso>
    let ont00000950 = Prefixed_Name(comcore, "ont00000950") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000951</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Wave Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000951">https://www.commoncoreontologies.org/ont00000951</seealso>
    let ont00000951 = Prefixed_Name(comcore, "ont00000951") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000952</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electric Motor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000952">https://www.commoncoreontologies.org/ont00000952</seealso>
    let ont00000952 = Prefixed_Name(comcore, "ont00000952") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000953</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pitch"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000953">https://www.commoncoreontologies.org/ont00000953</seealso>
    let ont00000953 = Prefixed_Name(comcore, "ont00000953") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000954</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Infrastructure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000954">https://www.commoncoreontologies.org/ont00000954</seealso>
    let ont00000954 = Prefixed_Name(comcore, "ont00000954") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Angular Momentum"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000955">https://www.commoncoreontologies.org/ont00000955</seealso>
    let ont00000955 = Prefixed_Name(comcore, "ont00000955") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000956</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Highway Interchange"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000956">https://www.commoncoreontologies.org/ont00000956</seealso>
    let ont00000956 = Prefixed_Name(comcore, "ont00000956") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000957</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reservoir"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000957">https://www.commoncoreontologies.org/ont00000957</seealso>
    let ont00000957 = Prefixed_Name(comcore, "ont00000957") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000958</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000958">https://www.commoncoreontologies.org/ont00000958</seealso>
    let ont00000958 = Prefixed_Name(comcore, "ont00000958") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000959</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000959">https://www.commoncoreontologies.org/ont00000959</seealso>
    let ont00000959 = Prefixed_Name(comcore, "ont00000959") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000960</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fixed Line Network Telephone Call"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000960">https://www.commoncoreontologies.org/ont00000960</seealso>
    let ont00000960 = Prefixed_Name(comcore, "ont00000960") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000961</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Current Conversion Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000961">https://www.commoncoreontologies.org/ont00000961</seealso>
    let ont00000961 = Prefixed_Name(comcore, "ont00000961") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000962</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Propellant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000962">https://www.commoncoreontologies.org/ont00000962</seealso>
    let ont00000962 = Prefixed_Name(comcore, "ont00000962") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000963</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel Transfer System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000963">https://www.commoncoreontologies.org/ont00000963</seealso>
    let ont00000963 = Prefixed_Name(comcore, "ont00000963") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000964</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Medium Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000964">https://www.commoncoreontologies.org/ont00000964</seealso>
    let ont00000964 = Prefixed_Name(comcore, "ont00000964") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000965</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Prescriptive Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000965">https://www.commoncoreontologies.org/ont00000965</seealso>
    let ont00000965 = Prefixed_Name(comcore, "ont00000965") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000966</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a EAN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000966">https://www.commoncoreontologies.org/ont00000966</seealso>
    let ont00000966 = Prefixed_Name(comcore, "ont00000966") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000967</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Height"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000967">https://www.commoncoreontologies.org/ont00000967</seealso>
    let ont00000967 = Prefixed_Name(comcore, "ont00000967") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000968</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assault Rifle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000968">https://www.commoncoreontologies.org/ont00000968</seealso>
    let ont00000968 = Prefixed_Name(comcore, "ont00000968") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000969</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Speed"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000969">https://www.commoncoreontologies.org/ont00000969</seealso>
    let ont00000969 = Prefixed_Name(comcore, "ont00000969") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000970</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Artifact Modification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000970">https://www.commoncoreontologies.org/ont00000970</seealso>
    let ont00000970 = Prefixed_Name(comcore, "ont00000970") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000971</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Deceptive Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000971">https://www.commoncoreontologies.org/ont00000971</seealso>
    let ont00000971 = Prefixed_Name(comcore, "ont00000971") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000972</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a EAN-13 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000972">https://www.commoncoreontologies.org/ont00000972</seealso>
    let ont00000972 = Prefixed_Name(comcore, "ont00000972") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000973</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decimal Time of Day Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000973">https://www.commoncoreontologies.org/ont00000973</seealso>
    let ont00000973 = Prefixed_Name(comcore, "ont00000973") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000974</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Plan"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000974">https://www.commoncoreontologies.org/ont00000974</seealso>
    let ont00000974 = Prefixed_Name(comcore, "ont00000974") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000975</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cyan"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000975">https://www.commoncoreontologies.org/ont00000975</seealso>
    let ont00000975 = Prefixed_Name(comcore, "ont00000975") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000976</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Political Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000976">https://www.commoncoreontologies.org/ont00000976</seealso>
    let ont00000976 = Prefixed_Name(comcore, "ont00000976") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000977</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Publishing Mass Media Documentary"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000977">https://www.commoncoreontologies.org/ont00000977</seealso>
    let ont00000977 = Prefixed_Name(comcore, "ont00000977") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000978</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cause"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000978">https://www.commoncoreontologies.org/ont00000978</seealso>
    let ont00000978 = Prefixed_Name(comcore, "ont00000978") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000979</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Closure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000979">https://www.commoncoreontologies.org/ont00000979</seealso>
    let ont00000979 = Prefixed_Name(comcore, "ont00000979") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000980</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Waste Material"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000980">https://www.commoncoreontologies.org/ont00000980</seealso>
    let ont00000980 = Prefixed_Name(comcore, "ont00000980") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000981</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Portion of Material Consumption"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000981">https://www.commoncoreontologies.org/ont00000981</seealso>
    let ont00000981 = Prefixed_Name(comcore, "ont00000981") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000982</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000982">https://www.commoncoreontologies.org/ont00000982</seealso>
    let ont00000982 = Prefixed_Name(comcore, "ont00000982") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000983</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shear Wave Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000983">https://www.commoncoreontologies.org/ont00000983</seealso>
    let ont00000983 = Prefixed_Name(comcore, "ont00000983") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000984</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Occupation Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000984">https://www.commoncoreontologies.org/ont00000984</seealso>
    let ont00000984 = Prefixed_Name(comcore, "ont00000984") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000985</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermal Insulation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000985">https://www.commoncoreontologies.org/ont00000985</seealso>
    let ont00000985 = Prefixed_Name(comcore, "ont00000985") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000986</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000986">https://www.commoncoreontologies.org/ont00000986</seealso>
    let ont00000986 = Prefixed_Name(comcore, "ont00000986") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000987</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Citizen Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000987">https://www.commoncoreontologies.org/ont00000987</seealso>
    let ont00000987 = Prefixed_Name(comcore, "ont00000987") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000988</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reflective Prism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000988">https://www.commoncoreontologies.org/ont00000988</seealso>
    let ont00000988 = Prefixed_Name(comcore, "ont00000988") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000989</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Super High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000989">https://www.commoncoreontologies.org/ont00000989</seealso>
    let ont00000989 = Prefixed_Name(comcore, "ont00000989") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000990</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nickname"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000990">https://www.commoncoreontologies.org/ont00000990</seealso>
    let ont00000990 = Prefixed_Name(comcore, "ont00000990") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000991</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000991">https://www.commoncoreontologies.org/ont00000991</seealso>
    let ont00000991 = Prefixed_Name(comcore, "ont00000991") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000992</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Second"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000992">https://www.commoncoreontologies.org/ont00000992</seealso>
    let ont00000992 = Prefixed_Name(comcore, "ont00000992") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000993</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power Rectifying Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000993">https://www.commoncoreontologies.org/ont00000993</seealso>
    let ont00000993 = Prefixed_Name(comcore, "ont00000993") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000994</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Power Production Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000994">https://www.commoncoreontologies.org/ont00000994</seealso>
    let ont00000994 = Prefixed_Name(comcore, "ont00000994") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000995</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000995">https://www.commoncoreontologies.org/ont00000995</seealso>
    let ont00000995 = Prefixed_Name(comcore, "ont00000995") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000996</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ramjet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000996">https://www.commoncoreontologies.org/ont00000996</seealso>
    let ont00000996 = Prefixed_Name(comcore, "ont00000996") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000997</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Disrupting Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000997">https://www.commoncoreontologies.org/ont00000997</seealso>
    let ont00000997 = Prefixed_Name(comcore, "ont00000997") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000998</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000998">https://www.commoncoreontologies.org/ont00000998</seealso>
    let ont00000998 = Prefixed_Name(comcore, "ont00000998") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00000999</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Defunct Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00000999">https://www.commoncoreontologies.org/ont00000999</seealso>
    let ont00000999 = Prefixed_Name(comcore, "ont00000999") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spray Nozzle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001000">https://www.commoncoreontologies.org/ont00001000</seealso>
    let ont00001000 = Prefixed_Name(comcore, "ont00001000") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Drooping"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001001">https://www.commoncoreontologies.org/ont00001001</seealso>
    let ont00001001 = Prefixed_Name(comcore, "ont00001001") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001002">https://www.commoncoreontologies.org/ont00001002</seealso>
    let ont00001002 = Prefixed_Name(comcore, "ont00001002") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cartridge"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001003">https://www.commoncoreontologies.org/ont00001003</seealso>
    let ont00001003 = Prefixed_Name(comcore, "ont00001003") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Electromagnetic Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001004">https://www.commoncoreontologies.org/ont00001004</seealso>
    let ont00001004 = Prefixed_Name(comcore, "ont00001004") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Turbojet Air-Breathing Jet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001005">https://www.commoncoreontologies.org/ont00001005</seealso>
    let ont00001005 = Prefixed_Name(comcore, "ont00001005") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operator Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001006">https://www.commoncoreontologies.org/ont00001006</seealso>
    let ont00001006 = Prefixed_Name(comcore, "ont00001006") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Passenger Train Car"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001007">https://www.commoncoreontologies.org/ont00001007</seealso>
    let ont00001007 = Prefixed_Name(comcore, "ont00001007") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological Weapon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001008">https://www.commoncoreontologies.org/ont00001008</seealso>
    let ont00001008 = Prefixed_Name(comcore, "ont00001008") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Telescope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001009">https://www.commoncoreontologies.org/ont00001009</seealso>
    let ont00001009 = Prefixed_Name(comcore, "ont00001009") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ordinal Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001010">https://www.commoncoreontologies.org/ont00001010</seealso>
    let ont00001010 = Prefixed_Name(comcore, "ont00001010") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Automobile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001011">https://www.commoncoreontologies.org/ont00001011</seealso>
    let ont00001011 = Prefixed_Name(comcore, "ont00001011") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a GS1 DataBar Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001012">https://www.commoncoreontologies.org/ont00001012</seealso>
    let ont00001012 = Prefixed_Name(comcore, "ont00001012") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heating Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001013">https://www.commoncoreontologies.org/ont00001013</seealso>
    let ont00001013 = Prefixed_Name(comcore, "ont00001013") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proper Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001014">https://www.commoncoreontologies.org/ont00001014</seealso>
    let ont00001014 = Prefixed_Name(comcore, "ont00001014") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Controlled-Access Highway"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001015">https://www.commoncoreontologies.org/ont00001015</seealso>
    let ont00001015 = Prefixed_Name(comcore, "ont00001015") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Lithosphere"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001016">https://www.commoncoreontologies.org/ont00001016</seealso>
    let ont00001016 = Prefixed_Name(comcore, "ont00001016") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001017">https://www.commoncoreontologies.org/ont00001017</seealso>
    let ont00001017 = Prefixed_Name(comcore, "ont00001017") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Equipment Cooling System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001018">https://www.commoncoreontologies.org/ont00001018</seealso>
    let ont00001018 = Prefixed_Name(comcore, "ont00001018") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Steering Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001019">https://www.commoncoreontologies.org/ont00001019</seealso>
    let ont00001019 = Prefixed_Name(comcore, "ont00001019") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Gaseous Fuel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001020">https://www.commoncoreontologies.org/ont00001020</seealso>
    let ont00001020 = Prefixed_Name(comcore, "ont00001020") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Denying"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001021">https://www.commoncoreontologies.org/ont00001021</seealso>
    let ont00001021 = Prefixed_Name(comcore, "ont00001021") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ratio Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001022">https://www.commoncoreontologies.org/ont00001022</seealso>
    let ont00001022 = Prefixed_Name(comcore, "ont00001022") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar Week"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001023">https://www.commoncoreontologies.org/ont00001023</seealso>
    let ont00001023 = Prefixed_Name(comcore, "ont00001023") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spark Ignition Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001024">https://www.commoncoreontologies.org/ont00001024</seealso>
    let ont00001024 = Prefixed_Name(comcore, "ont00001024") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electric Generator"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001025">https://www.commoncoreontologies.org/ont00001025</seealso>
    let ont00001025 = Prefixed_Name(comcore, "ont00001025") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pointing Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001026">https://www.commoncoreontologies.org/ont00001026</seealso>
    let ont00001026 = Prefixed_Name(comcore, "ont00001026") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Trim Tab"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001027">https://www.commoncoreontologies.org/ont00001027</seealso>
    let ont00001027 = Prefixed_Name(comcore, "ont00001027") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mechanical Wave Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001028">https://www.commoncoreontologies.org/ont00001028</seealso>
    let ont00001028 = Prefixed_Name(comcore, "ont00001028") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unguided Rocket"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001029">https://www.commoncoreontologies.org/ont00001029</seealso>
    let ont00001029 = Prefixed_Name(comcore, "ont00001029") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Train"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001030">https://www.commoncoreontologies.org/ont00001030</seealso>
    let ont00001030 = Prefixed_Name(comcore, "ont00001030") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Volunteering"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001031">https://www.commoncoreontologies.org/ont00001031</seealso>
    let ont00001031 = Prefixed_Name(comcore, "ont00001031") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Assignment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001032">https://www.commoncoreontologies.org/ont00001032</seealso>
    let ont00001032 = Prefixed_Name(comcore, "ont00001032") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological Sex"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001033">https://www.commoncoreontologies.org/ont00001033</seealso>
    let ont00001033 = Prefixed_Name(comcore, "ont00001033") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Full Motion Video Camera"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001034">https://www.commoncoreontologies.org/ont00001034</seealso>
    let ont00001034 = Prefixed_Name(comcore, "ont00001034") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pitch Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001035">https://www.commoncoreontologies.org/ont00001035</seealso>
    let ont00001035 = Prefixed_Name(comcore, "ont00001035") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001036">https://www.commoncoreontologies.org/ont00001036</seealso>
    let ont00001036 = Prefixed_Name(comcore, "ont00001036") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Constructed Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001037">https://www.commoncoreontologies.org/ont00001037</seealso>
    let ont00001037 = Prefixed_Name(comcore, "ont00001037") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nickel Cadmium Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001038">https://www.commoncoreontologies.org/ont00001038</seealso>
    let ont00001038 = Prefixed_Name(comcore, "ont00001038") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Repayment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001039">https://www.commoncoreontologies.org/ont00001039</seealso>
    let ont00001039 = Prefixed_Name(comcore, "ont00001039") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nadir"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001040">https://www.commoncoreontologies.org/ont00001040</seealso>
    let ont00001040 = Prefixed_Name(comcore, "ont00001040") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sequence Position Ordinality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001041">https://www.commoncoreontologies.org/ont00001041</seealso>
    let ont00001041 = Prefixed_Name(comcore, "ont00001041") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Equipment Mount"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001042">https://www.commoncoreontologies.org/ont00001042</seealso>
    let ont00001042 = Prefixed_Name(comcore, "ont00001042") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Aircraft"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001043">https://www.commoncoreontologies.org/ont00001043</seealso>
    let ont00001043 = Prefixed_Name(comcore, "ont00001043") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Radiation Detection Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001044">https://www.commoncoreontologies.org/ont00001044</seealso>
    let ont00001044 = Prefixed_Name(comcore, "ont00001044") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Model"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001045">https://www.commoncoreontologies.org/ont00001045</seealso>
    let ont00001045 = Prefixed_Name(comcore, "ont00001045") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Notification Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001046">https://www.commoncoreontologies.org/ont00001046</seealso>
    let ont00001046 = Prefixed_Name(comcore, "ont00001046") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001047">https://www.commoncoreontologies.org/ont00001047</seealso>
    let ont00001047 = Prefixed_Name(comcore, "ont00001047") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001048">https://www.commoncoreontologies.org/ont00001048</seealso>
    let ont00001048 = Prefixed_Name(comcore, "ont00001048") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001049">https://www.commoncoreontologies.org/ont00001049</seealso>
    let ont00001049 = Prefixed_Name(comcore, "ont00001049") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Primary Cell Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001050">https://www.commoncoreontologies.org/ont00001050</seealso>
    let ont00001050 = Prefixed_Name(comcore, "ont00001050") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Projectile Launcher"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001051">https://www.commoncoreontologies.org/ont00001051</seealso>
    let ont00001051 = Prefixed_Name(comcore, "ont00001051") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001052">https://www.commoncoreontologies.org/ont00001052</seealso>
    let ont00001052 = Prefixed_Name(comcore, "ont00001052") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Collision"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001053">https://www.commoncoreontologies.org/ont00001053</seealso>
    let ont00001053 = Prefixed_Name(comcore, "ont00001053") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Helical Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001054">https://www.commoncoreontologies.org/ont00001054</seealso>
    let ont00001054 = Prefixed_Name(comcore, "ont00001054") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Branched"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001055">https://www.commoncoreontologies.org/ont00001055</seealso>
    let ont00001055 = Prefixed_Name(comcore, "ont00001055") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Visible Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001056">https://www.commoncoreontologies.org/ont00001056</seealso>
    let ont00001056 = Prefixed_Name(comcore, "ont00001056") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Issuing Mass Media Press Release"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001057">https://www.commoncoreontologies.org/ont00001057</seealso>
    let ont00001057 = Prefixed_Name(comcore, "ont00001057") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hour"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001058">https://www.commoncoreontologies.org/ont00001058</seealso>
    let ont00001058 = Prefixed_Name(comcore, "ont00001058") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Shape Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001059">https://www.commoncoreontologies.org/ont00001059</seealso>
    let ont00001059 = Prefixed_Name(comcore, "ont00001059") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001060">https://www.commoncoreontologies.org/ont00001060</seealso>
    let ont00001060 = Prefixed_Name(comcore, "ont00001060") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motorcycle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001061">https://www.commoncoreontologies.org/ont00001061</seealso>
    let ont00001061 = Prefixed_Name(comcore, "ont00001061") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Community"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001062">https://www.commoncoreontologies.org/ont00001062</seealso>
    let ont00001062 = Prefixed_Name(comcore, "ont00001062") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Straight"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001063">https://www.commoncoreontologies.org/ont00001063</seealso>
    let ont00001063 = Prefixed_Name(comcore, "ont00001063") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001064">https://www.commoncoreontologies.org/ont00001064</seealso>
    let ont00001064 = Prefixed_Name(comcore, "ont00001064") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Two Dimensional Extent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001065">https://www.commoncoreontologies.org/ont00001065</seealso>
    let ont00001065 = Prefixed_Name(comcore, "ont00001065") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001066">https://www.commoncoreontologies.org/ont00001066</seealso>
    let ont00001066 = Prefixed_Name(comcore, "ont00001066") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Laser"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001067">https://www.commoncoreontologies.org/ont00001067</seealso>
    let ont00001067 = Prefixed_Name(comcore, "ont00001067") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001068">https://www.commoncoreontologies.org/ont00001068</seealso>
    let ont00001068 = Prefixed_Name(comcore, "ont00001068") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Representational Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001069">https://www.commoncoreontologies.org/ont00001069</seealso>
    let ont00001069 = Prefixed_Name(comcore, "ont00001069") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fluid Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001070">https://www.commoncoreontologies.org/ont00001070</seealso>
    let ont00001070 = Prefixed_Name(comcore, "ont00001070") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Payload Capacity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001071">https://www.commoncoreontologies.org/ont00001071</seealso>
    let ont00001071 = Prefixed_Name(comcore, "ont00001071") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FM Radio Broadcast Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001072">https://www.commoncoreontologies.org/ont00001072</seealso>
    let ont00001072 = Prefixed_Name(comcore, "ont00001072") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Value of Property"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001073">https://www.commoncoreontologies.org/ont00001073</seealso>
    let ont00001073 = Prefixed_Name(comcore, "ont00001073") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Educational Training Acquisition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001074">https://www.commoncoreontologies.org/ont00001074</seealso>
    let ont00001074 = Prefixed_Name(comcore, "ont00001074") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001075">https://www.commoncoreontologies.org/ont00001075</seealso>
    let ont00001075 = Prefixed_Name(comcore, "ont00001075") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electric Power Station"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001076">https://www.commoncoreontologies.org/ont00001076</seealso>
    let ont00001076 = Prefixed_Name(comcore, "ont00001076") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heavy Machine Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001077">https://www.commoncoreontologies.org/ont00001077</seealso>
    let ont00001077 = Prefixed_Name(comcore, "ont00001077") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Airport"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001078">https://www.commoncoreontologies.org/ont00001078</seealso>
    let ont00001078 = Prefixed_Name(comcore, "ont00001078") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blond"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001079">https://www.commoncoreontologies.org/ont00001079</seealso>
    let ont00001079 = Prefixed_Name(comcore, "ont00001079") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Far Infrared Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001080">https://www.commoncoreontologies.org/ont00001080</seealso>
    let ont00001080 = Prefixed_Name(comcore, "ont00001080") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geographic Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001081">https://www.commoncoreontologies.org/ont00001081</seealso>
    let ont00001081 = Prefixed_Name(comcore, "ont00001081") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Patch Receiver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001082">https://www.commoncoreontologies.org/ont00001082</seealso>
    let ont00001082 = Prefixed_Name(comcore, "ont00001082") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Air-Breathing Combustion Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001083">https://www.commoncoreontologies.org/ont00001083</seealso>
    let ont00001083 = Prefixed_Name(comcore, "ont00001083") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Processed Material"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001084">https://www.commoncoreontologies.org/ont00001084</seealso>
    let ont00001084 = Prefixed_Name(comcore, "ont00001084") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reflection Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001085">https://www.commoncoreontologies.org/ont00001085</seealso>
    let ont00001085 = Prefixed_Name(comcore, "ont00001085") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Road Junction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001086">https://www.commoncoreontologies.org/ont00001086</seealso>
    let ont00001086 = Prefixed_Name(comcore, "ont00001086") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orientation Observation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001087">https://www.commoncoreontologies.org/ont00001087</seealso>
    let ont00001087 = Prefixed_Name(comcore, "ont00001087") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decade"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001088">https://www.commoncoreontologies.org/ont00001088</seealso>
    let ont00001088 = Prefixed_Name(comcore, "ont00001088") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Petrochemical Refinery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001089">https://www.commoncoreontologies.org/ont00001089</seealso>
    let ont00001089 = Prefixed_Name(comcore, "ont00001089") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Pressure"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001090">https://www.commoncoreontologies.org/ont00001090</seealso>
    let ont00001090 = Prefixed_Name(comcore, "ont00001090") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fort"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001091">https://www.commoncoreontologies.org/ont00001091</seealso>
    let ont00001091 = Prefixed_Name(comcore, "ont00001091") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electrical Power Storage Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001092">https://www.commoncoreontologies.org/ont00001092</seealso>
    let ont00001092 = Prefixed_Name(comcore, "ont00001092") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coin"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001093">https://www.commoncoreontologies.org/ont00001093</seealso>
    let ont00001093 = Prefixed_Name(comcore, "ont00001093") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Espionage"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001094">https://www.commoncoreontologies.org/ont00001094</seealso>
    let ont00001094 = Prefixed_Name(comcore, "ont00001094") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cellular Telecommunication Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001095">https://www.commoncoreontologies.org/ont00001095</seealso>
    let ont00001095 = Prefixed_Name(comcore, "ont00001095") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Submachine Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001096">https://www.commoncoreontologies.org/ont00001096</seealso>
    let ont00001096 = Prefixed_Name(comcore, "ont00001096") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Common Stock"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001097">https://www.commoncoreontologies.org/ont00001097</seealso>
    let ont00001097 = Prefixed_Name(comcore, "ont00001097") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hospital"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001098">https://www.commoncoreontologies.org/ont00001098</seealso>
    let ont00001098 = Prefixed_Name(comcore, "ont00001098") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bridge"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001099">https://www.commoncoreontologies.org/ont00001099</seealso>
    let ont00001099 = Prefixed_Name(comcore, "ont00001099") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001100">https://www.commoncoreontologies.org/ont00001100</seealso>
    let ont00001100 = Prefixed_Name(comcore, "ont00001100") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interval Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001101">https://www.commoncoreontologies.org/ont00001101</seealso>
    let ont00001101 = Prefixed_Name(comcore, "ont00001101") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Commercial Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001102">https://www.commoncoreontologies.org/ont00001102</seealso>
    let ont00001102 = Prefixed_Name(comcore, "ont00001102") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artifact Model Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001103">https://www.commoncoreontologies.org/ont00001103</seealso>
    let ont00001103 = Prefixed_Name(comcore, "ont00001103") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Long Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001104">https://www.commoncoreontologies.org/ont00001104</seealso>
    let ont00001104 = Prefixed_Name(comcore, "ont00001104") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Secondary Cell Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001105">https://www.commoncoreontologies.org/ont00001105</seealso>
    let ont00001105 = Prefixed_Name(comcore, "ont00001105") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Roll Axis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001106">https://www.commoncoreontologies.org/ont00001106</seealso>
    let ont00001106 = Prefixed_Name(comcore, "ont00001106") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Landfill"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001107">https://www.commoncoreontologies.org/ont00001107</seealso>
    let ont00001107 = Prefixed_Name(comcore, "ont00001107") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultra High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001108">https://www.commoncoreontologies.org/ont00001108</seealso>
    let ont00001108 = Prefixed_Name(comcore, "ont00001108") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Counter-Clockwise Rotational Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001109">https://www.commoncoreontologies.org/ont00001109</seealso>
    let ont00001109 = Prefixed_Name(comcore, "ont00001109") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Evening"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001110">https://www.commoncoreontologies.org/ont00001110</seealso>
    let ont00001110 = Prefixed_Name(comcore, "ont00001110") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Low Midrange Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001111">https://www.commoncoreontologies.org/ont00001111</seealso>
    let ont00001111 = Prefixed_Name(comcore, "ont00001111") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proper Acceleration"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001112">https://www.commoncoreontologies.org/ont00001112</seealso>
    let ont00001112 = Prefixed_Name(comcore, "ont00001112") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Magenta"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001113">https://www.commoncoreontologies.org/ont00001113</seealso>
    let ont00001113 = Prefixed_Name(comcore, "ont00001113") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Division of Delimiting Domain"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001114">https://www.commoncoreontologies.org/ont00001114</seealso>
    let ont00001114 = Prefixed_Name(comcore, "ont00001114") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Private Network Telephone Call"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001115">https://www.commoncoreontologies.org/ont00001115</seealso>
    let ont00001115 = Prefixed_Name(comcore, "ont00001115") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reference Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001116">https://www.commoncoreontologies.org/ont00001116</seealso>
    let ont00001116 = Prefixed_Name(comcore, "ont00001116") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propelling Nozzle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001117">https://www.commoncoreontologies.org/ont00001117</seealso>
    let ont00001117 = Prefixed_Name(comcore, "ont00001117") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Surface Tension"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001118">https://www.commoncoreontologies.org/ont00001118</seealso>
    let ont00001118 = Prefixed_Name(comcore, "ont00001118") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Form Document"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001119">https://www.commoncoreontologies.org/ont00001119</seealso>
    let ont00001119 = Prefixed_Name(comcore, "ont00001119") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Religious Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001120">https://www.commoncoreontologies.org/ont00001120</seealso>
    let ont00001120 = Prefixed_Name(comcore, "ont00001120") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scramjet Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001121">https://www.commoncoreontologies.org/ont00001121</seealso>
    let ont00001121 = Prefixed_Name(comcore, "ont00001121") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Interference"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001122">https://www.commoncoreontologies.org/ont00001122</seealso>
    let ont00001122 = Prefixed_Name(comcore, "ont00001122") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Poison Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001123">https://www.commoncoreontologies.org/ont00001123</seealso>
    let ont00001123 = Prefixed_Name(comcore, "ont00001123") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001124</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Precision-Guided Missile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001124">https://www.commoncoreontologies.org/ont00001124</seealso>
    let ont00001124 = Prefixed_Name(comcore, "ont00001124") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Set of Eyes"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001125">https://www.commoncoreontologies.org/ont00001125</seealso>
    let ont00001125 = Prefixed_Name(comcore, "ont00001125") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001126</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Luminescent Property"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001126">https://www.commoncoreontologies.org/ont00001126</seealso>
    let ont00001126 = Prefixed_Name(comcore, "ont00001126") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001127</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001127">https://www.commoncoreontologies.org/ont00001127</seealso>
    let ont00001127 = Prefixed_Name(comcore, "ont00001127") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001128</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Residing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001128">https://www.commoncoreontologies.org/ont00001128</seealso>
    let ont00001128 = Prefixed_Name(comcore, "ont00001128") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pressurization Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001129">https://www.commoncoreontologies.org/ont00001129</seealso>
    let ont00001129 = Prefixed_Name(comcore, "ont00001129") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001130</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Polygon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001130">https://www.commoncoreontologies.org/ont00001130</seealso>
    let ont00001130 = Prefixed_Name(comcore, "ont00001130") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a EAN-8 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001131">https://www.commoncoreontologies.org/ont00001131</seealso>
    let ont00001131 = Prefixed_Name(comcore, "ont00001131") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Mission Capability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001132">https://www.commoncoreontologies.org/ont00001132</seealso>
    let ont00001132 = Prefixed_Name(comcore, "ont00001132") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001133</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001133">https://www.commoncoreontologies.org/ont00001133</seealso>
    let ont00001133 = Prefixed_Name(comcore, "ont00001133") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001134</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vehicle Frame"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001134">https://www.commoncoreontologies.org/ont00001134</seealso>
    let ont00001134 = Prefixed_Name(comcore, "ont00001134") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001135</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Liquid Fuel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001135">https://www.commoncoreontologies.org/ont00001135</seealso>
    let ont00001135 = Prefixed_Name(comcore, "ont00001135") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001136</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ultrasonic Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001136">https://www.commoncoreontologies.org/ont00001136</seealso>
    let ont00001136 = Prefixed_Name(comcore, "ont00001136") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001137</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiation Reflectivity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001137">https://www.commoncoreontologies.org/ont00001137</seealso>
    let ont00001137 = Prefixed_Name(comcore, "ont00001137") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001138</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Beverage Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001138">https://www.commoncoreontologies.org/ont00001138</seealso>
    let ont00001138 = Prefixed_Name(comcore, "ont00001138") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spacecraft"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001139">https://www.commoncoreontologies.org/ont00001139</seealso>
    let ont00001139 = Prefixed_Name(comcore, "ont00001139") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flywheel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001140">https://www.commoncoreontologies.org/ont00001140</seealso>
    let ont00001140 = Prefixed_Name(comcore, "ont00001140") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrastructure Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001141">https://www.commoncoreontologies.org/ont00001141</seealso>
    let ont00001141 = Prefixed_Name(comcore, "ont00001141") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Violet"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001142">https://www.commoncoreontologies.org/ont00001142</seealso>
    let ont00001142 = Prefixed_Name(comcore, "ont00001142") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001143</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Facsimile Transmission"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001143">https://www.commoncoreontologies.org/ont00001143</seealso>
    let ont00001143 = Prefixed_Name(comcore, "ont00001143") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Entertainment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001144">https://www.commoncoreontologies.org/ont00001144</seealso>
    let ont00001144 = Prefixed_Name(comcore, "ont00001144") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001145</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Receiver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001145">https://www.commoncoreontologies.org/ont00001145</seealso>
    let ont00001145 = Prefixed_Name(comcore, "ont00001145") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sidereal Time Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001146">https://www.commoncoreontologies.org/ont00001146</seealso>
    let ont00001146 = Prefixed_Name(comcore, "ont00001146") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001147</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Violence"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001147">https://www.commoncoreontologies.org/ont00001147</seealso>
    let ont00001147 = Prefixed_Name(comcore, "ont00001147") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Communication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001148">https://www.commoncoreontologies.org/ont00001148</seealso>
    let ont00001148 = Prefixed_Name(comcore, "ont00001148") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001149</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Range Interval Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001149">https://www.commoncoreontologies.org/ont00001149</seealso>
    let ont00001149 = Prefixed_Name(comcore, "ont00001149") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001150</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Ammunition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001150">https://www.commoncoreontologies.org/ont00001150</seealso>
    let ont00001150 = Prefixed_Name(comcore, "ont00001150") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001151</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Paper"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001151">https://www.commoncoreontologies.org/ont00001151</seealso>
    let ont00001151 = Prefixed_Name(comcore, "ont00001151") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001152</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government Domain"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001152">https://www.commoncoreontologies.org/ont00001152</seealso>
    let ont00001152 = Prefixed_Name(comcore, "ont00001152") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001153</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Damaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001153">https://www.commoncoreontologies.org/ont00001153</seealso>
    let ont00001153 = Prefixed_Name(comcore, "ont00001153") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001154</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Second Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001154">https://www.commoncoreontologies.org/ont00001154</seealso>
    let ont00001154 = Prefixed_Name(comcore, "ont00001154") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001155</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Full Motion Video Imaging Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001155">https://www.commoncoreontologies.org/ont00001155</seealso>
    let ont00001155 = Prefixed_Name(comcore, "ont00001155") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001156</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Information Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001156">https://www.commoncoreontologies.org/ont00001156</seealso>
    let ont00001156 = Prefixed_Name(comcore, "ont00001156") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001157</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydraulic Power Source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001157">https://www.commoncoreontologies.org/ont00001157</seealso>
    let ont00001157 = Prefixed_Name(comcore, "ont00001157") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001158</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Data Transformation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001158">https://www.commoncoreontologies.org/ont00001158</seealso>
    let ont00001158 = Prefixed_Name(comcore, "ont00001158") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001159</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bond"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001159">https://www.commoncoreontologies.org/ont00001159</seealso>
    let ont00001159 = Prefixed_Name(comcore, "ont00001159") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001160</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solvent Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001160">https://www.commoncoreontologies.org/ont00001160</seealso>
    let ont00001160 = Prefixed_Name(comcore, "ont00001160") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001161</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Counterfeit Legal Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001161">https://www.commoncoreontologies.org/ont00001161</seealso>
    let ont00001161 = Prefixed_Name(comcore, "ont00001161") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001162</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Commissive Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001162">https://www.commoncoreontologies.org/ont00001162</seealso>
    let ont00001162 = Prefixed_Name(comcore, "ont00001162") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001163</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001163">https://www.commoncoreontologies.org/ont00001163</seealso>
    let ont00001163 = Prefixed_Name(comcore, "ont00001163") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001164</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"County"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001164">https://www.commoncoreontologies.org/ont00001164</seealso>
    let ont00001164 = Prefixed_Name(comcore, "ont00001164") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Terrorist Training Camp"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001165">https://www.commoncoreontologies.org/ont00001165</seealso>
    let ont00001165 = Prefixed_Name(comcore, "ont00001165") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001166</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Minute Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001166">https://www.commoncoreontologies.org/ont00001166</seealso>
    let ont00001166 = Prefixed_Name(comcore, "ont00001166") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001167</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Midrange Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001167">https://www.commoncoreontologies.org/ont00001167</seealso>
    let ont00001167 = Prefixed_Name(comcore, "ont00001167") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001168</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reaction Mass"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001168">https://www.commoncoreontologies.org/ont00001168</seealso>
    let ont00001168 = Prefixed_Name(comcore, "ont00001168") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Communication Relay Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001169">https://www.commoncoreontologies.org/ont00001169</seealso>
    let ont00001169 = Prefixed_Name(comcore, "ont00001169") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001170</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hard X-ray Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001170">https://www.commoncoreontologies.org/ont00001170</seealso>
    let ont00001170 = Prefixed_Name(comcore, "ont00001170") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wireless Network Telephone Call"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001171">https://www.commoncoreontologies.org/ont00001171</seealso>
    let ont00001171 = Prefixed_Name(comcore, "ont00001171") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001172</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Gelatinous Propellant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001172">https://www.commoncoreontologies.org/ont00001172</seealso>
    let ont00001172 = Prefixed_Name(comcore, "ont00001172") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001173</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rocket Launcher"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001173">https://www.commoncoreontologies.org/ont00001173</seealso>
    let ont00001173 = Prefixed_Name(comcore, "ont00001173") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001174</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Shielding Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001174">https://www.commoncoreontologies.org/ont00001174</seealso>
    let ont00001174 = Prefixed_Name(comcore, "ont00001174") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001175</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001175">https://www.commoncoreontologies.org/ont00001175</seealso>
    let ont00001175 = Prefixed_Name(comcore, "ont00001175") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Estimate Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001176">https://www.commoncoreontologies.org/ont00001176</seealso>
    let ont00001176 = Prefixed_Name(comcore, "ont00001176") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001177</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Roll Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001177">https://www.commoncoreontologies.org/ont00001177</seealso>
    let ont00001177 = Prefixed_Name(comcore, "ont00001177") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Railway Crossing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001178">https://www.commoncoreontologies.org/ont00001178</seealso>
    let ont00001178 = Prefixed_Name(comcore, "ont00001178") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Digital Storage Device"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001179">https://www.commoncoreontologies.org/ont00001179</seealso>
    let ont00001179 = Prefixed_Name(comcore, "ont00001179") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001180">https://www.commoncoreontologies.org/ont00001180</seealso>
    let ont00001180 = Prefixed_Name(comcore, "ont00001180") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001181</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Triple Inertial Navigation System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001181">https://www.commoncoreontologies.org/ont00001181</seealso>
    let ont00001181 = Prefixed_Name(comcore, "ont00001181") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Phase Angle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001182">https://www.commoncoreontologies.org/ont00001182</seealso>
    let ont00001182 = Prefixed_Name(comcore, "ont00001182") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Social Network"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001183">https://www.commoncoreontologies.org/ont00001183</seealso>
    let ont00001183 = Prefixed_Name(comcore, "ont00001183") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spinning Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001184">https://www.commoncoreontologies.org/ont00001184</seealso>
    let ont00001184 = Prefixed_Name(comcore, "ont00001184") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rocket"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001185">https://www.commoncoreontologies.org/ont00001185</seealso>
    let ont00001185 = Prefixed_Name(comcore, "ont00001185") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Color Hue"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001186">https://www.commoncoreontologies.org/ont00001186</seealso>
    let ont00001186 = Prefixed_Name(comcore, "ont00001186") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001187</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Navigation System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001187">https://www.commoncoreontologies.org/ont00001187</seealso>
    let ont00001187 = Prefixed_Name(comcore, "ont00001187") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001188</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Denture"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001188">https://www.commoncoreontologies.org/ont00001188</seealso>
    let ont00001188 = Prefixed_Name(comcore, "ont00001188") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001189</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blue"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001189">https://www.commoncoreontologies.org/ont00001189</seealso>
    let ont00001189 = Prefixed_Name(comcore, "ont00001189") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001190</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone Call"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001190">https://www.commoncoreontologies.org/ont00001190</seealso>
    let ont00001190 = Prefixed_Name(comcore, "ont00001190") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001191</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operational Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001191">https://www.commoncoreontologies.org/ont00001191</seealso>
    let ont00001191 = Prefixed_Name(comcore, "ont00001191") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001192</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001192">https://www.commoncoreontologies.org/ont00001192</seealso>
    let ont00001192 = Prefixed_Name(comcore, "ont00001192") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001193</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fatigability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001193">https://www.commoncoreontologies.org/ont00001193</seealso>
    let ont00001193 = Prefixed_Name(comcore, "ont00001193") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001194</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gain of Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001194">https://www.commoncoreontologies.org/ont00001194</seealso>
    let ont00001194 = Prefixed_Name(comcore, "ont00001194") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geospatial Error Region"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001195">https://www.commoncoreontologies.org/ont00001195</seealso>
    let ont00001195 = Prefixed_Name(comcore, "ont00001195") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Artifact Assembly"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001196">https://www.commoncoreontologies.org/ont00001196</seealso>
    let ont00001196 = Prefixed_Name(comcore, "ont00001196") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Anthropogenic Feature"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001197">https://www.commoncoreontologies.org/ont00001197</seealso>
    let ont00001197 = Prefixed_Name(comcore, "ont00001197") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001198</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Railcar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001198">https://www.commoncoreontologies.org/ont00001198</seealso>
    let ont00001198 = Prefixed_Name(comcore, "ont00001198") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001199</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Protruding"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001199">https://www.commoncoreontologies.org/ont00001199</seealso>
    let ont00001199 = Prefixed_Name(comcore, "ont00001199") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001200</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Structural Support Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001200">https://www.commoncoreontologies.org/ont00001200</seealso>
    let ont00001200 = Prefixed_Name(comcore, "ont00001200") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Trail"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001201">https://www.commoncoreontologies.org/ont00001201</seealso>
    let ont00001201 = Prefixed_Name(comcore, "ont00001201") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Size Quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001202">https://www.commoncoreontologies.org/ont00001202</seealso>
    let ont00001202 = Prefixed_Name(comcore, "ont00001202") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Delimiting Domain"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001203">https://www.commoncoreontologies.org/ont00001203</seealso>
    let ont00001203 = Prefixed_Name(comcore, "ont00001203") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001204</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Night"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001204">https://www.commoncoreontologies.org/ont00001204</seealso>
    let ont00001204 = Prefixed_Name(comcore, "ont00001204") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001205</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Priority Scale"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001205">https://www.commoncoreontologies.org/ont00001205</seealso>
    let ont00001205 = Prefixed_Name(comcore, "ont00001205") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001206</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi-Year Temporal Interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001206">https://www.commoncoreontologies.org/ont00001206</seealso>
    let ont00001206 = Prefixed_Name(comcore, "ont00001206") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001207</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optical Lens"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001207">https://www.commoncoreontologies.org/ont00001207</seealso>
    let ont00001207 = Prefixed_Name(comcore, "ont00001207") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001208</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"High Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001208">https://www.commoncoreontologies.org/ont00001208</seealso>
    let ont00001208 = Prefixed_Name(comcore, "ont00001208") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001209</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a UPC-E Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001209">https://www.commoncoreontologies.org/ont00001209</seealso>
    let ont00001209 = Prefixed_Name(comcore, "ont00001209") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Retail Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001210">https://www.commoncoreontologies.org/ont00001210</seealso>
    let ont00001210 = Prefixed_Name(comcore, "ont00001210") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001211</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lifting Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001211">https://www.commoncoreontologies.org/ont00001211</seealso>
    let ont00001211 = Prefixed_Name(comcore, "ont00001211") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001212</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Female Sex"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001212">https://www.commoncoreontologies.org/ont00001212</seealso>
    let ont00001212 = Prefixed_Name(comcore, "ont00001212") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001213</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stasis of Artifact Operationality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001213">https://www.commoncoreontologies.org/ont00001213</seealso>
    let ont00001213 = Prefixed_Name(comcore, "ont00001213") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001214</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Specifically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001214">https://www.commoncoreontologies.org/ont00001214</seealso>
    let ont00001214 = Prefixed_Name(comcore, "ont00001214") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001215</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Funeral"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001215">https://www.commoncoreontologies.org/ont00001215</seealso>
    let ont00001215 = Prefixed_Name(comcore, "ont00001215") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Periscope"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001216">https://www.commoncoreontologies.org/ont00001216</seealso>
    let ont00001216 = Prefixed_Name(comcore, "ont00001216") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001217</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Medium Machine Gun"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001217">https://www.commoncoreontologies.org/ont00001217</seealso>
    let ont00001217 = Prefixed_Name(comcore, "ont00001217") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Signal Processing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001218">https://www.commoncoreontologies.org/ont00001218</seealso>
    let ont00001218 = Prefixed_Name(comcore, "ont00001218") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Delta-v"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001219">https://www.commoncoreontologies.org/ont00001219</seealso>
    let ont00001219 = Prefixed_Name(comcore, "ont00001219") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Opaque"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001220">https://www.commoncoreontologies.org/ont00001220</seealso>
    let ont00001220 = Prefixed_Name(comcore, "ont00001220") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physically Powered Engine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001221">https://www.commoncoreontologies.org/ont00001221</seealso>
    let ont00001221 = Prefixed_Name(comcore, "ont00001221") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solar Panel System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001222">https://www.commoncoreontologies.org/ont00001222</seealso>
    let ont00001222 = Prefixed_Name(comcore, "ont00001222") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dish Receiver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001223">https://www.commoncoreontologies.org/ont00001223</seealso>
    let ont00001223 = Prefixed_Name(comcore, "ont00001223") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process Requirement"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001224">https://www.commoncoreontologies.org/ont00001224</seealso>
    let ont00001224 = Prefixed_Name(comcore, "ont00001224") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Yellow"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001225">https://www.commoncoreontologies.org/ont00001225</seealso>
    let ont00001225 = Prefixed_Name(comcore, "ont00001225") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001226</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Employment by an Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001226">https://www.commoncoreontologies.org/ont00001226</seealso>
    let ont00001226 = Prefixed_Name(comcore, "ont00001226") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Longitudinal Wave Profile"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001227">https://www.commoncoreontologies.org/ont00001227</seealso>
    let ont00001227 = Prefixed_Name(comcore, "ont00001227") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Journal Article"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001228">https://www.commoncoreontologies.org/ont00001228</seealso>
    let ont00001228 = Prefixed_Name(comcore, "ont00001228") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001229</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Alkaline Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001229">https://www.commoncoreontologies.org/ont00001229</seealso>
    let ont00001229 = Prefixed_Name(comcore, "ont00001229") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001230</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rhombic Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001230">https://www.commoncoreontologies.org/ont00001230</seealso>
    let ont00001230 = Prefixed_Name(comcore, "ont00001230") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Brilliance Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001231">https://www.commoncoreontologies.org/ont00001231</seealso>
    let ont00001231 = Prefixed_Name(comcore, "ont00001231") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Possession"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001232">https://www.commoncoreontologies.org/ont00001232</seealso>
    let ont00001232 = Prefixed_Name(comcore, "ont00001232") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Crushing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001233">https://www.commoncoreontologies.org/ont00001233</seealso>
    let ont00001233 = Prefixed_Name(comcore, "ont00001233") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neutralization Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001234">https://www.commoncoreontologies.org/ont00001234</seealso>
    let ont00001234 = Prefixed_Name(comcore, "ont00001234") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Time Zone Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001235">https://www.commoncoreontologies.org/ont00001235</seealso>
    let ont00001235 = Prefixed_Name(comcore, "ont00001235") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001236</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Suicide"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001236">https://www.commoncoreontologies.org/ont00001236</seealso>
    let ont00001236 = Prefixed_Name(comcore, "ont00001236") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001237</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Birth"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001237">https://www.commoncoreontologies.org/ont00001237</seealso>
    let ont00001237 = Prefixed_Name(comcore, "ont00001237") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001238</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Initialism"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001238">https://www.commoncoreontologies.org/ont00001238</seealso>
    let ont00001238 = Prefixed_Name(comcore, "ont00001238") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Group of Organizations"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001239">https://www.commoncoreontologies.org/ont00001239</seealso>
    let ont00001239 = Prefixed_Name(comcore, "ont00001239") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001240</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Communication Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001240">https://www.commoncoreontologies.org/ont00001240</seealso>
    let ont00001240 = Prefixed_Name(comcore, "ont00001240") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001241</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001241">https://www.commoncoreontologies.org/ont00001241</seealso>
    let ont00001241 = Prefixed_Name(comcore, "ont00001241") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001242</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Actuator"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001242">https://www.commoncoreontologies.org/ont00001242</seealso>
    let ont00001242 = Prefixed_Name(comcore, "ont00001242") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001243</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Document Field"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001243">https://www.commoncoreontologies.org/ont00001243</seealso>
    let ont00001243 = Prefixed_Name(comcore, "ont00001243") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001244</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Issuing Mass Media Article"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001244">https://www.commoncoreontologies.org/ont00001244</seealso>
    let ont00001244 = Prefixed_Name(comcore, "ont00001244") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001245</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a PDF417 Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001245">https://www.commoncoreontologies.org/ont00001245</seealso>
    let ont00001245 = Prefixed_Name(comcore, "ont00001245") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001246</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Under Active Control"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001246">https://www.commoncoreontologies.org/ont00001246</seealso>
    let ont00001246 = Prefixed_Name(comcore, "ont00001246") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001247</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telecommunication Endpoint"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001247">https://www.commoncoreontologies.org/ont00001247</seealso>
    let ont00001247 = Prefixed_Name(comcore, "ont00001247") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001248</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Artificial Eye"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001248">https://www.commoncoreontologies.org/ont00001248</seealso>
    let ont00001248 = Prefixed_Name(comcore, "ont00001248") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001249</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cabin Pressurization Control System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001249">https://www.commoncoreontologies.org/ont00001249</seealso>
    let ont00001249 = Prefixed_Name(comcore, "ont00001249") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001250</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interior Lighting System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001250">https://www.commoncoreontologies.org/ont00001250</seealso>
    let ont00001250 = Prefixed_Name(comcore, "ont00001250") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001251</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Intelligence Gathering"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001251">https://www.commoncoreontologies.org/ont00001251</seealso>
    let ont00001251 = Prefixed_Name(comcore, "ont00001251") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001252</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Propulsion Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001252">https://www.commoncoreontologies.org/ont00001252</seealso>
    let ont00001252 = Prefixed_Name(comcore, "ont00001252") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001253</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fuel Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001253">https://www.commoncoreontologies.org/ont00001253</seealso>
    let ont00001253 = Prefixed_Name(comcore, "ont00001253") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001254</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Revolver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001254">https://www.commoncoreontologies.org/ont00001254</seealso>
    let ont00001254 = Prefixed_Name(comcore, "ont00001254") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Insecticide Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001255">https://www.commoncoreontologies.org/ont00001255</seealso>
    let ont00001255 = Prefixed_Name(comcore, "ont00001255") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reliability Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001256">https://www.commoncoreontologies.org/ont00001256</seealso>
    let ont00001256 = Prefixed_Name(comcore, "ont00001256") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nuclear Storage Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001257">https://www.commoncoreontologies.org/ont00001257</seealso>
    let ont00001257 = Prefixed_Name(comcore, "ont00001257") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001258</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Port"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001258">https://www.commoncoreontologies.org/ont00001258</seealso>
    let ont00001258 = Prefixed_Name(comcore, "ont00001258") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001259</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Atmosphere"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001259">https://www.commoncoreontologies.org/ont00001259</seealso>
    let ont00001259 = Prefixed_Name(comcore, "ont00001259") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001260</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Code 39 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001260">https://www.commoncoreontologies.org/ont00001260</seealso>
    let ont00001260 = Prefixed_Name(comcore, "ont00001260") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001261</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Identifying"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001261">https://www.commoncoreontologies.org/ont00001261</seealso>
    let ont00001261 = Prefixed_Name(comcore, "ont00001261") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001262">https://www.commoncoreontologies.org/ont00001262</seealso>
    let ont00001262 = Prefixed_Name(comcore, "ont00001262") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001263</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Issuing Mass Media Documentary"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001263">https://www.commoncoreontologies.org/ont00001263</seealso>
    let ont00001263 = Prefixed_Name(comcore, "ont00001263") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001264</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Code 128 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001264">https://www.commoncoreontologies.org/ont00001264</seealso>
    let ont00001264 = Prefixed_Name(comcore, "ont00001264") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001265</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Public Address System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001265">https://www.commoncoreontologies.org/ont00001265</seealso>
    let ont00001265 = Prefixed_Name(comcore, "ont00001265") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001266</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Vocational Training Instruction"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001266">https://www.commoncoreontologies.org/ont00001266</seealso>
    let ont00001266 = Prefixed_Name(comcore, "ont00001266") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001267</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Propaganda"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001267">https://www.commoncoreontologies.org/ont00001267</seealso>
    let ont00001267 = Prefixed_Name(comcore, "ont00001267") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a ISBN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001268">https://www.commoncoreontologies.org/ont00001268</seealso>
    let ont00001268 = Prefixed_Name(comcore, "ont00001268") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001269</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Warning"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001269">https://www.commoncoreontologies.org/ont00001269</seealso>
    let ont00001269 = Prefixed_Name(comcore, "ont00001269") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001270</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Howitzer"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001270">https://www.commoncoreontologies.org/ont00001270</seealso>
    let ont00001270 = Prefixed_Name(comcore, "ont00001270") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001271</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wired Communication Relay Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001271">https://www.commoncoreontologies.org/ont00001271</seealso>
    let ont00001271 = Prefixed_Name(comcore, "ont00001271") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001272</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Murder"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001272">https://www.commoncoreontologies.org/ont00001272</seealso>
    let ont00001272 = Prefixed_Name(comcore, "ont00001272") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001274</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrasonic Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001274">https://www.commoncoreontologies.org/ont00001274</seealso>
    let ont00001274 = Prefixed_Name(comcore, "ont00001274") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001275</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nominal Speed Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001275">https://www.commoncoreontologies.org/ont00001275</seealso>
    let ont00001275 = Prefixed_Name(comcore, "ont00001275") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Carrier Air Wing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001276">https://www.commoncoreontologies.org/ont00001276</seealso>
    let ont00001276 = Prefixed_Name(comcore, "ont00001276") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001277</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Red"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001277">https://www.commoncoreontologies.org/ont00001277</seealso>
    let ont00001277 = Prefixed_Name(comcore, "ont00001277") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stock"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001278">https://www.commoncoreontologies.org/ont00001278</seealso>
    let ont00001278 = Prefixed_Name(comcore, "ont00001278") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001279</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vibration Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001279">https://www.commoncoreontologies.org/ont00001279</seealso>
    let ont00001279 = Prefixed_Name(comcore, "ont00001279") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flat"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001280">https://www.commoncoreontologies.org/ont00001280</seealso>
    let ont00001280 = Prefixed_Name(comcore, "ont00001280") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Emulsifier Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001281">https://www.commoncoreontologies.org/ont00001281</seealso>
    let ont00001281 = Prefixed_Name(comcore, "ont00001281") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001282</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hydraulic Valve"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001282">https://www.commoncoreontologies.org/ont00001282</seealso>
    let ont00001282 = Prefixed_Name(comcore, "ont00001282") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refinery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001283">https://www.commoncoreontologies.org/ont00001283</seealso>
    let ont00001283 = Prefixed_Name(comcore, "ont00001283") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Crew"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001284">https://www.commoncoreontologies.org/ont00001284</seealso>
    let ont00001284 = Prefixed_Name(comcore, "ont00001284") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Revolving Motion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001285">https://www.commoncoreontologies.org/ont00001285</seealso>
    let ont00001285 = Prefixed_Name(comcore, "ont00001285") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001286</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Waveform"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001286">https://www.commoncoreontologies.org/ont00001286</seealso>
    let ont00001286 = Prefixed_Name(comcore, "ont00001286") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001287</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maintenance Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001287">https://www.commoncoreontologies.org/ont00001287</seealso>
    let ont00001287 = Prefixed_Name(comcore, "ont00001287") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001288</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Round Shot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001288">https://www.commoncoreontologies.org/ont00001288</seealso>
    let ont00001288 = Prefixed_Name(comcore, "ont00001288") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001289</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Damaged Stasis"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001289">https://www.commoncoreontologies.org/ont00001289</seealso>
    let ont00001289 = Prefixed_Name(comcore, "ont00001289") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001290</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Length"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001290">https://www.commoncoreontologies.org/ont00001290</seealso>
    let ont00001290 = Prefixed_Name(comcore, "ont00001290") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001291</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radiation Absorptivity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001291">https://www.commoncoreontologies.org/ont00001291</seealso>
    let ont00001291 = Prefixed_Name(comcore, "ont00001291") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001292</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bus"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001292">https://www.commoncoreontologies.org/ont00001292</seealso>
    let ont00001292 = Prefixed_Name(comcore, "ont00001292") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001293</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Perimeter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001293">https://www.commoncoreontologies.org/ont00001293</seealso>
    let ont00001293 = Prefixed_Name(comcore, "ont00001293") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001294</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Three Dimensional Extent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001294">https://www.commoncoreontologies.org/ont00001294</seealso>
    let ont00001294 = Prefixed_Name(comcore, "ont00001294") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001295">https://www.commoncoreontologies.org/ont00001295</seealso>
    let ont00001295 = Prefixed_Name(comcore, "ont00001295") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pitch Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001296">https://www.commoncoreontologies.org/ont00001296</seealso>
    let ont00001296 = Prefixed_Name(comcore, "ont00001296") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001297</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Headquarters Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001297">https://www.commoncoreontologies.org/ont00001297</seealso>
    let ont00001297 = Prefixed_Name(comcore, "ont00001297") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001298</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Copy of a Document"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001298">https://www.commoncoreontologies.org/ont00001298</seealso>
    let ont00001298 = Prefixed_Name(comcore, "ont00001298") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001299</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wetting Agent Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001299">https://www.commoncoreontologies.org/ont00001299</seealso>
    let ont00001299 = Prefixed_Name(comcore, "ont00001299") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Patch Antenna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001300">https://www.commoncoreontologies.org/ont00001300</seealso>
    let ont00001300 = Prefixed_Name(comcore, "ont00001300") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001301">https://www.commoncoreontologies.org/ont00001301</seealso>
    let ont00001301 = Prefixed_Name(comcore, "ont00001301") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Civil Organization"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001302">https://www.commoncoreontologies.org/ont00001302</seealso>
    let ont00001302 = Prefixed_Name(comcore, "ont00001302") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001303</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Position Observation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001303">https://www.commoncoreontologies.org/ont00001303</seealso>
    let ont00001303 = Prefixed_Name(comcore, "ont00001303") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dimension Specification"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001304">https://www.commoncoreontologies.org/ont00001304</seealso>
    let ont00001304 = Prefixed_Name(comcore, "ont00001304") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001305</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Loss of Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001305">https://www.commoncoreontologies.org/ont00001305</seealso>
    let ont00001305 = Prefixed_Name(comcore, "ont00001305") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Observation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001306">https://www.commoncoreontologies.org/ont00001306</seealso>
    let ont00001306 = Prefixed_Name(comcore, "ont00001306") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Mass Flow Rate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001307">https://www.commoncoreontologies.org/ont00001307</seealso>
    let ont00001307 = Prefixed_Name(comcore, "ont00001307") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sewage Treatment Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001308">https://www.commoncoreontologies.org/ont00001308</seealso>
    let ont00001308 = Prefixed_Name(comcore, "ont00001308") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lot Number"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001309">https://www.commoncoreontologies.org/ont00001309</seealso>
    let ont00001309 = Prefixed_Name(comcore, "ont00001309") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Covering Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001310">https://www.commoncoreontologies.org/ont00001310</seealso>
    let ont00001310 = Prefixed_Name(comcore, "ont00001310") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Aircraft Manufacturing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001311">https://www.commoncoreontologies.org/ont00001311</seealso>
    let ont00001311 = Prefixed_Name(comcore, "ont00001311") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001312</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Paramilitary Force"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001312">https://www.commoncoreontologies.org/ont00001312</seealso>
    let ont00001312 = Prefixed_Name(comcore, "ont00001312") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001313</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Article of Clothing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001313">https://www.commoncoreontologies.org/ont00001313</seealso>
    let ont00001313 = Prefixed_Name(comcore, "ont00001313") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001314</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Legal System Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001314">https://www.commoncoreontologies.org/ont00001314</seealso>
    let ont00001314 = Prefixed_Name(comcore, "ont00001314") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001315</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Waste Management Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001315">https://www.commoncoreontologies.org/ont00001315</seealso>
    let ont00001315 = Prefixed_Name(comcore, "ont00001315") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gimbal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001316">https://www.commoncoreontologies.org/ont00001316</seealso>
    let ont00001316 = Prefixed_Name(comcore, "ont00001316") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001317</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Volume"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001317">https://www.commoncoreontologies.org/ont00001317</seealso>
    let ont00001317 = Prefixed_Name(comcore, "ont00001317") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001318</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Yaw Orientation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001318">https://www.commoncoreontologies.org/ont00001318</seealso>
    let ont00001318 = Prefixed_Name(comcore, "ont00001318") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001319</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tank"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001319">https://www.commoncoreontologies.org/ont00001319</seealso>
    let ont00001319 = Prefixed_Name(comcore, "ont00001319") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Transceiver"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001320">https://www.commoncoreontologies.org/ont00001320</seealso>
    let ont00001320 = Prefixed_Name(comcore, "ont00001320") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001321</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lead Acid Electric Battery"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001321">https://www.commoncoreontologies.org/ont00001321</seealso>
    let ont00001321 = Prefixed_Name(comcore, "ont00001321") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001322</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decrease of Generically Dependent Continuant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001322">https://www.commoncoreontologies.org/ont00001322</seealso>
    let ont00001322 = Prefixed_Name(comcore, "ont00001322") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bearing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001323">https://www.commoncoreontologies.org/ont00001323</seealso>
    let ont00001323 = Prefixed_Name(comcore, "ont00001323") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001324</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process Regulation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001324">https://www.commoncoreontologies.org/ont00001324</seealso>
    let ont00001324 = Prefixed_Name(comcore, "ont00001324") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Renting"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001325">https://www.commoncoreontologies.org/ont00001325</seealso>
    let ont00001325 = Prefixed_Name(comcore, "ont00001325") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001326</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Land Transportation Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001326">https://www.commoncoreontologies.org/ont00001326</seealso>
    let ont00001326 = Prefixed_Name(comcore, "ont00001326") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001327</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Social Act"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001327">https://www.commoncoreontologies.org/ont00001327</seealso>
    let ont00001327 = Prefixed_Name(comcore, "ont00001327") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001328</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001328">https://www.commoncoreontologies.org/ont00001328</seealso>
    let ont00001328 = Prefixed_Name(comcore, "ont00001328") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001329</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Education Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001329">https://www.commoncoreontologies.org/ont00001329</seealso>
    let ont00001329 = Prefixed_Name(comcore, "ont00001329") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001330</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telemetry Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001330">https://www.commoncoreontologies.org/ont00001330</seealso>
    let ont00001330 = Prefixed_Name(comcore, "ont00001330") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001331</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Legal Name"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001331">https://www.commoncoreontologies.org/ont00001331</seealso>
    let ont00001331 = Prefixed_Name(comcore, "ont00001331") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001332</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Extreme Ultraviolet Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001332">https://www.commoncoreontologies.org/ont00001332</seealso>
    let ont00001332 = Prefixed_Name(comcore, "ont00001332") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001333</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rosy"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001333">https://www.commoncoreontologies.org/ont00001333</seealso>
    let ont00001333 = Prefixed_Name(comcore, "ont00001333") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001334</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Purchasing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001334">https://www.commoncoreontologies.org/ont00001334</seealso>
    let ont00001334 = Prefixed_Name(comcore, "ont00001334") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Government"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001335">https://www.commoncoreontologies.org/ont00001335</seealso>
    let ont00001335 = Prefixed_Name(comcore, "ont00001335") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001336</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Ownership"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001336">https://www.commoncoreontologies.org/ont00001336</seealso>
    let ont00001336 = Prefixed_Name(comcore, "ont00001336") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrared Light Frequency"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001337">https://www.commoncoreontologies.org/ont00001337</seealso>
    let ont00001337 = Prefixed_Name(comcore, "ont00001337") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Timbre"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001338">https://www.commoncoreontologies.org/ont00001338</seealso>
    let ont00001338 = Prefixed_Name(comcore, "ont00001338") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001339</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Walking"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001339">https://www.commoncoreontologies.org/ont00001339</seealso>
    let ont00001339 = Prefixed_Name(comcore, "ont00001339") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar Date Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001340">https://www.commoncoreontologies.org/ont00001340</seealso>
    let ont00001340 = Prefixed_Name(comcore, "ont00001340") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Portion of Geosphere"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001341">https://www.commoncoreontologies.org/ont00001341</seealso>
    let ont00001341 = Prefixed_Name(comcore, "ont00001341") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infantry Fighting Vehicle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001342">https://www.commoncoreontologies.org/ont00001342</seealso>
    let ont00001342 = Prefixed_Name(comcore, "ont00001342") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Circuit Breaker"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001343">https://www.commoncoreontologies.org/ont00001343</seealso>
    let ont00001343 = Prefixed_Name(comcore, "ont00001343") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological Depot"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001344">https://www.commoncoreontologies.org/ont00001344</seealso>
    let ont00001344 = Prefixed_Name(comcore, "ont00001344") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Impulse"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001345">https://www.commoncoreontologies.org/ont00001345</seealso>
    let ont00001345 = Prefixed_Name(comcore, "ont00001345") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Legal Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001346">https://www.commoncoreontologies.org/ont00001346</seealso>
    let ont00001346 = Prefixed_Name(comcore, "ont00001346") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Behavior"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001347">https://www.commoncoreontologies.org/ont00001347</seealso>
    let ont00001347 = Prefixed_Name(comcore, "ont00001347") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001348</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Three-Dimensional Position"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001348">https://www.commoncoreontologies.org/ont00001348</seealso>
    let ont00001348 = Prefixed_Name(comcore, "ont00001348") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001349</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Grey"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001349">https://www.commoncoreontologies.org/ont00001349</seealso>
    let ont00001349 = Prefixed_Name(comcore, "ont00001349") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001350</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermal Control Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001350">https://www.commoncoreontologies.org/ont00001350</seealso>
    let ont00001350 = Prefixed_Name(comcore, "ont00001350") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cartesian Coordinate System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001351">https://www.commoncoreontologies.org/ont00001351</seealso>
    let ont00001351 = Prefixed_Name(comcore, "ont00001351") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Greenwich Mean Time Zone Identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001352">https://www.commoncoreontologies.org/ont00001352</seealso>
    let ont00001352 = Prefixed_Name(comcore, "ont00001352") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Speed Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001353">https://www.commoncoreontologies.org/ont00001353</seealso>
    let ont00001353 = Prefixed_Name(comcore, "ont00001353") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001354</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vermilion"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001354">https://www.commoncoreontologies.org/ont00001354</seealso>
    let ont00001354 = Prefixed_Name(comcore, "ont00001354") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001355</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Freight Train Car"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001355">https://www.commoncoreontologies.org/ont00001355</seealso>
    let ont00001355 = Prefixed_Name(comcore, "ont00001355") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001356</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Increase of Disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001356">https://www.commoncoreontologies.org/ont00001356</seealso>
    let ont00001356 = Prefixed_Name(comcore, "ont00001356") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001357</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement Unit of Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001357">https://www.commoncoreontologies.org/ont00001357</seealso>
    let ont00001357 = Prefixed_Name(comcore, "ont00001357") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"School"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001358">https://www.commoncoreontologies.org/ont00001358</seealso>
    let ont00001358 = Prefixed_Name(comcore, "ont00001358") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Manufacturing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001359">https://www.commoncoreontologies.org/ont00001359</seealso>
    let ont00001359 = Prefixed_Name(comcore, "ont00001359") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Three Dimensional Shape"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001360">https://www.commoncoreontologies.org/ont00001360</seealso>
    let ont00001360 = Prefixed_Name(comcore, "ont00001360") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001361</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Healing Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001361">https://www.commoncoreontologies.org/ont00001361</seealso>
    let ont00001361 = Prefixed_Name(comcore, "ont00001361") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas Processing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001362">https://www.commoncoreontologies.org/ont00001362</seealso>
    let ont00001362 = Prefixed_Name(comcore, "ont00001362") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001363</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Male Sex"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001363">https://www.commoncoreontologies.org/ont00001363</seealso>
    let ont00001363 = Prefixed_Name(comcore, "ont00001363") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001364</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interval Measurement Information Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001364">https://www.commoncoreontologies.org/ont00001364</seealso>
    let ont00001364 = Prefixed_Name(comcore, "ont00001364") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001365</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maximum Speed Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001365">https://www.commoncoreontologies.org/ont00001365</seealso>
    let ont00001365 = Prefixed_Name(comcore, "ont00001365") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001366</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Powering Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001366">https://www.commoncoreontologies.org/ont00001366</seealso>
    let ont00001366 = Prefixed_Name(comcore, "ont00001366") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"One Dimensional Extent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001367">https://www.commoncoreontologies.org/ont00001367</seealso>
    let ont00001367 = Prefixed_Name(comcore, "ont00001367") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001368</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Motion Observation Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001368">https://www.commoncoreontologies.org/ont00001368</seealso>
    let ont00001368 = Prefixed_Name(comcore, "ont00001368") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rectangular"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001369">https://www.commoncoreontologies.org/ont00001369</seealso>
    let ont00001369 = Prefixed_Name(comcore, "ont00001369") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001370</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Machine Bearing"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001370">https://www.commoncoreontologies.org/ont00001370</seealso>
    let ont00001370 = Prefixed_Name(comcore, "ont00001370") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electromagnetic Induction Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001371">https://www.commoncoreontologies.org/ont00001371</seealso>
    let ont00001371 = Prefixed_Name(comcore, "ont00001371") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001372</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fertilizer Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001372">https://www.commoncoreontologies.org/ont00001372</seealso>
    let ont00001372 = Prefixed_Name(comcore, "ont00001372") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001373</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bow"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001373">https://www.commoncoreontologies.org/ont00001373</seealso>
    let ont00001373 = Prefixed_Name(comcore, "ont00001373") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Declarative Communication"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001374">https://www.commoncoreontologies.org/ont00001374</seealso>
    let ont00001374 = Prefixed_Name(comcore, "ont00001374") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Washing Facility"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001375">https://www.commoncoreontologies.org/ont00001375</seealso>
    let ont00001375 = Prefixed_Name(comcore, "ont00001375") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Torque"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001376">https://www.commoncoreontologies.org/ont00001376</seealso>
    let ont00001376 = Prefixed_Name(comcore, "ont00001376") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gold Color"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001377">https://www.commoncoreontologies.org/ont00001377</seealso>
    let ont00001377 = Prefixed_Name(comcore, "ont00001377") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001378</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hospitality Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001378">https://www.commoncoreontologies.org/ont00001378</seealso>
    let ont00001378 = Prefixed_Name(comcore, "ont00001378") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001379</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent Capability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001379">https://www.commoncoreontologies.org/ont00001379</seealso>
    let ont00001379 = Prefixed_Name(comcore, "ont00001379") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001380</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Farm"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001380">https://www.commoncoreontologies.org/ont00001380</seealso>
    let ont00001380 = Prefixed_Name(comcore, "ont00001380") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001381</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Medical Artifact"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001381">https://www.commoncoreontologies.org/ont00001381</seealso>
    let ont00001381 = Prefixed_Name(comcore, "ont00001381") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001382</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electronic Cash"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001382">https://www.commoncoreontologies.org/ont00001382</seealso>
    let ont00001382 = Prefixed_Name(comcore, "ont00001382") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001383</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fire Station"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001383">https://www.commoncoreontologies.org/ont00001383</seealso>
    let ont00001383 = Prefixed_Name(comcore, "ont00001383") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Opacity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001384">https://www.commoncoreontologies.org/ont00001384</seealso>
    let ont00001384 = Prefixed_Name(comcore, "ont00001384") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001385</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Haiti Gourde"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001385">https://www.commoncoreontologies.org/ont00001385</seealso>
    let ont00001385 = Prefixed_Name(comcore, "ont00001385") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001386</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yemeni Rial"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001386">https://www.commoncoreontologies.org/ont00001386</seealso>
    let ont00001386 = Prefixed_Name(comcore, "ont00001386") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001387</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Mauritania Ouguiya"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001387">https://www.commoncoreontologies.org/ont00001387</seealso>
    let ont00001387 = Prefixed_Name(comcore, "ont00001387") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001388</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000707</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Minute of Arc Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001388">https://www.commoncoreontologies.org/ont00001388</seealso>
    let ont00001388 = Prefixed_Name(comcore, "ont00001388") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001389</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Kenyan Shilling"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001389">https://www.commoncoreontologies.org/ont00001389</seealso>
    let ont00001389 = Prefixed_Name(comcore, "ont00001389") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001390</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Slug Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001390">https://www.commoncoreontologies.org/ont00001390</seealso>
    let ont00001390 = Prefixed_Name(comcore, "ont00001390") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001391</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000444</para>
    ///   <para>comcore:ont00000852</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000229</para>
    ///
    /// labels<para>"Erg Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001391">https://www.commoncoreontologies.org/ont00001391</seealso>
    let ont00001391 = Prefixed_Name(comcore, "ont00001391") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001392</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT-8"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001392">https://www.commoncoreontologies.org/ont00001392</seealso>
    let ont00001392 = Prefixed_Name(comcore, "ont00001392") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Tablespoon Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001393">https://www.commoncoreontologies.org/ont00001393</seealso>
    let ont00001393 = Prefixed_Name(comcore, "ont00001393") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001394</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Papua New Guinea Kina"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001394">https://www.commoncoreontologies.org/ont00001394</seealso>
    let ont00001394 = Prefixed_Name(comcore, "ont00001394") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001395</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT-3:30"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001395">https://www.commoncoreontologies.org/ont00001395</seealso>
    let ont00001395 = Prefixed_Name(comcore, "ont00001395") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001396</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Viet Nam Dong"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001396">https://www.commoncoreontologies.org/ont00001396</seealso>
    let ont00001396 = Prefixed_Name(comcore, "ont00001396") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001397</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Centimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001397">https://www.commoncoreontologies.org/ont00001397</seealso>
    let ont00001397 = Prefixed_Name(comcore, "ont00001397") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001398</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///
    /// labels<para>"Global Area Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001398">https://www.commoncoreontologies.org/ont00001398</seealso>
    let ont00001398 = Prefixed_Name(comcore, "ont00001398") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001399</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Ghana Cedi"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001399">https://www.commoncoreontologies.org/ont00001399</seealso>
    let ont00001399 = Prefixed_Name(comcore, "ont00001399") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001400</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sri Lanka Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001400">https://www.commoncoreontologies.org/ont00001400</seealso>
    let ont00001400 = Prefixed_Name(comcore, "ont00001400") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001401</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"South Africa Rand"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001401">https://www.commoncoreontologies.org/ont00001401</seealso>
    let ont00001401 = Prefixed_Name(comcore, "ont00001401") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001402</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000770</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilogram Per Liter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001402">https://www.commoncoreontologies.org/ont00001402</seealso>
    let ont00001402 = Prefixed_Name(comcore, "ont00001402") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001403</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Bravo Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001403">https://www.commoncoreontologies.org/ont00001403</seealso>
    let ont00001403 = Prefixed_Name(comcore, "ont00001403") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001404</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Afghanistan Afghani"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001404">https://www.commoncoreontologies.org/ont00001404</seealso>
    let ont00001404 = Prefixed_Name(comcore, "ont00001404") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001405</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-2"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001405">https://www.commoncoreontologies.org/ont00001405</seealso>
    let ont00001405 = Prefixed_Name(comcore, "ont00001405") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001406</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+9:30"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001406">https://www.commoncoreontologies.org/ont00001406</seealso>
    let ont00001406 = Prefixed_Name(comcore, "ont00001406") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001407</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000229</para>
    ///
    /// labels<para>"Shaft Horsepower Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001407">https://www.commoncoreontologies.org/ont00001407</seealso>
    let ont00001407 = Prefixed_Name(comcore, "ont00001407") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001408</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"X-ray Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001408">https://www.commoncoreontologies.org/ont00001408</seealso>
    let ont00001408 = Prefixed_Name(comcore, "ont00001408") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001409</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Singapore Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001409">https://www.commoncoreontologies.org/ont00001409</seealso>
    let ont00001409 = Prefixed_Name(comcore, "ont00001409") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001410</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guyana Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001410">https://www.commoncoreontologies.org/ont00001410</seealso>
    let ont00001410 = Prefixed_Name(comcore, "ont00001410") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001411</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000497</para>
    ///
    /// labels<para>"Pound Force Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001411">https://www.commoncoreontologies.org/ont00001411</seealso>
    let ont00001411 = Prefixed_Name(comcore, "ont00001411") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001412</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001412">https://www.commoncoreontologies.org/ont00001412</seealso>
    let ont00001412 = Prefixed_Name(comcore, "ont00001412") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001413</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Milligram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001413">https://www.commoncoreontologies.org/ont00001413</seealso>
    let ont00001413 = Prefixed_Name(comcore, "ont00001413") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001414</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001328</para>
    ///
    /// labels<para>"Terrestrial Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001414">https://www.commoncoreontologies.org/ont00001414</seealso>
    let ont00001414 = Prefixed_Name(comcore, "ont00001414") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001415</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Swiss Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001415">https://www.commoncoreontologies.org/ont00001415</seealso>
    let ont00001415 = Prefixed_Name(comcore, "ont00001415") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001416</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Centimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001416">https://www.commoncoreontologies.org/ont00001416</seealso>
    let ont00001416 = Prefixed_Name(comcore, "ont00001416") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001417</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001328</para>
    ///
    /// labels<para>"Ephemeris Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001417">https://www.commoncoreontologies.org/ont00001417</seealso>
    let ont00001417 = Prefixed_Name(comcore, "ont00001417") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001418</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000140</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilogram-Mole Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001418">https://www.commoncoreontologies.org/ont00001418</seealso>
    let ont00001418 = Prefixed_Name(comcore, "ont00001418") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001419</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+5"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001419">https://www.commoncoreontologies.org/ont00001419</seealso>
    let ont00001419 = Prefixed_Name(comcore, "ont00001419") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001420</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Dominican Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001420">https://www.commoncoreontologies.org/ont00001420</seealso>
    let ont00001420 = Prefixed_Name(comcore, "ont00001420") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001421</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sierra Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001421">https://www.commoncoreontologies.org/ont00001421</seealso>
    let ont00001421 = Prefixed_Name(comcore, "ont00001421") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001422</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Quart Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001422">https://www.commoncoreontologies.org/ont00001422</seealso>
    let ont00001422 = Prefixed_Name(comcore, "ont00001422") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001423</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Deciliter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001423">https://www.commoncoreontologies.org/ont00001423</seealso>
    let ont00001423 = Prefixed_Name(comcore, "ont00001423") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001424</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Alpha Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001424">https://www.commoncoreontologies.org/ont00001424</seealso>
    let ont00001424 = Prefixed_Name(comcore, "ont00001424") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000969</para>
    ///
    /// labels<para>"Miles Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001425">https://www.commoncoreontologies.org/ont00001425</seealso>
    let ont00001425 = Prefixed_Name(comcore, "ont00001425") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001426</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chinese Renminbi"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001426">https://www.commoncoreontologies.org/ont00001426</seealso>
    let ont00001426 = Prefixed_Name(comcore, "ont00001426") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001427</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Canadian Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001427">https://www.commoncoreontologies.org/ont00001427</seealso>
    let ont00001427 = Prefixed_Name(comcore, "ont00001427") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001428</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilometers Per Hour Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001428">https://www.commoncoreontologies.org/ont00001428</seealso>
    let ont00001428 = Prefixed_Name(comcore, "ont00001428") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001429</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000140</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gram-Mole Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001429">https://www.commoncoreontologies.org/ont00001429</seealso>
    let ont00001429 = Prefixed_Name(comcore, "ont00001429") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001430</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Foxtrot Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001430">https://www.commoncoreontologies.org/ont00001430</seealso>
    let ont00001430 = Prefixed_Name(comcore, "ont00001430") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001431</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Whiskey Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001431">https://www.commoncoreontologies.org/ont00001431</seealso>
    let ont00001431 = Prefixed_Name(comcore, "ont00001431") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001432</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001090</para>
    ///
    /// labels<para>"Kilogram Force Per Centimeter Square Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001432">https://www.commoncoreontologies.org/ont00001432</seealso>
    let ont00001432 = Prefixed_Name(comcore, "ont00001432") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001433</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Mile Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001433">https://www.commoncoreontologies.org/ont00001433</seealso>
    let ont00001433 = Prefixed_Name(comcore, "ont00001433") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001434</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+1"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001434">https://www.commoncoreontologies.org/ont00001434</seealso>
    let ont00001434 = Prefixed_Name(comcore, "ont00001434") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001435</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Colombian Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001435">https://www.commoncoreontologies.org/ont00001435</seealso>
    let ont00001435 = Prefixed_Name(comcore, "ont00001435") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001436</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000630</para>
    ///
    /// labels<para>"Universal Time 1 D"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001436">https://www.commoncoreontologies.org/ont00001436</seealso>
    let ont00001436 = Prefixed_Name(comcore, "ont00001436") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001437</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Liter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001437">https://www.commoncoreontologies.org/ont00001437</seealso>
    let ont00001437 = Prefixed_Name(comcore, "ont00001437") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001438</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000217</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Square Yard Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001438">https://www.commoncoreontologies.org/ont00001438</seealso>
    let ont00001438 = Prefixed_Name(comcore, "ont00001438") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001439</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000263</para>
    ///
    /// labels<para>"Twenty-Four-Hour Clock Time System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001439">https://www.commoncoreontologies.org/ont00001439</seealso>
    let ont00001439 = Prefixed_Name(comcore, "ont00001439") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001440</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-9"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001440">https://www.commoncoreontologies.org/ont00001440</seealso>
    let ont00001440 = Prefixed_Name(comcore, "ont00001440") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001441</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Rwanda Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001441">https://www.commoncoreontologies.org/ont00001441</seealso>
    let ont00001441 = Prefixed_Name(comcore, "ont00001441") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001442</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001357</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Week Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001442">https://www.commoncoreontologies.org/ont00001442</seealso>
    let ont00001442 = Prefixed_Name(comcore, "ont00001442") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001443</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Albania Lek"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001443">https://www.commoncoreontologies.org/ont00001443</seealso>
    let ont00001443 = Prefixed_Name(comcore, "ont00001443") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001444</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001357</para>
    ///
    /// labels<para>"Year Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001444">https://www.commoncoreontologies.org/ont00001444</seealso>
    let ont00001444 = Prefixed_Name(comcore, "ont00001444") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001445</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Centiliter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001445">https://www.commoncoreontologies.org/ont00001445</seealso>
    let ont00001445 = Prefixed_Name(comcore, "ont00001445") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001446</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Mike Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001446">https://www.commoncoreontologies.org/ont00001446</seealso>
    let ont00001446 = Prefixed_Name(comcore, "ont00001446") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001447</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CFP Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001447">https://www.commoncoreontologies.org/ont00001447</seealso>
    let ont00001447 = Prefixed_Name(comcore, "ont00001447") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001448</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Malawi Kwacha"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001448">https://www.commoncoreontologies.org/ont00001448</seealso>
    let ont00001448 = Prefixed_Name(comcore, "ont00001448") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001449</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Czech Koruna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001449">https://www.commoncoreontologies.org/ont00001449</seealso>
    let ont00001449 = Prefixed_Name(comcore, "ont00001449") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001450</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001004</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Volt Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001450">https://www.commoncoreontologies.org/ont00001450</seealso>
    let ont00001450 = Prefixed_Name(comcore, "ont00001450") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001451</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001004</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Milliampere Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001451">https://www.commoncoreontologies.org/ont00001451</seealso>
    let ont00001451 = Prefixed_Name(comcore, "ont00001451") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001452</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Indian Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001452">https://www.commoncoreontologies.org/ont00001452</seealso>
    let ont00001452 = Prefixed_Name(comcore, "ont00001452") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001453</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000707</para>
    ///
    /// labels<para>"Binary Degree Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001453">https://www.commoncoreontologies.org/ont00001453</seealso>
    let ont00001453 = Prefixed_Name(comcore, "ont00001453") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001454</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lima Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001454">https://www.commoncoreontologies.org/ont00001454</seealso>
    let ont00001454 = Prefixed_Name(comcore, "ont00001454") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001455</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Bolivia Boliviano"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001455">https://www.commoncoreontologies.org/ont00001455</seealso>
    let ont00001455 = Prefixed_Name(comcore, "ont00001455") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001456</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000217</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Square Mile Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001456">https://www.commoncoreontologies.org/ont00001456</seealso>
    let ont00001456 = Prefixed_Name(comcore, "ont00001456") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001457</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Quebec Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001457">https://www.commoncoreontologies.org/ont00001457</seealso>
    let ont00001457 = Prefixed_Name(comcore, "ont00001457") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001458</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Costa Rica Colon"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001458">https://www.commoncoreontologies.org/ont00001458</seealso>
    let ont00001458 = Prefixed_Name(comcore, "ont00001458") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001459</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001307</para>
    ///
    /// labels<para>"Pound Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001459">https://www.commoncoreontologies.org/ont00001459</seealso>
    let ont00001459 = Prefixed_Name(comcore, "ont00001459") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001460</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mauritius Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001460">https://www.commoncoreontologies.org/ont00001460</seealso>
    let ont00001460 = Prefixed_Name(comcore, "ont00001460") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001461</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001328</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Barycentric Dynamical Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001461">https://www.commoncoreontologies.org/ont00001461</seealso>
    let ont00001461 = Prefixed_Name(comcore, "ont00001461") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001462</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Twenty Foot Equivalent Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001462">https://www.commoncoreontologies.org/ont00001462</seealso>
    let ont00001462 = Prefixed_Name(comcore, "ont00001462") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001463</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000140</para>
    ///
    /// labels<para>"Kilomole Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001463">https://www.commoncoreontologies.org/ont00001463</seealso>
    let ont00001463 = Prefixed_Name(comcore, "ont00001463") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001464</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Uzbekistan Sum"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001464">https://www.commoncoreontologies.org/ont00001464</seealso>
    let ont00001464 = Prefixed_Name(comcore, "ont00001464") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001465</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Namibia Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001465">https://www.commoncoreontologies.org/ont00001465</seealso>
    let ont00001465 = Prefixed_Name(comcore, "ont00001465") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001466</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000959</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Revolutions Per Day Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001466">https://www.commoncoreontologies.org/ont00001466</seealso>
    let ont00001466 = Prefixed_Name(comcore, "ont00001466") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001467</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-4"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001467">https://www.commoncoreontologies.org/ont00001467</seealso>
    let ont00001467 = Prefixed_Name(comcore, "ont00001467") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001468</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+10"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001468">https://www.commoncoreontologies.org/ont00001468</seealso>
    let ont00001468 = Prefixed_Name(comcore, "ont00001468") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001469</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilometers Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001469">https://www.commoncoreontologies.org/ont00001469</seealso>
    let ont00001469 = Prefixed_Name(comcore, "ont00001469") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001470</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000959</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Megahertz Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001470">https://www.commoncoreontologies.org/ont00001470</seealso>
    let ont00001470 = Prefixed_Name(comcore, "ont00001470") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001471</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000217</para>
    ///
    /// labels<para>"Square Centimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001471">https://www.commoncoreontologies.org/ont00001471</seealso>
    let ont00001471 = Prefixed_Name(comcore, "ont00001471") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001472</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Millimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001472">https://www.commoncoreontologies.org/ont00001472</seealso>
    let ont00001472 = Prefixed_Name(comcore, "ont00001472") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001473</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Euro"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001473">https://www.commoncoreontologies.org/ont00001473</seealso>
    let ont00001473 = Prefixed_Name(comcore, "ont00001473") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001474</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001090</para>
    ///
    /// labels<para>"Atmosphere Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001474">https://www.commoncoreontologies.org/ont00001474</seealso>
    let ont00001474 = Prefixed_Name(comcore, "ont00001474") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001475</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000959</para>
    ///
    /// labels<para>"Kilohertz Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001475">https://www.commoncoreontologies.org/ont00001475</seealso>
    let ont00001475 = Prefixed_Name(comcore, "ont00001475") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001476</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+4"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001476">https://www.commoncoreontologies.org/ont00001476</seealso>
    let ont00001476 = Prefixed_Name(comcore, "ont00001476") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001477</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000239</para>
    ///
    /// labels<para>"Kilogram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001477">https://www.commoncoreontologies.org/ont00001477</seealso>
    let ont00001477 = Prefixed_Name(comcore, "ont00001477") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001478</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Angstrom Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001478">https://www.commoncoreontologies.org/ont00001478</seealso>
    let ont00001478 = Prefixed_Name(comcore, "ont00001478") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001479</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Angolan Kwanza"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001479">https://www.commoncoreontologies.org/ont00001479</seealso>
    let ont00001479 = Prefixed_Name(comcore, "ont00001479") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001480</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"India Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001480">https://www.commoncoreontologies.org/ont00001480</seealso>
    let ont00001480 = Prefixed_Name(comcore, "ont00001480") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001481</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Macao Pataca"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001481">https://www.commoncoreontologies.org/ont00001481</seealso>
    let ont00001481 = Prefixed_Name(comcore, "ont00001481") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001482</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Algerian Dinar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001482">https://www.commoncoreontologies.org/ont00001482</seealso>
    let ont00001482 = Prefixed_Name(comcore, "ont00001482") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001483</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000140</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mole Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001483">https://www.commoncoreontologies.org/ont00001483</seealso>
    let ont00001483 = Prefixed_Name(comcore, "ont00001483") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001484</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bangladesh Taka"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001484">https://www.commoncoreontologies.org/ont00001484</seealso>
    let ont00001484 = Prefixed_Name(comcore, "ont00001484") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001485</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Surinamese Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001485">https://www.commoncoreontologies.org/ont00001485</seealso>
    let ont00001485 = Prefixed_Name(comcore, "ont00001485") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001486</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000217</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Square Kilometer Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001486">https://www.commoncoreontologies.org/ont00001486</seealso>
    let ont00001486 = Prefixed_Name(comcore, "ont00001486") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001487</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Peru Nuevo Sol"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001487">https://www.commoncoreontologies.org/ont00001487</seealso>
    let ont00001487 = Prefixed_Name(comcore, "ont00001487") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001488</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tango Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001488">https://www.commoncoreontologies.org/ont00001488</seealso>
    let ont00001488 = Prefixed_Name(comcore, "ont00001488") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001489</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000707</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Radian Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001489">https://www.commoncoreontologies.org/ont00001489</seealso>
    let ont00001489 = Prefixed_Name(comcore, "ont00001489") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001490</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bulgarian Lev"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001490">https://www.commoncoreontologies.org/ont00001490</seealso>
    let ont00001490 = Prefixed_Name(comcore, "ont00001490") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001491</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000630</para>
    ///
    /// labels<para>"Universal Time 1 A"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001491">https://www.commoncoreontologies.org/ont00001491</seealso>
    let ont00001491 = Prefixed_Name(comcore, "ont00001491") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001492</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Lebanese Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001492">https://www.commoncoreontologies.org/ont00001492</seealso>
    let ont00001492 = Prefixed_Name(comcore, "ont00001492") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001493</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000497</para>
    ///
    /// labels<para>"Kilonewton Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001493">https://www.commoncoreontologies.org/ont00001493</seealso>
    let ont00001493 = Prefixed_Name(comcore, "ont00001493") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001494</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001290</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yard Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001494">https://www.commoncoreontologies.org/ont00001494</seealso>
    let ont00001494 = Prefixed_Name(comcore, "ont00001494") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001495</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000198</para>
    ///
    /// labels<para>"Sone Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001495">https://www.commoncoreontologies.org/ont00001495</seealso>
    let ont00001495 = Prefixed_Name(comcore, "ont00001495") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001496</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000217</para>
    ///
    /// labels<para>"Square Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001496">https://www.commoncoreontologies.org/ont00001496</seealso>
    let ont00001496 = Prefixed_Name(comcore, "ont00001496") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001497</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kuwaiti Dinar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001497">https://www.commoncoreontologies.org/ont00001497</seealso>
    let ont00001497 = Prefixed_Name(comcore, "ont00001497") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001498</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Fiji Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001498">https://www.commoncoreontologies.org/ont00001498</seealso>
    let ont00001498 = Prefixed_Name(comcore, "ont00001498") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001499</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Kiloliter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001499">https://www.commoncoreontologies.org/ont00001499</seealso>
    let ont00001499 = Prefixed_Name(comcore, "ont00001499") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001500</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Echo Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001500">https://www.commoncoreontologies.org/ont00001500</seealso>
    let ont00001500 = Prefixed_Name(comcore, "ont00001500") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001501</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tanzania Shilling"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001501">https://www.commoncoreontologies.org/ont00001501</seealso>
    let ont00001501 = Prefixed_Name(comcore, "ont00001501") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001502</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000229</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Decibel Isotropic Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001502">https://www.commoncoreontologies.org/ont00001502</seealso>
    let ont00001502 = Prefixed_Name(comcore, "ont00001502") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001503</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Hungary Forint"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001503">https://www.commoncoreontologies.org/ont00001503</seealso>
    let ont00001503 = Prefixed_Name(comcore, "ont00001503") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001504</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000659</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Newton Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001504">https://www.commoncoreontologies.org/ont00001504</seealso>
    let ont00001504 = Prefixed_Name(comcore, "ont00001504") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001505</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Uruguay Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001505">https://www.commoncoreontologies.org/ont00001505</seealso>
    let ont00001505 = Prefixed_Name(comcore, "ont00001505") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001506</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000630</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Universal Time 1 F"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001506">https://www.commoncoreontologies.org/ont00001506</seealso>
    let ont00001506 = Prefixed_Name(comcore, "ont00001506") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001507</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lesotho Loti"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001507">https://www.commoncoreontologies.org/ont00001507</seealso>
    let ont00001507 = Prefixed_Name(comcore, "ont00001507") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001508</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Brunei Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001508">https://www.commoncoreontologies.org/ont00001508</seealso>
    let ont00001508 = Prefixed_Name(comcore, "ont00001508") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001509</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Belarussian Ruble"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001509">https://www.commoncoreontologies.org/ont00001509</seealso>
    let ont00001509 = Prefixed_Name(comcore, "ont00001509") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001510</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Tonga Pa anga"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001510">https://www.commoncoreontologies.org/ont00001510</seealso>
    let ont00001510 = Prefixed_Name(comcore, "ont00001510") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001511</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Meters Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001511">https://www.commoncoreontologies.org/ont00001511</seealso>
    let ont00001511 = Prefixed_Name(comcore, "ont00001511") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"South Sudanese Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001512">https://www.commoncoreontologies.org/ont00001512</seealso>
    let ont00001512 = Prefixed_Name(comcore, "ont00001512") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001513</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Mexican Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001513">https://www.commoncoreontologies.org/ont00001513</seealso>
    let ont00001513 = Prefixed_Name(comcore, "ont00001513") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001514</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Laos Kip"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001514">https://www.commoncoreontologies.org/ont00001514</seealso>
    let ont00001514 = Prefixed_Name(comcore, "ont00001514") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001515</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Liberian Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001515">https://www.commoncoreontologies.org/ont00001515</seealso>
    let ont00001515 = Prefixed_Name(comcore, "ont00001515") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001516</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Oscar Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001516">https://www.commoncoreontologies.org/ont00001516</seealso>
    let ont00001516 = Prefixed_Name(comcore, "ont00001516") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001517</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Nicaragua Cordoba Oro"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001517">https://www.commoncoreontologies.org/ont00001517</seealso>
    let ont00001517 = Prefixed_Name(comcore, "ont00001517") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001518</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Madagascar Malagasy Ariary"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001518">https://www.commoncoreontologies.org/ont00001518</seealso>
    let ont00001518 = Prefixed_Name(comcore, "ont00001518") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001519</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Turkish Lira"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001519">https://www.commoncoreontologies.org/ont00001519</seealso>
    let ont00001519 = Prefixed_Name(comcore, "ont00001519") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001520</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Zambia Kwacha"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001520">https://www.commoncoreontologies.org/ont00001520</seealso>
    let ont00001520 = Prefixed_Name(comcore, "ont00001520") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001521</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Philippine Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001521">https://www.commoncoreontologies.org/ont00001521</seealso>
    let ont00001521 = Prefixed_Name(comcore, "ont00001521") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001522</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000217</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Square Foot Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001522">https://www.commoncoreontologies.org/ont00001522</seealso>
    let ont00001522 = Prefixed_Name(comcore, "ont00001522") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001523</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Pint Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001523">https://www.commoncoreontologies.org/ont00001523</seealso>
    let ont00001523 = Prefixed_Name(comcore, "ont00001523") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-11"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001524">https://www.commoncoreontologies.org/ont00001524</seealso>
    let ont00001524 = Prefixed_Name(comcore, "ont00001524") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001525</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000497</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Newton Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001525">https://www.commoncoreontologies.org/ont00001525</seealso>
    let ont00001525 = Prefixed_Name(comcore, "ont00001525") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001526</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mach Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001526">https://www.commoncoreontologies.org/ont00001526</seealso>
    let ont00001526 = Prefixed_Name(comcore, "ont00001526") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001527</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Hotel Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001527">https://www.commoncoreontologies.org/ont00001527</seealso>
    let ont00001527 = Prefixed_Name(comcore, "ont00001527") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001528</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000940</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilogram Meter Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001528">https://www.commoncoreontologies.org/ont00001528</seealso>
    let ont00001528 = Prefixed_Name(comcore, "ont00001528") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001529</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001328</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Geocentric Coordinate Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001529">https://www.commoncoreontologies.org/ont00001529</seealso>
    let ont00001529 = Prefixed_Name(comcore, "ont00001529") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001530</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000374</para>
    ///
    /// labels<para>"Cubic Meter Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001530">https://www.commoncoreontologies.org/ont00001530</seealso>
    let ont00001530 = Prefixed_Name(comcore, "ont00001530") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001531</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Botswana Pula"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001531">https://www.commoncoreontologies.org/ont00001531</seealso>
    let ont00001531 = Prefixed_Name(comcore, "ont00001531") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001532</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Egyptian Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001532">https://www.commoncoreontologies.org/ont00001532</seealso>
    let ont00001532 = Prefixed_Name(comcore, "ont00001532") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001533</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001357</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hour Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001533">https://www.commoncoreontologies.org/ont00001533</seealso>
    let ont00001533 = Prefixed_Name(comcore, "ont00001533") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001534</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+7"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001534">https://www.commoncoreontologies.org/ont00001534</seealso>
    let ont00001534 = Prefixed_Name(comcore, "ont00001534") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001535</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sudanese Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001535">https://www.commoncoreontologies.org/ont00001535</seealso>
    let ont00001535 = Prefixed_Name(comcore, "ont00001535") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001536</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001357</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001536">https://www.commoncoreontologies.org/ont00001536</seealso>
    let ont00001536 = Prefixed_Name(comcore, "ont00001536") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001537</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000630</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000067</para>
    ///
    /// labels<para>"Coordinated Universal Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001537">https://www.commoncoreontologies.org/ont00001537</seealso>
    let ont00001537 = Prefixed_Name(comcore, "ont00001537") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001538</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000074</para>
    ///
    /// labels<para>"Meters Per Second Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001538">https://www.commoncoreontologies.org/ont00001538</seealso>
    let ont00001538 = Prefixed_Name(comcore, "ont00001538") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001539</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tajikistan Somoni"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001539">https://www.commoncoreontologies.org/ont00001539</seealso>
    let ont00001539 = Prefixed_Name(comcore, "ont00001539") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001540</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Israel Shekel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001540">https://www.commoncoreontologies.org/ont00001540</seealso>
    let ont00001540 = Prefixed_Name(comcore, "ont00001540") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001541</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+12"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001541">https://www.commoncoreontologies.org/ont00001541</seealso>
    let ont00001541 = Prefixed_Name(comcore, "ont00001541") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001542</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Paraguay Guarani"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001542">https://www.commoncoreontologies.org/ont00001542</seealso>
    let ont00001542 = Prefixed_Name(comcore, "ont00001542") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001543</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001290</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Decimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001543">https://www.commoncoreontologies.org/ont00001543</seealso>
    let ont00001543 = Prefixed_Name(comcore, "ont00001543") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001544</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Short Ton Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001544">https://www.commoncoreontologies.org/ont00001544</seealso>
    let ont00001544 = Prefixed_Name(comcore, "ont00001544") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001545</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Swaziland Lilangeni"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001545">https://www.commoncoreontologies.org/ont00001545</seealso>
    let ont00001545 = Prefixed_Name(comcore, "ont00001545") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001546</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Democratic Republic Of Congo Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001546">https://www.commoncoreontologies.org/ont00001546</seealso>
    let ont00001546 = Prefixed_Name(comcore, "ont00001546") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001547</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Syrian Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001547">https://www.commoncoreontologies.org/ont00001547</seealso>
    let ont00001547 = Prefixed_Name(comcore, "ont00001547") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001548</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000630</para>
    ///
    /// labels<para>"Universal Time 1 R"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001548">https://www.commoncoreontologies.org/ont00001548</seealso>
    let ont00001548 = Prefixed_Name(comcore, "ont00001548") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001549</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000497</para>
    ///
    /// labels<para>"Dyne Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001549">https://www.commoncoreontologies.org/ont00001549</seealso>
    let ont00001549 = Prefixed_Name(comcore, "ont00001549") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001550</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000276</para>
    ///
    /// labels<para>"Julian Calendar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001550">https://www.commoncoreontologies.org/ont00001550</seealso>
    let ont00001550 = Prefixed_Name(comcore, "ont00001550") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001551</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Foot Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001551">https://www.commoncoreontologies.org/ont00001551</seealso>
    let ont00001551 = Prefixed_Name(comcore, "ont00001551") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001552</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001552">https://www.commoncoreontologies.org/ont00001552</seealso>
    let ont00001552 = Prefixed_Name(comcore, "ont00001552") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001553</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+6"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001553">https://www.commoncoreontologies.org/ont00001553</seealso>
    let ont00001553 = Prefixed_Name(comcore, "ont00001553") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001554</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT-10"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001554">https://www.commoncoreontologies.org/ont00001554</seealso>
    let ont00001554 = Prefixed_Name(comcore, "ont00001554") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001555</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000659</para>
    ///
    /// labels<para>"Pound Foot Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001555">https://www.commoncoreontologies.org/ont00001555</seealso>
    let ont00001555 = Prefixed_Name(comcore, "ont00001555") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001556</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Samoa Tala"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001556">https://www.commoncoreontologies.org/ont00001556</seealso>
    let ont00001556 = Prefixed_Name(comcore, "ont00001556") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001557</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000527</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pound Foot Second Square Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001557">https://www.commoncoreontologies.org/ont00001557</seealso>
    let ont00001557 = Prefixed_Name(comcore, "ont00001557") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001558</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"New Zealand Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001558">https://www.commoncoreontologies.org/ont00001558</seealso>
    let ont00001558 = Prefixed_Name(comcore, "ont00001558") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001559</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001090</para>
    ///
    /// labels<para>"Pascal Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001559">https://www.commoncoreontologies.org/ont00001559</seealso>
    let ont00001559 = Prefixed_Name(comcore, "ont00001559") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001560</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000444</para>
    ///   <para>comcore:ont00000229</para>
    ///   <para>comcore:ont00000852</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Calorie Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001560">https://www.commoncoreontologies.org/ont00001560</seealso>
    let ont00001560 = Prefixed_Name(comcore, "ont00001560") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001561</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Uganda Shilling"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001561">https://www.commoncoreontologies.org/ont00001561</seealso>
    let ont00001561 = Prefixed_Name(comcore, "ont00001561") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001562</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cambodian Riel"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001562">https://www.commoncoreontologies.org/ont00001562</seealso>
    let ont00001562 = Prefixed_Name(comcore, "ont00001562") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001563</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000444</para>
    ///   <para>comcore:ont00000852</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000229</para>
    ///
    /// labels<para>"Horsepower Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001563">https://www.commoncoreontologies.org/ont00001563</seealso>
    let ont00001563 = Prefixed_Name(comcore, "ont00001563") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001564</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000239</para>
    ///
    /// labels<para>"Decigram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001564">https://www.commoncoreontologies.org/ont00001564</seealso>
    let ont00001564 = Prefixed_Name(comcore, "ont00001564") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-5"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001565">https://www.commoncoreontologies.org/ont00001565</seealso>
    let ont00001565 = Prefixed_Name(comcore, "ont00001565") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001566</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000229</para>
    ///
    /// labels<para>"Watt Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001566">https://www.commoncoreontologies.org/ont00001566</seealso>
    let ont00001566 = Prefixed_Name(comcore, "ont00001566") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001567</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ounce Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001567">https://www.commoncoreontologies.org/ont00001567</seealso>
    let ont00001567 = Prefixed_Name(comcore, "ont00001567") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001568</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000770</para>
    ///
    /// labels<para>"Gram Per Cubic Centimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001568">https://www.commoncoreontologies.org/ont00001568</seealso>
    let ont00001568 = Prefixed_Name(comcore, "ont00001568") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001569</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000770</para>
    ///
    /// labels<para>"Kilogram Per Cubic Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001569">https://www.commoncoreontologies.org/ont00001569</seealso>
    let ont00001569 = Prefixed_Name(comcore, "ont00001569") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001570</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+2"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001570">https://www.commoncoreontologies.org/ont00001570</seealso>
    let ont00001570 = Prefixed_Name(comcore, "ont00001570") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001571</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001357</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Day Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001571">https://www.commoncoreontologies.org/ont00001571</seealso>
    let ont00001571 = Prefixed_Name(comcore, "ont00001571") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001572</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000844</para>
    ///
    /// labels<para>"Kelvin Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001572">https://www.commoncoreontologies.org/ont00001572</seealso>
    let ont00001572 = Prefixed_Name(comcore, "ont00001572") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001573</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Teaspoon Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001573">https://www.commoncoreontologies.org/ont00001573</seealso>
    let ont00001573 = Prefixed_Name(comcore, "ont00001573") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001574</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000959</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Revolutions Per Minute Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001574">https://www.commoncoreontologies.org/ont00001574</seealso>
    let ont00001574 = Prefixed_Name(comcore, "ont00001574") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001575</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CFA Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001575">https://www.commoncoreontologies.org/ont00001575</seealso>
    let ont00001575 = Prefixed_Name(comcore, "ont00001575") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001576</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Milliliter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001576">https://www.commoncoreontologies.org/ont00001576</seealso>
    let ont00001576 = Prefixed_Name(comcore, "ont00001576") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001577</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Ukraine Hryvnia"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001577">https://www.commoncoreontologies.org/ont00001577</seealso>
    let ont00001577 = Prefixed_Name(comcore, "ont00001577") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001578</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Nepalese Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001578">https://www.commoncoreontologies.org/ont00001578</seealso>
    let ont00001578 = Prefixed_Name(comcore, "ont00001578") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001579</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000374</para>
    ///
    /// labels<para>"Liter Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001579">https://www.commoncoreontologies.org/ont00001579</seealso>
    let ont00001579 = Prefixed_Name(comcore, "ont00001579") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001580</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Papa Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001580">https://www.commoncoreontologies.org/ont00001580</seealso>
    let ont00001580 = Prefixed_Name(comcore, "ont00001580") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001581</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///
    /// labels<para>"International Terrestrial Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001581">https://www.commoncoreontologies.org/ont00001581</seealso>
    let ont00001581 = Prefixed_Name(comcore, "ont00001581") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001582</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///
    /// labels<para>"Universal Transverse Mercator Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001582">https://www.commoncoreontologies.org/ont00001582</seealso>
    let ont00001582 = Prefixed_Name(comcore, "ont00001582") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001583</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Feet Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001583">https://www.commoncoreontologies.org/ont00001583</seealso>
    let ont00001583 = Prefixed_Name(comcore, "ont00001583") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001584</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///
    /// labels<para>"World Geographic Reference System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001584">https://www.commoncoreontologies.org/ont00001584</seealso>
    let ont00001584 = Prefixed_Name(comcore, "ont00001584") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001585</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000940</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Newton Second Per Kilogram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001585">https://www.commoncoreontologies.org/ont00001585</seealso>
    let ont00001585 = Prefixed_Name(comcore, "ont00001585") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001586</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Poland Zloty"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001586">https://www.commoncoreontologies.org/ont00001586</seealso>
    let ont00001586 = Prefixed_Name(comcore, "ont00001586") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001587</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001090</para>
    ///
    /// labels<para>"Bayre Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001587">https://www.commoncoreontologies.org/ont00001587</seealso>
    let ont00001587 = Prefixed_Name(comcore, "ont00001587") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001588</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+9"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001588">https://www.commoncoreontologies.org/ont00001588</seealso>
    let ont00001588 = Prefixed_Name(comcore, "ont00001588") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001589</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Inch Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001589">https://www.commoncoreontologies.org/ont00001589</seealso>
    let ont00001589 = Prefixed_Name(comcore, "ont00001589") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001590</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001328</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"International Atomic Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001590">https://www.commoncoreontologies.org/ont00001590</seealso>
    let ont00001590 = Prefixed_Name(comcore, "ont00001590") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001591</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Uniform Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001591">https://www.commoncoreontologies.org/ont00001591</seealso>
    let ont00001591 = Prefixed_Name(comcore, "ont00001591") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001592</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Kazakhstan Tenge"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001592">https://www.commoncoreontologies.org/ont00001592</seealso>
    let ont00001592 = Prefixed_Name(comcore, "ont00001592") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001593</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ethiopian Birr"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001593">https://www.commoncoreontologies.org/ont00001593</seealso>
    let ont00001593 = Prefixed_Name(comcore, "ont00001593") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001594</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"North Korean Won"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001594">https://www.commoncoreontologies.org/ont00001594</seealso>
    let ont00001594 = Prefixed_Name(comcore, "ont00001594") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001595</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Swedish Krona"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001595">https://www.commoncoreontologies.org/ont00001595</seealso>
    let ont00001595 = Prefixed_Name(comcore, "ont00001595") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001596</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001307</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilogram Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001596">https://www.commoncoreontologies.org/ont00001596</seealso>
    let ont00001596 = Prefixed_Name(comcore, "ont00001596") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001597</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+11"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001597">https://www.commoncoreontologies.org/ont00001597</seealso>
    let ont00001597 = Prefixed_Name(comcore, "ont00001597") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001598</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001290</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilometer Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001598">https://www.commoncoreontologies.org/ont00001598</seealso>
    let ont00001598 = Prefixed_Name(comcore, "ont00001598") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001599</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+3:30"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001599">https://www.commoncoreontologies.org/ont00001599</seealso>
    let ont00001599 = Prefixed_Name(comcore, "ont00001599") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001600</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guinean Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001600">https://www.commoncoreontologies.org/ont00001600</seealso>
    let ont00001600 = Prefixed_Name(comcore, "ont00001600") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001601</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"United Kingdom Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001601">https://www.commoncoreontologies.org/ont00001601</seealso>
    let ont00001601 = Prefixed_Name(comcore, "ont00001601") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001602</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000969</para>
    ///
    /// labels<para>"Miles Per Hour Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001602">https://www.commoncoreontologies.org/ont00001602</seealso>
    let ont00001602 = Prefixed_Name(comcore, "ont00001602") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001603</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"November Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001603">https://www.commoncoreontologies.org/ont00001603</seealso>
    let ont00001603 = Prefixed_Name(comcore, "ont00001603") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001604</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000707</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Degree Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001604">https://www.commoncoreontologies.org/ont00001604</seealso>
    let ont00001604 = Prefixed_Name(comcore, "ont00001604") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001605</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Argentine Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001605">https://www.commoncoreontologies.org/ont00001605</seealso>
    let ont00001605 = Prefixed_Name(comcore, "ont00001605") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001606</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000844</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Degree Celsius Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001606">https://www.commoncoreontologies.org/ont00001606</seealso>
    let ont00001606 = Prefixed_Name(comcore, "ont00001606") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001607</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Victor Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001607">https://www.commoncoreontologies.org/ont00001607</seealso>
    let ont00001607 = Prefixed_Name(comcore, "ont00001607") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000140</para>
    ///
    /// labels<para>"Pound-Mole Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001608">https://www.commoncoreontologies.org/ont00001608</seealso>
    let ont00001608 = Prefixed_Name(comcore, "ont00001608") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001609</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000707</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gradian Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001609">https://www.commoncoreontologies.org/ont00001609</seealso>
    let ont00001609 = Prefixed_Name(comcore, "ont00001609") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001610</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thai Baht"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001610">https://www.commoncoreontologies.org/ont00001610</seealso>
    let ont00001610 = Prefixed_Name(comcore, "ont00001610") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Gallon Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001611">https://www.commoncoreontologies.org/ont00001611</seealso>
    let ont00001611 = Prefixed_Name(comcore, "ont00001611") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001612</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001090</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bar Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001612">https://www.commoncoreontologies.org/ont00001612</seealso>
    let ont00001612 = Prefixed_Name(comcore, "ont00001612") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001613</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001004</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilovolt Ampere Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001613">https://www.commoncoreontologies.org/ont00001613</seealso>
    let ont00001613 = Prefixed_Name(comcore, "ont00001613") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001614</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Moldovan Leu"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001614">https://www.commoncoreontologies.org/ont00001614</seealso>
    let ont00001614 = Prefixed_Name(comcore, "ont00001614") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001615</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-7"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001615">https://www.commoncoreontologies.org/ont00001615</seealso>
    let ont00001615 = Prefixed_Name(comcore, "ont00001615") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001616</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gambian Dalasi"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001616">https://www.commoncoreontologies.org/ont00001616</seealso>
    let ont00001616 = Prefixed_Name(comcore, "ont00001616") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001617</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Nigeria Naira"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001617">https://www.commoncoreontologies.org/ont00001617</seealso>
    let ont00001617 = Prefixed_Name(comcore, "ont00001617") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001618</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United States Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001618">https://www.commoncoreontologies.org/ont00001618</seealso>
    let ont00001618 = Prefixed_Name(comcore, "ont00001618") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001619</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Solomon Island Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001619">https://www.commoncoreontologies.org/ont00001619</seealso>
    let ont00001619 = Prefixed_Name(comcore, "ont00001619") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001620</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Macedonian Denar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001620">https://www.commoncoreontologies.org/ont00001620</seealso>
    let ont00001620 = Prefixed_Name(comcore, "ont00001620") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Pakistani Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001621">https://www.commoncoreontologies.org/ont00001621</seealso>
    let ont00001621 = Prefixed_Name(comcore, "ont00001621") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001622</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Armenian Dram"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001622">https://www.commoncoreontologies.org/ont00001622</seealso>
    let ont00001622 = Prefixed_Name(comcore, "ont00001622") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001623</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Romanian Leu"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001623">https://www.commoncoreontologies.org/ont00001623</seealso>
    let ont00001623 = Prefixed_Name(comcore, "ont00001623") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Golf Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001624">https://www.commoncoreontologies.org/ont00001624</seealso>
    let ont00001624 = Prefixed_Name(comcore, "ont00001624") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000630</para>
    ///
    /// labels<para>"Universal Time 0"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001625">https://www.commoncoreontologies.org/ont00001625</seealso>
    let ont00001625 = Prefixed_Name(comcore, "ont00001625") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001626</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000263</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Twelve-Hour Clock Time System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001626">https://www.commoncoreontologies.org/ont00001626</seealso>
    let ont00001626 = Prefixed_Name(comcore, "ont00001626") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001627</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HongKong Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001627">https://www.commoncoreontologies.org/ont00001627</seealso>
    let ont00001627 = Prefixed_Name(comcore, "ont00001627") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001628</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yankee Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001628">https://www.commoncoreontologies.org/ont00001628</seealso>
    let ont00001628 = Prefixed_Name(comcore, "ont00001628") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001629</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Nautical Mile Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001629">https://www.commoncoreontologies.org/ont00001629</seealso>
    let ont00001629 = Prefixed_Name(comcore, "ont00001629") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001630</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000469</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"World Geodetic System 1984"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001630">https://www.commoncoreontologies.org/ont00001630</seealso>
    let ont00001630 = Prefixed_Name(comcore, "ont00001630") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001631</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Seychelles Rupee"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001631">https://www.commoncoreontologies.org/ont00001631</seealso>
    let ont00001631 = Prefixed_Name(comcore, "ont00001631") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001632</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Korean Won"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001632">https://www.commoncoreontologies.org/ont00001632</seealso>
    let ont00001632 = Prefixed_Name(comcore, "ont00001632") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001633</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Vanuatu Vatu"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001633">https://www.commoncoreontologies.org/ont00001633</seealso>
    let ont00001633 = Prefixed_Name(comcore, "ont00001633") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001634</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-1"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001634">https://www.commoncoreontologies.org/ont00001634</seealso>
    let ont00001634 = Prefixed_Name(comcore, "ont00001634") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001635</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bosnia And Herzegovina Convertible Mark"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001635">https://www.commoncoreontologies.org/ont00001635</seealso>
    let ont00001635 = Prefixed_Name(comcore, "ont00001635") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001636</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000198</para>
    ///
    /// labels<para>"Phon Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001636">https://www.commoncoreontologies.org/ont00001636</seealso>
    let ont00001636 = Prefixed_Name(comcore, "ont00001636") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001637</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001290</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Nanometer Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001637">https://www.commoncoreontologies.org/ont00001637</seealso>
    let ont00001637 = Prefixed_Name(comcore, "ont00001637") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Comoros Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001638">https://www.commoncoreontologies.org/ont00001638</seealso>
    let ont00001638 = Prefixed_Name(comcore, "ont00001638") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001639</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Indonesia Rupiah"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001639">https://www.commoncoreontologies.org/ont00001639</seealso>
    let ont00001639 = Prefixed_Name(comcore, "ont00001639") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001640</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Myanmar Kyat"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001640">https://www.commoncoreontologies.org/ont00001640</seealso>
    let ont00001640 = Prefixed_Name(comcore, "ont00001640") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001641</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000527</para>
    ///
    /// labels<para>"Kilogram Meter Square Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001641">https://www.commoncoreontologies.org/ont00001641</seealso>
    let ont00001641 = Prefixed_Name(comcore, "ont00001641") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001642</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Millimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001642">https://www.commoncoreontologies.org/ont00001642</seealso>
    let ont00001642 = Prefixed_Name(comcore, "ont00001642") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001643</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001090</para>
    ///
    /// labels<para>"Millibar Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001643">https://www.commoncoreontologies.org/ont00001643</seealso>
    let ont00001643 = Prefixed_Name(comcore, "ont00001643") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001644</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000374</para>
    ///
    /// labels<para>"Cubic Feet Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001644">https://www.commoncoreontologies.org/ont00001644</seealso>
    let ont00001644 = Prefixed_Name(comcore, "ont00001644") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001645</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000217</para>
    ///
    /// labels<para>"Square Inch Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001645">https://www.commoncoreontologies.org/ont00001645</seealso>
    let ont00001645 = Prefixed_Name(comcore, "ont00001645") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001646</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000969</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Knot Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001646">https://www.commoncoreontologies.org/ont00001646</seealso>
    let ont00001646 = Prefixed_Name(comcore, "ont00001646") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001647</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000074</para>
    ///
    /// labels<para>"Feet Per Second Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001647">https://www.commoncoreontologies.org/ont00001647</seealso>
    let ont00001647 = Prefixed_Name(comcore, "ont00001647") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001648</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///   <para>comcore:ont00001351</para>
    ///
    /// labels<para>"Earth-Centered Earth-Fixed Coordinate System"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001648">https://www.commoncoreontologies.org/ont00001648</seealso>
    let ont00001648 = Prefixed_Name(comcore, "ont00001648") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001649</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Mongolia Tugrik"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001649">https://www.commoncoreontologies.org/ont00001649</seealso>
    let ont00001649 = Prefixed_Name(comcore, "ont00001649") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001650</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tunisian Dinar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001650">https://www.commoncoreontologies.org/ont00001650</seealso>
    let ont00001650 = Prefixed_Name(comcore, "ont00001650") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001651</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001307</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gram Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001651">https://www.commoncoreontologies.org/ont00001651</seealso>
    let ont00001651 = Prefixed_Name(comcore, "ont00001651") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001652</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Russian Rouble"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001652">https://www.commoncoreontologies.org/ont00001652</seealso>
    let ont00001652 = Prefixed_Name(comcore, "ont00001652") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001653</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000852</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000444</para>
    ///   <para>comcore:ont00000229</para>
    ///
    /// labels<para>"Joule Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001653">https://www.commoncoreontologies.org/ont00001653</seealso>
    let ont00001653 = Prefixed_Name(comcore, "ont00001653") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001654</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Iranian Rial"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001654">https://www.commoncoreontologies.org/ont00001654</seealso>
    let ont00001654 = Prefixed_Name(comcore, "ont00001654") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001655</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cape Verde Escudo"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001655">https://www.commoncoreontologies.org/ont00001655</seealso>
    let ont00001655 = Prefixed_Name(comcore, "ont00001655") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001656</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001345</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Newton Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001656">https://www.commoncoreontologies.org/ont00001656</seealso>
    let ont00001656 = Prefixed_Name(comcore, "ont00001656") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001657</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Trinidad and Tobago Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001657">https://www.commoncoreontologies.org/ont00001657</seealso>
    let ont00001657 = Prefixed_Name(comcore, "ont00001657") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001658</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001328</para>
    ///
    /// labels<para>"Jet Propulsion Laboratory Ephemeris Time Argument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001658">https://www.commoncoreontologies.org/ont00001658</seealso>
    let ont00001658 = Prefixed_Name(comcore, "ont00001658") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001659</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000707</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Turn Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001659">https://www.commoncoreontologies.org/ont00001659</seealso>
    let ont00001659 = Prefixed_Name(comcore, "ont00001659") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001660</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000469</para>
    ///
    /// labels<para>"International Geomagnetic Reference Field"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001660">https://www.commoncoreontologies.org/ont00001660</seealso>
    let ont00001660 = Prefixed_Name(comcore, "ont00001660") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001661</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+8"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001661">https://www.commoncoreontologies.org/ont00001661</seealso>
    let ont00001661 = Prefixed_Name(comcore, "ont00001661") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001662</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mozambique Metical"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001662">https://www.commoncoreontologies.org/ont00001662</seealso>
    let ont00001662 = Prefixed_Name(comcore, "ont00001662") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001663</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001663">https://www.commoncoreontologies.org/ont00001663</seealso>
    let ont00001663 = Prefixed_Name(comcore, "ont00001663") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001664</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000198</para>
    ///
    /// labels<para>"Decibel Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001664">https://www.commoncoreontologies.org/ont00001664</seealso>
    let ont00001664 = Prefixed_Name(comcore, "ont00001664") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001665</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Georgian Lari"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001665">https://www.commoncoreontologies.org/ont00001665</seealso>
    let ont00001665 = Prefixed_Name(comcore, "ont00001665") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001666</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001328</para>
    ///
    /// labels<para>"Barycentric Coordinate Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001666">https://www.commoncoreontologies.org/ont00001666</seealso>
    let ont00001666 = Prefixed_Name(comcore, "ont00001666") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001667</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001357</para>
    ///
    /// labels<para>"Minute Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001667">https://www.commoncoreontologies.org/ont00001667</seealso>
    let ont00001667 = Prefixed_Name(comcore, "ont00001667") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001668</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Sierra Leone Leone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001668">https://www.commoncoreontologies.org/ont00001668</seealso>
    let ont00001668 = Prefixed_Name(comcore, "ont00001668") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001669</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000959</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gigahertz Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001669">https://www.commoncoreontologies.org/ont00001669</seealso>
    let ont00001669 = Prefixed_Name(comcore, "ont00001669") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001670</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Malaysia Ringgit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001670">https://www.commoncoreontologies.org/ont00001670</seealso>
    let ont00001670 = Prefixed_Name(comcore, "ont00001670") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001671</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Azerbaijan Manat"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001671">https://www.commoncoreontologies.org/ont00001671</seealso>
    let ont00001671 = Prefixed_Name(comcore, "ont00001671") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001672</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000217</para>
    ///
    /// labels<para>"Square Decimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001672">https://www.commoncoreontologies.org/ont00001672</seealso>
    let ont00001672 = Prefixed_Name(comcore, "ont00001672") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001673</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Japanese Yen"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001673">https://www.commoncoreontologies.org/ont00001673</seealso>
    let ont00001673 = Prefixed_Name(comcore, "ont00001673") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000276</para>
    ///
    /// labels<para>"Gregorian Calendar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001674">https://www.commoncoreontologies.org/ont00001674</seealso>
    let ont00001674 = Prefixed_Name(comcore, "ont00001674") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001675</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000940</para>
    ///
    /// labels<para>"Slug Foot Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001675">https://www.commoncoreontologies.org/ont00001675</seealso>
    let ont00001675 = Prefixed_Name(comcore, "ont00001675") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001676</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Metric Ton Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001676">https://www.commoncoreontologies.org/ont00001676</seealso>
    let ont00001676 = Prefixed_Name(comcore, "ont00001676") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001677</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Inch Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001677">https://www.commoncoreontologies.org/ont00001677</seealso>
    let ont00001677 = Prefixed_Name(comcore, "ont00001677") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001678</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001317</para>
    ///
    /// labels<para>"Cubic Decimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001678">https://www.commoncoreontologies.org/ont00001678</seealso>
    let ont00001678 = Prefixed_Name(comcore, "ont00001678") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001679</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"St Helena Pound"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001679">https://www.commoncoreontologies.org/ont00001679</seealso>
    let ont00001679 = Prefixed_Name(comcore, "ont00001679") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001680</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000074</para>
    ///
    /// labels<para>"Miles Per Second Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001680">https://www.commoncoreontologies.org/ont00001680</seealso>
    let ont00001680 = Prefixed_Name(comcore, "ont00001680") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001681</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000374</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gallon Per Minute Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001681">https://www.commoncoreontologies.org/ont00001681</seealso>
    let ont00001681 = Prefixed_Name(comcore, "ont00001681") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001682</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000497</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kilopond Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001682">https://www.commoncoreontologies.org/ont00001682</seealso>
    let ont00001682 = Prefixed_Name(comcore, "ont00001682") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001683</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001683">https://www.commoncoreontologies.org/ont00001683</seealso>
    let ont00001683 = Prefixed_Name(comcore, "ont00001683") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001684</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Burundi Franc"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001684">https://www.commoncoreontologies.org/ont00001684</seealso>
    let ont00001684 = Prefixed_Name(comcore, "ont00001684") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001685</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000707</para>
    ///
    /// labels<para>"Second of Arc Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001685">https://www.commoncoreontologies.org/ont00001685</seealso>
    let ont00001685 = Prefixed_Name(comcore, "ont00001685") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001686</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000374</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Standard Cubic Centimeter Per Minute Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001686">https://www.commoncoreontologies.org/ont00001686</seealso>
    let ont00001686 = Prefixed_Name(comcore, "ont00001686") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001687</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001317</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cubic Yard Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001687">https://www.commoncoreontologies.org/ont00001687</seealso>
    let ont00001687 = Prefixed_Name(comcore, "ont00001687") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001688</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sao Tome Principe Dobra"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001688">https://www.commoncoreontologies.org/ont00001688</seealso>
    let ont00001688 = Prefixed_Name(comcore, "ont00001688") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001689</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000852</para>
    ///   <para>comcore:ont00000444</para>
    ///   <para>comcore:ont00000229</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"British Thermal Unit Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001689">https://www.commoncoreontologies.org/ont00001689</seealso>
    let ont00001689 = Prefixed_Name(comcore, "ont00001689") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001690</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Turkmenistan Manat"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001690">https://www.commoncoreontologies.org/ont00001690</seealso>
    let ont00001690 = Prefixed_Name(comcore, "ont00001690") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001691</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT-6"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001691">https://www.commoncoreontologies.org/ont00001691</seealso>
    let ont00001691 = Prefixed_Name(comcore, "ont00001691") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001692</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001328</para>
    ///
    /// labels<para>"Unix Time"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001692">https://www.commoncoreontologies.org/ont00001692</seealso>
    let ont00001692 = Prefixed_Name(comcore, "ont00001692") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001693</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Zulu Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001693">https://www.commoncoreontologies.org/ont00001693</seealso>
    let ont00001693 = Prefixed_Name(comcore, "ont00001693") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001694</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001090</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pounds Per Square Inch Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001694">https://www.commoncoreontologies.org/ont00001694</seealso>
    let ont00001694 = Prefixed_Name(comcore, "ont00001694") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001695</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000630</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Universal Time 2"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001695">https://www.commoncoreontologies.org/ont00001695</seealso>
    let ont00001695 = Prefixed_Name(comcore, "ont00001695") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001696</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000239</para>
    ///
    /// labels<para>"Centigram Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001696">https://www.commoncoreontologies.org/ont00001696</seealso>
    let ont00001696 = Prefixed_Name(comcore, "ont00001696") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001697</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000074</para>
    ///
    /// labels<para>"Kilometers Per Second Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001697">https://www.commoncoreontologies.org/ont00001697</seealso>
    let ont00001697 = Prefixed_Name(comcore, "ont00001697") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001698</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000239</para>
    ///
    /// labels<para>"Long Ton Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001698">https://www.commoncoreontologies.org/ont00001698</seealso>
    let ont00001698 = Prefixed_Name(comcore, "ont00001698") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001699</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Morocco Dirham"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001699">https://www.commoncoreontologies.org/ont00001699</seealso>
    let ont00001699 = Prefixed_Name(comcore, "ont00001699") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001700</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Juliet Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001700">https://www.commoncoreontologies.org/ont00001700</seealso>
    let ont00001700 = Prefixed_Name(comcore, "ont00001700") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001701</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT-3"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001701">https://www.commoncoreontologies.org/ont00001701</seealso>
    let ont00001701 = Prefixed_Name(comcore, "ont00001701") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001702</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001352</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GMT+5:30"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001702">https://www.commoncoreontologies.org/ont00001702</seealso>
    let ont00001702 = Prefixed_Name(comcore, "ont00001702") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001703</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Brazilian Real"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001703">https://www.commoncoreontologies.org/ont00001703</seealso>
    let ont00001703 = Prefixed_Name(comcore, "ont00001703") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001704</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001352</para>
    ///
    /// labels<para>"GMT+3"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001704">https://www.commoncoreontologies.org/ont00001704</seealso>
    let ont00001704 = Prefixed_Name(comcore, "ont00001704") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001705</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chilean Peso"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001705">https://www.commoncoreontologies.org/ont00001705</seealso>
    let ont00001705 = Prefixed_Name(comcore, "ont00001705") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001706</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000217</para>
    ///
    /// labels<para>"Acre Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001706">https://www.commoncoreontologies.org/ont00001706</seealso>
    let ont00001706 = Prefixed_Name(comcore, "ont00001706") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001707</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001357</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Month Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001707">https://www.commoncoreontologies.org/ont00001707</seealso>
    let ont00001707 = Prefixed_Name(comcore, "ont00001707") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001708</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Serbian Dinar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001708">https://www.commoncoreontologies.org/ont00001708</seealso>
    let ont00001708 = Prefixed_Name(comcore, "ont00001708") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001709</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000502</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Quartic Meter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001709">https://www.commoncoreontologies.org/ont00001709</seealso>
    let ont00001709 = Prefixed_Name(comcore, "ont00001709") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001710</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Danish Krone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001710">https://www.commoncoreontologies.org/ont00001710</seealso>
    let ont00001710 = Prefixed_Name(comcore, "ont00001710") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001711</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001345</para>
    ///
    /// labels<para>"Dyne Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001711">https://www.commoncoreontologies.org/ont00001711</seealso>
    let ont00001711 = Prefixed_Name(comcore, "ont00001711") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001712</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Romeo Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001712">https://www.commoncoreontologies.org/ont00001712</seealso>
    let ont00001712 = Prefixed_Name(comcore, "ont00001712") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001713</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000217</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Square Millimeter Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001713">https://www.commoncoreontologies.org/ont00001713</seealso>
    let ont00001713 = Prefixed_Name(comcore, "ont00001713") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001714</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001290</para>
    ///
    /// labels<para>"Foot Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001714">https://www.commoncoreontologies.org/ont00001714</seealso>
    let ont00001714 = Prefixed_Name(comcore, "ont00001714") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001715</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000959</para>
    ///
    /// labels<para>"Terahertz Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001715">https://www.commoncoreontologies.org/ont00001715</seealso>
    let ont00001715 = Prefixed_Name(comcore, "ont00001715") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001716</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000630</para>
    ///
    /// labels<para>"Universal Time 1"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001716">https://www.commoncoreontologies.org/ont00001716</seealso>
    let ont00001716 = Prefixed_Name(comcore, "ont00001716") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001717</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Croatia Kuna"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001717">https://www.commoncoreontologies.org/ont00001717</seealso>
    let ont00001717 = Prefixed_Name(comcore, "ont00001717") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001718</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Honduras Lempira"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001718">https://www.commoncoreontologies.org/ont00001718</seealso>
    let ont00001718 = Prefixed_Name(comcore, "ont00001718") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001719</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kyrgyzstan Som"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001719">https://www.commoncoreontologies.org/ont00001719</seealso>
    let ont00001719 = Prefixed_Name(comcore, "ont00001719") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001720</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guatemala Quetzal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001720">https://www.commoncoreontologies.org/ont00001720</seealso>
    let ont00001720 = Prefixed_Name(comcore, "ont00001720") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001721</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000518</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Libyan Dinar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001721">https://www.commoncoreontologies.org/ont00001721</seealso>
    let ont00001721 = Prefixed_Name(comcore, "ont00001721") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001722</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Bhutan Ngultrum"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001722">https://www.commoncoreontologies.org/ont00001722</seealso>
    let ont00001722 = Prefixed_Name(comcore, "ont00001722") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001723</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Delta Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001723">https://www.commoncoreontologies.org/ont00001723</seealso>
    let ont00001723 = Prefixed_Name(comcore, "ont00001723") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001724</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000844</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Degree Fahrenheit Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001724">https://www.commoncoreontologies.org/ont00001724</seealso>
    let ont00001724 = Prefixed_Name(comcore, "ont00001724") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001725</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Iceland Krona"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001725">https://www.commoncoreontologies.org/ont00001725</seealso>
    let ont00001725 = Prefixed_Name(comcore, "ont00001725") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001726</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Norwegian Krone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001726">https://www.commoncoreontologies.org/ont00001726</seealso>
    let ont00001726 = Prefixed_Name(comcore, "ont00001726") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001727</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001235</para>
    ///
    /// labels<para>"Kilo Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001727">https://www.commoncoreontologies.org/ont00001727</seealso>
    let ont00001727 = Prefixed_Name(comcore, "ont00001727") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001728</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000239</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pound Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001728">https://www.commoncoreontologies.org/ont00001728</seealso>
    let ont00001728 = Prefixed_Name(comcore, "ont00001728") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001729</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001004</para>
    ///
    /// labels<para>"Volt Ampere Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001729">https://www.commoncoreontologies.org/ont00001729</seealso>
    let ont00001729 = Prefixed_Name(comcore, "ont00001729") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001730</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00000959</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hertz Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001730">https://www.commoncoreontologies.org/ont00001730</seealso>
    let ont00001730 = Prefixed_Name(comcore, "ont00001730") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001731</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Jamaican Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001731">https://www.commoncoreontologies.org/ont00001731</seealso>
    let ont00001731 = Prefixed_Name(comcore, "ont00001731") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001732</para>
    /// </summary>
    /// <remarks>
    ///   <para>comcore:ont00001235</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Charlie Time Zone"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001732">https://www.commoncoreontologies.org/ont00001732</seealso>
    let ont00001732 = Prefixed_Name(comcore, "ont00001732") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001733</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00001307</para>
    ///
    /// labels<para>"Slug Per Second Measurement Unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001733">https://www.commoncoreontologies.org/ont00001733</seealso>
    let ont00001733 = Prefixed_Name(comcore, "ont00001733") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001734</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>comcore:ont00000518</para>
    ///
    /// labels<para>"Australian Dollar"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001734">https://www.commoncoreontologies.org/ont00001734</seealso>
    let ont00001734 = Prefixed_Name(comcore, "ont00001734") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001735</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"query text"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001735">https://www.commoncoreontologies.org/ont00001735</seealso>
    let ont00001735 = Prefixed_Name(comcore, "ont00001735") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001737</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"doctrinal definition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001737">https://www.commoncoreontologies.org/ont00001737</seealso>
    let ont00001737 = Prefixed_Name(comcore, "ont00001737") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001738</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"SI unit label"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001738">https://www.commoncoreontologies.org/ont00001738</seealso>
    let ont00001738 = Prefixed_Name(comcore, "ont00001738") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001739</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"ordinal measurement annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001739">https://www.commoncoreontologies.org/ont00001739</seealso>
    let ont00001739 = Prefixed_Name(comcore, "ont00001739") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001740</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"SI unit symbol"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001740">https://www.commoncoreontologies.org/ont00001740</seealso>
    let ont00001740 = Prefixed_Name(comcore, "ont00001740") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001741</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"nominal measurement annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001741">https://www.commoncoreontologies.org/ont00001741</seealso>
    let ont00001741 = Prefixed_Name(comcore, "ont00001741") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001742</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"term creator"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001742">https://www.commoncoreontologies.org/ont00001742</seealso>
    let ont00001742 = Prefixed_Name(comcore, "ont00001742") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001743</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"content license"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001743">https://www.commoncoreontologies.org/ont00001743</seealso>
    let ont00001743 = Prefixed_Name(comcore, "ont00001743") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001744</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"copyright"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001744">https://www.commoncoreontologies.org/ont00001744</seealso>
    let ont00001744 = Prefixed_Name(comcore, "ont00001744") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001745</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"doctrinal source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001745">https://www.commoncoreontologies.org/ont00001745</seealso>
    let ont00001745 = Prefixed_Name(comcore, "ont00001745") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001746</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"measurement annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001746">https://www.commoncoreontologies.org/ont00001746</seealso>
    let ont00001746 = Prefixed_Name(comcore, "ont00001746") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001747</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"ratio measurement annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001747">https://www.commoncoreontologies.org/ont00001747</seealso>
    let ont00001747 = Prefixed_Name(comcore, "ont00001747") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001748</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"doctrinal label"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001748">https://www.commoncoreontologies.org/ont00001748</seealso>
    let ont00001748 = Prefixed_Name(comcore, "ont00001748") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001749</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"doctrinal acronym"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001749">https://www.commoncoreontologies.org/ont00001749</seealso>
    let ont00001749 = Prefixed_Name(comcore, "ont00001749") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001752</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has token unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001752">https://www.commoncoreontologies.org/ont00001752</seealso>
    let ont00001752 = Prefixed_Name(comcore, "ont00001752") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001753</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"acronym"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001753">https://www.commoncoreontologies.org/ont00001753</seealso>
    let ont00001753 = Prefixed_Name(comcore, "ont00001753") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001754</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"definition source"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001754">https://www.commoncoreontologies.org/ont00001754</seealso>
    let ont00001754 = Prefixed_Name(comcore, "ont00001754") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001756</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"interval measurement annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001756">https://www.commoncoreontologies.org/ont00001756</seealso>
    let ont00001756 = Prefixed_Name(comcore, "ont00001756") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001757</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"designator annotation"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001757">https://www.commoncoreontologies.org/ont00001757</seealso>
    let ont00001757 = Prefixed_Name(comcore, "ont00001757") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001758</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"http query string"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001758">https://www.commoncoreontologies.org/ont00001758</seealso>
    let ont00001758 = Prefixed_Name(comcore, "ont00001758") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001759</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"code license"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001759">https://www.commoncoreontologies.org/ont00001759</seealso>
    let ont00001759 = Prefixed_Name(comcore, "ont00001759") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001760</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is curated in ontology"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001760">https://www.commoncoreontologies.org/ont00001760</seealso>
    let ont00001760 = Prefixed_Name(comcore, "ont00001760") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001761</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is tokenized by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001761">https://www.commoncoreontologies.org/ont00001761</seealso>
    let ont00001761 = Prefixed_Name(comcore, "ont00001761") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001762</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"term editor"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001762">https://www.commoncoreontologies.org/ont00001762</seealso>
    let ont00001762 = Prefixed_Name(comcore, "ont00001762") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001763</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has altitude value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001763">https://www.commoncoreontologies.org/ont00001763</seealso>
    let ont00001763 = Prefixed_Name(comcore, "ont00001763") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001764</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has longitude value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001764">https://www.commoncoreontologies.org/ont00001764</seealso>
    let ont00001764 = Prefixed_Name(comcore, "ont00001764") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001765</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has text value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001765">https://www.commoncoreontologies.org/ont00001765</seealso>
    let ont00001765 = Prefixed_Name(comcore, "ont00001765") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001766</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has latitude value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001766">https://www.commoncoreontologies.org/ont00001766</seealso>
    let ont00001766 = Prefixed_Name(comcore, "ont00001766") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001767</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has datetime value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001767">https://www.commoncoreontologies.org/ont00001767</seealso>
    let ont00001767 = Prefixed_Name(comcore, "ont00001767") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001768</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has URI value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001768">https://www.commoncoreontologies.org/ont00001768</seealso>
    let ont00001768 = Prefixed_Name(comcore, "ont00001768") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001769</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has decimal value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001769">https://www.commoncoreontologies.org/ont00001769</seealso>
    let ont00001769 = Prefixed_Name(comcore, "ont00001769") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001770</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has double value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001770">https://www.commoncoreontologies.org/ont00001770</seealso>
    let ont00001770 = Prefixed_Name(comcore, "ont00001770") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001771</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has date value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001771">https://www.commoncoreontologies.org/ont00001771</seealso>
    let ont00001771 = Prefixed_Name(comcore, "ont00001771") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001772</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has boolean value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001772">https://www.commoncoreontologies.org/ont00001772</seealso>
    let ont00001772 = Prefixed_Name(comcore, "ont00001772") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001773</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has integer value"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001773">https://www.commoncoreontologies.org/ont00001773</seealso>
    let ont00001773 = Prefixed_Name(comcore, "ont00001773") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001774</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has brother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001774">https://www.commoncoreontologies.org/ont00001774</seealso>
    let ont00001774 = Prefixed_Name(comcore, "ont00001774") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001775</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is successor of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001775">https://www.commoncoreontologies.org/ont00001775</seealso>
    let ont00001775 = Prefixed_Name(comcore, "ont00001775") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001776</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has grandfather"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001776">https://www.commoncoreontologies.org/ont00001776</seealso>
    let ont00001776 = Prefixed_Name(comcore, "ont00001776") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001777</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has process part"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001777">https://www.commoncoreontologies.org/ont00001777</seealso>
    let ont00001777 = Prefixed_Name(comcore, "ont00001777") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001778</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has object"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001778">https://www.commoncoreontologies.org/ont00001778</seealso>
    let ont00001778 = Prefixed_Name(comcore, "ont00001778") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001779</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has inside instant"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001779">https://www.commoncoreontologies.org/ont00001779</seealso>
    let ont00001779 = Prefixed_Name(comcore, "ont00001779") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001780</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has mother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001780">https://www.commoncoreontologies.org/ont00001780</seealso>
    let ont00001780 = Prefixed_Name(comcore, "ont00001780") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001781</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has step sister"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001781">https://www.commoncoreontologies.org/ont00001781</seealso>
    let ont00001781 = Prefixed_Name(comcore, "ont00001781") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001782</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has all members located in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001782">https://www.commoncoreontologies.org/ont00001782</seealso>
    let ont00001782 = Prefixed_Name(comcore, "ont00001782") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001783</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is granddaughter of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001783">https://www.commoncoreontologies.org/ont00001783</seealso>
    let ont00001783 = Prefixed_Name(comcore, "ont00001783") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001784</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has son-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001784">https://www.commoncoreontologies.org/ont00001784</seealso>
    let ont00001784 = Prefixed_Name(comcore, "ont00001784") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has uncle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001785">https://www.commoncoreontologies.org/ont00001785</seealso>
    let ont00001785 = Prefixed_Name(comcore, "ont00001785") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001786">https://www.commoncoreontologies.org/ont00001786</seealso>
    let ont00001786 = Prefixed_Name(comcore, "ont00001786") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001787</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"agent in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001787">https://www.commoncoreontologies.org/ont00001787</seealso>
    let ont00001787 = Prefixed_Name(comcore, "ont00001787") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has paternal aunt"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001788">https://www.commoncoreontologies.org/ont00001788</seealso>
    let ont00001788 = Prefixed_Name(comcore, "ont00001788") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has aunt"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001789">https://www.commoncoreontologies.org/ont00001789</seealso>
    let ont00001789 = Prefixed_Name(comcore, "ont00001789") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001790</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maternal uncle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001790">https://www.commoncoreontologies.org/ont00001790</seealso>
    let ont00001790 = Prefixed_Name(comcore, "ont00001790") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001791</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"coincides with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001791">https://www.commoncoreontologies.org/ont00001791</seealso>
    let ont00001791 = Prefixed_Name(comcore, "ont00001791") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001792</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sister"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001792">https://www.commoncoreontologies.org/ont00001792</seealso>
    let ont00001792 = Prefixed_Name(comcore, "ont00001792") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001793</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has half sister"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001793">https://www.commoncoreontologies.org/ont00001793</seealso>
    let ont00001793 = Prefixed_Name(comcore, "ont00001793") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has subsidiary"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001794">https://www.commoncoreontologies.org/ont00001794</seealso>
    let ont00001794 = Prefixed_Name(comcore, "ont00001794") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001795</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has inside interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001795">https://www.commoncoreontologies.org/ont00001795</seealso>
    let ont00001795 = Prefixed_Name(comcore, "ont00001795") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001796</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tangential part of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001796">https://www.commoncoreontologies.org/ont00001796</seealso>
    let ont00001796 = Prefixed_Name(comcore, "ont00001796") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001797</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"partially overlaps with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001797">https://www.commoncoreontologies.org/ont00001797</seealso>
    let ont00001797 = Prefixed_Name(comcore, "ont00001797") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001798</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is supervised by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001798">https://www.commoncoreontologies.org/ont00001798</seealso>
    let ont00001798 = Prefixed_Name(comcore, "ont00001798") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001799</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"role of aggregate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001799">https://www.commoncoreontologies.org/ont00001799</seealso>
    let ont00001799 = Prefixed_Name(comcore, "ont00001799") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001800</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prohibits"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001800">https://www.commoncoreontologies.org/ont00001800</seealso>
    let ont00001800 = Prefixed_Name(comcore, "ont00001800") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001801</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subject of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001801">https://www.commoncoreontologies.org/ont00001801</seealso>
    let ont00001801 = Prefixed_Name(comcore, "ont00001801") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001802</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has husband"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001802">https://www.commoncoreontologies.org/ont00001802</seealso>
    let ont00001802 = Prefixed_Name(comcore, "ont00001802") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001803</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is cause of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001803">https://www.commoncoreontologies.org/ont00001803</seealso>
    let ont00001803 = Prefixed_Name(comcore, "ont00001803") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001804</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is spouse of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001804">https://www.commoncoreontologies.org/ont00001804</seealso>
    let ont00001804 = Prefixed_Name(comcore, "ont00001804") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001805</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is disrupted by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001805">https://www.commoncoreontologies.org/ont00001805</seealso>
    let ont00001805 = Prefixed_Name(comcore, "ont00001805") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001806</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is first cousin of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001806">https://www.commoncoreontologies.org/ont00001806</seealso>
    let ont00001806 = Prefixed_Name(comcore, "ont00001806") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001807</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is required by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001807">https://www.commoncoreontologies.org/ont00001807</seealso>
    let ont00001807 = Prefixed_Name(comcore, "ont00001807") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001808</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is about"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001808">https://www.commoncoreontologies.org/ont00001808</seealso>
    let ont00001808 = Prefixed_Name(comcore, "ont00001808") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001809</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inheres in aggregate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001809">https://www.commoncoreontologies.org/ont00001809</seealso>
    let ont00001809 = Prefixed_Name(comcore, "ont00001809") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001810</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"connected with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001810">https://www.commoncoreontologies.org/ont00001810</seealso>
    let ont00001810 = Prefixed_Name(comcore, "ont00001810") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001811</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an ordinal measurement of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001811">https://www.commoncoreontologies.org/ont00001811</seealso>
    let ont00001811 = Prefixed_Name(comcore, "ont00001811") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001812</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is grandson of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001812">https://www.commoncoreontologies.org/ont00001812</seealso>
    let ont00001812 = Prefixed_Name(comcore, "ont00001812") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001813</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001813">https://www.commoncoreontologies.org/ont00001813</seealso>
    let ont00001813 = Prefixed_Name(comcore, "ont00001813") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001814</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval finishes"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001814">https://www.commoncoreontologies.org/ont00001814</seealso>
    let ont00001814 = Prefixed_Name(comcore, "ont00001814") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001815</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subsidiary of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001815">https://www.commoncoreontologies.org/ont00001815</seealso>
    let ont00001815 = Prefixed_Name(comcore, "ont00001815") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001816</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is output of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001816">https://www.commoncoreontologies.org/ont00001816</seealso>
    let ont00001816 = Prefixed_Name(comcore, "ont00001816") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001817</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is prohibited by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001817">https://www.commoncoreontologies.org/ont00001817</seealso>
    let ont00001817 = Prefixed_Name(comcore, "ont00001817") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001818</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001818">https://www.commoncoreontologies.org/ont00001818</seealso>
    let ont00001818 = Prefixed_Name(comcore, "ont00001818") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001819</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"caused by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001819">https://www.commoncoreontologies.org/ont00001819</seealso>
    let ont00001819 = Prefixed_Name(comcore, "ont00001819") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001820</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has granddaughter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001820">https://www.commoncoreontologies.org/ont00001820</seealso>
    let ont00001820 = Prefixed_Name(comcore, "ont00001820") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001821</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval finished by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001821">https://www.commoncoreontologies.org/ont00001821</seealso>
    let ont00001821 = Prefixed_Name(comcore, "ont00001821") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001822</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval equals"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001822">https://www.commoncoreontologies.org/ont00001822</seealso>
    let ont00001822 = Prefixed_Name(comcore, "ont00001822") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001823</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has paternal uncle"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001823">https://www.commoncoreontologies.org/ont00001823</seealso>
    let ont00001823 = Prefixed_Name(comcore, "ont00001823") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001824</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is excerpted from"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001824">https://www.commoncoreontologies.org/ont00001824</seealso>
    let ont00001824 = Prefixed_Name(comcore, "ont00001824") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001825</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval overlaps"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001825">https://www.commoncoreontologies.org/ont00001825</seealso>
    let ont00001825 = Prefixed_Name(comcore, "ont00001825") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001826</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is sister-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001826">https://www.commoncoreontologies.org/ont00001826</seealso>
    let ont00001826 = Prefixed_Name(comcore, "ont00001826") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001827</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nontangential part of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001827">https://www.commoncoreontologies.org/ont00001827</seealso>
    let ont00001827 = Prefixed_Name(comcore, "ont00001827") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001828</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sister-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001828">https://www.commoncoreontologies.org/ont00001828</seealso>
    let ont00001828 = Prefixed_Name(comcore, "ont00001828") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001829</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"disposition of aggregate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001829">https://www.commoncoreontologies.org/ont00001829</seealso>
    let ont00001829 = Prefixed_Name(comcore, "ont00001829") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001830</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accomplice"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001830">https://www.commoncoreontologies.org/ont00001830</seealso>
    let ont00001830 = Prefixed_Name(comcore, "ont00001830") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001831</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subordinate role to"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001831">https://www.commoncoreontologies.org/ont00001831</seealso>
    let ont00001831 = Prefixed_Name(comcore, "ont00001831") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001832</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has some member located in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001832">https://www.commoncoreontologies.org/ont00001832</seealso>
    let ont00001832 = Prefixed_Name(comcore, "ont00001832") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001833</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has agent"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001833">https://www.commoncoreontologies.org/ont00001833</seealso>
    let ont00001833 = Prefixed_Name(comcore, "ont00001833") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001834</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affects"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001834">https://www.commoncoreontologies.org/ont00001834</seealso>
    let ont00001834 = Prefixed_Name(comcore, "ont00001834") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001835</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is son of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001835">https://www.commoncoreontologies.org/ont00001835</seealso>
    let ont00001835 = Prefixed_Name(comcore, "ont00001835") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001836</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aggregate bearer of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001836">https://www.commoncoreontologies.org/ont00001836</seealso>
    let ont00001836 = Prefixed_Name(comcore, "ont00001836") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001837</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"time zone identifier used by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001837">https://www.commoncoreontologies.org/ont00001837</seealso>
    let ont00001837 = Prefixed_Name(comcore, "ont00001837") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001838</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"disconnected with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001838">https://www.commoncoreontologies.org/ont00001838</seealso>
    let ont00001838 = Prefixed_Name(comcore, "ont00001838") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001839</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has son"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001839">https://www.commoncoreontologies.org/ont00001839</seealso>
    let ont00001839 = Prefixed_Name(comcore, "ont00001839") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001840</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has grandmother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001840">https://www.commoncoreontologies.org/ont00001840</seealso>
    let ont00001840 = Prefixed_Name(comcore, "ont00001840") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001841</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is input of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001841">https://www.commoncoreontologies.org/ont00001841</seealso>
    let ont00001841 = Prefixed_Name(comcore, "ont00001841") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001842</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is child of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001842">https://www.commoncoreontologies.org/ont00001842</seealso>
    let ont00001842 = Prefixed_Name(comcore, "ont00001842") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001843</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paternal first cousin of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001843">https://www.commoncoreontologies.org/ont00001843</seealso>
    let ont00001843 = Prefixed_Name(comcore, "ont00001843") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001844</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sender"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001844">https://www.commoncoreontologies.org/ont00001844</seealso>
    let ont00001844 = Prefixed_Name(comcore, "ont00001844") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001845</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is site of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001845">https://www.commoncoreontologies.org/ont00001845</seealso>
    let ont00001845 = Prefixed_Name(comcore, "ont00001845") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001846</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is organizational context of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001846">https://www.commoncoreontologies.org/ont00001846</seealso>
    let ont00001846 = Prefixed_Name(comcore, "ont00001846") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001847</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval is after"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001847">https://www.commoncoreontologies.org/ont00001847</seealso>
    let ont00001847 = Prefixed_Name(comcore, "ont00001847") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001848</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is inside instant of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001848">https://www.commoncoreontologies.org/ont00001848</seealso>
    let ont00001848 = Prefixed_Name(comcore, "ont00001848") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001849</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is father-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001849">https://www.commoncoreontologies.org/ont00001849</seealso>
    let ont00001849 = Prefixed_Name(comcore, "ont00001849") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001850</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is grandparent of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001850">https://www.commoncoreontologies.org/ont00001850</seealso>
    let ont00001850 = Prefixed_Name(comcore, "ont00001850") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001851</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is sister of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001851">https://www.commoncoreontologies.org/ont00001851</seealso>
    let ont00001851 = Prefixed_Name(comcore, "ont00001851") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001852</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"accessory in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001852">https://www.commoncoreontologies.org/ont00001852</seealso>
    let ont00001852 = Prefixed_Name(comcore, "ont00001852") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001853</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mother-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001853">https://www.commoncoreontologies.org/ont00001853</seealso>
    let ont00001853 = Prefixed_Name(comcore, "ont00001853") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001854</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has daughter-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001854">https://www.commoncoreontologies.org/ont00001854</seealso>
    let ont00001854 = Prefixed_Name(comcore, "ont00001854") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001855</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has spatial part"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001855">https://www.commoncoreontologies.org/ont00001855</seealso>
    let ont00001855 = Prefixed_Name(comcore, "ont00001855") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001856</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has niece"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001856">https://www.commoncoreontologies.org/ont00001856</seealso>
    let ont00001856 = Prefixed_Name(comcore, "ont00001856") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001857</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001857">https://www.commoncoreontologies.org/ont00001857</seealso>
    let ont00001857 = Prefixed_Name(comcore, "ont00001857") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001858</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is daughter of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001858">https://www.commoncoreontologies.org/ont00001858</seealso>
    let ont00001858 = Prefixed_Name(comcore, "ont00001858") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001859</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is delimited by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001859">https://www.commoncoreontologies.org/ont00001859</seealso>
    let ont00001859 = Prefixed_Name(comcore, "ont00001859") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001860</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is ancestor of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001860">https://www.commoncoreontologies.org/ont00001860</seealso>
    let ont00001860 = Prefixed_Name(comcore, "ont00001860") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001862</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval disjoint"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001862">https://www.commoncoreontologies.org/ont00001862</seealso>
    let ont00001862 = Prefixed_Name(comcore, "ont00001862") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001863</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses measurement unit"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001863">https://www.commoncoreontologies.org/ont00001863</seealso>
    let ont00001863 = Prefixed_Name(comcore, "ont00001863") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001864</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"delimits"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001864">https://www.commoncoreontologies.org/ont00001864</seealso>
    let ont00001864 = Prefixed_Name(comcore, "ont00001864") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001865</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"has familial relationship to"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001865">https://www.commoncoreontologies.org/ont00001865</seealso>
    let ont00001865 = Prefixed_Name(comcore, "ont00001865") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001866</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is interest of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001866">https://www.commoncoreontologies.org/ont00001866</seealso>
    let ont00001866 = Prefixed_Name(comcore, "ont00001866") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001867</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is daughter-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001867">https://www.commoncoreontologies.org/ont00001867</seealso>
    let ont00001867 = Prefixed_Name(comcore, "ont00001867") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001868</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a nominal measurement of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001868">https://www.commoncoreontologies.org/ont00001868</seealso>
    let ont00001868 = Prefixed_Name(comcore, "ont00001868") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001869</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval during"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001869">https://www.commoncoreontologies.org/ont00001869</seealso>
    let ont00001869 = Prefixed_Name(comcore, "ont00001869") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001870</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval overlapped by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001870">https://www.commoncoreontologies.org/ont00001870</seealso>
    let ont00001870 = Prefixed_Name(comcore, "ont00001870") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001871</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has wife"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001871">https://www.commoncoreontologies.org/ont00001871</seealso>
    let ont00001871 = Prefixed_Name(comcore, "ont00001871") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001872</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is step-brother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001872">https://www.commoncoreontologies.org/ont00001872</seealso>
    let ont00001872 = Prefixed_Name(comcore, "ont00001872") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001873</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"represented by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001873">https://www.commoncoreontologies.org/ont00001873</seealso>
    let ont00001873 = Prefixed_Name(comcore, "ont00001873") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001874</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is temporal region of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001874">https://www.commoncoreontologies.org/ont00001874</seealso>
    let ont00001874 = Prefixed_Name(comcore, "ont00001874") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001875</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval started by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001875">https://www.commoncoreontologies.org/ont00001875</seealso>
    let ont00001875 = Prefixed_Name(comcore, "ont00001875") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001876</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is grandfather of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001876">https://www.commoncoreontologies.org/ont00001876</seealso>
    let ont00001876 = Prefixed_Name(comcore, "ont00001876") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001877</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an interval measurement of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001877">https://www.commoncoreontologies.org/ont00001877</seealso>
    let ont00001877 = Prefixed_Name(comcore, "ont00001877") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001878</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mention of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001878">https://www.commoncoreontologies.org/ont00001878</seealso>
    let ont00001878 = Prefixed_Name(comcore, "ont00001878") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001879</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"designated by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001879">https://www.commoncoreontologies.org/ont00001879</seealso>
    let ont00001879 = Prefixed_Name(comcore, "ont00001879") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001880</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"capability of aggregate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001880">https://www.commoncoreontologies.org/ont00001880</seealso>
    let ont00001880 = Prefixed_Name(comcore, "ont00001880") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001881</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is son-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001881">https://www.commoncoreontologies.org/ont00001881</seealso>
    let ont00001881 = Prefixed_Name(comcore, "ont00001881") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001882</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is grandmother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001882">https://www.commoncoreontologies.org/ont00001882</seealso>
    let ont00001882 = Prefixed_Name(comcore, "ont00001882") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001883</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is brother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001883">https://www.commoncoreontologies.org/ont00001883</seealso>
    let ont00001883 = Prefixed_Name(comcore, "ont00001883") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001884</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"condition described by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001884">https://www.commoncoreontologies.org/ont00001884</seealso>
    let ont00001884 = Prefixed_Name(comcore, "ont00001884") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001885</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has mother-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001885">https://www.commoncoreontologies.org/ont00001885</seealso>
    let ont00001885 = Prefixed_Name(comcore, "ont00001885") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001886</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affected by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001886">https://www.commoncoreontologies.org/ont00001886</seealso>
    let ont00001886 = Prefixed_Name(comcore, "ont00001886") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001887</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is wife of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001887">https://www.commoncoreontologies.org/ont00001887</seealso>
    let ont00001887 = Prefixed_Name(comcore, "ont00001887") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001888</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"disrupts"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001888">https://www.commoncoreontologies.org/ont00001888</seealso>
    let ont00001888 = Prefixed_Name(comcore, "ont00001888") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001889</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"capability of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001889">https://www.commoncoreontologies.org/ont00001889</seealso>
    let ont00001889 = Prefixed_Name(comcore, "ont00001889") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001890</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has step brother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001890">https://www.commoncoreontologies.org/ont00001890</seealso>
    let ont00001890 = Prefixed_Name(comcore, "ont00001890") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001891</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has brother-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001891">https://www.commoncoreontologies.org/ont00001891</seealso>
    let ont00001891 = Prefixed_Name(comcore, "ont00001891") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001892</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paternal grandfather of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001892">https://www.commoncoreontologies.org/ont00001892</seealso>
    let ont00001892 = Prefixed_Name(comcore, "ont00001892") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001893</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"instant is after"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001893">https://www.commoncoreontologies.org/ont00001893</seealso>
    let ont00001893 = Prefixed_Name(comcore, "ont00001893") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001894</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has paternal first cousin"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001894">https://www.commoncoreontologies.org/ont00001894</seealso>
    let ont00001894 = Prefixed_Name(comcore, "ont00001894") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001895</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"accomplice in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001895">https://www.commoncoreontologies.org/ont00001895</seealso>
    let ont00001895 = Prefixed_Name(comcore, "ont00001895") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001896</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>"interval meets"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001896">https://www.commoncoreontologies.org/ont00001896</seealso>
    let ont00001896 = Prefixed_Name(comcore, "ont00001896") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001897</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is maternal grandmother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001897">https://www.commoncoreontologies.org/ont00001897</seealso>
    let ont00001897 = Prefixed_Name(comcore, "ont00001897") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001898</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"aggregate has capability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001898">https://www.commoncoreontologies.org/ont00001898</seealso>
    let ont00001898 = Prefixed_Name(comcore, "ont00001898") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001899</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"language used in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001899">https://www.commoncoreontologies.org/ont00001899</seealso>
    let ont00001899 = Prefixed_Name(comcore, "ont00001899") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001900</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is geospatial coordinate reference system of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001900">https://www.commoncoreontologies.org/ont00001900</seealso>
    let ont00001900 = Prefixed_Name(comcore, "ont00001900") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001901</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"aggregate has role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001901">https://www.commoncoreontologies.org/ont00001901</seealso>
    let ont00001901 = Prefixed_Name(comcore, "ont00001901") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001902</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is sibling of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001902">https://www.commoncoreontologies.org/ont00001902</seealso>
    let ont00001902 = Prefixed_Name(comcore, "ont00001902") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001903</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is maternal grandfather of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001903">https://www.commoncoreontologies.org/ont00001903</seealso>
    let ont00001903 = Prefixed_Name(comcore, "ont00001903") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001904</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measured by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001904">https://www.commoncoreontologies.org/ont00001904</seealso>
    let ont00001904 = Prefixed_Name(comcore, "ont00001904") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001905</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is half-brother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001905">https://www.commoncoreontologies.org/ont00001905</seealso>
    let ont00001905 = Prefixed_Name(comcore, "ont00001905") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is maternal first cousin of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001906">https://www.commoncoreontologies.org/ont00001906</seealso>
    let ont00001906 = Prefixed_Name(comcore, "ont00001906") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001907</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"aggregate has quality"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001907">https://www.commoncoreontologies.org/ont00001907</seealso>
    let ont00001907 = Prefixed_Name(comcore, "ont00001907") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001908</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses time zone identifier"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001908">https://www.commoncoreontologies.org/ont00001908</seealso>
    let ont00001908 = Prefixed_Name(comcore, "ont00001908") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001909</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has tangential part"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001909">https://www.commoncoreontologies.org/ont00001909</seealso>
    let ont00001909 = Prefixed_Name(comcore, "ont00001909") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001910</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"permits"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001910">https://www.commoncoreontologies.org/ont00001910</seealso>
    let ont00001910 = Prefixed_Name(comcore, "ont00001910") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001911</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paternal grandmother of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001911">https://www.commoncoreontologies.org/ont00001911</seealso>
    let ont00001911 = Prefixed_Name(comcore, "ont00001911") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001912</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses reference system"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001912">https://www.commoncoreontologies.org/ont00001912</seealso>
    let ont00001912 = Prefixed_Name(comcore, "ont00001912") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001913</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses geospatial coordinate reference system"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001913">https://www.commoncoreontologies.org/ont00001913</seealso>
    let ont00001913 = Prefixed_Name(comcore, "ont00001913") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001914</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measured by nominal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001914">https://www.commoncoreontologies.org/ont00001914</seealso>
    let ont00001914 = Prefixed_Name(comcore, "ont00001914") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001915</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>"interval met by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001915">https://www.commoncoreontologies.org/ont00001915</seealso>
    let ont00001915 = Prefixed_Name(comcore, "ont00001915") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001916</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"designates"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001916">https://www.commoncoreontologies.org/ont00001916</seealso>
    let ont00001916 = Prefixed_Name(comcore, "ont00001916") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001917</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"described by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001917">https://www.commoncoreontologies.org/ont00001917</seealso>
    let ont00001917 = Prefixed_Name(comcore, "ont00001917") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001918</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"occurs at"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001918">https://www.commoncoreontologies.org/ont00001918</seealso>
    let ont00001918 = Prefixed_Name(comcore, "ont00001918") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001919</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mentioned by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001919">https://www.commoncoreontologies.org/ont00001919</seealso>
    let ont00001919 = Prefixed_Name(comcore, "ont00001919") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001920</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prescribed by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001920">https://www.commoncoreontologies.org/ont00001920</seealso>
    let ont00001920 = Prefixed_Name(comcore, "ont00001920") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001921</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has input"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001921">https://www.commoncoreontologies.org/ont00001921</seealso>
    let ont00001921 = Prefixed_Name(comcore, "ont00001921") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001922</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has recipient"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001922">https://www.commoncoreontologies.org/ont00001922</seealso>
    let ont00001922 = Prefixed_Name(comcore, "ont00001922") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001923</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval starts"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001923">https://www.commoncoreontologies.org/ont00001923</seealso>
    let ont00001923 = Prefixed_Name(comcore, "ont00001923") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001924</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval contains"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001924">https://www.commoncoreontologies.org/ont00001924</seealso>
    let ont00001924 = Prefixed_Name(comcore, "ont00001924") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001925</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001925">https://www.commoncoreontologies.org/ont00001925</seealso>
    let ont00001925 = Prefixed_Name(comcore, "ont00001925") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001926</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paternal uncle of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001926">https://www.commoncoreontologies.org/ont00001926</seealso>
    let ont00001926 = Prefixed_Name(comcore, "ont00001926") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001927</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has half brother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001927">https://www.commoncoreontologies.org/ont00001927</seealso>
    let ont00001927 = Prefixed_Name(comcore, "ont00001927") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001928</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is predecessor of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001928">https://www.commoncoreontologies.org/ont00001928</seealso>
    let ont00001928 = Prefixed_Name(comcore, "ont00001928") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001929</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is maternal uncle of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001929">https://www.commoncoreontologies.org/ont00001929</seealso>
    let ont00001929 = Prefixed_Name(comcore, "ont00001929") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001930</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is second cousin of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001930">https://www.commoncoreontologies.org/ont00001930</seealso>
    let ont00001930 = Prefixed_Name(comcore, "ont00001930") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001931</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"externally connects with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001931">https://www.commoncoreontologies.org/ont00001931</seealso>
    let ont00001931 = Prefixed_Name(comcore, "ont00001931") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001932</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is niece of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001932">https://www.commoncoreontologies.org/ont00001932</seealso>
    let ont00001932 = Prefixed_Name(comcore, "ont00001932") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001933</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"process starts"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001933">https://www.commoncoreontologies.org/ont00001933</seealso>
    let ont00001933 = Prefixed_Name(comcore, "ont00001933") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001934</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maternal first cousin"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001934">https://www.commoncoreontologies.org/ont00001934</seealso>
    let ont00001934 = Prefixed_Name(comcore, "ont00001934") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001935</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has father-in-law"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001935">https://www.commoncoreontologies.org/ont00001935</seealso>
    let ont00001935 = Prefixed_Name(comcore, "ont00001935") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001936</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is object of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001936">https://www.commoncoreontologies.org/ont00001936</seealso>
    let ont00001936 = Prefixed_Name(comcore, "ont00001936") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001937</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has paternal grandmother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001937">https://www.commoncoreontologies.org/ont00001937</seealso>
    let ont00001937 = Prefixed_Name(comcore, "ont00001937") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001938</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"represents"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001938">https://www.commoncoreontologies.org/ont00001938</seealso>
    let ont00001938 = Prefixed_Name(comcore, "ont00001938") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001939</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affiliated with"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001939">https://www.commoncoreontologies.org/ont00001939</seealso>
    let ont00001939 = Prefixed_Name(comcore, "ont00001939") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001940</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval is before"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001940">https://www.commoncoreontologies.org/ont00001940</seealso>
    let ont00001940 = Prefixed_Name(comcore, "ont00001940") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001941</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is maternal aunt of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001941">https://www.commoncoreontologies.org/ont00001941</seealso>
    let ont00001941 = Prefixed_Name(comcore, "ont00001941") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001942</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prescribes"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001942">https://www.commoncoreontologies.org/ont00001942</seealso>
    let ont00001942 = Prefixed_Name(comcore, "ont00001942") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001943</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"supervises"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001943">https://www.commoncoreontologies.org/ont00001943</seealso>
    let ont00001943 = Prefixed_Name(comcore, "ont00001943") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001944</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"spatial part of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001944">https://www.commoncoreontologies.org/ont00001944</seealso>
    let ont00001944 = Prefixed_Name(comcore, "ont00001944") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001945</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is grandchild of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001945">https://www.commoncoreontologies.org/ont00001945</seealso>
    let ont00001945 = Prefixed_Name(comcore, "ont00001945") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001946</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has father"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001946">https://www.commoncoreontologies.org/ont00001946</seealso>
    let ont00001946 = Prefixed_Name(comcore, "ont00001946") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001947</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"quality of aggregate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001947">https://www.commoncoreontologies.org/ont00001947</seealso>
    let ont00001947 = Prefixed_Name(comcore, "ont00001947") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001948</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is half sister of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001948">https://www.commoncoreontologies.org/ont00001948</seealso>
    let ont00001948 = Prefixed_Name(comcore, "ont00001948") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001949</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accessory"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001949">https://www.commoncoreontologies.org/ont00001949</seealso>
    let ont00001949 = Prefixed_Name(comcore, "ont00001949") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001950</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is third cousin of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001950">https://www.commoncoreontologies.org/ont00001950</seealso>
    let ont00001950 = Prefixed_Name(comcore, "ont00001950") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001951</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has subordinate role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001951">https://www.commoncoreontologies.org/ont00001951</seealso>
    let ont00001951 = Prefixed_Name(comcore, "ont00001951") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001952</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is brother-in-law of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001952">https://www.commoncoreontologies.org/ont00001952</seealso>
    let ont00001952 = Prefixed_Name(comcore, "ont00001952") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001954</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has capability"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001954">https://www.commoncoreontologies.org/ont00001954</seealso>
    let ont00001954 = Prefixed_Name(comcore, "ont00001954") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is aunt of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001955">https://www.commoncoreontologies.org/ont00001955</seealso>
    let ont00001955 = Prefixed_Name(comcore, "ont00001955") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001956</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"aggregate has disposition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001956">https://www.commoncoreontologies.org/ont00001956</seealso>
    let ont00001956 = Prefixed_Name(comcore, "ont00001956") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001957</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is husband of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001957">https://www.commoncoreontologies.org/ont00001957</seealso>
    let ont00001957 = Prefixed_Name(comcore, "ont00001957") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001958</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maternal aunt"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001958">https://www.commoncoreontologies.org/ont00001958</seealso>
    let ont00001958 = Prefixed_Name(comcore, "ont00001958") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001959</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inhibits"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001959">https://www.commoncoreontologies.org/ont00001959</seealso>
    let ont00001959 = Prefixed_Name(comcore, "ont00001959") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001960</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maternal grandmother"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001960">https://www.commoncoreontologies.org/ont00001960</seealso>
    let ont00001960 = Prefixed_Name(comcore, "ont00001960") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001961</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measurement unit of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001961">https://www.commoncoreontologies.org/ont00001961</seealso>
    let ont00001961 = Prefixed_Name(comcore, "ont00001961") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001962</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"process started by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001962">https://www.commoncoreontologies.org/ont00001962</seealso>
    let ont00001962 = Prefixed_Name(comcore, "ont00001962") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001963</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measured by ordinal"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001963">https://www.commoncoreontologies.org/ont00001963</seealso>
    let ont00001963 = Prefixed_Name(comcore, "ont00001963") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001964</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measured by interval"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001964">https://www.commoncoreontologies.org/ont00001964</seealso>
    let ont00001964 = Prefixed_Name(comcore, "ont00001964") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001965</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measured by ratio"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001965">https://www.commoncoreontologies.org/ont00001965</seealso>
    let ont00001965 = Prefixed_Name(comcore, "ont00001965") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001966</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a measurement of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001966">https://www.commoncoreontologies.org/ont00001966</seealso>
    let ont00001966 = Prefixed_Name(comcore, "ont00001966") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001967</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is nephew of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001967">https://www.commoncoreontologies.org/ont00001967</seealso>
    let ont00001967 = Prefixed_Name(comcore, "ont00001967") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001968</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is descendant of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001968">https://www.commoncoreontologies.org/ont00001968</seealso>
    let ont00001968 = Prefixed_Name(comcore, "ont00001968") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001969</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has nephew"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001969">https://www.commoncoreontologies.org/ont00001969</seealso>
    let ont00001969 = Prefixed_Name(comcore, "ont00001969") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001970</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inhibited by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001970">https://www.commoncoreontologies.org/ont00001970</seealso>
    let ont00001970 = Prefixed_Name(comcore, "ont00001970") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001971</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interval contained by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001971">https://www.commoncoreontologies.org/ont00001971</seealso>
    let ont00001971 = Prefixed_Name(comcore, "ont00001971") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001972</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has paternal grandfather"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001972">https://www.commoncoreontologies.org/ont00001972</seealso>
    let ont00001972 = Prefixed_Name(comcore, "ont00001972") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001973</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maternal grandfather"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001973">https://www.commoncoreontologies.org/ont00001973</seealso>
    let ont00001973 = Prefixed_Name(comcore, "ont00001973") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001974</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"requires"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001974">https://www.commoncoreontologies.org/ont00001974</seealso>
    let ont00001974 = Prefixed_Name(comcore, "ont00001974") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001975</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is half-sibling of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001975">https://www.commoncoreontologies.org/ont00001975</seealso>
    let ont00001975 = Prefixed_Name(comcore, "ont00001975") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001976</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses language"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001976">https://www.commoncoreontologies.org/ont00001976</seealso>
    let ont00001976 = Prefixed_Name(comcore, "ont00001976") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001977</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has affiliate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001977">https://www.commoncoreontologies.org/ont00001977</seealso>
    let ont00001977 = Prefixed_Name(comcore, "ont00001977") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001978</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"receives"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001978">https://www.commoncoreontologies.org/ont00001978</seealso>
    let ont00001978 = Prefixed_Name(comcore, "ont00001978") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001979</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is step-sister of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001979">https://www.commoncoreontologies.org/ont00001979</seealso>
    let ont00001979 = Prefixed_Name(comcore, "ont00001979") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001980</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"describes condition"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001980">https://www.commoncoreontologies.org/ont00001980</seealso>
    let ont00001980 = Prefixed_Name(comcore, "ont00001980") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001981</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has grandson"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001981">https://www.commoncoreontologies.org/ont00001981</seealso>
    let ont00001981 = Prefixed_Name(comcore, "ont00001981") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001982</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001982">https://www.commoncoreontologies.org/ont00001982</seealso>
    let ont00001982 = Prefixed_Name(comcore, "ont00001982") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001983</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a ratio measurement of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001983">https://www.commoncoreontologies.org/ont00001983</seealso>
    let ont00001983 = Prefixed_Name(comcore, "ont00001983") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001984</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest in"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001984">https://www.commoncoreontologies.org/ont00001984</seealso>
    let ont00001984 = Prefixed_Name(comcore, "ont00001984") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001985</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is father of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001985">https://www.commoncoreontologies.org/ont00001985</seealso>
    let ont00001985 = Prefixed_Name(comcore, "ont00001985") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001986</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has output"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001986">https://www.commoncoreontologies.org/ont00001986</seealso>
    let ont00001986 = Prefixed_Name(comcore, "ont00001986") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001987</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has daughter"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001987">https://www.commoncoreontologies.org/ont00001987</seealso>
    let ont00001987 = Prefixed_Name(comcore, "ont00001987") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001988</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is uncle of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001988">https://www.commoncoreontologies.org/ont00001988</seealso>
    let ont00001988 = Prefixed_Name(comcore, "ont00001988") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001989</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has nontangential part"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001989">https://www.commoncoreontologies.org/ont00001989</seealso>
    let ont00001989 = Prefixed_Name(comcore, "ont00001989") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001990</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"instant is before"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001990">https://www.commoncoreontologies.org/ont00001990</seealso>
    let ont00001990 = Prefixed_Name(comcore, "ont00001990") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001992</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has organizational context"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001992">https://www.commoncoreontologies.org/ont00001992</seealso>
    let ont00001992 = Prefixed_Name(comcore, "ont00001992") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001993</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sends"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001993">https://www.commoncoreontologies.org/ont00001993</seealso>
    let ont00001993 = Prefixed_Name(comcore, "ont00001993") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001994</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paternal aunt of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001994">https://www.commoncoreontologies.org/ont00001994</seealso>
    let ont00001994 = Prefixed_Name(comcore, "ont00001994") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001995</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is parent of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001995">https://www.commoncoreontologies.org/ont00001995</seealso>
    let ont00001995 = Prefixed_Name(comcore, "ont00001995") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001996</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is step-sibling of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001996">https://www.commoncoreontologies.org/ont00001996</seealso>
    let ont00001996 = Prefixed_Name(comcore, "ont00001996") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001997</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is reference system of"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001997">https://www.commoncoreontologies.org/ont00001997</seealso>
    let ont00001997 = Prefixed_Name(comcore, "ont00001997") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001998</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is permitted by"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001998">https://www.commoncoreontologies.org/ont00001998</seealso>
    let ont00001998 = Prefixed_Name(comcore, "ont00001998") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00001999</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Filter Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00001999">https://www.commoncoreontologies.org/ont00001999</seealso>
    let ont00001999 = Prefixed_Name(comcore, "ont00001999") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Center of Mass"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002000">https://www.commoncoreontologies.org/ont00002000</seealso>
    let ont00002000 = Prefixed_Name(comcore, "ont00002000") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Media Content Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002001">https://www.commoncoreontologies.org/ont00002001</seealso>
    let ont00002001 = Prefixed_Name(comcore, "ont00002001") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Certificate"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002002">https://www.commoncoreontologies.org/ont00002002</seealso>
    let ont00002002 = Prefixed_Name(comcore, "ont00002002") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Academic Degree"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002003">https://www.commoncoreontologies.org/ont00002003</seealso>
    let ont00002003 = Prefixed_Name(comcore, "ont00002003") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002004">https://www.commoncoreontologies.org/ont00002004</seealso>
    let ont00002004 = Prefixed_Name(comcore, "ont00002004") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chart"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002005">https://www.commoncoreontologies.org/ont00002005</seealso>
    let ont00002005 = Prefixed_Name(comcore, "ont00002005") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Database"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002006">https://www.commoncoreontologies.org/ont00002006</seealso>
    let ont00002006 = Prefixed_Name(comcore, "ont00002006") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002007">https://www.commoncoreontologies.org/ont00002007</seealso>
    let ont00002007 = Prefixed_Name(comcore, "ont00002007") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code List"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002008">https://www.commoncoreontologies.org/ont00002008</seealso>
    let ont00002008 = Prefixed_Name(comcore, "ont00002008") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Video"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002009">https://www.commoncoreontologies.org/ont00002009</seealso>
    let ont00002009 = Prefixed_Name(comcore, "ont00002009") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002010">https://www.commoncoreontologies.org/ont00002010</seealso>
    let ont00002010 = Prefixed_Name(comcore, "ont00002010") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Warning Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002011">https://www.commoncoreontologies.org/ont00002011</seealso>
    let ont00002011 = Prefixed_Name(comcore, "ont00002011") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Email Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002012">https://www.commoncoreontologies.org/ont00002012</seealso>
    let ont00002012 = Prefixed_Name(comcore, "ont00002012") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Notification Message"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002013">https://www.commoncoreontologies.org/ont00002013</seealso>
    let ont00002013 = Prefixed_Name(comcore, "ont00002013") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002014">https://www.commoncoreontologies.org/ont00002014</seealso>
    let ont00002014 = Prefixed_Name(comcore, "ont00002014") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Two-Dimensional Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002015">https://www.commoncoreontologies.org/ont00002015</seealso>
    let ont00002015 = Prefixed_Name(comcore, "ont00002015") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Aztec Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002016">https://www.commoncoreontologies.org/ont00002016</seealso>
    let ont00002016 = Prefixed_Name(comcore, "ont00002016") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Matrix Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002017">https://www.commoncoreontologies.org/ont00002017</seealso>
    let ont00002017 = Prefixed_Name(comcore, "ont00002017") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"QR Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002018">https://www.commoncoreontologies.org/ont00002018</seealso>
    let ont00002018 = Prefixed_Name(comcore, "ont00002018") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PDF417 Code"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002019">https://www.commoncoreontologies.org/ont00002019</seealso>
    let ont00002019 = Prefixed_Name(comcore, "ont00002019") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"One-Dimensional Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002020">https://www.commoncoreontologies.org/ont00002020</seealso>
    let ont00002020 = Prefixed_Name(comcore, "ont00002020") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Codabar Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002021">https://www.commoncoreontologies.org/ont00002021</seealso>
    let ont00002021 = Prefixed_Name(comcore, "ont00002021") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code 93 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002022">https://www.commoncoreontologies.org/ont00002022</seealso>
    let ont00002022 = Prefixed_Name(comcore, "ont00002022") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ITF Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002023">https://www.commoncoreontologies.org/ont00002023</seealso>
    let ont00002023 = Prefixed_Name(comcore, "ont00002023") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MSI Plessey Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002024">https://www.commoncoreontologies.org/ont00002024</seealso>
    let ont00002024 = Prefixed_Name(comcore, "ont00002024") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EAN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002025">https://www.commoncoreontologies.org/ont00002025</seealso>
    let ont00002025 = Prefixed_Name(comcore, "ont00002025") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ISSN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002026">https://www.commoncoreontologies.org/ont00002026</seealso>
    let ont00002026 = Prefixed_Name(comcore, "ont00002026") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"JAN-13 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002027">https://www.commoncoreontologies.org/ont00002027</seealso>
    let ont00002027 = Prefixed_Name(comcore, "ont00002027") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EAN-13 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002028">https://www.commoncoreontologies.org/ont00002028</seealso>
    let ont00002028 = Prefixed_Name(comcore, "ont00002028") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EAN-8 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002029">https://www.commoncoreontologies.org/ont00002029</seealso>
    let ont00002029 = Prefixed_Name(comcore, "ont00002029") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ISBN Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002030">https://www.commoncoreontologies.org/ont00002030</seealso>
    let ont00002030 = Prefixed_Name(comcore, "ont00002030") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GS1 DataBar Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002031">https://www.commoncoreontologies.org/ont00002031</seealso>
    let ont00002031 = Prefixed_Name(comcore, "ont00002031") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code 39 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002032">https://www.commoncoreontologies.org/ont00002032</seealso>
    let ont00002032 = Prefixed_Name(comcore, "ont00002032") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code 128 Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002033">https://www.commoncoreontologies.org/ont00002033</seealso>
    let ont00002033 = Prefixed_Name(comcore, "ont00002033") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UPC Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002034">https://www.commoncoreontologies.org/ont00002034</seealso>
    let ont00002034 = Prefixed_Name(comcore, "ont00002034") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UPC-A Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002035">https://www.commoncoreontologies.org/ont00002035</seealso>
    let ont00002035 = Prefixed_Name(comcore, "ont00002035") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UPC-E Barcode"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002036">https://www.commoncoreontologies.org/ont00002036</seealso>
    let ont00002036 = Prefixed_Name(comcore, "ont00002036") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Line"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002037">https://www.commoncoreontologies.org/ont00002037</seealso>
    let ont00002037 = Prefixed_Name(comcore, "ont00002037") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Document Field Content"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002038">https://www.commoncoreontologies.org/ont00002038</seealso>
    let ont00002038 = Prefixed_Name(comcore, "ont00002038") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Document Content Entity"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002039">https://www.commoncoreontologies.org/ont00002039</seealso>
    let ont00002039 = Prefixed_Name(comcore, "ont00002039") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Book"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002040">https://www.commoncoreontologies.org/ont00002040</seealso>
    let ont00002040 = Prefixed_Name(comcore, "ont00002040") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transcript"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002041">https://www.commoncoreontologies.org/ont00002041</seealso>
    let ont00002041 = Prefixed_Name(comcore, "ont00002041") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spreadsheet"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002042">https://www.commoncoreontologies.org/ont00002042</seealso>
    let ont00002042 = Prefixed_Name(comcore, "ont00002042") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Report"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002043">https://www.commoncoreontologies.org/ont00002043</seealso>
    let ont00002043 = Prefixed_Name(comcore, "ont00002043") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Form Document"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002044">https://www.commoncoreontologies.org/ont00002044</seealso>
    let ont00002044 = Prefixed_Name(comcore, "ont00002044") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Journal Article"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002045">https://www.commoncoreontologies.org/ont00002045</seealso>
    let ont00002045 = Prefixed_Name(comcore, "ont00002045") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Explosive Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002066">https://www.commoncoreontologies.org/ont00002066</seealso>
    let ont00002066 = Prefixed_Name(comcore, "ont00002066") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Explosive Naval Mine"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002067">https://www.commoncoreontologies.org/ont00002067</seealso>
    let ont00002067 = Prefixed_Name(comcore, "ont00002067") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Display Instrument"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002068">https://www.commoncoreontologies.org/ont00002068</seealso>
    let ont00002068 = Prefixed_Name(comcore, "ont00002068") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Image Display Artifact Function"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002069">https://www.commoncoreontologies.org/ont00002069</seealso>
    let ont00002069 = Prefixed_Name(comcore, "ont00002069") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Email Address"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002070">https://www.commoncoreontologies.org/ont00002070</seealso>
    let ont00002070 = Prefixed_Name(comcore, "ont00002070") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Act of Employment"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002071">https://www.commoncoreontologies.org/ont00002071</seealso>
    let ont00002071 = Prefixed_Name(comcore, "ont00002071") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002073">https://www.commoncoreontologies.org/ont00002073</seealso>
    let ont00002073 = Prefixed_Name(comcore, "ont00002073") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor Platform Role"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002074">https://www.commoncoreontologies.org/ont00002074</seealso>
    let ont00002074 = Prefixed_Name(comcore, "ont00002074") |> PrefixedName
    /// <summary>
    ///   <para>comcore:ont00002075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensing Process"</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/ont00002075">https://www.commoncoreontologies.org/ont00002075</seealso>
    let ont00002075 = Prefixed_Name(comcore, "ont00002075") |> PrefixedName

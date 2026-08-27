namespace http.purl.obolibrary.org.obo.UO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uo =
    let _namespace_iri = Namespace_Iri uo |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:UO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"length unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000001">http://purl.obolibrary.org/obo/UO_0000001</seealso>
    let length_unit = Prefixed_Name(uo, "0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000002">http://purl.obolibrary.org/obo/UO_0000002</seealso>
    let mass_unit = Prefixed_Name(uo, "0000002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000003">http://purl.obolibrary.org/obo/UO_0000003</seealso>
    let time_unit = Prefixed_Name(uo, "0000003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temperature unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000005">http://purl.obolibrary.org/obo/UO_0000005</seealso>
    let temperature_unit = Prefixed_Name(uo, "0000005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"substance unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000006">http://purl.obolibrary.org/obo/UO_0000006</seealso>
    let substance_unit = Prefixed_Name(uo, "0000006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000001</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000008">http://purl.obolibrary.org/obo/UO_0000008</seealso>
    let meter = Prefixed_Name(uo, "0000008") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000002</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"kilogram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000009">http://purl.obolibrary.org/obo/UO_0000009</seealso>
    let kilogram = Prefixed_Name(uo, "0000009") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000010">http://purl.obolibrary.org/obo/UO_0000010</seealso>
    let second = Prefixed_Name(uo, "0000010") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000001</para>
    ///
    /// labels<para>"centimeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000015">http://purl.obolibrary.org/obo/UO_0000015</seealso>
    let centimeter = Prefixed_Name(uo, "0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>cdao:UO_0000001</para>
    ///
    /// labels<para>"millimeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000016">http://purl.obolibrary.org/obo/UO_0000016</seealso>
    let millimeter = Prefixed_Name(uo, "0000016") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000017</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000001</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"micrometer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000017">http://purl.obolibrary.org/obo/UO_0000017</seealso>
    let micrometer = Prefixed_Name(uo, "0000017") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000001</para>
    ///
    /// labels<para>"nanometer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000018">http://purl.obolibrary.org/obo/UO_0000018</seealso>
    let nanometer = Prefixed_Name(uo, "0000018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000001</para>
    ///
    /// labels<para>"angstrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000019">http://purl.obolibrary.org/obo/UO_0000019</seealso>
    let angstrom = Prefixed_Name(uo, "0000019") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000002</para>
    ///
    /// labels<para>"gram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000021">http://purl.obolibrary.org/obo/UO_0000021</seealso>
    let gram = Prefixed_Name(uo, "0000021") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000022</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000002</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"milligram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000022">http://purl.obolibrary.org/obo/UO_0000022</seealso>
    let milligram = Prefixed_Name(uo, "0000022") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000002</para>
    ///
    /// labels<para>"microgram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000023">http://purl.obolibrary.org/obo/UO_0000023</seealso>
    let microgram = Prefixed_Name(uo, "0000023") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000024</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000002</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nanogram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000024">http://purl.obolibrary.org/obo/UO_0000024</seealso>
    let nanogram = Prefixed_Name(uo, "0000024") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000025</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000002</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"picogram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000025">http://purl.obolibrary.org/obo/UO_0000025</seealso>
    let picogram = Prefixed_Name(uo, "0000025") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000005</para>
    ///
    /// labels<para>"degree Celsius"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000027">http://purl.obolibrary.org/obo/UO_0000027</seealso>
    let degree_Celsius = Prefixed_Name(uo, "0000027") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"millisecond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000028">http://purl.obolibrary.org/obo/UO_0000028</seealso>
    let millisecond = Prefixed_Name(uo, "0000028") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000031">http://purl.obolibrary.org/obo/UO_0000031</seealso>
    let minute = Prefixed_Name(uo, "0000031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000032">http://purl.obolibrary.org/obo/UO_0000032</seealso>
    let hour = Prefixed_Name(uo, "0000032") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000003</para>
    ///
    /// labels<para>"day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000033">http://purl.obolibrary.org/obo/UO_0000033</seealso>
    let day = Prefixed_Name(uo, "0000033") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"week"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000034">http://purl.obolibrary.org/obo/UO_0000034</seealso>
    let week = Prefixed_Name(uo, "0000034") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000035</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000035">http://purl.obolibrary.org/obo/UO_0000035</seealso>
    let month = Prefixed_Name(uo, "0000035") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000036</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000003</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000036">http://purl.obolibrary.org/obo/UO_0000036</seealso>
    let year = Prefixed_Name(uo, "0000036") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000039</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000006</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"micromole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000039">http://purl.obolibrary.org/obo/UO_0000039</seealso>
    let micromole = Prefixed_Name(uo, "0000039") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000041</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000006</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nanomole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000041">http://purl.obolibrary.org/obo/UO_0000041</seealso>
    let nanomole = Prefixed_Name(uo, "0000041") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000006</para>
    ///
    /// labels<para>"picomole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000042">http://purl.obolibrary.org/obo/UO_0000042</seealso>
    let picomole = Prefixed_Name(uo, "0000042") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"concentration unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000051">http://purl.obolibrary.org/obo/UO_0000051</seealso>
    let concentration_unit = Prefixed_Name(uo, "0000051") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rotational frequency unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000058">http://purl.obolibrary.org/obo/UO_0000058</seealso>
    let rotational_frequency_unit = Prefixed_Name(uo, "0000058") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"speed/velocity unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000060">http://purl.obolibrary.org/obo/UO_0000060</seealso>
    let ``speed/velocity_unit`` = Prefixed_Name(uo, "0000060") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"molar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000062">http://purl.obolibrary.org/obo/UO_0000062</seealso>
    let molar = Prefixed_Name(uo, "0000062") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000063</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"millimolar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000063">http://purl.obolibrary.org/obo/UO_0000063</seealso>
    let millimolar = Prefixed_Name(uo, "0000063") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"micromolar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000064">http://purl.obolibrary.org/obo/UO_0000064</seealso>
    let micromolar = Prefixed_Name(uo, "0000064") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000065</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nanomolar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000065">http://purl.obolibrary.org/obo/UO_0000065</seealso>
    let nanomolar = Prefixed_Name(uo, "0000065") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000066</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"picomolar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000066">http://purl.obolibrary.org/obo/UO_0000066</seealso>
    let picomolar = Prefixed_Name(uo, "0000066") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"turns per second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000092">http://purl.obolibrary.org/obo/UO_0000092</seealso>
    let turns_per_second = Prefixed_Name(uo, "0000092") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"meter per second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000094">http://purl.obolibrary.org/obo/UO_0000094</seealso>
    let meter_per_second = Prefixed_Name(uo, "0000094") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000095">http://purl.obolibrary.org/obo/UO_0000095</seealso>
    let volume_unit = Prefixed_Name(uo, "0000095") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000095</para>
    ///
    /// labels<para>"cubic centimeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000097">http://purl.obolibrary.org/obo/UO_0000097</seealso>
    let cubic_centimeter = Prefixed_Name(uo, "0000097") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000098</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000095</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"milliliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000098">http://purl.obolibrary.org/obo/UO_0000098</seealso>
    let milliliter = Prefixed_Name(uo, "0000098") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000099</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000095</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"liter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000099">http://purl.obolibrary.org/obo/UO_0000099</seealso>
    let liter = Prefixed_Name(uo, "0000099") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000100</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000095</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"cubic decimeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000100">http://purl.obolibrary.org/obo/UO_0000100</seealso>
    let cubic_decimeter = Prefixed_Name(uo, "0000100") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000101</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000095</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"microliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000101">http://purl.obolibrary.org/obo/UO_0000101</seealso>
    let microliter = Prefixed_Name(uo, "0000101") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000095</para>
    ///
    /// labels<para>"nanoliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000102">http://purl.obolibrary.org/obo/UO_0000102</seealso>
    let nanoliter = Prefixed_Name(uo, "0000102") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000095</para>
    ///
    /// labels<para>"picoliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000103">http://purl.obolibrary.org/obo/UO_0000103</seealso>
    let picoliter = Prefixed_Name(uo, "0000103") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"frequency unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000105">http://purl.obolibrary.org/obo/UO_0000105</seealso>
    let frequency_unit = Prefixed_Name(uo, "0000105") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>cdao:UO_0000105</para>
    ///
    /// labels<para>"hertz"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000106">http://purl.obolibrary.org/obo/UO_0000106</seealso>
    let hertz = Prefixed_Name(uo, "0000106") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pressure unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000109">http://purl.obolibrary.org/obo/UO_0000109</seealso>
    let pressure_unit = Prefixed_Name(uo, "0000109") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"energy unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000111">http://purl.obolibrary.org/obo/UO_0000111</seealso>
    let energy_unit = Prefixed_Name(uo, "0000111") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"power unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000113">http://purl.obolibrary.org/obo/UO_0000113</seealso>
    let power_unit = Prefixed_Name(uo, "0000113") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"watt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000114">http://purl.obolibrary.org/obo/UO_0000114</seealso>
    let watt = Prefixed_Name(uo, "0000114") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000163</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"mass percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000163">http://purl.obolibrary.org/obo/UO_0000163</seealso>
    let mass_percentage = Prefixed_Name(uo, "0000163") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000164</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"mass volume percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000164">http://purl.obolibrary.org/obo/UO_0000164</seealso>
    let mass_volume_percentage = Prefixed_Name(uo, "0000164") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000165</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"volume percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000165">http://purl.obolibrary.org/obo/UO_0000165</seealso>
    let volume_percentage = Prefixed_Name(uo, "0000165") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000175</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"gram per liter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000175">http://purl.obolibrary.org/obo/UO_0000175</seealso>
    let gram_per_liter = Prefixed_Name(uo, "0000175") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"milligram per milliliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000176">http://purl.obolibrary.org/obo/UO_0000176</seealso>
    let milligram_per_milliliter = Prefixed_Name(uo, "0000176") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000005</para>
    ///
    /// labels<para>"degree Fahrenheit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000195">http://purl.obolibrary.org/obo/UO_0000195</seealso>
    let degree_Fahrenheit = Prefixed_Name(uo, "0000195") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"pH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000196">http://purl.obolibrary.org/obo/UO_0000196</seealso>
    let pH = Prefixed_Name(uo, "0000196") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000207</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"milliliter per liter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000207">http://purl.obolibrary.org/obo/UO_0000207</seealso>
    let milliliter_per_liter = Prefixed_Name(uo, "0000207") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000208</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"gram per deciliter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000208">http://purl.obolibrary.org/obo/UO_0000208</seealso>
    let gram_per_deciliter = Prefixed_Name(uo, "0000208") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000212</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000051</para>
    ///
    /// labels<para>"colony forming unit per volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000212">http://purl.obolibrary.org/obo/UO_0000212</seealso>
    let colony_forming_unit_per_volume = Prefixed_Name(uo, "0000212") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"watt-hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000223">http://purl.obolibrary.org/obo/UO_0000223</seealso>
    let watt_hour = Prefixed_Name(uo, "0000223") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"kilowatt-hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000224">http://purl.obolibrary.org/obo/UO_0000224</seealso>
    let kilowatt_hour = Prefixed_Name(uo, "0000224") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000231">http://purl.obolibrary.org/obo/UO_0000231</seealso>
    let information_unit = Prefixed_Name(uo, "0000231") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000232">http://purl.obolibrary.org/obo/UO_0000232</seealso>
    let bit = Prefixed_Name(uo, "0000232") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"byte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000233">http://purl.obolibrary.org/obo/UO_0000233</seealso>
    let byte = Prefixed_Name(uo, "0000233") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"megabyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000235">http://purl.obolibrary.org/obo/UO_0000235</seealso>
    let megabyte = Prefixed_Name(uo, "0000235") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000270</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volumetric flow rate unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000270">http://purl.obolibrary.org/obo/UO_0000270</seealso>
    let volumetric_flow_rate_unit = Prefixed_Name(uo, "0000270") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000271</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000270</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"microliters per minute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000271">http://purl.obolibrary.org/obo/UO_0000271</seealso>
    let microliters_per_minute = Prefixed_Name(uo, "0000271") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Rate Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000280">http://purl.obolibrary.org/obo/UO_0000280</seealso>
    let rate_unit = Prefixed_Name(uo, "0000280") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000280</para>
    ///
    /// labels<para>"count per nanomolar second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000281">http://purl.obolibrary.org/obo/UO_0000281</seealso>
    let count_per_nanomolar_second = Prefixed_Name(uo, "0000281") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000282</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000280</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"count per molar second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000282">http://purl.obolibrary.org/obo/UO_0000282</seealso>
    let count_per_molar_second = Prefixed_Name(uo, "0000282") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000280</para>
    ///
    /// labels<para>"count per nanomolar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000284">http://purl.obolibrary.org/obo/UO_0000284</seealso>
    let count_per_nanomolar = Prefixed_Name(uo, "0000284") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cdao:UO_0000280</para>
    ///
    /// labels<para>"count per molar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000285">http://purl.obolibrary.org/obo/UO_0000285</seealso>
    let count_per_molar = Prefixed_Name(uo, "0000285") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000301</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000051</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"microgram per liter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000301">http://purl.obolibrary.org/obo/UO_0000301</seealso>
    let microgram_per_liter = Prefixed_Name(uo, "0000301") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"megaHertz"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000325">http://purl.obolibrary.org/obo/UO_0000325</seealso>
    let megaHertz = Prefixed_Name(uo, "0000325") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000331</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gigabyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000331">http://purl.obolibrary.org/obo/UO_0000331</seealso>
    let gigabyte = Prefixed_Name(uo, "0000331") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0000332</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"terabyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0000332">http://purl.obolibrary.org/obo/UO_0000332</seealso>
    let terabyte = Prefixed_Name(uo, "0000332") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0010005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"millimeters per day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0010005">http://purl.obolibrary.org/obo/UO_0010005</seealso>
    let millimeters_per_day = Prefixed_Name(uo, "0010005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UO_0010008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"kilometer per hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UO_0010008">http://purl.obolibrary.org/obo/UO_0010008</seealso>
    let kilometer_per_hour = Prefixed_Name(uo, "0010008") |> PrefixedName

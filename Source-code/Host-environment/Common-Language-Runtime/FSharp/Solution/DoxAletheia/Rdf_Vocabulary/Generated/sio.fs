namespace http.semanticscience.org.resource.SIO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module SIO =
    let _namespace_iri = Namespace_Iri SIO |> NamespaceIRI
    /// <summary>
    ///   <para>sio:SIO_000000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000000">http://semanticscience.org/resource/SIO_000000</seealso>
    let _000000 = Prefixed_Name(SIO, "000000") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is related to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000001">http://semanticscience.org/resource/SIO_000001</seealso>
    let _000001 = Prefixed_Name(SIO, "000001") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"material entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000004">http://semanticscience.org/resource/SIO_000004</seealso>
    let _000004 = Prefixed_Name(SIO, "000004") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000005">http://semanticscience.org/resource/SIO_000005</seealso>
    let _000005 = Prefixed_Name(SIO, "000005") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000006">http://semanticscience.org/resource/SIO_000006</seealso>
    let _000006 = Prefixed_Name(SIO, "000006") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has attribute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000008">http://semanticscience.org/resource/SIO_000008</seealso>
    let _000008 = Prefixed_Name(SIO, "000008") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000009">http://semanticscience.org/resource/SIO_000009</seealso>
    let _000009 = Prefixed_Name(SIO, "000009") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000010">http://semanticscience.org/resource/SIO_000010</seealso>
    let _000010 = Prefixed_Name(SIO, "000010") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is attribute of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000011">http://semanticscience.org/resource/SIO_000011</seealso>
    let _000011 = Prefixed_Name(SIO, "000011") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organization"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000012">http://semanticscience.org/resource/SIO_000012</seealso>
    let _000012 = Prefixed_Name(SIO, "000012") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000013">http://semanticscience.org/resource/SIO_000013</seealso>
    let _000013 = Prefixed_Name(SIO, "000013") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disposition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000014">http://semanticscience.org/resource/SIO_000014</seealso>
    let _000014 = Prefixed_Name(SIO, "000014") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information content entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000015">http://semanticscience.org/resource/SIO_000015</seealso>
    let _000015 = Prefixed_Name(SIO, "000015") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000016">http://semanticscience.org/resource/SIO_000016</seealso>
    let _000016 = Prefixed_Name(SIO, "000016") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"function"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000017">http://semanticscience.org/resource/SIO_000017</seealso>
    let _000017 = Prefixed_Name(SIO, "000017") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000019">http://semanticscience.org/resource/SIO_000019</seealso>
    let _000019 = Prefixed_Name(SIO, "000019") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"denotes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000020">http://semanticscience.org/resource/SIO_000020</seealso>
    let _000020 = Prefixed_Name(SIO, "000020") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"material boundary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000022">http://semanticscience.org/resource/SIO_000022</seealso>
    let _000022 = Prefixed_Name(SIO, "000022") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000026">http://semanticscience.org/resource/SIO_000026</seealso>
    let _000026 = Prefixed_Name(SIO, "000026") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000027">http://semanticscience.org/resource/SIO_000027</seealso>
    let _000027 = Prefixed_Name(SIO, "000027") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000028">http://semanticscience.org/resource/SIO_000028</seealso>
    let _000028 = Prefixed_Name(SIO, "000028") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is time boundary of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000029">http://semanticscience.org/resource/SIO_000029</seealso>
    let _000029 = Prefixed_Name(SIO, "000029") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biopolymer sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000030">http://semanticscience.org/resource/SIO_000030</seealso>
    let _000030 = Prefixed_Name(SIO, "000030") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"start date"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000031">http://semanticscience.org/resource/SIO_000031</seealso>
    let _000031 = Prefixed_Name(SIO, "000031") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"end date"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000032">http://semanticscience.org/resource/SIO_000032</seealso>
    let _000032 = Prefixed_Name(SIO, "000032") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process status"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000033">http://semanticscience.org/resource/SIO_000033</seealso>
    let _000033 = Prefixed_Name(SIO, "000033") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"completed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000034">http://semanticscience.org/resource/SIO_000034</seealso>
    let _000034 = Prefixed_Name(SIO, "000034") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ongoing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000035">http://semanticscience.org/resource/SIO_000035</seealso>
    let _000035 = Prefixed_Name(SIO, "000035") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"predicted"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000036">http://semanticscience.org/resource/SIO_000036</seealso>
    let _000036 = Prefixed_Name(SIO, "000036") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000037">http://semanticscience.org/resource/SIO_000037</seealso>
    let _000037 = Prefixed_Name(SIO, "000037") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"1D extent quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000038">http://semanticscience.org/resource/SIO_000038</seealso>
    let _000038 = Prefixed_Name(SIO, "000038") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"depth"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000039">http://semanticscience.org/resource/SIO_000039</seealso>
    let _000039 = Prefixed_Name(SIO, "000039") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"height"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000040">http://semanticscience.org/resource/SIO_000040</seealso>
    let _000040 = Prefixed_Name(SIO, "000040") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"length"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000041">http://semanticscience.org/resource/SIO_000041</seealso>
    let _000041 = Prefixed_Name(SIO, "000041") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"width"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000042">http://semanticscience.org/resource/SIO_000042</seealso>
    let _000042 = Prefixed_Name(SIO, "000042") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thickness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000043">http://semanticscience.org/resource/SIO_000043</seealso>
    let _000043 = Prefixed_Name(SIO, "000043") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"2D extent quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000044">http://semanticscience.org/resource/SIO_000044</seealso>
    let _000044 = Prefixed_Name(SIO, "000044") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"area"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000045">http://semanticscience.org/resource/SIO_000045</seealso>
    let _000045 = Prefixed_Name(SIO, "000045") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"length of perimeter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000046">http://semanticscience.org/resource/SIO_000046</seealso>
    let _000046 = Prefixed_Name(SIO, "000046") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"circumference"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000047">http://semanticscience.org/resource/SIO_000047</seealso>
    let _000047 = Prefixed_Name(SIO, "000047") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3D extent quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000048">http://semanticscience.org/resource/SIO_000048</seealso>
    let _000048 = Prefixed_Name(SIO, "000048") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000049">http://semanticscience.org/resource/SIO_000049</seealso>
    let _000049 = Prefixed_Name(SIO, "000049") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"compositional quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000051">http://semanticscience.org/resource/SIO_000051</seealso>
    let _000051 = Prefixed_Name(SIO, "000051") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000052">http://semanticscience.org/resource/SIO_000052</seealso>
    let _000052 = Prefixed_Name(SIO, "000052") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///
    /// labels<para>"has proper part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000053">http://semanticscience.org/resource/SIO_000053</seealso>
    let _000053 = Prefixed_Name(SIO, "000053") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has boundary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000054">http://semanticscience.org/resource/SIO_000054</seealso>
    let _000054 = Prefixed_Name(SIO, "000054") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shape"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000055">http://semanticscience.org/resource/SIO_000055</seealso>
    let _000055 = Prefixed_Name(SIO, "000055") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000056">http://semanticscience.org/resource/SIO_000056</seealso>
    let _000056 = Prefixed_Name(SIO, "000056") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"orientation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000057">http://semanticscience.org/resource/SIO_000057</seealso>
    let _000057 = Prefixed_Name(SIO, "000057") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has member"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000059">http://semanticscience.org/resource/SIO_000059</seealso>
    let _000059 = Prefixed_Name(SIO, "000059") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is denoted by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000060">http://semanticscience.org/resource/SIO_000060</seealso>
    let _000060 = Prefixed_Name(SIO, "000060") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is located in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000061">http://semanticscience.org/resource/SIO_000061</seealso>
    let _000061 = Prefixed_Name(SIO, "000061") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is participant in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000062">http://semanticscience.org/resource/SIO_000062</seealso>
    let _000062 = Prefixed_Name(SIO, "000062") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is agent in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000063">http://semanticscience.org/resource/SIO_000063</seealso>
    let _000063 = Prefixed_Name(SIO, "000063") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is provider of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000064">http://semanticscience.org/resource/SIO_000064</seealso>
    let _000064 = Prefixed_Name(SIO, "000064") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has provider"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000066">http://semanticscience.org/resource/SIO_000066</seealso>
    let _000066 = Prefixed_Name(SIO, "000066") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"namespace"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000067">http://semanticscience.org/resource/SIO_000067</seealso>
    let _000067 = Prefixed_Name(SIO, "000067") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000068">http://semanticscience.org/resource/SIO_000068</seealso>
    let _000068 = Prefixed_Name(SIO, "000068") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000069">http://semanticscience.org/resource/SIO_000069</seealso>
    let _000069 = Prefixed_Name(SIO, "000069") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measurement value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000070">http://semanticscience.org/resource/SIO_000070</seealso>
    let _000070 = Prefixed_Name(SIO, "000070") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000071">http://semanticscience.org/resource/SIO_000071</seealso>
    let _000071 = Prefixed_Name(SIO, "000071") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cartesian coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000072">http://semanticscience.org/resource/SIO_000072</seealso>
    let _000072 = Prefixed_Name(SIO, "000072") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000073">http://semanticscience.org/resource/SIO_000073</seealso>
    let _000073 = Prefixed_Name(SIO, "000073") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit of measurement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000074">http://semanticscience.org/resource/SIO_000074</seealso>
    let _000074 = Prefixed_Name(SIO, "000074") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mathematical entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000075">http://semanticscience.org/resource/SIO_000075</seealso>
    let _000075 = Prefixed_Name(SIO, "000075") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plan"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000076">http://semanticscience.org/resource/SIO_000076</seealso>
    let _000076 = Prefixed_Name(SIO, "000076") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"generic name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000077">http://semanticscience.org/resource/SIO_000077</seealso>
    let _000077 = Prefixed_Name(SIO, "000077") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"language entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000078">http://semanticscience.org/resource/SIO_000078</seealso>
    let _000078 = Prefixed_Name(SIO, "000078") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"visual language entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000079">http://semanticscience.org/resource/SIO_000079</seealso>
    let _000079 = Prefixed_Name(SIO, "000079") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"figure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000080">http://semanticscience.org/resource/SIO_000080</seealso>
    let _000080 = Prefixed_Name(SIO, "000080") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"image"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000081">http://semanticscience.org/resource/SIO_000081</seealso>
    let _000081 = Prefixed_Name(SIO, "000081") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"photograph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000082">http://semanticscience.org/resource/SIO_000082</seealso>
    let _000082 = Prefixed_Name(SIO, "000082") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000083">http://semanticscience.org/resource/SIO_000083</seealso>
    let _000083 = Prefixed_Name(SIO, "000083") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"question"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000085">http://semanticscience.org/resource/SIO_000085</seealso>
    let _000085 = Prefixed_Name(SIO, "000085") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publication"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000087">http://semanticscience.org/resource/SIO_000087</seealso>
    let _000087 = Prefixed_Name(SIO, "000087") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"record"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000088">http://semanticscience.org/resource/SIO_000088</seealso>
    let _000088 = Prefixed_Name(SIO, "000088") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data set"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000089">http://semanticscience.org/resource/SIO_000089</seealso>
    let _000089 = Prefixed_Name(SIO, "000089") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000090">http://semanticscience.org/resource/SIO_000090</seealso>
    let _000090 = Prefixed_Name(SIO, "000090") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000091">http://semanticscience.org/resource/SIO_000091</seealso>
    let _000091 = Prefixed_Name(SIO, "000091") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biopolymer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000092">http://semanticscience.org/resource/SIO_000092</seealso>
    let _000092 = Prefixed_Name(SIO, "000092") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///
    /// labels<para>"is proper part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000093">http://semanticscience.org/resource/SIO_000093</seealso>
    let _000093 = Prefixed_Name(SIO, "000093") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"algorithm"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000094">http://semanticscience.org/resource/SIO_000094</seealso>
    let _000094 = Prefixed_Name(SIO, "000094") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is member of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000095">http://semanticscience.org/resource/SIO_000095</seealso>
    let _000095 = Prefixed_Name(SIO, "000095") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is boundary of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000096">http://semanticscience.org/resource/SIO_000096</seealso>
    let _000096 = Prefixed_Name(SIO, "000096") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000097">http://semanticscience.org/resource/SIO_000097</seealso>
    let _000097 = Prefixed_Name(SIO, "000097") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software method"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000098">http://semanticscience.org/resource/SIO_000098</seealso>
    let _000098 = Prefixed_Name(SIO, "000098") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software module"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000099">http://semanticscience.org/resource/SIO_000099</seealso>
    let _000099 = Prefixed_Name(SIO, "000099") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software library"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000100">http://semanticscience.org/resource/SIO_000100</seealso>
    let _000100 = Prefixed_Name(SIO, "000100") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software application"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000101">http://semanticscience.org/resource/SIO_000101</seealso>
    let _000101 = Prefixed_Name(SIO, "000101") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software interpreter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000102">http://semanticscience.org/resource/SIO_000102</seealso>
    let _000102 = Prefixed_Name(SIO, "000102") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software script"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000103">http://semanticscience.org/resource/SIO_000103</seealso>
    let _000103 = Prefixed_Name(SIO, "000103") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000104">http://semanticscience.org/resource/SIO_000104</seealso>
    let _000104 = Prefixed_Name(SIO, "000104") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"symbol"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000105">http://semanticscience.org/resource/SIO_000105</seealso>
    let _000105 = Prefixed_Name(SIO, "000105") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"book"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000106">http://semanticscience.org/resource/SIO_000106</seealso>
    let _000106 = Prefixed_Name(SIO, "000106") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chapter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000107">http://semanticscience.org/resource/SIO_000107</seealso>
    let _000107 = Prefixed_Name(SIO, "000107") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"character"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000108">http://semanticscience.org/resource/SIO_000108</seealso>
    let _000108 = Prefixed_Name(SIO, "000108") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"novel"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000109">http://semanticscience.org/resource/SIO_000109</seealso>
    let _000109 = Prefixed_Name(SIO, "000109") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"paragraph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000110">http://semanticscience.org/resource/SIO_000110</seealso>
    let _000110 = Prefixed_Name(SIO, "000110") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000111">http://semanticscience.org/resource/SIO_000111</seealso>
    let _000111 = Prefixed_Name(SIO, "000111") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capability"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000112">http://semanticscience.org/resource/SIO_000112</seealso>
    let _000112 = Prefixed_Name(SIO, "000112") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sentence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000113">http://semanticscience.org/resource/SIO_000113</seealso>
    let _000113 = Prefixed_Name(SIO, "000113") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"word"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000114">http://semanticscience.org/resource/SIO_000114</seealso>
    let _000114 = Prefixed_Name(SIO, "000114") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000115">http://semanticscience.org/resource/SIO_000115</seealso>
    let _000115 = Prefixed_Name(SIO, "000115") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000116">http://semanticscience.org/resource/SIO_000116</seealso>
    let _000116 = Prefixed_Name(SIO, "000116") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000117">http://semanticscience.org/resource/SIO_000117</seealso>
    let _000117 = Prefixed_Name(SIO, "000117") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000118">http://semanticscience.org/resource/SIO_000118</seealso>
    let _000118 = Prefixed_Name(SIO, "000118") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brand name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000119">http://semanticscience.org/resource/SIO_000119</seealso>
    let _000119 = Prefixed_Name(SIO, "000119") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scientific name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000120">http://semanticscience.org/resource/SIO_000120</seealso>
    let _000120 = Prefixed_Name(SIO, "000120") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"magazine"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000121">http://semanticscience.org/resource/SIO_000121</seealso>
    let _000121 = Prefixed_Name(SIO, "000121") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"synonym"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000122">http://semanticscience.org/resource/SIO_000122</seealso>
    let _000122 = Prefixed_Name(SIO, "000122") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antonym"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000123">http://semanticscience.org/resource/SIO_000123</seealso>
    let _000123 = Prefixed_Name(SIO, "000123") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000124</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypernym"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000124">http://semanticscience.org/resource/SIO_000124</seealso>
    let _000124 = Prefixed_Name(SIO, "000124") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hyponym"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000125">http://semanticscience.org/resource/SIO_000125</seealso>
    let _000125 = Prefixed_Name(SIO, "000125") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000126</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"homonym"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000126">http://semanticscience.org/resource/SIO_000126</seealso>
    let _000126 = Prefixed_Name(SIO, "000126") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000127</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"workflow"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000127">http://semanticscience.org/resource/SIO_000127</seealso>
    let _000127 = Prefixed_Name(SIO, "000127") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000128</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is contained in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000128">http://semanticscience.org/resource/SIO_000128</seealso>
    let _000128 = Prefixed_Name(SIO, "000128") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ontology document"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000129">http://semanticscience.org/resource/SIO_000129</seealso>
    let _000129 = Prefixed_Name(SIO, "000129") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000130</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pattern"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000130">http://semanticscience.org/resource/SIO_000130</seealso>
    let _000130 = Prefixed_Name(SIO, "000130") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence motif"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000131">http://semanticscience.org/resource/SIO_000131</seealso>
    let _000131 = Prefixed_Name(SIO, "000131") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has participant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000132">http://semanticscience.org/resource/SIO_000132</seealso>
    let _000132 = Prefixed_Name(SIO, "000132") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000133</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000133">http://semanticscience.org/resource/SIO_000133</seealso>
    let _000133 = Prefixed_Name(SIO, "000133") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000135</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"definition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000135">http://semanticscience.org/resource/SIO_000135</seealso>
    let _000135 = Prefixed_Name(SIO, "000135") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000136</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"description"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000136">http://semanticscience.org/resource/SIO_000136</seealso>
    let _000136 = Prefixed_Name(SIO, "000136") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000137</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"category"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000137">http://semanticscience.org/resource/SIO_000137</seealso>
    let _000137 = Prefixed_Name(SIO, "000137") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000138</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"class"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000138">http://semanticscience.org/resource/SIO_000138</seealso>
    let _000138 = Prefixed_Name(SIO, "000138") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has agent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000139">http://semanticscience.org/resource/SIO_000139</seealso>
    let _000139 = Prefixed_Name(SIO, "000139") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"web service"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000140">http://semanticscience.org/resource/SIO_000140</seealso>
    let _000140 = Prefixed_Name(SIO, "000140") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"criterion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000141">http://semanticscience.org/resource/SIO_000141</seealso>
    let _000141 = Prefixed_Name(SIO, "000141") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inclusion criterion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000142">http://semanticscience.org/resource/SIO_000142</seealso>
    let _000142 = Prefixed_Name(SIO, "000142") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000143</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exclusion criterion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000143">http://semanticscience.org/resource/SIO_000143</seealso>
    let _000143 = Prefixed_Name(SIO, "000143") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"parameter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000144">http://semanticscience.org/resource/SIO_000144</seealso>
    let _000144 = Prefixed_Name(SIO, "000144") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000145</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is location of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000145">http://semanticscience.org/resource/SIO_000145</seealso>
    let _000145 = Prefixed_Name(SIO, "000145") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000146">http://semanticscience.org/resource/SIO_000146</seealso>
    let _000146 = Prefixed_Name(SIO, "000146") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000147</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"keyword"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000147">http://semanticscience.org/resource/SIO_000147</seealso>
    let _000147 = Prefixed_Name(SIO, "000147") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000148">http://semanticscience.org/resource/SIO_000148</seealso>
    let _000148 = Prefixed_Name(SIO, "000148") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000150</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"list"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000150">http://semanticscience.org/resource/SIO_000150</seealso>
    let _000150 = Prefixed_Name(SIO, "000150") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000151</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"manuscript"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000151">http://semanticscience.org/resource/SIO_000151</seealso>
    let _000151 = Prefixed_Name(SIO, "000151") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000152</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"note"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000152">http://semanticscience.org/resource/SIO_000152</seealso>
    let _000152 = Prefixed_Name(SIO, "000152") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000153</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000153">http://semanticscience.org/resource/SIO_000153</seealso>
    let _000153 = Prefixed_Name(SIO, "000153") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000154</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"article"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000154">http://semanticscience.org/resource/SIO_000154</seealso>
    let _000154 = Prefixed_Name(SIO, "000154") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000155</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"blog"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000155">http://semanticscience.org/resource/SIO_000155</seealso>
    let _000155 = Prefixed_Name(SIO, "000155") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000156</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"book volume"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000156">http://semanticscience.org/resource/SIO_000156</seealso>
    let _000156 = Prefixed_Name(SIO, "000156") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000157</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conference proceedings"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000157">http://semanticscience.org/resource/SIO_000157</seealso>
    let _000157 = Prefixed_Name(SIO, "000157") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000158</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"book series"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000158">http://semanticscience.org/resource/SIO_000158</seealso>
    let _000158 = Prefixed_Name(SIO, "000158") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000159</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"edited publication"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000159">http://semanticscience.org/resource/SIO_000159</seealso>
    let _000159 = Prefixed_Name(SIO, "000159") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000160</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"journal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000160">http://semanticscience.org/resource/SIO_000160</seealso>
    let _000160 = Prefixed_Name(SIO, "000160") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000161</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"manual"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000161">http://semanticscience.org/resource/SIO_000161</seealso>
    let _000161 = Prefixed_Name(SIO, "000161") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000162</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"periodical"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000162">http://semanticscience.org/resource/SIO_000162</seealso>
    let _000162 = Prefixed_Name(SIO, "000162") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000163</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"newspaper"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000163">http://semanticscience.org/resource/SIO_000163</seealso>
    let _000163 = Prefixed_Name(SIO, "000163") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000164</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"technical report"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000164">http://semanticscience.org/resource/SIO_000164</seealso>
    let _000164 = Prefixed_Name(SIO, "000164") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thesis document"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000165">http://semanticscience.org/resource/SIO_000165</seealso>
    let _000165 = Prefixed_Name(SIO, "000165") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000166</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"honor's thesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000166">http://semanticscience.org/resource/SIO_000166</seealso>
    let _000166 = Prefixed_Name(SIO, "000166") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000167</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"master's thesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000167">http://semanticscience.org/resource/SIO_000167</seealso>
    let _000167 = Prefixed_Name(SIO, "000167") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000168</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phd thesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000168">http://semanticscience.org/resource/SIO_000168</seealso>
    let _000168 = Prefixed_Name(SIO, "000168") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"booklet"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000169">http://semanticscience.org/resource/SIO_000169</seealso>
    let _000169 = Prefixed_Name(SIO, "000169") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000170</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000170">http://semanticscience.org/resource/SIO_000170</seealso>
    let _000170 = Prefixed_Name(SIO, "000170") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000171">http://semanticscience.org/resource/SIO_000171</seealso>
    let _000171 = Prefixed_Name(SIO, "000171") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000172</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"address"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000172">http://semanticscience.org/resource/SIO_000172</seealso>
    let _000172 = Prefixed_Name(SIO, "000172") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000173</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affiliation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000173">http://semanticscience.org/resource/SIO_000173</seealso>
    let _000173 = Prefixed_Name(SIO, "000173") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000174</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"citation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000174">http://semanticscience.org/resource/SIO_000174</seealso>
    let _000174 = Prefixed_Name(SIO, "000174") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000175</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000175">http://semanticscience.org/resource/SIO_000175</seealso>
    let _000175 = Prefixed_Name(SIO, "000175") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reference"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000176">http://semanticscience.org/resource/SIO_000176</seealso>
    let _000176 = Prefixed_Name(SIO, "000176") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000177</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"page range"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000177">http://semanticscience.org/resource/SIO_000177</seealso>
    let _000177 = Prefixed_Name(SIO, "000177") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"page total"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000178">http://semanticscience.org/resource/SIO_000178</seealso>
    let _000178 = Prefixed_Name(SIO, "000178") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000179">http://semanticscience.org/resource/SIO_000179</seealso>
    let _000179 = Prefixed_Name(SIO, "000179") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"language label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000180">http://semanticscience.org/resource/SIO_000180</seealso>
    let _000180 = Prefixed_Name(SIO, "000180") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000181</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"first name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000181">http://semanticscience.org/resource/SIO_000181</seealso>
    let _000181 = Prefixed_Name(SIO, "000181") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"last name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000182">http://semanticscience.org/resource/SIO_000182</seealso>
    let _000182 = Prefixed_Name(SIO, "000182") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"personal name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000183">http://semanticscience.org/resource/SIO_000183</seealso>
    let _000183 = Prefixed_Name(SIO, "000183") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000184">http://semanticscience.org/resource/SIO_000184</seealso>
    let _000184 = Prefixed_Name(SIO, "000184") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000185">http://semanticscience.org/resource/SIO_000185</seealso>
    let _000185 = Prefixed_Name(SIO, "000185") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"document version"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000186">http://semanticscience.org/resource/SIO_000186</seealso>
    let _000186 = Prefixed_Name(SIO, "000186") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000188</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abstract section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000188">http://semanticscience.org/resource/SIO_000188</seealso>
    let _000188 = Prefixed_Name(SIO, "000188") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000189</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acknowledgements section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000189">http://semanticscience.org/resource/SIO_000189</seealso>
    let _000189 = Prefixed_Name(SIO, "000189") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000190</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author contribution section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000190">http://semanticscience.org/resource/SIO_000190</seealso>
    let _000190 = Prefixed_Name(SIO, "000190") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000191</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000191">http://semanticscience.org/resource/SIO_000191</seealso>
    let _000191 = Prefixed_Name(SIO, "000191") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000192</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bibliography section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000192">http://semanticscience.org/resource/SIO_000192</seealso>
    let _000192 = Prefixed_Name(SIO, "000192") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000193</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"copyright section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000193">http://semanticscience.org/resource/SIO_000193</seealso>
    let _000193 = Prefixed_Name(SIO, "000193") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000194</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"correspondence section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000194">http://semanticscience.org/resource/SIO_000194</seealso>
    let _000194 = Prefixed_Name(SIO, "000194") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"discussion section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000195">http://semanticscience.org/resource/SIO_000195</seealso>
    let _000195 = Prefixed_Name(SIO, "000195") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"introduction section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000196">http://semanticscience.org/resource/SIO_000196</seealso>
    let _000196 = Prefixed_Name(SIO, "000196") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"materials and methods section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000197">http://semanticscience.org/resource/SIO_000197</seealso>
    let _000197 = Prefixed_Name(SIO, "000197") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000198</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"materials section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000198">http://semanticscience.org/resource/SIO_000198</seealso>
    let _000198 = Prefixed_Name(SIO, "000198") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000199</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"methods section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000199">http://semanticscience.org/resource/SIO_000199</seealso>
    let _000199 = Prefixed_Name(SIO, "000199") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000200</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"results section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000200">http://semanticscience.org/resource/SIO_000200</seealso>
    let _000200 = Prefixed_Name(SIO, "000200") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table of contents"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000201">http://semanticscience.org/resource/SIO_000201</seealso>
    let _000201 = Prefixed_Name(SIO, "000201") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000202">http://semanticscience.org/resource/SIO_000202</seealso>
    let _000202 = Prefixed_Name(SIO, "000202") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is connected to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000203">http://semanticscience.org/resource/SIO_000203</seealso>
    let _000203 = Prefixed_Name(SIO, "000203") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000204</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is adjacent to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000204">http://semanticscience.org/resource/SIO_000204</seealso>
    let _000204 = Prefixed_Name(SIO, "000204") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000205</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is represented by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000205">http://semanticscience.org/resource/SIO_000205</seealso>
    let _000205 = Prefixed_Name(SIO, "000205") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000206</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is supported by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000206">http://semanticscience.org/resource/SIO_000206</seealso>
    let _000206 = Prefixed_Name(SIO, "000206") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000207</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is disputed by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000207">http://semanticscience.org/resource/SIO_000207</seealso>
    let _000207 = Prefixed_Name(SIO, "000207") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000208</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is supporting evidence for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000208">http://semanticscience.org/resource/SIO_000208</seealso>
    let _000208 = Prefixed_Name(SIO, "000208") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000209</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is disputing evidence for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000209">http://semanticscience.org/resource/SIO_000209</seealso>
    let _000209 = Prefixed_Name(SIO, "000209") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"represents"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000210">http://semanticscience.org/resource/SIO_000210</seealso>
    let _000210 = Prefixed_Name(SIO, "000210") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000211</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is positionally after"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000211">http://semanticscience.org/resource/SIO_000211</seealso>
    let _000211 = Prefixed_Name(SIO, "000211") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000212</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is referred to by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000212">http://semanticscience.org/resource/SIO_000212</seealso>
    let _000212 = Prefixed_Name(SIO, "000212") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000213</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has concretization"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000213">http://semanticscience.org/resource/SIO_000213</seealso>
    let _000213 = Prefixed_Name(SIO, "000213") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000214</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is concretization of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000214">http://semanticscience.org/resource/SIO_000214</seealso>
    let _000214 = Prefixed_Name(SIO, "000214") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000215</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is measurement value of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000215">http://semanticscience.org/resource/SIO_000215</seealso>
    let _000215 = Prefixed_Name(SIO, "000215") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has measurement value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000216">http://semanticscience.org/resource/SIO_000216</seealso>
    let _000216 = Prefixed_Name(SIO, "000216") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000217</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000217">http://semanticscience.org/resource/SIO_000217</seealso>
    let _000217 = Prefixed_Name(SIO, "000217") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is quality of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000218">http://semanticscience.org/resource/SIO_000218</seealso>
    let _000218 = Prefixed_Name(SIO, "000218") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is source of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000219">http://semanticscience.org/resource/SIO_000219</seealso>
    let _000219 = Prefixed_Name(SIO, "000219") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"implies (-&gt;)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000220">http://semanticscience.org/resource/SIO_000220</seealso>
    let _000220 = Prefixed_Name(SIO, "000220") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has unit"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000221">http://semanticscience.org/resource/SIO_000221</seealso>
    let _000221 = Prefixed_Name(SIO, "000221") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is unit of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000222">http://semanticscience.org/resource/SIO_000222</seealso>
    let _000222 = Prefixed_Name(SIO, "000222") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has property"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000223">http://semanticscience.org/resource/SIO_000223</seealso>
    let _000223 = Prefixed_Name(SIO, "000223") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is property of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000224">http://semanticscience.org/resource/SIO_000224</seealso>
    let _000224 = Prefixed_Name(SIO, "000224") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has function"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000225">http://semanticscience.org/resource/SIO_000225</seealso>
    let _000225 = Prefixed_Name(SIO, "000225") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000226</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is function of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000226">http://semanticscience.org/resource/SIO_000226</seealso>
    let _000226 = Prefixed_Name(SIO, "000226") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is role of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000227">http://semanticscience.org/resource/SIO_000227</seealso>
    let _000227 = Prefixed_Name(SIO, "000227") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000228">http://semanticscience.org/resource/SIO_000228</seealso>
    let _000228 = Prefixed_Name(SIO, "000228") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000229</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has output"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000229">http://semanticscience.org/resource/SIO_000229</seealso>
    let _000229 = Prefixed_Name(SIO, "000229") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000230</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has input"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000230">http://semanticscience.org/resource/SIO_000230</seealso>
    let _000230 = Prefixed_Name(SIO, "000230") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is input in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000231">http://semanticscience.org/resource/SIO_000231</seealso>
    let _000231 = Prefixed_Name(SIO, "000231") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is output of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000232">http://semanticscience.org/resource/SIO_000232</seealso>
    let _000232 = Prefixed_Name(SIO, "000232") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is implementation of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000233">http://semanticscience.org/resource/SIO_000233</seealso>
    let _000233 = Prefixed_Name(SIO, "000233") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has implementation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000234">http://semanticscience.org/resource/SIO_000234</seealso>
    let _000234 = Prefixed_Name(SIO, "000234") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has disposition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000235">http://semanticscience.org/resource/SIO_000235</seealso>
    let _000235 = Prefixed_Name(SIO, "000235") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000236</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is disposition of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000236">http://semanticscience.org/resource/SIO_000236</seealso>
    let _000236 = Prefixed_Name(SIO, "000236") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000237</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"namespace label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000237">http://semanticscience.org/resource/SIO_000237</seealso>
    let _000237 = Prefixed_Name(SIO, "000237") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000238</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"logical operator"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000238">http://semanticscience.org/resource/SIO_000238</seealso>
    let _000238 = Prefixed_Name(SIO, "000238") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conjunction (and)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000239">http://semanticscience.org/resource/SIO_000239</seealso>
    let _000239 = Prefixed_Name(SIO, "000239") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000240</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is positionally before"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000240">http://semanticscience.org/resource/SIO_000240</seealso>
    let _000240 = Prefixed_Name(SIO, "000240") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000241</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is directly after"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000241">http://semanticscience.org/resource/SIO_000241</seealso>
    let _000241 = Prefixed_Name(SIO, "000241") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000242</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is directly before"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000242">http://semanticscience.org/resource/SIO_000242</seealso>
    let _000242 = Prefixed_Name(SIO, "000242") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000243</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is causally related with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000243">http://semanticscience.org/resource/SIO_000243</seealso>
    let _000243 = Prefixed_Name(SIO, "000243") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000244</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is derived from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000244">http://semanticscience.org/resource/SIO_000244</seealso>
    let _000244 = Prefixed_Name(SIO, "000244") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000245</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derives into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000245">http://semanticscience.org/resource/SIO_000245</seealso>
    let _000245 = Prefixed_Name(SIO, "000245") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000246</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"immediately derives into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000246">http://semanticscience.org/resource/SIO_000246</seealso>
    let _000246 = Prefixed_Name(SIO, "000246") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000247</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is immediately derived from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000247">http://semanticscience.org/resource/SIO_000247</seealso>
    let _000247 = Prefixed_Name(SIO, "000247") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000248</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"precedes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000248">http://semanticscience.org/resource/SIO_000248</seealso>
    let _000248 = Prefixed_Name(SIO, "000248") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000249</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is preceded by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000249">http://semanticscience.org/resource/SIO_000249</seealso>
    let _000249 = Prefixed_Name(SIO, "000249") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000250</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"immediately precedes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000250">http://semanticscience.org/resource/SIO_000250</seealso>
    let _000250 = Prefixed_Name(SIO, "000250") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000251</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is immediately preceded by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000251">http://semanticscience.org/resource/SIO_000251</seealso>
    let _000251 = Prefixed_Name(SIO, "000251") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000252</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is referenced by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000252">http://semanticscience.org/resource/SIO_000252</seealso>
    let _000252 = Prefixed_Name(SIO, "000252") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000253</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has source"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000253">http://semanticscience.org/resource/SIO_000253</seealso>
    let _000253 = Prefixed_Name(SIO, "000253") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000254</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is annotation of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000254">http://semanticscience.org/resource/SIO_000254</seealso>
    let _000254 = Prefixed_Name(SIO, "000254") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has annotation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000255">http://semanticscience.org/resource/SIO_000255</seealso>
    let _000255 = Prefixed_Name(SIO, "000255") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"proposition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000256">http://semanticscience.org/resource/SIO_000256</seealso>
    let _000256 = Prefixed_Name(SIO, "000256") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dimensionless quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000257">http://semanticscience.org/resource/SIO_000257</seealso>
    let _000257 = Prefixed_Name(SIO, "000257") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000258</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dimensional quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000258">http://semanticscience.org/resource/SIO_000258</seealso>
    let _000258 = Prefixed_Name(SIO, "000258") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000259</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000259">http://semanticscience.org/resource/SIO_000259</seealso>
    let _000259 = Prefixed_Name(SIO, "000259") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000261</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"premise"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000261">http://semanticscience.org/resource/SIO_000261</seealso>
    let _000261 = Prefixed_Name(SIO, "000261") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conclusion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000262">http://semanticscience.org/resource/SIO_000262</seealso>
    let _000262 = Prefixed_Name(SIO, "000262") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000263</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deductive argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000263">http://semanticscience.org/resource/SIO_000263</seealso>
    let _000263 = Prefixed_Name(SIO, "000263") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000264</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inductive argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000264">http://semanticscience.org/resource/SIO_000264</seealso>
    let _000264 = Prefixed_Name(SIO, "000264") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000265</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sound argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000265">http://semanticscience.org/resource/SIO_000265</seealso>
    let _000265 = Prefixed_Name(SIO, "000265") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000266</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"valid argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000266">http://semanticscience.org/resource/SIO_000266</seealso>
    let _000266 = Prefixed_Name(SIO, "000266") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000267</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"invalid argument"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000267">http://semanticscience.org/resource/SIO_000267</seealso>
    let _000267 = Prefixed_Name(SIO, "000267") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"truth value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000268">http://semanticscience.org/resource/SIO_000268</seealso>
    let _000268 = Prefixed_Name(SIO, "000268") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000269</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"true"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000269">http://semanticscience.org/resource/SIO_000269</seealso>
    let _000269 = Prefixed_Name(SIO, "000269") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000270</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"false"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000270">http://semanticscience.org/resource/SIO_000270</seealso>
    let _000270 = Prefixed_Name(SIO, "000270") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000272</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is variant of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000272">http://semanticscience.org/resource/SIO_000272</seealso>
    let _000272 = Prefixed_Name(SIO, "000272") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000273</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has direct part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000273">http://semanticscience.org/resource/SIO_000273</seealso>
    let _000273 = Prefixed_Name(SIO, "000273") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000274</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is prior version of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000274">http://semanticscience.org/resource/SIO_000274</seealso>
    let _000274 = Prefixed_Name(SIO, "000274") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000275</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"term"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000275">http://semanticscience.org/resource/SIO_000275</seealso>
    let _000275 = Prefixed_Name(SIO, "000275") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"emotion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000276">http://semanticscience.org/resource/SIO_000276</seealso>
    let _000276 = Prefixed_Name(SIO, "000276") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000277</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cites"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000277">http://semanticscience.org/resource/SIO_000277</seealso>
    let _000277 = Prefixed_Name(SIO, "000277") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is cited by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000278">http://semanticscience.org/resource/SIO_000278</seealso>
    let _000278 = Prefixed_Name(SIO, "000278") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000279</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000279">http://semanticscience.org/resource/SIO_000279</seealso>
    let _000279 = Prefixed_Name(SIO, "000279") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disjunction (or)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000280">http://semanticscience.org/resource/SIO_000280</seealso>
    let _000280 = Prefixed_Name(SIO, "000280") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negation (not)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000281">http://semanticscience.org/resource/SIO_000281</seealso>
    let _000281 = Prefixed_Name(SIO, "000281") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000282</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exclusive disjunction (xor)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000282">http://semanticscience.org/resource/SIO_000282</seealso>
    let _000282 = Prefixed_Name(SIO, "000282") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is similar to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000283">http://semanticscience.org/resource/SIO_000283</seealso>
    let _000283 = Prefixed_Name(SIO, "000283") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypothesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000284">http://semanticscience.org/resource/SIO_000284</seealso>
    let _000284 = Prefixed_Name(SIO, "000284") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"academic organization"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000285">http://semanticscience.org/resource/SIO_000285</seealso>
    let _000285 = Prefixed_Name(SIO, "000285") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000286</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subsequent version of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000286">http://semanticscience.org/resource/SIO_000286</seealso>
    let _000286 = Prefixed_Name(SIO, "000286") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000287</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social relation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000287">http://semanticscience.org/resource/SIO_000287</seealso>
    let _000287 = Prefixed_Name(SIO, "000287") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000288</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is covalently connected to (transitive)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000288">http://semanticscience.org/resource/SIO_000288</seealso>
    let _000288 = Prefixed_Name(SIO, "000288") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000289</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"set"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000289">http://semanticscience.org/resource/SIO_000289</seealso>
    let _000289 = Prefixed_Name(SIO, "000289") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000290</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"university"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000290">http://semanticscience.org/resource/SIO_000290</seealso>
    let _000290 = Prefixed_Name(SIO, "000290") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000291</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has target"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000291">http://semanticscience.org/resource/SIO_000291</seealso>
    let _000291 = Prefixed_Name(SIO, "000291") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000292</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is target in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000292">http://semanticscience.org/resource/SIO_000292</seealso>
    let _000292 = Prefixed_Name(SIO, "000292") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000293</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is weakly interacting with (transitive)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000293">http://semanticscience.org/resource/SIO_000293</seealso>
    let _000293 = Prefixed_Name(SIO, "000293") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000294</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is causally related to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000294">http://semanticscience.org/resource/SIO_000294</seealso>
    let _000294 = Prefixed_Name(SIO, "000294") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection of documents"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000295">http://semanticscience.org/resource/SIO_000295</seealso>
    let _000295 = Prefixed_Name(SIO, "000295") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"website"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000296">http://semanticscience.org/resource/SIO_000296</seealso>
    let _000296 = Prefixed_Name(SIO, "000296") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000297</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"movie"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000297">http://semanticscience.org/resource/SIO_000297</seealso>
    let _000297 = Prefixed_Name(SIO, "000297") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000298</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"excerpt"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000298">http://semanticscience.org/resource/SIO_000298</seealso>
    let _000298 = Prefixed_Name(SIO, "000298") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000299</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quote"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000299">http://semanticscience.org/resource/SIO_000299</seealso>
    let _000299 = Prefixed_Name(SIO, "000299") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000300">http://semanticscience.org/resource/SIO_000300</seealso>
    let _000300 = Prefixed_Name(SIO, "000300") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic image"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000301">http://semanticscience.org/resource/SIO_000301</seealso>
    let _000301 = Prefixed_Name(SIO, "000301") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"web page"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000302">http://semanticscience.org/resource/SIO_000302</seealso>
    let _000302 = Prefixed_Name(SIO, "000302") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"email"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000304">http://semanticscience.org/resource/SIO_000304</seealso>
    let _000304 = Prefixed_Name(SIO, "000304") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000305</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000305">http://semanticscience.org/resource/SIO_000305</seealso>
    let _000305 = Prefixed_Name(SIO, "000305") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"letter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000306">http://semanticscience.org/resource/SIO_000306</seealso>
    let _000306 = Prefixed_Name(SIO, "000306") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"normality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000307">http://semanticscience.org/resource/SIO_000307</seealso>
    let _000307 = Prefixed_Name(SIO, "000307") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"edition number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000308">http://semanticscience.org/resource/SIO_000308</seealso>
    let _000308 = Prefixed_Name(SIO, "000308") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000309">http://semanticscience.org/resource/SIO_000309</seealso>
    let _000309 = Prefixed_Name(SIO, "000309") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is direct part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000310">http://semanticscience.org/resource/SIO_000310</seealso>
    let _000310 = Prefixed_Name(SIO, "000310") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is product of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000311">http://semanticscience.org/resource/SIO_000311</seealso>
    let _000311 = Prefixed_Name(SIO, "000311") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000312</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has product"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000312">http://semanticscience.org/resource/SIO_000312</seealso>
    let _000312 = Prefixed_Name(SIO, "000312") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000313</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is component part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000313">http://semanticscience.org/resource/SIO_000313</seealso>
    let _000313 = Prefixed_Name(SIO, "000313") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000314</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polymer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000314">http://semanticscience.org/resource/SIO_000314</seealso>
    let _000314 = Prefixed_Name(SIO, "000314") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000315</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"functional specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000315">http://semanticscience.org/resource/SIO_000315</seealso>
    let _000315 = Prefixed_Name(SIO, "000315") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"design specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000316">http://semanticscience.org/resource/SIO_000316</seealso>
    let _000316 = Prefixed_Name(SIO, "000316") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000317</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000317">http://semanticscience.org/resource/SIO_000317</seealso>
    let _000317 = Prefixed_Name(SIO, "000317") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000318</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000318">http://semanticscience.org/resource/SIO_000318</seealso>
    let _000318 = Prefixed_Name(SIO, "000318") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000319</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"latitude"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000319">http://semanticscience.org/resource/SIO_000319</seealso>
    let _000319 = Prefixed_Name(SIO, "000319") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coordinate system"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000320">http://semanticscience.org/resource/SIO_000320</seealso>
    let _000320 = Prefixed_Name(SIO, "000320") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000321</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cartesian coordinate system"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000321">http://semanticscience.org/resource/SIO_000321</seealso>
    let _000321 = Prefixed_Name(SIO, "000321") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000322</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is spatiotemporally related to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000322">http://semanticscience.org/resource/SIO_000322</seealso>
    let _000322 = Prefixed_Name(SIO, "000322") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is surrounded by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000323">http://semanticscience.org/resource/SIO_000323</seealso>
    let _000323 = Prefixed_Name(SIO, "000323") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000324</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"surrounds"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000324">http://semanticscience.org/resource/SIO_000324</seealso>
    let _000324 = Prefixed_Name(SIO, "000324") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"overlaps with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000325">http://semanticscience.org/resource/SIO_000325</seealso>
    let _000325 = Prefixed_Name(SIO, "000325") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000326</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"concept"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000326">http://semanticscience.org/resource/SIO_000326</seealso>
    let _000326 = Prefixed_Name(SIO, "000326") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000327</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar coordinate system"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000327">http://semanticscience.org/resource/SIO_000327</seealso>
    let _000327 = Prefixed_Name(SIO, "000327") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000328</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positional identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000328">http://semanticscience.org/resource/SIO_000328</seealso>
    let _000328 = Prefixed_Name(SIO, "000328") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000329</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cylindrical coordinate system"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000329">http://semanticscience.org/resource/SIO_000329</seealso>
    let _000329 = Prefixed_Name(SIO, "000329") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000330</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spherical coordinate system"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000330">http://semanticscience.org/resource/SIO_000330</seealso>
    let _000330 = Prefixed_Name(SIO, "000330") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000331</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OWL ontology"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000331">http://semanticscience.org/resource/SIO_000331</seealso>
    let _000331 = Prefixed_Name(SIO, "000331") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000332</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is about"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000332">http://semanticscience.org/resource/SIO_000332</seealso>
    let _000332 = Prefixed_Name(SIO, "000332") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000333</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3D cartesian coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000333">http://semanticscience.org/resource/SIO_000333</seealso>
    let _000333 = Prefixed_Name(SIO, "000333") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000334</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is covalently connected to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000334">http://semanticscience.org/resource/SIO_000334</seealso>
    let _000334 = Prefixed_Name(SIO, "000334") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is weakly interacting with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000335">http://semanticscience.org/resource/SIO_000335</seealso>
    let _000335 = Prefixed_Name(SIO, "000335") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"objective"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000337">http://semanticscience.org/resource/SIO_000337</seealso>
    let _000337 = Prefixed_Name(SIO, "000337") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifies"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000338">http://semanticscience.org/resource/SIO_000338</seealso>
    let _000338 = Prefixed_Name(SIO, "000338") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000339</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is specified by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000339">http://semanticscience.org/resource/SIO_000339</seealso>
    let _000339 = Prefixed_Name(SIO, "000339") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"realizable entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000340">http://semanticscience.org/resource/SIO_000340</seealso>
    let _000340 = Prefixed_Name(SIO, "000340") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is manifested as"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000341">http://semanticscience.org/resource/SIO_000341</seealso>
    let _000341 = Prefixed_Name(SIO, "000341") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"term variant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000342">http://semanticscience.org/resource/SIO_000342</seealso>
    let _000342 = Prefixed_Name(SIO, "000342") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to modify"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000343">http://semanticscience.org/resource/SIO_000343</seealso>
    let _000343 = Prefixed_Name(SIO, "000343") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to record"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000344">http://semanticscience.org/resource/SIO_000344</seealso>
    let _000344 = Prefixed_Name(SIO, "000344") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to magnify"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000345">http://semanticscience.org/resource/SIO_000345</seealso>
    let _000345 = Prefixed_Name(SIO, "000345") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to heat"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000346">http://semanticscience.org/resource/SIO_000346</seealso>
    let _000346 = Prefixed_Name(SIO, "000346") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to cool"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000347">http://semanticscience.org/resource/SIO_000347</seealso>
    let _000347 = Prefixed_Name(SIO, "000347") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000348</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to freeze"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000348">http://semanticscience.org/resource/SIO_000348</seealso>
    let _000348 = Prefixed_Name(SIO, "000348") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000349</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to separate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000349">http://semanticscience.org/resource/SIO_000349</seealso>
    let _000349 = Prefixed_Name(SIO, "000349") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000350</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to ionize"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000350">http://semanticscience.org/resource/SIO_000350</seealso>
    let _000350 = Prefixed_Name(SIO, "000350") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to supply energy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000351">http://semanticscience.org/resource/SIO_000351</seealso>
    let _000351 = Prefixed_Name(SIO, "000351") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is causally related from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000352">http://semanticscience.org/resource/SIO_000352</seealso>
    let _000352 = Prefixed_Name(SIO, "000352") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to observe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000353">http://semanticscience.org/resource/SIO_000353</seealso>
    let _000353 = Prefixed_Name(SIO, "000353") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000354</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dysfunction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000354">http://semanticscience.org/resource/SIO_000354</seealso>
    let _000354 = Prefixed_Name(SIO, "000354") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000355</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"realizes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000355">http://semanticscience.org/resource/SIO_000355</seealso>
    let _000355 = Prefixed_Name(SIO, "000355") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000356</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is realized in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000356">http://semanticscience.org/resource/SIO_000356</seealso>
    let _000356 = Prefixed_Name(SIO, "000356") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000357</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fitness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000357">http://semanticscience.org/resource/SIO_000357</seealso>
    let _000357 = Prefixed_Name(SIO, "000357") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000358">http://semanticscience.org/resource/SIO_000358</seealso>
    let _000358 = Prefixed_Name(SIO, "000358") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"purpose"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000359">http://semanticscience.org/resource/SIO_000359</seealso>
    let _000359 = Prefixed_Name(SIO, "000359") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"belief"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000360">http://semanticscience.org/resource/SIO_000360</seealso>
    let _000360 = Prefixed_Name(SIO, "000360") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"satisfies"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000362">http://semanticscience.org/resource/SIO_000362</seealso>
    let _000362 = Prefixed_Name(SIO, "000362") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000363</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is satisfied by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000363">http://semanticscience.org/resource/SIO_000363</seealso>
    let _000363 = Prefixed_Name(SIO, "000363") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000364</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has creator"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000364">http://semanticscience.org/resource/SIO_000364</seealso>
    let _000364 = Prefixed_Name(SIO, "000364") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000365</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is creator of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000365">http://semanticscience.org/resource/SIO_000365</seealso>
    let _000365 = Prefixed_Name(SIO, "000365") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000366</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000366">http://semanticscience.org/resource/SIO_000366</seealso>
    let _000366 = Prefixed_Name(SIO, "000366") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000367">http://semanticscience.org/resource/SIO_000367</seealso>
    let _000367 = Prefixed_Name(SIO, "000367") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000368</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000368">http://semanticscience.org/resource/SIO_000368</seealso>
    let _000368 = Prefixed_Name(SIO, "000368") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has component part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000369">http://semanticscience.org/resource/SIO_000369</seealso>
    let _000369 = Prefixed_Name(SIO, "000369") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000370</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000370">http://semanticscience.org/resource/SIO_000370</seealso>
    let _000370 = Prefixed_Name(SIO, "000370") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to measure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000371">http://semanticscience.org/resource/SIO_000371</seealso>
    let _000371 = Prefixed_Name(SIO, "000371") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000372</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to inject"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000372">http://semanticscience.org/resource/SIO_000372</seealso>
    let _000372 = Prefixed_Name(SIO, "000372") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000373</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to boil"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000373">http://semanticscience.org/resource/SIO_000373</seealso>
    let _000373 = Prefixed_Name(SIO, "000373") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to reduce energy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000374">http://semanticscience.org/resource/SIO_000374</seealso>
    let _000374 = Prefixed_Name(SIO, "000374") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to supply electricity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000375">http://semanticscience.org/resource/SIO_000375</seealso>
    let _000375 = Prefixed_Name(SIO, "000375") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to change materially"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000376">http://semanticscience.org/resource/SIO_000376</seealso>
    let _000376 = Prefixed_Name(SIO, "000376") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to demagnify"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000377">http://semanticscience.org/resource/SIO_000377</seealso>
    let _000377 = Prefixed_Name(SIO, "000377") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000378</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to change appearance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000378">http://semanticscience.org/resource/SIO_000378</seealso>
    let _000378 = Prefixed_Name(SIO, "000378") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000379</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"perception"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000379">http://semanticscience.org/resource/SIO_000379</seealso>
    let _000379 = Prefixed_Name(SIO, "000379") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000380</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to contain"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000380">http://semanticscience.org/resource/SIO_000380</seealso>
    let _000380 = Prefixed_Name(SIO, "000380") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000381</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to immobilize"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000381">http://semanticscience.org/resource/SIO_000381</seealso>
    let _000381 = Prefixed_Name(SIO, "000381") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000382</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to filter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000382">http://semanticscience.org/resource/SIO_000382</seealso>
    let _000382 = Prefixed_Name(SIO, "000382") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000383</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to excite"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000383">http://semanticscience.org/resource/SIO_000383</seealso>
    let _000383 = Prefixed_Name(SIO, "000383") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to emit"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000384">http://semanticscience.org/resource/SIO_000384</seealso>
    let _000384 = Prefixed_Name(SIO, "000384") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000385</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to change energetically"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000385">http://semanticscience.org/resource/SIO_000385</seealso>
    let _000385 = Prefixed_Name(SIO, "000385") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000386</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to positively charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000386">http://semanticscience.org/resource/SIO_000386</seealso>
    let _000386 = Prefixed_Name(SIO, "000386") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000387</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to negatively charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000387">http://semanticscience.org/resource/SIO_000387</seealso>
    let _000387 = Prefixed_Name(SIO, "000387") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000388</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to assemble"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000388">http://semanticscience.org/resource/SIO_000388</seealso>
    let _000388 = Prefixed_Name(SIO, "000388") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000389</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to extract"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000389">http://semanticscience.org/resource/SIO_000389</seealso>
    let _000389 = Prefixed_Name(SIO, "000389") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000390">http://semanticscience.org/resource/SIO_000390</seealso>
    let _000390 = Prefixed_Name(SIO, "000390") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000391</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time measurement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000391">http://semanticscience.org/resource/SIO_000391</seealso>
    let _000391 = Prefixed_Name(SIO, "000391") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000392</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to change spatially"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000392">http://semanticscience.org/resource/SIO_000392</seealso>
    let _000392 = Prefixed_Name(SIO, "000392") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patient"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000393">http://semanticscience.org/resource/SIO_000393</seealso>
    let _000393 = Prefixed_Name(SIO, "000393") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000394</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"doctor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000394">http://semanticscience.org/resource/SIO_000394</seealso>
    let _000394 = Prefixed_Name(SIO, "000394") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000395</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to regulate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000395">http://semanticscience.org/resource/SIO_000395</seealso>
    let _000395 = Prefixed_Name(SIO, "000395") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000396</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"file"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000396">http://semanticscience.org/resource/SIO_000396</seealso>
    let _000396 = Prefixed_Name(SIO, "000396") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000397</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to provide"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000397">http://semanticscience.org/resource/SIO_000397</seealso>
    let _000397 = Prefixed_Name(SIO, "000397") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000398</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nurse"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000398">http://semanticscience.org/resource/SIO_000398</seealso>
    let _000398 = Prefixed_Name(SIO, "000398") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000399</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study subject"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000399">http://semanticscience.org/resource/SIO_000399</seealso>
    let _000399 = Prefixed_Name(SIO, "000399") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000400</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"x cartesian coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000400">http://semanticscience.org/resource/SIO_000400</seealso>
    let _000400 = Prefixed_Name(SIO, "000400") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000401</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"y cartesian coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000401">http://semanticscience.org/resource/SIO_000401</seealso>
    let _000401 = Prefixed_Name(SIO, "000401") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000402</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"z cartesian coordinate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000402">http://semanticscience.org/resource/SIO_000402</seealso>
    let _000402 = Prefixed_Name(SIO, "000402") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000403</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study group"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000403">http://semanticscience.org/resource/SIO_000403</seealso>
    let _000403 = Prefixed_Name(SIO, "000403") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000404</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"professor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000404">http://semanticscience.org/resource/SIO_000404</seealso>
    let _000404 = Prefixed_Name(SIO, "000404") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000405</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000405">http://semanticscience.org/resource/SIO_000405</seealso>
    let _000405 = Prefixed_Name(SIO, "000405") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000406</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"academic"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000406">http://semanticscience.org/resource/SIO_000406</seealso>
    let _000406 = Prefixed_Name(SIO, "000406") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000407</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to increase the rate of formation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000407">http://semanticscience.org/resource/SIO_000407</seealso>
    let _000407 = Prefixed_Name(SIO, "000407") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000408</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to investigate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000408">http://semanticscience.org/resource/SIO_000408</seealso>
    let _000408 = Prefixed_Name(SIO, "000408") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000409</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mutual disposition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000409">http://semanticscience.org/resource/SIO_000409</seealso>
    let _000409 = Prefixed_Name(SIO, "000409") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000410</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anger"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000410">http://semanticscience.org/resource/SIO_000410</seealso>
    let _000410 = Prefixed_Name(SIO, "000410") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000411</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000411">http://semanticscience.org/resource/SIO_000411</seealso>
    let _000411 = Prefixed_Name(SIO, "000411") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000412</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"love"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000412">http://semanticscience.org/resource/SIO_000412</seealso>
    let _000412 = Prefixed_Name(SIO, "000412") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000413</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geolegal region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000413">http://semanticscience.org/resource/SIO_000413</seealso>
    let _000413 = Prefixed_Name(SIO, "000413") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000414</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000414">http://semanticscience.org/resource/SIO_000414</seealso>
    let _000414 = Prefixed_Name(SIO, "000414") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000415</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geopolitical region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000415">http://semanticscience.org/resource/SIO_000415</seealso>
    let _000415 = Prefixed_Name(SIO, "000415") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000417</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000417">http://semanticscience.org/resource/SIO_000417</seealso>
    let _000417 = Prefixed_Name(SIO, "000417") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000418</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time instant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000418">http://semanticscience.org/resource/SIO_000418</seealso>
    let _000418 = Prefixed_Name(SIO, "000418") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000419</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"table"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000419">http://semanticscience.org/resource/SIO_000419</seealso>
    let _000419 = Prefixed_Name(SIO, "000419") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000420</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expression"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000420">http://semanticscience.org/resource/SIO_000420</seealso>
    let _000420 = Prefixed_Name(SIO, "000420") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000421</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is expression of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000421">http://semanticscience.org/resource/SIO_000421</seealso>
    let _000421 = Prefixed_Name(SIO, "000421") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000422</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is broader than (t)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000422">http://semanticscience.org/resource/SIO_000422</seealso>
    let _000422 = Prefixed_Name(SIO, "000422") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000423</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scatterplot"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000423">http://semanticscience.org/resource/SIO_000423</seealso>
    let _000423 = Prefixed_Name(SIO, "000423") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000424</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is narrower than (t)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000424">http://semanticscience.org/resource/SIO_000424</seealso>
    let _000424 = Prefixed_Name(SIO, "000424") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is generically related with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000425">http://semanticscience.org/resource/SIO_000425</seealso>
    let _000425 = Prefixed_Name(SIO, "000425") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000426</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is manifestation of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000426">http://semanticscience.org/resource/SIO_000426</seealso>
    let _000426 = Prefixed_Name(SIO, "000426") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000427</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is narrower than"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000427">http://semanticscience.org/resource/SIO_000427</seealso>
    let _000427 = Prefixed_Name(SIO, "000427") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000428</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"year"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000428">http://semanticscience.org/resource/SIO_000428</seealso>
    let _000428 = Prefixed_Name(SIO, "000428") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000429</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"month"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000429">http://semanticscience.org/resource/SIO_000429</seealso>
    let _000429 = Prefixed_Name(SIO, "000429") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000430</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"day"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000430">http://semanticscience.org/resource/SIO_000430</seealso>
    let _000430 = Prefixed_Name(SIO, "000430") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000431</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"century"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000431">http://semanticscience.org/resource/SIO_000431</seealso>
    let _000431 = Prefixed_Name(SIO, "000431") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000432</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"millenium"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000432">http://semanticscience.org/resource/SIO_000432</seealso>
    let _000432 = Prefixed_Name(SIO, "000432") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000433</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hour"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000433">http://semanticscience.org/resource/SIO_000433</seealso>
    let _000433 = Prefixed_Name(SIO, "000433") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000434</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000434">http://semanticscience.org/resource/SIO_000434</seealso>
    let _000434 = Prefixed_Name(SIO, "000434") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000435</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"second"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000435">http://semanticscience.org/resource/SIO_000435</seealso>
    let _000435 = Prefixed_Name(SIO, "000435") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000436</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"informational quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000436">http://semanticscience.org/resource/SIO_000436</seealso>
    let _000436 = Prefixed_Name(SIO, "000436") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000437</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"2D cartesian point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000437">http://semanticscience.org/resource/SIO_000437</seealso>
    let _000437 = Prefixed_Name(SIO, "000437") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000438</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"altitude"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000438">http://semanticscience.org/resource/SIO_000438</seealso>
    let _000438 = Prefixed_Name(SIO, "000438") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000439</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"center of mass"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000439">http://semanticscience.org/resource/SIO_000439</seealso>
    let _000439 = Prefixed_Name(SIO, "000439") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000440</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3D cartesian point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000440">http://semanticscience.org/resource/SIO_000440</seealso>
    let _000440 = Prefixed_Name(SIO, "000440") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000441</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"1D cartesian point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000441">http://semanticscience.org/resource/SIO_000441</seealso>
    let _000441 = Prefixed_Name(SIO, "000441") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000442</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"line graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000442">http://semanticscience.org/resource/SIO_000442</seealso>
    let _000442 = Prefixed_Name(SIO, "000442") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000443</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bar graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000443">http://semanticscience.org/resource/SIO_000443</seealso>
    let _000443 = Prefixed_Name(SIO, "000443") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000444</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"horizontal bar graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000444">http://semanticscience.org/resource/SIO_000444</seealso>
    let _000444 = Prefixed_Name(SIO, "000444") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000445</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vertical bar graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000445">http://semanticscience.org/resource/SIO_000445</seealso>
    let _000445 = Prefixed_Name(SIO, "000445") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000446</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stacked bar graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000446">http://semanticscience.org/resource/SIO_000446</seealso>
    let _000446 = Prefixed_Name(SIO, "000446") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000447</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"line-bar graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000447">http://semanticscience.org/resource/SIO_000447</seealso>
    let _000447 = Prefixed_Name(SIO, "000447") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000448</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"figure part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000448">http://semanticscience.org/resource/SIO_000448</seealso>
    let _000448 = Prefixed_Name(SIO, "000448") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000449</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plot"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000449">http://semanticscience.org/resource/SIO_000449</seealso>
    let _000449 = Prefixed_Name(SIO, "000449") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000450</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000450">http://semanticscience.org/resource/SIO_000450</seealso>
    let _000450 = Prefixed_Name(SIO, "000450") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000451</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cartesian coordinate axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000451">http://semanticscience.org/resource/SIO_000451</seealso>
    let _000451 = Prefixed_Name(SIO, "000451") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000452</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"x-axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000452">http://semanticscience.org/resource/SIO_000452</seealso>
    let _000452 = Prefixed_Name(SIO, "000452") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000453</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"y-axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000453">http://semanticscience.org/resource/SIO_000453</seealso>
    let _000453 = Prefixed_Name(SIO, "000453") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000454</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"z-axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000454">http://semanticscience.org/resource/SIO_000454</seealso>
    let _000454 = Prefixed_Name(SIO, "000454") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000455</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"category axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000455">http://semanticscience.org/resource/SIO_000455</seealso>
    let _000455 = Prefixed_Name(SIO, "000455") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000456</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary category axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000456">http://semanticscience.org/resource/SIO_000456</seealso>
    let _000456 = Prefixed_Name(SIO, "000456") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000457</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary category axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000457">http://semanticscience.org/resource/SIO_000457</seealso>
    let _000457 = Prefixed_Name(SIO, "000457") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000458</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000458">http://semanticscience.org/resource/SIO_000458</seealso>
    let _000458 = Prefixed_Name(SIO, "000458") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000459</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000459">http://semanticscience.org/resource/SIO_000459</seealso>
    let _000459 = Prefixed_Name(SIO, "000459") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000460</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000460">http://semanticscience.org/resource/SIO_000460</seealso>
    let _000460 = Prefixed_Name(SIO, "000460") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000461</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scaled value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000461">http://semanticscience.org/resource/SIO_000461</seealso>
    let _000461 = Prefixed_Name(SIO, "000461") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000462</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"linear value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000462">http://semanticscience.org/resource/SIO_000462</seealso>
    let _000462 = Prefixed_Name(SIO, "000462") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000463</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"logarithmic value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000463">http://semanticscience.org/resource/SIO_000463</seealso>
    let _000463 = Prefixed_Name(SIO, "000463") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000464</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data series"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000464">http://semanticscience.org/resource/SIO_000464</seealso>
    let _000464 = Prefixed_Name(SIO, "000464") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000465</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000465">http://semanticscience.org/resource/SIO_000465</seealso>
    let _000465 = Prefixed_Name(SIO, "000465") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000466</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"global maximal stationary point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000466">http://semanticscience.org/resource/SIO_000466</seealso>
    let _000466 = Prefixed_Name(SIO, "000466") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000467</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"global minimal stationary point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000467">http://semanticscience.org/resource/SIO_000467</seealso>
    let _000467 = Prefixed_Name(SIO, "000467") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000468</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legend"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000468">http://semanticscience.org/resource/SIO_000468</seealso>
    let _000468 = Prefixed_Name(SIO, "000468") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000469</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"graph title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000469">http://semanticscience.org/resource/SIO_000469</seealso>
    let _000469 = Prefixed_Name(SIO, "000469") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000470</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000470">http://semanticscience.org/resource/SIO_000470</seealso>
    let _000470 = Prefixed_Name(SIO, "000470") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000471</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000471">http://semanticscience.org/resource/SIO_000471</seealso>
    let _000471 = Prefixed_Name(SIO, "000471") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000472</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scientific data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000472">http://semanticscience.org/resource/SIO_000472</seealso>
    let _000472 = Prefixed_Name(SIO, "000472") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000473</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary graph title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000473">http://semanticscience.org/resource/SIO_000473</seealso>
    let _000473 = Prefixed_Name(SIO, "000473") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000474</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary graph title"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000474">http://semanticscience.org/resource/SIO_000474</seealso>
    let _000474 = Prefixed_Name(SIO, "000474") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000475</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000475">http://semanticscience.org/resource/SIO_000475</seealso>
    let _000475 = Prefixed_Name(SIO, "000475") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000476</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000476">http://semanticscience.org/resource/SIO_000476</seealso>
    let _000476 = Prefixed_Name(SIO, "000476") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000477</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is broader than"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000477">http://semanticscience.org/resource/SIO_000477</seealso>
    let _000477 = Prefixed_Name(SIO, "000477") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000478</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence variant role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000478">http://semanticscience.org/resource/SIO_000478</seealso>
    let _000478 = Prefixed_Name(SIO, "000478") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000479</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variant role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000479">http://semanticscience.org/resource/SIO_000479</seealso>
    let _000479 = Prefixed_Name(SIO, "000479") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000480</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insertion variant role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000480">http://semanticscience.org/resource/SIO_000480</seealso>
    let _000480 = Prefixed_Name(SIO, "000480") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000481</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deletion variant role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000481">http://semanticscience.org/resource/SIO_000481</seealso>
    let _000481 = Prefixed_Name(SIO, "000481") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000482</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is match to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000482">http://semanticscience.org/resource/SIO_000482</seealso>
    let _000482 = Prefixed_Name(SIO, "000482") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000483</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phrase"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000483">http://semanticscience.org/resource/SIO_000483</seealso>
    let _000483 = Prefixed_Name(SIO, "000483") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000484</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is exact match to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000484">http://semanticscience.org/resource/SIO_000484</seealso>
    let _000484 = Prefixed_Name(SIO, "000484") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000485</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000485">http://semanticscience.org/resource/SIO_000485</seealso>
    let _000485 = Prefixed_Name(SIO, "000485") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000486</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mouse"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000486">http://semanticscience.org/resource/SIO_000486</seealso>
    let _000486 = Prefixed_Name(SIO, "000486") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000487</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rat"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000487">http://semanticscience.org/resource/SIO_000487</seealso>
    let _000487 = Prefixed_Name(SIO, "000487") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000488</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"worm"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000488">http://semanticscience.org/resource/SIO_000488</seealso>
    let _000488 = Prefixed_Name(SIO, "000488") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000489</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"e.coli"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000489">http://semanticscience.org/resource/SIO_000489</seealso>
    let _000489 = Prefixed_Name(SIO, "000489") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000490</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is close match to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000490">http://semanticscience.org/resource/SIO_000490</seealso>
    let _000490 = Prefixed_Name(SIO, "000490") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000491</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is broad match to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000491">http://semanticscience.org/resource/SIO_000491</seealso>
    let _000491 = Prefixed_Name(SIO, "000491") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000492</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to consume"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000492">http://semanticscience.org/resource/SIO_000492</seealso>
    let _000492 = Prefixed_Name(SIO, "000492") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000493</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clause"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000493">http://semanticscience.org/resource/SIO_000493</seealso>
    let _000493 = Prefixed_Name(SIO, "000493") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000494</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to actively interact with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000494">http://semanticscience.org/resource/SIO_000494</seealso>
    let _000494 = Prefixed_Name(SIO, "000494") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000495</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is dissimilar to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000495">http://semanticscience.org/resource/SIO_000495</seealso>
    let _000495 = Prefixed_Name(SIO, "000495") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000496</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is opposite to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000496">http://semanticscience.org/resource/SIO_000496</seealso>
    let _000496 = Prefixed_Name(SIO, "000496") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000497</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is version of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000497">http://semanticscience.org/resource/SIO_000497</seealso>
    let _000497 = Prefixed_Name(SIO, "000497") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000498</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"person"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000498">http://semanticscience.org/resource/SIO_000498</seealso>
    let _000498 = Prefixed_Name(SIO, "000498") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000499</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to decrease the rate of formation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000499">http://semanticscience.org/resource/SIO_000499</seealso>
    let _000499 = Prefixed_Name(SIO, "000499") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000500</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polygon vertex"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000500">http://semanticscience.org/resource/SIO_000500</seealso>
    let _000500 = Prefixed_Name(SIO, "000500") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000501</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polygon edge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000501">http://semanticscience.org/resource/SIO_000501</seealso>
    let _000501 = Prefixed_Name(SIO, "000501") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000502</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyhedral skeleton"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000502">http://semanticscience.org/resource/SIO_000502</seealso>
    let _000502 = Prefixed_Name(SIO, "000502") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000503</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polygonal face"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000503">http://semanticscience.org/resource/SIO_000503</seealso>
    let _000503 = Prefixed_Name(SIO, "000503") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000504</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyhedral surface"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000504">http://semanticscience.org/resource/SIO_000504</seealso>
    let _000504 = Prefixed_Name(SIO, "000504") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000505</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polygon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000505">http://semanticscience.org/resource/SIO_000505</seealso>
    let _000505 = Prefixed_Name(SIO, "000505") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000506</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geometric entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000506">http://semanticscience.org/resource/SIO_000506</seealso>
    let _000506 = Prefixed_Name(SIO, "000506") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000507</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000507">http://semanticscience.org/resource/SIO_000507</seealso>
    let _000507 = Prefixed_Name(SIO, "000507") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000508</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"endpoint"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000508">http://semanticscience.org/resource/SIO_000508</seealso>
    let _000508 = Prefixed_Name(SIO, "000508") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000509</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"start point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000509">http://semanticscience.org/resource/SIO_000509</seealso>
    let _000509 = Prefixed_Name(SIO, "000509") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000510</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"model"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000510">http://semanticscience.org/resource/SIO_000510</seealso>
    let _000510 = Prefixed_Name(SIO, "000510") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000511</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000511">http://semanticscience.org/resource/SIO_000511</seealso>
    let _000511 = Prefixed_Name(SIO, "000511") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"line segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000512">http://semanticscience.org/resource/SIO_000512</seealso>
    let _000512 = Prefixed_Name(SIO, "000512") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000513</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tick mark"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000513">http://semanticscience.org/resource/SIO_000513</seealso>
    let _000513 = Prefixed_Name(SIO, "000513") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000514</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"major tick mark"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000514">http://semanticscience.org/resource/SIO_000514</seealso>
    let _000514 = Prefixed_Name(SIO, "000514") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000515</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minor tick mark"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000515">http://semanticscience.org/resource/SIO_000515</seealso>
    let _000515 = Prefixed_Name(SIO, "000515") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000516</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ray"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000516">http://semanticscience.org/resource/SIO_000516</seealso>
    let _000516 = Prefixed_Name(SIO, "000516") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000517</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quadrilateral"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000517">http://semanticscience.org/resource/SIO_000517</seealso>
    let _000517 = Prefixed_Name(SIO, "000517") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000518</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rectangle"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000518">http://semanticscience.org/resource/SIO_000518</seealso>
    let _000518 = Prefixed_Name(SIO, "000518") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000519</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bar"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000519">http://semanticscience.org/resource/SIO_000519</seealso>
    let _000519 = Prefixed_Name(SIO, "000519") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000520</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"triangle"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000520">http://semanticscience.org/resource/SIO_000520</seealso>
    let _000520 = Prefixed_Name(SIO, "000520") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000521</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"directed line segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000521">http://semanticscience.org/resource/SIO_000521</seealso>
    let _000521 = Prefixed_Name(SIO, "000521") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000522</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arrowed line segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000522">http://semanticscience.org/resource/SIO_000522</seealso>
    let _000522 = Prefixed_Name(SIO, "000522") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000523</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single arrowed line segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000523">http://semanticscience.org/resource/SIO_000523</seealso>
    let _000523 = Prefixed_Name(SIO, "000523") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double arrowed line segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000524">http://semanticscience.org/resource/SIO_000524</seealso>
    let _000524 = Prefixed_Name(SIO, "000524") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000525</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"horizontal line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000525">http://semanticscience.org/resource/SIO_000525</seealso>
    let _000525 = Prefixed_Name(SIO, "000525") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000526</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vertical line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000526">http://semanticscience.org/resource/SIO_000526</seealso>
    let _000526 = Prefixed_Name(SIO, "000526") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000527</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trend line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000527">http://semanticscience.org/resource/SIO_000527</seealso>
    let _000527 = Prefixed_Name(SIO, "000527") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000528</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increasing line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000528">http://semanticscience.org/resource/SIO_000528</seealso>
    let _000528 = Prefixed_Name(SIO, "000528") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000529</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreasing line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000529">http://semanticscience.org/resource/SIO_000529</seealso>
    let _000529 = Prefixed_Name(SIO, "000529") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000530</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plateau line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000530">http://semanticscience.org/resource/SIO_000530</seealso>
    let _000530 = Prefixed_Name(SIO, "000530") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000531</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drop line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000531">http://semanticscience.org/resource/SIO_000531</seealso>
    let _000531 = Prefixed_Name(SIO, "000531") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000532</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"terminal point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000532">http://semanticscience.org/resource/SIO_000532</seealso>
    let _000532 = Prefixed_Name(SIO, "000532") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000533</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"surface normal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000533">http://semanticscience.org/resource/SIO_000533</seealso>
    let _000533 = Prefixed_Name(SIO, "000533") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000534</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positionally oriented line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000534">http://semanticscience.org/resource/SIO_000534</seealso>
    let _000534 = Prefixed_Name(SIO, "000534") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000535</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical graph line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000535">http://semanticscience.org/resource/SIO_000535</seealso>
    let _000535 = Prefixed_Name(SIO, "000535") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000536</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to regulate the rate of formation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000536">http://semanticscience.org/resource/SIO_000536</seealso>
    let _000536 = Prefixed_Name(SIO, "000536") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000537</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curvature"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000537">http://semanticscience.org/resource/SIO_000537</seealso>
    let _000537 = Prefixed_Name(SIO, "000537") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000538</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"straight"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000538">http://semanticscience.org/resource/SIO_000538</seealso>
    let _000538 = Prefixed_Name(SIO, "000538") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000539</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"infinite line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000539">http://semanticscience.org/resource/SIO_000539</seealso>
    let _000539 = Prefixed_Name(SIO, "000539") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000540</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vector"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000540">http://semanticscience.org/resource/SIO_000540</seealso>
    let _000540 = Prefixed_Name(SIO, "000540") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000541</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vertex normal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000541">http://semanticscience.org/resource/SIO_000541</seealso>
    let _000541 = Prefixed_Name(SIO, "000541") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000542</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000542">http://semanticscience.org/resource/SIO_000542</seealso>
    let _000542 = Prefixed_Name(SIO, "000542") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000543</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a host"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000543">http://semanticscience.org/resource/SIO_000543</seealso>
    let _000543 = Prefixed_Name(SIO, "000543") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000544</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to infect"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000544">http://semanticscience.org/resource/SIO_000544</seealso>
    let _000544 = Prefixed_Name(SIO, "000544") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000545</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyline"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000545">http://semanticscience.org/resource/SIO_000545</seealso>
    let _000545 = Prefixed_Name(SIO, "000545") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000546</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection of points"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000546">http://semanticscience.org/resource/SIO_000546</seealso>
    let _000546 = Prefixed_Name(SIO, "000546") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000547</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to cause disease"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000547">http://semanticscience.org/resource/SIO_000547</seealso>
    let _000547 = Prefixed_Name(SIO, "000547") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000549</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to reduce the activation energy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000549">http://semanticscience.org/resource/SIO_000549</seealso>
    let _000549 = Prefixed_Name(SIO, "000549") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000550</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to increase the activation energy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000550">http://semanticscience.org/resource/SIO_000550</seealso>
    let _000550 = Prefixed_Name(SIO, "000550") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000551</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to change the activation energy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000551">http://semanticscience.org/resource/SIO_000551</seealso>
    let _000551 = Prefixed_Name(SIO, "000551") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000552</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has parameter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000552">http://semanticscience.org/resource/SIO_000552</seealso>
    let _000552 = Prefixed_Name(SIO, "000552") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000553</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is parameter in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000553">http://semanticscience.org/resource/SIO_000553</seealso>
    let _000553 = Prefixed_Name(SIO, "000553") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000554</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"normal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000554">http://semanticscience.org/resource/SIO_000554</seealso>
    let _000554 = Prefixed_Name(SIO, "000554") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000555</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abnormal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000555">http://semanticscience.org/resource/SIO_000555</seealso>
    let _000555 = Prefixed_Name(SIO, "000555") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000556</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lipid residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000556">http://semanticscience.org/resource/SIO_000556</seealso>
    let _000556 = Prefixed_Name(SIO, "000556") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000557</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is described by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000557">http://semanticscience.org/resource/SIO_000557</seealso>
    let _000557 = Prefixed_Name(SIO, "000557") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000558</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is orthologous to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000558">http://semanticscience.org/resource/SIO_000558</seealso>
    let _000558 = Prefixed_Name(SIO, "000558") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000559</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000559">http://semanticscience.org/resource/SIO_000559</seealso>
    let _000559 = Prefixed_Name(SIO, "000559") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000561</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular orbitral"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000561">http://semanticscience.org/resource/SIO_000561</seealso>
    let _000561 = Prefixed_Name(SIO, "000561") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000562</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passive transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000562">http://semanticscience.org/resource/SIO_000562</seealso>
    let _000562 = Prefixed_Name(SIO, "000562") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000563</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000563">http://semanticscience.org/resource/SIO_000563</seealso>
    let _000563 = Prefixed_Name(SIO, "000563") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000564</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diffusion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000564">http://semanticscience.org/resource/SIO_000564</seealso>
    let _000564 = Prefixed_Name(SIO, "000564") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diffusion equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000565">http://semanticscience.org/resource/SIO_000565</seealso>
    let _000565 = Prefixed_Name(SIO, "000565") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000566</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"movement equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000566">http://semanticscience.org/resource/SIO_000566</seealso>
    let _000566 = Prefixed_Name(SIO, "000566") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000567</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ordinary differential equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000567">http://semanticscience.org/resource/SIO_000567</seealso>
    let _000567 = Prefixed_Name(SIO, "000567") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000568</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial differential equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000568">http://semanticscience.org/resource/SIO_000568</seealso>
    let _000568 = Prefixed_Name(SIO, "000568") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000569</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"differential equation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000569">http://semanticscience.org/resource/SIO_000569</seealso>
    let _000569 = Prefixed_Name(SIO, "000569") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000570</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"movement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000570">http://semanticscience.org/resource/SIO_000570</seealso>
    let _000570 = Prefixed_Name(SIO, "000570") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000571</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brownian motion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000571">http://semanticscience.org/resource/SIO_000571</seealso>
    let _000571 = Prefixed_Name(SIO, "000571") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000572</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"osmosis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000572">http://semanticscience.org/resource/SIO_000572</seealso>
    let _000572 = Prefixed_Name(SIO, "000572") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000573</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passive movement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000573">http://semanticscience.org/resource/SIO_000573</seealso>
    let _000573 = Prefixed_Name(SIO, "000573") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000574</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"active movement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000574">http://semanticscience.org/resource/SIO_000574</seealso>
    let _000574 = Prefixed_Name(SIO, "000574") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000575</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transporting"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000575">http://semanticscience.org/resource/SIO_000575</seealso>
    let _000575 = Prefixed_Name(SIO, "000575") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000576</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"membrane transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000576">http://semanticscience.org/resource/SIO_000576</seealso>
    let _000576 = Prefixed_Name(SIO, "000576") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000577</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary active transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000577">http://semanticscience.org/resource/SIO_000577</seealso>
    let _000577 = Prefixed_Name(SIO, "000577") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000578</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary active transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000578">http://semanticscience.org/resource/SIO_000578</seealso>
    let _000578 = Prefixed_Name(SIO, "000578") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000579</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"symport enabled secondary active transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000579">http://semanticscience.org/resource/SIO_000579</seealso>
    let _000579 = Prefixed_Name(SIO, "000579") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000580</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antiport enabled secondary active transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000580">http://semanticscience.org/resource/SIO_000580</seealso>
    let _000580 = Prefixed_Name(SIO, "000580") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000581</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"locomotion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000581">http://semanticscience.org/resource/SIO_000581</seealso>
    let _000581 = Prefixed_Name(SIO, "000581") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000582</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"birthing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000582">http://semanticscience.org/resource/SIO_000582</seealso>
    let _000582 = Prefixed_Name(SIO, "000582") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000583</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dying"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000583">http://semanticscience.org/resource/SIO_000583</seealso>
    let _000583 = Prefixed_Name(SIO, "000583") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000585</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"idea"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000585">http://semanticscience.org/resource/SIO_000585</seealso>
    let _000585 = Prefixed_Name(SIO, "000585") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000586</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has capability"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000586">http://semanticscience.org/resource/SIO_000586</seealso>
    let _000586 = Prefixed_Name(SIO, "000586") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000587</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological reproduction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000587">http://semanticscience.org/resource/SIO_000587</seealso>
    let _000587 = Prefixed_Name(SIO, "000587") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000588</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"creating"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000588">http://semanticscience.org/resource/SIO_000588</seealso>
    let _000588 = Prefixed_Name(SIO, "000588") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000589</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulating"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000589">http://semanticscience.org/resource/SIO_000589</seealso>
    let _000589 = Prefixed_Name(SIO, "000589") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000590</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biosynthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000590">http://semanticscience.org/resource/SIO_000590</seealso>
    let _000590 = Prefixed_Name(SIO, "000590") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000591</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"destroying"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000591">http://semanticscience.org/resource/SIO_000591</seealso>
    let _000591 = Prefixed_Name(SIO, "000591") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000592</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical destruction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000592">http://semanticscience.org/resource/SIO_000592</seealso>
    let _000592 = Prefixed_Name(SIO, "000592") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000593</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interacting"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000593">http://semanticscience.org/resource/SIO_000593</seealso>
    let _000593 = Prefixed_Name(SIO, "000593") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000594</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data transformation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000594">http://semanticscience.org/resource/SIO_000594</seealso>
    let _000594 = Prefixed_Name(SIO, "000594") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000595</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"parameterized data transformation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000595">http://semanticscience.org/resource/SIO_000595</seealso>
    let _000595 = Prefixed_Name(SIO, "000595") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000596</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data storage device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000596">http://semanticscience.org/resource/SIO_000596</seealso>
    let _000596 = Prefixed_Name(SIO, "000596") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000597</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"solid state hard drive"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000597">http://semanticscience.org/resource/SIO_000597</seealso>
    let _000597 = Prefixed_Name(SIO, "000597") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000598</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hard disk drive"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000598">http://semanticscience.org/resource/SIO_000598</seealso>
    let _000598 = Prefixed_Name(SIO, "000598") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000600</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000600">http://semanticscience.org/resource/SIO_000600</seealso>
    let _000600 = Prefixed_Name(SIO, "000600") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000602</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"computational entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000602">http://semanticscience.org/resource/SIO_000602</seealso>
    let _000602 = Prefixed_Name(SIO, "000602") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sound wave"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000605">http://semanticscience.org/resource/SIO_000605</seealso>
    let _000605 = Prefixed_Name(SIO, "000605") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curve"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000608">http://semanticscience.org/resource/SIO_000608</seealso>
    let _000608 = Prefixed_Name(SIO, "000608") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000609</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000609">http://semanticscience.org/resource/SIO_000609</seealso>
    let _000609 = Prefixed_Name(SIO, "000609") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of capability"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000610">http://semanticscience.org/resource/SIO_000610</seealso>
    let _000610 = Prefixed_Name(SIO, "000610") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of catalytic capability"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000611">http://semanticscience.org/resource/SIO_000611</seealso>
    let _000611 = Prefixed_Name(SIO, "000611") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000612</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"representation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000612">http://semanticscience.org/resource/SIO_000612</seealso>
    let _000612 = Prefixed_Name(SIO, "000612") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000613</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ordinal position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000613">http://semanticscience.org/resource/SIO_000613</seealso>
    let _000613 = Prefixed_Name(SIO, "000613") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000614</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"attribute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000614">http://semanticscience.org/resource/SIO_000614</seealso>
    let _000614 = Prefixed_Name(SIO, "000614") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000616</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000616">http://semanticscience.org/resource/SIO_000616</seealso>
    let _000616 = Prefixed_Name(SIO, "000616") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000617</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"empty set"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000617">http://semanticscience.org/resource/SIO_000617</seealso>
    let _000617 = Prefixed_Name(SIO, "000617") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000618</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000618">http://semanticscience.org/resource/SIO_000618</seealso>
    let _000618 = Prefixed_Name(SIO, "000618") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000619</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory authority"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000619">http://semanticscience.org/resource/SIO_000619</seealso>
    let _000619 = Prefixed_Name(SIO, "000619") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000620</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collective"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000620">http://semanticscience.org/resource/SIO_000620</seealso>
    let _000620 = Prefixed_Name(SIO, "000620") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"formal specification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000621">http://semanticscience.org/resource/SIO_000621</seealso>
    let _000621 = Prefixed_Name(SIO, "000621") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000622</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RDFS ontology"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000622">http://semanticscience.org/resource/SIO_000622</seealso>
    let _000622 = Prefixed_Name(SIO, "000622") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000623</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OBO ontology"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000623">http://semanticscience.org/resource/SIO_000623</seealso>
    let _000623 = Prefixed_Name(SIO, "000623") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical functional group"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000624">http://semanticscience.org/resource/SIO_000624</seealso>
    let _000624 = Prefixed_Name(SIO, "000624") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000625">http://semanticscience.org/resource/SIO_000625</seealso>
    let _000625 = Prefixed_Name(SIO, "000625") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000626</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000626">http://semanticscience.org/resource/SIO_000626</seealso>
    let _000626 = Prefixed_Name(SIO, "000626") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000628</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"refers to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000628">http://semanticscience.org/resource/SIO_000628</seealso>
    let _000628 = Prefixed_Name(SIO, "000628") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000629</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subject of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000629">http://semanticscience.org/resource/SIO_000629</seealso>
    let _000629 = Prefixed_Name(SIO, "000629") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000630</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is paralogous to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000630">http://semanticscience.org/resource/SIO_000630</seealso>
    let _000630 = Prefixed_Name(SIO, "000630") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000631</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"references"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000631">http://semanticscience.org/resource/SIO_000631</seealso>
    let _000631 = Prefixed_Name(SIO, "000631") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000632</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is model of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000632">http://semanticscience.org/resource/SIO_000632</seealso>
    let _000632 = Prefixed_Name(SIO, "000632") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000633</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is modelled by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000633">http://semanticscience.org/resource/SIO_000633</seealso>
    let _000633 = Prefixed_Name(SIO, "000633") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000634</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is xenologous to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000634">http://semanticscience.org/resource/SIO_000634</seealso>
    let _000634 = Prefixed_Name(SIO, "000634") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000635</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has trigger"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000635">http://semanticscience.org/resource/SIO_000635</seealso>
    let _000635 = Prefixed_Name(SIO, "000635") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000636</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is trigger for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000636">http://semanticscience.org/resource/SIO_000636</seealso>
    let _000636 = Prefixed_Name(SIO, "000636") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"probability measure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000638">http://semanticscience.org/resource/SIO_000638</seealso>
    let _000638 = Prefixed_Name(SIO, "000638") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000639</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to passively interact with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000639">http://semanticscience.org/resource/SIO_000639</seealso>
    let _000639 = Prefixed_Name(SIO, "000639") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000640</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000640">http://semanticscience.org/resource/SIO_000640</seealso>
    let _000640 = Prefixed_Name(SIO, "000640") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000641</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has basis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000641">http://semanticscience.org/resource/SIO_000641</seealso>
    let _000641 = Prefixed_Name(SIO, "000641") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000642</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is base for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000642">http://semanticscience.org/resource/SIO_000642</seealso>
    let _000642 = Prefixed_Name(SIO, "000642") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000643</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is realizable property of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000643">http://semanticscience.org/resource/SIO_000643</seealso>
    let _000643 = Prefixed_Name(SIO, "000643") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000644</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has realizable property"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000644">http://semanticscience.org/resource/SIO_000644</seealso>
    let _000644 = Prefixed_Name(SIO, "000644") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000646</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is capability of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000646">http://semanticscience.org/resource/SIO_000646</seealso>
    let _000646 = Prefixed_Name(SIO, "000646") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000647</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process model"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000647">http://semanticscience.org/resource/SIO_000647</seealso>
    let _000647 = Prefixed_Name(SIO, "000647") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000648</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object model"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000648">http://semanticscience.org/resource/SIO_000648</seealso>
    let _000648 = Prefixed_Name(SIO, "000648") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000649</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information processing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000649">http://semanticscience.org/resource/SIO_000649</seealso>
    let _000649 = Prefixed_Name(SIO, "000649") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000650</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"wave"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000650">http://semanticscience.org/resource/SIO_000650</seealso>
    let _000650 = Prefixed_Name(SIO, "000650") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000651</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"textual entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000651">http://semanticscience.org/resource/SIO_000651</seealso>
    let _000651 = Prefixed_Name(SIO, "000651") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000652</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is directly connected to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000652">http://semanticscience.org/resource/SIO_000652</seealso>
    let _000652 = Prefixed_Name(SIO, "000652") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000653</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"version label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000653">http://semanticscience.org/resource/SIO_000653</seealso>
    let _000653 = Prefixed_Name(SIO, "000653") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000654</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software version label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000654">http://semanticscience.org/resource/SIO_000654</seealso>
    let _000654 = Prefixed_Name(SIO, "000654") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000655</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"transforms into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000655">http://semanticscience.org/resource/SIO_000655</seealso>
    let _000655 = Prefixed_Name(SIO, "000655") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000656</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"immediately transforms into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000656">http://semanticscience.org/resource/SIO_000656</seealso>
    let _000656 = Prefixed_Name(SIO, "000656") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000657</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is transformed from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000657">http://semanticscience.org/resource/SIO_000657</seealso>
    let _000657 = Prefixed_Name(SIO, "000657") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000658</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is immediately transformed from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000658">http://semanticscience.org/resource/SIO_000658</seealso>
    let _000658 = Prefixed_Name(SIO, "000658") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000660</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hole"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000660">http://semanticscience.org/resource/SIO_000660</seealso>
    let _000660 = Prefixed_Name(SIO, "000660") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000661</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"province"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000661">http://semanticscience.org/resource/SIO_000661</seealso>
    let _000661 = Prefixed_Name(SIO, "000661") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000662</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"state"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000662">http://semanticscience.org/resource/SIO_000662</seealso>
    let _000662 = Prefixed_Name(SIO, "000662") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000663</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"territory"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000663">http://semanticscience.org/resource/SIO_000663</seealso>
    let _000663 = Prefixed_Name(SIO, "000663") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000664</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"country"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000664">http://semanticscience.org/resource/SIO_000664</seealso>
    let _000664 = Prefixed_Name(SIO, "000664") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000665</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"city"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000665">http://semanticscience.org/resource/SIO_000665</seealso>
    let _000665 = Prefixed_Name(SIO, "000665") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000666</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"township"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000666">http://semanticscience.org/resource/SIO_000666</seealso>
    let _000666 = Prefixed_Name(SIO, "000666") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000667</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sofware execution"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000667">http://semanticscience.org/resource/SIO_000667</seealso>
    let _000667 = Prefixed_Name(SIO, "000667") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000668</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"in relation to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000668">http://semanticscience.org/resource/SIO_000668</seealso>
    let _000668 = Prefixed_Name(SIO, "000668") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000669</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"start time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000669">http://semanticscience.org/resource/SIO_000669</seealso>
    let _000669 = Prefixed_Name(SIO, "000669") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000670</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"end time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000670">http://semanticscience.org/resource/SIO_000670</seealso>
    let _000670 = Prefixed_Name(SIO, "000670") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000671</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000671">http://semanticscience.org/resource/SIO_000671</seealso>
    let _000671 = Prefixed_Name(SIO, "000671") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000672</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is identifier for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000672">http://semanticscience.org/resource/SIO_000672</seealso>
    let _000672 = Prefixed_Name(SIO, "000672") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000673</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has unique identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000673">http://semanticscience.org/resource/SIO_000673</seealso>
    let _000673 = Prefixed_Name(SIO, "000673") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is unique identifier for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000674">http://semanticscience.org/resource/SIO_000674</seealso>
    let _000674 = Prefixed_Name(SIO, "000674") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000675</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000675">http://semanticscience.org/resource/SIO_000675</seealso>
    let _000675 = Prefixed_Name(SIO, "000675") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000676</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000676">http://semanticscience.org/resource/SIO_000676</seealso>
    let _000676 = Prefixed_Name(SIO, "000676") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000677</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"processual role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000677">http://semanticscience.org/resource/SIO_000677</seealso>
    let _000677 = Prefixed_Name(SIO, "000677") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000678</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"abstract role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000678">http://semanticscience.org/resource/SIO_000678</seealso>
    let _000678 = Prefixed_Name(SIO, "000678") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000679</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time boundary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000679">http://semanticscience.org/resource/SIO_000679</seealso>
    let _000679 = Prefixed_Name(SIO, "000679") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000680</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has start time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000680">http://semanticscience.org/resource/SIO_000680</seealso>
    let _000680 = Prefixed_Name(SIO, "000680") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000681</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has end time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000681">http://semanticscience.org/resource/SIO_000681</seealso>
    let _000681 = Prefixed_Name(SIO, "000681") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000682</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is start time of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000682">http://semanticscience.org/resource/SIO_000682</seealso>
    let _000682 = Prefixed_Name(SIO, "000682") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000683</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"justification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000683">http://semanticscience.org/resource/SIO_000683</seealso>
    let _000683 = Prefixed_Name(SIO, "000683") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000684</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is end time of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000684">http://semanticscience.org/resource/SIO_000684</seealso>
    let _000684 = Prefixed_Name(SIO, "000684") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000686</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"academic department"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000686">http://semanticscience.org/resource/SIO_000686</seealso>
    let _000686 = Prefixed_Name(SIO, "000686") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000687</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exists at"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000687">http://semanticscience.org/resource/SIO_000687</seealso>
    let _000687 = Prefixed_Name(SIO, "000687") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000688</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000688">http://semanticscience.org/resource/SIO_000688</seealso>
    let _000688 = Prefixed_Name(SIO, "000688") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000689</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be a part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000689">http://semanticscience.org/resource/SIO_000689</seealso>
    let _000689 = Prefixed_Name(SIO, "000689") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000690</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to associate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000690">http://semanticscience.org/resource/SIO_000690</seealso>
    let _000690 = Prefixed_Name(SIO, "000690") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000692</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be actively interacted with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000692">http://semanticscience.org/resource/SIO_000692</seealso>
    let _000692 = Prefixed_Name(SIO, "000692") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000693</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000693">http://semanticscience.org/resource/SIO_000693</seealso>
    let _000693 = Prefixed_Name(SIO, "000693") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000694</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be passively interacted with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000694">http://semanticscience.org/resource/SIO_000694</seealso>
    let _000694 = Prefixed_Name(SIO, "000694") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000695</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be recorded"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000695">http://semanticscience.org/resource/SIO_000695</seealso>
    let _000695 = Prefixed_Name(SIO, "000695") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000696</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be observed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000696">http://semanticscience.org/resource/SIO_000696</seealso>
    let _000696 = Prefixed_Name(SIO, "000696") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000697</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mutual disposition of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000697">http://semanticscience.org/resource/SIO_000697</seealso>
    let _000697 = Prefixed_Name(SIO, "000697") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000698</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to disassemble"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000698">http://semanticscience.org/resource/SIO_000698</seealso>
    let _000698 = Prefixed_Name(SIO, "000698") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000699</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is greater than or equal to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000699">http://semanticscience.org/resource/SIO_000699</seealso>
    let _000699 = Prefixed_Name(SIO, "000699") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000700</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to disassociate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000700">http://semanticscience.org/resource/SIO_000700</seealso>
    let _000700 = Prefixed_Name(SIO, "000700") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000701</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to interact with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000701">http://semanticscience.org/resource/SIO_000701</seealso>
    let _000701 = Prefixed_Name(SIO, "000701") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000702</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be interacted with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000702">http://semanticscience.org/resource/SIO_000702</seealso>
    let _000702 = Prefixed_Name(SIO, "000702") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000703</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"evolving"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000703">http://semanticscience.org/resource/SIO_000703</seealso>
    let _000703 = Prefixed_Name(SIO, "000703") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000704</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positional role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000704">http://semanticscience.org/resource/SIO_000704</seealso>
    let _000704 = Prefixed_Name(SIO, "000704") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000705</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"design"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000705">http://semanticscience.org/resource/SIO_000705</seealso>
    let _000705 = Prefixed_Name(SIO, "000705") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000706</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"occupational role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000706">http://semanticscience.org/resource/SIO_000706</seealso>
    let _000706 = Prefixed_Name(SIO, "000706") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000707</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000707">http://semanticscience.org/resource/SIO_000707</seealso>
    let _000707 = Prefixed_Name(SIO, "000707") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000708</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"professor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000708">http://semanticscience.org/resource/SIO_000708</seealso>
    let _000708 = Prefixed_Name(SIO, "000708") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000709</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is mutually related to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000709">http://semanticscience.org/resource/SIO_000709</seealso>
    let _000709 = Prefixed_Name(SIO, "000709") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000710</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mutual role of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000710">http://semanticscience.org/resource/SIO_000710</seealso>
    let _000710 = Prefixed_Name(SIO, "000710") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000711</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"academic role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000711">http://semanticscience.org/resource/SIO_000711</seealso>
    let _000711 = Prefixed_Name(SIO, "000711") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000712</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000712">http://semanticscience.org/resource/SIO_000712</seealso>
    let _000712 = Prefixed_Name(SIO, "000712") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000713</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"doctor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000713">http://semanticscience.org/resource/SIO_000713</seealso>
    let _000713 = Prefixed_Name(SIO, "000713") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000714</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nurse role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000714">http://semanticscience.org/resource/SIO_000714</seealso>
    let _000714 = Prefixed_Name(SIO, "000714") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000715</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patient role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000715">http://semanticscience.org/resource/SIO_000715</seealso>
    let _000715 = Prefixed_Name(SIO, "000715") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000716</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical practitioner"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000716">http://semanticscience.org/resource/SIO_000716</seealso>
    let _000716 = Prefixed_Name(SIO, "000716") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000717</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dentist role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000717">http://semanticscience.org/resource/SIO_000717</seealso>
    let _000717 = Prefixed_Name(SIO, "000717") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000719</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to translocate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000719">http://semanticscience.org/resource/SIO_000719</seealso>
    let _000719 = Prefixed_Name(SIO, "000719") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000720</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be translocated"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000720">http://semanticscience.org/resource/SIO_000720</seealso>
    let _000720 = Prefixed_Name(SIO, "000720") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000721</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"comparative role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000721">http://semanticscience.org/resource/SIO_000721</seealso>
    let _000721 = Prefixed_Name(SIO, "000721") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000722</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be compared"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000722">http://semanticscience.org/resource/SIO_000722</seealso>
    let _000722 = Prefixed_Name(SIO, "000722") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000723</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to compare"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000723">http://semanticscience.org/resource/SIO_000723</seealso>
    let _000723 = Prefixed_Name(SIO, "000723") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000724</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to examine"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000724">http://semanticscience.org/resource/SIO_000724</seealso>
    let _000724 = Prefixed_Name(SIO, "000724") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000725</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be examined"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000725">http://semanticscience.org/resource/SIO_000725</seealso>
    let _000725 = Prefixed_Name(SIO, "000725") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000726</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"administrative role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000726">http://semanticscience.org/resource/SIO_000726</seealso>
    let _000726 = Prefixed_Name(SIO, "000726") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000727</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secretary role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000727">http://semanticscience.org/resource/SIO_000727</seealso>
    let _000727 = Prefixed_Name(SIO, "000727") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000728</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000728">http://semanticscience.org/resource/SIO_000728</seealso>
    let _000728 = Prefixed_Name(SIO, "000728") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000729</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"record identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000729">http://semanticscience.org/resource/SIO_000729</seealso>
    let _000729 = Prefixed_Name(SIO, "000729") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000730</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical entity identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000730">http://semanticscience.org/resource/SIO_000730</seealso>
    let _000730 = Prefixed_Name(SIO, "000730") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000731</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"informational entity identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000731">http://semanticscience.org/resource/SIO_000731</seealso>
    let _000731 = Prefixed_Name(SIO, "000731") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000732</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000732">http://semanticscience.org/resource/SIO_000732</seealso>
    let _000732 = Prefixed_Name(SIO, "000732") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000733</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is lesser than or equal to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000733">http://semanticscience.org/resource/SIO_000733</seealso>
    let _000733 = Prefixed_Name(SIO, "000733") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000734</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is greater than"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000734">http://semanticscience.org/resource/SIO_000734</seealso>
    let _000734 = Prefixed_Name(SIO, "000734") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000735</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is lesser than"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000735">http://semanticscience.org/resource/SIO_000735</seealso>
    let _000735 = Prefixed_Name(SIO, "000735") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000736</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is comparable to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000736">http://semanticscience.org/resource/SIO_000736</seealso>
    let _000736 = Prefixed_Name(SIO, "000736") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000737</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is numerically comparable to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000737">http://semanticscience.org/resource/SIO_000737</seealso>
    let _000737 = Prefixed_Name(SIO, "000737") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000738</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is equal to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000738">http://semanticscience.org/resource/SIO_000738</seealso>
    let _000738 = Prefixed_Name(SIO, "000738") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000739</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"planning"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000739">http://semanticscience.org/resource/SIO_000739</seealso>
    let _000739 = Prefixed_Name(SIO, "000739") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000740</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curve segment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000740">http://semanticscience.org/resource/SIO_000740</seealso>
    let _000740 = Prefixed_Name(SIO, "000740") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000741</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stationary point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000741">http://semanticscience.org/resource/SIO_000741</seealso>
    let _000741 = Prefixed_Name(SIO, "000741") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000742</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local maximum stationary point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000742">http://semanticscience.org/resource/SIO_000742</seealso>
    let _000742 = Prefixed_Name(SIO, "000742") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000743</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local minimum stationary point"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000743">http://semanticscience.org/resource/SIO_000743</seealso>
    let _000743 = Prefixed_Name(SIO, "000743") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000744</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"learning"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000744">http://semanticscience.org/resource/SIO_000744</seealso>
    let _000744 = Prefixed_Name(SIO, "000744") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000745</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"comparing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000745">http://semanticscience.org/resource/SIO_000745</seealso>
    let _000745 = Prefixed_Name(SIO, "000745") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000746</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reasoning"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000746">http://semanticscience.org/resource/SIO_000746</seealso>
    let _000746 = Prefixed_Name(SIO, "000746") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000747</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investigation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000747">http://semanticscience.org/resource/SIO_000747</seealso>
    let _000747 = Prefixed_Name(SIO, "000747") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000748</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"predicting"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000748">http://semanticscience.org/resource/SIO_000748</seealso>
    let _000748 = Prefixed_Name(SIO, "000748") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000749</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is inequal to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000749">http://semanticscience.org/resource/SIO_000749</seealso>
    let _000749 = Prefixed_Name(SIO, "000749") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000750</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000750">http://semanticscience.org/resource/SIO_000750</seealso>
    let _000750 = Prefixed_Name(SIO, "000750") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000751</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000751">http://semanticscience.org/resource/SIO_000751</seealso>
    let _000751 = Prefixed_Name(SIO, "000751") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000752</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"row"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000752">http://semanticscience.org/resource/SIO_000752</seealso>
    let _000752 = Prefixed_Name(SIO, "000752") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000753</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"column"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000753">http://semanticscience.org/resource/SIO_000753</seealso>
    let _000753 = Prefixed_Name(SIO, "000753") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000754</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database table"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000754">http://semanticscience.org/resource/SIO_000754</seealso>
    let _000754 = Prefixed_Name(SIO, "000754") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000755</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell (informational)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000755">http://semanticscience.org/resource/SIO_000755</seealso>
    let _000755 = Prefixed_Name(SIO, "000755") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000756</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database entry"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000756">http://semanticscience.org/resource/SIO_000756</seealso>
    let _000756 = Prefixed_Name(SIO, "000756") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000757</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database column"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000757">http://semanticscience.org/resource/SIO_000757</seealso>
    let _000757 = Prefixed_Name(SIO, "000757") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000758</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disordered"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000758">http://semanticscience.org/resource/SIO_000758</seealso>
    let _000758 = Prefixed_Name(SIO, "000758") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000759</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique cell"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000759">http://semanticscience.org/resource/SIO_000759</seealso>
    let _000759 = Prefixed_Name(SIO, "000759") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000760</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"referencing cell"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000760">http://semanticscience.org/resource/SIO_000760</seealso>
    let _000760 = Prefixed_Name(SIO, "000760") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000761</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"referent cell"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000761">http://semanticscience.org/resource/SIO_000761</seealso>
    let _000761 = Prefixed_Name(SIO, "000761") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000762</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database key"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000762">http://semanticscience.org/resource/SIO_000762</seealso>
    let _000762 = Prefixed_Name(SIO, "000762") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000763</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary database key"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000763">http://semanticscience.org/resource/SIO_000763</seealso>
    let _000763 = Prefixed_Name(SIO, "000763") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000764</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"foreign database key"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000764">http://semanticscience.org/resource/SIO_000764</seealso>
    let _000764 = Prefixed_Name(SIO, "000764") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000765</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"probability value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000765">http://semanticscience.org/resource/SIO_000765</seealso>
    let _000765 = Prefixed_Name(SIO, "000765") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000766</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"street name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000766">http://semanticscience.org/resource/SIO_000766</seealso>
    let _000766 = Prefixed_Name(SIO, "000766") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000767</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"postal code"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000767">http://semanticscience.org/resource/SIO_000767</seealso>
    let _000767 = Prefixed_Name(SIO, "000767") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000768</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"apartment number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000768">http://semanticscience.org/resource/SIO_000768</seealso>
    let _000768 = Prefixed_Name(SIO, "000768") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000769</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uncertainty value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000769">http://semanticscience.org/resource/SIO_000769</seealso>
    let _000769 = Prefixed_Name(SIO, "000769") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000770</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard deviation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000770">http://semanticscience.org/resource/SIO_000770</seealso>
    let _000770 = Prefixed_Name(SIO, "000770") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000771</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"versioned record"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000771">http://semanticscience.org/resource/SIO_000771</seealso>
    let _000771 = Prefixed_Name(SIO, "000771") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000772</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has evidence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000772">http://semanticscience.org/resource/SIO_000772</seealso>
    let _000772 = Prefixed_Name(SIO, "000772") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000773</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is evidence for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000773">http://semanticscience.org/resource/SIO_000773</seealso>
    let _000773 = Prefixed_Name(SIO, "000773") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000774</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is refuted by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000774">http://semanticscience.org/resource/SIO_000774</seealso>
    let _000774 = Prefixed_Name(SIO, "000774") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000775</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is refuting evidence for"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000775">http://semanticscience.org/resource/SIO_000775</seealso>
    let _000775 = Prefixed_Name(SIO, "000775") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000776</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000776">http://semanticscience.org/resource/SIO_000776</seealso>
    let _000776 = Prefixed_Name(SIO, "000776") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000777</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be a member of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000777">http://semanticscience.org/resource/SIO_000777</seealso>
    let _000777 = Prefixed_Name(SIO, "000777") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000778</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to distort"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000778">http://semanticscience.org/resource/SIO_000778</seealso>
    let _000778 = Prefixed_Name(SIO, "000778") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000779</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000779">http://semanticscience.org/resource/SIO_000779</seealso>
    let _000779 = Prefixed_Name(SIO, "000779") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000780</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to bind to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000780">http://semanticscience.org/resource/SIO_000780</seealso>
    let _000780 = Prefixed_Name(SIO, "000780") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000783</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial boundary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000783">http://semanticscience.org/resource/SIO_000783</seealso>
    let _000783 = Prefixed_Name(SIO, "000783") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000784</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hermaphrodite"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000784">http://semanticscience.org/resource/SIO_000784</seealso>
    let _000784 = Prefixed_Name(SIO, "000784") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"answer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000785">http://semanticscience.org/resource/SIO_000785</seealso>
    let _000785 = Prefixed_Name(SIO, "000785") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"verbal language entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000786">http://semanticscience.org/resource/SIO_000786</seealso>
    let _000786 = Prefixed_Name(SIO, "000786") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000787</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"page number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000787">http://semanticscience.org/resource/SIO_000787</seealso>
    let _000787 = Prefixed_Name(SIO, "000787") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"linear position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000788">http://semanticscience.org/resource/SIO_000788</seealso>
    let _000788 = Prefixed_Name(SIO, "000788") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence element position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000789">http://semanticscience.org/resource/SIO_000789</seealso>
    let _000789 = Prefixed_Name(SIO, "000789") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000790</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-protein coding RNA (ncRNA) gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000790">http://semanticscience.org/resource/SIO_000790</seealso>
    let _000790 = Prefixed_Name(SIO, "000790") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000791</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence start position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000791">http://semanticscience.org/resource/SIO_000791</seealso>
    let _000791 = Prefixed_Name(SIO, "000791") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000792</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence end position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000792">http://semanticscience.org/resource/SIO_000792</seealso>
    let _000792 = Prefixed_Name(SIO, "000792") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000793</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"measured at"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000793">http://semanticscience.org/resource/SIO_000793</seealso>
    let _000793 = Prefixed_Name(SIO, "000793") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"count"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000794">http://semanticscience.org/resource/SIO_000794</seealso>
    let _000794 = Prefixed_Name(SIO, "000794") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000795</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical entity role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000795">http://semanticscience.org/resource/SIO_000795</seealso>
    let _000795 = Prefixed_Name(SIO, "000795") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000796</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalytic role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000796">http://semanticscience.org/resource/SIO_000796</seealso>
    let _000796 = Prefixed_Name(SIO, "000796") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000797</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"substrate role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000797">http://semanticscience.org/resource/SIO_000797</seealso>
    let _000797 = Prefixed_Name(SIO, "000797") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000798</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000798">http://semanticscience.org/resource/SIO_000798</seealso>
    let _000798 = Prefixed_Name(SIO, "000798") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000799</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cofactor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000799">http://semanticscience.org/resource/SIO_000799</seealso>
    let _000799 = Prefixed_Name(SIO, "000799") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000800</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"co-enzyme role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000800">http://semanticscience.org/resource/SIO_000800</seealso>
    let _000800 = Prefixed_Name(SIO, "000800") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000801</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prosthetic group role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000801">http://semanticscience.org/resource/SIO_000801</seealso>
    let _000801 = Prefixed_Name(SIO, "000801") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000802</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"co-substrate role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000802">http://semanticscience.org/resource/SIO_000802</seealso>
    let _000802 = Prefixed_Name(SIO, "000802") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000803</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inhibitor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000803">http://semanticscience.org/resource/SIO_000803</seealso>
    let _000803 = Prefixed_Name(SIO, "000803") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000804</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"activator role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000804">http://semanticscience.org/resource/SIO_000804</seealso>
    let _000804 = Prefixed_Name(SIO, "000804") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000805</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"charged"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000805">http://semanticscience.org/resource/SIO_000805</seealso>
    let _000805 = Prefixed_Name(SIO, "000805") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000806</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uncharged"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000806">http://semanticscience.org/resource/SIO_000806</seealso>
    let _000806 = Prefixed_Name(SIO, "000806") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000807</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial positive charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000807">http://semanticscience.org/resource/SIO_000807</seealso>
    let _000807 = Prefixed_Name(SIO, "000807") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000808</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial negative charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000808">http://semanticscience.org/resource/SIO_000808</seealso>
    let _000808 = Prefixed_Name(SIO, "000808") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000809</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000809">http://semanticscience.org/resource/SIO_000809</seealso>
    let _000809 = Prefixed_Name(SIO, "000809") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000810</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"complete charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000810">http://semanticscience.org/resource/SIO_000810</seealso>
    let _000810 = Prefixed_Name(SIO, "000810") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000811</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"URL"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000811">http://semanticscience.org/resource/SIO_000811</seealso>
    let _000811 = Prefixed_Name(SIO, "000811") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000812</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affection"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000812">http://semanticscience.org/resource/SIO_000812</seealso>
    let _000812 = Prefixed_Name(SIO, "000812") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000813</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"angst"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000813">http://semanticscience.org/resource/SIO_000813</seealso>
    let _000813 = Prefixed_Name(SIO, "000813") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000814</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"annoyance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000814">http://semanticscience.org/resource/SIO_000814</seealso>
    let _000814 = Prefixed_Name(SIO, "000814") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000815</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anxiety"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000815">http://semanticscience.org/resource/SIO_000815</seealso>
    let _000815 = Prefixed_Name(SIO, "000815") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000816</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"apathy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000816">http://semanticscience.org/resource/SIO_000816</seealso>
    let _000816 = Prefixed_Name(SIO, "000816") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000817</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arousal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000817">http://semanticscience.org/resource/SIO_000817</seealso>
    let _000817 = Prefixed_Name(SIO, "000817") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000818</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"awe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000818">http://semanticscience.org/resource/SIO_000818</seealso>
    let _000818 = Prefixed_Name(SIO, "000818") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000819</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"boldness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000819">http://semanticscience.org/resource/SIO_000819</seealso>
    let _000819 = Prefixed_Name(SIO, "000819") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000820</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"boredom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000820">http://semanticscience.org/resource/SIO_000820</seealso>
    let _000820 = Prefixed_Name(SIO, "000820") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000821</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contempt"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000821">http://semanticscience.org/resource/SIO_000821</seealso>
    let _000821 = Prefixed_Name(SIO, "000821") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000822</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contentment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000822">http://semanticscience.org/resource/SIO_000822</seealso>
    let _000822 = Prefixed_Name(SIO, "000822") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000823</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curiosity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000823">http://semanticscience.org/resource/SIO_000823</seealso>
    let _000823 = Prefixed_Name(SIO, "000823") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000824</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"depression"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000824">http://semanticscience.org/resource/SIO_000824</seealso>
    let _000824 = Prefixed_Name(SIO, "000824") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000825</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"desire"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000825">http://semanticscience.org/resource/SIO_000825</seealso>
    let _000825 = Prefixed_Name(SIO, "000825") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000826</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"despair"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000826">http://semanticscience.org/resource/SIO_000826</seealso>
    let _000826 = Prefixed_Name(SIO, "000826") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000827</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disappointment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000827">http://semanticscience.org/resource/SIO_000827</seealso>
    let _000827 = Prefixed_Name(SIO, "000827") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000828</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disgust"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000828">http://semanticscience.org/resource/SIO_000828</seealso>
    let _000828 = Prefixed_Name(SIO, "000828") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000829</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dread"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000829">http://semanticscience.org/resource/SIO_000829</seealso>
    let _000829 = Prefixed_Name(SIO, "000829") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000830</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ecstasy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000830">http://semanticscience.org/resource/SIO_000830</seealso>
    let _000830 = Prefixed_Name(SIO, "000830") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000831</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positive emotion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000831">http://semanticscience.org/resource/SIO_000831</seealso>
    let _000831 = Prefixed_Name(SIO, "000831") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000832</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative emotion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000832">http://semanticscience.org/resource/SIO_000832</seealso>
    let _000832 = Prefixed_Name(SIO, "000832") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000833</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"embarassment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000833">http://semanticscience.org/resource/SIO_000833</seealso>
    let _000833 = Prefixed_Name(SIO, "000833") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000834</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"envy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000834">http://semanticscience.org/resource/SIO_000834</seealso>
    let _000834 = Prefixed_Name(SIO, "000834") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000835</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"euphoria"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000835">http://semanticscience.org/resource/SIO_000835</seealso>
    let _000835 = Prefixed_Name(SIO, "000835") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000836</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"excitement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000836">http://semanticscience.org/resource/SIO_000836</seealso>
    let _000836 = Prefixed_Name(SIO, "000836") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000837</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fear"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000837">http://semanticscience.org/resource/SIO_000837</seealso>
    let _000837 = Prefixed_Name(SIO, "000837") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000838</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"frustration"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000838">http://semanticscience.org/resource/SIO_000838</seealso>
    let _000838 = Prefixed_Name(SIO, "000838") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000839</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gratitude"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000839">http://semanticscience.org/resource/SIO_000839</seealso>
    let _000839 = Prefixed_Name(SIO, "000839") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000840</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"happiness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000840">http://semanticscience.org/resource/SIO_000840</seealso>
    let _000840 = Prefixed_Name(SIO, "000840") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000841</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"guilt"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000841">http://semanticscience.org/resource/SIO_000841</seealso>
    let _000841 = Prefixed_Name(SIO, "000841") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000842</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"grief"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000842">http://semanticscience.org/resource/SIO_000842</seealso>
    let _000842 = Prefixed_Name(SIO, "000842") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000843</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hope"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000843">http://semanticscience.org/resource/SIO_000843</seealso>
    let _000843 = Prefixed_Name(SIO, "000843") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000844</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hostility"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000844">http://semanticscience.org/resource/SIO_000844</seealso>
    let _000844 = Prefixed_Name(SIO, "000844") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000845</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hurt"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000845">http://semanticscience.org/resource/SIO_000845</seealso>
    let _000845 = Prefixed_Name(SIO, "000845") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000846</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hysteria"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000846">http://semanticscience.org/resource/SIO_000846</seealso>
    let _000846 = Prefixed_Name(SIO, "000846") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000847</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indifference"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000847">http://semanticscience.org/resource/SIO_000847</seealso>
    let _000847 = Prefixed_Name(SIO, "000847") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000848</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000848">http://semanticscience.org/resource/SIO_000848</seealso>
    let _000848 = Prefixed_Name(SIO, "000848") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000849</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"jealousy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000849">http://semanticscience.org/resource/SIO_000849</seealso>
    let _000849 = Prefixed_Name(SIO, "000849") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000850</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000850">http://semanticscience.org/resource/SIO_000850</seealso>
    let _000850 = Prefixed_Name(SIO, "000850") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000851</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loathing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000851">http://semanticscience.org/resource/SIO_000851</seealso>
    let _000851 = Prefixed_Name(SIO, "000851") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000852</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loneliness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000852">http://semanticscience.org/resource/SIO_000852</seealso>
    let _000852 = Prefixed_Name(SIO, "000852") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000853</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lust"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000853">http://semanticscience.org/resource/SIO_000853</seealso>
    let _000853 = Prefixed_Name(SIO, "000853") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000854</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"misery"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000854">http://semanticscience.org/resource/SIO_000854</seealso>
    let _000854 = Prefixed_Name(SIO, "000854") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000855</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"panic"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000855">http://semanticscience.org/resource/SIO_000855</seealso>
    let _000855 = Prefixed_Name(SIO, "000855") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000856</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"passion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000856">http://semanticscience.org/resource/SIO_000856</seealso>
    let _000856 = Prefixed_Name(SIO, "000856") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000857</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000857">http://semanticscience.org/resource/SIO_000857</seealso>
    let _000857 = Prefixed_Name(SIO, "000857") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000858</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pleasure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000858">http://semanticscience.org/resource/SIO_000858</seealso>
    let _000858 = Prefixed_Name(SIO, "000858") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000859</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pride"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000859">http://semanticscience.org/resource/SIO_000859</seealso>
    let _000859 = Prefixed_Name(SIO, "000859") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000860</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rage"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000860">http://semanticscience.org/resource/SIO_000860</seealso>
    let _000860 = Prefixed_Name(SIO, "000860") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000861</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regret"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000861">http://semanticscience.org/resource/SIO_000861</seealso>
    let _000861 = Prefixed_Name(SIO, "000861") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000862</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"remorse"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000862">http://semanticscience.org/resource/SIO_000862</seealso>
    let _000862 = Prefixed_Name(SIO, "000862") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000863</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sadness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000863">http://semanticscience.org/resource/SIO_000863</seealso>
    let _000863 = Prefixed_Name(SIO, "000863") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000864</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"satisfaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000864">http://semanticscience.org/resource/SIO_000864</seealso>
    let _000864 = Prefixed_Name(SIO, "000864") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000865</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shame"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000865">http://semanticscience.org/resource/SIO_000865</seealso>
    let _000865 = Prefixed_Name(SIO, "000865") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000866</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shock"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000866">http://semanticscience.org/resource/SIO_000866</seealso>
    let _000866 = Prefixed_Name(SIO, "000866") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000867</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shyness"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000867">http://semanticscience.org/resource/SIO_000867</seealso>
    let _000867 = Prefixed_Name(SIO, "000867") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000868</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sorrow"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000868">http://semanticscience.org/resource/SIO_000868</seealso>
    let _000868 = Prefixed_Name(SIO, "000868") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000869</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"suffering"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000869">http://semanticscience.org/resource/SIO_000869</seealso>
    let _000869 = Prefixed_Name(SIO, "000869") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000870</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"surprise"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000870">http://semanticscience.org/resource/SIO_000870</seealso>
    let _000870 = Prefixed_Name(SIO, "000870") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000871</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"terror"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000871">http://semanticscience.org/resource/SIO_000871</seealso>
    let _000871 = Prefixed_Name(SIO, "000871") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000872</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"wonder"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000872">http://semanticscience.org/resource/SIO_000872</seealso>
    let _000872 = Prefixed_Name(SIO, "000872") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000873</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"worry"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000873">http://semanticscience.org/resource/SIO_000873</seealso>
    let _000873 = Prefixed_Name(SIO, "000873") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000875</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"department chair role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000875">http://semanticscience.org/resource/SIO_000875</seealso>
    let _000875 = Prefixed_Name(SIO, "000875") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000876</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student advisor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000876">http://semanticscience.org/resource/SIO_000876</seealso>
    let _000876 = Prefixed_Name(SIO, "000876") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000877</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"undergraduate student advisor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000877">http://semanticscience.org/resource/SIO_000877</seealso>
    let _000877 = Prefixed_Name(SIO, "000877") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000878</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"graduate student advisor role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000878">http://semanticscience.org/resource/SIO_000878</seealso>
    let _000878 = Prefixed_Name(SIO, "000878") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000879</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reactant role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000879">http://semanticscience.org/resource/SIO_000879</seealso>
    let _000879 = Prefixed_Name(SIO, "000879") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000880</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulator role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000880">http://semanticscience.org/resource/SIO_000880</seealso>
    let _000880 = Prefixed_Name(SIO, "000880") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000881</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investigational role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000881">http://semanticscience.org/resource/SIO_000881</seealso>
    let _000881 = Prefixed_Name(SIO, "000881") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000882</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"host role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000882">http://semanticscience.org/resource/SIO_000882</seealso>
    let _000882 = Prefixed_Name(SIO, "000882") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000883</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subject role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000883">http://semanticscience.org/resource/SIO_000883</seealso>
    let _000883 = Prefixed_Name(SIO, "000883") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000884</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publishing role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000884">http://semanticscience.org/resource/SIO_000884</seealso>
    let _000884 = Prefixed_Name(SIO, "000884") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000885</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publisher role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000885">http://semanticscience.org/resource/SIO_000885</seealso>
    let _000885 = Prefixed_Name(SIO, "000885") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000886</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000886">http://semanticscience.org/resource/SIO_000886</seealso>
    let _000886 = Prefixed_Name(SIO, "000886") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000887</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"buffer role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000887">http://semanticscience.org/resource/SIO_000887</seealso>
    let _000887 = Prefixed_Name(SIO, "000887") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000888</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical substance role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000888">http://semanticscience.org/resource/SIO_000888</seealso>
    let _000888 = Prefixed_Name(SIO, "000888") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000889</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular entity role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000889">http://semanticscience.org/resource/SIO_000889</seealso>
    let _000889 = Prefixed_Name(SIO, "000889") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000890</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"toxin role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000890">http://semanticscience.org/resource/SIO_000890</seealso>
    let _000890 = Prefixed_Name(SIO, "000890") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000891</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"toxic role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000891">http://semanticscience.org/resource/SIO_000891</seealso>
    let _000891 = Prefixed_Name(SIO, "000891") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000892</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"in relation from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000892">http://semanticscience.org/resource/SIO_000892</seealso>
    let _000892 = Prefixed_Name(SIO, "000892") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000893</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reagent role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000893">http://semanticscience.org/resource/SIO_000893</seealso>
    let _000893 = Prefixed_Name(SIO, "000893") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000894</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to luminesce"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000894">http://semanticscience.org/resource/SIO_000894</seealso>
    let _000894 = Prefixed_Name(SIO, "000894") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000895</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to fluoresce"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000895">http://semanticscience.org/resource/SIO_000895</seealso>
    let _000895 = Prefixed_Name(SIO, "000895") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000896</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular tracer role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000896">http://semanticscience.org/resource/SIO_000896</seealso>
    let _000896 = Prefixed_Name(SIO, "000896") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000897</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000897">http://semanticscience.org/resource/SIO_000897</seealso>
    let _000897 = Prefixed_Name(SIO, "000897") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000898</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000898">http://semanticscience.org/resource/SIO_000898</seealso>
    let _000898 = Prefixed_Name(SIO, "000898") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000899</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromosome"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000899">http://semanticscience.org/resource/SIO_000899</seealso>
    let _000899 = Prefixed_Name(SIO, "000899") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000900</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has frequency"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000900">http://semanticscience.org/resource/SIO_000900</seealso>
    let _000900 = Prefixed_Name(SIO, "000900") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000901</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is frequency of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000901">http://semanticscience.org/resource/SIO_000901</seealso>
    let _000901 = Prefixed_Name(SIO, "000901") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000902</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"top value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000902">http://semanticscience.org/resource/SIO_000902</seealso>
    let _000902 = Prefixed_Name(SIO, "000902") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000903</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bottom value axis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000903">http://semanticscience.org/resource/SIO_000903</seealso>
    let _000903 = Prefixed_Name(SIO, "000903") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000904</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000904">http://semanticscience.org/resource/SIO_000904</seealso>
    let _000904 = Prefixed_Name(SIO, "000904") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000905</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has substrate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000905">http://semanticscience.org/resource/SIO_000905</seealso>
    let _000905 = Prefixed_Name(SIO, "000905") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"map"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000906">http://semanticscience.org/resource/SIO_000906</seealso>
    let _000906 = Prefixed_Name(SIO, "000906") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000907</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heatmap"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000907">http://semanticscience.org/resource/SIO_000907</seealso>
    let _000907 = Prefixed_Name(SIO, "000907") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000908</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"streamgraph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000908">http://semanticscience.org/resource/SIO_000908</seealso>
    let _000908 = Prefixed_Name(SIO, "000908") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000909</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"boxplot"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000909">http://semanticscience.org/resource/SIO_000909</seealso>
    let _000909 = Prefixed_Name(SIO, "000909") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000910</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic heatmap"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000910">http://semanticscience.org/resource/SIO_000910</seealso>
    let _000910 = Prefixed_Name(SIO, "000910") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000911</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"histogram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000911">http://semanticscience.org/resource/SIO_000911</seealso>
    let _000911 = Prefixed_Name(SIO, "000911") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000912</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measurement scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000912">http://semanticscience.org/resource/SIO_000912</seealso>
    let _000912 = Prefixed_Name(SIO, "000912") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000913</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nomimal scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000913">http://semanticscience.org/resource/SIO_000913</seealso>
    let _000913 = Prefixed_Name(SIO, "000913") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000914</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"binary scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000914">http://semanticscience.org/resource/SIO_000914</seealso>
    let _000914 = Prefixed_Name(SIO, "000914") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000915</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"numeric scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000915">http://semanticscience.org/resource/SIO_000915</seealso>
    let _000915 = Prefixed_Name(SIO, "000915") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000916</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decimal scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000916">http://semanticscience.org/resource/SIO_000916</seealso>
    let _000916 = Prefixed_Name(SIO, "000916") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000917</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"integer scale"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000917">http://semanticscience.org/resource/SIO_000917</seealso>
    let _000917 = Prefixed_Name(SIO, "000917") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000918</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"modifying"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000918">http://semanticscience.org/resource/SIO_000918</seealso>
    let _000918 = Prefixed_Name(SIO, "000918") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000919</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reproducing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000919">http://semanticscience.org/resource/SIO_000919</seealso>
    let _000919 = Prefixed_Name(SIO, "000919") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000920</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"independent variable"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000920">http://semanticscience.org/resource/SIO_000920</seealso>
    let _000920 = Prefixed_Name(SIO, "000920") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000921</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dependent variable"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000921">http://semanticscience.org/resource/SIO_000921</seealso>
    let _000921 = Prefixed_Name(SIO, "000921") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000922</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gantt chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000922">http://semanticscience.org/resource/SIO_000922</seealso>
    let _000922 = Prefixed_Name(SIO, "000922") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000923</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"correlation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000923">http://semanticscience.org/resource/SIO_000923</seealso>
    let _000923 = Prefixed_Name(SIO, "000923") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000924</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"television program"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000924">http://semanticscience.org/resource/SIO_000924</seealso>
    let _000924 = Prefixed_Name(SIO, "000924") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000926</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radio receiver"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000926">http://semanticscience.org/resource/SIO_000926</seealso>
    let _000926 = Prefixed_Name(SIO, "000926") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000927</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"telephone"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000927">http://semanticscience.org/resource/SIO_000927</seealso>
    let _000927 = Prefixed_Name(SIO, "000927") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000928</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radar"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000928">http://semanticscience.org/resource/SIO_000928</seealso>
    let _000928 = Prefixed_Name(SIO, "000928") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000929</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pie chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000929">http://semanticscience.org/resource/SIO_000929</seealso>
    let _000929 = Prefixed_Name(SIO, "000929") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000930</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"matrix chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000930">http://semanticscience.org/resource/SIO_000930</seealso>
    let _000930 = Prefixed_Name(SIO, "000930") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000931</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"network diagram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000931">http://semanticscience.org/resource/SIO_000931</seealso>
    let _000931 = Prefixed_Name(SIO, "000931") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000932</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"block histogram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000932">http://semanticscience.org/resource/SIO_000932</seealso>
    let _000932 = Prefixed_Name(SIO, "000932") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000933</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bubble chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000933">http://semanticscience.org/resource/SIO_000933</seealso>
    let _000933 = Prefixed_Name(SIO, "000933") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000934</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stack graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000934">http://semanticscience.org/resource/SIO_000934</seealso>
    let _000934 = Prefixed_Name(SIO, "000934") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000935</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treemap"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000935">http://semanticscience.org/resource/SIO_000935</seealso>
    let _000935 = Prefixed_Name(SIO, "000935") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000936</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"word tree"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000936">http://semanticscience.org/resource/SIO_000936</seealso>
    let _000936 = Prefixed_Name(SIO, "000936") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000937</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"textual chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000937">http://semanticscience.org/resource/SIO_000937</seealso>
    let _000937 = Prefixed_Name(SIO, "000937") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000938</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tag cloud"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000938">http://semanticscience.org/resource/SIO_000938</seealso>
    let _000938 = Prefixed_Name(SIO, "000938") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000939</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phrase net diagram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000939">http://semanticscience.org/resource/SIO_000939</seealso>
    let _000939 = Prefixed_Name(SIO, "000939") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000940</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mereological chart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000940">http://semanticscience.org/resource/SIO_000940</seealso>
    let _000940 = Prefixed_Name(SIO, "000940") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000941</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conversing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000941">http://semanticscience.org/resource/SIO_000941</seealso>
    let _000941 = Prefixed_Name(SIO, "000941") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000942</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"numeric label"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000942">http://semanticscience.org/resource/SIO_000942</seealso>
    let _000942 = Prefixed_Name(SIO, "000942") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000943</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"start position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000943">http://semanticscience.org/resource/SIO_000943</seealso>
    let _000943 = Prefixed_Name(SIO, "000943") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000944</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000944">http://semanticscience.org/resource/SIO_000944</seealso>
    let _000944 = Prefixed_Name(SIO, "000944") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000945</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tree diagram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000945">http://semanticscience.org/resource/SIO_000945</seealso>
    let _000945 = Prefixed_Name(SIO, "000945") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000946</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"flowchart"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000946">http://semanticscience.org/resource/SIO_000946</seealso>
    let _000946 = Prefixed_Name(SIO, "000946") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000947</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"venn diagram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000947">http://semanticscience.org/resource/SIO_000947</seealso>
    let _000947 = Prefixed_Name(SIO, "000947") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000948</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dendrogram"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000948">http://semanticscience.org/resource/SIO_000948</seealso>
    let _000948 = Prefixed_Name(SIO, "000948") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000949</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"apprehension"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000949">http://semanticscience.org/resource/SIO_000949</seealso>
    let _000949 = Prefixed_Name(SIO, "000949") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000950</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"resentment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000950">http://semanticscience.org/resource/SIO_000950</seealso>
    let _000950 = Prefixed_Name(SIO, "000950") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000951</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pain"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000951">http://semanticscience.org/resource/SIO_000951</seealso>
    let _000951 = Prefixed_Name(SIO, "000951") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000952</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"default parameter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000952">http://semanticscience.org/resource/SIO_000952</seealso>
    let _000952 = Prefixed_Name(SIO, "000952") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000953</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"end position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000953">http://semanticscience.org/resource/SIO_000953</seealso>
    let _000953 = Prefixed_Name(SIO, "000953") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000954</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sick"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000954">http://semanticscience.org/resource/SIO_000954</seealso>
    let _000954 = Prefixed_Name(SIO, "000954") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000955">http://semanticscience.org/resource/SIO_000955</seealso>
    let _000955 = Prefixed_Name(SIO, "000955") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000956</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000956">http://semanticscience.org/resource/SIO_000956</seealso>
    let _000956 = Prefixed_Name(SIO, "000956") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000957</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"communication device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000957">http://semanticscience.org/resource/SIO_000957</seealso>
    let _000957 = Prefixed_Name(SIO, "000957") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000959</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"existence quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000959">http://semanticscience.org/resource/SIO_000959</seealso>
    let _000959 = Prefixed_Name(SIO, "000959") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000960</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000960">http://semanticscience.org/resource/SIO_000960</seealso>
    let _000960 = Prefixed_Name(SIO, "000960") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000961</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fictional"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000961">http://semanticscience.org/resource/SIO_000961</seealso>
    let _000961 = Prefixed_Name(SIO, "000961") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000962</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"virtual"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000962">http://semanticscience.org/resource/SIO_000962</seealso>
    let _000962 = Prefixed_Name(SIO, "000962") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000963</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"not started"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000963">http://semanticscience.org/resource/SIO_000963</seealso>
    let _000963 = Prefixed_Name(SIO, "000963") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000964</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard operating procedure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000964">http://semanticscience.org/resource/SIO_000964</seealso>
    let _000964 = Prefixed_Name(SIO, "000964") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000965</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agreement quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000965">http://semanticscience.org/resource/SIO_000965</seealso>
    let _000965 = Prefixed_Name(SIO, "000965") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000966</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agreement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000966">http://semanticscience.org/resource/SIO_000966</seealso>
    let _000966 = Prefixed_Name(SIO, "000966") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000967</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disagreement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000967">http://semanticscience.org/resource/SIO_000967</seealso>
    let _000967 = Prefixed_Name(SIO, "000967") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000968</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"poison role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000968">http://semanticscience.org/resource/SIO_000968</seealso>
    let _000968 = Prefixed_Name(SIO, "000968") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000969</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"communicating"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000969">http://semanticscience.org/resource/SIO_000969</seealso>
    let _000969 = Prefixed_Name(SIO, "000969") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000970</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is first part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000970">http://semanticscience.org/resource/SIO_000970</seealso>
    let _000970 = Prefixed_Name(SIO, "000970") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000971</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000971">http://semanticscience.org/resource/SIO_000971</seealso>
    let _000971 = Prefixed_Name(SIO, "000971") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000972</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000972">http://semanticscience.org/resource/SIO_000972</seealso>
    let _000972 = Prefixed_Name(SIO, "000972") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000973</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is last part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000973">http://semanticscience.org/resource/SIO_000973</seealso>
    let _000973 = Prefixed_Name(SIO, "000973") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000974</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ordered part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000974">http://semanticscience.org/resource/SIO_000974</seealso>
    let _000974 = Prefixed_Name(SIO, "000974") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000975</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is ordered part of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000975">http://semanticscience.org/resource/SIO_000975</seealso>
    let _000975 = Prefixed_Name(SIO, "000975") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000976</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observational study"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000976">http://semanticscience.org/resource/SIO_000976</seealso>
    let _000976 = Prefixed_Name(SIO, "000976") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000977</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syllable"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000977">http://semanticscience.org/resource/SIO_000977</seealso>
    let _000977 = Prefixed_Name(SIO, "000977") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000978</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consonant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000978">http://semanticscience.org/resource/SIO_000978</seealso>
    let _000978 = Prefixed_Name(SIO, "000978") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000979</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vowel"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000979">http://semanticscience.org/resource/SIO_000979</seealso>
    let _000979 = Prefixed_Name(SIO, "000979") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000980</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sign language"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000980">http://semanticscience.org/resource/SIO_000980</seealso>
    let _000980 = Prefixed_Name(SIO, "000980") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000981</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"verbal language"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000981">http://semanticscience.org/resource/SIO_000981</seealso>
    let _000981 = Prefixed_Name(SIO, "000981") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000982</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"written language"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000982">http://semanticscience.org/resource/SIO_000982</seealso>
    let _000982 = Prefixed_Name(SIO, "000982") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000983</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000983">http://semanticscience.org/resource/SIO_000983</seealso>
    let _000983 = Prefixed_Name(SIO, "000983") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000984</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genome"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000984">http://semanticscience.org/resource/SIO_000984</seealso>
    let _000984 = Prefixed_Name(SIO, "000984") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000985</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein coding gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000985">http://semanticscience.org/resource/SIO_000985</seealso>
    let _000985 = Prefixed_Name(SIO, "000985") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000986</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"functional rna coding gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000986">http://semanticscience.org/resource/SIO_000986</seealso>
    let _000986 = Prefixed_Name(SIO, "000986") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000987</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"predicted gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000987">http://semanticscience.org/resource/SIO_000987</seealso>
    let _000987 = Prefixed_Name(SIO, "000987") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000988</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pseudogene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000988">http://semanticscience.org/resource/SIO_000988</seealso>
    let _000988 = Prefixed_Name(SIO, "000988") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000989</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence assembly"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000989">http://semanticscience.org/resource/SIO_000989</seealso>
    let _000989 = Prefixed_Name(SIO, "000989") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000991</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"validated gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000991">http://semanticscience.org/resource/SIO_000991</seealso>
    let _000991 = Prefixed_Name(SIO, "000991") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000992</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unsupported"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000992">http://semanticscience.org/resource/SIO_000992</seealso>
    let _000992 = Prefixed_Name(SIO, "000992") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000993</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical-disease association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000993">http://semanticscience.org/resource/SIO_000993</seealso>
    let _000993 = Prefixed_Name(SIO, "000993") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000994</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"experiment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000994">http://semanticscience.org/resource/SIO_000994</seealso>
    let _000994 = Prefixed_Name(SIO, "000994") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000995</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"suspended"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000995">http://semanticscience.org/resource/SIO_000995</seealso>
    let _000995 = Prefixed_Name(SIO, "000995") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000996</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cancelled"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000996">http://semanticscience.org/resource/SIO_000996</seealso>
    let _000996 = Prefixed_Name(SIO, "000996") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000997</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aborted"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000997">http://semanticscience.org/resource/SIO_000997</seealso>
    let _000997 = Prefixed_Name(SIO, "000997") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000998</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"literature curation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000998">http://semanticscience.org/resource/SIO_000998</seealso>
    let _000998 = Prefixed_Name(SIO, "000998") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_000999</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"procedure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_000999">http://semanticscience.org/resource/SIO_000999</seealso>
    let _000999 = Prefixed_Name(SIO, "000999") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clinical trial"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001000">http://semanticscience.org/resource/SIO_001000</seealso>
    let _001000 = Prefixed_Name(SIO, "001000") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical diagnosis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001001">http://semanticscience.org/resource/SIO_001001</seealso>
    let _001001 = Prefixed_Name(SIO, "001001") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"differential diagnosis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001002">http://semanticscience.org/resource/SIO_001002</seealso>
    let _001002 = Prefixed_Name(SIO, "001002") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diagnostic opinion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001003">http://semanticscience.org/resource/SIO_001003</seealso>
    let _001003 = Prefixed_Name(SIO, "001003") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"opinion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001004">http://semanticscience.org/resource/SIO_001004</seealso>
    let _001004 = Prefixed_Name(SIO, "001004") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drug effect"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001005">http://semanticscience.org/resource/SIO_001005</seealso>
    let _001005 = Prefixed_Name(SIO, "001005") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drug drug interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001006">http://semanticscience.org/resource/SIO_001006</seealso>
    let _001006 = Prefixed_Name(SIO, "001006") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assay"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001007">http://semanticscience.org/resource/SIO_001007</seealso>
    let _001007 = Prefixed_Name(SIO, "001007") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"toxicity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001008">http://semanticscience.org/resource/SIO_001008</seealso>
    let _001008 = Prefixed_Name(SIO, "001008") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"toxic"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001009">http://semanticscience.org/resource/SIO_001009</seealso>
    let _001009 = Prefixed_Name(SIO, "001009") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non toxic"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001010">http://semanticscience.org/resource/SIO_001010</seealso>
    let _001010 = Prefixed_Name(SIO, "001010") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001011">http://semanticscience.org/resource/SIO_001011</seealso>
    let _001011 = Prefixed_Name(SIO, "001011") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"healthy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001012">http://semanticscience.org/resource/SIO_001012</seealso>
    let _001012 = Prefixed_Name(SIO, "001012") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"age"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001013">http://semanticscience.org/resource/SIO_001013</seealso>
    let _001013 = Prefixed_Name(SIO, "001013") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ethnicity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001014">http://semanticscience.org/resource/SIO_001014</seealso>
    let _001014 = Prefixed_Name(SIO, "001014") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"race"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001015">http://semanticscience.org/resource/SIO_001015</seealso>
    let _001015 = Prefixed_Name(SIO, "001015") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ethnic group"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001016">http://semanticscience.org/resource/SIO_001016</seealso>
    let _001016 = Prefixed_Name(SIO, "001016") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syndrome"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001017">http://semanticscience.org/resource/SIO_001017</seealso>
    let _001017 = Prefixed_Name(SIO, "001017") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ratio"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001018">http://semanticscience.org/resource/SIO_001018</seealso>
    let _001018 = Prefixed_Name(SIO, "001018") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dose"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001019">http://semanticscience.org/resource/SIO_001019</seealso>
    let _001019 = Prefixed_Name(SIO, "001019") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"effective dose"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001020">http://semanticscience.org/resource/SIO_001020</seealso>
    let _001020 = Prefixed_Name(SIO, "001020") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"expected value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001021">http://semanticscience.org/resource/SIO_001021</seealso>
    let _001021 = Prefixed_Name(SIO, "001021") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diagnostic test"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001022">http://semanticscience.org/resource/SIO_001022</seealso>
    let _001022 = Prefixed_Name(SIO, "001022") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical screening"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001023">http://semanticscience.org/resource/SIO_001023</seealso>
    let _001023 = Prefixed_Name(SIO, "001023") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical procedure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001024">http://semanticscience.org/resource/SIO_001024</seealso>
    let _001024 = Prefixed_Name(SIO, "001024") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prognosis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001025">http://semanticscience.org/resource/SIO_001025</seealso>
    let _001025 = Prefixed_Name(SIO, "001025") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"report"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001026">http://semanticscience.org/resource/SIO_001026</seealso>
    let _001026 = Prefixed_Name(SIO, "001026") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical health record"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001027">http://semanticscience.org/resource/SIO_001027</seealso>
    let _001027 = Prefixed_Name(SIO, "001027") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical report"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001028">http://semanticscience.org/resource/SIO_001028</seealso>
    let _001028 = Prefixed_Name(SIO, "001028") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peer reviewed article"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001029">http://semanticscience.org/resource/SIO_001029</seealso>
    let _001029 = Prefixed_Name(SIO, "001029") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"major version number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001030">http://semanticscience.org/resource/SIO_001030</seealso>
    let _001030 = Prefixed_Name(SIO, "001030") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minor version number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001031">http://semanticscience.org/resource/SIO_001031</seealso>
    let _001031 = Prefixed_Name(SIO, "001031") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"revision number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001032">http://semanticscience.org/resource/SIO_001032</seealso>
    let _001032 = Prefixed_Name(SIO, "001032") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"text quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001033">http://semanticscience.org/resource/SIO_001033</seealso>
    let _001033 = Prefixed_Name(SIO, "001033") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reviewed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001034">http://semanticscience.org/resource/SIO_001034</seealso>
    let _001034 = Prefixed_Name(SIO, "001034") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peer-reviewed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001035">http://semanticscience.org/resource/SIO_001035</seealso>
    let _001035 = Prefixed_Name(SIO, "001035") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"draft"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001036">http://semanticscience.org/resource/SIO_001036</seealso>
    let _001036 = Prefixed_Name(SIO, "001036") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finalized"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001037">http://semanticscience.org/resource/SIO_001037</seealso>
    let _001037 = Prefixed_Name(SIO, "001037") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"editor reviewed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001038">http://semanticscience.org/resource/SIO_001038</seealso>
    let _001038 = Prefixed_Name(SIO, "001038") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"written"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001039">http://semanticscience.org/resource/SIO_001039</seealso>
    let _001039 = Prefixed_Name(SIO, "001039") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"morpheme"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001040">http://semanticscience.org/resource/SIO_001040</seealso>
    let _001040 = Prefixed_Name(SIO, "001040") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study design"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001041">http://semanticscience.org/resource/SIO_001041</seealso>
    let _001041 = Prefixed_Name(SIO, "001041") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"recipe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001042">http://semanticscience.org/resource/SIO_001042</seealso>
    let _001042 = Prefixed_Name(SIO, "001042") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"experimental protocol"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001043">http://semanticscience.org/resource/SIO_001043</seealso>
    let _001043 = Prefixed_Name(SIO, "001043") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"viroid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001044">http://semanticscience.org/resource/SIO_001044</seealso>
    let _001044 = Prefixed_Name(SIO, "001044") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001045">http://semanticscience.org/resource/SIO_001045</seealso>
    let _001045 = Prefixed_Name(SIO, "001045") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001046">http://semanticscience.org/resource/SIO_001046</seealso>
    let _001046 = Prefixed_Name(SIO, "001046") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-polar"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001047">http://semanticscience.org/resource/SIO_001047</seealso>
    let _001047 = Prefixed_Name(SIO, "001047") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intervention study"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001048">http://semanticscience.org/resource/SIO_001048</seealso>
    let _001048 = Prefixed_Name(SIO, "001048") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sampling"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001049">http://semanticscience.org/resource/SIO_001049</seealso>
    let _001049 = Prefixed_Name(SIO, "001049") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sample"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001050">http://semanticscience.org/resource/SIO_001050</seealso>
    let _001050 = Prefixed_Name(SIO, "001050") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data analysis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001051">http://semanticscience.org/resource/SIO_001051</seealso>
    let _001051 = Prefixed_Name(SIO, "001051") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data collection"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001052">http://semanticscience.org/resource/SIO_001052</seealso>
    let _001052 = Prefixed_Name(SIO, "001052") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reason"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001053">http://semanticscience.org/resource/SIO_001053</seealso>
    let _001053 = Prefixed_Name(SIO, "001053") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measuring"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001054">http://semanticscience.org/resource/SIO_001054</seealso>
    let _001054 = Prefixed_Name(SIO, "001054") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001055">http://semanticscience.org/resource/SIO_001055</seealso>
    let _001055 = Prefixed_Name(SIO, "001055") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"character position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001056">http://semanticscience.org/resource/SIO_001056</seealso>
    let _001056 = Prefixed_Name(SIO, "001056") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"word start position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001057">http://semanticscience.org/resource/SIO_001057</seealso>
    let _001057 = Prefixed_Name(SIO, "001057") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"word end position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001058">http://semanticscience.org/resource/SIO_001058</seealso>
    let _001058 = Prefixed_Name(SIO, "001058") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gesturing"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001059">http://semanticscience.org/resource/SIO_001059</seealso>
    let _001059 = Prefixed_Name(SIO, "001059") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"planned"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001060">http://semanticscience.org/resource/SIO_001060</seealso>
    let _001060 = Prefixed_Name(SIO, "001060") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"population"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001061">http://semanticscience.org/resource/SIO_001061</seealso>
    let _001061 = Prefixed_Name(SIO, "001061") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human population"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001062">http://semanticscience.org/resource/SIO_001062</seealso>
    let _001062 = Prefixed_Name(SIO, "001062") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"family"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001063">http://semanticscience.org/resource/SIO_001063</seealso>
    let _001063 = Prefixed_Name(SIO, "001063") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"community"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001064">http://semanticscience.org/resource/SIO_001064</seealso>
    let _001064 = Prefixed_Name(SIO, "001064") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"speculation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001065">http://semanticscience.org/resource/SIO_001065</seealso>
    let _001065 = Prefixed_Name(SIO, "001065") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001066">http://semanticscience.org/resource/SIO_001066</seealso>
    let _001066 = Prefixed_Name(SIO, "001066") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlled observational cohort study"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001067">http://semanticscience.org/resource/SIO_001067</seealso>
    let _001067 = Prefixed_Name(SIO, "001067") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"control group"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001068">http://semanticscience.org/resource/SIO_001068</seealso>
    let _001068 = Prefixed_Name(SIO, "001068") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intervention group"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001069">http://semanticscience.org/resource/SIO_001069</seealso>
    let _001069 = Prefixed_Name(SIO, "001069") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"control variable"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001070">http://semanticscience.org/resource/SIO_001070</seealso>
    let _001070 = Prefixed_Name(SIO, "001070") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"text span start position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001071">http://semanticscience.org/resource/SIO_001071</seealso>
    let _001071 = Prefixed_Name(SIO, "001071") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"text span end position"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001072">http://semanticscience.org/resource/SIO_001072</seealso>
    let _001072 = Prefixed_Name(SIO, "001072") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"text span"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001073">http://semanticscience.org/resource/SIO_001073</seealso>
    let _001073 = Prefixed_Name(SIO, "001073") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"t-statistic"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001074">http://semanticscience.org/resource/SIO_001074</seealso>
    let _001074 = Prefixed_Name(SIO, "001074") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"microarray probe set identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001075">http://semanticscience.org/resource/SIO_001075</seealso>
    let _001075 = Prefixed_Name(SIO, "001075") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"microarray experiment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001076">http://semanticscience.org/resource/SIO_001076</seealso>
    let _001076 = Prefixed_Name(SIO, "001076") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene expression value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001077">http://semanticscience.org/resource/SIO_001077</seealso>
    let _001077 = Prefixed_Name(SIO, "001077") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"differential gene expression ratio"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001078">http://semanticscience.org/resource/SIO_001078</seealso>
    let _001078 = Prefixed_Name(SIO, "001078") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genotype"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001079">http://semanticscience.org/resource/SIO_001079</seealso>
    let _001079 = Prefixed_Name(SIO, "001079") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vocabulary"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001080">http://semanticscience.org/resource/SIO_001080</seealso>
    let _001080 = Prefixed_Name(SIO, "001080") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"t-statistic based increased differential gene expression"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001081">http://semanticscience.org/resource/SIO_001081</seealso>
    let _001081 = Prefixed_Name(SIO, "001081") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"t-statistic based decreased differential gene expression"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001082">http://semanticscience.org/resource/SIO_001082</seealso>
    let _001082 = Prefixed_Name(SIO, "001082") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date of database submission"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001083">http://semanticscience.org/resource/SIO_001083</seealso>
    let _001083 = Prefixed_Name(SIO, "001083") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liquid solution"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001084">http://semanticscience.org/resource/SIO_001084</seealso>
    let _001084 = Prefixed_Name(SIO, "001084") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to remove a covalent bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001085">http://semanticscience.org/resource/SIO_001085</seealso>
    let _001085 = Prefixed_Name(SIO, "001085") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to add a covalent bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001086">http://semanticscience.org/resource/SIO_001086</seealso>
    let _001086 = Prefixed_Name(SIO, "001086") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to modify electronically"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001087">http://semanticscience.org/resource/SIO_001087</seealso>
    let _001087 = Prefixed_Name(SIO, "001087") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"concentration"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001088">http://semanticscience.org/resource/SIO_001088</seealso>
    let _001088 = Prefixed_Name(SIO, "001088") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pH"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001089">http://semanticscience.org/resource/SIO_001089</seealso>
    let _001089 = Prefixed_Name(SIO, "001089") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"homogeneous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001090">http://semanticscience.org/resource/SIO_001090</seealso>
    let _001090 = Prefixed_Name(SIO, "001090") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heterogeneous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001091">http://semanticscience.org/resource/SIO_001091</seealso>
    let _001091 = Prefixed_Name(SIO, "001091") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structural quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001092">http://semanticscience.org/resource/SIO_001092</seealso>
    let _001092 = Prefixed_Name(SIO, "001092") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rigid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001093">http://semanticscience.org/resource/SIO_001093</seealso>
    let _001093 = Prefixed_Name(SIO, "001093") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001094">http://semanticscience.org/resource/SIO_001094</seealso>
    let _001094 = Prefixed_Name(SIO, "001094") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curved"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001095">http://semanticscience.org/resource/SIO_001095</seealso>
    let _001095 = Prefixed_Name(SIO, "001095") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is specialization of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001096">http://semanticscience.org/resource/SIO_001096</seealso>
    let _001096 = Prefixed_Name(SIO, "001096") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is generalization of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001097">http://semanticscience.org/resource/SIO_001097</seealso>
    let _001097 = Prefixed_Name(SIO, "001097") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is alternate of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001098">http://semanticscience.org/resource/SIO_001098</seealso>
    let _001098 = Prefixed_Name(SIO, "001098") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electronic structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001099">http://semanticscience.org/resource/SIO_001099</seealso>
    let _001099 = Prefixed_Name(SIO, "001099") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"crystal structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001100">http://semanticscience.org/resource/SIO_001100</seealso>
    let _001100 = Prefixed_Name(SIO, "001100") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"is mutual capability of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001101">http://semanticscience.org/resource/SIO_001101</seealso>
    let _001101 = Prefixed_Name(SIO, "001101") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to interact and to be interacted with"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001102">http://semanticscience.org/resource/SIO_001102</seealso>
    let _001102 = Prefixed_Name(SIO, "001102") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to gain a covalent bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001103">http://semanticscience.org/resource/SIO_001103</seealso>
    let _001103 = Prefixed_Name(SIO, "001103") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to lose a covalent bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001104">http://semanticscience.org/resource/SIO_001104</seealso>
    let _001104 = Prefixed_Name(SIO, "001104") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to ingest"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001105">http://semanticscience.org/resource/SIO_001105</seealso>
    let _001105 = Prefixed_Name(SIO, "001105") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to produce"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001106">http://semanticscience.org/resource/SIO_001106</seealso>
    let _001106 = Prefixed_Name(SIO, "001106") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001107">http://semanticscience.org/resource/SIO_001107</seealso>
    let _001107 = Prefixed_Name(SIO, "001107") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrality measure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001108">http://semanticscience.org/resource/SIO_001108</seealso>
    let _001108 = Prefixed_Name(SIO, "001108") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mean"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001109">http://semanticscience.org/resource/SIO_001109</seealso>
    let _001109 = Prefixed_Name(SIO, "001109") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"median"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001110">http://semanticscience.org/resource/SIO_001110</seealso>
    let _001110 = Prefixed_Name(SIO, "001110") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mode"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001111">http://semanticscience.org/resource/SIO_001111</seealso>
    let _001111 = Prefixed_Name(SIO, "001111") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sum"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001112">http://semanticscience.org/resource/SIO_001112</seealso>
    let _001112 = Prefixed_Name(SIO, "001112") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minimal value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001113">http://semanticscience.org/resource/SIO_001113</seealso>
    let _001113 = Prefixed_Name(SIO, "001113") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maximal value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001114">http://semanticscience.org/resource/SIO_001114</seealso>
    let _001114 = Prefixed_Name(SIO, "001114") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"member count"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001115">http://semanticscience.org/resource/SIO_001115</seealso>
    let _001115 = Prefixed_Name(SIO, "001115") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"union"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001116">http://semanticscience.org/resource/SIO_001116</seealso>
    let _001116 = Prefixed_Name(SIO, "001116") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intersection"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001117">http://semanticscience.org/resource/SIO_001117</seealso>
    let _001117 = Prefixed_Name(SIO, "001117") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001118">http://semanticscience.org/resource/SIO_001118</seealso>
    let _001118 = Prefixed_Name(SIO, "001118") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with causal mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001119">http://semanticscience.org/resource/SIO_001119</seealso>
    let _001119 = Prefixed_Name(SIO, "001119") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"therapeutic gene-disease association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001120">http://semanticscience.org/resource/SIO_001120</seealso>
    let _001120 = Prefixed_Name(SIO, "001120") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease biomarker association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001121">http://semanticscience.org/resource/SIO_001121</seealso>
    let _001121 = Prefixed_Name(SIO, "001121") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with genetic variation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001122">http://semanticscience.org/resource/SIO_001122</seealso>
    let _001122 = Prefixed_Name(SIO, "001122") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with altered gene expression"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001123">http://semanticscience.org/resource/SIO_001123</seealso>
    let _001123 = Prefixed_Name(SIO, "001123") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001124</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with post-translational modification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001124">http://semanticscience.org/resource/SIO_001124</seealso>
    let _001124 = Prefixed_Name(SIO, "001124") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of transcription"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001125">http://semanticscience.org/resource/SIO_001125</seealso>
    let _001125 = Prefixed_Name(SIO, "001125") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001126</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of translation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001126">http://semanticscience.org/resource/SIO_001126</seealso>
    let _001126 = Prefixed_Name(SIO, "001126") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001127</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of molecular quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001127">http://semanticscience.org/resource/SIO_001127</seealso>
    let _001127 = Prefixed_Name(SIO, "001127") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001128</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of molecular production"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001128">http://semanticscience.org/resource/SIO_001128</seealso>
    let _001128 = Prefixed_Name(SIO, "001128") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of molecular degradation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001129">http://semanticscience.org/resource/SIO_001129</seealso>
    let _001129 = Prefixed_Name(SIO, "001129") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001130</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein mediated regulation of translation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001130">http://semanticscience.org/resource/SIO_001130</seealso>
    let _001130 = Prefixed_Name(SIO, "001130") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rna mediated regulation of translation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001131">http://semanticscience.org/resource/SIO_001131</seealso>
    let _001131 = Prefixed_Name(SIO, "001131") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process maintenance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001132">http://semanticscience.org/resource/SIO_001132</seealso>
    let _001132 = Prefixed_Name(SIO, "001132") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001133</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased frequency of process from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001133">http://semanticscience.org/resource/SIO_001133</seealso>
    let _001133 = Prefixed_Name(SIO, "001133") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001134</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased frequency of process from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001134">http://semanticscience.org/resource/SIO_001134</seealso>
    let _001134 = Prefixed_Name(SIO, "001134") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001135</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of process frequency"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001135">http://semanticscience.org/resource/SIO_001135</seealso>
    let _001135 = Prefixed_Name(SIO, "001135") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001136</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of process duration"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001136">http://semanticscience.org/resource/SIO_001136</seealso>
    let _001136 = Prefixed_Name(SIO, "001136") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001137</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased duration of process from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001137">http://semanticscience.org/resource/SIO_001137</seealso>
    let _001137 = Prefixed_Name(SIO, "001137") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001138</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased duration of process from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001138">http://semanticscience.org/resource/SIO_001138</seealso>
    let _001138 = Prefixed_Name(SIO, "001138") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of process spatial extent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001139">http://semanticscience.org/resource/SIO_001139</seealso>
    let _001139 = Prefixed_Name(SIO, "001139") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased spatial extent of process from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001140">http://semanticscience.org/resource/SIO_001140</seealso>
    let _001140 = Prefixed_Name(SIO, "001140") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased spatial extent of process from decreased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001141">http://semanticscience.org/resource/SIO_001141</seealso>
    let _001141 = Prefixed_Name(SIO, "001141") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maintenance of spatial extent of process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001142">http://semanticscience.org/resource/SIO_001142</seealso>
    let _001142 = Prefixed_Name(SIO, "001142") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001143</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maintenance of duration of process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001143">http://semanticscience.org/resource/SIO_001143</seealso>
    let _001143 = Prefixed_Name(SIO, "001143") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maintenance of frequency of process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001144">http://semanticscience.org/resource/SIO_001144</seealso>
    let _001144 = Prefixed_Name(SIO, "001144") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001145</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of object quantity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001145">http://semanticscience.org/resource/SIO_001145</seealso>
    let _001145 = Prefixed_Name(SIO, "001145") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased object production from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001146">http://semanticscience.org/resource/SIO_001146</seealso>
    let _001146 = Prefixed_Name(SIO, "001146") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001147</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased object production from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001147">http://semanticscience.org/resource/SIO_001147</seealso>
    let _001147 = Prefixed_Name(SIO, "001147") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased object consumption from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001148">http://semanticscience.org/resource/SIO_001148</seealso>
    let _001148 = Prefixed_Name(SIO, "001148") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001149</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased object consumption from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001149">http://semanticscience.org/resource/SIO_001149</seealso>
    let _001149 = Prefixed_Name(SIO, "001149") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001150</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of object consumption"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001150">http://semanticscience.org/resource/SIO_001150</seealso>
    let _001150 = Prefixed_Name(SIO, "001150") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001151</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of object production"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001151">http://semanticscience.org/resource/SIO_001151</seealso>
    let _001151 = Prefixed_Name(SIO, "001151") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001152</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maintenance of quantity of object production"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001152">http://semanticscience.org/resource/SIO_001152</seealso>
    let _001152 = Prefixed_Name(SIO, "001152") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001153</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maintenance of level of object consumption"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001153">http://semanticscience.org/resource/SIO_001153</seealso>
    let _001153 = Prefixed_Name(SIO, "001153") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001154</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"regulates"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001154">http://semanticscience.org/resource/SIO_001154</seealso>
    let _001154 = Prefixed_Name(SIO, "001154") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001155</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is regulated by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001155">http://semanticscience.org/resource/SIO_001155</seealso>
    let _001155 = Prefixed_Name(SIO, "001155") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001156</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"results in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001156">http://semanticscience.org/resource/SIO_001156</seealso>
    let _001156 = Prefixed_Name(SIO, "001156") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001157</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is result of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001157">http://semanticscience.org/resource/SIO_001157</seealso>
    let _001157 = Prefixed_Name(SIO, "001157") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001158</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"affects"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001158">http://semanticscience.org/resource/SIO_001158</seealso>
    let _001158 = Prefixed_Name(SIO, "001158") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001159</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affected by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001159">http://semanticscience.org/resource/SIO_001159</seealso>
    let _001159 = Prefixed_Name(SIO, "001159") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001160</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"number of objects produced"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001160">http://semanticscience.org/resource/SIO_001160</seealso>
    let _001160 = Prefixed_Name(SIO, "001160") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001161</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"number of objects consumed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001161">http://semanticscience.org/resource/SIO_001161</seealso>
    let _001161 = Prefixed_Name(SIO, "001161") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001162</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"difference in number of objects produced"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001162">http://semanticscience.org/resource/SIO_001162</seealso>
    let _001162 = Prefixed_Name(SIO, "001162") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001163</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increase in number of objects produced"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001163">http://semanticscience.org/resource/SIO_001163</seealso>
    let _001163 = Prefixed_Name(SIO, "001163") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001164</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decrease in number of objects produced"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001164">http://semanticscience.org/resource/SIO_001164</seealso>
    let _001164 = Prefixed_Name(SIO, "001164") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"user account"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001165">http://semanticscience.org/resource/SIO_001165</seealso>
    let _001165 = Prefixed_Name(SIO, "001165") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001166</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"annotation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001166">http://semanticscience.org/resource/SIO_001166</seealso>
    let _001166 = Prefixed_Name(SIO, "001166") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001167</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"comment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001167">http://semanticscience.org/resource/SIO_001167</seealso>
    let _001167 = Prefixed_Name(SIO, "001167") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001168</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"audio recording"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001168">http://semanticscience.org/resource/SIO_001168</seealso>
    let _001168 = Prefixed_Name(SIO, "001168") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"issue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001169">http://semanticscience.org/resource/SIO_001169</seealso>
    let _001169 = Prefixed_Name(SIO, "001169") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001170</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"slideshow"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001170">http://semanticscience.org/resource/SIO_001170</seealso>
    let _001170 = Prefixed_Name(SIO, "001170") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database cross-reference"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001171">http://semanticscience.org/resource/SIO_001171</seealso>
    let _001171 = Prefixed_Name(SIO, "001171") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001172</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exact cross-reference"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001172">http://semanticscience.org/resource/SIO_001172</seealso>
    let _001172 = Prefixed_Name(SIO, "001172") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001173</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double stranded DNA"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001173">http://semanticscience.org/resource/SIO_001173</seealso>
    let _001173 = Prefixed_Name(SIO, "001173") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001174</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid strand"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001174">http://semanticscience.org/resource/SIO_001174</seealso>
    let _001174 = Prefixed_Name(SIO, "001174") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001175</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positive nucleic acid strand"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001175">http://semanticscience.org/resource/SIO_001175</seealso>
    let _001175 = Prefixed_Name(SIO, "001175") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative nucleic acid strand"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001176">http://semanticscience.org/resource/SIO_001176</seealso>
    let _001176 = Prefixed_Name(SIO, "001176") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001177</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double stranded nucleic acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001177">http://semanticscience.org/resource/SIO_001177</seealso>
    let _001177 = Prefixed_Name(SIO, "001177") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double stranded RNA"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001178">http://semanticscience.org/resource/SIO_001178</seealso>
    let _001178 = Prefixed_Name(SIO, "001178") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"full agreement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001179">http://semanticscience.org/resource/SIO_001179</seealso>
    let _001179 = Prefixed_Name(SIO, "001179") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass spectrometry experiment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001180">http://semanticscience.org/resource/SIO_001180</seealso>
    let _001180 = Prefixed_Name(SIO, "001180") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001181</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"full disagreement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001181">http://semanticscience.org/resource/SIO_001181</seealso>
    let _001181 = Prefixed_Name(SIO, "001181") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribosomal RNA gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001182">http://semanticscience.org/resource/SIO_001182</seealso>
    let _001182 = Prefixed_Name(SIO, "001182") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001183">http://semanticscience.org/resource/SIO_001183</seealso>
    let _001183 = Prefixed_Name(SIO, "001183") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"slope"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001184">http://semanticscience.org/resource/SIO_001184</seealso>
    let _001184 = Prefixed_Name(SIO, "001184") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"software process identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001185">http://semanticscience.org/resource/SIO_001185</seealso>
    let _001185 = Prefixed_Name(SIO, "001185") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypothetical"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001186">http://semanticscience.org/resource/SIO_001186</seealso>
    let _001186 = Prefixed_Name(SIO, "001186") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001187</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"database row"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001187">http://semanticscience.org/resource/SIO_001187</seealso>
    let _001187 = Prefixed_Name(SIO, "001187") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001188</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SADI semantic web service"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001188">http://semanticscience.org/resource/SIO_001188</seealso>
    let _001188 = Prefixed_Name(SIO, "001188") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001189</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"semantic web service"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001189">http://semanticscience.org/resource/SIO_001189</seealso>
    let _001189 = Prefixed_Name(SIO, "001189") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001190</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"REST web service"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001190">http://semanticscience.org/resource/SIO_001190</seealso>
    let _001190 = Prefixed_Name(SIO, "001190") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001191</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SOAP web service"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001191">http://semanticscience.org/resource/SIO_001191</seealso>
    let _001191 = Prefixed_Name(SIO, "001191") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001192</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"web service invocation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001192">http://semanticscience.org/resource/SIO_001192</seealso>
    let _001192 = Prefixed_Name(SIO, "001192") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001193</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SADI web service invocation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001193">http://semanticscience.org/resource/SIO_001193</seealso>
    let _001193 = Prefixed_Name(SIO, "001193") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001194</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"media"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001194">http://semanticscience.org/resource/SIO_001194</seealso>
    let _001194 = Prefixed_Name(SIO, "001194") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"behaviour"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001195">http://semanticscience.org/resource/SIO_001195</seealso>
    let _001195 = Prefixed_Name(SIO, "001195") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"history"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001196">http://semanticscience.org/resource/SIO_001196</seealso>
    let _001196 = Prefixed_Name(SIO, "001196") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structural motif"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001197">http://semanticscience.org/resource/SIO_001197</seealso>
    let _001197 = Prefixed_Name(SIO, "001197") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001198</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consensus"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001198">http://semanticscience.org/resource/SIO_001198</seealso>
    let _001198 = Prefixed_Name(SIO, "001198") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001199</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased molecular degradation from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001199">http://semanticscience.org/resource/SIO_001199</seealso>
    let _001199 = Prefixed_Name(SIO, "001199") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001200</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased molecular degradation from decreased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001200">http://semanticscience.org/resource/SIO_001200</seealso>
    let _001200 = Prefixed_Name(SIO, "001200") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased molecular degradation from decreased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001201">http://semanticscience.org/resource/SIO_001201</seealso>
    let _001201 = Prefixed_Name(SIO, "001201") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased molecular degradation from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001202">http://semanticscience.org/resource/SIO_001202</seealso>
    let _001202 = Prefixed_Name(SIO, "001202") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased molecular production from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001203">http://semanticscience.org/resource/SIO_001203</seealso>
    let _001203 = Prefixed_Name(SIO, "001203") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001204</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased molecular production from increased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001204">http://semanticscience.org/resource/SIO_001204</seealso>
    let _001204 = Prefixed_Name(SIO, "001204") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001205</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased molecular production from decreased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001205">http://semanticscience.org/resource/SIO_001205</seealso>
    let _001205 = Prefixed_Name(SIO, "001205") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001206</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased molecular production from decreased regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001206">http://semanticscience.org/resource/SIO_001206</seealso>
    let _001206 = Prefixed_Name(SIO, "001206") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001207</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"increased chemical destruction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001207">http://semanticscience.org/resource/SIO_001207</seealso>
    let _001207 = Prefixed_Name(SIO, "001207") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001208</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decreased chemical destruction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001208">http://semanticscience.org/resource/SIO_001208</seealso>
    let _001208 = Prefixed_Name(SIO, "001208") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001209</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assertional qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001209">http://semanticscience.org/resource/SIO_001209</seealso>
    let _001209 = Prefixed_Name(SIO, "001209") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positive"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001210">http://semanticscience.org/resource/SIO_001210</seealso>
    let _001210 = Prefixed_Name(SIO, "001210") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001211</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001211">http://semanticscience.org/resource/SIO_001211</seealso>
    let _001211 = Prefixed_Name(SIO, "001211") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001212</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intensity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001212">http://semanticscience.org/resource/SIO_001212</seealso>
    let _001212 = Prefixed_Name(SIO, "001212") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001213</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mild"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001213">http://semanticscience.org/resource/SIO_001213</seealso>
    let _001213 = Prefixed_Name(SIO, "001213") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001214</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"moderate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001214">http://semanticscience.org/resource/SIO_001214</seealso>
    let _001214 = Prefixed_Name(SIO, "001214") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001215</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"severe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001215">http://semanticscience.org/resource/SIO_001215</seealso>
    let _001215 = Prefixed_Name(SIO, "001215") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fatal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001216">http://semanticscience.org/resource/SIO_001216</seealso>
    let _001216 = Prefixed_Name(SIO, "001216") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001217</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strong"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001217">http://semanticscience.org/resource/SIO_001217</seealso>
    let _001217 = Prefixed_Name(SIO, "001217") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weak"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001218">http://semanticscience.org/resource/SIO_001218</seealso>
    let _001218 = Prefixed_Name(SIO, "001218") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to test a hypothesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001219">http://semanticscience.org/resource/SIO_001219</seealso>
    let _001219 = Prefixed_Name(SIO, "001219") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to characterize"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001220">http://semanticscience.org/resource/SIO_001220</seealso>
    let _001220 = Prefixed_Name(SIO, "001220") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to describe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001221">http://semanticscience.org/resource/SIO_001221</seealso>
    let _001221 = Prefixed_Name(SIO, "001221") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"5' splice site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001222">http://semanticscience.org/resource/SIO_001222</seealso>
    let _001222 = Prefixed_Name(SIO, "001222") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3' splice site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001223">http://semanticscience.org/resource/SIO_001223</seealso>
    let _001223 = Prefixed_Name(SIO, "001223") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amino acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001224">http://semanticscience.org/resource/SIO_001224</seealso>
    let _001224 = Prefixed_Name(SIO, "001224") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cis regulatory element"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001225">http://semanticscience.org/resource/SIO_001225</seealso>
    let _001225 = Prefixed_Name(SIO, "001225") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001226</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trans-regulatory element"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001226">http://semanticscience.org/resource/SIO_001226</seealso>
    let _001226 = Prefixed_Name(SIO, "001226") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small cytoplasmic RNA (scRNA) gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001227">http://semanticscience.org/resource/SIO_001227</seealso>
    let _001227 = Prefixed_Name(SIO, "001227") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small nuclear RNA (snRNA) gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001228">http://semanticscience.org/resource/SIO_001228</seealso>
    let _001228 = Prefixed_Name(SIO, "001228") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001229</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small nucleolar RNA (snoRNA) gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001229">http://semanticscience.org/resource/SIO_001229</seealso>
    let _001229 = Prefixed_Name(SIO, "001229") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001230</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transfer RNA (tRNA) gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001230">http://semanticscience.org/resource/SIO_001230</seealso>
    let _001230 = Prefixed_Name(SIO, "001230") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small cytoplasmic RNA (scRNA)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001231">http://semanticscience.org/resource/SIO_001231</seealso>
    let _001231 = Prefixed_Name(SIO, "001231") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transfer RNA (tRNA)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001232">http://semanticscience.org/resource/SIO_001232</seealso>
    let _001232 = Prefixed_Name(SIO, "001232") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small nuclear RNA (snRNA)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001233">http://semanticscience.org/resource/SIO_001233</seealso>
    let _001233 = Prefixed_Name(SIO, "001233") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"small nucleolar RNA (snoRNA)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001234">http://semanticscience.org/resource/SIO_001234</seealso>
    let _001234 = Prefixed_Name(SIO, "001234") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-protein coding RNA (ncRNA)"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001235">http://semanticscience.org/resource/SIO_001235</seealso>
    let _001235 = Prefixed_Name(SIO, "001235") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001236</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data collection device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001236">http://semanticscience.org/resource/SIO_001236</seealso>
    let _001236 = Prefixed_Name(SIO, "001236") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001237</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass spectrometer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001237">http://semanticscience.org/resource/SIO_001237</seealso>
    let _001237 = Prefixed_Name(SIO, "001237") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001238</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"microarray device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001238">http://semanticscience.org/resource/SIO_001238</seealso>
    let _001238 = Prefixed_Name(SIO, "001238") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001239</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to identify"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001239">http://semanticscience.org/resource/SIO_001239</seealso>
    let _001239 = Prefixed_Name(SIO, "001239") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001240</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nmr device"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001240">http://semanticscience.org/resource/SIO_001240</seealso>
    let _001240 = Prefixed_Name(SIO, "001240") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001241</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalog"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001241">http://semanticscience.org/resource/SIO_001241</seealso>
    let _001241 = Prefixed_Name(SIO, "001241") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001242</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is identical to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001242">http://semanticscience.org/resource/SIO_001242</seealso>
    let _001242 = Prefixed_Name(SIO, "001242") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001243</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"likelihood"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001243">http://semanticscience.org/resource/SIO_001243</seealso>
    let _001243 = Prefixed_Name(SIO, "001243") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001244</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"log likelihood"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001244">http://semanticscience.org/resource/SIO_001244</seealso>
    let _001244 = Prefixed_Name(SIO, "001244") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001245</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard score"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001245">http://semanticscience.org/resource/SIO_001245</seealso>
    let _001245 = Prefixed_Name(SIO, "001245") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001246</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001246">http://semanticscience.org/resource/SIO_001246</seealso>
    let _001246 = Prefixed_Name(SIO, "001246") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001247</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is transitively related to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001247">http://semanticscience.org/resource/SIO_001247</seealso>
    let _001247 = Prefixed_Name(SIO, "001247") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001248</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001248">http://semanticscience.org/resource/SIO_001248</seealso>
    let _001248 = Prefixed_Name(SIO, "001248") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001249</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closed interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001249">http://semanticscience.org/resource/SIO_001249</seealso>
    let _001249 = Prefixed_Name(SIO, "001249") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001250</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical-pathway association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001250">http://semanticscience.org/resource/SIO_001250</seealso>
    let _001250 = Prefixed_Name(SIO, "001250") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001251</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left open interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001251">http://semanticscience.org/resource/SIO_001251</seealso>
    let _001251 = Prefixed_Name(SIO, "001251") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001252</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right open interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001252">http://semanticscience.org/resource/SIO_001252</seealso>
    let _001252 = Prefixed_Name(SIO, "001252") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001253</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right closed interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001253">http://semanticscience.org/resource/SIO_001253</seealso>
    let _001253 = Prefixed_Name(SIO, "001253") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001254</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left closed interval"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001254">http://semanticscience.org/resource/SIO_001254</seealso>
    let _001254 = Prefixed_Name(SIO, "001254") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pharmacokinetic pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001255">http://semanticscience.org/resource/SIO_001255</seealso>
    let _001255 = Prefixed_Name(SIO, "001255") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pharmacodynamic pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001256">http://semanticscience.org/resource/SIO_001256</seealso>
    let _001256 = Prefixed_Name(SIO, "001256") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical-gene assocation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001257">http://semanticscience.org/resource/SIO_001257</seealso>
    let _001257 = Prefixed_Name(SIO, "001257") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001258</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"set item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001258">http://semanticscience.org/resource/SIO_001258</seealso>
    let _001258 = Prefixed_Name(SIO, "001258") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001259</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001259">http://semanticscience.org/resource/SIO_001259</seealso>
    let _001259 = Prefixed_Name(SIO, "001259") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001260</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"list item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001260">http://semanticscience.org/resource/SIO_001260</seealso>
    let _001260 = Prefixed_Name(SIO, "001260") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001261</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ordered list item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001261">http://semanticscience.org/resource/SIO_001261</seealso>
    let _001261 = Prefixed_Name(SIO, "001261") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anatomical entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001262">http://semanticscience.org/resource/SIO_001262</seealso>
    let _001262 = Prefixed_Name(SIO, "001262") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001263</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zygosity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001263">http://semanticscience.org/resource/SIO_001263</seealso>
    let _001263 = Prefixed_Name(SIO, "001263") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001264</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"homozygous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001264">http://semanticscience.org/resource/SIO_001264</seealso>
    let _001264 = Prefixed_Name(SIO, "001264") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001265</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heterozygous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001265">http://semanticscience.org/resource/SIO_001265</seealso>
    let _001265 = Prefixed_Name(SIO, "001265") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001266</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hemizygous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001266">http://semanticscience.org/resource/SIO_001266</seealso>
    let _001266 = Prefixed_Name(SIO, "001266") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001267</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nullizygous"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001267">http://semanticscience.org/resource/SIO_001267</seealso>
    let _001267 = Prefixed_Name(SIO, "001267") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"parental transmission"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001268">http://semanticscience.org/resource/SIO_001268</seealso>
    let _001268 = Prefixed_Name(SIO, "001268") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001269</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maternally transmitted"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001269">http://semanticscience.org/resource/SIO_001269</seealso>
    let _001269 = Prefixed_Name(SIO, "001269") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001270</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"paternally transmitted"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001270">http://semanticscience.org/resource/SIO_001270</seealso>
    let _001270 = Prefixed_Name(SIO, "001270") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001271</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"helicity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001271">http://semanticscience.org/resource/SIO_001271</seealso>
    let _001271 = Prefixed_Name(SIO, "001271") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001272</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"circularly helical"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001272">http://semanticscience.org/resource/SIO_001272</seealso>
    let _001272 = Prefixed_Name(SIO, "001272") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001273</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left-handed helical"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001273">http://semanticscience.org/resource/SIO_001273</seealso>
    let _001273 = Prefixed_Name(SIO, "001273") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001274</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right-handed helical"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001274">http://semanticscience.org/resource/SIO_001274</seealso>
    let _001274 = Prefixed_Name(SIO, "001274") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001275</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coding frame offset"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001275">http://semanticscience.org/resource/SIO_001275</seealso>
    let _001275 = Prefixed_Name(SIO, "001275") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coding sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001276">http://semanticscience.org/resource/SIO_001276</seealso>
    let _001276 = Prefixed_Name(SIO, "001276") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001277</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has data item"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001277">http://semanticscience.org/resource/SIO_001277</seealso>
    let _001277 = Prefixed_Name(SIO, "001277") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is data item in"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001278">http://semanticscience.org/resource/SIO_001278</seealso>
    let _001278 = Prefixed_Name(SIO, "001278") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001279</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has phenotype"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001279">http://semanticscience.org/resource/SIO_001279</seealso>
    let _001279 = Prefixed_Name(SIO, "001279") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is phenotype of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001280">http://semanticscience.org/resource/SIO_001280</seealso>
    let _001280 = Prefixed_Name(SIO, "001280") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"humiliation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001281">http://semanticscience.org/resource/SIO_001281</seealso>
    let _001281 = Prefixed_Name(SIO, "001281") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001282</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hunger"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001282">http://semanticscience.org/resource/SIO_001282</seealso>
    let _001282 = Prefixed_Name(SIO, "001282") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"discouragement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001283">http://semanticscience.org/resource/SIO_001283</seealso>
    let _001283 = Prefixed_Name(SIO, "001283") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"satisfaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001284">http://semanticscience.org/resource/SIO_001284</seealso>
    let _001284 = Prefixed_Name(SIO, "001284") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"suicidal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001285">http://semanticscience.org/resource/SIO_001285</seealso>
    let _001285 = Prefixed_Name(SIO, "001285") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001286</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"irritability"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001286">http://semanticscience.org/resource/SIO_001286</seealso>
    let _001286 = Prefixed_Name(SIO, "001286") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001287</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indecision"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001287">http://semanticscience.org/resource/SIO_001287</seealso>
    let _001287 = Prefixed_Name(SIO, "001287") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001288</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temporal qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001288">http://semanticscience.org/resource/SIO_001288</seealso>
    let _001288 = Prefixed_Name(SIO, "001288") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001289</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"never"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001289">http://semanticscience.org/resource/SIO_001289</seealso>
    let _001289 = Prefixed_Name(SIO, "001289") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001290</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"some of the time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001290">http://semanticscience.org/resource/SIO_001290</seealso>
    let _001290 = Prefixed_Name(SIO, "001290") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001291</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"most of the time"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001291">http://semanticscience.org/resource/SIO_001291</seealso>
    let _001291 = Prefixed_Name(SIO, "001291") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001292</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"always"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001292">http://semanticscience.org/resource/SIO_001292</seealso>
    let _001292 = Prefixed_Name(SIO, "001292") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001293</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001293">http://semanticscience.org/resource/SIO_001293</seealso>
    let _001293 = Prefixed_Name(SIO, "001293") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001294</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"very poor quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001294">http://semanticscience.org/resource/SIO_001294</seealso>
    let _001294 = Prefixed_Name(SIO, "001294") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"poor quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001295">http://semanticscience.org/resource/SIO_001295</seealso>
    let _001295 = Prefixed_Name(SIO, "001295") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neither good nor poor quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001296">http://semanticscience.org/resource/SIO_001296</seealso>
    let _001296 = Prefixed_Name(SIO, "001296") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001297</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"good quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001297">http://semanticscience.org/resource/SIO_001297</seealso>
    let _001297 = Prefixed_Name(SIO, "001297") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001298</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"very good quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001298">http://semanticscience.org/resource/SIO_001298</seealso>
    let _001298 = Prefixed_Name(SIO, "001298") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001299</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quantity modifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001299">http://semanticscience.org/resource/SIO_001299</seealso>
    let _001299 = Prefixed_Name(SIO, "001299") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ovopub"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001300">http://semanticscience.org/resource/SIO_001300</seealso>
    let _001300 = Prefixed_Name(SIO, "001300") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection ovopub"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001301">http://semanticscience.org/resource/SIO_001301</seealso>
    let _001301 = Prefixed_Name(SIO, "001301") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assertion ovopub"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001302">http://semanticscience.org/resource/SIO_001302</seealso>
    let _001302 = Prefixed_Name(SIO, "001302") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001303</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"none quantifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001303">http://semanticscience.org/resource/SIO_001303</seealso>
    let _001303 = Prefixed_Name(SIO, "001303") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"a little quantifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001304">http://semanticscience.org/resource/SIO_001304</seealso>
    let _001304 = Prefixed_Name(SIO, "001304") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001305</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"moderately quantifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001305">http://semanticscience.org/resource/SIO_001305</seealso>
    let _001305 = Prefixed_Name(SIO, "001305") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mostly quantifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001306">http://semanticscience.org/resource/SIO_001306</seealso>
    let _001306 = Prefixed_Name(SIO, "001306") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"completely quantifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001307">http://semanticscience.org/resource/SIO_001307</seealso>
    let _001307 = Prefixed_Name(SIO, "001307") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"satisfaction qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001308">http://semanticscience.org/resource/SIO_001308</seealso>
    let _001308 = Prefixed_Name(SIO, "001308") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"very dissatisfied qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001309">http://semanticscience.org/resource/SIO_001309</seealso>
    let _001309 = Prefixed_Name(SIO, "001309") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dissatisfied qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001310">http://semanticscience.org/resource/SIO_001310</seealso>
    let _001310 = Prefixed_Name(SIO, "001310") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neither satisfied or dissatisfied qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001311">http://semanticscience.org/resource/SIO_001311</seealso>
    let _001311 = Prefixed_Name(SIO, "001311") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001312</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"satisfied qualifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001312">http://semanticscience.org/resource/SIO_001312</seealso>
    let _001312 = Prefixed_Name(SIO, "001312") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001313</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"excellent quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001313">http://semanticscience.org/resource/SIO_001313</seealso>
    let _001313 = Prefixed_Name(SIO, "001313") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001314</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date of issue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001314">http://semanticscience.org/resource/SIO_001314</seealso>
    let _001314 = Prefixed_Name(SIO, "001314") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001315</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"author list"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001315">http://semanticscience.org/resource/SIO_001315</seealso>
    let _001315 = Prefixed_Name(SIO, "001315") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ordered list"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001316">http://semanticscience.org/resource/SIO_001316</seealso>
    let _001316 = Prefixed_Name(SIO, "001316") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001317</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"middle name"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001317">http://semanticscience.org/resource/SIO_001317</seealso>
    let _001317 = Prefixed_Name(SIO, "001317") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001318</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"middle initial"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001318">http://semanticscience.org/resource/SIO_001318</seealso>
    let _001318 = Prefixed_Name(SIO, "001318") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001319</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"telephone number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001319">http://semanticscience.org/resource/SIO_001319</seealso>
    let _001319 = Prefixed_Name(SIO, "001319") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular phone number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001320">http://semanticscience.org/resource/SIO_001320</seealso>
    let _001320 = Prefixed_Name(SIO, "001320") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001321</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fax number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001321">http://semanticscience.org/resource/SIO_001321</seealso>
    let _001321 = Prefixed_Name(SIO, "001321") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001322</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IP number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001322">http://semanticscience.org/resource/SIO_001322</seealso>
    let _001322 = Prefixed_Name(SIO, "001322") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"email address"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001323">http://semanticscience.org/resource/SIO_001323</seealso>
    let _001323 = Prefixed_Name(SIO, "001323") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001324</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"work phone number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001324">http://semanticscience.org/resource/SIO_001324</seealso>
    let _001324 = Prefixed_Name(SIO, "001324") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001325</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"home phone number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001325">http://semanticscience.org/resource/SIO_001325</seealso>
    let _001325 = Prefixed_Name(SIO, "001325") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001326</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"status descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001326">http://semanticscience.org/resource/SIO_001326</seealso>
    let _001326 = Prefixed_Name(SIO, "001326") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001327</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein expression value"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001327">http://semanticscience.org/resource/SIO_001327</seealso>
    let _001327 = Prefixed_Name(SIO, "001327") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001328</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"copy number variation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001328">http://semanticscience.org/resource/SIO_001328</seealso>
    let _001328 = Prefixed_Name(SIO, "001328") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001329</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single nucleotide variation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001329">http://semanticscience.org/resource/SIO_001329</seealso>
    let _001329 = Prefixed_Name(SIO, "001329") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001330</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"metadata"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001330">http://semanticscience.org/resource/SIO_001330</seealso>
    let _001330 = Prefixed_Name(SIO, "001330") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001331</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diagnosis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001331">http://semanticscience.org/resource/SIO_001331</seealso>
    let _001331 = Prefixed_Name(SIO, "001331") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001332</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"directed acyclic graph"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001332">http://semanticscience.org/resource/SIO_001332</seealso>
    let _001332 = Prefixed_Name(SIO, "001332") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001333</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arc"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001333">http://semanticscience.org/resource/SIO_001333</seealso>
    let _001333 = Prefixed_Name(SIO, "001333") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001334</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"edge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001334">http://semanticscience.org/resource/SIO_001334</seealso>
    let _001334 = Prefixed_Name(SIO, "001334") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"node"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001335">http://semanticscience.org/resource/SIO_001335</seealso>
    let _001335 = Prefixed_Name(SIO, "001335") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001336</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"epimer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001336">http://semanticscience.org/resource/SIO_001336</seealso>
    let _001336 = Prefixed_Name(SIO, "001336") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"epimer association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001337">http://semanticscience.org/resource/SIO_001337</seealso>
    let _001337 = Prefixed_Name(SIO, "001337") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mereological quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001338">http://semanticscience.org/resource/SIO_001338</seealso>
    let _001338 = Prefixed_Name(SIO, "001338") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001339</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"empty"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001339">http://semanticscience.org/resource/SIO_001339</seealso>
    let _001339 = Prefixed_Name(SIO, "001339") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"full"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001340">http://semanticscience.org/resource/SIO_001340</seealso>
    let _001340 = Prefixed_Name(SIO, "001340") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"containment quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001341">http://semanticscience.org/resource/SIO_001341</seealso>
    let _001341 = Prefixed_Name(SIO, "001341") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with modifying mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001342">http://semanticscience.org/resource/SIO_001342</seealso>
    let _001342 = Prefixed_Name(SIO, "001342") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with susceptibility mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001343">http://semanticscience.org/resource/SIO_001343</seealso>
    let _001343 = Prefixed_Name(SIO, "001343") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with germline causal mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001344">http://semanticscience.org/resource/SIO_001344</seealso>
    let _001344 = Prefixed_Name(SIO, "001344") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with somatic causal mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001345">http://semanticscience.org/resource/SIO_001345</seealso>
    let _001345 = Prefixed_Name(SIO, "001345") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with somatic modifying mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001346">http://semanticscience.org/resource/SIO_001346</seealso>
    let _001346 = Prefixed_Name(SIO, "001346") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with germline modifying mutation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001347">http://semanticscience.org/resource/SIO_001347</seealso>
    let _001347 = Prefixed_Name(SIO, "001347") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001348</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fusion gene-disease association"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001348">http://semanticscience.org/resource/SIO_001348</seealso>
    let _001348 = Prefixed_Name(SIO, "001348") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001349</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with chromosomal rearrangement"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001349">http://semanticscience.org/resource/SIO_001349</seealso>
    let _001349 = Prefixed_Name(SIO, "001349") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001350</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene-disease association linked with genomic alterations"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001350">http://semanticscience.org/resource/SIO_001350</seealso>
    let _001350 = Prefixed_Name(SIO, "001350") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisGeNET disease specificity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001351">http://semanticscience.org/resource/SIO_001351</seealso>
    let _001351 = Prefixed_Name(SIO, "001351") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DisGeNET Pleiotropy Index"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001352">http://semanticscience.org/resource/SIO_001352</seealso>
    let _001352 = Prefixed_Name(SIO, "001352") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specialized object"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001353">http://semanticscience.org/resource/SIO_001353</seealso>
    let _001353 = Prefixed_Name(SIO, "001353") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001354</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"week"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001354">http://semanticscience.org/resource/SIO_001354</seealso>
    let _001354 = Prefixed_Name(SIO, "001354") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001355</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specific gravity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001355">http://semanticscience.org/resource/SIO_001355</seealso>
    let _001355 = Prefixed_Name(SIO, "001355") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001356</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information encoding"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001356">http://semanticscience.org/resource/SIO_001356</seealso>
    let _001356 = Prefixed_Name(SIO, "001356") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001357</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"speech"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001357">http://semanticscience.org/resource/SIO_001357</seealso>
    let _001357 = Prefixed_Name(SIO, "001357") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to retrieve"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001358">http://semanticscience.org/resource/SIO_001358</seealso>
    let _001358 = Prefixed_Name(SIO, "001358") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information translation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001359">http://semanticscience.org/resource/SIO_001359</seealso>
    let _001359 = Prefixed_Name(SIO, "001359") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information decoding"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001360">http://semanticscience.org/resource/SIO_001360</seealso>
    let _001360 = Prefixed_Name(SIO, "001360") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001361</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to store"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001361">http://semanticscience.org/resource/SIO_001361</seealso>
    let _001361 = Prefixed_Name(SIO, "001361") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to encode information"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001362">http://semanticscience.org/resource/SIO_001362</seealso>
    let _001362 = Prefixed_Name(SIO, "001362") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001363</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to maintain information"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001363">http://semanticscience.org/resource/SIO_001363</seealso>
    let _001363 = Prefixed_Name(SIO, "001363") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001364</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to decode information"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001364">http://semanticscience.org/resource/SIO_001364</seealso>
    let _001364 = Prefixed_Name(SIO, "001364") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001365</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate of change"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001365">http://semanticscience.org/resource/SIO_001365</seealso>
    let _001365 = Prefixed_Name(SIO, "001365") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001366</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information maintenance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001366">http://semanticscience.org/resource/SIO_001366</seealso>
    let _001366 = Prefixed_Name(SIO, "001366") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"frequency"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001367">http://semanticscience.org/resource/SIO_001367</seealso>
    let _001367 = Prefixed_Name(SIO, "001367") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001368</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"speed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001368">http://semanticscience.org/resource/SIO_001368</seealso>
    let _001368 = Prefixed_Name(SIO, "001368") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"velocity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001369">http://semanticscience.org/resource/SIO_001369</seealso>
    let _001369 = Prefixed_Name(SIO, "001369") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001370</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"slide"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001370">http://semanticscience.org/resource/SIO_001370</seealso>
    let _001370 = Prefixed_Name(SIO, "001370") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001371">http://semanticscience.org/resource/SIO_001371</seealso>
    let _001371 = Prefixed_Name(SIO, "001371") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001372</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legislation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001372">http://semanticscience.org/resource/SIO_001372</seealso>
    let _001372 = Prefixed_Name(SIO, "001372") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001373</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal document"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001373">http://semanticscience.org/resource/SIO_001373</seealso>
    let _001373 = Prefixed_Name(SIO, "001373") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brief"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001374">http://semanticscience.org/resource/SIO_001374</seealso>
    let _001374 = Prefixed_Name(SIO, "001374") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"book section"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001375">http://semanticscience.org/resource/SIO_001375</seealso>
    let _001375 = Prefixed_Name(SIO, "001375") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_001376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bill"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_001376">http://semanticscience.org/resource/SIO_001376</seealso>
    let _001376 = Prefixed_Name(SIO, "001376") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010000">http://semanticscience.org/resource/SIO_010000</seealso>
    let _010000 = Prefixed_Name(SIO, "010000") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010001">http://semanticscience.org/resource/SIO_010001</seealso>
    let _010001 = Prefixed_Name(SIO, "010001") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tissue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010002">http://semanticscience.org/resource/SIO_010002</seealso>
    let _010002 = Prefixed_Name(SIO, "010002") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organ"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010003">http://semanticscience.org/resource/SIO_010003</seealso>
    let _010003 = Prefixed_Name(SIO, "010003") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010004">http://semanticscience.org/resource/SIO_010004</seealso>
    let _010004 = Prefixed_Name(SIO, "010004") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weak submolecular component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010005">http://semanticscience.org/resource/SIO_010005</seealso>
    let _010005 = Prefixed_Name(SIO, "010005") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polypeptide"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010007">http://semanticscience.org/resource/SIO_010007</seealso>
    let _010007 = Prefixed_Name(SIO, "010007") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010008">http://semanticscience.org/resource/SIO_010008</seealso>
    let _010008 = Prefixed_Name(SIO, "010008") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonucleic acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010009">http://semanticscience.org/resource/SIO_010009</seealso>
    let _010009 = Prefixed_Name(SIO, "010009") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonucleic acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010010">http://semanticscience.org/resource/SIO_010010</seealso>
    let _010010 = Prefixed_Name(SIO, "010010") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lipid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010011">http://semanticscience.org/resource/SIO_010011</seealso>
    let _010011 = Prefixed_Name(SIO, "010011") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010013">http://semanticscience.org/resource/SIO_010013</seealso>
    let _010013 = Prefixed_Name(SIO, "010013") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary structure descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010014">http://semanticscience.org/resource/SIO_010014</seealso>
    let _010014 = Prefixed_Name(SIO, "010014") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010015">http://semanticscience.org/resource/SIO_010015</seealso>
    let _010015 = Prefixed_Name(SIO, "010015") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010016">http://semanticscience.org/resource/SIO_010016</seealso>
    let _010016 = Prefixed_Name(SIO, "010016") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonucleic acid sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010017">http://semanticscience.org/resource/SIO_010017</seealso>
    let _010017 = Prefixed_Name(SIO, "010017") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonucleic acid sequence"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010018">http://semanticscience.org/resource/SIO_010018</seealso>
    let _010018 = Prefixed_Name(SIO, "010018") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010019">http://semanticscience.org/resource/SIO_010019</seealso>
    let _010019 = Prefixed_Name(SIO, "010019") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"submolecular entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010020">http://semanticscience.org/resource/SIO_010020</seealso>
    let _010020 = Prefixed_Name(SIO, "010020") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary structure descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010022">http://semanticscience.org/resource/SIO_010022</seealso>
    let _010022 = Prefixed_Name(SIO, "010022") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tertiary structure descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010023">http://semanticscience.org/resource/SIO_010023</seealso>
    let _010023 = Prefixed_Name(SIO, "010023") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quaternary structure"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010024">http://semanticscience.org/resource/SIO_010024</seealso>
    let _010024 = Prefixed_Name(SIO, "010024") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oligosaccharide"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010025">http://semanticscience.org/resource/SIO_010025</seealso>
    let _010025 = Prefixed_Name(SIO, "010025") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genetic polymorphism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010026">http://semanticscience.org/resource/SIO_010026</seealso>
    let _010026 = Prefixed_Name(SIO, "010026") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"snp"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010027">http://semanticscience.org/resource/SIO_010027</seealso>
    let _010027 = Prefixed_Name(SIO, "010027") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genetic data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010028">http://semanticscience.org/resource/SIO_010028</seealso>
    let _010028 = Prefixed_Name(SIO, "010028") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological sex"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010029">http://semanticscience.org/resource/SIO_010029</seealso>
    let _010029 = Prefixed_Name(SIO, "010029") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monosaccharide"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010030">http://semanticscience.org/resource/SIO_010030</seealso>
    let _010030 = Prefixed_Name(SIO, "010030") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PDB chain identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010031">http://semanticscience.org/resource/SIO_010031</seealso>
    let _010031 = Prefixed_Name(SIO, "010031") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PDB record identifier"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010032">http://semanticscience.org/resource/SIO_010032</seealso>
    let _010032 = Prefixed_Name(SIO, "010032") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hydrogen bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010033">http://semanticscience.org/resource/SIO_010033</seealso>
    let _010033 = Prefixed_Name(SIO, "010033") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cation pi interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010034">http://semanticscience.org/resource/SIO_010034</seealso>
    let _010034 = Prefixed_Name(SIO, "010034") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010035">http://semanticscience.org/resource/SIO_010035</seealso>
    let _010035 = Prefixed_Name(SIO, "010035") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biochemical reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010036">http://semanticscience.org/resource/SIO_010036</seealso>
    let _010036 = Prefixed_Name(SIO, "010036") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical element"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010037">http://semanticscience.org/resource/SIO_010037</seealso>
    let _010037 = Prefixed_Name(SIO, "010037") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drug"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010038">http://semanticscience.org/resource/SIO_010038</seealso>
    let _010038 = Prefixed_Name(SIO, "010038") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pharmaceutical preparation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010039">http://semanticscience.org/resource/SIO_010039</seealso>
    let _010039 = Prefixed_Name(SIO, "010039") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"binding site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010040">http://semanticscience.org/resource/SIO_010040</seealso>
    let _010040 = Prefixed_Name(SIO, "010040") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"active site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010041">http://semanticscience.org/resource/SIO_010041</seealso>
    let _010041 = Prefixed_Name(SIO, "010041") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"haplotype"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010042">http://semanticscience.org/resource/SIO_010042</seealso>
    let _010042 = Prefixed_Name(SIO, "010042") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010043">http://semanticscience.org/resource/SIO_010043</seealso>
    let _010043 = Prefixed_Name(SIO, "010043") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010044">http://semanticscience.org/resource/SIO_010044</seealso>
    let _010044 = Prefixed_Name(SIO, "010044") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"base pair"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010045">http://semanticscience.org/resource/SIO_010045</seealso>
    let _010045 = Prefixed_Name(SIO, "010045") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010046">http://semanticscience.org/resource/SIO_010046</seealso>
    let _010046 = Prefixed_Name(SIO, "010046") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strong submolecular component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010047">http://semanticscience.org/resource/SIO_010047</seealso>
    let _010047 = Prefixed_Name(SIO, "010047") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"male"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010048">http://semanticscience.org/resource/SIO_010048</seealso>
    let _010048 = Prefixed_Name(SIO, "010048") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010049">http://semanticscience.org/resource/SIO_010049</seealso>
    let _010049 = Prefixed_Name(SIO, "010049") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allosteric site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010050">http://semanticscience.org/resource/SIO_010050</seealso>
    let _010050 = Prefixed_Name(SIO, "010050") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological fluid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010051">http://semanticscience.org/resource/SIO_010051</seealso>
    let _010051 = Prefixed_Name(SIO, "010051") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"female"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010052">http://semanticscience.org/resource/SIO_010052</seealso>
    let _010052 = Prefixed_Name(SIO, "010052") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"evolutionary lineage"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010053">http://semanticscience.org/resource/SIO_010053</seealso>
    let _010053 = Prefixed_Name(SIO, "010053") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell line"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010054">http://semanticscience.org/resource/SIO_010054</seealso>
    let _010054 = Prefixed_Name(SIO, "010054") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strain"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010055">http://semanticscience.org/resource/SIO_010055</seealso>
    let _010055 = Prefixed_Name(SIO, "010055") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phenotype"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010056">http://semanticscience.org/resource/SIO_010056</seealso>
    let _010056 = Prefixed_Name(SIO, "010056") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"life status"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010057">http://semanticscience.org/resource/SIO_010057</seealso>
    let _010057 = Prefixed_Name(SIO, "010057") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alive"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010058">http://semanticscience.org/resource/SIO_010058</seealso>
    let _010058 = Prefixed_Name(SIO, "010058") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dead"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010059">http://semanticscience.org/resource/SIO_010059</seealso>
    let _010059 = Prefixed_Name(SIO, "010059") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"family history"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010060">http://semanticscience.org/resource/SIO_010060</seealso>
    let _010060 = Prefixed_Name(SIO, "010060") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"generation number"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010061">http://semanticscience.org/resource/SIO_010061</seealso>
    let _010061 = Prefixed_Name(SIO, "010061") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"5' untranslated region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010064">http://semanticscience.org/resource/SIO_010064</seealso>
    let _010064 = Prefixed_Name(SIO, "010064") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bioinformatic data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010065">http://semanticscience.org/resource/SIO_010065</seealso>
    let _010065 = Prefixed_Name(SIO, "010065") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence alignment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010066">http://semanticscience.org/resource/SIO_010066</seealso>
    let _010066 = Prefixed_Name(SIO, "010066") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multiple sequence alignment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010067">http://semanticscience.org/resource/SIO_010067</seealso>
    let _010067 = Prefixed_Name(SIO, "010067") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pairwise sequence alignment"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010068">http://semanticscience.org/resource/SIO_010068</seealso>
    let _010068 = Prefixed_Name(SIO, "010068") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3' untranslated region"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010070">http://semanticscience.org/resource/SIO_010070</seealso>
    let _010070 = Prefixed_Name(SIO, "010070") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organic submolecule"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010071">http://semanticscience.org/resource/SIO_010071</seealso>
    let _010071 = Prefixed_Name(SIO, "010071") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organic molecule"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010072">http://semanticscience.org/resource/SIO_010072</seealso>
    let _010072 = Prefixed_Name(SIO, "010072") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open reading frame"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010073">http://semanticscience.org/resource/SIO_010073</seealso>
    let _010073 = Prefixed_Name(SIO, "010073") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amino acid residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010074">http://semanticscience.org/resource/SIO_010074</seealso>
    let _010074 = Prefixed_Name(SIO, "010074") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleotide residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010075">http://semanticscience.org/resource/SIO_010075</seealso>
    let _010075 = Prefixed_Name(SIO, "010075") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"poison"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010076">http://semanticscience.org/resource/SIO_010076</seealso>
    let _010076 = Prefixed_Name(SIO, "010076") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"active ingredient"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010077">http://semanticscience.org/resource/SIO_010077</seealso>
    let _010077 = Prefixed_Name(SIO, "010077") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"encodes"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010078">http://semanticscience.org/resource/SIO_010078</seealso>
    let _010078 = Prefixed_Name(SIO, "010078") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is encoded by"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010079">http://semanticscience.org/resource/SIO_010079</seealso>
    let _010079 = Prefixed_Name(SIO, "010079") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is transcribed into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010080">http://semanticscience.org/resource/SIO_010080</seealso>
    let _010080 = Prefixed_Name(SIO, "010080") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is transcribed from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010081">http://semanticscience.org/resource/SIO_010081</seealso>
    let _010081 = Prefixed_Name(SIO, "010081") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is translated into"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010082">http://semanticscience.org/resource/SIO_010082</seealso>
    let _010082 = Prefixed_Name(SIO, "010082") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is translated from"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010083">http://semanticscience.org/resource/SIO_010083</seealso>
    let _010083 = Prefixed_Name(SIO, "010083") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"operon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010084">http://semanticscience.org/resource/SIO_010084</seealso>
    let _010084 = Prefixed_Name(SIO, "010084") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene regulatory component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010085">http://semanticscience.org/resource/SIO_010085</seealso>
    let _010085 = Prefixed_Name(SIO, "010085") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene enhancer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010086">http://semanticscience.org/resource/SIO_010086</seealso>
    let _010086 = Prefixed_Name(SIO, "010086") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inactive ingredient"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010087">http://semanticscience.org/resource/SIO_010087</seealso>
    let _010087 = Prefixed_Name(SIO, "010087") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a template for molecular synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010088">http://semanticscience.org/resource/SIO_010088</seealso>
    let _010088 = Prefixed_Name(SIO, "010088") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a template for protein synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010089">http://semanticscience.org/resource/SIO_010089</seealso>
    let _010089 = Prefixed_Name(SIO, "010089") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a template for RNA synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010090">http://semanticscience.org/resource/SIO_010090</seealso>
    let _010090 = Prefixed_Name(SIO, "010090") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a template for DNA synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010091">http://semanticscience.org/resource/SIO_010091</seealso>
    let _010091 = Prefixed_Name(SIO, "010091") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonucleic acid template"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010092">http://semanticscience.org/resource/SIO_010092</seealso>
    let _010092 = Prefixed_Name(SIO, "010092") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonucleic acid primer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010093">http://semanticscience.org/resource/SIO_010093</seealso>
    let _010093 = Prefixed_Name(SIO, "010093") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to serve as a primer for DNA synthesis"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010094">http://semanticscience.org/resource/SIO_010094</seealso>
    let _010094 = Prefixed_Name(SIO, "010094") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RNA transcript component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010095">http://semanticscience.org/resource/SIO_010095</seealso>
    let _010095 = Prefixed_Name(SIO, "010095") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mature mRNA"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010096">http://semanticscience.org/resource/SIO_010096</seealso>
    let _010096 = Prefixed_Name(SIO, "010096") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pre-mRNA"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010097">http://semanticscience.org/resource/SIO_010097</seealso>
    let _010097 = Prefixed_Name(SIO, "010097") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mRNA splice variant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010098">http://semanticscience.org/resource/SIO_010098</seealso>
    let _010098 = Prefixed_Name(SIO, "010098") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"messenger RNA"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010099">http://semanticscience.org/resource/SIO_010099</seealso>
    let _010099 = Prefixed_Name(SIO, "010099") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dna gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010100">http://semanticscience.org/resource/SIO_010100</seealso>
    let _010100 = Prefixed_Name(SIO, "010100") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rna gene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010101">http://semanticscience.org/resource/SIO_010101</seealso>
    let _010101 = Prefixed_Name(SIO, "010101") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010277</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allele"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010277">http://semanticscience.org/resource/SIO_010277</seealso>
    let _010277 = Prefixed_Name(SIO, "010277") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ploidy"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010278">http://semanticscience.org/resource/SIO_010278</seealso>
    let _010278 = Prefixed_Name(SIO, "010278") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010283">http://semanticscience.org/resource/SIO_010283</seealso>
    let _010283 = Prefixed_Name(SIO, "010283") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010284</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"active transport"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010284">http://semanticscience.org/resource/SIO_010284</seealso>
    let _010284 = Prefixed_Name(SIO, "010284") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010285</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular complex formation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010285">http://semanticscience.org/resource/SIO_010285</seealso>
    let _010285 = Prefixed_Name(SIO, "010285") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010286</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular complex dissociation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010286">http://semanticscience.org/resource/SIO_010286</seealso>
    let _010286 = Prefixed_Name(SIO, "010286") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010287</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of biochemical process"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010287">http://semanticscience.org/resource/SIO_010287</seealso>
    let _010287 = Prefixed_Name(SIO, "010287") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010288</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biochemical activation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010288">http://semanticscience.org/resource/SIO_010288</seealso>
    let _010288 = Prefixed_Name(SIO, "010288") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010289</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biochemical inhibition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010289">http://semanticscience.org/resource/SIO_010289</seealso>
    let _010289 = Prefixed_Name(SIO, "010289") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process up-regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010295">http://semanticscience.org/resource/SIO_010295</seealso>
    let _010295 = Prefixed_Name(SIO, "010295") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process down-regulation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010296">http://semanticscience.org/resource/SIO_010296</seealso>
    let _010296 = Prefixed_Name(SIO, "010296") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010298</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010298">http://semanticscience.org/resource/SIO_010298</seealso>
    let _010298 = Prefixed_Name(SIO, "010298") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010299</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disease"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010299">http://semanticscience.org/resource/SIO_010299</seealso>
    let _010299 = Prefixed_Name(SIO, "010299") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transcription"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010300">http://semanticscience.org/resource/SIO_010300</seealso>
    let _010300 = Prefixed_Name(SIO, "010300") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010301</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"translation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010301">http://semanticscience.org/resource/SIO_010301</seealso>
    let _010301 = Prefixed_Name(SIO, "010301") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is homologous to"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010302">http://semanticscience.org/resource/SIO_010302</seealso>
    let _010302 = Prefixed_Name(SIO, "010302") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular modification"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010307">http://semanticscience.org/resource/SIO_010307</seealso>
    let _010307 = Prefixed_Name(SIO, "010307") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010308</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"metabolism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010308">http://semanticscience.org/resource/SIO_010308</seealso>
    let _010308 = Prefixed_Name(SIO, "010308") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010309</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catabolism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010309">http://semanticscience.org/resource/SIO_010309</seealso>
    let _010309 = Prefixed_Name(SIO, "010309") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anabolism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010310">http://semanticscience.org/resource/SIO_010310</seealso>
    let _010310 = Prefixed_Name(SIO, "010310") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010334</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbohydrate residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010334">http://semanticscience.org/resource/SIO_010334</seealso>
    let _010334 = Prefixed_Name(SIO, "010334") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010335">http://semanticscience.org/resource/SIO_010335</seealso>
    let _010335 = Prefixed_Name(SIO, "010335") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010336</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonucleotide residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010336">http://semanticscience.org/resource/SIO_010336</seealso>
    let _010336 = Prefixed_Name(SIO, "010336") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonucleotide residue"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010337">http://semanticscience.org/resource/SIO_010337</seealso>
    let _010337 = Prefixed_Name(SIO, "010337") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pharmaceutical component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010338">http://semanticscience.org/resource/SIO_010338</seealso>
    let _010338 = Prefixed_Name(SIO, "010338") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to covalently modify"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010340">http://semanticscience.org/resource/SIO_010340</seealso>
    let _010340 = Prefixed_Name(SIO, "010340") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"covalently connected entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010341">http://semanticscience.org/resource/SIO_010341</seealso>
    let _010341 = Prefixed_Name(SIO, "010341") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical complex"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010342">http://semanticscience.org/resource/SIO_010342</seealso>
    let _010342 = Prefixed_Name(SIO, "010342") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enzyme"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010343">http://semanticscience.org/resource/SIO_010343</seealso>
    let _010343 = Prefixed_Name(SIO, "010343") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalyst"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010344">http://semanticscience.org/resource/SIO_010344</seealso>
    let _010344 = Prefixed_Name(SIO, "010344") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010345">http://semanticscience.org/resource/SIO_010345</seealso>
    let _010345 = Prefixed_Name(SIO, "010345") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organic polymer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010346">http://semanticscience.org/resource/SIO_010346</seealso>
    let _010346 = Prefixed_Name(SIO, "010346") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to modify conformation of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010347">http://semanticscience.org/resource/SIO_010347</seealso>
    let _010347 = Prefixed_Name(SIO, "010347") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010349</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to cleave"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010349">http://semanticscience.org/resource/SIO_010349</seealso>
    let _010349 = Prefixed_Name(SIO, "010349") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to combine"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010351">http://semanticscience.org/resource/SIO_010351</seealso>
    let _010351 = Prefixed_Name(SIO, "010351") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to breathe"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010353">http://semanticscience.org/resource/SIO_010353</seealso>
    let _010353 = Prefixed_Name(SIO, "010353") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010354</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to conformationally activate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010354">http://semanticscience.org/resource/SIO_010354</seealso>
    let _010354 = Prefixed_Name(SIO, "010354") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010355</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to conformationally inhibit"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010355">http://semanticscience.org/resource/SIO_010355</seealso>
    let _010355 = Prefixed_Name(SIO, "010355") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to oxidize"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010358">http://semanticscience.org/resource/SIO_010358</seealso>
    let _010358 = Prefixed_Name(SIO, "010358") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to reduce"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010359">http://semanticscience.org/resource/SIO_010359</seealso>
    let _010359 = Prefixed_Name(SIO, "010359") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to modify oxidation state of"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010360">http://semanticscience.org/resource/SIO_010360</seealso>
    let _010360 = Prefixed_Name(SIO, "010360") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"substrate"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010362">http://semanticscience.org/resource/SIO_010362</seealso>
    let _010362 = Prefixed_Name(SIO, "010362") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010363</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010363">http://semanticscience.org/resource/SIO_010363</seealso>
    let _010363 = Prefixed_Name(SIO, "010363") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010364</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be modified"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010364">http://semanticscience.org/resource/SIO_010364</seealso>
    let _010364 = Prefixed_Name(SIO, "010364") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010365</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be cleaved"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010365">http://semanticscience.org/resource/SIO_010365</seealso>
    let _010365 = Prefixed_Name(SIO, "010365") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010366</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be covalently modified"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010366">http://semanticscience.org/resource/SIO_010366</seealso>
    let _010366 = Prefixed_Name(SIO, "010366") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be combined"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010367">http://semanticscience.org/resource/SIO_010367</seealso>
    let _010367 = Prefixed_Name(SIO, "010367") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010368</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be transported"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010368">http://semanticscience.org/resource/SIO_010368</seealso>
    let _010368 = Prefixed_Name(SIO, "010368") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be electronically modified"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010369">http://semanticscience.org/resource/SIO_010369</seealso>
    let _010369 = Prefixed_Name(SIO, "010369") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010370</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to gain an electron"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010370">http://semanticscience.org/resource/SIO_010370</seealso>
    let _010370 = Prefixed_Name(SIO, "010370") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to lose an electron"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010371">http://semanticscience.org/resource/SIO_010371</seealso>
    let _010371 = Prefixed_Name(SIO, "010371") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010372</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be activated"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010372">http://semanticscience.org/resource/SIO_010372</seealso>
    let _010372 = Prefixed_Name(SIO, "010372") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010373</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be inhibited"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010373">http://semanticscience.org/resource/SIO_010373</seealso>
    let _010373 = Prefixed_Name(SIO, "010373") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to be conformationally changed"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010374">http://semanticscience.org/resource/SIO_010374</seealso>
    let _010374 = Prefixed_Name(SIO, "010374") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multicellular organism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010375">http://semanticscience.org/resource/SIO_010375</seealso>
    let _010375 = Prefixed_Name(SIO, "010375") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unicellular organism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010376">http://semanticscience.org/resource/SIO_010376</seealso>
    let _010376 = Prefixed_Name(SIO, "010376") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular organism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010377">http://semanticscience.org/resource/SIO_010377</seealso>
    let _010377 = Prefixed_Name(SIO, "010377") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010378</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-cellular organism"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010378">http://semanticscience.org/resource/SIO_010378</seealso>
    let _010378 = Prefixed_Name(SIO, "010378") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010379</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"virus"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010379">http://semanticscience.org/resource/SIO_010379</seealso>
    let _010379 = Prefixed_Name(SIO, "010379") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010383</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drug regulatory authority"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010383">http://semanticscience.org/resource/SIO_010383</seealso>
    let _010383 = Prefixed_Name(SIO, "010383") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010410</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specialized material entity"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010410">http://semanticscience.org/resource/SIO_010410</seealso>
    let _010410 = Prefixed_Name(SIO, "010410") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010411</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reagent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010411">http://semanticscience.org/resource/SIO_010411</seealso>
    let _010411 = Prefixed_Name(SIO, "010411") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010412</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specimen"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010412">http://semanticscience.org/resource/SIO_010412</seealso>
    let _010412 = Prefixed_Name(SIO, "010412") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010414</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathogen"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010414">http://semanticscience.org/resource/SIO_010414</seealso>
    let _010414 = Prefixed_Name(SIO, "010414") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010415</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"host"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010415">http://semanticscience.org/resource/SIO_010415</seealso>
    let _010415 = Prefixed_Name(SIO, "010415") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010416</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"buffer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010416">http://semanticscience.org/resource/SIO_010416</seealso>
    let _010416 = Prefixed_Name(SIO, "010416") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010417</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"solvent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010417">http://semanticscience.org/resource/SIO_010417</seealso>
    let _010417 = Prefixed_Name(SIO, "010417") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010418</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"solute"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010418">http://semanticscience.org/resource/SIO_010418</seealso>
    let _010418 = Prefixed_Name(SIO, "010418") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010419</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antigen"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010419">http://semanticscience.org/resource/SIO_010419</seealso>
    let _010419 = Prefixed_Name(SIO, "010419") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010420</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"receptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010420">http://semanticscience.org/resource/SIO_010420</seealso>
    let _010420 = Prefixed_Name(SIO, "010420") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010423</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"target"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010423">http://semanticscience.org/resource/SIO_010423</seealso>
    let _010423 = Prefixed_Name(SIO, "010423") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010424</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrifugation pellet"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010424">http://semanticscience.org/resource/SIO_010424</seealso>
    let _010424 = Prefixed_Name(SIO, "010424") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supernatant"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010425">http://semanticscience.org/resource/SIO_010425</seealso>
    let _010425 = Prefixed_Name(SIO, "010425") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010426</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"centrifugation substance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010426">http://semanticscience.org/resource/SIO_010426</seealso>
    let _010426 = Prefixed_Name(SIO, "010426") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010427</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liquid solution component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010427">http://semanticscience.org/resource/SIO_010427</seealso>
    let _010427 = Prefixed_Name(SIO, "010427") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010428</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"evaluation role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010428">http://semanticscience.org/resource/SIO_010428</seealso>
    let _010428 = Prefixed_Name(SIO, "010428") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010429</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"placebo"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010429">http://semanticscience.org/resource/SIO_010429</seealso>
    let _010429 = Prefixed_Name(SIO, "010429") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010430</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"test role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010430">http://semanticscience.org/resource/SIO_010430</seealso>
    let _010430 = Prefixed_Name(SIO, "010430") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010431</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"control role"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010431">http://semanticscience.org/resource/SIO_010431</seealso>
    let _010431 = Prefixed_Name(SIO, "010431") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010432</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ligand"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010432">http://semanticscience.org/resource/SIO_010432</seealso>
    let _010432 = Prefixed_Name(SIO, "010432") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010433</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"low barrier hydrogen bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010433">http://semanticscience.org/resource/SIO_010433</seealso>
    let _010433 = Prefixed_Name(SIO, "010433") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010434</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"activator"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010434">http://semanticscience.org/resource/SIO_010434</seealso>
    let _010434 = Prefixed_Name(SIO, "010434") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010435</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inhibitor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010435">http://semanticscience.org/resource/SIO_010435</seealso>
    let _010435 = Prefixed_Name(SIO, "010435") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010436</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular regulator"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010436">http://semanticscience.org/resource/SIO_010436</seealso>
    let _010436 = Prefixed_Name(SIO, "010436") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010437</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"signal transducer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010437">http://semanticscience.org/resource/SIO_010437</seealso>
    let _010437 = Prefixed_Name(SIO, "010437") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010438</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"signal"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010438">http://semanticscience.org/resource/SIO_010438</seealso>
    let _010438 = Prefixed_Name(SIO, "010438") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010439</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"messenger"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010439">http://semanticscience.org/resource/SIO_010439</seealso>
    let _010439 = Prefixed_Name(SIO, "010439") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010440</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"second messenger"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010440">http://semanticscience.org/resource/SIO_010440</seealso>
    let _010440 = Prefixed_Name(SIO, "010440") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010441</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"submolecule"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010441">http://semanticscience.org/resource/SIO_010441</seealso>
    let _010441 = Prefixed_Name(SIO, "010441") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010442</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"charge quality"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010442">http://semanticscience.org/resource/SIO_010442</seealso>
    let _010442 = Prefixed_Name(SIO, "010442") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010443</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intron"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010443">http://semanticscience.org/resource/SIO_010443</seealso>
    let _010443 = Prefixed_Name(SIO, "010443") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010444</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene component"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010444">http://semanticscience.org/resource/SIO_010444</seealso>
    let _010444 = Prefixed_Name(SIO, "010444") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010445</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010445">http://semanticscience.org/resource/SIO_010445</seealso>
    let _010445 = Prefixed_Name(SIO, "010445") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010446</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene promoter"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010446">http://semanticscience.org/resource/SIO_010446</seealso>
    let _010446 = Prefixed_Name(SIO, "010446") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010447</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"start codon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010447">http://semanticscience.org/resource/SIO_010447</seealso>
    let _010447 = Prefixed_Name(SIO, "010447") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010448</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stop codon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010448">http://semanticscience.org/resource/SIO_010448</seealso>
    let _010448 = Prefixed_Name(SIO, "010448") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010450</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RNA transcript"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010450">http://semanticscience.org/resource/SIO_010450</seealso>
    let _010450 = Prefixed_Name(SIO, "010450") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010451</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"splice site"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010451">http://semanticscience.org/resource/SIO_010451</seealso>
    let _010451 = Prefixed_Name(SIO, "010451") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010452</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular pocket"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010452">http://semanticscience.org/resource/SIO_010452</seealso>
    let _010452 = Prefixed_Name(SIO, "010452") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010453</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acid"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010453">http://semanticscience.org/resource/SIO_010453</seealso>
    let _010453 = Prefixed_Name(SIO, "010453") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010454</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"base"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010454">http://semanticscience.org/resource/SIO_010454</seealso>
    let _010454 = Prefixed_Name(SIO, "010454") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010455</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"isomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010455">http://semanticscience.org/resource/SIO_010455</seealso>
    let _010455 = Prefixed_Name(SIO, "010455") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010456</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010456">http://semanticscience.org/resource/SIO_010456</seealso>
    let _010456 = Prefixed_Name(SIO, "010456") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010457</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cation"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010457">http://semanticscience.org/resource/SIO_010457</seealso>
    let _010457 = Prefixed_Name(SIO, "010457") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010458</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anion"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010458">http://semanticscience.org/resource/SIO_010458</seealso>
    let _010458 = Prefixed_Name(SIO, "010458") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010459</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar solvent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010459">http://semanticscience.org/resource/SIO_010459</seealso>
    let _010459 = Prefixed_Name(SIO, "010459") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010460</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nonpolar solvent"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010460">http://semanticscience.org/resource/SIO_010460</seealso>
    let _010460 = Prefixed_Name(SIO, "010460") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010461</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"positive charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010461">http://semanticscience.org/resource/SIO_010461</seealso>
    let _010461 = Prefixed_Name(SIO, "010461") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010462</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heterogeneous substance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010462">http://semanticscience.org/resource/SIO_010462</seealso>
    let _010462 = Prefixed_Name(SIO, "010462") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010463</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"homogeneous substance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010463">http://semanticscience.org/resource/SIO_010463</seealso>
    let _010463 = Prefixed_Name(SIO, "010463") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010464</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative charge"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010464">http://semanticscience.org/resource/SIO_010464</seealso>
    let _010464 = Prefixed_Name(SIO, "010464") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010465</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antibody"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010465">http://semanticscience.org/resource/SIO_010465</seealso>
    let _010465 = Prefixed_Name(SIO, "010465") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010468</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alpha helix"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010468">http://semanticscience.org/resource/SIO_010468</seealso>
    let _010468 = Prefixed_Name(SIO, "010468") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010469</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"beta strand"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010469">http://semanticscience.org/resource/SIO_010469</seealso>
    let _010469 = Prefixed_Name(SIO, "010469") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010471</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein part"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010471">http://semanticscience.org/resource/SIO_010471</seealso>
    let _010471 = Prefixed_Name(SIO, "010471") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010496</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ionic interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010496">http://semanticscience.org/resource/SIO_010496</seealso>
    let _010496 = Prefixed_Name(SIO, "010496") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010497</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein complex"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010497">http://semanticscience.org/resource/SIO_010497</seealso>
    let _010497 = Prefixed_Name(SIO, "010497") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010498</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010498">http://semanticscience.org/resource/SIO_010498</seealso>
    let _010498 = Prefixed_Name(SIO, "010498") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010499</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010499">http://semanticscience.org/resource/SIO_010499</seealso>
    let _010499 = Prefixed_Name(SIO, "010499") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010500</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"triple bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010500">http://semanticscience.org/resource/SIO_010500</seealso>
    let _010500 = Prefixed_Name(SIO, "010500") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010501</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aromatic bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010501">http://semanticscience.org/resource/SIO_010501</seealso>
    let _010501 = Prefixed_Name(SIO, "010501") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010502</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disulfide bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010502">http://semanticscience.org/resource/SIO_010502</seealso>
    let _010502 = Prefixed_Name(SIO, "010502") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010503</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dipole-dipole interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010503">http://semanticscience.org/resource/SIO_010503</seealso>
    let _010503 = Prefixed_Name(SIO, "010503") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010504</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"van der Waals interaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010504">http://semanticscience.org/resource/SIO_010504</seealso>
    let _010504 = Prefixed_Name(SIO, "010504") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010505</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"base stack"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010505">http://semanticscience.org/resource/SIO_010505</seealso>
    let _010505 = Prefixed_Name(SIO, "010505") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010506</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular complex"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010506">http://semanticscience.org/resource/SIO_010506</seealso>
    let _010506 = Prefixed_Name(SIO, "010506") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010507</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acid-base reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010507">http://semanticscience.org/resource/SIO_010507</seealso>
    let _010507 = Prefixed_Name(SIO, "010507") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010508</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalyzed reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010508">http://semanticscience.org/resource/SIO_010508</seealso>
    let _010508 = Prefixed_Name(SIO, "010508") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010509</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redox reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010509">http://semanticscience.org/resource/SIO_010509</seealso>
    let _010509 = Prefixed_Name(SIO, "010509") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010510</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inorganic reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010510">http://semanticscience.org/resource/SIO_010510</seealso>
    let _010510 = Prefixed_Name(SIO, "010510") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010511</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"decomposition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010511">http://semanticscience.org/resource/SIO_010511</seealso>
    let _010511 = Prefixed_Name(SIO, "010511") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"displacement reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010512">http://semanticscience.org/resource/SIO_010512</seealso>
    let _010512 = Prefixed_Name(SIO, "010512") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010513</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double displacement reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010513">http://semanticscience.org/resource/SIO_010513</seealso>
    let _010513 = Prefixed_Name(SIO, "010513") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010514</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single displacement reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010514">http://semanticscience.org/resource/SIO_010514</seealso>
    let _010514 = Prefixed_Name(SIO, "010514") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010515</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"synthesis reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010515">http://semanticscience.org/resource/SIO_010515</seealso>
    let _010515 = Prefixed_Name(SIO, "010515") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010516</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organic reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010516">http://semanticscience.org/resource/SIO_010516</seealso>
    let _010516 = Prefixed_Name(SIO, "010516") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010517</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"isomerization reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010517">http://semanticscience.org/resource/SIO_010517</seealso>
    let _010517 = Prefixed_Name(SIO, "010517") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010518</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"addition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010518">http://semanticscience.org/resource/SIO_010518</seealso>
    let _010518 = Prefixed_Name(SIO, "010518") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010519</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polar addition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010519">http://semanticscience.org/resource/SIO_010519</seealso>
    let _010519 = Prefixed_Name(SIO, "010519") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010520</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-polar addition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010520">http://semanticscience.org/resource/SIO_010520</seealso>
    let _010520 = Prefixed_Name(SIO, "010520") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010521</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"free radical addition"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010521">http://semanticscience.org/resource/SIO_010521</seealso>
    let _010521 = Prefixed_Name(SIO, "010521") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010522</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleophilic addition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010522">http://semanticscience.org/resource/SIO_010522</seealso>
    let _010522 = Prefixed_Name(SIO, "010522") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010523</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electrophilic addition reaction"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010523">http://semanticscience.org/resource/SIO_010523</seealso>
    let _010523 = Prefixed_Name(SIO, "010523") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010525</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biochemical pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010525">http://semanticscience.org/resource/SIO_010525</seealso>
    let _010525 = Prefixed_Name(SIO, "010525") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010526</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical reaction pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010526">http://semanticscience.org/resource/SIO_010526</seealso>
    let _010526 = Prefixed_Name(SIO, "010526") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010527</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical synthesis pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010527">http://semanticscience.org/resource/SIO_010527</seealso>
    let _010527 = Prefixed_Name(SIO, "010527") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010528</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical degradation pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010528">http://semanticscience.org/resource/SIO_010528</seealso>
    let _010528 = Prefixed_Name(SIO, "010528") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010530</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3d structure model"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010530">http://semanticscience.org/resource/SIO_010530</seealso>
    let _010530 = Prefixed_Name(SIO, "010530") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010531</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence profile"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010531">http://semanticscience.org/resource/SIO_010531</seealso>
    let _010531 = Prefixed_Name(SIO, "010531") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010532</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"metabolic pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010532">http://semanticscience.org/resource/SIO_010532</seealso>
    let _010532 = Prefixed_Name(SIO, "010532") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010533</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory pathway"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010533">http://semanticscience.org/resource/SIO_010533</seealso>
    let _010533 = Prefixed_Name(SIO, "010533") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010673</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medical history"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010673">http://semanticscience.org/resource/SIO_010673</seealso>
    let _010673 = Prefixed_Name(SIO, "010673") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"binary compound"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010674">http://semanticscience.org/resource/SIO_010674</seealso>
    let _010674 = Prefixed_Name(SIO, "010674") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010775</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stereoisomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010775">http://semanticscience.org/resource/SIO_010775</seealso>
    let _010775 = Prefixed_Name(SIO, "010775") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010776</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diastereomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010776">http://semanticscience.org/resource/SIO_010776</seealso>
    let _010776 = Prefixed_Name(SIO, "010776") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010777</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enantiomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010777">http://semanticscience.org/resource/SIO_010777</seealso>
    let _010777 = Prefixed_Name(SIO, "010777") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010778</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"optical isomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010778">http://semanticscience.org/resource/SIO_010778</seealso>
    let _010778 = Prefixed_Name(SIO, "010778") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010779</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structural isomer"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010779">http://semanticscience.org/resource/SIO_010779</seealso>
    let _010779 = Prefixed_Name(SIO, "010779") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010780</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ring"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010780">http://semanticscience.org/resource/SIO_010780</seealso>
    let _010780 = Prefixed_Name(SIO, "010780") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010781</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aromatic ring"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010781">http://semanticscience.org/resource/SIO_010781</seealso>
    let _010781 = Prefixed_Name(SIO, "010781") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010782</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heterocyclic ring"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010782">http://semanticscience.org/resource/SIO_010782</seealso>
    let _010782 = Prefixed_Name(SIO, "010782") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010783</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"homocyclic ring"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010783">http://semanticscience.org/resource/SIO_010783</seealso>
    let _010783 = Prefixed_Name(SIO, "010783") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010784</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ionic compound"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010784">http://semanticscience.org/resource/SIO_010784</seealso>
    let _010784 = Prefixed_Name(SIO, "010784") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"allotrope"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010785">http://semanticscience.org/resource/SIO_010785</seealso>
    let _010785 = Prefixed_Name(SIO, "010785") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbon allotrope"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010786">http://semanticscience.org/resource/SIO_010786</seealso>
    let _010786 = Prefixed_Name(SIO, "010786") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010787</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diamond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010787">http://semanticscience.org/resource/SIO_010787</seealso>
    let _010787 = Prefixed_Name(SIO, "010787") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"graphite"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010788">http://semanticscience.org/resource/SIO_010788</seealso>
    let _010788 = Prefixed_Name(SIO, "010788") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fullerene"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010789">http://semanticscience.org/resource/SIO_010789</seealso>
    let _010789 = Prefixed_Name(SIO, "010789") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010790</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aggregated carbon nanorods"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010790">http://semanticscience.org/resource/SIO_010790</seealso>
    let _010790 = Prefixed_Name(SIO, "010790") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010791</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amorphous carbon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010791">http://semanticscience.org/resource/SIO_010791</seealso>
    let _010791 = Prefixed_Name(SIO, "010791") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010792</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbon nanofoam"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010792">http://semanticscience.org/resource/SIO_010792</seealso>
    let _010792 = Prefixed_Name(SIO, "010792") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010793</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chaoite"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010793">http://semanticscience.org/resource/SIO_010793</seealso>
    let _010793 = Prefixed_Name(SIO, "010793") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"glassy carbon"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010794">http://semanticscience.org/resource/SIO_010794</seealso>
    let _010794 = Prefixed_Name(SIO, "010794") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_010795</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ionsdaleite"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_010795">http://semanticscience.org/resource/SIO_010795</seealso>
    let _010795 = Prefixed_Name(SIO, "010795") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"boron atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011000">http://semanticscience.org/resource/SIO_011000</seealso>
    let _011000 = Prefixed_Name(SIO, "011000") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011001">http://semanticscience.org/resource/SIO_011001</seealso>
    let _011001 = Prefixed_Name(SIO, "011001") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hydrogen atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011002">http://semanticscience.org/resource/SIO_011002</seealso>
    let _011002 = Prefixed_Name(SIO, "011002") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"helium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011003">http://semanticscience.org/resource/SIO_011003</seealso>
    let _011003 = Prefixed_Name(SIO, "011003") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lithium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011004">http://semanticscience.org/resource/SIO_011004</seealso>
    let _011004 = Prefixed_Name(SIO, "011004") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"beryllium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011005">http://semanticscience.org/resource/SIO_011005</seealso>
    let _011005 = Prefixed_Name(SIO, "011005") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nitrogen atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011006">http://semanticscience.org/resource/SIO_011006</seealso>
    let _011006 = Prefixed_Name(SIO, "011006") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oxygen atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011007">http://semanticscience.org/resource/SIO_011007</seealso>
    let _011007 = Prefixed_Name(SIO, "011007") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fluorine atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011008">http://semanticscience.org/resource/SIO_011008</seealso>
    let _011008 = Prefixed_Name(SIO, "011008") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011009">http://semanticscience.org/resource/SIO_011009</seealso>
    let _011009 = Prefixed_Name(SIO, "011009") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sodium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011010">http://semanticscience.org/resource/SIO_011010</seealso>
    let _011010 = Prefixed_Name(SIO, "011010") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"magnesium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011011">http://semanticscience.org/resource/SIO_011011</seealso>
    let _011011 = Prefixed_Name(SIO, "011011") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aluminium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011012">http://semanticscience.org/resource/SIO_011012</seealso>
    let _011012 = Prefixed_Name(SIO, "011012") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"silicon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011013">http://semanticscience.org/resource/SIO_011013</seealso>
    let _011013 = Prefixed_Name(SIO, "011013") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phosphorus atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011014">http://semanticscience.org/resource/SIO_011014</seealso>
    let _011014 = Prefixed_Name(SIO, "011014") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sulfur atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011015">http://semanticscience.org/resource/SIO_011015</seealso>
    let _011015 = Prefixed_Name(SIO, "011015") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chlorine atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011016">http://semanticscience.org/resource/SIO_011016</seealso>
    let _011016 = Prefixed_Name(SIO, "011016") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"argon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011017">http://semanticscience.org/resource/SIO_011017</seealso>
    let _011017 = Prefixed_Name(SIO, "011017") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"potassium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011018">http://semanticscience.org/resource/SIO_011018</seealso>
    let _011018 = Prefixed_Name(SIO, "011018") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calcium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011019">http://semanticscience.org/resource/SIO_011019</seealso>
    let _011019 = Prefixed_Name(SIO, "011019") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scandium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011020">http://semanticscience.org/resource/SIO_011020</seealso>
    let _011020 = Prefixed_Name(SIO, "011020") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"titanium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011021">http://semanticscience.org/resource/SIO_011021</seealso>
    let _011021 = Prefixed_Name(SIO, "011021") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vanadium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011022">http://semanticscience.org/resource/SIO_011022</seealso>
    let _011022 = Prefixed_Name(SIO, "011022") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011023">http://semanticscience.org/resource/SIO_011023</seealso>
    let _011023 = Prefixed_Name(SIO, "011023") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"manganese atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011024">http://semanticscience.org/resource/SIO_011024</seealso>
    let _011024 = Prefixed_Name(SIO, "011024") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"iron atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011025">http://semanticscience.org/resource/SIO_011025</seealso>
    let _011025 = Prefixed_Name(SIO, "011025") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cobalt atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011026">http://semanticscience.org/resource/SIO_011026</seealso>
    let _011026 = Prefixed_Name(SIO, "011026") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nickel atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011027">http://semanticscience.org/resource/SIO_011027</seealso>
    let _011027 = Prefixed_Name(SIO, "011027") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"copper atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011028">http://semanticscience.org/resource/SIO_011028</seealso>
    let _011028 = Prefixed_Name(SIO, "011028") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zinc atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011029">http://semanticscience.org/resource/SIO_011029</seealso>
    let _011029 = Prefixed_Name(SIO, "011029") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gallium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011030">http://semanticscience.org/resource/SIO_011030</seealso>
    let _011030 = Prefixed_Name(SIO, "011030") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"germanium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011031">http://semanticscience.org/resource/SIO_011031</seealso>
    let _011031 = Prefixed_Name(SIO, "011031") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arsenic atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011032">http://semanticscience.org/resource/SIO_011032</seealso>
    let _011032 = Prefixed_Name(SIO, "011032") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"selenium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011033">http://semanticscience.org/resource/SIO_011033</seealso>
    let _011033 = Prefixed_Name(SIO, "011033") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bromine atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011034">http://semanticscience.org/resource/SIO_011034</seealso>
    let _011034 = Prefixed_Name(SIO, "011034") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"krypton atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011035">http://semanticscience.org/resource/SIO_011035</seealso>
    let _011035 = Prefixed_Name(SIO, "011035") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rubidium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011036">http://semanticscience.org/resource/SIO_011036</seealso>
    let _011036 = Prefixed_Name(SIO, "011036") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strontium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011037">http://semanticscience.org/resource/SIO_011037</seealso>
    let _011037 = Prefixed_Name(SIO, "011037") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"yttrium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011038">http://semanticscience.org/resource/SIO_011038</seealso>
    let _011038 = Prefixed_Name(SIO, "011038") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011039</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zirconium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011039">http://semanticscience.org/resource/SIO_011039</seealso>
    let _011039 = Prefixed_Name(SIO, "011039") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"niobium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011040">http://semanticscience.org/resource/SIO_011040</seealso>
    let _011040 = Prefixed_Name(SIO, "011040") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molybdemum atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011041">http://semanticscience.org/resource/SIO_011041</seealso>
    let _011041 = Prefixed_Name(SIO, "011041") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011042</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"technetium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011042">http://semanticscience.org/resource/SIO_011042</seealso>
    let _011042 = Prefixed_Name(SIO, "011042") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011043</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ruthenium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011043">http://semanticscience.org/resource/SIO_011043</seealso>
    let _011043 = Prefixed_Name(SIO, "011043") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rhodium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011044">http://semanticscience.org/resource/SIO_011044</seealso>
    let _011044 = Prefixed_Name(SIO, "011044") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"palladium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011045">http://semanticscience.org/resource/SIO_011045</seealso>
    let _011045 = Prefixed_Name(SIO, "011045") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"silver atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011046">http://semanticscience.org/resource/SIO_011046</seealso>
    let _011046 = Prefixed_Name(SIO, "011046") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cadmium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011047">http://semanticscience.org/resource/SIO_011047</seealso>
    let _011047 = Prefixed_Name(SIO, "011047") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011048">http://semanticscience.org/resource/SIO_011048</seealso>
    let _011048 = Prefixed_Name(SIO, "011048") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tin atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011049">http://semanticscience.org/resource/SIO_011049</seealso>
    let _011049 = Prefixed_Name(SIO, "011049") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antimony atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011050">http://semanticscience.org/resource/SIO_011050</seealso>
    let _011050 = Prefixed_Name(SIO, "011050") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tellurium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011051">http://semanticscience.org/resource/SIO_011051</seealso>
    let _011051 = Prefixed_Name(SIO, "011051") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"iodine atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011052">http://semanticscience.org/resource/SIO_011052</seealso>
    let _011052 = Prefixed_Name(SIO, "011052") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"xenon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011053">http://semanticscience.org/resource/SIO_011053</seealso>
    let _011053 = Prefixed_Name(SIO, "011053") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"caesium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011054">http://semanticscience.org/resource/SIO_011054</seealso>
    let _011054 = Prefixed_Name(SIO, "011054") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"barium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011055">http://semanticscience.org/resource/SIO_011055</seealso>
    let _011055 = Prefixed_Name(SIO, "011055") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lanthanum atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011056">http://semanticscience.org/resource/SIO_011056</seealso>
    let _011056 = Prefixed_Name(SIO, "011056") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hafnium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011057">http://semanticscience.org/resource/SIO_011057</seealso>
    let _011057 = Prefixed_Name(SIO, "011057") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tantalum atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011058">http://semanticscience.org/resource/SIO_011058</seealso>
    let _011058 = Prefixed_Name(SIO, "011058") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tungsten atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011059">http://semanticscience.org/resource/SIO_011059</seealso>
    let _011059 = Prefixed_Name(SIO, "011059") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rhenium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011060">http://semanticscience.org/resource/SIO_011060</seealso>
    let _011060 = Prefixed_Name(SIO, "011060") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"osmium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011061">http://semanticscience.org/resource/SIO_011061</seealso>
    let _011061 = Prefixed_Name(SIO, "011061") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"iridium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011062">http://semanticscience.org/resource/SIO_011062</seealso>
    let _011062 = Prefixed_Name(SIO, "011062") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"platinum atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011063">http://semanticscience.org/resource/SIO_011063</seealso>
    let _011063 = Prefixed_Name(SIO, "011063") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gold atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011064">http://semanticscience.org/resource/SIO_011064</seealso>
    let _011064 = Prefixed_Name(SIO, "011064") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011065</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mercury atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011065">http://semanticscience.org/resource/SIO_011065</seealso>
    let _011065 = Prefixed_Name(SIO, "011065") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thallium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011066">http://semanticscience.org/resource/SIO_011066</seealso>
    let _011066 = Prefixed_Name(SIO, "011066") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lead atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011067">http://semanticscience.org/resource/SIO_011067</seealso>
    let _011067 = Prefixed_Name(SIO, "011067") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011068</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bismuth atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011068">http://semanticscience.org/resource/SIO_011068</seealso>
    let _011068 = Prefixed_Name(SIO, "011068") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011069</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polonium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011069">http://semanticscience.org/resource/SIO_011069</seealso>
    let _011069 = Prefixed_Name(SIO, "011069") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"astatine atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011070">http://semanticscience.org/resource/SIO_011070</seealso>
    let _011070 = Prefixed_Name(SIO, "011070") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radon atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011071">http://semanticscience.org/resource/SIO_011071</seealso>
    let _011071 = Prefixed_Name(SIO, "011071") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"francium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011072">http://semanticscience.org/resource/SIO_011072</seealso>
    let _011072 = Prefixed_Name(SIO, "011072") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011073">http://semanticscience.org/resource/SIO_011073</seealso>
    let _011073 = Prefixed_Name(SIO, "011073") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011074</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"actinium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011074">http://semanticscience.org/resource/SIO_011074</seealso>
    let _011074 = Prefixed_Name(SIO, "011074") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011075</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rutherfordium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011075">http://semanticscience.org/resource/SIO_011075</seealso>
    let _011075 = Prefixed_Name(SIO, "011075") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011076</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dubnium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011076">http://semanticscience.org/resource/SIO_011076</seealso>
    let _011076 = Prefixed_Name(SIO, "011076") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011077</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"seaborgium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011077">http://semanticscience.org/resource/SIO_011077</seealso>
    let _011077 = Prefixed_Name(SIO, "011077") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bohrium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011078">http://semanticscience.org/resource/SIO_011078</seealso>
    let _011078 = Prefixed_Name(SIO, "011078") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hassium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011079">http://semanticscience.org/resource/SIO_011079</seealso>
    let _011079 = Prefixed_Name(SIO, "011079") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"meitnerium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011080">http://semanticscience.org/resource/SIO_011080</seealso>
    let _011080 = Prefixed_Name(SIO, "011080") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"darmstadtium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011081">http://semanticscience.org/resource/SIO_011081</seealso>
    let _011081 = Prefixed_Name(SIO, "011081") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011082</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"roentgenium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011082">http://semanticscience.org/resource/SIO_011082</seealso>
    let _011082 = Prefixed_Name(SIO, "011082") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011083</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"copernicium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011083">http://semanticscience.org/resource/SIO_011083</seealso>
    let _011083 = Prefixed_Name(SIO, "011083") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unutrium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011084">http://semanticscience.org/resource/SIO_011084</seealso>
    let _011084 = Prefixed_Name(SIO, "011084") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ununquadium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011085">http://semanticscience.org/resource/SIO_011085</seealso>
    let _011085 = Prefixed_Name(SIO, "011085") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ununpentium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011086">http://semanticscience.org/resource/SIO_011086</seealso>
    let _011086 = Prefixed_Name(SIO, "011086") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ununhexium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011087">http://semanticscience.org/resource/SIO_011087</seealso>
    let _011087 = Prefixed_Name(SIO, "011087") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ununseptium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011088">http://semanticscience.org/resource/SIO_011088</seealso>
    let _011088 = Prefixed_Name(SIO, "011088") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ununoctium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011089">http://semanticscience.org/resource/SIO_011089</seealso>
    let _011089 = Prefixed_Name(SIO, "011089") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cerium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011090">http://semanticscience.org/resource/SIO_011090</seealso>
    let _011090 = Prefixed_Name(SIO, "011090") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"praseodymium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011091">http://semanticscience.org/resource/SIO_011091</seealso>
    let _011091 = Prefixed_Name(SIO, "011091") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neodymium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011092">http://semanticscience.org/resource/SIO_011092</seealso>
    let _011092 = Prefixed_Name(SIO, "011092") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011093</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"promethium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011093">http://semanticscience.org/resource/SIO_011093</seealso>
    let _011093 = Prefixed_Name(SIO, "011093") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"samarium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011094">http://semanticscience.org/resource/SIO_011094</seealso>
    let _011094 = Prefixed_Name(SIO, "011094") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011095</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"europium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011095">http://semanticscience.org/resource/SIO_011095</seealso>
    let _011095 = Prefixed_Name(SIO, "011095") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011096</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gadolinium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011096">http://semanticscience.org/resource/SIO_011096</seealso>
    let _011096 = Prefixed_Name(SIO, "011096") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"terbium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011097">http://semanticscience.org/resource/SIO_011097</seealso>
    let _011097 = Prefixed_Name(SIO, "011097") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dysprosium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011098">http://semanticscience.org/resource/SIO_011098</seealso>
    let _011098 = Prefixed_Name(SIO, "011098") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"holmium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011099">http://semanticscience.org/resource/SIO_011099</seealso>
    let _011099 = Prefixed_Name(SIO, "011099") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011100</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"erbium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011100">http://semanticscience.org/resource/SIO_011100</seealso>
    let _011100 = Prefixed_Name(SIO, "011100") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thulium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011101">http://semanticscience.org/resource/SIO_011101</seealso>
    let _011101 = Prefixed_Name(SIO, "011101") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ytterbium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011102">http://semanticscience.org/resource/SIO_011102</seealso>
    let _011102 = Prefixed_Name(SIO, "011102") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011103</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lutetium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011103">http://semanticscience.org/resource/SIO_011103</seealso>
    let _011103 = Prefixed_Name(SIO, "011103") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thorium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011104">http://semanticscience.org/resource/SIO_011104</seealso>
    let _011104 = Prefixed_Name(SIO, "011104") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protactinium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011105">http://semanticscience.org/resource/SIO_011105</seealso>
    let _011105 = Prefixed_Name(SIO, "011105") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uranium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011106">http://semanticscience.org/resource/SIO_011106</seealso>
    let _011106 = Prefixed_Name(SIO, "011106") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neptunium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011107">http://semanticscience.org/resource/SIO_011107</seealso>
    let _011107 = Prefixed_Name(SIO, "011107") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plutonium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011108">http://semanticscience.org/resource/SIO_011108</seealso>
    let _011108 = Prefixed_Name(SIO, "011108") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011109</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"americium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011109">http://semanticscience.org/resource/SIO_011109</seealso>
    let _011109 = Prefixed_Name(SIO, "011109") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"curium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011110">http://semanticscience.org/resource/SIO_011110</seealso>
    let _011110 = Prefixed_Name(SIO, "011110") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"berkelium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011111">http://semanticscience.org/resource/SIO_011111</seealso>
    let _011111 = Prefixed_Name(SIO, "011111") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011112</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"californium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011112">http://semanticscience.org/resource/SIO_011112</seealso>
    let _011112 = Prefixed_Name(SIO, "011112") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011113</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"einsteinium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011113">http://semanticscience.org/resource/SIO_011113</seealso>
    let _011113 = Prefixed_Name(SIO, "011113") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011114</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fermium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011114">http://semanticscience.org/resource/SIO_011114</seealso>
    let _011114 = Prefixed_Name(SIO, "011114") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mendelevium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011115">http://semanticscience.org/resource/SIO_011115</seealso>
    let _011115 = Prefixed_Name(SIO, "011115") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nobelium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011116">http://semanticscience.org/resource/SIO_011116</seealso>
    let _011116 = Prefixed_Name(SIO, "011116") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lawrencium atom"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011117">http://semanticscience.org/resource/SIO_011117</seealso>
    let _011117 = Prefixed_Name(SIO, "011117") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011118</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"covalent bond"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011118">http://semanticscience.org/resource/SIO_011118</seealso>
    let _011118 = Prefixed_Name(SIO, "011118") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011119</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biomolecular structure descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011119">http://semanticscience.org/resource/SIO_011119</seealso>
    let _011119 = Prefixed_Name(SIO, "011119") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011120</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular structure file"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011120">http://semanticscience.org/resource/SIO_011120</seealso>
    let _011120 = Prefixed_Name(SIO, "011120") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular structure descriptor"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011121">http://semanticscience.org/resource/SIO_011121</seealso>
    let _011121 = Prefixed_Name(SIO, "011121") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical data"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011123">http://semanticscience.org/resource/SIO_011123</seealso>
    let _011123 = Prefixed_Name(SIO, "011123") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecule"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011125">http://semanticscience.org/resource/SIO_011125</seealso>
    let _011125 = Prefixed_Name(SIO, "011125") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011126</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical substance"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011126">http://semanticscience.org/resource/SIO_011126</seealso>
    let _011126 = Prefixed_Name(SIO, "011126") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011130</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PDB file"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011130">http://semanticscience.org/resource/SIO_011130</seealso>
    let _011130 = Prefixed_Name(SIO, "011130") |> PrefixedName
    /// <summary>
    ///   <para>sio:SIO_011131</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection of 3d molecular structure models"</para></remarks>
    /// <seealso href="http://semanticscience.org/resource/SIO_011131">http://semanticscience.org/resource/SIO_011131</seealso>
    let _011131 = Prefixed_Name(SIO, "011131") |> PrefixedName

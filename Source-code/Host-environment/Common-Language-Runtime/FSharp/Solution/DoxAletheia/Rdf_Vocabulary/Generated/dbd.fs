namespace http.dbpedia.org.datatype.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbd =
    let _namespace_iri = Namespace_Iri dbd |> NamespaceIRI
    /// <summary>
    ///   <para>planet:datatype/Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Area">http://dbpedia.org/datatype/Area</seealso>
    let Area = Prefixed_Name(dbd, "Area") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Currency"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Currency">http://dbpedia.org/datatype/Currency</seealso>
    let Currency = Prefixed_Name(dbd, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Density</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Density"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Density">http://dbpedia.org/datatype/Density</seealso>
    let Density = Prefixed_Name(dbd, "Density") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ElectricCurrent"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ElectricCurrent">http://dbpedia.org/datatype/ElectricCurrent</seealso>
    let ElectricCurrent = Prefixed_Name(dbd, "ElectricCurrent") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Energy"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Energy">http://dbpedia.org/datatype/Energy</seealso>
    let Energy = Prefixed_Name(dbd, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/FlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"FlowRate"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/FlowRate">http://dbpedia.org/datatype/FlowRate</seealso>
    let FlowRate = Prefixed_Name(dbd, "FlowRate") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Force</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Force"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Force">http://dbpedia.org/datatype/Force</seealso>
    let Force = Prefixed_Name(dbd, "Force") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Frequency">http://dbpedia.org/datatype/Frequency</seealso>
    let Frequency = Prefixed_Name(dbd, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/FuelEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"FuelEfficiency"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/FuelEfficiency">http://dbpedia.org/datatype/FuelEfficiency</seealso>
    let FuelEfficiency = Prefixed_Name(dbd, "FuelEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/InformationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"InformationUnit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/InformationUnit">http://dbpedia.org/datatype/InformationUnit</seealso>
    let InformationUnit = Prefixed_Name(dbd, "InformationUnit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Length">http://dbpedia.org/datatype/Length</seealso>
    let Length = Prefixed_Name(dbd, "Length") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/LinearMassDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"LinearMassDensity"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/LinearMassDensity">http://dbpedia.org/datatype/LinearMassDensity</seealso>
    let LinearMassDensity = Prefixed_Name(dbd, "LinearMassDensity") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Mass"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Mass">http://dbpedia.org/datatype/Mass</seealso>
    let Mass = Prefixed_Name(dbd, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/PopulationDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"PopulationDensity"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/PopulationDensity">http://dbpedia.org/datatype/PopulationDensity</seealso>
    let PopulationDensity = Prefixed_Name(dbd, "PopulationDensity") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Power"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Power">http://dbpedia.org/datatype/Power</seealso>
    let Power = Prefixed_Name(dbd, "Power") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Pressure"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Pressure">http://dbpedia.org/datatype/Pressure</seealso>
    let Pressure = Prefixed_Name(dbd, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Ratio"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Ratio">http://dbpedia.org/datatype/Ratio</seealso>
    let Ratio = Prefixed_Name(dbd, "Ratio") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Speed">http://dbpedia.org/datatype/Speed</seealso>
    let Speed = Prefixed_Name(dbd, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Temperature"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Temperature">http://dbpedia.org/datatype/Temperature</seealso>
    let Temperature = Prefixed_Name(dbd, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Time"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Time">http://dbpedia.org/datatype/Time</seealso>
    let Time = Prefixed_Name(dbd, "Time") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Torque</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Torque"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Torque">http://dbpedia.org/datatype/Torque</seealso>
    let Torque = Prefixed_Name(dbd, "Torque") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Voltage"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Voltage">http://dbpedia.org/datatype/Voltage</seealso>
    let Voltage = Prefixed_Name(dbd, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Volume"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/Volume">http://dbpedia.org/datatype/Volume</seealso>
    let Volume = Prefixed_Name(dbd, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/acre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"acre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/acre">http://dbpedia.org/datatype/acre</seealso>
    let acre = Prefixed_Name(dbd, "acre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/afghanAfghani</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"afghanAfghani"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/afghanAfghani">http://dbpedia.org/datatype/afghanAfghani</seealso>
    let afghanAfghani = Prefixed_Name(dbd, "afghanAfghani") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/albanianLek</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"albanianLek"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/albanianLek">http://dbpedia.org/datatype/albanianLek</seealso>
    let albanianLek = Prefixed_Name(dbd, "albanianLek") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/algerianDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"algerianDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/algerianDinar">http://dbpedia.org/datatype/algerianDinar</seealso>
    let algerianDinar = Prefixed_Name(dbd, "algerianDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ampere"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ampere">http://dbpedia.org/datatype/ampere</seealso>
    let ampere = Prefixed_Name(dbd, "ampere") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/angolanKwanza</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"angolanKwanza"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/angolanKwanza">http://dbpedia.org/datatype/angolanKwanza</seealso>
    let angolanKwanza = Prefixed_Name(dbd, "angolanKwanza") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/argentinePeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"argentinePeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/argentinePeso">http://dbpedia.org/datatype/argentinePeso</seealso>
    let argentinePeso = Prefixed_Name(dbd, "argentinePeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/armenianDram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"armenianDram"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/armenianDram">http://dbpedia.org/datatype/armenianDram</seealso>
    let armenianDram = Prefixed_Name(dbd, "armenianDram") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/arubanGuilder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"arubanGuilder"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/arubanGuilder">http://dbpedia.org/datatype/arubanGuilder</seealso>
    let arubanGuilder = Prefixed_Name(dbd, "arubanGuilder") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/astronomicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"astronomicalUnit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/astronomicalUnit">http://dbpedia.org/datatype/astronomicalUnit</seealso>
    let astronomicalUnit = Prefixed_Name(dbd, "astronomicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/australianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"australianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/australianDollar">http://dbpedia.org/datatype/australianDollar</seealso>
    let australianDollar = Prefixed_Name(dbd, "australianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/azerbaijaniManat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"azerbaijaniManat"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/azerbaijaniManat">http://dbpedia.org/datatype/azerbaijaniManat</seealso>
    let azerbaijaniManat = Prefixed_Name(dbd, "azerbaijaniManat") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bahamianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bahamianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bahamianDollar">http://dbpedia.org/datatype/bahamianDollar</seealso>
    let bahamianDollar = Prefixed_Name(dbd, "bahamianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bahrainiDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bahrainiDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bahrainiDinar">http://dbpedia.org/datatype/bahrainiDinar</seealso>
    let bahrainiDinar = Prefixed_Name(dbd, "bahrainiDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bangladeshiTaka</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bangladeshiTaka"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bangladeshiTaka">http://dbpedia.org/datatype/bangladeshiTaka</seealso>
    let bangladeshiTaka = Prefixed_Name(dbd, "bangladeshiTaka") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bar">http://dbpedia.org/datatype/bar</seealso>
    let bar = Prefixed_Name(dbd, "bar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/barbadosDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"barbadosDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/barbadosDollar">http://dbpedia.org/datatype/barbadosDollar</seealso>
    let barbadosDollar = Prefixed_Name(dbd, "barbadosDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/belarussianRuble</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"belarussianRuble"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/belarussianRuble">http://dbpedia.org/datatype/belarussianRuble</seealso>
    let belarussianRuble = Prefixed_Name(dbd, "belarussianRuble") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/belizeDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"belizeDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/belizeDollar">http://dbpedia.org/datatype/belizeDollar</seealso>
    let belizeDollar = Prefixed_Name(dbd, "belizeDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bermudianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bermudianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bermudianDollar">http://dbpedia.org/datatype/bermudianDollar</seealso>
    let bermudianDollar = Prefixed_Name(dbd, "bermudianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bhutaneseNgultrum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bhutaneseNgultrum"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bhutaneseNgultrum">http://dbpedia.org/datatype/bhutaneseNgultrum</seealso>
    let bhutaneseNgultrum = Prefixed_Name(dbd, "bhutaneseNgultrum") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bit">http://dbpedia.org/datatype/bit</seealso>
    let bit = Prefixed_Name(dbd, "bit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bolivianBoliviano</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bolivianBoliviano"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bolivianBoliviano">http://dbpedia.org/datatype/bolivianBoliviano</seealso>
    let bolivianBoliviano = Prefixed_Name(dbd, "bolivianBoliviano") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/bosniaAndHerzegovinaConvertibleMarks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bosniaAndHerzegovinaConvertibleMarks"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bosniaAndHerzegovinaConvertibleMarks">http://dbpedia.org/datatype/bosniaAndHerzegovinaConvertibleMarks</seealso>
    let bosniaAndHerzegovinaConvertibleMarks =
        Prefixed_Name(dbd, "bosniaAndHerzegovinaConvertibleMarks") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/botswanaPula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"botswanaPula"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/botswanaPula">http://dbpedia.org/datatype/botswanaPula</seealso>
    let botswanaPula = Prefixed_Name(dbd, "botswanaPula") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/brakeHorsepower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"brakeHorsepower"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/brakeHorsepower">http://dbpedia.org/datatype/brakeHorsepower</seealso>
    let brakeHorsepower = Prefixed_Name(dbd, "brakeHorsepower") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/brazilianReal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"brazilianReal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/brazilianReal">http://dbpedia.org/datatype/brazilianReal</seealso>
    let brazilianReal = Prefixed_Name(dbd, "brazilianReal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bruneiDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bruneiDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bruneiDollar">http://dbpedia.org/datatype/bruneiDollar</seealso>
    let bruneiDollar = Prefixed_Name(dbd, "bruneiDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/bulgarianLev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"bulgarianLev"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/bulgarianLev">http://dbpedia.org/datatype/bulgarianLev</seealso>
    let bulgarianLev = Prefixed_Name(dbd, "bulgarianLev") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/burundianFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"burundianFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/burundianFranc">http://dbpedia.org/datatype/burundianFranc</seealso>
    let burundianFranc = Prefixed_Name(dbd, "burundianFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/byte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"byte"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/byte">http://dbpedia.org/datatype/byte</seealso>
    let byte = Prefixed_Name(dbd, "byte") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/calorie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"calorie"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/calorie">http://dbpedia.org/datatype/calorie</seealso>
    let calorie = Prefixed_Name(dbd, "calorie") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cambodianRiel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cambodianRiel"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cambodianRiel">http://dbpedia.org/datatype/cambodianRiel</seealso>
    let cambodianRiel = Prefixed_Name(dbd, "cambodianRiel") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/canadianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"canadianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/canadianDollar">http://dbpedia.org/datatype/canadianDollar</seealso>
    let canadianDollar = Prefixed_Name(dbd, "canadianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/capeVerdeEscudo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"capeVerdeEscudo"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/capeVerdeEscudo">http://dbpedia.org/datatype/capeVerdeEscudo</seealso>
    let capeVerdeEscudo = Prefixed_Name(dbd, "capeVerdeEscudo") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/carat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"carat"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/carat">http://dbpedia.org/datatype/carat</seealso>
    let carat = Prefixed_Name(dbd, "carat") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/caymanIslandsDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"caymanIslandsDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/caymanIslandsDollar">http://dbpedia.org/datatype/caymanIslandsDollar</seealso>
    let caymanIslandsDollar = Prefixed_Name(dbd, "caymanIslandsDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/centilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"centilitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/centilitre">http://dbpedia.org/datatype/centilitre</seealso>
    let centilitre = Prefixed_Name(dbd, "centilitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/centimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"centimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/centimetre">http://dbpedia.org/datatype/centimetre</seealso>
    let centimetre = Prefixed_Name(dbd, "centimetre") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/centralAfricanCfaFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"centralAfricanCfaFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/centralAfricanCfaFranc">http://dbpedia.org/datatype/centralAfricanCfaFranc</seealso>
    let centralAfricanCfaFranc =
        Prefixed_Name(dbd, "centralAfricanCfaFranc") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/cfpFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cfpFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cfpFranc">http://dbpedia.org/datatype/cfpFranc</seealso>
    let cfpFranc = Prefixed_Name(dbd, "cfpFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/chain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"chain"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/chain">http://dbpedia.org/datatype/chain</seealso>
    let chain = Prefixed_Name(dbd, "chain") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/chileanPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"chileanPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/chileanPeso">http://dbpedia.org/datatype/chileanPeso</seealso>
    let chileanPeso = Prefixed_Name(dbd, "chileanPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/colombianPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"colombianPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/colombianPeso">http://dbpedia.org/datatype/colombianPeso</seealso>
    let colombianPeso = Prefixed_Name(dbd, "colombianPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/comorianFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"comorianFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/comorianFranc">http://dbpedia.org/datatype/comorianFranc</seealso>
    let comorianFranc = Prefixed_Name(dbd, "comorianFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/congoleseFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"congoleseFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/congoleseFranc">http://dbpedia.org/datatype/congoleseFranc</seealso>
    let congoleseFranc = Prefixed_Name(dbd, "congoleseFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/costaRicanColon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"costaRicanColon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/costaRicanColon">http://dbpedia.org/datatype/costaRicanColon</seealso>
    let costaRicanColon = Prefixed_Name(dbd, "costaRicanColon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/croatianKuna</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"croatianKuna"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/croatianKuna">http://dbpedia.org/datatype/croatianKuna</seealso>
    let croatianKuna = Prefixed_Name(dbd, "croatianKuna") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubanPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubanPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubanPeso">http://dbpedia.org/datatype/cubanPeso</seealso>
    let cubanPeso = Prefixed_Name(dbd, "cubanPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicCentimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicCentimetre">http://dbpedia.org/datatype/cubicCentimetre</seealso>
    let cubicCentimetre = Prefixed_Name(dbd, "cubicCentimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicDecametre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicDecametre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicDecametre">http://dbpedia.org/datatype/cubicDecametre</seealso>
    let cubicDecametre = Prefixed_Name(dbd, "cubicDecametre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicDecimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicDecimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicDecimetre">http://dbpedia.org/datatype/cubicDecimetre</seealso>
    let cubicDecimetre = Prefixed_Name(dbd, "cubicDecimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicFeetPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicFeetPerSecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicFeetPerSecond">http://dbpedia.org/datatype/cubicFeetPerSecond</seealso>
    let cubicFeetPerSecond = Prefixed_Name(dbd, "cubicFeetPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicFeetPerYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicFeetPerYear"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicFeetPerYear">http://dbpedia.org/datatype/cubicFeetPerYear</seealso>
    let cubicFeetPerYear = Prefixed_Name(dbd, "cubicFeetPerYear") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicFoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicFoot"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicFoot">http://dbpedia.org/datatype/cubicFoot</seealso>
    let cubicFoot = Prefixed_Name(dbd, "cubicFoot") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicHectometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicHectometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicHectometre">http://dbpedia.org/datatype/cubicHectometre</seealso>
    let cubicHectometre = Prefixed_Name(dbd, "cubicHectometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicInch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicInch"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicInch">http://dbpedia.org/datatype/cubicInch</seealso>
    let cubicInch = Prefixed_Name(dbd, "cubicInch") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicKilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicKilometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicKilometre">http://dbpedia.org/datatype/cubicKilometre</seealso>
    let cubicKilometre = Prefixed_Name(dbd, "cubicKilometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicMetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicMetre">http://dbpedia.org/datatype/cubicMetre</seealso>
    let cubicMetre = Prefixed_Name(dbd, "cubicMetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicMetrePerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicMetrePerSecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicMetrePerSecond">http://dbpedia.org/datatype/cubicMetrePerSecond</seealso>
    let cubicMetrePerSecond = Prefixed_Name(dbd, "cubicMetrePerSecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicMetrePerYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicMetrePerYear"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicMetrePerYear">http://dbpedia.org/datatype/cubicMetrePerYear</seealso>
    let cubicMetrePerYear = Prefixed_Name(dbd, "cubicMetrePerYear") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicMile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicMile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicMile">http://dbpedia.org/datatype/cubicMile</seealso>
    let cubicMile = Prefixed_Name(dbd, "cubicMile") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicMillimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicMillimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicMillimetre">http://dbpedia.org/datatype/cubicMillimetre</seealso>
    let cubicMillimetre = Prefixed_Name(dbd, "cubicMillimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/cubicYard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"cubicYard"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/cubicYard">http://dbpedia.org/datatype/cubicYard</seealso>
    let cubicYard = Prefixed_Name(dbd, "cubicYard") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/czechKoruna</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"czechKoruna"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/czechKoruna">http://dbpedia.org/datatype/czechKoruna</seealso>
    let czechKoruna = Prefixed_Name(dbd, "czechKoruna") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/danishKrone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"danishKrone"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/danishKrone">http://dbpedia.org/datatype/danishKrone</seealso>
    let danishKrone = Prefixed_Name(dbd, "danishKrone") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/day</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"day"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/day">http://dbpedia.org/datatype/day</seealso>
    let day = Prefixed_Name(dbd, "day") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/decametre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"decametre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/decametre">http://dbpedia.org/datatype/decametre</seealso>
    let decametre = Prefixed_Name(dbd, "decametre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/decibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"decibar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/decibar">http://dbpedia.org/datatype/decibar</seealso>
    let decibar = Prefixed_Name(dbd, "decibar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/decilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"decilitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/decilitre">http://dbpedia.org/datatype/decilitre</seealso>
    let decilitre = Prefixed_Name(dbd, "decilitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/decimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"decimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/decimetre">http://dbpedia.org/datatype/decimetre</seealso>
    let decimetre = Prefixed_Name(dbd, "decimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/degreeCelsius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"degreeCelsius"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/degreeCelsius">http://dbpedia.org/datatype/degreeCelsius</seealso>
    let degreeCelsius = Prefixed_Name(dbd, "degreeCelsius") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/degreeFahrenheit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"degreeFahrenheit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/degreeFahrenheit">http://dbpedia.org/datatype/degreeFahrenheit</seealso>
    let degreeFahrenheit = Prefixed_Name(dbd, "degreeFahrenheit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/degreeRankine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"degreeRankine"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/degreeRankine">http://dbpedia.org/datatype/degreeRankine</seealso>
    let degreeRankine = Prefixed_Name(dbd, "degreeRankine") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/djiboutianFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"djiboutianFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/djiboutianFranc">http://dbpedia.org/datatype/djiboutianFranc</seealso>
    let djiboutianFranc = Prefixed_Name(dbd, "djiboutianFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/dominicanPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"dominicanPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/dominicanPeso">http://dbpedia.org/datatype/dominicanPeso</seealso>
    let dominicanPeso = Prefixed_Name(dbd, "dominicanPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/eastCaribbeanDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"eastCaribbeanDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/eastCaribbeanDollar">http://dbpedia.org/datatype/eastCaribbeanDollar</seealso>
    let eastCaribbeanDollar = Prefixed_Name(dbd, "eastCaribbeanDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/egyptianPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"egyptianPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/egyptianPound">http://dbpedia.org/datatype/egyptianPound</seealso>
    let egyptianPound = Prefixed_Name(dbd, "egyptianPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/engineConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"engineConfiguration"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/engineConfiguration">http://dbpedia.org/datatype/engineConfiguration</seealso>
    let engineConfiguration = Prefixed_Name(dbd, "engineConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/erg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"erg"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/erg">http://dbpedia.org/datatype/erg</seealso>
    let erg = Prefixed_Name(dbd, "erg") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/eritreanNakfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"eritreanNakfa"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/eritreanNakfa">http://dbpedia.org/datatype/eritreanNakfa</seealso>
    let eritreanNakfa = Prefixed_Name(dbd, "eritreanNakfa") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/estonianKroon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"estonianKroon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/estonianKroon">http://dbpedia.org/datatype/estonianKroon</seealso>
    let estonianKroon = Prefixed_Name(dbd, "estonianKroon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ethiopianBirr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ethiopianBirr"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ethiopianBirr">http://dbpedia.org/datatype/ethiopianBirr</seealso>
    let ethiopianBirr = Prefixed_Name(dbd, "ethiopianBirr") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/euro</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"euro"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/euro">http://dbpedia.org/datatype/euro</seealso>
    let euro = Prefixed_Name(dbd, "euro") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/falklandIslandsPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"falklandIslandsPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/falklandIslandsPound">http://dbpedia.org/datatype/falklandIslandsPound</seealso>
    let falklandIslandsPound =
        Prefixed_Name(dbd, "falklandIslandsPound") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/fathom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"fathom"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/fathom">http://dbpedia.org/datatype/fathom</seealso>
    let fathom = Prefixed_Name(dbd, "fathom") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/fijiDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"fijiDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/fijiDollar">http://dbpedia.org/datatype/fijiDollar</seealso>
    let fijiDollar = Prefixed_Name(dbd, "fijiDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/foot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"foot"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/foot">http://dbpedia.org/datatype/foot</seealso>
    let foot = Prefixed_Name(dbd, "foot") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/footPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"footPerMinute"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/footPerMinute">http://dbpedia.org/datatype/footPerMinute</seealso>
    let footPerMinute = Prefixed_Name(dbd, "footPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/footPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"footPerSecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/footPerSecond">http://dbpedia.org/datatype/footPerSecond</seealso>
    let footPerSecond = Prefixed_Name(dbd, "footPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/footPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"footPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/footPound">http://dbpedia.org/datatype/footPound</seealso>
    let footPound = Prefixed_Name(dbd, "footPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/fuelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"fuelType"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/fuelType">http://dbpedia.org/datatype/fuelType</seealso>
    let fuelType = Prefixed_Name(dbd, "fuelType") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/furlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"furlong"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/furlong">http://dbpedia.org/datatype/furlong</seealso>
    let furlong = Prefixed_Name(dbd, "furlong") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gambianDalasi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gambianDalasi"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gambianDalasi">http://dbpedia.org/datatype/gambianDalasi</seealso>
    let gambianDalasi = Prefixed_Name(dbd, "gambianDalasi") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/georgianLari</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"georgianLari"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/georgianLari">http://dbpedia.org/datatype/georgianLari</seealso>
    let georgianLari = Prefixed_Name(dbd, "georgianLari") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ghanaianCedi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ghanaianCedi"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ghanaianCedi">http://dbpedia.org/datatype/ghanaianCedi</seealso>
    let ghanaianCedi = Prefixed_Name(dbd, "ghanaianCedi") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gibraltarPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gibraltarPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gibraltarPound">http://dbpedia.org/datatype/gibraltarPound</seealso>
    let gibraltarPound = Prefixed_Name(dbd, "gibraltarPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigabyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigabyte"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigabyte">http://dbpedia.org/datatype/gigabyte</seealso>
    let gigabyte = Prefixed_Name(dbd, "gigabyte") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigahertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigahertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigahertz">http://dbpedia.org/datatype/gigahertz</seealso>
    let gigahertz = Prefixed_Name(dbd, "gigahertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigalitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigalitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigalitre">http://dbpedia.org/datatype/gigalitre</seealso>
    let gigalitre = Prefixed_Name(dbd, "gigalitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigametre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigametre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigametre">http://dbpedia.org/datatype/gigametre</seealso>
    let gigametre = Prefixed_Name(dbd, "gigametre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/giganewton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"giganewton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/giganewton">http://dbpedia.org/datatype/giganewton</seealso>
    let giganewton = Prefixed_Name(dbd, "giganewton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigawatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigawatt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigawatt">http://dbpedia.org/datatype/gigawatt</seealso>
    let gigawatt = Prefixed_Name(dbd, "gigawatt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gigawattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gigawattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gigawattHour">http://dbpedia.org/datatype/gigawattHour</seealso>
    let gigawattHour = Prefixed_Name(dbd, "gigawattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/grain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"grain"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/grain">http://dbpedia.org/datatype/grain</seealso>
    let grain = Prefixed_Name(dbd, "grain") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gram"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gram">http://dbpedia.org/datatype/gram</seealso>
    let gram = Prefixed_Name(dbd, "gram") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gramForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gramForce"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gramForce">http://dbpedia.org/datatype/gramForce</seealso>
    let gramForce = Prefixed_Name(dbd, "gramForce") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/gramPerCubicCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gramPerCubicCentimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gramPerCubicCentimetre">http://dbpedia.org/datatype/gramPerCubicCentimetre</seealso>
    let gramPerCubicCentimetre =
        Prefixed_Name(dbd, "gramPerCubicCentimetre") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/gramPerKilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gramPerKilometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gramPerKilometre">http://dbpedia.org/datatype/gramPerKilometre</seealso>
    let gramPerKilometre = Prefixed_Name(dbd, "gramPerKilometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/gramPerMillilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"gramPerMillilitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/gramPerMillilitre">http://dbpedia.org/datatype/gramPerMillilitre</seealso>
    let gramPerMillilitre = Prefixed_Name(dbd, "gramPerMillilitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/guatemalanQuetzal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"guatemalanQuetzal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/guatemalanQuetzal">http://dbpedia.org/datatype/guatemalanQuetzal</seealso>
    let guatemalanQuetzal = Prefixed_Name(dbd, "guatemalanQuetzal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/guineaFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"guineaFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/guineaFranc">http://dbpedia.org/datatype/guineaFranc</seealso>
    let guineaFranc = Prefixed_Name(dbd, "guineaFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/guyanaDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"guyanaDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/guyanaDollar">http://dbpedia.org/datatype/guyanaDollar</seealso>
    let guyanaDollar = Prefixed_Name(dbd, "guyanaDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/haitiGourde</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"haitiGourde"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/haitiGourde">http://dbpedia.org/datatype/haitiGourde</seealso>
    let haitiGourde = Prefixed_Name(dbd, "haitiGourde") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hand"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hand">http://dbpedia.org/datatype/hand</seealso>
    let hand = Prefixed_Name(dbd, "hand") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hectare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hectare"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hectare">http://dbpedia.org/datatype/hectare</seealso>
    let hectare = Prefixed_Name(dbd, "hectare") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hectolitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hectolitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hectolitre">http://dbpedia.org/datatype/hectolitre</seealso>
    let hectolitre = Prefixed_Name(dbd, "hectolitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hectometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hectometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hectometre">http://dbpedia.org/datatype/hectometre</seealso>
    let hectometre = Prefixed_Name(dbd, "hectometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hectopascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hectopascal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hectopascal">http://dbpedia.org/datatype/hectopascal</seealso>
    let hectopascal = Prefixed_Name(dbd, "hectopascal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hertz">http://dbpedia.org/datatype/hertz</seealso>
    let hertz = Prefixed_Name(dbd, "hertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/honduranLempira</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"honduranLempira"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/honduranLempira">http://dbpedia.org/datatype/honduranLempira</seealso>
    let honduranLempira = Prefixed_Name(dbd, "honduranLempira") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hongKongDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hongKongDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hongKongDollar">http://dbpedia.org/datatype/hongKongDollar</seealso>
    let hongKongDollar = Prefixed_Name(dbd, "hongKongDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/horsepower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"horsepower"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/horsepower">http://dbpedia.org/datatype/horsepower</seealso>
    let horsepower = Prefixed_Name(dbd, "horsepower") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hour">http://dbpedia.org/datatype/hour</seealso>
    let hour = Prefixed_Name(dbd, "hour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/hungarianForint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"hungarianForint"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/hungarianForint">http://dbpedia.org/datatype/hungarianForint</seealso>
    let hungarianForint = Prefixed_Name(dbd, "hungarianForint") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/icelandKrona</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"icelandKrona"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/icelandKrona">http://dbpedia.org/datatype/icelandKrona</seealso>
    let icelandKrona = Prefixed_Name(dbd, "icelandKrona") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/imperialBarrel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"imperialBarrel"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/imperialBarrel">http://dbpedia.org/datatype/imperialBarrel</seealso>
    let imperialBarrel = Prefixed_Name(dbd, "imperialBarrel") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/imperialBarrelOil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"imperialBarrelOil"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/imperialBarrelOil">http://dbpedia.org/datatype/imperialBarrelOil</seealso>
    let imperialBarrelOil = Prefixed_Name(dbd, "imperialBarrelOil") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/imperialGallon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"imperialGallon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/imperialGallon">http://dbpedia.org/datatype/imperialGallon</seealso>
    let imperialGallon = Prefixed_Name(dbd, "imperialGallon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/inch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"inch"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/inch">http://dbpedia.org/datatype/inch</seealso>
    let inch = Prefixed_Name(dbd, "inch") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/inchPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"inchPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/inchPound">http://dbpedia.org/datatype/inchPound</seealso>
    let inchPound = Prefixed_Name(dbd, "inchPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/indianRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"indianRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/indianRupee">http://dbpedia.org/datatype/indianRupee</seealso>
    let indianRupee = Prefixed_Name(dbd, "indianRupee") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/indonesianRupiah</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"indonesianRupiah"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/indonesianRupiah">http://dbpedia.org/datatype/indonesianRupiah</seealso>
    let indonesianRupiah = Prefixed_Name(dbd, "indonesianRupiah") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/inhabitantsPerSquareKilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"inhabitantsPerSquareKilometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/inhabitantsPerSquareKilometre">http://dbpedia.org/datatype/inhabitantsPerSquareKilometre</seealso>
    let inhabitantsPerSquareKilometre =
        Prefixed_Name(dbd, "inhabitantsPerSquareKilometre") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/inhabitantsPerSquareMile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"inhabitantsPerSquareMile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/inhabitantsPerSquareMile">http://dbpedia.org/datatype/inhabitantsPerSquareMile</seealso>
    let inhabitantsPerSquareMile =
        Prefixed_Name(dbd, "inhabitantsPerSquareMile") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/iranianRial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"iranianRial"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/iranianRial">http://dbpedia.org/datatype/iranianRial</seealso>
    let iranianRial = Prefixed_Name(dbd, "iranianRial") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/iraqiDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"iraqiDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/iraqiDinar">http://dbpedia.org/datatype/iraqiDinar</seealso>
    let iraqiDinar = Prefixed_Name(dbd, "iraqiDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/israeliNewSheqel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"israeliNewSheqel"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/israeliNewSheqel">http://dbpedia.org/datatype/israeliNewSheqel</seealso>
    let israeliNewSheqel = Prefixed_Name(dbd, "israeliNewSheqel") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/jamaicanDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"jamaicanDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/jamaicanDollar">http://dbpedia.org/datatype/jamaicanDollar</seealso>
    let jamaicanDollar = Prefixed_Name(dbd, "jamaicanDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/japaneseYen</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"japaneseYen"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/japaneseYen">http://dbpedia.org/datatype/japaneseYen</seealso>
    let japaneseYen = Prefixed_Name(dbd, "japaneseYen") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/jordanianDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"jordanianDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/jordanianDinar">http://dbpedia.org/datatype/jordanianDinar</seealso>
    let jordanianDinar = Prefixed_Name(dbd, "jordanianDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/joule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"joule"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/joule">http://dbpedia.org/datatype/joule</seealso>
    let joule = Prefixed_Name(dbd, "joule") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kazakhstaniTenge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kazakhstaniTenge"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kazakhstaniTenge">http://dbpedia.org/datatype/kazakhstaniTenge</seealso>
    let kazakhstaniTenge = Prefixed_Name(dbd, "kazakhstaniTenge") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kelvin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kelvin"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kelvin">http://dbpedia.org/datatype/kelvin</seealso>
    let kelvin = Prefixed_Name(dbd, "kelvin") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kenyanShilling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kenyanShilling"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kenyanShilling">http://dbpedia.org/datatype/kenyanShilling</seealso>
    let kenyanShilling = Prefixed_Name(dbd, "kenyanShilling") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kiloampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kiloampere"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kiloampere">http://dbpedia.org/datatype/kiloampere</seealso>
    let kiloampere = Prefixed_Name(dbd, "kiloampere") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilobit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilobit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilobit">http://dbpedia.org/datatype/kilobit</seealso>
    let kilobit = Prefixed_Name(dbd, "kilobit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilobyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilobyte"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilobyte">http://dbpedia.org/datatype/kilobyte</seealso>
    let kilobyte = Prefixed_Name(dbd, "kilobyte") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilocalorie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilocalorie"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilocalorie">http://dbpedia.org/datatype/kilocalorie</seealso>
    let kilocalorie = Prefixed_Name(dbd, "kilocalorie") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilogram"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilogram">http://dbpedia.org/datatype/kilogram</seealso>
    let kilogram = Prefixed_Name(dbd, "kilogram") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilogramForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilogramForce"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilogramForce">http://dbpedia.org/datatype/kilogramForce</seealso>
    let kilogramForce = Prefixed_Name(dbd, "kilogramForce") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/kilogramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilogramPerCubicMetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilogramPerCubicMetre">http://dbpedia.org/datatype/kilogramPerCubicMetre</seealso>
    let kilogramPerCubicMetre =
        Prefixed_Name(dbd, "kilogramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/kilogramPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilogramPerLitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilogramPerLitre">http://dbpedia.org/datatype/kilogramPerLitre</seealso>
    let kilogramPerLitre = Prefixed_Name(dbd, "kilogramPerLitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilohertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilohertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilohertz">http://dbpedia.org/datatype/kilohertz</seealso>
    let kilohertz = Prefixed_Name(dbd, "kilohertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilojoule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilojoule"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilojoule">http://dbpedia.org/datatype/kilojoule</seealso>
    let kilojoule = Prefixed_Name(dbd, "kilojoule") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilolightYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilolightYear"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilolightYear">http://dbpedia.org/datatype/kilolightYear</seealso>
    let kilolightYear = Prefixed_Name(dbd, "kilolightYear") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilolitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilolitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilolitre">http://dbpedia.org/datatype/kilolitre</seealso>
    let kilolitre = Prefixed_Name(dbd, "kilolitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilometre">http://dbpedia.org/datatype/kilometre</seealso>
    let kilometre = Prefixed_Name(dbd, "kilometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilometrePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilometrePerHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilometrePerHour">http://dbpedia.org/datatype/kilometrePerHour</seealso>
    let kilometrePerHour = Prefixed_Name(dbd, "kilometrePerHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilometrePerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilometrePerSecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilometrePerSecond">http://dbpedia.org/datatype/kilometrePerSecond</seealso>
    let kilometrePerSecond = Prefixed_Name(dbd, "kilometrePerSecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilometresPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilometresPerLitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilometresPerLitre">http://dbpedia.org/datatype/kilometresPerLitre</seealso>
    let kilometresPerLitre = Prefixed_Name(dbd, "kilometresPerLitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilonewton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilonewton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilonewton">http://dbpedia.org/datatype/kilonewton</seealso>
    let kilonewton = Prefixed_Name(dbd, "kilonewton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilopascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilopascal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilopascal">http://dbpedia.org/datatype/kilopascal</seealso>
    let kilopascal = Prefixed_Name(dbd, "kilopascal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilopond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilopond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilopond">http://dbpedia.org/datatype/kilopond</seealso>
    let kilopond = Prefixed_Name(dbd, "kilopond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilovolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilovolt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilovolt">http://dbpedia.org/datatype/kilovolt</seealso>
    let kilovolt = Prefixed_Name(dbd, "kilovolt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilowatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilowatt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilowatt">http://dbpedia.org/datatype/kilowatt</seealso>
    let kilowatt = Prefixed_Name(dbd, "kilowatt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kilowattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kilowattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kilowattHour">http://dbpedia.org/datatype/kilowattHour</seealso>
    let kilowattHour = Prefixed_Name(dbd, "kilowattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/knot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"knot"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/knot">http://dbpedia.org/datatype/knot</seealso>
    let knot = Prefixed_Name(dbd, "knot") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kuwaitiDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kuwaitiDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kuwaitiDinar">http://dbpedia.org/datatype/kuwaitiDinar</seealso>
    let kuwaitiDinar = Prefixed_Name(dbd, "kuwaitiDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/kyrgyzstaniSom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"kyrgyzstaniSom"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/kyrgyzstaniSom">http://dbpedia.org/datatype/kyrgyzstaniSom</seealso>
    let kyrgyzstaniSom = Prefixed_Name(dbd, "kyrgyzstaniSom") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/laoKip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"laoKip"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/laoKip">http://dbpedia.org/datatype/laoKip</seealso>
    let laoKip = Prefixed_Name(dbd, "laoKip") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/latvianLats</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"latvianLats"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/latvianLats">http://dbpedia.org/datatype/latvianLats</seealso>
    let latvianLats = Prefixed_Name(dbd, "latvianLats") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/lebanesePound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"lebanesePound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/lebanesePound">http://dbpedia.org/datatype/lebanesePound</seealso>
    let lebanesePound = Prefixed_Name(dbd, "lebanesePound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/lesothoLoti</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"lesothoLoti"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/lesothoLoti">http://dbpedia.org/datatype/lesothoLoti</seealso>
    let lesothoLoti = Prefixed_Name(dbd, "lesothoLoti") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/liberianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"liberianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/liberianDollar">http://dbpedia.org/datatype/liberianDollar</seealso>
    let liberianDollar = Prefixed_Name(dbd, "liberianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/libyanDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"libyanDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/libyanDinar">http://dbpedia.org/datatype/libyanDinar</seealso>
    let libyanDinar = Prefixed_Name(dbd, "libyanDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/lightYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"lightYear"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/lightYear">http://dbpedia.org/datatype/lightYear</seealso>
    let lightYear = Prefixed_Name(dbd, "lightYear") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/lithuanianLitas</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"lithuanianLitas"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/lithuanianLitas">http://dbpedia.org/datatype/lithuanianLitas</seealso>
    let lithuanianLitas = Prefixed_Name(dbd, "lithuanianLitas") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/litre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"litre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/litre">http://dbpedia.org/datatype/litre</seealso>
    let litre = Prefixed_Name(dbd, "litre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/macanesePataca</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"macanesePataca"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/macanesePataca">http://dbpedia.org/datatype/macanesePataca</seealso>
    let macanesePataca = Prefixed_Name(dbd, "macanesePataca") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/macedonianDenar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"macedonianDenar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/macedonianDenar">http://dbpedia.org/datatype/macedonianDenar</seealso>
    let macedonianDenar = Prefixed_Name(dbd, "macedonianDenar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/malagasyAriary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"malagasyAriary"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/malagasyAriary">http://dbpedia.org/datatype/malagasyAriary</seealso>
    let malagasyAriary = Prefixed_Name(dbd, "malagasyAriary") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/malawianKwacha</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"malawianKwacha"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/malawianKwacha">http://dbpedia.org/datatype/malawianKwacha</seealso>
    let malawianKwacha = Prefixed_Name(dbd, "malawianKwacha") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/malaysianRinggit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"malaysianRinggit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/malaysianRinggit">http://dbpedia.org/datatype/malaysianRinggit</seealso>
    let malaysianRinggit = Prefixed_Name(dbd, "malaysianRinggit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/maldivianRufiyaa</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"maldivianRufiyaa"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/maldivianRufiyaa">http://dbpedia.org/datatype/maldivianRufiyaa</seealso>
    let maldivianRufiyaa = Prefixed_Name(dbd, "maldivianRufiyaa") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/mauritanianOuguiya</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mauritanianOuguiya"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mauritanianOuguiya">http://dbpedia.org/datatype/mauritanianOuguiya</seealso>
    let mauritanianOuguiya = Prefixed_Name(dbd, "mauritanianOuguiya") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/mauritianRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mauritianRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mauritianRupee">http://dbpedia.org/datatype/mauritianRupee</seealso>
    let mauritianRupee = Prefixed_Name(dbd, "mauritianRupee") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megabit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megabit"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megabit">http://dbpedia.org/datatype/megabit</seealso>
    let megabit = Prefixed_Name(dbd, "megabit") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megabyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megabyte"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megabyte">http://dbpedia.org/datatype/megabyte</seealso>
    let megabyte = Prefixed_Name(dbd, "megabyte") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megacalorie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megacalorie"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megacalorie">http://dbpedia.org/datatype/megacalorie</seealso>
    let megacalorie = Prefixed_Name(dbd, "megacalorie") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megahertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megahertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megahertz">http://dbpedia.org/datatype/megahertz</seealso>
    let megahertz = Prefixed_Name(dbd, "megahertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megalitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megalitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megalitre">http://dbpedia.org/datatype/megalitre</seealso>
    let megalitre = Prefixed_Name(dbd, "megalitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megametre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megametre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megametre">http://dbpedia.org/datatype/megametre</seealso>
    let megametre = Prefixed_Name(dbd, "megametre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/meganewton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"meganewton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/meganewton">http://dbpedia.org/datatype/meganewton</seealso>
    let meganewton = Prefixed_Name(dbd, "meganewton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megapascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megapascal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megapascal">http://dbpedia.org/datatype/megapascal</seealso>
    let megapascal = Prefixed_Name(dbd, "megapascal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megapond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megapond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megapond">http://dbpedia.org/datatype/megapond</seealso>
    let megapond = Prefixed_Name(dbd, "megapond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megavolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megavolt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megavolt">http://dbpedia.org/datatype/megavolt</seealso>
    let megavolt = Prefixed_Name(dbd, "megavolt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megawatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megawatt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megawatt">http://dbpedia.org/datatype/megawatt</seealso>
    let megawatt = Prefixed_Name(dbd, "megawatt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/megawattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"megawattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/megawattHour">http://dbpedia.org/datatype/megawattHour</seealso>
    let megawattHour = Prefixed_Name(dbd, "megawattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/metre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"metre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/metre">http://dbpedia.org/datatype/metre</seealso>
    let metre = Prefixed_Name(dbd, "metre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/metrePerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"metrePerSecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/metrePerSecond">http://dbpedia.org/datatype/metrePerSecond</seealso>
    let metrePerSecond = Prefixed_Name(dbd, "metrePerSecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/mexicanPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mexicanPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mexicanPeso">http://dbpedia.org/datatype/mexicanPeso</seealso>
    let mexicanPeso = Prefixed_Name(dbd, "mexicanPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/microampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"microampere"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/microampere">http://dbpedia.org/datatype/microampere</seealso>
    let microampere = Prefixed_Name(dbd, "microampere") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/microlitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"microlitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/microlitre">http://dbpedia.org/datatype/microlitre</seealso>
    let microlitre = Prefixed_Name(dbd, "microlitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/micrometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"micrometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/micrometre">http://dbpedia.org/datatype/micrometre</seealso>
    let micrometre = Prefixed_Name(dbd, "micrometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/microsecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"microsecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/microsecond">http://dbpedia.org/datatype/microsecond</seealso>
    let microsecond = Prefixed_Name(dbd, "microsecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/microvolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"microvolt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/microvolt">http://dbpedia.org/datatype/microvolt</seealso>
    let microvolt = Prefixed_Name(dbd, "microvolt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/mile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mile">http://dbpedia.org/datatype/mile</seealso>
    let mile = Prefixed_Name(dbd, "mile") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milePerHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milePerHour">http://dbpedia.org/datatype/milePerHour</seealso>
    let milePerHour = Prefixed_Name(dbd, "milePerHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milliampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milliampere"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milliampere">http://dbpedia.org/datatype/milliampere</seealso>
    let milliampere = Prefixed_Name(dbd, "milliampere") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millibar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millibar">http://dbpedia.org/datatype/millibar</seealso>
    let millibar = Prefixed_Name(dbd, "millibar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millicalorie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millicalorie"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millicalorie">http://dbpedia.org/datatype/millicalorie</seealso>
    let millicalorie = Prefixed_Name(dbd, "millicalorie") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milligram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milligram"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milligram">http://dbpedia.org/datatype/milligram</seealso>
    let milligram = Prefixed_Name(dbd, "milligram") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milligramForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milligramForce"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milligramForce">http://dbpedia.org/datatype/milligramForce</seealso>
    let milligramForce = Prefixed_Name(dbd, "milligramForce") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millihertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millihertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millihertz">http://dbpedia.org/datatype/millihertz</seealso>
    let millihertz = Prefixed_Name(dbd, "millihertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millilitre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millilitre">http://dbpedia.org/datatype/millilitre</seealso>
    let millilitre = Prefixed_Name(dbd, "millilitre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millimetre">http://dbpedia.org/datatype/millimetre</seealso>
    let millimetre = Prefixed_Name(dbd, "millimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millinewton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millinewton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millinewton">http://dbpedia.org/datatype/millinewton</seealso>
    let millinewton = Prefixed_Name(dbd, "millinewton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millipascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millipascal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millipascal">http://dbpedia.org/datatype/millipascal</seealso>
    let millipascal = Prefixed_Name(dbd, "millipascal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millipond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millipond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millipond">http://dbpedia.org/datatype/millipond</seealso>
    let millipond = Prefixed_Name(dbd, "millipond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millisecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millisecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millisecond">http://dbpedia.org/datatype/millisecond</seealso>
    let millisecond = Prefixed_Name(dbd, "millisecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/millivolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"millivolt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/millivolt">http://dbpedia.org/datatype/millivolt</seealso>
    let millivolt = Prefixed_Name(dbd, "millivolt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milliwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milliwatt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milliwatt">http://dbpedia.org/datatype/milliwatt</seealso>
    let milliwatt = Prefixed_Name(dbd, "milliwatt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/milliwattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"milliwattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/milliwattHour">http://dbpedia.org/datatype/milliwattHour</seealso>
    let milliwattHour = Prefixed_Name(dbd, "milliwattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"minute"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/minute">http://dbpedia.org/datatype/minute</seealso>
    let minute = Prefixed_Name(dbd, "minute") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/moldovanLeu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"moldovanLeu"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/moldovanLeu">http://dbpedia.org/datatype/moldovanLeu</seealso>
    let moldovanLeu = Prefixed_Name(dbd, "moldovanLeu") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/mongolianT%C3%B6gr%C3%B6g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mongolianTögrög"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mongolianT%C3%B6gr%C3%B6g">http://dbpedia.org/datatype/mongolianT%C3%B6gr%C3%B6g</seealso>
    let ``mongolianT%C3%B6gr%C3%B6g`` =
        Prefixed_Name(dbd, "mongolianT%C3%B6gr%C3%B6g") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/moroccanDirham</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"moroccanDirham"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/moroccanDirham">http://dbpedia.org/datatype/moroccanDirham</seealso>
    let moroccanDirham = Prefixed_Name(dbd, "moroccanDirham") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/mozambicanMetical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"mozambicanMetical"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/mozambicanMetical">http://dbpedia.org/datatype/mozambicanMetical</seealso>
    let mozambicanMetical = Prefixed_Name(dbd, "mozambicanMetical") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/myanmaKyat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"myanmaKyat"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/myanmaKyat">http://dbpedia.org/datatype/myanmaKyat</seealso>
    let myanmaKyat = Prefixed_Name(dbd, "myanmaKyat") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/namibianDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"namibianDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/namibianDollar">http://dbpedia.org/datatype/namibianDollar</seealso>
    let namibianDollar = Prefixed_Name(dbd, "namibianDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/nanometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nanometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nanometre">http://dbpedia.org/datatype/nanometre</seealso>
    let nanometre = Prefixed_Name(dbd, "nanometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/nanonewton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nanonewton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nanonewton">http://dbpedia.org/datatype/nanonewton</seealso>
    let nanonewton = Prefixed_Name(dbd, "nanonewton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/nanosecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nanosecond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nanosecond">http://dbpedia.org/datatype/nanosecond</seealso>
    let nanosecond = Prefixed_Name(dbd, "nanosecond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/nautialMile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nautialMile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nautialMile">http://dbpedia.org/datatype/nautialMile</seealso>
    let nautialMile = Prefixed_Name(dbd, "nautialMile") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/nepaleseRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nepaleseRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nepaleseRupee">http://dbpedia.org/datatype/nepaleseRupee</seealso>
    let nepaleseRupee = Prefixed_Name(dbd, "nepaleseRupee") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/netherlandsAntilleanGuilder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"netherlandsAntilleanGuilder"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/netherlandsAntilleanGuilder">http://dbpedia.org/datatype/netherlandsAntilleanGuilder</seealso>
    let netherlandsAntilleanGuilder =
        Prefixed_Name(dbd, "netherlandsAntilleanGuilder") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/newTaiwanDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newTaiwanDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newTaiwanDollar">http://dbpedia.org/datatype/newTaiwanDollar</seealso>
    let newTaiwanDollar = Prefixed_Name(dbd, "newTaiwanDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/newZealandDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newZealandDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newZealandDollar">http://dbpedia.org/datatype/newZealandDollar</seealso>
    let newZealandDollar = Prefixed_Name(dbd, "newZealandDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/newton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newton"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newton">http://dbpedia.org/datatype/newton</seealso>
    let newton = Prefixed_Name(dbd, "newton") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/newtonCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newtonCentimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newtonCentimetre">http://dbpedia.org/datatype/newtonCentimetre</seealso>
    let newtonCentimetre = Prefixed_Name(dbd, "newtonCentimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/newtonMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newtonMetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newtonMetre">http://dbpedia.org/datatype/newtonMetre</seealso>
    let newtonMetre = Prefixed_Name(dbd, "newtonMetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/newtonMillimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"newtonMillimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/newtonMillimetre">http://dbpedia.org/datatype/newtonMillimetre</seealso>
    let newtonMillimetre = Prefixed_Name(dbd, "newtonMillimetre") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/nicaraguanC%C3%B3rdoba</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nicaraguanCórdoba"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nicaraguanC%C3%B3rdoba">http://dbpedia.org/datatype/nicaraguanC%C3%B3rdoba</seealso>
    let ``nicaraguanC%C3%B3rdoba`` =
        Prefixed_Name(dbd, "nicaraguanC%C3%B3rdoba") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/nigerianNaira</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"nigerianNaira"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/nigerianNaira">http://dbpedia.org/datatype/nigerianNaira</seealso>
    let nigerianNaira = Prefixed_Name(dbd, "nigerianNaira") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/northKoreanWon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"northKoreanWon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/northKoreanWon">http://dbpedia.org/datatype/northKoreanWon</seealso>
    let northKoreanWon = Prefixed_Name(dbd, "northKoreanWon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/norwegianKrone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"norwegianKrone"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/norwegianKrone">http://dbpedia.org/datatype/norwegianKrone</seealso>
    let norwegianKrone = Prefixed_Name(dbd, "norwegianKrone") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/omaniRial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"omaniRial"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/omaniRial">http://dbpedia.org/datatype/omaniRial</seealso>
    let omaniRial = Prefixed_Name(dbd, "omaniRial") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ounce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ounce"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ounce">http://dbpedia.org/datatype/ounce</seealso>
    let ounce = Prefixed_Name(dbd, "ounce") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/pakistaniRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"pakistaniRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/pakistaniRupee">http://dbpedia.org/datatype/pakistaniRupee</seealso>
    let pakistaniRupee = Prefixed_Name(dbd, "pakistaniRupee") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/panamanianBalboa</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"panamanianBalboa"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/panamanianBalboa">http://dbpedia.org/datatype/panamanianBalboa</seealso>
    let panamanianBalboa = Prefixed_Name(dbd, "panamanianBalboa") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/papuaNewGuineanKina</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"papuaNewGuineanKina"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/papuaNewGuineanKina">http://dbpedia.org/datatype/papuaNewGuineanKina</seealso>
    let papuaNewGuineanKina = Prefixed_Name(dbd, "papuaNewGuineanKina") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/paraguayanGuarani</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"paraguayanGuarani"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/paraguayanGuarani">http://dbpedia.org/datatype/paraguayanGuarani</seealso>
    let paraguayanGuarani = Prefixed_Name(dbd, "paraguayanGuarani") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/pascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"pascal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/pascal">http://dbpedia.org/datatype/pascal</seealso>
    let pascal = Prefixed_Name(dbd, "pascal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/perCent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"perCent"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/perCent">http://dbpedia.org/datatype/perCent</seealso>
    let perCent = Prefixed_Name(dbd, "perCent") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/perMil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"perMil"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/perMil">http://dbpedia.org/datatype/perMil</seealso>
    let perMil = Prefixed_Name(dbd, "perMil") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/peruvianNuevoSol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"peruvianNuevoSol"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/peruvianNuevoSol">http://dbpedia.org/datatype/peruvianNuevoSol</seealso>
    let peruvianNuevoSol = Prefixed_Name(dbd, "peruvianNuevoSol") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/pferdestaerke</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"pferdestaerke"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/pferdestaerke">http://dbpedia.org/datatype/pferdestaerke</seealso>
    let pferdestaerke = Prefixed_Name(dbd, "pferdestaerke") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/philippinePeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"philippinePeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/philippinePeso">http://dbpedia.org/datatype/philippinePeso</seealso>
    let philippinePeso = Prefixed_Name(dbd, "philippinePeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/polishZ%C5%82oty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"polishZłoty"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/polishZ%C5%82oty">http://dbpedia.org/datatype/polishZ%C5%82oty</seealso>
    let ``polishZ%C5%82oty`` = Prefixed_Name(dbd, "polishZ%C5%82oty") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/pond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"pond"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/pond">http://dbpedia.org/datatype/pond</seealso>
    let pond = Prefixed_Name(dbd, "pond") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/pound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"pound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/pound">http://dbpedia.org/datatype/pound</seealso>
    let pound = Prefixed_Name(dbd, "pound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/poundFoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"poundFoot"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/poundFoot">http://dbpedia.org/datatype/poundFoot</seealso>
    let poundFoot = Prefixed_Name(dbd, "poundFoot") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/poundPerSquareInch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"poundPerSquareInch"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/poundPerSquareInch">http://dbpedia.org/datatype/poundPerSquareInch</seealso>
    let poundPerSquareInch = Prefixed_Name(dbd, "poundPerSquareInch") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/poundSterling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"poundSterling"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/poundSterling">http://dbpedia.org/datatype/poundSterling</seealso>
    let poundSterling = Prefixed_Name(dbd, "poundSterling") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/poundal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"poundal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/poundal">http://dbpedia.org/datatype/poundal</seealso>
    let poundal = Prefixed_Name(dbd, "poundal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/qatariRial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"qatariRial"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/qatariRial">http://dbpedia.org/datatype/qatariRial</seealso>
    let qatariRial = Prefixed_Name(dbd, "qatariRial") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/renminbi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"renminbi"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/renminbi">http://dbpedia.org/datatype/renminbi</seealso>
    let renminbi = Prefixed_Name(dbd, "renminbi") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/rod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"rod"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/rod">http://dbpedia.org/datatype/rod</seealso>
    let rod = Prefixed_Name(dbd, "rod") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/romanianNewLeu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"romanianNewLeu"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/romanianNewLeu">http://dbpedia.org/datatype/romanianNewLeu</seealso>
    let romanianNewLeu = Prefixed_Name(dbd, "romanianNewLeu") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/russianRouble</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"russianRouble"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/russianRouble">http://dbpedia.org/datatype/russianRouble</seealso>
    let russianRouble = Prefixed_Name(dbd, "russianRouble") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/rwandaFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"rwandaFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/rwandaFranc">http://dbpedia.org/datatype/rwandaFranc</seealso>
    let rwandaFranc = Prefixed_Name(dbd, "rwandaFranc") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/s%C3%A3oTom%C3%A9AndPr%C3%ADncipeDobra</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"sãoToméAndPríncipeDobra"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/s%C3%A3oTom%C3%A9AndPr%C3%ADncipeDobra">http://dbpedia.org/datatype/s%C3%A3oTom%C3%A9AndPr%C3%ADncipeDobra</seealso>
    let ``s%C3%A3oTom%C3%A9AndPr%C3%ADncipeDobra`` =
        Prefixed_Name(dbd, "s%C3%A3oTom%C3%A9AndPr%C3%ADncipeDobra") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/saintHelenaPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"saintHelenaPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/saintHelenaPound">http://dbpedia.org/datatype/saintHelenaPound</seealso>
    let saintHelenaPound = Prefixed_Name(dbd, "saintHelenaPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/samoanTala</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"samoanTala"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/samoanTala">http://dbpedia.org/datatype/samoanTala</seealso>
    let samoanTala = Prefixed_Name(dbd, "samoanTala") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/saudiRiyal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"saudiRiyal"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/saudiRiyal">http://dbpedia.org/datatype/saudiRiyal</seealso>
    let saudiRiyal = Prefixed_Name(dbd, "saudiRiyal") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/second</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"second"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/second">http://dbpedia.org/datatype/second</seealso>
    let second = Prefixed_Name(dbd, "second") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/serbianDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"serbianDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/serbianDinar">http://dbpedia.org/datatype/serbianDinar</seealso>
    let serbianDinar = Prefixed_Name(dbd, "serbianDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/seychellesRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"seychellesRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/seychellesRupee">http://dbpedia.org/datatype/seychellesRupee</seealso>
    let seychellesRupee = Prefixed_Name(dbd, "seychellesRupee") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/sierraLeoneanLeone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"sierraLeoneanLeone"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/sierraLeoneanLeone">http://dbpedia.org/datatype/sierraLeoneanLeone</seealso>
    let sierraLeoneanLeone = Prefixed_Name(dbd, "sierraLeoneanLeone") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/singaporeDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"singaporeDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/singaporeDollar">http://dbpedia.org/datatype/singaporeDollar</seealso>
    let singaporeDollar = Prefixed_Name(dbd, "singaporeDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/slovakKoruna</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"slovakKoruna"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/slovakKoruna">http://dbpedia.org/datatype/slovakKoruna</seealso>
    let slovakKoruna = Prefixed_Name(dbd, "slovakKoruna") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/solomonIslandsDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"solomonIslandsDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/solomonIslandsDollar">http://dbpedia.org/datatype/solomonIslandsDollar</seealso>
    let solomonIslandsDollar =
        Prefixed_Name(dbd, "solomonIslandsDollar") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/somaliShilling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"somaliShilling"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/somaliShilling">http://dbpedia.org/datatype/somaliShilling</seealso>
    let somaliShilling = Prefixed_Name(dbd, "somaliShilling") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/southAfricanRand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"southAfricanRand"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/southAfricanRand">http://dbpedia.org/datatype/southAfricanRand</seealso>
    let southAfricanRand = Prefixed_Name(dbd, "southAfricanRand") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/southKoreanWon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"southKoreanWon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/southKoreanWon">http://dbpedia.org/datatype/southKoreanWon</seealso>
    let southKoreanWon = Prefixed_Name(dbd, "southKoreanWon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareCentimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareCentimetre">http://dbpedia.org/datatype/squareCentimetre</seealso>
    let squareCentimetre = Prefixed_Name(dbd, "squareCentimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareDecametre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareDecametre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareDecametre">http://dbpedia.org/datatype/squareDecametre</seealso>
    let squareDecametre = Prefixed_Name(dbd, "squareDecametre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareDecimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareDecimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareDecimetre">http://dbpedia.org/datatype/squareDecimetre</seealso>
    let squareDecimetre = Prefixed_Name(dbd, "squareDecimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareFoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareFoot"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareFoot">http://dbpedia.org/datatype/squareFoot</seealso>
    let squareFoot = Prefixed_Name(dbd, "squareFoot") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareHectometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareHectometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareHectometre">http://dbpedia.org/datatype/squareHectometre</seealso>
    let squareHectometre = Prefixed_Name(dbd, "squareHectometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareInch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareInch"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareInch">http://dbpedia.org/datatype/squareInch</seealso>
    let squareInch = Prefixed_Name(dbd, "squareInch") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareKilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareKilometre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareKilometre">http://dbpedia.org/datatype/squareKilometre</seealso>
    let squareKilometre = Prefixed_Name(dbd, "squareKilometre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareMetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareMetre">http://dbpedia.org/datatype/squareMetre</seealso>
    let squareMetre = Prefixed_Name(dbd, "squareMetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareMile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareMile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareMile">http://dbpedia.org/datatype/squareMile</seealso>
    let squareMile = Prefixed_Name(dbd, "squareMile") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareMillimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareMillimetre"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareMillimetre">http://dbpedia.org/datatype/squareMillimetre</seealso>
    let squareMillimetre = Prefixed_Name(dbd, "squareMillimetre") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareNauticalMile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareNauticalMile"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareNauticalMile">http://dbpedia.org/datatype/squareNauticalMile</seealso>
    let squareNauticalMile = Prefixed_Name(dbd, "squareNauticalMile") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/squareYard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"squareYard"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/squareYard">http://dbpedia.org/datatype/squareYard</seealso>
    let squareYard = Prefixed_Name(dbd, "squareYard") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/sriLankanRupee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"sriLankanRupee"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/sriLankanRupee">http://dbpedia.org/datatype/sriLankanRupee</seealso>
    let sriLankanRupee = Prefixed_Name(dbd, "sriLankanRupee") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/standardAtmosphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"standardAtmosphere"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/standardAtmosphere">http://dbpedia.org/datatype/standardAtmosphere</seealso>
    let standardAtmosphere = Prefixed_Name(dbd, "standardAtmosphere") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/stone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"stone"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/stone">http://dbpedia.org/datatype/stone</seealso>
    let stone = Prefixed_Name(dbd, "stone") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/sudanesePound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"sudanesePound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/sudanesePound">http://dbpedia.org/datatype/sudanesePound</seealso>
    let sudanesePound = Prefixed_Name(dbd, "sudanesePound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/surinamDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"surinamDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/surinamDollar">http://dbpedia.org/datatype/surinamDollar</seealso>
    let surinamDollar = Prefixed_Name(dbd, "surinamDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/swaziLilangeni</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"swaziLilangeni"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/swaziLilangeni">http://dbpedia.org/datatype/swaziLilangeni</seealso>
    let swaziLilangeni = Prefixed_Name(dbd, "swaziLilangeni") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/swedishKrona</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"swedishKrona"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/swedishKrona">http://dbpedia.org/datatype/swedishKrona</seealso>
    let swedishKrona = Prefixed_Name(dbd, "swedishKrona") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/swissFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"swissFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/swissFranc">http://dbpedia.org/datatype/swissFranc</seealso>
    let swissFranc = Prefixed_Name(dbd, "swissFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/syrianPound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"syrianPound"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/syrianPound">http://dbpedia.org/datatype/syrianPound</seealso>
    let syrianPound = Prefixed_Name(dbd, "syrianPound") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/tajikistaniSomoni</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tajikistaniSomoni"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tajikistaniSomoni">http://dbpedia.org/datatype/tajikistaniSomoni</seealso>
    let tajikistaniSomoni = Prefixed_Name(dbd, "tajikistaniSomoni") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/tanzanianShilling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tanzanianShilling"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tanzanianShilling">http://dbpedia.org/datatype/tanzanianShilling</seealso>
    let tanzanianShilling = Prefixed_Name(dbd, "tanzanianShilling") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/terabyte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"terabyte"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/terabyte">http://dbpedia.org/datatype/terabyte</seealso>
    let terabyte = Prefixed_Name(dbd, "terabyte") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/terahertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"terahertz"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/terahertz">http://dbpedia.org/datatype/terahertz</seealso>
    let terahertz = Prefixed_Name(dbd, "terahertz") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/terawattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"terawattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/terawattHour">http://dbpedia.org/datatype/terawattHour</seealso>
    let terawattHour = Prefixed_Name(dbd, "terawattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/thaiBaht</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"thaiBaht"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/thaiBaht">http://dbpedia.org/datatype/thaiBaht</seealso>
    let thaiBaht = Prefixed_Name(dbd, "thaiBaht") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/tonganPaanga</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tonganPaanga"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tonganPaanga">http://dbpedia.org/datatype/tonganPaanga</seealso>
    let tonganPaanga = Prefixed_Name(dbd, "tonganPaanga") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/tonne</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tonne"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tonne">http://dbpedia.org/datatype/tonne</seealso>
    let tonne = Prefixed_Name(dbd, "tonne") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/tonneForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tonneForce"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tonneForce">http://dbpedia.org/datatype/tonneForce</seealso>
    let tonneForce = Prefixed_Name(dbd, "tonneForce") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/trinidadAndTobagoDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"trinidadAndTobagoDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/trinidadAndTobagoDollar">http://dbpedia.org/datatype/trinidadAndTobagoDollar</seealso>
    let trinidadAndTobagoDollar =
        Prefixed_Name(dbd, "trinidadAndTobagoDollar") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/tunisianDinar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"tunisianDinar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/tunisianDinar">http://dbpedia.org/datatype/tunisianDinar</seealso>
    let tunisianDinar = Prefixed_Name(dbd, "tunisianDinar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/turkishLira</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"turkishLira"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/turkishLira">http://dbpedia.org/datatype/turkishLira</seealso>
    let turkishLira = Prefixed_Name(dbd, "turkishLira") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/turkmenistaniManat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"turkmenistaniManat"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/turkmenistaniManat">http://dbpedia.org/datatype/turkmenistaniManat</seealso>
    let turkmenistaniManat = Prefixed_Name(dbd, "turkmenistaniManat") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ugandaShilling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ugandaShilling"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ugandaShilling">http://dbpedia.org/datatype/ugandaShilling</seealso>
    let ugandaShilling = Prefixed_Name(dbd, "ugandaShilling") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/ukrainianHryvnia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"ukrainianHryvnia"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/ukrainianHryvnia">http://dbpedia.org/datatype/ukrainianHryvnia</seealso>
    let ukrainianHryvnia = Prefixed_Name(dbd, "ukrainianHryvnia") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/unitedArabEmiratesDirham</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"unitedArabEmiratesDirham"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/unitedArabEmiratesDirham">http://dbpedia.org/datatype/unitedArabEmiratesDirham</seealso>
    let unitedArabEmiratesDirham =
        Prefixed_Name(dbd, "unitedArabEmiratesDirham") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/uruguayanPeso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"uruguayanPeso"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/uruguayanPeso">http://dbpedia.org/datatype/uruguayanPeso</seealso>
    let uruguayanPeso = Prefixed_Name(dbd, "uruguayanPeso") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/usBarrel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"usBarrel"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/usBarrel">http://dbpedia.org/datatype/usBarrel</seealso>
    let usBarrel = Prefixed_Name(dbd, "usBarrel") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/usBarrelOil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"usBarrelOil"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/usBarrelOil">http://dbpedia.org/datatype/usBarrelOil</seealso>
    let usBarrelOil = Prefixed_Name(dbd, "usBarrelOil") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/usDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"usDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/usDollar">http://dbpedia.org/datatype/usDollar</seealso>
    let usDollar = Prefixed_Name(dbd, "usDollar") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/usGallon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"usGallon"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/usGallon">http://dbpedia.org/datatype/usGallon</seealso>
    let usGallon = Prefixed_Name(dbd, "usGallon") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/uzbekistanSom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"uzbekistanSom"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/uzbekistanSom">http://dbpedia.org/datatype/uzbekistanSom</seealso>
    let uzbekistanSom = Prefixed_Name(dbd, "uzbekistanSom") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/valvetrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"valvetrain"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/valvetrain">http://dbpedia.org/datatype/valvetrain</seealso>
    let valvetrain = Prefixed_Name(dbd, "valvetrain") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/vanuatuVatu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"vanuatuVatu"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/vanuatuVatu">http://dbpedia.org/datatype/vanuatuVatu</seealso>
    let vanuatuVatu = Prefixed_Name(dbd, "vanuatuVatu") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/venezuelanBol%C3%ADvar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"venezuelanBolívar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/venezuelanBol%C3%ADvar">http://dbpedia.org/datatype/venezuelanBol%C3%ADvar</seealso>
    let ``venezuelanBol%C3%ADvar`` =
        Prefixed_Name(dbd, "venezuelanBol%C3%ADvar") |> PrefixedName

    /// <summary>
    ///   <para>planet:datatype/volt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"volt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/volt">http://dbpedia.org/datatype/volt</seealso>
    let volt = Prefixed_Name(dbd, "volt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/watt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"watt"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/watt">http://dbpedia.org/datatype/watt</seealso>
    let watt = Prefixed_Name(dbd, "watt") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/wattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"wattHour"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/wattHour">http://dbpedia.org/datatype/wattHour</seealso>
    let wattHour = Prefixed_Name(dbd, "wattHour") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/westAfricanCfaFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"westAfricanCfaFranc"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/westAfricanCfaFranc">http://dbpedia.org/datatype/westAfricanCfaFranc</seealso>
    let westAfricanCfaFranc = Prefixed_Name(dbd, "westAfricanCfaFranc") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/yard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"yard"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/yard">http://dbpedia.org/datatype/yard</seealso>
    let yard = Prefixed_Name(dbd, "yard") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/yemeniRial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"yemeniRial"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/yemeniRial">http://dbpedia.org/datatype/yemeniRial</seealso>
    let yemeniRial = Prefixed_Name(dbd, "yemeniRial") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/zambianKwacha</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"zambianKwacha"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/zambianKwacha">http://dbpedia.org/datatype/zambianKwacha</seealso>
    let zambianKwacha = Prefixed_Name(dbd, "zambianKwacha") |> PrefixedName
    /// <summary>
    ///   <para>planet:datatype/zimbabweanDollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"zimbabweanDollar"</para></remarks>
    /// <seealso href="http://dbpedia.org/datatype/zimbabweanDollar">http://dbpedia.org/datatype/zimbabweanDollar</seealso>
    let zimbabweanDollar = Prefixed_Name(dbd, "zimbabweanDollar") |> PrefixedName

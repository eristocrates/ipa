namespace http.eulersharp.sourceforge.net._2003._03swap.units.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module units =
    let _namespace_iri = Namespace_Iri units |> NamespaceIRI
    /// <summary>
    ///   <para>units:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Specific units are declared in respective ontologies, e.g. leukocytesPerLiter in http://www.agfa.com/w3c/2009/hemogram#.</para>
    ///   <para>Using NASA 'SWEET' ontologies.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#">http://eulersharp.sourceforge.net/2003/03swap/units#</seealso>
    let _prefix_iri = Prefixed_Name(units, "") |> PrefixedName
    /// <summary>
    ///   <para>units:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unit</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#Unit">http://eulersharp.sourceforge.net/2003/03swap/units#Unit</seealso>
    let Unit = Prefixed_Name(units, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>units:atto</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#atto">http://eulersharp.sourceforge.net/2003/03swap/units#atto</seealso>
    let atto = Prefixed_Name(units, "atto") |> PrefixedName
    /// <summary>
    ///   <para>units:bit</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#bit">http://eulersharp.sourceforge.net/2003/03swap/units#bit</seealso>
    let bit = Prefixed_Name(units, "bit") |> PrefixedName
    /// <summary>
    ///   <para>units:byte</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#byte">http://eulersharp.sourceforge.net/2003/03swap/units#byte</seealso>
    let byte = Prefixed_Name(units, "byte") |> PrefixedName
    /// <summary>
    ///   <para>units:centiliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>centiliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#centiliter">http://eulersharp.sourceforge.net/2003/03swap/units#centiliter</seealso>
    let centiliter = Prefixed_Name(units, "centiliter") |> PrefixedName
    /// <summary>
    ///   <para>units:liter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#liter">http://eulersharp.sourceforge.net/2003/03swap/units#liter</seealso>
    let liter = Prefixed_Name(units, "liter") |> PrefixedName
    /// <summary>
    ///   <para>units:centimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>centimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#centimeter">http://eulersharp.sourceforge.net/2003/03swap/units#centimeter</seealso>
    let centimeter = Prefixed_Name(units, "centimeter") |> PrefixedName
    /// <summary>
    ///   <para>units:centimeterCubed</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///
    /// labels<para>cubic centimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#centimeterCubed">http://eulersharp.sourceforge.net/2003/03swap/units#centimeterCubed</seealso>
    let centimeterCubed = Prefixed_Name(units, "centimeterCubed") |> PrefixedName

    /// <summary>
    ///   <para>units:centimeterPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>centimeter per second</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#centimeterPerSecond">http://eulersharp.sourceforge.net/2003/03swap/units#centimeterPerSecond</seealso>
    let centimeterPerSecond =
        Prefixed_Name(units, "centimeterPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>units:century</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#century">http://eulersharp.sourceforge.net/2003/03swap/units#century</seealso>
    let century = Prefixed_Name(units, "century") |> PrefixedName
    /// <summary>
    ///   <para>units:cubicMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>cubic meter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#cubicMeter">http://eulersharp.sourceforge.net/2003/03swap/units#cubicMeter</seealso>
    let cubicMeter = Prefixed_Name(units, "cubicMeter") |> PrefixedName

    /// <summary>
    ///   <para>units:cubicMeterPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>cubic meter per second</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#cubicMeterPerSecond">http://eulersharp.sourceforge.net/2003/03swap/units#cubicMeterPerSecond</seealso>
    let cubicMeterPerSecond =
        Prefixed_Name(units, "cubicMeterPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>units:hertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>hertz</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#hertz">http://eulersharp.sourceforge.net/2003/03swap/units#hertz</seealso>
    let hertz = Prefixed_Name(units, "hertz") |> PrefixedName
    /// <summary>
    ///   <para>units:day</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#day">http://eulersharp.sourceforge.net/2003/03swap/units#day</seealso>
    let day = Prefixed_Name(units, "day") |> PrefixedName
    /// <summary>
    ///   <para>units:second</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>second</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#second">http://eulersharp.sourceforge.net/2003/03swap/units#second</seealso>
    let second = Prefixed_Name(units, "second") |> PrefixedName
    /// <summary>
    ///   <para>units:decade</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#decade">http://eulersharp.sourceforge.net/2003/03swap/units#decade</seealso>
    let decade = Prefixed_Name(units, "decade") |> PrefixedName
    /// <summary>
    ///   <para>units:deci</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#deci">http://eulersharp.sourceforge.net/2003/03swap/units#deci</seealso>
    let deci = Prefixed_Name(units, "deci") |> PrefixedName
    /// <summary>
    ///   <para>units:deciliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>deciliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#deciliter">http://eulersharp.sourceforge.net/2003/03swap/units#deciliter</seealso>
    let deciliter = Prefixed_Name(units, "deciliter") |> PrefixedName
    /// <summary>
    ///   <para>units:decimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>decimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#decimeter">http://eulersharp.sourceforge.net/2003/03swap/units#decimeter</seealso>
    let decimeter = Prefixed_Name(units, "decimeter") |> PrefixedName
    /// <summary>
    ///   <para>units:meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>meter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#meter">http://eulersharp.sourceforge.net/2003/03swap/units#meter</seealso>
    let meter = Prefixed_Name(units, "meter") |> PrefixedName
    /// <summary>
    ///   <para>units:decimeterCubed</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///
    /// labels<para>cubic decimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#decimeterCubed">http://eulersharp.sourceforge.net/2003/03swap/units#decimeterCubed</seealso>
    let decimeterCubed = Prefixed_Name(units, "decimeterCubed") |> PrefixedName
    /// <summary>
    ///   <para>units:degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>degree Celsius</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#degreeC">http://eulersharp.sourceforge.net/2003/03swap/units#degreeC</seealso>
    let degreeC = Prefixed_Name(units, "degreeC") |> PrefixedName
    /// <summary>
    ///   <para>units:degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>degree Fahrenheit</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#degreeF">http://eulersharp.sourceforge.net/2003/03swap/units#degreeF</seealso>
    let degreeF = Prefixed_Name(units, "degreeF") |> PrefixedName
    /// <summary>
    ///   <para>units:femto</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#femto">http://eulersharp.sourceforge.net/2003/03swap/units#femto</seealso>
    let femto = Prefixed_Name(units, "femto") |> PrefixedName
    /// <summary>
    ///   <para>units:femtoliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>femtoliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#femtoliter">http://eulersharp.sourceforge.net/2003/03swap/units#femtoliter</seealso>
    let femtoliter = Prefixed_Name(units, "femtoliter") |> PrefixedName
    /// <summary>
    ///   <para>units:gigaByte</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#gigaByte">http://eulersharp.sourceforge.net/2003/03swap/units#gigaByte</seealso>
    let gigaByte = Prefixed_Name(units, "gigaByte") |> PrefixedName
    /// <summary>
    ///   <para>units:gram</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>gram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#gram">http://eulersharp.sourceforge.net/2003/03swap/units#gram</seealso>
    let gram = Prefixed_Name(units, "gram") |> PrefixedName
    /// <summary>
    ///   <para>units:kilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>kilogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#kilogram">http://eulersharp.sourceforge.net/2003/03swap/units#kilogram</seealso>
    let kilogram = Prefixed_Name(units, "kilogram") |> PrefixedName
    /// <summary>
    ///   <para>units:gramPerDeciliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>gram per deciliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#gramPerDeciliter">http://eulersharp.sourceforge.net/2003/03swap/units#gramPerDeciliter</seealso>
    let gramPerDeciliter = Prefixed_Name(units, "gramPerDeciliter") |> PrefixedName
    /// <summary>
    ///   <para>units:perDeciliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///
    /// labels<para>per deciliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perDeciliter">http://eulersharp.sourceforge.net/2003/03swap/units#perDeciliter</seealso>
    let perDeciliter = Prefixed_Name(units, "perDeciliter") |> PrefixedName
    /// <summary>
    ///   <para>units:gramPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>gram per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#gramPerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#gramPerLiter</seealso>
    let gramPerLiter = Prefixed_Name(units, "gramPerLiter") |> PrefixedName
    /// <summary>
    ///   <para>units:perLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perLiter">http://eulersharp.sourceforge.net/2003/03swap/units#perLiter</seealso>
    let perLiter = Prefixed_Name(units, "perLiter") |> PrefixedName
    /// <summary>
    ///   <para>units:hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>hour</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#hour">http://eulersharp.sourceforge.net/2003/03swap/units#hour</seealso>
    let hour = Prefixed_Name(units, "hour") |> PrefixedName

    /// <summary>
    ///   <para>units:internationalUnitsPerMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#ComplexUnit&gt;</para>
    ///
    /// labels<para>international units per milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#internationalUnitsPerMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#internationalUnitsPerMilliliter</seealso>
    let internationalUnitsPerMilliliter =
        Prefixed_Name(units, "internationalUnitsPerMilliliter") |> PrefixedName

    /// <summary>
    ///   <para>units:kelvin</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>kelvin</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#kelvin">http://eulersharp.sourceforge.net/2003/03swap/units#kelvin</seealso>
    let kelvin = Prefixed_Name(units, "kelvin") |> PrefixedName
    /// <summary>
    ///   <para>units:kiloByte</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#kiloByte">http://eulersharp.sourceforge.net/2003/03swap/units#kiloByte</seealso>
    let kiloByte = Prefixed_Name(units, "kiloByte") |> PrefixedName

    /// <summary>
    ///   <para>units:kilogramPerMeterSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>kilogram per square meter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#kilogramPerMeterSquare">http://eulersharp.sourceforge.net/2003/03swap/units#kilogramPerMeterSquare</seealso>
    let kilogramPerMeterSquare =
        Prefixed_Name(units, "kilogramPerMeterSquare") |> PrefixedName

    /// <summary>
    ///   <para>units:megaByte</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#megaByte">http://eulersharp.sourceforge.net/2003/03swap/units#megaByte</seealso>
    let megaByte = Prefixed_Name(units, "megaByte") |> PrefixedName
    /// <summary>
    ///   <para>units:meterPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>meter per second</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#meterPerSecond">http://eulersharp.sourceforge.net/2003/03swap/units#meterPerSecond</seealso>
    let meterPerSecond = Prefixed_Name(units, "meterPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>units:microgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>microgram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#microgram">http://eulersharp.sourceforge.net/2003/03swap/units#microgram</seealso>
    let microgram = Prefixed_Name(units, "microgram") |> PrefixedName

    /// <summary>
    ///   <para>units:microgramPerKilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>microgram per kilogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerKilogram">http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerKilogram</seealso>
    let microgramPerKilogram =
        Prefixed_Name(units, "microgramPerKilogram") |> PrefixedName

    /// <summary>
    ///   <para>units:microgramPerKilogramPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerKilogramPerMinute">http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerKilogramPerMinute</seealso>
    let microgramPerKilogramPerMinute =
        Prefixed_Name(units, "microgramPerKilogramPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>units:perKilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>per kilogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perKilogram">http://eulersharp.sourceforge.net/2003/03swap/units#perKilogram</seealso>
    let perKilogram = Prefixed_Name(units, "perKilogram") |> PrefixedName
    /// <summary>
    ///   <para>units:perMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///   <para>E.g. unit for the frequency of respiration cycle, heart pumping cycle.</para>
    /// labels<para>per minute</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perMinute">http://eulersharp.sourceforge.net/2003/03swap/units#perMinute</seealso>
    let perMinute = Prefixed_Name(units, "perMinute") |> PrefixedName

    /// <summary>
    ///   <para>units:microgramPerMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>microgram per milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerMilliliter</seealso>
    let microgramPerMilliliter =
        Prefixed_Name(units, "microgramPerMilliliter") |> PrefixedName

    /// <summary>
    ///   <para>units:perMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>per milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#perMilliliter</seealso>
    let perMilliliter = Prefixed_Name(units, "perMilliliter") |> PrefixedName
    /// <summary>
    ///   <para>units:microgramPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>microgram per minute</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerMinute">http://eulersharp.sourceforge.net/2003/03swap/units#microgramPerMinute</seealso>
    let microgramPerMinute = Prefixed_Name(units, "microgramPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>units:micrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>micrometer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#micrometer">http://eulersharp.sourceforge.net/2003/03swap/units#micrometer</seealso>
    let micrometer = Prefixed_Name(units, "micrometer") |> PrefixedName
    /// <summary>
    ///   <para>units:micromole</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>micromole</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#micromole">http://eulersharp.sourceforge.net/2003/03swap/units#micromole</seealso>
    let micromole = Prefixed_Name(units, "micromole") |> PrefixedName
    /// <summary>
    ///   <para>units:mole</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>mole</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#mole">http://eulersharp.sourceforge.net/2003/03swap/units#mole</seealso>
    let mole = Prefixed_Name(units, "mole") |> PrefixedName
    /// <summary>
    ///   <para>units:micromolePerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>micromole per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#micromolePerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#micromolePerLiter</seealso>
    let micromolePerLiter = Prefixed_Name(units, "micromolePerLiter") |> PrefixedName

    /// <summary>
    ///   <para>units:milliInternationalUnitsPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#ComplexUnit&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>milli-international units per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milliInternationalUnitsPerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#milliInternationalUnitsPerLiter</seealso>
    let milliInternationalUnitsPerLiter =
        Prefixed_Name(units, "milliInternationalUnitsPerLiter") |> PrefixedName

    /// <summary>
    ///   <para>units:milligram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>milligram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligram">http://eulersharp.sourceforge.net/2003/03swap/units#milligram</seealso>
    let milligram = Prefixed_Name(units, "milligram") |> PrefixedName

    /// <summary>
    ///   <para>units:milligramPerDeciliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>milligram per deciliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerDeciliter">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerDeciliter</seealso>
    let milligramPerDeciliter =
        Prefixed_Name(units, "milligramPerDeciliter") |> PrefixedName

    /// <summary>
    ///   <para>units:milligramPerGram</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>milligram per gram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerGram">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerGram</seealso>
    let milligramPerGram = Prefixed_Name(units, "milligramPerGram") |> PrefixedName
    /// <summary>
    ///   <para>units:perGram</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>per gram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perGram">http://eulersharp.sourceforge.net/2003/03swap/units#perGram</seealso>
    let perGram = Prefixed_Name(units, "perGram") |> PrefixedName
    /// <summary>
    ///   <para>units:milligramPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>milligram per hour</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerHour">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerHour</seealso>
    let milligramPerHour = Prefixed_Name(units, "milligramPerHour") |> PrefixedName
    /// <summary>
    ///   <para>units:perHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///
    /// labels<para>per hour</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perHour">http://eulersharp.sourceforge.net/2003/03swap/units#perHour</seealso>
    let perHour = Prefixed_Name(units, "perHour") |> PrefixedName

    /// <summary>
    ///   <para>units:milligramPerKilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>milligram per kilogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerKilogram">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerKilogram</seealso>
    let milligramPerKilogram =
        Prefixed_Name(units, "milligramPerKilogram") |> PrefixedName

    /// <summary>
    ///   <para>units:milligramPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerLiter</seealso>
    let milligramPerLiter = Prefixed_Name(units, "milligramPerLiter") |> PrefixedName

    /// <summary>
    ///   <para>units:milligramPerMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#milligramPerMilliliter</seealso>
    let milligramPerMilliliter =
        Prefixed_Name(units, "milligramPerMilliliter") |> PrefixedName

    /// <summary>
    ///   <para>units:milliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milliliter">http://eulersharp.sourceforge.net/2003/03swap/units#milliliter</seealso>
    let milliliter = Prefixed_Name(units, "milliliter") |> PrefixedName

    /// <summary>
    ///   <para>units:milliliterPerKilogramPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>milliliter per kilogram per hour</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milliliterPerKilogramPerHour">http://eulersharp.sourceforge.net/2003/03swap/units#milliliterPerKilogramPerHour</seealso>
    let milliliterPerKilogramPerHour =
        Prefixed_Name(units, "milliliterPerKilogramPerHour") |> PrefixedName

    /// <summary>
    ///   <para>units:milliliterPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>milliliter per minute</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#milliliterPerMinute">http://eulersharp.sourceforge.net/2003/03swap/units#milliliterPerMinute</seealso>
    let milliliterPerMinute =
        Prefixed_Name(units, "milliliterPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>units:millimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>millimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#millimeter">http://eulersharp.sourceforge.net/2003/03swap/units#millimeter</seealso>
    let millimeter = Prefixed_Name(units, "millimeter") |> PrefixedName
    /// <summary>
    ///   <para>units:millimeterCubed</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>cubic millimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#millimeterCubed">http://eulersharp.sourceforge.net/2003/03swap/units#millimeterCubed</seealso>
    let millimeterCubed = Prefixed_Name(units, "millimeterCubed") |> PrefixedName
    /// <summary>
    ///   <para>units:millimole</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>millimole</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#millimole">http://eulersharp.sourceforge.net/2003/03swap/units#millimole</seealso>
    let millimole = Prefixed_Name(units, "millimole") |> PrefixedName
    /// <summary>
    ///   <para>units:millimolePerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>millimole per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#millimolePerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#millimolePerLiter</seealso>
    let millimolePerLiter = Prefixed_Name(units, "millimolePerLiter") |> PrefixedName
    /// <summary>
    ///   <para>units:millisecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>rdfs:Class</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///
    /// labels<para>millisecond</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#millisecond">http://eulersharp.sourceforge.net/2003/03swap/units#millisecond</seealso>
    let millisecond = Prefixed_Name(units, "millisecond") |> PrefixedName
    /// <summary>
    ///   <para>units:minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>minute</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#minute">http://eulersharp.sourceforge.net/2003/03swap/units#minute</seealso>
    let minute = Prefixed_Name(units, "minute") |> PrefixedName
    /// <summary>
    ///   <para>units:mmHg</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///   <para>760 mmHg corresponds with 101.325 kPa.</para>
    /// labels<para>millimeter of mercury</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#mmHg">http://eulersharp.sourceforge.net/2003/03swap/units#mmHg</seealso>
    let mmHg = Prefixed_Name(units, "mmHg") |> PrefixedName
    /// <summary>
    ///   <para>units:pascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>pascal</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#pascal">http://eulersharp.sourceforge.net/2003/03swap/units#pascal</seealso>
    let pascal = Prefixed_Name(units, "pascal") |> PrefixedName
    /// <summary>
    ///   <para>units:month</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>month</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#month">http://eulersharp.sourceforge.net/2003/03swap/units#month</seealso>
    let month = Prefixed_Name(units, "month") |> PrefixedName
    /// <summary>
    ///   <para>units:nanogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>nanogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#nanogram">http://eulersharp.sourceforge.net/2003/03swap/units#nanogram</seealso>
    let nanogram = Prefixed_Name(units, "nanogram") |> PrefixedName

    /// <summary>
    ///   <para>units:nanogramPerMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///
    /// labels<para>nanogram per milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#nanogramPerMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#nanogramPerMilliliter</seealso>
    let nanogramPerMilliliter =
        Prefixed_Name(units, "nanogramPerMilliliter") |> PrefixedName

    /// <summary>
    ///   <para>units:nanometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>nanometer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#nanometer">http://eulersharp.sourceforge.net/2003/03swap/units#nanometer</seealso>
    let nanometer = Prefixed_Name(units, "nanometer") |> PrefixedName
    /// <summary>
    ///   <para>units:ohm</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>ohm</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#ohm">http://eulersharp.sourceforge.net/2003/03swap/units#ohm</seealso>
    let ohm = Prefixed_Name(units, "ohm") |> PrefixedName
    /// <summary>
    ///   <para>units:perDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///   <para>E.g. unit for the frequency of clinical drug administration.</para>
    /// labels<para>per day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perDay">http://eulersharp.sourceforge.net/2003/03swap/units#perDay</seealso>
    let perDay = Prefixed_Name(units, "perDay") |> PrefixedName
    /// <summary>
    ///   <para>units:perMillimeterCubed</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>per cubic millimeter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perMillimeterCubed">http://eulersharp.sourceforge.net/2003/03swap/units#perMillimeterCubed</seealso>
    let perMillimeterCubed = Prefixed_Name(units, "perMillimeterCubed") |> PrefixedName
    /// <summary>
    ///   <para>units:perTeaspoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///
    /// labels<para>per teaspoon</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perTeaspoon">http://eulersharp.sourceforge.net/2003/03swap/units#perTeaspoon</seealso>
    let perTeaspoon = Prefixed_Name(units, "perTeaspoon") |> PrefixedName
    /// <summary>
    ///   <para>units:teaspoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>Equals 5ml, e.g. of a clinical drug administration form sirup.</para>
    /// labels<para>teaspoon</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#teaspoon">http://eulersharp.sourceforge.net/2003/03swap/units#teaspoon</seealso>
    let teaspoon = Prefixed_Name(units, "teaspoon") |> PrefixedName
    /// <summary>
    ///   <para>units:perYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByRaisingToPower&gt;</para>
    ///   <para>units:Unit</para>
    ///   <para>E.g. unit for the frequency of clinical vaccination.</para>
    /// labels<para>per year</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#perYear">http://eulersharp.sourceforge.net/2003/03swap/units#perYear</seealso>
    let perYear = Prefixed_Name(units, "perYear") |> PrefixedName
    /// <summary>
    ///   <para>units:percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>units:Unit</para>
    ///   <para>Replaced by &lt;http://eulersharp.sourceforge.net/2003/03swap/quantities#percent&gt;.</para>
    /// labels<para>percent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#percent">http://eulersharp.sourceforge.net/2003/03swap/units#percent</seealso>
    let percent = Prefixed_Name(units, "percent") |> PrefixedName
    /// <summary>
    ///   <para>units:pico</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#pico">http://eulersharp.sourceforge.net/2003/03swap/units#pico</seealso>
    let pico = Prefixed_Name(units, "pico") |> PrefixedName
    /// <summary>
    ///   <para>units:picogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>picogram</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#picogram">http://eulersharp.sourceforge.net/2003/03swap/units#picogram</seealso>
    let picogram = Prefixed_Name(units, "picogram") |> PrefixedName
    /// <summary>
    ///   <para>units:picometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#picometer">http://eulersharp.sourceforge.net/2003/03swap/units#picometer</seealso>
    let picometer = Prefixed_Name(units, "picometer") |> PrefixedName
    /// <summary>
    ///   <para>units:squareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>square meter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#squareMeter">http://eulersharp.sourceforge.net/2003/03swap/units#squareMeter</seealso>
    let squareMeter = Prefixed_Name(units, "squareMeter") |> PrefixedName
    /// <summary>
    ///   <para>units:tablespoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    ///   <para>Equals 15ml, e.g. of a clinical drug administration form sirup.</para>
    /// labels<para>tablespoon</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#tablespoon">http://eulersharp.sourceforge.net/2003/03swap/units#tablespoon</seealso>
    let tablespoon = Prefixed_Name(units, "tablespoon") |> PrefixedName
    /// <summary>
    ///   <para>units:teraByte</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDerivedByScaling&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#teraByte">http://eulersharp.sourceforge.net/2003/03swap/units#teraByte</seealso>
    let teraByte = Prefixed_Name(units, "teraByte") |> PrefixedName
    /// <summary>
    ///   <para>units:unitsPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#UnitDefinedByProduct&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>units per liter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#unitsPerLiter">http://eulersharp.sourceforge.net/2003/03swap/units#unitsPerLiter</seealso>
    let unitsPerLiter = Prefixed_Name(units, "unitsPerLiter") |> PrefixedName
    /// <summary>
    ///   <para>units:unitsPerMilliliter</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#ComplexUnit&gt;</para>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>units per milliliter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#unitsPerMilliliter">http://eulersharp.sourceforge.net/2003/03swap/units#unitsPerMilliliter</seealso>
    let unitsPerMilliliter = Prefixed_Name(units, "unitsPerMilliliter") |> PrefixedName
    /// <summary>
    ///   <para>units:week</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>week</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#week">http://eulersharp.sourceforge.net/2003/03swap/units#week</seealso>
    let week = Prefixed_Name(units, "week") |> PrefixedName
    /// <summary>
    ///   <para>units:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>units:Unit</para>
    ///
    /// labels<para>year</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#year">http://eulersharp.sourceforge.net/2003/03swap/units#year</seealso>
    let year = Prefixed_Name(units, "year") |> PrefixedName
    /// <summary>
    ///   <para>units:yocto</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#yocto">http://eulersharp.sourceforge.net/2003/03swap/units#yocto</seealso>
    let yocto = Prefixed_Name(units, "yocto") |> PrefixedName
    /// <summary>
    ///   <para>units:zepto</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#Prefix&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/units#zepto">http://eulersharp.sourceforge.net/2003/03swap/units#zepto</seealso>
    let zepto = Prefixed_Name(units, "zepto") |> PrefixedName

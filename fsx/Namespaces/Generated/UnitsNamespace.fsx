#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module units =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/units#" "units"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : unit</para>
    ///   <para>skos:definition : Reference mesurement with value 1 in which a quantity measurement is expressed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#Unit">units:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    let atto = _prefixId.prefix "atto"
    let bit = _prefixId.prefix "bit"
    let byte = _prefixId.prefix "byte"
    let centiliter = _prefixId.prefix "centiliter"
    let centimeter = _prefixId.prefix "centimeter"
    let centimeterCubed = _prefixId.prefix "centimeterCubed"
    let centimeterPerSecond = _prefixId.prefix "centimeterPerSecond"
    let century = _prefixId.prefix "century"
    let cubicMeter = _prefixId.prefix "cubicMeter"
    let cubicMeterPerSecond = _prefixId.prefix "cubicMeterPerSecond"
    let day = _prefixId.prefix "day"
    let decade = _prefixId.prefix "decade"
    let deci = _prefixId.prefix "deci"
    let deciliter = _prefixId.prefix "deciliter"
    let decimeter = _prefixId.prefix "decimeter"
    let decimeterCubed = _prefixId.prefix "decimeterCubed"
    let degreeC = _prefixId.prefix "degreeC"
    let degreeF = _prefixId.prefix "degreeF"
    let femto = _prefixId.prefix "femto"
    let femtoliter = _prefixId.prefix "femtoliter"
    let gigaByte = _prefixId.prefix "gigaByte"
    let gram = _prefixId.prefix "gram"
    let gramPerDeciliter = _prefixId.prefix "gramPerDeciliter"
    let gramPerLiter = _prefixId.prefix "gramPerLiter"
    let hertz = _prefixId.prefix "hertz"
    let hour = _prefixId.prefix "hour"

    let internationalUnitsPerMilliliter = _prefixId.prefix "internationalUnitsPerMilliliter"

    let kelvin = _prefixId.prefix "kelvin"
    let kiloByte = _prefixId.prefix "kiloByte"
    let kilogram = _prefixId.prefix "kilogram"
    let kilogramPerMeterSquare = _prefixId.prefix "kilogramPerMeterSquare"
    let liter = _prefixId.prefix "liter"
    let megaByte = _prefixId.prefix "megaByte"
    let meter = _prefixId.prefix "meter"
    let meterPerSecond = _prefixId.prefix "meterPerSecond"
    /// <summary>
    ///   <para>rdfs:label : microgram</para>
    ///   <para>screla:hasSymbol : µg^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#microgram">units:microgram</a>
    /// </summary>
    let microgram = _prefixId.prefix "microgram"
    let microgramPerKilogram = _prefixId.prefix "microgramPerKilogram"
    let microgramPerKilogramPerMinute = _prefixId.prefix "microgramPerKilogramPerMinute"
    let microgramPerMilliliter = _prefixId.prefix "microgramPerMilliliter"
    let microgramPerMinute = _prefixId.prefix "microgramPerMinute"
    let micrometer = _prefixId.prefix "micrometer"
    let micromole = _prefixId.prefix "micromole"
    let micromolePerLiter = _prefixId.prefix "micromolePerLiter"

    let milliInternationalUnitsPerLiter = _prefixId.prefix "milliInternationalUnitsPerLiter"

    /// <summary>
    ///   <para>rdfs:label : milligram</para>
    ///   <para>screla:hasSymbol : mg^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#milligram">units:milligram</a>
    /// </summary>
    let milligram = _prefixId.prefix "milligram"
    let milligramPerDeciliter = _prefixId.prefix "milligramPerDeciliter"
    let milligramPerGram = _prefixId.prefix "milligramPerGram"
    let milligramPerHour = _prefixId.prefix "milligramPerHour"
    let milligramPerKilogram = _prefixId.prefix "milligramPerKilogram"
    let milligramPerLiter = _prefixId.prefix "milligramPerLiter"
    let milligramPerMilliliter = _prefixId.prefix "milligramPerMilliliter"
    let milliliter = _prefixId.prefix "milliliter"
    let milliliterPerKilogramPerHour = _prefixId.prefix "milliliterPerKilogramPerHour"
    let milliliterPerMinute = _prefixId.prefix "milliliterPerMinute"
    let millimeter = _prefixId.prefix "millimeter"
    let millimeterCubed = _prefixId.prefix "millimeterCubed"
    let millimole = _prefixId.prefix "millimole"
    let millimolePerLiter = _prefixId.prefix "millimolePerLiter"
    /// <summary>
    ///   <para>rdfs:label : millisecond</para>
    ///   <para>screla:hasSymbol : ms^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#millisecond">units:millisecond</a>
    /// </summary>
    let millisecond = _prefixId.prefix "millisecond"
    let minute = _prefixId.prefix "minute"
    let mmHg = _prefixId.prefix "mmHg"
    let mole = _prefixId.prefix "mole"
    let month = _prefixId.prefix "month"
    /// <summary>
    ///   <para>rdfs:label : nanogram</para>
    ///   <para>screla:hasSymbol : ng^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#nanogram">units:nanogram</a>
    /// </summary>
    let nanogram = _prefixId.prefix "nanogram"
    let nanogramPerMilliliter = _prefixId.prefix "nanogramPerMilliliter"
    let nanometer = _prefixId.prefix "nanometer"
    let ohm = _prefixId.prefix "ohm"
    let pascal = _prefixId.prefix "pascal"
    let perDay = _prefixId.prefix "perDay"
    let perDeciliter = _prefixId.prefix "perDeciliter"
    let perGram = _prefixId.prefix "perGram"
    let perHour = _prefixId.prefix "perHour"
    let perKilogram = _prefixId.prefix "perKilogram"
    let perLiter = _prefixId.prefix "perLiter"
    let perMilliliter = _prefixId.prefix "perMilliliter"
    let perMillimeterCubed = _prefixId.prefix "perMillimeterCubed"
    let perMinute = _prefixId.prefix "perMinute"
    let perTeaspoon = _prefixId.prefix "perTeaspoon"
    let perYear = _prefixId.prefix "perYear"
    let percent = _prefixId.prefix "percent"
    let pico = _prefixId.prefix "pico"
    /// <summary>
    ///   <para>rdfs:label : picogram</para>
    ///   <para>screla:hasSymbol : pg^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/units#picogram">units:picogram</a>
    /// </summary>
    let picogram = _prefixId.prefix "picogram"
    let picometer = _prefixId.prefix "picometer"
    let second = _prefixId.prefix "second"
    let squareMeter = _prefixId.prefix "squareMeter"
    let tablespoon = _prefixId.prefix "tablespoon"
    let teaspoon = _prefixId.prefix "teaspoon"
    let teraByte = _prefixId.prefix "teraByte"
    let unitsPerLiter = _prefixId.prefix "unitsPerLiter"
    let unitsPerMilliliter = _prefixId.prefix "unitsPerMilliliter"
    let week = _prefixId.prefix "week"
    let year = _prefixId.prefix "year"
    let yocto = _prefixId.prefix "yocto"
    let zepto = _prefixId.prefix "zepto"

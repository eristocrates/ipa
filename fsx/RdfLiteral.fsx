// Look into Hydra/ Nancy
// https://github.com/NancyFx/Nancy/wiki/Introduction#the-super-duper-happy-path
#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Threading.Tasks
open System.Globalization

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa
#r "Iana.dll"
open Iana
#r "IanaScheme.dll"



let true_ = RdfLiteral.autotyped true
let false_ = RdfLiteral.autotyped false

module Binary =

    let base64 (bytes: Byte array) =
        let valueString = Convert.ToBase64String(bytes)

        PrefixId.xsd.prefix "base64Binary"
        |> PrefixedIri
        |> RdfLiteral.datatyped valueString

    let hex (bytes: Byte array) =
        let valueString = Convert.ToHexString(bytes)

        PrefixId.xsd.prefix "hexBinary"
        |> PrefixedIri
        |> RdfLiteral.datatyped valueString


module Temporal =
    module duration =
        let timeDuration (timespan: TimeSpan) =
            let valueString = Xml.XmlConvert.ToString(timespan)

            PrefixId.xsd.prefix "duration"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString

        let dayTimeDuration (timespan: TimeSpan) =
            let valueString = Xml.XmlConvert.ToString(timespan)

            PrefixId.xdt.prefix "dayTimeDuration"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


        let yearMonthDuration (years: int) (months: int) =
            let totalMonths = years * 12 + months

            let valueString =
                if totalMonths = 0 then
                    "P0M"
                else
                    let absoluteMonths = abs totalMonths
                    let yearsPart = absoluteMonths / 12
                    let monthsPart = absoluteMonths % 12
                    let sign = if totalMonths < 0 then "-" else ""

                    let yearText = if yearsPart = 0 then "" else $"{yearsPart}Y"

                    let monthText = if monthsPart = 0 then "" else $"{monthsPart}M"

                    $"{sign}P{yearText}{monthText}"

            PrefixId.xdt.prefix "yearMonthDuration"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


    module date =

        let only (date: DateOnly) =
            let valueString = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "date" |> PrefixedIri |> RdfLiteral.datatyped valueString

        let fromDatetime (datetime: DateTime) =
            let valueString = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "date" |> PrefixedIri |> RdfLiteral.datatyped valueString

        let time (datetime: DateTime) =
            let valueString = datetime.ToString("o", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "dateTime"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString

        let timeStamp (datetimeOffset: DateTimeOffset) =
            let valueString = datetimeOffset.ToString("o", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "dateTimeStamp"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString



    module time =

        let only (time: TimeOnly) =
            let valueString = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "time" |> PrefixedIri |> RdfLiteral.datatyped valueString

        let fromDatetime (datetime: DateTime) =
            let valueString = datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "time" |> PrefixedIri |> RdfLiteral.datatyped valueString

    module period =

        let day (datetime: DateTime) =
            let valueString = $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.xsd.prefix "gDay" |> PrefixedIri |> RdfLiteral.datatyped valueString


        let month (datetime: DateTime) =
            let valueString = $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.xsd.prefix "gMonth" |> PrefixedIri |> RdfLiteral.datatyped valueString


        let monthDay (datetime: DateTime) =
            let valueString = $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.xsd.prefix "gMonthDay"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


        let year (datetime: DateTime) =
            let valueString = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

            PrefixId.xsd.prefix "gYear" |> PrefixedIri |> RdfLiteral.datatyped valueString


        let yearMonth (datetime: DateTime) =
            let valueString = $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.xsd.prefix "gYearMonth"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString
        let generalDay (day: int) =
            // TODO find a strongly typed parse instead of validation
            // test <@ day >= 1 && day <= 99 @>
            let valueString = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.owlTime.prefix "generalDay"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


        let generalMonth (month: int) =
            // TODO find a strongly typed parse instead of validation
            // test <@ month >= 1 && month <= 20 @>
            let valueString = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

            PrefixId.owlTime.prefix "generalMonth"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


        let generalYear (year: int) =
            let valueString = year.ToString("0000", CultureInfo.InvariantCulture)

            PrefixId.owlTime.prefix "generalYear"
            |> PrefixedIri
            |> RdfLiteral.datatyped valueString


module Numeric =

    let private bigintValueString (value: bigint) =
        value.ToString(CultureInfo.InvariantCulture)

    let integer (value: bigint) =
        PrefixId.xsd.prefix "integer"
        |> PrefixedIri
        |> RdfLiteral.datatyped (bigintValueString value)

    let negativeInteger (value: bigint) =
        // TODO find a strongly typed parse instead of validation
        // test <@ value < 0I @>

        PrefixId.xsd.prefix "negativeInteger"
        |> PrefixedIri
        |> RdfLiteral.datatyped (bigintValueString value)

    let nonNegativeInteger (value: bigint) =
        // TODO find a strongly typed parse instead of validation
        // test <@ value >= 0I @>

        PrefixId.xsd.prefix "nonNegativeInteger"
        |> PrefixedIri
        |> RdfLiteral.datatyped (bigintValueString value)

    let nonPositiveInteger (value: bigint) =
        // TODO find a strongly typed parse instead of validation
        // test <@ value <= 0I @>

        PrefixId.xsd.prefix "nonPositiveInteger"
        |> PrefixedIri
        |> RdfLiteral.datatyped (bigintValueString value)

    let positiveInteger (value: bigint) =
        // TODO find a strongly typed parse instead of validation
        // test <@ value > 0I @>

        PrefixId.xsd.prefix "positiveInteger"
        |> PrefixedIri
        |> RdfLiteral.datatyped (bigintValueString value)

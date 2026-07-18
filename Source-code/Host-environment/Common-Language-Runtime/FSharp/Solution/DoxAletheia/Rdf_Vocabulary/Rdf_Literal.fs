module DoxAletheia.Rdf_Literal

open Rdf_Vocabulary
open System
open System.Globalization
open System.Xml

open Swensen.Unquote.Assertions

open https.www.w3.org._2003._05.xpath_datatypes.hash
open https.www.w3.org._2001.XMLSchema_instance.hash
open https.www.w3.org.XML._1998.namespace_.hash
open http.www.w3.org._2001.XMLSchema.hash
open http.www.w3.org._2006.time.hash

let simple lexical_form = SimpleLiteral lexical_form

let en lexical_form =
    LanguageString(lexical_form, Language_Tag.en)

let en_us lexical_form =
    RegionString(lexical_form, Language_Tag.en, Region_Subtag.US)

let datatyped lexical_form datatype =
    DatatypedLiteral(lexical_form, datatype)

let autotyped<'ValueType> (value: 'ValueType) =
    let value_string, datatype_iri =
        let invariant_string =
            if box value = null then
                String.Empty
            else
                Convert.ToString(value, CultureInfo.InvariantCulture)

        match box value with
        | :? Boolean as value -> (if value then "true" else "false"), xsd.boolean
        | :? (Byte array) as value -> Convert.ToBase64String(value), xsd.base64Binary
        | :? Byte as value -> invariant_string, xsd.unsignedByte
        | :? DateOnly as value -> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), xsd.date
        | :? DateTime as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTime
        | :? DateTimeOffset as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTimeStamp
        | :? Decimal as value -> invariant_string, xsd.decimal
        | :? Double as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.double
        | :? Int16 as value -> invariant_string, xsd.short
        | :? Int32 as value -> invariant_string, xsd.int
        | :? Int64 as value -> invariant_string, xsd.long
        | :? SByte as value -> invariant_string, xsd.byte
        | :? Single as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.float
        | :? TimeOnly as value -> value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture), xsd.time
        | :? TimeSpan as value -> Xml.XmlConvert.ToString(value), xsd.duration
        | :? UInt16 as value -> invariant_string, xsd.unsignedShort
        | :? UInt32 as value -> invariant_string, xsd.unsignedInt
        | :? UInt64 as value -> invariant_string, xsd.unsignedLong
        | :? Uri as value -> value.AbsoluteUri, xsd.anyURI
        | :? XmlQualifiedName as value -> value.ToString(), xsd.QName
        | :? Guid as value -> value.ToString(), xsd.ID
        | null -> "true", xsi.nil
        | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType
        | value -> invariant_string, xsd.string

    datatyped value_string datatype_iri

let true_ = autotyped true
let false_ = autotyped false

module Binary =

    let base64 (bytes: Byte array) =
        let value_string = Convert.ToBase64String(bytes)

        datatyped value_string xsd.base64Binary

    let hex (bytes: Byte array) =
        let value_string = Convert.ToHexString(bytes)

        datatyped value_string xsd.hexBinary


module Temporal =
    module duration =
        let timeDuration (timespan: TimeSpan) =
            let value_string = Xml.XmlConvert.ToString(timespan)

            datatyped value_string xsd.duration

        let dayTimeDuration (timespan: TimeSpan) =
            let value_string = Xml.XmlConvert.ToString(timespan)

            datatyped value_string xdt.dayTimeDuration


        let yearMonthDuration (years: int) (months: int) =
            let total_months = years * 12 + months

            let value_string =
                if total_months = 0 then
                    "P0M"
                else
                    let absolute_months = abs total_months
                    let years_part = absolute_months / 12
                    let months_part = absolute_months % 12
                    let sign = if total_months < 0 then "-" else ""

                    let year_text =
                        if years_part = 0 then
                            ""
                        else
                            $"{years_part}Y"

                    let month_text =
                        if months_part = 0 then
                            ""
                        else
                            $"{months_part}M"

                    $"{sign}P{year_text}{month_text}"

            datatyped value_string xdt.yearMonthDuration


    module date =

        let only (date: DateOnly) =
            let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            datatyped value_string xsd.date

        let from_datetime (datetime: DateTime) =
            let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            datatyped value_string xsd.date

        let time (datetime: DateTime) =
            let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

            datatyped value_string xsd.dateTime

        let timeStamp (datetime_offset: DateTimeOffset) =
            let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

            datatyped value_string xsd.dateTimeStamp



    module time =

        let only (time: TimeOnly) =
            let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            datatyped value_string xsd.time

        let from_datetime (datetime: DateTime) =
            let value_string =
                datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            datatyped value_string xsd.time

    module period =

        let day (datetime: DateTime) =
            let value_string =
                $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string xsd.gDay


        let month (datetime: DateTime) =
            let value_string =
                $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string xsd.gMonth


        let monthDay (datetime: DateTime) =
            let value_string =
                $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string xsd.gMonthDay


        let year (datetime: DateTime) =
            let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

            datatyped value_string xsd.gYear


        let yearMonth (datetime: DateTime) =
            let value_string =
                $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string xsd.gYearMonth

        let generalDay (day: int) =
            test <@ day >= 1 && day <= 99 @>
            let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string owl_time.generalDay


        let generalMonth (month: int) =
            test <@ month >= 1 && month <= 20 @>
            let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

            datatyped value_string owl_time.generalMonth


        let generalYear (year: int) =
            let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

            datatyped value_string owl_time.generalYear


module Numeric =

    let private bigint_value_string (value: bigint) =
        value.ToString(CultureInfo.InvariantCulture)

    let integer (value: bigint) =
        datatyped (bigint_value_string value) xsd.integer

    let negativeInteger (value: bigint) =
        test <@ value < 0I @>
        datatyped (bigint_value_string value) xsd.negativeInteger

    let nonNegativeInteger (value: bigint) =
        test <@ value >= 0I @>
        datatyped (bigint_value_string value) xsd.nonNegativeInteger

    let nonPositiveInteger (value: bigint) =
        test <@ value <= 0I @>
        datatyped (bigint_value_string value) xsd.nonPositiveInteger

    let positiveInteger (value: bigint) =
        test <@ value > 0I @>
        datatyped (bigint_value_string value) xsd.positiveInteger

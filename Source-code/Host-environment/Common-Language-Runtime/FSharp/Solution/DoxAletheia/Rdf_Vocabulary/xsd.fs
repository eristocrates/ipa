namespace http.www.w3.org._2001.XMLSchema.hash

open DoxAletheia

module xsd =
    let _namespace_name = "http://www.w3.org/2001/XMLSchema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    ///     `ENTITIES` represents the `ENTITIES` attribute type from [XML]. The _value
    ///     space_ of `ENTITIES` is the set of finite, non-zero-length sequences of
    ///     `ENTITY` values that have been declared as unparsed entities in a document
    ///     type definition. The _lexical space_ of `ENTITIES` is the set of
    ///     space-separated lists of tokens, of which each token is in the _lexical
    ///     space_ of `ENTITY`. The _item type_ of `ENTITIES` is `ENTITY`. `ENTITIES` is
    ///     derived from `anySimpleType` in two steps: an anonymous list type is
    ///     defined, whose _item type_ is `ENTITY`; this is the _base type_ of `ENTITIES`,
    ///     which restricts its value space to lists with at least one item.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#ENTITIES"></see></summary>
    let ENTITIES = _prefix "ENTITIES"
    /// <summary>
    ///
    ///     The definition of `anySimpleType` is a special _restriction_ of `anyType`. The
    ///     _lexical space_ of a`nySimpleType` is the set of all sequences of Unicode
    ///     characters, and its _value space_ includes all _atomic values_ and all
    ///     finite-length lists of zero or more _atomic values_.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#anySimpleType"></see></summary>
    let anySimpleType = _prefix "anySimpleType"
    /// <summary>
    ///
    ///      `ENTITY` represents the `ENTITY` attribute type from [XML]. The _value space_
    ///      of `ENTITY` is the set of all strings that match the `NCName` production in
    ///      [Namespaces in XML] and have been declared as an unparsed entity in a
    ///      document type definition. The _lexical space_ of ENTITY is the set of all
    ///      strings that match the NCName production in [Namespaces in XML]. The
    ///      _base type_ of ENTITY is NCName.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#ENTITY"></see></summary>
    let ENTITY = _prefix "ENTITY"
    /// <summary>
    ///
    ///      `NCName` represents XML "non-colonized" Names. The _value space_ of `NCName`
    ///      is the set of all strings which match the `NCName` production of
    ///      [Namespaces in XML]. The _lexical space_ of `NCName` is the set of all
    ///      strings which match the `NCName` production of [Namespaces in XML]. The
    ///      _base type_ of `NCName` is `Name`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#NCName"></see></summary>
    let NCName = _prefix "NCName"
    /// <summary>
    ///
    ///      `ID` represents the `ID` attribute type from [XML]. The _value space_ of `ID` is
    ///      the set of all strings that match the `NCName` production in [Namespaces
    ///      in XML]. The _lexical space_ of `ID` is the set of all strings that match
    ///      the `NCName` production in [Namespaces in XML]. The _base type_ of `ID` is
    ///      `NCName`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#ID"></see></summary>
    let ID = _prefix "ID"
    /// <summary>
    ///
    ///     `IDREF` represents the `IDREF` attribute type from [XML]. The _value space_ of
    ///     `IDREF` is the set of all strings that match the `NCName` production in
    ///     [Namespaces in XML]. The _lexical space_ of `IDREF` is the set of strings
    ///     that match the `NCName` production in [Namespaces in XML]. The _base type_
    ///     of `IDREF` is `NCName`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#IDREF"></see></summary>
    let IDREF = _prefix "IDREF"
    /// <summary>
    ///
    ///     `IDREFS` represents the `IDREFS` attribute type from [XML]. The _value space_
    ///     of `IDREFS` is the set of finite, non-zero-length sequences of `IDREF`s. The
    ///     _lexical space_ of `IDREFS` is the set of space-separated lists of tokens, of
    ///     which each token is in the _lexical space_ of `IDREF`. The _item type_ of
    ///     `IDREFS` is `IDREF`. `IDREFS` is derived from `anySimpleType` in two steps: an
    ///     anonymous list type is defined, whose _item type_ is `IDREF`; this is the
    ///     _base type_ of `IDREFS`, which restricts its value space to lists with at
    ///     least one item.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#IDREFS"></see></summary>
    let IDREFS = _prefix "IDREFS"
    /// <summary>
    ///
    ///     `Name` represents XML Names. The _value space_ of `Name` is the set of all
    ///     strings which match the `Name` production of [XML]. The _lexical space_ of
    ///     `Name` is the set of all strings which match the `Name` production of [XML].
    ///     The _base type_ of `Name` is `token`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    ///
    ///      `NMTOKEN` represents the `NMTOKEN` attribute type from [XML]. The _value
    ///      space_ of `NMTOKEN` is the set of tokens that match the `Nmtoken` production
    ///      in [XML]. The _lexical space_ of `NMTOKEN` is the set of strings that
    ///      match the Nmtoken production in [XML]. The _base type_ of `NMTOKEN` is
    ///      `token`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#NMTOKEN"></see></summary>
    let NMTOKEN = _prefix "NMTOKEN"
    /// <summary>
    ///
    ///      `token` represents tokenized strings. The _value space_ of `token` is the set
    ///      of strings that do not contain the carriage return (`#xD`), line feed (`#xA`)
    ///      nor tab (`#x9`) characters, that have no leading or trailing spaces (`#x20`)
    ///      and that have no internal sequences of two or more spaces. The _lexical
    ///      space_ of `token` is the set of strings that do not contain the carriage
    ///      return (`#xD`), line feed (`#xA`) nor tab (`#x9`) characters, that have no
    ///      leading or trailing spaces (`#x20`) and that have no internal sequences of
    ///      two or more spaces. The _base type_ of `token` is `normalizedString`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#token"></see></summary>
    let token = _prefix "token"
    /// <summary>
    ///
    ///     `NMTOKENS` represents the `NMTOKENS` attribute type from [XML]. The _value
    ///     space_ of `NMTOKENS` is the set of finite, non-zero-length sequences of
    ///     `NMTOKEN`s. The _lexical space_ of `NMTOKENS` is the set of space-separated
    ///     lists of tokens, of which each token is in the _lexical space_ of `NMTOKEN`.
    ///     The _item type_ of `NMTOKENS` is `NMTOKEN`. `NMTOKENS` is derived from
    ///     `anySimpleType` in two steps: an anonymous list type is defined, whose
    ///     _item type_ is `NMTOKEN`; this is the _base type_ of `NMTOKENS`, which
    ///     restricts its value space to lists with at least one item.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#NMTOKENS"></see></summary>
    let NMTOKENS = _prefix "NMTOKENS"
    /// <summary>
    ///
    ///     `NOTATION` represents the `NOTATION` attribute type from [XML]. The _value
    ///     space_ of `NOTATION` is the set of `QNames` of notations declared in the
    ///     current schema. The _lexical space_ of `NOTATION` is the set of all names of
    ///     notations declared in the current schema (in the form of `QNames`).
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#NOTATION"></see></summary>
    let NOTATION = _prefix "NOTATION"
    /// <summary>
    ///
    ///     `anyAtomicType` is a special _restriction_ of `anySimpleType`. The _value_ and
    ///     _lexical spaces_ of `anyAtomicType` are the unions of the _value_ and
    ///     _lexical spaces_ of all the _primitive_ datatypes, and `anyAtomicType` is
    ///     their _base type_.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#anyAtomicType"></see></summary>
    let anyAtomicType = _prefix "anyAtomicType"
    /// <summary>
    ///
    ///     `QName` represents XML qualified names. The _value space_ of `QName` is the set
    ///     of tuples `{namespace name, local part}`, where namespace name is an `anyURI`
    ///     and local part is an `NCName`. The _lexical space_ of `QName` is the set of
    ///     strings that match the `QName` production of [Namespaces in XML].
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#QName"></see></summary>
    let QName = _prefix "QName"
    /// <summary>
    ///
    ///     The root of the [XML Schema 1.1] datatype heirarchy.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#anyType"></see></summary>
    let anyType = _prefix "anyType"
    /// <summary>
    ///
    ///     `anyURI` represents an Internationalized Resource Identifier Reference
    ///     (IRI). An `anyURI` value can be absolute or relative, and may have an
    ///     optional fragment identifier (i.e., it may be an IRI Reference). This
    ///     type should be used when the value fulfills the role of an IRI, as
    ///     defined in [RFC 3987] or its successor(s) in the IETF Standards Track.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#anyURI"></see></summary>
    let anyURI = _prefix "anyURI"
    /// <summary>
    ///
    ///     `base64Binary` represents arbitrary Base64-encoded binary data. For
    ///     `base64Binary` data the entire binary stream is encoded using the `Base64`
    ///     Encoding defined in [RFC 3548], which is derived from the encoding
    ///     described in [RFC 2045].
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#base64Binary"></see></summary>
    let base64Binary = _prefix "base64Binary"
    /// <summary>
    ///
    ///     `boolean` represents the values of two-valued logic.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#boolean"></see></summary>
    let boolean = _prefix "boolean"
    /// <summary>
    ///
    ///     `byte` is _derived_ from `short` by setting the value of `maxInclusive` to be
    ///     `127` and `minInclusive` to be `-128`. The _base type_ of `byte` is `short`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#byte"></see></summary>
    let byte = _prefix "byte"
    /// <summary>
    ///
    ///     `short` is _derived_ from `int` by setting the value of `maxInclusive` to be
    ///     `32767` and `minInclusive` to be `-32768`. The _base type_ of `short` is `int`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#short"></see></summary>
    let short = _prefix "short"
    /// <summary>
    ///
    ///     `date` represents top-open intervals of exactly one day in length on the
    ///     timelines of `dateTime`, beginning on the beginning moment of each day, up to
    ///     but not including the beginning moment of the next day). For non-timezoned
    ///     values, the top-open intervals disjointly cover the non-timezoned timeline,
    ///     one per day. For timezoned values, the intervals begin at every minute and
    ///     therefore overlap.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    ///
    ///     `dateTime` represents instants of time, optionally marked with a particular
    ///     time zone offset. Values representing the same instant but having different
    ///     time zone offsets are equal but not identical.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///
    ///     The `dateTimeStamp` datatype is _derived_ from `dateTime` by giving the value
    ///     required to its `explicitTimezone` facet. The result is that all values of
    ///     `dateTimeStamp` are required to have explicit time zone offsets and the
    ///     datatype is totally ordered.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#dateTimeStamp"></see></summary>
    let dateTimeStamp = _prefix "dateTimeStamp"
    /// <summary>
    ///
    ///      `dayTimeDuration` is a datatype _derived_ from `duration` by restricting its
    ///      _lexical representations_ to instances of `dayTimeDurationLexicalRep`. The
    ///      _value space_ of `dayTimeDuration` is therefore that of `duration` restricted
    ///      to those whose `months` property is `0`. This results in a `duration` datatype
    ///      which is totally ordered.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#dayTimeDuration"></see></summary>
    let dayTimeDuration = _prefix "dayTimeDuration"
    /// <summary>
    ///
    ///     `duration` is a datatype that represents durations of time. The concept of
    ///     duration being captured is drawn from those of [ISO 8601], specifically
    ///     durations without fixed endpoints. For example, "15 days" (whose most
    ///     common lexical representation in duration is `"'P15D'"`) is a duration value;
    ///     "15 days beginning 12 July 1995" and "15 days ending 12 July 1995" are not
    ///     duration values. duration can provide addition and subtraction operations
    ///     between duration values and between duration/dateTime value pairs, and can
    ///     be the result of subtracting dateTime values. However, only addition to
    ///     `dateTime` is required for XML Schema processing and is defined in the
    ///     function `dateTimePlusDuration`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///
    ///     `decimal` represents a subset of the real numbers, which can be represented
    ///     by decimal numerals. The _value space_ of decimal is the set of numbers
    ///     that can be obtained by dividing an integer by a non-negative power of ten,
    ///     i.e., expressible as `i / 10n` where `i` and `n` are integers and `n ≥ 0`.
    ///     Precision is not reflected in this value space; the number `2.0` is not
    ///     distinct from the number `2.00`. The order relation on `decimal` is the order
    ///     relation on real numbers, restricted to this subset.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#decimal"></see></summary>
    let decimal = _prefix "decimal"
    /// <summary>
    ///
    ///     The `double` datatype is patterned after the IEEE double-precision 64-bit
    ///     floating point datatype [IEEE 754-2008]. Each floating point datatype has a
    ///     value space that is a subset of the rational numbers. Floating point
    ///     numbers are often used to approximate arbitrary real numbers.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#double"></see></summary>
    let double = _prefix "double"
    /// <summary>
    ///
    ///     The `float` datatype is patterned after the IEEE single-precision 32-bit
    ///     floating point datatype [IEEE 754-2008]. Its value space is a subset of the
    ///     rational numbers. Floating point numbers are often used to approximate
    ///     arbitrary real numbers.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#float"></see></summary>
    let float = _prefix "float"
    /// <summary>
    ///
    ///     `gDay` represents whole days within an arbitrary month—days that recur at the
    ///     same point in each (Gregorian) month. This datatype is used to represent a
    ///     specific day of the month. To indicate, for example, that an employee gets
    ///     a paycheck on the 15th of each month. (Obviously, days beyond 28 cannot
    ///     occur in all months; they are nonetheless permitted, up to 31.)
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#gDay"></see></summary>
    let gDay = _prefix "gDay"
    /// <summary>
    ///
    ///     `gMonth` represents whole (Gregorian) months within an arbitrary year—months
    ///     that recur at the same point in each year. It might be used, for example,
    ///     to say what month annual Thanksgiving celebrations fall in different
    ///     countries (`--11` in the United States, `--10` in Canada, and possibly other
    ///     months in other countries).
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#gMonth"></see></summary>
    let gMonth = _prefix "gMonth"
    /// <summary>
    ///
    ///     `gMonthDay` represents whole calendar days that recur at the same point in
    ///     each calendar year, or that occur in some arbitrary calendar year.
    ///     (Obviously, days beyond 28 cannot occur in all Februaries; 29 is
    ///     nonetheless permitted.)
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#gMonthDay"></see></summary>
    let gMonthDay = _prefix "gMonthDay"
    /// <summary>
    ///
    ///     `gYear` represents Gregorian calendar years.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#gYear"></see></summary>
    let gYear = _prefix "gYear"
    /// <summary>
    ///
    ///     `gYearMonth` represents specific whole Gregorian months in specific Gregorian years.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#gYearMonth"></see></summary>
    let gYearMonth = _prefix "gYearMonth"
    /// <summary>
    ///
    ///     hexBinary` represents arbitrary hex-encoded binary data.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#hexBinary"></see></summary>
    let hexBinary = _prefix "hexBinary"
    /// <summary>
    ///
    ///       `int` is _derived_ from `long` by setting the value of `maxInclusive` to be
    ///       `2147483647` and `minInclusive` to be `-2147483648`. The _base type_ of `int`
    ///       is `long`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#int"></see></summary>
    let int = _prefix "int"
    /// <summary>
    ///
    ///      `long` is _derived_ from `integer` by setting the value of `maxInclusive` to
    ///      be `9223372036854775807` and `minInclusive` to be `-9223372036854775808`. The
    ///      _base type_ of `long` is `integer`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#long"></see></summary>
    let long = _prefix "long"
    /// <summary>
    ///
    ///      `integer` is _derived_ from `decimal` by fixing the value of `fractionDigits`
    ///      to be `0` and disallowing the trailing decimal point. This results in the
    ///      standard mathematical concept of the integer numbers. The _value space_ of
    ///      `integer` is the infinite set `{...,-2,-1,0,1,2,...}`. The _base type_ of
    ///      `integer` is `decimal`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#integer"></see></summary>
    let integer = _prefix "integer"
    /// <summary>
    ///
    ///     `language` represents formal natural language identifiers, as defined by [BCP
    ///     47] (currently represented by [RFC 4646] and [RFC 4647]) or its
    ///     successor(s). The _value space_ and _lexical space_ of `language` are the set
    ///     of all strings that conform to the pattern `[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    ///
    ///      `negativeInteger` is _derived_ from `nonPositiveInteger` by setting the value
    ///      of `maxInclusive` to be `-1`. This results in the standard mathematical
    ///      concept of the negative integers. The _value space_ of `negativeInteger` is
    ///      the infinite set `{...,-2,-1}`. The _base type_ of `negativeInteger` is
    ///      `nonPositiveInteger`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#negativeInteger"></see></summary>
    let negativeInteger = _prefix "negativeInteger"
    /// <summary>
    ///
    ///     `nonPositiveInteger` is _derived_ from `integer` by setting the value of
    ///     `maxInclusive` to be `0`. This results in the standard mathematical concept
    ///     of the non-positive integers. The _value space_ of `nonPositiveInteger` is
    ///     the infinite set `{...,-2,-1,0}`. The _base type_ of `nonPositiveInteger` is
    ///     `integer`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#nonPositiveInteger"></see></summary>
    let nonPositiveInteger = _prefix "nonPositiveInteger"
    /// <summary>
    ///
    ///      `nonNegativeInteger` is _derived_ from `integer` by setting the value of
    ///      `minInclusive` to be `0`. This results in the standard mathematical concept
    ///      of the non-negative integers. The _value space_ of `nonNegativeInteger` is
    ///      the infinite set `{0,1,2,...}`. The _base type_ of `nonNegativeInteger` is
    ///      `integer`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#nonNegativeInteger"></see></summary>
    let nonNegativeInteger = _prefix "nonNegativeInteger"
    /// <summary>
    ///
    ///     `normalizedString` represents white space normalized strings. The _value
    ///     space_ of `normalizedString` is the set of strings that do not contain the
    ///     carriage return (`#xD`), line feed (`#xA`) nor tab (`#x9`) characters. The
    ///     _lexical space_ of `normalizedString` is the set of strings that do not
    ///     contain the carriage return (`#xD`), line feed (`#xA`) nor tab (`#x9`)
    ///     characters. The _base type_ of `normalizedString` is `string`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#normalizedString"></see></summary>
    let normalizedString = _prefix "normalizedString"
    /// <summary>
    ///
    ///     The `string` datatype represents character strings in XML.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#string"></see></summary>
    let string = _prefix "string"
    /// <summary>
    ///
    ///      `positiveInteger` is _derived_ from `nonNegativeInteger` by setting the value
    ///      of `minInclusive` to be `1`. This results in the standard mathematical
    ///      concept of the positive integer numbers. The _value space_ of
    ///      `positiveInteger` is the infinite set `{1,2,...}`. The _base type_ of
    ///      `positiveInteger` is `nonNegativeInteger`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#positiveInteger"></see></summary>
    let positiveInteger = _prefix "positiveInteger"
    /// <summary>
    ///
    ///     `time` represents instants of time that recur at the same point in each
    ///     calendar day, or that occur in some arbitrary calendar day.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    ///
    ///       `unsignedByte` is _derived_ from `unsignedShort` by setting the value of
    ///       `maxInclusive` to be `255`. The _base type_ of `unsignedByte` is
    ///       `unsignedShort`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#unsignedByte"></see></summary>
    let unsignedByte = _prefix "unsignedByte"
    /// <summary>
    ///
    ///        `unsignedShort` is _derived_ from `unsignedInt` by setting the value of
    ///        `maxInclusive` to be `65535`. The _base type_ of `unsignedShort` is
    ///        `unsignedInt`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#unsignedShort"></see></summary>
    let unsignedShort = _prefix "unsignedShort"
    /// <summary>
    ///
    ///     `unsignedInt` is _derived_ from `unsignedLong` by setting the value of
    ///     `maxInclusive` to be `4294967295`. The _base type_ of `unsignedInt` is
    ///     `unsignedLong`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#unsignedInt"></see></summary>
    let unsignedInt = _prefix "unsignedInt"
    /// <summary>
    ///
    ///      `unsignedLong` is _derived_ from `nonNegativeInteger` by setting the value of
    ///      `maxInclusive` to be `18446744073709551615`. The _base type_ of `unsignedLong`
    ///      is `nonNegativeInteger`.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#unsignedLong"></see></summary>
    let unsignedLong = _prefix "unsignedLong"
    /// <summary>
    ///
    ///      `yearMonthDuration` is a datatype _derived_ from `duration` by restricting its
    ///      _lexical representations_ to instances of `yearMonthDurationLexicalRep`. The
    ///      _value space_ of `yearMonthDuration` is therefore that of `duration`
    ///      restricted to those whose `seconds` property is `0`. This results in a
    ///      `duration` datatype which is totally ordered.
    ///
    /// <see href="http://www.w3.org/2001/XMLSchema#yearMonthDuration"></see></summary>
    let yearMonthDuration = _prefix "yearMonthDuration"

namespace Xsd.Namespace

module xsd =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://www.w3.org/2001/XMLSchema#"
            None
            (Some "xsd")
            None

    let schema = { _prefixID with _localName = "schema" }
    let string = { _prefixID with _localName = "string" }
    let boolean = { _prefixID with _localName = "boolean" }
    let decimal = { _prefixID with _localName = "decimal" }
    let integer = { _prefixID with _localName = "integer" }
    let double = { _prefixID with _localName = "double" }
    let float = { _prefixID with _localName = "float" }
    let date = { _prefixID with _localName = "date" }
    let time = { _prefixID with _localName = "time" }
    let dateTime = { _prefixID with _localName = "dateTime" }
    let dateTimeStamp = { _prefixID with _localName = "dateTimeStamp" }
    let gYear = { _prefixID with _localName = "gYear" }
    let gMonth = { _prefixID with _localName = "gMonth" }
    let gDay = { _prefixID with _localName = "gDay" }
    let gYearMonth = { _prefixID with _localName = "gYearMonth" }
    let gMonthDay = { _prefixID with _localName = "gMonthDay" }
    let duration = { _prefixID with _localName = "duration" }
    let yearMonthDuration = { _prefixID with _localName = "yearMonthDuration" }
    let dayTimeDuration = { _prefixID with _localName = "dayTimeDuration" }
    let byte = { _prefixID with _localName = "byte" }
    let short = { _prefixID with _localName = "short" }
    let int = { _prefixID with _localName = "int" }
    let long = { _prefixID with _localName = "long" }
    let unsignedByte = { _prefixID with _localName = "unsignedByte" }
    let unsignedShort = { _prefixID with _localName = "unsignedShort" }
    let unsignedInt = { _prefixID with _localName = "unsignedInt" }
    let unsignedLong = { _prefixID with _localName = "unsignedLong" }
    let positiveInteger = { _prefixID with _localName = "positiveInteger" }
    let nonNegativeInteger = { _prefixID with _localName = "nonNegativeInteger" }
    let negativeInteger = { _prefixID with _localName = "negativeInteger" }
    let nonPositiveInteger = { _prefixID with _localName = "nonPositiveInteger" }
    let hexBinary = { _prefixID with _localName = "hexBinary" }
    let base64Binary = { _prefixID with _localName = "base64Binary" }
    let anyURI = { _prefixID with _localName = "anyURI" }
    let language = { _prefixID with _localName = "language" }
    let normalizedString = { _prefixID with _localName = "normalizedString" }
    let token = { _prefixID with _localName = "token" }
    let NMTOKEN = { _prefixID with _localName = "NMTOKEN" }
    let Name = { _prefixID with _localName = "Name" }
    let NCName = { _prefixID with _localName = "NCName" }

namespace Json.Namespace

module json =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "urn:json/"
            None
            (Some "json")
            None

    let Grammar = { _prefixID with _localName = "Grammar" }

    let BeginArray = { _prefixID with _localName = "BeginArray" }

    let BeginObject = { _prefixID with _localName = "BeginObject" }

    let EndArray = { _prefixID with _localName = "EndArray" }

    let EndObject = { _prefixID with _localName = "EndObject" }

    let NameSeparator = { _prefixID with _localName = "NameSeparator" }

    let ValueSeparator = { _prefixID with _localName = "ValueSeparator" }

    let DecimalPoint = { _prefixID with _localName = "DecimalPoint" }

    let NonZeroDigit = { _prefixID with _localName = "NonZeroDigit" }

    let E = { _prefixID with _localName = "E" }

    let Exp = { _prefixID with _localName = "Exp" }

    let Frac = { _prefixID with _localName = "Frac" }

    let Int = { _prefixID with _localName = "Int" }

    let Minus = { _prefixID with _localName = "Minus" }

    let Plus = { _prefixID with _localName = "Plus" }

    let Zero = { _prefixID with _localName = "Zero" }

    let Char = { _prefixID with _localName = "Char" }

    let Escape = { _prefixID with _localName = "Escape" }

    let Quotation = { _prefixID with _localName = "Quotation" }

    let Unescaped = { _prefixID with _localName = "Unescaped" }

    let HEXDIG = { _prefixID with _localName = "HEXDIG" }

    let DIGIT = { _prefixID with _localName = "DIGIT" }

    let Text = { _prefixID with _localName = "Text" }

    let Value = { _prefixID with _localName = "Value" }

    let Boolean = { _prefixID with _localName = "Boolean" }

    let False = { _prefixID with _localName = "False" }

    let Null = { _prefixID with _localName = "Null" }

    let True = { _prefixID with _localName = "True" }

    let Object = { _prefixID with _localName = "Object" }

    let Member = { _prefixID with _localName = "Member" }

    let Members = { _prefixID with _localName = "Members" }

    let Array = { _prefixID with _localName = "Array" }

    let Element = { _prefixID with _localName = "Element" }

    let Elements = { _prefixID with _localName = "Elements" }

    let Number = { _prefixID with _localName = "Number" }

    let String = { _prefixID with _localName = "String" }

    let MediaType = { _prefixID with _localName = "MediaType" }

    let Data = { _prefixID with _localName = "Data" }

    let Validation = { _prefixID with _localName = "Validation" }

    let Documentation = { _prefixID with _localName = "Documentation" }

    let HyperlinkNavigation = { _prefixID with _localName = "HyperlinkNavigation" }

    let InteractionControl = { _prefixID with _localName = "InteractionControl" }

    let Specification = { _prefixID with _localName = "Specification" }

    let Reference = { _prefixID with _localName = "Reference" }

    let Dialect = { _prefixID with _localName = "Dialect" }

    let Vocabulary = { _prefixID with _localName = "Vocabulary" }

    let Navigation = { _prefixID with _localName = "Navigation" }

    let Interaction = { _prefixID with _localName = "Interaction" }

    let Document = { _prefixID with _localName = "Document" }

    let Instance = { _prefixID with _localName = "Instance" }

    let Schema = { _prefixID with _localName = "Schema" }

    let Root = { _prefixID with _localName = "Root" }

    let RootSchema = { _prefixID with _localName = "RootSchema" }

    let MetaSchema = { _prefixID with _localName = "MetaSchema" }

    let Keyword = { _prefixID with _localName = "Keyword" }

    let Type = { _prefixID with _localName = "Type" }

    let Property = { _prefixID with _localName = "Property" }

    let Identifier = { _prefixID with _localName = "Identifier" }

    let Assertion = { _prefixID with _localName = "Assertion" }

    let Annotation = { _prefixID with _localName = "Annotation" }

    let Applicator = { _prefixID with _localName = "Applicator" }

    let Reservedlocation = { _prefixID with _localName = "Reservedlocation" }

    let ExtensionKeyword = { _prefixID with _localName = "ExtensionKeyword" }

    let SchemaCoreVocabulary = { _prefixID with _localName = "SchemaCoreVocabulary" }

    let ``$schema`` = { _prefixID with _localName = "$schema" }

    let ``$vocabulary`` = { _prefixID with _localName = "$vocabulary" }

    let ``$id`` = { _prefixID with _localName = "$id" }

    let Fragment = { _prefixID with _localName = "Fragment" }

    let PointerFragment = { _prefixID with _localName = "PointerFragment" }

    let PlainNameFragment = { _prefixID with _localName = "PlainNameFragment" }

    let ``$anchor`` = { _prefixID with _localName = "$anchor" }

    let ``$dynamicAnchor`` = { _prefixID with _localName = "$dynamicAnchor" }

    let ``$ref`` = { _prefixID with _localName = "$ref" }

    let ``$dynamicRef`` = { _prefixID with _localName = "$dynamicRef" }

    let ``type`` = { _prefixID with _localName = "type" }

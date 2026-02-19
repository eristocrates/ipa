namespace Xs.Namespace

module xs =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://www.w3.org/2001/XMLSchema#/"
            None
            (Some "xs")
            None

    let schema = { _prefixID with _localName = "schema" }
    let annotation = { _prefixID with _localName = "annotation" }
    let documentation = { _prefixID with _localName = "documentation" }
    let import = { _prefixID with _localName = "import" }
    let complexType = { _prefixID with _localName = "complexType" }
    let complexContent = { _prefixID with _localName = "complexContent" }
    let restriction = { _prefixID with _localName = "restriction" }
    let anyType = { _prefixID with _localName = "anyType" }
    let anyAttribute = { _prefixID with _localName = "anyAttribute" }
    let extension = { _prefixID with _localName = "extension" }
    let openAttrs = { _prefixID with _localName = "openAttrs" }
    let sequence = { _prefixID with _localName = "sequence" }
    let element = { _prefixID with _localName = "element" }
    let attribute = { _prefixID with _localName = "attribute" }
    let ID = { _prefixID with _localName = "ID" }
    let group = { _prefixID with _localName = "group" }
    let choice = { _prefixID with _localName = "choice" }
    let include_ = { _prefixID with _localName = "include" }
    let redefine = { _prefixID with _localName = "redefine" }
    let ``override`` = { _prefixID with _localName = "override" }
    let redefinable = { _prefixID with _localName = "redefinable" }
    let notation = { _prefixID with _localName = "notation" }
    let simpleType = { _prefixID with _localName = "simpleType" }
    let attributeGroup = { _prefixID with _localName = "attributeGroup" }
    let NMTOKEN = { _prefixID with _localName = "NMTOKEN" }
    let enumeration = { _prefixID with _localName = "enumeration" }
    let derivationControl = { _prefixID with _localName = "derivationControl" }
    let union = { _prefixID with _localName = "union" }
    let token = { _prefixID with _localName = "token" }
    let list = { _prefixID with _localName = "list" }

    let reducedDerivationControl =
        { _prefixID with _localName = "reducedDerivationControl" }

    let typeDerivationControl = { _prefixID with _localName = "typeDerivationControl" }
    let composition = { _prefixID with _localName = "composition" }
    let defaultOpenContent = { _prefixID with _localName = "defaultOpenContent" }
    let schemaTop = { _prefixID with _localName = "schemaTop" }
    let anyURI = { _prefixID with _localName = "anyURI" }
    let fullDerivationSet = { _prefixID with _localName = "fullDerivationSet" }
    let blockSet = { _prefixID with _localName = "blockSet" }
    let formChoice = { _prefixID with _localName = "formChoice" }
    let QName = { _prefixID with _localName = "QName" }
    let xpathDefaultNamespace = { _prefixID with _localName = "xpathDefaultNamespace" }
    let key = { _prefixID with _localName = "key" }
    let selector = { _prefixID with _localName = "selector" }
    let field = { _prefixID with _localName = "field" }
    let unique = { _prefixID with _localName = "unique" }
    let keyref = { _prefixID with _localName = "keyref" }
    let nonNegativeInteger = { _prefixID with _localName = "nonNegativeInteger" }
    let allNNI = { _prefixID with _localName = "allNNI" }
    let NCName = { _prefixID with _localName = "NCName" }
    let groupRef = { _prefixID with _localName = "groupRef" }
    let all = { _prefixID with _localName = "all" }
    let localElement = { _prefixID with _localName = "localElement" }
    let any = { _prefixID with _localName = "any" }
    let annotated = { _prefixID with _localName = "annotated" }
    let localSimpleType = { _prefixID with _localName = "localSimpleType" }
    let defRef = { _prefixID with _localName = "defRef" }
    let string = { _prefixID with _localName = "string" }
    let boolean = { _prefixID with _localName = "boolean" }
    let attributeGroupRef = { _prefixID with _localName = "attributeGroupRef" }
    let wildcard = { _prefixID with _localName = "wildcard" }
    let qnameListA = { _prefixID with _localName = "qnameListA" }
    let assertion = { _prefixID with _localName = "assertion" }
    let simpleContent = { _prefixID with _localName = "simpleContent" }
    let openContent = { _prefixID with _localName = "openContent" }
    let typeDefParticle = { _prefixID with _localName = "typeDefParticle" }
    let attrDecls = { _prefixID with _localName = "attrDecls" }
    let assertions = { _prefixID with _localName = "assertions" }
    let complexTypeModel = { _prefixID with _localName = "complexTypeModel" }
    let derivationSet = { _prefixID with _localName = "derivationSet" }

    let simpleRestrictionModel =
        { _prefixID with _localName = "simpleRestrictionModel" }

    let restrictionType = { _prefixID with _localName = "restrictionType" }

    let complexRestrictionType =
        { _prefixID with _localName = "complexRestrictionType" }

    let extensionType = { _prefixID with _localName = "extensionType" }
    let simpleRestrictionType = { _prefixID with _localName = "simpleRestrictionType" }
    let simpleExtensionType = { _prefixID with _localName = "simpleExtensionType" }
    let topLevelComplexType = { _prefixID with _localName = "topLevelComplexType" }
    let localComplexType = { _prefixID with _localName = "localComplexType" }
    let altType = { _prefixID with _localName = "altType" }
    let identityConstraint = { _prefixID with _localName = "identityConstraint" }
    let occurs = { _prefixID with _localName = "occurs" }
    let topLevelElement = { _prefixID with _localName = "topLevelElement" }
    let particle = { _prefixID with _localName = "particle" }
    let realGroup = { _prefixID with _localName = "realGroup" }
    let allModel = { _prefixID with _localName = "allModel" }
    let simpleExplicitGroup = { _prefixID with _localName = "simpleExplicitGroup" }
    let nestedParticle = { _prefixID with _localName = "nestedParticle" }
    let explicitGroup = { _prefixID with _localName = "explicitGroup" }
    let namedGroup = { _prefixID with _localName = "namedGroup" }
    let namespaceList = { _prefixID with _localName = "namespaceList" }
    let basicNamespaceList = { _prefixID with _localName = "basicNamespaceList" }
    let minLength = { _prefixID with _localName = "minLength" }
    let anyAttrGroup = { _prefixID with _localName = "anyAttrGroup" }
    let qnameList = { _prefixID with _localName = "qnameList" }
    let specialNamespaceList = { _prefixID with _localName = "specialNamespaceList" }
    let topLevelAttribute = { _prefixID with _localName = "topLevelAttribute" }
    let namedAttributeGroup = { _prefixID with _localName = "namedAttributeGroup" }
    let keybase = { _prefixID with _localName = "keybase" }
    let ``public`` = { _prefixID with _localName = "public" }
    let appinfo = { _prefixID with _localName = "appinfo" }
    let simpleDerivation = { _prefixID with _localName = "simpleDerivation" }
    let simpleDerivationSet = { _prefixID with _localName = "simpleDerivationSet" }
    let topLevelSimpleType = { _prefixID with _localName = "topLevelSimpleType" }
    let facet = { _prefixID with _localName = "facet" }
    let integer = { _prefixID with _localName = "integer" }
    let numFacet = { _prefixID with _localName = "numFacet" }
    let positiveInteger = { _prefixID with _localName = "positiveInteger" }
    let noFixedFacet = { _prefixID with _localName = "noFixedFacet" }
    let id = { _prefixID with _localName = "id" }
    let targetNamespace = { _prefixID with _localName = "targetNamespace" }
    let version = { _prefixID with _localName = "version" }
    let finalDefault = { _prefixID with _localName = "finalDefault" }
    let blockDefault = { _prefixID with _localName = "blockDefault" }
    let attributeFormDefault = { _prefixID with _localName = "attributeFormDefault" }
    let elementFormDefault = { _prefixID with _localName = "elementFormDefault" }
    let defaultAttributes = { _prefixID with _localName = "defaultAttributes" }
    let ``type`` = { _prefixID with _localName = "type" }
    let minOccurs = { _prefixID with _localName = "minOccurs" }
    let maxOccurs = { _prefixID with _localName = "maxOccurs" }
    let name = { _prefixID with _localName = "name" }
    let ref = { _prefixID with _localName = "ref" }
    let ``use`` = { _prefixID with _localName = "use" }
    let ``default`` = { _prefixID with _localName = "default" }
    let fixed_ = { _prefixID with _localName = "fixed" }
    let form = { _prefixID with _localName = "form" }
    let inheritable = { _prefixID with _localName = "inheritable" }
    let notQName = { _prefixID with _localName = "notQName" }
    let ``assert`` = { _prefixID with _localName = "assert" }
    let test = { _prefixID with _localName = "test" }
    let mixed = { _prefixID with _localName = "mixed" }
    let ``abstract`` = { _prefixID with _localName = "abstract" }
    let final = { _prefixID with _localName = "final" }
    let block = { _prefixID with _localName = "block" }

    let defaultAttributesApply =
        { _prefixID with _localName = "defaultAttributesApply" }

    let ``base`` = { _prefixID with _localName = "base" }
    let mode = { _prefixID with _localName = "mode" }
    let appliesToEmpty = { _prefixID with _localName = "appliesToEmpty" }
    let alternative = { _prefixID with _localName = "alternative" }
    let substitutionGroup = { _prefixID with _localName = "substitutionGroup" }
    let nillable = { _prefixID with _localName = "nillable" }
    let ``namespace`` = { _prefixID with _localName = "namespace" }
    let notNamespace = { _prefixID with _localName = "notNamespace" }
    let processContents = { _prefixID with _localName = "processContents" }
    let schemaLocation = { _prefixID with _localName = "schemaLocation" }
    let xpath = { _prefixID with _localName = "xpath" }
    let refer = { _prefixID with _localName = "refer" }
    let system = { _prefixID with _localName = "system" }
    let source = { _prefixID with _localName = "source" }
    let XMLSchemaStructures = { _prefixID with _localName = "XMLSchemaStructures" }
    let XML = { _prefixID with _localName = "XML" }
    let itemType = { _prefixID with _localName = "itemType" }
    let memberTypes = { _prefixID with _localName = "memberTypes" }
    let value = { _prefixID with _localName = "value" }
    let minExclusive = { _prefixID with _localName = "minExclusive" }
    let minInclusive = { _prefixID with _localName = "minInclusive" }
    let maxExclusive = { _prefixID with _localName = "maxExclusive" }
    let maxInclusive = { _prefixID with _localName = "maxInclusive" }
    let intFacet = { _prefixID with _localName = "intFacet" }
    let totalDigits = { _prefixID with _localName = "totalDigits" }
    let fractionDigits = { _prefixID with _localName = "fractionDigits" }
    let length = { _prefixID with _localName = "length" }
    let maxLength = { _prefixID with _localName = "maxLength" }
    let whiteSpace = { _prefixID with _localName = "whiteSpace" }
    let pattern = { _prefixID with _localName = "pattern" }
    let explicitTimezone = { _prefixID with _localName = "explicitTimezone" }
    let all_complex_types = { _prefixID with _localName = "all_complex_types" }
    let anySimpleType = { _prefixID with _localName = "anySimpleType" }
    let anyAtomicType = { _prefixID with _localName = "anyAtomicType" }
    let base64Binary = { _prefixID with _localName = "base64Binary" }
    let date = { _prefixID with _localName = "date" }
    let dateTime = { _prefixID with _localName = "dateTime" }
    let dateTimeStamp = { _prefixID with _localName = "dateTimeStamp" }
    let decimal = { _prefixID with _localName = "decimal" }
    let long = { _prefixID with _localName = "long" }
    let int = { _prefixID with _localName = "int" }
    let short = { _prefixID with _localName = "short" }
    let byte = { _prefixID with _localName = "byte" }
    let unsignedLong = { _prefixID with _localName = "unsignedLong" }
    let unsignedInt = { _prefixID with _localName = "unsignedInt" }
    let unsignedShort = { _prefixID with _localName = "unsignedShort" }
    let unsignedByte = { _prefixID with _localName = "unsignedByte" }
    let nonPositiveInteger = { _prefixID with _localName = "nonPositiveInteger" }
    let negativeInteger = { _prefixID with _localName = "negativeInteger" }
    let double = { _prefixID with _localName = "double" }
    let duration = { _prefixID with _localName = "duration" }
    let dayTimeDuration = { _prefixID with _localName = "dayTimeDuration" }
    let yearMonthDuration = { _prefixID with _localName = "yearMonthDuration" }
    let float = { _prefixID with _localName = "float" }
    let gDay = { _prefixID with _localName = "gDay" }
    let gMonth = { _prefixID with _localName = "gMonth" }
    let gMonthDay = { _prefixID with _localName = "gMonthDay" }
    let gYear = { _prefixID with _localName = "gYear" }
    let gYearMonth = { _prefixID with _localName = "gYearMonth" }
    let hexBinary = { _prefixID with _localName = "hexBinary" }
    let NOTATION = { _prefixID with _localName = "NOTATION" }
    let normalizedString = { _prefixID with _localName = "normalizedString" }
    let language = { _prefixID with _localName = "language" }
    let Name = { _prefixID with _localName = "Name" }
    let ENTITY = { _prefixID with _localName = "ENTITY" }
    let IDREF = { _prefixID with _localName = "IDREF" }
    let time = { _prefixID with _localName = "time" }
    let ENTITIES = { _prefixID with _localName = "ENTITIES" }
    let IDREFS = { _prefixID with _localName = "IDREFS" }
    let NMTOKENS = { _prefixID with _localName = "NMTOKENS" }

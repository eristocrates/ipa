namespace Rml.Namespace

module rml =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://w3id.org/rml/"
            (Some @"http://w3id.org/rml/")
            (Some @"rml")
            None

    let AbstractLogicalSource = { _prefixID with _localName = "AbstractLogicalSource" }
    let AssertedTriplesMap = { _prefixID with _localName = "AssertedTriplesMap" }
    let BlankNode = { _prefixID with _localName = "BlankNode" }
    let CSV = { _prefixID with _localName = "CSV" }
    let ChildMap = { _prefixID with _localName = "ChildMap" }
    let Compression = { _prefixID with _localName = "Compression" }

    let CurrentWorkingDirectory =
        { _prefixID with _localName = "CurrentWorkingDirectory" }

    let DatatypeMap = { _prefixID with _localName = "DatatypeMap" }
    let Encoding = { _prefixID with _localName = "Encoding" }
    let ExpressionField = { _prefixID with _localName = "ExpressionField" }
    let ExpressionMap = { _prefixID with _localName = "ExpressionMap" }
    let Field = { _prefixID with _localName = "Field" }
    let ForeignKeyAnnotation = { _prefixID with _localName = "ForeignKeyAnnotation" }
    let FunctionExecution = { _prefixID with _localName = "FunctionExecution" }
    let FunctionMap = { _prefixID with _localName = "FunctionMap" }
    let GatherMap = { _prefixID with _localName = "GatherMap" }
    let GraphMap = { _prefixID with _localName = "GraphMap" }
    let IRI = { _prefixID with _localName = "IRI" }
    let IRISafeAnnotation = { _prefixID with _localName = "IRISafeAnnotation" }

    let InclusionDependencyAnnotation =
        { _prefixID with _localName = "InclusionDependencyAnnotation" }

    let Input = { _prefixID with _localName = "Input" }
    let Iterable = { _prefixID with _localName = "Iterable" }
    let IterableField = { _prefixID with _localName = "IterableField" }
    let JSONPath = { _prefixID with _localName = "JSONPath" }
    let Join = { _prefixID with _localName = "Join" }
    let LanguageMap = { _prefixID with _localName = "LanguageMap" }
    let Literal = { _prefixID with _localName = "Literal" }
    let LogicalSource = { _prefixID with _localName = "LogicalSource" }
    let LogicalTarget = { _prefixID with _localName = "LogicalTarget" }
    let LogicalView = { _prefixID with _localName = "LogicalView" }
    let LogicalViewJoin = { _prefixID with _localName = "LogicalViewJoin" }
    let MappingDirectory = { _prefixID with _localName = "MappingDirectory" }
    let Namespace = { _prefixID with _localName = "Namespace" }
    let NonAssertedTriplesMap = { _prefixID with _localName = "NonAssertedTriplesMap" }
    let NonNullableAnnotation = { _prefixID with _localName = "NonNullableAnnotation" }
    let ObjectMap = { _prefixID with _localName = "ObjectMap" }
    let ParameterMap = { _prefixID with _localName = "ParameterMap" }
    let ParentMap = { _prefixID with _localName = "ParentMap" }
    let PredicateMap = { _prefixID with _localName = "PredicateMap" }
    let PredicateObjectMap = { _prefixID with _localName = "PredicateObjectMap" }
    let PrimaryKeyAnnotation = { _prefixID with _localName = "PrimaryKeyAnnotation" }
    let RefObjectMap = { _prefixID with _localName = "RefObjectMap" }
    let ReferenceFormulation = { _prefixID with _localName = "ReferenceFormulation" }
    let RelativePath = { _prefixID with _localName = "RelativePath" }
    let ReturnMap = { _prefixID with _localName = "ReturnMap" }
    let SQL2008Query = { _prefixID with _localName = "SQL2008Query" }
    let SQL2008Table = { _prefixID with _localName = "SQL2008Table" }
    let Source = { _prefixID with _localName = "Source" }
    let StarMap = { _prefixID with _localName = "StarMap" }
    let Strategy = { _prefixID with _localName = "Strategy" }
    let StructuralAnnotation = { _prefixID with _localName = "StructuralAnnotation" }
    let SubjectMap = { _prefixID with _localName = "SubjectMap" }
    let Target = { _prefixID with _localName = "Target" }
    let TermMap = { _prefixID with _localName = "TermMap" }
    let TriplesMap = { _prefixID with _localName = "TriplesMap" }
    let URI = { _prefixID with _localName = "URI" }
    let ``UTF-16`` = { _prefixID with _localName = "UTF-16" }
    let ``UTF-8`` = { _prefixID with _localName = "UTF-8" }
    let UniqueAnnotation = { _prefixID with _localName = "UniqueAnnotation" }
    let UnsafeIRI = { _prefixID with _localName = "UnsafeIRI" }
    let UnsafeURI = { _prefixID with _localName = "UnsafeURI" }
    let XPath = { _prefixID with _localName = "XPath" }

    let XPathReferenceFormulation =
        { _prefixID with _localName = "XPathReferenceFormulation" }

    let allowEmptyListAndContainer =
        { _prefixID with _localName = "allowEmptyListAndContainer" }

    let append = { _prefixID with _localName = "append" }
    let baseIRI = { _prefixID with _localName = "baseIRI" }
    let cartesianProduct = { _prefixID with _localName = "cartesianProduct" }
    let cc = { _prefixID with _localName = "cc" }
    let child = { _prefixID with _localName = "child" }
    let childMap = { _prefixID with _localName = "childMap" }
    let ``class`` = { _prefixID with _localName = "class" }
    let compression = { _prefixID with _localName = "compression" }
    let constant = { _prefixID with _localName = "constant" }
    let core = { _prefixID with _localName = "core" }
    let datatype = { _prefixID with _localName = "datatype" }
    let datatypeMap = { _prefixID with _localName = "datatypeMap" }
    let encoding = { _prefixID with _localName = "encoding" }
    let field = { _prefixID with _localName = "field" }
    let fieldName = { _prefixID with _localName = "fieldName" }
    let fnml = { _prefixID with _localName = "fnml" }
    let ``function`` = { _prefixID with _localName = "function" }
    let functionExecution = { _prefixID with _localName = "functionExecution" }
    let functionMap = { _prefixID with _localName = "functionMap" }
    let gather = { _prefixID with _localName = "gather" }
    let gatherAs = { _prefixID with _localName = "gatherAs" }
    let graph = { _prefixID with _localName = "graph" }
    let graphMap = { _prefixID with _localName = "graphMap" }
    let gzip = { _prefixID with _localName = "gzip" }
    let innerJoin = { _prefixID with _localName = "innerJoin" }
    let input = { _prefixID with _localName = "input" }
    let inputValue = { _prefixID with _localName = "inputValue" }
    let inputValueMap = { _prefixID with _localName = "inputValueMap" }
    let io = { _prefixID with _localName = "io" }
    let iterator = { _prefixID with _localName = "iterator" }
    let joinCondition = { _prefixID with _localName = "joinCondition" }
    let language = { _prefixID with _localName = "language" }
    let languageMap = { _prefixID with _localName = "languageMap" }
    let leftJoin = { _prefixID with _localName = "leftJoin" }
    let logicalSource = { _prefixID with _localName = "logicalSource" }
    let logicalTarget = { _prefixID with _localName = "logicalTarget" }
    let lv = { _prefixID with _localName = "lv" }
    let ``namespace`` = { _prefixID with _localName = "namespace" }
    let namespacePrefix = { _prefixID with _localName = "namespacePrefix" }
    let namespaceURL = { _prefixID with _localName = "namespaceURL" }
    let none = { _prefixID with _localName = "none" }
    let ``null`` = { _prefixID with _localName = "null" }
    let object = { _prefixID with _localName = "object" }
    let objectMap = { _prefixID with _localName = "objectMap" }
    let onFields = { _prefixID with _localName = "onFields" }
    let parameter = { _prefixID with _localName = "parameter" }
    let parameterMap = { _prefixID with _localName = "parameterMap" }
    let parent = { _prefixID with _localName = "parent" }
    let parentLogicalView = { _prefixID with _localName = "parentLogicalView" }
    let parentMap = { _prefixID with _localName = "parentMap" }
    let parentTriplesMap = { _prefixID with _localName = "parentTriplesMap" }
    let path = { _prefixID with _localName = "path" }
    let predicate = { _prefixID with _localName = "predicate" }
    let predicateMap = { _prefixID with _localName = "predicateMap" }
    let predicateObjectMap = { _prefixID with _localName = "predicateObjectMap" }
    let quotedTriplesMap = { _prefixID with _localName = "quotedTriplesMap" }
    let reference = { _prefixID with _localName = "reference" }
    let referenceFormulation = { _prefixID with _localName = "referenceFormulation" }
    let ``return`` = { _prefixID with _localName = "return" }
    let returnMap = { _prefixID with _localName = "returnMap" }
    let root = { _prefixID with _localName = "root" }
    let serialization = { _prefixID with _localName = "serialization" }
    let source = { _prefixID with _localName = "source" }
    let star = { _prefixID with _localName = "star" }
    let strategy = { _prefixID with _localName = "strategy" }
    let structuralAnnotation = { _prefixID with _localName = "structuralAnnotation" }
    let subject = { _prefixID with _localName = "subject" }
    let subjectMap = { _prefixID with _localName = "subjectMap" }
    let target = { _prefixID with _localName = "target" }
    let targetFields = { _prefixID with _localName = "targetFields" }
    let targetView = { _prefixID with _localName = "targetView" }
    let targzip = { _prefixID with _localName = "targzip" }
    let tarxz = { _prefixID with _localName = "tarxz" }
    let template = { _prefixID with _localName = "template" }
    let termType = { _prefixID with _localName = "termType" }
    let viewOn = { _prefixID with _localName = "viewOn" }
    let zip = { _prefixID with _localName = "zip" }

    module lv_ =
        let _prefixID =
            Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
                "http://w3id.org/rml/lv/"
                (Some @"http://w3id.org/rml/")
                (Some "rml.lv")
                None

        let shapes = { _prefixID with _localName = "shapes" }

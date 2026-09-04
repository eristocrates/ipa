#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dqc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semwebquality.org/ontologies/dq-constraints#" "dqc"

    let ConstraintTemplates = _prefixId.prefix "ConstraintTemplates"
    let EAN_13All = _prefixId.prefix "EAN-13All"
    let EAN_13Class = _prefixId.prefix "EAN-13Class"

    let ExclusiveFunctionalDependencyAll =
        _prefixId.prefix "ExclusiveFunctionalDependencyAll"

    let ExclusiveFunctionalDependencyClass =
        _prefixId.prefix "ExclusiveFunctionalDependencyClass"

    let FiveDigitNumericAll = _prefixId.prefix "FiveDigitNumericAll"

    let FunctionalDependencyConstraints =
        _prefixId.prefix "FunctionalDependencyConstraints"

    let FunctionalDependencyTrustedReferenceAll =
        _prefixId.prefix "FunctionalDependencyTrustedReferenceAll"

    let FunctionalDependencyTrustedReferenceClass =
        _prefixId.prefix "FunctionalDependencyTrustedReferenceClass"

    let FunctionalDependencyTrustedReference_ClassOverBlankNode =
        _prefixId.prefix "FunctionalDependencyTrustedReference_ClassOverBlankNode"

    let FunctionalDependentEmptyValueAll =
        _prefixId.prefix "FunctionalDependentEmptyValueAll"

    let InconsistentValueRangeAll = _prefixId.prefix "InconsistentValueRangeAll"
    let LegalValueConstraints = _prefixId.prefix "LegalValueConstraints"
    let LettersAll = _prefixId.prefix "LettersAll"
    let LettersAndDotsAll = _prefixId.prefix "LettersAndDotsAll"
    let ListedIllegalValueAll = _prefixId.prefix "ListedIllegalValueAll"
    let ListedIllegalValueClass = _prefixId.prefix "ListedIllegalValueClass"
    let ListedLegalValueAll = _prefixId.prefix "ListedLegalValueAll"
    let ListedLegalValueClass = _prefixId.prefix "ListedLegalValueClass"

    let ListedLegalValueClassOverBlankNode =
        _prefixId.prefix "ListedLegalValueClassOverBlankNode"

    let LowerLimitAll = _prefixId.prefix "LowerLimitAll"
    let LowerLimitClass = _prefixId.prefix "LowerLimitClass"
    let MissingElementConstraints = _prefixId.prefix "MissingElementConstraints"
    let MissingLiterals = _prefixId.prefix "MissingLiterals"
    let MissingLiteralsAndProperties = _prefixId.prefix "MissingLiteralsAndProperties"
    let MissingProperties = _prefixId.prefix "MissingProperties"
    let NumbersAll = _prefixId.prefix "NumbersAll"
    let SyntaxConstraints = _prefixId.prefix "SyntaxConstraints"
    let UniqueValueAll = _prefixId.prefix "UniqueValueAll"
    let UniqueValueClass = _prefixId.prefix "UniqueValueClass"
    let UniquenessConstraints = _prefixId.prefix "UniquenessConstraints"
    let UpperLimitAll = _prefixId.prefix "UpperLimitAll"
    let UpperLimitClass = _prefixId.prefix "UpperLimitClass"
    let ValueRangeConstraints = _prefixId.prefix "ValueRangeConstraints"

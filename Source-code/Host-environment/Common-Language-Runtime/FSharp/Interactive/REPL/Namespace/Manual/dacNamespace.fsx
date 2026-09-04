#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"

open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02" "dac"

    let _prefix (localName: string) =
        PrefixedIri
            { prefixId = _prefixId
              localName = localName }

    let DataSchemaModel = _prefix "DataSchemaModel"
    let Model = _prefix "Model"
    let Element = _prefix "Element"
    let Property = _prefix "Property"
    let Value = _prefix "Value"
    let QuotedIdentifiers = _prefix "QuotedIdentifiers"
    let AnsiNulls = _prefix "AnsiNulls"
    let Name = _prefix "Name"
    let Relationship = _prefix "Relationship"
    let Entry = _prefix "Entry"
    let Annotation = _prefix "Annotation"
    let Type = _prefix "Type"
    let References = _prefix "References"
    let ExternalSource = _prefix "ExternalSource"
    let AttachedAnnotation = _prefix "AttachedAnnotation"
    let Disambiguator = _prefix "Disambiguator"
    let FileFormatVersion = _prefix "FileFormatVersion"
    let SchemaVersion = _prefix "SchemaVersion"
    let DspName = _prefix "DspName"
    let CollationLcid = _prefix "CollationLcid"
    let CollationCaseSensitive = _prefix "CollationCaseSensitive"
    let SqlCheckConstraint = _prefix "SqlCheckConstraint"
    let SqlDatabaseOptions = _prefix "SqlDatabaseOptions"
    let SqlDefaultConstraint = _prefix "SqlDefaultConstraint"
    let SqlDmlTrigger = _prefix "SqlDmlTrigger"
    let SqlExtendedProperty = _prefix "SqlExtendedProperty"
    let SqlForeignKeyConstraint = _prefix "SqlForeignKeyConstraint"
    let SqlIndex = _prefix "SqlIndex"
    let SqlInlineTableValuedFunction = _prefix "SqlInlineTableValuedFunction"
    let SqlLogin = _prefix "SqlLogin"

    let SqlMultiStatementTableValuedFunction =
        _prefix "SqlMultiStatementTableValuedFunction"

    let SqlPrimaryKeyConstraint = _prefix "SqlPrimaryKeyConstraint"
    let SqlProcedure = _prefix "SqlProcedure"
    let SqlRole = _prefix "SqlRole"
    let SqlRoleMembership = _prefix "SqlRoleMembership"
    let SqlScalarFunction = _prefix "SqlScalarFunction"
    let SqlSchema = _prefix "SqlSchema"
    let SqlStatistic = _prefix "SqlStatistic"
    let SqlSynonym = _prefix "SqlSynonym"
    let SqlTable = _prefix "SqlTable"
    let SqlTableType = _prefix "SqlTableType"
    let SqlUniqueConstraint = _prefix "SqlUniqueConstraint"
    let SqlUser = _prefix "SqlUser"
    let SqlView = _prefix "SqlView"

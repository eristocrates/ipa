namespace Dwellonit.vag.Namespace
module vag =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.essepuntato.it/2013/10/vagueness/" (Some "https://sourceforge.net/p/dwellonit/code/HEAD/tree/VaguenessOntology/model.owl?format=raw") (Some "dwellonit.vag") None
    let ``1.0`` = {_prefixID with _localName = "1.0"}
    let ApplicabilityContext = {_prefixID with _localName = "ApplicabilityContext"}
    let DescriptionOfNonVagueness = {_prefixID with _localName = "DescriptionOfNonVagueness"}
    let DescriptionOfVagueness = {_prefixID with _localName = "DescriptionOfVagueness"}
    let Dimension = {_prefixID with _localName = "Dimension"}
    let DimensionInContext = {_prefixID with _localName = "DimensionInContext"}
    let Justification = {_prefixID with _localName = "Justification"}
    let VaguenessAnnotation = {_prefixID with _localName = "VaguenessAnnotation"}
    let VaguenessType = {_prefixID with _localName = "VaguenessType"}
    let hasApplicabilityContext = {_prefixID with _localName = "hasApplicabilityContext"}
    let hasDimension = {_prefixID with _localName = "hasDimension"}
    let hasDimensionInContext = {_prefixID with _localName = "hasDimensionInContext"}
    let hasEntity = {_prefixID with _localName = "hasEntity"}
    let hasJustification = {_prefixID with _localName = "hasJustification"}
    let hasLogicFormula = {_prefixID with _localName = "hasLogicFormula"}
    let hasNaturalLanguageText = {_prefixID with _localName = "hasNaturalLanguageText"}
    let hasVaguenessType = {_prefixID with _localName = "hasVaguenessType"}
    let isApplicabilityContextOf = {_prefixID with _localName = "isApplicabilityContextOf"}
    let isDimensionIn = {_prefixID with _localName = "isDimensionIn"}
    let isDimensionInContextOf = {_prefixID with _localName = "isDimensionInContextOf"}
    let isDimensionOf = {_prefixID with _localName = "isDimensionOf"}
    let isEntityOf = {_prefixID with _localName = "isEntityOf"}
    let isJustificationOf = {_prefixID with _localName = "isJustificationOf"}
    let isLogicFormulaOf = {_prefixID with _localName = "isLogicFormulaOf"}
    let isVaguenessTypeOf = {_prefixID with _localName = "isVaguenessTypeOf"}
    let ``qualitative-vagueness`` = {_prefixID with _localName = "qualitative-vagueness"}
    let ``quantitative-vagueness`` = {_prefixID with _localName = "quantitative-vagueness"}
    let withDimension = {_prefixID with _localName = "withDimension"}
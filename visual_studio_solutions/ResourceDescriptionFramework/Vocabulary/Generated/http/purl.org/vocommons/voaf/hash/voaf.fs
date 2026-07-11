namespace Voaf.Namespace
module voaf =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/vocommons/voaf#" (Some "http://purl.org/vocommons/voaf#") (Some "voaf") None
    let DatasetOccurrences = {_prefixID with _localName = "DatasetOccurrences"}
    let Vocabulary = {_prefixID with _localName = "Vocabulary"}
    let VocabularySpace = {_prefixID with _localName = "VocabularySpace"}
    let classNumber = {_prefixID with _localName = "classNumber"}
    let dataset = {_prefixID with _localName = "dataset"}
    let exampleDataset = {_prefixID with _localName = "exampleDataset"}
    let extends = {_prefixID with _localName = "extends"}
    let generalizes = {_prefixID with _localName = "generalizes"}
    let hasDisjunctionsWith = {_prefixID with _localName = "hasDisjunctionsWith"}
    let hasEquivalencesWith = {_prefixID with _localName = "hasEquivalencesWith"}
    let inDataset = {_prefixID with _localName = "inDataset"}
    let metadataVoc = {_prefixID with _localName = "metadataVoc"}
    let occurrences = {_prefixID with _localName = "occurrences"}
    let occurrencesInDatasets = {_prefixID with _localName = "occurrencesInDatasets"}
    let occurrencesInVocabularies = {_prefixID with _localName = "occurrencesInVocabularies"}
    let propertyNumber = {_prefixID with _localName = "propertyNumber"}
    let reliesOn = {_prefixID with _localName = "reliesOn"}
    let reusedByDatasets = {_prefixID with _localName = "reusedByDatasets"}
    let reusedByVocabularies = {_prefixID with _localName = "reusedByVocabularies"}
    let similar = {_prefixID with _localName = "similar"}
    let specializes = {_prefixID with _localName = "specializes"}
    let toDoList = {_prefixID with _localName = "toDoList"}
    let usageInDataset = {_prefixID with _localName = "usageInDataset"}
    let usedBy = {_prefixID with _localName = "usedBy"}
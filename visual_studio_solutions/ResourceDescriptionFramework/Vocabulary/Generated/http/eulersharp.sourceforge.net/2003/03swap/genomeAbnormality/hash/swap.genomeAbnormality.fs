namespace Swap.genomeAbnormality.Namespace
module genomeAbnormality =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#" (Some "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality") (Some "swap.genomeAbnormality") None
    let Aneuploidy = {_prefixID with _localName = "Aneuploidy"}
    let ChromosomeAbnormality = {_prefixID with _localName = "ChromosomeAbnormality"}
    let ChromosomeDeletion = {_prefixID with _localName = "ChromosomeDeletion"}
    let ChromosomeDuplication = {_prefixID with _localName = "ChromosomeDuplication"}
    let ChromosomeInsertion = {_prefixID with _localName = "ChromosomeInsertion"}
    let ChromosomeInversion = {_prefixID with _localName = "ChromosomeInversion"}
    let ChromosomeMutation = {_prefixID with _localName = "ChromosomeMutation"}
    let ChromosomeTranslocation = {_prefixID with _localName = "ChromosomeTranslocation"}
    let GeneAbnormality = {_prefixID with _localName = "GeneAbnormality"}
    let GenomeAbnormality = {_prefixID with _localName = "GenomeAbnormality"}
    let MonogenicMutation = {_prefixID with _localName = "MonogenicMutation"}
    let Mutated = {_prefixID with _localName = "Mutated"}
    let PolygenicMutation = {_prefixID with _localName = "PolygenicMutation"}
    let SingleChromosomeMutation = {_prefixID with _localName = "SingleChromosomeMutation"}
    let TwoChromosomeMutation = {_prefixID with _localName = "TwoChromosomeMutation"}
    let Unmutated = {_prefixID with _localName = "Unmutated"}
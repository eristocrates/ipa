#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module frac =

    let _prefix = prefix_label "frac"



    let Attestation = _prefix "Attestation"



    let Collocation = _prefix "Collocation"



    let Frequency = _prefix "Frequency"



    let Observable = _prefix "Observable"



    let Observation = _prefix "Observation"



    let attestation = _prefix "attestation"



    let cScore = _prefix "cScore"



    let citation = _prefix "citation"



    let frequency = _prefix "frequency"


    /// An attestation gloss is the representation of the attestation as provided in a lexical resource. This may contain, for example, amendments or additional comments. For the string as found in the original text, use rdf:value.
    let gloss = _prefix "gloss"



    let head = _prefix "head"


    /// Points from an Observation to the exact location in the source material on where it is to be found. This can be, for example, a page in a book, the string URI of a passage in a text, a canonical reference to a passage in piece of literatur, or any Web Annotation selector. We have confirmed name, function and necessity of this property.
    ///     When the locus is provided, it is not necessary to also refer to the source material as a whole. The existence of such a reference is nevertheless implied.
    let locus = _prefix "locus"


    /// For an Observation, the property observedIn defines the URI of the data
    ///     source (or its metadata entry) that this particular observation was made in or derived from.
    ///     This can be, for example, a corpus or a text represented by its access URL, a book
    ///     represented by its bibliographical metadata, etc.
    let observedIn = _prefix "observedIn"



    let total = _prefix "total"

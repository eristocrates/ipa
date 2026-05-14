#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"
open RDFErgonomics

module rdfx =
    let prefix = prefix_label "rdfx"
    let subject_of = prefix "subject_of"
    let predicate_of = prefix "predicate_of"
    let object_of = prefix "object_of"
    let context_of = prefix "context_of"

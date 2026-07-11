open System

// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"
// open StringExtensions

type Value_Space = Value_Space of unit
type Lexical_Space = Lexical_Space of unit
type Lexical_Mapping = Lexical_Mapping of (Lexical_Space -> Value_Space)
type Canonical_Mapping = Canonical_Mapping of (Value_Space -> Lexical_Space)
type Identity_Relation = Identity_Relation of (Value_Space -> Value_Space -> bool)
type Equality_Relation = Equality_Relation of (Value_Space -> Value_Space -> bool)
type Order_Relation = Order_Relation of (Value_Space -> Value_Space -> bool)

type Datatype =
    {

      value_space: unit
      lexical_space: unit
      equality: unit -> unit
      order: unit -> unit
      lexical_mapping: unit -> unit

     }












//

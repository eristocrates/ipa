// https://www.w3.org/TR/xmlschema11-1/
// just a sketch


open System
open System.Reflection


#r "nuget: FSharp.UMX"
open FSharp.UMX

[<RequireQualifiedAccess>]
type Construction_Kind =
    | restriction
    | extension



[<RequireQualifiedAccess>]
type Type_Definition =
    | FromSimpleTypeDefinition of Simple_Type_Definition
    | FromComplexTypeDefinition of Complex_Type_Definition

and Simple_Type_Definition =
    {

      base_type_definition: Type_Definition
      restrictionFrom: Type_Definition

     }

and Complex_Type_Definition =
    {

      base_type_definition: Type_Definition
      construction_kind: Construction_Kind

     }



module xs =
    let rec anyType =
        { base_type_definition = Type_Definition.FromComplexTypeDefinition anyType
          construction_kind = Construction_Kind.restriction }

    let error = Error



























//

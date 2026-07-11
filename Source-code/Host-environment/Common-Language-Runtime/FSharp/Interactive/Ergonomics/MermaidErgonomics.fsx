open System
open System.Text

#r "nuget: Blake3"
open Blake3
#r "nuget: Siren"
open Siren

type String with

    member this.utf8 = Encoding.UTF8.GetBytes(this)
    member this.utf8_hex_string = Convert.ToHexString(this.utf8)
    member this.blake3 = Blake3.Hasher.Hash(this.utf8).AsSpan().ToArray()
    member this.blake3_hex_string = Convert.ToHexString(this.blake3)


// TODO convert more of siren

let flowchart_node (string_value: string) =
    flowchart.node (string_value.blake3_hex_string, string_value)

let flowchart_rhombus (string_value: string) =
    flowchart.nodeRhombus (string_value.blake3_hex_string, string_value)

let flowchart_unlabeled_link_arrow (from_string: string) (to_string: string) =
    [|


       flowchart_node from_string
       flowchart_node to_string
       flowchart.linkArrow (from_string.blake3_hex_string, to_string.blake3_hex_string)

       |]

let flowchart_labeled_link_arrow (from_string: string) (arrow_label: string) (to_string: string) =
    [|


       flowchart_node from_string
       flowchart_node to_string
       flowchart.linkArrow (from_string.blake3_hex_string, to_string.blake3_hex_string, arrow_label)

       |]

let flowchart_labeled_link_arrow_with_length
    (length: int)
    (from_string: string)
    (arrow_label: string)
    (to_string: string)
    =
    [|

       flowchart_node from_string
       flowchart_node to_string
       flowchart.linkArrow (from_string.blake3_hex_string, to_string.blake3_hex_string, arrow_label, length)

       |]

#load @".paket/load/main.group.fsx"

open System
open PhoneNumbers
open System.Text
open System.Globalization
open TextCopy


type Rune with
    member this.UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory this.Value

type String with
    member this.runes = this.Normalize().EnumerateRunes() |> Seq.toArray

    member this.prefixed(affix: string) = affix + this
    member this.suffixed(affix: string) = this + affix
    member this.circumfixed(affix: string) = affix + this + affix

type Guid with
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")

type PhoneNumber with
    static member Parse(numberString: string) =
        PhoneNumberUtil
            .GetInstance()
            .Parse(numberString, "US")

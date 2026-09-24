#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Pattern.fsx"

open SharedKernel
#load @".paket/load/main.group.fsx"
open System
open System.Text
open System.Text.RegularExpressions
open System.Globalization

open AngleSharp.Html
open TextCopy
open PhoneNumbers





let utf8Encoding = UTF8Encoding(encoderShouldEmitUTF8Identifier = false, throwOnInvalidBytes = true)


let escapedSurrogatePair = Regex(@"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})", RegexOptions.Compiled ||| RegexOptions.CultureInvariant)


type GraphemeCluster = { glyph: string; runes: Rune array }

module String =

    module subString =
        let fromLast (delimeter: string) (superString: string) =
            match superString.LastIndexOf(delimeter) with
            | -1 -> None
            | index -> Some(superString.Substring(index + 1))

        let fromCircumfix (prefix: string) (superstring: string) (suffix: string) =
            match superstring.IndexOf(prefix) + 1, superstring.LastIndexOf(suffix) - 1 with
            | -1, -1 -> None
            | fromPrefix, toSuffix -> Some(superstring[fromPrefix..toSuffix])

        let firstBefore (delimiter: string) (superstring: string) =
            match superstring.IndexOf delimiter with
            | -1 -> None
            | delimiterIndex ->
                let to_delimiter = delimiterIndex - 1
                let substring = superstring.[..to_delimiter]
                Some(substring)

    let untilCharacter (delimiterCharacter: char) (superstring: string) =
        superstring.ToCharArray()
        |> Array.takeWhile (fun character -> character <> delimiterCharacter)
        |> System.String

    let trimmed (text: string) = text.TrimStart().TrimEnd()

    let rev (text: string) =
        text.ToCharArray() |> Array.rev |> String

    /// just a crumb of humor to lighten the day
    let gnirts (text: string) = rev text


    let prepostfix (prefix: string) (text: string) (postfix: string) = prefix + text + postfix
    let circumfix (affix: string) (text: string) = prepostfix affix text affix
    let prefix (affix: string) (text: string) = prepostfix affix text String.Empty
    let postfix (affix: string) (text: string) = prepostfix String.Empty text affix
    let runes (text: string) = text.EnumerateRunes() |> Seq.toArray
    let textElements (text: string) =
        let enumerator = StringInfo.GetTextElementEnumerator(text)

        seq {

            while enumerator.MoveNext() do
                let element = enumerator.GetTextElement()
                yield element
        }
        |> Seq.toArray
    let graphemeClusters (text: string) =
        textElements text
        |> Array.map (fun textElement -> {
            glyph = textElement
            runes = runes textElement
        })
    let tryGraphemeCluster (text: string) =
        match graphemeClusters text with
        | [| graphemeCluster |] -> Some graphemeCluster
        | _ -> None

    let normalizeEscapedSurrogatePairs (text: string) =
        if text.IndexOf(@"\uD", StringComparison.OrdinalIgnoreCase) < 0 then
            text
        else
            Pattern.Regex.escapedSurrogatePair.Replace(
                text,
                MatchEvaluator(fun matched ->
                    let high = Convert.ToInt32(matched.Groups.[1].Value, 16) |> char

                    let low = Convert.ToInt32(matched.Groups.[2].Value, 16) |> char

                    Char.ConvertToUtf32(high, low) |> sprintf "\\U%08X")
            )
    let pathTokens (text: string) =
        text.Split(pathDelimiters, StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)
    let lexicalTokens (text: string) =
        text.Split(lexicalDelimiters, StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)

    let asUtf8 (text: string) =
        Encoding.UTF8.GetBytes(text.ToCharArray())
type String with
    static member Clipboard = new Clipboard()
    member this.trimmed = String.trimmed this
    member this.rev = String.rev this
    /// just a crumb of humor to lighten the day
    member this.gnirts = this.rev
    member this.prefix(affix: string) = String.prefix affix this
    member this.postfix(affix: string) = String.postfix affix this
    member this.circumfix(affix: string) = String.prepostfix affix this affix
    member this.prepostfix(prefix: string, postfix: string) = String.prepostfix prefix this postfix
    member this.clip = String.Clipboard.SetText this
    member this.runes = String.runes this
    member this.graphemeClusters = String.graphemeClusters this
    member this.tryGraphemeCluster = String.tryGraphemeCluster this
    member this.normalizeEscapedSurrogatePairs = String.normalizeEscapedSurrogatePairs this
    member this.pathTokens = String.pathTokens this
    member this.lexicalTokens = String.lexicalTokens this
    member this.asUtf8 = String.asUtf8 this


module Rune =
    let codePoint (rune: Rune) = rune.Value
    let hexName (rune: Rune) = sprintf "%04X" rune.Value
    let UHexName (rune: Rune) = hexName rune |> String.prefix "U+"
    let UnicodeCategory (rune: Rune) =
        CharUnicodeInfo.GetUnicodeCategory rune.Value

type Rune with
    member this.UnicodeCategory = Rune.UnicodeCategory this
    member this.codePoint = Rune.codePoint this
    member this.hexName = Rune.hexName this
    member this.UHexName = Rune.UHexName this


module GraphemeCluster =
    let tryHtmlName (graphemeCluster: GraphemeCluster) =
        match HtmlEntityProvider.ReverseResolver.GetName(graphemeCluster.glyph) with
        | null -> None
        | name -> Some(name.TrimEnd ';')

    let tryHtmlEntity (graphemeCluster: GraphemeCluster) =
        tryHtmlName graphemeCluster
        |> Option.map (fun name -> name.prepostfix ("&", ";"))
    let hexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.hexName)
        |> String.concat " "
    let UHexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.UHexName)
        |> String.concat " "
type GraphemeCluster with
    member this.tryHtmlName = GraphemeCluster.tryHtmlName this
    member this.tryHtmlEntity = GraphemeCluster.tryHtmlEntity this
    member this.hexName = GraphemeCluster.hexName this
    member this.UHexName = GraphemeCluster.UHexName this

module Char =
    let graphemeCluster (character: char) =
        string character |> String.tryGraphemeCluster |> Option.get
    let tryHtmlName (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlName
    let tryHtmlEntity (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlEntity
    let hexName (character: char) =
        graphemeCluster character |> GraphemeCluster.hexName
    let UHexName (character: char) =
        graphemeCluster character |> GraphemeCluster.UHexName
    let decimalEntity (character: char) = sprintf "&#%i;" (int character)
    let hexadecimalEntity (character: char) = sprintf "&#%i;" (int character)
type Char with
    member this.graphemeCluster = Char.graphemeCluster this
    member this.tryHtmlName = Char.tryHtmlName this

    member this.tryHtmlEntity = Char.tryHtmlEntity this
    member this.hexName = Char.hexName this
    member this.UHexName = Char.UHexName this



type Guid with
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")

type PhoneNumber with
    static member Parse(numberString: string) =
        PhoneNumberUtil.GetInstance().Parse(numberString, "US")

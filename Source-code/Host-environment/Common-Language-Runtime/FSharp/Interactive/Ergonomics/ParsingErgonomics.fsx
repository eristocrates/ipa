open System
open System.Text
open System.Linq

#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"

open FParsec
open FParsec.Pipes



let parser'withArgument'expecting parser argument (expectingMessage: string) = parser argument <??> expectingMessage




let string_from_charList (charList: char list) = new String(charList.ToArray())


let zero_or_more = many
let one_or_more = many1
let zero_of = notEmpty

let contiguous parser =
    one_or_more parser .>> (spaces1 <|> eof)

let prepend (head: 'HeadTailType) (tail: List<'HeadTailType>) = head :: tail

let int_from_stringNumeral (stringNumeral: string) =
    match System.Int32.TryParse(stringNumeral) with
    | true, intNumeral -> intNumeral
    | _ -> failwithf "Invalid numeral string: %s" stringNumeral

let intNumeral_from_charNumeral (charNumeral: char) =
    int_from_stringNumeral (string charNumeral)

let int_from_singleDigit (int_from_singleDigit: char) =
    int_from_stringNumeral (string int_from_singleDigit)

let int_from_doubleDigit (leftDigit: char) (rightDigit: char) =
    int_from_stringNumeral $"{leftDigit}{rightDigit}"

let int_from_tripleDigit (leftDigit: char) (centerDigit: char) (rightDigit: char) =
    int_from_stringNumeral $"{leftDigit}{centerDigit}{rightDigit}"

type Adposition =
    | OnString
    | OnFilePath
    | OnFileContent

let runParser parser (adposition: Adposition) (inputString: string) =
    match adposition with
    | OnString -> runParserOnString parser () "" inputString

let parseStringVariable parser (stringVariable: string) =
    runParserOnString parser () "" stringVariable

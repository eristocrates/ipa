open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics



type Exclamation_Mark =
    { as_rune: Rune }

    static member parse: Parser<Exclamation_Mark, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '!' |>> fun rune -> { as_rune = rune }

type Quotation_Mark =
    { as_rune: Rune }

    static member parse: Parser<Quotation_Mark, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '"' |>> fun rune -> { as_rune = rune }


type Number_Sign =
    { as_rune: Rune }

    static member parse: Parser<Number_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '#' |>> fun rune -> { as_rune = rune }

type Dollar_Sign =
    { as_rune: Rune }

    static member parse: Parser<Dollar_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '$' |>> fun rune -> { as_rune = rune }

type Percent_Sign =
    { as_rune: Rune }

    static member parse: Parser<Percent_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '%' |>> fun rune -> { as_rune = rune }

type Ampersand =
    { as_rune: Rune }

    static member parse: Parser<Ampersand, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '&' |>> fun rune -> { as_rune = rune }

type Apostrophe =
    { as_rune: Rune }

    static member parse: Parser<Apostrophe, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '\'' |>> fun rune -> { as_rune = rune }

type Left_Parenthesis =
    { as_rune: Rune }

    static member parse: Parser<Left_Parenthesis, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '(' |>> fun rune -> { as_rune = rune }

type Right_Parenthesis =
    { as_rune: Rune }

    static member parse: Parser<Right_Parenthesis, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune ')' |>> fun rune -> { as_rune = rune }

type Asterisk =
    { as_rune: Rune }

    static member parse: Parser<Asterisk, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '*' |>> fun rune -> { as_rune = rune }

type Plus_Sign =
    { as_rune: Rune }

    static member parse: Parser<Plus_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '+' |>> fun rune -> { as_rune = rune }

type Comma =
    { as_rune: Rune }

    static member parse: Parser<Comma, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune ',' |>> fun rune -> { as_rune = rune }

type Hyphen_Minus =
    { as_rune: Rune }

    static member parse: Parser<Hyphen_Minus, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '-' |>> fun rune -> { as_rune = rune }

type Full_Stop =
    { as_rune: Rune }

    static member parse: Parser<Full_Stop, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '.' |>> fun rune -> { as_rune = rune }

type Solidus =
    { as_rune: Rune }

    static member parse: Parser<Solidus, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '/' |>> fun rune -> { as_rune = rune }

type Colon =
    { as_rune: Rune }

    static member parse: Parser<Colon, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune ':' |>> fun rune -> { as_rune = rune }

type Semicolon =
    { as_rune: Rune }

    static member parse: Parser<Semicolon, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune ';' |>> fun rune -> { as_rune = rune }

type Less_Than_Sign =
    { as_rune: Rune }

    static member parse: Parser<Semicolon, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '<' |>> fun rune -> { as_rune = rune }

type Equals_Sign =
    { as_rune: Rune }

    static member parse: Parser<Equals_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '=' |>> fun rune -> { as_rune = rune }

type Greater_Than_Sign =
    { as_rune: Rune }

    static member parse: Parser<Semicolon, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '>' |>> fun rune -> { as_rune = rune }

type Question_Mark =
    { as_rune: Rune }

    static member parse: Parser<Question_Mark, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '?' |>> fun rune -> { as_rune = rune }

type Commercial_At =
    { as_rune: Rune }

    static member parse: Parser<Commercial_At, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '@' |>> fun rune -> { as_rune = rune }

type Left_Square_Bracket =
    { as_rune: Rune }

    static member parse: Parser<Left_Square_Bracket, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '[' |>> fun rune -> { as_rune = rune }

type Reverse_Solidus =
    { as_rune: Rune }

    static member parse: Parser<Reverse_Solidus, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '\\' |>> fun rune -> { as_rune = rune }

type Right_Square_Bracket =
    { as_rune: Rune }

    static member parse: Parser<Right_Square_Bracket, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune ']' |>> fun rune -> { as_rune = rune }

type Low_Line =
    { as_rune: Rune }

    static member parse: Parser<Low_Line, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '_' |>> fun rune -> { as_rune = rune }

type Left_Curly_Bracket =
    { as_rune: Rune }

    static member parse: Parser<Left_Curly_Bracket, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '{' |>> fun rune -> { as_rune = rune }

type Vertical_Line =
    { as_rune: Rune }

    static member parse: Parser<Reverse_Solidus, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '|' |>> fun rune -> { as_rune = rune }

type Right_Curly_Bracket =
    { as_rune: Rune }

    static member parse: Parser<Right_Curly_Bracket, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '}' |>> fun rune -> { as_rune = rune }

type Tilde =
    { as_rune: Rune }

    static member parse: Parser<Tilde, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '~' |>> fun rune -> { as_rune = rune }

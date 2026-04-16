module ParserCombinator.ABNF
open System
open System.Text
open System.IO
open System.Globalization



open XParsec
open XParsec.Parsers



open Ergonomics.XParsecErgonomics


open Unicodepoint.LatinAlphabet


open Unicodepoint.ArabicNumerals

[<RequireQualifiedAccess>]
type ALPHA =
    | FromLatinCapitalLetterA of Latin_Capital_Letter_A
    | FromLatinCapitalLetterB of Latin_Capital_Letter_B
    | FromLatinCapitalLetterC of Latin_Capital_Letter_C
    | FromLatinCapitalLetterD of Latin_Capital_Letter_D
    | FromLatinCapitalLetterE of Latin_Capital_Letter_E
    | FromLatinCapitalLetterF of Latin_Capital_Letter_F
    | FromLatinCapitalLetterG of Latin_Capital_Letter_G
    | FromLatinCapitalLetterH of Latin_Capital_Letter_H
    | FromLatinCapitalLetterI of Latin_Capital_Letter_I
    | FromLatinCapitalLetterJ of Latin_Capital_Letter_J
    | FromLatinCapitalLetterK of Latin_Capital_Letter_K
    | FromLatinCapitalLetterL of Latin_Capital_Letter_L
    | FromLatinCapitalLetterM of Latin_Capital_Letter_M
    | FromLatinCapitalLetterN of Latin_Capital_Letter_N
    | FromLatinCapitalLetterO of Latin_Capital_Letter_O
    | FromLatinCapitalLetterP of Latin_Capital_Letter_P
    | FromLatinCapitalLetterQ of Latin_Capital_Letter_Q
    | FromLatinCapitalLetterR of Latin_Capital_Letter_R
    | FromLatinCapitalLetterS of Latin_Capital_Letter_S
    | FromLatinCapitalLetterT of Latin_Capital_Letter_T
    | FromLatinCapitalLetterU of Latin_Capital_Letter_U
    | FromLatinCapitalLetterV of Latin_Capital_Letter_V
    | FromLatinCapitalLetterW of Latin_Capital_Letter_W
    | FromLatinCapitalLetterX of Latin_Capital_Letter_X
    | FromLatinCapitalLetterY of Latin_Capital_Letter_Y
    | FromLatinCapitalLetterZ of Latin_Capital_Letter_Z
    | FromLatinSmallLettera of Latin_Small_Letter_a
    | FromLatinSmallLetterb of Latin_Small_Letter_b
    | FromLatinSmallLetterc of Latin_Small_Letter_c
    | FromLatinSmallLetterd of Latin_Small_Letter_d
    | FromLatinSmallLettere of Latin_Small_Letter_e
    | FromLatinSmallLetterf of Latin_Small_Letter_f
    | FromLatinSmallLetterg of Latin_Small_Letter_g
    | FromLatinSmallLetterh of Latin_Small_Letter_h
    | FromLatinSmallLetteri of Latin_Small_Letter_i
    | FromLatinSmallLetterj of Latin_Small_Letter_j
    | FromLatinSmallLetterk of Latin_Small_Letter_k
    | FromLatinSmallLetterl of Latin_Small_Letter_l
    | FromLatinSmallLetterm of Latin_Small_Letter_m
    | FromLatinSmallLettern of Latin_Small_Letter_n
    | FromLatinSmallLettero of Latin_Small_Letter_o
    | FromLatinSmallLetterp of Latin_Small_Letter_p
    | FromLatinSmallLetterq of Latin_Small_Letter_q
    | FromLatinSmallLetterr of Latin_Small_Letter_r
    | FromLatinSmallLetters of Latin_Small_Letter_s
    | FromLatinSmallLettert of Latin_Small_Letter_t
    | FromLatinSmallLetteru of Latin_Small_Letter_u
    | FromLatinSmallLetterv of Latin_Small_Letter_v
    | FromLatinSmallLetterw of Latin_Small_Letter_w
    | FromLatinSmallLetterx of Latin_Small_Letter_x
    | FromLatinSmallLettery of Latin_Small_Letter_y
    | FromLatinSmallLetterz of Latin_Small_Letter_z

    member this.as_rune =
        match this with
        | FromLatinCapitalLetterA x -> x.as_rune
        | FromLatinCapitalLetterB x -> x.as_rune
        | FromLatinCapitalLetterC x -> x.as_rune
        | FromLatinCapitalLetterD x -> x.as_rune
        | FromLatinCapitalLetterE x -> x.as_rune
        | FromLatinCapitalLetterF x -> x.as_rune
        | FromLatinCapitalLetterG x -> x.as_rune
        | FromLatinCapitalLetterH x -> x.as_rune
        | FromLatinCapitalLetterI x -> x.as_rune
        | FromLatinCapitalLetterJ x -> x.as_rune
        | FromLatinCapitalLetterK x -> x.as_rune
        | FromLatinCapitalLetterL x -> x.as_rune
        | FromLatinCapitalLetterM x -> x.as_rune
        | FromLatinCapitalLetterN x -> x.as_rune
        | FromLatinCapitalLetterO x -> x.as_rune
        | FromLatinCapitalLetterP x -> x.as_rune
        | FromLatinCapitalLetterQ x -> x.as_rune
        | FromLatinCapitalLetterR x -> x.as_rune
        | FromLatinCapitalLetterS x -> x.as_rune
        | FromLatinCapitalLetterT x -> x.as_rune
        | FromLatinCapitalLetterU x -> x.as_rune
        | FromLatinCapitalLetterV x -> x.as_rune
        | FromLatinCapitalLetterW x -> x.as_rune
        | FromLatinCapitalLetterX x -> x.as_rune
        | FromLatinCapitalLetterY x -> x.as_rune
        | FromLatinCapitalLetterZ x -> x.as_rune
        | FromLatinSmallLettera x -> x.as_rune
        | FromLatinSmallLetterb x -> x.as_rune
        | FromLatinSmallLetterc x -> x.as_rune
        | FromLatinSmallLetterd x -> x.as_rune
        | FromLatinSmallLettere x -> x.as_rune
        | FromLatinSmallLetterf x -> x.as_rune
        | FromLatinSmallLetterg x -> x.as_rune
        | FromLatinSmallLetterh x -> x.as_rune
        | FromLatinSmallLetteri x -> x.as_rune
        | FromLatinSmallLetterj x -> x.as_rune
        | FromLatinSmallLetterk x -> x.as_rune
        | FromLatinSmallLetterl x -> x.as_rune
        | FromLatinSmallLetterm x -> x.as_rune
        | FromLatinSmallLettern x -> x.as_rune
        | FromLatinSmallLettero x -> x.as_rune
        | FromLatinSmallLetterp x -> x.as_rune
        | FromLatinSmallLetterq x -> x.as_rune
        | FromLatinSmallLetterr x -> x.as_rune
        | FromLatinSmallLetters x -> x.as_rune
        | FromLatinSmallLettert x -> x.as_rune
        | FromLatinSmallLetteru x -> x.as_rune
        | FromLatinSmallLetterv x -> x.as_rune
        | FromLatinSmallLetterw x -> x.as_rune
        | FromLatinSmallLetterx x -> x.as_rune
        | FromLatinSmallLettery x -> x.as_rune
        | FromLatinSmallLetterz x -> x.as_rune

    static member parse: Parser<ALPHA, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [ Latin_Capital_Letter_A.parse
                      |>> FromLatinCapitalLetterA
                      Latin_Capital_Letter_B.parse
                      |>> FromLatinCapitalLetterB
                      Latin_Capital_Letter_C.parse
                      |>> FromLatinCapitalLetterC
                      Latin_Capital_Letter_D.parse
                      |>> FromLatinCapitalLetterD
                      Latin_Capital_Letter_E.parse
                      |>> FromLatinCapitalLetterE
                      Latin_Capital_Letter_F.parse
                      |>> FromLatinCapitalLetterF
                      Latin_Capital_Letter_G.parse
                      |>> FromLatinCapitalLetterG
                      Latin_Capital_Letter_H.parse
                      |>> FromLatinCapitalLetterH
                      Latin_Capital_Letter_I.parse
                      |>> FromLatinCapitalLetterI
                      Latin_Capital_Letter_J.parse
                      |>> FromLatinCapitalLetterJ
                      Latin_Capital_Letter_K.parse
                      |>> FromLatinCapitalLetterK
                      Latin_Capital_Letter_L.parse
                      |>> FromLatinCapitalLetterL
                      Latin_Capital_Letter_M.parse
                      |>> FromLatinCapitalLetterM
                      Latin_Capital_Letter_N.parse
                      |>> FromLatinCapitalLetterN
                      Latin_Capital_Letter_O.parse
                      |>> FromLatinCapitalLetterO
                      Latin_Capital_Letter_P.parse
                      |>> FromLatinCapitalLetterP
                      Latin_Capital_Letter_Q.parse
                      |>> FromLatinCapitalLetterQ
                      Latin_Capital_Letter_R.parse
                      |>> FromLatinCapitalLetterR
                      Latin_Capital_Letter_S.parse
                      |>> FromLatinCapitalLetterS
                      Latin_Capital_Letter_T.parse
                      |>> FromLatinCapitalLetterT
                      Latin_Capital_Letter_U.parse
                      |>> FromLatinCapitalLetterU
                      Latin_Capital_Letter_V.parse
                      |>> FromLatinCapitalLetterV
                      Latin_Capital_Letter_W.parse
                      |>> FromLatinCapitalLetterW
                      Latin_Capital_Letter_X.parse
                      |>> FromLatinCapitalLetterX
                      Latin_Capital_Letter_Y.parse
                      |>> FromLatinCapitalLetterY
                      Latin_Capital_Letter_Z.parse
                      |>> FromLatinCapitalLetterZ
                      Latin_Small_Letter_a.parse
                      |>> FromLatinSmallLettera
                      Latin_Small_Letter_b.parse
                      |>> FromLatinSmallLetterb
                      Latin_Small_Letter_c.parse
                      |>> FromLatinSmallLetterc
                      Latin_Small_Letter_d.parse
                      |>> FromLatinSmallLetterd
                      Latin_Small_Letter_e.parse
                      |>> FromLatinSmallLettere
                      Latin_Small_Letter_f.parse
                      |>> FromLatinSmallLetterf
                      Latin_Small_Letter_g.parse
                      |>> FromLatinSmallLetterg
                      Latin_Small_Letter_h.parse
                      |>> FromLatinSmallLetterh
                      Latin_Small_Letter_i.parse
                      |>> FromLatinSmallLetteri
                      Latin_Small_Letter_j.parse
                      |>> FromLatinSmallLetterj
                      Latin_Small_Letter_k.parse
                      |>> FromLatinSmallLetterk
                      Latin_Small_Letter_l.parse
                      |>> FromLatinSmallLetterl
                      Latin_Small_Letter_m.parse
                      |>> FromLatinSmallLetterm
                      Latin_Small_Letter_n.parse
                      |>> FromLatinSmallLettern
                      Latin_Small_Letter_o.parse
                      |>> FromLatinSmallLettero
                      Latin_Small_Letter_p.parse
                      |>> FromLatinSmallLetterp
                      Latin_Small_Letter_q.parse
                      |>> FromLatinSmallLetterq
                      Latin_Small_Letter_r.parse
                      |>> FromLatinSmallLetterr
                      Latin_Small_Letter_s.parse
                      |>> FromLatinSmallLetters
                      Latin_Small_Letter_t.parse
                      |>> FromLatinSmallLettert
                      Latin_Small_Letter_u.parse
                      |>> FromLatinSmallLetteru
                      Latin_Small_Letter_v.parse
                      |>> FromLatinSmallLetterv
                      Latin_Small_Letter_w.parse
                      |>> FromLatinSmallLetterw
                      Latin_Small_Letter_x.parse
                      |>> FromLatinSmallLetterx
                      Latin_Small_Letter_y.parse
                      |>> FromLatinSmallLettery
                      Latin_Small_Letter_z.parse
                      |>> FromLatinSmallLetterz ])
            """ ALPHA          = %x41-5A / %x61-7A """



[<RequireQualifiedAccess>]
type DIGIT =
    | FromDigitZero of Digit_Zero
    | FromDigitOne of Digit_One
    | FromDigitTwo of Digit_Two
    | FromDigitThree of Digit_Three
    | FromDigitFour of Digit_Four
    | FromDigitFive of Digit_Five
    | FromDigitSix of Digit_Six
    | FromDigitSeven of Digit_Seven
    | FromDigitEight of Digit_Eight
    | FromDigitNine of Digit_Nine

    member this.as_rune =
        match this with
        | FromDigitZero x -> x.as_rune
        | FromDigitOne x -> x.as_rune
        | FromDigitTwo x -> x.as_rune
        | FromDigitThree x -> x.as_rune
        | FromDigitFour x -> x.as_rune
        | FromDigitFive x -> x.as_rune
        | FromDigitSix x -> x.as_rune
        | FromDigitSeven x -> x.as_rune
        | FromDigitEight x -> x.as_rune
        | FromDigitNine x -> x.as_rune

    static member parse: Parser<DIGIT, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [ Digit_Zero.parse |>> FromDigitZero
                      Digit_One.parse |>> FromDigitOne
                      Digit_Two.parse |>> FromDigitTwo
                      Digit_Three.parse |>> FromDigitThree
                      Digit_Four.parse |>> FromDigitFour
                      Digit_Five.parse |>> FromDigitFive
                      Digit_Six.parse |>> FromDigitSix
                      Digit_Seven.parse |>> FromDigitSeven
                      Digit_Eight.parse |>> FromDigitEight
                      Digit_Nine.parse |>> FromDigitNine ])
            """ DIGIT          =  %x30-39 ; 0-9 """

[<RequireQualifiedAccess>]
type HEXDIGIT =
    | FromDIGIT of DIGIT
    | FromLatinCapitalLetterA of Latin_Capital_Letter_A
    | FromLatinCapitalLetterB of Latin_Capital_Letter_B
    | FromLatinCapitalLetterC of Latin_Capital_Letter_C
    | FromLatinCapitalLetterD of Latin_Capital_Letter_D
    | FromLatinCapitalLetterE of Latin_Capital_Letter_E
    | FromLatinCapitalLetterF of Latin_Capital_Letter_F
    | FromLatinSmallLettera of Latin_Small_Letter_a
    | FromLatinSmallLetterb of Latin_Small_Letter_b
    | FromLatinSmallLetterc of Latin_Small_Letter_c
    | FromLatinSmallLetterd of Latin_Small_Letter_d
    | FromLatinSmallLettere of Latin_Small_Letter_e
    | FromLatinSmallLetterf of Latin_Small_Letter_f

    member this.as_rune =
        match this with
        | FromDIGIT digit -> digit.as_rune
        | FromLatinCapitalLetterA x -> x.as_rune
        | FromLatinCapitalLetterB x -> x.as_rune
        | FromLatinCapitalLetterC x -> x.as_rune
        | FromLatinCapitalLetterD x -> x.as_rune
        | FromLatinCapitalLetterE x -> x.as_rune
        | FromLatinCapitalLetterF x -> x.as_rune
        | FromLatinSmallLettera x -> x.as_rune
        | FromLatinSmallLetterb x -> x.as_rune
        | FromLatinSmallLetterc x -> x.as_rune
        | FromLatinSmallLetterd x -> x.as_rune
        | FromLatinSmallLettere x -> x.as_rune
        | FromLatinSmallLetterf x -> x.as_rune

    static member parse: Parser<HEXDIGIT, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [ DIGIT.parse |>> FromDIGIT
                      Latin_Capital_Letter_A.parse
                      |>> FromLatinCapitalLetterA
                      Latin_Capital_Letter_B.parse
                      |>> FromLatinCapitalLetterB
                      Latin_Capital_Letter_C.parse
                      |>> FromLatinCapitalLetterC
                      Latin_Capital_Letter_D.parse
                      |>> FromLatinCapitalLetterD
                      Latin_Capital_Letter_E.parse
                      |>> FromLatinCapitalLetterE
                      Latin_Capital_Letter_F.parse
                      |>> FromLatinCapitalLetterF
                      Latin_Small_Letter_a.parse
                      |>> FromLatinSmallLettera
                      Latin_Small_Letter_b.parse
                      |>> FromLatinSmallLetterb
                      Latin_Small_Letter_c.parse
                      |>> FromLatinSmallLetterc
                      Latin_Small_Letter_d.parse
                      |>> FromLatinSmallLetterd
                      Latin_Small_Letter_e.parse
                      |>> FromLatinSmallLettere
                      Latin_Small_Letter_f.parse
                      |>> FromLatinSmallLetterf ])
            """ HEXDIG         =  DIGIT / "A" / "B" / "C" / "D" / "E" / "F" / "a" / "b" / "c" / "d" / "e" / "f" """

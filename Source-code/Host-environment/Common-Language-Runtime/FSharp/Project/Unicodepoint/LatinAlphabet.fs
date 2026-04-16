module Unicodepoint.LatinAlphabet
open System
open System.Text
open System.IO
open System.Globalization



open XParsec
open XParsec.Parsers

open Ergonomics.XParsecErgonomics


type Latin_Capital_Letter_A =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_A, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'A' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_B =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_B, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'B' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_C =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_C, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'C' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_D =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_D, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'D' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_E =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_E, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'E' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_F =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_F, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'F' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_G =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_G, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'G' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_H =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_H, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'H' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_I =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_I, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'I' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_J =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_J, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'J' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_K =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_K, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'K' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_L =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_L, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'L' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_M =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_M, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'M' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_N =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_N, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'N' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_O =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_O, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'O' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_P =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_P, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'P' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_Q =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_Q, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'Q' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_R =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_R, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'R' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_S =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_S, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'S' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_T =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_T, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'T' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_U =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_U, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'U' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_V =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_V, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'V' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_W =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_W, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'W' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_X =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_X, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'X' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_Y =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_Y, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'Y' |>> fun rune -> { as_rune = rune }

type Latin_Capital_Letter_Z =
    { as_rune: Rune }
    static member parse: Parser<Latin_Capital_Letter_Z, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'Z' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_a =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_a, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'a' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_b =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_b, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'b' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_c =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_c, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'c' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_d =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_d, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'd' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_e =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_e, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'e' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_f =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_f, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'f' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_g =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_g, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'g' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_h =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_h, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'h' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_i =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_i, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'i' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_j =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_j, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'j' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_k =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_k, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'k' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_l =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_l, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'l' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_m =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_m, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'm' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_n =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_n, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'n' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_o =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_o, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'o' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_p =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_p, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'p' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_q =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_q, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'q' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_r =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_r, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'r' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_s =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_s, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 's' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_t =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_t, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 't' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_u =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_u, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'u' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_v =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_v, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'v' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_w =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_w, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'w' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_x =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_x, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'x' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_y =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_y, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'y' |>> fun rune -> { as_rune = rune }

type Latin_Small_Letter_z =
    { as_rune: Rune }
    static member parse: Parser<Latin_Small_Letter_z, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune 'z' |>> fun rune -> { as_rune = rune }

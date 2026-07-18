module DoxAletheia.ParserCombinator.Data
open System
open System.Buffers
open System.Text
open CommunityToolkit.HighPerformance.Buffers

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics
open LightningDB
open Blake3
open BitFaster.Caching
open BitFaster.Caching.Lfu
open FSharp.Configuration


open XParsec
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range


let string_pool = StringPool.Shared
module String_Pool = 

    let from_code_line
        (code_line: Code_Line)
        : string =

        // Every Unicode scalar requires either one or two UTF-16 code units.
        let char_buffer =
            ArrayPool<char>.Shared.Rent(code_line.Length * 2)

        try
            let mutable char_count = 0

            for code_point in code_line do
                let rune = Rune(code_point)

                char_count <-
                    char_count
                    + rune.EncodeToUtf16(
                        char_buffer.AsSpan(char_count)
                    )

            string_pool.GetOrAdd(
                ReadOnlySpan<char>(
                    char_buffer,
                    0,
                    char_count
                )
            )
        finally
            ArrayPool<char>.Shared.Return(char_buffer)


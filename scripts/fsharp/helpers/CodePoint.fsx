#if INTERACTIVE

#endif

module CodePoint =
    open System
    open System.Text
    open FParsec


    let isHighSurrogate (c: char) = Char.IsHighSurrogate(c)
    let isLowSurrogate (c: char) = Char.IsLowSurrogate(c)
    let isSurrogate (c: char) = Char.IsSurrogate(c)

    // RFC 8259: unescaped = %x20-21 / %x23-5B / %x5D-10FFFF
    // We implement it over code points (scalars).

    // Encode a Unicode scalar value (code point) into UTF-16 text.
    let encodeScalarToUtf16 (cp: int) : string =
        // .NET: ConvertFromUtf32 converts a Unicode code point into a UTF-16 encoded string.
        // (It emits 1 char for BMP, 2 chars for supplementary.)
        Char.ConvertFromUtf32(cp)

    let toString (codePoints: int list) : string =
        // Preserve explicitness; StringBuilder avoids quadratic concatenation.
        let sb = StringBuilder()

        for cp in codePoints do
            sb.Append(encodeScalarToUtf16 cp) |> ignore

        sb.ToString()

    let isHighSurrogateCodeUnit (u: int) = 0xD800 <= u && u <= 0xDBFF
    let isLowSurrogateCodeUnit (u: int) = 0xDC00 <= u && u <= 0xDFFF
    let isSurrogateCodeUnit (u: int) = 0xD800 <= u && u <= 0xDFFF

    // Combine a UTF-16 surrogate pair (as 16-bit values) into a scalar.
    let yokeSurrogates (hi: int) (lo: int) : int =
        // Convert via chars to reuse .NET's logic.
        let hiChar = char hi
        let loChar = char lo
        Char.ConvertToUtf32(hiChar, loChar)

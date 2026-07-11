namespace Grammar
#if INTERACTIVE

#endif

module AugmentedBackusNaurForm =
    open System
    open System.Globalization
    open System.Text
    open FParsec

    // Parses a single hex segment (e.g., "5B" or "74") into a single UTF-16 code unit char.
    // This is the shared core used by both terminalValue and concatenatedValue.
    let private terminalValueSegment (hexDigitSpan: ReadOnlySpan<char>) : char =
        if hexDigitSpan.Length = 0 then
            raise (ArgumentException("ABNF hex segment was empty."))

        let mutable n = 0

        if not (Int32.TryParse(hexDigitSpan, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, &n)) then
            raise (ArgumentException($"ABNF hex segment '{hexDigitSpan.ToString()}' has invalid hex digits."))

        if n < 0 || n > 0xFFFF then
            raise (
                ArgumentException(
                    $"ABNF hex segment '{hexDigitSpan.ToString()}' denotes U+{n:X}, which cannot fit in a single UTF-16 code unit."
                )
            )

        if 0xD800 <= n && n <= 0xDFFF then
            raise (
                ArgumentException(
                    $"ABNF hex segment '{hexDigitSpan.ToString()}' denotes U+{n:X}, which is a surrogate code unit and not a Unicode scalar value."
                )
            )

        char n

    // Your existing single-value helper, now implemented in terms of terminalValueSegment.
    let terminalValue (terminalValueStringLiteral: string) : char =
        if isNull terminalValueStringLiteral then
            raise (ArgumentException("ABNF token text was null.", nameof terminalValueStringLiteral))

        if terminalValueStringLiteral.Length < 3 then
            raise (
                ArgumentException(
                    $"ABNF token '{terminalValueStringLiteral}' is too short. Expected 'x' + 1+ hex digits.",
                    nameof terminalValueStringLiteral
                )
            )

        if terminalValueStringLiteral.[0] <> '%' || terminalValueStringLiteral.[1] <> 'x' then
            raise (
                ArgumentException(
                    $"ABNF token '{terminalValueStringLiteral}' must start with 'x'.",
                    nameof terminalValueStringLiteral
                )
            )

        let hexSpan = terminalValueStringLiteral.AsSpan(2)
        terminalValueSegment hexSpan

    /// ABNF concatenated hex numeric terminals like "%x74.72.75.65" -> "true".
    let concatenatedValue (concatenatedValueStringLiteral: string) : string =
        if isNull concatenatedValueStringLiteral then
            raise (ArgumentException("ABNF token text was null.", nameof concatenatedValueStringLiteral))

        if concatenatedValueStringLiteral.Length < 3 then
            raise (
                ArgumentException(
                    $"ABNF token '{concatenatedValueStringLiteral}' is too short. Expected 'x' + 1+ hex digits (optionally dot-separated).",
                    nameof concatenatedValueStringLiteral
                )
            )

        if
            concatenatedValueStringLiteral.[0] <> '%'
            || concatenatedValueStringLiteral.[1] <> 'x'
        then
            raise (
                ArgumentException(
                    $"ABNF token '{concatenatedValueStringLiteral}' must start with 'x'.",
                    nameof concatenatedValueStringLiteral
                )
            )

        let payloadSpan = concatenatedValueStringLiteral.AsSpan(2)

        if payloadSpan.Length = 0 then
            raise (
                ArgumentException(
                    $"ABNF token '{concatenatedValueStringLiteral}' has no hex digits after 'x'.",
                    nameof concatenatedValueStringLiteral
                )
            )

        // Split payload on '.' without allocating intermediate arrays.
        let builder = StringBuilder()

        let mutable segmentStartIndex = 0

        for i = 0 to payloadSpan.Length do
            let isAtEnd = (i = payloadSpan.Length)
            let isDot = (not isAtEnd && payloadSpan.[i] = '.')

            if isAtEnd || isDot then
                let segmentLength = i - segmentStartIndex

                if segmentLength = 0 then
                    raise (
                        ArgumentException(
                            $"ABNF token '{concatenatedValueStringLiteral}' contains an empty segment (e.g., '..' or trailing '.').",
                            nameof concatenatedValueStringLiteral
                        )
                    )

                let segmentSpan = payloadSpan.Slice(segmentStartIndex, segmentLength)
                let ch = terminalValueSegment segmentSpan
                builder.Append(ch) |> ignore

                segmentStartIndex <- i + 1

        builder.ToString()

    /// Parse a single hex segment (e.g., "20" or "10FFFF") into an Int32.
    let private terminalInt32Segment (hexDigitSpan: ReadOnlySpan<char>) : int =
        if hexDigitSpan.Length = 0 then
            raise (ArgumentException("ABNF hex segment was empty."))

        let mutable n = 0

        if not (Int32.TryParse(hexDigitSpan, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, &n)) then
            raise (ArgumentException($"ABNF hex segment '{hexDigitSpan.ToString()}' has invalid hex digits."))

        n

    /// ABNF BMP range parser: parses a single UTF-16 code unit char whose numeric value is in the inclusive range.
    /// Token form required: "%x<HEXDIG+>-<HEXDIG+>" (e.g., "%x20-21", "%x5D-10FFFF").
    ///
    /// Behavior:
    /// - Parses the two hex endpoints as integers.
    /// - Clamps the upper endpoint to 0xFFFF (BMP ceiling), by design.
    /// - Rejects negative endpoints and rejects lo > hiAfterClamp.
    /// - Returns a Parser<char,'u> that consumes one char satisfying the range.
    let rangeBmp (rangeTokenText: string) : Parser<char, 'u> =
        if isNull rangeTokenText then
            raise (ArgumentException("ABNF token text was null.", nameof rangeTokenText))

        if rangeTokenText.Length < 5 then
            // Minimum plausible: "%x0-0" is length 5
            raise (
                ArgumentException(
                    $"ABNF range token '{rangeTokenText}' is too short. Expected 'x' + HEX + '-' + HEX.",
                    nameof rangeTokenText
                )
            )

        if rangeTokenText.[0] <> '%' || rangeTokenText.[1] <> 'x' then
            raise (
                ArgumentException($"ABNF range token '{rangeTokenText}' must start with 'x'.", nameof rangeTokenText)
            )

        let payloadSpan = rangeTokenText.AsSpan(2)

        // Find the '-' separator (required for ranges)
        let dashIndex = payloadSpan.IndexOf('-')

        if dashIndex < 0 then
            raise (
                ArgumentException(
                    $"ABNF range token '{rangeTokenText}' must contain '-' to separate endpoints.",
                    nameof rangeTokenText
                )
            )

        let loSpan = payloadSpan.Slice(0, dashIndex)
        let hiSpan = payloadSpan.Slice(dashIndex + 1)

        if loSpan.Length = 0 || hiSpan.Length = 0 then
            raise (
                ArgumentException(
                    $"ABNF range token '{rangeTokenText}' must have hex digits on both sides of '-'.",
                    nameof rangeTokenText
                )
            )

        let lo = terminalInt32Segment loSpan
        let hiRaw = terminalInt32Segment hiSpan

        if lo < 0 || hiRaw < 0 then
            raise (
                ArgumentException(
                    $"ABNF range token '{rangeTokenText}' must not contain negative endpoints.",
                    nameof rangeTokenText
                )
            )

        // Explicit BMP clamp (by contract)
        let hi = if hiRaw > 0xFFFF then 0xFFFF else hiRaw

        if lo > hi then
            raise (
                ArgumentException(
                    $"ABNF range token '{rangeTokenText}' has lo > hi after BMP clamp (lo=0x{lo:X}, hi=0x{hi:X}).",
                    nameof rangeTokenText
                )
            )

        // Build the predicate over runtime UTF-16 code units (char)
        let predicate (c: char) =
            let n = int c
            lo <= n && n <= hi

        satisfyL predicate rangeTokenText

    /// Public: ABNF single terminal (e.g. "%x5B") as Parser<char, 'u>.
    let abnfTerminal (tokenText: string) : Parser<char, 'u> = pchar (terminalValue tokenText)

    let skippedTerminal (tokenText: string) : Parser<unit, 'u> =
        skipMany1 (pchar (terminalValue tokenText))

    /// Public: ABNF concatenation (e.g. "%x74.72.75.65") as Parser<string, 'u>.
    let abnfConcatenatedTerminal (tokenText: string) : Parser<string, 'u> = pstring (concatenatedValue tokenText)

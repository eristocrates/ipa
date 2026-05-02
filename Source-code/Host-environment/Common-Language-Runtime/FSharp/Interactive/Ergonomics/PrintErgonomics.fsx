[<RequireQualifiedAccess>]
type Format_Specifier =

    /// "bool ( System.Boolean )","Formatted as true or false"
    | b
    /// "string ( System.String )","Formatted as its unescaped contents"
    | s
    /// "char ( System.Char )","Formatted as the character literal"
    | c
    /// "a basic integer type","Formatted as a decimal integer, signed if the basic integer type is signed"
    | d
    /// "a basic integer type","Formatted as a decimal integer, signed if the basic integer type is signed"
    | i
    /// "a basic integer type","Formatted as an unsigned decimal integer"
    | u
    /// "a basic integer type","Formatted as an unsigned hexadecimal number (a-f or A-F for hex digits respectively)"
    | x
    /// "a basic integer type","Formatted as an unsigned hexadecimal number (a-f or A-F for hex digits respectively)"
    | X
    /// "a basic integer type","Formatted as an unsigned octal number"
    | o
    /// "a basic integer type","Formatted as an unsigned binary number"
    | B
    /// "a basic floating point type","Formatted as a signed value having the form [-]d.dddde[sign]ddd where d is a single decimal digit, dddd is one or more decimal digits, ddd is exactly three decimal digits, and sign is + or -"
    | e
    /// "a basic floating point type","Formatted as a signed value having the form [-]d.dddde[sign]ddd where d is a single decimal digit, dddd is one or more decimal digits, ddd is exactly three decimal digits, and sign is + or -"
    | E
    /// "a basic floating point type","Formatted as a signed value having the form [-]dddd.dddd , where dddd is one or more decimal digits. The number of digits before the decimal  point depends on the magnitude of the number, and the number of digits  after the decimal point depends on the requested precision."
    | f
    /// "a basic floating point type","Formatted as a signed value having the form [-]dddd.dddd , where dddd is one or more decimal digits. The number of digits before the decimal  point depends on the magnitude of the number, and the number of digits  after the decimal point depends on the requested precision."
    | F
    /// "a basic floating point type","Formatted using as a signed value printed in %f or %e format, whichever is more compact for the given value and precision."
    | g
    /// "a basic floating point type","Formatted using as a signed value printed in %f or %e format, whichever is more compact for the given value and precision."
    | G
    /// "a decimal ( System.Decimal ) value","Formatted using the ""G"" format specifier for System.Decimal.ToString(format)"
    | M
    /// "any value","Formatted by boxing the object and calling its System.Object.ToString() method"
    | O
    /// "any value","Formatted using structured plain text formatting with the default layout settings"
    | A
    /// "any value","Requires two arguments: a formatting function accepting a context parameter and the value, and the particular value to print"
    | a
    /// "any value","Requires one argument: a formatting function accepting a context parameter that either outputs or returns the appropriate text"
    | t

[<RequireQualifiedAccess>]
type Format_Flag =
    /// Add zeros instead of spaces to make up the required width
    | zero
    /// Left justify the result within the specified width
    | hyphen_minus
    /// Add a + character if the number is positive (to match a - sign for negatives)
    | plus_sign
    /// Add an extra space if the number is positive (to match a '-' sign for negatives)
    | space

type Format_Width =
    | Fixed_Width of int
    | Dynamic_Width

type Format_Precision =
    | Fixed_Precision of int
    | Dynamic_Precision
    | Zero_Precision


type Plain_Text_Format =
    { format_flags: Set<Format_Flag>
      format_width: Format_Width option
      format_precision: Format_Precision option
      format_specifier: Format_Specifier }

[<Literal>]
let test_format = "%10A"

printfn test_format [| for i in 1..5 -> (i, i * i) |]

open System.Runtime.InteropServices

[<Struct; StructLayout(LayoutKind.Sequential)>]
type FILE_ID_128 =
    val mutable Byte0: byte
    val mutable Byte1: byte
    val mutable Byte2: byte
    val mutable Byte3: byte
    val mutable Byte4: byte
    val mutable Byte5: byte
    val mutable Byte6: byte
    val mutable Byte7: byte
    val mutable Byte8: byte
    val mutable Byte9: byte
    val mutable Byte10: byte
    val mutable Byte11: byte
    val mutable Byte12: byte
    val mutable Byte13: byte
    val mutable Byte14: byte
    val mutable Byte15: byte

    member x.ToArray() =
        [| x.Byte0
           x.Byte1
           x.Byte2
           x.Byte3
           x.Byte4
           x.Byte5
           x.Byte6
           x.Byte7
           x.Byte8
           x.Byte9
           x.Byte10
           x.Byte11
           x.Byte12
           x.Byte13
           x.Byte14
           x.Byte15 |]

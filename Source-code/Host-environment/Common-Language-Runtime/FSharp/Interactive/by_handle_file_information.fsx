open System
open System.IO
open System.Runtime.InteropServices
open Microsoft.Win32.SafeHandles

[<Struct; StructLayout(LayoutKind.Sequential)>]
type FILETIME =
    val mutable dwLowDateTime: uint32
    val mutable dwHighDateTime: uint32

[<Struct; StructLayout(LayoutKind.Sequential)>]
type BY_HANDLE_FILE_INFORMATION =
    val mutable dwFileAttributes: uint32
    val mutable ftCreationTime: FILETIME
    val mutable ftLastAccessTime: FILETIME
    val mutable ftLastWriteTime: FILETIME
    val mutable dwVolumeSerialNumber: uint32
    val mutable nFileSizeHigh: uint32
    val mutable nFileSizeLow: uint32
    val mutable nNumberOfLinks: uint32
    val mutable nFileIndexHigh: uint32
    val mutable nFileIndexLow: uint32

module Native =
    [<DllImport("kernel32.dll", SetLastError = true)>]
    extern bool GetFileInformationByHandle(
        SafeFileHandle hFile,
        byref<BY_HANDLE_FILE_INFORMATION> lpFileInformation
    )


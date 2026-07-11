open System
open System.IO
open System.Runtime.InteropServices
open Microsoft.Win32.SafeHandles

#load "minwinbase.fsx"
open Minwinbase
#load "winnt.fsx"
open Winnt

[<Struct; StructLayout(LayoutKind.Sequential)>]
type FILE_ID_INFO =
    val mutable VolumeSerialNumber: uint64
    val mutable FileId: FILE_ID_128



[<DllImport("kernel32.dll", SetLastError = true)>]
extern bool GetFileInformationByHandleEx(SafeFileHandle hFile, FILE_INFO_BY_HANDLE_CLASS fileInformationClass, nativeint lpFileInformation, uint32 dwBufferSize)

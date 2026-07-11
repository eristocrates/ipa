open System
open System.IO
open System.Runtime.InteropServices
open Microsoft.Win32.SafeHandles

[<StructLayout(LayoutKind.Sequential)>]
type BY_HANDLE_FILE_INFORMATION =
    struct
        val dwFileAttributes: uint32
        val ftCreationTimeLow: uint32
        val ftCreationTimeHigh: uint32
        val ftLastAccessTimeLow: uint32
        val ftLastAccessTimeHigh: uint32
        val ftLastWriteTimeLow: uint32
        val ftLastWriteTimeHigh: uint32
        val dwVolumeSerialNumber: uint32
        val nFileSizeHigh: uint32
        val nFileSizeLow: uint32
        val nNumberOfLinks: uint32
        val nFileIndexHigh: uint32
        val nFileIndexLow: uint32
    end

[<DllImport("kernel32.dll", SetLastError = true)>]
extern bool GetFileInformationByHandle(SafeFileHandle hFile, BY_HANDLE_FILE_INFORMATION& lpFileInformation)

let getFileReferenceNumber (path: string) : uint64 =
    use fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
    let mutable info = Unchecked.defaultof<BY_HANDLE_FILE_INFORMATION>

    let ok = GetFileInformationByHandle(fs.SafeFileHandle, &info)

    if not ok then
        raise (System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error()))

    (uint64 info.nFileIndexHigh <<< 32) ||| uint64 info.nFileIndexLow

let frn = getFileReferenceNumber @"C:\rdfsharp\surfaces\examples\example.json"

open System
open System.IO
open System.Runtime.InteropServices
open Microsoft.Win32.SafeHandles

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Microsoft\Windows\API"
#load @"Headers\winbase.fsx"
#load @"Technologies\Desktop_Technologies\Data_Access_and_Storage\Local_file_systems\File_Management\GetFileInformation.fsx"

open GetFileInformation
open Winnt
open Minwinbase
open Winbase

// https://learn.microsoft.com/en-us/windows/win32/fileio/file-systems



/// A volume is a collection of directories and files.
type Logical_Volume =
    {

      serial_number: uint64

     }

/// A directory is a hierarchical collection of directories and files.
type Logical_Directory = { absolute_path: string }

/// A file is a logical grouping of related data.
type Logical_File =
    {

      absolute_path: string
      id: FILE_ID_128
      volume: Logical_Volume

     }
    member this.branch_extension(new_extension: string) =
        Path.ChangeExtension(this.absolute_path, new_extension)

    member this.directory = Path.GetDirectoryName this.absolute_path
    member this.stem = Path.GetFileNameWithoutExtension this.absolute_path
    member this.file_extension = (Path.GetExtension this.absolute_path)[1..]
    member this.id_byte_array() = this.id.ToArray()

    member this.id_hex() =
        BitConverter
            .ToString(this.id_byte_array ())
            .Replace("-", "")

    static member inhabitant(file_path: string) =
        use fs =
            new FileStream(file_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite ||| FileShare.Delete)

        let size = Marshal.SizeOf<FILE_ID_INFO>()
        let buffer = Marshal.AllocHGlobal(size)

        try
            let ok =
                GetFileInformation.ByHandleEx(
                    fs.SafeFileHandle,
                    FILE_INFO_BY_HANDLE_CLASS.FileIdInfo,
                    buffer,
                    uint32 size
                )

            if not ok then
                let err = Marshal.GetLastWin32Error()
                failwithf "GetFileInformationByHandleEx failed. Win32 error = %d" err

            let info = Marshal.PtrToStructure<FILE_ID_INFO>(buffer)

            {

              absolute_path = file_path
              id = info.FileId
              volume = { serial_number = info.VolumeSerialNumber }

            }


        finally
            Marshal.FreeHGlobal(buffer)



[<RequireQualifiedAccessAttribute>]
type File_System_Component =
    | Volume of Logical_Volume
    | Directory of Logical_Directory
    | File of (string -> Logical_File)





module java =
    let cmd =
        Logical_File.inhabitant
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Shell\Powershell\java.cmd"

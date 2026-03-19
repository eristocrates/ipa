// extract-all-icons.fsx
//
// Run:
//   dotnet fsi extract-all-icons.fsx "C:\Path\To\App.exe"
//   dotnet fsi extract-all-icons.fsx "C:\Path\To\App.exe" "C:\Temp\AppIcons"
//
// Outputs (per icon-group index):
//   <outDir>\<exeBase>.icon000.ico
//   <outDir>\<exeBase>.icon000.png
//   ...

#r "nuget: System.Drawing.Common, 8.0.0"

open System
open System.IO
open System.Runtime.InteropServices
open System.Drawing
open System.Drawing.Imaging

module Native =
    [<DllImport("shell32.dll", CharSet = CharSet.Unicode)>]
    extern uint32 ExtractIconEx(string lpszFile, int nIconIndex, IntPtr [] phiconLarge, IntPtr [] phiconSmall, uint32 nIcons)

    [<DllImport("user32.dll")>]
    extern bool DestroyIcon(IntPtr hIcon)

let printUsage () =
    let scriptName =
        try
            Path.GetFileName(fsi.CommandLineArgs.[0])
        with
        | _ -> "exe2ico.fsx"

    printfn "Usage:"
    printfn "  %s <path-to-exe-or-dll> [output-directory]" scriptName
    printfn ""
    printfn "Examples:"
    printfn "  %s \"C:\\Path\\To\\App.exe\"" scriptName
    printfn "  %s \"C:\\Path\\To\\App.exe\" \"C:\\Temp\\AppIcons\"" scriptName

let exePath: string =
    if fsi.CommandLineArgs.Length > 1 then
        fsi.CommandLineArgs.[1]
    else
        printUsage ()
        Environment.Exit(2)
        String.Empty // unreachable in practice, but keeps the type-checker satisfied

let outDir: string =
    if fsi.CommandLineArgs.Length > 2 then
        fsi.CommandLineArgs.[2]
    else
        let baseName = Path.GetFileNameWithoutExtension(exePath)
        Path.Combine(Path.GetDirectoryName(exePath), baseName + ".icons")

Directory.CreateDirectory(outDir) |> ignore

let exeBase: string = Path.GetFileNameWithoutExtension(exePath)

let getIconCount (path: string) : int =
    // Convention: nIconIndex = -1 returns number of icon groups.
    let dummyLarge: IntPtr [] = Array.zeroCreate 1
    let dummySmall: IntPtr [] = Array.zeroCreate 1
    int (Native.ExtractIconEx(path, -1, dummyLarge, dummySmall, 0u))

let saveIconIndex (path: string) (index: int) : unit =
    let large: IntPtr [] = Array.zeroCreate 1
    let small: IntPtr [] = Array.zeroCreate 1

    let extracted: uint32 = Native.ExtractIconEx(path, index, large, small, 1u)

    if extracted = 0u
       || (large.[0] = IntPtr.Zero && small.[0] = IntPtr.Zero) then
        printfn "Index %d: no icon handle returned." index
    else
        // Prefer large handle, else small.
        let hIcon: IntPtr =
            if large.[0] <> IntPtr.Zero then
                large.[0]
            else
                small.[0]

        // Wrap, clone, then destroy native handles.
        let cloned: Icon =
            use tmp: Icon = Icon.FromHandle(hIcon)
            tmp.Clone() :?> Icon

        // Free native handles to avoid GDI leaks.
        if large.[0] <> IntPtr.Zero then
            Native.DestroyIcon(large.[0]) |> ignore

        if small.[0] <> IntPtr.Zero then
            Native.DestroyIcon(small.[0]) |> ignore

        let stem = sprintf "%s.icon%03d" exeBase index
        let icoPath = Path.Combine(outDir, stem + ".ico")
        let pngPath = Path.Combine(outDir, stem + ".png")

        use icoStream =
            File.Open(icoPath, FileMode.Create, FileAccess.Write, FileShare.None)

        cloned.Save(icoStream)

        use bmp: Bitmap = cloned.ToBitmap()
        bmp.Save(pngPath, ImageFormat.Png)

        cloned.Dispose()

        printfn "Index %d: wrote %s and %s" index icoPath pngPath

let count: int = getIconCount exePath
printfn "Found %d icon group(s) in: %s" count exePath
printfn "Output directory: %s" outDir

for i in 0 .. (count - 1) do
    saveIconIndex exePath i

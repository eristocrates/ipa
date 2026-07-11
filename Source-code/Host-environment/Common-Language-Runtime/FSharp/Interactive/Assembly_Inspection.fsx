open System
open System.Reflection

let assemblyPath =
    @"C:\Repositories\appsdb\IPS_Sites\integration\CrystalReports\bin\Debug\net472\log4net.dll"

let inspectAssembly path =
    let name = AssemblyName.GetAssemblyName(path)

    printfn "FullName: %s" name.FullName
    printfn "Name: %s" name.Name
    printfn "Version: %O" name.Version

    printfn
        "CultureName: %s"
        (if isNull name.CultureName then
             ""
         else
             name.CultureName)

    let publicKeyToken =
        name.GetPublicKeyToken()
        |> Array.map (fun b -> b.ToString("x2"))
        |> String.concat ""

    printfn "PublicKeyToken: %s" publicKeyToken

inspectAssembly assemblyPath

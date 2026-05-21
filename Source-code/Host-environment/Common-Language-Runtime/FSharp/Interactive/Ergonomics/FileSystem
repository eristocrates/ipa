open System
open System.IO

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PathErgonomics.fsx"
open PathErgonomics
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\FsharpErgonomics.fsx"
open FsharpErgonomics

let targetDirectoryPathsStrings =
    [|

       @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices"
       @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\LCG_Stormwater_Inventory_updated"

       |]

let targetFilePathStrings =
    [|

       @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices\Core\Security\Hansen.Core.Security.Login.asmx"
       @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData\MetaData.xml"

       |]


let SurfaceRootDirectoryPath = DirectoryPath_from_string @"D:\Surface"
let ArtifactRootDirectoryPath = DirectoryPath_from_string @"D:\Artifact"



let targetFilePaths =
    targetFilePathStrings
    |> Array.Parallel.map FilePath_from_string

let testFilePathString =
    @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices\Core\Security\Hansen.Core.Security.Login.asmx"

let driveTest = Directory.GetDirectoryRoot testFilePathString
let testFilePath = FilePath_from_string testFilePathString
inspectObjectExpression testFilePath

let rec ancestorDirectoryPaths_from_DirectoryPath
    (currentDirectoryPath: DirectoryPath)
    (anchorDirectoryPath: DirectoryPath)
    (ancestorDirectoryPaths: DirectoryPath list)
    =
    if currentDirectoryPath.directoryName = anchorDirectoryPath.directoryName then
        ancestorDirectoryPaths
    else
        let parentDirectoryPath =
            DirectoryPath_from_string currentDirectoryPath.parentDirectoryPathString

        ancestorDirectoryPaths_from_DirectoryPath
            parentDirectoryPath
            anchorDirectoryPath
            (parentDirectoryPath :: ancestorDirectoryPaths)

let ancestorDirectoryPaths_from_FilePath (filePath: FilePath) (anchorDirectoryPath: DirectoryPath) =
    ancestorDirectoryPaths_from_DirectoryPath
        (DirectoryPath_from_string filePath.directoryPathString)
        anchorDirectoryPath
        []

let testAncestorPaths =
    ancestorDirectoryPaths_from_FilePath testFilePath SurfaceRootDirectoryPath

testAncestorPaths
|> List.iter inspectObjectExpression

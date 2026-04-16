(*

fsi.ShowDeclarationValues <- false
//fsi.ShowDeclarationValues <- true


#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"

open Fabulous.AST
open Fabulous.AST.Json

open type Fabulous.AST.Ast
open Fantomas.FCS.Text

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Json"

open FSharp.Data
open FSharp.Data.Json

#load @"C:\Repositories\appsdb\IPS_Sites\integration\PathIdentification\PathIdentification.fsx"
open PathIdentification

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\FsharpErgonomics.fsx"

open FsharpErgonomics
*)

open System
open System.Reflection
open System.Text
open System.IO

#r "nuget: Yog.FSharp"

open Yog.Model
open Yog.Builder.Labeled
open Yog.IO
open Yog.Pathfinding.Dijkstra



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\GraphErgonomics.fsx"

open GraphErgonomics
open Turtle
open IRI

// TODO figure out if all directories should just be their own namespace?
let default_context = directed<Turtle_IRI, Turtle_IRI> ()
// |> subject_predicate_object_context example.Alice example.knows example.Bob
// |> subjects_predicate_object_context [ example.Alice; example.Bob ] example.knows example.Charlie
let default_graph = default_context |> toGraph

let LocalPathsDirectoryPath = Path.Combine(__SOURCE_DIRECTORY__, "LocalPaths")


// TODO handle file paths terminating with A module for stemPath for stem , and a let binding for the extension, nesting per section if there's more than one period

(*

                                            module MetaData =
                                                let stemPath =
                                                    @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData\MetaData.xml"

                                                module xml =
                                                    let filePath =
                                                        @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData\MetaData.xml"


let SurfacePath = LocalPath.inhabitant { absolutePath = SurfaceRootDirectoryPath }

let leafPathStrings =
    [

      @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices"
      // @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData\MetaData.xml"
      @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData"
      @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\LCG_Stormwater_Inventory_updated"

      ]








let leafPaths =
    leafPathStrings
    |> List.map (fun pathString ->

        LocalPath.inhabitant { absolutePath = pathString }

    )

let testPath = leafPaths[0]
testPath.SegmentTokensFromRootDirectory SurfaceRootDirectoryPath

let branchPaths (rootPathString: string) =
    leafPaths
    |> List.collect (fun leafPath ->

        leafPath.AncestorDirectories rootPathString [ leafPath ])



let treePaths =
    leafPaths @ branchPaths (SurfaceRootDirectoryPath)
    |> List.toSeq



let randomPath = treePaths |> Seq.randomChoice


let childPathStringsFromParentPathString (parentPathString: string) =
    let childPaths =
        treePaths
        |> Seq.choose (fun localPath ->

            if localPath.ParentDirectory.FullName = parentPathString then
                Some(localPath)
            else
                None

        )
        |> Seq.toArray

    if childPaths.Length > 0 then
        childPaths
        |> Array.map (fun localPath -> localPath.FullName)
        |> Array.distinct
    else
        [||]





let SurfacePathStrings =
    childPathStringsFromParentPathString SurfaceRootDirectoryPath

let childPaths =
    SurfacePathStrings
    |> Array.map (fun childPathString ->

        treePaths
        |> Seq.find (fun path -> path.FullName = childPathString)

    )













let rec treeModule (childPathStrings: string array) (replacementRootDirectoryPath: string) =
    let childPaths =
        childPathStrings
        |> Array.map (fun childPathString ->

            treePaths
            |> Seq.find (fun localPath -> localPath.FullName = childPathString)

        )

    childPaths
    |> Array.map (fun childPath ->




        Module(childPath.Name) {

            Value(
                "directoryPath",
                ConstantExpr(
                    VerbatimString(
                        childPath.OriginalString.Replace(SurfaceRootDirectoryPath, replacementRootDirectoryPath)
                    )
                )
            )
            // TODO find some way to make paths available for type provider consumption without shadowing nested paths
            // .attribute (Attribute("Literal"))

            for nestedModule in
                treeModule (childPathStringsFromParentPathString childPath.OriginalString) replacementRootDirectoryPath do
                nestedModule


        })





type LocalFileSystemOakTemplate =

    {

      name: string
      directoryPath: string

     }
    member this.asFsx =
        Oak() {
            AnonymousModule() {
                Module(this.name) {

                    Value("directoryRootPath", ConstantExpr(VerbatimString(this.directoryPath)))
                    let childModules = treeModule SurfacePathStrings this.directoryPath

                    for nestedChildModule in childModules do
                        nestedChildModule

                }


            }

        }
        |> Gen.mkOak
        |> Gen.run

    member this.saveFsx =
        File.WriteAllText(Path.Combine(LocalPathsDirectoryPath, $"{this.name}Paths.fsx"), this.asFsx)

let SurfaceTemplate =
    {

      name = "Surface"
      directoryPath = SurfaceRootDirectoryPath

    }

let ArtifactTemplate =
    {

      name = "Artifact"
      directoryPath = ArtifactRootDirectoryPath

    }


SurfaceTemplate.saveFsx
ArtifactTemplate.saveFsx


//

// childPathStringsFromParentPathString
*)

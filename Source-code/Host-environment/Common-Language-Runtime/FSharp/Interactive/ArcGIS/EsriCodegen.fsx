#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- true

open System
open System.IO
open System
open System.IO
open System.Reflection
open System.Text.RegularExpressions
open System.Reflection
open System.Reflection.Emit
open Microsoft.FSharp.Reflection
#r "nuget: Fabulous.AST"
open Fabulous.AST
open Fantomas.Core


#r "nuget: Esri.ArcGISRuntime, 300.0.0"

open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Mapping
open Esri.ArcGISRuntime.ArcGISServices

#r "nuget: FsExcel"
open FsExcel
#r "nuget: TypeShape"
open TypeShape.Core
#r "nuget: FSharp.Compiler.Service, 43.10.102"
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Symbols
open FSharp.Compiler.Text

#r "nuget: CaseConverter"
open CaseConverter
#r "nuget: PolyType"
open PolyType
open PolyType.ReflectionProvider
open PolyType
open PolyType.Abstractions
open PolyType.ReflectionProvider

module interraster = 
    module Catalog = 

        module MapServices = 
            let _namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/"
            module LCPW_OverlayStormwaterInfrastructure_D_WM =
                // let pjson = JsonProvider<"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson">.Load "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson"
                let MapServer =
                        ArcGISMapImageLayer(Uri( "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer" ))
        
        
open interraster.Catalog.MapServices.LCPW_OverlayStormwaterInfrastructure_D_WM

MapServer.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously



let checker = FSharpChecker.Create()



MapServer.GetType().GetProperties()
MapServer.ServiceInfo







MapServer.Sublayers



let random_layer = 
  MapServer.Sublayers
  |> Seq.toArray
  |> Array.randomSample 1 
  |> Array.map (fun layer -> layer :?> ArcGISMapImageSublayer)
  |> Array.head






type Type_Shape = 
  {
      Shape_Enum: IShapeEnum array
      Shape_Equality: IShapeEquality array
      Shape_Comparison: IShapeComparison array
      Shape_DefaultConstructor: IShapeDefaultConstructor array
      Shape_KeyValuePair: IShapeKeyValuePair array
      Shape_Dictionary: IShapeDictionary array
      Shape_HashSet: IShapeHashSet array
      Shape_ResizeArray: IShapeResizeArray array
      Shape_Delegate: IShapeDelegate array
      Shape_Exception: IShapeException array
      Shape_ISerializable: IShapeISerializable array
      Shape_Array: IShapeArray array
      Shape_FSharpList: IShapeFSharpList array
      Shape_FSharpOption: IShapeFSharpOption array
      Shape_FSharpRef: IShapeFSharpRef array
      Shape_FSharpSet: IShapeFSharpSet array
      Shape_FSharpMap: IShapeFSharpMap array
      Shape_FSharpFunc: IShapeFSharpFunc array
      Shape_Collection: IShapeCollection array
      Shape_Enumerable: IShapeEnumerable array
      Shape_FSharpRecord: IShapeFSharpRecord array
      Shape_FSharpUnion: IShapeFSharpUnion array
      Shape_Tuple: IShapeTuple array
      Shape_Poco: IShapePoco array


  }


let type_shape = 
    let shape = shapeof<ArcGISMapImageSublayer>
    {
    Shape_Enum = 
      match shape with 
        | Shape.Enum enum_type -> [|enum_type|]
        | _ -> [||]
    Shape_Equality = 
      match shape with 
        | Shape.Equality equality_type -> [|equality_type|]
        | _ -> [||]
    Shape_Comparison = 
      match shape with 
        | Shape.Comparison comparison_type -> [|comparison_type|]
        | _ -> [||]
    Shape_DefaultConstructor = 
      match shape with 
        | Shape.DefaultConstructor defaultconstructor_type -> [|defaultconstructor_type|]
        | _ -> [||]
    Shape_KeyValuePair = 
      match shape with 
        | Shape.KeyValuePair keyvaluepair_type -> [|keyvaluepair_type|]
        | _ -> [||]
    Shape_Dictionary = 
      match shape with 
        | Shape.Dictionary dictionary_type -> [|dictionary_type|]
        | _ -> [||]
    Shape_HashSet = 
      match shape with 
        | Shape.HashSet hashset_type -> [|hashset_type|]
        | _ -> [||]
    Shape_ResizeArray = 
      match shape with 
        | Shape.ResizeArray resizearray_type -> [|resizearray_type|]
        | _ -> [||]
    Shape_Delegate = 
      match shape with 
        | Shape.Delegate delegate_type -> [|delegate_type|]
        | _ -> [||]
    Shape_Exception = 
      match shape with 
        | Shape.Exception exception_type -> [|exception_type|]
        | _ -> [||]
    Shape_ISerializable = 
      match shape with 
        | Shape.ISerializable iserializable_type -> [|iserializable_type|]
        | _ -> [||]
    Shape_Array = 
      match shape with 
        | Shape.Array array_type -> [|array_type|]
        | _ -> [||]
    Shape_FSharpList = 
      match shape with 
        | Shape.FSharpList fsharplist_type -> [|fsharplist_type|]
        | _ -> [||]
    Shape_FSharpOption = 
      match shape with 
        | Shape.FSharpOption fsharpoption_type -> [|fsharpoption_type|]
        | _ -> [||]
    Shape_FSharpRef = 
      match shape with 
        | Shape.FSharpRef fsharpref_type -> [|fsharpref_type|]
        | _ -> [||]
    Shape_FSharpSet = 
      match shape with 
        | Shape.FSharpSet fsharpset_type -> [|fsharpset_type|]
        | _ -> [||]
    Shape_FSharpMap = 
      match shape with 
        | Shape.FSharpMap fsharpmap_type -> [|fsharpmap_type|]
        | _ -> [||]
    Shape_FSharpFunc = 
      match shape with 
        | Shape.FSharpFunc fsharpfunc_type -> [|fsharpfunc_type|]
        | _ -> [||]
    Shape_Collection = 
      match shape with 
        | Shape.Collection collection_type -> [|collection_type|]
        | _ -> [||]
    Shape_Enumerable = 
      match shape with 
        | Shape.Enumerable enumerable_type -> [|enumerable_type|]
        | _ -> [||]
    Shape_FSharpRecord = 
      match shape with 
        | Shape.FSharpRecord fsharprecord_type -> [|fsharprecord_type|]
        | _ -> [||]
    Shape_FSharpUnion = 
      match shape with 
        | Shape.FSharpUnion fsharpunion_type -> [|fsharpunion_type|]
        | _ -> [||]
    Shape_Tuple = 
      match shape with 
        | Shape.Tuple tuple_type -> [|tuple_type|]
        | _ -> [||]
    Shape_Poco = 
      match shape with 
        | Shape.Poco poco_type -> [|poco_type|]
        | _ -> [||]
    }







let provider : ITypeShapeProvider =
    ReflectionTypeShapeProvider.Default

let layer_shape : ITypeShape =
    provider.GetTypeShape(typeof<ArcGISMapImageLayer>)

let layer_object_shape =
    match layer_shape with
    | :? IObjectTypeShape as object_shape ->
        object_shape

    | _ ->
        failwithf
            "Expected an object shape, but %s was classified as %A."
            layer_shape.Type.FullName
            layer_shape.Kind












type Converters with
    static member To_Pascal_Snake_Case(original_string: string) =
        original_string
        |> Converters.ToSnakeCase
        |> Converters.ToTitleCase


let exclusions =
    set [
        typeof<ArcGISMapImageLayer>.Name, "SublayerContents"
        typeof<ArcGISMapImageLayer>.Name, "Tables"
        typeof<ArcGISMapImageLayer>.Name, "CoreLayer"
    ]




let types = 
  [|
    typeof<ArcGISMapImageLayer>
  |]
let type_shapes = 
  types
  |> Array.map provider.GetTypeShape
let object_shapes = 
  type_shapes 
  |> Array.choose (fun type_shape -> 
  
    match type_shape with
    | :? IObjectTypeShape as object_shape ->
        Some object_shape

    | _ -> None
  
  )




let tbox_text =
    Ast.Oak() {
        Ast.AnonymousModule() {
            Ast.HashDirective(
                "r",
                "\"nuget: Esri.ArcGISRuntime, 300.0.0\""
            )

            Ast.Open("System")

            for object_shape in object_shapes do

                let system_properties = 
                  object_shape.Properties
                  |> Seq.choose (fun property_shape -> 
                          match property_shape.PropertyType with
                          | :? IObjectTypeShape as object_shape when object_shape.Type.Namespace = "System" ->
                              Some property_shape

                          | _ -> None
                  
                        )
                let non_system_properties = 
                  object_shape.Properties
                  |> Seq.choose (fun property_shape -> 
                          match property_shape.PropertyType with
                          | :? IObjectTypeShape as object_shape when object_shape.Type.Namespace <> "System" ->
                              printfn "%s : %s" object_shape.Type.Name property_shape.Name 
                              match object_shape.Type.Name,property_shape.Name with 
                              | "ArcGISMapServiceInfo","ServiceInfo"
                              | "Item","Item"
                                 -> None
                              | _,_ -> Some property_shape

                          | _ -> None
                  
                        )


                Ast.Record(Converters.To_Pascal_Snake_Case object_shape.Type.Name) {
                  
                    // for property in system_properties -> Ast.Field(Converters.ToSnakeCase property.Name, property.PropertyType.Type.FullName) 
                    for property in non_system_properties -> Ast.Field(Converters.ToSnakeCase property.Name, property.PropertyType.Type.FullName) 
                    match object_shape.Type.Name  with 
                    | type_name when type_name = typeof<ArcGISMapImageLayer> ->_
                    | _ -> ()
                }
        }
    }
    |> Gen.mkOak
    |> Gen.run


let tbox_file_path =
    Path.Combine(__SOURCE_DIRECTORY__, "Tbox.fsx")

File.WriteAllText(tbox_file_path, tbox_text)
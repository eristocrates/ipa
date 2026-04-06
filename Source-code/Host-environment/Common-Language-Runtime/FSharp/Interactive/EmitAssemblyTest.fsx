open System
open System.IO
open System.Reflection
open System.Reflection.Emit

let assemblyName = AssemblyName("RdfVocabulary")
let ab = PersistedAssemblyBuilder(assemblyName, typeof<obj>.Assembly)
let mb = ab.DefineDynamicModule("RdfVocabulary.dll")

let tb =
    mb.DefineType(
        "Vocab.Rdfs",
        TypeAttributes.Public
        ||| TypeAttributes.Abstract
        ||| TypeAttributes.Sealed
    )

let getter =
    tb.DefineMethod(
        "get_subClassOf",
        MethodAttributes.Public
        ||| MethodAttributes.Static
        ||| MethodAttributes.SpecialName
        ||| MethodAttributes.HideBySig,
        typeof<string>,
        Type.EmptyTypes
    )

let il = getter.GetILGenerator()
il.Emit(OpCodes.Ldstr, "http://www.w3.org/2000/01/rdf-schema#subClassOf")
il.Emit(OpCodes.Ret)

let prop =
    tb.DefineProperty("subClassOf", PropertyAttributes.None, typeof<string>, Type.EmptyTypes)

prop.SetGetMethod(getter)

tb.CreateType() |> ignore
let outputFilePath = Path.Combine(__SOURCE_DIRECTORY__, "RdfVocabulary.dll")

ab.Save(outputFilePath)

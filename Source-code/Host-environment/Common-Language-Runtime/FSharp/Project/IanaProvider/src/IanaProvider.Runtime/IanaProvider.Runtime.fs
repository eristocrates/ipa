namespace MyNamespace

open System


// Put the TypeProviderAssemblyAttribute in the runtime DLL, pointing to the design-time DLL
[<assembly:CompilerServices.TypeProviderAssembly("IanaProvider.DesignTime.dll")>]
do ()



[<RequireQualifiedAccess>]
type IanaStatus =
    | Permanent
    | Provisional
    | Historical
// TODO look into Constrained Resource Identifiers
// https://www.ietf.org/archive/id/draft-ietf-core-href-26.html
type IanaScheme = {
    lexicalForm: string
    description: string option
    status: IanaStatus
    criSchemeNumber: int
    wellKnownUriSupport: string option
}

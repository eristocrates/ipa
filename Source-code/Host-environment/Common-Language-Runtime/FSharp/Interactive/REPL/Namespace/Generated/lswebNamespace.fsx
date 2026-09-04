#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lsweb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#" "lsweb"

    let Characteristic = _prefixId.prefix "Characteristic"
    let DatasetManifestation = _prefixId.prefix "DatasetManifestation"
    let Entity = _prefixId.prefix "Entity"
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>sio:example : America^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion">lsmap:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"
    let GeospatialDataset = _prefixId.prefix "GeospatialDataset"
    let Provider = _prefixId.prefix "Provider"
    let Theme = _prefixId.prefix "Theme"
    let TimePeriod = _prefixId.prefix "TimePeriod"
    let Unit = _prefixId.prefix "Unit"
    let encodedInFormat = _prefixId.prefix "encodedInFormat"
    let hasManifestation = _prefixId.prefix "hasManifestation"

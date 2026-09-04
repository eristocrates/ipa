#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gf =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#" "gf"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:notation : GFI_Feature^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Geographic feature^^xsd:string</para>
    ///   <para>rdfs:comment : In ISO 19156 the class GFI_Feature is defined as an instance of GF_FeatureType. In this OWL representation we do not have a specific class for GF_FeatureType because this would imply subclassing owl:Class which is inconsistent with OWL-DL restrictions.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#AnyFeature">gf:AnyFeature</a>
    /// </summary>
    let AnyFeature = _prefixId.prefix "AnyFeature"

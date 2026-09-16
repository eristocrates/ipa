#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module shsh =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shacl-shacl#" "shsh"

    let _namespaceIri = _prefixId.prefix ""
    let EntailmentShape = _prefixId.prefix "EntailmentShape"
    let ListNodeShape = _prefixId.prefix "ListNodeShape"
    let ListShape = _prefixId.prefix "ListShape"
    let NodeShapeShape = _prefixId.prefix "NodeShapeShape"
    let PathListWithAtLeast2Members = _prefixId.prefix "PathListWithAtLeast2Members"
    let PathNodeShape = _prefixId.prefix "PathNodeShape"
    let PathShape = _prefixId.prefix "PathShape"
    let PropertyShapeShape = _prefixId.prefix "PropertyShapeShape"
    let ShapeShape = _prefixId.prefix "ShapeShape"
    let ShapesGraphShape = _prefixId.prefix "ShapesGraphShape"
    let ShapesListShape = _prefixId.prefix "ShapesListShape"

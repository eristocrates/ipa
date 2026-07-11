namespace Shaclshacl.Namespace
module shaclshacl =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/shacl-shacl#" (Some @"http://www.w3.org/ns/shacl-shacl#") (Some @"shaclshacl") None
    let EntailmentShape = {_prefixID with _localName = "EntailmentShape"}
    let ListNodeShape = {_prefixID with _localName = "ListNodeShape"}
    let ListShape = {_prefixID with _localName = "ListShape"}
    let NodeShapeShape = {_prefixID with _localName = "NodeShapeShape"}
    let PathListWithAtLeast2Members = {_prefixID with _localName = "PathListWithAtLeast2Members"}
    let PathNodeShape = {_prefixID with _localName = "PathNodeShape"}
    let PathShape = {_prefixID with _localName = "PathShape"}
    let PropertyShapeShape = {_prefixID with _localName = "PropertyShapeShape"}
    let ShapeShape = {_prefixID with _localName = "ShapeShape"}
    let ShapesGraphShape = {_prefixID with _localName = "ShapesGraphShape"}
    let ShapesListShape = {_prefixID with _localName = "ShapesListShape"}
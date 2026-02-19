namespace Owl_s.ObjectList.Namespace
module ObjectList =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#" (Some "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl") (Some "owl_s.ObjectList") None
    let List = {_prefixID with _localName = "List"}
    let first = {_prefixID with _localName = "first"}
    let nil = {_prefixID with _localName = "nil"}
    let rest = {_prefixID with _localName = "rest"}
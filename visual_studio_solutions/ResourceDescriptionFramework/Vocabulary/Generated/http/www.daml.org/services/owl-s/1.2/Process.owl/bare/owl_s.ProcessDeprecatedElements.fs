namespace Owl_s.ProcessDeprecatedElements.Namespace
module ProcessDeprecatedElements =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/Process.owl" (Some "http://www.daml.org/services/owl-s/1.2/ProcessDeprecatedElements.owl") (Some "owl_s.ProcessDeprecatedElements") None
    let ``#Any-Order`` = {_prefixID with _localName = "#Any-Order"}
    let ``#ConditionalEffect`` = {_prefixID with _localName = "#ConditionalEffect"}
    let ``#ConditionalOutput`` = {_prefixID with _localName = "#ConditionalOutput"}
    let ``#ControlConstruct`` = {_prefixID with _localName = "#ControlConstruct"}
    let ``#ProcessComponent`` = {_prefixID with _localName = "#ProcessComponent"}
    let ``#Unordered`` = {_prefixID with _localName = "#Unordered"}
    let ``#collapse`` = {_prefixID with _localName = "#collapse"}
    let ``#collapsesTo`` = {_prefixID with _localName = "#collapsesTo"}
    let ``#expand`` = {_prefixID with _localName = "#expand"}
    let ``#expandsTo`` = {_prefixID with _localName = "#expandsTo"}
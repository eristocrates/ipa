#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lifecycle =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vocab/lifecycle/schema#" "lifecycle"

    let _namespaceIri = _prefixId.prefix ""
    let Action = _prefixId.prefix "Action"
    let Lifecycle = _prefixId.prefix "Lifecycle"
    let State = _prefixId.prefix "State"
    let Task = _prefixId.prefix "Task"
    let TaskGroup = _prefixId.prefix "TaskGroup"
    let TaskProgress = _prefixId.prefix "TaskProgress"
    let Transition = _prefixId.prefix "Transition"
    let possibleState = _prefixId.prefix "possibleState"
    let possibleTransition = _prefixId.prefix "possibleTransition"

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open Dubzer.WhatwgUrl

module Infor =
    module CustomerService =
        let portal = DomUrl "https://customerportal.infor.com/csmcore"

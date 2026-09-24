#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"StringModule.dll"
#r @"Internet.dll"
#r @"TopLevelDomain.dll"
#r @"IanaScheme.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
#load @"PrettierNaming.fsx"
open Internet
open StringModule
#load @".paket/load/main.group.fsx"
open System

module https =
    let scheme = IanaScheme.https

    module org =
        let topLevelDomain = TopLevelDomain.org

        module iana =
            let secondLevelDomain = "iana"
            let host = secondLevelDomain +. topLevelDomain
            let site = scheme ..// host

            module www =
                let site = scheme |> www secondLevelDomain topLevelDomain

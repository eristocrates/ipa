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

    module com =
        let topLevelDomain = TopLevelDomain.com

        module example =
            let secondLevelDomain = "example"
            let host = secondLevelDomain +. topLevelDomain
            let site = scheme ..// host

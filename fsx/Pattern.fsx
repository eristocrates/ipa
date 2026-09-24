#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false

#I @"D:\https\com\github\eristocrates\ipa\dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"

#load @".paket/load/main.group.fsx"
open System
open System.Text
open System.Text.RegularExpressions




module Regex =
    let escapedSurrogatePair = Regex(@"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})", RegexOptions.Compiled ||| RegexOptions.CultureInvariant)

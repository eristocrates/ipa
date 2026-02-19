#if INTERACTIVE
#load "PrefixDeclaration.fsx"
#endif

open Shorthand
open Shorthand.LangTag
open PrefixDeclaration

let a = rdf.``type``
Graph.``default``.Clear()
let rule = Adhoc.mintPrefixID "urn:guokai.dev/tab-group/rule/" "rule-"
let urlMatch = Adhoc.mintPrefixID "urn:guokai.dev/tab-group/rule/match/url/" "match.url"
let titleMatch = Adhoc.mintPrefixID "urn:guokai.dev/tab-group/rule/match/title/" "match.title"
let regexPattern = Adhoc.mintPrefixID "urn:regex/pattern/" "regex.pattern"
let Fsharp_Documentation_Microsoft =  "rule-Fsharp_Documentation_Microsoft"
let Fsharp =  "rule-Fsharp"
let Xml_Documentation_Microsoft =  "rule-Xml_Documentation_Microsoft"
let edge =  "rule-edge"
let Microsoft_Power_Automate =  "rule-Microsoft_Power_Automate"
let Infor_Company_Community =  "rule-Infor_Company_Community"
let Infor_Company_Portal_Developer =  "rule-Infor_Company_Portal_Developer"
let SolarWinds_ServiceDesk_View =  "rule-SolarWinds_ServiceDesk_View"
let SolarWinds_ServiceDesk_Incident =  "rule-SolarWinds_ServiceDesk_Incident"
let SolarWinds_ServiceDesk_Documentation =  "rule-SolarWinds_ServiceDesk_Documentation"
let dotnet'fsharp = "dotnet.fsharp"
let dotnet'fsharp'uri = "https://learn.microsoft.com/en-us/dotnet/fsharp/"
let fsharp = "fsharp"
let fsharp'regex = "[fF]([sS][hH][aA][rR][pP]|#)"



[
  rule.prefix Fsharp_Documentation_Microsoft
  rule.prefix Fsharp
  rule.prefix Xml_Documentation_Microsoft
  rule.prefix edge
  rule.prefix Microsoft_Power_Automate
  rule.prefix Infor_Company_Community
  rule.prefix Infor_Company_Portal_Developer
  rule.prefix SolarWinds_ServiceDesk_View
  rule.prefix SolarWinds_ServiceDesk_Incident
  rule.prefix SolarWinds_ServiceDesk_Documentation
] =-~ [
 a -~- guokai.TabGroupingRule
 // guokai.enabled -~- true
] >-: defaultGraph

rule.prefix Fsharp_Documentation_Microsoft --- guokai.urlMatches --> urlMatch.prefix dotnet'fsharp >-: defaultGraph
rule.prefix Fsharp --~ [
  guokai.titleMatches -~- titleMatch.prefix fsharp
  guokai.urlMatches -~- urlMatch.prefix fsharp
] >-: defaultGraph


guokai.href --- a --> guokai.UrlMatchTarget >-: defaultGraph
guokai.UrlMatchTarget --- rdfs.subClassOf --> guokai.MatchTarget >-: defaultGraph

[
  guokai.startsWith
  guokai.regex
] -=- a --> guokai.MatchMethod >-: defaultGraph

urlMatch.prefix dotnet'fsharp --~ [ 
  guokai.``method`` -~- guokai.startsWith
  guokai.target -~- guokai.href
  guokai.value -~- dotnet'fsharp'uri ^^^xsd.anyURI
] >-: defaultGraph

[
  titleMatch.prefix fsharp
  urlMatch.prefix fsharp
] =-~ [ 
  guokai.``method`` -~- guokai.regex
  guokai.value -~- fsharp'regex ^^^``void``.uriRegexPattern
] >-: defaultGraph

urlMatch.prefix fsharp --- guokai.target --> guokai.href >-: defaultGraph


Serialization.Turtle.save Artifact.tabgroupsrules.ttl Graph.``default``

#time on

fsi.PrintLength <- 10
// fsi.ShowDeclarationValues <- false

#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"StringModule.dll"
#r @"Internet.dll"
#r @"TopLevelDomain.dll"
#r @"IanaScheme.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
#load "PrettierNaming.fsx"
open Internet
open StringModule

#load @"Sites\https\org\iana\www\Site.fsx"
#load @"Sites\https\com\fasterwebcloud\leoncountyfl\Site.fsx"
#load @".paket/load/main.group.fsx"

open System
open FSharp.Data
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Microsoft.AspNetCore.Http
open Meziantou.Framework
open Fabulous.AST
open Fantomas.Core
open Dubzer.WhatwgUrl
open TextCopy
open Microsoft.Graph.Models
open Tavis.UriTemplates



(*



[|

    "https://leoncountyfl.fasterwebcloud.com"
    "https://example.com"
    "https://www.iana.org"
    "https://github.com"
    "https://eristocrates.dev"
    "https://spec.edmcouncil.org"
|]
|> codegenSites





IriSpace.clipParameter "Domain"

*)

let testSites =
    [|

        "https://www.nuget.org/packages/Soenneker.Entities.Named"
        "https://www.nuget.org/profiles/ModelingEvolution"
        "https://www.google.com/search?q=astrea+shacl&rlz=1C1GCEB_enUS799US799&oq=astrea+shacl&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQABjvBTIHCAIQABjvBTIHCAMQABjvBTIHCAQQABjvBTIHCAUQABjvBdIBCDMxMjlqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://www.google.com/search?q=dotnet+%22Infor%22+api&sca_esv=cebce586dd40d497&rlz=1C1GCEB_enUS799US799&biw=1864&bih=1031&ei=XTKoaszJB4qTwbkPtvW3sQI&ved=2ahUKEwiM7PXTz-6WAxWKSTABHbb6LSYQ4dUDegQIBhAM&uact=5&oq=dotnet+%22Infor%22+api&gs_lp=Egxnd3Mtd2l6LXNlcnAiEmRvdG5ldCAiSW5mb3IiIGFwaTIHECEYChigAUj8I1CpDljpInABeAGQAQCYAWqgAYEEqgEDNy4xuAEDyAEA-AEBmAIJoAKkBMICChAAGEcY1gQYsAPCAggQABiABBiiBMICBRAAGO8FwgIJEAAYgAQYDRgTwgIIEAAYHhgNGBPCAgoQABgIGB4YDRgTwgIKEAAYBRgeGA0YE5gDAIgGAZAGApIHAzguMaAHpxWyBwM3LjG4B6EEwgcFMS43LjHIBxCACAE&sclient=gws-wiz-serp"
        "https://github.com/ktsu-dev/Semantics/blob/main/Semantics.Paths/README.md"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.Globbing/readme.md"
        "https://dev.to/hirave_palak/internet-architecture-5bka"
        "https://www.google.com/search?q=Microsoft.SqlServer.Dac.Model.ModelRelationshipClass+%22authorizer%22&sca_esv=942c0a0162520423&rlz=1C1GCEB_enUS799US799&biw=1864&bih=1031&ei=FGypavHjBuKcwbkPoPbnwA0&ved=2ahUKEwjxvZfr-vCWAxViTjABHSD7GdgQ4dUDegQIBhAM&uact=5&oq=Microsoft.SqlServer.Dac.Model.ModelRelationshipClass+%22authorizer%22&gs_lp=Egxnd3Mtd2l6LXNlcnAiQU1pY3Jvc29mdC5TcWxTZXJ2ZXIuRGFjLk1vZGVsLk1vZGVsUmVsYXRpb25zaGlwQ2xhc3MgImF1dGhvcml6ZXIiSNghUJgIWIcfcAF4AZABAJgBiAGgAZ0HqgEEMTIuMrgBA8gBAPgBAvgBAZgCCaAC4ATCAgoQABhHGNYEGLADwgIFEAAY7wXCAggQABiJBRiiBMICBRAhGKABmAMAiAYBkAYKkgcDOC4xoAf5ErIHAzcuMbgHuATCBwc0LjQuNC0xyAcfgAgB&sclient=gws-wiz-serp"
        "https://datatracker.ietf.org/doc/rfc3579/"
        "https://urlpattern.spec.whatwg.org/#urlpatterns"
        "https://chromewebstore.google.com/detail/copytables/ekdpkppgmlalfkphpibadldikjimijon"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.Uri/readme.md"
        "https://leoncountyfl.samanage.com/incidents/192864811"
        "https://www.iana.org/assignments/media-types"
        "https://www.google.com/search?q=dotnet+embedded+rdf+triplestore&rlz=1C1GCEB_enUS799US799&oq=dotnet+embedded+rdf+triplestore&gs_lcrp=EgZjaHJvbWUyCAgAEEUYFRg5MgYIARAhGBUyBwgCECEYjwLSAQg3MDQ0ajBqN6gCALACAA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://www.nuget.org/packages?q=ModelingEvolution"
        "https://html.spec.whatwg.org/multipage/browsers.html#ascii-serialisation-of-an-origin"
        "https://mermaid.ai/open-source/syntax/mindmap.html"
        "https://app.thebrain.com/brain/af38509e-8270-495b-b048-d02a8453387c/5ebaabac-20f4-4abd-8999-ded049f9cdb2"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.FullPath/readme.md"
        "https://en.wikipedia.org/wiki/Data_URI_scheme"
        "https://www.nuget.org/packages/Bridge.WebGL"
        "https://semantics.istc.cnr.it/lode/extract?url=https://w3id.org/fossr/ontology/bdi"
        "https://github.com/eristocrates/ipa"
        "https://www.rfc-editor.org/info/rfc2397/"
        "https://www.rfc-editor.org/info/rfc1034/#section-2.1"
        "https://www.rfc-editor.org/rfc/rfc7285.txt"
        "about:blank"
        "https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/fsharp-interactive-options"
        "https://www.nuget.org/packages/Cytoscape.NET"
        "https://github.com/AJ-comp/Compiler"
        "https://www.google.com/search?q=dotnet+op_+methods&rlz=1C1GCEB_enUS799US799&oq=dotnet+op_+methods&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQABjvBTIHCAIQABjvBTIHCAMQABjvBTIHCAQQABjvBTIHCAUQABjvBdIBCDMyOTBqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://qudt.org/3.1.10/vocab/quantitykind"
        "https://raw.githubusercontent.com/CommonCoreOntology/CommonCoreOntologies/refs/heads/develop/src/cco-modules/CurrencyUnitOntology.ttl"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Dwhatwg%2B%2522scheme-and-host%2522%26sca_esv%3D5a6de5ad61aa0ca3%26rlz%3D1C1GCEB_enUS799US799%26ei%3DUBqjatq1J8yGw8cPhKXKwQc%26biw%3D1864%26bih%3D1031%26ved%3D2ahUKEwjanaSC9OSWAxVMw_ACHYSSMngQ4dUDegQIBhAM%26uact%3D5%26oq%3Dwhatwg%2B%2522scheme-and-host%2522%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiGHdoYXR3ZyAic2NoZW1lLWFuZC1ob3N0IjIFEAAY7wUyBRAAGO8FMggQABiJBRiiBDIFEAAY7wUyBRAAGO8FSLwVUOYBWLETcAF4AZABAJgBd6ABzgOqAQM1LjG4AQPIAQD4AQH4AQKYAgegAvoDwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEwgIFEAAYgATCAgoQABiABBiKBRhDwgIEEAAYHpgDAIgGAZAGApIHAzUuMqAH-QmyBwM0LjK4B_UDwgcHMC40LjEuMsgHJYAIAQ%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMPyp9UGIijKeM3FphsLdwOr6s7IQEsv5Ne1ONpuKKpfFnAvcHHmm1scv_On0orlMgJyUloBQw"
        "https://github.com/edmcouncil/fibo/releases/tag/master_2026Q2"
        "https://leoncountyfl.fasterwebcloud.com/FASTER/Domains/Maintenance/Default.aspx"
        "https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/members/constructors"
        "https://www.nuget.org/packages/Universal.Common.Json"
        "https://www.nuget.org/packages/Universal.Common.Data"
        "https://www.nuget.org/packages?q=ipv6&includeComputedFrameworks=true&prerel=true&sortby=relevance"
        "https://www.nuget.org/packages?q=webgl&includeComputedFrameworks=true&prerel=true&sortby=relevance"
        "https://www.nuget.org/packages/Universal.Common.Collections"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Duri%2Borigin%2Bvs%2Bhttp%2Borigin%2Bform%26sca_esv%3D35cfe427b01f9ce2%26rlz%3D1C1GCEB_enUS799US799%26biw%3D1864%26bih%3D1031%26ei%3DFwCjav30Od7Ap84P5OyUkAc%26ved%3D2ahUKEwi93LWB2-SWAxVe4MkDHWQ2BXIQ4dUDegQIBhAM%26uact%3D5%26oq%3Duri%2Borigin%2Bvs%2Bhttp%2Borigin%2Bform%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiHnVyaSBvcmlnaW4gdnMgaHR0cCBvcmlnaW4gZm9ybTIFEAAY7wUyBRAAGO8FMgUQABjvBTIFEAAY7wVIviBQsAhYogxwAXgBkAEAmAFnoAGCA6oBAzQuMbgBA8gBAPgBAZgCBqACkgPCAgoQABhHGNYEGLADwgIIEAAYgAQYogTCAgUQIRigAcICBBAhGBWYAwCIBgGQBgqSBwM1LjGgB_YHsgcDNC4xuAeOA8IHAzAuNsgHCYAIAQ%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMLyp9UGIijZgy_oQXUDjWlQzruq6dDbDr5olZjK0YWtJpiz3Vm02aWyxMhn2HtvMgJyUloBQw"
        "https://www.nuget.org/packages/Abstract.DataStructures"
        "https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Messages"
        "chrome-error://chromewebdata/"
        "https://www.w3.org/TR/rdf12-concepts/#vocabularies"
        "https://www.nuget.org/packages?q=grafeo&includeComputedFrameworks=true&prerel=true&sortby=relevance"
        "https://www.google.com/search?q=pokemon+go+search+exclude+pokemon+at+a+power+spot&sca_esv=0ad83d8dec62c36e&rlz=1C1GCEB_enUS799US799&ei=I1OoarrQJOuMwbkP6cCpoAE&biw=1864&bih=1031&ved=2ahUKEwj67ef07u6WAxVrRjABHWlgChQQ4dUDegQIBhAM&uact=5&oq=pokemon+go+search+exclude+pokemon+at+a+power+spot&gs_lp=Egxnd3Mtd2l6LXNlcnAiMXBva2Vtb24gZ28gc2VhcmNoIGV4Y2x1ZGUgcG9rZW1vbiBhdCBhIHBvd2VyIHNwb3QyBRAAGO8FMgUQABjvBTIFEAAY7wUyBRAAGO8FMgUQABjvBUjdIlCECViQIXACeAGQAQCYAYwBoAHRCaoBBDExLjO4AQPIAQD4AQGYAg2gAp0HwgIKEAAYRxjWBBiwA5gDAIgGAZAGCpIHBDEyLjGgB4sasgcEMTAuMbgHlgfCBwYwLjEyLjHIBxaACAE&sclient=gws-wiz-serp"
        "chrome-error://chromewebdata/"
        "https://www.nuget.org/packages?q=domain+name&includeComputedFrameworks=true&prerel=true"
        "https://leoncountyfl.samanage.com/profile?layout=long&is_portal_mode=False"
        "https://www.mkbergman.com/sweet-tools/"
        "https://www.nuget.org/packages/Universal.Common.Serialization"
        "https://oscaf.sourceforge.net/"
        "https://www.nuget.org/packages?q=data+uri&includeComputedFrameworks=true&prerel=true&sortby=relevance"
        "https://leoncountyfl.samanage.com/incidents?report_id=9641268&applied=true&columns=requester%2Ctitle%2Cstate%2Csub_type%2Ctype%2Csite%2Cdepartment%2Cassigned_to%2Cpriority%2Ccreated_at%2Ccreated_by%2Ctag_list%2Cnumber%2Cslm%2Cpreview&data=state&sort_by=state&sort_order=DESC&title%5B%5D=test"
        "https://data.iana.org/TLD/tlds-alpha-by-domain.txt"
        "https://fsharp.github.io/fslang-spec/program-structure-and-execution/#122-signature-files"
        "https://github.com/OAI/sig-moonwalk/issues/125"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3DIban%26sca_esv%3Db2b87a3f75a2d5f7%26rlz%3D1C1GCEB_enUS799US799%26biw%3D1864%26bih%3D1031%26sxsrf%3DAPpeQnuhEnQi1j0LyNiEHUn4o5uL5QG4_A%253A1789049477809%26ei%3DhbqiapD9MKqzwt0P8cbwqAY%26ved%3D2ahUKEwjQ0_DUmOSWAxWqmbAFHXEjHGUQ4dUDegQIBhAM%26uact%3D5%26oq%3DIban%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiBEliYW4yChAAGIAEGIoFGEMyChAAGIAEGIoFGEMyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIHEAAYgAQYBDIHEAAYgAQYBDIHEAAYgAQYBEi4CFDCA1jpBnACeAGQAQCYAUWgAUWqAQExuAEDyAEA-AEB-AECmAIDoAJRqAIKwgIHECMYsAMYJ8ICChAAGEcY1gQYsAPCAgcQIxjqAhgnmAME8QV5u-XiYw-hYIgGAZAGCpIHATOgB7UCsgcBMbgHSMIHBTAuMi4xyAcJgAgB%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMLyp9UGIiiTWcgNegwWvabkWGQ_OmjArcKOreiYXgaAWlAW_Y4ZpJcN387fmmTFMgJyUloBQw"
        "https://sourceforge.net/projects/freemind/"
        "https://github.com/ktsu-dev/Semantics/blob/main/Semantics.Strings.Identifiers/README.md"
        "https://developer.mozilla.org/en-US/docs/Web/API/URLPattern/URLPattern"
        "https://www.ietf.org/download/rfc-index.txt"
        "https://leoncountyfl.fasterwebcloud.com/FASTER/Domains/Reports/ReportViewer.aspx?R=/Accounting/W516%20-%20Payables%20And%20Invoices%20By%20Vendor&TimeZone=3&ReportType=S&Domain=Accounting&Parent=Reports"
        "https://medium.com/@ahmad.sohail/paddlesharp-vs-ironocr-the-native-dependency-setup-a-net-team-signs-up-for-606099791302"
        "https://www.google.com/search?q=term+for+a+scheme+and+domain+name&rlz=1C1GCEB_enUS799US799&oq=term+for+a+scheme+and+domain+name&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQABjvBTIHCAIQABjvBTIHCAMQABjvBdIBCDU4MDZqMGo0qAIAsAIB&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://xmlns.com/foaf/spec/"
        "https://www.nuget.org/packages?q=+Universal.Common&includeComputedFrameworks=true&prerel=true"
        "https://www.nuget.org/packages?q=ebnf&includeComputedFrameworks=true&prerel=true&sortby=created-desc"
        "https://datatracker.ietf.org/"
        "https://lov.linkeddata.es/dataset/sparql"
        "https://csbiology.github.io/FSharp.FGL/content/tutorial.html"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Drdf%2Bnamespace%2Bvs%2Brdf%2Bvocabulary%26sca_esv%3D89264749a61b36b1%26rlz%3D1C1GCEB_enUS799US799%26ei%3D93qpar-JKfncwN4PnsaScQ%26biw%3D1864%26bih%3D1031%26ved%3D2ahUKEwj_4NaEifGWAxV5LtAFHR6jJA4Q4dUDegQIBhAM%26uact%3D5%26oq%3Drdf%2Bnamespace%2Bvs%2Brdf%2Bvocabulary%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiH3JkZiBuYW1lc3BhY2UgdnMgcmRmIHZvY2FidWxhcnkyBRAAGO8FMgUQABjvBTIFEAAY7wUyBRAAGO8FMgUQABjvBUjFMVCtBFi6MHADeAGQAQCYAWigAZMSqgEEMzIuMbgBA8gBAPgBAZgCI6AClxOoAgDCAgoQABhHGNYEGLADwgIHEAAYgAQYBMICBRAAGIAEwgIKEAAYgAQYigUYQ8ICBBAAGB7CAgcQABiABBgTwgIGEAAYHhgTwgIIEAAYCBgeGBPCAggQABiABBiiBMICCRAAGIAEGA0YE8ICBhAAGAgYHsICBRAhGKABwgIEECEYFZgDAfEFX-pKGe2I5oiIBgGQBgqSBwQzMy4yoAfGMrIHBDMxLjK4B_8SwgcIOS4xNy43LjLIB1qACAE%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMLyp9UGIihsoPnxt-D9j02JEX0ai3kK_XrBFWYmc_u2VUCVzVKlDnPyzJE9oz87MgJyUloBQw"
        "https://www.nuget.org/packages/Universal.Common.Drawing"
        "https://datatracker.ietf.org/doc/html/rfc6570"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Drdf%2Btask%2Bontology%2Bsemantic%2Bdesktop%2B%26sca_esv%3Da3685d48c0021347%26rlz%3D1C1GCEB_enUS799US799%26ei%3D0tqmaquNHvTIp84Pks_meA%26biw%3D1864%26bih%3D983%26ved%3D2ahUKEwirvtmDiOyWAxV05MkDHZKnGQ8Q4dUDegQIBhAM%26uact%3D5%26oq%3Drdf%2Btask%2Bontology%2Bsemantic%2Bdesktop%2B%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiI3JkZiB0YXNrIG9udG9sb2d5IHNlbWFudGljIGRlc2t0b3AgMgUQABjvBTIFEAAY7wUyBRAAGO8FMgUQABjvBTIFEAAY7wVIgT1Q1wVYozlwAXgBkAEBmAHgAaABqxGqAQYzLjE0LjG4AQPIAQD4AQGYAhKgAukQwgIKEAAYRxjWBBiwA8ICBRAhGKABwgIEECEYFcICBxAhGAoYoAGYAwCIBgGQBgqSBwY0LjEzLjGgB7wgsgcGMy4xMy4xuAfjEMIHBjMuMTQuMcgHHIAIAQ%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMLyp9UGIigy6YgXvNx13ut2dSvqyESITuHXKPR7haHh3LBYsS9f9XeIEO4BPB94MgJyUloBQw"
        "https://www.nuget.org/packages/Nager.PublicSuffix"
        "https://github.com/modelingevolution"
        "https://fornever.github.io/TruePath/"
        "https://www.iana.org/assignments/media-types"
        "https://www.nuget.org/packages/ModelingEvolution.Bytes"
        "https://qudt.org/3.1.10/vocab/dimensionvector"
        "https://learn.microsoft.com/en-us/dotnet/api/system.environment.machinename?view=net-10.0"
        "https://www.rfc-editor.org/rfc/rfc3261.json"
        "https://edgarfgp.github.io/Fabulous.AST/widgets/Expressions.html#Collections-and-Tuples"
        "https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/SemanticKernel.Core/Text/TextChunker.cs"
        "https://github.com/edgarfgp/Fabulous.AST"
        "https://github.com/meziantou/Meziantou.Framework"
        "about:blank"
        "https://github.com/Dubzer/Dubzer.WhatwgUrl/blob/master/docs/main.md"
        "https://qudt.org/3.1.10/vocab/soqk"
        "chrome-error://chromewebdata/"
        "https://oscaf.sourceforge.net/tmo.html"
        "https://www.google.com/search?q=Ulid&rlz=1C1GCEB_enUS799US799&oq=Ulid&gs_lcrp=EgZjaHJvbWUyBggAEEUYOdIBBzM2OWowajeoAgCwAgA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://www.nuget.org/packages/BabylonJS"
        "https://github.com/xiliumhq/crdtp"
        "https://spec.graphql.org/October2021/#sec-Appendix-Grammar-Summary"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Dall%2Brdf%2Bfile%2Bextensions%26sca_esv%3D0ad83d8dec62c36e%26rlz%3D1C1GCEB_enUS799US799%26ei%3DdE6oau3cOtWzkvQPloWU2Q0%26biw%3D1864%26bih%3D1031%26ved%3D2ahUKEwjt5qC56u6WAxXVmYQIHZYCJdsQ4dUDegQIBhAM%26uact%3D5%26oq%3Dall%2Brdf%2Bfile%2Bextensions%26gs_lp%3DEgxnd3Mtd2l6LXNlcnAiF2FsbCByZGYgZmlsZSBleHRlbnNpb25zMgoQIRgKGKABGMMESJYLUP8EWK4HcAF4AZABAZgBYqAB1wKqAQE0uAEDyAEA-AEBmAIEoAKfAsICChAAGEcY1gQYsAPCAgUQABjvBcICCBAAGIAEGKIEwgIGEAAYHhgNwgIIEAAYCBgeGA2YAwCIBgGQBgmSBwMzLjGgB4INsgcDMi4xuAeYAsIHBzAuMS4xLjLIByGACAE%26sclient%3Dgws-wiz-serp&q=EgSqVYJUGMLyp9UGIijBg2w4C1F0f1cZKPYW2Lh65ZJnHSKkzL_t49IkeEElqZZ59nchDBADMgJyUloBQw"
        "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fq%3Ddotnet%2Bsemantic%2Bstrings%26rlz%3D1C1GCEB_enUS799US799%26oq%3Ddotnet%2Bsemantic%2Bstrings%26gs_lcrp%3DEgZjaHJvbWUyCQgAEEUYORigAdIBCDI1NDhqMGo3qAIAsAIA%26sourceid%3Dchrome%26source%3Dchrome.ob%26ie%3DUTF-8&q=EgSqVYJUGMPyp9UGIiiqt_Arl9aFyDNjx2GvcCW5PFASDUm-9ZQu_PKdYF4sR3KX8JLyHvOjMgJyUloBQw"
        "https://inforprod.leoncountyfl.gov/operations/"
        "https://schema.org/version/latest/schemaorg-all-https.ttl"
        "https://www.meziantou.net/simplifying-path-manipulations-with-the-fullpath-type.htm"
        "https://www.iana.org/assignments/uri-schemes"
        "https://www.google.com/search?q=most+comon+content-types&rlz=1C1GCEB_enUS799US799&oq=most+comon+content-types&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTILCAEQABgNGBMYgAQyDggCEAAYDRgTGIAEGLQHMg4IAxAAGA0YExiABBi0BzIOCAQQABgNGBMYgAQYtAcyDggFEAAYDRgTGIAEGLQHMgoIBhAAGA0YExgeMgoIBxAAGA0YExgeMgoICBAAGA0YExgeMgoICRAAGA0YExge0gEINDc1NGowajSoAgCwAgE&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://lov.linkeddata.es/dataset/vocabs/voaf#"
        "https://www.nuget.org/packages?q=neo4j&includeComputedFrameworks=true&prerel=true"
        "https://api.ipify.org/"
        "https://www.nuget.org/packages?q=Infor+hansen&includeComputedFrameworks=true&prerel=true&sortby=relevance"
        "https://www.nuget.org/packages/Meziantou.Framework.Uri/2.0.0"
        "https://www.nuget.org/packages/Hekate"
        "https://www.google.com/search?q=format+of+rfc+draft+name&sca_esv=0d62d6a308d44284&rlz=1C1GCEB_enUS799US799&biw=902&bih=981&ei=5Emjar_LDeeqwN4P-7aB8AU&ved=2ahUKEwi_zfqxoeWWAxVnFdAFHXtbAF4Q4dUDegQIBhAM&uact=5&oq=format+of+rfc+draft+name&gs_lp=Egxnd3Mtd2l6LXNlcnAiGGZvcm1hdCBvZiByZmMgZHJhZnQgbmFtZTIFEAAY7wUyBRAAGO8FMgUQABjvBTIFEAAY7wUyBRAAGO8FSI04UNUGWO82cAJ4AJABAJgBlAGgAdMXqgEFMjAuMTC4AQPIAQD4AQGYAh6gAuwXqAIAwgIIEAAY7wUYsAPCAgcQABiABBgEwgIFEAAYgATCAgoQABiABBiKBRhDwgIIEAAYgAQYtAfCAgQQABgewgIHEAAYgAQYE8ICChAAGIAEGBMYtAfCAggQABiJBRiiBMICBRAhGKABwgIEECEYFcICCBAAGIAEGKIEmAMB8QWxiSLPHl5Af4gGAZAGBZIHBTE4LjEyoAecM7IHBTE3LjEyuAfpF8IHCDYuMjAuMi4yyAdLgAgB&sclient=gws-wiz-serp"
        "https://www.google.com/search?q=meziantou+fullpath&rlz=1C1GCEB_enUS799US799&oq=meziantou+fullpath&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIJCAEQABgTGIAEMggIAhAAGBMYHjIICAMQABgTGB4yCAgEEAAYExgeMggIBRAAGBMYHjIICAYQABgTGB4yCAgHEAAYExgeMggICBAAGBMYHjIICAkQABgTGB7SAQgzNDA0ajBqN6gCALACAA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.DnsClient/readme.md"
        "https://www.nuget.org/packages/Universal.Common.Language"
        "https://github.com/solid/solid-namespace"
        "https://www.google.com/search?q=href&rlz=1C1GCEB_enUS799US799&oq=href&gs_lcrp=EgZjaHJvbWUqBwgAEAAYgAQyBwgAEAAYgAQyBwgBEAAYgAQyBwgCEAAYgAQyBwgDEAAYgAQyBwgEEAAYgAQyBwgFEAAYgAQyCQgGEAAYBBiABDIHCAcQABiABDIHCAgQABiABDIJCAkQABgKGIAE0gEIMTMxM2owajeoAgCwAgA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "http://goldparser.org/doc/grammars/"
        "https://www.google.com/search?q=graph+arc&rlz=1C1GCEB_enUS799US799&oq=graph+arc&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIJCAEQABgTGIAEMgkIAhAAGBMYgAQyCQgDEAAYExiABDIJCAQQABgTGIAEMgkIBRAAGBMYgAQyCQgGEAAYExiABDIJCAcQABgTGIAEMgkICBAAGBMYgAQyCQgJEAAYExiABNIBCDI4MTBqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://www.rfc-editor.org/info/rfc6570/"
        "https://kasparorange.github.io/BrowserApi/articles/css-in-csharp.html#selectors-compose-with-c-operators"
        "https://github.com/nfdi4plants/ARCTokenization/blob/main/docs/ControlledVocabulary/Introduction.ipynb"
        "https://graphviz.org/download/"
        "https://www.google.com/search?q=linix+equivalent+of+Program+Files+folder&sca_esv=31fa6de42034ce83&rlz=1C1GCEB_enUS799US799&biw=1864&bih=1031&ei=BY2qaqKXHMW0qtsPkqSE2Qg&ved=2ahUKEwjircKyjvOWAxVFmmoFHRISIYsQ4dUDegQIBhAM&uact=5&oq=linix+equivalent+of+Program+Files+folder&gs_lp=Egxnd3Mtd2l6LXNlcnAiKGxpbml4IGVxdWl2YWxlbnQgb2YgUHJvZ3JhbSBGaWxlcyBmb2xkZXIyBRAAGO8FMgUQABjvBTIFEAAY7wVIkj9QtQRYmD5wAXgBkAEAmAFjoAG6FaoBAjQwuAEDyAEA-AEBmAIpoALCFsICChAAGEcY1gQYsAPCAgUQABiABMICBxAAGIAEGATCAgoQABiABBiKBRhDwgIJEAAYgAQYChgLwgIHEAAYgAQYDcICBhAAGB4YDcICCRAAGIAEGA0YE8ICDBAAGIAEGA0YExi0B8ICCBAAGB4YDRgTwgIIEAAYCBgeGA3CAgUQIRigAcICBBAhGBWYAwCIBgGQBgqSBwQ0MC4xoAfCjAGyBwQzOS4xuAe_FsIHCDYuMjguNi4xyAddgAgB&sclient=gws-wiz-serp"
        "https://www.w3.org/1999/02/22-rdf-syntax-ns#"
        "https://discord.com/channels/@me/319303514507575297"
        "https://www.nuget.org/packages/Fable.Browser.WebGL"
        "https://learn.microsoft.com/en-us/dotnet/api/system.net.ipaddress?view=net-10.0"
        "https://www.nuget.org/packages/d3"
        "https://urlpattern.spec.whatwg.org/#patterns"
        "chrome-error://chromewebdata/"
        "https://kasparorange.github.io/BrowserApi/articles/migration.html"
        "https://www.nuget.org/packages/Universal.Common.Pipelines"
        "https://rdflib.readthedocs.io/en/latest/apidocs/rdflib.namespace/"
        "https://media.discordapp.net/attachments/319303514507575297/1547793856110796880/20260910_221910.jpg?ex=6aa4b6db&is=6aa3655b&hm=90109d7265b2ce34132591b8d8932ef5cbea99a8412c616b6c3b21d54d136cfa&=&format=png&width=789&height=1024"
        "chrome-error://chromewebdata/"
        "https://www.google.com/search?q=html+character+entity&sca_esv=1e9e0030b7dc181c&rlz=1C1GCEB_enUS799US799&biw=1864&bih=1031&ei=cxSoavaLC96g0PEP8v-FKQ&ved=2ahUKEwi2kaqQs-6WAxVeEDQIHfJ_IQUQ4dUDegQIBhAM&uact=5&oq=html+character+entity&gs_lp=Egxnd3Mtd2l6LXNlcnAiFWh0bWwgY2hhcmFjdGVyIGVudGl0eTIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHjIEEAAYHkjDG1CWAli6GnABeACQAQCYAbIBoAGeDKoBBDE5LjK4AQPIAQD4AQGYAhWgApYMwgIKEAAYRxjWBBiwA8ICBhAAGB4YCsICBRAAGIAEwgIKEAAYgAQYigUYQ8ICBxAAGIAEGATCAgYQABgEGB7CAgcQABiABBgTwgIKEAAYgAQYExi0B8ICCRAAGIAEGA0YE8ICDBAAGIAEGA0YExi0B8ICBhAAGB4YE5gDAIgGAZAGBJIHBDE4LjOgB75CsgcEMTcuM7gHkwzCBwYwLjE2LjXIBzeACAE&sclient=gws-wiz-serp"
        "https://spec.graphql.org/"
        "https://chromedevtools.github.io/devtools-protocol/"
        "https://github.com/ChrisNikkel/GraphVG"
        "https://chromewebstore.google.com/detail/listgrab-%E2%80%94-copy-any-list/fhdpjaknemhaffinamdakedlhlffjkki"
        "https://ukgovld.github.io/ukgovldwg/recommendations/uri-patterns.html#reference-one"
        "https://w3c.github.io/rdf-concepts/spec/#vocabularies"
        "https://grafeo.dev/#__tabbed_3_1"
        "https://www.nuget.org/packages/Universal.Common.Threading.Tasks"
        "about:blank"
        "https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/MIME_types/Common_types"
        "https://www.google.com/search?q=f%23+pattern+match+last+char+of+char+array&rlz=1C1GCEB_enUS799US799&oq=f%23+pattern+match+last+char+of++char+array&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQABjvBTIHCAIQABjvBTIGCAMQRRg60gEJMTA2MjBqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://spec.openapis.org/oas/latest.html#path-templating"
        "https://chromewebstore.google.com/detail/element-outliner/anocibakijmiilifbbllfmnfafkfacmm"
        "https://github.com/microsoftgraph/microsoft-graph-docs-contrib/blob/main/api-reference/beta/resources/user.md"
        "https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Query"
        "https://learn.microsoft.com/en-us/dotnet/api/system.io.driveinfo?view=net-10.0"
        "https://www.nuget.org/packages/Universal.Common.Reflection"
        "https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/operator-overloading"
        "https://www.nuget.org/packages/GrafeoDB"
        "https://fsprojects.github.io/FSharp.TypeProviders.SDK/"
        "https://developer.mozilla.org/en-US/docs/Web/API"
        "https://learn.microsoft.com/en-us/dotnet/api/system.io?view=net-11.0-pp"
        "https://www.w3.org/TR/csv2rdf/"
        "https://github.com/dotnet/aspnetcore"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.Slug/readme.md"
        "https://qudt.org/3.1.10/vocab/constant"
        "https://acoli-repo.github.io/ontolex-frac/"
        "https://learn.microsoft.com/en-us/dotnet/api/microsoft.sqlserver.dac.model.tsqlmodelschema?view=sql-dacfx-162"
        "https://github.com/meziantou/Meziantou.Framework/blob/main/src/Meziantou.Framework.Uri/readme.md"
        "https://www.google.com/search?q=rfc+uri+template+vs+whatwg+url+pattern&sca_esv=e20246a2af79b3a3&rlz=1C1GCEB_enUS799US799&ei=FWCsasr6Auyup84P95PYwAc&biw=902&bih=981&ved=2ahUKEwiK2eToy_aWAxVs18kDHfcJFngQ4dUDegQIBhAM&uact=5&oq=rfc+uri+template+vs+whatwg+url+pattern&gs_lp=Egxnd3Mtd2l6LXNlcnAiJnJmYyB1cmkgdGVtcGxhdGUgdnMgd2hhdHdnIHVybCBwYXR0ZXJuMgUQABjvBTIFEAAY7wUyBRAAGO8FMgUQABjvBTIFEAAY7wVIjiZQkApY5CRwAXgBkAEAmAG0AaABggyqAQQxLjEwuAEDyAEA-AEBmAIIoALRB8ICChAAGEcY1gQYsAOYAwCIBgGQBgqSBwMxLjegB8MWsgcDMC43uAfLB8IHBTAuNy4xyAcQgAgB&sclient=gws-wiz-serp"
        "https://learn.microsoft.com/en-us/nuget/consume-packages/finding-and-choosing-packages#search-syntax"
        "https://bizcoder.com/constructing-urls-the-easy-way/"
        "https://www.google.com/search?q=rdf+events&rlz=1C1GCEB_enUS799US799&oq=rdf+events&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQABjvBTIHCAIQABjvBTIHCAMQABjvBTIHCAQQABjvBdIBCDE2NTdqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8"
        "https://www.w3.org/TR/rdb-direct-mapping/"
        "https://url.spec.whatwg.org/#biblio-rfc1034"
        "https://www.cambiaresearch.com/articles/730004/the-dotnet-uri-class-and-the-cambia.uriextensions-nuget-package"
        "https://www.nuget.org/profiles/ong.andrew?page=10"
        "https://www.nuget.org/packages/Universal.Common.Mathematics"
        "https://allegrograph.com/wp-content/uploads/2021/04/Event-Processing-using-an-RDF-Database.pdf"
        "https://www.google.com/search?q=are+towels+linen&sca_esv=e9ef250f52a78cc1&rlz=1C1GCEB_enUS799US799&biw=1864&bih=983&ei=pdOmasDhApK7p84Puf2O8Aw&ved=2ahUKEwiAyMSXgeyWAxWS3ckDHbm-A84Q4dUDegQIBhAM&uact=5&oq=are+towels+linen&gs_lp=Egxnd3Mtd2l6LXNlcnAiEGFyZSB0b3dlbHMgbGluZW4yBxAAGIAEGBMyBhAAGB4YEzIIEAAYCBgeGBMyCBAAGAgYHhgTMggQABgIGB4YEzIIEAAYCBgeGBMyCBAAGAgYHhgTMggQABgIGB4YEzIIEAAYCBgeGBMyCBAAGAgYHhgTSIIZUPoJWJcYcAF4AZABAJgBwQGgAeQMqgEEMTAuNrgBA8gBAPgBAZgCEaACzQ3CAgoQABhHGNYEGLADwgIKEAAYgAQYigUYQ8ICBRAAGIAEwgIHEAAYgAQYBMICCBAAGIAEGLQHwgIMEAAYgAQYDRgTGLQHwgIKEAAYgAQYDRi0B8ICBxAAGIAEGA3CAgoQABiABBgTGLQHwgIEEAAYHsICBhAAGB4YCsICBRAAGO8FwgIGEAAYCBgemAMAiAYBkAYHkgcDOS44oAeQNbIHAzguOLgHxA3CBwgwLjEwLjQuM8gHVIAIAQ&sclient=gws-wiz-serp"
        "about:blank"
        "https://www.nuget.org/packages?q=freemind&includeComputedFrameworks=true&prerel=true"
        "https://www.w3.org/TR/r2rml/#vocabulary"
        "https://www.puppeteersharp.com/api/index.html"
    |]
    |> Array.map (fun uriString -> Uri uriString |> WhatwgSite.fromUri)


// |> Array.groupBy (fun site -> site.scheme.lexicalForm, site.host.topLevelDomain.Value.tldRule.Name, site.host.secondLevelDomain.Value, site.host.subdomain)
let groups =
    testSites
    |> Array.groupBy (fun site -> site.scheme.lexicalForm)
    |> Array.map (fun (scheme, sites) -> scheme, sites |> Array.groupBy (fun site -> site.host.topLevelDomain.Value.tldRule.Name))
    |> Array.map (fun (scheme, sites) -> scheme, sites |> Array.groupBy (fun site -> site.host.topLevelDomain.Value.tldRule.Name))



groups[0]


let schemeModuleBinder = PrettierNaming.ModuleBinder this.scheme.lexicalForm
let schemeVariableBinder = PrettierNaming.VariableBinder this.scheme.lexicalForm

Ast.Oak() {
    Ast.AnonymousModule() {

        Ast.HashDirective("I", Ast.VerbatimString @"D:\https\com\github\eristocrates\ipa\dll\")
        Ast.HashDirective("r", Ast.VerbatimString @"StringModule.dll")
        Ast.HashDirective("r", Ast.VerbatimString @"Internet.dll")
        Ast.HashDirective("r", Ast.VerbatimString @"TopLevelDomain.dll")
        Ast.HashDirective("r", Ast.VerbatimString @"IanaScheme.dll")
        Ast.HashDirective("I", Ast.VerbatimString @"D:\https\com\github\eristocrates\ipa\fsx\")
        Ast.HashDirective("load", Ast.VerbatimString "PrettierNaming.fsx")
        Ast.Open("Internet")
        Ast.Open("StringModule")
        Ast.HashDirective("load", Ast.VerbatimString @".paket/load/main.group.fsx")
        Ast.Open("System")
        Ast.Module(schemeModuleBinder.binding) {
            Ast.Value("scheme", $"IanaScheme.{schemeVariableBinder.binding}")
            match this.host.topLevelDomain with
            | Some topLevelDomain ->
                let topLevelDomainModuleBinder = PrettierNaming.ModuleBinder topLevelDomain.tldRule.Name
                let topLevelDomainVariableBinder = PrettierNaming.VariableBinder topLevelDomain.tldRule.Name
                Ast.Module(topLevelDomainModuleBinder.binding) {
                    Ast.Value("topLevelDomain", $"TopLevelDomain.{topLevelDomainVariableBinder.binding}")
                    match this.host.secondLevelDomain with
                    | Some secondLevelDomain ->
                        let secondLevelDomainModuleBinder = PrettierNaming.ModuleBinder secondLevelDomain
                        Ast.Module(secondLevelDomainModuleBinder.binding) {
                            Ast.Value("secondLevelDomain", Ast.String secondLevelDomainModuleBinder.identifier)
                            Ast.Value("host", Ast.ConstantExpr "secondLevelDomain +. topLevelDomain")
                            Ast.Value("site", Ast.ConstantExpr "scheme ..// host")
                            match this.host.subdomain with
                            | Some subdomain ->
                                let subdomainModuleBinder = PrettierNaming.ModuleBinder subdomain
                                Ast.Module(subdomainModuleBinder.binding) {
                                    if subdomain = "www" then
                                        Ast.Value("site", Ast.ConstantExpr "scheme |> www secondLevelDomain topLevelDomain")
                                    else
                                        Ast.Value("site", Ast.ConstantExpr $"site .+ \"{subdomain}\"")
                                }
                            | None -> ()
                        }
                    | None -> ()
                }
            | None -> ()
        }
    }
}
|> Gen.mkOak
|> Gen.run
















module faster =
    open System.Web
    let site = Site.https.com.fasterwebcloud.leoncountyfl.site
    let space = site +/ "FASTER/Domains/{Domain}/Default.aspx"
    let Domain (Domain) =
        space.pathTemplate.AddParameter("Domain", Domain).Resolve()
        |> HttpUtility.UrlDecode
        |> Iri.fromString
    let Home = Domain "Home"
    let Assets = Domain "Assets"
    let Inventory = Domain "Inventory"
    let Maintenance = Domain "Maintenance"
    let Fuel = Domain "Fuel"
    let Accounting = Domain "Accounting"
    let Vendors = Domain "Vendors"
    let Setup = Domain "Setup"
    let Reports = Domain "Reports"
    let Dashboard = Domain "Dashboard"
    let Integrations = Domain "Integrations"


faster.Accounting.remoteReference.clip

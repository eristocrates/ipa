#if INTERACTIVE
#load "PrefixDeclaration.fsx"
#endif

open Shorthand
open Shorthand.LangTag
open PrefixDeclaration



let a = rdf.``type``

ipa.OpenHomeFoundation --- a --> org.Organization >-: defaultGraph
ipa.OpenHomeFoundation --- a --> prov.Organization >-: defaultGraph
ipa.OpenHomeFoundation --- a --> foaf.Organization >-: defaultGraph
ipa.OpenHomeFoundation --- foaf.homepage --> "https://www.openhomefoundation.org" ^^ shacl.IRI >-: defaultGraph
ipa.OpenHomeFoundation --- foaf.name --> "Open Home Foundation" @@ en  >-: defaultGraph

ipa.HomeAssistantProject --- a --> doap.Project >-: defaultGraph
ipa.HomeAssistantProject --- doap.name --> "Home Assistant" @@ en >-: defaultGraph
ipa.HomeAssistantProject --- doap.homepage --> "https://www.home-assistant.io/" ^^ shacl.IRI >-: defaultGraph
ipa.HomeAssistantProject --- prov.wasAttributedTo --> ipa.OpenHomeFoundation >-: defaultGraph

ipa.HomeAssistantProject --- doap.description --> "Home Assistant is an open source, home automation platform that puts local control and privacy first. It is powered by a worldwide community of tinkerers and DIY enthusiasts, and exists to put users in control of their homes, their data, and their personal well-being." @@ en >-: defaultGraph

ipa.NabuCasa --- a --> org.Organization >-: defaultGraph
ipa.NabuCasa --- a --> prov.Organization >-: defaultGraph
ipa.NabuCasa --- a --> foaf.Organization >-: defaultGraph
ipa.NabuCasa --- foaf.homepage --> "https://www.nabucasa.com" ^^ shacl.IRI >-: defaultGraph
ipa.NabuCasa --- foaf.name --> "Nabu Casa" @@ en >-: defaultGraph


ipa.HomeAssistantGreenModel --- a --> saref.DeviceKind >-: defaultGraph
ipa.HomeAssistantGreenModel --- a --> gr.ProductOrServiceModel >-: defaultGraph
ipa.HomeAssistantGreenModel --- schema.manufacturer --> ipa.NabuCasa >-: defaultGraph
ipa.HomeAssistantGreenModel --- prov.wasInfluencedBy --> ipa.HomeAssistantPlatform >-: defaultGraph

ipa.HomeAssistantGreenUnit --- a --> saref.Device >-: defaultGraph
ipa.HomeAssistantGreenUnit --- a --> gr.Individual >-: defaultGraph
ipa.HomeAssistantGreenUnit --- gr.hasMakeAndModel --> ipa.HomeAssistantGreenModel >-: defaultGraph
ipa.HomeAssistantGreenUnit --- saref.hasDeviceKind --> ipa.HomeAssistantGreenModel >-: defaultGraph


ipa.HomeAssistantOperatingSystem --- a --> sd.Software >-: defaultGraph
ipa.HomeAssistantOperatingSystem --- a --> schema.OperatingSystem >-: defaultGraph
ipa.HomeAssistantOperatingSystem --- a --> spdx3.Software_.SoftwareArtifact >-: defaultGraph
ipa.HomeAssistantOperatingSystem --- dolce.ultralite_.isPartOf --> ipa.HomeAssistantPlatform >-: defaultGraph

ipa.HomeAssistantSupervisor --- a --> sd.Software >-: defaultGraph
ipa.HomeAssistantSupervisor --- a --> spdx3.Software_.SoftwareArtifact >-: defaultGraph
ipa.HomeAssistantSupervisor --- dolce.ultralite_.isPartOf --> ipa.HomeAssistantPlatform >-: defaultGraph

ipa.HomeAssistantCore --- a --> sd.Software >-: defaultGraph
ipa.HomeAssistantCore --- a --> spdx3.Software_.SoftwareArtifact >-: defaultGraph
ipa.HomeAssistantCore --- dolce.ultralite_.isPartOf --> ipa.HomeAssistantPlatform >-: defaultGraph

ipa.HomeAssistantPlatform --- prov.wasAttributedTo --> ipa.HomeAssistantProject >-: defaultGraph
ipa.HomeAssistantPlatform --- a --> spdx3.Software_.SoftwareArtifact >-: defaultGraph

ipa.HomeAssistantPlatform_contains_Core --- a --> spdx3.Core_.Relationship >-: defaultGraph

ipa.HomeAssistantPlatform_contains_Core --- spdx3.Core_.relationshipType --> spdx3.Core_.RelationshipType_.contains >-: defaultGraph

ipa.HomeAssistantPlatform_contains_Core --- a --> spdx3.Core_.Relationship >-: defaultGraph
ipa.HomeAssistantPlatform_contains_Core --- a --> spdx3.Core_.Relationship >-: defaultGraph


Serialization.Turtle.save Artifact.test.ttl Graph.``default``

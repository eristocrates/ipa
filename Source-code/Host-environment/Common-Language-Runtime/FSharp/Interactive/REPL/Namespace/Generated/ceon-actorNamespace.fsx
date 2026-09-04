#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-actor`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/actor/" "ceon-actor"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actor Circular Value Network role^^xsd:string</para>
    ///   <para>rdfs:comment : The role(s) of an actor in a Circular Value Network, which is a specific type of collaboration.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ActorCVNRole">ceon-actor:ActorCVNRole</a>
    /// </summary>
    let ActorCVNRole = _prefixId.prefix "ActorCVNRole"
    /// <summary>
    ///   <para>rdfs:label : Actor collaboration role^^xsd:string</para>
    ///   <para>rdfs:comment : The roles of an actor involved in a collaboration.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ActorCollaborationRole">ceon-actor:ActorCollaborationRole</a>
    /// </summary>
    let ActorCollaborationRole = _prefixId.prefix "ActorCollaborationRole"
    /// <summary>
    ///   <para>rdfs:label : Actor process role^^xsd:string</para>
    ///   <para>rdfs:comment : The role(s) of an actor involved in a process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ActorProcessRole">ceon-actor:ActorProcessRole</a>
    /// </summary>
    let ActorProcessRole = _prefixId.prefix "ActorProcessRole"
    /// <summary>
    ///   <para>rdfs:label : Actor resource role^^xsd:string</para>
    ///   <para>rdfs:comment : The role(s) of an actor in relation to a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ActorResourceRole">ceon-actor:ActorResourceRole</a>
    /// </summary>
    let ActorResourceRole = _prefixId.prefix "ActorResourceRole"
    /// <summary>
    ///   <para>rdfs:label : Buying resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the buyer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/BuyingResource">ceon-actor:BuyingResource</a>
    /// </summary>
    let BuyingResource = _prefixId.prefix "BuyingResource"
    /// <summary>
    ///   <para>rdfs:label : Circular Value Network Participation^^xsd:string</para>
    ///   <para>rdfs:comment : A participation-relation, that represents the participation of an actor in a CVN with a certain role. For instance, a specific company playing the role of recycler in a certain flow of a CVN. The participation may also be related to a certain time (or time interval).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/CVNParticipation">ceon-actor:CVNParticipation</a>
    /// </summary>
    let CVNParticipation = _prefixId.prefix "CVNParticipation"
    /// <summary>
    ///   <para>rdfs:label : Consuming resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the consumer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ConsumingResource">ceon-actor:ConsumingResource</a>
    /// </summary>
    let ConsumingResource = _prefixId.prefix "ConsumingResource"
    /// <summary>
    ///   <para>rdfs:label : Dismantling resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the dismantler of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/DismantlingResource">ceon-actor:DismantlingResource</a>
    /// </summary>
    let DismantlingResource = _prefixId.prefix "DismantlingResource"
    /// <summary>
    ///   <para>rdfs:label : Issuing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the issuer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/IssuingResource">ceon-actor:IssuingResource</a>
    /// </summary>
    let IssuingResource = _prefixId.prefix "IssuingResource"
    /// <summary>
    ///   <para>rdfs:label : Manufacturing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the manufacturer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ManufacturingResource">ceon-actor:ManufacturingResource</a>
    /// </summary>
    let ManufacturingResource = _prefixId.prefix "ManufacturingResource"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 - 3.4.1 organization^^xsd:string</para>
    ///   <para>rdfs:comment : Person or group of people that has its own functions with responsibilities, authorities, and relationships to achieve its objectives. The concept of organization includes, but is not limited to sole-trader, company, corporation, firm, enterprise, authority, partnership, charity or institution, or part or combination thereof, whether incorporated or not, public or private (e.g. foundation, union, association, agency, municipality, region, country, intergovernmental agencies). A group of organizations can also be considered as	an organization that has, alone or collectively,their own objectives.</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/Organisation">ceon-actor:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Organisation Location^^xsd:string</para>
    ///   <para>rdfs:comment : Location of an organisation^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/OrganisationLocation">ceon-actor:OrganisationLocation</a>
    /// </summary>
    let OrganisationLocation = _prefixId.prefix "OrganisationLocation"
    /// <summary>
    ///   <para>rdfs:label : Owning resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the owner of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/OwningResource">ceon-actor:OwningResource</a>
    /// </summary>
    let OwningResource = _prefixId.prefix "OwningResource"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/Person">ceon-actor:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Process Participation^^xsd:string</para>
    ///   <para>rdfs:comment : Participation of a certain actor in a certain process, with a certain role. For instance, a certain department of a recycling company having the role of quality controllant, or material sorter, in a certain recycling process. The participation may also be given a time, e.g. a start and end time.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ProcessParticipation">ceon-actor:ProcessParticipation</a>
    /// </summary>
    let ProcessParticipation = _prefixId.prefix "ProcessParticipation"
    /// <summary>
    ///   <para>rdfs:label : Producing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the producer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ProducingResource">ceon-actor:ProducingResource</a>
    /// </summary>
    let ProducingResource = _prefixId.prefix "ProducingResource"
    /// <summary>
    ///   <para>rdfs:label : Providing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the provider of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ProvidingResource">ceon-actor:ProvidingResource</a>
    /// </summary>
    let ProvidingResource = _prefixId.prefix "ProvidingResource"
    /// <summary>
    ///   <para>rdfs:label : Recycling resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the recycler of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/RecyclingResource">ceon-actor:RecyclingResource</a>
    /// </summary>
    let RecyclingResource = _prefixId.prefix "RecyclingResource"
    /// <summary>
    ///   <para>rdfs:label : Repairing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the repairer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/RepairingResource">ceon-actor:RepairingResource</a>
    /// </summary>
    let RepairingResource = _prefixId.prefix "RepairingResource"
    /// <summary>
    ///   <para>rdfs:label : Reselling resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the reseller of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ResellingResource">ceon-actor:ResellingResource</a>
    /// </summary>
    let ResellingResource = _prefixId.prefix "ResellingResource"
    /// <summary>
    ///   <para>rdfs:label : Selling resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the seller of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/SellingResource">ceon-actor:SellingResource</a>
    /// </summary>
    let SellingResource = _prefixId.prefix "SellingResource"
    /// <summary>
    ///   <para>rdfs:label : Stakeholderrdfs:label : Interested Party^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 - 3.4.2 interested party, stakeholder^^xsd:string</para>
    ///   <para>rdfs:comment : Person or organization that can affect, be affected by, or perceive itself to be affected by a decision or activity. To “perceive itself to be affected” means the perception has been made known to the organization.</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/Stakeholder">ceon-actor:Stakeholder</a>
    /// </summary>
    let Stakeholder = _prefixId.prefix "Stakeholder"
    /// <summary>
    ///   <para>rdfs:label : Supplying resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the supplier of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/SupplyingResource">ceon-actor:SupplyingResource</a>
    /// </summary>
    let SupplyingResource = _prefixId.prefix "SupplyingResource"
    /// <summary>
    ///   <para>rdfs:label : Taking back resource^^xsd:stringrdfs:label : The relation where the role of the actor is the collector of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/TakingBackResource">ceon-actor:TakingBackResource</a>
    /// </summary>
    let TakingBackResource = _prefixId.prefix "TakingBackResource"
    /// <summary>
    ///   <para>rdfs:label : Updating resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the updater of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/UpdatingResource">ceon-actor:UpdatingResource</a>
    /// </summary>
    let UpdatingResource = _prefixId.prefix "UpdatingResource"
    /// <summary>
    ///   <para>rdfs:label : Using resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the user of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/UsingResource">ceon-actor:UsingResource</a>
    /// </summary>
    let UsingResource = _prefixId.prefix "UsingResource"
    /// <summary>
    ///   <para>rdfs:label : Viewing resource^^xsd:string</para>
    ///   <para>rdfs:comment : The relation where the role of the actor is the viewer of a certain resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/ViewingResource">ceon-actor:ViewingResource</a>
    /// </summary>
    let ViewingResource = _prefixId.prefix "ViewingResource"
    let buyer = _prefixId.prefix "buyer"
    /// <summary>
    ///   <para>rdfs:label : capability extent^^xsd:string</para>
    ///   <para>rdfs:comment : The extent of this capability, e.g. stating whether there are limist to the capability, such as a maximum amount or size of something.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/capabilityExtent">ceon-actor:capabilityExtent</a>
    /// </summary>
    let capabilityExtent = _prefixId.prefix "capabilityExtent"
    let collector = _prefixId.prefix "collector"
    let consumer = _prefixId.prefix "consumer"
    let dismantler = _prefixId.prefix "dismantler"
    /// <summary>
    ///   <para>rdfs:label : has organisation location^^xsd:string</para>
    ///   <para>rdfs:comment : Represent that an organisation has some locations.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/hasOrganisationLocation">ceon-actor:hasOrganisationLocation</a>
    /// </summary>
    let hasOrganisationLocation = _prefixId.prefix "hasOrganisationLocation"
    /// <summary>
    ///   <para>rdfs:label : Represent name of an organisation.^^xsd:stringrdfs:label : has organisation name^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/hasOrganisationName">ceon-actor:hasOrganisationName</a>
    /// </summary>
    let hasOrganisationName = _prefixId.prefix "hasOrganisationName"
    let issuer = _prefixId.prefix "issuer"
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:label : needed resource relations^^xsd:string</para>
    ///   <para>rdfs:comment : In order for an actor to have a capability, it needs to have certain resources, e.g. materials, infrastrucutre, know-how, information etc.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actor/neededResourceRelation">ceon-actor:neededResourceRelation</a>
    /// </summary>
    let neededResourceRelation = _prefixId.prefix "neededResourceRelation"
    let owner = _prefixId.prefix "owner"
    let producer = _prefixId.prefix "producer"
    let provider = _prefixId.prefix "provider"
    let recycler = _prefixId.prefix "recycler"
    let repairer = _prefixId.prefix "repairer"
    let reseller = _prefixId.prefix "reseller"
    let seller = _prefixId.prefix "seller"
    let supplier = _prefixId.prefix "supplier"
    let updater = _prefixId.prefix "updater"
    let user = _prefixId.prefix "user"
    let viewer = _prefixId.prefix "viewer"

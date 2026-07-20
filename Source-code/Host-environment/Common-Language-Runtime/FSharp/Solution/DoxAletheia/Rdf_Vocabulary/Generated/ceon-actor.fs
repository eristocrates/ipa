namespace http.w3id.org.CEON.ontology.actor.slash

open DoxAletheia

module ceon_actor =
    let _namespace_name = "http://w3id.org/CEON/ontology/actor/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/0.4/"></see>
    /// </summary>
    let ``_0.4/`` = _prefix "0.4/"
    /// <summary>
    /// The role(s) of an actor in a Circular Value Network, which is a specific type of collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorCVNRole"></see></summary>
    let ActorCVNRole = _prefix "ActorCVNRole"
    /// <summary>
    /// The roles of an actor involved in a collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorCollaborationRole"></see></summary>
    let ActorCollaborationRole = _prefix "ActorCollaborationRole"
    /// <summary>
    /// The role(s) of an actor involved in a process.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorProcessRole"></see></summary>
    let ActorProcessRole = _prefix "ActorProcessRole"
    /// <summary>
    /// The role(s) of an actor in relation to a resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorResourceRole"></see></summary>
    let ActorResourceRole = _prefix "ActorResourceRole"
    /// <summary>
    /// The relation where the role of the actor is the buyer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/BuyingResource"></see></summary>
    let BuyingResource = _prefix "BuyingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/buyer"></see>
    /// </summary>
    let buyer = _prefix "buyer"
    /// <summary>
    /// A participation-relation, that represents the participation of an actor in a CVN with a certain role. For instance, a specific company playing the role of recycler in a certain flow of a CVN. The participation may also be related to a certain time (or time interval).
    /// <see href="http://w3id.org/CEON/ontology/actor/CVNParticipation"></see></summary>
    let CVNParticipation = _prefix "CVNParticipation"
    /// <summary>
    /// The relation where the role of the actor is the consumer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ConsumingResource"></see></summary>
    let ConsumingResource = _prefix "ConsumingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/consumer"></see>
    /// </summary>
    let consumer = _prefix "consumer"
    /// <summary>
    /// The relation where the role of the actor is the dismantler of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/DismantlingResource"></see></summary>
    let DismantlingResource = _prefix "DismantlingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/dismantler"></see>
    /// </summary>
    let dismantler = _prefix "dismantler"
    /// <summary>
    /// The relation where the role of the actor is the issuer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/IssuingResource"></see></summary>
    let IssuingResource = _prefix "IssuingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/issuer"></see>
    /// </summary>
    let issuer = _prefix "issuer"
    /// <summary>
    /// The relation where the role of the actor is the manufacturer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ManufacturingResource"></see></summary>
    let ManufacturingResource = _prefix "ManufacturingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/manufacturer"></see>
    /// </summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// Person or group of people that has its own functions with responsibilities, authorities, and relationships to achieve its objectives. The concept of organization includes, but is not limited to sole-trader, company, corporation, firm, enterprise, authority, partnership, charity or institution, or part or combination thereof, whether incorporated or not, public or private (e.g. foundation, union, association, agency, municipality, region, country, intergovernmental agencies). A group of organizations can also be considered as	an organization that has, alone or collectively,their own objectives.
    /// <see href="http://w3id.org/CEON/ontology/actor/Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// Location of an organisation
    /// <see href="http://w3id.org/CEON/ontology/actor/OrganisationLocation"></see></summary>
    let OrganisationLocation = _prefix "OrganisationLocation"
    /// <summary>
    /// Represent that an organisation has some locations.
    /// <see href="http://w3id.org/CEON/ontology/actor/hasOrganisationLocation"></see></summary>
    let hasOrganisationLocation = _prefix "hasOrganisationLocation"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/hasOrganisationName"></see>
    /// </summary>
    let hasOrganisationName = _prefix "hasOrganisationName"
    /// <summary>
    /// The relation where the role of the actor is the owner of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/OwningResource"></see></summary>
    let OwningResource = _prefix "OwningResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Participation of a certain actor in a certain process, with a certain role. For instance, a certain department of a recycling company having the role of quality controllant, or material sorter, in a certain recycling process. The participation may also be given a time, e.g. a start and end time.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProcessParticipation"></see></summary>
    let ProcessParticipation = _prefix "ProcessParticipation"
    /// <summary>
    /// The relation where the role of the actor is the producer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProducingResource"></see></summary>
    let ProducingResource = _prefix "ProducingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/producer"></see>
    /// </summary>
    let producer = _prefix "producer"
    /// <summary>
    /// The relation where the role of the actor is the provider of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProvidingResource"></see></summary>
    let ProvidingResource = _prefix "ProvidingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/provider"></see>
    /// </summary>
    let provider = _prefix "provider"
    /// <summary>
    /// The relation where the role of the actor is the recycler of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/RecyclingResource"></see></summary>
    let RecyclingResource = _prefix "RecyclingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/recycler"></see>
    /// </summary>
    let recycler = _prefix "recycler"
    /// <summary>
    /// The relation where the role of the actor is the repairer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/RepairingResource"></see></summary>
    let RepairingResource = _prefix "RepairingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/repairer"></see>
    /// </summary>
    let repairer = _prefix "repairer"
    /// <summary>
    /// The relation where the role of the actor is the reseller of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ResellingResource"></see></summary>
    let ResellingResource = _prefix "ResellingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/reseller"></see>
    /// </summary>
    let reseller = _prefix "reseller"
    /// <summary>
    /// The relation where the role of the actor is the seller of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/SellingResource"></see></summary>
    let SellingResource = _prefix "SellingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/seller"></see>
    /// </summary>
    let seller = _prefix "seller"
    /// <summary>
    /// Person or organization that can affect, be affected by, or perceive itself to be affected by a decision or activity. To “perceive itself to be affected” means the perception has been made known to the organization.
    /// <see href="http://w3id.org/CEON/ontology/actor/Stakeholder"></see></summary>
    let Stakeholder = _prefix "Stakeholder"
    /// <summary>
    /// The relation where the role of the actor is the supplier of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/SupplyingResource"></see></summary>
    let SupplyingResource = _prefix "SupplyingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/supplier"></see>
    /// </summary>
    let supplier = _prefix "supplier"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/TakingBackResource"></see>
    /// </summary>
    let TakingBackResource = _prefix "TakingBackResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/collector"></see>
    /// </summary>
    let collector = _prefix "collector"
    /// <summary>
    /// The relation where the role of the actor is the updater of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/UpdatingResource"></see></summary>
    let UpdatingResource = _prefix "UpdatingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/updater"></see>
    /// </summary>
    let updater = _prefix "updater"
    /// <summary>
    /// The relation where the role of the actor is the user of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/UsingResource"></see></summary>
    let UsingResource = _prefix "UsingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/user"></see>
    /// </summary>
    let user = _prefix "user"
    /// <summary>
    /// The relation where the role of the actor is the viewer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ViewingResource"></see></summary>
    let ViewingResource = _prefix "ViewingResource"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/viewer"></see>
    /// </summary>
    let viewer = _prefix "viewer"
    /// <summary>
    /// The extent of this capability, e.g. stating whether there are limist to the capability, such as a maximum amount or size of something.
    /// <see href="http://w3id.org/CEON/ontology/actor/capabilityExtent"></see></summary>
    let capabilityExtent = _prefix "capabilityExtent"
    /// <summary>
    /// In order for an actor to have a capability, it needs to have certain resources, e.g. materials, infrastrucutre, know-how, information etc.
    /// <see href="http://w3id.org/CEON/ontology/actor/neededResourceRelation"></see></summary>
    let neededResourceRelation = _prefix "neededResourceRelation"

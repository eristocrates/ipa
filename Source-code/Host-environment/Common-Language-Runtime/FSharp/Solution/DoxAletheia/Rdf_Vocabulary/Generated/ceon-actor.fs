namespace http.w3id.org.CEON.ontology.actor.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_actor =
    let _namespace_name = "http://w3id.org/CEON/ontology/actor/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/0.4/"></see>
    /// </summary>
    let ``_0.4/`` = Namespaced_IRI.parse _namespace_name "0.4/" |> NamespacedName

    /// <summary>
    /// The role(s) of an actor in a Circular Value Network, which is a specific type of collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorCVNRole"></see></summary>
    let ActorCVNRole =
        Namespaced_IRI.parse _namespace_name "ActorCVNRole" |> NamespacedName

    /// <summary>
    /// The roles of an actor involved in a collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorCollaborationRole"></see></summary>
    let ActorCollaborationRole =
        Namespaced_IRI.parse _namespace_name "ActorCollaborationRole" |> NamespacedName

    /// <summary>
    /// The role(s) of an actor involved in a process.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorProcessRole"></see></summary>
    let ActorProcessRole =
        Namespaced_IRI.parse _namespace_name "ActorProcessRole" |> NamespacedName

    /// <summary>
    /// The role(s) of an actor in relation to a resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ActorResourceRole"></see></summary>
    let ActorResourceRole =
        Namespaced_IRI.parse _namespace_name "ActorResourceRole" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the buyer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/BuyingResource"></see></summary>
    let BuyingResource =
        Namespaced_IRI.parse _namespace_name "BuyingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/buyer"></see>
    /// </summary>
    let buyer = Namespaced_IRI.parse _namespace_name "buyer" |> NamespacedName

    /// <summary>
    /// A participation-relation, that represents the participation of an actor in a CVN with a certain role. For instance, a specific company playing the role of recycler in a certain flow of a CVN. The participation may also be related to a certain time (or time interval).
    /// <see href="http://w3id.org/CEON/ontology/actor/CVNParticipation"></see></summary>
    let CVNParticipation =
        Namespaced_IRI.parse _namespace_name "CVNParticipation" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the consumer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ConsumingResource"></see></summary>
    let ConsumingResource =
        Namespaced_IRI.parse _namespace_name "ConsumingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/consumer"></see>
    /// </summary>
    let consumer = Namespaced_IRI.parse _namespace_name "consumer" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the dismantler of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/DismantlingResource"></see></summary>
    let DismantlingResource =
        Namespaced_IRI.parse _namespace_name "DismantlingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/dismantler"></see>
    /// </summary>
    let dismantler = Namespaced_IRI.parse _namespace_name "dismantler" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the issuer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/IssuingResource"></see></summary>
    let IssuingResource =
        Namespaced_IRI.parse _namespace_name "IssuingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/issuer"></see>
    /// </summary>
    let issuer = Namespaced_IRI.parse _namespace_name "issuer" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the manufacturer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ManufacturingResource"></see></summary>
    let ManufacturingResource =
        Namespaced_IRI.parse _namespace_name "ManufacturingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// Person or group of people that has its own functions with responsibilities, authorities, and relationships to achieve its objectives. The concept of organization includes, but is not limited to sole-trader, company, corporation, firm, enterprise, authority, partnership, charity or institution, or part or combination thereof, whether incorporated or not, public or private (e.g. foundation, union, association, agency, municipality, region, country, intergovernmental agencies). A group of organizations can also be considered as	an organization that has, alone or collectively,their own objectives.
    /// <see href="http://w3id.org/CEON/ontology/actor/Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// Location of an organisation
    /// <see href="http://w3id.org/CEON/ontology/actor/OrganisationLocation"></see></summary>
    let OrganisationLocation =
        Namespaced_IRI.parse _namespace_name "OrganisationLocation" |> NamespacedName

    /// <summary>
    /// Represent that an organisation has some locations.
    /// <see href="http://w3id.org/CEON/ontology/actor/hasOrganisationLocation"></see></summary>
    let hasOrganisationLocation =
        Namespaced_IRI.parse _namespace_name "hasOrganisationLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/hasOrganisationName"></see>
    /// </summary>
    let hasOrganisationName =
        Namespaced_IRI.parse _namespace_name "hasOrganisationName" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the owner of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/OwningResource"></see></summary>
    let OwningResource =
        Namespaced_IRI.parse _namespace_name "OwningResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// Participation of a certain actor in a certain process, with a certain role. For instance, a certain department of a recycling company having the role of quality controllant, or material sorter, in a certain recycling process. The participation may also be given a time, e.g. a start and end time.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProcessParticipation"></see></summary>
    let ProcessParticipation =
        Namespaced_IRI.parse _namespace_name "ProcessParticipation" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the producer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProducingResource"></see></summary>
    let ProducingResource =
        Namespaced_IRI.parse _namespace_name "ProducingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/producer"></see>
    /// </summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the provider of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ProvidingResource"></see></summary>
    let ProvidingResource =
        Namespaced_IRI.parse _namespace_name "ProvidingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/provider"></see>
    /// </summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the recycler of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/RecyclingResource"></see></summary>
    let RecyclingResource =
        Namespaced_IRI.parse _namespace_name "RecyclingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/recycler"></see>
    /// </summary>
    let recycler = Namespaced_IRI.parse _namespace_name "recycler" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the repairer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/RepairingResource"></see></summary>
    let RepairingResource =
        Namespaced_IRI.parse _namespace_name "RepairingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/repairer"></see>
    /// </summary>
    let repairer = Namespaced_IRI.parse _namespace_name "repairer" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the reseller of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ResellingResource"></see></summary>
    let ResellingResource =
        Namespaced_IRI.parse _namespace_name "ResellingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/reseller"></see>
    /// </summary>
    let reseller = Namespaced_IRI.parse _namespace_name "reseller" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the seller of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/SellingResource"></see></summary>
    let SellingResource =
        Namespaced_IRI.parse _namespace_name "SellingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/seller"></see>
    /// </summary>
    let seller = Namespaced_IRI.parse _namespace_name "seller" |> NamespacedName

    /// <summary>
    /// Person or organization that can affect, be affected by, or perceive itself to be affected by a decision or activity. To “perceive itself to be affected” means the perception has been made known to the organization.
    /// <see href="http://w3id.org/CEON/ontology/actor/Stakeholder"></see></summary>
    let Stakeholder =
        Namespaced_IRI.parse _namespace_name "Stakeholder" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the supplier of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/SupplyingResource"></see></summary>
    let SupplyingResource =
        Namespaced_IRI.parse _namespace_name "SupplyingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/supplier"></see>
    /// </summary>
    let supplier = Namespaced_IRI.parse _namespace_name "supplier" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/TakingBackResource"></see>
    /// </summary>
    let TakingBackResource =
        Namespaced_IRI.parse _namespace_name "TakingBackResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/collector"></see>
    /// </summary>
    let collector = Namespaced_IRI.parse _namespace_name "collector" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the updater of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/UpdatingResource"></see></summary>
    let UpdatingResource =
        Namespaced_IRI.parse _namespace_name "UpdatingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/updater"></see>
    /// </summary>
    let updater = Namespaced_IRI.parse _namespace_name "updater" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the user of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/UsingResource"></see></summary>
    let UsingResource =
        Namespaced_IRI.parse _namespace_name "UsingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/user"></see>
    /// </summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName

    /// <summary>
    /// The relation where the role of the actor is the viewer of a certain resource.
    /// <see href="http://w3id.org/CEON/ontology/actor/ViewingResource"></see></summary>
    let ViewingResource =
        Namespaced_IRI.parse _namespace_name "ViewingResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actor/viewer"></see>
    /// </summary>
    let viewer = Namespaced_IRI.parse _namespace_name "viewer" |> NamespacedName

    /// <summary>
    /// The extent of this capability, e.g. stating whether there are limist to the capability, such as a maximum amount or size of something.
    /// <see href="http://w3id.org/CEON/ontology/actor/capabilityExtent"></see></summary>
    let capabilityExtent =
        Namespaced_IRI.parse _namespace_name "capabilityExtent" |> NamespacedName

    /// <summary>
    /// In order for an actor to have a capability, it needs to have certain resources, e.g. materials, infrastrucutre, know-how, information etc.
    /// <see href="http://w3id.org/CEON/ontology/actor/neededResourceRelation"></see></summary>
    let neededResourceRelation =
        Namespaced_IRI.parse _namespace_name "neededResourceRelation" |> NamespacedName

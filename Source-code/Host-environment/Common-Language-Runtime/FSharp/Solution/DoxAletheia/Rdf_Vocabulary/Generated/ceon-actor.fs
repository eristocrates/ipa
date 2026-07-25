namespace http.w3id.org.CEON.ontology.actor.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_actor =
    let _namespace_iri = Namespace_Iri ceon_actor |> NamespaceIRI

    /// <summary>
    ///   <para>ceon-actor:ActorResourceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role(s) of an actor in relation to a resource.</para>
    /// labels<para>Actor resource role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ActorResourceRole">http://w3id.org/CEON/ontology/actor/ActorResourceRole</seealso>
    let ActorResourceRole =
        Prefixed_Name(ceon_actor, "ActorResourceRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ManufacturingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the manufacturer of a certain resource.</para>
    /// labels<para>Manufacturing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ManufacturingResource">http://w3id.org/CEON/ontology/actor/ManufacturingResource</seealso>
    let ManufacturingResource =
        Prefixed_Name(ceon_actor, "ManufacturingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person or group of people that has its own functions with responsibilities, authorities, and relationships to achieve its objectives. The concept of organization includes, but is not limited to sole-trader, company, corporation, firm, enterprise, authority, partnership, charity or institution, or part or combination thereof, whether incorporated or not, public or private (e.g. foundation, union, association, agency, municipality, region, country, intergovernmental agencies). A group of organizations can also be considered as	an organization that has, alone or collectively,their own objectives.</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/Organisation">http://w3id.org/CEON/ontology/actor/Organisation</seealso>
    let Organisation = Prefixed_Name(ceon_actor, "Organisation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:OrganisationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location of an organisation</para>
    /// labels<para>Organisation Location</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/OrganisationLocation">http://w3id.org/CEON/ontology/actor/OrganisationLocation</seealso>
    let OrganisationLocation =
        Prefixed_Name(ceon_actor, "OrganisationLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:hasOrganisationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Represent name of an organisation.</para><para>has organisation name</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/hasOrganisationName">http://w3id.org/CEON/ontology/actor/hasOrganisationName</seealso>
    let hasOrganisationName =
        Prefixed_Name(ceon_actor, "hasOrganisationName") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:reseller</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/reseller">http://w3id.org/CEON/ontology/actor/reseller</seealso>
    let reseller = Prefixed_Name(ceon_actor, "reseller") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:Stakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person or organization that can affect, be affected by, or perceive itself to be affected by a decision or activity. To “perceive itself to be affected” means the perception has been made known to the organization.</para>
    /// labels<para>Interested Party</para><para>Stakeholder</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/Stakeholder">http://w3id.org/CEON/ontology/actor/Stakeholder</seealso>
    let Stakeholder = Prefixed_Name(ceon_actor, "Stakeholder") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/supplier">http://w3id.org/CEON/ontology/actor/supplier</seealso>
    let supplier = Prefixed_Name(ceon_actor, "supplier") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/">http://w3id.org/CEON/ontology/actor/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_actor, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:ActorCVNRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role(s) of an actor in a Circular Value Network, which is a specific type of collaboration.</para>
    /// labels<para>Actor Circular Value Network role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ActorCVNRole">http://w3id.org/CEON/ontology/actor/ActorCVNRole</seealso>
    let ActorCVNRole = Prefixed_Name(ceon_actor, "ActorCVNRole") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:ActorProcessRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role(s) of an actor involved in a process.</para>
    /// labels<para>Actor process role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ActorProcessRole">http://w3id.org/CEON/ontology/actor/ActorProcessRole</seealso>
    let ActorProcessRole = Prefixed_Name(ceon_actor, "ActorProcessRole") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/manufacturer">http://w3id.org/CEON/ontology/actor/manufacturer</seealso>
    let manufacturer = Prefixed_Name(ceon_actor, "manufacturer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:RecyclingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the recycler of a certain resource.</para>
    /// labels<para>Recycling resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/RecyclingResource">http://w3id.org/CEON/ontology/actor/RecyclingResource</seealso>
    let RecyclingResource =
        Prefixed_Name(ceon_actor, "RecyclingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:OwningResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the owner of a certain resource.</para>
    /// labels<para>Owning resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/OwningResource">http://w3id.org/CEON/ontology/actor/OwningResource</seealso>
    let OwningResource = Prefixed_Name(ceon_actor, "OwningResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/Person">http://w3id.org/CEON/ontology/actor/Person</seealso>
    let Person = Prefixed_Name(ceon_actor, "Person") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:0.4/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/0.4/">http://w3id.org/CEON/ontology/actor/0.4/</seealso>
    let ``_0.4/`` = Prefixed_Name(ceon_actor, "0.4/") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ConsumingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the consumer of a certain resource.</para>
    /// labels<para>Consuming resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ConsumingResource">http://w3id.org/CEON/ontology/actor/ConsumingResource</seealso>
    let ConsumingResource =
        Prefixed_Name(ceon_actor, "ConsumingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/owner">http://w3id.org/CEON/ontology/actor/owner</seealso>
    let owner = Prefixed_Name(ceon_actor, "owner") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ProcessParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Participation of a certain actor in a certain process, with a certain role. For instance, a certain department of a recycling company having the role of quality controllant, or material sorter, in a certain recycling process. The participation may also be given a time, e.g. a start and end time.</para>
    /// labels<para>Process Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ProcessParticipation">http://w3id.org/CEON/ontology/actor/ProcessParticipation</seealso>
    let ProcessParticipation =
        Prefixed_Name(ceon_actor, "ProcessParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:UsingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the user of a certain resource.</para>
    /// labels<para>Using resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/UsingResource">http://w3id.org/CEON/ontology/actor/UsingResource</seealso>
    let UsingResource = Prefixed_Name(ceon_actor, "UsingResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:dismantler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/dismantler">http://w3id.org/CEON/ontology/actor/dismantler</seealso>
    let dismantler = Prefixed_Name(ceon_actor, "dismantler") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/issuer">http://w3id.org/CEON/ontology/actor/issuer</seealso>
    let issuer = Prefixed_Name(ceon_actor, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:capabilityExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The extent of this capability, e.g. stating whether there are limist to the capability, such as a maximum amount or size of something.</para>
    /// labels<para>capability extent</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/capabilityExtent">http://w3id.org/CEON/ontology/actor/capabilityExtent</seealso>
    let capabilityExtent = Prefixed_Name(ceon_actor, "capabilityExtent") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:IssuingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the issuer of a certain resource.</para>
    /// labels<para>Issuing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/IssuingResource">http://w3id.org/CEON/ontology/actor/IssuingResource</seealso>
    let IssuingResource = Prefixed_Name(ceon_actor, "IssuingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:hasOrganisationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Represent that an organisation has some locations.</para>
    /// labels<para>has organisation location</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/hasOrganisationLocation">http://w3id.org/CEON/ontology/actor/hasOrganisationLocation</seealso>
    let hasOrganisationLocation =
        Prefixed_Name(ceon_actor, "hasOrganisationLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ActorCollaborationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The roles of an actor involved in a collaboration.</para>
    /// labels<para>Actor collaboration role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ActorCollaborationRole">http://w3id.org/CEON/ontology/actor/ActorCollaborationRole</seealso>
    let ActorCollaborationRole =
        Prefixed_Name(ceon_actor, "ActorCollaborationRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:BuyingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the buyer of a certain resource.</para>
    /// labels<para>Buying resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/BuyingResource">http://w3id.org/CEON/ontology/actor/BuyingResource</seealso>
    let BuyingResource = Prefixed_Name(ceon_actor, "BuyingResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:buyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/buyer">http://w3id.org/CEON/ontology/actor/buyer</seealso>
    let buyer = Prefixed_Name(ceon_actor, "buyer") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:CVNParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A participation-relation, that represents the participation of an actor in a CVN with a certain role. For instance, a specific company playing the role of recycler in a certain flow of a CVN. The participation may also be related to a certain time (or time interval).</para>
    /// labels<para>Circular Value Network Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/CVNParticipation">http://w3id.org/CEON/ontology/actor/CVNParticipation</seealso>
    let CVNParticipation = Prefixed_Name(ceon_actor, "CVNParticipation") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/consumer">http://w3id.org/CEON/ontology/actor/consumer</seealso>
    let consumer = Prefixed_Name(ceon_actor, "consumer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:DismantlingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the dismantler of a certain resource.</para>
    /// labels<para>Dismantling resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/DismantlingResource">http://w3id.org/CEON/ontology/actor/DismantlingResource</seealso>
    let DismantlingResource =
        Prefixed_Name(ceon_actor, "DismantlingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ProducingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the producer of a certain resource.</para>
    /// labels<para>Producing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ProducingResource">http://w3id.org/CEON/ontology/actor/ProducingResource</seealso>
    let ProducingResource =
        Prefixed_Name(ceon_actor, "ProducingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/producer">http://w3id.org/CEON/ontology/actor/producer</seealso>
    let producer = Prefixed_Name(ceon_actor, "producer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ProvidingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the provider of a certain resource.</para>
    /// labels<para>Providing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ProvidingResource">http://w3id.org/CEON/ontology/actor/ProvidingResource</seealso>
    let ProvidingResource =
        Prefixed_Name(ceon_actor, "ProvidingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/provider">http://w3id.org/CEON/ontology/actor/provider</seealso>
    let provider = Prefixed_Name(ceon_actor, "provider") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:recycler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/recycler">http://w3id.org/CEON/ontology/actor/recycler</seealso>
    let recycler = Prefixed_Name(ceon_actor, "recycler") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:RepairingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the repairer of a certain resource.</para>
    /// labels<para>Repairing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/RepairingResource">http://w3id.org/CEON/ontology/actor/RepairingResource</seealso>
    let RepairingResource =
        Prefixed_Name(ceon_actor, "RepairingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:repairer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/repairer">http://w3id.org/CEON/ontology/actor/repairer</seealso>
    let repairer = Prefixed_Name(ceon_actor, "repairer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:ResellingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the reseller of a certain resource.</para>
    /// labels<para>Reselling resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ResellingResource">http://w3id.org/CEON/ontology/actor/ResellingResource</seealso>
    let ResellingResource =
        Prefixed_Name(ceon_actor, "ResellingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:SellingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the seller of a certain resource.</para>
    /// labels<para>Selling resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/SellingResource">http://w3id.org/CEON/ontology/actor/SellingResource</seealso>
    let SellingResource = Prefixed_Name(ceon_actor, "SellingResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:seller</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/seller">http://w3id.org/CEON/ontology/actor/seller</seealso>
    let seller = Prefixed_Name(ceon_actor, "seller") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:SupplyingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the supplier of a certain resource.</para>
    /// labels<para>Supplying resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/SupplyingResource">http://w3id.org/CEON/ontology/actor/SupplyingResource</seealso>
    let SupplyingResource =
        Prefixed_Name(ceon_actor, "SupplyingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:TakingBackResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>The relation where the role of the actor is the collector of a certain resource.</para><para>Taking back resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/TakingBackResource">http://w3id.org/CEON/ontology/actor/TakingBackResource</seealso>
    let TakingBackResource =
        Prefixed_Name(ceon_actor, "TakingBackResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/collector">http://w3id.org/CEON/ontology/actor/collector</seealso>
    let collector = Prefixed_Name(ceon_actor, "collector") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:UpdatingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the updater of a certain resource.</para>
    /// labels<para>Updating resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/UpdatingResource">http://w3id.org/CEON/ontology/actor/UpdatingResource</seealso>
    let UpdatingResource = Prefixed_Name(ceon_actor, "UpdatingResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:updater</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/updater">http://w3id.org/CEON/ontology/actor/updater</seealso>
    let updater = Prefixed_Name(ceon_actor, "updater") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:user</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    ///   <para>ceon:ontology/actor/ActorCVNRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/user">http://w3id.org/CEON/ontology/actor/user</seealso>
    let user = Prefixed_Name(ceon_actor, "user") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:ViewingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation where the role of the actor is the viewer of a certain resource.</para>
    /// labels<para>Viewing resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/ViewingResource">http://w3id.org/CEON/ontology/actor/ViewingResource</seealso>
    let ViewingResource = Prefixed_Name(ceon_actor, "ViewingResource") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actor:viewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/actor/ActorResourceRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/viewer">http://w3id.org/CEON/ontology/actor/viewer</seealso>
    let viewer = Prefixed_Name(ceon_actor, "viewer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actor:neededResourceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In order for an actor to have a capability, it needs to have certain resources, e.g. materials, infrastrucutre, know-how, information etc.</para>
    /// labels<para>needed resource relations</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actor/neededResourceRelation">http://w3id.org/CEON/ontology/actor/neededResourceRelation</seealso>
    let neededResourceRelation =
        Prefixed_Name(ceon_actor, "neededResourceRelation") |> PrefixedName

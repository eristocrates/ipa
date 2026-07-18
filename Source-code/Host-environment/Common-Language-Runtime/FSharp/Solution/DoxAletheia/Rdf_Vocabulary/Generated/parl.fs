namespace http.reference.data.gov.uk.def.parliament.slash

open DoxAletheia.Rdf_Vocabulary

module parl =
    let _namespace_name = "http://reference.data.gov.uk/def/parliament/"
    /// <summary>
    /// Represents the leader of the political party
    /// <see href="http://reference.data.gov.uk/def/parliament/Leader"></see></summary>
    let Leader = Namespaced_IRI.parse _namespace_name "Leader" |> NamespacedName
    /// <summary>
    /// Defines a parliament, the law-making assembly of a nation.  Examples are Westminster, The Welsh Assembly, The Scottish Parliament and Northern Ireland Assembly.
    /// <see href="http://reference.data.gov.uk/def/parliament/Parliament"></see></summary>
    let Parliament = Namespaced_IRI.parse _namespace_name "Parliament" |> NamespacedName
    /// <summary>
    /// A seat in a Parliament
    /// <see href="http://reference.data.gov.uk/def/parliament/Seat"></see></summary>
    let Seat = Namespaced_IRI.parse _namespace_name "Seat" |> NamespacedName
    /// <summary>
    /// Defines the chambers with instances like The House of Commons and The House of Lords.
    /// <see href="http://reference.data.gov.uk/def/parliament/Chamber"></see></summary>
    let Chamber = Namespaced_IRI.parse _namespace_name "Chamber" |> NamespacedName

    /// <summary>
    /// Defines an administration to which independent law-making powers have been delegated.  Example instances are The Scottish Parliament and The Welsh Assembly
    /// <see href="http://reference.data.gov.uk/def/parliament/DevolvedParliament"></see></summary>
    let DevolvedParliament =
        Namespaced_IRI.parse _namespace_name "DevolvedParliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/parliament/Post"></see>
    /// </summary>
    let Post = Namespaced_IRI.parse _namespace_name "Post" |> NamespacedName

    /// <summary>
    /// A Political party such as The Conservative Party or The Labour Party.
    /// <see href="http://reference.data.gov.uk/def/parliament/PoliticalParty"></see></summary>
    let PoliticalParty =
        Namespaced_IRI.parse _namespace_name "PoliticalParty" |> NamespacedName

    /// <summary>
    /// A property linking a Devolved Assembly to the Parliament from which it was devolved.
    /// <see href="http://reference.data.gov.uk/def/parliament/devolvedFrom"></see></summary>
    let devolvedFrom =
        Namespaced_IRI.parse _namespace_name "devolvedFrom" |> NamespacedName

    /// <summary>
    /// Links a Parliament to a Devolved Assembly to which has devolved powers.
    /// <see href="http://reference.data.gov.uk/def/parliament/devolvesTo"></see></summary>
    let devolvesTo = Namespaced_IRI.parse _namespace_name "devolvesTo" |> NamespacedName
    /// <summary>
    /// A member of this parliament.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// The parliament this person or post is a member of.
    /// <see href="http://reference.data.gov.uk/def/parliament/memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName

    /// <summary>
    /// Indicates the Leader of this political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasPartyLeader"></see></summary>
    let hasPartyLeader =
        Namespaced_IRI.parse _namespace_name "hasPartyLeader" |> NamespacedName

    /// <summary>
    /// Indicates that a Leader is the leader of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/partyLeaderOf"></see></summary>
    let partyLeaderOf =
        Namespaced_IRI.parse _namespace_name "partyLeaderOf" |> NamespacedName

    /// <summary>
    /// Indicates that a political party has a person as member.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasPartyMember"></see></summary>
    let hasPartyMember =
        Namespaced_IRI.parse _namespace_name "hasPartyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/parliament/partyMemberOf"></see>
    /// </summary>
    let partyMemberOf =
        Namespaced_IRI.parse _namespace_name "partyMemberOf" |> NamespacedName

    /// <summary>
    /// This property indicates that a person holds the leadership of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/holdsLeadership"></see></summary>
    let holdsLeadership =
        Namespaced_IRI.parse _namespace_name "holdsLeadership" |> NamespacedName

    /// <summary>
    /// This property indicates that a person holds the leadership of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/leadershipHeldBy"></see></summary>
    let leadershipHeldBy =
        Namespaced_IRI.parse _namespace_name "leadershipHeldBy" |> NamespacedName

    /// <summary>
    /// Indicates the seat in parliament that this person holds.
    /// <see href="http://reference.data.gov.uk/def/parliament/holdsSeat"></see></summary>
    let holdsSeat = Namespaced_IRI.parse _namespace_name "holdsSeat" |> NamespacedName
    /// <summary>
    /// The constituency that the MP holding this seat in parliament represents.
    /// <see href="http://reference.data.gov.uk/def/parliament/represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    /// Indicates the person holding this seat in parliament.
    /// <see href="http://reference.data.gov.uk/def/parliament/seatHeldBy"></see></summary>
    let seatHeldBy = Namespaced_IRI.parse _namespace_name "seatHeldBy" |> NamespacedName

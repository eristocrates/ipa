namespace http.reference.data.gov.uk.def.parliament.slash

open DoxAletheia

module parl =
    let _namespace_name = "http://reference.data.gov.uk/def/parliament/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents the leader of the political party
    /// <see href="http://reference.data.gov.uk/def/parliament/Leader"></see></summary>
    let Leader = _prefix "Leader"
    /// <summary>
    /// Defines a parliament, the law-making assembly of a nation.  Examples are Westminster, The Welsh Assembly, The Scottish Parliament and Northern Ireland Assembly.
    /// <see href="http://reference.data.gov.uk/def/parliament/Parliament"></see></summary>
    let Parliament = _prefix "Parliament"
    /// <summary>
    /// A seat in a Parliament
    /// <see href="http://reference.data.gov.uk/def/parliament/Seat"></see></summary>
    let Seat = _prefix "Seat"
    /// <summary>
    /// Defines the chambers with instances like The House of Commons and The House of Lords.
    /// <see href="http://reference.data.gov.uk/def/parliament/Chamber"></see></summary>
    let Chamber = _prefix "Chamber"
    /// <summary>
    /// Defines an administration to which independent law-making powers have been delegated.  Example instances are The Scottish Parliament and The Welsh Assembly
    /// <see href="http://reference.data.gov.uk/def/parliament/DevolvedParliament"></see></summary>
    let DevolvedParliament = _prefix "DevolvedParliament"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/parliament/Post"></see>
    /// </summary>
    let Post = _prefix "Post"
    /// <summary>
    /// A Political party such as The Conservative Party or The Labour Party.
    /// <see href="http://reference.data.gov.uk/def/parliament/PoliticalParty"></see></summary>
    let PoliticalParty = _prefix "PoliticalParty"
    /// <summary>
    /// A property linking a Devolved Assembly to the Parliament from which it was devolved.
    /// <see href="http://reference.data.gov.uk/def/parliament/devolvedFrom"></see></summary>
    let devolvedFrom = _prefix "devolvedFrom"
    /// <summary>
    /// Links a Parliament to a Devolved Assembly to which has devolved powers.
    /// <see href="http://reference.data.gov.uk/def/parliament/devolvesTo"></see></summary>
    let devolvesTo = _prefix "devolvesTo"
    /// <summary>
    /// A member of this parliament.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// The parliament this person or post is a member of.
    /// <see href="http://reference.data.gov.uk/def/parliament/memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Indicates the Leader of this political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasPartyLeader"></see></summary>
    let hasPartyLeader = _prefix "hasPartyLeader"
    /// <summary>
    /// Indicates that a Leader is the leader of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/partyLeaderOf"></see></summary>
    let partyLeaderOf = _prefix "partyLeaderOf"
    /// <summary>
    /// Indicates that a political party has a person as member.
    /// <see href="http://reference.data.gov.uk/def/parliament/hasPartyMember"></see></summary>
    let hasPartyMember = _prefix "hasPartyMember"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/parliament/partyMemberOf"></see>
    /// </summary>
    let partyMemberOf = _prefix "partyMemberOf"
    /// <summary>
    /// This property indicates that a person holds the leadership of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/holdsLeadership"></see></summary>
    let holdsLeadership = _prefix "holdsLeadership"
    /// <summary>
    /// This property indicates that a person holds the leadership of a political party.
    /// <see href="http://reference.data.gov.uk/def/parliament/leadershipHeldBy"></see></summary>
    let leadershipHeldBy = _prefix "leadershipHeldBy"
    /// <summary>
    /// Indicates the seat in parliament that this person holds.
    /// <see href="http://reference.data.gov.uk/def/parliament/holdsSeat"></see></summary>
    let holdsSeat = _prefix "holdsSeat"
    /// <summary>
    /// The constituency that the MP holding this seat in parliament represents.
    /// <see href="http://reference.data.gov.uk/def/parliament/represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// Indicates the person holding this seat in parliament.
    /// <see href="http://reference.data.gov.uk/def/parliament/seatHeldBy"></see></summary>
    let seatHeldBy = _prefix "seatHeldBy"

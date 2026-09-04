#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module parl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/parliament/" "parl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Chamber</para>
    ///   <para>rdfs:comment : Defines the chambers with instances like The House of Commons and The House of Lords.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/Chamber">parl:Chamber</a>
    /// </summary>
    let Chamber = _prefixId.prefix "Chamber"
    /// <summary>
    ///   <para>rdfs:label : Devolved administration</para>
    ///   <para>rdfs:comment : Defines an administration to which independent law-making powers have been delegated.  Example instances are The Scottish Parliament and The Welsh Assembly</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/DevolvedParliament">parl:DevolvedParliament</a>
    /// </summary>
    let DevolvedParliament = _prefixId.prefix "DevolvedParliament"
    /// <summary>
    ///   <para>rdfs:label : Party Leader</para>
    ///   <para>rdfs:comment : Represents the leader of the political party</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/Leader">parl:Leader</a>
    /// </summary>
    let Leader = _prefixId.prefix "Leader"
    /// <summary>
    ///   <para>rdfs:label : Parliament</para>
    ///   <para>rdfs:comment : Defines a parliament, the law-making assembly of a nation.  Examples are Westminster, The Welsh Assembly, The Scottish Parliament and Northern Ireland Assembly.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/Parliament">parl:Parliament</a>
    /// </summary>
    let Parliament = _prefixId.prefix "Parliament"
    /// <summary>
    ///   <para>rdfs:label : Political party^^xsd:string</para>
    ///   <para>rdfs:comment : A Political party such as The Conservative Party or The Labour Party.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/PoliticalParty">parl:PoliticalParty</a>
    /// </summary>
    let PoliticalParty = _prefixId.prefix "PoliticalParty"
    /// <summary>
    ///   <para>rdfs:label : Post</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/Post">parl:Post</a>
    /// </summary>
    let Post = _prefixId.prefix "Post"
    /// <summary>
    ///   <para>rdfs:label : Seat</para>
    ///   <para>rdfs:comment : A seat in a Parliament^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/Seat">parl:Seat</a>
    /// </summary>
    let Seat = _prefixId.prefix "Seat"
    /// <summary>
    ///   <para>rdfs:label : devolved from</para>
    ///   <para>rdfs:comment : A property linking a Devolved Assembly to the Parliament from which it was devolved.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/devolvedFrom">parl:devolvedFrom</a>
    /// </summary>
    let devolvedFrom = _prefixId.prefix "devolvedFrom"
    /// <summary>
    ///   <para>rdfs:comment : Links a Parliament to a Devolved Assembly to which has devolved powers.</para>
    ///   <para>rdfs:label : devolves to</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/devolvesTo">parl:devolvesTo</a>
    /// </summary>
    let devolvesTo = _prefixId.prefix "devolvesTo"
    /// <summary>
    ///   <para>rdfs:label : Member</para>
    ///   <para>rdfs:comment : A member of this parliament.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/hasMember">parl:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : Leader</para>
    ///   <para>rdfs:comment : Indicates the Leader of this political party.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/hasPartyLeader">parl:hasPartyLeader</a>
    /// </summary>
    let hasPartyLeader = _prefixId.prefix "hasPartyLeader"
    /// <summary>
    ///   <para>rdfs:label : Member</para>
    ///   <para>rdfs:comment : Indicates that a political party has a person as member.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/hasPartyMember">parl:hasPartyMember</a>
    /// </summary>
    let hasPartyMember = _prefixId.prefix "hasPartyMember"
    /// <summary>
    ///   <para>rdfs:label : Holds Leadership</para>
    ///   <para>rdfs:comment : This property indicates that a person holds the leadership of a political party.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/holdsLeadership">parl:holdsLeadership</a>
    /// </summary>
    let holdsLeadership = _prefixId.prefix "holdsLeadership"
    /// <summary>
    ///   <para>rdfs:label : Seat</para>
    ///   <para>rdfs:comment : Indicates the seat in parliament that this person holds.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/holdsSeat">parl:holdsSeat</a>
    /// </summary>
    let holdsSeat = _prefixId.prefix "holdsSeat"
    /// <summary>
    ///   <para>rdfs:label : Holds Leadership</para>
    ///   <para>rdfs:comment : This property indicates that a person holds the leadership of a political party.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/leadershipHeldBy">parl:leadershipHeldBy</a>
    /// </summary>
    let leadershipHeldBy = _prefixId.prefix "leadershipHeldBy"
    /// <summary>
    ///   <para>rdfs:label : Member of</para>
    ///   <para>rdfs:comment : The parliament this person or post is a member of.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/memberOf">parl:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:label : Leader of</para>
    ///   <para>rdfs:comment : Indicates that a Leader is the leader of a political party.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/partyLeaderOf">parl:partyLeaderOf</a>
    /// </summary>
    let partyLeaderOf = _prefixId.prefix "partyLeaderOf"
    /// <summary>
    ///   <para>rdfs:label : Member of</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/partyMemberOf">parl:partyMemberOf</a>
    /// </summary>
    let partyMemberOf = _prefixId.prefix "partyMemberOf"
    /// <summary>
    ///   <para>skos:editorialNote : No range set on this though for the House of Commons it will be a &lt;http://data.ordnancesurvey.co.uk/ontology/admingeo/WestminsterConstituency&gt;.</para>
    ///   <para>rdfs:label : Represents</para>
    ///   <para>rdfs:comment : The constituency that the MP holding this seat in parliament represents.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/represents">parl:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:label : Held By</para>
    ///   <para>rdfs:comment : Indicates the person holding this seat in parliament.</para>
    ///   <a href="http://reference.data.gov.uk/def/parliament/seatHeldBy">parl:seatHeldBy</a>
    /// </summary>
    let seatHeldBy = _prefixId.prefix "seatHeldBy"

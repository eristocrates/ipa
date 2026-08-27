namespace http.reference.data.gov.uk.def.parliament.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module parl =
    let _namespace_iri = Namespace_Iri parl |> NamespaceIRI
    /// <summary>
    ///   <para>parl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/">http://reference.data.gov.uk/def/parliament/</seealso>
    let _prefix_iri = Prefixed_Name(parl, "") |> PrefixedName
    /// <summary>
    ///   <para>parl:Chamber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines the chambers with instances like The House of Commons and The House of Lords."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chamber"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Chamber">http://reference.data.gov.uk/def/parliament/Chamber</seealso>
    let Chamber = Prefixed_Name(parl, "Chamber") |> PrefixedName
    /// <summary>
    ///   <para>parl:DevolvedParliament</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines an administration to which independent law-making powers have been delegated.  Example instances are The Scottish Parliament and The Welsh Assembly"</para>
    /// labels<para>"Devolved administration"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/DevolvedParliament">http://reference.data.gov.uk/def/parliament/DevolvedParliament</seealso>
    let DevolvedParliament = Prefixed_Name(parl, "DevolvedParliament") |> PrefixedName
    /// <summary>
    ///   <para>parl:Leader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents the leader of the political party"</para>
    /// labels<para>"Party Leader"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Leader">http://reference.data.gov.uk/def/parliament/Leader</seealso>
    let Leader = Prefixed_Name(parl, "Leader") |> PrefixedName
    /// <summary>
    ///   <para>parl:Legislature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Legislature">http://reference.data.gov.uk/def/parliament/Legislature</seealso>
    let Legislature = Prefixed_Name(parl, "Legislature") |> PrefixedName
    /// <summary>
    ///   <para>parl:Parliament</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines a parliament, the law-making assembly of a nation.  Examples are Westminster, The Welsh Assembly, The Scottish Parliament and Northern Ireland Assembly."</para>
    /// labels<para>"Parliament"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Parliament">http://reference.data.gov.uk/def/parliament/Parliament</seealso>
    let Parliament = Prefixed_Name(parl, "Parliament") |> PrefixedName
    /// <summary>
    ///   <para>parl:PoliticalParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Political party such as The Conservative Party or The Labour Party."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Political party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/PoliticalParty">http://reference.data.gov.uk/def/parliament/PoliticalParty</seealso>
    let PoliticalParty = Prefixed_Name(parl, "PoliticalParty") |> PrefixedName
    /// <summary>
    ///   <para>parl:Post</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Post"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Post">http://reference.data.gov.uk/def/parliament/Post</seealso>
    let Post = Prefixed_Name(parl, "Post") |> PrefixedName
    /// <summary>
    ///   <para>parl:Seat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A seat in a Parliament"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seat"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/Seat">http://reference.data.gov.uk/def/parliament/Seat</seealso>
    let Seat = Prefixed_Name(parl, "Seat") |> PrefixedName
    /// <summary>
    ///   <para>parl:devolvedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a Devolved Assembly to the Parliament from which it was devolved."</para>
    /// labels<para>"devolved from"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/devolvedFrom">http://reference.data.gov.uk/def/parliament/devolvedFrom</seealso>
    let devolvedFrom = Prefixed_Name(parl, "devolvedFrom") |> PrefixedName
    /// <summary>
    ///   <para>parl:devolvesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Parliament to a Devolved Assembly to which has devolved powers."</para>
    /// labels<para>"devolves to"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/devolvesTo">http://reference.data.gov.uk/def/parliament/devolvesTo</seealso>
    let devolvesTo = Prefixed_Name(parl, "devolvesTo") |> PrefixedName
    /// <summary>
    ///   <para>parl:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A member of this parliament."</para>
    /// labels<para>"Member"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/hasMember">http://reference.data.gov.uk/def/parliament/hasMember</seealso>
    let hasMember = Prefixed_Name(parl, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>parl:hasPartyLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the Leader of this political party."</para>
    /// labels<para>"Leader"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/hasPartyLeader">http://reference.data.gov.uk/def/parliament/hasPartyLeader</seealso>
    let hasPartyLeader = Prefixed_Name(parl, "hasPartyLeader") |> PrefixedName
    /// <summary>
    ///   <para>parl:hasPartyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a political party has a person as member."</para>
    /// labels<para>"Member"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/hasPartyMember">http://reference.data.gov.uk/def/parliament/hasPartyMember</seealso>
    let hasPartyMember = Prefixed_Name(parl, "hasPartyMember") |> PrefixedName
    /// <summary>
    ///   <para>parl:holdsLeadership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that a person holds the leadership of a political party."</para>
    /// labels<para>"Holds Leadership"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/holdsLeadership">http://reference.data.gov.uk/def/parliament/holdsLeadership</seealso>
    let holdsLeadership = Prefixed_Name(parl, "holdsLeadership") |> PrefixedName
    /// <summary>
    ///   <para>parl:holdsSeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the seat in parliament that this person holds."</para>
    /// labels<para>"Seat"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/holdsSeat">http://reference.data.gov.uk/def/parliament/holdsSeat</seealso>
    let holdsSeat = Prefixed_Name(parl, "holdsSeat") |> PrefixedName
    /// <summary>
    ///   <para>parl:leadershipHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that a person holds the leadership of a political party."</para>
    /// labels<para>"Holds Leadership"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/leadershipHeldBy">http://reference.data.gov.uk/def/parliament/leadershipHeldBy</seealso>
    let leadershipHeldBy = Prefixed_Name(parl, "leadershipHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>parl:legislatureOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/legislatureOf">http://reference.data.gov.uk/def/parliament/legislatureOf</seealso>
    let legislatureOf = Prefixed_Name(parl, "legislatureOf") |> PrefixedName
    /// <summary>
    ///   <para>parl:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The parliament this person or post is a member of."</para>
    /// labels<para>"Member of"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/memberOf">http://reference.data.gov.uk/def/parliament/memberOf</seealso>
    let memberOf = Prefixed_Name(parl, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>parl:partyLeaderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that a Leader is the leader of a political party."</para>
    /// labels<para>"Leader of"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/partyLeaderOf">http://reference.data.gov.uk/def/parliament/partyLeaderOf</seealso>
    let partyLeaderOf = Prefixed_Name(parl, "partyLeaderOf") |> PrefixedName
    /// <summary>
    ///   <para>parl:partyMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Member of"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/partyMemberOf">http://reference.data.gov.uk/def/parliament/partyMemberOf</seealso>
    let partyMemberOf = Prefixed_Name(parl, "partyMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>parl:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The constituency that the MP holding this seat in parliament represents."</para>
    /// labels<para>"Represents"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/represents">http://reference.data.gov.uk/def/parliament/represents</seealso>
    let represents = Prefixed_Name(parl, "represents") |> PrefixedName
    /// <summary>
    ///   <para>parl:seatHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the person holding this seat in parliament."</para>
    /// labels<para>"Held By"</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/parliament/seatHeldBy">http://reference.data.gov.uk/def/parliament/seatHeldBy</seealso>
    let seatHeldBy = Prefixed_Name(parl, "seatHeldBy") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rel =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/relationship/" "rel"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : A particular type of connection existing between people related to or having dealings with each other.</para>
    ///   <para>rdfs:label : Relationship</para>
    ///   <a href="http://purl.org/vocab/relationship/Relationship">rel:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    let acquaintanceOf = _prefixId.prefix "acquaintanceOf"
    /// <summary>
    ///   <para>skos:definition : A person towards whom this person has mixed feelings or emotions.</para>
    ///   <para>rdfs:label : Ambivalent Of</para>
    ///   <a href="http://purl.org/vocab/relationship/ambivalentOf">rel:ambivalentOf</a>
    /// </summary>
    let ambivalentOf = _prefixId.prefix "ambivalentOf"
    let ancestorOf = _prefixId.prefix "ancestorOf"
    /// <summary>
    ///   <para>skos:definition : A person who opposes and contends against this person.</para>
    ///   <para>rdfs:label : Antagonist Of</para>
    ///   <a href="http://purl.org/vocab/relationship/antagonistOf">rel:antagonistOf</a>
    /// </summary>
    let antagonistOf = _prefixId.prefix "antagonistOf"
    /// <summary>
    ///   <para>skos:definition : A person to whom this person serves as a trusted counselor or teacher.</para>
    ///   <para>rdfs:label : Apprentice To</para>
    ///   <a href="http://purl.org/vocab/relationship/apprenticeTo">rel:apprenticeTo</a>
    /// </summary>
    let apprenticeTo = _prefixId.prefix "apprenticeTo"
    /// <summary>
    ///   <para>skos:definition : A person who was given birth to or nurtured and raised by this person.</para>
    ///   <para>rdfs:label : Child Of</para>
    ///   <a href="http://purl.org/vocab/relationship/childOf">rel:childOf</a>
    /// </summary>
    let childOf = _prefixId.prefix "childOf"
    let closeFriendOf = _prefixId.prefix "closeFriendOf"
    let collaboratesWith = _prefixId.prefix "collaboratesWith"
    let colleagueOf = _prefixId.prefix "colleagueOf"
    let descendantOf = _prefixId.prefix "descendantOf"
    /// <summary>
    ///   <para>rdfs:label : Employed By</para>
    ///   <para>skos:definition : A person for whom this person's services have been engaged.</para>
    ///   <a href="http://purl.org/vocab/relationship/employedBy">rel:employedBy</a>
    /// </summary>
    let employedBy = _prefixId.prefix "employedBy"
    /// <summary>
    ///   <para>rdfs:label : Employer Of</para>
    ///   <para>skos:definition : A person who engages the services of this person.</para>
    ///   <a href="http://purl.org/vocab/relationship/employerOf">rel:employerOf</a>
    /// </summary>
    let employerOf = _prefixId.prefix "employerOf"
    /// <summary>
    ///   <para>rdfs:label : Enemy Of</para>
    ///   <para>skos:definition : A person towards whom this person feels hatred, intends injury to, or opposes the interests of.</para>
    ///   <a href="http://purl.org/vocab/relationship/enemyOf">rel:enemyOf</a>
    /// </summary>
    let enemyOf = _prefixId.prefix "enemyOf"
    let engagedTo = _prefixId.prefix "engagedTo"
    let friendOf = _prefixId.prefix "friendOf"
    /// <summary>
    ///   <para>rdfs:label : Grandchild Of^^xsd:stringrdfs:label : Grandchild Of</para>
    ///   <para>skos:definition : A person who is a child of any of this person's children.</para>
    ///   <a href="http://purl.org/vocab/relationship/grandchildOf">rel:grandchildOf</a>
    /// </summary>
    let grandchildOf = _prefixId.prefix "grandchildOf"
    /// <summary>
    ///   <para>rdfs:label : Grandparent Of</para>
    ///   <para>skos:definition : A person who is the parent of any of this person's parents.</para>
    ///   <a href="http://purl.org/vocab/relationship/grandparentOf">rel:grandparentOf</a>
    /// </summary>
    let grandparentOf = _prefixId.prefix "grandparentOf"
    let hasMet = _prefixId.prefix "hasMet"
    /// <summary>
    ///   <para>skos:definition : a person who has influenced this person.</para>
    ///   <para>rdfs:label : Influenced By</para>
    ///   <a href="http://purl.org/vocab/relationship/influencedBy">rel:influencedBy</a>
    /// </summary>
    let influencedBy = _prefixId.prefix "influencedBy"
    /// <summary>
    ///   <para>skos:definition : A person known by this person primarily for a particular action, position or field of endeavour.</para>
    ///   <para>rdfs:label : Knows By Reputation</para>
    ///   <a href="http://purl.org/vocab/relationship/knowsByReputation">rel:knowsByReputation</a>
    /// </summary>
    let knowsByReputation = _prefixId.prefix "knowsByReputation"
    /// <summary>
    ///   <para>skos:definition : A person whom this person has slight or superficial knowledge of.</para>
    ///   <para>rdfs:label : Knows In Passing</para>
    ///   <a href="http://purl.org/vocab/relationship/knowsInPassing">rel:knowsInPassing</a>
    /// </summary>
    let knowsInPassing = _prefixId.prefix "knowsInPassing"
    /// <summary>
    ///   <para>skos:definition : A person who has come to be known to this person through their actions or position.</para>
    ///   <para>rdfs:label : Knows Of</para>
    ///   <a href="http://purl.org/vocab/relationship/knowsOf">rel:knowsOf</a>
    /// </summary>
    let knowsOf = _prefixId.prefix "knowsOf"
    let lifePartnerOf = _prefixId.prefix "lifePartnerOf"
    let livesWith = _prefixId.prefix "livesWith"
    let lostContactWith = _prefixId.prefix "lostContactWith"
    /// <summary>
    ///   <para>skos:definition : A person who serves as a trusted counselor or teacher to this person.</para>
    ///   <para>rdfs:label : Mentor Of</para>
    ///   <a href="http://purl.org/vocab/relationship/mentorOf">rel:mentorOf</a>
    /// </summary>
    let mentorOf = _prefixId.prefix "mentorOf"
    let neighborOf = _prefixId.prefix "neighborOf"
    /// <summary>
    ///   <para>skos:definition : A person who has given birth to or nurtured and raised this person.</para>
    ///   <para>rdfs:label : Parent Of</para>
    ///   <a href="http://purl.org/vocab/relationship/parentOf">rel:parentOf</a>
    /// </summary>
    let parentOf = _prefixId.prefix "parentOf"
    /// <summary>
    ///   <para>rdfs:label : Participant</para>
    ///   <a href="http://purl.org/vocab/relationship/participant">rel:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:label : Participant In</para>
    ///   <a href="http://purl.org/vocab/relationship/participantIn">rel:participantIn</a>
    /// </summary>
    let participantIn = _prefixId.prefix "participantIn"
    let rel_vocab_20090515 = _prefixId.prefix "rel-vocab-20090515"
    let siblingOf = _prefixId.prefix "siblingOf"
    let spouseOf = _prefixId.prefix "spouseOf"
    let worksWith = _prefixId.prefix "worksWith"
    /// <summary>
    ///   <para>skos:definition : A person whom this person would desire to know more closely.</para>
    ///   <para>rdfs:label : Would Like To Know</para>
    ///   <a href="http://purl.org/vocab/relationship/wouldLikeToKnow">rel:wouldLikeToKnow</a>
    /// </summary>
    let wouldLikeToKnow = _prefixId.prefix "wouldLikeToKnow"

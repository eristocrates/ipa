namespace Relationship.Namespace
module relationship =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/vocab/relationship/" (Some @"https://vocab.org/relationship/rel-vocab-20100607.rdf") (Some @"relationship") None
    let Relationship = {_prefixID with _localName = "Relationship"}
    let acquaintanceOf = {_prefixID with _localName = "acquaintanceOf"}
    let ambivalentOf = {_prefixID with _localName = "ambivalentOf"}
    let ancestorOf = {_prefixID with _localName = "ancestorOf"}
    let antagonistOf = {_prefixID with _localName = "antagonistOf"}
    let apprenticeTo = {_prefixID with _localName = "apprenticeTo"}
    let childOf = {_prefixID with _localName = "childOf"}
    let closeFriendOf = {_prefixID with _localName = "closeFriendOf"}
    let collaboratesWith = {_prefixID with _localName = "collaboratesWith"}
    let colleagueOf = {_prefixID with _localName = "colleagueOf"}
    let descendantOf = {_prefixID with _localName = "descendantOf"}
    let employedBy = {_prefixID with _localName = "employedBy"}
    let employerOf = {_prefixID with _localName = "employerOf"}
    let enemyOf = {_prefixID with _localName = "enemyOf"}
    let engagedTo = {_prefixID with _localName = "engagedTo"}
    let friendOf = {_prefixID with _localName = "friendOf"}
    let grandchildOf = {_prefixID with _localName = "grandchildOf"}
    let grandparentOf = {_prefixID with _localName = "grandparentOf"}
    let hasMet = {_prefixID with _localName = "hasMet"}
    let influencedBy = {_prefixID with _localName = "influencedBy"}
    let knowsByReputation = {_prefixID with _localName = "knowsByReputation"}
    let knowsInPassing = {_prefixID with _localName = "knowsInPassing"}
    let knowsOf = {_prefixID with _localName = "knowsOf"}
    let lifePartnerOf = {_prefixID with _localName = "lifePartnerOf"}
    let livesWith = {_prefixID with _localName = "livesWith"}
    let lostContactWith = {_prefixID with _localName = "lostContactWith"}
    let mentorOf = {_prefixID with _localName = "mentorOf"}
    let neighborOf = {_prefixID with _localName = "neighborOf"}
    let parentOf = {_prefixID with _localName = "parentOf"}
    let participant = {_prefixID with _localName = "participant"}
    let participantIn = {_prefixID with _localName = "participantIn"}
    let ``rel-vocab-20090515`` = {_prefixID with _localName = "rel-vocab-20090515"}
    let siblingOf = {_prefixID with _localName = "siblingOf"}
    let spouseOf = {_prefixID with _localName = "spouseOf"}
    let worksWith = {_prefixID with _localName = "worksWith"}
    let wouldLikeToKnow = {_prefixID with _localName = "wouldLikeToKnow"}
    module examples_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/vocab/relationship/examples/" (Some @"https://vocab.org/relationship/rel-vocab-20100607.rdf") (Some "relationship.examples") None 
        let ``1`` = {_prefixID with _localName = "1"}
        let ``2`` = {_prefixID with _localName = "2"}
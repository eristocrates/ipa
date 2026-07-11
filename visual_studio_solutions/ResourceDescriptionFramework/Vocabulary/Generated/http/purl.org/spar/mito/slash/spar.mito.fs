namespace Spar.mito.Namespace
module mito =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/mito/" (Some "http://purl.org/spar/mito.ttl") (Some "spar.mito") None
    let ``2024-05-09`` = {_prefixID with _localName = "2024-05-09"}
    let Mention = {_prefixID with _localName = "Mention"}
    let MentionType = {_prefixID with _localName = "MentionType"}
    let hasMentionType = {_prefixID with _localName = "hasMentionType"}
    let hasMentionedEntity = {_prefixID with _localName = "hasMentionedEntity"}
    let hasMentioningEntity = {_prefixID with _localName = "hasMentioningEntity"}
    let isMentionedBy = {_prefixID with _localName = "isMentionedBy"}
    let mentions = {_prefixID with _localName = "mentions"}
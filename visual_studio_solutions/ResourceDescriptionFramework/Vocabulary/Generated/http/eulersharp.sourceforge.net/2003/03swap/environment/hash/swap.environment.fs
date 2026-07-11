namespace Swap.environment.Namespace
module environment =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/environment#" (Some "http://eulersharp.sourceforge.net/2003/03swap/environment") (Some "swap.environment") None
    let CommunityEnvironment = {_prefixID with _localName = "CommunityEnvironment"}
    let Environment = {_prefixID with _localName = "Environment"}
    let Home = {_prefixID with _localName = "Home"}
    let HumanCommunityEnvironment = {_prefixID with _localName = "HumanCommunityEnvironment"}
    let environmentOf = {_prefixID with _localName = "environmentOf"}
    let hasEnvironment = {_prefixID with _localName = "hasEnvironment"}
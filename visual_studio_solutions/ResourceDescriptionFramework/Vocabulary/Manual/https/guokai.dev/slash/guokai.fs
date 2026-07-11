namespace Guokai.Namespace

module guokai =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "https://guokai.dev#"
            None
            (Some "guokai")
            None

    let method = { _prefixID with _localName = "method" }
    let value = { _prefixID with _localName = "value" }
    let Rule = { _prefixID with _localName = "Rule" }
    let TabGroupingRule = { _prefixID with _localName = "TabGroupingRule" }
    let enabled = { _prefixID with _localName = "enabled" }
    let groupName = { _prefixID with _localName = "groupName" }
    let ruleName = { _prefixID with _localName = "ruleName" }
    let Match = { _prefixID with _localName = "Match" }
    let target = { _prefixID with _localName = "target" }
    let MatchTarget = { _prefixID with _localName = "MatchTarget" }
    let UrlMatchTarget = { _prefixID with _localName = "UrlMatchTarget" }
    let hostnameMatch = { _prefixID with _localName = "hostnameMatch" }
    let href = { _prefixID with _localName = "href" }
    let TitleMatchTarget = { _prefixID with _localName = "TitleMatchTarget" }
    let ignoreCase = { _prefixID with _localName = "ignoreCase" }
    let TitleMatch = { _prefixID with _localName = "TitleMatch" }
    let MatchMethod = { _prefixID with _localName = "MatchMethod" }
    let includes = { _prefixID with _localName = "includes" }
    let startsWith = { _prefixID with _localName = "startsWith" }
    let endsWith = { _prefixID with _localName = "endsWith" }
    let equal = { _prefixID with _localName = "equal" }
    let regex = { _prefixID with _localName = "regex" }
    let titleMatches = { _prefixID with _localName = "titleMatches" }
    let urlMatches = { _prefixID with _localName = "urlMatches" }
    let MatchValue = { _prefixID with _localName = "MatchValue" }
    let Color = { _prefixID with _localName = "Color" }
    let groupColor = { _prefixID with _localName = "groupColor" }
    let blue = { _prefixID with _localName = "blue" }
    let cyan = { _prefixID with _localName = "cyan" }
    let green = { _prefixID with _localName = "green" }
    let grey = { _prefixID with _localName = "grey" }
    let orange = { _prefixID with _localName = "orange" }
    let pink = { _prefixID with _localName = "pink" }
    let purple = { _prefixID with _localName = "purple" }
    let red = { _prefixID with _localName = "red" }
    let yellow = { _prefixID with _localName = "yellow" }

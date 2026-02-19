module Pronouns.Namespace

module pronouns =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "https://en.pronouns.page/"
            None
            (Some "pronouns")
            None

    let she = { _prefixID with _localName = "she" }

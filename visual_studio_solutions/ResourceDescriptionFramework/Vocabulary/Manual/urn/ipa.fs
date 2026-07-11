namespace Ipa.Namespace

module ipa =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "urn:ipa/"
            None
            (Some "ipa")
            None

    let Organization = { _prefixID with _localName = "Organization" }

    let OpenHomeFoundation = { _prefixID with _localName = "OpenHomeFoundation" }

    let NabuCasa = { _prefixID with _localName = "NabuCasa" }

    let HomeAssistant = { _prefixID with _localName = "HomeAssistant" }

    let HomeAssistantOperatingSystem =
        { _prefixID with _localName = "HomeAssistantOperatingSystem" }

    let HomeAssistantSupervisor =
        { _prefixID with _localName = "HomeAssistantSupervisor" }

    let HomeAssistantCore = { _prefixID with _localName = "HomeAssistantCore" }

    let HomeAssistantProject = { _prefixID with _localName = "HomeAssistantProject" }

    let HomeAssistantCloud = { _prefixID with _localName = "HomeAssistantCloud" }

    let HomeAssistantPlatform = { _prefixID with _localName = "HomeAssistantPlatform" }

    let HomeAssistantPlatform_contains_Core =
        { _prefixID with _localName = "HomeAssistantPlatform_contains_Core" }

    let HomeAssistantPlatform_contains_Supervisor =
        { _prefixID with _localName = "HomeAssistantPlatform_contains_Supervisor" }

    let HomeAssistantPlatform_contains_OperatingSystem =
        { _prefixID with _localName = "HomeAssistantPlatform_contains_OperatingSystem" }

    let HomeAssistantSupervisor_dependsOn_OperatingSystem =
        { _prefixID with _localName = "HomeAssistantSupervisor_dependsOn_OperatingSystem" }

    let HomeAssistantCore_dependsOn_Supervisor =
        { _prefixID with _localName = "HomeAssistantCore_dependsOn_Supervisor" }

    let HomeAssistantGreen = { _prefixID with _localName = "HomeAssistantGreen" }

    let HomeAssistantGreenModel =
        { _prefixID with _localName = "HomeAssistantGreenModel" }

    let HomeAssistantGreenUnit =
        { _prefixID with _localName = "HomeAssistantGreenUnit" }

namespace Nepomuk.nco.v3.Namespace

module nco =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nco#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/32-nco.ontology")
            (Some "nepomuk.nco.v3")
            None

    let Namespace = { _prefixID with _localName = "Namespace" }
    let Role = { _prefixID with _localName = "Role" }
    let Affiliation = { _prefixID with _localName = "Affiliation" }
    let Contact = { _prefixID with _localName = "Contact" }
    let ContactGroup = { _prefixID with _localName = "ContactGroup" }
    let ContactList = { _prefixID with _localName = "ContactList" }
    let ContactMedium = { _prefixID with _localName = "ContactMedium" }
    let PersonContact = { _prefixID with _localName = "PersonContact" }
    let OrganizationContact = { _prefixID with _localName = "OrganizationContact" }
    let EmailAddress = { _prefixID with _localName = "EmailAddress" }
    let IMAddress = { _prefixID with _localName = "IMAddress" }
    let IMAccount = { _prefixID with _localName = "IMAccount" }
    let ``default-contact-me`` = { _prefixID with _localName = "default-contact-me" }
    let PhoneNumber = { _prefixID with _localName = "PhoneNumber" }
    let PostalAddress = { _prefixID with _localName = "PostalAddress" }
    let ModemNumber = { _prefixID with _localName = "ModemNumber" }
    let MessagingNumber = { _prefixID with _localName = "MessagingNumber" }
    let PagerNumber = { _prefixID with _localName = "PagerNumber" }
    let Gender = { _prefixID with _localName = "Gender" }
    let ``gender-male`` = { _prefixID with _localName = "gender-male" }
    let ``gender-female`` = { _prefixID with _localName = "gender-female" }
    let ``gender-other`` = { _prefixID with _localName = "gender-other" }
    let VoicePhoneNumber = { _prefixID with _localName = "VoicePhoneNumber" }
    let VideoTelephoneNumber = { _prefixID with _localName = "VideoTelephoneNumber" }
    let IsdnNumber = { _prefixID with _localName = "IsdnNumber" }
    let ParcelDeliveryAddress = { _prefixID with _localName = "ParcelDeliveryAddress" }
    let AudioIMAccount = { _prefixID with _localName = "AudioIMAccount" }
    let FaxNumber = { _prefixID with _localName = "FaxNumber" }
    let CarPhoneNumber = { _prefixID with _localName = "CarPhoneNumber" }
    let ContactListDataObject = { _prefixID with _localName = "ContactListDataObject" }
    let PcsNumber = { _prefixID with _localName = "PcsNumber" }

    let InternationalDeliveryAddress =
        { _prefixID with _localName = "InternationalDeliveryAddress" }

    let VideoIMAccount = { _prefixID with _localName = "VideoIMAccount" }
    let BbsNumber = { _prefixID with _localName = "BbsNumber" }
    let CellPhoneNumber = { _prefixID with _localName = "CellPhoneNumber" }

    let DomesticDeliveryAddress =
        { _prefixID with _localName = "DomesticDeliveryAddress" }

    let nameFamily = { _prefixID with _localName = "nameFamily" }
    let nameGiven = { _prefixID with _localName = "nameGiven" }
    let nameAdditional = { _prefixID with _localName = "nameAdditional" }
    let fullname = { _prefixID with _localName = "fullname" }
    let hasContactMedium = { _prefixID with _localName = "hasContactMedium" }
    let url = { _prefixID with _localName = "url" }
    let contributor = { _prefixID with _localName = "contributor" }
    let creator = { _prefixID with _localName = "creator" }
    let region = { _prefixID with _localName = "region" }
    let key = { _prefixID with _localName = "key" }
    let nameHonorificSuffix = { _prefixID with _localName = "nameHonorificSuffix" }
    let contactUID = { _prefixID with _localName = "contactUID" }
    let contactLocalUID = { _prefixID with _localName = "contactLocalUID" }
    let publisher = { _prefixID with _localName = "publisher" }
    let country = { _prefixID with _localName = "country" }
    let nameHonorificPrefix = { _prefixID with _localName = "nameHonorificPrefix" }
    let extendedAddress = { _prefixID with _localName = "extendedAddress" }
    let hasIMContact = { _prefixID with _localName = "hasIMContact" }
    let hasLocation = { _prefixID with _localName = "hasLocation" }
    let phoneNumber = { _prefixID with _localName = "phoneNumber" }
    let nickname = { _prefixID with _localName = "nickname" }
    let containsContact = { _prefixID with _localName = "containsContact" }
    let department = { _prefixID with _localName = "department" }
    let imID = { _prefixID with _localName = "imID" }
    let imAccountAddress = { _prefixID with _localName = "imAccountAddress" }
    let addressLocation = { _prefixID with _localName = "addressLocation" }
    let note = { _prefixID with _localName = "note" }
    let representative = { _prefixID with _localName = "representative" }
    let streetAddress = { _prefixID with _localName = "streetAddress" }
    let hasPhoneNumber = { _prefixID with _localName = "hasPhoneNumber" }
    let photo = { _prefixID with _localName = "photo" }
    let logo = { _prefixID with _localName = "logo" }
    let websiteUrl = { _prefixID with _localName = "websiteUrl" }
    let birthDate = { _prefixID with _localName = "birthDate" }
    let hasEmailAddress = { _prefixID with _localName = "hasEmailAddress" }
    let postalcode = { _prefixID with _localName = "postalcode" }
    let org = { _prefixID with _localName = "org" }
    let title = { _prefixID with _localName = "title" }
    let voiceMail = { _prefixID with _localName = "voiceMail" }
    let belongsToGroup = { _prefixID with _localName = "belongsToGroup" }
    let contactGroupName = { _prefixID with _localName = "contactGroupName" }
    let contactMediumComment = { _prefixID with _localName = "contactMediumComment" }
    let foafUrl = { _prefixID with _localName = "foafUrl" }
    let emailAddress = { _prefixID with _localName = "emailAddress" }
    let locality = { _prefixID with _localName = "locality" }
    let county = { _prefixID with _localName = "county" }
    let district = { _prefixID with _localName = "district" }
    let sound = { _prefixID with _localName = "sound" }
    let imNickname = { _prefixID with _localName = "imNickname" }
    let imAvatar = { _prefixID with _localName = "imAvatar" }
    let hobby = { _prefixID with _localName = "hobby" }
    let blogUrl = { _prefixID with _localName = "blogUrl" }
    let role = { _prefixID with _localName = "role" }
    let hasPostalAddress = { _prefixID with _localName = "hasPostalAddress" }
    let imAccountType = { _prefixID with _localName = "imAccountType" }
    let imProtocol = { _prefixID with _localName = "imProtocol" }
    let pobox = { _prefixID with _localName = "pobox" }
    let imStatusMessage = { _prefixID with _localName = "imStatusMessage" }
    let imDisplayName = { _prefixID with _localName = "imDisplayName" }
    let imEnabled = { _prefixID with _localName = "imEnabled" }
    let gender = { _prefixID with _localName = "gender" }
    let hasAffiliation = { _prefixID with _localName = "hasAffiliation" }
    let PresenceStatus = { _prefixID with _localName = "PresenceStatus" }

    let ``presence-status-unset`` =
        { _prefixID with _localName = "presence-status-unset" }

    let ``presence-status-offline`` =
        { _prefixID with _localName = "presence-status-offline" }

    let ``presence-status-available`` =
        { _prefixID with _localName = "presence-status-available" }

    let ``presence-status-away`` =
        { _prefixID with _localName = "presence-status-away" }

    let ``presence-status-extended-away`` =
        { _prefixID with _localName = "presence-status-extended-away" }

    let ``presence-status-hidden`` =
        { _prefixID with _localName = "presence-status-hidden" }

    let ``presence-status-busy`` =
        { _prefixID with _localName = "presence-status-busy" }

    let ``presence-status-unknown`` =
        { _prefixID with _localName = "presence-status-unknown" }

    let ``presence-status-error`` =
        { _prefixID with _localName = "presence-status-error" }

    let imPresence = { _prefixID with _localName = "imPresence" }
    let presenceLastModified = { _prefixID with _localName = "presenceLastModified" }
    let IMCapability = { _prefixID with _localName = "IMCapability" }

    let ``im-capability-text-chat`` =
        { _prefixID with _localName = "im-capability-text-chat" }

    let ``im-capability-media-calls`` =
        { _prefixID with _localName = "im-capability-media-calls" }

    let ``im-capability-audio-calls`` =
        { _prefixID with _localName = "im-capability-audio-calls" }

    let ``im-capability-video-calls`` =
        { _prefixID with _localName = "im-capability-video-calls" }

    let ``im-capability-upgrading-calls`` =
        { _prefixID with _localName = "im-capability-upgrading-calls" }

    let ``im-capability-file-transfers`` =
        { _prefixID with _localName = "im-capability-file-transfers" }

    let ``im-capability-stream-tubes`` =
        { _prefixID with _localName = "im-capability-stream-tubes" }

    let ``im-capability-dbus-tubes`` =
        { _prefixID with _localName = "im-capability-dbus-tubes" }

    let imCapability = { _prefixID with _localName = "imCapability" }
    let hasIMAddress = { _prefixID with _localName = "hasIMAddress" }
    let AuthorizationStatus = { _prefixID with _localName = "AuthorizationStatus" }

    let ``predefined-auth-status-yes`` =
        { _prefixID with _localName = "predefined-auth-status-yes" }

    let ``predefined-auth-status-no`` =
        { _prefixID with _localName = "predefined-auth-status-no" }

    let ``predefined-auth-status-requested`` =
        { _prefixID with _localName = "predefined-auth-status-requested" }

    let imAddressAuthStatusFrom =
        { _prefixID with _localName = "imAddressAuthStatusFrom" }

    let imAddressAuthStatusTo = { _prefixID with _localName = "imAddressAuthStatusTo" }
    let video = { _prefixID with _localName = "video" }

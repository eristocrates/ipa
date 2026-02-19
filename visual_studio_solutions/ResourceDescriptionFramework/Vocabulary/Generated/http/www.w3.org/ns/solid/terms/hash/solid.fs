namespace Solid.Namespace
module solid =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/solid/terms#" (Some "http://www.w3.org/ns/solid/terms#") (Some "solid") None
    let Account = {_prefixID with _localName = "Account"}
    let Inbox = {_prefixID with _localName = "Inbox"}
    let InsertDeletePatch = {_prefixID with _localName = "InsertDeletePatch"}
    let ListedDocument = {_prefixID with _localName = "ListedDocument"}
    let Notification = {_prefixID with _localName = "Notification"}
    let Patch = {_prefixID with _localName = "Patch"}
    let Timeline = {_prefixID with _localName = "Timeline"}
    let TypeIndex = {_prefixID with _localName = "TypeIndex"}
    let TypeRegistration = {_prefixID with _localName = "TypeRegistration"}
    let UnlistedDocument = {_prefixID with _localName = "UnlistedDocument"}
    let account = {_prefixID with _localName = "account"}
    let deletes = {_prefixID with _localName = "deletes"}
    let forClass = {_prefixID with _localName = "forClass"}
    let inbox = {_prefixID with _localName = "inbox"}
    let inserts = {_prefixID with _localName = "inserts"}
    let instance = {_prefixID with _localName = "instance"}
    let instanceContainer = {_prefixID with _localName = "instanceContainer"}
    let loginEndpoint = {_prefixID with _localName = "loginEndpoint"}
    let logoutEndpoint = {_prefixID with _localName = "logoutEndpoint"}
    let notification = {_prefixID with _localName = "notification"}
    let oidcIssuer = {_prefixID with _localName = "oidcIssuer"}
    let owner = {_prefixID with _localName = "owner"}
    let patches = {_prefixID with _localName = "patches"}
    let privateLabelIndex = {_prefixID with _localName = "privateLabelIndex"}
    let privateTypeIndex = {_prefixID with _localName = "privateTypeIndex"}
    let publicTypeIndex = {_prefixID with _localName = "publicTypeIndex"}
    let read = {_prefixID with _localName = "read"}
    let storageDescription = {_prefixID with _localName = "storageDescription"}
    let storageQuota = {_prefixID with _localName = "storageQuota"}
    let storageUsage = {_prefixID with _localName = "storageUsage"}
    let timeline = {_prefixID with _localName = "timeline"}
    let typeIndex = {_prefixID with _localName = "typeIndex"}
    let where = {_prefixID with _localName = "where"}
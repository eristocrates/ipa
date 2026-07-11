namespace Oidc.Namespace
module oidc =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/solid/oidc#" (Some "http://www.w3.org/ns/solid/oidc#") (Some "oidc") None
    let application_type = {_prefixID with _localName = "application_type"}
    let client_name = {_prefixID with _localName = "client_name"}
    let client_uri = {_prefixID with _localName = "client_uri"}
    let contacts = {_prefixID with _localName = "contacts"}
    let default_max_age = {_prefixID with _localName = "default_max_age"}
    let grant_types = {_prefixID with _localName = "grant_types"}
    let logo_uri = {_prefixID with _localName = "logo_uri"}
    let policy_uri = {_prefixID with _localName = "policy_uri"}
    let redirect_uris = {_prefixID with _localName = "redirect_uris"}
    let require_auth_time = {_prefixID with _localName = "require_auth_time"}
    let response_types = {_prefixID with _localName = "response_types"}
    let scope = {_prefixID with _localName = "scope"}
    let token_endpoint_auth_method = {_prefixID with _localName = "token_endpoint_auth_method"}
    let tos_uri = {_prefixID with _localName = "tos_uri"}
namespace Notify.Namespace
module notify =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/solid/notifications#" (Some "http://www.w3.org/ns/solid/notifications#") (Some "notify") None
    let EventSourceChannel2023 = {_prefixID with _localName = "EventSourceChannel2023"}
    let LDNChannel2023 = {_prefixID with _localName = "LDNChannel2023"}
    let StreamingHTTPChannel2023 = {_prefixID with _localName = "StreamingHTTPChannel2023"}
    let WebSocketChannel2023 = {_prefixID with _localName = "WebSocketChannel2023"}
    let WebhookChannel2023 = {_prefixID with _localName = "WebhookChannel2023"}
    let accept = {_prefixID with _localName = "accept"}
    let channel = {_prefixID with _localName = "channel"}
    let channelType = {_prefixID with _localName = "channelType"}
    let endAt = {_prefixID with _localName = "endAt"}
    let feature = {_prefixID with _localName = "feature"}
    let rate = {_prefixID with _localName = "rate"}
    let receiveFrom = {_prefixID with _localName = "receiveFrom"}
    let sendTo = {_prefixID with _localName = "sendTo"}
    let sender = {_prefixID with _localName = "sender"}
    let startAt = {_prefixID with _localName = "startAt"}
    let state = {_prefixID with _localName = "state"}
    let subscription = {_prefixID with _localName = "subscription"}
    let topic = {_prefixID with _localName = "topic"}
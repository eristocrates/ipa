namespace Swap.pim.email.Namespace
module email =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/pim/email#" (Some "http://www.w3.org/2000/10/swap/pim/email") (Some "swap.pim.email") None
    let Agent = {_prefixID with _localName = "Agent"}
    let Mailbox = {_prefixID with _localName = "Mailbox"}
    let Message = {_prefixID with _localName = "Message"}
    let cc = {_prefixID with _localName = "cc"}
    let date = {_prefixID with _localName = "date"}
    let date_iso = {_prefixID with _localName = "date_iso"}
    let from = {_prefixID with _localName = "from"}
    let mbox = {_prefixID with _localName = "mbox"}
    let phrase = {_prefixID with _localName = "phrase"}
    let received_iso = {_prefixID with _localName = "received_iso"}
    let recipients = {_prefixID with _localName = "recipients"}
    let references = {_prefixID with _localName = "references"}
    let senders = {_prefixID with _localName = "senders"}
    let subject = {_prefixID with _localName = "subject"}
    let ``to`` = {_prefixID with _localName = "to"}
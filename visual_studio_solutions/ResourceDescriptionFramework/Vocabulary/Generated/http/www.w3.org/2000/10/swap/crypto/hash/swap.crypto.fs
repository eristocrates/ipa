namespace Swap.crypto.Namespace
module crypto =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/crypto#" (Some "http://www.w3.org/2000/10/swap/crypto") (Some "swap.crypto") None
    let CanEncrypt = {_prefixID with _localName = "CanEncrypt"}
    let CanSign = {_prefixID with _localName = "CanSign"}
    let HasPrivate = {_prefixID with _localName = "HasPrivate"}
    let HashFunction = {_prefixID with _localName = "HashFunction"}
    let PublicKeyObject = {_prefixID with _localName = "PublicKeyObject"}
    let md5 = {_prefixID with _localName = "md5"}
    let publicKey = {_prefixID with _localName = "publicKey"}
    let sha = {_prefixID with _localName = "sha"}
    let sign = {_prefixID with _localName = "sign"}
    let verify = {_prefixID with _localName = "verify"}
    let verifyBoolean = {_prefixID with _localName = "verifyBoolean"}
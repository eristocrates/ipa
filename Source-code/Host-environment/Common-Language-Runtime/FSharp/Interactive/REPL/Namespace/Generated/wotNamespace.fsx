#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wot =
    let _prefixId = PrefixId.fromNamespaceLabel "http://xmlns.com/wot/0.1/" "wot"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Encrypted Document^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An encrypted document intended for a set of recipients.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/EncryptedDocument">wot:EncryptedDocument</a>
    /// </summary>
    let EncryptedDocument = _prefixId.prefix "EncryptedDocument"
    /// <summary>
    ///   <para>rdfs:comment : An endorsement resource containing a detached ascii signature.^^xsd:string</para>
    ///   <para>rdfs:label : Endorsement^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/Endorsement">wot:Endorsement</a>
    /// </summary>
    let Endorsement = _prefixId.prefix "Endorsement"
    /// <summary>
    ///   <para>rdfs:comment : A class used to represent a PGP/GPG public key for a user (an agent, person, group or organization).^^xsd:string</para>
    ///   <para>rdfs:label : Public Key^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/PubKey">wot:PubKey</a>
    /// </summary>
    let PubKey = _prefixId.prefix "PubKey"
    /// <summary>
    ///   <para>rdfs:comment : An event describing the action of a public key being signed by some other public key.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Key Signing Event^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/SigEvent">wot:SigEvent</a>
    /// </summary>
    let SigEvent = _prefixId.prefix "SigEvent"
    /// <summary>
    ///   <para>rdfs:comment : A user (agent, person, group or organization) of a PGP/GPG public key.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Key User^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/User">wot:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Assurance^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking a document to an endorsement resource containing a detached ascii signature.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/assurance">wot:assurance</a>
    /// </summary>
    let assurance = _prefixId.prefix "assurance"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Encrypted to^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking an encrypted document to a recipient.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/encryptedTo">wot:encryptedTo</a>
    /// </summary>
    let encryptedTo = _prefixId.prefix "encryptedTo"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Encrypted by^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking an encrypted document to the public key that was used to encrypt it.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/encrypter">wot:encrypter</a>
    /// </summary>
    let encrypter = _prefixId.prefix "encrypter"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Fingerprint^^xsd:string</para>
    ///   <para>rdfs:comment : A public key hex fingerprint string (40 digits, white space insignificant).^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/fingerprint">wot:fingerprint</a>
    /// </summary>
    let fingerprint = _prefixId.prefix "fingerprint"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Key^^xsd:string</para>
    ///   <para>rdfs:comment : A property to link a PubKey from a User^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/hasKey">wot:hasKey</a>
    /// </summary>
    let hasKey = _prefixId.prefix "hasKey"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Hex identifier^^xsd:string</para>
    ///   <para>rdfs:comment : A public key hex identifier string (8 digits).^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/hex_id">wot:hex_id</a>
    /// </summary>
    let hex_id = _prefixId.prefix "hex_id"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Identity^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking a public key to the user of the key.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/identity">wot:identity</a>
    /// </summary>
    let identity = _prefixId.prefix "identity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Length^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric string representing the length, in bytes, of a public key.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/length">wot:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Address^^xsd:string</para>
    ///   <para>rdfs:comment : The location of an ascii version of a public key.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/pubkeyAddress">wot:pubkeyAddress</a>
    /// </summary>
    let pubkeyAddress = _prefixId.prefix "pubkeyAddress"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Signature date^^xsd:string</para>
    ///   <para>rdfs:comment : The date of a public key signature event.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/sigdate">wot:sigdate</a>
    /// </summary>
    let sigdate = _prefixId.prefix "sigdate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Signed^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking a public key to a public key signature event.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/signed">wot:signed</a>
    /// </summary>
    let signed = _prefixId.prefix "signed"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Signer^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking a public key signature event to the public key that was used to sign.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/signer">wot:signer</a>
    /// </summary>
    let signer = _prefixId.prefix "signer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Signature time^^xsd:string</para>
    ///   <para>rdfs:comment : The time (of day) of a public key signature event.^^xsd:string</para>
    ///   <a href="http://xmlns.com/wot/0.1/sigtime">wot:sigtime</a>
    /// </summary>
    let sigtime = _prefixId.prefix "sigtime"

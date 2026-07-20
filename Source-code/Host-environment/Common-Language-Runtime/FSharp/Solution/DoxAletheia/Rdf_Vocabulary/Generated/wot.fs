namespace http.xmlns.com.wot._0._1.slash

open DoxAletheia

module wot =
    let _namespace_name = "http://xmlns.com/wot/0.1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An encrypted document intended for a set of recipients.
    /// <see href="http://xmlns.com/wot/0.1/EncryptedDocument"></see></summary>
    let EncryptedDocument = _prefix "EncryptedDocument"
    /// <summary>
    /// A user (agent, person, group or organization) of a PGP/GPG public key.
    /// <see href="http://xmlns.com/wot/0.1/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// An event describing the action of a public key being signed by some other public key.
    /// <see href="http://xmlns.com/wot/0.1/SigEvent"></see></summary>
    let SigEvent = _prefix "SigEvent"
    /// <summary>
    /// An endorsement resource containing a detached ascii signature.
    /// <see href="http://xmlns.com/wot/0.1/Endorsement"></see></summary>
    let Endorsement = _prefix "Endorsement"
    /// <summary>
    /// A class used to represent a PGP/GPG public key for a user (an agent, person, group or organization).
    /// <see href="http://xmlns.com/wot/0.1/PubKey"></see></summary>
    let PubKey = _prefix "PubKey"
    /// <summary>
    /// A property linking a document to an endorsement resource containing a detached ascii signature.
    /// <see href="http://xmlns.com/wot/0.1/assurance"></see></summary>
    let assurance = _prefix "assurance"
    /// <summary>
    /// A property linking an encrypted document to a recipient.
    /// <see href="http://xmlns.com/wot/0.1/encryptedTo"></see></summary>
    let encryptedTo = _prefix "encryptedTo"
    /// <summary>
    /// A property linking an encrypted document to the public key that was used to encrypt it.
    /// <see href="http://xmlns.com/wot/0.1/encrypter"></see></summary>
    let encrypter = _prefix "encrypter"
    /// <summary>
    /// A public key hex fingerprint string (40 digits, white space insignificant).
    /// <see href="http://xmlns.com/wot/0.1/fingerprint"></see></summary>
    let fingerprint = _prefix "fingerprint"
    /// <summary>
    /// A property to link a PubKey from a User
    /// <see href="http://xmlns.com/wot/0.1/hasKey"></see></summary>
    let hasKey = _prefix "hasKey"
    /// <summary>
    /// A property linking a public key to the user of the key.
    /// <see href="http://xmlns.com/wot/0.1/identity"></see></summary>
    let identity = _prefix "identity"
    /// <summary>
    /// A public key hex identifier string (8 digits).
    /// <see href="http://xmlns.com/wot/0.1/hex_id"></see></summary>
    let hex_id = _prefix "hex_id"
    /// <summary>
    /// A numeric string representing the length, in bytes, of a public key.
    /// <see href="http://xmlns.com/wot/0.1/length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// The location of an ascii version of a public key.
    /// <see href="http://xmlns.com/wot/0.1/pubkeyAddress"></see></summary>
    let pubkeyAddress = _prefix "pubkeyAddress"
    /// <summary>
    /// The date of a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/sigdate"></see></summary>
    let sigdate = _prefix "sigdate"
    /// <summary>
    /// A property linking a public key to a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/signed"></see></summary>
    let signed = _prefix "signed"
    /// <summary>
    /// A property linking a public key signature event to the public key that was used to sign.
    /// <see href="http://xmlns.com/wot/0.1/signer"></see></summary>
    let signer = _prefix "signer"
    /// <summary>
    /// The time (of day) of a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/sigtime"></see></summary>
    let sigtime = _prefix "sigtime"

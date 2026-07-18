namespace http.xmlns.com.wot._0._1.slash

open DoxAletheia.Rdf_Vocabulary

module wot =
    let _namespace_name = "http://xmlns.com/wot/0.1/"

    /// <summary>
    /// An encrypted document intended for a set of recipients.
    /// <see href="http://xmlns.com/wot/0.1/EncryptedDocument"></see></summary>
    let EncryptedDocument =
        Namespaced_IRI.parse _namespace_name "EncryptedDocument" |> NamespacedName

    /// <summary>
    /// A user (agent, person, group or organization) of a PGP/GPG public key.
    /// <see href="http://xmlns.com/wot/0.1/User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// An event describing the action of a public key being signed by some other public key.
    /// <see href="http://xmlns.com/wot/0.1/SigEvent"></see></summary>
    let SigEvent = Namespaced_IRI.parse _namespace_name "SigEvent" |> NamespacedName

    /// <summary>
    /// An endorsement resource containing a detached ascii signature.
    /// <see href="http://xmlns.com/wot/0.1/Endorsement"></see></summary>
    let Endorsement =
        Namespaced_IRI.parse _namespace_name "Endorsement" |> NamespacedName

    /// <summary>
    /// A class used to represent a PGP/GPG public key for a user (an agent, person, group or organization).
    /// <see href="http://xmlns.com/wot/0.1/PubKey"></see></summary>
    let PubKey = Namespaced_IRI.parse _namespace_name "PubKey" |> NamespacedName
    /// <summary>
    /// A property linking a document to an endorsement resource containing a detached ascii signature.
    /// <see href="http://xmlns.com/wot/0.1/assurance"></see></summary>
    let assurance = Namespaced_IRI.parse _namespace_name "assurance" |> NamespacedName

    /// <summary>
    /// A property linking an encrypted document to a recipient.
    /// <see href="http://xmlns.com/wot/0.1/encryptedTo"></see></summary>
    let encryptedTo =
        Namespaced_IRI.parse _namespace_name "encryptedTo" |> NamespacedName

    /// <summary>
    /// A property linking an encrypted document to the public key that was used to encrypt it.
    /// <see href="http://xmlns.com/wot/0.1/encrypter"></see></summary>
    let encrypter = Namespaced_IRI.parse _namespace_name "encrypter" |> NamespacedName

    /// <summary>
    /// A public key hex fingerprint string (40 digits, white space insignificant).
    /// <see href="http://xmlns.com/wot/0.1/fingerprint"></see></summary>
    let fingerprint =
        Namespaced_IRI.parse _namespace_name "fingerprint" |> NamespacedName

    /// <summary>
    /// A property to link a PubKey from a User
    /// <see href="http://xmlns.com/wot/0.1/hasKey"></see></summary>
    let hasKey = Namespaced_IRI.parse _namespace_name "hasKey" |> NamespacedName
    /// <summary>
    /// A property linking a public key to the user of the key.
    /// <see href="http://xmlns.com/wot/0.1/identity"></see></summary>
    let identity = Namespaced_IRI.parse _namespace_name "identity" |> NamespacedName
    /// <summary>
    /// A public key hex identifier string (8 digits).
    /// <see href="http://xmlns.com/wot/0.1/hex_id"></see></summary>
    let hex_id = Namespaced_IRI.parse _namespace_name "hex_id" |> NamespacedName
    /// <summary>
    /// A numeric string representing the length, in bytes, of a public key.
    /// <see href="http://xmlns.com/wot/0.1/length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// The location of an ascii version of a public key.
    /// <see href="http://xmlns.com/wot/0.1/pubkeyAddress"></see></summary>
    let pubkeyAddress =
        Namespaced_IRI.parse _namespace_name "pubkeyAddress" |> NamespacedName

    /// <summary>
    /// The date of a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/sigdate"></see></summary>
    let sigdate = Namespaced_IRI.parse _namespace_name "sigdate" |> NamespacedName
    /// <summary>
    /// A property linking a public key to a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/signed"></see></summary>
    let signed = Namespaced_IRI.parse _namespace_name "signed" |> NamespacedName
    /// <summary>
    /// A property linking a public key signature event to the public key that was used to sign.
    /// <see href="http://xmlns.com/wot/0.1/signer"></see></summary>
    let signer = Namespaced_IRI.parse _namespace_name "signer" |> NamespacedName
    /// <summary>
    /// The time (of day) of a public key signature event.
    /// <see href="http://xmlns.com/wot/0.1/sigtime"></see></summary>
    let sigtime = Namespaced_IRI.parse _namespace_name "sigtime" |> NamespacedName

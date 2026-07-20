namespace http.www.w3.org._2000._10.swap.crypto.hash

open DoxAletheia

module crypto =
    let _namespace_name = "http://www.w3.org/2000/10/swap/crypto#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// PublicKeyObjects which are capable of encrypting things
    /// <see href="http://www.w3.org/2000/10/swap/crypto#CanEncrypt"></see></summary>
    let CanEncrypt = _prefix "CanEncrypt"
    /// <summary>
    /// An object corresponding to a key for some algorithm.
    /// The object can hold a public and optionally a private key.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#PublicKeyObject"></see></summary>
    let PublicKeyObject = _prefix "PublicKeyObject"
    /// <summary>
    /// PublicKeyObjects which are capable of signing things.
    /// True if the algorithm is capable of signing data; false otherwise. To
    /// test if a given key object can sign data, use CanSign and HasPrivate.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#CanSign"></see></summary>
    let CanSign = _prefix "CanSign"
    /// <summary>
    ///
    /// Some keys have private parts, some don't.  This is the class of those which do.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/crypto#HasPrivate"></see></summary>
    let HasPrivate = _prefix "HasPrivate"
    /// <summary>
    ///
    /// The crypographic hash functions are (being functions) unique and are,
    /// when secure, assumed unambiguous (the whole point of being hash
    /// functions). That is, when you have the right hash, you have the right
    /// document. Currently (2001/9) only SHA is given that property.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/crypto#HashFunction"></see></summary>
    let HashFunction = _prefix "HashFunction"
    /// <summary>
    /// The object is a MD5 hash of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#md5"></see></summary>
    let md5 = _prefix "md5"
    /// <summary>
    /// The object is a public key object that doesn't
    ///     contain the private key data in the subject.
    ///     This function extracts the public part.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#publicKey"></see></summary>
    let publicKey = _prefix "publicKey"
    /// <summary>
    /// The object is a SHA-1 hash of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#sha"></see></summary>
    let sha = _prefix "sha"
    /// <summary>
    /// The subject should be a list of two things, a hash
    /// string and a key (containing private and public parts). The object is
    /// calculated as a signature string by signing the hash with the key's
    /// private part.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#sign"></see></summary>
    let sign = _prefix "sign"
    /// <summary>
    /// If the subject is a key object containing private and
    /// public parts and the obejct is a list of a hash and a signature, then
    /// this is true if and only if the signature is a valid signature of the
    /// hash with the key.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#verify"></see></summary>
    let verify = _prefix "verify"
    /// <summary>
    /// If the subject is a list containg a keypair, a hash,
    /// and a signature, then the object is either "1" if the signature
    /// validates or "0" if it does not.
    /// <see href="http://www.w3.org/2000/10/swap/crypto#verifyBoolean"></see></summary>
    let verifyBoolean = _prefix "verifyBoolean"

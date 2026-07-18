namespace http.securitytoolbox.appspot.com.securityAlgorithms.hash

open DoxAletheia.Rdf_Vocabulary

module algo =
    let _namespace_name = "http://securitytoolbox.appspot.com/securityAlgorithms#"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#AES"></see>
    /// </summary>
    let AES = Namespaced_IRI.parse _namespace_name "AES" |> NamespacedName

    /// <summary>
    /// These can be Typel, Type 2, Type3, or Type4
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#hasNSALevel"></see></summary>
    let hasNSALevel =
        Namespaced_IRI.parse _namespace_name "hasNSALevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SymmetricAlgorithm"></see>
    /// </summary>
    let SymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "SymmetricAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Algorithm"></see>
    /// </summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName

    /// <summary>
    /// NIST FIPS Standard
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#isNISTStandard"></see></summary>
    let isNISTStandard =
        Namespaced_IRI.parse _namespace_name "isNISTStandard" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#AsymmetricAlgorithm"></see>
    /// </summary>
    let AsymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "AsymmetricAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#EncryptionAlgorithm"></see>
    /// </summary>
    let EncryptionAlgorithm =
        Namespaced_IRI.parse _namespace_name "EncryptionAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Blowfish"></see>
    /// </summary>
    let Blowfish = Namespaced_IRI.parse _namespace_name "Blowfish" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CAST"></see>
    /// </summary>
    let CAST = Namespaced_IRI.parse _namespace_name "CAST" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CBC-MAC"></see>
    /// </summary>
    let ``CBC-MAC`` = Namespaced_IRI.parse _namespace_name "CBC-MAC" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MACAlgorithm"></see>
    /// </summary>
    let MACAlgorithm =
        Namespaced_IRI.parse _namespace_name "MACAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRAYON"></see>
    /// </summary>
    let CRAYON = Namespaced_IRI.parse _namespace_name "CRAYON" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-16"></see>
    /// </summary>
    let ``CRC-16`` = Namespaced_IRI.parse _namespace_name "CRC-16" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#ChecksumAlgorithm"></see>
    /// </summary>
    let ChecksumAlgorithm =
        Namespaced_IRI.parse _namespace_name "ChecksumAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-32"></see>
    /// </summary>
    let ``CRC-32`` = Namespaced_IRI.parse _namespace_name "CRC-32" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-8"></see>
    /// </summary>
    let ``CRC-8`` = Namespaced_IRI.parse _namespace_name "CRC-8" |> NamespacedName
    /// <summary>
    /// Refers only to single DES
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#DES"></see></summary>
    let DES = Namespaced_IRI.parse _namespace_name "DES" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#keyLength"></see>
    /// </summary>
    let keyLength = Namespaced_IRI.parse _namespace_name "keyLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#DiffieHellman"></see>
    /// </summary>
    let DiffieHellman =
        Namespaced_IRI.parse _namespace_name "DiffieHellman" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#KeyExchangeAlgorithm"></see>
    /// </summary>
    let KeyExchangeAlgorithm =
        Namespaced_IRI.parse _namespace_name "KeyExchangeAlgorithm" |> NamespacedName

    /// <summary>
    /// Elliptic Curve Crypto
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#ECC"></see></summary>
    let ECC = Namespaced_IRI.parse _namespace_name "ECC" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#HMAC"></see>
    /// </summary>
    let HMAC = Namespaced_IRI.parse _namespace_name "HMAC" |> NamespacedName

    /// <summary>
    ///
    /// Key dependent function; useful in providing user authentication without a
    /// secret key
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#HashAlgorithm"></see></summary>
    let HashAlgorithm =
        Namespaced_IRI.parse _namespace_name "HashAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SignatureAlgorithm"></see>
    /// </summary>
    let SignatureAlgorithm =
        Namespaced_IRI.parse _namespace_name "SignatureAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#KEA"></see>
    /// </summary>
    let KEA = Namespaced_IRI.parse _namespace_name "KEA" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MD4"></see>
    /// </summary>
    let MD4 = Namespaced_IRI.parse _namespace_name "MD4" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MD5"></see>
    /// </summary>
    let MD5 = Namespaced_IRI.parse _namespace_name "MD5" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Oakley"></see>
    /// </summary>
    let Oakley = Namespaced_IRI.parse _namespace_name "Oakley" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RC4"></see>
    /// </summary>
    let RC4 = Namespaced_IRI.parse _namespace_name "RC4" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RIPE-MD"></see>
    /// </summary>
    let ``RIPE-MD`` = Namespaced_IRI.parse _namespace_name "RIPE-MD" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RSA"></see>
    /// </summary>
    let RSA = Namespaced_IRI.parse _namespace_name "RSA" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-1"></see>
    /// </summary>
    let ``SHA-1`` = Namespaced_IRI.parse _namespace_name "SHA-1" |> NamespacedName
    /// <summary>
    /// usually used with AES
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-256"></see></summary>
    let ``SHA-256`` = Namespaced_IRI.parse _namespace_name "SHA-256" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Skipjack"></see>
    /// </summary>
    let Skipjack = Namespaced_IRI.parse _namespace_name "Skipjack" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#TripleDES"></see>
    /// </summary>
    let TripleDES = Namespaced_IRI.parse _namespace_name "TripleDES" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SynmmetricAlgorithm"></see>
    /// </summary>
    let SynmmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "SynmmetricAlgorithm" |> NamespacedName

    /// <summary>
    /// Can be CBC, ECB, OFB, CFB, or Counter
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#modeOfOperation"></see></summary>
    let modeOfOperation =
        Namespaced_IRI.parse _namespace_name "modeOfOperation" |> NamespacedName

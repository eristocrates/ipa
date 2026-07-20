namespace http.securitytoolbox.appspot.com.securityAlgorithms.hash

open DoxAletheia

module algo =
    let _namespace_name = "http://securitytoolbox.appspot.com/securityAlgorithms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#AES"></see>
    /// </summary>
    let AES = _prefix "AES"
    /// <summary>
    /// These can be Typel, Type 2, Type3, or Type4
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#hasNSALevel"></see></summary>
    let hasNSALevel = _prefix "hasNSALevel"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SymmetricAlgorithm"></see>
    /// </summary>
    let SymmetricAlgorithm = _prefix "SymmetricAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Algorithm"></see>
    /// </summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    /// NIST FIPS Standard
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#isNISTStandard"></see></summary>
    let isNISTStandard = _prefix "isNISTStandard"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#AsymmetricAlgorithm"></see>
    /// </summary>
    let AsymmetricAlgorithm = _prefix "AsymmetricAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#EncryptionAlgorithm"></see>
    /// </summary>
    let EncryptionAlgorithm = _prefix "EncryptionAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Blowfish"></see>
    /// </summary>
    let Blowfish = _prefix "Blowfish"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CAST"></see>
    /// </summary>
    let CAST = _prefix "CAST"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CBC-MAC"></see>
    /// </summary>
    let ``CBC-MAC`` = _prefix "CBC-MAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MACAlgorithm"></see>
    /// </summary>
    let MACAlgorithm = _prefix "MACAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRAYON"></see>
    /// </summary>
    let CRAYON = _prefix "CRAYON"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-16"></see>
    /// </summary>
    let ``CRC-16`` = _prefix "CRC-16"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#ChecksumAlgorithm"></see>
    /// </summary>
    let ChecksumAlgorithm = _prefix "ChecksumAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-32"></see>
    /// </summary>
    let ``CRC-32`` = _prefix "CRC-32"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-8"></see>
    /// </summary>
    let ``CRC-8`` = _prefix "CRC-8"
    /// <summary>
    /// Refers only to single DES
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#DES"></see></summary>
    let DES = _prefix "DES"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#keyLength"></see>
    /// </summary>
    let keyLength = _prefix "keyLength"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#DiffieHellman"></see>
    /// </summary>
    let DiffieHellman = _prefix "DiffieHellman"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#KeyExchangeAlgorithm"></see>
    /// </summary>
    let KeyExchangeAlgorithm = _prefix "KeyExchangeAlgorithm"
    /// <summary>
    /// Elliptic Curve Crypto
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#ECC"></see></summary>
    let ECC = _prefix "ECC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#HMAC"></see>
    /// </summary>
    let HMAC = _prefix "HMAC"
    /// <summary>
    ///
    /// Key dependent function; useful in providing user authentication without a
    /// secret key
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#HashAlgorithm"></see></summary>
    let HashAlgorithm = _prefix "HashAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SignatureAlgorithm"></see>
    /// </summary>
    let SignatureAlgorithm = _prefix "SignatureAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#KEA"></see>
    /// </summary>
    let KEA = _prefix "KEA"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MD4"></see>
    /// </summary>
    let MD4 = _prefix "MD4"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#MD5"></see>
    /// </summary>
    let MD5 = _prefix "MD5"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Oakley"></see>
    /// </summary>
    let Oakley = _prefix "Oakley"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RC4"></see>
    /// </summary>
    let RC4 = _prefix "RC4"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RIPE-MD"></see>
    /// </summary>
    let ``RIPE-MD`` = _prefix "RIPE-MD"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#RSA"></see>
    /// </summary>
    let RSA = _prefix "RSA"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-1"></see>
    /// </summary>
    let ``SHA-1`` = _prefix "SHA-1"
    /// <summary>
    /// usually used with AES
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-256"></see></summary>
    let ``SHA-256`` = _prefix "SHA-256"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#Skipjack"></see>
    /// </summary>
    let Skipjack = _prefix "Skipjack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#TripleDES"></see>
    /// </summary>
    let TripleDES = _prefix "TripleDES"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityAlgorithms#SynmmetricAlgorithm"></see>
    /// </summary>
    let SynmmetricAlgorithm = _prefix "SynmmetricAlgorithm"
    /// <summary>
    /// Can be CBC, ECB, OFB, CFB, or Counter
    /// <see href="http://securitytoolbox.appspot.com/securityAlgorithms#modeOfOperation"></see></summary>
    let modeOfOperation = _prefix "modeOfOperation"

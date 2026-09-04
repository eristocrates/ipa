#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module algo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/securityAlgorithms#" "algo"

    let _namespaceIri = _prefixId.prefix ""
    let AES = _prefixId.prefix "AES"
    let Algorithm = _prefixId.prefix "Algorithm"
    let AsymmetricAlgorithm = _prefixId.prefix "AsymmetricAlgorithm"
    let Blowfish = _prefixId.prefix "Blowfish"
    let CAST = _prefixId.prefix "CAST"
    let CBC_MAC = _prefixId.prefix "CBC-MAC"
    let CRAYON = _prefixId.prefix "CRAYON"
    let CRC_16 = _prefixId.prefix "CRC-16"
    let CRC_32 = _prefixId.prefix "CRC-32"
    let CRC_8 = _prefixId.prefix "CRC-8"
    let ChecksumAlgorithm = _prefixId.prefix "ChecksumAlgorithm"
    let DES = _prefixId.prefix "DES"
    let DiffieHellman = _prefixId.prefix "DiffieHellman"
    let ECC = _prefixId.prefix "ECC"
    let EncryptionAlgorithm = _prefixId.prefix "EncryptionAlgorithm"
    let HMAC = _prefixId.prefix "HMAC"
    /// <summary>
    ///   <para>rdfs:comment :
    /// Key dependent function; useful in providing user authentication without a
    /// secret key
    /// ^^xsd:string</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityAlgorithms#HashAlgorithm">algo:HashAlgorithm</a>
    /// </summary>
    let HashAlgorithm = _prefixId.prefix "HashAlgorithm"
    let KEA = _prefixId.prefix "KEA"
    let KeyExchangeAlgorithm = _prefixId.prefix "KeyExchangeAlgorithm"
    let MACAlgorithm = _prefixId.prefix "MACAlgorithm"
    let MD4 = _prefixId.prefix "MD4"
    let MD5 = _prefixId.prefix "MD5"
    let Oakley = _prefixId.prefix "Oakley"
    let RC4 = _prefixId.prefix "RC4"
    let RIPE_MD = _prefixId.prefix "RIPE-MD"
    let RSA = _prefixId.prefix "RSA"
    let SHA_1 = _prefixId.prefix "SHA-1"
    let SHA_256 = _prefixId.prefix "SHA-256"
    let SignatureAlgorithm = _prefixId.prefix "SignatureAlgorithm"
    let Skipjack = _prefixId.prefix "Skipjack"
    let SymmetricAlgorithm = _prefixId.prefix "SymmetricAlgorithm"
    let SynmmetricAlgorithm = _prefixId.prefix "SynmmetricAlgorithm"
    let TripleDES = _prefixId.prefix "TripleDES"
    /// <summary>
    ///   <para>rdfs:comment : These can be Typel, Type 2, Type3, or Type4^^xsd:string</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityAlgorithms#hasNSALevel">algo:hasNSALevel</a>
    /// </summary>
    let hasNSALevel = _prefixId.prefix "hasNSALevel"
    /// <summary>
    ///   <para>rdfs:comment : NIST FIPS Standard^^xsd:string</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityAlgorithms#isNISTStandard">algo:isNISTStandard</a>
    /// </summary>
    let isNISTStandard = _prefixId.prefix "isNISTStandard"
    let keyLength = _prefixId.prefix "keyLength"
    /// <summary>
    ///   <para>rdfs:comment : Can be CBC, ECB, OFB, CFB, or Counter^^xsd:string</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityAlgorithms#modeOfOperation">algo:modeOfOperation</a>
    /// </summary>
    let modeOfOperation = _prefixId.prefix "modeOfOperation"

namespace http.securitytoolbox.appspot.com.securityAlgorithms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module algo =
    let _namespace_iri = Namespace_Iri algo |> NamespaceIRI
    /// <summary>
    ///   <para>algo:AES</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#AES">http://securitytoolbox.appspot.com/securityAlgorithms#AES</seealso>
    let AES = Prefixed_Name(algo, "AES") |> PrefixedName
    /// <summary>
    ///   <para>algo:hasNSALevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>These can be Typel, Type 2, Type3, or Type4</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#hasNSALevel">http://securitytoolbox.appspot.com/securityAlgorithms#hasNSALevel</seealso>
    let hasNSALevel = Prefixed_Name(algo, "hasNSALevel") |> PrefixedName
    /// <summary>
    ///   <para>algo:EncryptionAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#EncryptionAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#EncryptionAlgorithm</seealso>
    let EncryptionAlgorithm = Prefixed_Name(algo, "EncryptionAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:Blowfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#Blowfish">http://securitytoolbox.appspot.com/securityAlgorithms#Blowfish</seealso>
    let Blowfish = Prefixed_Name(algo, "Blowfish") |> PrefixedName
    /// <summary>
    ///   <para>algo:CBC-MAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:MACAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CBC-MAC">http://securitytoolbox.appspot.com/securityAlgorithms#CBC-MAC</seealso>
    let CBC_MAC = Prefixed_Name(algo, "CBC-MAC") |> PrefixedName
    /// <summary>
    ///   <para>algo:MACAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#MACAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#MACAlgorithm</seealso>
    let MACAlgorithm = Prefixed_Name(algo, "MACAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:CRC-32</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:ChecksumAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-32">http://securitytoolbox.appspot.com/securityAlgorithms#CRC-32</seealso>
    let CRC_32 = Prefixed_Name(algo, "CRC-32") |> PrefixedName
    /// <summary>
    ///   <para>algo:CRC-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:ChecksumAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-8">http://securitytoolbox.appspot.com/securityAlgorithms#CRC-8</seealso>
    let CRC_8 = Prefixed_Name(algo, "CRC-8") |> PrefixedName
    /// <summary>
    ///   <para>algo:DES</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    ///   <para>Refers only to single DES</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#DES">http://securitytoolbox.appspot.com/securityAlgorithms#DES</seealso>
    let DES = Prefixed_Name(algo, "DES") |> PrefixedName
    /// <summary>
    ///   <para>algo:keyLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#keyLength">http://securitytoolbox.appspot.com/securityAlgorithms#keyLength</seealso>
    let keyLength = Prefixed_Name(algo, "keyLength") |> PrefixedName
    /// <summary>
    ///   <para>algo:HashAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// Key dependent function; useful in providing user authentication without a
    /// secret key
    /// </para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#HashAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#HashAlgorithm</seealso>
    let HashAlgorithm = Prefixed_Name(algo, "HashAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:SignatureAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#SignatureAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#SignatureAlgorithm</seealso>
    let SignatureAlgorithm = Prefixed_Name(algo, "SignatureAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:KEA</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:KeyExchangeAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#KEA">http://securitytoolbox.appspot.com/securityAlgorithms#KEA</seealso>
    let KEA = Prefixed_Name(algo, "KEA") |> PrefixedName
    /// <summary>
    ///   <para>algo:RC4</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#RC4">http://securitytoolbox.appspot.com/securityAlgorithms#RC4</seealso>
    let RC4 = Prefixed_Name(algo, "RC4") |> PrefixedName
    /// <summary>
    ///   <para>algo:RIPE-MD</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:HashAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#RIPE-MD">http://securitytoolbox.appspot.com/securityAlgorithms#RIPE-MD</seealso>
    let RIPE_MD = Prefixed_Name(algo, "RIPE-MD") |> PrefixedName
    /// <summary>
    ///   <para>algo:RSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:AsymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#RSA">http://securitytoolbox.appspot.com/securityAlgorithms#RSA</seealso>
    let RSA = Prefixed_Name(algo, "RSA") |> PrefixedName
    /// <summary>
    ///   <para>algo:SHA-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:HashAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-1">http://securitytoolbox.appspot.com/securityAlgorithms#SHA-1</seealso>
    let SHA_1 = Prefixed_Name(algo, "SHA-1") |> PrefixedName
    /// <summary>
    ///   <para>algo:CRAYON</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CRAYON">http://securitytoolbox.appspot.com/securityAlgorithms#CRAYON</seealso>
    let CRAYON = Prefixed_Name(algo, "CRAYON") |> PrefixedName

    /// <summary>
    ///   <para>algo:KeyExchangeAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#KeyExchangeAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#KeyExchangeAlgorithm</seealso>
    let KeyExchangeAlgorithm =
        Prefixed_Name(algo, "KeyExchangeAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>algo:HMAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:MACAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#HMAC">http://securitytoolbox.appspot.com/securityAlgorithms#HMAC</seealso>
    let HMAC = Prefixed_Name(algo, "HMAC") |> PrefixedName
    /// <summary>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#SymmetricAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#SymmetricAlgorithm</seealso>
    let SymmetricAlgorithm = Prefixed_Name(algo, "SymmetricAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:isNISTStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>NIST FIPS Standard</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#isNISTStandard">http://securitytoolbox.appspot.com/securityAlgorithms#isNISTStandard</seealso>
    let isNISTStandard = Prefixed_Name(algo, "isNISTStandard") |> PrefixedName
    /// <summary>
    ///   <para>algo:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#Algorithm">http://securitytoolbox.appspot.com/securityAlgorithms#Algorithm</seealso>
    let Algorithm = Prefixed_Name(algo, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:CAST</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CAST">http://securitytoolbox.appspot.com/securityAlgorithms#CAST</seealso>
    let CAST = Prefixed_Name(algo, "CAST") |> PrefixedName
    /// <summary>
    ///   <para>algo:CRC-16</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:ChecksumAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#CRC-16">http://securitytoolbox.appspot.com/securityAlgorithms#CRC-16</seealso>
    let CRC_16 = Prefixed_Name(algo, "CRC-16") |> PrefixedName
    /// <summary>
    ///   <para>algo:DiffieHellman</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:KeyExchangeAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#DiffieHellman">http://securitytoolbox.appspot.com/securityAlgorithms#DiffieHellman</seealso>
    let DiffieHellman = Prefixed_Name(algo, "DiffieHellman") |> PrefixedName
    /// <summary>
    ///   <para>algo:MD4</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:HashAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#MD4">http://securitytoolbox.appspot.com/securityAlgorithms#MD4</seealso>
    let MD4 = Prefixed_Name(algo, "MD4") |> PrefixedName
    /// <summary>
    ///   <para>algo:TripleDES</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#TripleDES">http://securitytoolbox.appspot.com/securityAlgorithms#TripleDES</seealso>
    let TripleDES = Prefixed_Name(algo, "TripleDES") |> PrefixedName
    /// <summary>
    ///   <para>algo:Oakley</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:KeyExchangeAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#Oakley">http://securitytoolbox.appspot.com/securityAlgorithms#Oakley</seealso>
    let Oakley = Prefixed_Name(algo, "Oakley") |> PrefixedName
    /// <summary>
    ///   <para>algo:Skipjack</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:SymmetricAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#Skipjack">http://securitytoolbox.appspot.com/securityAlgorithms#Skipjack</seealso>
    let Skipjack = Prefixed_Name(algo, "Skipjack") |> PrefixedName
    /// <summary>
    ///   <para>algo:SynmmetricAlgorithm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#SynmmetricAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#SynmmetricAlgorithm</seealso>
    let SynmmetricAlgorithm = Prefixed_Name(algo, "SynmmetricAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para> An ontology to describe various cryptographic algorithms</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#">http://securitytoolbox.appspot.com/securityAlgorithms#</seealso>
    let _prefix_iri = Prefixed_Name(algo, "") |> PrefixedName
    /// <summary>
    ///   <para>algo:AsymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#AsymmetricAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#AsymmetricAlgorithm</seealso>
    let AsymmetricAlgorithm = Prefixed_Name(algo, "AsymmetricAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:ChecksumAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#ChecksumAlgorithm">http://securitytoolbox.appspot.com/securityAlgorithms#ChecksumAlgorithm</seealso>
    let ChecksumAlgorithm = Prefixed_Name(algo, "ChecksumAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>algo:ECC</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:AsymmetricAlgorithm</para>
    ///   <para>Elliptic Curve Crypto</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#ECC">http://securitytoolbox.appspot.com/securityAlgorithms#ECC</seealso>
    let ECC = Prefixed_Name(algo, "ECC") |> PrefixedName
    /// <summary>
    ///   <para>algo:MD5</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:HashAlgorithm</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#MD5">http://securitytoolbox.appspot.com/securityAlgorithms#MD5</seealso>
    let MD5 = Prefixed_Name(algo, "MD5") |> PrefixedName
    /// <summary>
    ///   <para>algo:SHA-256</para>
    /// </summary>
    /// <remarks>
    ///   <para>algo:HashAlgorithm</para>
    ///   <para>usually used with AES</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#SHA-256">http://securitytoolbox.appspot.com/securityAlgorithms#SHA-256</seealso>
    let SHA_256 = Prefixed_Name(algo, "SHA-256") |> PrefixedName
    /// <summary>
    ///   <para>algo:modeOfOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Can be CBC, ECB, OFB, CFB, or Counter</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityAlgorithms#modeOfOperation">http://securitytoolbox.appspot.com/securityAlgorithms#modeOfOperation</seealso>
    let modeOfOperation = Prefixed_Name(algo, "modeOfOperation") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cert =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/auth/cert#" "cert"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Certificate</para>
    ///   <para>rdfs:comment : A certificate is a Document that is signed.
    ///     As explained here http://www.pgpi.org/doc/pgpintro/#p16
    ///     'A digital certificate consists of three things:
    ///         * A public key.
    ///         * Certificate information. ('Identity' information about the
    ///           user, such as name, user ID, and so on.)
    ///         * One or more digital signatures.'
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#Certificate">cert:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    let DSAKey = _prefixId.prefix "DSAKey"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : the class of keys</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#Key">cert:Key</a>
    /// </summary>
    let Key = _prefixId.prefix "Key"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : PGPCertificate^^xsd:string</para>
    ///   <para>rdfs:comment : the class of PGP Certificates</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#PGPCertificate">cert:PGPCertificate</a>
    /// </summary>
    let PGPCertificate = _prefixId.prefix "PGPCertificate"
    /// <summary>
    ///   <para>rdfs:label : PrivateKey^^xsd:string</para>
    ///   <para>rdfs:comment : Private Key</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#PrivateKey">cert:PrivateKey</a>
    /// </summary>
    let PrivateKey = _prefixId.prefix "PrivateKey"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : PublicKey^^xsd:string</para>
    ///   <para>rdfs:comment : Public Key^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#PublicKey">cert:PublicKey</a>
    /// </summary>
    let PublicKey = _prefixId.prefix "PublicKey"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : RSA Key</para>
    ///   <para>rdfs:comment :
    ///     The union of the public and private components of an RSAKey.
    ///     Usually those pieces are not kept together
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#RSAKey">cert:RSAKey</a>
    /// </summary>
    let RSAKey = _prefixId.prefix "RSAKey"
    let RSAPrivateKey = _prefixId.prefix "RSAPrivateKey"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : RSA Public Key</para>
    ///   <para>rdfs:comment :
    ///     The RSA public key.  Padded message m are encrypted by applying the function
    ///       modulus(power(m,exponent),modulus)
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#RSAPublicKey">cert:RSAPublicKey</a>
    /// </summary>
    let RSAPublicKey = _prefixId.prefix "RSAPublicKey"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Signature^^xsd:string</para>
    ///   <para>rdfs:comment : the class of signtatures</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#Signature">cert:Signature</a>
    /// </summary>
    let Signature = _prefixId.prefix "Signature"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : X509Certificate^^xsd:string</para>
    ///   <para>rdfs:comment : the class of X509 Certificates</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#X509Certificate">cert:X509Certificate</a>
    /// </summary>
    let X509Certificate = _prefixId.prefix "X509Certificate"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : exponent</para>
    ///   <para>rdfs:comment :
    ///        The exponent used to encrypt the message. Number chosen between
    ///        1 and the totient(p*q). Often named 'e' .
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#exponent">cert:exponent</a>
    /// </summary>
    let exponent = _prefixId.prefix "exponent"
    let hex = _prefixId.prefix "hex"
    /// <summary>
    ///   <para>skos:editorialNote :
    ///          It turns out that this relation is unintuitive to write out and to name.
    ///          One should instead use cert:key
    ///     </para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : identity</para>
    ///   <para>rdfs:comment :
    ///     the identity of the public key. This is the entity that knows the private key and
    ///     so can decrypt messages encrypted with the public key, or encrypt messages that can
    ///     be decrypted with the public key.
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#identity">cert:identity</a>
    /// </summary>
    let identity = _prefixId.prefix "identity"
    /// <summary>
    ///   <para>rdfs:label : key</para>
    ///   <para>rdfs:comment : relates an agent to a key - most often the public key.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/cert#key">cert:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : modulus</para>
    ///   <para>rdfs:comment :
    ///    &lt;p&gt;The modulus of an RSA public and private key.
    ///    Or the modulus of a DSA Key.
    ///    The modulus is encoded as a hex binary. The binary is the same as the one encoded in the
    ///   &lt;a href="http://www.w3.org/TR/xmldsig-core/#sec-CryptoBinary"&gt;XML DSIG CryptoBinary&lt;/a&gt;
    ///   &lt;/p&gt;
    ///   &lt;blockquote&gt;
    ///    This specification defines the ds:CryptoBinary simple type for representing arbitrary-length integers (e.g. "bignums") in XML as octet strings. The integer value is first converted to a "big endian" bitstring. The bitstring is then padded with leading zero bits so that the total number of bits == 0 mod 8 (so that there are an integral number of octets). If the bitstring contains entire leading octets that are zero, these are removed (so the high-order octet is always non-zero).
    ///   &lt;/blockquote&gt;
    ///  &lt;p&gt;The only difference is that the octet string is then encoded using either xsd:base64Binary or xsd:hexBinary. Currently for all usages of this relation, the xsd:hexBinary datatype should be used until the SPARQL working group specifies specifies in its &lt;a href="http://www.w3.org/TR/sparql11-entailment/#DEntRegime"&gt;D-Entailment&lt;/a&gt; that those two types are equivalent.&lt;/p&gt;
    ///  &lt;p&gt;It would have been better had there been a hexInteger datatype that was standard and supported by all tools.&lt;/p&gt;
    ///    </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#modulus">cert:modulus</a>
    /// </summary>
    let modulus = _prefixId.prefix "modulus"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : private</para>
    ///   <para>rdfs:comment :
    ///        The exponent used to decrypt the message
    ///        calculated as
    ///           public_exponent*private_exponent = 1 modulo totient(p*q)
    ///        The private exponent is often named 'd'
    ///     </para>
    ///   <a href="http://www.w3.org/ns/auth/cert#privateExponent">cert:privateExponent</a>
    /// </summary>
    let privateExponent = _prefixId.prefix "privateExponent"

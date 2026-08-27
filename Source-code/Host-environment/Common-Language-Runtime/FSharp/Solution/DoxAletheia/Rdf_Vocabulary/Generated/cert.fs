namespace http.www.w3.org.ns.auth.cert.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cert =
    let _namespace_iri = Namespace_Iri cert |> NamespaceIRI
    /// <summary>
    ///   <para>cert:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"
    ///    Ontology for Certificates and crypto stuff.
    ///    This is in development.
    ///    Some other ontologies to look at:
    ///      * http://www.w3.org/2000/10/swap/crypto
    ///         + has cwm builtins: http://www.w3.org/2000/10/swap/doc/Trust
    ///         - a bit old perhaps. It imports daml+oil
    ///         - would help to be more completely specified
    ///         - uses literals as subjects a little liberally, which makes this a
    ///         bit difficult to work with frameworks that don't permit this
    ///      * http://xmlns.com/wot/0.1/
    ///         - limited very much to PGP (though on can map PGP to X509)
    ///         - a little coarse grained, mixes up the PGP certificate with the PGP
    ///           public key
    ///      *
    ///    Todo:
    ///      - add some classes and relations for DSA
    ///      - should this all be in one file? Or should this be cut up a little? Say one file for the general CERT ontology, and then files for RSA, DSA, PGP, etc... Or perhaps it does not really matter?
    ///      - expand more on the certification side of things
    ///      - verify this by security experts
    ///      - owl2 has some constructs for combined inverse functional properties.
    ///        This may be useful to use in defining an RSA key which is identified
    ///        by two numbers.
    ///      - also create html version of the spec by using this as a template.
    ///      - should comments such as this be in html?
    ///    "</para>
    /// labels<para>"Ontology for Certificates and crypto stuff."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#">http://www.w3.org/ns/auth/cert#</seealso>
    let _prefix_iri = Prefixed_Name(cert, "") |> PrefixedName
    /// <summary>
    ///   <para>cert:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A certificate is a Document that is signed.
    ///     As explained here http://www.pgpi.org/doc/pgpintro/#p16
    ///     'A digital certificate consists of three things:
    ///         * A public key.
    ///         * Certificate information. ('Identity' information about the
    ///           user, such as name, user ID, and so on.)
    ///         * One or more digital signatures.'
    ///     "</para>
    /// labels<para>"Certificate"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#Certificate">http://www.w3.org/ns/auth/cert#Certificate</seealso>
    let Certificate = Prefixed_Name(cert, "Certificate") |> PrefixedName
    /// <summary>
    ///   <para>cert:DSAKey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#DSAKey">http://www.w3.org/ns/auth/cert#DSAKey</seealso>
    let DSAKey = Prefixed_Name(cert, "DSAKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the class of keys"</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#Key">http://www.w3.org/ns/auth/cert#Key</seealso>
    let Key = Prefixed_Name(cert, "Key") |> PrefixedName
    /// <summary>
    ///   <para>cert:PGPCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the class of PGP Certificates"</para>
    /// labels<para>"PGPCertificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#PGPCertificate">http://www.w3.org/ns/auth/cert#PGPCertificate</seealso>
    let PGPCertificate = Prefixed_Name(cert, "PGPCertificate") |> PrefixedName
    /// <summary>
    ///   <para>cert:PrivateKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Private Key"</para>
    /// labels<para>"PrivateKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#PrivateKey">http://www.w3.org/ns/auth/cert#PrivateKey</seealso>
    let PrivateKey = Prefixed_Name(cert, "PrivateKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:PublicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Public Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PublicKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#PublicKey">http://www.w3.org/ns/auth/cert#PublicKey</seealso>
    let PublicKey = Prefixed_Name(cert, "PublicKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:RSAKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The union of the public and private components of an RSAKey.
    ///     Usually those pieces are not kept together
    ///     "</para>
    /// labels<para>"RSA Key"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#RSAKey">http://www.w3.org/ns/auth/cert#RSAKey</seealso>
    let RSAKey = Prefixed_Name(cert, "RSAKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:RSAPrivateKey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#RSAPrivateKey">http://www.w3.org/ns/auth/cert#RSAPrivateKey</seealso>
    let RSAPrivateKey = Prefixed_Name(cert, "RSAPrivateKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:RSAPublicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The RSA public key.  Padded message m are encrypted by applying the function
    ///       modulus(power(m,exponent),modulus)
    ///     "</para>
    /// labels<para>"RSA Public Key"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#RSAPublicKey">http://www.w3.org/ns/auth/cert#RSAPublicKey</seealso>
    let RSAPublicKey = Prefixed_Name(cert, "RSAPublicKey") |> PrefixedName
    /// <summary>
    ///   <para>cert:Signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the class of signtatures"</para>
    /// labels<para>"Signature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#Signature">http://www.w3.org/ns/auth/cert#Signature</seealso>
    let Signature = Prefixed_Name(cert, "Signature") |> PrefixedName
    /// <summary>
    ///   <para>cert:X509Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the class of X509 Certificates"</para>
    /// labels<para>"X509Certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#X509Certificate">http://www.w3.org/ns/auth/cert#X509Certificate</seealso>
    let X509Certificate = Prefixed_Name(cert, "X509Certificate") |> PrefixedName
    /// <summary>
    ///   <para>cert:exponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///        The exponent used to encrypt the message. Number chosen between
    ///        1 and the totient(p*q). Often named 'e' .
    ///     "</para>
    /// labels<para>"exponent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#exponent">http://www.w3.org/ns/auth/cert#exponent</seealso>
    let exponent = Prefixed_Name(cert, "exponent") |> PrefixedName
    /// <summary>
    ///   <para>cert:hex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"&lt;span xmlns="http://www.w3.org/1999/xhtml"&gt;&lt;p&gt;
    ///    An encoding of a positive integer (from 0 to infinity) as a hexadecimal string that makes it easy to read and/or fun to present on the web.&lt;/p&gt;
    ///    &lt;p&gt;The purpose of this way of representing hexadecimals is to enable users to copy and paste hexadecimal notations as shown by most browsers, keychains or tools such as opensso, into their rdf representation of choice.  There are a wide variety of ways in which such strings can be presented. One finds the following:&lt;/p&gt;
    /// &lt;pre&gt;
    ///   e1 dc d5 e1 00 8f 21 5e d5 cc 7c 7e c4 9c ad 86
    ///   64 aa dc 29 f2 8d d9 56 7f 31 b6 bd 1b fd b8 ee
    ///   51 0d 3c 84 59 a2 45 d2 13 59 2a 14 82 1a 0f 6e
    ///   d3 d1 4a 2d a9 4c 7e db 90 07 fc f1 8d a3 8e 38
    ///   25 21 0a 32 c1 95 31 3c ba 56 cc 17 45 87 e1 eb
    ///   fd 9f 0f 82 16 67 9f 67 fa 91 e4 0d 55 4e 52 c0
    ///   66 64 2f fe 98 8f ae f8 96 21 5e ea 38 9e 5c 4f
    ///   27 e2 48 ca ca f2 90 23 ad 99 4b cc 38 32 6d bf
    /// &lt;/pre&gt;
    /// &lt;p&gt;
    ///  Or the same as the above, with ':' instead of spaces. We can't guarantee that these are the only ways such tools will present hexadecimals, so we are very lax.&lt;/p&gt;
    ///  &lt;p&gt;The letters can be uppercase or lowercase, or mixed.  &lt;/p&gt;
    ///  &lt;p&gt;Some strings may start with initial 00's, and can be stripped in this notation as they often are. Doing this could, in complement of 2 notation turn a positive number into a negative one, if the first hexadecimal character happens to be one of  the set {'8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F'} .  As we interpret this string as a hexadecimal number leading 00s are not important  (Complement of 2 notation and hexadecimal overlap for positive numbers)&lt;/p&gt;
    /// &lt;p&gt; In order to make this fun, we allow any unicode characters in the string. A parser should &lt;/p&gt;
    ///   &lt;ol&gt;
    /// &lt;li&gt;remove all non hexadecimal characters&lt;/li&gt;
    /// &lt;li&gt;treat the resulting as a hexadecimal representation of a number&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;p&gt;
    ///  This will allow people to make an ascii - better yet a UTF-8 - picture of their public key when publishing it on the web.
    /// &lt;/p&gt;
    /// &lt;p&gt;
    ///   Cert hex is also a datatype property because we used to write it out like this
    /// &lt;/p&gt;
    ///  &lt;pre&gt;
    ///    [] a rsa:RSAPublicKey;
    ///      rsa:public_exponent [ cert:hex "e1 dc d5 ..."]
    ///  &lt;/pre&gt;
    /// &lt;p&gt; The above notation is now deprecated. Now we prefer the literal format below.&lt;/p&gt;
    ///  &lt;pre&gt;
    ///    [] a rsa:RSAPublicKey;
    ///      rsa:public_exponent "e1 dc d5 ..."^^cert:hex .
    ///  &lt;/pre&gt;
    ///    &lt;/span&gt;
    ///         "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"hexadecimal"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#hex">http://www.w3.org/ns/auth/cert#hex</seealso>
    let hex = Prefixed_Name(cert, "hex") |> PrefixedName
    /// <summary>
    ///   <para>cert:identity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     the identity of the public key. This is the entity that knows the private key and
    ///     so can decrypt messages encrypted with the public key, or encrypt messages that can
    ///     be decrypted with the public key.
    ///     "</para>
    /// labels<para>"identity"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#identity">http://www.w3.org/ns/auth/cert#identity</seealso>
    let identity = Prefixed_Name(cert, "identity") |> PrefixedName
    /// <summary>
    ///   <para>cert:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"relates an agent to a key - most often the public key."</para>
    /// labels<para>"key"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#key">http://www.w3.org/ns/auth/cert#key</seealso>
    let key = Prefixed_Name(cert, "key") |> PrefixedName
    /// <summary>
    ///   <para>cert:modulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
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
    ///    "</para>
    /// labels<para>"modulus"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#modulus">http://www.w3.org/ns/auth/cert#modulus</seealso>
    let modulus = Prefixed_Name(cert, "modulus") |> PrefixedName
    /// <summary>
    ///   <para>cert:privateExponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///        The exponent used to decrypt the message
    ///        calculated as
    ///           public_exponent*private_exponent = 1 modulo totient(p*q)
    ///        The private exponent is often named 'd'
    ///     "</para>
    /// labels<para>"private"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/cert#privateExponent">http://www.w3.org/ns/auth/cert#privateExponent</seealso>
    let privateExponent = Prefixed_Name(cert, "privateExponent") |> PrefixedName

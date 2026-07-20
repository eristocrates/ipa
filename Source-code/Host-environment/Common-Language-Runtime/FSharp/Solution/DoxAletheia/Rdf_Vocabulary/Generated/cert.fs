namespace http.www.w3.org.ns.auth.cert.hash

open DoxAletheia

module cert =
    let _namespace_name = "http://www.w3.org/ns/auth/cert#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A certificate is a Document that is signed.
    ///     As explained here http://www.pgpi.org/doc/pgpintro/#p16
    ///     'A digital certificate consists of three things:
    ///         * A public key.
    ///         * Certificate information. ('Identity' information about the
    ///           user, such as name, user ID, and so on.)
    ///         * One or more digital signatures.'
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#Certificate"></see></summary>
    let Certificate = _prefix "Certificate"
    /// <summary>
    /// the class of keys
    /// <see href="http://www.w3.org/ns/auth/cert#Key"></see></summary>
    let Key = _prefix "Key"
    /// <summary>
    /// the class of PGP Certificates
    /// <see href="http://www.w3.org/ns/auth/cert#PGPCertificate"></see></summary>
    let PGPCertificate = _prefix "PGPCertificate"
    /// <summary>
    /// Private Key
    /// <see href="http://www.w3.org/ns/auth/cert#PrivateKey"></see></summary>
    let PrivateKey = _prefix "PrivateKey"
    /// <summary>
    /// Public Key
    /// <see href="http://www.w3.org/ns/auth/cert#PublicKey"></see></summary>
    let PublicKey = _prefix "PublicKey"
    /// <summary>
    ///
    ///     The union of the public and private components of an RSAKey.
    ///     Usually those pieces are not kept together
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#RSAKey"></see></summary>
    let RSAKey = _prefix "RSAKey"
    /// <summary>
    ///
    ///     The RSA public key.  Padded message m are encrypted by applying the function
    ///       modulus(power(m,exponent),modulus)
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#RSAPublicKey"></see></summary>
    let RSAPublicKey = _prefix "RSAPublicKey"
    /// <summary>
    /// the class of signtatures
    /// <see href="http://www.w3.org/ns/auth/cert#Signature"></see></summary>
    let Signature = _prefix "Signature"
    /// <summary>
    /// the class of X509 Certificates
    /// <see href="http://www.w3.org/ns/auth/cert#X509Certificate"></see></summary>
    let X509Certificate = _prefix "X509Certificate"
    /// <summary>
    ///
    ///        The exponent used to encrypt the message. Number chosen between
    ///        1 and the totient(p*q). Often named 'e' .
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#exponent"></see></summary>
    let exponent = _prefix "exponent"
    /// <summary>
    /// &lt;span xmlns="http://www.w3.org/1999/xhtml"&gt;&lt;p&gt;
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
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#hex"></see></summary>
    let hex = _prefix "hex"
    /// <summary>
    ///
    ///     the identity of the public key. This is the entity that knows the private key and
    ///     so can decrypt messages encrypted with the public key, or encrypt messages that can
    ///     be decrypted with the public key.
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#identity"></see></summary>
    let identity = _prefix "identity"
    /// <summary>
    /// relates an agent to a key - most often the public key.
    /// <see href="http://www.w3.org/ns/auth/cert#key"></see></summary>
    let key = _prefix "key"
    /// <summary>
    ///
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
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#modulus"></see></summary>
    let modulus = _prefix "modulus"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/auth/cert#DSAKey"></see>
    /// </summary>
    let DSAKey = _prefix "DSAKey"
    /// <summary>
    ///
    ///        The exponent used to decrypt the message
    ///        calculated as
    ///           public_exponent*private_exponent = 1 modulo totient(p*q)
    ///        The private exponent is often named 'd'
    ///
    /// <see href="http://www.w3.org/ns/auth/cert#privateExponent"></see></summary>
    let privateExponent = _prefix "privateExponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/auth/cert#RSAPrivateKey"></see>
    /// </summary>
    let RSAPrivateKey = _prefix "RSAPrivateKey"

namespace http.www.w3.org._2000._10.swap.crypto.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module crypto =
    let _namespace_iri = Namespace_Iri crypto |> NamespaceIRI
    /// <summary>
    ///   <para>crypto:CanEncrypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>PublicKeyObjects which are capable of encrypting things</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#CanEncrypt">http://www.w3.org/2000/10/swap/crypto#CanEncrypt</seealso>
    let CanEncrypt = Prefixed_Name(crypto, "CanEncrypt") |> PrefixedName
    /// <summary>
    ///   <para>crypto:CanSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>PublicKeyObjects which are capable of signing things.
    /// True if the algorithm is capable of signing data; false otherwise. To
    /// test if a given key object can sign data, use CanSign and HasPrivate.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#CanSign">http://www.w3.org/2000/10/swap/crypto#CanSign</seealso>
    let CanSign = Prefixed_Name(crypto, "CanSign") |> PrefixedName
    /// <summary>
    ///   <para>crypto:HashFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    /// The crypographic hash functions are (being functions) unique and are,
    /// when secure, assumed unambiguous (the whole point of being hash
    /// functions). That is, when you have the right hash, you have the right
    /// document. Currently (2001/9) only SHA is given that property.
    /// </para>
    /// labels<para>Any crypographic hash function</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#HashFunction">http://www.w3.org/2000/10/swap/crypto#HashFunction</seealso>
    let HashFunction = Prefixed_Name(crypto, "HashFunction") |> PrefixedName
    /// <summary>
    ///   <para>crypto:sha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>The object is a SHA-1 hash of the subject.</para>
    /// labels<para>SHA hash</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#sha">http://www.w3.org/2000/10/swap/crypto#sha</seealso>
    let sha = Prefixed_Name(crypto, "sha") |> PrefixedName
    /// <summary>
    ///   <para>crypto:publicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    ///   <para>The object is a public key object that doesn't
    ///     contain the private key data in the subject.
    ///     This function extracts the public part.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#publicKey">http://www.w3.org/2000/10/swap/crypto#publicKey</seealso>
    let publicKey = Prefixed_Name(crypto, "publicKey") |> PrefixedName
    /// <summary>
    ///   <para>crypto:verifyBoolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If the subject is a list containg a keypair, a hash,
    /// and a signature, then the object is either "1" if the signature
    /// validates or "0" if it does not.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#verifyBoolean">http://www.w3.org/2000/10/swap/crypto#verifyBoolean</seealso>
    let verifyBoolean = Prefixed_Name(crypto, "verifyBoolean") |> PrefixedName
    /// <summary>
    ///   <para>crypto:verify</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If the subject is a key object containing private and
    /// public parts and the obejct is a list of a hash and a signature, then
    /// this is true if and only if the signature is a valid signature of the
    /// hash with the key.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#verify">http://www.w3.org/2000/10/swap/crypto#verify</seealso>
    let verify = Prefixed_Name(crypto, "verify") |> PrefixedName
    /// <summary>
    ///   <para>crypto:PublicKeyObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An object corresponding to a key for some algorithm.
    /// The object can hold a public and optionally a private key.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#PublicKeyObject">http://www.w3.org/2000/10/swap/crypto#PublicKeyObject</seealso>
    let PublicKeyObject = Prefixed_Name(crypto, "PublicKeyObject") |> PrefixedName
    /// <summary>
    ///   <para>crypto:HasPrivate</para>
    /// </summary>
    /// <remarks>
    ///   <para>
    /// Some keys have private parts, some don't.  This is the class of those which do.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#HasPrivate">http://www.w3.org/2000/10/swap/crypto#HasPrivate</seealso>
    let HasPrivate = Prefixed_Name(crypto, "HasPrivate") |> PrefixedName
    /// <summary>
    ///   <para>crypto:md5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The object is a MD5 hash of the subject.</para>
    /// labels<para>MD5 hash</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#md5">http://www.w3.org/2000/10/swap/crypto#md5</seealso>
    let md5 = Prefixed_Name(crypto, "md5") |> PrefixedName
    /// <summary>
    ///   <para>crypto:sign</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject should be a list of two things, a hash
    /// string and a key (containing private and public parts). The object is
    /// calculated as a signature string by signing the hash with the key's
    /// private part.</para>
    /// labels<para>sign</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/crypto#sign">http://www.w3.org/2000/10/swap/crypto#sign</seealso>
    let sign = Prefixed_Name(crypto, "sign") |> PrefixedName

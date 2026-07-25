namespace http.xmlns.com.wot._0._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wot =
    let _namespace_iri = Namespace_Iri wot |> NamespaceIRI
    /// <summary>
    ///   <para>wot:EncryptedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An encrypted document intended for a set of recipients.</para>
    /// labels<para>Encrypted Document</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/EncryptedDocument">http://xmlns.com/wot/0.1/EncryptedDocument</seealso>
    let EncryptedDocument = Prefixed_Name(wot, "EncryptedDocument") |> PrefixedName
    /// <summary>
    ///   <para>wot:Endorsement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An endorsement resource containing a detached ascii signature.</para>
    /// labels<para>Endorsement</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/Endorsement">http://xmlns.com/wot/0.1/Endorsement</seealso>
    let Endorsement = Prefixed_Name(wot, "Endorsement") |> PrefixedName
    /// <summary>
    ///   <para>wot:PubKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class used to represent a PGP/GPG public key for a user (an agent, person, group or organization).</para>
    /// labels<para>Public Key</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/PubKey">http://xmlns.com/wot/0.1/PubKey</seealso>
    let PubKey = Prefixed_Name(wot, "PubKey") |> PrefixedName
    /// <summary>
    ///   <para>wot:assurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking a document to an endorsement resource containing a detached ascii signature.</para>
    /// labels<para>Assurance</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/assurance">http://xmlns.com/wot/0.1/assurance</seealso>
    let assurance = Prefixed_Name(wot, "assurance") |> PrefixedName
    /// <summary>
    ///   <para>wot:fingerprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A public key hex fingerprint string (40 digits, white space insignificant).</para>
    /// labels<para>Fingerprint</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/fingerprint">http://xmlns.com/wot/0.1/fingerprint</seealso>
    let fingerprint = Prefixed_Name(wot, "fingerprint") |> PrefixedName
    /// <summary>
    ///   <para>wot:hex_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A public key hex identifier string (8 digits).</para>
    /// labels<para>Hex identifier</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/hex_id">http://xmlns.com/wot/0.1/hex_id</seealso>
    let hex_id = Prefixed_Name(wot, "hex_id") |> PrefixedName
    /// <summary>
    ///   <para>wot:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numeric string representing the length, in bytes, of a public key.</para>
    /// labels<para>Length</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/length">http://xmlns.com/wot/0.1/length</seealso>
    let length = Prefixed_Name(wot, "length") |> PrefixedName
    /// <summary>
    ///   <para>wot:sigdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of a public key signature event.</para>
    /// labels<para>Signature date</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/sigdate">http://xmlns.com/wot/0.1/sigdate</seealso>
    let sigdate = Prefixed_Name(wot, "sigdate") |> PrefixedName
    /// <summary>
    ///   <para>wot:signed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking a public key to a public key signature event.</para>
    /// labels<para>Signed</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/signed">http://xmlns.com/wot/0.1/signed</seealso>
    let signed = Prefixed_Name(wot, "signed") |> PrefixedName
    /// <summary>
    ///   <para>wot:SigEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event describing the action of a public key being signed by some other public key.</para>
    /// labels<para>Key Signing Event</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/SigEvent">http://xmlns.com/wot/0.1/SigEvent</seealso>
    let SigEvent = Prefixed_Name(wot, "SigEvent") |> PrefixedName
    /// <summary>
    ///   <para>wot:encryptedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking an encrypted document to a recipient.</para>
    /// labels<para>Encrypted to</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/encryptedTo">http://xmlns.com/wot/0.1/encryptedTo</seealso>
    let encryptedTo = Prefixed_Name(wot, "encryptedTo") |> PrefixedName
    /// <summary>
    ///   <para>wot:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to link a PubKey from a User</para>
    /// labels<para>has Key</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/hasKey">http://xmlns.com/wot/0.1/hasKey</seealso>
    let hasKey = Prefixed_Name(wot, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>wot:pubkeyAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location of an ascii version of a public key.</para>
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/pubkeyAddress">http://xmlns.com/wot/0.1/pubkeyAddress</seealso>
    let pubkeyAddress = Prefixed_Name(wot, "pubkeyAddress") |> PrefixedName
    /// <summary>
    ///   <para>wot:signer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A property linking a public key signature event to the public key that was used to sign.</para>
    /// labels<para>Signer</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/signer">http://xmlns.com/wot/0.1/signer</seealso>
    let signer = Prefixed_Name(wot, "signer") |> PrefixedName
    /// <summary>
    ///   <para>wot:sigtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time (of day) of a public key signature event.</para>
    /// labels<para>Signature time</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/sigtime">http://xmlns.com/wot/0.1/sigtime</seealso>
    let sigtime = Prefixed_Name(wot, "sigtime") |> PrefixedName
    /// <summary>
    ///   <para>wot:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/">http://xmlns.com/wot/0.1/</seealso>
    let _prefix_iri = Prefixed_Name(wot, "") |> PrefixedName
    /// <summary>
    ///   <para>wot:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A user (agent, person, group or organization) of a PGP/GPG public key.</para>
    /// labels<para>Key User</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/User">http://xmlns.com/wot/0.1/User</seealso>
    let User = Prefixed_Name(wot, "User") |> PrefixedName
    /// <summary>
    ///   <para>wot:encrypter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking an encrypted document to the public key that was used to encrypt it.</para>
    /// labels<para>Encrypted by</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/encrypter">http://xmlns.com/wot/0.1/encrypter</seealso>
    let encrypter = Prefixed_Name(wot, "encrypter") |> PrefixedName
    /// <summary>
    ///   <para>wot:identity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A property linking a public key to the user of the key.</para>
    /// labels<para>Identity</para></remarks>
    /// <seealso href="http://xmlns.com/wot/0.1/identity">http://xmlns.com/wot/0.1/identity</seealso>
    let identity = Prefixed_Name(wot, "identity") |> PrefixedName

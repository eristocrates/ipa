namespace https.www.w3.org._2019.wot.security.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wotsec =
    let _namespace_iri = Namespace_Iri wotsec |> NamespaceIRI
    /// <summary>
    ///   <para>wotsec:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#">https://www.w3.org/2019/wot/security#</seealso>
    let _prefix_iri = Prefixed_Name(wotsec, "") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:APIKeySecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"API key authentication security configuration identified by the term &lt;code&gt;apikey&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "apikey"&lt;/code&gt;).  This is for the case where the access token is opaque and is not using a standard token format."</para>
    /// labels<para>"APIKeySecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#APIKeySecurityScheme">https://www.w3.org/2019/wot/security#APIKeySecurityScheme</seealso>
    let APIKeySecurityScheme =
        Prefixed_Name(wotsec, "APIKeySecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:BasicSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Basic authentication security configuration identified by the term &lt;code&gt;basic&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "basic"&lt;/code&gt;), using an unencrypted username and password.  This scheme should be used with some other security mechanism providing confidentiality, for example, TLS."</para>
    /// labels<para>"BasicSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#BasicSecurityScheme">https://www.w3.org/2019/wot/security#BasicSecurityScheme</seealso>
    let BasicSecurityScheme =
        Prefixed_Name(wotsec, "BasicSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:BearerSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Bearer token authentication security configuration identified by the term &lt;code&gt;bearer&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "bearer"&lt;/code&gt;).  This scheme is intended for situations where bearer tokens are used independently of OAuth2.  If the &lt;code&gt;oauth2&lt;/code&gt; scheme is specified it is not generally necessary to specify this scheme as well as it is implied.  For &lt;code&gt;format&lt;/code&gt;, the value &lt;code&gt;jwt&lt;/code&gt; indicates conformance with RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with !RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-bearer-format-extensions"&gt;Other formats and algorithms for bearer tokens MAY be specified in vocabulary extensions.&lt;/span&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BearerSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#BearerSecurityScheme">https://www.w3.org/2019/wot/security#BearerSecurityScheme</seealso>
    let BearerSecurityScheme =
        Prefixed_Name(wotsec, "BearerSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:CertSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Certificate-based asymmetric key security configuration conformant with X509V3 identified by the term &lt;code&gt;cert&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "cert"&lt;/code&gt;)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CertSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#CertSecurityScheme">https://www.w3.org/2019/wot/security#CertSecurityScheme</seealso>
    let CertSecurityScheme = Prefixed_Name(wotsec, "CertSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:DigestSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Digest authentication security configuration identified by the term &lt;code&gt;digest&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "digest"&lt;/code&gt;). This scheme is similar to basic authentication but with added features to avoid man-in-the-middle attacks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DigestSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#DigestSecurityScheme">https://www.w3.org/2019/wot/security#DigestSecurityScheme</seealso>
    let DigestSecurityScheme =
        Prefixed_Name(wotsec, "DigestSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:NoSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A security configuration corresponding to identified by the term &lt;code&gt;nosec&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "nosec"&lt;/code&gt;), indicating there is no authentication or other mechanism required to access the resource."</para>
    /// labels<para>"NoSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#NoSecurityScheme">https://www.w3.org/2019/wot/security#NoSecurityScheme</seealso>
    let NoSecurityScheme = Prefixed_Name(wotsec, "NoSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:OAuth2SecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"OAuth2 authentication security configuration for systems conformant with !RFC6749 and !RFC8252, identified by the term &lt;code&gt;oauth2&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "oauth2"&lt;/code&gt;).  &lt;span class="rfc2119-assertion" id="td-security-oauth2-implicit-flow"&gt;For the &lt;code&gt;implicit&lt;/code&gt; flow &lt;code&gt;authorization&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-password-client-flow"&gt;For the &lt;code&gt;password&lt;/code&gt; and &lt;code&gt;client&lt;/code&gt; flows &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-code-flow"&gt;For the &lt;code&gt;code&lt;/code&gt; flow both &lt;code&gt;authorization&lt;/code&gt; and &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  If no &lt;code&gt;scopes&lt;/code&gt; are defined in the &lt;code&gt;SecurityScheme&lt;/code&gt; then they are considered to be empty."</para>
    /// labels<para>"OAuth2SecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#OAuth2SecurityScheme">https://www.w3.org/2019/wot/security#OAuth2SecurityScheme</seealso>
    let OAuth2SecurityScheme =
        Prefixed_Name(wotsec, "OAuth2SecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:PSKSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Pre-shared key authentication security configuration identified by the term &lt;code&gt;psk&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "psk"&lt;/code&gt;)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PSKSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#PSKSecurityScheme">https://www.w3.org/2019/wot/security#PSKSecurityScheme</seealso>
    let PSKSecurityScheme = Prefixed_Name(wotsec, "PSKSecurityScheme") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:PoPSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Proof-of-possession (PoP) token authentication security configuration identified by the term &lt;code&gt;pop&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "pop"&lt;/code&gt;). Here &lt;code&gt;jwt&lt;/code&gt; indicates conformance with !RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with !RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with !RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-pop-format-extensions"&gt;Other formats and algorithms for PoP tokens MAY be specified in vocabulary extensions.&lt;/span&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PoPSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#PoPSecurityScheme">https://www.w3.org/2019/wot/security#PoPSecurityScheme</seealso>
    let PoPSecurityScheme = Prefixed_Name(wotsec, "PoPSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:PublicSecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Raw public key asymmetric key security configuration identified by the term &lt;code&gt;public&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "public"&lt;/code&gt;)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PublicSecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#PublicSecurityScheme">https://www.w3.org/2019/wot/security#PublicSecurityScheme</seealso>
    let PublicSecurityScheme =
        Prefixed_Name(wotsec, "PublicSecurityScheme") |> PrefixedName

    /// <summary>
    ///   <para>wotsec:SecurityScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata describing the configuration of a security mechanism.  &lt;span class="rfc2119-assertion" id="td-security-scheme-name"&gt;The value assigned to the name &lt;code&gt;scheme&lt;/code&gt; MUST be defined within a vocabulary included in the Thing Description, either in the present vocabulary or in a TD context extension."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SecurityScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#SecurityScheme">https://www.w3.org/2019/wot/security#SecurityScheme</seealso>
    let SecurityScheme = Prefixed_Name(wotsec, "SecurityScheme") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:alg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Encoding, encryption, or digest algorithm."</para>
    /// labels<para>"alg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#alg">https://www.w3.org/2019/wot/security#alg</seealso>
    let alg = Prefixed_Name(wotsec, "alg") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:authorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URI of the authorization server."</para>
    /// labels<para>"authorization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#authorization">https://www.w3.org/2019/wot/security#authorization</seealso>
    let authorization = Prefixed_Name(wotsec, "authorization") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:flow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Authorization flow."</para>
    /// labels<para>"flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#flow">https://www.w3.org/2019/wot/security#flow</seealso>
    let flow = Prefixed_Name(wotsec, "flow") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies format of security authentication information."</para>
    /// labels<para>"format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#format">https://www.w3.org/2019/wot/security#format</seealso>
    let format = Prefixed_Name(wotsec, "format") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:identity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier providing information which can be used for selection or confirmation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"identity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#identity">https://www.w3.org/2019/wot/security#identity</seealso>
    let identity = Prefixed_Name(wotsec, "identity") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the location of security authentication information."</para>
    /// labels<para>"in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#in">https://www.w3.org/2019/wot/security#in</seealso>
    let in_ = Prefixed_Name(wotsec, "in") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name for query, header, or cookie parameters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#name">https://www.w3.org/2019/wot/security#name</seealso>
    let name = Prefixed_Name(wotsec, "name") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URI of the proxy server this security configuration provides access to.  If not given, the corresponding security configuration is for the endpoint.  &lt;br/&gt;This feature is at risk."</para>
    /// labels<para>"proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#proxy">https://www.w3.org/2019/wot/security#proxy</seealso>
    let proxy = Prefixed_Name(wotsec, "proxy") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:qop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Quality of protection.  &lt;br/&gt;This feature is at risk."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#qop">https://www.w3.org/2019/wot/security#qop</seealso>
    let qop = Prefixed_Name(wotsec, "qop") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:refresh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URI of the refresh server."</para>
    /// labels<para>"refresh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#refresh">https://www.w3.org/2019/wot/security#refresh</seealso>
    let refresh = Prefixed_Name(wotsec, "refresh") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:scopes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Set of authorization scope identifiers provided as an array.  These are provided in tokens returned by an authorization server and associated with forms in order to identify what resources a client may access and how.  The values associated with a form should be chosen from those defined in an &lt;code&gt;OAuth2SecurityScheme&lt;/code&gt; active on that form.  &lt;br/&gt;This feature is at risk."</para>
    /// labels<para>"scopes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#scopes">https://www.w3.org/2019/wot/security#scopes</seealso>
    let scopes = Prefixed_Name(wotsec, "scopes") |> PrefixedName
    /// <summary>
    ///   <para>wotsec:token</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URI of the token server."</para>
    /// labels<para>"token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/security#token">https://www.w3.org/2019/wot/security#token</seealso>
    let token = Prefixed_Name(wotsec, "token") |> PrefixedName

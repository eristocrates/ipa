#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wotsec =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/security#" "wotsec"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : APIKeySecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : API key authentication security configuration identified by the term &lt;code&gt;apikey&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "apikey"&lt;/code&gt;).  This is for the case where the access token is opaque and is not using a standard token format.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#APIKeySecurityScheme">wotsec:APIKeySecurityScheme</a>
    /// </summary>
    let APIKeySecurityScheme = _prefixId.prefix "APIKeySecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : BasicSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Basic authentication security configuration identified by the term &lt;code&gt;basic&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "basic"&lt;/code&gt;), using an unencrypted username and password.  This scheme should be used with some other security mechanism providing confidentiality, for example, TLS.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#BasicSecurityScheme">wotsec:BasicSecurityScheme</a>
    /// </summary>
    let BasicSecurityScheme = _prefixId.prefix "BasicSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : BearerSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Bearer token authentication security configuration identified by the term &lt;code&gt;bearer&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "bearer"&lt;/code&gt;).  This scheme is intended for situations where bearer tokens are used independently of OAuth2.  If the &lt;code&gt;oauth2&lt;/code&gt; scheme is specified it is not generally necessary to specify this scheme as well as it is implied.  For &lt;code&gt;format&lt;/code&gt;, the value &lt;code&gt;jwt&lt;/code&gt; indicates conformance with RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with !RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-bearer-format-extensions"&gt;Other formats and algorithms for bearer tokens MAY be specified in vocabulary extensions.&lt;/span&gt;^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#BearerSecurityScheme">wotsec:BearerSecurityScheme</a>
    /// </summary>
    let BearerSecurityScheme = _prefixId.prefix "BearerSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : CertSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Certificate-based asymmetric key security configuration conformant with X509V3 identified by the term &lt;code&gt;cert&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "cert"&lt;/code&gt;).^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#CertSecurityScheme">wotsec:CertSecurityScheme</a>
    /// </summary>
    let CertSecurityScheme = _prefixId.prefix "CertSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : DigestSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Digest authentication security configuration identified by the term &lt;code&gt;digest&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "digest"&lt;/code&gt;). This scheme is similar to basic authentication but with added features to avoid man-in-the-middle attacks.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#DigestSecurityScheme">wotsec:DigestSecurityScheme</a>
    /// </summary>
    let DigestSecurityScheme = _prefixId.prefix "DigestSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : NoSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : A security configuration corresponding to identified by the term &lt;code&gt;nosec&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "nosec"&lt;/code&gt;), indicating there is no authentication or other mechanism required to access the resource.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#NoSecurityScheme">wotsec:NoSecurityScheme</a>
    /// </summary>
    let NoSecurityScheme = _prefixId.prefix "NoSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : OAuth2SecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : OAuth2 authentication security configuration for systems conformant with !RFC6749 and !RFC8252, identified by the term &lt;code&gt;oauth2&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "oauth2"&lt;/code&gt;).  &lt;span class="rfc2119-assertion" id="td-security-oauth2-implicit-flow"&gt;For the &lt;code&gt;implicit&lt;/code&gt; flow &lt;code&gt;authorization&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-password-client-flow"&gt;For the &lt;code&gt;password&lt;/code&gt; and &lt;code&gt;client&lt;/code&gt; flows &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-code-flow"&gt;For the &lt;code&gt;code&lt;/code&gt; flow both &lt;code&gt;authorization&lt;/code&gt; and &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  If no &lt;code&gt;scopes&lt;/code&gt; are defined in the &lt;code&gt;SecurityScheme&lt;/code&gt; then they are considered to be empty.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#OAuth2SecurityScheme">wotsec:OAuth2SecurityScheme</a>
    /// </summary>
    let OAuth2SecurityScheme = _prefixId.prefix "OAuth2SecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : PSKSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Pre-shared key authentication security configuration identified by the term &lt;code&gt;psk&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "psk"&lt;/code&gt;).^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#PSKSecurityScheme">wotsec:PSKSecurityScheme</a>
    /// </summary>
    let PSKSecurityScheme = _prefixId.prefix "PSKSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : PoPSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Proof-of-possession (PoP) token authentication security configuration identified by the term &lt;code&gt;pop&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "pop"&lt;/code&gt;). Here &lt;code&gt;jwt&lt;/code&gt; indicates conformance with !RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with !RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with !RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-pop-format-extensions"&gt;Other formats and algorithms for PoP tokens MAY be specified in vocabulary extensions.&lt;/span&gt;^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#PoPSecurityScheme">wotsec:PoPSecurityScheme</a>
    /// </summary>
    let PoPSecurityScheme = _prefixId.prefix "PoPSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : PublicSecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Raw public key asymmetric key security configuration identified by the term &lt;code&gt;public&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "public"&lt;/code&gt;).^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#PublicSecurityScheme">wotsec:PublicSecurityScheme</a>
    /// </summary>
    let PublicSecurityScheme = _prefixId.prefix "PublicSecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : SecurityScheme^^xsd:string</para>
    ///   <para>rdfs:comment : Metadata describing the configuration of a security mechanism.  &lt;span class="rfc2119-assertion" id="td-security-scheme-name"&gt;The value assigned to the name &lt;code&gt;scheme&lt;/code&gt; MUST be defined within a vocabulary included in the Thing Description, either in the present vocabulary or in a TD context extension.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#SecurityScheme">wotsec:SecurityScheme</a>
    /// </summary>
    let SecurityScheme = _prefixId.prefix "SecurityScheme"
    /// <summary>
    ///   <para>rdfs:label : alg^^xsd:string</para>
    ///   <para>rdfs:comment : Encoding, encryption, or digest algorithm.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#alg">wotsec:alg</a>
    /// </summary>
    let alg = _prefixId.prefix "alg"
    /// <summary>
    ///   <para>rdfs:label : authorization^^xsd:string</para>
    ///   <para>rdfs:comment : URI of the authorization server.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#authorization">wotsec:authorization</a>
    /// </summary>
    let authorization = _prefixId.prefix "authorization"
    /// <summary>
    ///   <para>rdfs:label : flow^^xsd:string</para>
    ///   <para>rdfs:comment : Authorization flow.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#flow">wotsec:flow</a>
    /// </summary>
    let flow = _prefixId.prefix "flow"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies format of security authentication information.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#format">wotsec:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : identity^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier providing information which can be used for selection or confirmation.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#identity">wotsec:identity</a>
    /// </summary>
    let identity = _prefixId.prefix "identity"
    /// <summary>
    ///   <para>rdfs:label : in^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the location of security authentication information.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#in">wotsec:in</a>
    /// </summary>
    let in_ = _prefixId.prefix "in"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : Name for query, header, or cookie parameters.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#name">wotsec:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : proxy^^xsd:string</para>
    ///   <para>rdfs:comment : URI of the proxy server this security configuration provides access to.  If not given, the corresponding security configuration is for the endpoint.  &lt;br/&gt;This feature is at risk.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#proxy">wotsec:proxy</a>
    /// </summary>
    let proxy = _prefixId.prefix "proxy"
    /// <summary>
    ///   <para>rdfs:label : qop^^xsd:string</para>
    ///   <para>rdfs:comment : Quality of protection.  &lt;br/&gt;This feature is at risk.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/security#qop">wotsec:qop</a>
    /// </summary>
    let qop = _prefixId.prefix "qop"
    /// <summary>
    ///   <para>rdfs:label : refresh^^xsd:string</para>
    ///   <para>rdfs:comment : URI of the refresh server.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#refresh">wotsec:refresh</a>
    /// </summary>
    let refresh = _prefixId.prefix "refresh"
    /// <summary>
    ///   <para>rdfs:label : scopes^^xsd:string</para>
    ///   <para>rdfs:comment : Set of authorization scope identifiers provided as an array.  These are provided in tokens returned by an authorization server and associated with forms in order to identify what resources a client may access and how.  The values associated with a form should be chosen from those defined in an &lt;code&gt;OAuth2SecurityScheme&lt;/code&gt; active on that form.  &lt;br/&gt;This feature is at risk.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#scopes">wotsec:scopes</a>
    /// </summary>
    let scopes = _prefixId.prefix "scopes"
    /// <summary>
    ///   <para>rdfs:label : token^^xsd:string</para>
    ///   <para>rdfs:comment : URI of the token server.</para>
    ///   <a href="https://www.w3.org/2019/wot/security#token">wotsec:token</a>
    /// </summary>
    let token = _prefixId.prefix "token"

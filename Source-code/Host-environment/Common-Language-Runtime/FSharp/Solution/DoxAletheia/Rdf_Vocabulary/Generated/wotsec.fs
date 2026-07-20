namespace https.www.w3.org._2019.wot.security.hash

open DoxAletheia

module wotsec =
    let _namespace_name = "https://www.w3.org/2019/wot/security#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// API key authentication security configuration identified by the term &lt;code&gt;apikey&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "apikey"&lt;/code&gt;).  This is for the case where the access token is opaque and is not using a standard token format.
    /// <see href="https://www.w3.org/2019/wot/security#APIKeySecurityScheme"></see></summary>
    let APIKeySecurityScheme = _prefix "APIKeySecurityScheme"
    /// <summary>
    /// Metadata describing the configuration of a security mechanism.  &lt;span class="rfc2119-assertion" id="td-security-scheme-name"&gt;The value assigned to the name &lt;code&gt;scheme&lt;/code&gt; MUST be defined within a vocabulary included in the Thing Description, either in the present vocabulary or in a TD context extension.
    /// <see href="https://www.w3.org/2019/wot/security#SecurityScheme"></see></summary>
    let SecurityScheme = _prefix "SecurityScheme"
    /// <summary>
    /// Basic authentication security configuration identified by the term &lt;code&gt;basic&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "basic"&lt;/code&gt;), using an unencrypted username and password.  This scheme should be used with some other security mechanism providing confidentiality, for example, TLS.
    /// <see href="https://www.w3.org/2019/wot/security#BasicSecurityScheme"></see></summary>
    let BasicSecurityScheme = _prefix "BasicSecurityScheme"
    /// <summary>
    /// Bearer token authentication security configuration identified by the term &lt;code&gt;bearer&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "bearer"&lt;/code&gt;).  This scheme is intended for situations where bearer tokens are used independently of OAuth2.  If the &lt;code&gt;oauth2&lt;/code&gt; scheme is specified it is not generally necessary to specify this scheme as well as it is implied.  For &lt;code&gt;format&lt;/code&gt;, the value &lt;code&gt;jwt&lt;/code&gt; indicates conformance with RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with !RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-bearer-format-extensions"&gt;Other formats and algorithms for bearer tokens MAY be specified in vocabulary extensions.&lt;/span&gt;
    /// <see href="https://www.w3.org/2019/wot/security#BearerSecurityScheme"></see></summary>
    let BearerSecurityScheme = _prefix "BearerSecurityScheme"
    /// <summary>
    /// Certificate-based asymmetric key security configuration conformant with X509V3 identified by the term &lt;code&gt;cert&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "cert"&lt;/code&gt;).
    /// <see href="https://www.w3.org/2019/wot/security#CertSecurityScheme"></see></summary>
    let CertSecurityScheme = _prefix "CertSecurityScheme"
    /// <summary>
    /// Digest authentication security configuration identified by the term &lt;code&gt;digest&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "digest"&lt;/code&gt;). This scheme is similar to basic authentication but with added features to avoid man-in-the-middle attacks.
    /// <see href="https://www.w3.org/2019/wot/security#DigestSecurityScheme"></see></summary>
    let DigestSecurityScheme = _prefix "DigestSecurityScheme"
    /// <summary>
    /// A security configuration corresponding to identified by the term &lt;code&gt;nosec&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "nosec"&lt;/code&gt;), indicating there is no authentication or other mechanism required to access the resource.
    /// <see href="https://www.w3.org/2019/wot/security#NoSecurityScheme"></see></summary>
    let NoSecurityScheme = _prefix "NoSecurityScheme"
    /// <summary>
    /// OAuth2 authentication security configuration for systems conformant with !RFC6749 and !RFC8252, identified by the term &lt;code&gt;oauth2&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "oauth2"&lt;/code&gt;).  &lt;span class="rfc2119-assertion" id="td-security-oauth2-implicit-flow"&gt;For the &lt;code&gt;implicit&lt;/code&gt; flow &lt;code&gt;authorization&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-password-client-flow"&gt;For the &lt;code&gt;password&lt;/code&gt; and &lt;code&gt;client&lt;/code&gt; flows &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  &lt;span class="rfc2119-assertion" id="td-security-oauth2-code-flow"&gt;For the &lt;code&gt;code&lt;/code&gt; flow both &lt;code&gt;authorization&lt;/code&gt; and &lt;code&gt;token&lt;/code&gt; MUST be included.&lt;/span&gt;  If no &lt;code&gt;scopes&lt;/code&gt; are defined in the &lt;code&gt;SecurityScheme&lt;/code&gt; then they are considered to be empty.
    /// <see href="https://www.w3.org/2019/wot/security#OAuth2SecurityScheme"></see></summary>
    let OAuth2SecurityScheme = _prefix "OAuth2SecurityScheme"
    /// <summary>
    /// Pre-shared key authentication security configuration identified by the term &lt;code&gt;psk&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "psk"&lt;/code&gt;).
    /// <see href="https://www.w3.org/2019/wot/security#PSKSecurityScheme"></see></summary>
    let PSKSecurityScheme = _prefix "PSKSecurityScheme"
    /// <summary>
    /// Proof-of-possession (PoP) token authentication security configuration identified by the term &lt;code&gt;pop&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "pop"&lt;/code&gt;). Here &lt;code&gt;jwt&lt;/code&gt; indicates conformance with !RFC7519, &lt;code&gt;jws&lt;/code&gt; indicates conformance with !RFC7797, &lt;code&gt;cwt&lt;/code&gt; indicates conformance with !RFC8392, and &lt;code&gt;jwe&lt;/code&gt; indicates conformance with RFC7516, with values for &lt;code&gt;alg&lt;/code&gt; interpreted consistently with those standards. &lt;span class="rfc2119-assertion" id="td-security-pop-format-extensions"&gt;Other formats and algorithms for PoP tokens MAY be specified in vocabulary extensions.&lt;/span&gt;
    /// <see href="https://www.w3.org/2019/wot/security#PoPSecurityScheme"></see></summary>
    let PoPSecurityScheme = _prefix "PoPSecurityScheme"
    /// <summary>
    /// Raw public key asymmetric key security configuration identified by the term &lt;code&gt;public&lt;/code&gt; (i.e., &lt;code&gt;"scheme": "public"&lt;/code&gt;).
    /// <see href="https://www.w3.org/2019/wot/security#PublicSecurityScheme"></see></summary>
    let PublicSecurityScheme = _prefix "PublicSecurityScheme"
    /// <summary>
    /// Encoding, encryption, or digest algorithm.
    /// <see href="https://www.w3.org/2019/wot/security#alg"></see></summary>
    let alg = _prefix "alg"
    /// <summary>
    /// URI of the authorization server.
    /// <see href="https://www.w3.org/2019/wot/security#authorization"></see></summary>
    let authorization = _prefix "authorization"
    /// <summary>
    /// Authorization flow.
    /// <see href="https://www.w3.org/2019/wot/security#flow"></see></summary>
    let flow = _prefix "flow"
    /// <summary>
    /// Specifies format of security authentication information.
    /// <see href="https://www.w3.org/2019/wot/security#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Identifier providing information which can be used for selection or confirmation.
    /// <see href="https://www.w3.org/2019/wot/security#identity"></see></summary>
    let identity = _prefix "identity"
    /// <summary>
    /// Specifies the location of security authentication information.
    /// <see href="https://www.w3.org/2019/wot/security#in"></see></summary>
    let in_ = _prefix "in"
    /// <summary>
    /// Name for query, header, or cookie parameters.
    /// <see href="https://www.w3.org/2019/wot/security#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// URI of the proxy server this security configuration provides access to.  If not given, the corresponding security configuration is for the endpoint.  &lt;br/&gt;This feature is at risk.
    /// <see href="https://www.w3.org/2019/wot/security#proxy"></see></summary>
    let proxy = _prefix "proxy"
    /// <summary>
    /// Quality of protection.  &lt;br/&gt;This feature is at risk.
    /// <see href="https://www.w3.org/2019/wot/security#qop"></see></summary>
    let qop = _prefix "qop"
    /// <summary>
    /// URI of the refresh server.
    /// <see href="https://www.w3.org/2019/wot/security#refresh"></see></summary>
    let refresh = _prefix "refresh"
    /// <summary>
    /// Set of authorization scope identifiers provided as an array.  These are provided in tokens returned by an authorization server and associated with forms in order to identify what resources a client may access and how.  The values associated with a form should be chosen from those defined in an &lt;code&gt;OAuth2SecurityScheme&lt;/code&gt; active on that form.  &lt;br/&gt;This feature is at risk.
    /// <see href="https://www.w3.org/2019/wot/security#scopes"></see></summary>
    let scopes = _prefix "scopes"
    /// <summary>
    /// URI of the token server.
    /// <see href="https://www.w3.org/2019/wot/security#token"></see></summary>
    let token = _prefix "token"

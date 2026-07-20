namespace http.purl.org.wai.hash

open DoxAletheia

module wai =
    let _namespace_name = "http://purl.org/wai#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Contexts are similar to situations or state of affairs providing interpretation coordinates for profiles. In the most simple case, these coordinates are just geographical/spatial or temporal coordinates. WAI does not impose a fixed definition of context. It is deliberately wide in order to enable third-parties the adequation of the meaning of context according to their modeling needs and requirements.
    /// <see href="http://purl.org/wai#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// A profile represents a particular person playing a given role. In the literature it is also known as a "qua-individual". WAI extends the meaning of profile to capture "person-as-role", "person-at-context" and "person-in-community".
    /// <see href="http://purl.org/wai#Profile"></see></summary>
    let Profile = _prefix "Profile"
    /// <summary>
    /// A property that can be predicated of a person. In WAI ontology, roles are reified as first order individuals and relations between roles and players are expressed by means of the wai:plays property. WAI does not impose any subclassification of roles. The concept is open to be refined according to domain or application requirements.
    /// <see href="http://purl.org/wai#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// This property enables to relate a profile with a given context (geographical, temporal, spatial, social, etc.).
    /// <see href="http://purl.org/wai#atContext"></see></summary>
    let atContext = _prefix "atContext"
    /// <summary>
    /// This property allows to specify which is the user profile that is active,
    /// given a interaction between two applications.
    /// <see href="http://purl.org/wai#isActive"></see></summary>
    let isActive = _prefix "isActive"
    /// <summary>
    /// This property encodes the participation relation between profiles and the communities they are member of.
    /// <see href="http://purl.org/wai#participates"></see></summary>
    let participates = _prefix "participates"
    /// <summary>
    /// A role is personalized by means of a profile, which wrap the role in the identity of the person behind the profile.
    /// <see href="http://purl.org/wai#personalizes"></see></summary>
    let personalizes = _prefix "personalizes"
    /// <summary>
    /// This property relates roles and their players, who can be any foaf:Agent (a person, a group, etc.)
    /// <see href="http://purl.org/wai#plays"></see></summary>
    let plays = _prefix "plays"
    /// <summary>
    /// This property allows to express hierarchies of roles, through of role specialization: if role A specializes role B, and B specializes C, then role A specializes role C.
    /// <see href="http://purl.org/wai#specializes"></see></summary>
    let specializes = _prefix "specializes"
    /// <summary>
    /// This property relates roles and their requisites, i.e. other roles.
    /// <see href="http://purl.org/wai#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// This property relates people and the featured profiles.
    /// <see href="http://purl.org/wai#profiles"></see></summary>
    let profiles = _prefix "profiles"

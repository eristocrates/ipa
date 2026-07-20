namespace http.purl.org.openorg.slash

open DoxAletheia

module oo =
    let _namespace_name = "http://purl.org/openorg/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A capability of a facility or organization. This is subtley different from a service, in that it means that it is capable of performing a certain task or technique. It may be useful to list capabilities when bidding for research contracts and grants.
    /// <see href="http://purl.org/openorg/Capability"></see></summary>
    let Capability = _prefix "Capability"
    /// <summary>
    /// An item of equipment. This term is in testing and may be superceeded by the Cerif vocab.
    /// <see href="http://purl.org/openorg/Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    /// A facility. A facility is a grouping of equipment and/or people that can perform specific tasks. This term has been coined to use in relation to research facilites at universities, but is not restricted to only research facilities. This term is in testing and may be superceeded by the Cerif vocab.
    /// <see href="http://purl.org/openorg/Facility"></see></summary>
    let Facility = _prefix "Facility"
    /// <summary>
    /// This term is intended to be a target for dcterms:license to specifically indicate that a license has not been defined for a resource.
    /// <see href="http://purl.org/openorg/NoLicenseDefined"></see></summary>
    let NoLicenseDefined = _prefix "NoLicenseDefined"
    /// <summary>
    /// An RDF document describing a specific organisation.
    /// <see href="http://purl.org/openorg/OrganizationProfileDocument"></see></summary>
    let OrganizationProfileDocument = _prefix "OrganizationProfileDocument"
    /// <summary>
    /// A service. This term has been defined for the purposes of defining services offered by university research facilities, but isn't restricted to universities or research. This term is in testing and may be superceeded by the Cerif vocab.
    /// <see href="http://purl.org/openorg/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// This relates a place (geo:SpatialThing) with a text description of how to access this thing. It may be that there is limited wheel chair access, a certain entrance is required or any other access information to tell a person planning to visit this place.
    /// <see href="http://purl.org/openorg/access"></see></summary>
    let access = _prefix "access"
    /// <summary>
    /// This is used to indicate the capacity of a thing when performing its default function. Ideally a more semantically meaningful predicate should be used, describing the capacity of something in a particular function.
    ///
    /// This may be used to associate:
    ///
    ///     a classroom, theatre, cinema or resturant with the number of people it seats
    ///     a bar or other entertainment venue with the fire limit for the venue
    ///     a school with how many students it can teach
    ///     a pencil case with how many pencils it can hold.
    ///
    /// You should be able to assume that resources of the same type, described in the same dataset, have capacities calculated in a more-or-less similar way.
    ///
    /// It should only be treated as a rough guide.
    /// <see href="http://purl.org/openorg/capacity"></see></summary>
    let capacity = _prefix "capacity"
    /// <summary>
    /// A mechanism of contacting someone who knows about this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI.
    /// <see href="http://purl.org/openorg/contact"></see></summary>
    let contact = _prefix "contact"
    /// <summary>
    /// a link from an agent to an HTML page or form that can be used to contact that agent. If a fragment identifier is used, it should refer to an @id of an HTML FORM element in the linked page.
    /// <see href="http://purl.org/openorg/contactForm"></see></summary>
    let contactForm = _prefix "contactForm"
    /// <summary>
    /// A sub-property of oo:contact indicating a route to have corrections made to data relating to this resource. Intended for use on a dataset, but it may be used on any URI -- for example you may use it to indicate that certain records in a dataset have different people to contact them to get it fixed.
    /// <see href="http://purl.org/openorg/corrections"></see></summary>
    let corrections = _prefix "corrections"
    /// <summary>
    /// Relates something to a Formal Organiation.
    /// <see href="http://purl.org/openorg/formalOrganization"></see></summary>
    let formalOrganization = _prefix "formalOrganization"
    /// <summary>
    /// link a geospatial feature to a an icon to use to indicate its location. The "point" should be the bottom center of the image.
    /// <see href="http://purl.org/openorg/mapIcon"></see></summary>
    let mapIcon = _prefix "mapIcon"
    /// <summary>
    /// Relates something to an organization. Intended for use to link things other than people and organizations to an organization, for example, equipment, key datasets (places, members).
    /// <see href="http://purl.org/openorg/organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    /// Relates something to a part of an organization.
    /// <see href="http://purl.org/openorg/organizationalUnit"></see></summary>
    let organizationalUnit = _prefix "organizationalUnit"
    /// <summary>
    /// A mechanism of contacting the primary person or group regarding this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI. This is not set as a function property as you may have edge cases where you want to list a primaryContact tel: and mailto: although this isn't recommended.
    /// <see href="http://purl.org/openorg/primaryContact"></see></summary>
    let primaryContact = _prefix "primaryContact"
    /// <summary>
    /// This relates an organization to a SPARQL endpoint which allows you to query open data about or produced by that organization.
    /// <see href="http://purl.org/openorg/sparql"></see></summary>
    let sparql = _prefix "sparql"
    /// <summary>
    /// This is used to relate a concept to the Twitter hashtag people are using to talk about that thing.
    ///
    /// We've created the twitterHashtag in the open org namespace. A hashtag can be related to a concept, location, event, or anything. A combination of hashtags may be used in one literal to indicate that it is that combination of hashtags which is associated with that resource.
    ///
    /// Having two oo:twitterHashtag properties, however, would indicate that either is used to refer to the same thing (not recommended).
    ///
    /// &lt;oo:twitterHashtag&gt;#myconf2010&lt;oo:twitterHashtag&gt;
    ///
    /// or, to indicate a combo hashtag:
    ///
    /// &lt;oo:twitterHashtag&gt;#myconf2010 #track2&lt;oo:twitterHashtag&gt;
    ///
    /// Instead of a string literal this may also point to a URI used to identify the hashtag.
    /// <see href="http://purl.org/openorg/twitterHashtag"></see></summary>
    let twitterHashtag = _prefix "twitterHashtag"

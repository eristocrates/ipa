#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/openorg/" "oo"
    /// <summary>
    ///   <para>rdfs:comment : A capability of a facility or organization. This is subtley different from a service, in that it means that it is capable of performing a certain task or technique. It may be useful to list capabilities when bidding for research contracts and grants.^^xsd:string</para>
    ///   <para>rdfs:label : Capability^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/Capability">oo:Capability</a>
    /// </summary>
    let Capability = _prefixId.prefix "Capability"
    /// <summary>
    ///   <para>rdfs:comment : An item of equipment. This term is in testing and may be superceeded by the Cerif vocab.^^xsd:string</para>
    ///   <para>rdfs:label : Equipment^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/Equipment">oo:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:comment : A facility. A facility is a grouping of equipment and/or people that can perform specific tasks. This term has been coined to use in relation to research facilites at universities, but is not restricted to only research facilities. This term is in testing and may be superceeded by the Cerif vocab.^^xsd:string</para>
    ///   <para>rdfs:label : Facility^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/Facility">oo:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    let NoLicenseDefined = _prefixId.prefix "NoLicenseDefined"
    /// <summary>
    ///   <para>rdfs:comment : An RDF document describing a specific organisation.^^xsd:string</para>
    ///   <para>rdfs:label : Organization Profile Document^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/OrganizationProfileDocument">oo:OrganizationProfileDocument</a>
    /// </summary>
    let OrganizationProfileDocument = _prefixId.prefix "OrganizationProfileDocument"
    /// <summary>
    ///   <para>rdfs:comment : A service. This term has been defined for the purposes of defining services offered by university research facilities, but isn't restricted to universities or research. This term is in testing and may be superceeded by the Cerif vocab.^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/Service">oo:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : This relates a place (geo:SpatialThing) with a text description of how to access this thing. It may be that there is limited wheel chair access, a certain entrance is required or any other access information to tell a person planning to visit this place.^^xsd:string</para>
    ///   <para>rdfs:label : access information^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/access">oo:access</a>
    /// </summary>
    let access = _prefixId.prefix "access"
    /// <summary>
    ///   <para>rdfs:comment : This is used to indicate the capacity of a thing when performing its default function. Ideally a more semantically meaningful predicate should be used, describing the capacity of something in a particular function.
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
    /// It should only be treated as a rough guide.^^xsd:string</para>
    ///   <para>rdfs:label : capacity^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/capacity">oo:capacity</a>
    /// </summary>
    let capacity = _prefixId.prefix "capacity"
    /// <summary>
    ///   <para>rdfs:comment : A mechanism of contacting someone who knows about this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI.^^xsd:string</para>
    ///   <para>rdfs:label : Contact^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/contact">oo:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:comment : a link from an agent to an HTML page or form that can be used to contact that agent. If a fragment identifier is used, it should refer to an @id of an HTML FORM element in the linked page.^^xsd:string</para>
    ///   <para>rdfs:label : contact form^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/contactForm">oo:contactForm</a>
    /// </summary>
    let contactForm = _prefixId.prefix "contactForm"
    /// <summary>
    ///   <para>rdfs:comment : A sub-property of oo:contact indicating a route to have corrections made to data relating to this resource. Intended for use on a dataset, but it may be used on any URI -- for example you may use it to indicate that certain records in a dataset have different people to contact them to get it fixed.^^xsd:string</para>
    ///   <para>rdfs:label : Corrections^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/corrections">oo:corrections</a>
    /// </summary>
    let corrections = _prefixId.prefix "corrections"
    /// <summary>
    ///   <para>rdfs:comment : Relates something to a Formal Organiation.^^xsd:string</para>
    ///   <para>rdfs:label : Formal Organization^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/formalOrganization">oo:formalOrganization</a>
    /// </summary>
    let formalOrganization = _prefixId.prefix "formalOrganization"
    /// <summary>
    ///   <para>rdfs:comment : link a geospatial feature to a an icon to use to indicate its location. The "point" should be the bottom center of the image.^^xsd:string</para>
    ///   <para>rdfs:label : map icon^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/mapIcon">oo:mapIcon</a>
    /// </summary>
    let mapIcon = _prefixId.prefix "mapIcon"
    /// <summary>
    ///   <para>rdfs:comment : Relates something to an organization. Intended for use to link things other than people and organizations to an organization, for example, equipment, key datasets (places, members).^^xsd:string</para>
    ///   <para>rdfs:label : organization^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/organization">oo:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>rdfs:comment : Relates something to a part of an organization.^^xsd:string</para>
    ///   <para>rdfs:label : Organizational Unit^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/organizationalUnit">oo:organizationalUnit</a>
    /// </summary>
    let organizationalUnit = _prefixId.prefix "organizationalUnit"
    /// <summary>
    ///   <para>rdfs:comment : A mechanism of contacting the primary person or group regarding this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI. This is not set as a function property as you may have edge cases where you want to list a primaryContact tel: and mailto: although this isn't recommended.^^xsd:string</para>
    ///   <para>rdfs:label : Primary Contact^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/primaryContact">oo:primaryContact</a>
    /// </summary>
    let primaryContact = _prefixId.prefix "primaryContact"
    /// <summary>
    ///   <para>rdfs:comment : This relates an organization to a SPARQL endpoint which allows you to query open data about or produced by that organization.^^xsd:string</para>
    ///   <para>rdfs:label : SPARQL Endpoint^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/sparql">oo:sparql</a>
    /// </summary>
    let sparql = _prefixId.prefix "sparql"
    /// <summary>
    ///   <para>rdfs:comment : This is used to relate a concept to the Twitter hashtag people are using to talk about that thing.
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
    /// Instead of a string literal this may also point to a URI used to identify the hashtag.^^xsd:string</para>
    ///   <para>rdfs:label : twitter hashtag^^xsd:string</para>
    ///   <a href="http://purl.org/openorg/twitterHashtag">oo:twitterHashtag</a>
    /// </summary>
    let twitterHashtag = _prefixId.prefix "twitterHashtag"

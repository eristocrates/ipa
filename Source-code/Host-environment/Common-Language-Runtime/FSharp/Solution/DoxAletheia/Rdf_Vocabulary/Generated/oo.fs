namespace http.purl.org.openorg.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oo =
    let _namespace_iri = Namespace_Iri oo |> NamespaceIRI
    /// <summary>
    ///   <para>oo:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An item of equipment. This term is in testing and may be superceeded by the Cerif vocab.</para>
    /// labels<para>Equipment</para></remarks>
    /// <seealso href="http://purl.org/openorg/Equipment">http://purl.org/openorg/Equipment</seealso>
    let Equipment = Prefixed_Name(oo, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>oo:access</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This relates a place (geo:SpatialThing) with a text description of how to access this thing. It may be that there is limited wheel chair access, a certain entrance is required or any other access information to tell a person planning to visit this place.</para>
    /// labels<para>access information</para></remarks>
    /// <seealso href="http://purl.org/openorg/access">http://purl.org/openorg/access</seealso>
    let access = Prefixed_Name(oo, "access") |> PrefixedName
    /// <summary>
    ///   <para>oo:capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This is used to indicate the capacity of a thing when performing its default function. Ideally a more semantically meaningful predicate should be used, describing the capacity of something in a particular function.
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
    /// It should only be treated as a rough guide.</para>
    /// labels<para>capacity</para></remarks>
    /// <seealso href="http://purl.org/openorg/capacity">http://purl.org/openorg/capacity</seealso>
    let capacity = Prefixed_Name(oo, "capacity") |> PrefixedName
    /// <summary>
    ///   <para>oo:formalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates something to a Formal Organiation.</para>
    /// labels<para>Formal Organization</para></remarks>
    /// <seealso href="http://purl.org/openorg/formalOrganization">http://purl.org/openorg/formalOrganization</seealso>
    let formalOrganization = Prefixed_Name(oo, "formalOrganization") |> PrefixedName
    /// <summary>
    ///   <para>oo:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A facility. A facility is a grouping of equipment and/or people that can perform specific tasks. This term has been coined to use in relation to research facilites at universities, but is not restricted to only research facilities. This term is in testing and may be superceeded by the Cerif vocab.</para>
    /// labels<para>Facility</para></remarks>
    /// <seealso href="http://purl.org/openorg/Facility">http://purl.org/openorg/Facility</seealso>
    let Facility = Prefixed_Name(oo, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>oo:contactForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a link from an agent to an HTML page or form that can be used to contact that agent. If a fragment identifier is used, it should refer to an @id of an HTML FORM element in the linked page.</para>
    /// labels<para>contact form</para></remarks>
    /// <seealso href="http://purl.org/openorg/contactForm">http://purl.org/openorg/contactForm</seealso>
    let contactForm = Prefixed_Name(oo, "contactForm") |> PrefixedName
    /// <summary>
    ///   <para>oo:mapIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>link a geospatial feature to a an icon to use to indicate its location. The "point" should be the bottom center of the image.</para>
    /// labels<para>map icon</para></remarks>
    /// <seealso href="http://purl.org/openorg/mapIcon">http://purl.org/openorg/mapIcon</seealso>
    let mapIcon = Prefixed_Name(oo, "mapIcon") |> PrefixedName
    /// <summary>
    ///   <para>oo:organizationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates something to a part of an organization.</para>
    /// labels<para>Organizational Unit</para></remarks>
    /// <seealso href="http://purl.org/openorg/organizationalUnit">http://purl.org/openorg/organizationalUnit</seealso>
    let organizationalUnit = Prefixed_Name(oo, "organizationalUnit") |> PrefixedName
    /// <summary>
    ///   <para>oo:primaryContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A mechanism of contacting the primary person or group regarding this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI. This is not set as a function property as you may have edge cases where you want to list a primaryContact tel: and mailto: although this isn't recommended.</para>
    /// labels<para>Primary Contact</para></remarks>
    /// <seealso href="http://purl.org/openorg/primaryContact">http://purl.org/openorg/primaryContact</seealso>
    let primaryContact = Prefixed_Name(oo, "primaryContact") |> PrefixedName
    /// <summary>
    ///   <para>oo:Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A capability of a facility or organization. This is subtley different from a service, in that it means that it is capable of performing a certain task or technique. It may be useful to list capabilities when bidding for research contracts and grants.</para>
    /// labels<para>Capability</para></remarks>
    /// <seealso href="http://purl.org/openorg/Capability">http://purl.org/openorg/Capability</seealso>
    let Capability = Prefixed_Name(oo, "Capability") |> PrefixedName

    /// <summary>
    ///   <para>oo:OrganizationProfileDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An RDF document describing a specific organisation.</para>
    /// labels<para>Organization Profile Document</para></remarks>
    /// <seealso href="http://purl.org/openorg/OrganizationProfileDocument">http://purl.org/openorg/OrganizationProfileDocument</seealso>
    let OrganizationProfileDocument =
        Prefixed_Name(oo, "OrganizationProfileDocument") |> PrefixedName

    /// <summary>
    ///   <para>oo:NoLicenseDefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>This term is intended to be a target for dcterms:license to specifically indicate that a license has not been defined for a resource.</para>
    /// labels<para>No License Defined</para></remarks>
    /// <seealso href="http://purl.org/openorg/NoLicenseDefined">http://purl.org/openorg/NoLicenseDefined</seealso>
    let NoLicenseDefined = Prefixed_Name(oo, "NoLicenseDefined") |> PrefixedName
    /// <summary>
    ///   <para>oo:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A service. This term has been defined for the purposes of defining services offered by university research facilities, but isn't restricted to universities or research. This term is in testing and may be superceeded by the Cerif vocab.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://purl.org/openorg/Service">http://purl.org/openorg/Service</seealso>
    let Service = Prefixed_Name(oo, "Service") |> PrefixedName
    /// <summary>
    ///   <para>oo:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A mechanism of contacting someone who knows about this resource. Suggested targets of this property are a foaf:Agent, a Document (eg. the webpage listing contact methods), a vcard address or a mailto: URI.</para>
    /// labels<para>Contact</para></remarks>
    /// <seealso href="http://purl.org/openorg/contact">http://purl.org/openorg/contact</seealso>
    let contact = Prefixed_Name(oo, "contact") |> PrefixedName
    /// <summary>
    ///   <para>oo:corrections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub-property of oo:contact indicating a route to have corrections made to data relating to this resource. Intended for use on a dataset, but it may be used on any URI -- for example you may use it to indicate that certain records in a dataset have different people to contact them to get it fixed.</para>
    /// labels<para>Corrections</para></remarks>
    /// <seealso href="http://purl.org/openorg/corrections">http://purl.org/openorg/corrections</seealso>
    let corrections = Prefixed_Name(oo, "corrections") |> PrefixedName
    /// <summary>
    ///   <para>oo:sparql</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This relates an organization to a SPARQL endpoint which allows you to query open data about or produced by that organization.</para>
    /// labels<para>SPARQL Endpoint</para></remarks>
    /// <seealso href="http://purl.org/openorg/sparql">http://purl.org/openorg/sparql</seealso>
    let sparql = Prefixed_Name(oo, "sparql") |> PrefixedName
    /// <summary>
    ///   <para>oo:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates something to an organization. Intended for use to link things other than people and organizations to an organization, for example, equipment, key datasets (places, members).</para>
    /// labels<para>organization</para></remarks>
    /// <seealso href="http://purl.org/openorg/organization">http://purl.org/openorg/organization</seealso>
    let organization = Prefixed_Name(oo, "organization") |> PrefixedName
    /// <summary>
    ///   <para>oo:twitterHashtag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This is used to relate a concept to the Twitter hashtag people are using to talk about that thing.
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
    /// Instead of a string literal this may also point to a URI used to identify the hashtag.</para>
    /// labels<para>twitter hashtag</para></remarks>
    /// <seealso href="http://purl.org/openorg/twitterHashtag">http://purl.org/openorg/twitterHashtag</seealso>
    let twitterHashtag = Prefixed_Name(oo, "twitterHashtag") |> PrefixedName

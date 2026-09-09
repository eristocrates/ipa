#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-sfc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/SitesAndFacilities/" "cmns-sfc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : facility^^xsd:string</para>
    ///   <para>skos:definition : something established to serve a particular purpose, make some course of action or operation easier, or provide some capability or service^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A facility may be concrete (as in a manufacturing facility) or abstract. Concrete facilities may be permanent, semi-permanent, or temporary structures, providing one or more capabilities at a given site. A single site may include multiple facilities and a given facility may span multiple sites.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/Facility">cmns-sfc:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>rdfs:label : site^^xsd:string</para>
    ///   <para>skos:definition : place, setting, or context in which something, such as a facility, is situated^^xsd:string</para>
    ///   <para>skos:example : Example facilities that may situated at some site include structures and buildings, an archeological dig, the landing location for an aircraft or spacecraft, and the site of a wound. A given site may accommodate multiple facilities.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A physical site has certain characteristics that contribute to the context it provides, including area, shape, accessibility, and in the case of a geographic site, landforms, soil and ground conditions, climate, and so forth.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/Site">cmns-sfc:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : tract identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier for a parcel issued for use in some jurisdiction^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/TractIdentifier">cmns-sfc:TractIdentifier</a>
    /// </summary>
    let TractIdentifier = _prefixId.prefix "TractIdentifier"
    /// <summary>
    ///   <para>rdfs:label : tract of land</para>
    ///   <para>skos:definition : geographic region that is a contiguous parcel or area of land within a larger region on the surface of the earth, typically defined by its boundaries as described in a deed, survey, or legal document</para>
    ///   <para>cmns-av:explanatoryNote : In some cases, such as in the case of unimproved land that may be owned by a government but without improvements, there may not be an address.cmns-av:explanatoryNote : Such a description typically includes a detailed, quantitative specification for that region specified using a prescribed coordinate and/or mapping system and/or a narrative description, such as 'metes and bounds', which provides a qualitative, but less precise, legal description of the location. The system(s) used to describe the tract are specified in local, regional, and national law.</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/TractOfLand">cmns-sfc:TractOfLand</a>
    /// </summary>
    let TractOfLand = _prefixId.prefix "TractOfLand"
    /// <summary>
    ///   <para>rdfs:label : venue^^xsd:string</para>
    ///   <para>skos:definition : site where something happens, described in the context of an event, activity, or something else that occurs there^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/Venue">cmns-sfc:Venue</a>
    /// </summary>
    let Venue = _prefixId.prefix "Venue"
    /// <summary>
    ///   <para>rdfs:label : enables^^xsd:string</para>
    ///   <para>skos:definition : creates an environment or situation where something can occur or function efficiently^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/enables">cmns-sfc:enables</a>
    /// </summary>
    let enables = _prefixId.prefix "enables"
    /// <summary>
    ///   <para>rdfs:label : is enabled by^^xsd:string</para>
    ///   <para>skos:definition : indicates something that occurs or functions efficiently due to^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/isEnabledBy">cmns-sfc:isEnabledBy</a>
    /// </summary>
    let isEnabledBy = _prefixId.prefix "isEnabledBy"
    /// <summary>
    ///   <para>rdfs:label : is situated at^^xsd:string</para>
    ///   <para>skos:definition : is placed at^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Something may be situated at some site, or in some setting, situation, or context.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/isSituatedAt">cmns-sfc:isSituatedAt</a>
    /// </summary>
    let isSituatedAt = _prefixId.prefix "isSituatedAt"
    /// <summary>
    ///   <para>rdfs:label : situates^^xsd:string</para>
    ///   <para>skos:definition : indicates the place, setting, or context in which something is placed^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/SitesAndFacilities/situates">cmns-sfc:situates</a>
    /// </summary>
    let situates = _prefixId.prefix "situates"

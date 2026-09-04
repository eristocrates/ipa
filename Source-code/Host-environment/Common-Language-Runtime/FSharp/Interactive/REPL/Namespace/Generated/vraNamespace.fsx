#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vra =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://simile.mit.edu/2003/10/ontologies/vraCore3#" "vra"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Corporation</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Corporation">vra:Corporation</a>
    /// </summary>
    let Corporation = _prefixId.prefix "Corporation"
    /// <summary>
    ///   <para>rdfs:comment : Entities are creators e.g. people or organisations^^xsd:string</para>
    ///   <para>rdfs:label : Entity</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Entity">vra:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : An image record is used for the visual surrogates of objects^^xsd:string</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Image">vra:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Larger Entity</para>
    ///   <para>rdfs:comment : A work^^xsd:string</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#LargerEntity">vra:LargerEntity</a>
    /// </summary>
    let LargerEntity = _prefixId.prefix "LargerEntity"
    /// <summary>
    ///   <para>rdfs:label : Record</para>
    ///   <para>rdfs:comment : A record is the superclass for Works and Images^^xsd:string</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Record">vra:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Series</para>
    ///   <para>rdfs:comment : A Series^^xsd:string</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Series">vra:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:label : Work</para>
    ///   <para>rdfs:comment : A work record is used for physical or created objects^^xsd:string</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Work">vra:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : alteration</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#alteration">vra:alteration</a>
    /// </summary>
    let alteration = _prefixId.prefix "alteration"
    /// <summary>
    ///   <para>rdfs:label : attribution</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#attribution">vra:attribution</a>
    /// </summary>
    let attribution = _prefixId.prefix "attribution"
    /// <summary>
    ///   <para>rdfs:label : beginning</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#beginning">vra:beginning</a>
    /// </summary>
    let beginning = _prefixId.prefix "beginning"
    /// <summary>
    ///   <para>rdfs:label : completion</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#completion">vra:completion</a>
    /// </summary>
    let completion = _prefixId.prefix "completion"
    /// <summary>
    ///   <para>rdfs:label : creation</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creation">vra:creation</a>
    /// </summary>
    let creation = _prefixId.prefix "creation"
    /// <summary>
    ///   <para>rdfs:label : creator</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creator">vra:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : culture</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#culture">vra:culture</a>
    /// </summary>
    let culture = _prefixId.prefix "culture"
    /// <summary>
    ///   <para>rdfs:label : date</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#date">vra:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#description">vra:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : design</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#design">vra:design</a>
    /// </summary>
    let design = _prefixId.prefix "design"
    /// <summary>
    ///   <para>rdfs:label : dynasty</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#dynasty">vra:dynasty</a>
    /// </summary>
    let dynasty = _prefixId.prefix "dynasty"
    /// <summary>
    ///   <para>rdfs:label : group</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#group">vra:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : ID</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#id">vra:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : current accession ID</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentAccession">vra:idCurrentAccession</a>
    /// </summary>
    let idCurrentAccession = _prefixId.prefix "idCurrentAccession"
    /// <summary>
    ///   <para>rdfs:label : current repository ID</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentRepository">vra:idCurrentRepository</a>
    /// </summary>
    let idCurrentRepository = _prefixId.prefix "idCurrentRepository"
    /// <summary>
    ///   <para>rdfs:label : former accession ID</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerAccession">vra:idFormerAccession</a>
    /// </summary>
    let idFormerAccession = _prefixId.prefix "idFormerAccession"
    /// <summary>
    ///   <para>rdfs:label : former repository ID</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerRepository">vra:idFormerRepository</a>
    /// </summary>
    let idFormerRepository = _prefixId.prefix "idFormerRepository"
    /// <summary>
    ///   <para>rdfs:label : location</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#location">vra:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : creation site</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCreationSite">vra:locationCreationSite</a>
    /// </summary>
    let locationCreationSite = _prefixId.prefix "locationCreationSite"
    /// <summary>
    ///   <para>rdfs:label : current repository</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentRepository">vra:locationCurrentRepository</a>
    /// </summary>
    let locationCurrentRepository = _prefixId.prefix "locationCurrentRepository"
    /// <summary>
    ///   <para>rdfs:label : current location</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentSite">vra:locationCurrentSite</a>
    /// </summary>
    let locationCurrentSite = _prefixId.prefix "locationCurrentSite"
    /// <summary>
    ///   <para>rdfs:label : discovery site</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationDiscoverySite">vra:locationDiscoverySite</a>
    /// </summary>
    let locationDiscoverySite = _prefixId.prefix "locationDiscoverySite"
    /// <summary>
    ///   <para>rdfs:label : former repository</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerRepository">vra:locationFormerRepository</a>
    /// </summary>
    let locationFormerRepository = _prefixId.prefix "locationFormerRepository"
    /// <summary>
    ///   <para>rdfs:label : former location</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerSite">vra:locationFormerSite</a>
    /// </summary>
    let locationFormerSite = _prefixId.prefix "locationFormerSite"
    /// <summary>
    ///   <para>rdfs:label : material</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#material">vra:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>rdfs:label : measurements</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurements">vra:measurements</a>
    /// </summary>
    let measurements = _prefixId.prefix "measurements"
    /// <summary>
    ///   <para>rdfs:label : dimensions</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsDimensions">vra:measurementsDimensions</a>
    /// </summary>
    let measurementsDimensions = _prefixId.prefix "measurementsDimensions"
    /// <summary>
    ///   <para>rdfs:label : format</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsFormat">vra:measurementsFormat</a>
    /// </summary>
    let measurementsFormat = _prefixId.prefix "measurementsFormat"
    /// <summary>
    ///   <para>rdfs:label : resolution</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsResolution">vra:measurementsResolution</a>
    /// </summary>
    let measurementsResolution = _prefixId.prefix "measurementsResolution"
    /// <summary>
    ///   <para>rdfs:label : medium</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#medium">vra:medium</a>
    /// </summary>
    let medium = _prefixId.prefix "medium"
    /// <summary>
    ///   <para>rdfs:label : movement</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#movement">vra:movement</a>
    /// </summary>
    let movement = _prefixId.prefix "movement"
    /// <summary>
    ///   <para>rdfs:label : period</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#period">vra:period</a>
    /// </summary>
    let period = _prefixId.prefix "period"
    /// <summary>
    ///   <para>rdfs:label : relation</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#relation">vra:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : restoration</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#restoration">vra:restoration</a>
    /// </summary>
    let restoration = _prefixId.prefix "restoration"
    /// <summary>
    ///   <para>rdfs:label : rights</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#rights">vra:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : role</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#role">vra:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:label : school</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#school">vra:school</a>
    /// </summary>
    let school = _prefixId.prefix "school"
    /// <summary>
    ///   <para>rdfs:label : source</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#source">vra:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : style</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#style">vra:style</a>
    /// </summary>
    let style = _prefixId.prefix "style"
    /// <summary>
    ///   <para>rdfs:label : style/period</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#stylePeriod">vra:stylePeriod</a>
    /// </summary>
    let stylePeriod = _prefixId.prefix "stylePeriod"
    /// <summary>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#subject">vra:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : support</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#support">vra:support</a>
    /// </summary>
    let support = _prefixId.prefix "support"
    /// <summary>
    ///   <para>rdfs:label : technique</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#technique">vra:technique</a>
    /// </summary>
    let technique = _prefixId.prefix "technique"
    /// <summary>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#title">vra:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : title translation</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleTranslation">vra:titleTranslation</a>
    /// </summary>
    let titleTranslation = _prefixId.prefix "titleTranslation"
    /// <summary>
    ///   <para>rdfs:label : title variant</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleVariant">vra:titleVariant</a>
    /// </summary>
    let titleVariant = _prefixId.prefix "titleVariant"
    /// <summary>
    ///   <para>rdfs:label : VRA record type</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#type">vra:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : VRA type</para>
    ///   <a href="http://simile.mit.edu/2003/10/ontologies/vraCore3#typeAAT">vra:typeAAT</a>
    /// </summary>
    let typeAAT = _prefixId.prefix "typeAAT"

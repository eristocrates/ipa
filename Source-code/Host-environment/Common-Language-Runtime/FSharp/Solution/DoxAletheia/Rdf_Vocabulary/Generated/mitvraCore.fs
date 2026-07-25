namespace http.simile.mit.edu._2003._10.ontologies.vraCore3.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mitvraCore =
    let _namespace_iri = Namespace_Iri mitvraCore |> NamespaceIRI
    /// <summary>
    ///   <para>mitvraCore:creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>creation</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creation">http://simile.mit.edu/2003/10/ontologies/vraCore3#creation</seealso>
    let creation = Prefixed_Name(mitvraCore, "creation") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>description</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#description">http://simile.mit.edu/2003/10/ontologies/vraCore3#description</seealso>
    let description = Prefixed_Name(mitvraCore, "description") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ID</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#id">http://simile.mit.edu/2003/10/ontologies/vraCore3#id</seealso>
    let id = Prefixed_Name(mitvraCore, "id") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:idFormerAccession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>former accession ID</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerAccession">http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerAccession</seealso>
    let idFormerAccession =
        Prefixed_Name(mitvraCore, "idFormerAccession") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>location</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#location">http://simile.mit.edu/2003/10/ontologies/vraCore3#location</seealso>
    let location = Prefixed_Name(mitvraCore, "location") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationCurrentSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>current location</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentSite">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentSite</seealso>
    let locationCurrentSite =
        Prefixed_Name(mitvraCore, "locationCurrentSite") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:measurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>measurements</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurements">http://simile.mit.edu/2003/10/ontologies/vraCore3#measurements</seealso>
    let measurements = Prefixed_Name(mitvraCore, "measurements") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>medium</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#medium">http://simile.mit.edu/2003/10/ontologies/vraCore3#medium</seealso>
    let medium = Prefixed_Name(mitvraCore, "medium") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Corporation</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Corporation">http://simile.mit.edu/2003/10/ontologies/vraCore3#Corporation</seealso>
    let Corporation = Prefixed_Name(mitvraCore, "Corporation") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Entities are creators e.g. people or organisations</para>
    /// labels<para>Entity</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Entity">http://simile.mit.edu/2003/10/ontologies/vraCore3#Entity</seealso>
    let Entity = Prefixed_Name(mitvraCore, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A record is the superclass for Works and Images</para>
    /// labels<para>Record</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Record">http://simile.mit.edu/2003/10/ontologies/vraCore3#Record</seealso>
    let Record = Prefixed_Name(mitvraCore, "Record") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A work record is used for physical or created objects</para>
    /// labels<para>Work</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Work">http://simile.mit.edu/2003/10/ontologies/vraCore3#Work</seealso>
    let Work = Prefixed_Name(mitvraCore, "Work") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>date</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#date">http://simile.mit.edu/2003/10/ontologies/vraCore3#date</seealso>
    let date = Prefixed_Name(mitvraCore, "date") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:completion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>completion</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#completion">http://simile.mit.edu/2003/10/ontologies/vraCore3#completion</seealso>
    let completion = Prefixed_Name(mitvraCore, "completion") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creator">http://simile.mit.edu/2003/10/ontologies/vraCore3#creator</seealso>
    let creator = Prefixed_Name(mitvraCore, "creator") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>group</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#group">http://simile.mit.edu/2003/10/ontologies/vraCore3#group</seealso>
    let group = Prefixed_Name(mitvraCore, "group") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An image record is used for the visual surrogates of objects</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Image">http://simile.mit.edu/2003/10/ontologies/vraCore3#Image</seealso>
    let Image = Prefixed_Name(mitvraCore, "Image") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:alteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>alteration</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#alteration">http://simile.mit.edu/2003/10/ontologies/vraCore3#alteration</seealso>
    let alteration = Prefixed_Name(mitvraCore, "alteration") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:beginning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>beginning</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#beginning">http://simile.mit.edu/2003/10/ontologies/vraCore3#beginning</seealso>
    let beginning = Prefixed_Name(mitvraCore, "beginning") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:design</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>design</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#design">http://simile.mit.edu/2003/10/ontologies/vraCore3#design</seealso>
    let design = Prefixed_Name(mitvraCore, "design") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:idCurrentRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>current repository ID</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentRepository">http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentRepository</seealso>
    let idCurrentRepository =
        Prefixed_Name(mitvraCore, "idCurrentRepository") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:idFormerRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>former repository ID</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerRepository">http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerRepository</seealso>
    let idFormerRepository =
        Prefixed_Name(mitvraCore, "idFormerRepository") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationCurrentRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>current repository</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentRepository">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentRepository</seealso>
    let locationCurrentRepository =
        Prefixed_Name(mitvraCore, "locationCurrentRepository") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>attribution</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#attribution">http://simile.mit.edu/2003/10/ontologies/vraCore3#attribution</seealso>
    let attribution = Prefixed_Name(mitvraCore, "attribution") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:culture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>culture</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#culture">http://simile.mit.edu/2003/10/ontologies/vraCore3#culture</seealso>
    let culture = Prefixed_Name(mitvraCore, "culture") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:dynasty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>dynasty</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#dynasty">http://simile.mit.edu/2003/10/ontologies/vraCore3#dynasty</seealso>
    let dynasty = Prefixed_Name(mitvraCore, "dynasty") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:idCurrentAccession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>current accession ID</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentAccession">http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentAccession</seealso>
    let idCurrentAccession =
        Prefixed_Name(mitvraCore, "idCurrentAccession") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationCreationSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>creation site</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCreationSite">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCreationSite</seealso>
    let locationCreationSite =
        Prefixed_Name(mitvraCore, "locationCreationSite") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationDiscoverySite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>discovery site</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationDiscoverySite">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationDiscoverySite</seealso>
    let locationDiscoverySite =
        Prefixed_Name(mitvraCore, "locationDiscoverySite") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationFormerRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>former repository</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerRepository">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerRepository</seealso>
    let locationFormerRepository =
        Prefixed_Name(mitvraCore, "locationFormerRepository") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>material</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#material">http://simile.mit.edu/2003/10/ontologies/vraCore3#material</seealso>
    let material = Prefixed_Name(mitvraCore, "material") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:measurementsResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>resolution</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsResolution">http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsResolution</seealso>
    let measurementsResolution =
        Prefixed_Name(mitvraCore, "measurementsResolution") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>period</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#period">http://simile.mit.edu/2003/10/ontologies/vraCore3#period</seealso>
    let period = Prefixed_Name(mitvraCore, "period") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Relation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Relation">http://simile.mit.edu/2003/10/ontologies/vraCore3#Relation</seealso>
    let Relation = Prefixed_Name(mitvraCore, "Relation") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:locationFormerSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>former location</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerSite">http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerSite</seealso>
    let locationFormerSite =
        Prefixed_Name(mitvraCore, "locationFormerSite") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:measurementsDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>dimensions</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsDimensions">http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsDimensions</seealso>
    let measurementsDimensions =
        Prefixed_Name(mitvraCore, "measurementsDimensions") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:measurementsFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>format</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsFormat">http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsFormat</seealso>
    let measurementsFormat =
        Prefixed_Name(mitvraCore, "measurementsFormat") |> PrefixedName

    /// <summary>
    ///   <para>mitvraCore:movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>movement</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#movement">http://simile.mit.edu/2003/10/ontologies/vraCore3#movement</seealso>
    let movement = Prefixed_Name(mitvraCore, "movement") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>relation</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#relation">http://simile.mit.edu/2003/10/ontologies/vraCore3#relation</seealso>
    let relation = Prefixed_Name(mitvraCore, "relation") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>rights</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#rights">http://simile.mit.edu/2003/10/ontologies/vraCore3#rights</seealso>
    let rights = Prefixed_Name(mitvraCore, "rights") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:school</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>school</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#school">http://simile.mit.edu/2003/10/ontologies/vraCore3#school</seealso>
    let school = Prefixed_Name(mitvraCore, "school") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#subject">http://simile.mit.edu/2003/10/ontologies/vraCore3#subject</seealso>
    let subject = Prefixed_Name(mitvraCore, "subject") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:support</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>support</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#support">http://simile.mit.edu/2003/10/ontologies/vraCore3#support</seealso>
    let support = Prefixed_Name(mitvraCore, "support") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>title</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#title">http://simile.mit.edu/2003/10/ontologies/vraCore3#title</seealso>
    let title = Prefixed_Name(mitvraCore, "title") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:titleVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>title variant</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleVariant">http://simile.mit.edu/2003/10/ontologies/vraCore3#titleVariant</seealso>
    let titleVariant = Prefixed_Name(mitvraCore, "titleVariant") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:stylePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>style/period</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#stylePeriod">http://simile.mit.edu/2003/10/ontologies/vraCore3#stylePeriod</seealso>
    let stylePeriod = Prefixed_Name(mitvraCore, "stylePeriod") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:restoration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>restoration</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#restoration">http://simile.mit.edu/2003/10/ontologies/vraCore3#restoration</seealso>
    let restoration = Prefixed_Name(mitvraCore, "restoration") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>source</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#source">http://simile.mit.edu/2003/10/ontologies/vraCore3#source</seealso>
    let source = Prefixed_Name(mitvraCore, "source") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#role">http://simile.mit.edu/2003/10/ontologies/vraCore3#role</seealso>
    let role = Prefixed_Name(mitvraCore, "role") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:style</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>style</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#style">http://simile.mit.edu/2003/10/ontologies/vraCore3#style</seealso>
    let style = Prefixed_Name(mitvraCore, "style") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>technique</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#technique">http://simile.mit.edu/2003/10/ontologies/vraCore3#technique</seealso>
    let technique = Prefixed_Name(mitvraCore, "technique") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>VRA record type</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#type">http://simile.mit.edu/2003/10/ontologies/vraCore3#type</seealso>
    let type_ = Prefixed_Name(mitvraCore, "type") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:titleTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>title translation</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleTranslation">http://simile.mit.edu/2003/10/ontologies/vraCore3#titleTranslation</seealso>
    let titleTranslation = Prefixed_Name(mitvraCore, "titleTranslation") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:typeAAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>VRA type</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#typeAAT">http://simile.mit.edu/2003/10/ontologies/vraCore3#typeAAT</seealso>
    let typeAAT = Prefixed_Name(mitvraCore, "typeAAT") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#">http://simile.mit.edu/2003/10/ontologies/vraCore3#</seealso>
    let _prefix_iri = Prefixed_Name(mitvraCore, "") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:LargerEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A work</para>
    /// labels<para>Larger Entity</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#LargerEntity">http://simile.mit.edu/2003/10/ontologies/vraCore3#LargerEntity</seealso>
    let LargerEntity = Prefixed_Name(mitvraCore, "LargerEntity") |> PrefixedName
    /// <summary>
    ///   <para>mitvraCore:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Series</para>
    /// labels<para>Series</para></remarks>
    /// <seealso href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Series">http://simile.mit.edu/2003/10/ontologies/vraCore3#Series</seealso>
    let Series = Prefixed_Name(mitvraCore, "Series") |> PrefixedName

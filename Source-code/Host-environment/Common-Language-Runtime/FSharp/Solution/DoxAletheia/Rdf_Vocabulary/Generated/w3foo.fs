namespace https.w3id.org.def.foo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3foo =
    let _namespace_iri = Namespace_Iri w3foo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:def/foo#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#">https://w3id.org/def/foo#</seealso>
    let _prefix_iri = Prefixed_Name(w3foo, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Abaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Abaw"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Abaw">https://w3id.org/def/foo#Abaw</seealso>
    let Abaw = Prefixed_Name(w3foo, "Abaw") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Altitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Altitude">https://w3id.org/def/foo#Altitude</seealso>
    let Altitude = Prefixed_Name(w3foo, "Altitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Animalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Animalia"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Animalia">https://w3id.org/def/foo#Animalia</seealso>
    let Animalia = Prefixed_Name(w3foo, "Animalia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Aqeela</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Aqeela"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Aqeela">https://w3id.org/def/foo#Aqeela</seealso>
    let Aqeela = Prefixed_Name(w3foo, "Aqeela") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Bikang1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bikang 1"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Bikang1">https://w3id.org/def/foo#Bikang1</seealso>
    let Bikang1 = Prefixed_Name(w3foo, "Bikang1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Bikang2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Bikang 2"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Bikang2">https://w3id.org/def/foo#Bikang2</seealso>
    let Bikang2 = Prefixed_Name(w3foo, "Bikang2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Binbingan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Binbingan"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Binbingan">https://w3id.org/def/foo#Binbingan</seealso>
    let Binbingan = Prefixed_Name(w3foo, "Binbingan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#CNRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#CNRatio">https://w3id.org/def/foo#CNRatio</seealso>
    let CNRatio = Prefixed_Name(w3foo, "CNRatio") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#CameraTrap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Camera Trap"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#CameraTrap">https://w3id.org/def/foo#CameraTrap</seealso>
    let CameraTrap = Prefixed_Name(w3foo, "CameraTrap") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Carnivora</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Carnivora"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Carnivora">https://w3id.org/def/foo#Carnivora</seealso>
    let Carnivora = Prefixed_Name(w3foo, "Carnivora") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Chordata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Chordata">https://w3id.org/def/foo#Chordata</seealso>
    let Chordata = Prefixed_Name(w3foo, "Chordata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Class">https://w3id.org/def/foo#Class</seealso>
    let Class = Prefixed_Name(w3foo, "Class") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Clay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Clay"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Clay">https://w3id.org/def/foo#Clay</seealso>
    let Clay = Prefixed_Name(w3foo, "Clay") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Count"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Count">https://w3id.org/def/foo#Count</seealso>
    let Count = Prefixed_Name(w3foo, "Count") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Cov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Cov"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Cov">https://w3id.org/def/foo#Cov</seealso>
    let Cov = Prefixed_Name(w3foo, "Cov") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Dara</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Dara"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Dara">https://w3id.org/def/foo#Dara</seealso>
    let Dara = Prefixed_Name(w3foo, "Dara") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Date">https://w3id.org/def/foo#Date</seealso>
    let Date = Prefixed_Name(w3foo, "Date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Direction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Direction">https://w3id.org/def/foo#Direction</seealso>
    let Direction = Prefixed_Name(w3foo, "Direction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Distance"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Distance">https://w3id.org/def/foo#Distance</seealso>
    let Distance = Prefixed_Name(w3foo, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Elephantidae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Elephantidae"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Elephantidae">https://w3id.org/def/foo#Elephantidae</seealso>
    let Elephantidae = Prefixed_Name(w3foo, "Elephantidae") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ElephasMaximus</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Elephantidae</para>
    ///   <para>w3id:def/foo#Animalia</para>
    ///   <para>w3id:def/foo#Mammalia</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Chordata</para>
    ///   <para>w3id:def/foo#Proboscidea</para>
    ///   <para>"Bornean elephants exhibit distinct morphological and behavioural traits compared to mainland Asian elephants, and their genetic uniqueness emphasises their priority for conservation efforts. Although they are considered an evolutionary significant unit requiring tailored conservation measures, their formal recognition as a subspecies awaits further research. Restricted to about 5% of Borneo, primarily in Sabah, Bornean elephants typically form family groups of 5 to 20 individuals, occasionally merging into larger herds of up to 200."</para>
    /// labels<para>"Asian Elephant"</para><para>"Elephas maximus"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#ElephasMaximus">https://w3id.org/def/foo#ElephasMaximus</seealso>
    let ElephasMaximus = Prefixed_Name(w3foo, "ElephasMaximus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Family">https://w3id.org/def/foo#Family</seealso>
    let Family = Prefixed_Name(w3foo, "Family") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Feature of Interest"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#FeatureOfInterest">https://w3id.org/def/foo#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(w3foo, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#GMTDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"GMT Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#GMTDate">https://w3id.org/def/foo#GMTDate</seealso>
    let GMTDate = Prefixed_Name(w3foo, "GMTDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#GMTTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"GMT Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#GMTTime">https://w3id.org/def/foo#GMTTime</seealso>
    let GMTTime = Prefixed_Name(w3foo, "GMTTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#GPSObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Observation</para>
    ///
    /// labels<para>"GPS Observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#GPSObservation">https://w3id.org/def/foo#GPSObservation</seealso>
    let GPSObservation = Prefixed_Name(w3foo, "GPSObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Genus">https://w3id.org/def/foo#Genus</seealso>
    let Genus = Prefixed_Name(w3foo, "Genus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Guli</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Guli"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Guli">https://w3id.org/def/foo#Guli</seealso>
    let Guli = Prefixed_Name(w3foo, "Guli") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#HDOP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"HDOP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#HDOP">https://w3id.org/def/foo#HDOP</seealso>
    let HDOP = Prefixed_Name(w3foo, "HDOP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Horizon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Horizon"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Horizon">https://w3id.org/def/foo#Horizon</seealso>
    let Horizon = Prefixed_Name(w3foo, "Horizon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#ID">https://w3id.org/def/foo#ID</seealso>
    let ID = Prefixed_Name(w3foo, "ID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Identifier">https://w3id.org/def/foo#Identifier</seealso>
    let Identifier = Prefixed_Name(w3foo, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///
    /// labels<para>"Camera Trap Image"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Image">https://w3id.org/def/foo#Image</seealso>
    let Image = Prefixed_Name(w3foo, "Image") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ImageID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#ImageID">https://w3id.org/def/foo#ImageID</seealso>
    let ImageID = Prefixed_Name(w3foo, "ImageID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ImageObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Observation</para>
    ///
    /// labels<para>"Image Observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#ImageObservation">https://w3id.org/def/foo#ImageObservation</seealso>
    let ImageObservation = Prefixed_Name(w3foo, "ImageObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#InorganicP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#InorganicP">https://w3id.org/def/foo#InorganicP</seealso>
    let InorganicP = Prefixed_Name(w3foo, "InorganicP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Ita</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ita"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Ita">https://w3id.org/def/foo#Ita</seealso>
    let Ita = Prefixed_Name(w3foo, "Ita") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Jasmin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Jasmin"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Jasmin">https://w3id.org/def/foo#Jasmin</seealso>
    let Jasmin = Prefixed_Name(w3foo, "Jasmin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Jasper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Jasper"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Jasper">https://w3id.org/def/foo#Jasper</seealso>
    let Jasper = Prefixed_Name(w3foo, "Jasper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Kasih</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Kasih"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Kasih">https://w3id.org/def/foo#Kasih</seealso>
    let Kasih = Prefixed_Name(w3foo, "Kasih") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Kingdom">https://w3id.org/def/foo#Kingdom</seealso>
    let Kingdom = Prefixed_Name(w3foo, "Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Kuma</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kuma"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Kuma">https://w3id.org/def/foo#Kuma</seealso>
    let Kuma = Prefixed_Name(w3foo, "Kuma") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#LandUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Land Use"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#LandUse">https://w3id.org/def/foo#LandUse</seealso>
    let LandUse = Prefixed_Name(w3foo, "LandUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Latitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Latitude">https://w3id.org/def/foo#Latitude</seealso>
    let Latitude = Prefixed_Name(w3foo, "Latitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#LianaDBH_cm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#LianaDBH_cm">https://w3id.org/def/foo#LianaDBH_cm</seealso>
    let LianaDBH_cm = Prefixed_Name(w3foo, "LianaDBH_cm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Lianas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///
    /// labels<para>"Lianas"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Lianas">https://w3id.org/def/foo#Lianas</seealso>
    let Lianas = Prefixed_Name(w3foo, "Lianas") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Liun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Liun"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Liun">https://w3id.org/def/foo#Liun</seealso>
    let Liun = Prefixed_Name(w3foo, "Liun") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#LocalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Local Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#LocalDate">https://w3id.org/def/foo#LocalDate</seealso>
    let LocalDate = Prefixed_Name(w3foo, "LocalDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#LocalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Local Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#LocalTime">https://w3id.org/def/foo#LocalTime</seealso>
    let LocalTime = Prefixed_Name(w3foo, "LocalTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Longitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Longitude">https://w3id.org/def/foo#Longitude</seealso>
    let Longitude = Prefixed_Name(w3foo, "Longitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Make</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Make">https://w3id.org/def/foo#Make</seealso>
    let Make = Prefixed_Name(w3foo, "Make") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/foo#MalayopythonReticulatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///
    /// labels<para>"Malayopython reticulatus"</para><para>"Reticulated Python"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#MalayopythonReticulatus">https://w3id.org/def/foo#MalayopythonReticulatus</seealso>
    let MalayopythonReticulatus =
        Prefixed_Name(w3foo, "MalayopythonReticulatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/foo#Maliau</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Maliau"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Maliau">https://w3id.org/def/foo#Maliau</seealso>
    let Maliau = Prefixed_Name(w3foo, "Maliau") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Mammalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mammalia"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Mammalia">https://w3id.org/def/foo#Mammalia</seealso>
    let Mammalia = Prefixed_Name(w3foo, "Mammalia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ManisJavanica</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Manis Javanica is a species critically threatened by poaching and habitat loss. It is one of eight pangolin species, all of which are considered Vulnerable, Endangered, or Critically Endangered according to the IUCN Red List and listed in CITES Appendix I. The Sunda pangolin, critically endangered and the only species found in Malaysia, inhabits Peninsular Malaysia and Malaysian Borneo, including Sabah and Sarawak. Despite its high protection status in Sabah, where it is (totally protected) under the Wildlife Conservation Enactment 1997, the species faces severe threats from illegal wildlife trade and habitat degradation. In 2019, authorities in Sabah seized over 30 tonnes of pangolin products, highlighting the extensive illicit trade network. The Sunda pangolin occupies various habitats, from primary and secondary forests to wetlands, mangroves, and grasslands."</para>
    /// labels<para>"Manis javanica"</para><para>"Sunda Pangolin"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#ManisJavanica">https://w3id.org/def/foo#ManisJavanica</seealso>
    let ManisJavanica = Prefixed_Name(w3foo, "ManisJavanica") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Merotai</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Merotai"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Merotai">https://w3id.org/def/foo#Merotai</seealso>
    let Merotai = Prefixed_Name(w3foo, "Merotai") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Model">https://w3id.org/def/foo#Model</seealso>
    let Model = Prefixed_Name(w3foo, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Nasalislarvatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///   <para>"Male proboscis monkeys have notably large noses, which are believed to have evolved due to their sexually competitive social system. Significant correlations exist between nose size, body size, testis size, and the number of females in a male's harem. This suggests that both male competition and female choice have driven the evolution of these enlarged noses."</para>
    /// labels<para>"Nasalis larvatus"</para><para>"Proboscis Monkey"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Nasalislarvatus">https://w3id.org/def/foo#Nasalislarvatus</seealso>
    let Nasalislarvatus = Prefixed_Name(w3foo, "Nasalislarvatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#ObservableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Observable Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#ObservableProperty">https://w3id.org/def/foo#ObservableProperty</seealso>
    let ObservableProperty = Prefixed_Name(w3foo, "ObservableProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Observation">https://w3id.org/def/foo#Observation</seealso>
    let Observation = Prefixed_Name(w3foo, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Order">https://w3id.org/def/foo#Order</seealso>
    let Order = Prefixed_Name(w3foo, "Order") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Phylum">https://w3id.org/def/foo#Phylum</seealso>
    let Phylum = Prefixed_Name(w3foo, "Phylum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#PlotName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Plot Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#PlotName">https://w3id.org/def/foo#PlotName</seealso>
    let PlotName = Prefixed_Name(w3foo, "PlotName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#PlotNo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#PlotNo">https://w3id.org/def/foo#PlotNo</seealso>
    let PlotNo = Prefixed_Name(w3foo, "PlotNo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Proboscidea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proboscidea "</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Proboscidea">https://w3id.org/def/foo#Proboscidea</seealso>
    let Proboscidea = Prefixed_Name(w3foo, "Proboscidea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Puteri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Puteri"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Puteri">https://w3id.org/def/foo#Puteri</seealso>
    let Puteri = Prefixed_Name(w3foo, "Puteri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Putut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Putut"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Putut">https://w3id.org/def/foo#Putut</seealso>
    let Putut = Prefixed_Name(w3foo, "Putut") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Reptilia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Reptilia"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Reptilia">https://w3id.org/def/foo#Reptilia</seealso>
    let Reptilia = Prefixed_Name(w3foo, "Reptilia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Sand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Sand">https://w3id.org/def/foo#Sand</seealso>
    let Sand = Prefixed_Name(w3foo, "Sand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Sejati</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sejati"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Sejati">https://w3id.org/def/foo#Sejati</seealso>
    let Sejati = Prefixed_Name(w3foo, "Sejati") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Sensor">https://w3id.org/def/foo#Sensor</seealso>
    let Sensor = Prefixed_Name(w3foo, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Seri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Seri"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Seri">https://w3id.org/def/foo#Seri</seealso>
    let Seri = Prefixed_Name(w3foo, "Seri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Silt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Silt"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Silt">https://w3id.org/def/foo#Silt</seealso>
    let Silt = Prefixed_Name(w3foo, "Silt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Site"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Site">https://w3id.org/def/foo#Site</seealso>
    let Site = Prefixed_Name(w3foo, "Site") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SiteName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#SiteName">https://w3id.org/def/foo#SiteName</seealso>
    let SiteName = Prefixed_Name(w3foo, "SiteName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SitePlotCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#SitePlotCode">https://w3id.org/def/foo#SitePlotCode</seealso>
    let SitePlotCode = Prefixed_Name(w3foo, "SitePlotCode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Soil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#FeatureOfInterest</para>
    ///
    /// labels<para>"Soil"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Soil">https://w3id.org/def/foo#Soil</seealso>
    let Soil = Prefixed_Name(w3foo, "Soil") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SoilObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Observation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Soil Observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#SoilObservation">https://w3id.org/def/foo#SoilObservation</seealso>
    let SoilObservation = Prefixed_Name(w3foo, "SoilObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SoilPH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Soil PH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#SoilPH">https://w3id.org/def/foo#SoilPH</seealso>
    let SoilPH = Prefixed_Name(w3foo, "SoilPH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SoilSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Soil Sensor"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#SoilSensor">https://w3id.org/def/foo#SoilSensor</seealso>
    let SoilSensor = Prefixed_Name(w3foo, "SoilSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Species">https://w3id.org/def/foo#Species</seealso>
    let Species = Prefixed_Name(w3foo, "Species") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Speed">https://w3id.org/def/foo#Speed</seealso>
    let Speed = Prefixed_Name(w3foo, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Squamata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Squamata"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Squamata">https://w3id.org/def/foo#Squamata</seealso>
    let Squamata = Prefixed_Name(w3foo, "Squamata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Subplot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Sub plot"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Subplot">https://w3id.org/def/foo#Subplot</seealso>
    let Subplot = Prefixed_Name(w3foo, "Subplot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#SubplotRadius_m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#SubplotRadius_m">https://w3id.org/def/foo#SubplotRadius_m</seealso>
    let SubplotRadius_m = Prefixed_Name(w3foo, "SubplotRadius_m") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TaxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TaxonRank">https://w3id.org/def/foo#TaxonRank</seealso>
    let TaxonRank = Prefixed_Name(w3foo, "TaxonRank") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Temperature">https://w3id.org/def/foo#Temperature</seealso>
    let Temperature = Prefixed_Name(w3foo, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#Time">https://w3id.org/def/foo#Time</seealso>
    let Time = Prefixed_Name(w3foo, "Time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TotalC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Total C"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#TotalC">https://w3id.org/def/foo#TotalC</seealso>
    let TotalC = Prefixed_Name(w3foo, "TotalC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TotalN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Total N"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#TotalN">https://w3id.org/def/foo#TotalN</seealso>
    let TotalN = Prefixed_Name(w3foo, "TotalN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TotalP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TotalP">https://w3id.org/def/foo#TotalP</seealso>
    let TotalP = Prefixed_Name(w3foo, "TotalP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeDBH_cm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeDBH_cm">https://w3id.org/def/foo#TreeDBH_cm</seealso>
    let TreeDBH_cm = Prefixed_Name(w3foo, "TreeDBH_cm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeHeight_m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeHeight_m">https://w3id.org/def/foo#TreeHeight_m</seealso>
    let TreeHeight_m = Prefixed_Name(w3foo, "TreeHeight_m") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeID">https://w3id.org/def/foo#TreeID</seealso>
    let TreeID = Prefixed_Name(w3foo, "TreeID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeIndividualNo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeIndividualNo">https://w3id.org/def/foo#TreeIndividualNo</seealso>
    let TreeIndividualNo = Prefixed_Name(w3foo, "TreeIndividualNo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeNLianas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeNLianas">https://w3id.org/def/foo#TreeNLianas</seealso>
    let TreeNLianas = Prefixed_Name(w3foo, "TreeNLianas") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeNotes">https://w3id.org/def/foo#TreeNotes</seealso>
    let TreeNotes = Prefixed_Name(w3foo, "TreeNotes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#TreeObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Observation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tree Observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#TreeObservation">https://w3id.org/def/foo#TreeObservation</seealso>
    let TreeObservation = Prefixed_Name(w3foo, "TreeObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Tulid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Tulid"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Tulid">https://w3id.org/def/foo#Tulid</seealso>
    let Tulid = Prefixed_Name(w3foo, "Tulid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Tunglap</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/foo#Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tunglap"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Tunglap">https://w3id.org/def/foo#Tunglap</seealso>
    let Tunglap = Prefixed_Name(w3foo, "Tunglap") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Umas2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:def/foo#Sensor</para>
    ///
    /// labels<para>"Umas2"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Umas2">https://w3id.org/def/foo#Umas2</seealso>
    let Umas2 = Prefixed_Name(w3foo, "Umas2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#V2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/def/foo#V2.0">https://w3id.org/def/foo#V2.0</seealso>
    let ``V2.0`` = Prefixed_Name(w3foo, "V2.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#Viverridae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Viverridae"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#Viverridae">https://w3id.org/def/foo#Viverridae</seealso>
    let Viverridae = Prefixed_Name(w3foo, "Viverridae") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/foo#hasFeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled."</para>
    /// labels<para>"has Feature Of Interest"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#hasFeatureOfInterest">https://w3id.org/def/foo#hasFeatureOfInterest</seealso>
    let hasFeatureOfInterest =
        Prefixed_Name(w3foo, "hasFeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/foo#isFeatureOfInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it."</para>
    /// labels<para>"is feature of interest of"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#isFeatureOfInterestOf">https://w3id.org/def/foo#isFeatureOfInterestOf</seealso>
    let isFeatureOfInterestOf =
        Prefixed_Name(w3foo, "isFeatureOfInterestOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/foo#isObservedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relation between an ObservableProperty and the Sensor able to observe it."</para>
    /// labels<para>"is observed by"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#isObservedBy">https://w3id.org/def/foo#isObservedBy</seealso>
    let isObservedBy = Prefixed_Name(w3foo, "isObservedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#madeBySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relation between an Observation and the Sensor which made the Observation."</para>
    /// labels<para>"made by sensor"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#madeBySensor">https://w3id.org/def/foo#madeBySensor</seealso>
    let madeBySensor = Prefixed_Name(w3foo, "madeBySensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#madeObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Sensor and an Observation made by the Sensor."</para>
    /// labels<para>"made observation"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#madeObservation">https://w3id.org/def/foo#madeObservation</seealso>
    let madeObservation = Prefixed_Name(w3foo, "madeObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation."</para>
    /// labels<para>"observed property"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#observedProperty">https://w3id.org/def/foo#observedProperty</seealso>
    let observedProperty = Prefixed_Name(w3foo, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#observes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relation between a Sensor and an ObservableProperty that it is capable of sensing."</para>
    /// labels<para>"observes"</para></remarks>
    /// <seealso href="https://w3id.org/def/foo#observes">https://w3id.org/def/foo#observes</seealso>
    let observes = Prefixed_Name(w3foo, "observes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/foo#resultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/foo#resultTime">https://w3id.org/def/foo#resultTime</seealso>
    let resultTime = Prefixed_Name(w3foo, "resultTime") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module isbd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/isbd/elements/" "isbd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Resourcerdfs:label : Recurso</para>
    ///   <para>skos:scopeNote : Includes text, music, still and moving images, graphics, maps, sound recordings and video recordings, electronic data or programs, including those issued serially.skos:scopeNote : Incluye texto, música, imágenes fijas y en movimiento, gráficos, mapas, grabaciones sonoras y videograbaciones, programas o datos electrónicos, incluyendo aquellos editados periódicamente.</para>
    ///   <para>skos:definition : Una entidad, tangible o intangible, que tiene contenido artístico y/o intelectual y que está concebida, producida y/o publicada como una unidad, formando la base de una descripción bibliográfica individual.skos:definition : An entity, tangible or intangible, that comprises intellectual and/or artistic content and is conceived, produced and/or issued as a unit, forming the basis of a single bibliographic description.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Resource</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2001">isbd:C2001</a>
    /// </summary>
    let C2001 = _prefixId.prefix "C2001"
    /// <summary>
    ///   <para>rdfs:label : Esquema de codificación de sintaxis ISBDrdfs:label : ISBD Syntax Encoding Scheme</para>
    ///   <para>skos:definition : Esquema de codificación de sintaxis utilizado en la Descripción Bibliográfica Internacional Normalizada (ISBD).skos:definition : Syntax encoding scheme used by International Standard Bibliographic Description (ISBD).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ISBDSyntaxEncodingScheme</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2002">isbd:C2002</a>
    /// </summary>
    let C2002 = _prefixId.prefix "C2002"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the content form and media type area (Area 0).skos:definition : Esquema de codificación utilizado para el área de forma del contenido y de tipo de medio (Área 0).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ContentFormAndMediaTypeAreaEncodingScheme</para>
    ///   <para>rdfs:label : Content Form And Media Type Area Encoding Schemerdfs:label : Esquema de codificación del área de forma del contenido y de tipo de medio</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2003">isbd:C2003</a>
    /// </summary>
    let C2003 = _prefixId.prefix "C2003"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the title and statement of responsibility area (Area 1).skos:definition : Esquema de codificación utilizado para el área de título y mención de responsabilidad (Área 1).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : TitleAndStatementOfResponsibilityAreaEncodingScheme</para>
    ///   <para>rdfs:label : Title And Statement Of Responsibility Area Encoding Schemerdfs:label : Esquema de codificación del área de título y mención de responsabilidad</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2004">isbd:C2004</a>
    /// </summary>
    let C2004 = _prefixId.prefix "C2004"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the edition area (Area 2).skos:definition : Esquema de codificación utilizado para el área de edición (Área 2).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : EditionAreaEncodingScheme</para>
    ///   <para>rdfs:label : Edition Area Encoding Schemerdfs:label : Esquema de codificación del área de edición</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2005">isbd:C2005</a>
    /// </summary>
    let C2005 = _prefixId.prefix "C2005"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the material or type of resource specific area (Area 3).skos:definition : Esquema de codificación utilizado para el área del material o tipo específico de recurso (Área 2).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : MaterialOrTypeOfResourceSpecificAreaEncodingScheme</para>
    ///   <para>rdfs:label : Material Or Type Of Resource Specific Area Encoding Schemerdfs:label : Esquema de codificación del área del material o tipo específico de recurso</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2006">isbd:C2006</a>
    /// </summary>
    let C2006 = _prefixId.prefix "C2006"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the publication, production, distribution, etc. area (Area 4).skos:definition : Esquema de codificación utilizado para el área de publicación, producción, distribución, etc. (Área 4).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : PublicationProductionDistributionEtcAreaEncodingScheme</para>
    ///   <para>rdfs:label : Publication, Production, Distribution, Etc Area Encoding Schemerdfs:label : Esquema de codificación del área de publicación, producción, distribución, etc.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2007">isbd:C2007</a>
    /// </summary>
    let C2007 = _prefixId.prefix "C2007"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the material description area (Area 5).skos:definition : Esquema de codificación utilizado para el área de descripción material (Área 5).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : MaterialDescriptionAreaEncodingScheme</para>
    ///   <para>rdfs:label : Material Description Area Encoding Schemerdfs:label : Esquema de codificación del área de descripción material</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2008">isbd:C2008</a>
    /// </summary>
    let C2008 = _prefixId.prefix "C2008"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the series and multipart monographic resource area (Area 6).skos:definition : Esquema de codificación utilizado para el área de serie y recurso monográfico multiparte (Área 6).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : SeriesAndMultipartMonographicResourceAreaEncodingScheme</para>
    ///   <para>rdfs:label : Series And Multipart Monographic Resource Area Encoding Schemerdfs:label : Esquema de codificación del área de serie y recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2009">isbd:C2009</a>
    /// </summary>
    let C2009 = _prefixId.prefix "C2009"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the note area (Area 7).skos:definition : Esquema de codificación utilizado para el área de notas (Área 7).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NoteAreaEncodingScheme</para>
    ///   <para>rdfs:label : Note Area Encoding Schemerdfs:label : Esquema de codificación del área de notas</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2010">isbd:C2010</a>
    /// </summary>
    let C2010 = _prefixId.prefix "C2010"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the resource identifier and terms of availability area (Area 8).skos:definition : Esquema de codificación utilizado para el área de identificador del recurso y condiciones de disponibilidad (Área 8).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ResourceIdentifierAndTermsOfAvailabilityAreaEncodingScheme</para>
    ///   <para>rdfs:label : Resource Identifier And Terms Of Availability Area Encoding Schemerdfs:label : Esquema de codificación del área de identificador del recurso y condiciones de disponibilidad</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2011">isbd:C2011</a>
    /// </summary>
    let C2011 = _prefixId.prefix "C2011"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the mathematical data area (Area 3 for cartographic resources).skos:definition : Esquema de codificación utilizado para el área de datos matemáticos (Área 3 de recursos cartográficos).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : MathematicalDataAreaEncodingScheme</para>
    ///   <para>rdfs:label : Mathematical Data Area Encoding Schemerdfs:label : Esquema de codificación del área de datos matemáticos</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2012">isbd:C2012</a>
    /// </summary>
    let C2012 = _prefixId.prefix "C2012"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the music format statement area (Area 3 for notated music resources).skos:definition : Esquema de codificación utilizado para el área de mención de formato musical (Área 3 para recursos de música notada).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : MusicFormatStatementAreaEncodingScheme</para>
    ///   <para>rdfs:label : Music Format Statement Area Encoding Schemerdfs:label : Esquema de codificación del área de mención de formato musical </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2013">isbd:C2013</a>
    /// </summary>
    let C2013 = _prefixId.prefix "C2013"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the numbering area (Area 3 for serials).skos:definition : Esquema de codificación utilizado para  el área de numeración (Área 3 de publicaciones periódicas).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NumberingAreaEncodingScheme</para>
    ///   <para>rdfs:label : Numbering Area Encoding Schemerdfs:label : Esquema de codificación del área de numeración</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2014">isbd:C2014</a>
    /// </summary>
    let C2014 = _prefixId.prefix "C2014"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the specific material designation and extent.skos:definition : Esquema de codificación utilizado para la designación específica del material y extensión.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : SpecificMaterialDesignationAndExtentEncodingScheme</para>
    ///   <para>rdfs:label : Specific Material Designation And Extent Encoding Schemerdfs:label : Esquema de codificación de designación específica del material y extensión</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2015">isbd:C2015</a>
    /// </summary>
    let C2015 = _prefixId.prefix "C2015"
    /// <summary>
    ///   <para>skos:definition : Syntax encoding scheme for other physical details.skos:definition : Esquema de codificación utilizada para otros detalles físicos.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : OtherPhysicalDetailsEncodingScheme</para>
    ///   <para>rdfs:label : Other Physical Details Encoding Schemerdfs:label : Esquema de codificación de otros detalles físicos</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2016">isbd:C2016</a>
    /// </summary>
    let C2016 = _prefixId.prefix "C2016"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the statement of coordinates and equinox.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : StatementOfCoordinatesAndEquinoxEncodingScheme</para>
    ///   <para>rdfs:label : Statement Of Coordinates And Equinox Encoding Schemerdfs:label : Esquema de codificación de la mención de coordenadas y equinoccio</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2017">isbd:C2017</a>
    /// </summary>
    let C2017 = _prefixId.prefix "C2017"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the place of publication, production, distribution statement.skos:definition : Esquema de codificación utilizada para la mención de lugar de publicación, producción o distribución.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : PlaceOfPublicationProductionDistributionStatementEncodingScheme</para>
    ///   <para>rdfs:label : Place Of Publication, Production, Distribution Statement Encoding Schemerdfs:label : Esquema de codificación de mención de lugar de publicación, producción o distribución</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2018">isbd:C2018</a>
    /// </summary>
    let C2018 = _prefixId.prefix "C2018"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the name of publisher, producer, distributor statement.skos:definition : Esquema de codificación utilizada para la mención del nombre del editor, productor o distribuidor.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NameOfPublisherProducerDistributorStatementEncodingScheme</para>
    ///   <para>rdfs:label : Name Of Publisher, Producer, Distributor Statement Encoding Schemerdfs:label : Esquema de codificación de mención del nombre del editor, productor o distribuidor</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2019">isbd:C2019</a>
    /// </summary>
    let C2019 = _prefixId.prefix "C2019"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the statement of printing or manufacture.skos:definition : Esquema de codificación utilizado para  la mención de impresión o fabricación.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : StatementOfPrintingOrManufactureEncodingScheme</para>
    ///   <para>rdfs:label : Statement Of Printing Or Manufacture Encoding Schemerdfs:label : Esquema de codificación de mención de impresión o fabricación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2020">isbd:C2020</a>
    /// </summary>
    let C2020 = _prefixId.prefix "C2020"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the compound title of the title proper.skos:definition : Esquema de codificación utilizado para el título compuesto del título propiamente dicho.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CompoundTitleOfTitleProperEncodingScheme</para>
    ///   <para>rdfs:label : Compound Title Of Title Proper Encoding Schemerdfs:label : Esquema de codificación del título compuesto de título propiamente dicho</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2021">isbd:C2021</a>
    /// </summary>
    let C2021 = _prefixId.prefix "C2021"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the title proper (compound) of a series or multipart monographic resource.skos:definition : Esquema de codificación utilizado para el título propiamente dicho (compuesto) de serie o recurso monográfico multiparte.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : TitleProperCompoundOfSeriesOrMultipartMonographicResourceEncodingScheme</para>
    ///   <para>rdfs:label : Title Proper (Compound) Of Series Or Multipart Monographic Resource Encoding Schemerdfs:label : Esquema de codificación del título propiamente dicho (compuesto) de serie</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2022">isbd:C2022</a>
    /// </summary>
    let C2022 = _prefixId.prefix "C2022"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the parallel title (compound) of a series or multipart monograph.skos:definition : Esquema de codificación utilizado para el título paralelo (compuesto) de serie o recurso monográfico multiparte.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ParallelTitleCompoundOfSeriesOrMultipartMonographicResourceEncodingScheme</para>
    ///   <para>rdfs:label : Parallel Title (Compound) Of Series Or Multipart Monographic Resource Encoding Schemerdfs:label : Esquema de codificación del título paralelo (compuesto) de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2024">isbd:C2024</a>
    /// </summary>
    let C2024 = _prefixId.prefix "C2024"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the compound title of the parallel title.skos:definition : Esquema de codificación utilizado para el título compuesto del título paralelo.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CompoundTitleOfParallelTitleEncodingScheme</para>
    ///   <para>rdfs:label : Compound Title Of Parallel Title Encoding Schemerdfs:label : Esquema de codificación del título compuesto de título paralelo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2025">isbd:C2025</a>
    /// </summary>
    let C2025 = _prefixId.prefix "C2025"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the content form and media type statement.skos:definition : Esquema de codificación utilizado para el mención de forma del contenido y de tipo de medio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ContentFormAndMediaTypeStatementEncodingScheme</para>
    ///   <para>rdfs:label : Content Form And Media Type Statement Encoding Schemerdfs:label : Esquema de codificación de mención de forma del contenido y de tipo de medio</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2026">isbd:C2026</a>
    /// </summary>
    let C2026 = _prefixId.prefix "C2026"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the terms of availability statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : TermsOfAvailabilityStatementEncodingScheme</para>
    ///   <para>rdfs:label : Terms Of Availability Statement Encoding Scheme</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2027">isbd:C2027</a>
    /// </summary>
    let C2027 = _prefixId.prefix "C2027"
    /// <summary>
    ///   <para>skos:definition : Syntax Encoding Scheme for the resource identifier statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ResourceIdentifierStatementEncodingScheme</para>
    ///   <para>rdfs:label : Resource Identifier Statement Encoding Scheme</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/C2028">isbd:C2028</a>
    /// </summary>
    let C2028 = _prefixId.prefix "C2028"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a category that reflects the fundamental form or forms in which the content is expressed.skos:definition : Relaciona un recurso con una categoría que refleja la forma o formas fundamentales en que se expresa el contenido.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContentForm</para>
    ///   <para>rdfs:label : has content formrdfs:label : tiene forma del contenido</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1001">isbd:P1001</a>
    /// </summary>
    let P1001 = _prefixId.prefix "P1001"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una subcategoría que amplía una categoría que refleja la forma o formas fundamentales en que se expresa el contenido.skos:definition : Relates a resource to a sub-category that expands a category that reflects the fundamental form or forms in which the content is expressed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContentQualification</para>
    ///   <para>rdfs:label : has content qualificationrdfs:label : tiene aclaración de contenido</para>
    ///   <para>skos:scopeNote : Los calificativos del contenido especifican el tipo, presencia o ausencia de movimiento, dimensión y naturaleza sensorial del recurso que se describe.skos:scopeNote : Content qualifications specify the type, presence or absence of motion, dimensionality and sensory nature for the resource being described.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1002">isbd:P1002</a>
    /// </summary>
    let P1002 = _prefixId.prefix "P1002"
    /// <summary>
    ///   <para>skos:scopeNote : Categories generally reflect the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to render, view, run, etc., the content of a resource.skos:scopeNote : Las categorías reflejan, en general, el formato del medio de almacenamiento y alojamiento de un soporte en combinación con el tipo de dispositivo de intermediación necesario para representar, ver, poner en funcionamiento, etc., el contenido de un recurso.</para>
    ///   <para>rdfs:label : tiene tipo de mediordfs:label : has media type</para>
    ///   <para>skos:definition : Relates a resource to a category that records the type or types of carrier used to convey the content.skos:definition : Relaciona un recurso con una categoría que refleja el tipo o tipos de soportes utilizados para transmitir el contenido.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMediaType</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1003">isbd:P1003</a>
    /// </summary>
    let P1003 = _prefixId.prefix "P1003"
    /// <summary>
    ///   <para>skos:scopeNote : The title proper includes any alternative title, but excludes parallel titles and other title information. In the case of a section or some supplements and some titles of subseries or parts, the title proper can consist of two or more components: the common title (or the title of the main series or of the multipart monographic resource), the dependent title and the dependent title designation. For resources containing several individual works the title proper is the collective title. Resources containing several individual works and lacking a collective title are considered not to have a title proper. A series or subseries also has its own title proper.skos:scopeNote : El título propiamente dicho incluye cualquier título alternativo, pero excluye títulos paralelos e información complementaria del título. En el caso de una sección o algunos suplementos y algunos títulos de subseries o partes, el título propiamente dicho puede consistir en dos o más componentes: el título común (o el título de la serie principal o del recurso monográfico multiparte), el título dependiente y la designación del título dependiente. Para recursos que contienen varias obras individuales, el título propiamente dicho es el título colectivo. Se considera que un recurso no tiene título propiamente dicho cuando contiene varias obras individuales y no existe un título colectivo. Una serie o subserie tiene también su títulopropiamente dicho.</para>
    ///   <para>skos:definition : Relates a resource to the title proper (the chief name of a resource, i.e. the title of a resource in the form in which it appears on the preferred source of information for the resource).skos:definition : Relaciona un recurso con el título propiamente dicho (el nombre principal de un recurso, es decir, el título de un recurso en la forma en la que aparece en la fuente preferida de información para el recurso).</para>
    ///   <para>rdfs:label : tiene título propiamente dichordfs:label : has title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleProper</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1004">isbd:P1004</a>
    /// </summary>
    let P1004 = _prefixId.prefix "P1004"
    /// <summary>
    ///   <para>rdfs:label : has parallel titlerdfs:label : tiene título paralelo</para>
    ///   <para>skos:scopeNote : Un título en otra lengua que se vincula lingüísticamente a otra parte de la descripción no se trata como título paralelo.skos:scopeNote : A title in another language that is linguistically linked to another part of the description is not treated as a parallel title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelTitle</para>
    ///   <para>skos:definition : Relaciona un recurso con un título en otra lengua y/o escritura diferente a la del título propiamente dicho y que se presenta como equivalente del título propiamente dicho en las fuentes preferidas de información.skos:definition : Relates a resource to a title in another language or script than the title proper and presented as an equivalent of the title proper on the preferred source or sources of information.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1005">isbd:P1005</a>
    /// </summary>
    let P1005 = _prefixId.prefix "P1005"
    /// <summary>
    ///   <para>rdfs:label : tiene información complementaria del títulordfs:label : has other title information</para>
    ///   <para>skos:scopeNote : La información complementaria del título puede incluir variantes de título que aparecen en la misma fuente que el título propiamente dicho.skos:scopeNote : Other title information can include variant titles appearing on the same source as the title proper.</para>
    ///   <para>skos:definition : Relates a resource to a word or phrase, or a group of characters, appearing in conjunction with, and subordinate to, the title proper of the resource.skos:definition : Relaciona un recurso con una palabra oexpresión, o grupo de caracteres que aparecen en conjunción con y subordinados al título propiamente dicho del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherTitleInformation</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1006">isbd:P1006</a>
    /// </summary>
    let P1006 = _prefixId.prefix "P1006"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of a work contained in the resource.skos:definition : Relaciona un recurso con uno o más nombres, frases, o grupos de caracteres relacionados con la identificación y/o función de cualquier persona o entidad corporativa responsables de, o que contribuyen a, la creación o realización del contenido intelectual o artístico de una obra contenida en el recurso.</para>
    ///   <para>skos:scopeNote : A statement of responsibility is not constructed when there is no such statement on the resource. A statement of responsibility can relate to such entities as: writers, composers, performers, graphic artists, choreographers, arrangers, cartographers, programmers, principal investigators, animators, etc., whose work is embodied in the resource, whether directly (e.g. author of text, editor, compiler, translator, illustrator, engraver, cartographer, composer, arranger, choreographer), or indirectly (e.g. author of the novel on which a film script is based, author of the work on which the software is based, adapters of an already existing work), whether in the same medium as the original or in another; collectors of various data, persons responsible for the direction of a performed work; organizations, or individuals or corporate bodies sponsoring the work of any of the above (with intellectual and not merely financial sponsorship), producers of a popular music recording;.production companies and individuals such as producers, directors, or others having some degree of overall responsibility for a work; individuals who have specific responsibilities when in the context of a particular film, or particular type of film, they have a major creative role (e.g. cinematographers, writers of screenplays or animators of animated films); developers and designers, whose work involves the creation of the content of a resource or its realisation (e.g. game designer); entities having specific responsibilities in the context of a particular resource or particular type of resource (e.g. project directors of survey data, video director).skos:scopeNote : No se construye una mención de responsabilidad cuando no hay mención en el recurso. Una mención de responsabilidad puede relacionar ciertas entidades como: escritores, compositores, realizadores, artistas gráficos, coreógrafos, arreglistas, cartógrafos, programadores, investigadores principales, animadores, etc., cuya obra está presente en el recurso, bien directamente (p. ej., autor del texto, editor, compilador, traductor, ilustrador, grabador, cartógrafo, compositor, arreglista, coreógrafo), o indirectamente (p. ej., autor de la novela en la que se basa un guión cinematográfico, autor de una obra en la que se basa un software, adaptadores de una obra ya existente), tanto si está en el mismo medio que el original o en otro, recopiladores de información diversa, personas responsables de la dirección de una obra interpretada, organizaciones, individuos  o entidades corporativas que patrocinan la obra de cualquiera de los anteriores (con patrocinion intelectual y no meramente financiero), productores de grabaciones de música popular, personas y compañias de producción como productores, directores u otros que tienen algún grado de responsabilidad sobre una obra; personas que tienen responsabilidades específicas en el contexto de una película, o tipo concreto de película, aquellos que tienen un rol creativo (por ejemplo cinematógrafos, escritores de guiones o dibujantes en películas de animación); desarrolladores y diseñadores, cuyo trabajo implica la creación del contenido de un recurso o su realización (p. ej. diseñador de juegos); entidades que tienen responsabilidades específicas en el contexto de un recurso concreto o tipo de recurso en particular (p. ej. directores de proyectos de datos estadísticos, director de video).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfResponsibilityRelatingToTitle</para>
    ///   <para>rdfs:label : has statement of responsibility relating to titlerdfs:label : tienen mención de responsabilidad relativa al título</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1007">isbd:P1007</a>
    /// </summary>
    let P1007 = _prefixId.prefix "P1007"
    /// <summary>
    ///   <para>skos:scopeNote : An edition statement normally includes either the word "edition" (or its equivalent in another language) or a related term together with a number ("2nd edition", etc.), or a term indicating difference from other editions ("new edition", "revised edition","“standard edition", "large print edition", "fourth state", "May 1970 script", etc.). A statement that includes the word "edition" or its equivalent is not considered an edition statement when it represents printing information, as is typical in the publication patterns of certain countries. An edition statement can also include other phrases that may be linguistically associated, linking the edition to other elements of the description (e.g. original title in a form such as "abridgement of ...").skos:scopeNote : Una mención de edición normalmente incluye o bien la palabra “edición” (o su equivalente en otra lengua) o un término similar, junto con un número ordinal (“2ª edición”, etc.) o un término que indique la diferencia respecto a otras ediciones (“nueva edición”, “edición revisada”, “edición estándar”, “edición de grandes caracteres”, cuarto estado”, “guión de mayo de 1970”, etc.). Una mención de edición puede incluir igualmente otras frases que pueden estar unidas lingüísticamente, vinculando la edición a otros elementos de la descripción (ej. título original con
    /// una forma como “resumen de….”).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEditionStatement</para>
    ///   <para>skos:definition : Relaciona un recurso con un término, frase o grupo de caracteres que indican que el recurso pertenece a una edición.skos:definition : Relates a resource to a word or phrase, or a group of characters, indicating that the resource belongs to an edition.</para>
    ///   <para>rdfs:label : tiene mención de ediciónrdfs:label : has edition statement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1008">isbd:P1008</a>
    /// </summary>
    let P1008 = _prefixId.prefix "P1008"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an equivalent of an edition statement (a word or phrase, or a group of characters, indicating that the resource belongs to an edition) in another language or script.skos:definition : Relaciona un recurso con un equivalente de la mención de edición (término, frase o grupo de caracteres que indican que el recurso pertenece a una edición) en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelEditionStatement</para>
    ///   <para>rdfs:label : has parallel edition statementrdfs:label : tiene mención de edición paralela</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1009">isbd:P1009</a>
    /// </summary>
    let P1009 = _prefixId.prefix "P1009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfResponsibilityRelatingToEdition</para>
    ///   <para>skos:scopeNote : Las menciones de responsabilidad relativas a la edición pueden hacer referencia a
    /// funciones tales como la de revisor de una nueva edición, o pueden designar a la persona o entidad responsable de la aportación de material complementario, apéndices, etc. a una nueva edición.skos:scopeNote : Statements of responsibility relating to the edition can indicate functions such as that of a reviser of a new edition, or can name the person or body responsible for the provision of supplementary matter, of appendices, etc., in a new edition.</para>
    ///   <para>rdfs:label : tiene mención de responsabilidad relativa a ediciónrdfs:label : has statement of responsibility relating to edition</para>
    ///   <para>skos:definition : Relates a resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of an edition of a work contained in the resource.skos:definition : Relaciona un recurso con uno o más nombres, frases, o grupos de caracteres relacionados con la identificación y/o función de cualquier persona o entidad corporativa responsables de, o que contribuyen a, la creación o realización del contenido intelectual o artístico de una edición de una obra contenida en el recurso.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1010">isbd:P1010</a>
    /// </summary>
    let P1010 = _prefixId.prefix "P1010"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying it as belonging to an edition or impression within an edition, or to an edition that is equivalent to the first named edition, or when the resource has significant differences in content from other impressions of the larger edition to which it belongs.skos:definition : Relaciona un recurso a una mención que lo identifica como perteneciente a una edición o impresión dentro de una edición, o a una edición equivalente a la primera edición mencionada, o cuando el recurso presenta diferencias significativas de contenido con respecto a otras impresiones de la edición más amplia a la que pertenece.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAdditionalEditionStatement</para>
    ///   <para>rdfs:label : has additional edition statementrdfs:label : tiene mención de edición adicional</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1011">isbd:P1011</a>
    /// </summary>
    let P1011 = _prefixId.prefix "P1011"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una palabra, frase, o grupo de caracteres que normalmente aparecen en el recurso, que es el nombre del recurso o de la obra (o cualquiera de un grupo de obras individuales) contenida en él.skos:definition : Relates a resource to a word or phrase, or a group of characters, usually appearing on the resource, that is the name of the resource or the work (or any one of a group of individual works) contained in it.</para>
    ///   <para>skos:scopeNote : A title proper; a title of individual work by the same author in a resource lacking a collective title; a title of an individual work by a different author in a resource lacking a collective title; a parallel title; other title information; or parallel other title information.skos:scopeNote : Un título propiamente dicho, un título de obra individual por el mismo autor en un recurso que carece de titulo colectivo; un título de una obra individual por un autor diferente en un recurso que carece de título colectivo; un título paralelo; información complementaria de título; u otra información complementaria de título paralelo.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitle</para>
    ///   <para>rdfs:label : tiene títulordfs:label : has title</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1012">isbd:P1012</a>
    /// </summary>
    let P1012 = _prefixId.prefix "P1012"
    /// <summary>
    ///   <para>rdfs:label : has mathematical data areardfs:label : tiene área de datos matemáticos</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMathematicalDataArea</para>
    ///   <para>skos:definition : Relaciona un recurso cartográfico a una mención que incluye la mención de escala, mención de proyección y mención de coordenadas y equinoccio.skos:definition : Relates a resource that is cartographic to a statement including the statement of scale, statement of projection, and the statement of coordinates and equinox.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1013">isbd:P1013</a>
    /// </summary>
    let P1013 = _prefixId.prefix "P1013"
    /// <summary>
    ///   <para>skos:scopeNote : Incluye partitura, partes. También se le conoce como formato de presentación musical.skos:scopeNote : Includes score, parts. Also known as musical presentation format.</para>
    ///   <para>rdfs:label : tiene mención de formato musicalrdfs:label : has music format statement</para>
    ///   <para>skos:definition : Relates a resource that is notated music to a term or phrase representing the physical form in which it is presented.skos:definition : Relaciona un recurso de música notada con un término o frase que representa la forma física en la cual se presenta.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMusicFormatStatement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1014">isbd:P1014</a>
    /// </summary>
    let P1014 = _prefixId.prefix "P1014"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberingArea</para>
    ///   <para>skos:definition : Relaciona un recurso que es una publicación seriada con una mención que incluye la numeración, la designación cronológica, el sistema paralelo de numeración, y el sistema sucesivo de numeración.skos:definition : Relates a resource that is a serial to a statement including the numbering, the chronological designation, the parallel system of numbering, and the subsequent system of numbering.</para>
    ///   <para>skos:scopeNote : Can include a numeral, a letter, any other character, or the combination of these, with or without an accompanying word ("volume", "number", etc.), and/or a chronological designation. Omitted if both the first and last issues or parts are not available.skos:scopeNote : Puede incluir un número, una letra, cualquier otro carácter o la combinación de éstos, con o sin una palabra acompañándoles (“volúmen”, “número”, etc.) y /o una designación cronológica. Se omite si tanto el primer como el último número o partes no están disponibles.</para>
    ///   <para>rdfs:label : has numbering areardfs:label : tiene área de numeración</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1015">isbd:P1015</a>
    /// </summary>
    let P1015 = _prefixId.prefix "P1015"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfPublicationProductionDistribution</para>
    ///   <para>rdfs:label : tiene lugar de publicación, producción, distribuciónrdfs:label : has place of publication, production, distribution</para>
    ///   <para>skos:scopeNote : Usually given on the preferred source of information as the name of a city. If no publisher, producer or distributor is named, it is the place from which the resource was issued or distributed.skos:scopeNote : Normalmente figura en la fuente preferida de información como el nombre de una ciudad. Si no consta el nombre de ningún editor, productor o distribuidor, es el lugar en el cual el recurso se ha emitido o distribuido.</para>
    ///   <para>skos:definition : Relaciona un recurso con el nombre de un lugar asociado en la fuente de información prescrita con el nombre del editor, productor o distribuidor.skos:definition : Relates a resource to the name of the place associated on the prescribed source of information with the name of the publisher, producer or distributor.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1016">isbd:P1016</a>
    /// </summary>
    let P1016 = _prefixId.prefix "P1016"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of the person or corporate body appearing on the resource that effects respectively the publication, production and/or distribution or release activities for the resource.skos:definition : Relaciona un recurso con el nombre de la persona o entidad corporativa que aparece en el recurso que lleva a cabo, respectivamente, la publicación, producción y/o distribución o las actividades de difusión del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameOfPublisherProducerDistributor</para>
    ///   <para>rdfs:label : has name of publisher, producer, distributorrdfs:label : tiene nombre de editor, productor, distribuidor</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1017">isbd:P1017</a>
    /// </summary>
    let P1017 = _prefixId.prefix "P1017"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the date on which it is officially offered for sale or distribution to the public, usually given in the form of a year.skos:definition : Relaciona un recurso con la fecha en que oficialmente se ha ofrecido para la venta o distribución al público, normalmente se da en la forma de un año.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateOfPublicationProductionDistribution</para>
    ///   <para>rdfs:label : has date of publication, production, distributionrdfs:label : tiene fecha de publicación, producción, distribución</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1018">isbd:P1018</a>
    /// </summary>
    let P1018 = _prefixId.prefix "P1018"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of the place associated on the resource with its printing or manufacture.skos:definition : Relaciona un recurso al nombre del lugar asociado en el recurso con su impresión o fabricación.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfPrintingOrManufacture</para>
    ///   <para>rdfs:label : has place of printing or manufacturerdfs:label : tiene lugar de impresión o fabricación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1019">isbd:P1019</a>
    /// </summary>
    let P1019 = _prefixId.prefix "P1019"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of the person or corporate body appearing on the resource that effects the printing or manufacturing of the resource.skos:definition : Relaciona un recurso con el nombre de la persona o entidad corporativa que aparece en el recurso que efectúa la impresión o fabricación del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameOfPrinterOrManufacturer</para>
    ///   <para>rdfs:label : has name of printer or manufacturerrdfs:label : tiene nombre de impresor o fabricante</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1020">isbd:P1020</a>
    /// </summary>
    let P1020 = _prefixId.prefix "P1020"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the date on which it is printed or manufactured, usually given in the form of a year.skos:definition : Relaciona un recurso con la fecha en la que se imprime o fabrica, normalmente se da en la forma de un año.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateOfPrintingOrManufacture</para>
    ///   <para>rdfs:label : has date of printing or manufacturerdfs:label : tiene fecha de impresión o fabricación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1021">isbd:P1021</a>
    /// </summary>
    let P1021 = _prefixId.prefix "P1021"
    /// <summary>
    ///   <para>rdfs:label : tiene designación específica del material y extensiónrdfs:label : has specific material designation and extent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSpecificMaterialDesignationAndExtent</para>
    ///   <para>skos:definition : Relates a resource to a statement including the specific material designation, the extent, the pagination statement (if a printed resource), and the playing time (if the resource has an inherent durational aspect).skos:definition : Relaciona un recurso con una mención incluyendo la designación específica de material, la extension, la mención de paginación (si es un recurso impreso) y la duración (si el recurso tiene un aspecto inherente de duración).</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1022">isbd:P1022</a>
    /// </summary>
    let P1022 = _prefixId.prefix "P1022"
    /// <summary>
    ///   <para>skos:scopeNote : Incluye método de producción, color, material del que está hecho el recurso, etc. Se omite cualquier característica implícita en la designación específica del material.skos:scopeNote : Includes method of production, colour, material from which the resource is made, etc. Any characteristic implicit in the specific material designation is omitted.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherPhysicalDetails</para>
    ///   <para>rdfs:label : has other physical detailsrdfs:label : tiene otros detalles físicos</para>
    ///   <para>skos:definition : Relates a resource to a statement including the statement relating to the material of which the resource is composed, the statement relating to the presence of illustrations, the particular type of illustration, the number of illustrations, the presence of colour, the reduction ration (if a microform), the presence or absence of sound (if a resource that may have integral sound as a feature), and other technical specifications.skos:definition : Relaciona un recurso con una mención que incluye la mención relativa al material del que está hecho el recurso, la mención relativa a la presencia de ilustraciones, el tipo específico de ilustración, el número de ilustraciones, la existencia de color, la proporción de reducción (si es una microforma), la existencia o ausencia de sonido (si es un recurso que pueda tener como carácterística el sonido integrado) y otras especificaciones técnicas.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1023">isbd:P1023</a>
    /// </summary>
    let P1023 = _prefixId.prefix "P1023"
    /// <summary>
    ///   <para>rdfs:label : tiene dimensionesrdfs:label : has dimensions</para>
    ///   <para>skos:scopeNote : Includes one or more dimensions. Includes the height of the resource, measured parallel to the spine, for printed textual and notated music resources. Includes the height by width of two-dimensional cartographic resources. Includes the height by width by depth of three-dimensional cartographic resources, excluding globes and sections of spheres. Includes the diameter for cartographic resources that are globes, sections of spheres, and two-dimensional circular forms. Includes additional dimensions such as the dimensions of a map when folded, or the dimensions of individual sheets of a collectively described group, or the individual dimensions of mounted sheets, of cartographic resources. Includes the height by width of two-dimensional multimedia resources, sound recordings, videorecordings, and still and moving images (wallcharts, microfiches, slides, transparencies, pictures, etc.). Includes the diameter, followed in parentheses by the abbreviation "diam." or its equivalent in another language, for circular forms of multimedia resources, sound recordings, videorecordings, and still and moving images. Includes the length of the vertical axis, followed in parentheses by "oval" or its equivalent, for oval forms of multimedia resources, sound recordings, videorecordings, and still and moving images. Includes two dimensions statements for the open and folded states of folded sheets of multimedia resources, sound recordings, videorecordings, and still and moving images. Includes height by width by depth (or height alone when appropriate) of three-dimensional multimedia resources, sound recordings, videorecordings, and still and moving images (dioramas, etc.). Includes the gauge of the film or width of the tape for multimedia resources, sound recordings, videorecordings, and still and moving images employing film or magnetic tape. Includes the dimensions of the physical carrier itself, irrespective of the external dimensions of any container, of electronic resources. Includes the diameter of a disc or a tape reel for an electronic resource. Includes the length and width of the tape of a reel of an electronic resource. Includes the height of the face of a chip cartridge of an electronic resource. Includes other dimensions given after the height when the dimensions or shape of the resource are unusual (e.g. when the width is greater than the height) for printed textual and notated music  resources. Includes the diameter of the playing surface when a sound disc is of a non-standard shape (e.g. when the playing surface has an irregularly shaped surround). Includes the height by depth of a tape cassette when it is other than the standard size (10 x 7 cm) and the width of tape is given when it is other than the standard width (4 mm). Includes the dimensions of a container for resources issued in a container, with or without accompanying material. Excludes the external dimensions of of any container such as an album or sleeve for multimedia resources, sound recordings, videorecordings, and still and moving images requiring the use of equipment (e.g. discs, cassettes, reels of tape or motion pictures). Excludes dimensions implicit in other parts of the description (e.g. cassettes and cartridges of a standard type) of multimedia resources, sound recordings, videorecordings, and still and moving images. Includes dimensions for older monographic resources which qualify the standard designation of bibliographic format as chosen by the cataloguing agency.skos:scopeNote : Incluye una o más dimensiones. Incluye la longitud del recurso, medida paralelelamente al lomo, para recursos textuales impresos y música notada. Incluye la longitud por la anchura en recursos cartográficos bidimensionales. Incluye la longitud por la anchura por la profundidad en recursos cartográficos tridimensionales, excluyendo los globos terráqueos y secciones de esferas. Incluye el diámetro para recursos cartográficos que son globos, secciones de esferas y recursos circulares en dos dimensiones. Incluye dimensiones adicionales de recursos cartográficos como las dimensiones de un mapa plegado, o las dimensiones de hojas individuales de un grupo descrito colectivamente, o de dimensiones individuales de hojas montadas. Incluye la altura por la anchura de recursos multimedia bidimensionales, grabaciones sonoras, videograbaciones e imágenes fijas y en movimiento (murales, microfichas, diapositivas, transparencias, imágenes, etc). Incluye el diámetro, seguido entre paréntesis de la abreviatura “diam.” o su equivalente en otra lengua, para las formas circulares de recursos multimedia, grabaciones sonoras, videograbaciones, e imágenes fijas y en movimiento. Incluye la longitud del eje vertical, seguido entre paréntesis por “oval” o su equivalente, para formas ovales de recursos multimedia, grabaciones sonoras, videograbaciones e imágenes fijas y en movimiento. Incluye mención de dos dimensiones para el estado plegado o abierto de hojas plegadas de recursos multimedia, grabaciones sonoras, videograbaciones, e imágenes fijas y en movimiento. Incluye la altura por anchura por profundidad (o solamente la longitud cuando sea apropiado) de recursos multimedia tridimensionales, grabaciones sonoras, videograbaciones, e imágenes fijas y en movimiento (dioramas, etc.) Incluye la anchura de la película o cinta para recursos multimedia, grabaciones sonoras, videograbaciones e imágenes fijas y en movimiento empleados en películas o cintas magnéticas. Incluye las dimensiones de cualquier soporte físico en sí mismo de recursos electrónicos independientemente de las dimensiones externas de su envase. Incluye la longitud y anchura de la cinta de un rollo de un recurso electrónico. Incluye la altura frontal de un cartucho de un recurso electrónico. Incluye otras dimensiones dadas tras la altura cuando las dimensiones o formas de un recurso son inusuales (p. ej. cuando la anchura es mayor que la longitud) para recursos textuales impresos y música notada. Incluye el diámetro de la superficie, cuando un disco sonoro no es de forma estándar (es decir, cuando la superficie grabada tiene un contorno irregular). Incluye la longitud por la profundidad de un casete cuando es otro tamaño que el estándar (10 x 7 cm) y la anchura de la cinta se da cuando es distinta de la anchura estándar (4 mm.). Incluye las dimensiones de un envase para recursos publicados en un envase, con o sin material anejo. Se excluye las dimensiones externas de cualquier envase como un álbum o funda para recursos multimedia, grabaciones sonoras, videograbaciones e imágenes fijas y en movimiento que requieren el uso en un equipo (discos, casetes, rollos de cinta o carretes de película). Se excluye las dimensiones implícitas en otras partes de la descripción (p. ej, casetes y cartuchos de tipo estándar) de recursos multimedia, grabaciones sonoras, videograbaciones e imágenes fijas y en movimiento. Incluye dimensiones para recursos monográficos antiguos que califican la designación estándar de formato bibliográfico elegido por la agencia de catalogación.</para>
    ///   <para>skos:definition : Relates a resource to a note on its dimensions in centimetres (or millimetres if the gauge of a film or width of a tape) rounded up to the nearest whole.skos:definition : Relaciona un recurso con una nota sobre sus dimensiones en centímetros (o milímetros si se trata de la anchura de una película o cinta) redondeando al número entero más cercano.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDimensions</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1024">isbd:P1024</a>
    /// </summary>
    let P1024 = _prefixId.prefix "P1024"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement on accompanying material (any physically separable part of the resource that is issued (or intended to be issued) at the same time and intended to be used with the resource).skos:definition : Relaciona un recurso con una mencion de material anejo (cualquier parte separada físicamente del recurso que se ha publicado (o existe intención de que se publique) al mismo tiempo y destinado para ser utilizado con el recurso).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAccompanyingMaterialStatement</para>
    ///   <para>rdfs:label : has accompanying material statementrdfs:label : tiene mención de material anejo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1025">isbd:P1025</a>
    /// </summary>
    let P1025 = _prefixId.prefix "P1025"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to the title proper (the chief name of a resource, i.e. the title of a resource in the form in which it appears on the preferred source of information for the resource).skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con el título propiamente dicho (el nombre principal de un recurso, es decir, el titulo de un recurso en la forma en la que aparece en la fuente preferida de información para el recurso).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleProperOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has title proper of series or multipart monographic resourcerdfs:label : tiene título propiamente dicho de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1026">isbd:P1026</a>
    /// </summary>
    let P1026 = _prefixId.prefix "P1026"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a title in another language or script than the title proper and presented as an equivalent of the title proper on the preferred source of information.skos:definition : Relaciona un recurso que es una serie o recurso monografico multiparte con un título en otra lengua o escritura diferente a la del título propiamente dicho y presentado como un equivalente del título propiamente dicho en la fuente preferida de información.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelTitleOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel title of series or multipart monographic resourcerdfs:label : tiene título paralelo de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1027">isbd:P1027</a>
    /// </summary>
    let P1027 = _prefixId.prefix "P1027"
    /// <summary>
    ///   <para>rdfs:label : tiene información complementaria del título de serie o recurso monográfico multiparterdfs:label : has other title information of series or multipart monographic resource</para>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a word or phrase, or a group of characters, appearing in conjunction with or subordinate to the title of the resource.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con una palabra, frase o grupo de caracteres que aparecen asociados, o subordinados al título del recurso.</para>
    ///   <para>skos:scopeNote : La información complementaria del título se indica cuando aparece en la fuente de información prescrita y es necesaria para la identificación del recurso bibliográfico más amplio o bien se considera importante para los usuarios del catálogo. La mención de edición relativa a la serie o subserie se da como información complementaria de título cuando es necesaria para la identificación de la serie.skos:scopeNote : Other title information is given when it appears on the prescribed source of information and is necessary for identification of the larger bibliographic resource or otherwise considered important to users of the catalogue. An edition statement relating to a series or subseries is given as other title information when necessary for identification of the series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherTitleInformationOfSeriesOrMultipartMonographicResource</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1028">isbd:P1028</a>
    /// </summary>
    let P1028 = _prefixId.prefix "P1028"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con uno o más nombres, frases o grupos de caracteres relacionados con la identificación y/o función de cualquier persona o entidad corporativa responsable de, o que contribuye a, la creación o realización del contenido artístico o intelectual de una obra contenida en el recurso.skos:definition : Relates a resource that is a series or multipart monographic resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of a work contained in the resource.</para>
    ///   <para>rdfs:label : tiene mención de responsabilidad de serie o recurso monográfico multiparterdfs:label : has statement of responsibility of series or multipart monographic resource</para>
    ///   <para>skos:scopeNote : Se da la primera mención de responsabilidad si el título propiamente dicho de la serie o recurso monográfico multiparte es un término genérico. En los demás  casos, se dan la primera y siguientes menciones de responsabilidad cuando aparecen en la fuente de información prescrita y son necesarias para la identificación del recurso bibliográfico más amplio o bien se considera importante para los usuarios del catálogo.skos:scopeNote : The first statement of responsibility is given if the title proper of the series or multipart monographic resource is a generic term. The first and subsequent statements of responsibility are given in other cases when they appear on the prescribed source of information and are necessary for identification of the larger bibliographic resource or otherwise considered important to users of the catalogue.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfResponsibilityOfSeriesOrMultipartMonographicResource</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1029">isbd:P1029</a>
    /// </summary>
    let P1029 = _prefixId.prefix "P1029"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to an international standard number relating to it.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con un número normalizado internacional relacionado con él.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasInternationalStandardNumberOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has international standard number of series or multipart monographic resourcerdfs:label : tiene número normalizado internacional de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1030">isbd:P1030</a>
    /// </summary>
    let P1030 = _prefixId.prefix "P1030"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to its numbering.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con su numeración.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberingWithinSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has numbering within series or multipart monographic resourcerdfs:label : tiene numeración de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1031">isbd:P1031</a>
    /// </summary>
    let P1031 = _prefixId.prefix "P1031"
    /// <summary>
    ///   <para>skos:scopeNote : Includes any number or alphanumeric designation associated with and identifying a resource according to an international standard, such as an International Standard Book Number or an International Standard Serial Number, or a designation assigned by a publisher. Includes notes considered important to users of the catalogue.skos:scopeNote : Incluye cualquier número o designación alfanumérica asociada que identifica un recurso de acuerdo a una norma internacional, como el International Standard Book Number o el International Standard Serial Number, o una denominación asignada por un editor. Incluye notas consideradas importantes para los usuarios del catálogo.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasResourceIdentifier</para>
    ///   <para>skos:definition : Relates a resource to an identifier.</para>
    ///   <para>rdfs:label : has resource identifierrdfs:label : tiene identificador del recurso</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1032">isbd:P1032</a>
    /// </summary>
    let P1032 = _prefixId.prefix "P1032"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a continuing resource to the unique name assigned to it by the ISSN Network.skos:definition : Relaciona un recurso continuado con un nombre único que le ha asignado la Red ISSN.</para>
    ///   <para>rdfs:label : tiene título claverdfs:label : has key title</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasKeyTitle</para>
    ///   <para>skos:scopeNote : El título clave se da incluso si es idéntico al título propiamente dicho del recurso continuado. No se da si el ISSN al que se aplica no aparece.skos:scopeNote : The key title is given even when it is identical to the title proper of the continuing resource. It is not given if the ISSN to which it applies is not given.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1033">isbd:P1033</a>
    /// </summary>
    let P1033 = _prefixId.prefix "P1033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermsOfAvailability</para>
    ///   <para>skos:scopeNote : Se recomienda que el precio del recurso se de con el código normalizado internacional para la moneda como en la norma ISO 4217.skos:scopeNote : It is recommended that the price of the resource be given with the international standard code for the currency as in ISO 4217.</para>
    ///   <para>skos:definition : Relates a resource to a statement of the price if it is for sale or a brief statement of other terms if it is not for sale.skos:definition : Relaciona un recurso con una mención del precio si está a la venta o una breve mención de otras condiciones si no está a la venta.</para>
    ///   <para>rdfs:label : has terms of availabilityrdfs:label : tiene condiciones de disponibilidad</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1034">isbd:P1034</a>
    /// </summary>
    let P1034 = _prefixId.prefix "P1034"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note on its edition area and bibliographic history.skos:definition : Relaciona un recurso con una nota sobre el area de edición e historia bibliográfica.</para>
    ///   <para>rdfs:label : has note on edition area and bibliographic historyrdfs:label : tiene nota sobre el área de edición e historia bibliográfica</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnEditionAreaAndBibliographicHistory</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1037">isbd:P1037</a>
    /// </summary>
    let P1037 = _prefixId.prefix "P1037"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el área de material o tipo específico de recurso.skos:definition : Relates a resource to a note on the material or type of resource specific area.</para>
    ///   <para>rdfs:label : tiene nota sobre tipo de material o tipo específico de recursordfs:label : has note on material type or resource specific type</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnMaterialTypeOrResourceSpecificType</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1038">isbd:P1038</a>
    /// </summary>
    let P1038 = _prefixId.prefix "P1038"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnPublicationProductionDistributionEtc</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el área de publicación, producción, distribución, etc.skos:definition : Relates a resource to a note on the publication, production, distribution, etc., area.</para>
    ///   <para>skos:scopeNote : Includes details of other publishers, producers, distributors, etc., of the resource; notes on variant publication, production or distribution, etc., information; irregularities; and additional dates.skos:scopeNote : Incluye detalles de otros editores, productores, distribuidores, etc., del recurso; notas sobre variaciones en la publicación, producción, distribución, etc.; irregularidades y fechas adicionales.
    /// </para>
    ///   <para>rdfs:label : tiene nota sobre publicación, producción, distribución, etc.rdfs:label : has note on publication, production, distribution, etc.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1039">isbd:P1039</a>
    /// </summary>
    let P1039 = _prefixId.prefix "P1039"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el área de descripción del material.skos:definition : Relates a resource to a note on the material description area.</para>
    ///   <para>skos:scopeNote : Incluye incluir información adicional de la descripción física del recurso y menciones sobre peculiaridades físicas concretas. Las notas deben realizarse sobre el material anejo o sobre detalles físicos anteriores de un recurso integrable.skos:scopeNote : Includes additional physical description of the resource, and statements on particular physical peculiarities. Notes may also be made on accompanying material or on earlier physical details of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnMaterialDescription</para>
    ///   <para>rdfs:label : has note on material descriptionrdfs:label : tiene nota sobre descripción del material</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1040">isbd:P1040</a>
    /// </summary>
    let P1040 = _prefixId.prefix "P1040"
    /// <summary>
    ///   <para>skos:scopeNote : Incluye notas que dan información sobre la serie o recurso monográfico multiparte en el que el recurso ha sido publicado, y notas sobre los editores de la serie.skos:scopeNote : Includes notes giving information about a series or multipart monographic resource in which the resource has been issued, and notes on series editors.</para>
    ///   <para>rdfs:label : tiene nota de serie o recurso monográfico multiparterdfs:label : has note on series and multipart monographic resources</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el área de serie y recurso monográfico.skos:definition : Relates a resource to a note on the series and monographic resources area.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnSeriesAndMultipartMonographicResources</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1041">isbd:P1041</a>
    /// </summary>
    let P1041 = _prefixId.prefix "P1041"
    /// <summary>
    ///   <para>rdfs:label : tiene nota sobre el contenidordfs:label : has note on contents</para>
    ///   <para>skos:scopeNote : Includes the list of contents and notes on other
    /// inclusions, such as indexes, inserts, bibliographies, discographies, etc.</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota relativa al contenido.skos:definition : Relates a resource to a note relating to the contents.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnContents</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1042">isbd:P1042</a>
    /// </summary>
    let P1042 = _prefixId.prefix "P1042"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con una nota sobre el fascículo, parte, iteración, etc., en  que se basa la descripción.skos:definition : Relates a resource that is a series or multipart monograph to a note on the issue, part, iteration, etc., that forms that basis of its description.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnBasisOfDescription</para>
    ///   <para>rdfs:label : tiene nota sobre base de descripciónrdfs:label : has note on basis of description</para>
    ///   <para>skos:scopeNote : Incluye el fascículo o parte en el que se basa la descripción cuando la descripción de una publicación seriada o recurso monográfico multiparte no está basada en el primer fascículo o parte publicada. Incluye la primera analítica consultada y su fecha de publicación, producción, distribución, etc, si se hace una descripción para una serie monográfica no numerada. Si también se han consultado otras analíticas y se puede identificar la última analítica incluye la analítica y su fecha de publicación. Incluye la última iteración consultada al preparar la descripción si esta descripción no se basa en la primera iteración de un recurso integrable. Incluye el fascículo o iteración que forma la base de la descripción de un recurso electrónico de acceso remoto, con la fecha en la que se consultó.skos:scopeNote : Includes the issue or part that forms the basis of the description if the description of a serial or multipart monographic resource is not based on the first issue or part published. Includes the earliest analytic consulted and its date of publication, production, distribution, etc. if a description is made for an unnumbered monographic series itself. Includes the analytic and its date of publication if other analytics also have been consulted and the latest analytic can be identified. Includes the latest iteration consulted in preparing the description if the description is not based on the first iteration of an integrating resource. Includes the issue or iteration that forms the basis of the description of a remote-access electronic resource, along with the date on which it was viewed.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1044">isbd:P1044</a>
    /// </summary>
    let P1044 = _prefixId.prefix "P1044"
    /// <summary>
    ///   <para>skos:scopeNote : Notes qualify and amplify the description in the other areas and can deal with any aspect of a resource. Notes may also give the bibliographic history of the resource and indicate relationships to other resources. In making reference to another resource in a note, enough information must be given to identify the
    /// resource. This may vary depending on the resource and the context of the note. For continuing resources,
    /// the citation may consist of the key title and ISSN. In other cases, it may consist of the title proper along
    /// with a statement of responsibility or other bibliographic details. Two or more notes may be combined into a single note when considered appropriate by the cataloguing agency.skos:scopeNote : Las notas califican y amplian la descripción de las otras áreas y pueden relacionarse con cualquier aspecto del recurso. Las notas pueden referirse también a la historia bibliográfica del recurso e indicar relaciones con otros recursos. Al hacer referencia a otros recursos en una nota, debe darse suficiente información para identificar el recurso. Esto puede variar dependiendo del recurso y el contexto de la nota. Para recursos continuados, la cita puede consistir en el título clave y el ISSN. En otros casos, puede consistir en el título propiamente dicho junto con una mención de responsabilidad u otros detalles bibliográficos. Se puede combinar dos o más notas en una nota común cuando se considere apropiado por la agencia de catalogación.</para>
    ///   <para>rdfs:label : has noterdfs:label : tiene nota</para>
    ///   <para>skos:definition : Relates a resource to a note of descriptive information that has not been given in other areas of the description but that is considered to be important to users of bibliographic records.skos:definition : Relaciona un recurso con una nota de información descriptiva que no se ha dado en otras áreas de descripción pero que se considera importante para los usuarios de registros bibliográficos.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNote</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1045">isbd:P1045</a>
    /// </summary>
    let P1045 = _prefixId.prefix "P1045"
    /// <summary>
    ///   <para>rdfs:label : tiene nota sobre el ejemplar que se describerdfs:label : Incluye notas relativas a las características físicas del ejemplar, notas relativas a ejemplares “encuadernados con”, notas de procedencia y notas de acción.rdfs:label : has note on copy in hand</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnCopyInHand</para>
    ///   <para>skos:scopeNote : Includes notes relating to the physical characteristics of the copy, notes relating to "bound with" copies, provenance notes, and action notes.</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el ejemplar que se está catalogando.skos:definition : Relates a resource to a note on the copy being catalogued.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1046">isbd:P1046</a>
    /// </summary>
    let P1046 = _prefixId.prefix "P1046"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is cartographic to the ratio of distances on the resource to the actual distances they represent, given as a representative fraction, expressed as a ratio (1: ).skos:definition : Relaciona un recurso cartográfico con la razón matemática entre la distancia en el recurso y la medida real que representa, se da como una fracción representativa, expresada como una ratio (1: ).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfScale</para>
    ///   <para>rdfs:label : has statement of scalerdfs:label : tiene mención de escala</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1047">isbd:P1047</a>
    /// </summary>
    let P1047 = _prefixId.prefix "P1047"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is cartographic to the name and properties of a systematic drawing of lines on a plane surface to represent the parallels of latitude and the meridians of longitude of the Earth or a section of the Earth or other celestial sphere.skos:definition : Relaciona un recurso cartográfico con el nombre y propiedades de un dibujo sistemático de líneas sobre una superficie plana que representa los paralelos de latitud y los meridianos de longitud de la Tierra o una sección de la Tierra u otra esfera celeste.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfProjection</para>
    ///   <para>rdfs:label : has statement of projectionrdfs:label : tiene mención de proyección</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1048">isbd:P1048</a>
    /// </summary>
    let P1048 = _prefixId.prefix "P1048"
    /// <summary>
    ///   <para>rdfs:label : tiene mención de coordenadas y equinocciordfs:label : has statement of coordinates and equinox</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfCoordinatesAndEquinox</para>
    ///   <para>skos:definition : Relaciona un recurso cartográfico con una mención que incluye las coordenadas y equinoccio.skos:definition : Relates a resource that is cartographic to a statement including the coordinates and equinox.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1049">isbd:P1049</a>
    /// </summary>
    let P1049 = _prefixId.prefix "P1049"
    /// <summary>
    ///   <para>rdfs:label : has coordinatesrdfs:label : tiene coordenadas</para>
    ///   <para>skos:definition : Relaciona un recurso cartográfico con sus coordenadas (las medidas de latitud y longitud que definen la posición de puntos sobre la superficie de la Tierra u otra esfera celeste que delimita la mayor extensión del área cubierta).skos:definition : Relates a resource that is cartographic to its coordinates (the quantities of latitude and longitude that define the position of points on the surface of the Earth or other celestial sphere that delimit the greatest extent of the area covered).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCoordinates</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1050">isbd:P1050</a>
    /// </summary>
    let P1050 = _prefixId.prefix "P1050"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso cartográfico con su ascensión recta (la distancia angular medida desde el Equinoccio de primavera hacia el Este a lo largo del Ecuador, al círculo horario a través del cuerpo celeste, en valores de 0 a 24 horas) y la declinación (la distancia angular de  un cuerpo sobre la esfera celeste medida en 90 grados Norte o Sur, con el Ecuador celeste a través del círculo horario del cuerpo celeste; comparable a la latitud de la esfera terrestre).skos:definition : Relates a resource that is cartographic to its right ascension (the angular distance measured eastward on the Equator from the vernal equinox to the hour circle through the celestial body, from 0 to 24 hours), and declination (the angular distance to a body on the celestial sphere measured north or south through 90 degrees from the celestial equator along the hour circle of the body; comparable to latitude on the terrestrial sphere).</para>
    ///   <para>rdfs:label : has right ascension and declinationrdfs:label : tiene ascensión recta y declinación</para>
    ///   <para>skos:scopeNote : Aplicar también a las cartas celestes.skos:scopeNote : Applies also to celestial charts.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRightAscensionAndDeclination</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1051">isbd:P1051</a>
    /// </summary>
    let P1051 = _prefixId.prefix "P1051"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is cartographic to its equinox (one of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0 degrees).skos:definition : Relaciona un recurso cartográfico con su equinoccio (uno de los dos puntos de la interesección de la eclíptica y el Ecuador celeste, ocupado por el sol cuando su declinación es de 0 grados).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEquinox</para>
    ///   <para>rdfs:label : has equinoxrdfs:label : tiene equinoccio</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1052">isbd:P1052</a>
    /// </summary>
    let P1052 = _prefixId.prefix "P1052"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the names and numbers of the physical unit or units constituting the resource.skos:definition : Relaciona un recurso con los nombres y números de la unidad o unidades físicas que constituyen el recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExtent</para>
    ///   <para>rdfs:label : has extentrdfs:label : tiene extensión</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1053">isbd:P1053</a>
    /// </summary>
    let P1053 = _prefixId.prefix "P1053"
    /// <summary>
    ///   <para>skos:scopeNote : Incluye la numeración de hojas, columnas, etc.skos:scopeNote : Includes notated music and cartographic resources as well as printed textual resources.skos:scopeNote : Includes the numbering of leaves, columns, etc.</para>
    ///   <para>rdfs:label : has paginationrdfs:label : tiene paginación</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPagination</para>
    ///   <para>skos:definition : Relaciona un recurso de texto impreso con la numeración secuencial de páginas.skos:definition : Relates a resource that is a printed text to the sequential numbering of the pages.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1054">isbd:P1054</a>
    /// </summary>
    let P1054 = _prefixId.prefix "P1054"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that has an inherent durational aspect to the time it takes to play the whole resource.skos:definition : Relaciona un recurso que tiene un aspecto inherente de duración con el tiempo que conlleva la ejecución del recurso completo.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlayingTime</para>
    ///   <para>rdfs:label : has playing timerdfs:label : tiene duración</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1055">isbd:P1055</a>
    /// </summary>
    let P1055 = _prefixId.prefix "P1055"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word or phrase indicating the material of which it is composed.skos:definition : Relaciona un recurso con una palabra o frase que indica el material del que está compuesto.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCompositionOfMaterial</para>
    ///   <para>rdfs:label : has composition of materialrdfs:label : tiene composición de material</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1056">isbd:P1056</a>
    /// </summary>
    let P1056 = _prefixId.prefix "P1056"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is illustrated to the abbreviation "ill." (or its equivalent in another language), followed or replaced by a specification of particular types of illustration.skos:definition : Relaciona un recurso que está ilustrado con la abreviatura “ill.” (o su equivalente en otra lengua), seguido o sustituido por una especificación del tipo concreto de ilustración.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPresenceOfIllustrations</para>
    ///   <para>rdfs:label : has presence of illustrationsrdfs:label : tiene presencia de ilustraciones</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1057">isbd:P1057</a>
    /// </summary>
    let P1057 = _prefixId.prefix "P1057"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of an additional edition statement of a work contained in the resource, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con uno o más nombres, frases o grupos de caracteres relativos a la identificación y/o función de personas o entidades corporativas responsables de, o que contribuyen a, la creación o realización del contenido intelectual o artístico de una mención de edición adicional de una obra contenida en el recurso, que se presenta en la fuente preferida de información como equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelStatementOfResponsibilityRelatingToAnAdditionalEditionStatement</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to an additional edition statementrdfs:label : tiene mención de responsabilidad paralela relativa a una mención de edición adicional</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1058">isbd:P1058</a>
    /// </summary>
    let P1058 = _prefixId.prefix "P1058"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of an additional edition statement of a work contained in the resource.skos:definition : Relaciona un recurso a uno o más nombres, frases o grupo de caracteres relacionados con la identificación y/o función de personas o entidades corporativas responsables de, o que contribuyen a, la creación o realización del contenido intelectual o artístico de una mención de edición adicional de una obra contenida en el recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfResponsibilityRelatingToAnAdditionalEditionStatement</para>
    ///   <para>rdfs:label : has statement of responsibility relating to an additional edition statementrdfs:label : tiene mención de responsabilidad relativa a una mención de edición adicional</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1059">isbd:P1059</a>
    /// </summary>
    let P1059 = _prefixId.prefix "P1059"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that has coloured illustrations, or is visual, to a statement indicating the presence of coloured illustrations or colour characteristics, using the abbreviations "col." or "b&amp;w" (or their equivalents in another language).skos:definition : Relaciona un recurso que tiene ilustraciones en color, o es visual, con una mención que indica la presencia de ilustraciones en color o características de color, utilizando las abreviaturas “col.” o “bl. y n.” (o sus equivalentes en otra lengua).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPresenceOfColour</para>
    ///   <para>rdfs:label : has presence of colourrdfs:label : tiene presencia de color</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1060">isbd:P1060</a>
    /// </summary>
    let P1060 = _prefixId.prefix "P1060"
    /// <summary>
    ///   <para>rdfs:label : tiene proporción de reducciónrdfs:label : has reduction ratio</para>
    ///   <para>skos:definition : Relates a resource that is a microform to an indication of the reduction ratio.skos:definition : Relaciona un recurso que es una microforma con una indicación de su proporción de reducción.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasReductionRatio</para>
    ///   <para>skos:scopeNote : Where possible the ratio is expressed numerically. The terms "low reduction" (up to 15x), "high reduction" (31x–60x), "very high reduction" (61x–
    /// 90x) and "ultra-high reduction" (91x and upwards) or their equivalents in another language and/or script are
    /// used in cases where the reduction ratio cannot be specified exactly.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1061">isbd:P1061</a>
    /// </summary>
    let P1061 = _prefixId.prefix "P1061"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso que incluye sonido como una característica integral con las abreviaturas “son.” (para “sonoro”) o “sil.” (para “silencio”) (o sus equivalentes en otra lengua).skos:definition : Relates a resource that includes sound as an integral feature to the abbreviations "sd." (for sound) or "si." (for silent) (or their equivalents in another language).</para>
    ///   <para>skos:scopeNote : Omitted if the presence of sound is implicit in the specific material designation.skos:scopeNote : Se omite si la presencia de sonido está implícita en la designación específica del material.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPresenceOrAbsenceOfSound</para>
    ///   <para>rdfs:label : has presence or absence of soundrdfs:label : tiene presencia o ausencia de sonido</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1062">isbd:P1062</a>
    /// </summary>
    let P1062 = _prefixId.prefix "P1062"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a microfilm reel, microfilm slip, or filmstrip to a statement of its frame alignment.skos:definition : Relaciona un recurso que es un carrete de microfilme, tira de microfilme, o tira de película  con una mención de su alineación de fotogramas.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFrameAlignment</para>
    ///   <para>rdfs:label : has frame alignmentrdfs:label : tiene alineación de los fotogramas</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1063">isbd:P1063</a>
    /// </summary>
    let P1063 = _prefixId.prefix "P1063"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is an older monographic resource to a citation, given in a standard and abbreviated form, to a description of the resource in a list describing older monographic resources.skos:definition : Relaciona un recurso monográfico antiguo con una cita, de forma abreviada y normalizada de la descripción del recurso, en una lista que describe recursos monográficos antiguos.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnBibliographicReference</para>
    ///   <para>rdfs:label : has note on bibliographic referencerdfs:label : tiene nota de referencia bibliográfica</para>
    ///   <para>skos:scopeNote : The note may contain more than one citation.skos:scopeNote : La nota debe contener más de una cita.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1064">isbd:P1064</a>
    /// </summary>
    let P1064 = _prefixId.prefix "P1064"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a serial to a note on the frequency. Relates a resource that is an integrating resource to a note on the frequency of updates.skos:definition : Relaciona un recurso que es una publicación seriada con una nota de frecuencia. Relaciona un recurso que es un recurso integrable con una nota de frecuencia de actualizaciones.</para>
    ///   <para>rdfs:label : has note on frequencyrdfs:label : tiene nota de frecuencia</para>
    ///   <para>skos:scopeNote : Se utiliza cuando la frecuencia no está establecida en el área de título y mención de responsabilidad o es necesario transmitir alguna información adicional.skos:scopeNote : Used when the frequency is not stated in the title and statement of responsibility area, or it is necessary to convey some additional information.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnFrequency </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1065">isbd:P1065</a>
    /// </summary>
    let P1065 = _prefixId.prefix "P1065"
    /// <summary>
    ///   <para>rdfs:label : has note on system requirements rdfs:label : tiene nota de requisitos mínimos del sistema</para>
    ///   <para>skos:scopeNote : Incluye una o más especificaciones técnicas, normalmente dadas en el siguiente orden y precedidas de la frase “Requisitos del sistema”: (o su equivalente en otra lengua): marca, modelo y/o número de serie del equipo o equipos; cantidad de memoria, nombre del sistema o sistemas operativos; requisitos de software (incluido el lenguaje de programación); periféricos; modificaciones (internas) de hardware; códigos de caracteres. Si el recurso está formado por dos o más soportes físicos diferentes (ej. un recurso multimedia formado por un disco electrónico y un videodisco), se puede redactar una nota sobre requisitos del sistema para cada uno, en la que se resalten las características distintivas del sistema asociado a cada soporte físico. Como alternativa, se puede hacer una única nota de requisitos del sistema para ambos soportes físicos.skos:scopeNote : Includes one or more technical specifications, usually given in the following order, and preceded by the phrase  "System requirements:" (or its equivalent in another language): name, model and, or, number of machine or machines; amount of memory; name of the operating system or systems; software requirements (including programming language); peripherals; hardware (internal) modifications; character code. Separate system requirements notes may be made to highlight distinctive system features associated with each physical carrier, when the resource consists of two or more different physical carriers (e.g. a multimedia resource consisting of an electronic disk and a videodisc). Alternatively, a single system requirements note for both physical carriers may be made.</para>
    ///   <para>skos:definition : Relates a resource that is a direct access electronic resource to a note on system requirements for use of the resource.skos:definition : Relaciona un recurso electrónico de acceso directo con una nota sobre los requisitos del sistema para el uso del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnSystemRequirements </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1066">isbd:P1066</a>
    /// </summary>
    let P1066 = _prefixId.prefix "P1066"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a remote access electronic resource to a note on the mode of access, preceded by the phrase "Mode of access:" (or its equivalent in another language).skos:definition : Relaciona un recurso electrónico remotocon una nota sobre el modo de acceso, precedido de la frase “Modo de acceso:” (o su equivalente en otra lengua).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnModeOfAccess </para>
    ///   <para>rdfs:label : has note on mode of access rdfs:label : tiene nota sobre modo de acceso</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1067">isbd:P1067</a>
    /// </summary>
    let P1067 = _prefixId.prefix "P1067"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre el título propiamente dicho (el nombre principal de un recurso, por ejemplo, el título de un recurso en la forma en la que aparece en la fuente preferida de información de información para el recurso).skos:definition : Relates a resource to a note on the title proper (the chief name of a resource, i.e. the title of a resource in the form in which it appears on the preferred source of information for the resource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnTitleProper</para>
    ///   <para>rdfs:label : has note on title properrdfs:label : tiene nota sobre título propiamente dicho</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1068">isbd:P1068</a>
    /// </summary>
    let P1068 = _prefixId.prefix "P1068"
    /// <summary>
    ///   <para>rdfs:label : tiene nota sobre naturaleza, alcance, forma, propósito o lenguardfs:label : has note on nature, scope, form, purpose or language</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnNatureScopeFormPurposeOrLanguage</para>
    ///   <para>skos:definition : Relates a resource to a note on its nature, purpose, scope, or literary, artistic or musical form, or language if the linguistic content is significant.skos:definition : Relaciona un recurso con una nota sobre su naturaleza, propósito, alcance, o forma literaria, artística o musical, o la lengua si el contenido lingüístico es significativo.</para>
    ///   <para>skos:scopeNote : Used when the information cannot be inferred from other elements of the description.skos:scopeNote : Se utiliza cuando la información no puede ser inferida de otros elementos de la descripción.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1073">isbd:P1073</a>
    /// </summary>
    let P1073 = _prefixId.prefix "P1073"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso monográfico antiguo con un número de caracteres procedentes de un número regulado de lugares en el texto de un recurso, considerado como un sustituto de un número normalizado.skos:definition : Relates a resource that is an older monographic resource to a number of characters drawn from a number of uniform places in the text of the resource, considered as a substitute for a standard number.</para>
    ///   <para>skos:scopeNote : Todavía tiene que determinarse por acuerdo internacional una fórmula definitiva para el identificador tipográfico. Hasta que se lleve a cabo ese acuerdo, se pueden utilizar las diferentes formas de identificadores tipográficos.skos:scopeNote : A definitive formula for fingerprint has yet to be determined by international agreement. Until such an agreement is made, various forms of fingerprint can be used.</para>
    ///   <para>rdfs:label : tiene identificador tipográficordfs:label : has fingerprint</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFingerprint</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1075">isbd:P1075</a>
    /// </summary>
    let P1075 = _prefixId.prefix "P1075"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is commercially issued to the label name and all catalogue numbers supplied by the issuing company.skos:definition : Relaciona un recurso que se publica comercialmente con el nombre de la etiqueta y con todos los números de catálogo suministrados por la compañía editora.</para>
    ///   <para>rdfs:label : has label name and catalogue numberrdfs:label : tiene nombre comercial y número de catálogo</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLabelNameAndCatalogueNumber</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1076">isbd:P1076</a>
    /// </summary>
    let P1076 = _prefixId.prefix "P1076"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a brief statement that qualifies, explains, or corrects the identifier.skos:definition : Relaciona un recurso con una breve mención que califica, explica o corrige el identificador.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasQualificationToIdentifier</para>
    ///   <para>rdfs:label : has qualification to identifierrdfs:label : tiene aclaración para el identificador</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1077">isbd:P1077</a>
    /// </summary>
    let P1077 = _prefixId.prefix "P1077"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre la encuadernación como fue publicada por el editor.skos:definition : Relates a resource to a note on the binding as issued by the publisher.</para>
    ///   <para>skos:scopeNote : Se excluye una encuadernación específica de un ejemplar que se tiene en la mano.skos:scopeNote : Excludes a binding specific to a copy in hand.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnBinding</para>
    ///   <para>rdfs:label : has note on bindingrdfs:label : tiene nota sobre la encuadernación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1078">isbd:P1078</a>
    /// </summary>
    let P1078 = _prefixId.prefix "P1078"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note relating to the resource identifier and terms of availability.skos:definition : Relaciona un recurso con una nota relativa al identificador del recurso y condiciones de disponibilidad.</para>
    ///   <para>rdfs:label : tiene nota sobre identificador del recurso y condición de disponibilidadrdfs:label : has note on resource identifier and terms of availability</para>
    ///   <para>skos:scopeNote : Includes notes of limited print run, issues or limited distribution.skos:scopeNote : Incluye notas de impresión limitada, edición o distribución limitada.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnResourceIdentifierAndTermsOfAvailability</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1079">isbd:P1079</a>
    /// </summary>
    let P1079 = _prefixId.prefix "P1079"
    /// <summary>
    ///   <para>rdfs:label : tiene nota sobre títulos paralelos e información complementaria del título paralelordfs:label : has note on parallel titles and parallel other title information</para>
    ///   <para>skos:definition : Relates a resource to a note on parallel titles and parallel other title information.skos:definition : Relaciona un recurso con una nota sobre los títulos paralelos e información complementaria del título paralela.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnParallelTitlesAndParallelOtherTitleInformation</para>
    ///   <para>skos:scopeNote : Excludes information recorded in the title and statement of responsibility area.skos:scopeNote : Se excluye la información registrada en el área de título y mención de responsabilidad.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1086">isbd:P1086</a>
    /// </summary>
    let P1086 = _prefixId.prefix "P1086"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnStatementOfResponsibility</para>
    ///   <para>rdfs:label : tiene nota sobre mención de responsabilidadrdfs:label : has note on statement of responsibility</para>
    ///   <para>skos:scopeNote : Includes statements of responsibility taken from outside the resource, its container or accompanying textual matter; notes on variant or expanded forms of names of persons or corporate bodies, notes on pseudonyms, notes on persons or corporate bodies connected with the work that cannot be included in other areas of the description (because, for example, their function is not specified); statements of responsibility relating to appendices and other supplementary matter appearing on the resource but not on a prescribed source of information; notes on the staging, instrumentation, etc., of performed works; notes on persons or bodies connected with the technical production, administrative and consulting functions of the work.skos:scopeNote : Incluye menciones de responsabilidad tomadas de fuentes externas al recurso, su envase o información textual aneja; notas sobre las variantes o formas desarrolladas de nombres de personas o de entidades corporativas, notas sobre seudónimos, notas sobre personas o entidades corporativas relacionadas con la obra que no pueden incluirse en otras áreas de la descripción (porque, por ejemplo, no está especificada su función); menciones de responsabilidad relativas a los apéndices y a otros materiales complementarios que aparecen en el recurso pero no en la fuente de información prescrita; notas sobre puesta en escena, instrumentación, etc. de las obras representadas; notas sobre personas o entidades corporativas relacionadas con la producción técnica y las funciones administrativas y consultivas de la obra.</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota sobre sus menciones de responsabilidad (menciones, que se transcriben del recurso que se está describiendo, relativas a las personas responsables del contenido intelectual o artístico del recurso, a las entidades corporativas de las que emana el contenido, o a las personas o entidades corporativas responsables de la realización del contenido del recurso).skos:definition : Relates a resource to a note on its statements of responsibility (statements, transcribed from the resource being described, relating to persons responsible for the intellectual or artistic content of the resource, to corporate bodies from which the content emanates, or to persons or corporate bodies responsible for the performance of the content of the resource).</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1087">isbd:P1087</a>
    /// </summary>
    let P1087 = _prefixId.prefix "P1087"
    /// <summary>
    ///   <para>skos:scopeNote : Puede basarse en las menciones encontradas en el recurso, en su envase o en el material textual que lo acompaña. También puede incluir información sobre el uso de técnicas o procedimientos especiales.skos:scopeNote : May draw upon statements found on the resource, its container or accompanying textual matter. Information on the use of special techniques or processes may also be included.</para>
    ///   <para>rdfs:label : has note providing a summaryrdfs:label : tiene nota de provisión de sumario</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteProvidingASummary</para>
    ///   <para>skos:definition : Relates a resource to a note providing a factual, non-evaluative account of the subject coverage.skos:definition : Relaciona un recurso con una nota que proporciona un informe objetivo, no evaluativo, de la cobertura temática.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1090">isbd:P1090</a>
    /// </summary>
    let P1090 = _prefixId.prefix "P1090"
    /// <summary>
    ///   <para>skos:scopeNote : Normalmente se obtienen de menciones de dentro o fuera del recurso. Incluye especificaciones de restricciones en el uso.skos:scopeNote : Normally taken from statements on or in the resource. Includes specification of restrictions on use.</para>
    ///   <para>rdfs:label : has note on use or audiencerdfs:label : tiene nota de uso o destinatario</para>
    ///   <para>skos:definition : Relates a resource to a note providing non-evaluative information as to the potential or recommended use of the resource and/or the intended audience.skos:definition : Relaciona un recurso con una nota que proporciona información no evaluativa sobre el uso potencial o recomendado del recurso y/o sobre los destinatarios a los que está dirigido.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnUseOrAudience</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1091">isbd:P1091</a>
    /// </summary>
    let P1091 = _prefixId.prefix "P1091"
    /// <summary>
    ///   <para>skos:scopeNote : Se excluyen los identificadores registrados en el área de identificador del recurso y condiciones de disponibilidad.skos:scopeNote : Excludes identifiers recorded in the resource identifier and terms of availability area.</para>
    ///   <para>rdfs:label : tiene nota relativa a númerosrdfs:label : has note on numbers</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnNumbers</para>
    ///   <para>skos:definition : Relates a resource to a note on numbers or identifiers associated with it.skos:definition : Relaciona un recurso a una nota relativa a números o identificadores asociados con él.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1092">isbd:P1092</a>
    /// </summary>
    let P1092 = _prefixId.prefix "P1092"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of terms of availability.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermsOfAvailabilityStatement</para>
    ///   <para>rdfs:label : has terms of availability statement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1093">isbd:P1093</a>
    /// </summary>
    let P1093 = _prefixId.prefix "P1093"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a serial or multipart monograph to a note on changes in edition statements that occur after the issue or part used as the basis of description and do not require a new description. Relates a resource that is an integrating resource to a note on earlier edition statements that are no longer present on the current iteration or that are in a different form on an earlier iteration and do not require a new description.skos:definition : Relaciona un recurso que es una publicación seriada o una monografía multiparte con una nota sobre cambios en las menciones de edición que son posteriores al fascículo o parte que se usa como base de la descripción, pero que no requiere una nueva descripción. Relaciona un recurso integrable con una nota sobre una mención de edición anterior que ya no está presente en la iteración más reciente o que está de una forma diferente a la iteración anterior, y que no requiere una nueva descripción.</para>
    ///   <para>rdfs:label : tiene nota de cambio en ediciónrdfs:label : has note on change to edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnChangeToEdition</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1094">isbd:P1094</a>
    /// </summary>
    let P1094 = _prefixId.prefix "P1094"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note relating to the edition being described or the bibliographic history of the work.skos:definition : Relaciona un recurso con una nota relativa a la edición que se describe o a la historia bibliográfica de la obra.</para>
    ///   <para>rdfs:label : has note on bibliographic historyrdfs:label : tiene nota de historia bibliográfica</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnBibliographicHistory</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1095">isbd:P1095</a>
    /// </summary>
    let P1095 = _prefixId.prefix "P1095"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that contains a work that is a translation to a note on the original title of the work, or, where appropriate, the key title and ISSN.skos:definition : Relaciona un recurso que contiene una obra que es una traducción con una nota sobre el título original de la obra o, cuando sea apropiado, el título clave e ISSN.</para>
    ///   <para>rdfs:label : tiene nota de traduccionesrdfs:label : has note on translations</para>
    ///   <para>skos:scopeNote : La notas sobre traducciones se pueden incluir en las notas sobre contenido cuando el recurso contiene varias obras individuales. Se excluyen notas sobre la lengua del título. Se excluyen notas sobre ediciones de un recurso que aparecen simultáneamente en varias lenguas.skos:scopeNote : Notes on translations may be included in the notes on contents when the resource contains several individual works. Excludes notes on the language of the title. Excludes notes on editions of a resource appearing simultaneously in different languages.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnTranslations</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1096">isbd:P1096</a>
    /// </summary>
    let P1096 = _prefixId.prefix "P1096"
    /// <summary>
    ///   <para>rdfs:label : tiene nota de diferentes edicionesrdfs:label : has note on different editions</para>
    ///   <para>skos:definition : Relates a resource to a note on the name of another edition or editions.skos:definition : Relaciona un recurso con una nota sobre el nombre de otra edición o ediciones.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnDifferentEditions</para>
    ///   <para>skos:scopeNote : Used when the resource is one of two or more simultaneously published editions differing in partial content or language. A general note is used if the name of the other edition or editions is not readily available, or the resource is published in more editions than can be named conveniently.skos:scopeNote : Se utiliza cuando el recurso es una de dos o más ediciones publicadas simultáneamente, que difieren parcialmente en el contenido o en la lengua. Se emplea una nota general si no está disponible el nombre de la otra edición o ediciones, o si el recurso se publica en más ediciones que pueden nombrarse convenientemente.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1097">isbd:P1097</a>
    /// </summary>
    let P1097 = _prefixId.prefix "P1097"
    /// <summary>
    ///   <para>skos:scopeNote : Includes facsimile reproductions or other photographic (or micro-) reproductions of a printed title, sound cassette copies of a sound disc, videotape reproductions of a motion picture, digitisations. Includes the frequency of the original resource.skos:scopeNote : Se incluyen reproducciones facsimilares u otras reproducciones fotográficas o micro-reproducciones de un título impreso, copias en cassette de un disco de sonoro, reproducciones en cita de vídeo de una película, digitalizaciones. Se incluye la frecuencia del recurso original.</para>
    ///   <para>skos:definition : Relaciona un recurso que es una reproducción exacta de otro recurso con una nota sobre el título del recurso original (cuando es diferente del de la reproducción) y sus datos de publicación.skos:definition : Relates a resource that is is an exact reproduction of another resource to a note on the title of the original resource (when different from the title of the reproduction) and its publication details.</para>
    ///   <para>rdfs:label : has note on reproductionrdfs:label : tiene nota de reproducción</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnReproduction</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1098">isbd:P1098</a>
    /// </summary>
    let P1098 = _prefixId.prefix "P1098"
    /// <summary>
    ///   <para>rdfs:label : has note on relationship to other resourcesrdfs:label : tiene nota de relación con otros recursos</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnRelationshipToOtherResources</para>
    ///   <para>skos:definition : Relaciona un recurso con una nota de relación con otros recursos.skos:definition : Relates a resource to a note on relationship to other resources.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1099">isbd:P1099</a>
    /// </summary>
    let P1099 = _prefixId.prefix "P1099"
    /// <summary>
    ///   <para>skos:scopeNote : A general note about the existence of supplements is used when they are numerous.skos:scopeNote : Se utiliza una nota general sobre la existencia de suplementos cuando sean muy numerosos.</para>
    ///   <para>rdfs:label : tiene nota de suplementos, insertos, etc.rdfs:label : has note on supplements, inserts, etc.</para>
    ///   <para>skos:definition : Relates a resource that has one or more supplements and/or inserts to a note on the title, the key title and ISSN of the supplement and/or insert.skos:definition : Relaciona un recurso que tiene uno o más suplementos y/o insertos con una nota sobre el título, el título clave e ISSN del suplemento y/o el inserto.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnSupplementsInsertsEtc</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1100">isbd:P1100</a>
    /// </summary>
    let P1100 = _prefixId.prefix "P1100"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a continuing resource to a note on a continuing resource that it is related to.skos:definition : Relaciona un recurso que es un recurso continuado con una nota sobre otro recurso continuado con el que está relacionado.</para>
    ///   <para>rdfs:label : tiene nota de relación entre recursos continuadosrdfs:label : has note on relationship between continuing resources</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnRelationshipBetweenContinuingResources</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1101">isbd:P1101</a>
    /// </summary>
    let P1101 = _prefixId.prefix "P1101"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement including notes on any descriptive information that has not been given in other areas of the description.skos:definition : Relaciona un recurso con una mención que incluye notas sobre cualquier información descriptiva que no se haya dado en otras áreas de la descripción.</para>
    ///   <para>rdfs:label : tiene área de notasrdfs:label : has note area</para>
    ///   <para>skos:scopeNote : Se utiliza cuando se considera de importancia para los usuarios de los registros bibliográficos.skos:scopeNote : Used when considered to be important to users of bibliographic records.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteArea</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1107">isbd:P1107</a>
    /// </summary>
    let P1107 = _prefixId.prefix "P1107"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelNumberingSystem</para>
    ///   <para>skos:definition : Relaciona un recurso que es una publicación seriada con la designación del fascículo o parte que aparece en la lengua y escritura del título propiamente dicho, cuando existen designaciones en más de una lengua o escritura.skos:definition : Relates a resource that is a serial to the designation appearing in the language and script of the title proper when there are designations in more than one language or script on the issue or part.</para>
    ///   <para>skos:scopeNote : Si no es aplicable el criterio de la definición, se utiliza la primera designación que aparece. También se pueden dar las designaciones paralelas.skos:scopeNote : If the criterion in the definition does not apply, the first designation is used. The parallel designations may also be given.</para>
    ///   <para>rdfs:label : has parallel numbering system rdfs:label : tiene sistema paralelo de numeración</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1116">isbd:P1116</a>
    /// </summary>
    let P1116 = _prefixId.prefix "P1116"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con el título de una obra individual cuando el recurso se compone de dos o más obras sin título colectivo.skos:definition : Relates a resource to the title of an individual work when the resource comprises two or more works without a collective title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfIndividualWorkBySameAuthor</para>
    ///   <para>rdfs:label : has title of individual work by same authorrdfs:label : tiene título de obra individual del mismo autor</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1117">isbd:P1117</a>
    /// </summary>
    let P1117 = _prefixId.prefix "P1117"
    /// <summary>
    ///   <para>rdfs:label : has title of individual work by different authorrdfs:label : tiene título de obra individual de diferente autor</para>
    ///   <para>skos:definition : Relaciona un recurso con el título de una obra individual cuando el recurso se compone de dos o más obras con diferentes menciones de responsabilidad sin título colectivo.skos:definition : Relates a resource to the title of an individual work when the resource comprises two or more works with different statements of responsibility without a collective title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfIndividualWorkByDifferentAuthor</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1118">isbd:P1118</a>
    /// </summary>
    let P1118 = _prefixId.prefix "P1118"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is notated music to an equivalent of a music format statement (a term or phrase representing the physical form in which it is presented) in another language or script and presented as equivalent.skos:definition : Relaciona un recurso que es música notada con un equivalente en otra lengua lengua o escritura de la mención de formato musical (un término o frase que representa la forma física en la que se presenta).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelMusicFormatStatement</para>
    ///   <para>rdfs:label : has parallel music format statementrdfs:label : tiene mención de formato musical paralela</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1119">isbd:P1119</a>
    /// </summary>
    let P1119 = _prefixId.prefix "P1119"
    /// <summary>
    ///   <para>skos:scopeNote : Normally, the serial carries a designation, such as "new series", "second series", etc., to indicate that a new sequence of numbering, not a new serial, is intended. The designation of the new sequence, if any, is included. The numbering system can include a numeral, a letter, any other character, or the combination of these, with or without an accompanying word ("volume", "number", etc.), and, or, a chronological designation.skos:scopeNote : Generalmente, la publicación seriada lleva una designación, como “nueva serie”, “segunda serie”, etc.., con la que se indica una nueva secuencia de numeración, no una nueva publicación. Se incluye, si existe, la designación de la nueva secuencia. El sistema de numeración puede incluir un numeral, una letra o cualquier otro carácter, o una combinación de ellos, con o sin una palabra que lo acompañe (“volumen, número, etc.) y/o una designación cronológica.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSubsequentNumberingSystem</para>
    ///   <para>skos:definition : Relaciona un recurso que es una publicación seriada con una nueva secuencia de numeración (la identificación de cada uno de los sucesivos fascículos o partes).skos:definition : Relates a resource that is a serial to a new sequence of numbering (the identification of each of the successive issues or parts).</para>
    ///   <para>rdfs:label : has subsequent numbering systemrdfs:label : tiene sistema sucesivo de numeración</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1120">isbd:P1120</a>
    /// </summary>
    let P1120 = _prefixId.prefix "P1120"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelNameOfPublisherProducerDistributor</para>
    ///   <para>rdfs:label : tiene nombre paralelo de editor, productor, distribuidorrdfs:label : has parallel name of publisher, producer, distributor</para>
    ///   <para>skos:definition : Relates a resource to the form of name of the publisher, producer and/or distributor in the language and script of the title proper when the name appears on the prescribed source of information for the resource in more than one language or script.skos:definition : Relaciona un recurso con la forma del nombre del editor, productor y/o distribuidor en la lengua y escritura del título propiamente dicho cuando dicho nombre aparece en la fuente prescrita de información en más de una lengua o escritura.</para>
    ///   <para>skos:scopeNote : If the criterion in the definition does not apply, the form of name made prominent by typography or, if there is no typographical distinction, the form of name that appears first is used.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1121">isbd:P1121</a>
    /// </summary>
    let P1121 = _prefixId.prefix "P1121"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasBibliographicFormatOfOlderMonographicResource</para>
    ///   <para>rdfs:label : tiene formato bibliográfico de recurso monográfico antiguordfs:label : has bibliographic format of older monographic resource</para>
    ///   <para>skos:definition : Relaciona un recurso que es un recurso monográfico antiguo con una designación normalizada elegida por la agencia de catalogación.skos:definition : Relates a resource that is an older monographic resource to a standard designation as chosen by the cataloguing agency.</para>
    ///   <para>skos:scopeNote : Por ejemplo: 1º, 2º, 4º, 8º, 12º, etc. Incluye la altura de la cubierta exterior de la publicación, medida paralelamente al lomo, o la del recurso cuando no está encuadernado, si se puede establecer que el recurso tiene una encuadernación normalizada del editor. Incluye el formato supuesto, seguido de interrogación, cuando no se ha podido determinar el formato. Se excluyen las dimensiones si no se puede establecer que el recurso tiene la encuadernación o envoltorio normalizado por el editor.skos:scopeNote : e.g. 1 °, 2 °, 4 °, 8 °, 12 °, etc. Includes the height of the outer case, measured parallel to the spine, or of the resource when it is not bound, if it can be established that the resource is in a standardized publisher's binding or in publisher's wrappers. Includes the assumed format followed by a question mark when the format cannot be determined. Excludes dimensions if it cannot be established that the resource is in a standardized publisher's binding or in publisher's wrappers.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1122">isbd:P1122</a>
    /// </summary>
    let P1122 = _prefixId.prefix "P1122"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a supplement to or insert in another resource to a note of the title, the key title and ISSN of the main resource.skos:definition : Relaciona un recurso que es un suplemento de o un inserto en otro recurso con una nota del título, título clave e ISSN del recurso principal.</para>
    ///   <para>rdfs:label : has note on supplement to or insert inrdfs:label : tiene nota de suplemento a o de insertado en</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnSupplementToOrInsertIn</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1123">isbd:P1123</a>
    /// </summary>
    let P1123 = _prefixId.prefix "P1123"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note on other relationships between it and other resources, including the nature of the relationship, the title, the key title and ISSN of the other resource or resources.skos:definition : Relaciona un recurso con una nota sobre otras relaciones entre él y otros recursos, incluyendo la naturaleza de la relación, el título, título clave e ISSN del otro recurso o recursos.</para>
    ///   <para>rdfs:label : has note on other relationshipsrdfs:label : tiene nota de otras relaciones</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnOtherRelationships</para>
    ///   <para>skos:scopeNote : Incluye recursos publicados conjuntamente y descritos por separado.skos:scopeNote : Includes resources published together and described separately.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1124">isbd:P1124</a>
    /// </summary>
    let P1124 = _prefixId.prefix "P1124"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of its identifier.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasResourceIdentifierStatement</para>
    ///   <para>rdfs:label : has resource identifier statement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1125">isbd:P1125</a>
    /// </summary>
    let P1125 = _prefixId.prefix "P1125"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a still image to details on the process or method of reproduction.skos:definition : Relaciona un recurso que es una imagen fija con los detalles del proceso o método de reproducción.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasProcessOrMethodOfReproductionOfStillImage</para>
    ///   <para>rdfs:label : has process or method of reproduction of still imagerdfs:label : tiene proceso o método de reproducción de imagen fija</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1126">isbd:P1126</a>
    /// </summary>
    let P1126 = _prefixId.prefix "P1126"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to its playing speed.skos:definition : Relaciona un recurso con su velocidad de reproducción.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlayingSpeed</para>
    ///   <para>rdfs:label : has playing speedrdfs:label : tiene velocidad de reproducción</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1127">isbd:P1127</a>
    /// </summary>
    let P1127 = _prefixId.prefix "P1127"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is an analogue sound disc to its recording method.skos:definition : Relaciona un recurso que es un disco sonoro analógico con su método de grabación.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRecordingMethod</para>
    ///   <para>rdfs:label : has recording methodrdfs:label : tiene método de grabación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1128">isbd:P1128</a>
    /// </summary>
    let P1128 = _prefixId.prefix "P1128"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is an analogue sound disc to its groove direction.skos:definition : Relaciona un recurso que es un disco sonoro analógico con la dirección del surco.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGrooveDirection</para>
    ///   <para>rdfs:label : has groove directionrdfs:label : tiene dirección del surco</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1129">isbd:P1129</a>
    /// </summary>
    let P1129 = _prefixId.prefix "P1129"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is an analogue sound disc to its groove size.skos:definition : Relaciona un recurso que es un disco sonoro analógico con el tamaño del surco.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGrooveSize</para>
    ///   <para>rdfs:label : has groove sizerdfs:label : tiene tamaño del surco</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1130">isbd:P1130</a>
    /// </summary>
    let P1130 = _prefixId.prefix "P1130"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the number of its tape tracks.skos:definition : Relaciona un recurso con el número de sus pistas.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberOfTapeTracks</para>
    ///   <para>rdfs:label : has number of tape tracksrdfs:label : tiene número de pistas</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1131">isbd:P1131</a>
    /// </summary>
    let P1131 = _prefixId.prefix "P1131"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a sound reel recorded on four or more tracks to its track configuration.skos:definition : Relaciona un recurso que es un rollo sonoro grabado en cuatro o más pistas con la configuración de sus pistas.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTrackConfiguration</para>
    ///   <para>rdfs:label : has track configurationrdfs:label : tiene configuración de pistas</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1132">isbd:P1132</a>
    /// </summary>
    let P1132 = _prefixId.prefix "P1132"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the number of its sound channels.skos:definition : Relaciona un recurso con el número de sus canales de sonido.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberOfSoundChannels</para>
    ///   <para>rdfs:label : has number of sound channelsrdfs:label : tiene número de canales de sonido</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1133">isbd:P1133</a>
    /// </summary>
    let P1133 = _prefixId.prefix "P1133"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the equalization it employs.skos:definition : Relaciona un recurso con la ecualización que emplea.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEqualization</para>
    ///   <para>rdfs:label : has equalizationrdfs:label : tiene ecualización</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1134">isbd:P1134</a>
    /// </summary>
    let P1134 = _prefixId.prefix "P1134"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the noise reduction it employs.skos:definition : Relaciona un recurso con la reducción de ruido que emplea.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoiseReduction</para>
    ///   <para>rdfs:label : has noise reductionrdfs:label : tiene reducción de ruido</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1135">isbd:P1135</a>
    /// </summary>
    let P1135 = _prefixId.prefix "P1135"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNoteOnContentFormAndMediaType</para>
    ///   <para>rdfs:label : has note on content form and media typerdfs:label : tiene nota sobre forma del contenido y tipo de medio</para>
    ///   <para>skos:definition : Relates a resource to a note on the content form and media type area.skos:definition : Relaciona un recurso con una nota sobre el área de forma del contenido y tipo de medio.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1136">isbd:P1136</a>
    /// </summary>
    let P1136 = _prefixId.prefix "P1136"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCommonTitleOfTitleProper</para>
    ///   <para>skos:scopeNote : El título común sirve para indicar esta relación de un grupo de recursos y, junto con el título de sección, identifica un recurso dado. El título común también puede ser común a un recurso principal y su suplemento o suplementos y a una serie principal y sus subseries cuando el suplemento o suplementos o las subseries tienen un título o títulos dependientes.skos:scopeNote : The common title serves to indicate this relationship in a group of resources and together with the section title identifies a given resource. The common title may also be common to a main resource and its supplement or supplements and to a main series and its subseries when the supplement or supplements or subseries have a dependent title or titles.</para>
    ///   <para>rdfs:label : tiene título común de título propiamente dichordfs:label : has common title of title proper</para>
    ///   <para>skos:definition : Relates a resource to that part of the title that is carried by a group of related resources in addition to their different section titles.skos:definition : Relaciona un recurso con aquella parte del título que es común a un grupo de recursos relacionados que tienen además sus diferentes títulos de sección.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1137">isbd:P1137</a>
    /// </summary>
    let P1137 = _prefixId.prefix "P1137"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleOfTitleProper</para>
    ///   <para>skos:scopeNote : Ejemplos de esto son los títulos de sección, algunos títulos de hojas individuales de series de mapas, algunos títulos de suplementos, algunos títulos de subseries y los títulos de algunas partes de un recurso monográfico multiparte.skos:scopeNote : Examples are section titles, some titles of individual sheets of a map series, some supplement titles and some titles of subseries and the titles of some parts of a multipart monographic resource.</para>
    ///   <para>skos:definition : Relates a resource to a title that by itself is insufficient to identify the resource and that requires the addition of the common title, or the title of the main resource or the title of the main series.skos:definition : Relaciona un recurso con un título que por sí mismo es insuficiente para identificar el recurso y que requiere la adición del título común, o del título del recurso principal o del título de la serie principal.</para>
    ///   <para>rdfs:label : has dependent title of title properrdfs:label : tiene título dependiente de título propiamente dicho</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1138">isbd:P1138</a>
    /// </summary>
    let P1138 = _prefixId.prefix "P1138"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering that alone or in conjunction with a dependent title serves to distinguish it from one or more related resources having a common title.skos:definition : Relaciona un recurso con la numeración que por sí sola o en conjunción con un título dependiente sirve para distinguirlo de uno o más recursos relacionados que tienen un título común.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleDesignationOfTitleProper</para>
    ///   <para>rdfs:label : has dependent title designation of title properrdfs:label : tiene designación de título dependiente de título propiamente dicho</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1139">isbd:P1139</a>
    /// </summary>
    let P1139 = _prefixId.prefix "P1139"
    /// <summary>
    ///   <para>rdfs:label : tiene información complementaria del título paralelardfs:label : has parallel other title information</para>
    ///   <para>skos:definition : Relates a resource to other title information presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con información complementaria del título que se presenta en la fuente de información preferida para el recurso como un equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelOtherTitleInformation</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1140">isbd:P1140</a>
    /// </summary>
    let P1140 = _prefixId.prefix "P1140"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility  presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con una mención de responsabilidad que se presenta en la fuente de información preferida para el recurso como un equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelStatementOfResponsibilityRelatingToTitle</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to titlerdfs:label : tiene mención de responsabilidad paralela al título</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1141">isbd:P1141</a>
    /// </summary>
    let P1141 = _prefixId.prefix "P1141"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of an edition of a work contained in the resource, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con uno o más nombres, frases o grupos de caracteres relativos a la identificación y/o función de cualquier persona o entidad corporativa responsable de o que contribuye a la creación o realización del contenido intelectual o artístico de una edición de una obra contenida en el recurso, que se presenta en la fuente de información preferida para el recurso y que se muestra como equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelStatementOfResponsibilityRelatingToEdition</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to editionrdfs:label : tiene mención de responsabilidad paralela relativa a edición</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1142">isbd:P1142</a>
    /// </summary>
    let P1142 = _prefixId.prefix "P1142"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word or phrase, or a group of characters, indicating that a resource belongs to an edition presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con una palabra o frase, o grupo de caracteres que indican que el recurso pertenece a una edición que se presenta en la fuente de información preferida para el recurso y que se muestra como equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelAdditionalEditionStatement</para>
    ///   <para>rdfs:label : has parallel additional edition statementrdfs:label : tiene mención de edición adicional paralela</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1143">isbd:P1143</a>
    /// </summary>
    let P1143 = _prefixId.prefix "P1143"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of a larger place such as a country, state, etc. and, if it is considered necessary for identification, the full address of the publisher, producer or distributor.skos:definition : Relaciona un recurso con el nombre de un lugar de mayor rango, como un país, estado, etc., y, si se considera necesario para su identificación, la dirección completa del editor, productor o distribuidor.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAdditionToPlaceOfPublication</para>
    ///   <para>rdfs:label : has addition to place of publicationrdfs:label : tiene adición al lugar de publicación</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1144">isbd:P1144</a>
    /// </summary>
    let P1144 = _prefixId.prefix "P1144"
    /// <summary>
    ///   <para>skos:scopeNote : If the criterion in the definition does not apply, the form of name made prominent by typography or, if there is no typographical distinction, the form of name that appears first is used.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelPaceOfPublicationProductionDistribution</para>
    ///   <para>skos:definition : Relaciona un recurso con el nombre de un lugar de publicación, producción y/o distribución en la lengua y escritura del título propiamente dicho cuando el nombre aparece en la fuente prescrita de información para el recurso en más de una lengua o escritura.skos:definition : Relates a resource to the name of the place of publication, production and/or distribution in the language and script of the title proper when the name appears on the prescribed source of information for the resource in more than one language or script.</para>
    ///   <para>rdfs:label : has parallel place of publication, production, distributionrdfs:label : tiene lugar paralelo de publicación, producción, distribución</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1145">isbd:P1145</a>
    /// </summary>
    let P1145 = _prefixId.prefix "P1145"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a term indicating the specific class of material (usually the class of physical object) to which it belongs, and the number of units.skos:definition : Relaciona un recurso con un término que indica la clase específica de material (generalmente la clase de objeto físico) al que pertenece, y el número de unidades.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSpecificMaterialDesignation</para>
    ///   <para>rdfs:label : has specific material designationrdfs:label : tiene designación específica del material</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1146">isbd:P1146</a>
    /// </summary>
    let P1146 = _prefixId.prefix "P1146"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to that part of the title that is carried by a group of related resources in addition to their different section titles.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con aquella parte del título que es común a un grupo de recursos relacionados que tienen también sus títulos de sección diferentes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCommonTitleOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has common title of series or multipart monographic resourcerdfs:label : tiene título común de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1147">isbd:P1147</a>
    /// </summary>
    let P1147 = _prefixId.prefix "P1147"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a title that by itself is insufficient to identify the resource and that requires the addition of the common title, or the title of the main resource or the title of the main series.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con un título que por sí mismo es insuficiente para identificar el recurso y que requiere la adición del título común, o el título del recurso principal o el título de la serie principal.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has dependent title of series or multipart monographic resourcerdfs:label : tiene título dependiente de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1148">isbd:P1148</a>
    /// </summary>
    let P1148 = _prefixId.prefix "P1148"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to numbering that alone or in conjunction with a dependent title serves to distinguish one of two or more related resources having a common title.skos:definition : Relaciona un recurso que es una serie o recurso monográfico multiparte con una numeración que por sí sola o en conjunción con un título dependiente sirve para distinguir uno de dos o más recursos relacionados que tienen un título común.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleDesignationOfSeriesOrMultipartMonogaphicResource</para>
    ///   <para>rdfs:label : has dependent title designation of series or multipart monographic resourcerdfs:label : tiene designación de título dependiente de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1149">isbd:P1149</a>
    /// </summary>
    let P1149 = _prefixId.prefix "P1149"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a qualification to a statement of the price if it is for sale or a brief statement of other terms if it is not for sale.skos:definition : Relaciona un recurso con una aclaración sobre una mención del precio, si está a la venta, o, si no lo está, una breve mención sobre otras condiciones de disponibilidad.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasQualificationToTermsOfAvailability</para>
    ///   <para>rdfs:label : has qualification to terms of availabilityrdfs:label : tiene aclaración a condición de disponibilidad </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1150">isbd:P1150</a>
    /// </summary>
    let P1150 = _prefixId.prefix "P1150"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of a larger place such as a country, state, etc. and, if it is considered necessary for identification, the full address of the publisher, producer or distributor, in the language and script of the title proper when the name appears on the prescribed source of information for the resource in more than one language or script.skos:definition : Relaciona un recurso con el nombre de un lugar de mayor rango como por ejemplo, páis, estado, etc., y, si se considera necesario para la identificación, la dirección completa del editor, productor o distribuidor, en la lengua y escritura del título propiamente dicho cuando el nombre aparece en la fuente prescrita de información para el recurso en más de una lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAdditionToParallelPlaceOfPublication</para>
    ///   <para>rdfs:label : has addition to parallel place of publicationrdfs:label : tiene adición al lugar de publicación paralelo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1151">isbd:P1151</a>
    /// </summary>
    let P1151 = _prefixId.prefix "P1151"
    /// <summary>
    ///   <para>rdfs:label : tiene información complementaria del título paralela de serie o de recurso monográfico multiparte rdfs:label : has parallel other title information of series or multipart monographic resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelOtherTitleInformationOfSeriesOrMultipartMonographicResource</para>
    ///   <para>skos:definition : Relates a resource that is a serial or multipart monographic resource to a word or phrase, or a group of characters, appearing in conjunction with, and subordinate to, the title proper of the resource presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso que es una publicación seriada o recurso monográfico multiparte con una palabra o frase o grupo de caracteres, que aparecen en conjunción con y subordinado al título propiamente dicho del recurso,  presentado en la fuente de información preferida para el recurso como un equivalente en otra lengua o escritura.</para>
    ///   <para>skos:scopeNote : La información complementaria del título paralela se da cuando se considera importante para los usuarios del catálogo.skos:scopeNote : Parallel other title information  is given when considered important to users of the catalogue.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1152">isbd:P1152</a>
    /// </summary>
    let P1152 = _prefixId.prefix "P1152"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to one or more names, phrases, or groups of characters relating to the identification and/or function of any persons or corporate bodies responsible for or contributing to the creation or realisation of the intellectual or artistic content of a work contained in the resource, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso que es una publicación seriada o recurso monográfico multiparte con uno o más nombres, frases, o grupos de caracteres relativos a la identificación y/o función de cualquier persona o entidad corporativa responsable de contribuir a la creación o realización del contenido intelectual o artístico de una obra contenida en el recurso, presentada en la fuente de información preferida para el recurso como equivalente en otra lengua o escritura.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelStatementOfResponsibilityOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel statement of responsibility of series or multipart monographic resourcerdfs:label : tiene mención de responsabilidad paralela de serie o recurso monográfico multiparte </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1153">isbd:P1153</a>
    /// </summary>
    let P1153 = _prefixId.prefix "P1153"
    /// <summary>
    ///   <para>rdfs:label : has standard identifierrdfs:label : tiene identificador normalizado</para>
    ///   <para>skos:scopeNote : Customary labels include "ISBN", "ISSN", "ISMN".skos:scopeNote : Como etiquetas convencionales se incluyen “ISBN”, “ISSN”, “ISMN”.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStandardIdentifier</para>
    ///   <para>skos:definition : Relates a resource to a standard identifier preceded by its customary label.skos:definition : Relaciona un recurso con un identificador normalizado precedido de su etiqueta convencional.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1154">isbd:P1154</a>
    /// </summary>
    let P1154 = _prefixId.prefix "P1154"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLongitudeAndLatitude</para>
    ///   <para>rdfs:label : tiene longitud y latitudrdfs:label : has longitude and latitude</para>
    ///   <para>skos:definition : Relates a resource that is a  terrestrial map to its coordinates expressed in decimal degrees or degrees (°), minutes (′) and seconds (″) of the sexagesimal system (360° circle) (with longitude always taken from the Greenwich prime meridian) in the order of longitude of westernmost extent, longitude of easternmost extent, latitude of northernmost extent , and latitude of southernmost extent, preceded by the appropriate initials for West (W), East (E), North (N) and South (S) or their equivalents in another language or script. Relates a resource that is a map of another celestial body to its coordinates in its coordinate system.skos:definition : Relaciona un recurso que es un mapa terrestre con sus coordenadas expresadas en grados decimales o en grados (º), minutos (´) y segundos (´´) del sistema sexagesimal (círculo de 360º) (con la longitud tomada siempre a partir del meridiano cero de Greeenwich) en el orden: punto de longitud más occidental, punto de longitud más oriental, latitud del punto más septentrional y latitud del punto más meridional, precedido por las iniciales apropiadas Oeste (O), Este (E), Norte (N) y Sur (S) o sus equivalentes en otra lengua o escritura. Relaciona un recurso que es un mapa de un cuerpo celeste con sus coordenadas en su sistema correspondiente.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1155">isbd:P1155</a>
    /// </summary>
    let P1155 = _prefixId.prefix "P1155"
    /// <summary>
    ///   <para>skos:scopeNote : A numeric designation is given as it appears, except that arabic numerals are given in place of other numerals or spelled-out numbers and multiple levels of numbering are given in a hierarchical order. A numeric designation may include alphabetic or other characters as well as numbers. Words in the designation may be abbreviated.skos:scopeNote : Una designación numérica se da tal y como aparezca, excepto que se dan números arábigos en lugar de números no arábigos o números expresados textualente y  numeraciones en múltiples niveles que sean dadas en order jerárquico. Una designación numérica puede incluir letras u otros caracteres además de números. Las palabras de la designación pueden abreviarse.</para>
    ///   <para>rdfs:label : tiene designación  numéricardfs:label : has numeric designation</para>
    ///   <para>skos:definition : Relaciona un recurso que es una publicación seriada con su designación numérica.skos:definition : Relates a resource that is a serial to its numeric designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumericDesignation</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1156">isbd:P1156</a>
    /// </summary>
    let P1156 = _prefixId.prefix "P1156"
    /// <summary>
    ///   <para>skos:scopeNote : Las palabras en la designación pueden abreviarse.skos:scopeNote : Words in the designation may be abbreviated.</para>
    ///   <para>rdfs:label : has chronological designationrdfs:label : tiene designación cronológica</para>
    ///   <para>skos:definition : Relaciona un recurso que es una publicación seriada con su designación cronológica.skos:definition : Relates a resource that is a serial to its chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasChronologicalDesignation</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1157">isbd:P1157</a>
    /// </summary>
    let P1157 = _prefixId.prefix "P1157"
    /// <summary>
    ///   <para>rdfs:label : has content form and media type areardfs:label : tiene área de forma del contenido y de tipo de medio</para>
    ///   <para>skos:definition : Relaciona un recurso con una mención que comprende tres elementos, cada uno tomado de listas cerradas: la forma del contenido, que son uno o más términos que reflejan la forma o formas fundamentales en que se expresa el contenido del recurso; la calificación del contenido, que especifica el tipo, naturaleza sensorial, dimensiones y/o la presencia/ausencia de movimiento en el recurso que se describe; y el tipo de medio, que indica el tipo o tipos de soporte utilizados para transmitir el contenido del recurso.skos:definition : Relates a resource to one or more statements each comprising three elements, each taken from closed lists: the content form, one or more terms reflecting the fundamental form or forms in which the content of a resource is expressed; the content qualification, specifying the type, sensory nature, dimensionality, and/or presence or absence of motion for the resource being described; and  the media type, indicating the type or types of carrier used to convey the content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContentFormAndMediaTypeArea</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1158">isbd:P1158</a>
    /// </summary>
    let P1158 = _prefixId.prefix "P1158"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleAndStatementOfResponsibilityArea</para>
    ///   <para>skos:definition : Relates a resource to a statement including the title proper, parallel titles, other title information, and statements of responsibility.skos:definition : Relaciona un recurso con una mención que incluye el título propiamente dicho, títulos paralelos, información complementaria del título y menciones de responsabilidad.</para>
    ///   <para>rdfs:label : tiene área de título y mención de responsabilidadrdfs:label : has title and statement of responsibility area</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1159">isbd:P1159</a>
    /// </summary>
    let P1159 = _prefixId.prefix "P1159"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEditionArea</para>
    ///   <para>skos:definition : Relates a resource to a statement including the edition statement, parallel edition statements, statements of responsibility relating to the edition, additional edition statements, and statements of responsibility following an additional edition statement.skos:definition : Relaciona un recurso con una mención que incluye la mención de edición, menciones de edición paralela, menciones de responsabilidad relativas a la edición, menciones de edición adicional y menciones de responsabilidad relativas a la mención de edición adicional.</para>
    ///   <para>rdfs:label : has edition areardfs:label : tiene área de edición</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1160">isbd:P1160</a>
    /// </summary>
    let P1160 = _prefixId.prefix "P1160"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMaterialOrTypeOfResourceSpecificArea</para>
    ///   <para>skos:definition : Relaciona un recurso con una mención que incluye datos que son exclusivos de una clase particular de material o tipo de recurso.skos:definition : Relates a resource to a statement including data that are unique to a particular class of material or type of resource.</para>
    ///   <para>rdfs:label : has material or type of resource specific areardfs:label : tiene área específica de material o tipo de recurso</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1161">isbd:P1161</a>
    /// </summary>
    let P1161 = _prefixId.prefix "P1161"
    /// <summary>
    ///   <para>skos:scopeNote : Cubre todos los tipos de publicación, producción, distribución, edición y actividades de difusión relacionadas con los recursos.skos:scopeNote : Covers all types of publication, production, distribution, issuing and release activities connected with resources.</para>
    ///   <para>rdfs:label : has publication, production, distribution, etc areardfs:label : tiene área de publicación, producción, distribución, etc.</para>
    ///   <para>skos:definition : Relates a resource to a statement including the place of publication, production and/or distribution; the name of publisher, producer, and/or distributor; the date of publication, production, and/or distribution; the place of printing or manufacture; the name of printer or manufacturer; and the date of printing or manufacture.skos:definition : Relaciona un recurso con una mención que incluye el lugar de publicación, producción y/o distribución; el nombre del editor, productor y/o distribuidor; la fecha de publicación, producción y/o distribución; el lugar de impresión o fabricación; el nombre del  impresor o fabricante, y la fecha de impresión o fabricación.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPublicationProductionDistributionEtcArea</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1162">isbd:P1162</a>
    /// </summary>
    let P1162 = _prefixId.prefix "P1162"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement including the specific material designation and extent, other physical details, the dimensions, and the accompanying material statement.skos:definition : Relaciona un recurso con una mención que incluye la designación específica del material y la extensión, otros detalles físicos, dimensiones y la mención de material anejo.</para>
    ///   <para>rdfs:label : has material description areardfs:label : tiene área de descripción del material</para>
    ///   <para>skos:scopeNote : Restricted to the resource as issued by the publisher.skos:scopeNote : Restringido al recurso tal y como lo publica el editor.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMaterialDescriptionArea</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1163">isbd:P1163</a>
    /// </summary>
    let P1163 = _prefixId.prefix "P1163"
    /// <summary>
    ///   <para>rdfs:label : has series and multipart monographic resource areardfs:label : tiene área de serie y recurso monográfico multiparte</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSeriesAndMultipartMonographicResourceArea</para>
    ///   <para>skos:definition : Relaciona un recurso con una mención que incluye el título propiamente dicho de una serie o recurso monográfico multiparte, el título paralelo de la serie o recurso monográfico multiparte, la información complementaria del título de la serie o recurso monográfico multiparte, la información complementaria del título paralela de la serie o recurso monográfico multiparte, la mención de resposabilidad relativa a la serie o recurso monográfico multiparte, la mención de resposabilidad paralela de la serie o recurso monográfico multiparte, el numero internacional normalizado de la serie o recurso monográfico multiparte y la numeración de la serie o recurso monográfico multiparte.skos:definition : Relates a resource to a statement including the title proper of a series or multipart monographic resource, the parallel title of a series or multipart monographic resource, the other title information of a series or multipart monographic resource, the parallel other title information of a series or multipart monographic resource, the statement of responsibility relating to a series or multipart monographic resource, the parallel statement of responsibility relating to a series or multipart monographic resource, the international standard number of a series or multipart monographic resource, and the numbering within a series or multipart monographic resource.</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1164">isbd:P1164</a>
    /// </summary>
    let P1164 = _prefixId.prefix "P1164"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una mención que incluye el identificador del recurso, el título clave y las condiciones de disponibilidad.skos:definition : Relates a resource to a statement including the resource identifier, the key title, and the terms of availability.</para>
    ///   <para>rdfs:label : has resource identifier and terms of availability areardfs:label : tiene área de identificador del recurso y condiciones de disponibilidad</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasResourceIdentifierAndTermsOfAvailabilityArea</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1165">isbd:P1165</a>
    /// </summary>
    let P1165 = _prefixId.prefix "P1165"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMusicFormatStatementArea</para>
    ///   <para>skos:definition : Relaciona un recurso que es música notada con una mención que incluye la mención de formato musical y las menciones de formato musical paralelas.skos:definition : Relates a resource that is notated music to a statement including the music format statement and parallel music format statements.</para>
    ///   <para>rdfs:label : tiene área de mención de formato musicalrdfs:label : has music format statement area</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1166">isbd:P1166</a>
    /// </summary>
    let P1166 = _prefixId.prefix "P1166"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement including the place of printing or manufacture, the name of printer or manufacturer, and the date of printing or manufacture.skos:definition : Relaciona un recurso con una mención que incluye el lugar de impresión o fabricación, el nombre del impresor o fabricante y la fecha de impresión o fabricación.</para>
    ///   <para>rdfs:label : has statement of printing or manufacturerdfs:label : tiene mención de impresión o fabricación</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfPrintingOrManufacture</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1167">isbd:P1167</a>
    /// </summary>
    let P1167 = _prefixId.prefix "P1167"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfPublicationProductionDistributionStatement</para>
    ///   <para>skos:definition : Relaciona un recurso con una mención que incluye el lugar de publicación, producción, distribución, la mención de lugar de publicación adicional y la mención de lugar de publicación paralela.skos:definition : Relates a resource to a statement including the place of publication, production, distribution, the additional place of publication statement, and the parallel statement of place of publication.</para>
    ///   <para>rdfs:label : has place of publication, production, distribution statementrdfs:label : tiene mención de lugar de publicación, producción o distribución</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1168">isbd:P1168</a>
    /// </summary>
    let P1168 = _prefixId.prefix "P1168"
    /// <summary>
    ///   <para>rdfs:label : tiene mención del nombre del editor, productor o distribuidorrdfs:label : has name of publisher, producer, distributor statement</para>
    ///   <para>skos:definition : Relaciona un recurso con una mención que incluye el nombre del editor, productor, distribuidor y la mención de editor, productor, distribuidor paralela.skos:definition : Relates a resource to a statement including the name of publisher, producer, distributor, and the parallel statement of publisher, producer, distributor.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameOfPublisherProducerDistributorStatement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1169">isbd:P1169</a>
    /// </summary>
    let P1169 = _prefixId.prefix "P1169"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of its title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleStatement</para>
    ///   <para>rdfs:label : has title statement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1170">isbd:P1170</a>
    /// </summary>
    let P1170 = _prefixId.prefix "P1170"
    /// <summary>
    ///   <para>rdfs:label : tiene título compueso de propiamente dichordfs:label : has compound title of title proper</para>
    ///   <para>skos:definition : Relaciona un recurso con un título propiamente dicho consistente en un título común y un título dependiente, con o sin designación de título dependiente.skos:definition : Relates a resource to the title proper consisting of a common title and a dependent title, with or without a dependent title designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCompoundTitleOfTitlePrope</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1171">isbd:P1171</a>
    /// </summary>
    let P1171 = _prefixId.prefix "P1171"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of its parallel title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelTitleStatement</para>
    ///   <para>rdfs:label : has parallel title statement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1172">isbd:P1172</a>
    /// </summary>
    let P1172 = _prefixId.prefix "P1172"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a statement of its title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleStatementOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has title statement of series or multipart monographic resource</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1173">isbd:P1173</a>
    /// </summary>
    let P1173 = _prefixId.prefix "P1173"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a statement of its parallel title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelTitleStatementOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel title statement of series or multipart monographic resource</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1174">isbd:P1174</a>
    /// </summary>
    let P1174 = _prefixId.prefix "P1174"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monograph to a title consisting of a common title and a dependent title, with or without a dependent title designation, in another language or script than the title proper and presented as an equivalent of the title proper on the prescribed source or sources of information.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelTitleCompoundOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel title (compound) of series or multipart monographic resourcerdfs:label : tiene título paralelo (compuesto) de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1177">isbd:P1177</a>
    /// </summary>
    let P1177 = _prefixId.prefix "P1177"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to that part of the title that is carried by a group of related resources in addition to their different section titles, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso que es una serie o un recurso monográfico multiparte con aquella parte del título que es común a un grupo de recursos relacionados que tienen además sus diferentes títulos de sección, presentada como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelCommonTitleOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel common title of series or multipart monographic resourcerdfs:label : tiene título común paralelo de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1178">isbd:P1178</a>
    /// </summary>
    let P1178 = _prefixId.prefix "P1178"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to a title that by itself is insufficient to identify the resource and that requires the addition of the common title, or the title of the main resource or the title of the main series, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso que es una serie o un recurso monográfico multiparte con un título que por sí mismo es insuficiente para identificar el recurso y que requiere de la adición del título común, o del título del recurso principal o del título de la serie principal, presentado como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelDependentTitleOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel dependent title of series or multipart monographic resourcerdfs:label : tiene título dependiente paralelo de serie o recurso monográfico multiparte </para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1179">isbd:P1179</a>
    /// </summary>
    let P1179 = _prefixId.prefix "P1179"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to numbering that alone or in conjunction with a dependent title serves to distinguish one of two or more related resources having a common title, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso que es una serie o un recurso monográfico multiparte con la numeración que por sí sola o en conjunción con un título dependiente sirve para distinguir un recurso de dos o más recursos relacionados que tienen un título común, presentada como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelDependentTitleDesignationOfSeriesOrMultipartMonographicResource</para>
    ///   <para>rdfs:label : has parallel dependent title designation of series or multipart monographic resourcerdfs:label : tiene designación de título dependiente paralelo de serie o recurso monográfico multiparte</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1180">isbd:P1180</a>
    /// </summary>
    let P1180 = _prefixId.prefix "P1180"
    /// <summary>
    ///   <para>rdfs:label : has compound title of parallel titlerdfs:label : tiene título compuesto de título paralelo</para>
    ///   <para>skos:definition : Relates a resource to the title proper consisting of a common title and a dependent title, with or without a dependent title designation, presented on the prescribed sources of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con un título propiamente dicho consistente en un título común y un título dependiente, con o sin designación de título dependiente, presentado como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCompoundTitleOfParallelTitle</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1181">isbd:P1181</a>
    /// </summary>
    let P1181 = _prefixId.prefix "P1181"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to that part of the title that is carried by a group of related resources in addition to their different section titles, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con aquella parte del título que es común a un grupo de recursos relacionados, que además tiene sus diferentes títulos de sección, presentado como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCommonTitleOfParallelTitle</para>
    ///   <para>rdfs:label : has common title of parallel titlerdfs:label : tiene título común de título paralelo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1182">isbd:P1182</a>
    /// </summary>
    let P1182 = _prefixId.prefix "P1182"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title that by itself is insufficient to identify the resource and that requires the addition of the common title, or the title of the main resource or the title of the main series, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con un título que por sí mismo es insuficiente para identificar el recurso y que requiere de la adición el título común, o del título del recurso principal o del título de la serie principal, presentado como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleOfParallelTitle</para>
    ///   <para>rdfs:label : has dependent title of parallel titlerdfs:label : tiene título dependiente de título paralelo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1183">isbd:P1183</a>
    /// </summary>
    let P1183 = _prefixId.prefix "P1183"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering that alone or in conjunction with a dependent title serves to distinguish it from one or more related resources having a common title, presented on the preferred source of information for the resource as an equivalent in another language or script.skos:definition : Relaciona un recurso con la numeración que por sí sola o en conjunción con un título dependiente sirve para distinguir un recurso de dos o más recursos relacionados que tienen un título común, presentada como equivalente en otra lengua o escritura en la fuente de información preferida del recurso.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDependentTitleDesignationOfParallelTitle</para>
    ///   <para>rdfs:label : has dependent title designation of parallel titlerdfs:label : tiene designación de título dependiente de título paralelo</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1184">isbd:P1184</a>
    /// </summary>
    let P1184 = _prefixId.prefix "P1184"
    /// <summary>
    ///   <para>skos:definition : Relaciona un recurso con una mención que comprende tres elementos, cada uno tomado de listas cerradas: la forma del contenido, que son uno o más términos que reflejan la forma o formas fundamentales en que se expresa el contenido del recurso; la calificación del contenido, que especifica el tipo, naturaleza sensorial, dimensiones y/o la presencia/ausencia de movimiento en el recurso que se describe; y el tipo de medio, que indica el tipo o tipos de soporte utilizados para transmitir el contenido del recurso.skos:definition : Relates a resource to a statement comprising three elements, each taken from closed lists: the content form, one or more terms reflecting the fundamental form or forms in which the content of a resource is expressed; the content qualification, specifying the type, sensory nature, dimensionality, and/or presence or absence of motion for the resource being described; and the media type, indicating the type or types of carrier used to convey the content of the resource.</para>
    ///   <para>rdfs:label : has content form and media type statementrdfs:label : tiene mención de forma del contenido y de tipo de medio</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContentFormAndMediaTypeStatement</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1185">isbd:P1185</a>
    /// </summary>
    let P1185 = _prefixId.prefix "P1185"
    /// <summary>
    ///   <para>skos:definition : Relates a resource that is a series or multipart monographic resource to the title proper consisting of a common title and a dependent title, with or without a dependent title designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleProperCompoundOfSeries</para>
    ///   <para>rdfs:label : has title proper (compound) of series</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1186">isbd:P1186</a>
    /// </summary>
    let P1186 = _prefixId.prefix "P1186"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic resource to an expression reflected in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExpressionAspect</para>
    ///   <para>rdfs:label : has expression aspect</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1190">isbd:P1190</a>
    /// </summary>
    let P1190 = _prefixId.prefix "P1190"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic resource to an item reflected in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasItemAspect</para>
    ///   <para>rdfs:label : has item aspect</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1191">isbd:P1191</a>
    /// </summary>
    let P1191 = _prefixId.prefix "P1191"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic resource to a manifestation reflected in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasManifestationAspect</para>
    ///   <para>rdfs:label : has manifestation aspect</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1192">isbd:P1192</a>
    /// </summary>
    let P1192 = _prefixId.prefix "P1192"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic resource to a work reflected in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasWorkAspect</para>
    ///   <para>rdfs:label : has work aspect</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1193">isbd:P1193</a>
    /// </summary>
    let P1193 = _prefixId.prefix "P1193"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a bibliographic resource that reflects it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isExpressionReflectedIn</para>
    ///   <para>rdfs:label : is expression reflected in</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1194">isbd:P1194</a>
    /// </summary>
    let P1194 = _prefixId.prefix "P1194"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a bibliographic resource that reflects it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isItemReflectedIn</para>
    ///   <para>rdfs:label : is item reflected in</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1195">isbd:P1195</a>
    /// </summary>
    let P1195 = _prefixId.prefix "P1195"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a bibliographic resource that reflects it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isManifestationReflectedIn</para>
    ///   <para>rdfs:label : is manifestation reflected in</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1196">isbd:P1196</a>
    /// </summary>
    let P1196 = _prefixId.prefix "P1196"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a bibliographic resource that reflects it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isWorkReflectedIn</para>
    ///   <para>rdfs:label : is work reflected in</para>
    ///   <a href="http://iflastandards.info/ns/isbd/elements/P1197">isbd:P1197</a>
    /// </summary>
    let P1197 = _prefixId.prefix "P1197"

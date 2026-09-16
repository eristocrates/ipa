#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cco =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.commoncoreontologies.org/" "cco"

    let InformationEntityOntology = _prefixId.prefix "InformationEntityOntology"
    let QualityOntology = _prefixId.prefix "QualityOntology"
    /// <summary>
    ///   <para>rdfs:label : Mass Density</para>
    ///   <para>skos:altLabel : Density</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of that bearer's mass per unit volume.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000009">cco:ont00000009</a>
    /// </summary>
    let ont00000009 = _prefixId.prefix "ont00000009"
    /// <summary>
    ///   <para>rdfs:label : Semicircular</para>
    ///   <para>skos:definition : A Shape quality inhering in a bearer in virtue of the bearer having the shape of half a circle.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000042">cco:ont00000042</a>
    /// </summary>
    let ont00000042 = _prefixId.prefix "ont00000042"
    /// <summary>
    ///   <para>rdfs:label : Green</para>
    ///   <para>skos:definition : A Color that is between Yellow and Cyan with a wavelength in the visible spectrum, typically between 520 to 560 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000082">cco:ont00000082</a>
    /// </summary>
    let ont00000082 = _prefixId.prefix "ont00000082"
    /// <summary>
    ///   <para>rdfs:label : Square</para>
    ///   <para>skos:definition : A Rectangular shape which has four equal length sides and four 90 degree angles.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000105">cco:ont00000105</a>
    /// </summary>
    let ont00000105 = _prefixId.prefix "ont00000105"
    /// <summary>
    ///   <para>rdfs:label : Translucent</para>
    ///   <para>skos:definition : An Opacity that inheres in a bearer in virtue of that bearer's capacity to transmit some but not all electromagnetic radiation of a given frequency through the bearer such that the bearer reflects, scatters, or absorbs some but not all electromagnetic radiation of that frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000112">cco:ont00000112</a>
    /// </summary>
    let ont00000112 = _prefixId.prefix "ont00000112"
    /// <summary>
    ///   <para>rdfs:label : Spatial Orientation</para>
    ///   <para>skos:altLabel : Attitude</para>
    ///   <para>skos:definition : A Relational Quality that is the angle of Rotation of an Object relative to one or more Plane of Reference or Axis of Rotation.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/wiki/Orientation_(geometry)^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000119">cco:ont00000119</a>
    /// </summary>
    let ont00000119 = _prefixId.prefix "ont00000119"
    /// <summary>
    ///   <para>rdfs:label : Blunt</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer not having a sharp edge or point.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000185">cco:ont00000185</a>
    /// </summary>
    let ont00000185 = _prefixId.prefix "ont00000185"
    /// <summary>
    ///   <para>rdfs:label : Purple</para>
    ///   <para>skos:definition : A Color that is aproximately midway between Red and Blue.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000196">cco:ont00000196</a>
    /// </summary>
    let ont00000196 = _prefixId.prefix "ont00000196"
    /// <summary>
    ///   <para>rdfs:label : Radiopaque</para>
    ///   <para>skos:altLabel : Radiodense</para>
    ///   <para>skos:definition : A Radiopacity that inheres in a bearer in virtue of its capacity to prevent most X-rays from passing through it.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000257">cco:ont00000257</a>
    /// </summary>
    let ont00000257 = _prefixId.prefix "ont00000257"
    /// <summary>
    ///   <para>rdfs:label : Albedo</para>
    ///   <para>skos:definition : A Radiation Reflectivity that inheres in a bearer in virtue of the capacity of its surface to reflect incident electromagnetic radiation of a particular wavelength.</para>
    ///   <para>skos:scopeNote : Albedo is a reflection coefficient and is measured as the ratio of radiation reflected from the surface to the incident radiation. Albedo is dimensionless, can be expressed as a percentage, and is measured on a scale from 0 for no reflection to 1 for perfect reflection of a surface. Albedo depends on the wavelength of the radiation; when no wavelength is specified, it typically refers to some appropriate average across the spectrum of visible light.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Albedo&amp;oldid=1063352646^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000281">cco:ont00000281</a>
    /// </summary>
    let ont00000281 = _prefixId.prefix "ont00000281"
    /// <summary>
    ///   <para>rdfs:label : Cylindrical</para>
    ///   <para>skos:altLabel : Columnar</para>
    ///   <para>skos:definition : A Three Dimensional Shape inhering in a bearer in virtue of the bearer having an elongated shape with round bases.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000283">cco:ont00000283</a>
    /// </summary>
    let ont00000283 = _prefixId.prefix "ont00000283"
    /// <summary>
    ///   <para>rdfs:label : Strength</para>
    ///   <para>skos:definition : A Realizable Entity that is realized when its bearer exerts or resists some power, influence, or force.</para>
    ///   <para>skos:scopeNote : Strength is intended to be understood broadly here. Physical strength is only one type of Strength. Other subtypes of Strength may include military strength, psychological strength, emotional strength, political strength, technological strength, and so on.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000284">cco:ont00000284</a>
    /// </summary>
    let ont00000284 = _prefixId.prefix "ont00000284"
    /// <summary>
    ///   <para>rdfs:label : Wetness</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the degree to which the bearer is covered by a liquid, typically on a continuum of dry to wet.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000295">cco:ont00000295</a>
    /// </summary>
    let ont00000295 = _prefixId.prefix "ont00000295"
    /// <summary>
    ///   <para>rdfs:label : Width</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a bearer in virtue of the bearer's extension in a horizontal direction.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000324">cco:ont00000324</a>
    /// </summary>
    let ont00000324 = _prefixId.prefix "ont00000324"
    /// <summary>
    ///   <para>rdfs:label : Texture</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the size, shape, and distribution of features on its surface, typically on a continuum from smooth to rough.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000327">cco:ont00000327</a>
    /// </summary>
    let ont00000327 = _prefixId.prefix "ont00000327"
    /// <summary>
    ///   <para>rdfs:label : Color</para>
    ///   <para>skos:definition : An Optical Property that inheres in a bearer in virtue of that bearer's Color Hue, Color Saturation and Color Brightness.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000378">cco:ont00000378</a>
    /// </summary>
    let ont00000378 = _prefixId.prefix "ont00000378"
    /// <summary>
    ///   <para>rdfs:label : Wide</para>
    ///   <para>skos:altLabel : Broadskos:altLabel : Fat</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a width or depth which is significantly larger in proportion to its length or height.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000385">cco:ont00000385</a>
    /// </summary>
    let ont00000385 = _prefixId.prefix "ont00000385"
    /// <summary>
    ///   <para>rdfs:label : Sharp</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a fine point or thin edge.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000424">cco:ont00000424</a>
    /// </summary>
    let ont00000424 = _prefixId.prefix "ont00000424"
    /// <summary>
    ///   <para>rdfs:label : Black</para>
    ///   <para>skos:definition : A Color that lacks any hues as parts.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000439">cco:ont00000439</a>
    /// </summary>
    let ont00000439 = _prefixId.prefix "ont00000439"
    /// <summary>
    ///   <para>rdfs:label : Temperature</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of its thermal energy.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000441">cco:ont00000441</a>
    /// </summary>
    let ont00000441 = _prefixId.prefix "ont00000441"
    /// <summary>
    ///   <para>rdfs:label : Radioactive</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of that bearer exhibiting or being caused by radioactivity.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000442">cco:ont00000442</a>
    /// </summary>
    let ont00000442 = _prefixId.prefix "ont00000442"
    /// <summary>
    ///   <para>rdfs:label : Circumference</para>
    ///   <para>skos:definition : A Perimeter that inheres in a circle or ellipse.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000446">cco:ont00000446</a>
    /// </summary>
    let ont00000446 = _prefixId.prefix "ont00000446"
    /// <summary>
    ///   <para>rdfs:label : Triangular</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of it having exactly three angles and exactly three sides.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000447">cco:ont00000447</a>
    /// </summary>
    let ont00000447 = _prefixId.prefix "ont00000447"
    /// <summary>
    ///   <para>rdfs:label : Silver Color</para>
    ///   <para>skos:definition : A Color that resembles Grey with the added feature of having a metallic shine.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000450">cco:ont00000450</a>
    /// </summary>
    let ont00000450 = _prefixId.prefix "ont00000450"
    /// <summary>
    ///   <para>rdfs:label : Fluorescence</para>
    ///   <para>skos:definition : A Luminescent Property that inheres in a bearer in virtue of that bearer's capacity to emit visible light while absorbing shorter wavelength radiation, but not after.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Fluorescence&amp;oldid=1061358510^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000459">cco:ont00000459</a>
    /// </summary>
    let ont00000459 = _prefixId.prefix "ont00000459"
    /// <summary>
    ///   <para>rdfs:label : Oblong</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having an long thin shape with approximately parallel sides.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000464">cco:ont00000464</a>
    /// </summary>
    let ont00000464 = _prefixId.prefix "ont00000464"
    /// <summary>
    ///   <para>rdfs:label : Curved</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having borders which are smoothly rounded.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000474">cco:ont00000474</a>
    /// </summary>
    let ont00000474 = _prefixId.prefix "ont00000474"
    /// <summary>
    ///   <para>rdfs:label : Cuboidal</para>
    ///   <para>skos:definition : A Three Dimensional Shape that inheres in a bearer in virtue of it having six Rectangular faces.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000478">cco:ont00000478</a>
    /// </summary>
    let ont00000478 = _prefixId.prefix "ont00000478"
    /// <summary>
    ///   <para>rdfs:label : Concave Shape</para>
    ///   <para>skos:definition : A Shape Quality that inheres in a bearer in virtue of the bearer having one or more cavities, such that at least one line connecting a pair of points on the surface of the bearer will lie outside.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000484">cco:ont00000484</a>
    /// </summary>
    let ont00000484 = _prefixId.prefix "ont00000484"
    /// <summary>
    ///   <para>rdfs:label : Serrated</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having multiple sharp points along a edge.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000494">cco:ont00000494</a>
    /// </summary>
    let ont00000494 = _prefixId.prefix "ont00000494"
    /// <summary>
    ///   <para>rdfs:label : Radiation Emissivity</para>
    ///   <para>skos:definition : A Disposition to Interact with Electromagnetic Radiation that inheres in a bearer in virtue of the capacity of that bearer to emit electromagnetic radiation of a given frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000512">cco:ont00000512</a>
    /// </summary>
    let ont00000512 = _prefixId.prefix "ont00000512"
    /// <summary>
    ///   <para>rdfs:label : Transparent</para>
    ///   <para>skos:definition : An Opacity that inheres in a bearer in virtue of that bearer's capacity to transmit all or nearly all electromagnetic radiation of a given frequency through the bearer such that the bearer reflects, scatters, or absorbs little or no electromagnetic radiation of that frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000525">cco:ont00000525</a>
    /// </summary>
    let ont00000525 = _prefixId.prefix "ont00000525"
    /// <summary>
    ///   <para>rdfs:label : White</para>
    ///   <para>skos:definition : A Color of maximum brightness, the color of objects that reflect nearly all wavelengths of the visible light spectrum, thus considered achromatic.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000528">cco:ont00000528</a>
    /// </summary>
    let ont00000528 = _prefixId.prefix "ont00000528"
    /// <summary>
    ///   <para>rdfs:label : Diameter</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a circle in virtue of the extent of a straight line that passes through the center of the circle and starts and ends on the circle's boundary.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000541">cco:ont00000541</a>
    /// </summary>
    let ont00000541 = _prefixId.prefix "ont00000541"
    /// <summary>
    ///   <para>dcterms:bibliographicCitation : Vulnerability | Definition of Vulnerability by Oxford Dictionary on Lexico.Com Also Meaning of Vulnerability. https://web.archive.org/web/20210118111731/https://www.lexico.com/en/definition/vulnerability. Accessed 19 Dec. 2022.^^xsd:string</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>rdfs:label : Vulnerability</para>
    ///   <para>skos:definition : A Disrupting Disposition the realization of which would disrupt a process that the bearer of the Disrupting Disposition has an interest in.</para>
    ///   <para>skos:editorialNote : This is defined class. A Vulnerability is indexed by the interest_in object property. A disposition can be a Vulnerability according to one index and not a Vulnerability according to another index.^^xsd:string</para>
    ///   <para>skos:prefLabel : Vulnerability</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000548">cco:ont00000548</a>
    /// </summary>
    let ont00000548 = _prefixId.prefix "ont00000548"
    /// <summary>
    ///   <para>rdfs:label : Cone Shape</para>
    ///   <para>skos:definition : A Three Dimensional Shape that inheres in a bearer in virtue of it having a Round base that tapers smoothly to an apex.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Cone&amp;oldid=1058362269^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000560">cco:ont00000560</a>
    /// </summary>
    let ont00000560 = _prefixId.prefix "ont00000560"
    /// <summary>
    ///   <para>rdfs:label : Cube Shape</para>
    ///   <para>skos:definition : A Cuboidal shape inhering in a bearer in virtue of it having six Square faces.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000565">cco:ont00000565</a>
    /// </summary>
    let ont00000565 = _prefixId.prefix "ont00000565"
    /// <summary>
    ///   <para>rdfs:label : Sloped</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a horizontal border which is not level.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000578">cco:ont00000578</a>
    /// </summary>
    let ont00000578 = _prefixId.prefix "ont00000578"
    /// <summary>
    ///   <para>rdfs:label : Thin</para>
    ///   <para>skos:altLabel : Narrowskos:altLabel : Slender</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a width or depth which is significantly smaller in proportion to its length or height.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000579">cco:ont00000579</a>
    /// </summary>
    let ont00000579 = _prefixId.prefix "ont00000579"
    /// <summary>
    ///   <para>rdfs:label : Convex Shape</para>
    ///   <para>skos:definition : A Shape Quality that inheres in a bearer in virtue of the bearer not having a cavity, such that no line connecting a pair of points on the surface of the bearer will lie outside.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000590">cco:ont00000590</a>
    /// </summary>
    let ont00000590 = _prefixId.prefix "ont00000590"
    /// <summary>
    ///   <para>rdfs:label : Thickness</para>
    ///   <para>skos:definition : A Depth that inheres in a bearer in virtue of it extending inward through an object.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000607">cco:ont00000607</a>
    /// </summary>
    let ont00000607 = _prefixId.prefix "ont00000607"
    /// <summary>
    ///   <para>skos:scopeNote : 'Matter' here can also refer to the inertial energy of an object.skos:scopeNote : Typical unit of measure is the kilogram or pound.</para>
    ///   <para>rdfs:label : Mass</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the amount of matter in that bearer.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000614">cco:ont00000614</a>
    /// </summary>
    let ont00000614 = _prefixId.prefix "ont00000614"
    /// <summary>
    ///   <para>rdfs:label : Radiopacity</para>
    ///   <para>skos:altLabel : Radiodensity</para>
    ///   <para>skos:definition : An Opacity that inheres in a bearer in virtue of its capacity to allow or prevent X-rays to pass through it.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Radiodensity&amp;oldid=1048274724^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000620">cco:ont00000620</a>
    /// </summary>
    let ont00000620 = _prefixId.prefix "ont00000620"
    /// <summary>
    ///   <para>rdfs:label : Disposition to Interact with Electromagnetic Radiation</para>
    ///   <para>skos:definition : A Disposition that inheres in a bearer in virtue of how that bearer interacts with electromagnetic radiation.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000628">cco:ont00000628</a>
    /// </summary>
    let ont00000628 = _prefixId.prefix "ont00000628"
    /// <summary>
    ///   <para>rdfs:label : Magnetism</para>
    ///   <para>skos:definition : A Disposition that is realized when its bearer exerts a magnetic force on another entity.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000632">cco:ont00000632</a>
    /// </summary>
    let ont00000632 = _prefixId.prefix "ont00000632"
    /// <summary>
    ///   <para>skos:scopeNote : When an object is "weighed", in the typical case, it is done so by taking into account the local force of gravity to determine the object's mass, whose standard of measure is the kilogram. The actual unit of measure of weight is the newton.</para>
    ///   <para>rdfs:label : Weight</para>
    ///   <para>skos:definition : A Quality that inheres in some material entity with a mass in virtue of its location in some gravitational field.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000633">cco:ont00000633</a>
    /// </summary>
    let ont00000633 = _prefixId.prefix "ont00000633"
    /// <summary>
    ///   <para>rdfs:label : Color Brightness</para>
    ///   <para>skos:altLabel : Color Intensity</para>
    ///   <para>skos:definition : An Optical Property that inheres in a bearer in virtue of its capacity to reflect or radiate light.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000648">cco:ont00000648</a>
    /// </summary>
    let ont00000648 = _prefixId.prefix "ont00000648"
    /// <summary>
    ///   <para>rdfs:label : Radiolucent</para>
    ///   <para>skos:altLabel : Hypodenseskos:altLabel : Transradiance</para>
    ///   <para>skos:definition : A Radiopacity that inheres in a bearer in virtue of its capacity to permit most X-rays to pass through it.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000695">cco:ont00000695</a>
    /// </summary>
    let ont00000695 = _prefixId.prefix "ont00000695"
    /// <summary>
    ///   <para>rdfs:label : Spherical</para>
    ///   <para>skos:definition : A Three Dimensional Shape inhering in a bearer in virtue of all of its cross sections being round.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000733">cco:ont00000733</a>
    /// </summary>
    let ont00000733 = _prefixId.prefix "ont00000733"
    /// <summary>
    ///   <para>rdfs:label : Length</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a bearer in virtue of the bearer's greatest extent in one direction.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000738">cco:ont00000738</a>
    /// </summary>
    let ont00000738 = _prefixId.prefix "ont00000738"
    /// <summary>
    ///   <para>rdfs:label : Color Saturation</para>
    ///   <para>skos:definition : An Optical Property that inheres in a bearer in virtue of its capacity to reflect high intensity light distributed across fewer wavelengths, typically considered on a continuum of purity.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000759">cco:ont00000759</a>
    /// </summary>
    let ont00000759 = _prefixId.prefix "ont00000759"
    /// <summary>
    ///   <para>rdfs:label : Hardness</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the degree to which it can be turned, bowed, or twisted without breaking.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000766">cco:ont00000766</a>
    /// </summary>
    let ont00000766 = _prefixId.prefix "ont00000766"
    /// <summary>
    ///   <para>rdfs:label : Amount</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the total, aggregate or sum of a number of discrete items or material the entity contains as parts.</para>
    ///   <para>cco:ont00001754 : http://en.wiktionary.org/wiki/amount^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000768">cco:ont00000768</a>
    /// </summary>
    let ont00000768 = _prefixId.prefix "ont00000768"
    /// <summary>
    ///   <para>rdfs:label : Optical Property</para>
    ///   <para>skos:definition : A Disposition to Interact with Electromagnetic Radiation that is realized when its bearer interacts with electromagnetic waves within the visible light spectrum.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000784">cco:ont00000784</a>
    /// </summary>
    let ont00000784 = _prefixId.prefix "ont00000784"
    /// <summary>
    ///   <para>rdfs:label : Altitude</para>
    ///   <para>skos:definition : A Height that inheres in a Site that externally connects an Independent Continuant to either the surface of the Earth or the Earth's mean Sea Level.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000787">cco:ont00000787</a>
    /// </summary>
    let ont00000787 = _prefixId.prefix "ont00000787"
    /// <summary>
    ///   <para>rdfs:label : Hazel</para>
    ///   <para>skos:definition : A Color that is a combination of Brown and Green, typically associated with eye color.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000797">cco:ont00000797</a>
    /// </summary>
    let ont00000797 = _prefixId.prefix "ont00000797"
    /// <summary>
    ///   <para>rdfs:label : Round</para>
    ///   <para>skos:altLabel : Circular</para>
    ///   <para>skos:definition : A Shape Quality that inheres in a bearer in virtue of every point along its circumference being equidistant from the center.</para>
    ///   <para>cco:ont00001754 : http://www.merriam-webster.com/dictionary/round^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000803">cco:ont00000803</a>
    /// </summary>
    let ont00000803 = _prefixId.prefix "ont00000803"
    /// <summary>
    ///   <para>rdfs:label : Coiled</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer being wound in concentric rings or spirals.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000805">cco:ont00000805</a>
    /// </summary>
    let ont00000805 = _prefixId.prefix "ont00000805"
    /// <summary>
    ///   <para>rdfs:label : Folded</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of one part of the bearer being layered over another connected part.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000815">cco:ont00000815</a>
    /// </summary>
    let ont00000815 = _prefixId.prefix "ont00000815"
    /// <summary>
    ///   <para>rdfs:label : Orange</para>
    ///   <para>skos:definition : A Color that is between Red and Yellow with a wavelength in the visible spectrum typically between 590 to 635 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000818">cco:ont00000818</a>
    /// </summary>
    let ont00000818 = _prefixId.prefix "ont00000818"
    /// <summary>
    ///   <para>rdfs:label : Refractivity</para>
    ///   <para>skos:definition : A Radiation Reflectivity that inheres in a bearer in virtue of the capacity of that bearer to change the direction of a propagating wave when passing through it.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Refractive_index&amp;oldid=1062519140^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000826">cco:ont00000826</a>
    /// </summary>
    let ont00000826 = _prefixId.prefix "ont00000826"
    /// <summary>
    ///   <para>rdfs:label : Body Shape</para>
    ///   <para>skos:definition : A Shape Quality inhering in a Person's body by virtue of the body's general outline or figure.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000835">cco:ont00000835</a>
    /// </summary>
    let ont00000835 = _prefixId.prefix "ont00000835"
    /// <summary>
    ///   <para>rdfs:label : Split</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a linear opening, or having been divided into parts.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000861">cco:ont00000861</a>
    /// </summary>
    let ont00000861 = _prefixId.prefix "ont00000861"
    /// <summary>
    ///   <para>rdfs:label : Brown</para>
    ///   <para>skos:definition : A Color that consists of dark orange and red, and of very low intensity.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000872">cco:ont00000872</a>
    /// </summary>
    let ont00000872 = _prefixId.prefix "ont00000872"
    /// <summary>
    ///   <para>rdfs:label : Wavy</para>
    ///   <para>skos:altLabel : Undulate</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of it having a sinuous or rippled border.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000885">cco:ont00000885</a>
    /// </summary>
    let ont00000885 = _prefixId.prefix "ont00000885"
    /// <summary>
    ///   <para>rdfs:label : Depth</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a bearer in virtue of the bearer's extension in a downward, backward, or inward direction.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000892">cco:ont00000892</a>
    /// </summary>
    let ont00000892 = _prefixId.prefix "ont00000892"
    /// <summary>
    ///   <para>rdfs:label : Pyramidal</para>
    ///   <para>skos:definition : A Three Dimensional Shape that inheres in a bearer in virtue of it having a polygonal base with vertices that all connect to the same apex to form triangular faces.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/wiki/Pyramid_(geometry)^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000912">cco:ont00000912</a>
    /// </summary>
    let ont00000912 = _prefixId.prefix "ont00000912"
    /// <summary>
    ///   <para>rdfs:label : Maroon</para>
    ///   <para>skos:definition : A Color consisting of purple and brown hue.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000913">cco:ont00000913</a>
    /// </summary>
    let ont00000913 = _prefixId.prefix "ont00000913"
    /// <summary>
    ///   <para>rdfs:label : Phosphorescence</para>
    ///   <para>skos:definition : A Luminescent Property that inheres in a bearer in virtue of that bearer's capacity to emit visible light after absorbing shorter wavelength radiation, and to continue emitting after the absorbing process has ceased.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Phosphorescence&amp;oldid=1060815719^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000941">cco:ont00000941</a>
    /// </summary>
    let ont00000941 = _prefixId.prefix "ont00000941"
    /// <summary>
    ///   <para>rdfs:label : Height</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a bearer in virtue of the bearer's extension in a vertical direction.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000967">cco:ont00000967</a>
    /// </summary>
    let ont00000967 = _prefixId.prefix "ont00000967"
    /// <summary>
    ///   <para>rdfs:label : Cyan</para>
    ///   <para>skos:definition : A Color that is between Green and Blue with a wavelength in the visible spectrum typically between 490 and 520 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000975">cco:ont00000975</a>
    /// </summary>
    let ont00000975 = _prefixId.prefix "ont00000975"
    /// <summary>
    ///   <para>rdfs:label : Closure</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the degree to which that bearer affords passage or sightline through it via an opening, aperture, orifice, or vent.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000979">cco:ont00000979</a>
    /// </summary>
    let ont00000979 = _prefixId.prefix "ont00000979"
    /// <summary>
    ///   <para>rdfs:label : Bent</para>
    ///   <para>skos:altLabel : Angularskos:altLabel : Kinked</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having one or more angles along its border.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000991">cco:ont00000991</a>
    /// </summary>
    let ont00000991 = _prefixId.prefix "ont00000991"
    /// <summary>
    ///   <para>dcterms:created : 2022-12-30T21:32:27-05:00^^xsd:dateTime</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>rdfs:label : Disrupting Disposition</para>
    ///   <para>skos:definition : A disposition the realization of which would disrupt a process some entity has an interest in.</para>
    ///   <para>skos:editorialNote : This is a defined class. A Disrupting Disposition is indexed by the interest_in object property. A disposition can be a Disrupting Disposition according to one index and not a Disrupting Disposition according to another index.^^xsd:string</para>
    ///   <para>skos:prefLabel : Threat</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00000997">cco:ont00000997</a>
    /// </summary>
    let ont00000997 = _prefixId.prefix "ont00000997"
    /// <summary>
    ///   <para>rdfs:label : Drooping</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a border that hangs downwards.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001001">cco:ont00001001</a>
    /// </summary>
    let ont00001001 = _prefixId.prefix "ont00001001"
    /// <summary>
    ///   <para>rdfs:label : Pointing Orientation</para>
    ///   <para>skos:altLabel : Facing Orientation</para>
    ///   <para>skos:definition : A Spatial Orientation of a Material Entity in which one or more of its designated components are oriented toward a specified direction.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001026">cco:ont00001026</a>
    /// </summary>
    let ont00001026 = _prefixId.prefix "ont00001026"
    /// <summary>
    ///   <para>rdfs:label : Branched</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having subdivisions or offshoots.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001055">cco:ont00001055</a>
    /// </summary>
    let ont00001055 = _prefixId.prefix "ont00001055"
    /// <summary>
    ///   <para>rdfs:label : Shape Quality</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the ratios between dimensions of external features of that bearer.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001059">cco:ont00001059</a>
    /// </summary>
    let ont00001059 = _prefixId.prefix "ont00001059"
    /// <summary>
    ///   <para>rdfs:label : Straight</para>
    ///   <para>skos:altLabel : Linear</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer not having curves, bends, or angles along its borders.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001063">cco:ont00001063</a>
    /// </summary>
    let ont00001063 = _prefixId.prefix "ont00001063"
    /// <summary>
    ///   <para>rdfs:label : Two Dimensional Extent</para>
    ///   <para>skos:altLabel : Area</para>
    ///   <para>skos:definition : A Size Quality that inheres in a bearer in virtue of the bearer's extension in two dimensions.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001065">cco:ont00001065</a>
    /// </summary>
    let ont00001065 = _prefixId.prefix "ont00001065"
    /// <summary>
    ///   <para>rdfs:label : Blond</para>
    ///   <para>skos:definition : A Color that ranges from nearly white to a light greyish yellow.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001079">cco:ont00001079</a>
    /// </summary>
    let ont00001079 = _prefixId.prefix "ont00001079"
    /// <summary>
    ///   <para>rdfs:label : Magenta</para>
    ///   <para>skos:definition : A Color consisting of red and blue hues.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001113">cco:ont00001113</a>
    /// </summary>
    let ont00001113 = _prefixId.prefix "ont00001113"
    /// <summary>
    ///   <para>rdfs:label : Surface Tension</para>
    ///   <para>skos:definition : A Disposition that inheres in a liquid and is realized when the cohesive forces of the molecules in the bearer at the surface are greater than the adhesive forces of the molecules in the surrounding air.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Surface_tension&amp;oldid=1062753527^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001118">cco:ont00001118</a>
    /// </summary>
    let ont00001118 = _prefixId.prefix "ont00001118"
    /// <summary>
    ///   <para>skos:scopeNote : There are a variety of photometric measurements, such as luminous flux/power or luminous intensity, whose units are lumen and candela respectively, which attempt to describe properties associated with the perception of light. These are weighted measurements, typically by the luminosity function, as thus exist on the side of information content. It is a point of further development to add the needed intrinsic properties of radiation that such measurements are about.</para>
    ///   <para>rdfs:label : Luminescent Property</para>
    ///   <para>skos:definition : An Optical Property that inheres in a bearer in virtue of that bearer's capacity to emit visible light, but which isn't the result of the bearer being heated.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Luminescence&amp;oldid=1050169944^^xsd:anyURI</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001126">cco:ont00001126</a>
    /// </summary>
    let ont00001126 = _prefixId.prefix "ont00001126"
    /// <summary>
    ///   <para>rdfs:label : Radiation Reflectivity</para>
    ///   <para>skos:definition : A Disposition to Interact with Electromagnetic Radiation that inheres in a bearer in virtue of the capacity of that bearer to scatter or reflect electromagnetic radiation of a given frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001137">cco:ont00001137</a>
    /// </summary>
    let ont00001137 = _prefixId.prefix "ont00001137"
    /// <summary>
    ///   <para>rdfs:label : Violet</para>
    ///   <para>skos:definition : A Color that is lower than Blue with a wavelength in the visible spectrum typically between 400 and 450 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001142">cco:ont00001142</a>
    /// </summary>
    let ont00001142 = _prefixId.prefix "ont00001142"
    /// <summary>
    ///   <para>rdfs:label : Roll Orientation</para>
    ///   <para>skos:altLabel : Roll</para>
    ///   <para>skos:definition : A Spatial Orientation of an Object relative to its Roll Axis.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001177">cco:ont00001177</a>
    /// </summary>
    let ont00001177 = _prefixId.prefix "ont00001177"
    /// <summary>
    ///   <para>rdfs:label : Phase Angle</para>
    ///   <para>skos:altLabel : Orbital Phase Angle</para>
    ///   <para>skos:definition : A Relational Quality that is the angle between the light incident onto an observed Object and the light reflected from the Object.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/wiki/Phase_angle_(astronomy)^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001182">cco:ont00001182</a>
    /// </summary>
    let ont00001182 = _prefixId.prefix "ont00001182"
    /// <summary>
    ///   <para>rdfs:label : Color Hue</para>
    ///   <para>skos:definition : An Optical Property that inheres in a bearer in virtue of its capacity to reflect a dominant wavelength of the visible light spectrum, which is typically divided up into 6 to 8 ranges.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001186">cco:ont00001186</a>
    /// </summary>
    let ont00001186 = _prefixId.prefix "ont00001186"
    /// <summary>
    ///   <para>rdfs:label : Blue</para>
    ///   <para>skos:definition : A Color that is between Cyan and Violet with a wavelength in the visible spectrum typically between 450 to 490 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001189">cco:ont00001189</a>
    /// </summary>
    let ont00001189 = _prefixId.prefix "ont00001189"
    /// <summary>
    ///   <para>rdfs:label : Fatigability</para>
    ///   <para>skos:definition : A Realizable Entity that is realized when its bearer loses strength and tires quickly.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001193">cco:ont00001193</a>
    /// </summary>
    let ont00001193 = _prefixId.prefix "ont00001193"
    /// <summary>
    ///   <para>rdfs:label : Protruding</para>
    ///   <para>skos:definition : A Shape Quality inhering in a part of an object in virtue of the part extending out above or beyond the surface of the object.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001199">cco:ont00001199</a>
    /// </summary>
    let ont00001199 = _prefixId.prefix "ont00001199"
    /// <summary>
    ///   <para>rdfs:label : Size Quality</para>
    ///   <para>skos:definition : A Quality that inheres in a bearer in virtue of the bearer's extension in one or more dimensions.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001202">cco:ont00001202</a>
    /// </summary>
    let ont00001202 = _prefixId.prefix "ont00001202"
    /// <summary>
    ///   <para>rdfs:label : Opaque</para>
    ///   <para>skos:definition : An Opacity that inheres in a bearer in virtue of that bearer's incapacity to transmit electromagnetic radiation of a given frequency through the bearer such that the bearer reflects, scatters, or absorbs all electromagnetic radiation of that frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001220">cco:ont00001220</a>
    /// </summary>
    let ont00001220 = _prefixId.prefix "ont00001220"
    /// <summary>
    ///   <para>rdfs:label : Yellow</para>
    ///   <para>skos:definition : A Color that is between Orange and Green with a wavelength in the visible spectrum typically between 560 to 590 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001225">cco:ont00001225</a>
    /// </summary>
    let ont00001225 = _prefixId.prefix "ont00001225"
    /// <summary>
    ///   <para>rdfs:label : Red</para>
    ///   <para>skos:definition : A Color that is above Orange with a wavelength in the visible spectrum typically between 635 to 700 nanometers.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001277">cco:ont00001277</a>
    /// </summary>
    let ont00001277 = _prefixId.prefix "ont00001277"
    /// <summary>
    ///   <para>rdfs:label : Flat</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of the bearer having a horizontal border without a significant deviation.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001280">cco:ont00001280</a>
    /// </summary>
    let ont00001280 = _prefixId.prefix "ont00001280"
    /// <summary>
    ///   <para>rdfs:label : Radiation Absorptivity</para>
    ///   <para>skos:definition : A Disposition to Interact with Electromagnetic Radiation that inheres in a bearer in virtue of the capacity of that bearer to absorb electromagnetic radiation of a given frequency.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001291">cco:ont00001291</a>
    /// </summary>
    let ont00001291 = _prefixId.prefix "ont00001291"
    /// <summary>
    ///   <para>rdfs:label : Perimeter</para>
    ///   <para>skos:definition : A One Dimensional Extent that inheres in a bearer in virtue of the extent of a boundary which encloses the bearer.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001293">cco:ont00001293</a>
    /// </summary>
    let ont00001293 = _prefixId.prefix "ont00001293"
    /// <summary>
    ///   <para>rdfs:label : Three Dimensional Extent</para>
    ///   <para>skos:altLabel : Volume</para>
    ///   <para>skos:definition : A Size Quality that inheres in a bearer in virtue of the bearer's extension in three dimensions.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001294">cco:ont00001294</a>
    /// </summary>
    let ont00001294 = _prefixId.prefix "ont00001294"
    /// <summary>
    ///   <para>rdfs:label : Pitch Orientation</para>
    ///   <para>skos:altLabel : Pitch</para>
    ///   <para>skos:definition : A Spatial Orientation of an Object relative to its Pitch Axis.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001296">cco:ont00001296</a>
    /// </summary>
    let ont00001296 = _prefixId.prefix "ont00001296"
    /// <summary>
    ///   <para>rdfs:label : Yaw Orientation</para>
    ///   <para>skos:altLabel : Yaw</para>
    ///   <para>skos:definition : A Spatial Orientation of an Object relative to its Yaw Axis.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001318">cco:ont00001318</a>
    /// </summary>
    let ont00001318 = _prefixId.prefix "ont00001318"
    /// <summary>
    ///   <para>rdfs:label : Rosy</para>
    ///   <para>skos:definition : A Color consisting of red hue and yellow hue and high brightness.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001333">cco:ont00001333</a>
    /// </summary>
    let ont00001333 = _prefixId.prefix "ont00001333"
    /// <summary>
    ///   <para>rdfs:label : Grey</para>
    ///   <para>skos:definition : A Color between white and black colors.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001349">cco:ont00001349</a>
    /// </summary>
    let ont00001349 = _prefixId.prefix "ont00001349"
    /// <summary>
    ///   <para>rdfs:label : Vermilion</para>
    ///   <para>skos:definition : A Color consisting of red and orange hue with a slight amount of gray.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001354">cco:ont00001354</a>
    /// </summary>
    let ont00001354 = _prefixId.prefix "ont00001354"
    /// <summary>
    ///   <para>rdfs:label : Three Dimensional Shape</para>
    ///   <para>skos:definition : A Shape Quality that inheres only in a three dimensional entity.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001360">cco:ont00001360</a>
    /// </summary>
    let ont00001360 = _prefixId.prefix "ont00001360"
    /// <summary>
    ///   <para>skos:scopeNote : Subclasses of one dimensional extent are included for usability. It is doubtful any of them can be objectively distinguished (on the side of the bearing entity) without some reference to external properties such as orientation and perspective.</para>
    ///   <para>rdfs:label : One Dimensional Extent</para>
    ///   <para>skos:definition : A Size Quality that inheres in a bearer in virtue of the bearer's extension in one dimension.</para>
    ///   <para>cco:ont00001754 : International Organization for Standardization. 2019. Quantities and units -- Part 3: Space and time (ISO 80000-3:2019). International Organization for Standardization. Available at: https://www.iso.org/standard/64974.html.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001367">cco:ont00001367</a>
    /// </summary>
    let ont00001367 = _prefixId.prefix "ont00001367"
    /// <summary>
    ///   <para>rdfs:label : Rectangular</para>
    ///   <para>skos:definition : A Shape Quality inhering in a bearer in virtue of having four sides and four 90 degree angles.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001369">cco:ont00001369</a>
    /// </summary>
    let ont00001369 = _prefixId.prefix "ont00001369"
    /// <summary>
    ///   <para>rdfs:label : Gold Color</para>
    ///   <para>skos:definition : A Color that resembles a yellow-orange Hue with the added feature of having a metallic shine.</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001377">cco:ont00001377</a>
    /// </summary>
    let ont00001377 = _prefixId.prefix "ont00001377"
    /// <summary>
    ///   <para>skos:scopeNote : Note that it is important to specify the frequency of electromagnetic radiation when representing a bearer's Opacity since a bearer may be Opaque with respect to electromagnetic radiation of one frequency, but be transparent with respect to electromagnetic radiation of another frequency. Unless otherwise stated, statements about a bearer's Opacity are assumed to be about electromagnetic radiation with a frequency in the visible spectrum.</para>
    ///   <para>rdfs:label : Opacity</para>
    ///   <para>skos:definition : A Disposition to Interact with Electromagnetic Radiation that inheres in a bearer in virtue of that bearer's capacity to transmit electromagnetic radiation of a given frequency through the bearer instead of reflecting, scattering, or absorbing electromangentic radiation of that frequency.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/wiki/Opacity_(optics)^^xsd:string</para>
    ///   <para>cco:ont00001760 : https://www.commoncoreontologies.org/QualityOntology^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/ont00001384">cco:ont00001384</a>
    /// </summary>
    let ont00001384 = _prefixId.prefix "ont00001384"
    let ont00001754 = _prefixId.prefix "ont00001754"
    let ont00001760 = _prefixId.prefix "ont00001760"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module iddo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/iddo#" "iddo"
    /// <summary>
    ///   <para>rdfs:label : Assigned property^^xsd:stringrdfs:label : Zugewiesenes Merkmal</para>
    ///   <para>rdfs:comment : Repraesentiert die Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)rdfs:comment : Represents the assignment of a property and a property state to a feature of interest (FOI).^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#AssignedProperty">iddo:AssignedProperty</a>
    /// </summary>
    let AssignedProperty = _prefixId.prefix "AssignedProperty"
    let AssignedPropertyShape = _prefixId.prefix "AssignedPropertyShape"
    /// <summary>
    ///   <para>rdfs:label : Boundary value^^xsd:stringrdfs:label : Grenzwert</para>
    ///   <para>iddo:code : PA040^^xsd:stringiddo:code : PA040</para>
    ///   <para>rdfs:comment : Einzelnes Grenzwertintervallrdfs:comment : Single Boundary value interval^^xsd:string</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#BoundaryValue">iddo:BoundaryValue</a>
    /// </summary>
    let BoundaryValue = _prefixId.prefix "BoundaryValue"
    /// <summary>
    ///   <para>iddo:code : PA040^^xsd:stringiddo:code : PA040</para>
    ///   <para>rdfs:label : Boundary value item^^xsd:stringrdfs:label : Grenzwerte</para>
    ///   <para>rdfs:comment : Grenzwertintervall bestehend aus der unteren(minValue) und der oberen(maxValue) Intervallgrenzerdfs:comment : Boundary value interval consisting of the lower(minValue) and the upper(maxValue) interval boundary^^xsd:string</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#BoundaryValueItem">iddo:BoundaryValueItem</a>
    /// </summary>
    let BoundaryValueItem = _prefixId.prefix "BoundaryValueItem"
    /// <summary>
    ///   <para>rdfs:comment : Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)rdfs:comment : Pair (list of boundary intervals of possible values for the property, unit)^^xsd:string</para>
    ///   <para>iddo:code : PA040^^xsd:stringiddo:code : PA040</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <para>rdfs:label : Boundary values^^xsd:stringrdfs:label : Grenzwerte</para>
    ///   <a href="https://w3id.org/iddo#BoundaryValues">iddo:BoundaryValues</a>
    /// </summary>
    let BoundaryValues = _prefixId.prefix "BoundaryValues"
    /// <summary>
    ///   <para>rdfs:label : Boundary values list^^xsd:stringrdfs:label : Grenzwertliste</para>
    ///   <para>iddo:code : PA040^^xsd:stringiddo:code : PA040</para>
    ///   <para>rdfs:comment : Pair  (List of boundary intervals of possible values for the property, unit)^^xsd:stringrdfs:comment : Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#BoundaryValuesList">iddo:BoundaryValuesList</a>
    /// </summary>
    let BoundaryValuesList = _prefixId.prefix "BoundaryValuesList"
    /// <summary>
    ///   <para>skos:scopeNote : GA022^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the category of the created property group^^xsd:stringrdfs:comment : Gibt die Kategorie der erstellten Merkmalsgruppe an</para>
    ///   <para>rdfs:label : Category of group of properties^^xsd:stringrdfs:label : Kategorie der Merkmalsgruppe</para>
    ///   <para>iddo:code : GA022^^xsd:stringiddo:code : GA022</para>
    ///   <para>skos:example : Class^^xsd:stringskos:example : Reference document^^xsd:stringskos:example : Domain^^xsd:stringskos:example : Composed property^^xsd:stringskos:example : Alternative use^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#CategoryOfGroupOfProperties">iddo:CategoryOfGroupOfProperties</a>
    /// </summary>
    let CategoryOfGroupOfProperties = _prefixId.prefix "CategoryOfGroupOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties^^xsd:stringrdfs:comment : Liste der global eindeutigen Bezeichner der verbundenen Merkmale (Attribut PA001); der Wert eines Merkmals steht zu den Werten der anderen in einer Beziehung. Beispielsweise ist ein Schallabsorptionsgrad fuer eine bestimmte Frequenz gegeben, in diesem Fall sind Schallabsorp-tionsgrad und Frequenz ver-bundene Merkmale.</para>
    ///   <para>iddo:code : PA020^^xsd:stringiddo:code : PA020</para>
    ///   <para>rdfs:label : Verbundene Merkmalerdfs:label : Connected properties^^xsd:string</para>
    ///   <para>skos:scopeNote : PA020^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#ConnectedProperties">iddo:ConnectedProperties</a>
    /// </summary>
    let ConnectedProperties = _prefixId.prefix "ConnectedProperties"
    /// <summary>
    ///   <para>skos:scopeNote : PA026/GA021^^xsd:string</para>
    ///   <para>iddo:code : PA026/GA021^^xsd:stringiddo:code : PA026/GA021</para>
    ///   <para>rdfs:label : Ursprungslandrdfs:label : Country of origin^^xsd:string</para>
    ///   <para>rdfs:comment : Country from where the requirement for this property/group of properties originated^^xsd:stringrdfs:comment : Land, aus dem die Anforderung an dieses Merkmal/dieser Merkmalsgruppe stammt</para>
    ///   <a href="https://w3id.org/iddo#CountryOfOrigin">iddo:CountryOfOrigin</a>
    /// </summary>
    let CountryOfOrigin = _prefixId.prefix "CountryOfOrigin"
    /// <summary>
    ///   <para>rdfs:label : Country of use^^xsd:stringrdfs:label : Land der Verwendung</para>
    ///   <para>rdfs:comment : Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in^^xsd:stringrdfs:comment : Land (Gruppe von Laendern, Kon-tinent), in dem das Merkmal/die Merkmalsgruppe fuer den Markt, auf dem die Beteiligten arbeiten, relevant ist</para>
    ///   <para>skos:scopeNote : PA024/GA019^^xsd:string</para>
    ///   <para>iddo:code : PA024/GA019^^xsd:stringiddo:code : PA024/GA019</para>
    ///   <a href="https://w3id.org/iddo#CountryOfUse">iddo:CountryOfUse</a>
    /// </summary>
    let CountryOfUse = _prefixId.prefix "CountryOfUse"
    /// <summary>
    ///   <para>iddo:code : PA015/GA015^^xsd:stringiddo:code : PA015/GA015</para>
    ///   <para>rdfs:label : Erlaeuterung fuer die Ablehnungrdfs:label : Creator's language^^xsd:string</para>
    ///   <para>skos:scopeNote : PA015/GA015^^xsd:string</para>
    ///   <para>rdfs:comment : Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)^^xsd:stringrdfs:comment : Satz, der den Grund fuer die Ab-lehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal entsprechen; diese Er-laeuterung muss in internatio-nalem Englisch (EN) geschrieben werden</para>
    ///   <a href="https://w3id.org/iddo#CreatorsLanguage">iddo:CreatorsLanguage</a>
    /// </summary>
    let CreatorsLanguage = _prefixId.prefix "CreatorsLanguage"
    /// <summary>
    ///   <para>rdfs:label : Data type^^xsd:stringrdfs:label : Datentyp (GUID)</para>
    ///   <para>rdfs:comment : Format fuer die Angabe des Wertes des Merkmals
    /// dies kann aus einer Soft-ware-Perspektive als Speiche-rungsart verstanden werden
    /// im Falle eines dynamischen Merkmals ist der Wert dieses Attributs der Datentyp des Er-gebnisses der Berechnung mit der Gleichungrdfs:comment : Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula^^xsd:string</para>
    ///   <para>iddo:code : PA030^^xsd:stringiddo:code : PA030</para>
    ///   <para>skos:scopeNote : PA030^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DataType">iddo:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:comment : Date after when the property can be used^^xsd:stringrdfs:comment : Datum, nach dem das Merkmal verwendet werden kann</para>
    ///   <para>iddo:code : PA004/GA004^^xsd:stringiddo:code : PA004/GA004</para>
    ///   <para>skos:scopeNote : PA04/GA04^^xsd:string</para>
    ///   <para>rdfs:label : Date of activation^^xsd:stringrdfs:label : Datum der Aktivierung</para>
    ///   <a href="https://w3id.org/iddo#DateOfActivation">iddo:DateOfActivation</a>
    /// </summary>
    let DateOfActivation = _prefixId.prefix "DateOfActivation"
    /// <summary>
    ///   <para>rdfs:comment : Datum der Validierung der An-frage zur Erstellung des Merkmals durch Sachverstaendigerdfs:comment : Date of validation of the property creation request by experts^^xsd:string</para>
    ///   <para>rdfs:label : Date of creation^^xsd:stringrdfs:label : Datum der Erstellung</para>
    ///   <para>skos:scopeNote : PA003/GA003^^xsd:string</para>
    ///   <para>iddo:code : PA003/GA003^^xsd:stringiddo:code : PA003/GA003</para>
    ///   <a href="https://w3id.org/iddo#DateOfCreation">iddo:DateOfCreation</a>
    /// </summary>
    let DateOfCreation = _prefixId.prefix "DateOfCreation"
    /// <summary>
    ///   <para>rdfs:comment : Date of deactivation^^xsd:stringrdfs:comment : Datum der Deaktivierung</para>
    ///   <para>rdfs:label : Date of deactivation^^xsd:stringrdfs:label : Datum der Deaktivierung</para>
    ///   <para>skos:scopeNote : PA008/GA008^^xsd:string</para>
    ///   <para>iddo:code : PA008/GA008^^xsd:stringiddo:code : PA008/GA008</para>
    ///   <a href="https://w3id.org/iddo#DateOfDeactivation">iddo:DateOfDeactivation</a>
    /// </summary>
    let DateOfDeactivation = _prefixId.prefix "DateOfDeactivation"
    /// <summary>
    ///   <para>rdfs:label : Datum der letzten Aenderungrdfs:label : Date of last change^^xsd:string</para>
    ///   <para>iddo:code : PA005/GA005^^xsd:stringiddo:code : PA005/GA005</para>
    ///   <para>skos:scopeNote : PA005/GA005^^xsd:string</para>
    ///   <para>rdfs:comment : Datum der Validierung der letzten Aenderungsanfrage durch Sachverstaendigerdfs:comment : Date of validation of the last change request by experts^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DateOfLastChange">iddo:DateOfLastChange</a>
    /// </summary>
    let DateOfLastChange = _prefixId.prefix "DateOfLastChange"
    /// <summary>
    ///   <para>rdfs:comment : Date of revision^^xsd:stringrdfs:comment : Datum der Ueberarbeitung</para>
    ///   <para>iddo:code : PA006/GA006^^xsd:stringiddo:code : PA006/GA006</para>
    ///   <para>rdfs:label : Datum der Ueberarbeitungrdfs:label : Date of revision^^xsd:string</para>
    ///   <para>skos:scopeNote : PA006/GA006^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DateOfRevision">iddo:DateOfRevision</a>
    /// </summary>
    let DateOfRevision = _prefixId.prefix "DateOfRevision"
    /// <summary>
    ///   <para>rdfs:comment : Date of version^^xsd:stringrdfs:comment : Datum der Version</para>
    ///   <para>rdfs:label : Datum der Versionrdfs:label : Date of version^^xsd:string</para>
    ///   <para>iddo:code : PA007/GA007^^xsd:stringiddo:code : PA007/GA007</para>
    ///   <para>skos:scopeNote : PA007/GA007^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DateOfVersion">iddo:DateOfVersion</a>
    /// </summary>
    let DateOfVersion = _prefixId.prefix "DateOfVersion"
    /// <summary>
    ///   <para>rdfs:comment : Contains a defining value of an array^^xsd:stringrdfs:comment : Enthaelt einen definierenden Wert eines Arrays</para>
    ///   <para>rdfs:label : Defining value^^xsd:stringrdfs:label : Definierender Wert</para>
    ///   <para>iddo:code : PA035^^xsd:stringiddo:code : PA035</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DefiningValue">iddo:DefiningValue</a>
    /// </summary>
    let DefiningValue = _prefixId.prefix "DefiningValue"
    /// <summary>
    ///   <para>rdfs:comment : Enthaelt einen definierenden Wert eines Arrays in Form eines Literalsrdfs:comment : Contains a defining value of an array in the form of a literal^^xsd:string</para>
    ///   <para>rdfs:label : Definierender Wert-Itemrdfs:label : Defining value item^^xsd:string</para>
    ///   <para>iddo:code : PA035^^xsd:stringiddo:code : PA035</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DefiningValueItem">iddo:DefiningValueItem</a>
    /// </summary>
    let DefiningValueItem = _prefixId.prefix "DefiningValueItem"
    /// <summary>
    ///   <para>rdfs:label : Defining values^^xsd:stringrdfs:label : Definierende Werte</para>
    ///   <para>rdfs:comment : In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030^^xsd:stringrdfs:comment : Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <para>iddo:code : PA035^^xsd:stringiddo:code : PA035</para>
    ///   <a href="https://w3id.org/iddo#DefiningValues">iddo:DefiningValues</a>
    /// </summary>
    let DefiningValues = _prefixId.prefix "DefiningValues"
    /// <summary>
    ///   <para>iddo:code : PA035^^xsd:stringiddo:code : PA035</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <para>rdfs:comment : In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030^^xsd:stringrdfs:comment : Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben</para>
    ///   <para>rdfs:label : Liste definierender Werterdfs:label : Defining values list^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DefiningValuesList">iddo:DefiningValuesList</a>
    /// </summary>
    let DefiningValuesList = _prefixId.prefix "DefiningValuesList"
    /// <summary>
    ///   <para>rdfs:comment : List of pairs (definition of the property/group of properties, language)^^xsd:stringrdfs:comment : Liste von Paaren (Definition des Merkmals/der Merkmalsgruppe, Sprache)</para>
    ///   <para>rdfs:label : Definition in Sprache Nrdfs:label : Definition of in language N^^xsd:string</para>
    ///   <para>iddo:code : PA016/GA016^^xsd:stringiddo:code : PA016/GA016</para>
    ///   <para>skos:scopeNote : PA016/GA016^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DefinitionInLanguage">iddo:DefinitionInLanguage</a>
    /// </summary>
    let DefinitionInLanguage = _prefixId.prefix "DefinitionInLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Satz, der den Grund fuer die Ablehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal/der neuen Merkmalsgruppe entsprechen; diese Erlaeuterung muss in internationalem Englisch (EN) geschrieben werdenrdfs:comment : Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)^^xsd:string</para>
    ///   <para>iddo:code : PA013/GA013^^xsd:stringiddo:code : PA013/GA013</para>
    ///   <para>rdfs:label : Deprecation explanation^^xsd:stringrdfs:label : Erlaeuterung fuer die Ablehnung</para>
    ///   <para>skos:scopeNote : PA013/GA013^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DeprecationExplanation">iddo:DeprecationExplanation</a>
    /// </summary>
    let DeprecationExplanation = _prefixId.prefix "DeprecationExplanation"
    /// <summary>
    ///   <para>iddo:code : PA019^^xsd:stringiddo:code : PA019</para>
    ///   <para>rdfs:comment : List of pairs (Description of the property, language)^^xsd:stringrdfs:comment : Liste von Paaren (Beschreibung des Merkmals, Sprache)</para>
    ///   <para>rdfs:label : Beschreibung in Sprache Nrdfs:label : Description in language N^^xsd:string</para>
    ///   <para>skos:scopeNote : PA019^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DescriptionInLanguage">iddo:DescriptionInLanguage</a>
    /// </summary>
    let DescriptionInLanguage = _prefixId.prefix "DescriptionInLanguage"
    /// <summary>
    ///   <para>rdfs:label : Data dictionary^^xsd:stringrdfs:label : Datenkatalog</para>
    ///   <para>rdfs:comment : Zentralisiertes Repository von Informationen ueber Daten, wie z. B. Bedeutung, Beziehungen zu anderen Daten, Ursprung, Verwendung und Formatrdfs:comment : Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Dictionary">iddo:Dictionary</a>
    /// </summary>
    let Dictionary = _prefixId.prefix "Dictionary"
    /// <summary>
    ///   <para>rdfs:label : Reference document^^xsd:stringrdfs:label : Referenzdokument</para>
    ///   <para>rdfs:comment : Publication that is consulted to find specific information, particularly in a technical or scientific domain^^xsd:stringrdfs:comment : Publikation, die hinzugezogen wird, um bestimmte Informationen zu finden, insbesondere in einer technischen oder wissenschaftlichen Domaene</para>
    ///   <a href="https://w3id.org/iddo#DictionaryReferenceDocument">iddo:DictionaryReferenceDocument</a>
    /// </summary>
    let DictionaryReferenceDocument = _prefixId.prefix "DictionaryReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : Dictionary subset^^xsd:stringrdfs:label : Teilmenge des Datenkatalogs</para>
    ///   <para>rdfs:comment : Defines a subset or subgrouping of a data catalog^^xsd:stringrdfs:comment : Definiert eine Teilmenge oder Untergruppierung eines Datenkatalogs</para>
    ///   <a href="https://w3id.org/iddo#DictionarySubset">iddo:DictionarySubset</a>
    /// </summary>
    let DictionarySubset = _prefixId.prefix "DictionarySubset"
    /// <summary>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <para>rdfs:comment : Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellenrdfs:comment : Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits^^xsd:string</para>
    ///   <para>iddo:code : PA037^^xsd:stringiddo:code : PA037</para>
    ///   <para>rdfs:label : Digital format^^xsd:stringrdfs:label : Digitales Format</para>
    ///   <a href="https://w3id.org/iddo#DigitalFormat">iddo:DigitalFormat</a>
    /// </summary>
    let DigitalFormat = _prefixId.prefix "DigitalFormat"
    /// <summary>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <para>rdfs:comment : Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellenrdfs:comment : Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits^^xsd:string</para>
    ///   <para>rdfs:label : Digital format item^^xsd:stringrdfs:label : Digitales Format-Item</para>
    ///   <para>iddo:code : PA037^^xsd:stringiddo:code : PA037</para>
    ///   <a href="https://w3id.org/iddo#DigitalFormatItem">iddo:DigitalFormatItem</a>
    /// </summary>
    let DigitalFormatItem = _prefixId.prefix "DigitalFormatItem"
    /// <summary>
    ///   <para>iddo:code : PA028^^xsd:stringiddo:code : PA028</para>
    ///   <para>rdfs:label : Dimension^^xsd:stringrdfs:label : Dimension</para>
    ///   <para>rdfs:comment : Im Falle einer physikalischen Groesse, Dimension nach ISO 80000 (alle Teile)
    /// dieses Attribut ermoeglicht, dass die Dimension maschinenlesbar ist; da alle physikalischen Groessen von 7 Basisgroessen abgeleitet sind, wird es durch Angabe der Basisdimensionen mit zugehoeriger Potenz (als rationale Zahl) in der folgenden Reihenfolge und mit jeweils einem Leerzeichen dazwischen angegebenrdfs:comment : In case of a physical quantity, dimension according to ISO 80000 (all parts)
    /// This attribute allows the dimension to be machine readable; as all physical quantities are derived from 7 base quantities, it is provided with the power (as a rational number) attached to a basic dimension in the following order and with one space between each^^xsd:string</para>
    ///   <para>skos:scopeNote : PA028^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Dimension">iddo:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>skos:example : no^^xsd:stringskos:example : yes^^xsd:string</para>
    ///   <para>skos:scopeNote : PA031^^xsd:string</para>
    ///   <para>rdfs:label : Dynamisches Merkmalrdfs:label : Dynamic Property^^xsd:string</para>
    ///   <para>iddo:code : PA031^^xsd:stringiddo:code : PA031</para>
    ///   <para>rdfs:comment : Wenn es sich um ein dynamisches Merkmal handelt, haengt der Wert von den im Attribut PA032 bereitgestellten Parametern abrdfs:comment : If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#DynamicProperty">iddo:DynamicProperty</a>
    /// </summary>
    let DynamicProperty = _prefixId.prefix "DynamicProperty"
    /// <summary>
    ///   <para>rdfs:comment : Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegtrdfs:comment : The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:string</para>
    ///   <para>iddo:code : PA038^^xsd:stringiddo:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <para>rdfs:label : Encoding^^xsd:stringrdfs:label : Kodierung</para>
    ///   <a href="https://w3id.org/iddo#Encoding">iddo:Encoding</a>
    /// </summary>
    let Encoding = _prefixId.prefix "Encoding"
    /// <summary>
    ///   <para>rdfs:label : Beispiel in Sprache Nrdfs:label : Example in language N^^xsd:string</para>
    ///   <para>rdfs:comment : Liste von Paaren (Beispiel des Merkmals, Sprache)rdfs:comment : List of pairs (example of the property, language)^^xsd:string</para>
    ///   <para>skos:scopeNote : PA019^^xsd:string</para>
    ///   <para>iddo:code : PA019^^xsd:stringiddo:code : PA019</para>
    ///   <a href="https://w3id.org/iddo#ExampleInLanguage">iddo:ExampleInLanguage</a>
    /// </summary>
    let ExampleInLanguage = _prefixId.prefix "ExampleInLanguage"
    /// <summary>
    ///   <para>rdfs:label : Gegebene Merkmalsgrupperdfs:label : Given group of properties^^xsd:string</para>
    ///   <para>rdfs:comment : Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.^^xsd:stringrdfs:comment : Global eindeutiger Bezeichner einer Merkmalsgruppe (Attribut GA001) fuer das dem Merkmal zugeordnetem Symbol</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>iddo:code : PA022^^xsd:stringiddo:code : PA022</para>
    ///   <a href="https://w3id.org/iddo#GivenGroupsOfProperties">iddo:GivenGroupsOfProperties</a>
    /// </summary>
    let GivenGroupsOfProperties = _prefixId.prefix "GivenGroupsOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : Eindeutiger Bezeichner, der mit dem in RFC 4122 beschriebenen Algorithmus erzeugt wirdrdfs:comment : Unique identifier generated using the algorithm denoted in RFC 4122^^xsd:string</para>
    ///   <para>skos:scopeNote : PA001/GA001^^xsd:string</para>
    ///   <para>iddo:code : PA001/GA001^^xsd:stringiddo:code : PA001/GA001</para>
    ///   <para>rdfs:label : Global eindeutiger Bezeichner (GUID)rdfs:label : Globally Unique Identifier (GUID)^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#GloballyUniqueIdentifier">iddo:GloballyUniqueIdentifier</a>
    /// </summary>
    let GloballyUniqueIdentifier = _prefixId.prefix "GloballyUniqueIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Group of properties^^xsd:stringrdfs:label : Merkmalsgruppe</para>
    ///   <para>rdfs:comment : Collection enabling the properties to be prearranged or organized^^xsd:stringrdfs:comment : Sammlung, die es ermoeglicht, die Merkmale vorauszuplanen oder zu organisieren</para>
    ///   <a href="https://w3id.org/iddo#GroupOfProperties">iddo:GroupOfProperties</a>
    /// </summary>
    let GroupOfProperties = _prefixId.prefix "GroupOfProperties"
    let GroupOfProperties_1 = _prefixId.prefix "GroupOfProperties_1"
    /// <summary>
    ///   <para>rdfs:comment : Liste von global eindeutigen Bezeichnern von Merkmalsgruppen (Attribut GA001), denen das Merkmal angehoertrdfs:comment : List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached^^xsd:string</para>
    ///   <para>rdfs:label : Group(s) of properties^^xsd:stringrdfs:label : Merkmalsgruppe(n)</para>
    ///   <para>skos:scopeNote : PA021^^xsd:string</para>
    ///   <para>iddo:code : PA021^^xsd:stringiddo:code : PA021</para>
    ///   <a href="https://w3id.org/iddo#GroupsOfProperties">iddo:GroupsOfProperties</a>
    /// </summary>
    let GroupsOfProperties = _prefixId.prefix "GroupsOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : Entsprechender Daten-katalog-Bezeichnerrdfs:comment : Corresponding data dictionary identifier^^xsd:string</para>
    ///   <para>skos:scopeNote : PA014^^xsd:string</para>
    ///   <para>iddo:code : PA014/GA014^^xsd:stringiddo:code : PA014/GA014</para>
    ///   <para>rdfs:label : Interconnected Data Dictionary ID^^xsd:stringrdfs:label : Miteinander verbundene Datenkatalog ID</para>
    ///   <a href="https://w3id.org/iddo#InterConDictID">iddo:InterConDictID</a>
    /// </summary>
    let InterConDictID = _prefixId.prefix "InterConDictID"

    /// <summary>
    ///   <para>skos:scopeNote : PA039^^xsd:string</para>
    ///   <para>rdfs:label : List of possible values in language N^^xsd:stringrdfs:label : Liste moeglicher Werte in Sprache N</para>
    ///   <para>rdfs:comment : Liste von Paaren (moeglicher Wert fuer das Merkmal und Sprache)
    /// Werte koennen String oder Zahlen seinrdfs:comment : List of pairs (possible value for the property and language)
    /// Values can be string or numbers^^xsd:string</para>
    ///   <para>iddo:code : PA039^^xsd:stringiddo:code : PA039</para>
    ///   <a href="https://w3id.org/iddo#ListOfPossibleValuesInLanguageN">iddo:ListOfPossibleValuesInLanguageN</a>
    /// </summary>
    let ListOfPossibleValuesInLanguageN =
        _prefixId.prefix "ListOfPossibleValuesInLanguageN"

    /// <summary>
    ///   <para>rdfs:comment : Liste von globalen Bezeichnern fuer die ersetzten Merk-malsgruppenrdfs:comment : List of globally unique identifiers of the replaced groups of properties^^xsd:string</para>
    ///   <para>rdfs:label : List of replaced groups of properties^^xsd:stringrdfs:label : Liste ersetzter Merkmalsgruppen</para>
    ///   <para>iddo:code : GA011^^xsd:stringiddo:code : GA011</para>
    ///   <para>skos:scopeNote : GA011^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#ListOfReplacedGroupsOfProperties">iddo:ListOfReplacedGroupsOfProperties</a>
    /// </summary>
    let ListOfReplacedGroupsOfProperties =
        _prefixId.prefix "ListOfReplacedGroupsOfProperties"

    /// <summary>
    ///   <para>skos:scopeNote : PA011^^xsd:string</para>
    ///   <para>rdfs:label : List of replaced properties^^xsd:stringrdfs:label : Liste ersetzter Merkmale</para>
    ///   <para>iddo:code : PA011^^xsd:stringiddo:code : PA011</para>
    ///   <para>rdfs:comment : Globally unique identifier of the replaced property (or properties)^^xsd:stringrdfs:comment : Global eindeutiger Bezeichner des ersetzten Merkmals (oder der Merkmale)</para>
    ///   <a href="https://w3id.org/iddo#ListOfReplacedProperties">iddo:ListOfReplacedProperties</a>
    /// </summary>
    let ListOfReplacedProperties = _prefixId.prefix "ListOfReplacedProperties"

    /// <summary>
    ///   <para>iddo:code : GA012^^xsd:stringiddo:code : GA012</para>
    ///   <para>rdfs:comment : List of globally unique identifiers of the replacing groups of properties^^xsd:stringrdfs:comment : Liste von globalen Bezeichnern fuer die ersetzenden Merkmalsgruppen</para>
    ///   <para>rdfs:label : Liste ersetzender Merkmalsgruppenrdfs:label : List of replacing groups of properties^^xsd:string</para>
    ///   <para>skos:scopeNote : GA012^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#ListOfReplacingGroupsOfProperties">iddo:ListOfReplacingGroupsOfProperties</a>
    /// </summary>
    let ListOfReplacingGroupsOfProperties =
        _prefixId.prefix "ListOfReplacingGroupsOfProperties"

    /// <summary>
    ///   <para>rdfs:label : Liste ersetzender Merkmalerdfs:label : List of replacing properties^^xsd:string</para>
    ///   <para>skos:scopeNote : PA012^^xsd:string</para>
    ///   <para>rdfs:comment : Globally unique identifier (attribute PA001) of the replacing property (or properties)^^xsd:stringrdfs:comment : global eindeutiger Bezeichner (Attribut PA001) des ersetzenden Merkmals (oder der Merkmale)</para>
    ///   <para>iddo:code : PA012^^xsd:stringiddo:code : PA012</para>
    ///   <a href="https://w3id.org/iddo#ListOfReplacingProperties">iddo:ListOfReplacingProperties</a>
    /// </summary>
    let ListOfReplacingProperties = _prefixId.prefix "ListOfReplacingProperties"
    /// <summary>
    ///   <para>rdfs:label : Messverfahrenrdfs:label : Method of measurement^^xsd:string</para>
    ///   <para>rdfs:comment : Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications^^xsd:stringrdfs:comment : Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen^^xsd:string</para>
    ///   <para>skos:scopeNote : PA029^^xsd:string</para>
    ///   <para>iddo:code : PA029^^xsd:stringiddo:code : PA029</para>
    ///   <a href="https://w3id.org/iddo#MethodOfMeasurement">iddo:MethodOfMeasurement</a>
    /// </summary>
    let MethodOfMeasurement = _prefixId.prefix "MethodOfMeasurement"
    /// <summary>
    ///   <para>rdfs:comment : Liste von Paaren (Name des Merkmals und Sprache)
    /// Dieses Attribut kann verwendet werden, um Synonyme fuer verschiedene Domaenen hinzuzufuegenrdfs:comment : List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains^^xsd:string</para>
    ///   <para>rdfs:label : Name in Sprache Nrdfs:label : Name in language N^^xsd:string</para>
    ///   <para>skos:scopeNote : PA016/GA016^^xsd:string</para>
    ///   <para>iddo:code : PA016/GA016^^xsd:stringiddo:code : PA016/GA016</para>
    ///   <a href="https://w3id.org/iddo#NameInLanguage">iddo:NameInLanguage</a>
    /// </summary>
    let NameInLanguage = _prefixId.prefix "NameInLanguage"
    /// <summary>
    ///   <para>rdfs:label : Names of the defining values^^xsd:stringrdfs:label : Name der definierenden Werte</para>
    ///   <para>skos:scopeNote : PA034^^xsd:string</para>
    ///   <para>iddo:code : PA034^^xsd:stringiddo:code : PA034</para>
    ///   <para>rdfs:comment : In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)^^xsd:stringrdfs:comment : Im Falle eines Feldes liefert dieses Attribut die Namen der Spaltenkoepfe, festgelegt als Liste von Paaren (Name, Sprache)</para>
    ///   <a href="https://w3id.org/iddo#NameOfTheDefiningValues">iddo:NameOfTheDefiningValues</a>
    /// </summary>
    let NameOfTheDefiningValues = _prefixId.prefix "NameOfTheDefiningValues"
    /// <summary>
    ///   <para>rdfs:comment : The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:stringrdfs:comment : Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    ///   <para>rdfs:label : Number of Characters^^xsd:stringrdfs:label : Anzahl der Zeichen</para>
    ///   <para>iddo:code : PA038^^xsd:stringiddo:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#NumberOfCharacters">iddo:NumberOfCharacters</a>
    /// </summary>
    let NumberOfCharacters = _prefixId.prefix "NumberOfCharacters"

    /// <summary>
    ///   <para>rdfs:label : Parameter des dynamischen Merkmalsrdfs:label : Parameters of the dynamic property^^xsd:string</para>
    ///   <para>rdfs:comment : List of GUIDS of properties which are parameters of the function for a dynamic property^^xsd:stringrdfs:comment : Liste von GUIDs von Merkmalen, welche Parameter der Funktion fuer ein dynamisches Merkmal sind</para>
    ///   <para>skos:scopeNote : PA032^^xsd:string</para>
    ///   <para>iddo:code : GA032iddo:code : PA032^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#ParametersOfTheDynamicProperty">iddo:ParametersOfTheDynamicProperty</a>
    /// </summary>
    let ParametersOfTheDynamicProperty =
        _prefixId.prefix "ParametersOfTheDynamicProperty"

    /// <summary>
    ///   <para>iddo:code : GA023^^xsd:stringiddo:code : GA023</para>
    ///   <para>skos:scopeNote : GA023^^xsd:string</para>
    ///   <para>rdfs:label : Parent group of properties^^xsd:stringrdfs:label : uebergeordnete Merkmalsgruppe</para>
    ///   <para>rdfs:comment : Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)^^xsd:stringrdfs:comment : Ermoeglicht die Ver-knuepfung einer Unter-gruppe mit einer ueber-geordneten Gruppe ueber ihre global ein-deutigen Bezeichner (Attribut GA001)
    /// jedes einer Gruppe zugehoerige Merkmal wird von der/den Untergruppe(n) uebernommen</para>
    ///   <a href="https://w3id.org/iddo#ParentGroupOfProperties">iddo:ParentGroupOfProperties</a>
    /// </summary>
    let ParentGroupOfProperties = _prefixId.prefix "ParentGroupOfProperties"
    /// <summary>
    ///   <para>rdfs:label : Physikalische Groesserdfs:label : Physical quantity^^xsd:string</para>
    ///   <para>skos:scopeNote : PA027^^xsd:string</para>
    ///   <para>iddo:code : PA027^^xsd:stringiddo:code : PA027</para>
    ///   <para>rdfs:comment : Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen.rdfs:comment : List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#PhysicalQuantity">iddo:PhysicalQuantity</a>
    /// </summary>
    let PhysicalQuantity = _prefixId.prefix "PhysicalQuantity"
    /// <summary>
    ///   <para>skos:scopeNote : PA039^^xsd:string</para>
    ///   <para>rdfs:label : Possible value in language N^^xsd:stringrdfs:label : Liste moeglicher Werte in Sprache N</para>
    ///   <para>rdfs:comment : Possible value for the property and language
    /// Values can be string or numbers^^xsd:stringrdfs:comment : Moeglicher Wert fuer das Merkmal und Sprache
    /// Werte koennen String oder Zahlen sein</para>
    ///   <para>iddo:code : PA039^^xsd:stringiddo:code : PA039</para>
    ///   <a href="https://w3id.org/iddo#PossibleValueInLanguageN">iddo:PossibleValueInLanguageN</a>
    /// </summary>
    let PossibleValueInLanguageN = _prefixId.prefix "PossibleValueInLanguageN"
    /// <summary>
    ///   <para>rdfs:label : Tolerance^^xsd:stringrdfs:label : Toleranz</para>
    ///   <para>iddo:code : PA037^^xsd:stringiddo:code : PA037</para>
    ///   <para>rdfs:comment : Precision is the number of significant digits^^xsd:stringrdfs:comment : Praezision ist die Anzahl signifi-kanter Stellen</para>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Precision">iddo:Precision</a>
    /// </summary>
    let Precision = _prefixId.prefix "Precision"
    /// <summary>
    ///   <para>rdfs:comment : Inhaerente oder erworbene Eigenschaft eines Datenelementsrdfs:comment : Inherent or acquired feature of an item^^xsd:string</para>
    ///   <para>rdfs:label : Property^^xsd:stringrdfs:label : Merkmal</para>
    ///   <a href="https://w3id.org/iddo#Property">iddo:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    let ReferenceDocument = _prefixId.prefix "ReferenceDocument"

    /// <summary>
    ///   <para>skos:scopeNote : PA014^^xsd:string</para>
    ///   <para>rdfs:label : Relation of propertiy identifier in the interconnected data dictionaries^^xsd:stringrdfs:label : Beziehung des Merkmalsbezeichners in den miteinander verbundenen Datenkatalogen</para>
    ///   <para>rdfs:comment : Paar (interner Merkmalsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// Dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werdenrdfs:comment : Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties^^xsd:string</para>
    ///   <para>iddo:code : PA014^^xsd:stringiddo:code : PA014</para>
    ///   <a href="https://w3id.org/iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries">iddo:RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries</a>
    /// </summary>
    let RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries =
        _prefixId.prefix "RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    ///   <para>rdfs:label : Beziehung des Bezeichners der Merkmalsgruppe in den miteinander verbundenen Datenkatalogenrdfs:label : Relation of the group of properties identifier in the interconnected data dictionaries^^xsd:string</para>
    ///   <para>skos:scopeNote : GA014^^xsd:string</para>
    ///   <para>rdfs:comment : Pair (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties^^xsd:stringrdfs:comment : Paar (interner Bezeichner der Merkmalsgruppe, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merkmalsgruppen verwendet werden</para>
    ///   <para>iddo:code : GA014^^xsd:stringiddo:code : GA014</para>
    ///   <a href="https://w3id.org/iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">iddo:RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</a>
    /// </summary>
    let RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefixId.prefix "RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    ///   <para>rdfs:label : Beziehung der Bezeichner der Merkmalsgruppe in den miteinander verbundenen Datenkatalogenrdfs:label : Relations of the group of properties identifiers in the interconnected data dictionaries^^xsd:string</para>
    ///   <para>skos:scopeNote : GA014^^xsd:string</para>
    ///   <para>iddo:code : GA014^^xsd:stringiddo:code : GA014</para>
    ///   <para>rdfs:comment : List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties^^xsd:stringrdfs:comment : Liste von Paaren (inter-ner Bezeichner der Merkmalsgruppe, ent-sprechender Daten-katalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merk-malsgruppen verwen-det werden</para>
    ///   <a href="https://w3id.org/iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">iddo:RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</a>
    /// </summary>
    let RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefixId.prefix "RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    ///   <para>rdfs:label : Beziehung der Merkmalsbezeichner in den miteinander verbundenen Datenka-talogenrdfs:label : Relations of the property identifiers in the interconnected data dictionaries^^xsd:string</para>
    ///   <para>iddo:code : PA014^^xsd:stringiddo:code : PA014</para>
    ///   <para>rdfs:comment : Liste von Paaren (interner Merk-malsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werdenrdfs:comment : List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties^^xsd:string</para>
    ///   <para>skos:scopeNote : PA014^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries">iddo:RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries</a>
    /// </summary>
    let RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries =
        _prefixId.prefix "RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    ///   <para>iddo:code : PA010/GA010^^xsd:stringiddo:code : PA010/GA010</para>
    ///   <para>rdfs:comment : This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed^^xsd:stringrdfs:comment : Diese Nummer der ueberarbeitung ermoeglicht die Verfolgung kleinerer aenderungen, z. B. neue uebersetzung, Korrekturen von Tippfehlern: wenn sich die Versionsnummer aendert, beginnt die Nummer der ueberarbeitung wieder bei 1.
    /// Sachverstaendige entscheiden, ob eine neue Nummer der ueberarbeitung angewendet werden kann oder ob eine neue ueberarbeitung erforderlich ist.</para>
    ///   <para>rdfs:label : Nummer der ueberarbeitungrdfs:label : Revision number^^xsd:string</para>
    ///   <para>skos:scopeNote : PA010/GA010^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#RevisionNumber">iddo:RevisionNumber</a>
    /// </summary>
    let RevisionNumber = _prefixId.prefix "RevisionNumber"
    /// <summary>
    ///   <para>iddo:code : PA002/GA002^^xsd:stringiddo:code : PA002/GA002</para>
    ///   <para>skos:example : inactive^^xsd:stringskos:example : active^^xsd:string</para>
    ///   <para>rdfs:label : Status^^xsd:stringrdfs:label : Status</para>
    ///   <para>rdfs:comment : Status of the property during its life cycle^^xsd:stringrdfs:comment : Status des Merkmals waehrend seines Lebenszyklus</para>
    ///   <para>skos:scopeNote : PA002/GA002^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Status">iddo:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : Subdivision of use^^xsd:stringrdfs:label : Unterteilung der Verwendung</para>
    ///   <para>rdfs:comment : Dokumentierte geographische Region, in der das Merkmal/ die Merkmalsgruppe verwendet wirdrdfs:comment : Documented geographical region of use of the group of properties^^xsd:string</para>
    ///   <para>iddo:code : PA025/GA020^^xsd:stringiddo:code : PA025/GA020</para>
    ///   <para>skos:scopeNote : PA025/GA020^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#SubdivisionOfUse">iddo:SubdivisionOfUse</a>
    /// </summary>
    let SubdivisionOfUse = _prefixId.prefix "SubdivisionOfUse"
    /// <summary>
    ///   <para>iddo:code : PA022^^xsd:stringiddo:code : PA022</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:label : Symbol^^xsd:stringrdfs:label : Symbol</para>
    ///   <a href="https://w3id.org/iddo#Symbol">iddo:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>rdfs:comment : Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))^^xsd:stringrdfs:comment : Paar (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))</para>
    ///   <para>iddo:code : PA022^^xsd:stringiddo:code : PA022</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:label : Symbol of the property in a given property group^^xsd:stringrdfs:label : Symbol des Merkmals in einer gegebenen Merkmalsgruppe</para>
    ///   <a href="https://w3id.org/iddo#SymbolOfTheProperty">iddo:SymbolOfTheProperty</a>
    /// </summary>
    let SymbolOfTheProperty = _prefixId.prefix "SymbolOfTheProperty"
    /// <summary>
    ///   <para>iddo:code : PA022^^xsd:stringiddo:code : PA022</para>
    ///   <para>rdfs:comment : List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))^^xsd:stringrdfs:comment : Liste von Paaren (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:label : Symbols of the property in a given property group^^xsd:stringrdfs:label : Symbole des Merkmals in einer gegebenen Merk-malsgruppe</para>
    ///   <a href="https://w3id.org/iddo#SymbolsOfTheProperty">iddo:SymbolsOfTheProperty</a>
    /// </summary>
    let SymbolsOfTheProperty = _prefixId.prefix "SymbolsOfTheProperty"
    /// <summary>
    ///   <para>rdfs:comment : Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:stringrdfs:comment : Paar fuer den Texttyp (Ver-schluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    ///   <para>iddo:code : PA038^^xsd:stringiddo:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <para>rdfs:label : Textformatrdfs:label : Text format^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#TextFormat">iddo:TextFormat</a>
    /// </summary>
    let TextFormat = _prefixId.prefix "TextFormat"
    /// <summary>
    ///   <para>rdfs:label : Text format item^^xsd:stringrdfs:label : Textformat-Item</para>
    ///   <para>iddo:code : PA038^^xsd:stringiddo:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <para>rdfs:comment : Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegtrdfs:comment : Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#TextFormatItem">iddo:TextFormatItem</a>
    /// </summary>
    let TextFormatItem = _prefixId.prefix "TextFormatItem"
    /// <summary>
    ///   <para>rdfs:comment : Fuer numerische Werte; der Gesamtbetrag, um den eine be-stimmte Einheit schwanken darf; sie ist die Differenz zwischen dem Hoechstwert und dem Mindestwert fuer die Einheitrdfs:comment : For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit^^xsd:string</para>
    ///   <para>skos:scopeNote : PA036^^xsd:string</para>
    ///   <para>iddo:code : PA036^^xsd:stringiddo:code : PA036</para>
    ///   <para>rdfs:label : Toleranzrdfs:label : Tolerance^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Tolerance">iddo:Tolerance</a>
    /// </summary>
    let Tolerance = _prefixId.prefix "Tolerance"
    /// <summary>
    ///   <para>rdfs:comment : Masseinheit fuer den digitalen Texttyprdfs:comment : Unit of measurement for the digital text type^^xsd:string</para>
    ///   <para>iddo:code : PA037^^xsd:stringiddo:code : PA037</para>
    ///   <para>rdfs:label : Einheitrdfs:label : Unit^^xsd:string</para>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Unit">iddo:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>iddo:code : PA033^^xsd:stringiddo:code : PA033</para>
    ///   <para>rdfs:comment : Eine Einheit zur Darstellung einer Skala, die es ermoeglicht, einen Wert zu messen
    /// es ist moeglich, dieses Attribut zu verwenden, um zu erlaeutern, dass dem Merkmal keine Einheit zugeordnet ist, indem einheitslos verwendet wirdrdfs:comment : A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless^^xsd:string</para>
    ///   <para>rdfs:label : Einheitenrdfs:label : Units^^xsd:string</para>
    ///   <para>skos:scopeNote : PA033^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#Units">iddo:Units</a>
    /// </summary>
    let Units = _prefixId.prefix "Units"
    /// <summary>
    ///   <para>rdfs:label : Versionsnummerrdfs:label : Version number^^xsd:string</para>
    ///   <para>rdfs:comment : This version number allows tracking of major changes. Experts decide if a new version number must be applied^^xsd:stringrdfs:comment : Diese Versionsnummer ermoeglicht die Verfolgung groesserer aenderungen. Sachverstaendige entscheiden, ob eine neue Ver-sionsnummer angewendet werden muss.</para>
    ///   <para>iddo:code : PA009/GA009^^xsd:stringiddo:code : PA009/GA009</para>
    ///   <para>skos:scopeNote : PA009/GA009^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#VersionNumber">iddo:VersionNumber</a>
    /// </summary>
    let VersionNumber = _prefixId.prefix "VersionNumber"
    /// <summary>
    ///   <para>rdfs:comment : Bildliche Darstellung des Merkmals durch Skizzen, Fotos, Videos oder sonstige Multimedia-Objekterdfs:comment : Visual representation of the group of properties through sketches, photos, videos or other multimedia objects^^xsd:string</para>
    ///   <para>iddo:code : PA023/GA018^^xsd:stringiddo:code : PA023/GA018</para>
    ///   <para>rdfs:label : Bildliche Darstellungrdfs:label : Visual representation^^xsd:string</para>
    ///   <para>skos:scopeNote : PA023/GA018^^xsd:string</para>
    ///   <a href="https://w3id.org/iddo#VisualRepresentation">iddo:VisualRepresentation</a>
    /// </summary>
    let VisualRepresentation = _prefixId.prefix "VisualRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:stringrdfs:label : Code</para>
    ///   <para>rdfs:comment : Code that can be used to identify the attribute^^xsd:stringrdfs:comment : Code, der zur Identifizierung des Attributs verwendet werden kann</para>
    ///   <a href="https://w3id.org/iddo#code">iddo:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"

    /// <summary>
    ///   <para>rdfs:label : has relation to a reference document^^xsd:stringrdfs:label : hat den Verweis auf ein Referenzdokument</para>
    ///   <a href="https://w3id.org/iddo#hasDictionaryReferenceDocument">iddo:hasDictionaryReferenceDocument</a>
    /// </summary>
    let hasDictionaryReferenceDocument =
        _prefixId.prefix "hasDictionaryReferenceDocument"

    /// <summary>
    ///   <para>rdfs:label : has dictionary subset^^xsd:stringrdfs:label : hat Teilmenge eines Katalogs</para>
    ///   <a href="https://w3id.org/iddo#hasDictionarySubset">iddo:hasDictionarySubset</a>
    /// </summary>
    let hasDictionarySubset = _prefixId.prefix "hasDictionarySubset"
    /// <summary>
    ///   <para>rdfs:label : has property^^xsd:stringrdfs:label : hat Merkmal</para>
    ///   <para>rdfs:comment : Attaches a property to a feature of interest (FOI)^^xsd:stringrdfs:comment : Fuegt ein Merkmal zu einem Feature of Interest (FOI) hinzu</para>
    ///   <a href="https://w3id.org/iddo#hasProperty">iddo:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has property group reference^^xsd:stringrdfs:label : hat Merkmalsgruppenreferenz</para>
    ///   <para>rdfs:comment : Attaches a property group reference to a iddo:ReferenceDocument^^xsd:stringrdfs:comment : Fuegt eine Merkmalsgruppe (oberstes in der Hierarchie) zu einer iddo:ReferenceDocument hinzu</para>
    ///   <a href="https://w3id.org/iddo#hasPropertyGroupReference">iddo:hasPropertyGroupReference</a>
    /// </summary>
    let hasPropertyGroupReference = _prefixId.prefix "hasPropertyGroupReference"
    /// <summary>
    ///   <para>rdfs:label : has Property Reference^^xsd:stringrdfs:label : hat Merkmalreferenz</para>
    ///   <para>rdfs:comment : Attaches a property reference to a property assignment^^xsd:stringrdfs:comment : Fuegt ein Merkmal zu einer Merkmalszuweisung hinzu</para>
    ///   <a href="https://w3id.org/iddo#hasPropertyReference">iddo:hasPropertyReference</a>
    /// </summary>
    let hasPropertyReference = _prefixId.prefix "hasPropertyReference"

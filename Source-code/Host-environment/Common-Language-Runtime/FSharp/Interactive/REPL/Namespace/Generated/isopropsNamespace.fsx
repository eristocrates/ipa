#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module isoprops =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/isoprops#" "isoprops"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Assigned property^^xsd:stringrdfs:label : Zugewiesenes Merkmal</para>
    ///   <para>rdfs:comment : Repraesentiert die Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)rdfs:comment : Represents the assignment of a property and a property state to a feature of interest (FOI).^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#AssignedProperty">isoprops:AssignedProperty</a>
    /// </summary>
    let AssignedProperty = _prefixId.prefix "AssignedProperty"
    /// <summary>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <para>rdfs:comment : Grenzwertintervall bestehend aus der oberen(maxValue) Intervallgrenzerdfs:comment : Boundary limit  interval consisting of the the upper (maxValue) interval boundary^^xsd:string</para>
    ///   <para>rdfs:label : Maximum Boundary Limit^^xsd:stringrdfs:label : Oberer Grenzwert</para>
    ///   <para>isoprops:code : PA040^^xsd:stringisoprops:code : PA040</para>
    ///   <a href="https://w3id.org/isoprops#BoundaryLimitMax">isoprops:BoundaryLimitMax</a>
    /// </summary>
    let BoundaryLimitMax = _prefixId.prefix "BoundaryLimitMax"
    /// <summary>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <para>rdfs:label : Unterer Grenzwertrdfs:label : Minimum Boundary Limit^^xsd:string</para>
    ///   <para>rdfs:comment : Boundary limit interval consisting of the lower(minValue) interval boundary^^xsd:stringrdfs:comment : Grenzwertintervall bestehend aus der unteren(minValue) Intervallgrenze</para>
    ///   <para>isoprops:code : PA040^^xsd:stringisoprops:code : PA040</para>
    ///   <a href="https://w3id.org/isoprops#BoundaryLimitMin">isoprops:BoundaryLimitMin</a>
    /// </summary>
    let BoundaryLimitMin = _prefixId.prefix "BoundaryLimitMin"
    /// <summary>
    ///   <para>rdfs:comment : Pair  (List of boundary intervals of possible values for the property, unit)^^xsd:stringrdfs:comment : Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)</para>
    ///   <para>isoprops:code : PA040^^xsd:stringisoprops:code : PA040</para>
    ///   <para>rdfs:label : Grenzwertlisterdfs:label : Boundary values list^^xsd:string</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#BoundaryValue">isoprops:BoundaryValue</a>
    /// </summary>
    let BoundaryValue = _prefixId.prefix "BoundaryValue"
    /// <summary>
    ///   <para>rdfs:label : Kategorie der Merkmalsgrupperdfs:label : Category of group of properties^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the category of the created property group^^xsd:stringrdfs:comment : Gibt die Kategorie der erstellten Merkmalsgruppe an</para>
    ///   <para>skos:example : Composed property^^xsd:stringskos:example : Reference document^^xsd:stringskos:example : Alternative use^^xsd:stringskos:example : Class^^xsd:stringskos:example : Domain^^xsd:string</para>
    ///   <para>skos:scopeNote : GA022^^xsd:string</para>
    ///   <para>isoprops:code : GA022^^xsd:stringisoprops:code : GA022</para>
    ///   <a href="https://w3id.org/isoprops#CategoryOfGroupOfProperties">isoprops:CategoryOfGroupOfProperties</a>
    /// </summary>
    let CategoryOfGroupOfProperties = _prefixId.prefix "CategoryOfGroupOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : Country from where the requirement for this property/group of properties originated^^xsd:stringrdfs:comment : Land, aus dem die Anforderung an dieses Merkmal/dieser Merkmalsgruppe stammt</para>
    ///   <para>rdfs:label : Country of origin^^xsd:stringrdfs:label : Ursprungsland</para>
    ///   <para>skos:scopeNote : PA026/GA021^^xsd:string</para>
    ///   <para>isoprops:code : PA026/GA021^^xsd:stringisoprops:code : PA026/GA021</para>
    ///   <a href="https://w3id.org/isoprops#CountryOfOrigin">isoprops:CountryOfOrigin</a>
    /// </summary>
    let CountryOfOrigin = _prefixId.prefix "CountryOfOrigin"
    /// <summary>
    ///   <para>isoprops:code : PA024/GA019^^xsd:stringisoprops:code : PA024/GA019</para>
    ///   <para>rdfs:comment : Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in^^xsd:stringrdfs:comment : Land (Gruppe von Laendern, Kon-tinent), in dem das Merkmal/die Merkmalsgruppe fuer den Markt, auf dem die Beteiligten arbeiten, relevant ist</para>
    ///   <para>rdfs:label : Land der Verwendungrdfs:label : Country of use^^xsd:string</para>
    ///   <para>skos:scopeNote : PA024/GA019^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#CountryOfUse">isoprops:CountryOfUse</a>
    /// </summary>
    let CountryOfUse = _prefixId.prefix "CountryOfUse"
    /// <summary>
    ///   <para>rdfs:comment : Satz, der den Grund fuer die Ab-lehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal entsprechen; diese Er-laeuterung muss in internatio-nalem Englisch (EN) geschrieben werdenrdfs:comment : Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)^^xsd:string</para>
    ///   <para>rdfs:label : Creator's language^^xsd:stringrdfs:label : Erlaeuterung fuer die Ablehnung</para>
    ///   <para>isoprops:code : PA015/GA015^^xsd:stringisoprops:code : PA015/GA015</para>
    ///   <para>skos:scopeNote : PA015/GA015^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#CreatorsLanguage">isoprops:CreatorsLanguage</a>
    /// </summary>
    let CreatorsLanguage = _prefixId.prefix "CreatorsLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Format fuer die Angabe des Wertes des Merkmals
    /// dies kann aus einer Soft-ware-Perspektive als Speiche-rungsart verstanden werden
    /// im Falle eines dynamischen Merkmals ist der Wert dieses Attributs der Datentyp des Er-gebnisses der Berechnung mit der Gleichungrdfs:comment : Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula^^xsd:string</para>
    ///   <para>isoprops:code : PA030^^xsd:stringisoprops:code : PA030</para>
    ///   <para>rdfs:label : Datentyp (GUID)rdfs:label : Data type^^xsd:string</para>
    ///   <para>skos:scopeNote : PA030^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DataType">isoprops:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:comment : Date after when the property can be used^^xsd:stringrdfs:comment : Datum, nach dem das Merkmal verwendet werden kann</para>
    ///   <para>rdfs:label : Date of activation^^xsd:stringrdfs:label : Datum der Aktivierung</para>
    ///   <para>isoprops:code : PA004/GA004^^xsd:stringisoprops:code : PA004/GA004</para>
    ///   <para>skos:scopeNote : PA04/GA04^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DateOfActivation">isoprops:DateOfActivation</a>
    /// </summary>
    let DateOfActivation = _prefixId.prefix "DateOfActivation"
    /// <summary>
    ///   <para>rdfs:comment : Datum der Validierung der An-frage zur Erstellung des Merkmals durch Sachverstaendigerdfs:comment : Date of validation of the property creation request by experts^^xsd:string</para>
    ///   <para>rdfs:label : Date of creation^^xsd:stringrdfs:label : Datum der Erstellung</para>
    ///   <para>isoprops:code : PA003/GA003^^xsd:stringisoprops:code : PA003/GA003</para>
    ///   <para>skos:scopeNote : PA003/GA003^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DateOfCreation">isoprops:DateOfCreation</a>
    /// </summary>
    let DateOfCreation = _prefixId.prefix "DateOfCreation"
    /// <summary>
    ///   <para>rdfs:label : Date of deactivation^^xsd:stringrdfs:label : Datum der Deaktivierung</para>
    ///   <para>rdfs:comment : Date of deactivation^^xsd:stringrdfs:comment : Datum der Deaktivierung</para>
    ///   <para>skos:scopeNote : PA008/GA008^^xsd:string</para>
    ///   <para>isoprops:code : PA008/GA008^^xsd:stringisoprops:code : PA008/GA008</para>
    ///   <a href="https://w3id.org/isoprops#DateOfDeactivation">isoprops:DateOfDeactivation</a>
    /// </summary>
    let DateOfDeactivation = _prefixId.prefix "DateOfDeactivation"
    /// <summary>
    ///   <para>rdfs:comment : Datum der Validierung der letzten Aenderungsanfrage durch Sachverstaendigerdfs:comment : Date of validation of the last change request by experts^^xsd:string</para>
    ///   <para>skos:scopeNote : PA005/GA005^^xsd:string</para>
    ///   <para>isoprops:code : PA005/GA005^^xsd:stringisoprops:code : PA005/GA005</para>
    ///   <para>rdfs:label : Datum der letzten Aenderungrdfs:label : Date of last change^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DateOfLastChange">isoprops:DateOfLastChange</a>
    /// </summary>
    let DateOfLastChange = _prefixId.prefix "DateOfLastChange"
    /// <summary>
    ///   <para>rdfs:comment : Datum der Ueberarbeitungrdfs:comment : Date of revision^^xsd:string</para>
    ///   <para>rdfs:label : Datum der Ueberarbeitungrdfs:label : Date of revision^^xsd:string</para>
    ///   <para>skos:scopeNote : PA006/GA006^^xsd:string</para>
    ///   <para>isoprops:code : PA006/GA006^^xsd:stringisoprops:code : PA006/GA006</para>
    ///   <a href="https://w3id.org/isoprops#DateOfRevision">isoprops:DateOfRevision</a>
    /// </summary>
    let DateOfRevision = _prefixId.prefix "DateOfRevision"
    /// <summary>
    ///   <para>rdfs:comment : Datum der Versionrdfs:comment : Date of version^^xsd:string</para>
    ///   <para>isoprops:code : PA007/GA007^^xsd:stringisoprops:code : PA007/GA007</para>
    ///   <para>rdfs:label : Datum der Versionrdfs:label : Date of version^^xsd:string</para>
    ///   <para>skos:scopeNote : PA007/GA007^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DateOfVersion">isoprops:DateOfVersion</a>
    /// </summary>
    let DateOfVersion = _prefixId.prefix "DateOfVersion"
    /// <summary>
    ///   <para>rdfs:label : Definierender Wert-Itemrdfs:label : Defining value item^^xsd:string</para>
    ///   <para>rdfs:comment : Contains a defining value of an array in the form of a literal^^xsd:stringrdfs:comment : Enthaelt einen definierenden Wert eines Arrays in Form eines Literals</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <para>isoprops:code : PA035^^xsd:stringisoprops:code : PA035</para>
    ///   <a href="https://w3id.org/isoprops#DefiningValueItem">isoprops:DefiningValueItem</a>
    /// </summary>
    let DefiningValueItem = _prefixId.prefix "DefiningValueItem"
    /// <summary>
    ///   <para>rdfs:label : Defining values list^^xsd:stringrdfs:label : Liste definierender Werte</para>
    ///   <para>isoprops:code : PA035^^xsd:stringisoprops:code : PA035</para>
    ///   <para>rdfs:comment : Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegebenrdfs:comment : In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030^^xsd:string</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DefiningValuesList">isoprops:DefiningValuesList</a>
    /// </summary>
    let DefiningValuesList = _prefixId.prefix "DefiningValuesList"
    /// <summary>
    ///   <para>skos:scopeNote : PA016/GA016^^xsd:string</para>
    ///   <para>rdfs:label : Definition in Sprache Nrdfs:label : Definition of in language N^^xsd:string</para>
    ///   <para>rdfs:comment : List of pairs (definition of the property/group of properties, language)^^xsd:stringrdfs:comment : Liste von Paaren (Definition des Merkmals/der Merkmalsgruppe, Sprache)</para>
    ///   <para>isoprops:code : PA016/GA016^^xsd:stringisoprops:code : PA016/GA016</para>
    ///   <a href="https://w3id.org/isoprops#DefinitionInLanguage">isoprops:DefinitionInLanguage</a>
    /// </summary>
    let DefinitionInLanguage = _prefixId.prefix "DefinitionInLanguage"
    /// <summary>
    ///   <para>rdfs:label : Erlaeuterung fuer die Ablehnungrdfs:label : Deprecation explanation^^xsd:string</para>
    ///   <para>skos:scopeNote : PA013/GA013^^xsd:string</para>
    ///   <para>rdfs:comment : Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)^^xsd:stringrdfs:comment : Satz, der den Grund fuer die Ablehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal/der neuen Merkmalsgruppe entsprechen; diese Erlaeuterung muss in internationalem Englisch (EN) geschrieben werden</para>
    ///   <para>isoprops:code : PA013/GA013^^xsd:stringisoprops:code : PA013/GA013</para>
    ///   <a href="https://w3id.org/isoprops#DeprecationExplanation">isoprops:DeprecationExplanation</a>
    /// </summary>
    let DeprecationExplanation = _prefixId.prefix "DeprecationExplanation"
    /// <summary>
    ///   <para>rdfs:label : Description in language N^^xsd:stringrdfs:label : Beschreibung in Sprache N</para>
    ///   <para>skos:scopeNote : PA019^^xsd:string</para>
    ///   <para>isoprops:code : PA019^^xsd:stringisoprops:code : PA019</para>
    ///   <para>rdfs:comment : Liste von Paaren (Beschreibung des Merkmals, Sprache)rdfs:comment : List of pairs (Description of the property, language)^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DescriptionInLanguage">isoprops:DescriptionInLanguage</a>
    /// </summary>
    let DescriptionInLanguage = _prefixId.prefix "DescriptionInLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Zentralisiertes Repository von Informationen ueber Daten, wie z. B. Bedeutung, Beziehungen zu anderen Daten, Ursprung, Verwendung und Formatrdfs:comment : Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format^^xsd:string</para>
    ///   <para>rdfs:label : Data dictionary^^xsd:stringrdfs:label : Datenkatalog</para>
    ///   <a href="https://w3id.org/isoprops#Dictionary">isoprops:Dictionary</a>
    /// </summary>
    let Dictionary = _prefixId.prefix "Dictionary"
    /// <summary>
    ///   <para>rdfs:label : Reference document^^xsd:stringrdfs:label : Referenzdokument</para>
    ///   <para>rdfs:comment : Publication that is consulted to find specific information, particularly in a technical or scientific domain^^xsd:stringrdfs:comment : Publikation, die hinzugezogen wird, um bestimmte Informationen zu finden, insbesondere in einer technischen oder wissenschaftlichen Domaene</para>
    ///   <a href="https://w3id.org/isoprops#DictionaryReferenceDocument">isoprops:DictionaryReferenceDocument</a>
    /// </summary>
    let DictionaryReferenceDocument = _prefixId.prefix "DictionaryReferenceDocument"
    /// <summary>
    ///   <para>rdfs:comment : Definiert eine Teilmenge oder Untergruppierung eines Datenkatalogsrdfs:comment : Defines a subset or subgrouping of a data catalog^^xsd:string</para>
    ///   <para>rdfs:label : Teilmenge des Datenkatalogsrdfs:label : Dictionary subset^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#DictionarySubset">isoprops:DictionarySubset</a>
    /// </summary>
    let DictionarySubset = _prefixId.prefix "DictionarySubset"
    /// <summary>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <para>rdfs:label : Digital format item^^xsd:stringrdfs:label : Digitales Format-Item</para>
    ///   <para>rdfs:comment : Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellenrdfs:comment : Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits^^xsd:string</para>
    ///   <para>isoprops:code : PA037^^xsd:stringisoprops:code : PA037</para>
    ///   <a href="https://w3id.org/isoprops#DigitalFormatItem">isoprops:DigitalFormatItem</a>
    /// </summary>
    let DigitalFormatItem = _prefixId.prefix "DigitalFormatItem"
    /// <summary>
    ///   <para>isoprops:code : PA031^^xsd:stringisoprops:code : PA031</para>
    ///   <para>rdfs:label : Dynamic Property^^xsd:stringrdfs:label : Dynamisches Merkmal</para>
    ///   <para>skos:scopeNote : PA031^^xsd:string</para>
    ///   <para>skos:example : no^^xsd:stringskos:example : yes^^xsd:string</para>
    ///   <para>rdfs:comment : If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032^^xsd:stringrdfs:comment : Wenn es sich um ein dynamisches Merkmal handelt, haengt der Wert von den im Attribut PA032 bereitgestellten Parametern ab</para>
    ///   <a href="https://w3id.org/isoprops#DynamicProperty">isoprops:DynamicProperty</a>
    /// </summary>
    let DynamicProperty = _prefixId.prefix "DynamicProperty"
    /// <summary>
    ///   <para>rdfs:label : Kodierungrdfs:label : Encoding^^xsd:string</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <para>rdfs:comment : The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:stringrdfs:comment : Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    ///   <para>isoprops:code : PA038^^xsd:stringisoprops:code : PA038</para>
    ///   <a href="https://w3id.org/isoprops#Encoding">isoprops:Encoding</a>
    /// </summary>
    let Encoding = _prefixId.prefix "Encoding"
    /// <summary>
    ///   <para>rdfs:label : Beispiel in Sprache Nrdfs:label : Example in language N^^xsd:string</para>
    ///   <para>isoprops:code : PA019^^xsd:stringisoprops:code : PA019</para>
    ///   <para>rdfs:comment : Liste von Paaren (Beispiel des Merkmals, Sprache)rdfs:comment : List of pairs (example of the property, language)^^xsd:string</para>
    ///   <para>skos:scopeNote : PA019^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#ExampleInLanguage">isoprops:ExampleInLanguage</a>
    /// </summary>
    let ExampleInLanguage = _prefixId.prefix "ExampleInLanguage"
    /// <summary>
    ///   <para>rdfs:label : External Dictionary Reference ^^xsd:stringrdfs:label : External Dictionary Reference</para>
    ///   <para>rdfs:comment : Paar (interner Merkmalsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// Dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werdenrdfs:comment : Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#ExternalDictionaryReference">isoprops:ExternalDictionaryReference</a>
    /// </summary>
    let ExternalDictionaryReference = _prefixId.prefix "ExternalDictionaryReference"
    /// <summary>
    ///   <para>skos:scopeNote : PA001/GA001^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identifier generated using the algorithm denoted in RFC 4122^^xsd:stringrdfs:comment : Eindeutiger Bezeichner, der mit dem in RFC 4122 beschriebenen Algorithmus erzeugt wird</para>
    ///   <para>isoprops:code : PA001/GA001^^xsd:stringisoprops:code : PA001/GA001</para>
    ///   <para>rdfs:label : Global eindeutiger Bezeichner (GUID)rdfs:label : Globally Unique Identifier (GUID)^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#GloballyUniqueIdentifier">isoprops:GloballyUniqueIdentifier</a>
    /// </summary>
    let GloballyUniqueIdentifier = _prefixId.prefix "GloballyUniqueIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Group of properties^^xsd:stringrdfs:label : Merkmalsgruppe</para>
    ///   <para>rdfs:comment : Collection enabling the properties to be prearranged or organized^^xsd:stringrdfs:comment : Sammlung, die es ermoeglicht, die Merkmale vorauszuplanen oder zu organisieren</para>
    ///   <a href="https://w3id.org/isoprops#GroupOfProperties">isoprops:GroupOfProperties</a>
    /// </summary>
    let GroupOfProperties = _prefixId.prefix "GroupOfProperties"
    /// <summary>
    ///   <para>rdfs:label : inclusive^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#Inclusive">isoprops:Inclusive</a>
    /// </summary>
    let Inclusive = _prefixId.prefix "Inclusive"
    /// <summary>
    ///   <para>rdfs:label : Messverfahrenrdfs:label : Method of measurement^^xsd:string</para>
    ///   <para>isoprops:code : PA029^^xsd:stringisoprops:code : PA029</para>
    ///   <para>rdfs:comment : Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen^^xsd:stringrdfs:comment : Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications^^xsd:string</para>
    ///   <para>skos:scopeNote : PA029^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#MethodOfMeasurement">isoprops:MethodOfMeasurement</a>
    /// </summary>
    let MethodOfMeasurement = _prefixId.prefix "MethodOfMeasurement"
    /// <summary>
    ///   <para>isoprops:code : PA016/GA016^^xsd:stringisoprops:code : PA016/GA016</para>
    ///   <para>rdfs:label : Name in language N^^xsd:stringrdfs:label : Name in Sprache N</para>
    ///   <para>skos:scopeNote : PA016/GA016^^xsd:string</para>
    ///   <para>rdfs:comment : Liste von Paaren (Name des Merkmals und Sprache)
    /// Dieses Attribut kann verwendet werden, um Synonyme fuer verschiedene Domaenen hinzuzufuegenrdfs:comment : List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#NameInLanguage">isoprops:NameInLanguage</a>
    /// </summary>
    let NameInLanguage = _prefixId.prefix "NameInLanguage"
    /// <summary>
    ///   <para>skos:scopeNote : PA034^^xsd:string</para>
    ///   <para>isoprops:code : PA034^^xsd:stringisoprops:code : PA034</para>
    ///   <para>rdfs:comment : Im Falle eines Feldes liefert dieses Attribut die Namen der Spaltenkoepfe, festgelegt als Liste von Paaren (Name, Sprache)rdfs:comment : In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)^^xsd:string</para>
    ///   <para>rdfs:label : Names of the defining values^^xsd:stringrdfs:label : Name der definierenden Werte</para>
    ///   <a href="https://w3id.org/isoprops#NameOfTheDefiningValues">isoprops:NameOfTheDefiningValues</a>
    /// </summary>
    let NameOfTheDefiningValues = _prefixId.prefix "NameOfTheDefiningValues"
    /// <summary>
    ///   <para>rdfs:comment : The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:stringrdfs:comment : Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    ///   <para>rdfs:label : Number of Characters^^xsd:stringrdfs:label : Anzahl der Zeichen</para>
    ///   <para>isoprops:code : PA038^^xsd:stringisoprops:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#NumberOfCharacters">isoprops:NumberOfCharacters</a>
    /// </summary>
    let NumberOfCharacters = _prefixId.prefix "NumberOfCharacters"
    /// <summary>
    ///   <para>rdfs:label : Physical quantity^^xsd:stringrdfs:label : Physikalische Groesse</para>
    ///   <para>rdfs:comment : List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations^^xsd:stringrdfs:comment : Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen.</para>
    ///   <a href="https://w3id.org/isoprops#PhysicalQuantity">isoprops:PhysicalQuantity</a>
    /// </summary>
    let PhysicalQuantity = _prefixId.prefix "PhysicalQuantity"
    /// <summary>
    ///   <para>rdfs:comment : Possible value for the property and language
    /// Values can be string or numbers^^xsd:stringrdfs:comment : Moeglicher Wert fuer das Merkmal und Sprache
    /// Werte koennen String oder Zahlen sein</para>
    ///   <para>isoprops:code : PA039^^xsd:stringisoprops:code : PA039</para>
    ///   <para>rdfs:label : Liste moeglicher Werte in Sprache Nrdfs:label : Possible value in language N^^xsd:string</para>
    ///   <para>skos:scopeNote : PA039^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#PossibleValues">isoprops:PossibleValues</a>
    /// </summary>
    let PossibleValues = _prefixId.prefix "PossibleValues"
    /// <summary>
    ///   <para>rdfs:label : Tolerance^^xsd:stringrdfs:label : Toleranz</para>
    ///   <para>rdfs:comment : Precision is the number of significant digits^^xsd:stringrdfs:comment : Praezision ist die Anzahl signifi-kanter Stellen</para>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <para>isoprops:code : PA037^^xsd:stringisoprops:code : PA037</para>
    ///   <a href="https://w3id.org/isoprops#Precision">isoprops:Precision</a>
    /// </summary>
    let Precision = _prefixId.prefix "Precision"
    /// <summary>
    ///   <para>rdfs:label : Merkmalrdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : Inhaerente oder erworbene Eigenschaft eines Datenelementsrdfs:comment : Inherent or acquired feature of an item^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#Property">isoprops:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    let ReferenceDocument = _prefixId.prefix "ReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : Revision number^^xsd:stringrdfs:label : Nummer der ueberarbeitung</para>
    ///   <para>skos:scopeNote : PA010/GA010^^xsd:string</para>
    ///   <para>rdfs:comment : Diese Nummer der ueberarbeitung ermoeglicht die Verfolgung kleinerer aenderungen, z. B. neue uebersetzung, Korrekturen von Tippfehlern: wenn sich die Versionsnummer aendert, beginnt die Nummer der ueberarbeitung wieder bei 1.
    /// Sachverstaendige entscheiden, ob eine neue Nummer der ueberarbeitung angewendet werden kann oder ob eine neue ueberarbeitung erforderlich ist.rdfs:comment : This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed^^xsd:string</para>
    ///   <para>isoprops:code : PA010/GA010^^xsd:stringisoprops:code : PA010/GA010</para>
    ///   <a href="https://w3id.org/isoprops#RevisionNumber">isoprops:RevisionNumber</a>
    /// </summary>
    let RevisionNumber = _prefixId.prefix "RevisionNumber"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:stringrdfs:label : Status</para>
    ///   <para>skos:example : active^^xsd:stringskos:example : inactive^^xsd:string</para>
    ///   <para>rdfs:comment : Status of the property during its life cycle^^xsd:stringrdfs:comment : Status des Merkmals waehrend seines Lebenszyklus</para>
    ///   <para>skos:scopeNote : PA002/GA002^^xsd:string</para>
    ///   <para>isoprops:code : PA002/GA002^^xsd:stringisoprops:code : PA002/GA002</para>
    ///   <a href="https://w3id.org/isoprops#Status">isoprops:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : Unterteilung der Verwendungrdfs:label : Subdivision of use^^xsd:string</para>
    ///   <para>skos:scopeNote : PA025/GA020^^xsd:string</para>
    ///   <para>isoprops:code : PA025/GA020^^xsd:stringisoprops:code : PA025/GA020</para>
    ///   <para>rdfs:comment : Dokumentierte geographische Region, in der das Merkmal/ die Merkmalsgruppe verwendet wirdrdfs:comment : Documented geographical region of use of the group of properties^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#SubdivisionOfUse">isoprops:SubdivisionOfUse</a>
    /// </summary>
    let SubdivisionOfUse = _prefixId.prefix "SubdivisionOfUse"
    /// <summary>
    ///   <para>isoprops:code : PA022^^xsd:stringisoprops:code : PA022</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:label : Symbol^^xsd:stringrdfs:label : Symbol</para>
    ///   <a href="https://w3id.org/isoprops#Symbol">isoprops:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:comment : Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))^^xsd:stringrdfs:comment : Paar (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))</para>
    ///   <para>isoprops:code : PA022^^xsd:stringisoprops:code : PA022</para>
    ///   <para>rdfs:label : Symbol des Merkmals in einer gegebenen Merkmalsgrupperdfs:label : Symbol of the property in a given property group^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#SymbolOfTheProperty">isoprops:SymbolOfTheProperty</a>
    /// </summary>
    let SymbolOfTheProperty = _prefixId.prefix "SymbolOfTheProperty"
    /// <summary>
    ///   <para>rdfs:comment : Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegtrdfs:comment : Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:string</para>
    ///   <para>rdfs:label : Text format item^^xsd:stringrdfs:label : Textformat-Item</para>
    ///   <para>isoprops:code : PA038^^xsd:stringisoprops:code : PA038</para>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#TextFormatItem">isoprops:TextFormatItem</a>
    /// </summary>
    let TextFormatItem = _prefixId.prefix "TextFormatItem"
    /// <summary>
    ///   <para>isoprops:code : PA036^^xsd:stringisoprops:code : PA036</para>
    ///   <para>rdfs:comment : Fuer numerische Werte; der Gesamtbetrag, um den eine be-stimmte Einheit schwanken darf; sie ist die Differenz zwischen dem Hoechstwert und dem Mindestwert fuer die Einheitrdfs:comment : For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit^^xsd:string</para>
    ///   <para>rdfs:label : Tolerance^^xsd:stringrdfs:label : Toleranz</para>
    ///   <para>skos:scopeNote : PA036^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#Tolerance">isoprops:Tolerance</a>
    /// </summary>
    let Tolerance = _prefixId.prefix "Tolerance"
    /// <summary>
    ///   <para>rdfs:label : Version number^^xsd:stringrdfs:label : Versionsnummer</para>
    ///   <para>isoprops:code : PA009/GA009^^xsd:stringisoprops:code : PA009/GA009</para>
    ///   <para>rdfs:comment : This version number allows tracking of major changes. Experts decide if a new version number must be applied^^xsd:stringrdfs:comment : Diese Versionsnummer ermoeglicht die Verfolgung groesserer aenderungen. Sachverstaendige entscheiden, ob eine neue Ver-sionsnummer angewendet werden muss.</para>
    ///   <para>skos:scopeNote : PA009/GA009^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#VersionNumber">isoprops:VersionNumber</a>
    /// </summary>
    let VersionNumber = _prefixId.prefix "VersionNumber"
    /// <summary>
    ///   <para>isoprops:code : PA023/GA018^^xsd:stringisoprops:code : PA023/GA018</para>
    ///   <para>rdfs:comment : Bildliche Darstellung des Merkmals durch Skizzen, Fotos, Videos oder sonstige Multimedia-Objekterdfs:comment : Visual representation of the group of properties through sketches, photos, videos or other multimedia objects^^xsd:string</para>
    ///   <para>skos:scopeNote : PA023/GA018^^xsd:string</para>
    ///   <para>rdfs:label : Bildliche Darstellungrdfs:label : Visual representation^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#VisualRepresentation">isoprops:VisualRepresentation</a>
    /// </summary>
    let VisualRepresentation = _prefixId.prefix "VisualRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:stringrdfs:label : Code</para>
    ///   <para>rdfs:comment : Code that can be used to identify the attribute^^xsd:stringrdfs:comment : Code, der zur Identifizierung des Attributs verwendet werden kann</para>
    ///   <a href="https://w3id.org/isoprops#code">isoprops:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:comment : Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)rdfs:comment : Pair (list of boundary intervals of possible values for the property, unit)^^xsd:string</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <para>rdfs:label : Boundary values^^xsd:stringrdfs:label : Grenzwerte</para>
    ///   <para>isoprops:code : PA040^^xsd:stringisoprops:code : PA040</para>
    ///   <a href="https://w3id.org/isoprops#hasBoundary">isoprops:hasBoundary</a>
    /// </summary>
    let hasBoundary = _prefixId.prefix "hasBoundary"
    /// <summary>
    ///   <para>rdfs:comment : Einzelnes Grenzwertintervallrdfs:comment : Single Boundary value interval^^xsd:string</para>
    ///   <para>rdfs:label : Grenzwertrdfs:label : Boundary value^^xsd:string</para>
    ///   <para>skos:scopeNote : PA040^^xsd:string</para>
    ///   <para>isoprops:code : PA040^^xsd:stringisoprops:code : PA040</para>
    ///   <a href="https://w3id.org/isoprops#hasBoundaryLimit">isoprops:hasBoundaryLimit</a>
    /// </summary>
    let hasBoundaryLimit = _prefixId.prefix "hasBoundaryLimit"
    /// <summary>
    ///   <para>rdfs:label : Verbundene Merkmalerdfs:label : Connected properties^^xsd:string</para>
    ///   <para>skos:scopeNote : PA020^^xsd:string</para>
    ///   <para>rdfs:comment : List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties^^xsd:stringrdfs:comment : Liste der global eindeutigen Bezeichner der verbundenen Merkmale (Attribut PA001); der Wert eines Merkmals steht zu den Werten der anderen in einer Beziehung. Beispielsweise ist ein Schallabsorptionsgrad fuer eine bestimmte Frequenz gegeben, in diesem Fall sind Schallabsorp-tionsgrad und Frequenz ver-bundene Merkmale.</para>
    ///   <para>isoprops:code : PA020^^xsd:stringisoprops:code : PA020</para>
    ///   <a href="https://w3id.org/isoprops#hasConnectedProperty">isoprops:hasConnectedProperty</a>
    /// </summary>
    let hasConnectedProperty = _prefixId.prefix "hasConnectedProperty"
    /// <summary>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <para>isoprops:code : PA035^^xsd:stringisoprops:code : PA035</para>
    ///   <para>rdfs:label : Definierende Werterdfs:label : Defining values^^xsd:string</para>
    ///   <para>rdfs:comment : Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegebenrdfs:comment : In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasDefiningValue">isoprops:hasDefiningValue</a>
    /// </summary>
    let hasDefiningValue = _prefixId.prefix "hasDefiningValue"
    /// <summary>
    ///   <para>rdfs:label : Definierender Wertrdfs:label : Defining value^^xsd:string</para>
    ///   <para>rdfs:comment : Enthaelt einen definierenden Wert eines Arraysrdfs:comment : Contains a defining value of an array^^xsd:string</para>
    ///   <para>isoprops:code : PA035^^xsd:stringisoprops:code : PA035</para>
    ///   <para>skos:scopeNote : PA035^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasDefiningValueItem">isoprops:hasDefiningValueItem</a>
    /// </summary>
    let hasDefiningValueItem = _prefixId.prefix "hasDefiningValueItem"

    /// <summary>
    ///   <para>rdfs:label : has relation to a reference document^^xsd:stringrdfs:label : hat den Verweis auf ein Referenzdokument</para>
    ///   <a href="https://w3id.org/isoprops#hasDictionaryReferenceDocument">isoprops:hasDictionaryReferenceDocument</a>
    /// </summary>
    let hasDictionaryReferenceDocument =
        _prefixId.prefix "hasDictionaryReferenceDocument"

    /// <summary>
    ///   <para>rdfs:label : has dictionary subset^^xsd:stringrdfs:label : hat Teilmenge eines Katalogs</para>
    ///   <a href="https://w3id.org/isoprops#hasDictionarySubset">isoprops:hasDictionarySubset</a>
    /// </summary>
    let hasDictionarySubset = _prefixId.prefix "hasDictionarySubset"
    /// <summary>
    ///   <para>rdfs:label : Digital format^^xsd:stringrdfs:label : Digitales Format</para>
    ///   <para>rdfs:comment : Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits^^xsd:stringrdfs:comment : Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen</para>
    ///   <para>skos:scopeNote : PA037^^xsd:string</para>
    ///   <para>isoprops:code : PA037^^xsd:stringisoprops:code : PA037</para>
    ///   <a href="https://w3id.org/isoprops#hasDigitalFormat">isoprops:hasDigitalFormat</a>
    /// </summary>
    let hasDigitalFormat = _prefixId.prefix "hasDigitalFormat"
    /// <summary>
    ///   <para>rdfs:label : has external dictionary^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasExternalDictionary">isoprops:hasExternalDictionary</a>
    /// </summary>
    let hasExternalDictionary = _prefixId.prefix "hasExternalDictionary"
    /// <summary>
    ///   <para>rdfs:label : has external dictionary property^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasExternalDictionaryProperty">isoprops:hasExternalDictionaryProperty</a>
    /// </summary>
    let hasExternalDictionaryProperty = _prefixId.prefix "hasExternalDictionaryProperty"

    /// <summary>
    ///   <para>rdfs:comment : List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties^^xsd:stringrdfs:comment : Liste von Paaren (interner Merk-malsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden</para>
    ///   <para>skos:scopeNote : GA014^^xsd:stringskos:scopeNote : PA014^^xsd:string</para>
    ///   <para>rdfs:label : hat externe Dictionary Referenzrdfs:label : has External Dictionary Reference^^xsd:string</para>
    ///   <para>isoprops:code : PA014^^xsd:stringisoprops:code : PA014isoprops:code : GA014^^xsd:stringisoprops:code : GA014</para>
    ///   <a href="https://w3id.org/isoprops#hasExternalDictionaryReference">isoprops:hasExternalDictionaryReference</a>
    /// </summary>
    let hasExternalDictionaryReference =
        _prefixId.prefix "hasExternalDictionaryReference"

    /// <summary>
    ///   <para>isoprops:code : PA022^^xsd:stringisoprops:code : PA022</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <para>rdfs:label : Gegebene Merkmalsgrupperdfs:label : Given group of properties^^xsd:string</para>
    ///   <para>rdfs:comment : Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.^^xsd:stringrdfs:comment : Global eindeutiger Bezeichner einer Merkmalsgruppe (Attribut GA001) fuer das dem Merkmal zugeordnetem Symbol</para>
    ///   <a href="https://w3id.org/isoprops#hasGivenGroupOfProperties">isoprops:hasGivenGroupOfProperties</a>
    /// </summary>
    let hasGivenGroupOfProperties = _prefixId.prefix "hasGivenGroupOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached^^xsd:stringrdfs:comment : Liste von global eindeutigen Bezeichnern von Merkmalsgruppen (Attribut GA001), denen das Merkmal angehoert</para>
    ///   <para>rdfs:label : Merkmalsgruppe(n)rdfs:label : Group(s) of properties^^xsd:string</para>
    ///   <para>skos:scopeNote : PA021^^xsd:string</para>
    ///   <para>isoprops:code : PA021^^xsd:stringisoprops:code : PA021</para>
    ///   <a href="https://w3id.org/isoprops#hasGroupOfProperties">isoprops:hasGroupOfProperties</a>
    /// </summary>
    let hasGroupOfProperties = _prefixId.prefix "hasGroupOfProperties"

    /// <summary>
    ///   <para>isoprops:code : GA032isoprops:code : PA032^^xsd:string</para>
    ///   <para>rdfs:comment : Liste von GUIDs von Merkmalen, welche Parameter der Funktion fuer ein dynamisches Merkmal sindrdfs:comment : List of GUIDS of properties which are parameters of the function for a dynamic property^^xsd:string</para>
    ///   <para>rdfs:label : Parameter des dynamischen Merkmalsrdfs:label : Parameters of the dynamic property^^xsd:string</para>
    ///   <para>skos:scopeNote : PA032^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasParameterOfTheDynamicProperty">isoprops:hasParameterOfTheDynamicProperty</a>
    /// </summary>
    let hasParameterOfTheDynamicProperty =
        _prefixId.prefix "hasParameterOfTheDynamicProperty"

    /// <summary>
    ///   <para>skos:scopeNote : GA023^^xsd:string</para>
    ///   <para>rdfs:label : uebergeordnete Merkmalsgrupperdfs:label : Parent group of properties^^xsd:string</para>
    ///   <para>isoprops:code : GA023^^xsd:stringisoprops:code : GA023</para>
    ///   <para>rdfs:comment : Ermoeglicht die Ver-knuepfung einer Unter-gruppe mit einer ueber-geordneten Gruppe ueber ihre global ein-deutigen Bezeichner (Attribut GA001)
    /// jedes einer Gruppe zugehoerige Merkmal wird von der/den Untergruppe(n) uebernommenrdfs:comment : Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasParentGroupOfProperties">isoprops:hasParentGroupOfProperties</a>
    /// </summary>
    let hasParentGroupOfProperties = _prefixId.prefix "hasParentGroupOfProperties"
    /// <summary>
    ///   <para>rdfs:comment : List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without" --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations^^xsd:stringrdfs:comment : Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen.</para>
    ///   <para>rdfs:label : Physikalische Groesserdfs:label : Physical quantity^^xsd:string</para>
    ///   <para>skos:scopeNote : PA027^^xsd:string</para>
    ///   <para>isoprops:code : PA027^^xsd:stringisoprops:code : PA027</para>
    ///   <a href="https://w3id.org/isoprops#hasPhysicalQuantity">isoprops:hasPhysicalQuantity</a>
    /// </summary>
    let hasPhysicalQuantity = _prefixId.prefix "hasPhysicalQuantity"
    /// <summary>
    ///   <para>skos:scopeNote : PA039^^xsd:string</para>
    ///   <para>rdfs:label : List of possible values in language N^^xsd:stringrdfs:label : Liste moeglicher Werte in Sprache N</para>
    ///   <para>rdfs:comment : Liste von Paaren (moeglicher Wert fuer das Merkmal und Sprache)
    /// Werte koennen String oder Zahlen seinrdfs:comment : List of pairs (possible value for the property and language)
    /// Values can be string or numbers^^xsd:string</para>
    ///   <para>isoprops:code : PA039^^xsd:stringisoprops:code : PA039</para>
    ///   <a href="https://w3id.org/isoprops#hasPossibleValues">isoprops:hasPossibleValues</a>
    /// </summary>
    let hasPossibleValues = _prefixId.prefix "hasPossibleValues"
    /// <summary>
    ///   <para>rdfs:label : has property^^xsd:stringrdfs:label : hat Merkmal</para>
    ///   <para>rdfs:comment : Attaches a property to a feature of interest (FOI)^^xsd:stringrdfs:comment : Fuegt ein Merkmal zu einem Feature of Interest (FOI) hinzu</para>
    ///   <a href="https://w3id.org/isoprops#hasProperty">isoprops:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has property group reference^^xsd:stringrdfs:label : hat Merkmalsgruppenreferenz</para>
    ///   <para>rdfs:comment : Attaches a property group reference to a isoprops:ReferenceDocument^^xsd:stringrdfs:comment : Fuegt eine Merkmalsgruppe (oberstes in der Hierarchie) zu einer isoprops:ReferenceDocument hinzu</para>
    ///   <a href="https://w3id.org/isoprops#hasPropertyGroupReference">isoprops:hasPropertyGroupReference</a>
    /// </summary>
    let hasPropertyGroupReference = _prefixId.prefix "hasPropertyGroupReference"
    /// <summary>
    ///   <para>rdfs:label : has Property Reference^^xsd:stringrdfs:label : hat Merkmalreferenz</para>
    ///   <para>rdfs:comment : Attaches a property reference to a property assignment^^xsd:stringrdfs:comment : Fuegt ein Merkmal zu einer Merkmalszuweisung hinzu</para>
    ///   <a href="https://w3id.org/isoprops#hasPropertyReference">isoprops:hasPropertyReference</a>
    /// </summary>
    let hasPropertyReference = _prefixId.prefix "hasPropertyReference"

    /// <summary>
    ///   <para>rdfs:comment : List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties^^xsd:stringrdfs:comment : Liste von Paaren (inter-ner Bezeichner der Merkmalsgruppe, ent-sprechender Daten-katalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merk-malsgruppen verwen-det werden</para>
    ///   <para>skos:scopeNote : GA014^^xsd:string</para>
    ///   <para>isoprops:code : GA014^^xsd:stringisoprops:code : GA014</para>
    ///   <para>rdfs:label : Beziehung der Bezeichner der Merkmalsgruppe in den miteinander verbundenen Datenkatalogenrdfs:label : Relations of the group of properties identifiers in the interconnected data dictionaries^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">isoprops:hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</a>
    /// </summary>
    let hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefixId.prefix "hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    ///   <para>rdfs:label : Symbols of the property in a given property group^^xsd:stringrdfs:label : Symbole des Merkmals in einer gegebenen Merk-malsgruppe</para>
    ///   <para>isoprops:code : PA022^^xsd:stringisoprops:code : PA022</para>
    ///   <para>rdfs:comment : Liste von Paaren (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))rdfs:comment : List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))^^xsd:string</para>
    ///   <para>skos:scopeNote : PA022^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasSymbolsOfTheProperty">isoprops:hasSymbolsOfTheProperty</a>
    /// </summary>
    let hasSymbolsOfTheProperty = _prefixId.prefix "hasSymbolsOfTheProperty"
    /// <summary>
    ///   <para>skos:scopeNote : PA038^^xsd:string</para>
    ///   <para>rdfs:label : Textformatrdfs:label : Text format^^xsd:string</para>
    ///   <para>rdfs:comment : Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegtrdfs:comment : Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978^^xsd:string</para>
    ///   <para>isoprops:code : PA038^^xsd:stringisoprops:code : PA038</para>
    ///   <a href="https://w3id.org/isoprops#hasTextFormat">isoprops:hasTextFormat</a>
    /// </summary>
    let hasTextFormat = _prefixId.prefix "hasTextFormat"
    /// <summary>
    ///   <para>skos:scopeNote : PA033^^xsd:string</para>
    ///   <para>isoprops:code : PA033^^xsd:stringisoprops:code : PA033</para>
    ///   <para>rdfs:comment : A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless --&gt; http://qudt.org/vocab/unit/UNITLESS^^xsd:stringrdfs:comment : Eine Einheit zur Darstellung einer Skala, die es ermoeglicht, einen Wert zu messen
    /// es ist moeglich, dieses Attribut zu verwenden, um zu erlaeutern, dass dem Merkmal keine Einheit zugeordnet ist, indem einheitslos verwendet wird --&gt; http://qudt.org/vocab/unit/UNITLESS</para>
    ///   <para>rdfs:label : hat Einheitrdfs:label : has unit^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#hasUnit">isoprops:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : Liste ersetzender Merkmalsgruppenrdfs:label : List of replacing groups of properties^^xsd:string</para>
    ///   <para>rdfs:comment : Liste von globalen Bezeichnern fuer die ersetzenden Merkmalsgruppenrdfs:comment : List of globally unique identifiers of the replacing groups of properties^^xsd:string</para>
    ///   <para>skos:scopeNote : GA012^^xsd:string</para>
    ///   <para>isoprops:code : GA012^^xsd:stringisoprops:code : GA012</para>
    ///   <a href="https://w3id.org/isoprops#isReplacedByGroupOfProperties">isoprops:isReplacedByGroupOfProperties</a>
    /// </summary>
    let isReplacedByGroupOfProperties = _prefixId.prefix "isReplacedByGroupOfProperties"
    /// <summary>
    ///   <para>isoprops:code : PA012^^xsd:stringisoprops:code : PA012</para>
    ///   <para>rdfs:label : List of replacing properties^^xsd:stringrdfs:label : Liste ersetzender Merkmale</para>
    ///   <para>skos:scopeNote : PA012^^xsd:string</para>
    ///   <para>rdfs:comment : Globally unique identifier (attribute PA001) of the replacing property (or properties)^^xsd:stringrdfs:comment : global eindeutiger Bezeichner (Attribut PA001) des ersetzenden Merkmals (oder der Merkmale)</para>
    ///   <a href="https://w3id.org/isoprops#isReplacedByProperty">isoprops:isReplacedByProperty</a>
    /// </summary>
    let isReplacedByProperty = _prefixId.prefix "isReplacedByProperty"
    /// <summary>
    ///   <para>rdfs:label : List of replaced groups of properties^^xsd:stringrdfs:label : Liste ersetzter Merkmalsgruppen</para>
    ///   <para>isoprops:code : GA011^^xsd:stringisoprops:code : GA011</para>
    ///   <para>skos:scopeNote : GA011^^xsd:string</para>
    ///   <para>rdfs:comment : Liste von globalen Bezeichnern fuer die ersetzten Merk-malsgruppenrdfs:comment : List of globally unique identifiers of the replaced groups of properties^^xsd:string</para>
    ///   <a href="https://w3id.org/isoprops#replacesGroupOfProperties">isoprops:replacesGroupOfProperties</a>
    /// </summary>
    let replacesGroupOfProperties = _prefixId.prefix "replacesGroupOfProperties"
    /// <summary>
    ///   <para>skos:scopeNote : PA011^^xsd:string</para>
    ///   <para>rdfs:comment : Globally unique identifier of the replaced property (or properties)^^xsd:stringrdfs:comment : Global eindeutiger Bezeichner des ersetzten Merkmals (oder der Merkmale)</para>
    ///   <para>rdfs:label : List of replaced properties^^xsd:stringrdfs:label : Liste ersetzter Merkmale</para>
    ///   <para>isoprops:code : PA011^^xsd:stringisoprops:code : PA011</para>
    ///   <a href="https://w3id.org/isoprops#replacesProperties">isoprops:replacesProperties</a>
    /// </summary>
    let replacesProperties = _prefixId.prefix "replacesProperties"

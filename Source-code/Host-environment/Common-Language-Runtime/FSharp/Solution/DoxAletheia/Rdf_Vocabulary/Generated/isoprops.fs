namespace https.w3id.org.isoprops.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module isoprops =
    let _namespace_iri = Namespace_Iri isoprops |> NamespaceIRI
    /// <summary>
    ///   <para>isoprops:RevisionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed</para>
    ///   <para>Diese Nummer der ueberarbeitung ermoeglicht die Verfolgung kleinerer aenderungen, z. B. neue uebersetzung, Korrekturen von Tippfehlern: wenn sich die Versionsnummer aendert, beginnt die Nummer der ueberarbeitung wieder bei 1.
    /// Sachverstaendige entscheiden, ob eine neue Nummer der ueberarbeitung angewendet werden kann oder ob eine neue ueberarbeitung erforderlich ist.</para>
    /// labels<para>Nummer der ueberarbeitung</para><para>Revision number</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#RevisionNumber">https://w3id.org/isoprops#RevisionNumber</seealso>
    let RevisionNumber = Prefixed_Name(isoprops, "RevisionNumber") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:isReplacedByGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of globally unique identifiers of the replacing groups of properties</para>
    ///   <para>Liste von globalen Bezeichnern fuer die ersetzenden Merkmalsgruppen</para>
    /// labels<para>List of replacing groups of properties</para><para>Liste ersetzender Merkmalsgruppen</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#isReplacedByGroupOfProperties">https://w3id.org/isoprops#isReplacedByGroupOfProperties</seealso>
    let isReplacedByGroupOfProperties =
        Prefixed_Name(isoprops, "isReplacedByGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:VisualRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Bildliche Darstellung des Merkmals durch Skizzen, Fotos, Videos oder sonstige Multimedia-Objekte</para>
    ///   <para>Visual representation of the group of properties through sketches, photos, videos or other multimedia objects</para>
    /// labels<para>Bildliche Darstellung</para><para>Visual representation</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#VisualRepresentation">https://w3id.org/isoprops#VisualRepresentation</seealso>
    let VisualRepresentation =
        Prefixed_Name(isoprops, "VisualRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:NameInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Liste von Paaren (Name des Merkmals und Sprache)
    /// Dieses Attribut kann verwendet werden, um Synonyme fuer verschiedene Domaenen hinzuzufuegen</para>
    ///   <para>List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains</para>
    /// labels<para>Name in language N</para><para>Name in Sprache N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NameInLanguage">https://w3id.org/isoprops#NameInLanguage</seealso>
    let NameInLanguage = Prefixed_Name(isoprops, "NameInLanguage") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/isoprops#">https://w3id.org/isoprops#</seealso>
    let _prefix_iri = Prefixed_Name(isoprops, "") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasDefiningValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contains a defining value of an array</para>
    ///   <para>Enthaelt einen definierenden Wert eines Arrays</para>
    /// labels<para>Definierender Wert</para><para>Defining value</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDefiningValueItem">https://w3id.org/isoprops#hasDefiningValueItem</seealso>
    let hasDefiningValueItem =
        Prefixed_Name(isoprops, "hasDefiningValueItem") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zentralisiertes Repository von Informationen ueber Daten, wie z. B. Bedeutung, Beziehungen zu anderen Daten, Ursprung, Verwendung und Format</para>
    ///   <para>Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format</para>
    /// labels<para>Data dictionary</para><para>Datenkatalog</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Dictionary">https://w3id.org/isoprops#Dictionary</seealso>
    let Dictionary = Prefixed_Name(isoprops, "Dictionary") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasDictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hat Teilmenge eines Katalogs</para><para>has dictionary subset</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDictionarySubset">https://w3id.org/isoprops#hasDictionarySubset</seealso>
    let hasDictionarySubset =
        Prefixed_Name(isoprops, "hasDictionarySubset") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasPropertyGroupReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Attaches a property group reference to a isoprops:ReferenceDocument</para>
    ///   <para>Fuegt eine Merkmalsgruppe (oberstes in der Hierarchie) zu einer isoprops:ReferenceDocument hinzu</para>
    /// labels<para>has property group reference</para><para>hat Merkmalsgruppenreferenz</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPropertyGroupReference">https://w3id.org/isoprops#hasPropertyGroupReference</seealso>
    let hasPropertyGroupReference =
        Prefixed_Name(isoprops, "hasPropertyGroupReference") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definiert eine Teilmenge oder Untergruppierung eines Datenkatalogs</para>
    ///   <para>Defines a subset or subgrouping of a data catalog</para>
    /// labels<para>Teilmenge des Datenkatalogs</para><para>Dictionary subset</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DictionarySubset">https://w3id.org/isoprops#DictionarySubset</seealso>
    let DictionarySubset = Prefixed_Name(isoprops, "DictionarySubset") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DigitalFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits</para>
    ///   <para>Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen</para>
    /// labels<para>Digitales Format-Item</para><para>Digital format item</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DigitalFormatItem">https://w3id.org/isoprops#DigitalFormatItem</seealso>
    let DigitalFormatItem = Prefixed_Name(isoprops, "DigitalFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Praezision ist die Anzahl signifi-kanter Stellen</para>
    ///   <para>Precision is the number of significant digits</para>
    /// labels<para>Tolerance</para><para>Toleranz</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Precision">https://w3id.org/isoprops#Precision</seealso>
    let Precision = Prefixed_Name(isoprops, "Precision") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasExternalDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has external dictionary</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionary">https://w3id.org/isoprops#hasExternalDictionary</seealso>
    let hasExternalDictionary =
        Prefixed_Name(isoprops, "hasExternalDictionary") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasExternalDictionaryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has external dictionary property</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionaryProperty">https://w3id.org/isoprops#hasExternalDictionaryProperty</seealso>
    let hasExternalDictionaryProperty =
        Prefixed_Name(isoprops, "hasExternalDictionaryProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Attaches a property to a feature of interest (FOI)</para>
    ///   <para>Fuegt ein Merkmal zu einem Feature of Interest (FOI) hinzu</para>
    /// labels<para>has property</para><para>hat Merkmal</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasProperty">https://w3id.org/isoprops#hasProperty</seealso>
    let hasProperty = Prefixed_Name(isoprops, "hasProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Liste von Paaren (inter-ner Bezeichner der Merkmalsgruppe, ent-sprechender Daten-katalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merk-malsgruppen verwen-det werden</para>
    ///   <para>List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties</para>
    /// labels<para>Beziehung der Bezeichner der Merkmalsgruppe in den miteinander verbundenen Datenkatalogen</para><para>Relations of the group of properties identifiers in the interconnected data dictionaries</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(isoprops, "hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:AssignedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Repraesentiert die Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)</para>
    ///   <para>Represents the assignment of a property and a property state to a feature of interest (FOI).</para>
    /// labels<para>Zugewiesenes Merkmal</para><para>Assigned property</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#AssignedProperty">https://w3id.org/isoprops#AssignedProperty</seealso>
    let AssignedProperty = Prefixed_Name(isoprops, "AssignedProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasGivenGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.</para>
    ///   <para>Global eindeutiger Bezeichner einer Merkmalsgruppe (Attribut GA001) fuer das dem Merkmal zugeordnetem Symbol</para>
    /// labels<para>Given group of properties</para><para>Gegebene Merkmalsgruppe</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasGivenGroupOfProperties">https://w3id.org/isoprops#hasGivenGroupOfProperties</seealso>
    let hasGivenGroupOfProperties =
        Prefixed_Name(isoprops, "hasGivenGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Publication that is consulted to find specific information, particularly in a technical or scientific domain</para>
    ///   <para>Publikation, die hinzugezogen wird, um bestimmte Informationen zu finden, insbesondere in einer technischen oder wissenschaftlichen Domaene</para>
    /// labels<para>Reference document</para><para>Referenzdokument</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DictionaryReferenceDocument">https://w3id.org/isoprops#DictionaryReferenceDocument</seealso>
    let DictionaryReferenceDocument =
        Prefixed_Name(isoprops, "DictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasDictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hat den Verweis auf ein Referenzdokument</para><para>has relation to a reference document</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDictionaryReferenceDocument">https://w3id.org/isoprops#hasDictionaryReferenceDocument</seealso>
    let hasDictionaryReferenceDocument =
        Prefixed_Name(isoprops, "hasDictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasPropertyReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Attaches a property reference to a property assignment</para>
    ///   <para>Fuegt ein Merkmal zu einer Merkmalszuweisung hinzu</para>
    /// labels<para>has Property Reference</para><para>hat Merkmalreferenz</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPropertyReference">https://w3id.org/isoprops#hasPropertyReference</seealso>
    let hasPropertyReference =
        Prefixed_Name(isoprops, "hasPropertyReference") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:BoundaryLimitMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Boundary limit  interval consisting of the the upper (maxValue) interval boundary</para>
    ///   <para>Grenzwertintervall bestehend aus der oberen(maxValue) Intervallgrenze</para>
    /// labels<para>Maximum Boundary Limit</para><para>Oberer Grenzwert</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryLimitMax">https://w3id.org/isoprops#BoundaryLimitMax</seealso>
    let BoundaryLimitMax = Prefixed_Name(isoprops, "BoundaryLimitMax") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless --&gt; http://qudt.org/vocab/unit/UNITLESS</para>
    ///   <para>Eine Einheit zur Darstellung einer Skala, die es ermoeglicht, einen Wert zu messen
    /// es ist moeglich, dieses Attribut zu verwenden, um zu erlaeutern, dass dem Merkmal keine Einheit zugeordnet ist, indem einheitslos verwendet wird --&gt; http://qudt.org/vocab/unit/UNITLESS</para>
    /// labels<para>hat Einheit</para><para>has unit</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasUnit">https://w3id.org/isoprops#hasUnit</seealso>
    let hasUnit = Prefixed_Name(isoprops, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:ReferenceDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/isoprops#ReferenceDocument">https://w3id.org/isoprops#ReferenceDocument</seealso>
    let ReferenceDocument = Prefixed_Name(isoprops, "ReferenceDocument") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Wenn es sich um ein dynamisches Merkmal handelt, haengt der Wert von den im Attribut PA032 bereitgestellten Parametern ab</para>
    ///   <para>If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032</para>
    /// labels<para>Dynamisches Merkmal</para><para>Dynamic Property</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DynamicProperty">https://w3id.org/isoprops#DynamicProperty</seealso>
    let DynamicProperty = Prefixed_Name(isoprops, "DynamicProperty") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The encoding is set according to Name of encoding standard of IANA, RFC 2978</para>
    ///   <para>Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    /// labels<para>Kodierung</para><para>Encoding</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Encoding">https://w3id.org/isoprops#Encoding</seealso>
    let Encoding = Prefixed_Name(isoprops, "Encoding") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:TextFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978</para>
    ///   <para>Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    /// labels<para>Text format item</para><para>Textformat-Item</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#TextFormatItem">https://w3id.org/isoprops#TextFormatItem</seealso>
    let TextFormatItem = Prefixed_Name(isoprops, "TextFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:ExampleInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Liste von Paaren (Beispiel des Merkmals, Sprache)</para>
    ///   <para>List of pairs (example of the property, language)</para>
    /// labels<para>Beispiel in Sprache N</para><para>Example in language N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#ExampleInLanguage">https://w3id.org/isoprops#ExampleInLanguage</seealso>
    let ExampleInLanguage = Prefixed_Name(isoprops, "ExampleInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:ExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties</para>
    ///   <para>Paar (interner Merkmalsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// Dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden</para>
    /// labels<para>External Dictionary Reference </para><para>External Dictionary Reference</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#ExternalDictionaryReference">https://w3id.org/isoprops#ExternalDictionaryReference</seealso>
    let ExternalDictionaryReference =
        Prefixed_Name(isoprops, "ExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:Inclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>inclusive</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Inclusive">https://w3id.org/isoprops#Inclusive</seealso>
    let Inclusive = Prefixed_Name(isoprops, "Inclusive") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:BoundaryLimitMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Boundary limit interval consisting of the lower(minValue) interval boundary</para>
    ///   <para>Grenzwertintervall bestehend aus der unteren(minValue) Intervallgrenze</para>
    /// labels<para>Minimum Boundary Limit</para><para>Unterer Grenzwert</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryLimitMin">https://w3id.org/isoprops#BoundaryLimitMin</seealso>
    let BoundaryLimitMin = Prefixed_Name(isoprops, "BoundaryLimitMin") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:BoundaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Pair  (List of boundary intervals of possible values for the property, unit)</para>
    ///   <para>Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)</para>
    /// labels<para>Boundary values list</para><para>Grenzwertliste</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryValue">https://w3id.org/isoprops#BoundaryValue</seealso>
    let BoundaryValue = Prefixed_Name(isoprops, "BoundaryValue") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:hasBoundaryLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Single Boundary value interval</para>
    ///   <para>Einzelnes Grenzwertintervall</para>
    /// labels<para>Boundary value</para><para>Grenzwert</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasBoundaryLimit">https://w3id.org/isoprops#hasBoundaryLimit</seealso>
    let hasBoundaryLimit = Prefixed_Name(isoprops, "hasBoundaryLimit") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:CategoryOfGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the category of the created property group</para>
    ///   <para>Gibt die Kategorie der erstellten Merkmalsgruppe an</para>
    /// labels<para>Category of group of properties</para><para>Kategorie der Merkmalsgruppe</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CategoryOfGroupOfProperties">https://w3id.org/isoprops#CategoryOfGroupOfProperties</seealso>
    let CategoryOfGroupOfProperties =
        Prefixed_Name(isoprops, "CategoryOfGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:GroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection enabling the properties to be prearranged or organized</para>
    ///   <para>Sammlung, die es ermoeglicht, die Merkmale vorauszuplanen oder zu organisieren</para>
    /// labels<para>Group of properties</para><para>Merkmalsgruppe</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#GroupOfProperties">https://w3id.org/isoprops#GroupOfProperties</seealso>
    let GroupOfProperties = Prefixed_Name(isoprops, "GroupOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:CountryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Land, aus dem die Anforderung an dieses Merkmal/dieser Merkmalsgruppe stammt</para>
    ///   <para>Country from where the requirement for this property/group of properties originated</para>
    /// labels<para>Country of origin</para><para>Ursprungsland</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CountryOfOrigin">https://w3id.org/isoprops#CountryOfOrigin</seealso>
    let CountryOfOrigin = Prefixed_Name(isoprops, "CountryOfOrigin") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:CountryOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Land (Gruppe von Laendern, Kon-tinent), in dem das Merkmal/die Merkmalsgruppe fuer den Markt, auf dem die Beteiligten arbeiten, relevant ist</para>
    ///   <para>Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in</para>
    /// labels<para>Land der Verwendung</para><para>Country of use</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CountryOfUse">https://w3id.org/isoprops#CountryOfUse</seealso>
    let CountryOfUse = Prefixed_Name(isoprops, "CountryOfUse") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula</para>
    ///   <para>Format fuer die Angabe des Wertes des Merkmals
    /// dies kann aus einer Soft-ware-Perspektive als Speiche-rungsart verstanden werden
    /// im Falle eines dynamischen Merkmals ist der Wert dieses Attributs der Datentyp des Er-gebnisses der Berechnung mit der Gleichung</para>
    /// labels<para>Datentyp (GUID)</para><para>Data type</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DataType">https://w3id.org/isoprops#DataType</seealso>
    let DataType = Prefixed_Name(isoprops, "DataType") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DateOfDeactivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of deactivation</para>
    ///   <para>Datum der Deaktivierung</para>
    /// labels<para>Datum der Deaktivierung</para><para>Date of deactivation</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfDeactivation">https://w3id.org/isoprops#DateOfDeactivation</seealso>
    let DateOfDeactivation =
        Prefixed_Name(isoprops, "DateOfDeactivation") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DateOfLastChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of validation of the last change request by experts</para>
    ///   <para>Datum der Validierung der letzten Aenderungsanfrage durch Sachverstaendige</para>
    /// labels<para>Datum der letzten Aenderung</para><para>Date of last change</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfLastChange">https://w3id.org/isoprops#DateOfLastChange</seealso>
    let DateOfLastChange = Prefixed_Name(isoprops, "DateOfLastChange") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DateOfVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datum der Version</para>
    ///   <para>Date of version</para>
    /// labels<para>Datum der Version</para><para>Date of version</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfVersion">https://w3id.org/isoprops#DateOfVersion</seealso>
    let DateOfVersion = Prefixed_Name(isoprops, "DateOfVersion") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DefiningValuesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030</para>
    ///   <para>Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben</para>
    /// labels<para>Liste definierender Werte</para><para>Defining values list</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefiningValuesList">https://w3id.org/isoprops#DefiningValuesList</seealso>
    let DefiningValuesList =
        Prefixed_Name(isoprops, "DefiningValuesList") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DefinitionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Liste von Paaren (Definition des Merkmals/der Merkmalsgruppe, Sprache)</para>
    ///   <para>List of pairs (definition of the property/group of properties, language)</para>
    /// labels<para>Definition of in language N</para><para>Definition in Sprache N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefinitionInLanguage">https://w3id.org/isoprops#DefinitionInLanguage</seealso>
    let DefinitionInLanguage =
        Prefixed_Name(isoprops, "DefinitionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DeprecationExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)</para>
    ///   <para>Satz, der den Grund fuer die Ablehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal/der neuen Merkmalsgruppe entsprechen; diese Erlaeuterung muss in internationalem Englisch (EN) geschrieben werden</para>
    /// labels<para>Erlaeuterung fuer die Ablehnung</para><para>Deprecation explanation</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DeprecationExplanation">https://w3id.org/isoprops#DeprecationExplanation</seealso>
    let DeprecationExplanation =
        Prefixed_Name(isoprops, "DeprecationExplanation") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DescriptionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Liste von Paaren (Beschreibung des Merkmals, Sprache)</para>
    ///   <para>List of pairs (Description of the property, language)</para>
    /// labels<para>Beschreibung in Sprache N</para><para>Description in language N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DescriptionInLanguage">https://w3id.org/isoprops#DescriptionInLanguage</seealso>
    let DescriptionInLanguage =
        Prefixed_Name(isoprops, "DescriptionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:SubdivisionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Dokumentierte geographische Region, in der das Merkmal/ die Merkmalsgruppe verwendet wird</para>
    ///   <para>Documented geographical region of use of the group of properties</para>
    /// labels<para>Unterteilung der Verwendung</para><para>Subdivision of use</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#SubdivisionOfUse">https://w3id.org/isoprops#SubdivisionOfUse</seealso>
    let SubdivisionOfUse = Prefixed_Name(isoprops, "SubdivisionOfUse") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Code that can be used to identify the attribute</para>
    ///   <para>Code, der zur Identifizierung des Attributs verwendet werden kann</para>
    /// labels<para>Code</para><para>Code</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#code">https://w3id.org/isoprops#code</seealso>
    let code = Prefixed_Name(isoprops, "code") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:replacesGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of globally unique identifiers of the replaced groups of properties</para>
    ///   <para>Liste von globalen Bezeichnern fuer die ersetzten Merk-malsgruppen</para>
    /// labels<para>List of replaced groups of properties</para><para>Liste ersetzter Merkmalsgruppen</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#replacesGroupOfProperties">https://w3id.org/isoprops#replacesGroupOfProperties</seealso>
    let replacesGroupOfProperties =
        Prefixed_Name(isoprops, "replacesGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Liste von Paaren (interner Merk-malsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden</para>
    ///   <para>List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties</para>
    /// labels<para>has External Dictionary Reference</para><para>hat externe Dictionary Referenz</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionaryReference">https://w3id.org/isoprops#hasExternalDictionaryReference</seealso>
    let hasExternalDictionaryReference =
        Prefixed_Name(isoprops, "hasExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasParentGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ermoeglicht die Ver-knuepfung einer Unter-gruppe mit einer ueber-geordneten Gruppe ueber ihre global ein-deutigen Bezeichner (Attribut GA001)
    /// jedes einer Gruppe zugehoerige Merkmal wird von der/den Untergruppe(n) uebernommen</para>
    ///   <para>Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)</para>
    /// labels<para>uebergeordnete Merkmalsgruppe</para><para>Parent group of properties</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasParentGroupOfProperties">https://w3id.org/isoprops#hasParentGroupOfProperties</seealso>
    let hasParentGroupOfProperties =
        Prefixed_Name(isoprops, "hasParentGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:VersionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This version number allows tracking of major changes. Experts decide if a new version number must be applied</para>
    ///   <para>Diese Versionsnummer ermoeglicht die Verfolgung groesserer aenderungen. Sachverstaendige entscheiden, ob eine neue Ver-sionsnummer angewendet werden muss.</para>
    /// labels<para>Versionsnummer</para><para>Version number</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#VersionNumber">https://w3id.org/isoprops#VersionNumber</seealso>
    let VersionNumber = Prefixed_Name(isoprops, "VersionNumber") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of the property during its life cycle</para>
    ///   <para>Status des Merkmals waehrend seines Lebenszyklus</para>
    /// labels<para>Status</para><para>Status</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Status">https://w3id.org/isoprops#Status</seealso>
    let Status = Prefixed_Name(isoprops, "Status") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:MethodOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications</para>
    ///   <para>Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen</para>
    /// labels<para>Method of measurement</para><para>Messverfahren</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#MethodOfMeasurement">https://w3id.org/isoprops#MethodOfMeasurement</seealso>
    let MethodOfMeasurement =
        Prefixed_Name(isoprops, "MethodOfMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:NameOfTheDefiningValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Im Falle eines Feldes liefert dieses Attribut die Namen der Spaltenkoepfe, festgelegt als Liste von Paaren (Name, Sprache)</para>
    ///   <para>In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)</para>
    /// labels<para>Name der definierenden Werte</para><para>Names of the defining values</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NameOfTheDefiningValues">https://w3id.org/isoprops#NameOfTheDefiningValues</seealso>
    let NameOfTheDefiningValues =
        Prefixed_Name(isoprops, "NameOfTheDefiningValues") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:PhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations</para>
    ///   <para>Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen.</para>
    /// labels<para>Physikalische Groesse</para><para>Physical quantity</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#PhysicalQuantity">https://w3id.org/isoprops#PhysicalQuantity</seealso>
    let PhysicalQuantity = Prefixed_Name(isoprops, "PhysicalQuantity") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:PossibleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Possible value for the property and language
    /// Values can be string or numbers</para>
    ///   <para>Moeglicher Wert fuer das Merkmal und Sprache
    /// Werte koennen String oder Zahlen sein</para>
    /// labels<para>Liste moeglicher Werte in Sprache N</para><para>Possible value in language N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#PossibleValues">https://w3id.org/isoprops#PossibleValues</seealso>
    let PossibleValues = Prefixed_Name(isoprops, "PossibleValues") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:Tolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Fuer numerische Werte; der Gesamtbetrag, um den eine be-stimmte Einheit schwanken darf; sie ist die Differenz zwischen dem Hoechstwert und dem Mindestwert fuer die Einheit</para>
    ///   <para>For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit</para>
    /// labels<para>Tolerance</para><para>Toleranz</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Tolerance">https://w3id.org/isoprops#Tolerance</seealso>
    let Tolerance = Prefixed_Name(isoprops, "Tolerance") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inhaerente oder erworbene Eigenschaft eines Datenelements</para>
    ///   <para>Inherent or acquired feature of an item</para>
    /// labels<para>Property</para><para>Merkmal</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Property">https://w3id.org/isoprops#Property</seealso>
    let Property = Prefixed_Name(isoprops, "Property") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:CreatorsLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Satz, der den Grund fuer die Ab-lehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal entsprechen; diese Er-laeuterung muss in internatio-nalem Englisch (EN) geschrieben werden</para>
    ///   <para>Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)</para>
    /// labels<para>Erlaeuterung fuer die Ablehnung</para><para>Creator's language</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CreatorsLanguage">https://w3id.org/isoprops#CreatorsLanguage</seealso>
    let CreatorsLanguage = Prefixed_Name(isoprops, "CreatorsLanguage") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DateOfActivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date after when the property can be used</para>
    ///   <para>Datum, nach dem das Merkmal verwendet werden kann</para>
    /// labels<para>Datum der Aktivierung</para><para>Date of activation</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfActivation">https://w3id.org/isoprops#DateOfActivation</seealso>
    let DateOfActivation = Prefixed_Name(isoprops, "DateOfActivation") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:NumberOfCharacters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    ///   <para>The encoding is set according to Name of encoding standard of IANA, RFC 2978</para>
    /// labels<para>Number of Characters</para><para>Anzahl der Zeichen</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NumberOfCharacters">https://w3id.org/isoprops#NumberOfCharacters</seealso>
    let NumberOfCharacters =
        Prefixed_Name(isoprops, "NumberOfCharacters") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasPossibleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of pairs (possible value for the property and language)
    /// Values can be string or numbers</para>
    ///   <para>Liste von Paaren (moeglicher Wert fuer das Merkmal und Sprache)
    /// Werte koennen String oder Zahlen sein</para>
    /// labels<para>List of possible values in language N</para><para>Liste moeglicher Werte in Sprache N</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPossibleValues">https://w3id.org/isoprops#hasPossibleValues</seealso>
    let hasPossibleValues = Prefixed_Name(isoprops, "hasPossibleValues") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasConnectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties</para>
    ///   <para>Liste der global eindeutigen Bezeichner der verbundenen Merkmale (Attribut PA001); der Wert eines Merkmals steht zu den Werten der anderen in einer Beziehung. Beispielsweise ist ein Schallabsorptionsgrad fuer eine bestimmte Frequenz gegeben, in diesem Fall sind Schallabsorp-tionsgrad und Frequenz ver-bundene Merkmale.</para>
    /// labels<para>Connected properties</para><para>Verbundene Merkmale</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasConnectedProperty">https://w3id.org/isoprops#hasConnectedProperty</seealso>
    let hasConnectedProperty =
        Prefixed_Name(isoprops, "hasConnectedProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasDigitalFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen</para>
    ///   <para>Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits</para>
    /// labels<para>Digitales Format</para><para>Digital format</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDigitalFormat">https://w3id.org/isoprops#hasDigitalFormat</seealso>
    let hasDigitalFormat = Prefixed_Name(isoprops, "hasDigitalFormat") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasPhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without" --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations</para>
    ///   <para>Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen.</para>
    /// labels<para>Physikalische Groesse</para><para>Physical quantity</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPhysicalQuantity">https://w3id.org/isoprops#hasPhysicalQuantity</seealso>
    let hasPhysicalQuantity =
        Prefixed_Name(isoprops, "hasPhysicalQuantity") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached</para>
    ///   <para>Liste von global eindeutigen Bezeichnern von Merkmalsgruppen (Attribut GA001), denen das Merkmal angehoert</para>
    /// labels<para>Group(s) of properties</para><para>Merkmalsgruppe(n)</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasGroupOfProperties">https://w3id.org/isoprops#hasGroupOfProperties</seealso>
    let hasGroupOfProperties =
        Prefixed_Name(isoprops, "hasGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Pair (list of boundary intervals of possible values for the property, unit)</para>
    ///   <para>Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)</para>
    /// labels<para>Boundary values</para><para>Grenzwerte</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasBoundary">https://w3id.org/isoprops#hasBoundary</seealso>
    let hasBoundary = Prefixed_Name(isoprops, "hasBoundary") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:SymbolOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))</para>
    ///   <para>Paar (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))</para>
    /// labels<para>Symbol des Merkmals in einer gegebenen Merkmalsgruppe</para><para>Symbol of the property in a given property group</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#SymbolOfTheProperty">https://w3id.org/isoprops#SymbolOfTheProperty</seealso>
    let SymbolOfTheProperty =
        Prefixed_Name(isoprops, "SymbolOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DateOfCreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of validation of the property creation request by experts</para>
    ///   <para>Datum der Validierung der An-frage zur Erstellung des Merkmals durch Sachverstaendige</para>
    /// labels<para>Datum der Erstellung</para><para>Date of creation</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfCreation">https://w3id.org/isoprops#DateOfCreation</seealso>
    let DateOfCreation = Prefixed_Name(isoprops, "DateOfCreation") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:replacesProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Global eindeutiger Bezeichner des ersetzten Merkmals (oder der Merkmale)</para>
    ///   <para>Globally unique identifier of the replaced property (or properties)</para>
    /// labels<para>List of replaced properties</para><para>Liste ersetzter Merkmale</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#replacesProperties">https://w3id.org/isoprops#replacesProperties</seealso>
    let replacesProperties =
        Prefixed_Name(isoprops, "replacesProperties") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:DateOfRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datum der Ueberarbeitung</para>
    ///   <para>Date of revision</para>
    /// labels<para>Datum der Ueberarbeitung</para><para>Date of revision</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfRevision">https://w3id.org/isoprops#DateOfRevision</seealso>
    let DateOfRevision = Prefixed_Name(isoprops, "DateOfRevision") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:DefiningValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enthaelt einen definierenden Wert eines Arrays in Form eines Literals</para>
    ///   <para>Contains a defining value of an array in the form of a literal</para>
    /// labels<para>Definierender Wert-Item</para><para>Defining value item</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefiningValueItem">https://w3id.org/isoprops#DefiningValueItem</seealso>
    let DefiningValueItem = Prefixed_Name(isoprops, "DefiningValueItem") |> PrefixedName
    /// <summary>
    ///   <para>isoprops:hasTextFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978</para>
    ///   <para>Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt</para>
    /// labels<para>Text format</para><para>Textformat</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasTextFormat">https://w3id.org/isoprops#hasTextFormat</seealso>
    let hasTextFormat = Prefixed_Name(isoprops, "hasTextFormat") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasSymbolsOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Liste von Paaren (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))</para>
    ///   <para>List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))</para>
    /// labels<para>Symbole des Merkmals in einer gegebenen Merk-malsgruppe</para><para>Symbols of the property in a given property group</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasSymbolsOfTheProperty">https://w3id.org/isoprops#hasSymbolsOfTheProperty</seealso>
    let hasSymbolsOfTheProperty =
        Prefixed_Name(isoprops, "hasSymbolsOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasParameterOfTheDynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of GUIDS of properties which are parameters of the function for a dynamic property</para>
    ///   <para>Liste von GUIDs von Merkmalen, welche Parameter der Funktion fuer ein dynamisches Merkmal sind</para>
    /// labels<para>Parameters of the dynamic property</para><para>Parameter des dynamischen Merkmals</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasParameterOfTheDynamicProperty">https://w3id.org/isoprops#hasParameterOfTheDynamicProperty</seealso>
    let hasParameterOfTheDynamicProperty =
        Prefixed_Name(isoprops, "hasParameterOfTheDynamicProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:hasDefiningValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030</para>
    ///   <para>Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben</para>
    /// labels<para>Definierende Werte</para><para>Defining values</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDefiningValue">https://w3id.org/isoprops#hasDefiningValue</seealso>
    let hasDefiningValue = Prefixed_Name(isoprops, "hasDefiningValue") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:isReplacedByProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>global eindeutiger Bezeichner (Attribut PA001) des ersetzenden Merkmals (oder der Merkmale)</para>
    ///   <para>Globally unique identifier (attribute PA001) of the replacing property (or properties)</para>
    /// labels<para>List of replacing properties</para><para>Liste ersetzender Merkmale</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#isReplacedByProperty">https://w3id.org/isoprops#isReplacedByProperty</seealso>
    let isReplacedByProperty =
        Prefixed_Name(isoprops, "isReplacedByProperty") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Symbol</para><para>Symbol</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Symbol">https://w3id.org/isoprops#Symbol</seealso>
    let Symbol = Prefixed_Name(isoprops, "Symbol") |> PrefixedName

    /// <summary>
    ///   <para>isoprops:GloballyUniqueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Eindeutiger Bezeichner, der mit dem in RFC 4122 beschriebenen Algorithmus erzeugt wird</para>
    ///   <para>Unique identifier generated using the algorithm denoted in RFC 4122</para>
    /// labels<para>Global eindeutiger Bezeichner (GUID)</para><para>Globally Unique Identifier (GUID)</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#GloballyUniqueIdentifier">https://w3id.org/isoprops#GloballyUniqueIdentifier</seealso>
    let GloballyUniqueIdentifier =
        Prefixed_Name(isoprops, "GloballyUniqueIdentifier") |> PrefixedName

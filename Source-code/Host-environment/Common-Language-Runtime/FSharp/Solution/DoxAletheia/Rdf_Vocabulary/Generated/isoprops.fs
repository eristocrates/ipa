namespace https.w3id.org.isoprops.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module isoprops =
    let _namespace_iri = Namespace_Iri isoprops |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:isoprops#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/isoprops#">https://w3id.org/isoprops#</seealso>
    let _prefix_iri = Prefixed_Name(isoprops, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#AssignedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Repraesentiert die Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)"</para>
    ///   <para>"Represents the assignment of a property and a property state to a feature of interest (FOI)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Assigned property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Zugewiesenes Merkmal"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#AssignedProperty">https://w3id.org/isoprops#AssignedProperty</seealso>
    let AssignedProperty = Prefixed_Name(isoprops, "AssignedProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#BoundaryLimitMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Grenzwertintervall bestehend aus der oberen(maxValue) Intervallgrenze"</para>
    ///   <para>"Boundary limit  interval consisting of the the upper (maxValue) interval boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oberer Grenzwert"</para><para>"Maximum Boundary Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryLimitMax">https://w3id.org/isoprops#BoundaryLimitMax</seealso>
    let BoundaryLimitMax = Prefixed_Name(isoprops, "BoundaryLimitMax") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#BoundaryLimitMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Boundary limit interval consisting of the lower(minValue) interval boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Grenzwertintervall bestehend aus der unteren(minValue) Intervallgrenze"</para>
    /// labels<para>"Unterer Grenzwert"</para><para>"Minimum Boundary Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryLimitMin">https://w3id.org/isoprops#BoundaryLimitMin</seealso>
    let BoundaryLimitMin = Prefixed_Name(isoprops, "BoundaryLimitMin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#BoundaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair  (List of boundary intervals of possible values for the property, unit)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)"</para>
    /// labels<para>"Boundary values list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwertliste"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#BoundaryValue">https://w3id.org/isoprops#BoundaryValue</seealso>
    let BoundaryValue = Prefixed_Name(isoprops, "BoundaryValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#CategoryOfGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Specifies the category of the created property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Gibt die Kategorie der erstellten Merkmalsgruppe an"</para>
    /// labels<para>"Kategorie der Merkmalsgruppe"</para><para>"Category of group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CategoryOfGroupOfProperties">https://w3id.org/isoprops#CategoryOfGroupOfProperties</seealso>
    let CategoryOfGroupOfProperties =
        Prefixed_Name(isoprops, "CategoryOfGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#CountryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Land, aus dem die Anforderung an dieses Merkmal/dieser Merkmalsgruppe stammt"</para>
    ///   <para>"Country from where the requirement for this property/group of properties originated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Ursprungsland"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CountryOfOrigin">https://w3id.org/isoprops#CountryOfOrigin</seealso>
    let CountryOfOrigin = Prefixed_Name(isoprops, "CountryOfOrigin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#CountryOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Land (Gruppe von Laendern, Kon-tinent), in dem das Merkmal/die Merkmalsgruppe fuer den Markt, auf dem die Beteiligten arbeiten, relevant ist"</para>
    /// labels<para>"Land der Verwendung"</para><para>"Country of use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CountryOfUse">https://w3id.org/isoprops#CountryOfUse</seealso>
    let CountryOfUse = Prefixed_Name(isoprops, "CountryOfUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#CreatorsLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Satz, der den Grund fuer die Ab-lehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal entsprechen; diese Er-laeuterung muss in internatio-nalem Englisch (EN) geschrieben werden"</para>
    /// labels<para>"Erlaeuterung fuer die Ablehnung"</para><para>"Creator's language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#CreatorsLanguage">https://w3id.org/isoprops#CreatorsLanguage</seealso>
    let CreatorsLanguage = Prefixed_Name(isoprops, "CreatorsLanguage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Format fuer die Angabe des Wertes des Merkmals
    /// dies kann aus einer Soft-ware-Perspektive als Speiche-rungsart verstanden werden
    /// im Falle eines dynamischen Merkmals ist der Wert dieses Attributs der Datentyp des Er-gebnisses der Berechnung mit der Gleichung"</para>
    ///   <para>"Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datentyp (GUID)"</para><para>"Data type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DataType">https://w3id.org/isoprops#DataType</seealso>
    let DataType = Prefixed_Name(isoprops, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DateOfActivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date after when the property can be used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum, nach dem das Merkmal verwendet werden kann"</para>
    /// labels<para>"Datum der Aktivierung"</para><para>"Date of activation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfActivation">https://w3id.org/isoprops#DateOfActivation</seealso>
    let DateOfActivation = Prefixed_Name(isoprops, "DateOfActivation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DateOfCreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Datum der Validierung der An-frage zur Erstellung des Merkmals durch Sachverstaendige"</para>
    ///   <para>"Date of validation of the property creation request by experts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date of creation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Erstellung"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfCreation">https://w3id.org/isoprops#DateOfCreation</seealso>
    let DateOfCreation = Prefixed_Name(isoprops, "DateOfCreation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DateOfDeactivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of deactivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Deaktivierung"</para>
    /// labels<para>"Date of deactivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Deaktivierung"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfDeactivation">https://w3id.org/isoprops#DateOfDeactivation</seealso>
    let DateOfDeactivation =
        Prefixed_Name(isoprops, "DateOfDeactivation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DateOfLastChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of validation of the last change request by experts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Validierung der letzten Aenderungsanfrage durch Sachverstaendige"</para>
    /// labels<para>"Date of last change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der letzten Aenderung"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfLastChange">https://w3id.org/isoprops#DateOfLastChange</seealso>
    let DateOfLastChange = Prefixed_Name(isoprops, "DateOfLastChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DateOfRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Datum der Ueberarbeitung"</para>
    ///   <para>"Date of revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date of revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Ueberarbeitung"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfRevision">https://w3id.org/isoprops#DateOfRevision</seealso>
    let DateOfRevision = Prefixed_Name(isoprops, "DateOfRevision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DateOfVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Datum der Version"</para>
    ///   <para>"Date of version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date of version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Version"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DateOfVersion">https://w3id.org/isoprops#DateOfVersion</seealso>
    let DateOfVersion = Prefixed_Name(isoprops, "DateOfVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DefiningValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Enthaelt einen definierenden Wert eines Arrays in Form eines Literals"</para>
    ///   <para>"Contains a defining value of an array in the form of a literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Definierender Wert-Item"</para><para>"Defining value item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefiningValueItem">https://w3id.org/isoprops#DefiningValueItem</seealso>
    let DefiningValueItem = Prefixed_Name(isoprops, "DefiningValueItem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DefiningValuesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben"</para>
    /// labels<para>"Liste definierender Werte"</para><para>"Defining values list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefiningValuesList">https://w3id.org/isoprops#DefiningValuesList</seealso>
    let DefiningValuesList =
        Prefixed_Name(isoprops, "DefiningValuesList") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DefinitionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Liste von Paaren (Definition des Merkmals/der Merkmalsgruppe, Sprache)"</para>
    ///   <para>"List of pairs (definition of the property/group of properties, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Definition in Sprache N"</para><para>"Definition of in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DefinitionInLanguage">https://w3id.org/isoprops#DefinitionInLanguage</seealso>
    let DefinitionInLanguage =
        Prefixed_Name(isoprops, "DefinitionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DeprecationExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Satz, der den Grund fuer die Ablehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal/der neuen Merkmalsgruppe entsprechen; diese Erlaeuterung muss in internationalem Englisch (EN) geschrieben werden"</para>
    /// labels<para>"Erlaeuterung fuer die Ablehnung"</para><para>"Deprecation explanation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DeprecationExplanation">https://w3id.org/isoprops#DeprecationExplanation</seealso>
    let DeprecationExplanation =
        Prefixed_Name(isoprops, "DeprecationExplanation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DescriptionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Liste von Paaren (Beschreibung des Merkmals, Sprache)"</para>
    ///   <para>"List of pairs (Description of the property, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beschreibung in Sprache N"</para><para>"Description in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DescriptionInLanguage">https://w3id.org/isoprops#DescriptionInLanguage</seealso>
    let DescriptionInLanguage =
        Prefixed_Name(isoprops, "DescriptionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Zentralisiertes Repository von Informationen ueber Daten, wie z. B. Bedeutung, Beziehungen zu anderen Daten, Ursprung, Verwendung und Format"</para>
    /// labels<para>"Data dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datenkatalog"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Dictionary">https://w3id.org/isoprops#Dictionary</seealso>
    let Dictionary = Prefixed_Name(isoprops, "Dictionary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Publikation, die hinzugezogen wird, um bestimmte Informationen zu finden, insbesondere in einer technischen oder wissenschaftlichen Domaene"</para>
    ///   <para>"Publication that is consulted to find specific information, particularly in a technical or scientific domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Referenzdokument"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DictionaryReferenceDocument">https://w3id.org/isoprops#DictionaryReferenceDocument</seealso>
    let DictionaryReferenceDocument =
        Prefixed_Name(isoprops, "DictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#DictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines a subset or subgrouping of a data catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Definiert eine Teilmenge oder Untergruppierung eines Datenkatalogs"</para>
    /// labels<para>"Teilmenge des Datenkatalogs"</para><para>"Dictionary subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DictionarySubset">https://w3id.org/isoprops#DictionarySubset</seealso>
    let DictionarySubset = Prefixed_Name(isoprops, "DictionarySubset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DigitalFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen"</para>
    ///   <para>"Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Digitales Format-Item"</para><para>"Digital format item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DigitalFormatItem">https://w3id.org/isoprops#DigitalFormatItem</seealso>
    let DigitalFormatItem = Prefixed_Name(isoprops, "DigitalFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#DynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Wenn es sich um ein dynamisches Merkmal handelt, haengt der Wert von den im Attribut PA032 bereitgestellten Parametern ab"</para>
    /// labels<para>"Dynamic Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Dynamisches Merkmal"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#DynamicProperty">https://w3id.org/isoprops#DynamicProperty</seealso>
    let DynamicProperty = Prefixed_Name(isoprops, "DynamicProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    ///   <para>"The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Encoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Kodierung"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Encoding">https://w3id.org/isoprops#Encoding</seealso>
    let Encoding = Prefixed_Name(isoprops, "Encoding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#ExampleInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Liste von Paaren (Beispiel des Merkmals, Sprache)"</para>
    ///   <para>"List of pairs (example of the property, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beispiel in Sprache N"</para><para>"Example in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#ExampleInLanguage">https://w3id.org/isoprops#ExampleInLanguage</seealso>
    let ExampleInLanguage = Prefixed_Name(isoprops, "ExampleInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#ExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (interner Merkmalsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// Dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden"</para>
    /// labels<para>"External Dictionary Reference"</para><para>"External Dictionary Reference "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#ExternalDictionaryReference">https://w3id.org/isoprops#ExternalDictionaryReference</seealso>
    let ExternalDictionaryReference =
        Prefixed_Name(isoprops, "ExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#GloballyUniqueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identifier generated using the algorithm denoted in RFC 4122"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Eindeutiger Bezeichner, der mit dem in RFC 4122 beschriebenen Algorithmus erzeugt wird"</para>
    /// labels<para>"Global eindeutiger Bezeichner (GUID)"</para><para>"Globally Unique Identifier (GUID)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#GloballyUniqueIdentifier">https://w3id.org/isoprops#GloballyUniqueIdentifier</seealso>
    let GloballyUniqueIdentifier =
        Prefixed_Name(isoprops, "GloballyUniqueIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#GroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Sammlung, die es ermoeglicht, die Merkmale vorauszuplanen oder zu organisieren"</para>
    ///   <para>"Collection enabling the properties to be prearranged or organized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Merkmalsgruppe"</para><para>"Group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#GroupOfProperties">https://w3id.org/isoprops#GroupOfProperties</seealso>
    let GroupOfProperties = Prefixed_Name(isoprops, "GroupOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Inclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"inclusive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Inclusive">https://w3id.org/isoprops#Inclusive</seealso>
    let Inclusive = Prefixed_Name(isoprops, "Inclusive") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#MethodOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Messverfahren"</para><para>"Method of measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#MethodOfMeasurement">https://w3id.org/isoprops#MethodOfMeasurement</seealso>
    let MethodOfMeasurement =
        Prefixed_Name(isoprops, "MethodOfMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#NameInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (Name des Merkmals und Sprache)
    /// Dieses Attribut kann verwendet werden, um Synonyme fuer verschiedene Domaenen hinzuzufuegen"</para>
    /// labels<para>"Name in Sprache N"</para><para>"Name in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NameInLanguage">https://w3id.org/isoprops#NameInLanguage</seealso>
    let NameInLanguage = Prefixed_Name(isoprops, "NameInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#NameOfTheDefiningValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die Namen der Spaltenkoepfe, festgelegt als Liste von Paaren (Name, Sprache)"</para>
    /// labels<para>"Names of the defining values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Name der definierenden Werte"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NameOfTheDefiningValues">https://w3id.org/isoprops#NameOfTheDefiningValues</seealso>
    let NameOfTheDefiningValues =
        Prefixed_Name(isoprops, "NameOfTheDefiningValues") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#NumberOfCharacters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    ///   <para>"The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anzahl der Zeichen"</para><para>"Number of Characters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#NumberOfCharacters">https://w3id.org/isoprops#NumberOfCharacters</seealso>
    let NumberOfCharacters =
        Prefixed_Name(isoprops, "NumberOfCharacters") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#PhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen."</para>
    ///   <para>"List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Physikalische Groesse"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#PhysicalQuantity">https://w3id.org/isoprops#PhysicalQuantity</seealso>
    let PhysicalQuantity = Prefixed_Name(isoprops, "PhysicalQuantity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#PossibleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Possible value for the property and language
    /// Values can be string or numbers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Moeglicher Wert fuer das Merkmal und Sprache
    /// Werte koennen String oder Zahlen sein"</para>
    /// labels<para>"Liste moeglicher Werte in Sprache N"</para><para>"Possible value in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#PossibleValues">https://w3id.org/isoprops#PossibleValues</seealso>
    let PossibleValues = Prefixed_Name(isoprops, "PossibleValues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Praezision ist die Anzahl signifi-kanter Stellen"</para>
    ///   <para>"Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Toleranz"</para><para>"Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Precision">https://w3id.org/isoprops#Precision</seealso>
    let Precision = Prefixed_Name(isoprops, "Precision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inherent or acquired feature of an item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Inhaerente oder erworbene Eigenschaft eines Datenelements"</para>
    /// labels<para>"Merkmal"</para><para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Property">https://w3id.org/isoprops#Property</seealso>
    let Property = Prefixed_Name(isoprops, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#ReferenceDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/isoprops#ReferenceDocument">https://w3id.org/isoprops#ReferenceDocument</seealso>
    let ReferenceDocument = Prefixed_Name(isoprops, "ReferenceDocument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#RevisionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Diese Nummer der ueberarbeitung ermoeglicht die Verfolgung kleinerer aenderungen, z. B. neue uebersetzung, Korrekturen von Tippfehlern: wenn sich die Versionsnummer aendert, beginnt die Nummer der ueberarbeitung wieder bei 1.
    /// Sachverstaendige entscheiden, ob eine neue Nummer der ueberarbeitung angewendet werden kann oder ob eine neue ueberarbeitung erforderlich ist."</para>
    ///   <para>"This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nummer der ueberarbeitung"</para><para>"Revision number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#RevisionNumber">https://w3id.org/isoprops#RevisionNumber</seealso>
    let RevisionNumber = Prefixed_Name(isoprops, "RevisionNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Status des Merkmals waehrend seines Lebenszyklus"</para>
    ///   <para>"Status of the property during its life cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Status"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Status">https://w3id.org/isoprops#Status</seealso>
    let Status = Prefixed_Name(isoprops, "Status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#SubdivisionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Documented geographical region of use of the group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Dokumentierte geographische Region, in der das Merkmal/ die Merkmalsgruppe verwendet wird"</para>
    /// labels<para>"Unterteilung der Verwendung"</para><para>"Subdivision of use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#SubdivisionOfUse">https://w3id.org/isoprops#SubdivisionOfUse</seealso>
    let SubdivisionOfUse = Prefixed_Name(isoprops, "SubdivisionOfUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Symbol"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Symbol">https://w3id.org/isoprops#Symbol</seealso>
    let Symbol = Prefixed_Name(isoprops, "Symbol") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#SymbolOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))"</para>
    /// labels<para>"Symbol des Merkmals in einer gegebenen Merkmalsgruppe"</para><para>"Symbol of the property in a given property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#SymbolOfTheProperty">https://w3id.org/isoprops#SymbolOfTheProperty</seealso>
    let SymbolOfTheProperty =
        Prefixed_Name(isoprops, "SymbolOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#TextFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    /// labels<para>"Textformat-Item"</para><para>"Text format item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#TextFormatItem">https://w3id.org/isoprops#TextFormatItem</seealso>
    let TextFormatItem = Prefixed_Name(isoprops, "TextFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#Tolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Fuer numerische Werte; der Gesamtbetrag, um den eine be-stimmte Einheit schwanken darf; sie ist die Differenz zwischen dem Hoechstwert und dem Mindestwert fuer die Einheit"</para>
    ///   <para>"For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Toleranz"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#Tolerance">https://w3id.org/isoprops#Tolerance</seealso>
    let Tolerance = Prefixed_Name(isoprops, "Tolerance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#VersionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This version number allows tracking of major changes. Experts decide if a new version number must be applied"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Diese Versionsnummer ermoeglicht die Verfolgung groesserer aenderungen. Sachverstaendige entscheiden, ob eine neue Ver-sionsnummer angewendet werden muss."</para>
    /// labels<para>"Versionsnummer"</para><para>"Version number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#VersionNumber">https://w3id.org/isoprops#VersionNumber</seealso>
    let VersionNumber = Prefixed_Name(isoprops, "VersionNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#VisualRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Bildliche Darstellung des Merkmals durch Skizzen, Fotos, Videos oder sonstige Multimedia-Objekte"</para>
    ///   <para>"Visual representation of the group of properties through sketches, photos, videos or other multimedia objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bildliche Darstellung"</para><para>"Visual representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#VisualRepresentation">https://w3id.org/isoprops#VisualRepresentation</seealso>
    let VisualRepresentation =
        Prefixed_Name(isoprops, "VisualRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Code, der zur Identifizierung des Attributs verwendet werden kann"</para>
    ///   <para>"Code that can be used to identify the attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Code"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#code">https://w3id.org/isoprops#code</seealso>
    let code = Prefixed_Name(isoprops, "code") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#hasBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair (list of boundary intervals of possible values for the property, unit)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)"</para>
    /// labels<para>"Boundary values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwerte"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasBoundary">https://w3id.org/isoprops#hasBoundary</seealso>
    let hasBoundary = Prefixed_Name(isoprops, "hasBoundary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#hasBoundaryLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Einzelnes Grenzwertintervall"</para>
    ///   <para>"Single Boundary value interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boundary value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwert"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasBoundaryLimit">https://w3id.org/isoprops#hasBoundaryLimit</seealso>
    let hasBoundaryLimit = Prefixed_Name(isoprops, "hasBoundaryLimit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasConnectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste der global eindeutigen Bezeichner der verbundenen Merkmale (Attribut PA001); der Wert eines Merkmals steht zu den Werten der anderen in einer Beziehung. Beispielsweise ist ein Schallabsorptionsgrad fuer eine bestimmte Frequenz gegeben, in diesem Fall sind Schallabsorp-tionsgrad und Frequenz ver-bundene Merkmale."</para>
    /// labels<para>"Verbundene Merkmale"</para><para>"Connected properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasConnectedProperty">https://w3id.org/isoprops#hasConnectedProperty</seealso>
    let hasConnectedProperty =
        Prefixed_Name(isoprops, "hasConnectedProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasDefiningValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben"</para>
    ///   <para>"In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Definierende Werte"</para><para>"Defining values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDefiningValue">https://w3id.org/isoprops#hasDefiningValue</seealso>
    let hasDefiningValue = Prefixed_Name(isoprops, "hasDefiningValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasDefiningValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contains a defining value of an array"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Enthaelt einen definierenden Wert eines Arrays"</para>
    /// labels<para>"Definierender Wert"</para><para>"Defining value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDefiningValueItem">https://w3id.org/isoprops#hasDefiningValueItem</seealso>
    let hasDefiningValueItem =
        Prefixed_Name(isoprops, "hasDefiningValueItem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasDictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relation to a reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat den Verweis auf ein Referenzdokument"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDictionaryReferenceDocument">https://w3id.org/isoprops#hasDictionaryReferenceDocument</seealso>
    let hasDictionaryReferenceDocument =
        Prefixed_Name(isoprops, "hasDictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasDictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dictionary subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Teilmenge eines Katalogs"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDictionarySubset">https://w3id.org/isoprops#hasDictionarySubset</seealso>
    let hasDictionarySubset =
        Prefixed_Name(isoprops, "hasDictionarySubset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasDigitalFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen"</para>
    /// labels<para>"Digital format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Digitales Format"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasDigitalFormat">https://w3id.org/isoprops#hasDigitalFormat</seealso>
    let hasDigitalFormat = Prefixed_Name(isoprops, "hasDigitalFormat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasExternalDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has external dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionary">https://w3id.org/isoprops#hasExternalDictionary</seealso>
    let hasExternalDictionary =
        Prefixed_Name(isoprops, "hasExternalDictionary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasExternalDictionaryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has external dictionary property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionaryProperty">https://w3id.org/isoprops#hasExternalDictionaryProperty</seealso>
    let hasExternalDictionaryProperty =
        Prefixed_Name(isoprops, "hasExternalDictionaryProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von Paaren (interner Merk-malsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden"</para>
    ///   <para>"List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has External Dictionary Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat externe Dictionary Referenz"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasExternalDictionaryReference">https://w3id.org/isoprops#hasExternalDictionaryReference</seealso>
    let hasExternalDictionaryReference =
        Prefixed_Name(isoprops, "hasExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasGivenGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Global eindeutiger Bezeichner einer Merkmalsgruppe (Attribut GA001) fuer das dem Merkmal zugeordnetem Symbol"</para>
    ///   <para>"Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gegebene Merkmalsgruppe"</para><para>"Given group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasGivenGroupOfProperties">https://w3id.org/isoprops#hasGivenGroupOfProperties</seealso>
    let hasGivenGroupOfProperties =
        Prefixed_Name(isoprops, "hasGivenGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von global eindeutigen Bezeichnern von Merkmalsgruppen (Attribut GA001), denen das Merkmal angehoert"</para>
    ///   <para>"List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group(s) of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Merkmalsgruppe(n)"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasGroupOfProperties">https://w3id.org/isoprops#hasGroupOfProperties</seealso>
    let hasGroupOfProperties =
        Prefixed_Name(isoprops, "hasGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasParameterOfTheDynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of GUIDS of properties which are parameters of the function for a dynamic property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von GUIDs von Merkmalen, welche Parameter der Funktion fuer ein dynamisches Merkmal sind"</para>
    /// labels<para>"Parameters of the dynamic property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Parameter des dynamischen Merkmals"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasParameterOfTheDynamicProperty">https://w3id.org/isoprops#hasParameterOfTheDynamicProperty</seealso>
    let hasParameterOfTheDynamicProperty =
        Prefixed_Name(isoprops, "hasParameterOfTheDynamicProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasParentGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Ermoeglicht die Ver-knuepfung einer Unter-gruppe mit einer ueber-geordneten Gruppe ueber ihre global ein-deutigen Bezeichner (Attribut GA001)
    /// jedes einer Gruppe zugehoerige Merkmal wird von der/den Untergruppe(n) uebernommen"</para>
    /// labels<para>"uebergeordnete Merkmalsgruppe"</para><para>"Parent group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasParentGroupOfProperties">https://w3id.org/isoprops#hasParentGroupOfProperties</seealso>
    let hasParentGroupOfProperties =
        Prefixed_Name(isoprops, "hasParentGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasPhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von Paaren (physikalische Groesse | Sprache)
    /// Physikalische Groessen werden in Einheiten des Internationalen Einheitensystems (SI) angegeben
    /// nicht physikalische Groessen wie z. B. Text werden mit dem Wert "ohne" angegeben --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// dies ist gleichbedeutend mit einem Mass in ISO 16739-1 und ISO 10303
    /// nur eine physikalische Groesse kann einem Merkmal zugeordnet werden. Dieses Attribut wird ver-wendet, um die Groesse in Klartext mit allen benoetigten ueberset-zungen bereitzustellen."</para>
    ///   <para>"List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without" --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physikalische Groesse"</para><para>"Physical quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPhysicalQuantity">https://w3id.org/isoprops#hasPhysicalQuantity</seealso>
    let hasPhysicalQuantity =
        Prefixed_Name(isoprops, "hasPhysicalQuantity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasPossibleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von Paaren (moeglicher Wert fuer das Merkmal und Sprache)
    /// Werte koennen String oder Zahlen sein"</para>
    ///   <para>"List of pairs (possible value for the property and language)
    /// Values can be string or numbers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"List of possible values in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste moeglicher Werte in Sprache N"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPossibleValues">https://w3id.org/isoprops#hasPossibleValues</seealso>
    let hasPossibleValues = Prefixed_Name(isoprops, "hasPossibleValues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Attaches a property to a feature of interest (FOI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Fuegt ein Merkmal zu einem Feature of Interest (FOI) hinzu"</para>
    /// labels<para>"hat Merkmal"</para><para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasProperty">https://w3id.org/isoprops#hasProperty</seealso>
    let hasProperty = Prefixed_Name(isoprops, "hasProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasPropertyGroupReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Attaches a property group reference to a isoprops:ReferenceDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Fuegt eine Merkmalsgruppe (oberstes in der Hierarchie) zu einer isoprops:ReferenceDocument hinzu"</para>
    /// labels<para>"has property group reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Merkmalsgruppenreferenz"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPropertyGroupReference">https://w3id.org/isoprops#hasPropertyGroupReference</seealso>
    let hasPropertyGroupReference =
        Prefixed_Name(isoprops, "hasPropertyGroupReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasPropertyReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fuegt ein Merkmal zu einer Merkmalszuweisung hinzu"</para>
    ///   <para>"Attaches a property reference to a property assignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hat Merkmalreferenz"</para><para>"has Property Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasPropertyReference">https://w3id.org/isoprops#hasPropertyReference</seealso>
    let hasPropertyReference =
        Prefixed_Name(isoprops, "hasPropertyReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (inter-ner Bezeichner der Merkmalsgruppe, ent-sprechender Daten-katalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merk-malsgruppen verwen-det werden"</para>
    /// labels<para>"Relations of the group of properties identifiers in the interconnected data dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Beziehung der Bezeichner der Merkmalsgruppe in den miteinander verbundenen Datenkatalogen"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(isoprops, "hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasSymbolsOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))"</para>
    /// labels<para>"Symbole des Merkmals in einer gegebenen Merk-malsgruppe"</para><para>"Symbols of the property in a given property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasSymbolsOfTheProperty">https://w3id.org/isoprops#hasSymbolsOfTheProperty</seealso>
    let hasSymbolsOfTheProperty =
        Prefixed_Name(isoprops, "hasSymbolsOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#hasTextFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    /// labels<para>"Textformat"</para><para>"Text format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasTextFormat">https://w3id.org/isoprops#hasTextFormat</seealso>
    let hasTextFormat = Prefixed_Name(isoprops, "hasTextFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isoprops#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless --&gt; http://qudt.org/vocab/unit/UNITLESS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Eine Einheit zur Darstellung einer Skala, die es ermoeglicht, einen Wert zu messen
    /// es ist moeglich, dieses Attribut zu verwenden, um zu erlaeutern, dass dem Merkmal keine Einheit zugeordnet ist, indem einheitslos verwendet wird --&gt; http://qudt.org/vocab/unit/UNITLESS"</para>
    /// labels<para>"has unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Einheit"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#hasUnit">https://w3id.org/isoprops#hasUnit</seealso>
    let hasUnit = Prefixed_Name(isoprops, "hasUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#isReplacedByGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von globalen Bezeichnern fuer die ersetzenden Merkmalsgruppen"</para>
    ///   <para>"List of globally unique identifiers of the replacing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"List of replacing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzender Merkmalsgruppen"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#isReplacedByGroupOfProperties">https://w3id.org/isoprops#isReplacedByGroupOfProperties</seealso>
    let isReplacedByGroupOfProperties =
        Prefixed_Name(isoprops, "isReplacedByGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#isReplacedByProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Globally unique identifier (attribute PA001) of the replacing property (or properties)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"global eindeutiger Bezeichner (Attribut PA001) des ersetzenden Merkmals (oder der Merkmale)"</para>
    /// labels<para>"List of replacing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzender Merkmale"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#isReplacedByProperty">https://w3id.org/isoprops#isReplacedByProperty</seealso>
    let isReplacedByProperty =
        Prefixed_Name(isoprops, "isReplacedByProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#replacesGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of globally unique identifiers of the replaced groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von globalen Bezeichnern fuer die ersetzten Merk-malsgruppen"</para>
    /// labels<para>"List of replaced groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzter Merkmalsgruppen"</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#replacesGroupOfProperties">https://w3id.org/isoprops#replacesGroupOfProperties</seealso>
    let replacesGroupOfProperties =
        Prefixed_Name(isoprops, "replacesGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops#replacesProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Global eindeutiger Bezeichner des ersetzten Merkmals (oder der Merkmale)"</para>
    ///   <para>"Globally unique identifier of the replaced property (or properties)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Liste ersetzter Merkmale"</para><para>"List of replaced properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops#replacesProperties">https://w3id.org/isoprops#replacesProperties</seealso>
    let replacesProperties =
        Prefixed_Name(isoprops, "replacesProperties") |> PrefixedName

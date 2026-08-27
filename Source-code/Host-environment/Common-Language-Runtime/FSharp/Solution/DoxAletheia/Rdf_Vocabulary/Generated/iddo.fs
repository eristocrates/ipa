namespace https.w3id.org.iddo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iddo =
    let _namespace_iri = Namespace_Iri iddo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:iddo#AssignedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the assignment of a property and a property state to a feature of interest (FOI)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Repraesentiert die Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)"</para>
    /// labels<para>"Zugewiesenes Merkmal"</para><para>"Assigned property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#AssignedProperty">https://w3id.org/iddo#AssignedProperty</seealso>
    let AssignedProperty = Prefixed_Name(iddo, "AssignedProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#AssignedPropertyShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Represents the validation using SHACL of the assignment of a property and a property state to a feature of interest (FOI)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Repraesentiert die Validierung mit Hilfe von SHACL der Zweisung eines Merkmals und einer Merkmalszustandes an ein Feature of Interest (FOI)"</para>
    /// labels<para>"Assigned property SHACL shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Zugewiesenes Merkmal SHACL Shape"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#AssignedPropertyShape">https://w3id.org/iddo#AssignedPropertyShape</seealso>
    let AssignedPropertyShape =
        Prefixed_Name(iddo, "AssignedPropertyShape") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#BoundaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Single Boundary value interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Einzelnes Grenzwertintervall"</para>
    /// labels<para>"Boundary value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwert"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#BoundaryValue">https://w3id.org/iddo#BoundaryValue</seealso>
    let BoundaryValue = Prefixed_Name(iddo, "BoundaryValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#BoundaryValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Grenzwertintervall bestehend aus der unteren(minValue) und der oberen(maxValue) Intervallgrenze"</para>
    ///   <para>"Boundary value interval consisting of the lower(minValue) and the upper(maxValue) interval boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boundary value item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwerte"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#BoundaryValueItem">https://w3id.org/iddo#BoundaryValueItem</seealso>
    let BoundaryValueItem = Prefixed_Name(iddo, "BoundaryValueItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#BoundaryValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair (list of boundary intervals of possible values for the property, unit)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)"</para>
    /// labels<para>"Boundary values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwerte"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#BoundaryValues">https://w3id.org/iddo#BoundaryValues</seealso>
    let BoundaryValues = Prefixed_Name(iddo, "BoundaryValues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#BoundaryValuesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Paar (Liste von Grenzwert-Intervallen moeglicher Werte fuer das Merkmal, Einheit)"</para>
    ///   <para>"Pair  (List of boundary intervals of possible values for the property, unit)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boundary values list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grenzwertliste"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#BoundaryValuesList">https://w3id.org/iddo#BoundaryValuesList</seealso>
    let BoundaryValuesList = Prefixed_Name(iddo, "BoundaryValuesList") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#CategoryOfGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the category of the created property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Gibt die Kategorie der erstellten Merkmalsgruppe an"</para>
    /// labels<para>"Category of group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Kategorie der Merkmalsgruppe"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#CategoryOfGroupOfProperties">https://w3id.org/iddo#CategoryOfGroupOfProperties</seealso>
    let CategoryOfGroupOfProperties =
        Prefixed_Name(iddo, "CategoryOfGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ConnectedProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste der global eindeutigen Bezeichner der verbundenen Merkmale (Attribut PA001); der Wert eines Merkmals steht zu den Werten der anderen in einer Beziehung. Beispielsweise ist ein Schallabsorptionsgrad fuer eine bestimmte Frequenz gegeben, in diesem Fall sind Schallabsorp-tionsgrad und Frequenz ver-bundene Merkmale."</para>
    ///   <para>"List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Connected properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Verbundene Merkmale"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ConnectedProperties">https://w3id.org/iddo#ConnectedProperties</seealso>
    let ConnectedProperties = Prefixed_Name(iddo, "ConnectedProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#CountryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Country from where the requirement for this property/group of properties originated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Land, aus dem die Anforderung an dieses Merkmal/dieser Merkmalsgruppe stammt"</para>
    /// labels<para>"Ursprungsland"</para><para>"Country of origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#CountryOfOrigin">https://w3id.org/iddo#CountryOfOrigin</seealso>
    let CountryOfOrigin = Prefixed_Name(iddo, "CountryOfOrigin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#CountryOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Land (Gruppe von Laendern, Kon-tinent), in dem das Merkmal/die Merkmalsgruppe fuer den Markt, auf dem die Beteiligten arbeiten, relevant ist"</para>
    ///   <para>"Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Land der Verwendung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#CountryOfUse">https://w3id.org/iddo#CountryOfUse</seealso>
    let CountryOfUse = Prefixed_Name(iddo, "CountryOfUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#CreatorsLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Satz, der den Grund fuer die Ab-lehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal entsprechen; diese Er-laeuterung muss in internatio-nalem Englisch (EN) geschrieben werden"</para>
    ///   <para>"Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Creator's language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Erlaeuterung fuer die Ablehnung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#CreatorsLanguage">https://w3id.org/iddo#CreatorsLanguage</seealso>
    let CreatorsLanguage = Prefixed_Name(iddo, "CreatorsLanguage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Format fuer die Angabe des Wertes des Merkmals
    /// dies kann aus einer Soft-ware-Perspektive als Speiche-rungsart verstanden werden
    /// im Falle eines dynamischen Merkmals ist der Wert dieses Attributs der Datentyp des Er-gebnisses der Berechnung mit der Gleichung"</para>
    /// labels<para>"Data type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datentyp (GUID)"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DataType">https://w3id.org/iddo#DataType</seealso>
    let DataType = Prefixed_Name(iddo, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfActivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date after when the property can be used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum, nach dem das Merkmal verwendet werden kann"</para>
    /// labels<para>"Datum der Aktivierung"</para><para>"Date of activation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfActivation">https://w3id.org/iddo#DateOfActivation</seealso>
    let DateOfActivation = Prefixed_Name(iddo, "DateOfActivation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfCreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of validation of the property creation request by experts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Validierung der An-frage zur Erstellung des Merkmals durch Sachverstaendige"</para>
    /// labels<para>"Date of creation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Erstellung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfCreation">https://w3id.org/iddo#DateOfCreation</seealso>
    let DateOfCreation = Prefixed_Name(iddo, "DateOfCreation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfDeactivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of deactivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Deaktivierung"</para>
    /// labels<para>"Datum der Deaktivierung"</para><para>"Date of deactivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfDeactivation">https://w3id.org/iddo#DateOfDeactivation</seealso>
    let DateOfDeactivation = Prefixed_Name(iddo, "DateOfDeactivation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfLastChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Datum der Validierung der letzten Aenderungsanfrage durch Sachverstaendige"</para>
    ///   <para>"Date of validation of the last change request by experts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datum der letzten Aenderung"</para><para>"Date of last change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfLastChange">https://w3id.org/iddo#DateOfLastChange</seealso>
    let DateOfLastChange = Prefixed_Name(iddo, "DateOfLastChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Ueberarbeitung"</para>
    /// labels<para>"Date of revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datum der Ueberarbeitung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfRevision">https://w3id.org/iddo#DateOfRevision</seealso>
    let DateOfRevision = Prefixed_Name(iddo, "DateOfRevision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DateOfVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Datum der Version"</para>
    /// labels<para>"Datum der Version"</para><para>"Date of version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DateOfVersion">https://w3id.org/iddo#DateOfVersion</seealso>
    let DateOfVersion = Prefixed_Name(iddo, "DateOfVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DefiningValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contains a defining value of an array"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Enthaelt einen definierenden Wert eines Arrays"</para>
    /// labels<para>"Defining value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Definierender Wert"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DefiningValue">https://w3id.org/iddo#DefiningValue</seealso>
    let DefiningValue = Prefixed_Name(iddo, "DefiningValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DefiningValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Enthaelt einen definierenden Wert eines Arrays in Form eines Literals"</para>
    ///   <para>"Contains a defining value of an array in the form of a literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Defining value item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Definierender Wert-Item"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DefiningValueItem">https://w3id.org/iddo#DefiningValueItem</seealso>
    let DefiningValueItem = Prefixed_Name(iddo, "DefiningValueItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DefiningValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben"</para>
    ///   <para>"In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Defining values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Definierende Werte"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DefiningValues">https://w3id.org/iddo#DefiningValues</seealso>
    let DefiningValues = Prefixed_Name(iddo, "DefiningValues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DefiningValuesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die definierenden Werte, sofern zutreffend, der Datentyp wird durch das Attribut PA030 angegeben"</para>
    /// labels<para>"Liste definierender Werte"</para><para>"Defining values list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DefiningValuesList">https://w3id.org/iddo#DefiningValuesList</seealso>
    let DefiningValuesList = Prefixed_Name(iddo, "DefiningValuesList") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#DefinitionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of pairs (definition of the property/group of properties, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (Definition des Merkmals/der Merkmalsgruppe, Sprache)"</para>
    /// labels<para>"Definition in Sprache N"</para><para>"Definition of in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DefinitionInLanguage">https://w3id.org/iddo#DefinitionInLanguage</seealso>
    let DefinitionInLanguage =
        Prefixed_Name(iddo, "DefinitionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#DeprecationExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Satz, der den Grund fuer die Ablehnung erlaeutert, der erklaeren kann, wie Werte umzurechnen sind, damit sie dem neuen Merkmal/der neuen Merkmalsgruppe entsprechen; diese Erlaeuterung muss in internationalem Englisch (EN) geschrieben werden"</para>
    ///   <para>"Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deprecation explanation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Erlaeuterung fuer die Ablehnung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DeprecationExplanation">https://w3id.org/iddo#DeprecationExplanation</seealso>
    let DeprecationExplanation =
        Prefixed_Name(iddo, "DeprecationExplanation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#DescriptionInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Liste von Paaren (Beschreibung des Merkmals, Sprache)"</para>
    ///   <para>"List of pairs (Description of the property, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beschreibung in Sprache N"</para><para>"Description in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DescriptionInLanguage">https://w3id.org/iddo#DescriptionInLanguage</seealso>
    let DescriptionInLanguage =
        Prefixed_Name(iddo, "DescriptionInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Zentralisiertes Repository von Informationen ueber Daten, wie z. B. Bedeutung, Beziehungen zu anderen Daten, Ursprung, Verwendung und Format"</para>
    /// labels<para>"Datenkatalog"</para><para>"Data dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Dictionary">https://w3id.org/iddo#Dictionary</seealso>
    let Dictionary = Prefixed_Name(iddo, "Dictionary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#DictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Publication that is consulted to find specific information, particularly in a technical or scientific domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Publikation, die hinzugezogen wird, um bestimmte Informationen zu finden, insbesondere in einer technischen oder wissenschaftlichen Domaene"</para>
    /// labels<para>"Reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Referenzdokument"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DictionaryReferenceDocument">https://w3id.org/iddo#DictionaryReferenceDocument</seealso>
    let DictionaryReferenceDocument =
        Prefixed_Name(iddo, "DictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#DictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines a subset or subgrouping of a data catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Definiert eine Teilmenge oder Untergruppierung eines Datenkatalogs"</para>
    /// labels<para>"Teilmenge des Datenkatalogs"</para><para>"Dictionary subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DictionarySubset">https://w3id.org/iddo#DictionarySubset</seealso>
    let DictionarySubset = Prefixed_Name(iddo, "DictionarySubset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DigitalFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen"</para>
    /// labels<para>"Digital format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Digitales Format"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DigitalFormat">https://w3id.org/iddo#DigitalFormat</seealso>
    let DigitalFormat = Prefixed_Name(iddo, "DigitalFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DigitalFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Paar fuer den digitalen Texttyp (Praezision, Masseinheit)
    /// Praezision ist die Anzahl signifikanter Stellen"</para>
    ///   <para>"Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Digitales Format-Item"</para><para>"Digital format item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DigitalFormatItem">https://w3id.org/iddo#DigitalFormatItem</seealso>
    let DigitalFormatItem = Prefixed_Name(iddo, "DigitalFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In case of a physical quantity, dimension according to ISO 80000 (all parts)
    /// This attribute allows the dimension to be machine readable; as all physical quantities are derived from 7 base quantities, it is provided with the power (as a rational number) attached to a basic dimension in the following order and with one space between each"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Im Falle einer physikalischen Groesse, Dimension nach ISO 80000 (alle Teile)
    /// dieses Attribut ermoeglicht, dass die Dimension maschinenlesbar ist; da alle physikalischen Groessen von 7 Basisgroessen abgeleitet sind, wird es durch Angabe der Basisdimensionen mit zugehoeriger Potenz (als rationale Zahl) in der folgenden Reihenfolge und mit jeweils einem Leerzeichen dazwischen angegeben"</para>
    /// labels<para>"Dimension"</para><para>"Dimension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Dimension">https://w3id.org/iddo#Dimension</seealso>
    let Dimension = Prefixed_Name(iddo, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#DynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Wenn es sich um ein dynamisches Merkmal handelt, haengt der Wert von den im Attribut PA032 bereitgestellten Parametern ab"</para>
    /// labels<para>"Dynamisches Merkmal"</para><para>"Dynamic Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#DynamicProperty">https://w3id.org/iddo#DynamicProperty</seealso>
    let DynamicProperty = Prefixed_Name(iddo, "DynamicProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    /// labels<para>"Encoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Kodierung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Encoding">https://w3id.org/iddo#Encoding</seealso>
    let Encoding = Prefixed_Name(iddo, "Encoding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#ExampleInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of pairs (example of the property, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (Beispiel des Merkmals, Sprache)"</para>
    /// labels<para>"Example in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Beispiel in Sprache N"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ExampleInLanguage">https://w3id.org/iddo#ExampleInLanguage</seealso>
    let ExampleInLanguage = Prefixed_Name(iddo, "ExampleInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#GivenGroupsOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Global eindeutiger Bezeichner einer Merkmalsgruppe (Attribut GA001) fuer das dem Merkmal zugeordnetem Symbol"</para>
    /// labels<para>"Gegebene Merkmalsgruppe"</para><para>"Given group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#GivenGroupsOfProperties">https://w3id.org/iddo#GivenGroupsOfProperties</seealso>
    let GivenGroupsOfProperties =
        Prefixed_Name(iddo, "GivenGroupsOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#GloballyUniqueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Eindeutiger Bezeichner, der mit dem in RFC 4122 beschriebenen Algorithmus erzeugt wird"</para>
    ///   <para>"Unique identifier generated using the algorithm denoted in RFC 4122"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Globally Unique Identifier (GUID)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Global eindeutiger Bezeichner (GUID)"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#GloballyUniqueIdentifier">https://w3id.org/iddo#GloballyUniqueIdentifier</seealso>
    let GloballyUniqueIdentifier =
        Prefixed_Name(iddo, "GloballyUniqueIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#GroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Sammlung, die es ermoeglicht, die Merkmale vorauszuplanen oder zu organisieren"</para>
    ///   <para>"Collection enabling the properties to be prearranged or organized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Merkmalsgruppe"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#GroupOfProperties">https://w3id.org/iddo#GroupOfProperties</seealso>
    let GroupOfProperties = Prefixed_Name(iddo, "GroupOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#GroupOfProperties_1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/iddo#GroupOfProperties_1">https://w3id.org/iddo#GroupOfProperties_1</seealso>
    let GroupOfProperties_1 = Prefixed_Name(iddo, "GroupOfProperties_1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#GroupsOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von global eindeutigen Bezeichnern von Merkmalsgruppen (Attribut GA001), denen das Merkmal angehoert"</para>
    /// labels<para>"Merkmalsgruppe(n)"</para><para>"Group(s) of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#GroupsOfProperties">https://w3id.org/iddo#GroupsOfProperties</seealso>
    let GroupsOfProperties = Prefixed_Name(iddo, "GroupsOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#InterConDictID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Entsprechender Daten-katalog-Bezeichner"</para>
    ///   <para>"Corresponding data dictionary identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interconnected Data Dictionary ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Miteinander verbundene Datenkatalog ID"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#InterConDictID">https://w3id.org/iddo#InterConDictID</seealso>
    let InterConDictID = Prefixed_Name(iddo, "InterConDictID") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ListOfPossibleValuesInLanguageN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of pairs (possible value for the property and language)
    /// Values can be string or numbers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (moeglicher Wert fuer das Merkmal und Sprache)
    /// Werte koennen String oder Zahlen sein"</para>
    /// labels<para>"Liste moeglicher Werte in Sprache N"</para><para>"List of possible values in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ListOfPossibleValuesInLanguageN">https://w3id.org/iddo#ListOfPossibleValuesInLanguageN</seealso>
    let ListOfPossibleValuesInLanguageN =
        Prefixed_Name(iddo, "ListOfPossibleValuesInLanguageN") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ListOfReplacedGroupsOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of globally unique identifiers of the replaced groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von globalen Bezeichnern fuer die ersetzten Merk-malsgruppen"</para>
    /// labels<para>"List of replaced groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzter Merkmalsgruppen"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ListOfReplacedGroupsOfProperties">https://w3id.org/iddo#ListOfReplacedGroupsOfProperties</seealso>
    let ListOfReplacedGroupsOfProperties =
        Prefixed_Name(iddo, "ListOfReplacedGroupsOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ListOfReplacedProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Globally unique identifier of the replaced property (or properties)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Global eindeutiger Bezeichner des ersetzten Merkmals (oder der Merkmale)"</para>
    /// labels<para>"List of replaced properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzter Merkmale"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ListOfReplacedProperties">https://w3id.org/iddo#ListOfReplacedProperties</seealso>
    let ListOfReplacedProperties =
        Prefixed_Name(iddo, "ListOfReplacedProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ListOfReplacingGroupsOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of globally unique identifiers of the replacing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von globalen Bezeichnern fuer die ersetzenden Merkmalsgruppen"</para>
    /// labels<para>"List of replacing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Liste ersetzender Merkmalsgruppen"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ListOfReplacingGroupsOfProperties">https://w3id.org/iddo#ListOfReplacingGroupsOfProperties</seealso>
    let ListOfReplacingGroupsOfProperties =
        Prefixed_Name(iddo, "ListOfReplacingGroupsOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ListOfReplacingProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"global eindeutiger Bezeichner (Attribut PA001) des ersetzenden Merkmals (oder der Merkmale)"</para>
    ///   <para>"Globally unique identifier (attribute PA001) of the replacing property (or properties)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Liste ersetzender Merkmale"</para><para>"List of replacing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ListOfReplacingProperties">https://w3id.org/iddo#ListOfReplacingProperties</seealso>
    let ListOfReplacingProperties =
        Prefixed_Name(iddo, "ListOfReplacingProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#MethodOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Messverfahren"</para><para>"Method of measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#MethodOfMeasurement">https://w3id.org/iddo#MethodOfMeasurement</seealso>
    let MethodOfMeasurement = Prefixed_Name(iddo, "MethodOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#NameInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Liste von Paaren (Name des Merkmals und Sprache)
    /// Dieses Attribut kann verwendet werden, um Synonyme fuer verschiedene Domaenen hinzuzufuegen"</para>
    ///   <para>"List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name in Sprache N"</para><para>"Name in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#NameInLanguage">https://w3id.org/iddo#NameInLanguage</seealso>
    let NameInLanguage = Prefixed_Name(iddo, "NameInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#NameOfTheDefiningValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Im Falle eines Feldes liefert dieses Attribut die Namen der Spaltenkoepfe, festgelegt als Liste von Paaren (Name, Sprache)"</para>
    /// labels<para>"Names of the defining values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Name der definierenden Werte"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#NameOfTheDefiningValues">https://w3id.org/iddo#NameOfTheDefiningValues</seealso>
    let NameOfTheDefiningValues =
        Prefixed_Name(iddo, "NameOfTheDefiningValues") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#NumberOfCharacters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    ///   <para>"The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number of Characters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Anzahl der Zeichen"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#NumberOfCharacters">https://w3id.org/iddo#NumberOfCharacters</seealso>
    let NumberOfCharacters = Prefixed_Name(iddo, "NumberOfCharacters") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ParametersOfTheDynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von GUIDs von Merkmalen, welche Parameter der Funktion fuer ein dynamisches Merkmal sind"</para>
    ///   <para>"List of GUIDS of properties which are parameters of the function for a dynamic property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameters of the dynamic property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Parameter des dynamischen Merkmals"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ParametersOfTheDynamicProperty">https://w3id.org/iddo#ParametersOfTheDynamicProperty</seealso>
    let ParametersOfTheDynamicProperty =
        Prefixed_Name(iddo, "ParametersOfTheDynamicProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#ParentGroupOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Ermoeglicht die Ver-knuepfung einer Unter-gruppe mit einer ueber-geordneten Gruppe ueber ihre global ein-deutigen Bezeichner (Attribut GA001)
    /// jedes einer Gruppe zugehoerige Merkmal wird von der/den Untergruppe(n) uebernommen"</para>
    ///   <para>"Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parent group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"uebergeordnete Merkmalsgruppe"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#ParentGroupOfProperties">https://w3id.org/iddo#ParentGroupOfProperties</seealso>
    let ParentGroupOfProperties =
        Prefixed_Name(iddo, "ParentGroupOfProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#PhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
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
    /// labels<para>"Physikalische Groesse"</para><para>"Physical quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#PhysicalQuantity">https://w3id.org/iddo#PhysicalQuantity</seealso>
    let PhysicalQuantity = Prefixed_Name(iddo, "PhysicalQuantity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#PossibleValueInLanguageN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Possible value for the property and language
    /// Values can be string or numbers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Moeglicher Wert fuer das Merkmal und Sprache
    /// Werte koennen String oder Zahlen sein"</para>
    /// labels<para>"Liste moeglicher Werte in Sprache N"</para><para>"Possible value in language N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#PossibleValueInLanguageN">https://w3id.org/iddo#PossibleValueInLanguageN</seealso>
    let PossibleValueInLanguageN =
        Prefixed_Name(iddo, "PossibleValueInLanguageN") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Precision is the number of significant digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Praezision ist die Anzahl signifi-kanter Stellen"</para>
    /// labels<para>"Toleranz"</para><para>"Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Precision">https://w3id.org/iddo#Precision</seealso>
    let Precision = Prefixed_Name(iddo, "Precision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inhaerente oder erworbene Eigenschaft eines Datenelements"</para>
    ///   <para>"Inherent or acquired feature of an item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Merkmal"</para><para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Property">https://w3id.org/iddo#Property</seealso>
    let Property = Prefixed_Name(iddo, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#ReferenceDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/iddo#ReferenceDocument">https://w3id.org/iddo#ReferenceDocument</seealso>
    let ReferenceDocument = Prefixed_Name(iddo, "ReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar (interner Merkmalsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// Dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden"</para>
    /// labels<para>"Beziehung des Merkmalsbezeichners in den miteinander verbundenen Datenkatalogen"</para><para>"Relation of propertiy identifier in the interconnected data dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(iddo, "RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Paar (interner Bezeichner der Merkmalsgruppe, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merkmalsgruppen verwendet werden"</para>
    ///   <para>"Pair (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beziehung des Bezeichners der Merkmalsgruppe in den miteinander verbundenen Datenkatalogen"</para><para>"Relation of the group of properties identifier in the interconnected data dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(iddo, "RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von Paaren (inter-ner Bezeichner der Merkmalsgruppe, ent-sprechender Daten-katalog-Bezeichner)
    /// dieses Attribut sollte fuer die Kompatibilitaet zwischen bereits vorhandenen Merk-malsgruppen verwen-det werden"</para>
    ///   <para>"List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relations of the group of properties identifiers in the interconnected data dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Beziehung der Bezeichner der Merkmalsgruppe in den miteinander verbundenen Datenkatalogen"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(iddo, "RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Liste von Paaren (interner Merk-malsbezeichner, entsprechender Datenkatalog-Bezeichner)
    /// dieses Attribut sollte fuer die Vertraeglichkeit zwischen bereits vorhandenen Merkmalen verwendet werden"</para>
    ///   <para>"List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beziehung der Merkmalsbezeichner in den miteinander verbundenen Datenka-talogen"</para><para>"Relations of the property identifiers in the interconnected data dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries">https://w3id.org/iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries</seealso>
    let RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries =
        Prefixed_Name(iddo, "RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#RevisionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Diese Nummer der ueberarbeitung ermoeglicht die Verfolgung kleinerer aenderungen, z. B. neue uebersetzung, Korrekturen von Tippfehlern: wenn sich die Versionsnummer aendert, beginnt die Nummer der ueberarbeitung wieder bei 1.
    /// Sachverstaendige entscheiden, ob eine neue Nummer der ueberarbeitung angewendet werden kann oder ob eine neue ueberarbeitung erforderlich ist."</para>
    /// labels<para>"Nummer der ueberarbeitung"</para><para>"Revision number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#RevisionNumber">https://w3id.org/iddo#RevisionNumber</seealso>
    let RevisionNumber = Prefixed_Name(iddo, "RevisionNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Status des Merkmals waehrend seines Lebenszyklus"</para>
    ///   <para>"Status of the property during its life cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Status"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Status">https://w3id.org/iddo#Status</seealso>
    let Status = Prefixed_Name(iddo, "Status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#SubdivisionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Documented geographical region of use of the group of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Dokumentierte geographische Region, in der das Merkmal/ die Merkmalsgruppe verwendet wird"</para>
    /// labels<para>"Subdivision of use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Unterteilung der Verwendung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#SubdivisionOfUse">https://w3id.org/iddo#SubdivisionOfUse</seealso>
    let SubdivisionOfUse = Prefixed_Name(iddo, "SubdivisionOfUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Symbol"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Symbol">https://w3id.org/iddo#Symbol</seealso>
    let Symbol = Prefixed_Name(iddo, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#SymbolOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Paar (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))"</para>
    ///   <para>"Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symbol of the property in a given property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Symbol des Merkmals in einer gegebenen Merkmalsgruppe"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#SymbolOfTheProperty">https://w3id.org/iddo#SymbolOfTheProperty</seealso>
    let SymbolOfTheProperty = Prefixed_Name(iddo, "SymbolOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#SymbolsOfTheProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Liste von Paaren (Symbol des Merkmals, global eindeutiger Bezeichner der Merkmalsgruppe (Attribut GA001))"</para>
    /// labels<para>"Symbole des Merkmals in einer gegebenen Merk-malsgruppe"</para><para>"Symbols of the property in a given property group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#SymbolsOfTheProperty">https://w3id.org/iddo#SymbolsOfTheProperty</seealso>
    let SymbolsOfTheProperty =
        Prefixed_Name(iddo, "SymbolsOfTheProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#TextFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den Texttyp (Ver-schluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    /// labels<para>"Textformat"</para><para>"Text format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#TextFormat">https://w3id.org/iddo#TextFormat</seealso>
    let TextFormat = Prefixed_Name(iddo, "TextFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#TextFormatItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Paar fuer den Texttyp (Verschluesselung, Anzahl der Zeichen)
    /// die Verschluesselung wird nach Name der Codierungsnorm von IANA, RFC 2978 festgelegt"</para>
    /// labels<para>"Text format item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Textformat-Item"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#TextFormatItem">https://w3id.org/iddo#TextFormatItem</seealso>
    let TextFormatItem = Prefixed_Name(iddo, "TextFormatItem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Tolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Fuer numerische Werte; der Gesamtbetrag, um den eine be-stimmte Einheit schwanken darf; sie ist die Differenz zwischen dem Hoechstwert und dem Mindestwert fuer die Einheit"</para>
    ///   <para>"For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Toleranz"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Tolerance">https://w3id.org/iddo#Tolerance</seealso>
    let Tolerance = Prefixed_Name(iddo, "Tolerance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Masseinheit fuer den digitalen Texttyp"</para>
    ///   <para>"Unit of measurement for the digital text type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Einheit"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Unit">https://w3id.org/iddo#Unit</seealso>
    let Unit = Prefixed_Name(iddo, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#Units</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Eine Einheit zur Darstellung einer Skala, die es ermoeglicht, einen Wert zu messen
    /// es ist moeglich, dieses Attribut zu verwenden, um zu erlaeutern, dass dem Merkmal keine Einheit zugeordnet ist, indem einheitslos verwendet wird"</para>
    /// labels<para>"Units"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Einheiten"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#Units">https://w3id.org/iddo#Units</seealso>
    let Units = Prefixed_Name(iddo, "Units") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#VersionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This version number allows tracking of major changes. Experts decide if a new version number must be applied"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Diese Versionsnummer ermoeglicht die Verfolgung groesserer aenderungen. Sachverstaendige entscheiden, ob eine neue Ver-sionsnummer angewendet werden muss."</para>
    /// labels<para>"Versionsnummer"</para><para>"Version number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#VersionNumber">https://w3id.org/iddo#VersionNumber</seealso>
    let VersionNumber = Prefixed_Name(iddo, "VersionNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#VisualRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Visual representation of the group of properties through sketches, photos, videos or other multimedia objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Bildliche Darstellung des Merkmals durch Skizzen, Fotos, Videos oder sonstige Multimedia-Objekte"</para>
    /// labels<para>"Visual representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Bildliche Darstellung"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#VisualRepresentation">https://w3id.org/iddo#VisualRepresentation</seealso>
    let VisualRepresentation =
        Prefixed_Name(iddo, "VisualRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Code, der zur Identifizierung des Attributs verwendet werden kann"</para>
    ///   <para>"Code that can be used to identify the attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Code"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#code">https://w3id.org/iddo#code</seealso>
    let code = Prefixed_Name(iddo, "code") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#hasDictionaryReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relation to a reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat den Verweis auf ein Referenzdokument"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#hasDictionaryReferenceDocument">https://w3id.org/iddo#hasDictionaryReferenceDocument</seealso>
    let hasDictionaryReferenceDocument =
        Prefixed_Name(iddo, "hasDictionaryReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#hasDictionarySubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dictionary subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Teilmenge eines Katalogs"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#hasDictionarySubset">https://w3id.org/iddo#hasDictionarySubset</seealso>
    let hasDictionarySubset = Prefixed_Name(iddo, "hasDictionarySubset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo#hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fuegt ein Merkmal zu einem Feature of Interest (FOI) hinzu"</para>
    ///   <para>"Attaches a property to a feature of interest (FOI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Merkmal"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#hasProperty">https://w3id.org/iddo#hasProperty</seealso>
    let hasProperty = Prefixed_Name(iddo, "hasProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#hasPropertyGroupReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fuegt eine Merkmalsgruppe (oberstes in der Hierarchie) zu einer iddo:ReferenceDocument hinzu"</para>
    ///   <para>"Attaches a property group reference to a iddo:ReferenceDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hat Merkmalsgruppenreferenz"</para><para>"has property group reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo#hasPropertyGroupReference">https://w3id.org/iddo#hasPropertyGroupReference</seealso>
    let hasPropertyGroupReference =
        Prefixed_Name(iddo, "hasPropertyGroupReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iddo#hasPropertyReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fuegt ein Merkmal zu einer Merkmalszuweisung hinzu"</para>
    ///   <para>"Attaches a property reference to a property assignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Property Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hat Merkmalreferenz"</para></remarks>
    /// <seealso href="https://w3id.org/iddo#hasPropertyReference">https://w3id.org/iddo#hasPropertyReference</seealso>
    let hasPropertyReference =
        Prefixed_Name(iddo, "hasPropertyReference") |> PrefixedName

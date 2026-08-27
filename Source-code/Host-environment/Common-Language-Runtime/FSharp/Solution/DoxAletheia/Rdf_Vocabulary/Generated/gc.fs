namespace http.www.oegov.org.core.owl.gc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gc =
    let _namespace_iri = Namespace_Iri gc |> NamespaceIRI
    /// <summary>
    ///   <para>gc:Anarcy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Anarcy">http://www.oegov.org/core/owl/gc#Anarcy</seealso>
    let Anarcy = Prefixed_Name(gc, "Anarcy") |> PrefixedName
    /// <summary>
    ///   <para>gc:AttributedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name, url and other details of an attribution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attributed Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#AttributedSource">http://www.oegov.org/core/owl/gc#AttributedSource</seealso>
    let AttributedSource = Prefixed_Name(gc, "AttributedSource") |> PrefixedName
    /// <summary>
    ///   <para>gc:CSV-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"CVS Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#CSV-Format">http://www.oegov.org/core/owl/gc#CSV-Format</seealso>
    let CSV_Format = Prefixed_Name(gc, "CSV-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Category">http://www.oegov.org/core/owl/gc#Category</seealso>
    let Category = Prefixed_Name(gc, "Category") |> PrefixedName
    /// <summary>
    ///   <para>gc:CommunistState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#CommunistState">http://www.oegov.org/core/owl/gc#CommunistState</seealso>
    let CommunistState = Prefixed_Name(gc, "CommunistState") |> PrefixedName

    /// <summary>
    ///   <para>gc:CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:License</para>
    ///
    /// labels<para>"Creative Commons Attribution-Share Alike 3.0 United States License"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense">http://www.oegov.org/core/owl/gc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense</seealso>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        Prefixed_Name(gc, "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense") |> PrefixedName

    /// <summary>
    ///   <para>gc:DataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#DataFormat">http://www.oegov.org/core/owl/gc#DataFormat</seealso>
    let DataFormat = Prefixed_Name(gc, "DataFormat") |> PrefixedName
    /// <summary>
    ///   <para>gc:DateUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#DateUnion">http://www.oegov.org/core/owl/gc#DateUnion</seealso>
    let DateUnion = Prefixed_Name(gc, "DateUnion") |> PrefixedName
    /// <summary>
    ///   <para>gc:Democracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Democracy">http://www.oegov.org/core/owl/gc#Democracy</seealso>
    let Democracy = Prefixed_Name(gc, "Democracy") |> PrefixedName
    /// <summary>
    ///   <para>gc:Dictatorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Dictatorship">http://www.oegov.org/core/owl/gc#Dictatorship</seealso>
    let Dictatorship = Prefixed_Name(gc, "Dictatorship") |> PrefixedName
    /// <summary>
    ///   <para>gc:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Entity">http://www.oegov.org/core/owl/gc#Entity</seealso>
    let Entity = Prefixed_Name(gc, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>gc:HTML-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"HTML Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#HTML-Format">http://www.oegov.org/core/owl/gc#HTML-Format</seealso>
    let HTML_Format = Prefixed_Name(gc, "HTML-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:KML-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"KML-Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#KML-Format">http://www.oegov.org/core/owl/gc#KML-Format</seealso>
    let KML_Format = Prefixed_Name(gc, "KML-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:KMZ-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"KMZ Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#KMZ-Format">http://www.oegov.org/core/owl/gc#KMZ-Format</seealso>
    let KMZ_Format = Prefixed_Name(gc, "KMZ-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:Monarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Monarchy">http://www.oegov.org/core/owl/gc#Monarchy</seealso>
    let Monarchy = Prefixed_Name(gc, "Monarchy") |> PrefixedName
    /// <summary>
    ///   <para>gc:OWL-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"OWL Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#OWL-Format">http://www.oegov.org/core/owl/gc#OWL-Format</seealso>
    let OWL_Format = Prefixed_Name(gc, "OWL-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Period">http://www.oegov.org/core/owl/gc#Period</seealso>
    let Period = Prefixed_Name(gc, "Period") |> PrefixedName
    /// <summary>
    ///   <para>gc:PoliticalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Political system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#PoliticalSystem">http://www.oegov.org/core/owl/gc#PoliticalSystem</seealso>
    let PoliticalSystem = Prefixed_Name(gc, "PoliticalSystem") |> PrefixedName
    /// <summary>
    ///   <para>gc:Q1</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:Quarter</para>
    ///
    /// labels<para>"Q1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Q1">http://www.oegov.org/core/owl/gc#Q1</seealso>
    let Q1 = Prefixed_Name(gc, "Q1") |> PrefixedName
    /// <summary>
    ///   <para>gc:Q2</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:Quarter</para>
    ///
    /// labels<para>"Q2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Q2">http://www.oegov.org/core/owl/gc#Q2</seealso>
    let Q2 = Prefixed_Name(gc, "Q2") |> PrefixedName
    /// <summary>
    ///   <para>gc:Q3</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:Quarter</para>
    ///
    /// labels<para>"Q3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Q3">http://www.oegov.org/core/owl/gc#Q3</seealso>
    let Q3 = Prefixed_Name(gc, "Q3") |> PrefixedName
    /// <summary>
    ///   <para>gc:Q4</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:Quarter</para>
    ///
    /// labels<para>"Q4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Q4">http://www.oegov.org/core/owl/gc#Q4</seealso>
    let Q4 = Prefixed_Name(gc, "Q4") |> PrefixedName
    /// <summary>
    ///   <para>gc:Quarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quarter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Quarter">http://www.oegov.org/core/owl/gc#Quarter</seealso>
    let Quarter = Prefixed_Name(gc, "Quarter") |> PrefixedName
    /// <summary>
    ///   <para>gc:RDF-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"RDF Fomat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#RDF-Format">http://www.oegov.org/core/owl/gc#RDF-Format</seealso>
    let RDF_Format = Prefixed_Name(gc, "RDF-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:RSS-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"RSS Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#RSS-Format">http://www.oegov.org/core/owl/gc#RSS-Format</seealso>
    let RSS_Format = Prefixed_Name(gc, "RSS-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Republic">http://www.oegov.org/core/owl/gc#Republic</seealso>
    let Republic = Prefixed_Name(gc, "Republic") |> PrefixedName
    /// <summary>
    ///   <para>gc:ShapefileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"Shapefile Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#ShapefileFormat">http://www.oegov.org/core/owl/gc#ShapefileFormat</seealso>
    let ShapefileFormat = Prefixed_Name(gc, "ShapefileFormat") |> PrefixedName
    /// <summary>
    ///   <para>gc:SocialistState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#SocialistState">http://www.oegov.org/core/owl/gc#SocialistState</seealso>
    let SocialistState = Prefixed_Name(gc, "SocialistState") |> PrefixedName
    /// <summary>
    ///   <para>gc:TextFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"Text Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#TextFormat">http://www.oegov.org/core/owl/gc#TextFormat</seealso>
    let TextFormat = Prefixed_Name(gc, "TextFormat") |> PrefixedName
    /// <summary>
    ///   <para>gc:Theocracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Theocracy">http://www.oegov.org/core/owl/gc#Theocracy</seealso>
    let Theocracy = Prefixed_Name(gc, "Theocracy") |> PrefixedName

    /// <summary>
    ///   <para>gc:TopQuadrantAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:AttributedSource</para>
    ///
    /// labels<para>"TopQuadrant attribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#TopQuadrantAttribution">http://www.oegov.org/core/owl/gc#TopQuadrantAttribution</seealso>
    let TopQuadrantAttribution =
        Prefixed_Name(gc, "TopQuadrantAttribution") |> PrefixedName

    /// <summary>
    ///   <para>gc:Tribal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#Tribal">http://www.oegov.org/core/owl/gc#Tribal</seealso>
    let Tribal = Prefixed_Name(gc, "Tribal") |> PrefixedName

    /// <summary>
    ///   <para>gc:UnstructuredDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"Unstructured Data Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#UnstructuredDataFormat">http://www.oegov.org/core/owl/gc#UnstructuredDataFormat</seealso>
    let UnstructuredDataFormat =
        Prefixed_Name(gc, "UnstructuredDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>gc:XML-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"XML Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#XML-Format">http://www.oegov.org/core/owl/gc#XML-Format</seealso>
    let XML_Format = Prefixed_Name(gc, "XML-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:XSL-Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>gc:DataFormat</para>
    ///
    /// labels<para>"XSL Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#XSL-Format">http://www.oegov.org/core/owl/gc#XSL-Format</seealso>
    let XSL_Format = Prefixed_Name(gc, "XSL-Format") |> PrefixedName
    /// <summary>
    ///   <para>gc:archiveURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"archive URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#archiveURL">http://www.oegov.org/core/owl/gc#archiveURL</seealso>
    let archiveURL = Prefixed_Name(gc, "archiveURL") |> PrefixedName
    /// <summary>
    ///   <para>gc:attributedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"attributed source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#attributedSource">http://www.oegov.org/core/owl/gc#attributedSource</seealso>
    let attributedSource = Prefixed_Name(gc, "attributedSource") |> PrefixedName
    /// <summary>
    ///   <para>gc:awardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"award date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#awardDate">http://www.oegov.org/core/owl/gc#awardDate</seealso>
    let awardDate = Prefixed_Name(gc, "awardDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#category">http://www.oegov.org/core/owl/gc#category</seealso>
    let category = Prefixed_Name(gc, "category") |> PrefixedName
    /// <summary>
    ///   <para>gc:cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#cause">http://www.oegov.org/core/owl/gc#cause</seealso>
    let cause = Prefixed_Name(gc, "cause") |> PrefixedName
    /// <summary>
    ///   <para>gc:cessationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"cessation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#cessationDate">http://www.oegov.org/core/owl/gc#cessationDate</seealso>
    let cessationDate = Prefixed_Name(gc, "cessationDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:clause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"clause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#clause">http://www.oegov.org/core/owl/gc#clause</seealso>
    let clause = Prefixed_Name(gc, "clause") |> PrefixedName
    /// <summary>
    ///   <para>gc:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"creation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#creationDate">http://www.oegov.org/core/owl/gc#creationDate</seealso>
    let creationDate = Prefixed_Name(gc, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#currency">http://www.oegov.org/core/owl/gc#currency</seealso>
    let currency = Prefixed_Name(gc, "currency") |> PrefixedName
    /// <summary>
    ///   <para>gc:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#date">http://www.oegov.org/core/owl/gc#date</seealso>
    let date = Prefixed_Name(gc, "date") |> PrefixedName
    /// <summary>
    ///   <para>gc:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"end date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#endDate">http://www.oegov.org/core/owl/gc#endDate</seealso>
    let endDate = Prefixed_Name(gc, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#format">http://www.oegov.org/core/owl/gc#format</seealso>
    let format = Prefixed_Name(gc, "format") |> PrefixedName
    /// <summary>
    ///   <para>gc:foundedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"founded on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#foundedOn">http://www.oegov.org/core/owl/gc#foundedOn</seealso>
    let foundedOn = Prefixed_Name(gc, "foundedOn") |> PrefixedName
    /// <summary>
    ///   <para>gc:hashtag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hashtag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#hashtag">http://www.oegov.org/core/owl/gc#hashtag</seealso>
    let hashtag = Prefixed_Name(gc, "hashtag") |> PrefixedName
    /// <summary>
    ///   <para>gc:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#identifier">http://www.oegov.org/core/owl/gc#identifier</seealso>
    let identifier = Prefixed_Name(gc, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>gc:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#image">http://www.oegov.org/core/owl/gc#image</seealso>
    let image = Prefixed_Name(gc, "image") |> PrefixedName
    /// <summary>
    ///   <para>gc:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"licence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#licence">http://www.oegov.org/core/owl/gc#licence</seealso>
    let licence = Prefixed_Name(gc, "licence") |> PrefixedName
    /// <summary>
    ///   <para>gc:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#member">http://www.oegov.org/core/owl/gc#member</seealso>
    let member_ = Prefixed_Name(gc, "member") |> PrefixedName
    /// <summary>
    ///   <para>gc:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#number">http://www.oegov.org/core/owl/gc#number</seealso>
    let number = Prefixed_Name(gc, "number") |> PrefixedName
    /// <summary>
    ///   <para>gc:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#person">http://www.oegov.org/core/owl/gc#person</seealso>
    let person = Prefixed_Name(gc, "person") |> PrefixedName
    /// <summary>
    ///   <para>gc:pointOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"point of contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#pointOfContact">http://www.oegov.org/core/owl/gc#pointOfContact</seealso>
    let pointOfContact = Prefixed_Name(gc, "pointOfContact") |> PrefixedName
    /// <summary>
    ///   <para>gc:releasedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"released date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#releasedDate">http://www.oegov.org/core/owl/gc#releasedDate</seealso>
    let releasedDate = Prefixed_Name(gc, "releasedDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#result">http://www.oegov.org/core/owl/gc#result</seealso>
    let result = Prefixed_Name(gc, "result") |> PrefixedName
    /// <summary>
    ///   <para>gc:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#revision">http://www.oegov.org/core/owl/gc#revision</seealso>
    let revision = Prefixed_Name(gc, "revision") |> PrefixedName
    /// <summary>
    ///   <para>gc:section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#section">http://www.oegov.org/core/owl/gc#section</seealso>
    let section = Prefixed_Name(gc, "section") |> PrefixedName
    /// <summary>
    ///   <para>gc:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"short title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#shortTitle">http://www.oegov.org/core/owl/gc#shortTitle</seealso>
    let shortTitle = Prefixed_Name(gc, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>gc:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#startDate">http://www.oegov.org/core/owl/gc#startDate</seealso>
    let startDate = Prefixed_Name(gc, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#status">http://www.oegov.org/core/owl/gc#status</seealso>
    let status = Prefixed_Name(gc, "status") |> PrefixedName
    /// <summary>
    ///   <para>gc:subCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sub category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#subCategory">http://www.oegov.org/core/owl/gc#subCategory</seealso>
    let subCategory = Prefixed_Name(gc, "subCategory") |> PrefixedName
    /// <summary>
    ///   <para>gc:submissionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"submission date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#submissionDate">http://www.oegov.org/core/owl/gc#submissionDate</seealso>
    let submissionDate = Prefixed_Name(gc, "submissionDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"summary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#summary">http://www.oegov.org/core/owl/gc#summary</seealso>
    let summary = Prefixed_Name(gc, "summary") |> PrefixedName
    /// <summary>
    ///   <para>gc:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#text">http://www.oegov.org/core/owl/gc#text</seealso>
    let text = Prefixed_Name(gc, "text") |> PrefixedName
    /// <summary>
    ///   <para>gc:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#title">http://www.oegov.org/core/owl/gc#title</seealso>
    let title = Prefixed_Name(gc, "title") |> PrefixedName
    /// <summary>
    ///   <para>gc:updatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"updated date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#updatedDate">http://www.oegov.org/core/owl/gc#updatedDate</seealso>
    let updatedDate = Prefixed_Name(gc, "updatedDate") |> PrefixedName
    /// <summary>
    ///   <para>gc:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#url">http://www.oegov.org/core/owl/gc#url</seealso>
    let url = Prefixed_Name(gc, "url") |> PrefixedName
    /// <summary>
    ///   <para>gc:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/gc#year">http://www.oegov.org/core/owl/gc#year</seealso>
    let year = Prefixed_Name(gc, "year") |> PrefixedName

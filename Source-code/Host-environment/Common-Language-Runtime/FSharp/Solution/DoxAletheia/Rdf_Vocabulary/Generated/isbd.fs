namespace http.iflastandards.info.ns.isbd.elements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module isbd =
    let _namespace_iri = Namespace_Iri isbd |> NamespaceIRI
    /// <summary>
    ///   <para>isbd:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/">http://iflastandards.info/ns/isbd/elements/</seealso>
    let _prefix_iri = Prefixed_Name(isbd, "") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource"</para><para>"Recurso"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2001">http://iflastandards.info/ns/isbd/elements/C2001</seealso>
    let C2001 = Prefixed_Name(isbd, "C2001") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ISBD Syntax Encoding Scheme"</para><para>"Esquema de codificación de sintaxis ISBD"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2002">http://iflastandards.info/ns/isbd/elements/C2002</seealso>
    let C2002 = Prefixed_Name(isbd, "C2002") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área de forma del contenido y de tipo de medio"</para><para>"Content Form And Media Type Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2003">http://iflastandards.info/ns/isbd/elements/C2003</seealso>
    let C2003 = Prefixed_Name(isbd, "C2003") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área de título y mención de responsabilidad"</para><para>"Title And Statement Of Responsibility Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2004">http://iflastandards.info/ns/isbd/elements/C2004</seealso>
    let C2004 = Prefixed_Name(isbd, "C2004") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área de edición"</para><para>"Edition Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2005">http://iflastandards.info/ns/isbd/elements/C2005</seealso>
    let C2005 = Prefixed_Name(isbd, "C2005") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área del material o tipo específico de recurso"</para><para>"Material Or Type Of Resource Specific Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2006">http://iflastandards.info/ns/isbd/elements/C2006</seealso>
    let C2006 = Prefixed_Name(isbd, "C2006") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área de publicación, producción, distribución, etc."</para><para>"Publication, Production, Distribution, Etc Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2007">http://iflastandards.info/ns/isbd/elements/C2007</seealso>
    let C2007 = Prefixed_Name(isbd, "C2007") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Description Area Encoding Scheme"</para><para>"Esquema de codificación del área de descripción material"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2008">http://iflastandards.info/ns/isbd/elements/C2008</seealso>
    let C2008 = Prefixed_Name(isbd, "C2008") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del área de serie y recurso monográfico multiparte"</para><para>"Series And Multipart Monographic Resource Area Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2009">http://iflastandards.info/ns/isbd/elements/C2009</seealso>
    let C2009 = Prefixed_Name(isbd, "C2009") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Note Area Encoding Scheme"</para><para>"Esquema de codificación del área de notas"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2010">http://iflastandards.info/ns/isbd/elements/C2010</seealso>
    let C2010 = Prefixed_Name(isbd, "C2010") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource Identifier And Terms Of Availability Area Encoding Scheme"</para><para>"Esquema de codificación del área de identificador del recurso y condiciones de disponibilidad"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2011">http://iflastandards.info/ns/isbd/elements/C2011</seealso>
    let C2011 = Prefixed_Name(isbd, "C2011") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mathematical Data Area Encoding Scheme"</para><para>"Esquema de codificación del área de datos matemáticos"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2012">http://iflastandards.info/ns/isbd/elements/C2012</seealso>
    let C2012 = Prefixed_Name(isbd, "C2012") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Music Format Statement Area Encoding Scheme"</para><para>"Esquema de codificación del área de mención de formato musical "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2013">http://iflastandards.info/ns/isbd/elements/C2013</seealso>
    let C2013 = Prefixed_Name(isbd, "C2013") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Numbering Area Encoding Scheme"</para><para>"Esquema de codificación del área de numeración"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2014">http://iflastandards.info/ns/isbd/elements/C2014</seealso>
    let C2014 = Prefixed_Name(isbd, "C2014") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Specific Material Designation And Extent Encoding Scheme"</para><para>"Esquema de codificación de designación específica del material y extensión"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2015">http://iflastandards.info/ns/isbd/elements/C2015</seealso>
    let C2015 = Prefixed_Name(isbd, "C2015") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación de otros detalles físicos"</para><para>"Other Physical Details Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2016">http://iflastandards.info/ns/isbd/elements/C2016</seealso>
    let C2016 = Prefixed_Name(isbd, "C2016") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Statement Of Coordinates And Equinox Encoding Scheme"</para><para>"Esquema de codificación de la mención de coordenadas y equinoccio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2017">http://iflastandards.info/ns/isbd/elements/C2017</seealso>
    let C2017 = Prefixed_Name(isbd, "C2017") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación de mención de lugar de publicación, producción o distribución"</para><para>"Place Of Publication, Production, Distribution Statement Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2018">http://iflastandards.info/ns/isbd/elements/C2018</seealso>
    let C2018 = Prefixed_Name(isbd, "C2018") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Name Of Publisher, Producer, Distributor Statement Encoding Scheme"</para><para>"Esquema de codificación de mención del nombre del editor, productor o distribuidor"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2019">http://iflastandards.info/ns/isbd/elements/C2019</seealso>
    let C2019 = Prefixed_Name(isbd, "C2019") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Statement Of Printing Or Manufacture Encoding Scheme"</para><para>"Esquema de codificación de mención de impresión o fabricación"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2020">http://iflastandards.info/ns/isbd/elements/C2020</seealso>
    let C2020 = Prefixed_Name(isbd, "C2020") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del título compuesto de título propiamente dicho"</para><para>"Compound Title Of Title Proper Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2021">http://iflastandards.info/ns/isbd/elements/C2021</seealso>
    let C2021 = Prefixed_Name(isbd, "C2021") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del título propiamente dicho (compuesto) de serie"</para><para>"Title Proper (Compound) Of Series Or Multipart Monographic Resource Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2022">http://iflastandards.info/ns/isbd/elements/C2022</seealso>
    let C2022 = Prefixed_Name(isbd, "C2022") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parallel Title (Compound) Of Series Or Multipart Monographic Resource Encoding Scheme"</para><para>"Esquema de codificación del título paralelo (compuesto) de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2024">http://iflastandards.info/ns/isbd/elements/C2024</seealso>
    let C2024 = Prefixed_Name(isbd, "C2024") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación del título compuesto de título paralelo"</para><para>"Compound Title Of Parallel Title Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2025">http://iflastandards.info/ns/isbd/elements/C2025</seealso>
    let C2025 = Prefixed_Name(isbd, "C2025") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Esquema de codificación de mención de forma del contenido y de tipo de medio"</para><para>"Content Form And Media Type Statement Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2026">http://iflastandards.info/ns/isbd/elements/C2026</seealso>
    let C2026 = Prefixed_Name(isbd, "C2026") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Terms Of Availability Statement Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2027">http://iflastandards.info/ns/isbd/elements/C2027</seealso>
    let C2027 = Prefixed_Name(isbd, "C2027") |> PrefixedName
    /// <summary>
    ///   <para>isbd:C2028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource Identifier Statement Encoding Scheme"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/C2028">http://iflastandards.info/ns/isbd/elements/C2028</seealso>
    let C2028 = Prefixed_Name(isbd, "C2028") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene forma del contenido"</para><para>"has content form"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1001">http://iflastandards.info/ns/isbd/elements/P1001</seealso>
    let P1001 = Prefixed_Name(isbd, "P1001") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has content qualification"</para><para>"tiene aclaración de contenido"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1002">http://iflastandards.info/ns/isbd/elements/P1002</seealso>
    let P1002 = Prefixed_Name(isbd, "P1002") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has media type"</para><para>"tiene tipo de medio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1003">http://iflastandards.info/ns/isbd/elements/P1003</seealso>
    let P1003 = Prefixed_Name(isbd, "P1003") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título propiamente dicho"</para><para>"has title proper"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1004">http://iflastandards.info/ns/isbd/elements/P1004</seealso>
    let P1004 = Prefixed_Name(isbd, "P1004") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título paralelo"</para><para>"has parallel title"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1005">http://iflastandards.info/ns/isbd/elements/P1005</seealso>
    let P1005 = Prefixed_Name(isbd, "P1005") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other title information"</para><para>"tiene información complementaria del título"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1006">http://iflastandards.info/ns/isbd/elements/P1006</seealso>
    let P1006 = Prefixed_Name(isbd, "P1006") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to title"</para><para>"tienen mención de responsabilidad relativa al título"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1007">http://iflastandards.info/ns/isbd/elements/P1007</seealso>
    let P1007 = Prefixed_Name(isbd, "P1007") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has edition statement"</para><para>"tiene mención de edición"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1008">http://iflastandards.info/ns/isbd/elements/P1008</seealso>
    let P1008 = Prefixed_Name(isbd, "P1008") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de edición paralela"</para><para>"has parallel edition statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1009">http://iflastandards.info/ns/isbd/elements/P1009</seealso>
    let P1009 = Prefixed_Name(isbd, "P1009") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to edition"</para><para>"tiene mención de responsabilidad relativa a edición"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1010">http://iflastandards.info/ns/isbd/elements/P1010</seealso>
    let P1010 = Prefixed_Name(isbd, "P1010") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has additional edition statement"</para><para>"tiene mención de edición adicional"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1011">http://iflastandards.info/ns/isbd/elements/P1011</seealso>
    let P1011 = Prefixed_Name(isbd, "P1011") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título"</para><para>"has title"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1012">http://iflastandards.info/ns/isbd/elements/P1012</seealso>
    let P1012 = Prefixed_Name(isbd, "P1012") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de datos matemáticos"</para><para>"has mathematical data area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1013">http://iflastandards.info/ns/isbd/elements/P1013</seealso>
    let P1013 = Prefixed_Name(isbd, "P1013") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de formato musical"</para><para>"has music format statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1014">http://iflastandards.info/ns/isbd/elements/P1014</seealso>
    let P1014 = Prefixed_Name(isbd, "P1014") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de numeración"</para><para>"has numbering area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1015">http://iflastandards.info/ns/isbd/elements/P1015</seealso>
    let P1015 = Prefixed_Name(isbd, "P1015") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene lugar de publicación, producción, distribución"</para><para>"has place of publication, production, distribution"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1016">http://iflastandards.info/ns/isbd/elements/P1016</seealso>
    let P1016 = Prefixed_Name(isbd, "P1016") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has name of publisher, producer, distributor"</para><para>"tiene nombre de editor, productor, distribuidor"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1017">http://iflastandards.info/ns/isbd/elements/P1017</seealso>
    let P1017 = Prefixed_Name(isbd, "P1017") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of publication, production, distribution"</para><para>"tiene fecha de publicación, producción, distribución"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1018">http://iflastandards.info/ns/isbd/elements/P1018</seealso>
    let P1018 = Prefixed_Name(isbd, "P1018") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene lugar de impresión o fabricación"</para><para>"has place of printing or manufacture"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1019">http://iflastandards.info/ns/isbd/elements/P1019</seealso>
    let P1019 = Prefixed_Name(isbd, "P1019") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has name of printer or manufacturer"</para><para>"tiene nombre de impresor o fabricante"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1020">http://iflastandards.info/ns/isbd/elements/P1020</seealso>
    let P1020 = Prefixed_Name(isbd, "P1020") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene fecha de impresión o fabricación"</para><para>"has date of printing or manufacture"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1021">http://iflastandards.info/ns/isbd/elements/P1021</seealso>
    let P1021 = Prefixed_Name(isbd, "P1021") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has specific material designation and extent"</para><para>"tiene designación específica del material y extensión"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1022">http://iflastandards.info/ns/isbd/elements/P1022</seealso>
    let P1022 = Prefixed_Name(isbd, "P1022") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene otros detalles físicos"</para><para>"has other physical details"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1023">http://iflastandards.info/ns/isbd/elements/P1023</seealso>
    let P1023 = Prefixed_Name(isbd, "P1023") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dimensions"</para><para>"tiene dimensiones"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1024">http://iflastandards.info/ns/isbd/elements/P1024</seealso>
    let P1024 = Prefixed_Name(isbd, "P1024") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de material anejo"</para><para>"has accompanying material statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1025">http://iflastandards.info/ns/isbd/elements/P1025</seealso>
    let P1025 = Prefixed_Name(isbd, "P1025") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título propiamente dicho de serie o recurso monográfico multiparte"</para><para>"has title proper of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1026">http://iflastandards.info/ns/isbd/elements/P1026</seealso>
    let P1026 = Prefixed_Name(isbd, "P1026") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title of series or multipart monographic resource"</para><para>"tiene título paralelo de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1027">http://iflastandards.info/ns/isbd/elements/P1027</seealso>
    let P1027 = Prefixed_Name(isbd, "P1027") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene información complementaria del título de serie o recurso monográfico multiparte"</para><para>"has other title information of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1028">http://iflastandards.info/ns/isbd/elements/P1028</seealso>
    let P1028 = Prefixed_Name(isbd, "P1028") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de responsabilidad de serie o recurso monográfico multiparte"</para><para>"has statement of responsibility of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1029">http://iflastandards.info/ns/isbd/elements/P1029</seealso>
    let P1029 = Prefixed_Name(isbd, "P1029") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has international standard number of series or multipart monographic resource"</para><para>"tiene número normalizado internacional de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1030">http://iflastandards.info/ns/isbd/elements/P1030</seealso>
    let P1030 = Prefixed_Name(isbd, "P1030") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene numeración de serie o recurso monográfico multiparte"</para><para>"has numbering within series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1031">http://iflastandards.info/ns/isbd/elements/P1031</seealso>
    let P1031 = Prefixed_Name(isbd, "P1031") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has resource identifier"</para><para>"tiene identificador del recurso"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1032">http://iflastandards.info/ns/isbd/elements/P1032</seealso>
    let P1032 = Prefixed_Name(isbd, "P1032") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has key title"</para><para>"tiene título clave"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1033">http://iflastandards.info/ns/isbd/elements/P1033</seealso>
    let P1033 = Prefixed_Name(isbd, "P1033") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene condiciones de disponibilidad"</para><para>"has terms of availability"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1034">http://iflastandards.info/ns/isbd/elements/P1034</seealso>
    let P1034 = Prefixed_Name(isbd, "P1034") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on edition area and bibliographic history"</para><para>"tiene nota sobre el área de edición e historia bibliográfica"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1037">http://iflastandards.info/ns/isbd/elements/P1037</seealso>
    let P1037 = Prefixed_Name(isbd, "P1037") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on material type or resource specific type"</para><para>"tiene nota sobre tipo de material o tipo específico de recurso"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1038">http://iflastandards.info/ns/isbd/elements/P1038</seealso>
    let P1038 = Prefixed_Name(isbd, "P1038") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre publicación, producción, distribución, etc."</para><para>"has note on publication, production, distribution, etc."</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1039">http://iflastandards.info/ns/isbd/elements/P1039</seealso>
    let P1039 = Prefixed_Name(isbd, "P1039") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre descripción del material"</para><para>"has note on material description"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1040">http://iflastandards.info/ns/isbd/elements/P1040</seealso>
    let P1040 = Prefixed_Name(isbd, "P1040") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de serie o recurso monográfico multiparte"</para><para>"has note on series and multipart monographic resources"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1041">http://iflastandards.info/ns/isbd/elements/P1041</seealso>
    let P1041 = Prefixed_Name(isbd, "P1041") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre el contenido"</para><para>"has note on contents"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1042">http://iflastandards.info/ns/isbd/elements/P1042</seealso>
    let P1042 = Prefixed_Name(isbd, "P1042") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on basis of description"</para><para>"tiene nota sobre base de descripción"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1044">http://iflastandards.info/ns/isbd/elements/P1044</seealso>
    let P1044 = Prefixed_Name(isbd, "P1044") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota"</para><para>"has note"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1045">http://iflastandards.info/ns/isbd/elements/P1045</seealso>
    let P1045 = Prefixed_Name(isbd, "P1045") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on copy in hand"</para><para>"tiene nota sobre el ejemplar que se describe"</para><para>"Incluye notas relativas a las características físicas del ejemplar, notas relativas a ejemplares “encuadernados con”, notas de procedencia y notas de acción."</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1046">http://iflastandards.info/ns/isbd/elements/P1046</seealso>
    let P1046 = Prefixed_Name(isbd, "P1046") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de escala"</para><para>"has statement of scale"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1047">http://iflastandards.info/ns/isbd/elements/P1047</seealso>
    let P1047 = Prefixed_Name(isbd, "P1047") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of projection"</para><para>"tiene mención de proyección"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1048">http://iflastandards.info/ns/isbd/elements/P1048</seealso>
    let P1048 = Prefixed_Name(isbd, "P1048") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of coordinates and equinox"</para><para>"tiene mención de coordenadas y equinoccio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1049">http://iflastandards.info/ns/isbd/elements/P1049</seealso>
    let P1049 = Prefixed_Name(isbd, "P1049") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene coordenadas"</para><para>"has coordinates"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1050">http://iflastandards.info/ns/isbd/elements/P1050</seealso>
    let P1050 = Prefixed_Name(isbd, "P1050") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene ascensión recta y declinación"</para><para>"has right ascension and declination"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1051">http://iflastandards.info/ns/isbd/elements/P1051</seealso>
    let P1051 = Prefixed_Name(isbd, "P1051") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has equinox"</para><para>"tiene equinoccio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1052">http://iflastandards.info/ns/isbd/elements/P1052</seealso>
    let P1052 = Prefixed_Name(isbd, "P1052") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has extent"</para><para>"tiene extensión"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1053">http://iflastandards.info/ns/isbd/elements/P1053</seealso>
    let P1053 = Prefixed_Name(isbd, "P1053") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has pagination"</para><para>"tiene paginación"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1054">http://iflastandards.info/ns/isbd/elements/P1054</seealso>
    let P1054 = Prefixed_Name(isbd, "P1054") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene duración"</para><para>"has playing time"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1055">http://iflastandards.info/ns/isbd/elements/P1055</seealso>
    let P1055 = Prefixed_Name(isbd, "P1055") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has composition of material"</para><para>"tiene composición de material"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1056">http://iflastandards.info/ns/isbd/elements/P1056</seealso>
    let P1056 = Prefixed_Name(isbd, "P1056") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene presencia de ilustraciones"</para><para>"has presence of illustrations"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1057">http://iflastandards.info/ns/isbd/elements/P1057</seealso>
    let P1057 = Prefixed_Name(isbd, "P1057") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to an additional edition statement"</para><para>"tiene mención de responsabilidad paralela relativa a una mención de edición adicional"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1058">http://iflastandards.info/ns/isbd/elements/P1058</seealso>
    let P1058 = Prefixed_Name(isbd, "P1058") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to an additional edition statement"</para><para>"tiene mención de responsabilidad relativa a una mención de edición adicional"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1059">http://iflastandards.info/ns/isbd/elements/P1059</seealso>
    let P1059 = Prefixed_Name(isbd, "P1059") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has presence of colour"</para><para>"tiene presencia de color"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1060">http://iflastandards.info/ns/isbd/elements/P1060</seealso>
    let P1060 = Prefixed_Name(isbd, "P1060") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has reduction ratio"</para><para>"tiene proporción de reducción"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1061">http://iflastandards.info/ns/isbd/elements/P1061</seealso>
    let P1061 = Prefixed_Name(isbd, "P1061") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has presence or absence of sound"</para><para>"tiene presencia o ausencia de sonido"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1062">http://iflastandards.info/ns/isbd/elements/P1062</seealso>
    let P1062 = Prefixed_Name(isbd, "P1062") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has frame alignment"</para><para>"tiene alineación de los fotogramas"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1063">http://iflastandards.info/ns/isbd/elements/P1063</seealso>
    let P1063 = Prefixed_Name(isbd, "P1063") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de referencia bibliográfica"</para><para>"has note on bibliographic reference"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1064">http://iflastandards.info/ns/isbd/elements/P1064</seealso>
    let P1064 = Prefixed_Name(isbd, "P1064") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on frequency"</para><para>"tiene nota de frecuencia"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1065">http://iflastandards.info/ns/isbd/elements/P1065</seealso>
    let P1065 = Prefixed_Name(isbd, "P1065") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de requisitos mínimos del sistema"</para><para>"has note on system requirements "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1066">http://iflastandards.info/ns/isbd/elements/P1066</seealso>
    let P1066 = Prefixed_Name(isbd, "P1066") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre modo de acceso"</para><para>"has note on mode of access "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1067">http://iflastandards.info/ns/isbd/elements/P1067</seealso>
    let P1067 = Prefixed_Name(isbd, "P1067") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre título propiamente dicho"</para><para>"has note on title proper"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1068">http://iflastandards.info/ns/isbd/elements/P1068</seealso>
    let P1068 = Prefixed_Name(isbd, "P1068") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on nature, scope, form, purpose or language"</para><para>"tiene nota sobre naturaleza, alcance, forma, propósito o lengua"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1073">http://iflastandards.info/ns/isbd/elements/P1073</seealso>
    let P1073 = Prefixed_Name(isbd, "P1073") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene identificador tipográfico"</para><para>"has fingerprint"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1075">http://iflastandards.info/ns/isbd/elements/P1075</seealso>
    let P1075 = Prefixed_Name(isbd, "P1075") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nombre comercial y número de catálogo"</para><para>"has label name and catalogue number"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1076">http://iflastandards.info/ns/isbd/elements/P1076</seealso>
    let P1076 = Prefixed_Name(isbd, "P1076") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene aclaración para el identificador"</para><para>"has qualification to identifier"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1077">http://iflastandards.info/ns/isbd/elements/P1077</seealso>
    let P1077 = Prefixed_Name(isbd, "P1077") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on binding"</para><para>"tiene nota sobre la encuadernación"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1078">http://iflastandards.info/ns/isbd/elements/P1078</seealso>
    let P1078 = Prefixed_Name(isbd, "P1078") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre identificador del recurso y condición de disponibilidad"</para><para>"has note on resource identifier and terms of availability"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1079">http://iflastandards.info/ns/isbd/elements/P1079</seealso>
    let P1079 = Prefixed_Name(isbd, "P1079") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota sobre títulos paralelos e información complementaria del título paralelo"</para><para>"has note on parallel titles and parallel other title information"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1086">http://iflastandards.info/ns/isbd/elements/P1086</seealso>
    let P1086 = Prefixed_Name(isbd, "P1086") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on statement of responsibility"</para><para>"tiene nota sobre mención de responsabilidad"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1087">http://iflastandards.info/ns/isbd/elements/P1087</seealso>
    let P1087 = Prefixed_Name(isbd, "P1087") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de provisión de sumario"</para><para>"has note providing a summary"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1090">http://iflastandards.info/ns/isbd/elements/P1090</seealso>
    let P1090 = Prefixed_Name(isbd, "P1090") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on use or audience"</para><para>"tiene nota de uso o destinatario"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1091">http://iflastandards.info/ns/isbd/elements/P1091</seealso>
    let P1091 = Prefixed_Name(isbd, "P1091") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota relativa a números"</para><para>"has note on numbers"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1092">http://iflastandards.info/ns/isbd/elements/P1092</seealso>
    let P1092 = Prefixed_Name(isbd, "P1092") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has terms of availability statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1093">http://iflastandards.info/ns/isbd/elements/P1093</seealso>
    let P1093 = Prefixed_Name(isbd, "P1093") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on change to edition"</para><para>"tiene nota de cambio en edición"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1094">http://iflastandards.info/ns/isbd/elements/P1094</seealso>
    let P1094 = Prefixed_Name(isbd, "P1094") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de historia bibliográfica"</para><para>"has note on bibliographic history"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1095">http://iflastandards.info/ns/isbd/elements/P1095</seealso>
    let P1095 = Prefixed_Name(isbd, "P1095") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de traducciones"</para><para>"has note on translations"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1096">http://iflastandards.info/ns/isbd/elements/P1096</seealso>
    let P1096 = Prefixed_Name(isbd, "P1096") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de diferentes ediciones"</para><para>"has note on different editions"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1097">http://iflastandards.info/ns/isbd/elements/P1097</seealso>
    let P1097 = Prefixed_Name(isbd, "P1097") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on reproduction"</para><para>"tiene nota de reproducción"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1098">http://iflastandards.info/ns/isbd/elements/P1098</seealso>
    let P1098 = Prefixed_Name(isbd, "P1098") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de relación con otros recursos"</para><para>"has note on relationship to other resources"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1099">http://iflastandards.info/ns/isbd/elements/P1099</seealso>
    let P1099 = Prefixed_Name(isbd, "P1099") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on supplements, inserts, etc."</para><para>"tiene nota de suplementos, insertos, etc."</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1100">http://iflastandards.info/ns/isbd/elements/P1100</seealso>
    let P1100 = Prefixed_Name(isbd, "P1100") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de relación entre recursos continuados"</para><para>"has note on relationship between continuing resources"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1101">http://iflastandards.info/ns/isbd/elements/P1101</seealso>
    let P1101 = Prefixed_Name(isbd, "P1101") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de notas"</para><para>"has note area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1107">http://iflastandards.info/ns/isbd/elements/P1107</seealso>
    let P1107 = Prefixed_Name(isbd, "P1107") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene sistema paralelo de numeración"</para><para>"has parallel numbering system "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1116">http://iflastandards.info/ns/isbd/elements/P1116</seealso>
    let P1116 = Prefixed_Name(isbd, "P1116") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título de obra individual del mismo autor"</para><para>"has title of individual work by same author"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1117">http://iflastandards.info/ns/isbd/elements/P1117</seealso>
    let P1117 = Prefixed_Name(isbd, "P1117") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title of individual work by different author"</para><para>"tiene título de obra individual de diferente autor"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1118">http://iflastandards.info/ns/isbd/elements/P1118</seealso>
    let P1118 = Prefixed_Name(isbd, "P1118") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de formato musical paralela"</para><para>"has parallel music format statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1119">http://iflastandards.info/ns/isbd/elements/P1119</seealso>
    let P1119 = Prefixed_Name(isbd, "P1119") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has subsequent numbering system"</para><para>"tiene sistema sucesivo de numeración"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1120">http://iflastandards.info/ns/isbd/elements/P1120</seealso>
    let P1120 = Prefixed_Name(isbd, "P1120") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel name of publisher, producer, distributor"</para><para>"tiene nombre paralelo de editor, productor, distribuidor"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1121">http://iflastandards.info/ns/isbd/elements/P1121</seealso>
    let P1121 = Prefixed_Name(isbd, "P1121") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene formato bibliográfico de recurso monográfico antiguo"</para><para>"has bibliographic format of older monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1122">http://iflastandards.info/ns/isbd/elements/P1122</seealso>
    let P1122 = Prefixed_Name(isbd, "P1122") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on supplement to or insert in"</para><para>"tiene nota de suplemento a o de insertado en"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1123">http://iflastandards.info/ns/isbd/elements/P1123</seealso>
    let P1123 = Prefixed_Name(isbd, "P1123") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene nota de otras relaciones"</para><para>"has note on other relationships"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1124">http://iflastandards.info/ns/isbd/elements/P1124</seealso>
    let P1124 = Prefixed_Name(isbd, "P1124") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has resource identifier statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1125">http://iflastandards.info/ns/isbd/elements/P1125</seealso>
    let P1125 = Prefixed_Name(isbd, "P1125") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has process or method of reproduction of still image"</para><para>"tiene proceso o método de reproducción de imagen fija"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1126">http://iflastandards.info/ns/isbd/elements/P1126</seealso>
    let P1126 = Prefixed_Name(isbd, "P1126") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene velocidad de reproducción"</para><para>"has playing speed"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1127">http://iflastandards.info/ns/isbd/elements/P1127</seealso>
    let P1127 = Prefixed_Name(isbd, "P1127") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene método de grabación"</para><para>"has recording method"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1128">http://iflastandards.info/ns/isbd/elements/P1128</seealso>
    let P1128 = Prefixed_Name(isbd, "P1128") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene dirección del surco"</para><para>"has groove direction"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1129">http://iflastandards.info/ns/isbd/elements/P1129</seealso>
    let P1129 = Prefixed_Name(isbd, "P1129") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene tamaño del surco"</para><para>"has groove size"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1130">http://iflastandards.info/ns/isbd/elements/P1130</seealso>
    let P1130 = Prefixed_Name(isbd, "P1130") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has number of tape tracks"</para><para>"tiene número de pistas"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1131">http://iflastandards.info/ns/isbd/elements/P1131</seealso>
    let P1131 = Prefixed_Name(isbd, "P1131") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has track configuration"</para><para>"tiene configuración de pistas"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1132">http://iflastandards.info/ns/isbd/elements/P1132</seealso>
    let P1132 = Prefixed_Name(isbd, "P1132") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene número de canales de sonido"</para><para>"has number of sound channels"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1133">http://iflastandards.info/ns/isbd/elements/P1133</seealso>
    let P1133 = Prefixed_Name(isbd, "P1133") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene ecualización"</para><para>"has equalization"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1134">http://iflastandards.info/ns/isbd/elements/P1134</seealso>
    let P1134 = Prefixed_Name(isbd, "P1134") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has noise reduction"</para><para>"tiene reducción de ruido"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1135">http://iflastandards.info/ns/isbd/elements/P1135</seealso>
    let P1135 = Prefixed_Name(isbd, "P1135") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on content form and media type"</para><para>"tiene nota sobre forma del contenido y tipo de medio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1136">http://iflastandards.info/ns/isbd/elements/P1136</seealso>
    let P1136 = Prefixed_Name(isbd, "P1136") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título común de título propiamente dicho"</para><para>"has common title of title proper"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1137">http://iflastandards.info/ns/isbd/elements/P1137</seealso>
    let P1137 = Prefixed_Name(isbd, "P1137") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dependent title of title proper"</para><para>"tiene título dependiente de título propiamente dicho"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1138">http://iflastandards.info/ns/isbd/elements/P1138</seealso>
    let P1138 = Prefixed_Name(isbd, "P1138") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene designación de título dependiente de título propiamente dicho"</para><para>"has dependent title designation of title proper"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1139">http://iflastandards.info/ns/isbd/elements/P1139</seealso>
    let P1139 = Prefixed_Name(isbd, "P1139") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene información complementaria del título paralela"</para><para>"has parallel other title information"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1140">http://iflastandards.info/ns/isbd/elements/P1140</seealso>
    let P1140 = Prefixed_Name(isbd, "P1140") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to title"</para><para>"tiene mención de responsabilidad paralela al título"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1141">http://iflastandards.info/ns/isbd/elements/P1141</seealso>
    let P1141 = Prefixed_Name(isbd, "P1141") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de responsabilidad paralela relativa a edición"</para><para>"has parallel statement of responsibility relating to edition"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1142">http://iflastandards.info/ns/isbd/elements/P1142</seealso>
    let P1142 = Prefixed_Name(isbd, "P1142") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel additional edition statement"</para><para>"tiene mención de edición adicional paralela"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1143">http://iflastandards.info/ns/isbd/elements/P1143</seealso>
    let P1143 = Prefixed_Name(isbd, "P1143") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene adición al lugar de publicación"</para><para>"has addition to place of publication"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1144">http://iflastandards.info/ns/isbd/elements/P1144</seealso>
    let P1144 = Prefixed_Name(isbd, "P1144") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel place of publication, production, distribution"</para><para>"tiene lugar paralelo de publicación, producción, distribución"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1145">http://iflastandards.info/ns/isbd/elements/P1145</seealso>
    let P1145 = Prefixed_Name(isbd, "P1145") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene designación específica del material"</para><para>"has specific material designation"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1146">http://iflastandards.info/ns/isbd/elements/P1146</seealso>
    let P1146 = Prefixed_Name(isbd, "P1146") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has common title of series or multipart monographic resource"</para><para>"tiene título común de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1147">http://iflastandards.info/ns/isbd/elements/P1147</seealso>
    let P1147 = Prefixed_Name(isbd, "P1147") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dependent title of series or multipart monographic resource"</para><para>"tiene título dependiente de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1148">http://iflastandards.info/ns/isbd/elements/P1148</seealso>
    let P1148 = Prefixed_Name(isbd, "P1148") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dependent title designation of series or multipart monographic resource"</para><para>"tiene designación de título dependiente de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1149">http://iflastandards.info/ns/isbd/elements/P1149</seealso>
    let P1149 = Prefixed_Name(isbd, "P1149") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene aclaración a condición de disponibilidad "</para><para>"has qualification to terms of availability"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1150">http://iflastandards.info/ns/isbd/elements/P1150</seealso>
    let P1150 = Prefixed_Name(isbd, "P1150") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene adición al lugar de publicación paralelo"</para><para>"has addition to parallel place of publication"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1151">http://iflastandards.info/ns/isbd/elements/P1151</seealso>
    let P1151 = Prefixed_Name(isbd, "P1151") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel other title information of series or multipart monographic resource"</para><para>"tiene información complementaria del título paralela de serie o de recurso monográfico multiparte "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1152">http://iflastandards.info/ns/isbd/elements/P1152</seealso>
    let P1152 = Prefixed_Name(isbd, "P1152") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility of series or multipart monographic resource"</para><para>"tiene mención de responsabilidad paralela de serie o recurso monográfico multiparte "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1153">http://iflastandards.info/ns/isbd/elements/P1153</seealso>
    let P1153 = Prefixed_Name(isbd, "P1153") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene identificador normalizado"</para><para>"has standard identifier"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1154">http://iflastandards.info/ns/isbd/elements/P1154</seealso>
    let P1154 = Prefixed_Name(isbd, "P1154") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has longitude and latitude"</para><para>"tiene longitud y latitud"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1155">http://iflastandards.info/ns/isbd/elements/P1155</seealso>
    let P1155 = Prefixed_Name(isbd, "P1155") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numeric designation"</para><para>"tiene designación  numérica"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1156">http://iflastandards.info/ns/isbd/elements/P1156</seealso>
    let P1156 = Prefixed_Name(isbd, "P1156") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene designación cronológica"</para><para>"has chronological designation"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1157">http://iflastandards.info/ns/isbd/elements/P1157</seealso>
    let P1157 = Prefixed_Name(isbd, "P1157") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1158</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has content form and media type area"</para><para>"tiene área de forma del contenido y de tipo de medio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1158">http://iflastandards.info/ns/isbd/elements/P1158</seealso>
    let P1158 = Prefixed_Name(isbd, "P1158") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de título y mención de responsabilidad"</para><para>"has title and statement of responsibility area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1159">http://iflastandards.info/ns/isbd/elements/P1159</seealso>
    let P1159 = Prefixed_Name(isbd, "P1159") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de edición"</para><para>"has edition area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1160">http://iflastandards.info/ns/isbd/elements/P1160</seealso>
    let P1160 = Prefixed_Name(isbd, "P1160") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área específica de material o tipo de recurso"</para><para>"has material or type of resource specific area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1161">http://iflastandards.info/ns/isbd/elements/P1161</seealso>
    let P1161 = Prefixed_Name(isbd, "P1161") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publication, production, distribution, etc area"</para><para>"tiene área de publicación, producción, distribución, etc."</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1162">http://iflastandards.info/ns/isbd/elements/P1162</seealso>
    let P1162 = Prefixed_Name(isbd, "P1162") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de descripción del material"</para><para>"has material description area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1163">http://iflastandards.info/ns/isbd/elements/P1163</seealso>
    let P1163 = Prefixed_Name(isbd, "P1163") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has series and multipart monographic resource area"</para><para>"tiene área de serie y recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1164">http://iflastandards.info/ns/isbd/elements/P1164</seealso>
    let P1164 = Prefixed_Name(isbd, "P1164") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene área de identificador del recurso y condiciones de disponibilidad"</para><para>"has resource identifier and terms of availability area"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1165">http://iflastandards.info/ns/isbd/elements/P1165</seealso>
    let P1165 = Prefixed_Name(isbd, "P1165") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has music format statement area"</para><para>"tiene área de mención de formato musical"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1166">http://iflastandards.info/ns/isbd/elements/P1166</seealso>
    let P1166 = Prefixed_Name(isbd, "P1166") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of printing or manufacture"</para><para>"tiene mención de impresión o fabricación"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1167">http://iflastandards.info/ns/isbd/elements/P1167</seealso>
    let P1167 = Prefixed_Name(isbd, "P1167") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene mención de lugar de publicación, producción o distribución"</para><para>"has place of publication, production, distribution statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1168">http://iflastandards.info/ns/isbd/elements/P1168</seealso>
    let P1168 = Prefixed_Name(isbd, "P1168") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has name of publisher, producer, distributor statement"</para><para>"tiene mención del nombre del editor, productor o distribuidor"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1169">http://iflastandards.info/ns/isbd/elements/P1169</seealso>
    let P1169 = Prefixed_Name(isbd, "P1169") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1170">http://iflastandards.info/ns/isbd/elements/P1170</seealso>
    let P1170 = Prefixed_Name(isbd, "P1170") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has compound title of title proper"</para><para>"tiene título compueso de propiamente dicho"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1171">http://iflastandards.info/ns/isbd/elements/P1171</seealso>
    let P1171 = Prefixed_Name(isbd, "P1171") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title statement"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1172">http://iflastandards.info/ns/isbd/elements/P1172</seealso>
    let P1172 = Prefixed_Name(isbd, "P1172") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title statement of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1173">http://iflastandards.info/ns/isbd/elements/P1173</seealso>
    let P1173 = Prefixed_Name(isbd, "P1173") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title statement of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1174">http://iflastandards.info/ns/isbd/elements/P1174</seealso>
    let P1174 = Prefixed_Name(isbd, "P1174") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene título paralelo (compuesto) de serie o recurso monográfico multiparte"</para><para>"has parallel title (compound) of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1177">http://iflastandards.info/ns/isbd/elements/P1177</seealso>
    let P1177 = Prefixed_Name(isbd, "P1177") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel common title of series or multipart monographic resource"</para><para>"tiene título común paralelo de serie o recurso monográfico multiparte"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1178">http://iflastandards.info/ns/isbd/elements/P1178</seealso>
    let P1178 = Prefixed_Name(isbd, "P1178") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel dependent title of series or multipart monographic resource"</para><para>"tiene título dependiente paralelo de serie o recurso monográfico multiparte "</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1179">http://iflastandards.info/ns/isbd/elements/P1179</seealso>
    let P1179 = Prefixed_Name(isbd, "P1179") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene designación de título dependiente paralelo de serie o recurso monográfico multiparte"</para><para>"has parallel dependent title designation of series or multipart monographic resource"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1180">http://iflastandards.info/ns/isbd/elements/P1180</seealso>
    let P1180 = Prefixed_Name(isbd, "P1180") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has compound title of parallel title"</para><para>"tiene título compuesto de título paralelo"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1181">http://iflastandards.info/ns/isbd/elements/P1181</seealso>
    let P1181 = Prefixed_Name(isbd, "P1181") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has common title of parallel title"</para><para>"tiene título común de título paralelo"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1182">http://iflastandards.info/ns/isbd/elements/P1182</seealso>
    let P1182 = Prefixed_Name(isbd, "P1182") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dependent title of parallel title"</para><para>"tiene título dependiente de título paralelo"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1183">http://iflastandards.info/ns/isbd/elements/P1183</seealso>
    let P1183 = Prefixed_Name(isbd, "P1183") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"tiene designación de título dependiente de título paralelo"</para><para>"has dependent title designation of parallel title"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1184">http://iflastandards.info/ns/isbd/elements/P1184</seealso>
    let P1184 = Prefixed_Name(isbd, "P1184") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has content form and media type statement"</para><para>"tiene mención de forma del contenido y de tipo de medio"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1185">http://iflastandards.info/ns/isbd/elements/P1185</seealso>
    let P1185 = Prefixed_Name(isbd, "P1185") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title proper (compound) of series"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1186">http://iflastandards.info/ns/isbd/elements/P1186</seealso>
    let P1186 = Prefixed_Name(isbd, "P1186") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has expression aspect"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1190">http://iflastandards.info/ns/isbd/elements/P1190</seealso>
    let P1190 = Prefixed_Name(isbd, "P1190") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has item aspect"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1191">http://iflastandards.info/ns/isbd/elements/P1191</seealso>
    let P1191 = Prefixed_Name(isbd, "P1191") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has manifestation aspect"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1192">http://iflastandards.info/ns/isbd/elements/P1192</seealso>
    let P1192 = Prefixed_Name(isbd, "P1192") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has work aspect"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1193">http://iflastandards.info/ns/isbd/elements/P1193</seealso>
    let P1193 = Prefixed_Name(isbd, "P1193") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is expression reflected in"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1194">http://iflastandards.info/ns/isbd/elements/P1194</seealso>
    let P1194 = Prefixed_Name(isbd, "P1194") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is item reflected in"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1195">http://iflastandards.info/ns/isbd/elements/P1195</seealso>
    let P1195 = Prefixed_Name(isbd, "P1195") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is manifestation reflected in"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1196">http://iflastandards.info/ns/isbd/elements/P1196</seealso>
    let P1196 = Prefixed_Name(isbd, "P1196") |> PrefixedName
    /// <summary>
    ///   <para>isbd:P1197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is work reflected in"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/isbd/elements/P1197">http://iflastandards.info/ns/isbd/elements/P1197</seealso>
    let P1197 = Prefixed_Name(isbd, "P1197") |> PrefixedName

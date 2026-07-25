namespace http.iflastandards.info.ns.fr.frad.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frad =
    let _namespace_iri = Namespace_Iri frad |> NamespaceIRI
    /// <summary>
    ///   <para>frad:C1001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description is modified from: Guidelines for authority records and references / revised by the Working Group on GARE Revision. Second edition.  München : K.G. Saur, 2001.</para>
    /// labels<para>Controlled Access Point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1001">http://iflastandards.info/ns/fr/frad/C1001</seealso>
    let C1001 = Prefixed_Name(frad, "C1001") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Familia</para><para>Family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1002">http://iflastandards.info/ns/fr/frad/C1002</seealso>
    let C1002 = Prefixed_Name(frad, "C1002") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Agencia</para><para>Agency</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1008">http://iflastandards.info/ns/fr/frad/C1008</seealso>
    let C1008 = Prefixed_Name(frad, "C1008") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Identificador</para><para>Identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1009">http://iflastandards.info/ns/fr/frad/C1009</seealso>
    let C1009 = Prefixed_Name(frad, "C1009") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es poseida por (familia)</para><para>is owned by (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2022">http://iflastandards.info/ns/fr/frad/P2022</seealso>
    let P2022 = Prefixed_Name(frad, "P2022") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es producida por (familia)</para><para>is produced by (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2024">http://iflastandards.info/ns/fr/frad/P2024</seealso>
    let P2024 = Prefixed_Name(frad, "P2024") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es productora (familia) de</para><para>is producer (family) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2025">http://iflastandards.info/ns/fr/frad/P2025</seealso>
    let P2025 = Prefixed_Name(frad, "P2025") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es realizadora (familia) de</para><para>is realizer (family) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2027">http://iflastandards.info/ns/fr/frad/P2027</seealso>
    let P2027 = Prefixed_Name(frad, "P2027") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sequential relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2029">http://iflastandards.info/ns/fr/frad/P2029</seealso>
    let P2029 = Prefixed_Name(frad, "P2029") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has accompanying relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2030">http://iflastandards.info/ns/fr/frad/P2030</seealso>
    let P2030 = Prefixed_Name(frad, "P2030") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene relación de característica compartida (obra)</para><para>has shared characteristic (work) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2031">http://iflastandards.info/ns/fr/frad/P2031</seealso>
    let P2031 = Prefixed_Name(frad, "P2031") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene relación de característica compartida (expresión)</para><para>has shared characteristic (expression) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2032">http://iflastandards.info/ns/fr/frad/P2032</seealso>
    let P2032 = Prefixed_Name(frad, "P2032") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene relación de característica compartida (manifestación)</para><para>has shared characteristic (manifestation) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2033">http://iflastandards.info/ns/fr/frad/P2033</seealso>
    let P2033 = Prefixed_Name(frad, "P2033") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene obra descriptiva</para><para>has descriptive work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2035">http://iflastandards.info/ns/fr/frad/P2035</seealso>
    let P2035 = Prefixed_Name(frad, "P2035") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has equivalence (item) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2037">http://iflastandards.info/ns/fr/frad/P2037</seealso>
    let P2037 = Prefixed_Name(frad, "P2037") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3001">http://iflastandards.info/ns/fr/frad/P3001</seealso>
    let P3001 = Prefixed_Name(frad, "P3001") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene campo de actividad (familia)</para><para>has field of activity (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3004">http://iflastandards.info/ns/fr/frad/P3004</seealso>
    let P3004 = Prefixed_Name(frad, "P3004") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has history of family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3005">http://iflastandards.info/ns/fr/frad/P3005</seealso>
    let P3005 = Prefixed_Name(frad, "P3005") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bibliographic Entity</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1010">http://iflastandards.info/ns/fr/frad/C1010</seealso>
    let C1010 = Prefixed_Name(frad, "C1010") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>regula</para><para>govern</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2004">http://iflastandards.info/ns/fr/frad/P2004</seealso>
    let P2004 = Prefixed_Name(frad, "P2004") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is created by</para><para>es creado por</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2005">http://iflastandards.info/ns/fr/frad/P2005</seealso>
    let P2005 = Prefixed_Name(frad, "P2005") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es modificado por</para><para>is modified by</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2007">http://iflastandards.info/ns/fr/frad/P2007</seealso>
    let P2007 = Prefixed_Name(frad, "P2007") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is basis (name) for</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2009">http://iflastandards.info/ns/fr/frad/P2009</seealso>
    let P2009 = Prefixed_Name(frad, "P2009") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is based on (name)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2010">http://iflastandards.info/ns/fr/frad/P2010</seealso>
    let P2010 = Prefixed_Name(frad, "P2010") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>está basado en (identificador)</para><para>is based on (identifier)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2012">http://iflastandards.info/ns/fr/frad/P2012</seealso>
    let P2012 = Prefixed_Name(frad, "P2012") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipo de identificador</para><para>has type of identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3021">http://iflastandards.info/ns/fr/frad/P3021</seealso>
    let P3021 = Prefixed_Name(frad, "P3021") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nombre</para><para>Name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1006">http://iflastandards.info/ns/fr/frad/C1006</seealso>
    let C1006 = Prefixed_Name(frad, "C1006") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description is modified from that in Functional requirements for bibliographic records : final report, by the IFLA Study Group on the Functional Requirements for Bibliographic Records, published by K.G. Saur, 1998.</para>
    /// labels<para>Corporate Body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1003">http://iflastandards.info/ns/fr/frad/C1003</seealso>
    let C1003 = Prefixed_Name(frad, "C1003") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reglas</para><para>Rules</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1007">http://iflastandards.info/ns/fr/frad/C1007</seealso>
    let C1007 = Prefixed_Name(frad, "C1007") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name of a Corporate Body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1011">http://iflastandards.info/ns/fr/frad/C1011</seealso>
    let C1011 = Prefixed_Name(frad, "C1011") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene relación de característica compartida (ejemplar)</para><para>has shared characteristic (item) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2034">http://iflastandards.info/ns/fr/frad/P2034</seealso>
    let P2034 = Prefixed_Name(frad, "P2034") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is descriptive work of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2036">http://iflastandards.info/ns/fr/frad/P2036</seealso>
    let P2036 = Prefixed_Name(frad, "P2036") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dates of family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3002">http://iflastandards.info/ns/fr/frad/P3002</seealso>
    let P3002 = Prefixed_Name(frad, "P3002") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has places associated with family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3003">http://iflastandards.info/ns/fr/frad/P3003</seealso>
    let P3003 = Prefixed_Name(frad, "P3003") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of controlled access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3006">http://iflastandards.info/ns/fr/frad/P3006</seealso>
    let P3006 = Prefixed_Name(frad, "P3006") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has status of controlled access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3007">http://iflastandards.info/ns/fr/frad/P3007</seealso>
    let P3007 = Prefixed_Name(frad, "P3007") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has base access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3017">http://iflastandards.info/ns/fr/frad/P3017</seealso>
    let P3017 = Prefixed_Name(frad, "P3017") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene punto de acceso no diferenciado</para><para>has undifferentiated access point </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3009">http://iflastandards.info/ns/fr/frad/P3009</seealso>
    let P3009 = Prefixed_Name(frad, "P3009") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has corresponding subject term or classification number</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4018">http://iflastandards.info/ns/fr/frad/P4018</seealso>
    let P4018 = Prefixed_Name(frad, "P4018") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has designated usage of controlled access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3008">http://iflastandards.info/ns/fr/frad/P3008</seealso>
    let P3008 = Prefixed_Name(frad, "P3008") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of base access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3010">http://iflastandards.info/ns/fr/frad/P3010</seealso>
    let P3010 = Prefixed_Name(frad, "P3010") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lengua de catalogación</para><para>has language of cataloguing</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3011">http://iflastandards.info/ns/fr/frad/P3011</seealso>
    let P3011 = Prefixed_Name(frad, "P3011") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has script of base access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3012">http://iflastandards.info/ns/fr/frad/P3012</seealso>
    let P3012 = Prefixed_Name(frad, "P3012") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has script of cataloguing</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3013">http://iflastandards.info/ns/fr/frad/P3013</seealso>
    let P3013 = Prefixed_Name(frad, "P3013") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has transliteration scheme of base access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3014">http://iflastandards.info/ns/fr/frad/P3014</seealso>
    let P3014 = Prefixed_Name(frad, "P3014") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has transliteration scheme of cataloguing</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3015">http://iflastandards.info/ns/fr/frad/P3015</seealso>
    let P3015 = Prefixed_Name(frad, "P3015") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has source of controlled access point</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3016">http://iflastandards.info/ns/fr/frad/P3016</seealso>
    let P3016 = Prefixed_Name(frad, "P3016") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Sometimes referred to as a "qualifier".</para>
    /// labels<para>tiene adición</para><para>has addition</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3018">http://iflastandards.info/ns/fr/frad/P3018</seealso>
    let P3018 = Prefixed_Name(frad, "P3018") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipo de nombre</para><para>has type of name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3022">http://iflastandards.info/ns/fr/frad/P3022</seealso>
    let P3022 = Prefixed_Name(frad, "P3022") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene cadena de caracteres</para><para>has name string</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3023">http://iflastandards.info/ns/fr/frad/P3023</seealso>
    let P3023 = Prefixed_Name(frad, "P3023") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene alcance de uso</para><para>has scope of usage</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3024">http://iflastandards.info/ns/fr/frad/P3024</seealso>
    let P3024 = Prefixed_Name(frad, "P3024") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene fechas de uso</para><para>has dates of usage</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3025">http://iflastandards.info/ns/fr/frad/P3025</seealso>
    let P3025 = Prefixed_Name(frad, "P3025") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3026">http://iflastandards.info/ns/fr/frad/P3026</seealso>
    let P3026 = Prefixed_Name(frad, "P3026") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has script of name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3027">http://iflastandards.info/ns/fr/frad/P3027</seealso>
    let P3027 = Prefixed_Name(frad, "P3027") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene esquema de transliteración del nombre</para><para>has transliteration scheme of name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3028">http://iflastandards.info/ns/fr/frad/P3028</seealso>
    let P3028 = Prefixed_Name(frad, "P3028") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene género</para><para>has gender</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3029">http://iflastandards.info/ns/fr/frad/P3029</seealso>
    let P3029 = Prefixed_Name(frad, "P3029") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lugar de nacimiento</para><para>has place of birth</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3030">http://iflastandards.info/ns/fr/frad/P3030</seealso>
    let P3030 = Prefixed_Name(frad, "P3030") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has country</para><para>tiene país</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3032">http://iflastandards.info/ns/fr/frad/P3032</seealso>
    let P3032 = Prefixed_Name(frad, "P3032") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lugar de residencia</para><para>has place of residence</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3033">http://iflastandards.info/ns/fr/frad/P3033</seealso>
    let P3033 = Prefixed_Name(frad, "P3033") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene dirección (persona)</para><para>has address (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3035">http://iflastandards.info/ns/fr/frad/P3035</seealso>
    let P3035 = Prefixed_Name(frad, "P3035") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene campo de actividad (persona)</para><para>has field of activity (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3037">http://iflastandards.info/ns/fr/frad/P3037</seealso>
    let P3037 = Prefixed_Name(frad, "P3037") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene biografía o historia</para><para>has biography or history</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3039">http://iflastandards.info/ns/fr/frad/P3039</seealso>
    let P3039 = Prefixed_Name(frad, "P3039") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene afiliación</para><para>has affiliation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3034">http://iflastandards.info/ns/fr/frad/P3034</seealso>
    let P3034 = Prefixed_Name(frad, "P3034") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3036">http://iflastandards.info/ns/fr/frad/P3036</seealso>
    let P3036 = Prefixed_Name(frad, "P3036") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has profession or occupation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3038">http://iflastandards.info/ns/fr/frad/P3038</seealso>
    let P3038 = Prefixed_Name(frad, "P3038") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lugar de fallecimiento</para><para>has place of death</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3031">http://iflastandards.info/ns/fr/frad/P3031</seealso>
    let P3031 = Prefixed_Name(frad, "P3031") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3040">http://iflastandards.info/ns/fr/frad/P3040</seealso>
    let P3040 = Prefixed_Name(frad, "P3040") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene campo de actividad (entidad corporativa)</para><para>has field of activity (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3042">http://iflastandards.info/ns/fr/frad/P3042</seealso>
    let P3042 = Prefixed_Name(frad, "P3042") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has address (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3041">http://iflastandards.info/ns/fr/frad/P3041</seealso>
    let P3041 = Prefixed_Name(frad, "P3041") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has history (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3043">http://iflastandards.info/ns/fr/frad/P3043</seealso>
    let P3043 = Prefixed_Name(frad, "P3043") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identificador de reglas</para><para>has rules identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3020">http://iflastandards.info/ns/fr/frad/P3020</seealso>
    let P3020 = Prefixed_Name(frad, "P3020") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lugar de origen de la obra</para><para>has place of origin of the work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3045">http://iflastandards.info/ns/fr/frad/P3045</seealso>
    let P3045 = Prefixed_Name(frad, "P3045") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene historia (obra)</para><para>has history (work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3046">http://iflastandards.info/ns/fr/frad/P3046</seealso>
    let P3046 = Prefixed_Name(frad, "P3046") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Scope note not present in original documentation; added to clarify semantic difference with "is part (item)" property (http://iflastandards.info/ns/fr/frbr/frbrer/P2092).</para>
    /// labels<para>has location of item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3047">http://iflastandards.info/ns/fr/frad/P3047</seealso>
    let P3047 = Prefixed_Name(frad, "P3047") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has immediate source of acquisition of item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3049">http://iflastandards.info/ns/fr/frad/P3049</seealso>
    let P3049 = Prefixed_Name(frad, "P3049") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3052">http://iflastandards.info/ns/fr/frad/P3052</seealso>
    let P3052 = Prefixed_Name(frad, "P3052") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has member (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4004">http://iflastandards.info/ns/fr/frad/P4004</seealso>
    let P4004 = Prefixed_Name(frad, "P4004") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is member of (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4005">http://iflastandards.info/ns/fr/frad/P4005</seealso>
    let P4005 = Prefixed_Name(frad, "P4005") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has member (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4006">http://iflastandards.info/ns/fr/frad/P4006</seealso>
    let P4006 = Prefixed_Name(frad, "P4006") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is member of (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4007">http://iflastandards.info/ns/fr/frad/P4007</seealso>
    let P4007 = Prefixed_Name(frad, "P4007") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founder</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4011">http://iflastandards.info/ns/fr/frad/P4011</seealso>
    let P4011 = Prefixed_Name(frad, "P4011") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propietario de</para><para>is owner of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4012">http://iflastandards.info/ns/fr/frad/P4012</seealso>
    let P4012 = Prefixed_Name(frad, "P4012") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene subordinado</para><para>has subordinate</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4014">http://iflastandards.info/ns/fr/frad/P4014</seealso>
    let P4014 = Prefixed_Name(frad, "P4014") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es subordinado de</para><para>is subordinate of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4015">http://iflastandards.info/ns/fr/frad/P4015</seealso>
    let P4015 = Prefixed_Name(frad, "P4015") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is predecessor of</para><para>es predecesora de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4016">http://iflastandards.info/ns/fr/frad/P4016</seealso>
    let P4016 = Prefixed_Name(frad, "P4016") |> PrefixedName
    /// <summary>
    ///   <para>frad:1003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/1003">http://iflastandards.info/ns/fr/frad/1003</seealso>
    let _1003 = Prefixed_Name(frad, "1003") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is successor of</para><para>es sucesora de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4017">http://iflastandards.info/ns/fr/frad/P4017</seealso>
    let P4017 = Prefixed_Name(frad, "P4017") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>modifies</para><para>modifica</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2008">http://iflastandards.info/ns/fr/frad/P2008</seealso>
    let P2008 = Prefixed_Name(frad, "P2008") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma lingüística alternativa (persona)</para><para>has alternative linguistic form (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4034">http://iflastandards.info/ns/fr/frad/P4034</seealso>
    let P4034 = Prefixed_Name(frad, "P4034") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is pseudonymous persona of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4036">http://iflastandards.info/ns/fr/frad/P4036</seealso>
    let P4036 = Prefixed_Name(frad, "P4036") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identidad religiosa</para><para>has religious identity</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4039">http://iflastandards.info/ns/fr/frad/P4039</seealso>
    let P4039 = Prefixed_Name(frad, "P4039") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identidad oficial</para><para>has official identity</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4041">http://iflastandards.info/ns/fr/frad/P4041</seealso>
    let P4041 = Prefixed_Name(frad, "P4041") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has works attributed to</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4043">http://iflastandards.info/ns/fr/frad/P4043</seealso>
    let P4043 = Prefixed_Name(frad, "P4043") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene relación colaborativa con</para><para>has collaborative relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4045">http://iflastandards.info/ns/fr/frad/P4045</seealso>
    let P4045 = Prefixed_Name(frad, "P4045") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sibling</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4047">http://iflastandards.info/ns/fr/frad/P4047</seealso>
    let P4047 = Prefixed_Name(frad, "P4047") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has equivalence (manifestation) relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2019">http://iflastandards.info/ns/fr/frad/P2019</seealso>
    let P2019 = Prefixed_Name(frad, "P2019") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is associated with</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2028">http://iflastandards.info/ns/fr/frad/P2028</seealso>
    let P2028 = Prefixed_Name(frad, "P2028") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name of a Family</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1013">http://iflastandards.info/ns/fr/frad/C1013</seealso>
    let C1013 = Prefixed_Name(frad, "C1013") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has custodial history of item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3048">http://iflastandards.info/ns/fr/frad/P3048</seealso>
    let P3048 = Prefixed_Name(frad, "P3048") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene designación numérica</para><para>has numeric designation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3051">http://iflastandards.info/ns/fr/frad/P3051</seealso>
    let P3051 = Prefixed_Name(frad, "P3051") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel language form</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4001">http://iflastandards.info/ns/fr/frad/P4001</seealso>
    let P4001 = Prefixed_Name(frad, "P4001") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has different rules form</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4003">http://iflastandards.info/ns/fr/frad/P4003</seealso>
    let P4003 = Prefixed_Name(frad, "P4003") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternate script form</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4002">http://iflastandards.info/ns/fr/frad/P4002</seealso>
    let P4002 = Prefixed_Name(frad, "P4002") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>applies</para><para>aplica</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2002">http://iflastandards.info/ns/fr/frad/P2002</seealso>
    let P2002 = Prefixed_Name(frad, "P2002") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject of the work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3050">http://iflastandards.info/ns/fr/frad/P3050</seealso>
    let P3050 = Prefixed_Name(frad, "P3050") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>creates</para><para>crea</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2006">http://iflastandards.info/ns/fr/frad/P2006</seealso>
    let P2006 = Prefixed_Name(frad, "P2006") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre extenso</para><para>has expanded name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4026">http://iflastandards.info/ns/fr/frad/P4026</seealso>
    let P4026 = Prefixed_Name(frad, "P4026") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other variant name (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4032">http://iflastandards.info/ns/fr/frad/P4032</seealso>
    let P4032 = Prefixed_Name(frad, "P4032") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma lingüística alternativa (obra)</para><para>has alternative linguistic form (work) </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4028">http://iflastandards.info/ns/fr/frad/P4028</seealso>
    let P4028 = Prefixed_Name(frad, "P4028") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es nombre convencional de</para><para>is conventional name of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4030">http://iflastandards.info/ns/fr/frad/P4030</seealso>
    let P4030 = Prefixed_Name(frad, "P4030") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other variant name (work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4033">http://iflastandards.info/ns/fr/frad/P4033</seealso>
    let P4033 = Prefixed_Name(frad, "P4033") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has pseudonymous persona</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4035">http://iflastandards.info/ns/fr/frad/P4035</seealso>
    let P4035 = Prefixed_Name(frad, "P4035") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identidad secular</para><para>has secular identity</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4037">http://iflastandards.info/ns/fr/frad/P4037</seealso>
    let P4037 = Prefixed_Name(frad, "P4037") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is religious identity of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4040">http://iflastandards.info/ns/fr/frad/P4040</seealso>
    let P4040 = Prefixed_Name(frad, "P4040") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is secular identity of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4038">http://iflastandards.info/ns/fr/frad/P4038</seealso>
    let P4038 = Prefixed_Name(frad, "P4038") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is official identity of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4042">http://iflastandards.info/ns/fr/frad/P4042</seealso>
    let P4042 = Prefixed_Name(frad, "P4042") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has attributed works from</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4044">http://iflastandards.info/ns/fr/frad/P4044</seealso>
    let P4044 = Prefixed_Name(frad, "P4044") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (familia)</para><para>has as subject (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4046">http://iflastandards.info/ns/fr/frad/P4046</seealso>
    let P4046 = Prefixed_Name(frad, "P4046") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parent</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4048">http://iflastandards.info/ns/fr/frad/P4048</seealso>
    let P4048 = Prefixed_Name(frad, "P4048") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has child</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4049">http://iflastandards.info/ns/fr/frad/P4049</seealso>
    let P4049 = Prefixed_Name(frad, "P4049") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is basis (identifier) for</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2011">http://iflastandards.info/ns/fr/frad/P2011</seealso>
    let P2011 = Prefixed_Name(frad, "P2011") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2013">http://iflastandards.info/ns/fr/frad/P2013</seealso>
    let P2013 = Prefixed_Name(frad, "P2013") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellation of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2014">http://iflastandards.info/ns/fr/frad/P2014</seealso>
    let P2014 = Prefixed_Name(frad, "P2014") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is assigned to</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2016">http://iflastandards.info/ns/fr/frad/P2016</seealso>
    let P2016 = Prefixed_Name(frad, "P2016") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is assigned</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2015">http://iflastandards.info/ns/fr/frad/P2015</seealso>
    let P2015 = Prefixed_Name(frad, "P2015") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has derivative</para><para>tiene derivada</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2017">http://iflastandards.info/ns/fr/frad/P2017</seealso>
    let P2017 = Prefixed_Name(frad, "P2017") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es derivativa de</para><para>is derivative of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2018">http://iflastandards.info/ns/fr/frad/P2018</seealso>
    let P2018 = Prefixed_Name(frad, "P2018") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creada por (familia)</para><para>is created by (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2020">http://iflastandards.info/ns/fr/frad/P2020</seealso>
    let P2020 = Prefixed_Name(frad, "P2020") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creadora (familia) de</para><para>is creator (family) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2021">http://iflastandards.info/ns/fr/frad/P2021</seealso>
    let P2021 = Prefixed_Name(frad, "P2021") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propietaria (familia) de</para><para>is owner (family) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2023">http://iflastandards.info/ns/fr/frad/P2023</seealso>
    let P2023 = Prefixed_Name(frad, "P2023") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es realizada por (familia)</para><para>is realized by (family)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2026">http://iflastandards.info/ns/fr/frad/P2026</seealso>
    let P2026 = Prefixed_Name(frad, "P2026") |> PrefixedName
    /// <summary>
    ///   <para>frad:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/">http://iflastandards.info/ns/fr/frad/</seealso>
    let _prefix_iri = Prefixed_Name(frad, "") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name of a Person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1012">http://iflastandards.info/ns/fr/frad/C1012</seealso>
    let C1012 = Prefixed_Name(frad, "C1012") |> PrefixedName
    /// <summary>
    ///   <para>frad:C1014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name of a Work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/C1014">http://iflastandards.info/ns/fr/frad/C1014</seealso>
    let C1014 = Prefixed_Name(frad, "C1014") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>son aplicadas por</para><para>are applied by</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2001">http://iflastandards.info/ns/fr/frad/P2001</seealso>
    let P2001 = Prefixed_Name(frad, "P2001") |> PrefixedName
    /// <summary>
    ///   <para>frad:P3019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has citation for rules</para><para>tiene cita de reglas</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P3019">http://iflastandards.info/ns/fr/frad/P3019</seealso>
    let P3019 = Prefixed_Name(frad, "P3019") |> PrefixedName
    /// <summary>
    ///   <para>frad:P2003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es regulado por</para><para>is governed by</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P2003">http://iflastandards.info/ns/fr/frad/P2003</seealso>
    let P2003 = Prefixed_Name(frad, "P2003") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has (descendent) genealogical relationship </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4008">http://iflastandards.info/ns/fr/frad/P4008</seealso>
    let P4008 = Prefixed_Name(frad, "P4008") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has (predecessor) genealogical relationship</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4009">http://iflastandards.info/ns/fr/frad/P4009</seealso>
    let P4009 = Prefixed_Name(frad, "P4009") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es fundador de</para><para>is founder of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4010">http://iflastandards.info/ns/fr/frad/P4010</seealso>
    let P4010 = Prefixed_Name(frad, "P4010") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene propietario</para><para>has owner</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4013">http://iflastandards.info/ns/fr/frad/P4013</seealso>
    let P4013 = Prefixed_Name(frad, "P4013") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identificador relacionado</para><para>has related identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4019">http://iflastandards.info/ns/fr/frad/P4019</seealso>
    let P4019 = Prefixed_Name(frad, "P4019") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre anterior</para><para>has earlier name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4021">http://iflastandards.info/ns/fr/frad/P4021</seealso>
    let P4021 = Prefixed_Name(frad, "P4021") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre posterior</para><para>has later name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4022">http://iflastandards.info/ns/fr/frad/P4022</seealso>
    let P4022 = Prefixed_Name(frad, "P4022") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma lingüística alternativa (familia)</para><para>has alternative linguistic form (family) </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4024">http://iflastandards.info/ns/fr/frad/P4024</seealso>
    let P4024 = Prefixed_Name(frad, "P4024") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma lingüística alternativa (entidad corporativa)</para><para>has alternative linguistic form (corporate body) </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4025">http://iflastandards.info/ns/fr/frad/P4025</seealso>
    let P4025 = Prefixed_Name(frad, "P4025") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene acrónimo o iniciales o abreviaturas</para><para>has acronym or initials or abbreviation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4027">http://iflastandards.info/ns/fr/frad/P4027</seealso>
    let P4027 = Prefixed_Name(frad, "P4027") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre convencional</para><para>has conventional name</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4029">http://iflastandards.info/ns/fr/frad/P4029</seealso>
    let P4029 = Prefixed_Name(frad, "P4029") |> PrefixedName
    /// <summary>
    ///   <para>frad:P4031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other variant name (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frad/P4031">http://iflastandards.info/ns/fr/frad/P4031</seealso>
    let P4031 = Prefixed_Name(frad, "P4031") |> PrefixedName

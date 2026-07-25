namespace http.iflastandards.info.ns.fr.frbr.frbrer.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frbrer =
    let _namespace_iri = Namespace_Iri frbrer |> NamespaceIRI
    /// <summary>
    ///   <para>frbrer:C1001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Work</para><para>Obra</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1001">http://iflastandards.info/ns/fr/frbr/frbrer/C1001</seealso>
    let C1001 = Prefixed_Name(frbrer, "C1001") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Expression</para><para>ExpresiÃ³n</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1002">http://iflastandards.info/ns/fr/frbr/frbrer/C1002</seealso>
    let C1002 = Prefixed_Name(frbrer, "C1002") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entidad corporativa</para><para>Corporate Body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1006">http://iflastandards.info/ns/fr/frbr/frbrer/C1006</seealso>
    let C1006 = Prefixed_Name(frbrer, "C1006") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es productor (persona) de</para><para>is producer (person) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2018">http://iflastandards.info/ns/fr/frbr/frbrer/P2018</seealso>
    let P2018 = Prefixed_Name(frbrer, "P2018") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an abridgement (expression) of</para><para>es compendio (expresiÃ³n) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2060">http://iflastandards.info/ns/fr/frbr/frbrer/P2060</seealso>
    let P2060 = Prefixed_Name(frbrer, "P2060") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a translation (expression)</para><para>tiene traducciÃ³n (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2063">http://iflastandards.info/ns/fr/frbr/frbrer/P2063</seealso>
    let P2063 = Prefixed_Name(frbrer, "P2063") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es complemento (obra) de (expresiÃ³n)</para><para>complements (work) (from expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2100">http://iflastandards.info/ns/fr/frbr/frbrer/P2100</seealso>
    let P2100 = Prefixed_Name(frbrer, "P2100") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©cnica de presentaciÃ³n (imagen cartogrÃ¡fica u objeto)</para><para>has presentation technique (cartographic image or object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3099">http://iflastandards.info/ns/fr/frbr/frbrer/P3099</seealso>
    let P3099 = Prefixed_Name(frbrer, "P3099") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ManifestaciÃ³n</para><para>Manifestation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1003">http://iflastandards.info/ns/fr/frbr/frbrer/C1003</seealso>
    let C1003 = Prefixed_Name(frbrer, "C1003") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Concepto</para><para>Concept</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1007">http://iflastandards.info/ns/fr/frbr/frbrer/C1007</seealso>
    let C1007 = Prefixed_Name(frbrer, "C1007") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Acontecimiento</para><para>Event</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1009">http://iflastandards.info/ns/fr/frbr/frbrer/C1009</seealso>
    let C1009 = Prefixed_Name(frbrer, "C1009") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipo de audencia</para><para>has intended audience</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3006">http://iflastandards.info/ns/fr/frbr/frbrer/P3006</seealso>
    let P3006 = Prefixed_Name(frbrer, "P3006") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has label "Other Distinguishing Characteristic", used also for an Expression attribute.</para>
    /// labels<para>tiene otras caracterÃ­siticas distintivas de obra</para><para>has other distinguishing characteristic of work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3004">http://iflastandards.info/ns/fr/frbr/frbrer/P3004</seealso>
    let P3004 = Prefixed_Name(frbrer, "P3004") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma de la obra</para><para>has form of work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3002">http://iflastandards.info/ns/fr/frbr/frbrer/P3002</seealso>
    let P3002 = Prefixed_Name(frbrer, "P3002") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene contexto de la obra</para><para>has context for the work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3007">http://iflastandards.info/ns/fr/frbr/frbrer/P3007</seealso>
    let P3007 = Prefixed_Name(frbrer, "P3007") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materializaciÃ³n de</para><para>is embodiment of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2004">http://iflastandards.info/ns/fr/frbr/frbrer/P2004</seealso>
    let P2004 = Prefixed_Name(frbrer, "P2004") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creador (entidad corporativa) de</para><para>is creator (corporate body) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2008">http://iflastandards.info/ns/fr/frbr/frbrer/P2008</seealso>
    let P2008 = Prefixed_Name(frbrer, "P2008") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creador (persona) de</para><para>is creator (person) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2010">http://iflastandards.info/ns/fr/frbr/frbrer/P2010</seealso>
    let P2010 = Prefixed_Name(frbrer, "P2010") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>estÃ¡ realizado por (entidad corporativa)</para><para>is realized by (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2011">http://iflastandards.info/ns/fr/frbr/frbrer/P2011</seealso>
    let P2011 = Prefixed_Name(frbrer, "P2011") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>estÃ¡ realizado por (persona)</para><para>is realized by (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2013">http://iflastandards.info/ns/fr/frbr/frbrer/P2013</seealso>
    let P2013 = Prefixed_Name(frbrer, "P2013") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es realizador (persona) de</para><para>is realizer (person) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2014">http://iflastandards.info/ns/fr/frbr/frbrer/P2014</seealso>
    let P2014 = Prefixed_Name(frbrer, "P2014") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es producido por (entidad corporativa)</para><para>is produced by (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2015">http://iflastandards.info/ns/fr/frbr/frbrer/P2015</seealso>
    let P2015 = Prefixed_Name(frbrer, "P2015") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an abridgement (expression)</para><para>tiene compendio (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2059">http://iflastandards.info/ns/fr/frbr/frbrer/P2059</seealso>
    let P2059 = Prefixed_Name(frbrer, "P2059") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene revisiÃ³n (expresiÃ³n)</para><para>has a revision (expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2061">http://iflastandards.info/ns/fr/frbr/frbrer/P2061</seealso>
    let P2061 = Prefixed_Name(frbrer, "P2061") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a revision (expression) of</para><para>es revisiÃ³n (expresiÃ³n) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2062">http://iflastandards.info/ns/fr/frbr/frbrer/P2062</seealso>
    let P2062 = Prefixed_Name(frbrer, "P2062") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an arrangement (expression)</para><para>tiene arreglo (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2065">http://iflastandards.info/ns/fr/frbr/frbrer/P2065</seealso>
    let P2065 = Prefixed_Name(frbrer, "P2065") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a successor (expression) (from expression)</para><para>continuado por (expresiÃ³n) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2067">http://iflastandards.info/ns/fr/frbr/frbrer/P2067</seealso>
    let P2067 = Prefixed_Name(frbrer, "P2067") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es complemento (expresiÃ³n) de (expresiÃ³n)</para><para>complements (expression) (from expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2070">http://iflastandards.info/ns/fr/frbr/frbrer/P2070</seealso>
    let P2070 = Prefixed_Name(frbrer, "P2070") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a summary (expression) of (expression)</para><para>es resumen (expresiÃ³n) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2072">http://iflastandards.info/ns/fr/frbr/frbrer/P2072</seealso>
    let P2072 = Prefixed_Name(frbrer, "P2072") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an adaptation (expression) (from expression)</para><para>tiene adaptaciÃ³n (expresiÃ³n) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2073">http://iflastandards.info/ns/fr/frbr/frbrer/P2073</seealso>
    let P2073 = Prefixed_Name(frbrer, "P2073") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an adaptation (expression) of (expression)</para><para>es adaptaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2074">http://iflastandards.info/ns/fr/frbr/frbrer/P2074</seealso>
    let P2074 = Prefixed_Name(frbrer, "P2074") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identificador del ejemplar</para><para>has item identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3031">http://iflastandards.info/ns/fr/frbr/frbrer/P3031</seealso>
    let P3031 = Prefixed_Name(frbrer, "P3031") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene huella tipogrÃ¡fica</para><para>has fingerprint</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3032">http://iflastandards.info/ns/fr/frbr/frbrer/P3032</seealso>
    let P3032 = Prefixed_Name(frbrer, "P3032") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has condition of the item</para><para>tiene estado del ejemplar</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3035">http://iflastandards.info/ns/fr/frbr/frbrer/P3035</seealso>
    let P3035 = Prefixed_Name(frbrer, "P3035") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene historial de tratamientos</para><para>has treatment history</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3036">http://iflastandards.info/ns/fr/frbr/frbrer/P3036</seealso>
    let P3036 = Prefixed_Name(frbrer, "P3036") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tratamiento programado</para><para>has scheduled treatment</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3037">http://iflastandards.info/ns/fr/frbr/frbrer/P3037</seealso>
    let P3037 = Prefixed_Name(frbrer, "P3037") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre de persona</para><para>has name of person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3039">http://iflastandards.info/ns/fr/frbr/frbrer/P3039</seealso>
    let P3039 = Prefixed_Name(frbrer, "P3039") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "includes" prefixing the definition, interpreted as "and other dates" in the property description.</para>
    /// labels<para>tiene fechas de persona</para><para>has dates of person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3040">http://iflastandards.info/ns/fr/frbr/frbrer/P3040</seealso>
    let P3040 = Prefixed_Name(frbrer, "P3040") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene calificativo de persona</para><para>has title of person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3041">http://iflastandards.info/ns/fr/frbr/frbrer/P3041</seealso>
    let P3041 = Prefixed_Name(frbrer, "P3041") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene otras designaciones asociadas con la persona</para><para>has other designation associated with the person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3042">http://iflastandards.info/ns/fr/frbr/frbrer/P3042</seealso>
    let P3042 = Prefixed_Name(frbrer, "P3042") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nombre de entidad corporativa</para><para>has name of the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3043">http://iflastandards.info/ns/fr/frbr/frbrer/P3043</seealso>
    let P3043 = Prefixed_Name(frbrer, "P3043") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene nÃºmero asociado a la entidad corporativa</para><para>has number associated with the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3044">http://iflastandards.info/ns/fr/frbr/frbrer/P3044</seealso>
    let P3044 = Prefixed_Name(frbrer, "P3044") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lugar asociado a la entidad corporativa</para><para>has place associated with the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3045">http://iflastandards.info/ns/fr/frbr/frbrer/P3045</seealso>
    let P3045 = Prefixed_Name(frbrer, "P3045") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene fecha asociada a la entidad corporativa</para><para>has date associated with the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3046">http://iflastandards.info/ns/fr/frbr/frbrer/P3046</seealso>
    let P3046 = Prefixed_Name(frbrer, "P3046") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene otra designaciÃ³n asociada a la entidad corporativa</para><para>has other designation associated with the corporate body</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3047">http://iflastandards.info/ns/fr/frbr/frbrer/P3047</seealso>
    let P3047 = Prefixed_Name(frbrer, "P3047") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©rmino del objeto</para><para>has term for the object</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3049">http://iflastandards.info/ns/fr/frbr/frbrer/P3049</seealso>
    let P3049 = Prefixed_Name(frbrer, "P3049") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©rmino del acontecimiento</para><para>has term for the event</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3050">http://iflastandards.info/ns/fr/frbr/frbrer/P3050</seealso>
    let P3050 = Prefixed_Name(frbrer, "P3050") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©rmino del lugar</para><para>has term for the place</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3051">http://iflastandards.info/ns/fr/frbr/frbrer/P3051</seealso>
    let P3051 = Prefixed_Name(frbrer, "P3051") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "acquisition/access"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>tiene fuente de adquisiciÃ³n o autorizaciÃ³n para el acceso</para><para>has source for acquisition or access authorization</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3053">http://iflastandards.info/ns/fr/frbr/frbrer/P3053</seealso>
    let P3053 = Prefixed_Name(frbrer, "P3053") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "fabricator/manufacturer"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>has fabricator or manufacturer</para><para>tiene fabricante o productor</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3054">http://iflastandards.info/ns/fr/frbr/frbrer/P3054</seealso>
    let P3054 = Prefixed_Name(frbrer, "P3054") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "publication/distribution"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>tiene fecha de publicaciÃ³n o distribuciÃ³n</para><para>has date of publication or distribution</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3055">http://iflastandards.info/ns/fr/frbr/frbrer/P3055</seealso>
    let P3055 = Prefixed_Name(frbrer, "P3055") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "publication/distribution"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>tiene lugar de publicaciÃ³n o distribuciÃ³n</para><para>has place of publication or distribution</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3057">http://iflastandards.info/ns/fr/frbr/frbrer/P3057</seealso>
    let P3057 = Prefixed_Name(frbrer, "P3057") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "edition/issue"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>tiene designaciÃ³n de ediciÃ³n o emisiÃ³n</para><para>has edition or issue designation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3058">http://iflastandards.info/ns/fr/frbr/frbrer/P3058</seealso>
    let P3058 = Prefixed_Name(frbrer, "P3058") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene medio de interpretaciÃ³n (obra musical)</para><para>has medium of performance (musical work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3059">http://iflastandards.info/ns/fr/frbr/frbrer/P3059</seealso>
    let P3059 = Prefixed_Name(frbrer, "P3059") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene designaciÃ³n numÃ©rica (obra musical)</para><para>has numeric designation (musical work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3060">http://iflastandards.info/ns/fr/frbr/frbrer/P3060</seealso>
    let P3060 = Prefixed_Name(frbrer, "P3060") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene clave (obra musical)</para><para>has key (musical work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3061">http://iflastandards.info/ns/fr/frbr/frbrer/P3061</seealso>
    let P3061 = Prefixed_Name(frbrer, "P3061") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "include" prefixing the definition, removed for being redundant with respect to "and other characteristics" in the property description.</para>
    /// labels<para>tiene caracterÃ­sticas del archivo (recurso electrÃ³nico)</para><para>has file characteristics (electronic resource)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3094">http://iflastandards.info/ns/fr/frbr/frbrer/P3094</seealso>
    let P3094 = Prefixed_Name(frbrer, "P3094") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene modo de acceso (recurso electrÃ³nico de acceso remoto)</para><para>has mode of access (remote electronic resource)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3095">http://iflastandards.info/ns/fr/frbr/frbrer/P3095</seealso>
    let P3095 = Prefixed_Name(frbrer, "P3095") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene direcciÃ³n de acceso (recurso electrÃ³nico de acceso remoto)</para><para>has access address (remote electronic resource)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3096">http://iflastandards.info/ns/fr/frbr/frbrer/P3096</seealso>
    let P3096 = Prefixed_Name(frbrer, "P3096") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene escala (imagen cartogrÃ¡fica u objeto)</para><para>has scale (cartographic image or object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3097">http://iflastandards.info/ns/fr/frbr/frbrer/P3097</seealso>
    let P3097 = Prefixed_Name(frbrer, "P3097") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene proyecciÃ³n (imagen cartogrÃ¡fica u objeto)</para><para>has projection (cartographic image or object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3098">http://iflastandards.info/ns/fr/frbr/frbrer/P3098</seealso>
    let P3098 = Prefixed_Name(frbrer, "P3098") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene representaciÃ³n de relieve (imagen cartogrÃ¡fica u objeto)</para><para>has representation of relief (cartographic image or object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3100">http://iflastandards.info/ns/fr/frbr/frbrer/P3100</seealso>
    let P3100 = Prefixed_Name(frbrer, "P3100") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "includes" prefixing the definition, interpreted as "and other geodetic, grid and vertical measurements" in the property description.</para>
    /// labels<para>tiene geodÃ©sic, cuadrÃ­cula y medida vertical (imagen cartogrÃ¡fica u objeto)</para><para>has geodetic, grid and vertical measurement (cartographic image or object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3101">http://iflastandards.info/ns/fr/frbr/frbrer/P3101</seealso>
    let P3101 = Prefixed_Name(frbrer, "P3101") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene fecha de la obra</para><para>has date of the work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3003">http://iflastandards.info/ns/fr/frbr/frbrer/P3003</seealso>
    let P3003 = Prefixed_Name(frbrer, "P3003") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es realizador (entidad corporativa) de</para><para>is realizer (corporate body) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2012">http://iflastandards.info/ns/fr/frbr/frbrer/P2012</seealso>
    let P2012 = Prefixed_Name(frbrer, "P2012") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es productor (entidad corporativa) de</para><para>is producer (corporate body) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2016">http://iflastandards.info/ns/fr/frbr/frbrer/P2016</seealso>
    let P2016 = Prefixed_Name(frbrer, "P2016") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es producido por (persona)</para><para>is produced by (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2017">http://iflastandards.info/ns/fr/frbr/frbrer/P2017</seealso>
    let P2017 = Prefixed_Name(frbrer, "P2017") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propiedad de (entidad corporativa)</para><para>is owned by (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2019">http://iflastandards.info/ns/fr/frbr/frbrer/P2019</seealso>
    let P2019 = Prefixed_Name(frbrer, "P2019") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propietario (entidad corporativa) de</para><para>is owner (corporate body) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2020">http://iflastandards.info/ns/fr/frbr/frbrer/P2020</seealso>
    let P2020 = Prefixed_Name(frbrer, "P2020") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (concepto)</para><para>has as subject (concept)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2023">http://iflastandards.info/ns/fr/frbr/frbrer/P2023</seealso>
    let P2023 = Prefixed_Name(frbrer, "P2023") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (concepto) de</para><para>is subject (concept) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2024">http://iflastandards.info/ns/fr/frbr/frbrer/P2024</seealso>
    let P2024 = Prefixed_Name(frbrer, "P2024") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (objeto) de</para><para>is subject (object) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2026">http://iflastandards.info/ns/fr/frbr/frbrer/P2026</seealso>
    let P2026 = Prefixed_Name(frbrer, "P2026") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (acontecimiento)</para><para>has as subject (event)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2027">http://iflastandards.info/ns/fr/frbr/frbrer/P2027</seealso>
    let P2027 = Prefixed_Name(frbrer, "P2027") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (acontecimiento) de</para><para>is subject (event) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2028">http://iflastandards.info/ns/fr/frbr/frbrer/P2028</seealso>
    let P2028 = Prefixed_Name(frbrer, "P2028") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject (place) of</para><para>es materia (lugar) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2030">http://iflastandards.info/ns/fr/frbr/frbrer/P2030</seealso>
    let P2030 = Prefixed_Name(frbrer, "P2030") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (entidad corporativa) de</para><para>is subject (corporate body) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2032">http://iflastandards.info/ns/fr/frbr/frbrer/P2032</seealso>
    let P2032 = Prefixed_Name(frbrer, "P2032") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (obra)</para><para>has as subject (work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2035">http://iflastandards.info/ns/fr/frbr/frbrer/P2035</seealso>
    let P2035 = Prefixed_Name(frbrer, "P2035") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a summary (work) (from work)</para><para>tiene resumen (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2049">http://iflastandards.info/ns/fr/frbr/frbrer/P2049</seealso>
    let P2049 = Prefixed_Name(frbrer, "P2049") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a supplement (work) (from work)</para><para>tiene suplemento (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2045">http://iflastandards.info/ns/fr/frbr/frbrer/P2045</seealso>
    let P2045 = Prefixed_Name(frbrer, "P2045") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>supplements (expression) (from work)</para><para>es suplemento (expresiÃ³n) de (obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2098">http://iflastandards.info/ns/fr/frbr/frbrer/P2098</seealso>
    let P2098 = Prefixed_Name(frbrer, "P2098") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como parte (obra)</para><para>has part (work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2057">http://iflastandards.info/ns/fr/frbr/frbrer/P2057</seealso>
    let P2057 = Prefixed_Name(frbrer, "P2057") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a successor (work) (from work)</para><para>continuado por (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2043">http://iflastandards.info/ns/fr/frbr/frbrer/P2043</seealso>
    let P2043 = Prefixed_Name(frbrer, "P2043") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es suplemento (obra) de (obra)</para><para>supplements (work) (from work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2046">http://iflastandards.info/ns/fr/frbr/frbrer/P2046</seealso>
    let P2046 = Prefixed_Name(frbrer, "P2046") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject (expression) of</para><para>es materia (expresiÃ³n) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2038">http://iflastandards.info/ns/fr/frbr/frbrer/P2038</seealso>
    let P2038 = Prefixed_Name(frbrer, "P2038") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (ejemplar)</para><para>has as subject (item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2041">http://iflastandards.info/ns/fr/frbr/frbrer/P2041</seealso>
    let P2041 = Prefixed_Name(frbrer, "P2041") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es complemento (obra) (de obra)</para><para>complements (work) (from work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2048">http://iflastandards.info/ns/fr/frbr/frbrer/P2048</seealso>
    let P2048 = Prefixed_Name(frbrer, "P2048") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has label "has adaptation"; amended to improve consistency.</para>
    /// labels<para>has an adaptation (work) (from work)</para><para>tiene adaptaciÃ³n (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2051">http://iflastandards.info/ns/fr/frbr/frbrer/P2051</seealso>
    let P2051 = Prefixed_Name(frbrer, "P2051") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an imitation (work) (from work)</para><para>tiene imitaciÃ³n (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2055">http://iflastandards.info/ns/fr/frbr/frbrer/P2055</seealso>
    let P2055 = Prefixed_Name(frbrer, "P2055") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an imitation (work) of (work)</para><para>es imitaciÃ³n (obra) de (obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2056">http://iflastandards.info/ns/fr/frbr/frbrer/P2056</seealso>
    let P2056 = Prefixed_Name(frbrer, "P2056") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an imitation (expression) of (expression)</para><para>es imitaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2078">http://iflastandards.info/ns/fr/frbr/frbrer/P2078</seealso>
    let P2078 = Prefixed_Name(frbrer, "P2078") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como parte (expresiÃ³n)</para><para>has part (expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2079">http://iflastandards.info/ns/fr/frbr/frbrer/P2079</seealso>
    let P2079 = Prefixed_Name(frbrer, "P2079") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>forma parte (expresiÃ³n) de</para><para>is part (expression) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2080">http://iflastandards.info/ns/fr/frbr/frbrer/P2080</seealso>
    let P2080 = Prefixed_Name(frbrer, "P2080") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es reproducciÃ³n (manifestaciÃ³n) de (manifestaciÃ³n)</para><para>is a reproduction (manifestation) of (manifestation)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2082">http://iflastandards.info/ns/fr/frbr/frbrer/P2082</seealso>
    let P2082 = Prefixed_Name(frbrer, "P2082") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene (manifestaciÃ³n) alterna</para><para>has an alternate</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2083">http://iflastandards.info/ns/fr/frbr/frbrer/P2083</seealso>
    let P2083 = Prefixed_Name(frbrer, "P2083") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como parte (manifestaciÃ³n)</para><para>has part (manifestation)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2085">http://iflastandards.info/ns/fr/frbr/frbrer/P2085</seealso>
    let P2085 = Prefixed_Name(frbrer, "P2085") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has label "has reconfiguration", amended to improve consistency.</para>
    /// labels<para>tiene reconfiguraciÃ³n</para><para>has a reconfiguration</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2087">http://iflastandards.info/ns/fr/frbr/frbrer/P2087</seealso>
    let P2087 = Prefixed_Name(frbrer, "P2087") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a reconfiguration of</para><para>es reconfiguraciÃ³n de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2088">http://iflastandards.info/ns/fr/frbr/frbrer/P2088</seealso>
    let P2088 = Prefixed_Name(frbrer, "P2088") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has label "has reproduction"; amended to improve consistency.</para>
    /// labels<para>tiene reproducciÃ³n (ejemplar) (de ejemplar)</para><para>has a reproduction (item) (from item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2089">http://iflastandards.info/ns/fr/frbr/frbrer/P2089</seealso>
    let P2089 = Prefixed_Name(frbrer, "P2089") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es reproducciÃ³n (ejemplar) de (ejemplar)</para><para>is a reproduction (item) of (item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2090">http://iflastandards.info/ns/fr/frbr/frbrer/P2090</seealso>
    let P2090 = Prefixed_Name(frbrer, "P2090") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como parte (ejemplar)</para><para>has part (item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2091">http://iflastandards.info/ns/fr/frbr/frbrer/P2091</seealso>
    let P2091 = Prefixed_Name(frbrer, "P2091") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>forma parte (ejemplar) de</para><para>is part (item) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2092">http://iflastandards.info/ns/fr/frbr/frbrer/P2092</seealso>
    let P2092 = Prefixed_Name(frbrer, "P2092") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene reproducciÃ³n (manifestaciÃ³n) (de ejemplar)</para><para>has a reproduction (manifestation) (from item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2093">http://iflastandards.info/ns/fr/frbr/frbrer/P2093</seealso>
    let P2093 = Prefixed_Name(frbrer, "P2093") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es reproducciÃ³n (manifestaciÃ³n) de (ejemplar)</para><para>is a reproduction (manifestation) of (item)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2094">http://iflastandards.info/ns/fr/frbr/frbrer/P2094</seealso>
    let P2094 = Prefixed_Name(frbrer, "P2094") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a supplement (work) (from expression)</para><para>tiene suplemento (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2097">http://iflastandards.info/ns/fr/frbr/frbrer/P2097</seealso>
    let P2097 = Prefixed_Name(frbrer, "P2097") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a complement (work) (from expression)</para><para>tiene complemento (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2099">http://iflastandards.info/ns/fr/frbr/frbrer/P2099</seealso>
    let P2099 = Prefixed_Name(frbrer, "P2099") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a summary (work) (from expression)</para><para>tiene resumen (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2101">http://iflastandards.info/ns/fr/frbr/frbrer/P2101</seealso>
    let P2101 = Prefixed_Name(frbrer, "P2101") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a summary (work) of (expression)</para><para>es resumen (obra) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2102">http://iflastandards.info/ns/fr/frbr/frbrer/P2102</seealso>
    let P2102 = Prefixed_Name(frbrer, "P2102") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an adaptation (work) (from expression)</para><para>tiene adaptaciÃ³n (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2103">http://iflastandards.info/ns/fr/frbr/frbrer/P2103</seealso>
    let P2103 = Prefixed_Name(frbrer, "P2103") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an adaptation (work) of (expression)</para><para>es adaptaciÃ³n (obra) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2104">http://iflastandards.info/ns/fr/frbr/frbrer/P2104</seealso>
    let P2104 = Prefixed_Name(frbrer, "P2104") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2105</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>has a transformation (work) (from expression)</para><para>tiene transformaciÃ³n (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2105">http://iflastandards.info/ns/fr/frbr/frbrer/P2105</seealso>
    let P2105 = Prefixed_Name(frbrer, "P2105") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>is a transformation (work) of (expression)</para><para>es transformaciÃ³n (obra) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2106">http://iflastandards.info/ns/fr/frbr/frbrer/P2106</seealso>
    let P2106 = Prefixed_Name(frbrer, "P2106") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an imitation (work) of (expression)</para><para>es imitaciÃ³n (obra) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2108">http://iflastandards.info/ns/fr/frbr/frbrer/P2108</seealso>
    let P2108 = Prefixed_Name(frbrer, "P2108") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a supplement (expression) (from expression)</para><para>tiene suplemento (expresiÃ³n) (de expresiÃ³n) </para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2109">http://iflastandards.info/ns/fr/frbr/frbrer/P2109</seealso>
    let P2109 = Prefixed_Name(frbrer, "P2109") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>supplements (expression) (from expression)</para><para>es suplemento (expresiÃ³n) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2110">http://iflastandards.info/ns/fr/frbr/frbrer/P2110</seealso>
    let P2110 = Prefixed_Name(frbrer, "P2110") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene soporte fÃ­sico</para><para>has physical medium</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3025">http://iflastandards.info/ns/fr/frbr/frbrer/P3025</seealso>
    let P3025 = Prefixed_Name(frbrer, "P3025") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene modo de captura</para><para>has capture mode</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3026">http://iflastandards.info/ns/fr/frbr/frbrer/P3026</seealso>
    let P3026 = Prefixed_Name(frbrer, "P3026") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene dimensiones del soporte</para><para>has dimensions of the carrier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3027">http://iflastandards.info/ns/fr/frbr/frbrer/P3027</seealso>
    let P3027 = Prefixed_Name(frbrer, "P3027") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene identificador del manifestaciÃ³n</para><para>has manifestation identifier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3028">http://iflastandards.info/ns/fr/frbr/frbrer/P3028</seealso>
    let P3028 = Prefixed_Name(frbrer, "P3028") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene condiciones de disponibilidad</para><para>has terms of availability</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3029">http://iflastandards.info/ns/fr/frbr/frbrer/P3029</seealso>
    let P3029 = Prefixed_Name(frbrer, "P3029") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene coordenadas (obra cartogrÃ¡fica)</para><para>has coordinates (cartographic work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3062">http://iflastandards.info/ns/fr/frbr/frbrer/P3062</seealso>
    let P3062 = Prefixed_Name(frbrer, "P3062") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene equinoccio (obra cartogrÃ¡fica)</para><para>has equinox (cartographic work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3063">http://iflastandards.info/ns/fr/frbr/frbrer/P3063</seealso>
    let P3063 = Prefixed_Name(frbrer, "P3063") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene modelo de secuencia (publicaciÃ³n seriada)</para><para>has sequencing pattern (serial)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3064">http://iflastandards.info/ns/fr/frbr/frbrer/P3064</seealso>
    let P3064 = Prefixed_Name(frbrer, "P3064") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene regularidad prevista de la publicaciÃ³n (publicaciÃ³n seriada)</para><para>has expected regularity of issue (serial)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3065">http://iflastandards.info/ns/fr/frbr/frbrer/P3065</seealso>
    let P3065 = Prefixed_Name(frbrer, "P3065") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene frecuencia de publicaciÃ³n prevista (publicaciÃ³n seriada)</para><para>has expected frequency of issue (serial)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3066">http://iflastandards.info/ns/fr/frbr/frbrer/P3066</seealso>
    let P3066 = Prefixed_Name(frbrer, "P3066") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipo de partitura (notaciÃ³n musical)</para><para>has type of score (musical notation)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3067">http://iflastandards.info/ns/fr/frbr/frbrer/P3067</seealso>
    let P3067 = Prefixed_Name(frbrer, "P3067") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©cnica (imagen grÃ¡fica o proyectada)</para><para>has technique (graphic or projected image)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3072">http://iflastandards.info/ns/fr/frbr/frbrer/P3072</seealso>
    let P3072 = Prefixed_Name(frbrer, "P3072") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipografÃ­a (libros impresos)</para><para>has typeface (printed book)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3074">http://iflastandards.info/ns/fr/frbr/frbrer/P3074</seealso>
    let P3074 = Prefixed_Name(frbrer, "P3074") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tamaÃ±o del tipo (libro impreso)</para><para>has type size (printed book)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3075">http://iflastandards.info/ns/fr/frbr/frbrer/P3075</seealso>
    let P3075 = Prefixed_Name(frbrer, "P3075") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene foliaciÃ³n (imprenta manual)</para><para>has foliation (hand-printed book)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3076">http://iflastandards.info/ns/fr/frbr/frbrer/P3076</seealso>
    let P3076 = Prefixed_Name(frbrer, "P3076") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has collation (hand-printed book)</para><para>tiene colaciÃ³n (imprenta manual)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3077">http://iflastandards.info/ns/fr/frbr/frbrer/P3077</seealso>
    let P3077 = Prefixed_Name(frbrer, "P3077") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene numeraciÃ³n (publicaciÃ³n seriada)</para><para>has numbering (serial)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3079">http://iflastandards.info/ns/fr/frbr/frbrer/P3079</seealso>
    let P3079 = Prefixed_Name(frbrer, "P3079") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene velocidad de reproducciÃ³n (grabaciÃ³n sonora)</para><para>has playing speed (sound recording)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3080">http://iflastandards.info/ns/fr/frbr/frbrer/P3080</seealso>
    let P3080 = Prefixed_Name(frbrer, "P3080") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene anchura del surco</para><para>has groove width</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3081">http://iflastandards.info/ns/fr/frbr/frbrer/P3081</seealso>
    let P3081 = Prefixed_Name(frbrer, "P3081") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has kind of cutting (sound recording)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3082">http://iflastandards.info/ns/fr/frbr/frbrer/P3082</seealso>
    let P3082 = Prefixed_Name(frbrer, "P3082") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene configuraciÃ³n de la cinta (grabaciÃ³n sonora)</para><para>has tape configuration (sound recording)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3083">http://iflastandards.info/ns/fr/frbr/frbrer/P3083</seealso>
    let P3083 = Prefixed_Name(frbrer, "P3083") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tipo de sonido (grabaciÃ³n sonora)</para><para>has kind of sound (sound recording)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3084">http://iflastandards.info/ns/fr/frbr/frbrer/P3084</seealso>
    let P3084 = Prefixed_Name(frbrer, "P3084") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene color (imagen)</para><para>has colour (image)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3086">http://iflastandards.info/ns/fr/frbr/frbrer/P3086</seealso>
    let P3086 = Prefixed_Name(frbrer, "P3086") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene escala de reducciÃ³n (microforma)</para><para>has reduction ratio (microform)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3087">http://iflastandards.info/ns/fr/frbr/frbrer/P3087</seealso>
    let P3087 = Prefixed_Name(frbrer, "P3087") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene polaridad (microforma o proyecciÃ³n visual)</para><para>has polarity (microform or visual projection)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3088">http://iflastandards.info/ns/fr/frbr/frbrer/P3088</seealso>
    let P3088 = Prefixed_Name(frbrer, "P3088") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene generaciÃ³n (microforma o proyecciÃ³n visual)</para><para>has generation (microform or visual projection)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3089">http://iflastandards.info/ns/fr/frbr/frbrer/P3089</seealso>
    let P3089 = Prefixed_Name(frbrer, "P3089") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene formato de presentaciÃ³n (proyecciÃ³n visual)</para><para>has presentation format (visual projection)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3090">http://iflastandards.info/ns/fr/frbr/frbrer/P3090</seealso>
    let P3090 = Prefixed_Name(frbrer, "P3090") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "includes" prefixing the definition, interpreted as "and other system components" in the property description.</para>
    /// labels<para>tiene requisitos del sistema (recurso electrÃ³nico)</para><para>has system requirements (electronic resource)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3093">http://iflastandards.info/ns/fr/frbr/frbrer/P3093</seealso>
    let P3093 = Prefixed_Name(frbrer, "P3093") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (expresiÃ³n)</para><para>has as subject (expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2037">http://iflastandards.info/ns/fr/frbr/frbrer/P2037</seealso>
    let P2037 = Prefixed_Name(frbrer, "P2037") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (manifestaciÃ³n)</para><para>has as subject (manifestation)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2039">http://iflastandards.info/ns/fr/frbr/frbrer/P2039</seealso>
    let P2039 = Prefixed_Name(frbrer, "P2039") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (manifestaciÃ³n) de</para><para>is subject (manifestation) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2040">http://iflastandards.info/ns/fr/frbr/frbrer/P2040</seealso>
    let P2040 = Prefixed_Name(frbrer, "P2040") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (ejemplar) de</para><para>is subject (item) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2042">http://iflastandards.info/ns/fr/frbr/frbrer/P2042</seealso>
    let P2042 = Prefixed_Name(frbrer, "P2042") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene reproducciÃ³n (manifestaciÃ³n) (de manifestaciÃ³n)</para><para>has a reproduction (manifestation) (from manifestation)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2081">http://iflastandards.info/ns/fr/frbr/frbrer/P2081</seealso>
    let P2081 = Prefixed_Name(frbrer, "P2081") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an imitation (work) (from expression)</para><para>tiene imitaciÃ³n (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2107">http://iflastandards.info/ns/fr/frbr/frbrer/P2107</seealso>
    let P2107 = Prefixed_Name(frbrer, "P2107") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene lengua de la expresiÃ³n</para><para>has language of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3011">http://iflastandards.info/ns/fr/frbr/frbrer/P3011</seealso>
    let P3011 = Prefixed_Name(frbrer, "P3011") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source document has label "Other Distinguishing Characteristic" used also for a Work attribute.</para>
    /// labels<para>tiene otras caracterÃ­sticas distintivas de expresiÃ³n</para><para>has other distinguishing characteristic of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3012">http://iflastandards.info/ns/fr/frbr/frbrer/P3012</seealso>
    let P3012 = Prefixed_Name(frbrer, "P3012") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene extensibilidad de la expresiÃ³n</para><para>has extensibility of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3013">http://iflastandards.info/ns/fr/frbr/frbrer/P3013</seealso>
    let P3013 = Prefixed_Name(frbrer, "P3013") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene extensiÃ³n de la expresiÃ³n</para><para>has extent of the expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3015">http://iflastandards.info/ns/fr/frbr/frbrer/P3015</seealso>
    let P3015 = Prefixed_Name(frbrer, "P3015") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene contexto de la expresiÃ³n</para><para>has context for the expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3017">http://iflastandards.info/ns/fr/frbr/frbrer/P3017</seealso>
    let P3017 = Prefixed_Name(frbrer, "P3017") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene restricciones de uso de la expresiÃ³n</para><para>has use restrictions on the expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3019">http://iflastandards.info/ns/fr/frbr/frbrer/P3019</seealso>
    let P3019 = Prefixed_Name(frbrer, "P3019") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene menciÃ³n de responsabilidad</para><para>has statement of responsibility</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3021">http://iflastandards.info/ns/fr/frbr/frbrer/P3021</seealso>
    let P3021 = Prefixed_Name(frbrer, "P3021") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma del soporte</para><para>has form of carrier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3023">http://iflastandards.info/ns/fr/frbr/frbrer/P3023</seealso>
    let P3023 = Prefixed_Name(frbrer, "P3023") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene extensiÃ³n del soporte</para><para>has extent of the carrier</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3024">http://iflastandards.info/ns/fr/frbr/frbrer/P3024</seealso>
    let P3024 = Prefixed_Name(frbrer, "P3024") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "marks/inscriptions"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>tiene marcas o inscripciones</para><para>has marks or inscriptions</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3052">http://iflastandards.info/ns/fr/frbr/frbrer/P3052</seealso>
    let P3052 = Prefixed_Name(frbrer, "P3052") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "publisher/distributor"; slash character replaced with "or" to improve clarity.</para>
    /// labels<para>has publisher or distributor</para><para>tiene editor o distribuidor</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3056">http://iflastandards.info/ns/fr/frbr/frbrer/P3056</seealso>
    let P3056 = Prefixed_Name(frbrer, "P3056") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene caracterÃ­sticas especiales de la reproducciÃ³n  (grabaciÃ³n sonora)</para><para>has special reproduction characteristic (sound recording)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3085">http://iflastandards.info/ns/fr/frbr/frbrer/P3085</seealso>
    let P3085 = Prefixed_Name(frbrer, "P3085") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is exemplar of</para><para>es ejemplar de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2006">http://iflastandards.info/ns/fr/frbr/frbrer/P2006</seealso>
    let P2006 = Prefixed_Name(frbrer, "P2006") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propiedad de (persona)</para><para>is owned by (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2021">http://iflastandards.info/ns/fr/frbr/frbrer/P2021</seealso>
    let P2021 = Prefixed_Name(frbrer, "P2021") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es propietario (persona) de</para><para>is owner (person) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2022">http://iflastandards.info/ns/fr/frbr/frbrer/P2022</seealso>
    let P2022 = Prefixed_Name(frbrer, "P2022") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a translation (expression) of</para><para>es traducciÃ³n (expresiÃ³n) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2064">http://iflastandards.info/ns/fr/frbr/frbrer/P2064</seealso>
    let P2064 = Prefixed_Name(frbrer, "P2064") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an arrangement (expression) of</para><para>es arreglo (expresiÃ³n) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2066">http://iflastandards.info/ns/fr/frbr/frbrer/P2066</seealso>
    let P2066 = Prefixed_Name(frbrer, "P2066") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es continuaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para><para>is a successor (expression) to (expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2068">http://iflastandards.info/ns/fr/frbr/frbrer/P2068</seealso>
    let P2068 = Prefixed_Name(frbrer, "P2068") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>forma parte (manifestaciÃ³n) de</para><para>is part (manifestation) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2086">http://iflastandards.info/ns/fr/frbr/frbrer/P2086</seealso>
    let P2086 = Prefixed_Name(frbrer, "P2086") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene estado de la publicaciÃ³n (publicaciÃ³n seriada)</para><para>has publication status (serial)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3078">http://iflastandards.info/ns/fr/frbr/frbrer/P3078</seealso>
    let P3078 = Prefixed_Name(frbrer, "P3078") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (objeto)</para><para>has as subject (object)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2025">http://iflastandards.info/ns/fr/frbr/frbrer/P2025</seealso>
    let P2025 = Prefixed_Name(frbrer, "P2025") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene complemento (expresiÃ³n)  (de expresiÃ³n)</para><para>has a complement (expression) (from expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2069">http://iflastandards.info/ns/fr/frbr/frbrer/P2069</seealso>
    let P2069 = Prefixed_Name(frbrer, "P2069") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ­tulo de la expresiÃ³n</para><para>has title of the expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3008">http://iflastandards.info/ns/fr/frbr/frbrer/P3008</seealso>
    let P3008 = Prefixed_Name(frbrer, "P3008") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene forma de la expresiÃ³n</para><para>has form of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3009">http://iflastandards.info/ns/fr/frbr/frbrer/P3009</seealso>
    let P3009 = Prefixed_Name(frbrer, "P3009") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene fecha de la expresiÃ³n</para><para>has date of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3010">http://iflastandards.info/ns/fr/frbr/frbrer/P3010</seealso>
    let P3010 = Prefixed_Name(frbrer, "P3010") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene revisabilidad de la expresiÃ³n</para><para>has revisability of expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3014">http://iflastandards.info/ns/fr/frbr/frbrer/P3014</seealso>
    let P3014 = Prefixed_Name(frbrer, "P3014") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has summarization of content</para><para>tiene resumen del contenido</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3016">http://iflastandards.info/ns/fr/frbr/frbrer/P3016</seealso>
    let P3016 = Prefixed_Name(frbrer, "P3016") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene respuesta crÃ­tica a la expresiÃ³n</para><para>has critical response to the expression</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3018">http://iflastandards.info/ns/fr/frbr/frbrer/P3018</seealso>
    let P3018 = Prefixed_Name(frbrer, "P3018") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ­tulo de la manifestaciÃ³n</para><para>has title of the manifestation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3020">http://iflastandards.info/ns/fr/frbr/frbrer/P3020</seealso>
    let P3020 = Prefixed_Name(frbrer, "P3020") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene menciÃ³n de serie</para><para>has series statement</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3022">http://iflastandards.info/ns/fr/frbr/frbrer/P3022</seealso>
    let P3022 = Prefixed_Name(frbrer, "P3022") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©rmino del concepto</para><para>has term for the concept</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3048">http://iflastandards.info/ns/fr/frbr/frbrer/P3048</seealso>
    let P3048 = Prefixed_Name(frbrer, "P3048") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a summary (expression) (from expression)</para><para>tiene resumen (expresiÃ³n) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2071">http://iflastandards.info/ns/fr/frbr/frbrer/P2071</seealso>
    let P2071 = Prefixed_Name(frbrer, "P2071") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene restricciones de acceso a la manifestaciÃ³n</para><para>has access restrictions on the manifestation</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3030">http://iflastandards.info/ns/fr/frbr/frbrer/P3030</seealso>
    let P3030 = Prefixed_Name(frbrer, "P3030") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/">http://iflastandards.info/ns/fr/frbr/frbrer/</seealso>
    let _prefix_iri = Prefixed_Name(frbrer, "") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ejemplar</para><para>Item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1004">http://iflastandards.info/ns/fr/frbr/frbrer/C1004</seealso>
    let C1004 = Prefixed_Name(frbrer, "C1004") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Persona</para><para>Person</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1005">http://iflastandards.info/ns/fr/frbr/frbrer/C1005</seealso>
    let C1005 = Prefixed_Name(frbrer, "C1005") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Objeto</para><para>Object</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1008">http://iflastandards.info/ns/fr/frbr/frbrer/C1008</seealso>
    let C1008 = Prefixed_Name(frbrer, "C1008") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:C1010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lugar</para><para>Place</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/C1010">http://iflastandards.info/ns/fr/frbr/frbrer/C1010</seealso>
    let C1010 = Prefixed_Name(frbrer, "C1010") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>estÃ¡ realizado mediante</para><para>is realized through</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2001">http://iflastandards.info/ns/fr/frbr/frbrer/P2001</seealso>
    let P2001 = Prefixed_Name(frbrer, "P2001") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es realizaciÃ³n de</para><para>is realization of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2002">http://iflastandards.info/ns/fr/frbr/frbrer/P2002</seealso>
    let P2002 = Prefixed_Name(frbrer, "P2002") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ­tulo de la obra</para><para>has title of the work</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3001">http://iflastandards.info/ns/fr/frbr/frbrer/P3001</seealso>
    let P3001 = Prefixed_Name(frbrer, "P3001") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene finalizaciÃ³n prevista</para><para>has intended termination</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3005">http://iflastandards.info/ns/fr/frbr/frbrer/P3005</seealso>
    let P3005 = Prefixed_Name(frbrer, "P3005") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>estÃ¡ materializado en</para><para>is embodied in</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2003">http://iflastandards.info/ns/fr/frbr/frbrer/P2003</seealso>
    let P2003 = Prefixed_Name(frbrer, "P2003") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>estÃ¡ ejemplificado por</para><para>is exemplified by</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2005">http://iflastandards.info/ns/fr/frbr/frbrer/P2005</seealso>
    let P2005 = Prefixed_Name(frbrer, "P2005") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creado por (entidad corporativa)</para><para>is created by (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2007">http://iflastandards.info/ns/fr/frbr/frbrer/P2007</seealso>
    let P2007 = Prefixed_Name(frbrer, "P2007") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es creado por (persona)</para><para>is created by (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2009">http://iflastandards.info/ns/fr/frbr/frbrer/P2009</seealso>
    let P2009 = Prefixed_Name(frbrer, "P2009") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (lugar)</para><para>has as subject (place)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2029">http://iflastandards.info/ns/fr/frbr/frbrer/P2029</seealso>
    let P2029 = Prefixed_Name(frbrer, "P2029") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (entidad corporativa)</para><para>has as subject (corporate body)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2031">http://iflastandards.info/ns/fr/frbr/frbrer/P2031</seealso>
    let P2031 = Prefixed_Name(frbrer, "P2031") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene como materia (persona)</para><para>has as subject (person)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2033">http://iflastandards.info/ns/fr/frbr/frbrer/P2033</seealso>
    let P2033 = Prefixed_Name(frbrer, "P2033") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es materia (persona) de</para><para>is subject (person) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2034">http://iflastandards.info/ns/fr/frbr/frbrer/P2034</seealso>
    let P2034 = Prefixed_Name(frbrer, "P2034") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject (work) of</para><para>es materia (obra) de</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2036">http://iflastandards.info/ns/fr/frbr/frbrer/P2036</seealso>
    let P2036 = Prefixed_Name(frbrer, "P2036") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>is a transformation (work) of (work)</para><para>es transformaciÃ³n (obra) de (obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2054">http://iflastandards.info/ns/fr/frbr/frbrer/P2054</seealso>
    let P2054 = Prefixed_Name(frbrer, "P2054") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a complement (work) (from work)</para><para>tiene complemento (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2047">http://iflastandards.info/ns/fr/frbr/frbrer/P2047</seealso>
    let P2047 = Prefixed_Name(frbrer, "P2047") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es continuaciÃ³n (obra) de (obra)</para><para>is a successor (work) to (work)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2044">http://iflastandards.info/ns/fr/frbr/frbrer/P2044</seealso>
    let P2044 = Prefixed_Name(frbrer, "P2044") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>has a transformation (work) (from work)</para><para>tiene transformaciÃ³n (obra) (de obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2053">http://iflastandards.info/ns/fr/frbr/frbrer/P2053</seealso>
    let P2053 = Prefixed_Name(frbrer, "P2053") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is an adaptation (work) of (work)</para><para>es adaptaciÃ³n (obra) de (obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2052">http://iflastandards.info/ns/fr/frbr/frbrer/P2052</seealso>
    let P2052 = Prefixed_Name(frbrer, "P2052") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>forma parte (obra) de</para><para>is part (work) of</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2058">http://iflastandards.info/ns/fr/frbr/frbrer/P2058</seealso>
    let P2058 = Prefixed_Name(frbrer, "P2058") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is a summary (work) of (work)</para><para>es resumen (obra) de (obra)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2050">http://iflastandards.info/ns/fr/frbr/frbrer/P2050</seealso>
    let P2050 = Prefixed_Name(frbrer, "P2050") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>has a transformation (expression) (from expression)</para><para>tiene transformaciÃ³n (expresiÃ³n) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2075">http://iflastandards.info/ns/fr/frbr/frbrer/P2075</seealso>
    let P2075 = Prefixed_Name(frbrer, "P2075") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Source documentation has "literary genre", but other genres allowed.</para>
    /// labels<para>is a transformation (expression) of (expression)</para><para>es transformaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2076">http://iflastandards.info/ns/fr/frbr/frbrer/P2076</seealso>
    let P2076 = Prefixed_Name(frbrer, "P2076") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has an imitation (expression) (from expression)</para><para>tiene imitaciÃ³n (expresiÃ³n) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2077">http://iflastandards.info/ns/fr/frbr/frbrer/P2077</seealso>
    let P2077 = Prefixed_Name(frbrer, "P2077") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a successor (work) (from expression)</para><para>continuado por (obra) (de expresiÃ³n)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2095">http://iflastandards.info/ns/fr/frbr/frbrer/P2095</seealso>
    let P2095 = Prefixed_Name(frbrer, "P2095") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P2096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>es continuaciÃ³n (obra) de (expresiÃ³n)</para><para>is a successor (work) to (expression)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P2096">http://iflastandards.info/ns/fr/frbr/frbrer/P2096</seealso>
    let P2096 = Prefixed_Name(frbrer, "P2096") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene procedencia del ejemplar</para><para>has provenance of the item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3033">http://iflastandards.info/ns/fr/frbr/frbrer/P3033</seealso>
    let P3033 = Prefixed_Name(frbrer, "P3033") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene historial de exposiciones</para><para>has exhibition history</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3034">http://iflastandards.info/ns/fr/frbr/frbrer/P3034</seealso>
    let P3034 = Prefixed_Name(frbrer, "P3034") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene restricciones de acceso al ejemplar</para><para>has access restrictions on the item</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3038">http://iflastandards.info/ns/fr/frbr/frbrer/P3038</seealso>
    let P3038 = Prefixed_Name(frbrer, "P3038") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene medio de interpretaciÃ³n (notaciÃ³n musical o registro sonoro)</para><para>has medium of performance (musical notation or recorded sound)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3068">http://iflastandards.info/ns/fr/frbr/frbrer/P3068</seealso>
    let P3068 = Prefixed_Name(frbrer, "P3068") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene tÃ©cnica de grabaciÃ³n (imagen sensible remota)</para><para>has recording technique (remote sensing image)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3070">http://iflastandards.info/ns/fr/frbr/frbrer/P3070</seealso>
    let P3070 = Prefixed_Name(frbrer, "P3070") |> PrefixedName
    /// <summary>
    ///   <para>frbrer:P3071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tiene caracterÃ­sticas especiales (imagen sensibel remota)</para><para>has special characteristic (remote sensing image)</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbrer/P3071">http://iflastandards.info/ns/fr/frbr/frbrer/P3071</seealso>
    let P3071 = Prefixed_Name(frbrer, "P3071") |> PrefixedName

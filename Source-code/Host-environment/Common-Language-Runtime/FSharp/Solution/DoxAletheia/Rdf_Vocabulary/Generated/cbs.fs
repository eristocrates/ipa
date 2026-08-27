namespace http.betalinkeddata.cbs.nl.def.cbs.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cbs =
    let _namespace_iri = Namespace_Iri cbs |> NamespaceIRI
    /// <summary>
    ///   <para>cbs:Buurt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Buurt"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#Buurt">http://betalinkeddata.cbs.nl/def/cbs#Buurt</seealso>
    let Buurt = Prefixed_Name(cbs, "Buurt") |> PrefixedName

    /// <summary>
    ///   <para>cbs:Gemeente_Geografisch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gemeente (Geografisch)"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#Gemeente_Geografisch">http://betalinkeddata.cbs.nl/def/cbs#Gemeente_Geografisch</seealso>
    let Gemeente_Geografisch =
        Prefixed_Name(cbs, "Gemeente_Geografisch") |> PrefixedName

    /// <summary>
    ///   <para>cbs:Land_Geografisch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Land (Geografisch)"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#Land_Geografisch">http://betalinkeddata.cbs.nl/def/cbs#Land_Geografisch</seealso>
    let Land_Geografisch = Prefixed_Name(cbs, "Land_Geografisch") |> PrefixedName
    /// <summary>
    ///   <para>cbs:Regio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Regio"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#Regio">http://betalinkeddata.cbs.nl/def/cbs#Regio</seealso>
    let Regio = Prefixed_Name(cbs, "Regio") |> PrefixedName
    /// <summary>
    ///   <para>cbs:Wijk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wijk"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#Wijk">http://betalinkeddata.cbs.nl/def/cbs#Wijk</seealso>
    let Wijk = Prefixed_Name(cbs, "Wijk") |> PrefixedName
    /// <summary>
    ///   <para>cbs:indelingswijziging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"indelingswijziging"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#indelingswijziging">http://betalinkeddata.cbs.nl/def/cbs#indelingswijziging</seealso>
    let indelingswijziging = Prefixed_Name(cbs, "indelingswijziging") |> PrefixedName
    /// <summary>
    ///   <para>cbs:regiocode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"regiocode"</para></remarks>
    /// <seealso href="http://betalinkeddata.cbs.nl/def/cbs#regiocode">http://betalinkeddata.cbs.nl/def/cbs#regiocode</seealso>
    let regiocode = Prefixed_Name(cbs, "regiocode") |> PrefixedName

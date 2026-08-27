namespace http.rdaregistry.info.Elements.i.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdai =
    let _namespace_iri = Namespace_Iri rdai |> NamespaceIRI
    /// <summary>
    ///   <para>rdai:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/">http://rdaregistry.info/Elements/i/</seealso>
    let _prefix_iri = Prefixed_Name(rdai, "") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has identifier for the item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40001">http://rdaregistry.info/Elements/i/P40001</seealso>
    let P40001 = Prefixed_Name(rdai, "P40001") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40002">http://rdaregistry.info/Elements/i/P40002</seealso>
    let P40002 = Prefixed_Name(rdai, "P40002") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on item-specific carrier characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40003">http://rdaregistry.info/Elements/i/P40003</seealso>
    let P40003 = Prefixed_Name(rdai, "P40003") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has collector"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40004">http://rdaregistry.info/Elements/i/P40004</seealso>
    let P40004 = Prefixed_Name(rdai, "P40004") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has collection registrar"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40005">http://rdaregistry.info/Elements/i/P40005</seealso>
    let P40005 = Prefixed_Name(rdai, "P40005") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has depositor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40006">http://rdaregistry.info/Elements/i/P40006</seealso>
    let P40006 = Prefixed_Name(rdai, "P40006") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has donor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40007">http://rdaregistry.info/Elements/i/P40007</seealso>
    let P40007 = Prefixed_Name(rdai, "P40007") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has seller"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40008">http://rdaregistry.info/Elements/i/P40008</seealso>
    let P40008 = Prefixed_Name(rdai, "P40008") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is contained in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40009">http://rdaregistry.info/Elements/i/P40009</seealso>
    let P40009 = Prefixed_Name(rdai, "P40009") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on dimensions of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40010">http://rdaregistry.info/Elements/i/P40010</seealso>
    let P40010 = Prefixed_Name(rdai, "P40010") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on extent of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40011">http://rdaregistry.info/Elements/i/P40011</seealso>
    let P40011 = Prefixed_Name(rdai, "P40011") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has illuminator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40012">http://rdaregistry.info/Elements/i/P40012</seealso>
    let P40012 = Prefixed_Name(rdai, "P40012") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has binder"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40013">http://rdaregistry.info/Elements/i/P40013</seealso>
    let P40013 = Prefixed_Name(rdai, "P40013") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has inscriber"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40014">http://rdaregistry.info/Elements/i/P40014</seealso>
    let P40014 = Prefixed_Name(rdai, "P40014") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has annotator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40015">http://rdaregistry.info/Elements/i/P40015</seealso>
    let P40015 = Prefixed_Name(rdai, "P40015") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has autographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40016">http://rdaregistry.info/Elements/i/P40016</seealso>
    let P40016 = Prefixed_Name(rdai, "P40016") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has curator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40017">http://rdaregistry.info/Elements/i/P40017</seealso>
    let P40017 = Prefixed_Name(rdai, "P40017") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has current owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40018">http://rdaregistry.info/Elements/i/P40018</seealso>
    let P40018 = Prefixed_Name(rdai, "P40018") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has former owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40019">http://rdaregistry.info/Elements/i/P40019</seealso>
    let P40019 = Prefixed_Name(rdai, "P40019") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has custodian"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40020">http://rdaregistry.info/Elements/i/P40020</seealso>
    let P40020 = Prefixed_Name(rdai, "P40020") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40021">http://rdaregistry.info/Elements/i/P40021</seealso>
    let P40021 = Prefixed_Name(rdai, "P40021") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has honouree (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40022">http://rdaregistry.info/Elements/i/P40022</seealso>
    let P40022 = Prefixed_Name(rdai, "P40022") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other person, family, or corporate body associated with an item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40023">http://rdaregistry.info/Elements/i/P40023</seealso>
    let P40023 = Prefixed_Name(rdai, "P40023") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restorationist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40024">http://rdaregistry.info/Elements/i/P40024</seealso>
    let P40024 = Prefixed_Name(rdai, "P40024") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dedicatee (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40025">http://rdaregistry.info/Elements/i/P40025</seealso>
    let P40025 = Prefixed_Name(rdai, "P40025") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has custodial history of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40026">http://rdaregistry.info/Elements/i/P40026</seealso>
    let P40026 = Prefixed_Name(rdai, "P40026") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is electronic reproduction of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40027">http://rdaregistry.info/Elements/i/P40027</seealso>
    let P40027 = Prefixed_Name(rdai, "P40027") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40028">http://rdaregistry.info/Elements/i/P40028</seealso>
    let P40028 = Prefixed_Name(rdai, "P40028") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is accompanied by (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40029">http://rdaregistry.info/Elements/i/P40029</seealso>
    let P40029 = Prefixed_Name(rdai, "P40029") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40030">http://rdaregistry.info/Elements/i/P40030</seealso>
    let P40030 = Prefixed_Name(rdai, "P40030") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is equivalent (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40031">http://rdaregistry.info/Elements/i/P40031</seealso>
    let P40031 = Prefixed_Name(rdai, "P40031") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is bound with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40032">http://rdaregistry.info/Elements/i/P40032</seealso>
    let P40032 = Prefixed_Name(rdai, "P40032") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40033">http://rdaregistry.info/Elements/i/P40033</seealso>
    let P40033 = Prefixed_Name(rdai, "P40033") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is container of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40034">http://rdaregistry.info/Elements/i/P40034</seealso>
    let P40034 = Prefixed_Name(rdai, "P40034") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is on disc with (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40035">http://rdaregistry.info/Elements/i/P40035</seealso>
    let P40035 = Prefixed_Name(rdai, "P40035") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is filmed with (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40036">http://rdaregistry.info/Elements/i/P40036</seealso>
    let P40036 = Prefixed_Name(rdai, "P40036") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40037">http://rdaregistry.info/Elements/i/P40037</seealso>
    let P40037 = Prefixed_Name(rdai, "P40037") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reprint of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40038">http://rdaregistry.info/Elements/i/P40038</seealso>
    let P40038 = Prefixed_Name(rdai, "P40038") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digital transfer of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40039">http://rdaregistry.info/Elements/i/P40039</seealso>
    let P40039 = Prefixed_Name(rdai, "P40039") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40040">http://rdaregistry.info/Elements/i/P40040</seealso>
    let P40040 = Prefixed_Name(rdai, "P40040") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40041">http://rdaregistry.info/Elements/i/P40041</seealso>
    let P40041 = Prefixed_Name(rdai, "P40041") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reproduction of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40042">http://rdaregistry.info/Elements/i/P40042</seealso>
    let P40042 = Prefixed_Name(rdai, "P40042") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40043">http://rdaregistry.info/Elements/i/P40043</seealso>
    let P40043 = Prefixed_Name(rdai, "P40043") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is preservation facsimile of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40044">http://rdaregistry.info/Elements/i/P40044</seealso>
    let P40044 = Prefixed_Name(rdai, "P40044") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40045">http://rdaregistry.info/Elements/i/P40045</seealso>
    let P40045 = Prefixed_Name(rdai, "P40045") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has related item of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40046">http://rdaregistry.info/Elements/i/P40046</seealso>
    let P40046 = Prefixed_Name(rdai, "P40046") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restrictions on access to item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40047">http://rdaregistry.info/Elements/i/P40047</seealso>
    let P40047 = Prefixed_Name(rdai, "P40047") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restrictions on use of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40048">http://rdaregistry.info/Elements/i/P40048</seealso>
    let P40048 = Prefixed_Name(rdai, "P40048") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has manifestation exemplified"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40049">http://rdaregistry.info/Elements/i/P40049</seealso>
    let P40049 = Prefixed_Name(rdai, "P40049") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has immediate source of acquisition of item"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40050">http://rdaregistry.info/Elements/i/P40050</seealso>
    let P40050 = Prefixed_Name(rdai, "P40050") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has accompanying item relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40051">http://rdaregistry.info/Elements/i/P40051</seealso>
    let P40051 = Prefixed_Name(rdai, "P40051") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40052">http://rdaregistry.info/Elements/i/P40052</seealso>
    let P40052 = Prefixed_Name(rdai, "P40052") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has equivalent item relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40053">http://rdaregistry.info/Elements/i/P40053</seealso>
    let P40053 = Prefixed_Name(rdai, "P40053") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has whole-part item relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40054">http://rdaregistry.info/Elements/i/P40054</seealso>
    let P40054 = Prefixed_Name(rdai, "P40054") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reproduced as (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40055">http://rdaregistry.info/Elements/i/P40055</seealso>
    let P40055 = Prefixed_Name(rdai, "P40055") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digital transfer (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40056">http://rdaregistry.info/Elements/i/P40056</seealso>
    let P40056 = Prefixed_Name(rdai, "P40056") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is electronic reproduction (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40057">http://rdaregistry.info/Elements/i/P40057</seealso>
    let P40057 = Prefixed_Name(rdai, "P40057") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40058">http://rdaregistry.info/Elements/i/P40058</seealso>
    let P40058 = Prefixed_Name(rdai, "P40058") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is preservation facsimile (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40059">http://rdaregistry.info/Elements/i/P40059</seealso>
    let P40059 = Prefixed_Name(rdai, "P40059") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reprinted as (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40060">http://rdaregistry.info/Elements/i/P40060</seealso>
    let P40060 = Prefixed_Name(rdai, "P40060") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is subject of (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40061">http://rdaregistry.info/Elements/i/P40061</seealso>
    let P40061 = Prefixed_Name(rdai, "P40061") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is described in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40062">http://rdaregistry.info/Elements/i/P40062</seealso>
    let P40062 = Prefixed_Name(rdai, "P40062") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is analysed in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40063">http://rdaregistry.info/Elements/i/P40063</seealso>
    let P40063 = Prefixed_Name(rdai, "P40063") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commentary in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40064">http://rdaregistry.info/Elements/i/P40064</seealso>
    let P40064 = Prefixed_Name(rdai, "P40064") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is critiqued in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40065">http://rdaregistry.info/Elements/i/P40065</seealso>
    let P40065 = Prefixed_Name(rdai, "P40065") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is evaluated in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40066">http://rdaregistry.info/Elements/i/P40066</seealso>
    let P40066 = Prefixed_Name(rdai, "P40066") |> PrefixedName
    /// <summary>
    ///   <para>rdai:P40067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reviewed in (item)"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/P40067">http://rdaregistry.info/Elements/i/P40067</seealso>
    let P40067 = Prefixed_Name(rdai, "P40067") |> PrefixedName

    /// <summary>
    ///   <para>rdai:accompaniedByItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/accompaniedByItem.en">http://rdaregistry.info/Elements/i/accompaniedByItem.en</seealso>
    let ``accompaniedByItem.en`` =
        Prefixed_Name(rdai, "accompaniedByItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:accompanyingItemRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/accompanyingItemRelationship.en">http://rdaregistry.info/Elements/i/accompanyingItemRelationship.en</seealso>
    let ``accompanyingItemRelationship.en`` =
        Prefixed_Name(rdai, "accompanyingItemRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:analysedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/analysedInItem.en">http://rdaregistry.info/Elements/i/analysedInItem.en</seealso>
    let ``analysedInItem.en`` = Prefixed_Name(rdai, "analysedInItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:annotator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/annotator.en">http://rdaregistry.info/Elements/i/annotator.en</seealso>
    let ``annotator.en`` = Prefixed_Name(rdai, "annotator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:autographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/autographer.en">http://rdaregistry.info/Elements/i/autographer.en</seealso>
    let ``autographer.en`` = Prefixed_Name(rdai, "autographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:binder.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/binder.en">http://rdaregistry.info/Elements/i/binder.en</seealso>
    let ``binder.en`` = Prefixed_Name(rdai, "binder.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:boundWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/boundWith.en">http://rdaregistry.info/Elements/i/boundWith.en</seealso>
    let ``boundWith.en`` = Prefixed_Name(rdai, "boundWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:collectionRegistrar.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/collectionRegistrar.en">http://rdaregistry.info/Elements/i/collectionRegistrar.en</seealso>
    let ``collectionRegistrar.en`` =
        Prefixed_Name(rdai, "collectionRegistrar.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:collector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/collector">http://rdaregistry.info/Elements/i/collector</seealso>
    let collector = Prefixed_Name(rdai, "collector") |> PrefixedName
    /// <summary>
    ///   <para>rdai:collector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/collector.en">http://rdaregistry.info/Elements/i/collector.en</seealso>
    let ``collector.en`` = Prefixed_Name(rdai, "collector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:collectorOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/collectorOf">http://rdaregistry.info/Elements/i/collectorOf</seealso>
    let collectorOf = Prefixed_Name(rdai, "collectorOf") |> PrefixedName

    /// <summary>
    ///   <para>rdai:commentaryInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/commentaryInItem.en">http://rdaregistry.info/Elements/i/commentaryInItem.en</seealso>
    let ``commentaryInItem.en`` =
        Prefixed_Name(rdai, "commentaryInItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:containedInItem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/containedInItem">http://rdaregistry.info/Elements/i/containedInItem</seealso>
    let containedInItem = Prefixed_Name(rdai, "containedInItem") |> PrefixedName

    /// <summary>
    ///   <para>rdai:containedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/containedInItem.en">http://rdaregistry.info/Elements/i/containedInItem.en</seealso>
    let ``containedInItem.en`` =
        Prefixed_Name(rdai, "containedInItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:containerOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/containerOfItem.en">http://rdaregistry.info/Elements/i/containerOfItem.en</seealso>
    let ``containerOfItem.en`` =
        Prefixed_Name(rdai, "containerOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:containsItem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/containsItem">http://rdaregistry.info/Elements/i/containsItem</seealso>
    let containsItem = Prefixed_Name(rdai, "containsItem") |> PrefixedName

    /// <summary>
    ///   <para>rdai:critiquedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/critiquedInItem.en">http://rdaregistry.info/Elements/i/critiquedInItem.en</seealso>
    let ``critiquedInItem.en`` =
        Prefixed_Name(rdai, "critiquedInItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:curator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/curator.en">http://rdaregistry.info/Elements/i/curator.en</seealso>
    let ``curator.en`` = Prefixed_Name(rdai, "curator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:currentOwner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/currentOwner">http://rdaregistry.info/Elements/i/currentOwner</seealso>
    let currentOwner = Prefixed_Name(rdai, "currentOwner") |> PrefixedName
    /// <summary>
    ///   <para>rdai:currentOwner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/currentOwner.en">http://rdaregistry.info/Elements/i/currentOwner.en</seealso>
    let ``currentOwner.en`` = Prefixed_Name(rdai, "currentOwner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:custodialHistoryOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/custodialHistoryOfItem.en">http://rdaregistry.info/Elements/i/custodialHistoryOfItem.en</seealso>
    let ``custodialHistoryOfItem.en`` =
        Prefixed_Name(rdai, "custodialHistoryOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:custodian.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/custodian.en">http://rdaregistry.info/Elements/i/custodian.en</seealso>
    let ``custodian.en`` = Prefixed_Name(rdai, "custodian.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:dedicateeOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/dedicateeOfItem.en">http://rdaregistry.info/Elements/i/dedicateeOfItem.en</seealso>
    let ``dedicateeOfItem.en`` =
        Prefixed_Name(rdai, "dedicateeOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:depositor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/depositor.en">http://rdaregistry.info/Elements/i/depositor.en</seealso>
    let ``depositor.en`` = Prefixed_Name(rdai, "depositor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:describedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/describedInItem.en">http://rdaregistry.info/Elements/i/describedInItem.en</seealso>
    let ``describedInItem.en`` =
        Prefixed_Name(rdai, "describedInItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:digitalTransferItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/digitalTransferItem.en">http://rdaregistry.info/Elements/i/digitalTransferItem.en</seealso>
    let ``digitalTransferItem.en`` =
        Prefixed_Name(rdai, "digitalTransferItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:digitalTransferOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/digitalTransferOfItem.en">http://rdaregistry.info/Elements/i/digitalTransferOfItem.en</seealso>
    let ``digitalTransferOfItem.en`` =
        Prefixed_Name(rdai, "digitalTransferOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:donor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/donor.en">http://rdaregistry.info/Elements/i/donor.en</seealso>
    let ``donor.en`` = Prefixed_Name(rdai, "donor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:electronicReproductionItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/electronicReproductionItem.en">http://rdaregistry.info/Elements/i/electronicReproductionItem.en</seealso>
    let ``electronicReproductionItem.en`` =
        Prefixed_Name(rdai, "electronicReproductionItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:electronicReproductionOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/electronicReproductionOfItem.en">http://rdaregistry.info/Elements/i/electronicReproductionOfItem.en</seealso>
    let ``electronicReproductionOfItem.en`` =
        Prefixed_Name(rdai, "electronicReproductionOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:equivalentItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/equivalentItem.en">http://rdaregistry.info/Elements/i/equivalentItem.en</seealso>
    let ``equivalentItem.en`` = Prefixed_Name(rdai, "equivalentItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:equivalentItemRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/equivalentItemRelationship.en">http://rdaregistry.info/Elements/i/equivalentItemRelationship.en</seealso>
    let ``equivalentItemRelationship.en`` =
        Prefixed_Name(rdai, "equivalentItemRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:evaluatedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/evaluatedInItem.en">http://rdaregistry.info/Elements/i/evaluatedInItem.en</seealso>
    let ``evaluatedInItem.en`` =
        Prefixed_Name(rdai, "evaluatedInItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:facsimileItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/facsimileItem.en">http://rdaregistry.info/Elements/i/facsimileItem.en</seealso>
    let ``facsimileItem.en`` = Prefixed_Name(rdai, "facsimileItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:facsimileOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/facsimileOfItem.en">http://rdaregistry.info/Elements/i/facsimileOfItem.en</seealso>
    let ``facsimileOfItem.en`` =
        Prefixed_Name(rdai, "facsimileOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:filmedWithItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/filmedWithItem.en">http://rdaregistry.info/Elements/i/filmedWithItem.en</seealso>
    let ``filmedWithItem.en`` = Prefixed_Name(rdai, "filmedWithItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:formerOwner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/formerOwner.en">http://rdaregistry.info/Elements/i/formerOwner.en</seealso>
    let ``formerOwner.en`` = Prefixed_Name(rdai, "formerOwner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:honoureeOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/honoureeOfItem.en">http://rdaregistry.info/Elements/i/honoureeOfItem.en</seealso>
    let ``honoureeOfItem.en`` = Prefixed_Name(rdai, "honoureeOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:identifierForTheItem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/identifierForTheItem">http://rdaregistry.info/Elements/i/identifierForTheItem</seealso>
    let identifierForTheItem =
        Prefixed_Name(rdai, "identifierForTheItem") |> PrefixedName

    /// <summary>
    ///   <para>rdai:identifierForTheItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/identifierForTheItem.en">http://rdaregistry.info/Elements/i/identifierForTheItem.en</seealso>
    let ``identifierForTheItem.en`` =
        Prefixed_Name(rdai, "identifierForTheItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:illuminator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/illuminator.en">http://rdaregistry.info/Elements/i/illuminator.en</seealso>
    let ``illuminator.en`` = Prefixed_Name(rdai, "illuminator.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:immediateSourceOfAcquisitionOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/immediateSourceOfAcquisitionOfItem.en">http://rdaregistry.info/Elements/i/immediateSourceOfAcquisitionOfItem.en</seealso>
    let ``immediateSourceOfAcquisitionOfItem.en`` =
        Prefixed_Name(rdai, "immediateSourceOfAcquisitionOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:inscriber.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/inscriber.en">http://rdaregistry.info/Elements/i/inscriber.en</seealso>
    let ``inscriber.en`` = Prefixed_Name(rdai, "inscriber.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:manifestationExemplified</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/manifestationExemplified">http://rdaregistry.info/Elements/i/manifestationExemplified</seealso>
    let manifestationExemplified =
        Prefixed_Name(rdai, "manifestationExemplified") |> PrefixedName

    /// <summary>
    ///   <para>rdai:manifestationExemplified.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/manifestationExemplified.en">http://rdaregistry.info/Elements/i/manifestationExemplified.en</seealso>
    let ``manifestationExemplified.en`` =
        Prefixed_Name(rdai, "manifestationExemplified.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:noteOnDimensionsOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/noteOnDimensionsOfItem.en">http://rdaregistry.info/Elements/i/noteOnDimensionsOfItem.en</seealso>
    let ``noteOnDimensionsOfItem.en`` =
        Prefixed_Name(rdai, "noteOnDimensionsOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:noteOnExtentOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/noteOnExtentOfItem.en">http://rdaregistry.info/Elements/i/noteOnExtentOfItem.en</seealso>
    let ``noteOnExtentOfItem.en`` =
        Prefixed_Name(rdai, "noteOnExtentOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:noteOnItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/noteOnItem.en">http://rdaregistry.info/Elements/i/noteOnItem.en</seealso>
    let ``noteOnItem.en`` = Prefixed_Name(rdai, "noteOnItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:noteOnItemSpecificCarrierCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/noteOnItemSpecificCarrierCharacteristic.en">http://rdaregistry.info/Elements/i/noteOnItemSpecificCarrierCharacteristic.en</seealso>
    let ``noteOnItemSpecificCarrierCharacteristic.en`` =
        Prefixed_Name(rdai, "noteOnItemSpecificCarrierCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:onDiscWithItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/onDiscWithItem.en">http://rdaregistry.info/Elements/i/onDiscWithItem.en</seealso>
    let ``onDiscWithItem.en`` = Prefixed_Name(rdai, "onDiscWithItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:otherPFCItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/otherPFCItem.en">http://rdaregistry.info/Elements/i/otherPFCItem.en</seealso>
    let ``otherPFCItem.en`` = Prefixed_Name(rdai, "otherPFCItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:owner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/owner">http://rdaregistry.info/Elements/i/owner</seealso>
    let owner = Prefixed_Name(rdai, "owner") |> PrefixedName
    /// <summary>
    ///   <para>rdai:owner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/owner.en">http://rdaregistry.info/Elements/i/owner.en</seealso>
    let ``owner.en`` = Prefixed_Name(rdai, "owner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:preservationFacsimileItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/preservationFacsimileItem.en">http://rdaregistry.info/Elements/i/preservationFacsimileItem.en</seealso>
    let ``preservationFacsimileItem.en`` =
        Prefixed_Name(rdai, "preservationFacsimileItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:preservationFacsimileOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/preservationFacsimileOfItem.en">http://rdaregistry.info/Elements/i/preservationFacsimileOfItem.en</seealso>
    let ``preservationFacsimileOfItem.en`` =
        Prefixed_Name(rdai, "preservationFacsimileOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:relatedItemOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/relatedItemOfItem.en">http://rdaregistry.info/Elements/i/relatedItemOfItem.en</seealso>
    let ``relatedItemOfItem.en`` =
        Prefixed_Name(rdai, "relatedItemOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:reprintOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/reprintOfItem.en">http://rdaregistry.info/Elements/i/reprintOfItem.en</seealso>
    let ``reprintOfItem.en`` = Prefixed_Name(rdai, "reprintOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:reprintedAsItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/reprintedAsItem.en">http://rdaregistry.info/Elements/i/reprintedAsItem.en</seealso>
    let ``reprintedAsItem.en`` =
        Prefixed_Name(rdai, "reprintedAsItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:reproducedAsItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/reproducedAsItem.en">http://rdaregistry.info/Elements/i/reproducedAsItem.en</seealso>
    let ``reproducedAsItem.en`` =
        Prefixed_Name(rdai, "reproducedAsItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:reproductionOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/reproductionOfItem.en">http://rdaregistry.info/Elements/i/reproductionOfItem.en</seealso>
    let ``reproductionOfItem.en`` =
        Prefixed_Name(rdai, "reproductionOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:restorationist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/restorationist.en">http://rdaregistry.info/Elements/i/restorationist.en</seealso>
    let ``restorationist.en`` = Prefixed_Name(rdai, "restorationist.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:restrictionsOnAccessToItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/restrictionsOnAccessToItem.en">http://rdaregistry.info/Elements/i/restrictionsOnAccessToItem.en</seealso>
    let ``restrictionsOnAccessToItem.en`` =
        Prefixed_Name(rdai, "restrictionsOnAccessToItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:restrictionsOnUseOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/restrictionsOnUseOfItem.en">http://rdaregistry.info/Elements/i/restrictionsOnUseOfItem.en</seealso>
    let ``restrictionsOnUseOfItem.en`` =
        Prefixed_Name(rdai, "restrictionsOnUseOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:reviewedInItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/reviewedInItem.en">http://rdaregistry.info/Elements/i/reviewedInItem.en</seealso>
    let ``reviewedInItem.en`` = Prefixed_Name(rdai, "reviewedInItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:seller.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/seller.en">http://rdaregistry.info/Elements/i/seller.en</seealso>
    let ``seller.en`` = Prefixed_Name(rdai, "seller.en") |> PrefixedName
    /// <summary>
    ///   <para>rdai:subjectOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/subjectOfItem.en">http://rdaregistry.info/Elements/i/subjectOfItem.en</seealso>
    let ``subjectOfItem.en`` = Prefixed_Name(rdai, "subjectOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdai:wholePartItemRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/i/wholePartItemRelationship.en">http://rdaregistry.info/Elements/i/wholePartItemRelationship.en</seealso>
    let ``wholePartItemRelationship.en`` =
        Prefixed_Name(rdai, "wholePartItemRelationship.en") |> PrefixedName

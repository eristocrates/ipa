namespace http.rdaregistry.info.Elements.u.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdau =
    let _namespace_iri = Namespace_Iri rdau |> NamespaceIRI
    /// <summary>
    ///   <para>rdau:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/">http://rdaregistry.info/Elements/u/</seealso>
    let _prefix_iri = Prefixed_Name(rdau, "") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is respondent of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60001">http://rdaregistry.info/Elements/u/P60001</seealso>
    let P60001 = Prefixed_Name(rdau, "P60001") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is degree granting institution of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60002">http://rdaregistry.info/Elements/u/P60002</seealso>
    let P60002 = Prefixed_Name(rdau, "P60002") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is host institution of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60003">http://rdaregistry.info/Elements/u/P60003</seealso>
    let P60003 = Prefixed_Name(rdau, "P60003") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is production company of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60004">http://rdaregistry.info/Elements/u/P60004</seealso>
    let P60004 = Prefixed_Name(rdau, "P60004") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is court governed of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60005">http://rdaregistry.info/Elements/u/P60005</seealso>
    let P60005 = Prefixed_Name(rdau, "P60005") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is collector of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60006">http://rdaregistry.info/Elements/u/P60006</seealso>
    let P60006 = Prefixed_Name(rdau, "P60006") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is collection registrar of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60007">http://rdaregistry.info/Elements/u/P60007</seealso>
    let P60007 = Prefixed_Name(rdau, "P60007") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is depositor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60008">http://rdaregistry.info/Elements/u/P60008</seealso>
    let P60008 = Prefixed_Name(rdau, "P60008") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is film director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60009">http://rdaregistry.info/Elements/u/P60009</seealso>
    let P60009 = Prefixed_Name(rdau, "P60009") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60010">http://rdaregistry.info/Elements/u/P60010</seealso>
    let P60010 = Prefixed_Name(rdau, "P60010") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60011">http://rdaregistry.info/Elements/u/P60011</seealso>
    let P60011 = Prefixed_Name(rdau, "P60011") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is donor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60012">http://rdaregistry.info/Elements/u/P60012</seealso>
    let P60012 = Prefixed_Name(rdau, "P60012") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is seller of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60013">http://rdaregistry.info/Elements/u/P60013</seealso>
    let P60013 = Prefixed_Name(rdau, "P60013") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is enacting jurisdiction of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60014">http://rdaregistry.info/Elements/u/P60014</seealso>
    let P60014 = Prefixed_Name(rdau, "P60014") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is jurisdiction governed of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60015">http://rdaregistry.info/Elements/u/P60015</seealso>
    let P60015 = Prefixed_Name(rdau, "P60015") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is conductor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60016">http://rdaregistry.info/Elements/u/P60016</seealso>
    let P60016 = Prefixed_Name(rdau, "P60016") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is actor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60017">http://rdaregistry.info/Elements/u/P60017</seealso>
    let P60017 = Prefixed_Name(rdau, "P60017") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is on-screen presenter of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60018">http://rdaregistry.info/Elements/u/P60018</seealso>
    let P60018 = Prefixed_Name(rdau, "P60018") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dancer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60019">http://rdaregistry.info/Elements/u/P60019</seealso>
    let P60019 = Prefixed_Name(rdau, "P60019") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is teacher of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60020">http://rdaregistry.info/Elements/u/P60020</seealso>
    let P60020 = Prefixed_Name(rdau, "P60020") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is host of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60021">http://rdaregistry.info/Elements/u/P60021</seealso>
    let P60021 = Prefixed_Name(rdau, "P60021") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is moderator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60022">http://rdaregistry.info/Elements/u/P60022</seealso>
    let P60022 = Prefixed_Name(rdau, "P60022") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is puppeteer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60023">http://rdaregistry.info/Elements/u/P60023</seealso>
    let P60023 = Prefixed_Name(rdau, "P60023") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is panelist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60024">http://rdaregistry.info/Elements/u/P60024</seealso>
    let P60024 = Prefixed_Name(rdau, "P60024") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is instrumentalist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60025">http://rdaregistry.info/Elements/u/P60025</seealso>
    let P60025 = Prefixed_Name(rdau, "P60025") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commentator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60026">http://rdaregistry.info/Elements/u/P60026</seealso>
    let P60026 = Prefixed_Name(rdau, "P60026") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is voice actor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60027">http://rdaregistry.info/Elements/u/P60027</seealso>
    let P60027 = Prefixed_Name(rdau, "P60027") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is narrator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60028">http://rdaregistry.info/Elements/u/P60028</seealso>
    let P60028 = Prefixed_Name(rdau, "P60028") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is storyteller of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60029">http://rdaregistry.info/Elements/u/P60029</seealso>
    let P60029 = Prefixed_Name(rdau, "P60029") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is speaker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60030">http://rdaregistry.info/Elements/u/P60030</seealso>
    let P60030 = Prefixed_Name(rdau, "P60030") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is singer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60031">http://rdaregistry.info/Elements/u/P60031</seealso>
    let P60031 = Prefixed_Name(rdau, "P60031") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is medium of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60032">http://rdaregistry.info/Elements/u/P60032</seealso>
    let P60032 = Prefixed_Name(rdau, "P60032") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is film producer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60033">http://rdaregistry.info/Elements/u/P60033</seealso>
    let P60033 = Prefixed_Name(rdau, "P60033") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio producer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60034">http://rdaregistry.info/Elements/u/P60034</seealso>
    let P60034 = Prefixed_Name(rdau, "P60034") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television producer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60035">http://rdaregistry.info/Elements/u/P60035</seealso>
    let P60035 = Prefixed_Name(rdau, "P60035") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has alternate identity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60036">http://rdaregistry.info/Elements/u/P60036</seealso>
    let P60036 = Prefixed_Name(rdau, "P60036") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has real identity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60037">http://rdaregistry.info/Elements/u/P60037</seealso>
    let P60037 = Prefixed_Name(rdau, "P60037") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has respondent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60045">http://rdaregistry.info/Elements/u/P60045</seealso>
    let P60045 = Prefixed_Name(rdau, "P60045") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has undifferentiated name indicator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60046">http://rdaregistry.info/Elements/u/P60046</seealso>
    let P60046 = Prefixed_Name(rdau, "P60046") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has type of agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60047">http://rdaregistry.info/Elements/u/P60047</seealso>
    let P60047 = Prefixed_Name(rdau, "P60047") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has carrier type"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60048">http://rdaregistry.info/Elements/u/P60048</seealso>
    let P60048 = Prefixed_Name(rdau, "P60048") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has content type"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60049">http://rdaregistry.info/Elements/u/P60049</seealso>
    let P60049 = Prefixed_Name(rdau, "P60049") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has media type"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60050">http://rdaregistry.info/Elements/u/P60050</seealso>
    let P60050 = Prefixed_Name(rdau, "P60050") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has mode of issuance"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60051">http://rdaregistry.info/Elements/u/P60051</seealso>
    let P60051 = Prefixed_Name(rdau, "P60051") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has identifier for the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60052">http://rdaregistry.info/Elements/u/P60052</seealso>
    let P60052 = Prefixed_Name(rdau, "P60052") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has identifier for the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60053">http://rdaregistry.info/Elements/u/P60053</seealso>
    let P60053 = Prefixed_Name(rdau, "P60053") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other distinguishing characteristic of the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60054">http://rdaregistry.info/Elements/u/P60054</seealso>
    let P60054 = Prefixed_Name(rdau, "P60054") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60055</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60055">http://rdaregistry.info/Elements/u/P60055</seealso>
    let P60055 = Prefixed_Name(rdau, "P60055") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on resource-specific carrier characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60056">http://rdaregistry.info/Elements/u/P60056</seealso>
    let P60056 = Prefixed_Name(rdau, "P60056") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has preferred citation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60057">http://rdaregistry.info/Elements/u/P60057</seealso>
    let P60057 = Prefixed_Name(rdau, "P60057") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has form of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60058">http://rdaregistry.info/Elements/u/P60058</seealso>
    let P60058 = Prefixed_Name(rdau, "P60058") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has regional encoding"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60059">http://rdaregistry.info/Elements/u/P60059</seealso>
    let P60059 = Prefixed_Name(rdau, "P60059") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has degree granting institution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60060">http://rdaregistry.info/Elements/u/P60060</seealso>
    let P60060 = Prefixed_Name(rdau, "P60060") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has host institution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60061">http://rdaregistry.info/Elements/u/P60061</seealso>
    let P60061 = Prefixed_Name(rdau, "P60061") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production company"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60062">http://rdaregistry.info/Elements/u/P60062</seealso>
    let P60062 = Prefixed_Name(rdau, "P60062") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has country associated with the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60063">http://rdaregistry.info/Elements/u/P60063</seealso>
    let P60063 = Prefixed_Name(rdau, "P60063") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60064">http://rdaregistry.info/Elements/u/P60064</seealso>
    let P60064 = Prefixed_Name(rdau, "P60064") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has court governed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60065">http://rdaregistry.info/Elements/u/P60065</seealso>
    let P60065 = Prefixed_Name(rdau, "P60065") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has collector"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60066">http://rdaregistry.info/Elements/u/P60066</seealso>
    let P60066 = Prefixed_Name(rdau, "P60066") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has collection registrar"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60067">http://rdaregistry.info/Elements/u/P60067</seealso>
    let P60067 = Prefixed_Name(rdau, "P60067") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has depositor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60068">http://rdaregistry.info/Elements/u/P60068</seealso>
    let P60068 = Prefixed_Name(rdau, "P60068") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has copyright date"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60069">http://rdaregistry.info/Elements/u/P60069</seealso>
    let P60069 = Prefixed_Name(rdau, "P60069") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of distribution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60070">http://rdaregistry.info/Elements/u/P60070</seealso>
    let P60070 = Prefixed_Name(rdau, "P60070") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of production"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60071">http://rdaregistry.info/Elements/u/P60071</seealso>
    let P60071 = Prefixed_Name(rdau, "P60071") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of manufacture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60072">http://rdaregistry.info/Elements/u/P60072</seealso>
    let P60072 = Prefixed_Name(rdau, "P60072") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of publication"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60073">http://rdaregistry.info/Elements/u/P60073</seealso>
    let P60073 = Prefixed_Name(rdau, "P60073") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of capture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60074">http://rdaregistry.info/Elements/u/P60074</seealso>
    let P60074 = Prefixed_Name(rdau, "P60074") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of usage"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60075">http://rdaregistry.info/Elements/u/P60075</seealso>
    let P60075 = Prefixed_Name(rdau, "P60075") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has period of activity of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60076">http://rdaregistry.info/Elements/u/P60076</seealso>
    let P60076 = Prefixed_Name(rdau, "P60076") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel designation of a named revision of an edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60077">http://rdaregistry.info/Elements/u/P60077</seealso>
    let P60077 = Prefixed_Name(rdau, "P60077") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel designation of edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60078">http://rdaregistry.info/Elements/u/P60078</seealso>
    let P60078 = Prefixed_Name(rdau, "P60078") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has number of a conference, etc."</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60079">http://rdaregistry.info/Elements/u/P60079</seealso>
    let P60079 = Prefixed_Name(rdau, "P60079") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numbering of part"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60080">http://rdaregistry.info/Elements/u/P60080</seealso>
    let P60080 = Prefixed_Name(rdau, "P60080") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numbering within series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60081">http://rdaregistry.info/Elements/u/P60081</seealso>
    let P60081 = Prefixed_Name(rdau, "P60081") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numbering within subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60082">http://rdaregistry.info/Elements/u/P60082</seealso>
    let P60082 = Prefixed_Name(rdau, "P60082") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is electronic reproduction"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60083">http://rdaregistry.info/Elements/u/P60083</seealso>
    let P60083 = Prefixed_Name(rdau, "P60083") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has film director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60084">http://rdaregistry.info/Elements/u/P60084</seealso>
    let P60084 = Prefixed_Name(rdau, "P60084") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has radio director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60085">http://rdaregistry.info/Elements/u/P60085</seealso>
    let P60085 = Prefixed_Name(rdau, "P60085") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has television director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60086">http://rdaregistry.info/Elements/u/P60086</seealso>
    let P60086 = Prefixed_Name(rdau, "P60086") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel distributor’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60087">http://rdaregistry.info/Elements/u/P60087</seealso>
    let P60087 = Prefixed_Name(rdau, "P60087") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dramatized as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60088">http://rdaregistry.info/Elements/u/P60088</seealso>
    let P60088 = Prefixed_Name(rdau, "P60088") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has field of activity of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60089">http://rdaregistry.info/Elements/u/P60089</seealso>
    let P60089 = Prefixed_Name(rdau, "P60089") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has award"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60090">http://rdaregistry.info/Elements/u/P60090</seealso>
    let P60090 = Prefixed_Name(rdau, "P60090") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has donor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60091">http://rdaregistry.info/Elements/u/P60091</seealso>
    let P60091 = Prefixed_Name(rdau, "P60091") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has seller"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60092">http://rdaregistry.info/Elements/u/P60092</seealso>
    let P60092 = Prefixed_Name(rdau, "P60092") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has file type"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60093">http://rdaregistry.info/Elements/u/P60093</seealso>
    let P60093 = Prefixed_Name(rdau, "P60093") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has affiliation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60095">http://rdaregistry.info/Elements/u/P60095</seealso>
    let P60095 = Prefixed_Name(rdau, "P60095") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has enacting jurisdiction"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60096">http://rdaregistry.info/Elements/u/P60096</seealso>
    let P60096 = Prefixed_Name(rdau, "P60096") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has jurisdiction governed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60097">http://rdaregistry.info/Elements/u/P60097</seealso>
    let P60097 = Prefixed_Name(rdau, "P60097") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has language of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60098">http://rdaregistry.info/Elements/u/P60098</seealso>
    let P60098 = Prefixed_Name(rdau, "P60098") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has language of the content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60099">http://rdaregistry.info/Elements/u/P60099</seealso>
    let P60099 = Prefixed_Name(rdau, "P60099") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile contained in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60100">http://rdaregistry.info/Elements/u/P60100</seealso>
    let P60100 = Prefixed_Name(rdau, "P60100") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is contained in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60101">http://rdaregistry.info/Elements/u/P60101</seealso>
    let P60101 = Prefixed_Name(rdau, "P60101") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is sequel"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60102">http://rdaregistry.info/Elements/u/P60102</seealso>
    let P60102 = Prefixed_Name(rdau, "P60102") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is replaced in part by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60103">http://rdaregistry.info/Elements/u/P60103</seealso>
    let P60103 = Prefixed_Name(rdau, "P60103") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is replaced by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60104">http://rdaregistry.info/Elements/u/P60104</seealso>
    let P60104 = Prefixed_Name(rdau, "P60104") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60105</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60105">http://rdaregistry.info/Elements/u/P60105</seealso>
    let P60105 = Prefixed_Name(rdau, "P60105") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted in verse as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60106">http://rdaregistry.info/Elements/u/P60106</seealso>
    let P60106 = Prefixed_Name(rdau, "P60106") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has location of conference, etc."</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60107">http://rdaregistry.info/Elements/u/P60107</seealso>
    let P60107 = Prefixed_Name(rdau, "P60107") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel manufacturer’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60108">http://rdaregistry.info/Elements/u/P60108</seealso>
    let P60108 = Prefixed_Name(rdau, "P60108") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has coordinates of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60109">http://rdaregistry.info/Elements/u/P60109</seealso>
    let P60109 = Prefixed_Name(rdau, "P60109") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as motion picture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60110">http://rdaregistry.info/Elements/u/P60110</seealso>
    let P60110 = Prefixed_Name(rdau, "P60110") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60111</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dubbed version of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60111">http://rdaregistry.info/Elements/u/P60111</seealso>
    let P60111 = Prefixed_Name(rdau, "P60111") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60112</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dubbed version"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60112">http://rdaregistry.info/Elements/u/P60112</seealso>
    let P60112 = Prefixed_Name(rdau, "P60112") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60113</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is cadenza"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60113">http://rdaregistry.info/Elements/u/P60113</seealso>
    let P60113 = Prefixed_Name(rdau, "P60113") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60114</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is variations based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60114">http://rdaregistry.info/Elements/u/P60114</seealso>
    let P60114 = Prefixed_Name(rdau, "P60114") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60115</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is modified by variation as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60115">http://rdaregistry.info/Elements/u/P60115</seealso>
    let P60115 = Prefixed_Name(rdau, "P60115") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is cadenza composed for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60116">http://rdaregistry.info/Elements/u/P60116</seealso>
    let P60116 = Prefixed_Name(rdau, "P60116") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is libretto for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60117">http://rdaregistry.info/Elements/u/P60117</seealso>
    let P60117 = Prefixed_Name(rdau, "P60117") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is incidental music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60118">http://rdaregistry.info/Elements/u/P60118</seealso>
    let P60118 = Prefixed_Name(rdau, "P60118") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has variant name for the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60119">http://rdaregistry.info/Elements/u/P60119</seealso>
    let P60119 = Prefixed_Name(rdau, "P60119") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is remade as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60120">http://rdaregistry.info/Elements/u/P60120</seealso>
    let P60120 = Prefixed_Name(rdau, "P60120") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is set to music as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60121">http://rdaregistry.info/Elements/u/P60121</seealso>
    let P60121 = Prefixed_Name(rdau, "P60121") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on issue, part, or iteration used as the basis for identification of the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60122">http://rdaregistry.info/Elements/u/P60122</seealso>
    let P60122 = Prefixed_Name(rdau, "P60122") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on changes in content characteristics"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60123">http://rdaregistry.info/Elements/u/P60123</seealso>
    let P60123 = Prefixed_Name(rdau, "P60123") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on changes in carrier characteristics"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60124">http://rdaregistry.info/Elements/u/P60124</seealso>
    let P60124 = Prefixed_Name(rdau, "P60124") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on distribution statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60125">http://rdaregistry.info/Elements/u/P60125</seealso>
    let P60125 = Prefixed_Name(rdau, "P60125") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on manufacture statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60126">http://rdaregistry.info/Elements/u/P60126</seealso>
    let P60126 = Prefixed_Name(rdau, "P60126") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on production statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60127">http://rdaregistry.info/Elements/u/P60127</seealso>
    let P60127 = Prefixed_Name(rdau, "P60127") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on publication statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60128">http://rdaregistry.info/Elements/u/P60128</seealso>
    let P60128 = Prefixed_Name(rdau, "P60128") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on frequency"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60129">http://rdaregistry.info/Elements/u/P60129</seealso>
    let P60129 = Prefixed_Name(rdau, "P60129") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on statement of responsibility"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60130">http://rdaregistry.info/Elements/u/P60130</seealso>
    let P60130 = Prefixed_Name(rdau, "P60130") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on series statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60131">http://rdaregistry.info/Elements/u/P60131</seealso>
    let P60131 = Prefixed_Name(rdau, "P60131") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on copyright date"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60132">http://rdaregistry.info/Elements/u/P60132</seealso>
    let P60132 = Prefixed_Name(rdau, "P60132") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on dimensions of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60133">http://rdaregistry.info/Elements/u/P60133</seealso>
    let P60133 = Prefixed_Name(rdau, "P60133") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on extent of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60134">http://rdaregistry.info/Elements/u/P60134</seealso>
    let P60134 = Prefixed_Name(rdau, "P60134") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on numbering of serials"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60135">http://rdaregistry.info/Elements/u/P60135</seealso>
    let P60135 = Prefixed_Name(rdau, "P60135") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60136">http://rdaregistry.info/Elements/u/P60136</seealso>
    let P60136 = Prefixed_Name(rdau, "P60136") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on edition statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60137">http://rdaregistry.info/Elements/u/P60137</seealso>
    let P60137 = Prefixed_Name(rdau, "P60137") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as novel"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60138">http://rdaregistry.info/Elements/u/P60138</seealso>
    let P60138 = Prefixed_Name(rdau, "P60138") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publisher’s number for music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60139">http://rdaregistry.info/Elements/u/P60139</seealso>
    let P60139 = Prefixed_Name(rdau, "P60139") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has plate number for music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60140">http://rdaregistry.info/Elements/u/P60140</seealso>
    let P60140 = Prefixed_Name(rdau, "P60140") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has conductor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60141">http://rdaregistry.info/Elements/u/P60141</seealso>
    let P60141 = Prefixed_Name(rdau, "P60141") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has actor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60142">http://rdaregistry.info/Elements/u/P60142</seealso>
    let P60142 = Prefixed_Name(rdau, "P60142") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has on-screen presenter"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60143">http://rdaregistry.info/Elements/u/P60143</seealso>
    let P60143 = Prefixed_Name(rdau, "P60143") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dancer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60144">http://rdaregistry.info/Elements/u/P60144</seealso>
    let P60144 = Prefixed_Name(rdau, "P60144") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has teacher"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60145">http://rdaregistry.info/Elements/u/P60145</seealso>
    let P60145 = Prefixed_Name(rdau, "P60145") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has host"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60146">http://rdaregistry.info/Elements/u/P60146</seealso>
    let P60146 = Prefixed_Name(rdau, "P60146") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has moderator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60147">http://rdaregistry.info/Elements/u/P60147</seealso>
    let P60147 = Prefixed_Name(rdau, "P60147") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has puppeteer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60148">http://rdaregistry.info/Elements/u/P60148</seealso>
    let P60148 = Prefixed_Name(rdau, "P60148") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has panelist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60149">http://rdaregistry.info/Elements/u/P60149</seealso>
    let P60149 = Prefixed_Name(rdau, "P60149") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has instrumentalist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60150">http://rdaregistry.info/Elements/u/P60150</seealso>
    let P60150 = Prefixed_Name(rdau, "P60150") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has commentator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60151">http://rdaregistry.info/Elements/u/P60151</seealso>
    let P60151 = Prefixed_Name(rdau, "P60151") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has voice actor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60152">http://rdaregistry.info/Elements/u/P60152</seealso>
    let P60152 = Prefixed_Name(rdau, "P60152") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has narrator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60153">http://rdaregistry.info/Elements/u/P60153</seealso>
    let P60153 = Prefixed_Name(rdau, "P60153") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has storyteller"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60154">http://rdaregistry.info/Elements/u/P60154</seealso>
    let P60154 = Prefixed_Name(rdau, "P60154") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has speaker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60155">http://rdaregistry.info/Elements/u/P60155</seealso>
    let P60155 = Prefixed_Name(rdau, "P60155") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has singer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60156">http://rdaregistry.info/Elements/u/P60156</seealso>
    let P60156 = Prefixed_Name(rdau, "P60156") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has medium"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60157">http://rdaregistry.info/Elements/u/P60157</seealso>
    let P60157 = Prefixed_Name(rdau, "P60157") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60158</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60158">http://rdaregistry.info/Elements/u/P60158</seealso>
    let P60158 = Prefixed_Name(rdau, "P60158") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has applied material"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60159">http://rdaregistry.info/Elements/u/P60159</seealso>
    let P60159 = Prefixed_Name(rdau, "P60159") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of distribution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60160">http://rdaregistry.info/Elements/u/P60160</seealso>
    let P60160 = Prefixed_Name(rdau, "P60160") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of production"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60161">http://rdaregistry.info/Elements/u/P60161</seealso>
    let P60161 = Prefixed_Name(rdau, "P60161") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of manufacture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60162">http://rdaregistry.info/Elements/u/P60162</seealso>
    let P60162 = Prefixed_Name(rdau, "P60162") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of publication"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60163">http://rdaregistry.info/Elements/u/P60163</seealso>
    let P60163 = Prefixed_Name(rdau, "P60163") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel place of distribution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60164">http://rdaregistry.info/Elements/u/P60164</seealso>
    let P60164 = Prefixed_Name(rdau, "P60164") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel place of manufacture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60165">http://rdaregistry.info/Elements/u/P60165</seealso>
    let P60165 = Prefixed_Name(rdau, "P60165") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel place of production"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60166">http://rdaregistry.info/Elements/u/P60166</seealso>
    let P60166 = Prefixed_Name(rdau, "P60166") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel place of publication"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60167">http://rdaregistry.info/Elements/u/P60167</seealso>
    let P60167 = Prefixed_Name(rdau, "P60167") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reprint of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60168">http://rdaregistry.info/Elements/u/P60168</seealso>
    let P60168 = Prefixed_Name(rdau, "P60168") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has film producer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60169">http://rdaregistry.info/Elements/u/P60169</seealso>
    let P60169 = Prefixed_Name(rdau, "P60169") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has radio producer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60170">http://rdaregistry.info/Elements/u/P60170</seealso>
    let P60170 = Prefixed_Name(rdau, "P60170") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has television producer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60171">http://rdaregistry.info/Elements/u/P60171</seealso>
    let P60171 = Prefixed_Name(rdau, "P60171") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel producer’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60172">http://rdaregistry.info/Elements/u/P60172</seealso>
    let P60172 = Prefixed_Name(rdau, "P60172") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel publisher’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60173">http://rdaregistry.info/Elements/u/P60173</seealso>
    let P60173 = Prefixed_Name(rdau, "P60173") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as radio program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60174">http://rdaregistry.info/Elements/u/P60174</seealso>
    let P60174 = Prefixed_Name(rdau, "P60174") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60175</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has academic degree"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60175">http://rdaregistry.info/Elements/u/P60175</seealso>
    let P60175 = Prefixed_Name(rdau, "P60175") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60176</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has custodial history of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60176">http://rdaregistry.info/Elements/u/P60176</seealso>
    let P60176 = Prefixed_Name(rdau, "P60176") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abstracted in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60177">http://rdaregistry.info/Elements/u/P60177</seealso>
    let P60177 = Prefixed_Name(rdau, "P60177") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is indexed in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60178">http://rdaregistry.info/Elements/u/P60178</seealso>
    let P60178 = Prefixed_Name(rdau, "P60178") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is preservation facsimile"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60179">http://rdaregistry.info/Elements/u/P60179</seealso>
    let P60179 = Prefixed_Name(rdau, "P60179") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as choreography"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60180">http://rdaregistry.info/Elements/u/P60180</seealso>
    let P60180 = Prefixed_Name(rdau, "P60180") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is errata"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60181">http://rdaregistry.info/Elements/u/P60181</seealso>
    let P60181 = Prefixed_Name(rdau, "P60181") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is illustrations"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60182">http://rdaregistry.info/Elements/u/P60182</seealso>
    let P60182 = Prefixed_Name(rdau, "P60182") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is insert"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60183">http://rdaregistry.info/Elements/u/P60183</seealso>
    let P60183 = Prefixed_Name(rdau, "P60183") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as motion picture screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60184">http://rdaregistry.info/Elements/u/P60184</seealso>
    let P60184 = Prefixed_Name(rdau, "P60184") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as a screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60185">http://rdaregistry.info/Elements/u/P60185</seealso>
    let P60185 = Prefixed_Name(rdau, "P60185") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as television screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60186">http://rdaregistry.info/Elements/u/P60186</seealso>
    let P60186 = Prefixed_Name(rdau, "P60186") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60187</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as video screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60187">http://rdaregistry.info/Elements/u/P60187</seealso>
    let P60187 = Prefixed_Name(rdau, "P60187") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60188</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as radio script"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60188">http://rdaregistry.info/Elements/u/P60188</seealso>
    let P60188 = Prefixed_Name(rdau, "P60188") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60189</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is freely translated as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60189">http://rdaregistry.info/Elements/u/P60189</seealso>
    let P60189 = Prefixed_Name(rdau, "P60189") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is description of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60190">http://rdaregistry.info/Elements/u/P60190</seealso>
    let P60190 = Prefixed_Name(rdau, "P60190") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is equivalent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60191">http://rdaregistry.info/Elements/u/P60191</seealso>
    let P60191 = Prefixed_Name(rdau, "P60191") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is subseries of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60192">http://rdaregistry.info/Elements/u/P60192</seealso>
    let P60192 = Prefixed_Name(rdau, "P60192") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is in series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60193">http://rdaregistry.info/Elements/u/P60193</seealso>
    let P60193 = Prefixed_Name(rdau, "P60193") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is inserted in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60194">http://rdaregistry.info/Elements/u/P60194</seealso>
    let P60194 = Prefixed_Name(rdau, "P60194") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is also issued as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60195">http://rdaregistry.info/Elements/u/P60195</seealso>
    let P60195 = Prefixed_Name(rdau, "P60195") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is accompanied by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60196">http://rdaregistry.info/Elements/u/P60196</seealso>
    let P60196 = Prefixed_Name(rdau, "P60196") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is mirror site"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60197">http://rdaregistry.info/Elements/u/P60197</seealso>
    let P60197 = Prefixed_Name(rdau, "P60197") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60198</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is complemented by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60198">http://rdaregistry.info/Elements/u/P60198</seealso>
    let P60198 = Prefixed_Name(rdau, "P60198") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60199</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is continued in part by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60199">http://rdaregistry.info/Elements/u/P60199</seealso>
    let P60199 = Prefixed_Name(rdau, "P60199") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60200</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digital transfer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60200">http://rdaregistry.info/Elements/u/P60200</seealso>
    let P60200 = Prefixed_Name(rdau, "P60200") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60201</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60201">http://rdaregistry.info/Elements/u/P60201</seealso>
    let P60201 = Prefixed_Name(rdau, "P60201") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60202</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is incidental music for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60202">http://rdaregistry.info/Elements/u/P60202</seealso>
    let P60202 = Prefixed_Name(rdau, "P60202") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60203</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abstracted as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60203">http://rdaregistry.info/Elements/u/P60203</seealso>
    let P60203 = Prefixed_Name(rdau, "P60203") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60204</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is augmented by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60204">http://rdaregistry.info/Elements/u/P60204</seealso>
    let P60204 = Prefixed_Name(rdau, "P60204") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60205</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is summarized as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60205">http://rdaregistry.info/Elements/u/P60205</seealso>
    let P60205 = Prefixed_Name(rdau, "P60205") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60206</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is catalogue"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60206">http://rdaregistry.info/Elements/u/P60206</seealso>
    let P60206 = Prefixed_Name(rdau, "P60206") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60207</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is special issue"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60207">http://rdaregistry.info/Elements/u/P60207</seealso>
    let P60207 = Prefixed_Name(rdau, "P60207") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60208</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is concordance"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60208">http://rdaregistry.info/Elements/u/P60208</seealso>
    let P60208 = Prefixed_Name(rdau, "P60208") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60209</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is addenda"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60209">http://rdaregistry.info/Elements/u/P60209</seealso>
    let P60209 = Prefixed_Name(rdau, "P60209") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60210</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as libretto"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60210">http://rdaregistry.info/Elements/u/P60210</seealso>
    let P60210 = Prefixed_Name(rdau, "P60210") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60211</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reviewed in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60211">http://rdaregistry.info/Elements/u/P60211</seealso>
    let P60211 = Prefixed_Name(rdau, "P60211") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60212</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is critiqued in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60212">http://rdaregistry.info/Elements/u/P60212</seealso>
    let P60212 = Prefixed_Name(rdau, "P60212") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60213</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commentary in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60213">http://rdaregistry.info/Elements/u/P60213</seealso>
    let P60213 = Prefixed_Name(rdau, "P60213") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60214</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is imitated as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60214">http://rdaregistry.info/Elements/u/P60214</seealso>
    let P60214 = Prefixed_Name(rdau, "P60214") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60215</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is described in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60215">http://rdaregistry.info/Elements/u/P60215</seealso>
    let P60215 = Prefixed_Name(rdau, "P60215") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60216</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is expanded as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60216">http://rdaregistry.info/Elements/u/P60216</seealso>
    let P60216 = Prefixed_Name(rdau, "P60216") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60217</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60217">http://rdaregistry.info/Elements/u/P60217</seealso>
    let P60217 = Prefixed_Name(rdau, "P60217") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60218</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is evaluated in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60218">http://rdaregistry.info/Elements/u/P60218</seealso>
    let P60218 = Prefixed_Name(rdau, "P60218") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60219</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is analysed in"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60219">http://rdaregistry.info/Elements/u/P60219</seealso>
    let P60219 = Prefixed_Name(rdau, "P60219") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60220</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is prequel"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60220">http://rdaregistry.info/Elements/u/P60220</seealso>
    let P60220 = Prefixed_Name(rdau, "P60220") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60221</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is appendix"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60221">http://rdaregistry.info/Elements/u/P60221</seealso>
    let P60221 = Prefixed_Name(rdau, "P60221") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60222</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is guide"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60222">http://rdaregistry.info/Elements/u/P60222</seealso>
    let P60222 = Prefixed_Name(rdau, "P60222") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60223</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abridgement of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60223">http://rdaregistry.info/Elements/u/P60223</seealso>
    let P60223 = Prefixed_Name(rdau, "P60223") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60224</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abstract of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60224">http://rdaregistry.info/Elements/u/P60224</seealso>
    let P60224 = Prefixed_Name(rdau, "P60224") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60225</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dramatization of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60225">http://rdaregistry.info/Elements/u/P60225</seealso>
    let P60225 = Prefixed_Name(rdau, "P60225") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60226</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is verse adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60226">http://rdaregistry.info/Elements/u/P60226</seealso>
    let P60226 = Prefixed_Name(rdau, "P60226") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60227</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is motion picture adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60227">http://rdaregistry.info/Elements/u/P60227</seealso>
    let P60227 = Prefixed_Name(rdau, "P60227") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60228</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is novelization of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60228">http://rdaregistry.info/Elements/u/P60228</seealso>
    let P60228 = Prefixed_Name(rdau, "P60228") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60229</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60229">http://rdaregistry.info/Elements/u/P60229</seealso>
    let P60229 = Prefixed_Name(rdau, "P60229") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60230</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60230">http://rdaregistry.info/Elements/u/P60230</seealso>
    let P60230 = Prefixed_Name(rdau, "P60230") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60231</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60231">http://rdaregistry.info/Elements/u/P60231</seealso>
    let P60231 = Prefixed_Name(rdau, "P60231") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60232</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is motion picture screenplay based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60232">http://rdaregistry.info/Elements/u/P60232</seealso>
    let P60232 = Prefixed_Name(rdau, "P60232") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60233</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television screenplay based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60233">http://rdaregistry.info/Elements/u/P60233</seealso>
    let P60233 = Prefixed_Name(rdau, "P60233") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60234</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is video screenplay based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60234">http://rdaregistry.info/Elements/u/P60234</seealso>
    let P60234 = Prefixed_Name(rdau, "P60234") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60235</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio script based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60235">http://rdaregistry.info/Elements/u/P60235</seealso>
    let P60235 = Prefixed_Name(rdau, "P60235") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60236</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is video adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60236">http://rdaregistry.info/Elements/u/P60236</seealso>
    let P60236 = Prefixed_Name(rdau, "P60236") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60237</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is bound with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60237">http://rdaregistry.info/Elements/u/P60237</seealso>
    let P60237 = Prefixed_Name(rdau, "P60237") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60238</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digest of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60238">http://rdaregistry.info/Elements/u/P60238</seealso>
    let P60238 = Prefixed_Name(rdau, "P60238") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60239</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is analysis of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60239">http://rdaregistry.info/Elements/u/P60239</seealso>
    let P60239 = Prefixed_Name(rdau, "P60239") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60240</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is series container of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60240">http://rdaregistry.info/Elements/u/P60240</seealso>
    let P60240 = Prefixed_Name(rdau, "P60240") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60241</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60241">http://rdaregistry.info/Elements/u/P60241</seealso>
    let P60241 = Prefixed_Name(rdau, "P60241") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60242</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is arrangement of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60242">http://rdaregistry.info/Elements/u/P60242</seealso>
    let P60242 = Prefixed_Name(rdau, "P60242") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60243</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is free translation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60243">http://rdaregistry.info/Elements/u/P60243</seealso>
    let P60243 = Prefixed_Name(rdau, "P60243") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60244</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is translation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60244">http://rdaregistry.info/Elements/u/P60244</seealso>
    let P60244 = Prefixed_Name(rdau, "P60244") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60245</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is revised as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60245">http://rdaregistry.info/Elements/u/P60245</seealso>
    let P60245 = Prefixed_Name(rdau, "P60245") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60246</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is parodied as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60246">http://rdaregistry.info/Elements/u/P60246</seealso>
    let P60246 = Prefixed_Name(rdau, "P60246") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60247</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is absorbed by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60247">http://rdaregistry.info/Elements/u/P60247</seealso>
    let P60247 = Prefixed_Name(rdau, "P60247") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60248</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is absorbed in part by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60248">http://rdaregistry.info/Elements/u/P60248</seealso>
    let P60248 = Prefixed_Name(rdau, "P60248") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60249</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is container of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60249">http://rdaregistry.info/Elements/u/P60249</seealso>
    let P60249 = Prefixed_Name(rdau, "P60249") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60250</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is derivative"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60250">http://rdaregistry.info/Elements/u/P60250</seealso>
    let P60250 = Prefixed_Name(rdau, "P60250") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60251</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is errata to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60251">http://rdaregistry.info/Elements/u/P60251</seealso>
    let P60251 = Prefixed_Name(rdau, "P60251") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60252</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is guide to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60252">http://rdaregistry.info/Elements/u/P60252</seealso>
    let P60252 = Prefixed_Name(rdau, "P60252") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60253</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is appendix to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60253">http://rdaregistry.info/Elements/u/P60253</seealso>
    let P60253 = Prefixed_Name(rdau, "P60253") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60254</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is illustrations for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60254">http://rdaregistry.info/Elements/u/P60254</seealso>
    let P60254 = Prefixed_Name(rdau, "P60254") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60255</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is evaluation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60255">http://rdaregistry.info/Elements/u/P60255</seealso>
    let P60255 = Prefixed_Name(rdau, "P60255") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60256</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is issued with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60256">http://rdaregistry.info/Elements/u/P60256</seealso>
    let P60256 = Prefixed_Name(rdau, "P60256") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60257</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is on disc with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60257">http://rdaregistry.info/Elements/u/P60257</seealso>
    let P60257 = Prefixed_Name(rdau, "P60257") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60258</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is filmed with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60258">http://rdaregistry.info/Elements/u/P60258</seealso>
    let P60258 = Prefixed_Name(rdau, "P60258") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60259</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is supplement to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60259">http://rdaregistry.info/Elements/u/P60259</seealso>
    let P60259 = Prefixed_Name(rdau, "P60259") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60260</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60260">http://rdaregistry.info/Elements/u/P60260</seealso>
    let P60260 = Prefixed_Name(rdau, "P60260") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60261</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is preceded by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60261">http://rdaregistry.info/Elements/u/P60261</seealso>
    let P60261 = Prefixed_Name(rdau, "P60261") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60262</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is finding aid"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60262">http://rdaregistry.info/Elements/u/P60262</seealso>
    let P60262 = Prefixed_Name(rdau, "P60262") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60263</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is index"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60263">http://rdaregistry.info/Elements/u/P60263</seealso>
    let P60263 = Prefixed_Name(rdau, "P60263") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60264</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60264">http://rdaregistry.info/Elements/u/P60264</seealso>
    let P60264 = Prefixed_Name(rdau, "P60264") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60265</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is motion picture screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60265">http://rdaregistry.info/Elements/u/P60265</seealso>
    let P60265 = Prefixed_Name(rdau, "P60265") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60266</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is musical setting of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60266">http://rdaregistry.info/Elements/u/P60266</seealso>
    let P60266 = Prefixed_Name(rdau, "P60266") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60267</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio script"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60267">http://rdaregistry.info/Elements/u/P60267</seealso>
    let P60267 = Prefixed_Name(rdau, "P60267") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60268</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60268">http://rdaregistry.info/Elements/u/P60268</seealso>
    let P60268 = Prefixed_Name(rdau, "P60268") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60269</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is video screenplay"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60269">http://rdaregistry.info/Elements/u/P60269</seealso>
    let P60269 = Prefixed_Name(rdau, "P60269") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60270</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is libretto"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60270">http://rdaregistry.info/Elements/u/P60270</seealso>
    let P60270 = Prefixed_Name(rdau, "P60270") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60271</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reprinted as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60271">http://rdaregistry.info/Elements/u/P60271</seealso>
    let P60271 = Prefixed_Name(rdau, "P60271") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60272</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reproduced as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60272">http://rdaregistry.info/Elements/u/P60272</seealso>
    let P60272 = Prefixed_Name(rdau, "P60272") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60273</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is paraphrased as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60273">http://rdaregistry.info/Elements/u/P60273</seealso>
    let P60273 = Prefixed_Name(rdau, "P60273") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60274</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is arranged as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60274">http://rdaregistry.info/Elements/u/P60274</seealso>
    let P60274 = Prefixed_Name(rdau, "P60274") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60275</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abridged as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60275">http://rdaregistry.info/Elements/u/P60275</seealso>
    let P60275 = Prefixed_Name(rdau, "P60275") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60276</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is continuation in part of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60276">http://rdaregistry.info/Elements/u/P60276</seealso>
    let P60276 = Prefixed_Name(rdau, "P60276") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60277</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is separated from"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60277">http://rdaregistry.info/Elements/u/P60277</seealso>
    let P60277 = Prefixed_Name(rdau, "P60277") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60278</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is succeeded by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60278">http://rdaregistry.info/Elements/u/P60278</seealso>
    let P60278 = Prefixed_Name(rdau, "P60278") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60279</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digested as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60279">http://rdaregistry.info/Elements/u/P60279</seealso>
    let P60279 = Prefixed_Name(rdau, "P60279") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60280</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is translated as"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60280">http://rdaregistry.info/Elements/u/P60280</seealso>
    let P60280 = Prefixed_Name(rdau, "P60280") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60281</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is supplement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60281">http://rdaregistry.info/Elements/u/P60281</seealso>
    let P60281 = Prefixed_Name(rdau, "P60281") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60282</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay for motion picture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60282">http://rdaregistry.info/Elements/u/P60282</seealso>
    let P60282 = Prefixed_Name(rdau, "P60282") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60283</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay for television program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60283">http://rdaregistry.info/Elements/u/P60283</seealso>
    let P60283 = Prefixed_Name(rdau, "P60283") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60284</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenplay for video"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60284">http://rdaregistry.info/Elements/u/P60284</seealso>
    let P60284 = Prefixed_Name(rdau, "P60284") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60285</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is script for radio program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60285">http://rdaregistry.info/Elements/u/P60285</seealso>
    let P60285 = Prefixed_Name(rdau, "P60285") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60286</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is addenda to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60286">http://rdaregistry.info/Elements/u/P60286</seealso>
    let P60286 = Prefixed_Name(rdau, "P60286") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60287</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is digital transfer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60287">http://rdaregistry.info/Elements/u/P60287</seealso>
    let P60287 = Prefixed_Name(rdau, "P60287") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60288</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is review of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60288">http://rdaregistry.info/Elements/u/P60288</seealso>
    let P60288 = Prefixed_Name(rdau, "P60288") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60289</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is summary of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60289">http://rdaregistry.info/Elements/u/P60289</seealso>
    let P60289 = Prefixed_Name(rdau, "P60289") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60290</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is catalogue of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60290">http://rdaregistry.info/Elements/u/P60290</seealso>
    let P60290 = Prefixed_Name(rdau, "P60290") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60291</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is concordance to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60291">http://rdaregistry.info/Elements/u/P60291</seealso>
    let P60291 = Prefixed_Name(rdau, "P60291") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60292</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is critique of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60292">http://rdaregistry.info/Elements/u/P60292</seealso>
    let P60292 = Prefixed_Name(rdau, "P60292") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60293</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is choreographic adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60293">http://rdaregistry.info/Elements/u/P60293</seealso>
    let P60293 = Prefixed_Name(rdau, "P60293") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60294</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is expanded version of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60294">http://rdaregistry.info/Elements/u/P60294</seealso>
    let P60294 = Prefixed_Name(rdau, "P60294") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60295</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is remake of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60295">http://rdaregistry.info/Elements/u/P60295</seealso>
    let P60295 = Prefixed_Name(rdau, "P60295") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60296</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is paraphrase of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60296">http://rdaregistry.info/Elements/u/P60296</seealso>
    let P60296 = Prefixed_Name(rdau, "P60296") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60297</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is reproduction of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60297">http://rdaregistry.info/Elements/u/P60297</seealso>
    let P60297 = Prefixed_Name(rdau, "P60297") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60298</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commentary on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60298">http://rdaregistry.info/Elements/u/P60298</seealso>
    let P60298 = Prefixed_Name(rdau, "P60298") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60299</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is preservation facsimile of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60299">http://rdaregistry.info/Elements/u/P60299</seealso>
    let P60299 = Prefixed_Name(rdau, "P60299") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60300</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile container of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60300">http://rdaregistry.info/Elements/u/P60300</seealso>
    let P60300 = Prefixed_Name(rdau, "P60300") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60301</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is facsimile of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60301">http://rdaregistry.info/Elements/u/P60301</seealso>
    let P60301 = Prefixed_Name(rdau, "P60301") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60302</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is index to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60302">http://rdaregistry.info/Elements/u/P60302</seealso>
    let P60302 = Prefixed_Name(rdau, "P60302") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60303</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is revision of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60303">http://rdaregistry.info/Elements/u/P60303</seealso>
    let P60303 = Prefixed_Name(rdau, "P60303") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60304</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is libretto based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60304">http://rdaregistry.info/Elements/u/P60304</seealso>
    let P60304 = Prefixed_Name(rdau, "P60304") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60305</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is based on"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60305">http://rdaregistry.info/Elements/u/P60305</seealso>
    let P60305 = Prefixed_Name(rdau, "P60305") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60306</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is continued by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60306">http://rdaregistry.info/Elements/u/P60306</seealso>
    let P60306 = Prefixed_Name(rdau, "P60306") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60307</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is augmentation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60307">http://rdaregistry.info/Elements/u/P60307</seealso>
    let P60307 = Prefixed_Name(rdau, "P60307") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60308</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abstracts for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60308">http://rdaregistry.info/Elements/u/P60308</seealso>
    let P60308 = Prefixed_Name(rdau, "P60308") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60309</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is indexing for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60309">http://rdaregistry.info/Elements/u/P60309</seealso>
    let P60309 = Prefixed_Name(rdau, "P60309") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60310</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is prequel to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60310">http://rdaregistry.info/Elements/u/P60310</seealso>
    let P60310 = Prefixed_Name(rdau, "P60310") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60311</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is imitation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60311">http://rdaregistry.info/Elements/u/P60311</seealso>
    let P60311 = Prefixed_Name(rdau, "P60311") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60312</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is parody of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60312">http://rdaregistry.info/Elements/u/P60312</seealso>
    let P60312 = Prefixed_Name(rdau, "P60312") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60313</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has related resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60313">http://rdaregistry.info/Elements/u/P60313</seealso>
    let P60313 = Prefixed_Name(rdau, "P60313") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60314</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has encoding format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60314">http://rdaregistry.info/Elements/u/P60314</seealso>
    let P60314 = Prefixed_Name(rdau, "P60314") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60315</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numeric designation of a musical resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60315">http://rdaregistry.info/Elements/u/P60315</seealso>
    let P60315 = Prefixed_Name(rdau, "P60315") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60316</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60316">http://rdaregistry.info/Elements/u/P60316</seealso>
    let P60316 = Prefixed_Name(rdau, "P60316") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60317</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is special issue of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60317">http://rdaregistry.info/Elements/u/P60317</seealso>
    let P60317 = Prefixed_Name(rdau, "P60317") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60318</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has form of tactile notation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60318">http://rdaregistry.info/Elements/u/P60318</seealso>
    let P60318 = Prefixed_Name(rdau, "P60318") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60319</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has form of notation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60319">http://rdaregistry.info/Elements/u/P60319</seealso>
    let P60319 = Prefixed_Name(rdau, "P60319") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60320</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has form of notated movement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60320">http://rdaregistry.info/Elements/u/P60320</seealso>
    let P60320 = Prefixed_Name(rdau, "P60320") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60321</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has form of musical notation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60321">http://rdaregistry.info/Elements/u/P60321</seealso>
    let P60321 = Prefixed_Name(rdau, "P60321") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60322</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has script"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60322">http://rdaregistry.info/Elements/u/P60322</seealso>
    let P60322 = Prefixed_Name(rdau, "P60322") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60323</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has digital representation of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60323">http://rdaregistry.info/Elements/u/P60323</seealso>
    let P60323 = Prefixed_Name(rdau, "P60323") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60324</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date associated with the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60324">http://rdaregistry.info/Elements/u/P60324</seealso>
    let P60324 = Prefixed_Name(rdau, "P60324") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60325</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place associated with the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60325">http://rdaregistry.info/Elements/u/P60325</seealso>
    let P60325 = Prefixed_Name(rdau, "P60325") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60326</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has video format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60326">http://rdaregistry.info/Elements/u/P60326</seealso>
    let P60326 = Prefixed_Name(rdau, "P60326") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60327</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60327">http://rdaregistry.info/Elements/u/P60327</seealso>
    let P60327 = Prefixed_Name(rdau, "P60327") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60328</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has series statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60328">http://rdaregistry.info/Elements/u/P60328</seealso>
    let P60328 = Prefixed_Name(rdau, "P60328") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60329</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has edition statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60329">http://rdaregistry.info/Elements/u/P60329</seealso>
    let P60329 = Prefixed_Name(rdau, "P60329") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60330</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has distribution statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60330">http://rdaregistry.info/Elements/u/P60330</seealso>
    let P60330 = Prefixed_Name(rdau, "P60330") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60331</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has manufacture statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60331">http://rdaregistry.info/Elements/u/P60331</seealso>
    let P60331 = Prefixed_Name(rdau, "P60331") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60332</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60332">http://rdaregistry.info/Elements/u/P60332</seealso>
    let P60332 = Prefixed_Name(rdau, "P60332") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60333</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publication statement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60333">http://rdaregistry.info/Elements/u/P60333</seealso>
    let P60333 = Prefixed_Name(rdau, "P60333") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60334</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to a named revision of an edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60334">http://rdaregistry.info/Elements/u/P60334</seealso>
    let P60334 = Prefixed_Name(rdau, "P60334") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60335</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60335">http://rdaregistry.info/Elements/u/P60335</seealso>
    let P60335 = Prefixed_Name(rdau, "P60335") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60336</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60336">http://rdaregistry.info/Elements/u/P60336</seealso>
    let P60336 = Prefixed_Name(rdau, "P60336") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60337</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to the edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60337">http://rdaregistry.info/Elements/u/P60337</seealso>
    let P60337 = Prefixed_Name(rdau, "P60337") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60338</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel statement of responsibility relating to title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60338">http://rdaregistry.info/Elements/u/P60338</seealso>
    let P60338 = Prefixed_Name(rdau, "P60338") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60339</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60339">http://rdaregistry.info/Elements/u/P60339</seealso>
    let P60339 = Prefixed_Name(rdau, "P60339") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60340</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to a named revision of an edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60340">http://rdaregistry.info/Elements/u/P60340</seealso>
    let P60340 = Prefixed_Name(rdau, "P60340") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60341</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60341">http://rdaregistry.info/Elements/u/P60341</seealso>
    let P60341 = Prefixed_Name(rdau, "P60341") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60342</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60342">http://rdaregistry.info/Elements/u/P60342</seealso>
    let P60342 = Prefixed_Name(rdau, "P60342") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60343</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has statement of responsibility relating to the edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60343">http://rdaregistry.info/Elements/u/P60343</seealso>
    let P60343 = Prefixed_Name(rdau, "P60343") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60344</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has emulsion on microfilm and microfiche"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60344">http://rdaregistry.info/Elements/u/P60344</seealso>
    let P60344 = Prefixed_Name(rdau, "P60344") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60345</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has longitude and latitude"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60345">http://rdaregistry.info/Elements/u/P60345</seealso>
    let P60345 = Prefixed_Name(rdau, "P60345") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60346</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has right ascension and declination"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60346">http://rdaregistry.info/Elements/u/P60346</seealso>
    let P60346 = Prefixed_Name(rdau, "P60346") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60347</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has strings of coordinate pairs"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60347">http://rdaregistry.info/Elements/u/P60347</seealso>
    let P60347 = Prefixed_Name(rdau, "P60347") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60348</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has system of organization"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60348">http://rdaregistry.info/Elements/u/P60348</seealso>
    let P60348 = Prefixed_Name(rdau, "P60348") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60349</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has broadcast standard"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60349">http://rdaregistry.info/Elements/u/P60349</seealso>
    let P60349 = Prefixed_Name(rdau, "P60349") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60350</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has digital file characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60350">http://rdaregistry.info/Elements/u/P60350</seealso>
    let P60350 = Prefixed_Name(rdau, "P60350") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60351</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sound characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60351">http://rdaregistry.info/Elements/u/P60351</seealso>
    let P60351 = Prefixed_Name(rdau, "P60351") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60352</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has video characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60352">http://rdaregistry.info/Elements/u/P60352</seealso>
    let P60352 = Prefixed_Name(rdau, "P60352") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60353</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has projection characteristic of motion picture film"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60353">http://rdaregistry.info/Elements/u/P60353</seealso>
    let P60353 = Prefixed_Name(rdau, "P60353") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60354</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as television program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60354">http://rdaregistry.info/Elements/u/P60354</seealso>
    let P60354 = Prefixed_Name(rdau, "P60354") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60355</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has variant title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60355">http://rdaregistry.info/Elements/u/P60355</seealso>
    let P60355 = Prefixed_Name(rdau, "P60355") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60356</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has hereditary title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60356">http://rdaregistry.info/Elements/u/P60356</seealso>
    let P60356 = Prefixed_Name(rdau, "P60356") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60357</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has later title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60357">http://rdaregistry.info/Elements/u/P60357</seealso>
    let P60357 = Prefixed_Name(rdau, "P60357") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60358</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has earlier title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60358">http://rdaregistry.info/Elements/u/P60358</seealso>
    let P60358 = Prefixed_Name(rdau, "P60358") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60359</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has abbreviated title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60359">http://rdaregistry.info/Elements/u/P60359</seealso>
    let P60359 = Prefixed_Name(rdau, "P60359") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60360</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of residence, etc."</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60360">http://rdaregistry.info/Elements/u/P60360</seealso>
    let P60360 = Prefixed_Name(rdau, "P60360") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60361</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as video"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60361">http://rdaregistry.info/Elements/u/P60361</seealso>
    let P60361 = Prefixed_Name(rdau, "P60361") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60362</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has prominent member of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60362">http://rdaregistry.info/Elements/u/P60362</seealso>
    let P60362 = Prefixed_Name(rdau, "P60362") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60363</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60363">http://rdaregistry.info/Elements/u/P60363</seealso>
    let P60363 = Prefixed_Name(rdau, "P60363") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60364</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has designation of a named revision of an edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60364">http://rdaregistry.info/Elements/u/P60364</seealso>
    let P60364 = Prefixed_Name(rdau, "P60364") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60365</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has designation of edition"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60365">http://rdaregistry.info/Elements/u/P60365</seealso>
    let P60365 = Prefixed_Name(rdau, "P60365") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60366</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has name of the place"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60366">http://rdaregistry.info/Elements/u/P60366</seealso>
    let P60366 = Prefixed_Name(rdau, "P60366") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60367</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title of the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60367">http://rdaregistry.info/Elements/u/P60367</seealso>
    let P60367 = Prefixed_Name(rdau, "P60367") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60368</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has name of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60368">http://rdaregistry.info/Elements/u/P60368</seealso>
    let P60368 = Prefixed_Name(rdau, "P60368") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60369</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60369">http://rdaregistry.info/Elements/u/P60369</seealso>
    let P60369 = Prefixed_Name(rdau, "P60369") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60370</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other designation associated with the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60370">http://rdaregistry.info/Elements/u/P60370</seealso>
    let P60370 = Prefixed_Name(rdau, "P60370") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60371</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of added lyrics"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60371">http://rdaregistry.info/Elements/u/P60371</seealso>
    let P60371 = Prefixed_Name(rdau, "P60371") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60372</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has summarization of the content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60372">http://rdaregistry.info/Elements/u/P60372</seealso>
    let P60372 = Prefixed_Name(rdau, "P60372") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60373</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has appellee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60373">http://rdaregistry.info/Elements/u/P60373</seealso>
    let P60373 = Prefixed_Name(rdau, "P60373") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60374</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other agent associated with a resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60374">http://rdaregistry.info/Elements/u/P60374</seealso>
    let P60374 = Prefixed_Name(rdau, "P60374") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60375</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dedicator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60375">http://rdaregistry.info/Elements/u/P60375</seealso>
    let P60375 = Prefixed_Name(rdau, "P60375") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60376</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has curator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60376">http://rdaregistry.info/Elements/u/P60376</seealso>
    let P60376 = Prefixed_Name(rdau, "P60376") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60377</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has surveyor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60377">http://rdaregistry.info/Elements/u/P60377</seealso>
    let P60377 = Prefixed_Name(rdau, "P60377") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60378</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has animator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60378">http://rdaregistry.info/Elements/u/P60378</seealso>
    let P60378 = Prefixed_Name(rdau, "P60378") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60379</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has arranger of music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60379">http://rdaregistry.info/Elements/u/P60379</seealso>
    let P60379 = Prefixed_Name(rdau, "P60379") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60380</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of added text"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60380">http://rdaregistry.info/Elements/u/P60380</seealso>
    let P60380 = Prefixed_Name(rdau, "P60380") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60381</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has draftsman"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60381">http://rdaregistry.info/Elements/u/P60381</seealso>
    let P60381 = Prefixed_Name(rdau, "P60381") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60382</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has transcriber"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60382">http://rdaregistry.info/Elements/u/P60382</seealso>
    let P60382 = Prefixed_Name(rdau, "P60382") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60383</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has musical director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60383">http://rdaregistry.info/Elements/u/P60383</seealso>
    let P60383 = Prefixed_Name(rdau, "P60383") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60384</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has costume designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60384">http://rdaregistry.info/Elements/u/P60384</seealso>
    let P60384 = Prefixed_Name(rdau, "P60384") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60385</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has translator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60385">http://rdaregistry.info/Elements/u/P60385</seealso>
    let P60385 = Prefixed_Name(rdau, "P60385") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60386</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has art director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60386">http://rdaregistry.info/Elements/u/P60386</seealso>
    let P60386 = Prefixed_Name(rdau, "P60386") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60387</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has performer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60387">http://rdaregistry.info/Elements/u/P60387</seealso>
    let P60387 = Prefixed_Name(rdau, "P60387") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60388</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has court reporter"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60388">http://rdaregistry.info/Elements/u/P60388</seealso>
    let P60388 = Prefixed_Name(rdau, "P60388") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60389</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of preface"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60389">http://rdaregistry.info/Elements/u/P60389</seealso>
    let P60389 = Prefixed_Name(rdau, "P60389") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60390</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of added commentary"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60390">http://rdaregistry.info/Elements/u/P60390</seealso>
    let P60390 = Prefixed_Name(rdau, "P60390") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60391</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of introduction"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60391">http://rdaregistry.info/Elements/u/P60391</seealso>
    let P60391 = Prefixed_Name(rdau, "P60391") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60392</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of supplementary textual content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60392">http://rdaregistry.info/Elements/u/P60392</seealso>
    let P60392 = Prefixed_Name(rdau, "P60392") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60393</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has editor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60393">http://rdaregistry.info/Elements/u/P60393</seealso>
    let P60393 = Prefixed_Name(rdau, "P60393") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60394</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has abridger"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60394">http://rdaregistry.info/Elements/u/P60394</seealso>
    let P60394 = Prefixed_Name(rdau, "P60394") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60395</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has recording engineer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60395">http://rdaregistry.info/Elements/u/P60395</seealso>
    let P60395 = Prefixed_Name(rdau, "P60395") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60396</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has illustrator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60396">http://rdaregistry.info/Elements/u/P60396</seealso>
    let P60396 = Prefixed_Name(rdau, "P60396") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60397</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has recordist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60397">http://rdaregistry.info/Elements/u/P60397</seealso>
    let P60397 = Prefixed_Name(rdau, "P60397") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60398</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has contributor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60398">http://rdaregistry.info/Elements/u/P60398</seealso>
    let P60398 = Prefixed_Name(rdau, "P60398") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60399</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has stage director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60399">http://rdaregistry.info/Elements/u/P60399</seealso>
    let P60399 = Prefixed_Name(rdau, "P60399") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60400</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has current owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60400">http://rdaregistry.info/Elements/u/P60400</seealso>
    let P60400 = Prefixed_Name(rdau, "P60400") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60401</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has former owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60401">http://rdaregistry.info/Elements/u/P60401</seealso>
    let P60401 = Prefixed_Name(rdau, "P60401") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60402</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has custodian"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60402">http://rdaregistry.info/Elements/u/P60402</seealso>
    let P60402 = Prefixed_Name(rdau, "P60402") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60404</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has owner"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60404">http://rdaregistry.info/Elements/u/P60404</seealso>
    let P60404 = Prefixed_Name(rdau, "P60404") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60406</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has honouree"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60406">http://rdaregistry.info/Elements/u/P60406</seealso>
    let P60406 = Prefixed_Name(rdau, "P60406") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60407</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has broadcaster"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60407">http://rdaregistry.info/Elements/u/P60407</seealso>
    let P60407 = Prefixed_Name(rdau, "P60407") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60408</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has film distributor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60408">http://rdaregistry.info/Elements/u/P60408</seealso>
    let P60408 = Prefixed_Name(rdau, "P60408") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60409</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has book designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60409">http://rdaregistry.info/Elements/u/P60409</seealso>
    let P60409 = Prefixed_Name(rdau, "P60409") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60410</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has engraver"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60410">http://rdaregistry.info/Elements/u/P60410</seealso>
    let P60410 = Prefixed_Name(rdau, "P60410") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60411</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has braille embosser"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60411">http://rdaregistry.info/Elements/u/P60411</seealso>
    let P60411 = Prefixed_Name(rdau, "P60411") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60412</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has printmaker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60412">http://rdaregistry.info/Elements/u/P60412</seealso>
    let P60412 = Prefixed_Name(rdau, "P60412") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60413</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has caster"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60413">http://rdaregistry.info/Elements/u/P60413</seealso>
    let P60413 = Prefixed_Name(rdau, "P60413") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60414</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has lithographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60414">http://rdaregistry.info/Elements/u/P60414</seealso>
    let P60414 = Prefixed_Name(rdau, "P60414") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60415</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has platemaker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60415">http://rdaregistry.info/Elements/u/P60415</seealso>
    let P60415 = Prefixed_Name(rdau, "P60415") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60416</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has etcher"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60416">http://rdaregistry.info/Elements/u/P60416</seealso>
    let P60416 = Prefixed_Name(rdau, "P60416") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60417</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has collotyper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60417">http://rdaregistry.info/Elements/u/P60417</seealso>
    let P60417 = Prefixed_Name(rdau, "P60417") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60418</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has printer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60418">http://rdaregistry.info/Elements/u/P60418</seealso>
    let P60418 = Prefixed_Name(rdau, "P60418") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60419</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has presenter"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60419">http://rdaregistry.info/Elements/u/P60419</seealso>
    let P60419 = Prefixed_Name(rdau, "P60419") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60420</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has degree supervisor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60420">http://rdaregistry.info/Elements/u/P60420</seealso>
    let P60420 = Prefixed_Name(rdau, "P60420") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60421</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has illuminator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60421">http://rdaregistry.info/Elements/u/P60421</seealso>
    let P60421 = Prefixed_Name(rdau, "P60421") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60422</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has editor of moving image work"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60422">http://rdaregistry.info/Elements/u/P60422</seealso>
    let P60422 = Prefixed_Name(rdau, "P60422") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60423</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has programmer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60423">http://rdaregistry.info/Elements/u/P60423</seealso>
    let P60423 = Prefixed_Name(rdau, "P60423") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60424</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60424">http://rdaregistry.info/Elements/u/P60424</seealso>
    let P60424 = Prefixed_Name(rdau, "P60424") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60425</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has cartographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60425">http://rdaregistry.info/Elements/u/P60425</seealso>
    let P60425 = Prefixed_Name(rdau, "P60425") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60426</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has composer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60426">http://rdaregistry.info/Elements/u/P60426</seealso>
    let P60426 = Prefixed_Name(rdau, "P60426") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60427</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has inventor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60427">http://rdaregistry.info/Elements/u/P60427</seealso>
    let P60427 = Prefixed_Name(rdau, "P60427") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60428</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has compiler"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60428">http://rdaregistry.info/Elements/u/P60428</seealso>
    let P60428 = Prefixed_Name(rdau, "P60428") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60429</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has photographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60429">http://rdaregistry.info/Elements/u/P60429</seealso>
    let P60429 = Prefixed_Name(rdau, "P60429") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60430</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has interviewer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60430">http://rdaregistry.info/Elements/u/P60430</seealso>
    let P60430 = Prefixed_Name(rdau, "P60430") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60431</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has artist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60431">http://rdaregistry.info/Elements/u/P60431</seealso>
    let P60431 = Prefixed_Name(rdau, "P60431") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60432</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has interviewee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60432">http://rdaregistry.info/Elements/u/P60432</seealso>
    let P60432 = Prefixed_Name(rdau, "P60432") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60433</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has choreographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60433">http://rdaregistry.info/Elements/u/P60433</seealso>
    let P60433 = Prefixed_Name(rdau, "P60433") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60434</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has author"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60434">http://rdaregistry.info/Elements/u/P60434</seealso>
    let P60434 = Prefixed_Name(rdau, "P60434") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60435</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has architect"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60435">http://rdaregistry.info/Elements/u/P60435</seealso>
    let P60435 = Prefixed_Name(rdau, "P60435") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60436</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has filmmaker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60436">http://rdaregistry.info/Elements/u/P60436</seealso>
    let P60436 = Prefixed_Name(rdau, "P60436") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60437</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60437">http://rdaregistry.info/Elements/u/P60437</seealso>
    let P60437 = Prefixed_Name(rdau, "P60437") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60438</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has distributor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60438">http://rdaregistry.info/Elements/u/P60438</seealso>
    let P60438 = Prefixed_Name(rdau, "P60438") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60440</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has producer of an unpublished resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60440">http://rdaregistry.info/Elements/u/P60440</seealso>
    let P60440 = Prefixed_Name(rdau, "P60440") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60441</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has producer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60441">http://rdaregistry.info/Elements/u/P60441</seealso>
    let P60441 = Prefixed_Name(rdau, "P60441") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60442</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60442">http://rdaregistry.info/Elements/u/P60442</seealso>
    let P60442 = Prefixed_Name(rdau, "P60442") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60443</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has manufacturer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60443">http://rdaregistry.info/Elements/u/P60443</seealso>
    let P60443 = Prefixed_Name(rdau, "P60443") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60444</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publisher"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60444">http://rdaregistry.info/Elements/u/P60444</seealso>
    let P60444 = Prefixed_Name(rdau, "P60444") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60446</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has minute taker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60446">http://rdaregistry.info/Elements/u/P60446</seealso>
    let P60446 = Prefixed_Name(rdau, "P60446") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60447</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has creator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60447">http://rdaregistry.info/Elements/u/P60447</seealso>
    let P60447 = Prefixed_Name(rdau, "P60447") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60449</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has director"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60449">http://rdaregistry.info/Elements/u/P60449</seealso>
    let P60449 = Prefixed_Name(rdau, "P60449") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60450</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restorationist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60450">http://rdaregistry.info/Elements/u/P60450</seealso>
    let P60450 = Prefixed_Name(rdau, "P60450") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60451</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sponsoring body"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60451">http://rdaregistry.info/Elements/u/P60451</seealso>
    let P60451 = Prefixed_Name(rdau, "P60451") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60452</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has director of photography"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60452">http://rdaregistry.info/Elements/u/P60452</seealso>
    let P60452 = Prefixed_Name(rdau, "P60452") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60454</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has related agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60454">http://rdaregistry.info/Elements/u/P60454</seealso>
    let P60454 = Prefixed_Name(rdau, "P60454") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60455</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dedicatee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60455">http://rdaregistry.info/Elements/u/P60455</seealso>
    let P60455 = Prefixed_Name(rdau, "P60455") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60456</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has addressee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60456">http://rdaregistry.info/Elements/u/P60456</seealso>
    let P60456 = Prefixed_Name(rdau, "P60456") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60457</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has appellant"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60457">http://rdaregistry.info/Elements/u/P60457</seealso>
    let P60457 = Prefixed_Name(rdau, "P60457") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60458</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has binder"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60458">http://rdaregistry.info/Elements/u/P60458</seealso>
    let P60458 = Prefixed_Name(rdau, "P60458") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60459</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has plaintiff"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60459">http://rdaregistry.info/Elements/u/P60459</seealso>
    let P60459 = Prefixed_Name(rdau, "P60459") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60460</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has inscriber"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60460">http://rdaregistry.info/Elements/u/P60460</seealso>
    let P60460 = Prefixed_Name(rdau, "P60460") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60461</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has judge"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60461">http://rdaregistry.info/Elements/u/P60461</seealso>
    let P60461 = Prefixed_Name(rdau, "P60461") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60462</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has defendant"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60462">http://rdaregistry.info/Elements/u/P60462</seealso>
    let P60462 = Prefixed_Name(rdau, "P60462") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60463</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has praeses"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60463">http://rdaregistry.info/Elements/u/P60463</seealso>
    let P60463 = Prefixed_Name(rdau, "P60463") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60464</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has annotator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60464">http://rdaregistry.info/Elements/u/P60464</seealso>
    let P60464 = Prefixed_Name(rdau, "P60464") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60465</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has consultant"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60465">http://rdaregistry.info/Elements/u/P60465</seealso>
    let P60465 = Prefixed_Name(rdau, "P60465") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60466</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has autographer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60466">http://rdaregistry.info/Elements/u/P60466</seealso>
    let P60466 = Prefixed_Name(rdau, "P60466") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60467</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has issuing body"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60467">http://rdaregistry.info/Elements/u/P60467</seealso>
    let P60467 = Prefixed_Name(rdau, "P60467") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60468</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has profession or occupation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60468">http://rdaregistry.info/Elements/u/P60468</seealso>
    let P60468 = Prefixed_Name(rdau, "P60468") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60469</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is electronic reproduction of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60469">http://rdaregistry.info/Elements/u/P60469</seealso>
    let P60469 = Prefixed_Name(rdau, "P60469") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60470</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has note on resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60470">http://rdaregistry.info/Elements/u/P60470</seealso>
    let P60470 = Prefixed_Name(rdau, "P60470") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60471</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60471">http://rdaregistry.info/Elements/u/P60471</seealso>
    let P60471 = Prefixed_Name(rdau, "P60471") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60472</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has epoch"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60472">http://rdaregistry.info/Elements/u/P60472</seealso>
    let P60472 = Prefixed_Name(rdau, "P60472") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60473</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has landscape architect"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60473">http://rdaregistry.info/Elements/u/P60473</seealso>
    let P60473 = Prefixed_Name(rdau, "P60473") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60474</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is finding aid for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60474">http://rdaregistry.info/Elements/u/P60474</seealso>
    let P60474 = Prefixed_Name(rdau, "P60474") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60475</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sculptor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60475">http://rdaregistry.info/Elements/u/P60475</seealso>
    let P60475 = Prefixed_Name(rdau, "P60475") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60476</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has screenwriter"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60476">http://rdaregistry.info/Elements/u/P60476</seealso>
    let P60476 = Prefixed_Name(rdau, "P60476") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60477</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has lyricist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60477">http://rdaregistry.info/Elements/u/P60477</seealso>
    let P60477 = Prefixed_Name(rdau, "P60477") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60478</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has librettist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60478">http://rdaregistry.info/Elements/u/P60478</seealso>
    let P60478 = Prefixed_Name(rdau, "P60478") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60479</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is replacement in part of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60479">http://rdaregistry.info/Elements/u/P60479</seealso>
    let P60479 = Prefixed_Name(rdau, "P60479") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60480</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is replacement of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60480">http://rdaregistry.info/Elements/u/P60480</seealso>
    let P60480 = Prefixed_Name(rdau, "P60480") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60481</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has special playback characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60481">http://rdaregistry.info/Elements/u/P60481</seealso>
    let P60481 = Prefixed_Name(rdau, "P60481") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60482</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has associated institution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60482">http://rdaregistry.info/Elements/u/P60482</seealso>
    let P60482 = Prefixed_Name(rdau, "P60482") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60483</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has granting institution or faculty"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60483">http://rdaregistry.info/Elements/u/P60483</seealso>
    let P60483 = Prefixed_Name(rdau, "P60483") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60484</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has agent history"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60484">http://rdaregistry.info/Elements/u/P60484</seealso>
    let P60484 = Prefixed_Name(rdau, "P60484") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60485</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has supplementary content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60485">http://rdaregistry.info/Elements/u/P60485</seealso>
    let P60485 = Prefixed_Name(rdau, "P60485") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60486</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has illustrative content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60486">http://rdaregistry.info/Elements/u/P60486</seealso>
    let P60486 = Prefixed_Name(rdau, "P60486") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60487</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has accessibility content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60487">http://rdaregistry.info/Elements/u/P60487</seealso>
    let P60487 = Prefixed_Name(rdau, "P60487") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60488</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has format of notated music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60488">http://rdaregistry.info/Elements/u/P60488</seealso>
    let P60488 = Prefixed_Name(rdau, "P60488") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60489</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dissertation or thesis information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60489">http://rdaregistry.info/Elements/u/P60489</seealso>
    let P60489 = Prefixed_Name(rdau, "P60489") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60490</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has contact information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60490">http://rdaregistry.info/Elements/u/P60490</seealso>
    let P60490 = Prefixed_Name(rdau, "P60490") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60491</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has history of the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60491">http://rdaregistry.info/Elements/u/P60491</seealso>
    let P60491 = Prefixed_Name(rdau, "P60491") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60492</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has biographical information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60492">http://rdaregistry.info/Elements/u/P60492</seealso>
    let P60492 = Prefixed_Name(rdau, "P60492") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60493</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other title information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60493">http://rdaregistry.info/Elements/u/P60493</seealso>
    let P60493 = Prefixed_Name(rdau, "P60493") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60494</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other title information of series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60494">http://rdaregistry.info/Elements/u/P60494</seealso>
    let P60494 = Prefixed_Name(rdau, "P60494") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60495</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other title information of subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60495">http://rdaregistry.info/Elements/u/P60495</seealso>
    let P60495 = Prefixed_Name(rdau, "P60495") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60496</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restrictions on access"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60496">http://rdaregistry.info/Elements/u/P60496</seealso>
    let P60496 = Prefixed_Name(rdau, "P60496") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60497</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has restrictions on use"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60497">http://rdaregistry.info/Elements/u/P60497</seealso>
    let P60497 = Prefixed_Name(rdau, "P60497") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60498</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has other details of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60498">http://rdaregistry.info/Elements/u/P60498</seealso>
    let P60498 = Prefixed_Name(rdau, "P60498") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60499</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numeric and/or alphabetic designation of first issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60499">http://rdaregistry.info/Elements/u/P60499</seealso>
    let P60499 = Prefixed_Name(rdau, "P60499") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60500</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numeric and/or alphabetic designation of last issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60500">http://rdaregistry.info/Elements/u/P60500</seealso>
    let P60500 = Prefixed_Name(rdau, "P60500") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60501</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has chronological designation of first issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60501">http://rdaregistry.info/Elements/u/P60501</seealso>
    let P60501 = Prefixed_Name(rdau, "P60501") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60502</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has chronological designation of last issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60502">http://rdaregistry.info/Elements/u/P60502</seealso>
    let P60502 = Prefixed_Name(rdau, "P60502") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60503</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is split into"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60503">http://rdaregistry.info/Elements/u/P60503</seealso>
    let P60503 = Prefixed_Name(rdau, "P60503") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60504</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is merged to form"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60504">http://rdaregistry.info/Elements/u/P60504</seealso>
    let P60504 = Prefixed_Name(rdau, "P60504") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60505</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is merger of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60505">http://rdaregistry.info/Elements/u/P60505</seealso>
    let P60505 = Prefixed_Name(rdau, "P60505") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60506</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has equinox"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60506">http://rdaregistry.info/Elements/u/P60506</seealso>
    let P60506 = Prefixed_Name(rdau, "P60506") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60507</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel other title information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60507">http://rdaregistry.info/Elements/u/P60507</seealso>
    let P60507 = Prefixed_Name(rdau, "P60507") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60508</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel other title information of series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60508">http://rdaregistry.info/Elements/u/P60508</seealso>
    let P60508 = Prefixed_Name(rdau, "P60508") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60509</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel other title information of subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60509">http://rdaregistry.info/Elements/u/P60509</seealso>
    let P60509 = Prefixed_Name(rdau, "P60509") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60510</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has additional scale information"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60510">http://rdaregistry.info/Elements/u/P60510</seealso>
    let P60510 = Prefixed_Name(rdau, "P60510") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60511</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has uniform resource locator"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60511">http://rdaregistry.info/Elements/u/P60511</seealso>
    let P60511 = Prefixed_Name(rdau, "P60511") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60512</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has address of the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60512">http://rdaregistry.info/Elements/u/P60512</seealso>
    let P60512 = Prefixed_Name(rdau, "P60512") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60513</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has layout"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60513">http://rdaregistry.info/Elements/u/P60513</seealso>
    let P60513 = Prefixed_Name(rdau, "P60513") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60514</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has year degree granted"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60514">http://rdaregistry.info/Elements/u/P60514</seealso>
    let P60514 = Prefixed_Name(rdau, "P60514") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60515</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60515">http://rdaregistry.info/Elements/u/P60515</seealso>
    let P60515 = Prefixed_Name(rdau, "P60515") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60516</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title proper of series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60516">http://rdaregistry.info/Elements/u/P60516</seealso>
    let P60516 = Prefixed_Name(rdau, "P60516") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60517</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has title proper of subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60517">http://rdaregistry.info/Elements/u/P60517</seealso>
    let P60517 = Prefixed_Name(rdau, "P60517") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60518</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has coverage of the content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60518">http://rdaregistry.info/Elements/u/P60518</seealso>
    let P60518 = Prefixed_Name(rdau, "P60518") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60519</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has resolution"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60519">http://rdaregistry.info/Elements/u/P60519</seealso>
    let P60519 = Prefixed_Name(rdau, "P60519") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60520</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has intended audience"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60520">http://rdaregistry.info/Elements/u/P60520</seealso>
    let P60520 = Prefixed_Name(rdau, "P60520") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60521</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has terms of availability"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60521">http://rdaregistry.info/Elements/u/P60521</seealso>
    let P60521 = Prefixed_Name(rdau, "P60521") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60522</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has track configuration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60522">http://rdaregistry.info/Elements/u/P60522</seealso>
    let P60522 = Prefixed_Name(rdau, "P60522") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60523</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of origin of the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60523">http://rdaregistry.info/Elements/u/P60523</seealso>
    let P60523 = Prefixed_Name(rdau, "P60523") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60524</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of establishment"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60524">http://rdaregistry.info/Elements/u/P60524</seealso>
    let P60524 = Prefixed_Name(rdau, "P60524") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60525</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of termination"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60525">http://rdaregistry.info/Elements/u/P60525</seealso>
    let P60525 = Prefixed_Name(rdau, "P60525") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60526</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of conference, etc."</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60526">http://rdaregistry.info/Elements/u/P60526</seealso>
    let P60526 = Prefixed_Name(rdau, "P60526") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60527</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60527">http://rdaregistry.info/Elements/u/P60527</seealso>
    let P60527 = Prefixed_Name(rdau, "P60527") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60528</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has equipment or system requirement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60528">http://rdaregistry.info/Elements/u/P60528</seealso>
    let P60528 = Prefixed_Name(rdau, "P60528") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60529</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has presentation format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60529">http://rdaregistry.info/Elements/u/P60529</seealso>
    let P60529 = Prefixed_Name(rdau, "P60529") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60530</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has fuller form of name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60530">http://rdaregistry.info/Elements/u/P60530</seealso>
    let P60530 = Prefixed_Name(rdau, "P60530") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60531</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has gender"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60531">http://rdaregistry.info/Elements/u/P60531</seealso>
    let P60531 = Prefixed_Name(rdau, "P60531") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60532</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has groove characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60532">http://rdaregistry.info/Elements/u/P60532</seealso>
    let P60532 = Prefixed_Name(rdau, "P60532") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60533</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has numbering of serials"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60533">http://rdaregistry.info/Elements/u/P60533</seealso>
    let P60533 = Prefixed_Name(rdau, "P60533") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60534</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has ISSN of series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60534">http://rdaregistry.info/Elements/u/P60534</seealso>
    let P60534 = Prefixed_Name(rdau, "P60534") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60535</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has ISSN of subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60535">http://rdaregistry.info/Elements/u/P60535</seealso>
    let P60535 = Prefixed_Name(rdau, "P60535") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60536</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has medium of performance"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60536">http://rdaregistry.info/Elements/u/P60536</seealso>
    let P60536 = Prefixed_Name(rdau, "P60536") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60537</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has medium of performance of musical content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60537">http://rdaregistry.info/Elements/u/P60537</seealso>
    let P60537 = Prefixed_Name(rdau, "P60537") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60538</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has frequency"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60538">http://rdaregistry.info/Elements/u/P60538</seealso>
    let P60538 = Prefixed_Name(rdau, "P60538") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60539</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dimensions"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60539">http://rdaregistry.info/Elements/u/P60539</seealso>
    let P60539 = Prefixed_Name(rdau, "P60539") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60540</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dimensions of map, etc."</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60540">http://rdaregistry.info/Elements/u/P60540</seealso>
    let P60540 = Prefixed_Name(rdau, "P60540") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60541</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has dimensions of still image"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60541">http://rdaregistry.info/Elements/u/P60541</seealso>
    let P60541 = Prefixed_Name(rdau, "P60541") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60542</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has projection of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60542">http://rdaregistry.info/Elements/u/P60542</seealso>
    let P60542 = Prefixed_Name(rdau, "P60542") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60543</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has type of recording"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60543">http://rdaregistry.info/Elements/u/P60543</seealso>
    let P60543 = Prefixed_Name(rdau, "P60543") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60544</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has distributor’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60544">http://rdaregistry.info/Elements/u/P60544</seealso>
    let P60544 = Prefixed_Name(rdau, "P60544") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60545</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has producer’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60545">http://rdaregistry.info/Elements/u/P60545</seealso>
    let P60545 = Prefixed_Name(rdau, "P60545") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60546</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has manufacturer’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60546">http://rdaregistry.info/Elements/u/P60546</seealso>
    let P60546 = Prefixed_Name(rdau, "P60546") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60547</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publisher’s name"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60547">http://rdaregistry.info/Elements/u/P60547</seealso>
    let P60547 = Prefixed_Name(rdau, "P60547") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60548</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has preferred name for the place"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60548">http://rdaregistry.info/Elements/u/P60548</seealso>
    let P60548 = Prefixed_Name(rdau, "P60548") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60549</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has preferred name for the agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60549">http://rdaregistry.info/Elements/u/P60549</seealso>
    let P60549 = Prefixed_Name(rdau, "P60549") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60550</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has extent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60550">http://rdaregistry.info/Elements/u/P60550</seealso>
    let P60550 = Prefixed_Name(rdau, "P60550") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60551</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has file size"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60551">http://rdaregistry.info/Elements/u/P60551</seealso>
    let P60551 = Prefixed_Name(rdau, "P60551") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60552</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has configuration of playback channels"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60552">http://rdaregistry.info/Elements/u/P60552</seealso>
    let P60552 = Prefixed_Name(rdau, "P60552") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60553</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has tape configuration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60553">http://rdaregistry.info/Elements/u/P60553</seealso>
    let P60553 = Prefixed_Name(rdau, "P60553") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60554</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has mount"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60554">http://rdaregistry.info/Elements/u/P60554</seealso>
    let P60554 = Prefixed_Name(rdau, "P60554") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60555</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place and date of capture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60555">http://rdaregistry.info/Elements/u/P60555</seealso>
    let P60555 = Prefixed_Name(rdau, "P60555") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60556</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of capture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60556">http://rdaregistry.info/Elements/u/P60556</seealso>
    let P60556 = Prefixed_Name(rdau, "P60556") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60557</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has duration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60557">http://rdaregistry.info/Elements/u/P60557</seealso>
    let P60557 = Prefixed_Name(rdau, "P60557") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60558</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has colour content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60558">http://rdaregistry.info/Elements/u/P60558</seealso>
    let P60558 = Prefixed_Name(rdau, "P60558") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60559</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sound content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60559">http://rdaregistry.info/Elements/u/P60559</seealso>
    let P60559 = Prefixed_Name(rdau, "P60559") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60560</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production method"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60560">http://rdaregistry.info/Elements/u/P60560</seealso>
    let P60560 = Prefixed_Name(rdau, "P60560") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60561</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production method for tactile resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60561">http://rdaregistry.info/Elements/u/P60561</seealso>
    let P60561 = Prefixed_Name(rdau, "P60561") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60562</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has production method for manuscript"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60562">http://rdaregistry.info/Elements/u/P60562</seealso>
    let P60562 = Prefixed_Name(rdau, "P60562") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60563</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has horizontal scale of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60563">http://rdaregistry.info/Elements/u/P60563</seealso>
    let P60563 = Prefixed_Name(rdau, "P60563") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60564</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has scale of still image or three-dimensional form"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60564">http://rdaregistry.info/Elements/u/P60564</seealso>
    let P60564 = Prefixed_Name(rdau, "P60564") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60565</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has scale"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60565">http://rdaregistry.info/Elements/u/P60565</seealso>
    let P60565 = Prefixed_Name(rdau, "P60565") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60566</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has aspect ratio"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60566">http://rdaregistry.info/Elements/u/P60566</seealso>
    let P60566 = Prefixed_Name(rdau, "P60566") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60567</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation of audio recording"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60567">http://rdaregistry.info/Elements/u/P60567</seealso>
    let P60567 = Prefixed_Name(rdau, "P60567") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60568</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60568">http://rdaregistry.info/Elements/u/P60568</seealso>
    let P60568 = Prefixed_Name(rdau, "P60568") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60569</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation of digital resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60569">http://rdaregistry.info/Elements/u/P60569</seealso>
    let P60569 = Prefixed_Name(rdau, "P60569") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60570</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation of motion picture film"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60570">http://rdaregistry.info/Elements/u/P60570</seealso>
    let P60570 = Prefixed_Name(rdau, "P60570") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60571</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation of videotape"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60571">http://rdaregistry.info/Elements/u/P60571</seealso>
    let P60571 = Prefixed_Name(rdau, "P60571") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60572</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has generation of microform"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60572">http://rdaregistry.info/Elements/u/P60572</seealso>
    let P60572 = Prefixed_Name(rdau, "P60572") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60573</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has polarity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60573">http://rdaregistry.info/Elements/u/P60573</seealso>
    let P60573 = Prefixed_Name(rdau, "P60573") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60574</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is absorption of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60574">http://rdaregistry.info/Elements/u/P60574</seealso>
    let P60574 = Prefixed_Name(rdau, "P60574") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60575</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is absorption in part of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60575">http://rdaregistry.info/Elements/u/P60575</seealso>
    let P60575 = Prefixed_Name(rdau, "P60575") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60576</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is continuation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60576">http://rdaregistry.info/Elements/u/P60576</seealso>
    let P60576 = Prefixed_Name(rdau, "P60576") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60577</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is sequel to"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60577">http://rdaregistry.info/Elements/u/P60577</seealso>
    let P60577 = Prefixed_Name(rdau, "P60577") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60578</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has book format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60578">http://rdaregistry.info/Elements/u/P60578</seealso>
    let P60578 = Prefixed_Name(rdau, "P60578") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60579</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has vertical scale of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60579">http://rdaregistry.info/Elements/u/P60579</seealso>
    let P60579 = Prefixed_Name(rdau, "P60579") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60580</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has key"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60580">http://rdaregistry.info/Elements/u/P60580</seealso>
    let P60580 = Prefixed_Name(rdau, "P60580") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60581</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has reduction ratio"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60581">http://rdaregistry.info/Elements/u/P60581</seealso>
    let P60581 = Prefixed_Name(rdau, "P60581") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60582</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has font size"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60582">http://rdaregistry.info/Elements/u/P60582</seealso>
    let P60582 = Prefixed_Name(rdau, "P60582") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60583</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has immediate source of acquisition of resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60583">http://rdaregistry.info/Elements/u/P60583</seealso>
    let P60583 = Prefixed_Name(rdau, "P60583") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60584</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has nature of the content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60584">http://rdaregistry.info/Elements/u/P60584</seealso>
    let P60584 = Prefixed_Name(rdau, "P60584") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60585</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has projection speed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60585">http://rdaregistry.info/Elements/u/P60585</seealso>
    let P60585 = Prefixed_Name(rdau, "P60585") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60586</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has playing speed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60586">http://rdaregistry.info/Elements/u/P60586</seealso>
    let P60586 = Prefixed_Name(rdau, "P60586") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60587</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has encoded bitrate"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60587">http://rdaregistry.info/Elements/u/P60587</seealso>
    let P60587 = Prefixed_Name(rdau, "P60587") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60588</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has preferred title for the resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60588">http://rdaregistry.info/Elements/u/P60588</seealso>
    let P60588 = Prefixed_Name(rdau, "P60588") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60589</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title proper"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60589">http://rdaregistry.info/Elements/u/P60589</seealso>
    let P60589 = Prefixed_Name(rdau, "P60589") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60590</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title proper of series"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60590">http://rdaregistry.info/Elements/u/P60590</seealso>
    let P60590 = Prefixed_Name(rdau, "P60590") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60591</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has parallel title proper of subseries"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60591">http://rdaregistry.info/Elements/u/P60591</seealso>
    let P60591 = Prefixed_Name(rdau, "P60591") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60592</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of death"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60592">http://rdaregistry.info/Elements/u/P60592</seealso>
    let P60592 = Prefixed_Name(rdau, "P60592") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60593</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has place of birth"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60593">http://rdaregistry.info/Elements/u/P60593</seealso>
    let P60593 = Prefixed_Name(rdau, "P60593") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60594</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has recording medium"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60594">http://rdaregistry.info/Elements/u/P60594</seealso>
    let P60594 = Prefixed_Name(rdau, "P60594") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60595</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60595">http://rdaregistry.info/Elements/u/P60595</seealso>
    let P60595 = Prefixed_Name(rdau, "P60595") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60596</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has base material"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60596">http://rdaregistry.info/Elements/u/P60596</seealso>
    let P60596 = Prefixed_Name(rdau, "P60596") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60597</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has key title"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60597">http://rdaregistry.info/Elements/u/P60597</seealso>
    let P60597 = Prefixed_Name(rdau, "P60597") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60598</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of death"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60598">http://rdaregistry.info/Elements/u/P60598</seealso>
    let P60598 = Prefixed_Name(rdau, "P60598") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60599</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has date of birth"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60599">http://rdaregistry.info/Elements/u/P60599</seealso>
    let P60599 = Prefixed_Name(rdau, "P60599") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60600</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of added lyrics of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60600">http://rdaregistry.info/Elements/u/P60600</seealso>
    let P60600 = Prefixed_Name(rdau, "P60600") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60601</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is appellee of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60601">http://rdaregistry.info/Elements/u/P60601</seealso>
    let P60601 = Prefixed_Name(rdau, "P60601") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60602</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is other agent associated with a resource of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60602">http://rdaregistry.info/Elements/u/P60602</seealso>
    let P60602 = Prefixed_Name(rdau, "P60602") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60603</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dedicator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60603">http://rdaregistry.info/Elements/u/P60603</seealso>
    let P60603 = Prefixed_Name(rdau, "P60603") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60604</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is curator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60604">http://rdaregistry.info/Elements/u/P60604</seealso>
    let P60604 = Prefixed_Name(rdau, "P60604") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60605</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is surveyor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60605">http://rdaregistry.info/Elements/u/P60605</seealso>
    let P60605 = Prefixed_Name(rdau, "P60605") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60606</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is animator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60606">http://rdaregistry.info/Elements/u/P60606</seealso>
    let P60606 = Prefixed_Name(rdau, "P60606") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60607</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is arranger of music of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60607">http://rdaregistry.info/Elements/u/P60607</seealso>
    let P60607 = Prefixed_Name(rdau, "P60607") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60608</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of added text of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60608">http://rdaregistry.info/Elements/u/P60608</seealso>
    let P60608 = Prefixed_Name(rdau, "P60608") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60609</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is draftsman of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60609">http://rdaregistry.info/Elements/u/P60609</seealso>
    let P60609 = Prefixed_Name(rdau, "P60609") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60610</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is transcriber of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60610">http://rdaregistry.info/Elements/u/P60610</seealso>
    let P60610 = Prefixed_Name(rdau, "P60610") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60611</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is musical director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60611">http://rdaregistry.info/Elements/u/P60611</seealso>
    let P60611 = Prefixed_Name(rdau, "P60611") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60612</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is costume designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60612">http://rdaregistry.info/Elements/u/P60612</seealso>
    let P60612 = Prefixed_Name(rdau, "P60612") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60613</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is translator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60613">http://rdaregistry.info/Elements/u/P60613</seealso>
    let P60613 = Prefixed_Name(rdau, "P60613") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60614</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is art director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60614">http://rdaregistry.info/Elements/u/P60614</seealso>
    let P60614 = Prefixed_Name(rdau, "P60614") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60615</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is performer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60615">http://rdaregistry.info/Elements/u/P60615</seealso>
    let P60615 = Prefixed_Name(rdau, "P60615") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60616</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is court reporter of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60616">http://rdaregistry.info/Elements/u/P60616</seealso>
    let P60616 = Prefixed_Name(rdau, "P60616") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60617</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of introduction of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60617">http://rdaregistry.info/Elements/u/P60617</seealso>
    let P60617 = Prefixed_Name(rdau, "P60617") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60618</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of added commentary of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60618">http://rdaregistry.info/Elements/u/P60618</seealso>
    let P60618 = Prefixed_Name(rdau, "P60618") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60619</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of afterword of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60619">http://rdaregistry.info/Elements/u/P60619</seealso>
    let P60619 = Prefixed_Name(rdau, "P60619") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60620</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of postface of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60620">http://rdaregistry.info/Elements/u/P60620</seealso>
    let P60620 = Prefixed_Name(rdau, "P60620") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60621</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is editor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60621">http://rdaregistry.info/Elements/u/P60621</seealso>
    let P60621 = Prefixed_Name(rdau, "P60621") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60622</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is abridger of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60622">http://rdaregistry.info/Elements/u/P60622</seealso>
    let P60622 = Prefixed_Name(rdau, "P60622") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60623</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is recording engineer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60623">http://rdaregistry.info/Elements/u/P60623</seealso>
    let P60623 = Prefixed_Name(rdau, "P60623") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60624</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is illustrator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60624">http://rdaregistry.info/Elements/u/P60624</seealso>
    let P60624 = Prefixed_Name(rdau, "P60624") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60625</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is recordist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60625">http://rdaregistry.info/Elements/u/P60625</seealso>
    let P60625 = Prefixed_Name(rdau, "P60625") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60626</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is contributor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60626">http://rdaregistry.info/Elements/u/P60626</seealso>
    let P60626 = Prefixed_Name(rdau, "P60626") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60627</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is stage director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60627">http://rdaregistry.info/Elements/u/P60627</seealso>
    let P60627 = Prefixed_Name(rdau, "P60627") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60628</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is current owner of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60628">http://rdaregistry.info/Elements/u/P60628</seealso>
    let P60628 = Prefixed_Name(rdau, "P60628") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60629</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has employee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60629">http://rdaregistry.info/Elements/u/P60629</seealso>
    let P60629 = Prefixed_Name(rdau, "P60629") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60630</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is former owner of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60630">http://rdaregistry.info/Elements/u/P60630</seealso>
    let P60630 = Prefixed_Name(rdau, "P60630") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60631</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is custodian of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60631">http://rdaregistry.info/Elements/u/P60631</seealso>
    let P60631 = Prefixed_Name(rdau, "P60631") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60632</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is owner of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60632">http://rdaregistry.info/Elements/u/P60632</seealso>
    let P60632 = Prefixed_Name(rdau, "P60632") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60633</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has incumbent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60633">http://rdaregistry.info/Elements/u/P60633</seealso>
    let P60633 = Prefixed_Name(rdau, "P60633") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60634</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is honouree of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60634">http://rdaregistry.info/Elements/u/P60634</seealso>
    let P60634 = Prefixed_Name(rdau, "P60634") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60635</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is broadcaster of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60635">http://rdaregistry.info/Elements/u/P60635</seealso>
    let P60635 = Prefixed_Name(rdau, "P60635") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60636</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is film distributor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60636">http://rdaregistry.info/Elements/u/P60636</seealso>
    let P60636 = Prefixed_Name(rdau, "P60636") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60637</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is book designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60637">http://rdaregistry.info/Elements/u/P60637</seealso>
    let P60637 = Prefixed_Name(rdau, "P60637") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60638</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is engraver of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60638">http://rdaregistry.info/Elements/u/P60638</seealso>
    let P60638 = Prefixed_Name(rdau, "P60638") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60639</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is braille embosser of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60639">http://rdaregistry.info/Elements/u/P60639</seealso>
    let P60639 = Prefixed_Name(rdau, "P60639") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60640</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is printmaker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60640">http://rdaregistry.info/Elements/u/P60640</seealso>
    let P60640 = Prefixed_Name(rdau, "P60640") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60641</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is caster of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60641">http://rdaregistry.info/Elements/u/P60641</seealso>
    let P60641 = Prefixed_Name(rdau, "P60641") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60642</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is lithographer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60642">http://rdaregistry.info/Elements/u/P60642</seealso>
    let P60642 = Prefixed_Name(rdau, "P60642") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60643</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is platemaker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60643">http://rdaregistry.info/Elements/u/P60643</seealso>
    let P60643 = Prefixed_Name(rdau, "P60643") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60644</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is etcher of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60644">http://rdaregistry.info/Elements/u/P60644</seealso>
    let P60644 = Prefixed_Name(rdau, "P60644") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60645</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is collotyper of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60645">http://rdaregistry.info/Elements/u/P60645</seealso>
    let P60645 = Prefixed_Name(rdau, "P60645") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60646</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is printer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60646">http://rdaregistry.info/Elements/u/P60646</seealso>
    let P60646 = Prefixed_Name(rdau, "P60646") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60647</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is presenter of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60647">http://rdaregistry.info/Elements/u/P60647</seealso>
    let P60647 = Prefixed_Name(rdau, "P60647") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60648</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has member of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60648">http://rdaregistry.info/Elements/u/P60648</seealso>
    let P60648 = Prefixed_Name(rdau, "P60648") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60649</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is degree supervisor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60649">http://rdaregistry.info/Elements/u/P60649</seealso>
    let P60649 = Prefixed_Name(rdau, "P60649") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60650</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is illuminator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60650">http://rdaregistry.info/Elements/u/P60650</seealso>
    let P60650 = Prefixed_Name(rdau, "P60650") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60651</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is editor of moving image work of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60651">http://rdaregistry.info/Elements/u/P60651</seealso>
    let P60651 = Prefixed_Name(rdau, "P60651") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60652</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is programmer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60652">http://rdaregistry.info/Elements/u/P60652</seealso>
    let P60652 = Prefixed_Name(rdau, "P60652") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60653</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60653">http://rdaregistry.info/Elements/u/P60653</seealso>
    let P60653 = Prefixed_Name(rdau, "P60653") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60654</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is cartographer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60654">http://rdaregistry.info/Elements/u/P60654</seealso>
    let P60654 = Prefixed_Name(rdau, "P60654") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60655</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is composer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60655">http://rdaregistry.info/Elements/u/P60655</seealso>
    let P60655 = Prefixed_Name(rdau, "P60655") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60656</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is inventor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60656">http://rdaregistry.info/Elements/u/P60656</seealso>
    let P60656 = Prefixed_Name(rdau, "P60656") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60657</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is compiler of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60657">http://rdaregistry.info/Elements/u/P60657</seealso>
    let P60657 = Prefixed_Name(rdau, "P60657") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60658</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is photographer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60658">http://rdaregistry.info/Elements/u/P60658</seealso>
    let P60658 = Prefixed_Name(rdau, "P60658") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60659</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is interviewer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60659">http://rdaregistry.info/Elements/u/P60659</seealso>
    let P60659 = Prefixed_Name(rdau, "P60659") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60660</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is artist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60660">http://rdaregistry.info/Elements/u/P60660</seealso>
    let P60660 = Prefixed_Name(rdau, "P60660") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60661</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is interviewee of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60661">http://rdaregistry.info/Elements/u/P60661</seealso>
    let P60661 = Prefixed_Name(rdau, "P60661") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60662</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is choreographer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60662">http://rdaregistry.info/Elements/u/P60662</seealso>
    let P60662 = Prefixed_Name(rdau, "P60662") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60663</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is author of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60663">http://rdaregistry.info/Elements/u/P60663</seealso>
    let P60663 = Prefixed_Name(rdau, "P60663") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60664</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is architect of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60664">http://rdaregistry.info/Elements/u/P60664</seealso>
    let P60664 = Prefixed_Name(rdau, "P60664") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60665</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is filmmaker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60665">http://rdaregistry.info/Elements/u/P60665</seealso>
    let P60665 = Prefixed_Name(rdau, "P60665") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60666</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is production designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60666">http://rdaregistry.info/Elements/u/P60666</seealso>
    let P60666 = Prefixed_Name(rdau, "P60666") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60667</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is distributor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60667">http://rdaregistry.info/Elements/u/P60667</seealso>
    let P60667 = Prefixed_Name(rdau, "P60667") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60668</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is producer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60668">http://rdaregistry.info/Elements/u/P60668</seealso>
    let P60668 = Prefixed_Name(rdau, "P60668") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60669</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is manufacturer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60669">http://rdaregistry.info/Elements/u/P60669</seealso>
    let P60669 = Prefixed_Name(rdau, "P60669") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60670</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is publisher of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60670">http://rdaregistry.info/Elements/u/P60670</seealso>
    let P60670 = Prefixed_Name(rdau, "P60670") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60671</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is minute taker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60671">http://rdaregistry.info/Elements/u/P60671</seealso>
    let P60671 = Prefixed_Name(rdau, "P60671") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60672</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is creator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60672">http://rdaregistry.info/Elements/u/P60672</seealso>
    let P60672 = Prefixed_Name(rdau, "P60672") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60673</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is director of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60673">http://rdaregistry.info/Elements/u/P60673</seealso>
    let P60673 = Prefixed_Name(rdau, "P60673") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60674</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is restorationist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60674">http://rdaregistry.info/Elements/u/P60674</seealso>
    let P60674 = Prefixed_Name(rdau, "P60674") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60675</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is sponsoring body of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60675">http://rdaregistry.info/Elements/u/P60675</seealso>
    let P60675 = Prefixed_Name(rdau, "P60675") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60676</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sponsor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60676">http://rdaregistry.info/Elements/u/P60676</seealso>
    let P60676 = Prefixed_Name(rdau, "P60676") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60678</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is director of photography of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60678">http://rdaregistry.info/Elements/u/P60678</seealso>
    let P60678 = Prefixed_Name(rdau, "P60678") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60679</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has employer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60679">http://rdaregistry.info/Elements/u/P60679</seealso>
    let P60679 = Prefixed_Name(rdau, "P60679") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60680</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has hierarchical superior"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60680">http://rdaregistry.info/Elements/u/P60680</seealso>
    let P60680 = Prefixed_Name(rdau, "P60680") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60681</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has hierarchical subordinate"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60681">http://rdaregistry.info/Elements/u/P60681</seealso>
    let P60681 = Prefixed_Name(rdau, "P60681") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60682</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has mergee"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60682">http://rdaregistry.info/Elements/u/P60682</seealso>
    let P60682 = Prefixed_Name(rdau, "P60682") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60683</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has predecessor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60683">http://rdaregistry.info/Elements/u/P60683</seealso>
    let P60683 = Prefixed_Name(rdau, "P60683") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60684</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has product of merger"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60684">http://rdaregistry.info/Elements/u/P60684</seealso>
    let P60684 = Prefixed_Name(rdau, "P60684") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60685</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has product of split"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60685">http://rdaregistry.info/Elements/u/P60685</seealso>
    let P60685 = Prefixed_Name(rdau, "P60685") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60686</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has successor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60686">http://rdaregistry.info/Elements/u/P60686</seealso>
    let P60686 = Prefixed_Name(rdau, "P60686") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60687</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has founded entity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60687">http://rdaregistry.info/Elements/u/P60687</seealso>
    let P60687 = Prefixed_Name(rdau, "P60687") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60688</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sponsored entity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60688">http://rdaregistry.info/Elements/u/P60688</seealso>
    let P60688 = Prefixed_Name(rdau, "P60688") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60689</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is dedicatee of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60689">http://rdaregistry.info/Elements/u/P60689</seealso>
    let P60689 = Prefixed_Name(rdau, "P60689") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60690</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is addressee of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60690">http://rdaregistry.info/Elements/u/P60690</seealso>
    let P60690 = Prefixed_Name(rdau, "P60690") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60691</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is appellant of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60691">http://rdaregistry.info/Elements/u/P60691</seealso>
    let P60691 = Prefixed_Name(rdau, "P60691") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60692</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is binder of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60692">http://rdaregistry.info/Elements/u/P60692</seealso>
    let P60692 = Prefixed_Name(rdau, "P60692") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60693</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is plaintiff of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60693">http://rdaregistry.info/Elements/u/P60693</seealso>
    let P60693 = Prefixed_Name(rdau, "P60693") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60694</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has founder"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60694">http://rdaregistry.info/Elements/u/P60694</seealso>
    let P60694 = Prefixed_Name(rdau, "P60694") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60695</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is inscriber of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60695">http://rdaregistry.info/Elements/u/P60695</seealso>
    let P60695 = Prefixed_Name(rdau, "P60695") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60696</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is judge of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60696">http://rdaregistry.info/Elements/u/P60696</seealso>
    let P60696 = Prefixed_Name(rdau, "P60696") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60697</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has member"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60697">http://rdaregistry.info/Elements/u/P60697</seealso>
    let P60697 = Prefixed_Name(rdau, "P60697") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60698</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is defendant of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60698">http://rdaregistry.info/Elements/u/P60698</seealso>
    let P60698 = Prefixed_Name(rdau, "P60698") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60699</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is praeses of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60699">http://rdaregistry.info/Elements/u/P60699</seealso>
    let P60699 = Prefixed_Name(rdau, "P60699") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60700</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is annotator of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60700">http://rdaregistry.info/Elements/u/P60700</seealso>
    let P60700 = Prefixed_Name(rdau, "P60700") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60701</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is consultant of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60701">http://rdaregistry.info/Elements/u/P60701</seealso>
    let P60701 = Prefixed_Name(rdau, "P60701") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60702</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is autographer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60702">http://rdaregistry.info/Elements/u/P60702</seealso>
    let P60702 = Prefixed_Name(rdau, "P60702") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60703</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is issuing body of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60703">http://rdaregistry.info/Elements/u/P60703</seealso>
    let P60703 = Prefixed_Name(rdau, "P60703") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60704</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is landscape architect of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60704">http://rdaregistry.info/Elements/u/P60704</seealso>
    let P60704 = Prefixed_Name(rdau, "P60704") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60705</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is sculptor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60705">http://rdaregistry.info/Elements/u/P60705</seealso>
    let P60705 = Prefixed_Name(rdau, "P60705") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60706</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is screenwriter of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60706">http://rdaregistry.info/Elements/u/P60706</seealso>
    let P60706 = Prefixed_Name(rdau, "P60706") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60707</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is lyricist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60707">http://rdaregistry.info/Elements/u/P60707</seealso>
    let P60707 = Prefixed_Name(rdau, "P60707") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60708</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is librettist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60708">http://rdaregistry.info/Elements/u/P60708</seealso>
    let P60708 = Prefixed_Name(rdau, "P60708") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60709</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has accompanying resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60709">http://rdaregistry.info/Elements/u/P60709</seealso>
    let P60709 = Prefixed_Name(rdau, "P60709") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60710</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has derivative resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60710">http://rdaregistry.info/Elements/u/P60710</seealso>
    let P60710 = Prefixed_Name(rdau, "P60710") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60711</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60711">http://rdaregistry.info/Elements/u/P60711</seealso>
    let P60711 = Prefixed_Name(rdau, "P60711") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60712</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has equivalent resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60712">http://rdaregistry.info/Elements/u/P60712</seealso>
    let P60712 = Prefixed_Name(rdau, "P60712") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60713</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sequential resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60713">http://rdaregistry.info/Elements/u/P60713</seealso>
    let P60713 = Prefixed_Name(rdau, "P60713") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60714</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has whole-part resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60714">http://rdaregistry.info/Elements/u/P60714</seealso>
    let P60714 = Prefixed_Name(rdau, "P60714") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60715</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of afterword"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60715">http://rdaregistry.info/Elements/u/P60715</seealso>
    let P60715 = Prefixed_Name(rdau, "P60715") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60716</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of postface"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60716">http://rdaregistry.info/Elements/u/P60716</seealso>
    let P60716 = Prefixed_Name(rdau, "P60716") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60717</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of preface of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60717">http://rdaregistry.info/Elements/u/P60717</seealso>
    let P60717 = Prefixed_Name(rdau, "P60717") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60718</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of supplementary textual content of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60718">http://rdaregistry.info/Elements/u/P60718</seealso>
    let P60718 = Prefixed_Name(rdau, "P60718") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60719</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is musical theatre adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60719">http://rdaregistry.info/Elements/u/P60719</seealso>
    let P60719 = Prefixed_Name(rdau, "P60719") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60720</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is opera adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60720">http://rdaregistry.info/Elements/u/P60720</seealso>
    let P60720 = Prefixed_Name(rdau, "P60720") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60721</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as musical theatre"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60721">http://rdaregistry.info/Elements/u/P60721</seealso>
    let P60721 = Prefixed_Name(rdau, "P60721") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60722</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as opera"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60722">http://rdaregistry.info/Elements/u/P60722</seealso>
    let P60722 = Prefixed_Name(rdau, "P60722") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60723</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60723">http://rdaregistry.info/Elements/u/P60723</seealso>
    let P60723 = Prefixed_Name(rdau, "P60723") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60724</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60724">http://rdaregistry.info/Elements/u/P60724</seealso>
    let P60724 = Prefixed_Name(rdau, "P60724") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60725</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is video music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60725">http://rdaregistry.info/Elements/u/P60725</seealso>
    let P60725 = Prefixed_Name(rdau, "P60725") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60726</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music for video"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60726">http://rdaregistry.info/Elements/u/P60726</seealso>
    let P60726 = Prefixed_Name(rdau, "P60726") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60727</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is television program music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60727">http://rdaregistry.info/Elements/u/P60727</seealso>
    let P60727 = Prefixed_Name(rdau, "P60727") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60728</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music for television program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60728">http://rdaregistry.info/Elements/u/P60728</seealso>
    let P60728 = Prefixed_Name(rdau, "P60728") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60729</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is radio program music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60729">http://rdaregistry.info/Elements/u/P60729</seealso>
    let P60729 = Prefixed_Name(rdau, "P60729") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60730</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music for radio program"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60730">http://rdaregistry.info/Elements/u/P60730</seealso>
    let P60730 = Prefixed_Name(rdau, "P60730") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60731</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is music for motion picture"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60731">http://rdaregistry.info/Elements/u/P60731</seealso>
    let P60731 = Prefixed_Name(rdau, "P60731") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60732</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is motion picture music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60732">http://rdaregistry.info/Elements/u/P60732</seealso>
    let P60732 = Prefixed_Name(rdau, "P60732") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60733</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has predecessor of split"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60733">http://rdaregistry.info/Elements/u/P60733</seealso>
    let P60733 = Prefixed_Name(rdau, "P60733") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60736</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has component of a merger"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60736">http://rdaregistry.info/Elements/u/P60736</seealso>
    let P60736 = Prefixed_Name(rdau, "P60736") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60737</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has officiated agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60737">http://rdaregistry.info/Elements/u/P60737</seealso>
    let P60737 = Prefixed_Name(rdau, "P60737") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60738</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has broader affiliated agent"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60738">http://rdaregistry.info/Elements/u/P60738</seealso>
    let P60738 = Prefixed_Name(rdau, "P60738") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60739</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has local affiliate"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60739">http://rdaregistry.info/Elements/u/P60739</seealso>
    let P60739 = Prefixed_Name(rdau, "P60739") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60740</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is choreography"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60740">http://rdaregistry.info/Elements/u/P60740</seealso>
    let P60740 = Prefixed_Name(rdau, "P60740") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60741</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is choreography for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60741">http://rdaregistry.info/Elements/u/P60741</seealso>
    let P60741 = Prefixed_Name(rdau, "P60741") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60742</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as graphic novel"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60742">http://rdaregistry.info/Elements/u/P60742</seealso>
    let P60742 = Prefixed_Name(rdau, "P60742") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60743</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is graphic novelization of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60743">http://rdaregistry.info/Elements/u/P60743</seealso>
    let P60743 = Prefixed_Name(rdau, "P60743") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60744</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as video game"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60744">http://rdaregistry.info/Elements/u/P60744</seealso>
    let P60744 = Prefixed_Name(rdau, "P60744") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60745</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is video game adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60745">http://rdaregistry.info/Elements/u/P60745</seealso>
    let P60745 = Prefixed_Name(rdau, "P60745") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60746</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has papermaker"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60746">http://rdaregistry.info/Elements/u/P60746</seealso>
    let P60746 = Prefixed_Name(rdau, "P60746") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60747</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is papermaker of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60747">http://rdaregistry.info/Elements/u/P60747</seealso>
    let P60747 = Prefixed_Name(rdau, "P60747") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60748</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has visual effects provider"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60748">http://rdaregistry.info/Elements/u/P60748</seealso>
    let P60748 = Prefixed_Name(rdau, "P60748") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60749</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has special effects provider"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60749">http://rdaregistry.info/Elements/u/P60749</seealso>
    let P60749 = Prefixed_Name(rdau, "P60749") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60750</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has letterer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60750">http://rdaregistry.info/Elements/u/P60750</seealso>
    let P60750 = Prefixed_Name(rdau, "P60750") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60751</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has rapporteur"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60751">http://rdaregistry.info/Elements/u/P60751</seealso>
    let P60751 = Prefixed_Name(rdau, "P60751") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60752</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has calligrapher"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60752">http://rdaregistry.info/Elements/u/P60752</seealso>
    let P60752 = Prefixed_Name(rdau, "P60752") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60753</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has book artist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60753">http://rdaregistry.info/Elements/u/P60753</seealso>
    let P60753 = Prefixed_Name(rdau, "P60753") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60754</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is visual effects provider of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60754">http://rdaregistry.info/Elements/u/P60754</seealso>
    let P60754 = Prefixed_Name(rdau, "P60754") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60755</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is special effects provider of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60755">http://rdaregistry.info/Elements/u/P60755</seealso>
    let P60755 = Prefixed_Name(rdau, "P60755") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60756</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is letterer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60756">http://rdaregistry.info/Elements/u/P60756</seealso>
    let P60756 = Prefixed_Name(rdau, "P60756") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60757</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is rapporteur of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60757">http://rdaregistry.info/Elements/u/P60757</seealso>
    let P60757 = Prefixed_Name(rdau, "P60757") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60758</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is calligrapher of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60758">http://rdaregistry.info/Elements/u/P60758</seealso>
    let P60758 = Prefixed_Name(rdau, "P60758") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60759</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is book artist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60759">http://rdaregistry.info/Elements/u/P60759</seealso>
    let P60759 = Prefixed_Name(rdau, "P60759") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60760</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of aspect ratio"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60760">http://rdaregistry.info/Elements/u/P60760</seealso>
    let P60760 = Prefixed_Name(rdau, "P60760") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60761</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of colour content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60761">http://rdaregistry.info/Elements/u/P60761</seealso>
    let P60761 = Prefixed_Name(rdau, "P60761") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60762</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of form of musical notation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60762">http://rdaregistry.info/Elements/u/P60762</seealso>
    let P60762 = Prefixed_Name(rdau, "P60762") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60763</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of form of notated movement"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60763">http://rdaregistry.info/Elements/u/P60763</seealso>
    let P60763 = Prefixed_Name(rdau, "P60763") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60764</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of format of notated music"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60764">http://rdaregistry.info/Elements/u/P60764</seealso>
    let P60764 = Prefixed_Name(rdau, "P60764") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60765</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of form of tactile notation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60765">http://rdaregistry.info/Elements/u/P60765</seealso>
    let P60765 = Prefixed_Name(rdau, "P60765") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60766</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of script"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60766">http://rdaregistry.info/Elements/u/P60766</seealso>
    let P60766 = Prefixed_Name(rdau, "P60766") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60767</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of applied material"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60767">http://rdaregistry.info/Elements/u/P60767</seealso>
    let P60767 = Prefixed_Name(rdau, "P60767") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60768</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of base material"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60768">http://rdaregistry.info/Elements/u/P60768</seealso>
    let P60768 = Prefixed_Name(rdau, "P60768") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60769</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of book format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60769">http://rdaregistry.info/Elements/u/P60769</seealso>
    let P60769 = Prefixed_Name(rdau, "P60769") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60770</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of broadcast standard"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60770">http://rdaregistry.info/Elements/u/P60770</seealso>
    let P60770 = Prefixed_Name(rdau, "P60770") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60771</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of configuration of playback channels"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60771">http://rdaregistry.info/Elements/u/P60771</seealso>
    let P60771 = Prefixed_Name(rdau, "P60771") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60772</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of digital file characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60772">http://rdaregistry.info/Elements/u/P60772</seealso>
    let P60772 = Prefixed_Name(rdau, "P60772") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60773</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of digital representation of cartographic content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60773">http://rdaregistry.info/Elements/u/P60773</seealso>
    let P60773 = Prefixed_Name(rdau, "P60773") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60774</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of emulsion on microfilm and microfiche"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60774">http://rdaregistry.info/Elements/u/P60774</seealso>
    let P60774 = Prefixed_Name(rdau, "P60774") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60775</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of encoding format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60775">http://rdaregistry.info/Elements/u/P60775</seealso>
    let P60775 = Prefixed_Name(rdau, "P60775") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60776</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of file type"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60776">http://rdaregistry.info/Elements/u/P60776</seealso>
    let P60776 = Prefixed_Name(rdau, "P60776") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60777</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of font size"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60777">http://rdaregistry.info/Elements/u/P60777</seealso>
    let P60777 = Prefixed_Name(rdau, "P60777") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60778</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation of audio recording"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60778">http://rdaregistry.info/Elements/u/P60778</seealso>
    let P60778 = Prefixed_Name(rdau, "P60778") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60779</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation of digital resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60779">http://rdaregistry.info/Elements/u/P60779</seealso>
    let P60779 = Prefixed_Name(rdau, "P60779") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60780</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation of microform"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60780">http://rdaregistry.info/Elements/u/P60780</seealso>
    let P60780 = Prefixed_Name(rdau, "P60780") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60781</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation of motion picture film"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60781">http://rdaregistry.info/Elements/u/P60781</seealso>
    let P60781 = Prefixed_Name(rdau, "P60781") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60782</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation of videotape"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60782">http://rdaregistry.info/Elements/u/P60782</seealso>
    let P60782 = Prefixed_Name(rdau, "P60782") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60783</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of groove characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60783">http://rdaregistry.info/Elements/u/P60783</seealso>
    let P60783 = Prefixed_Name(rdau, "P60783") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60784</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of layout"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60784">http://rdaregistry.info/Elements/u/P60784</seealso>
    let P60784 = Prefixed_Name(rdau, "P60784") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60785</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of mount"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60785">http://rdaregistry.info/Elements/u/P60785</seealso>
    let P60785 = Prefixed_Name(rdau, "P60785") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60786</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of playing speed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60786">http://rdaregistry.info/Elements/u/P60786</seealso>
    let P60786 = Prefixed_Name(rdau, "P60786") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60787</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of polarity"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60787">http://rdaregistry.info/Elements/u/P60787</seealso>
    let P60787 = Prefixed_Name(rdau, "P60787") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60788</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of presentation format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60788">http://rdaregistry.info/Elements/u/P60788</seealso>
    let P60788 = Prefixed_Name(rdau, "P60788") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60789</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of production method"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60789">http://rdaregistry.info/Elements/u/P60789</seealso>
    let P60789 = Prefixed_Name(rdau, "P60789") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60790</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of production method for manuscript"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60790">http://rdaregistry.info/Elements/u/P60790</seealso>
    let P60790 = Prefixed_Name(rdau, "P60790") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60791</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of production method for tactile resource"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60791">http://rdaregistry.info/Elements/u/P60791</seealso>
    let P60791 = Prefixed_Name(rdau, "P60791") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60792</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of projection characteristic of motion picture film"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60792">http://rdaregistry.info/Elements/u/P60792</seealso>
    let P60792 = Prefixed_Name(rdau, "P60792") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60793</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of projection speed"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60793">http://rdaregistry.info/Elements/u/P60793</seealso>
    let P60793 = Prefixed_Name(rdau, "P60793") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60794</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of recording medium"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60794">http://rdaregistry.info/Elements/u/P60794</seealso>
    let P60794 = Prefixed_Name(rdau, "P60794") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60795</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of reduction ratio"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60795">http://rdaregistry.info/Elements/u/P60795</seealso>
    let P60795 = Prefixed_Name(rdau, "P60795") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60796</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of sound characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60796">http://rdaregistry.info/Elements/u/P60796</seealso>
    let P60796 = Prefixed_Name(rdau, "P60796") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60797</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of special playback characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60797">http://rdaregistry.info/Elements/u/P60797</seealso>
    let P60797 = Prefixed_Name(rdau, "P60797") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60798</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of tape configuration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60798">http://rdaregistry.info/Elements/u/P60798</seealso>
    let P60798 = Prefixed_Name(rdau, "P60798") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60799</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of track configuration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60799">http://rdaregistry.info/Elements/u/P60799</seealso>
    let P60799 = Prefixed_Name(rdau, "P60799") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60800</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of type of recording"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60800">http://rdaregistry.info/Elements/u/P60800</seealso>
    let P60800 = Prefixed_Name(rdau, "P60800") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60801</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of video characteristic"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60801">http://rdaregistry.info/Elements/u/P60801</seealso>
    let P60801 = Prefixed_Name(rdau, "P60801") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60802</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of video format"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60802">http://rdaregistry.info/Elements/u/P60802</seealso>
    let P60802 = Prefixed_Name(rdau, "P60802") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60803</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of generation"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60803">http://rdaregistry.info/Elements/u/P60803</seealso>
    let P60803 = Prefixed_Name(rdau, "P60803") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60804</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of illustrative content"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60804">http://rdaregistry.info/Elements/u/P60804</seealso>
    let P60804 = Prefixed_Name(rdau, "P60804") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60805</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has subject"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60805">http://rdaregistry.info/Elements/u/P60805</seealso>
    let P60805 = Prefixed_Name(rdau, "P60805") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60806</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is subject of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60806">http://rdaregistry.info/Elements/u/P60806</seealso>
    let P60806 = Prefixed_Name(rdau, "P60806") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60807</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has graduate"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60807">http://rdaregistry.info/Elements/u/P60807</seealso>
    let P60807 = Prefixed_Name(rdau, "P60807") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60808</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is graduate of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60808">http://rdaregistry.info/Elements/u/P60808</seealso>
    let P60808 = Prefixed_Name(rdau, "P60808") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60809</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has writer of foreword"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60809">http://rdaregistry.info/Elements/u/P60809</seealso>
    let P60809 = Prefixed_Name(rdau, "P60809") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60810</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is writer of foreword of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60810">http://rdaregistry.info/Elements/u/P60810</seealso>
    let P60810 = Prefixed_Name(rdau, "P60810") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60811</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has sound designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60811">http://rdaregistry.info/Elements/u/P60811</seealso>
    let P60811 = Prefixed_Name(rdau, "P60811") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60812</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is sound designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60812">http://rdaregistry.info/Elements/u/P60812</seealso>
    let P60812 = Prefixed_Name(rdau, "P60812") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60813</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has lighting designer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60813">http://rdaregistry.info/Elements/u/P60813</seealso>
    let P60813 = Prefixed_Name(rdau, "P60813") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60814</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is lighting designer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60814">http://rdaregistry.info/Elements/u/P60814</seealso>
    let P60814 = Prefixed_Name(rdau, "P60814") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60815</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has degree committee member"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60815">http://rdaregistry.info/Elements/u/P60815</seealso>
    let P60815 = Prefixed_Name(rdau, "P60815") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60816</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is degree committee member of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60816">http://rdaregistry.info/Elements/u/P60816</seealso>
    let P60816 = Prefixed_Name(rdau, "P60816") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60817</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is producer of an unpublished resource of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60817">http://rdaregistry.info/Elements/u/P60817</seealso>
    let P60817 = Prefixed_Name(rdau, "P60817") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60818</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has alternative chronological designation of first issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60818">http://rdaregistry.info/Elements/u/P60818</seealso>
    let P60818 = Prefixed_Name(rdau, "P60818") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60819</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has alternative chronological designation of last issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60819">http://rdaregistry.info/Elements/u/P60819</seealso>
    let P60819 = Prefixed_Name(rdau, "P60819") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60820</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has alternative numeric and/or alphabetic designation of first issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60820">http://rdaregistry.info/Elements/u/P60820</seealso>
    let P60820 = Prefixed_Name(rdau, "P60820") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60821</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has alternative numeric and/or alphabetic designation of last issue or part of sequence"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60821">http://rdaregistry.info/Elements/u/P60821</seealso>
    let P60821 = Prefixed_Name(rdau, "P60821") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60822</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has scope of usage"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60822">http://rdaregistry.info/Elements/u/P60822</seealso>
    let P60822 = Prefixed_Name(rdau, "P60822") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60823</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has details of duration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60823">http://rdaregistry.info/Elements/u/P60823</seealso>
    let P60823 = Prefixed_Name(rdau, "P60823") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60824</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has on-screen participant"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60824">http://rdaregistry.info/Elements/u/P60824</seealso>
    let P60824 = Prefixed_Name(rdau, "P60824") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60825</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is on-screen participant of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60825">http://rdaregistry.info/Elements/u/P60825</seealso>
    let P60825 = Prefixed_Name(rdau, "P60825") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60826</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has commissioning body"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60826">http://rdaregistry.info/Elements/u/P60826</seealso>
    let P60826 = Prefixed_Name(rdau, "P60826") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60827</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commissioning body of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60827">http://rdaregistry.info/Elements/u/P60827</seealso>
    let P60827 = Prefixed_Name(rdau, "P60827") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60828</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has software developer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60828">http://rdaregistry.info/Elements/u/P60828</seealso>
    let P60828 = Prefixed_Name(rdau, "P60828") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60829</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is software developer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60829">http://rdaregistry.info/Elements/u/P60829</seealso>
    let P60829 = Prefixed_Name(rdau, "P60829") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60830</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is oratorio adaptation of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60830">http://rdaregistry.info/Elements/u/P60830</seealso>
    let P60830 = Prefixed_Name(rdau, "P60830") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60831</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is adapted as oratorio"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60831">http://rdaregistry.info/Elements/u/P60831</seealso>
    let P60831 = Prefixed_Name(rdau, "P60831") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60832</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is inspired by"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60832">http://rdaregistry.info/Elements/u/P60832</seealso>
    let P60832 = Prefixed_Name(rdau, "P60832") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60833</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is inspiration for"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60833">http://rdaregistry.info/Elements/u/P60833</seealso>
    let P60833 = Prefixed_Name(rdau, "P60833") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60834</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has participant in a treaty"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60834">http://rdaregistry.info/Elements/u/P60834</seealso>
    let P60834 = Prefixed_Name(rdau, "P60834") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60835</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is participant in a treaty of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60835">http://rdaregistry.info/Elements/u/P60835</seealso>
    let P60835 = Prefixed_Name(rdau, "P60835") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60836</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has researcher"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60836">http://rdaregistry.info/Elements/u/P60836</seealso>
    let P60836 = Prefixed_Name(rdau, "P60836") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60837</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is researcher of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60837">http://rdaregistry.info/Elements/u/P60837</seealso>
    let P60837 = Prefixed_Name(rdau, "P60837") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60838</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has colourist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60838">http://rdaregistry.info/Elements/u/P60838</seealso>
    let P60838 = Prefixed_Name(rdau, "P60838") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60839</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is colourist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60839">http://rdaregistry.info/Elements/u/P60839</seealso>
    let P60839 = Prefixed_Name(rdau, "P60839") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60840</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has make-up artist"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60840">http://rdaregistry.info/Elements/u/P60840</seealso>
    let P60840 = Prefixed_Name(rdau, "P60840") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60841</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is make-up artist of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60841">http://rdaregistry.info/Elements/u/P60841</seealso>
    let P60841 = Prefixed_Name(rdau, "P60841") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60842</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has choral conductor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60842">http://rdaregistry.info/Elements/u/P60842</seealso>
    let P60842 = Prefixed_Name(rdau, "P60842") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60843</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is choral conductor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60843">http://rdaregistry.info/Elements/u/P60843</seealso>
    let P60843 = Prefixed_Name(rdau, "P60843") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60844</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has instrumental conductor"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60844">http://rdaregistry.info/Elements/u/P60844</seealso>
    let P60844 = Prefixed_Name(rdau, "P60844") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60845</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is instrumental conductor of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60845">http://rdaregistry.info/Elements/u/P60845</seealso>
    let P60845 = Prefixed_Name(rdau, "P60845") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60846</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has commemoration"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60846">http://rdaregistry.info/Elements/u/P60846</seealso>
    let P60846 = Prefixed_Name(rdau, "P60846") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60847</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is commemoration of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60847">http://rdaregistry.info/Elements/u/P60847</seealso>
    let P60847 = Prefixed_Name(rdau, "P60847") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60848</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has referential resource relationship with"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60848">http://rdaregistry.info/Elements/u/P60848</seealso>
    let P60848 = Prefixed_Name(rdau, "P60848") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60849</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has organizer"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60849">http://rdaregistry.info/Elements/u/P60849</seealso>
    let P60849 = Prefixed_Name(rdau, "P60849") |> PrefixedName
    /// <summary>
    ///   <para>rdau:P60850</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is organizer of"</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/P60850">http://rdaregistry.info/Elements/u/P60850</seealso>
    let P60850 = Prefixed_Name(rdau, "P60850") |> PrefixedName

    /// <summary>
    ///   <para>rdau:abbreviatedTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abbreviatedTitle.en">http://rdaregistry.info/Elements/u/abbreviatedTitle.en</seealso>
    let ``abbreviatedTitle.en`` =
        Prefixed_Name(rdau, "abbreviatedTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:abridgedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abridgedAs.en">http://rdaregistry.info/Elements/u/abridgedAs.en</seealso>
    let ``abridgedAs.en`` = Prefixed_Name(rdau, "abridgedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abridgementOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abridgementOf.en">http://rdaregistry.info/Elements/u/abridgementOf.en</seealso>
    let ``abridgementOf.en`` = Prefixed_Name(rdau, "abridgementOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abridger.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abridger.en">http://rdaregistry.info/Elements/u/abridger.en</seealso>
    let ``abridger.en`` = Prefixed_Name(rdau, "abridger.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abridgerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abridgerOf.en">http://rdaregistry.info/Elements/u/abridgerOf.en</seealso>
    let ``abridgerOf.en`` = Prefixed_Name(rdau, "abridgerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:absorbedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/absorbedBy.en">http://rdaregistry.info/Elements/u/absorbedBy.en</seealso>
    let ``absorbedBy.en`` = Prefixed_Name(rdau, "absorbedBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:absorbedInPartBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/absorbedInPartBy.en">http://rdaregistry.info/Elements/u/absorbedInPartBy.en</seealso>
    let ``absorbedInPartBy.en`` =
        Prefixed_Name(rdau, "absorbedInPartBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:absorptionInPartOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/absorptionInPartOf.en">http://rdaregistry.info/Elements/u/absorptionInPartOf.en</seealso>
    let ``absorptionInPartOf.en`` =
        Prefixed_Name(rdau, "absorptionInPartOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:absorptionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/absorptionOf.en">http://rdaregistry.info/Elements/u/absorptionOf.en</seealso>
    let ``absorptionOf.en`` = Prefixed_Name(rdau, "absorptionOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abstractOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abstractOf.en">http://rdaregistry.info/Elements/u/abstractOf.en</seealso>
    let ``abstractOf.en`` = Prefixed_Name(rdau, "abstractOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abstractedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abstractedAs.en">http://rdaregistry.info/Elements/u/abstractedAs.en</seealso>
    let ``abstractedAs.en`` = Prefixed_Name(rdau, "abstractedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abstractedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abstractedIn.en">http://rdaregistry.info/Elements/u/abstractedIn.en</seealso>
    let ``abstractedIn.en`` = Prefixed_Name(rdau, "abstractedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:abstractsFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/abstractsFor.en">http://rdaregistry.info/Elements/u/abstractsFor.en</seealso>
    let ``abstractsFor.en`` = Prefixed_Name(rdau, "abstractsFor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:academicDegree.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/academicDegree.en">http://rdaregistry.info/Elements/u/academicDegree.en</seealso>
    let ``academicDegree.en`` = Prefixed_Name(rdau, "academicDegree.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:accessibilityContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/accessibilityContent.en">http://rdaregistry.info/Elements/u/accessibilityContent.en</seealso>
    let ``accessibilityContent.en`` =
        Prefixed_Name(rdau, "accessibilityContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:accompaniedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/accompaniedBy.en">http://rdaregistry.info/Elements/u/accompaniedBy.en</seealso>
    let ``accompaniedBy.en`` = Prefixed_Name(rdau, "accompaniedBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:accompanyingResourceRelationshipWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/accompanyingResourceRelationshipWith.en">http://rdaregistry.info/Elements/u/accompanyingResourceRelationshipWith.en</seealso>
    let ``accompanyingResourceRelationshipWith.en`` =
        Prefixed_Name(rdau, "accompanyingResourceRelationshipWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:actor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/actor.en">http://rdaregistry.info/Elements/u/actor.en</seealso>
    let ``actor.en`` = Prefixed_Name(rdau, "actor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:actorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/actorOf.en">http://rdaregistry.info/Elements/u/actorOf.en</seealso>
    let ``actorOf.en`` = Prefixed_Name(rdau, "actorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:adaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptationOf.en">http://rdaregistry.info/Elements/u/adaptationOf.en</seealso>
    let ``adaptationOf.en`` = Prefixed_Name(rdau, "adaptationOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:adaptedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAs.en">http://rdaregistry.info/Elements/u/adaptedAs.en</seealso>
    let ``adaptedAs.en`` = Prefixed_Name(rdau, "adaptedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsAMotionPicture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsAMotionPicture.en">http://rdaregistry.info/Elements/u/adaptedAsAMotionPicture.en</seealso>
    let ``adaptedAsAMotionPicture.en`` =
        Prefixed_Name(rdau, "adaptedAsAMotionPicture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsAMotionPictureScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsAMotionPictureScreenplay.en">http://rdaregistry.info/Elements/u/adaptedAsAMotionPictureScreenplay.en</seealso>
    let ``adaptedAsAMotionPictureScreenplay.en`` =
        Prefixed_Name(rdau, "adaptedAsAMotionPictureScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsARadioProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsARadioProgram.en">http://rdaregistry.info/Elements/u/adaptedAsARadioProgram.en</seealso>
    let ``adaptedAsARadioProgram.en`` =
        Prefixed_Name(rdau, "adaptedAsARadioProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsARadioScript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsARadioScript.en">http://rdaregistry.info/Elements/u/adaptedAsARadioScript.en</seealso>
    let ``adaptedAsARadioScript.en`` =
        Prefixed_Name(rdau, "adaptedAsARadioScript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsAScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsAScreenplay.en">http://rdaregistry.info/Elements/u/adaptedAsAScreenplay.en</seealso>
    let ``adaptedAsAScreenplay.en`` =
        Prefixed_Name(rdau, "adaptedAsAScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsATelevisionProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsATelevisionProgram.en">http://rdaregistry.info/Elements/u/adaptedAsATelevisionProgram.en</seealso>
    let ``adaptedAsATelevisionProgram.en`` =
        Prefixed_Name(rdau, "adaptedAsATelevisionProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsATelevisionScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsATelevisionScreenplay.en">http://rdaregistry.info/Elements/u/adaptedAsATelevisionScreenplay.en</seealso>
    let ``adaptedAsATelevisionScreenplay.en`` =
        Prefixed_Name(rdau, "adaptedAsATelevisionScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsAVideo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsAVideo.en">http://rdaregistry.info/Elements/u/adaptedAsAVideo.en</seealso>
    let ``adaptedAsAVideo.en`` =
        Prefixed_Name(rdau, "adaptedAsAVideo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsAVideoScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsAVideoScreenplay.en">http://rdaregistry.info/Elements/u/adaptedAsAVideoScreenplay.en</seealso>
    let ``adaptedAsAVideoScreenplay.en`` =
        Prefixed_Name(rdau, "adaptedAsAVideoScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsChoreography.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsChoreography.en">http://rdaregistry.info/Elements/u/adaptedAsChoreography.en</seealso>
    let ``adaptedAsChoreography.en`` =
        Prefixed_Name(rdau, "adaptedAsChoreography.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsGraphicNovel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsGraphicNovel.en">http://rdaregistry.info/Elements/u/adaptedAsGraphicNovel.en</seealso>
    let ``adaptedAsGraphicNovel.en`` =
        Prefixed_Name(rdau, "adaptedAsGraphicNovel.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsLibretto.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsLibretto.en">http://rdaregistry.info/Elements/u/adaptedAsLibretto.en</seealso>
    let ``adaptedAsLibretto.en`` =
        Prefixed_Name(rdau, "adaptedAsLibretto.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsMusicalTheatre.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsMusicalTheatre.en">http://rdaregistry.info/Elements/u/adaptedAsMusicalTheatre.en</seealso>
    let ``adaptedAsMusicalTheatre.en`` =
        Prefixed_Name(rdau, "adaptedAsMusicalTheatre.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsNovel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsNovel.en">http://rdaregistry.info/Elements/u/adaptedAsNovel.en</seealso>
    let ``adaptedAsNovel.en`` = Prefixed_Name(rdau, "adaptedAsNovel.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:adaptedAsOpera.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsOpera.en">http://rdaregistry.info/Elements/u/adaptedAsOpera.en</seealso>
    let ``adaptedAsOpera.en`` = Prefixed_Name(rdau, "adaptedAsOpera.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsOratorio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsOratorio.en">http://rdaregistry.info/Elements/u/adaptedAsOratorio.en</seealso>
    let ``adaptedAsOratorio.en`` =
        Prefixed_Name(rdau, "adaptedAsOratorio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedAsVideoGame.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedAsVideoGame.en">http://rdaregistry.info/Elements/u/adaptedAsVideoGame.en</seealso>
    let ``adaptedAsVideoGame.en`` =
        Prefixed_Name(rdau, "adaptedAsVideoGame.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:adaptedInVerseAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/adaptedInVerseAs.en">http://rdaregistry.info/Elements/u/adaptedInVerseAs.en</seealso>
    let ``adaptedInVerseAs.en`` =
        Prefixed_Name(rdau, "adaptedInVerseAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:addenda.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/addenda.en">http://rdaregistry.info/Elements/u/addenda.en</seealso>
    let ``addenda.en`` = Prefixed_Name(rdau, "addenda.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:addendaTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/addendaTo.en">http://rdaregistry.info/Elements/u/addendaTo.en</seealso>
    let ``addendaTo.en`` = Prefixed_Name(rdau, "addendaTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:additionalScaleInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/additionalScaleInformation.en">http://rdaregistry.info/Elements/u/additionalScaleInformation.en</seealso>
    let ``additionalScaleInformation.en`` =
        Prefixed_Name(rdau, "additionalScaleInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:addressOfTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/addressOfTheAgent.en">http://rdaregistry.info/Elements/u/addressOfTheAgent.en</seealso>
    let ``addressOfTheAgent.en`` =
        Prefixed_Name(rdau, "addressOfTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:addressee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/addressee.en">http://rdaregistry.info/Elements/u/addressee.en</seealso>
    let ``addressee.en`` = Prefixed_Name(rdau, "addressee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:addresseeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/addresseeOf.en">http://rdaregistry.info/Elements/u/addresseeOf.en</seealso>
    let ``addresseeOf.en`` = Prefixed_Name(rdau, "addresseeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:affiliation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/affiliation.en">http://rdaregistry.info/Elements/u/affiliation.en</seealso>
    let ``affiliation.en`` = Prefixed_Name(rdau, "affiliation.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:agentHistory.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/agentHistory.en">http://rdaregistry.info/Elements/u/agentHistory.en</seealso>
    let ``agentHistory.en`` = Prefixed_Name(rdau, "agentHistory.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:alsoIssuedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alsoIssuedAs.en">http://rdaregistry.info/Elements/u/alsoIssuedAs.en</seealso>
    let ``alsoIssuedAs.en`` = Prefixed_Name(rdau, "alsoIssuedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:alternateIdentity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alternateIdentity.en">http://rdaregistry.info/Elements/u/alternateIdentity.en</seealso>
    let ``alternateIdentity.en`` =
        Prefixed_Name(rdau, "alternateIdentity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:analysedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/analysedIn.en">http://rdaregistry.info/Elements/u/analysedIn.en</seealso>
    let ``analysedIn.en`` = Prefixed_Name(rdau, "analysedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:analysisOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/analysisOf.en">http://rdaregistry.info/Elements/u/analysisOf.en</seealso>
    let ``analysisOf.en`` = Prefixed_Name(rdau, "analysisOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:animator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/animator.en">http://rdaregistry.info/Elements/u/animator.en</seealso>
    let ``animator.en`` = Prefixed_Name(rdau, "animator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:animatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/animatorOf.en">http://rdaregistry.info/Elements/u/animatorOf.en</seealso>
    let ``animatorOf.en`` = Prefixed_Name(rdau, "animatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:annotator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/annotator.en">http://rdaregistry.info/Elements/u/annotator.en</seealso>
    let ``annotator.en`` = Prefixed_Name(rdau, "annotator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:annotatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/annotatorOf.en">http://rdaregistry.info/Elements/u/annotatorOf.en</seealso>
    let ``annotatorOf.en`` = Prefixed_Name(rdau, "annotatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appellant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appellant.en">http://rdaregistry.info/Elements/u/appellant.en</seealso>
    let ``appellant.en`` = Prefixed_Name(rdau, "appellant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appellantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appellantOf.en">http://rdaregistry.info/Elements/u/appellantOf.en</seealso>
    let ``appellantOf.en`` = Prefixed_Name(rdau, "appellantOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appellee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appellee.en">http://rdaregistry.info/Elements/u/appellee.en</seealso>
    let ``appellee.en`` = Prefixed_Name(rdau, "appellee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appelleeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appelleeOf.en">http://rdaregistry.info/Elements/u/appelleeOf.en</seealso>
    let ``appelleeOf.en`` = Prefixed_Name(rdau, "appelleeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appendix.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appendix.en">http://rdaregistry.info/Elements/u/appendix.en</seealso>
    let ``appendix.en`` = Prefixed_Name(rdau, "appendix.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:appendixTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appendixTo.en">http://rdaregistry.info/Elements/u/appendixTo.en</seealso>
    let ``appendixTo.en`` = Prefixed_Name(rdau, "appendixTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:appliedMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/appliedMaterial.en">http://rdaregistry.info/Elements/u/appliedMaterial.en</seealso>
    let ``appliedMaterial.en`` =
        Prefixed_Name(rdau, "appliedMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:architect.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/architect.en">http://rdaregistry.info/Elements/u/architect.en</seealso>
    let ``architect.en`` = Prefixed_Name(rdau, "architect.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:architectOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/architectOf.en">http://rdaregistry.info/Elements/u/architectOf.en</seealso>
    let ``architectOf.en`` = Prefixed_Name(rdau, "architectOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:arrangedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/arrangedAs.en">http://rdaregistry.info/Elements/u/arrangedAs.en</seealso>
    let ``arrangedAs.en`` = Prefixed_Name(rdau, "arrangedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:arrangementOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/arrangementOf.en">http://rdaregistry.info/Elements/u/arrangementOf.en</seealso>
    let ``arrangementOf.en`` = Prefixed_Name(rdau, "arrangementOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:arrangerOfMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/arrangerOfMusic.en">http://rdaregistry.info/Elements/u/arrangerOfMusic.en</seealso>
    let ``arrangerOfMusic.en`` =
        Prefixed_Name(rdau, "arrangerOfMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:arrangerOfMusicOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/arrangerOfMusicOf.en">http://rdaregistry.info/Elements/u/arrangerOfMusicOf.en</seealso>
    let ``arrangerOfMusicOf.en`` =
        Prefixed_Name(rdau, "arrangerOfMusicOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:artDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/artDirector.en">http://rdaregistry.info/Elements/u/artDirector.en</seealso>
    let ``artDirector.en`` = Prefixed_Name(rdau, "artDirector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:artDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/artDirectorOf.en">http://rdaregistry.info/Elements/u/artDirectorOf.en</seealso>
    let ``artDirectorOf.en`` = Prefixed_Name(rdau, "artDirectorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:artist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/artist.en">http://rdaregistry.info/Elements/u/artist.en</seealso>
    let ``artist.en`` = Prefixed_Name(rdau, "artist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:artistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/artistOf.en">http://rdaregistry.info/Elements/u/artistOf.en</seealso>
    let ``artistOf.en`` = Prefixed_Name(rdau, "artistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:aspectRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/aspectRatio.en">http://rdaregistry.info/Elements/u/aspectRatio.en</seealso>
    let ``aspectRatio.en`` = Prefixed_Name(rdau, "aspectRatio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:associatedInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/associatedInstitution.en">http://rdaregistry.info/Elements/u/associatedInstitution.en</seealso>
    let ``associatedInstitution.en`` =
        Prefixed_Name(rdau, "associatedInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:augmentationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/augmentationOf.en">http://rdaregistry.info/Elements/u/augmentationOf.en</seealso>
    let ``augmentationOf.en`` = Prefixed_Name(rdau, "augmentationOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:augmentedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/augmentedBy.en">http://rdaregistry.info/Elements/u/augmentedBy.en</seealso>
    let ``augmentedBy.en`` = Prefixed_Name(rdau, "augmentedBy.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:author.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/author.en">http://rdaregistry.info/Elements/u/author.en</seealso>
    let ``author.en`` = Prefixed_Name(rdau, "author.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:authorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/authorOf.en">http://rdaregistry.info/Elements/u/authorOf.en</seealso>
    let ``authorOf.en`` = Prefixed_Name(rdau, "authorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:autographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/autographer.en">http://rdaregistry.info/Elements/u/autographer.en</seealso>
    let ``autographer.en`` = Prefixed_Name(rdau, "autographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:autographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/autographerOf.en">http://rdaregistry.info/Elements/u/autographerOf.en</seealso>
    let ``autographerOf.en`` = Prefixed_Name(rdau, "autographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:award.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/award.en">http://rdaregistry.info/Elements/u/award.en</seealso>
    let ``award.en`` = Prefixed_Name(rdau, "award.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:baseMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/baseMaterial.en">http://rdaregistry.info/Elements/u/baseMaterial.en</seealso>
    let ``baseMaterial.en`` = Prefixed_Name(rdau, "baseMaterial.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:basedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/basedOn.en">http://rdaregistry.info/Elements/u/basedOn.en</seealso>
    let ``basedOn.en`` = Prefixed_Name(rdau, "basedOn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:binder.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/binder.en">http://rdaregistry.info/Elements/u/binder.en</seealso>
    let ``binder.en`` = Prefixed_Name(rdau, "binder.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:binderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/binderOf.en">http://rdaregistry.info/Elements/u/binderOf.en</seealso>
    let ``binderOf.en`` = Prefixed_Name(rdau, "binderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:biographicalInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/biographicalInformation.en">http://rdaregistry.info/Elements/u/biographicalInformation.en</seealso>
    let ``biographicalInformation.en`` =
        Prefixed_Name(rdau, "biographicalInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:bookArtist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/bookArtist.en">http://rdaregistry.info/Elements/u/bookArtist.en</seealso>
    let ``bookArtist.en`` = Prefixed_Name(rdau, "bookArtist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:bookArtistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/bookArtistOf.en">http://rdaregistry.info/Elements/u/bookArtistOf.en</seealso>
    let ``bookArtistOf.en`` = Prefixed_Name(rdau, "bookArtistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:bookDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/bookDesigner.en">http://rdaregistry.info/Elements/u/bookDesigner.en</seealso>
    let ``bookDesigner.en`` = Prefixed_Name(rdau, "bookDesigner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:bookDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/bookDesignerOf.en">http://rdaregistry.info/Elements/u/bookDesignerOf.en</seealso>
    let ``bookDesignerOf.en`` = Prefixed_Name(rdau, "bookDesignerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:bookFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/bookFormat.en">http://rdaregistry.info/Elements/u/bookFormat.en</seealso>
    let ``bookFormat.en`` = Prefixed_Name(rdau, "bookFormat.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:boundWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/boundWith.en">http://rdaregistry.info/Elements/u/boundWith.en</seealso>
    let ``boundWith.en`` = Prefixed_Name(rdau, "boundWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:brailleEmbosser.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/brailleEmbosser.en">http://rdaregistry.info/Elements/u/brailleEmbosser.en</seealso>
    let ``brailleEmbosser.en`` =
        Prefixed_Name(rdau, "brailleEmbosser.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:brailleEmbosserOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/brailleEmbosserOf.en">http://rdaregistry.info/Elements/u/brailleEmbosserOf.en</seealso>
    let ``brailleEmbosserOf.en`` =
        Prefixed_Name(rdau, "brailleEmbosserOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:broadcastStandard.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/broadcastStandard.en">http://rdaregistry.info/Elements/u/broadcastStandard.en</seealso>
    let ``broadcastStandard.en`` =
        Prefixed_Name(rdau, "broadcastStandard.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:broadcaster.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/broadcaster.en">http://rdaregistry.info/Elements/u/broadcaster.en</seealso>
    let ``broadcaster.en`` = Prefixed_Name(rdau, "broadcaster.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:broadcasterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/broadcasterOf.en">http://rdaregistry.info/Elements/u/broadcasterOf.en</seealso>
    let ``broadcasterOf.en`` = Prefixed_Name(rdau, "broadcasterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:broaderAffiliatedAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/broaderAffiliatedAgent.en">http://rdaregistry.info/Elements/u/broaderAffiliatedAgent.en</seealso>
    let ``broaderAffiliatedAgent.en`` =
        Prefixed_Name(rdau, "broaderAffiliatedAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:cadenza.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/cadenza.en">http://rdaregistry.info/Elements/u/cadenza.en</seealso>
    let ``cadenza.en`` = Prefixed_Name(rdau, "cadenza.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:cadenzaComposedFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/cadenzaComposedFor.en">http://rdaregistry.info/Elements/u/cadenzaComposedFor.en</seealso>
    let ``cadenzaComposedFor.en`` =
        Prefixed_Name(rdau, "cadenzaComposedFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:calligrapher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/calligrapher.en">http://rdaregistry.info/Elements/u/calligrapher.en</seealso>
    let ``calligrapher.en`` = Prefixed_Name(rdau, "calligrapher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:calligrapherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/calligrapherOf.en">http://rdaregistry.info/Elements/u/calligrapherOf.en</seealso>
    let ``calligrapherOf.en`` = Prefixed_Name(rdau, "calligrapherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:carrierType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/carrierType.en">http://rdaregistry.info/Elements/u/carrierType.en</seealso>
    let ``carrierType.en`` = Prefixed_Name(rdau, "carrierType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:cartographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/cartographer.en">http://rdaregistry.info/Elements/u/cartographer.en</seealso>
    let ``cartographer.en`` = Prefixed_Name(rdau, "cartographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:cartographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/cartographerOf.en">http://rdaregistry.info/Elements/u/cartographerOf.en</seealso>
    let ``cartographerOf.en`` = Prefixed_Name(rdau, "cartographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:caster.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/caster.en">http://rdaregistry.info/Elements/u/caster.en</seealso>
    let ``caster.en`` = Prefixed_Name(rdau, "caster.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:casterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/casterOf.en">http://rdaregistry.info/Elements/u/casterOf.en</seealso>
    let ``casterOf.en`` = Prefixed_Name(rdau, "casterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:catalogue.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/catalogue.en">http://rdaregistry.info/Elements/u/catalogue.en</seealso>
    let ``catalogue.en`` = Prefixed_Name(rdau, "catalogue.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:catalogueOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/catalogueOf.en">http://rdaregistry.info/Elements/u/catalogueOf.en</seealso>
    let ``catalogueOf.en`` = Prefixed_Name(rdau, "catalogueOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choralConductor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choralConductor.en">http://rdaregistry.info/Elements/u/choralConductor.en</seealso>
    let ``choralConductor.en`` =
        Prefixed_Name(rdau, "choralConductor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choralConductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choralConductorOf.en">http://rdaregistry.info/Elements/u/choralConductorOf.en</seealso>
    let ``choralConductorOf.en`` =
        Prefixed_Name(rdau, "choralConductorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choreographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choreographer.en">http://rdaregistry.info/Elements/u/choreographer.en</seealso>
    let ``choreographer.en`` = Prefixed_Name(rdau, "choreographer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choreographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choreographerOf.en">http://rdaregistry.info/Elements/u/choreographerOf.en</seealso>
    let ``choreographerOf.en`` =
        Prefixed_Name(rdau, "choreographerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choreographicAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choreographicAdaptationOf.en">http://rdaregistry.info/Elements/u/choreographicAdaptationOf.en</seealso>
    let ``choreographicAdaptationOf.en`` =
        Prefixed_Name(rdau, "choreographicAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choreography.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choreography.en">http://rdaregistry.info/Elements/u/choreography.en</seealso>
    let ``choreography.en`` = Prefixed_Name(rdau, "choreography.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:choreographyFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/choreographyFor.en">http://rdaregistry.info/Elements/u/choreographyFor.en</seealso>
    let ``choreographyFor.en`` =
        Prefixed_Name(rdau, "choreographyFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:chronologicalDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/chronologicalDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/chronologicalDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``chronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "chronologicalDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:chronologicalDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/chronologicalDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/chronologicalDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``chronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "chronologicalDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:collectionRegistrar.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collectionRegistrar.en">http://rdaregistry.info/Elements/u/collectionRegistrar.en</seealso>
    let ``collectionRegistrar.en`` =
        Prefixed_Name(rdau, "collectionRegistrar.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:collectionRegistrarOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collectionRegistrarOf.en">http://rdaregistry.info/Elements/u/collectionRegistrarOf.en</seealso>
    let ``collectionRegistrarOf.en`` =
        Prefixed_Name(rdau, "collectionRegistrarOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:collector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collector.en">http://rdaregistry.info/Elements/u/collector.en</seealso>
    let ``collector.en`` = Prefixed_Name(rdau, "collector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:collectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collectorOf.en">http://rdaregistry.info/Elements/u/collectorOf.en</seealso>
    let ``collectorOf.en`` = Prefixed_Name(rdau, "collectorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:collotyper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collotyper.en">http://rdaregistry.info/Elements/u/collotyper.en</seealso>
    let ``collotyper.en`` = Prefixed_Name(rdau, "collotyper.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:collotyperOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/collotyperOf.en">http://rdaregistry.info/Elements/u/collotyperOf.en</seealso>
    let ``collotyperOf.en`` = Prefixed_Name(rdau, "collotyperOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:colourContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/colourContent.en">http://rdaregistry.info/Elements/u/colourContent.en</seealso>
    let ``colourContent.en`` = Prefixed_Name(rdau, "colourContent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:colourist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/colourist.en">http://rdaregistry.info/Elements/u/colourist.en</seealso>
    let ``colourist.en`` = Prefixed_Name(rdau, "colourist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:colouristOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/colouristOf.en">http://rdaregistry.info/Elements/u/colouristOf.en</seealso>
    let ``colouristOf.en`` = Prefixed_Name(rdau, "colouristOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:commemoration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commemoration.en">http://rdaregistry.info/Elements/u/commemoration.en</seealso>
    let ``commemoration.en`` = Prefixed_Name(rdau, "commemoration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:commemorationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commemorationOf.en">http://rdaregistry.info/Elements/u/commemorationOf.en</seealso>
    let ``commemorationOf.en`` =
        Prefixed_Name(rdau, "commemorationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:commentaryIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commentaryIn.en">http://rdaregistry.info/Elements/u/commentaryIn.en</seealso>
    let ``commentaryIn.en`` = Prefixed_Name(rdau, "commentaryIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:commentaryOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commentaryOn.en">http://rdaregistry.info/Elements/u/commentaryOn.en</seealso>
    let ``commentaryOn.en`` = Prefixed_Name(rdau, "commentaryOn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:commentator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commentator.en">http://rdaregistry.info/Elements/u/commentator.en</seealso>
    let ``commentator.en`` = Prefixed_Name(rdau, "commentator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:commentatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commentatorOf.en">http://rdaregistry.info/Elements/u/commentatorOf.en</seealso>
    let ``commentatorOf.en`` = Prefixed_Name(rdau, "commentatorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:commissioningBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commissioningBody.en">http://rdaregistry.info/Elements/u/commissioningBody.en</seealso>
    let ``commissioningBody.en`` =
        Prefixed_Name(rdau, "commissioningBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:commissioningBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/commissioningBodyOf.en">http://rdaregistry.info/Elements/u/commissioningBodyOf.en</seealso>
    let ``commissioningBodyOf.en`` =
        Prefixed_Name(rdau, "commissioningBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:compiler.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/compiler.en">http://rdaregistry.info/Elements/u/compiler.en</seealso>
    let ``compiler.en`` = Prefixed_Name(rdau, "compiler.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:compilerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/compilerOf.en">http://rdaregistry.info/Elements/u/compilerOf.en</seealso>
    let ``compilerOf.en`` = Prefixed_Name(rdau, "compilerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:complementedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/complementedBy.en">http://rdaregistry.info/Elements/u/complementedBy.en</seealso>
    let ``complementedBy.en`` = Prefixed_Name(rdau, "complementedBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:componentOfAMerger.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/componentOfAMerger.en">http://rdaregistry.info/Elements/u/componentOfAMerger.en</seealso>
    let ``componentOfAMerger.en`` =
        Prefixed_Name(rdau, "componentOfAMerger.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:composer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/composer.en">http://rdaregistry.info/Elements/u/composer.en</seealso>
    let ``composer.en`` = Prefixed_Name(rdau, "composer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:composerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/composerOf.en">http://rdaregistry.info/Elements/u/composerOf.en</seealso>
    let ``composerOf.en`` = Prefixed_Name(rdau, "composerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:concordance.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/concordance.en">http://rdaregistry.info/Elements/u/concordance.en</seealso>
    let ``concordance.en`` = Prefixed_Name(rdau, "concordance.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:concordanceTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/concordanceTo.en">http://rdaregistry.info/Elements/u/concordanceTo.en</seealso>
    let ``concordanceTo.en`` = Prefixed_Name(rdau, "concordanceTo.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:conductor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/conductor.en">http://rdaregistry.info/Elements/u/conductor.en</seealso>
    let ``conductor.en`` = Prefixed_Name(rdau, "conductor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:conductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/conductorOf.en">http://rdaregistry.info/Elements/u/conductorOf.en</seealso>
    let ``conductorOf.en`` = Prefixed_Name(rdau, "conductorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:configurationOfPlaybackChannels.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/configurationOfPlaybackChannels.en">http://rdaregistry.info/Elements/u/configurationOfPlaybackChannels.en</seealso>
    let ``configurationOfPlaybackChannels.en`` =
        Prefixed_Name(rdau, "configurationOfPlaybackChannels.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:consultant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/consultant.en">http://rdaregistry.info/Elements/u/consultant.en</seealso>
    let ``consultant.en`` = Prefixed_Name(rdau, "consultant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:consultantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/consultantOf.en">http://rdaregistry.info/Elements/u/consultantOf.en</seealso>
    let ``consultantOf.en`` = Prefixed_Name(rdau, "consultantOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:contactInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/contactInformation.en">http://rdaregistry.info/Elements/u/contactInformation.en</seealso>
    let ``contactInformation.en`` =
        Prefixed_Name(rdau, "contactInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:containedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/containedIn.en">http://rdaregistry.info/Elements/u/containedIn.en</seealso>
    let ``containedIn.en`` = Prefixed_Name(rdau, "containedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:containerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/containerOf.en">http://rdaregistry.info/Elements/u/containerOf.en</seealso>
    let ``containerOf.en`` = Prefixed_Name(rdau, "containerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:contentType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/contentType.en">http://rdaregistry.info/Elements/u/contentType.en</seealso>
    let ``contentType.en`` = Prefixed_Name(rdau, "contentType.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:continuationInPartOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/continuationInPartOf.en">http://rdaregistry.info/Elements/u/continuationInPartOf.en</seealso>
    let ``continuationInPartOf.en`` =
        Prefixed_Name(rdau, "continuationInPartOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:continuationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/continuationOf.en">http://rdaregistry.info/Elements/u/continuationOf.en</seealso>
    let ``continuationOf.en`` = Prefixed_Name(rdau, "continuationOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:continuedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/continuedBy.en">http://rdaregistry.info/Elements/u/continuedBy.en</seealso>
    let ``continuedBy.en`` = Prefixed_Name(rdau, "continuedBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:continuedInPartBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/continuedInPartBy.en">http://rdaregistry.info/Elements/u/continuedInPartBy.en</seealso>
    let ``continuedInPartBy.en`` =
        Prefixed_Name(rdau, "continuedInPartBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:contributor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/contributor.en">http://rdaregistry.info/Elements/u/contributor.en</seealso>
    let ``contributor.en`` = Prefixed_Name(rdau, "contributor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:contributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/contributorOf.en">http://rdaregistry.info/Elements/u/contributorOf.en</seealso>
    let ``contributorOf.en`` = Prefixed_Name(rdau, "contributorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:coordinatesOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/coordinatesOfCartographicContent.en">http://rdaregistry.info/Elements/u/coordinatesOfCartographicContent.en</seealso>
    let ``coordinatesOfCartographicContent.en`` =
        Prefixed_Name(rdau, "coordinatesOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:copyrightDate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/copyrightDate.en">http://rdaregistry.info/Elements/u/copyrightDate.en</seealso>
    let ``copyrightDate.en`` = Prefixed_Name(rdau, "copyrightDate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:costumeDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/costumeDesigner.en">http://rdaregistry.info/Elements/u/costumeDesigner.en</seealso>
    let ``costumeDesigner.en`` =
        Prefixed_Name(rdau, "costumeDesigner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:costumeDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/costumeDesignerOf.en">http://rdaregistry.info/Elements/u/costumeDesignerOf.en</seealso>
    let ``costumeDesignerOf.en`` =
        Prefixed_Name(rdau, "costumeDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:countryAssociatedWithThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/countryAssociatedWithThePerson.en">http://rdaregistry.info/Elements/u/countryAssociatedWithThePerson.en</seealso>
    let ``countryAssociatedWithThePerson.en`` =
        Prefixed_Name(rdau, "countryAssociatedWithThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:courtGoverned.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/courtGoverned.en">http://rdaregistry.info/Elements/u/courtGoverned.en</seealso>
    let ``courtGoverned.en`` = Prefixed_Name(rdau, "courtGoverned.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:courtGovernedOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/courtGovernedOf.en">http://rdaregistry.info/Elements/u/courtGovernedOf.en</seealso>
    let ``courtGovernedOf.en`` =
        Prefixed_Name(rdau, "courtGovernedOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:courtReporter.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/courtReporter.en">http://rdaregistry.info/Elements/u/courtReporter.en</seealso>
    let ``courtReporter.en`` = Prefixed_Name(rdau, "courtReporter.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:courtReporterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/courtReporterOf.en">http://rdaregistry.info/Elements/u/courtReporterOf.en</seealso>
    let ``courtReporterOf.en`` =
        Prefixed_Name(rdau, "courtReporterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:coverageOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/coverageOfTheContent.en">http://rdaregistry.info/Elements/u/coverageOfTheContent.en</seealso>
    let ``coverageOfTheContent.en`` =
        Prefixed_Name(rdau, "coverageOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:creator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/creator.en">http://rdaregistry.info/Elements/u/creator.en</seealso>
    let ``creator.en`` = Prefixed_Name(rdau, "creator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:creatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/creatorOf.en">http://rdaregistry.info/Elements/u/creatorOf.en</seealso>
    let ``creatorOf.en`` = Prefixed_Name(rdau, "creatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:critiqueOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/critiqueOf.en">http://rdaregistry.info/Elements/u/critiqueOf.en</seealso>
    let ``critiqueOf.en`` = Prefixed_Name(rdau, "critiqueOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:critiquedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/critiquedIn.en">http://rdaregistry.info/Elements/u/critiquedIn.en</seealso>
    let ``critiquedIn.en`` = Prefixed_Name(rdau, "critiquedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:curator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/curator.en">http://rdaregistry.info/Elements/u/curator.en</seealso>
    let ``curator.en`` = Prefixed_Name(rdau, "curator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:curatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/curatorOf.en">http://rdaregistry.info/Elements/u/curatorOf.en</seealso>
    let ``curatorOf.en`` = Prefixed_Name(rdau, "curatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:currentOwner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/currentOwner.en">http://rdaregistry.info/Elements/u/currentOwner.en</seealso>
    let ``currentOwner.en`` = Prefixed_Name(rdau, "currentOwner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:currentOwnerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/currentOwnerOf.en">http://rdaregistry.info/Elements/u/currentOwnerOf.en</seealso>
    let ``currentOwnerOf.en`` = Prefixed_Name(rdau, "currentOwnerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:custodialHistoryOfResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/custodialHistoryOfResource.en">http://rdaregistry.info/Elements/u/custodialHistoryOfResource.en</seealso>
    let ``custodialHistoryOfResource.en`` =
        Prefixed_Name(rdau, "custodialHistoryOfResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:custodian.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/custodian.en">http://rdaregistry.info/Elements/u/custodian.en</seealso>
    let ``custodian.en`` = Prefixed_Name(rdau, "custodian.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:custodianOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/custodianOf.en">http://rdaregistry.info/Elements/u/custodianOf.en</seealso>
    let ``custodianOf.en`` = Prefixed_Name(rdau, "custodianOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dancer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dancer.en">http://rdaregistry.info/Elements/u/dancer.en</seealso>
    let ``dancer.en`` = Prefixed_Name(rdau, "dancer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dancerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dancerOf.en">http://rdaregistry.info/Elements/u/dancerOf.en</seealso>
    let ``dancerOf.en`` = Prefixed_Name(rdau, "dancerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateAssociatedWithTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateAssociatedWithTheAgent.en">http://rdaregistry.info/Elements/u/dateAssociatedWithTheAgent.en</seealso>
    let ``dateAssociatedWithTheAgent.en`` =
        Prefixed_Name(rdau, "dateAssociatedWithTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfBirth.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfBirth.en">http://rdaregistry.info/Elements/u/dateOfBirth.en</seealso>
    let ``dateOfBirth.en`` = Prefixed_Name(rdau, "dateOfBirth.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dateOfCapture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfCapture.en">http://rdaregistry.info/Elements/u/dateOfCapture.en</seealso>
    let ``dateOfCapture.en`` = Prefixed_Name(rdau, "dateOfCapture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfConferenceEtc.en">http://rdaregistry.info/Elements/u/dateOfConferenceEtc.en</seealso>
    let ``dateOfConferenceEtc.en`` =
        Prefixed_Name(rdau, "dateOfConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfDeath.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfDeath.en">http://rdaregistry.info/Elements/u/dateOfDeath.en</seealso>
    let ``dateOfDeath.en`` = Prefixed_Name(rdau, "dateOfDeath.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfDistribution.en">http://rdaregistry.info/Elements/u/dateOfDistribution.en</seealso>
    let ``dateOfDistribution.en`` =
        Prefixed_Name(rdau, "dateOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfEstablishment.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfEstablishment.en">http://rdaregistry.info/Elements/u/dateOfEstablishment.en</seealso>
    let ``dateOfEstablishment.en`` =
        Prefixed_Name(rdau, "dateOfEstablishment.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfManufacture.en">http://rdaregistry.info/Elements/u/dateOfManufacture.en</seealso>
    let ``dateOfManufacture.en`` =
        Prefixed_Name(rdau, "dateOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfProduction.en">http://rdaregistry.info/Elements/u/dateOfProduction.en</seealso>
    let ``dateOfProduction.en`` =
        Prefixed_Name(rdau, "dateOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfPublication.en">http://rdaregistry.info/Elements/u/dateOfPublication.en</seealso>
    let ``dateOfPublication.en`` =
        Prefixed_Name(rdau, "dateOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfResource.en">http://rdaregistry.info/Elements/u/dateOfResource.en</seealso>
    let ``dateOfResource.en`` = Prefixed_Name(rdau, "dateOfResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfTermination.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfTermination.en">http://rdaregistry.info/Elements/u/dateOfTermination.en</seealso>
    let ``dateOfTermination.en`` =
        Prefixed_Name(rdau, "dateOfTermination.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dateOfUsage.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dateOfUsage.en">http://rdaregistry.info/Elements/u/dateOfUsage.en</seealso>
    let ``dateOfUsage.en`` = Prefixed_Name(rdau, "dateOfUsage.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dedicatee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dedicatee.en">http://rdaregistry.info/Elements/u/dedicatee.en</seealso>
    let ``dedicatee.en`` = Prefixed_Name(rdau, "dedicatee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dedicateeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dedicateeOf.en">http://rdaregistry.info/Elements/u/dedicateeOf.en</seealso>
    let ``dedicateeOf.en`` = Prefixed_Name(rdau, "dedicateeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dedicator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dedicator.en">http://rdaregistry.info/Elements/u/dedicator.en</seealso>
    let ``dedicator.en`` = Prefixed_Name(rdau, "dedicator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dedicatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dedicatorOf.en">http://rdaregistry.info/Elements/u/dedicatorOf.en</seealso>
    let ``dedicatorOf.en`` = Prefixed_Name(rdau, "dedicatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:defendant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/defendant.en">http://rdaregistry.info/Elements/u/defendant.en</seealso>
    let ``defendant.en`` = Prefixed_Name(rdau, "defendant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:defendantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/defendantOf.en">http://rdaregistry.info/Elements/u/defendantOf.en</seealso>
    let ``defendantOf.en`` = Prefixed_Name(rdau, "defendantOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeCommitteeMember.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeCommitteeMember.en">http://rdaregistry.info/Elements/u/degreeCommitteeMember.en</seealso>
    let ``degreeCommitteeMember.en`` =
        Prefixed_Name(rdau, "degreeCommitteeMember.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeCommitteeMemberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeCommitteeMemberOf.en">http://rdaregistry.info/Elements/u/degreeCommitteeMemberOf.en</seealso>
    let ``degreeCommitteeMemberOf.en`` =
        Prefixed_Name(rdau, "degreeCommitteeMemberOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeGrantingInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeGrantingInstitution.en">http://rdaregistry.info/Elements/u/degreeGrantingInstitution.en</seealso>
    let ``degreeGrantingInstitution.en`` =
        Prefixed_Name(rdau, "degreeGrantingInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeGrantingInstitutionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeGrantingInstitutionOf.en">http://rdaregistry.info/Elements/u/degreeGrantingInstitutionOf.en</seealso>
    let ``degreeGrantingInstitutionOf.en`` =
        Prefixed_Name(rdau, "degreeGrantingInstitutionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeSupervisor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeSupervisor.en">http://rdaregistry.info/Elements/u/degreeSupervisor.en</seealso>
    let ``degreeSupervisor.en`` =
        Prefixed_Name(rdau, "degreeSupervisor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:degreeSupervisorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/degreeSupervisorOf.en">http://rdaregistry.info/Elements/u/degreeSupervisorOf.en</seealso>
    let ``degreeSupervisorOf.en`` =
        Prefixed_Name(rdau, "degreeSupervisorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:depositor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/depositor.en">http://rdaregistry.info/Elements/u/depositor.en</seealso>
    let ``depositor.en`` = Prefixed_Name(rdau, "depositor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:depositorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/depositorOf.en">http://rdaregistry.info/Elements/u/depositorOf.en</seealso>
    let ``depositorOf.en`` = Prefixed_Name(rdau, "depositorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:derivative.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/derivative.en">http://rdaregistry.info/Elements/u/derivative.en</seealso>
    let ``derivative.en`` = Prefixed_Name(rdau, "derivative.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:derivativeResourceRelationshipWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/derivativeResourceRelationshipWith.en">http://rdaregistry.info/Elements/u/derivativeResourceRelationshipWith.en</seealso>
    let ``derivativeResourceRelationshipWith.en`` =
        Prefixed_Name(rdau, "derivativeResourceRelationshipWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:describedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/describedIn.en">http://rdaregistry.info/Elements/u/describedIn.en</seealso>
    let ``describedIn.en`` = Prefixed_Name(rdau, "describedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:descriptionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/descriptionOf.en">http://rdaregistry.info/Elements/u/descriptionOf.en</seealso>
    let ``descriptionOf.en`` = Prefixed_Name(rdau, "descriptionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:designationOfANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/designationOfANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/u/designationOfANamedRevisionOfAnEdition.en</seealso>
    let ``designationOfANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdau, "designationOfANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:designationOfEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/designationOfEdition.en">http://rdaregistry.info/Elements/u/designationOfEdition.en</seealso>
    let ``designationOfEdition.en`` =
        Prefixed_Name(rdau, "designationOfEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:designer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/designer.en">http://rdaregistry.info/Elements/u/designer.en</seealso>
    let ``designer.en`` = Prefixed_Name(rdau, "designer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:designerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/designerOf.en">http://rdaregistry.info/Elements/u/designerOf.en</seealso>
    let ``designerOf.en`` = Prefixed_Name(rdau, "designerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfAppliedMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfAppliedMaterial.en">http://rdaregistry.info/Elements/u/detailsOfAppliedMaterial.en</seealso>
    let ``detailsOfAppliedMaterial.en`` =
        Prefixed_Name(rdau, "detailsOfAppliedMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfAspectRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfAspectRatio.en">http://rdaregistry.info/Elements/u/detailsOfAspectRatio.en</seealso>
    let ``detailsOfAspectRatio.en`` =
        Prefixed_Name(rdau, "detailsOfAspectRatio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfBaseMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfBaseMaterial.en">http://rdaregistry.info/Elements/u/detailsOfBaseMaterial.en</seealso>
    let ``detailsOfBaseMaterial.en`` =
        Prefixed_Name(rdau, "detailsOfBaseMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfBookFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfBookFormat.en">http://rdaregistry.info/Elements/u/detailsOfBookFormat.en</seealso>
    let ``detailsOfBookFormat.en`` =
        Prefixed_Name(rdau, "detailsOfBookFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfBroadcastStandard.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfBroadcastStandard.en">http://rdaregistry.info/Elements/u/detailsOfBroadcastStandard.en</seealso>
    let ``detailsOfBroadcastStandard.en`` =
        Prefixed_Name(rdau, "detailsOfBroadcastStandard.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfColourContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfColourContent.en">http://rdaregistry.info/Elements/u/detailsOfColourContent.en</seealso>
    let ``detailsOfColourContent.en`` =
        Prefixed_Name(rdau, "detailsOfColourContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfConfigurationOfPlaybackChannels.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfConfigurationOfPlaybackChannels.en">http://rdaregistry.info/Elements/u/detailsOfConfigurationOfPlaybackChannels.en</seealso>
    let ``detailsOfConfigurationOfPlaybackChannels.en`` =
        Prefixed_Name(rdau, "detailsOfConfigurationOfPlaybackChannels.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfDigitalFileCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfDigitalFileCharacteristic.en">http://rdaregistry.info/Elements/u/detailsOfDigitalFileCharacteristic.en</seealso>
    let ``detailsOfDigitalFileCharacteristic.en`` =
        Prefixed_Name(rdau, "detailsOfDigitalFileCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfDigitalRepresentationOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfDigitalRepresentationOfCartographicContent.en">http://rdaregistry.info/Elements/u/detailsOfDigitalRepresentationOfCartographicContent.en</seealso>
    let ``detailsOfDigitalRepresentationOfCartographicContent.en`` =
        Prefixed_Name(rdau, "detailsOfDigitalRepresentationOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfDuration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfDuration.en">http://rdaregistry.info/Elements/u/detailsOfDuration.en</seealso>
    let ``detailsOfDuration.en`` =
        Prefixed_Name(rdau, "detailsOfDuration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfEmulsionOnMicrofilmAndMicrofiche.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfEmulsionOnMicrofilmAndMicrofiche.en">http://rdaregistry.info/Elements/u/detailsOfEmulsionOnMicrofilmAndMicrofiche.en</seealso>
    let ``detailsOfEmulsionOnMicrofilmAndMicrofiche.en`` =
        Prefixed_Name(rdau, "detailsOfEmulsionOnMicrofilmAndMicrofiche.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfEncodingFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfEncodingFormat.en">http://rdaregistry.info/Elements/u/detailsOfEncodingFormat.en</seealso>
    let ``detailsOfEncodingFormat.en`` =
        Prefixed_Name(rdau, "detailsOfEncodingFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFileType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFileType.en">http://rdaregistry.info/Elements/u/detailsOfFileType.en</seealso>
    let ``detailsOfFileType.en`` =
        Prefixed_Name(rdau, "detailsOfFileType.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFontSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFontSize.en">http://rdaregistry.info/Elements/u/detailsOfFontSize.en</seealso>
    let ``detailsOfFontSize.en`` =
        Prefixed_Name(rdau, "detailsOfFontSize.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFormOfMusicalNotation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFormOfMusicalNotation.en">http://rdaregistry.info/Elements/u/detailsOfFormOfMusicalNotation.en</seealso>
    let ``detailsOfFormOfMusicalNotation.en`` =
        Prefixed_Name(rdau, "detailsOfFormOfMusicalNotation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFormOfNotatedMovement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFormOfNotatedMovement.en">http://rdaregistry.info/Elements/u/detailsOfFormOfNotatedMovement.en</seealso>
    let ``detailsOfFormOfNotatedMovement.en`` =
        Prefixed_Name(rdau, "detailsOfFormOfNotatedMovement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFormOfTactileNotation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFormOfTactileNotation.en">http://rdaregistry.info/Elements/u/detailsOfFormOfTactileNotation.en</seealso>
    let ``detailsOfFormOfTactileNotation.en`` =
        Prefixed_Name(rdau, "detailsOfFormOfTactileNotation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfFormatOfNotatedMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfFormatOfNotatedMusic.en">http://rdaregistry.info/Elements/u/detailsOfFormatOfNotatedMusic.en</seealso>
    let ``detailsOfFormatOfNotatedMusic.en`` =
        Prefixed_Name(rdau, "detailsOfFormatOfNotatedMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGeneration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGeneration.en">http://rdaregistry.info/Elements/u/detailsOfGeneration.en</seealso>
    let ``detailsOfGeneration.en`` =
        Prefixed_Name(rdau, "detailsOfGeneration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGenerationOfAudioRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGenerationOfAudioRecording.en">http://rdaregistry.info/Elements/u/detailsOfGenerationOfAudioRecording.en</seealso>
    let ``detailsOfGenerationOfAudioRecording.en`` =
        Prefixed_Name(rdau, "detailsOfGenerationOfAudioRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGenerationOfDigitalResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGenerationOfDigitalResource.en">http://rdaregistry.info/Elements/u/detailsOfGenerationOfDigitalResource.en</seealso>
    let ``detailsOfGenerationOfDigitalResource.en`` =
        Prefixed_Name(rdau, "detailsOfGenerationOfDigitalResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGenerationOfMicroform.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGenerationOfMicroform.en">http://rdaregistry.info/Elements/u/detailsOfGenerationOfMicroform.en</seealso>
    let ``detailsOfGenerationOfMicroform.en`` =
        Prefixed_Name(rdau, "detailsOfGenerationOfMicroform.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGenerationOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGenerationOfMotionPictureFilm.en">http://rdaregistry.info/Elements/u/detailsOfGenerationOfMotionPictureFilm.en</seealso>
    let ``detailsOfGenerationOfMotionPictureFilm.en`` =
        Prefixed_Name(rdau, "detailsOfGenerationOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGenerationOfVideotape.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGenerationOfVideotape.en">http://rdaregistry.info/Elements/u/detailsOfGenerationOfVideotape.en</seealso>
    let ``detailsOfGenerationOfVideotape.en`` =
        Prefixed_Name(rdau, "detailsOfGenerationOfVideotape.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfGrooveCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfGrooveCharacteristic.en">http://rdaregistry.info/Elements/u/detailsOfGrooveCharacteristic.en</seealso>
    let ``detailsOfGrooveCharacteristic.en`` =
        Prefixed_Name(rdau, "detailsOfGrooveCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfIllustrativeContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfIllustrativeContent.en">http://rdaregistry.info/Elements/u/detailsOfIllustrativeContent.en</seealso>
    let ``detailsOfIllustrativeContent.en`` =
        Prefixed_Name(rdau, "detailsOfIllustrativeContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfLayout.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfLayout.en">http://rdaregistry.info/Elements/u/detailsOfLayout.en</seealso>
    let ``detailsOfLayout.en`` =
        Prefixed_Name(rdau, "detailsOfLayout.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfMount.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfMount.en">http://rdaregistry.info/Elements/u/detailsOfMount.en</seealso>
    let ``detailsOfMount.en`` = Prefixed_Name(rdau, "detailsOfMount.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfPlayingSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfPlayingSpeed.en">http://rdaregistry.info/Elements/u/detailsOfPlayingSpeed.en</seealso>
    let ``detailsOfPlayingSpeed.en`` =
        Prefixed_Name(rdau, "detailsOfPlayingSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfPolarity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfPolarity.en">http://rdaregistry.info/Elements/u/detailsOfPolarity.en</seealso>
    let ``detailsOfPolarity.en`` =
        Prefixed_Name(rdau, "detailsOfPolarity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfPresentationFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfPresentationFormat.en">http://rdaregistry.info/Elements/u/detailsOfPresentationFormat.en</seealso>
    let ``detailsOfPresentationFormat.en`` =
        Prefixed_Name(rdau, "detailsOfPresentationFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfProductionMethod.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfProductionMethod.en">http://rdaregistry.info/Elements/u/detailsOfProductionMethod.en</seealso>
    let ``detailsOfProductionMethod.en`` =
        Prefixed_Name(rdau, "detailsOfProductionMethod.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfProductionMethodForManuscript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfProductionMethodForManuscript.en">http://rdaregistry.info/Elements/u/detailsOfProductionMethodForManuscript.en</seealso>
    let ``detailsOfProductionMethodForManuscript.en`` =
        Prefixed_Name(rdau, "detailsOfProductionMethodForManuscript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfProductionMethodForTactileResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfProductionMethodForTactileResource.en">http://rdaregistry.info/Elements/u/detailsOfProductionMethodForTactileResource.en</seealso>
    let ``detailsOfProductionMethodForTactileResource.en`` =
        Prefixed_Name(rdau, "detailsOfProductionMethodForTactileResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfProjectionCharacteristicOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfProjectionCharacteristicOfMotionPictureFilm.en">http://rdaregistry.info/Elements/u/detailsOfProjectionCharacteristicOfMotionPictureFilm.en</seealso>
    let ``detailsOfProjectionCharacteristicOfMotionPictureFilm.en`` =
        Prefixed_Name(rdau, "detailsOfProjectionCharacteristicOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfProjectionSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfProjectionSpeed.en">http://rdaregistry.info/Elements/u/detailsOfProjectionSpeed.en</seealso>
    let ``detailsOfProjectionSpeed.en`` =
        Prefixed_Name(rdau, "detailsOfProjectionSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfRecordingMedium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfRecordingMedium.en">http://rdaregistry.info/Elements/u/detailsOfRecordingMedium.en</seealso>
    let ``detailsOfRecordingMedium.en`` =
        Prefixed_Name(rdau, "detailsOfRecordingMedium.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfReductionRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfReductionRatio.en">http://rdaregistry.info/Elements/u/detailsOfReductionRatio.en</seealso>
    let ``detailsOfReductionRatio.en`` =
        Prefixed_Name(rdau, "detailsOfReductionRatio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfScript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfScript.en">http://rdaregistry.info/Elements/u/detailsOfScript.en</seealso>
    let ``detailsOfScript.en`` =
        Prefixed_Name(rdau, "detailsOfScript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfSoundCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfSoundCharacteristic.en">http://rdaregistry.info/Elements/u/detailsOfSoundCharacteristic.en</seealso>
    let ``detailsOfSoundCharacteristic.en`` =
        Prefixed_Name(rdau, "detailsOfSoundCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfSpecialPlaybackCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfSpecialPlaybackCharacteristic.en">http://rdaregistry.info/Elements/u/detailsOfSpecialPlaybackCharacteristic.en</seealso>
    let ``detailsOfSpecialPlaybackCharacteristic.en`` =
        Prefixed_Name(rdau, "detailsOfSpecialPlaybackCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfTapeConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfTapeConfiguration.en">http://rdaregistry.info/Elements/u/detailsOfTapeConfiguration.en</seealso>
    let ``detailsOfTapeConfiguration.en`` =
        Prefixed_Name(rdau, "detailsOfTapeConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfTrackConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfTrackConfiguration.en">http://rdaregistry.info/Elements/u/detailsOfTrackConfiguration.en</seealso>
    let ``detailsOfTrackConfiguration.en`` =
        Prefixed_Name(rdau, "detailsOfTrackConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfTypeOfRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfTypeOfRecording.en">http://rdaregistry.info/Elements/u/detailsOfTypeOfRecording.en</seealso>
    let ``detailsOfTypeOfRecording.en`` =
        Prefixed_Name(rdau, "detailsOfTypeOfRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfVideoCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfVideoCharacteristic.en">http://rdaregistry.info/Elements/u/detailsOfVideoCharacteristic.en</seealso>
    let ``detailsOfVideoCharacteristic.en`` =
        Prefixed_Name(rdau, "detailsOfVideoCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:detailsOfVideoFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/detailsOfVideoFormat.en">http://rdaregistry.info/Elements/u/detailsOfVideoFormat.en</seealso>
    let ``detailsOfVideoFormat.en`` =
        Prefixed_Name(rdau, "detailsOfVideoFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:digestOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digestOf.en">http://rdaregistry.info/Elements/u/digestOf.en</seealso>
    let ``digestOf.en`` = Prefixed_Name(rdau, "digestOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:digestedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digestedAs.en">http://rdaregistry.info/Elements/u/digestedAs.en</seealso>
    let ``digestedAs.en`` = Prefixed_Name(rdau, "digestedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:digitalFileCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digitalFileCharacteristic.en">http://rdaregistry.info/Elements/u/digitalFileCharacteristic.en</seealso>
    let ``digitalFileCharacteristic.en`` =
        Prefixed_Name(rdau, "digitalFileCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:digitalRepresentationOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digitalRepresentationOfCartographicContent.en">http://rdaregistry.info/Elements/u/digitalRepresentationOfCartographicContent.en</seealso>
    let ``digitalRepresentationOfCartographicContent.en`` =
        Prefixed_Name(rdau, "digitalRepresentationOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:digitalTransfer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digitalTransfer.en">http://rdaregistry.info/Elements/u/digitalTransfer.en</seealso>
    let ``digitalTransfer.en`` =
        Prefixed_Name(rdau, "digitalTransfer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:digitalTransferOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/digitalTransferOf.en">http://rdaregistry.info/Elements/u/digitalTransferOf.en</seealso>
    let ``digitalTransferOf.en`` =
        Prefixed_Name(rdau, "digitalTransferOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dimensions.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dimensions.en">http://rdaregistry.info/Elements/u/dimensions.en</seealso>
    let ``dimensions.en`` = Prefixed_Name(rdau, "dimensions.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dimensionsOfMapEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dimensionsOfMapEtc.en">http://rdaregistry.info/Elements/u/dimensionsOfMapEtc.en</seealso>
    let ``dimensionsOfMapEtc.en`` =
        Prefixed_Name(rdau, "dimensionsOfMapEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dimensionsOfStillImage.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dimensionsOfStillImage.en">http://rdaregistry.info/Elements/u/dimensionsOfStillImage.en</seealso>
    let ``dimensionsOfStillImage.en`` =
        Prefixed_Name(rdau, "dimensionsOfStillImage.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:director.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/director.en">http://rdaregistry.info/Elements/u/director.en</seealso>
    let ``director.en`` = Prefixed_Name(rdau, "director.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:directorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/directorOf.en">http://rdaregistry.info/Elements/u/directorOf.en</seealso>
    let ``directorOf.en`` = Prefixed_Name(rdau, "directorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:directorOfPhotography.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/directorOfPhotography.en">http://rdaregistry.info/Elements/u/directorOfPhotography.en</seealso>
    let ``directorOfPhotography.en`` =
        Prefixed_Name(rdau, "directorOfPhotography.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:directorOfPhotographyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/directorOfPhotographyOf.en">http://rdaregistry.info/Elements/u/directorOfPhotographyOf.en</seealso>
    let ``directorOfPhotographyOf.en`` =
        Prefixed_Name(rdau, "directorOfPhotographyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dissertationOrThesisInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dissertationOrThesisInformation.en">http://rdaregistry.info/Elements/u/dissertationOrThesisInformation.en</seealso>
    let ``dissertationOrThesisInformation.en`` =
        Prefixed_Name(rdau, "dissertationOrThesisInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:distributionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/distributionStatement.en">http://rdaregistry.info/Elements/u/distributionStatement.en</seealso>
    let ``distributionStatement.en`` =
        Prefixed_Name(rdau, "distributionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:distributor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/distributor.en">http://rdaregistry.info/Elements/u/distributor.en</seealso>
    let ``distributor.en`` = Prefixed_Name(rdau, "distributor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:distributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/distributorOf.en">http://rdaregistry.info/Elements/u/distributorOf.en</seealso>
    let ``distributorOf.en`` = Prefixed_Name(rdau, "distributorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:distributorsName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/distributorsName.en">http://rdaregistry.info/Elements/u/distributorsName.en</seealso>
    let ``distributorsName.en`` =
        Prefixed_Name(rdau, "distributorsName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:donor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/donor.en">http://rdaregistry.info/Elements/u/donor.en</seealso>
    let ``donor.en`` = Prefixed_Name(rdau, "donor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:donorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/donorOf.en">http://rdaregistry.info/Elements/u/donorOf.en</seealso>
    let ``donorOf.en`` = Prefixed_Name(rdau, "donorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:draftsman.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/draftsman.en">http://rdaregistry.info/Elements/u/draftsman.en</seealso>
    let ``draftsman.en`` = Prefixed_Name(rdau, "draftsman.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:draftsmanOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/draftsmanOf.en">http://rdaregistry.info/Elements/u/draftsmanOf.en</seealso>
    let ``draftsmanOf.en`` = Prefixed_Name(rdau, "draftsmanOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dramatizationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dramatizationOf.en">http://rdaregistry.info/Elements/u/dramatizationOf.en</seealso>
    let ``dramatizationOf.en`` =
        Prefixed_Name(rdau, "dramatizationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dramatizedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dramatizedAs.en">http://rdaregistry.info/Elements/u/dramatizedAs.en</seealso>
    let ``dramatizedAs.en`` = Prefixed_Name(rdau, "dramatizedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:dubbedVersion.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dubbedVersion.en">http://rdaregistry.info/Elements/u/dubbedVersion.en</seealso>
    let ``dubbedVersion.en`` = Prefixed_Name(rdau, "dubbedVersion.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:dubbedVersionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/dubbedVersionOf.en">http://rdaregistry.info/Elements/u/dubbedVersionOf.en</seealso>
    let ``dubbedVersionOf.en`` =
        Prefixed_Name(rdau, "dubbedVersionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:duration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/duration.en">http://rdaregistry.info/Elements/u/duration.en</seealso>
    let ``duration.en`` = Prefixed_Name(rdau, "duration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:earlierTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/earlierTitleProper.en">http://rdaregistry.info/Elements/u/earlierTitleProper.en</seealso>
    let ``earlierTitleProper.en`` =
        Prefixed_Name(rdau, "earlierTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:editionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/editionStatement.en">http://rdaregistry.info/Elements/u/editionStatement.en</seealso>
    let ``editionStatement.en`` =
        Prefixed_Name(rdau, "editionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:editor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/editor.en">http://rdaregistry.info/Elements/u/editor.en</seealso>
    let ``editor.en`` = Prefixed_Name(rdau, "editor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:editorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/editorOf.en">http://rdaregistry.info/Elements/u/editorOf.en</seealso>
    let ``editorOf.en`` = Prefixed_Name(rdau, "editorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:editorOfMovingImageResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/editorOfMovingImageResource.en">http://rdaregistry.info/Elements/u/editorOfMovingImageResource.en</seealso>
    let ``editorOfMovingImageResource.en`` =
        Prefixed_Name(rdau, "editorOfMovingImageResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:editorOfMovingImageResourceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/editorOfMovingImageResourceOf.en">http://rdaregistry.info/Elements/u/editorOfMovingImageResourceOf.en</seealso>
    let ``editorOfMovingImageResourceOf.en`` =
        Prefixed_Name(rdau, "editorOfMovingImageResourceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:electronicReproduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/electronicReproduction.en">http://rdaregistry.info/Elements/u/electronicReproduction.en</seealso>
    let ``electronicReproduction.en`` =
        Prefixed_Name(rdau, "electronicReproduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:electronicReproductionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/electronicReproductionOf.en">http://rdaregistry.info/Elements/u/electronicReproductionOf.en</seealso>
    let ``electronicReproductionOf.en`` =
        Prefixed_Name(rdau, "electronicReproductionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:employee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/employee.en">http://rdaregistry.info/Elements/u/employee.en</seealso>
    let ``employee.en`` = Prefixed_Name(rdau, "employee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:employer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/employer.en">http://rdaregistry.info/Elements/u/employer.en</seealso>
    let ``employer.en`` = Prefixed_Name(rdau, "employer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:emulsionOnMicrofilmAndMicrofiche.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/emulsionOnMicrofilmAndMicrofiche.en">http://rdaregistry.info/Elements/u/emulsionOnMicrofilmAndMicrofiche.en</seealso>
    let ``emulsionOnMicrofilmAndMicrofiche.en`` =
        Prefixed_Name(rdau, "emulsionOnMicrofilmAndMicrofiche.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:enactingJurisdiction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/enactingJurisdiction.en">http://rdaregistry.info/Elements/u/enactingJurisdiction.en</seealso>
    let ``enactingJurisdiction.en`` =
        Prefixed_Name(rdau, "enactingJurisdiction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:enactingJurisdictionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/enactingJurisdictionOf.en">http://rdaregistry.info/Elements/u/enactingJurisdictionOf.en</seealso>
    let ``enactingJurisdictionOf.en`` =
        Prefixed_Name(rdau, "enactingJurisdictionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:encodedBitrate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/encodedBitrate.en">http://rdaregistry.info/Elements/u/encodedBitrate.en</seealso>
    let ``encodedBitrate.en`` = Prefixed_Name(rdau, "encodedBitrate.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:encodingFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/encodingFormat.en">http://rdaregistry.info/Elements/u/encodingFormat.en</seealso>
    let ``encodingFormat.en`` = Prefixed_Name(rdau, "encodingFormat.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:engraver.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/engraver.en">http://rdaregistry.info/Elements/u/engraver.en</seealso>
    let ``engraver.en`` = Prefixed_Name(rdau, "engraver.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:engraverOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/engraverOf.en">http://rdaregistry.info/Elements/u/engraverOf.en</seealso>
    let ``engraverOf.en`` = Prefixed_Name(rdau, "engraverOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:epoch.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/epoch.en">http://rdaregistry.info/Elements/u/epoch.en</seealso>
    let ``epoch.en`` = Prefixed_Name(rdau, "epoch.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:equinox.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/equinox.en">http://rdaregistry.info/Elements/u/equinox.en</seealso>
    let ``equinox.en`` = Prefixed_Name(rdau, "equinox.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:equipmentOrSystemRequirement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/equipmentOrSystemRequirement.en">http://rdaregistry.info/Elements/u/equipmentOrSystemRequirement.en</seealso>
    let ``equipmentOrSystemRequirement.en`` =
        Prefixed_Name(rdau, "equipmentOrSystemRequirement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:equivalent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/equivalent.en">http://rdaregistry.info/Elements/u/equivalent.en</seealso>
    let ``equivalent.en`` = Prefixed_Name(rdau, "equivalent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:equivalentResourceRelationshipWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/equivalentResourceRelationshipWith.en">http://rdaregistry.info/Elements/u/equivalentResourceRelationshipWith.en</seealso>
    let ``equivalentResourceRelationshipWith.en`` =
        Prefixed_Name(rdau, "equivalentResourceRelationshipWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:errata.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/errata.en">http://rdaregistry.info/Elements/u/errata.en</seealso>
    let ``errata.en`` = Prefixed_Name(rdau, "errata.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:errataTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/errataTo.en">http://rdaregistry.info/Elements/u/errataTo.en</seealso>
    let ``errataTo.en`` = Prefixed_Name(rdau, "errataTo.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:etcher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/etcher.en">http://rdaregistry.info/Elements/u/etcher.en</seealso>
    let ``etcher.en`` = Prefixed_Name(rdau, "etcher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:etcherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/etcherOf.en">http://rdaregistry.info/Elements/u/etcherOf.en</seealso>
    let ``etcherOf.en`` = Prefixed_Name(rdau, "etcherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:evaluatedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/evaluatedIn.en">http://rdaregistry.info/Elements/u/evaluatedIn.en</seealso>
    let ``evaluatedIn.en`` = Prefixed_Name(rdau, "evaluatedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:evaluationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/evaluationOf.en">http://rdaregistry.info/Elements/u/evaluationOf.en</seealso>
    let ``evaluationOf.en`` = Prefixed_Name(rdau, "evaluationOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:expandedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/expandedAs.en">http://rdaregistry.info/Elements/u/expandedAs.en</seealso>
    let ``expandedAs.en`` = Prefixed_Name(rdau, "expandedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:expandedVersionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/expandedVersionOf.en">http://rdaregistry.info/Elements/u/expandedVersionOf.en</seealso>
    let ``expandedVersionOf.en`` =
        Prefixed_Name(rdau, "expandedVersionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:extent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/extent.en">http://rdaregistry.info/Elements/u/extent.en</seealso>
    let ``extent.en`` = Prefixed_Name(rdau, "extent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:facsimile.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/facsimile.en">http://rdaregistry.info/Elements/u/facsimile.en</seealso>
    let ``facsimile.en`` = Prefixed_Name(rdau, "facsimile.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:facsimileContainedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/facsimileContainedIn.en">http://rdaregistry.info/Elements/u/facsimileContainedIn.en</seealso>
    let ``facsimileContainedIn.en`` =
        Prefixed_Name(rdau, "facsimileContainedIn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:facsimileContainerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/facsimileContainerOf.en">http://rdaregistry.info/Elements/u/facsimileContainerOf.en</seealso>
    let ``facsimileContainerOf.en`` =
        Prefixed_Name(rdau, "facsimileContainerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:facsimileOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/facsimileOf.en">http://rdaregistry.info/Elements/u/facsimileOf.en</seealso>
    let ``facsimileOf.en`` = Prefixed_Name(rdau, "facsimileOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:fieldOfActivity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/fieldOfActivity.en">http://rdaregistry.info/Elements/u/fieldOfActivity.en</seealso>
    let ``fieldOfActivity.en`` =
        Prefixed_Name(rdau, "fieldOfActivity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:fileSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/fileSize.en">http://rdaregistry.info/Elements/u/fileSize.en</seealso>
    let ``fileSize.en`` = Prefixed_Name(rdau, "fileSize.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:fileType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/fileType.en">http://rdaregistry.info/Elements/u/fileType.en</seealso>
    let ``fileType.en`` = Prefixed_Name(rdau, "fileType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmDirector.en">http://rdaregistry.info/Elements/u/filmDirector.en</seealso>
    let ``filmDirector.en`` = Prefixed_Name(rdau, "filmDirector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmDirectorOf.en">http://rdaregistry.info/Elements/u/filmDirectorOf.en</seealso>
    let ``filmDirectorOf.en`` = Prefixed_Name(rdau, "filmDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:filmDistributor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmDistributor.en">http://rdaregistry.info/Elements/u/filmDistributor.en</seealso>
    let ``filmDistributor.en`` =
        Prefixed_Name(rdau, "filmDistributor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:filmDistributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmDistributorOf.en">http://rdaregistry.info/Elements/u/filmDistributorOf.en</seealso>
    let ``filmDistributorOf.en`` =
        Prefixed_Name(rdau, "filmDistributorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:filmProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmProducer.en">http://rdaregistry.info/Elements/u/filmProducer.en</seealso>
    let ``filmProducer.en`` = Prefixed_Name(rdau, "filmProducer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmProducerOf.en">http://rdaregistry.info/Elements/u/filmProducerOf.en</seealso>
    let ``filmProducerOf.en`` = Prefixed_Name(rdau, "filmProducerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmedWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmedWith.en">http://rdaregistry.info/Elements/u/filmedWith.en</seealso>
    let ``filmedWith.en`` = Prefixed_Name(rdau, "filmedWith.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmmaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmmaker.en">http://rdaregistry.info/Elements/u/filmmaker.en</seealso>
    let ``filmmaker.en`` = Prefixed_Name(rdau, "filmmaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:filmmakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/filmmakerOf.en">http://rdaregistry.info/Elements/u/filmmakerOf.en</seealso>
    let ``filmmakerOf.en`` = Prefixed_Name(rdau, "filmmakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:findingAid.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/findingAid.en">http://rdaregistry.info/Elements/u/findingAid.en</seealso>
    let ``findingAid.en`` = Prefixed_Name(rdau, "findingAid.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:findingAidFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/findingAidFor.en">http://rdaregistry.info/Elements/u/findingAidFor.en</seealso>
    let ``findingAidFor.en`` = Prefixed_Name(rdau, "findingAidFor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:fontSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/fontSize.en">http://rdaregistry.info/Elements/u/fontSize.en</seealso>
    let ``fontSize.en`` = Prefixed_Name(rdau, "fontSize.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formOfMusicalNotation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formOfMusicalNotation.en">http://rdaregistry.info/Elements/u/formOfMusicalNotation.en</seealso>
    let ``formOfMusicalNotation.en`` =
        Prefixed_Name(rdau, "formOfMusicalNotation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formOfNotatedMovement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formOfNotatedMovement.en">http://rdaregistry.info/Elements/u/formOfNotatedMovement.en</seealso>
    let ``formOfNotatedMovement.en`` =
        Prefixed_Name(rdau, "formOfNotatedMovement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formOfNotation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formOfNotation.en">http://rdaregistry.info/Elements/u/formOfNotation.en</seealso>
    let ``formOfNotation.en`` = Prefixed_Name(rdau, "formOfNotation.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:formOfResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formOfResource.en">http://rdaregistry.info/Elements/u/formOfResource.en</seealso>
    let ``formOfResource.en`` = Prefixed_Name(rdau, "formOfResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formOfTactileNotation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formOfTactileNotation.en">http://rdaregistry.info/Elements/u/formOfTactileNotation.en</seealso>
    let ``formOfTactileNotation.en`` =
        Prefixed_Name(rdau, "formOfTactileNotation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formatOfNotatedMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formatOfNotatedMusic.en">http://rdaregistry.info/Elements/u/formatOfNotatedMusic.en</seealso>
    let ``formatOfNotatedMusic.en`` =
        Prefixed_Name(rdau, "formatOfNotatedMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:formerOwner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formerOwner.en">http://rdaregistry.info/Elements/u/formerOwner.en</seealso>
    let ``formerOwner.en`` = Prefixed_Name(rdau, "formerOwner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:formerOwnerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/formerOwnerOf.en">http://rdaregistry.info/Elements/u/formerOwnerOf.en</seealso>
    let ``formerOwnerOf.en`` = Prefixed_Name(rdau, "formerOwnerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:foundedEntity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/foundedEntity.en">http://rdaregistry.info/Elements/u/foundedEntity.en</seealso>
    let ``foundedEntity.en`` = Prefixed_Name(rdau, "foundedEntity.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:founder.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/founder.en">http://rdaregistry.info/Elements/u/founder.en</seealso>
    let ``founder.en`` = Prefixed_Name(rdau, "founder.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:freeTranslationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/freeTranslationOf.en">http://rdaregistry.info/Elements/u/freeTranslationOf.en</seealso>
    let ``freeTranslationOf.en`` =
        Prefixed_Name(rdau, "freeTranslationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:freelyTranslatedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/freelyTranslatedAs.en">http://rdaregistry.info/Elements/u/freelyTranslatedAs.en</seealso>
    let ``freelyTranslatedAs.en`` =
        Prefixed_Name(rdau, "freelyTranslatedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:frequency.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/frequency.en">http://rdaregistry.info/Elements/u/frequency.en</seealso>
    let ``frequency.en`` = Prefixed_Name(rdau, "frequency.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:fullerFormOfName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/fullerFormOfName.en">http://rdaregistry.info/Elements/u/fullerFormOfName.en</seealso>
    let ``fullerFormOfName.en`` =
        Prefixed_Name(rdau, "fullerFormOfName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:gender.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/gender.en">http://rdaregistry.info/Elements/u/gender.en</seealso>
    let ``gender.en`` = Prefixed_Name(rdau, "gender.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:generation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generation.en">http://rdaregistry.info/Elements/u/generation.en</seealso>
    let ``generation.en`` = Prefixed_Name(rdau, "generation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:generationOfAudioRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generationOfAudioRecording.en">http://rdaregistry.info/Elements/u/generationOfAudioRecording.en</seealso>
    let ``generationOfAudioRecording.en`` =
        Prefixed_Name(rdau, "generationOfAudioRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:generationOfDigitalResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generationOfDigitalResource.en">http://rdaregistry.info/Elements/u/generationOfDigitalResource.en</seealso>
    let ``generationOfDigitalResource.en`` =
        Prefixed_Name(rdau, "generationOfDigitalResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:generationOfMicroform.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generationOfMicroform.en">http://rdaregistry.info/Elements/u/generationOfMicroform.en</seealso>
    let ``generationOfMicroform.en`` =
        Prefixed_Name(rdau, "generationOfMicroform.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:generationOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generationOfMotionPictureFilm.en">http://rdaregistry.info/Elements/u/generationOfMotionPictureFilm.en</seealso>
    let ``generationOfMotionPictureFilm.en`` =
        Prefixed_Name(rdau, "generationOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:generationOfVideotape.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/generationOfVideotape.en">http://rdaregistry.info/Elements/u/generationOfVideotape.en</seealso>
    let ``generationOfVideotape.en`` =
        Prefixed_Name(rdau, "generationOfVideotape.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:graduate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/graduate.en">http://rdaregistry.info/Elements/u/graduate.en</seealso>
    let ``graduate.en`` = Prefixed_Name(rdau, "graduate.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:graduateOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/graduateOf.en">http://rdaregistry.info/Elements/u/graduateOf.en</seealso>
    let ``graduateOf.en`` = Prefixed_Name(rdau, "graduateOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:grantingInstitutionOrFaculty.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/grantingInstitutionOrFaculty.en">http://rdaregistry.info/Elements/u/grantingInstitutionOrFaculty.en</seealso>
    let ``grantingInstitutionOrFaculty.en`` =
        Prefixed_Name(rdau, "grantingInstitutionOrFaculty.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:graphicNovelizationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/graphicNovelizationOf.en">http://rdaregistry.info/Elements/u/graphicNovelizationOf.en</seealso>
    let ``graphicNovelizationOf.en`` =
        Prefixed_Name(rdau, "graphicNovelizationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:grooveCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/grooveCharacteristic.en">http://rdaregistry.info/Elements/u/grooveCharacteristic.en</seealso>
    let ``grooveCharacteristic.en`` =
        Prefixed_Name(rdau, "grooveCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:guide.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/guide.en">http://rdaregistry.info/Elements/u/guide.en</seealso>
    let ``guide.en`` = Prefixed_Name(rdau, "guide.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:guideTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/guideTo.en">http://rdaregistry.info/Elements/u/guideTo.en</seealso>
    let ``guideTo.en`` = Prefixed_Name(rdau, "guideTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hereditaryTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hereditaryTitle.en">http://rdaregistry.info/Elements/u/hereditaryTitle.en</seealso>
    let ``hereditaryTitle.en`` =
        Prefixed_Name(rdau, "hereditaryTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hierarchicalSubordinate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hierarchicalSubordinate.en">http://rdaregistry.info/Elements/u/hierarchicalSubordinate.en</seealso>
    let ``hierarchicalSubordinate.en`` =
        Prefixed_Name(rdau, "hierarchicalSubordinate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hierarchicalSuperior.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hierarchicalSuperior.en">http://rdaregistry.info/Elements/u/hierarchicalSuperior.en</seealso>
    let ``hierarchicalSuperior.en`` =
        Prefixed_Name(rdau, "hierarchicalSuperior.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:historyOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/historyOfTheResource.en">http://rdaregistry.info/Elements/u/historyOfTheResource.en</seealso>
    let ``historyOfTheResource.en`` =
        Prefixed_Name(rdau, "historyOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:honouree.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/honouree.en">http://rdaregistry.info/Elements/u/honouree.en</seealso>
    let ``honouree.en`` = Prefixed_Name(rdau, "honouree.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:honoureeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/honoureeOf.en">http://rdaregistry.info/Elements/u/honoureeOf.en</seealso>
    let ``honoureeOf.en`` = Prefixed_Name(rdau, "honoureeOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:horizontalScaleOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/horizontalScaleOfCartographicContent.en">http://rdaregistry.info/Elements/u/horizontalScaleOfCartographicContent.en</seealso>
    let ``horizontalScaleOfCartographicContent.en`` =
        Prefixed_Name(rdau, "horizontalScaleOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:host.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/host.en">http://rdaregistry.info/Elements/u/host.en</seealso>
    let ``host.en`` = Prefixed_Name(rdau, "host.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hostInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hostInstitution.en">http://rdaregistry.info/Elements/u/hostInstitution.en</seealso>
    let ``hostInstitution.en`` =
        Prefixed_Name(rdau, "hostInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hostInstitutionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hostInstitutionOf.en">http://rdaregistry.info/Elements/u/hostInstitutionOf.en</seealso>
    let ``hostInstitutionOf.en`` =
        Prefixed_Name(rdau, "hostInstitutionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:hostOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/hostOf.en">http://rdaregistry.info/Elements/u/hostOf.en</seealso>
    let ``hostOf.en`` = Prefixed_Name(rdau, "hostOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:identifierForTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/identifierForTheAgent.en">http://rdaregistry.info/Elements/u/identifierForTheAgent.en</seealso>
    let ``identifierForTheAgent.en`` =
        Prefixed_Name(rdau, "identifierForTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:identifierForTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/identifierForTheResource.en">http://rdaregistry.info/Elements/u/identifierForTheResource.en</seealso>
    let ``identifierForTheResource.en`` =
        Prefixed_Name(rdau, "identifierForTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:illuminator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illuminator.en">http://rdaregistry.info/Elements/u/illuminator.en</seealso>
    let ``illuminator.en`` = Prefixed_Name(rdau, "illuminator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:illuminatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illuminatorOf.en">http://rdaregistry.info/Elements/u/illuminatorOf.en</seealso>
    let ``illuminatorOf.en`` = Prefixed_Name(rdau, "illuminatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:illustrations.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illustrations.en">http://rdaregistry.info/Elements/u/illustrations.en</seealso>
    let ``illustrations.en`` = Prefixed_Name(rdau, "illustrations.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:illustrationsFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illustrationsFor.en">http://rdaregistry.info/Elements/u/illustrationsFor.en</seealso>
    let ``illustrationsFor.en`` =
        Prefixed_Name(rdau, "illustrationsFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:illustrativeContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illustrativeContent.en">http://rdaregistry.info/Elements/u/illustrativeContent.en</seealso>
    let ``illustrativeContent.en`` =
        Prefixed_Name(rdau, "illustrativeContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:illustrator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illustrator.en">http://rdaregistry.info/Elements/u/illustrator.en</seealso>
    let ``illustrator.en`` = Prefixed_Name(rdau, "illustrator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:illustratorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/illustratorOf.en">http://rdaregistry.info/Elements/u/illustratorOf.en</seealso>
    let ``illustratorOf.en`` = Prefixed_Name(rdau, "illustratorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:imitatedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/imitatedAs.en">http://rdaregistry.info/Elements/u/imitatedAs.en</seealso>
    let ``imitatedAs.en`` = Prefixed_Name(rdau, "imitatedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:imitationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/imitationOf.en">http://rdaregistry.info/Elements/u/imitationOf.en</seealso>
    let ``imitationOf.en`` = Prefixed_Name(rdau, "imitationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:immediateSourceOfAcquisitionOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/immediateSourceOfAcquisitionOfItem.en">http://rdaregistry.info/Elements/u/immediateSourceOfAcquisitionOfItem.en</seealso>
    let ``immediateSourceOfAcquisitionOfItem.en`` =
        Prefixed_Name(rdau, "immediateSourceOfAcquisitionOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:inSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inSeries.en">http://rdaregistry.info/Elements/u/inSeries.en</seealso>
    let ``inSeries.en`` = Prefixed_Name(rdau, "inSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:incidentalMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/incidentalMusic.en">http://rdaregistry.info/Elements/u/incidentalMusic.en</seealso>
    let ``incidentalMusic.en`` =
        Prefixed_Name(rdau, "incidentalMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:incidentalMusicFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/incidentalMusicFor.en">http://rdaregistry.info/Elements/u/incidentalMusicFor.en</seealso>
    let ``incidentalMusicFor.en`` =
        Prefixed_Name(rdau, "incidentalMusicFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:incumbent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/incumbent.en">http://rdaregistry.info/Elements/u/incumbent.en</seealso>
    let ``incumbent.en`` = Prefixed_Name(rdau, "incumbent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:index.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/index.en">http://rdaregistry.info/Elements/u/index.en</seealso>
    let ``index.en`` = Prefixed_Name(rdau, "index.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:indexTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/indexTo.en">http://rdaregistry.info/Elements/u/indexTo.en</seealso>
    let ``indexTo.en`` = Prefixed_Name(rdau, "indexTo.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:indexedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/indexedIn.en">http://rdaregistry.info/Elements/u/indexedIn.en</seealso>
    let ``indexedIn.en`` = Prefixed_Name(rdau, "indexedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:indexingFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/indexingFor.en">http://rdaregistry.info/Elements/u/indexingFor.en</seealso>
    let ``indexingFor.en`` = Prefixed_Name(rdau, "indexingFor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inscriber.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inscriber.en">http://rdaregistry.info/Elements/u/inscriber.en</seealso>
    let ``inscriber.en`` = Prefixed_Name(rdau, "inscriber.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inscriberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inscriberOf.en">http://rdaregistry.info/Elements/u/inscriberOf.en</seealso>
    let ``inscriberOf.en`` = Prefixed_Name(rdau, "inscriberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:insert.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/insert.en">http://rdaregistry.info/Elements/u/insert.en</seealso>
    let ``insert.en`` = Prefixed_Name(rdau, "insert.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:insertedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/insertedIn.en">http://rdaregistry.info/Elements/u/insertedIn.en</seealso>
    let ``insertedIn.en`` = Prefixed_Name(rdau, "insertedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inspirationFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inspirationFor.en">http://rdaregistry.info/Elements/u/inspirationFor.en</seealso>
    let ``inspirationFor.en`` = Prefixed_Name(rdau, "inspirationFor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inspiredBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inspiredBy.en">http://rdaregistry.info/Elements/u/inspiredBy.en</seealso>
    let ``inspiredBy.en`` = Prefixed_Name(rdau, "inspiredBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:instrumentalConductor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/instrumentalConductor.en">http://rdaregistry.info/Elements/u/instrumentalConductor.en</seealso>
    let ``instrumentalConductor.en`` =
        Prefixed_Name(rdau, "instrumentalConductor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:instrumentalConductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/instrumentalConductorOf.en">http://rdaregistry.info/Elements/u/instrumentalConductorOf.en</seealso>
    let ``instrumentalConductorOf.en`` =
        Prefixed_Name(rdau, "instrumentalConductorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:instrumentalist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/instrumentalist.en">http://rdaregistry.info/Elements/u/instrumentalist.en</seealso>
    let ``instrumentalist.en`` =
        Prefixed_Name(rdau, "instrumentalist.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:instrumentalistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/instrumentalistOf.en">http://rdaregistry.info/Elements/u/instrumentalistOf.en</seealso>
    let ``instrumentalistOf.en`` =
        Prefixed_Name(rdau, "instrumentalistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:intendedAudience.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/intendedAudience.en">http://rdaregistry.info/Elements/u/intendedAudience.en</seealso>
    let ``intendedAudience.en`` =
        Prefixed_Name(rdau, "intendedAudience.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:interviewee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/interviewee.en">http://rdaregistry.info/Elements/u/interviewee.en</seealso>
    let ``interviewee.en`` = Prefixed_Name(rdau, "interviewee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:intervieweeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/intervieweeOf.en">http://rdaregistry.info/Elements/u/intervieweeOf.en</seealso>
    let ``intervieweeOf.en`` = Prefixed_Name(rdau, "intervieweeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:interviewer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/interviewer.en">http://rdaregistry.info/Elements/u/interviewer.en</seealso>
    let ``interviewer.en`` = Prefixed_Name(rdau, "interviewer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:interviewerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/interviewerOf.en">http://rdaregistry.info/Elements/u/interviewerOf.en</seealso>
    let ``interviewerOf.en`` = Prefixed_Name(rdau, "interviewerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inventor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inventor.en">http://rdaregistry.info/Elements/u/inventor.en</seealso>
    let ``inventor.en`` = Prefixed_Name(rdau, "inventor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:inventorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/inventorOf.en">http://rdaregistry.info/Elements/u/inventorOf.en</seealso>
    let ``inventorOf.en`` = Prefixed_Name(rdau, "inventorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:issnOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/issnOfSeries.en">http://rdaregistry.info/Elements/u/issnOfSeries.en</seealso>
    let ``issnOfSeries.en`` = Prefixed_Name(rdau, "issnOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:issnOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/issnOfSubseries.en">http://rdaregistry.info/Elements/u/issnOfSubseries.en</seealso>
    let ``issnOfSubseries.en`` =
        Prefixed_Name(rdau, "issnOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:issuedWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/issuedWith.en">http://rdaregistry.info/Elements/u/issuedWith.en</seealso>
    let ``issuedWith.en`` = Prefixed_Name(rdau, "issuedWith.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:issuingBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/issuingBody.en">http://rdaregistry.info/Elements/u/issuingBody.en</seealso>
    let ``issuingBody.en`` = Prefixed_Name(rdau, "issuingBody.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:issuingBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/issuingBodyOf.en">http://rdaregistry.info/Elements/u/issuingBodyOf.en</seealso>
    let ``issuingBodyOf.en`` = Prefixed_Name(rdau, "issuingBodyOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:judge.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/judge.en">http://rdaregistry.info/Elements/u/judge.en</seealso>
    let ``judge.en`` = Prefixed_Name(rdau, "judge.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:judgeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/judgeOf.en">http://rdaregistry.info/Elements/u/judgeOf.en</seealso>
    let ``judgeOf.en`` = Prefixed_Name(rdau, "judgeOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:jurisdictionGoverned.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/jurisdictionGoverned.en">http://rdaregistry.info/Elements/u/jurisdictionGoverned.en</seealso>
    let ``jurisdictionGoverned.en`` =
        Prefixed_Name(rdau, "jurisdictionGoverned.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:jurisdictionGovernedOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/jurisdictionGovernedOf.en">http://rdaregistry.info/Elements/u/jurisdictionGovernedOf.en</seealso>
    let ``jurisdictionGovernedOf.en`` =
        Prefixed_Name(rdau, "jurisdictionGovernedOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:key.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/key.en">http://rdaregistry.info/Elements/u/key.en</seealso>
    let ``key.en`` = Prefixed_Name(rdau, "key.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:keyTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/keyTitle.en">http://rdaregistry.info/Elements/u/keyTitle.en</seealso>
    let ``keyTitle.en`` = Prefixed_Name(rdau, "keyTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:landscapeArchitect.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/landscapeArchitect.en">http://rdaregistry.info/Elements/u/landscapeArchitect.en</seealso>
    let ``landscapeArchitect.en`` =
        Prefixed_Name(rdau, "landscapeArchitect.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:landscapeArchitectOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/landscapeArchitectOf.en">http://rdaregistry.info/Elements/u/landscapeArchitectOf.en</seealso>
    let ``landscapeArchitectOf.en`` =
        Prefixed_Name(rdau, "landscapeArchitectOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:languageOfTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/languageOfTheAgent.en">http://rdaregistry.info/Elements/u/languageOfTheAgent.en</seealso>
    let ``languageOfTheAgent.en`` =
        Prefixed_Name(rdau, "languageOfTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:languageOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/languageOfTheContent.en">http://rdaregistry.info/Elements/u/languageOfTheContent.en</seealso>
    let ``languageOfTheContent.en`` =
        Prefixed_Name(rdau, "languageOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:laterTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/laterTitleProper.en">http://rdaregistry.info/Elements/u/laterTitleProper.en</seealso>
    let ``laterTitleProper.en`` =
        Prefixed_Name(rdau, "laterTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:layout.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/layout.en">http://rdaregistry.info/Elements/u/layout.en</seealso>
    let ``layout.en`` = Prefixed_Name(rdau, "layout.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:letterer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/letterer.en">http://rdaregistry.info/Elements/u/letterer.en</seealso>
    let ``letterer.en`` = Prefixed_Name(rdau, "letterer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:lettererOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lettererOf.en">http://rdaregistry.info/Elements/u/lettererOf.en</seealso>
    let ``lettererOf.en`` = Prefixed_Name(rdau, "lettererOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:librettist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/librettist.en">http://rdaregistry.info/Elements/u/librettist.en</seealso>
    let ``librettist.en`` = Prefixed_Name(rdau, "librettist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:librettistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/librettistOf.en">http://rdaregistry.info/Elements/u/librettistOf.en</seealso>
    let ``librettistOf.en`` = Prefixed_Name(rdau, "librettistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:libretto.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/libretto.en">http://rdaregistry.info/Elements/u/libretto.en</seealso>
    let ``libretto.en`` = Prefixed_Name(rdau, "libretto.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:librettoBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/librettoBasedOn.en">http://rdaregistry.info/Elements/u/librettoBasedOn.en</seealso>
    let ``librettoBasedOn.en`` =
        Prefixed_Name(rdau, "librettoBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:librettoFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/librettoFor.en">http://rdaregistry.info/Elements/u/librettoFor.en</seealso>
    let ``librettoFor.en`` = Prefixed_Name(rdau, "librettoFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:lightingDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lightingDesigner.en">http://rdaregistry.info/Elements/u/lightingDesigner.en</seealso>
    let ``lightingDesigner.en`` =
        Prefixed_Name(rdau, "lightingDesigner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:lightingDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lightingDesignerOf.en">http://rdaregistry.info/Elements/u/lightingDesignerOf.en</seealso>
    let ``lightingDesignerOf.en`` =
        Prefixed_Name(rdau, "lightingDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:lithographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lithographer.en">http://rdaregistry.info/Elements/u/lithographer.en</seealso>
    let ``lithographer.en`` = Prefixed_Name(rdau, "lithographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:lithographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lithographerOf.en">http://rdaregistry.info/Elements/u/lithographerOf.en</seealso>
    let ``lithographerOf.en`` = Prefixed_Name(rdau, "lithographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:localAffiliate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/localAffiliate.en">http://rdaregistry.info/Elements/u/localAffiliate.en</seealso>
    let ``localAffiliate.en`` = Prefixed_Name(rdau, "localAffiliate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:locationOfConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/locationOfConferenceEtc.en">http://rdaregistry.info/Elements/u/locationOfConferenceEtc.en</seealso>
    let ``locationOfConferenceEtc.en`` =
        Prefixed_Name(rdau, "locationOfConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:locationOfHeadquarters.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/locationOfHeadquarters.en">http://rdaregistry.info/Elements/u/locationOfHeadquarters.en</seealso>
    let ``locationOfHeadquarters.en`` =
        Prefixed_Name(rdau, "locationOfHeadquarters.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:longitudeAndLatitude.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/longitudeAndLatitude.en">http://rdaregistry.info/Elements/u/longitudeAndLatitude.en</seealso>
    let ``longitudeAndLatitude.en`` =
        Prefixed_Name(rdau, "longitudeAndLatitude.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:lyricist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lyricist.en">http://rdaregistry.info/Elements/u/lyricist.en</seealso>
    let ``lyricist.en`` = Prefixed_Name(rdau, "lyricist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:lyricistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/lyricistOf.en">http://rdaregistry.info/Elements/u/lyricistOf.en</seealso>
    let ``lyricistOf.en`` = Prefixed_Name(rdau, "lyricistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:makeUpArtist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/makeUpArtist.en">http://rdaregistry.info/Elements/u/makeUpArtist.en</seealso>
    let ``makeUpArtist.en`` = Prefixed_Name(rdau, "makeUpArtist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:makeUpArtistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/makeUpArtistOf.en">http://rdaregistry.info/Elements/u/makeUpArtistOf.en</seealso>
    let ``makeUpArtistOf.en`` = Prefixed_Name(rdau, "makeUpArtistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:manufactureStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/manufactureStatement.en">http://rdaregistry.info/Elements/u/manufactureStatement.en</seealso>
    let ``manufactureStatement.en`` =
        Prefixed_Name(rdau, "manufactureStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:manufacturer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/manufacturer.en">http://rdaregistry.info/Elements/u/manufacturer.en</seealso>
    let ``manufacturer.en`` = Prefixed_Name(rdau, "manufacturer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:manufacturerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/manufacturerOf.en">http://rdaregistry.info/Elements/u/manufacturerOf.en</seealso>
    let ``manufacturerOf.en`` = Prefixed_Name(rdau, "manufacturerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:manufacturersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/manufacturersName.en">http://rdaregistry.info/Elements/u/manufacturersName.en</seealso>
    let ``manufacturersName.en`` =
        Prefixed_Name(rdau, "manufacturersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:mediaType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mediaType.en">http://rdaregistry.info/Elements/u/mediaType.en</seealso>
    let ``mediaType.en`` = Prefixed_Name(rdau, "mediaType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:medium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/medium.en">http://rdaregistry.info/Elements/u/medium.en</seealso>
    let ``medium.en`` = Prefixed_Name(rdau, "medium.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:mediumOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mediumOf.en">http://rdaregistry.info/Elements/u/mediumOf.en</seealso>
    let ``mediumOf.en`` = Prefixed_Name(rdau, "mediumOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:mediumOfPerformance.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mediumOfPerformance.en">http://rdaregistry.info/Elements/u/mediumOfPerformance.en</seealso>
    let ``mediumOfPerformance.en`` =
        Prefixed_Name(rdau, "mediumOfPerformance.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:mediumOfPerformanceOfMusicalContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mediumOfPerformanceOfMusicalContent.en">http://rdaregistry.info/Elements/u/mediumOfPerformanceOfMusicalContent.en</seealso>
    let ``mediumOfPerformanceOfMusicalContent.en`` =
        Prefixed_Name(rdau, "mediumOfPerformanceOfMusicalContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:member.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/member.en">http://rdaregistry.info/Elements/u/member.en</seealso>
    let ``member.en`` = Prefixed_Name(rdau, "member.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:memberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/memberOf.en">http://rdaregistry.info/Elements/u/memberOf.en</seealso>
    let ``memberOf.en`` = Prefixed_Name(rdau, "memberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:mergedToForm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mergedToForm.en">http://rdaregistry.info/Elements/u/mergedToForm.en</seealso>
    let ``mergedToForm.en`` = Prefixed_Name(rdau, "mergedToForm.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:mergee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mergee.en">http://rdaregistry.info/Elements/u/mergee.en</seealso>
    let ``mergee.en`` = Prefixed_Name(rdau, "mergee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:mergerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mergerOf.en">http://rdaregistry.info/Elements/u/mergerOf.en</seealso>
    let ``mergerOf.en`` = Prefixed_Name(rdau, "mergerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:minuteTaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/minuteTaker.en">http://rdaregistry.info/Elements/u/minuteTaker.en</seealso>
    let ``minuteTaker.en`` = Prefixed_Name(rdau, "minuteTaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:minuteTakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/minuteTakerOf.en">http://rdaregistry.info/Elements/u/minuteTakerOf.en</seealso>
    let ``minuteTakerOf.en`` = Prefixed_Name(rdau, "minuteTakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:mirrorSite.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mirrorSite.en">http://rdaregistry.info/Elements/u/mirrorSite.en</seealso>
    let ``mirrorSite.en`` = Prefixed_Name(rdau, "mirrorSite.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:modeOfIssuance.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/modeOfIssuance.en">http://rdaregistry.info/Elements/u/modeOfIssuance.en</seealso>
    let ``modeOfIssuance.en`` = Prefixed_Name(rdau, "modeOfIssuance.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:moderator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/moderator.en">http://rdaregistry.info/Elements/u/moderator.en</seealso>
    let ``moderator.en`` = Prefixed_Name(rdau, "moderator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:moderatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/moderatorOf.en">http://rdaregistry.info/Elements/u/moderatorOf.en</seealso>
    let ``moderatorOf.en`` = Prefixed_Name(rdau, "moderatorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:modifiedByVariationAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/modifiedByVariationAs.en">http://rdaregistry.info/Elements/u/modifiedByVariationAs.en</seealso>
    let ``modifiedByVariationAs.en`` =
        Prefixed_Name(rdau, "modifiedByVariationAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:motionPictureAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/motionPictureAdaptationOf.en">http://rdaregistry.info/Elements/u/motionPictureAdaptationOf.en</seealso>
    let ``motionPictureAdaptationOf.en`` =
        Prefixed_Name(rdau, "motionPictureAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:motionPictureMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/motionPictureMusic.en">http://rdaregistry.info/Elements/u/motionPictureMusic.en</seealso>
    let ``motionPictureMusic.en`` =
        Prefixed_Name(rdau, "motionPictureMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:motionPictureScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/motionPictureScreenplay.en">http://rdaregistry.info/Elements/u/motionPictureScreenplay.en</seealso>
    let ``motionPictureScreenplay.en`` =
        Prefixed_Name(rdau, "motionPictureScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:motionPictureScreenplayBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/motionPictureScreenplayBasedOn.en">http://rdaregistry.info/Elements/u/motionPictureScreenplayBasedOn.en</seealso>
    let ``motionPictureScreenplayBasedOn.en`` =
        Prefixed_Name(rdau, "motionPictureScreenplayBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:mount.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/mount.en">http://rdaregistry.info/Elements/u/mount.en</seealso>
    let ``mount.en`` = Prefixed_Name(rdau, "mount.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:music.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/music.en">http://rdaregistry.info/Elements/u/music.en</seealso>
    let ``music.en`` = Prefixed_Name(rdau, "music.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:musicFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicFor.en">http://rdaregistry.info/Elements/u/musicFor.en</seealso>
    let ``musicFor.en`` = Prefixed_Name(rdau, "musicFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicForMotionPicture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicForMotionPicture.en">http://rdaregistry.info/Elements/u/musicForMotionPicture.en</seealso>
    let ``musicForMotionPicture.en`` =
        Prefixed_Name(rdau, "musicForMotionPicture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicForRadioProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicForRadioProgram.en">http://rdaregistry.info/Elements/u/musicForRadioProgram.en</seealso>
    let ``musicForRadioProgram.en`` =
        Prefixed_Name(rdau, "musicForRadioProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicForTelevisionProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicForTelevisionProgram.en">http://rdaregistry.info/Elements/u/musicForTelevisionProgram.en</seealso>
    let ``musicForTelevisionProgram.en`` =
        Prefixed_Name(rdau, "musicForTelevisionProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicForVideo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicForVideo.en">http://rdaregistry.info/Elements/u/musicForVideo.en</seealso>
    let ``musicForVideo.en`` = Prefixed_Name(rdau, "musicForVideo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicalDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicalDirector.en">http://rdaregistry.info/Elements/u/musicalDirector.en</seealso>
    let ``musicalDirector.en`` =
        Prefixed_Name(rdau, "musicalDirector.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicalDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicalDirectorOf.en">http://rdaregistry.info/Elements/u/musicalDirectorOf.en</seealso>
    let ``musicalDirectorOf.en`` =
        Prefixed_Name(rdau, "musicalDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicalSettingOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicalSettingOf.en">http://rdaregistry.info/Elements/u/musicalSettingOf.en</seealso>
    let ``musicalSettingOf.en`` =
        Prefixed_Name(rdau, "musicalSettingOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:musicalTheatreAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/musicalTheatreAdaptationOf.en">http://rdaregistry.info/Elements/u/musicalTheatreAdaptationOf.en</seealso>
    let ``musicalTheatreAdaptationOf.en`` =
        Prefixed_Name(rdau, "musicalTheatreAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:nameOfTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/nameOfTheAgent.en">http://rdaregistry.info/Elements/u/nameOfTheAgent.en</seealso>
    let ``nameOfTheAgent.en`` = Prefixed_Name(rdau, "nameOfTheAgent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:nameOfThePlace.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/nameOfThePlace.en">http://rdaregistry.info/Elements/u/nameOfThePlace.en</seealso>
    let ``nameOfThePlace.en`` = Prefixed_Name(rdau, "nameOfThePlace.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:narrator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/narrator.en">http://rdaregistry.info/Elements/u/narrator.en</seealso>
    let ``narrator.en`` = Prefixed_Name(rdau, "narrator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:narratorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/narratorOf.en">http://rdaregistry.info/Elements/u/narratorOf.en</seealso>
    let ``narratorOf.en`` = Prefixed_Name(rdau, "narratorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:natureOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/natureOfTheContent.en">http://rdaregistry.info/Elements/u/natureOfTheContent.en</seealso>
    let ``natureOfTheContent.en`` =
        Prefixed_Name(rdau, "natureOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnChangesInCarrierCharacteristics.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnChangesInCarrierCharacteristics.en">http://rdaregistry.info/Elements/u/noteOnChangesInCarrierCharacteristics.en</seealso>
    let ``noteOnChangesInCarrierCharacteristics.en`` =
        Prefixed_Name(rdau, "noteOnChangesInCarrierCharacteristics.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnChangesInContentCharacteristics.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnChangesInContentCharacteristics.en">http://rdaregistry.info/Elements/u/noteOnChangesInContentCharacteristics.en</seealso>
    let ``noteOnChangesInContentCharacteristics.en`` =
        Prefixed_Name(rdau, "noteOnChangesInContentCharacteristics.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnCopyrightDate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnCopyrightDate.en">http://rdaregistry.info/Elements/u/noteOnCopyrightDate.en</seealso>
    let ``noteOnCopyrightDate.en`` =
        Prefixed_Name(rdau, "noteOnCopyrightDate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnDimensionsOfResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnDimensionsOfResource.en">http://rdaregistry.info/Elements/u/noteOnDimensionsOfResource.en</seealso>
    let ``noteOnDimensionsOfResource.en`` =
        Prefixed_Name(rdau, "noteOnDimensionsOfResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnDistributionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnDistributionStatement.en">http://rdaregistry.info/Elements/u/noteOnDistributionStatement.en</seealso>
    let ``noteOnDistributionStatement.en`` =
        Prefixed_Name(rdau, "noteOnDistributionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnEditionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnEditionStatement.en">http://rdaregistry.info/Elements/u/noteOnEditionStatement.en</seealso>
    let ``noteOnEditionStatement.en`` =
        Prefixed_Name(rdau, "noteOnEditionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnExtentOfResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnExtentOfResource.en">http://rdaregistry.info/Elements/u/noteOnExtentOfResource.en</seealso>
    let ``noteOnExtentOfResource.en`` =
        Prefixed_Name(rdau, "noteOnExtentOfResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnFrequency.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnFrequency.en">http://rdaregistry.info/Elements/u/noteOnFrequency.en</seealso>
    let ``noteOnFrequency.en`` =
        Prefixed_Name(rdau, "noteOnFrequency.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en">http://rdaregistry.info/Elements/u/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en</seealso>
    let ``noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en`` =
        Prefixed_Name(rdau, "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnManufactureStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnManufactureStatement.en">http://rdaregistry.info/Elements/u/noteOnManufactureStatement.en</seealso>
    let ``noteOnManufactureStatement.en`` =
        Prefixed_Name(rdau, "noteOnManufactureStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnNumberingOfSerials.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnNumberingOfSerials.en">http://rdaregistry.info/Elements/u/noteOnNumberingOfSerials.en</seealso>
    let ``noteOnNumberingOfSerials.en`` =
        Prefixed_Name(rdau, "noteOnNumberingOfSerials.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnProductionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnProductionStatement.en">http://rdaregistry.info/Elements/u/noteOnProductionStatement.en</seealso>
    let ``noteOnProductionStatement.en`` =
        Prefixed_Name(rdau, "noteOnProductionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnPublicationStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnPublicationStatement.en">http://rdaregistry.info/Elements/u/noteOnPublicationStatement.en</seealso>
    let ``noteOnPublicationStatement.en`` =
        Prefixed_Name(rdau, "noteOnPublicationStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnResource.en">http://rdaregistry.info/Elements/u/noteOnResource.en</seealso>
    let ``noteOnResource.en`` = Prefixed_Name(rdau, "noteOnResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnResourceSpecificCarrierCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnResourceSpecificCarrierCharacteristic.en">http://rdaregistry.info/Elements/u/noteOnResourceSpecificCarrierCharacteristic.en</seealso>
    let ``noteOnResourceSpecificCarrierCharacteristic.en`` =
        Prefixed_Name(rdau, "noteOnResourceSpecificCarrierCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnSeriesStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnSeriesStatement.en">http://rdaregistry.info/Elements/u/noteOnSeriesStatement.en</seealso>
    let ``noteOnSeriesStatement.en`` =
        Prefixed_Name(rdau, "noteOnSeriesStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnStatementOfResponsibility.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnStatementOfResponsibility.en">http://rdaregistry.info/Elements/u/noteOnStatementOfResponsibility.en</seealso>
    let ``noteOnStatementOfResponsibility.en`` =
        Prefixed_Name(rdau, "noteOnStatementOfResponsibility.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:noteOnTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/noteOnTitle.en">http://rdaregistry.info/Elements/u/noteOnTitle.en</seealso>
    let ``noteOnTitle.en`` = Prefixed_Name(rdau, "noteOnTitle.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:novelizationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/novelizationOf.en">http://rdaregistry.info/Elements/u/novelizationOf.en</seealso>
    let ``novelizationOf.en`` = Prefixed_Name(rdau, "novelizationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numberOfAConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numberOfAConferenceEtc.en">http://rdaregistry.info/Elements/u/numberOfAConferenceEtc.en</seealso>
    let ``numberOfAConferenceEtc.en`` =
        Prefixed_Name(rdau, "numberOfAConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numberingOfPart.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numberingOfPart.en">http://rdaregistry.info/Elements/u/numberingOfPart.en</seealso>
    let ``numberingOfPart.en`` =
        Prefixed_Name(rdau, "numberingOfPart.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numberingOfSerials.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numberingOfSerials.en">http://rdaregistry.info/Elements/u/numberingOfSerials.en</seealso>
    let ``numberingOfSerials.en`` =
        Prefixed_Name(rdau, "numberingOfSerials.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numberingWithinSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numberingWithinSeries.en">http://rdaregistry.info/Elements/u/numberingWithinSeries.en</seealso>
    let ``numberingWithinSeries.en`` =
        Prefixed_Name(rdau, "numberingWithinSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numberingWithinSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numberingWithinSubseries.en">http://rdaregistry.info/Elements/u/numberingWithinSubseries.en</seealso>
    let ``numberingWithinSubseries.en`` =
        Prefixed_Name(rdau, "numberingWithinSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/u/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdau, "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:numericDesignationOfAMusicalResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/numericDesignationOfAMusicalResource.en">http://rdaregistry.info/Elements/u/numericDesignationOfAMusicalResource.en</seealso>
    let ``numericDesignationOfAMusicalResource.en`` =
        Prefixed_Name(rdau, "numericDesignationOfAMusicalResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:officiatedAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/officiatedAgent.en">http://rdaregistry.info/Elements/u/officiatedAgent.en</seealso>
    let ``officiatedAgent.en`` =
        Prefixed_Name(rdau, "officiatedAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:onDiscWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/onDiscWith.en">http://rdaregistry.info/Elements/u/onDiscWith.en</seealso>
    let ``onDiscWith.en`` = Prefixed_Name(rdau, "onDiscWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:onScreenParticipant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/onScreenParticipant.en">http://rdaregistry.info/Elements/u/onScreenParticipant.en</seealso>
    let ``onScreenParticipant.en`` =
        Prefixed_Name(rdau, "onScreenParticipant.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:onScreenParticipantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/onScreenParticipantOf.en">http://rdaregistry.info/Elements/u/onScreenParticipantOf.en</seealso>
    let ``onScreenParticipantOf.en`` =
        Prefixed_Name(rdau, "onScreenParticipantOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:onScreenPresenter.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/onScreenPresenter.en">http://rdaregistry.info/Elements/u/onScreenPresenter.en</seealso>
    let ``onScreenPresenter.en`` =
        Prefixed_Name(rdau, "onScreenPresenter.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:onScreenPresenterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/onScreenPresenterOf.en">http://rdaregistry.info/Elements/u/onScreenPresenterOf.en</seealso>
    let ``onScreenPresenterOf.en`` =
        Prefixed_Name(rdau, "onScreenPresenterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:operaAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/operaAdaptationOf.en">http://rdaregistry.info/Elements/u/operaAdaptationOf.en</seealso>
    let ``operaAdaptationOf.en`` =
        Prefixed_Name(rdau, "operaAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:oratorioAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/oratorioAdaptationOf.en">http://rdaregistry.info/Elements/u/oratorioAdaptationOf.en</seealso>
    let ``oratorioAdaptationOf.en`` =
        Prefixed_Name(rdau, "oratorioAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:organizer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/organizer.en">http://rdaregistry.info/Elements/u/organizer.en</seealso>
    let ``organizer.en`` = Prefixed_Name(rdau, "organizer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:organizerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/organizerOf.en">http://rdaregistry.info/Elements/u/organizerOf.en</seealso>
    let ``organizerOf.en`` = Prefixed_Name(rdau, "organizerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherAgentAssociatedWithAResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherAgentAssociatedWithAResource.en">http://rdaregistry.info/Elements/u/otherAgentAssociatedWithAResource.en</seealso>
    let ``otherAgentAssociatedWithAResource.en`` =
        Prefixed_Name(rdau, "otherAgentAssociatedWithAResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherAgentAssociatedWithAResourceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherAgentAssociatedWithAResourceOf.en">http://rdaregistry.info/Elements/u/otherAgentAssociatedWithAResourceOf.en</seealso>
    let ``otherAgentAssociatedWithAResourceOf.en`` =
        Prefixed_Name(rdau, "otherAgentAssociatedWithAResourceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherDesignationAssociatedWithTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherDesignationAssociatedWithTheAgent.en">http://rdaregistry.info/Elements/u/otherDesignationAssociatedWithTheAgent.en</seealso>
    let ``otherDesignationAssociatedWithTheAgent.en`` =
        Prefixed_Name(rdau, "otherDesignationAssociatedWithTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherDetailsOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherDetailsOfCartographicContent.en">http://rdaregistry.info/Elements/u/otherDetailsOfCartographicContent.en</seealso>
    let ``otherDetailsOfCartographicContent.en`` =
        Prefixed_Name(rdau, "otherDetailsOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherDistinguishingCharacteristicOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherDistinguishingCharacteristicOfTheResource.en">http://rdaregistry.info/Elements/u/otherDistinguishingCharacteristicOfTheResource.en</seealso>
    let ``otherDistinguishingCharacteristicOfTheResource.en`` =
        Prefixed_Name(rdau, "otherDistinguishingCharacteristicOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherTitleInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherTitleInformation.en">http://rdaregistry.info/Elements/u/otherTitleInformation.en</seealso>
    let ``otherTitleInformation.en`` =
        Prefixed_Name(rdau, "otherTitleInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherTitleInformationOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherTitleInformationOfSeries.en">http://rdaregistry.info/Elements/u/otherTitleInformationOfSeries.en</seealso>
    let ``otherTitleInformationOfSeries.en`` =
        Prefixed_Name(rdau, "otherTitleInformationOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:otherTitleInformationOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/otherTitleInformationOfSubseries.en">http://rdaregistry.info/Elements/u/otherTitleInformationOfSubseries.en</seealso>
    let ``otherTitleInformationOfSubseries.en`` =
        Prefixed_Name(rdau, "otherTitleInformationOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:owner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/owner.en">http://rdaregistry.info/Elements/u/owner.en</seealso>
    let ``owner.en`` = Prefixed_Name(rdau, "owner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:ownerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/ownerOf.en">http://rdaregistry.info/Elements/u/ownerOf.en</seealso>
    let ``ownerOf.en`` = Prefixed_Name(rdau, "ownerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:panelist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/panelist.en">http://rdaregistry.info/Elements/u/panelist.en</seealso>
    let ``panelist.en`` = Prefixed_Name(rdau, "panelist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:panelistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/panelistOf.en">http://rdaregistry.info/Elements/u/panelistOf.en</seealso>
    let ``panelistOf.en`` = Prefixed_Name(rdau, "panelistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:papermaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/papermaker.en">http://rdaregistry.info/Elements/u/papermaker.en</seealso>
    let ``papermaker.en`` = Prefixed_Name(rdau, "papermaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:papermakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/papermakerOf.en">http://rdaregistry.info/Elements/u/papermakerOf.en</seealso>
    let ``papermakerOf.en`` = Prefixed_Name(rdau, "papermakerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelDesignationOfANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelDesignationOfANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/u/parallelDesignationOfANamedRevisionOfAnEdition.en</seealso>
    let ``parallelDesignationOfANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdau, "parallelDesignationOfANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelDesignationOfEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelDesignationOfEdition.en">http://rdaregistry.info/Elements/u/parallelDesignationOfEdition.en</seealso>
    let ``parallelDesignationOfEdition.en`` =
        Prefixed_Name(rdau, "parallelDesignationOfEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelDistributorsName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelDistributorsName.en">http://rdaregistry.info/Elements/u/parallelDistributorsName.en</seealso>
    let ``parallelDistributorsName.en`` =
        Prefixed_Name(rdau, "parallelDistributorsName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelManufacturersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelManufacturersName.en">http://rdaregistry.info/Elements/u/parallelManufacturersName.en</seealso>
    let ``parallelManufacturersName.en`` =
        Prefixed_Name(rdau, "parallelManufacturersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelOtherTitleInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelOtherTitleInformation.en">http://rdaregistry.info/Elements/u/parallelOtherTitleInformation.en</seealso>
    let ``parallelOtherTitleInformation.en`` =
        Prefixed_Name(rdau, "parallelOtherTitleInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelOtherTitleInformationOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelOtherTitleInformationOfSeries.en">http://rdaregistry.info/Elements/u/parallelOtherTitleInformationOfSeries.en</seealso>
    let ``parallelOtherTitleInformationOfSeries.en`` =
        Prefixed_Name(rdau, "parallelOtherTitleInformationOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelOtherTitleInformationOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelOtherTitleInformationOfSubseries.en">http://rdaregistry.info/Elements/u/parallelOtherTitleInformationOfSubseries.en</seealso>
    let ``parallelOtherTitleInformationOfSubseries.en`` =
        Prefixed_Name(rdau, "parallelOtherTitleInformationOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelPlaceOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelPlaceOfDistribution.en">http://rdaregistry.info/Elements/u/parallelPlaceOfDistribution.en</seealso>
    let ``parallelPlaceOfDistribution.en`` =
        Prefixed_Name(rdau, "parallelPlaceOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelPlaceOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelPlaceOfManufacture.en">http://rdaregistry.info/Elements/u/parallelPlaceOfManufacture.en</seealso>
    let ``parallelPlaceOfManufacture.en`` =
        Prefixed_Name(rdau, "parallelPlaceOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelPlaceOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelPlaceOfProduction.en">http://rdaregistry.info/Elements/u/parallelPlaceOfProduction.en</seealso>
    let ``parallelPlaceOfProduction.en`` =
        Prefixed_Name(rdau, "parallelPlaceOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelPlaceOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelPlaceOfPublication.en">http://rdaregistry.info/Elements/u/parallelPlaceOfPublication.en</seealso>
    let ``parallelPlaceOfPublication.en`` =
        Prefixed_Name(rdau, "parallelPlaceOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelProducersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelProducersName.en">http://rdaregistry.info/Elements/u/parallelProducersName.en</seealso>
    let ``parallelProducersName.en`` =
        Prefixed_Name(rdau, "parallelProducersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelPublishersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelPublishersName.en">http://rdaregistry.info/Elements/u/parallelPublishersName.en</seealso>
    let ``parallelPublishersName.en`` =
        Prefixed_Name(rdau, "parallelPublishersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdau, "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelStatementOfResponsibilityRelatingToSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToSeries.en">http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToSeries.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToSeries.en`` =
        Prefixed_Name(rdau, "parallelStatementOfResponsibilityRelatingToSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelStatementOfResponsibilityRelatingToSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToSubseries.en">http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToSubseries.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToSubseries.en`` =
        Prefixed_Name(rdau, "parallelStatementOfResponsibilityRelatingToSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelStatementOfResponsibilityRelatingToTheEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToTheEdition.en">http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToTheEdition.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToTheEdition.en`` =
        Prefixed_Name(rdau, "parallelStatementOfResponsibilityRelatingToTheEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelStatementOfResponsibilityRelatingToTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToTitleProper.en">http://rdaregistry.info/Elements/u/parallelStatementOfResponsibilityRelatingToTitleProper.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToTitleProper.en`` =
        Prefixed_Name(rdau, "parallelStatementOfResponsibilityRelatingToTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelTitleProper.en">http://rdaregistry.info/Elements/u/parallelTitleProper.en</seealso>
    let ``parallelTitleProper.en`` =
        Prefixed_Name(rdau, "parallelTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelTitleProperOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelTitleProperOfSeries.en">http://rdaregistry.info/Elements/u/parallelTitleProperOfSeries.en</seealso>
    let ``parallelTitleProperOfSeries.en`` =
        Prefixed_Name(rdau, "parallelTitleProperOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:parallelTitleProperOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parallelTitleProperOfSubseries.en">http://rdaregistry.info/Elements/u/parallelTitleProperOfSubseries.en</seealso>
    let ``parallelTitleProperOfSubseries.en`` =
        Prefixed_Name(rdau, "parallelTitleProperOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:paraphraseOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/paraphraseOf.en">http://rdaregistry.info/Elements/u/paraphraseOf.en</seealso>
    let ``paraphraseOf.en`` = Prefixed_Name(rdau, "paraphraseOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:paraphrasedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/paraphrasedAs.en">http://rdaregistry.info/Elements/u/paraphrasedAs.en</seealso>
    let ``paraphrasedAs.en`` = Prefixed_Name(rdau, "paraphrasedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:parodiedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parodiedAs.en">http://rdaregistry.info/Elements/u/parodiedAs.en</seealso>
    let ``parodiedAs.en`` = Prefixed_Name(rdau, "parodiedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:parodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/parodyOf.en">http://rdaregistry.info/Elements/u/parodyOf.en</seealso>
    let ``parodyOf.en`` = Prefixed_Name(rdau, "parodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:participantInATreaty.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/participantInATreaty.en">http://rdaregistry.info/Elements/u/participantInATreaty.en</seealso>
    let ``participantInATreaty.en`` =
        Prefixed_Name(rdau, "participantInATreaty.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:participantInATreatyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/participantInATreatyOf.en">http://rdaregistry.info/Elements/u/participantInATreatyOf.en</seealso>
    let ``participantInATreatyOf.en`` =
        Prefixed_Name(rdau, "participantInATreatyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:performer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/performer.en">http://rdaregistry.info/Elements/u/performer.en</seealso>
    let ``performer.en`` = Prefixed_Name(rdau, "performer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:performerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/performerOf.en">http://rdaregistry.info/Elements/u/performerOf.en</seealso>
    let ``performerOf.en`` = Prefixed_Name(rdau, "performerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:periodOfActivityOfTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/periodOfActivityOfTheAgent.en">http://rdaregistry.info/Elements/u/periodOfActivityOfTheAgent.en</seealso>
    let ``periodOfActivityOfTheAgent.en`` =
        Prefixed_Name(rdau, "periodOfActivityOfTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:photographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/photographer.en">http://rdaregistry.info/Elements/u/photographer.en</seealso>
    let ``photographer.en`` = Prefixed_Name(rdau, "photographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:photographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/photographerOf.en">http://rdaregistry.info/Elements/u/photographerOf.en</seealso>
    let ``photographerOf.en`` = Prefixed_Name(rdau, "photographerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeAndDateOfCapture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeAndDateOfCapture.en">http://rdaregistry.info/Elements/u/placeAndDateOfCapture.en</seealso>
    let ``placeAndDateOfCapture.en`` =
        Prefixed_Name(rdau, "placeAndDateOfCapture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeAssociatedWithTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeAssociatedWithTheAgent.en">http://rdaregistry.info/Elements/u/placeAssociatedWithTheAgent.en</seealso>
    let ``placeAssociatedWithTheAgent.en`` =
        Prefixed_Name(rdau, "placeAssociatedWithTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfBirth.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfBirth.en">http://rdaregistry.info/Elements/u/placeOfBirth.en</seealso>
    let ``placeOfBirth.en`` = Prefixed_Name(rdau, "placeOfBirth.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:placeOfCapture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfCapture.en">http://rdaregistry.info/Elements/u/placeOfCapture.en</seealso>
    let ``placeOfCapture.en`` = Prefixed_Name(rdau, "placeOfCapture.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:placeOfDeath.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfDeath.en">http://rdaregistry.info/Elements/u/placeOfDeath.en</seealso>
    let ``placeOfDeath.en`` = Prefixed_Name(rdau, "placeOfDeath.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfDistribution.en">http://rdaregistry.info/Elements/u/placeOfDistribution.en</seealso>
    let ``placeOfDistribution.en`` =
        Prefixed_Name(rdau, "placeOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfManufacture.en">http://rdaregistry.info/Elements/u/placeOfManufacture.en</seealso>
    let ``placeOfManufacture.en`` =
        Prefixed_Name(rdau, "placeOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfOriginOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfOriginOfTheResource.en">http://rdaregistry.info/Elements/u/placeOfOriginOfTheResource.en</seealso>
    let ``placeOfOriginOfTheResource.en`` =
        Prefixed_Name(rdau, "placeOfOriginOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfProduction.en">http://rdaregistry.info/Elements/u/placeOfProduction.en</seealso>
    let ``placeOfProduction.en`` =
        Prefixed_Name(rdau, "placeOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfPublication.en">http://rdaregistry.info/Elements/u/placeOfPublication.en</seealso>
    let ``placeOfPublication.en`` =
        Prefixed_Name(rdau, "placeOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:placeOfResidenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/placeOfResidenceEtc.en">http://rdaregistry.info/Elements/u/placeOfResidenceEtc.en</seealso>
    let ``placeOfResidenceEtc.en`` =
        Prefixed_Name(rdau, "placeOfResidenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:plaintiff.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/plaintiff.en">http://rdaregistry.info/Elements/u/plaintiff.en</seealso>
    let ``plaintiff.en`` = Prefixed_Name(rdau, "plaintiff.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:plaintiffOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/plaintiffOf.en">http://rdaregistry.info/Elements/u/plaintiffOf.en</seealso>
    let ``plaintiffOf.en`` = Prefixed_Name(rdau, "plaintiffOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:plateNumberForMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/plateNumberForMusic.en">http://rdaregistry.info/Elements/u/plateNumberForMusic.en</seealso>
    let ``plateNumberForMusic.en`` =
        Prefixed_Name(rdau, "plateNumberForMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:platemaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/platemaker.en">http://rdaregistry.info/Elements/u/platemaker.en</seealso>
    let ``platemaker.en`` = Prefixed_Name(rdau, "platemaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:platemakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/platemakerOf.en">http://rdaregistry.info/Elements/u/platemakerOf.en</seealso>
    let ``platemakerOf.en`` = Prefixed_Name(rdau, "platemakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:playingSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/playingSpeed.en">http://rdaregistry.info/Elements/u/playingSpeed.en</seealso>
    let ``playingSpeed.en`` = Prefixed_Name(rdau, "playingSpeed.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:polarity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/polarity.en">http://rdaregistry.info/Elements/u/polarity.en</seealso>
    let ``polarity.en`` = Prefixed_Name(rdau, "polarity.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:praeses.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/praeses.en">http://rdaregistry.info/Elements/u/praeses.en</seealso>
    let ``praeses.en`` = Prefixed_Name(rdau, "praeses.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:praesesOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/praesesOf.en">http://rdaregistry.info/Elements/u/praesesOf.en</seealso>
    let ``praesesOf.en`` = Prefixed_Name(rdau, "praesesOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:precededBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/precededBy.en">http://rdaregistry.info/Elements/u/precededBy.en</seealso>
    let ``precededBy.en`` = Prefixed_Name(rdau, "precededBy.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:predecessor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/predecessor.en">http://rdaregistry.info/Elements/u/predecessor.en</seealso>
    let ``predecessor.en`` = Prefixed_Name(rdau, "predecessor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:predecessorOfSplit.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/predecessorOfSplit.en">http://rdaregistry.info/Elements/u/predecessorOfSplit.en</seealso>
    let ``predecessorOfSplit.en`` =
        Prefixed_Name(rdau, "predecessorOfSplit.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preferredCitation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preferredCitation.en">http://rdaregistry.info/Elements/u/preferredCitation.en</seealso>
    let ``preferredCitation.en`` =
        Prefixed_Name(rdau, "preferredCitation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preferredNameForTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preferredNameForTheAgent.en">http://rdaregistry.info/Elements/u/preferredNameForTheAgent.en</seealso>
    let ``preferredNameForTheAgent.en`` =
        Prefixed_Name(rdau, "preferredNameForTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preferredNameForThePlace.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preferredNameForThePlace.en">http://rdaregistry.info/Elements/u/preferredNameForThePlace.en</seealso>
    let ``preferredNameForThePlace.en`` =
        Prefixed_Name(rdau, "preferredNameForThePlace.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preferredTitleForTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preferredTitleForTheResource.en">http://rdaregistry.info/Elements/u/preferredTitleForTheResource.en</seealso>
    let ``preferredTitleForTheResource.en`` =
        Prefixed_Name(rdau, "preferredTitleForTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:prequel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/prequel.en">http://rdaregistry.info/Elements/u/prequel.en</seealso>
    let ``prequel.en`` = Prefixed_Name(rdau, "prequel.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:prequelTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/prequelTo.en">http://rdaregistry.info/Elements/u/prequelTo.en</seealso>
    let ``prequelTo.en`` = Prefixed_Name(rdau, "prequelTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:presentationFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/presentationFormat.en">http://rdaregistry.info/Elements/u/presentationFormat.en</seealso>
    let ``presentationFormat.en`` =
        Prefixed_Name(rdau, "presentationFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:presenter.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/presenter.en">http://rdaregistry.info/Elements/u/presenter.en</seealso>
    let ``presenter.en`` = Prefixed_Name(rdau, "presenter.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:presenterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/presenterOf.en">http://rdaregistry.info/Elements/u/presenterOf.en</seealso>
    let ``presenterOf.en`` = Prefixed_Name(rdau, "presenterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preservationFacsimile.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preservationFacsimile.en">http://rdaregistry.info/Elements/u/preservationFacsimile.en</seealso>
    let ``preservationFacsimile.en`` =
        Prefixed_Name(rdau, "preservationFacsimile.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:preservationFacsimileOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/preservationFacsimileOf.en">http://rdaregistry.info/Elements/u/preservationFacsimileOf.en</seealso>
    let ``preservationFacsimileOf.en`` =
        Prefixed_Name(rdau, "preservationFacsimileOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:printer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/printer.en">http://rdaregistry.info/Elements/u/printer.en</seealso>
    let ``printer.en`` = Prefixed_Name(rdau, "printer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:printerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/printerOf.en">http://rdaregistry.info/Elements/u/printerOf.en</seealso>
    let ``printerOf.en`` = Prefixed_Name(rdau, "printerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:printmaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/printmaker.en">http://rdaregistry.info/Elements/u/printmaker.en</seealso>
    let ``printmaker.en`` = Prefixed_Name(rdau, "printmaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:printmakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/printmakerOf.en">http://rdaregistry.info/Elements/u/printmakerOf.en</seealso>
    let ``printmakerOf.en`` = Prefixed_Name(rdau, "printmakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:producer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/producer.en">http://rdaregistry.info/Elements/u/producer.en</seealso>
    let ``producer.en`` = Prefixed_Name(rdau, "producer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:producerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/producerOf.en">http://rdaregistry.info/Elements/u/producerOf.en</seealso>
    let ``producerOf.en`` = Prefixed_Name(rdau, "producerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:producerOfAnUnpublishedResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/producerOfAnUnpublishedResource.en">http://rdaregistry.info/Elements/u/producerOfAnUnpublishedResource.en</seealso>
    let ``producerOfAnUnpublishedResource.en`` =
        Prefixed_Name(rdau, "producerOfAnUnpublishedResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:producerOfAnUnpublishedResourceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/producerOfAnUnpublishedResourceOf.en">http://rdaregistry.info/Elements/u/producerOfAnUnpublishedResourceOf.en</seealso>
    let ``producerOfAnUnpublishedResourceOf.en`` =
        Prefixed_Name(rdau, "producerOfAnUnpublishedResourceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:producersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/producersName.en">http://rdaregistry.info/Elements/u/producersName.en</seealso>
    let ``producersName.en`` = Prefixed_Name(rdau, "producersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productOfAMerger.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productOfAMerger.en">http://rdaregistry.info/Elements/u/productOfAMerger.en</seealso>
    let ``productOfAMerger.en`` =
        Prefixed_Name(rdau, "productOfAMerger.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productOfASplit.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productOfASplit.en">http://rdaregistry.info/Elements/u/productOfASplit.en</seealso>
    let ``productOfASplit.en`` =
        Prefixed_Name(rdau, "productOfASplit.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionCompany.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionCompany.en">http://rdaregistry.info/Elements/u/productionCompany.en</seealso>
    let ``productionCompany.en`` =
        Prefixed_Name(rdau, "productionCompany.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionCompanyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionCompanyOf.en">http://rdaregistry.info/Elements/u/productionCompanyOf.en</seealso>
    let ``productionCompanyOf.en`` =
        Prefixed_Name(rdau, "productionCompanyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionDesigner.en">http://rdaregistry.info/Elements/u/productionDesigner.en</seealso>
    let ``productionDesigner.en`` =
        Prefixed_Name(rdau, "productionDesigner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionDesignerOf.en">http://rdaregistry.info/Elements/u/productionDesignerOf.en</seealso>
    let ``productionDesignerOf.en`` =
        Prefixed_Name(rdau, "productionDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionMethod.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionMethod.en">http://rdaregistry.info/Elements/u/productionMethod.en</seealso>
    let ``productionMethod.en`` =
        Prefixed_Name(rdau, "productionMethod.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionMethodForManuscript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionMethodForManuscript.en">http://rdaregistry.info/Elements/u/productionMethodForManuscript.en</seealso>
    let ``productionMethodForManuscript.en`` =
        Prefixed_Name(rdau, "productionMethodForManuscript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionMethodForTactileResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionMethodForTactileResource.en">http://rdaregistry.info/Elements/u/productionMethodForTactileResource.en</seealso>
    let ``productionMethodForTactileResource.en`` =
        Prefixed_Name(rdau, "productionMethodForTactileResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:productionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/productionStatement.en">http://rdaregistry.info/Elements/u/productionStatement.en</seealso>
    let ``productionStatement.en`` =
        Prefixed_Name(rdau, "productionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:professionOrOccupation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/professionOrOccupation.en">http://rdaregistry.info/Elements/u/professionOrOccupation.en</seealso>
    let ``professionOrOccupation.en`` =
        Prefixed_Name(rdau, "professionOrOccupation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:programmer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/programmer.en">http://rdaregistry.info/Elements/u/programmer.en</seealso>
    let ``programmer.en`` = Prefixed_Name(rdau, "programmer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:programmerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/programmerOf.en">http://rdaregistry.info/Elements/u/programmerOf.en</seealso>
    let ``programmerOf.en`` = Prefixed_Name(rdau, "programmerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:projectionCharacteristicOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/projectionCharacteristicOfMotionPictureFilm.en">http://rdaregistry.info/Elements/u/projectionCharacteristicOfMotionPictureFilm.en</seealso>
    let ``projectionCharacteristicOfMotionPictureFilm.en`` =
        Prefixed_Name(rdau, "projectionCharacteristicOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:projectionOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/projectionOfCartographicContent.en">http://rdaregistry.info/Elements/u/projectionOfCartographicContent.en</seealso>
    let ``projectionOfCartographicContent.en`` =
        Prefixed_Name(rdau, "projectionOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:projectionSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/projectionSpeed.en">http://rdaregistry.info/Elements/u/projectionSpeed.en</seealso>
    let ``projectionSpeed.en`` =
        Prefixed_Name(rdau, "projectionSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:prominentMemberOfTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/prominentMemberOfTheFamily.en">http://rdaregistry.info/Elements/u/prominentMemberOfTheFamily.en</seealso>
    let ``prominentMemberOfTheFamily.en`` =
        Prefixed_Name(rdau, "prominentMemberOfTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:publicationStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/publicationStatement.en">http://rdaregistry.info/Elements/u/publicationStatement.en</seealso>
    let ``publicationStatement.en`` =
        Prefixed_Name(rdau, "publicationStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:publisher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/publisher.en">http://rdaregistry.info/Elements/u/publisher.en</seealso>
    let ``publisher.en`` = Prefixed_Name(rdau, "publisher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:publisherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/publisherOf.en">http://rdaregistry.info/Elements/u/publisherOf.en</seealso>
    let ``publisherOf.en`` = Prefixed_Name(rdau, "publisherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:publishersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/publishersName.en">http://rdaregistry.info/Elements/u/publishersName.en</seealso>
    let ``publishersName.en`` = Prefixed_Name(rdau, "publishersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:publishersNumberForMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/publishersNumberForMusic.en">http://rdaregistry.info/Elements/u/publishersNumberForMusic.en</seealso>
    let ``publishersNumberForMusic.en`` =
        Prefixed_Name(rdau, "publishersNumberForMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:puppeteer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/puppeteer.en">http://rdaregistry.info/Elements/u/puppeteer.en</seealso>
    let ``puppeteer.en`` = Prefixed_Name(rdau, "puppeteer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:puppeteerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/puppeteerOf.en">http://rdaregistry.info/Elements/u/puppeteerOf.en</seealso>
    let ``puppeteerOf.en`` = Prefixed_Name(rdau, "puppeteerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioAdaptationOf.en">http://rdaregistry.info/Elements/u/radioAdaptationOf.en</seealso>
    let ``radioAdaptationOf.en`` =
        Prefixed_Name(rdau, "radioAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioDirector.en">http://rdaregistry.info/Elements/u/radioDirector.en</seealso>
    let ``radioDirector.en`` = Prefixed_Name(rdau, "radioDirector.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioDirectorOf.en">http://rdaregistry.info/Elements/u/radioDirectorOf.en</seealso>
    let ``radioDirectorOf.en`` =
        Prefixed_Name(rdau, "radioDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioProducer.en">http://rdaregistry.info/Elements/u/radioProducer.en</seealso>
    let ``radioProducer.en`` = Prefixed_Name(rdau, "radioProducer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioProducerOf.en">http://rdaregistry.info/Elements/u/radioProducerOf.en</seealso>
    let ``radioProducerOf.en`` =
        Prefixed_Name(rdau, "radioProducerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioProgramMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioProgramMusic.en">http://rdaregistry.info/Elements/u/radioProgramMusic.en</seealso>
    let ``radioProgramMusic.en`` =
        Prefixed_Name(rdau, "radioProgramMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioScript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioScript.en">http://rdaregistry.info/Elements/u/radioScript.en</seealso>
    let ``radioScript.en`` = Prefixed_Name(rdau, "radioScript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:radioScriptBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/radioScriptBasedOn.en">http://rdaregistry.info/Elements/u/radioScriptBasedOn.en</seealso>
    let ``radioScriptBasedOn.en`` =
        Prefixed_Name(rdau, "radioScriptBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:rapporteur.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/rapporteur.en">http://rdaregistry.info/Elements/u/rapporteur.en</seealso>
    let ``rapporteur.en`` = Prefixed_Name(rdau, "rapporteur.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:rapporteurOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/rapporteurOf.en">http://rdaregistry.info/Elements/u/rapporteurOf.en</seealso>
    let ``rapporteurOf.en`` = Prefixed_Name(rdau, "rapporteurOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:realIdentity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/realIdentity.en">http://rdaregistry.info/Elements/u/realIdentity.en</seealso>
    let ``realIdentity.en`` = Prefixed_Name(rdau, "realIdentity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:recordingEngineer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/recordingEngineer.en">http://rdaregistry.info/Elements/u/recordingEngineer.en</seealso>
    let ``recordingEngineer.en`` =
        Prefixed_Name(rdau, "recordingEngineer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:recordingEngineerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/recordingEngineerOf.en">http://rdaregistry.info/Elements/u/recordingEngineerOf.en</seealso>
    let ``recordingEngineerOf.en`` =
        Prefixed_Name(rdau, "recordingEngineerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:recordingMedium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/recordingMedium.en">http://rdaregistry.info/Elements/u/recordingMedium.en</seealso>
    let ``recordingMedium.en`` =
        Prefixed_Name(rdau, "recordingMedium.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:recordist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/recordist.en">http://rdaregistry.info/Elements/u/recordist.en</seealso>
    let ``recordist.en`` = Prefixed_Name(rdau, "recordist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:recordistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/recordistOf.en">http://rdaregistry.info/Elements/u/recordistOf.en</seealso>
    let ``recordistOf.en`` = Prefixed_Name(rdau, "recordistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reductionRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reductionRatio.en">http://rdaregistry.info/Elements/u/reductionRatio.en</seealso>
    let ``reductionRatio.en`` = Prefixed_Name(rdau, "reductionRatio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:referentialResourceRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/referentialResourceRelationship.en">http://rdaregistry.info/Elements/u/referentialResourceRelationship.en</seealso>
    let ``referentialResourceRelationship.en`` =
        Prefixed_Name(rdau, "referentialResourceRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:regionalEncoding.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/regionalEncoding.en">http://rdaregistry.info/Elements/u/regionalEncoding.en</seealso>
    let ``regionalEncoding.en`` =
        Prefixed_Name(rdau, "regionalEncoding.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:relatedAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/relatedAgent.en">http://rdaregistry.info/Elements/u/relatedAgent.en</seealso>
    let ``relatedAgent.en`` = Prefixed_Name(rdau, "relatedAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:relatedResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/relatedResource.en">http://rdaregistry.info/Elements/u/relatedResource.en</seealso>
    let ``relatedResource.en`` =
        Prefixed_Name(rdau, "relatedResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:remadeAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/remadeAs.en">http://rdaregistry.info/Elements/u/remadeAs.en</seealso>
    let ``remadeAs.en`` = Prefixed_Name(rdau, "remadeAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:remakeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/remakeOf.en">http://rdaregistry.info/Elements/u/remakeOf.en</seealso>
    let ``remakeOf.en`` = Prefixed_Name(rdau, "remakeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:replacedBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/replacedBy.en">http://rdaregistry.info/Elements/u/replacedBy.en</seealso>
    let ``replacedBy.en`` = Prefixed_Name(rdau, "replacedBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:replacedInPartBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/replacedInPartBy.en">http://rdaregistry.info/Elements/u/replacedInPartBy.en</seealso>
    let ``replacedInPartBy.en`` =
        Prefixed_Name(rdau, "replacedInPartBy.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:replacementInPartOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/replacementInPartOf.en">http://rdaregistry.info/Elements/u/replacementInPartOf.en</seealso>
    let ``replacementInPartOf.en`` =
        Prefixed_Name(rdau, "replacementInPartOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:replacementOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/replacementOf.en">http://rdaregistry.info/Elements/u/replacementOf.en</seealso>
    let ``replacementOf.en`` = Prefixed_Name(rdau, "replacementOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reprintOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reprintOf.en">http://rdaregistry.info/Elements/u/reprintOf.en</seealso>
    let ``reprintOf.en`` = Prefixed_Name(rdau, "reprintOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reprintedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reprintedAs.en">http://rdaregistry.info/Elements/u/reprintedAs.en</seealso>
    let ``reprintedAs.en`` = Prefixed_Name(rdau, "reprintedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reproducedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reproducedAs.en">http://rdaregistry.info/Elements/u/reproducedAs.en</seealso>
    let ``reproducedAs.en`` = Prefixed_Name(rdau, "reproducedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reproductionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reproductionOf.en">http://rdaregistry.info/Elements/u/reproductionOf.en</seealso>
    let ``reproductionOf.en`` = Prefixed_Name(rdau, "reproductionOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:researchOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/researchOf.en">http://rdaregistry.info/Elements/u/researchOf.en</seealso>
    let ``researchOf.en`` = Prefixed_Name(rdau, "researchOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:researcher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/researcher.en">http://rdaregistry.info/Elements/u/researcher.en</seealso>
    let ``researcher.en`` = Prefixed_Name(rdau, "researcher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:resolution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/resolution.en">http://rdaregistry.info/Elements/u/resolution.en</seealso>
    let ``resolution.en`` = Prefixed_Name(rdau, "resolution.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:respondent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/respondent.en">http://rdaregistry.info/Elements/u/respondent.en</seealso>
    let ``respondent.en`` = Prefixed_Name(rdau, "respondent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:respondentOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/respondentOf.en">http://rdaregistry.info/Elements/u/respondentOf.en</seealso>
    let ``respondentOf.en`` = Prefixed_Name(rdau, "respondentOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:restorationist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/restorationist.en">http://rdaregistry.info/Elements/u/restorationist.en</seealso>
    let ``restorationist.en`` = Prefixed_Name(rdau, "restorationist.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:restorationistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/restorationistOf.en">http://rdaregistry.info/Elements/u/restorationistOf.en</seealso>
    let ``restorationistOf.en`` =
        Prefixed_Name(rdau, "restorationistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:restrictionsOnAccess.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/restrictionsOnAccess.en">http://rdaregistry.info/Elements/u/restrictionsOnAccess.en</seealso>
    let ``restrictionsOnAccess.en`` =
        Prefixed_Name(rdau, "restrictionsOnAccess.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:restrictionsOnUse.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/restrictionsOnUse.en">http://rdaregistry.info/Elements/u/restrictionsOnUse.en</seealso>
    let ``restrictionsOnUse.en`` =
        Prefixed_Name(rdau, "restrictionsOnUse.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:reviewOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reviewOf.en">http://rdaregistry.info/Elements/u/reviewOf.en</seealso>
    let ``reviewOf.en`` = Prefixed_Name(rdau, "reviewOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:reviewedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/reviewedIn.en">http://rdaregistry.info/Elements/u/reviewedIn.en</seealso>
    let ``reviewedIn.en`` = Prefixed_Name(rdau, "reviewedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:revisedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/revisedAs.en">http://rdaregistry.info/Elements/u/revisedAs.en</seealso>
    let ``revisedAs.en`` = Prefixed_Name(rdau, "revisedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:revisionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/revisionOf.en">http://rdaregistry.info/Elements/u/revisionOf.en</seealso>
    let ``revisionOf.en`` = Prefixed_Name(rdau, "revisionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:rightAscensionAndDeclination.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/rightAscensionAndDeclination.en">http://rdaregistry.info/Elements/u/rightAscensionAndDeclination.en</seealso>
    let ``rightAscensionAndDeclination.en`` =
        Prefixed_Name(rdau, "rightAscensionAndDeclination.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:scale.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/scale.en">http://rdaregistry.info/Elements/u/scale.en</seealso>
    let ``scale.en`` = Prefixed_Name(rdau, "scale.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:scaleOfStillImageOrThreeDimensionalForm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/scaleOfStillImageOrThreeDimensionalForm.en">http://rdaregistry.info/Elements/u/scaleOfStillImageOrThreeDimensionalForm.en</seealso>
    let ``scaleOfStillImageOrThreeDimensionalForm.en`` =
        Prefixed_Name(rdau, "scaleOfStillImageOrThreeDimensionalForm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:scopeOfUsage.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/scopeOfUsage.en">http://rdaregistry.info/Elements/u/scopeOfUsage.en</seealso>
    let ``scopeOfUsage.en`` = Prefixed_Name(rdau, "scopeOfUsage.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:screenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplay.en">http://rdaregistry.info/Elements/u/screenplay.en</seealso>
    let ``screenplay.en`` = Prefixed_Name(rdau, "screenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenplayBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplayBasedOn.en">http://rdaregistry.info/Elements/u/screenplayBasedOn.en</seealso>
    let ``screenplayBasedOn.en`` =
        Prefixed_Name(rdau, "screenplayBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenplayFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplayFor.en">http://rdaregistry.info/Elements/u/screenplayFor.en</seealso>
    let ``screenplayFor.en`` = Prefixed_Name(rdau, "screenplayFor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenplayForTheMotionPicture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplayForTheMotionPicture.en">http://rdaregistry.info/Elements/u/screenplayForTheMotionPicture.en</seealso>
    let ``screenplayForTheMotionPicture.en`` =
        Prefixed_Name(rdau, "screenplayForTheMotionPicture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenplayForTheTelevisionProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplayForTheTelevisionProgram.en">http://rdaregistry.info/Elements/u/screenplayForTheTelevisionProgram.en</seealso>
    let ``screenplayForTheTelevisionProgram.en`` =
        Prefixed_Name(rdau, "screenplayForTheTelevisionProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenplayForTheVideo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenplayForTheVideo.en">http://rdaregistry.info/Elements/u/screenplayForTheVideo.en</seealso>
    let ``screenplayForTheVideo.en`` =
        Prefixed_Name(rdau, "screenplayForTheVideo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:screenwriter.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenwriter.en">http://rdaregistry.info/Elements/u/screenwriter.en</seealso>
    let ``screenwriter.en`` = Prefixed_Name(rdau, "screenwriter.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:screenwriterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/screenwriterOf.en">http://rdaregistry.info/Elements/u/screenwriterOf.en</seealso>
    let ``screenwriterOf.en`` = Prefixed_Name(rdau, "screenwriterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:script.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/script.en">http://rdaregistry.info/Elements/u/script.en</seealso>
    let ``script.en`` = Prefixed_Name(rdau, "script.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:scriptForTheRadioProgram.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/scriptForTheRadioProgram.en">http://rdaregistry.info/Elements/u/scriptForTheRadioProgram.en</seealso>
    let ``scriptForTheRadioProgram.en`` =
        Prefixed_Name(rdau, "scriptForTheRadioProgram.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:sculptor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sculptor.en">http://rdaregistry.info/Elements/u/sculptor.en</seealso>
    let ``sculptor.en`` = Prefixed_Name(rdau, "sculptor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:sculptorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sculptorOf.en">http://rdaregistry.info/Elements/u/sculptorOf.en</seealso>
    let ``sculptorOf.en`` = Prefixed_Name(rdau, "sculptorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:seller.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/seller.en">http://rdaregistry.info/Elements/u/seller.en</seealso>
    let ``seller.en`` = Prefixed_Name(rdau, "seller.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:sellerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sellerOf.en">http://rdaregistry.info/Elements/u/sellerOf.en</seealso>
    let ``sellerOf.en`` = Prefixed_Name(rdau, "sellerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:separatedFrom.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/separatedFrom.en">http://rdaregistry.info/Elements/u/separatedFrom.en</seealso>
    let ``separatedFrom.en`` = Prefixed_Name(rdau, "separatedFrom.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:sequel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sequel.en">http://rdaregistry.info/Elements/u/sequel.en</seealso>
    let ``sequel.en`` = Prefixed_Name(rdau, "sequel.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:sequelTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sequelTo.en">http://rdaregistry.info/Elements/u/sequelTo.en</seealso>
    let ``sequelTo.en`` = Prefixed_Name(rdau, "sequelTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:sequentialResourceRelationshipWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sequentialResourceRelationshipWith.en">http://rdaregistry.info/Elements/u/sequentialResourceRelationshipWith.en</seealso>
    let ``sequentialResourceRelationshipWith.en`` =
        Prefixed_Name(rdau, "sequentialResourceRelationshipWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:seriesContainerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/seriesContainerOf.en">http://rdaregistry.info/Elements/u/seriesContainerOf.en</seealso>
    let ``seriesContainerOf.en`` =
        Prefixed_Name(rdau, "seriesContainerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:seriesStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/seriesStatement.en">http://rdaregistry.info/Elements/u/seriesStatement.en</seealso>
    let ``seriesStatement.en`` =
        Prefixed_Name(rdau, "seriesStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:setToMusicAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/setToMusicAs.en">http://rdaregistry.info/Elements/u/setToMusicAs.en</seealso>
    let ``setToMusicAs.en`` = Prefixed_Name(rdau, "setToMusicAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:singer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/singer.en">http://rdaregistry.info/Elements/u/singer.en</seealso>
    let ``singer.en`` = Prefixed_Name(rdau, "singer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:singerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/singerOf.en">http://rdaregistry.info/Elements/u/singerOf.en</seealso>
    let ``singerOf.en`` = Prefixed_Name(rdau, "singerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:softwareDeveloper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/softwareDeveloper.en">http://rdaregistry.info/Elements/u/softwareDeveloper.en</seealso>
    let ``softwareDeveloper.en`` =
        Prefixed_Name(rdau, "softwareDeveloper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:softwareDeveloperOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/softwareDeveloperOf.en">http://rdaregistry.info/Elements/u/softwareDeveloperOf.en</seealso>
    let ``softwareDeveloperOf.en`` =
        Prefixed_Name(rdau, "softwareDeveloperOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:soundCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/soundCharacteristic.en">http://rdaregistry.info/Elements/u/soundCharacteristic.en</seealso>
    let ``soundCharacteristic.en`` =
        Prefixed_Name(rdau, "soundCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:soundContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/soundContent.en">http://rdaregistry.info/Elements/u/soundContent.en</seealso>
    let ``soundContent.en`` = Prefixed_Name(rdau, "soundContent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:soundDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/soundDesigner.en">http://rdaregistry.info/Elements/u/soundDesigner.en</seealso>
    let ``soundDesigner.en`` = Prefixed_Name(rdau, "soundDesigner.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:soundDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/soundDesignerOf.en">http://rdaregistry.info/Elements/u/soundDesignerOf.en</seealso>
    let ``soundDesignerOf.en`` =
        Prefixed_Name(rdau, "soundDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:speaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/speaker.en">http://rdaregistry.info/Elements/u/speaker.en</seealso>
    let ``speaker.en`` = Prefixed_Name(rdau, "speaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:speakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/speakerOf.en">http://rdaregistry.info/Elements/u/speakerOf.en</seealso>
    let ``speakerOf.en`` = Prefixed_Name(rdau, "speakerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:specialEffectsProvider.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/specialEffectsProvider.en">http://rdaregistry.info/Elements/u/specialEffectsProvider.en</seealso>
    let ``specialEffectsProvider.en`` =
        Prefixed_Name(rdau, "specialEffectsProvider.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:specialEffectsProviderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/specialEffectsProviderOf.en">http://rdaregistry.info/Elements/u/specialEffectsProviderOf.en</seealso>
    let ``specialEffectsProviderOf.en`` =
        Prefixed_Name(rdau, "specialEffectsProviderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:specialIssue.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/specialIssue.en">http://rdaregistry.info/Elements/u/specialIssue.en</seealso>
    let ``specialIssue.en`` = Prefixed_Name(rdau, "specialIssue.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:specialIssueOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/specialIssueOf.en">http://rdaregistry.info/Elements/u/specialIssueOf.en</seealso>
    let ``specialIssueOf.en`` = Prefixed_Name(rdau, "specialIssueOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:specialPlaybackCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/specialPlaybackCharacteristic.en">http://rdaregistry.info/Elements/u/specialPlaybackCharacteristic.en</seealso>
    let ``specialPlaybackCharacteristic.en`` =
        Prefixed_Name(rdau, "specialPlaybackCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:splitInto.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/splitInto.en">http://rdaregistry.info/Elements/u/splitInto.en</seealso>
    let ``splitInto.en`` = Prefixed_Name(rdau, "splitInto.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:sponsor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sponsor.en">http://rdaregistry.info/Elements/u/sponsor.en</seealso>
    let ``sponsor.en`` = Prefixed_Name(rdau, "sponsor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:sponsoredEntity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sponsoredEntity.en">http://rdaregistry.info/Elements/u/sponsoredEntity.en</seealso>
    let ``sponsoredEntity.en`` =
        Prefixed_Name(rdau, "sponsoredEntity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:sponsoringBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sponsoringBody.en">http://rdaregistry.info/Elements/u/sponsoringBody.en</seealso>
    let ``sponsoringBody.en`` = Prefixed_Name(rdau, "sponsoringBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:sponsoringBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/sponsoringBodyOf.en">http://rdaregistry.info/Elements/u/sponsoringBodyOf.en</seealso>
    let ``sponsoringBodyOf.en`` =
        Prefixed_Name(rdau, "sponsoringBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:stageDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/stageDirector.en">http://rdaregistry.info/Elements/u/stageDirector.en</seealso>
    let ``stageDirector.en`` = Prefixed_Name(rdau, "stageDirector.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:stageDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/stageDirectorOf.en">http://rdaregistry.info/Elements/u/stageDirectorOf.en</seealso>
    let ``stageDirectorOf.en`` =
        Prefixed_Name(rdau, "stageDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibility.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibility.en">http://rdaregistry.info/Elements/u/statementOfResponsibility.en</seealso>
    let ``statementOfResponsibility.en`` =
        Prefixed_Name(rdau, "statementOfResponsibility.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</seealso>
    let ``statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdau, "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibilityRelatingToSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToSeries.en">http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToSeries.en</seealso>
    let ``statementOfResponsibilityRelatingToSeries.en`` =
        Prefixed_Name(rdau, "statementOfResponsibilityRelatingToSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibilityRelatingToSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToSubseries.en">http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToSubseries.en</seealso>
    let ``statementOfResponsibilityRelatingToSubseries.en`` =
        Prefixed_Name(rdau, "statementOfResponsibilityRelatingToSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibilityRelatingToTheEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToTheEdition.en">http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToTheEdition.en</seealso>
    let ``statementOfResponsibilityRelatingToTheEdition.en`` =
        Prefixed_Name(rdau, "statementOfResponsibilityRelatingToTheEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:statementOfResponsibilityRelatingToTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToTitleProper.en">http://rdaregistry.info/Elements/u/statementOfResponsibilityRelatingToTitleProper.en</seealso>
    let ``statementOfResponsibilityRelatingToTitleProper.en`` =
        Prefixed_Name(rdau, "statementOfResponsibilityRelatingToTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:storyteller.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/storyteller.en">http://rdaregistry.info/Elements/u/storyteller.en</seealso>
    let ``storyteller.en`` = Prefixed_Name(rdau, "storyteller.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:storytellerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/storytellerOf.en">http://rdaregistry.info/Elements/u/storytellerOf.en</seealso>
    let ``storytellerOf.en`` = Prefixed_Name(rdau, "storytellerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:stringsOfCoordinatePairs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/stringsOfCoordinatePairs.en">http://rdaregistry.info/Elements/u/stringsOfCoordinatePairs.en</seealso>
    let ``stringsOfCoordinatePairs.en`` =
        Prefixed_Name(rdau, "stringsOfCoordinatePairs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:subject.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/subject.en">http://rdaregistry.info/Elements/u/subject.en</seealso>
    let ``subject.en`` = Prefixed_Name(rdau, "subject.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:subjectOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/subjectOf.en">http://rdaregistry.info/Elements/u/subjectOf.en</seealso>
    let ``subjectOf.en`` = Prefixed_Name(rdau, "subjectOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:subseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/subseries.en">http://rdaregistry.info/Elements/u/subseries.en</seealso>
    let ``subseries.en`` = Prefixed_Name(rdau, "subseries.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:subseriesOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/subseriesOf.en">http://rdaregistry.info/Elements/u/subseriesOf.en</seealso>
    let ``subseriesOf.en`` = Prefixed_Name(rdau, "subseriesOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:succeededBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/succeededBy.en">http://rdaregistry.info/Elements/u/succeededBy.en</seealso>
    let ``succeededBy.en`` = Prefixed_Name(rdau, "succeededBy.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:successor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/successor.en">http://rdaregistry.info/Elements/u/successor.en</seealso>
    let ``successor.en`` = Prefixed_Name(rdau, "successor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:summarizationOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/summarizationOfTheContent.en">http://rdaregistry.info/Elements/u/summarizationOfTheContent.en</seealso>
    let ``summarizationOfTheContent.en`` =
        Prefixed_Name(rdau, "summarizationOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:summarizedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/summarizedAs.en">http://rdaregistry.info/Elements/u/summarizedAs.en</seealso>
    let ``summarizedAs.en`` = Prefixed_Name(rdau, "summarizedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:summaryOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/summaryOf.en">http://rdaregistry.info/Elements/u/summaryOf.en</seealso>
    let ``summaryOf.en`` = Prefixed_Name(rdau, "summaryOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:supplement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/supplement.en">http://rdaregistry.info/Elements/u/supplement.en</seealso>
    let ``supplement.en`` = Prefixed_Name(rdau, "supplement.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:supplementTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/supplementTo.en">http://rdaregistry.info/Elements/u/supplementTo.en</seealso>
    let ``supplementTo.en`` = Prefixed_Name(rdau, "supplementTo.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:supplementaryContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/supplementaryContent.en">http://rdaregistry.info/Elements/u/supplementaryContent.en</seealso>
    let ``supplementaryContent.en`` =
        Prefixed_Name(rdau, "supplementaryContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:surveyor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/surveyor.en">http://rdaregistry.info/Elements/u/surveyor.en</seealso>
    let ``surveyor.en`` = Prefixed_Name(rdau, "surveyor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:surveyorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/surveyorOf.en">http://rdaregistry.info/Elements/u/surveyorOf.en</seealso>
    let ``surveyorOf.en`` = Prefixed_Name(rdau, "surveyorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:systemOfOrganization.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/systemOfOrganization.en">http://rdaregistry.info/Elements/u/systemOfOrganization.en</seealso>
    let ``systemOfOrganization.en`` =
        Prefixed_Name(rdau, "systemOfOrganization.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:tapeConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/tapeConfiguration.en">http://rdaregistry.info/Elements/u/tapeConfiguration.en</seealso>
    let ``tapeConfiguration.en`` =
        Prefixed_Name(rdau, "tapeConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:teacher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/teacher.en">http://rdaregistry.info/Elements/u/teacher.en</seealso>
    let ``teacher.en`` = Prefixed_Name(rdau, "teacher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:teacherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/teacherOf.en">http://rdaregistry.info/Elements/u/teacherOf.en</seealso>
    let ``teacherOf.en`` = Prefixed_Name(rdau, "teacherOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionAdaptationOf.en">http://rdaregistry.info/Elements/u/televisionAdaptationOf.en</seealso>
    let ``televisionAdaptationOf.en`` =
        Prefixed_Name(rdau, "televisionAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionDirector.en">http://rdaregistry.info/Elements/u/televisionDirector.en</seealso>
    let ``televisionDirector.en`` =
        Prefixed_Name(rdau, "televisionDirector.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionDirectorOf.en">http://rdaregistry.info/Elements/u/televisionDirectorOf.en</seealso>
    let ``televisionDirectorOf.en`` =
        Prefixed_Name(rdau, "televisionDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionProducer.en">http://rdaregistry.info/Elements/u/televisionProducer.en</seealso>
    let ``televisionProducer.en`` =
        Prefixed_Name(rdau, "televisionProducer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionProducerOf.en">http://rdaregistry.info/Elements/u/televisionProducerOf.en</seealso>
    let ``televisionProducerOf.en`` =
        Prefixed_Name(rdau, "televisionProducerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionProgramMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionProgramMusic.en">http://rdaregistry.info/Elements/u/televisionProgramMusic.en</seealso>
    let ``televisionProgramMusic.en`` =
        Prefixed_Name(rdau, "televisionProgramMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionScreenplay.en">http://rdaregistry.info/Elements/u/televisionScreenplay.en</seealso>
    let ``televisionScreenplay.en`` =
        Prefixed_Name(rdau, "televisionScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:televisionScreenplayBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/televisionScreenplayBasedOn.en">http://rdaregistry.info/Elements/u/televisionScreenplayBasedOn.en</seealso>
    let ``televisionScreenplayBasedOn.en`` =
        Prefixed_Name(rdau, "televisionScreenplayBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:termsOfAvailability.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/termsOfAvailability.en">http://rdaregistry.info/Elements/u/termsOfAvailability.en</seealso>
    let ``termsOfAvailability.en`` =
        Prefixed_Name(rdau, "termsOfAvailability.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:title.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/title.en">http://rdaregistry.info/Elements/u/title.en</seealso>
    let ``title.en`` = Prefixed_Name(rdau, "title.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:titleOfTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/titleOfTheAgent.en">http://rdaregistry.info/Elements/u/titleOfTheAgent.en</seealso>
    let ``titleOfTheAgent.en`` =
        Prefixed_Name(rdau, "titleOfTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:titleOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/titleOfTheResource.en">http://rdaregistry.info/Elements/u/titleOfTheResource.en</seealso>
    let ``titleOfTheResource.en`` =
        Prefixed_Name(rdau, "titleOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:titleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/titleProper.en">http://rdaregistry.info/Elements/u/titleProper.en</seealso>
    let ``titleProper.en`` = Prefixed_Name(rdau, "titleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:titleProperOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/titleProperOfSeries.en">http://rdaregistry.info/Elements/u/titleProperOfSeries.en</seealso>
    let ``titleProperOfSeries.en`` =
        Prefixed_Name(rdau, "titleProperOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:titleProperOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/titleProperOfSubseries.en">http://rdaregistry.info/Elements/u/titleProperOfSubseries.en</seealso>
    let ``titleProperOfSubseries.en`` =
        Prefixed_Name(rdau, "titleProperOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:trackConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/trackConfiguration.en">http://rdaregistry.info/Elements/u/trackConfiguration.en</seealso>
    let ``trackConfiguration.en`` =
        Prefixed_Name(rdau, "trackConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:transcriber.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/transcriber.en">http://rdaregistry.info/Elements/u/transcriber.en</seealso>
    let ``transcriber.en`` = Prefixed_Name(rdau, "transcriber.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:transcriberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/transcriberOf.en">http://rdaregistry.info/Elements/u/transcriberOf.en</seealso>
    let ``transcriberOf.en`` = Prefixed_Name(rdau, "transcriberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:translatedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/translatedAs.en">http://rdaregistry.info/Elements/u/translatedAs.en</seealso>
    let ``translatedAs.en`` = Prefixed_Name(rdau, "translatedAs.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:translationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/translationOf.en">http://rdaregistry.info/Elements/u/translationOf.en</seealso>
    let ``translationOf.en`` = Prefixed_Name(rdau, "translationOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:translator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/translator.en">http://rdaregistry.info/Elements/u/translator.en</seealso>
    let ``translator.en`` = Prefixed_Name(rdau, "translator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:translatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/translatorOf.en">http://rdaregistry.info/Elements/u/translatorOf.en</seealso>
    let ``translatorOf.en`` = Prefixed_Name(rdau, "translatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:typeOfAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/typeOfAgent.en">http://rdaregistry.info/Elements/u/typeOfAgent.en</seealso>
    let ``typeOfAgent.en`` = Prefixed_Name(rdau, "typeOfAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:typeOfRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/typeOfRecording.en">http://rdaregistry.info/Elements/u/typeOfRecording.en</seealso>
    let ``typeOfRecording.en`` =
        Prefixed_Name(rdau, "typeOfRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:undifferentiatedNameIndicator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/undifferentiatedNameIndicator.en">http://rdaregistry.info/Elements/u/undifferentiatedNameIndicator.en</seealso>
    let ``undifferentiatedNameIndicator.en`` =
        Prefixed_Name(rdau, "undifferentiatedNameIndicator.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:uniformResourceLocator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/uniformResourceLocator.en">http://rdaregistry.info/Elements/u/uniformResourceLocator.en</seealso>
    let ``uniformResourceLocator.en`` =
        Prefixed_Name(rdau, "uniformResourceLocator.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:variantNameForTheAgent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/variantNameForTheAgent.en">http://rdaregistry.info/Elements/u/variantNameForTheAgent.en</seealso>
    let ``variantNameForTheAgent.en`` =
        Prefixed_Name(rdau, "variantNameForTheAgent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:variantTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/variantTitle.en">http://rdaregistry.info/Elements/u/variantTitle.en</seealso>
    let ``variantTitle.en`` = Prefixed_Name(rdau, "variantTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:variationsBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/variationsBasedOn.en">http://rdaregistry.info/Elements/u/variationsBasedOn.en</seealso>
    let ``variationsBasedOn.en`` =
        Prefixed_Name(rdau, "variationsBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:verseAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/verseAdaptationOf.en">http://rdaregistry.info/Elements/u/verseAdaptationOf.en</seealso>
    let ``verseAdaptationOf.en`` =
        Prefixed_Name(rdau, "verseAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:verticalScaleOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/verticalScaleOfCartographicContent.en">http://rdaregistry.info/Elements/u/verticalScaleOfCartographicContent.en</seealso>
    let ``verticalScaleOfCartographicContent.en`` =
        Prefixed_Name(rdau, "verticalScaleOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoAdaptationOf.en">http://rdaregistry.info/Elements/u/videoAdaptationOf.en</seealso>
    let ``videoAdaptationOf.en`` =
        Prefixed_Name(rdau, "videoAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoCharacteristic.en">http://rdaregistry.info/Elements/u/videoCharacteristic.en</seealso>
    let ``videoCharacteristic.en`` =
        Prefixed_Name(rdau, "videoCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoFormat.en">http://rdaregistry.info/Elements/u/videoFormat.en</seealso>
    let ``videoFormat.en`` = Prefixed_Name(rdau, "videoFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoGameAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoGameAdaptationOf.en">http://rdaregistry.info/Elements/u/videoGameAdaptationOf.en</seealso>
    let ``videoGameAdaptationOf.en`` =
        Prefixed_Name(rdau, "videoGameAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoMusic.en">http://rdaregistry.info/Elements/u/videoMusic.en</seealso>
    let ``videoMusic.en`` = Prefixed_Name(rdau, "videoMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoScreenplay.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoScreenplay.en">http://rdaregistry.info/Elements/u/videoScreenplay.en</seealso>
    let ``videoScreenplay.en`` =
        Prefixed_Name(rdau, "videoScreenplay.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:videoScreenplayBasedOn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/videoScreenplayBasedOn.en">http://rdaregistry.info/Elements/u/videoScreenplayBasedOn.en</seealso>
    let ``videoScreenplayBasedOn.en`` =
        Prefixed_Name(rdau, "videoScreenplayBasedOn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:visualEffectsProvider.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/visualEffectsProvider.en">http://rdaregistry.info/Elements/u/visualEffectsProvider.en</seealso>
    let ``visualEffectsProvider.en`` =
        Prefixed_Name(rdau, "visualEffectsProvider.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:visualEffectsProviderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/visualEffectsProviderOf.en">http://rdaregistry.info/Elements/u/visualEffectsProviderOf.en</seealso>
    let ``visualEffectsProviderOf.en`` =
        Prefixed_Name(rdau, "visualEffectsProviderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:voiceActor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/voiceActor.en">http://rdaregistry.info/Elements/u/voiceActor.en</seealso>
    let ``voiceActor.en`` = Prefixed_Name(rdau, "voiceActor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdau:voiceActorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/voiceActorOf.en">http://rdaregistry.info/Elements/u/voiceActorOf.en</seealso>
    let ``voiceActorOf.en`` = Prefixed_Name(rdau, "voiceActorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:wholePartResourceRelationshipWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/wholePartResourceRelationshipWith.en">http://rdaregistry.info/Elements/u/wholePartResourceRelationshipWith.en</seealso>
    let ``wholePartResourceRelationshipWith.en`` =
        Prefixed_Name(rdau, "wholePartResourceRelationshipWith.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedCommentary.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedCommentary.en">http://rdaregistry.info/Elements/u/writerOfAddedCommentary.en</seealso>
    let ``writerOfAddedCommentary.en`` =
        Prefixed_Name(rdau, "writerOfAddedCommentary.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedCommentaryOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedCommentaryOf.en">http://rdaregistry.info/Elements/u/writerOfAddedCommentaryOf.en</seealso>
    let ``writerOfAddedCommentaryOf.en`` =
        Prefixed_Name(rdau, "writerOfAddedCommentaryOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedLyrics.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedLyrics.en">http://rdaregistry.info/Elements/u/writerOfAddedLyrics.en</seealso>
    let ``writerOfAddedLyrics.en`` =
        Prefixed_Name(rdau, "writerOfAddedLyrics.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedLyricsOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedLyricsOf.en">http://rdaregistry.info/Elements/u/writerOfAddedLyricsOf.en</seealso>
    let ``writerOfAddedLyricsOf.en`` =
        Prefixed_Name(rdau, "writerOfAddedLyricsOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedText.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedText.en">http://rdaregistry.info/Elements/u/writerOfAddedText.en</seealso>
    let ``writerOfAddedText.en`` =
        Prefixed_Name(rdau, "writerOfAddedText.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAddedTextOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAddedTextOf.en">http://rdaregistry.info/Elements/u/writerOfAddedTextOf.en</seealso>
    let ``writerOfAddedTextOf.en`` =
        Prefixed_Name(rdau, "writerOfAddedTextOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAfterword.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAfterword.en">http://rdaregistry.info/Elements/u/writerOfAfterword.en</seealso>
    let ``writerOfAfterword.en`` =
        Prefixed_Name(rdau, "writerOfAfterword.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfAfterwordOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfAfterwordOf.en">http://rdaregistry.info/Elements/u/writerOfAfterwordOf.en</seealso>
    let ``writerOfAfterwordOf.en`` =
        Prefixed_Name(rdau, "writerOfAfterwordOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfForeword.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfForeword.en">http://rdaregistry.info/Elements/u/writerOfForeword.en</seealso>
    let ``writerOfForeword.en`` =
        Prefixed_Name(rdau, "writerOfForeword.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfForewordOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfForewordOf.en">http://rdaregistry.info/Elements/u/writerOfForewordOf.en</seealso>
    let ``writerOfForewordOf.en`` =
        Prefixed_Name(rdau, "writerOfForewordOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfIntroduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfIntroduction.en">http://rdaregistry.info/Elements/u/writerOfIntroduction.en</seealso>
    let ``writerOfIntroduction.en`` =
        Prefixed_Name(rdau, "writerOfIntroduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfIntroductionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfIntroductionOf.en">http://rdaregistry.info/Elements/u/writerOfIntroductionOf.en</seealso>
    let ``writerOfIntroductionOf.en`` =
        Prefixed_Name(rdau, "writerOfIntroductionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfPostface.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfPostface.en">http://rdaregistry.info/Elements/u/writerOfPostface.en</seealso>
    let ``writerOfPostface.en`` =
        Prefixed_Name(rdau, "writerOfPostface.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfPostfaceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfPostfaceOf.en">http://rdaregistry.info/Elements/u/writerOfPostfaceOf.en</seealso>
    let ``writerOfPostfaceOf.en`` =
        Prefixed_Name(rdau, "writerOfPostfaceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfPreface.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfPreface.en">http://rdaregistry.info/Elements/u/writerOfPreface.en</seealso>
    let ``writerOfPreface.en`` =
        Prefixed_Name(rdau, "writerOfPreface.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfPrefaceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfPrefaceOf.en">http://rdaregistry.info/Elements/u/writerOfPrefaceOf.en</seealso>
    let ``writerOfPrefaceOf.en`` =
        Prefixed_Name(rdau, "writerOfPrefaceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfSupplementaryTextualContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfSupplementaryTextualContent.en">http://rdaregistry.info/Elements/u/writerOfSupplementaryTextualContent.en</seealso>
    let ``writerOfSupplementaryTextualContent.en`` =
        Prefixed_Name(rdau, "writerOfSupplementaryTextualContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:writerOfSupplementaryTextualContentOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/writerOfSupplementaryTextualContentOf.en">http://rdaregistry.info/Elements/u/writerOfSupplementaryTextualContentOf.en</seealso>
    let ``writerOfSupplementaryTextualContentOf.en`` =
        Prefixed_Name(rdau, "writerOfSupplementaryTextualContentOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdau:yearDegreeGranted.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/u/yearDegreeGranted.en">http://rdaregistry.info/Elements/u/yearDegreeGranted.en</seealso>
    let ``yearDegreeGranted.en`` =
        Prefixed_Name(rdau, "yearDegreeGranted.en") |> PrefixedName

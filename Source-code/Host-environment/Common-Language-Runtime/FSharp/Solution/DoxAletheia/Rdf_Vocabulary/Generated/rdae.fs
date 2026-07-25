namespace http.rdaregistry.info.Elements.e.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdae =
    let _namespace_iri = Namespace_Iri rdae |> NamespaceIRI
    /// <summary>
    ///   <para>rdae:P20002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20002">http://rdaregistry.info/Elements/e/P20002</seealso>
    let P20002 = Prefixed_Name(rdae, "P20002") |> PrefixedName

    /// <summary>
    ///   <para>rdae:otherDistinguishingCharacteristicOfTheExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/otherDistinguishingCharacteristicOfTheExpression">http://rdaregistry.info/Elements/e/otherDistinguishingCharacteristicOfTheExpression</seealso>
    let otherDistinguishingCharacteristicOfTheExpression =
        Prefixed_Name(rdae, "otherDistinguishingCharacteristicOfTheExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:award</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/award">http://rdaregistry.info/Elements/e/award</seealso>
    let award = Prefixed_Name(rdae, "award") |> PrefixedName

    /// <summary>
    ///   <para>rdae:languageOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/languageOfExpression">http://rdaregistry.info/Elements/e/languageOfExpression</seealso>
    let languageOfExpression =
        Prefixed_Name(rdae, "languageOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has artistic and/or technical credit</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20008">http://rdaregistry.info/Elements/e/P20008</seealso>
    let P20008 = Prefixed_Name(rdae, "P20008") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20153">http://rdaregistry.info/Elements/e/P20153</seealso>
    let P20153 = Prefixed_Name(rdae, "P20153") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on changes in content characteristics</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20010">http://rdaregistry.info/Elements/e/P20010</seealso>
    let P20010 = Prefixed_Name(rdae, "P20010") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has performer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20039">http://rdaregistry.info/Elements/e/P20039</seealso>
    let P20039 = Prefixed_Name(rdae, "P20039") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has actor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20012">http://rdaregistry.info/Elements/e/P20012</seealso>
    let P20012 = Prefixed_Name(rdae, "P20012") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has voice actor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20070">http://rdaregistry.info/Elements/e/P20070</seealso>
    let P20070 = Prefixed_Name(rdae, "P20070") |> PrefixedName
    /// <summary>
    ///   <para>rdae:dancer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dancer">http://rdaregistry.info/Elements/e/dancer</seealso>
    let dancer = Prefixed_Name(rdae, "dancer") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has teacher</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20015">http://rdaregistry.info/Elements/e/P20015</seealso>
    let P20015 = Prefixed_Name(rdae, "P20015") |> PrefixedName
    /// <summary>
    ///   <para>rdae:teacher</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/teacher">http://rdaregistry.info/Elements/e/teacher</seealso>
    let teacher = Prefixed_Name(rdae, "teacher") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has host</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20016">http://rdaregistry.info/Elements/e/P20016</seealso>
    let P20016 = Prefixed_Name(rdae, "P20016") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has puppeteer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20018">http://rdaregistry.info/Elements/e/P20018</seealso>
    let P20018 = Prefixed_Name(rdae, "P20018") |> PrefixedName
    /// <summary>
    ///   <para>rdae:panelist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/panelist">http://rdaregistry.info/Elements/e/panelist</seealso>
    let panelist = Prefixed_Name(rdae, "panelist") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has instrumentalist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20020">http://rdaregistry.info/Elements/e/P20020</seealso>
    let P20020 = Prefixed_Name(rdae, "P20020") |> PrefixedName
    /// <summary>
    ///   <para>rdae:instrumentalist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/instrumentalist">http://rdaregistry.info/Elements/e/instrumentalist</seealso>
    let instrumentalist = Prefixed_Name(rdae, "instrumentalist") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has narrator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20022">http://rdaregistry.info/Elements/e/P20022</seealso>
    let P20022 = Prefixed_Name(rdae, "P20022") |> PrefixedName
    /// <summary>
    ///   <para>rdae:narrator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/narrator">http://rdaregistry.info/Elements/e/narrator</seealso>
    let narrator = Prefixed_Name(rdae, "narrator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has storyteller</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20023">http://rdaregistry.info/Elements/e/P20023</seealso>
    let P20023 = Prefixed_Name(rdae, "P20023") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has composer (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20026">http://rdaregistry.info/Elements/e/P20026</seealso>
    let P20026 = Prefixed_Name(rdae, "P20026") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has contributor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20053">http://rdaregistry.info/Elements/e/P20053</seealso>
    let P20053 = Prefixed_Name(rdae, "P20053") |> PrefixedName
    /// <summary>
    ///   <para>rdae:composerExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/composerExpression">http://rdaregistry.info/Elements/e/composerExpression</seealso>
    let composerExpression = Prefixed_Name(rdae, "composerExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:performer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/performer">http://rdaregistry.info/Elements/e/performer</seealso>
    let performer = Prefixed_Name(rdae, "performer") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has court reporter</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20040">http://rdaregistry.info/Elements/e/P20040</seealso>
    let P20040 = Prefixed_Name(rdae, "P20040") |> PrefixedName
    /// <summary>
    ///   <para>rdae:recordist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/recordist">http://rdaregistry.info/Elements/e/recordist</seealso>
    let recordist = Prefixed_Name(rdae, "recordist") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production designer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20056">http://rdaregistry.info/Elements/e/P20056</seealso>
    let P20056 = Prefixed_Name(rdae, "P20056") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has editor of moving image work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20055">http://rdaregistry.info/Elements/e/P20055</seealso>
    let P20055 = Prefixed_Name(rdae, "P20055") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has minute taker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20058">http://rdaregistry.info/Elements/e/P20058</seealso>
    let P20058 = Prefixed_Name(rdae, "P20058") |> PrefixedName
    /// <summary>
    ///   <para>rdae:contributor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/contributor">http://rdaregistry.info/Elements/e/contributor</seealso>
    let contributor = Prefixed_Name(rdae, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has presenter</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20054">http://rdaregistry.info/Elements/e/P20054</seealso>
    let P20054 = Prefixed_Name(rdae, "P20054") |> PrefixedName

    /// <summary>
    ///   <para>rdae:editorOfMovingImageWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/editorOfMovingImageWork">http://rdaregistry.info/Elements/e/editorOfMovingImageWork</seealso>
    let editorOfMovingImageWork =
        Prefixed_Name(rdae, "editorOfMovingImageWork") |> PrefixedName

    /// <summary>
    ///   <para>rdae:performerNarratorAndOrPresenter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/performerNarratorAndOrPresenter">http://rdaregistry.info/Elements/e/performerNarratorAndOrPresenter</seealso>
    let performerNarratorAndOrPresenter =
        Prefixed_Name(rdae, "performerNarratorAndOrPresenter") |> PrefixedName

    /// <summary>
    ///   <para>rdae:minuteTaker</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/minuteTaker">http://rdaregistry.info/Elements/e/minuteTaker</seealso>
    let minuteTaker = Prefixed_Name(rdae, "minuteTaker") |> PrefixedName

    /// <summary>
    ///   <para>rdae:manifestationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/manifestationOfExpression">http://rdaregistry.info/Elements/e/manifestationOfExpression</seealso>
    let manifestationOfExpression =
        Prefixed_Name(rdae, "manifestationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as radio program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20060">http://rdaregistry.info/Elements/e/P20060</seealso>
    let P20060 = Prefixed_Name(rdae, "P20060") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20127">http://rdaregistry.info/Elements/e/P20127</seealso>
    let P20127 = Prefixed_Name(rdae, "P20127") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsARadioProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsARadioProgramExpression">http://rdaregistry.info/Elements/e/adaptedAsARadioProgramExpression</seealso>
    let adaptedAsARadioProgramExpression =
        Prefixed_Name(rdae, "adaptedAsARadioProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has form of tactile notation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20061">http://rdaregistry.info/Elements/e/P20061</seealso>
    let P20061 = Prefixed_Name(rdae, "P20061") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has form of notation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20062">http://rdaregistry.info/Elements/e/P20062</seealso>
    let P20062 = Prefixed_Name(rdae, "P20062") |> PrefixedName
    /// <summary>
    ///   <para>rdae:formOfNotation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/formOfNotation">http://rdaregistry.info/Elements/e/formOfNotation</seealso>
    let formOfNotation = Prefixed_Name(rdae, "formOfNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdae:formOfNotatedMovement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/formOfNotatedMovement">http://rdaregistry.info/Elements/e/formOfNotatedMovement</seealso>
    let formOfNotatedMovement =
        Prefixed_Name(rdae, "formOfNotatedMovement") |> PrefixedName

    /// <summary>
    ///   <para>rdae:formOfMusicalNotation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/formOfMusicalNotation">http://rdaregistry.info/Elements/e/formOfMusicalNotation</seealso>
    let formOfMusicalNotation =
        Prefixed_Name(rdae, "formOfMusicalNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdae:script</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/script">http://rdaregistry.info/Elements/e/script</seealso>
    let script = Prefixed_Name(rdae, "script") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as television program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20066">http://rdaregistry.info/Elements/e/P20066</seealso>
    let P20066 = Prefixed_Name(rdae, "P20066") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20128">http://rdaregistry.info/Elements/e/P20128</seealso>
    let P20128 = Prefixed_Name(rdae, "P20128") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsATelevisionProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsATelevisionProgramExpression">http://rdaregistry.info/Elements/e/adaptedAsATelevisionProgramExpression</seealso>
    let adaptedAsATelevisionProgramExpression =
        Prefixed_Name(rdae, "adaptedAsATelevisionProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as video (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20067">http://rdaregistry.info/Elements/e/P20067</seealso>
    let P20067 = Prefixed_Name(rdae, "P20067") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20134">http://rdaregistry.info/Elements/e/P20134</seealso>
    let P20134 = Prefixed_Name(rdae, "P20134") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsAVideoProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsAVideoProgramExpression">http://rdaregistry.info/Elements/e/adaptedAsAVideoProgramExpression</seealso>
    let adaptedAsAVideoProgramExpression =
        Prefixed_Name(rdae, "adaptedAsAVideoProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is complemented by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20100">http://rdaregistry.info/Elements/e/P20100</seealso>
    let P20100 = Prefixed_Name(rdae, "P20100") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20163">http://rdaregistry.info/Elements/e/P20163</seealso>
    let P20163 = Prefixed_Name(rdae, "P20163") |> PrefixedName

    /// <summary>
    ///   <para>rdae:librettoForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/librettoForExpression">http://rdaregistry.info/Elements/e/librettoForExpression</seealso>
    let librettoForExpression =
        Prefixed_Name(rdae, "librettoForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is incidental music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20085">http://rdaregistry.info/Elements/e/P20085</seealso>
    let P20085 = Prefixed_Name(rdae, "P20085") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20243</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20243">http://rdaregistry.info/Elements/e/P20243</seealso>
    let P20243 = Prefixed_Name(rdae, "P20243") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is incidental music for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20103">http://rdaregistry.info/Elements/e/P20103</seealso>
    let P20103 = Prefixed_Name(rdae, "P20103") |> PrefixedName

    /// <summary>
    ///   <para>rdae:incidentalMusicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/incidentalMusicExpression">http://rdaregistry.info/Elements/e/incidentalMusicExpression</seealso>
    let incidentalMusicExpression =
        Prefixed_Name(rdae, "incidentalMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is remade as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20086">http://rdaregistry.info/Elements/e/P20086</seealso>
    let P20086 = Prefixed_Name(rdae, "P20086") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appendix (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20118">http://rdaregistry.info/Elements/e/P20118</seealso>
    let P20118 = Prefixed_Name(rdae, "P20118") |> PrefixedName

    /// <summary>
    ///   <para>rdae:appendixToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/appendixToExpression">http://rdaregistry.info/Elements/e/appendixToExpression</seealso>
    let appendixToExpression =
        Prefixed_Name(rdae, "appendixToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstracted in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20090">http://rdaregistry.info/Elements/e/P20090</seealso>
    let P20090 = Prefixed_Name(rdae, "P20090") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstracts for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20193">http://rdaregistry.info/Elements/e/P20193</seealso>
    let P20193 = Prefixed_Name(rdae, "P20193") |> PrefixedName

    /// <summary>
    ///   <para>rdae:abstractedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abstractedInExpression">http://rdaregistry.info/Elements/e/abstractedInExpression</seealso>
    let abstractedInExpression =
        Prefixed_Name(rdae, "abstractedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is indexed in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20091">http://rdaregistry.info/Elements/e/P20091</seealso>
    let P20091 = Prefixed_Name(rdae, "P20091") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreography for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20183">http://rdaregistry.info/Elements/e/P20183</seealso>
    let P20183 = Prefixed_Name(rdae, "P20183") |> PrefixedName

    /// <summary>
    ///   <para>rdae:choreographyExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/choreographyExpression">http://rdaregistry.info/Elements/e/choreographyExpression</seealso>
    let choreographyExpression =
        Prefixed_Name(rdae, "choreographyExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is errata (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20093">http://rdaregistry.info/Elements/e/P20093</seealso>
    let P20093 = Prefixed_Name(rdae, "P20093") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is errata to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20146">http://rdaregistry.info/Elements/e/P20146</seealso>
    let P20146 = Prefixed_Name(rdae, "P20146") |> PrefixedName
    /// <summary>
    ///   <para>rdae:errataExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/errataExpression">http://rdaregistry.info/Elements/e/errataExpression</seealso>
    let errataExpression = Prefixed_Name(rdae, "errataExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illustrations (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20094">http://rdaregistry.info/Elements/e/P20094</seealso>
    let P20094 = Prefixed_Name(rdae, "P20094") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illustrations for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20148">http://rdaregistry.info/Elements/e/P20148</seealso>
    let P20148 = Prefixed_Name(rdae, "P20148") |> PrefixedName

    /// <summary>
    ///   <para>rdae:illustrationsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/illustrationsExpression">http://rdaregistry.info/Elements/e/illustrationsExpression</seealso>
    let illustrationsExpression =
        Prefixed_Name(rdae, "illustrationsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20096">http://rdaregistry.info/Elements/e/P20096</seealso>
    let P20096 = Prefixed_Name(rdae, "P20096") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture screenplay based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20130">http://rdaregistry.info/Elements/e/P20130</seealso>
    let P20130 = Prefixed_Name(rdae, "P20130") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsAMotionPictureScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsAMotionPictureScreenplayExpression">http://rdaregistry.info/Elements/e/adaptedAsAMotionPictureScreenplayExpression</seealso>
    let adaptedAsAMotionPictureScreenplayExpression =
        Prefixed_Name(rdae, "adaptedAsAMotionPictureScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as television screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20097">http://rdaregistry.info/Elements/e/P20097</seealso>
    let P20097 = Prefixed_Name(rdae, "P20097") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as video screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20098">http://rdaregistry.info/Elements/e/P20098</seealso>
    let P20098 = Prefixed_Name(rdae, "P20098") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20129">http://rdaregistry.info/Elements/e/P20129</seealso>
    let P20129 = Prefixed_Name(rdae, "P20129") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsAScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsAScreenplayExpression">http://rdaregistry.info/Elements/e/adaptedAsAScreenplayExpression</seealso>
    let adaptedAsAScreenplayExpression =
        Prefixed_Name(rdae, "adaptedAsAScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is imitation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20195">http://rdaregistry.info/Elements/e/P20195</seealso>
    let P20195 = Prefixed_Name(rdae, "P20195") |> PrefixedName

    /// <summary>
    ///   <para>rdae:imitatedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/imitatedAsExpression">http://rdaregistry.info/Elements/e/imitatedAsExpression</seealso>
    let imitatedAsExpression =
        Prefixed_Name(rdae, "imitatedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20115</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is expanded as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20115">http://rdaregistry.info/Elements/e/P20115</seealso>
    let P20115 = Prefixed_Name(rdae, "P20115") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is expanded version of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20184">http://rdaregistry.info/Elements/e/P20184</seealso>
    let P20184 = Prefixed_Name(rdae, "P20184") |> PrefixedName

    /// <summary>
    ///   <para>rdae:expandedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/expandedAsExpression">http://rdaregistry.info/Elements/e/expandedAsExpression</seealso>
    let expandedAsExpression =
        Prefixed_Name(rdae, "expandedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluated in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20116">http://rdaregistry.info/Elements/e/P20116</seealso>
    let P20116 = Prefixed_Name(rdae, "P20116") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical arrangement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20165">http://rdaregistry.info/Elements/e/P20165</seealso>
    let P20165 = Prefixed_Name(rdae, "P20165") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalArrangementOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalArrangementOf">http://rdaregistry.info/Elements/e/musicalArrangementOf</seealso>
    let musicalArrangementOf =
        Prefixed_Name(rdae, "musicalArrangementOf") |> PrefixedName

    /// <summary>
    ///   <para>rdae:freeTranslationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/freeTranslationOfExpression">http://rdaregistry.info/Elements/e/freeTranslationOfExpression</seealso>
    let freeTranslationOfExpression =
        Prefixed_Name(rdae, "freeTranslationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:translationOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/translationOf">http://rdaregistry.info/Elements/e/translationOf</seealso>
    let translationOf = Prefixed_Name(rdae, "translationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is parody of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20196">http://rdaregistry.info/Elements/e/P20196</seealso>
    let P20196 = Prefixed_Name(rdae, "P20196") |> PrefixedName

    /// <summary>
    ///   <para>rdae:parodiedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/parodiedAsExpression">http://rdaregistry.info/Elements/e/parodiedAsExpression</seealso>
    let parodiedAsExpression =
        Prefixed_Name(rdae, "parodiedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorbedByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorbedByExpression">http://rdaregistry.info/Elements/e/absorbedByExpression</seealso>
    let absorbedByExpression =
        Prefixed_Name(rdae, "absorbedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorbedInPartByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorbedInPartByExpression">http://rdaregistry.info/Elements/e/absorbedInPartByExpression</seealso>
    let absorbedInPartByExpression =
        Prefixed_Name(rdae, "absorbedInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:containsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/containsExpression">http://rdaregistry.info/Elements/e/containsExpression</seealso>
    let containsExpression = Prefixed_Name(rdae, "containsExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:errataToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/errataToExpression">http://rdaregistry.info/Elements/e/errataToExpression</seealso>
    let errataToExpression = Prefixed_Name(rdae, "errataToExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:guideToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/guideToExpression">http://rdaregistry.info/Elements/e/guideToExpression</seealso>
    let guideToExpression = Prefixed_Name(rdae, "guideToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:illustrationsForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/illustrationsForExpression">http://rdaregistry.info/Elements/e/illustrationsForExpression</seealso>
    let illustrationsForExpression =
        Prefixed_Name(rdae, "illustrationsForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continuation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20149">http://rdaregistry.info/Elements/e/P20149</seealso>
    let P20149 = Prefixed_Name(rdae, "P20149") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continued by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20191">http://rdaregistry.info/Elements/e/P20191</seealso>
    let P20191 = Prefixed_Name(rdae, "P20191") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuationOfExpression">http://rdaregistry.info/Elements/e/continuationOfExpression</seealso>
    let continuationOfExpression =
        Prefixed_Name(rdae, "continuationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuesExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuesExpression">http://rdaregistry.info/Elements/e/continuesExpression</seealso>
    let continuesExpression = Prefixed_Name(rdae, "continuesExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:evaluationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/evaluationOfExpression">http://rdaregistry.info/Elements/e/evaluationOfExpression</seealso>
    let evaluationOfExpression =
        Prefixed_Name(rdae, "evaluationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is supplement to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20151">http://rdaregistry.info/Elements/e/P20151</seealso>
    let P20151 = Prefixed_Name(rdae, "P20151") |> PrefixedName
    /// <summary>
    ///   <para>rdae:adaptedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsExpression">http://rdaregistry.info/Elements/e/adaptedAsExpression</seealso>
    let adaptedAsExpression = Prefixed_Name(rdae, "adaptedAsExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20201</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is merger of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20201">http://rdaregistry.info/Elements/e/P20201</seealso>
    let P20201 = Prefixed_Name(rdae, "P20201") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continuation in part of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20167">http://rdaregistry.info/Elements/e/P20167</seealso>
    let P20167 = Prefixed_Name(rdae, "P20167") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20235</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sequential expression relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20235">http://rdaregistry.info/Elements/e/P20235</seealso>
    let P20235 = Prefixed_Name(rdae, "P20235") |> PrefixedName

    /// <summary>
    ///   <para>rdae:precededByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/precededByExpression">http://rdaregistry.info/Elements/e/precededByExpression</seealso>
    let precededByExpression =
        Prefixed_Name(rdae, "precededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is finding aid for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20197">http://rdaregistry.info/Elements/e/P20197</seealso>
    let P20197 = Prefixed_Name(rdae, "P20197") |> PrefixedName

    /// <summary>
    ///   <para>rdae:findingAidExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/findingAidExpression">http://rdaregistry.info/Elements/e/findingAidExpression</seealso>
    let findingAidExpression =
        Prefixed_Name(rdae, "findingAidExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20188</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is index to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20188">http://rdaregistry.info/Elements/e/P20188</seealso>
    let P20188 = Prefixed_Name(rdae, "P20188") |> PrefixedName
    /// <summary>
    ///   <para>rdae:indexExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/indexExpression">http://rdaregistry.info/Elements/e/indexExpression</seealso>
    let indexExpression = Prefixed_Name(rdae, "indexExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20161">http://rdaregistry.info/Elements/e/P20161</seealso>
    let P20161 = Prefixed_Name(rdae, "P20161") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20158</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20158">http://rdaregistry.info/Elements/e/P20158</seealso>
    let P20158 = Prefixed_Name(rdae, "P20158") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20162">http://rdaregistry.info/Elements/e/P20162</seealso>
    let P20162 = Prefixed_Name(rdae, "P20162") |> PrefixedName

    /// <summary>
    ///   <para>rdae:radioScriptExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/radioScriptExpression">http://rdaregistry.info/Elements/e/radioScriptExpression</seealso>
    let radioScriptExpression =
        Prefixed_Name(rdae, "radioScriptExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:televisionScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/televisionScreenplayExpression">http://rdaregistry.info/Elements/e/televisionScreenplayExpression</seealso>
    let televisionScreenplayExpression =
        Prefixed_Name(rdae, "televisionScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:videoScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/videoScreenplayExpression">http://rdaregistry.info/Elements/e/videoScreenplayExpression</seealso>
    let videoScreenplayExpression =
        Prefixed_Name(rdae, "videoScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:librettoExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/librettoExpression">http://rdaregistry.info/Elements/e/librettoExpression</seealso>
    let librettoExpression = Prefixed_Name(rdae, "librettoExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is paraphrased as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20164">http://rdaregistry.info/Elements/e/P20164</seealso>
    let P20164 = Prefixed_Name(rdae, "P20164") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is paraphrase of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20186">http://rdaregistry.info/Elements/e/P20186</seealso>
    let P20186 = Prefixed_Name(rdae, "P20186") |> PrefixedName

    /// <summary>
    ///   <para>rdae:paraphrasedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/paraphrasedAsExpression">http://rdaregistry.info/Elements/e/paraphrasedAsExpression</seealso>
    let paraphrasedAsExpression =
        Prefixed_Name(rdae, "paraphrasedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalArrangement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalArrangement">http://rdaregistry.info/Elements/e/musicalArrangement</seealso>
    let musicalArrangement = Prefixed_Name(rdae, "musicalArrangement") |> PrefixedName
    /// <summary>
    ///   <para>rdae:colourOfMovingImage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/colourOfMovingImage">http://rdaregistry.info/Elements/e/colourOfMovingImage</seealso>
    let colourOfMovingImage = Prefixed_Name(rdae, "colourOfMovingImage") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20221</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has colour content of resource designed for persons with visual impairments</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20221">http://rdaregistry.info/Elements/e/P20221</seealso>
    let P20221 = Prefixed_Name(rdae, "P20221") |> PrefixedName

    /// <summary>
    ///   <para>rdae:colourContentOfResourceDesignedForPersonsWithVisualImpairments</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/colourContentOfResourceDesignedForPersonsWithVisualImpairments">http://rdaregistry.info/Elements/e/colourContentOfResourceDesignedForPersonsWithVisualImpairments</seealso>
    let colourContentOfResourceDesignedForPersonsWithVisualImpairments =
        Prefixed_Name(rdae, "colourContentOfResourceDesignedForPersonsWithVisualImpairments") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20222</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has colour of still image</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20222">http://rdaregistry.info/Elements/e/P20222</seealso>
    let P20222 = Prefixed_Name(rdae, "P20222") |> PrefixedName
    /// <summary>
    ///   <para>rdae:colourOfStillImage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/colourOfStillImage">http://rdaregistry.info/Elements/e/colourOfStillImage</seealso>
    let colourOfStillImage = Prefixed_Name(rdae, "colourOfStillImage") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20223</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has colour of three-dimensional form</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20223">http://rdaregistry.info/Elements/e/P20223</seealso>
    let P20223 = Prefixed_Name(rdae, "P20223") |> PrefixedName

    /// <summary>
    ///   <para>rdae:colourOfThreeDimensionalForm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/colourOfThreeDimensionalForm">http://rdaregistry.info/Elements/e/colourOfThreeDimensionalForm</seealso>
    let colourOfThreeDimensionalForm =
        Prefixed_Name(rdae, "colourOfThreeDimensionalForm") |> PrefixedName

    /// <summary>
    ///   <para>rdae:colourContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/colourContent">http://rdaregistry.info/Elements/e/colourContent</seealso>
    let colourContent = Prefixed_Name(rdae, "colourContent") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20225</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sound content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20225">http://rdaregistry.info/Elements/e/P20225</seealso>
    let P20225 = Prefixed_Name(rdae, "P20225") |> PrefixedName
    /// <summary>
    ///   <para>rdae:soundContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/soundContent">http://rdaregistry.info/Elements/e/soundContent</seealso>
    let soundContent = Prefixed_Name(rdae, "soundContent") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20226</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has horizontal scale of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20226">http://rdaregistry.info/Elements/e/P20226</seealso>
    let P20226 = Prefixed_Name(rdae, "P20226") |> PrefixedName

    /// <summary>
    ///   <para>rdae:horizontalScaleOfCartographicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/horizontalScaleOfCartographicContent">http://rdaregistry.info/Elements/e/horizontalScaleOfCartographicContent</seealso>
    let horizontalScaleOfCartographicContent =
        Prefixed_Name(rdae, "horizontalScaleOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:conductor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/conductor">http://rdaregistry.info/Elements/e/conductor</seealso>
    let conductor = Prefixed_Name(rdae, "conductor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:actor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/actor">http://rdaregistry.info/Elements/e/actor</seealso>
    let actor = Prefixed_Name(rdae, "actor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dancer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20014">http://rdaregistry.info/Elements/e/P20014</seealso>
    let P20014 = Prefixed_Name(rdae, "P20014") |> PrefixedName
    /// <summary>
    ///   <para>rdae:moderator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/moderator">http://rdaregistry.info/Elements/e/moderator</seealso>
    let moderator = Prefixed_Name(rdae, "moderator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:speaker</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/speaker">http://rdaregistry.info/Elements/e/speaker</seealso>
    let speaker = Prefixed_Name(rdae, "speaker") |> PrefixedName
    /// <summary>
    ///   <para>rdae:animator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/animator">http://rdaregistry.info/Elements/e/animator</seealso>
    let animator = Prefixed_Name(rdae, "animator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:arrangerOfMusic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/arrangerOfMusic">http://rdaregistry.info/Elements/e/arrangerOfMusic</seealso>
    let arrangerOfMusic = Prefixed_Name(rdae, "arrangerOfMusic") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has stage director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20031">http://rdaregistry.info/Elements/e/P20031</seealso>
    let P20031 = Prefixed_Name(rdae, "P20031") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has performer, narrator, and/or presenter</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20057">http://rdaregistry.info/Elements/e/P20057</seealso>
    let P20057 = Prefixed_Name(rdae, "P20057") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has manifestation of expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20059">http://rdaregistry.info/Elements/e/P20059</seealso>
    let P20059 = Prefixed_Name(rdae, "P20059") |> PrefixedName

    /// <summary>
    ///   <para>rdae:dramatizedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dramatizedAsExpression">http://rdaregistry.info/Elements/e/dramatizedAsExpression</seealso>
    let dramatizedAsExpression =
        Prefixed_Name(rdae, "dramatizedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is contained in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20074">http://rdaregistry.info/Elements/e/P20074</seealso>
    let P20074 = Prefixed_Name(rdae, "P20074") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is container of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20145">http://rdaregistry.info/Elements/e/P20145</seealso>
    let P20145 = Prefixed_Name(rdae, "P20145") |> PrefixedName

    /// <summary>
    ///   <para>rdae:containedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/containedInExpression">http://rdaregistry.info/Elements/e/containedInExpression</seealso>
    let containedInExpression =
        Prefixed_Name(rdae, "containedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:replacedInPartByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/replacedInPartByExpression">http://rdaregistry.info/Elements/e/replacedInPartByExpression</seealso>
    let replacedInPartByExpression =
        Prefixed_Name(rdae, "replacedInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replaced by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20076">http://rdaregistry.info/Elements/e/P20076</seealso>
    let P20076 = Prefixed_Name(rdae, "P20076") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is succeeded by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20169">http://rdaregistry.info/Elements/e/P20169</seealso>
    let P20169 = Prefixed_Name(rdae, "P20169") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20199</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replacement of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20199">http://rdaregistry.info/Elements/e/P20199</seealso>
    let P20199 = Prefixed_Name(rdae, "P20199") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dubbed version of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20078">http://rdaregistry.info/Elements/e/P20078</seealso>
    let P20078 = Prefixed_Name(rdae, "P20078") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is translation of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20141">http://rdaregistry.info/Elements/e/P20141</seealso>
    let P20141 = Prefixed_Name(rdae, "P20141") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dubbed version</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20079">http://rdaregistry.info/Elements/e/P20079</seealso>
    let P20079 = Prefixed_Name(rdae, "P20079") |> PrefixedName
    /// <summary>
    ///   <para>rdae:dubbedVersionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dubbedVersionOf">http://rdaregistry.info/Elements/e/dubbedVersionOf</seealso>
    let dubbedVersionOf = Prefixed_Name(rdae, "dubbedVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>rdae:dubbedVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dubbedVersion">http://rdaregistry.info/Elements/e/dubbedVersion</seealso>
    let dubbedVersion = Prefixed_Name(rdae, "dubbedVersion") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cadenza (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20080">http://rdaregistry.info/Elements/e/P20080</seealso>
    let P20080 = Prefixed_Name(rdae, "P20080") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20105</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is augmented by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20105">http://rdaregistry.info/Elements/e/P20105</seealso>
    let P20105 = Prefixed_Name(rdae, "P20105") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cadenza composed for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20083">http://rdaregistry.info/Elements/e/P20083</seealso>
    let P20083 = Prefixed_Name(rdae, "P20083") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalVariationsBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalVariationsBasedOnExpression">http://rdaregistry.info/Elements/e/musicalVariationsBasedOnExpression</seealso>
    let musicalVariationsBasedOnExpression =
        Prefixed_Name(rdae, "musicalVariationsBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20203</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is derivative (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20203">http://rdaregistry.info/Elements/e/P20203</seealso>
    let P20203 = Prefixed_Name(rdae, "P20203") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalVariationsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalVariationsExpression">http://rdaregistry.info/Elements/e/musicalVariationsExpression</seealso>
    let musicalVariationsExpression =
        Prefixed_Name(rdae, "musicalVariationsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video screenplay based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20132">http://rdaregistry.info/Elements/e/P20132</seealso>
    let P20132 = Prefixed_Name(rdae, "P20132") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsAVideoScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsAVideoScreenplayExpression">http://rdaregistry.info/Elements/e/adaptedAsAVideoScreenplayExpression</seealso>
    let adaptedAsAVideoScreenplayExpression =
        Prefixed_Name(rdae, "adaptedAsAVideoScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as radio script (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20099">http://rdaregistry.info/Elements/e/P20099</seealso>
    let P20099 = Prefixed_Name(rdae, "P20099") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20102">http://rdaregistry.info/Elements/e/P20102</seealso>
    let P20102 = Prefixed_Name(rdae, "P20102") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20157">http://rdaregistry.info/Elements/e/P20157</seealso>
    let P20157 = Prefixed_Name(rdae, "P20157") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio script (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20160">http://rdaregistry.info/Elements/e/P20160</seealso>
    let P20160 = Prefixed_Name(rdae, "P20160") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20176</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is script for radio program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20176">http://rdaregistry.info/Elements/e/P20176</seealso>
    let P20176 = Prefixed_Name(rdae, "P20176") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20232</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has accompanying expression relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20232">http://rdaregistry.info/Elements/e/P20232</seealso>
    let P20232 = Prefixed_Name(rdae, "P20232") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20152">http://rdaregistry.info/Elements/e/P20152</seealso>
    let P20152 = Prefixed_Name(rdae, "P20152") |> PrefixedName

    /// <summary>
    ///   <para>rdae:dramatizationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dramatizationOfExpression">http://rdaregistry.info/Elements/e/dramatizationOfExpression</seealso>
    let dramatizationOfExpression =
        Prefixed_Name(rdae, "dramatizationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supplementToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supplementToExpression">http://rdaregistry.info/Elements/e/supplementToExpression</seealso>
    let supplementToExpression =
        Prefixed_Name(rdae, "supplementToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptationOfExpression">http://rdaregistry.info/Elements/e/adaptationOfExpression</seealso>
    let adaptationOfExpression =
        Prefixed_Name(rdae, "adaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:critiqueOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/critiqueOfExpression">http://rdaregistry.info/Elements/e/critiqueOfExpression</seealso>
    let critiqueOfExpression =
        Prefixed_Name(rdae, "critiqueOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:choreographyForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/choreographyForExpression">http://rdaregistry.info/Elements/e/choreographyForExpression</seealso>
    let choreographyForExpression =
        Prefixed_Name(rdae, "choreographyForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:expandedVersionOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/expandedVersionOfExpression">http://rdaregistry.info/Elements/e/expandedVersionOfExpression</seealso>
    let expandedVersionOfExpression =
        Prefixed_Name(rdae, "expandedVersionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:illustrativeContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/illustrativeContent">http://rdaregistry.info/Elements/e/illustrativeContent</seealso>
    let illustrativeContent = Prefixed_Name(rdae, "illustrativeContent") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20208</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has accessibility content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20208">http://rdaregistry.info/Elements/e/P20208</seealso>
    let P20208 = Prefixed_Name(rdae, "P20208") |> PrefixedName

    /// <summary>
    ///   <para>rdae:accessibilityContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/accessibilityContent">http://rdaregistry.info/Elements/e/accessibilityContent</seealso>
    let accessibilityContent =
        Prefixed_Name(rdae, "accessibilityContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20209</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has format of notated music</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20209">http://rdaregistry.info/Elements/e/P20209</seealso>
    let P20209 = Prefixed_Name(rdae, "P20209") |> PrefixedName

    /// <summary>
    ///   <para>rdae:formatOfNotatedMusic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/formatOfNotatedMusic">http://rdaregistry.info/Elements/e/formatOfNotatedMusic</seealso>
    let formatOfNotatedMusic =
        Prefixed_Name(rdae, "formatOfNotatedMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20210</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other details of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20210">http://rdaregistry.info/Elements/e/P20210</seealso>
    let P20210 = Prefixed_Name(rdae, "P20210") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has animator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20028">http://rdaregistry.info/Elements/e/P20028</seealso>
    let P20028 = Prefixed_Name(rdae, "P20028") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has arranger of music</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20029">http://rdaregistry.info/Elements/e/P20029</seealso>
    let P20029 = Prefixed_Name(rdae, "P20029") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has costume designer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20036">http://rdaregistry.info/Elements/e/P20036</seealso>
    let P20036 = Prefixed_Name(rdae, "P20036") |> PrefixedName
    /// <summary>
    ///   <para>rdae:costumeDesigner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/costumeDesigner">http://rdaregistry.info/Elements/e/costumeDesigner</seealso>
    let costumeDesigner = Prefixed_Name(rdae, "costumeDesigner") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has art director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20038">http://rdaregistry.info/Elements/e/P20038</seealso>
    let P20038 = Prefixed_Name(rdae, "P20038") |> PrefixedName
    /// <summary>
    ///   <para>rdae:artDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/artDirector">http://rdaregistry.info/Elements/e/artDirector</seealso>
    let artDirector = Prefixed_Name(rdae, "artDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdae:formOfTactileNotation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/formOfTactileNotation">http://rdaregistry.info/Elements/e/formOfTactileNotation</seealso>
    let formOfTactileNotation =
        Prefixed_Name(rdae, "formOfTactileNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has script</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20065">http://rdaregistry.info/Elements/e/P20065</seealso>
    let P20065 = Prefixed_Name(rdae, "P20065") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has form of notated movement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20063">http://rdaregistry.info/Elements/e/P20063</seealso>
    let P20063 = Prefixed_Name(rdae, "P20063") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20198</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replacement in part of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20198">http://rdaregistry.info/Elements/e/P20198</seealso>
    let P20198 = Prefixed_Name(rdae, "P20198") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supersededInPartByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supersededInPartByExpression">http://rdaregistry.info/Elements/e/supersededInPartByExpression</seealso>
    let supersededInPartByExpression =
        Prefixed_Name(rdae, "supersededInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:replacedByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/replacedByExpression">http://rdaregistry.info/Elements/e/replacedByExpression</seealso>
    let replacedByExpression =
        Prefixed_Name(rdae, "replacedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supersededByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supersededByExpression">http://rdaregistry.info/Elements/e/supersededByExpression</seealso>
    let supersededByExpression =
        Prefixed_Name(rdae, "supersededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is verse adaptation (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20077">http://rdaregistry.info/Elements/e/P20077</seealso>
    let P20077 = Prefixed_Name(rdae, "P20077") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is verse adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20124">http://rdaregistry.info/Elements/e/P20124</seealso>
    let P20124 = Prefixed_Name(rdae, "P20124") |> PrefixedName

    /// <summary>
    ///   <para>rdae:verseAdaptationExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/verseAdaptationExpression">http://rdaregistry.info/Elements/e/verseAdaptationExpression</seealso>
    let verseAdaptationExpression =
        Prefixed_Name(rdae, "verseAdaptationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is translated as</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20171">http://rdaregistry.info/Elements/e/P20171</seealso>
    let P20171 = Prefixed_Name(rdae, "P20171") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical variations based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20081">http://rdaregistry.info/Elements/e/P20081</seealso>
    let P20081 = Prefixed_Name(rdae, "P20081") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is augmentation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20192">http://rdaregistry.info/Elements/e/P20192</seealso>
    let P20192 = Prefixed_Name(rdae, "P20192") |> PrefixedName

    /// <summary>
    ///   <para>rdae:cadenzaComposedForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/cadenzaComposedForExpression">http://rdaregistry.info/Elements/e/cadenzaComposedForExpression</seealso>
    let cadenzaComposedForExpression =
        Prefixed_Name(rdae, "cadenzaComposedForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20084">http://rdaregistry.info/Elements/e/P20084</seealso>
    let P20084 = Prefixed_Name(rdae, "P20084") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is remake of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20185">http://rdaregistry.info/Elements/e/P20185</seealso>
    let P20185 = Prefixed_Name(rdae, "P20185") |> PrefixedName
    /// <summary>
    ///   <para>rdae:remadeAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/remadeAsExpression">http://rdaregistry.info/Elements/e/remadeAsExpression</seealso>
    let remadeAsExpression = Prefixed_Name(rdae, "remadeAsExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical setting (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20087">http://rdaregistry.info/Elements/e/P20087</seealso>
    let P20087 = Prefixed_Name(rdae, "P20087") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalSettingExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalSettingExpression">http://rdaregistry.info/Elements/e/musicalSettingExpression</seealso>
    let musicalSettingExpression =
        Prefixed_Name(rdae, "musicalSettingExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is novelization (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20088">http://rdaregistry.info/Elements/e/P20088</seealso>
    let P20088 = Prefixed_Name(rdae, "P20088") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is novelization of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20126">http://rdaregistry.info/Elements/e/P20126</seealso>
    let P20126 = Prefixed_Name(rdae, "P20126") |> PrefixedName

    /// <summary>
    ///   <para>rdae:novelizationExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/novelizationExpression">http://rdaregistry.info/Elements/e/novelizationExpression</seealso>
    let novelizationExpression =
        Prefixed_Name(rdae, "novelizationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is indexing for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20194">http://rdaregistry.info/Elements/e/P20194</seealso>
    let P20194 = Prefixed_Name(rdae, "P20194") |> PrefixedName
    /// <summary>
    ///   <para>rdae:indexedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/indexedInExpression">http://rdaregistry.info/Elements/e/indexedInExpression</seealso>
    let indexedInExpression = Prefixed_Name(rdae, "indexedInExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreography (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20092">http://rdaregistry.info/Elements/e/P20092</seealso>
    let P20092 = Prefixed_Name(rdae, "P20092") |> PrefixedName

    /// <summary>
    ///   <para>rdae:incidentalMusicForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/incidentalMusicForExpression">http://rdaregistry.info/Elements/e/incidentalMusicForExpression</seealso>
    let incidentalMusicForExpression =
        Prefixed_Name(rdae, "incidentalMusicForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstract (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20104">http://rdaregistry.info/Elements/e/P20104</seealso>
    let P20104 = Prefixed_Name(rdae, "P20104") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstract of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20122">http://rdaregistry.info/Elements/e/P20122</seealso>
    let P20122 = Prefixed_Name(rdae, "P20122") |> PrefixedName

    /// <summary>
    ///   <para>rdae:motionPictureScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/motionPictureScreenplayBasedOnExpression">http://rdaregistry.info/Elements/e/motionPictureScreenplayBasedOnExpression</seealso>
    let motionPictureScreenplayBasedOnExpression =
        Prefixed_Name(rdae, "motionPictureScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:televisionScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/televisionScreenplayBasedOnExpression">http://rdaregistry.info/Elements/e/televisionScreenplayBasedOnExpression</seealso>
    let televisionScreenplayBasedOnExpression =
        Prefixed_Name(rdae, "televisionScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayExpression">http://rdaregistry.info/Elements/e/screenplayExpression</seealso>
    let screenplayExpression =
        Prefixed_Name(rdae, "screenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:motionPictureScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/motionPictureScreenplayExpression">http://rdaregistry.info/Elements/e/motionPictureScreenplayExpression</seealso>
    let motionPictureScreenplayExpression =
        Prefixed_Name(rdae, "motionPictureScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:remakeOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/remakeOfExpression">http://rdaregistry.info/Elements/e/remakeOfExpression</seealso>
    let remakeOfExpression = Prefixed_Name(rdae, "remakeOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:paraphraseOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/paraphraseOfExpression">http://rdaregistry.info/Elements/e/paraphraseOfExpression</seealso>
    let paraphraseOfExpression =
        Prefixed_Name(rdae, "paraphraseOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:commentaryOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/commentaryOnExpression">http://rdaregistry.info/Elements/e/commentaryOnExpression</seealso>
    let commentaryOnExpression =
        Prefixed_Name(rdae, "commentaryOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:indexToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/indexToExpression">http://rdaregistry.info/Elements/e/indexToExpression</seealso>
    let indexToExpression = Prefixed_Name(rdae, "indexToExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20189</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is revision of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20189">http://rdaregistry.info/Elements/e/P20189</seealso>
    let P20189 = Prefixed_Name(rdae, "P20189") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20211</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is revised as</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20211">http://rdaregistry.info/Elements/e/P20211</seealso>
    let P20211 = Prefixed_Name(rdae, "P20211") |> PrefixedName
    /// <summary>
    ///   <para>rdae:revisionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/revisionOf">http://rdaregistry.info/Elements/e/revisionOf</seealso>
    let revisionOf = Prefixed_Name(rdae, "revisionOf") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuedByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuedByExpression">http://rdaregistry.info/Elements/e/continuedByExpression</seealso>
    let continuedByExpression =
        Prefixed_Name(rdae, "continuedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:augmentationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/augmentationOfExpression">http://rdaregistry.info/Elements/e/augmentationOfExpression</seealso>
    let augmentationOfExpression =
        Prefixed_Name(rdae, "augmentationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:abstractsForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abstractsForExpression">http://rdaregistry.info/Elements/e/abstractsForExpression</seealso>
    let abstractsForExpression =
        Prefixed_Name(rdae, "abstractsForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:imitationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/imitationOfExpression">http://rdaregistry.info/Elements/e/imitationOfExpression</seealso>
    let imitationOfExpression =
        Prefixed_Name(rdae, "imitationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:parodyOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/parodyOfExpression">http://rdaregistry.info/Elements/e/parodyOfExpression</seealso>
    let parodyOfExpression = Prefixed_Name(rdae, "parodyOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:findingAidForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/findingAidForExpression">http://rdaregistry.info/Elements/e/findingAidForExpression</seealso>
    let findingAidForExpression =
        Prefixed_Name(rdae, "findingAidForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:replacementOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/replacementOfExpression">http://rdaregistry.info/Elements/e/replacementOfExpression</seealso>
    let replacementOfExpression =
        Prefixed_Name(rdae, "replacementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supersedesExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supersedesExpression">http://rdaregistry.info/Elements/e/supersedesExpression</seealso>
    let supersedesExpression =
        Prefixed_Name(rdae, "supersedesExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:splitIntoExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/splitIntoExpression">http://rdaregistry.info/Elements/e/splitIntoExpression</seealso>
    let splitIntoExpression = Prefixed_Name(rdae, "splitIntoExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20212</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is merged to form (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20212">http://rdaregistry.info/Elements/e/P20212</seealso>
    let P20212 = Prefixed_Name(rdae, "P20212") |> PrefixedName
    /// <summary>
    ///   <para>rdae:mergerOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/mergerOfExpression">http://rdaregistry.info/Elements/e/mergerOfExpression</seealso>
    let mergerOfExpression = Prefixed_Name(rdae, "mergerOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsMusicalTheatreExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsMusicalTheatreExpression">http://rdaregistry.info/Elements/e/adaptedAsMusicalTheatreExpression</seealso>
    let adaptedAsMusicalTheatreExpression =
        Prefixed_Name(rdae, "adaptedAsMusicalTheatreExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsOperaExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsOperaExpression">http://rdaregistry.info/Elements/e/adaptedAsOperaExpression</seealso>
    let adaptedAsOperaExpression =
        Prefixed_Name(rdae, "adaptedAsOperaExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicExpression">http://rdaregistry.info/Elements/e/musicExpression</seealso>
    let musicExpression = Prefixed_Name(rdae, "musicExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20245</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20245">http://rdaregistry.info/Elements/e/P20245</seealso>
    let P20245 = Prefixed_Name(rdae, "P20245") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20246</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for video (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20246">http://rdaregistry.info/Elements/e/P20246</seealso>
    let P20246 = Prefixed_Name(rdae, "P20246") |> PrefixedName

    /// <summary>
    ///   <para>rdae:videoMusicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/videoMusicExpression">http://rdaregistry.info/Elements/e/videoMusicExpression</seealso>
    let videoMusicExpression =
        Prefixed_Name(rdae, "videoMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicForVideoExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicForVideoExpression">http://rdaregistry.info/Elements/e/musicForVideoExpression</seealso>
    let musicForVideoExpression =
        Prefixed_Name(rdae, "musicForVideoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20247</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television program music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20247">http://rdaregistry.info/Elements/e/P20247</seealso>
    let P20247 = Prefixed_Name(rdae, "P20247") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicForTelevisionProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicForTelevisionProgramExpression">http://rdaregistry.info/Elements/e/musicForTelevisionProgramExpression</seealso>
    let musicForTelevisionProgramExpression =
        Prefixed_Name(rdae, "musicForTelevisionProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20249</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio program music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20249">http://rdaregistry.info/Elements/e/P20249</seealso>
    let P20249 = Prefixed_Name(rdae, "P20249") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20250</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for radio program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20250">http://rdaregistry.info/Elements/e/P20250</seealso>
    let P20250 = Prefixed_Name(rdae, "P20250") |> PrefixedName

    /// <summary>
    ///   <para>rdae:radioProgramMusicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/radioProgramMusicExpression">http://rdaregistry.info/Elements/e/radioProgramMusicExpression</seealso>
    let radioProgramMusicExpression =
        Prefixed_Name(rdae, "radioProgramMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicForRadioProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicForRadioProgramExpression">http://rdaregistry.info/Elements/e/musicForRadioProgramExpression</seealso>
    let musicForRadioProgramExpression =
        Prefixed_Name(rdae, "musicForRadioProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of added text</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20030">http://rdaregistry.info/Elements/e/P20030</seealso>
    let P20030 = Prefixed_Name(rdae, "P20030") |> PrefixedName
    /// <summary>
    ///   <para>rdae:transcriber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/transcriber">http://rdaregistry.info/Elements/e/transcriber</seealso>
    let transcriber = Prefixed_Name(rdae, "transcriber") |> PrefixedName
    /// <summary>
    ///   <para>rdae:presenter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/presenter">http://rdaregistry.info/Elements/e/presenter</seealso>
    let presenter = Prefixed_Name(rdae, "presenter") |> PrefixedName
    /// <summary>
    ///   <para>rdae:noteOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/noteOnExpression">http://rdaregistry.info/Elements/e/noteOnExpression</seealso>
    let noteOnExpression = Prefixed_Name(rdae, "noteOnExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dramatization of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20123">http://rdaregistry.info/Elements/e/P20123</seealso>
    let P20123 = Prefixed_Name(rdae, "P20123") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20236</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has whole-part expression relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20236">http://rdaregistry.info/Elements/e/P20236</seealso>
    let P20236 = Prefixed_Name(rdae, "P20236") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replaced in part by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20075">http://rdaregistry.info/Elements/e/P20075</seealso>
    let P20075 = Prefixed_Name(rdae, "P20075") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as motion picture screenplay (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20095">http://rdaregistry.info/Elements/e/P20095</seealso>
    let P20095 = Prefixed_Name(rdae, "P20095") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayForTheMotionPictureExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayForTheMotionPictureExpression">http://rdaregistry.info/Elements/e/screenplayForTheMotionPictureExpression</seealso>
    let screenplayForTheMotionPictureExpression =
        Prefixed_Name(rdae, "screenplayForTheMotionPictureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:indexingForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/indexingForExpression">http://rdaregistry.info/Elements/e/indexingForExpression</seealso>
    let indexingForExpression =
        Prefixed_Name(rdae, "indexingForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:writerOfPostface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfPostface">http://rdaregistry.info/Elements/e/writerOfPostface</seealso>
    let writerOfPostface = Prefixed_Name(rdae, "writerOfPostface") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20239</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical theatre adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20239">http://rdaregistry.info/Elements/e/P20239</seealso>
    let P20239 = Prefixed_Name(rdae, "P20239") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20240</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is opera adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20240">http://rdaregistry.info/Elements/e/P20240</seealso>
    let P20240 = Prefixed_Name(rdae, "P20240") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20242</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as opera (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20242">http://rdaregistry.info/Elements/e/P20242</seealso>
    let P20242 = Prefixed_Name(rdae, "P20242") |> PrefixedName

    /// <summary>
    ///   <para>rdae:operaAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/operaAdaptationOfExpression">http://rdaregistry.info/Elements/e/operaAdaptationOfExpression</seealso>
    let operaAdaptationOfExpression =
        Prefixed_Name(rdae, "operaAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has transcriber</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20034">http://rdaregistry.info/Elements/e/P20034</seealso>
    let P20034 = Prefixed_Name(rdae, "P20034") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has musical director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20035">http://rdaregistry.info/Elements/e/P20035</seealso>
    let P20035 = Prefixed_Name(rdae, "P20035") |> PrefixedName
    /// <summary>
    ///   <para>rdae:musicalDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalDirector">http://rdaregistry.info/Elements/e/musicalDirector</seealso>
    let musicalDirector = Prefixed_Name(rdae, "musicalDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has choreographer (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20043">http://rdaregistry.info/Elements/e/P20043</seealso>
    let P20043 = Prefixed_Name(rdae, "P20043") |> PrefixedName
    /// <summary>
    ///   <para>rdae:productionDesigner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/productionDesigner">http://rdaregistry.info/Elements/e/productionDesigner</seealso>
    let productionDesigner = Prefixed_Name(rdae, "productionDesigner") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical setting of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20159">http://rdaregistry.info/Elements/e/P20159</seealso>
    let P20159 = Prefixed_Name(rdae, "P20159") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appendix to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20089">http://rdaregistry.info/Elements/e/P20089</seealso>
    let P20089 = Prefixed_Name(rdae, "P20089") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsARadioScriptExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsARadioScriptExpression">http://rdaregistry.info/Elements/e/adaptedAsARadioScriptExpression</seealso>
    let adaptedAsARadioScriptExpression =
        Prefixed_Name(rdae, "adaptedAsARadioScriptExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:complementedByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/complementedByExpression">http://rdaregistry.info/Elements/e/complementedByExpression</seealso>
    let complementedByExpression =
        Prefixed_Name(rdae, "complementedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continued in part by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20101">http://rdaregistry.info/Elements/e/P20101</seealso>
    let P20101 = Prefixed_Name(rdae, "P20101") |> PrefixedName

    /// <summary>
    ///   <para>rdae:abstractOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abstractOfExpression">http://rdaregistry.info/Elements/e/abstractOfExpression</seealso>
    let abstractOfExpression =
        Prefixed_Name(rdae, "abstractOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:containerOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/containerOfExpression">http://rdaregistry.info/Elements/e/containerOfExpression</seealso>
    let containerOfExpression =
        Prefixed_Name(rdae, "containerOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayForTheTelevisionProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayForTheTelevisionProgramExpression">http://rdaregistry.info/Elements/e/screenplayForTheTelevisionProgramExpression</seealso>
    let screenplayForTheTelevisionProgramExpression =
        Prefixed_Name(rdae, "screenplayForTheTelevisionProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:replacementInPartOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/replacementInPartOfExpression">http://rdaregistry.info/Elements/e/replacementInPartOfExpression</seealso>
    let replacementInPartOfExpression =
        Prefixed_Name(rdae, "replacementInPartOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supersedesInPartExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supersedesInPartExpression">http://rdaregistry.info/Elements/e/supersedesInPartExpression</seealso>
    let supersedesInPartExpression =
        Prefixed_Name(rdae, "supersedesInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20241</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as musical theatre (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20241">http://rdaregistry.info/Elements/e/P20241</seealso>
    let P20241 = Prefixed_Name(rdae, "P20241") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalTheatreAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalTheatreAdaptationOfExpression">http://rdaregistry.info/Elements/e/musicalTheatreAdaptationOfExpression</seealso>
    let musicalTheatreAdaptationOfExpression =
        Prefixed_Name(rdae, "musicalTheatreAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicForMotionPictureExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicForMotionPictureExpression">http://rdaregistry.info/Elements/e/musicForMotionPictureExpression</seealso>
    let musicForMotionPictureExpression =
        Prefixed_Name(rdae, "musicForMotionPictureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has translator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20037">http://rdaregistry.info/Elements/e/P20037</seealso>
    let P20037 = Prefixed_Name(rdae, "P20037") |> PrefixedName
    /// <summary>
    ///   <para>rdae:translator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/translator">http://rdaregistry.info/Elements/e/translator</seealso>
    let translator = Prefixed_Name(rdae, "translator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has abridger</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20049">http://rdaregistry.info/Elements/e/P20049</seealso>
    let P20049 = Prefixed_Name(rdae, "P20049") |> PrefixedName
    /// <summary>
    ///   <para>rdae:abridger</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abridger">http://rdaregistry.info/Elements/e/abridger</seealso>
    let abridger = Prefixed_Name(rdae, "abridger") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has form of musical notation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20064">http://rdaregistry.info/Elements/e/P20064</seealso>
    let P20064 = Prefixed_Name(rdae, "P20064") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorptionOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorptionOfExpression">http://rdaregistry.info/Elements/e/absorptionOfExpression</seealso>
    let absorptionOfExpression =
        Prefixed_Name(rdae, "absorptionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorbedExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorbedExpression">http://rdaregistry.info/Elements/e/absorbedExpression</seealso>
    let absorbedExpression = Prefixed_Name(rdae, "absorbedExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorbed in part by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20144">http://rdaregistry.info/Elements/e/P20144</seealso>
    let P20144 = Prefixed_Name(rdae, "P20144") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorbedInPartExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorbedInPartExpression">http://rdaregistry.info/Elements/e/absorbedInPartExpression</seealso>
    let absorbedInPartExpression =
        Prefixed_Name(rdae, "absorbedInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:absorptionInPartOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/absorptionInPartOfExpression">http://rdaregistry.info/Elements/e/absorptionInPartOfExpression</seealso>
    let absorptionInPartOfExpression =
        Prefixed_Name(rdae, "absorptionInPartOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicalSettingOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicalSettingOfExpression">http://rdaregistry.info/Elements/e/musicalSettingOfExpression</seealso>
    let musicalSettingOfExpression =
        Prefixed_Name(rdae, "musicalSettingOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:musicForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/musicForExpression">http://rdaregistry.info/Elements/e/musicForExpression</seealso>
    let musicForExpression = Prefixed_Name(rdae, "musicForExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:cadenzaExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/cadenzaExpression">http://rdaregistry.info/Elements/e/cadenzaExpression</seealso>
    let cadenzaExpression = Prefixed_Name(rdae, "cadenzaExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20204</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20204">http://rdaregistry.info/Elements/e/P20204</seealso>
    let P20204 = Prefixed_Name(rdae, "P20204") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical variations (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20082">http://rdaregistry.info/Elements/e/P20082</seealso>
    let P20082 = Prefixed_Name(rdae, "P20082") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television screenplay based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20131">http://rdaregistry.info/Elements/e/P20131</seealso>
    let P20131 = Prefixed_Name(rdae, "P20131") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsATelevisionScreenplayExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsATelevisionScreenplayExpression">http://rdaregistry.info/Elements/e/adaptedAsATelevisionScreenplayExpression</seealso>
    let adaptedAsATelevisionScreenplayExpression =
        Prefixed_Name(rdae, "adaptedAsATelevisionScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio script based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20133">http://rdaregistry.info/Elements/e/P20133</seealso>
    let P20133 = Prefixed_Name(rdae, "P20133") |> PrefixedName

    /// <summary>
    ///   <para>rdae:evaluatedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/evaluatedInExpression">http://rdaregistry.info/Elements/e/evaluatedInExpression</seealso>
    let evaluatedInExpression =
        Prefixed_Name(rdae, "evaluatedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorption in part of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20138">http://rdaregistry.info/Elements/e/P20138</seealso>
    let P20138 = Prefixed_Name(rdae, "P20138") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical arrangement of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20139">http://rdaregistry.info/Elements/e/P20139</seealso>
    let P20139 = Prefixed_Name(rdae, "P20139") |> PrefixedName

    /// <summary>
    ///   <para>rdae:abridgedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abridgedAsExpression">http://rdaregistry.info/Elements/e/abridgedAsExpression</seealso>
    let abridgedAsExpression =
        Prefixed_Name(rdae, "abridgedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:librettoBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/librettoBasedOnExpression">http://rdaregistry.info/Elements/e/librettoBasedOnExpression</seealso>
    let librettoBasedOnExpression =
        Prefixed_Name(rdae, "librettoBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20227</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has scale of still image or three-dimensional form</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20227">http://rdaregistry.info/Elements/e/P20227</seealso>
    let P20227 = Prefixed_Name(rdae, "P20227") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20248</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for television program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20248">http://rdaregistry.info/Elements/e/P20248</seealso>
    let P20248 = Prefixed_Name(rdae, "P20248") |> PrefixedName

    /// <summary>
    ///   <para>rdae:televisionProgramMusicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/televisionProgramMusicExpression">http://rdaregistry.info/Elements/e/televisionProgramMusicExpression</seealso>
    let televisionProgramMusicExpression =
        Prefixed_Name(rdae, "televisionProgramMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20251</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture music (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20251">http://rdaregistry.info/Elements/e/P20251</seealso>
    let P20251 = Prefixed_Name(rdae, "P20251") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20252</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for motion picture (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20252">http://rdaregistry.info/Elements/e/P20252</seealso>
    let P20252 = Prefixed_Name(rdae, "P20252") |> PrefixedName

    /// <summary>
    ///   <para>rdae:motionPictureMusicExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/motionPictureMusicExpression">http://rdaregistry.info/Elements/e/motionPictureMusicExpression</seealso>
    let motionPictureMusicExpression =
        Prefixed_Name(rdae, "motionPictureMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/">http://rdaregistry.info/Elements/e/</seealso>
    let _prefix_iri = Prefixed_Name(rdae, "") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has content type</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20001">http://rdaregistry.info/Elements/e/P20001</seealso>
    let P20001 = Prefixed_Name(rdae, "P20001") |> PrefixedName
    /// <summary>
    ///   <para>rdae:contentType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/contentType">http://rdaregistry.info/Elements/e/contentType</seealso>
    let contentType = Prefixed_Name(rdae, "contentType") |> PrefixedName

    /// <summary>
    ///   <para>rdae:identifierForTheExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/identifierForTheExpression">http://rdaregistry.info/Elements/e/identifierForTheExpression</seealso>
    let identifierForTheExpression =
        Prefixed_Name(rdae, "identifierForTheExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other distinguishing characteristic of the expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20003">http://rdaregistry.info/Elements/e/P20003</seealso>
    let P20003 = Prefixed_Name(rdae, "P20003") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of capture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20004">http://rdaregistry.info/Elements/e/P20004</seealso>
    let P20004 = Prefixed_Name(rdae, "P20004") |> PrefixedName
    /// <summary>
    ///   <para>rdae:dateOfCapture</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dateOfCapture">http://rdaregistry.info/Elements/e/dateOfCapture</seealso>
    let dateOfCapture = Prefixed_Name(rdae, "dateOfCapture") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has award</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20005">http://rdaregistry.info/Elements/e/P20005</seealso>
    let P20005 = Prefixed_Name(rdae, "P20005") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20006">http://rdaregistry.info/Elements/e/P20006</seealso>
    let P20006 = Prefixed_Name(rdae, "P20006") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of the content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20007">http://rdaregistry.info/Elements/e/P20007</seealso>
    let P20007 = Prefixed_Name(rdae, "P20007") |> PrefixedName

    /// <summary>
    ///   <para>rdae:languageOfTheContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/languageOfTheContent">http://rdaregistry.info/Elements/e/languageOfTheContent</seealso>
    let languageOfTheContent =
        Prefixed_Name(rdae, "languageOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:artisticAndOrTechnicalCredit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/artisticAndOrTechnicalCredit">http://rdaregistry.info/Elements/e/artisticAndOrTechnicalCredit</seealso>
    let artisticAndOrTechnicalCredit =
        Prefixed_Name(rdae, "artisticAndOrTechnicalCredit") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as motion picture (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20009">http://rdaregistry.info/Elements/e/P20009</seealso>
    let P20009 = Prefixed_Name(rdae, "P20009") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture adaptation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20125">http://rdaregistry.info/Elements/e/P20125</seealso>
    let P20125 = Prefixed_Name(rdae, "P20125") |> PrefixedName

    /// <summary>
    ///   <para>rdae:adaptedAsAMotionPictureExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/adaptedAsAMotionPictureExpression">http://rdaregistry.info/Elements/e/adaptedAsAMotionPictureExpression</seealso>
    let adaptedAsAMotionPictureExpression =
        Prefixed_Name(rdae, "adaptedAsAMotionPictureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20071">http://rdaregistry.info/Elements/e/P20071</seealso>
    let P20071 = Prefixed_Name(rdae, "P20071") |> PrefixedName

    /// <summary>
    ///   <para>rdae:noteOnChangesInContentCharacteristics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/noteOnChangesInContentCharacteristics">http://rdaregistry.info/Elements/e/noteOnChangesInContentCharacteristics</seealso>
    let noteOnChangesInContentCharacteristics =
        Prefixed_Name(rdae, "noteOnChangesInContentCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has conductor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20011">http://rdaregistry.info/Elements/e/P20011</seealso>
    let P20011 = Prefixed_Name(rdae, "P20011") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has on-screen presenter</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20013">http://rdaregistry.info/Elements/e/P20013</seealso>
    let P20013 = Prefixed_Name(rdae, "P20013") |> PrefixedName
    /// <summary>
    ///   <para>rdae:onScreenPresenter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/onScreenPresenter">http://rdaregistry.info/Elements/e/onScreenPresenter</seealso>
    let onScreenPresenter = Prefixed_Name(rdae, "onScreenPresenter") |> PrefixedName
    /// <summary>
    ///   <para>rdae:host</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/host">http://rdaregistry.info/Elements/e/host</seealso>
    let host = Prefixed_Name(rdae, "host") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has moderator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20017">http://rdaregistry.info/Elements/e/P20017</seealso>
    let P20017 = Prefixed_Name(rdae, "P20017") |> PrefixedName
    /// <summary>
    ///   <para>rdae:puppeteer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/puppeteer">http://rdaregistry.info/Elements/e/puppeteer</seealso>
    let puppeteer = Prefixed_Name(rdae, "puppeteer") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has panelist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20019">http://rdaregistry.info/Elements/e/P20019</seealso>
    let P20019 = Prefixed_Name(rdae, "P20019") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has commentator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20021">http://rdaregistry.info/Elements/e/P20021</seealso>
    let P20021 = Prefixed_Name(rdae, "P20021") |> PrefixedName
    /// <summary>
    ///   <para>rdae:commentator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/commentator">http://rdaregistry.info/Elements/e/commentator</seealso>
    let commentator = Prefixed_Name(rdae, "commentator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:storyteller</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/storyteller">http://rdaregistry.info/Elements/e/storyteller</seealso>
    let storyteller = Prefixed_Name(rdae, "storyteller") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has speaker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20024">http://rdaregistry.info/Elements/e/P20024</seealso>
    let P20024 = Prefixed_Name(rdae, "P20024") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has singer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20025">http://rdaregistry.info/Elements/e/P20025</seealso>
    let P20025 = Prefixed_Name(rdae, "P20025") |> PrefixedName
    /// <summary>
    ///   <para>rdae:singer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/singer">http://rdaregistry.info/Elements/e/singer</seealso>
    let singer = Prefixed_Name(rdae, "singer") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has surveyor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20027">http://rdaregistry.info/Elements/e/P20027</seealso>
    let P20027 = Prefixed_Name(rdae, "P20027") |> PrefixedName
    /// <summary>
    ///   <para>rdae:surveyor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/surveyor">http://rdaregistry.info/Elements/e/surveyor</seealso>
    let surveyor = Prefixed_Name(rdae, "surveyor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of added lyrics</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20068">http://rdaregistry.info/Elements/e/P20068</seealso>
    let P20068 = Prefixed_Name(rdae, "P20068") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of supplementary textual content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20046">http://rdaregistry.info/Elements/e/P20046</seealso>
    let P20046 = Prefixed_Name(rdae, "P20046") |> PrefixedName
    /// <summary>
    ///   <para>rdae:writerOfAddedText</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfAddedText">http://rdaregistry.info/Elements/e/writerOfAddedText</seealso>
    let writerOfAddedText = Prefixed_Name(rdae, "writerOfAddedText") |> PrefixedName
    /// <summary>
    ///   <para>rdae:stageDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/stageDirector">http://rdaregistry.info/Elements/e/stageDirector</seealso>
    let stageDirector = Prefixed_Name(rdae, "stageDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has interviewer (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20032">http://rdaregistry.info/Elements/e/P20032</seealso>
    let P20032 = Prefixed_Name(rdae, "P20032") |> PrefixedName

    /// <summary>
    ///   <para>rdae:interviewerExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/interviewerExpression">http://rdaregistry.info/Elements/e/interviewerExpression</seealso>
    let interviewerExpression =
        Prefixed_Name(rdae, "interviewerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has draftsman</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20033">http://rdaregistry.info/Elements/e/P20033</seealso>
    let P20033 = Prefixed_Name(rdae, "P20033") |> PrefixedName
    /// <summary>
    ///   <para>rdae:draftsman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/draftsman">http://rdaregistry.info/Elements/e/draftsman</seealso>
    let draftsman = Prefixed_Name(rdae, "draftsman") |> PrefixedName
    /// <summary>
    ///   <para>rdae:courtReporter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/courtReporter">http://rdaregistry.info/Elements/e/courtReporter</seealso>
    let courtReporter = Prefixed_Name(rdae, "courtReporter") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of preface</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20041">http://rdaregistry.info/Elements/e/P20041</seealso>
    let P20041 = Prefixed_Name(rdae, "P20041") |> PrefixedName
    /// <summary>
    ///   <para>rdae:writerOfPreface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfPreface">http://rdaregistry.info/Elements/e/writerOfPreface</seealso>
    let writerOfPreface = Prefixed_Name(rdae, "writerOfPreface") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has cartographer (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20042">http://rdaregistry.info/Elements/e/P20042</seealso>
    let P20042 = Prefixed_Name(rdae, "P20042") |> PrefixedName

    /// <summary>
    ///   <para>rdae:cartographerExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/cartographerExpression">http://rdaregistry.info/Elements/e/cartographerExpression</seealso>
    let cartographerExpression =
        Prefixed_Name(rdae, "cartographerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:choreographerExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/choreographerExpression">http://rdaregistry.info/Elements/e/choreographerExpression</seealso>
    let choreographerExpression =
        Prefixed_Name(rdae, "choreographerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of added commentary</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20044">http://rdaregistry.info/Elements/e/P20044</seealso>
    let P20044 = Prefixed_Name(rdae, "P20044") |> PrefixedName

    /// <summary>
    ///   <para>rdae:writerOfAddedCommentary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfAddedCommentary">http://rdaregistry.info/Elements/e/writerOfAddedCommentary</seealso>
    let writerOfAddedCommentary =
        Prefixed_Name(rdae, "writerOfAddedCommentary") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of introduction</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20045">http://rdaregistry.info/Elements/e/P20045</seealso>
    let P20045 = Prefixed_Name(rdae, "P20045") |> PrefixedName

    /// <summary>
    ///   <para>rdae:writerOfIntroduction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfIntroduction">http://rdaregistry.info/Elements/e/writerOfIntroduction</seealso>
    let writerOfIntroduction =
        Prefixed_Name(rdae, "writerOfIntroduction") |> PrefixedName

    /// <summary>
    ///   <para>rdae:writerOfSupplementaryTextualContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfSupplementaryTextualContent">http://rdaregistry.info/Elements/e/writerOfSupplementaryTextualContent</seealso>
    let writerOfSupplementaryTextualContent =
        Prefixed_Name(rdae, "writerOfSupplementaryTextualContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has interviewee (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20047">http://rdaregistry.info/Elements/e/P20047</seealso>
    let P20047 = Prefixed_Name(rdae, "P20047") |> PrefixedName

    /// <summary>
    ///   <para>rdae:intervieweeExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/intervieweeExpression">http://rdaregistry.info/Elements/e/intervieweeExpression</seealso>
    let intervieweeExpression =
        Prefixed_Name(rdae, "intervieweeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has editor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20048">http://rdaregistry.info/Elements/e/P20048</seealso>
    let P20048 = Prefixed_Name(rdae, "P20048") |> PrefixedName
    /// <summary>
    ///   <para>rdae:editor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/editor">http://rdaregistry.info/Elements/e/editor</seealso>
    let editor = Prefixed_Name(rdae, "editor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has recording engineer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20050">http://rdaregistry.info/Elements/e/P20050</seealso>
    let P20050 = Prefixed_Name(rdae, "P20050") |> PrefixedName
    /// <summary>
    ///   <para>rdae:recordingEngineer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/recordingEngineer">http://rdaregistry.info/Elements/e/recordingEngineer</seealso>
    let recordingEngineer = Prefixed_Name(rdae, "recordingEngineer") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has illustrator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20051">http://rdaregistry.info/Elements/e/P20051</seealso>
    let P20051 = Prefixed_Name(rdae, "P20051") |> PrefixedName
    /// <summary>
    ///   <para>rdae:illustrator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/illustrator">http://rdaregistry.info/Elements/e/illustrator</seealso>
    let illustrator = Prefixed_Name(rdae, "illustrator") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has recordist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20052">http://rdaregistry.info/Elements/e/P20052</seealso>
    let P20052 = Prefixed_Name(rdae, "P20052") |> PrefixedName
    /// <summary>
    ///   <para>rdae:writerOfAddedLyrics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfAddedLyrics">http://rdaregistry.info/Elements/e/writerOfAddedLyrics</seealso>
    let writerOfAddedLyrics = Prefixed_Name(rdae, "writerOfAddedLyrics") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has summarization of the content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20069">http://rdaregistry.info/Elements/e/P20069</seealso>
    let P20069 = Prefixed_Name(rdae, "P20069") |> PrefixedName

    /// <summary>
    ///   <para>rdae:summarizationOfTheContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/summarizationOfTheContent">http://rdaregistry.info/Elements/e/summarizationOfTheContent</seealso>
    let summarizationOfTheContent =
        Prefixed_Name(rdae, "summarizationOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:voiceActor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/voiceActor">http://rdaregistry.info/Elements/e/voiceActor</seealso>
    let voiceActor = Prefixed_Name(rdae, "voiceActor") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is description of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20072">http://rdaregistry.info/Elements/e/P20072</seealso>
    let P20072 = Prefixed_Name(rdae, "P20072") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is review of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20178">http://rdaregistry.info/Elements/e/P20178</seealso>
    let P20178 = Prefixed_Name(rdae, "P20178") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysis of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20136">http://rdaregistry.info/Elements/e/P20136</seealso>
    let P20136 = Prefixed_Name(rdae, "P20136") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20187</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20187">http://rdaregistry.info/Elements/e/P20187</seealso>
    let P20187 = Prefixed_Name(rdae, "P20187") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critique of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20182">http://rdaregistry.info/Elements/e/P20182</seealso>
    let P20182 = Prefixed_Name(rdae, "P20182") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20150">http://rdaregistry.info/Elements/e/P20150</seealso>
    let P20150 = Prefixed_Name(rdae, "P20150") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20234</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has descriptive expression relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20234">http://rdaregistry.info/Elements/e/P20234</seealso>
    let P20234 = Prefixed_Name(rdae, "P20234") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20202</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is described in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20202">http://rdaregistry.info/Elements/e/P20202</seealso>
    let P20202 = Prefixed_Name(rdae, "P20202") |> PrefixedName

    /// <summary>
    ///   <para>rdae:descriptionOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/descriptionOfExpression">http://rdaregistry.info/Elements/e/descriptionOfExpression</seealso>
    let descriptionOfExpression =
        Prefixed_Name(rdae, "descriptionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dramatized as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20073">http://rdaregistry.info/Elements/e/P20073</seealso>
    let P20073 = Prefixed_Name(rdae, "P20073") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is separated from (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20168">http://rdaregistry.info/Elements/e/P20168</seealso>
    let P20168 = Prefixed_Name(rdae, "P20168") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuedInPartByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuedInPartByExpression">http://rdaregistry.info/Elements/e/continuedInPartByExpression</seealso>
    let continuedInPartByExpression =
        Prefixed_Name(rdae, "continuedInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for television program (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20174">http://rdaregistry.info/Elements/e/P20174</seealso>
    let P20174 = Prefixed_Name(rdae, "P20174") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20175</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for video (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20175">http://rdaregistry.info/Elements/e/P20175</seealso>
    let P20175 = Prefixed_Name(rdae, "P20175") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for motion picture (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20173">http://rdaregistry.info/Elements/e/P20173</seealso>
    let P20173 = Prefixed_Name(rdae, "P20173") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayForExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayForExpression">http://rdaregistry.info/Elements/e/screenplayForExpression</seealso>
    let screenplayForExpression =
        Prefixed_Name(rdae, "screenplayForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20244</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20244">http://rdaregistry.info/Elements/e/P20244</seealso>
    let P20244 = Prefixed_Name(rdae, "P20244") |> PrefixedName
    /// <summary>
    ///   <para>rdae:abstractExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abstractExpression">http://rdaregistry.info/Elements/e/abstractExpression</seealso>
    let abstractExpression = Prefixed_Name(rdae, "abstractExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is addenda (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20109">http://rdaregistry.info/Elements/e/P20109</seealso>
    let P20109 = Prefixed_Name(rdae, "P20109") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is concordance (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20108">http://rdaregistry.info/Elements/e/P20108</seealso>
    let P20108 = Prefixed_Name(rdae, "P20108") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is index (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20156">http://rdaregistry.info/Elements/e/P20156</seealso>
    let P20156 = Prefixed_Name(rdae, "P20156") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is catalogue (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20107">http://rdaregistry.info/Elements/e/P20107</seealso>
    let P20107 = Prefixed_Name(rdae, "P20107") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is finding aid (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20155">http://rdaregistry.info/Elements/e/P20155</seealso>
    let P20155 = Prefixed_Name(rdae, "P20155") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is supplement (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20172">http://rdaregistry.info/Elements/e/P20172</seealso>
    let P20172 = Prefixed_Name(rdae, "P20172") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is guide (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20120">http://rdaregistry.info/Elements/e/P20120</seealso>
    let P20120 = Prefixed_Name(rdae, "P20120") |> PrefixedName

    /// <summary>
    ///   <para>rdae:augmentedByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/augmentedByExpression">http://rdaregistry.info/Elements/e/augmentedByExpression</seealso>
    let augmentedByExpression =
        Prefixed_Name(rdae, "augmentedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is summary (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20106">http://rdaregistry.info/Elements/e/P20106</seealso>
    let P20106 = Prefixed_Name(rdae, "P20106") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is summary of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20179">http://rdaregistry.info/Elements/e/P20179</seealso>
    let P20179 = Prefixed_Name(rdae, "P20179") |> PrefixedName
    /// <summary>
    ///   <para>rdae:summaryExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/summaryExpression">http://rdaregistry.info/Elements/e/summaryExpression</seealso>
    let summaryExpression = Prefixed_Name(rdae, "summaryExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is catalogue of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20180">http://rdaregistry.info/Elements/e/P20180</seealso>
    let P20180 = Prefixed_Name(rdae, "P20180") |> PrefixedName
    /// <summary>
    ///   <para>rdae:catalogueExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/catalogueExpression">http://rdaregistry.info/Elements/e/catalogueExpression</seealso>
    let catalogueExpression = Prefixed_Name(rdae, "catalogueExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is concordance to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20181">http://rdaregistry.info/Elements/e/P20181</seealso>
    let P20181 = Prefixed_Name(rdae, "P20181") |> PrefixedName

    /// <summary>
    ///   <para>rdae:concordanceExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/concordanceExpression">http://rdaregistry.info/Elements/e/concordanceExpression</seealso>
    let concordanceExpression =
        Prefixed_Name(rdae, "concordanceExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is addenda to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20177">http://rdaregistry.info/Elements/e/P20177</seealso>
    let P20177 = Prefixed_Name(rdae, "P20177") |> PrefixedName
    /// <summary>
    ///   <para>rdae:addendaExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/addendaExpression">http://rdaregistry.info/Elements/e/addendaExpression</seealso>
    let addendaExpression = Prefixed_Name(rdae, "addendaExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is basis for libretto (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20110">http://rdaregistry.info/Elements/e/P20110</seealso>
    let P20110 = Prefixed_Name(rdae, "P20110") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto based on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20190">http://rdaregistry.info/Elements/e/P20190</seealso>
    let P20190 = Prefixed_Name(rdae, "P20190") |> PrefixedName

    /// <summary>
    ///   <para>rdae:basisForLibrettoExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/basisForLibrettoExpression">http://rdaregistry.info/Elements/e/basisForLibrettoExpression</seealso>
    let basisForLibrettoExpression =
        Prefixed_Name(rdae, "basisForLibrettoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20111</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reviewed in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20111">http://rdaregistry.info/Elements/e/P20111</seealso>
    let P20111 = Prefixed_Name(rdae, "P20111") |> PrefixedName

    /// <summary>
    ///   <para>rdae:reviewedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/reviewedInExpression">http://rdaregistry.info/Elements/e/reviewedInExpression</seealso>
    let reviewedInExpression =
        Prefixed_Name(rdae, "reviewedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20112</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critiqued in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20112">http://rdaregistry.info/Elements/e/P20112</seealso>
    let P20112 = Prefixed_Name(rdae, "P20112") |> PrefixedName

    /// <summary>
    ///   <para>rdae:critiquedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/critiquedInExpression">http://rdaregistry.info/Elements/e/critiquedInExpression</seealso>
    let critiquedInExpression =
        Prefixed_Name(rdae, "critiquedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20113</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20113">http://rdaregistry.info/Elements/e/P20113</seealso>
    let P20113 = Prefixed_Name(rdae, "P20113") |> PrefixedName

    /// <summary>
    ///   <para>rdae:commentaryInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/commentaryInExpression">http://rdaregistry.info/Elements/e/commentaryInExpression</seealso>
    let commentaryInExpression =
        Prefixed_Name(rdae, "commentaryInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20114</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is imitated as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20114">http://rdaregistry.info/Elements/e/P20114</seealso>
    let P20114 = Prefixed_Name(rdae, "P20114") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is parodied as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20142">http://rdaregistry.info/Elements/e/P20142</seealso>
    let P20142 = Prefixed_Name(rdae, "P20142") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysed in (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20117">http://rdaregistry.info/Elements/e/P20117</seealso>
    let P20117 = Prefixed_Name(rdae, "P20117") |> PrefixedName

    /// <summary>
    ///   <para>rdae:analysedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/analysedInExpression">http://rdaregistry.info/Elements/e/analysedInExpression</seealso>
    let analysedInExpression =
        Prefixed_Name(rdae, "analysedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:appendixExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/appendixExpression">http://rdaregistry.info/Elements/e/appendixExpression</seealso>
    let appendixExpression = Prefixed_Name(rdae, "appendixExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is freely translated as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20119">http://rdaregistry.info/Elements/e/P20119</seealso>
    let P20119 = Prefixed_Name(rdae, "P20119") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is free translation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20140">http://rdaregistry.info/Elements/e/P20140</seealso>
    let P20140 = Prefixed_Name(rdae, "P20140") |> PrefixedName

    /// <summary>
    ///   <para>rdae:freelyTranslatedAsExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/freelyTranslatedAsExpression">http://rdaregistry.info/Elements/e/freelyTranslatedAsExpression</seealso>
    let freelyTranslatedAsExpression =
        Prefixed_Name(rdae, "freelyTranslatedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is guide to (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20147">http://rdaregistry.info/Elements/e/P20147</seealso>
    let P20147 = Prefixed_Name(rdae, "P20147") |> PrefixedName
    /// <summary>
    ///   <para>rdae:guideExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/guideExpression">http://rdaregistry.info/Elements/e/guideExpression</seealso>
    let guideExpression = Prefixed_Name(rdae, "guideExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abridgement of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20121">http://rdaregistry.info/Elements/e/P20121</seealso>
    let P20121 = Prefixed_Name(rdae, "P20121") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abridged as (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20166">http://rdaregistry.info/Elements/e/P20166</seealso>
    let P20166 = Prefixed_Name(rdae, "P20166") |> PrefixedName

    /// <summary>
    ///   <para>rdae:abridgementOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/abridgementOfExpression">http://rdaregistry.info/Elements/e/abridgementOfExpression</seealso>
    let abridgementOfExpression =
        Prefixed_Name(rdae, "abridgementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:verseAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/verseAdaptationOfExpression">http://rdaregistry.info/Elements/e/verseAdaptationOfExpression</seealso>
    let verseAdaptationOfExpression =
        Prefixed_Name(rdae, "verseAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:motionPictureAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/motionPictureAdaptationOfExpression">http://rdaregistry.info/Elements/e/motionPictureAdaptationOfExpression</seealso>
    let motionPictureAdaptationOfExpression =
        Prefixed_Name(rdae, "motionPictureAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:novelizationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/novelizationOfExpression">http://rdaregistry.info/Elements/e/novelizationOfExpression</seealso>
    let novelizationOfExpression =
        Prefixed_Name(rdae, "novelizationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:radioAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/radioAdaptationOfExpression">http://rdaregistry.info/Elements/e/radioAdaptationOfExpression</seealso>
    let radioAdaptationOfExpression =
        Prefixed_Name(rdae, "radioAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:televisionAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/televisionAdaptationOfExpression">http://rdaregistry.info/Elements/e/televisionAdaptationOfExpression</seealso>
    let televisionAdaptationOfExpression =
        Prefixed_Name(rdae, "televisionAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayBasedOnExpression">http://rdaregistry.info/Elements/e/screenplayBasedOnExpression</seealso>
    let screenplayBasedOnExpression =
        Prefixed_Name(rdae, "screenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:videoScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/videoScreenplayBasedOnExpression">http://rdaregistry.info/Elements/e/videoScreenplayBasedOnExpression</seealso>
    let videoScreenplayBasedOnExpression =
        Prefixed_Name(rdae, "videoScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:radioScriptBasedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/radioScriptBasedOnExpression">http://rdaregistry.info/Elements/e/radioScriptBasedOnExpression</seealso>
    let radioScriptBasedOnExpression =
        Prefixed_Name(rdae, "radioScriptBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:videoAdaptationOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/videoAdaptationOfExpression">http://rdaregistry.info/Elements/e/videoAdaptationOfExpression</seealso>
    let videoAdaptationOfExpression =
        Prefixed_Name(rdae, "videoAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digest of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20135">http://rdaregistry.info/Elements/e/P20135</seealso>
    let P20135 = Prefixed_Name(rdae, "P20135") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digest (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20170">http://rdaregistry.info/Elements/e/P20170</seealso>
    let P20170 = Prefixed_Name(rdae, "P20170") |> PrefixedName
    /// <summary>
    ///   <para>rdae:digestOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/digestOfExpression">http://rdaregistry.info/Elements/e/digestOfExpression</seealso>
    let digestOfExpression = Prefixed_Name(rdae, "digestOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:analysisOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/analysisOfExpression">http://rdaregistry.info/Elements/e/analysisOfExpression</seealso>
    let analysisOfExpression =
        Prefixed_Name(rdae, "analysisOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorption of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20137">http://rdaregistry.info/Elements/e/P20137</seealso>
    let P20137 = Prefixed_Name(rdae, "P20137") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is preceded by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20154">http://rdaregistry.info/Elements/e/P20154</seealso>
    let P20154 = Prefixed_Name(rdae, "P20154") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorbed by (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20143">http://rdaregistry.info/Elements/e/P20143</seealso>
    let P20143 = Prefixed_Name(rdae, "P20143") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20200</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is split into (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20200">http://rdaregistry.info/Elements/e/P20200</seealso>
    let P20200 = Prefixed_Name(rdae, "P20200") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuationInPartOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuationInPartOfExpression">http://rdaregistry.info/Elements/e/continuationInPartOfExpression</seealso>
    let continuationInPartOfExpression =
        Prefixed_Name(rdae, "continuationInPartOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:continuesInPartExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/continuesInPartExpression">http://rdaregistry.info/Elements/e/continuesInPartExpression</seealso>
    let continuesInPartExpression =
        Prefixed_Name(rdae, "continuesInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:separatedFromExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/separatedFromExpression">http://rdaregistry.info/Elements/e/separatedFromExpression</seealso>
    let separatedFromExpression =
        Prefixed_Name(rdae, "separatedFromExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:succeededByExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/succeededByExpression">http://rdaregistry.info/Elements/e/succeededByExpression</seealso>
    let succeededByExpression =
        Prefixed_Name(rdae, "succeededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:digestExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/digestExpression">http://rdaregistry.info/Elements/e/digestExpression</seealso>
    let digestExpression = Prefixed_Name(rdae, "digestExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:translatedAs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/translatedAs">http://rdaregistry.info/Elements/e/translatedAs</seealso>
    let translatedAs = Prefixed_Name(rdae, "translatedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supplementExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supplementExpression">http://rdaregistry.info/Elements/e/supplementExpression</seealso>
    let supplementExpression =
        Prefixed_Name(rdae, "supplementExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:screenplayForTheVideoExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/screenplayForTheVideoExpression">http://rdaregistry.info/Elements/e/screenplayForTheVideoExpression</seealso>
    let screenplayForTheVideoExpression =
        Prefixed_Name(rdae, "screenplayForTheVideoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:scriptForTheRadioProgramExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/scriptForTheRadioProgramExpression">http://rdaregistry.info/Elements/e/scriptForTheRadioProgramExpression</seealso>
    let scriptForTheRadioProgramExpression =
        Prefixed_Name(rdae, "scriptForTheRadioProgramExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:addendaToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/addendaToExpression">http://rdaregistry.info/Elements/e/addendaToExpression</seealso>
    let addendaToExpression = Prefixed_Name(rdae, "addendaToExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:reviewOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/reviewOfExpression">http://rdaregistry.info/Elements/e/reviewOfExpression</seealso>
    let reviewOfExpression = Prefixed_Name(rdae, "reviewOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:summaryOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/summaryOfExpression">http://rdaregistry.info/Elements/e/summaryOfExpression</seealso>
    let summaryOfExpression = Prefixed_Name(rdae, "summaryOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:catalogueOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/catalogueOfExpression">http://rdaregistry.info/Elements/e/catalogueOfExpression</seealso>
    let catalogueOfExpression =
        Prefixed_Name(rdae, "catalogueOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:concordanceToExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/concordanceToExpression">http://rdaregistry.info/Elements/e/concordanceToExpression</seealso>
    let concordanceToExpression =
        Prefixed_Name(rdae, "concordanceToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:describedInExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/describedInExpression">http://rdaregistry.info/Elements/e/describedInExpression</seealso>
    let describedInExpression =
        Prefixed_Name(rdae, "describedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20233</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has derivative expression relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20233">http://rdaregistry.info/Elements/e/P20233</seealso>
    let P20233 = Prefixed_Name(rdae, "P20233") |> PrefixedName

    /// <summary>
    ///   <para>rdae:derivativeExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/derivativeExpression">http://rdaregistry.info/Elements/e/derivativeExpression</seealso>
    let derivativeExpression =
        Prefixed_Name(rdae, "derivativeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:basedOnExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/basedOnExpression">http://rdaregistry.info/Elements/e/basedOnExpression</seealso>
    let basedOnExpression = Prefixed_Name(rdae, "basedOnExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20205</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20205">http://rdaregistry.info/Elements/e/P20205</seealso>
    let P20205 = Prefixed_Name(rdae, "P20205") |> PrefixedName
    /// <summary>
    ///   <para>rdae:relatedExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/relatedExpression">http://rdaregistry.info/Elements/e/relatedExpression</seealso>
    let relatedExpression = Prefixed_Name(rdae, "relatedExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20206</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has supplementary content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20206">http://rdaregistry.info/Elements/e/P20206</seealso>
    let P20206 = Prefixed_Name(rdae, "P20206") |> PrefixedName

    /// <summary>
    ///   <para>rdae:supplementaryContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/supplementaryContent">http://rdaregistry.info/Elements/e/supplementaryContent</seealso>
    let supplementaryContent =
        Prefixed_Name(rdae, "supplementaryContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20207</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has illustrative content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20207">http://rdaregistry.info/Elements/e/P20207</seealso>
    let P20207 = Prefixed_Name(rdae, "P20207") |> PrefixedName

    /// <summary>
    ///   <para>rdae:otherDetailsOfCartographicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/otherDetailsOfCartographicContent">http://rdaregistry.info/Elements/e/otherDetailsOfCartographicContent</seealso>
    let otherDetailsOfCartographicContent =
        Prefixed_Name(rdae, "otherDetailsOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:revisedAs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/revisedAs">http://rdaregistry.info/Elements/e/revisedAs</seealso>
    let revisedAs = Prefixed_Name(rdae, "revisedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdae:mergedToFormExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/mergedToFormExpression">http://rdaregistry.info/Elements/e/mergedToFormExpression</seealso>
    let mergedToFormExpression =
        Prefixed_Name(rdae, "mergedToFormExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20213</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has additional scale information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20213">http://rdaregistry.info/Elements/e/P20213</seealso>
    let P20213 = Prefixed_Name(rdae, "P20213") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20228</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has scale</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20228">http://rdaregistry.info/Elements/e/P20228</seealso>
    let P20228 = Prefixed_Name(rdae, "P20228") |> PrefixedName

    /// <summary>
    ///   <para>rdae:additionalScaleInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/additionalScaleInformation">http://rdaregistry.info/Elements/e/additionalScaleInformation</seealso>
    let additionalScaleInformation =
        Prefixed_Name(rdae, "additionalScaleInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20214</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of expression</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20214">http://rdaregistry.info/Elements/e/P20214</seealso>
    let P20214 = Prefixed_Name(rdae, "P20214") |> PrefixedName
    /// <summary>
    ///   <para>rdae:dateOfExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/dateOfExpression">http://rdaregistry.info/Elements/e/dateOfExpression</seealso>
    let dateOfExpression = Prefixed_Name(rdae, "dateOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20215</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has medium of performance of musical content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20215">http://rdaregistry.info/Elements/e/P20215</seealso>
    let P20215 = Prefixed_Name(rdae, "P20215") |> PrefixedName

    /// <summary>
    ///   <para>rdae:mediumOfPerformanceOfMusicalContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/mediumOfPerformanceOfMusicalContent">http://rdaregistry.info/Elements/e/mediumOfPerformanceOfMusicalContent</seealso>
    let mediumOfPerformanceOfMusicalContent =
        Prefixed_Name(rdae, "mediumOfPerformanceOfMusicalContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20216</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has projection of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20216">http://rdaregistry.info/Elements/e/P20216</seealso>
    let P20216 = Prefixed_Name(rdae, "P20216") |> PrefixedName

    /// <summary>
    ///   <para>rdae:projectionOfCartographicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/projectionOfCartographicContent">http://rdaregistry.info/Elements/e/projectionOfCartographicContent</seealso>
    let projectionOfCartographicContent =
        Prefixed_Name(rdae, "projectionOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20217</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place and date of capture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20217">http://rdaregistry.info/Elements/e/P20217</seealso>
    let P20217 = Prefixed_Name(rdae, "P20217") |> PrefixedName

    /// <summary>
    ///   <para>rdae:placeAndDateOfCapture</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/placeAndDateOfCapture">http://rdaregistry.info/Elements/e/placeAndDateOfCapture</seealso>
    let placeAndDateOfCapture =
        Prefixed_Name(rdae, "placeAndDateOfCapture") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20218</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of capture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20218">http://rdaregistry.info/Elements/e/P20218</seealso>
    let P20218 = Prefixed_Name(rdae, "P20218") |> PrefixedName
    /// <summary>
    ///   <para>rdae:placeOfCapture</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/placeOfCapture">http://rdaregistry.info/Elements/e/placeOfCapture</seealso>
    let placeOfCapture = Prefixed_Name(rdae, "placeOfCapture") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20219</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has duration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20219">http://rdaregistry.info/Elements/e/P20219</seealso>
    let P20219 = Prefixed_Name(rdae, "P20219") |> PrefixedName
    /// <summary>
    ///   <para>rdae:duration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/duration">http://rdaregistry.info/Elements/e/duration</seealso>
    let duration = Prefixed_Name(rdae, "duration") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20220</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has colour of moving image</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20220">http://rdaregistry.info/Elements/e/P20220</seealso>
    let P20220 = Prefixed_Name(rdae, "P20220") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20224</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has colour content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20224">http://rdaregistry.info/Elements/e/P20224</seealso>
    let P20224 = Prefixed_Name(rdae, "P20224") |> PrefixedName

    /// <summary>
    ///   <para>rdae:scaleOfStillImageOrThreeDimensionalForm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/scaleOfStillImageOrThreeDimensionalForm">http://rdaregistry.info/Elements/e/scaleOfStillImageOrThreeDimensionalForm</seealso>
    let scaleOfStillImageOrThreeDimensionalForm =
        Prefixed_Name(rdae, "scaleOfStillImageOrThreeDimensionalForm") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20230</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has vertical scale of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20230">http://rdaregistry.info/Elements/e/P20230</seealso>
    let P20230 = Prefixed_Name(rdae, "P20230") |> PrefixedName
    /// <summary>
    ///   <para>rdae:scale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/scale">http://rdaregistry.info/Elements/e/scale</seealso>
    let scale = Prefixed_Name(rdae, "scale") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20229</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has aspect ratio</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20229">http://rdaregistry.info/Elements/e/P20229</seealso>
    let P20229 = Prefixed_Name(rdae, "P20229") |> PrefixedName
    /// <summary>
    ///   <para>rdae:aspectRatio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/aspectRatio">http://rdaregistry.info/Elements/e/aspectRatio</seealso>
    let aspectRatio = Prefixed_Name(rdae, "aspectRatio") |> PrefixedName

    /// <summary>
    ///   <para>rdae:verticalScaleOfCartographicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/verticalScaleOfCartographicContent">http://rdaregistry.info/Elements/e/verticalScaleOfCartographicContent</seealso>
    let verticalScaleOfCartographicContent =
        Prefixed_Name(rdae, "verticalScaleOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20231</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has work expressed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20231">http://rdaregistry.info/Elements/e/P20231</seealso>
    let P20231 = Prefixed_Name(rdae, "P20231") |> PrefixedName
    /// <summary>
    ///   <para>rdae:workExpressed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/workExpressed">http://rdaregistry.info/Elements/e/workExpressed</seealso>
    let workExpressed = Prefixed_Name(rdae, "workExpressed") |> PrefixedName

    /// <summary>
    ///   <para>rdae:accompanyingExpressionRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/accompanyingExpressionRelationship">http://rdaregistry.info/Elements/e/accompanyingExpressionRelationship</seealso>
    let accompanyingExpressionRelationship =
        Prefixed_Name(rdae, "accompanyingExpressionRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdae:derivativeExpressionRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/derivativeExpressionRelationship">http://rdaregistry.info/Elements/e/derivativeExpressionRelationship</seealso>
    let derivativeExpressionRelationship =
        Prefixed_Name(rdae, "derivativeExpressionRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdae:descriptiveExpressionRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/descriptiveExpressionRelationship">http://rdaregistry.info/Elements/e/descriptiveExpressionRelationship</seealso>
    let descriptiveExpressionRelationship =
        Prefixed_Name(rdae, "descriptiveExpressionRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdae:sequentialExpressionRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/sequentialExpressionRelationship">http://rdaregistry.info/Elements/e/sequentialExpressionRelationship</seealso>
    let sequentialExpressionRelationship =
        Prefixed_Name(rdae, "sequentialExpressionRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdae:wholePartExpressionRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/wholePartExpressionRelationship">http://rdaregistry.info/Elements/e/wholePartExpressionRelationship</seealso>
    let wholePartExpressionRelationship =
        Prefixed_Name(rdae, "wholePartExpressionRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdae:P20237</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of afterword</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20237">http://rdaregistry.info/Elements/e/P20237</seealso>
    let P20237 = Prefixed_Name(rdae, "P20237") |> PrefixedName
    /// <summary>
    ///   <para>rdae:writerOfAfterword</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/writerOfAfterword">http://rdaregistry.info/Elements/e/writerOfAfterword</seealso>
    let writerOfAfterword = Prefixed_Name(rdae, "writerOfAfterword") |> PrefixedName
    /// <summary>
    ///   <para>rdae:P20238</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has writer of postface</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/e/P20238">http://rdaregistry.info/Elements/e/P20238</seealso>
    let P20238 = Prefixed_Name(rdae, "P20238") |> PrefixedName

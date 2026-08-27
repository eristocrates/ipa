namespace http.www.wurvoc.org.bibliography.om_2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ombibo =
    let _namespace_iri = Namespace_Iri ombibo |> NamespaceIRI
    /// <summary>
    ///   <para>ombibo:ApJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/ApJ">http://www.wurvoc.org/bibliography/om-2/ApJ</seealso>
    let ApJ = Prefixed_Name(ombibo, "ApJ") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Astrophysical_Techniques</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques">http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques</seealso>
    let Astrophysical_Techniques =
        Prefixed_Name(ombibo, "Astrophysical_Techniques") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Astrophysical_Techniques_chapter1</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques_chapter1">http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques_chapter1</seealso>
    let Astrophysical_Techniques_chapter1 =
        Prefixed_Name(ombibo, "Astrophysical_Techniques_chapter1") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Astrophysical_Techniques_chapter3</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques_chapter3">http://www.wurvoc.org/bibliography/om-2/Astrophysical_Techniques_chapter3</seealso>
    let Astrophysical_Techniques_chapter3 =
        Prefixed_Name(ombibo, "Astrophysical_Techniques_chapter3") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Brengt_Stroemgren</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Brengt_Stroemgren">http://www.wurvoc.org/bibliography/om-2/Brengt_Stroemgren</seealso>
    let Brengt_Stroemgren = Prefixed_Name(ombibo, "Brengt_Stroemgren") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:CR_Kitchin</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/CR_Kitchin">http://www.wurvoc.org/bibliography/om-2/CR_Kitchin</seealso>
    let CR_Kitchin = Prefixed_Name(ombibo, "CR_Kitchin") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Cambridge_University_Press</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Cambridge_University_Press">http://www.wurvoc.org/bibliography/om-2/Cambridge_University_Press</seealso>
    let Cambridge_University_Press =
        Prefixed_Name(ombibo, "Cambridge_University_Press") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Crawford1958</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Crawford1958">http://www.wurvoc.org/bibliography/om-2/Crawford1958</seealso>
    let Crawford1958 = Prefixed_Name(ombibo, "Crawford1958") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Crawford1958Authors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Seq</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Crawford1958Authors">http://www.wurvoc.org/bibliography/om-2/Crawford1958Authors</seealso>
    let Crawford1958Authors =
        Prefixed_Name(ombibo, "Crawford1958Authors") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:DLCrawford</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/DLCrawford">http://www.wurvoc.org/bibliography/om-2/DLCrawford</seealso>
    let DLCrawford = Prefixed_Name(ombibo, "DLCrawford") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:Edwin_Budding</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Edwin_Budding">http://www.wurvoc.org/bibliography/om-2/Edwin_Budding</seealso>
    let Edwin_Budding = Prefixed_Name(ombibo, "Edwin_Budding") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Glossary_Astronomical_Almanac</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:BookSection</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Glossary_Astronomical_Almanac">http://www.wurvoc.org/bibliography/om-2/Glossary_Astronomical_Almanac</seealso>
    let Glossary_Astronomical_Almanac =
        Prefixed_Name(ombibo, "Glossary_Astronomical_Almanac") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Hajo_Rijgersberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Hajo_Rijgersberg">http://www.wurvoc.org/bibliography/om-2/Hajo_Rijgersberg</seealso>
    let Hajo_Rijgersberg = Prefixed_Name(ombibo, "Hajo_Rijgersberg") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:IAUDiv1WG</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/IAUDiv1WG">http://www.wurvoc.org/bibliography/om-2/IAUDiv1WG</seealso>
    let IAUDiv1WG = Prefixed_Name(ombibo, "IAUDiv1WG") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:IAU_2012_Resolution_B2</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/IAU_2012_Resolution_B2">http://www.wurvoc.org/bibliography/om-2/IAU_2012_Resolution_B2</seealso>
    let IAU_2012_Resolution_B2 =
        Prefixed_Name(ombibo, "IAU_2012_Resolution_B2") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Institute_of_Physics_Publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Institute_of_Physics_Publishing">http://www.wurvoc.org/bibliography/om-2/Institute_of_Physics_Publishing</seealso>
    let Institute_of_Physics_Publishing =
        Prefixed_Name(ombibo, "Institute_of_Physics_Publishing") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:International_Astronomical_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/International_Astronomical_Union">http://www.wurvoc.org/bibliography/om-2/International_Astronomical_Union</seealso>
    let International_Astronomical_Union =
        Prefixed_Name(ombibo, "International_Astronomical_Union") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:IntroAstronomicalPhotometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Book</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometry">http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometry</seealso>
    let IntroAstronomicalPhotometry =
        Prefixed_Name(ombibo, "IntroAstronomicalPhotometry") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:IntroAstronomicalPhotometryAuthors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Seq</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometryAuthors">http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometryAuthors</seealso>
    let IntroAstronomicalPhotometryAuthors =
        Prefixed_Name(ombibo, "IntroAstronomicalPhotometryAuthors") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:IntroAstronomicalPhotometry_chapter_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometry_chapter_2">http://www.wurvoc.org/bibliography/om-2/IntroAstronomicalPhotometry_chapter_2</seealso>
    let IntroAstronomicalPhotometry_chapter_2 =
        Prefixed_Name(ombibo, "IntroAstronomicalPhotometry_chapter_2") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Jean_Meeus</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Jean_Meeus">http://www.wurvoc.org/bibliography/om-2/Jean_Meeus</seealso>
    let Jean_Meeus = Prefixed_Name(ombibo, "Jean_Meeus") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:Kenneth_Siedelmann</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Kenneth_Siedelmann">http://www.wurvoc.org/bibliography/om-2/Kenneth_Siedelmann</seealso>
    let Kenneth_Siedelmann = Prefixed_Name(ombibo, "Kenneth_Siedelmann") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:Osman_Demircan</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Osman_Demircan">http://www.wurvoc.org/bibliography/om-2/Osman_Demircan</seealso>
    let Osman_Demircan = Prefixed_Name(ombibo, "Osman_Demircan") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:Stroemgren1956</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Article</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Stroemgren1956">http://www.wurvoc.org/bibliography/om-2/Stroemgren1956</seealso>
    let Stroemgren1956 = Prefixed_Name(ombibo, "Stroemgren1956") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:Stroemgren1956Authors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Seq</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Stroemgren1956Authors">http://www.wurvoc.org/bibliography/om-2/Stroemgren1956Authors</seealso>
    let Stroemgren1956Authors =
        Prefixed_Name(ombibo, "Stroemgren1956Authors") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:University_Science_Books</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/University_Science_Books">http://www.wurvoc.org/bibliography/om-2/University_Science_Books</seealso>
    let University_Science_Books =
        Prefixed_Name(ombibo, "University_Science_Books") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:VU</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/VU">http://www.wurvoc.org/bibliography/om-2/VU</seealso>
    let VU = Prefixed_Name(ombibo, "VU") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:VistasAstronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/VistasAstronomy">http://www.wurvoc.org/bibliography/om-2/VistasAstronomy</seealso>
    let VistasAstronomy = Prefixed_Name(ombibo, "VistasAstronomy") |> PrefixedName
    /// <summary>
    ///   <para>ombibo:Willmann_Bell</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/Willmann_Bell">http://www.wurvoc.org/bibliography/om-2/Willmann_Bell</seealso>
    let Willmann_Bell = Prefixed_Name(ombibo, "Willmann_Bell") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:chapter13_Astronomical_Algorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/chapter13_Astronomical_Algorithms">http://www.wurvoc.org/bibliography/om-2/chapter13_Astronomical_Algorithms</seealso>
    let chapter13_Astronomical_Algorithms =
        Prefixed_Name(ombibo, "chapter13_Astronomical_Algorithms") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:chapter23_Astronomical_Algorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:Chapter</para>
    /// </remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/chapter23_Astronomical_Algorithms">http://www.wurvoc.org/bibliography/om-2/chapter23_Astronomical_Algorithms</seealso>
    let chapter23_Astronomical_Algorithms =
        Prefixed_Name(ombibo, "chapter23_Astronomical_Algorithms") |> PrefixedName

    /// <summary>
    ///   <para>ombibo:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"reference"</para></remarks>
    /// <seealso href="http://www.wurvoc.org/bibliography/om-2/reference">http://www.wurvoc.org/bibliography/om-2/reference</seealso>
    let reference = Prefixed_Name(ombibo, "reference") |> PrefixedName

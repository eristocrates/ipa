namespace http.www.lexinfo.net.ontology._2._0.lexinfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lexinfo =
    let _namespace_iri = Namespace_Iri lexinfo |> NamespaceIRI
    /// <summary>
    ///   <para>lexinfo:AbbreviatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Сокращенная форма"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AbbreviatedForm">http://www.lexinfo.net/ontology/2.0/lexinfo#AbbreviatedForm</seealso>
    let AbbreviatedForm = Prefixed_Name(lexinfo, "AbbreviatedForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AccusativePostPositiveArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AccusativePostPositiveArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#AccusativePostPositiveArgument</seealso>
    let AccusativePostPositiveArgument =
        Prefixed_Name(lexinfo, "AccusativePostPositiveArgument") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivalComplementFrame</seealso>
    let AdjectivalComplementFrame =
        Prefixed_Name(lexinfo, "AdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Adjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Прилагательное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adjective">http://www.lexinfo.net/ontology/2.0/lexinfo#Adjective</seealso>
    let Adjective = Prefixed_Name(lexinfo, "Adjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveAccusativePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAccusativePostPositiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAccusativePostPositiveFrame</seealso>
    let AdjectiveAccusativePostPositiveFrame =
        Prefixed_Name(lexinfo, "AdjectiveAccusativePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveAttributiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAttributiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAttributiveFrame</seealso>
    let AdjectiveAttributiveFrame =
        Prefixed_Name(lexinfo, "AdjectiveAttributiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveComparativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveComparativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveComparativeFrame</seealso>
    let AdjectiveComparativeFrame =
        Prefixed_Name(lexinfo, "AdjectiveComparativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveDativePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveDativePostPositiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveDativePostPositiveFrame</seealso>
    let AdjectiveDativePostPositiveFrame =
        Prefixed_Name(lexinfo, "AdjectiveDativePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveFrame</seealso>
    let AdjectiveFrame = Prefixed_Name(lexinfo, "AdjectiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveGenitivePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveGenitivePostPositiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveGenitivePostPositiveFrame</seealso>
    let AdjectiveGenitivePostPositiveFrame =
        Prefixed_Name(lexinfo, "AdjectiveGenitivePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveImpersonalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveImpersonalFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveImpersonalFrame</seealso>
    let AdjectiveImpersonalFrame =
        Prefixed_Name(lexinfo, "AdjectiveImpersonalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectivePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePOS">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePOS</seealso>
    let AdjectivePOS = Prefixed_Name(lexinfo, "AdjectivePOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:AdjectivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePPFrame</seealso>
    let AdjectivePPFrame = Prefixed_Name(lexinfo, "AdjectivePPFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:AdjectivePhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePhrase">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePhrase</seealso>
    let AdjectivePhrase = Prefixed_Name(lexinfo, "AdjectivePhrase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectivePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePostPositiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePostPositiveFrame</seealso>
    let AdjectivePostPositiveFrame =
        Prefixed_Name(lexinfo, "AdjectivePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectivePredicateFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Note this frame should be used when both attributive and predicative use of the adjective is allowed"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicateFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicateFrame</seealso>
    let AdjectivePredicateFrame =
        Prefixed_Name(lexinfo, "AdjectivePredicateFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectivePredicativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicativeFrame</seealso>
    let AdjectivePredicativeFrame =
        Prefixed_Name(lexinfo, "AdjectivePredicativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveScaleFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveScaleFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveScaleFrame</seealso>
    let AdjectiveScaleFrame =
        Prefixed_Name(lexinfo, "AdjectiveScaleFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdjectiveSuperlativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveSuperlativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveSuperlativeFrame</seealso>
    let AdjectiveSuperlativeFrame =
        Prefixed_Name(lexinfo, "AdjectiveSuperlativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Adjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#Adjunct</seealso>
    let Adjunct = Prefixed_Name(lexinfo, "Adjunct") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Прелог или послелог"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adposition">http://www.lexinfo.net/ontology/2.0/lexinfo#Adposition</seealso>
    let Adposition = Prefixed_Name(lexinfo, "Adposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:AdpositionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionPOS</seealso>
    let AdpositionPOS = Prefixed_Name(lexinfo, "AdpositionPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdpositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionalObject">http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionalObject</seealso>
    let AdpositionalObject =
        Prefixed_Name(lexinfo, "AdpositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Adverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Наречие"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adverb">http://www.lexinfo.net/ontology/2.0/lexinfo#Adverb</seealso>
    let Adverb = Prefixed_Name(lexinfo, "Adverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:AdverbPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbPOS</seealso>
    let AdverbPOS = Prefixed_Name(lexinfo, "AdverbPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbialComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbialComplementFrame</seealso>
    let AdverbialComplementFrame =
        Prefixed_Name(lexinfo, "AdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Аффикс"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Affix">http://www.lexinfo.net/ontology/2.0/lexinfo#Affix</seealso>
    let Affix = Prefixed_Name(lexinfo, "Affix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Animacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Одушевленность"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Animacy">http://www.lexinfo.net/ontology/2.0/lexinfo#Animacy</seealso>
    let Animacy = Prefixed_Name(lexinfo, "Animacy") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ArbitraryControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates either the subject or object of the main clause may be the omitted argument of the subclause"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ArbitraryControl">http://www.lexinfo.net/ontology/2.0/lexinfo#ArbitraryControl</seealso>
    let ArbitraryControl = Prefixed_Name(lexinfo, "ArbitraryControl") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Артикль"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Article">http://www.lexinfo.net/ontology/2.0/lexinfo#Article</seealso>
    let Article = Prefixed_Name(lexinfo, "Article") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ArticlePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ArticlePOS">http://www.lexinfo.net/ontology/2.0/lexinfo#ArticlePOS</seealso>
    let ArticlePOS = Prefixed_Name(lexinfo, "ArticlePOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Вид"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Aspect">http://www.lexinfo.net/ontology/2.0/lexinfo#Aspect</seealso>
    let Aspect = Prefixed_Name(lexinfo, "Aspect") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:AttributiveArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#AttributiveArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#AttributiveArgument</seealso>
    let AttributiveArgument =
        Prefixed_Name(lexinfo, "AttributiveArgument") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:CJK_compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A lexical unit in a CJKV language that is represented by at least two CJKV characters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"compound(cjkv)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"словосочетание в CJKV"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#CJK_compound">http://www.lexinfo.net/ontology/2.0/lexinfo#CJK_compound</seealso>
    let CJK_compound = Prefixed_Name(lexinfo, "CJK_compound") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Case">http://www.lexinfo.net/ontology/2.0/lexinfo#Case</seealso>
    let Case = Prefixed_Name(lexinfo, "Case") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ClausalArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ClausalArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#ClausalArgument</seealso>
    let ClausalArgument = Prefixed_Name(lexinfo, "ClausalArgument") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Cliticness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Клитика"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Cliticness">http://www.lexinfo.net/ontology/2.0/lexinfo#Cliticness</seealso>
    let Cliticness = Prefixed_Name(lexinfo, "Cliticness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:CommonNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Имя нарицательное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#CommonNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#CommonNoun</seealso>
    let CommonNoun = Prefixed_Name(lexinfo, "CommonNoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ComparativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ComparativeAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#ComparativeAdjunct</seealso>
    let ComparativeAdjunct =
        Prefixed_Name(lexinfo, "ComparativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Complement">http://www.lexinfo.net/ontology/2.0/lexinfo#Complement</seealso>
    let Complement = Prefixed_Name(lexinfo, "Complement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Союз"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Conjunction">http://www.lexinfo.net/ontology/2.0/lexinfo#Conjunction</seealso>
    let Conjunction = Prefixed_Name(lexinfo, "Conjunction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ConjunctionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ConjunctionPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#ConjunctionPOS</seealso>
    let ConjunctionPOS = Prefixed_Name(lexinfo, "ConjunctionPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Control">http://www.lexinfo.net/ontology/2.0/lexinfo#Control</seealso>
    let Control = Prefixed_Name(lexinfo, "Control") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Датирование"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Dating">http://www.lexinfo.net/ontology/2.0/lexinfo#Dating</seealso>
    let Dating = Prefixed_Name(lexinfo, "Dating") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DativePostPositiveArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DativePostPositiveArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#DativePostPositiveArgument</seealso>
    let DativePostPositiveArgument =
        Prefixed_Name(lexinfo, "DativePostPositiveArgument") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DativeTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DativeTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#DativeTransitiveFrame</seealso>
    let DativeTransitiveFrame =
        Prefixed_Name(lexinfo, "DativeTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DeclarativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clause beginning with the declarative conjunction ("that" in English)"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeClause">http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeClause</seealso>
    let DeclarativeClause = Prefixed_Name(lexinfo, "DeclarativeClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:DeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction ("that" in English)"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeFrame</seealso>
    let DeclarativeFrame = Prefixed_Name(lexinfo, "DeclarativeFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Definiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Определенность"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Definiteness">http://www.lexinfo.net/ontology/2.0/lexinfo#Definiteness</seealso>
    let Definiteness = Prefixed_Name(lexinfo, "Definiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Степень"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Degree">http://www.lexinfo.net/ontology/2.0/lexinfo#Degree</seealso>
    let Degree = Prefixed_Name(lexinfo, "Degree") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Детерминанта"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Determiner">http://www.lexinfo.net/ontology/2.0/lexinfo#Determiner</seealso>
    let Determiner = Prefixed_Name(lexinfo, "Determiner") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:DeterminerPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeterminerPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#DeterminerPOS</seealso>
    let DeterminerPOS = Prefixed_Name(lexinfo, "DeterminerPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:DirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Прямое дополнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DirectObject">http://www.lexinfo.net/ontology/2.0/lexinfo#DirectObject</seealso>
    let DirectObject = Prefixed_Name(lexinfo, "DirectObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DitransitiveDoubleAccusativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveDoubleAccusativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveDoubleAccusativeFrame</seealso>
    let DitransitiveDoubleAccusativeFrame =
        Prefixed_Name(lexinfo, "DitransitiveDoubleAccusativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame</seealso>
    let DitransitiveFrame = Prefixed_Name(lexinfo, "DitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DitransitiveFrame_For</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_For">http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_For</seealso>
    let DitransitiveFrame_For =
        Prefixed_Name(lexinfo, "DitransitiveFrame_For") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:DitransitiveFrame_To</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_To">http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_To</seealso>
    let DitransitiveFrame_To =
        Prefixed_Name(lexinfo, "DitransitiveFrame_To") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Finiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Конечность"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Finiteness">http://www.lexinfo.net/ontology/2.0/lexinfo#Finiteness</seealso>
    let Finiteness = Prefixed_Name(lexinfo, "Finiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Частота использования"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Frequency">http://www.lexinfo.net/ontology/2.0/lexinfo#Frequency</seealso>
    let Frequency = Prefixed_Name(lexinfo, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:FusedPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A word that is a fusion of a preposition and some other word... examples include the German words "zum" and "daran""</para>
    /// labels<para>"Слитный предлог"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPreposition">http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPreposition</seealso>
    let FusedPreposition = Prefixed_Name(lexinfo, "FusedPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:FusedPrepositionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPrepositionPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPrepositionPOS</seealso>
    let FusedPrepositionPOS =
        Prefixed_Name(lexinfo, "FusedPrepositionPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Род"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gender">http://www.lexinfo.net/ontology/2.0/lexinfo#Gender</seealso>
    let Gender = Prefixed_Name(lexinfo, "Gender") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:GenitiveDitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveDitransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveDitransitiveFrame</seealso>
    let GenitiveDitransitiveFrame =
        Prefixed_Name(lexinfo, "GenitiveDitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:GenitiveObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Дополнение в родительном падеже"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveObject">http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveObject</seealso>
    let GenitiveObject = Prefixed_Name(lexinfo, "GenitiveObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:GenitivePostPositiveArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitivePostPositiveArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#GenitivePostPositiveArgument</seealso>
    let GenitivePostPositiveArgument =
        Prefixed_Name(lexinfo, "GenitivePostPositiveArgument") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:GenitiveTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveTransitiveFrame</seealso>
    let GenitiveTransitiveFrame =
        Prefixed_Name(lexinfo, "GenitiveTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Gerund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clause, whose head is a non-finite verb form, which is used in place of an argument. In English these use the "-ing" suffix"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gerund">http://www.lexinfo.net/ontology/2.0/lexinfo#Gerund</seealso>
    let Gerund = Prefixed_Name(lexinfo, "Gerund") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:GerundACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundACFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GerundACFrame</seealso>
    let GerundACFrame = Prefixed_Name(lexinfo, "GerundACFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:GerundFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates one of the arguments is a gerund clause"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GerundFrame</seealso>
    let GerundFrame = Prefixed_Name(lexinfo, "GerundFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:GerundOCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundOCFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GerundOCFrame</seealso>
    let GerundOCFrame = Prefixed_Name(lexinfo, "GerundOCFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:GerundSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundSCFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#GerundSCFrame</seealso>
    let GerundSCFrame = Prefixed_Name(lexinfo, "GerundSCFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ImpersonalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalFrame</seealso>
    let ImpersonalFrame = Prefixed_Name(lexinfo, "ImpersonalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ImpersonalIntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitiveFrame</seealso>
    let ImpersonalIntransitiveFrame =
        Prefixed_Name(lexinfo, "ImpersonalIntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ImpersonalIntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitivePPFrame</seealso>
    let ImpersonalIntransitivePPFrame =
        Prefixed_Name(lexinfo, "ImpersonalIntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ImpersonalTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalTransitiveFrame</seealso>
    let ImpersonalTransitiveFrame =
        Prefixed_Name(lexinfo, "ImpersonalTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IndirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Косвенное дополнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IndirectObject">http://www.lexinfo.net/ontology/2.0/lexinfo#IndirectObject</seealso>
    let IndirectObject = Prefixed_Name(lexinfo, "IndirectObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:InfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clause whose main verb is infinitive"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveClause</seealso>
    let InfinitiveClause = Prefixed_Name(lexinfo, "InfinitiveClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:InfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Infinitive frames take an infinitive clause as an argument"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveFrame</seealso>
    let InfinitiveFrame = Prefixed_Name(lexinfo, "InfinitiveFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Infix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Суффикс"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Infix">http://www.lexinfo.net/ontology/2.0/lexinfo#Infix</seealso>
    let Infix = Prefixed_Name(lexinfo, "Infix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Междометие"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Interjection">http://www.lexinfo.net/ontology/2.0/lexinfo#Interjection</seealso>
    let Interjection = Prefixed_Name(lexinfo, "Interjection") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:InterrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclause that begins interrogative construction ("wh"-word in English)"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeClause">http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeClause</seealso>
    let InterrogativeClause =
        Prefixed_Name(lexinfo, "InterrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:InterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., "who", "where", "how")"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeFrame</seealso>
    let InterrogativeFrame =
        Prefixed_Name(lexinfo, "InterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:InterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeInfinitiveFrame</seealso>
    let InterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfo, "InterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveAdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdjectivalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdjectivalComplementFrame</seealso>
    let IntransitiveAdjectivalComplementFrame =
        Prefixed_Name(lexinfo, "IntransitiveAdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveAdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdverbialComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdverbialComplementFrame</seealso>
    let IntransitiveAdverbialComplementFrame =
        Prefixed_Name(lexinfo, "IntransitiveAdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveDeclarativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveDeclarativeFrame</seealso>
    let IntransitiveDeclarativeFrame =
        Prefixed_Name(lexinfo, "IntransitiveDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveFrame</seealso>
    let IntransitiveFrame = Prefixed_Name(lexinfo, "IntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveInfinitiveACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveACFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveACFrame</seealso>
    let IntransitiveInfinitiveACFrame =
        Prefixed_Name(lexinfo, "IntransitiveInfinitiveACFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveInfinitiveRSFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveRSFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveRSFrame</seealso>
    let IntransitiveInfinitiveRSFrame =
        Prefixed_Name(lexinfo, "IntransitiveInfinitiveRSFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveInfinitiveSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveSCFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveSCFrame</seealso>
    let IntransitiveInfinitiveSCFrame =
        Prefixed_Name(lexinfo, "IntransitiveInfinitiveSCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"he ASKED [what he should do]"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeFrame</seealso>
    let IntransitiveInterrogativeFrame =
        Prefixed_Name(lexinfo, "IntransitiveInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveInterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame</seealso>
    let IntransitiveInterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfo, "IntransitiveInterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveNominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveNominalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveNominalComplementFrame</seealso>
    let IntransitiveNominalComplementFrame =
        Prefixed_Name(lexinfo, "IntransitiveNominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitivePPDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPDeclarativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPDeclarativeFrame</seealso>
    let IntransitivePPDeclarativeFrame =
        Prefixed_Name(lexinfo, "IntransitivePPDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPFrame</seealso>
    let IntransitivePPFrame =
        Prefixed_Name(lexinfo, "IntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:IntransitiveSententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveSententialFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveSententialFrame</seealso>
    let IntransitiveSententialFrame =
        Prefixed_Name(lexinfo, "IntransitiveSententialFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ModificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ModificationType">http://www.lexinfo.net/ontology/2.0/lexinfo#ModificationType</seealso>
    let ModificationType = Prefixed_Name(lexinfo, "ModificationType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Наклонение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Mood">http://www.lexinfo.net/ontology/2.0/lexinfo#Mood</seealso>
    let Mood = Prefixed_Name(lexinfo, "Mood") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:MorphosyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Морфосинтаксическое свойство"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#MorphosyntacticProperty">http://www.lexinfo.net/ontology/2.0/lexinfo#MorphosyntacticProperty</seealso>
    let MorphosyntacticProperty =
        Prefixed_Name(lexinfo, "MorphosyntacticProperty") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Отрицание"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Negative">http://www.lexinfo.net/ontology/2.0/lexinfo#Negative</seealso>
    let Negative = Prefixed_Name(lexinfo, "Negative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:NominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NominalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#NominalComplementFrame</seealso>
    let NominalComplementFrame =
        Prefixed_Name(lexinfo, "NominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:NormativeAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Норматив"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NormativeAuthorization">http://www.lexinfo.net/ontology/2.0/lexinfo#NormativeAuthorization</seealso>
    let NormativeAuthorization =
        Prefixed_Name(lexinfo, "NormativeAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Имя существительное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Noun">http://www.lexinfo.net/ontology/2.0/lexinfo#Noun</seealso>
    let Noun = Prefixed_Name(lexinfo, "Noun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:NounFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#NounFrame</seealso>
    let NounFrame = Prefixed_Name(lexinfo, "NounFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:NounPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#NounPOS</seealso>
    let NounPOS = Prefixed_Name(lexinfo, "NounPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:NounPPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#NounPPFrame</seealso>
    let NounPPFrame = Prefixed_Name(lexinfo, "NounPPFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:NounPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPhrase">http://www.lexinfo.net/ontology/2.0/lexinfo#NounPhrase</seealso>
    let NounPhrase = Prefixed_Name(lexinfo, "NounPhrase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:NounPossessiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPossessiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#NounPossessiveFrame</seealso>
    let NounPossessiveFrame =
        Prefixed_Name(lexinfo, "NounPossessiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:NounPredicateFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPredicateFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#NounPredicateFrame</seealso>
    let NounPredicateFrame =
        Prefixed_Name(lexinfo, "NounPredicateFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Число"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Number">http://www.lexinfo.net/ontology/2.0/lexinfo#Number</seealso>
    let Number = Prefixed_Name(lexinfo, "Number") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Имя числительное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Numeral">http://www.lexinfo.net/ontology/2.0/lexinfo#Numeral</seealso>
    let Numeral = Prefixed_Name(lexinfo, "Numeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:NumeralPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#NumeralPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#NumeralPOS</seealso>
    let NumeralPOS = Prefixed_Name(lexinfo, "NumeralPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Объект"</para><para>"Дополнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Object">http://www.lexinfo.net/ontology/2.0/lexinfo#Object</seealso>
    let Object = Prefixed_Name(lexinfo, "Object") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ObjectComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectComplement">http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectComplement</seealso>
    let ObjectComplement = Prefixed_Name(lexinfo, "ObjectComplement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ObjectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the object of the main clause is also the (omitted) object of the subclause"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectControl">http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectControl</seealso>
    let ObjectControl = Prefixed_Name(lexinfo, "ObjectControl") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#PPFrame</seealso>
    let PPFrame = Prefixed_Name(lexinfo, "PPFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PartOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Часть речи"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PartOfSpeech">http://www.lexinfo.net/ontology/2.0/lexinfo#PartOfSpeech</seealso>
    let PartOfSpeech = Prefixed_Name(lexinfo, "PartOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Частица"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Particle">http://www.lexinfo.net/ontology/2.0/lexinfo#Particle</seealso>
    let Particle = Prefixed_Name(lexinfo, "Particle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ParticlePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ParticlePOS">http://www.lexinfo.net/ontology/2.0/lexinfo#ParticlePOS</seealso>
    let ParticlePOS = Prefixed_Name(lexinfo, "ParticlePOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Лицо"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Person">http://www.lexinfo.net/ontology/2.0/lexinfo#Person</seealso>
    let Person = Prefixed_Name(lexinfo, "Person") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PossessiveAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PossessiveAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#PossessiveAdjunct</seealso>
    let PossessiveAdjunct = Prefixed_Name(lexinfo, "PossessiveAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PostPositiveArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PostPositiveArgument">http://www.lexinfo.net/ontology/2.0/lexinfo#PostPositiveArgument</seealso>
    let PostPositiveArgument =
        Prefixed_Name(lexinfo, "PostPositiveArgument") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Postposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Послелог"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Postposition">http://www.lexinfo.net/ontology/2.0/lexinfo#Postposition</seealso>
    let Postposition = Prefixed_Name(lexinfo, "Postposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PredicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdjective</seealso>
    let PredicativeAdjective =
        Prefixed_Name(lexinfo, "PredicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PredicativeAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdverb">http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdverb</seealso>
    let PredicativeAdverb = Prefixed_Name(lexinfo, "PredicativeAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PredicativeNominative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeNominative">http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeNominative</seealso>
    let PredicativeNominative =
        Prefixed_Name(lexinfo, "PredicativeNominative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Приставка"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Prefix">http://www.lexinfo.net/ontology/2.0/lexinfo#Prefix</seealso>
    let Prefix = Prefixed_Name(lexinfo, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Предлог"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Preposition">http://www.lexinfo.net/ontology/2.0/lexinfo#Preposition</seealso>
    let Preposition = Prefixed_Name(lexinfo, "Preposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PrepositionFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionFrame</seealso>
    let PrepositionFrame = Prefixed_Name(lexinfo, "PrepositionFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PrepositionPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionPhrase">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionPhrase</seealso>
    let PrepositionPhrase = Prefixed_Name(lexinfo, "PrepositionPhrase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PrepositionalAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalAdjunct</seealso>
    let PrepositionalAdjunct =
        Prefixed_Name(lexinfo, "PrepositionalAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PrepositionalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract frame for words that take a prepositional phrase as an argument"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalFrame</seealso>
    let PrepositionalFrame =
        Prefixed_Name(lexinfo, "PrepositionalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PrepositionalInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalInterrogativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalInterrogativeFrame</seealso>
    let PrepositionalInterrogativeFrame =
        Prefixed_Name(lexinfo, "PrepositionalInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PrepositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Предложное дополнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalObject">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalObject</seealso>
    let PrepositionalObject =
        Prefixed_Name(lexinfo, "PrepositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:PrepositionalPhraseFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalPhraseFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalPhraseFrame</seealso>
    let PrepositionalPhraseFrame =
        Prefixed_Name(lexinfo, "PrepositionalPhraseFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Pronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Местоимение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Pronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#Pronoun</seealso>
    let Pronoun = Prefixed_Name(lexinfo, "Pronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:PronounPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#PronounPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#PronounPOS</seealso>
    let PronounPOS = Prefixed_Name(lexinfo, "PronounPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ProperNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Имя собственное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ProperNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#ProperNoun</seealso>
    let ProperNoun = Prefixed_Name(lexinfo, "ProperNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:RaisableSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#RaisableSubject">http://www.lexinfo.net/ontology/2.0/lexinfo#RaisableSubject</seealso>
    let RaisableSubject = Prefixed_Name(lexinfo, "RaisableSubject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:RaisingSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal."</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#RaisingSubject">http://www.lexinfo.net/ontology/2.0/lexinfo#RaisingSubject</seealso>
    let RaisingSubject = Prefixed_Name(lexinfo, "RaisingSubject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ReciprocalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReciprocalFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReciprocalFrame</seealso>
    let ReciprocalFrame = Prefixed_Name(lexinfo, "ReciprocalFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ReferentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Принадлежность"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReferentType">http://www.lexinfo.net/ontology/2.0/lexinfo#ReferentType</seealso>
    let ReferentType = Prefixed_Name(lexinfo, "ReferentType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveDativeTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ist diese frame echt?"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDativeTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDativeTransitiveFrame</seealso>
    let ReflexiveDativeTransitiveFrame =
        Prefixed_Name(lexinfo, "ReflexiveDativeTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveDitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDitransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDitransitiveFrame</seealso>
    let ReflexiveDitransitiveFrame =
        Prefixed_Name(lexinfo, "ReflexiveDitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveFrame</seealso>
    let ReflexiveFrame = Prefixed_Name(lexinfo, "ReflexiveFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ReflexiveObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Рефлексивное дополнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveObject">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveObject</seealso>
    let ReflexiveObject = Prefixed_Name(lexinfo, "ReflexiveObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveReciprocalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveReciprocalFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveReciprocalFrame</seealso>
    let ReflexiveReciprocalFrame =
        Prefixed_Name(lexinfo, "ReflexiveReciprocalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitiveFrame</seealso>
    let ReflexiveTransitiveFrame =
        Prefixed_Name(lexinfo, "ReflexiveTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:ReflexiveTransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitivePPFrame</seealso>
    let ReflexiveTransitivePPFrame =
        Prefixed_Name(lexinfo, "ReflexiveTransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Register</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Регистр"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Register">http://www.lexinfo.net/ontology/2.0/lexinfo#Register</seealso>
    let Register = Prefixed_Name(lexinfo, "Register") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:SententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SententialFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SententialFrame</seealso>
    let SententialFrame = Prefixed_Name(lexinfo, "SententialFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Подлежащее"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Subject">http://www.lexinfo.net/ontology/2.0/lexinfo#Subject</seealso>
    let Subject = Prefixed_Name(lexinfo, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:SubjectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the subject of the main clause is the (omitted) subject of the subclause"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectControl">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectControl</seealso>
    let SubjectControl = Prefixed_Name(lexinfo, "SubjectControl") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:SubjectlessFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessFrame</seealso>
    let SubjectlessFrame = Prefixed_Name(lexinfo, "SubjectlessFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SubjectlessIntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitiveFrame</seealso>
    let SubjectlessIntransitiveFrame =
        Prefixed_Name(lexinfo, "SubjectlessIntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SubjectlessIntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitivePPFrame</seealso>
    let SubjectlessIntransitivePPFrame =
        Prefixed_Name(lexinfo, "SubjectlessIntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SubjectlessTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitiveFrame</seealso>
    let SubjectlessTransitiveFrame =
        Prefixed_Name(lexinfo, "SubjectlessTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SubjectlessTransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitivePPFrame</seealso>
    let SubjectlessTransitivePPFrame =
        Prefixed_Name(lexinfo, "SubjectlessTransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SubjunctiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclause that is in the subjunctive mood"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjunctiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#SubjunctiveClause</seealso>
    let SubjunctiveClause = Prefixed_Name(lexinfo, "SubjunctiveClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Окончание"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Suffix">http://www.lexinfo.net/ontology/2.0/lexinfo#Suffix</seealso>
    let Suffix = Prefixed_Name(lexinfo, "Suffix") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:SuperlativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SuperlativeAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#SuperlativeAdjunct</seealso>
    let SuperlativeAdjunct =
        Prefixed_Name(lexinfo, "SuperlativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Символ"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Symbol">http://www.lexinfo.net/ontology/2.0/lexinfo#Symbol</seealso>
    let Symbol = Prefixed_Name(lexinfo, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:SymbolPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#SymbolPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#SymbolPOS</seealso>
    let SymbolPOS = Prefixed_Name(lexinfo, "SymbolPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:TemporalQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Временной классификатор"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TemporalQualifier">http://www.lexinfo.net/ontology/2.0/lexinfo#TemporalQualifier</seealso>
    let TemporalQualifier = Prefixed_Name(lexinfo, "TemporalQualifier") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Видовременная форма"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Tense">http://www.lexinfo.net/ontology/2.0/lexinfo#Tense</seealso>
    let Tense = Prefixed_Name(lexinfo, "Tense") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:TermElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TermElement">http://www.lexinfo.net/ontology/2.0/lexinfo#TermElement</seealso>
    let TermElement = Prefixed_Name(lexinfo, "TermElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:TermType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Тип термина"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TermType">http://www.lexinfo.net/ontology/2.0/lexinfo#TermType</seealso>
    let TermType = Prefixed_Name(lexinfo, "TermType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveAdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdjectivalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdjectivalComplementFrame</seealso>
    let TransitiveAdjectivalComplementFrame =
        Prefixed_Name(lexinfo, "TransitiveAdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveAdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdverbialComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdverbialComplementFrame</seealso>
    let TransitiveAdverbialComplementFrame =
        Prefixed_Name(lexinfo, "TransitiveAdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveDeclarativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveDeclarativeFrame</seealso>
    let TransitiveDeclarativeFrame =
        Prefixed_Name(lexinfo, "TransitiveDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveFrame</seealso>
    let TransitiveFrame = Prefixed_Name(lexinfo, "TransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveInfinitiveACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveACFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveACFrame</seealso>
    let TransitiveInfinitiveACFrame =
        Prefixed_Name(lexinfo, "TransitiveInfinitiveACFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveInfinitiveOCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveOCFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveOCFrame</seealso>
    let TransitiveInfinitiveOCFrame =
        Prefixed_Name(lexinfo, "TransitiveInfinitiveOCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveInfinitiveSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveSCFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveSCFrame</seealso>
    let TransitiveInfinitiveSCFrame =
        Prefixed_Name(lexinfo, "TransitiveInfinitiveSCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeFrame</seealso>
    let TransitiveInterrogativeFrame =
        Prefixed_Name(lexinfo, "TransitiveInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveInterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeInfinitiveFrame</seealso>
    let TransitiveInterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfo, "TransitiveInterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveNominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveNominalComplementFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveNominalComplementFrame</seealso>
    let TransitiveNominalComplementFrame =
        Prefixed_Name(lexinfo, "TransitiveNominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitivePPFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitivePPFrame</seealso>
    let TransitivePPFrame = Prefixed_Name(lexinfo, "TransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:TransitiveSententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveSententialFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveSententialFrame</seealso>
    let TransitiveSententialFrame =
        Prefixed_Name(lexinfo, "TransitiveSententialFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:Verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Глагол"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Verb">http://www.lexinfo.net/ontology/2.0/lexinfo#Verb</seealso>
    let Verb = Prefixed_Name(lexinfo, "Verb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:VerbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFormMood">http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFormMood</seealso>
    let VerbFormMood = Prefixed_Name(lexinfo, "VerbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:VerbFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFrame">http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFrame</seealso>
    let VerbFrame = Prefixed_Name(lexinfo, "VerbFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:VerbPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPOS">http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPOS</seealso>
    let VerbPOS = Prefixed_Name(lexinfo, "VerbPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:VerbPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPhrase">http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPhrase</seealso>
    let VerbPhrase = Prefixed_Name(lexinfo, "VerbPhrase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Залог"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#Voice">http://www.lexinfo.net/ontology/2.0/lexinfo#Voice</seealso>
    let Voice = Prefixed_Name(lexinfo, "Voice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:abbreviatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>"A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"сокращенная форма"</para><para>"abbreviated form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviatedForm">http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviatedForm</seealso>
    let abbreviatedForm = Prefixed_Name(lexinfo, "abbreviatedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///
    /// labels<para>"сокращение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviation">http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviation</seealso>
    let abbreviation = Prefixed_Name(lexinfo, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:abbreviationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between an abbreviation and its full or expanded form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abbreviationFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviationFor">http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviationFor</seealso>
    let abbreviationFor = Prefixed_Name(lexinfo, "abbreviationFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:abessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case that expresses the lack or absence of the referent of the noun it marks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abessive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#abessiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#abessiveCase</seealso>
    let abessiveCase = Prefixed_Name(lexinfo, "abessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case used to typically indicate locative or instrumental function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ablative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ablativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#ablativeCase</seealso>
    let ablativeCase = Prefixed_Name(lexinfo, "ablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:absolutiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"absolutive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#absolutiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#absolutiveCase</seealso>
    let absolutiveCase = Prefixed_Name(lexinfo, "absolutiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:accusativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case used to indicate direct object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"винительный падеж"</para><para>"accusative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCase</seealso>
    let accusativeCase = Prefixed_Name(lexinfo, "accusativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:accusativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCaseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCaseForm</seealso>
    let accusativeCaseForm =
        Prefixed_Name(lexinfo, "accusativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"acronym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"акроним"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#acronym">http://www.lexinfo.net/ontology/2.0/lexinfo#acronym</seealso>
    let acronym = Prefixed_Name(lexinfo, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:acronymFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between an acronym and its full or expanded form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"acronymFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#acronymFor">http://www.lexinfo.net/ontology/2.0/lexinfo#acronymFor</seealso>
    let acronymFor = Prefixed_Name(lexinfo, "acronymFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:activeVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Voice</para>
    ///   <para>"Value that expresses the situation where the grammatical subject is also the semantic actor of the verb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"активный залог"</para><para>"active voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#activeVoice">http://www.lexinfo.net/ontology/2.0/lexinfo#activeVoice</seealso>
    let activeVoice = Prefixed_Name(lexinfo, "activeVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case which expresses the meaning of presence 'at' or 'near' a place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adessive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adessiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#adessiveCase</seealso>
    let adessiveCase = Prefixed_Name(lexinfo, "adessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:aditiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Case expressing &amp;quot;to&amp;quot; in Basque studies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aditive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#aditiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#aditiveCase</seealso>
    let aditiveCase = Prefixed_Name(lexinfo, "aditiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>"Part of speech related to attributes of noun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective">http://www.lexinfo.net/ontology/2.0/lexinfo#adjective</seealso>
    let adjective = Prefixed_Name(lexinfo, "adjective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adjective-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>"Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-i">http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-i</seealso>
    let adjective_i = Prefixed_Name(lexinfo, "adjective-i") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adjective-na</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denominal adjectives in Japanese formed from a noun plus the particle 'na'"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-na">http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-na</seealso>
    let adjective_na = Prefixed_Name(lexinfo, "adjective-na") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#adjunct</seealso>
    let adjunct = Prefixed_Name(lexinfo, "adjunct") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:admittedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>"A term rated according to the scale of a term acceptability rating as a synonym for a preferred term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"допустимый термин"</para><para>"admitted term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#admittedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#admittedTerm</seealso>
    let admittedTerm = Prefixed_Name(lexinfo, "admittedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:AdpositionPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adposition">http://www.lexinfo.net/ontology/2.0/lexinfo#adposition</seealso>
    let adposition = Prefixed_Name(lexinfo, "adposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:adpositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adpositionalObject">http://www.lexinfo.net/ontology/2.0/lexinfo#adpositionalObject</seealso>
    let adpositionalObject =
        Prefixed_Name(lexinfo, "adpositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:adverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdverbPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverb">http://www.lexinfo.net/ontology/2.0/lexinfo#adverb</seealso>
    let adverb = Prefixed_Name(lexinfo, "adverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:adverbialComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialComplement">http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialComplement</seealso>
    let adverbialComplement =
        Prefixed_Name(lexinfo, "adverbialComplement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:adverbialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"()"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adverbial pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialPronoun</seealso>
    let adverbialPronoun = Prefixed_Name(lexinfo, "adverbialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:affirmativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Particle used to express affirmation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"affirmative particule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#affirmativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#affirmativeParticle</seealso>
    let affirmativeParticle =
        Prefixed_Name(lexinfo, "affirmativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermElement</para>
    ///
    /// labels<para>"аффикс"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#affix">http://www.lexinfo.net/ontology/2.0/lexinfo#affix</seealso>
    let affix = Prefixed_Name(lexinfo, "affix") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:affixedPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Personnal pronoun that is affixed, i.e. added as an affix to another word."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"affixed personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#affixedPersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#affixedPersonalPronoun</seealso>
    let affixedPersonalPronoun =
        Prefixed_Name(lexinfo, "affixedPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:allativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Case which expresses the meaning of motion 'to' or 'towards' the referent it marks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"allative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#allativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#allativeCase</seealso>
    let allativeCase = Prefixed_Name(lexinfo, "allativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:allusivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Pronoun that refers to something characterized by allusions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"allusive pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#allusivePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#allusivePronoun</seealso>
    let allusivePronoun = Prefixed_Name(lexinfo, "allusivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:animacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"animacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#animacy">http://www.lexinfo.net/ontology/2.0/lexinfo#animacy</seealso>
    let animacy = Prefixed_Name(lexinfo, "animacy") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:animate</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Animacy</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Perceived as alive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"одушевленный"</para><para>"animate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#animate">http://www.lexinfo.net/ontology/2.0/lexinfo#animate</seealso>
    let animate = Prefixed_Name(lexinfo, "animate") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:antonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"antonym term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#antonym">http://www.lexinfo.net/ontology/2.0/lexinfo#antonym</seealso>
    let antonym = Prefixed_Name(lexinfo, "antonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A designation that represents an individual concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"название"</para><para>"appellation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#appellation">http://www.lexinfo.net/ontology/2.0/lexinfo#appellation</seealso>
    let appellation = Prefixed_Name(lexinfo, "appellation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:approximate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to qualify something similar but not exactly the same"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"approximate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#approximate">http://www.lexinfo.net/ontology/2.0/lexinfo#approximate</seealso>
    let approximate = Prefixed_Name(lexinfo, "approximate") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:approximateSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#approximateSynonym">http://www.lexinfo.net/ontology/2.0/lexinfo#approximateSynonym</seealso>
    let approximateSynonym =
        Prefixed_Name(lexinfo, "approximateSynonym") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:archaicForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TemporalQualifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A term or lexeme no longer in ordinary use, though retained for special purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"archaic form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#archaicForm">http://www.lexinfo.net/ontology/2.0/lexinfo#archaicForm</seealso>
    let archaicForm = Prefixed_Name(lexinfo, "archaicForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:ArticlePOS</para>
    ///   <para>"Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"артикль"</para><para>"article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#article">http://www.lexinfo.net/ontology/2.0/lexinfo#article</seealso>
    let article = Prefixed_Name(lexinfo, "article") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#aspect">http://www.lexinfo.net/ontology/2.0/lexinfo#aspect</seealso>
    let aspect = Prefixed_Name(lexinfo, "aspect") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:associativeRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two concepts having a non-hierarchical thematic connection by virtue of experience."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"concept relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#associativeRelation">http://www.lexinfo.net/ontology/2.0/lexinfo#associativeRelation</seealso>
    let associativeRelation =
        Prefixed_Name(lexinfo, "associativeRelation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:attributiveArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#attributiveArg">http://www.lexinfo.net/ontology/2.0/lexinfo#attributiveArg</seealso>
    let attributiveArg = Prefixed_Name(lexinfo, "attributiveArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:baseElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"The root form of a word or term that is used as the formal dictionary entry for the term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"корень слова"</para><para>"baseElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#baseElement">http://www.lexinfo.net/ontology/2.0/lexinfo#baseElement</seealso>
    let baseElement = Prefixed_Name(lexinfo, "baseElement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:benchLevelRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The register of terms used in applications-oriented as opposed to theoretical or academic levels of language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Register of terms used in applications-oriented as opposed to theoretical or academic levels of language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bench-level register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#benchLevelRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#benchLevelRegister</seealso>
    let benchLevelRegister =
        Prefixed_Name(lexinfo, "benchLevelRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:benefactiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"benefactive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#benefactiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#benefactiveCase</seealso>
    let benefactiveCase = Prefixed_Name(lexinfo, "benefactiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:bound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Cliticness</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Linked to a particular element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"связанная"</para><para>"bound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#bound">http://www.lexinfo.net/ontology/2.0/lexinfo#bound</seealso>
    let bound = Prefixed_Name(lexinfo, "bound") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:bullet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Sign used to mark an item in a list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bullet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#bullet">http://www.lexinfo.net/ontology/2.0/lexinfo#bullet</seealso>
    let bullet = Prefixed_Name(lexinfo, "bullet") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:cardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A word denoting a number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"порядковое числительное"</para><para>"cardinal numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#cardinalNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#cardinalNumeral</seealso>
    let cardinalNumeral = Prefixed_Name(lexinfo, "cardinalNumeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#case">http://www.lexinfo.net/ontology/2.0/lexinfo#case</seealso>
    let case = Prefixed_Name(lexinfo, "case") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:causallyRelatedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"causallyRelatedConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#causallyRelatedConcept">http://www.lexinfo.net/ontology/2.0/lexinfo#causallyRelatedConcept</seealso>
    let causallyRelatedConcept =
        Prefixed_Name(lexinfo, "causallyRelatedConcept") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:causativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"causative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#causativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#causativeCase</seealso>
    let causativeCase = Prefixed_Name(lexinfo, "causativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:cessative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Aspect that expresses the cessation of an event or state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cessative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"завершенный"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#cessative">http://www.lexinfo.net/ontology/2.0/lexinfo#cessative</seealso>
    let cessative = Prefixed_Name(lexinfo, "cessative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:circumposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:AdpositionPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Adposition which consists of two parts which are positioned ahead and after the adpositional foci."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"circumposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#circumposition">http://www.lexinfo.net/ontology/2.0/lexinfo#circumposition</seealso>
    let circumposition = Prefixed_Name(lexinfo, "circumposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:clausalArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#clausalArg">http://www.lexinfo.net/ontology/2.0/lexinfo#clausalArg</seealso>
    let clausalArg = Prefixed_Name(lexinfo, "clausalArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:clippedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An abbreviation formed by truncating a part of a simple term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"clipped term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"урезанная форма"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTerm</seealso>
    let clippedTerm = Prefixed_Name(lexinfo, "clippedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:clippedTermFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between a clipped term and its full or expanded form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"clippedTermFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTermFor">http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTermFor</seealso>
    let clippedTermFor = Prefixed_Name(lexinfo, "clippedTermFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:cliticness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Categorization of the different types of clitics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cliticness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#cliticness">http://www.lexinfo.net/ontology/2.0/lexinfo#cliticness</seealso>
    let cliticness = Prefixed_Name(lexinfo, "cliticness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:closeParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"End of a parenthesis pair."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"close parenthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#closeParenthesis">http://www.lexinfo.net/ontology/2.0/lexinfo#closeParenthesis</seealso>
    let closeParenthesis = Prefixed_Name(lexinfo, "closeParenthesis") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"collective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#collective">http://www.lexinfo.net/ontology/2.0/lexinfo#collective</seealso>
    let collective = Prefixed_Name(lexinfo, "collective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:collectivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"A pronoun that refers to all elements of a set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"collective pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#collectivePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#collectivePronoun</seealso>
    let collectivePronoun = Prefixed_Name(lexinfo, "collectivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:collocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#collocation">http://www.lexinfo.net/ontology/2.0/lexinfo#collocation</seealso>
    let collocation = Prefixed_Name(lexinfo, "collocation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:colon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>"Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"двоеточие"</para><para>"colon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#colon">http://www.lexinfo.net/ontology/2.0/lexinfo#colon</seealso>
    let colon = Prefixed_Name(lexinfo, "colon") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:comitativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case which expresses a meaning similar to 'along with' or 'accompagnied by'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comitative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comitativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#comitativeCase</seealso>
    let comitativeCase = Prefixed_Name(lexinfo, "comitativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:comma</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>"Mark (,) used in writing to show a short pause or to separate items in a list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"запятая"</para><para>"comma"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comma">http://www.lexinfo.net/ontology/2.0/lexinfo#comma</seealso>
    let comma = Prefixed_Name(lexinfo, "comma") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:commonGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Gender</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Indistinguished gender for epicenes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"common gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonGender">http://www.lexinfo.net/ontology/2.0/lexinfo#commonGender</seealso>
    let commonGender = Prefixed_Name(lexinfo, "commonGender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A synonym for an international scientific term that is used in general discourse in a given language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"common name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"общепринятое название"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonName">http://www.lexinfo.net/ontology/2.0/lexinfo#commonName</seealso>
    let commonName = Prefixed_Name(lexinfo, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:commonNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Noun that signifies a non-specific member of a group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A noun or adjective denoting a class of objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"commonNoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"common noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#commonNoun</seealso>
    let commonNoun = Prefixed_Name(lexinfo, "commonNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:commonlyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Said of a term that appears frequently."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"частоиспользуемый"</para><para>"commonlyUsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"commonly used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonlyUsed">http://www.lexinfo.net/ontology/2.0/lexinfo#commonlyUsed</seealso>
    let commonlyUsed = Prefixed_Name(lexinfo, "commonlyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:comparative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Degree</para>
    ///   <para>"Comparative is the comparison where only two entites are involved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"сравнительная"</para><para>"comparative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparative">http://www.lexinfo.net/ontology/2.0/lexinfo#comparative</seealso>
    let comparative = Prefixed_Name(lexinfo, "comparative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:comparativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeAdjunct</seealso>
    let comparativeAdjunct =
        Prefixed_Name(lexinfo, "comparativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:comparativeDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeDegreeForm">http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeDegreeForm</seealso>
    let comparativeDegreeForm =
        Prefixed_Name(lexinfo, "comparativeDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:comparativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Particle used to compare."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comparative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeParticle</seealso>
    let comparativeParticle =
        Prefixed_Name(lexinfo, "comparativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"complement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#complement">http://www.lexinfo.net/ontology/2.0/lexinfo#complement</seealso>
    let complement = Prefixed_Name(lexinfo, "complement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"составное слово"</para><para>"compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"сложная форма"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#compound">http://www.lexinfo.net/ontology/2.0/lexinfo#compound</seealso>
    let compound = Prefixed_Name(lexinfo, "compound") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:compoundPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdpositionPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Preposition that is a aggregation of words"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"compound preposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#compoundPreposition">http://www.lexinfo.net/ontology/2.0/lexinfo#compoundPreposition</seealso>
    let compoundPreposition =
        Prefixed_Name(lexinfo, "compoundPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:conditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>"A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"условное"</para><para>"conditional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditional">http://www.lexinfo.net/ontology/2.0/lexinfo#conditional</seealso>
    let conditional = Prefixed_Name(lexinfo, "conditional") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:conditionalParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"conditional particule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conditional particule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalParticle</seealso>
    let conditionalParticle =
        Prefixed_Name(lexinfo, "conditionalParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:conditionalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"conditional pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conditional pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalPronoun</seealso>
    let conditionalPronoun =
        Prefixed_Name(lexinfo, "conditionalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The confidence in a given relationship."</para>
    /// labels<para>"Confidence"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#confidence">http://www.lexinfo.net/ontology/2.0/lexinfo#confidence</seealso>
    let confidence = Prefixed_Name(lexinfo, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ConjunctionPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Word that syntactically links words or constituents, and expresses a semantic relationship between them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conjunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#conjunction">http://www.lexinfo.net/ontology/2.0/lexinfo#conjunction</seealso>
    let conjunction = Prefixed_Name(lexinfo, "conjunction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:contraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"сокращение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#contraction">http://www.lexinfo.net/ontology/2.0/lexinfo#contraction</seealso>
    let contraction = Prefixed_Name(lexinfo, "contraction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:contractionFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The full form that corresponds to a contracted form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contractionFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#contractionFor">http://www.lexinfo.net/ontology/2.0/lexinfo#contractionFor</seealso>
    let contractionFor = Prefixed_Name(lexinfo, "contractionFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:coordinateConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coordinateConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinateConcept">http://www.lexinfo.net/ontology/2.0/lexinfo#coordinateConcept</seealso>
    let coordinateConcept = Prefixed_Name(lexinfo, "coordinateConcept") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:coordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ConjunctionPOS</para>
    ///   <para>"Conjunction that links constituents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coordinating conjunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinatingConjunction">http://www.lexinfo.net/ontology/2.0/lexinfo#coordinatingConjunction</seealso>
    let coordinatingConjunction =
        Prefixed_Name(lexinfo, "coordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:coordinationParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"particle for coordination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coordination particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinationParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#coordinationParticle</seealso>
    let coordinationParticle =
        Prefixed_Name(lexinfo, "coordinationParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:copula</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Special word that combines the subject of a sentence and its description."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"copula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#copula">http://www.lexinfo.net/ontology/2.0/lexinfo#copula</seealso>
    let copula = Prefixed_Name(lexinfo, "copula") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:copulativeArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeArg">http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeArg</seealso>
    let copulativeArg = Prefixed_Name(lexinfo, "copulativeArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:copulativeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeSubject">http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeSubject</seealso>
    let copulativeSubject = Prefixed_Name(lexinfo, "copulativeSubject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication specifying whether the usage is old or modern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dating">http://www.lexinfo.net/ontology/2.0/lexinfo#dating</seealso>
    let dating = Prefixed_Name(lexinfo, "dating") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:dativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCase</seealso>
    let dativeCase = Prefixed_Name(lexinfo, "dativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:dativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCaseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCaseForm</seealso>
    let dativeCaseForm = Prefixed_Name(lexinfo, "dativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:declarativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#declarativeClause">http://www.lexinfo.net/ontology/2.0/lexinfo#declarativeClause</seealso>
    let declarativeClause = Prefixed_Name(lexinfo, "declarativeClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:deficientVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"verb lacking certain morphosyntactic properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deficient verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#deficientVerb">http://www.lexinfo.net/ontology/2.0/lexinfo#deficientVerb</seealso>
    let deficientVerb = Prefixed_Name(lexinfo, "deficientVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:definite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Value referring to the capacity of identification of an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"определенный"</para><para>"definite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#definite">http://www.lexinfo.net/ontology/2.0/lexinfo#definite</seealso>
    let definite = Prefixed_Name(lexinfo, "definite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:definiteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ArticlePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>"Article that allows the reference to a specific, identifiable entity (or class of entities)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definite article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#definiteArticle">http://www.lexinfo.net/ontology/2.0/lexinfo#definiteArticle</seealso>
    let definiteArticle = Prefixed_Name(lexinfo, "definiteArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:definiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property about the possiblity to identify an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definiteness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#definiteness">http://www.lexinfo.net/ontology/2.0/lexinfo#definiteness</seealso>
    let definiteness = Prefixed_Name(lexinfo, "definiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property concerning comparison."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#degree">http://www.lexinfo.net/ontology/2.0/lexinfo#degree</seealso>
    let degree = Prefixed_Name(lexinfo, "degree") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:delativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case which expresses motion downward from the referent of the noun it marks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"delative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#delativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#delativeCase</seealso>
    let delativeCase = Prefixed_Name(lexinfo, "delativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:demonstrativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Determiner used to point to an entity in the situation or elsewhere in a sentence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"demonstrative determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativeDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativeDeterminer</seealso>
    let demonstrativeDeterminer =
        Prefixed_Name(lexinfo, "demonstrativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:demonstrativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Pronoun used to point to an entity in the situation or elsewhere in a sentence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"demonstrative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativePronoun</seealso>
    let demonstrativePronoun =
        Prefixed_Name(lexinfo, "demonstrativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:deprecatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term rated according to the scale of a term acceptability rating as undesired."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deprecated term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"устаревший термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#deprecatedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#deprecatedTerm</seealso>
    let deprecatedTerm = Prefixed_Name(lexinfo, "deprecatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:derivedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#derivedForm">http://www.lexinfo.net/ontology/2.0/lexinfo#derivedForm</seealso>
    let derivedForm = Prefixed_Name(lexinfo, "derivedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#description">http://www.lexinfo.net/ontology/2.0/lexinfo#description</seealso>
    let description = Prefixed_Name(lexinfo, "description") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#determiner">http://www.lexinfo.net/ontology/2.0/lexinfo#determiner</seealso>
    let determiner = Prefixed_Name(lexinfo, "determiner") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:dialectRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dialectRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#dialectRegister</seealso>
    let dialectRegister = Prefixed_Name(lexinfo, "dialectRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:diminutiveNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NounPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"diminutive noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"diminutive noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#diminutiveNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#diminutiveNoun</seealso>
    let diminutiveNoun = Prefixed_Name(lexinfo, "diminutiveNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:directObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relation between a phrase and a verb, in which the relation is central to the verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"direct object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#directObject">http://www.lexinfo.net/ontology/2.0/lexinfo#directObject</seealso>
    let directObject = Prefixed_Name(lexinfo, "directObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:distinctiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"distinctive particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"distinctive particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#distinctiveParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#distinctiveParticle</seealso>
    let distinctiveParticle =
        Prefixed_Name(lexinfo, "distinctiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:dual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>"The form used in some languages to designate two persons or things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Form used in some languages to designate two persons or things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dual">http://www.lexinfo.net/ontology/2.0/lexinfo#dual</seealso>
    let dual = Prefixed_Name(lexinfo, "dual") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:dualNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#dualNumberForm">http://www.lexinfo.net/ontology/2.0/lexinfo#dualNumberForm</seealso>
    let dualNumberForm = Prefixed_Name(lexinfo, "dualNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:elativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case which expresses the meaning of motion 'away from' from the referent of the noun it marks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"elative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#elativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#elativeCase</seealso>
    let elativeCase = Prefixed_Name(lexinfo, "elativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:emphaticPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"An emphatic pronoun is a personal pronoun that is used to emphasize its referent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"emphatic pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#emphaticPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#emphaticPronoun</seealso>
    let emphaticPronoun = Prefixed_Name(lexinfo, "emphaticPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:entryTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A term that heads a terminological entry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"entry term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#entryTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#entryTerm</seealso>
    let entryTerm = Prefixed_Name(lexinfo, "entryTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:equation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"уравнение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#equation">http://www.lexinfo.net/ontology/2.0/lexinfo#equation</seealso>
    let equation = Prefixed_Name(lexinfo, "equation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:equativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#equativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#equativeCase</seealso>
    let equativeCase = Prefixed_Name(lexinfo, "equativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ergativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case assigned to the subject of a transitive verb as opposed to absolutive case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ergative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ergativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#ergativeCase</seealso>
    let ergativeCase = Prefixed_Name(lexinfo, "ergativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:essiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case which expresses a state of being."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"essive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#essiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#essiveCase</seealso>
    let essiveCase = Prefixed_Name(lexinfo, "essiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:etymologicalRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Morpheme that has a particular status with regards to the word's etymology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"etymological root"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymologicalRoot">http://www.lexinfo.net/ontology/2.0/lexinfo#etymologicalRoot</seealso>
    let etymologicalRoot = Prefixed_Name(lexinfo, "etymologicalRoot") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:etymology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information on the origin of a word and the development of its meaning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"etymology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymology">http://www.lexinfo.net/ontology/2.0/lexinfo#etymology</seealso>
    let etymology = Prefixed_Name(lexinfo, "etymology") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:exact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Completely correct in every detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#exact">http://www.lexinfo.net/ontology/2.0/lexinfo#exact</seealso>
    let exact = Prefixed_Name(lexinfo, "exact") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An example of the usage of a frame."</para>
    /// labels<para>"example"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#example">http://www.lexinfo.net/ontology/2.0/lexinfo#example</seealso>
    let example = Prefixed_Name(lexinfo, "example") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:exclamativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Determiner expressing an emotional utterance and marked with a strong intonation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclamative determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativeDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativeDeterminer</seealso>
    let exclamativeDeterminer =
        Prefixed_Name(lexinfo, "exclamativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:exclamativePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>"Special sign (!) usually used in writing to mark exclamation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclamative point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePoint">http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePoint</seealso>
    let exclamativePoint = Prefixed_Name(lexinfo, "exclamativePoint") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:exclamativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Pronoun marked with an emotional utterance and/or a strong intonation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclamative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePronoun</seealso>
    let exclamativePronoun =
        Prefixed_Name(lexinfo, "exclamativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:existentialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"pronoun that indicates the existence of something or someone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"existential pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#existentialPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#existentialPronoun</seealso>
    let existentialPronoun =
        Prefixed_Name(lexinfo, "existentialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:explanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"explanation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#explanation">http://www.lexinfo.net/ontology/2.0/lexinfo#explanation</seealso>
    let explanation = Prefixed_Name(lexinfo, "explanation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A significant word or phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"выражение"</para><para>"expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#expression">http://www.lexinfo.net/ontology/2.0/lexinfo#expression</seealso>
    let expression = Prefixed_Name(lexinfo, "expression") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:facetiousRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#facetiousRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#facetiousRegister</seealso>
    let facetiousRegister = Prefixed_Name(lexinfo, "facetiousRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:feminine</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Gender</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"feminine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"женский"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#feminine">http://www.lexinfo.net/ontology/2.0/lexinfo#feminine</seealso>
    let feminine = Prefixed_Name(lexinfo, "feminine") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:finite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Finiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property applied to a verb form that can occur on its own in an independent sentence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"конечный"</para><para>"finite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#finite">http://www.lexinfo.net/ontology/2.0/lexinfo#finite</seealso>
    let finite = Prefixed_Name(lexinfo, "finite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:finiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property referring to finite and non-finite status of a verbal form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"finitness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#finiteness">http://www.lexinfo.net/ontology/2.0/lexinfo#finiteness</seealso>
    let finiteness = Prefixed_Name(lexinfo, "finiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:firstPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Person</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"first person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"первое лицо"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#firstPerson">http://www.lexinfo.net/ontology/2.0/lexinfo#firstPerson</seealso>
    let firstPerson = Prefixed_Name(lexinfo, "firstPerson") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:firstPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#firstPersonForm">http://www.lexinfo.net/ontology/2.0/lexinfo#firstPersonForm</seealso>
    let firstPersonForm = Prefixed_Name(lexinfo, "firstPersonForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formCaseVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formCaseVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formCaseVariant</seealso>
    let formCaseVariant = Prefixed_Name(lexinfo, "formCaseVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formDegreeVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formDegreeVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formDegreeVariant</seealso>
    let formDegreeVariant = Prefixed_Name(lexinfo, "formDegreeVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formMoodVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formMoodVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formMoodVariant</seealso>
    let formMoodVariant = Prefixed_Name(lexinfo, "formMoodVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formNumberVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formNumberVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formNumberVariant</seealso>
    let formNumberVariant = Prefixed_Name(lexinfo, "formNumberVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formPersonVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formPersonVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formPersonVariant</seealso>
    let formPersonVariant = Prefixed_Name(lexinfo, "formPersonVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:formPositivityVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formPositivityVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formPositivityVariant</seealso>
    let formPositivityVariant =
        Prefixed_Name(lexinfo, "formPositivityVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:formTenseVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formTenseVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#formTenseVariant</seealso>
    let formTenseVariant = Prefixed_Name(lexinfo, "formTenseVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formalRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formalRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#formalRegister</seealso>
    let formalRegister = Prefixed_Name(lexinfo, "formalRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"формула"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#formula">http://www.lexinfo.net/ontology/2.0/lexinfo#formula</seealso>
    let formula = Prefixed_Name(lexinfo, "formula") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relative commonness with which a term occurs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#frequency">http://www.lexinfo.net/ontology/2.0/lexinfo#frequency</seealso>
    let frequency = Prefixed_Name(lexinfo, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:fullArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"For definiteness, when a specific form is the syntactic subject of the clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"full article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullArticle">http://www.lexinfo.net/ontology/2.0/lexinfo#fullArticle</seealso>
    let fullArticle = Prefixed_Name(lexinfo, "fullArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:fullForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"The complete presentation of a term or lexeme for which there is an abbreviated form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"несокращенная форма"</para><para>"full form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullForm">http://www.lexinfo.net/ontology/2.0/lexinfo#fullForm</seealso>
    let fullForm = Prefixed_Name(lexinfo, "fullForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:fullFormFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fullFormFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullFormFor">http://www.lexinfo.net/ontology/2.0/lexinfo#fullFormFor</seealso>
    let fullFormFor = Prefixed_Name(lexinfo, "fullFormFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:fusedPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:FusedPrepositionPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Preposition that is the result of a morphological merge from at least two words."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fused preposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPreposition">http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPreposition</seealso>
    let fusedPreposition = Prefixed_Name(lexinfo, "fusedPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:fusedPrepositionDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:FusedPrepositionPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"word resulting from the aggregation of a proposition and a determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fused preposition determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionDeterminer</seealso>
    let fusedPrepositionDeterminer =
        Prefixed_Name(lexinfo, "fusedPrepositionDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:fusedPrepositionPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:FusedPrepositionPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"word resulting from the aggregation of a preposition and a pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fused preposition pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionPronoun</seealso>
    let fusedPrepositionPronoun =
        Prefixed_Name(lexinfo, "fusedPrepositionPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:fusedPronounAuxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"word resulting from the aggregation of a pronoun and an auxiliary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fused pronoun auxiliary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPronounAuxiliary">http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPronounAuxiliary</seealso>
    let fusedPronounAuxiliary =
        Prefixed_Name(lexinfo, "fusedPronounAuxiliary") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:future</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Tense</para>
    ///   <para>"Verb tense that indicates action or state of being in the future."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"будущее"</para><para>"future"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#future">http://www.lexinfo.net/ontology/2.0/lexinfo#future</seealso>
    let future = Prefixed_Name(lexinfo, "future") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:futureParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Particle used in order to express future."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"future particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#futureParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#futureParticle</seealso>
    let futureParticle = Prefixed_Name(lexinfo, "futureParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:futureTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#futureTenseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#futureTenseForm</seealso>
    let futureTenseForm = Prefixed_Name(lexinfo, "futureTenseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A grammatical category that indicates grammatical relationships between words in sentences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grammatical gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#gender">http://www.lexinfo.net/ontology/2.0/lexinfo#gender</seealso>
    let gender = Prefixed_Name(lexinfo, "gender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:generalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:AdverbPOS</para>
    ///   <para>"Adverb belonging to the general class of adverbs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"general adverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#generalAdverb">http://www.lexinfo.net/ontology/2.0/lexinfo#generalAdverb</seealso>
    let generalAdverb = Prefixed_Name(lexinfo, "generalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:generalizationWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &amp;quot;etc.&amp;quot; sense."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generalization word"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#generalizationWord">http://www.lexinfo.net/ontology/2.0/lexinfo#generalizationWord</seealso>
    let generalizationWord =
        Prefixed_Name(lexinfo, "generalizationWord") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:genericNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"A numeral used to indicate the number of sets/kinds of objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generic numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#genericNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#genericNumeral</seealso>
    let genericNumeral = Prefixed_Name(lexinfo, "genericNumeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:genitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"родительный падеж"</para><para>"genitive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCase</seealso>
    let genitiveCase = Prefixed_Name(lexinfo, "genitiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:genitiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCaseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCaseForm</seealso>
    let genitiveCaseForm = Prefixed_Name(lexinfo, "genitiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:genitiveObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveObject">http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveObject</seealso>
    let genitiveObject = Prefixed_Name(lexinfo, "genitiveObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:geographicalVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Description of a specific form used in a certain region as opposed to another form used in another region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geographical variant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#geographicalVariant">http://www.lexinfo.net/ontology/2.0/lexinfo#geographicalVariant</seealso>
    let geographicalVariant =
        Prefixed_Name(lexinfo, "geographicalVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:gerundClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#gerundClause">http://www.lexinfo.net/ontology/2.0/lexinfo#gerundClause</seealso>
    let gerundClause = Prefixed_Name(lexinfo, "gerundClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:gerundive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:VerbFormMood</para>
    ///
    /// labels<para>"герундий"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#gerundive">http://www.lexinfo.net/ontology/2.0/lexinfo#gerundive</seealso>
    let gerundive = Prefixed_Name(lexinfo, "gerundive") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gloss"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#gloss">http://www.lexinfo.net/ontology/2.0/lexinfo#gloss</seealso>
    let gloss = Prefixed_Name(lexinfo, "gloss") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#head">http://www.lexinfo.net/ontology/2.0/lexinfo#head</seealso>
    let head = Prefixed_Name(lexinfo, "head") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:holonymTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the referenced element is a part of this object"</para>
    /// labels<para>"holonym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#holonymTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#holonymTerm</seealso>
    let holonymTerm = Prefixed_Name(lexinfo, "holonymTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:homograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Word that is written like another, but that has a different pronunciation, meaning, and/or origin."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"homograph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#homograph">http://www.lexinfo.net/ontology/2.0/lexinfo#homograph</seealso>
    let homograph = Prefixed_Name(lexinfo, "homograph") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:homonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Word that sounds the same and is written the same as another word but is different in meaning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"homonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#homonym">http://www.lexinfo.net/ontology/2.0/lexinfo#homonym</seealso>
    let homonym = Prefixed_Name(lexinfo, "homonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:homophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A word that is pronounced in the same way as another word but that is spelled differently."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Word that sounds like another word, but is different in writiing or meaning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"homophone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#homophone">http://www.lexinfo.net/ontology/2.0/lexinfo#homophone</seealso>
    let homophone = Prefixed_Name(lexinfo, "homophone") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:hypernym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#hypernym">http://www.lexinfo.net/ontology/2.0/lexinfo#hypernym</seealso>
    let hypernym = Prefixed_Name(lexinfo, "hypernym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:hyponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#hyponym">http://www.lexinfo.net/ontology/2.0/lexinfo#hyponym</seealso>
    let hyponym = Prefixed_Name(lexinfo, "hyponym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:idiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"idiom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"идиома"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#idiom">http://www.lexinfo.net/ontology/2.0/lexinfo#idiom</seealso>
    let idiom = Prefixed_Name(lexinfo, "idiom") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:illativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#illativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#illativeCase</seealso>
    let illativeCase = Prefixed_Name(lexinfo, "illativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:imperative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>lexinfo:Mood</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Mood used to express an order."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"императивное"</para><para>"imperative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperative">http://www.lexinfo.net/ontology/2.0/lexinfo#imperative</seealso>
    let imperative = Prefixed_Name(lexinfo, "imperative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:imperativeMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperativeMoodForm">http://www.lexinfo.net/ontology/2.0/lexinfo#imperativeMoodForm</seealso>
    let imperativeMoodForm =
        Prefixed_Name(lexinfo, "imperativeMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:imperfect</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Tense</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Verb tense that refers to action in the past that is incomplete or ongoing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"несовершенная"</para><para>"imperfect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfect">http://www.lexinfo.net/ontology/2.0/lexinfo#imperfect</seealso>
    let imperfect = Prefixed_Name(lexinfo, "imperfect") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:imperfectTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfectTenseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#imperfectTenseForm</seealso>
    let imperfectTenseForm =
        Prefixed_Name(lexinfo, "imperfectTenseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:imperfective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Aspect</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"несовершенный"</para><para>"imperfective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfective">http://www.lexinfo.net/ontology/2.0/lexinfo#imperfective</seealso>
    let imperfective = Prefixed_Name(lexinfo, "imperfective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:impersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Pronoun lacking person referent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"impersonal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#impersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#impersonalPronoun</seealso>
    let impersonalPronoun = Prefixed_Name(lexinfo, "impersonalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:inHouseRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>"The register of terms that are company-specific and not readily recognized outside this environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Register of terms that are company-specific and not readily recognized outside this environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in house register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#inHouseRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#inHouseRegister</seealso>
    let inHouseRegister = Prefixed_Name(lexinfo, "inHouseRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:inanimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Animacy</para>
    ///   <para>"Perceived as not living."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"неодушевленный"</para><para>"inanimate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#inanimate">http://www.lexinfo.net/ontology/2.0/lexinfo#inanimate</seealso>
    let inanimate = Prefixed_Name(lexinfo, "inanimate") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:inchoative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Aspect</para>
    ///   <para>"Aspect that expresses the beginning of an event or state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inchoative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#inchoative">http://www.lexinfo.net/ontology/2.0/lexinfo#inchoative</seealso>
    let inchoative = Prefixed_Name(lexinfo, "inchoative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:indefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Definiteness</para>
    ///   <para>"Value related to an entity in a situation where the identification of this entity is not clear cut."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"неопределенный"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefinite">http://www.lexinfo.net/ontology/2.0/lexinfo#indefinite</seealso>
    let indefinite = Prefixed_Name(lexinfo, "indefinite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:indefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Article not capable of expressing identification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteArticle">http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteArticle</seealso>
    let indefiniteArticle = Prefixed_Name(lexinfo, "indefiniteArticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indefiniteCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A word used to express imprecise quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite cardinal numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteCardinalNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteCardinalNumeral</seealso>
    let indefiniteCardinalNumeral =
        Prefixed_Name(lexinfo, "indefiniteCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indefiniteDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Determiner not capable of identification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteDeterminer</seealso>
    let indefiniteDeterminer =
        Prefixed_Name(lexinfo, "indefiniteDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indefiniteMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A word indicating imprecise number of times something happened."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite multiplicative numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteMultiplicativeNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteMultiplicativeNumeral</seealso>
    let indefiniteMultiplicativeNumeral =
        Prefixed_Name(lexinfo, "indefiniteMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indefiniteOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A word used to indicate imprecise rank of an object in a sequence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite ordinal numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteOrdinalNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteOrdinalNumeral</seealso>
    let indefiniteOrdinalNumeral =
        Prefixed_Name(lexinfo, "indefiniteOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indefinitePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Pronoun that does not allow reference."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indefinite pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefinitePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#indefinitePronoun</seealso>
    let indefinitePronoun = Prefixed_Name(lexinfo, "indefinitePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:indicative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>lexinfo:Mood</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Mood value used in the expression of statements and questions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indicative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"изъявительное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indicative">http://www.lexinfo.net/ontology/2.0/lexinfo#indicative</seealso>
    let indicative = Prefixed_Name(lexinfo, "indicative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indicativeMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indicativeMoodForm">http://www.lexinfo.net/ontology/2.0/lexinfo#indicativeMoodForm</seealso>
    let indicativeMoodForm =
        Prefixed_Name(lexinfo, "indicativeMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:indifferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:ModificationType</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Markup to express that there is not any pertinence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indifferent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indifferent">http://www.lexinfo.net/ontology/2.0/lexinfo#indifferent</seealso>
    let indifferent = Prefixed_Name(lexinfo, "indifferent") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:indirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"indirect object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#indirectObject">http://www.lexinfo.net/ontology/2.0/lexinfo#indirectObject</seealso>
    let indirectObject = Prefixed_Name(lexinfo, "indirectObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:inessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case which expresses the meaning of location or position within a place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inessive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#inessiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#inessiveCase</seealso>
    let inessiveCase = Prefixed_Name(lexinfo, "inessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:infinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>"Mood cited as unmarked or base form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"неопределенная форма"</para><para>"infinitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitive">http://www.lexinfo.net/ontology/2.0/lexinfo#infinitive</seealso>
    let infinitive = Prefixed_Name(lexinfo, "infinitive") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:infinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveClause</seealso>
    let infinitiveClause = Prefixed_Name(lexinfo, "infinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:infinitiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Particle used to express infinitive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"infinitive particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveParticle</seealso>
    let infinitiveParticle =
        Prefixed_Name(lexinfo, "infinitiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:infix</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"суффикс"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#infix">http://www.lexinfo.net/ontology/2.0/lexinfo#infix</seealso>
    let infix = Prefixed_Name(lexinfo, "infix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:inflectionElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inflectionElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#inflectionElement">http://www.lexinfo.net/ontology/2.0/lexinfo#inflectionElement</seealso>
    let inflectionElement = Prefixed_Name(lexinfo, "inflectionElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:infrequentlyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Frequency</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Said of a term that does not appear frequently."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"infrequentlyUsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"нечастоиспользуемый"</para><para>"infrequently used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#infrequentlyUsed">http://www.lexinfo.net/ontology/2.0/lexinfo#infrequentlyUsed</seealso>
    let infrequentlyUsed = Prefixed_Name(lexinfo, "infrequentlyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:initialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>lexinfo:AbbreviatedForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initialism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"инициалы"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#initialism">http://www.lexinfo.net/ontology/2.0/lexinfo#initialism</seealso>
    let initialism = Prefixed_Name(lexinfo, "initialism") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:initialismFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between an initialism and its full or expanded form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initialismFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#initialismFor">http://www.lexinfo.net/ontology/2.0/lexinfo#initialismFor</seealso>
    let initialismFor = Prefixed_Name(lexinfo, "initialismFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:instrumentalCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instrumental case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"творительный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#instrumentalCase">http://www.lexinfo.net/ontology/2.0/lexinfo#instrumentalCase</seealso>
    let instrumentalCase = Prefixed_Name(lexinfo, "instrumentalCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Word or sound that expresses an emotion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interjection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interjection">http://www.lexinfo.net/ontology/2.0/lexinfo#interjection</seealso>
    let interjection = Prefixed_Name(lexinfo, "interjection") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:internationalScientificTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"international scientific term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"международный научный термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#internationalScientificTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#internationalScientificTerm</seealso>
    let internationalScientificTerm =
        Prefixed_Name(lexinfo, "internationalScientificTerm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:internationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A term that has the same or nearly identical orthographic or phonemic form in many languages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"internationalism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"интернационализм"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#internationalism">http://www.lexinfo.net/ontology/2.0/lexinfo#internationalism</seealso>
    let internationalism = Prefixed_Name(lexinfo, "internationalism") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>"An interrogative/relative word used to ask about quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative cardinal numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeCardinalNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeCardinalNumeral</seealso>
    let interrogativeCardinalNumeral =
        Prefixed_Name(lexinfo, "interrogativeCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeClause">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeClause</seealso>
    let interrogativeClause =
        Prefixed_Name(lexinfo, "interrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determiner used to express a question."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeDeterminer</seealso>
    let interrogativeDeterminer =
        Prefixed_Name(lexinfo, "interrogativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeInfinitiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeInfinitiveClause</seealso>
    let interrogativeInfinitiveClause =
        Prefixed_Name(lexinfo, "interrogativeInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An interrogative/relative word used to ask about the number of times something happened."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative multiplicative numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeMultiplicativeNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeMultiplicativeNumeral</seealso>
    let interrogativeMultiplicativeNumeral =
        Prefixed_Name(lexinfo, "interrogativeMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"An interrogative/relative word used to ask about numeric ranking."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative ordinal numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeOrdinalNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeOrdinalNumeral</seealso>
    let interrogativeOrdinalNumeral =
        Prefixed_Name(lexinfo, "interrogativeOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Particle used to express a question."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeParticle</seealso>
    let interrogativeParticle =
        Prefixed_Name(lexinfo, "interrogativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Pronoun used to express a question."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativePronoun</seealso>
    let interrogativePronoun =
        Prefixed_Name(lexinfo, "interrogativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:interrogativeRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"pronoun which may act as a relative pronoun or an interrogative one"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interrogative relative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeRelativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeRelativePronoun</seealso>
    let interrogativeRelativePronoun =
        Prefixed_Name(lexinfo, "interrogativeRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:invertedComma</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Inverted comma."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inverted comma"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#invertedComma">http://www.lexinfo.net/ontology/2.0/lexinfo#invertedComma</seealso>
    let invertedComma = Prefixed_Name(lexinfo, "invertedComma") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ironicRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ironicRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#ironicRegister</seealso>
    let ironicRegister = Prefixed_Name(lexinfo, "ironicRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:irreflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"personal pronoun which is not reflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"irreflexive personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#irreflexivePersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#irreflexivePersonalPronoun</seealso>
    let irreflexivePersonalPronoun =
        Prefixed_Name(lexinfo, "irreflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:languageSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#languageSpecific">http://www.lexinfo.net/ontology/2.0/lexinfo#languageSpecific</seealso>
    let languageSpecific = Prefixed_Name(lexinfo, "languageSpecific") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:lativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case which expresses motion to a location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#lativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#lativeCase</seealso>
    let lativeCase = Prefixed_Name(lexinfo, "lativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:legalTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term that is legally defined and used in legally binding documents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"legal term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"легальный термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#legalTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#legalTerm</seealso>
    let legalTerm = Prefixed_Name(lexinfo, "legalTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:SymbolPOS</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#letter">http://www.lexinfo.net/ontology/2.0/lexinfo#letter</seealso>
    let letter = Prefixed_Name(lexinfo, "letter") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:lightVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"verb participating in a complex predication that has little semantic content of its own."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"light verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#lightVerb">http://www.lexinfo.net/ontology/2.0/lexinfo#lightVerb</seealso>
    let lightVerb = Prefixed_Name(lexinfo, "lightVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:locativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case that indicates a final location of action or a time of the action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"locative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"местный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#locativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#locativeCase</seealso>
    let locativeCase = Prefixed_Name(lexinfo, "locativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:logicalExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"logical expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"логическое выражение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#logicalExpression">http://www.lexinfo.net/ontology/2.0/lexinfo#logicalExpression</seealso>
    let logicalExpression = Prefixed_Name(lexinfo, "logicalExpression") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:mainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>"Main verb in contrast to a modal or an auxiliary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"main verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#mainVerb">http://www.lexinfo.net/ontology/2.0/lexinfo#mainVerb</seealso>
    let mainVerb = Prefixed_Name(lexinfo, "mainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:masculine</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Gender</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"мужской"</para><para>"masculine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#masculine">http://www.lexinfo.net/ontology/2.0/lexinfo#masculine</seealso>
    let masculine = Prefixed_Name(lexinfo, "masculine") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:massNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mass noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"massNoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#massNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#massNoun</seealso>
    let massNoun = Prefixed_Name(lexinfo, "massNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:memberHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the object is a member of this"</para>
    /// labels<para>"member holonym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberHolonym">http://www.lexinfo.net/ontology/2.0/lexinfo#memberHolonym</seealso>
    let memberHolonym = Prefixed_Name(lexinfo, "memberHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:memberMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates this is an element of the other"</para>
    /// labels<para>"member meronym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberMeronym">http://www.lexinfo.net/ontology/2.0/lexinfo#memberMeronym</seealso>
    let memberMeronym = Prefixed_Name(lexinfo, "memberMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:meronymTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates this is a part of another concept"</para>
    /// labels<para>"meronym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#meronymTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#meronymTerm</seealso>
    let meronymTerm = Prefixed_Name(lexinfo, "meronymTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:middleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Voice</para>
    ///   <para>"Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"средний залог"</para><para>"медиальный залог"</para><para>"middle voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#middleVoice">http://www.lexinfo.net/ontology/2.0/lexinfo#middleVoice</seealso>
    let middleVoice = Prefixed_Name(lexinfo, "middleVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:modal</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#modal">http://www.lexinfo.net/ontology/2.0/lexinfo#modal</seealso>
    let modal = Prefixed_Name(lexinfo, "modal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:modern</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Dating</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Currently in use."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#modern">http://www.lexinfo.net/ontology/2.0/lexinfo#modern</seealso>
    let modern = Prefixed_Name(lexinfo, "modern") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:modificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the prenominal or postnominal positions of determiners which distinguish different forms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modification type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#modificationType">http://www.lexinfo.net/ontology/2.0/lexinfo#modificationType</seealso>
    let modificationType = Prefixed_Name(lexinfo, "modificationType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#mood">http://www.lexinfo.net/ontology/2.0/lexinfo#mood</seealso>
    let mood = Prefixed_Name(lexinfo, "mood") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:morphologicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"морфологическая часть слова"</para><para>"morphological element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#morphologicalElement">http://www.lexinfo.net/ontology/2.0/lexinfo#morphologicalElement</seealso>
    let morphologicalElement =
        Prefixed_Name(lexinfo, "morphologicalElement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:morphosyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#morphosyntacticProperty">http://www.lexinfo.net/ontology/2.0/lexinfo#morphosyntacticProperty</seealso>
    let morphosyntacticProperty =
        Prefixed_Name(lexinfo, "morphosyntacticProperty") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:multiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A word that expresses the number of times something happened."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"multiplicative numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#multiplicativeNumeral">http://www.lexinfo.net/ontology/2.0/lexinfo#multiplicativeNumeral</seealso>
    let multiplicativeNumeral =
        Prefixed_Name(lexinfo, "multiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"denotes the negation or the absence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"negative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#negative">http://www.lexinfo.net/ontology/2.0/lexinfo#negative</seealso>
    let negative = Prefixed_Name(lexinfo, "negative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:negativeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativeForm">http://www.lexinfo.net/ontology/2.0/lexinfo#negativeForm</seealso>
    let negativeForm = Prefixed_Name(lexinfo, "negativeForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:negativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Particle used to express negation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"negative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#negativeParticle</seealso>
    let negativeParticle = Prefixed_Name(lexinfo, "negativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:negativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Pronoun used in a context of a negation or for expressing a negation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"negative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#negativePronoun</seealso>
    let negativePronoun = Prefixed_Name(lexinfo, "negativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:neuter</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Gender</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"средний"</para><para>"neuter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#neuter">http://www.lexinfo.net/ontology/2.0/lexinfo#neuter</seealso>
    let neuter = Prefixed_Name(lexinfo, "neuter") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:neutralRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Register</para>
    ///   <para>"The register appropriate to general texts or discourse."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"neutral register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#neutralRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#neutralRegister</seealso>
    let neutralRegister = Prefixed_Name(lexinfo, "neutralRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:no</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Cliticness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Negative</para>
    ///   <para>"Value for negation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"нет"</para><para>"no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#no">http://www.lexinfo.net/ontology/2.0/lexinfo#no</seealso>
    let no = Prefixed_Name(lexinfo, "no") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:nominativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case used to indicate the subject of a verb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nominative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"именительный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCase</seealso>
    let nominativeCase = Prefixed_Name(lexinfo, "nominativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:nominativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCaseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCaseForm</seealso>
    let nominativeCaseForm =
        Prefixed_Name(lexinfo, "nominativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:nonFinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Finiteness</para>
    ///   <para>"Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"переходный"</para><para>"non-finite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#nonFinite">http://www.lexinfo.net/ontology/2.0/lexinfo#nonFinite</seealso>
    let nonFinite = Prefixed_Name(lexinfo, "nonFinite") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:normativeAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"normative authorization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#normativeAuthorization">http://www.lexinfo.net/ontology/2.0/lexinfo#normativeAuthorization</seealso>
    let normativeAuthorization =
        Prefixed_Name(lexinfo, "normativeAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A statement that provides further information on any part of a language resource entry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#note">http://www.lexinfo.net/ontology/2.0/lexinfo#note</seealso>
    let note = Prefixed_Name(lexinfo, "note") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:NounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Part of speech used to express the name of a person, place, action or thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"имя существительное"</para><para>"noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#noun">http://www.lexinfo.net/ontology/2.0/lexinfo#noun</seealso>
    let noun = Prefixed_Name(lexinfo, "noun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:nucleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nucleus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"ядро"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#nucleus">http://www.lexinfo.net/ontology/2.0/lexinfo#nucleus</seealso>
    let nucleus = Prefixed_Name(lexinfo, "nucleus") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grammatical number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#number">http://www.lexinfo.net/ontology/2.0/lexinfo#number</seealso>
    let number = Prefixed_Name(lexinfo, "number") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>"Part of speech that expresses a number or the relation to a number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"имя числительное"</para><para>"numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#numeral">http://www.lexinfo.net/ontology/2.0/lexinfo#numeral</seealso>
    let numeral = Prefixed_Name(lexinfo, "numeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:numeralFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NumeralPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Word used to denote the denominator of a fraction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"numeral fraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#numeralFraction">http://www.lexinfo.net/ontology/2.0/lexinfo#numeralFraction</seealso>
    let numeralFraction = Prefixed_Name(lexinfo, "numeralFraction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#object">http://www.lexinfo.net/ontology/2.0/lexinfo#object</seealso>
    let object = Prefixed_Name(lexinfo, "object") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:objectComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#objectComplement">http://www.lexinfo.net/ontology/2.0/lexinfo#objectComplement</seealso>
    let objectComplement = Prefixed_Name(lexinfo, "objectComplement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:obliqueCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"oblique case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#obliqueCase">http://www.lexinfo.net/ontology/2.0/lexinfo#obliqueCase</seealso>
    let obliqueCase = Prefixed_Name(lexinfo, "obliqueCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:obsoleteForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TemporalQualifier</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term or lexeme which is no longer in common use."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"obsolete form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#obsoleteForm">http://www.lexinfo.net/ontology/2.0/lexinfo#obsoleteForm</seealso>
    let obsoleteForm = Prefixed_Name(lexinfo, "obsoleteForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:old</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Dating</para>
    ///   <para>"Used in the past."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"old"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#old">http://www.lexinfo.net/ontology/2.0/lexinfo#old</seealso>
    let old = Prefixed_Name(lexinfo, "old") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:openParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Beginning of a pair of parenthesis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"open parenthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#openParenthesis">http://www.lexinfo.net/ontology/2.0/lexinfo#openParenthesis</seealso>
    let openParenthesis = Prefixed_Name(lexinfo, "openParenthesis") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:optionalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"optionalElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#optionalElement">http://www.lexinfo.net/ontology/2.0/lexinfo#optionalElement</seealso>
    let optionalElement = Prefixed_Name(lexinfo, "optionalElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:ordinalAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Adjective/numeral/number expressing a numeric ranking."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ordinal adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#ordinalAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#ordinalAdjective</seealso>
    let ordinalAdjective = Prefixed_Name(lexinfo, "ordinalAdjective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:otherAnimacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Animacy</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Perceived as related to animacy, but without specific reference to the previous items."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"other animacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"otherAnimacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherAnimacy">http://www.lexinfo.net/ontology/2.0/lexinfo#otherAnimacy</seealso>
    let otherAnimacy = Prefixed_Name(lexinfo, "otherAnimacy") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:otherGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Gender</para>
    ///   <para>"A grammatical category that indicates grammatical relationships between words in sentences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"otherGender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherGender">http://www.lexinfo.net/ontology/2.0/lexinfo#otherGender</seealso>
    let otherGender = Prefixed_Name(lexinfo, "otherGender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:otherNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Number</para>
    ///   <para>"Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"otherNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherNumber">http://www.lexinfo.net/ontology/2.0/lexinfo#otherNumber</seealso>
    let otherNumber = Prefixed_Name(lexinfo, "otherNumber") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:outdatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TemporalQualifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"outdated form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#outdatedForm">http://www.lexinfo.net/ontology/2.0/lexinfo#outdatedForm</seealso>
    let outdatedForm = Prefixed_Name(lexinfo, "outdatedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a part of this object"</para>
    /// labels<para>"part holonym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partHolonym">http://www.lexinfo.net/ontology/2.0/lexinfo#partHolonym</seealso>
    let partHolonym = Prefixed_Name(lexinfo, "partHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates this a component of the other concept"</para>
    /// labels<para>"part meronym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partMeronym">http://www.lexinfo.net/ontology/2.0/lexinfo#partMeronym</seealso>
    let partMeronym = Prefixed_Name(lexinfo, "partMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A unique alphanumeric designation assigned to an object in a manufacturing system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"номер детали"</para><para>"part number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partNumber">http://www.lexinfo.net/ontology/2.0/lexinfo#partNumber</seealso>
    let partNumber = Prefixed_Name(lexinfo, "partNumber") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Term used to describe how a particular word is used in a sentence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A category assigned to a word based on its grammatical and semantic properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"part of speech"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partOfSpeech">http://www.lexinfo.net/ontology/2.0/lexinfo#partOfSpeech</seealso>
    let partOfSpeech = Prefixed_Name(lexinfo, "partOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Term referring to a word derived from a verb and used as an adjective."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"participle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"причастие"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#participle">http://www.lexinfo.net/ontology/2.0/lexinfo#participle</seealso>
    let participle = Prefixed_Name(lexinfo, "participle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:participleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Adjective based on a verb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"participle adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#participleAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#participleAdjective</seealso>
    let participleAdjective =
        Prefixed_Name(lexinfo, "participleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:participleFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#participleFormOf">http://www.lexinfo.net/ontology/2.0/lexinfo#participleFormOf</seealso>
    let participleFormOf = Prefixed_Name(lexinfo, "participleFormOf") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>"Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"частица"</para><para>"particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#particle">http://www.lexinfo.net/ontology/2.0/lexinfo#particle</seealso>
    let particle = Prefixed_Name(lexinfo, "particle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partitiveArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ArticlePOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Article expressing a part or quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partitive article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveArticle">http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveArticle</seealso>
    let partitiveArticle = Prefixed_Name(lexinfo, "partitiveArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partitive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"количественный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveCase</seealso>
    let partitiveCase = Prefixed_Name(lexinfo, "partitiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:partitiveRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partitive relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveRelation">http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveRelation</seealso>
    let partitiveRelation = Prefixed_Name(lexinfo, "partitiveRelation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:passiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Voice</para>
    ///   <para>"Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"пассивный залог"</para><para>"passive voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#passiveVoice">http://www.lexinfo.net/ontology/2.0/lexinfo#passiveVoice</seealso>
    let passiveVoice = Prefixed_Name(lexinfo, "passiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:past</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Tense</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Past tense is an absolute tense that refers to a time before the moment of utterance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"прошлое"</para><para>"past"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#past">http://www.lexinfo.net/ontology/2.0/lexinfo#past</seealso>
    let past = Prefixed_Name(lexinfo, "past") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:pastParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Adjective based on a past participle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"past participle adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pastParticipleAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#pastParticipleAdjective</seealso>
    let pastParticipleAdjective =
        Prefixed_Name(lexinfo, "pastParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:pastTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pastTenseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#pastTenseForm</seealso>
    let pastTenseForm = Prefixed_Name(lexinfo, "pastTenseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:paucal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Number</para>
    ///   <para>"Number that specifies 'a few' things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"paucal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#paucal">http://www.lexinfo.net/ontology/2.0/lexinfo#paucal</seealso>
    let paucal = Prefixed_Name(lexinfo, "paucal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:perfective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"совершенный"</para><para>"perfective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#perfective">http://www.lexinfo.net/ontology/2.0/lexinfo#perfective</seealso>
    let perfective = Prefixed_Name(lexinfo, "perfective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#person">http://www.lexinfo.net/ontology/2.0/lexinfo#person</seealso>
    let person = Prefixed_Name(lexinfo, "person") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:personal</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ReferentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Property that refers to the person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"personal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#personal">http://www.lexinfo.net/ontology/2.0/lexinfo#personal</seealso>
    let personal = Prefixed_Name(lexinfo, "personal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:personalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Pronoun referring a person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#personalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#personalPronoun</seealso>
    let personalPronoun = Prefixed_Name(lexinfo, "personalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:pertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pertainsTo">http://www.lexinfo.net/ontology/2.0/lexinfo#pertainsTo</seealso>
    let pertainsTo = Prefixed_Name(lexinfo, "pertainsTo") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:phraseologicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phraseological unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"фразеологическая единица"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#phraseologicalUnit">http://www.lexinfo.net/ontology/2.0/lexinfo#phraseologicalUnit</seealso>
    let phraseologicalUnit =
        Prefixed_Name(lexinfo, "phraseologicalUnit") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:plainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>"verb which has its own semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plain verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#plainVerb">http://www.lexinfo.net/ontology/2.0/lexinfo#plainVerb</seealso>
    let plainVerb = Prefixed_Name(lexinfo, "plainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:plural</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The form of a term or word (usually of a noun) used to designate more than one object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Value that expresses more than one element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"множественное"</para><para>"plural"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#plural">http://www.lexinfo.net/ontology/2.0/lexinfo#plural</seealso>
    let plural = Prefixed_Name(lexinfo, "plural") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:pluralNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pluralNumberForm">http://www.lexinfo.net/ontology/2.0/lexinfo#pluralNumberForm</seealso>
    let pluralNumberForm = Prefixed_Name(lexinfo, "pluralNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Sign (.) used to expresses the end of a sentence or an abbreviation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#point">http://www.lexinfo.net/ontology/2.0/lexinfo#point</seealso>
    let point = Prefixed_Name(lexinfo, "point") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:positive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Degree</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Value used in a comparison relationship when no comparison is involved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"positive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"положительная"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#positive">http://www.lexinfo.net/ontology/2.0/lexinfo#positive</seealso>
    let positive = Prefixed_Name(lexinfo, "positive") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:positiveDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#positiveDegreeForm">http://www.lexinfo.net/ontology/2.0/lexinfo#positiveDegreeForm</seealso>
    let positiveDegreeForm =
        Prefixed_Name(lexinfo, "positiveDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:positiveForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#positiveForm">http://www.lexinfo.net/ontology/2.0/lexinfo#positiveForm</seealso>
    let positiveForm = Prefixed_Name(lexinfo, "positiveForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:possessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ReferentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relative to the possession or association."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessive">http://www.lexinfo.net/ontology/2.0/lexinfo#possessive</seealso>
    let possessive = Prefixed_Name(lexinfo, "possessive") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"An adjective derived from a noun and denoting possession by the object described by the noun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjective</seealso>
    let possessiveAdjective =
        Prefixed_Name(lexinfo, "possessiveAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjunct</seealso>
    let possessiveAdjunct = Prefixed_Name(lexinfo, "possessiveAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Determiner that expresses ownership."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveDeterminer</seealso>
    let possessiveDeterminer =
        Prefixed_Name(lexinfo, "possessiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveInfinitiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveInfinitiveClause</seealso>
    let possessiveInfinitiveClause =
        Prefixed_Name(lexinfo, "possessiveInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Particle expressing ownship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveParticle</seealso>
    let possessiveParticle =
        Prefixed_Name(lexinfo, "possessiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessivePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#possessivePronoun</seealso>
    let possessivePronoun = Prefixed_Name(lexinfo, "possessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:possessiveRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possessive relative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveRelativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveRelativePronoun</seealso>
    let possessiveRelativePronoun =
        Prefixed_Name(lexinfo, "possessiveRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:postModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ModificationType</para>
    ///   <para>"Situation where the modifier is after the modified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"post modifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#postModifier">http://www.lexinfo.net/ontology/2.0/lexinfo#postModifier</seealso>
    let postModifier = Prefixed_Name(lexinfo, "postModifier") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:postPositiveArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something"</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#postPositiveArg">http://www.lexinfo.net/ontology/2.0/lexinfo#postPositiveArg</seealso>
    let postPositiveArg = Prefixed_Name(lexinfo, "postPositiveArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:postposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdpositionPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Adposition that appears at the end of the noun phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"postposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#postposition">http://www.lexinfo.net/ontology/2.0/lexinfo#postposition</seealso>
    let postposition = Prefixed_Name(lexinfo, "postposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:preModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:ModificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Situation where the modifier is before the modified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"premodifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#preModifier">http://www.lexinfo.net/ontology/2.0/lexinfo#preModifier</seealso>
    let preModifier = Prefixed_Name(lexinfo, "preModifier") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:predicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjective</seealso>
    let predicativeAdjective =
        Prefixed_Name(lexinfo, "predicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:predicativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjunct</seealso>
    let predicativeAdjunct =
        Prefixed_Name(lexinfo, "predicativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:predicativeAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdverb">http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdverb</seealso>
    let predicativeAdverb = Prefixed_Name(lexinfo, "predicativeAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:predicativeNominative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeNominative">http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeNominative</seealso>
    let predicativeNominative =
        Prefixed_Name(lexinfo, "predicativeNominative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:preferredTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term rated according to the scale of a term acceptability rating as the primary term for a given concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preferred term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"предпочтительный термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#preferredTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#preferredTerm</seealso>
    let preferredTerm = Prefixed_Name(lexinfo, "preferredTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"приставка"</para><para>"префикс"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prefix">http://www.lexinfo.net/ontology/2.0/lexinfo#prefix</seealso>
    let prefix = Prefixed_Name(lexinfo, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:AdpositionPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Adposition placed at the beginning of a noun phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#preposition">http://www.lexinfo.net/ontology/2.0/lexinfo#preposition</seealso>
    let preposition = Prefixed_Name(lexinfo, "preposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:prepositionalAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdjunct</seealso>
    let prepositionalAdjunct =
        Prefixed_Name(lexinfo, "prepositionalAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:prepositionalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:AdverbPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"adverb which is very similar in its form to a preposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prepositional adverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdverb">http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdverb</seealso>
    let prepositionalAdverb =
        Prefixed_Name(lexinfo, "prepositionalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:prepositionalGerundClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalGerundClause">http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalGerundClause</seealso>
    let prepositionalGerundClause =
        Prefixed_Name(lexinfo, "prepositionalGerundClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:prepositionalInterrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalInterrogativeClause">http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalInterrogativeClause</seealso>
    let prepositionalInterrogativeClause =
        Prefixed_Name(lexinfo, "prepositionalInterrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:prepositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalObject">http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalObject</seealso>
    let prepositionalObject =
        Prefixed_Name(lexinfo, "prepositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Tense</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Verb tense that indicates action or state of being in the present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"настоящее"</para><para>"present"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#present">http://www.lexinfo.net/ontology/2.0/lexinfo#present</seealso>
    let present = Prefixed_Name(lexinfo, "present") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:presentParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>"Adjective based on a present participle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"present participle adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentParticipleAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#presentParticipleAdjective</seealso>
    let presentParticipleAdjective =
        Prefixed_Name(lexinfo, "presentParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:presentTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentTenseForm">http://www.lexinfo.net/ontology/2.0/lexinfo#presentTenseForm</seealso>
    let presentTenseForm = Prefixed_Name(lexinfo, "presentTenseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:presentativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"pronoun that identify the current locative or temporal situation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"presentative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#presentativePronoun</seealso>
    let presentativePronoun =
        Prefixed_Name(lexinfo, "presentativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:preterite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Tense</para>
    ///   <para>"The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown""</para>
    /// labels<para>"претерит"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#preterite">http://www.lexinfo.net/ontology/2.0/lexinfo#preterite</seealso>
    let preterite = Prefixed_Name(lexinfo, "preterite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:productName</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"An attribute assigned to a term indicating that that term is the official designator for a product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"productName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"название продукта"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#productName">http://www.lexinfo.net/ontology/2.0/lexinfo#productName</seealso>
    let productName = Prefixed_Name(lexinfo, "productName") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:prolativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prolative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#prolativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#prolativeCase</seealso>
    let prolativeCase = Prefixed_Name(lexinfo, "prolativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:pronominalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:AdverbPOS</para>
    ///   <para>"adverb formed in replacement of a preposition and a pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pronominal adverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronominalAdverb">http://www.lexinfo.net/ontology/2.0/lexinfo#pronominalAdverb</seealso>
    let pronominalAdverb = Prefixed_Name(lexinfo, "pronominalAdverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:pronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Word used in place of a noun or a noun phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#pronoun</seealso>
    let pronoun = Prefixed_Name(lexinfo, "pronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:pronunciation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The representation of the manner by which a term or word is articulated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pronunciation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronunciation">http://www.lexinfo.net/ontology/2.0/lexinfo#pronunciation</seealso>
    let pronunciation = Prefixed_Name(lexinfo, "pronunciation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:properNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A noun or adjective denoting a single object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Noun that is the name of a specific individual, place, or object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"properNoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"proper noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#properNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#properNoun</seealso>
    let properNoun = Prefixed_Name(lexinfo, "properNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:proverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A brief popular axiom or saying."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"пословица"</para><para>"proverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#proverb">http://www.lexinfo.net/ontology/2.0/lexinfo#proverb</seealso>
    let proverb = Prefixed_Name(lexinfo, "proverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:punctuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"punctuation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#punctuation">http://www.lexinfo.net/ontology/2.0/lexinfo#punctuation</seealso>
    let punctuation = Prefixed_Name(lexinfo, "punctuation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:quadrial</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Property related to four elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quadrial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#quadrial">http://www.lexinfo.net/ontology/2.0/lexinfo#quadrial</seealso>
    let quadrial = Prefixed_Name(lexinfo, "quadrial") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:qualifierAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:AdjectivePOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Adjective used to qualify."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifier adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#qualifierAdjective">http://www.lexinfo.net/ontology/2.0/lexinfo#qualifierAdjective</seealso>
    let qualifierAdjective =
        Prefixed_Name(lexinfo, "qualifierAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:quasiEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#quasiEquivalent">http://www.lexinfo.net/ontology/2.0/lexinfo#quasiEquivalent</seealso>
    let quasiEquivalent = Prefixed_Name(lexinfo, "quasiEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:questionMark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Sign used to express a question."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"question mark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#questionMark">http://www.lexinfo.net/ontology/2.0/lexinfo#questionMark</seealso>
    let questionMark = Prefixed_Name(lexinfo, "questionMark") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:radical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"radical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#radical">http://www.lexinfo.net/ontology/2.0/lexinfo#radical</seealso>
    let radical = Prefixed_Name(lexinfo, "radical") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:rarelyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Frequency</para>
    ///   <para>"Said of a term that is almost never used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rarely used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"редкоиспользуемый"</para><para>"rarelyUsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#rarelyUsed">http://www.lexinfo.net/ontology/2.0/lexinfo#rarelyUsed</seealso>
    let rarelyUsed = Prefixed_Name(lexinfo, "rarelyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:reciprocalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"Pronoun expressing mutual relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reciprocal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#reciprocalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#reciprocalPronoun</seealso>
    let reciprocalPronoun = Prefixed_Name(lexinfo, "reciprocalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:referentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type of concrete object or concept (the referent) that an expression represents (the reference)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referent type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#referentType">http://www.lexinfo.net/ontology/2.0/lexinfo#referentType</seealso>
    let referentType = Prefixed_Name(lexinfo, "referentType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:reflexiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>"Determiner that refers to the same entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reflexive adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexiveDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#reflexiveDeterminer</seealso>
    let reflexiveDeterminer =
        Prefixed_Name(lexinfo, "reflexiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:reflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"personal pronoun which is reflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reflexive personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePersonalPronoun</seealso>
    let reflexivePersonalPronoun =
        Prefixed_Name(lexinfo, "reflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:reflexivePossessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A possessive pronoun that refers to the subject as the possessor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reflexive possessive pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePossessivePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePossessivePronoun</seealso>
    let reflexivePossessivePronoun =
        Prefixed_Name(lexinfo, "reflexivePossessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:register</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#register">http://www.lexinfo.net/ontology/2.0/lexinfo#register</seealso>
    let register = Prefixed_Name(lexinfo, "register") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:regulatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term defined by law or government regulation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"regulated term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"урегулированный термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#regulatedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#regulatedTerm</seealso>
    let regulatedTerm = Prefixed_Name(lexinfo, "regulatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:relatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A term connected to another term by a coordinate or associative relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relatedTerm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#relatedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#relatedTerm</seealso>
    let relatedTerm = Prefixed_Name(lexinfo, "relatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:relationNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NounPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"relation noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relation noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#relationNoun">http://www.lexinfo.net/ontology/2.0/lexinfo#relationNoun</seealso>
    let relationNoun = Prefixed_Name(lexinfo, "relationNoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:relativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:DeterminerPOS</para>
    ///   <para>"Determiner related to a referent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relative determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativeDeterminer">http://www.lexinfo.net/ontology/2.0/lexinfo#relativeDeterminer</seealso>
    let relativeDeterminer =
        Prefixed_Name(lexinfo, "relativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:relativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>"relative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#relativeParticle</seealso>
    let relativeParticle = Prefixed_Name(lexinfo, "relativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:relativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>"Pronoun which introduces a relative clause and refers to something that has been said before."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relative pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativePronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#relativePronoun</seealso>
    let relativePronoun = Prefixed_Name(lexinfo, "relativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:romanization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Transcription or transliteration from non-Latin script into Latin script."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"romanization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#romanization">http://www.lexinfo.net/ontology/2.0/lexinfo#romanization</seealso>
    let romanization = Prefixed_Name(lexinfo, "romanization") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:root</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"base of a word"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"root"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#root">http://www.lexinfo.net/ontology/2.0/lexinfo#root</seealso>
    let root = Prefixed_Name(lexinfo, "root") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:secondPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Person</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Second person deixis is deictic reference to a person or persons identified as addressee."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"second person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"второе лицо"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#secondPerson">http://www.lexinfo.net/ontology/2.0/lexinfo#secondPerson</seealso>
    let secondPerson = Prefixed_Name(lexinfo, "secondPerson") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:secondPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#secondPersonForm">http://www.lexinfo.net/ontology/2.0/lexinfo#secondPersonForm</seealso>
    let secondPersonForm = Prefixed_Name(lexinfo, "secondPersonForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:segmentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specification of the pointers in time or sequence that indicates the segmentation process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"segmentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#segmentation">http://www.lexinfo.net/ontology/2.0/lexinfo#segmentation</seealso>
    let segmentation = Prefixed_Name(lexinfo, "segmentation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:semiColon</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sign (;) usually used to separate phrases."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"semi-colon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#semiColon">http://www.lexinfo.net/ontology/2.0/lexinfo#semiColon</seealso>
    let semiColon = Prefixed_Name(lexinfo, "semiColon") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:senseExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Descriptive material that provides a sample of an object or entity defined in the entry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sense example"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#senseExample">http://www.lexinfo.net/ontology/2.0/lexinfo#senseExample</seealso>
    let senseExample = Prefixed_Name(lexinfo, "senseExample") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:sententialClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#sententialClause">http://www.lexinfo.net/ontology/2.0/lexinfo#sententialClause</seealso>
    let sententialClause = Prefixed_Name(lexinfo, "sententialClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:setPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A fixed, lexicalized phrase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"устойчивое словосочетание"</para><para>"set phrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#setPhrase">http://www.lexinfo.net/ontology/2.0/lexinfo#setPhrase</seealso>
    let setPhrase = Prefixed_Name(lexinfo, "setPhrase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:shortArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Definiteness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"For definiteness, when a specific form is not the syntactic subject of the clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"short article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortArticle">http://www.lexinfo.net/ontology/2.0/lexinfo#shortArticle</seealso>
    let shortArticle = Prefixed_Name(lexinfo, "shortArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:shortForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A variant of a multiword term or lexeme that includes fewer words than the full form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"сокращенная форма"</para><para>"short form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortForm">http://www.lexinfo.net/ontology/2.0/lexinfo#shortForm</seealso>
    let shortForm = Prefixed_Name(lexinfo, "shortForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:shortFormFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A linking element used to identify a relation between a short form and its full or expanded form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"short form for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortFormFor">http://www.lexinfo.net/ontology/2.0/lexinfo#shortFormFor</seealso>
    let shortFormFor = Prefixed_Name(lexinfo, "shortFormFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:singular</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Value that expresses one element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The form of a term or word (usually of a noun) used to designate one object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"singular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"единственное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#singular">http://www.lexinfo.net/ontology/2.0/lexinfo#singular</seealso>
    let singular = Prefixed_Name(lexinfo, "singular") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:singularNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#singularNumberForm">http://www.lexinfo.net/ontology/2.0/lexinfo#singularNumberForm</seealso>
    let singularNumberForm =
        Prefixed_Name(lexinfo, "singularNumberForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:sku</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"артикул"</para><para>"sku"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"единица складского учета"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#sku">http://www.lexinfo.net/ontology/2.0/lexinfo#sku</seealso>
    let sku = Prefixed_Name(lexinfo, "sku") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:slangRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"slang register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#slangRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#slangRegister</seealso>
    let slangRegister = Prefixed_Name(lexinfo, "slangRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:slash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>"The punctuation sign /"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"slash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#slash">http://www.lexinfo.net/ontology/2.0/lexinfo#slash</seealso>
    let slash = Prefixed_Name(lexinfo, "slash") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:sociativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sociative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#sociativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#sociativeCase</seealso>
    let sociativeCase = Prefixed_Name(lexinfo, "sociativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:standardText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>"A fixed chunk of recurring text."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"standard text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"стандартное выражение"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#standardText">http://www.lexinfo.net/ontology/2.0/lexinfo#standardText</seealso>
    let standardText = Prefixed_Name(lexinfo, "standardText") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:standardizedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A term that has been standardized by a standardizing body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"standardized term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"стандартный термин"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#standardizedTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#standardizedTerm</seealso>
    let standardizedTerm = Prefixed_Name(lexinfo, "standardizedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A chunk of text used in a software interface, documentation, help file, or the like."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"строка"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#string">http://www.lexinfo.net/ontology/2.0/lexinfo#string</seealso>
    let string = Prefixed_Name(lexinfo, "string") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:stringCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A type value assigned to a string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"stringCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#stringCategory">http://www.lexinfo.net/ontology/2.0/lexinfo#stringCategory</seealso>
    let stringCategory = Prefixed_Name(lexinfo, "stringCategory") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:strongPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"strong personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#strongPersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#strongPersonalPronoun</seealso>
    let strongPersonalPronoun =
        Prefixed_Name(lexinfo, "strongPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#subject">http://www.lexinfo.net/ontology/2.0/lexinfo#subject</seealso>
    let subject = Prefixed_Name(lexinfo, "subject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:subjunctive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Mood</para>
    ///   <para>lexinfo:VerbFormMood</para>
    ///   <para>"Mood often used to express uncertainty, whishes or desires."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subjunctive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"сослагательное"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctive">http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctive</seealso>
    let subjunctive = Prefixed_Name(lexinfo, "subjunctive") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:subjunctiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveClause">http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveClause</seealso>
    let subjunctiveClause = Prefixed_Name(lexinfo, "subjunctiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:subjunctiveMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveMoodForm">http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveMoodForm</seealso>
    let subjunctiveMoodForm =
        Prefixed_Name(lexinfo, "subjunctiveMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:sublativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case for a move of something to the surface of another object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"сублатив"</para><para>"sublative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#sublativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#sublativeCase</seealso>
    let sublativeCase = Prefixed_Name(lexinfo, "sublativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:subordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:ConjunctionPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subordinating conjunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#subordinatingConjunction">http://www.lexinfo.net/ontology/2.0/lexinfo#subordinatingConjunction</seealso>
    let subordinatingConjunction =
        Prefixed_Name(lexinfo, "subordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:substanceHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates what this is composed of"</para>
    /// labels<para>"substance holonym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceHolonym">http://www.lexinfo.net/ontology/2.0/lexinfo#substanceHolonym</seealso>
    let substanceHolonym = Prefixed_Name(lexinfo, "substanceHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:substanceMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates this is a substance that composes the other"</para>
    /// labels<para>"substance meronym"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceMeronym">http://www.lexinfo.net/ontology/2.0/lexinfo#substanceMeronym</seealso>
    let substanceMeronym = Prefixed_Name(lexinfo, "substanceMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"окончание"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#suffix">http://www.lexinfo.net/ontology/2.0/lexinfo#suffix</seealso>
    let suffix = Prefixed_Name(lexinfo, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:superessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case indicating location on top of something or on the surface of something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"суперессив"</para><para>"superessive case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#superessiveCase">http://www.lexinfo.net/ontology/2.0/lexinfo#superessiveCase</seealso>
    let superessiveCase = Prefixed_Name(lexinfo, "superessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:superlative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Degree</para>
    ///   <para>"Value used in a comparison between more than two entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"превосходная"</para><para>"superlative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlative">http://www.lexinfo.net/ontology/2.0/lexinfo#superlative</seealso>
    let superlative = Prefixed_Name(lexinfo, "superlative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:superlativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeAdjunct">http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeAdjunct</seealso>
    let superlativeAdjunct =
        Prefixed_Name(lexinfo, "superlativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:superlativeDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeDegreeForm">http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeDegreeForm</seealso>
    let superlativeDegreeForm =
        Prefixed_Name(lexinfo, "superlativeDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:superlativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"superlative particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeParticle</seealso>
    let superlativeParticle =
        Prefixed_Name(lexinfo, "superlativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:supersededTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A term that is no longer preferred or admitted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"вытесненный термин"</para><para>"superseded term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#supersededTerm">http://www.lexinfo.net/ontology/2.0/lexinfo#supersededTerm</seealso>
    let supersededTerm = Prefixed_Name(lexinfo, "supersededTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:suspensionPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:SymbolPOS</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sequence of three dots having the same meaning as &amp;quot;et cetera&amp;quot; (full form) or &amp;quot;etc&amp;quot; (abbreviated form)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"suspension points"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#suspensionPoints">http://www.lexinfo.net/ontology/2.0/lexinfo#suspensionPoints</seealso>
    let suspensionPoints = Prefixed_Name(lexinfo, "suspensionPoints") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:syllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"слог"</para><para>"syllable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#syllable">http://www.lexinfo.net/ontology/2.0/lexinfo#syllable</seealso>
    let syllable = Prefixed_Name(lexinfo, "syllable") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"символ"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#symbol">http://www.lexinfo.net/ontology/2.0/lexinfo#symbol</seealso>
    let symbol = Prefixed_Name(lexinfo, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#synonym">http://www.lexinfo.net/ontology/2.0/lexinfo#synonym</seealso>
    let synonym = Prefixed_Name(lexinfo, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:tabooRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#tabooRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#tabooRegister</seealso>
    let tabooRegister = Prefixed_Name(lexinfo, "tabooRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:technicalRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The register appropriate to scientific texts or special languages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"technical register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#technicalRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#technicalRegister</seealso>
    let technicalRegister = Prefixed_Name(lexinfo, "technicalRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:temporalQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An attribution of a term or lexeme with respect to its use over time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"temporal qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#temporalQualifier">http://www.lexinfo.net/ontology/2.0/lexinfo#temporalQualifier</seealso>
    let temporalQualifier = Prefixed_Name(lexinfo, "temporalQualifier") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property referring to the way the grammar marks the time at which the action denoted by the verb took place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#tense">http://www.lexinfo.net/ontology/2.0/lexinfo#tense</seealso>
    let tense = Prefixed_Name(lexinfo, "tense") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:termElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any logically significant portion of a larger term or lexeme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lexTermElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#termElement">http://www.lexinfo.net/ontology/2.0/lexinfo#termElement</seealso>
    let termElement = Prefixed_Name(lexinfo, "termElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An attribute assigned to a lexeme or a term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lexTermType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#termType">http://www.lexinfo.net/ontology/2.0/lexinfo#termType</seealso>
    let termType = Prefixed_Name(lexinfo, "termType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:terminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Case that indicates to what or where something ends."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"терминативный падеж"</para><para>"terminative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#terminativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#terminativeCase</seealso>
    let terminativeCase = Prefixed_Name(lexinfo, "terminativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:thirdPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Person</para>
    ///   <para>"Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"third person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"третье лицо"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPerson">http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPerson</seealso>
    let thirdPerson = Prefixed_Name(lexinfo, "thirdPerson") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:thirdPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPersonForm">http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPersonForm</seealso>
    let thirdPersonForm = Prefixed_Name(lexinfo, "thirdPersonForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:transcribedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:TermType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"текстовая форма"</para><para>"transcribed form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#transcribedForm">http://www.lexinfo.net/ontology/2.0/lexinfo#transcribedForm</seealso>
    let transcribedForm = Prefixed_Name(lexinfo, "transcribedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#translation">http://www.lexinfo.net/ontology/2.0/lexinfo#translation</seealso>
    let translation = Prefixed_Name(lexinfo, "translation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:translationConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The confidence in a given translation."</para>
    /// labels<para>"Translation confidence"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#translationConfidence">http://www.lexinfo.net/ontology/2.0/lexinfo#translationConfidence</seealso>
    let translationConfidence =
        Prefixed_Name(lexinfo, "translationConfidence") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:translativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"translative case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"транслятивный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#translativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#translativeCase</seealso>
    let translativeCase = Prefixed_Name(lexinfo, "translativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:transliteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Form resulting from the conversion of one writing system into another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"transliteration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#transliteration">http://www.lexinfo.net/ontology/2.0/lexinfo#transliteration</seealso>
    let transliteration = Prefixed_Name(lexinfo, "transliteration") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:trial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"trial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#trial">http://www.lexinfo.net/ontology/2.0/lexinfo#trial</seealso>
    let trial = Prefixed_Name(lexinfo, "trial") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:unaccomplished</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"aspect that expresses an event or state that is not finished."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unaccomplished"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"незавершенный"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#unaccomplished">http://www.lexinfo.net/ontology/2.0/lexinfo#unaccomplished</seealso>
    let unaccomplished = Prefixed_Name(lexinfo, "unaccomplished") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:unclassifiedParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:ParticlePOS</para>
    ///   <para>"Particle that is not covered by other sorts of particle definitions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unclassified particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#unclassifiedParticle">http://www.lexinfo.net/ontology/2.0/lexinfo#unclassifiedParticle</seealso>
    let unclassifiedParticle =
        Prefixed_Name(lexinfo, "unclassifiedParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:usageNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A note containing information on the usage of the associated word or term."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usage note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#usageNote">http://www.lexinfo.net/ontology/2.0/lexinfo#usageNote</seealso>
    let usageNote = Prefixed_Name(lexinfo, "usageNote") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:VerbPOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"глагол"</para><para>"verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#verb">http://www.lexinfo.net/ontology/2.0/lexinfo#verb</seealso>
    let verb = Prefixed_Name(lexinfo, "verb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:verbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"verb form mood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#verbFormMood">http://www.lexinfo.net/ontology/2.0/lexinfo#verbFormMood</seealso>
    let verbFormMood = Prefixed_Name(lexinfo, "verbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:vocativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfo:Case</para>
    ///   <para>"Case used to indicate direct address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vocative  case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"звательный падеж"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#vocativeCase">http://www.lexinfo.net/ontology/2.0/lexinfo#vocativeCase</seealso>
    let vocativeCase = Prefixed_Name(lexinfo, "vocativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#voice">http://www.lexinfo.net/ontology/2.0/lexinfo#voice</seealso>
    let voice = Prefixed_Name(lexinfo, "voice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:vulgarRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Register</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Register of a term or text type that can be characterized as profane or socially unacceptable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The register of a term or text type that can be characterized as profane or socially unacceptable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vulgar register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#vulgarRegister">http://www.lexinfo.net/ontology/2.0/lexinfo#vulgarRegister</seealso>
    let vulgarRegister = Prefixed_Name(lexinfo, "vulgarRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:weakPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:PartOfSpeech</para>
    ///   <para>lexinfo:PronounPOS</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"weak personal pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#weakPersonalPronoun">http://www.lexinfo.net/ontology/2.0/lexinfo#weakPersonalPronoun</seealso>
    let weakPersonalPronoun =
        Prefixed_Name(lexinfo, "weakPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfo:wordElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lexinfo:TermElement</para>
    ///   <para>"Any lexeme element in a compound lexical unit that is itself a word."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wordElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"часть слова"</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#wordElement">http://www.lexinfo.net/ontology/2.0/lexinfo#wordElement</seealso>
    let wordElement = Prefixed_Name(lexinfo, "wordElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfo:yes</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfo:Negative</para>
    ///   <para>lexinfo:Cliticness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Positive value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"да"</para><para>"yes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/2.0/lexinfo#yes">http://www.lexinfo.net/ontology/2.0/lexinfo#yes</seealso>
    let yes = Prefixed_Name(lexinfo, "yes") |> PrefixedName

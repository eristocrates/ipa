namespace http.www.kanzaki.com.ns.music.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kanzaki =
    let _namespace_iri = Namespace_Iri kanzaki |> NamespaceIRI
    /// <summary>
    ///   <para>kanzaki:A-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on A, whose key signature has 3 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#A-dur">http://www.kanzaki.com/ns/music#A-dur</seealso>
    let A_dur = Prefixed_Name(kanzaki, "A-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Alto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Alto singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Alto">http://www.kanzaki.com/ns/music#Alto</seealso>
    let Alto = Prefixed_Name(kanzaki, "Alto") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person or group (or any agent) who creates or performs art works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Artist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Artist">http://www.kanzaki.com/ns/music#Artist</seealso>
    let Artist = Prefixed_Name(kanzaki, "Artist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:As-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on A flat, whose key signature has 4 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"As dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#As-dur">http://www.kanzaki.com/ns/music#As-dur</seealso>
    let As_dur = Prefixed_Name(kanzaki, "As-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:B-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on B flat, whose key signature has 2 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#B-dur">http://www.kanzaki.com/ns/music#B-dur</seealso>
    let B_dur = Prefixed_Name(kanzaki, "B-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Ballet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical work for a dance form featuring a staged presentation of group or solo dancing. Note 'Ballet_Event' in this vocabulary describes the performance of a ballet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ballet (Work)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ballet">http://www.kanzaki.com/ns/music#Ballet</seealso>
    let Ballet = Prefixed_Name(kanzaki, "Ballet") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:BalletCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group that performs ballet works."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ballet Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#BalletCompany">http://www.kanzaki.com/ns/music#BalletCompany</seealso>
    let BalletCompany = Prefixed_Name(kanzaki, "BalletCompany") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Ballet_Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of ballet performance
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ballet Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ballet_Event">http://www.kanzaki.com/ns/music#Ballet_Event</seealso>
    let Ballet_Event = Prefixed_Name(kanzaki, "Ballet_Event") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Ballet_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    /// </remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ballet_Performance">http://www.kanzaki.com/ns/music#Ballet_Performance</seealso>
    let Ballet_Performance =
        Prefixed_Name(kanzaki, "Ballet_Performance") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Baritone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Baritone singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Baritone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Baritone">http://www.kanzaki.com/ns/music#Baritone</seealso>
    let Baritone = Prefixed_Name(kanzaki, "Baritone") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Bass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Bass singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Bass">http://www.kanzaki.com/ns/music#Bass</seealso>
    let Bass = Prefixed_Name(kanzaki, "Bass") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:BassClarinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A larger member of the clarinet family, usually in key B-flat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bass Clarinet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#BassClarinet">http://www.kanzaki.com/ns/music#BassClarinet</seealso>
    let BassClarinet = Prefixed_Name(kanzaki, "BassClarinet") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:BassClarinettist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Bass Clarinet player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bass_Clarinettist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#BassClarinettist">http://www.kanzaki.com/ns/music#BassClarinettist</seealso>
    let BassClarinettist = Prefixed_Name(kanzaki, "BassClarinettist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:BassetHorn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A larger member of the clarinet family, typically in lower F, and has darker and less brilliant timbre."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Basset Horn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#BassetHorn">http://www.kanzaki.com/ns/music#BassetHorn</seealso>
    let BassetHorn = Prefixed_Name(kanzaki, "BassetHorn") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Bassoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A low-pitched woodwind instrument with a double reed, having a long wooden body attached to a U-shaped lateral tube that leads to the mouthpiece. A Fagotto."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bassoon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Bassoon">http://www.kanzaki.com/ns/music#Bassoon</seealso>
    let Bassoon = Prefixed_Name(kanzaki, "Bassoon") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Bassoonist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Fagotto player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bassoonist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Bassoonist">http://www.kanzaki.com/ns/music#Bassoonist</seealso>
    let Bassoonist = Prefixed_Name(kanzaki, "Bassoonist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Brass_Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A wind musical instrument, that consists of a brass tube  blown by means of a cup-shaped or funnel-shaped mouthpiece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Brass Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Brass_Instrument">http://www.kanzaki.com/ns/music#Brass_Instrument</seealso>
    let Brass_Instrument = Prefixed_Name(kanzaki, "Brass_Instrument") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:C-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on C, whose key signature has no sharp or flat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#C-dur">http://www.kanzaki.com/ns/music#C-dur</seealso>
    let C_dur = Prefixed_Name(kanzaki, "C-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Cantata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vocal composition accompanied by instruments and generally containing more than one movement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cantata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Cantata">http://www.kanzaki.com/ns/music#Cantata</seealso>
    let Cantata = Prefixed_Name(kanzaki, "Cantata") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Celesta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument with a keyboard and metal plates struck by hammers that produce bell-like tones."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Celesta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Celesta">http://www.kanzaki.com/ns/music#Celesta</seealso>
    let Celesta = Prefixed_Name(kanzaki, "Celesta") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:CelestaPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Celesta player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CelestaPlayer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#CelestaPlayer">http://www.kanzaki.com/ns/music#CelestaPlayer</seealso>
    let CelestaPlayer = Prefixed_Name(kanzaki, "CelestaPlayer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Cellist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Cello player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cellist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Cellist">http://www.kanzaki.com/ns/music#Cellist</seealso>
    let Cellist = Prefixed_Name(kanzaki, "Cellist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Cello</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stringed instrument of the violin family, with bass to tenor tone. Usually played in sitting position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cello"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Cello">http://www.kanzaki.com/ns/music#Cello</seealso>
    let Cello = Prefixed_Name(kanzaki, "Cello") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Ces-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on C flat, whose key signature has 7 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ces dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ces-dur">http://www.kanzaki.com/ns/music#Ces-dur</seealso>
    let Ces_dur = Prefixed_Name(kanzaki, "Ces-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Chamber_Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A genre of music composed for performance by small ensemble"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chamber Music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Chamber_Music">http://www.kanzaki.com/ns/music#Chamber_Music</seealso>
    let Chamber_Music = Prefixed_Name(kanzaki, "Chamber_Music") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Choral_Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A genre of music composed for performance by a chorus or choir"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Choral Music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Choral_Music">http://www.kanzaki.com/ns/music#Choral_Music</seealso>
    let Choral_Music = Prefixed_Name(kanzaki, "Choral_Music") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Choreographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"someone who creates new dances, or directs an opera"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Choreographer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Choreographer">http://www.kanzaki.com/ns/music#Choreographer</seealso>
    let Choreographer = Prefixed_Name(kanzaki, "Choreographer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Chorus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group of singers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chorus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Chorus">http://www.kanzaki.com/ns/music#Chorus</seealso>
    let Chorus = Prefixed_Name(kanzaki, "Chorus") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Cis-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on C sharp, whose key signature has 7 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cis dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Cis-dur">http://www.kanzaki.com/ns/music#Cis-dur</seealso>
    let Cis_dur = Prefixed_Name(kanzaki, "Cis-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Clarinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A woodwind instrument having a straight cylindrical tube with a flaring bell and a single-reed mouthpiece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Clarinet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Clarinet">http://www.kanzaki.com/ns/music#Clarinet</seealso>
    let Clarinet = Prefixed_Name(kanzaki, "Clarinet") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Clarinettist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Clarinet player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Clarinettist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Clarinettist">http://www.kanzaki.com/ns/music#Clarinettist</seealso>
    let Clarinettist = Prefixed_Name(kanzaki, "Clarinettist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person (or any agent) who composed art works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Composer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Composer">http://www.kanzaki.com/ns/music#Composer</seealso>
    let Composer = Prefixed_Name(kanzaki, "Composer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Concert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of musical performance by players or singers not involving theatrical staging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Concert">http://www.kanzaki.com/ns/music#Concert</seealso>
    let Concert = Prefixed_Name(kanzaki, "Concert") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Concerto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A composition for orchestra and a soloist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concerto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Concerto">http://www.kanzaki.com/ns/music#Concerto</seealso>
    let Concerto = Prefixed_Name(kanzaki, "Concerto") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Conductor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Conductor">http://www.kanzaki.com/ns/music#Conductor</seealso>
    let Conductor = Prefixed_Name(kanzaki, "Conductor") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Contrabass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The largest member of string insrtument, usually with four or five strings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contrabass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Contrabass">http://www.kanzaki.com/ns/music#Contrabass</seealso>
    let Contrabass = Prefixed_Name(kanzaki, "Contrabass") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Contrabassist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Contrabass player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contrabassist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Contrabassist">http://www.kanzaki.com/ns/music#Contrabassist</seealso>
    let Contrabassist = Prefixed_Name(kanzaki, "Contrabassist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Contrafagotto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A larger mebmer of the basoon family, producing the lowest tone in the woodwind section."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contrafagotto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Contrafagotto">http://www.kanzaki.com/ns/music#Contrafagotto</seealso>
    let Contrafagotto = Prefixed_Name(kanzaki, "Contrafagotto") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:ContrafagottoPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Contrafagotto player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContrafagottoPlayer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#ContrafagottoPlayer">http://www.kanzaki.com/ns/music#ContrafagottoPlayer</seealso>
    let ContrafagottoPlayer =
        Prefixed_Name(kanzaki, "ContrafagottoPlayer") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Countertenor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Countertenor singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Countertenor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Countertenor">http://www.kanzaki.com/ns/music#Countertenor</seealso>
    let Countertenor = Prefixed_Name(kanzaki, "Countertenor") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:D-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on D, whose key signature has 2 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#D-dur">http://www.kanzaki.com/ns/music#D-dur</seealso>
    let D_dur = Prefixed_Name(kanzaki, "D-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Des-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on D flat, whose key signature has 5 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Des dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Des-dur">http://www.kanzaki.com/ns/music#Des-dur</seealso>
    let Des_dur = Prefixed_Name(kanzaki, "Des-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artist who directs a musical group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Director"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Director">http://www.kanzaki.com/ns/music#Director</seealso>
    let Director = Prefixed_Name(kanzaki, "Director") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:E-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on E, whose key signature has 4 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#E-dur">http://www.kanzaki.com/ns/music#E-dur</seealso>
    let E_dur = Prefixed_Name(kanzaki, "E-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:EnglishHorn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A double-reed woodwind instrument, larger member of the oboe family."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"English Horn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#EnglishHorn">http://www.kanzaki.com/ns/music#EnglishHorn</seealso>
    let EnglishHorn = Prefixed_Name(kanzaki, "EnglishHorn") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:EnglishHornPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An English Horn player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"English Horn player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#EnglishHornPlayer">http://www.kanzaki.com/ns/music#EnglishHornPlayer</seealso>
    let EnglishHornPlayer = Prefixed_Name(kanzaki, "EnglishHornPlayer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Ensemble</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group which perfroms in relatively small size, particularly chamber music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ensemble"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ensemble">http://www.kanzaki.com/ns/music#Ensemble</seealso>
    let Ensemble = Prefixed_Name(kanzaki, "Ensemble") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Es-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on E flat, whose key signature has 3 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Es dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Es-dur">http://www.kanzaki.com/ns/music#Es-dur</seealso>
    let Es_dur = Prefixed_Name(kanzaki, "Es-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:F-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on F, whose key signature has 1 flat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#F-dur">http://www.kanzaki.com/ns/music#F-dur</seealso>
    let F_dur = Prefixed_Name(kanzaki, "F-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Fis-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on F sharp, whose key signature has 6 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fis dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Fis-dur">http://www.kanzaki.com/ns/music#Fis-dur</seealso>
    let Fis_dur = Prefixed_Name(kanzaki, "Fis-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Flute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A high-pitched woodwind instrument; a slender tube closed at one end with finger holes on one end and an opening near the closed end across which the breath is blown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Flute">http://www.kanzaki.com/ns/music#Flute</seealso>
    let Flute = Prefixed_Name(kanzaki, "Flute") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Flutist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Flute player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flutist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Flutist">http://www.kanzaki.com/ns/music#Flutist</seealso>
    let Flutist = Prefixed_Name(kanzaki, "Flutist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:G-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on G, whose key signature has 1 sharp."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#G-dur">http://www.kanzaki.com/ns/music#G-dur</seealso>
    let G_dur = Prefixed_Name(kanzaki, "G-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Ges-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on G flat, whose key signature has 6 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ges dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Ges-dur">http://www.kanzaki.com/ns/music#Ges-dur</seealso>
    let Ges_dur = Prefixed_Name(kanzaki, "Ges-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Guitar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument having a large flat-backed sound box, a long fretted neck, and usually six strings, played by strumming or plucking."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Guitar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Guitar">http://www.kanzaki.com/ns/music#Guitar</seealso>
    let Guitar = Prefixed_Name(kanzaki, "Guitar") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Guitarist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Guitar player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Guitarist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Guitarist">http://www.kanzaki.com/ns/music#Guitarist</seealso>
    let Guitarist = Prefixed_Name(kanzaki, "Guitarist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:H-dur</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Major key based on B, whose key signature has 5 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H dur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#H-dur">http://www.kanzaki.com/ns/music#H-dur</seealso>
    let H_dur = Prefixed_Name(kanzaki, "H-dur") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Harp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instrument with usually 46 or 47 strings that are played by plucking with the fingers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Harp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Harp">http://www.kanzaki.com/ns/music#Harp</seealso>
    let Harp = Prefixed_Name(kanzaki, "Harp") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Harpist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Harp player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Harpist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Harpist">http://www.kanzaki.com/ns/music#Harpist</seealso>
    let Harpist = Prefixed_Name(kanzaki, "Harpist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Harpsichord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A keyboard instrument whose strings are plucked by means of quills or plectrums. Cembalo."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Harpsichord"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Harpsichord">http://www.kanzaki.com/ns/music#Harpsichord</seealso>
    let Harpsichord = Prefixed_Name(kanzaki, "Harpsichord") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Horn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brass instrument with a long narrow tube that is coiled in a circle before ending in a flaring bell, usually being equipped with valves. A French Horn."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Horn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Horn">http://www.kanzaki.com/ns/music#Horn</seealso>
    let Horn = Prefixed_Name(kanzaki, "Horn") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Hornist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Horn player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hornist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Hornist">http://www.kanzaki.com/ns/music#Hornist</seealso>
    let Hornist = Prefixed_Name(kanzaki, "Hornist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A key of a musical work (e.g. C-dur, b-moll)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Key">http://www.kanzaki.com/ns/music#Key</seealso>
    let Key = Prefixed_Name(kanzaki, "Key") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Keyboard_Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument that has a set of keys that consist of scale."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Keyboard Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Keyboard_Instrument">http://www.kanzaki.com/ns/music#Keyboard_Instrument</seealso>
    let Keyboard_Instrument =
        Prefixed_Name(kanzaki, "Keyboard_Instrument") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Mandolin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pear-shaped small stringed instrument descended from the lute, played with a pick."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mandolin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Mandolin">http://www.kanzaki.com/ns/music#Mandolin</seealso>
    let Mandolin = Prefixed_Name(kanzaki, "Mandolin") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:MezzoSoprano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Mezzo Soprano singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mezzo Soprano"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#MezzoSoprano">http://www.kanzaki.com/ns/music#MezzoSoprano</seealso>
    let MezzoSoprano = Prefixed_Name(kanzaki, "MezzoSoprano") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subsection of a musical work. Typically a movement of a symphony, but also a piece of suit, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Movement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Movement">http://www.kanzaki.com/ns/music#Movement</seealso>
    let Movement = Prefixed_Name(kanzaki, "Movement") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:MusicDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The person who leads a musical group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Music Director"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#MusicDirector">http://www.kanzaki.com/ns/music#MusicDirector</seealso>
    let MusicDirector = Prefixed_Name(kanzaki, "MusicDirector") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:MusicalGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group that performs art works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musical Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#MusicalGroup">http://www.kanzaki.com/ns/music#MusicalGroup</seealso>
    let MusicalGroup = Prefixed_Name(kanzaki, "MusicalGroup") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Musical_Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of musical performance by players or singers, including theatrical staging. Typically the event has date and location. Note this is different from Performance, which is a 'representation' of a musical work realized at a musical event or recording, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musical Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Musical_Event">http://www.kanzaki.com/ns/music#Musical_Event</seealso>
    let Musical_Event = Prefixed_Name(kanzaki, "Musical_Event") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Musical_Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instrument to play music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musical Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Musical_Instrument">http://www.kanzaki.com/ns/music#Musical_Instrument</seealso>
    let Musical_Instrument =
        Prefixed_Name(kanzaki, "Musical_Instrument") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Musical_Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Representation of a musical work, such as a score, sheet music, perfornamce, recoding, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musical Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Musical_Representation">http://www.kanzaki.com/ns/music#Musical_Representation</seealso>
    let Musical_Representation =
        Prefixed_Name(kanzaki, "Musical_Representation") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Musical_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical work in any form, e.g. a composition, its movement, phrase, theme etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musical Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Musical_Work">http://www.kanzaki.com/ns/music#Musical_Work</seealso>
    let Musical_Work = Prefixed_Name(kanzaki, "Musical_Work") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Musician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artist who performs, composes or conducts music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musician"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Musician">http://www.kanzaki.com/ns/music#Musician</seealso>
    let Musician = Prefixed_Name(kanzaki, "Musician") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Oboe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A woodwind instrument with a conical bore and a double-reed mouthpiece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oboe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Oboe">http://www.kanzaki.com/ns/music#Oboe</seealso>
    let Oboe = Prefixed_Name(kanzaki, "Oboe") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Oboist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Oboe player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oboist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Oboist">http://www.kanzaki.com/ns/music#Oboist</seealso>
    let Oboist = Prefixed_Name(kanzaki, "Oboist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Oeuvre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A (complete) musical work by a composer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oeuvre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Oeuvre">http://www.kanzaki.com/ns/music#Oeuvre</seealso>
    let Oeuvre = Prefixed_Name(kanzaki, "Oeuvre") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Opera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical work with drama, song, chorus and orchestral music. Note 'Opera_Event' in this vocabulary describes the performance of an opera."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opera (Work)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Opera">http://www.kanzaki.com/ns/music#Opera</seealso>
    let Opera = Prefixed_Name(kanzaki, "Opera") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:OperaCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group that performs opera works."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opera Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#OperaCompany">http://www.kanzaki.com/ns/music#OperaCompany</seealso>
    let OperaCompany = Prefixed_Name(kanzaki, "OperaCompany") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Opera_Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of opera performance (not an opera as a musical work, which is defined here as 'Opera')"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opera Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Opera_Event">http://www.kanzaki.com/ns/music#Opera_Event</seealso>
    let Opera_Event = Prefixed_Name(kanzaki, "Opera_Event") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Opera_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Opera_Performance">http://www.kanzaki.com/ns/music#Opera_Performance</seealso>
    let Opera_Performance = Prefixed_Name(kanzaki, "Opera_Performance") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Oratorio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large musical composition for orchestra, vocal soloists and chorus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oratorio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Oratorio">http://www.kanzaki.com/ns/music#Oratorio</seealso>
    let Oratorio = Prefixed_Name(kanzaki, "Oratorio") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Orchestra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group which perfroms large scale symphonic works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orchestra"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Orchestra">http://www.kanzaki.com/ns/music#Orchestra</seealso>
    let Orchestra = Prefixed_Name(kanzaki, "Orchestra") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Orchestral_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A composition for orchestra (and a soloist or soloists, optionally with chorus)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orchestral Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Orchestral_Work">http://www.kanzaki.com/ns/music#Orchestral_Work</seealso>
    let Orchestral_Work = Prefixed_Name(kanzaki, "Orchestral_Work") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Overture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An orchestral music composed for the opening of an opera or oratorio, often played as an independend work in concerts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Overture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Overture">http://www.kanzaki.com/ns/music#Overture</seealso>
    let Overture = Prefixed_Name(kanzaki, "Overture") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A music for a particular instrument or voice taken from a full score (Note: in this ontology, Part is not a division of an orchestra)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Part">http://www.kanzaki.com/ns/music#Part</seealso>
    let Part = Prefixed_Name(kanzaki, "Part") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Percussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument that produces sound by striking the body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Percussion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Percussion">http://www.kanzaki.com/ns/music#Percussion</seealso>
    let Percussion = Prefixed_Name(kanzaki, "Percussion") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Percussionist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Percussion player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Percussionist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Percussionist">http://www.kanzaki.com/ns/music#Percussionist</seealso>
    let Percussionist = Prefixed_Name(kanzaki, "Percussionist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Representation of a musical work in the form of performace, e.g. playing instruments, singing etc. Note a concert is a Musical_Event where a Performance is presented."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Peroformance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Performance">http://www.kanzaki.com/ns/music#Performance</seealso>
    let Performance = Prefixed_Name(kanzaki, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Pianist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Piano player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pianist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Pianist">http://www.kanzaki.com/ns/music#Pianist</seealso>
    let Pianist = Prefixed_Name(kanzaki, "Pianist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Piano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument with a manual keyboard actuating hammers that strike wire strings. A pianoforte."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pian"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Piano">http://www.kanzaki.com/ns/music#Piano</seealso>
    let Piano = Prefixed_Name(kanzaki, "Piano") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Piccolo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piccolo flute, smaller member of the flute family."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Piccolo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Piccolo">http://www.kanzaki.com/ns/music#Piccolo</seealso>
    let Piccolo = Prefixed_Name(kanzaki, "Piccolo") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:PiccoloPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Piccolo flute player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Piccolo player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#PiccoloPlayer">http://www.kanzaki.com/ns/music#PiccoloPlayer</seealso>
    let PiccoloPlayer = Prefixed_Name(kanzaki, "PiccoloPlayer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Player</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artist who performs a musical instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Player">http://www.kanzaki.com/ns/music#Player</seealso>
    let Player = Prefixed_Name(kanzaki, "Player") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Recital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of musical performance especially by soloists"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Recital">http://www.kanzaki.com/ns/music#Recital</seealso>
    let Recital = Prefixed_Name(kanzaki, "Recital") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Religious_Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A genre of music composed for performance as part of religious ceremonies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Religious Music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Religious_Music">http://www.kanzaki.com/ns/music#Religious_Music</seealso>
    let Religious_Music = Prefixed_Name(kanzaki, "Religious_Music") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Saxophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A woodwind instrument with a single-reed mouthpiece and a (usually curved) conical metal tube, including soprano, alto, tenor, and baritone sizes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Saxophone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Saxophone">http://www.kanzaki.com/ns/music#Saxophone</seealso>
    let Saxophone = Prefixed_Name(kanzaki, "Saxophone") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A full score or piano-vocal score of a work, either published or manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Score">http://www.kanzaki.com/ns/music#Score</seealso>
    let Score = Prefixed_Name(kanzaki, "Score") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artist who sings a song"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Singer">http://www.kanzaki.com/ns/music#Singer</seealso>
    let Singer = Prefixed_Name(kanzaki, "Singer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Sketch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sketch, or a brief prelimary composition of a work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sketch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Sketch">http://www.kanzaki.com/ns/music#Sketch</seealso>
    let Sketch = Prefixed_Name(kanzaki, "Sketch") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Soprano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Soprano singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soprano"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Soprano">http://www.kanzaki.com/ns/music#Soprano</seealso>
    let Soprano = Prefixed_Name(kanzaki, "Soprano") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:SopranoClarinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A smaller member of the clarinet family, commonly in key E-flat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soprano Clarinet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#SopranoClarinet">http://www.kanzaki.com/ns/music#SopranoClarinet</seealso>
    let SopranoClarinet = Prefixed_Name(kanzaki, "SopranoClarinet") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:StringQuartetEnsemble</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical group of four string players. Note 'String_Quartette' is SQ as musical work in this vocabulary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Qtring Quartet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#StringQuartetEnsemble">http://www.kanzaki.com/ns/music#StringQuartetEnsemble</seealso>
    let StringQuartetEnsemble =
        Prefixed_Name(kanzaki, "StringQuartetEnsemble") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:String_Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stringed musical instrument, in which sound is produced by plucking, striking, or bowing taut strings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"String Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#String_Instrument">http://www.kanzaki.com/ns/music#String_Instrument</seealso>
    let String_Instrument = Prefixed_Name(kanzaki, "String_Instrument") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:String_Quartet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A music composed for instrumental quartet with 2 violins and a viola and a cello. Note 'StringQuartetEnsemble' is SQ ensemble in this vocabulary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"String Quartet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#String_Quartet">http://www.kanzaki.com/ns/music#String_Quartet</seealso>
    let String_Quartet = Prefixed_Name(kanzaki, "String_Quartet") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:String_Quartette</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    /// </remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#String_Quartette">http://www.kanzaki.com/ns/music#String_Quartette</seealso>
    let String_Quartette = Prefixed_Name(kanzaki, "String_Quartette") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Suite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical composition of several movements only loosely connected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Suite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Suite">http://www.kanzaki.com/ns/music#Suite</seealso>
    let Suite = Prefixed_Name(kanzaki, "Suite") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Symphonic_Poem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An orchestral composition based on a thematic subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symphonic Poem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Symphonic_Poem">http://www.kanzaki.com/ns/music#Symphonic_Poem</seealso>
    let Symphonic_Poem = Prefixed_Name(kanzaki, "Symphonic_Poem") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Symphony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large and complex work for symphony orchestra"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symphony"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Symphony">http://www.kanzaki.com/ns/music#Symphony</seealso>
    let Symphony = Prefixed_Name(kanzaki, "Symphony") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Tenor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tenor singer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tenor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Tenor">http://www.kanzaki.com/ns/music#Tenor</seealso>
    let Tenor = Prefixed_Name(kanzaki, "Tenor") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Text of a musical work (e.g. lyric or verse)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Text">http://www.kanzaki.com/ns/music#Text</seealso>
    let Text = Prefixed_Name(kanzaki, "Text") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Timpani</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of large copper or brass hemispherical drums with a parchment head that can be tuned by adjusting the tension."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timpani"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Timpani">http://www.kanzaki.com/ns/music#Timpani</seealso>
    let Timpani = Prefixed_Name(kanzaki, "Timpani") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Timpanist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Timpani player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timpanist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Timpanist">http://www.kanzaki.com/ns/music#Timpanist</seealso>
    let Timpanist = Prefixed_Name(kanzaki, "Timpanist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Trombone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brass instrument consisting of a long cylindrical tube, and having a movable U-shaped slide for producing different pitches."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trombone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Trombone">http://www.kanzaki.com/ns/music#Trombone</seealso>
    let Trombone = Prefixed_Name(kanzaki, "Trombone") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Trombonist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Trombone player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trombonist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Trombonist">http://www.kanzaki.com/ns/music#Trombonist</seealso>
    let Trombonist = Prefixed_Name(kanzaki, "Trombonist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Trumpet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A A soprano brass instrument consisting of a long metal tube looped once and ending in a flared bell, usually being equipped with valves or pistons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trumpet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Trumpet">http://www.kanzaki.com/ns/music#Trumpet</seealso>
    let Trumpet = Prefixed_Name(kanzaki, "Trumpet") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Trumpeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Trumpet player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trumpeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Trumpeter">http://www.kanzaki.com/ns/music#Trumpeter</seealso>
    let Trumpeter = Prefixed_Name(kanzaki, "Trumpeter") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Tuba</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large, valved, brass instrument with a bass pitch."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tuba"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Tuba">http://www.kanzaki.com/ns/music#Tuba</seealso>
    let Tuba = Prefixed_Name(kanzaki, "Tuba") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:TubaPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tuba player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TubaPlayer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#TubaPlayer">http://www.kanzaki.com/ns/music#TubaPlayer</seealso>
    let TubaPlayer = Prefixed_Name(kanzaki, "TubaPlayer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A venue for musical performance, e.g. concert hall, opera house, recital hall, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Venue">http://www.kanzaki.com/ns/music#Venue</seealso>
    let Venue = Prefixed_Name(kanzaki, "Venue") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Viola</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stringed instrument of the violin family, slightly larger than a violin, tuned a fifth lower, and having a deeper, more sonorous tone."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Viola"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Viola">http://www.kanzaki.com/ns/music#Viola</seealso>
    let Viola = Prefixed_Name(kanzaki, "Viola") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Violin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical instrument played with a bow, having four strings. Usually plays the highest part of the string section."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Violin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Violin">http://www.kanzaki.com/ns/music#Violin</seealso>
    let Violin = Prefixed_Name(kanzaki, "Violin") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Violinist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Violn player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Violinist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Violinist">http://www.kanzaki.com/ns/music#Violinist</seealso>
    let Violinist = Prefixed_Name(kanzaki, "Violinist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:Violist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Viola player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Violist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Violist">http://www.kanzaki.com/ns/music#Violist</seealso>
    let Violist = Prefixed_Name(kanzaki, "Violist") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Woodwind_Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A wind musical instrument, in which sound is produced by the vibration of reeds in the mouthpiece, or by the passing of air across the mouthpiece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Woodwind Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Woodwind_Instrument">http://www.kanzaki.com/ns/music#Woodwind_Instrument</seealso>
    let Woodwind_Instrument =
        Prefixed_Name(kanzaki, "Woodwind_Instrument") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:Written_Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Representation of a musical work in the form of a written expression, e.g. score, parts, autograph, printed music, sketch, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Written Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#Written_Representation">http://www.kanzaki.com/ns/music#Written_Representation</seealso>
    let Written_Representation =
        Prefixed_Name(kanzaki, "Written_Representation") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:a-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#a-moll">http://www.kanzaki.com/ns/music#a-moll</seealso>
    let a_moll = Prefixed_Name(kanzaki, "a-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:ais-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on A sharp, whose key signature has 7 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ais moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#ais-moll">http://www.kanzaki.com/ns/music#ais-moll</seealso>
    let ais_moll = Prefixed_Name(kanzaki, "ais-moll") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:artist_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the subject artist or agent. Super-property of #plays, #performs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Artist Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#artist_description">http://www.kanzaki.com/ns/music#artist_description</seealso>
    let artist_description =
        Prefixed_Name(kanzaki, "artist_description") |> PrefixedName

    /// <summary>
    ///   <para>kanzaki:as-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on A flat, whose key signature has 7 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"as moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#as-moll">http://www.kanzaki.com/ns/music#as-moll</seealso>
    let as_moll = Prefixed_Name(kanzaki, "as-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:b-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on B flat, whose key signature has 5 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"b moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#b-moll">http://www.kanzaki.com/ns/music#b-moll</seealso>
    let b_moll = Prefixed_Name(kanzaki, "b-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:c-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on C, whose key signature has 3 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"c moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#c-moll">http://www.kanzaki.com/ns/music#c-moll</seealso>
    let c_moll = Prefixed_Name(kanzaki, "c-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:cis-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on C sharp, whose key signature has 4 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cis moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#cis-moll">http://www.kanzaki.com/ns/music#cis-moll</seealso>
    let cis_moll = Prefixed_Name(kanzaki, "cis-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical work is composed by a person, a group, a software program etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Composer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#composer">http://www.kanzaki.com/ns/music#composer</seealso>
    let composer = Prefixed_Name(kanzaki, "composer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the composition process of the subject. Composition period or completion date, place, revision etc. can be described as properties of the object composition process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#composition">http://www.kanzaki.com/ns/music#composition</seealso>
    let composition = Prefixed_Name(kanzaki, "composition") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject performance is coducted by the object (or the subject musical event has a conductor). See comment of #performer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#conductor">http://www.kanzaki.com/ns/music#conductor</seealso>
    let conductor = Prefixed_Name(kanzaki, "conductor") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:conductorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical event has a conductor. Literal version of #conductor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductor Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#conductorName">http://www.kanzaki.com/ns/music#conductorName</seealso>
    let conductorName = Prefixed_Name(kanzaki, "conductorName") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:d-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on D, whose key signature has 1 flat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"d moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#d-moll">http://www.kanzaki.com/ns/music#d-moll</seealso>
    let d_moll = Prefixed_Name(kanzaki, "d-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>ex:Example</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject is (was) derived from the object, e.g a copy score is derived from the composer manuscript (or, possibly, a CD recording is derived from a performance at a concert)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Derived From"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#derivedFrom">http://www.kanzaki.com/ns/music#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(kanzaki, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the subject musical work. Super-property of some properties in this vocabulary, as well as description of a general descriptive resource such as time-line of composing process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#description">http://www.kanzaki.com/ns/music#description</seealso>
    let description = Prefixed_Name(kanzaki, "description") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:dis-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on D sharp, whose key signature has 6 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dis moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#dis-moll">http://www.kanzaki.com/ns/music#dis-moll</seealso>
    let dis_moll = Prefixed_Name(kanzaki, "dis-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:e-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on E, whose key signature has 1 sharp."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"e moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#e-moll">http://www.kanzaki.com/ns/music#e-moll</seealso>
    let e_moll = Prefixed_Name(kanzaki, "e-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:es-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on E flat, whose key signature has 6 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"es moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#es-moll">http://www.kanzaki.com/ns/music#es-moll</seealso>
    let es_moll = Prefixed_Name(kanzaki, "es-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:event_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the subject musical event. Super-property of #program, #presents, #venue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#event_description">http://www.kanzaki.com/ns/music#event_description</seealso>
    let event_description = Prefixed_Name(kanzaki, "event_description") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:f-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on F, whose key signature has 4 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"f moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#f-moll">http://www.kanzaki.com/ns/music#f-moll</seealso>
    let f_moll = Prefixed_Name(kanzaki, "f-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:fis-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on F sharp, whose key signature has 3 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fis moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#fis-moll">http://www.kanzaki.com/ns/music#fis-moll</seealso>
    let fis_moll = Prefixed_Name(kanzaki, "fis-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical work or its movement has a form, such as sonata, minuet, etc. Would be better defined as ObjectProperty."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#form">http://www.kanzaki.com/ns/music#form</seealso>
    let form = Prefixed_Name(kanzaki, "form") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:g-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on G, whose key signature has 2 flats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"g moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#g-moll">http://www.kanzaki.com/ns/music#g-moll</seealso>
    let g_moll = Prefixed_Name(kanzaki, "g-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:gis-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on G sharp, whose key signature has 5 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gis moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#gis-moll">http://www.kanzaki.com/ns/music#gis-moll</seealso>
    let gis_moll = Prefixed_Name(kanzaki, "gis-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:h-moll</para>
    /// </summary>
    /// <remarks>
    ///   <para>kanzaki:Key</para>
    ///   <para>"Minor key based on B, whose key signature has 2 sharps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"h moll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#h-moll">http://www.kanzaki.com/ns/music#h-moll</seealso>
    let h_moll = Prefixed_Name(kanzaki, "h-moll") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical work or its movement has a key, such as C major, d minor, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#key">http://www.kanzaki.com/ns/music#key</seealso>
    let key = Prefixed_Name(kanzaki, "key") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:keyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical work or its movement has a key. Textual version of #key."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Key Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#keyName">http://www.kanzaki.com/ns/music#keyName</seealso>
    let keyName = Prefixed_Name(kanzaki, "keyName") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:marks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical work or its movement has instruction mark(s) of tempo and/or expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Marks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#marks">http://www.kanzaki.com/ns/music#marks</seealso>
    let marks = Prefixed_Name(kanzaki, "marks") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical work or its movement has a time measure such as 3/4, 4/4, 6/8 etc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#meter">http://www.kanzaki.com/ns/music#meter</seealso>
    let meter = Prefixed_Name(kanzaki, "meter") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:opus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical composition has an identifier assigned by a composer (e.g. 'op.131') or other editor (e.g. 'KV.551')"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#opus">http://www.kanzaki.com/ns/music#opus</seealso>
    let opus = Prefixed_Name(kanzaki, "opus") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ex:Example</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject has a performer (an artist, a group, a machine etc.). The preferred domain of this property is #Performance, so as to model that "a concert presents a performance (of a musical work) that is realized by this performer". However, in natural language, we often say that "a concert has performers who play these musical works", i.e. the domain of 'performer' is #Musical_Event in this case, and it would be more intuitive model. Hence, the domain is leave unrestricted here for a moment. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Performer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#performer">http://www.kanzaki.com/ns/music#performer</seealso>
    let performer = Prefixed_Name(kanzaki, "performer") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:performerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical event has a performer. Literal version of #performer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PerformerName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#performerName">http://www.kanzaki.com/ns/music#performerName</seealso>
    let performerName = Prefixed_Name(kanzaki, "performerName") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:performs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject artist (or group, machine, etc) performs a musical work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Performs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#performs">http://www.kanzaki.com/ns/music#performs</seealso>
    let performs = Prefixed_Name(kanzaki, "performs") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:plays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject artist (or group, machine, etc) plays an musical instrument. If :me :plays :Violin, then :me a :Violininst."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#plays">http://www.kanzaki.com/ns/music#plays</seealso>
    let plays = Prefixed_Name(kanzaki, "plays") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:premiere</para>
    /// </summary>
    /// <remarks>
    ///   <para>ex:Example</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical work was first performed at an concert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Premiere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#premiere">http://www.kanzaki.com/ns/music#premiere</seealso>
    let premiere = Prefixed_Name(kanzaki, "premiere") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:presents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical event presents a performance of a musical work. An experiment to have better model to describe musical work, its representation and an event to present the representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#presents">http://www.kanzaki.com/ns/music#presents</seealso>
    let presents = Prefixed_Name(kanzaki, "presents") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical event presents a musical work as its program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#program">http://www.kanzaki.com/ns/music#program</seealso>
    let program = Prefixed_Name(kanzaki, "program") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:programLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject musical event presents a musical work as its program. Literal version of #program."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Program Line"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#programLine">http://www.kanzaki.com/ns/music#programLine</seealso>
    let programLine = Prefixed_Name(kanzaki, "programLine") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ex:Example</para>
    ///   <para>"The subject musical work is published as a score or sheet music (still not sure what kind of class is appropriate as the range)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"published"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#published">http://www.kanzaki.com/ns/music#published</seealso>
    let published = Prefixed_Name(kanzaki, "published") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject (performance, score, etc) is a representation of the object musical work. An experiment to have better model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#represents">http://www.kanzaki.com/ns/music#represents</seealso>
    let represents = Prefixed_Name(kanzaki, "represents") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:sections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical work has subsections such as movements. Current model recommends RDF Collection as the object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sections"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#sections">http://www.kanzaki.com/ns/music#sections</seealso>
    let sections = Prefixed_Name(kanzaki, "sections") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:soloist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject performance is performed by this soloist (or the subject musical event has a soloist. See comment of #performer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soloist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#soloist">http://www.kanzaki.com/ns/music#soloist</seealso>
    let soloist = Prefixed_Name(kanzaki, "soloist") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical work has a historical source, such as sketch, autograph score or published score."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#source">http://www.kanzaki.com/ns/music#source</seealso>
    let source = Prefixed_Name(kanzaki, "source") |> PrefixedName
    /// <summary>
    ///   <para>kanzaki:venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject musical event is presented at the object venue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/music#venue">http://www.kanzaki.com/ns/music#venue</seealso>
    let venue = Prefixed_Name(kanzaki, "venue") |> PrefixedName

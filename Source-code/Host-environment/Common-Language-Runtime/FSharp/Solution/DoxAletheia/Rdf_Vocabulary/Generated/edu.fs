namespace https.schema.edu.ee.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module edu =
    let _namespace_iri = Namespace_Iri edu |> NamespaceIRI
    /// <summary>
    ///   <para>edu:0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Ontoloogia kirjeldab hariduse valdkonna peamised mõisted ja seosed nende vahel. Praeguses versioonis on rõhk pandud õppematerjali, õpiväljundite ja õppekavaga seotud detailidele.</para>
    /// </remarks>
    /// <seealso href="https://schema.edu.ee/0.1">https://schema.edu.ee/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(edu, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>edu:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://schema.edu.ee/">https://schema.edu.ee/</seealso>
    let _prefix_iri = Prefixed_Name(edu, "") |> PrefixedName
    /// <summary>
    ///   <para>edu:#Oppematerjal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://schema.edu.ee/#Oppematerjal">https://schema.edu.ee/#Oppematerjal</seealso>
    let ``_#Oppematerjal`` = Prefixed_Name(edu, "#Oppematerjal") |> PrefixedName
    /// <summary>
    ///   <para>edu:0.1/html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://schema.edu.ee/0.1/html">https://schema.edu.ee/0.1/html</seealso>
    let ``_0.1/html`` = Prefixed_Name(edu, "0.1/html") |> PrefixedName
    /// <summary>
    ///   <para>edu:seotudOpivaljund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljundit võidakse kasutada erinevates ainevaldkondades riikliku õppekava kontekstis. Õpiväljund ei pea olema seotud ainevaldkonnaga. Õppematerjal on seotud konkreetsete õpiväljundite saavutamisega. Minimaalselt on õppematerjaliga seotud üks õpiväljund.</para>
    /// labels<para>Teemaga või õppematerjaliga seotud õpiväljund</para></remarks>
    /// <seealso href="https://schema.edu.ee/seotudOpivaljund">https://schema.edu.ee/seotudOpivaljund</seealso>
    let seotudOpivaljund = Prefixed_Name(edu, "seotudOpivaljund") |> PrefixedName
    /// <summary>
    ///   <para>edu:seotudOppeaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljund ei pea olema seotud ühegi õppeainega ja võib olla seotud mitme õppeainega.</para>
    /// labels<para>Õppeaine, mille raames õpiväljundit või teemat käsitletekse</para></remarks>
    /// <seealso href="https://schema.edu.ee/seotudOppeaine">https://schema.edu.ee/seotudOppeaine</seealso>
    let seotudOppeaine = Prefixed_Name(edu, "seotudOppeaine") |> PrefixedName
    /// <summary>
    ///   <para>edu:ulesanneKoosneb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ülesanne koosneb vähemalt ühest üksikküsimusest.</para>
    /// labels<para>Ülesanne koosneb üksikküsimustest</para></remarks>
    /// <seealso href="https://schema.edu.ee/ulesanneKoosneb">https://schema.edu.ee/ulesanneKoosneb</seealso>
    let ulesanneKoosneb = Prefixed_Name(edu, "ulesanneKoosneb") |> PrefixedName
    /// <summary>
    ///   <para>edu:vanuseaste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Vanuse teatav alajaotus; selles vanuses inimesed.</para>
    /// labels<para>Vanuseaste</para></remarks>
    /// <seealso href="https://schema.edu.ee/vanuseaste">https://schema.edu.ee/vanuseaste</seealso>
    let vanuseaste = Prefixed_Name(edu, "vanuseaste") |> PrefixedName
    /// <summary>
    ///   <para>edu:0.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://schema.edu.ee/0.1/">https://schema.edu.ee/0.1/</seealso>
    let ``_0.1/`` = Prefixed_Name(edu, "0.1/") |> PrefixedName
    /// <summary>
    ///   <para>edu:Ainekava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dokument, mis hõlmab ühe aine õppe-eesmärgid, õppesisu, metoodika ja hindamise põhimõtted.</para>
    /// labels<para>Ainekava</para></remarks>
    /// <seealso href="https://schema.edu.ee/Ainekava">https://schema.edu.ee/Ainekava</seealso>
    let Ainekava = Prefixed_Name(edu, "Ainekava") |> PrefixedName
    /// <summary>
    ///   <para>edu:Ainevaldkond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lähedase eesmärgiseade ja õppesisuga õppeained moodustavad ainevaldkonna. Ainevaldkonnad on järgmised:
    ///   1) keel ja kirjandus;
    ///   2) võõrkeeled;
    ///   3) matemaatika;
    ///   4) loodusained;
    ///   5) sotsiaalained;
    ///   6) kunstiained;
    ///   7) kehaline kasvatus.
    ///
    /// Ainevaldkonna õppeainete õpetamise peamine eesmärk on vastava valdkonnapädevuse kujundamine. Valdkonnapädevuste kujunemist ning gümnaasiumi õppe- ja kasvatuseesmärkide saavutamist toetavad ainekavades esitatud õpitulemused, lõiming teiste ainevaldkondade õppeainetega ning tunni- ja kooliväline tegevus. NB alignmentType = educationalSubjectArea.</para>
    /// labels<para>Ainevaldkond</para><para>Subject area</para></remarks>
    /// <seealso href="https://schema.edu.ee/Ainevaldkond">https://schema.edu.ee/Ainevaldkond</seealso>
    let Ainevaldkond = Prefixed_Name(edu, "Ainevaldkond") |> PrefixedName

    /// <summary>
    ///   <para>edu:AinevaldkonnaPadevus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ainevaldkonna pädevus</para></remarks>
    /// <seealso href="https://schema.edu.ee/AinevaldkonnaPadevus">https://schema.edu.ee/AinevaldkonnaPadevus</seealso>
    let AinevaldkonnaPadevus =
        Prefixed_Name(edu, "AinevaldkonnaPadevus") |> PrefixedName

    /// <summary>
    ///   <para>edu:Padevus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Teadmiste, oskuste ja hoiakute kogum, mis tagab suutlikkuse teatud tegevusalal või -valdkonnas loovalt, ettevõtlikult ja paindlikult toimida.</para>
    /// labels<para>Competence</para><para>Pädevus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Padevus">https://schema.edu.ee/Padevus</seealso>
    let Padevus = Prefixed_Name(edu, "Padevus") |> PrefixedName
    /// <summary>
    ///   <para>edu:Haridusaste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hariduse omandamise järjestikune osa, selle iga (järgnev) osa (nt põhiharidus, keskharidus, kõrgharidus). NB alignmentType = educationalLevel.</para>
    /// labels<para>Haridusaste</para></remarks>
    /// <seealso href="https://schema.edu.ee/Haridusaste">https://schema.edu.ee/Haridusaste</seealso>
    let Haridusaste = Prefixed_Name(edu, "Haridusaste") |> PrefixedName
    /// <summary>
    ///   <para>edu:Opivaljund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppimise tulemusena omandatavad teadmised, oskused ja hoiakud või nende kogumid (pädevused), mille olemasolu ja/või saavutatuse taset on võimalik tõendada ja hinnata. Nt "oskab liita 10 piires". NB alignmentType = teaches.</para>
    /// labels<para>Learning outcome</para><para>Õpiväljund</para></remarks>
    /// <seealso href="https://schema.edu.ee/Opivaljund">https://schema.edu.ee/Opivaljund</seealso>
    let Opivaljund = Prefixed_Name(edu, "Opivaljund") |> PrefixedName
    /// <summary>
    ///   <para>edu:Kontrolltoo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppepäevas võib läbi viia ühe kontrolltöö. Kontrolltöö toimumise ajast teatatakse õpilastele vähemalt viis õppepäeva enne kontrolltöö toimumist. Õppenädalas võib läbi viia kuni kolm kontrolltööd. Kontrolltöid ei planeerita esmaspäevale ja reedele, samuti õppepäeva esimesele ning viimasele õppetunnile, v.a juhul, kui õppeaine on tunniplaanis esmaspäeval ja reedel või ainult ühel neist päevadest või esimese või viimase tunnina.</para>
    /// labels<para>Kontrolltöö</para></remarks>
    /// <seealso href="https://schema.edu.ee/Kontrolltoo">https://schema.edu.ee/Kontrolltoo</seealso>
    let Kontrolltoo = Prefixed_Name(edu, "Kontrolltoo") |> PrefixedName
    /// <summary>
    ///   <para>edu:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hindamisvahend kokkulepitud eesmärgi hindamiseks. Nt ülesannete kogum; standardiseeritud ülesannete või küsimuste kogum, millega uuritakse ja hinnatakse inimese võimeid ja omadusi või teadmisi ja oskusi.</para>
    /// labels<para>Test</para><para>Test</para></remarks>
    /// <seealso href="https://schema.edu.ee/Test">https://schema.edu.ee/Test</seealso>
    let Test = Prefixed_Name(edu, "Test") |> PrefixedName
    /// <summary>
    ///   <para>edu:Kusimus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Üksikküsimus testis.</para>
    /// labels<para>Küsimus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Kusimus">https://schema.edu.ee/Kusimus</seealso>
    let Kusimus = Prefixed_Name(edu, "Kusimus") |> PrefixedName
    /// <summary>
    ///   <para>edu:OpetajaTookava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Töökava on õpetajale igapäevane abivahend, mis võimaldab tal õppeprotsessi kavandada ja analüüsida ning iseennast hinnata. Töökava on dokument, mille alusel toimub õppetöö tundides.</para>
    /// labels<para>Õpetaja töökava</para></remarks>
    /// <seealso href="https://schema.edu.ee/OpetajaTookava">https://schema.edu.ee/OpetajaTookava</seealso>
    let OpetajaTookava = Prefixed_Name(edu, "OpetajaTookava") |> PrefixedName
    /// <summary>
    ///   <para>edu:Opitulemus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kellegi teadmistele, oskustele, võimetele, töötulemustele antud hinnang, mida väljendatakse numbrites, tähtedes, punktides vm hindamisühikutes. Lihtsustatult, õpitulemus esitab õpiväljundi saavutatuse taset. Eksami või arvestuse sooritus.</para>
    /// labels<para>Learning assessment</para><para>Õpitulemus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Opitulemus">https://schema.edu.ee/Opitulemus</seealso>
    let Opitulemus = Prefixed_Name(edu, "Opitulemus") |> PrefixedName
    /// <summary>
    ///   <para>edu:OppeasutuseOppekava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppeasutuse õppekava on õppe- ja kasvatustegevuse alusdokument, milles kirjeldatakse õppe rõhuasetused ja tegevused õppekava täitmiseks.</para>
    /// labels<para>Õppeasutuse õppekava</para></remarks>
    /// <seealso href="https://schema.edu.ee/OppeasutuseOppekava">https://schema.edu.ee/OppeasutuseOppekava</seealso>
    let OppeasutuseOppekava = Prefixed_Name(edu, "OppeasutuseOppekava") |> PrefixedName
    /// <summary>
    ///   <para>edu:Koolitus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kavandatud süsteemne õpe, mille käigus antakse edasi kindlaid oskusi, teadmisi ja infot ning kujundatakse hoiakuid ja suhtumisi.</para>
    /// labels<para>Koolitus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Koolitus">https://schema.edu.ee/Koolitus</seealso>
    let Koolitus = Prefixed_Name(edu, "Koolitus") |> PrefixedName
    /// <summary>
    ///   <para>edu:Opirada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppija poolt läbitud tee, mis sisaldab (e-)õppe tegevusi, mis võimaldavad teadmiste, oskuste ja pädevuste järjepidevat omandamist.</para>
    /// labels<para>Õpirada</para></remarks>
    /// <seealso href="https://schema.edu.ee/Opirada">https://schema.edu.ee/Opirada</seealso>
    let Opirada = Prefixed_Name(edu, "Opirada") |> PrefixedName
    /// <summary>
    ///   <para>edu:Oppeaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppeasutuses õpetatav teadus-, tehnika-, kunsti- vm ala.</para>
    /// labels<para>Õppeaine</para><para>Subject</para></remarks>
    /// <seealso href="https://schema.edu.ee/Oppeaine">https://schema.edu.ee/Oppeaine</seealso>
    let Oppeaine = Prefixed_Name(edu, "Oppeaine") |> PrefixedName
    /// <summary>
    ///   <para>edu:Oppematerjal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Nii digitaalsel kui muul kujul õppematerjal. Digitaalsel kujul avaldatud õppematerjal on nt: e-õpik, õpiotstarbeline veebivideo ja mobiilirakendus, õpimäng, e-tööleht, veebipõhine test, õpiobjekt.</para>
    /// labels<para>Learning material</para><para>Õppematerjal</para></remarks>
    /// <seealso href="https://schema.edu.ee/Oppematerjal">https://schema.edu.ee/Oppematerjal</seealso>
    let Oppematerjal = Prefixed_Name(edu, "Oppematerjal") |> PrefixedName
    /// <summary>
    ///   <para>edu:Oskus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Võime rakendada teadmisi ja kasutada neid ülesannete täitmisel ja probleemide lahendamisel.</para>
    /// labels<para>Skill</para><para>Oskus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Oskus">https://schema.edu.ee/Oskus</seealso>
    let Oskus = Prefixed_Name(edu, "Oskus") |> PrefixedName
    /// <summary>
    ///   <para>edu:Teadmine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õpingutega või kogemustest omandatud faktide, reeglite, seaduspärasuste jms tundmine.</para>
    /// labels<para>Knowledge</para><para>Teadmine</para></remarks>
    /// <seealso href="https://schema.edu.ee/Teadmine">https://schema.edu.ee/Teadmine</seealso>
    let Teadmine = Prefixed_Name(edu, "Teadmine") |> PrefixedName
    /// <summary>
    ///   <para>edu:Tunnikontroll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Väikesemahuline kirjalik töö tunnis õpitu kontrollimiseks ja hindamiseks.</para>
    /// labels<para>Tunnikontroll</para></remarks>
    /// <seealso href="https://schema.edu.ee/Tunnikontroll">https://schema.edu.ee/Tunnikontroll</seealso>
    let Tunnikontroll = Prefixed_Name(edu, "Tunnikontroll") |> PrefixedName
    /// <summary>
    ///   <para>edu:Vastus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Üksikküsimuse vastus testis.</para>
    /// labels<para>Vastus</para></remarks>
    /// <seealso href="https://schema.edu.ee/Vastus">https://schema.edu.ee/Vastus</seealso>
    let Vastus = Prefixed_Name(edu, "Vastus") |> PrefixedName
    /// <summary>
    ///   <para>edu:ainevaldkondKoosneb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ainevaldkond sisaldab vähemalt ühte, kuid enamasti rohkemat, õppeainet.</para>
    /// labels<para>Ainevaldkond sisaldab õppeainet</para><para>Includes subject</para></remarks>
    /// <seealso href="https://schema.edu.ee/ainevaldkondKoosneb">https://schema.edu.ee/ainevaldkondKoosneb</seealso>
    let ainevaldkondKoosneb = Prefixed_Name(edu, "ainevaldkondKoosneb") |> PrefixedName
    /// <summary>
    ///   <para>edu:RiiklikOppekava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hariduse eesmärkide elluviimise riiklik plaan, mis annab ülevaate sellest, milleks, mida, kuidas ja millise aja jooksul õpitakse ning õpetatakse.</para>
    /// labels<para>National curriculum</para><para>Riiklik õppekava</para></remarks>
    /// <seealso href="https://schema.edu.ee/RiiklikOppekava">https://schema.edu.ee/RiiklikOppekava</seealso>
    let RiiklikOppekava = Prefixed_Name(edu, "RiiklikOppekava") |> PrefixedName
    /// <summary>
    ///   <para>edu:Sihtgrupp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Elanikkonna rühm, mille vajadusi silmas pidades on õppematerjal loodud.</para>
    /// labels<para>Educational audience</para><para>Sihtgrupp</para></remarks>
    /// <seealso href="https://schema.edu.ee/Sihtgrupp">https://schema.edu.ee/Sihtgrupp</seealso>
    let Sihtgrupp = Prefixed_Name(edu, "Sihtgrupp") |> PrefixedName
    /// <summary>
    ///   <para>edu:Tasemetoo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kokkuvõttev test, kokkulepitud astme (kooliastme) lõpus saavutatud oskused ja teadmised; kooliastme lõpus teadmiste ja oskuste omandatust kontrolliv üleriigiline töö.</para>
    /// labels<para>Tasemetöö</para></remarks>
    /// <seealso href="https://schema.edu.ee/Tasemetoo">https://schema.edu.ee/Tasemetoo</seealso>
    let Tasemetoo = Prefixed_Name(edu, "Tasemetoo") |> PrefixedName
    /// <summary>
    ///   <para>edu:Teema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Aine sisuühik, mida õpetatakse a'la "2. maailmasõda ajaloos" või "Geomeetria". Teemad on kasutusel õppematerjalide lõimimiseks. NB alignmentType = educationalSubject.</para>
    /// labels<para>Topic</para><para>Teema</para></remarks>
    /// <seealso href="https://schema.edu.ee/Teema">https://schema.edu.ee/Teema</seealso>
    let Teema = Prefixed_Name(edu, "Teema") |> PrefixedName
    /// <summary>
    ///   <para>edu:Ulesanne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kohustusena antud töö; harjutustöö koolis. Ülesanne koosneb tööjuhendist, (üksik)küsimustest ja vastustest. Kasutusel ka hindamisvahendina.</para>
    /// labels<para>Ülesanne</para></remarks>
    /// <seealso href="https://schema.edu.ee/Ulesanne">https://schema.edu.ee/Ulesanne</seealso>
    let Ulesanne = Prefixed_Name(edu, "Ulesanne") |> PrefixedName
    /// <summary>
    ///   <para>edu:eeldab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljundi omandamiseks on vajalik teine õpiväljund, nt oskuse jaoks on vajalik teadmine.</para>
    /// labels<para>Õpiväljundi eeldus</para></remarks>
    /// <seealso href="https://schema.edu.ee/eeldab">https://schema.edu.ee/eeldab</seealso>
    let eeldab = Prefixed_Name(edu, "eeldab") |> PrefixedName
    /// <summary>
    ///   <para>edu:kooliaste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Hariduse omandamise järjestikune alajaotus, selle iga (järgnev) osa.
    ///
    /// Kooliastmed on:
    /// 1) I kooliaste – 1.–3. klass;
    /// 2) II kooliaste – 4.–6. klass;
    /// 3) III kooliaste – 7.–9. klass;
    /// 4) gümnaasium – 10.–12. klass.
    ///
    /// Põhikooli kooliastmed on:
    /// 1) I kooliaste – 1.–3. klass;
    /// 2) II kooliaste – 4.–6. klass;
    /// 3) III kooliaste – 7.–9. klass.</para>
    /// labels<para>Kooliaste</para></remarks>
    /// <seealso href="https://schema.edu.ee/kooliaste">https://schema.edu.ee/kooliaste</seealso>
    let kooliaste = Prefixed_Name(edu, "kooliaste") |> PrefixedName
    /// <summary>
    ///   <para>edu:opivaljundEeldab</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://schema.edu.ee/opivaljundEeldab">https://schema.edu.ee/opivaljundEeldab</seealso>
    let opivaljundEeldab = Prefixed_Name(edu, "opivaljundEeldab") |> PrefixedName
    /// <summary>
    ///   <para>edu:alateema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Teema alamosa, a'la "Tasandilised kujundid".</para>
    /// labels<para>Alateema</para></remarks>
    /// <seealso href="https://schema.edu.ee/alateema">https://schema.edu.ee/alateema</seealso>
    let alateema = Prefixed_Name(edu, "alateema") |> PrefixedName
    /// <summary>
    ///   <para>edu:hindabOpitulemust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ülesanne hindab mil määral on õpitulemus omandatud. Küsimus hindab kas konkreetse küsimusega seotud õpitulemus on saavutatud või mitte.</para>
    /// labels<para>Hindab õpitulemuse saavutatust</para></remarks>
    /// <seealso href="https://schema.edu.ee/hindabOpitulemust">https://schema.edu.ee/hindabOpitulemust</seealso>
    let hindabOpitulemust = Prefixed_Name(edu, "hindabOpitulemust") |> PrefixedName
    /// <summary>
    ///   <para>edu:onEelduseks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljund on eelduseks teis(t)ele õpiväljundi(te)le.</para>
    /// labels<para>Õpiväljund on eelduseks</para></remarks>
    /// <seealso href="https://schema.edu.ee/onEelduseks">https://schema.edu.ee/onEelduseks</seealso>
    let onEelduseks = Prefixed_Name(edu, "onEelduseks") |> PrefixedName
    /// <summary>
    ///   <para>edu:seotudAinevaldkond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljundit võidakse kasutada erinevates ainevaldkondades riikliku õppekava kontekstis. Õpiväljund ei pea olema seotud ainevaldkonnaga. Õppematerjal võib olla seotud ainevaldkondadega.</para>
    /// labels<para>Ainevaldkond, mille raames õpiväljundit või õppematerjali käsitletakse</para></remarks>
    /// <seealso href="https://schema.edu.ee/seotudAinevaldkond">https://schema.edu.ee/seotudAinevaldkond</seealso>
    let seotudAinevaldkond = Prefixed_Name(edu, "seotudAinevaldkond") |> PrefixedName
    /// <summary>
    ///   <para>edu:seotudHaridusaste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õppematerjal on mõeldud või õpiväljund on planeeritud konkreetsele haridusastmele.</para>
    /// labels<para>Õppematerjali või õpiväljundiga seotud haridusaste</para></remarks>
    /// <seealso href="https://schema.edu.ee/seotudHaridusaste">https://schema.edu.ee/seotudHaridusaste</seealso>
    let seotudHaridusaste = Prefixed_Name(edu, "seotudHaridusaste") |> PrefixedName
    /// <summary>
    ///   <para>edu:seotudTeema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Õpiväljund ei pea olema ühegi teemaga, kuid teema raames käsitletakse vähemalt ühte õpiväljundit. Õppematerjal võib olla seotud teemadega.</para>
    /// labels<para>Teema, mille raames õpiväljundit või teemat käsitletakse</para></remarks>
    /// <seealso href="https://schema.edu.ee/seotudTeema">https://schema.edu.ee/seotudTeema</seealso>
    let seotudTeema = Prefixed_Name(edu, "seotudTeema") |> PrefixedName
    /// <summary>
    ///   <para>edu:testKoosneb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Test koosneb vähemalt ühest ülesandest.</para>
    /// labels<para>Test koosneb ülesannetest</para></remarks>
    /// <seealso href="https://schema.edu.ee/testKoosneb">https://schema.edu.ee/testKoosneb</seealso>
    let testKoosneb = Prefixed_Name(edu, "testKoosneb") |> PrefixedName
    /// <summary>
    ///   <para>edu:#Opivaljund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://schema.edu.ee/#Opivaljund">https://schema.edu.ee/#Opivaljund</seealso>
    let ``_#Opivaljund`` = Prefixed_Name(edu, "#Opivaljund") |> PrefixedName
    /// <summary>
    ///   <para>edu:Oppekava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Õppe ja kasvatuse alusdokument, mis määrab õppe- ja kasvatuseesmärgid, õppe sisu ja mahu, metoodika põhimõtted ning hindamise alused, nõuded õppekeskkonnale vms.</para>
    /// labels<para>Curriculum</para><para>Õppekava</para></remarks>
    /// <seealso href="https://schema.edu.ee/Oppekava">https://schema.edu.ee/Oppekava</seealso>
    let Oppekava = Prefixed_Name(edu, "Oppekava") |> PrefixedName
    /// <summary>
    ///   <para>edu:Hoiak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inimese kalduvus hinnata objektide (näit. isikute, sündmuste, nähtuste) olemust teatud määral soosival või mittesoosival viisil. See hinnang väljendub tavaliselt tunnetusliku (kognitiivse), emotsionaalse (afektiivse) või käitumusliku (konatiivse) reageeringuna.</para>
    /// labels<para>Attitude</para><para>Hoiak</para></remarks>
    /// <seealso href="https://schema.edu.ee/Hoiak">https://schema.edu.ee/Hoiak</seealso>
    let Hoiak = Prefixed_Name(edu, "Hoiak") |> PrefixedName

    /// <summary>
    ///   <para>edu:IndividuaalneOppekava</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individuaalne õppekava on Individuaalse õppekava järgi õppimise korra kohaselt hariduslike erivajadustega õpilase jaoks koostatud õppekava, mis loob õpilasele tingimused võimetekohaseks õppimiseks ja arenemiseks. Individuaalne õppekava koostatakse õpilasele, kellel on raskusi oma klassikaaslastega samal ajal samas ruumis või vastavale klassile koostatud töökava alusel töötada. Hariduslikeks erivajadusteks võivad olla õpilase eriline andekus, õpi- ja käitumisraskused, terviserikked, puuded või pikemaaegne õpikeskkonnast eemal viibimine.</para>
    /// labels<para>Individuaalne õppekava</para></remarks>
    /// <seealso href="https://schema.edu.ee/IndividuaalneOppekava">https://schema.edu.ee/IndividuaalneOppekava</seealso>
    let IndividuaalneOppekava =
        Prefixed_Name(edu, "IndividuaalneOppekava") |> PrefixedName

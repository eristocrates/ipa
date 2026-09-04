#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module edu =
    let _prefixId = PrefixId.fromNamespaceLabel "https://schema.edu.ee/" "edu"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.1`` = _prefixId.prefix "0.1"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ainekava</para>
    ///   <para>rdfs:comment : Dokument, mis hõlmab ühe aine õppe-eesmärgid, õppesisu, metoodika ja hindamise põhimõtted.</para>
    ///   <a href="https://schema.edu.ee/Ainekava">edu:Ainekava</a>
    /// </summary>
    let Ainekava = _prefixId.prefix "Ainekava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ainevaldkondrdfs:label : Subject area</para>
    ///   <para>rdfs:comment : Lähedase eesmärgiseade ja õppesisuga õppeained moodustavad ainevaldkonna. Ainevaldkonnad on järgmised:
    ///   1) keel ja kirjandus;
    ///   2) võõrkeeled;
    ///   3) matemaatika;
    ///   4) loodusained;
    ///   5) sotsiaalained;
    ///   6) kunstiained;
    ///   7) kehaline kasvatus.
    ///
    /// Ainevaldkonna õppeainete õpetamise peamine eesmärk on vastava valdkonnapädevuse kujundamine. Valdkonnapädevuste kujunemist ning gümnaasiumi õppe- ja kasvatuseesmärkide saavutamist toetavad ainekavades esitatud õpitulemused, lõiming teiste ainevaldkondade õppeainetega ning tunni- ja kooliväline tegevus. NB alignmentType = educationalSubjectArea.</para>
    ///   <a href="https://schema.edu.ee/Ainevaldkond">edu:Ainevaldkond</a>
    /// </summary>
    let Ainevaldkond = _prefixId.prefix "Ainevaldkond"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ainevaldkonna pädevus</para>
    ///   <a href="https://schema.edu.ee/AinevaldkonnaPadevus">edu:AinevaldkonnaPadevus</a>
    /// </summary>
    let AinevaldkonnaPadevus = _prefixId.prefix "AinevaldkonnaPadevus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-20^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-20^^xsd:date</para>
    ///   <para>rdfs:label : Haridusaste</para>
    ///   <para>rdfs:comment : Hariduse omandamise järjestikune osa, selle iga (järgnev) osa (nt põhiharidus, keskharidus, kõrgharidus). NB alignmentType = educationalLevel.</para>
    ///   <a href="https://schema.edu.ee/Haridusaste">edu:Haridusaste</a>
    /// </summary>
    let Haridusaste = _prefixId.prefix "Haridusaste"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Attituderdfs:label : Hoiak</para>
    ///   <para>rdfs:comment : Inimese kalduvus hinnata objektide (näit. isikute, sündmuste, nähtuste) olemust teatud määral soosival või mittesoosival viisil. See hinnang väljendub tavaliselt tunnetusliku (kognitiivse), emotsionaalse (afektiivse) või käitumusliku (konatiivse) reageeringuna.</para>
    ///   <a href="https://schema.edu.ee/Hoiak">edu:Hoiak</a>
    /// </summary>
    let Hoiak = _prefixId.prefix "Hoiak"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Individuaalne õppekava</para>
    ///   <para>rdfs:comment : Individuaalne õppekava on Individuaalse õppekava järgi õppimise korra kohaselt hariduslike erivajadustega õpilase jaoks koostatud õppekava, mis loob õpilasele tingimused võimetekohaseks õppimiseks ja arenemiseks. Individuaalne õppekava koostatakse õpilasele, kellel on raskusi oma klassikaaslastega samal ajal samas ruumis või vastavale klassile koostatud töökava alusel töötada. Hariduslikeks erivajadusteks võivad olla õpilase eriline andekus, õpi- ja käitumisraskused, terviserikked, puuded või pikemaaegne õpikeskkonnast eemal viibimine.</para>
    ///   <a href="https://schema.edu.ee/IndividuaalneOppekava">edu:IndividuaalneOppekava</a>
    /// </summary>
    let IndividuaalneOppekava = _prefixId.prefix "IndividuaalneOppekava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Kontrolltöö</para>
    ///   <para>rdfs:comment : Õppepäevas võib läbi viia ühe kontrolltöö. Kontrolltöö toimumise ajast teatatakse õpilastele vähemalt viis õppepäeva enne kontrolltöö toimumist. Õppenädalas võib läbi viia kuni kolm kontrolltööd. Kontrolltöid ei planeerita esmaspäevale ja reedele, samuti õppepäeva esimesele ning viimasele õppetunnile, v.a juhul, kui õppeaine on tunniplaanis esmaspäeval ja reedel või ainult ühel neist päevadest või esimese või viimase tunnina.</para>
    ///   <a href="https://schema.edu.ee/Kontrolltoo">edu:Kontrolltoo</a>
    /// </summary>
    let Kontrolltoo = _prefixId.prefix "Kontrolltoo"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Koolitus</para>
    ///   <para>rdfs:comment : Kavandatud süsteemne õpe, mille käigus antakse edasi kindlaid oskusi, teadmisi ja infot ning kujundatakse hoiakuid ja suhtumisi.</para>
    ///   <a href="https://schema.edu.ee/Koolitus">edu:Koolitus</a>
    /// </summary>
    let Koolitus = _prefixId.prefix "Koolitus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Küsimus</para>
    ///   <para>rdfs:comment : Üksikküsimus testis.</para>
    ///   <a href="https://schema.edu.ee/Kusimus">edu:Kusimus</a>
    /// </summary>
    let Kusimus = _prefixId.prefix "Kusimus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õpetaja töökava</para>
    ///   <para>rdfs:comment : Töökava on õpetajale igapäevane abivahend, mis võimaldab tal õppeprotsessi kavandada ja analüüsida ning iseennast hinnata. Töökava on dokument, mille alusel toimub õppetöö tundides.</para>
    ///   <a href="https://schema.edu.ee/OpetajaTookava">edu:OpetajaTookava</a>
    /// </summary>
    let OpetajaTookava = _prefixId.prefix "OpetajaTookava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õpirada</para>
    ///   <para>rdfs:comment : Õppija poolt läbitud tee, mis sisaldab (e-)õppe tegevusi, mis võimaldavad teadmiste, oskuste ja pädevuste järjepidevat omandamist.</para>
    ///   <a href="https://schema.edu.ee/Opirada">edu:Opirada</a>
    /// </summary>
    let Opirada = _prefixId.prefix "Opirada"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Learning assessmentrdfs:label : Õpitulemus</para>
    ///   <para>rdfs:comment : Kellegi teadmistele, oskustele, võimetele, töötulemustele antud hinnang, mida väljendatakse numbrites, tähtedes, punktides vm hindamisühikutes. Lihtsustatult, õpitulemus esitab õpiväljundi saavutatuse taset. Eksami või arvestuse sooritus.</para>
    ///   <a href="https://schema.edu.ee/Opitulemus">edu:Opitulemus</a>
    /// </summary>
    let Opitulemus = _prefixId.prefix "Opitulemus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Learning outcomerdfs:label : Õpiväljund</para>
    ///   <para>rdfs:comment : Õppimise tulemusena omandatavad teadmised, oskused ja hoiakud või nende kogumid (pädevused), mille olemasolu ja/või saavutatuse taset on võimalik tõendada ja hinnata. Nt "oskab liita 10 piires". NB alignmentType = teaches.</para>
    ///   <a href="https://schema.edu.ee/Opivaljund">edu:Opivaljund</a>
    /// </summary>
    let Opivaljund = _prefixId.prefix "Opivaljund"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Subjectrdfs:label : Õppeaine</para>
    ///   <para>rdfs:comment : Õppeasutuses õpetatav teadus-, tehnika-, kunsti- vm ala.</para>
    ///   <a href="https://schema.edu.ee/Oppeaine">edu:Oppeaine</a>
    /// </summary>
    let Oppeaine = _prefixId.prefix "Oppeaine"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õppeasutuse õppekava</para>
    ///   <para>rdfs:comment : Õppeasutuse õppekava on õppe- ja kasvatustegevuse alusdokument, milles kirjeldatakse õppe rõhuasetused ja tegevused õppekava täitmiseks.</para>
    ///   <a href="https://schema.edu.ee/OppeasutuseOppekava">edu:OppeasutuseOppekava</a>
    /// </summary>
    let OppeasutuseOppekava = _prefixId.prefix "OppeasutuseOppekava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Curriculumrdfs:label : Õppekava</para>
    ///   <para>rdfs:comment : Õppe ja kasvatuse alusdokument, mis määrab õppe- ja kasvatuseesmärgid, õppe sisu ja mahu, metoodika põhimõtted ning hindamise alused, nõuded õppekeskkonnale vms.</para>
    ///   <a href="https://schema.edu.ee/Oppekava">edu:Oppekava</a>
    /// </summary>
    let Oppekava = _prefixId.prefix "Oppekava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Learning materialrdfs:label : Õppematerjal</para>
    ///   <para>rdfs:comment : Nii digitaalsel kui muul kujul õppematerjal. Digitaalsel kujul avaldatud õppematerjal on nt: e-õpik, õpiotstarbeline veebivideo ja mobiilirakendus, õpimäng, e-tööleht, veebipõhine test, õpiobjekt.</para>
    ///   <a href="https://schema.edu.ee/Oppematerjal">edu:Oppematerjal</a>
    /// </summary>
    let Oppematerjal = _prefixId.prefix "Oppematerjal"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Oskusrdfs:label : Skill</para>
    ///   <para>rdfs:comment : Võime rakendada teadmisi ja kasutada neid ülesannete täitmisel ja probleemide lahendamisel.</para>
    ///   <a href="https://schema.edu.ee/Oskus">edu:Oskus</a>
    /// </summary>
    let Oskus = _prefixId.prefix "Oskus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Competencerdfs:label : Pädevus</para>
    ///   <para>rdfs:comment : Teadmiste, oskuste ja hoiakute kogum, mis tagab suutlikkuse teatud tegevusalal või -valdkonnas loovalt, ettevõtlikult ja paindlikult toimida.</para>
    ///   <a href="https://schema.edu.ee/Padevus">edu:Padevus</a>
    /// </summary>
    let Padevus = _prefixId.prefix "Padevus"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : National curriculumrdfs:label : Riiklik õppekava</para>
    ///   <para>rdfs:comment : Hariduse eesmärkide elluviimise riiklik plaan, mis annab ülevaate sellest, milleks, mida, kuidas ja millise aja jooksul õpitakse ning õpetatakse.</para>
    ///   <a href="https://schema.edu.ee/RiiklikOppekava">edu:RiiklikOppekava</a>
    /// </summary>
    let RiiklikOppekava = _prefixId.prefix "RiiklikOppekava"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Educational audiencerdfs:label : Sihtgrupp</para>
    ///   <para>rdfs:comment : Elanikkonna rühm, mille vajadusi silmas pidades on õppematerjal loodud.</para>
    ///   <a href="https://schema.edu.ee/Sihtgrupp">edu:Sihtgrupp</a>
    /// </summary>
    let Sihtgrupp = _prefixId.prefix "Sihtgrupp"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Tasemetöö</para>
    ///   <para>rdfs:comment : Kokkuvõttev test, kokkulepitud astme (kooliastme) lõpus saavutatud oskused ja teadmised; kooliastme lõpus teadmiste ja oskuste omandatust kontrolliv üleriigiline töö.</para>
    ///   <a href="https://schema.edu.ee/Tasemetoo">edu:Tasemetoo</a>
    /// </summary>
    let Tasemetoo = _prefixId.prefix "Tasemetoo"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Knowledgerdfs:label : Teadmine</para>
    ///   <para>rdfs:comment : Õpingutega või kogemustest omandatud faktide, reeglite, seaduspärasuste jms tundmine.</para>
    ///   <a href="https://schema.edu.ee/Teadmine">edu:Teadmine</a>
    /// </summary>
    let Teadmine = _prefixId.prefix "Teadmine"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Teemardfs:label : Topic</para>
    ///   <para>rdfs:comment : Aine sisuühik, mida õpetatakse a'la "2. maailmasõda ajaloos" või "Geomeetria". Teemad on kasutusel õppematerjalide lõimimiseks. NB alignmentType = educationalSubject.</para>
    ///   <a href="https://schema.edu.ee/Teema">edu:Teema</a>
    /// </summary>
    let Teema = _prefixId.prefix "Teema"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Testrdfs:label : Test</para>
    ///   <para>rdfs:comment : Hindamisvahend kokkulepitud eesmärgi hindamiseks. Nt ülesannete kogum; standardiseeritud ülesannete või küsimuste kogum, millega uuritakse ja hinnatakse inimese võimeid ja omadusi või teadmisi ja oskusi.</para>
    ///   <a href="https://schema.edu.ee/Test">edu:Test</a>
    /// </summary>
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Tunnikontroll</para>
    ///   <para>rdfs:comment : Väikesemahuline kirjalik töö tunnis õpitu kontrollimiseks ja hindamiseks.</para>
    ///   <a href="https://schema.edu.ee/Tunnikontroll">edu:Tunnikontroll</a>
    /// </summary>
    let Tunnikontroll = _prefixId.prefix "Tunnikontroll"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ülesanne</para>
    ///   <para>rdfs:comment : Kohustusena antud töö; harjutustöö koolis. Ülesanne koosneb tööjuhendist, (üksik)küsimustest ja vastustest. Kasutusel ka hindamisvahendina.</para>
    ///   <a href="https://schema.edu.ee/Ulesanne">edu:Ulesanne</a>
    /// </summary>
    let Ulesanne = _prefixId.prefix "Ulesanne"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Vastus</para>
    ///   <para>rdfs:comment : Üksikküsimuse vastus testis.</para>
    ///   <a href="https://schema.edu.ee/Vastus">edu:Vastus</a>
    /// </summary>
    let Vastus = _prefixId.prefix "Vastus"
    /// <summary>
    ///   <para>rdfs:comment : Ainevaldkond sisaldab vähemalt ühte, kuid enamasti rohkemat, õppeainet.</para>
    ///   <para>rdfs:label : Includes subjectrdfs:label : Ainevaldkond sisaldab õppeainet</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <a href="https://schema.edu.ee/ainevaldkondKoosneb">edu:ainevaldkondKoosneb</a>
    /// </summary>
    let ainevaldkondKoosneb = _prefixId.prefix "ainevaldkondKoosneb"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Alateema</para>
    ///   <para>rdfs:comment : Teema alamosa, a'la "Tasandilised kujundid".</para>
    ///   <a href="https://schema.edu.ee/alateema">edu:alateema</a>
    /// </summary>
    let alateema = _prefixId.prefix "alateema"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õpiväljundi eeldus</para>
    ///   <para>rdfs:comment : Õpiväljundi omandamiseks on vajalik teine õpiväljund, nt oskuse jaoks on vajalik teadmine.</para>
    ///   <a href="https://schema.edu.ee/eeldab">edu:eeldab</a>
    /// </summary>
    let eeldab = _prefixId.prefix "eeldab"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Hindab õpitulemuse saavutatust</para>
    ///   <para>rdfs:comment : Ülesanne hindab mil määral on õpitulemus omandatud. Küsimus hindab kas konkreetse küsimusega seotud õpitulemus on saavutatud või mitte.</para>
    ///   <a href="https://schema.edu.ee/hindabOpitulemust">edu:hindabOpitulemust</a>
    /// </summary>
    let hindabOpitulemust = _prefixId.prefix "hindabOpitulemust"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Kooliaste</para>
    ///   <para>rdfs:comment : Hariduse omandamise järjestikune alajaotus, selle iga (järgnev) osa.
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
    ///   <a href="https://schema.edu.ee/kooliaste">edu:kooliaste</a>
    /// </summary>
    let kooliaste = _prefixId.prefix "kooliaste"
    /// <summary>
    ///   <para>rdfs:comment : Õpiväljund on eelduseks teis(t)ele õpiväljundi(te)le.</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õpiväljund on eelduseks</para>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <a href="https://schema.edu.ee/onEelduseks">edu:onEelduseks</a>
    /// </summary>
    let onEelduseks = _prefixId.prefix "onEelduseks"
    let opivaljundEeldab = _prefixId.prefix "opivaljundEeldab"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ainevaldkond, mille raames õpiväljundit või õppematerjali käsitletakse</para>
    ///   <para>rdfs:comment : Õpiväljundit võidakse kasutada erinevates ainevaldkondades riikliku õppekava kontekstis. Õpiväljund ei pea olema seotud ainevaldkonnaga. Õppematerjal võib olla seotud ainevaldkondadega.</para>
    ///   <a href="https://schema.edu.ee/seotudAinevaldkond">edu:seotudAinevaldkond</a>
    /// </summary>
    let seotudAinevaldkond = _prefixId.prefix "seotudAinevaldkond"
    /// <summary>
    ///   <para>dcterms:issued : 2020-02-20^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-02-20^^xsd:date</para>
    ///   <para>rdfs:comment : Õppematerjal on mõeldud või õpiväljund on planeeritud konkreetsele haridusastmele.</para>
    ///   <para>rdfs:label : Õppematerjali või õpiväljundiga seotud haridusaste</para>
    ///   <a href="https://schema.edu.ee/seotudHaridusaste">edu:seotudHaridusaste</a>
    /// </summary>
    let seotudHaridusaste = _prefixId.prefix "seotudHaridusaste"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Teemaga või õppematerjaliga seotud õpiväljund</para>
    ///   <para>rdfs:comment : Õpiväljundit võidakse kasutada erinevates ainevaldkondades riikliku õppekava kontekstis. Õpiväljund ei pea olema seotud ainevaldkonnaga. Õppematerjal on seotud konkreetsete õpiväljundite saavutamisega. Minimaalselt on õppematerjaliga seotud üks õpiväljund.</para>
    ///   <a href="https://schema.edu.ee/seotudOpivaljund">edu:seotudOpivaljund</a>
    /// </summary>
    let seotudOpivaljund = _prefixId.prefix "seotudOpivaljund"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Õppeaine, mille raames õpiväljundit või teemat käsitletekse</para>
    ///   <para>rdfs:comment : Õpiväljund ei pea olema seotud ühegi õppeainega ja võib olla seotud mitme õppeainega.</para>
    ///   <a href="https://schema.edu.ee/seotudOppeaine">edu:seotudOppeaine</a>
    /// </summary>
    let seotudOppeaine = _prefixId.prefix "seotudOppeaine"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Teema, mille raames õpiväljundit või teemat käsitletakse</para>
    ///   <para>rdfs:comment : Õpiväljund ei pea olema ühegi teemaga, kuid teema raames käsitletakse vähemalt ühte õpiväljundit. Õppematerjal võib olla seotud teemadega.</para>
    ///   <a href="https://schema.edu.ee/seotudTeema">edu:seotudTeema</a>
    /// </summary>
    let seotudTeema = _prefixId.prefix "seotudTeema"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Test koosneb ülesannetest</para>
    ///   <para>rdfs:comment : Test koosneb vähemalt ühest ülesandest.</para>
    ///   <a href="https://schema.edu.ee/testKoosneb">edu:testKoosneb</a>
    /// </summary>
    let testKoosneb = _prefixId.prefix "testKoosneb"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Ülesanne koosneb üksikküsimustest</para>
    ///   <para>rdfs:comment : Ülesanne koosneb vähemalt ühest üksikküsimusest.</para>
    ///   <a href="https://schema.edu.ee/ulesanneKoosneb">edu:ulesanneKoosneb</a>
    /// </summary>
    let ulesanneKoosneb = _prefixId.prefix "ulesanneKoosneb"
    /// <summary>
    ///   <para>dcterms:modified : 2020-02-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2020-02-14^^xsd:date</para>
    ///   <para>rdfs:label : Vanuseaste</para>
    ///   <para>rdfs:comment : Vanuse teatav alajaotus; selles vanuses inimesed.</para>
    ///   <a href="https://schema.edu.ee/vanuseaste">edu:vanuseaste</a>
    /// </summary>
    let vanuseaste = _prefixId.prefix "vanuseaste"

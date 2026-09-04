#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mrel =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://id.loc.gov/vocabulary/relators/" "mrel"

    /// <summary>
    ///   <para>mads:authoritativeLabel : Abridger</para>
    ///   <para>rdfs:label : Abridger</para>
    ///   <para>skos:notation : abr^^xsd:string</para>
    ///   <para>mads:code : abr^^xsd:string</para>
    ///   <para>skos:prefLabel : Abridger</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/abr">mrel:abr</a>
    /// </summary>
    let abr = _prefixId.prefix "abr"
    /// <summary>
    ///   <para>rdfs:label : Art copyist</para>
    ///   <para>mads:authoritativeLabel : Art copyist</para>
    ///   <para>mads:code : acp^^xsd:string</para>
    ///   <para>skos:notation : acp^^xsd:string</para>
    ///   <para>skos:prefLabel : Art copyist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/acp">mrel:acp</a>
    /// </summary>
    let acp = _prefixId.prefix "acp"
    /// <summary>
    ///   <para>skos:notation : act^^xsd:string</para>
    ///   <para>rdfs:label : Actor</para>
    ///   <para>skos:prefLabel : Actor</para>
    ///   <para>mads:authoritativeLabel : Actor</para>
    ///   <para>mads:code : act^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/act">mrel:act</a>
    /// </summary>
    let act = _prefixId.prefix "act"
    /// <summary>
    ///   <para>rdfs:label : Art director</para>
    ///   <para>skos:notation : adi^^xsd:string</para>
    ///   <para>mads:code : adi^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Art director</para>
    ///   <para>skos:prefLabel : Art director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/adi">mrel:adi</a>
    /// </summary>
    let adi = _prefixId.prefix "adi"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Adapter</para>
    ///   <para>skos:prefLabel : Adapter</para>
    ///   <para>mads:code : adp^^xsd:string</para>
    ///   <para>skos:notation : adp^^xsd:string</para>
    ///   <para>rdfs:label : Adapter</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/adp">mrel:adp</a>
    /// </summary>
    let adp = _prefixId.prefix "adp"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Author of afterword, colophon, etc.</para>
    ///   <para>skos:prefLabel : Author of afterword, colophon, etc.</para>
    ///   <para>rdfs:label : Author of afterword, colophon, etc.</para>
    ///   <para>mads:code : aft^^xsd:string</para>
    ///   <para>skos:notation : aft^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aft">mrel:aft</a>
    /// </summary>
    let aft = _prefixId.prefix "aft"
    /// <summary>
    ///   <para>rdfs:label : Analyst</para>
    ///   <para>mads:authoritativeLabel : Analyst</para>
    ///   <para>skos:notation : anl^^xsd:string</para>
    ///   <para>skos:prefLabel : Analyst</para>
    ///   <para>mads:code : anl^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/anl">mrel:anl</a>
    /// </summary>
    let anl = _prefixId.prefix "anl"
    /// <summary>
    ///   <para>rdfs:label : Animator</para>
    ///   <para>mads:code : anm^^xsd:string</para>
    ///   <para>skos:notation : anm^^xsd:string</para>
    ///   <para>skos:prefLabel : Animator</para>
    ///   <para>mads:authoritativeLabel : Animator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/anm">mrel:anm</a>
    /// </summary>
    let anm = _prefixId.prefix "anm"
    /// <summary>
    ///   <para>skos:prefLabel : Annotator</para>
    ///   <para>rdfs:label : Annotator</para>
    ///   <para>mads:authoritativeLabel : Annotator</para>
    ///   <para>skos:notation : ann^^xsd:string</para>
    ///   <para>mads:code : ann^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ann">mrel:ann</a>
    /// </summary>
    let ann = _prefixId.prefix "ann"
    /// <summary>
    ///   <para>rdfs:label : Bibliographic antecedent</para>
    ///   <para>mads:authoritativeLabel : Bibliographic antecedent</para>
    ///   <para>mads:code : ant^^xsd:string</para>
    ///   <para>skos:prefLabel : Bibliographic antecedent</para>
    ///   <para>skos:notation : ant^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ant">mrel:ant</a>
    /// </summary>
    let ant = _prefixId.prefix "ant"
    /// <summary>
    ///   <para>skos:notation : ape^^xsd:string</para>
    ///   <para>mads:code : ape^^xsd:string</para>
    ///   <para>rdfs:label : Appellee</para>
    ///   <para>skos:prefLabel : Appellee</para>
    ///   <para>mads:authoritativeLabel : Appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ape">mrel:ape</a>
    /// </summary>
    let ape = _prefixId.prefix "ape"
    /// <summary>
    ///   <para>mads:code : apl^^xsd:string</para>
    ///   <para>skos:prefLabel : Appellant</para>
    ///   <para>skos:notation : apl^^xsd:string</para>
    ///   <para>rdfs:label : Appellant</para>
    ///   <para>mads:authoritativeLabel : Appellant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/apl">mrel:apl</a>
    /// </summary>
    let apl = _prefixId.prefix "apl"
    /// <summary>
    ///   <para>mads:code : app^^xsd:string</para>
    ///   <para>rdfs:label : Applicant</para>
    ///   <para>skos:notation : app^^xsd:string</para>
    ///   <para>skos:prefLabel : Applicant</para>
    ///   <para>mads:authoritativeLabel : Applicant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/app">mrel:app</a>
    /// </summary>
    let app = _prefixId.prefix "app"
    /// <summary>
    ///   <para>mads:code : aqt^^xsd:string</para>
    ///   <para>skos:prefLabel : Author in quotations or text abstracts</para>
    ///   <para>rdfs:label : Author in quotations or text abstracts</para>
    ///   <para>skos:notation : aqt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Author in quotations or text abstracts</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aqt">mrel:aqt</a>
    /// </summary>
    let aqt = _prefixId.prefix "aqt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Architect</para>
    ///   <para>skos:prefLabel : Architect</para>
    ///   <para>mads:code : arc^^xsd:string</para>
    ///   <para>rdfs:label : Architect</para>
    ///   <para>skos:notation : arc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/arc">mrel:arc</a>
    /// </summary>
    let arc = _prefixId.prefix "arc"
    /// <summary>
    ///   <para>skos:notation : ard^^xsd:string</para>
    ///   <para>mads:code : ard^^xsd:string</para>
    ///   <para>skos:prefLabel : Artistic director</para>
    ///   <para>mads:authoritativeLabel : Artistic director</para>
    ///   <para>rdfs:label : Artistic director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ard">mrel:ard</a>
    /// </summary>
    let ard = _prefixId.prefix "ard"
    /// <summary>
    ///   <para>mads:code : arr^^xsd:string</para>
    ///   <para>skos:notation : arr^^xsd:string</para>
    ///   <para>skos:prefLabel : Arranger</para>
    ///   <para>rdfs:label : Arranger</para>
    ///   <para>mads:authoritativeLabel : Arranger</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/arr">mrel:arr</a>
    /// </summary>
    let arr = _prefixId.prefix "arr"
    /// <summary>
    ///   <para>mads:code : art^^xsd:string</para>
    ///   <para>skos:prefLabel : Artist</para>
    ///   <para>rdfs:label : Artist</para>
    ///   <para>mads:authoritativeLabel : Artist</para>
    ///   <para>skos:notation : art^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/art">mrel:art</a>
    /// </summary>
    let art = _prefixId.prefix "art"
    /// <summary>
    ///   <para>rdfs:label : Assignee</para>
    ///   <para>mads:code : asg^^xsd:string</para>
    ///   <para>skos:prefLabel : Assignee</para>
    ///   <para>mads:authoritativeLabel : Assignee</para>
    ///   <para>skos:notation : asg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/asg">mrel:asg</a>
    /// </summary>
    let asg = _prefixId.prefix "asg"
    /// <summary>
    ///   <para>skos:notation : asn^^xsd:string</para>
    ///   <para>mads:code : asn^^xsd:string</para>
    ///   <para>skos:prefLabel : Associated name</para>
    ///   <para>mads:authoritativeLabel : Associated name</para>
    ///   <para>rdfs:label : Associated name</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/asn">mrel:asn</a>
    /// </summary>
    let asn = _prefixId.prefix "asn"
    /// <summary>
    ///   <para>mads:code : ato^^xsd:string</para>
    ///   <para>skos:prefLabel : Autographer</para>
    ///   <para>mads:authoritativeLabel : Autographer</para>
    ///   <para>rdfs:label : Autographer</para>
    ///   <para>skos:notation : ato^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ato">mrel:ato</a>
    /// </summary>
    let ato = _prefixId.prefix "ato"
    /// <summary>
    ///   <para>mads:code : att^^xsd:string</para>
    ///   <para>skos:notation : att^^xsd:string</para>
    ///   <para>skos:prefLabel : Attributed name</para>
    ///   <para>mads:authoritativeLabel : Attributed name</para>
    ///   <para>rdfs:label : Attributed name</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/att">mrel:att</a>
    /// </summary>
    let att = _prefixId.prefix "att"
    /// <summary>
    ///   <para>rdfs:label : Auctioneer</para>
    ///   <para>mads:code : auc^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Auctioneer</para>
    ///   <para>skos:prefLabel : Auctioneer</para>
    ///   <para>skos:notation : auc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/auc">mrel:auc</a>
    /// </summary>
    let auc = _prefixId.prefix "auc"
    /// <summary>
    ///   <para>rdfs:label : Author of dialog</para>
    ///   <para>skos:notation : aud^^xsd:string</para>
    ///   <para>mads:code : aud^^xsd:string</para>
    ///   <para>skos:prefLabel : Author of dialog</para>
    ///   <para>mads:authoritativeLabel : Author of dialog</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aud">mrel:aud</a>
    /// </summary>
    let aud = _prefixId.prefix "aud"
    /// <summary>
    ///   <para>mads:code : aui^^xsd:string</para>
    ///   <para>rdfs:label : Author of introduction, etc.</para>
    ///   <para>skos:prefLabel : Author of introduction, etc.</para>
    ///   <para>skos:notation : aui^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Author of introduction, etc.</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aui">mrel:aui</a>
    /// </summary>
    let aui = _prefixId.prefix "aui"
    /// <summary>
    ///   <para>skos:prefLabel : Screenwriter</para>
    ///   <para>rdfs:label : Screenwriter</para>
    ///   <para>mads:authoritativeLabel : Screenwriter</para>
    ///   <para>mads:code : aus^^xsd:string</para>
    ///   <para>skos:notation : aus^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aus">mrel:aus</a>
    /// </summary>
    let aus = _prefixId.prefix "aus"
    /// <summary>
    ///   <para>skos:notation : aut^^xsd:string</para>
    ///   <para>skos:prefLabel : Author</para>
    ///   <para>mads:code : aut^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Author</para>
    ///   <para>rdfs:label : Author</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/aut">mrel:aut</a>
    /// </summary>
    let aut = _prefixId.prefix "aut"
    /// <summary>
    ///   <para>skos:prefLabel : Binding designer</para>
    ///   <para>skos:notation : bdd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Binding designer</para>
    ///   <para>rdfs:label : Binding designer</para>
    ///   <para>mads:code : bdd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bdd">mrel:bdd</a>
    /// </summary>
    let bdd = _prefixId.prefix "bdd"
    /// <summary>
    ///   <para>skos:prefLabel : Bookjacket designer</para>
    ///   <para>mads:authoritativeLabel : Bookjacket designer</para>
    ///   <para>rdfs:label : Bookjacket designer</para>
    ///   <para>mads:code : bjd^^xsd:string</para>
    ///   <para>skos:notation : bjd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bjd">mrel:bjd</a>
    /// </summary>
    let bjd = _prefixId.prefix "bjd"
    /// <summary>
    ///   <para>mads:code : bkd^^xsd:string</para>
    ///   <para>skos:notation : bkd^^xsd:string</para>
    ///   <para>skos:prefLabel : Book designer</para>
    ///   <para>rdfs:label : Book designer</para>
    ///   <para>mads:authoritativeLabel : Book designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bkd">mrel:bkd</a>
    /// </summary>
    let bkd = _prefixId.prefix "bkd"
    /// <summary>
    ///   <para>rdfs:label : Book producer</para>
    ///   <para>skos:notation : bkp^^xsd:string</para>
    ///   <para>skos:prefLabel : Book producer</para>
    ///   <para>mads:authoritativeLabel : Book producer</para>
    ///   <para>mads:code : bkp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bkp">mrel:bkp</a>
    /// </summary>
    let bkp = _prefixId.prefix "bkp"
    /// <summary>
    ///   <para>skos:notation : blw^^xsd:string</para>
    ///   <para>rdfs:label : Blurb writer</para>
    ///   <para>mads:authoritativeLabel : Blurb writer</para>
    ///   <para>skos:prefLabel : Blurb writer</para>
    ///   <para>mads:code : blw^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/blw">mrel:blw</a>
    /// </summary>
    let blw = _prefixId.prefix "blw"
    /// <summary>
    ///   <para>skos:prefLabel : Binder</para>
    ///   <para>skos:notation : bnd^^xsd:string</para>
    ///   <para>rdfs:label : Binder</para>
    ///   <para>mads:authoritativeLabel : Binder</para>
    ///   <para>mads:code : bnd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bnd">mrel:bnd</a>
    /// </summary>
    let bnd = _prefixId.prefix "bnd"
    /// <summary>
    ///   <para>rdfs:label : Bookplate designer</para>
    ///   <para>skos:notation : bpd^^xsd:string</para>
    ///   <para>mads:code : bpd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Bookplate designer</para>
    ///   <para>skos:prefLabel : Bookplate designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bpd">mrel:bpd</a>
    /// </summary>
    let bpd = _prefixId.prefix "bpd"
    /// <summary>
    ///   <para>rdfs:label : Broadcaster</para>
    ///   <para>skos:prefLabel : Broadcaster</para>
    ///   <para>skos:notation : brd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Broadcaster</para>
    ///   <para>mads:code : brd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/brd">mrel:brd</a>
    /// </summary>
    let brd = _prefixId.prefix "brd"
    /// <summary>
    ///   <para>mads:code : brl^^xsd:string</para>
    ///   <para>skos:notation : brl^^xsd:string</para>
    ///   <para>skos:prefLabel : Braille embosser</para>
    ///   <para>rdfs:label : Braille embosser</para>
    ///   <para>mads:authoritativeLabel : Braille embosser</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/brl">mrel:brl</a>
    /// </summary>
    let brl = _prefixId.prefix "brl"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Bookseller</para>
    ///   <para>rdfs:label : Bookseller</para>
    ///   <para>skos:notation : bsl^^xsd:string</para>
    ///   <para>skos:prefLabel : Bookseller</para>
    ///   <para>mads:code : bsl^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/bsl">mrel:bsl</a>
    /// </summary>
    let bsl = _prefixId.prefix "bsl"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Caster</para>
    ///   <para>rdfs:label : Caster</para>
    ///   <para>skos:prefLabel : Caster</para>
    ///   <para>mads:code : cas^^xsd:string</para>
    ///   <para>skos:notation : cas^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cas">mrel:cas</a>
    /// </summary>
    let cas = _prefixId.prefix "cas"
    /// <summary>
    ///   <para>skos:prefLabel : Conceptor</para>
    ///   <para>rdfs:label : Conceptor</para>
    ///   <para>mads:authoritativeLabel : Conceptor</para>
    ///   <para>mads:code : ccp^^xsd:string</para>
    ///   <para>skos:notation : ccp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ccp">mrel:ccp</a>
    /// </summary>
    let ccp = _prefixId.prefix "ccp"
    /// <summary>
    ///   <para>mads:code : chr^^xsd:string</para>
    ///   <para>skos:prefLabel : Choreographer</para>
    ///   <para>rdfs:label : Choreographer</para>
    ///   <para>mads:authoritativeLabel : Choreographer</para>
    ///   <para>skos:notation : chr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/chr">mrel:chr</a>
    /// </summary>
    let chr = _prefixId.prefix "chr"
    /// <summary>
    ///   <para>skos:notation : cli^^xsd:string</para>
    ///   <para>mads:code : cli^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Client</para>
    ///   <para>rdfs:label : Client</para>
    ///   <para>skos:prefLabel : Client</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cli">mrel:cli</a>
    /// </summary>
    let cli = _prefixId.prefix "cli"
    /// <summary>
    ///   <para>mads:code : cll^^xsd:string</para>
    ///   <para>skos:notation : cll^^xsd:string</para>
    ///   <para>rdfs:label : Calligrapher</para>
    ///   <para>skos:prefLabel : Calligrapher</para>
    ///   <para>mads:authoritativeLabel : Calligrapher</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cll">mrel:cll</a>
    /// </summary>
    let cll = _prefixId.prefix "cll"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Colorist</para>
    ///   <para>skos:prefLabel : Colorist</para>
    ///   <para>rdfs:label : Colorist</para>
    ///   <para>mads:code : clr^^xsd:string</para>
    ///   <para>skos:notation : clr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/clr">mrel:clr</a>
    /// </summary>
    let clr = _prefixId.prefix "clr"
    /// <summary>
    ///   <para>skos:notation : clt^^xsd:string</para>
    ///   <para>skos:prefLabel : Collotyper</para>
    ///   <para>mads:code : clt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Collotyper</para>
    ///   <para>rdfs:label : Collotyper</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/clt">mrel:clt</a>
    /// </summary>
    let clt = _prefixId.prefix "clt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Commentator</para>
    ///   <para>rdfs:label : Commentator</para>
    ///   <para>skos:prefLabel : Commentator</para>
    ///   <para>skos:notation : cmm^^xsd:string</para>
    ///   <para>mads:code : cmm^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cmm">mrel:cmm</a>
    /// </summary>
    let cmm = _prefixId.prefix "cmm"
    /// <summary>
    ///   <para>rdfs:label : Composer</para>
    ///   <para>skos:prefLabel : Composer</para>
    ///   <para>skos:notation : cmp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Composer</para>
    ///   <para>mads:code : cmp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cmp">mrel:cmp</a>
    /// </summary>
    let cmp = _prefixId.prefix "cmp"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Compositor</para>
    ///   <para>skos:prefLabel : Compositor</para>
    ///   <para>skos:notation : cmt^^xsd:string</para>
    ///   <para>mads:code : cmt^^xsd:string</para>
    ///   <para>rdfs:label : Compositor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cmt">mrel:cmt</a>
    /// </summary>
    let cmt = _prefixId.prefix "cmt"
    /// <summary>
    ///   <para>skos:notation : cnd^^xsd:string</para>
    ///   <para>rdfs:label : Conductor</para>
    ///   <para>mads:code : cnd^^xsd:string</para>
    ///   <para>skos:prefLabel : Conductor</para>
    ///   <para>mads:authoritativeLabel : Conductor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cnd">mrel:cnd</a>
    /// </summary>
    let cnd = _prefixId.prefix "cnd"
    /// <summary>
    ///   <para>skos:notation : cng^^xsd:string</para>
    ///   <para>mads:code : cng^^xsd:string</para>
    ///   <para>skos:prefLabel : Cinematographer</para>
    ///   <para>mads:authoritativeLabel : Cinematographer</para>
    ///   <para>rdfs:label : Cinematographer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cng">mrel:cng</a>
    /// </summary>
    let cng = _prefixId.prefix "cng"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Censor</para>
    ///   <para>skos:prefLabel : Censor</para>
    ///   <para>rdfs:label : Censor</para>
    ///   <para>mads:code : cns^^xsd:string</para>
    ///   <para>skos:notation : cns^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cns">mrel:cns</a>
    /// </summary>
    let cns = _prefixId.prefix "cns"
    /// <summary>
    ///   <para>mads:code : coe^^xsd:string</para>
    ///   <para>skos:notation : coe^^xsd:string</para>
    ///   <para>rdfs:label : Contestant-appellee</para>
    ///   <para>mads:authoritativeLabel : Contestant-appellee</para>
    ///   <para>skos:prefLabel : Contestant-appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/coe">mrel:coe</a>
    /// </summary>
    let coe = _prefixId.prefix "coe"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Collector</para>
    ///   <para>skos:notation : col^^xsd:string</para>
    ///   <para>mads:code : col^^xsd:string</para>
    ///   <para>rdfs:label : Collector</para>
    ///   <para>skos:prefLabel : Collector</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/col">mrel:col</a>
    /// </summary>
    let col = _prefixId.prefix "col"
    let collection_BIBFRAMEInstance = _prefixId.prefix "collection_BIBFRAMEInstance"
    let collection_BIBFRAMEWork = _prefixId.prefix "collection_BIBFRAMEWork"
    let collection_RDA = _prefixId.prefix "collection_RDA"
    let collection_RDAContributor = _prefixId.prefix "collection_RDAContributor"
    let collection_RDACreator = _prefixId.prefix "collection_RDACreator"
    let collection_RDADistributor = _prefixId.prefix "collection_RDADistributor"
    let collection_RDAExpression = _prefixId.prefix "collection_RDAExpression"
    let collection_RDAItem = _prefixId.prefix "collection_RDAItem"
    let collection_RDAManifestation = _prefixId.prefix "collection_RDAManifestation"
    let collection_RDAManufacturer = _prefixId.prefix "collection_RDAManufacturer"
    let collection_RDAOther = _prefixId.prefix "collection_RDAOther"
    let collection_RDAOwner = _prefixId.prefix "collection_RDAOwner"
    let collection_RDAPublisher = _prefixId.prefix "collection_RDAPublisher"
    let collection_RDAWork = _prefixId.prefix "collection_RDAWork"
    /// <summary>
    ///   <para>skos:prefLabel : Compiler</para>
    ///   <para>rdfs:label : Compiler</para>
    ///   <para>mads:code : com^^xsd:string</para>
    ///   <para>skos:notation : com^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Compiler</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/com">mrel:com</a>
    /// </summary>
    let com = _prefixId.prefix "com"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Conservator</para>
    ///   <para>rdfs:label : Conservator</para>
    ///   <para>skos:notation : con^^xsd:string</para>
    ///   <para>mads:code : con^^xsd:string</para>
    ///   <para>skos:prefLabel : Conservator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/con">mrel:con</a>
    /// </summary>
    let con = _prefixId.prefix "con"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Collection registrar</para>
    ///   <para>skos:prefLabel : Collection registrar</para>
    ///   <para>rdfs:label : Collection registrar</para>
    ///   <para>skos:notation : cor^^xsd:string</para>
    ///   <para>mads:code : cor^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cor">mrel:cor</a>
    /// </summary>
    let cor = _prefixId.prefix "cor"
    /// <summary>
    ///   <para>mads:code : cos^^xsd:string</para>
    ///   <para>skos:notation : cos^^xsd:string</para>
    ///   <para>skos:prefLabel : Contestant</para>
    ///   <para>rdfs:label : Contestant</para>
    ///   <para>mads:authoritativeLabel : Contestant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cos">mrel:cos</a>
    /// </summary>
    let cos = _prefixId.prefix "cos"
    /// <summary>
    ///   <para>skos:notation : cot^^xsd:string</para>
    ///   <para>skos:prefLabel : Contestant-appellant</para>
    ///   <para>rdfs:label : Contestant-appellant</para>
    ///   <para>mads:authoritativeLabel : Contestant-appellant</para>
    ///   <para>mads:code : cot^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cot">mrel:cot</a>
    /// </summary>
    let cot = _prefixId.prefix "cot"
    /// <summary>
    ///   <para>rdfs:label : Court governed</para>
    ///   <para>mads:code : cou^^xsd:string</para>
    ///   <para>skos:prefLabel : Court governed</para>
    ///   <para>mads:authoritativeLabel : Court governed</para>
    ///   <para>skos:notation : cou^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cou">mrel:cou</a>
    /// </summary>
    let cou = _prefixId.prefix "cou"
    /// <summary>
    ///   <para>rdfs:label : Cover designer</para>
    ///   <para>mads:code : cov^^xsd:string</para>
    ///   <para>skos:prefLabel : Cover designer</para>
    ///   <para>skos:notation : cov^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Cover designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cov">mrel:cov</a>
    /// </summary>
    let cov = _prefixId.prefix "cov"
    /// <summary>
    ///   <para>skos:notation : cpc^^xsd:string</para>
    ///   <para>skos:prefLabel : Copyright claimant</para>
    ///   <para>mads:authoritativeLabel : Copyright claimant</para>
    ///   <para>mads:code : cpc^^xsd:string</para>
    ///   <para>rdfs:label : Copyright claimant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cpc">mrel:cpc</a>
    /// </summary>
    let cpc = _prefixId.prefix "cpc"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Complainant-appellee</para>
    ///   <para>skos:prefLabel : Complainant-appellee</para>
    ///   <para>rdfs:label : Complainant-appellee</para>
    ///   <para>skos:notation : cpe^^xsd:string</para>
    ///   <para>mads:code : cpe^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cpe">mrel:cpe</a>
    /// </summary>
    let cpe = _prefixId.prefix "cpe"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Copyright holder</para>
    ///   <para>skos:notation : cph^^xsd:string</para>
    ///   <para>rdfs:label : Copyright holder</para>
    ///   <para>mads:code : cph^^xsd:string</para>
    ///   <para>skos:prefLabel : Copyright holder</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cph">mrel:cph</a>
    /// </summary>
    let cph = _prefixId.prefix "cph"
    /// <summary>
    ///   <para>skos:prefLabel : Complainant</para>
    ///   <para>skos:notation : cpl^^xsd:string</para>
    ///   <para>mads:code : cpl^^xsd:string</para>
    ///   <para>rdfs:label : Complainant</para>
    ///   <para>mads:authoritativeLabel : Complainant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cpl">mrel:cpl</a>
    /// </summary>
    let cpl = _prefixId.prefix "cpl"
    /// <summary>
    ///   <para>rdfs:label : Complainant-appellant</para>
    ///   <para>skos:prefLabel : Complainant-appellant</para>
    ///   <para>mads:authoritativeLabel : Complainant-appellant</para>
    ///   <para>skos:notation : cpt^^xsd:string</para>
    ///   <para>mads:code : cpt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cpt">mrel:cpt</a>
    /// </summary>
    let cpt = _prefixId.prefix "cpt"
    /// <summary>
    ///   <para>skos:prefLabel : Creator</para>
    ///   <para>mads:authoritativeLabel : Creator</para>
    ///   <para>skos:notation : cre^^xsd:string</para>
    ///   <para>mads:code : cre^^xsd:string</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cre">mrel:cre</a>
    /// </summary>
    let cre = _prefixId.prefix "cre"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Correspondent</para>
    ///   <para>mads:code : crp^^xsd:string</para>
    ///   <para>skos:prefLabel : Correspondent</para>
    ///   <para>rdfs:label : Correspondent</para>
    ///   <para>skos:notation : crp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/crp">mrel:crp</a>
    /// </summary>
    let crp = _prefixId.prefix "crp"
    /// <summary>
    ///   <para>mads:code : crr^^xsd:string</para>
    ///   <para>skos:notation : crr^^xsd:string</para>
    ///   <para>skos:prefLabel : Corrector</para>
    ///   <para>mads:authoritativeLabel : Corrector</para>
    ///   <para>rdfs:label : Corrector</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/crr">mrel:crr</a>
    /// </summary>
    let crr = _prefixId.prefix "crr"
    /// <summary>
    ///   <para>skos:notation : crt^^xsd:string</para>
    ///   <para>mads:code : crt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Court reporter</para>
    ///   <para>rdfs:label : Court reporter</para>
    ///   <para>skos:prefLabel : Court reporter</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/crt">mrel:crt</a>
    /// </summary>
    let crt = _prefixId.prefix "crt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Consultant</para>
    ///   <para>skos:prefLabel : Consultant</para>
    ///   <para>skos:notation : csl^^xsd:string</para>
    ///   <para>rdfs:label : Consultant</para>
    ///   <para>mads:code : csl^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/csl">mrel:csl</a>
    /// </summary>
    let csl = _prefixId.prefix "csl"
    /// <summary>
    ///   <para>rdfs:label : Consultant to a project</para>
    ///   <para>skos:notation : csp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Consultant to a project</para>
    ///   <para>mads:code : csp^^xsd:string</para>
    ///   <para>skos:prefLabel : Consultant to a project</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/csp">mrel:csp</a>
    /// </summary>
    let csp = _prefixId.prefix "csp"
    /// <summary>
    ///   <para>rdfs:label : Costume designer</para>
    ///   <para>skos:notation : cst^^xsd:string</para>
    ///   <para>mads:code : cst^^xsd:string</para>
    ///   <para>skos:prefLabel : Costume designer</para>
    ///   <para>mads:authoritativeLabel : Costume designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cst">mrel:cst</a>
    /// </summary>
    let cst = _prefixId.prefix "cst"
    /// <summary>
    ///   <para>rdfs:label : Contributor</para>
    ///   <para>mads:code : ctb^^xsd:string</para>
    ///   <para>skos:notation : ctb^^xsd:string</para>
    ///   <para>skos:prefLabel : Contributor</para>
    ///   <para>mads:authoritativeLabel : Contributor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ctb">mrel:ctb</a>
    /// </summary>
    let ctb = _prefixId.prefix "ctb"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Contestee-appellee</para>
    ///   <para>skos:notation : cte^^xsd:string</para>
    ///   <para>rdfs:label : Contestee-appellee</para>
    ///   <para>mads:code : cte^^xsd:string</para>
    ///   <para>skos:prefLabel : Contestee-appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cte">mrel:cte</a>
    /// </summary>
    let cte = _prefixId.prefix "cte"
    /// <summary>
    ///   <para>mads:code : ctg^^xsd:string</para>
    ///   <para>rdfs:label : Cartographer</para>
    ///   <para>skos:notation : ctg^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Cartographer</para>
    ///   <para>skos:prefLabel : Cartographer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ctg">mrel:ctg</a>
    /// </summary>
    let ctg = _prefixId.prefix "ctg"
    /// <summary>
    ///   <para>skos:prefLabel : Contractor</para>
    ///   <para>rdfs:label : Contractor</para>
    ///   <para>skos:notation : ctr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Contractor</para>
    ///   <para>mads:code : ctr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ctr">mrel:ctr</a>
    /// </summary>
    let ctr = _prefixId.prefix "ctr"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Contestee</para>
    ///   <para>skos:prefLabel : Contestee</para>
    ///   <para>mads:code : cts^^xsd:string</para>
    ///   <para>rdfs:label : Contestee</para>
    ///   <para>skos:notation : cts^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cts">mrel:cts</a>
    /// </summary>
    let cts = _prefixId.prefix "cts"
    /// <summary>
    ///   <para>skos:notation : ctt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Contestee-appellant</para>
    ///   <para>rdfs:label : Contestee-appellant</para>
    ///   <para>skos:prefLabel : Contestee-appellant</para>
    ///   <para>mads:code : ctt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ctt">mrel:ctt</a>
    /// </summary>
    let ctt = _prefixId.prefix "ctt"
    /// <summary>
    ///   <para>rdfs:label : Curator</para>
    ///   <para>mads:code : cur^^xsd:string</para>
    ///   <para>skos:prefLabel : Curator</para>
    ///   <para>skos:notation : cur^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Curator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cur">mrel:cur</a>
    /// </summary>
    let cur = _prefixId.prefix "cur"
    /// <summary>
    ///   <para>skos:prefLabel : Commentator for written text</para>
    ///   <para>rdfs:label : Commentator for written text</para>
    ///   <para>mads:code : cwt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Commentator for written text</para>
    ///   <para>skos:notation : cwt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/cwt">mrel:cwt</a>
    /// </summary>
    let cwt = _prefixId.prefix "cwt"
    /// <summary>
    ///   <para>mads:code : dbp^^xsd:string</para>
    ///   <para>skos:notation : dbp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Distribution place</para>
    ///   <para>skos:prefLabel : Distribution place</para>
    ///   <para>rdfs:label : Distribution place</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dbp">mrel:dbp</a>
    /// </summary>
    let dbp = _prefixId.prefix "dbp"
    /// <summary>
    ///   <para>skos:prefLabel : Defendant</para>
    ///   <para>skos:notation : dfd^^xsd:string</para>
    ///   <para>rdfs:label : Defendant</para>
    ///   <para>mads:code : dfd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Defendant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dfd">mrel:dfd</a>
    /// </summary>
    let dfd = _prefixId.prefix "dfd"
    /// <summary>
    ///   <para>rdfs:label : Defendant-appellee</para>
    ///   <para>skos:prefLabel : Defendant-appellee</para>
    ///   <para>mads:authoritativeLabel : Defendant-appellee</para>
    ///   <para>mads:code : dfe^^xsd:string</para>
    ///   <para>skos:notation : dfe^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dfe">mrel:dfe</a>
    /// </summary>
    let dfe = _prefixId.prefix "dfe"
    /// <summary>
    ///   <para>mads:code : dft^^xsd:string</para>
    ///   <para>rdfs:label : Defendant-appellant</para>
    ///   <para>skos:prefLabel : Defendant-appellant</para>
    ///   <para>mads:authoritativeLabel : Defendant-appellant</para>
    ///   <para>skos:notation : dft^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dft">mrel:dft</a>
    /// </summary>
    let dft = _prefixId.prefix "dft"
    /// <summary>
    ///   <para>skos:prefLabel : Degree granting institution</para>
    ///   <para>rdfs:label : Degree granting institution</para>
    ///   <para>mads:authoritativeLabel : Degree granting institution</para>
    ///   <para>mads:code : dgg^^xsd:string</para>
    ///   <para>skos:notation : dgg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dgg">mrel:dgg</a>
    /// </summary>
    let dgg = _prefixId.prefix "dgg"
    /// <summary>
    ///   <para>rdfs:label : Degree supervisor</para>
    ///   <para>mads:code : dgs^^xsd:string</para>
    ///   <para>skos:notation : dgs^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Degree supervisor</para>
    ///   <para>skos:prefLabel : Degree supervisor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dgs">mrel:dgs</a>
    /// </summary>
    let dgs = _prefixId.prefix "dgs"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Dissertant</para>
    ///   <para>rdfs:label : Dissertant</para>
    ///   <para>skos:prefLabel : Dissertant</para>
    ///   <para>mads:code : dis^^xsd:string</para>
    ///   <para>skos:notation : dis^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dis">mrel:dis</a>
    /// </summary>
    let dis = _prefixId.prefix "dis"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Delineator</para>
    ///   <para>skos:notation : dln^^xsd:string</para>
    ///   <para>rdfs:label : Delineator</para>
    ///   <para>skos:prefLabel : Delineator</para>
    ///   <para>mads:code : dln^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dln">mrel:dln</a>
    /// </summary>
    let dln = _prefixId.prefix "dln"
    /// <summary>
    ///   <para>rdfs:label : Dancer</para>
    ///   <para>mads:code : dnc^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Dancer</para>
    ///   <para>skos:notation : dnc^^xsd:string</para>
    ///   <para>skos:prefLabel : Dancer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dnc">mrel:dnc</a>
    /// </summary>
    let dnc = _prefixId.prefix "dnc"
    /// <summary>
    ///   <para>skos:prefLabel : Donor</para>
    ///   <para>rdfs:label : Donor</para>
    ///   <para>skos:notation : dnr^^xsd:string</para>
    ///   <para>mads:code : dnr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Donor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dnr">mrel:dnr</a>
    /// </summary>
    let dnr = _prefixId.prefix "dnr"
    /// <summary>
    ///   <para>skos:prefLabel : Depicted</para>
    ///   <para>skos:notation : dpc^^xsd:string</para>
    ///   <para>mads:code : dpc^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Depicted</para>
    ///   <para>rdfs:label : Depicted</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dpc">mrel:dpc</a>
    /// </summary>
    let dpc = _prefixId.prefix "dpc"
    /// <summary>
    ///   <para>mads:code : dpt^^xsd:string</para>
    ///   <para>rdfs:label : Depositor</para>
    ///   <para>mads:authoritativeLabel : Depositor</para>
    ///   <para>skos:notation : dpt^^xsd:string</para>
    ///   <para>skos:prefLabel : Depositor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dpt">mrel:dpt</a>
    /// </summary>
    let dpt = _prefixId.prefix "dpt"
    /// <summary>
    ///   <para>skos:notation : drm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Draftsman</para>
    ///   <para>rdfs:label : Draftsman</para>
    ///   <para>skos:prefLabel : Draftsman</para>
    ///   <para>mads:code : drm^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/drm">mrel:drm</a>
    /// </summary>
    let drm = _prefixId.prefix "drm"
    /// <summary>
    ///   <para>skos:prefLabel : Director</para>
    ///   <para>mads:authoritativeLabel : Director</para>
    ///   <para>skos:notation : drt^^xsd:string</para>
    ///   <para>rdfs:label : Director</para>
    ///   <para>mads:code : drt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/drt">mrel:drt</a>
    /// </summary>
    let drt = _prefixId.prefix "drt"
    /// <summary>
    ///   <para>skos:notation : dsr^^xsd:string</para>
    ///   <para>rdfs:label : Designer</para>
    ///   <para>mads:authoritativeLabel : Designer</para>
    ///   <para>skos:prefLabel : Designer</para>
    ///   <para>mads:code : dsr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dsr">mrel:dsr</a>
    /// </summary>
    let dsr = _prefixId.prefix "dsr"
    /// <summary>
    ///   <para>mads:code : dst^^xsd:string</para>
    ///   <para>rdfs:label : Distributor</para>
    ///   <para>mads:authoritativeLabel : Distributor</para>
    ///   <para>skos:prefLabel : Distributor</para>
    ///   <para>skos:notation : dst^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dst">mrel:dst</a>
    /// </summary>
    let dst = _prefixId.prefix "dst"
    /// <summary>
    ///   <para>rdfs:label : Data contributor</para>
    ///   <para>mads:code : dtc^^xsd:string</para>
    ///   <para>skos:prefLabel : Data contributor</para>
    ///   <para>mads:authoritativeLabel : Data contributor</para>
    ///   <para>skos:notation : dtc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dtc">mrel:dtc</a>
    /// </summary>
    let dtc = _prefixId.prefix "dtc"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Dedicatee</para>
    ///   <para>mads:code : dte^^xsd:string</para>
    ///   <para>skos:notation : dte^^xsd:string</para>
    ///   <para>skos:prefLabel : Dedicatee</para>
    ///   <para>rdfs:label : Dedicatee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dte">mrel:dte</a>
    /// </summary>
    let dte = _prefixId.prefix "dte"
    /// <summary>
    ///   <para>rdfs:label : Data manager</para>
    ///   <para>mads:code : dtm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Data manager</para>
    ///   <para>skos:prefLabel : Data manager</para>
    ///   <para>skos:notation : dtm^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dtm">mrel:dtm</a>
    /// </summary>
    let dtm = _prefixId.prefix "dtm"
    /// <summary>
    ///   <para>skos:prefLabel : Dedicator</para>
    ///   <para>mads:authoritativeLabel : Dedicator</para>
    ///   <para>mads:code : dto^^xsd:string</para>
    ///   <para>rdfs:label : Dedicator</para>
    ///   <para>skos:notation : dto^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dto">mrel:dto</a>
    /// </summary>
    let dto = _prefixId.prefix "dto"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Dubious author</para>
    ///   <para>mads:code : dub^^xsd:string</para>
    ///   <para>skos:notation : dub^^xsd:string</para>
    ///   <para>rdfs:label : Dubious author</para>
    ///   <para>skos:prefLabel : Dubious author</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/dub">mrel:dub</a>
    /// </summary>
    let dub = _prefixId.prefix "dub"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Editor of compilation</para>
    ///   <para>rdfs:label : Editor of compilation</para>
    ///   <para>mads:code : edc^^xsd:string</para>
    ///   <para>skos:prefLabel : Editor of compilation</para>
    ///   <para>skos:notation : edc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/edc">mrel:edc</a>
    /// </summary>
    let edc = _prefixId.prefix "edc"
    /// <summary>
    ///   <para>skos:prefLabel : Editor of moving image work</para>
    ///   <para>skos:notation : edm^^xsd:string</para>
    ///   <para>mads:code : edm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Editor of moving image work</para>
    ///   <para>rdfs:label : Editor of moving image work</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/edm">mrel:edm</a>
    /// </summary>
    let edm = _prefixId.prefix "edm"
    /// <summary>
    ///   <para>mads:code : edt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Editor</para>
    ///   <para>skos:notation : edt^^xsd:string</para>
    ///   <para>skos:prefLabel : Editor</para>
    ///   <para>rdfs:label : Editor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/edt">mrel:edt</a>
    /// </summary>
    let edt = _prefixId.prefix "edt"
    /// <summary>
    ///   <para>skos:prefLabel : Engraver</para>
    ///   <para>rdfs:label : Engraver</para>
    ///   <para>mads:code : egr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Engraver</para>
    ///   <para>skos:notation : egr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/egr">mrel:egr</a>
    /// </summary>
    let egr = _prefixId.prefix "egr"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Electrician</para>
    ///   <para>mads:code : elg^^xsd:string</para>
    ///   <para>rdfs:label : Electrician</para>
    ///   <para>skos:prefLabel : Electrician</para>
    ///   <para>skos:notation : elg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/elg">mrel:elg</a>
    /// </summary>
    let elg = _prefixId.prefix "elg"
    /// <summary>
    ///   <para>mads:code : elt^^xsd:string</para>
    ///   <para>rdfs:label : Electrotyper</para>
    ///   <para>mads:authoritativeLabel : Electrotyper</para>
    ///   <para>skos:prefLabel : Electrotyper</para>
    ///   <para>skos:notation : elt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/elt">mrel:elt</a>
    /// </summary>
    let elt = _prefixId.prefix "elt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Engineer</para>
    ///   <para>mads:code : eng^^xsd:string</para>
    ///   <para>skos:notation : eng^^xsd:string</para>
    ///   <para>skos:prefLabel : Engineer</para>
    ///   <para>rdfs:label : Engineer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/eng">mrel:eng</a>
    /// </summary>
    let eng = _prefixId.prefix "eng"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Enacting jurisdiction</para>
    ///   <para>skos:prefLabel : Enacting jurisdiction</para>
    ///   <para>mads:code : enj^^xsd:string</para>
    ///   <para>rdfs:label : Enacting jurisdiction</para>
    ///   <para>skos:notation : enj^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/enj">mrel:enj</a>
    /// </summary>
    let enj = _prefixId.prefix "enj"
    /// <summary>
    ///   <para>skos:notation : etr^^xsd:string</para>
    ///   <para>rdfs:label : Etcher</para>
    ///   <para>mads:authoritativeLabel : Etcher</para>
    ///   <para>skos:prefLabel : Etcher</para>
    ///   <para>mads:code : etr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/etr">mrel:etr</a>
    /// </summary>
    let etr = _prefixId.prefix "etr"
    /// <summary>
    ///   <para>skos:prefLabel : Event place</para>
    ///   <para>rdfs:label : Event place</para>
    ///   <para>mads:authoritativeLabel : Event place</para>
    ///   <para>mads:code : evp^^xsd:string</para>
    ///   <para>skos:notation : evp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/evp">mrel:evp</a>
    /// </summary>
    let evp = _prefixId.prefix "evp"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Expert</para>
    ///   <para>skos:prefLabel : Expert</para>
    ///   <para>skos:notation : exp^^xsd:string</para>
    ///   <para>rdfs:label : Expert</para>
    ///   <para>mads:code : exp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/exp">mrel:exp</a>
    /// </summary>
    let exp = _prefixId.prefix "exp"
    /// <summary>
    ///   <para>rdfs:label : Facsimilist</para>
    ///   <para>skos:prefLabel : Facsimilist</para>
    ///   <para>skos:notation : fac^^xsd:string</para>
    ///   <para>mads:code : fac^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Facsimilist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fac">mrel:fac</a>
    /// </summary>
    let fac = _prefixId.prefix "fac"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Film distributor</para>
    ///   <para>mads:code : fds^^xsd:string</para>
    ///   <para>skos:prefLabel : Film distributor</para>
    ///   <para>skos:notation : fds^^xsd:string</para>
    ///   <para>rdfs:label : Film distributor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fds">mrel:fds</a>
    /// </summary>
    let fds = _prefixId.prefix "fds"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Field director</para>
    ///   <para>mads:code : fld^^xsd:string</para>
    ///   <para>skos:prefLabel : Field director</para>
    ///   <para>skos:notation : fld^^xsd:string</para>
    ///   <para>rdfs:label : Field director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fld">mrel:fld</a>
    /// </summary>
    let fld = _prefixId.prefix "fld"
    /// <summary>
    ///   <para>skos:prefLabel : Film editor</para>
    ///   <para>mads:code : flm^^xsd:string</para>
    ///   <para>skos:notation : flm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Film editor</para>
    ///   <para>rdfs:label : Film editor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/flm">mrel:flm</a>
    /// </summary>
    let flm = _prefixId.prefix "flm"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Film director</para>
    ///   <para>mads:code : fmd^^xsd:string</para>
    ///   <para>skos:prefLabel : Film director</para>
    ///   <para>skos:notation : fmd^^xsd:string</para>
    ///   <para>rdfs:label : Film director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fmd">mrel:fmd</a>
    /// </summary>
    let fmd = _prefixId.prefix "fmd"
    /// <summary>
    ///   <para>rdfs:label : Filmmaker</para>
    ///   <para>mads:authoritativeLabel : Filmmaker</para>
    ///   <para>mads:code : fmk^^xsd:string</para>
    ///   <para>skos:prefLabel : Filmmaker</para>
    ///   <para>skos:notation : fmk^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fmk">mrel:fmk</a>
    /// </summary>
    let fmk = _prefixId.prefix "fmk"
    /// <summary>
    ///   <para>skos:notation : fmo^^xsd:string</para>
    ///   <para>skos:prefLabel : Former owner</para>
    ///   <para>mads:authoritativeLabel : Former owner</para>
    ///   <para>rdfs:label : Former owner</para>
    ///   <para>mads:code : fmo^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fmo">mrel:fmo</a>
    /// </summary>
    let fmo = _prefixId.prefix "fmo"
    /// <summary>
    ///   <para>skos:prefLabel : Film producer</para>
    ///   <para>rdfs:label : Film producer</para>
    ///   <para>skos:notation : fmp^^xsd:string</para>
    ///   <para>mads:code : fmp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Film producer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fmp">mrel:fmp</a>
    /// </summary>
    let fmp = _prefixId.prefix "fmp"
    /// <summary>
    ///   <para>rdfs:label : Funder</para>
    ///   <para>mads:code : fnd^^xsd:string</para>
    ///   <para>skos:prefLabel : Funder</para>
    ///   <para>mads:authoritativeLabel : Funder</para>
    ///   <para>skos:notation : fnd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fnd">mrel:fnd</a>
    /// </summary>
    let fnd = _prefixId.prefix "fnd"
    /// <summary>
    ///   <para>skos:notation : fpy^^xsd:string</para>
    ///   <para>skos:prefLabel : First party</para>
    ///   <para>mads:authoritativeLabel : First party</para>
    ///   <para>rdfs:label : First party</para>
    ///   <para>mads:code : fpy^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/fpy">mrel:fpy</a>
    /// </summary>
    let fpy = _prefixId.prefix "fpy"
    /// <summary>
    ///   <para>skos:notation : frg^^xsd:string</para>
    ///   <para>rdfs:label : Forger</para>
    ///   <para>skos:prefLabel : Forger</para>
    ///   <para>mads:authoritativeLabel : Forger</para>
    ///   <para>mads:code : frg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/frg">mrel:frg</a>
    /// </summary>
    let frg = _prefixId.prefix "frg"
    /// <summary>
    ///   <para>skos:prefLabel : Geographic information specialist</para>
    ///   <para>rdfs:label : Geographic information specialist</para>
    ///   <para>mads:code : gis^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Geographic information specialist</para>
    ///   <para>skos:notation : gis^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/gis">mrel:gis</a>
    /// </summary>
    let gis = _prefixId.prefix "gis"
    /// <summary>
    ///   <para>rdfs:label : Host institution</para>
    ///   <para>mads:authoritativeLabel : Host institution</para>
    ///   <para>mads:code : his^^xsd:string</para>
    ///   <para>skos:notation : his^^xsd:string</para>
    ///   <para>skos:prefLabel : Host institution</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/his">mrel:his</a>
    /// </summary>
    let his = _prefixId.prefix "his"
    /// <summary>
    ///   <para>mads:code : hnr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Honoree</para>
    ///   <para>skos:notation : hnr^^xsd:string</para>
    ///   <para>skos:prefLabel : Honoree</para>
    ///   <para>rdfs:label : Honoree</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/hnr">mrel:hnr</a>
    /// </summary>
    let hnr = _prefixId.prefix "hnr"
    /// <summary>
    ///   <para>skos:prefLabel : Host</para>
    ///   <para>mads:authoritativeLabel : Host</para>
    ///   <para>skos:notation : hst^^xsd:string</para>
    ///   <para>mads:code : hst^^xsd:string</para>
    ///   <para>rdfs:label : Host</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/hst">mrel:hst</a>
    /// </summary>
    let hst = _prefixId.prefix "hst"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Illustrator</para>
    ///   <para>skos:prefLabel : Illustrator</para>
    ///   <para>rdfs:label : Illustrator</para>
    ///   <para>skos:notation : ill^^xsd:string</para>
    ///   <para>mads:code : ill^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ill">mrel:ill</a>
    /// </summary>
    let ill = _prefixId.prefix "ill"
    /// <summary>
    ///   <para>skos:prefLabel : Illuminator</para>
    ///   <para>mads:code : ilu^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Illuminator</para>
    ///   <para>skos:notation : ilu^^xsd:string</para>
    ///   <para>rdfs:label : Illuminator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ilu">mrel:ilu</a>
    /// </summary>
    let ilu = _prefixId.prefix "ilu"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Inscriber</para>
    ///   <para>skos:prefLabel : Inscriber</para>
    ///   <para>rdfs:label : Inscriber</para>
    ///   <para>mads:code : ins^^xsd:string</para>
    ///   <para>skos:notation : ins^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ins">mrel:ins</a>
    /// </summary>
    let ins = _prefixId.prefix "ins"
    /// <summary>
    ///   <para>skos:notation : inv^^xsd:string</para>
    ///   <para>rdfs:label : Inventor</para>
    ///   <para>skos:prefLabel : Inventor</para>
    ///   <para>mads:code : inv^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Inventor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/inv">mrel:inv</a>
    /// </summary>
    let inv = _prefixId.prefix "inv"
    /// <summary>
    ///   <para>skos:prefLabel : Issuing body</para>
    ///   <para>rdfs:label : Issuing body</para>
    ///   <para>mads:code : isb^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Issuing body</para>
    ///   <para>skos:notation : isb^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/isb">mrel:isb</a>
    /// </summary>
    let isb = _prefixId.prefix "isb"
    /// <summary>
    ///   <para>skos:notation : itr^^xsd:string</para>
    ///   <para>mads:code : itr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Instrumentalist</para>
    ///   <para>rdfs:label : Instrumentalist</para>
    ///   <para>skos:prefLabel : Instrumentalist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/itr">mrel:itr</a>
    /// </summary>
    let itr = _prefixId.prefix "itr"
    /// <summary>
    ///   <para>skos:notation : ive^^xsd:string</para>
    ///   <para>skos:prefLabel : Interviewee</para>
    ///   <para>mads:authoritativeLabel : Interviewee</para>
    ///   <para>rdfs:label : Interviewee</para>
    ///   <para>mads:code : ive^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ive">mrel:ive</a>
    /// </summary>
    let ive = _prefixId.prefix "ive"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Interviewer</para>
    ///   <para>skos:prefLabel : Interviewer</para>
    ///   <para>skos:notation : ivr^^xsd:string</para>
    ///   <para>rdfs:label : Interviewer</para>
    ///   <para>mads:code : ivr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ivr">mrel:ivr</a>
    /// </summary>
    let ivr = _prefixId.prefix "ivr"
    /// <summary>
    ///   <para>mads:code : jud^^xsd:string</para>
    ///   <para>rdfs:label : Judge</para>
    ///   <para>skos:prefLabel : Judge</para>
    ///   <para>skos:notation : jud^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Judge</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/jud">mrel:jud</a>
    /// </summary>
    let jud = _prefixId.prefix "jud"
    /// <summary>
    ///   <para>mads:code : jug^^xsd:string</para>
    ///   <para>skos:notation : jug^^xsd:string</para>
    ///   <para>skos:prefLabel : Jurisdiction governed</para>
    ///   <para>mads:authoritativeLabel : Jurisdiction governed</para>
    ///   <para>rdfs:label : Jurisdiction governed</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/jug">mrel:jug</a>
    /// </summary>
    let jug = _prefixId.prefix "jug"
    /// <summary>
    ///   <para>mads:code : lbr^^xsd:string</para>
    ///   <para>rdfs:label : Laboratory</para>
    ///   <para>skos:prefLabel : Laboratory</para>
    ///   <para>mads:authoritativeLabel : Laboratory</para>
    ///   <para>skos:notation : lbr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lbr">mrel:lbr</a>
    /// </summary>
    let lbr = _prefixId.prefix "lbr"
    /// <summary>
    ///   <para>mads:code : lbt^^xsd:string</para>
    ///   <para>skos:prefLabel : Librettist</para>
    ///   <para>mads:authoritativeLabel : Librettist</para>
    ///   <para>rdfs:label : Librettist</para>
    ///   <para>skos:notation : lbt^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lbt">mrel:lbt</a>
    /// </summary>
    let lbt = _prefixId.prefix "lbt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Laboratory director</para>
    ///   <para>skos:prefLabel : Laboratory director</para>
    ///   <para>rdfs:label : Laboratory director</para>
    ///   <para>mads:code : ldr^^xsd:string</para>
    ///   <para>skos:notation : ldr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ldr">mrel:ldr</a>
    /// </summary>
    let ldr = _prefixId.prefix "ldr"
    /// <summary>
    ///   <para>mads:code : led^^xsd:string</para>
    ///   <para>skos:prefLabel : Lead</para>
    ///   <para>mads:authoritativeLabel : Lead</para>
    ///   <para>skos:notation : led^^xsd:string</para>
    ///   <para>rdfs:label : Lead</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/led">mrel:led</a>
    /// </summary>
    let led = _prefixId.prefix "led"
    /// <summary>
    ///   <para>skos:prefLabel : Libelee-appellee</para>
    ///   <para>skos:notation : lee^^xsd:string</para>
    ///   <para>rdfs:label : Libelee-appellee</para>
    ///   <para>mads:authoritativeLabel : Libelee-appellee</para>
    ///   <para>mads:code : lee^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lee">mrel:lee</a>
    /// </summary>
    let lee = _prefixId.prefix "lee"
    let lei = _prefixId.prefix "lei"
    /// <summary>
    ///   <para>skos:prefLabel : Libelee</para>
    ///   <para>rdfs:label : Libelee</para>
    ///   <para>mads:authoritativeLabel : Libelee</para>
    ///   <para>mads:code : lel^^xsd:string</para>
    ///   <para>skos:notation : lel^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lel">mrel:lel</a>
    /// </summary>
    let lel = _prefixId.prefix "lel"
    /// <summary>
    ///   <para>mads:code : len^^xsd:string</para>
    ///   <para>skos:prefLabel : Lender</para>
    ///   <para>rdfs:label : Lender</para>
    ///   <para>skos:notation : len^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Lender</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/len">mrel:len</a>
    /// </summary>
    let len = _prefixId.prefix "len"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Libelee-appellant</para>
    ///   <para>mads:code : let^^xsd:string</para>
    ///   <para>rdfs:label : Libelee-appellant</para>
    ///   <para>skos:notation : let^^xsd:string</para>
    ///   <para>skos:prefLabel : Libelee-appellant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/let">mrel:let</a>
    /// </summary>
    let let_ = _prefixId.prefix "let"
    /// <summary>
    ///   <para>rdfs:label : Lighting designer</para>
    ///   <para>mads:authoritativeLabel : Lighting designer</para>
    ///   <para>skos:prefLabel : Lighting designer</para>
    ///   <para>mads:code : lgd^^xsd:string</para>
    ///   <para>skos:notation : lgd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lgd">mrel:lgd</a>
    /// </summary>
    let lgd = _prefixId.prefix "lgd"
    /// <summary>
    ///   <para>mads:code : lie^^xsd:string</para>
    ///   <para>skos:notation : lie^^xsd:string</para>
    ///   <para>skos:prefLabel : Libelant-appellee</para>
    ///   <para>mads:authoritativeLabel : Libelant-appellee</para>
    ///   <para>rdfs:label : Libelant-appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lie">mrel:lie</a>
    /// </summary>
    let lie = _prefixId.prefix "lie"
    /// <summary>
    ///   <para>rdfs:label : Libelant</para>
    ///   <para>mads:authoritativeLabel : Libelant</para>
    ///   <para>mads:code : lil^^xsd:string</para>
    ///   <para>skos:prefLabel : Libelant</para>
    ///   <para>skos:notation : lil^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lil">mrel:lil</a>
    /// </summary>
    let lil = _prefixId.prefix "lil"
    /// <summary>
    ///   <para>skos:notation : lit^^xsd:string</para>
    ///   <para>mads:code : lit^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Libelant-appellant</para>
    ///   <para>rdfs:label : Libelant-appellant</para>
    ///   <para>skos:prefLabel : Libelant-appellant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lit">mrel:lit</a>
    /// </summary>
    let lit = _prefixId.prefix "lit"
    /// <summary>
    ///   <para>mads:code : lsa^^xsd:string</para>
    ///   <para>skos:notation : lsa^^xsd:string</para>
    ///   <para>skos:prefLabel : Landscape architect</para>
    ///   <para>mads:authoritativeLabel : Landscape architect</para>
    ///   <para>rdfs:label : Landscape architect</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lsa">mrel:lsa</a>
    /// </summary>
    let lsa = _prefixId.prefix "lsa"
    /// <summary>
    ///   <para>skos:notation : lse^^xsd:string</para>
    ///   <para>skos:prefLabel : Licensee</para>
    ///   <para>rdfs:label : Licensee</para>
    ///   <para>mads:authoritativeLabel : Licensee</para>
    ///   <para>mads:code : lse^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lse">mrel:lse</a>
    /// </summary>
    let lse = _prefixId.prefix "lse"
    /// <summary>
    ///   <para>skos:notation : lso^^xsd:string</para>
    ///   <para>rdfs:label : Licensor</para>
    ///   <para>skos:prefLabel : Licensor</para>
    ///   <para>mads:authoritativeLabel : Licensor</para>
    ///   <para>mads:code : lso^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lso">mrel:lso</a>
    /// </summary>
    let lso = _prefixId.prefix "lso"
    /// <summary>
    ///   <para>skos:notation : ltg^^xsd:string</para>
    ///   <para>rdfs:label : Lithographer</para>
    ///   <para>mads:authoritativeLabel : Lithographer</para>
    ///   <para>mads:code : ltg^^xsd:string</para>
    ///   <para>skos:prefLabel : Lithographer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ltg">mrel:ltg</a>
    /// </summary>
    let ltg = _prefixId.prefix "ltg"
    /// <summary>
    ///   <para>skos:prefLabel : Lyricist</para>
    ///   <para>mads:authoritativeLabel : Lyricist</para>
    ///   <para>rdfs:label : Lyricist</para>
    ///   <para>skos:notation : lyr^^xsd:string</para>
    ///   <para>mads:code : lyr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/lyr">mrel:lyr</a>
    /// </summary>
    let lyr = _prefixId.prefix "lyr"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Music copyist</para>
    ///   <para>skos:notation : mcp^^xsd:string</para>
    ///   <para>skos:prefLabel : Music copyist</para>
    ///   <para>mads:code : mcp^^xsd:string</para>
    ///   <para>rdfs:label : Music copyist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mcp">mrel:mcp</a>
    /// </summary>
    let mcp = _prefixId.prefix "mcp"
    /// <summary>
    ///   <para>rdfs:label : Metadata contact</para>
    ///   <para>skos:notation : mdc^^xsd:string</para>
    ///   <para>skos:prefLabel : Metadata contact</para>
    ///   <para>mads:authoritativeLabel : Metadata contact</para>
    ///   <para>mads:code : mdc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mdc">mrel:mdc</a>
    /// </summary>
    let mdc = _prefixId.prefix "mdc"
    /// <summary>
    ///   <para>skos:prefLabel : Medium</para>
    ///   <para>mads:authoritativeLabel : Medium</para>
    ///   <para>skos:notation : med^^xsd:string</para>
    ///   <para>rdfs:label : Medium</para>
    ///   <para>mads:code : med^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/med">mrel:med</a>
    /// </summary>
    let med = _prefixId.prefix "med"
    /// <summary>
    ///   <para>skos:notation : mfp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Manufacture place</para>
    ///   <para>skos:prefLabel : Manufacture place</para>
    ///   <para>mads:code : mfp^^xsd:string</para>
    ///   <para>rdfs:label : Manufacture place</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mfp">mrel:mfp</a>
    /// </summary>
    let mfp = _prefixId.prefix "mfp"
    /// <summary>
    ///   <para>skos:notation : mfr^^xsd:string</para>
    ///   <para>mads:code : mfr^^xsd:string</para>
    ///   <para>rdfs:label : Manufacturer</para>
    ///   <para>skos:prefLabel : Manufacturer</para>
    ///   <para>mads:authoritativeLabel : Manufacturer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mfr">mrel:mfr</a>
    /// </summary>
    let mfr = _prefixId.prefix "mfr"
    /// <summary>
    ///   <para>rdfs:label : Moderator</para>
    ///   <para>mads:authoritativeLabel : Moderator</para>
    ///   <para>skos:prefLabel : Moderator</para>
    ///   <para>skos:notation : mod^^xsd:string</para>
    ///   <para>mads:code : mod^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mod">mrel:mod</a>
    /// </summary>
    let mod_ = _prefixId.prefix "mod"
    /// <summary>
    ///   <para>skos:prefLabel : Monitor</para>
    ///   <para>rdfs:label : Monitor</para>
    ///   <para>mads:code : mon^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Monitor</para>
    ///   <para>skos:notation : mon^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mon">mrel:mon</a>
    /// </summary>
    let mon = _prefixId.prefix "mon"
    /// <summary>
    ///   <para>rdfs:label : Marbler</para>
    ///   <para>mads:authoritativeLabel : Marbler</para>
    ///   <para>skos:prefLabel : Marbler</para>
    ///   <para>skos:notation : mrb^^xsd:string</para>
    ///   <para>mads:code : mrb^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mrb">mrel:mrb</a>
    /// </summary>
    let mrb = _prefixId.prefix "mrb"
    /// <summary>
    ///   <para>mads:code : mrk^^xsd:string</para>
    ///   <para>skos:notation : mrk^^xsd:string</para>
    ///   <para>skos:prefLabel : Markup editor</para>
    ///   <para>rdfs:label : Markup editor</para>
    ///   <para>mads:authoritativeLabel : Markup editor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mrk">mrel:mrk</a>
    /// </summary>
    let mrk = _prefixId.prefix "mrk"
    /// <summary>
    ///   <para>skos:notation : msd^^xsd:string</para>
    ///   <para>rdfs:label : Musical director</para>
    ///   <para>skos:prefLabel : Musical director</para>
    ///   <para>mads:code : msd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Musical director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/msd">mrel:msd</a>
    /// </summary>
    let msd = _prefixId.prefix "msd"
    /// <summary>
    ///   <para>skos:prefLabel : Metal-engraver</para>
    ///   <para>skos:notation : mte^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Metal-engraver</para>
    ///   <para>mads:code : mte^^xsd:string</para>
    ///   <para>rdfs:label : Metal-engraver</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mte">mrel:mte</a>
    /// </summary>
    let mte = _prefixId.prefix "mte"
    /// <summary>
    ///   <para>rdfs:label : Minute taker</para>
    ///   <para>mads:authoritativeLabel : Minute taker</para>
    ///   <para>skos:prefLabel : Minute taker</para>
    ///   <para>skos:notation : mtk^^xsd:string</para>
    ///   <para>mads:code : mtk^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mtk">mrel:mtk</a>
    /// </summary>
    let mtk = _prefixId.prefix "mtk"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Musician</para>
    ///   <para>mads:code : mus^^xsd:string</para>
    ///   <para>skos:notation : mus^^xsd:string</para>
    ///   <para>rdfs:label : Musician</para>
    ///   <para>skos:prefLabel : Musician</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/mus">mrel:mus</a>
    /// </summary>
    let mus = _prefixId.prefix "mus"
    /// <summary>
    ///   <para>skos:prefLabel : Narrator</para>
    ///   <para>rdfs:label : Narrator</para>
    ///   <para>skos:notation : nrt^^xsd:string</para>
    ///   <para>mads:code : nrt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Narrator</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/nrt">mrel:nrt</a>
    /// </summary>
    let nrt = _prefixId.prefix "nrt"
    /// <summary>
    ///   <para>skos:notation : opn^^xsd:string</para>
    ///   <para>mads:code : opn^^xsd:string</para>
    ///   <para>rdfs:label : Opponent</para>
    ///   <para>mads:authoritativeLabel : Opponent</para>
    ///   <para>skos:prefLabel : Opponent</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/opn">mrel:opn</a>
    /// </summary>
    let opn = _prefixId.prefix "opn"
    /// <summary>
    ///   <para>rdfs:label : Originator</para>
    ///   <para>mads:code : org^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Originator</para>
    ///   <para>skos:prefLabel : Originator</para>
    ///   <para>skos:notation : org^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/org">mrel:org</a>
    /// </summary>
    let org = _prefixId.prefix "org"
    /// <summary>
    ///   <para>mads:code : orm^^xsd:string</para>
    ///   <para>skos:prefLabel : Organizer</para>
    ///   <para>skos:notation : orm^^xsd:string</para>
    ///   <para>rdfs:label : Organizer</para>
    ///   <para>mads:authoritativeLabel : Organizer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/orm">mrel:orm</a>
    /// </summary>
    let orm = _prefixId.prefix "orm"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Onscreen presenter</para>
    ///   <para>skos:notation : osp^^xsd:string</para>
    ///   <para>skos:prefLabel : Onscreen presenter</para>
    ///   <para>rdfs:label : Onscreen presenter</para>
    ///   <para>mads:code : osp^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/osp">mrel:osp</a>
    /// </summary>
    let osp = _prefixId.prefix "osp"
    /// <summary>
    ///   <para>skos:notation : oth^^xsd:string</para>
    ///   <para>skos:prefLabel : Other</para>
    ///   <para>mads:authoritativeLabel : Other</para>
    ///   <para>mads:code : oth^^xsd:string</para>
    ///   <para>rdfs:label : Other</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/oth">mrel:oth</a>
    /// </summary>
    let oth = _prefixId.prefix "oth"
    /// <summary>
    ///   <para>skos:prefLabel : Owner</para>
    ///   <para>rdfs:label : Owner</para>
    ///   <para>mads:code : own^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Owner</para>
    ///   <para>skos:notation : own^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/own">mrel:own</a>
    /// </summary>
    let own = _prefixId.prefix "own"
    /// <summary>
    ///   <para>mads:code : pan^^xsd:string</para>
    ///   <para>skos:prefLabel : Panelist</para>
    ///   <para>rdfs:label : Panelist</para>
    ///   <para>mads:authoritativeLabel : Panelist</para>
    ///   <para>skos:notation : pan^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pan">mrel:pan</a>
    /// </summary>
    let pan = _prefixId.prefix "pan"
    /// <summary>
    ///   <para>mads:code : pat^^xsd:string</para>
    ///   <para>skos:notation : pat^^xsd:string</para>
    ///   <para>rdfs:label : Patron</para>
    ///   <para>skos:prefLabel : Patron</para>
    ///   <para>mads:authoritativeLabel : Patron</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pat">mrel:pat</a>
    /// </summary>
    let pat = _prefixId.prefix "pat"
    /// <summary>
    ///   <para>skos:prefLabel : Publishing director</para>
    ///   <para>mads:authoritativeLabel : Publishing director</para>
    ///   <para>mads:code : pbd^^xsd:string</para>
    ///   <para>rdfs:label : Publishing director</para>
    ///   <para>skos:notation : pbd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pbd">mrel:pbd</a>
    /// </summary>
    let pbd = _prefixId.prefix "pbd"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Publisher</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>mads:code : pbl^^xsd:string</para>
    ///   <para>skos:notation : pbl^^xsd:string</para>
    ///   <para>skos:prefLabel : Publisher</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pbl">mrel:pbl</a>
    /// </summary>
    let pbl = _prefixId.prefix "pbl"
    /// <summary>
    ///   <para>skos:prefLabel : Project director</para>
    ///   <para>mads:code : pdr^^xsd:string</para>
    ///   <para>skos:notation : pdr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Project director</para>
    ///   <para>rdfs:label : Project director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pdr">mrel:pdr</a>
    /// </summary>
    let pdr = _prefixId.prefix "pdr"
    /// <summary>
    ///   <para>skos:prefLabel : Proofreader</para>
    ///   <para>mads:authoritativeLabel : Proofreader</para>
    ///   <para>skos:notation : pfr^^xsd:string</para>
    ///   <para>mads:code : pfr^^xsd:string</para>
    ///   <para>rdfs:label : Proofreader</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pfr">mrel:pfr</a>
    /// </summary>
    let pfr = _prefixId.prefix "pfr"
    /// <summary>
    ///   <para>mads:code : pht^^xsd:string</para>
    ///   <para>skos:notation : pht^^xsd:string</para>
    ///   <para>skos:prefLabel : Photographer</para>
    ///   <para>rdfs:label : Photographer</para>
    ///   <para>mads:authoritativeLabel : Photographer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pht">mrel:pht</a>
    /// </summary>
    let pht = _prefixId.prefix "pht"
    /// <summary>
    ///   <para>mads:code : plt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Platemaker</para>
    ///   <para>skos:prefLabel : Platemaker</para>
    ///   <para>skos:notation : plt^^xsd:string</para>
    ///   <para>rdfs:label : Platemaker</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/plt">mrel:plt</a>
    /// </summary>
    let plt = _prefixId.prefix "plt"
    /// <summary>
    ///   <para>rdfs:label : Permitting agency</para>
    ///   <para>mads:authoritativeLabel : Permitting agency</para>
    ///   <para>skos:notation : pma^^xsd:string</para>
    ///   <para>mads:code : pma^^xsd:string</para>
    ///   <para>skos:prefLabel : Permitting agency</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pma">mrel:pma</a>
    /// </summary>
    let pma = _prefixId.prefix "pma"
    /// <summary>
    ///   <para>rdfs:label : Production manager</para>
    ///   <para>skos:prefLabel : Production manager</para>
    ///   <para>skos:notation : pmn^^xsd:string</para>
    ///   <para>mads:code : pmn^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Production manager</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pmn">mrel:pmn</a>
    /// </summary>
    let pmn = _prefixId.prefix "pmn"
    /// <summary>
    ///   <para>mads:code : pop^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Printer of plates</para>
    ///   <para>rdfs:label : Printer of plates</para>
    ///   <para>skos:prefLabel : Printer of plates</para>
    ///   <para>skos:notation : pop^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pop">mrel:pop</a>
    /// </summary>
    let pop = _prefixId.prefix "pop"
    /// <summary>
    ///   <para>skos:prefLabel : Papermaker</para>
    ///   <para>rdfs:label : Papermaker</para>
    ///   <para>mads:authoritativeLabel : Papermaker</para>
    ///   <para>skos:notation : ppm^^xsd:string</para>
    ///   <para>mads:code : ppm^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ppm">mrel:ppm</a>
    /// </summary>
    let ppm = _prefixId.prefix "ppm"
    /// <summary>
    ///   <para>skos:notation : ppt^^xsd:string</para>
    ///   <para>mads:code : ppt^^xsd:string</para>
    ///   <para>rdfs:label : Puppeteer</para>
    ///   <para>skos:prefLabel : Puppeteer</para>
    ///   <para>mads:authoritativeLabel : Puppeteer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ppt">mrel:ppt</a>
    /// </summary>
    let ppt = _prefixId.prefix "ppt"
    /// <summary>
    ///   <para>rdfs:label : Praeses</para>
    ///   <para>mads:authoritativeLabel : Praeses</para>
    ///   <para>skos:prefLabel : Praeses</para>
    ///   <para>skos:notation : pra^^xsd:string</para>
    ///   <para>mads:code : pra^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pra">mrel:pra</a>
    /// </summary>
    let pra = _prefixId.prefix "pra"
    /// <summary>
    ///   <para>skos:notation : prc^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Process contact</para>
    ///   <para>rdfs:label : Process contact</para>
    ///   <para>mads:code : prc^^xsd:string</para>
    ///   <para>skos:prefLabel : Process contact</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prc">mrel:prc</a>
    /// </summary>
    let prc = _prefixId.prefix "prc"
    /// <summary>
    ///   <para>mads:code : prd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Production personnel</para>
    ///   <para>skos:prefLabel : Production personnel</para>
    ///   <para>skos:notation : prd^^xsd:string</para>
    ///   <para>rdfs:label : Production personnel</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prd">mrel:prd</a>
    /// </summary>
    let prd = _prefixId.prefix "prd"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Presenter</para>
    ///   <para>rdfs:label : Presenter</para>
    ///   <para>mads:code : pre^^xsd:string</para>
    ///   <para>skos:prefLabel : Presenter</para>
    ///   <para>skos:notation : pre^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pre">mrel:pre</a>
    /// </summary>
    let pre = _prefixId.prefix "pre"
    /// <summary>
    ///   <para>rdfs:label : Performer</para>
    ///   <para>skos:prefLabel : Performer</para>
    ///   <para>mads:authoritativeLabel : Performer</para>
    ///   <para>skos:notation : prf^^xsd:string</para>
    ///   <para>mads:code : prf^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prf">mrel:prf</a>
    /// </summary>
    let prf = _prefixId.prefix "prf"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Programmer</para>
    ///   <para>skos:notation : prg^^xsd:string</para>
    ///   <para>skos:prefLabel : Programmer</para>
    ///   <para>rdfs:label : Programmer</para>
    ///   <para>mads:code : prg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prg">mrel:prg</a>
    /// </summary>
    let prg = _prefixId.prefix "prg"
    /// <summary>
    ///   <para>rdfs:label : Printmaker</para>
    ///   <para>skos:prefLabel : Printmaker</para>
    ///   <para>mads:code : prm^^xsd:string</para>
    ///   <para>skos:notation : prm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Printmaker</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prm">mrel:prm</a>
    /// </summary>
    let prm = _prefixId.prefix "prm"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Production company</para>
    ///   <para>rdfs:label : Production company</para>
    ///   <para>skos:notation : prn^^xsd:string</para>
    ///   <para>skos:prefLabel : Production company</para>
    ///   <para>mads:code : prn^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prn">mrel:prn</a>
    /// </summary>
    let prn = _prefixId.prefix "prn"
    /// <summary>
    ///   <para>skos:notation : pro^^xsd:string</para>
    ///   <para>rdfs:label : Producer</para>
    ///   <para>mads:authoritativeLabel : Producer</para>
    ///   <para>skos:prefLabel : Producer</para>
    ///   <para>mads:code : pro^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pro">mrel:pro</a>
    /// </summary>
    let pro = _prefixId.prefix "pro"
    /// <summary>
    ///   <para>skos:prefLabel : Production place</para>
    ///   <para>skos:notation : prp^^xsd:string</para>
    ///   <para>mads:code : prp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Production place</para>
    ///   <para>rdfs:label : Production place</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prp">mrel:prp</a>
    /// </summary>
    let prp = _prefixId.prefix "prp"
    /// <summary>
    ///   <para>skos:notation : prs^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Production designer</para>
    ///   <para>mads:code : prs^^xsd:string</para>
    ///   <para>rdfs:label : Production designer</para>
    ///   <para>skos:prefLabel : Production designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prs">mrel:prs</a>
    /// </summary>
    let prs = _prefixId.prefix "prs"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Printer</para>
    ///   <para>rdfs:label : Printer</para>
    ///   <para>mads:code : prt^^xsd:string</para>
    ///   <para>skos:notation : prt^^xsd:string</para>
    ///   <para>skos:prefLabel : Printer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prt">mrel:prt</a>
    /// </summary>
    let prt = _prefixId.prefix "prt"
    /// <summary>
    ///   <para>skos:prefLabel : Provider</para>
    ///   <para>rdfs:label : Provider</para>
    ///   <para>skos:notation : prv^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Provider</para>
    ///   <para>mads:code : prv^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/prv">mrel:prv</a>
    /// </summary>
    let prv = _prefixId.prefix "prv"
    /// <summary>
    ///   <para>rdfs:label : Patent applicant</para>
    ///   <para>mads:code : pta^^xsd:string</para>
    ///   <para>skos:prefLabel : Patent applicant</para>
    ///   <para>skos:notation : pta^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Patent applicant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pta">mrel:pta</a>
    /// </summary>
    let pta = _prefixId.prefix "pta"
    /// <summary>
    ///   <para>rdfs:label : Plaintiff-appellee</para>
    ///   <para>skos:prefLabel : Plaintiff-appellee</para>
    ///   <para>mads:code : pte^^xsd:string</para>
    ///   <para>skos:notation : pte^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Plaintiff-appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pte">mrel:pte</a>
    /// </summary>
    let pte = _prefixId.prefix "pte"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Plaintiff</para>
    ///   <para>mads:code : ptf^^xsd:string</para>
    ///   <para>skos:prefLabel : Plaintiff</para>
    ///   <para>skos:notation : ptf^^xsd:string</para>
    ///   <para>rdfs:label : Plaintiff</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ptf">mrel:ptf</a>
    /// </summary>
    let ptf = _prefixId.prefix "ptf"
    /// <summary>
    ///   <para>skos:notation : pth^^xsd:string</para>
    ///   <para>rdfs:label : Patent holder</para>
    ///   <para>mads:code : pth^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Patent holder</para>
    ///   <para>skos:prefLabel : Patent holder</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pth">mrel:pth</a>
    /// </summary>
    let pth = _prefixId.prefix "pth"
    /// <summary>
    ///   <para>mads:code : ptt^^xsd:string</para>
    ///   <para>skos:prefLabel : Plaintiff-appellant</para>
    ///   <para>skos:notation : ptt^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Plaintiff-appellant</para>
    ///   <para>rdfs:label : Plaintiff-appellant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ptt">mrel:ptt</a>
    /// </summary>
    let ptt = _prefixId.prefix "ptt"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Publication place</para>
    ///   <para>mads:code : pup^^xsd:string</para>
    ///   <para>skos:notation : pup^^xsd:string</para>
    ///   <para>skos:prefLabel : Publication place</para>
    ///   <para>rdfs:label : Publication place</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/pup">mrel:pup</a>
    /// </summary>
    let pup = _prefixId.prefix "pup"
    /// <summary>
    ///   <para>rdfs:label : Rubricator</para>
    ///   <para>mads:code : rbr^^xsd:string</para>
    ///   <para>skos:prefLabel : Rubricator</para>
    ///   <para>mads:authoritativeLabel : Rubricator</para>
    ///   <para>skos:notation : rbr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rbr">mrel:rbr</a>
    /// </summary>
    let rbr = _prefixId.prefix "rbr"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Recordist</para>
    ///   <para>skos:prefLabel : Recordist</para>
    ///   <para>rdfs:label : Recordist</para>
    ///   <para>skos:notation : rcd^^xsd:string</para>
    ///   <para>mads:code : rcd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rcd">mrel:rcd</a>
    /// </summary>
    let rcd = _prefixId.prefix "rcd"
    /// <summary>
    ///   <para>skos:prefLabel : Recording engineer</para>
    ///   <para>skos:notation : rce^^xsd:string</para>
    ///   <para>mads:code : rce^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Recording engineer</para>
    ///   <para>rdfs:label : Recording engineer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rce">mrel:rce</a>
    /// </summary>
    let rce = _prefixId.prefix "rce"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Addressee</para>
    ///   <para>skos:notation : rcp^^xsd:string</para>
    ///   <para>mads:code : rcp^^xsd:string</para>
    ///   <para>rdfs:label : Addressee</para>
    ///   <para>skos:prefLabel : Addressee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rcp">mrel:rcp</a>
    /// </summary>
    let rcp = _prefixId.prefix "rcp"
    /// <summary>
    ///   <para>skos:notation : rdd^^xsd:string</para>
    ///   <para>rdfs:label : Radio director</para>
    ///   <para>skos:prefLabel : Radio director</para>
    ///   <para>mads:code : rdd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Radio director</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rdd">mrel:rdd</a>
    /// </summary>
    let rdd = _prefixId.prefix "rdd"
    /// <summary>
    ///   <para>rdfs:label : Redaktor</para>
    ///   <para>mads:code : red^^xsd:string</para>
    ///   <para>skos:notation : red^^xsd:string</para>
    ///   <para>skos:prefLabel : Redaktor</para>
    ///   <para>mads:authoritativeLabel : Redaktor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/red">mrel:red</a>
    /// </summary>
    let red = _prefixId.prefix "red"
    /// <summary>
    ///   <para>rdfs:label : Renderer</para>
    ///   <para>mads:code : ren^^xsd:string</para>
    ///   <para>skos:notation : ren^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Renderer</para>
    ///   <para>skos:prefLabel : Renderer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ren">mrel:ren</a>
    /// </summary>
    let ren = _prefixId.prefix "ren"
    /// <summary>
    ///   <para>rdfs:label : Researcher</para>
    ///   <para>skos:prefLabel : Researcher</para>
    ///   <para>skos:notation : res^^xsd:string</para>
    ///   <para>mads:code : res^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Researcher</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/res">mrel:res</a>
    /// </summary>
    let res = _prefixId.prefix "res"
    /// <summary>
    ///   <para>skos:notation : rev^^xsd:string</para>
    ///   <para>skos:prefLabel : Reviewer</para>
    ///   <para>mads:code : rev^^xsd:string</para>
    ///   <para>rdfs:label : Reviewer</para>
    ///   <para>mads:authoritativeLabel : Reviewer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rev">mrel:rev</a>
    /// </summary>
    let rev = _prefixId.prefix "rev"
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>mads:code : rpc^^xsd:string</para>
    ///   <para>rdfs:label : Radio producer</para>
    ///   <para>skos:notation : rpc^^xsd:string</para>
    ///   <para>skos:prefLabel : Radio producer</para>
    ///   <para>mads:authoritativeLabel : Radio producer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rpc">mrel:rpc</a>
    /// </summary>
    let rpc = _prefixId.prefix "rpc"
    /// <summary>
    ///   <para>skos:notation : rps^^xsd:string</para>
    ///   <para>rdfs:label : Repository</para>
    ///   <para>skos:prefLabel : Repository</para>
    ///   <para>mads:authoritativeLabel : Repository</para>
    ///   <para>mads:code : rps^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rps">mrel:rps</a>
    /// </summary>
    let rps = _prefixId.prefix "rps"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Reporter</para>
    ///   <para>skos:notation : rpt^^xsd:string</para>
    ///   <para>skos:prefLabel : Reporter</para>
    ///   <para>mads:code : rpt^^xsd:string</para>
    ///   <para>rdfs:label : Reporter</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rpt">mrel:rpt</a>
    /// </summary>
    let rpt = _prefixId.prefix "rpt"
    /// <summary>
    ///   <para>skos:prefLabel : Responsible party</para>
    ///   <para>mads:authoritativeLabel : Responsible party</para>
    ///   <para>mads:code : rpy^^xsd:string</para>
    ///   <para>skos:notation : rpy^^xsd:string</para>
    ///   <para>rdfs:label : Responsible party</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rpy">mrel:rpy</a>
    /// </summary>
    let rpy = _prefixId.prefix "rpy"
    /// <summary>
    ///   <para>skos:notation : rse^^xsd:string</para>
    ///   <para>mads:code : rse^^xsd:string</para>
    ///   <para>rdfs:label : Respondent-appellee</para>
    ///   <para>mads:authoritativeLabel : Respondent-appellee</para>
    ///   <para>skos:prefLabel : Respondent-appellee</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rse">mrel:rse</a>
    /// </summary>
    let rse = _prefixId.prefix "rse"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Restager</para>
    ///   <para>skos:notation : rsg^^xsd:string</para>
    ///   <para>skos:prefLabel : Restager</para>
    ///   <para>mads:code : rsg^^xsd:string</para>
    ///   <para>rdfs:label : Restager</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rsg">mrel:rsg</a>
    /// </summary>
    let rsg = _prefixId.prefix "rsg"
    /// <summary>
    ///   <para>rdfs:label : Respondent</para>
    ///   <para>skos:prefLabel : Respondent</para>
    ///   <para>skos:notation : rsp^^xsd:string</para>
    ///   <para>mads:code : rsp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Respondent</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rsp">mrel:rsp</a>
    /// </summary>
    let rsp = _prefixId.prefix "rsp"
    /// <summary>
    ///   <para>skos:prefLabel : Restorationist</para>
    ///   <para>rdfs:label : Restorationist</para>
    ///   <para>mads:code : rsr^^xsd:string</para>
    ///   <para>skos:notation : rsr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Restorationist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rsr">mrel:rsr</a>
    /// </summary>
    let rsr = _prefixId.prefix "rsr"
    /// <summary>
    ///   <para>skos:prefLabel : Respondent-appellant</para>
    ///   <para>mads:authoritativeLabel : Respondent-appellant</para>
    ///   <para>mads:code : rst^^xsd:string</para>
    ///   <para>skos:notation : rst^^xsd:string</para>
    ///   <para>rdfs:label : Respondent-appellant</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rst">mrel:rst</a>
    /// </summary>
    let rst = _prefixId.prefix "rst"
    /// <summary>
    ///   <para>skos:notation : rth^^xsd:string</para>
    ///   <para>rdfs:label : Research team head</para>
    ///   <para>skos:prefLabel : Research team head</para>
    ///   <para>mads:code : rth^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Research team head</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rth">mrel:rth</a>
    /// </summary>
    let rth = _prefixId.prefix "rth"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Research team member</para>
    ///   <para>skos:notation : rtm^^xsd:string</para>
    ///   <para>rdfs:label : Research team member</para>
    ///   <para>skos:prefLabel : Research team member</para>
    ///   <para>mads:code : rtm^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/rtm">mrel:rtm</a>
    /// </summary>
    let rtm = _prefixId.prefix "rtm"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Scientific advisor</para>
    ///   <para>skos:prefLabel : Scientific advisor</para>
    ///   <para>mads:code : sad^^xsd:string</para>
    ///   <para>rdfs:label : Scientific advisor</para>
    ///   <para>skos:notation : sad^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sad">mrel:sad</a>
    /// </summary>
    let sad = _prefixId.prefix "sad"
    /// <summary>
    ///   <para>rdfs:label : Scenarist</para>
    ///   <para>skos:prefLabel : Scenarist</para>
    ///   <para>skos:notation : sce^^xsd:string</para>
    ///   <para>mads:code : sce^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Scenarist</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sce">mrel:sce</a>
    /// </summary>
    let sce = _prefixId.prefix "sce"
    /// <summary>
    ///   <para>skos:notation : scl^^xsd:string</para>
    ///   <para>mads:code : scl^^xsd:string</para>
    ///   <para>skos:prefLabel : Sculptor</para>
    ///   <para>mads:authoritativeLabel : Sculptor</para>
    ///   <para>rdfs:label : Sculptor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/scl">mrel:scl</a>
    /// </summary>
    let scl = _prefixId.prefix "scl"
    /// <summary>
    ///   <para>rdfs:label : Scribe</para>
    ///   <para>mads:code : scr^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Scribe</para>
    ///   <para>skos:notation : scr^^xsd:string</para>
    ///   <para>skos:prefLabel : Scribe</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/scr">mrel:scr</a>
    /// </summary>
    let scr = _prefixId.prefix "scr"
    /// <summary>
    ///   <para>skos:notation : sds^^xsd:string</para>
    ///   <para>skos:prefLabel : Sound designer</para>
    ///   <para>mads:code : sds^^xsd:string</para>
    ///   <para>rdfs:label : Sound designer</para>
    ///   <para>mads:authoritativeLabel : Sound designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sds">mrel:sds</a>
    /// </summary>
    let sds = _prefixId.prefix "sds"
    /// <summary>
    ///   <para>skos:prefLabel : Secretary</para>
    ///   <para>skos:notation : sec^^xsd:string</para>
    ///   <para>rdfs:label : Secretary</para>
    ///   <para>mads:code : sec^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Secretary</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sec">mrel:sec</a>
    /// </summary>
    let sec = _prefixId.prefix "sec"
    /// <summary>
    ///   <para>mads:code : sgd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Stage director</para>
    ///   <para>rdfs:label : Stage director</para>
    ///   <para>skos:prefLabel : Stage director</para>
    ///   <para>skos:notation : sgd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sgd">mrel:sgd</a>
    /// </summary>
    let sgd = _prefixId.prefix "sgd"
    /// <summary>
    ///   <para>skos:notation : sgn^^xsd:string</para>
    ///   <para>skos:prefLabel : Signer</para>
    ///   <para>mads:code : sgn^^xsd:string</para>
    ///   <para>rdfs:label : Signer</para>
    ///   <para>mads:authoritativeLabel : Signer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sgn">mrel:sgn</a>
    /// </summary>
    let sgn = _prefixId.prefix "sgn"
    /// <summary>
    ///   <para>mads:code : sht^^xsd:string</para>
    ///   <para>skos:notation : sht^^xsd:string</para>
    ///   <para>rdfs:label : Supporting host</para>
    ///   <para>mads:authoritativeLabel : Supporting host</para>
    ///   <para>skos:prefLabel : Supporting host</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sht">mrel:sht</a>
    /// </summary>
    let sht = _prefixId.prefix "sht"
    /// <summary>
    ///   <para>mads:code : sll^^xsd:string</para>
    ///   <para>rdfs:label : Seller</para>
    ///   <para>mads:authoritativeLabel : Seller</para>
    ///   <para>skos:notation : sll^^xsd:string</para>
    ///   <para>skos:prefLabel : Seller</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sll">mrel:sll</a>
    /// </summary>
    let sll = _prefixId.prefix "sll"
    /// <summary>
    ///   <para>rdfs:label : Singer</para>
    ///   <para>mads:code : sng^^xsd:string</para>
    ///   <para>skos:prefLabel : Singer</para>
    ///   <para>skos:notation : sng^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Singer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/sng">mrel:sng</a>
    /// </summary>
    let sng = _prefixId.prefix "sng"
    /// <summary>
    ///   <para>skos:prefLabel : Speaker</para>
    ///   <para>mads:authoritativeLabel : Speaker</para>
    ///   <para>rdfs:label : Speaker</para>
    ///   <para>mads:code : spk^^xsd:string</para>
    ///   <para>skos:notation : spk^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/spk">mrel:spk</a>
    /// </summary>
    let spk = _prefixId.prefix "spk"
    /// <summary>
    ///   <para>rdfs:label : Sponsor</para>
    ///   <para>mads:code : spn^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Sponsor</para>
    ///   <para>skos:prefLabel : Sponsor</para>
    ///   <para>skos:notation : spn^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/spn">mrel:spn</a>
    /// </summary>
    let spn = _prefixId.prefix "spn"
    /// <summary>
    ///   <para>rdfs:label : Second party</para>
    ///   <para>skos:notation : spy^^xsd:string</para>
    ///   <para>mads:code : spy^^xsd:string</para>
    ///   <para>skos:prefLabel : Second party</para>
    ///   <para>mads:authoritativeLabel : Second party</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/spy">mrel:spy</a>
    /// </summary>
    let spy = _prefixId.prefix "spy"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Surveyor</para>
    ///   <para>skos:notation : srv^^xsd:string</para>
    ///   <para>mads:code : srv^^xsd:string</para>
    ///   <para>skos:prefLabel : Surveyor</para>
    ///   <para>rdfs:label : Surveyor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/srv">mrel:srv</a>
    /// </summary>
    let srv = _prefixId.prefix "srv"
    /// <summary>
    ///   <para>skos:notation : std^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Set designer</para>
    ///   <para>skos:prefLabel : Set designer</para>
    ///   <para>rdfs:label : Set designer</para>
    ///   <para>mads:code : std^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/std">mrel:std</a>
    /// </summary>
    let std = _prefixId.prefix "std"
    /// <summary>
    ///   <para>rdfs:label : Setting</para>
    ///   <para>mads:code : stg^^xsd:string</para>
    ///   <para>skos:notation : stg^^xsd:string</para>
    ///   <para>skos:prefLabel : Setting</para>
    ///   <para>mads:authoritativeLabel : Setting</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/stg">mrel:stg</a>
    /// </summary>
    let stg = _prefixId.prefix "stg"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Storyteller</para>
    ///   <para>skos:prefLabel : Storyteller</para>
    ///   <para>mads:code : stl^^xsd:string</para>
    ///   <para>skos:notation : stl^^xsd:string</para>
    ///   <para>rdfs:label : Storyteller</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/stl">mrel:stl</a>
    /// </summary>
    let stl = _prefixId.prefix "stl"
    /// <summary>
    ///   <para>mads:code : stm^^xsd:string</para>
    ///   <para>skos:prefLabel : Stage manager</para>
    ///   <para>skos:notation : stm^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Stage manager</para>
    ///   <para>rdfs:label : Stage manager</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/stm">mrel:stm</a>
    /// </summary>
    let stm = _prefixId.prefix "stm"
    /// <summary>
    ///   <para>rdfs:label : Standards body</para>
    ///   <para>mads:code : stn^^xsd:string</para>
    ///   <para>skos:notation : stn^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Standards body</para>
    ///   <para>skos:prefLabel : Standards body</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/stn">mrel:stn</a>
    /// </summary>
    let stn = _prefixId.prefix "stn"
    /// <summary>
    ///   <para>skos:notation : str^^xsd:string</para>
    ///   <para>rdfs:label : Stereotyper</para>
    ///   <para>skos:prefLabel : Stereotyper</para>
    ///   <para>mads:authoritativeLabel : Stereotyper</para>
    ///   <para>mads:code : str^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/str">mrel:str</a>
    /// </summary>
    let str = _prefixId.prefix "str"
    /// <summary>
    ///   <para>skos:notation : tcd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Technical director</para>
    ///   <para>skos:prefLabel : Technical director</para>
    ///   <para>rdfs:label : Technical director</para>
    ///   <para>mads:code : tcd^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tcd">mrel:tcd</a>
    /// </summary>
    let tcd = _prefixId.prefix "tcd"
    /// <summary>
    ///   <para>skos:notation : tch^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Teacher</para>
    ///   <para>skos:prefLabel : Teacher</para>
    ///   <para>mads:code : tch^^xsd:string</para>
    ///   <para>rdfs:label : Teacher</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tch">mrel:tch</a>
    /// </summary>
    let tch = _prefixId.prefix "tch"
    /// <summary>
    ///   <para>mads:code : ths^^xsd:string</para>
    ///   <para>rdfs:label : Thesis advisor</para>
    ///   <para>skos:notation : ths^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Thesis advisor</para>
    ///   <para>skos:prefLabel : Thesis advisor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/ths">mrel:ths</a>
    /// </summary>
    let ths = _prefixId.prefix "ths"
    /// <summary>
    ///   <para>skos:prefLabel : Television director</para>
    ///   <para>rdfs:label : Television director</para>
    ///   <para>mads:authoritativeLabel : Television director</para>
    ///   <para>skos:notation : tld^^xsd:string</para>
    ///   <para>mads:code : tld^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tld">mrel:tld</a>
    /// </summary>
    let tld = _prefixId.prefix "tld"
    /// <summary>
    ///   <para>mads:code : tlp^^xsd:string</para>
    ///   <para>rdfs:label : Television producer</para>
    ///   <para>skos:prefLabel : Television producer</para>
    ///   <para>skos:notation : tlp^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Television producer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tlp">mrel:tlp</a>
    /// </summary>
    let tlp = _prefixId.prefix "tlp"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Transcriber</para>
    ///   <para>rdfs:label : Transcriber</para>
    ///   <para>skos:notation : trc^^xsd:string</para>
    ///   <para>skos:prefLabel : Transcriber</para>
    ///   <para>mads:code : trc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/trc">mrel:trc</a>
    /// </summary>
    let trc = _prefixId.prefix "trc"
    /// <summary>
    ///   <para>skos:prefLabel : Translator</para>
    ///   <para>mads:code : trl^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Translator</para>
    ///   <para>rdfs:label : Translator</para>
    ///   <para>skos:notation : trl^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/trl">mrel:trl</a>
    /// </summary>
    let trl = _prefixId.prefix "trl"
    /// <summary>
    ///   <para>mads:code : tyd^^xsd:string</para>
    ///   <para>skos:notation : tyd^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Type designer</para>
    ///   <para>rdfs:label : Type designer</para>
    ///   <para>skos:prefLabel : Type designer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tyd">mrel:tyd</a>
    /// </summary>
    let tyd = _prefixId.prefix "tyd"
    /// <summary>
    ///   <para>mads:code : tyg^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Typographer</para>
    ///   <para>skos:prefLabel : Typographer</para>
    ///   <para>rdfs:label : Typographer</para>
    ///   <para>skos:notation : tyg^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/tyg">mrel:tyg</a>
    /// </summary>
    let tyg = _prefixId.prefix "tyg"
    /// <summary>
    ///   <para>mads:code : uvp^^xsd:string</para>
    ///   <para>skos:notation : uvp^^xsd:string</para>
    ///   <para>rdfs:label : University place</para>
    ///   <para>skos:prefLabel : University place</para>
    ///   <para>mads:authoritativeLabel : University place</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/uvp">mrel:uvp</a>
    /// </summary>
    let uvp = _prefixId.prefix "uvp"
    /// <summary>
    ///   <para>skos:notation : vac^^xsd:string</para>
    ///   <para>skos:prefLabel : Voice actor</para>
    ///   <para>mads:code : vac^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Voice actor</para>
    ///   <para>rdfs:label : Voice actor</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/vac">mrel:vac</a>
    /// </summary>
    let vac = _prefixId.prefix "vac"
    /// <summary>
    ///   <para>rdfs:label : Videographer</para>
    ///   <para>skos:notation : vdg^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Videographer</para>
    ///   <para>mads:code : vdg^^xsd:string</para>
    ///   <para>skos:prefLabel : Videographer</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/vdg">mrel:vdg</a>
    /// </summary>
    let vdg = _prefixId.prefix "vdg"
    /// <summary>
    ///   <para>skos:prefLabel : Writer of added commentary</para>
    ///   <para>skos:notation : wac^^xsd:string</para>
    ///   <para>rdfs:label : Writer of added commentary</para>
    ///   <para>mads:code : wac^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Writer of added commentary</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wac">mrel:wac</a>
    /// </summary>
    let wac = _prefixId.prefix "wac"
    /// <summary>
    ///   <para>rdfs:label : Writer of added lyrics</para>
    ///   <para>mads:code : wal^^xsd:string</para>
    ///   <para>skos:notation : wal^^xsd:string</para>
    ///   <para>skos:prefLabel : Writer of added lyrics</para>
    ///   <para>mads:authoritativeLabel : Writer of added lyrics</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wal">mrel:wal</a>
    /// </summary>
    let wal = _prefixId.prefix "wal"
    /// <summary>
    ///   <para>rdfs:label : Writer of accompanying material</para>
    ///   <para>mads:code : wam^^xsd:string</para>
    ///   <para>skos:notation : wam^^xsd:string</para>
    ///   <para>skos:prefLabel : Writer of accompanying material</para>
    ///   <para>mads:authoritativeLabel : Writer of accompanying material</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wam">mrel:wam</a>
    /// </summary>
    let wam = _prefixId.prefix "wam"
    /// <summary>
    ///   <para>skos:prefLabel : Writer of added text</para>
    ///   <para>mads:authoritativeLabel : Writer of added text</para>
    ///   <para>skos:notation : wat^^xsd:string</para>
    ///   <para>mads:code : wat^^xsd:string</para>
    ///   <para>rdfs:label : Writer of added text</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wat">mrel:wat</a>
    /// </summary>
    let wat = _prefixId.prefix "wat"
    /// <summary>
    ///   <para>skos:notation : wdc^^xsd:string</para>
    ///   <para>skos:prefLabel : Woodcutter</para>
    ///   <para>rdfs:label : Woodcutter</para>
    ///   <para>mads:authoritativeLabel : Woodcutter</para>
    ///   <para>mads:code : wdc^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wdc">mrel:wdc</a>
    /// </summary>
    let wdc = _prefixId.prefix "wdc"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Wood engraver</para>
    ///   <para>skos:prefLabel : Wood engraver</para>
    ///   <para>mads:code : wde^^xsd:string</para>
    ///   <para>skos:notation : wde^^xsd:string</para>
    ///   <para>rdfs:label : Wood engraver</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wde">mrel:wde</a>
    /// </summary>
    let wde = _prefixId.prefix "wde"
    /// <summary>
    ///   <para>mads:authoritativeLabel : Writer of introduction</para>
    ///   <para>skos:prefLabel : Writer of introduction</para>
    ///   <para>rdfs:label : Writer of introduction</para>
    ///   <para>skos:notation : win^^xsd:string</para>
    ///   <para>mads:code : win^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/win">mrel:win</a>
    /// </summary>
    let win = _prefixId.prefix "win"
    /// <summary>
    ///   <para>skos:prefLabel : Witness</para>
    ///   <para>mads:authoritativeLabel : Witness</para>
    ///   <para>rdfs:label : Witness</para>
    ///   <para>mads:code : wit^^xsd:string</para>
    ///   <para>skos:notation : wit^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wit">mrel:wit</a>
    /// </summary>
    let wit = _prefixId.prefix "wit"
    /// <summary>
    ///   <para>skos:prefLabel : Writer of preface</para>
    ///   <para>mads:authoritativeLabel : Writer of preface</para>
    ///   <para>skos:notation : wpr^^xsd:string</para>
    ///   <para>rdfs:label : Writer of preface</para>
    ///   <para>mads:code : wpr^^xsd:string</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wpr">mrel:wpr</a>
    /// </summary>
    let wpr = _prefixId.prefix "wpr"
    /// <summary>
    ///   <para>rdfs:label : Writer of supplementary textual content</para>
    ///   <para>skos:notation : wst^^xsd:string</para>
    ///   <para>skos:prefLabel : Writer of supplementary textual content</para>
    ///   <para>mads:code : wst^^xsd:string</para>
    ///   <para>mads:authoritativeLabel : Writer of supplementary textual content</para>
    ///   <a href="http://id.loc.gov/vocabulary/relators/wst">mrel:wst</a>
    /// </summary>
    let wst = _prefixId.prefix "wst"

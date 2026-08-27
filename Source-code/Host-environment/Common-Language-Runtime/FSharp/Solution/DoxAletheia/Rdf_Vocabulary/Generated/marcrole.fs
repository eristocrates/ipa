namespace http.id.loc.gov.vocabulary.relators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module marcrole =
    let _namespace_iri = Namespace_Iri marcrole |> NamespaceIRI
    /// <summary>
    ///   <para>loc:vocabulary/relators/Author</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/Author">http://id.loc.gov/vocabulary/relators/Author</seealso>
    let Author = Prefixed_Name(marcrole, "Author") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/Editor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/Editor">http://id.loc.gov/vocabulary/relators/Editor</seealso>
    let Editor = Prefixed_Name(marcrole, "Editor") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/abr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Abridger"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/abr">http://id.loc.gov/vocabulary/relators/abr</seealso>
    let abr = Prefixed_Name(marcrole, "abr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/acp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Art copyist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/acp">http://id.loc.gov/vocabulary/relators/acp</seealso>
    let acp = Prefixed_Name(marcrole, "acp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/act</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/act">http://id.loc.gov/vocabulary/relators/act</seealso>
    let act = Prefixed_Name(marcrole, "act") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/adi</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Art director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/adi">http://id.loc.gov/vocabulary/relators/adi</seealso>
    let adi = Prefixed_Name(marcrole, "adi") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/adp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Adapter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/adp">http://id.loc.gov/vocabulary/relators/adp</seealso>
    let adp = Prefixed_Name(marcrole, "adp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aft</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Author of afterword, colophon, etc."</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aft">http://id.loc.gov/vocabulary/relators/aft</seealso>
    let aft = Prefixed_Name(marcrole, "aft") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/anl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Analyst"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/anl">http://id.loc.gov/vocabulary/relators/anl</seealso>
    let anl = Prefixed_Name(marcrole, "anl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/anm</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Animator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/anm">http://id.loc.gov/vocabulary/relators/anm</seealso>
    let anm = Prefixed_Name(marcrole, "anm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ann</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Annotator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ann">http://id.loc.gov/vocabulary/relators/ann</seealso>
    let ann = Prefixed_Name(marcrole, "ann") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ant</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Bibliographic antecedent"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ant">http://id.loc.gov/vocabulary/relators/ant</seealso>
    let ant = Prefixed_Name(marcrole, "ant") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ape">http://id.loc.gov/vocabulary/relators/ape</seealso>
    let ape = Prefixed_Name(marcrole, "ape") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/apl</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/apl">http://id.loc.gov/vocabulary/relators/apl</seealso>
    let apl = Prefixed_Name(marcrole, "apl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/app</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Applicant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/app">http://id.loc.gov/vocabulary/relators/app</seealso>
    let app = Prefixed_Name(marcrole, "app") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aqt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Author in quotations or text abstracts"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aqt">http://id.loc.gov/vocabulary/relators/aqt</seealso>
    let aqt = Prefixed_Name(marcrole, "aqt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/arc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Architect"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/arc">http://id.loc.gov/vocabulary/relators/arc</seealso>
    let arc = Prefixed_Name(marcrole, "arc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Artistic director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ard">http://id.loc.gov/vocabulary/relators/ard</seealso>
    let ard = Prefixed_Name(marcrole, "ard") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/arr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Arranger"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/arr">http://id.loc.gov/vocabulary/relators/arr</seealso>
    let arr = Prefixed_Name(marcrole, "arr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/art</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Artist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/art">http://id.loc.gov/vocabulary/relators/art</seealso>
    let art = Prefixed_Name(marcrole, "art") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/asg</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Assignee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/asg">http://id.loc.gov/vocabulary/relators/asg</seealso>
    let asg = Prefixed_Name(marcrole, "asg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/asn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Associated name"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/asn">http://id.loc.gov/vocabulary/relators/asn</seealso>
    let asn = Prefixed_Name(marcrole, "asn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ato</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Autographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ato">http://id.loc.gov/vocabulary/relators/ato</seealso>
    let ato = Prefixed_Name(marcrole, "ato") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/att</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Attributed name"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/att">http://id.loc.gov/vocabulary/relators/att</seealso>
    let att = Prefixed_Name(marcrole, "att") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/auc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Auctioneer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/auc">http://id.loc.gov/vocabulary/relators/auc</seealso>
    let auc = Prefixed_Name(marcrole, "auc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aud</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Author of dialog"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aud">http://id.loc.gov/vocabulary/relators/aud</seealso>
    let aud = Prefixed_Name(marcrole, "aud") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aui</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Author of introduction, etc."</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aui">http://id.loc.gov/vocabulary/relators/aui</seealso>
    let aui = Prefixed_Name(marcrole, "aui") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aus</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Screenwriter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aus">http://id.loc.gov/vocabulary/relators/aus</seealso>
    let aus = Prefixed_Name(marcrole, "aus") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aut</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Author"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aut">http://id.loc.gov/vocabulary/relators/aut</seealso>
    let aut = Prefixed_Name(marcrole, "aut") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/aut.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/aut.html">http://id.loc.gov/vocabulary/relators/aut.html</seealso>
    let ``aut.html`` = Prefixed_Name(marcrole, "aut.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bdd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Binding designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bdd">http://id.loc.gov/vocabulary/relators/bdd</seealso>
    let bdd = Prefixed_Name(marcrole, "bdd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bjd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Bookjacket designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bjd">http://id.loc.gov/vocabulary/relators/bjd</seealso>
    let bjd = Prefixed_Name(marcrole, "bjd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bkd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Book designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bkd">http://id.loc.gov/vocabulary/relators/bkd</seealso>
    let bkd = Prefixed_Name(marcrole, "bkd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bkp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Book producer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bkp">http://id.loc.gov/vocabulary/relators/bkp</seealso>
    let bkp = Prefixed_Name(marcrole, "bkp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/blw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Blurb writer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/blw">http://id.loc.gov/vocabulary/relators/blw</seealso>
    let blw = Prefixed_Name(marcrole, "blw") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Binder"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bnd">http://id.loc.gov/vocabulary/relators/bnd</seealso>
    let bnd = Prefixed_Name(marcrole, "bnd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bpd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Bookplate designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bpd">http://id.loc.gov/vocabulary/relators/bpd</seealso>
    let bpd = Prefixed_Name(marcrole, "bpd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/brd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Broadcaster"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/brd">http://id.loc.gov/vocabulary/relators/brd</seealso>
    let brd = Prefixed_Name(marcrole, "brd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/brl</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Braille embosser"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/brl">http://id.loc.gov/vocabulary/relators/brl</seealso>
    let brl = Prefixed_Name(marcrole, "brl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/bsl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Bookseller"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/bsl">http://id.loc.gov/vocabulary/relators/bsl</seealso>
    let bsl = Prefixed_Name(marcrole, "bsl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Caster"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cas">http://id.loc.gov/vocabulary/relators/cas</seealso>
    let cas = Prefixed_Name(marcrole, "cas") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ccp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Conceptor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ccp">http://id.loc.gov/vocabulary/relators/ccp</seealso>
    let ccp = Prefixed_Name(marcrole, "ccp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/chr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Choreographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/chr">http://id.loc.gov/vocabulary/relators/chr</seealso>
    let chr = Prefixed_Name(marcrole, "chr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cli</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Client"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cli">http://id.loc.gov/vocabulary/relators/cli</seealso>
    let cli = Prefixed_Name(marcrole, "cli") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cll</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Calligrapher"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cll">http://id.loc.gov/vocabulary/relators/cll</seealso>
    let cll = Prefixed_Name(marcrole, "cll") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/clr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Colorist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/clr">http://id.loc.gov/vocabulary/relators/clr</seealso>
    let clr = Prefixed_Name(marcrole, "clr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/clt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Collotyper"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/clt">http://id.loc.gov/vocabulary/relators/clt</seealso>
    let clt = Prefixed_Name(marcrole, "clt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cmm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Commentator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cmm">http://id.loc.gov/vocabulary/relators/cmm</seealso>
    let cmm = Prefixed_Name(marcrole, "cmm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cmp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Composer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cmp">http://id.loc.gov/vocabulary/relators/cmp</seealso>
    let cmp = Prefixed_Name(marcrole, "cmp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cmt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Compositor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cmt">http://id.loc.gov/vocabulary/relators/cmt</seealso>
    let cmt = Prefixed_Name(marcrole, "cmt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cmt.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cmt.html">http://id.loc.gov/vocabulary/relators/cmt.html</seealso>
    let ``cmt.html`` = Prefixed_Name(marcrole, "cmt.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Conductor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cnd">http://id.loc.gov/vocabulary/relators/cnd</seealso>
    let cnd = Prefixed_Name(marcrole, "cnd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cng</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Cinematographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cng">http://id.loc.gov/vocabulary/relators/cng</seealso>
    let cng = Prefixed_Name(marcrole, "cng") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cns</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Censor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cns">http://id.loc.gov/vocabulary/relators/cns</seealso>
    let cns = Prefixed_Name(marcrole, "cns") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/coe</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Contestant-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/coe">http://id.loc.gov/vocabulary/relators/coe</seealso>
    let coe = Prefixed_Name(marcrole, "coe") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/col</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Collector"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/col">http://id.loc.gov/vocabulary/relators/col</seealso>
    let col = Prefixed_Name(marcrole, "col") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_BIBFRAMEInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - BIBFRAME Instance Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEInstance">http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEInstance</seealso>
    let collection_BIBFRAMEInstance =
        Prefixed_Name(marcrole, "collection_BIBFRAMEInstance") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_BIBFRAMEWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - BIBFRAME Work Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEWork">http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEWork</seealso>
    let collection_BIBFRAMEWork =
        Prefixed_Name(marcrole, "collection_BIBFRAMEWork") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDA">http://id.loc.gov/vocabulary/relators/collection_RDA</seealso>
    let collection_RDA = Prefixed_Name(marcrole, "collection_RDA") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Contributor Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAContributor">http://id.loc.gov/vocabulary/relators/collection_RDAContributor</seealso>
    let collection_RDAContributor =
        Prefixed_Name(marcrole, "collection_RDAContributor") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDACreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Creator Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDACreator">http://id.loc.gov/vocabulary/relators/collection_RDACreator</seealso>
    let collection_RDACreator =
        Prefixed_Name(marcrole, "collection_RDACreator") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDADistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Distributor Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDADistributor">http://id.loc.gov/vocabulary/relators/collection_RDADistributor</seealso>
    let collection_RDADistributor =
        Prefixed_Name(marcrole, "collection_RDADistributor") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Expression Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAExpression">http://id.loc.gov/vocabulary/relators/collection_RDAExpression</seealso>
    let collection_RDAExpression =
        Prefixed_Name(marcrole, "collection_RDAExpression") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Item Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAItem">http://id.loc.gov/vocabulary/relators/collection_RDAItem</seealso>
    let collection_RDAItem =
        Prefixed_Name(marcrole, "collection_RDAItem") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Manifestation Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAManifestation">http://id.loc.gov/vocabulary/relators/collection_RDAManifestation</seealso>
    let collection_RDAManifestation =
        Prefixed_Name(marcrole, "collection_RDAManifestation") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Manufacturer Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAManufacturer">http://id.loc.gov/vocabulary/relators/collection_RDAManufacturer</seealso>
    let collection_RDAManufacturer =
        Prefixed_Name(marcrole, "collection_RDAManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Other Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAOther">http://id.loc.gov/vocabulary/relators/collection_RDAOther</seealso>
    let collection_RDAOther =
        Prefixed_Name(marcrole, "collection_RDAOther") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Owner Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAOwner">http://id.loc.gov/vocabulary/relators/collection_RDAOwner</seealso>
    let collection_RDAOwner =
        Prefixed_Name(marcrole, "collection_RDAOwner") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Publisher Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAPublisher">http://id.loc.gov/vocabulary/relators/collection_RDAPublisher</seealso>
    let collection_RDAPublisher =
        Prefixed_Name(marcrole, "collection_RDAPublisher") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/collection_RDAWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:MADSCollection</para>
    ///
    /// labels<para>"Relators - RDA Work Collection"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/collection_RDAWork">http://id.loc.gov/vocabulary/relators/collection_RDAWork</seealso>
    let collection_RDAWork =
        Prefixed_Name(marcrole, "collection_RDAWork") |> PrefixedName

    /// <summary>
    ///   <para>loc:vocabulary/relators/com</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Compiler"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/com">http://id.loc.gov/vocabulary/relators/com</seealso>
    let com = Prefixed_Name(marcrole, "com") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/con</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Conservator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/con">http://id.loc.gov/vocabulary/relators/con</seealso>
    let con = Prefixed_Name(marcrole, "con") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Collection registrar"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cor">http://id.loc.gov/vocabulary/relators/cor</seealso>
    let cor = Prefixed_Name(marcrole, "cor") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cos</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Contestant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cos">http://id.loc.gov/vocabulary/relators/cos</seealso>
    let cos = Prefixed_Name(marcrole, "cos") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Contestant-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cot">http://id.loc.gov/vocabulary/relators/cot</seealso>
    let cot = Prefixed_Name(marcrole, "cot") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cou</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Court governed"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cou">http://id.loc.gov/vocabulary/relators/cou</seealso>
    let cou = Prefixed_Name(marcrole, "cou") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cov</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Cover designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cov">http://id.loc.gov/vocabulary/relators/cov</seealso>
    let cov = Prefixed_Name(marcrole, "cov") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cpc</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Copyright claimant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cpc">http://id.loc.gov/vocabulary/relators/cpc</seealso>
    let cpc = Prefixed_Name(marcrole, "cpc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cpe</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Complainant-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cpe">http://id.loc.gov/vocabulary/relators/cpe</seealso>
    let cpe = Prefixed_Name(marcrole, "cpe") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cph</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Copyright holder"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cph">http://id.loc.gov/vocabulary/relators/cph</seealso>
    let cph = Prefixed_Name(marcrole, "cph") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cpl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Complainant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cpl">http://id.loc.gov/vocabulary/relators/cpl</seealso>
    let cpl = Prefixed_Name(marcrole, "cpl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Complainant-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cpt">http://id.loc.gov/vocabulary/relators/cpt</seealso>
    let cpt = Prefixed_Name(marcrole, "cpt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cre</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Creator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cre">http://id.loc.gov/vocabulary/relators/cre</seealso>
    let cre = Prefixed_Name(marcrole, "cre") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/crp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Correspondent"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/crp">http://id.loc.gov/vocabulary/relators/crp</seealso>
    let crp = Prefixed_Name(marcrole, "crp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/crr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Corrector"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/crr">http://id.loc.gov/vocabulary/relators/crr</seealso>
    let crr = Prefixed_Name(marcrole, "crr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/crt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Court reporter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/crt">http://id.loc.gov/vocabulary/relators/crt</seealso>
    let crt = Prefixed_Name(marcrole, "crt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/csl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Consultant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/csl">http://id.loc.gov/vocabulary/relators/csl</seealso>
    let csl = Prefixed_Name(marcrole, "csl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/csp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Consultant to a project"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/csp">http://id.loc.gov/vocabulary/relators/csp</seealso>
    let csp = Prefixed_Name(marcrole, "csp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Costume designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cst">http://id.loc.gov/vocabulary/relators/cst</seealso>
    let cst = Prefixed_Name(marcrole, "cst") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ctb</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Contributor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ctb">http://id.loc.gov/vocabulary/relators/ctb</seealso>
    let ctb = Prefixed_Name(marcrole, "ctb") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Contestee-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cte">http://id.loc.gov/vocabulary/relators/cte</seealso>
    let cte = Prefixed_Name(marcrole, "cte") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ctg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Cartographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ctg">http://id.loc.gov/vocabulary/relators/ctg</seealso>
    let ctg = Prefixed_Name(marcrole, "ctg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ctr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Contractor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ctr">http://id.loc.gov/vocabulary/relators/ctr</seealso>
    let ctr = Prefixed_Name(marcrole, "ctr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Contestee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cts">http://id.loc.gov/vocabulary/relators/cts</seealso>
    let cts = Prefixed_Name(marcrole, "cts") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ctt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Contestee-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ctt">http://id.loc.gov/vocabulary/relators/ctt</seealso>
    let ctt = Prefixed_Name(marcrole, "ctt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cur</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Curator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cur">http://id.loc.gov/vocabulary/relators/cur</seealso>
    let cur = Prefixed_Name(marcrole, "cur") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cur.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cur.html">http://id.loc.gov/vocabulary/relators/cur.html</seealso>
    let ``cur.html`` = Prefixed_Name(marcrole, "cur.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/cwt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Commentator for written text"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/cwt">http://id.loc.gov/vocabulary/relators/cwt</seealso>
    let cwt = Prefixed_Name(marcrole, "cwt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dbp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Distribution place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dbp">http://id.loc.gov/vocabulary/relators/dbp</seealso>
    let dbp = Prefixed_Name(marcrole, "dbp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dfd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Defendant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dfd">http://id.loc.gov/vocabulary/relators/dfd</seealso>
    let dfd = Prefixed_Name(marcrole, "dfd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dfe</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Defendant-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dfe">http://id.loc.gov/vocabulary/relators/dfe</seealso>
    let dfe = Prefixed_Name(marcrole, "dfe") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dft</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Defendant-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dft">http://id.loc.gov/vocabulary/relators/dft</seealso>
    let dft = Prefixed_Name(marcrole, "dft") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dgg</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Degree granting institution"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dgg">http://id.loc.gov/vocabulary/relators/dgg</seealso>
    let dgg = Prefixed_Name(marcrole, "dgg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dgs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Degree supervisor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dgs">http://id.loc.gov/vocabulary/relators/dgs</seealso>
    let dgs = Prefixed_Name(marcrole, "dgs") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Dissertant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dis">http://id.loc.gov/vocabulary/relators/dis</seealso>
    let dis = Prefixed_Name(marcrole, "dis") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dln</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Delineator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dln">http://id.loc.gov/vocabulary/relators/dln</seealso>
    let dln = Prefixed_Name(marcrole, "dln") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dnc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Dancer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dnc">http://id.loc.gov/vocabulary/relators/dnc</seealso>
    let dnc = Prefixed_Name(marcrole, "dnc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Donor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dnr">http://id.loc.gov/vocabulary/relators/dnr</seealso>
    let dnr = Prefixed_Name(marcrole, "dnr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dpc</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Depicted"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dpc">http://id.loc.gov/vocabulary/relators/dpc</seealso>
    let dpc = Prefixed_Name(marcrole, "dpc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Depositor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dpt">http://id.loc.gov/vocabulary/relators/dpt</seealso>
    let dpt = Prefixed_Name(marcrole, "dpt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/drm</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Draftsman"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/drm">http://id.loc.gov/vocabulary/relators/drm</seealso>
    let drm = Prefixed_Name(marcrole, "drm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/drt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/drt">http://id.loc.gov/vocabulary/relators/drt</seealso>
    let drt = Prefixed_Name(marcrole, "drt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dsr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dsr">http://id.loc.gov/vocabulary/relators/dsr</seealso>
    let dsr = Prefixed_Name(marcrole, "dsr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dst</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Distributor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dst">http://id.loc.gov/vocabulary/relators/dst</seealso>
    let dst = Prefixed_Name(marcrole, "dst") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Data contributor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dtc">http://id.loc.gov/vocabulary/relators/dtc</seealso>
    let dtc = Prefixed_Name(marcrole, "dtc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Dedicatee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dte">http://id.loc.gov/vocabulary/relators/dte</seealso>
    let dte = Prefixed_Name(marcrole, "dte") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dtm</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Data manager"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dtm">http://id.loc.gov/vocabulary/relators/dtm</seealso>
    let dtm = Prefixed_Name(marcrole, "dtm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dto</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Dedicator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dto">http://id.loc.gov/vocabulary/relators/dto</seealso>
    let dto = Prefixed_Name(marcrole, "dto") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/dub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Dubious author"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/dub">http://id.loc.gov/vocabulary/relators/dub</seealso>
    let dub = Prefixed_Name(marcrole, "dub") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/edc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Editor of compilation"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/edc">http://id.loc.gov/vocabulary/relators/edc</seealso>
    let edc = Prefixed_Name(marcrole, "edc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/edm</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Editor of moving image work"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/edm">http://id.loc.gov/vocabulary/relators/edm</seealso>
    let edm = Prefixed_Name(marcrole, "edm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/edt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Editor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/edt">http://id.loc.gov/vocabulary/relators/edt</seealso>
    let edt = Prefixed_Name(marcrole, "edt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/edt.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/edt.html">http://id.loc.gov/vocabulary/relators/edt.html</seealso>
    let ``edt.html`` = Prefixed_Name(marcrole, "edt.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/egr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Engraver"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/egr">http://id.loc.gov/vocabulary/relators/egr</seealso>
    let egr = Prefixed_Name(marcrole, "egr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/egr.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/egr.html">http://id.loc.gov/vocabulary/relators/egr.html</seealso>
    let ``egr.html`` = Prefixed_Name(marcrole, "egr.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/elg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Electrician"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/elg">http://id.loc.gov/vocabulary/relators/elg</seealso>
    let elg = Prefixed_Name(marcrole, "elg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/elt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Electrotyper"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/elt">http://id.loc.gov/vocabulary/relators/elt</seealso>
    let elt = Prefixed_Name(marcrole, "elt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/eng</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Engineer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/eng">http://id.loc.gov/vocabulary/relators/eng</seealso>
    let eng = Prefixed_Name(marcrole, "eng") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/eng.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/eng.html">http://id.loc.gov/vocabulary/relators/eng.html</seealso>
    let ``eng.html`` = Prefixed_Name(marcrole, "eng.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/enj</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Enacting jurisdiction"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/enj">http://id.loc.gov/vocabulary/relators/enj</seealso>
    let enj = Prefixed_Name(marcrole, "enj") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/etr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Etcher"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/etr">http://id.loc.gov/vocabulary/relators/etr</seealso>
    let etr = Prefixed_Name(marcrole, "etr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/evp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Event place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/evp">http://id.loc.gov/vocabulary/relators/evp</seealso>
    let evp = Prefixed_Name(marcrole, "evp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/exp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Expert"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/exp">http://id.loc.gov/vocabulary/relators/exp</seealso>
    let exp = Prefixed_Name(marcrole, "exp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fac</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Facsimilist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fac">http://id.loc.gov/vocabulary/relators/fac</seealso>
    let fac = Prefixed_Name(marcrole, "fac") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Film distributor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fds">http://id.loc.gov/vocabulary/relators/fds</seealso>
    let fds = Prefixed_Name(marcrole, "fds") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fld</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Field director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fld">http://id.loc.gov/vocabulary/relators/fld</seealso>
    let fld = Prefixed_Name(marcrole, "fld") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/flm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Film editor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/flm">http://id.loc.gov/vocabulary/relators/flm</seealso>
    let flm = Prefixed_Name(marcrole, "flm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fmd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Film director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fmd">http://id.loc.gov/vocabulary/relators/fmd</seealso>
    let fmd = Prefixed_Name(marcrole, "fmd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fmk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Filmmaker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fmk">http://id.loc.gov/vocabulary/relators/fmk</seealso>
    let fmk = Prefixed_Name(marcrole, "fmk") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fmo</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Former owner"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fmo">http://id.loc.gov/vocabulary/relators/fmo</seealso>
    let fmo = Prefixed_Name(marcrole, "fmo") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fmp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Film producer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fmp">http://id.loc.gov/vocabulary/relators/fmp</seealso>
    let fmp = Prefixed_Name(marcrole, "fmp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Funder"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fnd">http://id.loc.gov/vocabulary/relators/fnd</seealso>
    let fnd = Prefixed_Name(marcrole, "fnd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/fpy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"First party"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/fpy">http://id.loc.gov/vocabulary/relators/fpy</seealso>
    let fpy = Prefixed_Name(marcrole, "fpy") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/frg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Forger"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/frg">http://id.loc.gov/vocabulary/relators/frg</seealso>
    let frg = Prefixed_Name(marcrole, "frg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/frg.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/frg.html">http://id.loc.gov/vocabulary/relators/frg.html</seealso>
    let ``frg.html`` = Prefixed_Name(marcrole, "frg.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/gis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Geographic information specialist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/gis">http://id.loc.gov/vocabulary/relators/gis</seealso>
    let gis = Prefixed_Name(marcrole, "gis") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/his</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Host institution"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/his">http://id.loc.gov/vocabulary/relators/his</seealso>
    let his = Prefixed_Name(marcrole, "his") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/hnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Honoree"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/hnr">http://id.loc.gov/vocabulary/relators/hnr</seealso>
    let hnr = Prefixed_Name(marcrole, "hnr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/hst</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Host"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/hst">http://id.loc.gov/vocabulary/relators/hst</seealso>
    let hst = Prefixed_Name(marcrole, "hst") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ill</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Illustrator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ill">http://id.loc.gov/vocabulary/relators/ill</seealso>
    let ill = Prefixed_Name(marcrole, "ill") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ilu</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Illuminator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ilu">http://id.loc.gov/vocabulary/relators/ilu</seealso>
    let ilu = Prefixed_Name(marcrole, "ilu") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Inscriber"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ins">http://id.loc.gov/vocabulary/relators/ins</seealso>
    let ins = Prefixed_Name(marcrole, "ins") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/inv</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Inventor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/inv">http://id.loc.gov/vocabulary/relators/inv</seealso>
    let inv = Prefixed_Name(marcrole, "inv") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/isb</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Issuing body"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/isb">http://id.loc.gov/vocabulary/relators/isb</seealso>
    let isb = Prefixed_Name(marcrole, "isb") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/itr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Instrumentalist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/itr">http://id.loc.gov/vocabulary/relators/itr</seealso>
    let itr = Prefixed_Name(marcrole, "itr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ive</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Interviewee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ive">http://id.loc.gov/vocabulary/relators/ive</seealso>
    let ive = Prefixed_Name(marcrole, "ive") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ivr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Interviewer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ivr">http://id.loc.gov/vocabulary/relators/ivr</seealso>
    let ivr = Prefixed_Name(marcrole, "ivr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/jud</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Judge"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/jud">http://id.loc.gov/vocabulary/relators/jud</seealso>
    let jud = Prefixed_Name(marcrole, "jud") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/jug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Jurisdiction governed"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/jug">http://id.loc.gov/vocabulary/relators/jug</seealso>
    let jug = Prefixed_Name(marcrole, "jug") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lbr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Laboratory"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lbr">http://id.loc.gov/vocabulary/relators/lbr</seealso>
    let lbr = Prefixed_Name(marcrole, "lbr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lbt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Librettist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lbt">http://id.loc.gov/vocabulary/relators/lbt</seealso>
    let lbt = Prefixed_Name(marcrole, "lbt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ldr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Laboratory director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ldr">http://id.loc.gov/vocabulary/relators/ldr</seealso>
    let ldr = Prefixed_Name(marcrole, "ldr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/led</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Lead"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/led">http://id.loc.gov/vocabulary/relators/led</seealso>
    let led = Prefixed_Name(marcrole, "led") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lee</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Libelee-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lee">http://id.loc.gov/vocabulary/relators/lee</seealso>
    let lee = Prefixed_Name(marcrole, "lee") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lei</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lei">http://id.loc.gov/vocabulary/relators/lei</seealso>
    let lei = Prefixed_Name(marcrole, "lei") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Libelee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lel">http://id.loc.gov/vocabulary/relators/lel</seealso>
    let lel = Prefixed_Name(marcrole, "lel") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/len</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Lender"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/len">http://id.loc.gov/vocabulary/relators/len</seealso>
    let len = Prefixed_Name(marcrole, "len") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/let</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Libelee-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/let">http://id.loc.gov/vocabulary/relators/let</seealso>
    let let_ = Prefixed_Name(marcrole, "let") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lgd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Lighting designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lgd">http://id.loc.gov/vocabulary/relators/lgd</seealso>
    let lgd = Prefixed_Name(marcrole, "lgd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lie</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Libelant-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lie">http://id.loc.gov/vocabulary/relators/lie</seealso>
    let lie = Prefixed_Name(marcrole, "lie") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lil</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Libelant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lil">http://id.loc.gov/vocabulary/relators/lil</seealso>
    let lil = Prefixed_Name(marcrole, "lil") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Libelant-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lit">http://id.loc.gov/vocabulary/relators/lit</seealso>
    let lit = Prefixed_Name(marcrole, "lit") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lsa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Landscape architect"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lsa">http://id.loc.gov/vocabulary/relators/lsa</seealso>
    let lsa = Prefixed_Name(marcrole, "lsa") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Licensee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lse">http://id.loc.gov/vocabulary/relators/lse</seealso>
    let lse = Prefixed_Name(marcrole, "lse") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Licensor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lso">http://id.loc.gov/vocabulary/relators/lso</seealso>
    let lso = Prefixed_Name(marcrole, "lso") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ltg</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Lithographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ltg">http://id.loc.gov/vocabulary/relators/ltg</seealso>
    let ltg = Prefixed_Name(marcrole, "ltg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/lyr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Lyricist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/lyr">http://id.loc.gov/vocabulary/relators/lyr</seealso>
    let lyr = Prefixed_Name(marcrole, "lyr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mcp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Music copyist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mcp">http://id.loc.gov/vocabulary/relators/mcp</seealso>
    let mcp = Prefixed_Name(marcrole, "mcp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mdc</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Metadata contact"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mdc">http://id.loc.gov/vocabulary/relators/mdc</seealso>
    let mdc = Prefixed_Name(marcrole, "mdc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/med</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Medium"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/med">http://id.loc.gov/vocabulary/relators/med</seealso>
    let med = Prefixed_Name(marcrole, "med") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mfp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Manufacture place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mfp">http://id.loc.gov/vocabulary/relators/mfp</seealso>
    let mfp = Prefixed_Name(marcrole, "mfp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mfr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Manufacturer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mfr">http://id.loc.gov/vocabulary/relators/mfr</seealso>
    let mfr = Prefixed_Name(marcrole, "mfr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Moderator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mod">http://id.loc.gov/vocabulary/relators/mod</seealso>
    let mod_ = Prefixed_Name(marcrole, "mod") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mon</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Monitor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mon">http://id.loc.gov/vocabulary/relators/mon</seealso>
    let mon = Prefixed_Name(marcrole, "mon") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mrb</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Marbler"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mrb">http://id.loc.gov/vocabulary/relators/mrb</seealso>
    let mrb = Prefixed_Name(marcrole, "mrb") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mrk</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Markup editor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mrk">http://id.loc.gov/vocabulary/relators/mrk</seealso>
    let mrk = Prefixed_Name(marcrole, "mrk") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/msd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Musical director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/msd">http://id.loc.gov/vocabulary/relators/msd</seealso>
    let msd = Prefixed_Name(marcrole, "msd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Metal-engraver"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mte">http://id.loc.gov/vocabulary/relators/mte</seealso>
    let mte = Prefixed_Name(marcrole, "mte") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mtk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Minute taker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mtk">http://id.loc.gov/vocabulary/relators/mtk</seealso>
    let mtk = Prefixed_Name(marcrole, "mtk") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/mus</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Musician"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/mus">http://id.loc.gov/vocabulary/relators/mus</seealso>
    let mus = Prefixed_Name(marcrole, "mus") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/nrt</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Narrator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/nrt">http://id.loc.gov/vocabulary/relators/nrt</seealso>
    let nrt = Prefixed_Name(marcrole, "nrt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/opn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Opponent"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/opn">http://id.loc.gov/vocabulary/relators/opn</seealso>
    let opn = Prefixed_Name(marcrole, "opn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/org</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Originator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/org">http://id.loc.gov/vocabulary/relators/org</seealso>
    let org = Prefixed_Name(marcrole, "org") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/orm</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Organizer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/orm">http://id.loc.gov/vocabulary/relators/orm</seealso>
    let orm = Prefixed_Name(marcrole, "orm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/osp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Onscreen presenter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/osp">http://id.loc.gov/vocabulary/relators/osp</seealso>
    let osp = Prefixed_Name(marcrole, "osp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/oth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Other"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/oth">http://id.loc.gov/vocabulary/relators/oth</seealso>
    let oth = Prefixed_Name(marcrole, "oth") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/own</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Owner"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/own">http://id.loc.gov/vocabulary/relators/own</seealso>
    let own = Prefixed_Name(marcrole, "own") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Panelist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pan">http://id.loc.gov/vocabulary/relators/pan</seealso>
    let pan = Prefixed_Name(marcrole, "pan") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Patron"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pat">http://id.loc.gov/vocabulary/relators/pat</seealso>
    let pat = Prefixed_Name(marcrole, "pat") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pbd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Publishing director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pbd">http://id.loc.gov/vocabulary/relators/pbd</seealso>
    let pbd = Prefixed_Name(marcrole, "pbd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pbl</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Publisher"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pbl">http://id.loc.gov/vocabulary/relators/pbl</seealso>
    let pbl = Prefixed_Name(marcrole, "pbl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pbl.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pbl.html">http://id.loc.gov/vocabulary/relators/pbl.html</seealso>
    let ``pbl.html`` = Prefixed_Name(marcrole, "pbl.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pdr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Project director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pdr">http://id.loc.gov/vocabulary/relators/pdr</seealso>
    let pdr = Prefixed_Name(marcrole, "pdr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pfr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Proofreader"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pfr">http://id.loc.gov/vocabulary/relators/pfr</seealso>
    let pfr = Prefixed_Name(marcrole, "pfr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pht</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Photographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pht">http://id.loc.gov/vocabulary/relators/pht</seealso>
    let pht = Prefixed_Name(marcrole, "pht") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/plt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Platemaker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/plt">http://id.loc.gov/vocabulary/relators/plt</seealso>
    let plt = Prefixed_Name(marcrole, "plt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pma</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Permitting agency"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pma">http://id.loc.gov/vocabulary/relators/pma</seealso>
    let pma = Prefixed_Name(marcrole, "pma") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pmn</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Production manager"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pmn">http://id.loc.gov/vocabulary/relators/pmn</seealso>
    let pmn = Prefixed_Name(marcrole, "pmn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Printer of plates"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pop">http://id.loc.gov/vocabulary/relators/pop</seealso>
    let pop = Prefixed_Name(marcrole, "pop") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ppm</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Papermaker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ppm">http://id.loc.gov/vocabulary/relators/ppm</seealso>
    let ppm = Prefixed_Name(marcrole, "ppm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ppt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Puppeteer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ppt">http://id.loc.gov/vocabulary/relators/ppt</seealso>
    let ppt = Prefixed_Name(marcrole, "ppt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pra</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Praeses"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pra">http://id.loc.gov/vocabulary/relators/pra</seealso>
    let pra = Prefixed_Name(marcrole, "pra") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Process contact"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prc">http://id.loc.gov/vocabulary/relators/prc</seealso>
    let prc = Prefixed_Name(marcrole, "prc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prd</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Production personnel"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prd">http://id.loc.gov/vocabulary/relators/prd</seealso>
    let prd = Prefixed_Name(marcrole, "prd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pre</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Presenter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pre">http://id.loc.gov/vocabulary/relators/pre</seealso>
    let pre = Prefixed_Name(marcrole, "pre") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Performer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prf">http://id.loc.gov/vocabulary/relators/prf</seealso>
    let prf = Prefixed_Name(marcrole, "prf") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prg</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Programmer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prg">http://id.loc.gov/vocabulary/relators/prg</seealso>
    let prg = Prefixed_Name(marcrole, "prg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Printmaker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prm">http://id.loc.gov/vocabulary/relators/prm</seealso>
    let prm = Prefixed_Name(marcrole, "prm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prn</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Production company"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prn">http://id.loc.gov/vocabulary/relators/prn</seealso>
    let prn = Prefixed_Name(marcrole, "prn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pro</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Producer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pro">http://id.loc.gov/vocabulary/relators/pro</seealso>
    let pro = Prefixed_Name(marcrole, "pro") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Production place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prp">http://id.loc.gov/vocabulary/relators/prp</seealso>
    let prp = Prefixed_Name(marcrole, "prp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prs</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Production designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prs">http://id.loc.gov/vocabulary/relators/prs</seealso>
    let prs = Prefixed_Name(marcrole, "prs") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Printer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prt">http://id.loc.gov/vocabulary/relators/prt</seealso>
    let prt = Prefixed_Name(marcrole, "prt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prt.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prt.html">http://id.loc.gov/vocabulary/relators/prt.html</seealso>
    let ``prt.html`` = Prefixed_Name(marcrole, "prt.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/prv</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Provider"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/prv">http://id.loc.gov/vocabulary/relators/prv</seealso>
    let prv = Prefixed_Name(marcrole, "prv") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pta</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Patent applicant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pta">http://id.loc.gov/vocabulary/relators/pta</seealso>
    let pta = Prefixed_Name(marcrole, "pta") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Plaintiff-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pte">http://id.loc.gov/vocabulary/relators/pte</seealso>
    let pte = Prefixed_Name(marcrole, "pte") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ptf</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Plaintiff"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ptf">http://id.loc.gov/vocabulary/relators/ptf</seealso>
    let ptf = Prefixed_Name(marcrole, "ptf") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Patent holder"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pth">http://id.loc.gov/vocabulary/relators/pth</seealso>
    let pth = Prefixed_Name(marcrole, "pth") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ptt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Plaintiff-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ptt">http://id.loc.gov/vocabulary/relators/ptt</seealso>
    let ptt = Prefixed_Name(marcrole, "ptt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/pup</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Publication place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/pup">http://id.loc.gov/vocabulary/relators/pup</seealso>
    let pup = Prefixed_Name(marcrole, "pup") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rbr</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Rubricator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rbr">http://id.loc.gov/vocabulary/relators/rbr</seealso>
    let rbr = Prefixed_Name(marcrole, "rbr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rcd</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Recordist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rcd">http://id.loc.gov/vocabulary/relators/rcd</seealso>
    let rcd = Prefixed_Name(marcrole, "rcd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Recording engineer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rce">http://id.loc.gov/vocabulary/relators/rce</seealso>
    let rce = Prefixed_Name(marcrole, "rce") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rcp</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Addressee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rcp">http://id.loc.gov/vocabulary/relators/rcp</seealso>
    let rcp = Prefixed_Name(marcrole, "rcp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rdd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rdd">http://id.loc.gov/vocabulary/relators/rdd</seealso>
    let rdd = Prefixed_Name(marcrole, "rdd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/red</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Redaktor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/red">http://id.loc.gov/vocabulary/relators/red</seealso>
    let red = Prefixed_Name(marcrole, "red") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ren</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Renderer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ren">http://id.loc.gov/vocabulary/relators/ren</seealso>
    let ren = Prefixed_Name(marcrole, "ren") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/res</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Researcher"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/res">http://id.loc.gov/vocabulary/relators/res</seealso>
    let res = Prefixed_Name(marcrole, "res") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Reviewer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rev">http://id.loc.gov/vocabulary/relators/rev</seealso>
    let rev = Prefixed_Name(marcrole, "rev") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/role</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/role">http://id.loc.gov/vocabulary/relators/role</seealso>
    let role = Prefixed_Name(marcrole, "role") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rpc</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio producer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rpc">http://id.loc.gov/vocabulary/relators/rpc</seealso>
    let rpc = Prefixed_Name(marcrole, "rpc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rps</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Repository"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rps">http://id.loc.gov/vocabulary/relators/rps</seealso>
    let rps = Prefixed_Name(marcrole, "rps") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Reporter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rpt">http://id.loc.gov/vocabulary/relators/rpt</seealso>
    let rpt = Prefixed_Name(marcrole, "rpt") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rpy</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Responsible party"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rpy">http://id.loc.gov/vocabulary/relators/rpy</seealso>
    let rpy = Prefixed_Name(marcrole, "rpy") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rse</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Respondent-appellee"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rse">http://id.loc.gov/vocabulary/relators/rse</seealso>
    let rse = Prefixed_Name(marcrole, "rse") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rsg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Restager"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rsg">http://id.loc.gov/vocabulary/relators/rsg</seealso>
    let rsg = Prefixed_Name(marcrole, "rsg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Respondent"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rsp">http://id.loc.gov/vocabulary/relators/rsp</seealso>
    let rsp = Prefixed_Name(marcrole, "rsp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rsr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Restorationist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rsr">http://id.loc.gov/vocabulary/relators/rsr</seealso>
    let rsr = Prefixed_Name(marcrole, "rsr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rst</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Respondent-appellant"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rst">http://id.loc.gov/vocabulary/relators/rst</seealso>
    let rst = Prefixed_Name(marcrole, "rst") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Research team head"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rth">http://id.loc.gov/vocabulary/relators/rth</seealso>
    let rth = Prefixed_Name(marcrole, "rth") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/rtm</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Research team member"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/rtm">http://id.loc.gov/vocabulary/relators/rtm</seealso>
    let rtm = Prefixed_Name(marcrole, "rtm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sad</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Scientific advisor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sad">http://id.loc.gov/vocabulary/relators/sad</seealso>
    let sad = Prefixed_Name(marcrole, "sad") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sce</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Scenarist"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sce">http://id.loc.gov/vocabulary/relators/sce</seealso>
    let sce = Prefixed_Name(marcrole, "sce") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/scl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Sculptor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/scl">http://id.loc.gov/vocabulary/relators/scl</seealso>
    let scl = Prefixed_Name(marcrole, "scl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/scr</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Scribe"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/scr">http://id.loc.gov/vocabulary/relators/scr</seealso>
    let scr = Prefixed_Name(marcrole, "scr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sds</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Sound designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sds">http://id.loc.gov/vocabulary/relators/sds</seealso>
    let sds = Prefixed_Name(marcrole, "sds") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sec</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Secretary"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sec">http://id.loc.gov/vocabulary/relators/sec</seealso>
    let sec = Prefixed_Name(marcrole, "sec") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sgd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Stage director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sgd">http://id.loc.gov/vocabulary/relators/sgd</seealso>
    let sgd = Prefixed_Name(marcrole, "sgd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sgn</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Signer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sgn">http://id.loc.gov/vocabulary/relators/sgn</seealso>
    let sgn = Prefixed_Name(marcrole, "sgn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sht</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Supporting host"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sht">http://id.loc.gov/vocabulary/relators/sht</seealso>
    let sht = Prefixed_Name(marcrole, "sht") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Seller"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sll">http://id.loc.gov/vocabulary/relators/sll</seealso>
    let sll = Prefixed_Name(marcrole, "sll") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/sng</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Singer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/sng">http://id.loc.gov/vocabulary/relators/sng</seealso>
    let sng = Prefixed_Name(marcrole, "sng") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/spk</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Speaker"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/spk">http://id.loc.gov/vocabulary/relators/spk</seealso>
    let spk = Prefixed_Name(marcrole, "spk") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/spn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Sponsor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/spn">http://id.loc.gov/vocabulary/relators/spn</seealso>
    let spn = Prefixed_Name(marcrole, "spn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/spy</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Second party"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/spy">http://id.loc.gov/vocabulary/relators/spy</seealso>
    let spy = Prefixed_Name(marcrole, "spy") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/srv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Surveyor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/srv">http://id.loc.gov/vocabulary/relators/srv</seealso>
    let srv = Prefixed_Name(marcrole, "srv") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/std</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Set designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/std">http://id.loc.gov/vocabulary/relators/std</seealso>
    let std = Prefixed_Name(marcrole, "std") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/stg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Setting"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/stg">http://id.loc.gov/vocabulary/relators/stg</seealso>
    let stg = Prefixed_Name(marcrole, "stg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/stl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Storyteller"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/stl">http://id.loc.gov/vocabulary/relators/stl</seealso>
    let stl = Prefixed_Name(marcrole, "stl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/stm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stage manager"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/stm">http://id.loc.gov/vocabulary/relators/stm</seealso>
    let stm = Prefixed_Name(marcrole, "stm") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/stn</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Standards body"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/stn">http://id.loc.gov/vocabulary/relators/stn</seealso>
    let stn = Prefixed_Name(marcrole, "stn") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/str</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Stereotyper"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/str">http://id.loc.gov/vocabulary/relators/str</seealso>
    let str = Prefixed_Name(marcrole, "str") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tcd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Technical director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tcd">http://id.loc.gov/vocabulary/relators/tcd</seealso>
    let tcd = Prefixed_Name(marcrole, "tcd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tch</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Teacher"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tch">http://id.loc.gov/vocabulary/relators/tch</seealso>
    let tch = Prefixed_Name(marcrole, "tch") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tch.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tch.html">http://id.loc.gov/vocabulary/relators/tch.html</seealso>
    let ``tch.html`` = Prefixed_Name(marcrole, "tch.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/ths</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Thesis advisor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/ths">http://id.loc.gov/vocabulary/relators/ths</seealso>
    let ths = Prefixed_Name(marcrole, "ths") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tld</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Television director"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tld">http://id.loc.gov/vocabulary/relators/tld</seealso>
    let tld = Prefixed_Name(marcrole, "tld") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tlp</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Television producer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tlp">http://id.loc.gov/vocabulary/relators/tlp</seealso>
    let tlp = Prefixed_Name(marcrole, "tlp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/trc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Transcriber"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/trc">http://id.loc.gov/vocabulary/relators/trc</seealso>
    let trc = Prefixed_Name(marcrole, "trc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/trc.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/trc.html">http://id.loc.gov/vocabulary/relators/trc.html</seealso>
    let ``trc.html`` = Prefixed_Name(marcrole, "trc.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/trl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Translator"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/trl">http://id.loc.gov/vocabulary/relators/trl</seealso>
    let trl = Prefixed_Name(marcrole, "trl") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/trl.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/trl.html">http://id.loc.gov/vocabulary/relators/trl.html</seealso>
    let ``trl.html`` = Prefixed_Name(marcrole, "trl.html") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tyd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Type designer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tyd">http://id.loc.gov/vocabulary/relators/tyd</seealso>
    let tyd = Prefixed_Name(marcrole, "tyd") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/tyg</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Typographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/tyg">http://id.loc.gov/vocabulary/relators/tyg</seealso>
    let tyg = Prefixed_Name(marcrole, "tyg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/uvp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"University place"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/uvp">http://id.loc.gov/vocabulary/relators/uvp</seealso>
    let uvp = Prefixed_Name(marcrole, "uvp") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/vac</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Voice actor"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/vac">http://id.loc.gov/vocabulary/relators/vac</seealso>
    let vac = Prefixed_Name(marcrole, "vac") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/vdg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Videographer"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/vdg">http://id.loc.gov/vocabulary/relators/vdg</seealso>
    let vdg = Prefixed_Name(marcrole, "vdg") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wac</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Writer of added commentary"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wac">http://id.loc.gov/vocabulary/relators/wac</seealso>
    let wac = Prefixed_Name(marcrole, "wac") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Writer of added lyrics"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wal">http://id.loc.gov/vocabulary/relators/wal</seealso>
    let wal = Prefixed_Name(marcrole, "wal") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wam</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Writer of accompanying material"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wam">http://id.loc.gov/vocabulary/relators/wam</seealso>
    let wam = Prefixed_Name(marcrole, "wam") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Writer of added text"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wat">http://id.loc.gov/vocabulary/relators/wat</seealso>
    let wat = Prefixed_Name(marcrole, "wat") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wdc</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Woodcutter"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wdc">http://id.loc.gov/vocabulary/relators/wdc</seealso>
    let wdc = Prefixed_Name(marcrole, "wdc") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wde</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"Wood engraver"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wde">http://id.loc.gov/vocabulary/relators/wde</seealso>
    let wde = Prefixed_Name(marcrole, "wde") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/win</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>madsrdf:Authority</para>
    ///
    /// labels<para>"Writer of introduction"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/win">http://id.loc.gov/vocabulary/relators/win</seealso>
    let win = Prefixed_Name(marcrole, "win") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wit</para>
    /// </summary>
    /// <remarks>
    ///   <para>madsrdf:Authority</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Witness"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wit">http://id.loc.gov/vocabulary/relators/wit</seealso>
    let wit = Prefixed_Name(marcrole, "wit") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wpr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Writer of preface"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wpr">http://id.loc.gov/vocabulary/relators/wpr</seealso>
    let wpr = Prefixed_Name(marcrole, "wpr") |> PrefixedName
    /// <summary>
    ///   <para>loc:vocabulary/relators/wst</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:Authority</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>madsrdf:Topic</para>
    ///
    /// labels<para>"Writer of supplementary textual content"</para></remarks>
    /// <seealso href="http://id.loc.gov/vocabulary/relators/wst">http://id.loc.gov/vocabulary/relators/wst</seealso>
    let wst = Prefixed_Name(marcrole, "wst") |> PrefixedName

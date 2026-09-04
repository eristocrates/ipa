#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module label =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/vocab/2004/03/label#" "label"

    /// <summary>
    ///   <para>rdfs:comment : En relation mellem en term og dens inverses navn i flertalsformrdfs:comment : A relation between a term and the label of its inverse in literal plural form</para>
    ///   <para>label:singular : flertalsform for inverslabel:singular : plural form of inverse</para>
    ///   <para>rdfs:label : inverse pluralrdfs:label : inverst flertal</para>
    ///   <para>label:plural : plural forms of inverseslabel:plural : flertalsformer for inverse</para>
    ///   <a href="http://purl.org/net/vocab/2004/03/label#inversePlural">label:inversePlural</a>
    /// </summary>
    let inversePlural = _prefixId.prefix "inversePlural"
    /// <summary>
    ///   <para>rdfs:comment : En relation mellem en term og dens inverses navn i entalsformrdfs:comment : A relation between a term and the label of its inverse in literal singular form</para>
    ///   <para>label:plural : singular forms of inverseslabel:plural : entalsformer for inverse</para>
    ///   <para>rdfs:label : inverse singularrdfs:label : inverst ental</para>
    ///   <para>label:singular : singular form of inverselabel:singular : entalsform for invers</para>
    ///   <a href="http://purl.org/net/vocab/2004/03/label#inverseSingular">label:inverseSingular</a>
    /// </summary>
    let inverseSingular = _prefixId.prefix "inverseSingular"
    /// <summary>
    ///   <para>label:plural : plural formslabel:plural : formas pluraleslabel:plural : flertalsformer</para>
    ///   <para>rdfs:label : flertalrdfs:label : pluralrdfs:label : plural</para>
    ///   <para>rdfs:comment : Una relación entre un término y su etiqueta en forma pluralrdfs:comment : A relation between a term and its label in literal plural formrdfs:comment : En relation mellem en term og dens navn i flertalsform</para>
    ///   <para>label:singular : flertalsformlabel:singular : forma plurallabel:singular : plural form</para>
    ///   <a href="http://purl.org/net/vocab/2004/03/label#plural">label:plural</a>
    /// </summary>
    let plural = _prefixId.prefix "plural"
    /// <summary>
    ///   <para>label:singular : forma singularlabel:singular : singular formlabel:singular : entalsform</para>
    ///   <para>label:plural : singular formslabel:plural : entalsformerlabel:plural : formas singulares</para>
    ///   <para>rdfs:label : singularrdfs:label : singularrdfs:label : ental</para>
    ///   <para>rdfs:comment : Una relación entre un término y su etiqueta en forma singularrdfs:comment : A relation between a term and its label in literal singular formrdfs:comment : En relation mellem en term og dens navn i entalsform</para>
    ///   <a href="http://purl.org/net/vocab/2004/03/label#singular">label:singular</a>
    /// </summary>
    let singular = _prefixId.prefix "singular"

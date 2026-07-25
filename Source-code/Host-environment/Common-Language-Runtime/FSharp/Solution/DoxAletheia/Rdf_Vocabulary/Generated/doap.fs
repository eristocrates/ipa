namespace http.usefulinc.com.ns.doap.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module doap =
    let _namespace_iri = Namespace_Iri doap |> NamespaceIRI
    /// <summary>
    ///   <para>doap:BKRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Repositorio BitKeeper del código fuente.</para>
    ///   <para>BitKeeper Quellcode-Versionierungssystem.</para>
    ///   <para>ソースコードのBitKeeperのリポジトリ</para>
    ///   <para>BitKeeper source code repository.</para>
    ///   <para>Dépôt BitKeeper du code source.</para>
    ///   <para>Úložiště zdrojových kódů BitKeeper.</para>
    /// labels<para>Repositorio BitKeeper</para><para>BitKeeper Repository</para><para>BitKeeper Repository</para><para>Úložiště BitKeeper</para><para>BitKeeperのリポジトリ</para><para>Dépôt BitKeeper</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#BKRepository">http://usefulinc.com/ns/doap#BKRepository</seealso>
    let BKRepository = Prefixed_Name(doap, "BKRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:ArchRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>GNU Arch Quellcode-Versionierungssystem.</para>
    ///   <para>Dépôt GNU Arch du code source.</para>
    ///   <para>ソースコードのGNU Archのリポジトリ</para>
    ///   <para>Repositorio GNU Arch del código fuente.</para>
    ///   <para>Úložiště zdrojových kódů GNU Arch.</para>
    ///   <para>GNU Arch source code repository.</para>
    /// labels<para>Repositorio GNU Arch</para><para>GNU Arch repository</para><para>GNU Arch repository</para><para>Úložiště GNU Arch</para><para>Dépôt GNU Arch</para><para>GNU Archのリポジトリ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#ArchRepository">http://usefulinc.com/ns/doap#ArchRepository</seealso>
    let ArchRepository = Prefixed_Name(doap, "ArchRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:helper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Colaborador del proyecto.</para>
    ///   <para>Collaborateur au projet.</para>
    ///   <para>Spoluautor projektu.</para>
    ///   <para>Projekt-Mitarbeiter.</para>
    ///   <para>Project contributor.</para>
    ///   <para>このプロジェクトの貢献者</para>
    /// labels<para>collaborateur</para><para>colaborador</para><para>spoluautor</para><para>helper</para><para>Helfer</para><para>貢献者</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#helper">http://usefulinc.com/ns/doap#helper</seealso>
    let helper = Prefixed_Name(doap, "helper") |> PrefixedName
    /// <summary>
    ///   <para>doap:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>ソースコードのリポジトリ</para>
    ///   <para>Úložiště zdrojových kódů.</para>
    ///   <para>Source code repository.</para>
    ///   <para>Quellcode-Versionierungssystem.</para>
    ///   <para>Dépôt du code source.</para>
    ///   <para>Repositorio del código fuente.</para>
    /// labels<para>Repositorio</para><para>Repository</para><para>Repository</para><para>Úložiště</para><para>リポジトリ</para><para>Dépôt</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#Repository">http://usefulinc.com/ns/doap#Repository</seealso>
    let Repository = Prefixed_Name(doap, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>doap:BazaarBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Bazaar source code branch.</para>
    ///   <para>ソースコードのBazzarのリポジトリ</para>
    /// labels<para>Bazaar Branch</para><para>Bazzarのリポジトリ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#BazaarBranch">http://usefulinc.com/ns/doap#BazaarBranch</seealso>
    let BazaarBranch = Prefixed_Name(doap, "BazaarBranch") |> PrefixedName
    /// <summary>
    ///   <para>doap:old-homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>このプロジェクトの前のホームページ。他のプロジェクトの前のホームページじゃないこと。</para>
    ///   <para>El URL de la antigua página de un proyecto,
    /// 		asociada con exactamente un proyecto.</para>
    ///   <para>L'URL d'une ancienne page web d'un
    /// 		projet, associée avec un unique projet.</para>
    ///   <para>URL der letzten Projekt-Homepage,
    /// 		verbunden mit genau einem Projekt.</para>
    ///   <para>URL adresa předešlé domovské stránky projektu asociované s právě jedním projektem.</para>
    ///   <para>URL of a project's past homepage,
    /// 		associated with exactly one project.</para>
    /// labels<para>stará domovská stránka</para><para>página web antigua</para><para>ancienne page web</para><para>Alte Homepage</para><para>old homepage</para><para>前のホームページ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#old-homepage">http://usefulinc.com/ns/doap#old-homepage</seealso>
    let old_homepage = Prefixed_Name(doap, "old-homepage") |> PrefixedName
    /// <summary>
    ///   <para>doap:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Umístění úložiště.</para>
    ///   <para>このリポジトリの場所。</para>
    ///   <para>lugar de un repositorio.</para>
    ///   <para>Location of a repository.</para>
    ///   <para>Lokation eines Repositorys.</para>
    ///   <para>Emplacement d'un dépôt.</para>
    /// labels<para>lugar del respositorio</para><para>emplacement du dépôt</para><para>Repository Lokation</para><para>repository location</para><para>umístění úložiště</para><para>このリポジトリのURL</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#location">http://usefulinc.com/ns/doap#location</seealso>
    let location = Prefixed_Name(doap, "location") |> PrefixedName
    /// <summary>
    ///   <para>doap:mailing-list</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Domovská stránka nebo e–mailová adresa e–mailové diskuse.</para>
    ///   <para>Página web de la lista de correo o dirección de correo.</para>
    ///   <para>メーリングリストのホームページやメールアドレス</para>
    ///   <para>Homepage der Mailing Liste oder E-Mail Adresse.</para>
    ///   <para>Page web de la liste de diffusion, ou adresse de courriel.</para>
    ///   <para>Mailing list home page or email address.</para>
    /// labels<para>liste de diffusion</para><para>e–mailová diskuse</para><para>lista de correo</para><para>Mailing Liste</para><para>mailing list</para><para>メーリングリスト</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#mailing-list">http://usefulinc.com/ns/doap#mailing-list</seealso>
    let mailing_list = Prefixed_Name(doap, "mailing-list") |> PrefixedName
    /// <summary>
    ///   <para>doap:CVSRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Repositorio CVS del código fuente.</para>
    ///   <para>CVS source code repository.</para>
    ///   <para>CVS Quellcode-Versionierungssystem.</para>
    ///   <para>Dépôt CVS du code source.</para>
    ///   <para>Úložiště zdrojových kódů CVS.</para>
    ///   <para>ソースコードのCVSのリポジトリ</para>
    /// labels<para>Repositorio CVS</para><para>CVS Repository</para><para>CVS Repository</para><para>Úložiště CVS</para><para>CVSのリポジトリ</para><para>Dépôt CVS</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#CVSRepository">http://usefulinc.com/ns/doap#CVSRepository</seealso>
    let CVSRepository = Prefixed_Name(doap, "CVSRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Úložiště zdrojových kódů.</para>
    ///   <para>このプロジェクトのソースコードのリポジトリ</para>
    ///   <para>Quellcode-Versionierungssystem.</para>
    ///   <para>Repositorio del código fuente.</para>
    ///   <para>Dépôt du code source.</para>
    ///   <para>Source code repository.</para>
    /// labels<para>repositorio</para><para>Repository</para><para>repository</para><para>úložiště</para><para>リポジトリ</para><para>dépôt</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#repository">http://usefulinc.com/ns/doap#repository</seealso>
    let repository = Prefixed_Name(doap, "repository") |> PrefixedName
    /// <summary>
    ///   <para>doap:DarcsRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>darcs source code repository.</para>
    ///   <para>Dépôt darcs du code source.</para>
    ///   <para>ソースコードのdarcsのリポジトリ</para>
    ///   <para>Repositorio darcs del código fuente.</para>
    /// labels<para>Repositorio darcs</para><para>darcs Repository</para><para>Dépôt darcs</para><para>darcsのリポジトリ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#DarcsRepository">http://usefulinc.com/ns/doap#DarcsRepository</seealso>
    let DarcsRepository = Prefixed_Name(doap, "DarcsRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:GitRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>ソースコードのGitのリポジトリ</para>
    ///   <para>Git Quellcode-Versionierungssystem.</para>
    ///   <para>Repositorio Git del código fuente.</para>
    ///   <para>Dépôt Git du code source.</para>
    ///   <para>Úložiště zdrojových kódů Git.</para>
    ///   <para>Git source code repository.</para>
    /// labels<para>Repositorio Git</para><para>Git repository</para><para>Git Repository</para><para>Úložiště Git</para><para>Gitのリポジトリ</para><para>Dépôt Git</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#GitRepository">http://usefulinc.com/ns/doap#GitRepository</seealso>
    let GitRepository = Prefixed_Name(doap, "GitRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:HgRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Mercurial source code repository.</para>
    ///   <para>ソースコードのMercurialのリポジトリ</para>
    /// labels<para>Mercurial Repository</para><para>Mercurialのリポジトリ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#HgRepository">http://usefulinc.com/ns/doap#HgRepository</seealso>
    let HgRepository = Prefixed_Name(doap, "HgRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>プログラミングのプロジェクト</para>
    ///   <para>Ein Projekt.</para>
    ///   <para>Un projet.</para>
    ///   <para>Un proyecto.</para>
    ///   <para>A project.</para>
    ///   <para>Projekt.</para>
    /// labels<para>Proyecto</para><para>Projekt</para><para>Prijekt</para><para>Project</para><para>Projet</para><para>プロジェクト</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#Project">http://usefulinc.com/ns/doap#Project</seealso>
    let Project = Prefixed_Name(doap, "Project") |> PrefixedName
    /// <summary>
    ///   <para>doap:SVNRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Úložiště zdrojových kódů Subversion.</para>
    ///   <para>Subversion Quellcode-Versionierungssystem.</para>
    ///   <para>Dépôt Subversion du code source.</para>
    ///   <para>ソースコードのSubversionのリポジトリ</para>
    ///   <para>Repositorio Subversion del código fuente.</para>
    ///   <para>Subversion source code repository.</para>
    /// labels<para>Repositorio Subversion</para><para>Subversion Repository</para><para>Subversion Repository</para><para>Úložiště Subversion</para><para>Dépôt Subversion</para><para>Subversionのリポジトリ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#SVNRepository">http://usefulinc.com/ns/doap#SVNRepository</seealso>
    let SVNRepository = Prefixed_Name(doap, "SVNRepository") |> PrefixedName
    /// <summary>
    ///   <para>doap:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Información sobre la versión de un release del proyecto.</para>
    ///   <para>Détails sur une version d'une realease d'un projet.</para>
    ///   <para>Version information of a project release.</para>
    ///   <para>リリースのバーション情報</para>
    ///   <para>Informace o uvolněné verzi projektu.</para>
    ///   <para>Versionsinformation eines Projekt Releases.</para>
    /// labels<para>Version</para><para>Version</para><para>Version</para><para>Versión</para><para>バーション</para><para>Verze</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#Version">http://usefulinc.com/ns/doap#Version</seealso>
    let Version = Prefixed_Name(doap, "Version") |> PrefixedName
    /// <summary>
    ///   <para>doap:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of target user base</para>
    ///   <para>目指したユーザたちの説明</para>
    /// labels<para>audience</para><para>目指したユーザ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#audience">http://usefulinc.com/ns/doap#audience</seealso>
    let audience = Prefixed_Name(doap, "audience") |> PrefixedName
    /// <summary>
    ///   <para>doap:blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>このプロジェクトに関するブログのURI</para>
    ///   <para>URI of a blog related to a project</para>
    /// labels<para>blog</para><para>ブログ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#blog">http://usefulinc.com/ns/doap#blog</seealso>
    let blog = Prefixed_Name(doap, "blog") |> PrefixedName
    /// <summary>
    ///   <para>doap:browse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>このリポジトリのウェブのウェブのユーザインタフェース</para>
    ///   <para>Web-Browser Interface für das Repository.</para>
    ///   <para>Interface web au dépôt.</para>
    ///   <para>Web browser interface to repository.</para>
    ///   <para>Webové rozhraní pro prohlížení úložiště.</para>
    ///   <para>Interface web del repositorio.</para>
    /// labels<para>ウェブのユーザインタフェース</para><para>visualiser</para><para>prohlížeč</para><para>navegar</para><para>browse</para><para>browse</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#browse">http://usefulinc.com/ns/doap#browse</seealso>
    let browse = Prefixed_Name(doap, "browse") |> PrefixedName
    /// <summary>
    ///   <para>doap:Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A specification of a system's aspects, technical or otherwise.</para>
    ///   <para>あるシステムの詳しく書いた明細書。多分技術的なもの。</para>
    /// labels<para>Specification</para><para>明細書じ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#Specification">http://usefulinc.com/ns/doap#Specification</seealso>
    let Specification = Prefixed_Name(doap, "Specification") |> PrefixedName
    /// <summary>
    ///   <para>doap:anon-root</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Repository für anonymen Zugriff</para>
    ///   <para>Repositorio para acceso anónimo.</para>
    ///   <para>Úložiště pro anonymní přístup.</para>
    ///   <para>Dépôt pour accès anonyme.</para>
    ///   <para>Repository for anonymous access.</para>
    ///   <para>匿名でアクセスできるパス</para>
    /// labels<para>anonymous root</para><para>racine anonyme</para><para>anonymní kořen</para><para>Anonymes Root</para><para>raíz anónima</para><para>匿名ルート</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#anon-root">http://usefulinc.com/ns/doap#anon-root</seealso>
    let anon_root = Prefixed_Name(doap, "anon-root") |> PrefixedName
    /// <summary>
    ///   <para>doap:bug-database</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Fehlerdatenbank eines Projektes.</para>
    ///   <para>Suivi des bugs pour un projet.</para>
    ///   <para>Bug tracker para un proyecto.</para>
    ///   <para>Správa chyb projektu.</para>
    ///   <para>このプロジェクのバグ管理ページ</para>
    ///   <para>Bug tracker for a project.</para>
    /// labels<para>base de datos de bugs</para><para>Fehlerdatenbank</para><para>suivi des bugs</para><para>databáze chyb</para><para>bug database</para><para>バグページ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#bug-database">http://usefulinc.com/ns/doap#bug-database</seealso>
    let bug_database = Prefixed_Name(doap, "bug-database") |> PrefixedName
    /// <summary>
    ///   <para>doap:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Kategorie projektu.</para>
    ///   <para>Une catégorie de projet.</para>
    ///   <para>Una categoría de proyecto.</para>
    ///   <para>このプロジェクトの分類。</para>
    ///   <para>Eine Kategorie eines Projektes.</para>
    ///   <para>A category of project.</para>
    /// labels<para>Kategorie</para><para>categoría</para><para>catégorie</para><para>kategorie</para><para>category</para><para>分類</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#category">http://usefulinc.com/ns/doap#category</seealso>
    let category = Prefixed_Name(doap, "category") |> PrefixedName
    /// <summary>
    ///   <para>doap:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Descripción en texto plano de un proyecto, de 2 a 4 enunciados de longitud.</para>
    ///   <para>Texte descriptif d'un projet, long de 2 à 4 phrases.</para>
    ///   <para>Plain text description of a project, of 2-4 sentences in length.</para>
    ///   <para>プロジェクトの文の説明、2から4までの行数。</para>
    ///   <para>Beschreibung eines Projekts als einfacher Text mit der Länge von 2 bis 4 Sätzen.</para>
    ///   <para>Čistě textový, 2 až 4 věty dlouhý popis projektu.</para>
    /// labels<para>Beschreibung</para><para>description</para><para>description</para><para>descripción</para><para>popis</para><para>説明</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#description">http://usefulinc.com/ns/doap#description</seealso>
    let description = Prefixed_Name(doap, "description") |> PrefixedName
    /// <summary>
    ///   <para>doap:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Datum, kdy bylo něco vytvořeno ve formátu RRRR-MM-DD, např. 2004-04-05</para>
    ///   <para>Date à laquelle a été créé quelque chose, au format AAAA-MM-JJ (par ex. 2004-04-05)</para>
    ///   <para>何かが作成された日付、AAAA-MM-JJの型、例えば2004-04-05。</para>
    ///   <para>Fecha en la que algo fue creado, en formato AAAA-MM-DD. e.g. 2004-04-05</para>
    ///   <para>Erstellungsdatum von Irgendwas, angegeben im YYYY-MM-DD Format, z.B. 2004-04-05.</para>
    ///   <para>Date when something was created, in YYYY-MM-DD form. e.g. 2004-04-05</para>
    /// labels<para>vytvořeno</para><para>erstellt</para><para>created</para><para>creado</para><para>créé</para><para>作成日付</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#created">http://usefulinc.com/ns/doap#created</seealso>
    let created = Prefixed_Name(doap, "created") |> PrefixedName
    /// <summary>
    ///   <para>doap:documenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Contributor of documentation to the project.</para>
    ///   <para>Mitarbeiter an der Dokumentation eines Projektes.</para>
    ///   <para>Proveedor de documentación para el proyecto.</para>
    ///   <para>Spoluautor dokumentace projektu.</para>
    ///   <para>Collaborateur à la documentation du projet.</para>
    ///   <para>このプロジェクトのドキュメントの貢献者</para>
    /// labels<para>rédacteur de l'aide</para><para>escritor de ayuda</para><para>dokumentarista</para><para>Dokumentator</para><para>documenter</para><para>文章制作者</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#documenter">http://usefulinc.com/ns/doap#documenter</seealso>
    let documenter = Prefixed_Name(doap, "documenter") |> PrefixedName
    /// <summary>
    ///   <para>doap:download-mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Mirror de la página web de descarga.</para>
    ///   <para>Zrcadlo stránky pro stažení softwaru.</para>
    ///   <para>Miroir de la page de téléchargement du programme.</para>
    ///   <para>Spiegel der Seite von die Projekt-Software heruntergeladen werden kann.</para>
    ///   <para>このプロジェクトのダウンロードミラー</para>
    ///   <para>Mirror of software download web page.</para>
    /// labels<para>Spiegel der Seite zum Herunterladen</para><para>miroir pour le téléchargement</para><para>zrcadlo stránky pro stažení</para><para>mirror de descarga</para><para>download mirror</para><para>ダウンロードミラー</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#download-mirror">http://usefulinc.com/ns/doap#download-mirror</seealso>
    let download_mirror = Prefixed_Name(doap, "download-mirror") |> PrefixedName
    /// <summary>
    ///   <para>doap:download-page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Web-Seite von der die Projekt-Software heruntergeladen werden kann.</para>
    ///   <para>Página web de la cuál se puede bajar el software.</para>
    ///   <para>Page web à partir de laquelle on peut télécharger le programme.</para>
    ///   <para>Webová stránka, na které lze stáhnout projektový software.</para>
    ///   <para>このプロジェクトのダウンロードできるウェブページ</para>
    ///   <para>Web page from which the project software can be downloaded.</para>
    /// labels<para>Seite zum Herunterladen</para><para>page de téléchargement</para><para>stránka pro stažení</para><para>página de descarga</para><para>download page</para><para>ダウンロードページ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#download-page">http://usefulinc.com/ns/doap#download-page</seealso>
    let download_page = Prefixed_Name(doap, "download-page") |> PrefixedName
    /// <summary>
    ///   <para>doap:file-release</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URI of download associated with this release.</para>
    ///   <para>URI adresa stažení asociované s revizí.</para>
    /// labels<para>このリリースのダウンロードできるファイルのURI</para><para>soubor revize</para><para>file-release</para><para>ファイル</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#file-release">http://usefulinc.com/ns/doap#file-release</seealso>
    let file_release = Prefixed_Name(doap, "file-release") |> PrefixedName
    /// <summary>
    ///   <para>doap:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>このプロジェクトのホームページのURL。このホームページは他のプロジェクトのホームページじゃないこと。</para>
    ///   <para>El URL de la página de un proyecto,
    /// 		asociada con exactamente un proyecto.</para>
    ///   <para>URL adresa domovské stránky projektu asociované s právě jedním projektem.</para>
    ///   <para>URL der Projekt-Homepage,
    /// 		verbunden mit genau einem Projekt.</para>
    ///   <para>URL of a project's homepage,
    /// 		associated with exactly one project.</para>
    ///   <para>L'URL de la page web d'un projet,
    /// 		associée avec un unique projet.</para>
    /// labels<para>domovská stránka</para><para>página web</para><para>Homepage</para><para>page web</para><para>homepage</para><para>ホームページ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#homepage">http://usefulinc.com/ns/doap#homepage</seealso>
    let homepage = Prefixed_Name(doap, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>doap:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>このプロジェクトが実装したシステムの明細書。標準やAPIや明細書のようなもの。</para>
    ///   <para>A specification that a project implements. Could be a standard, API or legally defined level of conformance.</para>
    /// labels<para>Implements specification</para><para>実装した明細書</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#implements">http://usefulinc.com/ns/doap#implements</seealso>
    let implements = Prefixed_Name(doap, "implements") |> PrefixedName
    /// <summary>
    ///   <para>doap:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>ISO language code a project has been translated into</para>
    ///   <para>このプロジェクトの翻訳された言語のISO言語コート</para>
    /// labels<para>language</para><para>言語</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#language">http://usefulinc.com/ns/doap#language</seealso>
    let language = Prefixed_Name(doap, "language") |> PrefixedName
    /// <summary>
    ///   <para>doap:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>このプロジェクトの散布ライセンスのRDF説明のURI</para>
    ///   <para>Die URI einer RDF-Beschreibung einer Lizenz unter der die Software herausgegeben wird.</para>
    ///   <para>L'URI d'une description RDF de la licence sous laquelle le programme est distribué.</para>
    ///   <para>URI adresa RDF popisu licence, pod kterou je software distribuován.</para>
    ///   <para>El URI de una descripción RDF de la licencia bajo la cuál se distribuye el software.</para>
    ///   <para>The URI of an RDF description of the license the software is distributed under.</para>
    /// labels<para>licencia</para><para>licence</para><para>license</para><para>licence</para><para>Lizenz</para><para>ライセンス</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#license">http://usefulinc.com/ns/doap#license</seealso>
    let license = Prefixed_Name(doap, "license") |> PrefixedName
    /// <summary>
    ///   <para>doap:maintainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Hauptentwickler eines Projektes, der Projektleiter</para>
    ///   <para>Développeur principal d'un projet, un meneur du projet.</para>
    ///   <para>このプロジェクトのメンテなー及びリーダ。</para>
    ///   <para>Správce projektu, vedoucí projektu.</para>
    ///   <para>Desarrollador principal de un proyecto, un líder de proyecto.</para>
    ///   <para>Maintainer of a project, a project leader.</para>
    /// labels<para>desarrollador principal</para><para>Projektverantwortlicher</para><para>développeur principal</para><para>maintainer</para><para>správce</para><para>メンテナー</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#maintainer">http://usefulinc.com/ns/doap#maintainer</seealso>
    let maintainer = Prefixed_Name(doap, "maintainer") |> PrefixedName
    /// <summary>
    ///   <para>doap:module</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>このリポジトリのモジュール名前</para>
    ///   <para>Nombre del módulo de un repositorio.</para>
    ///   <para>Nom du module d'un dépôt.</para>
    ///   <para>Module name of a repository.</para>
    ///   <para>Jméno modulu v úložišti.</para>
    ///   <para>Modul-Name eines Subversion.</para>
    /// labels<para>モジュール名前</para><para>module</para><para>módulo</para><para>module</para><para>Modul</para><para>modul</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#module">http://usefulinc.com/ns/doap#module</seealso>
    let module_ = Prefixed_Name(doap, "module") |> PrefixedName
    /// <summary>
    ///   <para>doap:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Jméno něčeho.</para>
    ///   <para>Le nom de quelque chose.</para>
    ///   <para>何かの名前</para>
    ///   <para>El nombre de algo.</para>
    ///   <para>A name of something.</para>
    ///   <para>Der Name von Irgendwas</para>
    /// labels<para>nombre</para><para>jméno</para><para>name</para><para>Name</para><para>nom</para><para>名前</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#name">http://usefulinc.com/ns/doap#name</seealso>
    let name = Prefixed_Name(doap, "name") |> PrefixedName
    /// <summary>
    ///   <para>doap:os</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Operating system that a project is limited to.  Omit this property if the project is not OS-specific.</para>
    ///   <para>Operační systém, na jehož použití je projekt limitován. Vynechejte tuto vlastnost, pokud je projekt nezávislý na operačním systému.</para>
    ///   <para>Système d'exploitation auquel est limité le projet. Omettez cette propriété si le
    /// 		projet n'est pas limité à un système d'exploitation.</para>
    ///   <para>このプロジェクトの限られたオペレーティングシステム。もし、プロジェクトはどのOSも大丈夫なら、このプロパティを書き落としていい。</para>
    ///   <para>Sistema opertivo al cuál está limitado el proyecto.  Omita esta propiedad si el proyecto no es específico
    /// 		de un sistema opertaivo en particular.</para>
    ///   <para>Betriebssystem auf dem das Projekt eingesetzt werden kann. Diese Eigenschaft kann ausgelassen werden, wenn das Projekt nicht BS-spezifisch ist.</para>
    /// labels<para>système d'exploitation</para><para>sistema operativo</para><para>operating system</para><para>operační systém</para><para>Betriebssystem</para><para>オペレーティングシステム</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#os">http://usefulinc.com/ns/doap#os</seealso>
    let os = Prefixed_Name(doap, "os") |> PrefixedName
    /// <summary>
    ///   <para>doap:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicator of software platform (non-OS specific), e.g. Java, Firefox, ECMA CLR</para>
    ///   <para>このプロジェクトの必要なプラットフォーム（OSに関係ない）。例えば：Java、Firefox、ECMA CLRとか。</para>
    /// labels<para>プラットフォーム</para><para>platform</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#platform">http://usefulinc.com/ns/doap#platform</seealso>
    let platform = Prefixed_Name(doap, "platform") |> PrefixedName

    /// <summary>
    ///   <para>doap:programming-language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Programming language a project is implemented in or intended for use with.</para>
    ///   <para>Programovací jazyk, ve kterém je projekt implementován nebo pro který je zamýšlen k použití.</para>
    ///   <para>このプログラミングの実装のプログラミング言語、または目指した言語。</para>
    ///   <para>Lenguaje de programación en el que un proyecto es implementado o con el cuál pretende usarse.</para>
    ///   <para>Programmiersprache in der ein Projekt implementiert ist oder intendiert wird zu benutzen.</para>
    ///   <para>Langage de programmation avec lequel un projet est implémenté,
    /// 		ou avec lequel il est prévu de l'utiliser.</para>
    /// labels<para>langage de programmation</para><para>lenguaje de programación</para><para>programming language</para><para>programovací jazyk</para><para>Programmiersprache</para><para>プログラミング言語</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#programming-language">http://usefulinc.com/ns/doap#programming-language</seealso>
    let programming_language =
        Prefixed_Name(doap, "programming-language") |> PrefixedName

    /// <summary>
    ///   <para>doap:release</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Un release (versión) de un proyecto.</para>
    ///   <para>Une release (révision) d'un projet.</para>
    ///   <para>このプロジェクトのリリース</para>
    ///   <para>A project release.</para>
    ///   <para>Ein Release (Version) eines Projekts.</para>
    ///   <para>Relase (verze) projektu.</para>
    /// labels<para>release</para><para>Release</para><para>release</para><para>release</para><para>release</para><para>リリース</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#release">http://usefulinc.com/ns/doap#release</seealso>
    let release = Prefixed_Name(doap, "release") |> PrefixedName
    /// <summary>
    ///   <para>doap:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifiant de révision d'une release du programme.</para>
    ///   <para>Revision identifier of a software release.</para>
    ///   <para>Indentificador de la versión de un release de software.</para>
    ///   <para>Identifikátor zpřístupněné revize softwaru.</para>
    ///   <para>Versionsidentifikator eines Software-Releases.</para>
    ///   <para>このリリースのリビジョン識別子</para>
    /// labels<para>revision</para><para>révision</para><para>リビジョンコート</para><para>versión</para><para>Version</para><para>verze</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#revision">http://usefulinc.com/ns/doap#revision</seealso>
    let revision = Prefixed_Name(doap, "revision") |> PrefixedName
    /// <summary>
    ///   <para>doap:screenshots</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>スクリーンショットのあるウェブページ</para>
    ///   <para>Página web con capturas de pantalla del proyecto.</para>
    ///   <para>Page web avec des captures d'écran du projet.</para>
    ///   <para>Web-Seite mit Screenshots eines Projektes.</para>
    ///   <para>Web page with screenshots of project.</para>
    ///   <para>Webová stránka projektu se snímky obrazovky.</para>
    /// labels<para>capturas de pantalla</para><para>captures d'écran</para><para>snímek obrazovky</para><para>Screenshots</para><para>screenshots</para><para>スクリーンショット</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#screenshots">http://usefulinc.com/ns/doap#screenshots</seealso>
    let screenshots = Prefixed_Name(doap, "screenshots") |> PrefixedName
    /// <summary>
    ///   <para>doap:service-endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of a web service endpoint where software as a service may be accessed</para>
    ///   <para>ことプロジェクトが提供したサーブスを載せるサイト。</para>
    /// labels<para>service endpoint</para><para>サービスサイト</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#service-endpoint">http://usefulinc.com/ns/doap#service-endpoint</seealso>
    let service_endpoint = Prefixed_Name(doap, "service-endpoint") |> PrefixedName
    /// <summary>
    ///   <para>doap:shortdesc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Texte descriptif concis (8 ou 9 mots) d'un projet.</para>
    ///   <para>Short (8 or 9 words) plain text description of a project.</para>
    ///   <para>Krátký (8 nebo 9 slov) čistě textový popis projektu.</para>
    ///   <para>日本語の二十文字ぐらいの説明</para>
    ///   <para>Kurzbeschreibung (8 oder 9 Wörter) eines Projects als einfacher Text.</para>
    ///   <para>Descripción corta (8 o 9 palabras) en texto plano de un proyecto.</para>
    /// labels<para>description courte</para><para>short description</para><para>descripción corta</para><para>Kurzbeschreibung</para><para>krátký popis</para><para>簡単な説明</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#shortdesc">http://usefulinc.com/ns/doap#shortdesc</seealso>
    let shortdesc = Prefixed_Name(doap, "shortdesc") |> PrefixedName
    /// <summary>
    ///   <para>doap:tester</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A tester or other quality control contributor.</para>
    ///   <para>このプロジェクトのため、試験をする人や品質メンテナー。</para>
    ///   <para>Un testeur ou un collaborateur au contrôle qualité.</para>
    ///   <para>Un tester u otro proveedor de control de calidad.</para>
    ///   <para>Tester nebo jiný spoluautor kontrolující kvalitu.</para>
    ///   <para>Ein Tester oder anderer Mitarbeiter der Qualitätskontrolle.</para>
    /// labels<para>testeur</para><para>tester</para><para>tester</para><para>tester</para><para>Tester</para><para>試験者</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#tester">http://usefulinc.com/ns/doap#tester</seealso>
    let tester = Prefixed_Name(doap, "tester") |> PrefixedName
    /// <summary>
    ///   <para>doap:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Spoluautor překladu projektu.</para>
    ///   <para>このプロジェクトを翻訳する貢献者</para>
    ///   <para>Mitarbeiter an den Übersetzungen eines Projektes.</para>
    ///   <para>Contributor of translations to the project.</para>
    ///   <para>Collaborateur à la traduction du projet.</para>
    ///   <para>Proveedor de traducciones al proyecto.</para>
    /// labels<para>překladatel</para><para>Übersetzer</para><para>translator</para><para>traducteur</para><para>traductor</para><para>翻訳者</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#translator">http://usefulinc.com/ns/doap#translator</seealso>
    let translator = Prefixed_Name(doap, "translator") |> PrefixedName
    /// <summary>
    ///   <para>doap:vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vendor organization: commercial, free or otherwise</para>
    ///   <para>提供組織、商業の組織や自由の組織。</para>
    /// labels<para>vendor</para><para>提供組織</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#vendor">http://usefulinc.com/ns/doap#vendor</seealso>
    let vendor = Prefixed_Name(doap, "vendor") |> PrefixedName
    /// <summary>
    ///   <para>doap:wiki</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>L'URL du Wiki pour la discussion collaborative sur le projet.</para>
    ///   <para>URL del Wiki para discusión colaborativa del proyecto.</para>
    ///   <para>このプロジェクトの討論用ウィキ</para>
    ///   <para>URL of Wiki for collaborative discussion of project.</para>
    ///   <para>Wiki-URL für die kollaborative Dikussion eines Projektes.</para>
    ///   <para>URL adresa wiki projektu pro společné diskuse.</para>
    /// labels<para>wiki</para><para>wiki</para><para>wiki</para><para>wiki</para><para>Wiki</para><para>ウィキ</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#wiki">http://usefulinc.com/ns/doap#wiki</seealso>
    let wiki = Prefixed_Name(doap, "wiki") |> PrefixedName
    /// <summary>
    ///   <para>doap:developer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>プロジェクトのソフトウェアの開発者</para>
    ///   <para>Developer of software for the project.</para>
    ///   <para>Vývojář softwaru projektu.</para>
    ///   <para>Desarrollador de software para el proyecto.</para>
    ///   <para>Développeur pour le projet.</para>
    ///   <para>Software-Entwickler für eine Projekt.</para>
    /// labels<para>desarrollador</para><para>développeur</para><para>Entwickler</para><para>developer</para><para>vývojář</para><para>開発者</para></remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#developer">http://usefulinc.com/ns/doap#developer</seealso>
    let developer = Prefixed_Name(doap, "developer") |> PrefixedName
    /// <summary>
    ///   <para>doap:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://usefulinc.com/ns/doap#">http://usefulinc.com/ns/doap#</seealso>
    let _prefix_iri = Prefixed_Name(doap, "") |> PrefixedName

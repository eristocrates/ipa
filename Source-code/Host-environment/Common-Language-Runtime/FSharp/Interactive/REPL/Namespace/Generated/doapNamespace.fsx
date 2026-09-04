#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module doap =
    let _prefixId = PrefixId.fromNamespaceLabel "http://usefulinc.com/ns/doap#" "doap"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Dépôt GNU Archrdfs:label : GNU Archのリポジトリrdfs:label : Repositorio GNU Archrdfs:label : Úložiště GNU Archrdfs:label : GNU Arch repositoryrdfs:label : GNU Arch repository</para>
    ///   <para>rdfs:comment : GNU Arch source code repository.rdfs:comment : Úložiště zdrojových kódů GNU Arch.rdfs:comment : Dépôt GNU Arch du code source.rdfs:comment : ソースコードのGNU Archのリポジトリrdfs:comment : Repositorio GNU Arch del código fuente.rdfs:comment : GNU Arch Quellcode-Versionierungssystem.</para>
    ///   <a href="http://usefulinc.com/ns/doap#ArchRepository">doap:ArchRepository</a>
    /// </summary>
    let ArchRepository = _prefixId.prefix "ArchRepository"
    /// <summary>
    ///   <para>rdfs:comment : Dépôt BitKeeper du code source.rdfs:comment : Úložiště zdrojových kódů BitKeeper.rdfs:comment : BitKeeper Quellcode-Versionierungssystem.rdfs:comment : Repositorio BitKeeper del código fuente.rdfs:comment : ソースコードのBitKeeperのリポジトリrdfs:comment : BitKeeper source code repository.</para>
    ///   <para>rdfs:label : BitKeeperのリポジトリrdfs:label : BitKeeper Repositoryrdfs:label : BitKeeper Repositoryrdfs:label : Dépôt BitKeeperrdfs:label : Úložiště BitKeeperrdfs:label : Repositorio BitKeeper</para>
    ///   <a href="http://usefulinc.com/ns/doap#BKRepository">doap:BKRepository</a>
    /// </summary>
    let BKRepository = _prefixId.prefix "BKRepository"
    /// <summary>
    ///   <para>rdfs:comment : ソースコードのBazzarのリポジトリrdfs:comment : Bazaar source code branch.</para>
    ///   <para>rdfs:label : Bazzarのリポジトリrdfs:label : Bazaar Branch</para>
    ///   <a href="http://usefulinc.com/ns/doap#BazaarBranch">doap:BazaarBranch</a>
    /// </summary>
    let BazaarBranch = _prefixId.prefix "BazaarBranch"
    /// <summary>
    ///   <para>rdfs:comment : Dépôt CVS du code source.rdfs:comment : Úložiště zdrojových kódů CVS.rdfs:comment : CVS Quellcode-Versionierungssystem.rdfs:comment : CVS source code repository.rdfs:comment : ソースコードのCVSのリポジトリrdfs:comment : Repositorio CVS del código fuente.</para>
    ///   <para>rdfs:label : CVS Repositoryrdfs:label : CVS Repositoryrdfs:label : Úložiště CVSrdfs:label : Dépôt CVSrdfs:label : CVSのリポジトリrdfs:label : Repositorio CVS</para>
    ///   <a href="http://usefulinc.com/ns/doap#CVSRepository">doap:CVSRepository</a>
    /// </summary>
    let CVSRepository = _prefixId.prefix "CVSRepository"
    /// <summary>
    ///   <para>rdfs:label : darcs Repositoryrdfs:label : Dépôt darcsrdfs:label : darcsのリポジトリrdfs:label : Repositorio darcs</para>
    ///   <para>rdfs:comment : Dépôt darcs du code source.rdfs:comment : Repositorio darcs del código fuente.rdfs:comment : darcs source code repository.rdfs:comment : ソースコードのdarcsのリポジトリ</para>
    ///   <a href="http://usefulinc.com/ns/doap#DarcsRepository">doap:DarcsRepository</a>
    /// </summary>
    let DarcsRepository = _prefixId.prefix "DarcsRepository"
    /// <summary>
    ///   <para>rdfs:label : Dépôt Gitrdfs:label : Git Repositoryrdfs:label : Úložiště Gitrdfs:label : Gitのリポジトリrdfs:label : Repositorio Gitrdfs:label : Git repository</para>
    ///   <para>rdfs:comment : Repositorio Git del código fuente.rdfs:comment : Dépôt Git du code source.rdfs:comment : Úložiště zdrojových kódů Git.rdfs:comment : ソースコードのGitのリポジトリrdfs:comment : Git source code repository.rdfs:comment : Git Quellcode-Versionierungssystem.</para>
    ///   <a href="http://usefulinc.com/ns/doap#GitRepository">doap:GitRepository</a>
    /// </summary>
    let GitRepository = _prefixId.prefix "GitRepository"
    /// <summary>
    ///   <para>rdfs:comment : ソースコードのMercurialのリポジトリrdfs:comment : Mercurial source code repository.</para>
    ///   <para>rdfs:label : Mercurialのリポジトリrdfs:label : Mercurial Repository</para>
    ///   <a href="http://usefulinc.com/ns/doap#HgRepository">doap:HgRepository</a>
    /// </summary>
    let HgRepository = _prefixId.prefix "HgRepository"
    /// <summary>
    ///   <para>rdfs:label : Proyectordfs:label : Projetrdfs:label : Projectrdfs:label : Projektrdfs:label : Prijektrdfs:label : プロジェクト</para>
    ///   <para>rdfs:comment : プログラミングのプロジェクトrdfs:comment : Projekt.rdfs:comment : Un proyecto.rdfs:comment : Ein Projekt.rdfs:comment : Un projet.rdfs:comment : A project.</para>
    ///   <a href="http://usefulinc.com/ns/doap#Project">doap:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Úložištěrdfs:label : リポジトリrdfs:label : Repositoryrdfs:label : Repositoryrdfs:label : Dépôtrdfs:label : Repositorio</para>
    ///   <para>rdfs:comment : ソースコードのリポジトリrdfs:comment : Source code repository.rdfs:comment : Dépôt du code source.rdfs:comment : Quellcode-Versionierungssystem.rdfs:comment : Úložiště zdrojových kódů.rdfs:comment : Repositorio del código fuente.</para>
    ///   <a href="http://usefulinc.com/ns/doap#Repository">doap:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:label : Dépôt Subversionrdfs:label : Subversion Repositoryrdfs:label : Subversion Repositoryrdfs:label : Úložiště Subversionrdfs:label : Subversionのリポジトリrdfs:label : Repositorio Subversion</para>
    ///   <para>rdfs:comment : Subversion source code repository.rdfs:comment : Úložiště zdrojových kódů Subversion.rdfs:comment : Dépôt Subversion du code source.rdfs:comment : ソースコードのSubversionのリポジトリrdfs:comment : Subversion Quellcode-Versionierungssystem.rdfs:comment : Repositorio Subversion del código fuente.</para>
    ///   <a href="http://usefulinc.com/ns/doap#SVNRepository">doap:SVNRepository</a>
    /// </summary>
    let SVNRepository = _prefixId.prefix "SVNRepository"
    /// <summary>
    ///   <para>rdfs:comment : あるシステムの詳しく書いた明細書。多分技術的なもの。rdfs:comment : A specification of a system's aspects, technical or otherwise.</para>
    ///   <para>rdfs:label : 明細書じrdfs:label : Specification</para>
    ///   <a href="http://usefulinc.com/ns/doap#Specification">doap:Specification</a>
    /// </summary>
    let Specification = _prefixId.prefix "Specification"
    /// <summary>
    ///   <para>rdfs:comment : リリースのバーション情報rdfs:comment : Información sobre la versión de un release del proyecto.rdfs:comment : Détails sur une version d'une realease d'un projet.rdfs:comment : Informace o uvolněné verzi projektu.rdfs:comment : Version information of a project release.rdfs:comment : Versionsinformation eines Projekt Releases.</para>
    ///   <para>rdfs:label : Versionrdfs:label : Versionrdfs:label : Versionrdfs:label : バーションrdfs:label : Verzerdfs:label : Versión</para>
    ///   <a href="http://usefulinc.com/ns/doap#Version">doap:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:comment : Repository für anonymen Zugriffrdfs:comment : Repositorio para acceso anónimo.rdfs:comment : Úložiště pro anonymní přístup.rdfs:comment : Dépôt pour accès anonyme.rdfs:comment : 匿名でアクセスできるパスrdfs:comment : Repository for anonymous access.</para>
    ///   <para>rdfs:label : raíz anónimardfs:label : anonymní kořenrdfs:label : anonymous rootrdfs:label : 匿名ルートrdfs:label : racine anonymerdfs:label : Anonymes Root</para>
    ///   <a href="http://usefulinc.com/ns/doap#anon-root">doap:anon-root</a>
    /// </summary>
    let anon_root = _prefixId.prefix "anon-root"
    /// <summary>
    ///   <para>rdfs:comment : 目指したユーザたちの説明rdfs:comment : Description of target user base</para>
    ///   <para>rdfs:label : 目指したユーザrdfs:label : audience</para>
    ///   <a href="http://usefulinc.com/ns/doap#audience">doap:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>rdfs:comment : このプロジェクトに関するブログのURIrdfs:comment : URI of a blog related to a project</para>
    ///   <para>rdfs:label : ブログrdfs:label : blog</para>
    ///   <a href="http://usefulinc.com/ns/doap#blog">doap:blog</a>
    /// </summary>
    let blog = _prefixId.prefix "blog"
    /// <summary>
    ///   <para>rdfs:label : browserdfs:label : ウェブのユーザインタフェースrdfs:label : navegarrdfs:label : visualiserrdfs:label : prohlížečrdfs:label : browse</para>
    ///   <para>rdfs:comment : Webové rozhraní pro prohlížení úložiště.rdfs:comment : Web browser interface to repository.rdfs:comment : Interface web au dépôt.rdfs:comment : Interface web del repositorio.rdfs:comment : Web-Browser Interface für das Repository.rdfs:comment : このリポジトリのウェブのウェブのユーザインタフェース</para>
    ///   <a href="http://usefulinc.com/ns/doap#browse">doap:browse</a>
    /// </summary>
    let browse = _prefixId.prefix "browse"
    /// <summary>
    ///   <para>rdfs:label : databáze chybrdfs:label : suivi des bugsrdfs:label : Fehlerdatenbankrdfs:label : バグページrdfs:label : bug databaserdfs:label : base de datos de bugs</para>
    ///   <para>rdfs:comment : Suivi des bugs pour un projet.rdfs:comment : Bug tracker for a project.rdfs:comment : Fehlerdatenbank eines Projektes.rdfs:comment : Bug tracker para un proyecto.rdfs:comment : このプロジェクのバグ管理ページrdfs:comment : Správa chyb projektu.</para>
    ///   <a href="http://usefulinc.com/ns/doap#bug-database">doap:bug-database</a>
    /// </summary>
    let bug_database = _prefixId.prefix "bug-database"
    /// <summary>
    ///   <para>rdfs:label : categoryrdfs:label : 分類rdfs:label : categoríardfs:label : kategorierdfs:label : Kategorierdfs:label : catégorie</para>
    ///   <para>rdfs:comment : Kategorie projektu.rdfs:comment : Eine Kategorie eines Projektes.rdfs:comment : このプロジェクトの分類。rdfs:comment : A category of project.rdfs:comment : Una categoría de proyecto.rdfs:comment : Une catégorie de projet.</para>
    ///   <a href="http://usefulinc.com/ns/doap#category">doap:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : createdrdfs:label : erstelltrdfs:label : vytvořenordfs:label : 作成日付rdfs:label : creadordfs:label : créé</para>
    ///   <para>rdfs:comment : Erstellungsdatum von Irgendwas, angegeben im YYYY-MM-DD Format, z.B. 2004-04-05.rdfs:comment : Datum, kdy bylo něco vytvořeno ve formátu RRRR-MM-DD, např. 2004-04-05rdfs:comment : Fecha en la que algo fue creado, en formato AAAA-MM-DD. e.g. 2004-04-05rdfs:comment : 何かが作成された日付、AAAA-MM-JJの型、例えば2004-04-05。rdfs:comment : Date when something was created, in YYYY-MM-DD form. e.g. 2004-04-05rdfs:comment : Date à laquelle a été créé quelque chose, au format AAAA-MM-JJ (par ex. 2004-04-05)</para>
    ///   <a href="http://usefulinc.com/ns/doap#created">doap:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:comment : Čistě textový, 2 až 4 věty dlouhý popis projektu.rdfs:comment : Texte descriptif d'un projet, long de 2 à 4 phrases.rdfs:comment : プロジェクトの文の説明、2から4までの行数。rdfs:comment : Descripción en texto plano de un proyecto, de 2 a 4 enunciados de longitud.rdfs:comment : Beschreibung eines Projekts als einfacher Text mit der Länge von 2 bis 4 Sätzen.rdfs:comment : Plain text description of a project, of 2-4 sentences in length.</para>
    ///   <para>rdfs:label : descripciónrdfs:label : popisrdfs:label : descriptionrdfs:label : descriptionrdfs:label : Beschreibungrdfs:label : 説明</para>
    ///   <a href="http://usefulinc.com/ns/doap#description">doap:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : プロジェクトのソフトウェアの開発者rdfs:comment : Vývojář softwaru projektu.rdfs:comment : Desarrollador de software para el proyecto.rdfs:comment : Développeur pour le projet.rdfs:comment : Developer of software for the project.rdfs:comment : Software-Entwickler für eine Projekt.</para>
    ///   <para>rdfs:label : Entwicklerrdfs:label : vývojářrdfs:label : développeurrdfs:label : 開発者rdfs:label : desarrolladorrdfs:label : developer</para>
    ///   <a href="http://usefulinc.com/ns/doap#developer">doap:developer</a>
    /// </summary>
    let developer = _prefixId.prefix "developer"
    /// <summary>
    ///   <para>rdfs:comment : Proveedor de documentación para el proyecto.rdfs:comment : Collaborateur à la documentation du projet.rdfs:comment : このプロジェクトのドキュメントの貢献者rdfs:comment : Spoluautor dokumentace projektu.rdfs:comment : Contributor of documentation to the project.rdfs:comment : Mitarbeiter an der Dokumentation eines Projektes.</para>
    ///   <para>rdfs:label : documenterrdfs:label : dokumentaristardfs:label : Dokumentatorrdfs:label : escritor de ayudardfs:label : 文章制作者rdfs:label : rédacteur de l'aide</para>
    ///   <a href="http://usefulinc.com/ns/doap#documenter">doap:documenter</a>
    /// </summary>
    let documenter = _prefixId.prefix "documenter"
    /// <summary>
    ///   <para>rdfs:label : zrcadlo stránky pro staženírdfs:label : miroir pour le téléchargementrdfs:label : ダウンロードミラーrdfs:label : download mirrorrdfs:label : Spiegel der Seite zum Herunterladenrdfs:label : mirror de descarga</para>
    ///   <para>rdfs:comment : Mirror of software download web page.rdfs:comment : Spiegel der Seite von die Projekt-Software heruntergeladen werden kann.rdfs:comment : Zrcadlo stránky pro stažení softwaru.rdfs:comment : Mirror de la página web de descarga.rdfs:comment : Miroir de la page de téléchargement du programme.rdfs:comment : このプロジェクトのダウンロードミラー</para>
    ///   <a href="http://usefulinc.com/ns/doap#download-mirror">doap:download-mirror</a>
    /// </summary>
    let download_mirror = _prefixId.prefix "download-mirror"
    /// <summary>
    ///   <para>rdfs:label : stránka pro staženírdfs:label : ダウンロードページrdfs:label : page de téléchargementrdfs:label : Seite zum Herunterladenrdfs:label : download pagerdfs:label : página de descarga</para>
    ///   <para>rdfs:comment : Web-Seite von der die Projekt-Software heruntergeladen werden kann.rdfs:comment : Webová stránka, na které lze stáhnout projektový software.rdfs:comment : Web page from which the project software can be downloaded.rdfs:comment : Page web à partir de laquelle on peut télécharger le programme.rdfs:comment : このプロジェクトのダウンロードできるウェブページrdfs:comment : Página web de la cuál se puede bajar el software.</para>
    ///   <a href="http://usefulinc.com/ns/doap#download-page">doap:download-page</a>
    /// </summary>
    let download_page = _prefixId.prefix "download-page"
    /// <summary>
    ///   <para>rdfs:label : このリリースのダウンロードできるファイルのURIrdfs:label : ファイルrdfs:label : soubor revizerdfs:label : file-release</para>
    ///   <para>rdfs:comment : URI adresa stažení asociované s revizí.rdfs:comment : URI of download associated with this release.</para>
    ///   <a href="http://usefulinc.com/ns/doap#file-release">doap:file-release</a>
    /// </summary>
    let file_release = _prefixId.prefix "file-release"
    /// <summary>
    ///   <para>rdfs:label : helperrdfs:label : 貢献者rdfs:label : collaborateurrdfs:label : colaboradorrdfs:label : Helferrdfs:label : spoluautor</para>
    ///   <para>rdfs:comment : Spoluautor projektu.rdfs:comment : Projekt-Mitarbeiter.rdfs:comment : Collaborateur au projet.rdfs:comment : このプロジェクトの貢献者rdfs:comment : Project contributor.rdfs:comment : Colaborador del proyecto.</para>
    ///   <a href="http://usefulinc.com/ns/doap#helper">doap:helper</a>
    /// </summary>
    let helper = _prefixId.prefix "helper"
    /// <summary>
    ///   <para>rdfs:label : page webrdfs:label : Homepagerdfs:label : página webrdfs:label : ホームページrdfs:label : homepagerdfs:label : domovská stránka</para>
    ///   <para>rdfs:comment : El URL de la página de un proyecto,
    /// 		asociada con exactamente un proyecto.rdfs:comment : URL of a project's homepage,
    /// 		associated with exactly one project.rdfs:comment : URL der Projekt-Homepage,
    /// 		verbunden mit genau einem Projekt.rdfs:comment : このプロジェクトのホームページのURL。このホームページは他のプロジェクトのホームページじゃないこと。rdfs:comment : L'URL de la page web d'un projet,
    /// 		associée avec un unique projet.rdfs:comment : URL adresa domovské stránky projektu asociované s právě jedním projektem.</para>
    ///   <a href="http://usefulinc.com/ns/doap#homepage">doap:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>rdfs:comment : このプロジェクトが実装したシステムの明細書。標準やAPIや明細書のようなもの。rdfs:comment : A specification that a project implements. Could be a standard, API or legally defined level of conformance.</para>
    ///   <para>rdfs:label : 実装した明細書rdfs:label : Implements specification</para>
    ///   <a href="http://usefulinc.com/ns/doap#implements">doap:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:comment : このプロジェクトの翻訳された言語のISO言語コートrdfs:comment : ISO language code a project has been translated into</para>
    ///   <para>rdfs:label : 言語rdfs:label : language</para>
    ///   <a href="http://usefulinc.com/ns/doap#language">doap:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : L'URI d'une description RDF de la licence sous laquelle le programme est distribué.rdfs:comment : El URI de una descripción RDF de la licencia bajo la cuál se distribuye el software.rdfs:comment : Die URI einer RDF-Beschreibung einer Lizenz unter der die Software herausgegeben wird.rdfs:comment : URI adresa RDF popisu licence, pod kterou je software distribuován.rdfs:comment : このプロジェクトの散布ライセンスのRDF説明のURIrdfs:comment : The URI of an RDF description of the license the software is distributed under.</para>
    ///   <para>rdfs:label : Lizenzrdfs:label : licencerdfs:label : licencerdfs:label : licenserdfs:label : licenciardfs:label : ライセンス</para>
    ///   <a href="http://usefulinc.com/ns/doap#license">doap:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : repository locationrdfs:label : umístění úložištěrdfs:label : lugar del respositoriordfs:label : emplacement du dépôtrdfs:label : Repository Lokationrdfs:label : このリポジトリのURL</para>
    ///   <para>rdfs:comment : このリポジトリの場所。rdfs:comment : Lokation eines Repositorys.rdfs:comment : Location of a repository.rdfs:comment : lugar de un repositorio.rdfs:comment : Emplacement d'un dépôt.rdfs:comment : Umístění úložiště.</para>
    ///   <a href="http://usefulinc.com/ns/doap#location">doap:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : lista de correordfs:label : メーリングリストrdfs:label : mailing listrdfs:label : liste de diffusionrdfs:label : Mailing Listerdfs:label : e–mailová diskuse</para>
    ///   <para>rdfs:comment : メーリングリストのホームページやメールアドレスrdfs:comment : Domovská stránka nebo e–mailová adresa e–mailové diskuse.rdfs:comment : Homepage der Mailing Liste oder E-Mail Adresse.rdfs:comment : Page web de la liste de diffusion, ou adresse de courriel.rdfs:comment : Mailing list home page or email address.rdfs:comment : Página web de la lista de correo o dirección de correo.</para>
    ///   <a href="http://usefulinc.com/ns/doap#mailing-list">doap:mailing-list</a>
    /// </summary>
    let mailing_list = _prefixId.prefix "mailing-list"
    /// <summary>
    ///   <para>rdfs:comment : Správce projektu, vedoucí projektu.rdfs:comment : Développeur principal d'un projet, un meneur du projet.rdfs:comment : このプロジェクトのメンテなー及びリーダ。rdfs:comment : Hauptentwickler eines Projektes, der Projektleiterrdfs:comment : Desarrollador principal de un proyecto, un líder de proyecto.rdfs:comment : Maintainer of a project, a project leader.</para>
    ///   <para>rdfs:label : Projektverantwortlicherrdfs:label : メンテナーrdfs:label : développeur principalrdfs:label : správcerdfs:label : maintainerrdfs:label : desarrollador principal</para>
    ///   <a href="http://usefulinc.com/ns/doap#maintainer">doap:maintainer</a>
    /// </summary>
    let maintainer = _prefixId.prefix "maintainer"
    /// <summary>
    ///   <para>rdfs:comment : このリポジトリのモジュール名前rdfs:comment : Jméno modulu v úložišti.rdfs:comment : Nom du module d'un dépôt.rdfs:comment : Nombre del módulo de un repositorio.rdfs:comment : Modul-Name eines Subversion.rdfs:comment : Module name of a repository.</para>
    ///   <para>rdfs:label : modulerdfs:label : modulerdfs:label : モジュール名前rdfs:label : modulrdfs:label : Modulrdfs:label : módulo</para>
    ///   <a href="http://usefulinc.com/ns/doap#module">doap:module</a>
    /// </summary>
    let module_ = _prefixId.prefix "module"
    /// <summary>
    ///   <para>rdfs:label : nombrerdfs:label : nomrdfs:label : Namerdfs:label : namerdfs:label : 名前rdfs:label : jméno</para>
    ///   <para>rdfs:comment : A name of something.rdfs:comment : Der Name von Irgendwasrdfs:comment : El nombre de algo.rdfs:comment : Jméno něčeho.rdfs:comment : 何かの名前rdfs:comment : Le nom de quelque chose.</para>
    ///   <a href="http://usefulinc.com/ns/doap#name">doap:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : stará domovská stránkardfs:label : 前のホームページrdfs:label : ancienne page webrdfs:label : Alte Homepagerdfs:label : old homepagerdfs:label : página web antigua</para>
    ///   <para>rdfs:comment : URL adresa předešlé domovské stránky projektu asociované s právě jedním projektem.rdfs:comment : URL of a project's past homepage,
    /// 		associated with exactly one project.rdfs:comment : L'URL d'une ancienne page web d'un
    /// 		projet, associée avec un unique projet.rdfs:comment : URL der letzten Projekt-Homepage,
    /// 		verbunden mit genau einem Projekt.rdfs:comment : El URL de la antigua página de un proyecto,
    /// 		asociada con exactamente un proyecto.rdfs:comment : このプロジェクトの前のホームページ。他のプロジェクトの前のホームページじゃないこと。</para>
    ///   <a href="http://usefulinc.com/ns/doap#old-homepage">doap:old-homepage</a>
    /// </summary>
    let old_homepage = _prefixId.prefix "old-homepage"
    /// <summary>
    ///   <para>rdfs:label : operační systémrdfs:label : système d'exploitationrdfs:label : Betriebssystemrdfs:label : sistema operativordfs:label : オペレーティングシステムrdfs:label : operating system</para>
    ///   <para>rdfs:comment : Système d'exploitation auquel est limité le projet. Omettez cette propriété si le
    /// 		projet n'est pas limité à un système d'exploitation.rdfs:comment : Sistema opertivo al cuál está limitado el proyecto.  Omita esta propiedad si el proyecto no es específico
    /// 		de un sistema opertaivo en particular.rdfs:comment : Betriebssystem auf dem das Projekt eingesetzt werden kann. Diese Eigenschaft kann ausgelassen werden, wenn das Projekt nicht BS-spezifisch ist.rdfs:comment : このプロジェクトの限られたオペレーティングシステム。もし、プロジェクトはどのOSも大丈夫なら、このプロパティを書き落としていい。rdfs:comment : Operační systém, na jehož použití je projekt limitován. Vynechejte tuto vlastnost, pokud je projekt nezávislý na operačním systému.rdfs:comment : Operating system that a project is limited to.  Omit this property if the project is not OS-specific.</para>
    ///   <a href="http://usefulinc.com/ns/doap#os">doap:os</a>
    /// </summary>
    let os = _prefixId.prefix "os"
    /// <summary>
    ///   <para>rdfs:comment : このプロジェクトの必要なプラットフォーム（OSに関係ない）。例えば：Java、Firefox、ECMA CLRとか。rdfs:comment : Indicator of software platform (non-OS specific), e.g. Java, Firefox, ECMA CLR</para>
    ///   <para>rdfs:label : プラットフォームrdfs:label : platform</para>
    ///   <a href="http://usefulinc.com/ns/doap#platform">doap:platform</a>
    /// </summary>
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:comment : Programming language a project is implemented in or intended for use with.rdfs:comment : Lenguaje de programación en el que un proyecto es implementado o con el cuál pretende usarse.rdfs:comment : Programmiersprache in der ein Projekt implementiert ist oder intendiert wird zu benutzen.rdfs:comment : Langage de programmation avec lequel un projet est implémenté,
    /// 		ou avec lequel il est prévu de l'utiliser.rdfs:comment : このプログラミングの実装のプログラミング言語、または目指した言語。rdfs:comment : Programovací jazyk, ve kterém je projekt implementován nebo pro který je zamýšlen k použití.</para>
    ///   <para>rdfs:label : programovací jazykrdfs:label : langage de programmationrdfs:label : programming languagerdfs:label : プログラミング言語rdfs:label : lenguaje de programaciónrdfs:label : Programmiersprache</para>
    ///   <a href="http://usefulinc.com/ns/doap#programming-language">doap:programming-language</a>
    /// </summary>
    let programming_language = _prefixId.prefix "programming-language"
    /// <summary>
    ///   <para>rdfs:comment : Un release (versión) de un proyecto.rdfs:comment : Une release (révision) d'un projet.rdfs:comment : A project release.rdfs:comment : Relase (verze) projektu.rdfs:comment : Ein Release (Version) eines Projekts.rdfs:comment : このプロジェクトのリリース</para>
    ///   <para>rdfs:label : Releaserdfs:label : releaserdfs:label : releaserdfs:label : releaserdfs:label : releaserdfs:label : リリース</para>
    ///   <a href="http://usefulinc.com/ns/doap#release">doap:release</a>
    /// </summary>
    let release = _prefixId.prefix "release"
    /// <summary>
    ///   <para>rdfs:comment : Repositorio del código fuente.rdfs:comment : Úložiště zdrojových kódů.rdfs:comment : Source code repository.rdfs:comment : このプロジェクトのソースコードのリポジトリrdfs:comment : Dépôt du code source.rdfs:comment : Quellcode-Versionierungssystem.</para>
    ///   <para>rdfs:label : repositoryrdfs:label : repositoriordfs:label : dépôtrdfs:label : Repositoryrdfs:label : リポジトリrdfs:label : úložiště</para>
    ///   <a href="http://usefulinc.com/ns/doap#repository">doap:repository</a>
    /// </summary>
    let repository = _prefixId.prefix "repository"
    /// <summary>
    ///   <para>rdfs:comment : Revision identifier of a software release.rdfs:comment : Indentificador de la versión de un release de software.rdfs:comment : Identifikátor zpřístupněné revize softwaru.rdfs:comment : Versionsidentifikator eines Software-Releases.rdfs:comment : Identifiant de révision d'une release du programme.rdfs:comment : このリリースのリビジョン識別子</para>
    ///   <para>rdfs:label : Versionrdfs:label : revisionrdfs:label : リビジョンコートrdfs:label : révisionrdfs:label : versiónrdfs:label : verze</para>
    ///   <a href="http://usefulinc.com/ns/doap#revision">doap:revision</a>
    /// </summary>
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:comment : スクリーンショットのあるウェブページrdfs:comment : Web page with screenshots of project.rdfs:comment : Página web con capturas de pantalla del proyecto.rdfs:comment : Page web avec des captures d'écran du projet.rdfs:comment : Webová stránka projektu se snímky obrazovky.rdfs:comment : Web-Seite mit Screenshots eines Projektes.</para>
    ///   <para>rdfs:label : スクリーンショットrdfs:label : snímek obrazovkyrdfs:label : Screenshotsrdfs:label : screenshotsrdfs:label : captures d'écranrdfs:label : capturas de pantalla</para>
    ///   <a href="http://usefulinc.com/ns/doap#screenshots">doap:screenshots</a>
    /// </summary>
    let screenshots = _prefixId.prefix "screenshots"
    /// <summary>
    ///   <para>rdfs:comment : ことプロジェクトが提供したサーブスを載せるサイト。rdfs:comment : The URI of a web service endpoint where software as a service may be accessed</para>
    ///   <para>rdfs:label : サービスサイトrdfs:label : service endpoint</para>
    ///   <a href="http://usefulinc.com/ns/doap#service-endpoint">doap:service-endpoint</a>
    /// </summary>
    let service_endpoint = _prefixId.prefix "service-endpoint"
    /// <summary>
    ///   <para>rdfs:label : Kurzbeschreibungrdfs:label : description courterdfs:label : 簡単な説明rdfs:label : descripción cortardfs:label : krátký popisrdfs:label : short description</para>
    ///   <para>rdfs:comment : Descripción corta (8 o 9 palabras) en texto plano de un proyecto.rdfs:comment : Short (8 or 9 words) plain text description of a project.rdfs:comment : Krátký (8 nebo 9 slov) čistě textový popis projektu.rdfs:comment : 日本語の二十文字ぐらいの説明rdfs:comment : Kurzbeschreibung (8 oder 9 Wörter) eines Projects als einfacher Text.rdfs:comment : Texte descriptif concis (8 ou 9 mots) d'un projet.</para>
    ///   <a href="http://usefulinc.com/ns/doap#shortdesc">doap:shortdesc</a>
    /// </summary>
    let shortdesc = _prefixId.prefix "shortdesc"
    /// <summary>
    ///   <para>rdfs:label : testeurrdfs:label : Testerrdfs:label : 試験者rdfs:label : testerrdfs:label : testerrdfs:label : tester</para>
    ///   <para>rdfs:comment : このプロジェクトのため、試験をする人や品質メンテナー。rdfs:comment : Tester nebo jiný spoluautor kontrolující kvalitu.rdfs:comment : Ein Tester oder anderer Mitarbeiter der Qualitätskontrolle.rdfs:comment : Un testeur ou un collaborateur au contrôle qualité.rdfs:comment : A tester or other quality control contributor.rdfs:comment : Un tester u otro proveedor de control de calidad.</para>
    ///   <a href="http://usefulinc.com/ns/doap#tester">doap:tester</a>
    /// </summary>
    let tester = _prefixId.prefix "tester"
    /// <summary>
    ///   <para>rdfs:label : traductorrdfs:label : translatorrdfs:label : 翻訳者rdfs:label : Übersetzerrdfs:label : traducteurrdfs:label : překladatel</para>
    ///   <para>rdfs:comment : Proveedor de traducciones al proyecto.rdfs:comment : Mitarbeiter an den Übersetzungen eines Projektes.rdfs:comment : Contributor of translations to the project.rdfs:comment : Collaborateur à la traduction du projet.rdfs:comment : Spoluautor překladu projektu.rdfs:comment : このプロジェクトを翻訳する貢献者</para>
    ///   <a href="http://usefulinc.com/ns/doap#translator">doap:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>rdfs:comment : 提供組織、商業の組織や自由の組織。rdfs:comment : Vendor organization: commercial, free or otherwise</para>
    ///   <para>rdfs:label : 提供組織rdfs:label : vendor</para>
    ///   <a href="http://usefulinc.com/ns/doap#vendor">doap:vendor</a>
    /// </summary>
    let vendor = _prefixId.prefix "vendor"
    /// <summary>
    ///   <para>rdfs:comment : L'URL du Wiki pour la discussion collaborative sur le projet.rdfs:comment : このプロジェクトの討論用ウィキrdfs:comment : URL of Wiki for collaborative discussion of project.rdfs:comment : URL adresa wiki projektu pro společné diskuse.rdfs:comment : Wiki-URL für die kollaborative Dikussion eines Projektes.rdfs:comment : URL del Wiki para discusión colaborativa del proyecto.</para>
    ///   <para>rdfs:label : ウィキrdfs:label : Wikirdfs:label : wikirdfs:label : wikirdfs:label : wikirdfs:label : wiki</para>
    ///   <a href="http://usefulinc.com/ns/doap#wiki">doap:wiki</a>
    /// </summary>
    let wiki = _prefixId.prefix "wiki"

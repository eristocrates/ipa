namespace http.usefulinc.com.ns.doap.hash

open DoxAletheia.Rdf_Vocabulary

module doap =
    let _namespace_name = "http://usefulinc.com/ns/doap#"

    /// <summary>
    /// GNU Arch source code repository.
    /// <see href="http://usefulinc.com/ns/doap#ArchRepository"></see></summary>
    let ArchRepository =
        Namespaced_IRI.parse _namespace_name "ArchRepository" |> NamespacedName

    /// <summary>
    /// Source code repository.
    /// <see href="http://usefulinc.com/ns/doap#Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// BitKeeper source code repository.
    /// <see href="http://usefulinc.com/ns/doap#BKRepository"></see></summary>
    let BKRepository =
        Namespaced_IRI.parse _namespace_name "BKRepository" |> NamespacedName

    /// <summary>
    /// Bazaar source code branch.
    /// <see href="http://usefulinc.com/ns/doap#BazaarBranch"></see></summary>
    let BazaarBranch =
        Namespaced_IRI.parse _namespace_name "BazaarBranch" |> NamespacedName

    /// <summary>
    /// CVS source code repository.
    /// <see href="http://usefulinc.com/ns/doap#CVSRepository"></see></summary>
    let CVSRepository =
        Namespaced_IRI.parse _namespace_name "CVSRepository" |> NamespacedName

    /// <summary>
    /// darcs source code repository.
    /// <see href="http://usefulinc.com/ns/doap#DarcsRepository"></see></summary>
    let DarcsRepository =
        Namespaced_IRI.parse _namespace_name "DarcsRepository" |> NamespacedName

    /// <summary>
    /// Git source code repository.
    /// <see href="http://usefulinc.com/ns/doap#GitRepository"></see></summary>
    let GitRepository =
        Namespaced_IRI.parse _namespace_name "GitRepository" |> NamespacedName

    /// <summary>
    /// Mercurial source code repository.
    /// <see href="http://usefulinc.com/ns/doap#HgRepository"></see></summary>
    let HgRepository =
        Namespaced_IRI.parse _namespace_name "HgRepository" |> NamespacedName

    /// <summary>
    /// A project.
    /// <see href="http://usefulinc.com/ns/doap#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// Subversion source code repository.
    /// <see href="http://usefulinc.com/ns/doap#SVNRepository"></see></summary>
    let SVNRepository =
        Namespaced_IRI.parse _namespace_name "SVNRepository" |> NamespacedName

    /// <summary>
    /// A specification of a system's aspects, technical or otherwise.
    /// <see href="http://usefulinc.com/ns/doap#Specification"></see></summary>
    let Specification =
        Namespaced_IRI.parse _namespace_name "Specification" |> NamespacedName

    /// <summary>
    /// Version information of a project release.
    /// <see href="http://usefulinc.com/ns/doap#Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName

    /// <summary>
    /// Repository for anonymous access.
    /// <see href="http://usefulinc.com/ns/doap#anon-root"></see></summary>
    let ``anon-root`` =
        Namespaced_IRI.parse _namespace_name "anon-root" |> NamespacedName

    /// <summary>
    /// Description of target user base
    /// <see href="http://usefulinc.com/ns/doap#audience"></see></summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName
    /// <summary>
    /// URI of a blog related to a project
    /// <see href="http://usefulinc.com/ns/doap#blog"></see></summary>
    let blog = Namespaced_IRI.parse _namespace_name "blog" |> NamespacedName
    /// <summary>
    /// Web browser interface to repository.
    /// <see href="http://usefulinc.com/ns/doap#browse"></see></summary>
    let browse = Namespaced_IRI.parse _namespace_name "browse" |> NamespacedName

    /// <summary>
    /// Bug tracker for a project.
    /// <see href="http://usefulinc.com/ns/doap#bug-database"></see></summary>
    let ``bug-database`` =
        Namespaced_IRI.parse _namespace_name "bug-database" |> NamespacedName

    /// <summary>
    /// A category of project.
    /// <see href="http://usefulinc.com/ns/doap#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// Date when something was created, in YYYY-MM-DD form. e.g. 2004-04-05
    /// <see href="http://usefulinc.com/ns/doap#created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName

    /// <summary>
    /// Plain text description of a project, of 2-4 sentences in length.
    /// <see href="http://usefulinc.com/ns/doap#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Developer of software for the project.
    /// <see href="http://usefulinc.com/ns/doap#developer"></see></summary>
    let developer = Namespaced_IRI.parse _namespace_name "developer" |> NamespacedName
    /// <summary>
    /// Contributor of documentation to the project.
    /// <see href="http://usefulinc.com/ns/doap#documenter"></see></summary>
    let documenter = Namespaced_IRI.parse _namespace_name "documenter" |> NamespacedName

    /// <summary>
    /// Mirror of software download web page.
    /// <see href="http://usefulinc.com/ns/doap#download-mirror"></see></summary>
    let ``download-mirror`` =
        Namespaced_IRI.parse _namespace_name "download-mirror" |> NamespacedName

    /// <summary>
    /// Web page from which the project software can be downloaded.
    /// <see href="http://usefulinc.com/ns/doap#download-page"></see></summary>
    let ``download-page`` =
        Namespaced_IRI.parse _namespace_name "download-page" |> NamespacedName

    /// <summary>
    /// URI of download associated with this release.
    /// <see href="http://usefulinc.com/ns/doap#file-release"></see></summary>
    let ``file-release`` =
        Namespaced_IRI.parse _namespace_name "file-release" |> NamespacedName

    /// <summary>
    /// Project contributor.
    /// <see href="http://usefulinc.com/ns/doap#helper"></see></summary>
    let helper = Namespaced_IRI.parse _namespace_name "helper" |> NamespacedName
    /// <summary>
    /// URL of a project's homepage,
    /// 		associated with exactly one project.
    /// <see href="http://usefulinc.com/ns/doap#homepage"></see></summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    /// A specification that a project implements. Could be a standard, API or legally defined level of conformance.
    /// <see href="http://usefulinc.com/ns/doap#implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName
    /// <summary>
    /// このプロジェクトの翻訳された言語のISO言語コート
    /// ISO language code a project has been translated into
    /// <see href="http://usefulinc.com/ns/doap#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// The URI of an RDF description of the license the software is distributed under.
    /// <see href="http://usefulinc.com/ns/doap#license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// Location of a repository.
    /// <see href="http://usefulinc.com/ns/doap#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// Mailing list home page or email address.
    /// <see href="http://usefulinc.com/ns/doap#mailing-list"></see></summary>
    let ``mailing-list`` =
        Namespaced_IRI.parse _namespace_name "mailing-list" |> NamespacedName

    /// <summary>
    /// Maintainer of a project, a project leader.
    /// <see href="http://usefulinc.com/ns/doap#maintainer"></see></summary>
    let maintainer = Namespaced_IRI.parse _namespace_name "maintainer" |> NamespacedName
    /// <summary>
    /// Module name of a repository.
    /// <see href="http://usefulinc.com/ns/doap#module"></see></summary>
    let module_ = Namespaced_IRI.parse _namespace_name "module" |> NamespacedName
    /// <summary>
    /// A name of something.
    /// <see href="http://usefulinc.com/ns/doap#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// URL of a project's past homepage,
    /// 		associated with exactly one project.
    /// <see href="http://usefulinc.com/ns/doap#old-homepage"></see></summary>
    let ``old-homepage`` =
        Namespaced_IRI.parse _namespace_name "old-homepage" |> NamespacedName

    /// <summary>
    /// Operating system that a project is limited to.  Omit this property if the project is not OS-specific.
    /// <see href="http://usefulinc.com/ns/doap#os"></see></summary>
    let os = Namespaced_IRI.parse _namespace_name "os" |> NamespacedName
    /// <summary>
    /// Indicator of software platform (non-OS specific), e.g. Java, Firefox, ECMA CLR
    /// <see href="http://usefulinc.com/ns/doap#platform"></see></summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName

    /// <summary>
    /// Programming language a project is implemented in or intended for use with.
    /// <see href="http://usefulinc.com/ns/doap#programming-language"></see></summary>
    let ``programming-language`` =
        Namespaced_IRI.parse _namespace_name "programming-language" |> NamespacedName

    /// <summary>
    /// A project release.
    /// <see href="http://usefulinc.com/ns/doap#release"></see></summary>
    let release = Namespaced_IRI.parse _namespace_name "release" |> NamespacedName
    /// <summary>
    /// Source code repository.
    /// <see href="http://usefulinc.com/ns/doap#repository"></see></summary>
    let repository = Namespaced_IRI.parse _namespace_name "repository" |> NamespacedName
    /// <summary>
    /// Revision identifier of a software release.
    /// <see href="http://usefulinc.com/ns/doap#revision"></see></summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName

    /// <summary>
    /// Web page with screenshots of project.
    /// <see href="http://usefulinc.com/ns/doap#screenshots"></see></summary>
    let screenshots =
        Namespaced_IRI.parse _namespace_name "screenshots" |> NamespacedName

    /// <summary>
    /// The URI of a web service endpoint where software as a service may be accessed
    /// <see href="http://usefulinc.com/ns/doap#service-endpoint"></see></summary>
    let ``service-endpoint`` =
        Namespaced_IRI.parse _namespace_name "service-endpoint" |> NamespacedName

    /// <summary>
    /// Short (8 or 9 words) plain text description of a project.
    /// <see href="http://usefulinc.com/ns/doap#shortdesc"></see></summary>
    let shortdesc = Namespaced_IRI.parse _namespace_name "shortdesc" |> NamespacedName
    /// <summary>
    /// このプロジェクトのため、試験をする人や品質メンテナー。
    /// A tester or other quality control contributor.
    /// <see href="http://usefulinc.com/ns/doap#tester"></see></summary>
    let tester = Namespaced_IRI.parse _namespace_name "tester" |> NamespacedName
    /// <summary>
    /// Contributor of translations to the project.
    /// <see href="http://usefulinc.com/ns/doap#translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    /// Vendor organization: commercial, free or otherwise
    /// <see href="http://usefulinc.com/ns/doap#vendor"></see></summary>
    let vendor = Namespaced_IRI.parse _namespace_name "vendor" |> NamespacedName
    /// <summary>
    /// URL of Wiki for collaborative discussion of project.
    /// <see href="http://usefulinc.com/ns/doap#wiki"></see></summary>
    let wiki = Namespaced_IRI.parse _namespace_name "wiki" |> NamespacedName

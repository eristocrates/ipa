namespace http.usefulinc.com.ns.doap.hash

open DoxAletheia

module doap =
    let _namespace_name = "http://usefulinc.com/ns/doap#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// GNU Arch source code repository.
    /// <see href="http://usefulinc.com/ns/doap#ArchRepository"></see></summary>
    let ArchRepository = _prefix "ArchRepository"
    /// <summary>
    /// Source code repository.
    /// <see href="http://usefulinc.com/ns/doap#Repository"></see></summary>
    let Repository = _prefix "Repository"
    /// <summary>
    /// BitKeeper source code repository.
    /// <see href="http://usefulinc.com/ns/doap#BKRepository"></see></summary>
    let BKRepository = _prefix "BKRepository"
    /// <summary>
    /// Bazaar source code branch.
    /// <see href="http://usefulinc.com/ns/doap#BazaarBranch"></see></summary>
    let BazaarBranch = _prefix "BazaarBranch"
    /// <summary>
    /// CVS source code repository.
    /// <see href="http://usefulinc.com/ns/doap#CVSRepository"></see></summary>
    let CVSRepository = _prefix "CVSRepository"
    /// <summary>
    /// darcs source code repository.
    /// <see href="http://usefulinc.com/ns/doap#DarcsRepository"></see></summary>
    let DarcsRepository = _prefix "DarcsRepository"
    /// <summary>
    /// Git source code repository.
    /// <see href="http://usefulinc.com/ns/doap#GitRepository"></see></summary>
    let GitRepository = _prefix "GitRepository"
    /// <summary>
    /// Mercurial source code repository.
    /// <see href="http://usefulinc.com/ns/doap#HgRepository"></see></summary>
    let HgRepository = _prefix "HgRepository"
    /// <summary>
    /// A project.
    /// <see href="http://usefulinc.com/ns/doap#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Subversion source code repository.
    /// <see href="http://usefulinc.com/ns/doap#SVNRepository"></see></summary>
    let SVNRepository = _prefix "SVNRepository"
    /// <summary>
    /// A specification of a system's aspects, technical or otherwise.
    /// <see href="http://usefulinc.com/ns/doap#Specification"></see></summary>
    let Specification = _prefix "Specification"
    /// <summary>
    /// Version information of a project release.
    /// <see href="http://usefulinc.com/ns/doap#Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    /// Repository for anonymous access.
    /// <see href="http://usefulinc.com/ns/doap#anon-root"></see></summary>
    let ``anon-root`` = _prefix "anon-root"
    /// <summary>
    /// Description of target user base
    /// <see href="http://usefulinc.com/ns/doap#audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// URI of a blog related to a project
    /// <see href="http://usefulinc.com/ns/doap#blog"></see></summary>
    let blog = _prefix "blog"
    /// <summary>
    /// Web browser interface to repository.
    /// <see href="http://usefulinc.com/ns/doap#browse"></see></summary>
    let browse = _prefix "browse"
    /// <summary>
    /// Bug tracker for a project.
    /// <see href="http://usefulinc.com/ns/doap#bug-database"></see></summary>
    let ``bug-database`` = _prefix "bug-database"
    /// <summary>
    /// A category of project.
    /// <see href="http://usefulinc.com/ns/doap#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// Date when something was created, in YYYY-MM-DD form. e.g. 2004-04-05
    /// <see href="http://usefulinc.com/ns/doap#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// Plain text description of a project, of 2-4 sentences in length.
    /// <see href="http://usefulinc.com/ns/doap#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Developer of software for the project.
    /// <see href="http://usefulinc.com/ns/doap#developer"></see></summary>
    let developer = _prefix "developer"
    /// <summary>
    /// Contributor of documentation to the project.
    /// <see href="http://usefulinc.com/ns/doap#documenter"></see></summary>
    let documenter = _prefix "documenter"
    /// <summary>
    /// Mirror of software download web page.
    /// <see href="http://usefulinc.com/ns/doap#download-mirror"></see></summary>
    let ``download-mirror`` = _prefix "download-mirror"
    /// <summary>
    /// Web page from which the project software can be downloaded.
    /// <see href="http://usefulinc.com/ns/doap#download-page"></see></summary>
    let ``download-page`` = _prefix "download-page"
    /// <summary>
    /// URI of download associated with this release.
    /// <see href="http://usefulinc.com/ns/doap#file-release"></see></summary>
    let ``file-release`` = _prefix "file-release"
    /// <summary>
    /// Project contributor.
    /// <see href="http://usefulinc.com/ns/doap#helper"></see></summary>
    let helper = _prefix "helper"
    /// <summary>
    /// URL of a project's homepage,
    /// 		associated with exactly one project.
    /// <see href="http://usefulinc.com/ns/doap#homepage"></see></summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// A specification that a project implements. Could be a standard, API or legally defined level of conformance.
    /// <see href="http://usefulinc.com/ns/doap#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// このプロジェクトの翻訳された言語のISO言語コート
    /// ISO language code a project has been translated into
    /// <see href="http://usefulinc.com/ns/doap#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// The URI of an RDF description of the license the software is distributed under.
    /// <see href="http://usefulinc.com/ns/doap#license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// Location of a repository.
    /// <see href="http://usefulinc.com/ns/doap#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Mailing list home page or email address.
    /// <see href="http://usefulinc.com/ns/doap#mailing-list"></see></summary>
    let ``mailing-list`` = _prefix "mailing-list"
    /// <summary>
    /// Maintainer of a project, a project leader.
    /// <see href="http://usefulinc.com/ns/doap#maintainer"></see></summary>
    let maintainer = _prefix "maintainer"
    /// <summary>
    /// Module name of a repository.
    /// <see href="http://usefulinc.com/ns/doap#module"></see></summary>
    let module_ = _prefix "module"
    /// <summary>
    /// A name of something.
    /// <see href="http://usefulinc.com/ns/doap#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// URL of a project's past homepage,
    /// 		associated with exactly one project.
    /// <see href="http://usefulinc.com/ns/doap#old-homepage"></see></summary>
    let ``old-homepage`` = _prefix "old-homepage"
    /// <summary>
    /// Operating system that a project is limited to.  Omit this property if the project is not OS-specific.
    /// <see href="http://usefulinc.com/ns/doap#os"></see></summary>
    let os = _prefix "os"
    /// <summary>
    /// Indicator of software platform (non-OS specific), e.g. Java, Firefox, ECMA CLR
    /// <see href="http://usefulinc.com/ns/doap#platform"></see></summary>
    let platform = _prefix "platform"
    /// <summary>
    /// Programming language a project is implemented in or intended for use with.
    /// <see href="http://usefulinc.com/ns/doap#programming-language"></see></summary>
    let ``programming-language`` = _prefix "programming-language"
    /// <summary>
    /// A project release.
    /// <see href="http://usefulinc.com/ns/doap#release"></see></summary>
    let release = _prefix "release"
    /// <summary>
    /// Source code repository.
    /// <see href="http://usefulinc.com/ns/doap#repository"></see></summary>
    let repository = _prefix "repository"
    /// <summary>
    /// Revision identifier of a software release.
    /// <see href="http://usefulinc.com/ns/doap#revision"></see></summary>
    let revision = _prefix "revision"
    /// <summary>
    /// Web page with screenshots of project.
    /// <see href="http://usefulinc.com/ns/doap#screenshots"></see></summary>
    let screenshots = _prefix "screenshots"
    /// <summary>
    /// The URI of a web service endpoint where software as a service may be accessed
    /// <see href="http://usefulinc.com/ns/doap#service-endpoint"></see></summary>
    let ``service-endpoint`` = _prefix "service-endpoint"
    /// <summary>
    /// Short (8 or 9 words) plain text description of a project.
    /// <see href="http://usefulinc.com/ns/doap#shortdesc"></see></summary>
    let shortdesc = _prefix "shortdesc"
    /// <summary>
    /// このプロジェクトのため、試験をする人や品質メンテナー。
    /// A tester or other quality control contributor.
    /// <see href="http://usefulinc.com/ns/doap#tester"></see></summary>
    let tester = _prefix "tester"
    /// <summary>
    /// Contributor of translations to the project.
    /// <see href="http://usefulinc.com/ns/doap#translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    /// Vendor organization: commercial, free or otherwise
    /// <see href="http://usefulinc.com/ns/doap#vendor"></see></summary>
    let vendor = _prefix "vendor"
    /// <summary>
    /// URL of Wiki for collaborative discussion of project.
    /// <see href="http://usefulinc.com/ns/doap#wiki"></see></summary>
    let wiki = _prefix "wiki"

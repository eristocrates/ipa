namespace http.purl.org.spar.scoro.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module scoro =
    let _namespace_iri = Namespace_Iri scoro |> NamespaceIRI
    /// <summary>
    ///   <para>scoro:DataRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to data.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>data role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/DataRole">http://purl.org/spar/scoro/DataRole</seealso>
    let DataRole = Prefixed_Name(scoro, "DataRole") |> PrefixedName

    /// <summary>
    ///   <para>scoro:ContributionSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The situation an agent has of making a contribution to realizing a goal or completing a task relating to a scholarly activity or entity such as journal article.  The type or nature of the contribution is defined by the object of the object property scoro:withContribution, which is an individual in the class scoro:Contribution or one of its sub-classes.  The entity to which the contribution relates is specified using the object property scoro:relatesToEntity or one of its sub-properties, and the effort expended in making that contribution is specified using the object property scoro:withContributionEffort.</para>
    /// labels<para>contribution situation</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ContributionSituation">http://purl.org/spar/scoro/ContributionSituation</seealso>
    let ContributionSituation =
        Prefixed_Name(scoro, "ContributionSituation") |> PrefixedName

    /// <summary>
    ///   <para>scoro:withContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property connecting an agent's contribution situation to a definition of the contribution made by this agent, specified as an instance of the class scoro:Contribution or of one of its sub-classes.</para>
    /// labels<para>with contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/withContribution">http://purl.org/spar/scoro/withContribution</seealso>
    let withContribution = Prefixed_Name(scoro, "withContribution") |> PrefixedName
    /// <summary>
    ///   <para>scoro:AuthorshipRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that a person might hold as an author of a publication or the creator of a work.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>authorship role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/AuthorshipRole">http://purl.org/spar/scoro/AuthorshipRole</seealso>
    let AuthorshipRole = Prefixed_Name(scoro, "AuthorshipRole") |> PrefixedName

    /// <summary>
    ///   <para>scoro:AuthorshipContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the type or nature of a contribution made with respect to the authorship of a publication such as a journal article.  Individual members of this class are used to specify particular authorship contributions.</para>
    /// labels<para>authorship contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/AuthorshipContribution">http://purl.org/spar/scoro/AuthorshipContribution</seealso>
    let AuthorshipContribution =
        Prefixed_Name(scoro, "AuthorshipContribution") |> PrefixedName

    /// <summary>
    ///   <para>scoro:IntellectualContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the type or nature of an intellectual contribution made to the research described in a journal article.  Individual members of this class are used to specify particular contributions.</para>
    /// labels<para>intellectual contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/IntellectualContribution">http://purl.org/spar/scoro/IntellectualContribution</seealso>
    let IntellectualContribution =
        Prefixed_Name(scoro, "IntellectualContribution") |> PrefixedName

    /// <summary>
    ///   <para>scoro:InvestigationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to an investigation.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>investigation role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/InvestigationRole">http://purl.org/spar/scoro/InvestigationRole</seealso>
    let InvestigationRole = Prefixed_Name(scoro, "InvestigationRole") |> PrefixedName
    /// <summary>
    ///   <para>scoro:article-guarantor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>The role of a person who takes responsibility for the integrity of the work as a whole, from the inception of the research investigation to the published research article.</para>
    /// labels<para>article guarantor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/article-guarantor">http://purl.org/spar/scoro/article-guarantor</seealso>
    let article_guarantor = Prefixed_Name(scoro, "article-guarantor") |> PrefixedName

    /// <summary>
    ///   <para>scoro:ExperimentalContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the type or nature of a practical or experimental contribution made to the research.  Individual members of this class are used to specify particular contributions.</para>
    /// labels<para>experimental contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ExperimentalContribution">http://purl.org/spar/scoro/ExperimentalContribution</seealso>
    let ExperimentalContribution =
        Prefixed_Name(scoro, "ExperimentalContribution") |> PrefixedName

    /// <summary>
    ///   <para>scoro:departmental-administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person who is the administrator of a department within a larger organization, for example of a university academic department.</para>
    /// labels<para>departmental administrator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/departmental-administrator">http://purl.org/spar/scoro/departmental-administrator</seealso>
    let departmental_administrator =
        Prefixed_Name(scoro, "departmental-administrator") |> PrefixedName

    /// <summary>
    ///   <para>scoro:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person who is in charge of an organization or activity, for example a research institute or a dramatic performance.</para>
    /// labels<para>director</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/director">http://purl.org/spar/scoro/director</seealso>
    let director = Prefixed_Name(scoro, "director") |> PrefixedName

    /// <summary>
    ///   <para>scoro:OrganizationalContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the type or nature of an organizational or administrative contribution.  Individual members of this class are used to specify particular contributions.</para>
    /// labels<para>organizational contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/OrganizationalContribution">http://purl.org/spar/scoro/OrganizationalContribution</seealso>
    let OrganizationalContribution =
        Prefixed_Name(scoro, "OrganizationalContribution") |> PrefixedName

    /// <summary>
    ///   <para>scoro:scoro.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/scoro/scoro.png">http://purl.org/spar/scoro/scoro.png</seealso>
    let ``scoro.png`` = Prefixed_Name(scoro, "scoro.png") |> PrefixedName
    /// <summary>
    ///   <para>scoro:2017-09-04</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/scoro/2017-09-04">http://purl.org/spar/scoro/2017-09-04</seealso>
    let _2017_09_04 = Prefixed_Name(scoro, "2017-09-04") |> PrefixedName
    /// <summary>
    ///   <para>scoro:ComputationalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.</para>
    /// labels<para>computational agent</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ComputationalAgent">http://purl.org/spar/scoro/ComputationalAgent</seealso>
    let ComputationalAgent = Prefixed_Name(scoro, "ComputationalAgent") |> PrefixedName
    /// <summary>
    ///   <para>scoro:ContributionEffort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the effort expended in making a contribution.</para>
    /// labels<para>contribution effort</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ContributionEffort">http://purl.org/spar/scoro/ContributionEffort</seealso>
    let ContributionEffort = Prefixed_Name(scoro, "ContributionEffort") |> PrefixedName
    /// <summary>
    ///   <para>scoro:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the type or nature of a contribution made by an agent.  Individual members of this class or its sub-classes are used to specify particular contributions.</para>
    /// labels<para>contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/Contribution">http://purl.org/spar/scoro/Contribution</seealso>
    let Contribution = Prefixed_Name(scoro, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>scoro:EducationalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to an educational organization or activity.  Individual members of this class are used to specify particular educational roles.</para>
    /// labels<para>educational role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/EducationalRole">http://purl.org/spar/scoro/EducationalRole</seealso>
    let EducationalRole = Prefixed_Name(scoro, "EducationalRole") |> PrefixedName
    /// <summary>
    ///   <para>scoro:accountant</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person whose job is to manage financial accounts, for example the accounts of an organization, or of a particular funded project or activity of that organization.</para>
    /// labels<para>accountant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/accountant">http://purl.org/spar/scoro/accountant</seealso>
    let accountant = Prefixed_Name(scoro, "accountant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by an agent responsible for the day-to-day management and running of an organization or activity.</para>
    /// labels<para>administrator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/administrator">http://purl.org/spar/scoro/administrator</seealso>
    let administrator = Prefixed_Name(scoro, "administrator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:access-provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role of an agent who provides access to a resource, for example an online data repository.</para>
    /// labels<para>access provider</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/access-provider">http://purl.org/spar/scoro/access-provider</seealso>
    let access_provider = Prefixed_Name(scoro, "access-provider") |> PrefixedName
    /// <summary>
    ///   <para>scoro:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An agent that acts on behalf of another agent.</para>
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/agent">http://purl.org/spar/scoro/agent</seealso>
    let agent = Prefixed_Name(scoro, "agent") |> PrefixedName
    /// <summary>
    ///   <para>scoro:auditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person who conducts a formal audit of financial accounts.</para>
    /// labels<para>auditor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/auditor">http://purl.org/spar/scoro/auditor</seealso>
    let auditor = Prefixed_Name(scoro, "auditor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:chief-scientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A senior scientist who takes a leadership role in an organization or group.</para>
    /// labels<para>chief scientist</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/chief-scientist">http://purl.org/spar/scoro/chief-scientist</seealso>
    let chief_scientist = Prefixed_Name(scoro, "chief-scientist") |> PrefixedName

    /// <summary>
    ///   <para>scoro:chief-technology-officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person who is the chief technology officer of an organization, responsible for directing and managing technical developments for that organization.</para>
    /// labels<para>chief technology officer</para><para>CTO</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/chief-technology-officer">http://purl.org/spar/scoro/chief-technology-officer</seealso>
    let chief_technology_officer =
        Prefixed_Name(scoro, "chief-technology-officer") |> PrefixedName

    /// <summary>
    ///   <para>scoro:co-applicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being a co-applicant on the grant application to obtain funding to fund an endeavour such as a research project.</para>
    /// labels<para>co-applicant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/co-applicant">http://purl.org/spar/scoro/co-applicant</seealso>
    let co_applicant = Prefixed_Name(scoro, "co-applicant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:co-investigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being a co-investigator for a research investigation.</para>
    /// labels<para>co-investigator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/co-investigator">http://purl.org/spar/scoro/co-investigator</seealso>
    let co_investigator = Prefixed_Name(scoro, "co-investigator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:college-fellow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by an academic as a senior member of a college.</para>
    /// labels<para>college fellow</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/college-fellow">http://purl.org/spar/scoro/college-fellow</seealso>
    let college_fellow = Prefixed_Name(scoro, "college-fellow") |> PrefixedName
    /// <summary>
    ///   <para>scoro:consortium-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The authorship role of an organisation or consortium that has contributed collectively to the work described in the publication and is named in the list of authors, e.g. 'Wellcome Trust Case Control Consortium' or 'Malaria Genomic Epidemiology Network'.  (The members of such a group should be separately listed elsewhere in the document).</para>
    /// labels<para>consortium author</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/consortium-author">http://purl.org/spar/scoro/consortium-author</seealso>
    let consortium_author = Prefixed_Name(scoro, "consortium-author") |> PrefixedName
    /// <summary>
    ///   <para>scoro:contractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>The role held by an agent who enters into a contract to undertake specified work or to supply specified services in return for payment.</para>
    /// labels<para>contractor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/contractor">http://purl.org/spar/scoro/contractor</seealso>
    let contractor = Prefixed_Name(scoro, "contractor") |> PrefixedName

    /// <summary>
    ///   <para>scoro:creates-novel-organisms-or-cells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of creating novel organisms (e.g. mouse mutants) or cells (e.g. tranformed cell lines), either for use in the research, or as a research output of use to others.</para>
    /// labels<para>creates novel organisms or cells</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/creates-novel-organisms-or-cells">http://purl.org/spar/scoro/creates-novel-organisms-or-cells</seealso>
    let creates_novel_organisms_or_cells =
        Prefixed_Name(scoro, "creates-novel-organisms-or-cells") |> PrefixedName

    /// <summary>
    ///   <para>scoro:curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role of an agent that documents, cares for and manages collections of objects (for example in a museum) or of data (as in a data repository or database).  [A data curator is a curator who specializes in digital data, while a librarian is a type of curator specializing in textual publications.]</para>
    /// labels<para>curator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/curator">http://purl.org/spar/scoro/curator</seealso>
    let curator = Prefixed_Name(scoro, "curator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:data-manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role a person has of being a data manager, responsible for day-to-day management, maintenance and back-up of data, for example those arising from the research project or held in a repository.</para>
    /// labels<para>data manager</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/data-manager">http://purl.org/spar/scoro/data-manager</seealso>
    let data_manager = Prefixed_Name(scoro, "data-manager") |> PrefixedName
    /// <summary>
    ///   <para>scoro:affiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role an agent has of being affiliated to some organization or institution in a context of some entity or activity, for example a document, a project or an internship.</para>
    /// labels<para>affiliate</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/affiliate">http://purl.org/spar/scoro/affiliate</seealso>
    let affiliate = Prefixed_Name(scoro, "affiliate") |> PrefixedName

    /// <summary>
    ///   <para>scoro:approves-final-manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>The contribution of approving the final version of the manuscript, prior to submission for publication. </para>
    /// labels<para>approves final manuscript</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/approves-final-manuscript">http://purl.org/spar/scoro/approves-final-manuscript</seealso>
    let approves_final_manuscript =
        Prefixed_Name(scoro, "approves-final-manuscript") |> PrefixedName

    /// <summary>
    ///   <para>scoro:chief-executive-officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person who is the chief executive officer of an organization, responsible for directing and managing the business of that organization.</para>
    /// labels<para>chief executive officer</para><para>CEO</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/chief-executive-officer">http://purl.org/spar/scoro/chief-executive-officer</seealso>
    let chief_executive_officer =
        Prefixed_Name(scoro, "chief-executive-officer") |> PrefixedName

    /// <summary>
    ///   <para>scoro:claimant</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person making a financial claim, for example for refund of travel expenses from a project grant.</para>
    /// labels<para>claimant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/claimant">http://purl.org/spar/scoro/claimant</seealso>
    let claimant = Prefixed_Name(scoro, "claimant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:analyses-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of data analysis.  This might include statistical analysis, bioinformatics analysis, or image analysis.</para>
    /// labels<para>analyses data</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/analyses-data">http://purl.org/spar/scoro/analyses-data</seealso>
    let analyses_data = Prefixed_Name(scoro, "analyses-data") |> PrefixedName

    /// <summary>
    ///   <para>scoro:builds-and-or-maintains-instruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of building instruments, equipment or scientific apparatus and/or maintaining the same in a workable condition for use in experiments.</para>
    /// labels<para>builds and/or maintains instruments</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/builds-and-or-maintains-instruments">http://purl.org/spar/scoro/builds-and-or-maintains-instruments</seealso>
    let builds_and_or_maintains_instruments =
        Prefixed_Name(scoro, "builds-and-or-maintains-instruments") |> PrefixedName

    /// <summary>
    ///   <para>scoro:collaborator</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person, typically from another research group or institution, who collaborates with the team undertaking a research investigation.</para>
    /// labels<para>collaborator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/collaborator">http://purl.org/spar/scoro/collaborator</seealso>
    let collaborator = Prefixed_Name(scoro, "collaborator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:college-head</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a senior academic who heads a college and acts as its CEO.  Among the many alternative titles give to this role, the most common are President or Master of the college.</para>
    /// labels<para>college head</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/college-head">http://purl.org/spar/scoro/college-head</seealso>
    let college_head = Prefixed_Name(scoro, "college-head") |> PrefixedName
    /// <summary>
    ///   <para>scoro:collects-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of making experimental observations and collecting data, for example using a telescope, a microscope or an analytical instrument.</para>
    /// labels<para>collects data</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/collects-data">http://purl.org/spar/scoro/collects-data</seealso>
    let collects_data = Prefixed_Name(scoro, "collects-data") |> PrefixedName

    /// <summary>
    ///   <para>scoro:computer-programmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being someone who develops computer software.</para>
    /// labels<para>computer programmer</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/computer-programmer">http://purl.org/spar/scoro/computer-programmer</seealso>
    let computer_programmer =
        Prefixed_Name(scoro, "computer-programmer") |> PrefixedName

    /// <summary>
    ///   <para>scoro:consultant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being a consultant who is providing expertise or services.</para>
    /// labels<para>consultant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/consultant">http://purl.org/spar/scoro/consultant</seealso>
    let consultant = Prefixed_Name(scoro, "consultant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:contact-person</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of a person who serves as the primary contact and information provider for third parties wishing to find out more about an organization or an activity.</para>
    /// labels<para>contact person</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/contact-person">http://purl.org/spar/scoro/contact-person</seealso>
    let contact_person = Prefixed_Name(scoro, "contact-person") |> PrefixedName

    /// <summary>
    ///   <para>scoro:controls-project-finances</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of controlling the financial aspects of the research project, including authorizing expenditure, creating and managing budgets, and submitting financial reports to the funding agency.</para>
    /// labels<para>controls project finances</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/controls-project-finances">http://purl.org/spar/scoro/controls-project-finances</seealso>
    let controls_project_finances =
        Prefixed_Name(scoro, "controls-project-finances") |> PrefixedName

    /// <summary>
    ///   <para>scoro:creates-novel-reagents</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of creating novel physical or chemical compounds, or molecular biology constructs, either for use in the research, or as a research output of use to others.</para>
    /// labels<para>creates novel reagents</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/creates-novel-reagents">http://purl.org/spar/scoro/creates-novel-reagents</seealso>
    let creates_novel_reagents =
        Prefixed_Name(scoro, "creates-novel-reagents") |> PrefixedName

    /// <summary>
    ///   <para>scoro:data-creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role a person has of being a creator, originator, gatherer or collector of new data.</para>
    /// labels<para>data creator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/data-creator">http://purl.org/spar/scoro/data-creator</seealso>
    let data_creator = Prefixed_Name(scoro, "data-creator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:conceives-project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of conceiving the research project in the first place.
    ///
    /// Note that an individual other than the lead applicant and the co-applicants on a grant application may make considerable contributions to conceiving a research project, but may be prevented from being a formal applicant by reason of affiliation or status (e.g. as a non-academic partner, or a research student).</para>
    /// labels<para>conceives project</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/conceives-project">http://purl.org/spar/scoro/conceives-project</seealso>
    let conceives_project = Prefixed_Name(scoro, "conceives-project") |> PrefixedName

    /// <summary>
    ///   <para>scoro:corresponding-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role an author has of being the corresponding author of the document, with whom editors and readers should correspond concerning it. </para>
    /// labels<para>corresponding author</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/corresponding-author">http://purl.org/spar/scoro/corresponding-author</seealso>
    let corresponding_author =
        Prefixed_Name(scoro, "corresponding-author") |> PrefixedName

    /// <summary>
    ///   <para>scoro:creates-software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of creating computer software, including software for experimental control, analytical tools, mathematical model and computational simulations for use in the research, or of creating an IT service (e.g. a bioinformatics database or Web service) of use to others.  </para>
    /// labels<para>creates software</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/creates-software">http://purl.org/spar/scoro/creates-software</seealso>
    let creates_software = Prefixed_Name(scoro, "creates-software") |> PrefixedName
    /// <summary>
    ///   <para>scoro:data-curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role a person has of being a data curator, responsible reviewing, enhancing, cleaning, or standardizing data and their associated metadata, for example those arising from the research project, and for their long-term preservation.</para>
    /// labels<para>data curator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/data-curator">http://purl.org/spar/scoro/data-curator</seealso>
    let data_curator = Prefixed_Name(scoro, "data-curator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:data-publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:DataRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of an agent who publishes data.</para>
    /// labels<para>data publisher</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/data-publisher">http://purl.org/spar/scoro/data-publisher</seealso>
    let data_publisher = Prefixed_Name(scoro, "data-publisher") |> PrefixedName
    /// <summary>
    ///   <para>scoro:data-user</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role a person has of being a user or re-user of existing data.</para>
    /// labels<para>data user</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/data-user">http://purl.org/spar/scoro/data-user</seealso>
    let data_user = Prefixed_Name(scoro, "data-user") |> PrefixedName

    /// <summary>
    ///   <para>scoro:develops-methodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of developing experimental methodology that enables research.</para>
    /// labels<para>develops methodology</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/develops-methodology">http://purl.org/spar/scoro/develops-methodology</seealso>
    let develops_methodology =
        Prefixed_Name(scoro, "develops-methodology") |> PrefixedName

    /// <summary>
    ///   <para>scoro:doctoral-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>The role of a person registerd for a Ph.D. degree at a university.</para>
    /// labels<para>doctoral student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/doctoral-student">http://purl.org/spar/scoro/doctoral-student</seealso>
    let doctoral_student = Prefixed_Name(scoro, "doctoral-student") |> PrefixedName
    /// <summary>
    ///   <para>scoro:embargo-controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:DataRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of the person who has responsibility for setting and lifting embargos that restrict access to a dataset (or a document) for a specified period of time.</para>
    /// labels<para>embargo controller</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/embargo-controller">http://purl.org/spar/scoro/embargo-controller</seealso>
    let embargo_controller = Prefixed_Name(scoro, "embargo-controller") |> PrefixedName
    /// <summary>
    ///   <para>scoro:employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by an agent that employs one or more people to undertake work on that agent's behalf.</para>
    /// labels<para>employer</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/employer">http://purl.org/spar/scoro/employer</seealso>
    let employer = Prefixed_Name(scoro, "employer") |> PrefixedName

    /// <summary>
    ///   <para>scoro:ensures-regulatory-compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of ensuring regulatory compliance for the research undertaken, for example in obtaining informed consent from patients, approval from research ethics or radiation safety committees, or a license for animal experimentation.  </para>
    /// labels<para>ensures regulatory compliance</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ensures-regulatory-compliance">http://purl.org/spar/scoro/ensures-regulatory-compliance</seealso>
    let ensures_regulatory_compliance =
        Prefixed_Name(scoro, "ensures-regulatory-compliance") |> PrefixedName

    /// <summary>
    ///   <para>scoro:hasContributionContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property relating a contribution situation to an entity representing the context for that situation.</para>
    /// labels<para>has contribution context</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/hasContributionContext">http://purl.org/spar/scoro/hasContributionContext</seealso>
    let hasContributionContext =
        Prefixed_Name(scoro, "hasContributionContext") |> PrefixedName

    /// <summary>
    ///   <para>scoro:hasPersonalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying a unique and unambiguous identifier for an individual person within a given context, specified by the object property scoro:usesPersonalIdentifierScheme and an individual member of the class scoro:PersonalIdentifierScheme.</para>
    /// labels<para>has personal identifier</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/hasPersonalIdentifier">http://purl.org/spar/scoro/hasPersonalIdentifier</seealso>
    let hasPersonalIdentifier =
        Prefixed_Name(scoro, "hasPersonalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>scoro:host-institution</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a institution of hosting some initiative, people, or event.</para>
    /// labels<para>host institution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/host-institution">http://purl.org/spar/scoro/host-institution</seealso>
    let host_institution = Prefixed_Name(scoro, "host-institution") |> PrefixedName
    /// <summary>
    ///   <para>scoro:inventor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being the inventor or some entity (for example a computer algorithm, or an experimental procedure).</para>
    /// labels<para>inventor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/inventor">http://purl.org/spar/scoro/inventor</seealso>
    let inventor = Prefixed_Name(scoro, "inventor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:isContributionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property relating the definition of a specific contribution to the contribution situation of an agent making that contribution.</para>
    /// labels<para>is contribution in</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/isContributionIn">http://purl.org/spar/scoro/isContributionIn</seealso>
    let isContributionIn = Prefixed_Name(scoro, "isContributionIn") |> PrefixedName
    /// <summary>
    ///   <para>scoro:makesContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to a contribution.  This is done via the indirection: foaf:Agent scoro:makesContribution [ a scoro:ContributionSituation ; scoro:withContribution scoro:Contribution ; scoro:withEffort scoro:ContributionEffort ] .  The ontology permits one to specify the time period over which a contribution is made, and the other contextual entities to which that agent's contribution relates.</para>
    /// labels<para>makes contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/makesContribution">http://purl.org/spar/scoro/makesContribution</seealso>
    let makesContribution = Prefixed_Name(scoro, "makesContribution") |> PrefixedName
    /// <summary>
    ///   <para>scoro:lead-applicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>The role a person has of being the lead applicant on the grant application to obtain funding to fund an endeavour such as a research project.</para>
    /// labels<para>lead applicant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/lead-applicant">http://purl.org/spar/scoro/lead-applicant</seealso>
    let lead_applicant = Prefixed_Name(scoro, "lead-applicant") |> PrefixedName

    /// <summary>
    ///   <para>scoro:maintains-organisms-or-cells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of maintaining multicellular organisms (plants, animals or fungi) or cell cultures used as experimental subjects, and of breeding these where appropriate.
    ///
    /// [Note that there may be occasions when it is inappropriate to acknowledge such contributions, for fear of personal reprisals on the individuals involved from animal rights activists].</para>
    /// labels<para>maintains organisms or cell cultures</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/maintains-organisms-or-cells">http://purl.org/spar/scoro/maintains-organisms-or-cells</seealso>
    let maintains_organisms_or_cells =
        Prefixed_Name(scoro, "maintains-organisms-or-cells") |> PrefixedName

    /// <summary>
    ///   <para>scoro:maintains-research-facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of managing and operating a research facility, for example a confocal microscopy facility.</para>
    /// labels<para>maintains research facility</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/maintains-research-facility">http://purl.org/spar/scoro/maintains-research-facility</seealso>
    let maintains_research_facility =
        Prefixed_Name(scoro, "maintains-research-facility") |> PrefixedName

    /// <summary>
    ///   <para>scoro:manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person responsible for managing the day-to-day activities of an activity, enterprise or organization.</para>
    /// labels<para>manager</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/manager">http://purl.org/spar/scoro/manager</seealso>
    let manager = Prefixed_Name(scoro, "manager") |> PrefixedName
    /// <summary>
    ///   <para>scoro:manages-project</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of project management.
    ///
    /// Note that an individual other than the person holding the formal role of project manager may make considerable contributions to the management of a research project.</para>
    /// labels<para>manages project</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/manages-project">http://purl.org/spar/scoro/manages-project</seealso>
    let manages_project = Prefixed_Name(scoro, "manages-project") |> PrefixedName
    /// <summary>
    ///   <para>scoro:minor-effort</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ContributionEffort</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contributor provided a minor effort towards achieving this contribution. </para>
    /// labels<para>contributed minor effort</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/minor-effort">http://purl.org/spar/scoro/minor-effort</seealso>
    let minor_effort = Prefixed_Name(scoro, "minor-effort") |> PrefixedName

    /// <summary>
    ///   <para>scoro:non-academic-staff-member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role of a person employed within a university department, school or institute who is not a member of the academic faculty.</para>
    /// labels<para>non-academic staff member</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/non-academic-staff-member">http://purl.org/spar/scoro/non-academic-staff-member</seealso>
    let non_academic_staff_member =
        Prefixed_Name(scoro, "non-academic-staff-member") |> PrefixedName

    /// <summary>
    ///   <para>scoro:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>The role held by an agent who is the owner of something with actual or potential financial value, for example a building, a piece of equipment, the copyright of a document, or the intellectual property rights relating to an idea or discovery.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/owner">http://purl.org/spar/scoro/owner</seealso>
    let owner = Prefixed_Name(scoro, "owner") |> PrefixedName
    /// <summary>
    ///   <para>scoro:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent who takes part in something, for example a conference, a private meeting or a public event.</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/participant">http://purl.org/spar/scoro/participant</seealso>
    let participant = Prefixed_Name(scoro, "participant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:possessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent as possessor or owner of some entity such as an address or a telephone number.</para>
    /// labels<para>possessor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/possessor">http://purl.org/spar/scoro/possessor</seealso>
    let possessor = Prefixed_Name(scoro, "possessor") |> PrefixedName

    /// <summary>
    ///   <para>scoro:postdoctoral-researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being a post-doctoral researcher involved in a research investigation.</para>
    /// labels<para>postdoctoral researcher</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/postdoctoral-researcher">http://purl.org/spar/scoro/postdoctoral-researcher</seealso>
    let postdoctoral_researcher =
        Prefixed_Name(scoro, "postdoctoral-researcher") |> PrefixedName

    /// <summary>
    ///   <para>scoro:postgraduate-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of a person registerd for a graduate (masters or doctoral) degree at a university.</para>
    /// labels<para>postgraduate student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/postgraduate-student">http://purl.org/spar/scoro/postgraduate-student</seealso>
    let postgraduate_student =
        Prefixed_Name(scoro, "postgraduate-student") |> PrefixedName

    /// <summary>
    ///   <para>scoro:processes-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of processing, cleaning, assembling, condensing or refining the data.</para>
    /// labels<para>processs data</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/processes-data">http://purl.org/spar/scoro/processes-data</seealso>
    let processes_data = Prefixed_Name(scoro, "processes-data") |> PrefixedName
    /// <summary>
    ///   <para>scoro:programme-manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person who is in charge of a programme of related activities or projects, for example on behalf of a funding agency.</para>
    /// labels<para>programme manager</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/programme-manager">http://purl.org/spar/scoro/programme-manager</seealso>
    let programme_manager = Prefixed_Name(scoro, "programme-manager") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-exising-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of providing pre-existing data for re-use in the research.</para>
    /// labels<para>provides existing data</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-exising-data">http://purl.org/spar/scoro/provides-exising-data</seealso>
    let provides_exising_data =
        Prefixed_Name(scoro, "provides-exising-data") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-patients</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of providing access to medical or veterinary patients, to make possible the research.</para>
    /// labels<para>provides patients</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-patients">http://purl.org/spar/scoro/provides-patients</seealso>
    let provides_patients = Prefixed_Name(scoro, "provides-patients") |> PrefixedName
    /// <summary>
    ///   <para>scoro:purchaser</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent of making purchases of goods or services, the cost of which is typically charged to a particular academic budget, for example a project manager placing an order to purchase equipment funded from a research grant.</para>
    /// labels<para>purchaser</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/purchaser">http://purl.org/spar/scoro/purchaser</seealso>
    let purchaser = Prefixed_Name(scoro, "purchaser") |> PrefixedName
    /// <summary>
    ///   <para>scoro:registrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent responsible for maintaining official records, for example the records of student enrollment and academic standing held by a college or university, or the records of securities owned by a financial institution.</para>
    /// labels<para>registrar</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/registrar">http://purl.org/spar/scoro/registrar</seealso>
    let registrar = Prefixed_Name(scoro, "registrar") |> PrefixedName
    /// <summary>
    ///   <para>scoro:research-assistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being a research assistant involved in a research investigation.</para>
    /// labels<para>research assistant</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/research-assistant">http://purl.org/spar/scoro/research-assistant</seealso>
    let research_assistant = Prefixed_Name(scoro, "research-assistant") |> PrefixedName
    /// <summary>
    ///   <para>scoro:research-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being a research student, namely someone engaged in research as part of studying for a higher degree at a university or research institute, whose research will be presented in a thesis in part fulfilment of the requirements of that degree.</para>
    /// labels<para>research student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/research-student">http://purl.org/spar/scoro/research-student</seealso>
    let research_student = Prefixed_Name(scoro, "research-student") |> PrefixedName
    /// <summary>
    ///   <para>scoro:researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being a researcher involved in a research investigation, for example by conducting experiments, collecting and analyzing data, or undertaking formal study.</para>
    /// labels<para>researcher</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/researcher">http://purl.org/spar/scoro/researcher</seealso>
    let researcher = Prefixed_Name(scoro, "researcher") |> PrefixedName
    /// <summary>
    ///   <para>scoro:service-engineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role held by a person who services, maintains and repairs equipment, facilities or technical infrastructure. </para>
    /// labels<para>service engineer</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/service-engineer">http://purl.org/spar/scoro/service-engineer</seealso>
    let service_engineer = Prefixed_Name(scoro, "service-engineer") |> PrefixedName
    /// <summary>
    ///   <para>scoro:solo-effort</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ContributionEffort</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contributor was the only person who provided effort in achieving this contribution, which was entirely due to this contributor.</para>
    /// labels<para>contributed all the effort</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/solo-effort">http://purl.org/spar/scoro/solo-effort</seealso>
    let solo_effort = Prefixed_Name(scoro, "solo-effort") |> PrefixedName
    /// <summary>
    ///   <para>scoro:spokesperson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person who makes statements on behalf of another individual, a group, a project or an institution</para>
    /// labels<para>spokesperson</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/spokesperson">http://purl.org/spar/scoro/spokesperson</seealso>
    let spokesperson = Prefixed_Name(scoro, "spokesperson") |> PrefixedName
    /// <summary>
    ///   <para>scoro:supervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of a person who guides and oversees the research activities of a team member, or who formally supervises a student during that student's research project undertaken as part of a degree course at a university.</para>
    /// labels<para>supervisor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/supervisor">http://purl.org/spar/scoro/supervisor</seealso>
    let supervisor = Prefixed_Name(scoro, "supervisor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent of providing goods or services in exchange for payment.</para>
    /// labels<para>supplier</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/supplier">http://purl.org/spar/scoro/supplier</seealso>
    let supplier = Prefixed_Name(scoro, "supplier") |> PrefixedName
    /// <summary>
    ///   <para>scoro:technician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being a technician, providing technical assistance in some endeavour such as a research investigation.</para>
    /// labels<para>technician</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/technician">http://purl.org/spar/scoro/technician</seealso>
    let technician = Prefixed_Name(scoro, "technician") |> PrefixedName
    /// <summary>
    ///   <para>scoro:withEffort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property connecting an agent's contribution with respect to a particular entity to the amount of effort exerted by this agent in making that contribution, defined by individuals of the class scoro:ContributionEffort.</para>
    /// labels<para>with contribution effort</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/withEffort">http://purl.org/spar/scoro/withEffort</seealso>
    let withEffort = Prefixed_Name(scoro, "withEffort") |> PrefixedName
    /// <summary>
    ///   <para>scoro:withJobTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property connecting an agent's role in time to a job title that characterizes that role.  This data property complements the definition of that role in time specified by scoro:Role.  For example, for the scoro:OrganizationalRole 'Head of Department', the specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'. </para>
    /// labels<para>with job title</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/withJobTitle">http://purl.org/spar/scoro/withJobTitle</seealso>
    let withJobTitle = Prefixed_Name(scoro, "withJobTitle") |> PrefixedName

    /// <summary>
    ///   <para>scoro:designs-experiments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of experimental design and planning.</para>
    /// labels<para>designs experiments</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/designs-experiments">http://purl.org/spar/scoro/designs-experiments</seealso>
    let designs_experiments =
        Prefixed_Name(scoro, "designs-experiments") |> PrefixedName

    /// <summary>
    ///   <para>scoro:employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person employed for wages or a salary by an organization, to undertake work for that organization.</para>
    /// labels<para>employee</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/employee">http://purl.org/spar/scoro/employee</seealso>
    let employee = Prefixed_Name(scoro, "employee") |> PrefixedName
    /// <summary>
    ///   <para>scoro:faculty-member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>The role of an academic employed to undertake research and teaching within a university department, school or institute.</para>
    /// labels<para>faculty member</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/faculty-member">http://purl.org/spar/scoro/faculty-member</seealso>
    let faculty_member = Prefixed_Name(scoro, "faculty-member") |> PrefixedName

    /// <summary>
    ///   <para>scoro:financial-controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent of controlling the finances, for example the finances of an organization, a building project or a research project.  This role extends to the control of or the authorisation of expenditure from a budget, and may be undertaken by a computational agent.</para>
    /// labels<para>financial controller</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/financial-controller">http://purl.org/spar/scoro/financial-controller</seealso>
    let financial_controller =
        Prefixed_Name(scoro, "financial-controller") |> PrefixedName

    /// <summary>
    ///   <para>scoro:funder</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent of providing funds, for example for a research project.</para>
    /// labels<para>funder</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/funder">http://purl.org/spar/scoro/funder</seealso>
    let funder = Prefixed_Name(scoro, "funder") |> PrefixedName

    /// <summary>
    ///   <para>scoro:isRelatedToContributionSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property relating an entity to the contribution situation for which that entity provides the context.</para>
    /// labels<para>is related to contribution situation</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/isRelatedToContributionSituation">http://purl.org/spar/scoro/isRelatedToContributionSituation</seealso>
    let isRelatedToContributionSituation =
        Prefixed_Name(scoro, "isRelatedToContributionSituation") |> PrefixedName

    /// <summary>
    ///   <para>scoro:hasORCID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.</para>
    /// labels<para>has ORCID</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/hasORCID">http://purl.org/spar/scoro/hasORCID</seealso>
    let hasORCID = Prefixed_Name(scoro, "hasORCID") |> PrefixedName

    /// <summary>
    ///   <para>scoro:isEqualToContributionSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>This property allows the link of two contribution situations that are equals for particular aspects (i.e. for type of contribution, contribution effort and context).</para>
    /// labels<para>is equal to contribution situation</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/isEqualToContributionSituation">http://purl.org/spar/scoro/isEqualToContributionSituation</seealso>
    let isEqualToContributionSituation =
        Prefixed_Name(scoro, "isEqualToContributionSituation") |> PrefixedName

    /// <summary>
    ///   <para>scoro:isMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property relating a contribution situation that an agent makes, to that agent.</para>
    /// labels<para>is made by</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/isMadeBy">http://purl.org/spar/scoro/isMadeBy</seealso>
    let isMadeBy = Prefixed_Name(scoro, "isMadeBy") |> PrefixedName

    /// <summary>
    ///   <para>scoro:maintains-IT-Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of maintaining the IT infrastructure required for the research.</para>
    /// labels<para>maintains IT infrastructure</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/maintains-IT-Infrastructure">http://purl.org/spar/scoro/maintains-IT-Infrastructure</seealso>
    let maintains_IT_Infrastructure =
        Prefixed_Name(scoro, "maintains-IT-Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>scoro:major-effort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ContributionEffort</para>
    ///   <para>The contributor provided a major effort towards achieving this contribution.  (It would be unusual for more than three contributors to be described as providing major effort towards achieving any particular contribution).</para>
    /// labels<para>contributed major effort</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/major-effort">http://purl.org/spar/scoro/major-effort</seealso>
    let major_effort = Prefixed_Name(scoro, "major-effort") |> PrefixedName
    /// <summary>
    ///   <para>scoro:master-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>The role of a person registerd for a master degree at a university.</para>
    /// labels<para>master student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/master-student">http://purl.org/spar/scoro/master-student</seealso>
    let master_student = Prefixed_Name(scoro, "master-student") |> PrefixedName

    /// <summary>
    ///   <para>scoro:obtains-and-or-prepares-specimens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of obtaining and/or preparing specimens in a manner requiring research expertise or skill, for example collecting and preparing fossils, or preparing electron microscope specimens for examination.  </para>
    /// labels<para>obtains and/or prepared specimens</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/obtains-and-or-prepares-specimens">http://purl.org/spar/scoro/obtains-and-or-prepares-specimens</seealso>
    let obtains_and_or_prepares_specimens =
        Prefixed_Name(scoro, "obtains-and-or-prepares-specimens") |> PrefixedName

    /// <summary>
    ///   <para>scoro:partner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by a person who is a partner with one or more other people in an organization, project, endeavour, activity or sphere of common interest.</para>
    /// labels<para>partner</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/partner">http://purl.org/spar/scoro/partner</seealso>
    let partner = Prefixed_Name(scoro, "partner") |> PrefixedName
    /// <summary>
    ///   <para>scoro:photographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>The role a person has of being a photographer of, or for, some entity.</para>
    /// labels<para>photographer</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/photographer">http://purl.org/spar/scoro/photographer</seealso>
    let photographer = Prefixed_Name(scoro, "photographer") |> PrefixedName
    /// <summary>
    ///   <para>scoro:principal-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>The role an author has of being the principal or primary author of the document, who has contributed most to the work described.
    ///
    /// (In some communities, but not all, the principal author is named first in the author list.  Two or more authors can have the role of principal author if they contributed equally to the work.  This role should not be employed in communities in which no primacy of authorship is asserted, but where all authors are deemed to have made an equal contribution to the work.)</para>
    /// labels<para>principal author</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/principal-author">http://purl.org/spar/scoro/principal-author</seealso>
    let principal_author = Prefixed_Name(scoro, "principal-author") |> PrefixedName

    /// <summary>
    ///   <para>scoro:principal-investigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being the principal investigator for a research investigation.</para>
    /// labels<para>principal investigator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/principal-investigator">http://purl.org/spar/scoro/principal-investigator</seealso>
    let principal_investigator =
        Prefixed_Name(scoro, "principal-investigator") |> PrefixedName

    /// <summary>
    ///   <para>scoro:project-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role a person has of being a project student, namely someone engaged in an undergraduate research project as part of studying for an undergraduate degree at a university, whose research will be presented in an undergraduate research project report in part fulfilment of the requirements of that degree.</para>
    /// labels<para>project student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/project-student">http://purl.org/spar/scoro/project-student</seealso>
    let project_student = Prefixed_Name(scoro, "project-student") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-administrative-support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>The contribution of providing administrative support for the research project.  </para>
    /// labels<para>provides administrative support</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-administrative-support">http://purl.org/spar/scoro/provides-administrative-support</seealso>
    let provides_administrative_support =
        Prefixed_Name(scoro, "provides-administrative-support") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-advice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of providing advice to facilitate the research, while not actively participating in the work.</para>
    /// labels<para>provides advice</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-advice">http://purl.org/spar/scoro/provides-advice</seealso>
    let provides_advice = Prefixed_Name(scoro, "provides-advice") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-technical-support</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of providing technical support that facilitates research.</para>
    /// labels<para>provides technical support</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-technical-support">http://purl.org/spar/scoro/provides-technical-support</seealso>
    let provides_technical_support =
        Prefixed_Name(scoro, "provides-technical-support") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-tools-equipment-or-facilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of providing tools, equipment or facilities for the research, while not actively participating in the work.</para>
    /// labels<para>provides tools, equipment or facilities</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-tools-equipment-or-facilities">http://purl.org/spar/scoro/provides-tools-equipment-or-facilities</seealso>
    let provides_tools_equipment_or_facilities =
        Prefixed_Name(scoro, "provides-tools-equipment-or-facilities") |> PrefixedName

    /// <summary>
    ///   <para>scoro:publishes-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>The contribution of publishing in a public database or data repository data arising from the research.
    ///
    /// Note that this activity is distinct from that of publishing a journal article containing a selection of these data.</para>
    /// labels<para>publishes data</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/publishes-data">http://purl.org/spar/scoro/publishes-data</seealso>
    let publishes_data = Prefixed_Name(scoro, "publishes-data") |> PrefixedName
    /// <summary>
    ///   <para>scoro:revises-manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of critically reviewing and revising drafts of the manuscript of the research paper.</para>
    /// labels<para>revises manuscript</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/revises-manuscript">http://purl.org/spar/scoro/revises-manuscript</seealso>
    let revises_manuscript = Prefixed_Name(scoro, "revises-manuscript") |> PrefixedName
    /// <summary>
    ///   <para>scoro:rights-holder</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent who holds, owns and manages the legal rights to a project or activity and its products and outcomes, for example the exploitation, licensing and intellectual property rights.
    ///
    /// [See also http://purl.org/spar/scoro/patent-holder and http://purl.org/spar/pro/copyright-owner].</para>
    /// labels<para>rights holder</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/rights-holder">http://purl.org/spar/scoro/rights-holder</seealso>
    let rights_holder = Prefixed_Name(scoro, "rights-holder") |> PrefixedName
    /// <summary>
    ///   <para>scoro:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>The role held by an agent that provides funds or support for a person, project or activity, often in return for access to the exploitable commercial potential associated with that person’s work, or that project or activity’s output, for example through equity sharing or publicity.
    ///
    /// [Note: there are also several other non-financial meaning of 'sponsor'.]</para>
    /// labels<para>sponsor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/sponsor">http://purl.org/spar/scoro/sponsor</seealso>
    let sponsor = Prefixed_Name(scoro, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:stakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by an agent with an interest or concern in something, for example the creation of a new university.</para>
    /// labels<para>stakeholder</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/stakeholder">http://purl.org/spar/scoro/stakeholder</seealso>
    let stakeholder = Prefixed_Name(scoro, "stakeholder") |> PrefixedName

    /// <summary>
    ///   <para>scoro:undergraduate-student</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:EducationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of a person registerd for an undergraduate degree at a university.</para>
    /// labels<para>undergraduate student</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/undergraduate-student">http://purl.org/spar/scoro/undergraduate-student</seealso>
    let undergraduate_student =
        Prefixed_Name(scoro, "undergraduate-student") |> PrefixedName

    /// <summary>
    ///   <para>scoro:undertakes-modelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of design, implementation and analysis of mathematical models or computer simulations.</para>
    /// labels<para>undertakes modelling</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/undertakes-modelling">http://purl.org/spar/scoro/undertakes-modelling</seealso>
    let undertakes_modelling =
        Prefixed_Name(scoro, "undertakes-modelling") |> PrefixedName

    /// <summary>
    ///   <para>scoro:FinancialRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to academic and project finance.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>financial role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/FinancialRole">http://purl.org/spar/scoro/FinancialRole</seealso>
    let FinancialRole = Prefixed_Name(scoro, "FinancialRole") |> PrefixedName
    /// <summary>
    ///   <para>scoro:OrganizationalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to an organization and its administration, particularly within an academic context.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>organizational role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/OrganizationalRole">http://purl.org/spar/scoro/OrganizationalRole</seealso>
    let OrganizationalRole = Prefixed_Name(scoro, "OrganizationalRole") |> PrefixedName
    /// <summary>
    ///   <para>scoro:ProjectRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an agent might hold with respect to a project.  Individual members of this class are used to specify particular roles.</para>
    /// labels<para>project role</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/ProjectRole">http://purl.org/spar/scoro/ProjectRole</seealso>
    let ProjectRole = Prefixed_Name(scoro, "ProjectRole") |> PrefixedName

    /// <summary>
    ///   <para>scoro:formulates-research-questions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of formulating the questions to be answered and the hypotheses to be tested by the research to be undertaken.</para>
    /// labels<para>formulates research questions</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/formulates-research-questions">http://purl.org/spar/scoro/formulates-research-questions</seealso>
    let formulates_research_questions =
        Prefixed_Name(scoro, "formulates-research-questions") |> PrefixedName

    /// <summary>
    ///   <para>scoro:funding-recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent who is the official recipient of funding, for example the university of which a funded research project leader is a member.</para>
    /// labels<para>funding recipient</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/funding-recipient">http://purl.org/spar/scoro/funding-recipient</seealso>
    let funding_recipient = Prefixed_Name(scoro, "funding-recipient") |> PrefixedName
    /// <summary>
    ///   <para>scoro:head-of-department</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by a person who is the chief executive officer of a department within a larger organization, for example a senior academic who is head of a university academic department.</para>
    /// labels<para>head of department</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/head-of-department">http://purl.org/spar/scoro/head-of-department</seealso>
    let head_of_department = Prefixed_Name(scoro, "head-of-department") |> PrefixedName
    /// <summary>
    ///   <para>scoro:illustrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being an illustrator of, or for, some entity.</para>
    /// labels<para>illustrator</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/illustrator">http://purl.org/spar/scoro/illustrator</seealso>
    let illustrator = Prefixed_Name(scoro, "illustrator") |> PrefixedName
    /// <summary>
    ///   <para>scoro:interprets-results</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>The contribution of interpretation of experimental results.</para>
    /// labels<para>interprets results</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/interprets-results">http://purl.org/spar/scoro/interprets-results</seealso>
    let interprets_results = Prefixed_Name(scoro, "interprets-results") |> PrefixedName

    /// <summary>
    ///   <para>scoro:isEqualToRoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property allows the link of two roles in time as being equal, and is particularly useful for specifying that two principal authorship roles are equal.</para>
    /// labels<para>is equal to role in time</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/isEqualToRoleInTime">http://purl.org/spar/scoro/isEqualToRoleInTime</seealso>
    let isEqualToRoleInTime =
        Prefixed_Name(scoro, "isEqualToRoleInTime") |> PrefixedName

    /// <summary>
    ///   <para>scoro:leads-investigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:IntellectualContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of providing intellectual leadership and direction for the research.
    ///
    /// Note that an individual other than the principal investigator and the co-investigators may make considerable leadership contributions to a research investigation.</para>
    /// labels<para>leads investigation</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/leads-investigation">http://purl.org/spar/scoro/leads-investigation</seealso>
    let leads_investigation =
        Prefixed_Name(scoro, "leads-investigation") |> PrefixedName

    /// <summary>
    ///   <para>scoro:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent of belonging to a group or organization.</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/member">http://purl.org/spar/scoro/member</seealso>
    let member_ = Prefixed_Name(scoro, "member") |> PrefixedName
    /// <summary>
    ///   <para>scoro:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by an agent who organizes something, such as a conference, a private meeting or a public event.</para>
    /// labels<para>organizer</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/organizer">http://purl.org/spar/scoro/organizer</seealso>
    let organizer = Prefixed_Name(scoro, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>scoro:patent-holder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role held by an agent who holds a patent.
    ///
    /// [See also http://purl.org/spar/scoro/rights-holder and http://purl.org/spar/pro/copyright-owner].</para>
    /// labels<para>patent holder</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/patent-holder">http://purl.org/spar/scoro/patent-holder</seealso>
    let patent_holder = Prefixed_Name(scoro, "patent-holder") |> PrefixedName
    /// <summary>
    ///   <para>scoro:percentageFTE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the proportion of a person's full time activity that is dedicated to a particular role (e.g. for part-time employment, 50% FTE).</para>
    /// labels<para>percentage full-time equivalent</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/percentageFTE">http://purl.org/spar/scoro/percentageFTE</seealso>
    let percentageFTE = Prefixed_Name(scoro, "percentageFTE") |> PrefixedName

    /// <summary>
    ///   <para>scoro:performs-experiments</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of performing experiments.</para>
    /// labels<para>performs experiments</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/performs-experiments">http://purl.org/spar/scoro/performs-experiments</seealso>
    let performs_experiments =
        Prefixed_Name(scoro, "performs-experiments") |> PrefixedName

    /// <summary>
    ///   <para>scoro:prepares-illustrations</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of selecting the data and preparing the figures and tables presenting these data for inclusion in the publication. </para>
    /// labels<para>prepares illustrations</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/prepares-illustrations">http://purl.org/spar/scoro/prepares-illustrations</seealso>
    let prepares_illustrations =
        Prefixed_Name(scoro, "prepares-illustrations") |> PrefixedName

    /// <summary>
    ///   <para>scoro:prepares-supplementary-information</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of preparing the supplementary information files submitted with the manuscript. </para>
    /// labels<para>prepares supplementary information</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/prepares-supplementary-information">http://purl.org/spar/scoro/prepares-supplementary-information</seealso>
    let prepares_supplementary_information =
        Prefixed_Name(scoro, "prepares-supplementary-information") |> PrefixedName

    /// <summary>
    ///   <para>scoro:project-leader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>The role a person or an institution has of being project leader for a resource or a project such as a research project.</para>
    /// labels<para>project leader</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/project-leader">http://purl.org/spar/scoro/project-leader</seealso>
    let project_leader = Prefixed_Name(scoro, "project-leader") |> PrefixedName
    /// <summary>
    ///   <para>scoro:project-manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>The role a person has of being project manager for a project such as a research project.</para>
    /// labels<para>project manager</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/project-manager">http://purl.org/spar/scoro/project-manager</seealso>
    let project_manager = Prefixed_Name(scoro, "project-manager") |> PrefixedName
    /// <summary>
    ///   <para>scoro:project-member</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person has of being a member of a project such as a research project.</para>
    /// labels<para>project member</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/project-member">http://purl.org/spar/scoro/project-member</seealso>
    let project_member = Prefixed_Name(scoro, "project-member") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-reagents-specimens-or-materials</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of providing reagents, specimens or materials, including living organisms and cells, for example those not readily obtainable from commercial sources, to make possible the research.</para>
    /// labels<para>provides reagents, specimens or materials</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-reagents-specimens-or-materials">http://purl.org/spar/scoro/provides-reagents-specimens-or-materials</seealso>
    let provides_reagents_specimens_or_materials =
        Prefixed_Name(scoro, "provides-reagents-specimens-or-materials") |> PrefixedName

    /// <summary>
    ///   <para>scoro:provides-service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>The contribution of providing a research service, for example a DNA sequencing service or a custom peptide synthesis service.</para>
    /// labels<para>provided service</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-service">http://purl.org/spar/scoro/provides-service</seealso>
    let provides_service = Prefixed_Name(scoro, "provides-service") |> PrefixedName
    /// <summary>
    ///   <para>scoro:provides-software</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ExperimentalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of providing software to facilitate the research, while not actively participating in the work.</para>
    /// labels<para>provides software</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/provides-software">http://purl.org/spar/scoro/provides-software</seealso>
    let provides_software = Prefixed_Name(scoro, "provides-software") |> PrefixedName

    /// <summary>
    ///   <para>scoro:registration-agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of an agent officially appointed by a Registration Authority that acts to register things. For example, CrossRef is a registration agency for DOIs relating to documents, while DataCite is a registration agency for DOIs relating to datasets, both acting for the Registration Authority for DOIs, namely the International DOI Foundation (IDF).</para>
    /// labels<para>registration agency</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/registration-agency">http://purl.org/spar/scoro/registration-agency</seealso>
    let registration_agency =
        Prefixed_Name(scoro, "registration-agency") |> PrefixedName

    /// <summary>
    ///   <para>scoro:registration-authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>The role of an agent with responsibility for registering and maintaining international standards, internet domain names, patents, controlled vocabularies and other similar entities required for reliable international cooperatative activities.  For example, the International DOI Foundation (IDF) is the Registration Authority for DOIs.</para>
    /// labels<para>registration authority</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/registration-authority">http://purl.org/spar/scoro/registration-authority</seealso>
    let registration_authority =
        Prefixed_Name(scoro, "registration-authority") |> PrefixedName

    /// <summary>
    ///   <para>scoro:repository-manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:DataRole</para>
    ///   <para>The role a person has of being a manager of a repository where entities are given secure long-term storage, typically digital repository for information objects, for example a data repository.</para>
    /// labels<para>repository manager</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/repository-manager">http://purl.org/spar/scoro/repository-manager</seealso>
    let repository_manager = Prefixed_Name(scoro, "repository-manager") |> PrefixedName
    /// <summary>
    ///   <para>scoro:scholar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:InvestigationRole</para>
    ///   <para>The role of an academic who undertakes scholarly activities, including research investigations.  This role is particularly used to describe endeavours in the arts and humanites that are frequently undertaken without financial support from a particular funded project dedicated to these scholarly activities.</para>
    /// labels<para>scholar</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/scholar">http://purl.org/spar/scoro/scholar</seealso>
    let scholar = Prefixed_Name(scoro, "scholar") |> PrefixedName
    /// <summary>
    ///   <para>scoro:secures-funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of securing funding for the research project.
    ///
    /// Note that an individual other than the lead applicant and the co-applicants on a grant application may make contributions to securing funding for a research project, for example by assisting in writing the grant application.</para>
    /// labels<para>secures funding</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/secures-funding">http://purl.org/spar/scoro/secures-funding</seealso>
    let secures_funding = Prefixed_Name(scoro, "secures-funding") |> PrefixedName
    /// <summary>
    ///   <para>scoro:senior-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>The role an author has of being the senior author of the document. </para>
    /// labels<para>senior author</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/senior-author">http://purl.org/spar/scoro/senior-author</seealso>
    let senior_author = Prefixed_Name(scoro, "senior-author") |> PrefixedName
    /// <summary>
    ///   <para>scoro:sub-contractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:FinancialRole</para>
    ///   <para>The role held by an agent who enters into a contract to take over part of another contractor's obligation to undertake specified work or supply specified services in return for payment.</para>
    /// labels<para>sub-contractor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/sub-contractor">http://purl.org/spar/scoro/sub-contractor</seealso>
    let sub_contractor = Prefixed_Name(scoro, "sub-contractor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The relationship held by an entity that succeeds another, for example a new electron microscope that replaces an out-dated one, a research project that follows on from a preceding project, or a faculty member who succeeds a colleague as head of department.</para>
    /// labels<para>successor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/successor">http://purl.org/spar/scoro/successor</seealso>
    let successor = Prefixed_Name(scoro, "successor") |> PrefixedName

    /// <summary>
    ///   <para>scoro:supervises-colleagues</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of supervising, mentoring, instructing or training colleagues, particularly junior research assistants and research students, in aspects of the research or its methodologies.</para>
    /// labels<para>Supervises, mentors or trains colleagues</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/supervises-colleagues">http://purl.org/spar/scoro/supervises-colleagues</seealso>
    let supervises_colleagues =
        Prefixed_Name(scoro, "supervises-colleagues") |> PrefixedName

    /// <summary>
    ///   <para>scoro:vice-chancellor</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:OrganizationalRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role held by the chief executive officer of a university, responsible for directing and managing its business and academic activities.</para>
    /// labels<para>vice-chancellor</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/vice-chancellor">http://purl.org/spar/scoro/vice-chancellor</seealso>
    let vice_chancellor = Prefixed_Name(scoro, "vice-chancellor") |> PrefixedName
    /// <summary>
    ///   <para>scoro:web-master</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:DataRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role of a person responsible for maintaining a web site and its content.</para>
    /// labels<para>web-master</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/web-master">http://purl.org/spar/scoro/web-master</seealso>
    let web_master = Prefixed_Name(scoro, "web-master") |> PrefixedName
    /// <summary>
    ///   <para>scoro:workpackage-leader</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:ProjectRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The role a person or institution has of being leader for a workpackage or sub-project within a project such as a research project, with responsibility for ensuring that the proposed work is undertaken and documented, the generated data are properly curated and archived, and the results are published and reported to the funding agency.</para>
    /// labels<para>workpackage leader</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/workpackage-leader">http://purl.org/spar/scoro/workpackage-leader</seealso>
    let workpackage_leader = Prefixed_Name(scoro, "workpackage-leader") |> PrefixedName

    /// <summary>
    ///   <para>scoro:writes-manuscript-draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>scoro:AuthorshipContribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The contribution of writing the initial draft of the manuscript of the research paper.</para>
    /// labels<para>writes manuscript draft</para></remarks>
    /// <seealso href="http://purl.org/spar/scoro/writes-manuscript-draft">http://purl.org/spar/scoro/writes-manuscript-draft</seealso>
    let writes_manuscript_draft =
        Prefixed_Name(scoro, "writes-manuscript-draft") |> PrefixedName

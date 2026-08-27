namespace http.purl.org.spar.pso.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pso =
    let _namespace_iri = Namespace_Iri pso |> NamespaceIRI
    /// <summary>
    ///   <para>pso:APC-fully-waived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    ///   <para>"The status of an article for which payment of the article processing charge has been fully waived by the publisher."</para>
    /// labels<para>"APC fully waived"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/APC-fully-waived">http://purl.org/spar/pso/APC-fully-waived</seealso>
    let APC_fully_waived = Prefixed_Name(pso, "APC-fully-waived") |> PrefixedName
    /// <summary>
    ///   <para>pso:APC-not-charged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    ///   <para>"The status of an article for which an article processing charge is not charged by the publisher."</para>
    /// labels<para>"APC not charged"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/APC-not-charged">http://purl.org/spar/pso/APC-not-charged</seealso>
    let APC_not_charged = Prefixed_Name(pso, "APC-not-charged") |> PrefixedName
    /// <summary>
    ///   <para>pso:APC-not-required</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of an article for which an article processing charge is not required by the publisher."</para>
    /// labels<para>"APC not required"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/APC-not-required">http://purl.org/spar/pso/APC-not-required</seealso>
    let APC_not_required = Prefixed_Name(pso, "APC-not-required") |> PrefixedName
    /// <summary>
    ///   <para>pso:APC-paid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    ///   <para>"The status of an article for which the article processing charge has been paid to the publisher by the author or his/her institution."</para>
    /// labels<para>"APC paid"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/APC-paid">http://purl.org/spar/pso/APC-paid</seealso>
    let APC_paid = Prefixed_Name(pso, "APC-paid") |> PrefixedName

    /// <summary>
    ///   <para>pso:APC-partially-waived</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of an article for which payment of the article processing charge has been partially waived by the publisher."</para>
    /// labels<para>"APC partially waived"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/APC-partially-waived">http://purl.org/spar/pso/APC-partially-waived</seealso>
    let APC_partially_waived =
        Prefixed_Name(pso, "APC-partially-waived") |> PrefixedName

    /// <summary>
    ///   <para>pso:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity, such as a person, a group, an organization or a software agent, involved in one or more events."</para>
    /// labels<para>"agent"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/Agent">http://purl.org/spar/pso/Agent</seealso>
    let Agent = Prefixed_Name(pso, "Agent") |> PrefixedName

    /// <summary>
    ///   <para>pso:ArticleProcessingChargeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A state or condition that a document may have that relates to a fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article."</para>
    /// labels<para>"article processing charge status"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/ArticleProcessingChargeStatus">http://purl.org/spar/pso/ArticleProcessingChargeStatus</seealso>
    let ArticleProcessingChargeStatus =
        Prefixed_Name(pso, "ArticleProcessingChargeStatus") |> PrefixedName

    /// <summary>
    ///   <para>pso:PublicationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A state or condition that a document may have that relates to the publication of such document."</para>
    /// labels<para>"publishing status"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/PublicationStatus">http://purl.org/spar/pso/PublicationStatus</seealso>
    let PublicationStatus = Prefixed_Name(pso, "PublicationStatus") |> PrefixedName
    /// <summary>
    ///   <para>pso:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A state or condition that a document may have."</para>
    /// labels<para>"status"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/Status">http://purl.org/spar/pso/Status</seealso>
    let Status = Prefixed_Name(pso, "Status") |> PrefixedName
    /// <summary>
    ///   <para>pso:StatusInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular situation that describe a state or condition some documents may have at a particular time as consequence of one or more events."</para>
    /// labels<para>"status in time"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/StatusInTime">http://purl.org/spar/pso/StatusInTime</seealso>
    let StatusInTime = Prefixed_Name(pso, "StatusInTime") |> PrefixedName

    /// <summary>
    ///   <para>pso:accepted-for-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (for example a document or a dataset) once it has been accepted for publication by a publisher or data repository."</para>
    /// labels<para>"accepted for publication"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/accepted-for-publication">http://purl.org/spar/pso/accepted-for-publication</seealso>
    let accepted_for_publication =
        Prefixed_Name(pso, "accepted-for-publication") |> PrefixedName

    /// <summary>
    ///   <para>pso:anonymized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a document or dataset that has been subjected to anonymization, so that individual persons, for example the authors and/or people that are the subjects described in the document or dataset, cannot be identified."</para>
    /// labels<para>"anonymized"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/anonymized">http://purl.org/spar/pso/anonymized</seealso>
    let anonymized = Prefixed_Name(pso, "anonymized") |> PrefixedName
    /// <summary>
    ///   <para>pso:archived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work (for example a document or a dataset) that has been saved for long-term preservation in a physical or electronic archive."</para>
    /// labels<para>"archived"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/archived">http://purl.org/spar/pso/archived</seealso>
    let archived = Prefixed_Name(pso, "archived") |> PrefixedName
    /// <summary>
    ///   <para>pso:catalogued</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (for example a document or a dataset) concerning which metadata has been stored in a physical or electronic catalogue."</para>
    /// labels<para>"catalogued"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/catalogued">http://purl.org/spar/pso/catalogued</seealso>
    let catalogued = Prefixed_Name(pso, "catalogued") |> PrefixedName
    /// <summary>
    ///   <para>pso:closed-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work (typically a private or secret paper or a confidential dataset) that is typically held unpublished in a 'dark' archive whose existence is unknown by the wider world, and that is only available to the owner or copyright holder of the asset."</para>
    /// labels<para>"closed access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/closed-access">http://purl.org/spar/pso/closed-access</seealso>
    let closed_access = Prefixed_Name(pso, "closed-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:confidential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a document containing information that must be kept confidential."</para>
    /// labels<para>"confidential"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/confidential">http://purl.org/spar/pso/confidential</seealso>
    let confidential = Prefixed_Name(pso, "confidential") |> PrefixedName
    /// <summary>
    ///   <para>pso:copy-edited</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a document that has been subjected to copy editing, i.e. alterations to the text undertaken by someone other than the author that are designed to improve the formatting, style and accuracy of text, or to bring the text into the house style of the publisher (e.g. Americanization of British spelling), but that are not designed to alter the substance or meaning of the text."</para>
    /// labels<para>"copy-edited"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/copy-edited">http://purl.org/spar/pso/copy-edited</seealso>
    let copy_edited = Prefixed_Name(pso, "copy-edited") |> PrefixedName
    /// <summary>
    ///   <para>pso:corrected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work (for example a document or a dataset) in which errors, that may have introduced by the author, by a publisher, or by some automated process, have been corrected."</para>
    /// labels<para>"corrected"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/corrected">http://purl.org/spar/pso/corrected</seealso>
    let corrected = Prefixed_Name(pso, "corrected") |> PrefixedName
    /// <summary>
    ///   <para>pso:draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (for example a document or a dataset) prior to completion and publication."</para>
    /// labels<para>"draft"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/draft">http://purl.org/spar/pso/draft</seealso>
    let draft = Prefixed_Name(pso, "draft") |> PrefixedName
    /// <summary>
    ///   <para>pso:embargoed</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work that is subjected to an embargo, which means that the work cannot be published, or in the case of a press release that it cannot be reported on, until a particular date known as the embargo date.  For open-access journal articles, an embargoed article is one in which availability of the open-access version of the article is delayed by the publisher for a substantial embargo period, typically of six or twelve months, after subscription-access availability of the published work.
    ///
    /// "</para>
    /// labels<para>"embargoed"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/embargoed">http://purl.org/spar/pso/embargoed</seealso>
    let embargoed = Prefixed_Name(pso, "embargoed") |> PrefixedName
    /// <summary>
    ///   <para>pso:enhanced</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (for example a document or a dataset) that has been updated or enhanced, for example by the provision of additional or supplementary material."</para>
    /// labels<para>"enhanced"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/enhanced">http://purl.org/spar/pso/enhanced</seealso>
    let enhanced = Prefixed_Name(pso, "enhanced") |> PrefixedName
    /// <summary>
    ///   <para>pso:final-draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a pre-publication work (for example a document or a dataset) when in the authors' opinion it has been brought to a stage of development that renders it suitable for publication."</para>
    /// labels<para>"final draft"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/final-draft">http://purl.org/spar/pso/final-draft</seealso>
    let final_draft = Prefixed_Name(pso, "final-draft") |> PrefixedName
    /// <summary>
    ///   <para>pso:gold-open-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a published work, typically a journal article, made available by the publisher on the publisher's own web site for third parties to read without payment of access or subscription fees.  Gold open access has the benefit that the article is findable where you expect it to be, but licensing restrictions may limit the possibilities for downloading, text mining, modification, re-publication or re-use of the published work.  Gold open-access publication typically involves payment by the author or his/her institution to the publisher of an article processing charge (aka an author publishing charge).  [See also: pso:open-access, pso:gratis-open-access, pso:libre-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]"</para>
    /// labels<para>"gold open access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/gold-open-access">http://purl.org/spar/pso/gold-open-access</seealso>
    let gold_open_access = Prefixed_Name(pso, "gold-open-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:gratis-open-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a published work which is free to read on-line, in contrast to subscription-access works, but to which licensing restrictions apply, limiting the possibilities for downloading, text mining, modification, re-publication or re-use of the published work.  The term Gratis Open Access thus signifies absence of a price barrier to view.  While both imply ‘free’ (a potentially ambiguous word), Gratis Open Access equates to ‘free as in beer’ while Libre Open Access (q.v.) equates to ‘free as in speech’.  Gratis Open Access is thus a necessary but not a sufficient condition for true Libre Open Access.   Many ‘open access’ publications by commercial scholarly publishers are only Gratis Open Access, while almost all publications by ‘pure’ Open Access scholarly publishers are Libre Open Access. [See also: pso:open-access, pso:libre-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]"</para>
    /// labels<para>"gratis open access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/gratis-open-access">http://purl.org/spar/pso/gratis-open-access</seealso>
    let gratis_open_access = Prefixed_Name(pso, "gratis-open-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:green-open-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a published work made available by the author, by self-archiving a version of the work for free and open public use in their institutional repository, in a central repository, or elsewhere, in parallel with publication of a subscription-access Version of Record of the work by a publisher.  The green open-access version of the work may be a preprint (the version of the article as first submitted for publication) or a postprint (the pre-publication version of the article after incorporation of authors’ responses to peer reviewers’ comments).  Its availability may have an embargo restriction imposed by the publisher of the subscription-access version of the work, that prevents the green open-access version from being freely available until some substantial time after publication of the subscription-access journal issue containing that article.  A green open-access work should be accompanied by a license explicitly defining usage rights, for example a Creative Commons Attribution License.  [See also: pso:open-access, pso:gratis-open-access, pso:libre-open-access, pso:gold-open-access, pso:embargoed and pso:subscription-access.]"</para>
    /// labels<para>"green open access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/green-open-access">http://purl.org/spar/pso/green-open-access</seealso>
    let green_open_access = Prefixed_Name(pso, "green-open-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:holdsStatusInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a document, a dataset or some other thing to a status that it holds at a specific time."</para>
    /// labels<para>"holds status in time"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/holdsStatusInTime">http://purl.org/spar/pso/holdsStatusInTime</seealso>
    let holdsStatusInTime = Prefixed_Name(pso, "holdsStatusInTime") |> PrefixedName
    /// <summary>
    ///   <para>pso:in-press</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a document after it has been accepted for publication and prior to its formal publication in print.  (Note that for many journal articles that are published electronically, this status rarely exists, since there is commonly no delay between acceptance and publication.)"</para>
    /// labels<para>"in press"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/in-press">http://purl.org/spar/pso/in-press</seealso>
    let in_press = Prefixed_Name(pso, "in-press") |> PrefixedName
    /// <summary>
    ///   <para>pso:initial-draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a pre-publication work (for example a document or a dataset) when in its initial stage of development."</para>
    /// labels<para>"initial draft"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/initial-draft">http://purl.org/spar/pso/initial-draft</seealso>
    let initial_draft = Prefixed_Name(pso, "initial-draft") |> PrefixedName
    /// <summary>
    ///   <para>pso:intermediate-draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a pre-publication work (for example a document or a dataset) part-way through its development."</para>
    /// labels<para>"intermediate draft"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/intermediate-draft">http://purl.org/spar/pso/intermediate-draft</seealso>
    let intermediate_draft = Prefixed_Name(pso, "intermediate-draft") |> PrefixedName

    /// <summary>
    ///   <para>pso:isAcquiredAsConsequenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating a particular publishing status to the event that causes its acquisition."</para>
    /// labels<para>"is acquired as consequence of"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/isAcquiredAsConsequenceOf">http://purl.org/spar/pso/isAcquiredAsConsequenceOf</seealso>
    let isAcquiredAsConsequenceOf =
        Prefixed_Name(pso, "isAcquiredAsConsequenceOf") |> PrefixedName

    /// <summary>
    ///   <para>pso:isLostAsConsequenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating a particular publishing status to the event that causes its loss."</para>
    /// labels<para>"is lost as consequence of"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/isLostAsConsequenceOf">http://purl.org/spar/pso/isLostAsConsequenceOf</seealso>
    let isLostAsConsequenceOf =
        Prefixed_Name(pso, "isLostAsConsequenceOf") |> PrefixedName

    /// <summary>
    ///   <para>pso:isStatusHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a status held at a specific time to the document, dataset or other thing holding that status."</para>
    /// labels<para>"is status held by"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/isStatusHeldBy">http://purl.org/spar/pso/isStatusHeldBy</seealso>
    let isStatusHeldBy = Prefixed_Name(pso, "isStatusHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>pso:isStatusIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating the definition of a specific status to the situation of the document, a dataset or something else holding that status at a specific time."</para>
    /// labels<para>"is status in"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/isStatusIn">http://purl.org/spar/pso/isStatusIn</seealso>
    let isStatusIn = Prefixed_Name(pso, "isStatusIn") |> PrefixedName
    /// <summary>
    ///   <para>pso:libre-open-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a published work which is both free to read on-line, and to which additional usage rights apply, for example the right to text mine, make derivative works, re-use and re-publish the published work, such rights frequently being defined by application of an explicit license such as a Creative Commons license.  [See also: pso:open-access, pso:gratis-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]"</para>
    /// labels<para>"libre open access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/libre-open-access">http://purl.org/spar/pso/libre-open-access</seealso>
    let libre_open_access = Prefixed_Name(pso, "libre-open-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:non-confidential</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a document containing information that may be shared publicly."</para>
    /// labels<para>"non-confidential"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/non-confidential">http://purl.org/spar/pso/non-confidential</seealso>
    let non_confidential = Prefixed_Name(pso, "non-confidential") |> PrefixedName
    /// <summary>
    ///   <para>pso:open-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a published work (typically a scholarly publication or a dataset) that is freely available via the Internet for third parties to read without payment of access or subscription fees, and (in the case of a work published under a full open-access license) that is freely available to download and reuse for any purposes including commercial ones, including modification of the original work, its integration with other material, and its re-publication, subject typically to a requirement that the original authors and the source of the original work are acknowledged in compliance with scholarly citation norms. [See also: pso:gratis-open-access, pso:libre-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]"</para>
    /// labels<para>"open access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/open-access">http://purl.org/spar/pso/open-access</seealso>
    let open_access = Prefixed_Name(pso, "open-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:peer-reviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work, typically a scholarly journal article, that has been peer reviewed, i.e. subjected to review by two or more independent reviewers (also know as referees) who are academic peers of the author(s), and judged by them to be of sufficient quality to merit publication, usually after further revision by the author to incorporate the reviewers' suggested modifications and improvements."</para>
    /// labels<para>"peer reviewed"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/peer-reviewed">http://purl.org/spar/pso/peer-reviewed</seealso>
    let peer_reviewed = Prefixed_Name(pso, "peer-reviewed") |> PrefixedName
    /// <summary>
    ///   <para>pso:proof</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a pre-publication document late in the publication process, once it has been accepted for publication by a publisher, after the inclusion of any author corrections required by the editor following peer-review, following copy editing and formatting to bring the manuscript into the house style, and prior to final checking by the editor, proof-reader and author to detect and eliminate any errors prior to publication."</para>
    /// labels<para>"proof"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/proof">http://purl.org/spar/pso/proof</seealso>
    let proof = Prefixed_Name(pso, "proof") |> PrefixedName
    /// <summary>
    ///   <para>pso:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of material (for example a document or a dataset) that has been published, i.e. made available for people to access, read or use, either freely or for a purchase price or an access fee."</para>
    /// labels<para>"published"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/published">http://purl.org/spar/pso/published</seealso>
    let published = Prefixed_Name(pso, "published") |> PrefixedName

    /// <summary>
    ///   <para>pso:rejected-for-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of material (for example a document or a dataset) after it has been rejected for publication by a publisher or data repository."</para>
    /// labels<para>"rejected for publication"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/rejected-for-publication">http://purl.org/spar/pso/rejected-for-publication</seealso>
    let rejected_for_publication =
        Prefixed_Name(pso, "rejected-for-publication") |> PrefixedName

    /// <summary>
    ///   <para>pso:republished</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a publication (for example a book) that has been republished in a different edition or in translation, or of a work (for example a journal article or a poem) that is republished as part of a collection or an anthology, or of material (for example a figure from an existing publication) that is republished as part of a quite different publication.  Where the publisher of the new work is different from the original publisher, such republication typically includes an acknowledgement of the source and copyright of the original material, and is undertaken after obtaining permission of the original copyright holder."</para>
    /// labels<para>"republished"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/republished">http://purl.org/spar/pso/republished</seealso>
    let republished = Prefixed_Name(pso, "republished") |> PrefixedName
    /// <summary>
    ///   <para>pso:restricted-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (typically a scholarly paper or a dataset) to which access is restricted.  For example, confidential information to which access is made available only to those who have been approved by the owner or copyright holder of the asset after personal application, or to those with appropriate security clearance, or to those within a partnership."</para>
    /// labels<para>"restricted access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/restricted-access">http://purl.org/spar/pso/restricted-access</seealso>
    let restricted_access = Prefixed_Name(pso, "restricted-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:resultsInAcquiring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating an event to the consequential acquisition of a particular publishing status."</para>
    /// labels<para>"results in acquiring"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/resultsInAcquiring">http://purl.org/spar/pso/resultsInAcquiring</seealso>
    let resultsInAcquiring = Prefixed_Name(pso, "resultsInAcquiring") |> PrefixedName
    /// <summary>
    ///   <para>pso:resultsInLosing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating an event to the consequential loss of a particular publishing status."</para>
    /// labels<para>"results in losing"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/resultsInLosing">http://purl.org/spar/pso/resultsInLosing</seealso>
    let resultsInLosing = Prefixed_Name(pso, "resultsInLosing") |> PrefixedName

    /// <summary>
    ///   <para>pso:retracted-from-publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a publication that has been subsequently retracted by the publisher, for example because it was subsequently found to contain erroneous or fraudulent information."</para>
    /// labels<para>"retracted from publication"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/retracted-from-publication">http://purl.org/spar/pso/retracted-from-publication</seealso>
    let retracted_from_publication =
        Prefixed_Name(pso, "retracted-from-publication") |> PrefixedName

    /// <summary>
    ///   <para>pso:reviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a published work, for example a book or a journal article, that has been subjected to a written review giving critical analysis of its content, scope and quality.  [See also pso:peer-reviewed.]"</para>
    /// labels<para>"reviewed"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/reviewed">http://purl.org/spar/pso/reviewed</seealso>
    let reviewed = Prefixed_Name(pso, "reviewed") |> PrefixedName
    /// <summary>
    ///   <para>pso:revised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of s work (for example a document or a dataset) that has been altered or improved, typically by the original author."</para>
    /// labels<para>"revised"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/revised">http://purl.org/spar/pso/revised</seealso>
    let revised = Prefixed_Name(pso, "revised") |> PrefixedName
    /// <summary>
    ///   <para>pso:submitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a work (for example a document or a dataset) that has been submitted for publication by the author to a publisher or a data repository, prior to its being accepted or rejected."</para>
    /// labels<para>"submitted"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/submitted">http://purl.org/spar/pso/submitted</seealso>
    let submitted = Prefixed_Name(pso, "submitted") |> PrefixedName
    /// <summary>
    ///   <para>pso:subscription-access</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The status of a published work, typically an article in a journal issue, that is not available to read without payment of an article access fee or a journal subscription fee for that publication."</para>
    /// labels<para>"subscription access"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/subscription-access">http://purl.org/spar/pso/subscription-access</seealso>
    let subscription_access = Prefixed_Name(pso, "subscription-access") |> PrefixedName
    /// <summary>
    ///   <para>pso:under-review</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a document that has been received from the author(s) by an editor or a publisher for potential publication, and then has been sent to independent reviewers for their comments as to its suitability for publication, prior to receipt of such reviews."</para>
    /// labels<para>"under review"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/under-review">http://purl.org/spar/pso/under-review</seealso>
    let under_review = Prefixed_Name(pso, "under-review") |> PrefixedName
    /// <summary>
    ///   <para>pso:unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work (for example a document or a dataset) that has not been published by the author, a publisher or a data repository."</para>
    /// labels<para>"unpublished"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/unpublished">http://purl.org/spar/pso/unpublished</seealso>
    let unpublished = Prefixed_Name(pso, "unpublished") |> PrefixedName
    /// <summary>
    ///   <para>pso:version-of-record</para>
    /// </summary>
    /// <remarks>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The final version of a document that has been formally published as a peer-reviewed journal article, citable via a permanent identifier, and forming an abiding component of the scholarly record."</para>
    /// labels<para>"version of record"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/version-of-record">http://purl.org/spar/pso/version-of-record</seealso>
    let version_of_record = Prefixed_Name(pso, "version-of-record") |> PrefixedName
    /// <summary>
    ///   <para>pso:withStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating the holding of a status by a document, a dataset or something else at a specific time to the definition of that status."</para>
    /// labels<para>"with status"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/withStatus">http://purl.org/spar/pso/withStatus</seealso>
    let withStatus = Prefixed_Name(pso, "withStatus") |> PrefixedName

    /// <summary>
    ///   <para>pso:withdrawn-from-submission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pso:PublicationStatus</para>
    ///   <para>"The status of a work (for example a pre-publication document or dataset) that has been voluntarily withdrawn by the author, having previously been submitted for publication, perhaps because the revisions requested by the peer-reviewers were considered impossible to achieve, or because the author wishes to submit it for publication elsewhere."</para>
    /// labels<para>"withdrawn from submission"</para></remarks>
    /// <seealso href="http://purl.org/spar/pso/withdrawn-from-submission">http://purl.org/spar/pso/withdrawn-from-submission</seealso>
    let withdrawn_from_submission =
        Prefixed_Name(pso, "withdrawn-from-submission") |> PrefixedName

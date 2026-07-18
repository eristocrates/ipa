namespace http.purl.org.spar.pso.slash

open DoxAletheia.Rdf_Vocabulary

module pso =
    let _namespace_name = "http://purl.org/spar/pso/"

    /// <summary>
    /// The status of an article for which payment of the article processing charge has been fully waived by the publisher.
    /// <see href="http://purl.org/spar/pso/APC-fully-waived"></see></summary>
    let ``APC-fully-waived`` =
        Namespaced_IRI.parse _namespace_name "APC-fully-waived" |> NamespacedName

    /// <summary>
    /// A state or condition that a document may have that relates to a fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article.
    /// <see href="http://purl.org/spar/pso/ArticleProcessingChargeStatus"></see></summary>
    let ArticleProcessingChargeStatus =
        Namespaced_IRI.parse _namespace_name "ArticleProcessingChargeStatus" |> NamespacedName

    /// <summary>
    /// The status of an article for which an article processing charge is not charged by the publisher.
    /// <see href="http://purl.org/spar/pso/APC-not-charged"></see></summary>
    let ``APC-not-charged`` =
        Namespaced_IRI.parse _namespace_name "APC-not-charged" |> NamespacedName

    /// <summary>
    /// The status of an article for which an article processing charge is not required by the publisher.
    /// <see href="http://purl.org/spar/pso/APC-not-required"></see></summary>
    let ``APC-not-required`` =
        Namespaced_IRI.parse _namespace_name "APC-not-required" |> NamespacedName

    /// <summary>
    /// The status of an article for which the article processing charge has been paid to the publisher by the author or his/her institution.
    /// <see href="http://purl.org/spar/pso/APC-paid"></see></summary>
    let ``APC-paid`` = Namespaced_IRI.parse _namespace_name "APC-paid" |> NamespacedName

    /// <summary>
    /// The status of an article for which payment of the article processing charge has been partially waived by the publisher.
    /// <see href="http://purl.org/spar/pso/APC-partially-waived"></see></summary>
    let ``APC-partially-waived`` =
        Namespaced_IRI.parse _namespace_name "APC-partially-waived" |> NamespacedName

    /// <summary>
    /// An entity, such as a person, a group, an organization or a software agent, involved in one or more events.
    /// <see href="http://purl.org/spar/pso/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// A state or condition that a document may have.
    /// <see href="http://purl.org/spar/pso/Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A state or condition that a document may have that relates to the publication of such document.
    /// <see href="http://purl.org/spar/pso/PublicationStatus"></see></summary>
    let PublicationStatus =
        Namespaced_IRI.parse _namespace_name "PublicationStatus" |> NamespacedName

    /// <summary>
    /// A particular situation that describe a state or condition some documents may have at a particular time as consequence of one or more events.
    /// <see href="http://purl.org/spar/pso/StatusInTime"></see></summary>
    let StatusInTime =
        Namespaced_IRI.parse _namespace_name "StatusInTime" |> NamespacedName

    /// <summary>
    /// A property relating a status held at a specific time to the document, dataset or other thing holding that status.
    /// <see href="http://purl.org/spar/pso/isStatusHeldBy"></see></summary>
    let isStatusHeldBy =
        Namespaced_IRI.parse _namespace_name "isStatusHeldBy" |> NamespacedName

    /// <summary>
    /// The property relating the holding of a status by a document, a dataset or something else at a specific time to the definition of that status.
    /// <see href="http://purl.org/spar/pso/withStatus"></see></summary>
    let withStatus = Namespaced_IRI.parse _namespace_name "withStatus" |> NamespacedName

    /// <summary>
    /// The property relating a particular publishing status to the event that causes its acquisition.
    /// <see href="http://purl.org/spar/pso/isAcquiredAsConsequenceOf"></see></summary>
    let isAcquiredAsConsequenceOf =
        Namespaced_IRI.parse _namespace_name "isAcquiredAsConsequenceOf" |> NamespacedName

    /// <summary>
    /// The status of a work (for example a document or a dataset) once it has been accepted for publication by a publisher or data repository.
    /// <see href="http://purl.org/spar/pso/accepted-for-publication"></see></summary>
    let ``accepted-for-publication`` =
        Namespaced_IRI.parse _namespace_name "accepted-for-publication" |> NamespacedName

    /// <summary>
    /// The status of a document or dataset that has been subjected to anonymization, so that individual persons, for example the authors and/or people that are the subjects described in the document or dataset, cannot be identified.
    /// <see href="http://purl.org/spar/pso/anonymized"></see></summary>
    let anonymized = Namespaced_IRI.parse _namespace_name "anonymized" |> NamespacedName
    /// <summary>
    /// The status of a work (for example a document or a dataset) that has been saved for long-term preservation in a physical or electronic archive.
    /// <see href="http://purl.org/spar/pso/archived"></see></summary>
    let archived = Namespaced_IRI.parse _namespace_name "archived" |> NamespacedName
    /// <summary>
    /// The status of a work (for example a document or a dataset) concerning which metadata has been stored in a physical or electronic catalogue.
    /// <see href="http://purl.org/spar/pso/catalogued"></see></summary>
    let catalogued = Namespaced_IRI.parse _namespace_name "catalogued" |> NamespacedName

    /// <summary>
    /// The status of a work (typically a private or secret paper or a confidential dataset) that is typically held unpublished in a 'dark' archive whose existence is unknown by the wider world, and that is only available to the owner or copyright holder of the asset.
    /// <see href="http://purl.org/spar/pso/closed-access"></see></summary>
    let ``closed-access`` =
        Namespaced_IRI.parse _namespace_name "closed-access" |> NamespacedName

    /// <summary>
    /// The status of a document containing information that must be kept confidential.
    /// <see href="http://purl.org/spar/pso/confidential"></see></summary>
    let confidential =
        Namespaced_IRI.parse _namespace_name "confidential" |> NamespacedName

    /// <summary>
    /// The status of a document that has been subjected to copy editing, i.e. alterations to the text undertaken by someone other than the author that are designed to improve the formatting, style and accuracy of text, or to bring the text into the house style of the publisher (e.g. Americanization of British spelling), but that are not designed to alter the substance or meaning of the text.
    /// <see href="http://purl.org/spar/pso/copy-edited"></see></summary>
    let ``copy-edited`` =
        Namespaced_IRI.parse _namespace_name "copy-edited" |> NamespacedName

    /// <summary>
    /// The status of a work (for example a document or a dataset) in which errors, that may have introduced by the author, by a publisher, or by some automated process, have been corrected.
    /// <see href="http://purl.org/spar/pso/corrected"></see></summary>
    let corrected = Namespaced_IRI.parse _namespace_name "corrected" |> NamespacedName
    /// <summary>
    /// The status of a work (for example a document or a dataset) prior to completion and publication.
    /// <see href="http://purl.org/spar/pso/draft"></see></summary>
    let draft = Namespaced_IRI.parse _namespace_name "draft" |> NamespacedName
    /// <summary>
    /// The status of a work that is subjected to an embargo, which means that the work cannot be published, or in the case of a press release that it cannot be reported on, until a particular date known as the embargo date.  For open-access journal articles, an embargoed article is one in which availability of the open-access version of the article is delayed by the publisher for a substantial embargo period, typically of six or twelve months, after subscription-access availability of the published work.
    ///
    ///
    /// <see href="http://purl.org/spar/pso/embargoed"></see></summary>
    let embargoed = Namespaced_IRI.parse _namespace_name "embargoed" |> NamespacedName
    /// <summary>
    /// The status of a work (for example a document or a dataset) that has been updated or enhanced, for example by the provision of additional or supplementary material.
    /// <see href="http://purl.org/spar/pso/enhanced"></see></summary>
    let enhanced = Namespaced_IRI.parse _namespace_name "enhanced" |> NamespacedName

    /// <summary>
    /// The status of a pre-publication work (for example a document or a dataset) when in the authors' opinion it has been brought to a stage of development that renders it suitable for publication.
    /// <see href="http://purl.org/spar/pso/final-draft"></see></summary>
    let ``final-draft`` =
        Namespaced_IRI.parse _namespace_name "final-draft" |> NamespacedName

    /// <summary>
    /// The status of a published work, typically a journal article, made available by the publisher on the publisher's own web site for third parties to read without payment of access or subscription fees.  Gold open access has the benefit that the article is findable where you expect it to be, but licensing restrictions may limit the possibilities for downloading, text mining, modification, re-publication or re-use of the published work.  Gold open-access publication typically involves payment by the author or his/her institution to the publisher of an article processing charge (aka an author publishing charge).  [See also: pso:open-access, pso:gratis-open-access, pso:libre-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]
    /// <see href="http://purl.org/spar/pso/gold-open-access"></see></summary>
    let ``gold-open-access`` =
        Namespaced_IRI.parse _namespace_name "gold-open-access" |> NamespacedName

    /// <summary>
    /// The status of a published work which is free to read on-line, in contrast to subscription-access works, but to which licensing restrictions apply, limiting the possibilities for downloading, text mining, modification, re-publication or re-use of the published work.  The term Gratis Open Access thus signifies absence of a price barrier to view.  While both imply ‘free’ (a potentially ambiguous word), Gratis Open Access equates to ‘free as in beer’ while Libre Open Access (q.v.) equates to ‘free as in speech’.  Gratis Open Access is thus a necessary but not a sufficient condition for true Libre Open Access.   Many ‘open access’ publications by commercial scholarly publishers are only Gratis Open Access, while almost all publications by ‘pure’ Open Access scholarly publishers are Libre Open Access. [See also: pso:open-access, pso:libre-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]
    /// <see href="http://purl.org/spar/pso/gratis-open-access"></see></summary>
    let ``gratis-open-access`` =
        Namespaced_IRI.parse _namespace_name "gratis-open-access" |> NamespacedName

    /// <summary>
    /// The status of a published work made available by the author, by self-archiving a version of the work for free and open public use in their institutional repository, in a central repository, or elsewhere, in parallel with publication of a subscription-access Version of Record of the work by a publisher.  The green open-access version of the work may be a preprint (the version of the article as first submitted for publication) or a postprint (the pre-publication version of the article after incorporation of authors’ responses to peer reviewers’ comments).  Its availability may have an embargo restriction imposed by the publisher of the subscription-access version of the work, that prevents the green open-access version from being freely available until some substantial time after publication of the subscription-access journal issue containing that article.  A green open-access work should be accompanied by a license explicitly defining usage rights, for example a Creative Commons Attribution License.  [See also: pso:open-access, pso:gratis-open-access, pso:libre-open-access, pso:gold-open-access, pso:embargoed and pso:subscription-access.]
    /// <see href="http://purl.org/spar/pso/green-open-access"></see></summary>
    let ``green-open-access`` =
        Namespaced_IRI.parse _namespace_name "green-open-access" |> NamespacedName

    /// <summary>
    /// A property relating a document, a dataset or some other thing to a status that it holds at a specific time.
    /// <see href="http://purl.org/spar/pso/holdsStatusInTime"></see></summary>
    let holdsStatusInTime =
        Namespaced_IRI.parse _namespace_name "holdsStatusInTime" |> NamespacedName

    /// <summary>
    /// The status of a document after it has been accepted for publication and prior to its formal publication in print.  (Note that for many journal articles that are published electronically, this status rarely exists, since there is commonly no delay between acceptance and publication.)
    /// <see href="http://purl.org/spar/pso/in-press"></see></summary>
    let ``in-press`` = Namespaced_IRI.parse _namespace_name "in-press" |> NamespacedName

    /// <summary>
    /// The status of a pre-publication work (for example a document or a dataset) when in its initial stage of development.
    /// <see href="http://purl.org/spar/pso/initial-draft"></see></summary>
    let ``initial-draft`` =
        Namespaced_IRI.parse _namespace_name "initial-draft" |> NamespacedName

    /// <summary>
    /// The status of a pre-publication work (for example a document or a dataset) part-way through its development.
    /// <see href="http://purl.org/spar/pso/intermediate-draft"></see></summary>
    let ``intermediate-draft`` =
        Namespaced_IRI.parse _namespace_name "intermediate-draft" |> NamespacedName

    /// <summary>
    /// The property relating a particular publishing status to the event that causes its loss.
    /// <see href="http://purl.org/spar/pso/isLostAsConsequenceOf"></see></summary>
    let isLostAsConsequenceOf =
        Namespaced_IRI.parse _namespace_name "isLostAsConsequenceOf" |> NamespacedName

    /// <summary>
    /// The property relating the definition of a specific status to the situation of the document, a dataset or something else holding that status at a specific time.
    /// <see href="http://purl.org/spar/pso/isStatusIn"></see></summary>
    let isStatusIn = Namespaced_IRI.parse _namespace_name "isStatusIn" |> NamespacedName

    /// <summary>
    /// The status of a published work which is both free to read on-line, and to which additional usage rights apply, for example the right to text mine, make derivative works, re-use and re-publish the published work, such rights frequently being defined by application of an explicit license such as a Creative Commons license.  [See also: pso:open-access, pso:gratis-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]
    /// <see href="http://purl.org/spar/pso/libre-open-access"></see></summary>
    let ``libre-open-access`` =
        Namespaced_IRI.parse _namespace_name "libre-open-access" |> NamespacedName

    /// <summary>
    /// The status of a document containing information that may be shared publicly.
    /// <see href="http://purl.org/spar/pso/non-confidential"></see></summary>
    let ``non-confidential`` =
        Namespaced_IRI.parse _namespace_name "non-confidential" |> NamespacedName

    /// <summary>
    /// The status of a published work (typically a scholarly publication or a dataset) that is freely available via the Internet for third parties to read without payment of access or subscription fees, and (in the case of a work published under a full open-access license) that is freely available to download and reuse for any purposes including commercial ones, including modification of the original work, its integration with other material, and its re-publication, subject typically to a requirement that the original authors and the source of the original work are acknowledged in compliance with scholarly citation norms. [See also: pso:gratis-open-access, pso:libre-open-access, pso:gold-open-access, pso:green-open-access, pso:embargoed and pso:subscription-access.]
    /// <see href="http://purl.org/spar/pso/open-access"></see></summary>
    let ``open-access`` =
        Namespaced_IRI.parse _namespace_name "open-access" |> NamespacedName

    /// <summary>
    /// The status of a work, typically a scholarly journal article, that has been peer reviewed, i.e. subjected to review by two or more independent reviewers (also know as referees) who are academic peers of the author(s), and judged by them to be of sufficient quality to merit publication, usually after further revision by the author to incorporate the reviewers' suggested modifications and improvements.
    /// <see href="http://purl.org/spar/pso/peer-reviewed"></see></summary>
    let ``peer-reviewed`` =
        Namespaced_IRI.parse _namespace_name "peer-reviewed" |> NamespacedName

    /// <summary>
    /// The status of a published work, for example a book or a journal article, that has been subjected to a written review giving critical analysis of its content, scope and quality.  [See also pso:peer-reviewed.]
    /// <see href="http://purl.org/spar/pso/reviewed"></see></summary>
    let reviewed = Namespaced_IRI.parse _namespace_name "reviewed" |> NamespacedName
    /// <summary>
    /// The status of a pre-publication document late in the publication process, once it has been accepted for publication by a publisher, after the inclusion of any author corrections required by the editor following peer-review, following copy editing and formatting to bring the manuscript into the house style, and prior to final checking by the editor, proof-reader and author to detect and eliminate any errors prior to publication.
    /// <see href="http://purl.org/spar/pso/proof"></see></summary>
    let proof = Namespaced_IRI.parse _namespace_name "proof" |> NamespacedName
    /// <summary>
    /// The status of material (for example a document or a dataset) that has been published, i.e. made available for people to access, read or use, either freely or for a purchase price or an access fee.
    /// <see href="http://purl.org/spar/pso/published"></see></summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName

    /// <summary>
    /// The status of material (for example a document or a dataset) after it has been rejected for publication by a publisher or data repository.
    /// <see href="http://purl.org/spar/pso/rejected-for-publication"></see></summary>
    let ``rejected-for-publication`` =
        Namespaced_IRI.parse _namespace_name "rejected-for-publication" |> NamespacedName

    /// <summary>
    /// The status of a publication (for example a book) that has been republished in a different edition or in translation, or of a work (for example a journal article or a poem) that is republished as part of a collection or an anthology, or of material (for example a figure from an existing publication) that is republished as part of a quite different publication.  Where the publisher of the new work is different from the original publisher, such republication typically includes an acknowledgement of the source and copyright of the original material, and is undertaken after obtaining permission of the original copyright holder.
    /// <see href="http://purl.org/spar/pso/republished"></see></summary>
    let republished =
        Namespaced_IRI.parse _namespace_name "republished" |> NamespacedName

    /// <summary>
    /// The status of a work (typically a scholarly paper or a dataset) to which access is restricted.  For example, confidential information to which access is made available only to those who have been approved by the owner or copyright holder of the asset after personal application, or to those with appropriate security clearance, or to those within a partnership.
    /// <see href="http://purl.org/spar/pso/restricted-access"></see></summary>
    let ``restricted-access`` =
        Namespaced_IRI.parse _namespace_name "restricted-access" |> NamespacedName

    /// <summary>
    /// The property relating an event to the consequential acquisition of a particular publishing status.
    /// <see href="http://purl.org/spar/pso/resultsInAcquiring"></see></summary>
    let resultsInAcquiring =
        Namespaced_IRI.parse _namespace_name "resultsInAcquiring" |> NamespacedName

    /// <summary>
    /// The property relating an event to the consequential loss of a particular publishing status.
    /// <see href="http://purl.org/spar/pso/resultsInLosing"></see></summary>
    let resultsInLosing =
        Namespaced_IRI.parse _namespace_name "resultsInLosing" |> NamespacedName

    /// <summary>
    /// The status of a publication that has been subsequently retracted by the publisher, for example because it was subsequently found to contain erroneous or fraudulent information.
    /// <see href="http://purl.org/spar/pso/retracted-from-publication"></see></summary>
    let ``retracted-from-publication`` =
        Namespaced_IRI.parse _namespace_name "retracted-from-publication" |> NamespacedName

    /// <summary>
    /// The status of s work (for example a document or a dataset) that has been altered or improved, typically by the original author.
    /// <see href="http://purl.org/spar/pso/revised"></see></summary>
    let revised = Namespaced_IRI.parse _namespace_name "revised" |> NamespacedName
    /// <summary>
    /// The status of a work (for example a document or a dataset) that has been submitted for publication by the author to a publisher or a data repository, prior to its being accepted or rejected.
    /// <see href="http://purl.org/spar/pso/submitted"></see></summary>
    let submitted = Namespaced_IRI.parse _namespace_name "submitted" |> NamespacedName

    /// <summary>
    /// The status of a published work, typically an article in a journal issue, that is not available to read without payment of an article access fee or a journal subscription fee for that publication.
    /// <see href="http://purl.org/spar/pso/subscription-access"></see></summary>
    let ``subscription-access`` =
        Namespaced_IRI.parse _namespace_name "subscription-access" |> NamespacedName

    /// <summary>
    /// The status of a document that has been received from the author(s) by an editor or a publisher for potential publication, and then has been sent to independent reviewers for their comments as to its suitability for publication, prior to receipt of such reviews.
    /// <see href="http://purl.org/spar/pso/under-review"></see></summary>
    let ``under-review`` =
        Namespaced_IRI.parse _namespace_name "under-review" |> NamespacedName

    /// <summary>
    /// The status of a work (for example a document or a dataset) that has not been published by the author, a publisher or a data repository.
    /// <see href="http://purl.org/spar/pso/unpublished"></see></summary>
    let unpublished =
        Namespaced_IRI.parse _namespace_name "unpublished" |> NamespacedName

    /// <summary>
    /// The final version of a document that has been formally published as a peer-reviewed journal article, citable via a permanent identifier, and forming an abiding component of the scholarly record.
    /// <see href="http://purl.org/spar/pso/version-of-record"></see></summary>
    let ``version-of-record`` =
        Namespaced_IRI.parse _namespace_name "version-of-record" |> NamespacedName

    /// <summary>
    /// The status of a work (for example a pre-publication document or dataset) that has been voluntarily withdrawn by the author, having previously been submitted for publication, perhaps because the revisions requested by the peer-reviewers were considered impossible to achieve, or because the author wishes to submit it for publication elsewhere.
    /// <see href="http://purl.org/spar/pso/withdrawn-from-submission"></see></summary>
    let ``withdrawn-from-submission`` =
        Namespaced_IRI.parse _namespace_name "withdrawn-from-submission" |> NamespacedName

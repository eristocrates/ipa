#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ptr-ptr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/" "fibo-be-ptr-ptr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : general partner^^xsd:string</para>
    ///   <para>skos:definition : partner and part-owner that is responsible for managing the day to day operations of the partnership and that may be jointly and severally liable for the obligations of the partnership^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that although typically a general partner is a person, in the context of certain funds, such as private equity, a general partner may be a firm that manages the fund.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartner">fibo-be-ptr-ptr:GeneralPartner</a>
    /// </summary>
    let GeneralPartner = _prefixId.prefix "GeneralPartner"
    /// <summary>
    ///   <para>rdfs:label : general partnership^^xsd:string</para>
    ///   <para>skos:definition : partnership that has at least two general partners that agree to share in all assets, profits, and financial and legal liabilities of the business^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : GP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : General partnerships are the most basic and common form of partnership world-wide.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartnership">fibo-be-ptr-ptr:GeneralPartnership</a>
    /// </summary>
    let GeneralPartnership = _prefixId.prefix "GeneralPartnership"

    /// <summary>
    ///   <para>rdfs:label : limited liability limited partnership^^xsd:string</para>
    ///   <para>skos:definition : limited partnership that consists of one or more general partners who are liable for the obligations of the entity as well as one or more protected limited liability partners^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LLLP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The primary difference between an LLLP and more traditional limited partnership is that an LLLP allows liability transfer from the general partner's (to external insurer) for debts and obligations of the limited partnership. Typically, general partners manage the LLLP, while the limited partners' interest is primarily for investment purposes.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityLimitedPartnership">fibo-be-ptr-ptr:LimitedLiabilityLimitedPartnership</a>
    /// </summary>
    let LimitedLiabilityLimitedPartnership =
        _prefixId.prefix "LimitedLiabilityLimitedPartnership"

    /// <summary>
    ///   <para>rdfs:label : limited liability partnership^^xsd:string</para>
    ///   <para>skos:definition : partnership that has general partners but provides its individual partners some level of protection against personal liability for certain partnership liabilities^^xsd:string</para>
    ///   <para>skos:example : Law firms, accountancies, wealth managers, professional medical groups, and other professional consultancies often take the form of a limited liability partnership.^^xsd:stringskos:example : One example of a limited liability partnership is that of an incorporated limited partnership (ILP) in Australia.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LLP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : LLPs are a flexible legal and tax entity that allows partners to benefit from economies of scale by working together while also reducing their liability for the actions of other partners.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityPartnership">fibo-be-ptr-ptr:LimitedLiabilityPartnership</a>
    /// </summary>
    let LimitedLiabilityPartnership = _prefixId.prefix "LimitedLiabilityPartnership"
    /// <summary>
    ///   <para>rdfs:label : limited partner^^xsd:string</para>
    ///   <para>skos:definition : partner whose liabilities are limited to the extent of their investment or guarantees and that has no involvement in the day to day operations of the partnership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartner">fibo-be-ptr-ptr:LimitedPartner</a>
    /// </summary>
    let LimitedPartner = _prefixId.prefix "LimitedPartner"
    /// <summary>
    ///   <para>rdfs:label : limited partnership^^xsd:string</para>
    ///   <para>skos:definition : partnership that has at least one general partner and at least one limited partner^^xsd:string</para>
    ///   <para>skos:example : In the United States, film production companies, real estate investment firms, and private equity firms are typically formed as limited partnerships. In the United Kingdom, limited partnerships are governed by the Limited Partnerships Act 1907 and, on matters on which that Act is silent, also by the Partnership Act 1890.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Limited partnerships are distinct from limited liability partnerships, in which all partners have limited liability. Similar to a general partnership, the general partners have management control, share the right to use partnership property, share the profits of the firm in predefined proportions, and have joint and several liability for the debts of the partnership.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartnership">fibo-be-ptr-ptr:LimitedPartnership</a>
    /// </summary>
    let LimitedPartnership = _prefixId.prefix "LimitedPartnership"
    /// <summary>
    ///   <para>rdfs:label : partner^^xsd:string</para>
    ///   <para>skos:definition : co-owner, member, and agent of a partnership whose participation level, including proportional liabilities and share in the profit / loss of the business is specified in a partnership agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partner">fibo-be-ptr-ptr:Partner</a>
    /// </summary>
    let Partner = _prefixId.prefix "Partner"
    /// <summary>
    ///   <para>rdfs:label : partnership^^xsd:string</para>
    ///   <para>skos:definition : association of two or more legal persons to carry on as co-owners a business for profit^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Partnerships exist in many countries world-wide. Examples of the laws related to the establishment and operation of partnerships include the Partnership Act of 1890 in the United Kingdom and the Uniform Partnership Act in the United States.^^xsd:stringcmns-av:explanatoryNote : Whether or not partnerships are established through, for example, incorporation, depends on the jurisdiction. Partnerships typically not corporations in the US, but can be in Australia and Ghana. See https://legalvision.com.au/what-are-incorporated-limited-partnerships/ and http://swiftlaw.co/incorporated-partnership/ for additional details.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partnership">fibo-be-ptr-ptr:Partnership</a>
    /// </summary>
    let Partnership = _prefixId.prefix "Partnership"
    /// <summary>
    ///   <para>rdfs:label : partnership agreement^^xsd:string</para>
    ///   <para>skos:definition : contract between partners in a partnership that establishes the terms and conditions of the relationship between the partners^^xsd:string</para>
    ///   <para>cmns-av:synonym : articles of partnership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/PartnershipAgreement">fibo-be-ptr-ptr:PartnershipAgreement</a>
    /// </summary>
    let PartnershipAgreement = _prefixId.prefix "PartnershipAgreement"
    /// <summary>
    ///   <para>rdfs:label : has general partner^^xsd:string</para>
    ///   <para>skos:definition : indicates an actor that has some measure of control over the partnership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasGeneralPartner">fibo-be-ptr-ptr:hasGeneralPartner</a>
    /// </summary>
    let hasGeneralPartner = _prefixId.prefix "hasGeneralPartner"
    /// <summary>
    ///   <para>rdfs:label : has limited partner^^xsd:string</para>
    ///   <para>skos:definition : indicates an actor that may have some measure of influence over the partnership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasLimitedPartner">fibo-be-ptr-ptr:hasLimitedPartner</a>
    /// </summary>
    let hasLimitedPartner = _prefixId.prefix "hasLimitedPartner"
    /// <summary>
    ///   <para>rdfs:label : is general partner of^^xsd:string</para>
    ///   <para>skos:definition : indicates the organization that the general partner manages^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isGeneralPartnerOf">fibo-be-ptr-ptr:isGeneralPartnerOf</a>
    /// </summary>
    let isGeneralPartnerOf = _prefixId.prefix "isGeneralPartnerOf"
    /// <summary>
    ///   <para>rdfs:label : is limited partner of^^xsd:string</para>
    ///   <para>skos:definition : indicates the organization that the limited partner participates in^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isLimitedPartnerOf">fibo-be-ptr-ptr:isLimitedPartnerOf</a>
    /// </summary>
    let isLimitedPartnerOf = _prefixId.prefix "isLimitedPartnerOf"

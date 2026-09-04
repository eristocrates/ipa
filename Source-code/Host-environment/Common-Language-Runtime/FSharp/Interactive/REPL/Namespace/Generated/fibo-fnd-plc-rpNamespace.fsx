#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-plc-rp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/" "fibo-fnd-plc-rp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : personal property</para>
    ///   <para>skos:definition : asset that is a movable item or possession not fixed to land</para>
    ///   <para>cmns-av:explanatoryNote : Personal property may include tangible assets, such as machinery, furniture, vehicles, artwork, and jewelry, regardless of whether such assets are owned by a person or organization, and intangible assets, including but not limited to intellectual property and financial instruments.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PersonalProperty">fibo-fnd-plc-rp:PersonalProperty</a>
    /// </summary>
    let PersonalProperty = _prefixId.prefix "PersonalProperty"
    /// <summary>
    ///   <para>rdfs:label : property inspection^^xsd:string</para>
    ///   <para>skos:definition : event that involves analyzing one or more aspects of a real property^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The concept of a property inspection is separate from conducting an overarching appraisal. Examples are termite inspections, construction inspections, evaluation for completion of some milestone, improvement, correction, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspection">fibo-fnd-plc-rp:PropertyInspection</a>
    /// </summary>
    let PropertyInspection = _prefixId.prefix "PropertyInspection"
    /// <summary>
    ///   <para>rdfs:label : property inspection report^^xsd:string</para>
    ///   <para>skos:definition : report covering the findings of a property inspection^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspectionReport">fibo-fnd-plc-rp:PropertyInspectionReport</a>
    /// </summary>
    let PropertyInspectionReport = _prefixId.prefix "PropertyInspectionReport"
    /// <summary>
    ///   <para>rdfs:label : real estate</para>
    ///   <para>skos:definition : real property, interests in mortgages on real property (including interests in mortgages on leaseholds of land or improvements thereon), and shares in qualified real estate investment trusts</para>
    ///   <para>cmns-av:adaptedFrom : https://www.law.cornell.edu/cfr/text/26/1.856-3^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The term 'mortgages on real property' includes deeds of trust on real property. Note that interpretation of the term 'real estate' is context-dependent - this broader interpretation is used in tax law in the US and elsewhere.</para>
    ///   <para>cmns-av:synonym : real estate asset</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealEstate">fibo-fnd-plc-rp:RealEstate</a>
    /// </summary>
    let RealEstate = _prefixId.prefix "RealEstate"
    /// <summary>
    ///   <para>rdfs:label : real property</para>
    ///   <para>skos:definition : physical asset defined as land together with any structures that are permanently attached to that land, such as houses, trees, fences and improvements</para>
    ///   <para>cmns-av:adaptedFrom : https://www.law.cornell.edu/cfr/text/10/600.101^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Real property may be classified according to its general use as residential, commercial, agricultural, industrial, or special purpose. This term is sometimes used synonymously with 'real estate', though not in all circumstances under US law.cmns-av:explanatoryNote : Real property typically encompasses both the physical land and everything that lies above, below, or on its surface, including any fixed structures, natural resources, and rights or interests (e.g., mineral rights). There are cases, such as condominiums, in which the interior of the structure is owned by a party that may not own the land. There are also cases in which certain long-term leases have similar characteristics to ownership, but are time-bound.</para>
    ///   <para>cmns-av:synonym : parcel</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealProperty">fibo-fnd-plc-rp:RealProperty</a>
    /// </summary>
    let RealProperty = _prefixId.prefix "RealProperty"
    /// <summary>
    ///   <para>rdfs:label : real property appraisal^^xsd:string</para>
    ///   <para>skos:definition : value assessment that estimates the amount of money some real property is worth^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The valuation uses one or more methodologies and is conducted by an appraiser or technology with a logical model that performs the same function.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyAppraisal">fibo-fnd-plc-rp:RealPropertyAppraisal</a>
    /// </summary>
    let RealPropertyAppraisal = _prefixId.prefix "RealPropertyAppraisal"
    /// <summary>
    ///   <para>rdfs:label : real property identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier given to identify a specific real property in some jurisidiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyIdentifier">fibo-fnd-plc-rp:RealPropertyIdentifier</a>
    /// </summary>
    let RealPropertyIdentifier = _prefixId.prefix "RealPropertyIdentifier"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractIdentifier">fibo-fnd-plc-rp:TractIdentifier</a>
    /// </summary>
    let TractIdentifier = _prefixId.prefix "TractIdentifier"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractOfLand">fibo-fnd-plc-rp:TractOfLand</a>
    /// </summary>
    let TractOfLand = _prefixId.prefix "TractOfLand"

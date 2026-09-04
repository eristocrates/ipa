#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-org-fm`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/" "fibo-fnd-org-fm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : employee^^xsd:string</para>
    ///   <para>skos:definition : person in the service of another under any contract of hire, express or implied, oral or written, where the employer has the right to control and direct that person in the material details of how the work is to be performed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employee">fibo-fnd-org-fm:Employee</a>
    /// </summary>
    let Employee = _prefixId.prefix "Employee"
    /// <summary>
    ///   <para>rdfs:label : employer^^xsd:string</para>
    ///   <para>skos:definition : party that provides compensation, including wages or a salary and potentially other benefits, in exchange for work performed by one or more people, and that has the right to control and direct the employee in the material details of how the work is to be performed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employer">fibo-fnd-org-fm:Employer</a>
    /// </summary>
    let Employer = _prefixId.prefix "Employer"
    /// <summary>
    ///   <para>rdfs:label : employment</para>
    ///   <para>skos:definition : situation representing the state of being employed, i.e., the relationship that holds between an employer and employee for some period of time^^xsd:string</para>
    ///   <para>skos:scopeNote : This definition does not include workers in contingent arrangements, such as independent contractors, leased employees, temporary employees, on-call workers, and others that do not have a direct contractual relationship with the employer. The distinction is important for legal reasons, particularly for regulatory reporting with respect to responsible parties such as corporate officers, lending officers, others authorized or licensed to perform certain tasks, and traders, for example.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the broadest sense, employment is the situation in which someone is fully engaged in doing something that they want to do. From a FIBO perspective, however, employment is understood to be more specific. It is the relationship between two parties, evidenced by an implicit or explicit contract, in which work is compensated and in which one party, a legal person, typically a formal organization, acts as the employer and the other, typically a legally capable natural person, as the employee.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employment">fibo-fnd-org-fm:Employment</a>
    /// </summary>
    let Employment = _prefixId.prefix "Employment"
    /// <summary>
    ///   <para>rdfs:label : group^^xsd:string</para>
    ///   <para>skos:definition : collection of agents (people, organizations, software agents, etc.) that are considered as a unit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Group">fibo-fnd-org-fm:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : employs^^xsd:string</para>
    ///   <para>skos:definition : indicates someone that is employed by the legal person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/employs">fibo-fnd-org-fm:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>rdfs:label : has employed party^^xsd:string</para>
    ///   <para>skos:definition : identifies the employee in an employment situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployedParty">fibo-fnd-org-fm:hasEmployedParty</a>
    /// </summary>
    let hasEmployedParty = _prefixId.prefix "hasEmployedParty"
    /// <summary>
    ///   <para>rdfs:label : has employee^^xsd:string</para>
    ///   <para>skos:definition : indicates an employee that is employed by the employer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployee">fibo-fnd-org-fm:hasEmployee</a>
    /// </summary>
    let hasEmployee = _prefixId.prefix "hasEmployee"
    /// <summary>
    ///   <para>rdfs:label : has employing party^^xsd:string</para>
    ///   <para>skos:definition : identifies employer in an employment situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployingParty">fibo-fnd-org-fm:hasEmployingParty</a>
    /// </summary>
    let hasEmployingParty = _prefixId.prefix "hasEmployingParty"
    /// <summary>
    ///   <para>rdfs:label : is employed by^^xsd:string</para>
    ///   <para>skos:definition : indicates the party (legal person or formal organization) that employs someone^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedBy">fibo-fnd-org-fm:isEmployedBy</a>
    /// </summary>
    let isEmployedBy = _prefixId.prefix "isEmployedBy"
    /// <summary>
    ///   <para>rdfs:label : is employed in^^xsd:string</para>
    ///   <para>skos:definition : indicates the context of employment in which someone is employed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedIn">fibo-fnd-org-fm:isEmployedIn</a>
    /// </summary>
    let isEmployedIn = _prefixId.prefix "isEmployedIn"
    /// <summary>
    ///   <para>rdfs:label : is employee of^^xsd:string</para>
    ///   <para>skos:definition : identifies the formal organization for which the employee works^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployeeOf">fibo-fnd-org-fm:isEmployeeOf</a>
    /// </summary>
    let isEmployeeOf = _prefixId.prefix "isEmployeeOf"
    /// <summary>
    ///   <para>rdfs:label : is employing party^^xsd:string</para>
    ///   <para>skos:definition : relates a party in the role of employer to the context of employment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployingParty">fibo-fnd-org-fm:isEmployingParty</a>
    /// </summary>
    let isEmployingParty = _prefixId.prefix "isEmployingParty"

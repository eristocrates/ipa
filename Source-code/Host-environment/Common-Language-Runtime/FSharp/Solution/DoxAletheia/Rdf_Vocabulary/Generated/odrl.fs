namespace http.www.w3.org.ns.odrl._2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odrl =
    let _namespace_iri = Namespace_Iri odrl |> NamespaceIRI
    /// <summary>
    ///   <para>odrl:includedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Included In</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/includedIn">http://www.w3.org/ns/odrl/2/includedIn</seealso>
    let includedIn = Prefixed_Name(odrl, "includedIn") |> PrefixedName
    /// <summary>
    ///   <para>odrl:use</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Use</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/use">http://www.w3.org/ns/odrl/2/use</seealso>
    let use_ = Prefixed_Name(odrl, "use") |> PrefixedName
    /// <summary>
    ///   <para>odrl:adHocShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Ad-hoc sharing</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/adHocShare">http://www.w3.org/ns/odrl/2/adHocShare</seealso>
    let adHocShare = Prefixed_Name(odrl, "adHocShare") |> PrefixedName
    /// <summary>
    ///   <para>odrl:AllConnections</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:PartyScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>All First-Level Connections</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/AllConnections">http://www.w3.org/ns/odrl/2/AllConnections</seealso>
    let AllConnections = Prefixed_Name(odrl, "AllConnections") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#duties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#duties">http://www.w3.org/ns/odrl/2/#duties</seealso>
    let ``_#duties`` = Prefixed_Name(odrl, "#duties") |> PrefixedName
    /// <summary>
    ///   <para>odrl:consequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Consequence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/consequence">http://www.w3.org/ns/odrl/2/consequence</seealso>
    let consequence = Prefixed_Name(odrl, "consequence") |> PrefixedName
    /// <summary>
    ///   <para>odrl:duty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Duty</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/duty">http://www.w3.org/ns/odrl/2/duty</seealso>
    let duty = Prefixed_Name(odrl, "duty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#partyConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#partyConcepts">http://www.w3.org/ns/odrl/2/#partyConcepts</seealso>
    let ``_#partyConcepts`` = Prefixed_Name(odrl, "#partyConcepts") |> PrefixedName
    /// <summary>
    ///   <para>odrl:assignerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Assigner Of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/assignerOf">http://www.w3.org/ns/odrl/2/assignerOf</seealso>
    let assignerOf = Prefixed_Name(odrl, "assignerOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:assigneeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Assignee Of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/assigneeOf">http://www.w3.org/ns/odrl/2/assigneeOf</seealso>
    let assigneeOf = Prefixed_Name(odrl, "assigneeOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:attributedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Attributed Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/attributedParty">http://www.w3.org/ns/odrl/2/attributedParty</seealso>
    let attributedParty = Prefixed_Name(odrl, "attributedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:compensatedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Compensated Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/compensatedParty">http://www.w3.org/ns/odrl/2/compensatedParty</seealso>
    let compensatedParty = Prefixed_Name(odrl, "compensatedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is the RDF ontology for ODRL Version 2.2.</para>
    /// labels<para>ODRL Version 2.2</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/">http://www.w3.org/ns/odrl/2/</seealso>
    let _prefix_iri = Prefixed_Name(odrl, "") |> PrefixedName
    /// <summary>
    ///   <para>odrl:include</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Include</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/include">http://www.w3.org/ns/odrl/2/include</seealso>
    let include_ = Prefixed_Name(odrl, "include") |> PrefixedName
    /// <summary>
    ///   <para>odrl:play</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Play</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/play">http://www.w3.org/ns/odrl/2/play</seealso>
    let play = Prefixed_Name(odrl, "play") |> PrefixedName
    /// <summary>
    ///   <para>odrl:present</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Present</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/present">http://www.w3.org/ns/odrl/2/present</seealso>
    let present = Prefixed_Name(odrl, "present") |> PrefixedName
    /// <summary>
    ///   <para>odrl:delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Delete</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/delete">http://www.w3.org/ns/odrl/2/delete</seealso>
    let delete = Prefixed_Name(odrl, "delete") |> PrefixedName
    /// <summary>
    ///   <para>odrl:derive</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Derive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/derive">http://www.w3.org/ns/odrl/2/derive</seealso>
    let derive = Prefixed_Name(odrl, "derive") |> PrefixedName
    /// <summary>
    ///   <para>odrl:execute</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Execute</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/execute">http://www.w3.org/ns/odrl/2/execute</seealso>
    let execute = Prefixed_Name(odrl, "execute") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#conflictConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#conflictConcepts">http://www.w3.org/ns/odrl/2/#conflictConcepts</seealso>
    let ``_#conflictConcepts`` =
        Prefixed_Name(odrl, "#conflictConcepts") |> PrefixedName

    /// <summary>
    ///   <para>odrl:xone</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Only One</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/xone">http://www.w3.org/ns/odrl/2/xone</seealso>
    let xone = Prefixed_Name(odrl, "xone") |> PrefixedName
    /// <summary>
    ///   <para>odrl:gteq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Operator</para>
    ///
    /// labels<para>Greater than or equal to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/gteq">http://www.w3.org/ns/odrl/2/gteq</seealso>
    let gteq = Prefixed_Name(odrl, "gteq") |> PrefixedName
    /// <summary>
    ///   <para>odrl:isNoneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Is none of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/isNoneOf">http://www.w3.org/ns/odrl/2/isNoneOf</seealso>
    let isNoneOf = Prefixed_Name(odrl, "isNoneOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:gt</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Operator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Greater than</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/gt">http://www.w3.org/ns/odrl/2/gt</seealso>
    let gt = Prefixed_Name(odrl, "gt") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#constraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#constraints">http://www.w3.org/ns/odrl/2/#constraints</seealso>
    let ``_#constraints`` = Prefixed_Name(odrl, "#constraints") |> PrefixedName
    /// <summary>
    ///   <para>odrl:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/constraint">http://www.w3.org/ns/odrl/2/constraint</seealso>
    let constraint_ = Prefixed_Name(odrl, "constraint") |> PrefixedName

    /// <summary>
    ///   <para>odrl:rightOperandReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Right Operand Reference</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/rightOperandReference">http://www.w3.org/ns/odrl/2/rightOperandReference</seealso>
    let rightOperandReference =
        Prefixed_Name(odrl, "rightOperandReference") |> PrefixedName

    /// <summary>
    ///   <para>odrl:RightOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Right Operand</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/RightOperand">http://www.w3.org/ns/odrl/2/RightOperand</seealso>
    let RightOperand = Prefixed_Name(odrl, "RightOperand") |> PrefixedName
    /// <summary>
    ///   <para>odrl:refinement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Refinement</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/refinement">http://www.w3.org/ns/odrl/2/refinement</seealso>
    let refinement = Prefixed_Name(odrl, "refinement") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Constraint">http://www.w3.org/ns/odrl/2/Constraint</seealso>
    let Constraint = Prefixed_Name(odrl, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>odrl:All</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:PartyScope</para>
    ///
    /// labels<para>All</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/All">http://www.w3.org/ns/odrl/2/All</seealso>
    let All = Prefixed_Name(odrl, "All") |> PrefixedName
    /// <summary>
    ///   <para>odrl:All2ndConnections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:PartyScope</para>
    ///
    /// labels<para>All Second-level Connections</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/All2ndConnections">http://www.w3.org/ns/odrl/2/All2ndConnections</seealso>
    let All2ndConnections = Prefixed_Name(odrl, "All2ndConnections") |> PrefixedName
    /// <summary>
    ///   <para>odrl:device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Device</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/device">http://www.w3.org/ns/odrl/2/device</seealso>
    let device = Prefixed_Name(odrl, "device") |> PrefixedName
    /// <summary>
    ///   <para>odrl:write</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Write</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/write">http://www.w3.org/ns/odrl/2/write</seealso>
    let write = Prefixed_Name(odrl, "write") |> PrefixedName
    /// <summary>
    ///   <para>odrl:inheritRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Inherit Relation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/inheritRelation">http://www.w3.org/ns/odrl/2/inheritRelation</seealso>
    let inheritRelation = Prefixed_Name(odrl, "inheritRelation") |> PrefixedName
    /// <summary>
    ///   <para>odrl:lend</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lend</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/lend">http://www.w3.org/ns/odrl/2/lend</seealso>
    let lend = Prefixed_Name(odrl, "lend") |> PrefixedName
    /// <summary>
    ///   <para>odrl:writeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Write to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/writeTo">http://www.w3.org/ns/odrl/2/writeTo</seealso>
    let writeTo = Prefixed_Name(odrl, "writeTo") |> PrefixedName
    /// <summary>
    ///   <para>odrl:system</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>System</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/system">http://www.w3.org/ns/odrl/2/system</seealso>
    let system = Prefixed_Name(odrl, "system") |> PrefixedName
    /// <summary>
    ///   <para>odrl:ignore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:UndefinedTerm</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ignore Undefined Actions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/ignore">http://www.w3.org/ns/odrl/2/ignore</seealso>
    let ignore = Prefixed_Name(odrl, "ignore") |> PrefixedName
    /// <summary>
    ///   <para>odrl:preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Preview</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/preview">http://www.w3.org/ns/odrl/2/preview</seealso>
    let preview = Prefixed_Name(odrl, "preview") |> PrefixedName
    /// <summary>
    ///   <para>odrl:extractChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Extract character</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/extractChar">http://www.w3.org/ns/odrl/2/extractChar</seealso>
    let extractChar = Prefixed_Name(odrl, "extractChar") |> PrefixedName
    /// <summary>
    ///   <para>odrl:share</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Share</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/share">http://www.w3.org/ns/odrl/2/share</seealso>
    let share = Prefixed_Name(odrl, "share") |> PrefixedName
    /// <summary>
    ///   <para>odrl:extractPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Extract page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/extractPage">http://www.w3.org/ns/odrl/2/extractPage</seealso>
    let extractPage = Prefixed_Name(odrl, "extractPage") |> PrefixedName
    /// <summary>
    ///   <para>odrl:secondaryUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Secondary Use</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/secondaryUse">http://www.w3.org/ns/odrl/2/secondaryUse</seealso>
    let secondaryUse = Prefixed_Name(odrl, "secondaryUse") |> PrefixedName
    /// <summary>
    ///   <para>odrl:extractWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Extract word</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/extractWord">http://www.w3.org/ns/odrl/2/extractWord</seealso>
    let extractWord = Prefixed_Name(odrl, "extractWord") |> PrefixedName
    /// <summary>
    ///   <para>odrl:undefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Handle Undefined Term</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/undefined">http://www.w3.org/ns/odrl/2/undefined</seealso>
    let undefined = Prefixed_Name(odrl, "undefined") |> PrefixedName
    /// <summary>
    ///   <para>odrl:append</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Append</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/append">http://www.w3.org/ns/odrl/2/append</seealso>
    let append = Prefixed_Name(odrl, "append") |> PrefixedName
    /// <summary>
    ///   <para>odrl:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>License</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/license">http://www.w3.org/ns/odrl/2/license</seealso>
    let license = Prefixed_Name(odrl, "license") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#logicalConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#logicalConstraints">http://www.w3.org/ns/odrl/2/#logicalConstraints</seealso>
    let ``_#logicalConstraints`` =
        Prefixed_Name(odrl, "#logicalConstraints") |> PrefixedName

    /// <summary>
    ///   <para>odrl:operand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Operand</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/operand">http://www.w3.org/ns/odrl/2/operand</seealso>
    let operand = Prefixed_Name(odrl, "operand") |> PrefixedName
    /// <summary>
    ///   <para>odrl:LogicalConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Logical Constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/LogicalConstraint">http://www.w3.org/ns/odrl/2/LogicalConstraint</seealso>
    let LogicalConstraint = Prefixed_Name(odrl, "LogicalConstraint") |> PrefixedName
    /// <summary>
    ///   <para>odrl:assigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Assigner</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/assigner">http://www.w3.org/ns/odrl/2/assigner</seealso>
    let assigner = Prefixed_Name(odrl, "assigner") |> PrefixedName
    /// <summary>
    ///   <para>odrl:assignee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Assignee</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/assignee">http://www.w3.org/ns/odrl/2/assignee</seealso>
    let assignee = Prefixed_Name(odrl, "assignee") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#partyRolesCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#partyRolesCommon">http://www.w3.org/ns/odrl/2/#partyRolesCommon</seealso>
    let ``_#partyRolesCommon`` =
        Prefixed_Name(odrl, "#partyRolesCommon") |> PrefixedName

    /// <summary>
    ///   <para>odrl:trackedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Tracked Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/trackedParty">http://www.w3.org/ns/odrl/2/trackedParty</seealso>
    let trackedParty = Prefixed_Name(odrl, "trackedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:contractedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contracted Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/contractedParty">http://www.w3.org/ns/odrl/2/contractedParty</seealso>
    let contractedParty = Prefixed_Name(odrl, "contractedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:attributingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Attributing Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/attributingParty">http://www.w3.org/ns/odrl/2/attributingParty</seealso>
    let attributingParty = Prefixed_Name(odrl, "attributingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:consentedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Consented Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/consentedParty">http://www.w3.org/ns/odrl/2/consentedParty</seealso>
    let consentedParty = Prefixed_Name(odrl, "consentedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#policyConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#policyConcepts">http://www.w3.org/ns/odrl/2/#policyConcepts</seealso>
    let ``_#policyConcepts`` = Prefixed_Name(odrl, "#policyConcepts") |> PrefixedName
    /// <summary>
    ///   <para>odrl:inheritFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Inherits From</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/inheritFrom">http://www.w3.org/ns/odrl/2/inheritFrom</seealso>
    let inheritFrom = Prefixed_Name(odrl, "inheritFrom") |> PrefixedName
    /// <summary>
    ///   <para>odrl:profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Profile</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/profile">http://www.w3.org/ns/odrl/2/profile</seealso>
    let profile = Prefixed_Name(odrl, "profile") |> PrefixedName
    /// <summary>
    ///   <para>odrl:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Unique Identifier</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/uid">http://www.w3.org/ns/odrl/2/uid</seealso>
    let uid = Prefixed_Name(odrl, "uid") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#policySubClassesCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#policySubClassesCommon">http://www.w3.org/ns/odrl/2/#policySubClassesCommon</seealso>
    let ``_#policySubClassesCommon`` =
        Prefixed_Name(odrl, "#policySubClassesCommon") |> PrefixedName

    /// <summary>
    ///   <para>odrl:Ticket</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Ticket</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Ticket">http://www.w3.org/ns/odrl/2/Ticket</seealso>
    let Ticket = Prefixed_Name(odrl, "Ticket") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Request</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Request">http://www.w3.org/ns/odrl/2/Request</seealso>
    let Request = Prefixed_Name(odrl, "Request") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Prohibition</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Prohibition">http://www.w3.org/ns/odrl/2/Prohibition</seealso>
    let Prohibition = Prefixed_Name(odrl, "Prohibition") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#ruleConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#ruleConcepts">http://www.w3.org/ns/odrl/2/#ruleConcepts</seealso>
    let ``_#ruleConcepts`` = Prefixed_Name(odrl, "#ruleConcepts") |> PrefixedName
    /// <summary>
    ///   <para>odrl:failure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Failure</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/failure">http://www.w3.org/ns/odrl/2/failure</seealso>
    let failure = Prefixed_Name(odrl, "failure") |> PrefixedName
    /// <summary>
    ///   <para>odrl:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/function">http://www.w3.org/ns/odrl/2/function</seealso>
    let function_ = Prefixed_Name(odrl, "function") |> PrefixedName
    /// <summary>
    ///   <para>odrl:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Relation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/relation">http://www.w3.org/ns/odrl/2/relation</seealso>
    let relation = Prefixed_Name(odrl, "relation") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Rule</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Rule">http://www.w3.org/ns/odrl/2/Rule</seealso>
    let Rule = Prefixed_Name(odrl, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:PartyScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Group">http://www.w3.org/ns/odrl/2/Group</seealso>
    let Group = Prefixed_Name(odrl, "Group") |> PrefixedName
    /// <summary>
    ///   <para>odrl:appendTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Append To</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/appendTo">http://www.w3.org/ns/odrl/2/appendTo</seealso>
    let appendTo = Prefixed_Name(odrl, "appendTo") |> PrefixedName
    /// <summary>
    ///   <para>odrl:attachSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Attach source</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/attachSource">http://www.w3.org/ns/odrl/2/attachSource</seealso>
    let attachSource = Prefixed_Name(odrl, "attachSource") |> PrefixedName
    /// <summary>
    ///   <para>odrl:support</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:UndefinedTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Support Undefined Actions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/support">http://www.w3.org/ns/odrl/2/support</seealso>
    let support = Prefixed_Name(odrl, "support") |> PrefixedName
    /// <summary>
    ///   <para>odrl:remedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remedy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/remedy">http://www.w3.org/ns/odrl/2/remedy</seealso>
    let remedy = Prefixed_Name(odrl, "remedy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:obligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Obligation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/obligation">http://www.w3.org/ns/odrl/2/obligation</seealso>
    let obligation = Prefixed_Name(odrl, "obligation") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Duty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Duty</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Duty">http://www.w3.org/ns/odrl/2/Duty</seealso>
    let Duty = Prefixed_Name(odrl, "Duty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:PartyCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Party Collection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/PartyCollection">http://www.w3.org/ns/odrl/2/PartyCollection</seealso>
    let PartyCollection = Prefixed_Name(odrl, "PartyCollection") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Party">http://www.w3.org/ns/odrl/2/Party</seealso>
    let Party = Prefixed_Name(odrl, "Party") |> PrefixedName
    /// <summary>
    ///   <para>odrl:consentingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Consenting Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/consentingParty">http://www.w3.org/ns/odrl/2/consentingParty</seealso>
    let consentingParty = Prefixed_Name(odrl, "consentingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:contractingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contracting Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/contractingParty">http://www.w3.org/ns/odrl/2/contractingParty</seealso>
    let contractingParty = Prefixed_Name(odrl, "contractingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:informingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Informing Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/informingParty">http://www.w3.org/ns/odrl/2/informingParty</seealso>
    let informingParty = Prefixed_Name(odrl, "informingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:compensatingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Compensating Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/compensatingParty">http://www.w3.org/ns/odrl/2/compensatingParty</seealso>
    let compensatingParty = Prefixed_Name(odrl, "compensatingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Permission</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Permission">http://www.w3.org/ns/odrl/2/Permission</seealso>
    let Permission = Prefixed_Name(odrl, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Policy">http://www.w3.org/ns/odrl/2/Policy</seealso>
    let Policy = Prefixed_Name(odrl, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Offer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Offer">http://www.w3.org/ns/odrl/2/Offer</seealso>
    let Offer = Prefixed_Name(odrl, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Agreement</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Agreement">http://www.w3.org/ns/odrl/2/Agreement</seealso>
    let Agreement = Prefixed_Name(odrl, "Agreement") |> PrefixedName
    /// <summary>
    ///   <para>odrl:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>ODRL Core Profile</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/core">http://www.w3.org/ns/odrl/2/core</seealso>
    let core = Prefixed_Name(odrl, "core") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#actionConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#actionConcepts">http://www.w3.org/ns/odrl/2/#actionConcepts</seealso>
    let ``_#actionConcepts`` = Prefixed_Name(odrl, "#actionConcepts") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#actions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#actions">http://www.w3.org/ns/odrl/2/#actions</seealso>
    let ``_#actions`` = Prefixed_Name(odrl, "#actions") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#actionsCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#actionsCommon">http://www.w3.org/ns/odrl/2/#actionsCommon</seealso>
    let ``_#actionsCommon`` = Prefixed_Name(odrl, "#actionsCommon") |> PrefixedName
    /// <summary>
    ///   <para>odrl:print</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Print</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/print">http://www.w3.org/ns/odrl/2/print</seealso>
    let print = Prefixed_Name(odrl, "print") |> PrefixedName
    /// <summary>
    ///   <para>odrl:uninstall</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Uninstall</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/uninstall">http://www.w3.org/ns/odrl/2/uninstall</seealso>
    let uninstall = Prefixed_Name(odrl, "uninstall") |> PrefixedName
    /// <summary>
    ///   <para>odrl:transform</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Transform</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/transform">http://www.w3.org/ns/odrl/2/transform</seealso>
    let transform = Prefixed_Name(odrl, "transform") |> PrefixedName
    /// <summary>
    ///   <para>odrl:compensate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Compensate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/compensate">http://www.w3.org/ns/odrl/2/compensate</seealso>
    let compensate = Prefixed_Name(odrl, "compensate") |> PrefixedName
    /// <summary>
    ///   <para>odrl:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Attribute</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/attribute">http://www.w3.org/ns/odrl/2/attribute</seealso>
    let attribute = Prefixed_Name(odrl, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>odrl:read</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Read</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/read">http://www.w3.org/ns/odrl/2/read</seealso>
    let read = Prefixed_Name(odrl, "read") |> PrefixedName
    /// <summary>
    ///   <para>odrl:synchronize</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Synchronize</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/synchronize">http://www.w3.org/ns/odrl/2/synchronize</seealso>
    let synchronize = Prefixed_Name(odrl, "synchronize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:obtainConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Obtain Consent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/obtainConsent">http://www.w3.org/ns/odrl/2/obtainConsent</seealso>
    let obtainConsent = Prefixed_Name(odrl, "obtainConsent") |> PrefixedName
    /// <summary>
    ///   <para>odrl:concurrentUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Concurrent Use</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/concurrentUse">http://www.w3.org/ns/odrl/2/concurrentUse</seealso>
    let concurrentUse = Prefixed_Name(odrl, "concurrentUse") |> PrefixedName
    /// <summary>
    ///   <para>odrl:ensureExclusivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ensure Exclusivity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/ensureExclusivity">http://www.w3.org/ns/odrl/2/ensureExclusivity</seealso>
    let ensureExclusivity = Prefixed_Name(odrl, "ensureExclusivity") |> PrefixedName
    /// <summary>
    ///   <para>odrl:display</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Display</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/display">http://www.w3.org/ns/odrl/2/display</seealso>
    let display = Prefixed_Name(odrl, "display") |> PrefixedName
    /// <summary>
    ///   <para>odrl:acceptTracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Accept Tracking</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/acceptTracking">http://www.w3.org/ns/odrl/2/acceptTracking</seealso>
    let acceptTracking = Prefixed_Name(odrl, "acceptTracking") |> PrefixedName
    /// <summary>
    ///   <para>odrl:reviewPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Review Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/reviewPolicy">http://www.w3.org/ns/odrl/2/reviewPolicy</seealso>
    let reviewPolicy = Prefixed_Name(odrl, "reviewPolicy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Archive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/archive">http://www.w3.org/ns/odrl/2/archive</seealso>
    let archive = Prefixed_Name(odrl, "archive") |> PrefixedName
    /// <summary>
    ///   <para>odrl:annotate</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Annotate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/annotate">http://www.w3.org/ns/odrl/2/annotate</seealso>
    let annotate = Prefixed_Name(odrl, "annotate") |> PrefixedName
    /// <summary>
    ///   <para>odrl:stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Stream</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/stream">http://www.w3.org/ns/odrl/2/stream</seealso>
    let stream = Prefixed_Name(odrl, "stream") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#assetConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#assetConcepts">http://www.w3.org/ns/odrl/2/#assetConcepts</seealso>
    let ``_#assetConcepts`` = Prefixed_Name(odrl, "#assetConcepts") |> PrefixedName
    /// <summary>
    ///   <para>odrl:implies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Implies</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/implies">http://www.w3.org/ns/odrl/2/implies</seealso>
    let implies = Prefixed_Name(odrl, "implies") |> PrefixedName
    /// <summary>
    ///   <para>odrl:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Action</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/action">http://www.w3.org/ns/odrl/2/action</seealso>
    let action = Prefixed_Name(odrl, "action") |> PrefixedName
    /// <summary>
    ///   <para>odrl:transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Transfer Ownership</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/transfer">http://www.w3.org/ns/odrl/2/transfer</seealso>
    let transfer = Prefixed_Name(odrl, "transfer") |> PrefixedName
    /// <summary>
    ///   <para>odrl:extract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Extract</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/extract">http://www.w3.org/ns/odrl/2/extract</seealso>
    let extract = Prefixed_Name(odrl, "extract") |> PrefixedName
    /// <summary>
    ///   <para>odrl:install</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Install</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/install">http://www.w3.org/ns/odrl/2/install</seealso>
    let install = Prefixed_Name(odrl, "install") |> PrefixedName
    /// <summary>
    ///   <para>odrl:sell</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Sell</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/sell">http://www.w3.org/ns/odrl/2/sell</seealso>
    let sell = Prefixed_Name(odrl, "sell") |> PrefixedName
    /// <summary>
    ///   <para>odrl:nextPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Next Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/nextPolicy">http://www.w3.org/ns/odrl/2/nextPolicy</seealso>
    let nextPolicy = Prefixed_Name(odrl, "nextPolicy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:translate</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Translate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/translate">http://www.w3.org/ns/odrl/2/translate</seealso>
    let translate = Prefixed_Name(odrl, "translate") |> PrefixedName
    /// <summary>
    ///   <para>odrl:inform</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Inform</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/inform">http://www.w3.org/ns/odrl/2/inform</seealso>
    let inform = Prefixed_Name(odrl, "inform") |> PrefixedName
    /// <summary>
    ///   <para>odrl:aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Aggregate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/aggregate">http://www.w3.org/ns/odrl/2/aggregate</seealso>
    let aggregate = Prefixed_Name(odrl, "aggregate") |> PrefixedName
    /// <summary>
    ///   <para>odrl:modify</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Modify</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/modify">http://www.w3.org/ns/odrl/2/modify</seealso>
    let modify = Prefixed_Name(odrl, "modify") |> PrefixedName
    /// <summary>
    ///   <para>odrl:grantUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Grant Use</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/grantUse">http://www.w3.org/ns/odrl/2/grantUse</seealso>
    let grantUse = Prefixed_Name(odrl, "grantUse") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#assetParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#assetParty">http://www.w3.org/ns/odrl/2/#assetParty</seealso>
    let ``_#assetParty`` = Prefixed_Name(odrl, "#assetParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:reproduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Reproduce</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/reproduce">http://www.w3.org/ns/odrl/2/reproduce</seealso>
    let reproduce = Prefixed_Name(odrl, "reproduce") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Asset">http://www.w3.org/ns/odrl/2/Asset</seealso>
    let Asset = Prefixed_Name(odrl, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>odrl:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/source">http://www.w3.org/ns/odrl/2/source</seealso>
    let source = Prefixed_Name(odrl, "source") |> PrefixedName
    /// <summary>
    ///   <para>odrl:AssetCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Asset Collection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/AssetCollection">http://www.w3.org/ns/odrl/2/AssetCollection</seealso>
    let AssetCollection = Prefixed_Name(odrl, "AssetCollection") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#assetRelations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#assetRelations">http://www.w3.org/ns/odrl/2/#assetRelations</seealso>
    let ``_#assetRelations`` = Prefixed_Name(odrl, "#assetRelations") |> PrefixedName
    /// <summary>
    ///   <para>odrl:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/target">http://www.w3.org/ns/odrl/2/target</seealso>
    let target = Prefixed_Name(odrl, "target") |> PrefixedName
    /// <summary>
    ///   <para>odrl:output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Output</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/output">http://www.w3.org/ns/odrl/2/output</seealso>
    let output = Prefixed_Name(odrl, "output") |> PrefixedName
    /// <summary>
    ///   <para>odrl:prohibit</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:ConflictTerm</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Prefer Prohibitions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/prohibit">http://www.w3.org/ns/odrl/2/prohibit</seealso>
    let prohibit = Prefixed_Name(odrl, "prohibit") |> PrefixedName
    /// <summary>
    ///   <para>odrl:conflict</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Handle Policy Conflicts</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/conflict">http://www.w3.org/ns/odrl/2/conflict</seealso>
    let conflict = Prefixed_Name(odrl, "conflict") |> PrefixedName
    /// <summary>
    ///   <para>odrl:resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Rendition Resolution</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/resolution">http://www.w3.org/ns/odrl/2/resolution</seealso>
    let resolution = Prefixed_Name(odrl, "resolution") |> PrefixedName
    /// <summary>
    ///   <para>odrl:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Purpose</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/purpose">http://www.w3.org/ns/odrl/2/purpose</seealso>
    let purpose = Prefixed_Name(odrl, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>odrl:spatialCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Geospatial Coordinates</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/spatialCoordinates">http://www.w3.org/ns/odrl/2/spatialCoordinates</seealso>
    let spatialCoordinates = Prefixed_Name(odrl, "spatialCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>odrl:fileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>File Format</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/fileFormat">http://www.w3.org/ns/odrl/2/fileFormat</seealso>
    let fileFormat = Prefixed_Name(odrl, "fileFormat") |> PrefixedName
    /// <summary>
    ///   <para>odrl:payAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Payment Amount</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/payAmount">http://www.w3.org/ns/odrl/2/payAmount</seealso>
    let payAmount = Prefixed_Name(odrl, "payAmount") |> PrefixedName
    /// <summary>
    ///   <para>odrl:absoluteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Absolute Asset Size</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/absoluteSize">http://www.w3.org/ns/odrl/2/absoluteSize</seealso>
    let absoluteSize = Prefixed_Name(odrl, "absoluteSize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Asset Percentage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/percentage">http://www.w3.org/ns/odrl/2/percentage</seealso>
    let percentage = Prefixed_Name(odrl, "percentage") |> PrefixedName
    /// <summary>
    ///   <para>odrl:relativePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Relative Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/relativePosition">http://www.w3.org/ns/odrl/2/relativePosition</seealso>
    let relativePosition = Prefixed_Name(odrl, "relativePosition") |> PrefixedName
    /// <summary>
    ///   <para>odrl:meteredTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Metered Time</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/meteredTime">http://www.w3.org/ns/odrl/2/meteredTime</seealso>
    let meteredTime = Prefixed_Name(odrl, "meteredTime") |> PrefixedName
    /// <summary>
    ///   <para>odrl:recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Recipient</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/recipient">http://www.w3.org/ns/odrl/2/recipient</seealso>
    let recipient = Prefixed_Name(odrl, "recipient") |> PrefixedName
    /// <summary>
    ///   <para>odrl:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Part Of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/partOf">http://www.w3.org/ns/odrl/2/partOf</seealso>
    let partOf = Prefixed_Name(odrl, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:hasPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Target Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/hasPolicy">http://www.w3.org/ns/odrl/2/hasPolicy</seealso>
    let hasPolicy = Prefixed_Name(odrl, "hasPolicy") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#assetRelationsCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#assetRelationsCommon">http://www.w3.org/ns/odrl/2/#assetRelationsCommon</seealso>
    let ``_#assetRelationsCommon`` =
        Prefixed_Name(odrl, "#assetRelationsCommon") |> PrefixedName

    /// <summary>
    ///   <para>odrl:invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:ConflictTerm</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Void Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/invalid">http://www.w3.org/ns/odrl/2/invalid</seealso>
    let invalid = Prefixed_Name(odrl, "invalid") |> PrefixedName
    /// <summary>
    ///   <para>odrl:perm</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:ConflictTerm</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Prefer Permissions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/perm">http://www.w3.org/ns/odrl/2/perm</seealso>
    let perm = Prefixed_Name(odrl, "perm") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#constraintLeftOperandCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#constraintLeftOperandCommon">http://www.w3.org/ns/odrl/2/#constraintLeftOperandCommon</seealso>
    let ``_#constraintLeftOperandCommon`` =
        Prefixed_Name(odrl, "#constraintLeftOperandCommon") |> PrefixedName

    /// <summary>
    ///   <para>odrl:relativeTemporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Relative Temporal Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/relativeTemporalPosition">http://www.w3.org/ns/odrl/2/relativeTemporalPosition</seealso>
    let relativeTemporalPosition =
        Prefixed_Name(odrl, "relativeTemporalPosition") |> PrefixedName

    /// <summary>
    ///   <para>odrl:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Datetime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/dateTime">http://www.w3.org/ns/odrl/2/dateTime</seealso>
    let dateTime = Prefixed_Name(odrl, "dateTime") |> PrefixedName

    /// <summary>
    ///   <para>odrl:absoluteSpatialPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Absolute Spatial Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/absoluteSpatialPosition">http://www.w3.org/ns/odrl/2/absoluteSpatialPosition</seealso>
    let absoluteSpatialPosition =
        Prefixed_Name(odrl, "absoluteSpatialPosition") |> PrefixedName

    /// <summary>
    ///   <para>odrl:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Product Context</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/product">http://www.w3.org/ns/odrl/2/product</seealso>
    let product = Prefixed_Name(odrl, "product") |> PrefixedName
    /// <summary>
    ///   <para>odrl:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/count">http://www.w3.org/ns/odrl/2/count</seealso>
    let count = Prefixed_Name(odrl, "count") |> PrefixedName
    /// <summary>
    ///   <para>odrl:ConflictTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Conflict Strategy Preference</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/ConflictTerm">http://www.w3.org/ns/odrl/2/ConflictTerm</seealso>
    let ConflictTerm = Prefixed_Name(odrl, "ConflictTerm") |> PrefixedName
    /// <summary>
    ///   <para>odrl:systemDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>System Device</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/systemDevice">http://www.w3.org/ns/odrl/2/systemDevice</seealso>
    let systemDevice = Prefixed_Name(odrl, "systemDevice") |> PrefixedName
    /// <summary>
    ///   <para>odrl:virtualLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Virtual IT Communication Location</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/virtualLocation">http://www.w3.org/ns/odrl/2/virtualLocation</seealso>
    let virtualLocation = Prefixed_Name(odrl, "virtualLocation") |> PrefixedName
    /// <summary>
    ///   <para>odrl:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/language">http://www.w3.org/ns/odrl/2/language</seealso>
    let language = Prefixed_Name(odrl, "language") |> PrefixedName
    /// <summary>
    ///   <para>odrl:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Version</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/version">http://www.w3.org/ns/odrl/2/version</seealso>
    let version = Prefixed_Name(odrl, "version") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#constraintLogicalOperands</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#constraintLogicalOperands">http://www.w3.org/ns/odrl/2/#constraintLogicalOperands</seealso>
    let ``_#constraintLogicalOperands`` =
        Prefixed_Name(odrl, "#constraintLogicalOperands") |> PrefixedName

    /// <summary>
    ///   <para>odrl:timeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Recurring Time Interval</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/timeInterval">http://www.w3.org/ns/odrl/2/timeInterval</seealso>
    let timeInterval = Prefixed_Name(odrl, "timeInterval") |> PrefixedName
    /// <summary>
    ///   <para>odrl:deliveryChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Delivery Channel</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/deliveryChannel">http://www.w3.org/ns/odrl/2/deliveryChannel</seealso>
    let deliveryChannel = Prefixed_Name(odrl, "deliveryChannel") |> PrefixedName

    /// <summary>
    ///   <para>odrl:relativeSpatialPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Relative Spatial Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/relativeSpatialPosition">http://www.w3.org/ns/odrl/2/relativeSpatialPosition</seealso>
    let relativeSpatialPosition =
        Prefixed_Name(odrl, "relativeSpatialPosition") |> PrefixedName

    /// <summary>
    ///   <para>odrl:unitOfCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Unit Of Count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/unitOfCount">http://www.w3.org/ns/odrl/2/unitOfCount</seealso>
    let unitOfCount = Prefixed_Name(odrl, "unitOfCount") |> PrefixedName
    /// <summary>
    ///   <para>odrl:elapsedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Elapsed Time</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/elapsedTime">http://www.w3.org/ns/odrl/2/elapsedTime</seealso>
    let elapsedTime = Prefixed_Name(odrl, "elapsedTime") |> PrefixedName
    /// <summary>
    ///   <para>odrl:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/event">http://www.w3.org/ns/odrl/2/event</seealso>
    let event_ = Prefixed_Name(odrl, "event") |> PrefixedName
    /// <summary>
    ///   <para>odrl:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Geospatial Named Area</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/spatial">http://www.w3.org/ns/odrl/2/spatial</seealso>
    let spatial = Prefixed_Name(odrl, "spatial") |> PrefixedName
    /// <summary>
    ///   <para>odrl:relativeSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Relative Asset Size</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/relativeSize">http://www.w3.org/ns/odrl/2/relativeSize</seealso>
    let relativeSize = Prefixed_Name(odrl, "relativeSize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Industry Context</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/industry">http://www.w3.org/ns/odrl/2/industry</seealso>
    let industry = Prefixed_Name(odrl, "industry") |> PrefixedName

    /// <summary>
    ///   <para>odrl:absoluteTemporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Absolute Temporal Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/absoluteTemporalPosition">http://www.w3.org/ns/odrl/2/absoluteTemporalPosition</seealso>
    let absoluteTemporalPosition =
        Prefixed_Name(odrl, "absoluteTemporalPosition") |> PrefixedName

    /// <summary>
    ///   <para>odrl:and</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>And</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/and">http://www.w3.org/ns/odrl/2/and</seealso>
    let and_ = Prefixed_Name(odrl, "and") |> PrefixedName
    /// <summary>
    ///   <para>odrl:or</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Or</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/or">http://www.w3.org/ns/odrl/2/or</seealso>
    let or_ = Prefixed_Name(odrl, "or") |> PrefixedName
    /// <summary>
    ///   <para>odrl:isA</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:Operator</para>
    ///
    /// labels<para>Is a</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/isA">http://www.w3.org/ns/odrl/2/isA</seealso>
    let isA = Prefixed_Name(odrl, "isA") |> PrefixedName
    /// <summary>
    ///   <para>odrl:lt</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Less than</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/lt">http://www.w3.org/ns/odrl/2/lt</seealso>
    let lt = Prefixed_Name(odrl, "lt") |> PrefixedName
    /// <summary>
    ///   <para>odrl:lteq</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Less than or equal to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/lteq">http://www.w3.org/ns/odrl/2/lteq</seealso>
    let lteq = Prefixed_Name(odrl, "lteq") |> PrefixedName
    /// <summary>
    ///   <para>odrl:isAllOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Operator</para>
    ///
    /// labels<para>Is all of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/isAllOf">http://www.w3.org/ns/odrl/2/isAllOf</seealso>
    let isAllOf = Prefixed_Name(odrl, "isAllOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:isAnyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Operator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Is any of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/isAnyOf">http://www.w3.org/ns/odrl/2/isAnyOf</seealso>
    let isAnyOf = Prefixed_Name(odrl, "isAnyOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:absolutePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Absolute Asset Position</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/absolutePosition">http://www.w3.org/ns/odrl/2/absolutePosition</seealso>
    let absolutePosition = Prefixed_Name(odrl, "absolutePosition") |> PrefixedName
    /// <summary>
    ///   <para>odrl:media</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:LeftOperand</para>
    ///
    /// labels<para>Media Context</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/media">http://www.w3.org/ns/odrl/2/media</seealso>
    let media = Prefixed_Name(odrl, "media") |> PrefixedName
    /// <summary>
    ///   <para>odrl:delayPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Delay Period</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/delayPeriod">http://www.w3.org/ns/odrl/2/delayPeriod</seealso>
    let delayPeriod = Prefixed_Name(odrl, "delayPeriod") |> PrefixedName
    /// <summary>
    ///   <para>odrl:andSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>And Sequence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/andSequence">http://www.w3.org/ns/odrl/2/andSequence</seealso>
    let andSequence = Prefixed_Name(odrl, "andSequence") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#constraintRelationalOperators</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#constraintRelationalOperators">http://www.w3.org/ns/odrl/2/#constraintRelationalOperators</seealso>
    let ``_#constraintRelationalOperators`` =
        Prefixed_Name(odrl, "#constraintRelationalOperators") |> PrefixedName

    /// <summary>
    ///   <para>odrl:eq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Equal to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/eq">http://www.w3.org/ns/odrl/2/eq</seealso>
    let eq = Prefixed_Name(odrl, "eq") |> PrefixedName
    /// <summary>
    ///   <para>odrl:neq</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:Operator</para>
    ///
    /// labels<para>Not equal to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/neq">http://www.w3.org/ns/odrl/2/neq</seealso>
    let neq = Prefixed_Name(odrl, "neq") |> PrefixedName
    /// <summary>
    ///   <para>odrl:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Has part</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/hasPart">http://www.w3.org/ns/odrl/2/hasPart</seealso>
    let hasPart = Prefixed_Name(odrl, "hasPart") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#constraintRightOpCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#constraintRightOpCommon">http://www.w3.org/ns/odrl/2/#constraintRightOpCommon</seealso>
    let ``_#constraintRightOpCommon`` =
        Prefixed_Name(odrl, "#constraintRightOpCommon") |> PrefixedName

    /// <summary>
    ///   <para>odrl:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/unit">http://www.w3.org/ns/odrl/2/unit</seealso>
    let unit = Prefixed_Name(odrl, "unit") |> PrefixedName
    /// <summary>
    ///   <para>odrl:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Status</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/status">http://www.w3.org/ns/odrl/2/status</seealso>
    let status = Prefixed_Name(odrl, "status") |> PrefixedName
    /// <summary>
    ///   <para>odrl:dataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Datatype</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/dataType">http://www.w3.org/ns/odrl/2/dataType</seealso>
    let dataType = Prefixed_Name(odrl, "dataType") |> PrefixedName
    /// <summary>
    ///   <para>odrl:shareAlike</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Share-alike</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/shareAlike">http://www.w3.org/ns/odrl/2/shareAlike</seealso>
    let shareAlike = Prefixed_Name(odrl, "shareAlike") |> PrefixedName
    /// <summary>
    ///   <para>odrl:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Scope</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/scope">http://www.w3.org/ns/odrl/2/scope</seealso>
    let scope = Prefixed_Name(odrl, "scope") |> PrefixedName
    /// <summary>
    ///   <para>odrl:payeeParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Payee Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/payeeParty">http://www.w3.org/ns/odrl/2/payeeParty</seealso>
    let payeeParty = Prefixed_Name(odrl, "payeeParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:timedCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Timed Count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/timedCount">http://www.w3.org/ns/odrl/2/timedCount</seealso>
    let timedCount = Prefixed_Name(odrl, "timedCount") |> PrefixedName
    /// <summary>
    ///   <para>odrl:lease</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Lease</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/lease">http://www.w3.org/ns/odrl/2/lease</seealso>
    let lease = Prefixed_Name(odrl, "lease") |> PrefixedName
    /// <summary>
    ///   <para>odrl:inheritAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Inheritance Allowed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/inheritAllowed">http://www.w3.org/ns/odrl/2/inheritAllowed</seealso>
    let inheritAllowed = Prefixed_Name(odrl, "inheritAllowed") |> PrefixedName
    /// <summary>
    ///   <para>odrl:proximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>proximity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/proximity">http://www.w3.org/ns/odrl/2/proximity</seealso>
    let proximity = Prefixed_Name(odrl, "proximity") |> PrefixedName
    /// <summary>
    ///   <para>odrl:export</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Export</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/export">http://www.w3.org/ns/odrl/2/export</seealso>
    let export = Prefixed_Name(odrl, "export") |> PrefixedName
    /// <summary>
    ///   <para>odrl:attachPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Attach policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/attachPolicy">http://www.w3.org/ns/odrl/2/attachPolicy</seealso>
    let attachPolicy = Prefixed_Name(odrl, "attachPolicy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:AllGroups</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:PartyScope</para>
    ///
    /// labels<para>All Group Connections</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/AllGroups">http://www.w3.org/ns/odrl/2/AllGroups</seealso>
    let AllGroups = Prefixed_Name(odrl, "AllGroups") |> PrefixedName
    /// <summary>
    ///   <para>odrl:UndefinedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Undefined Term</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/UndefinedTerm">http://www.w3.org/ns/odrl/2/UndefinedTerm</seealso>
    let UndefinedTerm = Prefixed_Name(odrl, "UndefinedTerm") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#partyRoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#partyRoles">http://www.w3.org/ns/odrl/2/#partyRoles</seealso>
    let ``_#partyRoles`` = Prefixed_Name(odrl, "#partyRoles") |> PrefixedName
    /// <summary>
    ///   <para>odrl:informedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Informed Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/informedParty">http://www.w3.org/ns/odrl/2/informedParty</seealso>
    let informedParty = Prefixed_Name(odrl, "informedParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:trackingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Tracking Party</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/trackingParty">http://www.w3.org/ns/odrl/2/trackingParty</seealso>
    let trackingParty = Prefixed_Name(odrl, "trackingParty") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#permissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#permissions">http://www.w3.org/ns/odrl/2/#permissions</seealso>
    let ``_#permissions`` = Prefixed_Name(odrl, "#permissions") |> PrefixedName
    /// <summary>
    ///   <para>odrl:permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Permission</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/permission">http://www.w3.org/ns/odrl/2/permission</seealso>
    let permission = Prefixed_Name(odrl, "permission") |> PrefixedName

    /// <summary>
    ///   <para>odrl:#policySubClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#policySubClasses">http://www.w3.org/ns/odrl/2/#policySubClasses</seealso>
    let ``_#policySubClasses`` =
        Prefixed_Name(odrl, "#policySubClasses") |> PrefixedName

    /// <summary>
    ///   <para>odrl:Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Set</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Set">http://www.w3.org/ns/odrl/2/Set</seealso>
    let Set = Prefixed_Name(odrl, "Set") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Privacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Privacy Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Privacy">http://www.w3.org/ns/odrl/2/Privacy</seealso>
    let Privacy = Prefixed_Name(odrl, "Privacy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Assertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Assertion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Assertion">http://www.w3.org/ns/odrl/2/Assertion</seealso>
    let Assertion = Prefixed_Name(odrl, "Assertion") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#prohibitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#prohibitions">http://www.w3.org/ns/odrl/2/#prohibitions</seealso>
    let ``_#prohibitions`` = Prefixed_Name(odrl, "#prohibitions") |> PrefixedName
    /// <summary>
    ///   <para>odrl:prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Prohibition</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/prohibition">http://www.w3.org/ns/odrl/2/prohibition</seealso>
    let prohibition = Prefixed_Name(odrl, "prohibition") |> PrefixedName
    /// <summary>
    ///   <para>odrl:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Operator</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Is part of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/isPartOf">http://www.w3.org/ns/odrl/2/isPartOf</seealso>
    let isPartOf = Prefixed_Name(odrl, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>odrl:policyUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:RightOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Policy Rule Usage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/policyUsage">http://www.w3.org/ns/odrl/2/policyUsage</seealso>
    let policyUsage = Prefixed_Name(odrl, "policyUsage") |> PrefixedName
    /// <summary>
    ///   <para>odrl:rightOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Has Right Operand</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/rightOperand">http://www.w3.org/ns/odrl/2/rightOperand</seealso>
    let rightOperand = Prefixed_Name(odrl, "rightOperand") |> PrefixedName
    /// <summary>
    ///   <para>odrl:leftOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Has Left Operand</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/leftOperand">http://www.w3.org/ns/odrl/2/leftOperand</seealso>
    let leftOperand = Prefixed_Name(odrl, "leftOperand") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Operator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Operator">http://www.w3.org/ns/odrl/2/Operator</seealso>
    let Operator = Prefixed_Name(odrl, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>odrl:LeftOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Left Operand</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/LeftOperand">http://www.w3.org/ns/odrl/2/LeftOperand</seealso>
    let LeftOperand = Prefixed_Name(odrl, "LeftOperand") |> PrefixedName
    /// <summary>
    ///   <para>odrl:operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Has Operator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/operator">http://www.w3.org/ns/odrl/2/operator</seealso>
    let operator = Prefixed_Name(odrl, "operator") |> PrefixedName
    /// <summary>
    ///   <para>odrl:#deprecatedTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/#deprecatedTerms">http://www.w3.org/ns/odrl/2/#deprecatedTerms</seealso>
    let ``_#deprecatedTerms`` = Prefixed_Name(odrl, "#deprecatedTerms") |> PrefixedName
    /// <summary>
    ///   <para>odrl:PartyScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Party Scope</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/PartyScope">http://www.w3.org/ns/odrl/2/PartyScope</seealso>
    let PartyScope = Prefixed_Name(odrl, "PartyScope") |> PrefixedName
    /// <summary>
    ///   <para>odrl:pay</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Pay</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/pay">http://www.w3.org/ns/odrl/2/pay</seealso>
    let pay = Prefixed_Name(odrl, "pay") |> PrefixedName
    /// <summary>
    ///   <para>odrl:copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Copy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/copy">http://www.w3.org/ns/odrl/2/copy</seealso>
    let copy = Prefixed_Name(odrl, "copy") |> PrefixedName
    /// <summary>
    ///   <para>odrl:AssetScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Asset Scope</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/AssetScope">http://www.w3.org/ns/odrl/2/AssetScope</seealso>
    let AssetScope = Prefixed_Name(odrl, "AssetScope") |> PrefixedName
    /// <summary>
    ///   <para>odrl:commercialize</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Commercialize</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/commercialize">http://www.w3.org/ns/odrl/2/commercialize</seealso>
    let commercialize = Prefixed_Name(odrl, "commercialize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>odrl:PartyScope</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Individual</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Individual">http://www.w3.org/ns/odrl/2/Individual</seealso>
    let Individual = Prefixed_Name(odrl, "Individual") |> PrefixedName
    /// <summary>
    ///   <para>odrl:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/Action">http://www.w3.org/ns/odrl/2/Action</seealso>
    let Action = Prefixed_Name(odrl, "Action") |> PrefixedName
    /// <summary>
    ///   <para>odrl:watermark</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Watermark</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/watermark">http://www.w3.org/ns/odrl/2/watermark</seealso>
    let watermark = Prefixed_Name(odrl, "watermark") |> PrefixedName
    /// <summary>
    ///   <para>odrl:move</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Move</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/move">http://www.w3.org/ns/odrl/2/move</seealso>
    let move = Prefixed_Name(odrl, "move") |> PrefixedName
    /// <summary>
    ///   <para>odrl:digitize</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Digitize</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/digitize">http://www.w3.org/ns/odrl/2/digitize</seealso>
    let digitize = Prefixed_Name(odrl, "digitize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:distribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Distribute</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/distribute">http://www.w3.org/ns/odrl/2/distribute</seealso>
    let distribute = Prefixed_Name(odrl, "distribute") |> PrefixedName
    /// <summary>
    ///   <para>odrl:anonymize</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Anonymize</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/anonymize">http://www.w3.org/ns/odrl/2/anonymize</seealso>
    let anonymize = Prefixed_Name(odrl, "anonymize") |> PrefixedName
    /// <summary>
    ///   <para>odrl:textToSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Text-to-speech</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/textToSpeech">http://www.w3.org/ns/odrl/2/textToSpeech</seealso>
    let textToSpeech = Prefixed_Name(odrl, "textToSpeech") |> PrefixedName
    /// <summary>
    ///   <para>odrl:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>odrl:Action</para>
    ///
    /// labels<para>Index</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/index">http://www.w3.org/ns/odrl/2/index</seealso>
    let index = Prefixed_Name(odrl, "index") |> PrefixedName
    /// <summary>
    ///   <para>odrl:give</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:Action</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Give</para></remarks>
    /// <seealso href="http://www.w3.org/ns/odrl/2/give">http://www.w3.org/ns/odrl/2/give</seealso>
    let give = Prefixed_Name(odrl, "give") |> PrefixedName

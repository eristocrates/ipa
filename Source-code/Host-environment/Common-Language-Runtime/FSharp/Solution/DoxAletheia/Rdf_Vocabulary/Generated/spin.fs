namespace http.spinrdf.org.spin.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spin =
    let _namespace_iri = Namespace_Iri spin |> NamespaceIRI
    /// <summary>
    ///   <para>spin:AskTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Attribute</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A SPIN template that wraps an ASK query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The ASK query wrapped by this template."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ask template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#AskTemplate">http://spinrdf.org/spin#AskTemplate</seealso>
    let AskTemplate = Prefixed_Name(spin, "AskTemplate") |> PrefixedName
    /// <summary>
    ///   <para>spin:AskTemplates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:AskTemplate</para>
    ///   <para>"Suggested abstract base class for all AskTemplates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ask templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#AskTemplates">http://spinrdf.org/spin#AskTemplates</seealso>
    let AskTemplates = Prefixed_Name(spin, "AskTemplates") |> PrefixedName
    /// <summary>
    ///   <para>spin:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Provides metadata about a column in the result set of a (SPARQL) query, for example of the body queries of SPIN templates. Columns can define human-readable labels that serve as column titles, using rdfs:label."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Column">http://spinrdf.org/spin#Column</seealso>
    let Column = Prefixed_Name(spin, "Column") |> PrefixedName
    /// <summary>
    ///   <para>spin:ConstraintViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An object that can be created by spin:constraints to provide information about a constraint violation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constraint violation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#ConstraintViolation">http://spinrdf.org/spin#ConstraintViolation</seealso>
    let ConstraintViolation = Prefixed_Name(spin, "ConstraintViolation") |> PrefixedName

    /// <summary>
    ///   <para>spin:ConstraintViolationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The type of the supported levels of constraint violations, including spin:Error and spin:Warning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constraint violation level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#ConstraintViolationLevel">http://spinrdf.org/spin#ConstraintViolationLevel</seealso>
    let ConstraintViolationLevel =
        Prefixed_Name(spin, "ConstraintViolationLevel") |> PrefixedName

    /// <summary>
    ///   <para>spin:ConstructTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Attribute</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The CONSTRUCT query wrapped by this template."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Construct template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#ConstructTemplate">http://spinrdf.org/spin#ConstructTemplate</seealso>
    let ConstructTemplate = Prefixed_Name(spin, "ConstructTemplate") |> PrefixedName
    /// <summary>
    ///   <para>spin:ConstructTemplates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:ConstructTemplate</para>
    ///   <para>"Suggested abstract base class for all ConstructTemplates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Construct templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#ConstructTemplates">http://spinrdf.org/spin#ConstructTemplates</seealso>
    let ConstructTemplates = Prefixed_Name(spin, "ConstructTemplates") |> PrefixedName
    /// <summary>
    ///   <para>spin:Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:ConstraintViolationLevel</para>
    ///   <para>"Indicates that the associated constraint violation is an error that should be fixed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Error">http://spinrdf.org/spin#Error</seealso>
    let Error = Prefixed_Name(spin, "Error") |> PrefixedName
    /// <summary>
    ///   <para>spin:Fatal</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:ConstraintViolationLevel</para>
    ///   <para>"Indicates that the associated constraint violation is a severe error that must be fixed. Constraint checking engines may decide to stop further evaluation once a fatal error has been detected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fatal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Fatal">http://spinrdf.org/spin#Fatal</seealso>
    let Fatal = Prefixed_Name(spin, "Fatal") |> PrefixedName
    /// <summary>
    ///   <para>spin:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>spl:Attribute</para>
    ///   <para>"Metaclass for functions that can be used in SPARQL expressions (e.g. FILTER or BIND). The function themselves are classes that are instances of this metaclass. Function calls are instances of the function classes, with property values for the arguments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"the body of the function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Function">http://spinrdf.org/spin#Function</seealso>
    let Function = Prefixed_Name(spin, "Function") |> PrefixedName
    /// <summary>
    ///   <para>spin:Functions</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Function</para>
    ///   <para>"An abstract base class for all defined functions. This class mainly serves as a shared root so that the various instances of the Function metaclass are grouped together."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Functions">http://spinrdf.org/spin#Functions</seealso>
    let Functions = Prefixed_Name(spin, "Functions") |> PrefixedName
    /// <summary>
    ///   <para>spin:Info</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:ConstraintViolationLevel</para>
    ///   <para>"Indicates that the associated constraint violation is a not a problem. This level can be used for diagnostic and debugging purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Info"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Info">http://spinrdf.org/spin#Info</seealso>
    let Info = Prefixed_Name(spin, "Info") |> PrefixedName
    /// <summary>
    ///   <para>spin:LibraryOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class that can be attached to base URIs (ontologies) to instruct SPIN engines that this ontology only contains a library of SPIN declarations. Library Ontologies should be ignored by SPIN inference engines even if they have been imported by a domain model. For example, a SPIN version of OWL RL may contain all the OWL RL axioms, attached to owl:Thing, but nothing else. However, when executed, these axioms should not be executed over themselves, because we don't want the system to reason about the SPIN triples to speed up things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Library ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#LibraryOntology">http://spinrdf.org/spin#LibraryOntology</seealso>
    let LibraryOntology = Prefixed_Name(spin, "LibraryOntology") |> PrefixedName
    /// <summary>
    ///   <para>spin:MagicProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:MagicProperty</para>
    ///   <para>"An abstract superclass that can be used to group all spin:MagicProperty instances under a single parent class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magic properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#MagicProperties">http://spinrdf.org/spin#MagicProperties</seealso>
    let MagicProperties = Prefixed_Name(spin, "MagicProperties") |> PrefixedName
    /// <summary>
    ///   <para>spin:MagicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Magic property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#MagicProperty">http://spinrdf.org/spin#MagicProperty</seealso>
    let MagicProperty = Prefixed_Name(spin, "MagicProperty") |> PrefixedName
    /// <summary>
    ///   <para>spin:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract building block of a SPARQL system. A Module can take Arguments as input and applies them on an input RDF Graph. The Arguments should be declared as spin:constraints."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Module">http://spinrdf.org/spin#Module</seealso>
    let Module = Prefixed_Name(spin, "Module") |> PrefixedName
    /// <summary>
    ///   <para>spin:Modules</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>spl:ConstructDefaultValues</para>
    ///   <para>"An "artificial" parent class for all Functions and Templates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Modules">http://spinrdf.org/spin#Modules</seealso>
    let Modules = Prefixed_Name(spin, "Modules") |> PrefixedName
    /// <summary>
    ///   <para>spin:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Groups together the kinds of SPARQL commands that can appear as SPIN rules and constructors: CONSTRUCT, DELETE WHERE and DELETE/INSERT. This class is never to be instantiated directly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Rule">http://spinrdf.org/spin#Rule</seealso>
    let Rule = Prefixed_Name(spin, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>spin:RuleProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The metaclass of spin:rule and its subproperties. spin:RuleProperties can have additional metadata attached to them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rule property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#RuleProperty">http://spinrdf.org/spin#RuleProperty</seealso>
    let RuleProperty = Prefixed_Name(spin, "RuleProperty") |> PrefixedName
    /// <summary>
    ///   <para>spin:SelectTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>spl:Attribute</para>
    ///   <para>"The SELECT query wrapped by this template."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A SPIN template that wraps a SELECT query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Select template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#SelectTemplate">http://spinrdf.org/spin#SelectTemplate</seealso>
    let SelectTemplate = Prefixed_Name(spin, "SelectTemplate") |> PrefixedName
    /// <summary>
    ///   <para>spin:SelectTemplates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:SelectTemplate</para>
    ///   <para>"Suggested abstract base class for all SelectTemplates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Select templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#SelectTemplates">http://spinrdf.org/spin#SelectTemplates</seealso>
    let SelectTemplates = Prefixed_Name(spin, "SelectTemplates") |> PrefixedName
    /// <summary>
    ///   <para>spin:TableDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstraction of objects that can produce tabular data. This serves as a base class of spin:SelectTemplate, because SELECT queries can produce tables with columns for each result variable. However, other types of TableDataProviders are conceivable by other frameworks, and this class may prove as a useful shared foundation.
    ///
    /// TableDataProviders can link to definitions of columns via spin:column, and these definitions can inform rendering engines."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Table data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#TableDataProvider">http://spinrdf.org/spin#TableDataProvider</seealso>
    let TableDataProvider = Prefixed_Name(spin, "TableDataProvider") |> PrefixedName
    /// <summary>
    ///   <para>spin:Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Attribute</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"the body of the Template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The metaclass of SPIN templates. Templates are classes that are instances of this class. A template represents a reusable SPARQL query or update request that can be parameterized with arguments. Templates can be instantiated in places where normally a SPARQL query or update request is used, in particular as spin:rules and spin:constraints."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Template">http://spinrdf.org/spin#Template</seealso>
    let Template = Prefixed_Name(spin, "Template") |> PrefixedName
    /// <summary>
    ///   <para>spin:Templates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Suggested abstract base class for all Templates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Templates">http://spinrdf.org/spin#Templates</seealso>
    let Templates = Prefixed_Name(spin, "Templates") |> PrefixedName
    /// <summary>
    ///   <para>spin:UpdateTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Attribute</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The UPDATE command wrapped by this template."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A SPIN template that has an UPDATE command as its body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Update template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#UpdateTemplate">http://spinrdf.org/spin#UpdateTemplate</seealso>
    let UpdateTemplate = Prefixed_Name(spin, "UpdateTemplate") |> PrefixedName
    /// <summary>
    ///   <para>spin:UpdateTemplates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:UpdateTemplate</para>
    ///   <para>"Suggested abstract base class for all UpdateTemplates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Update templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#UpdateTemplates">http://spinrdf.org/spin#UpdateTemplates</seealso>
    let UpdateTemplates = Prefixed_Name(spin, "UpdateTemplates") |> PrefixedName
    /// <summary>
    ///   <para>spin:Warning</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:ConstraintViolationLevel</para>
    ///   <para>"Indicates that the associated constraint violation is a problem that may not have to be fixed but may lead to issues in the future."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Warning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#Warning">http://spinrdf.org/spin#Warning</seealso>
    let Warning = Prefixed_Name(spin, "Warning") |> PrefixedName
    /// <summary>
    ///   <para>spin:_arg1</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/spin#_arg1">http://spinrdf.org/spin#_arg1</seealso>
    let _arg1 = Prefixed_Name(spin, "_arg1") |> PrefixedName
    /// <summary>
    ///   <para>spin:_arg2</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/spin#_arg2">http://spinrdf.org/spin#_arg2</seealso>
    let _arg2 = Prefixed_Name(spin, "_arg2") |> PrefixedName
    /// <summary>
    ///   <para>spin:_arg3</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/spin#_arg3">http://spinrdf.org/spin#_arg3</seealso>
    let _arg3 = Prefixed_Name(spin, "_arg3") |> PrefixedName
    /// <summary>
    ///   <para>spin:_arg4</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/spin#_arg4">http://spinrdf.org/spin#_arg4</seealso>
    let _arg4 = Prefixed_Name(spin, "_arg4") |> PrefixedName
    /// <summary>
    ///   <para>spin:_arg5</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/spin#_arg5">http://spinrdf.org/spin#_arg5</seealso>
    let _arg5 = Prefixed_Name(spin, "_arg5") |> PrefixedName
    /// <summary>
    ///   <para>spin:_this</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Variable</para>
    ///   <para>"A system variable representing the current context instance in a rule or constraint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"_this"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#_this">http://spinrdf.org/spin#_this</seealso>
    let _this = Prefixed_Name(spin, "_this") |> PrefixedName
    /// <summary>
    ///   <para>spin:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be set to true to indicate that this module shall not be instantiated. Abstract modules are only there to organize other modules into hierarchies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#abstract">http://spinrdf.org/spin#abstract</seealso>
    let abstract_ = Prefixed_Name(spin, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>spin:ask</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Function</para>
    ///   <para>"Executes a given ASK query and returns its boolean result. The first argument must point to an sp:Ask or a SPIN template call that has an ASK query as its body. All subsequent argument can come in pairs, with the first one being a variable name and the second its binding.
    ///
    /// Example:
    ///
    ///     BIND (spin:ask(?query, "this", owl:Thing) AS ?result) .
    ///
    /// will execute the sp:Ask behind ?query with the variable ?this pre-bound to owl:Thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#ask">http://spinrdf.org/spin#ask</seealso>
    let ask = Prefixed_Name(spin, "ask") |> PrefixedName
    /// <summary>
    ///   <para>spin:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The body of a Function or Template. This points to a Query instance. For Functions, this is limited to either ASK or SELECT type queries. If the body is the ASK function then the return value is xsd:boolean. Otherwise, the SELECT query must have a single return variable. The first binding of this SELECT query will be returned as result of the function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#body">http://spinrdf.org/spin#body</seealso>
    let body = Prefixed_Name(spin, "body") |> PrefixedName
    /// <summary>
    ///   <para>spin:cachable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be set to true to instruct the SPIN engine that it may cache the results of all calls to the associated function. Functions should only be marked as cachable if the same combination of input arguments always returns the same result. Functions that query a graph or other background data that may change over time should not be cached. Caching can significantly improve performance of frequently needed functions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cachable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#cachable">http://spinrdf.org/spin#cachable</seealso>
    let cachable = Prefixed_Name(spin, "cachable") |> PrefixedName
    /// <summary>
    ///   <para>spin:column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can link a TableDataProvider (esp. SelectTemplate) with one or more columns that provide metadata for rendering purposes. Columns can be sorted by their spin:columnIndex (which must align with the ordering of variables in the SELECT query starting with 0). Not all result variables of the underlying query need to have a matching spin:Column."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#column">http://spinrdf.org/spin#column</seealso>
    let column = Prefixed_Name(spin, "column") |> PrefixedName
    /// <summary>
    ///   <para>spin:columnIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The index of a column (from left to right) starting at 0."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"column index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#columnIndex">http://spinrdf.org/spin#columnIndex</seealso>
    let columnIndex = Prefixed_Name(spin, "columnIndex") |> PrefixedName
    /// <summary>
    ///   <para>spin:columnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The datatype or resource type of a spin:Column. For example this is useful as metadata to inform a rendering engine that numeric columns (e.g. xsd:float) need to be right-aligned."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"column type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#columnType">http://spinrdf.org/spin#columnType</seealso>
    let columnType = Prefixed_Name(spin, "columnType") |> PrefixedName
    /// <summary>
    ///   <para>spin:columnWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The preferred width of the associated Column, for display purposes. Values in pixels (rendering engines may multiply the values depending on resolution)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"column width"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#columnWidth">http://spinrdf.org/spin#columnWidth</seealso>
    let columnWidth = Prefixed_Name(spin, "columnWidth") |> PrefixedName
    /// <summary>
    ///   <para>spin:command</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to link a resource with a SPARQL query or update request (sp:Command)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#command">http://spinrdf.org/spin#command</seealso>
    let command = Prefixed_Name(spin, "command") |> PrefixedName
    /// <summary>
    ///   <para>spin:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a class with constraints on its instances. The values of this property are "axioms" expressed as CONSTRUCT or ASK queries where the variable ?this refers to the instances of the surrounding class. ASK queries must evaluate to false for each member of this class - returning true means that the instance ?this violates the constraint. CONSTRUCT queries must create instances of spin:ConstraintViolation to provide details on the reason for the violation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#constraint">http://spinrdf.org/spin#constraint</seealso>
    let constraint_ = Prefixed_Name(spin, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>spin:construct</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:MagicProperty</para>
    ///   <para>"Evaluates a given sp:Construct or SPIN template call (first argument on the left hand side) and binds the resulting triples to the variables on the right hand side.
    ///
    /// Example:
    ///
    ///     (?query "this" owl:Thing) spin:construct (?s ?p ?o)
    ///
    /// will execute the sp:Construct ?query using the binding of owl:Thing to ?this. The resulting triples will be bound to ?s, ?p and ?o. If any of ?s ?p ?o are bound, it will only return the matching triples."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"construct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#construct">http://spinrdf.org/spin#construct</seealso>
    let construct = Prefixed_Name(spin, "construct") |> PrefixedName
    /// <summary>
    ///   <para>spin:constructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to attach a "constructor" to a class. A constructor is a SPARQL CONSTRUCT query or INSERT/DELETE Update operation that can add initial values to the current instance. At execution time, the variable ?this is bound to the current instance. Tools can call constructors of a class and its superclasses when an instance of a class has been created. Constructors will also be used to initialize resources that have received a new rdf:type triple as a result of spin:rules firing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"constructor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#constructor">http://spinrdf.org/spin#constructor</seealso>
    let constructor = Prefixed_Name(spin, "constructor") |> PrefixedName
    /// <summary>
    ///   <para>spin:eval</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Function</para>
    ///   <para>"Evaluates a given SPIN expression or SELECT or ASK query, and returns its result. The first argument must be the expression in SPIN RDF syntax. All other arguments must come in pairs: first a property name, and then a value. These name/value pairs will be pre-bound variables for the execution of the expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"eval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#eval">http://spinrdf.org/spin#eval</seealso>
    let eval = Prefixed_Name(spin, "eval") |> PrefixedName
    /// <summary>
    ///   <para>spin:fix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to link a ConstraintViolation with one or more UPDATE Templates that would help fix the violation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#fix">http://spinrdf.org/spin#fix</seealso>
    let fix = Prefixed_Name(spin, "fix") |> PrefixedName
    /// <summary>
    ///   <para>spin:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>"Can be used to link an RDF graph (usually the instance of owl:Ontology) with a SPIN library to define constraints. SPIN-aware tools should include the definitions from those libraries for constraint checking. Using such libraries is a simpler alternative than explicitly importing them using owl:imports, because it does not force all the SPIN triples into the RDF model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#imports">http://spinrdf.org/spin#imports</seealso>
    let imports = Prefixed_Name(spin, "imports") |> PrefixedName
    /// <summary>
    ///   <para>spin:labelTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A template string for displaying instantiations of a module in human-readable form. The template may contain the argument variable names in curly braces to support substitution. For example, "The number of values of the {?arg1} property.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#labelTemplate">http://spinrdf.org/spin#labelTemplate</seealso>
    let labelTemplate = Prefixed_Name(spin, "labelTemplate") |> PrefixedName
    /// <summary>
    ///   <para>spin:nextRuleProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to link two sub-properties of spin:rule (or spin:rule itself) to instruct the SPIN engine to execute one set of rules before another one. The values of the subject property will be executed before those of the object property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"next rule property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#nextRuleProperty">http://spinrdf.org/spin#nextRuleProperty</seealso>
    let nextRuleProperty = Prefixed_Name(spin, "nextRuleProperty") |> PrefixedName
    /// <summary>
    ///   <para>spin:private</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be set to true to indicate that a SPIN function or template is only meant to be used as a helper of other modules, but not directly. Among others, this allows user interfaces to filter out private modules. Furthermore, it tells potential users of this module that they should avoid using this module, as it may not be stable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"private"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#private">http://spinrdf.org/spin#private</seealso>
    let private_ = Prefixed_Name(spin, "private") |> PrefixedName
    /// <summary>
    ///   <para>spin:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to point from any resource to a Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#query">http://spinrdf.org/spin#query</seealso>
    let query = Prefixed_Name(spin, "query") |> PrefixedName
    /// <summary>
    ///   <para>spin:returnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The return type of a Function, e.g. xsd:string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"return type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#returnType">http://spinrdf.org/spin#returnType</seealso>
    let returnType = Prefixed_Name(spin, "returnType") |> PrefixedName
    /// <summary>
    ///   <para>spin:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:RuleProperty</para>
    ///   <para>"An inferencing rule attached to a class. Rules are expressed as CONSTRUCT queries or INSERT/DELETE operations where the variable ?this will be bound to the current instance of the class. These inferences can be used to derive new values from existing values at the instance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#rule">http://spinrdf.org/spin#rule</seealso>
    let rule = Prefixed_Name(spin, "rule") |> PrefixedName

    /// <summary>
    ///   <para>spin:rulePropertyMaxIterationCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be attached to spin:rule (or subclasses thereof) to instruct a SPIN rules engine that it shall only execute the rules max times. If no value is specified, then the rules will be executed with no specific limit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rule property max iteration count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#rulePropertyMaxIterationCount">http://spinrdf.org/spin#rulePropertyMaxIterationCount</seealso>
    let rulePropertyMaxIterationCount =
        Prefixed_Name(spin, "rulePropertyMaxIterationCount") |> PrefixedName

    /// <summary>
    ///   <para>spin:select</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:MagicProperty</para>
    ///   <para>"Executes a given SELECT or ASK query (or a corresponding SPIN template call) and binds its result rows to the variables specified on the right hand side. May also pre-bind variables for the query execution, using name-value pairs on the left hand side.
    ///
    /// Example:
    ///
    ///     (?query "this" owl:Thing) spin:select (?a ?b)
    ///
    /// will execute the sp:Select or sp:Ask that ?query points to and pre-bind ?this with the value of owl:Thing for the execution of the query. The first result variable of the query's result set will be bound to ?a, the second to ?b etc. If the nodes on the right are bound (or constants) then it will match with the values from the result set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"select"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#select">http://spinrdf.org/spin#select</seealso>
    let select = Prefixed_Name(spin, "select") |> PrefixedName
    /// <summary>
    ///   <para>spin:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The symbol of a function, e.g. "=" for the eq function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#symbol">http://spinrdf.org/spin#symbol</seealso>
    let symbol = Prefixed_Name(spin, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>spin:systemProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An "abstract" base property that groups together those system properties that the user will hardly ever need to see in property trees. This property may be dropped in future versions of this ontology - right now it's mainly here for convenience."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"system property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#systemProperty">http://spinrdf.org/spin#systemProperty</seealso>
    let systemProperty = Prefixed_Name(spin, "systemProperty") |> PrefixedName
    /// <summary>
    ///   <para>spin:thisUnbound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be set to true for SPIN rules and constraints that do not require pre-binding the variable ?this with all members of the associated class. This flag should only be set to true if the WHERE clause is sufficiently strong to only bind instances of the associated class, or its subclasses. In those cases, the engine can greatly improve performance of query execution, because it does not need to add clauses to narrow down the WHERE clause."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"this unbound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#thisUnbound">http://spinrdf.org/spin#thisUnbound</seealso>
    let thisUnbound = Prefixed_Name(spin, "thisUnbound") |> PrefixedName
    /// <summary>
    ///   <para>spin:update</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to point from any resource to an Update."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"update"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#update">http://spinrdf.org/spin#update</seealso>
    let update = Prefixed_Name(spin, "update") |> PrefixedName
    /// <summary>
    ///   <para>spin:violationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An optional attribute of ConstraintViolations to point at a violation level (such as Error and Warning). Defaults to spin:Error."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"violation level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#violationLevel">http://spinrdf.org/spin#violationLevel</seealso>
    let violationLevel = Prefixed_Name(spin, "violationLevel") |> PrefixedName
    /// <summary>
    ///   <para>spin:violationPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An optional attribute of ConstraintViolations to provide a path expression from the root resource to the value that is invalid. If this is a URI then the path represents the predicate of a subject/predicate combination. Otherwise it should be a blank node of type sp:Path."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"violation path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#violationPath">http://spinrdf.org/spin#violationPath</seealso>
    let violationPath = Prefixed_Name(spin, "violationPath") |> PrefixedName
    /// <summary>
    ///   <para>spin:violationRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The root resource of the violation (often ?this in the constraint body)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"violation root"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#violationRoot">http://spinrdf.org/spin#violationRoot</seealso>
    let violationRoot = Prefixed_Name(spin, "violationRoot") |> PrefixedName
    /// <summary>
    ///   <para>spin:violationSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to link a spin:ConstraintViolation with the query or template call that caused it. This property is typically filled in automatically by the constraint checking engine and does not need to be set manually. However, it can be useful to learn more about the origin of a violation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"violation source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#violationSource">http://spinrdf.org/spin#violationSource</seealso>
    let violationSource = Prefixed_Name(spin, "violationSource") |> PrefixedName
    /// <summary>
    ///   <para>spin:violationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An optional attribute of ConstraintViolations to point at a specific RDF node that caused the violation. Should be accessible from the root via the violationPath."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"violation value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/spin#violationValue">http://spinrdf.org/spin#violationValue</seealso>
    let violationValue = Prefixed_Name(spin, "violationValue") |> PrefixedName

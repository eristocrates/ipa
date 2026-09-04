#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spin =
    let _prefixId = PrefixId.fromNamespaceLabel "http://spinrdf.org/spin#" "spin"
    /// <summary>
    ///   <para>rdfs:comment : A SPIN template that wraps an ASK query.^^xsd:string</para>
    ///   <para>rdfs:label : Ask template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#AskTemplate">spin:AskTemplate</a>
    /// </summary>
    let AskTemplate = _prefixId.prefix "AskTemplate"
    let AskTemplates = _prefixId.prefix "AskTemplates"
    /// <summary>
    ///   <para>rdfs:comment : Provides metadata about a column in the result set of a (SPARQL) query, for example of the body queries of SPIN templates. Columns can define human-readable labels that serve as column titles, using rdfs:label.^^xsd:string</para>
    ///   <para>rdfs:label : Column^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Column">spin:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:comment : An object that can be created by spin:constraints to provide information about a constraint violation.^^xsd:string</para>
    ///   <para>rdfs:label : Constraint violation^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#ConstraintViolation">spin:ConstraintViolation</a>
    /// </summary>
    let ConstraintViolation = _prefixId.prefix "ConstraintViolation"
    /// <summary>
    ///   <para>rdfs:comment : The type of the supported levels of constraint violations, including spin:Error and spin:Warning.^^xsd:string</para>
    ///   <para>rdfs:label : Constraint violation level^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#ConstraintViolationLevel">spin:ConstraintViolationLevel</a>
    /// </summary>
    let ConstraintViolationLevel = _prefixId.prefix "ConstraintViolationLevel"
    /// <summary>
    ///   <para>rdfs:label : Construct template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#ConstructTemplate">spin:ConstructTemplate</a>
    /// </summary>
    let ConstructTemplate = _prefixId.prefix "ConstructTemplate"
    let ConstructTemplates = _prefixId.prefix "ConstructTemplates"
    let Error = _prefixId.prefix "Error"
    let Fatal = _prefixId.prefix "Fatal"
    /// <summary>
    ///   <para>rdfs:comment : Metaclass for functions that can be used in SPARQL expressions (e.g. FILTER or BIND). The function themselves are classes that are instances of this metaclass. Function calls are instances of the function classes, with property values for the arguments.^^xsd:string</para>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Function">spin:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    let Functions = _prefixId.prefix "Functions"
    let Info = _prefixId.prefix "Info"
    /// <summary>
    ///   <para>rdfs:comment : A marker class that can be attached to base URIs (ontologies) to instruct SPIN engines that this ontology only contains a library of SPIN declarations. Library Ontologies should be ignored by SPIN inference engines even if they have been imported by a domain model. For example, a SPIN version of OWL RL may contain all the OWL RL axioms, attached to owl:Thing, but nothing else. However, when executed, these axioms should not be executed over themselves, because we don't want the system to reason about the SPIN triples to speed up things.^^xsd:string</para>
    ///   <para>rdfs:label : Library ontology^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#LibraryOntology">spin:LibraryOntology</a>
    /// </summary>
    let LibraryOntology = _prefixId.prefix "LibraryOntology"
    let MagicProperties = _prefixId.prefix "MagicProperties"
    /// <summary>
    ///   <para>rdfs:label : Magic property^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#MagicProperty">spin:MagicProperty</a>
    /// </summary>
    let MagicProperty = _prefixId.prefix "MagicProperty"
    /// <summary>
    ///   <para>rdfs:comment : An abstract building block of a SPARQL system. A Module can take Arguments as input and applies them on an input RDF Graph. The Arguments should be declared as spin:constraints.^^xsd:string</para>
    ///   <para>rdfs:label : Module^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Module">spin:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    /// <summary>
    ///   <para>rdfs:comment : An "artificial" parent class for all Functions and Templates.^^xsd:string</para>
    ///   <para>rdfs:label : Modules^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Modules">spin:Modules</a>
    /// </summary>
    let Modules = _prefixId.prefix "Modules"
    /// <summary>
    ///   <para>rdfs:comment : Groups together the kinds of SPARQL commands that can appear as SPIN rules and constructors: CONSTRUCT, DELETE WHERE and DELETE/INSERT. This class is never to be instantiated directly.^^xsd:string</para>
    ///   <para>rdfs:label : Rule^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Rule">spin:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:comment : The metaclass of spin:rule and its subproperties. spin:RuleProperties can have additional metadata attached to them.^^xsd:string</para>
    ///   <para>rdfs:label : Rule property^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#RuleProperty">spin:RuleProperty</a>
    /// </summary>
    let RuleProperty = _prefixId.prefix "RuleProperty"
    /// <summary>
    ///   <para>rdfs:comment : A SPIN template that wraps a SELECT query.^^xsd:string</para>
    ///   <para>rdfs:label : Select template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#SelectTemplate">spin:SelectTemplate</a>
    /// </summary>
    let SelectTemplate = _prefixId.prefix "SelectTemplate"
    let SelectTemplates = _prefixId.prefix "SelectTemplates"
    /// <summary>
    ///   <para>rdfs:comment : An abstraction of objects that can produce tabular data. This serves as a base class of spin:SelectTemplate, because SELECT queries can produce tables with columns for each result variable. However, other types of TableDataProviders are conceivable by other frameworks, and this class may prove as a useful shared foundation.
    ///
    /// TableDataProviders can link to definitions of columns via spin:column, and these definitions can inform rendering engines.^^xsd:string</para>
    ///   <para>rdfs:label : Table data provider^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#TableDataProvider">spin:TableDataProvider</a>
    /// </summary>
    let TableDataProvider = _prefixId.prefix "TableDataProvider"
    /// <summary>
    ///   <para>rdfs:comment : The metaclass of SPIN templates. Templates are classes that are instances of this class. A template represents a reusable SPARQL query or update request that can be parameterized with arguments. Templates can be instantiated in places where normally a SPARQL query or update request is used, in particular as spin:rules and spin:constraints.^^xsd:string</para>
    ///   <para>rdfs:label : Template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#Template">spin:Template</a>
    /// </summary>
    let Template = _prefixId.prefix "Template"
    let Templates = _prefixId.prefix "Templates"
    /// <summary>
    ///   <para>rdfs:comment : A SPIN template that has an UPDATE command as its body.^^xsd:string</para>
    ///   <para>rdfs:label : Update template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#UpdateTemplate">spin:UpdateTemplate</a>
    /// </summary>
    let UpdateTemplate = _prefixId.prefix "UpdateTemplate"
    let UpdateTemplates = _prefixId.prefix "UpdateTemplates"
    let Warning = _prefixId.prefix "Warning"
    let _arg1 = _prefixId.prefix "_arg1"
    let _arg2 = _prefixId.prefix "_arg2"
    let _arg3 = _prefixId.prefix "_arg3"
    let _arg4 = _prefixId.prefix "_arg4"
    let _arg5 = _prefixId.prefix "_arg5"
    let _this = _prefixId.prefix "_this"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true to indicate that this module shall not be instantiated. Abstract modules are only there to organize other modules into hierarchies.^^xsd:string</para>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#abstract">spin:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    let ask = _prefixId.prefix "ask"
    /// <summary>
    ///   <para>rdfs:comment : The body of a Function or Template. This points to a Query instance. For Functions, this is limited to either ASK or SELECT type queries. If the body is the ASK function then the return value is xsd:boolean. Otherwise, the SELECT query must have a single return variable. The first binding of this SELECT query will be returned as result of the function call.^^xsd:string</para>
    ///   <para>rdfs:label : body^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#body">spin:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true to instruct the SPIN engine that it may cache the results of all calls to the associated function. Functions should only be marked as cachable if the same combination of input arguments always returns the same result. Functions that query a graph or other background data that may change over time should not be cached. Caching can significantly improve performance of frequently needed functions.^^xsd:string</para>
    ///   <para>rdfs:label : cachable^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#cachable">spin:cachable</a>
    /// </summary>
    let cachable = _prefixId.prefix "cachable"
    /// <summary>
    ///   <para>rdfs:comment : Can link a TableDataProvider (esp. SelectTemplate) with one or more columns that provide metadata for rendering purposes. Columns can be sorted by their spin:columnIndex (which must align with the ordering of variables in the SELECT query starting with 0). Not all result variables of the underlying query need to have a matching spin:Column.^^xsd:string</para>
    ///   <para>rdfs:label : column^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#column">spin:column</a>
    /// </summary>
    let column = _prefixId.prefix "column"
    /// <summary>
    ///   <para>rdfs:comment : The index of a column (from left to right) starting at 0.^^xsd:string</para>
    ///   <para>rdfs:label : column index^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#columnIndex">spin:columnIndex</a>
    /// </summary>
    let columnIndex = _prefixId.prefix "columnIndex"
    /// <summary>
    ///   <para>rdfs:comment : The datatype or resource type of a spin:Column. For example this is useful as metadata to inform a rendering engine that numeric columns (e.g. xsd:float) need to be right-aligned.^^xsd:string</para>
    ///   <para>rdfs:label : column type^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#columnType">spin:columnType</a>
    /// </summary>
    let columnType = _prefixId.prefix "columnType"
    /// <summary>
    ///   <para>rdfs:comment : The preferred width of the associated Column, for display purposes. Values in pixels (rendering engines may multiply the values depending on resolution).^^xsd:string</para>
    ///   <para>rdfs:label : column width^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#columnWidth">spin:columnWidth</a>
    /// </summary>
    let columnWidth = _prefixId.prefix "columnWidth"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a resource with a SPARQL query or update request (sp:Command).^^xsd:string</para>
    ///   <para>rdfs:label : command^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#command">spin:command</a>
    /// </summary>
    let command = _prefixId.prefix "command"
    /// <summary>
    ///   <para>rdfs:comment : Links a class with constraints on its instances. The values of this property are "axioms" expressed as CONSTRUCT or ASK queries where the variable ?this refers to the instances of the surrounding class. ASK queries must evaluate to false for each member of this class - returning true means that the instance ?this violates the constraint. CONSTRUCT queries must create instances of spin:ConstraintViolation to provide details on the reason for the violation.^^xsd:string</para>
    ///   <para>rdfs:label : constraint^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#constraint">spin:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    let construct = _prefixId.prefix "construct"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to attach a "constructor" to a class. A constructor is a SPARQL CONSTRUCT query or INSERT/DELETE Update operation that can add initial values to the current instance. At execution time, the variable ?this is bound to the current instance. Tools can call constructors of a class and its superclasses when an instance of a class has been created. Constructors will also be used to initialize resources that have received a new rdf:type triple as a result of spin:rules firing.^^xsd:string</para>
    ///   <para>rdfs:label : constructor^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#constructor">spin:constructor</a>
    /// </summary>
    let constructor = _prefixId.prefix "constructor"
    let eval = _prefixId.prefix "eval"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a ConstraintViolation with one or more UPDATE Templates that would help fix the violation.^^xsd:string</para>
    ///   <para>rdfs:label : fix^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#fix">spin:fix</a>
    /// </summary>
    let fix = _prefixId.prefix "fix"
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:comment : A template string for displaying instantiations of a module in human-readable form. The template may contain the argument variable names in curly braces to support substitution. For example, "The number of values of the {?arg1} property."^^xsd:string</para>
    ///   <para>rdfs:label : label template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#labelTemplate">spin:labelTemplate</a>
    /// </summary>
    let labelTemplate = _prefixId.prefix "labelTemplate"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link two sub-properties of spin:rule (or spin:rule itself) to instruct the SPIN engine to execute one set of rules before another one. The values of the subject property will be executed before those of the object property.^^xsd:string</para>
    ///   <para>rdfs:label : next rule property^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#nextRuleProperty">spin:nextRuleProperty</a>
    /// </summary>
    let nextRuleProperty = _prefixId.prefix "nextRuleProperty"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true to indicate that a SPIN function or template is only meant to be used as a helper of other modules, but not directly. Among others, this allows user interfaces to filter out private modules. Furthermore, it tells potential users of this module that they should avoid using this module, as it may not be stable.^^xsd:string</para>
    ///   <para>rdfs:label : private^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#private">spin:private</a>
    /// </summary>
    let private_ = _prefixId.prefix "private"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to point from any resource to a Query.^^xsd:string</para>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#query">spin:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:comment : The return type of a Function, e.g. xsd:string.^^xsd:string</para>
    ///   <para>rdfs:label : return type^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#returnType">spin:returnType</a>
    /// </summary>
    let returnType = _prefixId.prefix "returnType"
    let rule = _prefixId.prefix "rule"
    /// <summary>
    ///   <para>rdfs:comment : Can be attached to spin:rule (or subclasses thereof) to instruct a SPIN rules engine that it shall only execute the rules max times. If no value is specified, then the rules will be executed with no specific limit.^^xsd:string</para>
    ///   <para>rdfs:label : rule property max iteration count^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#rulePropertyMaxIterationCount">spin:rulePropertyMaxIterationCount</a>
    /// </summary>
    let rulePropertyMaxIterationCount = _prefixId.prefix "rulePropertyMaxIterationCount"
    let select = _prefixId.prefix "select"
    /// <summary>
    ///   <para>rdfs:comment : The symbol of a function, e.g. "=" for the eq function.^^xsd:string</para>
    ///   <para>rdfs:label : symbol^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#symbol">spin:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"
    /// <summary>
    ///   <para>rdfs:comment : An "abstract" base property that groups together those system properties that the user will hardly ever need to see in property trees. This property may be dropped in future versions of this ontology - right now it's mainly here for convenience.^^xsd:string</para>
    ///   <para>rdfs:label : system property^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#systemProperty">spin:systemProperty</a>
    /// </summary>
    let systemProperty = _prefixId.prefix "systemProperty"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true for SPIN rules and constraints that do not require pre-binding the variable ?this with all members of the associated class. This flag should only be set to true if the WHERE clause is sufficiently strong to only bind instances of the associated class, or its subclasses. In those cases, the engine can greatly improve performance of query execution, because it does not need to add clauses to narrow down the WHERE clause.^^xsd:string</para>
    ///   <para>rdfs:label : this unbound^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#thisUnbound">spin:thisUnbound</a>
    /// </summary>
    let thisUnbound = _prefixId.prefix "thisUnbound"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to point from any resource to an Update.^^xsd:string</para>
    ///   <para>rdfs:label : update^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#update">spin:update</a>
    /// </summary>
    let update = _prefixId.prefix "update"
    /// <summary>
    ///   <para>rdfs:comment : An optional attribute of ConstraintViolations to point at a violation level (such as Error and Warning). Defaults to spin:Error.^^xsd:string</para>
    ///   <para>rdfs:label : violation level^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#violationLevel">spin:violationLevel</a>
    /// </summary>
    let violationLevel = _prefixId.prefix "violationLevel"
    /// <summary>
    ///   <para>rdfs:comment : An optional attribute of ConstraintViolations to provide a path expression from the root resource to the value that is invalid. If this is a URI then the path represents the predicate of a subject/predicate combination. Otherwise it should be a blank node of type sp:Path.^^xsd:string</para>
    ///   <para>rdfs:label : violation path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#violationPath">spin:violationPath</a>
    /// </summary>
    let violationPath = _prefixId.prefix "violationPath"
    /// <summary>
    ///   <para>rdfs:comment : The root resource of the violation (often ?this in the constraint body).^^xsd:string</para>
    ///   <para>rdfs:label : violation root^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#violationRoot">spin:violationRoot</a>
    /// </summary>
    let violationRoot = _prefixId.prefix "violationRoot"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a spin:ConstraintViolation with the query or template call that caused it. This property is typically filled in automatically by the constraint checking engine and does not need to be set manually. However, it can be useful to learn more about the origin of a violation.^^xsd:string</para>
    ///   <para>rdfs:label : violation source^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#violationSource">spin:violationSource</a>
    /// </summary>
    let violationSource = _prefixId.prefix "violationSource"
    /// <summary>
    ///   <para>rdfs:comment : An optional attribute of ConstraintViolations to point at a specific RDF node that caused the violation. Should be accessible from the root via the violationPath.^^xsd:string</para>
    ///   <para>rdfs:label : violation value^^xsd:string</para>
    ///   <a href="http://spinrdf.org/spin#violationValue">spin:violationValue</a>
    /// </summary>
    let violationValue = _prefixId.prefix "violationValue"

namespace http.spinrdf.org.spin.hash

open DoxAletheia.Rdf_Vocabulary

module spin =
    let _namespace_name = "http://spinrdf.org/spin#"
    /// <summary>
    /// Groups together the kinds of SPARQL commands that can appear as SPIN rules and constructors: CONSTRUCT, DELETE WHERE and DELETE/INSERT. This class is never to be instantiated directly.
    /// <see href="http://spinrdf.org/spin#Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName
    /// <summary>
    /// The body of a Function or Template. This points to a Query instance. For Functions, this is limited to either ASK or SELECT type queries. If the body is the ASK function then the return value is xsd:boolean. Otherwise, the SELECT query must have a single return variable. The first binding of this SELECT query will be returned as result of the function call.
    /// <see href="http://spinrdf.org/spin#body"></see></summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName

    /// <summary>
    /// A SPIN template that wraps an ASK query.
    /// <see href="http://spinrdf.org/spin#AskTemplate"></see></summary>
    let AskTemplate =
        Namespaced_IRI.parse _namespace_name "AskTemplate" |> NamespacedName

    /// <summary>
    /// Links a class with constraints on its instances. The values of this property are "axioms" expressed as CONSTRUCT or ASK queries where the variable ?this refers to the instances of the surrounding class. ASK queries must evaluate to false for each member of this class - returning true means that the instance ?this violates the constraint. CONSTRUCT queries must create instances of spin:ConstraintViolation to provide details on the reason for the violation.
    /// <see href="http://spinrdf.org/spin#constraint"></see></summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    /// The metaclass of SPIN templates. Templates are classes that are instances of this class. A template represents a reusable SPARQL query or update request that can be parameterized with arguments. Templates can be instantiated in places where normally a SPARQL query or update request is used, in particular as spin:rules and spin:constraints.
    /// <see href="http://spinrdf.org/spin#Template"></see></summary>
    let Template = Namespaced_IRI.parse _namespace_name "Template" |> NamespacedName

    /// <summary>
    /// Suggested abstract base class for all AskTemplates.
    /// <see href="http://spinrdf.org/spin#AskTemplates"></see></summary>
    let AskTemplates =
        Namespaced_IRI.parse _namespace_name "AskTemplates" |> NamespacedName

    /// <summary>
    /// Can be set to true to indicate that this module shall not be instantiated. Abstract modules are only there to organize other modules into hierarchies.
    /// <see href="http://spinrdf.org/spin#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// Suggested abstract base class for all Templates.
    /// <see href="http://spinrdf.org/spin#Templates"></see></summary>
    let Templates = Namespaced_IRI.parse _namespace_name "Templates" |> NamespacedName
    /// <summary>
    /// Provides metadata about a column in the result set of a (SPARQL) query, for example of the body queries of SPIN templates. Columns can define human-readable labels that serve as column titles, using rdfs:label.
    /// <see href="http://spinrdf.org/spin#Column"></see></summary>
    let Column = Namespaced_IRI.parse _namespace_name "Column" |> NamespacedName

    /// <summary>
    /// An object that can be created by spin:constraints to provide information about a constraint violation.
    /// <see href="http://spinrdf.org/spin#ConstraintViolation"></see></summary>
    let ConstraintViolation =
        Namespaced_IRI.parse _namespace_name "ConstraintViolation" |> NamespacedName

    /// <summary>
    /// The type of the supported levels of constraint violations, including spin:Error and spin:Warning.
    /// <see href="http://spinrdf.org/spin#ConstraintViolationLevel"></see></summary>
    let ConstraintViolationLevel =
        Namespaced_IRI.parse _namespace_name "ConstraintViolationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spinrdf.org/spin#ConstructTemplate"></see>
    /// </summary>
    let ConstructTemplate =
        Namespaced_IRI.parse _namespace_name "ConstructTemplate" |> NamespacedName

    /// <summary>
    /// Suggested abstract base class for all ConstructTemplates.
    /// <see href="http://spinrdf.org/spin#ConstructTemplates"></see></summary>
    let ConstructTemplates =
        Namespaced_IRI.parse _namespace_name "ConstructTemplates" |> NamespacedName

    /// <summary>
    /// Indicates that the associated constraint violation is an error that should be fixed.
    /// <see href="http://spinrdf.org/spin#Error"></see></summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName
    /// <summary>
    /// Indicates that the associated constraint violation is a severe error that must be fixed. Constraint checking engines may decide to stop further evaluation once a fatal error has been detected.
    /// <see href="http://spinrdf.org/spin#Fatal"></see></summary>
    let Fatal = Namespaced_IRI.parse _namespace_name "Fatal" |> NamespacedName
    /// <summary>
    /// Metaclass for functions that can be used in SPARQL expressions (e.g. FILTER or BIND). The function themselves are classes that are instances of this metaclass. Function calls are instances of the function classes, with property values for the arguments.
    /// <see href="http://spinrdf.org/spin#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    /// An abstract building block of a SPARQL system. A Module can take Arguments as input and applies them on an input RDF Graph. The Arguments should be declared as spin:constraints.
    /// <see href="http://spinrdf.org/spin#Module"></see></summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName
    /// <summary>
    /// An abstract base class for all defined functions. This class mainly serves as a shared root so that the various instances of the Function metaclass are grouped together.
    /// <see href="http://spinrdf.org/spin#Functions"></see></summary>
    let Functions = Namespaced_IRI.parse _namespace_name "Functions" |> NamespacedName
    /// <summary>
    /// An "artificial" parent class for all Functions and Templates.
    /// <see href="http://spinrdf.org/spin#Modules"></see></summary>
    let Modules = Namespaced_IRI.parse _namespace_name "Modules" |> NamespacedName
    /// <summary>
    /// Indicates that the associated constraint violation is a not a problem. This level can be used for diagnostic and debugging purposes.
    /// <see href="http://spinrdf.org/spin#Info"></see></summary>
    let Info = Namespaced_IRI.parse _namespace_name "Info" |> NamespacedName

    /// <summary>
    /// A marker class that can be attached to base URIs (ontologies) to instruct SPIN engines that this ontology only contains a library of SPIN declarations. Library Ontologies should be ignored by SPIN inference engines even if they have been imported by a domain model. For example, a SPIN version of OWL RL may contain all the OWL RL axioms, attached to owl:Thing, but nothing else. However, when executed, these axioms should not be executed over themselves, because we don't want the system to reason about the SPIN triples to speed up things.
    /// <see href="http://spinrdf.org/spin#LibraryOntology"></see></summary>
    let LibraryOntology =
        Namespaced_IRI.parse _namespace_name "LibraryOntology" |> NamespacedName

    /// <summary>
    /// An abstract superclass that can be used to group all spin:MagicProperty instances under a single parent class.
    /// <see href="http://spinrdf.org/spin#MagicProperties"></see></summary>
    let MagicProperties =
        Namespaced_IRI.parse _namespace_name "MagicProperties" |> NamespacedName

    /// <summary>
    ///   <see href="http://spinrdf.org/spin#MagicProperty"></see>
    /// </summary>
    let MagicProperty =
        Namespaced_IRI.parse _namespace_name "MagicProperty" |> NamespacedName

    /// <summary>
    /// An "abstract" base property that groups together those system properties that the user will hardly ever need to see in property trees. This property may be dropped in future versions of this ontology - right now it's mainly here for convenience.
    /// <see href="http://spinrdf.org/spin#systemProperty"></see></summary>
    let systemProperty =
        Namespaced_IRI.parse _namespace_name "systemProperty" |> NamespacedName

    /// <summary>
    /// Can be used to attach a "constructor" to a class. A constructor is a SPARQL CONSTRUCT query or INSERT/DELETE Update operation that can add initial values to the current instance. At execution time, the variable ?this is bound to the current instance. Tools can call constructors of a class and its superclasses when an instance of a class has been created. Constructors will also be used to initialize resources that have received a new rdf:type triple as a result of spin:rules firing.
    /// <see href="http://spinrdf.org/spin#constructor"></see></summary>
    let constructor =
        Namespaced_IRI.parse _namespace_name "constructor" |> NamespacedName

    /// <summary>
    /// The metaclass of spin:rule and its subproperties. spin:RuleProperties can have additional metadata attached to them.
    /// <see href="http://spinrdf.org/spin#RuleProperty"></see></summary>
    let RuleProperty =
        Namespaced_IRI.parse _namespace_name "RuleProperty" |> NamespacedName

    /// <summary>
    /// A SPIN template that wraps a SELECT query.
    /// <see href="http://spinrdf.org/spin#SelectTemplate"></see></summary>
    let SelectTemplate =
        Namespaced_IRI.parse _namespace_name "SelectTemplate" |> NamespacedName

    /// <summary>
    /// An abstraction of objects that can produce tabular data. This serves as a base class of spin:SelectTemplate, because SELECT queries can produce tables with columns for each result variable. However, other types of TableDataProviders are conceivable by other frameworks, and this class may prove as a useful shared foundation.
    ///
    /// TableDataProviders can link to definitions of columns via spin:column, and these definitions can inform rendering engines.
    /// <see href="http://spinrdf.org/spin#TableDataProvider"></see></summary>
    let TableDataProvider =
        Namespaced_IRI.parse _namespace_name "TableDataProvider" |> NamespacedName

    /// <summary>
    /// Suggested abstract base class for all SelectTemplates.
    /// <see href="http://spinrdf.org/spin#SelectTemplates"></see></summary>
    let SelectTemplates =
        Namespaced_IRI.parse _namespace_name "SelectTemplates" |> NamespacedName

    /// <summary>
    /// A SPIN template that has an UPDATE command as its body.
    /// <see href="http://spinrdf.org/spin#UpdateTemplate"></see></summary>
    let UpdateTemplate =
        Namespaced_IRI.parse _namespace_name "UpdateTemplate" |> NamespacedName

    /// <summary>
    /// Suggested abstract base class for all UpdateTemplates.
    /// <see href="http://spinrdf.org/spin#UpdateTemplates"></see></summary>
    let UpdateTemplates =
        Namespaced_IRI.parse _namespace_name "UpdateTemplates" |> NamespacedName

    /// <summary>
    /// Indicates that the associated constraint violation is a problem that may not have to be fixed but may lead to issues in the future.
    /// <see href="http://spinrdf.org/spin#Warning"></see></summary>
    let Warning = Namespaced_IRI.parse _namespace_name "Warning" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/spin#_arg1"></see>
    /// </summary>
    let _arg1 = Namespaced_IRI.parse _namespace_name "_arg1" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/spin#_arg2"></see>
    /// </summary>
    let _arg2 = Namespaced_IRI.parse _namespace_name "_arg2" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/spin#_arg3"></see>
    /// </summary>
    let _arg3 = Namespaced_IRI.parse _namespace_name "_arg3" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/spin#_arg4"></see>
    /// </summary>
    let _arg4 = Namespaced_IRI.parse _namespace_name "_arg4" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/spin#_arg5"></see>
    /// </summary>
    let _arg5 = Namespaced_IRI.parse _namespace_name "_arg5" |> NamespacedName
    /// <summary>
    /// A system variable representing the current context instance in a rule or constraint.
    /// <see href="http://spinrdf.org/spin#_this"></see></summary>
    let _this = Namespaced_IRI.parse _namespace_name "_this" |> NamespacedName
    /// <summary>
    /// Executes a given ASK query and returns its boolean result. The first argument must point to an sp:Ask or a SPIN template call that has an ASK query as its body. All subsequent argument can come in pairs, with the first one being a variable name and the second its binding.
    ///
    /// Example:
    ///
    ///     BIND (spin:ask(?query, "this", owl:Thing) AS ?result) .
    ///
    /// will execute the sp:Ask behind ?query with the variable ?this pre-bound to owl:Thing.
    /// <see href="http://spinrdf.org/spin#ask"></see></summary>
    let ask = Namespaced_IRI.parse _namespace_name "ask" |> NamespacedName
    /// <summary>
    /// Can be set to true to instruct the SPIN engine that it may cache the results of all calls to the associated function. Functions should only be marked as cachable if the same combination of input arguments always returns the same result. Functions that query a graph or other background data that may change over time should not be cached. Caching can significantly improve performance of frequently needed functions.
    /// <see href="http://spinrdf.org/spin#cachable"></see></summary>
    let cachable = Namespaced_IRI.parse _namespace_name "cachable" |> NamespacedName
    /// <summary>
    /// Can link a TableDataProvider (esp. SelectTemplate) with one or more columns that provide metadata for rendering purposes. Columns can be sorted by their spin:columnIndex (which must align with the ordering of variables in the SELECT query starting with 0). Not all result variables of the underlying query need to have a matching spin:Column.
    /// <see href="http://spinrdf.org/spin#column"></see></summary>
    let column = Namespaced_IRI.parse _namespace_name "column" |> NamespacedName

    /// <summary>
    /// The index of a column (from left to right) starting at 0.
    /// <see href="http://spinrdf.org/spin#columnIndex"></see></summary>
    let columnIndex =
        Namespaced_IRI.parse _namespace_name "columnIndex" |> NamespacedName

    /// <summary>
    /// The datatype or resource type of a spin:Column. For example this is useful as metadata to inform a rendering engine that numeric columns (e.g. xsd:float) need to be right-aligned.
    /// <see href="http://spinrdf.org/spin#columnType"></see></summary>
    let columnType = Namespaced_IRI.parse _namespace_name "columnType" |> NamespacedName

    /// <summary>
    /// The preferred width of the associated Column, for display purposes. Values in pixels (rendering engines may multiply the values depending on resolution).
    /// <see href="http://spinrdf.org/spin#columnWidth"></see></summary>
    let columnWidth =
        Namespaced_IRI.parse _namespace_name "columnWidth" |> NamespacedName

    /// <summary>
    /// Can be used to link a resource with a SPARQL query or update request (sp:Command).
    /// <see href="http://spinrdf.org/spin#command"></see></summary>
    let command = Namespaced_IRI.parse _namespace_name "command" |> NamespacedName
    /// <summary>
    /// Can be used to point from any resource to a Query.
    /// <see href="http://spinrdf.org/spin#query"></see></summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName
    /// <summary>
    /// Evaluates a given sp:Construct or SPIN template call (first argument on the left hand side) and binds the resulting triples to the variables on the right hand side.
    ///
    /// Example:
    ///
    ///     (?query "this" owl:Thing) spin:construct (?s ?p ?o)
    ///
    /// will execute the sp:Construct ?query using the binding of owl:Thing to ?this. The resulting triples will be bound to ?s, ?p and ?o. If any of ?s ?p ?o are bound, it will only return the matching triples.
    /// <see href="http://spinrdf.org/spin#construct"></see></summary>
    let construct = Namespaced_IRI.parse _namespace_name "construct" |> NamespacedName
    /// <summary>
    /// Evaluates a given SPIN expression or SELECT or ASK query, and returns its result. The first argument must be the expression in SPIN RDF syntax. All other arguments must come in pairs: first a property name, and then a value. These name/value pairs will be pre-bound variables for the execution of the expression.
    /// <see href="http://spinrdf.org/spin#eval"></see></summary>
    let eval = Namespaced_IRI.parse _namespace_name "eval" |> NamespacedName
    /// <summary>
    /// Can be used to link a ConstraintViolation with one or more UPDATE Templates that would help fix the violation.
    /// <see href="http://spinrdf.org/spin#fix"></see></summary>
    let fix = Namespaced_IRI.parse _namespace_name "fix" |> NamespacedName
    /// <summary>
    /// Can be used to link an RDF graph (usually the instance of owl:Ontology) with a SPIN library to define constraints. SPIN-aware tools should include the definitions from those libraries for constraint checking. Using such libraries is a simpler alternative than explicitly importing them using owl:imports, because it does not force all the SPIN triples into the RDF model.
    /// <see href="http://spinrdf.org/spin#imports"></see></summary>
    let imports = Namespaced_IRI.parse _namespace_name "imports" |> NamespacedName

    /// <summary>
    /// A template string for displaying instantiations of a module in human-readable form. The template may contain the argument variable names in curly braces to support substitution. For example, "The number of values of the {?arg1} property."
    /// <see href="http://spinrdf.org/spin#labelTemplate"></see></summary>
    let labelTemplate =
        Namespaced_IRI.parse _namespace_name "labelTemplate" |> NamespacedName

    /// <summary>
    /// Can be used to link two sub-properties of spin:rule (or spin:rule itself) to instruct the SPIN engine to execute one set of rules before another one. The values of the subject property will be executed before those of the object property.
    /// <see href="http://spinrdf.org/spin#nextRuleProperty"></see></summary>
    let nextRuleProperty =
        Namespaced_IRI.parse _namespace_name "nextRuleProperty" |> NamespacedName

    /// <summary>
    /// Can be set to true to indicate that a SPIN function or template is only meant to be used as a helper of other modules, but not directly. Among others, this allows user interfaces to filter out private modules. Furthermore, it tells potential users of this module that they should avoid using this module, as it may not be stable.
    /// <see href="http://spinrdf.org/spin#private"></see></summary>
    let private_ = Namespaced_IRI.parse _namespace_name "private" |> NamespacedName
    /// <summary>
    /// The return type of a Function, e.g. xsd:string.
    /// <see href="http://spinrdf.org/spin#returnType"></see></summary>
    let returnType = Namespaced_IRI.parse _namespace_name "returnType" |> NamespacedName
    /// <summary>
    /// An inferencing rule attached to a class. Rules are expressed as CONSTRUCT queries or INSERT/DELETE operations where the variable ?this will be bound to the current instance of the class. These inferences can be used to derive new values from existing values at the instance.
    /// <see href="http://spinrdf.org/spin#rule"></see></summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName

    /// <summary>
    /// Can be attached to spin:rule (or subclasses thereof) to instruct a SPIN rules engine that it shall only execute the rules max times. If no value is specified, then the rules will be executed with no specific limit.
    /// <see href="http://spinrdf.org/spin#rulePropertyMaxIterationCount"></see></summary>
    let rulePropertyMaxIterationCount =
        Namespaced_IRI.parse _namespace_name "rulePropertyMaxIterationCount" |> NamespacedName

    /// <summary>
    /// Executes a given SELECT or ASK query (or a corresponding SPIN template call) and binds its result rows to the variables specified on the right hand side. May also pre-bind variables for the query execution, using name-value pairs on the left hand side.
    ///
    /// Example:
    ///
    ///     (?query "this" owl:Thing) spin:select (?a ?b)
    ///
    /// will execute the sp:Select or sp:Ask that ?query points to and pre-bind ?this with the value of owl:Thing for the execution of the query. The first result variable of the query's result set will be bound to ?a, the second to ?b etc. If the nodes on the right are bound (or constants) then it will match with the values from the result set.
    /// <see href="http://spinrdf.org/spin#select"></see></summary>
    let select = Namespaced_IRI.parse _namespace_name "select" |> NamespacedName
    /// <summary>
    /// The symbol of a function, e.g. "=" for the eq function.
    /// <see href="http://spinrdf.org/spin#symbol"></see></summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName

    /// <summary>
    /// Can be set to true for SPIN rules and constraints that do not require pre-binding the variable ?this with all members of the associated class. This flag should only be set to true if the WHERE clause is sufficiently strong to only bind instances of the associated class, or its subclasses. In those cases, the engine can greatly improve performance of query execution, because it does not need to add clauses to narrow down the WHERE clause.
    /// <see href="http://spinrdf.org/spin#thisUnbound"></see></summary>
    let thisUnbound =
        Namespaced_IRI.parse _namespace_name "thisUnbound" |> NamespacedName

    /// <summary>
    /// Can be used to point from any resource to an Update.
    /// <see href="http://spinrdf.org/spin#update"></see></summary>
    let update = Namespaced_IRI.parse _namespace_name "update" |> NamespacedName

    /// <summary>
    /// An optional attribute of ConstraintViolations to point at a violation level (such as Error and Warning). Defaults to spin:Error.
    /// <see href="http://spinrdf.org/spin#violationLevel"></see></summary>
    let violationLevel =
        Namespaced_IRI.parse _namespace_name "violationLevel" |> NamespacedName

    /// <summary>
    /// An optional attribute of ConstraintViolations to provide a path expression from the root resource to the value that is invalid. If this is a URI then the path represents the predicate of a subject/predicate combination. Otherwise it should be a blank node of type sp:Path.
    /// <see href="http://spinrdf.org/spin#violationPath"></see></summary>
    let violationPath =
        Namespaced_IRI.parse _namespace_name "violationPath" |> NamespacedName

    /// <summary>
    /// The root resource of the violation (often ?this in the constraint body).
    /// <see href="http://spinrdf.org/spin#violationRoot"></see></summary>
    let violationRoot =
        Namespaced_IRI.parse _namespace_name "violationRoot" |> NamespacedName

    /// <summary>
    /// Can be used to link a spin:ConstraintViolation with the query or template call that caused it. This property is typically filled in automatically by the constraint checking engine and does not need to be set manually. However, it can be useful to learn more about the origin of a violation.
    /// <see href="http://spinrdf.org/spin#violationSource"></see></summary>
    let violationSource =
        Namespaced_IRI.parse _namespace_name "violationSource" |> NamespacedName

    /// <summary>
    /// An optional attribute of ConstraintViolations to point at a specific RDF node that caused the violation. Should be accessible from the root via the violationPath.
    /// <see href="http://spinrdf.org/spin#violationValue"></see></summary>
    let violationValue =
        Namespaced_IRI.parse _namespace_name "violationValue" |> NamespacedName

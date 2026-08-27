namespace http.www.w3.org._2000._10.swap.os.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module os =
    let _namespace_iri = Namespace_Iri os |> NamespaceIRI
    /// <summary>
    ///   <para>os:argv</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.daml.org/2000/10/daml-ont#UniqueProperty&gt;</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The object is looked up as the literal string which was given
    /// as the nth command line argument.
    ///
    ///     The os:argv property allows one to make statements whose interpretation
    /// is relative to the conditions pertaining at the time of execution. Beware
    /// of writing axioms about these, in making optimizations for example about
    /// reuse of information between runs.  The uniqueness of this property pertains
    /// to one run of a program.  The ont:UniqueProperty may be removed if it
    /// messes up more complex processing.
    ///
    /// (For example, cwm uses a "-with" argument
    /// to indicate that the following args should be passed to the RDF system.
    ///
    /// Example:
    ///     cwm foo.n3 -think -with bar baz
    ///     when processing,   {"1" os:argv "bar". "2" os:arv "baz"} will be true)
    ///
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"command line argument value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/os#argv">http://www.w3.org/2000/10/swap/os#argv</seealso>
    let argv = Prefixed_Name(os, "argv") |> PrefixedName
    /// <summary>
    ///   <para>os:baseAbsolute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>&lt;http://www.daml.org/2000/10/daml-ont#UniqueProperty&gt;</para>
    ///   <para>"The baseAbsolute property of a URI reference string is a string
    /// which is an (absolute) URI, generated assuming the
    /// base of the running process.  This will, for example,
    /// generate a file: URI from a unix relative file path when running
    /// in file: space.  (Cwm uses the current working directory as a base
    /// unless the --base option is given)
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"absolute form assuming current base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/os#baseAbsolute">http://www.w3.org/2000/10/swap/os#baseAbsolute</seealso>
    let baseAbsolute = Prefixed_Name(os, "baseAbsolute") |> PrefixedName
    /// <summary>
    ///   <para>os:baseRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.daml.org/2000/10/daml-ont#UniqueProperty&gt;</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The baseRelative property of a URI string is a string
    /// which is a valid relative form of the URI, relative to the
    /// base of the running process.  The base of a running unix
    /// process is typically a file: URI for the file being processed,
    /// or just the current working directory followed by a "/".
    ///
    /// The relative form is suitable for quotation in a file
    /// whose URI is the same (except for anything after the last slash).
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relative to current base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/os#baseRelative">http://www.w3.org/2000/10/swap/os#baseRelative</seealso>
    let baseRelative = Prefixed_Name(os, "baseRelative") |> PrefixedName
    /// <summary>
    ///   <para>os:environ</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>&lt;http://www.daml.org/2000/10/daml-ont#UniqueProperty&gt;</para>
    ///   <para>"
    /// The os:environ property of a string is the value corresponding to
    /// the string when looked up in the curent environment.  This is
    /// not, of course, something of global significance: it is only
    /// used in local processing for passing parameters into a semantic web
    /// processor.  The subject is the name of the environment variable
    /// and the object its value.
    ///
    /// os:environ is a built-in function in cwm, and corresponds
    /// to Python's os.environ[] .
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"environment value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/os#environ">http://www.w3.org/2000/10/swap/os#environ</seealso>
    let environ = Prefixed_Name(os, "environ") |> PrefixedName

namespace http.jena.hpl.hp.com._2005._11.Assembler.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ja =
    let _namespace_iri = Namespace_Iri ja |> NamespaceIRI
    /// <summary>
    ///   <para>ja:Object</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://jena.hpl.hp.com/2005/11/Assembler#Object">http://jena.hpl.hp.com/2005/11/Assembler#Object</seealso>
    let Object = Prefixed_Name(ja, "Object") |> PrefixedName
    /// <summary>
    ///   <para>ja:assembler</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://jena.hpl.hp.com/2005/11/Assembler#assembler">http://jena.hpl.hp.com/2005/11/Assembler#assembler</seealso>
    let assembler = Prefixed_Name(ja, "assembler") |> PrefixedName

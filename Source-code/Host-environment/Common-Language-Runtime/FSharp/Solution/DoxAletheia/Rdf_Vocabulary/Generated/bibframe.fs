namespace http.id.loc.gov.ontologies.bibframe.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bibframe =
    let _namespace_iri = Namespace_Iri bibframe |> NamespaceIRI
    /// <summary>
    ///   <para>loc:ontologies/bibframe/subject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://id.loc.gov/ontologies/bibframe/subject">http://id.loc.gov/ontologies/bibframe/subject</seealso>
    let subject = Prefixed_Name(bibframe, "subject") |> PrefixedName

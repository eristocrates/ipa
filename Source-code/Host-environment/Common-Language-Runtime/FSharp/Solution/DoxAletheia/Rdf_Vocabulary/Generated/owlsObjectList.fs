namespace http.www.daml.org.services.owl_s._1._2.generic.ObjectList.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsObjectList =
    let _namespace_iri = Namespace_Iri owlsObjectList |> NamespaceIRI
    /// <summary>
    ///   <para>owlsObjectList:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The first item in the subject RDF list.</para>
    /// labels<para>first</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#first">http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#first</seealso>
    let first = Prefixed_Name(owlsObjectList, "first") |> PrefixedName
    /// <summary>
    ///   <para>owlsObjectList:nil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlsObjectList:List</para>
    ///   <para>The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.</para>
    /// labels<para>nil</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#nil">http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#nil</seealso>
    let nil = Prefixed_Name(owlsObjectList, "nil") |> PrefixedName
    /// <summary>
    ///   <para>owlsObjectList:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is intended to provide an OWL-DL compatible version of rdf:List</para>
    /// labels<para>List</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#List">http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#List</seealso>
    let List = Prefixed_Name(owlsObjectList, "List") |> PrefixedName
    /// <summary>
    ///   <para>owlsObjectList:rest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The rest of the subject RDF list after the first item.</para>
    /// labels<para>rest</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#rest">http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#rest</seealso>
    let rest = Prefixed_Name(owlsObjectList, "rest") |> PrefixedName

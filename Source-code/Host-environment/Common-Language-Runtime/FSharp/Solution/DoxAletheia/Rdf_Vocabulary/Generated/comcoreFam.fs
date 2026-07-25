namespace https.www.commoncoreontologies.org.FamilialRelationsOntology.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module comcoreFam =
    let _namespace_iri = Namespace_Iri comcoreFam |> NamespaceIRI
    /// <summary>
    ///   <para>comcoreFam:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology is designed to represent familial relationships.</para>
    /// labels<para>Familial Relations Ontology</para></remarks>
    /// <seealso href="https://www.commoncoreontologies.org/FamilialRelationsOntology">https://www.commoncoreontologies.org/FamilialRelationsOntology</seealso>
    let _prefix_iri = Prefixed_Name(comcoreFam, "") |> PrefixedName

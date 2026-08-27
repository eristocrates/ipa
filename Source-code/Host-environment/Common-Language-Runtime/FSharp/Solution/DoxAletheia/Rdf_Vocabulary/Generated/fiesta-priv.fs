namespace http.purl.org.iot.ontology.fiesta_iot.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fiesta_priv =
    let _namespace_iri = Namespace_Iri fiesta_priv |> NamespaceIRI
    /// <summary>
    ///   <para>fiesta-priv:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"After a thorough analysis of existing Internet of Things (IoT) related ontologies, we propose FIESTA-IoT Ontology that aims to achieve semantic interoperability among heterogeneous testbeds. The Ontology is framed within the EU H2020's FIESTA-IoT project, that aims to seamlessly support the federation of testbeds through the usage of semantic-based technologies. The  FIESTA-IoT ontology takes inspiration from the well-known Noy et al. methodology  for reusing and interconnecting existing ontologies. To build the ontology, we leverage a number of core concepts from various mainstream ontologies and taxonomies, such as Semantic Sensor Network (SSN), M3-lite (a lite version of M3 ontology), WGS84, IoT-lite, Time, and DUL ontology. Please report any errors to rachit.agarwal@inria.fr"</para>
    /// labels<para>"FIESTA-IoT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/iot/ontology/fiesta-iot#">http://purl.org/iot/ontology/fiesta-iot#</seealso>
    let _prefix_iri = Prefixed_Name(fiesta_priv, "") |> PrefixedName

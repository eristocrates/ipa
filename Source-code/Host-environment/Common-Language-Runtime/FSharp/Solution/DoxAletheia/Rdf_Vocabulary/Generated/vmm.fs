namespace http.spi_fm.uca.es.spdef.models.genericTools.vmm._1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vmm =
    let _namespace_iri = Namespace_Iri vmm |> NamespaceIRI
    /// <summary>
    ///   <para>vmm:Connector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Clase que representa a una determinada relación entre
    ///    dos elementos de modelado."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Connector entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Connector">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Connector</seealso>
    let Connector = Prefixed_Name(vmm, "Connector") |> PrefixedName
    /// <summary>
    ///   <para>vmm:Diagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Clase que representa a un determinado diagrama modelado
    ///    con algún lenguaje visual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Diagram entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Diagram">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Diagram</seealso>
    let Diagram = Prefixed_Name(vmm, "Diagram") |> PrefixedName
    /// <summary>
    ///   <para>vmm:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Enumeración con los posibles tipos de elementos que
    ///    pueden participar en un diagrama. Casos de uso, clases o componentes
    ///    son ejemplos de tipos de elementos en modelos UML."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Element entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Element">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Element</seealso>
    let Element = Prefixed_Name(vmm, "Element") |> PrefixedName
    /// <summary>
    ///   <para>vmm:ModelRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase contenedora de todos los proyectos gestionados con
    ///    la herramienta de modelado."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The ModelRepository entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ModelRepository">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ModelRepository</seealso>
    let ModelRepository = Prefixed_Name(vmm, "ModelRepository") |> PrefixedName
    /// <summary>
    ///   <para>vmm:Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase que representa a un paquete de modelos, con el
    ///    cual organizar los diferentes modelos."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Package entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Package">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Package</seealso>
    let Package = Prefixed_Name(vmm, "Package") |> PrefixedName
    /// <summary>
    ///   <para>vmm:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Clase contenedora de todos los modelos generados para un
    ///    determinado proyecto."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Project entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Project">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Project</seealso>
    let Project = Prefixed_Name(vmm, "Project") |> PrefixedName
    /// <summary>
    ///   <para>vmm:connectors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Conectores de un determinado elemento de modelado"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The connectors reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#connectors">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#connectors</seealso>
    let connectors = Prefixed_Name(vmm, "connectors") |> PrefixedName
    /// <summary>
    ///   <para>vmm:containedElements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Elementos de modelado contenidos en un determinado diagrama"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The containedElements reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#containedElements">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#containedElements</seealso>
    let containedElements = Prefixed_Name(vmm, "containedElements") |> PrefixedName
    /// <summary>
    ///   <para>vmm:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Descripción de un paquete, diagrama, elemento, conector o proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The description attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#description">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#description</seealso>
    let description = Prefixed_Name(vmm, "description") |> PrefixedName
    /// <summary>
    ///   <para>vmm:diagrams</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Diagramas (modelos) includos en un paquete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The diagrams reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#diagrams">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#diagrams</seealso>
    let diagrams = Prefixed_Name(vmm, "diagrams") |> PrefixedName
    /// <summary>
    ///   <para>vmm:elements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Elementos de modelado incluidos en un paquete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The elements reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#elements">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#elements</seealso>
    let elements = Prefixed_Name(vmm, "elements") |> PrefixedName
    /// <summary>
    ///   <para>vmm:embeddedPackages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Paquetes incluidos dentro de un paquete de modelos"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The embeddedPackages reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#embeddedPackages">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#embeddedPackages</seealso>
    let embeddedPackages = Prefixed_Name(vmm, "embeddedPackages") |> PrefixedName
    /// <summary>
    ///   <para>vmm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Nombre de un paquete, diagrama, elemento, conector o proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The name attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#name">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#name</seealso>
    let name = Prefixed_Name(vmm, "name") |> PrefixedName
    /// <summary>
    ///   <para>vmm:packages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Paquetes de modelos de un determinado proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The packages reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#packages">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#packages</seealso>
    let packages = Prefixed_Name(vmm, "packages") |> PrefixedName
    /// <summary>
    ///   <para>vmm:projects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proyectos registrados en la herramienta de modelado visual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The projects reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#projects">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#projects</seealso>
    let projects = Prefixed_Name(vmm, "projects") |> PrefixedName
    /// <summary>
    ///   <para>vmm:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ruizrube">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ruizrube</seealso>
    let ruizrube = Prefixed_Name(vmm, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>vmm:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Elemento destino de un conector entre dos elementos de modelado"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The target reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#target">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#target</seealso>
    let target = Prefixed_Name(vmm, "target") |> PrefixedName
    /// <summary>
    ///   <para>vmm:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Tipo de un diagrama, elemento o conector entre elementos de modelado"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The type attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#type">http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#type</seealso>
    let type_ = Prefixed_Name(vmm, "type") |> PrefixedName

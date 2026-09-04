#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vmm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#" "vmm"

    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a una determinada relación entre
    ///    dos elementos de modelado.^^xsd:string</para>
    ///   <para>rdfs:label : The Connector entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Connector">vmm:Connector</a>
    /// </summary>
    let Connector = _prefixId.prefix "Connector"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a un determinado diagrama modelado
    ///    con algún lenguaje visual.^^xsd:string</para>
    ///   <para>rdfs:label : The Diagram entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Diagram">vmm:Diagram</a>
    /// </summary>
    let Diagram = _prefixId.prefix "Diagram"
    /// <summary>
    ///   <para>rdfs:comment : Enumeración con los posibles tipos de elementos que
    ///    pueden participar en un diagrama. Casos de uso, clases o componentes
    ///    son ejemplos de tipos de elementos en modelos UML.^^xsd:string</para>
    ///   <para>rdfs:label : The Element entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Element">vmm:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:comment : Clase contenedora de todos los proyectos gestionados con
    ///    la herramienta de modelado.^^xsd:string</para>
    ///   <para>rdfs:label : The ModelRepository entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ModelRepository">vmm:ModelRepository</a>
    /// </summary>
    let ModelRepository = _prefixId.prefix "ModelRepository"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a un paquete de modelos, con el
    ///    cual organizar los diferentes modelos.^^xsd:string</para>
    ///   <para>rdfs:label : The Package entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Package">vmm:Package</a>
    /// </summary>
    let Package = _prefixId.prefix "Package"
    /// <summary>
    ///   <para>rdfs:comment : Clase contenedora de todos los modelos generados para un
    ///    determinado proyecto.^^xsd:string</para>
    ///   <para>rdfs:label : The Project entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Project">vmm:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Conectores de un determinado elemento de modelado^^xsd:string</para>
    ///   <para>rdfs:label : The connectors reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#connectors">vmm:connectors</a>
    /// </summary>
    let connectors = _prefixId.prefix "connectors"
    /// <summary>
    ///   <para>rdfs:comment : Elementos de modelado contenidos en un determinado diagrama^^xsd:string</para>
    ///   <para>rdfs:label : The containedElements reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#containedElements">vmm:containedElements</a>
    /// </summary>
    let containedElements = _prefixId.prefix "containedElements"
    /// <summary>
    ///   <para>rdfs:label : The description attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Descripción de un paquete, diagrama, elemento, conector o proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#description">vmm:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Diagramas (modelos) includos en un paquete^^xsd:string</para>
    ///   <para>rdfs:label : The diagrams reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#diagrams">vmm:diagrams</a>
    /// </summary>
    let diagrams = _prefixId.prefix "diagrams"
    /// <summary>
    ///   <para>rdfs:comment : Elementos de modelado incluidos en un paquete^^xsd:string</para>
    ///   <para>rdfs:label : The elements reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#elements">vmm:elements</a>
    /// </summary>
    let elements = _prefixId.prefix "elements"
    /// <summary>
    ///   <para>rdfs:comment : Paquetes incluidos dentro de un paquete de modelos^^xsd:string</para>
    ///   <para>rdfs:label : The embeddedPackages reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#embeddedPackages">vmm:embeddedPackages</a>
    /// </summary>
    let embeddedPackages = _prefixId.prefix "embeddedPackages"
    /// <summary>
    ///   <para>rdfs:label : The name attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Nombre de un paquete, diagrama, elemento, conector o proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#name">vmm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Paquetes de modelos de un determinado proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The packages reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#packages">vmm:packages</a>
    /// </summary>
    let packages = _prefixId.prefix "packages"
    /// <summary>
    ///   <para>rdfs:comment : Proyectos registrados en la herramienta de modelado visual^^xsd:string</para>
    ///   <para>rdfs:label : The projects reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#projects">vmm:projects</a>
    /// </summary>
    let projects = _prefixId.prefix "projects"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:comment : Elemento destino de un conector entre dos elementos de modelado^^xsd:string</para>
    ///   <para>rdfs:label : The target reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#target">vmm:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:label : The type attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Tipo de un diagrama, elemento o conector entre elementos de modelado^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#type">vmm:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"

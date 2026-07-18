namespace http.spi_fm.uca.es.spdef.models.genericTools.vmm._1._0.hash

open DoxAletheia.Rdf_Vocabulary

module vmm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName
    /// <summary>
    /// Clase que representa a una determinada relación entre
    ///    dos elementos de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Connector"></see></summary>
    let Connector = Namespaced_IRI.parse _namespace_name "Connector" |> NamespacedName
    /// <summary>
    /// Clase que representa a un determinado diagrama modelado
    ///    con algún lenguaje visual.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Diagram"></see></summary>
    let Diagram = Namespaced_IRI.parse _namespace_name "Diagram" |> NamespacedName
    /// <summary>
    /// Enumeración con los posibles tipos de elementos que
    ///    pueden participar en un diagrama. Casos de uso, clases o componentes
    ///    son ejemplos de tipos de elementos en modelos UML.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName

    /// <summary>
    /// Clase contenedora de todos los proyectos gestionados con
    ///    la herramienta de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ModelRepository"></see></summary>
    let ModelRepository =
        Namespaced_IRI.parse _namespace_name "ModelRepository" |> NamespacedName

    /// <summary>
    /// Clase que representa a un paquete de modelos, con el
    ///    cual organizar los diferentes modelos.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Package"></see></summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName
    /// <summary>
    /// Clase contenedora de todos los modelos generados para un
    ///    determinado proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// Conectores de un determinado elemento de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#connectors"></see></summary>
    let connectors = Namespaced_IRI.parse _namespace_name "connectors" |> NamespacedName

    /// <summary>
    /// Elementos de modelado contenidos en un determinado diagrama
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#containedElements"></see></summary>
    let containedElements =
        Namespaced_IRI.parse _namespace_name "containedElements" |> NamespacedName

    /// <summary>
    /// Descripción de un paquete, diagrama, elemento, conector o proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Diagramas (modelos) includos en un paquete
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#diagrams"></see></summary>
    let diagrams = Namespaced_IRI.parse _namespace_name "diagrams" |> NamespacedName
    /// <summary>
    /// Elementos de modelado incluidos en un paquete
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#elements"></see></summary>
    let elements = Namespaced_IRI.parse _namespace_name "elements" |> NamespacedName

    /// <summary>
    /// Paquetes incluidos dentro de un paquete de modelos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#embeddedPackages"></see></summary>
    let embeddedPackages =
        Namespaced_IRI.parse _namespace_name "embeddedPackages" |> NamespacedName

    /// <summary>
    /// Nombre de un paquete, diagrama, elemento, conector o proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Paquetes de modelos de un determinado proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#packages"></see></summary>
    let packages = Namespaced_IRI.parse _namespace_name "packages" |> NamespacedName
    /// <summary>
    /// Proyectos registrados en la herramienta de modelado visual
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#projects"></see></summary>
    let projects = Namespaced_IRI.parse _namespace_name "projects" |> NamespacedName
    /// <summary>
    /// Elemento destino de un conector entre dos elementos de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName
    /// <summary>
    /// Tipo de un diagrama, elemento o conector entre elementos de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

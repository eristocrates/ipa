namespace http.spi_fm.uca.es.spdef.models.genericTools.vmm._1._0.hash

open DoxAletheia

module vmm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    /// Clase que representa a una determinada relación entre
    ///    dos elementos de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Connector"></see></summary>
    let Connector = _prefix "Connector"
    /// <summary>
    /// Clase que representa a un determinado diagrama modelado
    ///    con algún lenguaje visual.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Diagram"></see></summary>
    let Diagram = _prefix "Diagram"
    /// <summary>
    /// Enumeración con los posibles tipos de elementos que
    ///    pueden participar en un diagrama. Casos de uso, clases o componentes
    ///    son ejemplos de tipos de elementos en modelos UML.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Element"></see></summary>
    let Element = _prefix "Element"
    /// <summary>
    /// Clase contenedora de todos los proyectos gestionados con
    ///    la herramienta de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#ModelRepository"></see></summary>
    let ModelRepository = _prefix "ModelRepository"
    /// <summary>
    /// Clase que representa a un paquete de modelos, con el
    ///    cual organizar los diferentes modelos.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Package"></see></summary>
    let Package = _prefix "Package"
    /// <summary>
    /// Clase contenedora de todos los modelos generados para un
    ///    determinado proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Conectores de un determinado elemento de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#connectors"></see></summary>
    let connectors = _prefix "connectors"
    /// <summary>
    /// Elementos de modelado contenidos en un determinado diagrama
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#containedElements"></see></summary>
    let containedElements = _prefix "containedElements"
    /// <summary>
    /// Descripción de un paquete, diagrama, elemento, conector o proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Diagramas (modelos) includos en un paquete
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#diagrams"></see></summary>
    let diagrams = _prefix "diagrams"
    /// <summary>
    /// Elementos de modelado incluidos en un paquete
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#elements"></see></summary>
    let elements = _prefix "elements"
    /// <summary>
    /// Paquetes incluidos dentro de un paquete de modelos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#embeddedPackages"></see></summary>
    let embeddedPackages = _prefix "embeddedPackages"
    /// <summary>
    /// Nombre de un paquete, diagrama, elemento, conector o proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Paquetes de modelos de un determinado proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#packages"></see></summary>
    let packages = _prefix "packages"
    /// <summary>
    /// Proyectos registrados en la herramienta de modelado visual
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#projects"></see></summary>
    let projects = _prefix "projects"
    /// <summary>
    /// Elemento destino de un conector entre dos elementos de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// Tipo de un diagrama, elemento o conector entre elementos de modelado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#type"></see></summary>
    let type_ = _prefix "type"

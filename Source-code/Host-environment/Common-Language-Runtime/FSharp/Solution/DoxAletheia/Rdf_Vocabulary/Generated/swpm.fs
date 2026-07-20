namespace http.spi_fm.uca.es.spdef.models.deployment.swpm._1._0.hash

open DoxAletheia

module swpm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    /// Clase que representa la base de código de un proyecto
    ///    software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#CodeWorkProduct"></see></summary>
    let CodeWorkProduct = _prefix "CodeWorkProduct"
    /// <summary>
    /// Clase abstracta que representa un producto interno al
    ///    desarrollo o mantenimiento de software. Puede ser de tipo documental
    ///    o de código.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#InternalProduct"></see></summary>
    let InternalProduct = _prefix "InternalProduct"
    /// <summary>
    /// Clase abstracta que representa un producto de trabajo
    ///    desarrollado durante el transcurso de un proyecto software y con
    ///    valor para terceros.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DeliverableProduct"></see></summary>
    let DeliverableProduct = _prefix "DeliverableProduct"
    /// <summary>
    /// Clase abstracta y similar al concepto de WorkProduct en
    ///    SPEM que representa un determinado producto generado o
    ///    mantenido durante el proceso software. Se distinguen entre productos
    ///    entregables o internos.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#WorkProduct"></see></summary>
    let WorkProduct = _prefix "WorkProduct"
    /// <summary>
    /// Clase que representa un documento técnico de trabajo.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DocumentaryWorkProduct"></see></summary>
    let DocumentaryWorkProduct = _prefix "DocumentaryWorkProduct"
    /// <summary>
    /// Clase que representa un modelo diseñado haciendo uso un
    ///    lenguaje de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Clase contenedora de todos los productos de trabajo de
    ///    un proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Clase que representa una sección dentro de un
    ///    determinado documento generado durante el proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// Clase que representa un determinado paquete de código
    ///    fuente basado en algún lenguaje de programación.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#SourcePackage"></see></summary>
    let SourcePackage = _prefix "SourcePackage"
    /// <summary>
    /// Clase que representa una especificación textual de algún
    ///    aspecto del proyecto software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Specification"></see></summary>
    let Specification = _prefix "Specification"
    /// <summary>
    /// Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Secciones incluidas dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedSections"></see></summary>
    let embeddedSections = _prefix "embeddedSections"
    /// <summary>
    /// Productos de trabajo incluidos dentro de un producto entregable
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedWorkproducts"></see></summary>
    let embeddedWorkproducts = _prefix "embeddedWorkproducts"
    /// <summary>
    /// Modelos de Ingeniería del Software incluidos dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#models"></see></summary>
    let models = _prefix "models"
    /// <summary>
    /// Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Orden de la sección dentro de un producto de trabajo de tipo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Paquetes existentes en un producto de trabajo de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#packages"></see></summary>
    let packages = _prefix "packages"
    /// <summary>
    /// Secciones dentro de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#sections"></see></summary>
    let sections = _prefix "sections"
    /// <summary>
    /// Especificaciones, no basadas en modelos, incluidas dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#specifications"></see></summary>
    let specifications = _prefix "specifications"
    /// <summary>
    /// Tipo de un modelo, especificación, producto entregable o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Productos de trabajo asociados a un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#workproducts"></see></summary>
    let workproducts = _prefix "workproducts"

namespace http.spi_fm.uca.es.spdef.models.deployment.swpm._1._0.hash

open DoxAletheia.Rdf_Vocabulary

module swpm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName

    /// <summary>
    /// Clase que representa la base de código de un proyecto
    ///    software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#CodeWorkProduct"></see></summary>
    let CodeWorkProduct =
        Namespaced_IRI.parse _namespace_name "CodeWorkProduct" |> NamespacedName

    /// <summary>
    /// Clase abstracta que representa un producto interno al
    ///    desarrollo o mantenimiento de software. Puede ser de tipo documental
    ///    o de código.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#InternalProduct"></see></summary>
    let InternalProduct =
        Namespaced_IRI.parse _namespace_name "InternalProduct" |> NamespacedName

    /// <summary>
    /// Clase abstracta que representa un producto de trabajo
    ///    desarrollado durante el transcurso de un proyecto software y con
    ///    valor para terceros.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DeliverableProduct"></see></summary>
    let DeliverableProduct =
        Namespaced_IRI.parse _namespace_name "DeliverableProduct" |> NamespacedName

    /// <summary>
    /// Clase abstracta y similar al concepto de WorkProduct en
    ///    SPEM que representa un determinado producto generado o
    ///    mantenido durante el proceso software. Se distinguen entre productos
    ///    entregables o internos.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#WorkProduct"></see></summary>
    let WorkProduct =
        Namespaced_IRI.parse _namespace_name "WorkProduct" |> NamespacedName

    /// <summary>
    /// Clase que representa un documento técnico de trabajo.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DocumentaryWorkProduct"></see></summary>
    let DocumentaryWorkProduct =
        Namespaced_IRI.parse _namespace_name "DocumentaryWorkProduct" |> NamespacedName

    /// <summary>
    /// Clase que representa un modelo diseñado haciendo uso un
    ///    lenguaje de modelado.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// Clase contenedora de todos los productos de trabajo de
    ///    un proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// Clase que representa una sección dentro de un
    ///    determinado documento generado durante el proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName

    /// <summary>
    /// Clase que representa un determinado paquete de código
    ///    fuente basado en algún lenguaje de programación.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#SourcePackage"></see></summary>
    let SourcePackage =
        Namespaced_IRI.parse _namespace_name "SourcePackage" |> NamespacedName

    /// <summary>
    /// Clase que representa una especificación textual de algún
    ///    aspecto del proyecto software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Specification"></see></summary>
    let Specification =
        Namespaced_IRI.parse _namespace_name "Specification" |> NamespacedName

    /// <summary>
    /// Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Secciones incluidas dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedSections"></see></summary>
    let embeddedSections =
        Namespaced_IRI.parse _namespace_name "embeddedSections" |> NamespacedName

    /// <summary>
    /// Productos de trabajo incluidos dentro de un producto entregable
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedWorkproducts"></see></summary>
    let embeddedWorkproducts =
        Namespaced_IRI.parse _namespace_name "embeddedWorkproducts" |> NamespacedName

    /// <summary>
    /// Modelos de Ingeniería del Software incluidos dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#models"></see></summary>
    let models = Namespaced_IRI.parse _namespace_name "models" |> NamespacedName
    /// <summary>
    /// Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Orden de la sección dentro de un producto de trabajo de tipo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// Paquetes existentes en un producto de trabajo de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#packages"></see></summary>
    let packages = Namespaced_IRI.parse _namespace_name "packages" |> NamespacedName
    /// <summary>
    /// Secciones dentro de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#sections"></see></summary>
    let sections = Namespaced_IRI.parse _namespace_name "sections" |> NamespacedName

    /// <summary>
    /// Especificaciones, no basadas en modelos, incluidas dentro de una sección de un producto de trabajo documental
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#specifications"></see></summary>
    let specifications =
        Namespaced_IRI.parse _namespace_name "specifications" |> NamespacedName

    /// <summary>
    /// Tipo de un modelo, especificación, producto entregable o paquete de código fuente
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// Productos de trabajo asociados a un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#workproducts"></see></summary>
    let workproducts =
        Namespaced_IRI.parse _namespace_name "workproducts" |> NamespacedName

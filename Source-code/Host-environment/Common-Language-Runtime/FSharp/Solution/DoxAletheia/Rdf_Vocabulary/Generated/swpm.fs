namespace http.spi_fm.uca.es.spdef.models.deployment.swpm._1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swpm =
    let _namespace_iri = Namespace_Iri swpm |> NamespaceIRI
    /// <summary>
    ///   <para>swpm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente</para>
    /// labels<para>The name attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#name">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#name</seealso>
    let name = Prefixed_Name(swpm, "name") |> PrefixedName
    /// <summary>
    ///   <para>swpm:workproducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Productos de trabajo asociados a un proyecto</para>
    /// labels<para>The workproducts reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#workproducts">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#workproducts</seealso>
    let workproducts = Prefixed_Name(swpm, "workproducts") |> PrefixedName
    /// <summary>
    ///   <para>swpm:CodeWorkProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa la base de código de un proyecto
    ///    software.</para>
    /// labels<para>The CodeWorkProduct entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#CodeWorkProduct">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#CodeWorkProduct</seealso>
    let CodeWorkProduct = Prefixed_Name(swpm, "CodeWorkProduct") |> PrefixedName
    /// <summary>
    ///   <para>swpm:DeliverableProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase abstracta que representa un producto de trabajo
    ///    desarrollado durante el transcurso de un proyecto software y con
    ///    valor para terceros.</para>
    /// labels<para>The DeliverableProduct entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DeliverableProduct">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DeliverableProduct</seealso>
    let DeliverableProduct = Prefixed_Name(swpm, "DeliverableProduct") |> PrefixedName

    /// <summary>
    ///   <para>swpm:DocumentaryWorkProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa un documento técnico de trabajo.</para>
    /// labels<para>The DocumentaryWorkProduct entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DocumentaryWorkProduct">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DocumentaryWorkProduct</seealso>
    let DocumentaryWorkProduct =
        Prefixed_Name(swpm, "DocumentaryWorkProduct") |> PrefixedName

    /// <summary>
    ///   <para>swpm:WorkProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase abstracta y similar al concepto de WorkProduct en
    ///    SPEM que representa un determinado producto generado o
    ///    mantenido durante el proceso software. Se distinguen entre productos
    ///    entregables o internos.</para>
    /// labels<para>The WorkProduct entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#WorkProduct">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#WorkProduct</seealso>
    let WorkProduct = Prefixed_Name(swpm, "WorkProduct") |> PrefixedName
    /// <summary>
    ///   <para>swpm:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa un modelo diseñado haciendo uso un
    ///    lenguaje de modelado.</para>
    /// labels<para>The Model entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Model">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Model</seealso>
    let Model = Prefixed_Name(swpm, "Model") |> PrefixedName
    /// <summary>
    ///   <para>swpm:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase contenedora de todos los productos de trabajo de
    ///    un proyecto.</para>
    /// labels<para>The Project entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Project">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Project</seealso>
    let Project = Prefixed_Name(swpm, "Project") |> PrefixedName
    /// <summary>
    ///   <para>swpm:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa una sección dentro de un
    ///    determinado documento generado durante el proyecto.</para>
    /// labels<para>The Section entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Section">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Section</seealso>
    let Section = Prefixed_Name(swpm, "Section") |> PrefixedName
    /// <summary>
    ///   <para>swpm:Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa una especificación textual de algún
    ///    aspecto del proyecto software.</para>
    /// labels<para>The Specification entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Specification">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Specification</seealso>
    let Specification = Prefixed_Name(swpm, "Specification") |> PrefixedName
    /// <summary>
    ///   <para>swpm:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente</para>
    /// labels<para>The description attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#description">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#description</seealso>
    let description = Prefixed_Name(swpm, "description") |> PrefixedName
    /// <summary>
    ///   <para>swpm:SourcePackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa un determinado paquete de código
    ///    fuente basado en algún lenguaje de programación.</para>
    /// labels<para>The SourcePackage entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#SourcePackage">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#SourcePackage</seealso>
    let SourcePackage = Prefixed_Name(swpm, "SourcePackage") |> PrefixedName
    /// <summary>
    ///   <para>swpm:embeddedSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Secciones incluidas dentro de una sección de un producto de trabajo documental</para>
    /// labels<para>The embeddedSections reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedSections">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedSections</seealso>
    let embeddedSections = Prefixed_Name(swpm, "embeddedSections") |> PrefixedName
    /// <summary>
    ///   <para>swpm:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Orden de la sección dentro de un producto de trabajo de tipo documental</para>
    /// labels<para>The order attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#order">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#order</seealso>
    let order = Prefixed_Name(swpm, "order") |> PrefixedName

    /// <summary>
    ///   <para>swpm:embeddedWorkproducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Productos de trabajo incluidos dentro de un producto entregable</para>
    /// labels<para>The embeddedWorkproducts reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedWorkproducts">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedWorkproducts</seealso>
    let embeddedWorkproducts =
        Prefixed_Name(swpm, "embeddedWorkproducts") |> PrefixedName

    /// <summary>
    ///   <para>swpm:models</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Modelos de Ingeniería del Software incluidos dentro de una sección de un producto de trabajo documental</para>
    /// labels<para>The models reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#models">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#models</seealso>
    let models = Prefixed_Name(swpm, "models") |> PrefixedName
    /// <summary>
    ///   <para>swpm:packages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Paquetes existentes en un producto de trabajo de código fuente</para>
    /// labels<para>The packages reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#packages">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#packages</seealso>
    let packages = Prefixed_Name(swpm, "packages") |> PrefixedName
    /// <summary>
    ///   <para>swpm:specifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Especificaciones, no basadas en modelos, incluidas dentro de una sección de un producto de trabajo documental</para>
    /// labels<para>The specifications reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#specifications">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#specifications</seealso>
    let specifications = Prefixed_Name(swpm, "specifications") |> PrefixedName
    /// <summary>
    ///   <para>swpm:sections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Secciones dentro de un producto de trabajo documental</para>
    /// labels<para>The sections reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#sections">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#sections</seealso>
    let sections = Prefixed_Name(swpm, "sections") |> PrefixedName
    /// <summary>
    ///   <para>swpm:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tipo de un modelo, especificación, producto entregable o paquete de código fuente</para>
    /// labels<para>The type attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#type">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#type</seealso>
    let type_ = Prefixed_Name(swpm, "type") |> PrefixedName
    /// <summary>
    ///   <para>swpm:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#ruizrube">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#ruizrube</seealso>
    let ruizrube = Prefixed_Name(swpm, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>swpm:InternalProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase abstracta que representa un producto interno al
    ///    desarrollo o mantenimiento de software. Puede ser de tipo documental
    ///    o de código.</para>
    /// labels<para>The InternalProduct entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#InternalProduct">http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#InternalProduct</seealso>
    let InternalProduct = Prefixed_Name(swpm, "InternalProduct") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swpm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#" "swpm"

    /// <summary>
    ///   <para>rdfs:comment : Clase que representa la base de código de un proyecto
    ///    software.^^xsd:string</para>
    ///   <para>rdfs:label : The CodeWorkProduct entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#CodeWorkProduct">swpm:CodeWorkProduct</a>
    /// </summary>
    let CodeWorkProduct = _prefixId.prefix "CodeWorkProduct"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta que representa un producto de trabajo
    ///    desarrollado durante el transcurso de un proyecto software y con
    ///    valor para terceros.^^xsd:string</para>
    ///   <para>rdfs:label : The DeliverableProduct entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DeliverableProduct">swpm:DeliverableProduct</a>
    /// </summary>
    let DeliverableProduct = _prefixId.prefix "DeliverableProduct"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa un documento técnico de trabajo.^^xsd:string</para>
    ///   <para>rdfs:label : The DocumentaryWorkProduct entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#DocumentaryWorkProduct">swpm:DocumentaryWorkProduct</a>
    /// </summary>
    let DocumentaryWorkProduct = _prefixId.prefix "DocumentaryWorkProduct"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta que representa un producto interno al
    ///    desarrollo o mantenimiento de software. Puede ser de tipo documental
    ///    o de código.^^xsd:string</para>
    ///   <para>rdfs:label : The InternalProduct entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#InternalProduct">swpm:InternalProduct</a>
    /// </summary>
    let InternalProduct = _prefixId.prefix "InternalProduct"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa un modelo diseñado haciendo uso un
    ///    lenguaje de modelado.^^xsd:string</para>
    ///   <para>rdfs:label : The Model entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Model">swpm:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:comment : Clase contenedora de todos los productos de trabajo de
    ///    un proyecto.^^xsd:string</para>
    ///   <para>rdfs:label : The Project entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Project">swpm:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa una sección dentro de un
    ///    determinado documento generado durante el proyecto.^^xsd:string</para>
    ///   <para>rdfs:label : The Section entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Section">swpm:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa un determinado paquete de código
    ///    fuente basado en algún lenguaje de programación.^^xsd:string</para>
    ///   <para>rdfs:label : The SourcePackage entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#SourcePackage">swpm:SourcePackage</a>
    /// </summary>
    let SourcePackage = _prefixId.prefix "SourcePackage"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa una especificación textual de algún
    ///    aspecto del proyecto software.^^xsd:string</para>
    ///   <para>rdfs:label : The Specification entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#Specification">swpm:Specification</a>
    /// </summary>
    let Specification = _prefixId.prefix "Specification"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta y similar al concepto de WorkProduct en
    ///    SPEM que representa un determinado producto generado o
    ///    mantenido durante el proceso software. Se distinguen entre productos
    ///    entregables o internos.^^xsd:string</para>
    ///   <para>rdfs:label : The WorkProduct entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#WorkProduct">swpm:WorkProduct</a>
    /// </summary>
    let WorkProduct = _prefixId.prefix "WorkProduct"
    /// <summary>
    ///   <para>rdfs:label : The description attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#description">swpm:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Secciones incluidas dentro de una sección de un producto de trabajo documental^^xsd:string</para>
    ///   <para>rdfs:label : The embeddedSections reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedSections">swpm:embeddedSections</a>
    /// </summary>
    let embeddedSections = _prefixId.prefix "embeddedSections"
    /// <summary>
    ///   <para>rdfs:comment : Productos de trabajo incluidos dentro de un producto entregable^^xsd:string</para>
    ///   <para>rdfs:label : The embeddedWorkproducts reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#embeddedWorkproducts">swpm:embeddedWorkproducts</a>
    /// </summary>
    let embeddedWorkproducts = _prefixId.prefix "embeddedWorkproducts"
    /// <summary>
    ///   <para>rdfs:comment : Modelos de Ingeniería del Software incluidos dentro de una sección de un producto de trabajo documental^^xsd:string</para>
    ///   <para>rdfs:label : The models reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#models">swpm:models</a>
    /// </summary>
    let models = _prefixId.prefix "models"
    /// <summary>
    ///   <para>rdfs:comment : Descripción de un proyecto, producto de trabajo, sección, modelo, especificación o paquete de código fuente^^xsd:string</para>
    ///   <para>rdfs:label : The name attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#name">swpm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Orden de la sección dentro de un producto de trabajo de tipo documental^^xsd:string</para>
    ///   <para>rdfs:label : The order attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#order">swpm:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:comment : Paquetes existentes en un producto de trabajo de código fuente^^xsd:string</para>
    ///   <para>rdfs:label : The packages reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#packages">swpm:packages</a>
    /// </summary>
    let packages = _prefixId.prefix "packages"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:comment : Secciones dentro de un producto de trabajo documental^^xsd:string</para>
    ///   <para>rdfs:label : The sections reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#sections">swpm:sections</a>
    /// </summary>
    let sections = _prefixId.prefix "sections"
    /// <summary>
    ///   <para>rdfs:comment : Especificaciones, no basadas en modelos, incluidas dentro de una sección de un producto de trabajo documental^^xsd:string</para>
    ///   <para>rdfs:label : The specifications reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#specifications">swpm:specifications</a>
    /// </summary>
    let specifications = _prefixId.prefix "specifications"
    /// <summary>
    ///   <para>rdfs:label : The type attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Tipo de un modelo, especificación, producto entregable o paquete de código fuente^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#type">swpm:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : Productos de trabajo asociados a un proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The workproducts reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#workproducts">swpm:workproducts</a>
    /// </summary>
    let workproducts = _prefixId.prefix "workproducts"

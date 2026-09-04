#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wikim =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#" "wikim"

    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a un artículo dentro de la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The Article entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Article">wikim:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a una categoría dentro una
    ///    instancia de la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The Category entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Category">wikim:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa a un determinado archivo binario
    ///    almacenado en la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The File entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#File">wikim:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa la inclusión de una imagen dentro
    ///    de un artículo wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The Image entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Image">wikim:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa el item de una lista.^^xsd:string</para>
    ///   <para>rdfs:label : The Item entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Item">wikim:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa un lista de items.^^xsd:string</para>
    ///   <para>rdfs:label : The ItemList entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ItemList">wikim:ItemList</a>
    /// </summary>
    let ItemList = _prefixId.prefix "ItemList"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa un párrafo de texto.^^xsd:string</para>
    ///   <para>rdfs:label : The Paragraph entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Paragraph">wikim:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>rdfs:comment : Clase que permite declarar una sección dentro de un
    ///    artículo de la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The Section entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Section">wikim:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta que se especializa en cada tipo de
    ///    contenido que puede incluirse dentro de una sección de un artículo.^^xsd:string</para>
    ///   <para>rdfs:label : The SectionContent entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#SectionContent">wikim:SectionContent</a>
    /// </summary>
    let SectionContent = _prefixId.prefix "SectionContent"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa al usuario y la página del mismo
    ///    dentro de la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The User entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#User">wikim:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta que representa a un tipo de contenido
    ///    concreto que puede almacenar una wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The WikiContent entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiContent">wikim:WikiContent</a>
    /// </summary>
    let WikiContent = _prefixId.prefix "WikiContent"
    /// <summary>
    ///   <para>rdfs:comment : Clase contenedora de todos los contenidos existentes en
    ///    la wiki.^^xsd:string</para>
    ///   <para>rdfs:label : The WikiDatabase entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiDatabase">wikim:WikiDatabase</a>
    /// </summary>
    let WikiDatabase = _prefixId.prefix "WikiDatabase"
    /// <summary>
    ///   <para>rdfs:comment : Texto alternativo que disponen las imágenes^^xsd:string</para>
    ///   <para>rdfs:label : The alternative attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#alternative">wikim:alternative</a>
    /// </summary>
    let alternative = _prefixId.prefix "alternative"
    /// <summary>
    ///   <para>rdfs:comment : Categorías de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The categories reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#categories">wikim:categories</a>
    /// </summary>
    let categories = _prefixId.prefix "categories"
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Secciones incluidas dentro de otra sección de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The embeddedSections reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#embeddedSections">wikim:embeddedSections</a>
    /// </summary>
    let embeddedSections = _prefixId.prefix "embeddedSections"
    /// <summary>
    ///   <para>rdfs:comment : Items que forman parte de una lista de items de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The items reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#items">wikim:items</a>
    /// </summary>
    let items = _prefixId.prefix "items"
    /// <summary>
    ///   <para>rdfs:label : The name attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Nombre de un contenido, sección o lista de elementos dentro de un artículo wiki^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#name">wikim:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Orden de un contenido dentro de una sección de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The order attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#order">wikim:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:comment : Categorías padre de una dada^^xsd:string</para>
    ///   <para>rdfs:label : The parentCategory reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#parentCategory">wikim:parentCategory</a>
    /// </summary>
    let parentCategory = _prefixId.prefix "parentCategory"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:comment : Contenidos incluidos dentro de una sección de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The contents reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sectionContents">wikim:sectionContents</a>
    /// </summary>
    let sectionContents = _prefixId.prefix "sectionContents"
    /// <summary>
    ///   <para>rdfs:comment : Secciones incluidas dentro de un artículo wiki^^xsd:string</para>
    ///   <para>rdfs:label : The sections reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sections">wikim:sections</a>
    /// </summary>
    let sections = _prefixId.prefix "sections"
    /// <summary>
    ///   <para>rdfs:comment : Texto que aparece dentro de una sección, párrafo o item de un artículo de la wiki^^xsd:string</para>
    ///   <para>rdfs:label : The text attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#text">wikim:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:comment : Dirección web de una imagen^^xsd:string</para>
    ///   <para>rdfs:label : The uri attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#uri">wikim:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>rdfs:comment : Contenidos existentes en el sistema wiki^^xsd:string</para>
    ///   <para>rdfs:label : The wikiContents reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#wikiContents">wikim:wikiContents</a>
    /// </summary>
    let wikiContents = _prefixId.prefix "wikiContents"

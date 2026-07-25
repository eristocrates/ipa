namespace http.spi_fm.uca.es.spdef.models.genericTools.wikim._1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wikim =
    let _namespace_iri = Namespace_Iri wikim |> NamespaceIRI
    /// <summary>
    ///   <para>wikim:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa a un determinado archivo binario
    ///    almacenado en la wiki.</para>
    /// labels<para>The File entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#File">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#File</seealso>
    let File = Prefixed_Name(wikim, "File") |> PrefixedName
    /// <summary>
    ///   <para>wikim:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Texto alternativo que disponen las imágenes</para>
    /// labels<para>The alternative attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#alternative">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#alternative</seealso>
    let alternative = Prefixed_Name(wikim, "alternative") |> PrefixedName
    /// <summary>
    ///   <para>wikim:categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Categorías de un artículo wiki</para>
    /// labels<para>The categories reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#categories">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#categories</seealso>
    let categories = Prefixed_Name(wikim, "categories") |> PrefixedName
    /// <summary>
    ///   <para>wikim:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Items que forman parte de una lista de items de un artículo wiki</para>
    /// labels<para>The items reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#items">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#items</seealso>
    let items = Prefixed_Name(wikim, "items") |> PrefixedName
    /// <summary>
    ///   <para>wikim:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Orden de un contenido dentro de una sección de un artículo wiki</para>
    /// labels<para>The order attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#order">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#order</seealso>
    let order = Prefixed_Name(wikim, "order") |> PrefixedName
    /// <summary>
    ///   <para>wikim:sectionContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Contenidos incluidos dentro de una sección de un artículo wiki</para>
    /// labels<para>The contents reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sectionContents">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sectionContents</seealso>
    let sectionContents = Prefixed_Name(wikim, "sectionContents") |> PrefixedName
    /// <summary>
    ///   <para>wikim:wikiContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Contenidos existentes en el sistema wiki</para>
    /// labels<para>The wikiContents reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#wikiContents">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#wikiContents</seealso>
    let wikiContents = Prefixed_Name(wikim, "wikiContents") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa a una categoría dentro una
    ///    instancia de la wiki.</para>
    /// labels<para>The Category entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Category">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Category</seealso>
    let Category = Prefixed_Name(wikim, "Category") |> PrefixedName
    /// <summary>
    ///   <para>wikim:SectionContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase abstracta que se especializa en cada tipo de
    ///    contenido que puede incluirse dentro de una sección de un artículo.</para>
    /// labels<para>The SectionContent entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#SectionContent">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#SectionContent</seealso>
    let SectionContent = Prefixed_Name(wikim, "SectionContent") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa el item de una lista.</para>
    /// labels<para>The Item entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Item">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Item</seealso>
    let Item = Prefixed_Name(wikim, "Item") |> PrefixedName
    /// <summary>
    ///   <para>wikim:ItemList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa un lista de items.</para>
    /// labels<para>The ItemList entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ItemList">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ItemList</seealso>
    let ItemList = Prefixed_Name(wikim, "ItemList") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa un párrafo de texto.</para>
    /// labels<para>The Paragraph entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Paragraph">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Paragraph</seealso>
    let Paragraph = Prefixed_Name(wikim, "Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que permite declarar una sección dentro de un
    ///    artículo de la wiki.</para>
    /// labels<para>The Section entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Section">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Section</seealso>
    let Section = Prefixed_Name(wikim, "Section") |> PrefixedName
    /// <summary>
    ///   <para>wikim:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa al usuario y la página del mismo
    ///    dentro de la wiki.</para>
    /// labels<para>The User entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#User">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#User</seealso>
    let User = Prefixed_Name(wikim, "User") |> PrefixedName
    /// <summary>
    ///   <para>wikim:WikiDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase contenedora de todos los contenidos existentes en
    ///    la wiki.</para>
    /// labels<para>The WikiDatabase entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiDatabase">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiDatabase</seealso>
    let WikiDatabase = Prefixed_Name(wikim, "WikiDatabase") |> PrefixedName
    /// <summary>
    ///   <para>wikim:embeddedSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Secciones incluidas dentro de otra sección de un artículo wiki</para>
    /// labels<para>The embeddedSections reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#embeddedSections">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#embeddedSections</seealso>
    let embeddedSections = Prefixed_Name(wikim, "embeddedSections") |> PrefixedName
    /// <summary>
    ///   <para>wikim:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nombre de un contenido, sección o lista de elementos dentro de un artículo wiki</para>
    /// labels<para>The name attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#name">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#name</seealso>
    let name = Prefixed_Name(wikim, "name") |> PrefixedName
    /// <summary>
    ///   <para>wikim:parentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Categorías padre de una dada</para>
    /// labels<para>The parentCategory reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#parentCategory">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#parentCategory</seealso>
    let parentCategory = Prefixed_Name(wikim, "parentCategory") |> PrefixedName
    /// <summary>
    ///   <para>wikim:sections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Secciones incluidas dentro de un artículo wiki</para>
    /// labels<para>The sections reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sections">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sections</seealso>
    let sections = Prefixed_Name(wikim, "sections") |> PrefixedName
    /// <summary>
    ///   <para>wikim:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Texto que aparece dentro de una sección, párrafo o item de un artículo de la wiki</para>
    /// labels<para>The text attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#text">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#text</seealso>
    let text = Prefixed_Name(wikim, "text") |> PrefixedName
    /// <summary>
    ///   <para>wikim:description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#description">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#description</seealso>
    let description = Prefixed_Name(wikim, "description") |> PrefixedName
    /// <summary>
    ///   <para>wikim:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Dirección web de una imagen</para>
    /// labels<para>The uri attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#uri">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#uri</seealso>
    let uri = Prefixed_Name(wikim, "uri") |> PrefixedName
    /// <summary>
    ///   <para>wikim:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ruizrube">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ruizrube</seealso>
    let ruizrube = Prefixed_Name(wikim, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa a un artículo dentro de la wiki.</para>
    /// labels<para>The Article entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Article">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Article</seealso>
    let Article = Prefixed_Name(wikim, "Article") |> PrefixedName
    /// <summary>
    ///   <para>wikim:WikiContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase abstracta que representa a un tipo de contenido
    ///    concreto que puede almacenar una wiki.</para>
    /// labels<para>The WikiContent entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiContent">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiContent</seealso>
    let WikiContent = Prefixed_Name(wikim, "WikiContent") |> PrefixedName
    /// <summary>
    ///   <para>wikim:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase que representa la inclusión de una imagen dentro
    ///    de un artículo wiki.</para>
    /// labels<para>The Image entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Image">http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Image</seealso>
    let Image = Prefixed_Name(wikim, "Image") |> PrefixedName

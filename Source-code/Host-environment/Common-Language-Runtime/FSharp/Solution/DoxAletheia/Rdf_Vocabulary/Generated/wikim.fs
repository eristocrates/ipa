namespace http.spi_fm.uca.es.spdef.models.genericTools.wikim._1._0.hash

open DoxAletheia.Rdf_Vocabulary

module wikim =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName
    /// <summary>
    /// Clase que representa a un artículo dentro de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// Clase abstracta que representa a un tipo de contenido
    ///    concreto que puede almacenar una wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiContent"></see></summary>
    let WikiContent =
        Namespaced_IRI.parse _namespace_name "WikiContent" |> NamespacedName

    /// <summary>
    /// Clase que representa a una categoría dentro una
    ///    instancia de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// Clase que representa a un determinado archivo binario
    ///    almacenado en la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName
    /// <summary>
    /// Clase que representa la inclusión de una imagen dentro
    ///    de un artículo wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// Clase abstracta que se especializa en cada tipo de
    ///    contenido que puede incluirse dentro de una sección de un artículo.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#SectionContent"></see></summary>
    let SectionContent =
        Namespaced_IRI.parse _namespace_name "SectionContent" |> NamespacedName

    /// <summary>
    /// Clase que representa el item de una lista.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// Clase que representa un lista de items.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ItemList"></see></summary>
    let ItemList = Namespaced_IRI.parse _namespace_name "ItemList" |> NamespacedName
    /// <summary>
    /// Clase que representa un párrafo de texto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Paragraph"></see></summary>
    let Paragraph = Namespaced_IRI.parse _namespace_name "Paragraph" |> NamespacedName
    /// <summary>
    /// Clase que permite declarar una sección dentro de un
    ///    artículo de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    /// Clase que representa al usuario y la página del mismo
    ///    dentro de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    /// Clase contenedora de todos los contenidos existentes en
    ///    la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiDatabase"></see></summary>
    let WikiDatabase =
        Namespaced_IRI.parse _namespace_name "WikiDatabase" |> NamespacedName

    /// <summary>
    /// Texto alternativo que disponen las imágenes
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#alternative"></see></summary>
    let alternative =
        Namespaced_IRI.parse _namespace_name "alternative" |> NamespacedName

    /// <summary>
    /// Categorías de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#categories"></see></summary>
    let categories = Namespaced_IRI.parse _namespace_name "categories" |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Secciones incluidas dentro de otra sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#embeddedSections"></see></summary>
    let embeddedSections =
        Namespaced_IRI.parse _namespace_name "embeddedSections" |> NamespacedName

    /// <summary>
    /// Items que forman parte de una lista de items de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#items"></see></summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName
    /// <summary>
    /// Nombre de un contenido, sección o lista de elementos dentro de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Orden de un contenido dentro de una sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    /// Categorías padre de una dada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#parentCategory"></see></summary>
    let parentCategory =
        Namespaced_IRI.parse _namespace_name "parentCategory" |> NamespacedName

    /// <summary>
    /// Contenidos incluidos dentro de una sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sectionContents"></see></summary>
    let sectionContents =
        Namespaced_IRI.parse _namespace_name "sectionContents" |> NamespacedName

    /// <summary>
    /// Secciones incluidas dentro de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sections"></see></summary>
    let sections = Namespaced_IRI.parse _namespace_name "sections" |> NamespacedName
    /// <summary>
    /// Texto que aparece dentro de una sección, párrafo o item de un artículo de la wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// Dirección web de una imagen
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName

    /// <summary>
    /// Contenidos existentes en el sistema wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#wikiContents"></see></summary>
    let wikiContents =
        Namespaced_IRI.parse _namespace_name "wikiContents" |> NamespacedName

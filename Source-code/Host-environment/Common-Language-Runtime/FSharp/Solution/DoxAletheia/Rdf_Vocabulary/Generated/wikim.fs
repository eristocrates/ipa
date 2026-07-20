namespace http.spi_fm.uca.es.spdef.models.genericTools.wikim._1._0.hash

open DoxAletheia

module wikim =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    /// Clase que representa a un artículo dentro de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// Clase abstracta que representa a un tipo de contenido
    ///    concreto que puede almacenar una wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiContent"></see></summary>
    let WikiContent = _prefix "WikiContent"
    /// <summary>
    /// Clase que representa a una categoría dentro una
    ///    instancia de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// Clase que representa a un determinado archivo binario
    ///    almacenado en la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// Clase que representa la inclusión de una imagen dentro
    ///    de un artículo wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// Clase abstracta que se especializa en cada tipo de
    ///    contenido que puede incluirse dentro de una sección de un artículo.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#SectionContent"></see></summary>
    let SectionContent = _prefix "SectionContent"
    /// <summary>
    /// Clase que representa el item de una lista.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// Clase que representa un lista de items.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#ItemList"></see></summary>
    let ItemList = _prefix "ItemList"
    /// <summary>
    /// Clase que representa un párrafo de texto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Paragraph"></see></summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    /// Clase que permite declarar una sección dentro de un
    ///    artículo de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// Clase que representa al usuario y la página del mismo
    ///    dentro de la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// Clase contenedora de todos los contenidos existentes en
    ///    la wiki.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#WikiDatabase"></see></summary>
    let WikiDatabase = _prefix "WikiDatabase"
    /// <summary>
    /// Texto alternativo que disponen las imágenes
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#alternative"></see></summary>
    let alternative = _prefix "alternative"
    /// <summary>
    /// Categorías de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#categories"></see></summary>
    let categories = _prefix "categories"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    /// Secciones incluidas dentro de otra sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#embeddedSections"></see></summary>
    let embeddedSections = _prefix "embeddedSections"
    /// <summary>
    /// Items que forman parte de una lista de items de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#items"></see></summary>
    let items = _prefix "items"
    /// <summary>
    /// Nombre de un contenido, sección o lista de elementos dentro de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Orden de un contenido dentro de una sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Categorías padre de una dada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#parentCategory"></see></summary>
    let parentCategory = _prefix "parentCategory"
    /// <summary>
    /// Contenidos incluidos dentro de una sección de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sectionContents"></see></summary>
    let sectionContents = _prefix "sectionContents"
    /// <summary>
    /// Secciones incluidas dentro de un artículo wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#sections"></see></summary>
    let sections = _prefix "sections"
    /// <summary>
    /// Texto que aparece dentro de una sección, párrafo o item de un artículo de la wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Dirección web de una imagen
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#uri"></see></summary>
    let uri = _prefix "uri"
    /// <summary>
    /// Contenidos existentes en el sistema wiki
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#wikiContents"></see></summary>
    let wikiContents = _prefix "wikiContents"

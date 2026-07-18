namespace http.purl.org.NET.raul.hash

open DoxAletheia.Rdf_Vocabulary

module raul =
    let _namespace_name = "http://purl.org/NET/raul#"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Button"></see>
    /// </summary>
    let Button = Namespaced_IRI.parse _namespace_name "Button" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Widget"></see>
    /// </summary>
    let Widget = Namespaced_IRI.parse _namespace_name "Widget" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#CREATEOperation"></see>
    /// </summary>
    let CREATEOperation =
        Namespaced_IRI.parse _namespace_name "CREATEOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#CRUDOperation"></see>
    /// </summary>
    let CRUDOperation =
        Namespaced_IRI.parse _namespace_name "CRUDOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Checkbox"></see>
    /// </summary>
    let Checkbox = Namespaced_IRI.parse _namespace_name "Checkbox" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#DELETEOperation"></see>
    /// </summary>
    let DELETEOperation =
        Namespaced_IRI.parse _namespace_name "DELETEOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#DynamicGroup"></see>
    /// </summary>
    let DynamicGroup =
        Namespaced_IRI.parse _namespace_name "DynamicGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Group"></see>
    /// </summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Listbox"></see>
    /// </summary>
    let Listbox = Namespaced_IRI.parse _namespace_name "Listbox" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Listitem"></see>
    /// </summary>
    let Listitem = Namespaced_IRI.parse _namespace_name "Listitem" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Page"></see>
    /// </summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#READOperation"></see>
    /// </summary>
    let READOperation =
        Namespaced_IRI.parse _namespace_name "READOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Radiobutton"></see>
    /// </summary>
    let Radiobutton =
        Namespaced_IRI.parse _namespace_name "Radiobutton" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Textbox"></see>
    /// </summary>
    let Textbox = Namespaced_IRI.parse _namespace_name "Textbox" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#UPDATEOperation"></see>
    /// </summary>
    let UPDATEOperation =
        Namespaced_IRI.parse _namespace_name "UPDATEOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#WidgetContainer"></see>
    /// </summary>
    let WidgetContainer =
        Namespaced_IRI.parse _namespace_name "WidgetContainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#action"></see>
    /// </summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#checked"></see>
    /// </summary>
    let checked_ = Namespaced_IRI.parse _namespace_name "checked" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#class"></see>
    /// </summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#command"></see>
    /// </summary>
    let command = Namespaced_IRI.parse _namespace_name "command" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#disabled"></see>
    /// </summary>
    let disabled = Namespaced_IRI.parse _namespace_name "disabled" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#group"></see>
    /// </summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#hidden"></see>
    /// </summary>
    let hidden = Namespaced_IRI.parse _namespace_name "hidden" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#isPassword"></see>
    /// </summary>
    let isPassword = Namespaced_IRI.parse _namespace_name "isPassword" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#label"></see>
    /// </summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#list"></see>
    /// </summary>
    let list = Namespaced_IRI.parse _namespace_name "list" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#maxlength"></see>
    /// </summary>
    let maxlength = Namespaced_IRI.parse _namespace_name "maxlength" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#method"></see>
    /// </summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#multiple"></see>
    /// </summary>
    let multiple = Namespaced_IRI.parse _namespace_name "multiple" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#row"></see>
    /// </summary>
    let row = Namespaced_IRI.parse _namespace_name "row" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#selected"></see>
    /// </summary>
    let selected = Namespaced_IRI.parse _namespace_name "selected" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#size"></see>
    /// </summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

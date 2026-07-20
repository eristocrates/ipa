namespace http.purl.org.NET.raul.hash

open DoxAletheia

module raul =
    let _namespace_name = "http://purl.org/NET/raul#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Button"></see>
    /// </summary>
    let Button = _prefix "Button"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Widget"></see>
    /// </summary>
    let Widget = _prefix "Widget"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#CREATEOperation"></see>
    /// </summary>
    let CREATEOperation = _prefix "CREATEOperation"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#CRUDOperation"></see>
    /// </summary>
    let CRUDOperation = _prefix "CRUDOperation"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Checkbox"></see>
    /// </summary>
    let Checkbox = _prefix "Checkbox"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#DELETEOperation"></see>
    /// </summary>
    let DELETEOperation = _prefix "DELETEOperation"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#DynamicGroup"></see>
    /// </summary>
    let DynamicGroup = _prefix "DynamicGroup"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Listbox"></see>
    /// </summary>
    let Listbox = _prefix "Listbox"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Listitem"></see>
    /// </summary>
    let Listitem = _prefix "Listitem"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Page"></see>
    /// </summary>
    let Page = _prefix "Page"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#READOperation"></see>
    /// </summary>
    let READOperation = _prefix "READOperation"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Radiobutton"></see>
    /// </summary>
    let Radiobutton = _prefix "Radiobutton"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#Textbox"></see>
    /// </summary>
    let Textbox = _prefix "Textbox"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#UPDATEOperation"></see>
    /// </summary>
    let UPDATEOperation = _prefix "UPDATEOperation"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#WidgetContainer"></see>
    /// </summary>
    let WidgetContainer = _prefix "WidgetContainer"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#action"></see>
    /// </summary>
    let action = _prefix "action"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#checked"></see>
    /// </summary>
    let checked_ = _prefix "checked"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#class"></see>
    /// </summary>
    let class_ = _prefix "class"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#command"></see>
    /// </summary>
    let command = _prefix "command"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#disabled"></see>
    /// </summary>
    let disabled = _prefix "disabled"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#group"></see>
    /// </summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#hidden"></see>
    /// </summary>
    let hidden = _prefix "hidden"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#isPassword"></see>
    /// </summary>
    let isPassword = _prefix "isPassword"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#label"></see>
    /// </summary>
    let label = _prefix "label"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#list"></see>
    /// </summary>
    let list = _prefix "list"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#maxlength"></see>
    /// </summary>
    let maxlength = _prefix "maxlength"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#method"></see>
    /// </summary>
    let method = _prefix "method"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#multiple"></see>
    /// </summary>
    let multiple = _prefix "multiple"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#row"></see>
    /// </summary>
    let row = _prefix "row"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#selected"></see>
    /// </summary>
    let selected = _prefix "selected"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#size"></see>
    /// </summary>
    let size = _prefix "size"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://purl.org/NET/raul#value"></see>
    /// </summary>
    let value = _prefix "value"

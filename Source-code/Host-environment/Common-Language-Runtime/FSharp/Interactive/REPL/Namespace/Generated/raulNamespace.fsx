#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module raul =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/NET/raul#" "raul"
    /// <summary>
    ///   <para>rdfs:label : Button^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Button">raul:Button</a>
    /// </summary>
    let Button = _prefixId.prefix "Button"
    /// <summary>
    ///   <para>rdfs:label : CREATEOperation^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#CREATEOperation">raul:CREATEOperation</a>
    /// </summary>
    let CREATEOperation = _prefixId.prefix "CREATEOperation"
    /// <summary>
    ///   <para>rdfs:label : CRUDOperation^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#CRUDOperation">raul:CRUDOperation</a>
    /// </summary>
    let CRUDOperation = _prefixId.prefix "CRUDOperation"
    /// <summary>
    ///   <para>rdfs:label : Checkbox^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Checkbox">raul:Checkbox</a>
    /// </summary>
    let Checkbox = _prefixId.prefix "Checkbox"
    /// <summary>
    ///   <para>rdfs:label : DELETEOperation^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#DELETEOperation">raul:DELETEOperation</a>
    /// </summary>
    let DELETEOperation = _prefixId.prefix "DELETEOperation"
    /// <summary>
    ///   <para>rdfs:label : DynamicGroup^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#DynamicGroup">raul:DynamicGroup</a>
    /// </summary>
    let DynamicGroup = _prefixId.prefix "DynamicGroup"
    /// <summary>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Group">raul:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Listbox^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Listbox">raul:Listbox</a>
    /// </summary>
    let Listbox = _prefixId.prefix "Listbox"
    /// <summary>
    ///   <para>rdfs:label : Listitem^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Listitem">raul:Listitem</a>
    /// </summary>
    let Listitem = _prefixId.prefix "Listitem"
    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Page">raul:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : READOperation^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#READOperation">raul:READOperation</a>
    /// </summary>
    let READOperation = _prefixId.prefix "READOperation"
    /// <summary>
    ///   <para>rdfs:label : Radiobutton^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Radiobutton">raul:Radiobutton</a>
    /// </summary>
    let Radiobutton = _prefixId.prefix "Radiobutton"
    /// <summary>
    ///   <para>rdfs:label : Textbox^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Textbox">raul:Textbox</a>
    /// </summary>
    let Textbox = _prefixId.prefix "Textbox"
    /// <summary>
    ///   <para>rdfs:label : UPDATEOperation^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#UPDATEOperation">raul:UPDATEOperation</a>
    /// </summary>
    let UPDATEOperation = _prefixId.prefix "UPDATEOperation"
    /// <summary>
    ///   <para>rdfs:label : Widget^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#Widget">raul:Widget</a>
    /// </summary>
    let Widget = _prefixId.prefix "Widget"
    /// <summary>
    ///   <para>rdfs:label : WidgetContainer^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#WidgetContainer">raul:WidgetContainer</a>
    /// </summary>
    let WidgetContainer = _prefixId.prefix "WidgetContainer"
    /// <summary>
    ///   <para>rdfs:label : action^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#action">raul:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>rdfs:label : checked^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#checked">raul:checked</a>
    /// </summary>
    let checked_ = _prefixId.prefix "checked"
    /// <summary>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#class">raul:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : command^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#command">raul:command</a>
    /// </summary>
    let command = _prefixId.prefix "command"
    /// <summary>
    ///   <para>rdfs:label : disabled^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#disabled">raul:disabled</a>
    /// </summary>
    let disabled = _prefixId.prefix "disabled"
    /// <summary>
    ///   <para>rdfs:label : group^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#group">raul:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : hidden^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#hidden">raul:hidden</a>
    /// </summary>
    let hidden = _prefixId.prefix "hidden"
    /// <summary>
    ///   <para>rdfs:label : id^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#id">raul:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : isPassword^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#isPassword">raul:isPassword</a>
    /// </summary>
    let isPassword = _prefixId.prefix "isPassword"
    /// <summary>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#label">raul:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : list^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#list">raul:list</a>
    /// </summary>
    let list = _prefixId.prefix "list"
    /// <summary>
    ///   <para>rdfs:label : maxlength^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#maxlength">raul:maxlength</a>
    /// </summary>
    let maxlength = _prefixId.prefix "maxlength"
    /// <summary>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#method">raul:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>rdfs:label : multiple^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#multiple">raul:multiple</a>
    /// </summary>
    let multiple = _prefixId.prefix "multiple"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#name">raul:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : row^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#row">raul:row</a>
    /// </summary>
    let row = _prefixId.prefix "row"
    /// <summary>
    ///   <para>rdfs:label : selected^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#selected">raul:selected</a>
    /// </summary>
    let selected = _prefixId.prefix "selected"
    /// <summary>
    ///   <para>rdfs:label : size^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#size">raul:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#title">raul:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://purl.org/NET/raul#value">raul:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"

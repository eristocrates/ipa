namespace http.purl.org.NET.raul.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module raul =
    let _namespace_iri = Namespace_Iri raul |> NamespaceIRI
    /// <summary>
    ///   <para>raul:CREATEOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>CREATEOperation</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#CREATEOperation">http://purl.org/NET/raul#CREATEOperation</seealso>
    let CREATEOperation = Prefixed_Name(raul, "CREATEOperation") |> PrefixedName
    /// <summary>
    ///   <para>raul:CRUDOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CRUDOperation</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#CRUDOperation">http://purl.org/NET/raul#CRUDOperation</seealso>
    let CRUDOperation = Prefixed_Name(raul, "CRUDOperation") |> PrefixedName
    /// <summary>
    ///   <para>raul:command</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>command</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#command">http://purl.org/NET/raul#command</seealso>
    let command = Prefixed_Name(raul, "command") |> PrefixedName
    /// <summary>
    ///   <para>raul:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>group</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#group">http://purl.org/NET/raul#group</seealso>
    let group = Prefixed_Name(raul, "group") |> PrefixedName
    /// <summary>
    ///   <para>raul:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#id">http://purl.org/NET/raul#id</seealso>
    let id = Prefixed_Name(raul, "id") |> PrefixedName
    /// <summary>
    ///   <para>raul:list</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>list</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#list">http://purl.org/NET/raul#list</seealso>
    let list = Prefixed_Name(raul, "list") |> PrefixedName
    /// <summary>
    ///   <para>raul:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#name">http://purl.org/NET/raul#name</seealso>
    let name = Prefixed_Name(raul, "name") |> PrefixedName
    /// <summary>
    ///   <para>raul:Widget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Widget</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Widget">http://purl.org/NET/raul#Widget</seealso>
    let Widget = Prefixed_Name(raul, "Widget") |> PrefixedName
    /// <summary>
    ///   <para>raul:DELETEOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DELETEOperation</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#DELETEOperation">http://purl.org/NET/raul#DELETEOperation</seealso>
    let DELETEOperation = Prefixed_Name(raul, "DELETEOperation") |> PrefixedName
    /// <summary>
    ///   <para>raul:Listbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Listbox</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Listbox">http://purl.org/NET/raul#Listbox</seealso>
    let Listbox = Prefixed_Name(raul, "Listbox") |> PrefixedName
    /// <summary>
    ///   <para>raul:READOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>READOperation</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#READOperation">http://purl.org/NET/raul#READOperation</seealso>
    let READOperation = Prefixed_Name(raul, "READOperation") |> PrefixedName
    /// <summary>
    ///   <para>raul:UPDATEOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UPDATEOperation</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#UPDATEOperation">http://purl.org/NET/raul#UPDATEOperation</seealso>
    let UPDATEOperation = Prefixed_Name(raul, "UPDATEOperation") |> PrefixedName
    /// <summary>
    ///   <para>raul:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Group">http://purl.org/NET/raul#Group</seealso>
    let Group = Prefixed_Name(raul, "Group") |> PrefixedName
    /// <summary>
    ///   <para>raul:Listitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Listitem</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Listitem">http://purl.org/NET/raul#Listitem</seealso>
    let Listitem = Prefixed_Name(raul, "Listitem") |> PrefixedName
    /// <summary>
    ///   <para>raul:Radiobutton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Radiobutton</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Radiobutton">http://purl.org/NET/raul#Radiobutton</seealso>
    let Radiobutton = Prefixed_Name(raul, "Radiobutton") |> PrefixedName
    /// <summary>
    ///   <para>raul:DynamicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>DynamicGroup</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#DynamicGroup">http://purl.org/NET/raul#DynamicGroup</seealso>
    let DynamicGroup = Prefixed_Name(raul, "DynamicGroup") |> PrefixedName
    /// <summary>
    ///   <para>raul:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Page</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Page">http://purl.org/NET/raul#Page</seealso>
    let Page = Prefixed_Name(raul, "Page") |> PrefixedName
    /// <summary>
    ///   <para>raul:Textbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Textbox</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Textbox">http://purl.org/NET/raul#Textbox</seealso>
    let Textbox = Prefixed_Name(raul, "Textbox") |> PrefixedName
    /// <summary>
    ///   <para>raul:WidgetContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>WidgetContainer</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#WidgetContainer">http://purl.org/NET/raul#WidgetContainer</seealso>
    let WidgetContainer = Prefixed_Name(raul, "WidgetContainer") |> PrefixedName
    /// <summary>
    ///   <para>raul:checked</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>checked</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#checked">http://purl.org/NET/raul#checked</seealso>
    let checked_ = Prefixed_Name(raul, "checked") |> PrefixedName
    /// <summary>
    ///   <para>raul:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>action</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#action">http://purl.org/NET/raul#action</seealso>
    let action = Prefixed_Name(raul, "action") |> PrefixedName
    /// <summary>
    ///   <para>raul:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>class</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#class">http://purl.org/NET/raul#class</seealso>
    let class_ = Prefixed_Name(raul, "class") |> PrefixedName
    /// <summary>
    ///   <para>raul:disabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>disabled</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#disabled">http://purl.org/NET/raul#disabled</seealso>
    let disabled = Prefixed_Name(raul, "disabled") |> PrefixedName
    /// <summary>
    ///   <para>raul:isPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>isPassword</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#isPassword">http://purl.org/NET/raul#isPassword</seealso>
    let isPassword = Prefixed_Name(raul, "isPassword") |> PrefixedName
    /// <summary>
    ///   <para>raul:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#label">http://purl.org/NET/raul#label</seealso>
    let label = Prefixed_Name(raul, "label") |> PrefixedName
    /// <summary>
    ///   <para>raul:hidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>hidden</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#hidden">http://purl.org/NET/raul#hidden</seealso>
    let hidden = Prefixed_Name(raul, "hidden") |> PrefixedName
    /// <summary>
    ///   <para>raul:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>method</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#method">http://purl.org/NET/raul#method</seealso>
    let method = Prefixed_Name(raul, "method") |> PrefixedName
    /// <summary>
    ///   <para>raul:multiple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>multiple</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#multiple">http://purl.org/NET/raul#multiple</seealso>
    let multiple = Prefixed_Name(raul, "multiple") |> PrefixedName
    /// <summary>
    ///   <para>raul:maxlength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maxlength</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#maxlength">http://purl.org/NET/raul#maxlength</seealso>
    let maxlength = Prefixed_Name(raul, "maxlength") |> PrefixedName
    /// <summary>
    ///   <para>raul:row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>row</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#row">http://purl.org/NET/raul#row</seealso>
    let row = Prefixed_Name(raul, "row") |> PrefixedName
    /// <summary>
    ///   <para>raul:selected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>selected</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#selected">http://purl.org/NET/raul#selected</seealso>
    let selected = Prefixed_Name(raul, "selected") |> PrefixedName
    /// <summary>
    ///   <para>raul:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>size</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#size">http://purl.org/NET/raul#size</seealso>
    let size = Prefixed_Name(raul, "size") |> PrefixedName
    /// <summary>
    ///   <para>raul:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>title</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#title">http://purl.org/NET/raul#title</seealso>
    let title = Prefixed_Name(raul, "title") |> PrefixedName
    /// <summary>
    ///   <para>raul:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#value">http://purl.org/NET/raul#value</seealso>
    let value = Prefixed_Name(raul, "value") |> PrefixedName
    /// <summary>
    ///   <para>raul:Button</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Button</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Button">http://purl.org/NET/raul#Button</seealso>
    let Button = Prefixed_Name(raul, "Button") |> PrefixedName
    /// <summary>
    ///   <para>raul:Checkbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Checkbox</para></remarks>
    /// <seealso href="http://purl.org/NET/raul#Checkbox">http://purl.org/NET/raul#Checkbox</seealso>
    let Checkbox = Prefixed_Name(raul, "Checkbox") |> PrefixedName

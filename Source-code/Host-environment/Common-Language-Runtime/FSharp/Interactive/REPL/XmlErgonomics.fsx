#load @".paket/load/main.group.fsx"

open System.Xml.Schema
open System.Xml

let xsdInference = XmlSchemaInference()
let LitXmlWriterSettings = new XmlWriterSettings()
LitXmlWriterSettings.Indent <- true
LitXmlWriterSettings.OmitXmlDeclaration <- true
LitXmlWriterSettings.NewLineOnAttributes <- false

type LitXml.ElementBuilder with 
    
    static member writeToXmlDocs (elements:LitXml.Element array) :string array= 

        elements
        |> Array.collect (fun element -> LitXml.ElementBuilder.writeToStringWith LitXmlWriterSettings element |> _.Split("\n"))


module XmlDocumentationComment = 
    open LitXml
    let _href (reference:string) = attr "href" reference
    let a: ElementBuilder = elem "a"
    /// §D.3.2	Set text in a code-like font
    let c: ElementBuilder = elem "c"
    /// §D.3.3	Set one or more lines of source code or program output
    let code : ElementBuilder = elem "code"
    /// §D.3.4	Indicate an example
    let example : ElementBuilder = elem "example"
    /// §D.3.5	Identifies the exceptions a method can throw
    let exception_ : ElementBuilder = elem "exception"
    /// §D.3.6	Includes XML from an external file
    let include_ : ElementBuilder = elem "include"
    /// §D.3.7	Create a list or table
    let list_ : ElementBuilder = elem "list"
    /// §D.3.8	Permit structure to be added to text
    let para : ElementBuilder = elem "para"
    /// §D.3.9	Describe a parameter for a method or constructor
    let param : ElementBuilder = elem "param"
    /// §D.3.10	Identify that a word is a parameter name
    let paramref : ElementBuilder = elem "paramref"
    /// §D.3.11	Document the security accessibility of a member
    let permission : ElementBuilder = elem "permission"
    /// §D.3.12	Describe additional information about a type
    let remarks : ElementBuilder = elem "remarks"
    /// §D.3.13	Describe the return value of a method
    let returns : ElementBuilder = elem "returns"
    /// §D.3.14	Specify a link
    let see : ElementBuilder = elem "see"
    /// §D.3.15	Generate a See Also entry
    let seealso : ElementBuilder = elem "seealso"
    /// §D.3.16	Describe a type or a member of a type
    let summary : ElementBuilder = elem "summary"
    /// §D.3.17	Describe a type parameter for a generic type or method
    let typeparam : ElementBuilder = elem "typeparam"
    /// §D.3.18	Identify that a word is a type parameter name
    let typeparamref : ElementBuilder = elem "typeparamref"
    /// §D.3.19	Describe a property
    let value : ElementBuilder = elem "value"

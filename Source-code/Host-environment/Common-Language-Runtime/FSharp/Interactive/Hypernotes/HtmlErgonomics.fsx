open System
open System.IO

#r "nuget: FSharp.ViewEngine"
open FSharp.ViewEngine
open type Html
open type Svg


module Render =
    let toHtmlFile (html_path: string) (html_element: HtmlElement) =
        let parent_directory = Path.GetDirectoryName(html_path)

        Directory.CreateDirectory(parent_directory)
        |> ignore

        let html_content = Render.toHtmlDocString html_element
        File.WriteAllText(html_path, html_content)






type Html with
    // static member myCard = TagBuilder("my-card")

    /// a SafeCURIEorCURIEorIRI, used for stating what the data is about (a 'subject' in RDF terminology);
    static member inline _about(value: string) =
        { Name = "about"
          Value = ValueSome value }

    /// a CDATA string, for supplying machine-readable content for a literal (a 'literal object', in RDF terminology);
    static member inline _content(value: string) =
        { Name = "content"
          Value = ValueSome value }

    /// a TERMorCURIEorAbsIRI representing a datatype, to express the datatype of a literal;
    static member inline _datatype(value: string) =
        { Name = "datatype"
          Value = ValueSome value }

    /// a traditionally navigable IRI for expressing the partner resource of a relationship (a 'resource object', in RDF terminology);
    static member inline _href(value: string) =
        { Name = "href"
          Value = ValueSome value }

    /// An attribute used to indicate that the object associated with a rel or property attribute on the same element is to be added to the list for that predicate. The value of this attribute MUST be ignored. Presence of this attribute causes a list to be created if it does not already exist.
    static member inline _inlist(value: string) =
        { Name = "inlist"
          Value = ValueSome value }

    /// a white space separated list of prefix-name IRI pairs of the form NCName ':' ' '+ xsd:anyURI
    static member inline _prefix(value: string) =
        { Name = "prefix"
          Value = ValueSome value }

    /// a white space separated list of TERMorCURIEorAbsIRIs, used for expressing relationships between a subject and either a resource object if given or some literal text (also a 'predicate');
    static member inline _property(value: string) =
        { Name = "property"
          Value = ValueSome value }

    /// a white space separated list of TERMorCURIEorAbsIRIs, used for expressing relationships between two resources ('predicates' in RDF terminology);
    static member inline _rel(value: string) =
        { Name = "rel"
          Value = ValueSome value }

    /// a SafeCURIEorCURIEorIRI for expressing the partner resource of a relationship that is not intended to be navigable (e.g., a 'clickable' link) (also an 'object');
    static member inline _resource(value: string) =
        { Name = "resource"
          Value = ValueSome value }

    /// a white space separated list of TERMorCURIEorAbsIRIs, used for expressing reverse relationships between two resources (also 'predicates');
    static member inline _rev(value: string) =
        { Name = "rev"
          Value = ValueSome value }

    /// an IRI for expressing the partner resource of a relationship when the resource is embedded (also a 'resource object');
    static member inline _src(value: string) =
        { Name = "src"
          Value = ValueSome value }

    /// a white space separated list of TERMorCURIEorAbsIRIs that indicate the RDF type(s) to associate with a subject;
    static member inline _typeof(value: string) =
        { Name = "typeof"
          Value = ValueSome value }

    /// an IRI that defines the mapping to use when a TERM is referenced in an attribute value. See General Use of Terms in Attributes and the section on Vocabulary Expansion.
    static member inline _vocab(value: string) =
        { Name = "vocab"
          Value = ValueSome value }










/// https://www.w3.org/TR/rdfa-core/#s_syntax
module rdfa =

    ///a SafeCURIEorCURIEorIRI, used for stating what the data is about (a 'subject' in RDF terminology);
    let about = Html._about
    ///a CDATA string, for supplying machine-readable content for a literal (a 'literal object', in RDF terminology);
    let content = Html._content
    ///a TERMorCURIEorAbsIRI representing a datatype, to express the datatype of a literal;
    let datatype = Html._datatype
    ///a traditionally navigable IRI for expressing the partner resource of a relationship (a 'resource object', in RDF terminology);
    let href = Html._href
    ///An attribute used to indicate that the object associated with a rel or property attribute on the same element is to be added to the list for that predicate. The value of this attribute MUST be ignored. Presence of this attribute causes a list to be created if it does not already exist.
    let inlist = Html._inlist
    ///a white space separated list of prefix-name IRI pairs of the form NCName ':' ' '+ xsd:anyURI
    let prefix = Html._prefix
    ///a white space separated list of TERMorCURIEorAbsIRIs, used for expressing relationships between a subject and either a resource object if given or some literal text (also a 'predicate');
    let property = Html._property
    ///a white space separated list of TERMorCURIEorAbsIRIs, used for expressing relationships between two resources ('predicates' in RDF terminology);
    let rel = Html._rel
    ///a SafeCURIEorCURIEorIRI for expressing the partner resource of a relationship that is not intended to be navigable (e.g., a 'clickable' link) (also an 'object');
    let resource = Html._resource
    ///a white space separated list of TERMorCURIEorAbsIRIs, used for expressing reverse relationships between two resources (also 'predicates');
    let rev = Html._rev
    ///an IRI for expressing the partner resource of a relationship when the resource is embedded (also a 'resource object');
    let src = Html._src
    ///a white space separated list of TERMorCURIEorAbsIRIs that indicate the RDF type(s) to associate with a subject;
    let typeof = Html._typeof
    ///an IRI that defines the mapping to use when a TERM is referenced in an attribute value. See General Use of Terms in Attributes and the section on Vocabulary Expansion.
    let vocab = Html._vocab














let test_html =
    html {
        _lang "en-US"

        head {
            meta {
                _charset "utf-8"
                _name "viewport"
                _content "width=device-width, initial-scale=1.0"
            }

            title "title"
        }

        body {
            rdfa.vocab "http://purl.org/dc/terms/"
            h1 { "The Basics of RDFA: RDFa Lite" }

            h2 {
                _property "title"
                "The Trouble with Bob"
            }

            p {
                span {
                    _property "created"
                    "Date: 2011-09-10"
                }
            }

            div {
                p {
                    "Alice Birpemswick, Email: "

                    a {
                        _href "mailto:alice@example.com"
                        "alice@example.com "
                    }

                    "Phone: "

                    a {
                        _href "tel:+1-617-555-7332"
                        "+1 617.555.7332"
                    }
                }
            }

            div {
                rdfa.resource "/alice/posts/trouble_with_bob"

                h2 {
                    rdfa.property "title"
                    "The trouble with bob"
                }

                p {
                    "Date:"

                    span {
                        rdfa.property "created"
                        "2011-09-10"
                    }
                }
            }





            p {
                "All content on this site is licensed under"

                a {
                    _property "http://creativecommons.org/ns#license"
                    _href "http://creativecommons.org/licenses/by/3.0/"
                    "a Creative Commons License."
                }

                "©2011 Alice Birpemswick."
            }
        }
    }

let current_directory_path filename =
    Path.Combine(__SOURCE_DIRECTORY__, filename)

let html_path = current_directory_path "test.html"

test_html |> Render.toHtmlFile html_path

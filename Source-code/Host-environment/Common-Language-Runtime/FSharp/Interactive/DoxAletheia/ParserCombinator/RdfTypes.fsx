#time on

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics


#r "nuget: XParsec"
open XParsec
open XParsec.Combinators

#r "nuget: NeatIntervals"
#r "nuget: FRange"

#r "nuget: UUIDNext"
open UUIDNext
open UUIDNext.Tools

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\ParserCombinator\bin\Release\net10.0"
#r "Ergonomic_Extensions.dll"
#r "ParserCombinator.dll"
#r "Unicodepoint.dll"
#r "Interval_Range.dll"
#r "ResourceIdentifier.dll"
open DoxAletheia

// TODO next adjust to renamed code point/line/square functions


open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayExtensions
open ByteExtensions
open XParsec.Parsers
open Interval_Range
open ParserCombinator.Data
open ParserCombinator.ResourceIdentifier
open Rfc_Types
open Code_Point_Rule
open Code_Line_Rule
let current_directory_file_path (file_name:string) = Path.Combine(__SOURCE_DIRECTORY__,file_name)








fsi.AddPrinter<Absolute_IRI>(fun absolute_iri -> absolute_iri.fsi_printer)
fsi.AddPrinter<Authority>(fun authority -> authority.fsi_printer)
fsi.AddPrinter<Fragment>(fun fragment -> fragment.fsi_printer)
fsi.AddPrinter<Hextet>(fun hextet -> hextet.fsi_printer)
fsi.AddPrinter<Hierarchical_Part>(fun hierarchical_part -> hierarchical_part.fsi_printer)
fsi.AddPrinter<Host>(fun host -> host.fsi_printer)
fsi.AddPrinter<IP_Literal>(fun ip_literal -> ip_literal.fsi_printer)
fsi.AddPrinter<IPv4_Address>(fun ipv4_address -> ipv4_address.fsi_printer)
fsi.AddPrinter<IPv6_Address>(fun ipv6_address -> ipv6_address.fsi_printer)
fsi.AddPrinter<IPvFuture>(fun ipvfuture -> ipvfuture.fsi_printer)
fsi.AddPrinter<IRI>(fun iri -> iri.fsi_printer)
fsi.AddPrinter<Least_Significant_32_Bits>(fun least_significant_32_bits -> least_significant_32_bits.fsi_printer)
fsi.AddPrinter<Nonzero_Noncolon_Segment>(fun nonzero_noncolon_segment -> nonzero_noncolon_segment.fsi_printer)
fsi.AddPrinter<Nonzero_Segment>(fun nonzero_segment -> nonzero_segment.fsi_printer)
fsi.AddPrinter<Octet>(fun octet -> octet.fsi_printer)
fsi.AddPrinter<Path_Abempty>(fun path_abempty -> path_abempty.fsi_printer)
fsi.AddPrinter<Path_Absolute>(fun path_absolute -> path_absolute.fsi_printer)
fsi.AddPrinter<Path_Noscheme>(fun path_noscheme -> path_noscheme.fsi_printer)
fsi.AddPrinter<Path_Rootless>(fun path_rootless -> path_rootless.fsi_printer)
fsi.AddPrinter<Query>(fun query -> query.fsi_printer)
fsi.AddPrinter<Registered_Name>(fun registered_name -> registered_name.fsi_printer)
fsi.AddPrinter<Relative_Part>(fun relative_part -> relative_part.fsi_printer)
fsi.AddPrinter<Relative_Reference>(fun relative_reference -> relative_reference.fsi_printer)
fsi.AddPrinter<Scheme>(fun scheme -> scheme.fsi_printer)
fsi.AddPrinter<Segment>(fun segment -> segment.fsi_printer)
fsi.AddPrinter<Userinfo>(fun userinfo -> userinfo.fsi_printer)













[<RequireQualifiedAccess>]
type Language_Tag = 
    | en
[<RequireQualifiedAccess>]
type Region_Subtag = 
    | US

type Rdf_Triple =
    { curSubject: Rdf_Subject
      curPredicate: Rdf_Predicate
      curObject: Rdf_Object }
    member this.as_object = this |> TripleTerm |> TripleTermObject

and Rdf_Quad =
    { triple: Rdf_Triple
      curGraph: Rdf_Subject option }
and Rdf_Subject = 
    | IRIREFSubject of IRIREF
    | BlankNodeSubject of Blank_Node

and Rdf_Predicate = 
    | IRIREFPredicate of IRIREF
and Rdf_Object = 
    | IRIREFObject of IRIREF
    | BlankNodeObject of Blank_Node
    | LiteralObject of Rdf_Literal
    | TripleTermObject of Triple_Term
and PredicateObjectList = 
    {

      verb: Rdf_Predicate
      objectLists: ObjectList array

     }

and ObjectList =
    { rdf_object: Rdf_Object
      annotations: Annotation array }

and Annotation =
    | AnnotationReifier of Rdf_Subject
    | AnnotationBlock of PredicateObjectList
and Triple_Term = 
    | TripleTerm of Rdf_Triple
    member this.as_object  = TripleTermObject this

and IRIREF =
    | NamespacedName of Namespaced_IRI
    | SkolemIRIREF of Skolem_IRI
    | IRIREF of IRI
    | RelativeReference of Relative_Reference
    member this.as_subject = IRIREFSubject this
    member this.as_predicate = IRIREFPredicate this
    member this.as_object = IRIREFObject this

     static member parser :Parser<IRIREF, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    return! 
                        choice [

                                IRI.parser |>> IRIREF
                                Relative_Reference.parser |>> RelativeReference
                    
                            ]

                
                }
    static member metasyntax = 
        """
            IRI-reference  = IRI / irelative-ref
            URI-reference = URI / relative-ref

        """

    static member parse (input_string:string) =  
        match IRIREF.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IRIREF.metasyntax}"
     member this.as_code_square = 
        match this with 
        | IRIREF uri -> uri.as_code_square
        | SkolemIRIREF uri -> uri.as_code_square
        | NamespacedName namespaced_iri -> namespaced_iri.as_code_square
        | RelativeReference relative_ref -> relative_ref.as_code_square
    member this.iri_id() = data_store.iri_id_from_code_square this.as_code_square
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | IRIREF uri -> "<" + uri.as_rendered_string + ">"
        | SkolemIRIREF uri -> "<" + uri.as_rendered_string + ">"
        | NamespacedName namespaced_iri -> "<" + namespaced_iri.as_rendered_string + ">"
        | RelativeReference relative_ref -> "<" + relative_ref.as_rendered_string + ">"

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings

    
and  Blank_Node =
    | BlankNodeIdentifier of identifier: string
    | BlankNodePropertyList of identifier: string * predicateObjectList: PredicateObjectList
    
    member this.as_subject = BlankNodeSubject this
    member this.as_object = BlankNodeObject this
and  Rdf_Literal =
    | SimpleLiteral of lexical_form: string
    | LongLiteral of lexical_form: string
    | DatatypedLiteral of lexical_form: string * datatype: IRIREF
    | LanguageString of lexical_form: string * language: Language_Tag
    | RegionString of lexical_form: string * language: Language_Tag * region: Region_Subtag
    | DirectedLanguageString of lexical_form: string * language: Language_Tag * base_direction: Initial_Text_Direction
    | DirectedRegionString of
        lexical_form: string *
        language: Language_Tag *
        region: Region_Subtag *
        base_direction: Initial_Text_Direction

    member this.lexical_form =
        match this with
        | SimpleLiteral lexical_form -> lexical_form
        | LongLiteral lexical_form -> lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> lexical_form
        | LanguageString (lexical_form, language) -> lexical_form
        | RegionString (lexical_form, language, region) -> lexical_form
        | DirectedLanguageString (lexical_form, language, base_direction) -> lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) -> lexical_form
    member this.as_object = LiteralObject this

and  Initial_Text_Direction =
    | Ltr
    | Rtl
and Skolem_IRI = 
    | SkolemIRI of IRIREF * Guid
    member this.well_known_iriref = 
        match this with 
        | SkolemIRI(well_known_stem,uuid) -> well_known_stem
    member this.uuid = 
        match this with 
        | SkolemIRI(well_known_stem,uuid) -> uuid
    member this.as_code_square = 
        Array.concat [|
             this.well_known_iriref.as_code_square
             [|this.uuid.ToString("N").as_code_line|]
             |]

    member this.as_subject = this |> SkolemIRIREF |> IRIREFSubject
    member this.as_predicate = this |> SkolemIRIREF |> IRIREFPredicate
    member this.as_object = this |> SkolemIRIREF |> IRIREFObject
    member this.as_rendered_string = 
        match this with 
        | SkolemIRI(well_known_stem,uuid) -> well_known_stem.as_rendered_string + uuid.ToString("N")
and Namespaced_IRI = 
    private
    | NamespacedIRI of IRIREF * Local_Name
    member this.namespace_iriref = 
        match this with 
        | NamespacedIRI(namespace_name,local_name) -> namespace_name
    
    member this.local_name = 
        match this with 
        | NamespacedIRI(namespace_name,local_name) -> local_name

    static member metasyntax = 
        """
    
            IRIREF            ::=  '<' ([^#x00-#x20<>"{}|^`\] | UCHAR)* '>' /* #x00=NULL #01-#x1F=control codes #x20=space */
            PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?

        """

    static member parse (namespace_name_input:string)(local_name_input:string) =  
        let namespace_name = 
            match IRIREF.parser namespace_name_input.as_parser_input with 
            | Ok success -> success
            | Error failure -> failwith $"{failure} : {code_line_message namespace_name_input.as_code_line  IRIREF.metasyntax}"
        let local_name = 
            match Local_Name.parser local_name_input.as_parser_input   with 
            | Ok success -> success
            | Error failure -> failwith $"{failure} : {code_line_message local_name_input.as_code_line  PN_LOCAL.metasyntax}"
        NamespacedIRI(namespace_name,local_name)
     member this.as_code_square = 
        match this with 
        | NamespacedIRI(namespace_name,local_name) -> 
            Array.concat [|
                namespace_name.as_code_square
                local_name.as_code_square
                |]
    member this.iri_id() = data_store.iri_id_from_code_square this.as_code_square
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | NamespacedIRI(namespace_name,local_name) -> namespace_name.as_rendered_string + local_name.as_rendered_string
    member this.as_subject = this |> NamespacedName |> IRIREFSubject
    member this.as_predicate = this |> NamespacedName |> IRIREFPredicate
    member this.as_object = this |> NamespacedName |> IRIREFObject

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings

and Local_Name = 

         private
         | LocalName of PN_LOCAL
         | LocalPath of Path_Rootless
         static member parser :Parser<Local_Name, Code_Point, unit, ReadableMemory<Code_Point>> = 
                    parser {  
                            return! choice [
                                PN_LOCAL.parser |>> LocalName
                                Path_Rootless.parser |>> LocalPath
                            ]

                        }
         static member metasyntax = 
                                      """
                                      PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                      ipath-rootless = isegment-nz *( "/" isegment )
                                      """ 
         static member parse (input_string:string) =  
            match Local_Name.parser input_string.as_parser_input with 
            | Ok success ->  success 
            | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Local_Name.metasyntax}"
         member this.as_code_square = 
            match this with 
            | LocalName pn_local  -> [|pn_local.as_code_line|]
            | LocalPath path_rootless -> path_rootless.as_code_square
         member this.local_name_id() = data_store.local_name_id_from_code_square this.as_code_square
         member this.as_raw_strings = this.as_code_square |> Strings.from_code_square
         member this.as_rendered_string = 
     
            match this with 
            | LocalName pn_local  -> pn_local.as_rendered_string
            | LocalPath path_rootless -> path_rootless.as_rendered_string

         member this.fsi_printer = 
            let unames = Code_Square.Unames this.as_code_square
            sprintf "%A %A ``%A``" this unames  this.as_raw_strings

and PN_LOCAL  =
     private
     | PN_LOCAL of Code_Line
     static member parser :Parser<PN_LOCAL, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {  

                    let! head = 
                        choice [

                            pn_chars_u.code_point_parser
                            parse_char ':'
                            any_point_from_interval Unicodepoint.Partition.Ascii_Digits

                        ]
                    let! maybe_tail = opt (

                        many (choice [
                            pn_chars.code_point_parser
                            parse_char '.'
                            parse_char ':'
                        ])
                    )
                    return
                        match maybe_tail with 
                        | ValueNone -> PN_LOCAL [|head|]
                        | ValueSome immutable_code_line -> 
                            immutable_code_line
                            |> Code_Line.from_immutable_code_line
                            |> Array.insertAt 0 head 
                            |> PN_LOCAL

                }
     static member metasyntax = 
                                  """
                                  PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                  """ 
     static member parse (input_string:string) =  
        match PN_LOCAL.parser input_string.as_parser_input with 
        | Ok (PN_LOCAL false_positive) when false_positive[false_positive.last_index] = int '.'  ->  failwith $"false positive for {input_string}, cannot end with full stop ``.`` : {code_line_message input_string.as_code_line  PN_LOCAL.metasyntax}" 
        | Ok success -> 
            success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  PN_LOCAL.metasyntax}"
     member this.as_code_line = 
        match this with 
        | PN_LOCAL code_line -> code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     member this.legisign_id() = data_store.legisign_id_from_code_line this.as_code_line
     member this.as_rendered_string = this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string



fsi.AddPrinter<IRIREF>(fun iriref -> iriref.fsi_printer)
fsi.AddPrinter<Namespaced_IRI>(fun namespaced_iri -> namespaced_iri.fsi_printer)
fsi.AddPrinter<Local_Name>(fun local_name -> local_name.fsi_printer)
fsi.AddPrinter<IRIREF>(fun uri_reference -> uri_reference.fsi_printer)

fsi.AddPrinter<PN_LOCAL>(fun pn_local -> pn_local.fsi_printer)









type Rdf_Graph = { triples: Set<Rdf_Triple> }







let test_pn_local = PN_LOCAL.parse "type"


let test_hash_name = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
let test_slash_name = "http://xmlns.com/foaf/0.1/"



let rdf_type = Namespaced_IRI.parse  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" "type"
let foaf_Person = Namespaced_IRI.parse "http://xmlns.com/foaf/0.1/" "Person"

foaf_Person.local_name.as_rendered_string
foaf_Person.namespace_iriref.as_rendered_string


foaf_Person.iri_id()

rdf_type.iri_id()

let test_iris = 
    [|

        "http://example.com/"
        "https://example.com/path/to/resource"
        "ftp://ftp.example.com/pub/file.txt"
        "file:///etc/hosts"
        "mailto:john.doe@example.com"
        "urn:isbn:0451450523"
        "tel:+1-816-555-1212"
        "news:comp.infosystems.www.servers.unix"
        "data:text/plain;charset=utf-8,Hello%20World"
    |]
let test_iri_string = test_iris |> Array.randomChoice
let iris = test_iris |> Array.map (fun test_iri -> IRI.parse test_iri)

let random_iri = iris  |> Array.randomChoice
random_iri.iri_id()
let test_reg_name = "roboz0r.github.io"
Registered_Name.parser test_reg_name.as_parser_input
let test_scheme = Scheme.parse "https"

test_scheme.as_code_line




let test_iri = IRI.parse test_iri_string
test_iri.as_rendered_string

test_iri.scheme
test_iri.hierarchical_part
test_iri.maybe_query
test_iri.maybe_fragment







